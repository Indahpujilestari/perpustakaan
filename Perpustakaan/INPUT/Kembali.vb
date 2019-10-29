Imports MySql.Data.MySqlClient
Public Class Kembali
    Dim tg As Integer = 0
    Sub Tampil()
        DS = New DataSet
        Query = "select * from pengembalian"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_kembali.DataSource = DS.Tables(0)
    End Sub
    Sub bersih()
        tidpinjam.Clear()
        tidanggota.Clear()
        tnama.Clear()
        tidbuku.Clear()
        tjudul.Text = ""
        ttglpinjam.Text = ""
        ttglkembali.Text = ""
        tlama.Text = ""
        tdenda.Text = ""
        ttotal.Text = ""
        Format(ttglpinjam.Value, "yyyy-MM-dd")
        Format(ttglkembali.Value, "yyyy-MM-dd")

    End Sub

    Private Sub Kembali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
        Tampil()
    End Sub

    Private Sub tback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tback.Click
        Close()

    End Sub

    Private Sub tbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbatal.Click
        Call bersih()
    End Sub

    Private Sub tbl_kembali_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_kembali.CellClick
        Dim i As Integer
        i = tbl_kembali.CurrentRow.Index
        tidpinjam.Text = tbl_kembali.Item(0, i).Value
        tidanggota.Text = tbl_kembali.Item(1, i).Value
        tnama.Text = tbl_kembali.Item(2, i).Value
        tidbuku.Text = tbl_kembali.Item(3, i).Value()
        tjudul.Text = tbl_kembali.Item(1, i).Value()
        tlama.Text = tbl_kembali.Item(2, i).Value
        tdenda.Text = tbl_kembali.Item(3, i).Value()
        ttotal.Text = tbl_kembali.Item(1, i).Value()
        Format(ttglpinjam.Value, "yyyy-MM-dd")
        Format(ttglkembali.Value, "yyyy-MM-dd")
   
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "SELECT * FROM pengembalian where nama like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_kembali.DataSource = DS.Tables(0)
    End Sub

    Private Sub tdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdelete.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "delete from pengembalian where id_kembali='" & tidpinjam.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil hapus")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudul.Text = ""
        tlama.Text = ""
        tdenda.Text = ""
        ttotal.Text = ""
        Format(ttglpinjam.Value, "yyyy-MM-dd")
        Format(ttglkembali.Value, "yyyy-MM-dd")

    End Sub

    Private Sub tupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "update pengembalian set  tgl_pinjam='" & ttglpinjam.Text & "', denda='" & tdenda.Text & "', judul_buku='" & tjudul.Text & "', id_buku='" & tidbuku.Text & "', lama_pinjam='" & tlama.Text & "', nama='" & tnama.Text & "', id_anggota='" & tidanggota.Text & "', id_buku='" & tidbuku.Text & "', total='" & ttotal.Text & "'  where id_pinjam='" & tidpinjam.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudul.Text = ""
        tlama.Text = ""
        tdenda.Text = ""
        ttotal.Text = ""
        Format(ttglpinjam.Value, "yyyy-MM-dd")
        Format(ttglkembali.Value, "yyyy-MM-dd")
    End Sub

    Private Sub tsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsimpan.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "INSERT INTO pengembalian values ('" & tidpinjam.Text & "' , '" & Format(ttglkembali.Value, "yyyy-MM-dd") & "', '" & Format(ttglpinjam.Value, "yyyy-MM-dd") & "', '" & tdenda.Text & "', '" & tjudul.Text & "', '" & tlama.Text & "','" & tnama.Text & "', '" & tidanggota.Text & "','" & tidbuku.Text & "', '" & ttotal.Text & "')"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudul.Text = ""
        tlama.Text = ""
        tdenda.Text = ""
        ttotal.Text = ""
        Format(ttglpinjam.Value, "yyyy-MM-dd")
        Format(ttglkembali.Value, "yyyy-MM-dd")
    End Sub

    Private Sub bcaridata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcaridata.Click
        list_pinjam.ShowDialog()
    End Sub

    Private Sub blama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blama.Click
        Dim lama As Integer
        lama = DateDiff(DateInterval.Day, ttglpinjam.Value, ttglkembali.Value)
        tlama.Text = lama
    End Sub

    Private Sub bhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bhitung.Click
        If Val(tlama.Text) > 6 Then
            ttotal.Text = (Val(tlama.Text) - 6) * Val(tdenda.Text)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Riport_Pengembalian.Show()
    End Sub

    Private Sub tidpinjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tidpinjam.TextChanged

    End Sub
End Class