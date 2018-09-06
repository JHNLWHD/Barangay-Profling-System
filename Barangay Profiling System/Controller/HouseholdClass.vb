Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class HouseholdClass
    Inherits HouseClass

    Private _idhousehold As Integer = 0
    Private _household_code As String = ""
    Private _household_status As String = ""
    Private _household_remove_status As String = ""
    Private _household_reg_date As Date
    Private _household_head As String = ""

    Private _idhousehold_has_house As Integer = 0
    Private _household_idhousehold As Integer = 0
    Private _house_idhouse As Integer = 0
    Private _household_has_house_reg_date As Date
    Private _household_has_house_status As String = ""

    Private _household_member_role As String = ""
    Private _household_member_reg_date As Date
    Private _idhousehold_member As Integer = 0
    Private _household_member_is_head As String = ""
    Private _household_memeber_head_status As String = ""

    Public Property Idhousehold As Integer
        Get
            Return _idhousehold
        End Get
        Set(value As Integer)
            _idhousehold = value
        End Set
    End Property

    Public Property Household_code As String
        Get
            Return _household_code
        End Get
        Set(value As String)
            _household_code = value
        End Set
    End Property

    Public Property Household_status As String
        Get
            Return _household_status
        End Get
        Set(value As String)
            _household_status = value
        End Set
    End Property

    Public Property Household_remove_status As String
        Get
            Return _household_remove_status
        End Get
        Set(value As String)
            _household_remove_status = value
        End Set
    End Property

    Public Property Household_reg_date As Date
        Get
            Return _household_reg_date
        End Get
        Set(value As Date)
            _household_reg_date = value
        End Set
    End Property

    Public Property Idhousehold_has_house As Integer
        Get
            Return _idhousehold_has_house
        End Get
        Set(value As Integer)
            _idhousehold_has_house = value
        End Set
    End Property

    Public Property Household_idhousehold As Integer
        Get
            Return _household_idhousehold
        End Get
        Set(value As Integer)
            _household_idhousehold = value
        End Set
    End Property



    Public Property Household_has_house_reg_date As Date
        Get
            Return _household_has_house_reg_date
        End Get
        Set(value As Date)
            _household_has_house_reg_date = value
        End Set
    End Property

    Public Property Household_has_house_status As String
        Get
            Return _household_has_house_status
        End Get
        Set(value As String)
            _household_has_house_status = value
        End Set
    End Property

    Public Property House_idhouse1 As Integer
        Get
            Return House_idhouse
        End Get
        Set(value As Integer)
            House_idhouse = value
        End Set
    End Property

    Public Property Household_member_role As String
        Get
            Return _household_member_role
        End Get
        Set(value As String)
            _household_member_role = value
        End Set
    End Property

    Public Property Household_member_reg_date As Date
        Get
            Return _household_member_reg_date
        End Get
        Set(value As Date)
            _household_member_reg_date = value
        End Set
    End Property

    Public Property Idhousehold_member As Integer
        Get
            Return _idhousehold_member
        End Get
        Set(value As Integer)
            _idhousehold_member = value
        End Set
    End Property

    Public Property Household_member_is_head As String
        Get
            Return _household_member_is_head
        End Get
        Set(value As String)
            _household_member_is_head = value
        End Set
    End Property

    Public Property House_idhouse As Integer
        Get
            Return _house_idhouse
        End Get
        Set(value As Integer)
            _house_idhouse = value
        End Set
    End Property

    Public Property Household_memeber_head_status As String
        Get
            Return _household_memeber_head_status
        End Get
        Set(value As String)
            _household_memeber_head_status = value
        End Set
    End Property

    Public Property Household_head As String
        Get
            Return _household_head
        End Get
        Set(value As String)
            _household_head = value
        End Set
    End Property

    Public Sub LoadResidentInHouseHold(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM person;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Public Sub GetResidentDetails(id As Integer)
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
            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AddResident() As Boolean
        Try

            Dim sql As String = "INSERT INTO person(person_last_name,person_first_name,person_middle_name,person_extension_name,person_gender,person_mobile_no,person_tel_no,person_date_of_birth,person_civil_status,person_status,person_reg_date,person_reg_date_resident) VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8,'" & MySqlHelper.EscapeString("Resident") & "',CURRENT_DATE,CURRENT_DATE);"
            ConnectToServer()
            ServerExecuteSQL(sql, Person_last_name, Person_first_name, Person_middle_name, Person_extension_name, Person_gender, Person_mobile_no, Person_tel_no, Person_date_of_birth, Person_civil_status)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("class")
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function


    Public Function AddHouseholdNewhead(str As String) As Boolean
        Try

            Dim sql As String = "INSERT INTO household(household_status,household_remove_status,household_reg_date," _
                                & "household_code,household_head) VALUES ('" & MySqlHelper.EscapeString("Active") & "','" & MySqlHelper.EscapeString("False") & "',CURRENT_DATE,@0,@1);"
            sql += str
            sql += "INSERT INTO household_has_house(household_idhousehold,house_idhouse,household_has_house_reg_date,household_has_house_status) VALUES ((SELECT MAX(idhousehold) FROM household),@2,CURRENT_DATE,'" & MySqlHelper.EscapeString("Active") & "');"
            sql += "INSERT INTO household_member(household_idhousehold,person_idperson,household_member_role,household_member_reg_date,household_member_is_head," _
                    & "household_member_head_status) VALUES ((SELECT MAX(idhousehold) FROM household),(SELECT MAX(idperson) FROM person),@3,CURRENT_DATE,'" & MySqlHelper.EscapeString("True") & "','" & MySqlHelper.EscapeString("Active") & "');"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new household: " + Household_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new household: " + Household_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Household_code, Household_head, House_idhouse, Household_member_role)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("class")
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function AddHouseholdOldhead() As Boolean
        Try

            Dim sql As String = "INSERT INTO household(household_status,household_remove_status,household_reg_date," _
                                & "household_code,household_head) VALUES ('" & MySqlHelper.EscapeString("Active") & "','" & MySqlHelper.EscapeString("False") & "',CURRENT_DATE,@0,@1);"
            sql += "INSERT INTO household_has_house(household_idhousehold,house_idhouse,household_has_house_reg_date,household_has_house_status) VALUES ((SELECT MAX(idhousehold) FROM household),@2,CURRENT_DATE,'" & MySqlHelper.EscapeString("Active") & "');"
            sql += "INSERT INTO household_member(household_idhousehold,person_idperson,household_member_role,household_member_reg_date,household_member_is_head," _
                    & "household_member_head_status) VALUES ((SELECT MAX(idhousehold) FROM household),@3,@4,CURRENT_DATE,'" & MySqlHelper.EscapeString("True") & "','" & MySqlHelper.EscapeString("Active") & "');"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new household: " + Household_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new household: " + Household_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Household_code, Household_head, House_idhouse, Person_idperson, Household_member_role)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("class")
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub LoadLotOwnerHistory(actions As String, id As Integer, status As String)
        Try
            Dim sql As String = ""
            If actions = "Current" Then
                sql = "SELECT * FROM person INNER JOIN lot_ownership WHERE lot_ownership.lot_house_idlot_house = '" & MySqlHelper.EscapeString(id) & "' AND lot_ownership.lot_ownership_status = '" & MySqlHelper.EscapeString(status) & "';"

            Else
                sql = "SELECT * FROM person INNER JOIN lot_ownership WHERE lot_ownership.lot_house_idlot_house = '" & MySqlHelper.EscapeString(id) & "' AND lot_ownership.lot_ownership_status = '" & MySqlHelper.EscapeString(status) & "';"
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            'dgv.Rows.Clear()

            While MySqlDR.Read

                Person_first_name = MySqlDR("person_first_name")
                Person_last_name = MySqlDR("person_last_name")
                Person_middle_name = MySqlDR("person_middle_name")
                Person_extension_name = MySqlDR("person_extension_name")
                Person_place_of_birth = MySqlDR("person_place_of_birth")
                Person_gender = MySqlDR("person_gender")
                Person_date_of_birth = MySqlDR("person_date_of_birth")
                Person_mobile_no = MySqlDR("person_mobile_no")
                Person_tel_no = MySqlDR("person_tel_no")
                Person_civil_status = MySqlDR("person_civil_status")
                Person_status = MySqlDR("person_status")

            End While

            'dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub LoadLotOwnerHistoryDgv(dgv As DataGridView, id As Integer)
        Try
            Dim sql As String = ""

            sql = "SELECT * FROM person INNER JOIN lot_ownership ON person.idperson = lot_ownership.person_idperson WHERE lot_ownership.lot_house_idlot_house = '" & MySqlHelper.EscapeString(id) & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idperson"), (MySqlDR("person_first_name") + " " + MySqlDR("person_middle_name") + " " +
                             MySqlDR("person_last_name") + " " + MySqlDR("person_extension_name")),
                             MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("lot_ownership_status"),
                             MySqlDR("lot_ownership_reg_date"))
                ' Date.ParseExact("lot_ownership_reg_date", "yyyy-MM-dd", CultureInfo.InvariantCulture)

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHouseOwnerHistoryDgv(dgv As DataGridView, id As Integer)
        Try
            Dim sql As String = ""

            sql = "SELECT * FROM person INNER JOIN house_ownership ON person.idperson = house_ownership.person_idperson WHERE house_ownership.house_idhouse = '" & MySqlHelper.EscapeString(id) & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idperson"), (MySqlDR("person_first_name") + " " + MySqlDR("person_middle_name") + " " +
                             MySqlDR("person_last_name") + " " + MySqlDR("person_extension_name")),
                             MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("house_ownership_status"),
                             MySqlDR("house_ownership_reg_date"))
                ' Date.ParseExact("lot_ownership_reg_date", "yyyy-MM-dd", CultureInfo.InvariantCulture)

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Public Sub LoadHouseOwnerHistory(actions As String, id As Integer, status As String)
        Try
            Dim sql As String = ""
            If actions = "Current" Then
                sql = "SELECT * FROM person INNER JOIN house_ownership WHERE house_ownership.house_idhouse = '" & MySqlHelper.EscapeString(id) & "' AND house_ownership.house_ownership_status = '" & MySqlHelper.EscapeString(status) & "';"

            Else
                sql = "SELECT * FROM person INNER JOIN house_ownership WHERE house_ownership.house_idhouse = '" & MySqlHelper.EscapeString(id) & "' AND house_ownership.house_ownership_status = '" & MySqlHelper.EscapeString(status) & "';"
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            'dgv.Rows.Clear()

            While MySqlDR.Read

                Person_first_name = MySqlDR("person_first_name")
                Person_last_name = MySqlDR("person_last_name")
                Person_middle_name = MySqlDR("person_middle_name")
                Person_extension_name = MySqlDR("person_extension_name")
                Person_place_of_birth = MySqlDR("person_place_of_birth")
                Person_gender = MySqlDR("person_gender")
                Person_date_of_birth = MySqlDR("person_date_of_birth")
                Person_mobile_no = MySqlDR("person_mobile_no")
                Person_tel_no = MySqlDR("person_tel_no")
                Person_civil_status = MySqlDR("person_civil_status")
                Person_status = MySqlDR("person_status")

            End While

            ' dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub LoadHouseholdSearch(dgv As DataGridView, txt As String)
        Try
            Dim sql As String = ""

            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member on household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson where household.household_code LIKE '" & MySqlHelper.EscapeString(txt) & "%';"
            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idhousehold"), MySqlDR("household_code"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LoadHouseholdSearch(txt As String)
        Try
            Dim sql As String = ""

            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member on household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson where household.idhousehold = '" & MySqlHelper.EscapeString(txt) & "';"
            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader

            While MySqlDR.Read

                House_code = MySqlDR("house_code")
                Household_code = MySqlDR("household_code")
                Idhousehold = MySqlDR("idhousehold")
                Idhousehold_member = MySqlDR("idhousehold_member")
                Household_member_role = MySqlDR("household_member_role")
                Idhousehold_has_house = MySqlDR("idhousehold_has_house")
                Idperson = MySqlDR("idperson")
                Person_first_name = MySqlDR("person_first_name")
                Person_middle_name = MySqlDR("person_middle_name")
                Person_last_name = MySqlDR("person_last_name")
                Person_extension_name = MySqlDR("person_extension_name")

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Changehead(str As String) As Boolean
        Try

            Dim sql As String = "UPDATE household SET household_head = @0 WHERE idhousehold = @1;"
            sql += "UPDATE household_member SET household_member_head_status = @2,household_member_role=@3 WHERE idhousehold_member = @4;"
            sql += "INSERT INTO household_member(household_idhousehold,person_idperson,household_member_role,household_member_reg_date,household_member_is_head," _
                    & "household_member_head_status) VALUES (@5,@6,@7,CURRENT_DATE,'" & MySqlHelper.EscapeString("True") & "','" & MySqlHelper.EscapeString("Active") & "');"
            sql += str
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have update household: " + Household_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have update household: " + Household_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Household_head, Idhousehold, Household_memeber_head_status, Household_member_role,
                             Idhousehold_member, Household_idhousehold, Person_idperson, Household_member_role)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function NoChangehead() As Boolean
        Try

            Dim sql As String = ""
            sql += "UPDATE household_member SET household_member_role=@0 WHERE idhousehold_member = @1;"
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have update household: " + Household_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have update household: " + Household_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Household_member_role, Idhousehold_member)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub LoadHouseholdRecords(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member On household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson where household_member.household_member_is_head = 'True';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idhousehold"), MySqlDR("idperson"), MySqlDR("household_code"), MySqlDR("house_code"), MySqlDR("household_status"),
                             MySqlDR("household_head"), MySqlDR("household_member_role"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchHouseholdRecords(dgv As DataGridView, txt As String)
        Try
            Dim sql As String = ""
            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member On household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson " _
                  & "where household.household_code Like '" & txt & "%' OR house.house_code Like '" & txt & "%' OR household.household_head LIKE '" & txt & "%';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idhousehold"), MySqlDR("idperson"), MySqlDR("household_code"), MySqlDR("house_code"), MySqlDR("household_status"),
                             MySqlDR("household_head"), MySqlDR("household_member_role"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHouseholdMember(dgv As DataGridView, str As String)
        Try
            Dim sql As String = ""
            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member On household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson where household.household_head = '" & str & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"),
                                           MySqlDR("person_extension_name")), MySqlDR("household_member_role"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHouseholdhead(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "select * from household inner join household_has_house on household.idhousehold = household_has_house.household_idhousehold " _
                  & "inner join house on household_has_house.house_idhouse = house.idhouse " _
                  & "inner join household_member On household_has_house.idhousehold_has_house = household_member.household_idhousehold " _
                  & "inner join person on household_member.person_idperson = person.idperson " _
                  & "where household_member.household_member_is_head = '" & "True" & "' " _
                  & "AND household_member.household_member_head_status = '" & "Active" & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read

                dgv.Rows.Add(MySqlDR("idperson"), MySqlDR("idhouse"), MySqlDR("house_code"), MySqlDR("idhousehold"),
                             MySqlDR("household_head"), MySqlDR("household_member_role"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
