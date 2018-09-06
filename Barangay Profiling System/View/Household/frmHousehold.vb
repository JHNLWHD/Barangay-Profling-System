Imports MySql.Data.MySqlClient
Public Class frmHousehold

    Dim trigger As String
    Dim triggerAdd, triggerBrowse As Boolean
    Public Shared houseid As Integer
    Public Shared personid As Integer
    Public Shared personid1 As Integer

    Private HouseholdObj As HouseholdClass
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                trigger = "New"
                btnSave.Enabled = True
                btnEdit.Enabled = False
                pnlSearch.Enabled = False
                ClearAll(pnlSearch)
                txtHouseholdCode.Text = "H-" + generateRandomHouseHold()
                pcbBrowseHousehold.Enabled = True
                pcbAddHousehold.Enabled = True
                btnBrowseHouse.Enabled = True
                cboRole.Enabled = True
                cboRole.SelectedIndex = -1
            Else
                ClearAll(gboEmployeeInfo)
                btnNew.Text = "New"
                trigger = ""
                btnSave.Enabled = False
                btnEdit.Enabled = True
                pnlSearch.Enabled = True
                pcbBrowseHousehold.Enabled = False
                pcbAddHousehold.Enabled = False
                btnBrowseHouse.Enabled = False
                cboRole.Enabled = False
                cboRole.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmHouseholdRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pcbBrowseHousehold_Click(sender As Object, e As EventArgs) Handles pcbBrowseHousehold.Click
        Try
            triggerAdd = False
            triggerBrowse = True
            broHousehold.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pcbAddHousehold_Click(sender As Object, e As EventArgs) Handles pcbAddHousehold.Click
        Try
            triggerAdd = True
            triggerBrowse = False
            addHousehold.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowseHouse_Click(sender As Object, e As EventArgs) Handles btnBrowseHouse.Click
        Try
            frmBrowseHouse.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim str As String = ""
            HouseholdObj = New HouseholdClass
            If trigger = "New" Then

                With HouseholdObj
                    If txtHeadName.Text <> vbNullString And txtHousecode.Text <> vbNullString And txtHouseholdCode.Text <> vbNullString And cboRole.Text <> vbNullString Then
                        If triggerAdd = True And triggerBrowse = False Then
                            With addHousehold
                                str = "INSERT INTO person(person_first_name,person_middle_name," _
                            & "person_last_name,person_extension_name,person_gender," _
                            & "person_mobile_no,person_tel_no,person_civil_status," _
                            & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                            & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                            & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                            & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                            & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                            & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                            & "'" & MySqlHelper.EscapeString("Resident") & "'," _
                            & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                            & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                            & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"

                                HouseholdObj.Household_head = String.Format("{0} {1} {2} {3}", .txtFirstName.Text, .txtMiddleName.Text, .txtLastName.Text, .txtExtensionName.Text)
                            End With
                            .Household_code = txtHouseholdCode.Text
                            .Household_member_role = cboRole.Text
                            .House_idhouse = houseid

                            'NEW HEAD
                            If .AddHouseholdNewhead(str) = True Then
                                addHousehold.Close()
                                MessageBox.Show("New Household has been saved.")
                                ClearAll(gboEmployeeInfo)
                                btnNew.Text = "New"
                                trigger = ""
                                btnSave.Enabled = False
                                btnEdit.Enabled = True
                                pnlSearch.Enabled = True
                                pcbBrowseHousehold.Enabled = False
                                pcbAddHousehold.Enabled = False
                                btnBrowseHouse.Enabled = False
                                cboRole.Enabled = False
                                cboRole.SelectedIndex = -1
                            Else
                                MessageBox.Show("Error occured in saving the data.")
                                Exit Sub
                            End If
                        Else
                            .Household_code = txtHouseholdCode.Text
                            .Household_member_role = cboRole.Text
                            .House_idhouse = houseid
                            .Person_idperson = personid
                            .Household_head = txtHeadName.Text
                            'OLD HEAD
                            If .AddHouseholdOldhead = True Then
                                addHousehold.Close()
                                MessageBox.Show("New Household has been saved.")
                                ClearAll(gboEmployeeInfo)
                                btnNew.Text = "New"
                                trigger = ""
                                btnSave.Enabled = False
                                btnEdit.Enabled = True
                                pnlSearch.Enabled = True
                                pcbBrowseHousehold.Enabled = False
                                pcbAddHousehold.Enabled = False
                                btnBrowseHouse.Enabled = False
                                cboRole.Enabled = False
                                cboRole.SelectedIndex = -1
                            Else
                                MessageBox.Show("Error occured in saving the data.")
                                Exit Sub
                            End If
                        End If
                    Else
                        MessageBox.Show("Please fill up fields.")
                        Exit Sub
                    End If

                End With
            Else
                'edit
                If txtHeadName.Text <> vbNullString And txtHousecode.Text <> vbNullString And txtHouseholdCode.Text <> vbNullString And cboRole.Text <> vbNullString Then
                    If triggerAdd = True And triggerBrowse = False Then
                        With addHousehold
                            str = "INSERT INTO person(person_first_name,person_middle_name," _
                        & "person_last_name,person_extension_name,person_gender," _
                        & "person_mobile_no,person_tel_no,person_civil_status," _
                        & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                        & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                        & "VALUES('" & MySqlHelper.EscapeString(.txtFirstName.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.txtMiddleName.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.txtLastName.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.txtExtensionName.Text) & "'," _
                        & "'" & If(.rbtnMale.Checked = True, "Male", "Female") & "'," _
                        & "'" & MySqlHelper.EscapeString(.txtMobileNumber.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.txtTelephoneNumber.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.cboCivilStatus.Text) & "'," _
                        & "'" & MySqlHelper.EscapeString(.dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                        & "'" & MySqlHelper.EscapeString("Resident") & "'," _
                        & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                        & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                        & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"

                            HouseholdObj.Household_head = String.Format("{0} {1} {2} {3}", .txtFirstName.Text, .txtMiddleName.Text, .txtLastName.Text, .txtExtensionName.Text)
                        End With
                        'update household_head, household_member_head_status
                        'insert New household_member
                        If HouseholdObj.Changehead(str) = True Then
                            'save
                            addHousehold.Close()
                            MessageBox.Show("Household " + txtHouseholdCode.Text + " has been updated.")
                            ClearAll(gboEmployeeInfo)
                            btnEdit.Text = "Edit"
                            trigger = ""
                            btnSave.Enabled = False
                            btnEdit.Enabled = True
                            pnlSearch.Enabled = True
                            pcbBrowseHousehold.Enabled = False
                            pcbAddHousehold.Enabled = False
                            btnBrowseHouse.Enabled = False
                            cboRole.Enabled = False
                            cboRole.SelectedIndex = -1
                        Else
                            MessageBox.Show("Error occured in updating the data.")
                            Exit Sub
                        End If

                    Else

                        With HouseholdObj
                            .Household_member_role = cboRole.Text
                            .Household_head = txtHeadName.Text
                            If personid <> personid1 Then
                                'update household_head, household_member_head_status
                                'insert New household_member
                                If HouseholdObj.Changehead(str) = True Then
                                    'save
                                    addHousehold.Close()
                                    MessageBox.Show("Household " + txtHouseholdCode.Text + " has been updated.")
                                    ClearAll(gboEmployeeInfo)
                                    btnEdit.Text = "Edit"
                                    trigger = ""
                                    btnSave.Enabled = False
                                    btnEdit.Enabled = True
                                    pnlSearch.Enabled = True
                                    pcbBrowseHousehold.Enabled = False
                                    pcbAddHousehold.Enabled = False
                                    btnBrowseHouse.Enabled = False
                                    cboRole.Enabled = False
                                    cboRole.SelectedIndex = -1
                                Else
                                    MessageBox.Show("Error occured in updating the data.")
                                    Exit Sub
                                End If
                            Else
                                'Update member role
                                If HouseholdObj.NoChangehead() = True Then
                                    'save
                                    addHousehold.Close()
                                    MessageBox.Show("Household " + txtHouseholdCode.Text + " has been updated.")
                                    ClearAll(gboEmployeeInfo)
                                    btnEdit.Text = "Edit"
                                    trigger = ""
                                    btnSave.Enabled = False
                                    btnEdit.Enabled = True
                                    pnlSearch.Enabled = True
                                    pcbBrowseHousehold.Enabled = False
                                    pcbAddHousehold.Enabled = False
                                    btnBrowseHouse.Enabled = False
                                    cboRole.Enabled = False
                                    cboRole.SelectedIndex = -1
                                Else
                                    MessageBox.Show("Error occured in updating the data.")
                                    Exit Sub
                                End If
                            End If
                        End With

                    End If

                Else
                    MessageBox.Show("Please fill up fields.")
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            HouseholdObj = New HouseholdClass

            If txtSearch.Text.Trim <> vbNullString Then
                HouseholdObj.LoadHouseholdSearch(dgvSearch, txtSearch.Text)
            Else
                dgvSearch.Rows.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellContentClick
        Try
            HouseholdObj = New HouseholdClass
            With HouseholdObj
                .LoadHouseholdSearch(dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
                txtHousecode.Text = .House_code
                txtHouseholdCode.Text = .Household_code
                txtHeadName.Text = String.Format("{0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)
                cboRole.SelectedIndex = cboRole.FindString(.Household_member_role)
            End With
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
                pnlSearch.Enabled = False
                gboEmployeeInfo.Enabled = True
                btnBrowseHouse.Enabled = False
                pcbBrowseHousehold.Enabled = True
                pcbAddHousehold.Enabled = True
                cboRole.Enabled = True
            Else
                ClearAll(gboEmployeeInfo)
                ClearAll(pnlSearch)
                gboEmployeeInfo.Enabled = False
                pnlSearch.Enabled = True
                btnEdit.Text = "Edit"
                btnBrowseHouse.Enabled = False
                btnSave.Enabled = False
                btnNew.Enabled = True
                cboRole.Enabled = False
                cboRole.SelectedIndex = -1
                trigger = ""
                pcbBrowseHousehold.Enabled = False
                pcbAddHousehold.Enabled = False
                txtSearch.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmHousehold_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            pcbBrowseHousehold.Enabled = False
            pcbAddHousehold.Enabled = False
            btnBrowseHouse.Enabled = False
            triggerAdd = False
            triggerBrowse = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Try
            HouseholdObj = New HouseholdClass
            With HouseholdObj
                .LoadHouseholdSearch(dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
                txtHousecode.Text = .House_code
                txtHouseholdCode.Text = .Household_code
                personid1 = .Idperson
                txtHeadName.Text = String.Format("{0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)
                cboRole.SelectedIndex = cboRole.FindString(.Household_member_role)
                btnEdit.Enabled = True
                btnNew.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class