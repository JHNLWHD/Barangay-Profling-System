Public Class broEmployee

    Private EmployeeObj As EmployeeClass

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                .GetEmployeeDetails(dgvEmployee.SelectedRows(0).Cells(0).Value.ToString)

                .IdEmployee = .IdEmployee
                frmAccount.txtID.Text = .IdEmployee
                'MsgBox(frmAccount._idEmp)

                .Employee_idemployee = .IdEmployee
                frmAccount.txtFirstName.Text = .Person_first_name
                frmAccount.txtMiddleName.Text = .Person_middle_name
                frmAccount.txtLastName.Text = .Person_last_name
                frmAccount.txtExtensionName.Text = .Person_extension_name

                If .Person_gender = "Female" Then
                    frmAccount.rbtnFemale.Checked = True
                ElseIf .Person_gender = "Male" Then
                    frmAccount.rbtnMale.Checked = True
                End If

                frmAccount.txtMobileNumber.Text = .Person_mobile_no
                frmAccount.txtTelephoneNumber.Text = .Person_tel_no
                frmAccount.dtpDOB.Value = .Person_date_of_birth
                If .Employee_type = "Official" Then
                    frmAccount.txtType.Text = "Official"
                    frmAccount.txtPosition.Text = .Employee_position
                ElseIf .Employee_type = "Staff" Then
                    frmAccount.txtType.Text = "Staff"
                    frmAccount.txtPosition.Text = .Employee_position
                End If

                Close()
                Dispose()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub broEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                .LoadEmployeeMain(dgvEmployee, "All")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Close()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            broEmployee_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                If txtSearch.Text.Length > 0 Then
                    .SearchEmployee(dgvEmployee, txtSearch.Text, 0)
                Else
                    broEmployee_Load(sender, e)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class