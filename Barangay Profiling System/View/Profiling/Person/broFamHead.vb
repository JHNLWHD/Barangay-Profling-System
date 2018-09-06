Public Class broFamHead
    Private HouseholdObj As New HouseholdClass
    Private HouseObj As New HouseClass
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            frmProfiling.txtHouseholdHead.Text = dgvBrowsePerson.SelectedRows(0).Cells(4).Value.ToString
            frmProfiling.txtHouseCode.Text = dgvBrowsePerson.SelectedRows(0).Cells(2).Value.ToString
            frmProfiling._idhouse = dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString
            HouseObj.GetHouseDetails(dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString)
            frmProfiling._idhousehold = dgvBrowsePerson.SelectedRows(0).Cells(3).Value.ToString
            With HouseObj
                frmProfiling.txtHouseAddress.Text = .Address_name
                .GetHouseOwnerInfoDetails(dgvBrowsePerson.SelectedRows(0).Cells(1).Value.ToString)
                frmProfiling.txtHouseOwner.Text = String.Format("{0} {1} {2} {3}", .Person_first_name, .Person_middle_name,
                                                                .Person_last_name, .Person_extension_name)
            End With
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub broFamHead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            HouseholdObj.LoadHouseholdhead(dgvBrowsePerson)
        Catch ex As Exception

        End Try
    End Sub
End Class