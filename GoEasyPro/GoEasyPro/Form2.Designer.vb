<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.camMacTB = New System.Windows.Forms.TextBox()
        Me.camNameTB = New System.Windows.Forms.TextBox()
        Me.addBTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwTB = New System.Windows.Forms.TextBox()
        Me.ssidTB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.delBTN = New System.Windows.Forms.Button()
        Me.closeBTN = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(536, 302)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.camMacTB)
        Me.GroupBox1.Controls.Add(Me.camNameTB)
        Me.GroupBox1.Controls.Add(Me.addBTN)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.passwTB)
        Me.GroupBox1.Controls.Add(Me.ssidTB)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(492, 342)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kamera hinzufügen"
        '
        'camMacTB
        '
        Me.camMacTB.Location = New System.Drawing.Point(15, 151)
        Me.camMacTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.camMacTB.Name = "camMacTB"
        Me.camMacTB.Size = New System.Drawing.Size(223, 22)
        Me.camMacTB.TabIndex = 2
        '
        'camNameTB
        '
        Me.camNameTB.Location = New System.Drawing.Point(15, 70)
        Me.camNameTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.camNameTB.Name = "camNameTB"
        Me.camNameTB.Size = New System.Drawing.Size(223, 22)
        Me.camNameTB.TabIndex = 1
        Me.camNameTB.Text = "CAM "
        '
        'addBTN
        '
        Me.addBTN.Location = New System.Drawing.Point(325, 287)
        Me.addBTN.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(149, 43)
        Me.addBTN.TabIndex = 5
        Me.addBTN.Text = "Hinzufügen"
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Für Videozugriff"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Für Fernbedienung"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Allgemein"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(11, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "MAC-Adresse der Cam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name der Cam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SSID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 215)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Passwort"
        '
        'passwTB
        '
        Me.passwTB.Location = New System.Drawing.Point(248, 235)
        Me.passwTB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 6)
        Me.passwTB.Name = "passwTB"
        Me.passwTB.Size = New System.Drawing.Size(223, 22)
        Me.passwTB.TabIndex = 4
        '
        'ssidTB
        '
        Me.ssidTB.Location = New System.Drawing.Point(15, 235)
        Me.ssidTB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 6)
        Me.ssidTB.Name = "ssidTB"
        Me.ssidTB.Size = New System.Drawing.Size(220, 22)
        Me.ssidTB.TabIndex = 3
        Me.ssidTB.Text = "GP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.delBTN)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(560, 407)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bekannte Kameras"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(9, 336)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(349, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Es werden nur die ersten 4 Cams im Programm verwendet"
        '
        'delBTN
        '
        Me.delBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delBTN.Location = New System.Drawing.Point(311, 354)
        Me.delBTN.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.delBTN.Name = "delBTN"
        Me.delBTN.Size = New System.Drawing.Size(236, 43)
        Me.delBTN.TabIndex = 8
        Me.delBTN.Text = "Ausgewählte löschen"
        Me.delBTN.UseVisualStyleBackColor = True
        '
        'closeBTN
        '
        Me.closeBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBTN.Location = New System.Drawing.Point(931, 382)
        Me.closeBTN.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.closeBTN.Name = "closeBTN"
        Me.closeBTN.Size = New System.Drawing.Size(149, 43)
        Me.closeBTN.TabIndex = 6
        Me.closeBTN.Text = "Schließen"
        Me.closeBTN.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.closeBTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Kameraregistrierung"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents addBTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwTB As TextBox
    Friend WithEvents ssidTB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents delBTN As Button
    Friend WithEvents closeBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents camMacTB As TextBox
    Friend WithEvents camNameTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
