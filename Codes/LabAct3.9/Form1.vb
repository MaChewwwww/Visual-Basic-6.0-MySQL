Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim T1, T2, T3 As Double

        T1 = Val(TextBox1.Text)
        T2 = Val(TextBox2.Text)
        T3 = T1 * T2

        TextBox3.Text = T3


    End Sub
End Class
