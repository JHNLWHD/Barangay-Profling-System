Public Class frmHearingDetails

    Private CaseObj As New CaseClass
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            With CaseObj
                If txtTrigger.Text = "Close" Then
                    .Case_has_hearing_status = "Close"
                    .GetHearingID(txtcodehearing.Text)
                    .Hearing_idhearing = .Idhearing
                    If .UpdateHearingToComplete = True Then
                        MsgBox("This hearing is close")
                        .Case_has_hearing_status = "Complete"
                        .Case_has_hearing_witness = txtHearingWitness.Text
                        .Hearing_idhearing = txtcodehearing.Text
                        .Case_has_hearing_remarks = txtRemarks.Text
                        If .UpdateHearingDetails = True Then
                            'MsgBox("hearing details has been updated.")
                            Close()
                            frmCaseDetails.Close()
                        Else
                            'MsgBox("Error occured saving data.")
                        End If
                    Else
                        MsgBox("Failed to close this hearing.")
                        Exit Sub
                    End If
                Else
                    .Case_has_hearing_status = "Close"
                    .Case_has_hearing_witness = txtHearingWitness.Text
                    .GetHearingID(txtcodehearing.Text)
                    .Hearing_idhearing = .Idhearing
                    .Case_has_hearing_remarks = txtRemarks.Text
                    If .UpdateHearingDetails = True Then
                        MsgBox("Hearing details has been updated.")
                        Close()
                        frmCaseDetails.Close()
                    Else
                        MsgBox("Error occured saving data.")
                    End If
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmHearingDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class