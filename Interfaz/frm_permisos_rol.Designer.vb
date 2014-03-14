<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_permisos_rol
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
        Me.tv_menu = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbx_tipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_modulo = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'tv_menu
        '
        Me.tv_menu.Location = New System.Drawing.Point(12, 25)
        Me.tv_menu.Name = "tv_menu"
        Me.tv_menu.Size = New System.Drawing.Size(226, 305)
        Me.tv_menu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(244, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbx_tipoUsuario
        '
        Me.cbx_tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipoUsuario.FormattingEnabled = True
        Me.cbx_tipoUsuario.Location = New System.Drawing.Point(400, 25)
        Me.cbx_tipoUsuario.Name = "cbx_tipoUsuario"
        Me.cbx_tipoUsuario.Size = New System.Drawing.Size(183, 21)
        Me.cbx_tipoUsuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Usuario:"
        '
        'grb_modulo
        '
        Me.grb_modulo.Location = New System.Drawing.Point(313, 52)
        Me.grb_modulo.Name = "grb_modulo"
        Me.grb_modulo.Size = New System.Drawing.Size(279, 278)
        Me.grb_modulo.TabIndex = 4
        Me.grb_modulo.TabStop = False
        Me.grb_modulo.Text = "Características Módulo"
        '
        'frm_permisos_rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 405)
        Me.Controls.Add(Me.grb_modulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_tipoUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tv_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_permisos_rol"
        Me.Text = "Asignación de permisos de menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv_menu As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbx_tipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grb_modulo As System.Windows.Forms.GroupBox
End Class
