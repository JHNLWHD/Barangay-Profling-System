Public Class frmAddRoad

    Private AddressObj As New AddressClass
    Dim msg As String = ""
    Dim trigger As String = ""
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Close()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addRoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtRoad.Text = String.Empty
            With AddressObj
                .LoadRoadRecords(dgvRoad, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            With AddressObj
                .Road_name = txtRoad.Text
                .Road_status = "Active"
                .Road_remove_status = "False"
                If .isRoadExist(.Road_name, "New") = True Then
                    msg = "already exist."
                    MessageBox.Show(String.Format("{0} {1}", .Road_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If .AddRoad = True Then
                        msg = "is saved."
                        MessageBox.Show(String.Format("{0} {1}", .Road_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        addRoad_Load(sender, e)
                        trigger = ""
                        Exit Sub
                    Else
                        msg = "is not saved."
                        MessageBox.Show(String.Format("{0} {1}", .Road_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class