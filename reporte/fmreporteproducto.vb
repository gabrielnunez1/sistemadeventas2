Public Class fmreporteproducto

    Private Sub fmreporteproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'rptproducto.mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.mostrar_productoTableAdapter.Fill(Me.rptproducto.mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class