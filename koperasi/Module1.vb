Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader
    Public str As String
    Public hasil As Integer

    Public Sub Koneksi()
        str = "Data Source=FAIZALRUZKY-PC\SQLEXPRESS;Initial Catalog=koperasidb;Integrated security=SSPI;Persist Security Info=true;MultipleActiveResultSets=True"
        conn = New SqlConnection(str)
        'MultipleActiveResultSets=True
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub

End Module
