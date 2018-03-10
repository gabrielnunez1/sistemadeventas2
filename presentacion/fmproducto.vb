Public Class fmproducto
    Private tabla As New DataSet
    Private dt As New DataTable

    Private Sub fmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnguardar2.Visible = False
        btneliminar.Visible = False
        mostrar()
        datalistado.Columns("precio_venta").Width = 50
        datalistado.Columns("precio_compra").Width = 50
        datalistado.Columns("nombre_categoria").Width = 150
        datalistado.Columns("nombre").Width = 150
        ocultar_columnas()
        txtfecha_vencimiento.Visible = False
        limpiar()
    End Sub
    Public Sub limpiar()
        btnguardar2.Visible = False
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnom_categoria.Text = ""
        txtnombre.Text = ""
        txtdescripcion.Text = ""
        txtstock.Text = "0"
        txtprecio_venta.Text = "0"
        txtprecio_compra.Text = "0"
        txtstock.Text = "0"
        txtidproducto.Text = ""
        txtcod.Text = ""
        txtfecha_vencimiento.Text = DateTime.Today
        CheckBox1.CheckState = CheckState.Unchecked
        imagen.Image = Nothing
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Private Sub mostrar()

        Try
            Dim func As New fproducto
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
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(10).Visible = False


    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtidcategoria.Text <> "" And txtnom_categoria.Text <> "" Then
            Try
                Dim dts As New vproducto
                Dim func As New fproducto

                dts.gnombre = txtnombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                dts.gimagen = ruta
                dts.gcod = txtcod.Text

                If CheckBox1.CheckState = CheckState.Checked Then
                    dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                Else : CheckBox1.CheckState = CheckState.Unchecked
                    dts.gfecha_vencimiento = Nothing
                End If

                If txtprecio_compra.Text < txtprecio_venta.Text Then
                    If func.insertar(dts) Then
                        MessageBox.Show("Producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()

                    Else
                        MessageBox.Show("Producto no registrado intente de nuevo", "Error al querer guardar producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Else
                    MessageBox.Show("Precio Compra no puede ser un numero mayor o igual a precio venta", "Error al querer guardar producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            chkcell.value = Not chkcell.value
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Me.Size = New System.Drawing.Size(1312, 600)
        Me.GroupBox2.Location = New Point(436, 79)
        btnguardar2.Visible = True
        txtcod.Text = datalistado.SelectedCells.Item(11).Value.ToString
        txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnom_categoria.Text = datalistado.SelectedCells.Item(3).Value
        txtnombre.Text = datalistado.SelectedCells.Item(4).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(5).Value.ToString
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txtprecio_compra.Text = datalistado.SelectedCells.Item(7).Value
        txtprecio_venta.Text = datalistado.SelectedCells.Item(8).Value

        If datalistado.SelectedCells.Item(9).Value.Equals(DBNull.Value) Then
            CheckBox1.CheckState = CheckState.Unchecked
            txtfecha_vencimiento.Text = DateTime.Today
            CheckBox1.CheckState = CheckState.Unchecked
        Else
            CheckBox1.CheckState = CheckState.Checked
            txtfecha_vencimiento.Text = datalistado.SelectedCells.Item(9).Value
        End If


        imagen.BackgroundImage = Nothing

        Try
            If datalistado.SelectedCells.Item(10).Value.ToString = "" Then
                imagen.Image = Nothing
            Else
                imagen.Image = Image.FromFile(datalistado.SelectedCells.Item(10).Value.ToString)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        btneditar.Visible = True


    End Sub

    Dim ruta As String

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            ruta = dlg.FileName
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage


        End If
    End Sub
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            btneliminar.Visible = True
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
            btneliminar.Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea eliminar los producto seleccionado?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idproducto").Value)
                        Dim vdb As New vproducto
                        Dim func As New fproducto
                        vdb.gidproducto = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Producto no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing

    End Sub
    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        fmcategoria.txtflag.Text = "1"
        fmcategoria.ShowDialog()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            venta.Campo2 = datalistado.SelectedCells.Item(5).Value.ToString 'descripcion
            venta.Campo3 = datalistado.SelectedCells.Item(8).Value 'precio_venta
            venta.CampoP = datalistado.SelectedCells.Item(1).Value 'iproducto
            venta.ComboBox1.Text = datalistado.SelectedCells.Item(4).Value ' nombre producto
            venta.TextBox3.Text = datalistado.SelectedCells.Item(8).Value 'precio_venta
            venta.txtcantidad.Maximum = datalistado.SelectedCells.Item(6).Value 'stock
            venta.txtcod.Text = datalistado.SelectedCells.Item(11).Value.ToString
            If datalistado.SelectedCells.Item(10).Value.ToString <> "" Then
                venta.imagen.Image = Image.FromFile(datalistado.SelectedCells.Item(10).Value.ToString)
            Else
                venta.imagen.Image = Nothing
            End If
            Me.Close()
        End If

    End Sub

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_compra.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_venta.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtfecha_vencimiento.Visible = True
        Else : CheckBox1.CheckState = CheckState.Unchecked
            txtfecha_vencimiento.Visible = False
        End If
    End Sub




    Private Sub btnguardar2_Click(sender As Object, e As EventArgs) Handles btnguardar2.Click
        
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea editar los datos del Producto?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                Dim dts As New vproducto
                Dim func As New fproducto

                dts.gidproducto = txtidproducto.Text
                dts.gnombre = txtnombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text
                dts.gcod = txtcod.Text

                If CheckBox1.CheckState = CheckState.Checked Then
                    dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                Else : CheckBox1.CheckState = CheckState.Unchecked
                    dts.gfecha_vencimiento = Nothing
                End If



                If imagen.Image Is Nothing Then
                    ruta = ""

                Else

                    If ruta <> "" Then

                        dts.gimagen = ruta

                    Else
                        ruta = datalistado.SelectedCells.Item(10).Value.ToString
                        dts.gimagen = ruta
                    End If
                End If



                If txtprecio_compra.Text < txtprecio_venta.Text Then
                    If func.editar(dts) Then
                        MessageBox.Show("Producto modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        ruta = ""
                    Else
                        MessageBox.Show("Producto no fue modificado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Else
                    MessageBox.Show("Precio Compra no puede ser un numero mayor a precio venta", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta inglesar algun datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

   
    

End Class