Imports System.Data.SqlClient
Imports System.Configuration
Imports DTO
Imports Utility


Public Class DocgiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildIDStudent(ByRef nextID As String) As Result
        nextID = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextID = x + "000000"


        Dim query As String = String.Empty
        query &= "Select TOP 1 [maDocGia] "
        query &= "From [tblDocGia] "
        query &= "Order By [maDocGia] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("[maDocGia")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextID = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextID = nextID + tmp
                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Automatically retrieves the next Student Number without success", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dg As DocGiaDTO) As Result

        'Dim query As String = String.Empty
        'query &= "INSERT INTO [dbo].[dbo.tblDocGia]([HoTen],[LoaiDocGia],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NguoiLapThe])"
        'query &= "VALUES (@HoTen,@LoaiDocGia,@NgaySinh, @DiaChi, @Email, @NgayLapThe,@NguoiLapThe)"

        'Using conn As New SqlConnection(connectionString)
        '    Using comm As New SqlCommand()
        '        With comm
        '            .Connection = conn
        '            .CommandType = CommandType.Text
        '            .CommandText = query
        '            .Parameters.AddWithValue("@HoTen", dg.HoTen)
        '            .Parameters.AddWithValue("@LoaiDocGia", dg.LoaiDocGia)
        '            .Parameters.AddWithValue("@NgaySinh", dg.NgaySinh)
        '            .Parameters.AddWithValue("@DiaChi", dg.DiaChi)
        '            .Parameters.AddWithValue("@Email", dg.Email)
        '            .Parameters.AddWithValue("@NgayLapThe", dg.NgayLapThe)
        '            .Parameters.AddWithValue("@NguoiLapThe", dg.NguoiLapThe)
        '        End With
        '        Try
        '            conn.Open()
        '            comm.ExecuteNonQuery()
        '        Catch ex As Exception
        '            conn.Close()
        '            System.Console.WriteLine(ex.StackTrace)
        '            Return 0
        '        End Try
        '    End Using
        'End Using
        'Return 1
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia] ([maDocGia], [LoaiDocGia], [HoTen], [DiaChi], [NgaySinh],[Email],[NgayLapThe],[NguoiLapThe])"
        'sai fix
        query &= "VALUES (@maDocGia,@LoaiDocGia,@HoTen,@DiaChi,@NgaySinh,@Email,@NgayLapThe,@NguoiLapThe)"

        'get MSHS
        Dim nextID = "1"
        buildIDStudent(nextID)
        dg.MaDocGia = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_Readers", dg.MaDocGia)
                    .Parameters.AddWithValue("@Id_typeReaders", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@Name_Readers", dg.HoTen)
                    .Parameters.AddWithValue("@Address", dg.DiaChi)
                    .Parameters.AddWithValue("@Birthday", dg.NgaySinh)
                    'them Email/Card date/ID Employee
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Card_Date", dg.NgayLapThe)
                    .Parameters.AddWithValue("@Id_Employee", dg.NguoiLapThe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Add Reader unsuccessful", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listStudent As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [tblDocGia] ([maDocGia], [LoaiDocGia], [HoTen], [DiaChi], [NgaySinh],[Email],[NgayLapThe],[NguoiLapThe]"
        query &= "FROM [tblDocGia]"


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
                        listStudent.Clear()
                        While reader.Read()
                            listStudent.Add(New DocGiaDTO(reader("maDocGia"), reader("LoaiDocGia"), reader("HoTen"), reader("DiaChi"), reader("NgaySinh"), reader("Email"), reader("NgayLapThe"), reader("NguoiLapThe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Takes all Students unsuccessful", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
