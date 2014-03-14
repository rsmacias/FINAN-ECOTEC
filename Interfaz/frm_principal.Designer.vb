<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip_prinicipal = New System.Windows.Forms.MenuStrip()
        Me.tsmi_inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_cerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_manteniemientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_departamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_sucursal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_formaPago = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_banco = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_procesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_facturacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_pago = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_seguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_perfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptSeguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptSeguridad_general = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptSeguridad_especifico = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptPagos_general = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rptPagos_especifico = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip_prinicipal = New System.Windows.Forms.StatusStrip()
        Me.tssl_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_apellido = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_tipoUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip_prinicipal.SuspendLayout()
        Me.StatusStrip_prinicipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_prinicipal
        '
        Me.MenuStrip_prinicipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_inicio, Me.tsmi_manteniemientos, Me.tsmi_procesos, Me.tsmi_seguridad, Me.tsmi_reportes})
        Me.MenuStrip_prinicipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_prinicipal.Name = "MenuStrip_prinicipal"
        Me.MenuStrip_prinicipal.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip_prinicipal.TabIndex = 1
        Me.MenuStrip_prinicipal.Text = "MenuStrip1"
        '
        'tsmi_inicio
        '
        Me.tsmi_inicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_cerrarSesion})
        Me.tsmi_inicio.Name = "tsmi_inicio"
        Me.tsmi_inicio.Size = New System.Drawing.Size(48, 20)
        Me.tsmi_inicio.Text = "&Inicio"
        '
        'tsmi_cerrarSesion
        '
        Me.tsmi_cerrarSesion.Name = "tsmi_cerrarSesion"
        Me.tsmi_cerrarSesion.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_cerrarSesion.Text = "Cerrar Sesión"
        '
        'tsmi_manteniemientos
        '
        Me.tsmi_manteniemientos.AutoToolTip = True
        Me.tsmi_manteniemientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_departamento, Me.tsmi_sucursal, Me.tsmi_formaPago, Me.tsmi_banco})
        Me.tsmi_manteniemientos.Name = "tsmi_manteniemientos"
        Me.tsmi_manteniemientos.Size = New System.Drawing.Size(112, 20)
        Me.tsmi_manteniemientos.Text = "&Manteniemientos"
        '
        'tsmi_departamento
        '
        Me.tsmi_departamento.Name = "tsmi_departamento"
        Me.tsmi_departamento.Size = New System.Drawing.Size(154, 22)
        Me.tsmi_departamento.Text = "Departamento"
        '
        'tsmi_sucursal
        '
        Me.tsmi_sucursal.Name = "tsmi_sucursal"
        Me.tsmi_sucursal.Size = New System.Drawing.Size(154, 22)
        Me.tsmi_sucursal.Text = "Sucursal"
        '
        'tsmi_formaPago
        '
        Me.tsmi_formaPago.Name = "tsmi_formaPago"
        Me.tsmi_formaPago.Size = New System.Drawing.Size(154, 22)
        Me.tsmi_formaPago.Text = "Forma de Pago"
        '
        'tsmi_banco
        '
        Me.tsmi_banco.Name = "tsmi_banco"
        Me.tsmi_banco.Size = New System.Drawing.Size(154, 22)
        Me.tsmi_banco.Text = "Banco"
        '
        'tsmi_procesos
        '
        Me.tsmi_procesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_facturacion, Me.tsmi_pago})
        Me.tsmi_procesos.Name = "tsmi_procesos"
        Me.tsmi_procesos.Size = New System.Drawing.Size(66, 20)
        Me.tsmi_procesos.Text = "Procesos"
        '
        'tsmi_facturacion
        '
        Me.tsmi_facturacion.Name = "tsmi_facturacion"
        Me.tsmi_facturacion.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_facturacion.Text = "Facturación"
        '
        'tsmi_pago
        '
        Me.tsmi_pago.Name = "tsmi_pago"
        Me.tsmi_pago.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_pago.Text = "Pago"
        '
        'tsmi_seguridad
        '
        Me.tsmi_seguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Usuarios, Me.tsmi_perfiles, Me.tsmi_permisos})
        Me.tsmi_seguridad.Name = "tsmi_seguridad"
        Me.tsmi_seguridad.Size = New System.Drawing.Size(72, 20)
        Me.tsmi_seguridad.Text = "&Seguridad"
        '
        'tsmi_Usuarios
        '
        Me.tsmi_Usuarios.Name = "tsmi_Usuarios"
        Me.tsmi_Usuarios.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_Usuarios.Text = "&Usuarios"
        '
        'tsmi_perfiles
        '
        Me.tsmi_perfiles.Name = "tsmi_perfiles"
        Me.tsmi_perfiles.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_perfiles.Text = "Perfiles"
        '
        'tsmi_permisos
        '
        Me.tsmi_permisos.Name = "tsmi_permisos"
        Me.tsmi_permisos.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_permisos.Text = "Permisos"
        '
        'tsmi_reportes
        '
        Me.tsmi_reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_rptSeguridad, Me.tsmi_rptPagos})
        Me.tsmi_reportes.Name = "tsmi_reportes"
        Me.tsmi_reportes.Size = New System.Drawing.Size(65, 20)
        Me.tsmi_reportes.Text = "Reportes"
        '
        'tsmi_rptSeguridad
        '
        Me.tsmi_rptSeguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_rptSeguridad_general, Me.tsmi_rptSeguridad_especifico})
        Me.tsmi_rptSeguridad.Name = "tsmi_rptSeguridad"
        Me.tsmi_rptSeguridad.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptSeguridad.Text = "Seguridad"
        '
        'tsmi_rptSeguridad_general
        '
        Me.tsmi_rptSeguridad_general.Name = "tsmi_rptSeguridad_general"
        Me.tsmi_rptSeguridad_general.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptSeguridad_general.Text = "General"
        '
        'tsmi_rptSeguridad_especifico
        '
        Me.tsmi_rptSeguridad_especifico.Name = "tsmi_rptSeguridad_especifico"
        Me.tsmi_rptSeguridad_especifico.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptSeguridad_especifico.Text = "Especifico"
        '
        'tsmi_rptPagos
        '
        Me.tsmi_rptPagos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_rptPagos_general, Me.tsmi_rptPagos_especifico})
        Me.tsmi_rptPagos.Name = "tsmi_rptPagos"
        Me.tsmi_rptPagos.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptPagos.Text = "Pagos"
        '
        'tsmi_rptPagos_general
        '
        Me.tsmi_rptPagos_general.Name = "tsmi_rptPagos_general"
        Me.tsmi_rptPagos_general.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptPagos_general.Text = "General"
        '
        'tsmi_rptPagos_especifico
        '
        Me.tsmi_rptPagos_especifico.Name = "tsmi_rptPagos_especifico"
        Me.tsmi_rptPagos_especifico.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_rptPagos_especifico.Text = "Especifico"
        '
        'StatusStrip_prinicipal
        '
        Me.StatusStrip_prinicipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_usuario, Me.tssl_apellido, Me.tssl_tipoUsuario})
        Me.StatusStrip_prinicipal.Location = New System.Drawing.Point(0, 444)
        Me.StatusStrip_prinicipal.Name = "StatusStrip_prinicipal"
        Me.StatusStrip_prinicipal.Size = New System.Drawing.Size(670, 22)
        Me.StatusStrip_prinicipal.TabIndex = 2
        Me.StatusStrip_prinicipal.Text = "StatusStrip1"
        '
        'tssl_usuario
        '
        Me.tssl_usuario.Name = "tssl_usuario"
        Me.tssl_usuario.Size = New System.Drawing.Size(0, 17)
        '
        'tssl_apellido
        '
        Me.tssl_apellido.Name = "tssl_apellido"
        Me.tssl_apellido.Size = New System.Drawing.Size(0, 17)
        '
        'tssl_tipoUsuario
        '
        Me.tssl_tipoUsuario.Name = "tssl_tipoUsuario"
        Me.tssl_tipoUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 466)
        Me.Controls.Add(Me.StatusStrip_prinicipal)
        Me.Controls.Add(Me.MenuStrip_prinicipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip_prinicipal
        Me.Name = "frm_principal"
        Me.Text = "Sistema"
        Me.MenuStrip_prinicipal.ResumeLayout(False)
        Me.MenuStrip_prinicipal.PerformLayout()
        Me.StatusStrip_prinicipal.ResumeLayout(False)
        Me.StatusStrip_prinicipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip_prinicipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmi_inicio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_cerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip_prinicipal As System.Windows.Forms.StatusStrip
    Friend WithEvents tsmi_manteniemientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_seguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssl_usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmi_departamento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_sucursal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_formaPago As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_banco As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_procesos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_facturacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_pago As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_perfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssl_apellido As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmi_reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptSeguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptSeguridad_general As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptSeguridad_especifico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptPagos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptPagos_general As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_rptPagos_especifico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssl_tipoUsuario As System.Windows.Forms.ToolStripStatusLabel
End Class
