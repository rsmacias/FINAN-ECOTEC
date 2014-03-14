Public Class cls_sucursal
    Private _codigo As Integer
    Private _descripcion As String
    Private _departamentos() As Item_Departamentos

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

    Public Property Departamentos() As Item_Departamentos()
        Get
            Return _departamentos
        End Get
        Set(ByVal value As Item_Departamentos())
            _departamentos = value
        End Set
    End Property


    Class Item_Departamentos
        Private _departamento As cls_departamento
        Public Property Departamento() As cls_departamento
            Get
                Return _departamento
            End Get
            Set(ByVal value As cls_departamento)
                _departamento = value
            End Set
        End Property

        Public Sub New()

        End Sub
    End Class

    Private _recursoError As String
    Public Property Recurso_Error() As String
        Get
            Return _recursoError
        End Get
        Set(ByVal value As String)
            _recursoError = value
        End Set
    End Property

    'METODOS Y FUNCIONES
    Public Function Agregar_departamentos() As Boolean
        Dim respuesta As Boolean

        Return respuesta
    End Function

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

    Public Overloads Function Consultar_general() As DataTable
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
                .CommandText = "str_cons_g_sucursal"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_sucursal-Consultar_general-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Overloads Function Consultar_especifica() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function
End Class
