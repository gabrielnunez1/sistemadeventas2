Public Class vdetalle
    Dim iddetalleventa, idventa, idproducto, cantidad As Integer
    Dim precio_unitario, total As Decimal

    Public Property giddetalleventa
        Get
            Return iddetalleventa
        End Get
        Set(value)
            iddetalleventa = value
        End Set
    End Property
    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(value)
            idventa = value
        End Set
    End Property
    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(value)
            idproducto = value
        End Set
    End Property
    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property gprecio_unitario
        Get
            Return precio_unitario
        End Get
        Set(value)
            precio_unitario = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal iddetalleventa As Integer, ByVal idventa As Integer, ByVal idproducto As Integer, ByVal cantidad As Integer, ByVal total As String, ByVal precio_unitario As String)
        giddetalleventa = iddetalleventa
        gidventa = idventa
        gidproducto = idproducto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario
        gtotal = total
    End Sub
End Class


