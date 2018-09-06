Public Class AccountInfo
    Private Sub AccountInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Try
            txtAge.Text = GetCurrentAge(dtpDOB.Value, getDate)
        Catch ex As Exception

        End Try
    End Sub
End Class