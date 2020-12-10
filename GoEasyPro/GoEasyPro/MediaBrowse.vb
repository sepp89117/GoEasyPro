Public Class MediaBrowse

    Public mediaDirectory As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 0 Then
                Dim vidName As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                Dim vidUrl As String = "http://10.5.5.9:8080/videos/DCIM/" & mediaDirectory & "/" & vidName

                Process.Start(vidUrl)
            End If
        Catch

        End Try
    End Sub

    Private Sub MediaBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lWait.Close()
    End Sub
End Class