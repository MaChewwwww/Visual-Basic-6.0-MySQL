<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApprovedRequestList
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
        Me.GridApprovedList = New System.Windows.Forms.DataGridView()
        CType(Me.GridApprovedList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridApprovedList
        '
        Me.GridApprovedList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridApprovedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridApprovedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridApprovedList.Location = New System.Drawing.Point(1, 1)
        Me.GridApprovedList.Name = "GridApprovedList"
        Me.GridApprovedList.ReadOnly = True
        Me.GridApprovedList.Size = New System.Drawing.Size(1102, 654)
        Me.GridApprovedList.TabIndex = 0
        '
        'ApprovedRequestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 655)
        Me.Controls.Add(Me.GridApprovedList)
        Me.Name = "ApprovedRequestList"
        Me.Text = "ApprovedRequestList"
        CType(Me.GridApprovedList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridApprovedList As DataGridView
End Class
