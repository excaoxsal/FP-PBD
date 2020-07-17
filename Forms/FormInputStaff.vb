Public Class FormInputStaff
    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With tblStaff.Rows(br)
                txtNIK.Text = .Cells(0).Value.ToString
                txtStaff.Text = .Cells(1).Value.ToString
                txtTelepon.Text = .Cells(2).Value.ToString
                txtAlamat.Text = .Cells(3).Value.ToString
            End With
            LblBaris.Text = "Data ke-" & br + 1 & " dari " & tblStaff.RowCount - 1 & " data"

        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolStaff.tampilData.ToTable
        tblStaff.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            tblStaff.Rows(DTGrid.Rows.Count - 1).Selected = True
            tblStaff.CurrentCell = tblStaff.Item(1, baris)
            AturButton(True)
            IsiBox(baris)

        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtNIK.Enabled = False
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GBCari.Enter

    End Sub

    Private Sub DGBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblStaff.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBInput.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GBTombol.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub



    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1
        AturButton(False)
        txtNIK.Focus()
        txtStaff.Text = KontrolStaff.idBaru()

        txtNIK.Text = ""
        txtStaff.Text = ""
        txtPassword.Text = ""
        txtTelepon.Text = ""
        txtAlamat.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        tblStaff.ClearSelection()
        baris = 0
        tblStaff.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        tblStaff.ClearSelection()
        If baris < DTGrid.Rows.Count - 1 Then baris = baris + 1
        tblStaff.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tblStaff.ClearSelection()
        If baris > 0 Then baris = baris - 1
        tblStaff.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        tblStaff.ClearSelection()
        baris = DTGrid.Rows.Count - 1
        tblStaff.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub
End Class