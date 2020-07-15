Imports Microsoft.Build.Framework.XamlTypes

Public Class FormInputSiswa
    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = Not st
        GroupBox2.Enabled = st
        GroupBox3.Enabled = st


    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With tblSiswa.Rows(br)
                TxtKode.Text = .Cells(0).Value.ToString
                txtNISN.Text = .Cells(1).Value.ToString
                txtSiswa.Text = .Cells(2).Value.ToString
                TxtStok.Text = .Cells(3).Value.ToString
            End With
            LblBaris.Text = "Data ke-" & br + 1 & " dari " & tblSiswa.RowCount - 1 & " data"

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        tblSiswa.ClearSelection()
        If baris < DTGrid.Rows.Count - 1 Then baris = baris + 1
        tblSiswa.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tblSiswa.ClearSelection()
        If baris > 0 Then baris = baris - 1
        tblSiswa.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolSiswa.tampilData.ToTable
        tblSiswa.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            tblSiswa.Rows(DTGrid.Rows.Count - 1).Selected = True
            tblSiswa.CurrentCell = tblSiswa.Item(1, baris)
            AturButton(True)
            IsiBox(baris)

        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolSiswa.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            tblSiswa.DataSource = DTGrid
            tblSiswa.Rows(DTGrid.Rows.Count - 1).Selected = True
            tblSiswa.CurrentCell = tblSiswa.Item(1, baris)
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

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblSiswa.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            tblSiswa.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1
        txtNISN.Focus()
        TxtKode.Text = KontrolSiswa.kodeBaru()

        txtNISN.Text = ""
        txtSiswa.Text = ""
        TxtStok.Text = ""


    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        modeProses = 2
        txtNISN.Focus()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        tblSiswa.ClearSelection()
        baris = 0
        tblSiswa.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        tblSiswa.ClearSelection()
        baris = DTGrid.Rows.Count - 1
        tblSiswa.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasSiswa
            .kodeNisn = TxtKode.Text
            .namaSiswas = txtNISN.Text
            .hargaBarang = txtSiswa.Text
            .stokBarang = TxtStok.Text
        End With
        If modeProses = 1 Then
            KontrolSiswa.InsertData(EntitasSiswa)
        ElseIf modeProses = 2 Then
            KontrolSiswa.updateData(EntitasSiswa)

        End If
        MsgBox("data terseimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        KontrolSiswa.deleteData(TxtKode.Text)
        RefreshGrid()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtTTL_TextChanged(sender As Object, e As EventArgs) Handles txtTTL.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
