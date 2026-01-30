<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacionRapida_Despachos_Hab_facturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacionRapida_Despachos_Hab_facturacion))
        Me.lbl_texto_comprobante = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_cantidad_total_hab = New System.Windows.Forms.Label()
        Me.lbl_cantidad_total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_hab = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones_hab = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_hab = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_detalle_cobro = New System.Windows.Forms.DataGridView()
        Me.pnlTipoNumeracion = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalirNumeracion = New System.Windows.Forms.Button()
        Me.btnAceptarNumeracion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_detalle_cobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipoNumeracion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_texto_comprobante
        '
        Me.lbl_texto_comprobante.BackColor = System.Drawing.Color.Navy
        Me.lbl_texto_comprobante.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto_comprobante.ForeColor = System.Drawing.Color.White
        Me.lbl_texto_comprobante.Location = New System.Drawing.Point(11, 13)
        Me.lbl_texto_comprobante.Name = "lbl_texto_comprobante"
        Me.lbl_texto_comprobante.Size = New System.Drawing.Size(822, 26)
        Me.lbl_texto_comprobante.TabIndex = 125
        Me.lbl_texto_comprobante.Text = "HABILITAR PEDIDO PARA FACTURACION"
        Me.lbl_texto_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_cantidad_total_hab)
        Me.GroupBox2.Controls.Add(Me.lbl_cantidad_total)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(11, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 100)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'lbl_cantidad_total_hab
        '
        Me.lbl_cantidad_total_hab.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad_total_hab.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cantidad_total_hab.Location = New System.Drawing.Point(210, 56)
        Me.lbl_cantidad_total_hab.Name = "lbl_cantidad_total_hab"
        Me.lbl_cantidad_total_hab.Size = New System.Drawing.Size(145, 26)
        Me.lbl_cantidad_total_hab.TabIndex = 120
        Me.lbl_cantidad_total_hab.Text = "Pagado"
        Me.lbl_cantidad_total_hab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cantidad_total
        '
        Me.lbl_cantidad_total.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad_total.ForeColor = System.Drawing.Color.Red
        Me.lbl_cantidad_total.Location = New System.Drawing.Point(210, 19)
        Me.lbl_cantidad_total.Name = "lbl_cantidad_total"
        Me.lbl_cantidad_total.Size = New System.Drawing.Size(145, 26)
        Me.lbl_cantidad_total.TabIndex = 119
        Me.lbl_cantidad_total.Text = "Monto Venta"
        Me.lbl_cantidad_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(16, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 26)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Cantidad Hab."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(16, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 26)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Cantidad total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_hab)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_del)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones_hab)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_hab)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dgv_detalle_cobro)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(11, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 278)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de habilitaciones"
        '
        'dtp_fecha_hab
        '
        Me.dtp_fecha_hab.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fecha_hab.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha_hab.Location = New System.Drawing.Point(518, 38)
        Me.dtp_fecha_hab.Name = "dtp_fecha_hab"
        Me.dtp_fecha_hab.Size = New System.Drawing.Size(116, 22)
        Me.dtp_fecha_hab.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(516, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Fecha de Disposición"
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(646, 38)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(77, 23)
        Me.btn_add.TabIndex = 51
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(730, 38)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(77, 23)
        Me.btn_del.TabIndex = 50
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cantidad"
        '
        'txt_observaciones_hab
        '
        Me.txt_observaciones_hab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observaciones_hab.ForeColor = System.Drawing.Color.Maroon
        Me.txt_observaciones_hab.Location = New System.Drawing.Point(121, 39)
        Me.txt_observaciones_hab.MaxLength = 50
        Me.txt_observaciones_hab.Name = "txt_observaciones_hab"
        Me.txt_observaciones_hab.Size = New System.Drawing.Size(391, 22)
        Me.txt_observaciones_hab.TabIndex = 28
        '
        'txt_cantidad_hab
        '
        Me.txt_cantidad_hab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad_hab.ForeColor = System.Drawing.Color.Maroon
        Me.txt_cantidad_hab.Location = New System.Drawing.Point(9, 39)
        Me.txt_cantidad_hab.Name = "txt_cantidad_hab"
        Me.txt_cantidad_hab.Size = New System.Drawing.Size(106, 22)
        Me.txt_cantidad_hab.TabIndex = 27
        Me.txt_cantidad_hab.Text = "0"
        Me.txt_cantidad_hab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(273, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Observaciones"
        '
        'dgv_detalle_cobro
        '
        Me.dgv_detalle_cobro.AllowUserToAddRows = False
        Me.dgv_detalle_cobro.AllowUserToDeleteRows = False
        Me.dgv_detalle_cobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle_cobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_cobro.Location = New System.Drawing.Point(9, 67)
        Me.dgv_detalle_cobro.Name = "dgv_detalle_cobro"
        Me.dgv_detalle_cobro.Size = New System.Drawing.Size(801, 202)
        Me.dgv_detalle_cobro.TabIndex = 1
        '
        'pnlTipoNumeracion
        '
        Me.pnlTipoNumeracion.BackColor = System.Drawing.Color.Transparent
        Me.pnlTipoNumeracion.Controls.Add(Me.GroupBox4)
        Me.pnlTipoNumeracion.Location = New System.Drawing.Point(568, 405)
        Me.pnlTipoNumeracion.Name = "pnlTipoNumeracion"
        Me.pnlTipoNumeracion.Size = New System.Drawing.Size(265, 96)
        Me.pnlTipoNumeracion.TabIndex = 122
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSalirNumeracion)
        Me.GroupBox4.Controls.Add(Me.btnAceptarNumeracion)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 84)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSalirNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(127, 18)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(108, 58)
        Me.btnSalirNumeracion.TabIndex = 10
        Me.btnSalirNumeracion.Text = "Cancelar Hab."
        Me.btnSalirNumeracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarNumeracion
        '
        Me.btnAceptarNumeracion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptarNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarNumeracion.Image = CType(resources.GetObject("btnAceptarNumeracion.Image"), System.Drawing.Image)
        Me.btnAceptarNumeracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptarNumeracion.Location = New System.Drawing.Point(9, 18)
        Me.btnAceptarNumeracion.Name = "btnAceptarNumeracion"
        Me.btnAceptarNumeracion.Size = New System.Drawing.Size(108, 58)
        Me.btnAceptarNumeracion.TabIndex = 11
        Me.btnAceptarNumeracion.Text = "Registrar Hab."
        Me.btnAceptarNumeracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptarNumeracion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(11, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 26)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Producto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(11, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 26)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Cantidad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_producto
        '
        Me.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_producto.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_producto.ForeColor = System.Drawing.Color.Maroon
        Me.txt_producto.Location = New System.Drawing.Point(105, 46)
        Me.txt_producto.MaxLength = 50
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(728, 29)
        Me.txt_producto.TabIndex = 128
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cantidad.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Maroon
        Me.txt_Cantidad.Location = New System.Drawing.Point(105, 83)
        Me.txt_Cantidad.MaxLength = 50
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(728, 29)
        Me.txt_Cantidad.TabIndex = 129
        '
        'FrmFacturacionRapida_Despachos_Hab_facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 514)
        Me.Controls.Add(Me.txt_Cantidad)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_texto_comprobante)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlTipoNumeracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacturacionRapida_Despachos_Hab_facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Habilitar para Facturar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_detalle_cobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipoNumeracion.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_texto_comprobante As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cantidad_total_hab As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad_total As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_hab As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones_hab As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad_hab As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle_cobro As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTipoNumeracion As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalirNumeracion As System.Windows.Forms.Button
    Friend WithEvents btnAceptarNumeracion As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
End Class
