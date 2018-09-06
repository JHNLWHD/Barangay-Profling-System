Imports MySql.Data.MySqlClient
Public Class frmAddAddress

    Private AddressObj As New AddressClass

    Public Function purok(cbo As String) As Object
        Return If(cbo <> vbNullString, getIDPurok(cbo), DBNull.Value)
    End Function

    Public Function road(cbo As String) As Object
        Return If(cbo <> vbNullString, getIDRoad(cbo), DBNull.Value)
    End Function

    Public Function street(cbo As String) As Object
        Return If(cbo <> vbNullString, getIDStreet(cbo), DBNull.Value)
    End Function

    Public Function drive(cbo As String) As Object
        Return If(cbo <> vbNullString, getIDDrive(cbo), DBNull.Value)
    End Function


    Public purokLambda As Func(Of String, Object) = Function(cbo) purok(cbo)

    Public roadLambda As Func(Of String, Object) = Function(cbo) road(cbo)

    Public streetLambda As Func(Of String, Object) = Function(cbo) street(cbo)

    Public driveLambda As Func(Of String, Object) = Function(cbo) drive(cbo)

    Private Sub addAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With AddressObj
                .LoadDrive(cboDrive)
                .LoadPurok(cboPurok)
                .LoadRoad(cboRoad)
                .LoadStreet(cboStreet)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            frmHouse.txtHouseAddress.Text = String.Format("{0} {1} {2} {3}", cboStreet.Text, cboPurok.Text, cboDrive.Text, cboRoad.Text)
            Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStreet_Click(sender As Object, e As EventArgs) Handles btnStreet.Click
        Try
            frmAddStreet.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDrive_Click(sender As Object, e As EventArgs) Handles btnDrive.Click
        Try
            frmAddDrive.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPurok_Click(sender As Object, e As EventArgs) Handles btnPurok.Click
        Try
            frmAddPurok.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRoad_Click(sender As Object, e As EventArgs) Handles btnRoad.Click
        Try
            frmAddRoad.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class