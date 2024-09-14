Public Class Grade
    Private Sub Grade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If Val(TextBox1.Text) >= 90 Then
            TextBox2.Text = "A"

        ElseIf Val(TextBox1.Text) >= 80 And Val(TextBox1.Text) <= 89 Then
            TextBox2.Text = "B"

        ElseIf Val(TextBox1.Text) >= 70 And Val(TextBox1.Text) >= 79 Then
            TextBox2.Text = "C"

        ElseIf Val(TextBox1.Text) >= 60 And Val(TextBox1.Text) >= 69 Then
            TextBox2.Text = "D"

        ElseIf Val(TextBox1.Text) < 60 Then
            TextBox2.Text = "F"

        End If

    End Sub
End Class
