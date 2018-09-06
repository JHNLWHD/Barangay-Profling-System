Public Class frmAddHouseOwner

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Try
            txtAge.Text = GetCurrentAge(dtpDOB.Value, getDate)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtFirstName.Text <> "" And txtLastName.Text <> "" And txtAge.Text <> "" And txtPOB.Text <> "" And txtMobileNumber.Text <> "" And cboCivilStatus.Text <> "" Then


                frmHouse.txtHouseOwnerName.Text = String.Format("{0} {1} {2} {3}", txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtExtensionName.Text)
                Hide()

            Else
                MsgBox("Please fill up the fields.")
                Exit Sub

            End If

        Catch ex As Exception



        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged

    End Sub

    Private Sub frmAddHouseOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class