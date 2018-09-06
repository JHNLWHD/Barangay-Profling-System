Public Class frmAddStreet

    Private AddressObj As New AddressClass
    Dim msg As String = ""
    Dim trigger As String = ""
    Private Sub addStreet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtStreet.Text = String.Empty
            With AddressObj
                .LoadStreetRecords(dgvStreet, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Close()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            With AddressObj
                .Street_name = txtStreet.Text
                .Street_status = "Active"
                .Street_remove_status = "False"
                If .isStreetExist(.Street_name, "New") = True Then
                    msg = "already exist."
                    MessageBox.Show(String.Format("{0} {1}", .Street_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If .AddStreet = True Then
                        msg = "is saved."
                        MessageBox.Show(String.Format("{0} {1}", .Street_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        addStreet_Load(sender, e)
                        trigger = ""
                        Exit Sub
                    Else
                        msg = "is not saved."
                        MessageBox.Show(String.Format("{0} {1}", .Street_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class