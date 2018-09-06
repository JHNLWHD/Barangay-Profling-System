Public Class frmEmployee

    Public _idperson As Integer = 0
    Dim trigger As String = ""
    Private EmployeeObj As New EmployeeClass
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                btnSave.Enabled = True
                btnBrowseRes.Enabled = True
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = False
                rbtnOfficial.Enabled = True
                rbtnStaff.Enabled = True
                cboPosition.Enabled = True
                'cboStatus.SelectedIndex = 0
                If rbtnOfficial.Checked = True Then
                    rbtnOfficial_CheckedChanged(sender, e)
                Else
                    rbtnStaff_CheckedChanged(sender, e)
                End If
                cboStatus.Text = "Active"
                trigger = "New"
            Else
                ClearAll(gboEmployeeInfo)
                ClearAll(gboEmploymentInfo)
                btnNew.Text = "New"
                cboStatus.SelectedIndex = -1
                btnSave.Enabled = False
                btnBrowseRes.Enabled = False
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                'cboStatus.SelectedIndex = -1
                trigger = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ClearAll(gboEmployeeInfo)
            ClearAll(gboEmploymentInfo)
            trigger = ""
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowseRes_Click_1(sender As Object, e As EventArgs) Handles btnBrowseRes.Click
        broResident.ShowDialog()
    End Sub

    Private Sub rbtnOfficial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOfficial.CheckedChanged
        cboPosition.SelectedIndex = -1
        cboPosition.Items.Clear()
        cboPosition.Items.Add("Barangay Captain")
        cboPosition.Items.Add("Kagawad")

    End Sub

    Private Sub rbtnStaff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnStaff.CheckedChanged
        cboPosition.SelectedIndex = -1
        cboPosition.Items.Clear()
        cboPosition.Items.Add("Secretary")
        cboPosition.Items.Add("Treasurer")
        cboPosition.Items.Add("Clerk")
        cboPosition.Items.Add("Assistant Clerk")
        cboPosition.Items.Add("Information Technology Officer")
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Try
            txtAge.Text = GetCurrentAge(dtpDOB.Value, getDate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If trigger = "New" Then
                With EmployeeObj

                    .Person_idperson = _idperson
                    .Person_first_name = txtFirstName.Text
                    .Person_middle_name = txtMiddleName.Text
                    .Person_last_name = txtLastName.Text
                    .Person_extension_name = txtExtensionName.Text
                    .Person_mobile_no = txtMobileNumber.Text
                    .Person_tel_no = txtTelephoneNumber.Text
                    .Person_date_of_birth = dtpDOB.Text

                    If rbtnMale.Checked = True Then
                        .Person_gender = "Male"
                    ElseIf rbtnFemale.Checked = True Then
                        .Person_gender = "Female"
                    End If

                    .Employee_position = cboPosition.Text
                    .Employee_status = "Active"

                    If rbtnOfficial.Checked = True Then
                        .Employee_type = "Official"
                    ElseIf rbtnStaff.Checked = True Then
                        .Employee_type = "Staff"
                    End If

                    If .isEmployeeActive(.Person_idperson) = True Then
                        MessageBox.Show("This person is currently an employee.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        .Employee_history_description = String.Format("{0} {1} {2}'s {3} position is now {4}", .Person_first_name, .Person_middle_name, .Person_last_name, 
                                                                      .Person_extension_name, .Employee_position)
                        If .Employee_position = "Barangay Captain" Then
                            If .hasBarangayCaptainActive("Barangay Captain") = True Then
                                MessageBox.Show(String.Format("There is a current active barangay captain in placed.", .Person_first_name, .Person_middle_name,
                                                              .Person_last_name, .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                If .AddEmployee = True Then
                                    MessageBox.Show(String.Format("{0} {1} {2} {3} is now an employee.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                                  .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    trigger = ""
                                    frmEmployee_Load(sender, e)
                                    Exit Sub
                                Else
                                    MessageBox.Show(String.Format("{0} {1} {2} {3} is didn't make as employee.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                                  .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                            End If
                        Else
                            If .AddEmployee = True Then
                                MessageBox.Show(String.Format("{0} {1} {2} {3} is now an employee.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                              .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                trigger = ""
                                frmEmployee_Load(sender, e)
                            Else
                                MessageBox.Show(String.Format("{0} {1} {2} {3} is didn't make as employee.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                              .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If

                    End If

                End With
            Else

                With EmployeeObj
                    .IdEmployee = .IdEmployee
                    .Employee_idemployee = .IdEmployee
                    .Person_first_name = txtFirstName.Text
                    .Person_middle_name = txtMiddleName.Text
                    .Person_last_name = txtLastName.Text
                    .Person_extension_name = txtExtensionName.Text
                    .Person_mobile_no = txtMobileNumber.Text
                    .Person_tel_no = txtTelephoneNumber.Text
                    .Person_date_of_birth = dtpDOB.Text

                    If rbtnMale.Checked = True Then
                        .Person_gender = "Male"
                    ElseIf rbtnFemale.Checked = True Then
                        .Person_gender = "Female"
                    End If

                    .Employee_position = cboPosition.Text
                    .Employee_status = cboStatus.Text

                    If rbtnOfficial.Checked = True Then
                        .Employee_type = "Official"
                    ElseIf rbtnStaff.Checked = True Then
                        .Employee_type = "Staff"
                    End If

                    .Employee_history_description = String.Format("{0} {1} {2}'s {3} position is now {4}", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                                  .Person_extension_name, .Employee_position)

                    If .hasBarangayCaptainActiveID(.IdEmployee) = True Then
                        MessageBox.Show(String.Format("There is a current active barangay captain in placed.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                      .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        If .UpdateEmployee = True Then
                            MessageBox.Show(String.Format("{0} {1} {2} {3} is now an {4}.", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name,
                                                          .Employee_position), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            trigger = ""
                            frmEmployee_Load(sender, e)
                            Exit Sub
                        Else
                            MessageBox.Show(String.Format("{0} {1} {2} {3} is didn't make as an employee.", .Person_first_name, .Person_middle_name, .Person_last_name,
                                                          .Person_extension_name), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            With EmployeeObj
                If txtSearch.Text.Length > 0 Then
                    .SearchEmployee(dgvSearch, txtSearch.Text, 1)
                Else
                    dgvSearch.Rows.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            'Hide()
            frmEmployee_Load(sender, e)
            frmEmployeeRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            With EmployeeObj
                .GetEmployeeDetails(dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
                .IdEmployee = .IdEmployee
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
                dtpDOB.Value = .Person_date_of_birth

                If .Employee_type = "Official" Then
                    rbtnOfficial.Checked = True
                    cboPosition.SelectedIndex = -1
                    cboPosition.Items.Clear()
                    cboPosition.Items.Add("Barangay Captain")
                    cboPosition.Items.Add("Kagawad")
                    cboPosition.SelectedIndex = cboPosition.FindString(.Employee_position)
                ElseIf .Employee_type = "Staff" Then
                    rbtnStaff.Checked = True
                    cboPosition.SelectedIndex = -1
                    cboPosition.Items.Clear()
                    cboPosition.Items.Add("Secretary")
                    cboPosition.Items.Add("Treasurer")
                    cboPosition.Items.Add("Clerk")
                    cboPosition.Items.Add("Assistant Clerk")
                    cboPosition.Items.Add("Information Technology Officer")
                    cboPosition.SelectedIndex = cboPosition.FindString(.Employee_position)
                End If

                cboStatus.SelectedIndex = cboStatus.FindString(.Employee_status)

            End With

            btnNew.Enabled = False
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnShowRecords.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                btnEdit.Enabled = True
                btnSave.Enabled = True
                btnNew.Enabled = False
                btnBrowseRes.Enabled = False
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = False
                rbtnOfficial.Enabled = True
                rbtnStaff.Enabled = True
                cboPosition.Enabled = True
                trigger = "Edit"
            Else
                ClearAll(gboEmployeeInfo)
                ClearAll(gboEmploymentInfo)
                btnEdit.Text = "Edit"
                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnNew.Enabled = True
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                cboStatus.SelectedIndex = -1
                dgvSearch.Rows.Clear()
                txtSearch.Clear()
                trigger = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellContentDoubleClick
        Try
            If btnEdit.Text = "Edit" Then
                btnEdit.Text = "Cancel"
                dgvSearch_CellClick(sender, e)
                btnSave.Enabled = True
                btnNew.Enabled = False
                btnBrowseRes.Enabled = False
                txtSearch.Enabled = False
                dgvSearch.Enabled = False
                btnEdit.Enabled = True
                rbtnOfficial.Enabled = True
                rbtnStaff.Enabled = True
                cboPosition.Enabled = True
                cboStatus.Enabled = True
                trigger = "Edit"
            Else
                ClearAll(gboEmployeeInfo)
                ClearAll(gboEmploymentInfo)
                btnEdit.Text = "Edit"
                btnEdit.Enabled = False
                btnSave.Enabled = False
                btnNew.Enabled = True
                txtSearch.Enabled = True
                dgvSearch.Enabled = True
                dgvSearch.Rows.Clear()
                txtSearch.Clear()
                cboStatus.SelectedIndex = -1
                cboStatus.Enabled = False
                trigger = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class