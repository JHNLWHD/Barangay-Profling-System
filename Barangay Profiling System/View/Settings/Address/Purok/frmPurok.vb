Public Class frmPurok

    Private AddressObj As New AddressClass
    Dim trigger As String = ""
    Private Sub frmPurok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            trigger = ""
            ClearAll(gboInfo)
            ClearAll(pnlSearch)
            btnNew.Enabled = True
            txtSearch.Text = ""
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            gboInfo.Enabled = False
            dgvSearch.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                btnSave.Enabled = True
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = False
                trigger = "New"
                gboInfo.Enabled = True
                txtPurok.Enabled = True
                cboStatus.SelectedIndex = 0
                cboStatus.Enabled = True
            Else
                ClearAll(gboInfo)
                btnNew.Text = "New"
                btnSave.Enabled = False
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                trigger = ""
                gboInfo.Enabled = False
                txtPurok.Enabled = False
                cboStatus.SelectedIndex = -1
                cboStatus.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                btnSave.Enabled = True
                btnNew.Enabled = False
                gboInfo.Enabled = True
                pnlSearch.Enabled = False
                trigger = "Edit"
            Else
                ClearAll(gboInfo)
                ClearAll(pnlSearch)
                btnEdit.Text = "Edit"
                btnSave.Enabled = False
                btnNew.Enabled = True
                gboInfo.Enabled = False
                pnlSearch.Enabled = True
                trigger = ""
                btnEdit.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmPurok_Load(sender, e)
            frmPurokRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim msg As String = ""

            If trigger = "New" Then

                With AddressObj

                    If txtPurok.Text <> "" Then


                        .Purok_name = txtPurok.Text
                        .Purok_status = cboStatus.Text
                        .Purok_remove_status = "False"
                        If .isPurokExist(.Purok_name, "New") = True Then
                            msg = "already exist."
                            MessageBox.Show(String.Format("{0} {1}", .Purok_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If .AddPurok = True Then
                                msg = "is saved."
                                MessageBox.Show(String.Format("{0} {1}", .Purok_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                frmPurok_Load(sender, e)
                                trigger = ""
                                Exit Sub
                            Else
                                msg = "is not saved."
                                MessageBox.Show(String.Format("{0} {1}", .Purok_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If

                    Else
                        MessageBox.Show("Please fill up fields.")
                        Exit Sub


                    End If

                End With

            Else

                With AddressObj

                    .Idpurok = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                    If .isPurokExist(.Purok_name, "Edit", .Idpurok) = True Then
                        msg = "already exist."
                        MessageBox.Show(String.Format("{0} {1}", .Purok_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        .Purok_name = txtPurok.Text
                        .Idpurok = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                        .Purok_status = cboStatus.Text
                        If .UpdatePurok = True Then
                            msg = "is updated."
                            MessageBox.Show(String.Format("{0} {1}", .Purok_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frmPurok_Load(sender, e)
                            trigger = ""
                            Exit Sub
                        Else
                            msg = "is not updated."
                            MessageBox.Show(String.Format("{0} {1}", .Purok_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With AddressObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchPurokRecords(dgvSearch, "ALL", 1, txtSearch.Text)
                Else
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            With AddressObj
                .Idpurok = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                txtPurok.Text = dgvSearch.SelectedRows(0).Cells(1).Value.ToString
                cboStatus.SelectedIndex = cboStatus.FindString(dgvSearch.SelectedRows(0).Cells(2).Value.ToString)
                .Purok_name = txtPurok.Text
            End With

            btnNew.Enabled = False
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnShowRecords.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        Try
            dgvSearch_CellClick(sender, e)
            btnEdit.Text = "Cancel"
            btnSave.Enabled = True
            btnNew.Enabled = False
            gboInfo.Enabled = True
            pnlSearch.Enabled = False
            trigger = "Edit"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPurok_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class