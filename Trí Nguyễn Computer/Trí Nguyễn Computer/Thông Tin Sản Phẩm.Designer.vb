<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thong_Tin_San_Pham
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMaSanPham = New System.Windows.Forms.Label()
        Me.lblTenSanPham = New System.Windows.Forms.Label()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblDonViTinh = New System.Windows.Forms.Label()
        Me.lblLoaiSanPham = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 274)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(801, 228)
        Me.DataGridView1.TabIndex = 1
        '
        'lblMaSanPham
        '
        Me.lblMaSanPham.AutoSize = True
        Me.lblMaSanPham.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaSanPham.ForeColor = System.Drawing.Color.Red
        Me.lblMaSanPham.Location = New System.Drawing.Point(31, 24)
        Me.lblMaSanPham.Name = "lblMaSanPham"
        Me.lblMaSanPham.Size = New System.Drawing.Size(108, 19)
        Me.lblMaSanPham.TabIndex = 2
        Me.lblMaSanPham.Text = "Mã Sản Phẩm:"
        '
        'lblTenSanPham
        '
        Me.lblTenSanPham.AutoSize = True
        Me.lblTenSanPham.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenSanPham.ForeColor = System.Drawing.Color.Red
        Me.lblTenSanPham.Location = New System.Drawing.Point(31, 72)
        Me.lblTenSanPham.Name = "lblTenSanPham"
        Me.lblTenSanPham.Size = New System.Drawing.Size(110, 19)
        Me.lblTenSanPham.TabIndex = 2
        Me.lblTenSanPham.Text = "Tên Sản Phẩm:"
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGia.ForeColor = System.Drawing.Color.Red
        Me.lblDonGia.Location = New System.Drawing.Point(68, 118)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(71, 19)
        Me.lblDonGia.TabIndex = 2
        Me.lblDonGia.Text = "Đơn Giá:"
        '
        'lblDonViTinh
        '
        Me.lblDonViTinh.AutoSize = True
        Me.lblDonViTinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonViTinh.ForeColor = System.Drawing.Color.Red
        Me.lblDonViTinh.Location = New System.Drawing.Point(471, 24)
        Me.lblDonViTinh.Name = "lblDonViTinh"
        Me.lblDonViTinh.Size = New System.Drawing.Size(96, 19)
        Me.lblDonViTinh.TabIndex = 2
        Me.lblDonViTinh.Text = "Đơn Vị Tính:"
        '
        'lblLoaiSanPham
        '
        Me.lblLoaiSanPham.AutoSize = True
        Me.lblLoaiSanPham.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblLoaiSanPham.ForeColor = System.Drawing.Color.Red
        Me.lblLoaiSanPham.Location = New System.Drawing.Point(453, 72)
        Me.lblLoaiSanPham.Name = "lblLoaiSanPham"
        Me.lblLoaiSanPham.Size = New System.Drawing.Size(114, 19)
        Me.lblLoaiSanPham.TabIndex = 2
        Me.lblLoaiSanPham.Text = "Loại Sản Phẩm:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(219, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(145, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(219, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(573, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(219, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(573, 73)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(219, 20)
        Me.TextBox5.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "I<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(327, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 37)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = ">I"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(430, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Quay Lại"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Thong_Tin_San_Pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 514)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.lblTenSanPham)
        Me.Controls.Add(Me.lblLoaiSanPham)
        Me.Controls.Add(Me.lblDonViTinh)
        Me.Controls.Add(Me.lblMaSanPham)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Thong_Tin_San_Pham"
        Me.Text = "Thông Tin Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMaSanPham As System.Windows.Forms.Label
    Friend WithEvents lblTenSanPham As System.Windows.Forms.Label
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblDonViTinh As System.Windows.Forms.Label
    Friend WithEvents lblLoaiSanPham As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
