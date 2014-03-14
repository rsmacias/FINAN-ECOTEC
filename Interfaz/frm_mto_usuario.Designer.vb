<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mto_usuario
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
        Me.grb_opciones = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_nombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_claveUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_tipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txt_apellidosPersona = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nombresPersona = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbx_sucursal = New System.Windows.Forms.ComboBox()
        Me.chk_sucursal = New System.Windows.Forms.CheckBox()
        Me.grb_opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_opciones
        '
        Me.grb_opciones.Controls.Add(Me.btn_eliminar)
        Me.grb_opciones.Controls.Add(Me.btn_editar)
        Me.grb_opciones.Controls.Add(Me.btn_nuevo)
        Me.grb_opciones.Location = New System.Drawing.Point(19, 205)
        Me.grb_opciones.Name = "grb_opciones"
        Me.grb_opciones.Size = New System.Drawing.Size(269, 67)
        Me.grb_opciones.TabIndex = 2
        Me.grb_opciones.TabStop = False
        Me.grb_opciones.Text = "Opciones"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(176, 22)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 32)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "E&liminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(95, 22)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 32)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "&Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(14, 22)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 32)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(103, 10)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 4
        '
        'txt_nombreUsuario
        '
        Me.txt_nombreUsuario.Location = New System.Drawing.Point(103, 119)
        Me.txt_nombreUsuario.Name = "txt_nombreUsuario"
        Me.txt_nombreUsuario.Size = New System.Drawing.Size(168, 20)
        Me.txt_nombreUsuario.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre usuario:"
        '
        'txt_claveUsuario
        '
        Me.txt_claveUsuario.Location = New System.Drawing.Point(103, 145)
        Me.txt_claveUsuario.Name = "txt_claveUsuario"
        Me.txt_claveUsuario.Size = New System.Drawing.Size(168, 20)
        Me.txt_claveUsuario.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo Usuario:"
        '
        'cbx_tipoUsuario
        '
        Me.cbx_tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipoUsuario.FormattingEnabled = True
        Me.cbx_tipoUsuario.Location = New System.Drawing.Point(103, 90)
        Me.cbx_tipoUsuario.Name = "cbx_tipoUsuario"
        Me.cbx_tipoUsuario.Size = New System.Drawing.Size(168, 21)
        Me.cbx_tipoUsuario.TabIndex = 11
        '
        'txt_apellidosPersona
        '
        Me.txt_apellidosPersona.Location = New System.Drawing.Point(103, 62)
        Me.txt_apellidosPersona.Name = "txt_apellidosPersona"
        Me.txt_apellidosPersona.Size = New System.Drawing.Size(168, 20)
        Me.txt_apellidosPersona.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Apellidos:"
        '
        'txt_nombresPersona
        '
        Me.txt_nombresPersona.Location = New System.Drawing.Point(103, 36)
        Me.txt_nombresPersona.Name = "txt_nombresPersona"
        Me.txt_nombresPersona.Size = New System.Drawing.Size(168, 20)
        Me.txt_nombresPersona.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nombres:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(209, 9)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(43, 23)
        Me.btn_consultar.TabIndex = 17
        Me.btn_consultar.Text = "..."
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbx_sucursal
        '
        Me.cbx_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_sucursal.FormattingEnabled = True
        Me.cbx_sucursal.Location = New System.Drawing.Point(103, 172)
        Me.cbx_sucursal.Name = "cbx_sucursal"
        Me.cbx_sucursal.Size = New System.Drawing.Size(168, 21)
        Me.cbx_sucursal.TabIndex = 19
        '
        'chk_sucursal
        '
        Me.chk_sucursal.AutoSize = True
        Me.chk_sucursal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_sucursal.Location = New System.Drawing.Point(17, 174)
        Me.chk_sucursal.Name = "chk_sucursal"
        Me.chk_sucursal.Size = New System.Drawing.Size(67, 17)
        Me.chk_sucursal.TabIndex = 20
        Me.chk_sucursal.Text = "Sucursal"
        Me.chk_sucursal.UseVisualStyleBackColor = True
        '
        'frm_mto_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 283)
        Me.Controls.Add(Me.chk_sucursal)
        Me.Controls.Add(Me.cbx_sucursal)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.txt_apellidosPersona)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nombresPersona)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_tipoUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_claveUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombreUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grb_opciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_mto_usuario"
        Me.Text = "Usuario"
        Me.grb_opciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_opciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_claveUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbx_tipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents txt_apellidosPersona As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombresPersona As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents cbx_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents chk_sucursal As System.Windows.Forms.CheckBox
End Class
