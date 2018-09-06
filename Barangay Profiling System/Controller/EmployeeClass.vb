Imports MySql.Data.MySqlClient
Public Class EmployeeClass
    Inherits PersonClass

    Private _idemployee As Integer = 0
    Private _idemployee_obj As Integer = 0
    Private _person_idperson As Integer = 0
    Private _employee_position As String = ""
    Private _employee_status As String = ""
    Private _employee_type As String = ""
    Private _employee_date_reg As Date
    Private _employee_history_description As String = ""
    Private _employee_idemployee As Integer = 0
    Private _employee_history_date As Date
    Private _idemployee_history As Integer = 0


    Public Property Employee_history_date As Date
        Get
            Return _employee_history_date
        End Get
        Set(value As Date)
            _employee_history_date = value
        End Set
    End Property


    Public Property Employee_Date_reg As Date
        Get
            Return _employee_date_reg
        End Get
        Set(value As Date)
            _employee_date_reg = value
        End Set
    End Property

    Public Property IdEmployee As Integer
        Get
            Return _idemployee
        End Get
        Set(value As Integer)
            _idemployee = value
        End Set
    End Property


    Public Property Employee_idemployee As Integer
        Get
            Return Employee_idemployee
        End Get
        Set(value As Integer)
            _employee_idemployee = value
        End Set
    End Property

    Public Property Idemployee_history As Integer
        Get
            Return _idemployee_history
        End Get
        Set(value As Integer)
            _idemployee_history = value
        End Set
    End Property


    Public Property Employee_history_description As String
        Get
            Return _employee_history_description
        End Get
        Set(value As String)
            _employee_history_description = value
        End Set
    End Property

    Public Property Employee_position As String
        Get
            Return _employee_position
        End Get
        Set(value As String)
            _employee_position = value
        End Set
    End Property


    Public Property Employee_status As String
        Get
            Return _employee_status
        End Get
        Set(value As String)
            _employee_status = value
        End Set
    End Property


    Public Property Employee_type As String
        Get
            Return _employee_type
        End Get
        Set(value As String)
            _employee_type = value
        End Set
    End Property

    Public Property Idemployee_obj As Integer
        Get
            Return _idemployee_obj
        End Get
        Set(value As Integer)
            _idemployee_obj = value
        End Set
    End Property

    Public Function AddEmployee() As Boolean
        Try
            Dim sql As String = "INSERT INTO employee(employee_position,employee_type,employee_status,person_idperson,employee_reg_date) VALUES(@0,@1,@2,@3,CURRENT_DATE);"
            sql += "INSERT INTO employee_history (employee_history_desc,employee_history_date,employee_idemployee) VALUES (@4,CURRENT_DATE,(SELECT MAX(idemployee) FROM employee));"
            ConnectToServer()
            ServerExecuteSQL(sql, Employee_position, Employee_type, Employee_status, Person_idperson, Employee_history_description)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function UpdateEmployee() As Boolean
        Try

            Dim sql As String = "UPDATE employee SET employee_position=@0,employee_type=@1,employee_status=@2 WHERE idemployee=@3;"
            sql += "INSERT INTO employee_history (employee_history_description,employee_history_date,employee_idemployee) VALUES (@4,CURRENT_DATE,@5);"
            ConnectToServer()
            ServerExecuteSQL(sql, Employee_position, Employee_type, Employee_status, IdEmployee, Employee_history_description, Employee_idemployee)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Sub LoadPersonAtEmployee(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM person WHERE person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                & "person_vital_status = '" & MySqlHelper.EscapeString("Alive") & "' AND person_reg_date <= CURRENT_DATE;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idperson"),
                             String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                           MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                             Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd") , MySqlDR("person_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SearchPersonAtEmployee(dgv As DataGridView, str As String)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM person WHERE (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                & "CONCAT(person_last_name,',',person_first_name,' ',person_middle_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%') " _
                & "OR (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                & "CONCAT(person_first_name,',',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%');"

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

    Public Sub SearchEmployee(dgv As DataGridView, str As String, limit As Integer)
        Try
            Dim sql As String = ""
            If limit = 0 Then
                sql = "SELECT * FROM employee INNER JOIN person on person.idperson = employee.person_idperson WHERE (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                    & "CONCAT(person_last_name,',',person_first_name,' ',person_middle_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%') " _
                    & "OR (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                    & "CONCAT(person_first_name,',',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%');"
            Else
                sql = "SELECT * FROM employee INNER JOIN person on person.idperson = employee.person_idperson WHERE (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                    & "CONCAT(person_last_name,',',person_first_name,' ',person_middle_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%') " _
                    & "OR (person_status = '" & MySqlHelper.EscapeString("Resident") & "' AND " _
                    & "CONCAT(person_first_name,',',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(str) & "%') LIMIT 5;"
            End If


            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                If limit = 0 Then
                    dgv.Rows.Add(MySqlDR("idemployee"),
                                 String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"),
                                               MySqlDR("person_last_name"), MySqlDR("person_extension_name")),
                                 MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("employee_status"), MySqlDR("employee_reg_date"),
                                 MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"),
                                 Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"))
                Else
                    dgv.Rows.Add(MySqlDR("idemployee"),
                           String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"),
                                         MySqlDR("person_middle_name"), MySqlDR("person_last_name"),
                                         MySqlDR("person_extension_name")))
                End If

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadEmployeeMain(dgv As DataGridView, stat As String)
        Try

            Dim sql As String = ""
            If stat = "All" Then
                sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson;"
            Else
                sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson WHERE employee_status = '" & MySqlHelper.EscapeString(stat) & "';"
            End If


            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idemployee"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")),
                             MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("employee_status"), MySqlDR("employee_reg_date"), MySqlDR("person_gender"),
                             MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchEmployeeMain(dgv As DataGridView, txt As String, stat As String)
        Try

            Dim sql As String = ""
            If stat = "All" Then
                sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson WHERE person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "Or person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
              & "(CONCAT(person_first_name,' ',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_first_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_last_name,' ',person_first_name,' ',person_middle_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "');"
            Else
                sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson WHERE employee_status = '" & MySqlHelper.EscapeString(stat) & "' AND " _
              & "(person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "Or person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
              & "(CONCAT(person_first_name,' ',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_first_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_last_name,' ',person_first_name,' ',person_middle_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "'));"
            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idemployee"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("employee_status"), MySqlDR("employee_date_reg"), MySqlDR("person_gender"), MySqlDR("person_civil_status"), MySqlDR("person_mobile_no"), MySqlDR("person_tel_no"), Convert.ToDateTime(MySqlDR("person_date_of_birth")).ToString("yyyy-MM-dd"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


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
            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub GetEmployeeDetails(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson  WHERE idemployee = '" & MySqlHelper.EscapeString(id) & "';"

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

                Employee_position = MySqlDR("employee_position")
                Employee_type = MySqlDR("employee_type")
                Employee_status = MySqlDR("employee_status")
                IdEmployee = MySqlDR("idemployee")


            End While
            MySqlDR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function isEmployeeActive(id As Integer) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            sql = "SELECT idemployee FROM employee WHERE person_idperson = '" & id & "' AND employee_status = '" & MySqlHelper.EscapeString("Active") & "';"

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)

            Dim oj As Object = ds.Tables(0).Rows(0)("idemployee")

        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function hasBarangayCaptainActive(str As String) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = "SELECT idemployee FROM employee WHERE employee_position = '" & MySqlHelper.EscapeString(str) & "' AND employee_status = '" & "Active" & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to ctch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idemployee")
            Idemployee_obj = ds.Tables(0).Rows(0)("idemployee")
        Catch ex As Exception

            ' MsgBox(ex.Message)
            Return False
            Exit Function
        Finally

        End Try
        Return True
    End Function

    Public Function hasBarangayCaptainActiveID(id As Integer) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = "SELECT idemployee FROM employee WHERE employee_position = '" & MySqlHelper.EscapeString("Barangay Captain") & "' AND employee_status = '" & "Active" & "' AND idemployee != '" & id & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to ctch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idemployee")

        Catch ex As Exception

            ' MsgBox(ex.Message)
            Return False
            Exit Function
        Finally

        End Try
        Return True
    End Function
    Public Function UpdateEmployeeStatus() As Boolean
        Try

            Dim sql As String = "UPDATE employee SET employee_status=@0 WHERE idemployee=@1;"
            sql += "INSERT INTO employee_history (employee_history_description,employee_history_date,employee_idemployee) VALUES (@2,CURRENT_DATE,@3);"
            ConnectToServer()
            ServerExecuteSQL(sql, Employee_status, IdEmployee, Employee_history_description, Employee_idemployee)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

End Class
