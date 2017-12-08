<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tim_Kiem_Thong_Tin_Khach_Hang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tim_Kiem_Thong_Tin_Khach_Hang))
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtBangDuLieu = New System.Windows.Forms.DataGridView()
        Me.ButtonQuayLai = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBangDuLieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimKiem
        '
        resources.ApplyResources(Me.lblTimKiem, "lblTimKiem")
        Me.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimKiem.Name = "lblTimKiem"
        '
        'TextBoxSearch
        '
        resources.ApplyResources(Me.TextBoxSearch, "TextBoxSearch")
        Me.TextBoxSearch.Name = "TextBoxSearch"
        '
        'ButtonSearch
        '
        resources.ApplyResources(Me.ButtonSearch, "ButtonSearch")
        Me.ButtonSearch.ForeColor = System.Drawing.Color.Red
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'dtBangDuLieu
        '
        Me.dtBangDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dtBangDuLieu, "dtBangDuLieu")
        Me.dtBangDuLieu.Name = "dtBangDuLieu"
        '
        'ButtonQuayLai
        '
        resources.ApplyResources(Me.ButtonQuayLai, "ButtonQuayLai")
        Me.ButtonQuayLai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonQuayLai.Name = "ButtonQuayLai"
        Me.ButtonQuayLai.UseVisualStyleBackColor = True
        '
        'Tim_Kiem_Thong_Tin_Khach_Hang
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonQuayLai)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Controls.Add(Me.dtBangDuLieu)
        Me.Name = "Tim_Kiem_Thong_Tin_Khach_Hang"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBangDuLieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimKiem As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dtBangDuLieu As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonQuayLai As System.Windows.Forms.Button

End Class
