<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PendingGrid = New System.Windows.Forms.DataGridView()
        Me.bidtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gradetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sectiontxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.TextBox()
        Me.timetxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpurpose = New System.Windows.Forms.RichTextBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnApprovedList = New System.Windows.Forms.Button()
        CType(Me.PendingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(305, 540)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(175, 71)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Reject"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PendingGrid
        '
        Me.PendingGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PendingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PendingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PendingGrid.Location = New System.Drawing.Point(12, 57)
        Me.PendingGrid.Name = "PendingGrid"
        Me.PendingGrid.Size = New System.Drawing.Size(780, 449)
        Me.PendingGrid.TabIndex = 1
        '
        'bidtxt
        '
        Me.bidtxt.Location = New System.Drawing.Point(923, 115)
        Me.bidtxt.Name = "bidtxt"
        Me.bidtxt.ReadOnly = True
        Me.bidtxt.Size = New System.Drawing.Size(118, 20)
        Me.bidtxt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(931, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Booking ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1127, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Room"
        '
        'roomtxt
        '
        Me.roomtxt.Location = New System.Drawing.Point(1105, 115)
        Me.roomtxt.Name = "roomtxt"
        Me.roomtxt.ReadOnly = True
        Me.roomtxt.Size = New System.Drawing.Size(107, 20)
        Me.roomtxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(952, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grade"
        '
        'gradetxt
        '
        Me.gradetxt.Location = New System.Drawing.Point(923, 186)
        Me.gradetxt.Name = "gradetxt"
        Me.gradetxt.ReadOnly = True
        Me.gradetxt.Size = New System.Drawing.Size(118, 20)
        Me.gradetxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1127, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Section"
        '
        'sectiontxt
        '
        Me.sectiontxt.Location = New System.Drawing.Point(1105, 186)
        Me.sectiontxt.Name = "sectiontxt"
        Me.sectiontxt.ReadOnly = True
        Me.sectiontxt.Size = New System.Drawing.Size(107, 20)
        Me.sectiontxt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(966, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date"
        '
        'datetxt
        '
        Me.datetxt.Location = New System.Drawing.Point(923, 258)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.ReadOnly = True
        Me.datetxt.Size = New System.Drawing.Size(118, 20)
        Me.datetxt.TabIndex = 11
        '
        'timetxt
        '
        Me.timetxt.Location = New System.Drawing.Point(1105, 258)
        Me.timetxt.Name = "timetxt"
        Me.timetxt.ReadOnly = True
        Me.timetxt.Size = New System.Drawing.Size(107, 20)
        Me.timetxt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1127, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1031, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Purpose"
        '
        'txtpurpose
        '
        Me.txtpurpose.Location = New System.Drawing.Point(878, 333)
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.ReadOnly = True
        Me.txtpurpose.Size = New System.Drawing.Size(384, 299)
        Me.txtpurpose.TabIndex = 15
        Me.txtpurpose.Text = ""
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.Lime
        Me.btnApprove.Location = New System.Drawing.Point(124, 540)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(175, 71)
        Me.btnApprove.TabIndex = 16
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Pending Request List"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(963, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Detailed Information"
        '
        'btnApprovedList
        '
        Me.btnApprovedList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApprovedList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprovedList.Location = New System.Drawing.Point(569, 523)
        Me.btnApprovedList.Name = "btnApprovedList"
        Me.btnApprovedList.Size = New System.Drawing.Size(269, 104)
        Me.btnApprovedList.TabIndex = 19
        Me.btnApprovedList.Text = "Click to See the List of View Approved Request"
        Me.btnApprovedList.UseVisualStyleBackColor = False
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 644)
        Me.Controls.Add(Me.btnApprovedList)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.txtpurpose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.timetxt)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sectiontxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gradetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.roomtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bidtxt)
        Me.Controls.Add(Me.PendingGrid)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "AdminPanel"
        Me.Text = "Form1"
        CType(Me.PendingGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents PendingGrid As DataGridView
    Friend WithEvents bidtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents roomtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gradetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sectiontxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents datetxt As TextBox
    Friend WithEvents timetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpurpose As RichTextBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnApprovedList As Button
End Class
