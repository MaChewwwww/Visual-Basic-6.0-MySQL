Public Class Form1

    Dim MOP As Double
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MOP = 0.1
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        MOP = 0.05
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        MOP = 0.1
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim t1, t2, t3 As Double
        t1 = Val(TextBox1.Text)

        If RadioButton1.Checked = True Then
            t2 = t1 * MOP
            t3 = t1 - t2
            TextBox2.Text = t3
        ElseIf RadioButton2.Checked = True Then
            t2 = t1 * MOP
            t3 = t1 + t2
            TextBox2.Text = t3
        ElseIf RadioButton3.Checked = True Then
            t2 = t1 * MOP
            t3 = t1 + t2
            TextBox2.Text = t3
        End If

    End Sub
End Class

