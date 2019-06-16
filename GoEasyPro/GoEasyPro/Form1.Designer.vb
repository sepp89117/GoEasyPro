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
        Me.StatusReqTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startTime_lbl = New System.Windows.Forms.Label()
        Me.ka_timer = New System.Windows.Forms.Timer(Me.components)
        Me.stat4PB = New System.Windows.Forms.PictureBox()
        Me.stat3PB = New System.Windows.Forms.PictureBox()
        Me.stat2PB = New System.Windows.Forms.PictureBox()
        Me.stat1PB = New System.Windows.Forms.PictureBox()
        Me.ModePic4 = New System.Windows.Forms.PictureBox()
        Me.ModePic3 = New System.Windows.Forms.PictureBox()
        Me.ModePic2 = New System.Windows.Forms.PictureBox()
        Me.ModePic1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.status1_lbl = New System.Windows.Forms.Label()
        Me.status2_lbl = New System.Windows.Forms.Label()
        Me.status3_lbl = New System.Windows.Forms.Label()
        Me.status4_lbl = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.stat4PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat3PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stat1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModePic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("3ds", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fernbedienung"
        '
        'M1
        '
        Me.M1.AutoSize = True
        Me.M1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M1.ForeColor = System.Drawing.Color.Gray
        Me.M1.Location = New System.Drawing.Point(28, 166)
        Me.M1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(81, 19)
        Me.M1.TabIndex = 3
        Me.M1.Text = "M-040-01"
        '
        'M2
        '
        Me.M2.AutoSize = True
        Me.M2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M2.ForeColor = System.Drawing.Color.Gray
        Me.M2.Location = New System.Drawing.Point(195, 166)
        Me.M2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(81, 19)
        Me.M2.TabIndex = 3
        Me.M2.Text = "M-040-02"
        '
        'M3
        '
        Me.M3.AutoSize = True
        Me.M3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M3.ForeColor = System.Drawing.Color.Gray
        Me.M3.Location = New System.Drawing.Point(363, 166)
        Me.M3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(80, 19)
        Me.M3.TabIndex = 3
        Me.M3.Text = "M-040-03"
        '
        'M4
        '
        Me.M4.AutoSize = True
        Me.M4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.M4.ForeColor = System.Drawing.Color.Gray
        Me.M4.Location = New System.Drawing.Point(530, 166)
        Me.M4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(80, 19)
        Me.M4.TabIndex = 3
        Me.M4.Text = "M-040-04"
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.ReadBufferSize = 1024
        Me.SerialPort1.WriteBufferSize = 512
        Me.SerialPort1.WriteTimeout = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 258)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Start Record"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(691, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.StatusLabel1.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 258)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Power off all Cams"
        '
        'OnlineTimer
        '
        Me.OnlineTimer.Interval = 1000
        '
        'StatusReqTimer
        '
        Me.StatusReqTimer.Interval = 2500
        '
        'startTime_lbl
        '
        Me.startTime_lbl.AutoSize = True
        Me.startTime_lbl.Location = New System.Drawing.Point(163, 258)
        Me.startTime_lbl.Name = "startTime_lbl"
        Me.startTime_lbl.Size = New System.Drawing.Size(53, 19)
        Me.startTime_lbl.TabIndex = 8
        Me.startTime_lbl.Text = "--:--:--"
        '
        'ka_timer
        '
        Me.ka_timer.Interval = 2500
        '
        'stat4PB
        '
        Me.stat4PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat4PB.Location = New System.Drawing.Point(529, 96)
        Me.stat4PB.Name = "stat4PB"
        Me.stat4PB.Size = New System.Drawing.Size(15, 15)
        Me.stat4PB.TabIndex = 9
        Me.stat4PB.TabStop = False
        '
        'stat3PB
        '
        Me.stat3PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat3PB.Location = New System.Drawing.Point(363, 96)
        Me.stat3PB.Name = "stat3PB"
        Me.stat3PB.Size = New System.Drawing.Size(15, 15)
        Me.stat3PB.TabIndex = 9
        Me.stat3PB.TabStop = False
        '
        'stat2PB
        '
        Me.stat2PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat2PB.Location = New System.Drawing.Point(195, 96)
        Me.stat2PB.Name = "stat2PB"
        Me.stat2PB.Size = New System.Drawing.Size(15, 15)
        Me.stat2PB.TabIndex = 9
        Me.stat2PB.TabStop = False
        '
        'stat1PB
        '
        Me.stat1PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stat1PB.Location = New System.Drawing.Point(29, 96)
        Me.stat1PB.Name = "stat1PB"
        Me.stat1PB.Size = New System.Drawing.Size(15, 15)
        Me.stat1PB.TabIndex = 9
        Me.stat1PB.TabStop = False
        '
        'ModePic4
        '
        Me.ModePic4.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic4.Location = New System.Drawing.Point(544, 115)
        Me.ModePic4.Name = "ModePic4"
        Me.ModePic4.Size = New System.Drawing.Size(37, 36)
        Me.ModePic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModePic4.TabIndex = 7
        Me.ModePic4.TabStop = False
        '
        'ModePic3
        '
        Me.ModePic3.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic3.Location = New System.Drawing.Point(377, 115)
        Me.ModePic3.Name = "ModePic3"
        Me.ModePic3.Size = New System.Drawing.Size(37, 36)
        Me.ModePic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModePic3.TabIndex = 7
        Me.ModePic3.TabStop = False
        '
        'ModePic2
        '
        Me.ModePic2.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic2.Location = New System.Drawing.Point(210, 115)
        Me.ModePic2.Name = "ModePic2"
        Me.ModePic2.Size = New System.Drawing.Size(37, 36)
        Me.ModePic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModePic2.TabIndex = 7
        Me.ModePic2.TabStop = False
        '
        'ModePic1
        '
        Me.ModePic1.BackColor = System.Drawing.Color.Honeydew
        Me.ModePic1.Location = New System.Drawing.Point(43, 115)
        Me.ModePic1.Name = "ModePic1"
        Me.ModePic1.Size = New System.Drawing.Size(37, 36)
        Me.ModePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ModePic1.TabIndex = 7
        Me.ModePic1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.GoEasyPro.My.Resources.Resources.iconfinder_power_1055002
        Me.PictureBox7.Location = New System.Drawing.Point(626, 251)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.GoEasyPro.My.Resources.Resources.rec_button
        Me.PictureBox6.Location = New System.Drawing.Point(127, 251)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox5.Location = New System.Drawing.Point(524, 89)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(145, 107)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox4.Location = New System.Drawing.Point(357, 89)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(145, 107)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox3.Location = New System.Drawing.Point(190, 89)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(145, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GoEasyPro.My.Resources.Resources.goproBlack
        Me.PictureBox2.Location = New System.Drawing.Point(23, 89)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoEasyPro.My.Resources.Resources._off
        Me.PictureBox1.Location = New System.Drawing.Point(216, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'status1_lbl
        '
        Me.status1_lbl.AutoSize = True
        Me.status1_lbl.ForeColor = System.Drawing.Color.White
        Me.status1_lbl.Location = New System.Drawing.Point(28, 200)
        Me.status1_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status1_lbl.Name = "status1_lbl"
        Me.status1_lbl.Size = New System.Drawing.Size(55, 19)
        Me.status1_lbl.TabIndex = 3
        Me.status1_lbl.Text = "Offline"
        '
        'status2_lbl
        '
        Me.status2_lbl.AutoSize = True
        Me.status2_lbl.ForeColor = System.Drawing.Color.White
        Me.status2_lbl.Location = New System.Drawing.Point(196, 200)
        Me.status2_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status2_lbl.Name = "status2_lbl"
        Me.status2_lbl.Size = New System.Drawing.Size(55, 19)
        Me.status2_lbl.TabIndex = 3
        Me.status2_lbl.Text = "Offline"
        '
        'status3_lbl
        '
        Me.status3_lbl.AutoSize = True
        Me.status3_lbl.ForeColor = System.Drawing.Color.White
        Me.status3_lbl.Location = New System.Drawing.Point(363, 200)
        Me.status3_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status3_lbl.Name = "status3_lbl"
        Me.status3_lbl.Size = New System.Drawing.Size(55, 19)
        Me.status3_lbl.TabIndex = 3
        Me.status3_lbl.Text = "Offline"
        '
        'status4_lbl
        '
        Me.status4_lbl.AutoSize = True
        Me.status4_lbl.ForeColor = System.Drawing.Color.White
        Me.status4_lbl.Location = New System.Drawing.Point(530, 200)
        Me.status4_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status4_lbl.Name = "status4_lbl"
        Me.status4_lbl.Size = New System.Drawing.Size(55, 19)
        Me.status4_lbl.TabIndex = 3
        Me.status4_lbl.Text = "Offline"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 327)
        Me.Controls.Add(Me.stat4PB)
        Me.Controls.Add(Me.stat3PB)
        Me.Controls.Add(Me.stat2PB)
        Me.Controls.Add(Me.stat1PB)
        Me.Controls.Add(Me.startTime_lbl)
        Me.Controls.Add(Me.ModePic4)
        Me.Controls.Add(Me.ModePic3)
        Me.Controls.Add(Me.ModePic2)
        Me.Controls.Add(Me.ModePic1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.M4)
        Me.Controls.Add(Me.M3)
        Me.Controls.Add(Me.M2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.status4_lbl)
        Me.Controls.Add(Me.status3_lbl)
        Me.Controls.Add(Me.status2_lbl)
        Me.Controls.Add(Me.status1_lbl)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("3ds", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GoEasyPro"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.stat4PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat3PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stat1PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModePic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents M1 As Label
    Friend WithEvents M2 As Label
    Friend WithEvents M3 As Label
    Friend WithEvents M4 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OnlineTimer As Timer
    Friend WithEvents StatusReqTimer As Timer
    Friend WithEvents ModePic1 As PictureBox
    Friend WithEvents ModePic2 As PictureBox
    Friend WithEvents ModePic3 As PictureBox
    Friend WithEvents ModePic4 As PictureBox
    Friend WithEvents startTime_lbl As Label
    Friend WithEvents stat1PB As PictureBox
    Friend WithEvents stat2PB As PictureBox
    Friend WithEvents stat3PB As PictureBox
    Friend WithEvents stat4PB As PictureBox
    Friend WithEvents ka_timer As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents status1_lbl As Label
    Friend WithEvents status2_lbl As Label
    Friend WithEvents status3_lbl As Label
    Friend WithEvents status4_lbl As Label
End Class
