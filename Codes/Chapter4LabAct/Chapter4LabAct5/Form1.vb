Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then

            Dim nNumber As Double
            nNumber = Val(TextBox1.Text)

            If nNumber < 5 Then
                TextBox2.Text = "Little or No Damage."
            ElseIf nNumber >= 5 And nNumber <= 5.5 Then
                TextBox2.Text = "Some Damage!"
            ElseIf nNumber >= 5.6 And nNumber <= 6.5 Then
                TextBox2.Text = "Serious Damage!"
            ElseIf nNumber >= 6.6 And nNumber <= 7.5 Then
                TextBox2.Text = "Disaster!"
            ElseIf nNumber > 7.5 Then
                TextBox2.Text = "Catastrophe!"
            End If
        Else
                TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("Please put a number.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
