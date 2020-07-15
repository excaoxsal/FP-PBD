Public Class ClassEntJurusan
    Private id As String 
    Private nama As String

    Public Property idJurusan() As String
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property
    Public Property namaJurusan() As String
        Get
            Return nama
        End Get
        Set
            nama = Value
        End Set
    End Property
End Class

