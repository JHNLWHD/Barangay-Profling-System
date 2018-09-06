Public Class frmAddHearingDate

    Private CaseObj As New CaseClass
    Public int_arrc(1000) As Integer
    Public int_arrr(1000) As Integer
    Public arrc_l As Integer
    Public arrr_l As Integer
    Private Sub btnAddHearingDate_Click(sender As Object, e As EventArgs) Handles btnAddHearingDate.Click
        Try
            Dim bool As Boolean = False
            With CaseObj

                For i As Integer = 0 To arrc_l
                    For x As Integer = 0 To arrr_l
                        .Case_idcase = Integer.Parse(txtID.Text)
                        .Hearing_code = txtCode.Text
                        .Hearing_date = dtpAddHearingDate.Value.ToString("yyyy-MM-dd")
                        .Case_complainant_idcomplainant = int_arrc(i)
                        .Case_respondent_idrespondent = int_arrr(i)
                        .Case_has_hearing_status = "Open"
                        .Case_has_hearing_remarks = ""
                        'Case_complainant_idcomplainant, Case_respondent_idrespondent,
                        'Hearing_idhearing, Case_has_hearing_remarks, Case_has_hearing_status
                        If .AddMoreHearing = True Then
                            bool = True
                        End If
                    Next
                Next
                If bool = True Then
                    MsgBox("Hearing is added.")
                    Dispose()
                    Close()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelHearingDate_Click(sender As Object, e As EventArgs) Handles btnCancelHearingDate.Click
        Dispose()
        Close()
    End Sub
End Class