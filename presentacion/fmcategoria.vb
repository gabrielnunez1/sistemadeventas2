Public Class fmcategoria
    Private dt As New DataTable
    Private Sub fmcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()
        datalistado.Columns(2).Width = 200
        ocultar_columnas()
    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidcategoria.Text = ""

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fcategoria
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

    End Sub



    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de la categoria porfavor, este dato es obligatorio")
        End If

    End Sub



    

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vcategoria
                Dim func As New fcategoria

                dts.gnombre_categoria = txtnombre.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Categoria registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoria no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre.Text = datalistado.SelectedCells.Item(1).Value
        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub



    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos de la categoria?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtidcategoria.Text <> "" Then
                Try
                    Dim dts As New vcategoria
                    Dim func As New fcategoria

                    dts.gidcategoria = txtidcategoria.Text
                    dts.gnombre_categoria = txtnombre.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Categoria modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Categoria no fue modificada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            fmproducto.txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
            fmproducto.txtnom_categoria.Text = datalistado.SelectedCells.Item(1).Value
            Me.Close()

        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()

    End Sub
    

    Private Sub btnnuevo_Click_1(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

  
    
End Class