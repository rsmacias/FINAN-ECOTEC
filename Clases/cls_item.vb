Public Class cls_item
    Private _codigo As Integer
    Private _descripcion As String

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

    'METODOS Y FUNCIONES
    Public Function Cambiar_precio() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    'BASICAS
    Public Function Ingresar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Modificar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Eliminar() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Public Function Consultar_general() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function
    
    Public Function Consultar_especifica() As Boolean
        Dim respuesta As Boolean
        'OJO ESTA SE SOBRECARGA DE VARIAS MANERAS: POR CODIGO, POR GRUPO O SUBGRUPO
        Return respuesta
    End Function
End Class
