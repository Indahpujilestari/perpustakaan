Public Class Riport_Peminjaman
    Sub tampil()
        Dim obj As New CRpeminjaman
        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.RefreshReport()
    End Sub
    Sub cetakid()
        Try
            Dim obj As New CRpeminjaman
            CrystalReportViewer1.ReportSource = obj
            'CrystalReportViewer1.SelectionFormula = "{id_buku}=" & TextBox1.Text & ""
            CrystalReportViewer1.Show()
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Riport_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub
End Class