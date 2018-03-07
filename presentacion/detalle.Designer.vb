<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalle
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bus2 = New System.Windows.Forms.DateTimePicker()
        Me.bus = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btnnuevaventa = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datalistado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(82, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 29)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Detalle de venta"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Location = New System.Drawing.Point(255, 444)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(90, 33)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.datalistado.Controls.Add(Me.GroupBox2)
        Me.datalistado.Controls.Add(Me.GroupBox1)
        Me.datalistado.Controls.Add(Me.btnsalir)
        Me.datalistado.Controls.Add(Me.btnnuevaventa)
        Me.datalistado.Location = New System.Drawing.Point(3, 79)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.Size = New System.Drawing.Size(459, 483)
        Me.datalistado.TabIndex = 34
        Me.datalistado.TabStop = False
        Me.datalistado.Text = "Listado de Ventas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.bus2)
        Me.GroupBox2.Controls.Add(Me.bus)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 195)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas"
        '
        'bus2
        '
        Me.bus2.Location = New System.Drawing.Point(225, 18)
        Me.bus2.Name = "bus2"
        Me.bus2.Size = New System.Drawing.Size(200, 20)
        Me.bus2.TabIndex = 41
        '
        'bus
        '
        Me.bus.Location = New System.Drawing.Point(6, 18)
        Me.bus.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(200, 20)
        Me.bus.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(430, 145)
        Me.DataGridView1.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.DataGridView)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.inexistente)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 228)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(436, 154)
        Me.DataGridView.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(191, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 58)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(123, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 39)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label13.Location = New System.Drawing.Point(158, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 39)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "--"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(120, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 39)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(2, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 25)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Sub Total:"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(276, 125)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(89, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistente"
        '
        'btnnuevaventa
        '
        Me.btnnuevaventa.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnnuevaventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnuevaventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevaventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevaventa.Location = New System.Drawing.Point(122, 444)
        Me.btnnuevaventa.Name = "btnnuevaventa"
        Me.btnnuevaventa.Size = New System.Drawing.Size(116, 33)
        Me.btnnuevaventa.TabIndex = 0
        Me.btnnuevaventa.Text = "&Nueva Venta"
        Me.btnnuevaventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevaventa.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Label2"
        '
        'detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:.Detalle de venta.:."
        Me.datalistado.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents datalistado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents btnnuevaventa As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents bus As System.Windows.Forms.DateTimePicker
    Friend WithEvents bus2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
