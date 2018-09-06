Imports System.Text
Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class frmHome

    Private AccountObj As New AccountClass
    Private Sub LoadResidents()
        Try
            Dim s As String = "select distinct year(person_reg_date) FROM person;"
            If ConnectToServer() = True Then
                'cboHouse.Items.Clear()
                'cboResidentChartView.Items.Clear()
                Dim cmd1 = New MySqlCommand(s, getServerConnection())
                Dim reader As MySqlDataReader = cmd1.ExecuteReader()
                While reader.Read()
                    cboResidentChartView.Items.Add(reader("year(person_reg_date)"))
                    cboHouse.Items.Add(reader("year(person_reg_date)"))
                    'cboCertificateChart.Items.Add(reader("year(person_date_registered)"))

                End While
                cboResidentChartView.Items.Add("All")
                cboHouse.Items.Add("All")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboResidentChartView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResidentChartView.SelectedIndexChanged
        Try
            Dim str As String = cboResidentChartView.Text
            If cboResidentChartView.Text = "All" Then
                str = ""
            End If

            Dim ChartPerson As String = "SELECT COUNT(idperson), YEAR(person_reg_date) FROM person WHERE YEAR(person_reg_date) LIKE '%" & str & "%' GROUP by YEAR(person_reg_date) order by idperson ASC;"
            If ConnectToServer() = True Then
                ResidentChart.Series(0).Points.Clear()

                Dim cmd1 = New MySqlCommand(ChartPerson, getServerConnection())
                Dim reader As MySqlDataReader = cmd1.ExecuteReader()
                While reader.Read()
                    ResidentChart.Series(0).Points.AddXY(reader("YEAR(person_reg_date)"), reader("COUNT(idperson)"))
                End While
            End If

            Dim ChartBusEst As String = "SELECT COUNT(idbusiness_est), YEAR(business_est_date_register) FROM business_est WHERE YEAR(business_est_date_register) LIKE '%" & str & "%' GROUP by YEAR(business_est_date_register) order by idbusiness_est ASC;"
            If ConnectToServer() = True Then
                ResidentChart.Series(1).Points.Clear()

                Dim cmd1 = New MySqlCommand(ChartBusEst, getServerConnection())
                Dim reader As MySqlDataReader = cmd1.ExecuteReader()
                While reader.Read()
                    ResidentChart.Series(1).Points.AddXY(reader("YEAR(business_est_date_register)"), reader("COUNT(idbusiness_est)"))
                End While
            End If

        Catch ex As Exception
            '   MsgBox(ex.Message)
            ' MsgBox("yes")
        End Try
    End Sub

    Private Sub cboHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHouse.SelectedIndexChanged
        Try
            Dim str As String = cboHouse.Text
            If cboHouse.Text = "All" Then
                str = ""
            End If
            Dim Monthly As String = "select COUNT(idhouse), YEAR(house_reg_date) FROM house where YEAR(house_reg_date) LIKE '%" & str & "%'  GROUP by YEAR(house_reg_date) order by idhouse ASC;"
            If ConnectToServer() = True Then
                HouseChart.Series(0).Points.Clear()

                Dim cmd1 = New MySql.Data.MySqlClient.MySqlCommand(Monthly, getServerConnection)
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd1.ExecuteReader()
                While reader.Read()
                    HouseChart.Series(0).Points.AddXY(reader("YEAR(house_reg_date)"), reader("COUNT(idhouse)"))

                End While
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            '  MsgBox("no")
        End Try
    End Sub


    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Try
            frmEmployee.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HouseModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HouseModuleToolStripMenuItem.Click
        Try
            frmHouse.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        Try
            frmAccount.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HomeTimer_Tick(sender As Object, e As EventArgs) Handles HomeTimer.Tick
        Try
            lblDate.Text = String.Format("Date: {0}", getDate())
            lblTime.Text = String.Format("Time: {0}", getTime())


        Catch ex As Exception

        End Try
    End Sub

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            HomeTimer.Start()
            LoadResidents()
            cboResidentChartView.SelectedIndex = 0
            cboHouse.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SchoolYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolYearToolStripMenuItem.Click
        Try
            frmFiscalYear.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Paint(sender As Object, e As PaintEventArgs) Handles Label2.Paint
        Dim fontObj As Font
        fontObj = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
        e.Graphics.TranslateTransform(sender.width - 30, 170)
        e.Graphics.RotateTransform(-90)
        e.Graphics.DrawString("NUMBERS OF REGISTERED", fontObj, Brushes.Black, 0, 0)
    End Sub

    Private Sub ManagePurokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePurokToolStripMenuItem.Click
        Try
            frmPurok.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShifterReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShifterReportsToolStripMenuItem.Click
        Try
            frmAccountRecord.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TransfereeReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransfereeReportsToolStripMenuItem.Click
        Try
            frmEmployeeRecords.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ManageDriveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDriveToolStripMenuItem.Click
        Try
            frmDrive.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManageStreetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStreetToolStripMenuItem.Click
        Try
            frmStreet.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManageRoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageRoadToolStripMenuItem.Click
        Try
            frmRoad.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManageReligionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReligionToolStripMenuItem.Click
        Try
            frmReligion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManageTribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTribeToolStripMenuItem.Click
        Try
            frmTribe.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManageOccupationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageOccupationToolStripMenuItem.Click
        Try
            frmOccupation.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim result As MsgBoxResult = MessageBox.Show("Are you sure want to exit?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = MsgBoxResult.Yes Then
                With AccountObj
                    .Account_isLogin = "False"
                    .Idaccount = frm_login._user_id
                    .UpdateAccountFlag()
                End With

                Dispose()
                frm_login.Show()
                frm_login.txtUsername.Clear()
                frm_login.txtPassword.Clear()
                frm_login.txtUsername.Focus()
            Else
                e.Cancel = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResidentModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BusinessEstablishmentModuleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            frmBusEst.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HouseholdModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HouseholdModuleToolStripMenuItem.Click
        Try
            frmHousehold.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResidentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidentReportToolStripMenuItem.Click
        Try
            frmResidentRecord.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub HouseModuleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HouseModuleToolStripMenuItem1.Click
        Try
            frmHouseRecord.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HouseholdModuleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HouseholdModuleToolStripMenuItem1.Click
        Try
            frmHouseholdRecords.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaseToolStripMenuItem.Click

    End Sub

    Private Sub CaseModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaseModuleToolStripMenuItem.Click
        Try
            frmCase.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HearingModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HearingModuleToolStripMenuItem.Click
        Try
            frmHearingSchedule.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProfilingModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilingModuleToolStripMenuItem.Click
        Try
            frmProfiling.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            HOME_Load(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        Try
            HOME_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class
