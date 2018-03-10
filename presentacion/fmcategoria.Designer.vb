<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmcategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmcategoria))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 66)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Location = New System.Drawing.Point(113, 55)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(65, 29)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Location = New System.Drawing.Point(195, 55)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(65, 29)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Location = New System.Drawing.Point(113, 55)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(65, 29)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Location = New System.Drawing.Point(32, 55)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(65, 29)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(75, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Registro Categorías"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 91)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(108, 19)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(180, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Categoria:"
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Enabled = False
        Me.txtidcategoria.Location = New System.Drawing.Point(108, 19)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(181, 20)
        Me.txtidcategoria.TabIndex = 1
        Me.txtidcategoria.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Idcategoria:"
        Me.Label1.Visible = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 58)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(268, 291)
        Me.datalistado.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.Width = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Busqudad:"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(95, 190)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistente"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(117, 32)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(157, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre_categoria"})
        Me.cbocampo.Location = New System.Drawing.Point(3, 31)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(108, 21)
        Me.cbocampo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 355)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Categoria"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(258, 3)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(43, 20)
        Me.txtflag.TabIndex = 24
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'fmcategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(615, 365)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtflag)
        Me.Name = "fmcategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:.Listado de Categorías.:."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidcategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
End Class
