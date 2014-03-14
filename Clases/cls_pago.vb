Public Class cls_pago
    Private _codigo As Integer
    Private _valor As Double
    Private _tipo_pago As cls_forma_pago
    Private _factura As cls_factura
    Private _observacion As String
    Private _cheques() As cls_cheque
    Private _estado As String
    Private _fecha_creacion As DateTime

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property Forma_pago() As cls_forma_pago
        Get
            Return _tipo_pago
        End Get
        Set(ByVal value As cls_forma_pago)
            _tipo_pago = value
        End Set
    End Property

    Public Property Factura() As cls_factura
        Get
            Return _factura
        End Get
        Set(ByVal value As cls_factura)
            _factura = value
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

    Public Property Fecha_creacion() As DateTime
        Get
            Return _fecha_creacion
        End Get
        Set(ByVal value As DateTime)
            _fecha_creacion = value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property


    'METODOS Y FUNCIONES
    Public Function Reversar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Realizar_pago() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Generar_nota_credito() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Private Sub Agregar_cheque(cheques As cls_cheque())
        'VER SI SE NECESITA UNA CLASE PROPIA PARA ESTO O COMO UN METODO BASTA
    End Sub
End Class
