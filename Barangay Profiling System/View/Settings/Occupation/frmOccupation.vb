Public Class frmOccupation

    Private PersonObj As New PersonClass
    Dim trigger As String = ""
    Private Sub frmOccupation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            gboInfo.Enabled = False
            pnlSearch.Enabled = True
            ClearAll(gboInfo)
            ClearAll(pnlSearch)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                trigger = "New"
                cboStatus.SelectedIndex = 0
                btnSave.Enabled = True
                btnEdit.Enabled = False
                gboInfo.Enabled = True
                pnlSearch.Enabled = False
                ClearAll(pnlSearch)
            Else
                ClearAll(gboInfo)
                ClearAll(pnlSearch)
                txtSearch.Text = ""
                btnNew.Text = "New"
                trigger = ""
                cboStatus.SelectedIndex = -1
                btnSave.Enabled = False
                btnEdit.Enabled = True
                gboInfo.Enabled = False
                pnlSearch.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                trigger = "Edit"
                btnNew.Enabled = False
                btnSave.Enabled = True
                gboInfo.Enabled = True
                pnlSearch.Enabled = False
            Else
                ClearAll(gboInfo)
                ClearAll(pnlSearch)
                gboInfo.Enabled = False
                pnlSearch.Enabled = True
                btnEdit.Text = "Edit"
                btnSave.Enabled = False
                btnNew.Enabled = True
                cboStatus.SelectedIndex = -1
                trigger = ""
                txtSearch.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmOccupation_Load(sender, e)
            frmOccupationRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim msg As String = ""

            If trigger = "New" Then

                With PersonObj

                    If txtOccupation.Text <> "" Then

                        .Occupation_name = txtOccupation.Text
                        .Occupation_status = cboStatus.Text
                        .Occupation_remove_status = "False"
                        If .isOccupationExist(.Occupation_name, "New") = True Then
                            msg = "already exist."
                            MessageBox.Show(String.Format("{0} {1}", .Occupation_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If .AddOccupation = True Then
                                msg = "is saved."
                                MessageBox.Show(String.Format("{0} {1}", .Occupation_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                frmOccupation_Load(sender, e)
                                trigger = ""
                                Exit Sub
                            Else
                                msg = "is not saved."
                                MessageBox.Show(String.Format("{0} {1}", .Occupation_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If



                    Else
                        MessageBox.Show("Please fill up fields.")
                        Exit Sub


                    End If

                End With

            Else

                With PersonObj

                    .Idoccupation = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                    If .isOccupationExist(.Occupation_name, "Edit", .Idoccupation) = True Then
                        msg = "already exist."
                        MessageBox.Show(String.Format("{0} {1}", .Occupation_name_obj, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Else
                        .Occupation_name = txtOccupation.Text
                        .Idoccupation = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                        .Occupation_status = cboStatus.Text
                        If .UpdateOccupation = True Then
                            msg = "is updated."
                            MessageBox.Show(String.Format("{0} {1}", .Occupation_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                            frmOccupation_Load(sender, e)
                            trigger = ""
                            Exit Sub
                        Else
                            msg = "is not updated."
                            MessageBox.Show(String.Format("{0} {1}", .Occupation_name, msg), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            With PersonObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchOccupationRecords(dgvSearch, "ALL", 1, txtSearch.Text)
                Else
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            With PersonObj
                .Idoccupation = dgvSearch.SelectedRows(0).Cells(0).Value.ToString
                txtOccupation.Text = dgvSearch.SelectedRows(0).Cells(1).Value.ToString
                cboStatus.SelectedIndex = cboStatus.FindString(dgvSearch.SelectedRows(0).Cells(2).Value.ToString)
                .Occupation_name = txtOccupation.Text
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
            trigger = "Edit"
            btnNew.Enabled = False
            btnSave.Enabled = True
            gboInfo.Enabled = True
            pnlSearch.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class