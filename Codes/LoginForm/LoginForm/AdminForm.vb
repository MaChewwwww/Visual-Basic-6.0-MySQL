Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoginForm.Hide()

    End Sub



    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles WelcomeCurrentUser.TextChanged


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Rooms.Show()
        Me.Close()
    End Sub

    Private Sub btnSections_Click(sender As Object, e As EventArgs) Handles btnSections.Click
        SectionMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnRequestList_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        RequestList.Show()
        Me.Close()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        Accounts.Show()
        Me.Close()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        Me.Close()
        Time.Show()
    End Sub
End Class