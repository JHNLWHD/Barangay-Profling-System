Public Class frmAccountRecord

    Private AccountObj As New AccountClass

    Private Sub frmAccountRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With AccountObj
                .LoadAccountMain(dgvAccount, "All")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmAccountRecord_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With AccountObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchAccountMain(dgvAccount, txtSearch.Text, "All")
                Else
                    frmAccountRecord_Load(sender, e)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvAccount_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAccount.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvAccount.Rows(e.RowIndex).Selected = True
                dgvAccount.CurrentCell = dgvAccount.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvAccount.SelectedRows.Count = 1 Then
                    If dgvAccount.SelectedRows(0).Cells(8).Value.ToString = "Active" Then
                        cmInactive.Show(dgvAccount, e.Location)
                        cmInactive.Show(Cursor.Position)
                    ElseIf dgvAccount.SelectedRows(0).Cells(8).Value.ToString = "Inactive" Then
                        cmActive.Show(dgvAccount, e.Location)
                        cmActive.Show(Cursor.Position)
                    End If

                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub frmAccountRecord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactiveToolStripMenuItem.Click
        Try
            With AccountObj
                .Idaccount = dgvAccount.SelectedRows(0).Cells(0).Value.ToString
                .Account_status = "Inactive"

                If .UpdateAccount = True Then
                    MessageBox.Show("Save", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit Sub
                Else
                    MessageBox.Show("Not Saved", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAccountToolStripMenuItem.Click
        Try
            With AccountObj
                .GetAccountDetatils(dgvAccount.SelectedRows(0).Cells(0).Value.ToString)

                AccountInfo.txtFirstName.Text = .Person_first_name
                AccountInfo.txtMiddleName.Text = .Person_middle_name
                AccountInfo.txtLastName.Text = .Person_last_name
                AccountInfo.txtExtensionName.Text = .Person_extension_name

                If .Person_gender = "Male" Then
                    AccountInfo.rbtnMale.Checked = True
                Else
                    AccountInfo.rbtnFemale.Checked = True
                End If

                AccountInfo.txtMobileNumber.Text = .Person_mobile_no
                AccountInfo.txtTelephoneNumber.Text = .Person_tel_no
                AccountInfo.dtpDOB.Value = .Person_date_of_birth
                AccountInfo.txtType.Text = .Employee_type
                AccountInfo.txtPosition.Text = .Employee_position

                AccountInfo.txtAccountPosition.Text = .Account_type
                AccountInfo.txtUsername.Text = .Account_username
                AccountInfo.txtPassword.Text = .Account_password
                AccountInfo.txtPassword.UseSystemPasswordChar = True
                AccountInfo.txtSecurityQuestion.Text = .Account_security_question
                AccountInfo.txtAnswer.Text = .Account_answer

            End With

            AccountInfo.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveToolStripMenuItem.Click
        Try
            With AccountObj
                .Idaccount = dgvAccount.SelectedRows(0).Cells(0).Value.ToString
                .Account_status = "Active"

                If .UpdateAccount = True Then
                    MessageBox.Show("Save", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit Sub
                Else
                    MessageBox.Show("Not Saved", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New AccountReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idaccount")
                .Add("account_name")
                .Add("account_username")
                .Add("employee_type")
                .Add("employee_position")
                .Add("account_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvAccount.Rows.Count - 1
                dt.Rows.Add(dgvAccount.Rows(i).Cells(0).Value.ToString,
            dgvAccount.Rows(i).Cells(1).Value.ToString,
            dgvAccount.Rows(i).Cells(2).Value.ToString,
             dgvAccount.Rows(i).Cells(3).Value.ToString,
              dgvAccount.Rows(i).Cells(4).Value.ToString,
           dgvAccount.Rows(i).Cells(5).Value.ToString)

            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Try
            ViewAccountToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class