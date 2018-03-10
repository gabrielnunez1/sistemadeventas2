<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmlogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtlogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 203)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso al Sistema"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(168, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "&Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningresar.Location = New System.Drawing.Point(56, 136)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(93, 34)
        Me.btningresar.TabIndex = 5
        Me.btningresar.Text = "&Ingresar"
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(111, 80)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(198, 20)
        Me.txtpassword.TabIndex = 4
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(111, 45)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(198, 20)
        Me.txtlogin.TabIndex = 3
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(56, 9)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(56, 24)
        Me.lblhora.TabIndex = 13
        Me.lblhora.Text = "login"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'fmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(475, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmlogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
