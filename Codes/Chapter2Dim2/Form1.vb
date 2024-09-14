Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Dim Message As String

        Message = "Option Button 1 is Clicked!"

        MsgBox(Message)



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Dim Message As String

        Message = "Option Button 2 is Clicked!"

        MsgBox(Message)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        Dim Message As String

        Message = "Option Button 3 is Clicked!"

        MsgBox(Message)


    End Sub
End Class
