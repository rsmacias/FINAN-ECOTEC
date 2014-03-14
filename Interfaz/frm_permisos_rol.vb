Imports System.Data
Imports Prueba

Public Class frm_permisos_rol

    Private Sub frm_permisos_rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cls_parametrosGlobales.Inicializar_controles(Me)
        'cls_parametrosGlobales.Carga_permisos(Me)

        carga_arbol_menu()
        carga_tiposUsuario()
    End Sub

    Private Sub carga_arbol_menu()
        Dim ds As New DataSet()
        Dim obj_tipoUsuario As New cls_tipo_usuario()
        Dim nodo_padre As TreeNode
        Dim fila_padre As DataRow

        Try
            ds = obj_tipoUsuario.Consultar_menu()
            If Not ds.Tables.Count <= 0 Then
                tv_menu.Nodes.Clear()
                For Each fila_padre In ds.Tables(0).Rows
                    nodo_padre = New TreeNode(fila_padre.Item("MENU_NOMBRE"))
                    nodo_padre.Tag = fila_padre.Item("MENU_CODIGO") & "-" & fila_padre.Item("MENU_CONTROL_NOMBRE")
                    tv_menu.Nodes.Add(nodo_padre)
                    'PREGUNTA PRIMERO SI EXISTE O NO RELACION DE LA FILA
                    If fila_padre.GetChildRows("relacion_1").Count > 0 Then
                        carga_nodos(fila_padre, nodo_padre, 1)
                    End If
                Next
            Else
                If Not obj_tipoUsuario.Recurso_Error = String.Empty Then
                    MessageBox.Show(obj_tipoUsuario.Recurso_Error, "Sistema", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("No existe ninguna opción de menú almacenada.", "Sistema", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Interfaz: " & ex.Message, "Sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub carga_nodos(ByVal fila_padre As DataRow, nodo_padre As TreeNode, ByVal indice As Integer)
        Dim nodo_hijo As New TreeNode
        Dim fila_hija As DataRow
        For Each fila_hija In fila_padre.GetChildRows("relacion_" & indice)
            nodo_hijo = nodo_padre.Nodes.Add(fila_hija("MENU_NOMBRE"))
            nodo_hijo.Tag = fila_hija.Item("MENU_CODIGO") & "-" & fila_hija.Item("MENU_CONTROL_NOMBRE")
            'PREGUNTA PRIMERO SI EXISTE O NO RELACION DE LA FILA
            If fila_hija.GetChildRows("relacion_" & indice + 1).Count > 0 Then
                carga_nodos(fila_hija, nodo_hijo, indice + 1)
            End If
        Next
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

    Private Sub tv_menu_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tv_menu.NodeMouseClick
        'MessageBox.Show(e.Node.Tag)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nodo_seleccion As New TreeNode()
        nodo_seleccion = tv_menu.SelectedNode
        If nodo_seleccion.Nodes.Count > 0 Then
            MessageBox.Show("Solo puede seleccionar NODOS HOJA")
        Else
            MessageBox.Show("Nodo Seleccionado: " & nodo_seleccion.Text & " con: " & nodo_seleccion.Tag)
        End If
    End Sub
End Class