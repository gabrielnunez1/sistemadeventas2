<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmbackupbase
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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnbackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.Location = New System.Drawing.Point(25, 12)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(283, 85)
        Me.btnbackup.TabIndex = 0
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'fmbackupbase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(335, 106)
        Me.Controls.Add(Me.btnbackup)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "fmbackupbase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
End Class
