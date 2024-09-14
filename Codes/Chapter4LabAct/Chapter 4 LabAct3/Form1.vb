Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then
            Dim nSpeed As Double
            nSpeed = Val(TextBox1.Text)
            If nSpeed > 1100 Then
                TextBox2.Text = "It's a Civilian Aircraft!"
            ElseIf nSpeed >= 500 And nSpeed <= 1100 Then
                TextBox2.Text = "It's a Military Aircraft!"
            ElseIf nSpeed < 500 Then
                TextBox2.Text = "It's a bird!"
            End If

        Else
            TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("Please put a number.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

