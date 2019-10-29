Public Class Form_Utama

    Private Sub Form_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksidatabase()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form_Login.Show()

    End Sub
End Class