Public Class frmAccount

    Dim trigger As String = ""
    Private AccountObj As New AccountClass
    Public Shared _idEmp As Integer
    Private Sub btnBrowseRes_Click(sender As Object, e As EventArgs) Handles btnBrowseRes.Click
        Try
            broEmployee.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            pnlCenter.Enabled = False
            ClearAll(pnlCenter)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                btnSave.Enabled = True
                btnBrowseRes.Enabled = True
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = False
                trigger = "New"
                pnlCenter.Enabled = True
                gboEmployeeInfo.Enabled = False
                btnBrowseRes.Enabled = True
                txtUsername.Text = generateUsername()
                txtPassword.Text = generatePassword()
            Else
                ClearAll(gboEmployeeInfo)
                ClearAll(gboAccountInfo)
                btnNew.Text = "New"
                btnSave.Enabled = False
                btnBrowseRes.Enabled = False
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                trigger = ""
                pnlCenter.Enabled = False
                gboEmployeeInfo.Enabled = False
                btnBrowseRes.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If trigger = "New" Then
                With AccountObj

                    .Person_first_name = txtFirstName.Text
                    .Person_middle_name = txtMiddleName.Text
                    .Person_last_name = txtLastName.Text
                    .Person_extension_name = txtExtensionName.Text
                    .Person_mobile_no = txtMobileNumber.Text
                    .Person_tel_no = txtTelephoneNumber.Text
                    .Person_date_of_birth = dtpDOB.Value.ToString("yyyy-MM-dd")
                    If rbtnMale.Checked = True Then
                        .Person_gender = "Male"
                    ElseIf rbtnFemale.Checked = True Then
                        .Person_gender = "Female"
                    End If
                    .Employee_position = txtPosition.Text

                    .Employee_type = txtType.Text
                    .Account_password = txtPassword.Text
                    .Account_username = txtUsername.Text
                    If cboPosition.Text = "Super Admin" Or cboPosition.Text = "Admin" Then
                        .Account_type = "Admin"
                        .Account_position = cboPosition.Text
                    Else
                        .Account_type = "User"
                        .Account_position = cboPosition.Text
                    End If
                    .Account_security_question = cboSecurityQuestion.Text
                    .Account_answer = txtAnswer.Text
                    .Account_status = "Active"
                    .Employee_idemployee = txtID.Text


                    If .AddAccount(txtID.Text) = True Then
                        MessageBox.Show(String.Format("{0} {1} {2} {3} have an account now.", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name),
                                        My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmAccount_Load(sender, e)
                        trigger = ""
                        Exit Sub
                    Else
                        MessageBox.Show(String.Format("There is a failure occured when creating the account for {0} {1} {2} {3}.", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name),
                                        My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                End With

            Else
                With AccountObj

                    If cboPosition.Text = "Super Admin" Or cboPosition.Text = "Admin" Then
                        .Account_type = "Admin"
                        .Account_position = cboPosition.Text
                    Else
                        .Account_type = "User"
                        .Account_position = cboPosition.Text
                    End If
                    .Account_security_question = cboSecurityQuestion.Text
                    .Account_answer = txtAnswer.Text
                    .Idaccount = .Idaccount
                    If .UpdateAccountDetails = True Then
                        MessageBox.Show(String.Format("Updating the account of {0} {1} {2} {3} is succesfully done.", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name),
                                        My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmAccount_Load(sender, e)
                        trigger = ""
                    Else
                        MessageBox.Show(String.Format("There is a failure occured when updating the account of {0} {1} {2} {3}.", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name),
                                        My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            dgvSearch_CellContentDoubleClick(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmAccountRecord.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With AccountObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchAccount(dgvSearch, txtSearch.Text)
                Else
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellContentClick
        Try
            With AccountObj
                .GetAccountDetatils(dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
                .Idaccount = .Idaccount

                txtFirstName.Text = .Person_first_name
                txtMiddleName.Text = .Person_middle_name
                txtLastName.Text = .Person_last_name
                txtExtensionName.Text = .Person_extension_name

                If .Person_gender = "Male" Then
                    rbtnMale.Checked = True
                Else
                    rbtnFemale.Checked = True
                End If

                txtMobileNumber.Text = .Person_mobile_no
                txtTelephoneNumber.Text = .Person_tel_no
                txtType.Text = .Employee_type
                txtPosition.Text = .Employee_position

                cboPosition.SelectedIndex = cboPosition.FindString(.Account_type)
                txtUsername.Text = .Account_username
                txtPassword.Text = .Account_password
                txtPassword.UseSystemPasswordChar = True
                cboSecurityQuestion.SelectedIndex = cboSecurityQuestion.FindString(.Account_security_question)
                txtAnswer.Text = .Account_answer
            End With

            btnNew.Enabled = False
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnShowRecords.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellContentDoubleClick
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                dgvSearch_CellContentClick(sender, e)
                btnSave.Enabled = True
                btnNew.Enabled = False
                btnBrowseRes.Enabled = False
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                gboAccountInfo.Enabled = True
                cboPosition.Enabled = True
                cboSecurityQuestion.Enabled = True
                txtUsername.Enabled = False
                txtPassword.Enabled = True
                txtAnswer.Enabled = True
                btnEdit.Enabled = True
                trigger = "Edit"
            Else
                ClearAll(pnlCenter)
                btnEdit.Text = "Edit"
                btnSave.Enabled = False
                btnNew.Enabled = True
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                dgvSearch.Rows.Clear()
                txtSearch.Clear()
                gboAccountInfo.Enabled = False
                cboPosition.Enabled = False
                cboSecurityQuestion.Enabled = False
                txtUsername.Enabled = False
                txtPassword.Enabled = False
                txtAnswer.Enabled = False
                trigger = ""
                btnEdit.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class