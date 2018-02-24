Public Class usuario
    Private tabla As New DataSet
    Private dt As New DataTable
    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        ocultar_columnas()
        limpiar()
        btneliminar.Visible = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub
    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.value = Not chkcell.value
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
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidusuario.Text = datalistado.SelectedCells.Item(1).Value
        txtnombres.Text = datalistado.SelectedCells.Item(2).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtdni.Text = datalistado.SelectedCells.Item(4).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(5).Value
        txttelefono.Text = datalistado.SelectedCells.Item(6).Value
        txtacceso.Text = datalistado.SelectedCells.Item(7).Value
        txtlogin.Text = datalistado.SelectedCells.Item(8).Value
        txtpassword.Text = datalistado.SelectedCells.Item(9).Value


        btneditar.Visible = True
        btnguardar.Visible = False



    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidusuario.Text = ""
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtdni.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtacceso.Text = ""
        txtlogin.Text = ""
        txtpassword.Text = ""



    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False


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
    Private Sub mostrar()

        Try
            Dim func As New fusuario
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


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdni.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtacceso.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" Then

            Try
                Dim dts As New vusuario
                Dim func As New fusuario

                dts.gnombre = txtnombres.Text
                dts.gapellidos = txtapellidos.Text
                dts.gdni = txtdni.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gacceso = txtacceso.Text
                dts.glogin = txtlogin.Text
                dts.gpassword = txtpassword.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Usuario registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Usuario no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos del usuario?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtidusuario.Text <> "" And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdni.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtacceso.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" Then
                Try
                    Dim dts As New vusuario
                    Dim func As New fusuario

                    dts.gidusuario = txtidusuario.Text
                    dts.gnombre = txtnombres.Text
                    dts.gapellidos = txtapellidos.Text
                    dts.gdni = txtdni.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gacceso = txtacceso.Text
                    dts.glogin = txtlogin.Text
                    dts.gpassword = txtpassword.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Usuario modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Usuario no fue modificada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea eliminar los usuarios seleccionadas?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idusuario").Value)
                        Dim vdb As New vusuario
                        Dim func As New fusuario
                        vdb.gidusuario = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Usuario no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class