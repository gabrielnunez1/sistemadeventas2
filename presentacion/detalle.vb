
Option Explicit On
Option Strict On

Imports System.Data.SqlClient


Public Class detalle
    Private Const campo_Relacionado As String = "idventa"
    Private dt As New DataTable
    Dim DataSet As New DataSet
    Dim CampoP As String
    Dim Fechini As String
    Dim Fechfin As String

      

    Public Sub detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fechini = Format(bus.Value, "yyyyMMdd") & " 00:00:00"
        Fechfin = Format(bus2.Value, "yyyyMMdd") & " 23:59:59"
        filtrar_fecha()
        DataSet.Clear()
        dt.Clear()
        DataGridView.DataSource = Nothing
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub filtrar_fecha()
        Dim con As New SqlConnection

        Try
            con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
            con.Open()


            ' DataGridView maestro 
            Dim comando As New SqlCommand
            Dim Adaptador As New SqlDataAdapter()

            With comando
                ' Asignar el sql para seleccionar los datos de la tabla Maestro  

                


                .CommandText = "SELECT idventa,(SELECT dni FROM cliente where venta.idcliente=cliente.idcliente) as DNI,(SELECT nombres FROM cliente where venta.idcliente=cliente.idcliente) as Nombre,Fecha,tipo as Factura FROM venta where fecha BETWEEN '" & Fechini & "' AND '" & Fechfin & "'"
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
            If DataGridView1.Rows.Count > 0 Then
                'esta lleno

                With Adaptador
                    .SelectCommand = comando
                    ' llenar el dataset  
                    Adaptador.Fill(DataSet, "Detalle")
                End With

                With DataSet

                    If Not .Relations.Contains("mi_Relacion") Then
                        .Relations.Add("mi_Relacion", .Tables("Maestro").Columns(campo_Relacionado), .Tables("Detalle").Columns(campo_Relacionado))

                    End If
                End With

                ' Establecer el DataSource y el DataMember para el DataGridview Detalle  
                With DataGridView
                    .DataSource = DataSet
                    .DataMember = "Maestro.mi_Relacion"
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

            Else
                DataGridView1.ColumnHeadersVisible = False
                'datagridview1 esta vacio

            End If

            With con
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .Dispose()
            End With
        Catch ex As Exception

        End Try
        'ocultar_columnas()
    End Sub

  

    Private Sub bus_ValueChanged(sender As Object, e As EventArgs) Handles bus.ValueChanged
    
        DataSet.Clear()
        dt.Clear()
        DataGridView.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        filtrar_fecha()

    End Sub

    Private Sub bus2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles bus2.Validating
       

    End Sub




    Private Sub bus2_ValueChanged_1(sender As Object, e As EventArgs) Handles bus2.ValueChanged
        If bus2.Value < bus.Value Then

            MessageBox.Show(bus, "La fecha no puede ser mayor a la fecha fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
         

        End If
        DataSet.Clear()
        dt.Clear()
        DataGridView.DataSource = Nothing
        DataGridView1.DataSource = Nothing

        filtrar_fecha()



        'If DataGridView1.Rows.Count > 0 Then
        '    filtrar_fecha()
        '    'esta lleno

        'Else

        '    'esta vacio

        'End If


    End Sub

    'Private Function traerdatasetfecha(fecha1 As String, fecha2 As String) As DataSet
    '    Dim ds As DataSet = New DataSet
    '    Dim con As New SqlConnection

    '    Try
    '        con.ConnectionString = "Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True"
    '        con.Open()
    '        Dim comando As New SqlCommand
    '        Dim Adaptador As New SqlDataAdapter()
    '        With comando
    '            ' Asignar el sql para seleccionar los datos de la tabla Maestro  



    '            .CommandText = "SELECT * FROM venta WHERE fecha  BETWEEN '" & fecha1 & "' AND '" & fecha2 & "';"
    '            .Connection = con


    '        End With
    '        With Adaptador
    '            .SelectCommand = comando
    '            ' llenar el dataset  
    '            Adaptador.Fill(ds, "Maestro")
    '        End With

    '        With con
    '            If .State = ConnectionState.Open Then
    '                .Close()
    '            End If
    '            .Dispose()
    '        End With
    '    Catch e As Exception
    '        With con
    '            If .State = ConnectionState.Open Then
    '                .Close()
    '            End If
    '            .Dispose()
    '        End With
    '        MsgBox("error")
    '    End Try

    '    Return ds
    'End Function



    Private Function traerfecha(bus3 As DateTimePicker) As String
        Dim fecha As String = ""
        Dim ano As String = bus3.Value.Year.ToString
        Dim mes As String = bus3.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" & mes
        End If
        Dim dia As String = bus3.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" & dia
        End If
        Dim hora As String = "00:00:00"

        fecha = ano & mes & dia & " " & hora


        Label11.Text = fecha
        Return fecha
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filtrar_fecha()
        Label1.Text = traerfecha(bus).ToString
        Label2.Text = traerfecha(bus2).ToString
    End Sub

    Private Sub ocultar_columnas()

        'If DataGridView1.Rows.Count > 0 Then
        '    DataGridView1.Columns("idventa").Visible = False
        '    DataGridView.Columns("idventa").Visible = False
        '    DataGridView.Columns("iddetalleventa").Visible = False
        '    'esta lleno



        'End If

     
        
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