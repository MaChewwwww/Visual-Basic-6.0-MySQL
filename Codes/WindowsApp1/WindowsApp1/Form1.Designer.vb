<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender :"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(195, 127)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(103, 41)
        Me.radMale.TabIndex = 3
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(358, 127)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(141, 41)
        Me.radFemale.TabIndex = 4
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Birthday :"
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(171, 186)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(385, 31)
        Me.dtp.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Program :"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(183, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(354, 24)
        Me.txtName.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(183, 86)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(354, 24)
        Me.txtAge.TabIndex = 9
        '
        'cmbProgram
        '
        Me.cmbProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"BSIT", "BSCS", "BSComEng"})
        Me.cmbProgram.Location = New System.Drawing.Point(171, 257)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(385, 32)
        Me.cmbProgram.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(220, 318)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(232, 61)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbProgram)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents btnSave As Button
End Class
