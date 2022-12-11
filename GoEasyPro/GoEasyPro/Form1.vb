Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Newtonsoft.Json.Linq
Imports NativeWifi
Imports System.Text
Imports Windows.Devices.Bluetooth
Imports Windows.Devices.Bluetooth.Advertisement
Imports Windows.Storage.Streams
Imports Windows.Devices.Bluetooth.GenericAttributeProfile
Imports Windows.Foundation
Imports Windows.Devices.Enumeration

Public Class Form1
    Dim version As String = " V1.6.2"
    Dim camMac(3) As String
    Dim camSSIDs(3) As String
    Dim camWifiPW(3) As String
    Public comportname As String
    Public baudrate As Integer = 115200
    Dim _connected As Boolean = False
    Dim _recording As Boolean = False
    Dim readThread As New Thread(AddressOf Incoming_serial)
    Dim scannedPort As String = Nothing
    Dim lastSee As Date() = {DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now}
    Dim Udp As New UdpClient
    Public camsTBL As New DataTable 'Kamera SSIDs und Passwörter für WLAN-Direkt Verbindung
    Dim wifiClient = New WlanClient()
    Dim wifiIface As WlanClient.WlanInterface = wifiClient.Interfaces(0)
    Dim onClientList As New List(Of String)
    Dim recTime As TimeSpan
    Dim sdBoxes(3) As PictureBox
    Dim foundCams(3) As Boolean
    Dim connectedCam(3) As Boolean
    Dim incomingData As String = Nothing
    Dim onlines(3) As Boolean

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        StopHosting()
    End Sub

    Private Sub remoteOnOffBTN_Click(sender As Object, e As EventArgs) Handles remoteOnOffBTN.Click
        If _connected Then

            'Beende Hosting
            StopHosting()
        Else
            'Stelle Host für GoPros bereit
            StatusLabel1.Text = "Scanne nach COM-Port"

            StartHosting()
        End If

        'Switche Bild für Toggle-Button
        If _connected Then
            remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_on")
        Else
            remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_off")
        End If
    End Sub

    Private Sub StartHosting()
        If _connected = False Then

            If scannedPort Is Nothing Then
                comportname = AutoDetectArduino() 'for variable Port
            Else
                comportname = scannedPort
            End If

            If scannedPort = Nothing Then
                MsgBox("Hardware nicht gefunden. Anschluss prüfen und erneut versuchen.")
                StatusLabel1.Text = "Hardware nicht gefunden."
                StatusStrip1.Refresh()
                Exit Sub
            End If

            Try
                readThread = New Thread(AddressOf Incoming_serial)
                SerialPort1.PortName = comportname
                SerialPort1.BaudRate = baudrate
                AddHandler SerialPort1.DataReceived, AddressOf Incoming_serial
                SerialPort1.Open()
                readThread.Start()
                _connected = SerialPort1.IsOpen
                System.Threading.Thread.Sleep(1500)


                'watcher.ScanningMode = BluetoothLEScanningMode.Active
                '' Only activate the watcher when we're recieving values >= -80
                'watcher.SignalStrengthFilter.InRangeThresholdInDBm = -85
                '' Stop watching if the value drops below -90 (user walked away)
                'watcher.SignalStrengthFilter.OutOfRangeThresholdInDBm = -90
                '' Wait 5 seconds to make sure the device Is really out of range
                'watcher.SignalStrengthFilter.OutOfRangeTimeout = TimeSpan.FromMilliseconds(5000)
                'watcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(2000)
                '' Starting watching for advertisements
                'watcher.Start()

            Catch ex As Exception
                _connected = False
            End Try
        End If
        Application.DoEvents()

        If send_msg("<rc1>") Then
            _connected = True
            StatusLabel1.Text = "Fernbedinung AN"
        Else
            _connected = False
        End If
    End Sub

    Private Sub StopHosting()
        If _recording Then
            If send_msg("<sh0>") Then
                RecTimeTimer.Enabled = False
                Label6.Text = "Aufnahme"
                StartStopBtn.Image = My.Resources.rec_button
                RecListBox.Items.Add("Start: " & startTime_lbl.Text & ", Dauer: " & recTime.ToString)
                _recording = False
            End If
        End If

        Thread.Sleep(500)

        'disable BLE
        'watcher.Stop()

        If send_msg("<rc0>") Then
            While SerialPort1.IsOpen
                StopReader()
                SerialPort1.Close()
            End While
            _connected = False
            StatusLabel1.Text = "Fernbedinung AUS"
        Else
            While SerialPort1.IsOpen
                StopReader()
                SerialPort1.Close()
            End While
            _connected = False
            StatusLabel1.Text = "Fernbedinung AUS"
        End If
        'Switche Bild für Toggle-Button
        If _connected Then
            remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_on")
        Else
            remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_off")
        End If

        M1.ForeColor = Color.Gray
        ModePic1.Image = Nothing
        status1_lbl.Text = "Offline"
        stat1PB.Image = My.Resources.offline

        M2.ForeColor = Color.Gray
        ModePic2.Image = Nothing
        status2_lbl.Text = "Offline"
        stat2PB.Image = My.Resources.offline

        M3.ForeColor = Color.Gray
        ModePic3.Image = Nothing
        status3_lbl.Text = "Offline"
        stat3PB.Image = My.Resources.offline

        M4.ForeColor = Color.Gray
        ModePic4.Image = Nothing
        status4_lbl.Text = "Offline"
        stat4PB.Image = My.Resources.offline

        onClientList.Clear()
    End Sub

    Private Sub StopReader()
        Application.DoEvents()
        readThread.Join()
        RemoveHandler SerialPort1.DataReceived, AddressOf Incoming_serial
        Thread.Sleep(1000)
    End Sub

    Public Function send_msg(ByVal msg As String) As Boolean
        If _connected = True Then
            Try
                SerialPort1.Write(msg)
                Console.WriteLine("TX: " & msg)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Private Sub StartStopBtn_Click(sender As Object, e As EventArgs) Handles StartStopBtn.Click
        'Start/Stop Record
        If Not _recording Then
            If send_msg("<sh1>") Then
                startTime_lbl.Text = DateTime.Now.ToString("HH:mm:ss") & " Uhr"
                recTime = New TimeSpan
                RecTimeTimer.Enabled = True
                Label6.Text = "Stopp"
                StartStopBtn.Image = My.Resources.stop_button
                Thread.Sleep(200)
            End If
        Else
            If send_msg("<sh0>") Then
                RecTimeTimer.Enabled = False
                Label6.Text = "Aufnahme"
                StartStopBtn.Image = My.Resources.rec_button
                Dim titleString As String = ""
                If Not titelTB.Text = "" Then
                    titleString = titelTB.Text & ", "
                End If

                RecListBox.Items.Add(titleString & "Start: " & startTime_lbl.Text & ", Dauer: " & recTime.ToString)
            End If
        End If
    End Sub

    Private Sub Incoming_serial() ' Handles SerialPort.DataReceived


        Try
            'If SerialPort1.BytesToRead > 15 Then

            'incomingData = SerialPort1.ReadLine()

            Static Buffer As String

            Buffer += SerialPort1.ReadExisting

            Dim CrLfPos As Integer = InStr(Buffer, vbCrLf)

            If CrLfPos > 0 Then
                incomingData = Buffer.Substring(0, CrLfPos)
                Buffer = Mid(Buffer, CrLfPos + 2)   'clean up the Static buffer (data is double-buffered here)

                Me.BeginInvoke(Sub() ReceivedText(incomingData))
            End If


            'If incomingData IsNot Nothing Then
            '    Me.BeginInvoke(Sub() ReceivedText(incomingData))
            'End If


            'End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub OnlineTimer_Tick(sender As Object, e As EventArgs) Handles OnlineTimer.Tick
        Dim currentTime = DateTime.Now
        Dim timeOut As TimeSpan = TimeSpan.FromSeconds(10)
        Dim i As Integer = 0

        For Each seeing As Date In lastSee
            If currentTime - seeing > timeOut Or Not _connected Then
                'cam aus liste löschen und grau schreiben
                onClientList.Remove(camMac(i))
                Select Case i
                    Case 0
                        onlines(i) = False
                        M1.ForeColor = Color.Gray
                        ModePic1.Image = Nothing
                        status1_lbl.Text = "Offline"
                        stat1PB.Image = My.Resources.offline
                        c1BattLbl.Text = "---%"
                        c1DateLbl.Text = "Datum"
                    Case 1
                        onlines(i) = False
                        M2.ForeColor = Color.Gray
                        ModePic2.Image = Nothing
                        status2_lbl.Text = "Offline"
                        stat2PB.Image = My.Resources.offline
                        c2BattLbl.Text = "---%"
                        c2DateLbl.Text = "Datum"
                    Case 2
                        onlines(i) = False
                        M3.ForeColor = Color.Gray
                        ModePic3.Image = Nothing
                        status3_lbl.Text = "Offline"
                        stat3PB.Image = My.Resources.offline
                        c3BattLbl.Text = "---%"
                        c3DateLbl.Text = "Datum"
                    Case 3
                        onlines(i) = False
                        M4.ForeColor = Color.Gray
                        ModePic4.Image = Nothing
                        status4_lbl.Text = "Offline"
                        stat4PB.Image = My.Resources.offline
                        c4BattLbl.Text = "---%"
                        c4DateLbl.Text = "Datum"
                    Case 0 And 1 And 2 And 3
                        OnlineTimer.Enabled = False
                End Select
            End If
            i += 1
        Next
        'StatusReqTimer.Enabled = True
    End Sub

    Private Sub ReceivedText(ByVal text As String)
        Console.WriteLine("RX: " & text)

        If text.Contains("<rcOn>") Then
            If text.Contains("1") Then
                StatusLabel1.Text = "Fernbedienung gestartet"
            ElseIf text.Contains("0") Then
                'StatusLabel1.Text = "Fernbedinung AUS"
                'StopHosting()
            End If

            'Behandle Online-Meldung
        ElseIf text.Contains("<pw1>") Then

        ElseIf text.Contains("<BL>") Then
            Dim battLevel As String = text.Remove(0, text.IndexOf("<BL>") + 4)
            battLevel = battLevel.Remove(battLevel.IndexOf("</"), battLevel.Length - battLevel.IndexOf("</"))

            Dim CamMacF As String = text.Remove(0, text.IndexOf("@") + 1).Replace(vbCr, "")

            Dim x As Integer = 1
            For Each mac As String In camMac
                If mac = CamMacF Then
                    Select Case x
                        Case 1
                            c1BattLbl.Text = battLevel & "%"
                        Case 2
                            c2BattLbl.Text = battLevel & "%"
                        Case 3
                            c3BattLbl.Text = battLevel & "%"
                        Case 4
                            c4BattLbl.Text = battLevel & "%"
                    End Select
                Else
                    x += 1
                End If
            Next

        ElseIf text.Contains("<TM>") Then
            'YYYY-MM-DD, HH:mm:ss
            Dim camDate As String = text.Remove(0, text.IndexOf("<TM>") + 4)
            camDate = camDate.Remove(camDate.IndexOf("</"), camDate.Length - camDate.IndexOf("</"))
            Dim theDate As New DateTime
            theDate = Convert.ToDateTime(camDate)

            Dim CamMacF As String = text.Remove(0, text.IndexOf("@") + 1).Replace(vbCr, "")

            Dim x As Integer = 1
            For Each mac As String In camMac
                If mac = CamMacF Then
                    Select Case x
                        Case 1
                            c1DateLbl.Text = theDate.ToString("dd.MM.yy, HH:mm:ss")
                        Case 2
                            c2DateLbl.Text = theDate.ToString("dd.MM.yy, HH:mm:ss")
                        Case 3
                            c3DateLbl.Text = theDate.ToString("dd.MM.yy, HH:mm:ss")
                        Case 4
                            c4DateLbl.Text = theDate.ToString("dd.MM.yy, HH:mm:ss")
                    End Select
                Else
                    x += 1
                End If
            Next

        ElseIf text.Contains("<st>") Then
            Try
                Dim status As String = text.Remove(0, text.IndexOf("<st>") + 4)
                status = status.Remove(status.IndexOf("</"), status.Length - status.IndexOf("</"))
                Dim statusSplit = status.Split(" ")

                Dim shutter = statusSplit(15)
                Dim mode = statusSplit(14) '(0: 'video', 1: 'photo', 2: 'burst', 3: 'timelapse', 7: 'settings')
                Dim CamMacF As String = text.Remove(0, text.IndexOf("@") + 1).Replace(vbCr, "")

                registerCam(CamMacF)

                Dim x As Integer = 1
                For Each mac As String In camMac
                    If mac = CamMacF Then
                        Select Case x
                            Case 1
                                'If Not onlines(0) Then
                                '    'send DateTime to cam
                                '    send_msg("<tm>" & DateTime.Now.ToString("yy MM dd HH mm ss") & "</tm>")
                                '    onlines(0) = True
                                'End If

                                lastSee(0) = DateTime.Now

                                If shutter = 0 Then
                                    Select Case mode
                                        Case "0"
                                            status1_lbl.Text = "Video mode"
                                        Case "1"
                                            status1_lbl.Text = "Photo mode"
                                        Case "2"
                                            status1_lbl.Text = "Burst mode"
                                        Case "3"
                                            status1_lbl.Text = "Timelapse mode"
                                        Case "7"
                                            status1_lbl.Text = "Settings mode"
                                        Case Else
                                            status1_lbl.Text = "Unkwn mode"
                                    End Select

                                    M1.ForeColor = Color.LightGreen
                                    stat1PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status1_lbl.Text = "Recording..."
                                    stat1PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                            Case 2
                                'If Not onlines(1) Then
                                '    'send DateTime to cam
                                '    send_msg("<tm>" & DateTime.Now.ToString("yy MM dd HH mm ss") & "</tm>")
                                '    onlines(1) = True
                                'End If
                                lastSee(1) = DateTime.Now

                                If shutter = 0 Then
                                    Select Case mode
                                        Case "0"
                                            status2_lbl.Text = "Video mode"
                                        Case "1"
                                            status2_lbl.Text = "Photo mode"
                                        Case "2"
                                            status2_lbl.Text = "Burst mode"
                                        Case "3"
                                            status2_lbl.Text = "Timelapse mode"
                                        Case "7"
                                            status2_lbl.Text = "Settings mode"
                                        Case Else
                                            status2_lbl.Text = "Unkwn mode"
                                    End Select

                                    M2.ForeColor = Color.LightGreen
                                    stat2PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status2_lbl.Text = "Recording..."
                                    M2.ForeColor = Color.LightGreen
                                    stat2PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                            Case 3
                                'If Not onlines(2) Then
                                '    'send DateTime to cam
                                '    send_msg("<tm>" & DateTime.Now.ToString("yy MM dd HH mm ss") & "</tm>")
                                '    onlines(2) = True
                                'End If
                                lastSee(2) = DateTime.Now

                                If shutter = 0 Then
                                    Select Case mode
                                        Case "0"
                                            status3_lbl.Text = "Video mode"
                                        Case "1"
                                            status3_lbl.Text = "Photo mode"
                                        Case "2"
                                            status3_lbl.Text = "Burst mode"
                                        Case "3"
                                            status3_lbl.Text = "Timelapse mode"
                                        Case "7"
                                            status3_lbl.Text = "Settings mode"
                                        Case Else
                                            status3_lbl.Text = "Unkwn mode"
                                    End Select

                                    M3.ForeColor = Color.LightGreen
                                    stat3PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status3_lbl.Text = "Recording..."
                                    stat3PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                            Case 4
                                'If Not onlines(3) Then
                                '    'send DateTime to cam
                                '    send_msg("<tm>" & DateTime.Now.ToString("yyMMddHHmmss") & "</tm>")
                                '    onlines(3) = True
                                'End If
                                lastSee(3) = DateTime.Now

                                If shutter = 0 Then
                                    Select Case mode
                                        Case "0"
                                            status4_lbl.Text = "Video mode"
                                        Case "1"
                                            status4_lbl.Text = "Photo mode"
                                        Case "2"
                                            status4_lbl.Text = "Burst mode"
                                        Case "3"
                                            status4_lbl.Text = "Timelapse mode"
                                        Case "7"
                                            status4_lbl.Text = "Settings mode"
                                        Case Else
                                            status4_lbl.Text = "Unkwn mode"
                                    End Select

                                    M4.ForeColor = Color.LightGreen
                                    stat4PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status4_lbl.Text = "Recording..."
                                    stat4PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                        End Select
                        Exit For
                    Else
                        x += 1
                    End If
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        ElseIf text.Contains("<lc>") Then
            Try
                Dim lcdContend As String = text.Remove(0, text.IndexOf("<lc>") + 4)
                Dim i = lcdContend.IndexOf("</lc>")
                lcdContend = lcdContend.Remove(lcdContend.IndexOf("</"), lcdContend.Length - lcdContend.IndexOf("</"))
                Dim CamMacF As String = text.Remove(0, text.IndexOf("@") + 1).Replace(vbCr, "")

                Dim img As Bitmap = GetBitmap(lcdContend)

                Dim x As Integer = 1
                For Each mac As String In camMac
                    If mac = CamMacF Then
                        Select Case x
                            Case 1 'cam 1
                                ModePic1.Image = img
                            Case 2 'cam 2
                                ModePic2.Image = img
                            Case 3 'cam 3
                                ModePic3.Image = img
                            Case 4 'cam 4
                                ModePic4.Image = img
                        End Select
                        Exit For
                    Else
                        x += 1
                    End If
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        ElseIf text.Contains("Exception") Then
            OnlineTimer.Enabled = False
            'Beende Hosting
            StopHosting()
            System.Threading.Thread.Sleep(3000)
            StartHosting()

            'Switche Bild für Toggle-Button
            If _connected Then
                remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_on")
            Else
                remoteOnOffBTN.Image = My.Resources.ResourceManager.GetObject("_off")
            End If
        End If
    End Sub

    Private Function GetBitmap(lcdContend) As Bitmap
        Dim lcdBytes(599) As Byte
        Dim split = lcdContend.Split(" ")


        For lci = 0 To 599
            'Konvertiere einzeln die Bytes von String zu Byte
            'beginne im split bei index + 15 um die ersten 15 Bytes wegzulassen, da diese keine Bitmapdaten sind
            'invertiere die Daten x != x mit Xor 255
            lcdBytes(lci) = Convert.ToByte(split(lci + 15), 16) Xor 255
        Next

        'lade 60x75 Bitmap aus den Ressourcen als Grundlage
        Dim img = New Bitmap(60, 75)

        Dim bmd As BitmapData = img.LockBits(
           New Rectangle(0, 0, img.Width, img.Height),
           ImageLockMode.WriteOnly,
           PixelFormat.Format1bppIndexed)

        'kopiere die Bytes in das Bitmap
        Marshal.Copy(lcdBytes, 0, bmd.Scan0, lcdBytes.Length)


        img.UnlockBits(bmd)

        Dim result As Image = DirectCast(img, Image)

        img.RotateFlip(RotateFlipType.Rotate180FlipX)

        Return result
    End Function

    Private Function registerCam(ByVal onClient As String)
        OnlineTimer.Enabled = True

        'Ergänze MAC-Liste der online-cams wenn nötig
        Dim inList As Boolean = False
        For Each cl As String In onClientList
            If cl = onClient Then
                inList = True
                Exit For
            End If
        Next
        If Not inList Then
            onClientList.Add(onClient)
        End If

        'Speichere Uhrzeit wann Kamera zuletzt online war
        Dim x As Integer = 1
        For Each mac As String In camMac
            If mac = onClient Then
                Select Case x
                    Case 1
                        M1.ForeColor = Color.LightGreen
                        lastSee(0) = DateTime.Now
                    Case 2
                        M2.ForeColor = Color.LightGreen
                        lastSee(1) = DateTime.Now
                    Case 3
                        M3.ForeColor = Color.LightGreen
                        lastSee(2) = DateTime.Now
                    Case 4
                        M4.ForeColor = Color.LightGreen
                        lastSee(3) = DateTime.Now
                End Select
                Exit For
            Else
                x += 1
            End If
        Next

        StatusLabel1.Text = "Anzahl verbundener Kameras = " & onClientList.Count
    End Function

    Public Function BitToRGB(ByVal input() As Byte) As Byte()
        Dim bitResult(input.Length + 1) As Byte

        Dim white() As Byte = New Byte() {240, 255, 240}
        Dim black() As Byte = New Byte() {0, 0, 0}
        Dim byteIndex As Integer = 0

        'Durchlaufe die 600bytes des Inputs
        Do While (byteIndex < input.Length)
            Dim bitIndex As Integer = 0

            'Durchlaufe die 8bit des bytes
            Do While (bitIndex < 8)
                Dim bitNr = 4 + bitIndex
                Dim theBit = (input(byteIndex) And bitNr)

                'schiebe Bit in Byte
                If bitNr <= 7 Then
                    bitResult(byteIndex) = bitResult(byteIndex) Or (1 << bitNr)
                Else
                    bitResult(byteIndex + 1) = bitResult(byteIndex + 1) Or (1 << (bitNr - 7))
                End If

                bitIndex += 1
            Loop

            byteIndex += 1
        Loop

        Return bitResult
    End Function

    Private Function AutoDetectArduino() As String
        Dim portNos(My.Computer.Ports.SerialPortNames.Count) As String

        For i = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            portNos(i) = My.Computer.Ports.SerialPortNames(i).Substring(3)
        Next

        Array.Sort(portNos)
        Array.Reverse(portNos)

        For Each portNo As String In portNos
            StatusLabel1.Text = "Prüfe COM-Port " & portNo & "..."
            StatusStrip1.Refresh()

            Dim portName As String = "COM" + portNo

            Try
                SerialPort1 = New SerialPort(portName, baudrate, Parity.None, 8, StopBits.One)
                SerialPort1.ReadTimeout = 2000
                SerialPort1.WriteTimeout = 700

                SerialPort1.Open()

                Dim ListeningWatch As New Stopwatch
                Dim serialMessage As String
                Thread.Sleep(1000)

                SerialPort1.Write("???")

                ListeningWatch.Start()
                While ListeningWatch.ElapsedMilliseconds < 700 And ListeningWatch.IsRunning
                    serialMessage = SerialPort1.ReadLine()
                    If serialMessage.Contains("GPRC") Then
                        ListeningWatch.Stop()
                        SerialPort1.Close()
                        scannedPort = portName
                        Thread.Sleep(1000)
                        Return portName
                        Exit For
                    End If
                End While
            Catch
                SerialPort1.Close()
            End Try
        Next
        Return Nothing
    End Function

    Private Sub camsOffBTN_Click(sender As Object, e As EventArgs) Handles camsOffBTN.Click
        If Not _recording Then
            If send_msg("<pw0>") Then
                System.Threading.Thread.Sleep(800)
                send_msg("<pw0>")
                StatusLabel1.Text = "All Cams off"
                System.Threading.Thread.Sleep(800)
                M1.ForeColor = Color.Gray
                M2.ForeColor = Color.Gray
                M3.ForeColor = Color.Gray
                M4.ForeColor = Color.Gray
                ModePic1.Image = Nothing
                ModePic2.Image = Nothing
                ModePic3.Image = Nothing
                ModePic4.Image = Nothing
                status1_lbl.Text = "Offline"
                status2_lbl.Text = "Offline"
                status3_lbl.Text = "Offline"
                status4_lbl.Text = "Offline"
                stat1PB.Image = My.Resources.offline
                stat2PB.Image = My.Resources.offline
                stat3PB.Image = My.Resources.offline
                stat4PB.Image = My.Resources.offline
                If _connected Then
                    'Beende Hosting
                    StopHosting()
                End If
            End If
        Else
            If send_msg("<sh0>") Then
                _recording = False
                Label6.Text = "Start Record"
                If send_msg("<pw0>") Then
                    System.Threading.Thread.Sleep(800)
                    send_msg("<pw0>")
                    StatusLabel1.Text = "All Cams off"
                    System.Threading.Thread.Sleep(800)
                    M1.ForeColor = Color.Gray
                    M2.ForeColor = Color.Gray
                    M3.ForeColor = Color.Gray
                    M4.ForeColor = Color.Gray
                    ModePic1.Image = Nothing
                    ModePic2.Image = Nothing
                    ModePic3.Image = Nothing
                    ModePic4.Image = Nothing
                    status1_lbl.Text = "Offline"
                    status2_lbl.Text = "Offline"
                    status3_lbl.Text = "Offline"
                    status4_lbl.Text = "Offline"
                    stat1PB.Image = My.Resources.offline
                    stat2PB.Image = My.Resources.offline
                    stat3PB.Image = My.Resources.offline
                    stat4PB.Image = My.Resources.offline
                    If _connected Then
                        'Beende Hosting
                        StopHosting()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & version
        UhrzeitTimer.Enabled = True

        For i = 0 To connectedCam.Length - 1
            connectedCam(i) = False
        Next

        Try
            wifiIface.Scan()
        Catch
            StatusLabel1.Text = "Bitte WLAN einschalten/prüfen"
        End Try

        wifiScanTimer.Enabled = True
        getNetworksTimer.Enabled = True

        sdBoxes(0) = SDbox1
        sdBoxes(1) = SDbox2
        sdBoxes(2) = SDbox3
        sdBoxes(3) = SDbox4

        'cam table laden
        camsTBL.TableName = "cams"
        camsTBL.Columns.Add("Cam-Name")
        camsTBL.PrimaryKey = New DataColumn() {camsTBL.Columns(0)}
        camsTBL.Columns.Add("MAC")
        camsTBL.Columns.Add("SSID")
        camsTBL.Columns.Add("Passwort")

        Dim pfad As String = (Path.Combine(Application.StartupPath, "cams.xml"))
        If File.Exists(pfad) Then
            camsTBL.ReadXml(pfad)
            SetCamData()
        End If
    End Sub

    Public Sub SetCamData()
        For i = 0 To camsTBL.Rows.Count - 1
            Dim row As DataRow = camsTBL.Rows.Item(i)
            Dim camName As String = row.Item(0).ToString
            Dim SSID As String = row.Item(2).ToString
            Dim camNo = " (-" & SSID.Substring(8) & ") "

            Select Case i
                Case 0
                    M1.Text = camName
                    Mn1.Text = camNo
                Case 1
                    M2.Text = camName
                    Mn2.Text = camNo
                Case 2
                    M3.Text = camName
                    Mn3.Text = camNo
                Case 3
                    M4.Text = camName
                    Mn4.Text = camNo
            End Select

            camMac(i) = row.Item(1).ToString
            camSSIDs(i) = SSID
            camWifiPW(i) = row.Item(3).ToString

            'es werden nur max 4 Kameras unterstützt
            If i >= 3 Then
                Exit For
            End If
        Next
    End Sub
    Private Sub GetAvailableNetworks()
        Dim networks() As Wlan.WlanAvailableNetwork

        Try
            networks = wifiIface.GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags.IncludeAllManualHiddenProfiles)


            For i = 0 To foundCams.Length - 1
                foundCams(i) = False
            Next
            For i = 0 To connectedCam.Length - 1
                connectedCam(i) = False
            Next

            For Each network As Wlan.WlanAvailableNetwork In networks
                If (network.dot11DefaultCipherAlgorithm = Wlan.Dot11CipherAlgorithm.CCMP) Then
                    Dim ssid = network.dot11Ssid
                    Dim ssidString = Encoding.ASCII.GetString(ssid.SSID, 0, ssid.SSIDLength)

                    For i = 0 To camSSIDs.Length - 1
                        If camSSIDs(i) = ssidString Then
                            'check if connected
                            Dim currentConnection As Wlan.WlanConnectionAttributes = wifiIface.CurrentConnection

                            'if connected
                            Try
                                If currentConnection.profileName = camSSIDs(i) Then
                                    sdBoxes(i).Image = My.Resources.microSD_green
                                    connectedCam(i) = True
                                Else
                                    sdBoxes(i).Image = My.Resources.microSD_yellow
                                End If
                            Catch
                                sdBoxes(i).Image = My.Resources.microSD_yellow
                            End Try

                            foundCams(i) = True
                            Exit For
                        End If
                    Next

                    For i = 0 To foundCams.Length - 1
                        If Not foundCams(i) Then
                            sdBoxes(i).Image = My.Resources.microSD_red
                        End If
                    Next
                End If
            Next
        Catch
            StatusLabel1.Text = "Bitte WLAN einschalten/prüfen"
        End Try
    End Sub

    Private Sub UhrzeitTimer_Tick(sender As Object, e As EventArgs) Handles UhrzeitTimer.Tick
        lblUhrzeit.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub RecTimeTimer_Tick(sender As Object, e As EventArgs) Handles RecTimeTimer.Tick
        Dim time1 As TimeSpan = TimeSpan.FromSeconds(1)
        recTime = recTime.Add(time1)
        recTimeLBL.Text = recTime.ToString
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click, AufnahmelisteToolStripMenuItem.Click
        'Zeige Liste der Aufnahme-Uhrzeiten
        If Me.Height = 731 Then
            Me.Height = 521
        Else
            Me.Height = 731
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SDbox1_Click(sender As Object, e As EventArgs) Handles SDbox1.Click
        'wake wifi via BLE
        'TODO

        'verbinde wifi mit cam 1
        pWait.Show(Me)
        pWait.Refresh()

        Dim profileName = camSSIDs(0)
        Dim key = camWifiPW(0)
        Dim profileXml = String.Format("<?xml version=""1.0""?><WLANProfile xmlns=""http://www.microsoft.com/networking/WLAN/profile/v1""><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><connectionMode>auto</connectionMode><autoSwitch>false</autoSwitch><MSM><security><authEncryption><authentication>WPA2PSK</authentication><encryption>AES</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>passPhrase</keyType><protected>false</protected><keyMaterial>{1}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>",
                                       profileName, key)

        connectWifi(profileXml, profileName, 0)
    End Sub
    Private Sub SDbox2_Click(sender As Object, e As EventArgs) Handles SDbox2.Click
        'verbinde wifi mit cam 2
        pWait.Show(Me)
        pWait.Refresh()

        Dim profileName = camSSIDs(1)
        Dim key = camWifiPW(1)
        Dim profileXml = String.Format("<?xml version=""1.0""?><WLANProfile xmlns=""http://www.microsoft.com/networking/WLAN/profile/v1""><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><connectionMode>auto</connectionMode><autoSwitch>false</autoSwitch><MSM><security><authEncryption><authentication>WPA2PSK</authentication><encryption>AES</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>passPhrase</keyType><protected>false</protected><keyMaterial>{1}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>",
                                       profileName, key)

        connectWifi(profileXml, profileName, 1)
    End Sub
    Private Sub SDbox3_Click(sender As Object, e As EventArgs) Handles SDbox3.Click
        'verbinde wifi mit cam 3
        pWait.Show(Me)
        pWait.Refresh()


        Dim profileName = camSSIDs(2)
        Dim key = camWifiPW(2)
        Dim profileXml = String.Format("<?xml version=""1.0""?><WLANProfile xmlns=""http://www.microsoft.com/networking/WLAN/profile/v1""><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><connectionMode>auto</connectionMode><autoSwitch>false</autoSwitch><MSM><security><authEncryption><authentication>WPA2PSK</authentication><encryption>AES</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>passPhrase</keyType><protected>false</protected><keyMaterial>{1}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>",
                                       profileName, key)

        connectWifi(profileXml, profileName, 2)
    End Sub
    Private Sub SDbox4_Click(sender As Object, e As EventArgs) Handles SDbox4.Click
        'verbinde wifi mit cam 4
        pWait.Show(Me)
        pWait.Refresh()


        Dim profileName = camSSIDs(3)
        Dim key = camWifiPW(3)
        Dim profileXml = String.Format("<?xml version=""1.0""?><WLANProfile xmlns=""http://www.microsoft.com/networking/WLAN/profile/v1""><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><connectionMode>auto</connectionMode><autoSwitch>false</autoSwitch><MSM><security><authEncryption><authentication>WPA2PSK</authentication><encryption>AES</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>passPhrase</keyType><protected>false</protected><keyMaterial>{1}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>",
                                       profileName, key)

        connectWifi(profileXml, profileName, 3)
    End Sub

    Private Sub connectWifi(ByVal profileXml, ByVal profileName, ByVal camNr)
        'check connection
        Dim connectedSsids As New Collection()
        Dim conSsid As Wlan.Dot11Ssid

        Try
            If Not connectedCam(camNr) Then
                Try
                    wifiIface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, True)
                Catch
                    'profil vorhanden
                End Try

                conSsid = wifiIface.CurrentConnection.wlanAssociationAttributes.dot11Ssid
                connectedSsids.Add(New String(Encoding.ASCII.GetChars(conSsid.SSID, 0, conSsid.SSIDLength)))
                For Each connectedSsid In connectedSsids
                    If connectedSsid = profileName Then
                        connectedCam(camNr) = True
                    End If
                Next


                If Not connectedCam(camNr) Then
                    'connect to cam
                    wifiIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName)

                    'wait for connection
                    Dim Timeout = 5000
                    Do While ((wifiIface.InterfaceState.ToString() <> "Connected") And (Timeout >= 0))
                        System.Threading.Thread.Sleep(500)
                        Timeout -= 500
                    Loop

                    'check connection again
                    connectedSsids = New Collection()
                    conSsid = wifiIface.CurrentConnection.wlanAssociationAttributes.dot11Ssid
                    connectedSsids.Add(New String(Encoding.ASCII.GetChars(conSsid.SSID, 0, conSsid.SSIDLength)))
                    For Each connectedSsid In connectedSsids
                        If connectedSsid = profileName Then
                            connectedCam(camNr) = True
                        End If
                    Next
                End If
            Else
                connectedCam(camNr) = True
            End If
        Catch 'ex As Exception
            'MessageBox.Show(ex.Message)

        End Try

        pWait.Close()
        If connectedCam(camNr) Then
            lWait.Show(Me)
            lWait.Refresh()

            showVideoList(profileName)
        Else
            MessageBox.Show("Keine Verbindung zu " & profileName)
        End If
    End Sub

    Private Sub showVideoList(profileName)
        'Rufe Videoliste als JSON ab von http://10.5.5.9:8080/gp/gpMediaList
        Dim mediaInfoStr As String = ""
        Dim mediaInfo As JToken

        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://10.5.5.9:8080/gp/gpMediaList"), HttpWebRequest)
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            mediaInfoStr = reader.ReadToEnd()
            'Hole JSON-Mediainfo in mediaInfoJSA
            Dim json As JObject

            json = JObject.Parse(mediaInfoStr)
            mediaInfo = json.Last.First.First

            Dim mediaDirectory As JProperty = mediaInfo.First
            Dim mediaList As JArray = mediaInfo.Last.First
            MediaBrowse.mediaDirectory = mediaDirectory

            For Each video As JObject In mediaList
                Dim vidName = video.Item("n").ToString
                Dim vidTimeStamp As String = New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(video.Item("mod").ToString()).ToString
                Dim vidSeconds As Long = video.Item("s").ToString
                vidSeconds /= 3777750
                Dim vidDur As TimeSpan = TimeSpan.FromSeconds(vidSeconds)

                MediaBrowse.DataGridView1.Rows.Add(vbNull, vidName, vidTimeStamp, vidDur.ToString)
            Next

            For Each row As DataGridViewRow In MediaBrowse.DataGridView1.Rows
                If Not row.Cells(1).Value = Nothing Then
                    'Lade Thum-Nails nach mit http://10.5.5.9/gp/gpMediaMetadata?p=xxxGOPRO/GOPRxxxx.MP4
                    Dim thumbURL = "http://10.5.5.9/gp/gpMediaMetadata?p=" & mediaDirectory.First.ToString() & "/" & row.Cells(1).Value

                    Dim tClient As WebClient = New WebClient

                    Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(thumbURL), False))
                    Dim img As Image = DirectCast(tImage, Image)

                    row.Cells(0).Value = img
                    row.Height = 120
                End If
            Next

            MediaBrowse.DataGridView1.AutoResizeRows()

            MediaBrowse.Show(Me)
        Catch
            lWait.Close()
            If Not mediaInfoStr = "" And IsNothing(mediaInfo) Then
                MessageBox.Show("Speicherkarte leer?")
            Else
                MessageBox.Show("Fehler beim Laden der Liste. Bitte erneut versuchen!")
            End If

            wifiIface.DeleteProfile(profileName)
        End Try
    End Sub

    Private Sub wifiScanTimer_Tick(sender As Object, e As EventArgs) Handles wifiScanTimer.Tick
        Try
            wifiIface.Scan()
        Catch
            StatusLabel1.Text = "Bitte WLAN einschalten/prüfen"
        End Try
    End Sub

    Private Sub getNetworksTimer_Tick(sender As Object, e As EventArgs) Handles getNetworksTimer.Tick
        GetAvailableNetworks()
    End Sub

    'Private Sub SetTimeBtn_Click(sender As Object, e As EventArgs)
    '    'set date time in gopro
    '    'http://10.5.5.9/gp/gpControl/command/setup/date_time?p=%11%0b%10%11%29%2c

    'End Sub

    Private Sub VideomodusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideomodusToolStripMenuItem.Click
        send_msg("<cmv>")
    End Sub

    Private Sub PhotomodusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotomodusToolStripMenuItem.Click
        send_msg("<cmp>")
    End Sub

    Private Sub BurstToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BurstToolStripMenuItem.Click
        send_msg("<cmb>")
    End Sub

    Private Sub TimelapseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimelapseToolStripMenuItem.Click
        send_msg("<cml>")
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Form2.ShowDialog(Me)
    End Sub

    Private Sub camsRestartBTN_Click_1(sender As Object, e As EventArgs) Handles camsRestartBTN.Click
        send_msg("<pw0>")
        Thread.Sleep(2000)
        send_msg("<rc0>")
        Thread.Sleep(3000)
        send_msg("<rc1>")
    End Sub
End Class
