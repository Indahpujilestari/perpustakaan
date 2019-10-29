Imports MySql.Data.MySqlClient
Public Class list_buku
    Sub Tampil()
        DS = New DataSet
        Query = "select * from buku"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_listbuku.DataSource = DS.Tables(0)
    End Sub

    Private Sub list_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub tbl_listbuku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_listbuku.CellContentClick
        With tbl_listbuku
            Try
                Pinjam.tidbuku.Text = .Item(0, .CurrentRow.Index).Value
                Pinjam.tjudulbuku.Text = .Item(3, .CurrentRow.Index).Value
                '==============================================================
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
    End Sub
End Class