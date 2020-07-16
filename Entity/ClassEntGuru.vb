Public Class ClassEntGuru
    Private id As String 
    Private nama As String
    Private alamat As String
    Private notelpon As Integer
    Private email As String
    Private jabatan As String

    Public Property idGuru() As String
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property
    Public Property namaGuru() As String
        Get
            Return nama
        End Get
        Set
            nama = Value
        End Set
    End Property
    Public Property alamatGuru() As String
        Get
            Return alamat
        End Get
        Set
            alamat = Value
        End Set
    End Property
    Public Property notelponGuru() As Integer
        Get
            Return notelpon
        End Get
        Set
            notelpon = Value
        End Set
    End Property
      Public Property emailGuru() As String
        Get
            Return email
        End Get
        Set
            email = Value
        End Set
    End Property
    Public Property jabatanGuru() As String
        Get
            Return jabatan
        End Get
        Set
            jabatan = Value
        End Set
    End Property
End Class

