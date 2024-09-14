Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Dim CB1 As String
        CB1 = "CheckBox 1 is Clicked!"

        MsgBox(CB1)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        Dim CB2 As String
        CB2 = "CheckBox 2 is Clicked!"

        MsgBox(CB2)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        Dim CB3 As String
        CB3 = "CheckBox 3 is Clicked!"

        MsgBox(CB3)

    End Sub


End Class
