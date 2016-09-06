Public Class SplashScreen


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If ProgressBar1.Value <= 15 Then
            Label1.Text = " Membaca Data Pegawai ..."
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Membaca Data Anggota..."
        ElseIf ProgressBar1.Value <= 45 Then
            Label1.Text = "Membaca Data Transaksi..."
        ElseIf ProgressBar1.Value <= 60 Then
            Label1.Text = " Membaca Data Laporan..."
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "        Pembacaan Selesai"
            Label2.Text = "          Mohon Tunggu.."
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Dim Log As New Login
            Log.Show()
            Me.Hide()
        End If
    End Sub

End Class