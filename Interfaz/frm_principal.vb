Public Class frm_principal

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializa el menu deshabilitando las opciones de primer nivel y los nodos hoja.
        inicializar_menu()

        'Muestra ventana de inicio de sesión
        Dim oIncioSesion As New frm_Inicio_Sesion()
        With oIncioSesion
            .MdiParent = Me
            .Show()
        End With
    End Sub

    ''' <summary>
    ''' Deshabilita las opciones de primer nivel del menú junto a los nodos hojas.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub inicializar_menu()
        For Each elemento As ToolStripMenuItem In MenuStrip_prinicipal.Items
            elemento.Enabled = False
            deshabilitar_opciones(elemento)
        Next
    End Sub

    ''' <summary>
    ''' Deshabilita los ToolStripMenuItem hoja.
    ''' </summary>
    ''' <param name="elemento">ToolStripMenuItem a recorrer.</param>
    ''' <remarks></remarks>
    Private Sub deshabilitar_opciones(elemento As ToolStripMenuItem)
        For Each opcion As ToolStripMenuItem In elemento.DropDownItems
            If opcion.HasDropDown Then
                deshabilitar_opciones(opcion)
            Else
                opcion.Enabled = False
            End If
        Next
    End Sub

    ''' <summary>
    ''' Habilita las opciones del primer nivel del menu
    ''' </summary>
    ''' <param name="dt_permisos">DataTable con las opciones a habilitar.</param>
    ''' <remarks></remarks>
    Public Sub habilitar_menu(dt_permisos As DataTable)
        For Each elemento As ToolStripMenuItem In MenuStrip_prinicipal.Items
            elemento.Enabled = True
            habilitar_opciones(elemento, dt_permisos)
        Next
    End Sub

    ''' <summary>
    ''' Habilita los ToolStripMenuItem hoja.
    ''' </summary>
    ''' <param name="elemento">ToolStripMenuItem a recorrer.</param>
    ''' <param name="dt_permisos">DataTable con las opciones a habilitar.</param>
    ''' <remarks></remarks>
    Private Sub habilitar_opciones(elemento As ToolStripMenuItem, dt_permisos As DataTable)
        For Each opcion As ToolStripMenuItem In elemento.DropDownItems
            For Each fila As DataRow In dt_permisos.Rows
                If opcion.Name = fila("nom_control").ToString() Then
                    opcion.Enabled = True
                End If
            Next
            If opcion.HasDropDown Then
                habilitar_opciones(opcion, dt_permisos)
            End If
        Next
    End Sub



    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_Usuarios.Click
        Dim oUsuario As New frm_mto_usuario
        With oUsuario
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_departamento.Click
        Dim ofDepartamento As New frm_mto_departamento
        With ofDepartamento
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub SucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_sucursal.Click
        Dim ofSucursal As New frm_mto_sucursal
        With ofSucursal
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub FormaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_formaPago.Click
        Dim ofForma_Pago As New frm_mto_formaPago
        With ofForma_Pago
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub BancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_banco.Click
        Dim ofBanco As New frm_mto_banco
        With ofBanco
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_facturacion.Click
        Dim ofFacturacion As New frm_facturacion
        With ofFacturacion
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_pago.Click
        Dim ofPago As New frm_pago
        With ofPago
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_rptSeguridad_general.Click
        Dim ofPago As New frm_rpt_general
        With ofPago
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub EspecificoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_rptSeguridad_especifico.Click
        Dim ofPago As New frm_rpt_especifico
        With ofPago
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub tsmi_cerrarSesion_Click(sender As Object, e As EventArgs) Handles tsmi_cerrarSesion.Click

    End Sub
End Class