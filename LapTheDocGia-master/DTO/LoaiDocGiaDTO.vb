Public Class LoaiDocGiaDTO
    Private i_maLoaiDG As Integer
    Private str_TenLoai As String

    Public Sub New()

    End Sub
    Public Sub New(i_maLoaiDG As Integer, str_TenLoai As String)
        Me.i_maLoaiDG = i_maLoaiDG
        Me.str_TenLoai = str_TenLoai
    End Sub
    Public Property MaLoai_DocGia As Integer
        Get
            Return i_maLoaiDG
        End Get
        Set(value As Integer)
            i_maLoaiDG = value
        End Set
    End Property

    Public Property TenLoaiDocGia As String
        Get
            Return str_TenLoai
        End Get
        Set(value As String)
            str_TenLoai = value
        End Set
    End Property
End Class
