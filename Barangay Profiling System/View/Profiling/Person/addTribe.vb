Public Class addTribe

    Private PersonObj As PersonClass

    Private Sub addTribe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
            LoadTribeToCbo(frmProfiling.cboTribe)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addTribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PersonObj = New PersonClass
            With PersonObj
                .LoadTribeRecords(dgvBrowsePerson, "Not All", 0, "Active")
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
                .Tribe_name = txtTribe.Text
                .Tribe_status = "Active"
                .Tribe_remove_status = "False"
                If .AddTribe = True Then
                    MsgBox(.Religion_name + " is saved.")
                    txtTribe.Clear()
                    .LoadTribeRecords(dgvBrowsePerson, "Not All", 0, "Active")
                Else
                    MsgBox("Error occured in saving the data.")
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class