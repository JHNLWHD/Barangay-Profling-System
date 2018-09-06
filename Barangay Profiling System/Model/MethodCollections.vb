Imports MySql.Data.MySqlClient
Module MethodCollections

    Public Function GetCurrentAge(DOB As Date, serverDate As Date) As Integer
        Try
            Dim age As Integer = 0
            age = serverDate.Year - DOB.Year
            If (DOB > serverDate.AddYears(-age)) Then age -= 1
            Return age
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function getDate() As String

        Dim _date As String
        Try
            ConnectToServer()
            Dim cmd As New MySqlCommand()
            Dim sql As String = "select date_format(current_date(),'%M %d, %Y')"
            cmd = New MySqlCommand(sql, getServerConnection())
            _date = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

        Return _date

    End Function

    Public Function getYear() As String

        Dim _date As String
        Try
            ConnectToServer()
            Dim cmd As New MySqlCommand
            Dim sql As String = "select date_format(current_date(),'%Y')"
            cmd = New MySqlCommand(sql, getServerConnection())
            _date = cmd.ExecuteScalar
        Catch ex As Exception
            Return Nothing
        End Try

        Return _date

    End Function

    Public Function getTime() As String

        Dim _date As String
        Try
            ConnectToServer()
            Dim cmd As New MySqlCommand
            Dim sql As String = "select date_format(current_time(),'%r')"
            cmd = New MySqlCommand(sql, getServerConnection())
            _date = cmd.ExecuteScalar
        Catch ex As Exception
            Return Nothing
        End Try

        Return _date

    End Function

    Public Sub keyAllow(str1 As String, txt As TextBox)
        Dim text As String = txt.Text
        Dim key As String
        Dim selectionIndex As Integer = txt.SelectionStart
        Dim change As Integer
        Dim selectionLength As Integer
        selectionLength = txt.SelectionLength

        For x As Integer = 0 To txt.TextLength - 1
            key = txt.Text.Substring(x, 1)
            If str1.Contains(key) = False Then
                text = text.Replace(key, String.Empty)
                change = 1
            End If

        Next
        txt.Text = text
        txt.SelectionStart = selectionIndex
        txt.SelectionLength = selectionIndex
    End Sub


    Public Sub ClearAll(root As Control)

        For Each ctrl As Control In root.Controls

            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = Nothing
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
                ' CType(ctrl, ComboBox).Items.Clear()
            End If

            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Rows.Clear()
                CType(ctrl, DataGridView).ClearSelection()
            End If
        Next ctrl

    End Sub

    Public Function RequiredField(ParamArray obj() As Object) As Boolean
        Try
            Dim i As Integer
            For i = 0 To obj.Length - 1
                If String.IsNullOrWhiteSpace(obj(i)) = True Then
                    Return False
                End If
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function generateRandom() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("QWERTYUIOPLKJHGFDSAZXCVBNM").ToCharArray
            For i As Integer = 0 To 7
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Function generateRandomPersonCode() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("QWERTYUIOPLKJHGFDSAZXCVBNM").ToCharArray
            For i As Integer = 0 To 5
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Function generateRandomNumber() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("0987654321QWERTYUIOPLKJHGFDSAZXCVBNM").ToCharArray
            For i As Integer = 0 To 5
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Function generateUsername() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("QWERTYUIOPLKJHGFDSAZXCVBNM").ToCharArray
            For i As Integer = 0 To 7
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Function generatePassword() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("QWERTYUIOPLKJHGFDSAZXCVBNM1234567890").ToCharArray
            For i As Integer = 0 To 12
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Function getIDPurok(cbo As String) As Object
        Dim ds As New DataSet
        Dim oj As Object
        Try
            MsgBox(cbo)
            Dim sql As String = "SELECT idpurok FROM purok WHERE purok_name = '" & MySqlHelper.EscapeString(cbo) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            oj = ds.Tables(0).Rows(0)("idpurok")
        Catch ex As Exception
            Return Nothing
            Exit Function
        End Try
        Return oj
    End Function

    Public Function getIDDrive(cbo As String) As Object
        Dim ds As New DataSet
        Dim oj As Object
        Try
            Dim sql As String = "SELECT iddrive FROM drive WHERE drive_name = '" & MySqlHelper.EscapeString(cbo) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            oj = ds.Tables(0).Rows(0)("iddrive")
        Catch ex As Exception
            Return Nothing
            Exit Function
        End Try
        Return oj
    End Function
    Public Function getIDStreet(cbo As String) As Object
        Dim ds As New DataSet
        Dim oj As Object
        Try
            Dim sql As String = "SELECT idstreet FROM street WHERE street_name = '" & MySqlHelper.EscapeString(cbo) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            oj = ds.Tables(0).Rows(0)("idstreet")
        Catch ex As Exception
            Return Nothing
            Exit Function
        End Try
        Return oj
    End Function
    Public Function getIDRoad(cbo As String) As Object
        Dim ds As New DataSet
        Dim oj As Object
        Try
            Dim sql As String = "SELECT idroad FROM road WHERE road_name = '" & MySqlHelper.EscapeString(cbo) & "';"
            ConnectToServer()
            Dim da As New MySqlDataAdapter(sql, getServerConnection)
            da.Fill(ds, sql)
            'check if it exist then go to catch if none
            oj = ds.Tables(0).Rows(0)("idroad")
        Catch ex As Exception
            Return Nothing
            Exit Function
        End Try
        Return oj
    End Function

    Public Function generateRandomHouseHold() As String
        Dim str As String = ""
        Try
            Dim rdm As New Random()
            Dim chr As Char() = ("0987654321QWERTYUIOPLKJHGFDSAZXCVBNM").ToCharArray
            For i As Integer = 0 To 6
                str += chr(rdm.Next(0, chr.Length))
            Next
        Catch ex As Exception

        End Try

        Return str
    End Function

    Public Sub LoadReligionToCbo(cbo As ComboBox)
        Try
            ConnectToServer()
            Dim sql As String = ""
            sql = "SELECT * FROM religion WHERE religion_status = '" & MySqlHelper.EscapeString("Active") & "' " _
                & "AND religion_remove_status = '" & MySqlHelper.EscapeString("False") & "';"

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            cbo.Items.Clear()
            While MySqlDR.Read
                Dim name As String = MySqlDR("religion_name")
                cbo.Items.Add(name)
            End While

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadTribeToCbo(cbo As ComboBox)
        Try
            ConnectToServer()
            Dim sql As String = ""
            sql = "SELECT * FROM tribe WHERE tribe_status = '" & MySqlHelper.EscapeString("Active") & "' " _
                & "AND tribe_remove_status = '" & MySqlHelper.EscapeString("False") & "';"

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            cbo.Items.Clear()
            While MySqlDR.Read
                Dim name As String = MySqlDR("tribe_name")
                cbo.Items.Add(name)
            End While

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadOccupationToCbo(cbo As ComboBox)
        Try
            ConnectToServer()
            Dim sql As String = ""
            sql = "SELECT * FROM occupation WHERE occupation_status = '" & MySqlHelper.EscapeString("Active") & "' " _
                & "AND occupation_remove_status = '" & MySqlHelper.EscapeString("False") & "';"

            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            cbo.Items.Clear()
            While MySqlDR.Read
                Dim name As String = MySqlDR("occupation_name")
                cbo.Items.Add(name)
            End While

            MySqlDR.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
End Module
