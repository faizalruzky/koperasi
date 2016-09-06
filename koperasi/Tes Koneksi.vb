Imports System.Data.SqlClient
Public Class Tes_Koneksi

    Private Sub Tes_Koneksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New SqlDataAdapter("Select * from tabel_anggota", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
    End Sub

  
End Class
