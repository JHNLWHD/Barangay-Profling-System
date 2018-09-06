Imports MySql.Data.MySqlClient
Public Class FiscalYearClass

    Private _idfiscal_year As Integer = 0
    Private _fiscal_year As Integer = 0
    Private _fiscal_year_status As String = ""
    Private _fiscal_year_remove_status As String = ""
    Private _fiscal_year_reg_date As Date
    Private _fiscal_year_obj As Integer = 0

    Public Property Idfiscal_year As Integer
        Get
            Return _idfiscal_year
        End Get
        Set(value As Integer)
            _idfiscal_year = value
        End Set
    End Property

    Public Property Fiscal_year As Integer
        Get
            Return _fiscal_year
        End Get
        Set(value As Integer)
            _fiscal_year = value
        End Set
    End Property

    Public Property Fiscal_year_status As String
        Get
            Return _fiscal_year_status
        End Get
        Set(value As String)
            _fiscal_year_status = value
        End Set
    End Property

    Public Property Fiscal_year_reg_date As Date
        Get
            Return _fiscal_year_reg_date
        End Get
        Set(value As Date)
            _fiscal_year_reg_date = value
        End Set
    End Property

    Public Property Fiscal_year_remove_status As String
        Get
            Return _fiscal_year_remove_status
        End Get
        Set(value As String)
            _fiscal_year_remove_status = value
        End Set
    End Property

    Public Property Fiscal_year_obj As Integer
        Get
            Return _fiscal_year_obj
        End Get
        Set(value As Integer)
            _fiscal_year_obj = value
        End Set
    End Property

    Public Function AddFiscalYear() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            ' MsgBox(frm_login._user_id)
            Dim sql As String = "INSERT INTO fiscal_year(fiscal_year,fiscal_year_status,fiscal_year_remove_status,fiscal_year_reg_date,fiscal_year_remarks) VALUES(@0,@1,@2,CURRENT_DATE,' ');"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new fiscal year: " + Fiscal_year.ToString) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new fiscal: " + Fiscal_year.ToString) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year, Fiscal_year_status, Fiscal_year_remove_status)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function AddFiscalYearNoActLogs() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO fiscal_year(fiscal_year,fiscal_year_status,fiscal_year_remove_status,fiscal_year_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new fiscal year: " + Fiscal_year) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new academic year: " + Fiscal_year) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year, Fiscal_year_status, Fiscal_year_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateFiscalYear() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE fiscal_year SET fiscal_year=@0 WHERE idfiscal_year=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a fiscal year to: " + Fiscal_year.ToString) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a fiscal year to: " + Fiscal_year.ToString) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year, Idfiscal_year)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveFiscalYear() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE fiscal_year SET fiscal_year_remove_status=@0,fiscal_year_status=@1 WHERE idfiscal_year=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a fiscal year: " + Fiscal_year.ToString) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a fiscal year: " + Fiscal_year.ToString) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year_remove_status, Fiscal_year_status, Idfiscal_year)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateFiscalYear() As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = "UPDATE fiscal_year SET fiscal_year_status= '" & MySqlHelper.EscapeString("Inactive") & "';"
            sql += "UPDATE fiscal_year SET fiscal_year_status=@0 WHERE idfiscal_year=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have activated a fiscal year: " + Fiscal_year.ToString) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have activated a fiscal year: " + Fiscal_year.ToString) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year_status, Idfiscal_year)
        Catch ex As Exception
            Rollback()
            Return False
            ' MsgBox(ex.Message)
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function CloseFiscalYear() As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = "UPDATE fiscal_year SET fiscal_year_status= '" & MySqlHelper.EscapeString("Inactive") & "';"
            'NO ACTIVITY LOGS
            ConnectToServer()
            ServerExecuteSQL(sql, Fiscal_year_status)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isFiscalYearExist(str As String, trigger As String, Optional ByVal idFiscalYear As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM fiscal_year WHERE fiscal_year = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM fiscal_year WHERE fiscal_year = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idfiscal_year != '" & MySqlHelper.EscapeString(idFiscalYear) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idfiscal_year")
            Fiscal_year_obj = ds.Tables(0).Rows(0)("fiscal_year")
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function GetActiveFiscalYear() As String
        Dim ds As New DataSet
        Try

            Dim sql As String = "SELECT * FROM fiscal_year WHERE fiscal_year_status = '" & MySqlHelper.EscapeString("Active") & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader

            While MySqlDR.Read
                Idfiscal_year = MySqlDR("idfiscal_year")
                Fiscal_year_obj = MySqlDR("fiscal_year")
            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Sub LoadFiscalYearRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "ORDER BY fiscal_year DESC;"
                Else
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "ORDER BY fiscal_year DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "AND fiscal_year_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY fiscal_year DESC;"
                Else
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "AND fiscal_year_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY fiscal_year DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idfiscal_year"), MySqlDR("fiscal_year"), MySqlDR("fiscal_year_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchFiscalYearRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "All" Then
                If limit = 0 Then
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idfiscal_year DESC;"
                Else
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idfiscal_year DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "AND fiscal_year_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idfiscal_year DESC;"
                Else
                    sql = "SELECT * FROM fiscal_year WHERE fiscal_year LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND fiscal_year_reg_date <= CURRENT_DATE " _
                        & "AND fiscal_year_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idfiscal_year DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idfiscal_year"), MySqlDR("fiscal_year"), MySqlDR("fiscal_year_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getActiveFY()
        Try
            ConnectToServer()
            Dim sql As String = ""

            sql = "SELECT * FROM academic_year WHERE academic_year.academic_year_status = '" & MySqlHelper.EscapeString("Active") & "';"

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader

            While MySqlDR.Read
                Fiscal_year = MySqlDR("fiscal_year")
            End While

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadFYToEdit(index As Integer)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM fiscal_year WHERE fiscal_year_reg_date <= CURRENT_DATE AND fiscal_year_remove_status = '" & MySqlHelper.EscapeString("False") & "' " _
                        & " AND idfiscal_year = " & MySqlHelper.EscapeString(index) & " ORDER BY idfiscal_year DESC LIMIT 1;"

            ConnectToServer()

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader

            While MySqlDR.Read
                Idfiscal_year = MySqlDR("idfiscal_year")
                Fiscal_year = MySqlDR("fiscal_year")
                Fiscal_year_status = MySqlDR("fiscal_year_status")
            End While

            MySqlDR.Close()
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
End Class
