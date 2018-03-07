<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmproducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmproducto))
        Me.btnguardar2 = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtprecio_venta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.txtnom_categoria = New System.Windows.Forms.TextBox()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mantenimiento = New System.Windows.Forms.GroupBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnguardar2
        '
        Me.btnguardar2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnguardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar2.Location = New System.Drawing.Point(186, 442)
        Me.btnguardar2.Name = "btnguardar2"
        Me.btnguardar2.Size = New System.Drawing.Size(82, 34)
        Me.btnguardar2.TabIndex = 27
        Me.btnguardar2.Text = "Guardar2"
        Me.btnguardar2.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = CType(resources.GetObject("btnlimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(336, 373)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(79, 62)
        Me.btnlimpiar.TabIndex = 25
        Me.btnlimpiar.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImage = CType(resources.GetObject("btncargar.BackgroundImage"), System.Drawing.Image)
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(336, 281)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(79, 70)
        Me.btncargar.TabIndex = 24
        Me.btncargar.TabStop = False
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(6, 54)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Location = New System.Drawing.Point(104, 442)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(86, 34)
        Me.btneliminar.TabIndex = 15
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(319, 227)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistente"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(133, 28)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(318, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre", "nombre_categoria"})
        Me.cbocampo.Location = New System.Drawing.Point(6, 27)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(121, 21)
        Me.cbocampo.TabIndex = 1
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 77)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(841, 359)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.Width = 50
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 258)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "Fecha de vencimiento:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'imagen
        '
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Location = New System.Drawing.Point(147, 281)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(183, 154)
        Me.imagen.TabIndex = 23
        Me.imagen.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Categoria:"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Location = New System.Drawing.Point(186, 442)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(82, 34)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Location = New System.Drawing.Point(287, 442)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(82, 34)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Location = New System.Drawing.Point(81, 442)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(82, 34)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtprecio_venta
        '
        Me.txtprecio_venta.Location = New System.Drawing.Point(146, 229)
        Me.txtprecio_venta.MaxLength = 8
        Me.txtprecio_venta.Name = "txtprecio_venta"
        Me.txtprecio_venta.Size = New System.Drawing.Size(75, 20)
        Me.txtprecio_venta.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio de Venta:"
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.Location = New System.Drawing.Point(146, 203)
        Me.txtprecio_compra.MaxLength = 9
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.Size = New System.Drawing.Size(75, 20)
        Me.txtprecio_compra.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio de Compra:"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(146, 177)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(74, 20)
        Me.txtstock.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stock:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(146, 117)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(269, 54)
        Me.txtdescripcion.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 70)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Location = New System.Drawing.Point(16, 442)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(82, 34)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Imagen:"
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(146, 255)
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(200, 20)
        Me.txtfecha_vencimiento.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Idproducto:"
        Me.Label1.Visible = False
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnbuscarcategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbuscarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(375, 75)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(40, 36)
        Me.btnbuscarcategoria.TabIndex = 19
        Me.btnbuscarcategoria.Text = "..."
        Me.btnbuscarcategoria.UseVisualStyleBackColor = False
        '
        'txtnom_categoria
        '
        Me.txtnom_categoria.Enabled = False
        Me.txtnom_categoria.Location = New System.Drawing.Point(146, 81)
        Me.txtnom_categoria.Name = "txtnom_categoria"
        Me.txtnom_categoria.Size = New System.Drawing.Size(223, 20)
        Me.txtnom_categoria.TabIndex = 18
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Enabled = False
        Me.txtidcategoria.Location = New System.Drawing.Point(146, 80)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(38, 20)
        Me.txtidcategoria.TabIndex = 17
        Me.txtidcategoria.Visible = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(381, 5)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(36, 20)
        Me.txtflag.TabIndex = 31
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(145, 50)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(269, 20)
        Me.txtnombre.TabIndex = 3
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(390, 52)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(272, 20)
        Me.txtidproducto.TabIndex = 1
        Me.txtidproducto.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(853, 482)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de productos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(77, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(274, 29)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Registro de Productos"
        '
        'mantenimiento
        '
        Me.mantenimiento.Controls.Add(Me.txtcod)
        Me.mantenimiento.Controls.Add(Me.Label8)
        Me.mantenimiento.Controls.Add(Me.btnguardar2)
        Me.mantenimiento.Controls.Add(Me.Label2)
        Me.mantenimiento.Controls.Add(Me.CheckBox1)
        Me.mantenimiento.Controls.Add(Me.btnlimpiar)
        Me.mantenimiento.Controls.Add(Me.btncargar)
        Me.mantenimiento.Controls.Add(Me.imagen)
        Me.mantenimiento.Controls.Add(Me.Label9)
        Me.mantenimiento.Controls.Add(Me.txtfecha_vencimiento)
        Me.mantenimiento.Controls.Add(Me.Label1)
        Me.mantenimiento.Controls.Add(Me.btnbuscarcategoria)
        Me.mantenimiento.Controls.Add(Me.txtnom_categoria)
        Me.mantenimiento.Controls.Add(Me.txtidcategoria)
        Me.mantenimiento.Controls.Add(Me.Label7)
        Me.mantenimiento.Controls.Add(Me.btnguardar)
        Me.mantenimiento.Controls.Add(Me.btncancelar)
        Me.mantenimiento.Controls.Add(Me.btnnuevo)
        Me.mantenimiento.Controls.Add(Me.txtprecio_venta)
        Me.mantenimiento.Controls.Add(Me.Label5)
        Me.mantenimiento.Controls.Add(Me.txtprecio_compra)
        Me.mantenimiento.Controls.Add(Me.Label6)
        Me.mantenimiento.Controls.Add(Me.txtstock)
        Me.mantenimiento.Controls.Add(Me.Label3)
        Me.mantenimiento.Controls.Add(Me.txtdescripcion)
        Me.mantenimiento.Controls.Add(Me.Label4)
        Me.mantenimiento.Controls.Add(Me.txtnombre)
        Me.mantenimiento.Location = New System.Drawing.Point(2, 78)
        Me.mantenimiento.Name = "mantenimiento"
        Me.mantenimiento.Size = New System.Drawing.Size(429, 482)
        Me.mantenimiento.TabIndex = 28
        Me.mantenimiento.TabStop = False
        Me.mantenimiento.Text = "Mantenimiento"
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(145, 19)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(269, 20)
        Me.txtcod.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Codigo de Barra:"
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'fmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1287, 564)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.mantenimiento)
        Me.Controls.Add(Me.txtidproducto)
        Me.Name = "fmproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. Listado de productos .:."
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.mantenimiento.ResumeLayout(False)
        Me.mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar2 As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents btncargar As System.Windows.Forms.PictureBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtprecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfecha_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarcategoria As System.Windows.Forms.Button
    Friend WithEvents txtnom_categoria As System.Windows.Forms.TextBox
    Friend WithEvents txtidcategoria As System.Windows.Forms.TextBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
End Class
