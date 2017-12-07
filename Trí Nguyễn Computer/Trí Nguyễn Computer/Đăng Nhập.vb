Public Class Dang_Nhap

    Private Sub ButtonDangNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDangNhap.Click
        If TextBoxTaiKhoan.Text = "" OrElse TextBoxMatKhau.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxTaiKhoan.Text = "TriNguyen" AndAlso TextBoxMatKhau.Text = "123456" Then
                MessageBox.Show("Chúc Mừng Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Home.Show()
                Me.Hide()
            Else
                If TextBoxTaiKhoan.Text = "SinhVien" AndAlso TextBoxMatKhau.Text = "sinhvien" Then
                    MessageBox.Show("Chúc Mừng Sinh Viên Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Home.Show()
                    Home.ThongTinUngDungToolStripMenuItem.Enabled = False
                    Me.Hide()
                Else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class