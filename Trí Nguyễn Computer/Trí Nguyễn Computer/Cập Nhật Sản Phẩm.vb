Public Class Cap_Nhat_San_Pham
    'Khai bao bien de truy xuat DB tu lop DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Dinh nghia thu tuc load du lieu tu bang Loai_SP vao ComboBoxMaLoai
    Private Sub LoadDataOnComboBox()
        Dim sqlQuery As String = "SELECT [MaLoai_SP], [TenLoaiSP] FROM [dbo].[Loai_SP]"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.ComboBoxMaLoai.DataSource = dTable
        Me.ComboBoxMaLoai.ValueMember = "[MaLoai_SP]"
        Me.ComboBoxMaLoai.DisplayMember = "[TenLoaiSP]"
    End Sub

    Private Sub Cap_Nhat_San_Pham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnComboBox()
    End Sub
End Class