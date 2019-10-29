Imports MySql.Data.MySqlClient
Public Class Buku
    Sub Tampil()
        DS = New DataSet
        Query = "select * from buku"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_buku.DataSource = DS.Tables(0)
    End Sub
    Private Sub Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
        Tampil()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Riport_buku.Show()
    End Sub

    Private Sub tcari_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "SELECT * FROM buku where judul_buku like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_buku.DataSource = DS.Tables(0)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form_Login.Show()
    End Sub
End Class