Public Class frmHouseholdRecords
    Private HouseholdObj As HouseholdClass
    Private Sub frmHouseholdRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            HouseholdObj = New HouseholdClass
            txtSearch.Text = String.Empty
            With HouseholdObj
                .LoadHouseholdRecords(dgvHousehold)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmHouseholdRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            HouseholdObj = New HouseholdClass
            With HouseholdObj
                If txtSearch.Text.Trim <> vbNullString Then
                    .SearchHouseholdRecords(dgvHousehold, txtSearch.Text)
                Else
                    frmHouseholdRecords_Load(sender, e)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHousehold_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHousehold.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvHousehold.Rows(e.RowIndex).Selected = True
                dgvHousehold.CurrentCell = dgvHousehold.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvHousehold.SelectedRows.Count = 1 Then
                    cmActions.Show(dgvHousehold, e.Location)
                    cmActions.Show(Cursor.Position)
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub ViewHouseholdMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHouseholdMembersToolStripMenuItem.Click
        Try
            HouseholdObj = New HouseholdClass
            With HouseholdMember
                .txtHouseholdCode.Text = dgvHousehold.SelectedRows(0).Cells(2).Value.ToString
                .txtHouseCode.Text = dgvHousehold.SelectedRows(0).Cells(3).Value.ToString
                .txtHeadname.Text = dgvHousehold.SelectedRows(0).Cells(5).Value.ToString
                HouseholdObj.LoadHouseholdMember(.dgvMember, dgvHousehold.SelectedRows(0).Cells(5).Value.ToString)
                .ShowDialog()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New HouseHoldReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idhousehold")
                .Add("household_code")
                .Add("house_code")
                .Add("status")
                .Add("headName")
                .Add("role")


            End With


            For i As Integer = 0 To dgvHousehold.Rows.Count - 1
                dt.Rows.Add(dgvHousehold.Rows(i).Cells(0).Value.ToString,
            dgvHousehold.Rows(i).Cells(2).Value.ToString,
             dgvHousehold.Rows(i).Cells(3).Value.ToString,
              dgvHousehold.Rows(i).Cells(4).Value.ToString,
                               dgvHousehold.Rows(i).Cells(5).Value.ToString,
           dgvHousehold.Rows(i).Cells(6).Value.ToString)

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