Public Class Form1
    Dim N1, N2 As Double
    Dim Answer As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 + N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 - N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 * N2
        TextBox3.Text = ("" + Answer)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        N1 = Val(TextBox1.Text)
        N2 = Val(TextBox2.Text)
        Answer = N1 / N2
        TextBox3.Text = ("" + Answer)
    End Sub
End Class
