Imports MySql.Data.MySqlClient
Public Class AddressClass

    Private _idpurok As Integer = 0
    Private _purok_name As String = ""
    Private _purok_status As String = ""
    Private _purok_remove_status As String = ""
    Private _purok_reg_date As Date
    Private _purok_name_obj As String = ""

    Private _iddrive As Integer = 0
    Private _drive_name As String = ""
    Private _drive_status As String = ""
    Private _drive_remove_status As String = ""
    Private _drive_reg_date As Date
    Private _drive_name_obj As String = ""

    Private _idroad As Integer = 0
    Private _road_name As String = ""
    Private _road_status As String = ""
    Private _road_remove_status As String = ""
    Private _road_reg_date As Date
    Private _road_name_obj As String = ""

    Private _idstreet As Integer = 0
    Private _street_name As String = ""
    Private _street_status As String = ""
    Private _street_remove_status As String = ""
    Private _street_reg_date As Date
    Private _street_name_obj As String = ""

    Private _idsubdivision As Integer = 0
    Private _subdivision_name As String = ""
    Private _subdivision_status As String = ""
    Private _subdivision_remove_status As String = ""
    Private _subdivision_reg_date As Date
    Private _subdivision_name_obj As String = ""

    Private _idblock As Integer = 0
    Private _block_name As String = ""
    Private _block_status As String = ""
    Private _block_remove_status As String = ""
    Private _block_reg_date As Date
    Private _subdivision_id_subdivision As Integer = 0

    Private _idlot As Integer = 0
    Private _lot_name As String = ""
    Private _lot_status As String = ""
    Private _lot_remove_status As String = ""
    Private _lot_reg_date As Date
    Private _block_id_block As Integer = 0

#Region "Property"

    Public Property Idpurok As Integer
        Get
            Return _idpurok
        End Get
        Set(value As Integer)
            _idpurok = value
        End Set
    End Property

    Public Property Purok_name As String
        Get
            Return _purok_name
        End Get
        Set(value As String)
            _purok_name = value
        End Set
    End Property

    Public Property Purok_status As String
        Get
            Return _purok_status
        End Get
        Set(value As String)
            _purok_status = value
        End Set
    End Property

    Public Property Purok_remove_status As String
        Get
            Return _purok_remove_status
        End Get
        Set(value As String)
            _purok_remove_status = value
        End Set
    End Property

    Public Property Purok_reg_date As Date
        Get
            Return _purok_reg_date
        End Get
        Set(value As Date)
            _purok_reg_date = value
        End Set
    End Property

    Public Property Purok_name_obj As String
        Get
            Return _purok_name_obj
        End Get
        Set(value As String)
            _purok_name_obj = value
        End Set
    End Property

    Public Property Iddrive As Integer
        Get
            Return _iddrive
        End Get
        Set(value As Integer)
            _iddrive = value
        End Set
    End Property

    Public Property Drive_name As String
        Get
            Return _drive_name
        End Get
        Set(value As String)
            _drive_name = value
        End Set
    End Property

    Public Property Drive_status As String
        Get
            Return _drive_status
        End Get
        Set(value As String)
            _drive_status = value
        End Set
    End Property

    Public Property Drive_remove_status As String
        Get
            Return _drive_remove_status
        End Get
        Set(value As String)
            _drive_remove_status = value
        End Set
    End Property

    Public Property Drive_reg_date As Date
        Get
            Return _drive_reg_date
        End Get
        Set(value As Date)
            _drive_reg_date = value
        End Set
    End Property

    Public Property Drive_name_obj As String
        Get
            Return _drive_name_obj
        End Get
        Set(value As String)
            _drive_name_obj = value
        End Set
    End Property

    Public Property Idroad As Integer
        Get
            Return _idroad
        End Get
        Set(value As Integer)
            _idroad = value
        End Set
    End Property

    Public Property Road_name As String
        Get
            Return _road_name
        End Get
        Set(value As String)
            _road_name = value
        End Set
    End Property

    Public Property Road_status As String
        Get
            Return _road_status
        End Get
        Set(value As String)
            _road_status = value
        End Set
    End Property

    Public Property Road_remove_status As String
        Get
            Return _road_remove_status
        End Get
        Set(value As String)
            _road_remove_status = value
        End Set
    End Property

    Public Property Road_reg_date As Date
        Get
            Return _road_reg_date
        End Get
        Set(value As Date)
            _road_reg_date = value
        End Set
    End Property

    Public Property Road_name_obj As String
        Get
            Return _road_name_obj
        End Get
        Set(value As String)
            _road_name_obj = value
        End Set
    End Property

    Public Property Idstreet As Integer
        Get
            Return _idstreet
        End Get
        Set(value As Integer)
            _idstreet = value
        End Set
    End Property

    Public Property Street_name As String
        Get
            Return _street_name
        End Get
        Set(value As String)
            _street_name = value
        End Set
    End Property

    Public Property Street_status As String
        Get
            Return _street_status
        End Get
        Set(value As String)
            _street_status = value
        End Set
    End Property

    Public Property Street_remove_status As String
        Get
            Return _street_remove_status
        End Get
        Set(value As String)
            _street_remove_status = value
        End Set
    End Property

    Public Property Street_reg_date As Date
        Get
            Return _street_reg_date
        End Get
        Set(value As Date)
            _street_reg_date = value
        End Set
    End Property

    Public Property Street_name_obj As String
        Get
            Return _street_name_obj
        End Get
        Set(value As String)
            _street_name_obj = value
        End Set
    End Property

    Public Property Idsubdivision As Integer
        Get
            Return _idsubdivision
        End Get
        Set(value As Integer)
            _idsubdivision = value
        End Set
    End Property

    Public Property Subdivision_name As String
        Get
            Return _subdivision_name
        End Get
        Set(value As String)
            _subdivision_name = value
        End Set
    End Property

    Public Property Subdivision_status As String
        Get
            Return _subdivision_status
        End Get
        Set(value As String)
            _subdivision_status = value
        End Set
    End Property

    Public Property Subdivision_remove_status As String
        Get
            Return _subdivision_remove_status
        End Get
        Set(value As String)
            _subdivision_remove_status = value
        End Set
    End Property

    Public Property Subdivision_reg_date As Date
        Get
            Return _subdivision_reg_date
        End Get
        Set(value As Date)
            _subdivision_reg_date = value
        End Set
    End Property

    Public Property Idblock As Integer
        Get
            Return _idblock
        End Get
        Set(value As Integer)
            _idblock = value
        End Set
    End Property

    Public Property Block_name As String
        Get
            Return _block_name
        End Get
        Set(value As String)
            _block_name = value
        End Set
    End Property

    Public Property Block_status As String
        Get
            Return _block_status
        End Get
        Set(value As String)
            _block_status = value
        End Set
    End Property

    Public Property Block_remove_status As String
        Get
            Return _block_remove_status
        End Get
        Set(value As String)
            _block_remove_status = value
        End Set
    End Property

    Public Property Block_reg_date As Date
        Get
            Return _block_reg_date
        End Get
        Set(value As Date)
            _block_reg_date = value
        End Set
    End Property

    Public Property Subdivision_id_subdivision As Integer
        Get
            Return _subdivision_id_subdivision
        End Get
        Set(value As Integer)
            _subdivision_id_subdivision = value
        End Set
    End Property

    Public Property Idlot As Integer
        Get
            Return _idlot
        End Get
        Set(value As Integer)
            _idlot = value
        End Set
    End Property

    Public Property Lot_name As String
        Get
            Return _lot_name
        End Get
        Set(value As String)
            _lot_name = value
        End Set
    End Property

    Public Property Lot_status As String
        Get
            Return _lot_status
        End Get
        Set(value As String)
            _lot_status = value
        End Set
    End Property

    Public Property Lot_remove_status As String
        Get
            Return _lot_remove_status
        End Get
        Set(value As String)
            _lot_remove_status = value
        End Set
    End Property

    Public Property Lot_reg_date As Date
        Get
            Return _lot_reg_date
        End Get
        Set(value As Date)
            _lot_reg_date = value
        End Set
    End Property

    Public Property Block_id_block As Integer
        Get
            Return _block_id_block
        End Get
        Set(value As Integer)
            _block_id_block = value
        End Set
    End Property

    Public Property Subdivision_name_obj As String
        Get
            Return _subdivision_name_obj
        End Get
        Set(value As String)
            _subdivision_name_obj = value
        End Set
    End Property
#End Region

    Public Function AddPurok() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO purok(purok_name,purok_status,purok_remove_status,purok_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new purok: " + Purok_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new purok: " + Purok_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Purok_name, Purok_status, Purok_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdatePurok() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE purok SET purok_name=@0,purok_status=@1 WHERE idpurok=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a purok to: " + Purok_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a purok to: " + Purok_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Purok_name, Purok_status, Idpurok)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemovePurok() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE purok SET purok_remove_status=@0,purok_status=@1 WHERE idpurok=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a purok: " + Purok_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a purok: " + Purok_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Purok_remove_status, Purok_status, Idpurok)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivatePurok(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE purok SET purok_status=@0 WHERE idpurok=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a purok: " + Purok_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a purok: " + Purok_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Purok_status, Idpurok)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isPurokExist(str As String, trigger As String, Optional ByVal idPurok As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM purok WHERE purok_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM purok WHERE purok_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idpurok != '" & MySqlHelper.EscapeString(idPurok) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idpurok")
            Purok_name_obj = ds.Tables(0).Rows(0)("purok_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function



    Public Function AddDrive() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO drive(drive_name,drive_status,drive_remove_status,drive_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new drive: " + Drive_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new drive: " + Drive_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Drive_name, Drive_status, Drive_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateDrive() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE drive SET drive_name=@0,drive_status=@1 WHERE iddrive=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a drive to: " + Drive_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a drive to: " + Drive_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Drive_name, Drive_status, Iddrive)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveDrive() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE drive SET drive_remove_status=@0 WHERE iddrive=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a drive: " + Drive_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a drive: " + Drive_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Drive_remove_status, Iddrive)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateDrive(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE drive SET drive_status=@0 WHERE iddrive=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a drive: " + Drive_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a drive: " + Drive_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Drive_status, Iddrive)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isDriveExist(str As String, trigger As String, Optional ByVal idDrive As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM drive WHERE drive_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM drive WHERE drive_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND iddrive != '" & MySqlHelper.EscapeString(idDrive) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("iddrive")
            Drive_name_obj = ds.Tables(0).Rows(0)("drive_name")
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddRoad() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO road(road_name,road_status,road_remove_status,road_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new road: " + Road_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new road: " + Road_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Road_name, Road_status, Road_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateRoad() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE road SET road_name=@0 WHERE idroad=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a road to: " + Road_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a road to: " + Road_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Road_name, Idroad)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveRoad() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE road SET road_remove_status=@0 WHERE idroad=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a road: " + Road_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a road: " + Road_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Road_remove_status, Idroad)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateRoad(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE road SET road_status=@0 WHERE idroad=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a road: " + Road_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a road: " + Road_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Road_status, Idroad)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isRoadExist(str As String, trigger As String, Optional ByVal idRoad As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM road WHERE road_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM road WHERE road_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idroad != '" & MySqlHelper.EscapeString(idRoad) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idroad")
            Road_name_obj = ds.Tables(0).Rows(0)("road_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddStreet() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO street(street_name,street_status,street_remove_status,street_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new street: " + Street_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new street: " + Street_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Street_name, Street_status, Street_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateStreet() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE street SET street_name=@0 WHERE idstreet=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a street to: " + Street_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a street to: " + Street_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Street_name, Idstreet)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveStreet() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE street SET street_remove_status=@0 WHERE idstreet=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a street: " + Street_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a street: " + Street_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Street_remove_status, Idstreet)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateStreet(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE street SET street_status=@0 WHERE idstreet=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a street: " + Street_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a street: " + Street_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Street_status, Idstreet)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isStreetExist(str As String, trigger As String, Optional ByVal idStreet As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM street WHERE street_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM street WHERE street_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idstreet != '" & MySqlHelper.EscapeString(idStreet) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idstreet")
            Street_name_obj = ds.Tables(0).Rows(0)("street_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Sub LoadPurokRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM purok WHERE purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idpurok DESC;"
                Else
                    sql = "SELECT * FROM purok WHERE purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idpurok DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM purok WHERE purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "AND purok_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idpurok DESC;"
                Else
                    sql = "SELECT * FROM purok WHERE purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "AND purok_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idpurok DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idpurok"), MySqlDR("purok_name"), MySqlDR("purok_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchPurokRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM purok WHERE purok_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idpurok DESC;"
                Else
                    sql = "SELECT * FROM purok WHERE purok_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idpurok DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM purok WHERE purok_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "AND purok_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idpurok DESC;"
                Else
                    sql = "SELECT * FROM purok WHERE purok_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND purok_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND purok_reg_date <= CURRENT_DATE " _
                        & "AND purok_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idpurok DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idpurok"), MySqlDR("purok_name"), MySqlDR("purok_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadRoadRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM road WHERE road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idroad DESC;"
                Else
                    sql = "SELECT * FROM road WHERE road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idroad DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM road WHERE road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "AND road_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idroad DESC;"
                Else
                    sql = "SELECT * FROM road WHERE road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "AND road_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idroad DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idroad"), MySqlDR("road_name"), MySqlDR("road_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchRoadRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM road WHERE road_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idroad DESC;"
                Else
                    sql = "SELECT * FROM road WHERE road_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idroad DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM road WHERE road_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "AND road_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idroad DESC;"
                Else
                    sql = "SELECT * FROM road WHERE road_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND road_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND road_reg_date <= CURRENT_DATE " _
                        & "AND road_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idroad DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idroad"), MySqlDR("road_name"), MySqlDR("road_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadDriveRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM drive WHERE drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "ORDER BY iddrive DESC;"
                Else
                    sql = "SELECT * FROM drive WHERE drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "ORDER BY iddrive DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM drive WHERE drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "AND drive_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY iddrive DESC;"
                Else
                    sql = "SELECT * FROM drive WHERE drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "AND drive_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY iddrive DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("iddrive"), MySqlDR("drive_name"), MySqlDR("drive_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchDriveRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM drive WHERE drive_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "ORDER BY iddrive DESC;"
                Else
                    sql = "SELECT * FROM drive WHERE drive_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "ORDER BY iddrive DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM drive WHERE drive_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "AND drive_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY iddrive DESC;"
                Else
                    sql = "SELECT * FROM drive WHERE drive_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND drive_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND drive_reg_date <= CURRENT_DATE " _
                        & "AND drive_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY iddrive DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("iddrive"), MySqlDR("drive_name"), MySqlDR("drive_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LoadStreetRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM street WHERE street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idstreet DESC;"
                Else
                    sql = "SELECT * FROM street WHERE street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idstreet DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM street WHERE street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "AND street_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idstreet DESC;"
                Else
                    sql = "SELECT * FROM street WHERE street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "AND street_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idstreet DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idstreet"), MySqlDR("street_name"), MySqlDR("street_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchStreetRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "All" Then
                If limit = 0 Then
                    sql = "SELECT * FROM street WHERE street_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idstreet DESC;"
                Else
                    sql = "SELECT * FROM street WHERE street_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idstreet DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM street WHERE street_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "AND street_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idstreet DESC;"
                Else
                    sql = "SELECT * FROM street WHERE street_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND street_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND street_reg_date <= CURRENT_DATE " _
                        & "AND street_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idstreet DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idstreet"), MySqlDR("street_name"), MySqlDR("street_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AddSubdivision() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO subdivision(subdivision_name,subdivision_status,subdivision_remove_status,subdivision_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new subdivision: " + Subdivision_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new subdivision: " + Subdivision_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Subdivision_name, Subdivision_status, Subdivision_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isSubdivisionExist(str As String, trigger As String, Optional ByVal idStreet As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM subdivision WHERE subdivision_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM subdivision WHERE subdivision_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idsubdivision != '" & MySqlHelper.EscapeString(idStreet) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idsubdivision")
            Subdivision_name_obj = ds.Tables(0).Rows(0)("subdivision_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddBlock() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO block(block_name,block_status,block_remove_status,block_reg_date,subdivision_idsubdivision) VALUES(@0,@1,@2,CURRENT_DATE,(SELECT MAX(idsubdivision) FROM subdivision));"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new block: " + Block_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new block: " + Block_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Block_name, Block_status, Block_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function AddLot() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO lot(lot_name,lot_status,lot_remove_status,lot_reg_date,block_idblock) VALUES(@0,@1,@2,CURRENT_DATE,(SELECT MAX(idblock) FROM block));"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new lot: " + Lot_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new lot: " + Lot_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Lot_name, Lot_status, Lot_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function


    Public Sub LoadSubdivisionRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM subdivision WHERE subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idsubdivision DESC;"
                Else
                    sql = "SELECT * FROM subdivision WHERE subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idsubdivision DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM subdivision WHERE subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "AND subdivision_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idsubdivision DESC;"
                Else
                    sql = "SELECT * FROM subdivision WHERE subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "AND subdivision_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idsubdivision DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idsubdivision"), MySqlDR("subdivision_name"), MySqlDR("subdivision_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchSubdivisionRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM subdivision WHERE subdivision LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idsubdivision DESC;"
                Else
                    sql = "SELECT * FROM subdivision WHERE subdivision LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idsubdivision DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM subdivision WHERE subdivision LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "AND subdivision_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idsubdivision DESC;"
                Else
                    sql = "SELECT * FROM subdivision WHERE subdivision LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND subdivision_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND subdivision_reg_date <= CURRENT_DATE " _
                        & "AND subdivision_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idsubdivision DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idsubdivision"), MySqlDR("subdivision_name"), MySqlDR("subdivision_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LoadPurok(cbo As ComboBox)

        ConnectToServer()
        Dim query As String = "SELECT * FROM purok WHERE purok_status =  '" & MySqlHelper.EscapeString("Active") & "'"
        Dim command = New MySqlCommand(query, getServerConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader

        cbo.Items.Clear()

        While reader.Read()
            Dim lname = reader.GetString("purok_name")

            cbo.Items.Add(lname)
        End While

    End Sub

    Public Sub LoadDrive(cbo As ComboBox)

        ConnectToServer()
        Dim query As String = "SELECT * FROM drive WHERE drive_status =  '" & MySqlHelper.EscapeString("Active") & "'"
        Dim command = New MySqlCommand(query, getServerConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader

        cbo.Items.Clear()

        While reader.Read()
            Dim lname = reader.GetString("drive_name")

            cbo.Items.Add(lname)
        End While

    End Sub

    Public Sub LoadRoad(cbo As ComboBox)

        ConnectToServer()
        Dim query As String = "SELECT * FROM road WHERE road_status =  '" & MySqlHelper.EscapeString("Active") & "'"
        Dim command = New MySqlCommand(query, getServerConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader

        cbo.Items.Clear()

        While reader.Read()
            Dim lname = reader.GetString("road_name")

            cbo.Items.Add(lname)
        End While

    End Sub

    Public Sub LoadStreet(cbo As ComboBox)

        ConnectToServer()
        Dim query As String = "SELECT * FROM street WHERE street_status =  '" & MySqlHelper.EscapeString("Active") & "'"
        Dim command = New MySqlCommand(query, getServerConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader

        cbo.Items.Clear()

        While reader.Read()
            Dim lname = reader.GetString("street_name")

            cbo.Items.Add(lname)
        End While

    End Sub



End Class
