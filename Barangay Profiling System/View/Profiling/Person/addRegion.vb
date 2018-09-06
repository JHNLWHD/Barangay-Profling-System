Public Class addRegion

    Private PersonObj As PersonClass

    Private Sub addRegion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
            LoadReligionToCbo(frmProfiling.cboReligion)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PersonObj = New PersonClass
            With PersonObj
                .LoadReligionRecords(dgvBrowsePerson, "Not All", 0, "Active")
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
                .Religion_name = txtReligion.Text
                .Religion_status = "Active"
                .Religion_remove_status = "False"
                If .AddReligion = True Then
                    MsgBox(.Religion_name + " is saved.")
                    txtReligion.Clear()
                    .LoadReligionRecords(dgvBrowsePerson, "Not All", 0, "Active")
                Else
                    MsgBox("Error occured in saving the data.")
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class