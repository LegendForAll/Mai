Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class LoaiDocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub



    Public Function insert(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia])"
        query &= "VALUES (@MaLoaiDocGia,@TenLoaiDocGia)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDocGia", ldg.MaLoai_DocGia)
                    .Parameters.AddWithValue("@TenLoaiDocGia", ldg.TenLoaiDocGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm học sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLoaiDocGia], [TenLoaiDocGia]"
        query &= " FROM [tblLoaiDocGia]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiDG.Clear()
                        While reader.Read()
                            listLoaiDG.Add(New LoaiDocGiaDTO(reader("MaLoaiDocGia"), reader("TenLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Get the reader list unsuccessful", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
