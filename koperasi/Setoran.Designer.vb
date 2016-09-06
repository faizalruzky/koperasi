<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setoran
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblNomor = New System.Windows.Forms.Label()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Simpanan"
        '
        'LblNomor
        '
        Me.LblNomor.BackColor = System.Drawing.SystemColors.Info
        Me.LblNomor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomor.Location = New System.Drawing.Point(146, 101)
        Me.LblNomor.Name = "LblNomor"
        Me.LblNomor.Size = New System.Drawing.Size(120, 19)
        Me.LblNomor.TabIndex = 4
        Me.LblNomor.Text = "lblnomor"
        '
        'LblSaldo
        '
        Me.LblSaldo.BackColor = System.Drawing.SystemColors.Info
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Location = New System.Drawing.Point(146, 172)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(120, 21)
        Me.LblSaldo.TabIndex = 5
        Me.LblSaldo.Text = "lblsaldo"
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.SystemColors.Info
        Me.LblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNama.Location = New System.Drawing.Point(322, 140)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(226, 21)
        Me.LblNama.TabIndex = 8
        Me.LblNama.Text = "lblnama"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(146, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(440, 177)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Image = Global.koperasi.My.Resources.Resources.Simpan_icon
        Me.BTNSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSimpan.Location = New System.Drawing.Point(322, 208)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(68, 61)
        Me.BTNSimpan.TabIndex = 14
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
        Me.BTNBatal.Location = New System.Drawing.Point(405, 208)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(63, 61)
        Me.BTNBatal.TabIndex = 15
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
        Me.BTNTutup.Location = New System.Drawing.Point(484, 208)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(64, 61)
        Me.BTNTutup.TabIndex = 16
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTutup.UseVisualStyleBackColor = False
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(146, 212)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(120, 20)
        Me.TxtJumlah.TabIndex = 12
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(39, 285)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(509, 164)
        Me.DGV.TabIndex = 17
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(405, 101)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(143, 20)
        Me.DTP.TabIndex = 18
        Me.DTP.Value = New Date(2014, 6, 3, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(319, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jenis Simpanan"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Alcohol Licks", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 30)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Setoran"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.koperasi.My.Resources.Resources.logo_fix
        Me.PictureBox1.Location = New System.Drawing.Point(27, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.koperasi.My.Resources.Resources.print_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(39, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 54)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Setoran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.koperasi.My.Resources.Resources.bg_form_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 508)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.LblNomor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Setoran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setoran"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNomor As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
