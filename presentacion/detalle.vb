
Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class detalle
    Private Const campo_Relacionado As String = "idventa"
    Private dt As New DataTable
    Private Sub detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection

        Try
            con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
            con.Open()

            Dim DataSet As New DataSet
            ' DataGridView maestro  
            Dim Adaptador As New SqlDataAdapter()
            Dim comando As New SqlCommand
            With comando
                ' Asignar el sql para seleccionar los datos de la tabla Maestro  
                .CommandText = "SELECT idventa,(SELECT dni FROM cliente where venta.idcliente=cliente.idcliente) as DNI,(SELECT nombres FROM cliente where venta.idcliente=cliente.idcliente) as Nombre,Fecha FROM venta"
                .Connection = con
            End With
            With Adaptador
                .SelectCommand = comando
                ' llenar el dataset  
                Adaptador.Fill(DataSet, "Maestro")
            End With

            ' Enlazar el DataGridView al dataset  
            With DataGridView1
                .DataMember = "Maestro"
                .DataSource = DataSet

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DefaultCellStyle.BackColor = Color.AliceBlue


            End With
            '            ' DataGridView detalle  
            With comando
                ' cadena sql para cargar la tabla pedidos  
                .CommandText = "SELECT iddetalleventa,idventa,(SELECT nombre FROM producto where detalle.idproducto=producto.idproducto) AS Nombre_Producto,Cantidad,Precio_unitario as Precio_Unitario,Total FROM detalle"

            End With

            With Adaptador
                .SelectCommand = comando
                ' llenar el dataset  
                Adaptador.Fill(DataSet, "Detalle")
            End With

            ' Agregar la relación ( campo en común : campo_Relacionado = idventa )  

            With DataSet
                .Relations.Add("mi_Relacion", .Tables("Maestro").Columns(campo_Relacionado), .Tables("Detalle").Columns(campo_Relacionado))
            End With


            ' Establecer el DataSource y el DataMember para el DataGridview Detalle  
            With DataGridView
                .DataSource = DataSet
                .DataMember = "Maestro.mi_Relacion"
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            With con
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .Dispose()
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        ocultar_columnas()
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub ocultar_columnas()
        DataGridView1.Columns(0).Visible = False
        DataGridView.Columns(1).Visible = False
        DataGridView.Columns(0).Visible = False


    End Sub

    Private Sub btnnuevaventa_Click_1(sender As Object, e As EventArgs) Handles btnnuevaventa.Click
        venta.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim rotal As Double = 0 'suma de subtotal
        Dim fila As DataGridViewRow = New DataGridViewRow() '
        For Each fila In DataGridView.Rows '
            rotal += Convert.ToDouble(fila.Cells("Total").Value) '
        Next '
        Label13.Text = Convert.ToString(rotal) '
    End Sub

    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class