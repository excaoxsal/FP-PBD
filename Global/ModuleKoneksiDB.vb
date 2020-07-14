Imports System.Data.OleDb

Module ModuleKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Data Source=Excalimoon;Integrated Security=SSPI;Initial Catalog=E:\MY DATA\TUGAS\PBD\PBD\18.12.0895\DB\DB_PENJUALAN_0895.MDF"
    Public koneksi As New OleDbConnection(strKon)
    Public Function BUKAKONEKSI() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return koneksi
    End Function
    Public Function TUTUPKONEKSI() As OleDbConnection
        koneksi.Close()
        Return koneksi

    End Function
End Module
