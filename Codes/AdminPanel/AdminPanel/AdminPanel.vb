﻿Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class AdminPanel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Booking_id,  Room, Grade, Section, Date, Time, Approval, Purpose FROM daterequest_comlab WHERE Approval = 'Pending';", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            PendingGrid.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        openCon()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from daterequest_comlab where Booking_id='" & bidtxt.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Request has been deleted.")

        con.Close()
        bidtxt.Clear()
        roomtxt.Clear()
        gradetxt.Clear()
        sectiontxt.Clear()
        datetxt.Clear()
        timetxt.Clear()
        txtpurpose.Clear()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Booking_id,  Room, Grade, Section, Date, Time, Approval, Purpose FROM daterequest_comlab WHERE Approval = 'Pending';", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            PendingGrid.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub PendingGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PendingGrid.CellClick

        bidtxt.Text = PendingGrid.CurrentRow.Cells(0).Value.ToString
        roomtxt.Text = PendingGrid.CurrentRow.Cells(1).Value.ToString
        gradetxt.Text = PendingGrid.CurrentRow.Cells(2).Value.ToString
        sectiontxt.Text = PendingGrid.CurrentRow.Cells(3).Value.ToString
        datetxt.Text = PendingGrid.CurrentRow.Cells(4).Value.ToString
        timetxt.Text = PendingGrid.CurrentRow.Cells(5).Value.ToString
        txtpurpose.Text = PendingGrid.CurrentRow.Cells(7).Value.ToString

    End Sub

    Private Sub ApprovedGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtpurpose_TextChanged(sender As Object, e As EventArgs) Handles txtpurpose.TextChanged

    End Sub

    Private Sub bidtxt_TextChanged(sender As Object, e As EventArgs) Handles bidtxt.TextChanged

    End Sub

    Private Sub roomtxt_TextChanged(sender As Object, e As EventArgs) Handles roomtxt.TextChanged

    End Sub

    Private Sub gradetxt_TextChanged(sender As Object, e As EventArgs) Handles gradetxt.TextChanged

    End Sub

    Private Sub sectiontxt_TextChanged(sender As Object, e As EventArgs) Handles sectiontxt.TextChanged

    End Sub

    Private Sub datetxt_TextChanged(sender As Object, e As EventArgs) Handles datetxt.TextChanged

    End Sub

    Private Sub timetxt_TextChanged(sender As Object, e As EventArgs) Handles timetxt.TextChanged

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        openCon()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from daterequest_comlab where Booking_id='" & bidtxt.Text & "'"
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into approved_request (`Booking_id`,`Room`,`Grade`,`Section`,`Date`,`Time`,`Purpose`) VALUES 
        ('" & bidtxt.Text & "','" & roomtxt.Text & "','" & gradetxt.Text & "', '" & sectiontxt.Text & "', '" & datetxt.Text & "', '" & timetxt.Text & "', '" & txtpurpose.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("Request has been approved.", MsgBoxStyle.Information)
        con.Close()

        bidtxt.Clear()
        roomtxt.Clear()
        gradetxt.Clear()
        sectiontxt.Clear()
        datetxt.Clear()
        timetxt.Clear()
        txtpurpose.Clear()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Booking_id,  Room, Grade, Section, Date, Time, Approval, Purpose FROM daterequest_comlab WHERE Approval = 'Pending';", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            PendingGrid.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub btnApprovedList_Click(sender As Object, e As EventArgs) Handles btnApprovedList.Click

        ApprovedRequestList.Show()

    End Sub

End Class
