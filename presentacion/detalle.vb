
Option Explicit On
Option Strict On

Imports System.Data.SqlClient


Public Class detalle
    Private Const campo_Relacionado As String = "idventa"
    Private dt As New DataTable
    Dim DataSet As New DataSet

    Dim Fechini As String
    Dim Fechfin As String

    Public Sub detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filtrar_fecha()
        DataSet.Clear()
        dt.Clear()
        
    End Sub
    Private Sub filtrar_fecha()
        Dim con As New SqlConnection

        Try
            con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
            con.Open()
          
            Fechini = Format(bus.Value.Date, "yyyyMMdd") & Format("HH:mm:ss", " 00:00:00")
            Fechfin = Format(bus2.Value.Date, "yyyyMMdd") & Format("HH:mm:ss", " 23:59:59")

           

            ' DataGridView maestro 
            Dim comando As New SqlCommand
            Dim Adaptador As New SqlDataAdapter()


            With comando
                ' Asignar el sql para seleccionar los datos de la tabla Maestro  

                .CommandText = "SELECT idventa,(SELECT dni FROM cliente where venta.idcliente=cliente.idcliente) as DNI,(SELECT nombres FROM cliente where venta.idcliente=cliente.idcliente) as Nombre, CAST( fecha AS DATE ) as fecha,tipo as Factura FROM venta where fecha BETWEEN '" & Fechini & "' AND '" & Fechfin & "'"
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
                .Connection = con
            End With


            With Adaptador
                .SelectCommand = comando
                ' llenar el dataset  
                Adaptador.Fill(DataSet, "Detalle")
            End With
            ' Enlazar el DataGridView al dataset  

            With DataGridView
                .DataMember = "Detalle"
                .DataSource = DataSet

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DefaultCellStyle.BackColor = Color.AliceBlue
            End With

            With DataSet

                If Not .Relations.Contains("mi_Relacion") Then
                    .Relations.Add("mi_Relacion", .Tables("Maestro").Columns(campo_Relacionado), .Tables("Detalle").Columns(campo_Relacionado), False)

                End If
            End With

            ' Establecer el DataSource y el DataMember para el DataGridview Detalle  
            With DataGridView
                .DataSource = DataSet
                .DataMember = "Maestro.mi_Relacion"
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

           
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Si es la fila de nuevos registros, continuamos
                If (row.IsNewRow) Then Continue For
                ' Celdas de cada fila
                For Each col As DataGridViewCell In row.Cells
                    ' Primero comprobamos si es Nothing, y si 
                    ' procede, después comprobamos si es NULL.
                    If ((col.Value Is Nothing) OrElse _
                      (col.Value Is DBNull.Value)) Then
                        ' Cambiamos el color de fondo de la celda
                        col.Style.BackColor = Color.DarkGray
                    End If
                Next ' siguiente celda
            Next ' siguiente fila
            With con
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .Dispose()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ocultar_columnas()
    End Sub

  

    Private Sub bus_ValueChanged(sender As Object, e As EventArgs) Handles bus.ValueChanged
    
        DataSet.Clear()
        dt.Clear()
        DataGridView.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        filtrar_fecha()

    End Sub

   
    Private Sub bus2_ValueChanged_1(sender As Object, e As EventArgs) Handles bus2.ValueChanged

        DataSet.Clear()
        dt.Clear()
        DataGridView.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        filtrar_fecha()
        If bus2.Value.Date < bus.Value.Date Then

            MessageBox.Show(bus, "La fecha no puede ser mayor a la fecha fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        filtrar_fecha()

    End Sub

    Private Sub ocultar_columnas()

        DataGridView1.Columns("idventa").Visible = False
        DataGridView.Columns("idventa").Visible = False
        DataGridView.Columns("iddetalleventa").Visible = False
     
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