Public Class frmCaseRemarks

    Private CaseObj As New CaseClass
    Private Sub btnPrintReportCase_Click(sender As Object, e As EventArgs) Handles btnPrintReportCase.Click
        Try
            With CaseObj

                .Case_remarks = "Close"
                .Idcase = txtID.Text
                .Case_report = txtCaseReport.Text
                If .UpdateCaseToComplete() = True Then
                    MsgBox("Case is closed.")
                    Close()
                    .LoadCaseDetails(frmCaseRecords.dgvCase)
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class