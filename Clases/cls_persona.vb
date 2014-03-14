Public Class cls_persona
    Private _nombre As String
    Private _apellido As String
    Private _fecha_nacimiento As Date

    Public Property Nombres() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property Fecha_Nacimiento() As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(ByVal value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    'METODOS Y FUNCIONES
    Public Function Calcular_edad() As Integer
        Dim respuesta As Integer
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
        Return respuesta
    End Function
End Class
