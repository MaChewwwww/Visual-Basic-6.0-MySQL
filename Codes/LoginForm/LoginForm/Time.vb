Imports MySql.Data.MySqlClient

Public Class Time
    Private Sub Time_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()
        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "time")
            TimeGridView.DataSource = ds.Tables("time")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub TimeGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TimeGridView.CellClick

        timeid.Text = TimeGridView.CurrentRow.Cells(0).Value.ToString
        readtimestart.Text = TimeGridView.CurrentRow.Cells(1).Value.ToString
        readendtime.Text = TimeGridView.CurrentRow.Cells(2).Value.ToString
        readtotalusage.Text = TimeGridView.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from time WHERE starting_time='" & newtimestart.Text & "' AND end_usage='" & newendtime.Text & "'"
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                MsgBox("Duplicate Entry Found! this time usage already exist in the database.", MsgBoxStyle.Critical)
                con.Close()

            ElseIf newtimestart.Text = Nothing Then
                MsgBox("Please enter a starting time.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf newendtime.Text = Nothing Then
                MsgBox("Please enter your desired end time usage.", MsgBoxStyle.Critical)
                con.Close()

            Else
                con.Close()

                Dim t1 As String
                Dim t2 As String

                t1 = newtimestart.Text
                t2 = newendtime.Text

                newtotalusage.Text = t1 + " - " + t2

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO time (`starting_time`,`end_usage`,`time`) VALUES ('" & newtimestart.Text & "','" & newendtime.Text & "','" & newtotalusage.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("New time usage has been successfully registered to the database.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "time")
            TimeGridView.DataSource = ds.Tables("time")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub btnUpdateTime_Click(sender As Object, e As EventArgs) Handles btnUpdateTime.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from time WHERE starting_time='" & newtimestart.Text & "' AND end_usage='" & newendtime.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Update has been cancelled! same time usage is already in the database.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf newtimestart.Text = Nothing Then
                MsgBox("Please enter a starting time.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf newendtime.Text = Nothing Then
                MsgBox("Please enter your desired end time usage.", MsgBoxStyle.Critical)
                con.Close()

            Else
                con.Close()

                Dim t1 As String
                Dim t2 As String

                t1 = newtimestart.Text
                t2 = newendtime.Text

                newtotalusage.Text = t1 + " - " + t2

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update time SET starting_time='" & newtimestart.Text & "', end_usage='" & newendtime.Text & "', time='" & newtotalusage.Text & "'
                WHERE starting_time='" & readtimestart.Text & "' And end_usage='" & readendtime.Text & "' AND time='" & readtotalusage.Text & "'"

                cmd.ExecuteNonQuery()
                MsgBox("Selected user has been successfully updated!", MsgBoxStyle.Information)
                con.Close()
            End If

            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "time")
            TimeGridView.DataSource = ds.Tables("time")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminForm.Show()
        Me.Close()
        AdminForm.WelcomeCurrentUser.Text = "Welcome " + CurrentUser
    End Sub

    Private Sub btnDeleteTime_Click(sender As Object, e As EventArgs) Handles btnDeleteTime.Click

        If timeid.Text = Nothing Then
            MsgBox("Please select a row inside the table.", MsgBoxStyle.Critical)

        Else
            openCon()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Delete from time where id='" & timeid.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Time availability has been deleted.", MsgBoxStyle.Exclamation)

            con.Close()

            readendtime.Clear()
            readtotalusage.Clear()
            readtimestart.Clear()
            timeid.Clear()

            Try
                con.Open()
                Dim Search As New MySqlDataAdapter("SELECT * FROM time", con)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "time")
                TimeGridView.DataSource = ds.Tables("time")
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try

        End If

    End Sub
End Class