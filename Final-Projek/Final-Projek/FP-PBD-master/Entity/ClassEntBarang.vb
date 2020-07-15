Public Class ClassEntBarang
    Private kode As String
    Private nama As String
    Private harga As Integer
    Private stok As Integer
    Private _kodeBarang As String
    Private _namaBarang As String
    Private _hargaBarang As String
    Private _stokBarang As String

    Public Property kodeBarang() As String
        Get
            Return kode
        End Get
        Set
            kode = Value
        End Set
    End Property
    Public Property namaBarang() As String
        Get
            Return nama
        End Get
        Set
            nama = Value
        End Set
    End Property
    Public Property hargaBarang As String
        Get
            Return harga
        End Get
        Set
            harga = Value
        End Set
    End Property
    Public Property stokBarang As String
        Get
            Return stok
        End Get
        Set
            stok = Value
        End Set
    End Property
End Class

