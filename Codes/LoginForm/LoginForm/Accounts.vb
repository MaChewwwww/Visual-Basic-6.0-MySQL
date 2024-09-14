Imports MySql.Data.MySqlClient

Public Class Accounts
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminForm.Show()
        Me.Close()
        AdminForm.WelcomeCurrentUser.Text = "Welcome " + CurrentUser
    End Sub

    Private Sub AccountGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountGridView.CellClick

        useridtxt.Text = AccountGridView.CurrentRow.Cells(0).Value.ToString
        usernameread.Text = AccountGridView.CurrentRow.Cells(1).Value.ToString
        passwordread.Text = AccountGridView.CurrentRow.Cells(2).Value.ToString
        accountread.Text = AccountGridView.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()
        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM loginform", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "loginform")
            AccountGridView.DataSource = ds.Tables("loginform")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click



        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from loginform WHERE Username='" & NewUser.Text & "' AND Password='" & NewPassword.Text & "' AND Type='" & cmbtype.SelectedItem & "'"
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                MsgBox("Duplicate Entry Found! this section already exist in the database.", MsgBoxStyle.Critical)
                con.Close()

            ElseIf NewUser.Text = Nothing Then
                MsgBox("Please enter a username.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewPassword.Text = Nothing Then
                MsgBox("Please enter a password.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf cmbtype.Text = Nothing Then
                MsgBox("Please select an Account Type.", MsgBoxStyle.Critical)
                con.Close()

            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO loginform (`Username`,`Password`,`Type`) VALUES ('" & NewUser.Text & "','" & NewPassword.Text & "','" & cmbtype.SelectedItem & "')"
                cmd.ExecuteNonQuery()
                MsgBox("New account has been successfully registered!.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM loginform", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "loginform")
            AccountGridView.DataSource = ds.Tables("loginform")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try







    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from loginform WHERE Username='" & NewUser.Text & "' AND Password='" & NewPassword.Text & "' AND Type='" & cmbtype.SelectedItem & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Update has been cancelled! same credentials of the account is already in the database.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewUser.Text = Nothing Then
                MsgBox("Please enter a username.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewPassword.Text = Nothing Then
                MsgBox("Please enter a password.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf cmbtype.Text = Nothing Then
                MsgBox("Please select an Account Type.", MsgBoxStyle.Critical)
                con.Close()


            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update loginform SET Username='" & NewUser.Text & "', Password='" & NewPassword.Text & "', Type='" & cmbtype.SelectedItem & "'
                WHERE Username='" & usernameread.Text & "' And Password='" & passwordread.Text & "' AND Type='" & accountread.Text & "'"

                cmd.ExecuteNonQuery()
                MsgBox("Selected user has been successfully updated!", MsgBoxStyle.Information)
                con.Close()
            End If

            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM loginform", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "loginform")
            AccountGridView.DataSource = ds.Tables("loginform")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click

        openCon()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from loginform where user_id='" & useridtxt.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Section has been deleted.", MsgBoxStyle.Exclamation)

        con.Close()

        accountread.Clear()
        passwordread.Clear()
        usernameread.Clear()
        useridtxt.Clear()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM loginform", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "loginform")
            AccountGridView.DataSource = ds.Tables("loginform")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub NewUser_TextChanged(sender As Object, e As EventArgs) Handles NewUser.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub accountread_TextChanged(sender As Object, e As EventArgs) Handles accountread.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged

    End Sub

    Private Sub useridtxt_TextChanged(sender As Object, e As EventArgs) Handles useridtxt.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub NewPassword_TextChanged(sender As Object, e As EventArgs) Handles NewPassword.TextChanged

    End Sub

    Private Sub passwordread_TextChanged(sender As Object, e As EventArgs) Handles passwordread.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub usernameread_TextChanged(sender As Object, e As EventArgs) Handles usernameread.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class