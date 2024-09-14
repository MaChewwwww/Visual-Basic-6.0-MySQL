Imports MySql.Data.MySqlClient
Public Class ApprovedRequestList
    Private Sub ApprovedRequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()
        MsgBox("This is the list of all approved request.")
        con.Close()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM approved_request WHERE Approval = 'Approved';", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "approved_request")
            GridApprovedList.DataSource = ds.Tables("approved_request")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridApprovedList.CellContentClick

    End Sub
End Class