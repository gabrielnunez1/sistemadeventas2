<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmcomprobanteconcliente
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientecon = New sistemadeventas2.clientecon()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.generar_comprobanteTableAdapter = New sistemadeventas2.clienteconTableAdapters.generar_comprobanteTableAdapter()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientecon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.clientecon
        '
        'clientecon
        '
        Me.clientecon.DataSetName = "clientecon"
        Me.clientecon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sistemadeventas2.rptcomprabantecon.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(927, 498)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(443, 157)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 1
        Me.txtidventa.Visible = False
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'fmcomprobanteconcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 498)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "fmcomprobanteconcliente"
        Me.Text = "Form1"
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientecon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents generar_comprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clientecon As sistemadeventas2.clientecon
    Friend WithEvents generar_comprobanteTableAdapter As sistemadeventas2.clienteconTableAdapters.generar_comprobanteTableAdapter
End Class
