<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking_ComLab
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTime = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.radioG11 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radioG12 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(166, 163)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(217, 20)
        Me.dtpDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(686, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(363, 112)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time :"
        '
        'cmbTime
        '
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Items.AddRange(New Object() {"07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00"})
        Me.cmbTime.Location = New System.Drawing.Point(166, 224)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(217, 21)
        Me.cmbTime.TabIndex = 4
        '
        'DataGridView1
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(402, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 386)
        Me.DataGridView1.TabIndex = 5
        '
        'radioG11
        '
        Me.radioG11.AutoSize = True
        Me.radioG11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioG11.Location = New System.Drawing.Point(194, 266)
        Me.radioG11.Name = "radioG11"
        Me.radioG11.Size = New System.Drawing.Size(54, 29)
        Me.radioG11.TabIndex = 6
        Me.radioG11.TabStop = True
        Me.radioG11.Text = "11"
        Me.radioG11.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Grade :"
        '
        'radioG12
        '
        Me.radioG12.AutoSize = True
        Me.radioG12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioG12.Location = New System.Drawing.Point(300, 266)
        Me.radioG12.Name = "radioG12"
        Me.radioG12.Size = New System.Drawing.Size(54, 29)
        Me.radioG12.TabIndex = 9
        Me.radioG12.TabStop = True
        Me.radioG12.Text = "12"
        Me.radioG12.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Section :"
        '
        'cmbSection
        '
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00"})
        Me.cmbSection.Location = New System.Drawing.Point(189, 324)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(194, 21)
        Me.cmbSection.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 39)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Purpose of Usage :"
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(12, 447)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(640, 154)
        Me.txtPurpose.TabIndex = 14
        Me.txtPurpose.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 39)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Room :"
        '
        'cmbRoom
        '
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Location = New System.Drawing.Point(166, 100)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(217, 21)
        Me.cmbRoom.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(550, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Pending Request List"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Booking_ComLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 613)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbRoom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.radioG12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.radioG11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Name = "Booking_ComLab"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTime As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents radioG11 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents radioG12 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurpose As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents Label7 As Label
End Class
