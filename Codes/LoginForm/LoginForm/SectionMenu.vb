Imports MySql.Data.MySqlClient
Public Class SectionMenu
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SectionGridView.CellClick

        sectionidtxt.Text = SectionGridView.CurrentRow.Cells(0).Value.ToString
        GradeReadtxt.Text = SectionGridView.CurrentRow.Cells(1).Value.ToString
        SectionReadtxt.Text = SectionGridView.CurrentRow.Cells(2).Value.ToString
        AdviserReadtxt.Text = SectionGridView.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub SectionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected Successfully to the Database!")
        con.Close()


        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM grade_section", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "grade_section")
            SectionGridView.DataSource = ds.Tables("grade_section")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddSection.Click



        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from grade_section WHERE Grade='" & cmbGrade.SelectedItem & "' AND Section='" & NewSectionTxt.Text & "'"
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                MsgBox("Duplicate Entry Found! this section already exist in the database.", MsgBoxStyle.Critical)
                con.Close()

            ElseIf cmbGrade.SelectedItem = Nothing Then
                MsgBox("Please select a grade level.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewSectionTxt.Text = Nothing Then
                MsgBox("Please enter a section.", MsgBoxStyle.Critical)
                con.Close()
            ElseIf NewAdvisertxt.Text = Nothing Then
                MsgBox("Please enter an adviser.", MsgBoxStyle.Critical)
                con.Close()

            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO grade_section (`Grade`,`Section`,`Adviser`) VALUES ('" & cmbGrade.SelectedItem & "','" & NewSectionTxt.Text & "','" & NewAdvisertxt.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("New section has been successfully added!.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM grade_section", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "grade_section")
            SectionGridView.DataSource = ds.Tables("grade_section")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try


    End Sub

    Private Sub btnUpdateSection_Click(sender As Object, e As EventArgs) Handles btnUpdateSection.Click



        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from grade_section WHERE Grade='" & cmbGrade.SelectedItem & "' AND Section='" & NewSectionTxt.Text & "' AND Adviser='" & NewAdvisertxt.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Update has been cancelled! the new data is already in the database.", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update grade_section SET Grade='" & cmbGrade.SelectedItem & "', Section='" & NewSectionTxt.Text & "', Adviser='" & NewAdvisertxt.Text & "'
                WHERE Grade='" & GradeReadtxt.Text & "' And Section='" & SectionReadtxt.Text & "' AND Adviser='" & AdviserReadtxt.Text & "'"

                cmd.ExecuteNonQuery()
                MsgBox("Selected room has been successfully updated!", MsgBoxStyle.Information)
                con.Close()
            End If

            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM grade_section", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "grade_section")
            SectionGridView.DataSource = ds.Tables("grade_section")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub btnDeleteSection_Click(sender As Object, e As EventArgs) Handles btnDeleteSection.Click

        openCon()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from grade_section where section_id='" & sectionidtxt.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Section has been deleted.", MsgBoxStyle.Exclamation)

        con.Close()

        GradeReadtxt.Clear()
        AdviserReadtxt.Clear()
        SectionReadtxt.Clear()
        sectionidtxt.Clear()

        Try
            con.Open()
            Dim Search As New MySqlDataAdapter("SELECT * FROM grade_section", con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "grade_section")
            SectionGridView.DataSource = ds.Tables("grade_section")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub cmbGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrade.SelectedIndexChanged

    End Sub

    Private Sub NewSectionTxt_TextChanged(sender As Object, e As EventArgs) Handles NewSectionTxt.Validating

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminForm.Show()
        Me.Close()
        AdminForm.WelcomeCurrentUser.Text = "Welcome " + CurrentUser
    End Sub

End Class