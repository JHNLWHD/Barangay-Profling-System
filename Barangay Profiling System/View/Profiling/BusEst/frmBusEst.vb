Public Class frmBusEst
    Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
        Try
            broOwner.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class