<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnAddProduct
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
        Me.imgProduct = New System.Windows.Forms.PictureBox()
        Me.txtproductname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.numProductStock = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numProductPrice = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.imgProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProductStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProductPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgProduct
        '
        Me.imgProduct.Location = New System.Drawing.Point(33, 26)
        Me.imgProduct.Name = "imgProduct"
        Me.imgProduct.Size = New System.Drawing.Size(118, 81)
        Me.imgProduct.TabIndex = 0
        Me.imgProduct.TabStop = False
        '
        'txtproductname
        '
        Me.txtproductname.Location = New System.Drawing.Point(176, 50)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(449, 23)
        Me.txtproductname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Description :"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(178, 119)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(450, 106)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(33, 119)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(118, 40)
        Me.btnAddImage.TabIndex = 5
        Me.btnAddImage.Text = "Add Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'numProductStock
        '
        Me.numProductStock.Location = New System.Drawing.Point(33, 202)
        Me.numProductStock.Name = "numProductStock"
        Me.numProductStock.Size = New System.Drawing.Size(120, 23)
        Me.numProductStock.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Stock :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Product Price :"
        '
        'numProductPrice
        '
        Me.numProductPrice.DecimalPlaces = 2
        Me.numProductPrice.Location = New System.Drawing.Point(33, 277)
        Me.numProductPrice.Name = "numProductPrice"
        Me.numProductPrice.Size = New System.Drawing.Size(120, 23)
        Me.numProductPrice.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 115)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Add Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numProductPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numProductStock)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.imgProduct)
        Me.Name = "btnAddProduct"
        Me.Text = "Form1"
        CType(Me.imgProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProductStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProductPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgProduct As PictureBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnAddImage As Button
    Public WithEvents numProductStock As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents numProductPrice As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
