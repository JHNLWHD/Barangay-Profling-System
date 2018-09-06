Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Globalization
Public Class frmEmployeeRecords

    Private EmployeeObj As EmployeeClass
    Private Sub frmEmployeeRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                .LoadEmployeeMain(dgvEmployee, "All")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchEmployee(dgvEmployee, txtSearch.Text, 0)
                Else
                    frmEmployeeRecords_Load(sender, e)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmEmployeeRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactiveToolStripMenuItem.Click
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                .Employee_status = "Inactive"
                .IdEmployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                .Employee_idemployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                .Employee_history_description = String.Format("{0} is now inactive.", dgvEmployee.SelectedRows(0).Cells(1).Value.ToString)
                If dgvEmployee.SelectedRows(0).Cells(3).Value.ToString = "Barangay Captain" Then
                    Dim result As MsgBoxResult = MessageBox.Show(String.Format("Are you sure you want to make as inactive this barangay captain?", My.Application,
                                                                               MessageBoxIcon.Question, MessageBoxButtons.YesNo))
                    'need to recode if there is no current barangay captain, ask ma'am marj
                    If result = MsgBoxResult.Yes Then
                        If .UpdateEmployeeStatus = True Then
                            MessageBox.Show(String.Format("{0} is now inactive.", dgvEmployee.SelectedRows(0).Cells(1).Value.ToString))
                            frmEmployeeRecords_Load(sender, e)
                            Exit Sub
                        End If
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveToolStripMenuItem.Click
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                .Employee_status = "Active"
                .IdEmployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                .Employee_idemployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                .Employee_history_description = String.Format("{0} is now active.", dgvEmployee.SelectedRows(0).Cells(1).Value.ToString)
                If dgvEmployee.SelectedRows(0).Cells(3).Value.ToString = "Barangay Captain" Then
                    If .hasBarangayCaptainActiveID(.IdEmployee) = True Then
                        Dim result As MsgBoxResult = MessageBox.Show(String.Format("Are you sure you want to make as active this barangay captain? Note: This will set the curent baranagay captain inactive",
                                                                                   My.Application, MessageBoxIcon.Question, MessageBoxButtons.YesNo))

                        If result = MsgBoxResult.Yes Then
                            .Employee_status = "Inactive"
                            .IdEmployee = .Idemployee_obj
                            .Employee_idemployee = .Idemployee_obj
                            If .UpdateEmployeeStatus = True Then
                                .Employee_status = "Active"
                                .IdEmployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                                .Employee_idemployee = dgvEmployee.SelectedRows(0).Cells(0).Value.ToString
                                If .UpdateEmployeeStatus = True Then
                                    MessageBox.Show(String.Format("{0} is now active.", dgvEmployee.SelectedRows(0).Cells(1).Value.ToString))
                                    frmEmployeeRecords_Load(sender, e)
                                    Exit Sub
                                End If
                            End If

                        End If
                    End If
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEmployeeRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvEmployee_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmployee.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvEmployee.Rows(e.RowIndex).Selected = True
                dgvEmployee.CurrentCell = dgvEmployee.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvEmployee.SelectedRows.Count = 1 Then
                    If dgvEmployee.SelectedRows(0).Cells(4).Value.ToString = "Inactive" Then
                        cmActive.Show(dgvEmployee, e.Location)
                        cmActive.Show(Cursor.Position)
                    ElseIf dgvEmployee.SelectedRows(0).Cells(4).Value.ToString = "Active" Then
                        cmInactive.Show(dgvEmployee, e.Location)
                        cmInactive.Show(Cursor.Position)
                    End If
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New EmployeeReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idemployee")
                .Add("employee_name")
                .Add("employee_type")
                .Add("employee_position")
                .Add("employee_status")
                .Add("employee_reg_date")
                .Add("employee_gender")

            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvEmployee.Rows.Count - 1
                dt.Rows.Add(dgvEmployee.Rows(i).Cells(0).Value.ToString,
            dgvEmployee.Rows(i).Cells(1).Value.ToString,
            dgvEmployee.Rows(i).Cells(2).Value.ToString,
             dgvEmployee.Rows(i).Cells(3).Value.ToString,
              dgvEmployee.Rows(i).Cells(4).Value.ToString,
           dgvEmployee.Rows(i).Cells(5).Value.ToString,
                dgvEmployee.Rows(i).Cells(6).Value.ToString)
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
            With EmployeeObj
                .GetEmployeeDetails(dgvEmployee.SelectedRows(0).Cells(0).Value.ToString)

                EmpInfo.txtFirstName.Text = .Person_first_name
                EmpInfo.txtMiddleName.Text = .Person_middle_name
                EmpInfo.txtLastName.Text = .Person_last_name
                EmpInfo.txtExtensionName.Text = .Person_extension_name

                If .Person_gender = "Male" Then
                    EmpInfo.rbtnMale.Checked = True
                Else
                    EmpInfo.rbtnFemale.Checked = True
                End If

                EmpInfo.txtMobileNumber.Text = .Person_mobile_no
                EmpInfo.txtTelephoneNumber.Text = .Person_tel_no
                EmpInfo.dtpDOB.Value = .Person_date_of_birth

                If .Employee_type = "Official" Then
                    EmpInfo.rbtnOfficial.Checked = True
                Else
                    EmpInfo.rbtnStaff.Checked = True
                End If

                EmpInfo.txtPosition.Text = .Employee_position
                EmpInfo.txtStatus.Text = .Employee_status

            End With

            EmpInfo.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class