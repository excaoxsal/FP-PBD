<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.tblStaff = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtJabatan = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tblStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(600, 478)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(63, 49)
        Me.btnSelesai.TabIndex = 12
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnLast)
        Me.GroupBox4.Controls.Add(Me.btnNext)
        Me.GroupBox4.Controls.Add(Me.btnPrev)
        Me.GroupBox4.Controls.Add(Me.btnFirst)
        Me.GroupBox4.Location = New System.Drawing.Point(346, 481)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 41)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCari)
        Me.GroupBox3.Controls.Add(Me.txtCari)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 468)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 64)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masukan Data Yang Dicari"
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
        'tblStaff
        '
        Me.tblStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblStaff.Location = New System.Drawing.Point(12, 314)
        Me.tblStaff.Name = "tblStaff"
        Me.tblStaff.Size = New System.Drawing.Size(642, 138)
        Me.tblStaff.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 166)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtJabatan)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.rbPerempuan)
        Me.GroupBox1.Controls.Add(Me.rbLaki)
        Me.GroupBox1.Controls.Add(Me.txtStaff)
        Me.GroupBox1.Controls.Add(Me.txtNIK)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 209)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'TxtJabatan
        '
        Me.TxtJabatan.Location = New System.Drawing.Point(162, 180)
        Me.TxtJabatan.Name = "TxtJabatan"
        Me.TxtJabatan.Size = New System.Drawing.Size(250, 20)
        Me.TxtJabatan.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 156)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 20)
        Me.txtEmail.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(5, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Jabatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Email"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(162, 107)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(250, 20)
        Me.txtTelepon.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "No Telepon"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(162, 133)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(250, 20)
        Me.txtAlamat.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(162, 82)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 20)
        Me.txtPassword.TabIndex = 10
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(238, 62)
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
        Me.rbLaki.Location = New System.Drawing.Point(162, 62)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(64, 17)
        Me.rbLaki.TabIndex = 7
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'txtStaff
        '
        Me.txtStaff.Location = New System.Drawing.Point(162, 36)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(250, 20)
        Me.txtStaff.TabIndex = 6
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(162, 10)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(250, 20)
        Me.txtNIK.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 78)
        Me.Panel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(550, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(256, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 42)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Input Staff"
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Location = New System.Drawing.Point(247, 455)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(83, 13)
        Me.LblBaris.TabIndex = 14
        Me.LblBaris.Text = "Data ke 0 dari 0"
        '
        'FormInputStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(677, 535)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tblStaff)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormInputStaff"
        Me.Text = "FormInputStaff"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tblStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelesai As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents tblStaff As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblBaris As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtJabatan As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
End Class
