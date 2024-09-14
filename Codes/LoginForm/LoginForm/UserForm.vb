Imports MySql.Data.MySqlClient
Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Hide()


        con.Close()
        con.Open()
        MsgBox("Connected Successfully to the Database!")
        con.Close()

        Try

            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM daterequest_comlab WHERE Requested_User='" & LoginForm.txtUsername.Text & "'", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "daterequest_comlab")
            MyPendingRequests.DataSource = ds.Tables("daterequest_comlab")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

        Try

            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM approved_request WHERE Requested_User='" & LoginForm.txtUsername.Text & "'", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "approved_request")
            MyApprovedRequests.DataSource = ds.Tables("approved_request")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try



    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Booking_ComLab.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub
End Class