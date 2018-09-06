Public Class frmBrowsePersonSpouse

    Private PersonObj As New PersonClass
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try


            frmAddSpouse._trigger = "Browse"
            frmAddSpouse.gboSpouseInfo.Enabled = False

            With PersonObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmAddSpouse.txtID2.Text = .Idperson
                frmAddSpouse.txtLastName.Text = .Person_last_name
                frmAddSpouse.txtFirstName.Text = .Person_first_name
                frmAddSpouse.txtMiddleName.Text = .Person_middle_name
                frmAddSpouse.txtExtensionName.Text = .Person_extension_name
                frmAddSpouse.txtPOB.Text = .Person_place_of_birth
                frmAddSpouse.dtpDOB.Value = .Person_date_of_birth

                If .Person_gender = "Female" Then
                    frmAddSpouse.rbtnFemale.Checked = True
                Else
                    frmAddSpouse.rbtnMale.Checked = True
                End If

                frmAddSpouse.txtMobileNumber.Text = .Person_mobile_no
                frmAddSpouse.txtTelephoneNumber.Text = .Person_tel_no
                frmAddSpouse.cboCivilStatus.SelectedIndex = .Person_civil_status

                If .Person_vital_status = "Alive" Then
                    frmAddSpouse.rbtnAlive.Checked = True
                Else
                    frmAddSpouse.rbtnDead.Checked = True
                End If

                frmAddSpouse.chkResident.Text = .Person_status

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBrowsePersonSpouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With PersonObj
                .LoadPerson(dgvBrowsePerson)
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class