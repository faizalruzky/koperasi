Imports System.Data.SqlClient
Public Class Data_Anggota
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox2.Focus()
    End Sub
    Dim tinggi As Double = 0

    Sub DataBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox2.Focus()
    End Sub
    Sub otomatis()
        Try
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tabel_anggota ORDER BY ID_anggota DESC", conn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            Dim kode_anggota As String = 0
            Try
                If Not dr.HasRows Then
                    kode_anggota = "KSP001"
                Else
                    kode_anggota = Val(Microsoft.VisualBasic.Mid(dr.Item("ID_anggota").ToString, 4, 3)) + 1
                    If Len(kode_anggota) = 1 Then
                        kode_anggota = "KSP00" & kode_anggota & ""
                    ElseIf Len(kode_anggota) = 2 Then
                        kode_anggota = "KSP0" & kode_anggota & ""
                    ElseIf Len(kode_anggota) = 3 Then
                        kode_anggota = "KSP" & kode_anggota & ""
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                TextBox1.Text = kode_anggota
                'conn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Data_Anggota_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call otomatis()
    End Sub
    Sub Tampilkan()
        Call Koneksi()
        da = New SqlClient.SqlDataAdapter("Select * from tabel_anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    

    Private Sub Data_Anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 7
        If e.KeyChar = Chr(13) Then
            TextBox1.Text = UCase(TextBox1.Text)
            cmd = New SqlCommand("select * from tabel_anggota where ID_anggota='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TextBox2.Text = rd.Item("nama")
                TextBox3.Text = rd.Item("alamat")
                TextBox4.Text = rd.Item("telepon")
                TextBox5.Text = rd.Item("simpanan_wajib")
                TextBox6.Text = rd.Item("simpanan_pokok")
                TextBox7.Text = rd.Item("simpanan_sukarela")
                TextBox8.Text = rd.Item("saldo")
                TextBox2.Focus()
            Else
                Call DataBaru()
                TextBox2.Focus()
            End If

        End If
        ' If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = UCase(TextBox2.Text)
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox3.Text = UCase(TextBox3.Text)
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 13
        If e.KeyChar = Chr(13) Then TextBox5.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then TextBox6.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then TextBox7.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox8.Text = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text)
            TextBox8.Enabled = True
            BTNSimpan.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data Belum Lengkap ")
        ElseIf TextBox8.Text = "" Then
            MsgBox("Coba Enter di Simpanan Sukarela")

            Exit Sub
        Else
            cmd = New SqlCommand("Select * from tabel_anggota where ID_anggota='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into tabel_anggota(ID_anggota,nama,alamat,telepon,simpanan_wajib,simpanan_pokok,simpanan_sukarela,saldo) values " & _
                "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                cmd = New SqlCommand(sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan")
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit As String = "Update tabel_anggota set " & _
                "nama='" & TextBox2.Text & "', " & _
                "alamat='" & TextBox3.Text & "', " & _
                "telepon='" & TextBox4.Text & "', " & _
                "simpanan_wajib='" & TextBox5.Text & "', " & _
                "simpanan_pokok='" & TextBox6.Text & "', " & _
                "simpanan_sukarela='" & TextBox7.Text & "', " & _
                "saldo='" & TextBox6.Text & "' where ID_anggota='" & TextBox1.Text & "'"
                cmd = New SqlCommand(sqledit, conn)
                cmd.ExecuteNonQuery()

                Call Kosongkan()
                Call Tampilkan()

            End If
        End If
    End Sub

    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
        Call otomatis()
    End Sub

    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub BTNHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi kode Anggota terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else

            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New SqlCommand("Delete from tabel_anggota where nama='" & TextBox2.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
                MsgBox("Data Berhasil dihapus")
            Else
                Call Kosongkan()
                Call otomatis()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
        Call otomatis()
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        TextBox7.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        TextBox8.Text = DGV.Rows(e.RowIndex).Cells(7).Value

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.ReadOnly = True
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''tinggi += 15
        e.Graphics.DrawString("                Koperasi Simpan Pinjam", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("       Jl Cipadung N0 92 Cibiru - Bandung", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                    CV. Faizal Ruzky", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 30
        e.Graphics.DrawString("                      Kartu Member", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 25
        e.Graphics.DrawString("============================", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("ID Anggota            : " + TextBox1.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Nama Anggota       : " + TextBox2.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Alamat                  : " + TextBox3.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("Telepon                 : " + TextBox4.Text, New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("---------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 10
        tinggi += 15
        e.Graphics.DrawString("Ket. Wajib Disimpan", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("---------------------------------------------------", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
        tinggi += 15
        e.Graphics.DrawString("                 ", New Drawing.Font("verdana", 8), Brushes.Black, 2, tinggi)
    End Sub
End Class