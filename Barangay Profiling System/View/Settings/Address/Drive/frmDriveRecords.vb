Public Class frmDriveRecords

    Private AddressObj As New AddressClass
    Private Sub frmDriveRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSearch.Text = String.Empty
            With AddressObj
                .LoadDriveRecords(dgvDrive, "ALL", 0)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActivateDriveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateDriveToolStripMenuItem.Click
        'ACTIVATE Drive
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Iddrive = dgvDrive.SelectedRows(0).Cells(0).Value.ToString
                .Drive_status = "Active"
                If .ActivateDeactivateDrive("activated") = True Then
                    MessageBox.Show(String.Format("{0} is now activated.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} is failed to be activated.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveDriveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveDriveToolStripMenuItem.Click
        'REMOVE Drive
        Try
            AddressObj = New AddressClass
            With AddressObj
                .Drive_remove_status = "True"
                .Drive_status = "Inactive"
                .Iddrive = dgvDrive.SelectedRows(0).Cells(0).Value.ToString
                If .RemoveDrive = True Then
                    MessageBox.Show(String.Format("{0} is removed.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                    txtSearch.Text = String.Empty
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be removed.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                .Iddrive = dgvDrive.SelectedRows(0).Cells(0).Value.ToString
                .Drive_status = "Inactive"
                If .ActivateDeactivateDrive("deactivated") = True Then
                    MessageBox.Show(String.Format("{0} is now deactivated.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = String.Empty
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                    Exit Sub
                Else
                    MessageBox.Show(String.Format("{0} failed to be deactivated.", dgvDrive.SelectedRows(0).Cells(1).Value.ToString), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveDriveToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles RemoveDriveToolStripMenuItem8.Click
        Try
            RemoveDriveToolStripMenuItem_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDrive_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDrive.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvDrive.Rows(e.RowIndex).Selected = True
                dgvDrive.CurrentCell = dgvDrive.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If dgvDrive.SelectedRows.Count = 1 Then

                    If dgvDrive.SelectedRows(0).Cells(2).Value.ToString = "Active" Then
                        cmDriveDeactivate.Show(dgvDrive, e.Location)
                        cmDriveDeactivate.Show(Cursor.Position)
                    ElseIf dgvDrive.SelectedRows(0).Cells(2).Value.ToString = "Inactive" Then
                        cmDriveActivate.Show(dgvDrive, e.Location)
                        cmDriveActivate.Show(Cursor.Position)
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
            Dim rpt As New DriveReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("iddrive")
                .Add("drive_name")
                .Add("drive_status")


            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvDrive.Rows.Count - 1
                dt.Rows.Add(dgvDrive.Rows(i).Cells(0).Value.ToString,
            dgvDrive.Rows(i).Cells(1).Value.ToString,
                               dgvDrive.Rows(i).Cells(2).Value.ToString)
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
                    .SearchDriveRecords(dgvDrive, "ALL", 0, txtSearch.Text)
                Else
                    .LoadDriveRecords(dgvDrive, "ALL", 0)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class