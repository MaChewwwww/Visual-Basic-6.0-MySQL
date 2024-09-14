Imports System.Buffers
Imports System.CodeDom
Imports System.ComponentModel.Design
Imports System.Security.Authentication.ExtendedProtection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("Remember to still do your chores, activities and take a rest if you need to.")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox1.Text = "You seems Fresh"

        If CheckBox2.Checked = True Then
            TextBox1.Text = "You seems fresh and had a delicious meal."
        Else
            TextBox1.Text = "Remember to eat, you need energy for today's activities."
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        TextBox1.Text = "I hope you had a delicious meal"

        If CheckBox1.Checked = True Then
            TextBox1.Text = "You look so fresh, I hope you had a delicious meal."
        Else
            TextBox1.Text = "I hope you had a delicious meal, you should take a bath"
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        TextBox1.Text = "Great, it seems like you had fun."

    End Sub

End Class
