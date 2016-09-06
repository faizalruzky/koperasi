Imports System.Data.SqlClient
Public Class Login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Koneksi()
        cmd = New SqlCommand("select * from tabel_petugas where nama_ptgs='" & TextBox1.Text & "' and password_ptgs='" & TextBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("login gagal, periksa kembali user name dan password")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()

        Else

            Me.Visible = False
            Menu_Utama.Show()
            Menu_Utama.Panel1.Text = rd.Item("kode_ptgs")
            Menu_Utama.Panel2.Text = rd.Item("nama_ptgs")
            Menu_Utama.Panel3.Text = rd.Item("status_ptgs")


            If Menu_Utama.Panel3.Text = "OPERATOR" Then
                Menu_Utama.tblPetugas.Enabled = False
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(12) Then TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(12) Then Button1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub


End Class