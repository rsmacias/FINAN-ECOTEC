<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pago
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombresAlumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_codigoAlumno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codigoFactura = New System.Windows.Forms.TextBox()
        Me.btn_consultarFactura = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grb_opciones = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_Imprimir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.grb_detalle = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbx_formaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_QuitarItem = New System.Windows.Forms.Button()
        Me.btn_ModificarItem = New System.Windows.Forms.Button()
        Me.btn_agregarItem = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.grb_opciones.SuspendLayout()
        Me.grb_detalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombresAlumno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_codigoAlumno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_codigoFactura)
        Me.GroupBox1.Controls.Add(Me.btn_consultarFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Factura"
        '
        'txt_nombresAlumno
        '
        Me.txt_nombresAlumno.Location = New System.Drawing.Point(300, 45)
        Me.txt_nombresAlumno.Name = "txt_nombresAlumno"
        Me.txt_nombresAlumno.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombresAlumno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Alumno:"
        '
        'txt_codigoAlumno
        '
        Me.txt_codigoAlumno.Location = New System.Drawing.Point(300, 20)
        Me.txt_codigoAlumno.Name = "txt_codigoAlumno"
        Me.txt_codigoAlumno.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigoAlumno.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cod. Alumno:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(63, 45)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha:"
        '
        'txt_codigoFactura
        '
        Me.txt_codigoFactura.Location = New System.Drawing.Point(63, 19)
        Me.txt_codigoFactura.Name = "txt_codigoFactura"
        Me.txt_codigoFactura.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigoFactura.TabIndex = 2
        '
        'btn_consultarFactura
        '
        Me.btn_consultarFactura.Location = New System.Drawing.Point(167, 18)
        Me.btn_consultarFactura.Name = "btn_consultarFactura"
        Me.btn_consultarFactura.Size = New System.Drawing.Size(36, 23)
        Me.btn_consultarFactura.TabIndex = 3
        Me.btn_consultarFactura.Text = "..."
        Me.btn_consultarFactura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número:"
        '
        'grb_opciones
        '
        Me.grb_opciones.Controls.Add(Me.btn_guardar)
        Me.grb_opciones.Controls.Add(Me.btn_Imprimir)
        Me.grb_opciones.Controls.Add(Me.btn_nuevo)
        Me.grb_opciones.Location = New System.Drawing.Point(12, 426)
        Me.grb_opciones.Name = "grb_opciones"
        Me.grb_opciones.Size = New System.Drawing.Size(255, 62)
        Me.grb_opciones.TabIndex = 22
        Me.grb_opciones.TabStop = False
        Me.grb_opciones.Text = "Opciones"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(88, 20)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 32)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "&Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Location = New System.Drawing.Point(167, 20)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(75, 32)
        Me.btn_Imprimir.TabIndex = 3
        Me.btn_Imprimir.Text = "&Reversar"
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(8, 20)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 32)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'grb_detalle
        '
        Me.grb_detalle.Controls.Add(Me.GroupBox2)
        Me.grb_detalle.Controls.Add(Me.btn_QuitarItem)
        Me.grb_detalle.Controls.Add(Me.btn_ModificarItem)
        Me.grb_detalle.Controls.Add(Me.btn_agregarItem)
        Me.grb_detalle.Controls.Add(Me.DataGridView1)
        Me.grb_detalle.Location = New System.Drawing.Point(12, 113)
        Me.grb_detalle.Name = "grb_detalle"
        Me.grb_detalle.Size = New System.Drawing.Size(508, 307)
        Me.grb_detalle.TabIndex = 23
        Me.grb_detalle.TabStop = False
        Me.grb_detalle.Text = "Detalle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbx_formaPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_observacion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_valor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 76)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'cbx_formaPago
        '
        Me.cbx_formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_formaPago.FormattingEnabled = True
        Me.cbx_formaPago.Location = New System.Drawing.Point(279, 17)
        Me.cbx_formaPago.Name = "cbx_formaPago"
        Me.cbx_formaPago.Size = New System.Drawing.Size(213, 21)
        Me.cbx_formaPago.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Forma Pago:"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(78, 42)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(414, 20)
        Me.txt_observacion.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Observación:"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(78, 17)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Valor:"
        '
        'btn_QuitarItem
        '
        Me.btn_QuitarItem.Location = New System.Drawing.Point(299, 95)
        Me.btn_QuitarItem.Name = "btn_QuitarItem"
        Me.btn_QuitarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_QuitarItem.TabIndex = 39
        Me.btn_QuitarItem.Text = "Quitar"
        Me.btn_QuitarItem.UseVisualStyleBackColor = True
        '
        'btn_ModificarItem
        '
        Me.btn_ModificarItem.Location = New System.Drawing.Point(214, 95)
        Me.btn_ModificarItem.Name = "btn_ModificarItem"
        Me.btn_ModificarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_ModificarItem.TabIndex = 38
        Me.btn_ModificarItem.Text = "Modificar"
        Me.btn_ModificarItem.UseVisualStyleBackColor = True
        '
        'btn_agregarItem
        '
        Me.btn_agregarItem.Location = New System.Drawing.Point(135, 95)
        Me.btn_agregarItem.Name = "btn_agregarItem"
        Me.btn_agregarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarItem.TabIndex = 37
        Me.btn_agregarItem.Text = "Agregar"
        Me.btn_agregarItem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(486, 165)
        Me.DataGridView1.TabIndex = 0
        '
        'frm_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 512)
        Me.Controls.Add(Me.grb_detalle)
        Me.Controls.Add(Me.grb_opciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_pago"
        Me.Text = "Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grb_opciones.ResumeLayout(False)
        Me.grb_detalle.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codigoFactura As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultarFactura As System.Windows.Forms.Button
    Friend WithEvents grb_opciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grb_detalle As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombresAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_codigoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_formaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_valor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_QuitarItem As System.Windows.Forms.Button
    Friend WithEvents btn_ModificarItem As System.Windows.Forms.Button
    Friend WithEvents btn_agregarItem As System.Windows.Forms.Button
End Class
