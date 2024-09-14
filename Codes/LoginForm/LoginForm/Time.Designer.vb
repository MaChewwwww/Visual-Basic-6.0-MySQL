<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time
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
        Me.TimeGridView = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDeleteTime = New System.Windows.Forms.Button()
        Me.btnUpdateTime = New System.Windows.Forms.Button()
        Me.btnAddTime = New System.Windows.Forms.Button()
        Me.newtimestart = New System.Windows.Forms.TextBox()
        Me.readtotalusage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.timeid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.newendtime = New System.Windows.Forms.TextBox()
        Me.readendtime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.readtimestart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.newtotalusage = New System.Windows.Forms.TextBox()
        CType(Me.TimeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeGridView
        '
        Me.TimeGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimeGridView.Location = New System.Drawing.Point(32, 78)
        Me.TimeGridView.Name = "TimeGridView"
        Me.TimeGridView.Size = New System.Drawing.Size(461, 412)
        Me.TimeGridView.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(103, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(315, 27)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "List of Available Time Usage"
        '
        'btnDeleteTime
        '
        Me.btnDeleteTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteTime.Location = New System.Drawing.Point(359, 533)
        Me.btnDeleteTime.Name = "btnDeleteTime"
        Me.btnDeleteTime.Size = New System.Drawing.Size(134, 47)
        Me.btnDeleteTime.TabIndex = 84
        Me.btnDeleteTime.Text = "Delete"
        Me.btnDeleteTime.UseVisualStyleBackColor = False
        '
        'btnUpdateTime
        '
        Me.btnUpdateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateTime.Location = New System.Drawing.Point(196, 533)
        Me.btnUpdateTime.Name = "btnUpdateTime"
        Me.btnUpdateTime.Size = New System.Drawing.Size(134, 47)
        Me.btnUpdateTime.TabIndex = 83
        Me.btnUpdateTime.Text = "Update Selected Time"
        Me.btnUpdateTime.UseVisualStyleBackColor = False
        '
        'btnAddTime
        '
        Me.btnAddTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddTime.Location = New System.Drawing.Point(32, 533)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(134, 47)
        Me.btnAddTime.TabIndex = 82
        Me.btnAddTime.Text = "Add Time"
        Me.btnAddTime.UseVisualStyleBackColor = False
        '
        'newtimestart
        '
        Me.newtimestart.Location = New System.Drawing.Point(798, 212)
        Me.newtimestart.Name = "newtimestart"
        Me.newtimestart.Size = New System.Drawing.Size(139, 20)
        Me.newtimestart.TabIndex = 105
        Me.newtimestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'readtotalusage
        '
        Me.readtotalusage.Location = New System.Drawing.Point(528, 382)
        Me.readtotalusage.Name = "readtotalusage"
        Me.readtotalusage.ReadOnly = True
        Me.readtotalusage.Size = New System.Drawing.Size(139, 20)
        Me.readtotalusage.TabIndex = 101
        Me.readtotalusage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(553, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Total Usage"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(886, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 43)
        Me.btnBack.TabIndex = 99
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'timeid
        '
        Me.timeid.Location = New System.Drawing.Point(529, 456)
        Me.timeid.Name = "timeid"
        Me.timeid.ReadOnly = True
        Me.timeid.Size = New System.Drawing.Size(139, 20)
        Me.timeid.TabIndex = 98
        Me.timeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(569, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Time ID"
        '
        'newendtime
        '
        Me.newendtime.Location = New System.Drawing.Point(798, 296)
        Me.newendtime.Name = "newendtime"
        Me.newendtime.Size = New System.Drawing.Size(139, 20)
        Me.newendtime.TabIndex = 96
        Me.newendtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'readendtime
        '
        Me.readendtime.Location = New System.Drawing.Point(527, 296)
        Me.readendtime.Name = "readendtime"
        Me.readendtime.ReadOnly = True
        Me.readendtime.Size = New System.Drawing.Size(139, 20)
        Me.readendtime.TabIndex = 95
        Me.readendtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "End of Usage"
        '
        'readtimestart
        '
        Me.readtimestart.Location = New System.Drawing.Point(527, 212)
        Me.readtimestart.Name = "readtimestart"
        Me.readtimestart.ReadOnly = True
        Me.readtimestart.Size = New System.Drawing.Size(139, 20)
        Me.readtimestart.TabIndex = 93
        Me.readtimestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(545, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Starting Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(717, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Update Data / Add Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(512, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 27)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Selected Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(816, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Starting Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(812, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "End of Usage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(816, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Total Usage"
        '
        'newtotalusage
        '
        Me.newtotalusage.Location = New System.Drawing.Point(798, 382)
        Me.newtotalusage.Name = "newtotalusage"
        Me.newtotalusage.ReadOnly = True
        Me.newtotalusage.Size = New System.Drawing.Size(139, 20)
        Me.newtotalusage.TabIndex = 110
        Me.newtotalusage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Time
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 654)
        Me.Controls.Add(Me.newtotalusage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.newtimestart)
        Me.Controls.Add(Me.readtotalusage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.timeid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.newendtime)
        Me.Controls.Add(Me.readendtime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.readtimestart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDeleteTime)
        Me.Controls.Add(Me.btnUpdateTime)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TimeGridView)
        Me.Name = "Time"
        Me.Text = "Time"
        CType(Me.TimeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimeGridView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDeleteTime As Button
    Friend WithEvents btnUpdateTime As Button
    Friend WithEvents btnAddTime As Button
    Friend WithEvents newtimestart As TextBox
    Friend WithEvents readtotalusage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents timeid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents newendtime As TextBox
    Friend WithEvents readendtime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents readtimestart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents newtotalusage As TextBox
End Class
