Public Class frmPurokRecords

    Private AddressObj As New AddressClass
    Private Sub frmPurokRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With AddressObj
                .LoadPurokRecords(dgvPurok, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivatePurokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivatePurokToolStripMenuItem.Click
        'ACTIVATE purok
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Idpurok = dgvPurok.SelectedRows(0).Cells(0).Value.ToString
                .Purok_status = "Active"
                If .ActivateDeactivatePurok("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemovePurokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePurokToolStripMenuItem.Click
        'REMOVE purok
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Purok_remove_status = "True"
                .Purok_status = "Inactive"
                .Idpurok = dgvPurok.SelectedRows(0).Cells(0).Value.ToString
                If .RemovePurok = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                .Idpurok = dgvPurok.SelectedRows(0).Cells(0).Value.ToString
                .Purok_status = "Inactive"
                If .ActivateDeactivatePurok("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvPurok.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemovePurokToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemovePurokToolStripMenuItem8.Click
        Try
            RemovePurokToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvPurok_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPurok.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvPurok.Rows(e.RowIndex).Selected = True
                dgvPurok.CurrentCell = dgvPurok.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvPurok.SelectedRows.Count = 1 Then

                    If dgvPurok.SelectedRows(0).Cells(2).Value.ToString = "Active" Then

                        cmPurokDeactivate.Show(dgvPurok, e.Location)
                        cmPurokDeactivate.Show(Cursor.Position)
                    ElseIf dgvPurok.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then

                        cmPurokActivate.Show(dgvPurok, e.Location)
                        cmPurokActivate.Show(Cursor.Position)
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
            Dim rpt As New PurokReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idpurok")
                .Add("purok_name")
                .Add("purok_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvPurok.Rows.Count - 1
                dt.Rows.Add(dgvPurok.Rows(i).Cells(0).Value.ToString,
            dgvPurok.Rows(i).Cells(1).Value.ToString,
                dgvPurok.Rows(i).Cells(2).Value.ToString)
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
                    .SearchPurokRecords(dgvPurok, "ALL", 0, txtSearch.Text)
                Else
                    .LoadPurokRecords(dgvPurok, "ALL", 0)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmPurokRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class