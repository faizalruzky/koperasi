Imports System.Data.SqlClient
Public Class Petugas
    Sub Kosongkan()
        TKode.Text = ""
        TNama.Text = ""
        TPassword.Text = ""
        CmbStatus.Text = ""
        TKode.Focus()
    End Sub

    Sub DataBaru()
        TNama.Text = ""
        TPassword.Text = ""
        CmbStatus.Text = ""
        TNama.Focus()
    End Sub
    Sub otomatis()
        Try
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tabel_petugas ORDER BY kode_ptgs DESC", conn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            Dim kode_petugas As String = 0
            Try
                If Not dr.HasRows Then
                    kode_petugas = "OPR001"
                Else
                    kode_petugas = Val(Microsoft.VisualBasic.Mid(dr.Item("kode_ptgs").ToString, 4, 3)) + 1
                    If Len(kode_petugas) = 1 Then
                        kode_petugas = "OPR00" & kode_petugas & ""
                    ElseIf Len(kode_petugas) = 2 Then
                        kode_petugas = "OPR0" & kode_petugas & ""
                    ElseIf Len(kode_petugas) = 3 Then
                        kode_petugas = "OPR" & kode_petugas & ""
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                TKode.Text = kode_petugas
                'conn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Petugas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call otomatis()
    End Sub
    Sub Tampilkan()
        Call Koneksi()
        da = New SqlDataAdapter("Select * from tabel_petugas ORDER BY 1", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    
    Private Sub Petugas_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampilkan()
        Koneksi()
    End Sub

    Sub TampilstatusPTG()
        CmbStatus.Items.Clear()
        cmd = New SqlCommand("select distinct status_ptgs from tabel_petugas", conn)
        rd = cmd.ExecuteReader
        While rd.Read
            CmbStatus.Items.Add(rd.GetString(0))
        End While
    End Sub


    Private Sub Petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Call Koneksi()
        Call Tampilkan()
        CmbStatus.Items.Add("ADMINISTRATOR")
        CmbStatus.Items.Add("OPERATOR")
        'CmbStatus.Items.Add("USER")
    End Sub

    Private Sub CmbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbStatus.KeyPress
        CmbStatus.MaxLength = 15
        If e.KeyChar = Chr(13) Then CmdSimpan.Focus()
    End Sub
    Private Sub TKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKode.KeyPress
        TKode.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            TKode.Text = UCase(TKode.Text)
            cmd = New SqlCommand("select * from tabel_petugas where kode_ptgs='" & TKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TNama.Text = rd.Item("nama_ptgs")
                TPassword.Text = rd.Item("password_ptgs")
                CmbStatus.Text = rd.Item("status_ptgs")
                TNama.Focus()
            Else
                Call DataBaru()
                TNama.Focus()
            End If
        End If
    End Sub

    Private Sub TNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNama.KeyPress
        TNama.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TPassword.Focus()
            TNama.Text = UCase(TNama.Text)
        End If

    End Sub

    Private Sub TPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TPassword.KeyPress
        TPassword.MaxLength = 12
        If e.KeyChar = Chr(13) Then CmbStatus.Focus()
    End Sub
    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click

        If TKode.Text = "" Or TNama.Text = "" Or TPassword.Text = "" Or CmbStatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub

        Else
            Call Koneksi()
            cmd = New SqlCommand("Select * from tabel_petugas where kode_ptgs='" & TKode.Text & "'", conn)
            rd = cmd.ExecuteReader


            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into tabel_petugas(kode_ptgs,nama_ptgs,password_ptgs,status_ptgs) values " & _
                "('" & TKode.Text & "','" & TNama.Text & "','" & TPassword.Text & "','" & CmbStatus.Text & "')"
                cmd = New SqlCommand(sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan")
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit As String = "Update tabel_petugas set " & _
                "nama_ptgs='" & TNama.Text & "', " & _
                "password_ptgs='" & TPassword.Text & "', " & _
                "status_ptgs='" & CmbStatus.Text & "' where kode_ptgs='" & TKode.Text & "'"
                cmd = New SqlCommand(sqledit, conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
                MsgBox("Data Berhasil disimpan")
            End If
        End If

    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Call Kosongkan()
        Call otomatis()
    End Sub

    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        Me.Close()
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If TKode.Text = "" Then
            MsgBox("Isi kode Petugas terlebih dahulu")
            TKode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim sqlhapus As String = "Delete  from tabel_petugas where nama_ptgs='" & TNama.Text & "'",
                cmd = New SqlCommand(sqlhapus, conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
                MsgBox("Data Berhasil dihapus")
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        TKode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TNama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TPassword.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        CmbStatus.Text = DGV.Rows(e.RowIndex).Cells(3).Value

    End Sub
End Class