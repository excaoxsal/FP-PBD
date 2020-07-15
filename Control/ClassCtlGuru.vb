Imports System.Data.OleDb

Public Class ClassCtlGuru : Implements InfProsess

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProsess.InsertData
        Dim data As New ClassEntGuru
        data = Ob

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProsess.updateData
        Dim data As New ClassEntGuru
        data = Ob



        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(Ob As Object) As OleDbCommand Implements InfProsess.deleteData
        Dim data As New ClassEntGuru
        data = Ob


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProsess.tampilData
        Try

            DTA = New OleDbDataAdapter("Select * from GURU", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Table_GURU")
            Dim grid As New DataView(DTS.Tables("Table_GURU"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function idBaru() As String
        Dim baru As String
        Dim idakhir As Integer
        Try
            DTA = New OleDbDataAdapter("Select max(right(id_guru,4)) from guru", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_id")
            idakhir = Val(DTS.Tables("max_id").Rows(0).Item(0))
            baru = "B" & Strings.Right("000" & idakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from GURU where nama_guru - Like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            Dim grid As New DataView(DTS.Tables("Cari_Guru"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
