Imports MySql.Data.MySqlClient
Public Class frm_login

    Public Shared _user_id As Integer = 0
    Public Shared _user_name As String = ""
    Public Shared _user_type As String = ""
    Private AccountObj As AccountClass
    Private FiscalObj As FiscalYearClass
    Private Sub btn_login_MouseHover(sender As Object, e As EventArgs) Handles btn_login.MouseHover
        Dim TT As New ToolTip
        TT.SetToolTip(btn_login, "CLICK TO LOG IN THIS ACCOUNT")
    End Sub
    Private Sub btnShowPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShowPassword.MouseUp
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub btnsp_MouseHover(sender As Object, e As EventArgs) Handles btnShowPassword.MouseHover
        Dim TT As New ToolTip
        TT.SetToolTip(btnShowPassword, "CLICK TO SHOW PASSWORD")
    End Sub
    Private Sub btnShowPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnShowPassword.MouseDown
        txtPassword.PasswordChar = ""
    End Sub
    Private Sub frm_login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try

            AccountObj = New AccountClass
            FiscalObj = New FiscalYearClass
            With AccountObj
                If .isExist(txtUsername.Text) = True Then
                    If .isActive(txtUsername.Text) = True Then
                        If .isMatched(txtUsername.Text, txtPassword.Text) = True Then
                            If .isLogin(txtUsername.Text, txtPassword.Text) = False Then
                                If .isAdmin(txtUsername.Text, txtPassword.Text) = True Then
                                    .getAccountDetails(txtUsername.Text, txtPassword.Text)
                                    _user_id = .Idaccount
                                    _user_name = .Account_username
                                    _user_type = .Account_type
                                    .Account_isLogin = "True"
                                    .Idaccount = _user_id
                                    .UpdateAccountFlag()
                                    FiscalObj.GetActiveFiscalYear()
                                    frmHome.TSWelcome.Text = String.Format("Welcome: {0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)
                                    frmHome.Label7.Text = String.Format("Current Fiscal Year: {0}", FiscalObj.Fiscal_year_obj)
                                    'MetroMessageBox.Show(Me, String.Format("Welcome {0}", frmHome.lblName.Text), My.Application.Info.Title + " says: ", MessageBoxButtons.OK, MessageBoxIcon.Question, 250)
                                    frmHome.Show()
                                    Hide()

                                Else
                                    .getAccountDetails(txtUsername.Text, txtPassword.Text)
                                    _user_id = .Idaccount
                                    _user_name = .Account_username
                                    _user_type = .Account_type
                                    .Account_isLogin = "True"
                                    .Idaccount = _user_id
                                    .UpdateAccountFlag()
                                    FiscalObj.GetActiveFiscalYear()
                                    frmHome.SettingsToolStripMenuItem.Visible = False
                                    frmHome.AccountToolStripMenuItem.Visible = False
                                    frmHome.EmployeeToolStripMenuItem.Visible = False
                                    frmHome.TSWelcome.Text = String.Format("Welcome: {0} {1} {2} {3}", .Person_first_name, .Person_middle_name, .Person_last_name, .Person_extension_name)
                                    frmHome.Label7.Text = String.Format("Current Fiscal Year: {0}", FiscalObj.Fiscal_year_obj)
                                    frmHome.Show()
                                    Hide()
                                End If
                            Else
                                'MetroMessageBox.Show(Me, String.Format("This account is currently login in other pc."), My.Application.Info.Title + " says: ", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
                                MsgBox("This account is currently login in other pc.")
                            End If
                        Else
                            'MetroMessageBox.Show(Me, String.Format("Account details doesn't matched."), My.Application.Info.Title + " says:", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
                            MsgBox("Account details doesn't matched.")
                        End If
                    Else
                        'MetroMessageBox.Show(Me, String.Format("This account is not active anymore."), My.Application.Info.Title + " says:", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
                        MsgBox("This account is not active anymore")
                    End If
                Else
                    'MetroMessageBox.Show(Me, String.Format("This account doesn't exist."), My.Application.Info.Title + " says:", MessageBoxButtons.OK, MessageBoxIcon.Error, 250)
                    MsgBox("This account doesn't exist")

                End If
            End With
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_logincancel_Click(sender As Object, e As EventArgs) Handles btn_logincancel.Click
        Try
            Dispose()
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub
End Class