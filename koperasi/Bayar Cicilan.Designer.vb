<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bayar_Cicilan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bayar_Cicilan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblNomorByr = New System.Windows.Forms.Label()
        Me.LblTanggalKredit = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblTelepon = New System.Windows.Forms.Label()
        Me.LblJumlah = New System.Windows.Forms.Label()
        Me.LblTerlambat = New System.Windows.Forms.Label()
        Me.LblDenda = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LblTanggalTempo = New System.Windows.Forms.Label()
        Me.LblTelahBayar = New System.Windows.Forms.Label()
        Me.LblSisaLalu = New System.Windows.Forms.Label()
        Me.LblCicilanKe = New System.Windows.Forms.Label()
        Me.LblSisaSekarang = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.TxtAngsuran = New System.Windows.Forms.TextBox()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Kredit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Kredit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(29, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Pinjaman"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Terlambat (Hari)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(29, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Denda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Keterangan"
        '
        'LblNomorByr
        '
        Me.LblNomorByr.BackColor = System.Drawing.SystemColors.Info
        Me.LblNomorByr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomorByr.Location = New System.Drawing.Point(126, 100)
        Me.LblNomorByr.Name = "LblNomorByr"
        Me.LblNomorByr.Size = New System.Drawing.Size(124, 22)
        Me.LblNomorByr.TabIndex = 9
        Me.LblNomorByr.Text = "Label10"
        '
        'LblTanggalKredit
        '
        Me.LblTanggalKredit.BackColor = System.Drawing.SystemColors.Info
        Me.LblTanggalKredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggalKredit.Location = New System.Drawing.Point(126, 168)
        Me.LblTanggalKredit.Name = "LblTanggalKredit"
        Me.LblTanggalKredit.Size = New System.Drawing.Size(124, 22)
        Me.LblTanggalKredit.TabIndex = 10
        '
        'LblAlamat
        '
        Me.LblAlamat.BackColor = System.Drawing.SystemColors.Info
        Me.LblAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAlamat.Location = New System.Drawing.Point(126, 201)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(124, 75)
        Me.LblAlamat.TabIndex = 11
        Me.LblAlamat.Text = "Label12"
        '
        'LblTelepon
        '
        Me.LblTelepon.BackColor = System.Drawing.SystemColors.Info
        Me.LblTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTelepon.Location = New System.Drawing.Point(126, 285)
        Me.LblTelepon.Name = "LblTelepon"
        Me.LblTelepon.Size = New System.Drawing.Size(124, 22)
        Me.LblTelepon.TabIndex = 12
        Me.LblTelepon.Text = "Label13"
        '
        'LblJumlah
        '
        Me.LblJumlah.BackColor = System.Drawing.SystemColors.Info
        Me.LblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblJumlah.Location = New System.Drawing.Point(126, 322)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(124, 24)
        Me.LblJumlah.TabIndex = 13
        Me.LblJumlah.Text = "Label14"
        '
        'LblTerlambat
        '
        Me.LblTerlambat.BackColor = System.Drawing.SystemColors.Info
        Me.LblTerlambat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTerlambat.Location = New System.Drawing.Point(126, 366)
        Me.LblTerlambat.Name = "LblTerlambat"
        Me.LblTerlambat.Size = New System.Drawing.Size(124, 22)
        Me.LblTerlambat.TabIndex = 14
        Me.LblTerlambat.Text = "Label15"
        '
        'LblDenda
        '
        Me.LblDenda.BackColor = System.Drawing.SystemColors.Info
        Me.LblDenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDenda.Location = New System.Drawing.Point(126, 410)
        Me.LblDenda.Name = "LblDenda"
        Me.LblDenda.Size = New System.Drawing.Size(124, 24)
        Me.LblDenda.TabIndex = 15
        Me.LblDenda.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(276, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Tanggal Bayar"
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.SystemColors.Info
        Me.LblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNama.Location = New System.Drawing.Point(279, 130)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(240, 24)
        Me.LblNama.TabIndex = 17
        Me.LblNama.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(276, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Tgl Jatuh Tempo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(276, 241)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Telah Dibayar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(276, 294)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Sisa Bulan Lalu"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(276, 333)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Angsuran + Denda"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(276, 375)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Cicilan Ke"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(276, 421)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Sisa Pembayaran"
        '
        'LblTanggalTempo
        '
        Me.LblTanggalTempo.BackColor = System.Drawing.SystemColors.Info
        Me.LblTanggalTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggalTempo.Location = New System.Drawing.Point(394, 191)
        Me.LblTanggalTempo.Name = "LblTanggalTempo"
        Me.LblTanggalTempo.Size = New System.Drawing.Size(125, 23)
        Me.LblTanggalTempo.TabIndex = 25
        Me.LblTanggalTempo.Text = "Label26"
        '
        'LblTelahBayar
        '
        Me.LblTelahBayar.BackColor = System.Drawing.SystemColors.Info
        Me.LblTelahBayar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTelahBayar.Location = New System.Drawing.Point(394, 233)
        Me.LblTelahBayar.Name = "LblTelahBayar"
        Me.LblTelahBayar.Size = New System.Drawing.Size(125, 21)
        Me.LblTelahBayar.TabIndex = 26
        Me.LblTelahBayar.Text = "Label27"
        '
        'LblSisaLalu
        '
        Me.LblSisaLalu.BackColor = System.Drawing.SystemColors.Info
        Me.LblSisaLalu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSisaLalu.Location = New System.Drawing.Point(394, 285)
        Me.LblSisaLalu.Name = "LblSisaLalu"
        Me.LblSisaLalu.Size = New System.Drawing.Size(125, 23)
        Me.LblSisaLalu.TabIndex = 27
        Me.LblSisaLalu.Text = "Label28"
        '
        'LblCicilanKe
        '
        Me.LblCicilanKe.BackColor = System.Drawing.SystemColors.Info
        Me.LblCicilanKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCicilanKe.Location = New System.Drawing.Point(394, 365)
        Me.LblCicilanKe.Name = "LblCicilanKe"
        Me.LblCicilanKe.Size = New System.Drawing.Size(48, 23)
        Me.LblCicilanKe.TabIndex = 28
        Me.LblCicilanKe.Text = "Label29"
        '
        'LblSisaSekarang
        '
        Me.LblSisaSekarang.BackColor = System.Drawing.SystemColors.Info
        Me.LblSisaSekarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSisaSekarang.Location = New System.Drawing.Point(394, 412)
        Me.LblSisaSekarang.Name = "LblSisaSekarang"
        Me.LblSisaSekarang.Size = New System.Drawing.Size(125, 22)
        Me.LblSisaSekarang.TabIndex = 29
        Me.LblSisaSekarang.Text = "Label30"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(126, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Location = New System.Drawing.Point(126, 457)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(327, 35)
        Me.TxtKeterangan.TabIndex = 32
        '
        'TxtAngsuran
        '
        Me.TxtAngsuran.Location = New System.Drawing.Point(394, 322)
        Me.TxtAngsuran.Name = "TxtAngsuran"
        Me.TxtAngsuran.Size = New System.Drawing.Size(125, 20)
        Me.TxtAngsuran.TabIndex = 31
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Image = Global.koperasi.My.Resources.Resources.Simpan_icon
        Me.BTNSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSimpan.Location = New System.Drawing.Point(541, 167)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(61, 51)
        Me.BTNSimpan.TabIndex = 33
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNSimpan.UseVisualStyleBackColor = False
        '
        'BTNBatal
        '
        Me.BTNBatal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBatal.Image = Global.koperasi.My.Resources.Resources.Batal_icon
        Me.BTNBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNBatal.Location = New System.Drawing.Point(541, 235)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(61, 46)
        Me.BTNBatal.TabIndex = 34
        Me.BTNBatal.Text = "Batal"
        Me.BTNBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNBatal.UseVisualStyleBackColor = False
        '
        'BTNTutup
        '
        Me.BTNTutup.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNTutup.Image = Global.koperasi.My.Resources.Resources.tutup_icon
        Me.BTNTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNTutup.Location = New System.Drawing.Point(541, 296)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(61, 44)
        Me.BTNTutup.TabIndex = 35
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTutup.UseVisualStyleBackColor = False
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.GridColor = System.Drawing.SystemColors.Control
        Me.DGV1.Location = New System.Drawing.Point(617, 100)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(417, 176)
        Me.DGV1.TabIndex = 36
        '
        'DGV2
        '
        Me.DGV2.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.GridColor = System.Drawing.SystemColors.Control
        Me.DGV2.Location = New System.Drawing.Point(623, 318)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(417, 174)
        Me.DGV2.TabIndex = 37
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(374, 102)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(145, 20)
        Me.DTP.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Alcohol Licks", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(316, 35)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Bayar Cicilan"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.koperasi.My.Resources.Resources.logo_fix
        Me.PictureBox1.Location = New System.Drawing.Point(44, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.koperasi.My.Resources.Resources.print_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(541, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 51)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(457, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Bayar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(457, 482)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Kembalian"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(521, 475)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 45
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(521, 445)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 46
        '
        'Bayar_Cicilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 513)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.TxtAngsuran)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblSisaSekarang)
        Me.Controls.Add(Me.LblCicilanKe)
        Me.Controls.Add(Me.LblSisaLalu)
        Me.Controls.Add(Me.LblTelahBayar)
        Me.Controls.Add(Me.LblTanggalTempo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LblDenda)
        Me.Controls.Add(Me.LblTerlambat)
        Me.Controls.Add(Me.LblJumlah)
        Me.Controls.Add(Me.LblTelepon)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblTanggalKredit)
        Me.Controls.Add(Me.LblNomorByr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Bayar_Cicilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bayar_Cicilan"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblNomorByr As System.Windows.Forms.Label
    Friend WithEvents LblTanggalKredit As System.Windows.Forms.Label
    Friend WithEvents LblAlamat As System.Windows.Forms.Label
    Friend WithEvents LblTelepon As System.Windows.Forms.Label
    Friend WithEvents LblJumlah As System.Windows.Forms.Label
    Friend WithEvents LblTerlambat As System.Windows.Forms.Label
    Friend WithEvents LblDenda As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblTanggalTempo As System.Windows.Forms.Label
    Friend WithEvents LblTelahBayar As System.Windows.Forms.Label
    Friend WithEvents LblSisaLalu As System.Windows.Forms.Label
    Friend WithEvents LblCicilanKe As System.Windows.Forms.Label
    Friend WithEvents LblSisaSekarang As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents TxtAngsuran As System.Windows.Forms.TextBox
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
