<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fminicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fminicio))
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexToolStripMenuItem, Me.ToolStripSeparator8})
        Me.HelpMenu.Image = CType(resources.GetObject("HelpMenu.Image"), System.Drawing.Image)
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(100, 34)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(190, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(80, 34)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(804, 22)
        Me.StatusStrip.TabIndex = 11
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ToolsMenu, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(804, 38)
        Me.MenuStrip.Stretch = False
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.RegistroDeVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Image = CType(resources.GetObject("VentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(103, 34)
        Me.VentasToolStripMenuItem.Text = "&Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Image = CType(resources.GetObject("NuevaVentaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.NuevaVentaToolStripMenuItem.Text = "&Nueva Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDeProductosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(122, 34)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarBackupToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.ToolsMenu.Image = CType(resources.GetObject("ToolsMenu.Image"), System.Drawing.Image)
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(165, 34)
        Me.ToolsMenu.Text = "&Herramientas"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(232, 34)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Image = Global.sistemadeventas2.My.Resources.Resources.paper
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(219, 34)
        Me.RegistroDeVentasToolStripMenuItem.Text = "&Detalle Ventas"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem1})
        Me.IngresosToolStripMenuItem.Image = Global.sistemadeventas2.My.Resources.Resources.books
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(119, 34)
        Me.IngresosToolStripMenuItem.Text = "&Ingresos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(175, 34)
        Me.CategoriasToolStripMenuItem.Text = "Categoria"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(175, 34)
        Me.ProductosToolStripMenuItem.Text = "Producto"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = CType(resources.GetObject("ClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(175, 34)
        Me.ClientesToolStripMenuItem1.Text = "Cliente"
        '
        'ReportesDeProductosToolStripMenuItem
        '
        Me.ReportesDeProductosToolStripMenuItem.Image = Global.sistemadeventas2.My.Resources.Resources.Printer1
        Me.ReportesDeProductosToolStripMenuItem.Name = "ReportesDeProductosToolStripMenuItem"
        Me.ReportesDeProductosToolStripMenuItem.Size = New System.Drawing.Size(295, 34)
        Me.ReportesDeProductosToolStripMenuItem.Text = "Reportes de Productos"
        '
        'GenerarBackupToolStripMenuItem
        '
        Me.GenerarBackupToolStripMenuItem.Image = Global.sistemadeventas2.My.Resources.Resources.backup
        Me.GenerarBackupToolStripMenuItem.Name = "GenerarBackupToolStripMenuItem"
        Me.GenerarBackupToolStripMenuItem.Size = New System.Drawing.Size(232, 34)
        Me.GenerarBackupToolStripMenuItem.Text = "Generar Backup"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(152, 34)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'fminicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(804, 468)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "fminicio"
        Me.Text = ".:. Sistema de Ventas .:."
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
