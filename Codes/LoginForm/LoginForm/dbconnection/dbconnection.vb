Imports MySql.Data.MySqlClient

Module dbconnection

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public CurrentUser As String


    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=Ionlylovemyself123!;database=bookingsystem"
        con.Open()
    End Sub

End Module
