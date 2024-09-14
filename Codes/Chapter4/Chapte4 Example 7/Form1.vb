Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        CheckBox1.Checked = 1
        CheckBox2.Checked = 0
        CheckBox3.Checked = 1
        CheckBox4.Checked = 0
        CheckBox5.Checked = 1
        CheckBox6.Checked = 0
        CheckBox7.Checked = 0
        TextBox1.Text = "185"

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        CheckBox1.Checked = 1
        CheckBox2.Checked = 1
        CheckBox3.Checked = 1
        CheckBox4.Checked = 1
        CheckBox5.Checked = 1
        CheckBox6.Checked = 0
        CheckBox7.Checked = 0
        TextBox1.Text = "250"

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        CheckBox1.Checked = 1
        CheckBox2.Checked = 1
        CheckBox3.Checked = 1
        CheckBox4.Checked = 1
        CheckBox5.Checked = 1
        CheckBox6.Checked = 1
        CheckBox7.Checked = 1
        TextBox1.Text = "290"

    End Sub
End Class
