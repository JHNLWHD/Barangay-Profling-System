Public Class frmHouseRecord

    Private HouseObj As New HouseClass
    Private HouseHoldObj As New HouseholdClass
    Private Sub frmHouseRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With HouseObj
                'HouseInfo.ShowDialog()
                .LoadHouseDetails(dgvHouse, "Active")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewCurrentOwnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCurrentOwnerToolStripMenuItem.Click
        Try
            'Current Lot Owner
            With HouseHoldObj

                .LoadLotOwnerHistory("Current", dgvHouse.SelectedRows(0).Cells(0).Value.ToString, "Active")
                With LotOwnerInfo
                    .txtLastName.Text = HouseHoldObj.Person_last_name
                    .txtFirstname.Text = HouseHoldObj.Person_first_name
                    .txtMiddleName.Text = HouseHoldObj.Person_middle_name
                    .txtExtensionName.Text = HouseHoldObj.Person_extension_name
                    .txtDob.Text = HouseHoldObj.Person_date_of_birth
                    .txtAge.Text = GetCurrentAge(Date.Parse(.txtDob.Text), getDate)
                    .txtMobileNumber.Text = HouseHoldObj.Person_mobile_no
                    .txtTelephoneNumber.Text = HouseHoldObj.Person_tel_no
                    .txtCivilStatus.Text = HouseHoldObj.Person_civil_status
                    .txtPob.Text = HouseHoldObj.Person_place_of_birth
                    .txtResidencyStatus.Text = HouseHoldObj.Person_status
                    .txtGender.Text = HouseHoldObj.Person_gender
                    .ShowDialog()

                End With

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ViewHouseHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHouseHistoryToolStripMenuItem.Click
        Try
            'House History
            With HouseObj
                .LoadHouseHistory(HouseHistory.dgvHistory, dgvHouse.SelectedRows(0).Cells(3).Value.ToString)
                HouseHistory.txtHouseCode.Text = .House_code
                HouseHistory.txtHouseName.Text = .House_name
                HouseHistory.txtHouseType.Text = .House_type

                .GetAddressDetails(dgvHouse.SelectedRows(0).Cells(0).Value.ToString)
                HouseHistory.txtHouseAddress.Text = .Address_name
                HouseHistory.ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHouse_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHouse.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvHouse.Rows(e.RowIndex).Selected = True
                dgvHouse.CurrentCell = dgvHouse.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvHouse.SelectedRows.Count = 1 Then
                    cmActions.Show(dgvHouse, e.Location)
                    cmActions.Show(Cursor.Position)
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub ViewHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHistoryToolStripMenuItem.Click
        Try
            'Lot owner history
            With HouseHoldObj
                .LoadLotOwnerHistoryDgv(ShowOwnerHistoryHouse.dgvHistory, dgvHouse.SelectedRows(0).Cells(0).Value.ToString)
                ShowOwnerHistoryHouse.ShowDialog()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewHouseInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHouseInformationToolStripMenuItem.Click
        Try
            With HouseObj
                .GetLotOwnerInfoDetails(dgvHouse.SelectedRows(0).Cells(3).Value.ToString)
                HouseInfo.txtLotcode.Text = .Lot_house_code
                HouseInfo.txtHousecode.Text = .House_code
                HouseInfo.txtHouselevel.Text = .House_level
                HouseInfo.txtHousename.Text = .House_name
                HouseInfo.txtHousetype.Text = .House_type
                HouseInfo.txtHouseAddress.Text = .Address_name
                HouseInfo.txtSettlementStatus.Text = .House_settlement_status
                HouseInfo.txtRemarks.Text = .House_remarks

                HouseInfo.txtLotowner.Text = String.Format("{0} {1} {2} {3}", .Person_first_name,
                                           .Person_middle_name, .Person_last_name, .Person_extension_name)

                .GetLotOwnerInfoDetails(dgvHouse.SelectedRows(0).Cells(3).Value.ToString)
                HouseInfo.txtHouseowner.Text = String.Format("{0} {1} {2} {3}", .Person_first_name,
                                           .Person_middle_name, .Person_last_name, .Person_extension_name)

                HouseInfo.ShowDialog()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewCurrentOwnerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewCurrentOwnerToolStripMenuItem1.Click
        Try
            'Current House owner info
            With HouseHoldObj

                .LoadHouseOwnerHistory("Current", dgvHouse.SelectedRows(0).Cells(3).Value.ToString, "Active")
                With HouseOwnerInfo

                    .txtLastName.Text = HouseHoldObj.Person_last_name
                    .txtFirstname.Text = HouseHoldObj.Person_first_name
                    .txtMiddleName.Text = HouseHoldObj.Person_middle_name
                    .txtExtensionName.Text = HouseHoldObj.Person_extension_name
                    .txtDob.Text = HouseHoldObj.Person_date_of_birth
                    .txtAge.Text = GetCurrentAge(Date.Parse(.txtDob.Text), getDate)
                    .txtMobileNumber.Text = HouseHoldObj.Person_mobile_no
                    .txtTelephoneNumber.Text = HouseHoldObj.Person_tel_no
                    .txtCivilStatus.Text = HouseHoldObj.Person_civil_status
                    .txtPob.Text = HouseHoldObj.Person_place_of_birth
                    .txtResidencyStatus.Text = HouseHoldObj.Person_status
                    .txtGender.Text = HouseHoldObj.Person_gender
                    .ShowDialog()

                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ViewHistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewHistoryToolStripMenuItem1.Click
        Try
            With HouseHoldObj
                .LoadHouseOwnerHistoryDgv(ShowOwnerHistoryHouse.dgvHistory, dgvHouse.SelectedRows(0).Cells(3).Value.ToString)
                ShowOwnerHistoryHouse.ShowDialog()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With HouseObj
                If txtSearch.Text.Trim <> vbNullString Then
                    .SearchHouseDetails(dgvHouse, "Active", txtSearch.Text)
                Else
                    frmHouseRecord_Load(sender, e)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtSearch.Clear()
            frmHouseRecord_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New HouseReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idhouse")
                .Add("lot_code")
                .Add("address")
                .Add("house_code")
                .Add("settlement_status")
                .Add("house_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvHouse.Rows.Count - 1
                dt.Rows.Add(dgvHouse.Rows(i).Cells(0).Value.ToString,
            dgvHouse.Rows(i).Cells(1).Value.ToString,
            dgvHouse.Rows(i).Cells(2).Value.ToString,
              dgvHouse.Rows(i).Cells(4).Value.ToString,
           dgvHouse.Rows(i).Cells(5).Value.ToString,
             dgvHouse.Rows(i).Cells(6).Value.ToString)

            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class