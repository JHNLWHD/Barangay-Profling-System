Imports MySql.Data.MySqlClient

Public Class frmCaseRecords

    Private Caseobj As New CaseClass
    Private _dss As New DataSet
    Private Sub frmCaseRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Caseobj
                .LoadCaseDetails(dgvCase)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvCase_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCase.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                dgvCase.Rows(e.RowIndex).Selected = True
                dgvCase.CurrentCell = dgvCase.Rows(e.RowIndex).Cells(e.ColumnIndex)

                If dgvCase.SelectedRows(0).Cells(5).Value.ToString = "Open" Then
                    ContextMenuStrip1.Show(dgvCase, e.Location)
                    ContextMenuStrip1.Show(Cursor.Position)
                Else
                    ContextMenuStrip2.Show(dgvCase, e.Location)
                    ContextMenuStrip2.Show(Cursor.Position)
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub HearingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HearingToolStripMenuItem.Click
        Try
            With Caseobj
                .GetCaseDetails(dgvCase.SelectedRows(0).Cells(0).Value.ToString,
                                frmCaseDetails.dgvHearing, frmCaseDetails.dgvComplainant,
                                frmCaseDetails.dgvRespondent)
                frmCaseDetails.txtCaseCode.Text = .Case_code
                frmCaseDetails.txtCaseType.Text = .Case_type
                frmCaseDetails.txtDescription.Text = .Case_desc

                frmCaseDetails.lblStatus.Text = .Case_remarks



                frmCaseDetails.ShowDialog()
                frmCaseDetails._idCase = .Idcase

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintReportCase_Click(sender As Object, e As EventArgs) Handles btnPrintReportCase.Click
        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New CaseReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("caseCode")
                .Add("caseType")
                .Add("caseDesc")
                .Add("caseReceiveDate")
                .Add("caseRemarks")
                .Add("caseComp")
                .Add("caseRes")



            End With


            For i As Integer = 0 To dgvCase.Rows.Count - 1
                dt.Rows.Add(dgvCase.Rows(i).Cells(1).Value.ToString,
            dgvCase.Rows(i).Cells(2).Value.ToString,
             dgvCase.Rows(i).Cells(3).Value.ToString,
              dgvCase.Rows(i).Cells(4).Value.ToString,
           dgvCase.Rows(i).Cells(5).Value.ToString,
                               dgvCase.Rows(i).Cells(6).Value.ToString,
                               dgvCase.Rows(i).Cells(7).Value.ToString)

            Next

            rpt.SetDataSource(dt)




            frm.CrystalReportViewer1.ReportSource = rpt
            frm.CrystalReportViewer1.Refresh()
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MakeThisCaseCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeThisCaseCompleteToolStripMenuItem.Click
        Try
            frmCaseRemarks.txtID.Text = dgvCase.SelectedRows(0).Cells(0).Value.ToString
            frmCaseRemarks.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub AddMoreHearingToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddMoreHearingToolStripMenuItem.Click
    '    Try
    '        frmAddHearingDate.ShowDialog()
    '        GetComplaintRespondent(dgvCase.SelectedRows(0).Cells(0).Value.ToString)
    '        Dim i As Integer = 0
    '        For Each row As DataRow In _dss.Tables(0).Rows
    '            With frmAddHearingDate
    '                .int_arrc(i) = row("case_complainant_idcomplainant")
    '                .int_arrr(i) = row("case_respondent_idrespondent")


    '            End With
    '            i = i + 1
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Public Sub GetComplaintRespondent(str As String)
        Try
            ConnectToServer()
            _dss.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "select DISTINCT case_complainant_idcomplainant,case_respondent_idrespondent from case_has_hearing where case_idcase = '" & str & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_dss)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        HearingToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ReOpenCaseToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ReOpenCaseToolStripMenuItem2.Click
        Try
            With Caseobj
                .Case_remarks = "Re-Open"
                .Idcase = dgvCase.SelectedRows(0).Cells(0).Value.ToString
                If .UpdateCaseToReOpen() = True Then
                    MsgBox("Case is re-open.")
                    frmCaseRecords_Load(sender, e)
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetHearingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetHearingToolStripMenuItem.Click
        Try
            GetComplaintRespondent(dgvCase.SelectedRows(0).Cells(0).Value.ToString)
            Dim i As Integer = 0
            For Each row As DataRow In _dss.Tables(0).Rows
                With frmAddHearingDate
                    .int_arrc(i) = row("case_complainant_idcomplainant")
                    .int_arrr(i) = row("case_respondent_idrespondent")
                    .arrc_l = i
                    .arrr_l = i
                End With
                i = i + 1
            Next
            frmAddHearingDate.txtID.Text = dgvCase.SelectedRows(0).Cells(0).Value.ToString
            frmAddHearingDate.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            With Caseobj
                If txtSearch.Text.Trim <> vbNullString Then
                    .SearchCaseDetails(dgvCase, txtSearch.Text)
                Else
                    .LoadCaseDetails(dgvCase)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtSearch.Text = String.Empty
            frmCaseRecords_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class