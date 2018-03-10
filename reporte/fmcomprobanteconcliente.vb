
Public Class fmcomprobanteconcliente

    Private Sub fmcomprobanteconcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            Me.generar_comprobanteTableAdapter.Fill(Me.clientecon.generar_comprobante, idventa:=txtidventa.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()

        End Try
        

    End Sub
End Class