Imports MySql.Data.MySqlClient
Public Class frmProfiling

    Dim trigger As String = ""
    Dim str As String = ""
    Public Shared _existing As Integer = 0
    Public Shared _idhouse As Integer = 0
    Public Shared _idhousehold As Integer = 0
    Private PersonObj As New PersonClass
    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmResidentRecord.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
        Try
            'change form
            broExistingPerson.ShowDialog()
            _existing = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmProfiling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            pnlCenter.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                btnNew.Enabled = True
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnShowRecords.Enabled = True
                pnlCenter.Enabled = True
                trigger = "New"
                _existing = 0
                cboRole.Enabled = True
                cboReligion.Enabled = True
                cboTribe.Enabled = True
                cboOccupation.Enabled = True
                LoadReligionToCbo(cboReligion)
                LoadTribeToCbo(cboTribe)
                LoadOccupationToCbo(cboOccupation)
                cboReligion.SelectedIndex = -1
                cboRole.SelectedIndex = -1
                cboTribe.SelectedIndex = -1
                cboOccupation.SelectedIndex = -1
                cboCivilStatus.Enabled = True
                cboCivilStatus.SelectedIndex = -1
                ClearAll(TabControl1)
            Else
                ClearAll(TabControl1)
                btnNew.Text = "New"
                btnNew.Enabled = True
                btnSave.Enabled = False
                btnEdit.Enabled = False
                btnShowRecords.Enabled = True
                pnlCenter.Enabled = False
                trigger = ""
                _existing = 0
                cboRole.Enabled = False
                cboReligion.Enabled = False
                cboTribe.Enabled = False
                cboOccupation.Enabled = False
                cboReligion.SelectedIndex = -1
                cboRole.SelectedIndex = -1
                cboTribe.SelectedIndex = -1
                cboOccupation.SelectedIndex = -1
                cboCivilStatus.Enabled = False
                cboCivilStatus.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Try
            txtAge.Text = GetCurrentAge(dtpDOB.Value, getDate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReligion_Click(sender As Object, e As EventArgs) Handles btnReligion.Click
        Try
            addRegion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTribe_Click(sender As Object, e As EventArgs) Handles btnTribe.Click
        Try
            addTribe.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOccupation_Click(sender As Object, e As EventArgs) Handles btnOccupation.Click
        Try
            addOccupation.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If trigger = "New" Then
                If _existing = 1 Then
                    'GET ID THEN ADD
                    'UPDATE
                Else
                    'INSERT
                    With PersonObj
                        .Person_code = "P-" + generateRandomPersonCode()
                        .Person_last_name = txtLastname.Text
                        .Person_first_name = txtFirstname.Text
                        .Person_middle_name = txtMiddlename.Text
                        .Person_extension_name = txtExtensionname.Text
                        If rbtnMale.Checked = True Then
                            .Person_gender = "Male"
                        Else
                            .Person_gender = "Female"
                        End If
                        .Person_mobile_no = txtMobileNumber.Text
                        .Person_tel_no = txtTelNum.Text
                        .Person_date_of_birth = dtpDOB.Value
                        .Person_status = "Resident"
                        If chkVoter.Checked = True Then
                            .Person_voter_status = "Voter"
                        Else
                            .Person_voter_status = "Non Voter"
                        End If
                        .Person_precinct_number = txtPrecintNum.Text
                        .Person_place_of_birth = txtPob.Text
                        .Person_height = txtHeight.Text
                        .Person_weight = txtWeight.Text
                        .Person_hair_color = cboHairColor.Text
                        .Person_eye_color = cboEyeColor.Text
                        .Person_complexion = txtComplexion.Text
                        .Person_vital_status = "Alive"
                        .Household_idhousehold1 = _idhousehold
                        .Household_member_role1 = cboRole.Text

                        For Each rows As DataGridViewRow In dgvRelative.Rows
                            If rows.Cells(0).Value.ToString = 0 Then
                                'INSERT person, relative
                                str += "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color,person_code) " _
                               & "VALUES('" & MySqlHelper.EscapeString(rows.Cells(1).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(2).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(3).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(4).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(6).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("2018-01-01") & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(10).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("P-" + generateRandomPersonCode()) & "');"

                                If rows.Cells(8).Value.ToString = 0 Then
                                    str += "INSERT INTO relative(relative_role,relative_idperson," _
                                   & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                   & "(SELECT MAX(idperson) FROM person)," _
                                   & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1));"

                                    str += "INSERT INTO relative(relative_role,relative_idperson," _
                                   & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                   & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1)," _
                                   & "(SELECT MAX(idperson) FROM person));"
                                Else
                                    cboCivilStatus.SelectedIndex = cboCivilStatus.FindString("Married")
                                    str += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage," _
                                   & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                   & "(SELECT MAX(idperson) FROM person),'" & rows.Cells(9).Value.ToString & "'," _
                                   & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1));"

                                    str += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage," _
                                   & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                   & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1),'" & rows.Cells(9).Value.ToString & "'," _
                                   & "(SELECT MAX(idperson) FROM person));"
                                End If

                            Else

                                If rows.Cells(8).Value.ToString = 0 Then
                                    str += "INSERT INTO relative(relative_role,relative_idperson," _
                                    & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                    & "'" & rows.Cells(0).Value.ToString & "'," _
                                    & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1));"

                                    str += "INSERT INTO relative(relative_role,relative_idperson," _
                                  & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                  & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1)," _
                                  & "'" & rows.Cells(0).Value.ToString & "');"

                                Else
                                    cboCivilStatus.SelectedIndex = cboCivilStatus.FindString("Married")
                                    str += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage," _
                                    & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                    & "'" & rows.Cells(0).Value.ToString & "','" & rows.Cells(9).Value.ToString & "'," _
                                    & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1));"

                                    str += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage," _
                                   & "person_idperson) VALUES('" & rows.Cells(7).Value.ToString & "'," _
                                   & "(SELECT idperson FROM person WHERE person_code = '" & MySqlHelper.EscapeString(.Person_code) & "' LIMIT 1),'" & rows.Cells(9).Value.ToString & "'," _
                                   & "'" & rows.Cells(0).Value.ToString & "');"
                                End If

                            End If
                        Next

                        .Person_civil_status = cboCivilStatus.Text
                        If cboReligion.SelectedIndex <> -1 Then
                            .Idreligion = 0
                        End If
                        If cboTribe.SelectedIndex <> -1 Then
                            .Idtribe = 0
                        End If
                        If cboOccupation.SelectedIndex <> -1 Then
                            .Idoccupation = 0
                        End If

                        If .AddResident(str) = True Then
                            MsgBox("New resident has been saved.")
                            btnNew_Click(sender, e)
                        Else
                            MsgBox("Error occured in saving data.")
                            Exit Sub
                        End If
                    End With
                End If
            Else
                'edit
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bHouseholdHead_Click(sender As Object, e As EventArgs) Handles btnHouseholdHead.Click
        Try
            broFamHead.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        Try
            broPerson.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkResident_CheckedChanged(sender As Object, e As EventArgs) Handles chkResident.CheckedChanged
        Try
            If cboFamilyRole.Text = "Spouse" Then
                gboMarriage.Enabled = True
            Else
                gboMarriage.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'ADD TO DGV
            If cboFamilyRole.Text = "Spouse" Then
                dgvRelative.Rows.Add(0, txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text,
                                 String.Format("{0} {1} {2} {3}", txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text),
                                If(rbtnMaleR.Checked = True, "Male", "Female"), cboFamilyRole.Text, 1,
                                 dtpDOM.Value.ToString("yyyy-MM-dd"),
                                 If(chkResident.Checked = True, "Resident", "Non Resident"))
            Else
                dgvRelative.Rows.Add(0, txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text,
                                 String.Format("{0} {1} {2} {3}", txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text),
                                If(rbtnMaleR.Checked = True, "Male", "Female"), cboFamilyRole.Text, 0,
                                 "",
                                 If(chkResident.Checked = True, "Resident", "Non Resident"))
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmProfiling_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class