Public Class ClassEntPembayaran
    Private id As String 
    Private nama As String
    Private total As Integer

    Public Property idPembayaran() As String
        Get
            Return id
        End Get
        Set
            id = Value
        End Set
    End Property
    Public Property namaPembayaran() As String
        Get
            Return nama
        End Get
        Set
            nama = Value
        End Set
    End Property
    Public Property totalPembayaran() As String
        Get
            Return total
        End Get
        Set
            total = Value
        End Set
    End Property
End Class

