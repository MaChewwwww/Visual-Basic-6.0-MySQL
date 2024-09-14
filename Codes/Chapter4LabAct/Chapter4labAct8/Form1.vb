Public Class Form1
    Dim N1, N2 As Double
    Dim Answer As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 - N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 * N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 / N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 + N2
        TextBox3.Text = ("" + Answer)
    End Sub

End Class
