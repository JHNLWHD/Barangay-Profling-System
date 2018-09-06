Public Class frmAddDrive

    Private AddressObj As New AddressClass
    Dim msg As String = ""
    Dim trigger As String = ""
    Private Sub addDrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtDrive.Text = String.Empty
            With AddressObj
                .LoadDriveRecords(dgvDrive, "ALL", 0)
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
                .Drive_name = txtDrive.Text
                .Drive_status = "Active"
                .Drive_remove_status = "False"
                If .isDriveExist(.Drive_name, "New") = True Then
                    msg = "already exist."
                    MessageBox.Show(String.Format("{0} {1}", .Drive_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If .AddDrive = True Then
                        msg = "is saved."
                        MessageBox.Show(String.Format("{0} {1}", .Drive_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        addDrive_Load(sender, e)
                        trigger = ""
                        Exit Sub
                    Else
                        msg = "is not saved."
                        MessageBox.Show(String.Format("{0} {1}", .Drive_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class