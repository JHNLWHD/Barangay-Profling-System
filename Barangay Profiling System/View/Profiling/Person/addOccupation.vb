Public Class addOccupation

    Private PersonObj As PersonClass

    Private Sub addOccupation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
            LoadOccupationToCbo(frmProfiling.cboOccupation)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addOccupation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PersonObj = New PersonClass
            With PersonObj
                .LoadOccupationRecords(dgvBrowsePerson, "Not All", 0, "Active")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Dispose()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Occupation_name = txtOccupation.Text
                .Occupation_status = "Active"
                .Occupation_remove_status = "False"
                If .AddOccupation = True Then
                    MsgBox(.Occupation_name + " is saved.")
                    txtOccupation.Clear()
                    .LoadOccupationRecords(dgvBrowsePerson, "Not All", 0, "Active")
                Else
                    MsgBox("Error occured in saving the data.")
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class