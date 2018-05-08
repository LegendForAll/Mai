Imports DAL
Imports DTO

Public Class DocGiaBUS
    Private dgDAL As DocgiaDAL
    Public Sub New()
        dgDAL = New DocgiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocgiaDAL(connectionString)
    End Sub

    Public Function insert(dg As DocGiaDTO)
        Return dgDAL.insert(dg)
    End Function

End Class
