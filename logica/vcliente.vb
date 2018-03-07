Public Class vcliente
    Dim idcliente As Integer
    Dim nombres, apellidos, direccion, telefono, dni, tipos As String

    'seeter y getter
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property
    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(value)
            nombres = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property
    Public Property gtipos
        Get
            Return tipos
        End Get
        Set(value)
            tipos = value
        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByRef idcliente As Integer, ByRef nombres As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal dni As String)
        gidcliente = idcliente
        gnombres = nombres
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gdni = dni
        gtipos = tipos
    End Sub
End Class
