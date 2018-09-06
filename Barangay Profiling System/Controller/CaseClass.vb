Imports MySql.Data.MySqlClient
Public Class CaseClass
    Inherits PersonClass

    Private _idcase As Integer = 0
    Private _complainant_idcomplainant As Integer = 0
    Private _respondent_idrespondent As Integer = 0
    Private _case_code As String = ""
    Private _case_type As String = ""
    Private _case_desc As String = ""
    Private _case_date_received As Date
    Private _case_remarks As String = ""
    Private _case_has_hearing_witness As String = ""
    Private _case_report As String = ""


    Private _idhearing As Integer = 0
    Private _hearing_code As String = ""
    Private _hearing_no As String = ""
    Private _hearing_date As Date


    Private _idcomplainant As Integer = 0
    Private _complainant_code As String = ""
    Private _person_idperson As Integer = 0
    Private _person_has_business_est_person_idperson As Integer = 0
    Private _person_has_business_est_business_est_idbusiness_est As Integer = 0


    Private _idrespondent As Integer = 0
    Private _respondent_code As String = ""

    Private _idcase_has_hearing As Integer = 0
    Private _case_idcase As Integer = 0
    Private _case_complainant_idcomplainant As Integer = 0
    Private _case_respondent_idrespondent As Integer = 0
    Private _hearing_idhearing As Integer = 0
    Private _case_has_hearing_remarks As String = ""
    Private _case_has_hearing_status As String = ""

    Private _ds As New DataSet
    Private _ds1 As New DataSet
    Private _ds2 As New DataSet
    Private _ds3 As New DataSet


    Public Property Idcase As Integer
        Get
            Return _idcase
        End Get
        Set(value As Integer)
            _idcase = value
        End Set
    End Property

    Public Property Complainant_idcomplainant As Integer
        Get
            Return _complainant_idcomplainant
        End Get
        Set(value As Integer)
            _complainant_idcomplainant = value
        End Set
    End Property

    Public Property Respondent_idrespondent As Integer
        Get
            Return _respondent_idrespondent
        End Get
        Set(value As Integer)
            _respondent_idrespondent = value
        End Set
    End Property

    Public Property Case_code As String
        Get
            Return _case_code
        End Get
        Set(value As String)
            _case_code = value
        End Set
    End Property

    Public Property Case_type As String
        Get
            Return _case_type
        End Get
        Set(value As String)
            _case_type = value
        End Set
    End Property

    Public Property Case_desc As String
        Get
            Return _case_desc
        End Get
        Set(value As String)
            _case_desc = value
        End Set
    End Property

    Public Property Case_date_received As Date
        Get
            Return _case_date_received
        End Get
        Set(value As Date)
            _case_date_received = value
        End Set
    End Property

    Public Property Case_remarks As String
        Get
            Return _case_remarks
        End Get
        Set(value As String)
            _case_remarks = value
        End Set
    End Property

    Public Property Idhearing As Integer
        Get
            Return _idhearing
        End Get
        Set(value As Integer)
            _idhearing = value
        End Set
    End Property

    Public Property Hearing_code As String
        Get
            Return _hearing_code
        End Get
        Set(value As String)
            _hearing_code = value
        End Set
    End Property

    Public Property Hearing_no As String
        Get
            Return _hearing_no
        End Get
        Set(value As String)
            _hearing_no = value
        End Set
    End Property

    Public Property Hearing_date As Date
        Get
            Return _hearing_date
        End Get
        Set(value As Date)
            _hearing_date = value
        End Set
    End Property

    Public Property Idcomplainant As Integer
        Get
            Return _idcomplainant
        End Get
        Set(value As Integer)
            _idcomplainant = value
        End Set
    End Property

    Public Property Complainant_code As String
        Get
            Return _complainant_code
        End Get
        Set(value As String)
            _complainant_code = value
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

    Public Property Person_has_business_est_person_idperson As Integer
        Get
            Return _person_has_business_est_person_idperson
        End Get
        Set(value As Integer)
            _person_has_business_est_person_idperson = value
        End Set
    End Property

    Public Property Person_has_business_est_business_est_idbusiness_est As Integer
        Get
            Return _person_has_business_est_business_est_idbusiness_est
        End Get
        Set(value As Integer)
            _person_has_business_est_business_est_idbusiness_est = value
        End Set
    End Property

    Public Property Idrespondent As Integer
        Get
            Return _idrespondent
        End Get
        Set(value As Integer)
            _idrespondent = value
        End Set
    End Property

    Public Property Respondent_code As String
        Get
            Return _respondent_code
        End Get
        Set(value As String)
            _respondent_code = value
        End Set
    End Property

    Public Property Idcase_has_hearing As Integer
        Get
            Return _idcase_has_hearing
        End Get
        Set(value As Integer)
            _idcase_has_hearing = value
        End Set
    End Property

    Public Property Case_idcase As Integer
        Get
            Return _case_idcase
        End Get
        Set(value As Integer)
            _case_idcase = value
        End Set
    End Property

    Public Property Case_complainant_idcomplainant As Integer
        Get
            Return _case_complainant_idcomplainant
        End Get
        Set(value As Integer)
            _case_complainant_idcomplainant = value
        End Set
    End Property

    Public Property Case_respondent_idrespondent As Integer
        Get
            Return _case_respondent_idrespondent
        End Get
        Set(value As Integer)
            _case_respondent_idrespondent = value
        End Set
    End Property

    Public Property Hearing_idhearing As Integer
        Get
            Return _hearing_idhearing
        End Get
        Set(value As Integer)
            _hearing_idhearing = value
        End Set
    End Property

    Public Property Case_has_hearing_remarks As String
        Get
            Return _case_has_hearing_remarks
        End Get
        Set(value As String)
            _case_has_hearing_remarks = value
        End Set
    End Property

    Public Property Case_has_hearing_status As String
        Get
            Return _case_has_hearing_status
        End Get
        Set(value As String)
            _case_has_hearing_status = value
        End Set
    End Property

    Public Property Case_has_hearing_witness As String
        Get
            Return _case_has_hearing_witness
        End Get
        Set(value As String)
            _case_has_hearing_witness = value
        End Set
    End Property

    Public Property Case_report As String
        Get
            Return _case_report
        End Get
        Set(value As String)
            _case_report = value
        End Set
    End Property

    Public Function AddCase(str As String, str2 As String) As Boolean
        Try
            Dim sql As String = ""
            'RESPONDENT COMPLAINANT
            sql += str
            sql += "INSERT INTO `case`(complainant_idcomplainant,respondent_idrespondent,case_code,case_type,case_desc,case_date_received," _
                & "case_remarks) VALUES(0,0,@0,@1,@2,CURRENT_DATE,@3);"
            'HEARING
            'CASE HAS HEARING
            sql += str2
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Case_code, Case_type, Case_desc, Case_remarks)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateHearingDetails() As Boolean
        Try
            Dim sql As String = ""
            sql = "UPDATE case_has_hearing SET case_has_hearing_status = @0,case_has_hearing_witness=@1,case_has_hearing_remarks=@2 WHERE " _
                & "case_has_hearing.hearing_idhearing=@3;"
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Case_has_hearing_status, Case_has_hearing_witness, Case_has_hearing_remarks, Hearing_idhearing)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateCaseToComplete() As Boolean
        Try
            Dim sql As String = ""
            sql = "UPDATE `case` SET case_remarks = @0,case_report=@1 WHERE idcase = @2;"
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Case_remarks, Case_report, Idcase)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateCaseToReOpen() As Boolean
        Try
            Dim sql As String = ""
            sql = "UPDATE `case` SET case_remarks = @0 WHERE idcase = @1;"
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Case_remarks, Idcase)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function UpdateHearingToComplete() As Boolean
        Try
            Dim sql As String = ""
            sql = "UPDATE case_has_hearing SET case_has_hearing_status = @0 WHERE hearing_idhearing = @1;"
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Case_has_hearing_status, Hearing_idhearing)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub GetHearingID(str As String)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM hearing WHERE hearing_code = '" & str & "'"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read
                Idhearing = MySqlDR("idhearing")
            End While
            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHearing(dgv As DataGridView, str1 As String, str2 As String)
        Try
            Dim sql As String = ""
            sql = "SELECT * FROM `case` INNER JOIN case_has_hearing ON `case`.idcase = case_has_hearing.case_idcase " _
             & "INNER JOIN hearing On case_has_hearing.hearing_idhearing = hearing.idhearing " _
            & "WHERE hearing.hearing_date >= '" & str1 & "' AND hearing.hearing_date <= '" & str2 & "' group by hearing_idhearing;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idhearing"), MySqlDR("hearing_code"), Convert.ToDateTime(MySqlDR("hearing_date")).ToString("yyyy-MM-dd"),
                             MySqlDR("case_has_hearing_status"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadCase(dgv As DataGridView)
        Try
            Dim sql As String = ""
            sql = "Select * FROM `Case` WHERE case_date_received <= CURRENT_DATE;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcase"), MySqlDR("case_code"), MySqlDR("case_type"),
                             MySqlDR("case_desc"), Convert.ToDateTime(MySqlDR("case_date_received")).ToString("yyyy-MM-dd"),
                             MySqlDR("case_remarks"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetComplainantDetails(id As Integer)
        Try

            ConnectToServer()
            _ds2.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "Select * FROM complainant WHERE idcomplainant = '" & id & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetRespondentDetails(id As Integer)
        Try

            ConnectToServer()
            _ds1.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "SELECT * FROM respondent WHERE idrespondent = '" & id & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetComplainantDetails1(id As Integer)
        Try

            ConnectToServer()
            _ds2.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "Select * FROM complainant WHERE idcomplainant = '" & id & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetRespondentDetails1(id As Integer)
        Try

            ConnectToServer()
            _ds1.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "SELECT * FROM respondent WHERE idrespondent = '" & id & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Overloads Sub GetPersonDetails(id As Integer)
        Try

            ConnectToServer()
            _ds3.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "SELECT * FROM person WHERE idperson = '" & id & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds3)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetCaseDetails(str As String, dgv As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView)
        Try

            ConnectToServer()
            dgv.Rows.Clear()
            dgv2.Rows.Clear()
            dgv3.Rows.Clear()
            _ds.Clear()
            _ds1.Clear()
            _ds2.Clear()
            _ds3.Clear()
            GetCaseInfo(str)
            Dim array_int(100) As Integer
            Dim array_int1(100) As Integer
            Dim array_int2(100) As Integer
            Dim i As Integer = 0
            For Each row As DataRow In _ds.Tables(0).Rows

                Idcase = row("idcase")
                Case_code = row("case_code")
                Case_type = row("case_type")
                Case_desc = row("case_desc")
                Case_date_received = row("case_date_received")
                Case_remarks = row("case_remarks")
                If i = 0 Then
                    array_int2(i) = row("idhearing")
                    dgv.Rows.Add(row("hearing_code"), Convert.ToDateTime(row("hearing_date")).ToString("yyyy-MM-dd"),
                                     row("case_has_hearing_status"))

                Else
                    If array_int2.Contains(row("idhearing")) Then
                    Else
                        array_int2(i) = row("idhearing")
                        dgv.Rows.Add(row("hearing_code"), Convert.ToDateTime(row("hearing_date")).ToString("yyyy-MM-dd"),
                                     row("case_has_hearing_status"))
                    End If
                End If

                If i = 0 Then
                    array_int(i) = row("case_complainant_idcomplainant")
                    GetComplainantDetails(row("case_complainant_idcomplainant"))
                    For Each row2 As DataRow In _ds2.Tables(0).Rows
                        Person_idperson = row2("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson)
                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        dgv2.Rows.Add(row("case_complainant_idcomplainant"), row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                             row3("person_extension_name"),
                             String.Format("{0} {1} {2} {3}", row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                             row3("person_extension_name")), row3("person_gender"), "",
                                 row3("person_status"))
                    Next

                Else
                    If array_int.Contains(row("case_complainant_idcomplainant")) Then
                    Else
                        array_int(i) = row("case_complainant_idcomplainant")
                        GetComplainantDetails(row("case_complainant_idcomplainant"))
                        For Each row2 As DataRow In _ds2.Tables(0).Rows
                            Person_idperson = row2("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            dgv2.Rows.Add(row("case_complainant_idcomplainant"), row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                             row3("person_extension_name"),
                             String.Format("{0} {1} {2} {3}", row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                             row3("person_extension_name")), row3("person_gender"), "",
                                 row3("person_status"))
                        Next

                    End If
                End If



                If i = 0 Then
                    array_int1(i) = row("case_respondent_idrespondent")
                    GetRespondentDetails(row("case_respondent_idrespondent"))
                    For Each row4 As DataRow In _ds1.Tables(0).Rows
                        Person_idperson1 = row4("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson1)

                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        dgv3.Rows.Add(row("case_respondent_idrespondent"), row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                                 row3("person_extension_name"),
                                 String.Format("{0} {1} {2} {3}", row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                                 row3("person_extension_name")), row3("person_gender"), "",
                                     row3("person_status"))
                    Next
                Else
                    If array_int1.Contains(row("case_respondent_idrespondent")) Then
                    Else
                        array_int1(i) = row("case_respondent_idrespondent")
                        GetRespondentDetails(row("case_respondent_idrespondent"))
                        For Each row4 As DataRow In _ds1.Tables(0).Rows
                            Person_idperson1 = row4("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson1)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            dgv3.Rows.Add(row("case_respondent_idrespondent"), row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                                     row3("person_extension_name"),
                                     String.Format("{0} {1} {2} {3}", row3("person_last_name"), row3("person_first_name"), row3("person_middle_name"),
                                     row3("person_extension_name")), row3("person_gender"), "",
                                         row3("person_status"))
                        Next
                    End If
                End If
                i = i + 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadCaseDetails(dgv As DataGridView)
        Try

            ConnectToServer()
            dgv.Rows.Clear()
            _ds.Clear()
            _ds1.Clear()
            _ds2.Clear()
            _ds3.Clear()
            GetCaseInfo1()
            Dim array_int(100) As Integer
            Dim array_int1(100) As Integer
            Dim array_int2(100) As Integer
            Dim array_strc(1000) As String
            Dim array_strr(1000) As String
            Dim i As Integer = 0
            For Each row As DataRow In _ds.Tables(0).Rows

                Idcase = row("idcase")
                Case_code = row("case_code")
                Case_type = row("case_type")
                Case_desc = row("case_desc")
                Case_date_received = row("case_date_received")
                Case_remarks = row("case_remarks")


                If i = 0 Then
                    array_int(i) = row("case_complainant_idcomplainant")
                    GetComplainantDetails1(row("case_complainant_idcomplainant"))
                    For Each row2 As DataRow In _ds2.Tables(0).Rows
                        Person_idperson = row2("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson)
                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        array_strc(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                    Next

                Else
                    If array_int.Contains(row("case_complainant_idcomplainant")) Then
                    Else
                        array_int(i) = row("case_complainant_idcomplainant")
                        GetComplainantDetails1(row("case_complainant_idcomplainant"))
                        For Each row2 As DataRow In _ds2.Tables(0).Rows
                            Person_idperson = row2("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            array_strc(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                        Next

                    End If
                End If



                If i = 0 Then
                    array_int1(i) = row("case_respondent_idrespondent")
                    GetRespondentDetails1(row("case_respondent_idrespondent"))
                    For Each row4 As DataRow In _ds1.Tables(0).Rows
                        Person_idperson1 = row4("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson1)

                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        array_strr(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                    Next
                Else
                    If array_int1.Contains(row("case_respondent_idrespondent")) Then
                    Else
                        array_int1(i) = row("case_respondent_idrespondent")
                        GetRespondentDetails1(row("case_respondent_idrespondent"))
                        For Each row4 As DataRow In _ds1.Tables(0).Rows
                            Person_idperson1 = row4("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson1)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            array_strr(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                        Next
                    End If
                End If
                If i = 0 Then
                    array_int2(i) = row("idcase")
                    dgv.Rows.Add(row("idcase"), row("case_code"), row("case_type"),
                           row("case_desc"), Convert.ToDateTime(row("case_date_received")).ToString("yyyy-MM-dd"),
                           row("case_remarks"), String.Join(",", array_strc(i)), String.Join(",", array_strr(i)))

                Else
                    If array_int2.Contains(row("idcase")) Then
                        'clear array
                        Array.Clear(array_int1, 0, array_int1.Length)
                        Array.Clear(array_int, 0, array_int.Length)
                        Array.Clear(array_strc, 0, array_strc.Length)
                        Array.Clear(array_strr, 0, array_strr.Length)
                    Else
                        array_int2(i) = row("idcase")
                        dgv.Rows.Add(row("idcase"), row("case_code"), row("case_type"),
                           row("case_desc"), Convert.ToDateTime(row("case_date_received")).ToString("yyyy-MM-dd"),
                           row("case_remarks"), String.Join(",", array_strc(i)), String.Join(",", array_strr(i)))

                    End If
                End If
                i = i + 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchCaseDetails(dgv As DataGridView, str As String)
        Try

            ConnectToServer()
            dgv.Rows.Clear()
            _ds.Clear()
            _ds1.Clear()
            _ds2.Clear()
            _ds3.Clear()
            GetCaseInfo2(str)
            Dim array_int(100) As Integer
            Dim array_int1(100) As Integer
            Dim array_int2(100) As Integer
            Dim array_strc(1000) As String
            Dim array_strr(1000) As String
            Dim i As Integer = 0
            For Each row As DataRow In _ds.Tables(0).Rows

                Idcase = row("idcase")
                Case_code = row("case_code")
                Case_type = row("case_type")
                Case_desc = row("case_desc")
                Case_date_received = row("case_date_received")
                Case_remarks = row("case_remarks")


                If i = 0 Then
                    array_int(i) = row("case_complainant_idcomplainant")
                    GetComplainantDetails1(row("case_complainant_idcomplainant"))
                    For Each row2 As DataRow In _ds2.Tables(0).Rows
                        Person_idperson = row2("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson)
                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        array_strc(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                    Next

                Else
                    If array_int.Contains(row("case_complainant_idcomplainant")) Then
                    Else
                        array_int(i) = row("case_complainant_idcomplainant")
                        GetComplainantDetails1(row("case_complainant_idcomplainant"))
                        For Each row2 As DataRow In _ds2.Tables(0).Rows
                            Person_idperson = row2("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            array_strc(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                        Next

                    End If
                End If



                If i = 0 Then
                    array_int1(i) = row("case_respondent_idrespondent")
                    GetRespondentDetails1(row("case_respondent_idrespondent"))
                    For Each row4 As DataRow In _ds1.Tables(0).Rows
                        Person_idperson1 = row4("person_idperson")
                    Next
                    GetPersonDetails(Person_idperson1)

                    For Each row3 As DataRow In _ds3.Tables(0).Rows
                        array_strr(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                    Next
                Else
                    If array_int1.Contains(row("case_respondent_idrespondent")) Then
                    Else
                        array_int1(i) = row("case_respondent_idrespondent")
                        GetRespondentDetails1(row("case_respondent_idrespondent"))
                        For Each row4 As DataRow In _ds1.Tables(0).Rows
                            Person_idperson1 = row4("person_idperson")
                        Next
                        GetPersonDetails(Person_idperson1)
                        For Each row3 As DataRow In _ds3.Tables(0).Rows
                            array_strr(i) = String.Format("{0} {1} {2} {3}", row3("person_first_name"), row3("person_middle_name"), row3("person_last_name"), row3("person_extension_name"))
                        Next
                    End If
                End If
                If i = 0 Then
                    array_int2(i) = row("idcase")
                    dgv.Rows.Add(row("idcase"), row("case_code"), row("case_type"),
                           row("case_desc"), Convert.ToDateTime(row("case_date_received")).ToString("yyyy-MM-dd"),
                           row("case_remarks"), String.Join(",", array_strc(i)), String.Join(",", array_strr(i)))

                Else
                    If array_int2.Contains(row("idcase")) Then
                        'clear array
                        Array.Clear(array_int1, 0, array_int1.Length)
                        Array.Clear(array_int, 0, array_int.Length)
                        Array.Clear(array_strc, 0, array_strc.Length)
                        Array.Clear(array_strr, 0, array_strr.Length)
                    Else
                        array_int2(i) = row("idcase")
                        dgv.Rows.Add(row("idcase"), row("case_code"), row("case_type"),
                           row("case_desc"), Convert.ToDateTime(row("case_date_received")).ToString("yyyy-MM-dd"),
                           row("case_remarks"), String.Join(",", array_strc(i)), String.Join(",", array_strr(i)))

                    End If
                End If
                i = i + 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GetComplaintRespondent(str As String)
        Try
            ConnectToServer()
            _ds.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "select DISTINCT case_complainant_idcomplainant,case_respondent_idrespondent from case_has_hearing where case_idcase = '" & str & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub GetCaseInfo(str As String)
        Try
            ConnectToServer()
            _ds.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "select * from `case` inner join case_has_hearing on `case`.idcase = case_has_hearing.case_idcase " _
               & "inner join hearing On case_has_hearing.hearing_idhearing = hearing.idhearing " _
               & "WHERE `case`.case_date_received <= CURRENT_DATE And `case`.idcase =  '" & MySqlHelper.EscapeString(str) & "';"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub


    Public Sub GetCaseInfo1()
        Try
            ConnectToServer()
            _ds.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "select * from `case` inner join case_has_hearing on `case`.idcase = case_has_hearing.case_idcase " _
               & "inner join hearing On case_has_hearing.hearing_idhearing = hearing.idhearing " _
               & "WHERE `case`.case_date_received <= CURRENT_DATE;"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub GetCaseInfo2(str As String)
        Try
            ConnectToServer()
            _ds.Clear()

            Dim da As New MySqlDataAdapter
            Dim sql As String = ""
            sql = "select * from `case` inner join case_has_hearing on `case`.idcase = case_has_hearing.case_idcase " _
               & "inner join hearing On case_has_hearing.hearing_idhearing = hearing.idhearing " _
               & "WHERE `case`.case_date_received <= CURRENT_DATE AND (`case`.case_code LIKE '%" & str & "%' " _
               & "OR `case`.case_type LIKE '%" & str & "%');"
            da = New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(_ds)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function isHaveCase(str As String) As Boolean
        Dim ds As New DataSet
        Try
            Dim sql As String = ""
            sql = "select * from `case` inner join case_has_hearing on `case`.idcase = case_has_hearing.case_idcase " _
            & "inner join hearing on case_has_hearing.hearing_idhearing = hearing.idhearing WHERE `case`.case_remarks = 'Active' and " _
            & "(case_has_hearing.case_has_hearing_status = 'Incoming'  OR case_has_hearing.case_has_hearing_status = 'Pending') AND " _
            & "case_has_hearing.case_respondent_idrespondent = " _
            & "(SELECT idrespondent FROM respondent WHERE person_idperson = '" & str & "' LIMIT 1);"

            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            Dim oj As Object = ds.Tables(0).Rows(0)("idcase")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try

        Return True
    End Function

    Public Function AddMoreHearing() As Boolean
        Try
            Dim sql As String = ""
            'RESPONDENT COMPLAINANT
            sql = "INSERT INTO hearing(hearing_code,hearing_date) VALUES(@0,@1);"
            sql += "INSERT INTO case_has_hearing(case_idcase,case_complainant_idcomplainant,case_respondent_idrespondent," _
                & "hearing_idhearing,case_has_hearing_remarks,case_has_hearing_status) " _
                & "VALUES(@2,@3,@4,(SELECT MAX(idhearing) FROM hearing),@5,@6);"
            'HEARING
            'CASE HAS HEARING
            'sql += "INSERT INTO activity_logs(activity_logs_myact_name,activity_logs_act_name,activity_logs_date,account_idaccount) " _
            '    & "VALUES('" & MySqlHelper.EscapeString("You have saved new tribe: " + Tribe_name) & "'," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_name + " have saved new tribe: " + Tribe_name) & "',CURRENT_TIMESTAMP," _
            '    & "'" & MySqlHelper.EscapeString(frm_login._user_id) & "');"
            ConnectToServer()
            ServerExecuteSQL(sql, Hearing_code, Hearing_date, Case_idcase, Case_complainant_idcomplainant, Case_respondent_idrespondent,
                              Case_has_hearing_remarks, Case_has_hearing_status)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub LoadCaseHistory(dgv As DataGridView, str As String)
        Try
            Dim sql As String = ""
            sql = "select * from person inner join respondent on person.idperson = respondent.person_idperson " _
                    & "inner join case_has_hearing on respondent.idrespondent = case_has_hearing.case_respondent_idrespondent " _
                    & "INNER JOIN `case` on case_has_hearing.case_idcase = `case`.idcase where person.idperson = '" & str & "' " _
                    & "and `case`.case_date_received <= current_date() group by `case`.idcase;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcase"), MySqlDR("case_code"), MySqlDR("case_type"), MySqlDR("case_desc"),
                             Convert.ToDateTime(MySqlDR("case_date_received")).ToString("yyyy-MM-dd"),
                             MySqlDR("case_remarks"), MySqlDR("case_report"))

            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadHearingDetails(str As String)
        Try
            Dim sql As String = ""
            sql = "select * from case_has_hearing where case_has_hearing.case_idcase = (select idcase from `case` where case_code = '" & str & "' limit 1) " _
                    & "group by hearing_idhearing;"

            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader


            While MySqlDR.Read
                Case_has_hearing_remarks = MySqlDR("case_has_hearing_remarks")
                Case_has_hearing_witness = MySqlDR("case_has_hearing_witness")
            End While



            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
