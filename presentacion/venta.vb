Imports System.Data.SqlClient
Public Class venta
    Private dt As New DataTable
    Public CampoP As Integer
    Public campo5 As Integer
    Public Campo3 As Decimal = 0
    Public Campo2 As String = String.Empty
    Public stock As Integer
    Private tabla As DataSet


    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        fmcliente.Size = New System.Drawing.Size(595, 515)
        fmcliente.GroupBox2.Location = New Point(6, 71)

        fmcliente.txtflag.Text = "1"
        fmcliente.ShowDialog()
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
        total = Campo3 * cantidad
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
        txtcantidad.Enabled = False
        limpiar()
    End Sub
    Private Sub btncobrar_Click(sender As Object, e As EventArgs) Handles btncobrar.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT (*) FROM venta"
            Dim a As Integer = Convert.ToInt16(cmd.ExecuteScalar) + 1
            If consumidorfinal.CheckState = CheckState.Checked Then
                Dim b As String = "consumidorfinal"
                cmd.CommandText = "INSERT INTO venta (idventa,fecha,tipo) VALUES ('" & a & "','" & DateTime.Now.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToLongTimeString & "','" & b & "');"
                fmreportecomprobante.Camp = b.ToString
            Else
                Dim b As String = "Con"
                cmd.CommandText = "INSERT INTO venta (idventa,idcliente,fecha,tipo) VALUES ('" & a & "','" & Integer.Parse(txtidcliente.Text) & "','" & DateTime.Now.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToLongTimeString & "','" & b & "');"

            End If
            fmreportecomprobante.txtidventa.Text = Me.txtidventa.Text '''''''

            cmd.ExecuteNonQuery()
            cargarDetalleVenta(a, cmd)
        Catch ex As Exception
            MessageBox.Show("Error al cobrar " & ex.Message, "Error al realizar el cobro")
        Finally
            con.Close()
        End Try



        If consumidorfinal.CheckState = CheckState.Checked Then

            fmreportecomprobante.ShowDialog()
        Else

            fmreportecomprobante.ShowDialog()
        End If
        Me.Close()

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
        Dim idproducto As Integer
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
            cmd.ExecuteNonQuery()
            dts.gcantidad = cantidad
            dts.gidproducto = idproducto

        Next
        definirstock(func, dts)
        'fmreportecomprobante.txtidventa.Text = idVenta + 1

    
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
        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub
    Public Sub limpiar()
        ComboBox1.Text = ""
        txtcantidad.Text = "0"
        TextBox3.Text = ""
        imagen.Image = Nothing
    End Sub

    Public Sub foco2()
        If String.IsNullOrEmpty(ComboBox1.Text) And fmproducto.txtflag.Text <> "1" Then
            txtcantidad.Enabled = False

        Else
            txtcantidad.Enabled = True

        End If
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        fmproducto.Show()
        fmproducto.Location = New Point(30, 60)
        fmproducto.Size = New System.Drawing.Size(882, 600)
        fmproducto.GroupBox2.Location = New Point(7, 79)
        fmproducto.txtflag.Text = "1"

        foco2()
    End Sub
    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double
        cant = txtcantidad.Value
        If txtcantidad.Value > 0 And ComboBox1.Text <> "" And fmproducto.txtflag.Text <> "1" Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If

    End Sub

    Private Sub consumidorfinal_CheckedChanged(sender As Object, e As EventArgs) Handles consumidorfinal.CheckedChanged
        If consumidorfinal.CheckState = CheckState.Checked Then
            GroupBox1.Visible = False
            limpiar()
        Else : consumidorfinal.CheckState = CheckState.Unchecked
            GroupBox1.Visible = True
            TextBox3.Enabled = False
            btnbuscar.Enabled = True
            limpiar()
        End If
    End Sub
End Class