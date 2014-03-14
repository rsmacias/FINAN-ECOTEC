Public Class cls_cheque
    Private _codigo As Integer
    Private _numero As String
    Private _banco As cls_banco
    Private _titulas As String
    Private _fecha_creacion As DateTime
    Private _numero_cta As String
    Private _fecha_emision As DateTime
    Private _protestado As Boolean
    Private _postfechado As Boolean
    Private _fecha_protesta As DateTime

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property Banco() As cls_banco
        Get
            Return _banco
        End Get
        Set(ByVal value As cls_banco)
            _banco = value
        End Set
    End Property

    Public Property Titular() As String
        Get
            Return _titulas
        End Get
        Set(ByVal value As String)
            _titulas = value
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

    Public Property Cta_cte() As String
        Get
            Return _numero_cta
        End Get
        Set(ByVal value As String)
            _numero_cta = value
        End Set
    End Property

    Public Property Fecha_emision() As DateTime
        Get
            Return _fecha_emision
        End Get
        Set(ByVal value As DateTime)
            _fecha_emision = value
        End Set
    End Property

    Public Property Protestado() As Boolean
        Get
            Return _protestado
        End Get
        Set(ByVal value As Boolean)
            _protestado = value
        End Set
    End Property

    Public Property Postfechado() As Boolean
        Get
            Return _postfechado
        End Get
        Set(ByVal value As Boolean)
            _postfechado = value
        End Set
    End Property

    Public Property Fecha_protesta() As DateTime
        Get
            Return _fecha_protesta
        End Get
        Set(ByVal value As DateTime)
            _fecha_protesta = value
        End Set
    End Property

End Class
