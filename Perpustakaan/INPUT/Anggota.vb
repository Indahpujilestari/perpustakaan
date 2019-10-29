Imports MySql.Data.MySqlClient
Public Class Anggota
    Dim tg As Integer = 0
    

    Sub Tampil()
        DS = New DataSet
        Query = "select * from anggota"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_anggota.DataSource = DS.Tables(0)
    End Sub
    Sub bersih()
        tid.Clear()
        tnama.Clear()
        talamat.Clear()
        cjk.Text = ""
        cangkatan.Text = ""
        cprodi.Text = ""

    End Sub



    Private Sub Anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
        Tampil()

    End Sub

    Private Sub lsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsimpan.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "insert into anggota values('" & tid.Text & "', '" & tnama.Text & "','" & talamat.Text & "', '" & cjk.Text & "', '" & cangkatan.Text & "', '" & cprodi.Text & "')"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tid.Text = ""
        tnama.Text = ""
        talamat.Text = ""
        cjk.Text = ""
        cangkatan.Text = ""
        cprodi.Text = ""

    End Sub


    Private Sub lupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lupdate.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "update anggota set nama='" & tnama.Text & "', alamat='" & talamat.Text & "', jk='" & cjk.Text & "', angkatan='" & cangkatan.Text & "', jurusan='" & cprodi.Text & "' where id_anggota='" & tid.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil Disimpan")
        tid.Text = ""
        tnama.Text = ""
        talamat.Text = ""
        cjk.Text = ""
        cangkatan.Text = ""
        cprodi.Text = ""


    End Sub

    Private Sub ldelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ldelete.Click
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "delete from anggota where id_anggota='" & tid.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        Tampil()
        MsgBox("Berhasil hapus")
        tid.Text = ""
        tnama.Text = ""
        talamat.Text = ""
        cjk.Text = ""
        cangkatan.Text = ""
        cprodi.Text = ""

    End Sub

    Private Sub lbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbatal.Click
        Call bersih()
    End Sub

    Private Sub lback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lback.Click
        Close()
    End Sub

    Private Sub cjurusan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cprodi.SelectedIndexChanged

    End Sub

    Private Sub tbl_anggota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        

    End Sub

    Private Sub tcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcari.TextChanged
        DS = New DataSet
        Query = "select * from anggota where nama like '%" & tcari.Text & "%'"
        DA = New MySqlDataAdapter(Query, CONN)
        DA.Fill(DS)
        tbl_anggota.DataSource = DS.Tables(0)
    End Sub

    Private Sub tbl_anggota_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_anggota.CellClick
        Dim i As Integer
        i = tbl_anggota.CurrentRow.Index

        tid.Text = tbl_anggota.Item(0, i).Value
        tnama.Text = tbl_anggota.Item(1, i).Value
        talamat.Text = tbl_anggota.Item(2, i).Value
        cjk.Text = tbl_anggota.Item(3, i).Value()
        cangkatan.Text = tbl_anggota.Item(4, i).Value()
        cprodi.Text = tbl_anggota.Item(5, i).Value
    End Sub


    Private Sub tbl_anggota_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tbl_anggota.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Riport_anggota.Show()

    End Sub

    Private Sub tid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tid.TextChanged

    End Sub
End Class