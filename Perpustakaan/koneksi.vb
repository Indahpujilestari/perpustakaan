Imports MySql.Data.MySqlClient
Module koneksi
    Public CONN As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public connString As String
    Public Query As String

    Sub koneksidatabase()
        connString = "server=localhost;uid=root;password=;database=db_perpustakaan"
        CONN = New MySqlConnection(connString)

        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
                '   MsgBox("Koneksi Berhasil")
            End If

        Catch ex As Exception
            MsgBox("Koneksi gagal")
        End Try
    End Sub
End Module
