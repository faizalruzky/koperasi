Public Class Menu_Utama
    Private Sub tblAnggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblAnggota.Click
        Data_Anggota.Show()
    End Sub
    Private Sub tblPetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblPetugas.Click
        Petugas.Show()
    End Sub

    Private Sub tblSimpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpanan.Click
        Setoran.Show()
    End Sub
    Private Sub tblPengambilan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblPengambilan.Click
        Pengambilan.Show()
    End Sub
    Private Sub tblPinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblPinjaman.Click
        Pinjaman.Show()
    End Sub
    Private Sub tblBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblBayar.Click
        Bayar_Cicilan.Show()
    End Sub
    Private Sub tblGPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblGPassword.Click
        GantiPassword.Show()
    End Sub
    Private Sub tblLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblLaporan.Click
        Laporan.Show()
    End Sub
    Private Sub Menu_Utama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            If MessageBox.Show("Tutup aplikasi..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                End
            End If
        End If
    End Sub
   

    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        If MessageBox.Show("Tutup aplikasi..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    
    End Class