<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapThe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapThe))
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbLoaiDocGia = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNgayLapThe = New System.Windows.Forms.Label()
        Me.lbNguoiLapThe = New System.Windows.Forms.Label()
        Me.tbHoTen = New System.Windows.Forms.TextBox()
        Me.cbxLoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.tbNguoiLapThe = New System.Windows.Forms.TextBox()
        Me.bttNhap = New System.Windows.Forms.Button()
        Me.tbMaDocGia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Location = New System.Drawing.Point(83, 54)
        Me.lbHoTen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(46, 13)
        Me.lbHoTen.TabIndex = 0
        Me.lbHoTen.Text = "Họ Tên:"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Location = New System.Drawing.Point(83, 161)
        Me.lbDiaChi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(44, 13)
        Me.lbDiaChi.TabIndex = 1
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(83, 124)
        Me.lbNgaySinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(59, 13)
        Me.lbNgaySinh.TabIndex = 2
        Me.lbNgaySinh.Text = "Ngày Sinh:"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(82, 90)
        Me.lbLoaiDocGia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(72, 13)
        Me.lbLoaiDocGia.TabIndex = 3
        Me.lbLoaiDocGia.Text = "Loại Độc Giả:"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(83, 196)
        Me.lbEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(35, 13)
        Me.lbEmail.TabIndex = 4
        Me.lbEmail.Text = "Email:"
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.Location = New System.Drawing.Point(83, 232)
        Me.lbNgayLapThe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(78, 13)
        Me.lbNgayLapThe.TabIndex = 5
        Me.lbNgayLapThe.Text = "Ngày Lập Thẻ:"
        '
        'lbNguoiLapThe
        '
        Me.lbNguoiLapThe.AutoSize = True
        Me.lbNguoiLapThe.Location = New System.Drawing.Point(83, 269)
        Me.lbNguoiLapThe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNguoiLapThe.Name = "lbNguoiLapThe"
        Me.lbNguoiLapThe.Size = New System.Drawing.Size(81, 13)
        Me.lbNguoiLapThe.TabIndex = 6
        Me.lbNguoiLapThe.Text = "Người Lập Thẻ:"
        '
        'tbHoTen
        '
        Me.tbHoTen.Location = New System.Drawing.Point(192, 50)
        Me.tbHoTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(275, 20)
        Me.tbHoTen.TabIndex = 7
        '
        'cbxLoaiDocGia
        '
        Me.cbxLoaiDocGia.FormattingEnabled = True
        Me.cbxLoaiDocGia.Items.AddRange(New Object() {"X", "Y"})
        Me.cbxLoaiDocGia.Location = New System.Drawing.Point(192, 84)
        Me.cbxLoaiDocGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxLoaiDocGia.Name = "cbxLoaiDocGia"
        Me.cbxLoaiDocGia.Size = New System.Drawing.Size(82, 21)
        Me.cbxLoaiDocGia.TabIndex = 8
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(192, 120)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(212, 20)
        Me.dtpNgaySinh.TabIndex = 9
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(192, 157)
        Me.tbDiaChi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(275, 20)
        Me.tbDiaChi.TabIndex = 10
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(192, 192)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(275, 20)
        Me.tbEmail.TabIndex = 11
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(192, 228)
        Me.dtpNgayLapThe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(212, 20)
        Me.dtpNgayLapThe.TabIndex = 12
        '
        'tbNguoiLapThe
        '
        Me.tbNguoiLapThe.Location = New System.Drawing.Point(192, 265)
        Me.tbNguoiLapThe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbNguoiLapThe.Name = "tbNguoiLapThe"
        Me.tbNguoiLapThe.Size = New System.Drawing.Size(275, 20)
        Me.tbNguoiLapThe.TabIndex = 13
        '
        'bttNhap
        '
        Me.bttNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttNhap.Location = New System.Drawing.Point(232, 326)
        Me.bttNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttNhap.Name = "bttNhap"
        Me.bttNhap.Size = New System.Drawing.Size(107, 28)
        Me.bttNhap.TabIndex = 14
        Me.bttNhap.Text = "Nhập"
        Me.bttNhap.UseVisualStyleBackColor = True
        '
        'tbMaDocGia
        '
        Me.tbMaDocGia.Location = New System.Drawing.Point(192, 11)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.ReadOnly = True
        Me.tbMaDocGia.Size = New System.Drawing.Size(275, 20)
        Me.tbMaDocGia.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Mã đọc giả:"
        '
        'frmLapThe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 378)
        Me.Controls.Add(Me.tbMaDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttNhap)
        Me.Controls.Add(Me.tbNguoiLapThe)
        Me.Controls.Add(Me.dtpNgayLapThe)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.cbxLoaiDocGia)
        Me.Controls.Add(Me.tbHoTen)
        Me.Controls.Add(Me.lbNguoiLapThe)
        Me.Controls.Add(Me.lbNgayLapThe)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbLoaiDocGia)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbHoTen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmLapThe"
        Me.Text = "Lập Thẻ Độc Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbLoaiDocGia As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbNgayLapThe As Label
    Friend WithEvents lbNguoiLapThe As Label
    Friend WithEvents tbHoTen As TextBox
    Friend WithEvents cbxLoaiDocGia As ComboBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents tbNguoiLapThe As TextBox
    Friend WithEvents bttNhap As Button
    Friend WithEvents tbMaDocGia As TextBox
    Friend WithEvents Label1 As Label
End Class
