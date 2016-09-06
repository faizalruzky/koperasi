Imports System.Data.SqlClient
Imports System.Math

Public Class Pinjaman
    Sub Kosongkan()
        ComboBox1.Text = ""
        LblNama.Text = ""
        LblSaldo.Text = ""
        DTP.Text = ""
        TxtPinjaman.Clear()
        TxtBunga.Clear()
        TxtCicilan.Clear()
        TxtPinjaman.Clear()
        LblAngsuran.Text = ""
        ComboBox1.Focus()
    End Sub
    Dim tinggi As Double = 0
    Sub TampilGrid()
        da = New SqlDataAdapter("select * from tabel_pinjaman", conn)
        ds = New DataSet
        da.Fill(ds, "tabel_pinjaman")
        DGV.DataSource = ds.Tables("tabel_pinjaman")
    End Sub

    Sub TampilAnggota()
        cmd = New SqlCommand("Select * from tabel_anggota", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub Otomatis()
        cmd = New SqlCommand("Select * from tabel_pinjaman where ID_kredit in (select max(ID_kredit) from tabel_pinjaman) order by ID_kredit desc", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "KR" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "KR" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 8) + 1
                urutan = "KR" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LblIDKredit.Text = urutan
    End Sub

    Private Sub Pinjaman_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()
    End Sub

    Private Sub Pinjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTP.Value = Today
        Call Koneksi()
        Call TampilGrid()
        Call Kosongkan()
        TampilAnggota()
    End Sub

    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then TxtPinjaman.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New SqlCommand("select * from tabel_anggota where ID_anggota='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblNama.Text = rd.Item(1)
            LblSaldo.Text = rd.Item(7)
        End If
    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
        Call Otomatis()
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or TxtPinjaman.Text = "" Or TxtBunga.Text = "" Or TxtCicilan.Text = "" Then
            MsgBox("Data belum lengkap ")
        ElseIf LblAngsuran.Text = "" Then
            MsgBox("Coba Enter di lama cicilan")
            Exit Sub
        Else
            'simpan data ke tabel pinjam
            Dim simpan As String = "Insert Into tabel_pinjaman(ID_kredit,tanggal,ID_anggota,jumlah,bunga,lama_cicilan,angsuran,sisa,keterangan,kode_ptgs) values " & _
            "('" & LblIDKredit.Text & "',CURRENT_TIMESTAMP,'" & ComboBox1.Text & "','" & TxtPinjaman.Text & "','" & TxtBunga.Text & "','" & TxtCicilan.Text & "','" & LblAngsuran.Text & "','" & TxtPinjaman.Text & "','-','" & Menu_Utama.Panel1.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            Call Otomatis()
            Call TampilGrid()
            Call Kosongkan()
            MsgBox("Proses Berhasil disimpan")
        End If
    End Sub

    Private Sub TxtPinjaman_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPinjaman.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtPinjaman.Text) > Val(LblSaldo.Text) * 2 Then
                MsgBox("pinjaman maksimal 2X lipat saldo")
                TxtPinjaman.Clear()
            Else
                TxtBunga.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtBunga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBunga.KeyPress
        If e.KeyChar = Chr(13) Then TxtCicilan.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtCicilan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCicilan.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hitung As Decimal = Microsoft.VisualBasic.Pmt(Val(TxtBunga.Text) / 100 / 12, Val(TxtCicilan.Text), Val(TxtPinjaman.Text)) * -1
            LblAngsuran.Text = CInt(Round(hitung, 2))
            BTNSimpan.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        LblIDKredit.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DTP.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TxtPinjaman.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        TxtBunga.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        TxtCicilan.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        LblAngsuran.Text = DGV.Rows(e.RowIndex).Cells(7).Value
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''tinggi += 15
        e.Graphics.DrawString("                Koperasi Simpan Pinjam", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("       Jl Cipadung N0 92 Cibiru - Bandung", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                    CV. Faizal Ruzky", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 30
        e.Graphics.DrawString("                      Pinjaman", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Tgl            " + DTP.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Petugas                   " + Menu_Utama.Panel1.Text + Menu_Utama.Panel2.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Trans                      " + LblIDKredit.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 35
        e.Graphics.DrawString("ID Anggota               : " + ComboBox1.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Nama                       : " + LblNama.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Saldo                       : " + LblSaldo.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Jumlah Pinjaman       : " + TxtPinjaman.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Bunga                      : " + TxtBunga.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Lama Cicilan             : " + TxtCicilan.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Angsuran/Bln            : " + LblAngsuran.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("--------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 10
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 25
        e.Graphics.DrawString("                    TERIMAKASIH", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("--------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                 ", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
        Call Otomatis()
    End Sub

End Class