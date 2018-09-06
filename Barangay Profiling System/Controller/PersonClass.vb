Imports MySql.Data.MySqlClient
Public Class PersonClass

    Private _idtribe As Integer = 0
    Private _tribe_name As String = ""
    Private _tribe_status As String = ""
    Private _tribe_remove_status As String = ""
    Private _tribe_reg_date As Date
    Private _tribe_name_obj As String = ""

    Private _idreligion As Integer = 0
    Private _religion_name As String = ""
    Private _religion_status As String = ""
    Private _religion_remove_status As String = ""
    Private _religion_reg_date As Date
    Private _religion_name_obj As String = ""

    Private _idoccupation As Integer = 0
    Private _occupation_name As String = ""
    Private _occupation_status As String = ""
    Private _occupation_remove_status As String = ""
    Private _occupation_reg_date As Date
    Private _occupation_name_obj As String = ""

    Private _idperson As Integer = 0
    Private _person_code As String = ""
    Private _person_last_name As String = ""
    Private _person_first_name As String = ""
    Private _person_middle_name As String = ""
    Private _person_extension_name As String = ""
    Private _person_gender As String = ""
    Private _person_tel_no As String = ""
    Private _person_mobile_no As String = ""
    Private _person_civil_status As String = ""
    Private _person_date_of_birth As Date
    Private _person_status As String = ""
    Private _person_reg_date As Date
    Private _person_reg_date_resident As Date
    Private _person_voter_status As String = ""
    Private _person_precinct_number As String = ""
    Private _person_place_of_birth As String = ""
    Private _person_height As String = ""
    Private _person_weight As String = ""
    Private _person_complexion As String = ""
    Private _person_hair_color As String = ""
    Private _person_eye_color As String = ""
    Private _person_image As Byte()
    Private _person_vital_status As String = ""

    Private _idperson_history As Integer = 0
    Private _person_history_desc As String = ""
    Private _person_history_reg_date As Date
    Private _person_idperson As Integer = 0

    Private _household_idhousehold1 As Integer = 0
    Private _household_member_role1 As String = ""

    Private _idrelative As Integer = 0
    Private _relative_role As String = ""
    Private _relative_idperson As Integer = 0
    Private _relative_dom As Date


    Public Property Idtribe As Integer
        Get
            Return _idtribe
        End Get
        Set(value As Integer)
            _idtribe = value
        End Set
    End Property

    Public Property Tribe_name As String
        Get
            Return _tribe_name
        End Get
        Set(value As String)
            _tribe_name = value
        End Set
    End Property

    Public Property Tribe_status As String
        Get
            Return _tribe_status
        End Get
        Set(value As String)
            _tribe_status = value
        End Set
    End Property

    Public Property Tribe_remove_status As String
        Get
            Return _tribe_remove_status
        End Get
        Set(value As String)
            _tribe_remove_status = value
        End Set
    End Property

    Public Property Trbe_reg_date As Date
        Get
            Return _tribe_reg_date
        End Get
        Set(value As Date)
            _tribe_reg_date = value
        End Set
    End Property

    Public Property Tribe_name_obj As String
        Get
            Return _tribe_name_obj
        End Get
        Set(value As String)
            _tribe_name_obj = value
        End Set
    End Property

    Public Property Idreligion As Integer
        Get
            Return _idreligion
        End Get
        Set(value As Integer)
            _idreligion = value
        End Set
    End Property

    Public Property Religion_name As String
        Get
            Return _religion_name
        End Get
        Set(value As String)
            _religion_name = value
        End Set
    End Property

    Public Property Religion_status As String
        Get
            Return _religion_status
        End Get
        Set(value As String)
            _religion_status = value
        End Set
    End Property

    Public Property Religion_remove_status As String
        Get
            Return _religion_remove_status
        End Get
        Set(value As String)
            _religion_remove_status = value
        End Set
    End Property

    Public Property Religion_reg_date As Date
        Get
            Return _religion_reg_date
        End Get
        Set(value As Date)
            _religion_reg_date = value
        End Set
    End Property

    Public Property Religion_name_obj As String
        Get
            Return _religion_name_obj
        End Get
        Set(value As String)
            _religion_name_obj = value
        End Set
    End Property

    Public Property Idoccupation As Integer
        Get
            Return _idoccupation
        End Get
        Set(value As Integer)
            _idoccupation = value
        End Set
    End Property

    Public Property Occupation_name As String
        Get
            Return _occupation_name
        End Get
        Set(value As String)
            _occupation_name = value
        End Set
    End Property

    Public Property Occupation_status As String
        Get
            Return _occupation_status
        End Get
        Set(value As String)
            _occupation_status = value
        End Set
    End Property

    Public Property Occupation_remove_status As String
        Get
            Return _occupation_remove_status
        End Get
        Set(value As String)
            _occupation_remove_status = value
        End Set
    End Property

    Public Property Occupation_reg_date As Date
        Get
            Return _occupation_reg_date
        End Get
        Set(value As Date)
            _occupation_reg_date = value
        End Set
    End Property

    Public Property Occupation_name_obj As String
        Get
            Return _occupation_name_obj
        End Get
        Set(value As String)
            _occupation_name_obj = value
        End Set
    End Property

    Public Property Idperson As Integer
        Get
            Return _idperson
        End Get
        Set(value As Integer)
            _idperson = value
        End Set
    End Property

    Public Property Person_last_name As String
        Get
            Return _person_last_name
        End Get
        Set(value As String)
            _person_last_name = value
        End Set
    End Property

    Public Property Person_first_name As String
        Get
            Return _person_first_name
        End Get
        Set(value As String)
            _person_first_name = value
        End Set
    End Property

    Public Property Person_middle_name As String
        Get
            Return _person_middle_name
        End Get
        Set(value As String)
            _person_middle_name = value
        End Set
    End Property

    Public Property Person_extension_name As String
        Get
            Return _person_extension_name
        End Get
        Set(value As String)
            _person_extension_name = value
        End Set
    End Property

    Public Property Person_gender As String
        Get
            Return _person_gender
        End Get
        Set(value As String)
            _person_gender = value
        End Set
    End Property

    Public Property Person_tel_no As String
        Get
            Return _person_tel_no
        End Get
        Set(value As String)
            _person_tel_no = value
        End Set
    End Property

    Public Property Person_mobile_no As String
        Get
            Return _person_mobile_no
        End Get
        Set(value As String)
            _person_mobile_no = value
        End Set
    End Property

    Public Property Person_civil_status As String
        Get
            Return _person_civil_status
        End Get
        Set(value As String)
            _person_civil_status = value
        End Set
    End Property

    Public Property Person_date_of_birth As Date
        Get
            Return _person_date_of_birth
        End Get
        Set(value As Date)
            _person_date_of_birth = value
        End Set
    End Property

    Public Property Person_status As String
        Get
            Return _person_status
        End Get
        Set(value As String)
            _person_status = value
        End Set
    End Property

    Public Property Person_reg_date As Date
        Get
            Return _person_reg_date
        End Get
        Set(value As Date)
            _person_reg_date = value
        End Set
    End Property

    Public Property Person_reg_date_resident As Date
        Get
            Return _person_reg_date_resident
        End Get
        Set(value As Date)
            _person_reg_date_resident = value
        End Set
    End Property

    Public Property Idperson_history As Integer
        Get
            Return _idperson_history
        End Get
        Set(value As Integer)
            _idperson_history = value
        End Set
    End Property

    Public Property Person_history_desc As String
        Get
            Return _person_history_desc
        End Get
        Set(value As String)
            _person_history_desc = value
        End Set
    End Property

    Public Property Person_history_reg_date As Date
        Get
            Return _person_history_reg_date
        End Get
        Set(value As Date)
            _person_history_reg_date = value
        End Set
    End Property

    Public Property Person_idperson As Integer
        Get
            Return _person_idperson
        End Get
        Set(value As Integer)
            _person_idperson = value
        End Set
    End Property

    Public Property Person_voter_status As String
        Get
            Return _person_voter_status
        End Get
        Set(value As String)
            _person_voter_status = value
        End Set
    End Property

    Public Property Person_precinct_number As String
        Get
            Return _person_precinct_number
        End Get
        Set(value As String)
            _person_precinct_number = value
        End Set
    End Property

    Public Property Person_place_of_birth As String
        Get
            Return _person_place_of_birth
        End Get
        Set(value As String)
            _person_place_of_birth = value
        End Set
    End Property

    Public Property Person_height As String
        Get
            Return _person_height
        End Get
        Set(value As String)
            _person_height = value
        End Set
    End Property

    Public Property Person_weight As String
        Get
            Return _person_weight
        End Get
        Set(value As String)
            _person_weight = value
        End Set
    End Property

    Public Property Person_complexion As String
        Get
            Return _person_complexion
        End Get
        Set(value As String)
            _person_complexion = value
        End Set
    End Property

    Public Property Person_hair_color As String
        Get
            Return _person_hair_color
        End Get
        Set(value As String)
            _person_hair_color = value
        End Set
    End Property

    Public Property Person_eye_color As String
        Get
            Return _person_eye_color
        End Get
        Set(value As String)
            _person_eye_color = value
        End Set
    End Property

    Public Property Person_image As Byte()
        Get
            Return _person_image
        End Get
        Set(value As Byte())
            _person_image = value
        End Set
    End Property

    Public Property Person_vital_status As String
        Get
            Return _person_vital_status
        End Get
        Set(value As String)
            _person_vital_status = value
        End Set
    End Property

    Public Property Household_member_role1 As String
        Get
            Return _household_member_role1
        End Get
        Set(value As String)
            _household_member_role1 = value
        End Set
    End Property

    Public Property Household_idhousehold1 As Integer
        Get
            Return _household_idhousehold1
        End Get
        Set(value As Integer)
            _household_idhousehold1 = value
        End Set
    End Property

    Public Property Person_code As String
        Get
            Return _person_code
        End Get
        Set(value As String)
            _person_code = value
        End Set
    End Property

    Public Property Idrelative As Integer
        Get
            Return _idrelative
        End Get
        Set(value As Integer)
            _idrelative = value
        End Set
    End Property

    Public Property Relative_role As String
        Get
            Return _relative_role
        End Get
        Set(value As String)
            _relative_role = value
        End Set
    End Property

    Public Property Relative_idperson As Integer
        Get
            Return _relative_idperson
        End Get
        Set(value As Integer)
            _relative_idperson = value
        End Set
    End Property

    Public Property Relative_dom As Date
        Get
            Return _relative_dom
        End Get
        Set(value As Date)
            _relative_dom = value
        End Set
    End Property

    Public Sub GetPersonDetails(id As Integer)
        Try

            Dim sql As String = ""
            sql = "Select * FROM person WHERE idperson = '" & MySqlHelper.EscapeString(id) & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

                Idperson = MySqlDR("idperson")
                Person_first_name = MySqlDR("person_first_name")
                Person_middle_name = MySqlDR("person_middle_name")
                Person_last_name = MySqlDR("person_last_name")
                Person_extension_name = MySqlDR("person_extension_name")
                Person_gender = MySqlDR("person_gender")
                Person_tel_no = MySqlDR("person_tel_no")
                Person_mobile_no = MySqlDR("person_mobile_no")
                Person_civil_status = MySqlDR("person_civil_status")
                Person_date_of_birth = MySqlDR("person_date_of_birth")
                Person_status = MySqlDR("person_status")
                Person_vital_status = MySqlDR("person_vital_status")
            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AddTribe() As Boolean
        Try
            Dim sql As String = "INSERT INTO tribe(tribe_name,tribe_status,tribe_remove_status,tribe_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Tribe_name, Tribe_status, Tribe_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateTribe() As Boolean
        Try
            Dim sql As String = "UPDATE tribe SET tribe_name=@0,tribe_status=@1 WHERE idtribe=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a tribe to: " + Tribe_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a tribe to: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Tribe_name, Tribe_status, Idtribe)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveTribe() As Boolean
        Try
            Dim sql As String = "UPDATE tribe SET tribe_remove_status=@0 WHERE idtribe=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a tribe: " + Tribe_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Tribe_remove_status, Idtribe)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateTribe(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE tribe SET tribe_status=@0 WHERE idtribe=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a tribe: " + Tribe_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Tribe_status, Idtribe)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isTribeExist(str As String, trigger As String, Optional ByVal idTribe As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM tribe WHERE tribe_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM tribe WHERE tribe_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idtribe != '" & MySqlHelper.EscapeString(idTribe) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idtribe")
            Tribe_name_obj = ds.Tables(0).Rows(0)("tribe_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddReligion() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO religion(religion_name,religion_status,religion_remove_status,religion_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new religion: " + Religion_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new religion: " + Religion_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Religion_name, Religion_status, Religion_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateReligion() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE religion SET religion_name=@0,religion_status=@1 WHERE idreligion=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a religion to: " + Religion_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a religion to: " + Religion_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Religion_name, Religion_status, Idreligion)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveReligion() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE religion SET religion_remove_status=@0 WHERE idreligion=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a religion: " + Religion_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a religion: " + Religion_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Religion_remove_status, Idreligion)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateReligion(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE religion SET religion_status=@0 WHERE idreligion=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a religion: " + Religion_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a religion: " + Religion_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Religion_status, Idreligion)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isReligionExist(str As String, trigger As String, Optional ByVal idReligion As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM religion WHERE religion_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM religion WHERE religion_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idreligion != '" & MySqlHelper.EscapeString(idReligion) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idreligion")
            Religion_name_obj = ds.Tables(0).Rows(0)("religion_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddOccupation() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "INSERT INTO occupation(occupation_name,occupation_status,occupation_remove_status,occupation_reg_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new occupation: " + Occupation_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new occupation: " + Occupation_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Occupation_name, Occupation_status, Occupation_remove_status)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateOccupation() As Boolean
        Try
            'Validate first if AY is existing
            'Validate if it is Currently Active
            Dim sql As String = "UPDATE occupation SET occupation_name=@0,occupation_status=@1 WHERE idoccupation=@2;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have updated a occupation to: " + Occupation_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have updated a occupation to: " + Occupation_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Occupation_name, Occupation_status, Idoccupation)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function RemoveOccupation() As Boolean
        Try
            'Validate if it is Currently Active
            'If true then don't proceed
            Dim sql As String = "UPDATE occupation SET occupation_remove_status=@0 WHERE idoccupation=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have removed a occupation: " + Occupation_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have removed a occupation: " + Occupation_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Occupation_remove_status, Idoccupation)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function ActivateDeactivateOccupation(str As String) As Boolean
        Try
            'set all to close before activating or vice-versa
            Dim sql As String = ""
            sql += "UPDATE occupation SET occupation_status=@0 WHERE idoccupation=@1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have '" & str & " a occupation: " + Occupation_name) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have '" & str & "' a occupation: " + Occupation_name) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Occupation_status, Idoccupation)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function isOccupationExist(str As String, trigger As String, Optional ByVal idOccupation As Integer = 0) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            If trigger = "New" Then
                sql = "SELECT * FROM occupation WHERE occupation_name = '" & MySqlHelper.EscapeString(str) & "';"
            ElseIf trigger = "Edit" Then
                sql = "SELECT * FROM occupation WHERE occupation_name = '" & MySqlHelper.EscapeString(str) & "' " _
                   & "AND idoccupation != '" & MySqlHelper.EscapeString(idOccupation) & "';"
            End If

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idoccupation")
            Occupation_name_obj = ds.Tables(0).Rows(0)("occupation_name")
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Sub LoadTribeRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM tribe WHERE tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idtribe DESC;"
                Else
                    sql = "SELECT * FROM tribe WHERE tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idtribe DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM tribe WHERE tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "AND tribe_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idtribe DESC;"
                Else
                    sql = "SELECT * FROM tribe WHERE tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "AND tribe_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idtribe DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idtribe"), MySqlDR("tribe_name"), MySqlDR("tribe_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchTribeRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM tribe WHERE tribe_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idtribe DESC;"
                Else
                    sql = "SELECT * FROM tribe WHERE tribe_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idtribe DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM tribe WHERE tribe_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "AND tribe_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idtribe DESC;"
                Else
                    sql = "SELECT * FROM tribe WHERE tribe_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND tribe_reg_date <= CURRENT_DATE " _
                        & "AND tribe_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idtribe DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idtribe"), MySqlDR("tribe_name"), MySqlDR("tribe_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadReligionRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM religion WHERE religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idreligion DESC;"
                Else
                    sql = "SELECT * FROM religion WHERE religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idreligion DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM religion WHERE religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "AND religion_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idreligion DESC;"
                Else
                    sql = "SELECT * FROM religion WHERE religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "AND religion_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idreligion DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idreligion"), MySqlDR("religion_name"), MySqlDR("religion_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchReligionRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM religion WHERE religion_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idreligion DESC;"
                Else
                    sql = "SELECT * FROM religion WHERE religion_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idreligion DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM religion WHERE religion_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "AND religion_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idreligion DESC;"
                Else
                    sql = "SELECT * FROM religion WHERE religion_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND religion_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND religion_reg_date <= CURRENT_DATE " _
                        & "AND religion_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idreligion DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idreligion"), MySqlDR("religion_name"), MySqlDR("religion_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadOccupationRecords(dgv As DataGridView, filter As String, limit As Integer, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM occupation WHERE occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idoccupation DESC;"
                Else
                    sql = "SELECT * FROM occupation WHERE occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idoccupation DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM occupation WHERE occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "AND occupation_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idoccupation DESC;"
                Else
                    sql = "SELECT * FROM occupation WHERE occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "AND occupation_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idoccupation DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idoccupation"), MySqlDR("occupation_name"), MySqlDR("occupation_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchOccupationRecords(dgv As DataGridView, filter As String, limit As Integer, search As String, Optional stat As String = "")
        Try

            Dim sql As String = ""

            If filter = "ALL" Then
                If limit = 0 Then
                    sql = "SELECT * FROM occupation WHERE occupation_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idoccupation DESC;"
                Else
                    sql = "SELECT * FROM occupation WHERE occupation_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "ORDER BY idoccupation DESC LIMIT 5;"
                End If
            Else
                If limit = 0 Then
                    sql = "SELECT * FROM occupation WHERE occupation_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "AND occupation_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idoccupation DESC;"
                Else
                    sql = "SELECT * FROM occupation WHERE occupation_name LIKE '%" & MySqlHelper.EscapeString(search) & "%' " _
                        & "AND occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "' AND occupation_reg_date <= CURRENT_DATE " _
                        & "AND occupation_status = '" & MySqlHelper.EscapeString(stat) & "' ORDER BY idoccupation DESC LIMIT 5;"
                End If
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idoccupation"), MySqlDR("occupation_name"), MySqlDR("occupation_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadPerson(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM person WHERE person_reg_date <= CURRENT_DATE;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"), MySqlDR("person_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadPersonResident(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM person WHERE person_reg_date <= CURRENT_DATE AND person_status = 'Resident';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"), MySqlDR("person_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchPerson(dgv As DataGridView, txt As String)
        Try
            Dim sql As String = ""

            sql = "SELECT * FROM person WHERE person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "Or person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
              & "(CONCAT(person_first_name,' ',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_first_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_last_name,' ',person_first_name,' ',person_middle_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "');"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"), MySqlDR("person_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchPersonResident(dgv As DataGridView, txt As String)
        Try
            Dim sql As String = ""

            sql = "SELECT * FROM person WHERE person_status = 'Active' AND (person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
              & "(CONCAT(person_first_name,' ',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_first_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_last_name,' ',person_first_name,' ',person_middle_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "'));"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"), MySqlDR("person_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function AddResident(str As String) As Boolean
        Try
            Dim sql As String = ""
            sql = "INSERT INTO person(person_last_name,person_first_name,person_middle_name,person_extension_name," _
                & "person_gender,person_mobile_no,person_tel_no,person_civil_status,person_date_of_birth," _
                & "person_status,person_reg_date_resident,person_reg_date,person_voter_status,person_precinct_number," _
                & "person_place_of_birth,person_height,person_weight,person_hair_color,person_eye_color," _
                & "person_vital_status,person_code) VALUES(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,CURRENT_DATE,CURRENT_DATE,@10,@11,@12," _
                & "@13,@14,@15,@16,@17,@18);"
            sql += "INSERT INTO household_member(household_idhousehold,person_idperson,household_member_role," _
                & "household_member_reg_date,household_member_is_head,household_member_head_status) " _
                & "VALUES(@19,(SELECT MAX(idperson) FROM person),@20,CURRENT_DATE,'" & "False" & "','" & " " & "');"
            sql += str
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new resident: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new resident: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Person_last_name, Person_first_name, Person_middle_name, Person_extension_name, Person_gender,
                             Person_mobile_no, Person_tel_no, Person_civil_status, Person_date_of_birth, Person_status,
                             Person_voter_status, Person_precinct_number, Person_place_of_birth, Person_height, Person_weight,
                             Person_hair_color, Person_eye_color, Person_vital_status, Person_code, Household_idhousehold1,
                             Household_member_role1)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function AddSpouse() As Boolean
        Try
            Dim sql As String = ""
            sql = "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage,person_idperson) " _
                & "VALUES(@0,@1,@2,@3);"
            sql += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage,person_idperson) " _
                & "VALUES(@4,@5,@6,@7);"
            sql += "UPDATE person SET person_civil_status = @8 WHERE idperson = @9;"
            sql += "UPDATE person SET person_civil_status = @10 WHERE idperson = @11;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new spouse: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new spouse: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Relative_role, Relative_idperson, Relative_dom, Person_idperson,
                                Relative_role, Person_idperson, Relative_dom, Relative_idperson,
                             Person_civil_status, Relative_idperson, Person_civil_status, Person_idperson)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function AddSpouse(str As String) As Boolean
        Try
            Dim sql As String = ""
            sql += str
            sql += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage,person_idperson) " _
                & "VALUES(@0,(SELECT MAX(idperson) FROM person),@1,@2);"
            sql += "INSERT INTO relative(relative_role,relative_idperson,relative_date_of_marriage,person_idperson) " _
                & "VALUES(@3,@4,@5,(SELECT MAX(idperson) FROM person));"
            sql += "UPDATE person SET person_civil_status = @6 WHERE idperson = @7;"
            sql += "UPDATE person SET person_civil_status = @8 ORDER BY idperson DESC LIMIT 1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new spouse: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new spouse: " + String.Format("{0} {1} {2} {3}", Person_first_name, Person_middle_name, Person_last_name, Person_extension_name)) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Relative_role, Relative_dom, Relative_idperson,
                                Relative_role, Relative_idperson, Relative_dom,
                             Person_civil_status, Relative_idperson, Person_civil_status)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub LoadFamilyMember(dgv As DataGridView, str As String)
        Try
            Dim sql As String = ""
            sql = "select * from person inner join relative on person.idperson = relative.relative_idperson " _
                    & "where relative.person_idperson = '" & str & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                If MySqlDR("relative_role") = "Spouse" Then
                    dgv.Rows.Add(MySqlDR("idperson"), MySqlDR("person_last_name"), MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_extension_name"),
                            String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")),
                            MySqlDR("person_gender"), MySqlDR("relative_role"),
                            1, MySqlDR("relative_date_of_marriage"), MySqlDR("person_status"))
                Else
                    dgv.Rows.Add(MySqlDR("idperson"), MySqlDR("person_last_name"), MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_extension_name"),
                            String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")),
                            MySqlDR("person_gender"), MySqlDR("relative_role"),
                            0, "", MySqlDR("person_status"))
                End If


            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadPersonResidentDgv(dgv As DataGridView, gender As String, seniorCitizen As String)
        Try
            Dim sql As String = ""
            If gender = "All" Then
                sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                 & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                 & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                 & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) As 'street_obj'," _
                 & "(SELECT YEAR(CURDATE()) - 
                    YEAR(person_date_of_birth) - 
                    IF(STR_TO_DATE(CONCAT(YEAR(CURDATE()), '-',
                    MONTH(person_date_of_birth), '-', DAY(person_date_of_birth)) ,'%Y-%c-%e') > CURDATE(), 1, 0) 
                    ) AS 'age'" _
                 & " FROM person INNER JOIN household_member On person.idperson = household_member.person_idperson " _
                 & "INNER JOIN household ON household_member.household_idhousehold = household.idhousehold" _
                 & "  INNER JOIN household_has_house On household.idhousehold = household_has_house.household_idhousehold" _
                 & "  INNER JOIN house ON household_has_house.house_idhouse = house.idhouse" _
                 & "  INNER JOIN lot_house ON house.lot_house_idlot_house = lot_house.idlot_house " _
                 & "WHERE person.person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                 & "person.person_vital_status = '" & MySqlHelper.EscapeString("Alive") & "' AND person.person_reg_date <= CURRENT_DATE;"
            Else
                sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                 & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                 & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                 & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) As 'street_obj'," _
                 & "(SELECT YEAR(CURDATE()) - 
                    YEAR(person_date_of_birth) - 
                    IF(STR_TO_DATE(CONCAT(YEAR(CURDATE()), '-',
                    MONTH(person_date_of_birth), '-', DAY(person_date_of_birth)) ,'%Y-%c-%e') > CURDATE(), 1, 0) 
                    ) AS 'age'" _
                 & " FROM person INNER JOIN household_member On person.idperson = household_member.person_idperson " _
                 & "INNER JOIN household ON household_member.household_idhousehold = household.idhousehold" _
                 & "  INNER JOIN household_has_house On household.idhousehold = household_has_house.household_idhousehold" _
                 & "  INNER JOIN house ON household_has_house.house_idhouse = house.idhouse" _
                 & "  INNER JOIN lot_house ON house.lot_house_idlot_house = lot_house.idlot_house " _
                 & "WHERE person.person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                 & "person.person_vital_status = '" & MySqlHelper.EscapeString("Alive") & "' AND person.person_reg_date <= CURRENT_DATE " _
                 & "AND person.person_gender = '" & gender & "';"

            End If



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                If seniorCitizen = "True" Then
                    If MySqlDR("age") >= 60 Then
                        dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                           MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                             Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"),
                            MySqlDR("age"), String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("person_status"))
                    End If
                Else
                    dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                           MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                             Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"),
                            MySqlDR("age"), String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("person_status"))
                End If


            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchPersonResidentDgv(dgv As DataGridView, gender As String, seniorCitizen As String, txt As String)
        Try
            Dim sql As String = ""
            If gender = "All" And seniorCitizen = "False" Then
                sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                  & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                  & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                  & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) As 'street_obj'," _
                  & "(SELECT YEAR(CURDATE()) - 
                    YEAR(person_date_of_birth) - 
                    IF(STR_TO_DATE(CONCAT(YEAR(CURDATE()), '-',
                    MONTH(person_date_of_birth), '-', DAY(person_date_of_birth)) ,'%Y-%c-%e') > CURDATE(), 1, 0) 
                    ) AS 'age'" _
                  & " FROM person INNER JOIN household_member On person.idperson = household_member.person_idperson " _
                  & "INNER JOIN household ON household_member.household_idhousehold = household.idhousehold" _
                  & "  INNER JOIN household_has_house On household.idhousehold = household_has_house.household_idhousehold" _
                  & "  INNER JOIN house ON household_has_house.house_idhouse = house.idhouse" _
                  & "  INNER JOIN lot_house ON house.lot_house_idlot_house = lot_house.idlot_house " _
                  & "WHERE person.person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                  & "person.person_vital_status = '" & MySqlHelper.EscapeString("Alive") & "' AND person.person_reg_date <= CURRENT_DATE " _
                  & "AND (person.person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
                  & "OR person.person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person.person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
                  & "OR person.person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
                  & "(CONCAT(person.person_first_name,' ',person.person_middle_name,' ',person.person_last_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
                  & "(CONCAT(person.person_first_name,' ',person.person_last_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
                  & "(CONCAT(person.person_last_name,' ',person.person_first_name,' ',person.person_middle_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "'));"
            Else
                sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                 & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                 & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                 & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) As 'street_obj'," _
                 & "(SELECT YEAR(CURDATE()) - 
                    YEAR(person_date_of_birth) - 
                    IF(STR_TO_DATE(CONCAT(YEAR(CURDATE()), '-',
                    MONTH(person_date_of_birth), '-', DAY(person_date_of_birth)) ,'%Y-%c-%e') > CURDATE(), 1, 0) 
                    ) AS 'age'" _
                 & " FROM person INNER JOIN household_member On person.idperson = household_member.person_idperson " _
                 & "INNER JOIN household ON household_member.household_idhousehold = household.idhousehold" _
                 & "  INNER JOIN household_has_house On household.idhousehold = household_has_house.household_idhousehold" _
                 & "  INNER JOIN house ON household_has_house.house_idhouse = house.idhouse" _
                 & "  INNER JOIN lot_house ON house.lot_house_idlot_house = lot_house.idlot_house " _
                 & "WHERE person.person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                 & "person.person_vital_status = '" & MySqlHelper.EscapeString("Alive") & "' AND person.person_reg_date <= CURRENT_DATE " _
                 & "AND person.person_gender = '" & gender & "' " _
                  & "AND (person.person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
                  & "OR person.person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person.person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
                  & "OR person.person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
                  & "(CONCAT(person.person_first_name,' ',person.person_middle_name,' ',person.person_last_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
                  & "(CONCAT(person.person_first_name,' ',person.person_last_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
                  & "(CONCAT(person.person_last_name,' ',person.person_first_name,' ',person.person_middle_name,' ',person.person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "'));"
            End If



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                If seniorCitizen = "True" Then
                    If MySqlDR("age") >= 60 Then
                        dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                           MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                             Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"),
                            MySqlDR("age"), String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("person_status"))
                    End If
                Else
                    dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                           MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                             Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"),
                            MySqlDR("age"), String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("person_status"))
                End If
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
