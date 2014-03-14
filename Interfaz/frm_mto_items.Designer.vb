<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mto_items
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
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_opciones = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_grupo = New System.Windows.Forms.ComboBox()
        Me.cbx_nviel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grb_opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_estado
        '
        Me.txt_estado.Enabled = False
        Me.txt_estado.Location = New System.Drawing.Point(79, 163)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(100, 20)
        Me.txt_estado.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Estado:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(185, 6)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(43, 23)
        Me.btn_consultar.TabIndex = 18
        Me.btn_consultar.Text = "..."
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(79, 35)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion.Size = New System.Drawing.Size(230, 40)
        Me.txt_descripcion.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(79, 9)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código:"
        '
        'grb_opciones
        '
        Me.grb_opciones.Controls.Add(Me.btn_eliminar)
        Me.grb_opciones.Controls.Add(Me.btn_editar)
        Me.grb_opciones.Controls.Add(Me.btn_nuevo)
        Me.grb_opciones.Location = New System.Drawing.Point(20, 195)
        Me.grb_opciones.Name = "grb_opciones"
        Me.grb_opciones.Size = New System.Drawing.Size(304, 67)
        Me.grb_opciones.TabIndex = 15
        Me.grb_opciones.TabStop = False
        Me.grb_opciones.Text = "Opciones"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(195, 22)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 32)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "E&liminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(114, 22)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 32)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "&Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(33, 22)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 32)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Grupo:"
        '
        'cbx_grupo
        '
        Me.cbx_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_grupo.FormattingEnabled = True
        Me.cbx_grupo.Location = New System.Drawing.Point(79, 82)
        Me.cbx_grupo.Name = "cbx_grupo"
        Me.cbx_grupo.Size = New System.Drawing.Size(200, 21)
        Me.cbx_grupo.TabIndex = 24
        '
        'cbx_nviel
        '
        Me.cbx_nviel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nviel.FormattingEnabled = True
        Me.cbx_nviel.Location = New System.Drawing.Point(79, 109)
        Me.cbx_nviel.Name = "cbx_nviel"
        Me.cbx_nviel.Size = New System.Drawing.Size(149, 21)
        Me.cbx_nviel.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nivel:"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(79, 136)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Precio:"
        '
        'frm_mto_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 272)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_nviel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbx_grupo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grb_opciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_mto_items"
        Me.Text = "Productos"
        Me.grb_opciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grb_opciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbx_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_nviel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
