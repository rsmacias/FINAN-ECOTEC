<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facturacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_periodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultarAlumno = New System.Windows.Forms.Button()
        Me.txt_apellidosAlumno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombresAlumno = New System.Windows.Forms.TextBox()
        Me.txt_codigoAlumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_consultarFactura = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_pagado = New System.Windows.Forms.CheckBox()
        Me.chk_impreso = New System.Windows.Forms.CheckBox()
        Me.grb_detalle = New System.Windows.Forms.GroupBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.grb_opciones = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_pagar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grb_Item = New System.Windows.Forms.GroupBox()
        Me.dtp_fechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_abono = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_consultarItem = New System.Windows.Forms.Button()
        Me.txt_descripcionItem = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_grupo = New System.Windows.Forms.TextBox()
        Me.txt_codigoItem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_quitarItem = New System.Windows.Forms.Button()
        Me.btn_modificarItem = New System.Windows.Forms.Button()
        Me.btn_agregarItem = New System.Windows.Forms.Button()
        Me.txt_totalPagar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grb_cabecera = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_codigoSRI = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_autorizacion = New System.Windows.Forms.TextBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.grb_detalle.SuspendLayout()
        Me.grb_opciones.SuspendLayout()
        Me.grb_Item.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_cabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número:"
        '
        'txt_numero
        '
        Me.txt_numero.Enabled = False
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(91, 18)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(161, 26)
        Me.txt_numero.TabIndex = 2
        '
        'txt_periodo
        '
        Me.txt_periodo.Location = New System.Drawing.Point(91, 70)
        Me.txt_periodo.Name = "txt_periodo"
        Me.txt_periodo.Size = New System.Drawing.Size(100, 20)
        Me.txt_periodo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Período:"
        '
        'txt_estado
        '
        Me.txt_estado.Enabled = False
        Me.txt_estado.Location = New System.Drawing.Point(91, 142)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(119, 20)
        Me.txt_estado.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultarAlumno)
        Me.GroupBox1.Controls.Add(Me.txt_apellidosAlumno)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_nombresAlumno)
        Me.GroupBox1.Controls.Add(Me.txt_codigoAlumno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 93)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Alumno"
        '
        'btn_consultarAlumno
        '
        Me.btn_consultarAlumno.Location = New System.Drawing.Point(205, 16)
        Me.btn_consultarAlumno.Name = "btn_consultarAlumno"
        Me.btn_consultarAlumno.Size = New System.Drawing.Size(36, 23)
        Me.btn_consultarAlumno.TabIndex = 8
        Me.btn_consultarAlumno.Text = "..."
        Me.btn_consultarAlumno.UseVisualStyleBackColor = True
        '
        'txt_apellidosAlumno
        '
        Me.txt_apellidosAlumno.Location = New System.Drawing.Point(92, 64)
        Me.txt_apellidosAlumno.Name = "txt_apellidosAlumno"
        Me.txt_apellidosAlumno.Size = New System.Drawing.Size(174, 20)
        Me.txt_apellidosAlumno.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Apellidos:"
        '
        'txt_nombresAlumno
        '
        Me.txt_nombresAlumno.Location = New System.Drawing.Point(92, 41)
        Me.txt_nombresAlumno.Name = "txt_nombresAlumno"
        Me.txt_nombresAlumno.Size = New System.Drawing.Size(174, 20)
        Me.txt_nombresAlumno.TabIndex = 11
        '
        'txt_codigoAlumno
        '
        Me.txt_codigoAlumno.Location = New System.Drawing.Point(92, 18)
        Me.txt_codigoAlumno.Name = "txt_codigoAlumno"
        Me.txt_codigoAlumno.Size = New System.Drawing.Size(107, 20)
        Me.txt_codigoAlumno.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombres:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Código:"
        '
        'btn_consultarFactura
        '
        Me.btn_consultarFactura.Location = New System.Drawing.Point(258, 19)
        Me.btn_consultarFactura.Name = "btn_consultarFactura"
        Me.btn_consultarFactura.Size = New System.Drawing.Size(36, 23)
        Me.btn_consultarFactura.TabIndex = 14
        Me.btn_consultarFactura.Text = "..."
        Me.btn_consultarFactura.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pagado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Impreso:"
        '
        'chk_pagado
        '
        Me.chk_pagado.AutoSize = True
        Me.chk_pagado.Location = New System.Drawing.Point(63, 171)
        Me.chk_pagado.Name = "chk_pagado"
        Me.chk_pagado.Size = New System.Drawing.Size(15, 14)
        Me.chk_pagado.TabIndex = 18
        Me.chk_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_pagado.UseVisualStyleBackColor = True
        '
        'chk_impreso
        '
        Me.chk_impreso.AutoSize = True
        Me.chk_impreso.Location = New System.Drawing.Point(146, 171)
        Me.chk_impreso.Name = "chk_impreso"
        Me.chk_impreso.Size = New System.Drawing.Size(15, 14)
        Me.chk_impreso.TabIndex = 19
        Me.chk_impreso.UseVisualStyleBackColor = True
        '
        'grb_detalle
        '
        Me.grb_detalle.Controls.Add(Me.txt_descuento)
        Me.grb_detalle.Controls.Add(Me.grb_opciones)
        Me.grb_detalle.Controls.Add(Me.Label20)
        Me.grb_detalle.Controls.Add(Me.grb_Item)
        Me.grb_detalle.Controls.Add(Me.btn_quitarItem)
        Me.grb_detalle.Controls.Add(Me.btn_modificarItem)
        Me.grb_detalle.Controls.Add(Me.btn_agregarItem)
        Me.grb_detalle.Controls.Add(Me.txt_totalPagar)
        Me.grb_detalle.Controls.Add(Me.Label11)
        Me.grb_detalle.Controls.Add(Me.txt_IVA)
        Me.grb_detalle.Controls.Add(Me.Label10)
        Me.grb_detalle.Controls.Add(Me.txt_subtotal)
        Me.grb_detalle.Controls.Add(Me.Label9)
        Me.grb_detalle.Controls.Add(Me.DataGridView1)
        Me.grb_detalle.Location = New System.Drawing.Point(12, 201)
        Me.grb_detalle.Name = "grb_detalle"
        Me.grb_detalle.Size = New System.Drawing.Size(627, 468)
        Me.grb_detalle.TabIndex = 20
        Me.grb_detalle.TabStop = False
        Me.grb_detalle.Text = "Detalle"
        '
        'txt_descuento
        '
        Me.txt_descuento.Enabled = False
        Me.txt_descuento.Location = New System.Drawing.Point(487, 417)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(131, 20)
        Me.txt_descuento.TabIndex = 39
        '
        'grb_opciones
        '
        Me.grb_opciones.Controls.Add(Me.btn_guardar)
        Me.grb_opciones.Controls.Add(Me.btn_imprimir)
        Me.grb_opciones.Controls.Add(Me.btn_pagar)
        Me.grb_opciones.Controls.Add(Me.btn_nuevo)
        Me.grb_opciones.Location = New System.Drawing.Point(16, 393)
        Me.grb_opciones.Name = "grb_opciones"
        Me.grb_opciones.Size = New System.Drawing.Size(330, 62)
        Me.grb_opciones.TabIndex = 21
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
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(248, 20)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(75, 32)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "&Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_pagar
        '
        Me.btn_pagar.Location = New System.Drawing.Point(168, 20)
        Me.btn_pagar.Name = "btn_pagar"
        Me.btn_pagar.Size = New System.Drawing.Size(75, 32)
        Me.btn_pagar.TabIndex = 2
        Me.btn_pagar.Text = "&Pagar"
        Me.btn_pagar.UseVisualStyleBackColor = True
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(424, 421)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Descuento:"
        '
        'grb_Item
        '
        Me.grb_Item.Controls.Add(Me.dtp_fechaCobro)
        Me.grb_Item.Controls.Add(Me.Label19)
        Me.grb_Item.Controls.Add(Me.txt_abono)
        Me.grb_Item.Controls.Add(Me.Label18)
        Me.grb_Item.Controls.Add(Me.txt_precio)
        Me.grb_Item.Controls.Add(Me.Label15)
        Me.grb_Item.Controls.Add(Me.btn_consultarItem)
        Me.grb_Item.Controls.Add(Me.txt_descripcionItem)
        Me.grb_Item.Controls.Add(Me.Label12)
        Me.grb_Item.Controls.Add(Me.txt_grupo)
        Me.grb_Item.Controls.Add(Me.txt_codigoItem)
        Me.grb_Item.Controls.Add(Me.Label13)
        Me.grb_Item.Controls.Add(Me.Label14)
        Me.grb_Item.Location = New System.Drawing.Point(11, 12)
        Me.grb_Item.Name = "grb_Item"
        Me.grb_Item.Size = New System.Drawing.Size(607, 94)
        Me.grb_Item.TabIndex = 37
        Me.grb_Item.TabStop = False
        '
        'dtp_fechaCobro
        '
        Me.dtp_fechaCobro.Location = New System.Drawing.Point(314, 65)
        Me.dtp_fechaCobro.Name = "dtp_fechaCobro"
        Me.dtp_fechaCobro.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fechaCobro.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(237, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Fecha Cobro:"
        '
        'txt_abono
        '
        Me.txt_abono.Location = New System.Drawing.Point(72, 64)
        Me.txt_abono.Name = "txt_abono"
        Me.txt_abono.Size = New System.Drawing.Size(90, 20)
        Me.txt_abono.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Abono:"
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Location = New System.Drawing.Point(314, 39)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(163, 20)
        Me.txt_precio.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(237, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Precio:"
        '
        'btn_consultarItem
        '
        Me.btn_consultarItem.Location = New System.Drawing.Point(166, 12)
        Me.btn_consultarItem.Name = "btn_consultarItem"
        Me.btn_consultarItem.Size = New System.Drawing.Size(36, 23)
        Me.btn_consultarItem.TabIndex = 34
        Me.btn_consultarItem.Text = "..."
        Me.btn_consultarItem.UseVisualStyleBackColor = True
        '
        'txt_descripcionItem
        '
        Me.txt_descripcionItem.Enabled = False
        Me.txt_descripcionItem.Location = New System.Drawing.Point(314, 14)
        Me.txt_descripcionItem.Name = "txt_descripcionItem"
        Me.txt_descripcionItem.Size = New System.Drawing.Size(269, 20)
        Me.txt_descripcionItem.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(237, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Descripción:"
        '
        'txt_grupo
        '
        Me.txt_grupo.Enabled = False
        Me.txt_grupo.Location = New System.Drawing.Point(72, 38)
        Me.txt_grupo.Name = "txt_grupo"
        Me.txt_grupo.Size = New System.Drawing.Size(152, 20)
        Me.txt_grupo.TabIndex = 38
        '
        'txt_codigoItem
        '
        Me.txt_codigoItem.Location = New System.Drawing.Point(72, 14)
        Me.txt_codigoItem.Name = "txt_codigoItem"
        Me.txt_codigoItem.Size = New System.Drawing.Size(90, 20)
        Me.txt_codigoItem.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Grupo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Código:"
        '
        'btn_quitarItem
        '
        Me.btn_quitarItem.Location = New System.Drawing.Point(358, 109)
        Me.btn_quitarItem.Name = "btn_quitarItem"
        Me.btn_quitarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitarItem.TabIndex = 36
        Me.btn_quitarItem.Text = "Quitar"
        Me.btn_quitarItem.UseVisualStyleBackColor = True
        '
        'btn_modificarItem
        '
        Me.btn_modificarItem.Location = New System.Drawing.Point(273, 109)
        Me.btn_modificarItem.Name = "btn_modificarItem"
        Me.btn_modificarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificarItem.TabIndex = 35
        Me.btn_modificarItem.Text = "Modificar"
        Me.btn_modificarItem.UseVisualStyleBackColor = True
        '
        'btn_agregarItem
        '
        Me.btn_agregarItem.Location = New System.Drawing.Point(194, 109)
        Me.btn_agregarItem.Name = "btn_agregarItem"
        Me.btn_agregarItem.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarItem.TabIndex = 34
        Me.btn_agregarItem.Text = "Agregar"
        Me.btn_agregarItem.UseVisualStyleBackColor = True
        '
        'txt_totalPagar
        '
        Me.txt_totalPagar.Enabled = False
        Me.txt_totalPagar.Location = New System.Drawing.Point(487, 441)
        Me.txt_totalPagar.Name = "txt_totalPagar"
        Me.txt_totalPagar.Size = New System.Drawing.Size(131, 20)
        Me.txt_totalPagar.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(424, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Total:"
        '
        'txt_IVA
        '
        Me.txt_IVA.Enabled = False
        Me.txt_IVA.Location = New System.Drawing.Point(487, 393)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.Size = New System.Drawing.Size(131, 20)
        Me.txt_IVA.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(424, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "IVA:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(487, 369)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(131, 20)
        Me.txt_subtotal.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(424, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Subtotal:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(605, 225)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripción"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Abono"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Grupo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha Pago"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'grb_cabecera
        '
        Me.grb_cabecera.Controls.Add(Me.Label22)
        Me.grb_cabecera.Controls.Add(Me.txt_codigoSRI)
        Me.grb_cabecera.Controls.Add(Me.Label21)
        Me.grb_cabecera.Controls.Add(Me.txt_autorizacion)
        Me.grb_cabecera.Controls.Add(Me.txt_observacion)
        Me.grb_cabecera.Controls.Add(Me.Label17)
        Me.grb_cabecera.Controls.Add(Me.Label16)
        Me.grb_cabecera.Controls.Add(Me.txt_fecha)
        Me.grb_cabecera.Controls.Add(Me.txt_numero)
        Me.grb_cabecera.Controls.Add(Me.Label1)
        Me.grb_cabecera.Controls.Add(Me.Label2)
        Me.grb_cabecera.Controls.Add(Me.chk_impreso)
        Me.grb_cabecera.Controls.Add(Me.txt_periodo)
        Me.grb_cabecera.Controls.Add(Me.chk_pagado)
        Me.grb_cabecera.Controls.Add(Me.Label3)
        Me.grb_cabecera.Controls.Add(Me.Label8)
        Me.grb_cabecera.Controls.Add(Me.txt_estado)
        Me.grb_cabecera.Controls.Add(Me.Label7)
        Me.grb_cabecera.Controls.Add(Me.GroupBox1)
        Me.grb_cabecera.Controls.Add(Me.btn_consultarFactura)
        Me.grb_cabecera.Location = New System.Drawing.Point(12, 3)
        Me.grb_cabecera.Name = "grb_cabecera"
        Me.grb_cabecera.Size = New System.Drawing.Size(627, 192)
        Me.grb_cabecera.TabIndex = 22
        Me.grb_cabecera.TabStop = False
        Me.grb_cabecera.Text = "Cabecera"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Cod. SRI:"
        '
        'txt_codigoSRI
        '
        Me.txt_codigoSRI.Location = New System.Drawing.Point(91, 117)
        Me.txt_codigoSRI.Name = "txt_codigoSRI"
        Me.txt_codigoSRI.Size = New System.Drawing.Size(144, 20)
        Me.txt_codigoSRI.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Autorización:"
        '
        'txt_autorizacion
        '
        Me.txt_autorizacion.Location = New System.Drawing.Point(91, 93)
        Me.txt_autorizacion.Name = "txt_autorizacion"
        Me.txt_autorizacion.Size = New System.Drawing.Size(144, 20)
        Me.txt_autorizacion.TabIndex = 23
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(408, 111)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observacion.Size = New System.Drawing.Size(209, 73)
        Me.txt_observacion.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(338, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Observación:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Fecha:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Location = New System.Drawing.Point(91, 47)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(140, 20)
        Me.txt_fecha.TabIndex = 21
        '
        'frm_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 678)
        Me.Controls.Add(Me.grb_cabecera)
        Me.Controls.Add(Me.grb_detalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_facturacion"
        Me.Text = "Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grb_detalle.ResumeLayout(False)
        Me.grb_detalle.PerformLayout()
        Me.grb_opciones.ResumeLayout(False)
        Me.grb_Item.ResumeLayout(False)
        Me.grb_Item.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_cabecera.ResumeLayout(False)
        Me.grb_cabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents txt_periodo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_consultarAlumno As System.Windows.Forms.Button
    Friend WithEvents txt_apellidosAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombresAlumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_consultarFactura As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_pagado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_impreso As System.Windows.Forms.CheckBox
    Friend WithEvents grb_detalle As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grb_opciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_pagar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents txt_totalPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_IVA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grb_cabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_quitarItem As System.Windows.Forms.Button
    Friend WithEvents btn_modificarItem As System.Windows.Forms.Button
    Friend WithEvents btn_agregarItem As System.Windows.Forms.Button
    Friend WithEvents grb_Item As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_abono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_consultarItem As System.Windows.Forms.Button
    Friend WithEvents txt_descripcionItem As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_grupo As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigoItem As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_codigoSRI As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_autorizacion As System.Windows.Forms.TextBox
End Class
