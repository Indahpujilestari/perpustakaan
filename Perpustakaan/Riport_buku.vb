Public Class Riport_buku
    Sub tampil()
        Dim obj As New CRbuku
        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.RefreshReport()
    End Sub
    Sub cetakid()
        Try
            Dim obj As New CRbuku
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

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class