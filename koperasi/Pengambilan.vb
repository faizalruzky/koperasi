Imports System.Data.SqlClient

Public Class Pengambilan
    Sub Kosongkan()
        ComboBox1.Text = ""
        LblSaldo.Text = ""
        LblSukaRela.Text = ""
        DTP.Text = ""
        TxtJumlah.Clear()
        LblNama.Text = ""
        ComboBox1.Focus()
    End Sub
    Dim tinggi As Double = 0
    Sub TampilGrid()
        da = New SqlDataAdapter("select * from tabel_pengambilan", conn)
        ds = New DataSet
        da.Fill(ds, "tabel_pengambilan")
        DGV.DataSource = ds.Tables("tabel_pengambilan")
    End Sub

    Sub TampilAnggota()
        cmd = New SqlCommand("Select * from tabel_anggota", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub Otomatis()
        cmd = New SqlCommand("Select * from tabel_pengambilan where ID_pengambilan in (select max(ID_pengambilan) from tabel_pengambilan) order by ID_pengambilan desc", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "ABL" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                urutan = "ABL" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
                urutan = "ABL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        LblNomor.Text = urutan
    End Sub

    Private Sub Pengambilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()

    End Sub


    Private Sub Pengambilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Kosongkan()
        TampilAnggota()
    End Sub

    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then TxtJumlah.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New SqlCommand("select * from tabel_anggota where ID_anggota='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblNama.Text = rd.Item(1)
            LblSaldo.Text = rd.Item(7)
            LblSukaRela.Text = rd.Item(6)
        End If
    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
        Call Otomatis()
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or TxtJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        ElseIf Val(TxtJumlah.Text) > Val(LblSukaRela.Text) Then
            MsgBox("saldo simpanan sukarela tidak mencukupi")
            TxtJumlah.Clear()
       
        Else
            'simpan data ke tabel pinjam
            Dim simpan As String
            simpan = "Insert into tabel_pengambilan (ID_pengambilan,tanggal,ID_anggota,jumlah,kode_ptgs) values " & _
            "('" & LblNomor.Text & "',CURRENT_TIMESTAMP,'" & ComboBox1.Text & "','" & TxtJumlah.Text & "','" & Menu_Utama.Panel1.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()

            'kurangi saldo anggota dengan Pengambilan yang baru saja dilakukan
            cmd = New SqlCommand("select * from tabel_anggota where ID_anggota='" & ComboBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editsaldo = "update tabel_anggota set saldo= '" & Val(LblSaldo.Text) - Val(TxtJumlah.Text) & "' where ID_anggota='" & ComboBox1.Text & "'"
                cmd = New SqlCommand(editsaldo, conn)
                cmd.ExecuteNonQuery()

                Dim editsukarela = "update tabel_anggota set simpanan_sukarela= '" & Val(rd.Item(6)) - Val(TxtJumlah.Text) & "' where ID_anggota='" & ComboBox1.Text & "'"
                cmd = New SqlCommand(editsukarela, conn)
                cmd.ExecuteNonQuery()
            End If
            Call Otomatis()
            Call TampilGrid()
            Call Kosongkan()
            MsgBox("Proses Berhasil disimpan")
        End If

    End Sub

    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtJumlah.Text) > Val(LblSukaRela.Text) Then
                MsgBox("saldo simpanan sukarela tidak mencukupi")
                TxtJumlah.Clear()
            Else
                BTNSimpan.Focus()
            End If
        End If
    End Sub
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        LblNomor.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DTP.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TxtJumlah.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''tinggi += 15
        e.Graphics.DrawString("                Koperasi Simpan Pinjam", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("       Jl Cipadung N0 92 Cibiru - Bandung", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                    CV. Faizal Ruzky", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 30
        e.Graphics.DrawString("                      Pengambilan", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Tgl            " + DTP.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Petugas                   " + Menu_Utama.Panel1.Text + Menu_Utama.Panel2.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Trans                      " + LblNomor.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 35
        e.Graphics.DrawString("ID Anggota               : " + ComboBox1.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Nama                       : " + LblNama.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Saldo                       : " + LblSaldo.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Simpanan Sukarela    : " + LblSukaRela.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Jumlah                     : " + TxtJumlah.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        
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