﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputGuru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GBIsidata = New System.Windows.Forms.GroupBox()
        Me.TxtJabatan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdGuru = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotelp = New System.Windows.Forms.TextBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.txtNamaGuru = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBBtn = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.tblSiswa = New System.Windows.Forms.DataGridView()
        Me.GBCari = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.GBNavigasi = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GBIsidata.SuspendLayout()
        Me.GBBtn.SuspendLayout()
        CType(Me.tblSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCari.SuspendLayout()
        Me.GBNavigasi.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBIsidata
        '
        Me.GBIsidata.Controls.Add(Me.TxtJabatan)
        Me.GBIsidata.Controls.Add(Me.Label9)
        Me.GBIsidata.Controls.Add(Me.txtIdGuru)
        Me.GBIsidata.Controls.Add(Me.Label6)
        Me.GBIsidata.Controls.Add(Me.Label1)
        Me.GBIsidata.Controls.Add(Me.txtAlamat)
        Me.GBIsidata.Controls.Add(Me.Label8)
        Me.GBIsidata.Controls.Add(Me.txtEmail)
        Me.GBIsidata.Controls.Add(Me.Label7)
        Me.GBIsidata.Controls.Add(Me.txtNotelp)
        Me.GBIsidata.Controls.Add(Me.rbPerempuan)
        Me.GBIsidata.Controls.Add(Me.rbLaki)
        Me.GBIsidata.Controls.Add(Me.txtNamaGuru)
        Me.GBIsidata.Controls.Add(Me.txtNIK)
        Me.GBIsidata.Controls.Add(Me.Label4)
        Me.GBIsidata.Controls.Add(Me.Label3)
        Me.GBIsidata.Controls.Add(Me.Label2)
        Me.GBIsidata.Location = New System.Drawing.Point(12, 68)
        Me.GBIsidata.Name = "GBIsidata"
        Me.GBIsidata.Size = New System.Drawing.Size(427, 218)
        Me.GBIsidata.TabIndex = 0
        Me.GBIsidata.TabStop = False
        '
        'TxtJabatan
        '
        Me.TxtJabatan.Location = New System.Drawing.Point(162, 177)
        Me.TxtJabatan.Name = "TxtJabatan"
        Me.TxtJabatan.Size = New System.Drawing.Size(250, 20)
        Me.TxtJabatan.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Jabatan"
        '
        'txtIdGuru
        '
        Me.txtIdGuru.Location = New System.Drawing.Point(162, 8)
        Me.txtIdGuru.Name = "txtIdGuru"
        Me.txtIdGuru.Size = New System.Drawing.Size(250, 20)
        Me.txtIdGuru.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ID Guru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "E-mail"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(162, 151)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(250, 20)
        Me.txtAlamat.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Alamat"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 125)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 20)
        Me.txtEmail.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No Telpon"
        '
        'txtNotelp
        '
        Me.txtNotelp.Location = New System.Drawing.Point(162, 99)
        Me.txtNotelp.Name = "txtNotelp"
        Me.txtNotelp.Size = New System.Drawing.Size(250, 20)
        Me.txtNotelp.TabIndex = 10
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(239, 80)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbPerempuan.TabIndex = 8
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(162, 80)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(64, 17)
        Me.rbLaki.TabIndex = 7
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'txtNamaGuru
        '
        Me.txtNamaGuru.Location = New System.Drawing.Point(162, 57)
        Me.txtNamaGuru.Name = "txtNamaGuru"
        Me.txtNamaGuru.Size = New System.Drawing.Size(250, 20)
        Me.txtNamaGuru.TabIndex = 6
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(162, 32)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(250, 20)
        Me.txtNIK.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Guru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'GBBtn
        '
        Me.GBBtn.Controls.Add(Me.btnBatal)
        Me.GBBtn.Controls.Add(Me.btnSimpan)
        Me.GBBtn.Controls.Add(Me.btnHapus)
        Me.GBBtn.Controls.Add(Me.btnUbah)
        Me.GBBtn.Controls.Add(Me.btnTambah)
        Me.GBBtn.Location = New System.Drawing.Point(445, 79)
        Me.GBBtn.Name = "GBBtn"
        Me.GBBtn.Size = New System.Drawing.Size(218, 166)
        Me.GBBtn.TabIndex = 1
        Me.GBBtn.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(98, 86)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(111, 49)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(98, 21)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 49)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(6, 103)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 43)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(6, 58)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(86, 39)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(6, 10)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 42)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'tblSiswa
        '
        Me.tblSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblSiswa.Location = New System.Drawing.Point(12, 292)
        Me.tblSiswa.Name = "tblSiswa"
        Me.tblSiswa.Size = New System.Drawing.Size(642, 155)
        Me.tblSiswa.TabIndex = 2
        '
        'GBCari
        '
        Me.GBCari.Controls.Add(Me.btnCari)
        Me.GBCari.Controls.Add(Me.txtCari)
        Me.GBCari.Location = New System.Drawing.Point(1, 466)
        Me.GBCari.Name = "GBCari"
        Me.GBCari.Size = New System.Drawing.Size(338, 64)
        Me.GBCari.TabIndex = 3
        Me.GBCari.TabStop = False
        Me.GBCari.Text = "Masukan Data Yang Dicari"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(222, 13)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(107, 42)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 29)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(196, 20)
        Me.txtCari.TabIndex = 0
        '
        'GBNavigasi
        '
        Me.GBNavigasi.Controls.Add(Me.btnLast)
        Me.GBNavigasi.Controls.Add(Me.btnNext)
        Me.GBNavigasi.Controls.Add(Me.btnPrev)
        Me.GBNavigasi.Controls.Add(Me.btnFirst)
        Me.GBNavigasi.Location = New System.Drawing.Point(356, 480)
        Me.GBNavigasi.Name = "GBNavigasi"
        Me.GBNavigasi.Size = New System.Drawing.Size(238, 41)
        Me.GBNavigasi.TabIndex = 4
        Me.GBNavigasi.TabStop = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(180, 12)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(43, 23)
        Me.btnLast.TabIndex = 5
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(131, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(43, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(55, 12)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(43, 23)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.Text = "<<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 12)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(43, 23)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Location = New System.Drawing.Point(247, 450)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(83, 13)
        Me.LblBaris.TabIndex = 5
        Me.LblBaris.Text = "Data ke 0 dari 0"
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(600, 480)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(63, 49)
        Me.btnSelesai.TabIndex = 6
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 62)
        Me.Panel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(243, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 42)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Input Guru"
        '
        'FormInputGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(666, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.GBNavigasi)
        Me.Controls.Add(Me.GBCari)
        Me.Controls.Add(Me.tblSiswa)
        Me.Controls.Add(Me.GBBtn)
        Me.Controls.Add(Me.GBIsidata)
        Me.Name = "FormInputGuru"
        Me.GBIsidata.ResumeLayout(False)
        Me.GBIsidata.PerformLayout()
        Me.GBBtn.ResumeLayout(False)
        CType(Me.tblSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCari.ResumeLayout(False)
        Me.GBCari.PerformLayout()
        Me.GBNavigasi.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBIsidata As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaGuru As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GBBtn As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents tblSiswa As DataGridView
    Friend WithEvents GBCari As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents GBNavigasi As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents LblBaris As Label
    Friend WithEvents btnSelesai As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNotelp As TextBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdGuru As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtJabatan As TextBox
    Friend WithEvents Label9 As Label
End Class
