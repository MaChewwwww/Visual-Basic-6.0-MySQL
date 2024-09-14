Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then

            Dim nNumber As Double
            nNumber = Val(TextBox1.Text)

            If nNumber >= 98 Then
                TextBox2.Text = "1.00"
            ElseIf nNumber >= 95 And nNumber <= 97 Then
                TextBox2.Text = "1.25"
            ElseIf nNumber >= 92 And nNumber <= 94 Then
                TextBox2.Text = "1.50"
            ElseIf nNumber >= 89 And nNumber <= 91 Then
                TextBox2.Text = "1.75"
            ElseIf nNumber >= 85 And nNumber <= 88 Then
                TextBox2.Text = "2.00"
            ElseIf nNumber >= 82 And nNumber <= 84 Then
                TextBox2.Text = "2.25"
            ElseIf nNumber >= 80 And nNumber <= 81 Then
                TextBox2.Text = "2.50"
            ElseIf nNumber >= 77 And nNumber <= 79 Then
                TextBox2.Text = "2.75"
            ElseIf nNumber >= 75 And nNumber <= 76 Then
                TextBox2.Text = "3.00"
            Else
                TextBox2.Text = "Out of Range!"
            End If
        Else
            TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("Please put a number.", MsgBoxStyle.Critical)
        End If
    End Sub

End Class
