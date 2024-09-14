Imports MySql.Data.MySqlClient
Public Class AdminPanel

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT Booking_id, Room, Grade, Section, Date, Time, Approval, Purpose FROM daterequest_comlab ORDER BY Date, Time WHERE Approval = 'Pending'", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            DataGridView1.DataSource = ds.Tables("daterequest_comlab")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class