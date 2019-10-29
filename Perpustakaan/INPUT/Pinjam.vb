Imports MySql.Data.MySqlClient
Public Class Pinjam
    Dim tg As Integer = 0
    Sub Tampil()
        DS = New DataSet
        Query = "select * from peminjaman"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_pinjam.DataSource = DS.Tables(0)
    End Sub
    Sub bersih()
        tidpinjam.Clear()
        tidanggota.Clear()
        tnama.Clear()
        tidbuku.Clear()
        tjudulbuku.Text = ""
        dtanggalpinjam.Text = ""
        dtanggalkembali.Text = ""

    End Sub

    Private Sub bcarianggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcarianggota.Click
        list_anggota.ShowDialog()
    End Sub

    Private Sub bcaribuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcaribuku.Click
        list_buku.ShowDialog()
    End Sub

    Private Sub tsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsimpan.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        ' Query = "INSERT INTO `peminjaman` (`id_pinjam`, `id_anggota`, `id_buku`, `nama`, `judul_buku`, `tgl_pinjam`, `tgl_kembali`) VALUES ('" & tidpinjam.Text & "','" & tidanggota.Text & "','" & tnama.Text & "', '" & tidbuku.Text & "', '" & tjudulbuku.Text & "', '" & Format(dtanggalpinjam.Value, "yyyy-MM-dd") & "', '" & Format(dtanggalkembali.Value, "yyyy-MM-dd") & "')"
        Query = "INSERT INTO peminjaman values ('" & tidpinjam.Text & "','" & tidanggota.Text & "' , '" & tidbuku.Text & "','" & tnama.Text & "', '" & tjudulbuku.Text & "', '" & Format(dtanggalpinjam.Value, "yyyy-MM-dd") & "', '" & Format(dtanggalkembali.Value, "yyyy-MM-dd") & "')"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil Disimpan")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudulbuku.Text = ""
        Tampil()
    End Sub

    Private Sub tupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "update peminjaman set tgl_pinjam='" & dtanggalpinjam.Text & "', tgl_kembali='" & dtanggalkembali.Text & "', nama='" & tnama.Text & "', id_anggota='" & tidanggota.Text & "', id_buku='" & tidbuku.Text & "', judul_buku='" & tjudulbuku.Text & "' where id_pinjam='" & tidpinjam.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudulbuku.Text = ""
        Format(dtanggalpinjam.Value, "yyyy-MM-dd")
        Format(dtanggalkembali.Value, "yyyy-MM-dd")
    End Sub

    Private Sub tdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdelete.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "delete from peminjaman where id_pinjam='" & tidpinjam.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil hapus")
        tidpinjam.Text = ""
        tidanggota.Text = ""
        tnama.Text = ""
        tidbuku.Text = ""
        tjudulbuku.Text = ""
        Format(dtanggalpinjam.Value, "yyyy-MM-dd")
        Format(dtanggalkembali.Value, "yyyy-MM-dd")
    End Sub

    Private Sub tbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbatal.Click
        Call bersih()
    End Sub

    Private Sub tback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tback.Click
        Close()
    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "SELECT * FROM peminjaman where nama like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_pinjam.DataSource = DS.Tables(0)
    End Sub

    Private Sub tbl_pinjam_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_pinjam.CellClick
        Dim i As Integer
        i = tbl_pinjam.CurrentRow.Index
        tidpinjam.Text = tbl_pinjam.Item(0, i).Value
        tidanggota.Text = tbl_pinjam.Item(1, i).Value
        tnama.Text = tbl_pinjam.Item(2, i).Value
        tidbuku.Text = tbl_pinjam.Item(3, i).Value()
        tjudulbuku.Text = tbl_pinjam.Item(1, i).Value()
        Format(dtanggalpinjam.Value, "yyyy-MM-dd")
        Format(dtanggalkembali.Value, "yyyy-MM-dd")
    End Sub

    Private Sub Pinjem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
        Tampil()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Riport_Peminjaman.Show()
    End Sub

    Private Sub tidpinjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tidpinjam.TextChanged

    End Sub
End Class