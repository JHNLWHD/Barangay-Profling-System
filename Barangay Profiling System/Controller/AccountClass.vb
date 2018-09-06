Imports MySql.Data.MySqlClient
Public Class AccountClass
    Inherits EmployeeClass


    Private _idaccount As Integer = 0
    Private _employee_idemloyee As Integer = 0
    Private _person_idperson As Integer = 0
    Private _account_username As String = ""
    Private _account_password As String = ""
    Private _account_name As String = ""
    Private _account_type As String = ""
    Private _account_security_question As String = ""
    Private _account_answer As String = ""
    Private _account_status As String = ""
    Private _account_position As String = ""
    Private _account_isLogin As String = ""




    Public Property Idaccount As Integer
        Get
            Return _idaccount
        End Get
        Set(value As Integer)
            _idaccount = value
        End Set
    End Property


    Public Property Account_status As String
        Get
            Return _account_status
        End Get
        Set(value As String)
            _account_status = value
        End Set
    End Property

    Public Property Account_username As String
        Get
            Return _account_username
        End Get
        Set(value As String)
            _account_username = value
        End Set
    End Property

    Public Property Account_password As String
        Get
            Return _account_password
        End Get
        Set(value As String)
            _account_password = value
        End Set
    End Property

    Public Property Account_name As String
        Get
            Return _account_name
        End Get
        Set(value As String)
            _account_name = value
        End Set
    End Property

    Public Property Account_type As String
        Get
            Return _account_type
        End Get
        Set(value As String)
            _account_type = value
        End Set
    End Property

    Public Property Account_security_question As String
        Get
            Return _account_security_question
        End Get
        Set(value As String)
            _account_security_question = value
        End Set
    End Property

    Public Property Account_answer As String
        Get
            Return _account_answer
        End Get
        Set(value As String)
            _account_answer = value
        End Set
    End Property

    Public Property Employee_idemloyee As Integer
        Get
            Return _employee_idemloyee
        End Get
        Set(value As Integer)
            _employee_idemloyee = value
        End Set
    End Property

    Public Property Person_idperson1 As Integer
        Get
            Return _person_idperson
        End Get
        Set(value As Integer)
            _person_idperson = value
        End Set
    End Property

    Public Property Account_position As String
        Get
            Return _account_position
        End Get
        Set(value As String)
            _account_position = value
        End Set
    End Property

    Public Property Account_isLogin As String
        Get
            Return _account_isLogin
        End Get
        Set(value As String)
            _account_isLogin = value
        End Set
    End Property

    Sub New()

    End Sub

    Public Sub LoadEmployeeAtAccount(dgv As DataGridView)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM employee inner join person on person.idperson = employee.person_idperson;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idemployee"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("employee_status"), Convert.ToDateTime(MySqlDR("employee_date_reg")).ToString("yyyy-MM-dd"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetEmployeeDetatils(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM person inner join employee on person.idperson = employee.person_idperson WHERE idemployee= '" & MySqlHelper.EscapeString(id) & "';"

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

                IdEmployee = MySqlDR("idemployee")
                Employee_position = MySqlDR("employee_position")
                Employee_type = MySqlDR("employee_type")
                Employee_status = MySqlDR("employee_status")

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAccountMain(dgv As DataGridView, Optional txt As String = "")
        Try

            Dim sql As String = ""
            If txt = "All" Then
                sql = "SELECT * FROM account inner join employee on account.employee_idemployee = employee.idemployee inner join person on employee.person_idperson = person.idperson;"

            Else
                sql = "SELECT * FROM account inner join employee on account.employee_idemployee = employee.idemployee inner join person on employee.person_idperson = person.idperson WHERE account_status = '" & MySqlHelper.EscapeString(txt) & "';"

            End If

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idaccount"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("account_username"), MySqlDR("account_password"), MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("account_security_question"), MySqlDR("account_answer"), MySqlDR("account_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchAccountMain(dgv As DataGridView, txt As String, Optional txt1 As String = "")
        Try

            Dim sql As String = ""
            If txt1 = "All" Then
                sql = "SELECT * FROM account inner join employee on account.employee_idemployee = employee.idemployee inner join person on employee.person_idperson = person.idperson WHERE person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "OR person_middle_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' OR person_last_name LIKE '%" & MySqlHelper.EscapeString(txt) & "%' " _
              & "Or person_extension_name Like '%" & MySqlHelper.EscapeString(txt) & "%' OR " _
              & "(CONCAT(person_first_name,' ',person_middle_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_first_name,' ',person_last_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "') OR " _
              & "(CONCAT(person_last_name,' ',person_first_name,' ',person_middle_name,' ',person_extension_name) LIKE '%" & MySqlHelper.EscapeString(txt) & "');"

            Else
                sql = "Select * FROM account inner join employee On account.employee_idemployee = employee.idemployee inner join person On employee.person_idperson = person.idperson WHERE (account_status = '" & MySqlHelper.EscapeString(txt1) & "') " _
                & "AND (person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
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
                dgv.Rows.Add(MySqlDR("idaccount"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")), MySqlDR("account_username"), MySqlDR("account_password"), MySqlDR("employee_type"), MySqlDR("employee_position"), MySqlDR("account_security_question"), MySqlDR("account_answer"), MySqlDR("employee_status"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchAccount(dgv As DataGridView, txt As String)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM account inner join employee on account.employee_idemployee = employee.idemployee inner join person on employee.person_idperson = person.idperson WHERE person_first_name Like '%" & MySqlHelper.EscapeString(txt) & "%' " _
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
                dgv.Rows.Add(MySqlDR("idaccount"), String.Format("{0} {1} {2} {3}", MySqlDR("person_first_name"), MySqlDR("person_middle_name"), MySqlDR("person_last_name"), MySqlDR("person_extension_name")))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function AddAccount(str As String) As Boolean
        Try


            Dim sql As String = "INSERT INTO account(account_username,account_password,account_type,account_security_question,account_answer,employee_idemployee,account_position,account_status,account_isLogin)" _
                                & " VALUES(@0,@1,@2,@3,@4,@5,@6,'" & MySqlHelper.EscapeString("Active") & "','" & MySqlHelper.EscapeString("False") & "');"
            'sql += "INSERT INTO employee_history (employee_history_description,employee_history_date,employee_idemployee) VALUES (@4,CURRENT_DATE,(SELECT MAX(idemployee) FROM employee))"
            ConnectToServer()
            MsgBox(str)
            ServerExecuteSQL(sql, Account_username, Account_password, Account_type, Account_security_question, Account_answer,
                             str, Account_position)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateAccount() As Boolean
        Try
            Dim sql As String = "UPDATE account SET account_status=@0 WHERE idaccount=@1;"
            'sql += "INSERT INTO employee_history (employee_history_description,employee_history_date,employee_idemployee) VALUES (@4,CURRENT_DATE,(SELECT MAX(idemployee) FROM employee))"
            ConnectToServer()
            ServerExecuteSQL(sql, Account_status, Idaccount)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function UpdateAccountDetails() As Boolean
        Try
            Dim sql As String = "UPDATE account SET account_security_question=@0,account_answer=@1,account_position=@2 WHERE idaccount=@3;"
            'sql += "INSERT INTO employee_history (employee_history_description,employee_history_date,employee_idemployee) VALUES (@4,CURRENT_DATE,(SELECT MAX(idemployee) FROM employee))"
            ConnectToServer()
            ServerExecuteSQL(sql, Account_security_question, Account_answer, Account_position, Idaccount)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub GetAccountDetatils(id As Integer)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM person inner join employee on person.idperson = employee.person_idperson inner join account on employee.idemployee = account.employee_idemployee WHERE idaccount= '" & MySqlHelper.EscapeString(id) & "';"

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

                IdEmployee = MySqlDR("idemployee")
                Employee_position = MySqlDR("employee_position")
                Employee_type = MySqlDR("employee_type")
                Employee_status = MySqlDR("employee_status")

                Idaccount = MySqlDR("idaccount")
                Account_username = MySqlDR("account_username")
                Account_password = MySqlDR("account_password")
                Account_security_question = MySqlDR("account_security_question")
                Account_answer = MySqlDR("account_answer")
                Account_type = MySqlDR("account_type")
                'Account_position = MySqlDR("account_position")

            End While

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function isExist(strUsername As String) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = "SELECT idaccount FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to ctch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idaccount")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function isRemove(strUsername As String) As Boolean
        Dim ds As New DataSet
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT account_remove_status FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            Dim oj As Object = ds.Tables(0).Rows(0)("account_remove_status")
            If oj = "TRUE" Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As Exception
            bool = False
            Return bool
        End Try
        Return bool
    End Function

    Public Function isActive(strUsername As String) As Boolean
        Dim ds As New DataSet
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT account_status FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            Dim oj As Object = ds.Tables(0).Rows(0)("account_status")
            If oj = "Active" Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As Exception
            bool = False
            Return bool
        End Try
        Return bool
    End Function

    Public Function isAdmin(strUsername As String, strPassword As String) As Boolean
        Dim ds As New DataSet
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT account_type FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "' AND account_password = '" & MySqlHelper.EscapeString(strPassword) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            Dim oj As Object = ds.Tables(0).Rows(0)("account_type")
            If oj = "Admin" Or oj = "Super Admin" Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As Exception
            bool = False
            Return bool
        End Try
        Return bool
    End Function

    Public Function isMatched(strUsername As String, strPassword As String) As Boolean
        Dim ds As New DataSet
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT idaccount FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "' AND BINARY account_password = '" & MySqlHelper.EscapeString(strPassword) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            Dim oj As Object = ds.Tables(0).Rows(0)("idaccount")
            If oj <> 0 Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As Exception
            bool = False
            Return bool
            'MsgBox(ex.Message)
        End Try
        Return bool
    End Function

    Public Function isLogin(strUsername As String, strPassword As String) As Boolean
        Dim ds As New DataSet
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT account_isLogin FROM account WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "' AND account_password = '" & MySqlHelper.EscapeString(strPassword) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            Dim oj As Object = ds.Tables(0).Rows(0)("account_isLogin")
            If oj = "True" Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As Exception
            bool = False
            Return bool
        End Try
        Return bool
    End Function

    Public Sub getAccountDetails(strUsername As String, strPassword As String)
        Try
            ConnectToServer()
            Dim sql As String = ""
            sql = "SELECT * FROM person INNER JOIN employee on person.idperson = employee.person_idperson INNER JOIN account ON employee.idemployee = account.employee_idemployee " _
                    & "WHERE account_username = '" & MySqlHelper.EscapeString(strUsername) & "' AND account_password = '" & MySqlHelper.EscapeString(strPassword) & "';"

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader

            While MySqlDR.Read
                Idaccount = MySqlDR("idaccount")
                Account_type = MySqlDR("account_type")
                Account_username = MySqlDR("account_username")
                Account_password = MySqlDR("account_password")
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

    Public Function UpdateAccountFlag() As Boolean
        Try
            Dim sql As String = "UPDATE account SET account_isLogin=@0 WHERE idaccount = @1;"

            'NO ACTIVITY LOGS
            ConnectToServer()
            ServerExecuteSQL(sql, Account_isLogin, Idaccount)
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
End Class
