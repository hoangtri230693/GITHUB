Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ThongTinKhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinKhachHangToolStripMenuItem.Click
        Thông_Tin_Khách_Hàng.Show()
        Me.Hide()
    End Sub
    Private Sub TimKiemKhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimKiemKhachHangToolStripMenuItem.Click
        Tim_Kiem_Thong_Tin_Khach_Hang.Show()
        Me.Hide()
    End Sub
    Private Sub CapNhatKhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapNhatKhachHangToolStripMenuItem.Click
        Cap_Nhat_Thong_Tin_Khach_Hang.Show()
        Me.Hide()
    End Sub
    Private Sub ThôngTinSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinSanPhamToolStripMenuItem.Click
        Thong_Tin_San_Pham.Show()
        Me.Hide()
    End Sub
    Private Sub CapNhatSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapNhatSanPhamToolStripMenuItem.Click
        Cap_Nhat_San_Pham.Show()
        Me.Hide()
    End Sub
    Private Sub HoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoaDonToolStripMenuItem.Click
        Chi_Tiet_Hoa_Don.Show()
        Me.Hide()
    End Sub
    Private Sub ThongTinUngDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinUngDungToolStripMenuItem.Click
        Thong_Tin_Ung_Dung.Show()
    End Sub
    Private Sub DangXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangXuatToolStripMenuItem.Click
        Dang_Nhap.Show()
        Me.Hide()
    End Sub
    Private Sub ThoatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class