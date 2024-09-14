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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(135, 146)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(226, 20)
        Me.dtpDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 131)
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
        Me.Label2.Location = New System.Drawing.Point(20, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time :"
        '
        'cmbTime
        '
        Me.cmbTime.FormattingEnabled = True
        Me.cmbTime.Items.AddRange(New Object() {"07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00"})
        Me.cmbTime.Location = New System.Drawing.Point(140, 207)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(221, 21)
        Me.cmbTime.TabIndex = 4
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(388, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 386)
        Me.DataGridView1.TabIndex = 5
        '
        'radioG11
        '
        Me.radioG11.AutoSize = True
        Me.radioG11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioG11.Location = New System.Drawing.Point(167, 256)
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
        Me.Label3.Location = New System.Drawing.Point(20, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Grade :"
        '
        'radioG12
        '
        Me.radioG12.AutoSize = True
        Me.radioG12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioG12.Location = New System.Drawing.Point(243, 256)
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
        Me.Label4.Location = New System.Drawing.Point(20, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Section :"
        '
        'cmbSection
        '
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"07:00 - 08:00", "08:00 - 09:00", "09:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00"})
        Me.cmbSection.Location = New System.Drawing.Point(167, 324)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(194, 21)
        Me.cmbSection.TabIndex = 11
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.Location = New System.Drawing.Point(50, 34)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.Size = New System.Drawing.Size(247, 58)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = "Computer Lab"
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
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox2.Location = New System.Drawing.Point(603, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(238, 37)
        Me.RichTextBox2.TabIndex = 15
        Me.RichTextBox2.Text = "Pending Request List"
        '
        'Booking_ComLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 613)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
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
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurpose As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
