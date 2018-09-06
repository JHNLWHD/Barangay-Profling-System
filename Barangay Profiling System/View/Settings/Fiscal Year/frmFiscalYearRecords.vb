Public Class frmFiscalYearRecords

    Private FiscalYearObj As New FiscalYearClass
    Private Sub frmFiscalYearRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With FiscalYearObj
                txtSearch.Text = String.Empty
                .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With FiscalYearObj
                If txtSearch.Text.Trim.Length = 0 Then
                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                ElseIf txtSearch.Text.Trim.Length >= 0 Then
                    .SearchFiscalYearRecords(dgvFiscalYear, "All", 0, txtSearch.Text)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvFiscalYear_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvFiscalYear.CellMouseUp
        If e.Button = MouseButtons.Right Then
            dgvFiscalYear.Rows(e.RowIndex).Selected = True
            dgvFiscalYear.CurrentCell = dgvFiscalYear.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If dgvFiscalYear.SelectedRows.Count = 1 Then

                If dgvFiscalYear.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                    'active
                    cmFYActionsActive.Show(dgvFiscalYear, e.Location)
                    cmFYActionsActive.Show(Cursor.Position)
                ElseIf dgvFiscalYear.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                    'inactive
                    cmFYActionsInactive.Show(dgvFiscalYear, e.Location)
                    cmFYActionsInactive.Show(Cursor.Position)
                End If

            End If
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            With FiscalYearObj
                If .GetActiveFiscalYear = True Then
                    If String.Compare(.Fiscal_year_obj.ToString, dgvFiscalYear.SelectedRows(0).Cells(0).Value.ToString, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                        MessageBox.Show(String.Format("{0} is the currently active fiscal year.", .Fiscal_year_obj), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                        Exit Sub
                    Else
                        .Fiscal_year_remove_status = "True"
                        .Idfiscal_year = dgvFiscalYear.SelectedRows(0).Cells(0).Value.ToString
                        .Fiscal_year_status = "Inactive"
                        If .RemoveFiscalYear = True Then
                            MessageBox.Show(String.Format("{0} is removed.", dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                            Exit Sub
                        Else
                            MessageBox.Show(String.Format("{0} failed to be removed.", dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem2.Click
        RemoveToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ActivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateToolStripMenuItem.Click
        'deactivate
        Try
            With FiscalYearObj
                If dgvFiscalYear.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                    MessageBox.Show(String.Format("{0} is already activated.", dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                    Exit Sub
                Else
                    .Fiscal_year = dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString
                    If .GetActiveFiscalYear = True Then
                        If .Fiscal_year_obj = .Fiscal_year Then

                        Else
                            .Fiscal_year_obj += 1
                            If .Fiscal_year_obj = .Fiscal_year Then
                                .Idfiscal_year = dgvFiscalYear.SelectedRows(0).Cells(0).Value.ToString
                                .Fiscal_year_status = "Inactive"
                                If .ActivateFiscalYear = True Then
                                    MessageBox.Show(String.Format("{0} is now deactivated.", .Fiscal_year), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    'sync
                                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                    Exit Sub
                                Else

                                    MessageBox.Show(String.Format("{0} failed to be deactivated.", .Fiscal_year), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                    Exit Sub
                                End If
                            ElseIf .Fiscal_year_obj > .Fiscal_year Then
                                'msg
                                MessageBox.Show(String.Format("{0} is early than current fiscal year: {1}.", .Fiscal_year, FiscalYearObj), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                Exit Sub
                            ElseIf .Fiscal_year_obj < .Fiscal_year Then
                                'msg
                                MessageBox.Show(String.Format("{0} is too advanced to the next fiscal year: {1}.", .Fiscal_year, FiscalYearObj), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                Exit Sub
                            End If
                        End If

                    End If
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub InactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactiveToolStripMenuItem.Click
        Try
            FiscalYearObj = New FiscalYearClass
            With FiscalYearObj
                If dgvFiscalYear.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                    'MetroMessageBox.Show(Me, String.Format("Connection Error." + vbCrLf + "Please check your connection settings"), My.Application.Info.Title + " says:", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
                    MessageBox.Show(String.Format("{0} is already activated.", dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                    Exit Sub
                Else
                    .Fiscal_year = dgvFiscalYear.SelectedRows(0).Cells(1).Value.ToString
                    If .GetActiveFiscalYear = True Then
                        If .Fiscal_year_obj = .Fiscal_year Then

                        Else
                            .Fiscal_year_obj += 1
                            If .Fiscal_year_obj = .Fiscal_year Then
                                .Idfiscal_year = dgvFiscalYear.SelectedRows(0).Cells(0).Value.ToString
                                .Fiscal_year_status = "Active"
                                If .ActivateFiscalYear = True Then
                                    MessageBox.Show(String.Format("{0} is now activated.", .Fiscal_year), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                                    'sync
                                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                    Exit Sub
                                Else
                                    MessageBox.Show(String.Format("{0} is failed to activate.", .Fiscal_year), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                    Exit Sub
                                End If
                            ElseIf .Fiscal_year_obj > .Fiscal_year Then
                                'msg
                                MessageBox.Show(String.Format("{0} is early than current fiscal year: {1}.", .Fiscal_year, FiscalYearObj), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                                .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                Exit Sub
                            ElseIf .Fiscal_year_obj < .Fiscal_year Then
                                'msg
                                MessageBox.Show(String.Format("{0} is too advanced to the next fiscal year: {1}.", .Fiscal_year, FiscalYearObj), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Question)
                                .LoadFiscalYearRecords(dgvFiscalYear, "ALL", 0)
                                Exit Sub
                            End If
                        End If

                    End If
                End If
            End With

        Catch ex As Exception
            'MetroMessageBox.Show(Me, String.Format("Connection Error." + vbCrLf + "Please check your connection settings"), My.Application.Info.Title + " says:", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
        End Try
    End Sub

    Private Sub frmFiscalYearRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New FiscalReport

            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idfiscal_year")
                .Add("fiscal_year_date")
                .Add("fiscal_year_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvFiscalYear.Rows.Count - 1
                dt.Rows.Add(dgvFiscalYear.Rows(i).Cells(0).Value.ToString,
            dgvFiscalYear.Rows(i).Cells(1).Value.ToString,
                dgvFiscalYear.Rows(i).Cells(2).Value.ToString)
            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            frmFiscalYearRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class