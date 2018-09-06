Public Class frmHearingSchedule
    Private Caseobj As New CaseClass

    Private Sub btnPrintHearingSched_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmHearingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Caseobj
                .LoadHearing(dgvHearingSched, dtpHearingSchedDateFrom.Value.ToString("yyyy-MM-dd"),
                             dtpHearingSchedDateTo.Value.ToString("yyyy-MM-dd"))
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpHearingSchedDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpHearingSchedDateFrom.ValueChanged
        Try
            frmHearingSchedule_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpHearingSchedDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpHearingSchedDateTo.ValueChanged
        Try
            frmHearingSchedule_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintHearingSched_Click_1(sender As Object, e As EventArgs) Handles btnPrintHearingSched.Click
        Try
            'DataTable/DataSet
            Dim dt As New DataTable
            'Report Document
            Dim rpt As New HearingScheduleReport
            'Report Viewer
            Dim frm As New DisplayReports

            With dt.Columns

                .Add("hearingCode")
                .Add("hearingDate")
                .Add("hearingStatus")



            End With


            'Dim broEmp As New Reports

            ' dgvReportsEmployee = New DataGridView
            For i As Integer = 0 To dgvHearingSched.Rows.Count - 1
                dt.Rows.Add(dgvHearingSched.Rows(i).Cells(1).Value.ToString,
            dgvHearingSched.Rows(i).Cells(2).Value.ToString,
            dgvHearingSched.Rows(i).Cells(3).Value.ToString)

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