<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierresModulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierresModulos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_refrescar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_transacciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num_anio = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.gbCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.chk_caja_chica = New System.Windows.Forms.CheckBox()
        Me.chk_activo_fijo = New System.Windows.Forms.CheckBox()
        Me.chk_recursos_humanos = New System.Windows.Forms.CheckBox()
        Me.chk_manufactura = New System.Windows.Forms.CheckBox()
        Me.chk_cajabancos = New System.Windows.Forms.CheckBox()
        Me.chk_contabilidad = New System.Windows.Forms.CheckBox()
        Me.chk_clientes = New System.Windows.Forms.CheckBox()
        Me.chk_almacenes = New System.Windows.Forms.CheckBox()
        Me.chk_proveedores = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.num_anio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.gbCaracteristicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_grabar, Me.btn_eliminar, Me.btn_refrescar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 204
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(139, 22)
        Me.btn_Editar.Text = "&Consultar/Modificar"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_refrescar
        '
        Me.btn_refrescar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_refrescar.Image = CType(resources.GetObject("btn_refrescar.Image"), System.Drawing.Image)
        Me.btn_refrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_refrescar.Name = "btn_refrescar"
        Me.btn_refrescar.Size = New System.Drawing.Size(82, 22)
        Me.btn_refrescar.Text = "&Refrescar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton8.Text = "&Salir"
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 35)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(608, 353)
        Me.tc_tipos.TabIndex = 203
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_transacciones)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Transacciones"
        '
        'dgv_transacciones
        '
        Me.dgv_transacciones.AllowUserToAddRows = False
        Me.dgv_transacciones.AllowUserToDeleteRows = False
        Me.dgv_transacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transacciones.Location = New System.Drawing.Point(21, 58)
        Me.dgv_transacciones.Name = "dgv_transacciones"
        Me.dgv_transacciones.ReadOnly = True
        Me.dgv_transacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_transacciones.Size = New System.Drawing.Size(555, 243)
        Me.dgv_transacciones.TabIndex = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.num_anio)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(21, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 45)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Año"
        '
        'num_anio
        '
        Me.num_anio.Location = New System.Drawing.Point(61, 17)
        Me.num_anio.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.num_anio.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.num_anio.Name = "num_anio"
        Me.num_anio.Size = New System.Drawing.Size(100, 20)
        Me.num_anio.TabIndex = 0
        Me.num_anio.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(22, 304)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 123
        Me.lblCantidad.Text = "."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(495, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.Label4)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.dtp_fecha)
        Me.gb_data.Controls.Add(Me.gbCaracteristicas)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(489, 321)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(331, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Modulo sin marcar = ABIERTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(331, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Modulo marcado = CERRADO"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CustomFormat = "    MMMM/yyyy"
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha.Location = New System.Drawing.Point(15, 35)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(139, 20)
        Me.dtp_fecha.TabIndex = 18
        '
        'gbCaracteristicas
        '
        Me.gbCaracteristicas.Controls.Add(Me.chk_caja_chica)
        Me.gbCaracteristicas.Controls.Add(Me.chk_activo_fijo)
        Me.gbCaracteristicas.Controls.Add(Me.chk_recursos_humanos)
        Me.gbCaracteristicas.Controls.Add(Me.chk_manufactura)
        Me.gbCaracteristicas.Controls.Add(Me.chk_cajabancos)
        Me.gbCaracteristicas.Controls.Add(Me.chk_contabilidad)
        Me.gbCaracteristicas.Controls.Add(Me.chk_clientes)
        Me.gbCaracteristicas.Controls.Add(Me.chk_almacenes)
        Me.gbCaracteristicas.Controls.Add(Me.chk_proveedores)
        Me.gbCaracteristicas.ForeColor = System.Drawing.Color.Navy
        Me.gbCaracteristicas.Location = New System.Drawing.Point(6, 69)
        Me.gbCaracteristicas.Name = "gbCaracteristicas"
        Me.gbCaracteristicas.Size = New System.Drawing.Size(477, 240)
        Me.gbCaracteristicas.TabIndex = 17
        Me.gbCaracteristicas.TabStop = False
        Me.gbCaracteristicas.Text = "Modulos"
        '
        'chk_caja_chica
        '
        Me.chk_caja_chica.AutoSize = True
        Me.chk_caja_chica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_caja_chica.ForeColor = System.Drawing.Color.Navy
        Me.chk_caja_chica.Location = New System.Drawing.Point(167, 98)
        Me.chk_caja_chica.Name = "chk_caja_chica"
        Me.chk_caja_chica.Size = New System.Drawing.Size(77, 17)
        Me.chk_caja_chica.TabIndex = 32
        Me.chk_caja_chica.Text = "Caja Chica"
        Me.chk_caja_chica.UseVisualStyleBackColor = True
        '
        'chk_activo_fijo
        '
        Me.chk_activo_fijo.AutoSize = True
        Me.chk_activo_fijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_activo_fijo.ForeColor = System.Drawing.Color.Navy
        Me.chk_activo_fijo.Location = New System.Drawing.Point(167, 71)
        Me.chk_activo_fijo.Name = "chk_activo_fijo"
        Me.chk_activo_fijo.Size = New System.Drawing.Size(75, 17)
        Me.chk_activo_fijo.TabIndex = 31
        Me.chk_activo_fijo.Text = "Activo Fijo"
        Me.chk_activo_fijo.UseVisualStyleBackColor = True
        '
        'chk_recursos_humanos
        '
        Me.chk_recursos_humanos.AutoSize = True
        Me.chk_recursos_humanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_recursos_humanos.ForeColor = System.Drawing.Color.Navy
        Me.chk_recursos_humanos.Location = New System.Drawing.Point(167, 45)
        Me.chk_recursos_humanos.Name = "chk_recursos_humanos"
        Me.chk_recursos_humanos.Size = New System.Drawing.Size(119, 17)
        Me.chk_recursos_humanos.TabIndex = 30
        Me.chk_recursos_humanos.Text = "Recursos Humanos"
        Me.chk_recursos_humanos.UseVisualStyleBackColor = True
        '
        'chk_manufactura
        '
        Me.chk_manufactura.AutoSize = True
        Me.chk_manufactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_manufactura.ForeColor = System.Drawing.Color.Navy
        Me.chk_manufactura.Location = New System.Drawing.Point(9, 124)
        Me.chk_manufactura.Name = "chk_manufactura"
        Me.chk_manufactura.Size = New System.Drawing.Size(86, 17)
        Me.chk_manufactura.TabIndex = 27
        Me.chk_manufactura.Text = "Manufactura"
        Me.chk_manufactura.UseVisualStyleBackColor = True
        '
        'chk_cajabancos
        '
        Me.chk_cajabancos.AutoSize = True
        Me.chk_cajabancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_cajabancos.ForeColor = System.Drawing.Color.Navy
        Me.chk_cajabancos.Location = New System.Drawing.Point(9, 98)
        Me.chk_cajabancos.Name = "chk_cajabancos"
        Me.chk_cajabancos.Size = New System.Drawing.Size(94, 17)
        Me.chk_cajabancos.TabIndex = 25
        Me.chk_cajabancos.Text = "Caja y Bancos"
        Me.chk_cajabancos.UseVisualStyleBackColor = True
        '
        'chk_contabilidad
        '
        Me.chk_contabilidad.AutoSize = True
        Me.chk_contabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_contabilidad.ForeColor = System.Drawing.Color.Navy
        Me.chk_contabilidad.Location = New System.Drawing.Point(167, 19)
        Me.chk_contabilidad.Name = "chk_contabilidad"
        Me.chk_contabilidad.Size = New System.Drawing.Size(84, 17)
        Me.chk_contabilidad.TabIndex = 24
        Me.chk_contabilidad.Text = "Contabilidad"
        Me.chk_contabilidad.UseVisualStyleBackColor = True
        '
        'chk_clientes
        '
        Me.chk_clientes.AutoSize = True
        Me.chk_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_clientes.ForeColor = System.Drawing.Color.Navy
        Me.chk_clientes.Location = New System.Drawing.Point(9, 71)
        Me.chk_clientes.Name = "chk_clientes"
        Me.chk_clientes.Size = New System.Drawing.Size(63, 17)
        Me.chk_clientes.TabIndex = 15
        Me.chk_clientes.Text = "Clientes"
        Me.chk_clientes.UseVisualStyleBackColor = True
        '
        'chk_almacenes
        '
        Me.chk_almacenes.AutoSize = True
        Me.chk_almacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_almacenes.ForeColor = System.Drawing.Color.Navy
        Me.chk_almacenes.Location = New System.Drawing.Point(9, 45)
        Me.chk_almacenes.Name = "chk_almacenes"
        Me.chk_almacenes.Size = New System.Drawing.Size(78, 17)
        Me.chk_almacenes.TabIndex = 14
        Me.chk_almacenes.Text = "Almacenes"
        Me.chk_almacenes.UseVisualStyleBackColor = True
        '
        'chk_proveedores
        '
        Me.chk_proveedores.AutoSize = True
        Me.chk_proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_proveedores.ForeColor = System.Drawing.Color.Navy
        Me.chk_proveedores.Location = New System.Drawing.Point(9, 19)
        Me.chk_proveedores.Name = "chk_proveedores"
        Me.chk_proveedores.Size = New System.Drawing.Size(86, 17)
        Me.chk_proveedores.TabIndex = 13
        Me.chk_proveedores.Text = "Proveedores"
        Me.chk_proveedores.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tipo de Transaccion"
        '
        'FrmCierresModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 390)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCierresModulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre de Modulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.num_anio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        Me.gbCaracteristicas.ResumeLayout(False)
        Me.gbCaracteristicas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_transacciones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents gbCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chk_recursos_humanos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_manufactura As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cajabancos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_contabilidad As System.Windows.Forms.CheckBox
    Friend WithEvents chk_clientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_almacenes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_proveedores As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents num_anio As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_caja_chica As System.Windows.Forms.CheckBox
    Friend WithEvents chk_activo_fijo As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_refrescar As System.Windows.Forms.ToolStripButton
End Class
