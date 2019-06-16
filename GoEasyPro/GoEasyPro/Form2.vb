Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.ma
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row In DataGridView1.SelectedRows
                Dim i = row.index
                MsgBox(row.cells(1).value.ToString & " " & row.cells(0).value.ToString & " wurde gelöscht.")
                Form1.ma.Rows(i).Delete()
                Form1.ma.WriteXml((Path.Combine(Application.StartupPath, "cams.xml")), XmlWriteMode.WriteSchema)
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "" And Not TextBox2.Text = "" And Not ComboBox1.Text = "" Then
            Dim row As DataRow = Form1.ma.NewRow()
            row("Name") = TextBox1.Text
            row("Passwort") = TextBox2.Text
            row("Nr") = ComboBox1.Text
            Form1.ma.Rows.Add(row)
            Form1.ma.WriteXml((Path.Combine(Application.StartupPath, "cams.xml")), XmlWriteMode.WriteSchema)
        Else
            MsgBox("Ungültige Eingabe")
        End If
    End Sub
End Class