Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Laporan
    Sub TglSetoran()
        Call Koneksi()
        

        cmd = New SqlCommand("select distinct month(Tanggal) as Bulan from tabel_simpanan", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop

        cmd = New SqlCommand("select distinct year(Tanggal) as Tahun from TABEL_SIMPANAN", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox2.Items.Add(rd.Item(0))
        Loop
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.ReportSource = Nothing
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi\LaporanAnggota.rpt")
        CRV.ReportSource = cryRpt
        CRV.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.RefreshReport()
        CRV.ReportSource = Nothing
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi\Laporan Setoran Harian.rpt")
        CRV.ReportSource = cryRpt
        CRV.SelectionFormula = "totext({tabel_simpanan.tanggal}) = '" & Format(Me.DTP1.Value, "yyyy-MM-dd") & "'"
        CRV.RefreshReport()
    End Sub
    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TglSetoran()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        CRV.RefreshReport()
        CRV.SelectionFormula = "Month({TABEL_SIMPANAN.TANGGAL})=" & Val(ComboBox1.Text) & " and Year({TABEL_SIMPANAN.TANGGAL})=" & Val(ComboBox2.Text)
        CRV.ReportSource = "C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi" & "\Laporan Setoran Bulanan.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CRV.RefreshReport()
        CRV.ReportSource = Nothing
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi\Laporan Pengambilan Harian.rpt")
        CRV.ReportSource = cryRpt
        CRV.SelectionFormula = "totext({tabel_pengambilan.tanggal}) = '" & Format(Me.DTP2.Value, "yyyy-MM-dd") & "'"
        CRV.RefreshReport()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ComboBox3.Text = "" Or ComboBox4.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.RefreshReport()
            CRV.SelectionFormula = "Month({tabel_pengambilan.Tanggal})=" & Val(ComboBox3.Text) & " and Year({tabel_pengambilan.Tanggal})=" & Val(ComboBox4.Text)
            CRV.ReportSource = "PengambilanBulanan.rpt"
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
       
        CRV.RefreshReport()
        CRV.ReportSource = Nothing
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi\Laporan Pinjaman Harian.rpt")
        CRV.ReportSource = cryRpt
        CRV.SelectionFormula = "totext({tabel_pinjaman.tanggal}) = '" & Format(Me.DTP3.Value, "yyyy-MM-dd") & "'"
        CRV.RefreshReport()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ComboBox5.Text = "" Or ComboBox6.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.RefreshReport()
            CRV.SelectionFormula = "Month({tabel_pinjaman.Tanggal})=" & Month(DTP2.Text) & " and Year({tabel_pinjaman.Tanggal})=" & Year(DTP2.Text)
            CRV.ReportSource = "PinjamanBulanan.rpt"
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        CRV.RefreshReport()
        CRV.ReportSource = Nothing
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Faizal Ruzky\Documents\Visual Studio 2010\Projects\koperasi\koperasi\Laporan Cicilan Harian.rpt")
        CRV.ReportSource = cryRpt
        CRV.SelectionFormula = "totext({tabel_bayar_cicilan.tanggal_bayar}) = '" & Format(Me.DTP4.Value, "yyyy-MM-dd") & "'"
        CRV.RefreshReport()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If ComboBox7.Text = "" Or ComboBox8.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.RefreshReport()
            CRV.SelectionFormula = "Month({tabel_bayar_cicilan.tanggal_bayar})=" & Val(ComboBox7.Text) & " and Year({tabel_bayar_cicilan.tanggal_bayar})=" & Val(ComboBox8.Text)
            CRV.ReportSource = "BayarBulanan.rpt"
            CRV.RefreshReport()
        End If
    End Sub

End Class