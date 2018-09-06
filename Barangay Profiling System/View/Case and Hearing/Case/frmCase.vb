Imports MySql.Data.MySqlClient
Public Class frmCase

    Private CaseObj As CaseClass
    Dim str As String = ""
    Dim str2 As String = ""
    Dim trigger As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            CaseObj = New CaseClass
            With CaseObj
                If trigger = "New" Then

                    For Each rows As DataGridViewRow In dgvComplainant.Rows

                        If rows.Cells(0).Value.ToString = 0 Then
                            'INSERT person
                            If rows.Cells(8).Value.ToString = "Resident" Then
                                str += "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(rows.Cells(1).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(2).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(3).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(4).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(6).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(9).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(8).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(10).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"

                                str += "INSERT INTO complainant(complainant_code,person_idperson) " _
                                & "VALUES('" & rows.Cells(7).Value.ToString & "',(SELECT MAX(idperson) FROM person));"
                            Else
                                str += "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(rows.Cells(1).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(2).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(3).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(4).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(6).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                              & "'" & MySqlHelper.EscapeString(rows.Cells(9).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(8).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(10).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"

                                str += "INSERT INTO complainant(complainant_code,person_idperson) " _
                               & "VALUES('" & rows.Cells(7).Value.ToString & "',(SELECT MAX(idperson) FROM person));"
                            End If
                        Else
                            'GET ID OF PERSON 
                            'INSERT COMPLAINANT
                            str += "INSERT INTO complainant(complainant_code,person_idperson) " _
                                & "VALUES('" & rows.Cells(7).Value.ToString & "','" & rows.Cells(0).Value.ToString & "');"
                        End If

                    Next

                    For Each rows As DataGridViewRow In dgvRespondent.Rows

                        If rows.Cells(0).Value.ToString = 0 Then
                            'INSERT person
                            If rows.Cells(8).Value.ToString = "Resident" Then
                                str += "INSERT INTO person(person_first_name,person_middle_name," _
                               & "person_last_name,person_extension_name,person_gender," _
                               & "person_mobile_no,person_tel_no,person_civil_status," _
                               & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                               & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                               & "VALUES('" & MySqlHelper.EscapeString(rows.Cells(1).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(2).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(3).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(4).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(6).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(9).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString(rows.Cells(8).Value.ToString) & "'," _
                               & "'" & MySqlHelper.EscapeString("Resident") & "'," _
                               & "'" & MySqlHelper.EscapeString("Alive") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                               & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"

                                str += "INSERT INTO respondent(respondent_code,person_idperson) " _
                                & "VALUES('" & rows.Cells(7).Value.ToString & "',(SELECT MAX(idperson) FROM person));"

                            End If
                        Else
                            'GET ID OF PERSON 
                            'INSERT COMPLAINANT
                            str += "INSERT INTO respondent(respondent_code,person_idperson) " _
                                & "VALUES('" & rows.Cells(7).Value.ToString & "','" & rows.Cells(0).Value.ToString & "');"
                        End If

                    Next

                    For Each rows As DataGridViewRow In dgvHearing.Rows
                        str2 += "INSERT INTO hearing(hearing_code,hearing_date) " _
                            & "VALUES('" & MySqlHelper.EscapeString(rows.Cells(0).Value.ToString) & "'," _
                            & "'" & MySqlHelper.EscapeString(rows.Cells(1).Value.ToString) & "');"

                        For i As Integer = 0 To dgvComplainant.RowCount - 1
                            For x As Integer = 0 To dgvRespondent.RowCount - 1
                                str2 += "INSERT INTO case_has_hearing(case_idcase,case_complainant_idcomplainant," _
                       & "case_respondent_idrespondent,hearing_idhearing,case_has_hearing_remarks," _
                       & "case_has_hearing_status,case_has_hearing_witness) VALUES((SELECT MAX(idcase) FROM `case`)," _
                       & "(SELECT idcomplainant FROM complainant WHERE " _
                       & "complainant_code = '" & MySqlHelper.EscapeString(dgvComplainant.Rows(i).Cells(7).Value.ToString) & "' LIMIT 1)," _
                       & "(SELECT idrespondent FROM respondent WHERE " _
                       & "respondent_code = '" & MySqlHelper.EscapeString(dgvRespondent.Rows(x).Cells(7).Value.ToString) & "' LIMIT 1)," _
                       & "(SELECT idhearing FROM hearing WHERE " _
                       & "hearing_code = '" & MySqlHelper.EscapeString(rows.Cells(0).Value.ToString) & "' LIMIT 1)," _
                       & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("Open") & "','" & MySqlHelper.EscapeString("") & "');"
                            Next
                        Next

                    Next

                    .Case_code = txtCaseCode.Text
                    .Case_type = txtCaseType.Text
                    .Case_desc = txtDescription.Text
                    .Case_remarks = "Open"
                    If .AddCase(str, str2) = True Then
                        MsgBox("New case has been saved.")
                        ClearAll(TabControl1)
                        dgvComplainant.Rows.Clear()
                        dgvRespondent.Rows.Clear()
                        dgvHearing.Rows.Clear()
                        ClearAll(TabPage1)
                        frmCase_Load(sender, e)
                    Else
                        MsgBox("Error occured in saving the data.")
                        Exit Sub
                    End If
                Else
                    'edit
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            dgvComplainant.Rows.Add(0, txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text,
                                    String.Format("{0} {1} {2} {3}", txtLName.Text, txtFName.Text, txtMName.Text, txtEName.Text),
                                    If(rbtnMaleC.Checked = True, "Male", "Female"), "C-" + generateRandom(), cboCivilStatusCaseComp.Text,
                                    dtpDOBCaseComp.Value.ToString("yyyy-MM-dd"),
                                    If(chkResidentC.Checked = True, "Resident", "Non Resident"))
            txtLName.Clear()
            txtMName.Clear()
            txtFName.Clear()
            txtEName.Clear()
            chkResidentC.Checked = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnComplainant_Click(sender As Object, e As EventArgs) Handles btnComplainant.Click
        Try
            frmComplainant.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHearing_Click(sender As Object, e As EventArgs) Handles btnHearing.Click
        Try
            For Each rows As DataGridViewRow In dgvHearing.Rows
                If txtHearingcode.Text = rows.Cells(0).Value.ToString Then
                    MsgBox("Hearing code must be unique.")
                    Exit Sub
                Else

                End If
            Next
            dgvHearing.Rows.Add(txtHearingcode.Text, dtpDOH.Value.ToString("yyyy-MM-dd"))
            txtHearingcode.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddR_Click(sender As Object, e As EventArgs) Handles btnAddR.Click
        Try
            dgvRespondent.Rows.Add(0, txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtExtensionname.Text,
                                    String.Format("{0} {1} {2} {3}", txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtExtensionname.Text),
                                    If(rbtnMaleR.Checked = True, "Male", "Female"), "R-" + generateRandom(), cboCivilStatusCaseRes.Text,
                                   dtpDOBCaseRes.Value.ToString("yyyy-MM-dd"),
                                     "Resident")
            txtLastname.Clear()
            txtMiddlename.Clear()
            txtFirstname.Clear()
            txtExtensionname.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If btnNew.Text = "New" Then
                btnNew.Text = "Cancel"
                trigger = "New"
                btnSave.Enabled = True
                btnEdit.Enabled = False
                TabControl1.Enabled = True
                pnlSearch.Enabled = False
                ClearAll(pnlSearch)
                dgvComplainant.Rows.Clear()
                dgvRespondent.Rows.Clear()
                dgvHearing.Rows.Clear()
            Else
                ClearAll(TabControl1)
                btnNew.Text = "New"
                trigger = ""
                dgvComplainant.Rows.Clear()
                dgvRespondent.Rows.Clear()
                dgvHearing.Rows.Clear()
                btnSave.Enabled = False
                btnEdit.Enabled = True
                TabControl1.Enabled = False
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
                TabControl1.Enabled = True
                pnlSearch.Enabled = False
            Else
                ClearAll(TabControl1)
                ClearAll(pnlSearch)
                TabControl1.Enabled = False
                pnlSearch.Enabled = True
                btnEdit.Text = "Edit"
                btnSave.Enabled = False
                btnNew.Enabled = True
                trigger = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnShowRecords_Click(sender As Object, e As EventArgs) Handles btnShowRecords.Click
        Try
            frmCaseRecords.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            trigger = ""
            btnNew.Text = "New"
            btnEdit.Text = "Edit"
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnShowRecords.Enabled = True
            ClearAll(TabControl1)
            TabControl1.Enabled = False
            pnlSearch.Enabled = True
            dgvComplainant.Rows.Clear()
            dgvRespondent.Rows.Clear()
            dgvHearing.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRespondent_Click(sender As Object, e As EventArgs) Handles btnRespondent.Click
        Try
            frmRespondent.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class