Public Class frmCaseDetails
    Public Shared _idCase As Integer = 0

    Private CaseObj As New CaseClass
    Private Sub dgvHearing_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHearing.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvHearing.Rows(e.RowIndex).Selected = True
                dgvHearing.CurrentCell = dgvHearing.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvHearing.SelectedRows(0).Cells(2).Value.ToString = "Open" Then
                    ContextMenuStrip1.Show(dgvHearing, e.Location)
                    CompleteThisHearingToolStripMenuItem.Visible = True
                    ContextMenuStrip1.Show(Cursor.Position)

                Else
                    ContextMenuStrip1.Show(dgvHearing, e.Location)
                    CompleteThisHearingToolStripMenuItem.Visible = False
                    ContextMenuStrip1.Show(Cursor.Position)

                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ViewMoreDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMoreDetailsToolStripMenuItem.Click
        Try
            With frmHearingDetails
                If dgvHearing.SelectedRows(0).Cells(2).Value.ToString = "Open" Then
                    .txtCaseCode.Text = txtCaseCode.Text
                    .txtHearingDesc.Text = txtDescription.Text
                    .dtpHearingDate.Value = dgvHearing.SelectedRows(0).Cells(1).Value.ToString
                    .txtcodehearing.Text = dgvHearing.SelectedRows(0).Cells(0).Value.ToString
                    .lblStatus.Text = dgvHearing.SelectedRows(0).Cells(2).Value.ToString
                    .btnSave.Visible = True
                    .txtHearingDesc.Enabled = True
                    .txtHearingWitness.Enabled = True
                    .txtRemarks.Enabled = True
                    .ShowDialog()
                Else
                    'load case_has_hearing
                    .txtCaseCode.Text = txtCaseCode.Text
                    .txtHearingDesc.Text = txtDescription.Text
                    .dtpHearingDate.Value = dgvHearing.SelectedRows(0).Cells(1).Value.ToString
                    .txtcodehearing.Text = dgvHearing.SelectedRows(0).Cells(0).Value.ToString
                    .lblStatus.Text = dgvHearing.SelectedRows(0).Cells(2).Value.ToString
                    .btnSave.Visible = False
                    .txtHearingDesc.Enabled = False
                    .txtHearingWitness.Enabled = False
                    .txtRemarks.Enabled = False
                    CaseObj.LoadHearingDetails(txtCaseCode.Text)
                    .txtHearingWitness.Text = CaseObj.Case_has_hearing_witness
                    .txtRemarks.Text = CaseObj.Case_has_hearing_remarks
                    .ShowDialog()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CompleteThisHearingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompleteThisHearingToolStripMenuItem.Click
        Try
            frmHearingDetails.txtTrigger.Text = "Close"
            frmHearingDetails.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCaseDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCaseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class