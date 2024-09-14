Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "143" Then
            TextBox2.Text = "I Love You!"
        Else
            TextBox2.Text = "Wrong Guess!"
        End If
    End Sub

End Class
