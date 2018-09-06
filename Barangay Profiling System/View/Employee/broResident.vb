Imports MySql.Data.MySqlClient
Public Class broResident

    Private EmployeeObj As New EmployeeClass
    'Private frmEmployee As New frmEmployee
    Private Sub broResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With EmployeeObj
                .LoadPersonAtEmployee(dgvBrowsePerson)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try

            EmployeeObj = New EmployeeClass

            With EmployeeObj
                .GetPersonDetails(dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString)
                frmEmployee._idperson = .Idperson
                frmEmployee.txtFirstName.Text = .Person_first_name
                frmEmployee.txtMiddleName.Text = .Person_middle_name
                frmEmployee.txtLastName.Text = .Person_last_name
                frmEmployee.txtExtensionName.Text = .Person_extension_name
                If .Person_gender = "Female" Then
                    frmEmployee.rbtnFemale.Checked = True
                ElseIf .Person_gender = "Male" Then
                    frmEmployee.rbtnMale.Checked = True

                End If
                frmEmployee.txtMobileNumber.Text = .Person_mobile_no
                frmEmployee.txtTelephoneNumber.Text = .Person_tel_no
                frmEmployee.dtpDOB.Value = .Person_date_of_birth
                Close()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Close()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        Try
            EmployeeObj = New EmployeeClass
            With EmployeeObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchPersonAtEmployee(dgvBrowsePerson, txtSearch.Text)
                Else
                    broResident_Load(sender, e)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            broResident_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvBrowsePerson_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowsePerson.CellContentClick

    End Sub

    Private Sub dgvBrowsePerson_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dgvBrowsePerson.CellContextMenuStripNeeded

    End Sub

    Private Sub dgvBrowsePerson_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowsePerson.CellDoubleClick

        frmEmployee.Label1.Text = dgvBrowsePerson.Rows(dgvBrowsePerson.CurrentRow.Index).Cells(0).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With EmployeeObj
                If txtSearch.Text.Trim.Length > 0 Then

                Else
                    .LoadPersonAtEmployee(dgvBrowsePerson)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class