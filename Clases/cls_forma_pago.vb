Public Class cls_forma_pago
    Private _codigo As Integer
    Private _descripcion As String
    Private _fecha_creacion As DateTime
    Private _estado As String

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha_creacion() As DateTime
        Get
            Return _fecha_creacion
        End Get
        Set(ByVal value As DateTime)
            _fecha_creacion = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    'METODOS Y FUNCIONES

    'BASICAS
    Public Overloads Function Ingresar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Overloads Function Modificar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Overloads Function Eliminar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Overloads Function Consultar_general() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Overloads Function Consultar_especifica() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function
End Class
