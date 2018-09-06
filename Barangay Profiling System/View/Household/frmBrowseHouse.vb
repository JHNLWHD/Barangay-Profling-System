Public Class frmBrowseHouse

    Private HouseObj As HouseClass

    Private Sub frmBrowseHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            HouseObj = New HouseClass
            With HouseObj
                .LoadHouseRecords(dgvHouse, "Active")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHouse_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHouse.CellContentDoubleClick
        Try
            frmHousehold.houseid = dgvHouse.SelectedRows(0).Cells(0).Value.ToString
            frmHousehold.txtHousecode.Text = dgvHouse.SelectedRows(0).Cells(1).Value.ToString
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHouse_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHouse.CellDoubleClick
        Try
            frmHousehold.houseid = dgvHouse.SelectedRows(0).Cells(0).Value.ToString
            frmHousehold.txtHousecode.Text = dgvHouse.SelectedRows(0).Cells(1).Value.ToString
            Close()
        Catch ex As Exception

        End Try
    End Sub
End Class