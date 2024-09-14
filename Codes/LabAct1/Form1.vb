Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "You have chose RED"
        PictureBox1.Image = Image.FromFile("C:\Users\paroc\Pictures\Red_Color.jpg")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "You have chose BLUE"
        PictureBox1.Image = Image.FromFile("C:\Users\paroc\Pictures\blue0517-4dfc85cb0200460ab717b101ac07888f.jpg")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "You have chose GREEN"
        PictureBox1.Image = Image.FromFile("C:\Users\paroc\Pictures\grass-green-color-solid-background-1920x1080.png")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
