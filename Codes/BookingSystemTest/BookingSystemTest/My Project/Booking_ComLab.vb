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
            Dim Search As New MySqlDataAdapter("SELECT Room, Grade, Section, Date, Time FROM daterequest_comlab ORDER BY Date, Time", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            DataGridView1.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Room = "Computer Lab"

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

                cmd.CommandText = "insert into daterequest_comlab (`Room`,`Date`,`Time`,`Grade`,`Section`,`Purpose`) VALUES ('" & Room & "','" & dtpDate.Value.Date & "', '" & cmbTime.SelectedItem & "', '" & Grade & "', 
                '" & cmbSection.SelectedItem & "', '" & txtPurpose.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("SuccessFully Requested, please wait for approval.", MsgBoxStyle.Information)

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Room, Grade, Section, Date, Time FROM daterequest_comlab ORDER BY Date, Time", con)
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

        With Me.cmbSection.Items

            .Clear()
            .Add("ICT-A")
            .Add("ICT-B")
            .Add("Tourism")
            .Add("STEM-A")
            .Add("STEM-B")
            .Add("STEM-C")
            .Add("STEM-D")


        End With


    End Sub

    Private Sub radioG12_CheckedChanged(sender As Object, e As EventArgs) Handles radioG12.CheckedChanged

        Grade = "12"
        cmbSection.Text = ""

        With Me.cmbSection.Items
            .Clear()
            .Add("ICT")
            .Add("Tourism")
            .Add("STEM-1")
            .Add("STEM-2")
            .Add("STEM-3")
            .Add("STEM-4")

        End With

    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged


    End Sub
End Class
