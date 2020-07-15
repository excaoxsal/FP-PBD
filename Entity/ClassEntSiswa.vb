Public Class ClassEntSiswa
    Private idsiswa As String
    Private nisn As String
    Private namasiswa As String
    Private alamatsiswa As String
    Private jeniskelamin As String
    Private notelp As Integer
    Private emailsiswa As String
    Private th_angkatan As Integer
    Private harga As Integer
    Private stok As Integer
    Private _kodeBarang As String
    Private _namaBarang As String
    Private _hargaBarang As String
    Private _stokBarang As String

    Public Property kodeNisn() As String
        Get
            Return nisn
        End Get
        Set
            nisn = Value
        End Set
    End Property
    Public Property kodesiswa() As String
        Get
            Return idsiswa
        End Get
        Set
            idsiswa = Value
        End Set
    End Property
    Public Property namaSiswas() As String
        Get
            Return namasiswa
        End Get
        Set
            namasiswa = Value
        End Set
    End Property
    Public Property alamat() As String
        Get
            Return alamatsiswa
        End Get
        Set
            alamatsiswa = Value
        End Set
    End Property
    Public Property nomortel() As Integer
        Get
            Return notelp
        End Get
        Set
            notelp = Value
        End Set
    End Property
    Public Property email() As String
        Get
            Return emailsiswa
        End Get
        Set
            emailsiswa = Value
        End Set
    End Property
    Public Property tahun() As String
        Get
            Return th_angkatan
        End Get
        Set
            th_angkatan = Value
        End Set
    End Property
End Class

