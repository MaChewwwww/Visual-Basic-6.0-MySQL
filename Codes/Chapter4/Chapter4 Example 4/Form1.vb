Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "B" Or TextBox1.Text = "b" Then
            TextBox2.Text = "Blue!"

        ElseIf TextBox1.Text = "R" Or TextBox1.Text = "r" Then
            TextBox2.Text = "Red!"

        ElseIf TextBox1.Text = "G" Or TextBox1.Text = "g" Then
            TextBox2.Text = "Green!"

        ElseIf TextBox1.Text = "Y" Or TextBox1.Text = "y" Then
            TextBox2.Text = "Yellow!"

        Else
            TextBox2.Text = "Unknown Color"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
