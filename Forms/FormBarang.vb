Imports Microsoft.Build.Framework.XamlTypes

Public Class FormBarang
    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnUbah.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = Not st
        BtnBatal.Enabled = Not st

        GroupBox1.Enabled = Not st
        GroupBox2.Enabled = st
        GroupBox3.Enabled = st


    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                TxtKode.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(1).Value.ToString
                TxtHarga.Text = .Cells(2).Value.ToString
                TxtStok.Text = .Cells(3).Value.ToString
            End With
            LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGBarang.RowCount - 1 & " data"

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        DGBarang.ClearSelection()
        If baris < DTGrid.Rows.Count - 1 Then baris = baris + 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        DGBarang.ClearSelection()
        If baris > 0 Then baris = baris - 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(True)
            IsiBox(baris)

        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ada")
            RefreshGrid()
        End If
    End Sub
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        TxtKode.Enabled = False
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles BtnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        modeProses = 1
        TxtNama.Focus()
        TxtKode.Text = KontrolBarang.kodeBaru()

        TxtNama.Text = ""
        TxtHarga.Text = ""
        TxtStok.Text = ""


    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        modeProses = 2
        TxtNama.Focus()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        DGBarang.ClearSelection()
        baris = 0
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        DGBarang.ClearSelection()
        baris = DTGrid.Rows.Count - 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCari.Text)
            TxtCari.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasBarang
            .kodeBarang = TxtKode.Text
            .namaBarang = TxtNama.Text
            .hargaBarang = TxtHarga.Text
            .stokBarang = TxtStok.Text
        End With
        If modeProses = 1 Then
            KontrolBarang.InsertData(EntitasBarang)
        ElseIf modeProses = 2 Then
            KontrolBarang.updateData(EntitasBarang)

        End If
        MsgBox("data terseimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        KontrolBarang.deleteData(TxtKode.Text)
        RefreshGrid()
    End Sub
End Class
