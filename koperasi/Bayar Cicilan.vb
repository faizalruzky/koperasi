Imports System.Data.SqlClient
Public Class Bayar_Cicilan

    Sub Bersihkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        LblNama.Text = ""
        LblAlamat.Text = ""
        LblTelepon.Text = ""
        DTP.Text = ""
        LblJumlah.Text = ""
        LblTanggalTempo.Text = ""
        LblTerlambat.Text = ""
        LblTelahBayar.Text = ""
        LblSisaLalu.Text = ""
        LblDenda.Text = ""
        TxtAngsuran.Text = ""
        LblCicilanKe.Text = ""
        LblSisaSekarang.Text = ""
        LblTanggalKredit.Text = ""
        TxtKeterangan.Text = "-"
    End Sub
    Dim tinggi As Double = 0
    Sub Otomatis()
        cmd = New SqlCommand("Select * from tabel_bayar_cicilan where nomor_bayar in (select max(nomor_bayar) from tabel_bayar_cicilan) order by nomor_bayar desc", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "BY" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "BY" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 8) + 1
                urutan = "BY" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LblNomorByr.Text = urutan
    End Sub

    Sub Tampiltabel_pinjaman()
        da = New SqlDataAdapter("select * from tabel_pinjaman ", Conn)
        ds = New DataSet
        da.Fill(ds, "tabel_pinjaman")
        DGV1.DataSource = ds.Tables("tabel_pinjaman")
    End Sub

    Sub TampilCicilan()
        da = New SqlDataAdapter("select * from tabel_bayar_cicilan", Conn)
        ds = New DataSet
        da.Fill(ds, "tabel_bayar_cicilan")
        DGV2.DataSource = ds.Tables("tabel_bayar_cicilan")
    End Sub

    Sub TampilID_kredit()
        cmd = New SqlCommand("Select * from tabel_pinjaman where keterangan<>'LUNAS'", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub tabel_bayar_cicilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()

    End Sub


    Private Sub tabel_bayar_cicilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilID_kredit()
        Call Tampiltabel_pinjaman()
        Call TampilCicilan()
        Call Bersihkan()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then TxtAngsuran.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        cmd = New SqlCommand("select * from tabel_pinjaman where ID_kredit='" & ComboBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblJumlah.Text = rd.Item("jumlah")
            TxtAngsuran.Text = CInt(rd.Item("angsuran"))
            LblSisaLalu.Text = rd.Item("sisa")
            LblTanggalKredit.Text = rd.Item("tanggal")
            LblCicilanKe.Text = rd.Item("angsuran_ke") + "1"
            'jika belum pernah membayar angsuran maka jatuh tempo pembayaran adalah dimulai dari tanggal beli + 30 hari
            If IsDBNull(rd.Item("angsuran_ke")) = 0 Then
                LblTanggalTempo.Text = DateAdd(DateInterval.Day, 30, rd.Item(1))
            Else
                'jika pernah ada angsuran, maka angsuran berikutnya
                'adalah 30 hari X jumlah angsuran yang penah dibayar
                LblTanggalTempo.Text = DateAdd(DateInterval.Day, 30 * LblCicilanKe.Text, rd.Item(1))
            End If
            'jumlah denda adalah 5000 x hari keterlambatan dati tgl jatuh tempo
            If CDate(DTP.Text) > CDate(LblTanggalTempo.Text) Then
                LblTerlambat.Text = (DTP.Text) - (LblTanggalTempo.Text)
                LblDenda.Text = 5000 * Val(LblTerlambat.Text)
            Else
                LblTerlambat.Text = 0
                LblDenda.Text = 0
            End If

            If CInt(IsDBNull(rd.Item("telah_bayar"))) = 0 Then
                LblTelahBayar.Text = 0
            Else
                LblTelahBayar.Text = IsDBNull(rd.Item("telah_bayar"))
            End If

            'mencari identitas Anggota yang dihasilkan dari query tabel_pinjaman
            cmd = New SqlCommand("select * from tabel_anggota where ID_anggota='" & rd.Item(2) & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                LblNama.Text = rd.Item("nama")
                LblAlamat.Text = rd.Item("alamat")
                LblTelepon.Text = rd.Item("telepon")
            End If
        End If
    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Bersihkan()
        Call Otomatis()
        ComboBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub TxtAngsuran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAngsuran.KeyPress
        If e.KeyChar = Chr(13) Then

            cmd = New SqlCommand("SELECT * FROM tabel_pinjaman WHERE ID_kredit='" & ComboBox1.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                'jika angsuran melebihi sisa pembayaran, maka tampilkan dalam keterangan uang kembaliannya
                If Val(TxtAngsuran.Text) > rd.Item("sisa") Then
                    TxtAngsuran.Text = TxtAngsuran.Text
                    TxtKeterangan.Text = "kembali" & Space(1) & (TxtAngsuran.Text - rd.Item("sisa")) & Space(1) & "LUNAS"
                    LblCicilanKe.Text = 1
                    LblSisaSekarang.Text = 0
                Else
                    'sisa sekarang tampil setelah dikurang angsuran indikasi cicilan terus berubah yaitu cicilan bulan lalu + 1
                    LblSisaSekarang.Text = LblSisaLalu.Text - rd.Item("angsuran")
                    TxtKeterangan.Text = "Pembayaran Bulan" & Space(1) & (MonthName(Month(LblTanggalTempo.Text)))
                    TxtKeterangan.Text = TxtKeterangan.Text & Space(1) & Year(LblTanggalTempo.Text)
                    TxtKeterangan.Focus()
                End If
                TxtKeterangan.Focus()
            End If
        End If
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or TxtAngsuran.Text = "" Or LblSisaSekarang.Text = "" Then
            MsgBox("Data belum lengkap, coba enter di angsuran + denda")
            TxtAngsuran.Focus()
            Exit Sub
        End If

        Dim Simpan As String = "INSERT INTO tabel_bayar_cicilan(nomor_bayar,tanggal_bayar,ID_kredit,jumlah,sisa,cicilan,keterangan,kode_ptgs) VALUES " & _
        "('" & LblNomorByr.Text & "',CURRENT_TIMESTAMP,'" & ComboBox1.Text & "','" & TxtAngsuran.Text & "','" & LblSisaSekarang.Text & "','" & LblCicilanKe.Text & "','" & TxtKeterangan.Text & "','" & Menu_Utama.Panel1.Text & "')"
        cmd = New SqlCommand(Simpan, Conn)
        cmd.ExecuteNonQuery()

        'sisa pembayaran terus berkurang akibat pembayaran
        'jumlah telah bayar terus bertambah
        'jika sisa sekarang = 0 maka keterangan =lunas
        'indikasi angsuran terus berubah 1,2,3 dan seterusnya
        cmd = New SqlCommand("SELECT * FROM tabel_pinjaman WHERE ID_kredit='" & ComboBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then

            If LblSisaSekarang.Text = 0 Then
                Dim updatedata As String = "UPDATE tabel_pinjaman SET SISA='" & LblSisaSekarang.Text & "',telah_bayar= '" & rd.Item("telah_bayar") + TxtAngsuran.Text & "',angsuran_ke='" & LblCicilanKe.Text & "',keterangan='LUNAS' WHERE ID_kredit='" & ComboBox1.Text & "'"
                cmd = New SqlCommand(updatedata, Conn)
                cmd.ExecuteNonQuery()
            Else
                Dim updatedata As String = "UPDATE tabel_pinjaman SET SISA='" & rd.Item("sisa") - TxtAngsuran.Text & "',telah_bayar= '" & rd.Item("telah_bayar") + TxtAngsuran.Text & "',angsuran_ke='" & LblCicilanKe.Text & "',keterangan='-' WHERE ID_kredit='" & ComboBox1.Text & "'"
                cmd = New SqlCommand(updatedata, Conn)
                cmd.ExecuteNonQuery()
            End If

            cmd = New SqlCommand("SELECT * FROM tabel_pinjaman WHERE ID_kredit='" & ComboBox1.Text & "' AND SISA=0", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then

                Dim UBAHKET As String = "UPDATE tabel_pinjaman SET KETerangan='LUNAS' WHERE ID_kredit='" & ComboBox1.Text & "'"
                cmd = New SqlCommand(UBAHKET, Conn)
                cmd.ExecuteNonQuery()

            End If
            Call Otomatis()
            Call Bersihkan()
            Call Tampiltabel_pinjaman()
            Call TampilCicilan()
            MsgBox("Proses Berhasil disimpan")
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TxtKeterangan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKeterangan.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtKeterangan.Text = "" Then
                TxtKeterangan.Text = "-"
            Else
                btnsimpan.Focus()
            End If
        End If

    End Sub


    Private Sub DGV1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        On Error Resume Next
        ComboBox1.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub DGV2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseClick
        On Error Resume Next
        LblNomorByr.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
        DTP.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
        'LblJumlah.Text = DGV2.Rows(e.RowIndex).Cells(3).Value
        LblSisaSekarang.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
        LblCicilanKe.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        TxtKeterangan.Text = DGV2.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''tinggi += 15
        e.Graphics.DrawString("                      Koperasi Simpan Pinjam", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("             Jl Cipadung N0 92 Cibiru - Bandung", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                          CV. Faizal Ruzky", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 30
        e.Graphics.DrawString("                            Bayar Cicilan", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("=================================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Tgl            " + DTP.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("=================================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Petugas                   " + Menu_Utama.Panel1.Text + Menu_Utama.Panel2.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Trans                      " + LblNomorByr.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 35
        e.Graphics.DrawString("ID Anggota                : " + ComboBox1.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Nama                        : " + LblNama.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Alamat                      : " + LblAlamat.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Telepon                     : " + LblTelepon.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Jumlah Pinjaman        : " + LblJumlah.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Terlambat (Hari)        : " + LblTerlambat.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Denda                      : " + LblDenda.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Tgl Jatuh Tempo        : " + LblTanggalTempo.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Telah dibayar             : " + LblTelahBayar.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Sisa Bulan lalu           : " + LblSisaLalu.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Angsuran + Denda     : " + TxtAngsuran.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Cicilan ke                  : " + LblCicilanKe.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Sisa Pembayaran       : " + LblSisaSekarang.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Keterangan               : " + TxtKeterangan.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("-----------------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 10
        tinggi += 15
        e.Graphics.DrawString("Total Bayar  = Rp. " + TxtAngsuran.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Bayar          = Rp. " + TextBox1.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Kembalian    = Rp. " + TextBox2.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("=================================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 25
        e.Graphics.DrawString("                          TERIMAKASIH", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("-----------------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
        Call Otomatis()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = Val(TextBox1.Text) - Val(TxtAngsuran.Text)
        End If
    End Sub

   
End Class