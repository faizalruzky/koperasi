<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tblKeluar = New System.Windows.Forms.Button()
        Me.tblGPassword = New System.Windows.Forms.Button()
        Me.tblLaporan = New System.Windows.Forms.Button()
        Me.tblBayar = New System.Windows.Forms.Button()
        Me.tblPinjaman = New System.Windows.Forms.Button()
        Me.tblPengambilan = New System.Windows.Forms.Button()
        Me.tblSimpanan = New System.Windows.Forms.Button()
        Me.tblPetugas = New System.Windows.Forms.Button()
        Me.tblAnggota = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel1, Me.Panel2, Me.Panel3})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 636)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1114, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 17)
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 17)
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.koperasi.My.Resources.Resources.header2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1114, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'tblKeluar
        '
        Me.tblKeluar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblKeluar.Image = Global.koperasi.My.Resources.Resources.Logout_icon
        Me.tblKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblKeluar.Location = New System.Drawing.Point(594, 12)
        Me.tblKeluar.Name = "tblKeluar"
        Me.tblKeluar.Size = New System.Drawing.Size(77, 78)
        Me.tblKeluar.TabIndex = 11
        Me.tblKeluar.Text = "Keluar"
        Me.tblKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblKeluar.UseVisualStyleBackColor = False
        '
        'tblGPassword
        '
        Me.tblGPassword.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblGPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblGPassword.Image = Global.koperasi.My.Resources.Resources.tbl_ganti_password
        Me.tblGPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblGPassword.Location = New System.Drawing.Point(8, 102)
        Me.tblGPassword.Name = "tblGPassword"
        Me.tblGPassword.Size = New System.Drawing.Size(75, 77)
        Me.tblGPassword.TabIndex = 10
        Me.tblGPassword.Text = "Ganti Password"
        Me.tblGPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblGPassword.UseVisualStyleBackColor = False
        '
        'tblLaporan
        '
        Me.tblLaporan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblLaporan.Image = Global.koperasi.My.Resources.Resources.Laporan
        Me.tblLaporan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblLaporan.Location = New System.Drawing.Point(520, 12)
        Me.tblLaporan.Name = "tblLaporan"
        Me.tblLaporan.Size = New System.Drawing.Size(75, 78)
        Me.tblLaporan.TabIndex = 9
        Me.tblLaporan.Text = "Laporan"
        Me.tblLaporan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblLaporan.UseVisualStyleBackColor = False
        '
        'tblBayar
        '
        Me.tblBayar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblBayar.Image = Global.koperasi.My.Resources.Resources.tbl_bayar
        Me.tblBayar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblBayar.Location = New System.Drawing.Point(250, 13)
        Me.tblBayar.Name = "tblBayar"
        Me.tblBayar.Size = New System.Drawing.Size(88, 77)
        Me.tblBayar.TabIndex = 8
        Me.tblBayar.Text = "Bayar Cicilan"
        Me.tblBayar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblBayar.UseVisualStyleBackColor = False
        '
        'tblPinjaman
        '
        Me.tblPinjaman.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblPinjaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblPinjaman.Image = Global.koperasi.My.Resources.Resources.tbl_pinjaman
        Me.tblPinjaman.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblPinjaman.Location = New System.Drawing.Point(171, 13)
        Me.tblPinjaman.Name = "tblPinjaman"
        Me.tblPinjaman.Size = New System.Drawing.Size(76, 77)
        Me.tblPinjaman.TabIndex = 7
        Me.tblPinjaman.Text = "Pinjaman"
        Me.tblPinjaman.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblPinjaman.UseVisualStyleBackColor = False
        '
        'tblPengambilan
        '
        Me.tblPengambilan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblPengambilan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblPengambilan.Image = Global.koperasi.My.Resources.Resources.tbl_pengambilan_fix
        Me.tblPengambilan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblPengambilan.Location = New System.Drawing.Point(85, 13)
        Me.tblPengambilan.Name = "tblPengambilan"
        Me.tblPengambilan.Size = New System.Drawing.Size(82, 77)
        Me.tblPengambilan.TabIndex = 6
        Me.tblPengambilan.Text = "Pengambilan Dana"
        Me.tblPengambilan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblPengambilan.UseVisualStyleBackColor = False
        '
        'tblSimpanan
        '
        Me.tblSimpanan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblSimpanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblSimpanan.Image = Global.koperasi.My.Resources.Resources.simpanan
        Me.tblSimpanan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblSimpanan.Location = New System.Drawing.Point(6, 13)
        Me.tblSimpanan.Name = "tblSimpanan"
        Me.tblSimpanan.Size = New System.Drawing.Size(75, 77)
        Me.tblSimpanan.TabIndex = 5
        Me.tblSimpanan.Text = "Simpanan"
        Me.tblSimpanan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblSimpanan.UseVisualStyleBackColor = False
        '
        'tblPetugas
        '
        Me.tblPetugas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblPetugas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblPetugas.Image = Global.koperasi.My.Resources.Resources.admin_fix
        Me.tblPetugas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblPetugas.Location = New System.Drawing.Point(83, 13)
        Me.tblPetugas.Name = "tblPetugas"
        Me.tblPetugas.Size = New System.Drawing.Size(72, 77)
        Me.tblPetugas.TabIndex = 4
        Me.tblPetugas.Text = "Pegawai"
        Me.tblPetugas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblPetugas.UseVisualStyleBackColor = False
        '
        'tblAnggota
        '
        Me.tblAnggota.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tblAnggota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblAnggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tblAnggota.Image = Global.koperasi.My.Resources.Resources.icon_user1
        Me.tblAnggota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tblAnggota.Location = New System.Drawing.Point(6, 13)
        Me.tblAnggota.Name = "tblAnggota"
        Me.tblAnggota.Size = New System.Drawing.Size(75, 77)
        Me.tblAnggota.TabIndex = 3
        Me.tblAnggota.Text = "Anggota"
        Me.tblAnggota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tblAnggota.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.koperasi.My.Resources.Resources.bg_menu_utama_fix_3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1114, 616)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.tblAnggota)
        Me.GroupBox1.Controls.Add(Me.tblPetugas)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.tblPengambilan)
        Me.GroupBox2.Controls.Add(Me.tblSimpanan)
        Me.GroupBox2.Controls.Add(Me.tblPinjaman)
        Me.GroupBox2.Controls.Add(Me.tblBayar)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 96)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 658)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tblKeluar)
        Me.Controls.Add(Me.tblGPassword)
        Me.Controls.Add(Me.tblLaporan)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Utama"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tblAnggota As System.Windows.Forms.Button
    Friend WithEvents tblPetugas As System.Windows.Forms.Button
    Friend WithEvents tblSimpanan As System.Windows.Forms.Button
    Friend WithEvents tblPengambilan As System.Windows.Forms.Button
    Friend WithEvents tblPinjaman As System.Windows.Forms.Button
    Friend WithEvents tblBayar As System.Windows.Forms.Button
    Friend WithEvents tblLaporan As System.Windows.Forms.Button
    Friend WithEvents tblGPassword As System.Windows.Forms.Button
    Friend WithEvents tblKeluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
