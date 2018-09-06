Public Class frmRoadRecords

    Private AddressObj As New AddressClass
    Private Sub frmRoadRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With AddressObj
                .LoadRoadRecords(dgvRoad, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateRoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateRoadToolStripMenuItem.Click
        'ACTIVATE Road
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Idroad = dgvRoad.SelectedRows(0).Cells(0).Value.ToString
                .Road_status = "Active"
                If .ActivateDeactivateRoad("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveRoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveRoadToolStripMenuItem.Click
        'REMOVE Road
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Road_remove_status = "True"
                .Road_status = "Inactive"
                .Idroad = dgvRoad.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveRoad = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeactivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeactivateToolStripMenuItem.Click
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Idroad = dgvRoad.SelectedRows(0).Cells(0).Value.ToString
                .Road_status = "Inactive"
                If .ActivateDeactivateRoad("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvRoad.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveRoadToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveRoadToolStripMenuItem8.Click
        Try
            RemoveRoadToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRoad_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRoad.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvRoad.Rows(e.RowIndex).Selected = True
                dgvRoad.CurrentCell = dgvRoad.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvRoad.SelectedRows.Count = 1 Then

                    If dgvRoad.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmRoadActivate.Show(dgvRoad, e.Location)
                        cmRoadActivate.Show(Cursor.Position)
                    ElseIf dgvRoad.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmRoadDeactivate.Show(dgvRoad, e.Location)
                        cmRoadDeactivate.Show(Cursor.Position)
                    End If

                End If
            Catch ex As Exception
                'MessageBox.Show("Connection Error." + vbCrLf + "Please check your connection settings", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New RoadReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idroad")
                .Add("road_name")
                .Add("road_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvRoad.Rows.Count - 1
                dt.Rows.Add(dgvRoad.Rows(i).Cells(0).Value.ToString,
            dgvRoad.Rows(i).Cells(1).Value.ToString,
                dgvRoad.Rows(i).Cells(2).Value.ToString)
            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With AddressObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchRoadRecords(dgvRoad, "ALL", 0, txtSearch.Text)
                Else
                    .LoadRoadRecords(dgvRoad, "ALL", 0)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class