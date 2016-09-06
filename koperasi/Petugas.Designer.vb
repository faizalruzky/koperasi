<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Petugas
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
        Me.TKode = New System.Windows.Forms.TextBox()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdTutup = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(159, 100)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(91, 20)
        Me.TKode.TabIndex = 4
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(159, 142)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(144, 20)
        Me.TNama.TabIndex = 5
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(159, 183)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(144, 20)
        Me.TPassword.TabIndex = 6
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"ADMINISTRATOR", "OPERATOR"})
        Me.CmbStatus.Location = New System.Drawing.Point(159, 220)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(144, 21)
        Me.CmbStatus.TabIndex = 7
        Me.CmbStatus.Tag = ""
        '
        'CmdSimpan
        '
        Me.CmdSimpan.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CmdSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSimpan.Image = Global.koperasi.My.Resources.Resources.Simpan_icon1
        Me.CmdSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdSimpan.Location = New System.Drawing.Point(343, 100)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(60, 62)
        Me.CmdSimpan.TabIndex = 8
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSimpan.UseVisualStyleBackColor = False
        '
        'CmdHapus
        '
        Me.CmdHapus.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CmdHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdHapus.Image = Global.koperasi.My.Resources.Resources.Delete_icon
        Me.CmdHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdHapus.Location = New System.Drawing.Point(343, 183)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(60, 58)
        Me.CmdHapus.TabIndex = 9
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdHapus.UseVisualStyleBackColor = False
        '
        'CmdBatal
        '
        Me.CmdBatal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CmdBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdBatal.Image = Global.koperasi.My.Resources.Resources.Batal_icon
        Me.CmdBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdBatal.Location = New System.Drawing.Point(450, 100)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(61, 62)
        Me.CmdBatal.TabIndex = 10
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdBatal.UseVisualStyleBackColor = False
        '
        'CmdTutup
        '
        Me.CmdTutup.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CmdTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdTutup.Image = Global.koperasi.My.Resources.Resources.tutup_icon
        Me.CmdTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdTutup.Location = New System.Drawing.Point(450, 181)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(61, 60)
        Me.CmdTutup.TabIndex = 11
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdTutup.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(59, 263)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(444, 170)
        Me.DGV.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Alcohol Licks", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 33)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Data Pegawai"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.koperasi.My.Resources.Resources.logo_fix
        Me.PictureBox1.Location = New System.Drawing.Point(26, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.koperasi.My.Resources.Resources.bg_form_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 457)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.TKode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Petugas"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TKode As System.Windows.Forms.TextBox
    Friend WithEvents TNama As System.Windows.Forms.TextBox
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
