Imports Microsoft.Reporting.WinForms

Public Class fmreportecomprobante
    Public Camp As String
    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.reportecomprobanteTableAdapter.Fill(Me.rptcomprobante.reportecomprobante)
            'Me.Generar_comprobanteTableAdapter.Fill(Me.dbventasDataSet1.generar_comprobante, idventa:=txtidventa.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try

        Dim parameters As New List(Of ReportParameter)()
        parameters.Add(New ReportParameter("demoParameter", Camp))
        parameters.Add(New ReportParameter("demoParameter1", venta.consumidorfinal.Text.ToString))
        parameters.Add(New ReportParameter("demoParameter2", venta.txtcantidad.Text.ToString))
        parameters.Add(New ReportParameter("demoParameter3", venta.txtcantidad.Text.ToString))


        ReportViewer1.LocalReport.SetParameters(parameters)

        ReportViewer1.RefreshReport()


      



    End Sub

End Class