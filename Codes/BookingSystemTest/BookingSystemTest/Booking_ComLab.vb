Imports MySql.Data.MySqlClient
Public Class Booking_ComLab

    Dim Grade As String
    Dim Section As String
    Dim Room As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSection.Items.Clear()

        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Room, Grade, Section, Date, Time, Approval FROM daterequest_comlab ORDER BY Date, Time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            DataGridView1.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try



        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select Room_Name from bookingsystem.roomlist"
            dr = cmd.ExecuteReader
            cmbSection.Items.Clear()

            While dr.Read

                Dim RoomName = dr.GetString("Room_Name")
                cmbRoom.Items.Add(RoomName)

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        openCon()

        Try
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from bookingsystem.daterequest_comlab where Date='" & dtpDate.Value.Date & "' AND Time='" & cmbTime.SelectedItem & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Duplicate Entry Found! your request has been cancelled.", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()

                con.Open()

                cmd.CommandText = "insert into daterequest_comlab (`Room`,`Date`,`Time`,`Grade`,`Section`,`Purpose`) VALUES ('" & cmbRoom.SelectedItem & "','" & dtpDate.Value.Date & "', '" & cmbTime.SelectedItem & "', '" & Grade & "', 
                '" & cmbSection.SelectedItem & "', '" & txtPurpose.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("SuccessFully Requested, please wait for approval.", MsgBoxStyle.Information)

                cmbRoom.Text = ""
                Label7.Text = "Pending Request List"
                cmbTime.Text = ""
                cmbSection.Text = ""

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Room, Grade, Section, Date, Time, Approval FROM daterequest_comlab ORDER BY Date, Time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            DataGridView1.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTime.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub radioG11_CheckedChanged(sender As Object, e As EventArgs) Handles radioG11.CheckedChanged

        Grade = "11"
        cmbSection.Text = ""


        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select grade, section from bookingsystem.grade_section where grade='" & Grade & "'"
            dr = cmd.ExecuteReader
            cmbSection.Items.Clear()

            While dr.Read

                Dim SectionList = dr.GetString("Section")
                cmbSection.Items.Add(SectionList)

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub radioG12_CheckedChanged(sender As Object, e As EventArgs) Handles radioG12.CheckedChanged

        Grade = "12"
        cmbSection.Text = ""

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select grade, section from bookingsystem.grade_section where grade='" & Grade & "'"
            dr = cmd.ExecuteReader
            cmbSection.Items.Clear()

            While dr.Read

                Dim SectionList = dr.GetString("Section")
                cmbSection.Items.Add(SectionList)

            End While

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged

        Label7.Text = cmbRoom.Text + " Pending Request List"

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Room, Grade, Section, Date, Time, Approval FROM daterequest_comlab WHERE Room='" & cmbRoom.SelectedItem & "'ORDER BY Date, Time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            DataGridView1.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub
End Class
