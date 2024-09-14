Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim UserType As String

    Dim dtable As New DataTable
    Dim da As MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click



        openCon()
        da = New MySqlDataAdapter("Select Username,Password,Type FROM loginform where username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "' AND Type ='" & UserType & "'", con)
        dtable.Clear()
        da.Fill(dtable)


        If dtable.Rows.Count = Nothing Then

            MsgBox("Please enter the following details.", MsgBoxStyle.Critical)

        ElseIf UserType = "Admin" Then
            AdminForm.Show()
            CurrentUser = Me.txtUsername.Text
            AdminForm.WelcomeCurrentUser.Text = "Welcome " + CurrentUser

        ElseIf UserType = "User" Then
            UserForm.Show()
            CurrentUser = Me.txtUsername.Text
            UserForm.WelcomeUser.Text = "Welcome" + CurrentUser

        Else
            MsgBox("Please enter the correct username or password.", MsgBoxStyle.Critical)


        End If

        con.Close()


    End Sub

    Private Sub rAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rAdmin.CheckedChanged

        UserType = "Admin"

    End Sub

    Private Sub rUser_CheckedChanged(sender As Object, e As EventArgs) Handles rUser.CheckedChanged

        UserType = "User"

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
