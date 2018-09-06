Public Class frmStreetRecords

    Private AddressObj As New AddressClass
    Private Sub frmStreetRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With AddressObj
                .LoadStreetRecords(dgvStreet, "All", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateStreetToolStripMenuItem.Click
        'ACTIVATE Street
        Try
            With AddressObj
                .Idstreet = dgvStreet.SelectedRows(0).Cells(0).Value.ToString
                .Street_status = "Active"
                If .ActivateDeactivateStreet("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadStreetRecords(dgvStreet, "All", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadStreetRecords(dgvStreet, "All", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveStreetToolStripMenuItem.Click
        'REMOVE Street
        Try
            With AddressObj
                .Street_remove_status = "True"
                .Street_status = "Inactive"
                .Idstreet = dgvStreet.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveStreet = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadStreetRecords(dgvStreet, "All", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeactivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeactivateToolStripMenuItem.Click
        Try
            With AddressObj
                .Idstreet = dgvStreet.SelectedRows(0).Cells(0).Value.ToString
                .Street_status = "Inactive"
                If .ActivateDeactivateStreet("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadStreetRecords(dgvStreet, "All", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvStreet.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadStreetRecords(dgvStreet, "All", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveStreetToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveStreetToolStripMenuItem8.Click
        Try
            RemoveStreetToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvStreet_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStreet.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvStreet.Rows(e.RowIndex).Selected = True
                dgvStreet.CurrentCell = dgvStreet.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvStreet.SelectedRows.Count = 1 Then

                    If dgvStreet.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmStreetDeactivate.Show(dgvStreet, e.Location)
                        cmStreetDeactivate.Show(Cursor.Position)
                    ElseIf dgvStreet.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmStreetActivate.Show(dgvStreet, e.Location)
                        cmStreetActivate.Show(Cursor.Position)
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
            Dim rpt As New StreetReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("idstreet")
                .Add("street_name")
                .Add("street_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvStreet.Rows.Count - 1
                dt.Rows.Add(dgvStreet.Rows(i).Cells(0).Value.ToString,
            dgvStreet.Rows(i).Cells(1).Value.ToString,
                dgvStreet.Rows(i).Cells(2).Value.ToString)
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
            frmStreetRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With AddressObj
                If txtSearch.Text.Trim.Length > 0 Then
                    .SearchStreetRecords(dgvStreet, "All", 0, txtSearch.Text)
                Else
                    .LoadStreetRecords(dgvStreet, "All", 0)
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub
End Class