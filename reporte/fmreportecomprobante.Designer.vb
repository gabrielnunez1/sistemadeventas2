<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmreportecomprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.reportecomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptcomprobante = New sistemadeventas2.rptcomprobante()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reportecomprobanteTableAdapter = New sistemadeventas2.rptcomprobanteTableAdapters.reportecomprobanteTableAdapter()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        CType(Me.reportecomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptcomprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportecomprobanteBindingSource
        '
        Me.reportecomprobanteBindingSource.DataMember = "reportecomprobante"
        Me.reportecomprobanteBindingSource.DataSource = Me.rptcomprobante
        '
        'rptcomprobante
        '
        Me.rptcomprobante.DataSetName = "rptcomprobante"
        Me.rptcomprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "rptcomprobante"
        ReportDataSource2.Value = Me.reportecomprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sistemadeventas2.rptcomprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(820, 588)
        Me.ReportViewer1.TabIndex = 2
        '
        'reportecomprobanteTableAdapter
        '
        Me.reportecomprobanteTableAdapter.ClearBeforeFill = True
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(399, 175)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 3
        Me.txtidventa.Visible = False
        '
        'fmreportecomprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 588)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "fmreportecomprobante"
        Me.Text = "fmreportecomprobante"
        CType(Me.reportecomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptcomprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reportecomprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptcomprobante As sistemadeventas2.rptcomprobante
    Friend WithEvents reportecomprobanteTableAdapter As sistemadeventas2.rptcomprobanteTableAdapters.reportecomprobanteTableAdapter
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
End Class
