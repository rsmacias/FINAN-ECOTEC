﻿Public Class frm_mto_tipoUsuario

    Private Sub frm_mto_tipoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_parametrosGlobales.Inicializar_controles(Me)
        cls_parametrosGlobales.Carga_permisos(Me)
    End Sub
End Class