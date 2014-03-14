Imports Prueba

Public Class frm_Inicio_Sesion

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Consulta_usuario()
    End Sub

    Private Sub Consulta_usuario()
        Dim obj_usuario As New cls_usuario()
        Dim dt As New DataTable()
        obj_usuario.Nombre_Usuario = txt_usuario.Text
        obj_usuario.Clave = txt_clave.Text

        Try
            dt = obj_usuario.Inciar_sesion()
            If Not dt.Rows.Count <= 0 Then
                ' == GUARDO EL USUARIO Y CLAVE PARA CONTROL FUTURO
                cls_parametrosGlobales._usuario = txt_usuario.Text
                cls_parametrosGlobales._clave = txt_clave.Text
                cls_parametrosGlobales._tipoUsuario = dt.Rows(0)("cod_tipo_usuario").ToString()
                ' == GUARDO EL USUARIO Y CLAVE PARA CONTROL FUTURO

                MessageBox.Show("Acceso Exitoso", "Sistema", MessageBoxButtons.OK)

                With frm_principal
                    ' == CODIGO DE CONSULTA DE PERMISOS DE MENU
                    Dim dt_permisos As New DataTable()
                    obj_usuario.Tipo_Usuario.Codigo = dt.Rows(0)("cod_tipo_usuario").ToString()
                    dt_permisos = obj_usuario.Tipo_Usuario.Consultar_permisos_menu()
                    If dt_permisos.Rows.Count <= 0 Then
                        If Not obj_usuario.Tipo_Usuario.Recurso_Error = String.Empty Then
                            MessageBox.Show(obj_usuario.Tipo_Usuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                        Else
                            MessageBox.Show("No existen permisos concedidos al rol de este usuario", "Sistema", MessageBoxButtons.OK)
                        End If
                    Else
                        .habilitar_menu(dt_permisos)
                    End If
                    ' == CODIGO DE CONSULTA DE PERMISOS DE MENU

                    With .StatusStrip_prinicipal
                        .Items("tssl_apellido").Text = "Sr(a): " & dt.Rows(0)("apellido").ToString()
                        .Items("tssl_usuario").Text = "Usuario: " & txt_usuario.Text
                        .Items("tssl_tipoUsuario").Text = "Rol: " & dt.Rows(0)("des_tipo_usuario").ToString()
                    End With
                End With

                Me.Close()
            Else
                If Not obj_usuario.Recurso_Error = String.Empty Then
                    MessageBox.Show(obj_usuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Acceso Denegado", "Sistema", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub
End Class