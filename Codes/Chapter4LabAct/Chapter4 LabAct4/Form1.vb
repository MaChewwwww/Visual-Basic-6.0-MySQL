Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



        If TextBox1.Text = "B" Or TextBox1.Text = "b" Then
            TextBox2.Text = "Battleship!"
        ElseIf TextBox1.Text = "C" Or TextBox1.Text = "c" Then
            TextBox2.Text = "Cruiser!"
        ElseIf TextBox1.Text = "D" Or TextBox1.Text = "d" Then
            TextBox2.Text = "Destroyer!"
        ElseIf TextBox1.Text = "F" Or TextBox1.Text = "F" Then
            TextBox2.Text = "Frigate!"
        Else
            TextBox2.Text = "Invalid class id of the ship!"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
