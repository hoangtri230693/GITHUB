<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinKhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimKiemKhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapNhatKhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapNhatSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeThongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DangXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinUngDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Điện Toán Đám Mây - INF205 - PT12201"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(223, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nguyễn Hoàng Trí - PS01940"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(233, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Xin chào thầy và các bạn!"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(565, 104)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(305, 99)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhachHangToolStripMenuItem, Me.SanPhamToolStripMenuItem, Me.HoaDonToolStripMenuItem, Me.HeThongToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThongTinKhachHangToolStripMenuItem, Me.TimKiemKhachHangToolStripMenuItem, Me.CapNhatKhachHangToolStripMenuItem})
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KhachHangToolStripMenuItem.Text = "Khách Hàng"
        '
        'ThongTinKhachHangToolStripMenuItem
        '
        Me.ThongTinKhachHangToolStripMenuItem.Image = CType(resources.GetObject("ThongTinKhachHangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThongTinKhachHangToolStripMenuItem.Name = "ThongTinKhachHangToolStripMenuItem"
        Me.ThongTinKhachHangToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ThongTinKhachHangToolStripMenuItem.Text = "Thông Tin Khách Hàng"
        '
        'TimKiemKhachHangToolStripMenuItem
        '
        Me.TimKiemKhachHangToolStripMenuItem.Image = CType(resources.GetObject("TimKiemKhachHangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TimKiemKhachHangToolStripMenuItem.Name = "TimKiemKhachHangToolStripMenuItem"
        Me.TimKiemKhachHangToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TimKiemKhachHangToolStripMenuItem.Text = "Tìm Kiếm Khách Hàng"
        '
        'CapNhatKhachHangToolStripMenuItem
        '
        Me.CapNhatKhachHangToolStripMenuItem.Image = CType(resources.GetObject("CapNhatKhachHangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CapNhatKhachHangToolStripMenuItem.Name = "CapNhatKhachHangToolStripMenuItem"
        Me.CapNhatKhachHangToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CapNhatKhachHangToolStripMenuItem.Text = "Cập Nhật Khách Hàng"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThongTinSanPhamToolStripMenuItem, Me.CapNhatSanPhamToolStripMenuItem})
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SanPhamToolStripMenuItem.Text = "Sản Phẩm"
        '
        'ThongTinSanPhamToolStripMenuItem
        '
        Me.ThongTinSanPhamToolStripMenuItem.Image = CType(resources.GetObject("ThongTinSanPhamToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThongTinSanPhamToolStripMenuItem.Name = "ThongTinSanPhamToolStripMenuItem"
        Me.ThongTinSanPhamToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ThongTinSanPhamToolStripMenuItem.Text = "Thông Tin Sản Phẩm"
        '
        'CapNhatSanPhamToolStripMenuItem
        '
        Me.CapNhatSanPhamToolStripMenuItem.Image = CType(resources.GetObject("CapNhatSanPhamToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CapNhatSanPhamToolStripMenuItem.Name = "CapNhatSanPhamToolStripMenuItem"
        Me.CapNhatSanPhamToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CapNhatSanPhamToolStripMenuItem.Text = "Cập Nhật Sản Phẩm"
        '
        'HoaDonToolStripMenuItem
        '
        Me.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem"
        Me.HoaDonToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HoaDonToolStripMenuItem.Text = "Hóa Đơn"
        '
        'HeThongToolStripMenuItem
        '
        Me.HeThongToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangXuatToolStripMenuItem, Me.ThoatToolStripMenuItem, Me.ThongTinUngDungToolStripMenuItem})
        Me.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem"
        Me.HeThongToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HeThongToolStripMenuItem.Text = "Hệ Thống"
        '
        'DangXuatToolStripMenuItem
        '
        Me.DangXuatToolStripMenuItem.Image = CType(resources.GetObject("DangXuatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem"
        Me.DangXuatToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DangXuatToolStripMenuItem.Text = "Đăng Xuất"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Image = CType(resources.GetObject("ThoatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ThoatToolStripMenuItem.Text = "Thoát"
        '
        'ThongTinUngDungToolStripMenuItem
        '
        Me.ThongTinUngDungToolStripMenuItem.Image = CType(resources.GetObject("ThongTinUngDungToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThongTinUngDungToolStripMenuItem.Name = "ThongTinUngDungToolStripMenuItem"
        Me.ThongTinUngDungToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ThongTinUngDungToolStripMenuItem.Text = "Thông Tin Ứng Dụng"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 401)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThongTinKhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimKiemKhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapNhatKhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThongTinSanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapNhatSanPhamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoaDonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HeThongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DangXuatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThongTinUngDungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
