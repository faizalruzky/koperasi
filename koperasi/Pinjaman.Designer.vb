<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjaman
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblIDKredit = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.LblAngsuran = New System.Windows.Forms.Label()
        Me.TxtCicilan = New System.Windows.Forms.TextBox()
        Me.TxtPinjaman = New System.Windows.Forms.TextBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBunga = New System.Windows.Forms.TextBox()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kredit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo"
        '
        'LblIDKredit
        '
        Me.LblIDKredit.BackColor = System.Drawing.SystemColors.Info
        Me.LblIDKredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIDKredit.Location = New System.Drawing.Point(150, 90)
        Me.LblIDKredit.Name = "LblIDKredit"
        Me.LblIDKredit.Size = New System.Drawing.Size(134, 20)
        Me.LblIDKredit.TabIndex = 5
        Me.LblIDKredit.Text = "LblidKredit"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.SystemColors.Info
        Me.LblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNama.Location = New System.Drawing.Point(150, 201)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(134, 21)
        Me.LblNama.TabIndex = 8
        Me.LblNama.Text = "LblNama"
        '
        'LblSaldo
        '
        Me.LblSaldo.BackColor = System.Drawing.SystemColors.Info
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Location = New System.Drawing.Point(150, 237)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(134, 23)
        Me.LblSaldo.TabIndex = 9
        Me.LblSaldo.Text = "LblSaldo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Jumlah Pinjaman"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(328, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Bunga (%) / Tahun"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(328, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Lama Cicilan (Bln)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(328, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Angsuran / Bln"
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Image = Global.koperasi.My.Resources.Resources.Simpan_icon
        Me.BTNSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSimpan.Location = New System.Drawing.Point(345, 237)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(67, 58)
        Me.BTNSimpan.TabIndex = 17
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
        Me.BTNBatal.Location = New System.Drawing.Point(427, 237)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(64, 58)
        Me.BTNBatal.TabIndex = 18
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
        Me.BTNTutup.Location = New System.Drawing.Point(508, 237)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(66, 58)
        Me.BTNTutup.TabIndex = 19
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTutup.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(33, 309)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(572, 152)
        Me.DGV.TabIndex = 20
        '
        'LblAngsuran
        '
        Me.LblAngsuran.BackColor = System.Drawing.SystemColors.Info
        Me.LblAngsuran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAngsuran.Location = New System.Drawing.Point(480, 208)
        Me.LblAngsuran.Name = "LblAngsuran"
        Me.LblAngsuran.Size = New System.Drawing.Size(125, 21)
        Me.LblAngsuran.TabIndex = 18
        Me.LblAngsuran.Text = "LblAngsuran"
        '
        'TxtCicilan
        '
        Me.TxtCicilan.Location = New System.Drawing.Point(480, 170)
        Me.TxtCicilan.Name = "TxtCicilan"
        Me.TxtCicilan.Size = New System.Drawing.Size(125, 20)
        Me.TxtCicilan.TabIndex = 16
        '
        'TxtPinjaman
        '
        Me.TxtPinjaman.Location = New System.Drawing.Point(480, 88)
        Me.TxtPinjaman.Name = "TxtPinjaman"
        Me.TxtPinjaman.Size = New System.Drawing.Size(125, 20)
        Me.TxtPinjaman.TabIndex = 14
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(150, 128)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(134, 20)
        Me.DTP.TabIndex = 22
        Me.DTP.Value = New Date(2014, 5, 27, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(520, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "%"
        '
        'TxtBunga
        '
        Me.TxtBunga.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBunga.Location = New System.Drawing.Point(480, 135)
        Me.TxtBunga.Name = "TxtBunga"
        Me.TxtBunga.Size = New System.Drawing.Size(41, 20)
        Me.TxtBunga.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Alcohol Licks", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 26)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pinjaman"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.koperasi.My.Resources.Resources.logo_fix
        Me.PictureBox1.Location = New System.Drawing.Point(33, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.koperasi.My.Resources.Resources.print_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(33, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 58)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Pinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.koperasi.My.Resources.Resources.bg_form_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 532)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.TxtPinjaman)
        Me.Controls.Add(Me.TxtBunga)
        Me.Controls.Add(Me.TxtCicilan)
        Me.Controls.Add(Me.LblAngsuran)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblIDKredit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Pinjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pinjaman"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblIDKredit As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents LblAngsuran As System.Windows.Forms.Label
    Friend WithEvents TxtCicilan As System.Windows.Forms.TextBox
    Friend WithEvents TxtPinjaman As System.Windows.Forms.TextBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtBunga As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
