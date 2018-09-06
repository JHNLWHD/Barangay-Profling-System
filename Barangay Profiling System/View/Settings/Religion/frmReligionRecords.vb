Public Class frmReligionRecords

    Private PersonObj As New PersonClass
    Private Sub frmReligionRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With PersonObj
                .LoadReligionRecords(dgvReligion, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateReligionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateReligionToolStripMenuItem.Click
        'ACTIVATE Religion
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Idreligion = dgvReligion.SelectedRows(0).Cells(0).Value.ToString
                .Religion_status = "Active"
                If .ActivateDeactivateReligion("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveReligionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveReligionToolStripMenuItem.Click
        'REMOVE Religion
        Try
            PersonObj = New PersonClass
            With PersonObj
                .Religion_remove_status = "True"
                .Religion_status = "Inactive"
                .Idreligion = dgvReligion.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveReligion = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                .Idreligion = dgvReligion.SelectedRows(0).Cells(0).Value.ToString
                .Religion_status = "Inactive"
                If .ActivateDeactivateReligion("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvReligion.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveReligionToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveReligionToolStripMenuItem8.Click
        Try
            RemoveReligionToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvReligion_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvReligion.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvReligion.Rows(e.RowIndex).Selected = True
                dgvReligion.CurrentCell = dgvReligion.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvReligion.SelectedRows.Count = 1 Then

                    If dgvReligion.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmReligionDeactivate.Show(dgvReligion, e.Location)
                        cmReligionDeactivate.Show(Cursor.Position)
                    ElseIf dgvReligion.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmReligionActivate.Show(dgvReligion, e.Location)
                        cmReligionActivate.Show(Cursor.Position)
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
            Dim rpt As New Religion

            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idreligion")
                .Add("religion_name")
                .Add("religion_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvReligion.Rows.Count - 1
                dt.Rows.Add(dgvReligion.Rows(i).Cells(0).Value.ToString,
            dgvReligion.Rows(i).Cells(1).Value.ToString,
                dgvReligion.Rows(i).Cells(2).Value.ToString)
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
                    .SearchReligionRecords(dgvReligion, "ALL", 0, txtSearch.Text)
                Else
                    .LoadReligionRecords(dgvReligion, "ALL", 0)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class