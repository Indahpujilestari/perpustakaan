Imports MySql.Data.MySqlClient
Public Class list_pinjam

    Sub Tampil()
        DS = New DataSet
        Query = "select * from peminjaman"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_listpinjam.DataSource = DS.Tables(0)
    End Sub


    Private Sub list_pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub tbl_listpinjam_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_listpinjam.CellContentClick
        With tbl_listpinjam
            Try
                Kembali.tidpinjam.Text = .Item(0, .CurrentRow.Index).Value
                Kembali.tidanggota.Text = .Item(1, .CurrentRow.Index).Value
                Kembali.tnama.Text = .Item(2, .CurrentRow.Index).Value
                Kembali.tidbuku.Text = .Item(3, .CurrentRow.Index).Value
                Kembali.tjudul.Text = .Item(4, .CurrentRow.Index).Value
                Kembali.ttglpinjam.Text = .Item(5, .CurrentRow.Index).Value

                '==============================================================
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
    End Sub
End Class