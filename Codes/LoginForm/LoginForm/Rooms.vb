Imports MySql.Data.MySqlClient

Public Class Rooms
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()


        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM roomlist", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "roomlist")
            RoomListGrid.DataSource = ds.Tables("roomlist")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try




    End Sub

    Private Sub RoomListGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RoomListGrid.CellClick

        txtroomid.Text = RoomListGrid.CurrentRow.Cells(0).Value.ToString
        RoomTypeReadtxt.Text = RoomListGrid.CurrentRow.Cells(1).Value.ToString
        RoomNameReadTxt.Text = RoomListGrid.CurrentRow.Cells(2).Value.ToString
        RoomNumberReadtxt.Text = RoomListGrid.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click



        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from bookingsystem.roomlist WHERE Room_Name='" & NewRoomNametxt.Text & "' OR Room_Number='" & NewRoomNotxt.Text & "'"
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                MsgBox("Duplicate Entry Found! this room already exist in the database.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewRoomTypetxt.Text = Nothing Then
                MsgBox("Please enter a room type.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewRoomNametxt.Text = Nothing Then
                MsgBox("Please enter a room name.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewRoomNotxt.Text = Nothing Then
                MsgBox("Please enter a room number.", MsgBoxStyle.Critical)
                con.Close()


            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO bookingsystem.roomlist (`Room_Type`,`Room_Name`,`Room_Number`) VALUES ('" & NewRoomTypetxt.Text & "','" & NewRoomNametxt.Text & "','" & NewRoomNotxt.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("New room has been successfully added!.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try





        Try
                con.Open()
                Dim Search As New MySqlDataAdapter("SELECT * FROM roomlist", con)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "roomlist")
                RoomListGrid.DataSource = ds.Tables("roomlist")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try

    End Sub

    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click


        Try


            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from bookingsystem.roomlist WHERE Room_Name='" & NewRoomNametxt.Text & "' AND Room_Number='" & NewRoomNotxt.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Update has been cancelled! the new data is already in the database.", MsgBoxStyle.Critical)
                con.Close()

            ElseIf txtroomid.Text = Nothing Then
                MsgBox("Please select a room inside the data table.", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update bookingsystem.roomlist SET Room_Type='" & NewRoomTypetxt.Text & "', Room_Name='" & NewRoomNametxt.Text & "', Room_Number='" & NewRoomNotxt.Text & "'
                WHERE Room_Type='" & RoomTypeReadtxt.Text & "' And Room_Name='" & RoomNameReadTxt.Text & "' AND Room_Number='" & RoomNumberReadtxt.Text & "'"
                cmd.ExecuteNonQuery()

                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update bookingsystem.daterequest_comlab SET Room='" & NewRoomNametxt.Text & "' Where Room='" & RoomNameReadTxt.Text & "'"
                cmd.ExecuteNonQuery()

                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update bookingsystem.approved_request SET Room='" & NewRoomNametxt.Text & "' Where Room='" & RoomNameReadTxt.Text & "'"
                cmd.ExecuteNonQuery()

                MsgBox("Selected room has been successfully updated!", MsgBoxStyle.Information)
                con.Close()

                txtroomid.Clear()
                RoomTypeReadtxt.Clear()
                RoomNameReadTxt.Clear()
                RoomNumberReadtxt.Clear()
                NewRoomTypetxt.Clear()
                NewRoomNametxt.Clear()
                NewRoomNotxt.Clear()
            End If


            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM roomlist", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "roomlist")
            RoomListGrid.DataSource = ds.Tables("roomlist")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub NewRoomNotxt_TextChanged(sender As Object, e As EventArgs) Handles NewRoomNotxt.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminForm.Show()
        AdminForm.WelcomeCurrentUser.Text = "Welcome " + CurrentUser
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click

        openCon()
        If txtroomid.Text = Nothing Then
            MsgBox("Please select a room inside the data table.", MsgBoxStyle.Critical)
            con.Close()
        Else
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Delete from bookingsystem.roomlist where Room_id='" & txtroomid.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Room has been deleted.", MsgBoxStyle.Exclamation)

            con.Close()

            txtroomid.Clear()
            RoomTypeReadtxt.Clear()
            RoomNameReadTxt.Clear()
            RoomNumberReadtxt.Clear()
        End If

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM roomlist", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "roomlist")
            RoomListGrid.DataSource = ds.Tables("roomlist")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub RoomListGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles RoomListGrid.CellContentClick

    End Sub

    Private Sub NewRoomNametxt_TextChanged(sender As Object, e As EventArgs) Handles NewRoomNametxt.TextChanged

    End Sub
End Class