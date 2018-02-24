﻿Imports System.Data.SqlClient


Public Class conexion
    Public idusuario As Integer
    Protected cnn As New SqlConnection
    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=GABRIEL;Initial Catalog=dbventas1;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class

