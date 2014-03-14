Imports System.Configuration

Public Class cls_tipo_usuario
    Private _codigo As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _usuario As cls_usuario

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Public Property Usuario() As cls_usuario
        Get
            Return _usuario
        End Get
        Set(ByVal value As cls_usuario)
            _usuario = value
        End Set
    End Property


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

    Public Function Consultar_general() As DataTable
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
                .CommandText = "str_cons_g_tipoUsuario"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_general-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Function Consultar_permisos_menu() As DataTable
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
                .CommandText = "str_cons_e_permisosMenu"
                With .Parameters
                    .AddWithValue("@tipo_usuario", Me.Codigo)
                End With
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_permisos_menu-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Function Consultar_permisos_modulo(ByVal nombre_modulo As String) As DataTable
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
                .CommandText = "str_cons_e_permisosModulo"
                With .Parameters
                    .AddWithValue("@modulo_nombre", nombre_modulo)
                    .AddWithValue("@tipo_usuario", Me.Codigo)
                End With
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_permisos_modulo-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Function Consultar_niveles_menu() As DataTable
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
                .CommandText = "str_cons_nivelesMenu"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_permisos_menu-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return dt
    End Function

    Public Function Consultar_menu() As DataSet
        Dim ds As New DataSet()
        Dim dt_niveles As New DataTable()
        Dim con As New SqlClient.SqlConnection()
        Dim cmd As New SqlClient.SqlCommand()
        Dim da As New SqlClient.SqlDataAdapter()

        Try
            con.ConnectionString = Configuration.ConfigurationSettings.AppSettings("CadenaConexion")
            con.Open()

            dt_niveles = Me.Consultar_niveles_menu()
            If Not dt_niveles.Rows.Count <= 0 Then
                For i As Integer = 0 To dt_niveles.Rows.Count - 1
                    'FUNCION QUE CONSULTE Y ME DE UN DATATABLE
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "str_cons_menuXnivel"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@nivel", dt_niveles.Rows(i).Item("niveles"))
                    End With
                    da.SelectCommand = cmd
                    da.Fill(ds, "dt_nivel_" & i)
                    'AGREGAR LAS RELACIONES ENTRE LOS DATATABLES
                    If Not i = 0 Then
                        ds.Relations.Add("relacion_" & i, ds.Tables(i - 1).Columns("MENU_CODIGO"), ds.Tables(i).Columns("MENU_PADRE"))
                    End If
                Next
            Else
                Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_Menu-Error en consultar niveles"
            End If
        Catch ex As Exception
            Me.Recurso_Error = "Clases-cls_tipo_usuario-Consultar_permisos_menu-" & ex.Message
        Finally
            con.Close()
            cmd.Dispose()
        End Try

        Return ds
    End Function

    Public Function Consultar_especifica() As Boolean
        Dim respuesta As Boolean
        Return respuesta
    End Function
End Class
