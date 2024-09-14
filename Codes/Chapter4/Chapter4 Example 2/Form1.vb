Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If Val(TextBox1.Text) >= 0 Then
            TextBox2.Text = "Postive Number!"

        ElseIf Val(TextBox1.Text) < 0 Then
            TextBox2.Text = "Negative Number!"

        Else
            TextBox2.Text = "Please enter a valid number!"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
