Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim nYearEntry As Integer
        nYearEntry = Val(TextBox1.Text)
        Select Case nYearEntry
            Case 1
                TextBox2.Text = "Freshman!"
            Case 2
                TextBox2.Text = "Sophomore!"
            Case 3
                TextBox2.Text = "Junior!"
            Case 4
                TextBox2.Text = "Senior!"
            Case Else
                TextBox2.Text = "Out-Of-School!"
        End Select

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
