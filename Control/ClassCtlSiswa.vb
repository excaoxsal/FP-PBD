Imports System.Data.OleDb

Public Class ClassCtlSiswa : Implements InfProsess

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProsess.InsertData
        Dim data As New ClassEntSiswa
        data = Ob
        CMD = New OleDbCommand("insert into siswa values('" & data.kodesiswa & "','" _
                               & data.kodeNisn & "','" & data.namaSiswas & "','" & data.jk & "','" _
                               & data.tanggallahir & "','" & data.alamat & "','" & data.nomortel & "','" _
                               & data.email & "','" & data.tahun & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProsess.updateData
        Dim data As New ClassEntSiswa
        data = Ob
        CMD = New OleDbCommand("update siswa set nama_siswa='" & data.namaSiswas & "', jenis_kelamin ='" _
                               & data.jk & "', tgl_lahir='" & data.tanggallahir & "',alamat_siswa = '" & data.alamat & "', no_telp_siswa='" _
                               & data.nomortel & "', email_siswa = '" & data.email & "',th_angkatan = " & data.tahun & " where id_siswa = '" & data.kodesiswa & "'", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProsess.deleteData


        CMD = New OleDbCommand("delete from siswa where id_siswa ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProsess.tampilData
        Try

            DTA = New OleDbDataAdapter("Select * from Siswa", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Table_Siswa")
            Dim grid As New DataView(DTS.Tables("Table_Siswa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("Select max(right(ID_SISWA, 4)) from SISWA", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "S" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from siswa where nama_siswa " _
                                       & "Like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            Dim grid As New DataView(DTS.Tables("Cari_Siswa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekSiswaDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count (id_siswa) from kelas where id_siswa ='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
