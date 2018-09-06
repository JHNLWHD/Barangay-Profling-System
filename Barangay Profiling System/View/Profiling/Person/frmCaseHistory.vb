Public Class frmCaseHistory
    Private Sub frmCaseHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dgvHistory.RowCount > 0 Then
                lblCase.Visible = False
            Else
                lblCase.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class