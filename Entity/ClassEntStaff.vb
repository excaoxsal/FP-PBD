Public Class ClassEntStaff
    Private id As String 
    Private password As String
    Private nama As String
    Private alamat As String
    Private notelpon As Integer
    Private email As String

    Public Property idStaff() As String
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property
      Public Property passwordStaff() As String
        Get
            Return password
        End Get
        Set
            password = Value
        End Set
    End Property
    Public Property namaStaff() As String
        Get
            Return nama
        End Get
        Set
            nama = Value
        End Set
    End Property
    Public Property alamatStaff() As String
        Get
            Return alamat
        End Get
        Set
            alamat = Value
        End Set
    End Property
    Public Property notelponStaff() As Integer
        Get
            Return notelpon
        End Get
        Set
            notelpon = Value
        End Set
    End Property
      Public Property emailStaff() As String
        Get
            Return email
        End Get
        Set
            email = Value
        End Set
    End Property
End Class

