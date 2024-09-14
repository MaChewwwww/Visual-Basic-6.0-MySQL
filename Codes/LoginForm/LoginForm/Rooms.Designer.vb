<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.RoomListGrid = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoomNumberReadtxt = New System.Windows.Forms.TextBox()
        Me.RoomTypeReadtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomNameReadTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NewRoomNametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewRoomTypetxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NewRoomNotxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtroomid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.RoomListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(1134, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(110, 42)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddRoom.Location = New System.Drawing.Point(117, 542)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(134, 47)
        Me.btnAddRoom.TabIndex = 1
        Me.btnAddRoom.Text = "Add Rooms"
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'btnEditRoom
        '
        Me.btnEditRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEditRoom.Location = New System.Drawing.Point(296, 542)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(134, 47)
        Me.btnEditRoom.TabIndex = 2
        Me.btnEditRoom.Text = "Update Selected Room"
        Me.btnEditRoom.UseVisualStyleBackColor = False
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteRoom.Location = New System.Drawing.Point(478, 542)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(134, 47)
        Me.btnDeleteRoom.TabIndex = 3
        Me.btnDeleteRoom.Text = "Delete"
        Me.btnDeleteRoom.UseVisualStyleBackColor = False
        '
        'RoomListGrid
        '
        Me.RoomListGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoomListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RoomListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomListGrid.Location = New System.Drawing.Point(26, 72)
        Me.RoomListGrid.Name = "RoomListGrid"
        Me.RoomListGrid.Size = New System.Drawing.Size(704, 452)
        Me.RoomListGrid.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(780, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 27)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Selected Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(972, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Update Data / Add Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(828, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Room No."
        '
        'RoomNumberReadtxt
        '
        Me.RoomNumberReadtxt.Location = New System.Drawing.Point(797, 382)
        Me.RoomNumberReadtxt.Name = "RoomNumberReadtxt"
        Me.RoomNumberReadtxt.ReadOnly = True
        Me.RoomNumberReadtxt.Size = New System.Drawing.Size(139, 20)
        Me.RoomNumberReadtxt.TabIndex = 22
        Me.RoomNumberReadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RoomTypeReadtxt
        '
        Me.RoomTypeReadtxt.Location = New System.Drawing.Point(797, 191)
        Me.RoomTypeReadtxt.Name = "RoomTypeReadtxt"
        Me.RoomTypeReadtxt.ReadOnly = True
        Me.RoomTypeReadtxt.Size = New System.Drawing.Size(139, 20)
        Me.RoomTypeReadtxt.TabIndex = 24
        Me.RoomTypeReadtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(818, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Room Type"
        '
        'RoomNameReadTxt
        '
        Me.RoomNameReadTxt.Location = New System.Drawing.Point(797, 288)
        Me.RoomNameReadTxt.Name = "RoomNameReadTxt"
        Me.RoomNameReadTxt.ReadOnly = True
        Me.RoomNameReadTxt.Size = New System.Drawing.Size(139, 20)
        Me.RoomNameReadTxt.TabIndex = 26
        Me.RoomNameReadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(818, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Room Name"
        '
        'NewRoomNametxt
        '
        Me.NewRoomNametxt.Location = New System.Drawing.Point(1045, 288)
        Me.NewRoomNametxt.Name = "NewRoomNametxt"
        Me.NewRoomNametxt.Size = New System.Drawing.Size(139, 20)
        Me.NewRoomNametxt.TabIndex = 32
        Me.NewRoomNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1066, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Room Name"
        '
        'NewRoomTypetxt
        '
        Me.NewRoomTypetxt.Location = New System.Drawing.Point(1045, 191)
        Me.NewRoomTypetxt.Name = "NewRoomTypetxt"
        Me.NewRoomTypetxt.Size = New System.Drawing.Size(139, 20)
        Me.NewRoomTypetxt.TabIndex = 30
        Me.NewRoomTypetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1066, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Room Type"
        '
        'NewRoomNotxt
        '
        Me.NewRoomNotxt.Location = New System.Drawing.Point(1045, 382)
        Me.NewRoomNotxt.Name = "NewRoomNotxt"
        Me.NewRoomNotxt.Size = New System.Drawing.Size(139, 20)
        Me.NewRoomNotxt.TabIndex = 28
        Me.NewRoomNotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1076, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Room No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 27)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "List of Room"
        '
        'txtroomid
        '
        Me.txtroomid.Location = New System.Drawing.Point(797, 468)
        Me.txtroomid.Name = "txtroomid"
        Me.txtroomid.ReadOnly = True
        Me.txtroomid.Size = New System.Drawing.Size(139, 20)
        Me.txtroomid.TabIndex = 35
        Me.txtroomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(828, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Room ID"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 660)
        Me.Controls.Add(Me.txtroomid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NewRoomNametxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NewRoomTypetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NewRoomNotxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RoomNameReadTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RoomTypeReadtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RoomNumberReadtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RoomListGrid)
        Me.Controls.Add(Me.btnDeleteRoom)
        Me.Controls.Add(Me.btnEditRoom)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        CType(Me.RoomListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents btnEditRoom As Button
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents RoomListGrid As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoomNumberReadtxt As TextBox
    Friend WithEvents RoomTypeReadtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoomNameReadTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NewRoomNametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NewRoomTypetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NewRoomNotxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtroomid As TextBox
    Friend WithEvents Label10 As Label
End Class
