Imports MySql.Data.MySqlClient
Public Class Form_Login

    Sub bersih()
        tuser.Clear()
        tpas.Clear()
        clevel.Text = ""
    End Sub

    Private Sub bbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbatal.Click
        Call bersih()
    End Sub

    Private Sub blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogin.Click
        Call koneksidatabase()
        CMD = New MySqlCommand
        CMD.Connection = CONN
        Query = "select * from admin where username ='" & tuser.Text & "' and '" & tpas.Text & "'"
        CMD.CommandText = Query
        CMD.ExecuteNonQuery()
        DR = CMD.ExecuteReader()
        DR.Read()

        If Not DR.HasRows Then
            Call koneksidatabase()
            MsgBox("login gagal")
            tuser.Clear()
            tpas.Clear()
            tuser.Clear()

        ElseIf clevel.Text = "Anggota" Then
            MsgBox("login berhasil")
            Me.Visible = False
            Buku.Show()
        ElseIf clevel.Text = "Admin" Then
            MsgBox("login berhasil")
            Me.Visible = False
            Form_Admin.Show()
        End If
    End Sub

    Private Sub clevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clevel.SelectedIndexChanged

    End Sub

    Private Sub Form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tuser.TextChanged

    End Sub
End Class