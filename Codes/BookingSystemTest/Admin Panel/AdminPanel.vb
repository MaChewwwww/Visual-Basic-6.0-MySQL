Imports MySql.Data.MySqlClient
Public Class AdminPanel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class