Public Class Thong_Tin_Khach_Hang
    'Load'
    Private Sub Thong_Tin_Khach_Hang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String =
            <sql>
                select * from Khach_Hang
            </sql>
        thucthi(sql, "KhachHang")
        bs.Datasource = ds.Tables("KhachHang")
        dgv1.Datasource = bs
        bs.ResetBindings(False)
    End Sub
End Class