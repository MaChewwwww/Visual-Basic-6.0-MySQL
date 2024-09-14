Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CheckBox1.Checked = True
        CheckBox5.Checked = True
        TextBox1.Text = "PHP 1500"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        TextBox1.Text = "PHP 1700"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        TextBox1.Text = "PHP 2000"
    End Sub
End Class
