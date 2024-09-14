Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Dim O1 As String

        O1 = "Option Button 1 is Clicked!"

        TextBox1.Text = O1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Dim O2 As String

        O2 = "Option Button 2 is Clicked!"

        TextBox1.Text = O2

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Dim O3 As String

        O3 = "Option Button 3 is Clicked!"

        TextBox1.Text = O3

    End Sub
End Class
