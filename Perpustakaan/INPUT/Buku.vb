Imports MySql.Data.MySqlClient
Public Class Buku
   Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "SELECT * FROM buku where nama_pengarang like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_buku.DataSource = DS.Tables(0)
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Riport_buku.Show()
    End Sub

  
End Class