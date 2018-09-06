Public Class frmOccupationRecords

    Private PersonObj As New PersonClass
    Private Sub frmOccupationRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With PersonObj
                .LoadOccupationRecords(dgvOccupation, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateOccupationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateOccupationToolStripMenuItem.Click
        'ACTIVATE Occupation
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Idoccupation = dgvOccupation.SelectedRows(0).Cells(0).Value.ToString
                .Occupation_status = "Active"
                If .ActivateDeactivateOccupation("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveOccupationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveOccupationToolStripMenuItem.Click
        'REMOVE Occupation
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Occupation_remove_status = "True"
                .Occupation_status = "Inactive"
                .Idoccupation = dgvOccupation.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveOccupation = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                .Idoccupation = dgvOccupation.SelectedRows(0).Cells(0).Value.ToString
                .Occupation_status = "Inactive"
                If .ActivateDeactivateOccupation("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvOccupation.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveOccupationToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveOccupationToolStripMenuItem8.Click
        Try
            RemoveOccupationToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvOccupation_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOccupation.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvOccupation.Rows(e.RowIndex).Selected = True
                dgvOccupation.CurrentCell = dgvOccupation.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvOccupation.SelectedRows.Count = 1 Then

                    If dgvOccupation.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmOccupationDeactivate.Show(dgvOccupation, e.Location)
                        cmOccupationDeactivate.Show(Cursor.Position)
                    ElseIf dgvOccupation.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmOccupationActivate.Show(dgvOccupation, e.Location)
                        cmOccupationActivate.Show(Cursor.Position)
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
            Dim rpt As New OccupationReport

            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idoccupation")
                .Add("occupation_name")
                .Add("occupation_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvOccupation.Rows.Count - 1
                dt.Rows.Add(dgvOccupation.Rows(i).Cells(0).Value.ToString,
            dgvOccupation.Rows(i).Cells(1).Value.ToString,
                dgvOccupation.Rows(i).Cells(2).Value.ToString)
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
            With PersonObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchOccupationRecords(dgvOccupation, "ALL", 0, txtSearch.Text)
                Else
                    .LoadOccupationRecords(dgvOccupation, "ALL", 0)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class