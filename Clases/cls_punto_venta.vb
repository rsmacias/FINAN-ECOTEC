Public Class cls_punto_venta
    Private _codigo As Integer
    Private _descripcion As String
    Private _IP As String
    Private _mac As String
    Private _fecha_creacion As DateTime

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

    Public Property MAC() As String
        Get
            Return _mac
        End Get
        Set(ByVal value As String)
            _mac = value
        End Set
    End Property

    Public Property IP() As String
        Get
            Return _IP
        End Get
        Set(ByVal value As String)
            _IP = value
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

End Class
