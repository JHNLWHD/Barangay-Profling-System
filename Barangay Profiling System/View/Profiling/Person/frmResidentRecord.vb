Public Class frmResidentRecord

    Private EmployeeObj As EmployeeClass
    Private CaseObj As CaseClass
    Private PersonObj As PersonClass
    Dim chk As String

    Private Sub dgvBrowsePerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowsePerson.CellContentClick

    End Sub

    Private Sub dgvBrowsePerson_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBrowsePerson.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvBrowsePerson.Rows(e.RowIndex).Selected = True
                dgvBrowsePerson.CurrentCell = dgvBrowsePerson.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ContextMenuStrip1.Show(dgvBrowsePerson, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmResidentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboGender.SelectedIndex = 0

            If chkSenior.Checked = True Then
                chk = "True"
            Else
                chk = "False"
            End If
            PersonObj = New PersonClass
            With PersonObj
                .LoadPersonResidentDgv(dgvBrowsePerson, cboGender.Text, chk)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CertificateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificateToolStripMenuItem.Click
        Try

            EmployeeObj = New EmployeeClass
            CaseObj = New CaseClass
            If CaseObj.isHaveCase(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString) = True Then

                MsgBox("This person have pending case.")

            End If

            With EmployeeObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmClearance._idperson = .Idperson
                frmClearance.txtClearanceName.Text = .Person_first_name
                frmClearance.txtClearanceGender.Text = .Person_gender
                frmClearance.TextBox1txtClearanceAddress.Text = dgvBrowsePerson.SelectedRows(0).Cells(8).Value.ToString
                frmClearance.txtClearanceCivilStatus.Text = dgvBrowsePerson.SelectedRows(0).Cells(3).Value.ToString
                frmClearance.txtClearanceAge.Text = dgvBrowsePerson.SelectedRows(0).Cells(7).Value.ToString


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        frmClearance.ShowDialog()
    End Sub

    Private Sub IndigencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndigencyToolStripMenuItem.Click
        Try

            EmployeeObj = New EmployeeClass
            CaseObj = New CaseClass
            If CaseObj.isHaveCase(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString) = True Then

                MsgBox("This person have pending case.")

            End If

            With EmployeeObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmIndigency._idperson = .Idperson
                frmIndigency.txtClearanceName.Text = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString
                frmIndigency.txtClearanceAge.Text = GetCurrentAge(dgvBrowsePerson.SelectedRows(0).Cells(6).Value.ToString, getDate)


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmIndigency.ShowDialog()
    End Sub

    Private Sub ResidencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidencyToolStripMenuItem.Click
        Try

            EmployeeObj = New EmployeeClass
            CaseObj = New CaseClass
            If CaseObj.isHaveCase(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString) = True Then

                MsgBox("This person have pending case.")

            End If

            With EmployeeObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmResidency._idperson = .Idperson
                frmResidency.txtResidencyAddress.Text = dgvBrowsePerson.SelectedRows(0).Cells(8).Value.ToString
                frmResidency.txtClearanceName.Text = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString
                frmResidency.txtClearanceAge.Text = dgvBrowsePerson.SelectedRows(0).Cells(7).Value.ToString


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmResidency.ShowDialog()
    End Sub

    Private Sub ResidentToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub NonResidentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            frmAppearance.txtClearanceName.Enabled = True
            frmAppearance.btnPrint.Enabled = False
            frmAppearance.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AppearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppearanceToolStripMenuItem.Click
        Try

            EmployeeObj = New EmployeeClass
            CaseObj = New CaseClass
            If CaseObj.isHaveCase(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString) = True Then

                MsgBox("This person have pending case.")

            End If

            With EmployeeObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmAppearance._idperson = .Idperson

                frmAppearance.txtClearanceName.Text = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmAppearance.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrintReportResdient.Click

        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New ResidentReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns


                .Add("person_name")
                .Add("person_gender")
                .Add("person_civil_status")
                .Add("person_age")
                .Add("person_address")
                .Add("person_status")




            End With


            For i As Integer = 0 To dgvBrowsePerson.Rows.Count - 1
                dt.Rows.Add(dgvBrowsePerson.Rows(i).Cells(1).Value.ToString,
            dgvBrowsePerson.Rows(i).Cells(2).Value.ToString,
            dgvBrowsePerson.Rows(i).Cells(3).Value.ToString,
             dgvBrowsePerson.Rows(i).Cells(7).Value.ToString,
                            dgvBrowsePerson.Rows(i).Cells(8).Value.ToString,
                            dgvBrowsePerson.Rows(i).Cells(9).Value.ToString)


            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MarryToSomeoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarryToSomeoneToolStripMenuItem.Click
        Try
            frmAddSpouse.txtID.Text = dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString
            frmAddSpouse.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewFamilyMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFamilyMemberToolStripMenuItem.Click
        Try
            PersonObj = New PersonClass
            With PersonObj
                .LoadFamilyMember(frmViewFamilyMember.dgvRelative, dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
            End With

            frmViewFamilyMember.txtName.Text = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString
            frmViewFamilyMember.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkSenior_CheckedChanged(sender As Object, e As EventArgs) Handles chkSenior.CheckedChanged
        Try
            If txtSearch.Text.Trim = vbNullString Then
                If chkSenior.Checked = True Then
                    chk = "True"
                Else
                    chk = "False"
                End If
                PersonObj = New PersonClass
                With PersonObj
                    .LoadPersonResidentDgv(dgvBrowsePerson, cboGender.Text, chk)
                End With
            Else
                txtSearch_TextChanged(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        Try
            If txtSearch.Text.Trim = vbNullString Then
                If chkSenior.Checked = True Then
                    chk = "True"
                Else
                    chk = "False"
                End If
                PersonObj = New PersonClass
                With PersonObj
                    .LoadPersonResidentDgv(dgvBrowsePerson, cboGender.Text, chk)
                End With
            Else
                txtSearch_TextChanged(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            PersonObj = New PersonClass
            If txtSearch.Text.Trim <> vbNullString Then
                If chkSenior.Checked = True Then
                    chk = "True"
                Else
                    chk = "False"
                End If
                PersonObj.SearchPersonResidentDgv(dgvBrowsePerson, cboGender.Text, chk, txtSearch.Text)
            Else
                If chkSenior.Checked = True Then
                    chk = "True"
                Else
                    chk = "False"
                End If
                With PersonObj
                    .LoadPersonResidentDgv(dgvBrowsePerson, cboGender.Text, chk)
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        Try



            With PersonObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                Residentinfo._idperson = .Idperson
                Residentinfo.lblLN.Text = .Person_last_name
                Residentinfo.lblFN.Text = .Person_first_name
                Residentinfo.lblMN.Text = .Person_middle_name
                Residentinfo.lblExt.Text = .Person_extension_name
                Residentinfo.lblPOB.Text = .Person_place_of_birth
                Residentinfo.lblDOB.Text = .Person_date_of_birth

                If .Person_gender = "Female" Then
                    Residentinfo.lblGender.Text = "Female"
                Else
                    Residentinfo.lblGender.Text = "Male"
                End If

                If .Person_voter_status = "Voter" Then
                    Residentinfo.lblRegVoter.Text = "Voter"
                Else
                    Residentinfo.lblRegVoter.Text = "Non-Voter"
                End If


                Residentinfo.lblMobNo.Text = .Person_mobile_no
                Residentinfo.lblTelNo.Text = .Person_tel_no
                Residentinfo.lblMartialStatus.Text = .Person_civil_status
                Residentinfo.lblAddress.Text = dgvBrowsePerson.SelectedRows(0).Cells(8).Value.ToString

                Residentinfo.lblPrecNo.Text = .Person_precinct_number



            End With

            Residentinfo.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewCaseHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCaseHistoryToolStripMenuItem.Click
        Try
            CaseObj = New CaseClass
            With CaseObj
                .LoadCaseHistory(frmCaseHistory.dgvHistory, dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
            End With
            frmCaseHistory.lblName.Text = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString
            frmCaseHistory.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class