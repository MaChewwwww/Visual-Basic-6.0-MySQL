<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.btnUpdateAccount = New System.Windows.Forms.Button()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.useridtxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.passwordread = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usernameread = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AccountGridView = New System.Windows.Forms.DataGridView()
        Me.accountread = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewUser = New System.Windows.Forms.TextBox()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        CType(Me.AccountGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(985, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 43)
        Me.btnBack.TabIndex = 81
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 27)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "List of Accounts"
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteAccount.Location = New System.Drawing.Point(410, 562)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(134, 47)
        Me.btnDeleteAccount.TabIndex = 79
        Me.btnDeleteAccount.Text = "Delete"
        Me.btnDeleteAccount.UseVisualStyleBackColor = False
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateAccount.Location = New System.Drawing.Point(235, 562)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Size = New System.Drawing.Size(134, 47)
        Me.btnUpdateAccount.TabIndex = 78
        Me.btnUpdateAccount.Text = "Update Selected Account"
        Me.btnUpdateAccount.UseVisualStyleBackColor = False
        '
        'btnAddAccount
        '
        Me.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddAccount.Location = New System.Drawing.Point(63, 562)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(134, 47)
        Me.btnAddAccount.TabIndex = 77
        Me.btnAddAccount.Text = "Add Account"
        Me.btnAddAccount.UseVisualStyleBackColor = False
        '
        'useridtxt
        '
        Me.useridtxt.Location = New System.Drawing.Point(650, 449)
        Me.useridtxt.Name = "useridtxt"
        Me.useridtxt.ReadOnly = True
        Me.useridtxt.Size = New System.Drawing.Size(139, 20)
        Me.useridtxt.TabIndex = 73
        Me.useridtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(690, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "User ID"
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(895, 289)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(139, 20)
        Me.NewPassword.TabIndex = 71
        Me.NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordread
        '
        Me.passwordread.Location = New System.Drawing.Point(648, 289)
        Me.passwordread.Name = "passwordread"
        Me.passwordread.ReadOnly = True
        Me.passwordread.Size = New System.Drawing.Size(139, 20)
        Me.passwordread.TabIndex = 68
        Me.passwordread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(676, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Password"
        '
        'usernameread
        '
        Me.usernameread.Location = New System.Drawing.Point(648, 205)
        Me.usernameread.Name = "usernameread"
        Me.usernameread.ReadOnly = True
        Me.usernameread.Size = New System.Drawing.Size(139, 20)
        Me.usernameread.TabIndex = 66
        Me.usernameread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(671, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(822, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Update Data / Add Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(639, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 27)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Selected Data"
        '
        'AccountGridView
        '
        Me.AccountGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountGridView.Location = New System.Drawing.Point(12, 74)
        Me.AccountGridView.Name = "AccountGridView"
        Me.AccountGridView.Size = New System.Drawing.Size(574, 454)
        Me.AccountGridView.TabIndex = 60
        '
        'accountread
        '
        Me.accountread.Location = New System.Drawing.Point(649, 375)
        Me.accountread.Name = "accountread"
        Me.accountread.ReadOnly = True
        Me.accountread.Size = New System.Drawing.Size(139, 20)
        Me.accountread.TabIndex = 83
        Me.accountread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(666, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Account Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(910, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Account Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(922, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(922, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Password"
        '
        'NewUser
        '
        Me.NewUser.Location = New System.Drawing.Point(895, 205)
        Me.NewUser.Name = "NewUser"
        Me.NewUser.Size = New System.Drawing.Size(139, 20)
        Me.NewUser.TabIndex = 88
        Me.NewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbtype
        '
        Me.cmbtype.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbtype.Location = New System.Drawing.Point(895, 384)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(139, 21)
        Me.cmbtype.TabIndex = 89
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 655)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.NewUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.accountread)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDeleteAccount)
        Me.Controls.Add(Me.btnUpdateAccount)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.useridtxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.passwordread)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.usernameread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AccountGridView)
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        CType(Me.AccountGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents btnUpdateAccount As Button
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents useridtxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents passwordread As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents usernameread As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AccountGridView As DataGridView
    Friend WithEvents accountread As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NewUser As TextBox
    Friend WithEvents cmbtype As ComboBox
End Class
