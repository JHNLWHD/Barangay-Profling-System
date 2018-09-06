Public Class frmRole
    Private Sub btnCancelRole_Click(sender As Object, e As EventArgs) Handles btnCancelRole.Click
        Close()
    End Sub

    Private Sub btnSaveRole_Click(sender As Object, e As EventArgs) Handles btnSaveRole.Click
        Try
            Close()
            broPerson.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class