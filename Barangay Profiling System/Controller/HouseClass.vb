Imports MySql.Data.MySqlClient
Public Class HouseClass
    Inherits PersonClass

    Private _idlot_house As Integer = 0
    Private _lot_house_code As String = ""
    Private _lot_house_reg_date As Date
    Private _purok_idpurok As Object
    Private _road_idroad As Object
    Private _street_idstreet As Object
    Private _drive_iddrive As Object
    Private _lot_idlot As Integer = 0
    Private _address_name As String = ""

    Private _idhouse As Integer = 0
    Private _house_code As String = ""
    Private _house_reg_date As Date
    Private _lot_house_idlot_house As Integer = 0
    Private _house_name As String = ""
    Private _house_level As String = ""
    Private _house_type As String = ""
    Private _house_settlement_status As String = ""
    Private _house_status As String = ""
    Private _house_remarks As String = ""

    Private _idhouse_history As Integer = 0
    Private _house_history_desc As String = ""
    Private _house_history_date As Date

    Private _idhouse_ownership As Integer = 0
    Private _person_idperson As Integer = 0
    Private _house_idhouse As Integer = 0
    Private _house_ownership_reg_date As Date
    Private _house_ownership_status As String = ""

    Private _idlot_ownership As Integer = 0
    Private _lot_ownership_status As String = ""
    Private _lot_ownership_reg_date As Date

    Private _lot_owner_id As Integer = 0
    Private _house_owner_id As Integer = 0


    Public Property Idlot_house As Integer
        Get
            Return _idlot_house
        End Get
        Set(value As Integer)
            _idlot_house = value
        End Set
    End Property

    Public Property Lot_house_code As String
        Get
            Return _lot_house_code
        End Get
        Set(value As String)
            _lot_house_code = value
        End Set
    End Property

    Public Property Lot_house_reg_date As Date
        Get
            Return _lot_house_reg_date
        End Get
        Set(value As Date)
            _lot_house_reg_date = value
        End Set
    End Property

    Public Property Idhouse As Integer
        Get
            Return _idhouse
        End Get
        Set(value As Integer)
            _idhouse = value
        End Set
    End Property

    Public Property House_code As String
        Get
            Return _house_code
        End Get
        Set(value As String)
            _house_code = value
        End Set
    End Property

    Public Property House_reg_date As Date
        Get
            Return _house_reg_date
        End Get
        Set(value As Date)
            _house_reg_date = value
        End Set
    End Property

    Public Property Lot_house_idlot_house As Integer
        Get
            Return _lot_house_idlot_house
        End Get
        Set(value As Integer)
            _lot_house_idlot_house = value
        End Set
    End Property

    Public Property Idhouse_ownership As Integer
        Get
            Return _idhouse_ownership
        End Get
        Set(value As Integer)
            _idhouse_ownership = value
        End Set
    End Property

    'Public Property Person_idperson As Integer
    '    Get
    '        Return _person_idperson
    '    End Get
    '    Set(value As Integer)
    '        _person_idperson = value
    '    End Set
    'End Property

    Public Property House_idhouse As Integer
        Get
            Return _house_idhouse
        End Get
        Set(value As Integer)
            _house_idhouse = value
        End Set
    End Property

    Public Property House_ownership_reg_date As Date
        Get
            Return _house_ownership_reg_date
        End Get
        Set(value As Date)
            _house_ownership_reg_date = value
        End Set
    End Property

    Public Property House_ownership_status As String
        Get
            Return _house_ownership_status
        End Get
        Set(value As String)
            _house_ownership_status = value
        End Set
    End Property

    Public Property Idlot_ownership As Integer
        Get
            Return _idlot_ownership
        End Get
        Set(value As Integer)
            _idlot_ownership = value
        End Set
    End Property

    Public Property Lot_ownership_status As String
        Get
            Return _lot_ownership_status
        End Get
        Set(value As String)
            _lot_ownership_status = value
        End Set
    End Property

    Public Property Lot_ownership_reg_date As Date
        Get
            Return _lot_ownership_reg_date
        End Get
        Set(value As Date)
            _lot_ownership_reg_date = value
        End Set
    End Property

    Public Property Purok_idpurok As Object
        Get
            Return _purok_idpurok
        End Get
        Set(value As Object)
            _purok_idpurok = value
        End Set
    End Property

    Public Property Road_idroad As Object
        Get
            Return _road_idroad
        End Get
        Set(value As Object)
            _road_idroad = value
        End Set
    End Property

    Public Property Street_idstreet As Object
        Get
            Return _street_idstreet
        End Get
        Set(value As Object)
            _street_idstreet = value
        End Set
    End Property

    Public Property Drive_iddrive As Object
        Get
            Return _drive_iddrive
        End Get
        Set(value As Object)
            _drive_iddrive = value
        End Set
    End Property

    Public Property Lot_idlot As Integer
        Get
            Return _lot_idlot
        End Get
        Set(value As Integer)
            _lot_idlot = value
        End Set
    End Property

    Public Property House_name As String
        Get
            Return _house_name
        End Get
        Set(value As String)
            _house_name = value
        End Set
    End Property

    Public Property House_type As String
        Get
            Return _house_type
        End Get
        Set(value As String)
            _house_type = value
        End Set
    End Property

    Public Property House_settlement_status As String
        Get
            Return _house_settlement_status
        End Get
        Set(value As String)
            _house_settlement_status = value
        End Set
    End Property

    Public Property House_status As String
        Get
            Return _house_status
        End Get
        Set(value As String)
            _house_status = value
        End Set
    End Property

    Public Property House_remarks As String
        Get
            Return _house_remarks
        End Get
        Set(value As String)
            _house_remarks = value
        End Set
    End Property

    Public Property House_level As String
        Get
            Return _house_level
        End Get
        Set(value As String)
            _house_level = value
        End Set
    End Property

    Public Property Idhouse_history As Integer
        Get
            Return _idhouse_history
        End Get
        Set(value As Integer)
            _idhouse_history = value
        End Set
    End Property

    Public Property House_history_desc As String
        Get
            Return _house_history_desc
        End Get
        Set(value As String)
            _house_history_desc = value
        End Set
    End Property

    Public Property House_history_date As Date
        Get
            Return _house_history_date
        End Get
        Set(value As Date)
            _house_history_date = value
        End Set
    End Property

    Public Property Lot_owner_id As Integer
        Get
            Return _lot_owner_id
        End Get
        Set(value As Integer)
            _lot_owner_id = value
        End Set
    End Property

    Public Property House_owner_id As Integer
        Get
            Return _house_owner_id
        End Get
        Set(value As Integer)
            _house_owner_id = value
        End Set
    End Property

    Public Property Address_name As String
        Get
            Return Address_name1
        End Get
        Set(value As String)
            Address_name1 = value
        End Set
    End Property

    Public Property Address_name1 As String
        Get
            Return _address_name
        End Get
        Set(value As String)
            _address_name = value
        End Set
    End Property

    Public Function AddHouse(str As String) As Boolean
        Try
            Dim sql As String = ""
            sql = "INSERT INTO lot_house(lot_house_code,lot_house_reg_date,purok_idpurok," _
                & "drive_iddrive,road_idroad,street_idstreet) " _
                & "VALUES(@0,CURRENT_DATE,@1,@2,@3,@4);"
            sql += "INSERT INTO house(house_code,lot_house_idlot_house,house_reg_date,house_name,house_type,house_level," _
                & "house_settlement_status,house_status,house_remarks) " _
                & "VALUES(@5,(SELECT MAX(idlot_house) FROM lot_house),CURRENT_DATE,@6,@7,@8,@9,@10,@11);"
            sql += "INSERT INTO house_history(house_history_desc,house_history_date,house_idhouse) " _
                & "VALUES(@12,CURRENT_DATE,(SELECT MAX(idhouse) FROM house));"
            sql += str
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new house: " + House_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new house: " + House_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Lot_house_code, Purok_idpurok, Drive_iddrive, Road_idroad, Street_idstreet,
                             House_code, House_name, House_type, House_level, House_settlement_status, House_status, House_remarks, House_history_desc)
        Catch ex As Exception
            MsgBox(ex.Message + "hOUSE")
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function EditHouse(str As String) As Boolean
        Try

            Dim sql As String = ""
            sql = "UPDATE lot_house SET lot_house_code=@0,purok_idpurok=@1," _
                & "drive_iddrive=@2,road_idroad=@3,street_idstreet=@4 WHERE idlot_house=@5;"
            sql += "UPDATE house SET house_code=@6,house_name=@7,house_type=@8,house_level=@9," _
                & "house_settlement_status=@10,house_status=@11,house_remarks=@12 WHERE idhouse=@13;"
            sql += "INSERT INTO house_history(house_history_desc,house_history_date,house_idhouse) " _
                & "VALUES(@14,CURRENT_DATE,@15);"
            sql += str
            sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
                & "VALUES('" & MySqlHelper.EscapeString("You have saved new house: " + House_code) & "'," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new house: " + House_code) & "',CURRENT_TIMESTAMP," _
                & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Lot_house_code, Purok_idpurok, Drive_iddrive, Road_idroad, Street_idstreet, Idlot_house,
                             House_code, House_name, House_type, House_level, House_settlement_status, House_status, House_remarks,
                             Idhouse, House_history_desc, Idhouse)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub LoadHouseDetails(dgv As DataGridView, status As String)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj'" _
                & " FROM lot_house INNER JOIN house ON lot_house.idlot_house = house.lot_house_idlot_house WHERE house.house_status = '" & status & "';"




            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idlot_house"), MySqlDR("lot_house_code"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("idhouse"), MySqlDR("house_code"), MySqlDR("house_settlement_status"), MySqlDR("house_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchHouseDetails(dgv As DataGridView, status As String, search As String)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj'" _
                & " FROM lot_house INNER JOIN house ON lot_house.idlot_house = house.lot_house_idlot_house WHERE house.house_status = '" & status & "' " _
                & "AND (lot_house.lot_house_code LIKE '" & search & "%' OR house.house_code LIKE '" & search & "%');"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idlot_house"), MySqlDR("lot_house_code"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")),
                             MySqlDR("idhouse"), MySqlDR("house_code"), MySqlDR("house_settlement_status"), MySqlDR("house_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchHouseCode(dgv As DataGridView, str As String)
        Try
            Dim sql As String = ""

            sql = "SELECT * FROM house WHERE house_code Like '%" & MySqlHelper.EscapeString(str) & "%';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idhouse"), MySqlDR("house_code"), MySqlDR("lot_house_idlot_house"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetLotHouseDetails(id As String)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM lot_house INNER JOIN lot_ownership" _
                & " ON lot_house.idlot_house = lot_ownership.lot_house_idlot_house " _
                & "WHERE lot_house.idlot_house = '" & MySqlHelper.EscapeString(id) & "' " _
                & "AND lot_ownership.lot_ownership_status = '" & MySqlHelper.EscapeString("Active") & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

                Idlot_house = MySqlDR("idlot_house")
                Lot_house_code = MySqlDR("lot_house_code")
                Purok_idpurok = MySqlDR("purok_idpurok")
                Street_idstreet = MySqlDR("street_idstreet")
                Drive_iddrive = MySqlDR("drive_iddrive")
                Road_idroad = MySqlDR("road_idroad")
                Lot_owner_id = MySqlDR("person_idperson")
                Lot_ownership_status = MySqlDR("lot_ownership_status")

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetHouseDetails(code As String, idlot As String)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM house INNER JOIN house_ownership ON house.idhouse = house_ownership.house_idhouse " _
                & "WHERE house.house_code = '" & MySqlHelper.EscapeString(code) & "' AND " _
                & "house.lot_house_idlot_house = '" & MySqlHelper.EscapeString(idlot) & "' AND " _
                & "house_ownership.house_ownership_status = '" & MySqlHelper.EscapeString("Active") & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

                Idhouse = MySqlDR("idhouse")
                House_code = MySqlDR("house_code")
                House_name = MySqlDR("house_name")
                House_type = MySqlDR("house_type")
                House_level = MySqlDR("house_level")
                House_settlement_status = MySqlDR("house_settlement_status")
                House_status = MySqlDR("house_status")
                House_ownership_status = MySqlDR("house_ownership_status")
                House_owner_id = MySqlDR("person_idperson")

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetOwnerDetails(id As Integer)
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

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetAddressDetails(id As String)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj'" _
                & " FROM lot_house WHERE lot_house.idlot_house = '" & MySqlHelper.EscapeString(id) & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read
                Address_name = String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj"))
            End While


            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHouseHistory(dgv As DataGridView, id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM house INNER JOIN house_history WHERE house_idhouse = '" & MySqlHelper.EscapeString(id) & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                House_code = MySqlDR("house_code")
                House_name = MySqlDR("house_name")
                House_type = MySqlDR("house_type")

                dgv.Rows.Add(MySqlDR("idhouse_history"), MySqlDR("house_history_desc"), Convert.ToDateTime(MySqlDR("house_history_date")).ToString("MMMM dd, yyyy"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetLotOwnerInfoDetails(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                  & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                  & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                  & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj' " _
                  & "FROM lot_house INNER JOIN lot_ownership ON  lot_house.idlot_house = lot_ownership.lot_house_idlot_house INNER JOIN person " _
                  & "ON lot_ownership.person_idperson = person.idperson" _
                  & " INNER JOIN house On lot_house.idlot_house = house.lot_house_idlot_house WHERE lot_ownership_status = 'Active' AND house.idhouse = '" & id & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

                Person_first_name = MySqlDR("person_first_name")
                Person_middle_name = MySqlDR("person_middle_name")
                Person_last_name = MySqlDR("person_last_name")
                Person_extension_name = MySqlDR("person_extension_name")

                Lot_house_code = MySqlDR("lot_house_code")
                House_code = MySqlDR("house_code")
                House_name = MySqlDR("house_name")
                House_level = MySqlDR("house_level")
                House_type = MySqlDR("house_type")
                House_settlement_status = MySqlDR("house_settlement_status")
                House_remarks = MySqlDR("house_remarks")

                Address_name = String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj"))

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub GetHouseOwnerInfoDetails(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM house INNER JOIN house_ownership ON house.idhouse = house_ownership.house_idhouse " _
                & "INNER JOIN person On house_ownership.person_idperson = person.idperson WHERE house_ownership.house_ownership_status = 'Active' AND house.idhouse = '" & id & "';"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

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

    Public Sub LoadHouseRecords(dgv As DataGridView, status As String)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj'" _
                & " FROM lot_house INNER JOIN house ON lot_house.idlot_house = house.lot_house_idlot_house WHERE house.house_status = '" & status & "';"




            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idhouse"), MySqlDR("lot_house_code"), MySqlDR("house_name"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj")))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetHouseDetails(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT *,(SELECT purok_name FROM purok WHERE idpurok = purok_idpurok LIMIT 1) AS 'purok_obj'," _
                  & "(SELECT drive_name FROM drive WHERE iddrive = drive_iddrive LIMIT 1) AS 'drive_obj'," _
                  & "(SELECT road_name FROM road WHERE idroad = road_idroad LIMIT 1) AS 'road_obj'," _
                  & "(SELECT street_name FROM street WHERE idstreet = street_idstreet LIMIT 1) AS 'street_obj'" _
                  & " FROM lot_house INNER JOIN house ON lot_house.idlot_house = house.lot_house_idlot_house WHERE house.idhouse = '" & id & "';"
            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read

                Idhouse = MySqlDR("idhouse")
                House_code = MySqlDR("house_code")
                Address_name = String.Format("{0} {1} {2} {3}", MySqlDR("purok_obj"),
                                           MySqlDR("drive_obj"), MySqlDR("road_obj"), MySqlDR("street_obj"))


            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
