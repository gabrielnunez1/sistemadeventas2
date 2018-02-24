Public Class fmcliente
    Private dt As New DataTable

    Private Sub fmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnguardar2.Visible = False
        mostrar()
        ocultar_columnas()
    End Sub

    Public Sub limpiar()
        btnguardar2.Visible = False
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtdireccion.Text = ""
        txtidcliente.Text = ""
        txtdni.Text = ""

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fCliente
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If cbocampo.Text <> String.Empty Then
                dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"
                If dv.Count <> 0 Then
                    inexistente.Visible = False
                    datalistado.DataSource = dv
                    ocultar_columnas()
                Else
                    inexistente.Visible = True
                    datalistado.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(6).Visible = False

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor, este dato es obligatorio")
        End If

    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtapellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese los apellidos del cliente porfavor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del cliente porfavor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdni_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el dni del cliente porfavor, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txtdni.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New fcliente

                dts.gnombres = txtnombres.Text
                dts.gapellidos = txtapellidos.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gdni = txtdni.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta inglesar algun datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick


        limpiar()


        btneditar.Visible = True


    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Me.Size = New System.Drawing.Size(870, 515)
        Me.GroupBox2.Location = New Point(284, 71)
        btnguardar2.Visible = True

        txtidcliente.Text = datalistado.SelectedCells.Item(6).Value
        txtnombres.Text = datalistado.SelectedCells.Item(1).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(2).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(3).Value
        txtdni.Text = datalistado.SelectedCells.Item(5).Value
        txttelefono.Text = datalistado.SelectedCells.Item(4).Value.ToString 'esto es para que acepte null





    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            venta.txtidcliente.Text = datalistado.SelectedCells.Item(6).Value
            venta.txtnombre_cliente.Text = datalistado.SelectedCells.Item(1).Value
            venta.TextBox1.Text = datalistado.SelectedCells.Item(5).Value
            venta.foco()
            Me.Close()
        End If


    End Sub

    Private Sub txtnombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombres.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub btnguardar2_Click(sender As Object, e As EventArgs) Handles btnguardar2.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txtdni.Text <> "" And txtidcliente.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gidcliente = txtidcliente.Text
                    dts.gnombres = txtnombres.Text
                    dts.gapellidos = txtapellidos.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gdni = txtdni.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Cliente modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Cliente no fue modificado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta inglesar algun datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub
End Class