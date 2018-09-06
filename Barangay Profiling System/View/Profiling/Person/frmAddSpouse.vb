Imports MySql.Data.MySqlClient
Public Class frmAddSpouse
    Public Shared _idperson As Integer
    Public Shared _trigger As String
    Public Shared _idrelative As Integer
    Private PersonObj As New PersonClass
    Dim str As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Dispose()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If _trigger = "Browse" Then
                'INSERT RELATIVE FOR PERSONS
                'UPDATE BOTH CIVIL STATUS
                With PersonObj
                    .Relative_role = "Spouse"
                    .Relative_dom = dtpSpouseInfoMarriage.Value.ToString("yyyy-MM-dd")
                    .Relative_idperson = txtID.Text
                    .Person_idperson = txtID2.Text
                    .Person_civil_status = "Married"
                    If .AddSpouse = True Then
                        MsgBox("Data is saved")
                        Dispose()
                        Close()
                    Else
                        MsgBox("Error occured in saving the data")
                        Exit Sub
                    End If
                End With
            Else
                With PersonObj
                    If chkResident.Checked = True Then
                        str += "INSERT INTO person(person_first_name,person_middle_name," _
                   & "person_last_name,person_extension_name,person_gender," _
                   & "person_mobile_no,person_tel_no,person_civil_status," _
                   & "person_date_of_birth,person_status,person_vital_status,person_reg_date,person_reg_date_resident," _
                   & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                   & "VALUES('" & MySqlHelper.EscapeString(txtFirstName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtMiddleName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtLastName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtExtensionName.Text) & "'," _
                   & "'" & If(rbtnMale.Checked = True, "Male", "Female") & "'," _
                   & "'" & MySqlHelper.EscapeString(txtMobileNumber.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtTelephoneNumber.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(cboCivilStatus.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                   & "'" & If(chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                   & "'" & If(rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                   & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                   & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                    Else
                        str += "INSERT INTO person(person_first_name,person_middle_name," _
                   & "person_last_name,person_extension_name,person_gender," _
                   & "person_mobile_no,person_tel_no,person_civil_status," _
                   & "person_date_of_birth,person_status,person_vital_status,person_reg_date," _
                   & "person_voter_status,person_precinct_number,person_place_of_birth,person_height,person_weight,person_complexion,person_hair_color,person_eye_color) " _
                   & "VALUES('" & MySqlHelper.EscapeString(txtFirstName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtMiddleName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtLastName.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtExtensionName.Text) & "'," _
                   & "'" & If(rbtnMale.Checked = True, "Male", "Female") & "'," _
                   & "'" & MySqlHelper.EscapeString(txtMobileNumber.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(txtTelephoneNumber.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(cboCivilStatus.Text) & "'," _
                   & "'" & MySqlHelper.EscapeString(dtpDOB.Value.ToString("yyyy-MM-dd")) & "'," _
                   & "'" & If(chkResident.Checked = True, "Resident", "Non Resident") & "'," _
                   & "'" & If(rbtnAlive.Checked = True, "Alive", "Dead") & "',CURRENT_DATE,'" & MySqlHelper.EscapeString("") & "'," _
                   & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "'," _
                   & "'" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "','" & MySqlHelper.EscapeString("") & "');"
                    End If

                    .Relative_role = "Spouse"
                    .Relative_dom = dtpSpouseInfoMarriage.Value.ToString("yyyy-MM-dd")
                    .Relative_idperson = txtID.text
                    .Person_civil_status = "Married"
                    If .AddSpouse(str) = True Then
                        MsgBox("Data is saved")
                        Dispose()
                        Close()
                    Else
                        MsgBox("Error occured in saving the data")
                        Exit Sub
                    End If
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPersonSpouse_Click(sender As Object, e As EventArgs) Handles btnPersonSpouse.Click
        Try
            frmBrowsePersonSpouse.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class