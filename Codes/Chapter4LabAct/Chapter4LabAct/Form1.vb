Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



        If TextBox1.Text = "A" Or TextBox1.Text = "a" Then
            TextBox2.Text = "It's a Vowel!"
        ElseIf TextBox1.Text = "E" Or TextBox1.Text = "e" Then
            TextBox2.Text = "It's a Vowel!"
        ElseIf TextBox1.Text = "I" Or TextBox1.Text = "i" Then
            TextBox2.Text = "It's a Vowel!"
        ElseIf TextBox1.Text = "O" Or TextBox1.Text = "o" Then
            TextBox2.Text = "It's a Vowel!"
        ElseIf TextBox1.Text = "U" Or TextBox1.Text = "u" Then
            TextBox2.Text = "It's a Vowel!"
        ElseIf IsNumeric(TextBox1.Text) Then
            TextBox2.Text = "It's a Number!"

        Else
            TextBox2.Text = "It's a Consonant!"

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
