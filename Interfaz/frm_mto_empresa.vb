Public Class frm_mto_empresa

    Private Sub frm_mto_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_parametrosGlobales.Inicializar_controles(Me)
        cls_parametrosGlobales.Carga_permisos(Me)
    End Sub
End Class