Public Class cls_factura
    Private _numero As String
    Private _alumno As Integer
    Private _periodo As String
    Private _fecha_creacion As DateTime
    Private _fecha_impresion As DateTime
    Private _pago As cls_pago
    Private _estado As String
    Private _pagado As Boolean
    Private _impreso As Boolean
    Private _punto_venta As cls_punto_venta
    Private _observacion As String

    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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

    Public Property Fecha_impresion() As DateTime
        Get
            Return _fecha_impresion
        End Get
        Set(ByVal value As DateTime)
            _fecha_impresion = value
        End Set
    End Property

    Public Property Pago() As cls_pago
        Get
            Return _pago
        End Get
        Set(ByVal value As cls_pago)
            _pago = value
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

    Public Property Pagado() As Boolean
        Get
            Return _pagado
        End Get
        Set(ByVal value As Boolean)
            _pagado = value
        End Set
    End Property

    Public Property Impreso() As Boolean
        Get
            Return _impreso
        End Get
        Set(ByVal value As Boolean)
            _impreso = value
        End Set
    End Property

    Public Property Alumno_codigo() As Integer
        Get
            Return _alumno
        End Get
        Set(ByVal value As Integer)
            _alumno = value
        End Set
    End Property

    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
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

    Public Property Punto_venta() As cls_punto_venta
        Get
            Return _punto_venta
        End Get
        Set(ByVal value As cls_punto_venta)
            _punto_venta = value
        End Set
    End Property

    'METODOS Y FUNCIONES
    Public Function Imprimir() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Ingresar() As Boolean
        Dim respuesta As Boolean

        Me.Pago.Realizar_pago() 'OJO PODRIA HACERSE DESDE AQUI

        Return respuesta
    End Function
End Class
