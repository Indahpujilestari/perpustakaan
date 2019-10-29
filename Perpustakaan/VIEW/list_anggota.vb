Imports MySql.Data.MySqlClient
Public Class list_anggota
    Sub Tampil()
        DS = New DataSet
        Query = "select * from anggota"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_listanggota.DataSource = DS.Tables(0)
    End Sub

    Private Sub list_anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub tbl_listanggota_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_listanggota.CellClick
        With tbl_listanggota
            Try
                Pinjam.tidanggota.Text = .Item(0, .CurrentRow.Index).Value
                Pinjam.tnama.Text = .Item(1, .CurrentRow.Index).Value
                '==============================================================
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
    End Sub

    Private Sub tbl_listanggota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_listanggota.CellContentClick

    End Sub
End Class