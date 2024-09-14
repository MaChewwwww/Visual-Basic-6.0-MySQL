Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Or TextBox1.Text = "-" Then

            Dim nTemp As Double
            nTemp = Val(TextBox1.Text)

            If nTemp < 0 Then
                TextBox2.Text = "ICE"
            ElseIf nTemp >= 0 And nTemp <= 100 Then
                TextBox2.Text = "WATER"
            ElseIf nTemp > 100 Then
                TextBox2.Text = "STEAM"
            ElseIf Not IsNumeric(TextBox1.Text) Then
                TextBox2.Clear()
                MsgBox("Please put a number.", MsgBoxStyle.Critical)
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

