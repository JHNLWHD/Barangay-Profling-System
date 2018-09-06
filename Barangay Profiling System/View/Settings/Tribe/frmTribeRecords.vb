Public Class frmTribeRecords

    Private PersonObj As New PersonClass
    Private Sub frmTribeRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With PersonObj
                .LoadTribeRecords(dgvTribe, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateTribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateTribeToolStripMenuItem.Click
        'ACTIVATE Tribe
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Idtribe = dgvTribe.SelectedRows(0).Cells(0).Value.ToString
                .Tribe_status = "Active"
                If .ActivateDeactivateTribe("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadTribeRecords(dgvTribe, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadTribeRecords(dgvTribe, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveTribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTribeToolStripMenuItem.Click
        'REMOVE Tribe
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Tribe_remove_status = "True"
                .Tribe_status = "Inactive"
                .Idtribe = dgvTribe.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveTribe = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadTribeRecords(dgvTribe, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeactivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeactivateToolStripMenuItem.Click
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Idtribe = dgvTribe.SelectedRows(0).Cells(0).Value.ToString
                .Tribe_status = "Inactive"
                If .ActivateDeactivateTribe("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadTribeRecords(dgvTribe, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvTribe.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadTribeRecords(dgvTribe, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveTribeToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveTribeToolStripMenuItem8.Click
        Try
            RemoveTribeToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvTribe_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTribe.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvTribe.Rows(e.RowIndex).Selected = True
                dgvTribe.CurrentCell = dgvTribe.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvTribe.SelectedRows.Count = 1 Then

                    If dgvTribe.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmTribeDeactivate.Show(dgvTribe, e.Location)
                        cmTribeDeactivate.Show(Cursor.Position)
                    ElseIf dgvTribe.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmTribeActivate.Show(dgvTribe, e.Location)
                        cmTribeActivate.Show(Cursor.Position)
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
            Dim rpt As New TribeReport

            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idtribe")
                .Add("tribe_name")
                .Add("tribe_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvTribe.Rows.Count - 1
                dt.Rows.Add(dgvTribe.Rows(i).Cells(0).Value.ToString,
            dgvTribe.Rows(i).Cells(1).Value.ToString,
                dgvTribe.Rows(i).Cells(2).Value.ToString)
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