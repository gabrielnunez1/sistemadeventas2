Imports System.Data.SqlClient
Public Class venta

    Private dt As New DataTable
    Public CampoP As Integer
    Public Campo3 As Decimal = 0
    Public Campo2 As String = String.Empty
    Public tipos As String

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        fmcliente.Size = New System.Drawing.Size(595, 515)
        fmcliente.GroupBox2.Location = New Point(6, 71)
        fmcliente.txtflag.Text = "1"
        fmcliente.ShowDialog()
        Me.txtcod.Focus()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre_producto As String = ComboBox1.Text()
        Dim precio As Decimal = Campo3
        Dim total As Decimal = 0
        Dim cantidad As Integer
        Dim vf As Boolean = True
        cantidad = txtcantidad.Value
        total = precio * cantidad
        btncobrar.Enabled = True

        For Each filaa As DataGridViewRow In datalistado.Rows
            If filaa.Cells(1).Value = nombre_producto Then

                filaa.Cells(3).Value += cantidad
                filaa.Cells(5).Value = filaa.Cells(3).Value * precio
                vf = False
                Exit For
            End If
        Next
        If vf Then
            datalistado.Rows.Add(False, nombre_producto, Campo2, cantidad, precio, total, CampoP)
        End If
        txtcantidad.Maximum -= txtcantidad.Text
        Dim rotal As Double = 0 'suma de subtotal
        Dim fila As DataGridViewRow = New DataGridViewRow() '
        For Each fila In datalistado.Rows '
            rotal += Convert.ToDouble(fila.Cells("total").Value) '
        Next
        Label13.Text = Convert.ToString(rotal) '
        Me.txtcod.Focus()
        limpiar()

    End Sub

    Private Sub btncobrar_Click(sender As Object, e As EventArgs) Handles btncobrar.Click
        If Not consumidorfinal.CheckState = CheckState.Checked Then
            If String.IsNullOrEmpty(txtnombre_cliente.Text) Or _
        String.IsNullOrEmpty(TextBox1.Text) Then
                MessageBox.Show("Error al realizar el cobro debe ingresar cliente.", "Error al cobrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        End If
        fmcomprobanteconcliente.txtidventa.Text = Me.txtidventa.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT (*) FROM venta"
            Dim a As Integer = Convert.ToInt16(cmd.ExecuteScalar) + 1
            If consumidorfinal.CheckState = CheckState.Checked Then
                Dim b As String = "Consumidor final"
                cmd.CommandText = "INSERT INTO venta (idventa,fecha,tipo) VALUES ('" & a & "','" & DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "") + " " + DateTime.Now.ToString("HH:mm:ss") & "','" & b & "');"

            Else
                cmd.CommandText = "INSERT INTO venta (idventa,idcliente,fecha,tipo) VALUES ('" & a & "','" & Integer.Parse(txtidcliente.Text) & "','" & DateTime.Now.ToString("yyyy/MM/dd").Replace("/", "") + " " + DateTime.Now.ToString("HH:mm:ss") & "','" & tipos & "');"
                fmcomprobanteconcliente.txtidventa.Text = a
            End If
            cmd.ExecuteNonQuery()
            cargarDetalleVenta(a, cmd)
            If consumidorfinal.CheckState = CheckState.Checked Then
                fmreportecomprobante.ShowDialog()
            Else
                fmcomprobanteconcliente.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cobrar " & ex.Message, "Error al realizar el cobro")
        Finally
            con.Close()
        End Try
        limpia()

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub definirstock(func As fdetalle, dts As vdetalle)
        If func.disminuir_stock(dts) Then
            MessageBox.Show("Se registro la venta", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Artículo no fue añadido correctamente a la venta intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cargarDetalleVenta(idVenta As Integer, cmd As SqlCommand)
        Dim cantidad As Integer
        Dim precio As String
        Dim idproducto As String
        Dim total As String
        Dim dts As New vdetalle
        Dim func As New fdetalle
        For Each row As DataGridViewRow In Me.datalistado.Rows
            cantidad = row.Cells("Cantidad").Value
            precio = row.Cells("Precio").Value
            idproducto = row.Cells("idproducto").Value
            total = row.Cells("Total").Value
            cmd.CommandText = "SELECT COUNT (*) FROM detalle"
            Dim iddetalleventa As Integer = Convert.ToInt16(cmd.ExecuteScalar) + 1
            cmd.CommandText = "INSERT INTO detalle (iddetalleventa,idventa,idproducto,cantidad,precio_unitario,total) VALUES ('" & iddetalleventa & "','" & idVenta & "','" & idproducto & "','" & cantidad & "','" & precio.Replace(",", ".") & "','" & total.Replace(",", ".") & "');"
            fmreportecomprobante.txtidventa.Text = idVenta + 1
            cmd.ExecuteNonQuery()
            dts.gcantidad = cantidad
            dts.gidproducto = idproducto
        Next
        definirstock(func, dts)

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
        result = MessageBox.Show("¿Realmente desea eliminar los clientes seleccionado?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim f As Boolean = True
            While f
                f = False
                For Each vfila As DataGridViewRow In datalistado.Rows
                    If vfila.Cells("Eliminar").Value Then
                        f = True
                        datalistado.Rows.Remove(vfila)
                        Label13.Text -= vfila.Cells(5).Value
                        Exit For
                    End If
                Next
            End While
            If datalistado.Rows.Count > 0 Then
                btncobrar.Enabled = True
            Else
                btncobrar.Enabled = False
            End If
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btncobrar.Enabled = False
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        If consumidorfinal.CheckState = CheckState.Unchecked Then
            foco()

        End If

        btneliminar.Visible = False
        TextBox3.Enabled = False
        btncobrar.Enabled = False
        datalistado.Columns.Item("Eliminar").Visible = False
        Label13.Text = 0
        txtidcliente.Visible = False
        ComboBox1.Enabled = False
        datalistado.Columns("Nombre").Width = 190
    End Sub

    Public Sub foco()
        If String.IsNullOrEmpty(txtidcliente.Text) Or _
           String.IsNullOrEmpty(txtnombre_cliente.Text) Then
            btnbuscar.Enabled = False
            TextBox3.Enabled = False
            btnbuscar.Enabled = False
            Button2.Visible = False
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
            TextBox3.Enabled = False
            btnbuscar.Enabled = True
        End If

    End Sub
    Public Sub limpia()
        datalistado.Rows.Clear()
        consumidorfinal.Checked = True
        txtnombre_cliente.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
        txtcantidad.Text = "0"
        TextBox3.Text = ""
        imagen.Image = Nothing
        txtcod.Text = ""
    End Sub

    Public Sub limpiar()
        ComboBox1.Text = ""
        txtcantidad.Text = "0"
        TextBox3.Text = ""
        imagen.Image = Nothing
        txtcod.Text = ""

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        fmproducto.Show()
        fmproducto.Location = New Point(30, 60)
        fmproducto.Size = New System.Drawing.Size(882, 600)
        fmproducto.GroupBox2.Location = New Point(7, 79)
        fmproducto.txtflag.Text = "1"

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtcantidad.Value > 0 And Button2.Visible = True Then
                Me.Button2.Focus()
            End If
        End If

    End Sub
    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        If txtcantidad.Value > 0 And ComboBox1.Text <> "" And fmproducto.txtflag.Text <> "1" Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If

    End Sub

    Private Sub consumidorfinal_CheckedChanged(sender As Object, e As EventArgs) Handles consumidorfinal.CheckedChanged
        If consumidorfinal.CheckState = CheckState.Checked Then
            GroupBox1.Visible = False
            txtidcliente.Text = ""
            txtnombre_cliente.Text = ""
            TextBox1.Text = ""
            tipos = ""
        Else : consumidorfinal.CheckState = CheckState.Unchecked
            GroupBox1.Visible = True
            TextBox3.Enabled = False
            btnbuscar.Enabled = True
            txtidcliente.Text = ""
            txtnombre_cliente.Text = ""
            TextBox1.Text = ""
            tipos = ""
        End If
    End Sub

    Private Sub txtcod_LostFocus(sender As Object, e As EventArgs) Handles txtcod.LostFocus

        If Not txtcod.Text = "" Then

            Dim clave As String = txtcod.Text
            Dim func As New fproducto
            dt = func.mostrar
            For Each rows As DataRow In dt.Rows
                Dim id As String = rows("cod").ToString
                If id.Trim = clave.Trim Then
                    CampoP = rows("idproducto").ToString
                    ComboBox1.Text = rows("nombre").ToString
                    TextBox3.Text = rows("precio_venta").ToString
                    Campo3 = TextBox3.Text
                    Campo2 = rows("descripcion").ToString

                    If rows("imagen").ToString <> "" Then
                        imagen.Image = Image.FromFile(rows("imagen"))
                    Else
                        imagen.Image = Nothing
                    End If
                    Exit For

                End If
            Next
            Me.txtcantidad.Focus()
            txtcantidad.Select(0, txtcantidad.Text.Length)
        End If
    End Sub

    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod.KeyPress
        If Not txtcod.Text = "" Then
            If Asc(e.KeyChar) = 13 Then
                Dim clave As String = txtcod.Text
                Dim func As New fproducto
                dt = func.mostrar
                For Each rows As DataRow In dt.Rows

                    Dim id As String = rows("cod").ToString
                    If id.Trim = clave.Trim Then
                        CampoP = rows("idproducto").ToString
                        ComboBox1.Text = rows("nombre").ToString
                        TextBox3.Text = rows("precio_venta").ToString
                        Campo3 = TextBox3.Text
                        Campo2 = rows("descripcion").ToString

                        If rows("imagen").ToString <> "" Then
                            imagen.Image = Image.FromFile(rows("imagen"))
                        Else
                            imagen.Image = Nothing
                        End If
                        Exit For
                    End If
                Next
                pasar()
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                Me.btncobrar.Focus()
            End If

        End If
    End Sub

    Public Sub pasar()
        If TextBox3.Text <> "" Then
            Me.txtcantidad.Focus()
            txtcantidad.Select(0, txtcantidad.Text.Length)

        End If
    End Sub



End Class