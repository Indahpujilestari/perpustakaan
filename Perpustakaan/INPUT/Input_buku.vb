Imports MySql.Data.MySqlClient
Public Class Input_buku
    Dim tg As Integer = 0
    Sub Tampil()
        DS = New DataSet
        Query = "select * from buku"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_buku.DataSource = DS.Tables(0)
    End Sub
    Sub bersih()
        tid.Clear()
        tnama.Clear()
        ttahun_buku.Clear()
        tjudul_buku.Text = ""
        tpenerbit.Text = ""
        cjenis_buku.Text = ""
        tqty.Text = ""
        tg = 0
    End Sub

    Private Sub Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
        Tampil()

    End Sub
    Private Sub tbl_buku_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_buku.CellClick
        Dim i As Integer
        i = tbl_buku.CurrentRow.Index

        tid.Text = tbl_buku.Item(0, i).Value
        tnama.Text = tbl_buku.Item(1, i).Value
        ttahun_buku.Text = tbl_buku.Item(2, i).Value
        tjudul_buku.Text = tbl_buku.Item(3, i).Value()
        tpenerbit.Text = tbl_buku.Item(1, i).Value()
        cjenis_buku.Text = tbl_buku.Item(5, i).Value
        tqty.Text = tbl_buku.Item(3, i).Value
    End Sub
    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "SELECT * FROM buku where nama_pengarang like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_buku.DataSource = DS.Tables(0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Riport_buku.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "INSERT INTO buku values ('" & tid.Text & "', '" & tnama.Text & "','" & ttahun_buku.Text & "', '" & tjudul_buku.Text & "', '" & tpenerbit.Text & "', '" & cjenis_buku.Text & "', '" & tqty.Text & "')"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tid.Text = ""
        tnama.Text = ""
        ttahun_buku.Text = ""
        tjudul_buku.Text = ""
        tpenerbit.Text = ""
        cjenis_buku.Text = ""
        tqty.Text = ""
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "update buku set nama_pengarang='" & tnama.Text & "', thn_buku='" & ttahun_buku.Text & "', judul_buku='" & tjudul_buku.Text & "', penerbit='" & tpenerbit.Text & "', jenis_buku='" & cjenis_buku.Text & "', qty='" & tqty.Text & "' where id_buku='" & tid.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tid.Text = ""
        tnama.Text = ""
        ttahun_buku.Text = ""
        tjudul_buku.Text = ""
        tpenerbit.Text = ""
        cjenis_buku.Text = ""
        tqty.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "delete from buku where id_buku='" & tid.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil hapus")
        tid.Text = ""
        tnama.Text = ""
        ttahun_buku.Text = ""
        tjudul_buku.Text = ""
        tpenerbit.Text = ""
        cjenis_buku.Text = ""
        tqty.Text = ""
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Call bersih()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Close()

    End Sub

    
    Private Sub tid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tid.TextChanged

    End Sub
End Class