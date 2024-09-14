Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim sColor As String
        sColor = TextBox1.Text

        Select Case sColor
            Case "B", "b"
                TextBox2.Text = "Blue!"
            Case "R", "r"
                TextBox2.Text = "Red!"
            Case "G", "g"
                TextBox2.Text = "Green!"
            Case "Y", "y"
                TextBox2.Text = "Yellow!"
            Case Else
                TextBox2.Text = "Unknown Color!"

        End Select

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
