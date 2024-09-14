<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SectionMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SectionGridView = New System.Windows.Forms.DataGridView()
        Me.sectionidtxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NewSectionTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewAdvisertxt = New System.Windows.Forms.TextBox()
        Me.SectionReadtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GradeReadtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdviserReadtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGrade = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeleteSection = New System.Windows.Forms.Button()
        Me.btnUpdateSection = New System.Windows.Forms.Button()
        Me.btnAddSection = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.SectionGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SectionGridView
        '
        Me.SectionGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SectionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectionGridView.Location = New System.Drawing.Point(12, 57)
        Me.SectionGridView.Name = "SectionGridView"
        Me.SectionGridView.Size = New System.Drawing.Size(608, 454)
        Me.SectionGridView.TabIndex = 0
        '
        'sectionidtxt
        '
        Me.sectionidtxt.Location = New System.Drawing.Point(648, 465)
        Me.sectionidtxt.Name = "sectionidtxt"
        Me.sectionidtxt.ReadOnly = True
        Me.sectionidtxt.Size = New System.Drawing.Size(139, 20)
        Me.sectionidtxt.TabIndex = 51
        Me.sectionidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(679, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Section ID"
        '
        'NewSectionTxt
        '
        Me.NewSectionTxt.Location = New System.Drawing.Point(881, 272)
        Me.NewSectionTxt.Name = "NewSectionTxt"
        Me.NewSectionTxt.Size = New System.Drawing.Size(139, 20)
        Me.NewSectionTxt.TabIndex = 49
        Me.NewSectionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(923, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Section"
        '
        'NewAdvisertxt
        '
        Me.NewAdvisertxt.Location = New System.Drawing.Point(881, 368)
        Me.NewAdvisertxt.Name = "NewAdvisertxt"
        Me.NewAdvisertxt.Size = New System.Drawing.Size(139, 20)
        Me.NewAdvisertxt.TabIndex = 45
        Me.NewAdvisertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SectionReadtxt
        '
        Me.SectionReadtxt.Location = New System.Drawing.Point(648, 272)
        Me.SectionReadtxt.Name = "SectionReadtxt"
        Me.SectionReadtxt.ReadOnly = True
        Me.SectionReadtxt.Size = New System.Drawing.Size(139, 20)
        Me.SectionReadtxt.TabIndex = 43
        Me.SectionReadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(689, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Section"
        '
        'GradeReadtxt
        '
        Me.GradeReadtxt.Location = New System.Drawing.Point(648, 188)
        Me.GradeReadtxt.Name = "GradeReadtxt"
        Me.GradeReadtxt.ReadOnly = True
        Me.GradeReadtxt.Size = New System.Drawing.Size(139, 20)
        Me.GradeReadtxt.TabIndex = 41
        Me.GradeReadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(689, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Grade"
        '
        'AdviserReadtxt
        '
        Me.AdviserReadtxt.Location = New System.Drawing.Point(648, 368)
        Me.AdviserReadtxt.Name = "AdviserReadtxt"
        Me.AdviserReadtxt.ReadOnly = True
        Me.AdviserReadtxt.Size = New System.Drawing.Size(139, 20)
        Me.AdviserReadtxt.TabIndex = 39
        Me.AdviserReadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(689, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Adviser"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(807, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Update Data / Add Section"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(639, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 27)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Selected Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(923, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Grade"
        '
        'cmbGrade
        '
        Me.cmbGrade.FormattingEnabled = True
        Me.cmbGrade.Items.AddRange(New Object() {"11", "12"})
        Me.cmbGrade.Location = New System.Drawing.Point(881, 188)
        Me.cmbGrade.Name = "cmbGrade"
        Me.cmbGrade.Size = New System.Drawing.Size(139, 21)
        Me.cmbGrade.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(923, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Adviser"
        '
        'btnDeleteSection
        '
        Me.btnDeleteSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteSection.Location = New System.Drawing.Point(410, 545)
        Me.btnDeleteSection.Name = "btnDeleteSection"
        Me.btnDeleteSection.Size = New System.Drawing.Size(134, 47)
        Me.btnDeleteSection.TabIndex = 57
        Me.btnDeleteSection.Text = "Delete"
        Me.btnDeleteSection.UseVisualStyleBackColor = False
        '
        'btnUpdateSection
        '
        Me.btnUpdateSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateSection.Location = New System.Drawing.Point(235, 545)
        Me.btnUpdateSection.Name = "btnUpdateSection"
        Me.btnUpdateSection.Size = New System.Drawing.Size(134, 47)
        Me.btnUpdateSection.TabIndex = 56
        Me.btnUpdateSection.Text = "Update Selected Section"
        Me.btnUpdateSection.UseVisualStyleBackColor = False
        '
        'btnAddSection
        '
        Me.btnAddSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddSection.Location = New System.Drawing.Point(63, 545)
        Me.btnAddSection.Name = "btnAddSection"
        Me.btnAddSection.Size = New System.Drawing.Size(134, 47)
        Me.btnAddSection.TabIndex = 55
        Me.btnAddSection.Text = "Add Section"
        Me.btnAddSection.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(255, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 27)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "List of Section"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(969, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 43)
        Me.btnBack.TabIndex = 59
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'SectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 641)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDeleteSection)
        Me.Controls.Add(Me.btnUpdateSection)
        Me.Controls.Add(Me.btnAddSection)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbGrade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sectionidtxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NewSectionTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NewAdvisertxt)
        Me.Controls.Add(Me.SectionReadtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GradeReadtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AdviserReadtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SectionGridView)
        Me.Name = "SectionMenu"
        Me.Text = "SectionMenu"
        CType(Me.SectionGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SectionGridView As DataGridView
    Friend WithEvents sectionidtxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NewSectionTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NewAdvisertxt As TextBox
    Friend WithEvents SectionReadtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GradeReadtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AdviserReadtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDeleteSection As Button
    Friend WithEvents btnUpdateSection As Button
    Friend WithEvents btnAddSection As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
End Class
