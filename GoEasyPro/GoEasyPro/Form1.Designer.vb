<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.M1 = New System.Windows.Forms.Label()
        Me.M2 = New System.Windows.Forms.Label()
        Me.M3 = New System.Windows.Forms.Label()
        Me.M4 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OnlineTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startTime_lbl = New System.Windows.Forms.Label()
        Me.wifiScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.status1_lbl = New System.Windows.Forms.Label()
        Me.status2_lbl = New System.Windows.Forms.Label()
        Me.status3_lbl = New System.Windows.Forms.Label()
        Me.status4_lbl = New System.Windows.Forms.Label()
        Me.lblUhrzeit = New System.Windows.Forms.Label()
        Me.UhrzeitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.recTimeLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RecListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.titelTB = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AufnahmelisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideomodusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotomodusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BurstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimelapseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.getNetworksTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Mn1 = New System.Windows.Forms.Label()
        Me.Mn2 = New System.Windows.Forms.Label()
        Me.Mn3 = New System.Windows.Forms.Label()
        Me.Mn4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c1DateLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1BattLbl = New System.Windows.Forms.Label()
        Me.c2DateLbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.c2BattLbl = New System.Windows.Forms.Label()
        Me.c3DateLbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c3BattLbl = New System.Windows.Forms.Label()
        Me.c4DateLbl = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.c4BattLbl = New System.Windows.Forms.Label()
        Me.SDbox4 = New System.Windows.Forms.PictureBox()
        Me.SDbox3 = New System.Windows.Forms.PictureBox()
        Me.SDbox2 = New System.Windows.Forms.PictureBox()
        Me.SDbox1 = New System.Windows.Forms.PictureBox()
        Me.ModePic4 = New System.Windows.Forms.PictureBox()
        Me.ModePic3 = New System.Windows.Forms.PictureBox()
        Me.ModePic2 = New System.Windows.Forms.PictureBox()
        Me.ModePic1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.stat4PB = New System.Windows.Forms.PictureBox()
        Me.stat3PB = New System.Windows.Forms.PictureBox()
        Me.stat2PB = New System.Windows.Forms.PictureBox()
        Me.stat1PB = New System.Windows.Forms.PictureBox()
        Me.camsOffBTN = New System.Windows.Forms.PictureBox()
        Me.camsRestartBTN = New System.Windows.Forms.PictureBox()
        Me.StartStopBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.remoteOnOffBTN = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SDbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat4PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat3PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camsOffBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camsRestartBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartStopBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.remoteOnOffBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("3ds", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fernbedienung"
        '
        'M1
        '
        Me.M1.AutoSize = True
        Me.M1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M1.ForeColor = System.Drawing.Color.Gray
        Me.M1.Location = New System.Drawing.Point(35, 251)
        Me.M1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(71, 23)
        Me.M1.TabIndex = 3
        Me.M1.Text = "CAM X"
        '
        'M2
        '
        Me.M2.AutoSize = True
        Me.M2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M2.ForeColor = System.Drawing.Color.Gray
        Me.M2.Location = New System.Drawing.Point(248, 251)
        Me.M2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(71, 23)
        Me.M2.TabIndex = 3
        Me.M2.Text = "CAM X"
        '
        'M3
        '
        Me.M3.AutoSize = True
        Me.M3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M3.ForeColor = System.Drawing.Color.Gray
        Me.M3.Location = New System.Drawing.Point(462, 251)
        Me.M3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(71, 23)
        Me.M3.TabIndex = 3
        Me.M3.Text = "CAM X"
        '
        'M4
        '
        Me.M4.AutoSize = True
        Me.M4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M4.ForeColor = System.Drawing.Color.Gray
        Me.M4.Location = New System.Drawing.Point(675, 251)
        Me.M4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(71, 23)
        Me.M4.TabIndex = 3
        Me.M4.Text = "CAM X"
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.ReadBufferSize = 1024
        Me.SerialPort1.ReadTimeout = 2000
        Me.SerialPort1.WriteBufferSize = 512
        Me.SerialPort1.WriteTimeout = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 354)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Aufnahme"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 26)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(145, 20)
        Me.StatusLabel1.Text = "Ferbedienung ist aus"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(670, 368)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Kameras neustarten"
        '
        'OnlineTimer
        '
        Me.OnlineTimer.Interval = 1000
        '
        'startTime_lbl
        '
        Me.startTime_lbl.AutoSize = True
        Me.startTime_lbl.Location = New System.Drawing.Point(92, 385)
        Me.startTime_lbl.Name = "startTime_lbl"
        Me.startTime_lbl.Size = New System.Drawing.Size(70, 23)
        Me.startTime_lbl.TabIndex = 8
        Me.startTime_lbl.Text = "--:--:--"
        '
        'wifiScanTimer
        '
        Me.wifiScanTimer.Interval = 10000
        '
        'status1_lbl
        '
        Me.status1_lbl.AutoSize = True
        Me.status1_lbl.ForeColor = System.Drawing.Color.White
        Me.status1_lbl.Location = New System.Drawing.Point(26, 294)
        Me.status1_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status1_lbl.Name = "status1_lbl"
        Me.status1_lbl.Size = New System.Drawing.Size(69, 23)
        Me.status1_lbl.TabIndex = 3
        Me.status1_lbl.Text = "Offline"
        '
        'status2_lbl
        '
        Me.status2_lbl.AutoSize = True
        Me.status2_lbl.ForeColor = System.Drawing.Color.White
        Me.status2_lbl.Location = New System.Drawing.Point(240, 294)
        Me.status2_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status2_lbl.Name = "status2_lbl"
        Me.status2_lbl.Size = New System.Drawing.Size(69, 23)
        Me.status2_lbl.TabIndex = 3
        Me.status2_lbl.Text = "Offline"
        '
        'status3_lbl
        '
        Me.status3_lbl.AutoSize = True
        Me.status3_lbl.ForeColor = System.Drawing.Color.White
        Me.status3_lbl.Location = New System.Drawing.Point(456, 294)
        Me.status3_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status3_lbl.Name = "status3_lbl"
        Me.status3_lbl.Size = New System.Drawing.Size(69, 23)
        Me.status3_lbl.TabIndex = 3
        Me.status3_lbl.Text = "Offline"
        '
        'status4_lbl
        '
        Me.status4_lbl.AutoSize = True
        Me.status4_lbl.ForeColor = System.Drawing.Color.White
        Me.status4_lbl.Location = New System.Drawing.Point(670, 294)
        Me.status4_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status4_lbl.Name = "status4_lbl"
        Me.status4_lbl.Size = New System.Drawing.Size(69, 23)
        Me.status4_lbl.TabIndex = 3
        Me.status4_lbl.Text = "Offline"
        '
        'lblUhrzeit
        '
        Me.lblUhrzeit.AutoSize = True
        Me.lblUhrzeit.Font = New System.Drawing.Font("3ds", 24.0!)
        Me.lblUhrzeit.Location = New System.Drawing.Point(708, 41)
        Me.lblUhrzeit.Name = "lblUhrzeit"
        Me.lblUhrzeit.Size = New System.Drawing.Size(186, 45)
        Me.lblUhrzeit.TabIndex = 10
        Me.lblUhrzeit.Text = "00:00:00"
        '
        'UhrzeitTimer
        '
        Me.UhrzeitTimer.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 385)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start:"
        '
        'recTimeLBL
        '
        Me.recTimeLBL.AutoSize = True
        Me.recTimeLBL.Location = New System.Drawing.Point(92, 413)
        Me.recTimeLBL.Name = "recTimeLBL"
        Me.recTimeLBL.Size = New System.Drawing.Size(70, 23)
        Me.recTimeLBL.TabIndex = 8
        Me.recTimeLBL.Text = "--:--:--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 413)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Zeit:"
        '
        'RecTimeTimer
        '
        Me.RecTimeTimer.Interval = 1000
        '
        'RecListBox
        '
        Me.RecListBox.FormattingEnabled = True
        Me.RecListBox.ItemHeight = 23
        Me.RecListBox.Location = New System.Drawing.Point(31, 486)
        Me.RecListBox.Name = "RecListBox"
        Me.RecListBox.Size = New System.Drawing.Size(826, 119)
        Me.RecListBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 467)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Aufnahmen:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 354)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Titel:"
        '
        'titelTB
        '
        Me.titelTB.Location = New System.Drawing.Point(78, 350)
        Me.titelTB.Name = "titelTB"
        Me.titelTB.Size = New System.Drawing.Size(139, 33)
        Me.titelTB.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AnsichtToolStripMenuItem, Me.ModisToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 30)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(59, 26)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AufnahmelisteToolStripMenuItem})
        Me.AnsichtToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(71, 26)
        Me.AnsichtToolStripMenuItem.Text = "Ansicht"
        '
        'AufnahmelisteToolStripMenuItem
        '
        Me.AufnahmelisteToolStripMenuItem.Name = "AufnahmelisteToolStripMenuItem"
        Me.AufnahmelisteToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.AufnahmelisteToolStripMenuItem.Text = "Aufnahmeliste"
        '
        'ModisToolStripMenuItem
        '
        Me.ModisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideomodusToolStripMenuItem, Me.PhotomodusToolStripMenuItem, Me.BurstToolStripMenuItem, Me.TimelapseToolStripMenuItem})
        Me.ModisToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ModisToolStripMenuItem.Name = "ModisToolStripMenuItem"
        Me.ModisToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.ModisToolStripMenuItem.Text = "Modis"
        '
        'VideomodusToolStripMenuItem
        '
        Me.VideomodusToolStripMenuItem.Name = "VideomodusToolStripMenuItem"
        Me.VideomodusToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.VideomodusToolStripMenuItem.Text = "Videomodus"
        '
        'PhotomodusToolStripMenuItem
        '
        Me.PhotomodusToolStripMenuItem.Name = "PhotomodusToolStripMenuItem"
        Me.PhotomodusToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.PhotomodusToolStripMenuItem.Text = "Fotomodus"
        '
        'BurstToolStripMenuItem
        '
        Me.BurstToolStripMenuItem.Name = "BurstToolStripMenuItem"
        Me.BurstToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.BurstToolStripMenuItem.Text = "Burst"
        '
        'TimelapseToolStripMenuItem
        '
        Me.TimelapseToolStripMenuItem.Name = "TimelapseToolStripMenuItem"
        Me.TimelapseToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.TimelapseToolStripMenuItem.Text = "Timelapse"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.EinstellungenToolStripMenuItem.Text = "Kameraregistrierung"
        '
        'getNetworksTimer
        '
        Me.getNetworksTimer.Interval = 2000
        '
        'Mn1
        '
        Me.Mn1.AutoSize = True
        Me.Mn1.BackColor = System.Drawing.Color.White
        Me.Mn1.ForeColor = System.Drawing.Color.Black
        Me.Mn1.Location = New System.Drawing.Point(140, 251)
        Me.Mn1.Name = "Mn1"
        Me.Mn1.Size = New System.Drawing.Size(64, 23)
        Me.Mn1.TabIndex = 16
        Me.Mn1.Text = " (-XX) "
        '
        'Mn2
        '
        Me.Mn2.AutoSize = True
        Me.Mn2.BackColor = System.Drawing.Color.White
        Me.Mn2.ForeColor = System.Drawing.Color.Black
        Me.Mn2.Location = New System.Drawing.Point(353, 251)
        Me.Mn2.Name = "Mn2"
        Me.Mn2.Size = New System.Drawing.Size(64, 23)
        Me.Mn2.TabIndex = 16
        Me.Mn2.Text = " (-XX) "
        '
        'Mn3
        '
        Me.Mn3.AutoSize = True
        Me.Mn3.BackColor = System.Drawing.Color.White
        Me.Mn3.ForeColor = System.Drawing.Color.Black
        Me.Mn3.Location = New System.Drawing.Point(567, 251)
        Me.Mn3.Name = "Mn3"
        Me.Mn3.Size = New System.Drawing.Size(64, 23)
        Me.Mn3.TabIndex = 16
        Me.Mn3.Text = " (-XX) "
        '
        'Mn4
        '
        Me.Mn4.AutoSize = True
        Me.Mn4.BackColor = System.Drawing.Color.White
        Me.Mn4.ForeColor = System.Drawing.Color.Black
        Me.Mn4.Location = New System.Drawing.Point(781, 251)
        Me.Mn4.Name = "Mn4"
        Me.Mn4.Size = New System.Drawing.Size(52, 23)
        Me.Mn4.TabIndex = 16
        Me.Mn4.Text = " (-X) "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(670, 413)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Kameras abschalten"
        '
        'c1DateLbl
        '
        Me.c1DateLbl.AutoSize = True
        Me.c1DateLbl.Location = New System.Drawing.Point(35, 100)
        Me.c1DateLbl.Name = "c1DateLbl"
        Me.c1DateLbl.Size = New System.Drawing.Size(71, 23)
        Me.c1DateLbl.TabIndex = 17
        Me.c1DateLbl.Text = "Datum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Batt:"
        '
        'c1BattLbl
        '
        Me.c1BattLbl.AutoSize = True
        Me.c1BattLbl.Location = New System.Drawing.Point(83, 122)
        Me.c1BattLbl.Name = "c1BattLbl"
        Me.c1BattLbl.Size = New System.Drawing.Size(51, 23)
        Me.c1BattLbl.TabIndex = 18
        Me.c1BattLbl.Text = "---%"
        '
        'c2DateLbl
        '
        Me.c2DateLbl.AutoSize = True
        Me.c2DateLbl.Location = New System.Drawing.Point(248, 100)
        Me.c2DateLbl.Name = "c2DateLbl"
        Me.c2DateLbl.Size = New System.Drawing.Size(71, 23)
        Me.c2DateLbl.TabIndex = 17
        Me.c2DateLbl.Text = "Datum"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(248, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 23)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Batt:"
        '
        'c2BattLbl
        '
        Me.c2BattLbl.AutoSize = True
        Me.c2BattLbl.Location = New System.Drawing.Point(296, 122)
        Me.c2BattLbl.Name = "c2BattLbl"
        Me.c2BattLbl.Size = New System.Drawing.Size(51, 23)
        Me.c2BattLbl.TabIndex = 18
        Me.c2BattLbl.Text = "---%"
        '
        'c3DateLbl
        '
        Me.c3DateLbl.AutoSize = True
        Me.c3DateLbl.Location = New System.Drawing.Point(462, 100)
        Me.c3DateLbl.Name = "c3DateLbl"
        Me.c3DateLbl.Size = New System.Drawing.Size(71, 23)
        Me.c3DateLbl.TabIndex = 17
        Me.c3DateLbl.Text = "Datum"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(462, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Batt:"
        '
        'c3BattLbl
        '
        Me.c3BattLbl.AutoSize = True
        Me.c3BattLbl.Location = New System.Drawing.Point(510, 122)
        Me.c3BattLbl.Name = "c3BattLbl"
        Me.c3BattLbl.Size = New System.Drawing.Size(51, 23)
        Me.c3BattLbl.TabIndex = 18
        Me.c3BattLbl.Text = "---%"
        '
        'c4DateLbl
        '
        Me.c4DateLbl.AutoSize = True
        Me.c4DateLbl.Location = New System.Drawing.Point(675, 100)
        Me.c4DateLbl.Name = "c4DateLbl"
        Me.c4DateLbl.Size = New System.Drawing.Size(71, 23)
        Me.c4DateLbl.TabIndex = 17
        Me.c4DateLbl.Text = "Datum"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(675, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 23)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Batt:"
        '
        'c4BattLbl
        '
        Me.c4BattLbl.AutoSize = True
        Me.c4BattLbl.Location = New System.Drawing.Point(723, 122)
        Me.c4BattLbl.Name = "c4BattLbl"
        Me.c4BattLbl.Size = New System.Drawing.Size(51, 23)
        Me.c4BattLbl.TabIndex = 18
        Me.c4BattLbl.Text = "---%"
        '
        'SDbox4
        '
        Me.SDbox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SDbox4.Image = CType(resources.GetObject("SDbox4.Image"), System.Drawing.Image)
        Me.SDbox4.Location = New System.Drawing.Point(799, 290)
        Me.SDbox4.Name = "SDbox4"
        Me.SDbox4.Size = New System.Drawing.Size(40, 43)
        Me.SDbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SDbox4.TabIndex = 15
        Me.SDbox4.TabStop = False
        '
        'SDbox3
        '
        Me.SDbox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SDbox3.Image = CType(resources.GetObject("SDbox3.Image"), System.Drawing.Image)
        Me.SDbox3.Location = New System.Drawing.Point(585, 290)
        Me.SDbox3.Name = "SDbox3"
        Me.SDbox3.Size = New System.Drawing.Size(40, 43)
        Me.SDbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SDbox3.TabIndex = 15
        Me.SDbox3.TabStop = False
        '
        'SDbox2
        '
        Me.SDbox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SDbox2.Image = CType(resources.GetObject("SDbox2.Image"), System.Drawing.Image)
        Me.SDbox2.Location = New System.Drawing.Point(371, 290)
        Me.SDbox2.Name = "SDbox2"
        Me.SDbox2.Size = New System.Drawing.Size(40, 43)
        Me.SDbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SDbox2.TabIndex = 15
        Me.SDbox2.TabStop = False
        '
        'SDbox1
        '
        Me.SDbox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SDbox1.Image = CType(resources.GetObject("SDbox1.Image"), System.Drawing.Image)
        Me.SDbox1.Location = New System.Drawing.Point(158, 290)
        Me.SDbox1.Name = "SDbox1"
        Me.SDbox1.Size = New System.Drawing.Size(40, 43)
        Me.SDbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SDbox1.TabIndex = 15
        Me.SDbox1.TabStop = False
        '
        'ModePic4
        '
        Me.ModePic4.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic4.Location = New System.Drawing.Point(683, 167)
        Me.ModePic4.Name = "ModePic4"
        Me.ModePic4.Size = New System.Drawing.Size(60, 75)
        Me.ModePic4.TabIndex = 7
        Me.ModePic4.TabStop = False
        '
        'ModePic3
        '
        Me.ModePic3.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic3.Location = New System.Drawing.Point(469, 167)
        Me.ModePic3.Name = "ModePic3"
        Me.ModePic3.Size = New System.Drawing.Size(60, 75)
        Me.ModePic3.TabIndex = 7
        Me.ModePic3.TabStop = False
        '
        'ModePic2
        '
        Me.ModePic2.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic2.Location = New System.Drawing.Point(255, 167)
        Me.ModePic2.Name = "ModePic2"
        Me.ModePic2.Size = New System.Drawing.Size(60, 75)
        Me.ModePic2.TabIndex = 7
        Me.ModePic2.TabStop = False
        '
        'ModePic1
        '
        Me.ModePic1.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic1.Location = New System.Drawing.Point(42, 167)
        Me.ModePic1.Name = "ModePic1"
        Me.ModePic1.Size = New System.Drawing.Size(60, 75)
        Me.ModePic1.TabIndex = 7
        Me.ModePic1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(8, 386)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'stat4PB
        '
        Me.stat4PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat4PB.Location = New System.Drawing.Point(671, 156)
        Me.stat4PB.Name = "stat4PB"
        Me.stat4PB.Size = New System.Drawing.Size(15, 15)
        Me.stat4PB.TabIndex = 9
        Me.stat4PB.TabStop = False
        '
        'stat3PB
        '
        Me.stat3PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat3PB.Location = New System.Drawing.Point(458, 156)
        Me.stat3PB.Name = "stat3PB"
        Me.stat3PB.Size = New System.Drawing.Size(15, 15)
        Me.stat3PB.TabIndex = 9
        Me.stat3PB.TabStop = False
        '
        'stat2PB
        '
        Me.stat2PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat2PB.Location = New System.Drawing.Point(244, 156)
        Me.stat2PB.Name = "stat2PB"
        Me.stat2PB.Size = New System.Drawing.Size(15, 15)
        Me.stat2PB.TabIndex = 9
        Me.stat2PB.TabStop = False
        '
        'stat1PB
        '
        Me.stat1PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat1PB.Location = New System.Drawing.Point(30, 156)
        Me.stat1PB.Name = "stat1PB"
        Me.stat1PB.Size = New System.Drawing.Size(15, 15)
        Me.stat1PB.TabIndex = 9
        Me.stat1PB.TabStop = False
        '
        'camsOffBTN
        '
        Me.camsOffBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.camsOffBTN.Image = Global.GoEasyPro.My.Resources.Resources.iconfinder_power_1055002
        Me.camsOffBTN.Location = New System.Drawing.Point(826, 406)
        Me.camsOffBTN.Name = "camsOffBTN"
        Me.camsOffBTN.Size = New System.Drawing.Size(32, 32)
        Me.camsOffBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.camsOffBTN.TabIndex = 6
        Me.camsOffBTN.TabStop = False
        '
        'camsRestartBTN
        '
        Me.camsRestartBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.camsRestartBTN.Image = CType(resources.GetObject("camsRestartBTN.Image"), System.Drawing.Image)
        Me.camsRestartBTN.Location = New System.Drawing.Point(826, 361)
        Me.camsRestartBTN.Name = "camsRestartBTN"
        Me.camsRestartBTN.Size = New System.Drawing.Size(32, 32)
        Me.camsRestartBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.camsRestartBTN.TabIndex = 6
        Me.camsRestartBTN.TabStop = False
        '
        'StartStopBtn
        '
        Me.StartStopBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartStopBtn.Image = Global.GoEasyPro.My.Resources.Resources.rec_button
        Me.StartStopBtn.Location = New System.Drawing.Point(237, 348)
        Me.StartStopBtn.Name = "StartStopBtn"
        Me.StartStopBtn.Size = New System.Drawing.Size(30, 30)
        Me.StartStopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.StartStopBtn.TabIndex = 4
        Me.StartStopBtn.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox5.Location = New System.Drawing.Point(664, 145)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(193, 145)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox4.Location = New System.Drawing.Point(450, 145)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(193, 145)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox3.Location = New System.Drawing.Point(236, 145)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(193, 145)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox2.Location = New System.Drawing.Point(23, 145)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(193, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'remoteOnOffBTN
        '
        Me.remoteOnOffBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remoteOnOffBTN.Image = Global.GoEasyPro.My.Resources.Resources._off
        Me.remoteOnOffBTN.Location = New System.Drawing.Point(216, 36)
        Me.remoteOnOffBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.remoteOnOffBTN.Name = "remoteOnOffBTN"
        Me.remoteOnOffBTN.Size = New System.Drawing.Size(83, 38)
        Me.remoteOnOffBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.remoteOnOffBTN.TabIndex = 1
        Me.remoteOnOffBTN.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 474)
        Me.Controls.Add(Me.c4BattLbl)
        Me.Controls.Add(Me.c3BattLbl)
        Me.Controls.Add(Me.c2BattLbl)
        Me.Controls.Add(Me.c1BattLbl)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c4DateLbl)
        Me.Controls.Add(Me.c3DateLbl)
        Me.Controls.Add(Me.c2DateLbl)
        Me.Controls.Add(Me.c1DateLbl)
        Me.Controls.Add(Me.M4)
        Me.Controls.Add(Me.M3)
        Me.Controls.Add(Me.M2)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.Mn4)
        Me.Controls.Add(Me.Mn3)
        Me.Controls.Add(Me.Mn2)
        Me.Controls.Add(Me.Mn1)
        Me.Controls.Add(Me.SDbox4)
        Me.Controls.Add(Me.SDbox3)
        Me.Controls.Add(Me.SDbox2)
        Me.Controls.Add(Me.SDbox1)
        Me.Controls.Add(Me.titelTB)
        Me.Controls.Add(Me.ModePic4)
        Me.Controls.Add(Me.ModePic3)
        Me.Controls.Add(Me.ModePic2)
        Me.Controls.Add(Me.ModePic1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblUhrzeit)
        Me.Controls.Add(Me.stat4PB)
        Me.Controls.Add(Me.stat3PB)
        Me.Controls.Add(Me.stat2PB)
        Me.Controls.Add(Me.stat1PB)
        Me.Controls.Add(Me.recTimeLBL)
        Me.Controls.Add(Me.startTime_lbl)
        Me.Controls.Add(Me.camsOffBTN)
        Me.Controls.Add(Me.camsRestartBTN)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.StartStopBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.status4_lbl)
        Me.Controls.Add(Me.status3_lbl)
        Me.Controls.Add(Me.status2_lbl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.status1_lbl)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.remoteOnOffBTN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecListBox)
        Me.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(896, 513)
        Me.Name = "Form1"
        Me.Text = "GoEasyPro by S. Balzer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SDbox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDbox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat4PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat3PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat1PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camsOffBTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camsRestartBTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartStopBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.remoteOnOffBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents remoteOnOffBTN As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents M1 As Label
    Friend WithEvents M2 As Label
    Friend WithEvents M3 As Label
    Friend WithEvents M4 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents StartStopBtn As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents camsRestartBTN As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OnlineTimer As Timer
    Friend WithEvents ModePic1 As PictureBox
    Friend WithEvents ModePic2 As PictureBox
    Friend WithEvents ModePic3 As PictureBox
    Friend WithEvents ModePic4 As PictureBox
    Friend WithEvents startTime_lbl As Label
    Friend WithEvents stat1PB As PictureBox
    Friend WithEvents stat2PB As PictureBox
    Friend WithEvents stat3PB As PictureBox
    Friend WithEvents stat4PB As PictureBox
    Friend WithEvents wifiScanTimer As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents status1_lbl As Label
    Friend WithEvents status2_lbl As Label
    Friend WithEvents status3_lbl As Label
    Friend WithEvents status4_lbl As Label
    Friend WithEvents lblUhrzeit As Label
    Friend WithEvents UhrzeitTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents recTimeLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RecTimeTimer As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RecListBox As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents titelTB As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AufnahmelisteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SDbox1 As PictureBox
    Friend WithEvents SDbox2 As PictureBox
    Friend WithEvents SDbox3 As PictureBox
    Friend WithEvents SDbox4 As PictureBox
    Friend WithEvents getNetworksTimer As Timer
    Friend WithEvents Mn1 As Label
    Friend WithEvents Mn2 As Label
    Friend WithEvents Mn3 As Label
    Friend WithEvents Mn4 As Label
    Friend WithEvents ModisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideomodusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhotomodusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BurstToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimelapseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents camsOffBTN As PictureBox
    Friend WithEvents c1DateLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents c1BattLbl As Label
    Friend WithEvents c2DateLbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents c2BattLbl As Label
    Friend WithEvents c3DateLbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents c3BattLbl As Label
    Friend WithEvents c4DateLbl As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents c4BattLbl As Label
End Class
