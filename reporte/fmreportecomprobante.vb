Imports Microsoft.Reporting.WinForms

Public Class fmreportecomprobante


    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.reportecomprobanteTableAdapter.Fill(Me.rptcomprobante.reportecomprobante)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try

     

    End Sub

End Class