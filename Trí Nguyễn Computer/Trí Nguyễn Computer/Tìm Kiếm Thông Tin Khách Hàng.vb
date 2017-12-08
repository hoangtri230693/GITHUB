Public Class Tim_Kiem_Thong_Tin_Khach_Hang

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxSearch.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Khách Hàng")
        Else
            Dim sql As String =
             <sql>
                 select * from Khach_Hang
                 where HoTen Like N'%{0}%'
             </sql>
            sql = String.Format(sql, TextBoxSearch.Text)
            thucthi(sql, "Search")
            dgv3.DataSource = ds.Tables("Search")
        End If

    End Sub

End Class
