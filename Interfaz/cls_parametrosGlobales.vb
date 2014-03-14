Imports Prueba

Public Class cls_parametrosGlobales
    Public Shared _usuario As String = String.Empty
    Public Shared _clave As String = String.Empty
    Public Shared _tipoUsuario As String = String.Empty

#Region "Procedimientos de Seguridad"
    ''' <summary>
    ''' Obtiene los permisos de las funciones del formulario deacuerdo al rol o tipo de usuario.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub Carga_permisos(ByVal formulario As Form)
        Dim dt As New DataTable()
        Dim obj_tipoUsuario As New cls_tipo_usuario()

        Try
            obj_tipoUsuario.Codigo = cls_parametrosGlobales._tipoUsuario
            dt = obj_tipoUsuario.Consultar_permisos_modulo(formulario.Name)
            If dt.Rows.Count <= 0 Then
                If Not obj_tipoUsuario.Recurso_Error = String.Empty Then
                    MessageBox.Show(obj_tipoUsuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("No existe aún permisos concedidos al rol de este usuario", "Sistema", MessageBoxButtons.OK)
                    Inicializar_controles(formulario) 'DENEGAR TODO CONTROL
                End If
            Else
                Habilitar_controles(formulario, dt) 'CONCEDER LOS PERMISOS ALMACENADOS
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub
    ''' <summary>
    ''' Deshabilita todos los botones del formulario.
    ''' </summary>
    ''' <param name="elemento_control">Objeto contenedor de tipo Control.</param>
    ''' <remarks></remarks>
    Public Shared Sub Inicializar_controles(ByVal elemento_control As Control)
        For Each elemento As Control In elemento_control.Controls
            If Not TypeOf elemento Is Button Then
                If TypeOf elemento Is GroupBox Then
                    Inicializar_controles(elemento)
                End If
            Else ' Encontró un botón
                CType(elemento, Button).Enabled = False
            End If
        Next
    End Sub
    ''' <summary>
    ''' Habilita los botones del formulario.
    ''' </summary>
    ''' <param name="elemento_control">Objeto contenedor de tipo Control.</param>
    ''' <param name="dt_permisos">Objeto DataTable con los permisos del tipo de usuario.</param>
    ''' <remarks></remarks>
    Private Shared Sub Habilitar_controles(ByVal elemento_control As Control, ByVal dt_permisos As DataTable)
        For Each fila As DataRow In dt_permisos.Rows
            For Each elemento As Control In elemento_control.Controls
                If Not TypeOf elemento Is Button Then
                    If TypeOf elemento Is GroupBox Then
                        Habilitar_controles(elemento, dt_permisos)
                    End If
                Else ' Encontró un botón
                    If fila.Item("nom_control").ToString() = CType(elemento, Button).Name Then
                        CType(elemento, Button).Enabled = True
                    End If
                End If
            Next
        Next
    End Sub
#End Region
End Class
