Public Class cls_usuario
    Inherits cls_persona

    Private _codigo As String
    Private _nombre_usuario As String
    Private _clave As String
    Private _tipo_usuario As New cls_tipo_usuario()

    Public Sub New(nombres As String, apellidos As String, fecha_nacimiento As Date)
        MyBase.Apellidos = apellidos
        MyBase.Nombres = nombres
        MyBase.Fecha_Nacimiento = fecha_nacimiento
    End Sub

    Public Sub New()
        MyBase.Apellidos = String.Empty
        MyBase.Nombres = String.Empty
        MyBase.Fecha_Nacimiento = Date.Now
    End Sub

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre_Usuario() As String
        Get
            Return _nombre_usuario
        End Get
        Set(ByVal value As String)
            _nombre_usuario = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property Tipo_Usuario() As cls_tipo_usuario
        Get
            Return _tipo_usuario
        End Get
        Set(ByVal value As cls_tipo_usuario)
            _tipo_usuario = value
        End Set
    End Property


    ' METODOS Y FUNCIONES
    Public Function Inciar_sesion() As DataTable
        Dim dt As New DataTable()
        Dim con As New SqlClient.SqlConnection()
        Dim cmd As New SqlClient.SqlCommand()
        Dim da As New SqlClient.SqlDataAdapter()

        Try
            con.ConnectionString = Configuration.ConfigurationSettings.AppSettings("CadenaConexion")
            con.Open()
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "str_cons_e_usuario"
                With .Parameters
                    .AddWithValue("@nombre", Me.Nombre_Usuario)
                    .AddWithValue("@clave", Me.Clave)
                End With
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_usuario-Iniciar_sesion-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Function Cambiar_clave() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function

    Private _recursoError As String
    Public Property Recurso_Error() As String
        Get
            Return _recursoError
        End Get
        Set(ByVal value As String)
            _recursoError = value
        End Set
    End Property

    'BASICAS
    Public Overloads Function Ingresar() As Integer
        Dim con As New SqlClient.SqlConnection()
        Dim cmd As New SqlClient.SqlCommand()
        Dim respuesta As Integer = 0

        Try
            con.ConnectionString = Configuration.ConfigurationSettings.AppSettings("CadenaConexion")
            con.Open()
            With cmd
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = "str_ins_usuario"
                With .Parameters
                    .AddWithValue("@codigo", Me.Codigo)
                    .AddWithValue("@nombre", Me.Nombre_Usuario)
                    .AddWithValue("@pass", Me.Clave)
                    .AddWithValue("@tipo", Me.Tipo_Usuario.Codigo)
                    .AddWithValue("@apellido", Me.Apellidos)
                End With
                respuesta = .ExecuteNonQuery
            End With

        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_usuario-Ingresar-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

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
