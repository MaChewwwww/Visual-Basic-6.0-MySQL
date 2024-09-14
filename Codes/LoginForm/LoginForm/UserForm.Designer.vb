<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyPendingRequests = New System.Windows.Forms.DataGridView()
        Me.MyApprovedRequests = New System.Windows.Forms.DataGridView()
        Me.WelcomeUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPendingRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApprovedRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(27, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(233, 258)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 561)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(106, 573)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(121, 42)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyPendingRequests
        '
        Me.MyPendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyPendingRequests.Location = New System.Drawing.Point(284, 56)
        Me.MyPendingRequests.Name = "MyPendingRequests"
        Me.MyPendingRequests.Size = New System.Drawing.Size(797, 258)
        Me.MyPendingRequests.TabIndex = 9
        '
        'MyApprovedRequests
        '
        Me.MyApprovedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyApprovedRequests.Location = New System.Drawing.Point(284, 379)
        Me.MyApprovedRequests.Name = "MyApprovedRequests"
        Me.MyApprovedRequests.Size = New System.Drawing.Size(797, 258)
        Me.MyApprovedRequests.TabIndex = 10
        '
        'WelcomeUser
        '
        Me.WelcomeUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WelcomeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WelcomeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeUser.Location = New System.Drawing.Point(27, 19)
        Me.WelcomeUser.Name = "WelcomeUser"
        Me.WelcomeUser.ReadOnly = True
        Me.WelcomeUser.Size = New System.Drawing.Size(233, 31)
        Me.WelcomeUser.TabIndex = 11
        Me.WelcomeUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 39)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "My Approved Request List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "My Pending Request List"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 649)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WelcomeUser)
        Me.Controls.Add(Me.MyApprovedRequests)
        Me.Controls.Add(Me.MyPendingRequests)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "UserForm"
        Me.Text = "MainForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPendingRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApprovedRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MyPendingRequests As DataGridView
    Friend WithEvents MyApprovedRequests As DataGridView
    Public WithEvents WelcomeUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
