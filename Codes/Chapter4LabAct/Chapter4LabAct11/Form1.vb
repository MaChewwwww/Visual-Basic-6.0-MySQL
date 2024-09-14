Public Class Form1

    Dim Medical_Exam As Double
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CheckBox1.Checked = True
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        Medical_Exam = 12000
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = True
        CheckBox4.Checked = False
        Medical_Exam = 700
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        Medical_Exam = 1000
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nExam, Bill As Double
        nExam = Val(TextBox1.Text)
        Bill = nExam * Medical_Exam
        TextBox2.Text = Bill

    End Sub
End Class

