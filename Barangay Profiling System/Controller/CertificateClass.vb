Imports MySql.Data.MySqlClient
Public Class CertificateClass
    Inherits PersonClass

    Private _idcertificate As Integer = 0
    Private _certificate_type As String = ""
    Private _certificate_date As Date
    Private _certificate_purpose As String = ""
    Private _person_idperson As Integer = 0

    Public Property Idcertificate As Integer
        Get
            Return _idcertificate
        End Get
        Set(value As Integer)
            _idcertificate = value
        End Set
    End Property

    Public Property Certificate_type As String
        Get
            Return _certificate_type
        End Get
        Set(value As String)
            _certificate_type = value
        End Set
    End Property

    Public Property Certificate_date As Date
        Get
            Return _certificate_date
        End Get
        Set(value As Date)
            _certificate_date = value
        End Set
    End Property

    Public Property Certificate_purpose As String
        Get
            Return _certificate_purpose
        End Get
        Set(value As String)
            _certificate_purpose = value
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

    Public Function AddCertificate() As Boolean
        Try
            Dim sql As String = "INSERT INTO certificate(certificate_type,certificate_purpose,person_idperson,certificate_date) VALUES(@0,@1,@2,CURRENT_DATE);"
            ConnectToServer()
            ServerExecuteSQL(sql, Certificate_type, _certificate_purpose, Person_idperson, Certificate_date)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function




    Public Sub LoadCertificate(dgv As DataGridView)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM certificate inner join person on person.idperson = certificate.person_idperson WHERE person.idperson = '" & frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcertificate"), MySqlDR("certificate_type"), MySqlDR("certificate_purpose"), Convert.ToDateTime(MySqlDR("certificate_date")).ToString("yyyy-MM-dd"), MySqlDR("person_idperson"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadResidency(dgv As DataGridView)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM certificate inner join person on person.idperson = certificate.person_idperson WHERE person.idperson = '" & frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString & "' AND certificate_type = '" & MySqlHelper.EscapeString("Residency") & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcertificate"), MySqlDR("certificate_type"), MySqlDR("certificate_purpose"), Convert.ToDateTime(MySqlDR("certificate_date")).ToString("yyyy-MM-dd"), MySqlDR("person_idperson"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAppearance(dgv As DataGridView)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM certificate inner join person on person.idperson = certificate.person_idperson WHERE person.idperson = '" & frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString & "' AND certificate_type = '" & MySqlHelper.EscapeString("Appearance") & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcertificate"), MySqlDR("certificate_type"), MySqlDR("certificate_purpose"), Convert.ToDateTime(MySqlDR("certificate_date")).ToString("yyyy-MM-dd"), MySqlDR("person_idperson"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadClearance(dgv As DataGridView)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM certificate inner join person on person.idperson = certificate.person_idperson WHERE person.idperson = '" & frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString & "' AND certificate_type = '" & MySqlHelper.EscapeString("Clearance") & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcertificate"), MySqlDR("certificate_type"), MySqlDR("certificate_purpose"), Convert.ToDateTime(MySqlDR("certificate_date")).ToString("yyyy-MM-dd"), MySqlDR("person_idperson"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub LoadIndigency(dgv As DataGridView)
        Try

            Dim sql As String = ""

            sql = "SELECT * FROM certificate inner join person on person.idperson = certificate.person_idperson WHERE person.idperson = '" & frmResidentRecord.dgvBrowsePerson.SelectedRows(0).Cells(0).Value.ToString & "' AND certificate_type = '" & MySqlHelper.EscapeString("Indigency") & "';"



            ConnectToServer()
            Dim MySqlCmd As MySqlCommand = New MySqlCommand(sql, getServerConnection)
            Dim MySqlDR As MySqlDataReader = MySqlCmd.ExecuteReader
            dgv.Rows.Clear()

            While MySqlDR.Read
                dgv.Rows.Add(MySqlDR("idcertificate"), MySqlDR("certificate_type"), MySqlDR("certificate_purpose"), Convert.ToDateTime(MySqlDR("certificate_date")).ToString("yyyy-MM-dd"), MySqlDR("person_idperson"))
            End While

            dgv.ClearSelection()

            MySqlDR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
