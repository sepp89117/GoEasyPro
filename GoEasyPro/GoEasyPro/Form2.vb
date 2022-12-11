Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.camsTBL
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles delBTN.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row In DataGridView1.SelectedRows
                Dim i = row.index
                MsgBox(row.cells(1).value.ToString & " " & row.cells(0).value.ToString & " wurde gelöscht.")
                Form1.camsTBL.Rows(i).Delete()
                Form1.camsTBL.WriteXml((Path.Combine(Application.StartupPath, "cams.xml")), XmlWriteMode.WriteSchema)
            Next
        End If
    End Sub

    Private Sub closeBTN_Click(sender As Object, e As EventArgs) Handles closeBTN.Click
        Me.Close()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If Not ssidTB.Text = "" And Not passwTB.Text = "" And Not camNameTB.Text = "" And Not camMacTB.Text = "" Then
            Dim row As DataRow = Form1.camsTBL.NewRow()
            row("Cam-Name") = camNameTB.Text
            row("MAC") = camMacTB.Text
            row("SSID") = ssidTB.Text
            row("Passwort") = passwTB.Text
            Form1.camsTBL.Rows.Add(row)
            Form1.camsTBL.WriteXml((Path.Combine(Application.StartupPath, "cams.xml")), XmlWriteMode.WriteSchema)
        Else
            MsgBox("Ungültige Eingabe")
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Form1.camsTBL.WriteXml((Path.Combine(Application.StartupPath, "cams.xml")), XmlWriteMode.WriteSchema)
        Form1.SetCamData()
    End Sub
End Class