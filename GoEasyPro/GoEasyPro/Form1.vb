Imports System.IO.Ports
Imports System.Net.Sockets
Imports System.Threading

Public Class Form1
    Dim version As String = " V1.0"
    Public comportname As String = "COM4"
    Public baudrate As Integer = 115200
    Dim _connected As Boolean = False
    Dim _recording As Boolean = False
    Dim readThread As New Thread(AddressOf Incoming_serial)
    Dim scannedPort As String = Nothing
    Dim camMac As String() = {"4:41:69:4F:F:4B", "4:41:69:5E:4A:33", "4:41:69:5F:11:39", "4:41:69:5F:72:39"}
    Dim lastSee As Date() = {DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now}
    Dim Udp As New UdpClient
    Public ma As New DataTable 'Kamera SSIDs und Passwörter für WLAN-Direkt Verbindung

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        StopHosting()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If _connected Then

            StatusReqTimer.Enabled = False
            'Beende Hosting
            StopHosting()
            startTime_lbl.Text = "--:--:--"
        Else
            'Stelle Host für GoPros bereit
            StatusLabel1.Text = "Scanne nach COM-Port"

            StartHosting()
        End If

        'Switche Bild für Toggle-Button
        If _connected Then
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("_on")
        Else
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("_off")
        End If
    End Sub

    Private Sub StartHosting()
        If _connected = False Then

            If scannedPort Is Nothing Then
                comportname = AutoDetectArduino() 'for variable Port
                'comportname = "COM20" 'for fast debug
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
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("_on")
        Else
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("_off")
        End If
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

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'Start/Stop Record
        If Not _recording Then
            If send_msg("<sh1>") Then
                startTime_lbl.Text = DateTime.Now.ToString("HH:mm:ss") & " Uhr"
                Label6.Text = "Stop Record"
            End If
        Else
            If send_msg("<sh0>") Then
                Label6.Text = "Start Record"
            End If
        End If
    End Sub

    Private Sub Incoming_serial() ' Handles SerialPort.DataReceived
        Dim incomingData As String = Nothing

        Try
            incomingData = SerialPort1.ReadLine()
            If incomingData IsNot Nothing Then
                Me.BeginInvoke(Sub() ReceivedText(incomingData))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Dim onClientList As New List(Of String)

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
                        M1.ForeColor = Color.Gray
                        ModePic1.Image = Nothing
                        status1_lbl.Text = "Offline"
                        stat1PB.Image = My.Resources.offline
                    Case 1
                        M2.ForeColor = Color.Gray
                        ModePic2.Image = Nothing
                        status2_lbl.Text = "Offline"
                        stat2PB.Image = My.Resources.offline
                    Case 2
                        M3.ForeColor = Color.Gray
                        ModePic3.Image = Nothing
                        status3_lbl.Text = "Offline"
                        stat3PB.Image = My.Resources.offline
                    Case 3
                        M4.ForeColor = Color.Gray
                        ModePic4.Image = Nothing
                        status4_lbl.Text = "Offline"
                        stat4PB.Image = My.Resources.offline
                    Case 0 And 1 And 2 And 3
                        OnlineTimer.Enabled = False
                End Select
            End If
            i += 1
        Next
        StatusReqTimer.Enabled = True
    End Sub

    Private Sub ReceivedText(ByVal text As String)
        Console.WriteLine("RX: " & text)

        If text.Contains("<rcOn>") Then
            If text.Contains("1") Then
                StatusLabel1.Text = "Fernbedienung gestartet"
            ElseIf text.Contains("0") Then
                StatusLabel1.Text = "Fernbedinung AUS"
                StopHosting()
            End If

            'Behandle Online-Meldung
        ElseIf text.Contains("<pw1>") Then
            OnlineTimer.Enabled = True

            'filtere MAC aus Online-Meldung
            Dim onClient As String = text.Remove(0, text.IndexOf("<pw1>") + 5)
            Dim i = onClient.IndexOf("</pw1>")
            onClient = onClient.Remove(onClient.IndexOf("</"), onClient.Length - onClient.IndexOf("</"))

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
        ElseIf text.Contains("<st>") Then
            Try
                Dim status As String = text.Remove(0, text.IndexOf("<st>") + 4)
                Dim i = status.IndexOf("</st>")
                status = status.Remove(status.IndexOf("</"), status.Length - status.IndexOf("</"))
                Dim mode = status.Remove(0, 30)
                mode = mode.Remove(1)
                Dim shutter = status.Remove(0, 32)
                shutter = shutter.Remove(1)
                '0 0 0 0 0 0 0 0 0 1 1 73 74 0 0 0 0 0 0 0 <-Videomode not recording
                '0 0 0 0 0 0 0 0 0 1 1 73 74 0 0 1 0 1 0 0 <-Videomode recording
                '0 0 0 0 0 0 0 0 0 1 1 73 74 0 1 0 0 0 0 0 <- Photomode
                Dim CamMacF As String = text.Remove(0, text.IndexOf("@") + 1).Replace(vbCr, "")

                Dim x As Integer = 1
                For Each mac As String In camMac
                    If mac = CamMacF Then
                        Select Case x
                            Case 1
                                lastSee(0) = DateTime.Now
                                If mode = 0 Then
                                    ModePic1.Image = My.Resources.videomode
                                Else
                                    ModePic1.Image = My.Resources.photomode
                                End If

                                If shutter = 0 Then
                                    status1_lbl.Text = "Stand by"
                                    M1.ForeColor = Color.LightGreen
                                    stat1PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status1_lbl.Text = "Recording..."
                                    stat1PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                            Case 2
                                lastSee(1) = DateTime.Now
                                If mode = 0 Then
                                    ModePic2.Image = My.Resources.videomode
                                Else
                                    ModePic2.Image = My.Resources.photomode
                                End If

                                If shutter = 0 Then
                                    status2_lbl.Text = "Stand by"
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
                                lastSee(2) = DateTime.Now
                                If mode = 0 Then
                                    ModePic3.Image = My.Resources.videomode
                                Else
                                    ModePic3.Image = My.Resources.photomode
                                End If

                                If shutter = 0 Then
                                    status3_lbl.Text = "Stand by"
                                    M3.ForeColor = Color.LightGreen
                                    stat3PB.Image = My.Resources.online
                                    _recording = False
                                Else
                                    status3_lbl.Text = "Recording..."
                                    stat3PB.Image = My.Resources.rec
                                    _recording = True
                                End If
                            Case 4
                                lastSee(3) = DateTime.Now
                                If mode = 0 Then
                                    ModePic4.Image = My.Resources.videomode
                                Else
                                    ModePic4.Image = My.Resources.photomode
                                End If

                                If shutter = 0 Then
                                    status4_lbl.Text = "Stand by"
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
        ElseIf text.Contains("Exception") Then
            OnlineTimer.Enabled = False
            StatusReqTimer.Enabled = False
            'Beende Hosting
            StopHosting()
            System.Threading.Thread.Sleep(3000)
            StartHosting()

            'Switche Bild für Toggle-Button
            If _connected Then
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("_on")
            Else
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("_off")
            End If
        End If
    End Sub

    Private Function AutoDetectArduino() As String
        For Each sp As String In My.Computer.Ports.SerialPortNames
            StatusLabel1.Text = "Prüfe Port " & sp & "..."
            StatusStrip1.Refresh()

            Try
                SerialPort1 = New SerialPort(sp, baudrate, Parity.None, 8, StopBits.One)
                SerialPort1.ReadTimeout = 700
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
                        scannedPort = sp
                        Thread.Sleep(1000)
                        Return sp
                        Exit For
                    End If
                End While
            Catch
                SerialPort1.Close()
            End Try
        Next
        Return Nothing
    End Function

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Not _recording Then
            If send_msg("<pw0>") Then
                System.Threading.Thread.Sleep(800)
                send_msg("<pw0>")
                StatusReqTimer.Enabled = False
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
                    StatusReqTimer.Enabled = False
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

    Private Sub StatusReqTimer_Tick(sender As Object, e As EventArgs) Handles StatusReqTimer.Tick
        send_msg("<st>")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & version
    End Sub
End Class
