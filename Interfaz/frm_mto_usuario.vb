Imports Prueba

Public Class frm_mto_usuario

    Private Sub frm_mto_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_parametrosGlobales.Inicializar_controles(Me)
        cls_parametrosGlobales.Carga_permisos(Me)

        cbx_sucursal.Enabled = False
        carga_tiposUsuario()
        carga_sucursal()
    End Sub

    Private Sub chk_sucursal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sucursal.CheckedChanged
        If chk_sucursal.Checked Then
            cbx_sucursal.Enabled = True
        Else
            cbx_sucursal.Enabled = False
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        'If chk_sucursal.Checked Then
        Guardar()
        'Else

        'End If

    End Sub

    Private Sub carga_tiposUsuario()
        Dim obj_tipoUsuario As New cls_tipo_usuario()
        Dim dt As New DataTable()
        Try
            dt = obj_tipoUsuario.Consultar_general()
            If Not dt.Rows.Count <= 0 Then
                With cbx_tipoUsuario
                    .DataSource = dt
                    .DisplayMember = "nombre"
                    .ValueMember = "codigo"
                End With
            Else
                If Not obj_tipoUsuario.Recurso_Error = String.Empty Then
                    MessageBox.Show(obj_tipoUsuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("No existen datos de tipos de usuarios a mostrar", "Sistema", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub carga_sucursal()
        Dim obj_sucursal As New cls_sucursal()
        Dim dt As New DataTable()
        Try
            dt = obj_sucursal.Consultar_general()
            If Not dt.Rows.Count <= 0 Then
                With cbx_sucursal
                    .DataSource = dt
                    .DisplayMember = "nombre"
                    .ValueMember = "codigo"
                End With
            Else
                If Not obj_sucursal.Recurso_Error = String.Empty Then
                    MessageBox.Show(obj_sucursal.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("No existen datos de sucursales a mostrar", "Sistema", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Guardar()
        Dim respuesta As Integer = 0
        Dim obj_Usuario As New cls_usuario()

        Try
            With obj_Usuario
                .Codigo = txt_codigo.Text
                .Nombre_Usuario = txt_nombreUsuario.Text
                .Apellidos = txt_apellidosPersona.Text
                .Tipo_Usuario.Codigo = cbx_tipoUsuario.SelectedValue
                .Clave = txt_claveUsuario.Text
                respuesta = .Ingresar()
            End With
            If Not respuesta <= 0 Then
                MessageBox.Show("Ingreso Exitoso!", "Sistema", MessageBoxButtons.OK)
            Else

                MessageBox.Show(obj_Usuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub
End Class