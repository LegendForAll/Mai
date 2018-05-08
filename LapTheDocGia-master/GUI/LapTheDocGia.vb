Imports DTO
Imports BUS


Public Class frmLapThe

    Private dgBus As DocGiaBUS
    Private Sub bttNhap_Click(sender As Object, e As EventArgs) Handles bttNhap.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        docgia.HoTen = tbHoTen.Text
        docgia.DiaChi = tbDiaChi.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.LoaiDocGia = cbxLoaiDocGia.DisplayMember
        docgia.Email = tbEmail.Text
        docgia.NgayLapThe = dtpNgayLapThe.Value
        docgia.NguoiLapThe = tbNguoiLapThe.Text

        Dim DateTimeNow As DateTime
        DateTimeNow = DateTime.Now

        Dim tuoi As TimeSpan
        Dim age As Integer

        tuoi = DateTimeNow - docgia.NgaySinh
        age = tuoi.TotalDays / 365

        If (age < 18 Or age > 55) Then
            MessageBox.Show("Tuoi doc gia khong hop le")
            dtpNgaySinh.Focus()
            Return
        End If
        Dim dg = dgBus.insert(docgia)
        If (dg = 1) Then
            MessageBox.Show("Thêm độc giả thành thành công")
        Else
            MessageBox.Show("Thêm độc giả thất bại")
        End If
    End Sub

    Private Sub frmLapThe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles tbHoTen.TextChanged

    End Sub
End Class