<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_TransaccionTipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_TransaccionTipo))
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_transacciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.gbCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.chkcodarticulo = New System.Windows.Forms.CheckBox()
        Me.chk_lote_F = New System.Windows.Forms.CheckBox()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.cboTipoArticulo = New System.Windows.Forms.ComboBox()
        Me.chk_TipoArticulo = New System.Windows.Forms.CheckBox()
        Me.chk_GuiaAnalisis = New System.Windows.Forms.CheckBox()
        Me.chk_AlmDestino = New System.Windows.Forms.CheckBox()
        Me.chk_Count = New System.Windows.Forms.CheckBox()
        Me.chk_Account = New System.Windows.Forms.CheckBox()
        Me.chk_autorizado = New System.Windows.Forms.CheckBox()
        Me.chk_centrocosto = New System.Windows.Forms.CheckBox()
        Me.chk_ordenprod = New System.Windows.Forms.CheckBox()
        Me.chk_cliente = New System.Windows.Forms.CheckBox()
        Me.chk_almacen = New System.Windows.Forms.CheckBox()
        Me.chk_ordencompra = New System.Windows.Forms.CheckBox()
        Me.chk_comentario = New System.Windows.Forms.CheckBox()
        Me.chk_documento = New System.Windows.Forms.CheckBox()
        Me.chk_prove = New System.Windows.Forms.CheckBox()
        Me.chk_valorizado = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.chk_GuiaRemision = New System.Windows.Forms.CheckBox()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.gbCaracteristicas.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 32)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(503, 365)
        Me.tc_tipos.TabIndex = 26
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
        Me.TabPage1.Size = New System.Drawing.Size(495, 339)
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
        Me.dgv_transacciones.Size = New System.Drawing.Size(450, 255)
        Me.dgv_transacciones.TabIndex = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(21, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 45)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(437, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(22, 316)
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
        Me.TabPage2.Size = New System.Drawing.Size(495, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.gbCaracteristicas)
        Me.gb_data.Controls.Add(Me.cmb_tipo)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(489, 333)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'gbCaracteristicas
        '
        Me.gbCaracteristicas.Controls.Add(Me.chk_GuiaRemision)
        Me.gbCaracteristicas.Controls.Add(Me.chkcodarticulo)
        Me.gbCaracteristicas.Controls.Add(Me.chk_lote_F)
        Me.gbCaracteristicas.Controls.Add(Me.txt_count)
        Me.gbCaracteristicas.Controls.Add(Me.CboAlmacen)
        Me.gbCaracteristicas.Controls.Add(Me.cboTipoArticulo)
        Me.gbCaracteristicas.Controls.Add(Me.chk_TipoArticulo)
        Me.gbCaracteristicas.Controls.Add(Me.chk_GuiaAnalisis)
        Me.gbCaracteristicas.Controls.Add(Me.chk_AlmDestino)
        Me.gbCaracteristicas.Controls.Add(Me.chk_Count)
        Me.gbCaracteristicas.Controls.Add(Me.chk_Account)
        Me.gbCaracteristicas.Controls.Add(Me.chk_autorizado)
        Me.gbCaracteristicas.Controls.Add(Me.chk_centrocosto)
        Me.gbCaracteristicas.Controls.Add(Me.chk_ordenprod)
        Me.gbCaracteristicas.Controls.Add(Me.chk_cliente)
        Me.gbCaracteristicas.Controls.Add(Me.chk_almacen)
        Me.gbCaracteristicas.Controls.Add(Me.chk_ordencompra)
        Me.gbCaracteristicas.Controls.Add(Me.chk_comentario)
        Me.gbCaracteristicas.Controls.Add(Me.chk_documento)
        Me.gbCaracteristicas.Controls.Add(Me.chk_prove)
        Me.gbCaracteristicas.Controls.Add(Me.chk_valorizado)
        Me.gbCaracteristicas.ForeColor = System.Drawing.Color.Navy
        Me.gbCaracteristicas.Location = New System.Drawing.Point(6, 100)
        Me.gbCaracteristicas.Name = "gbCaracteristicas"
        Me.gbCaracteristicas.Size = New System.Drawing.Size(477, 222)
        Me.gbCaracteristicas.TabIndex = 17
        Me.gbCaracteristicas.TabStop = False
        Me.gbCaracteristicas.Text = "&Caracteristicas"
        '
        'chkcodarticulo
        '
        Me.chkcodarticulo.AutoSize = True
        Me.chkcodarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkcodarticulo.ForeColor = System.Drawing.Color.Navy
        Me.chkcodarticulo.Location = New System.Drawing.Point(6, 172)
        Me.chkcodarticulo.Name = "chkcodarticulo"
        Me.chkcodarticulo.Size = New System.Drawing.Size(86, 17)
        Me.chkcodarticulo.TabIndex = 30
        Me.chkcodarticulo.Text = "Cod. Articulo"
        Me.chkcodarticulo.UseVisualStyleBackColor = True
        '
        'chk_lote_F
        '
        Me.chk_lote_F.AutoSize = True
        Me.chk_lote_F.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_lote_F.ForeColor = System.Drawing.Color.Navy
        Me.chk_lote_F.Location = New System.Drawing.Point(340, 71)
        Me.chk_lote_F.Name = "chk_lote_F"
        Me.chk_lote_F.Size = New System.Drawing.Size(97, 17)
        Me.chk_lote_F.TabIndex = 29
        Me.chk_lote_F.Text = "Lote a Fabricar"
        Me.chk_lote_F.UseVisualStyleBackColor = True
        '
        'txt_count
        '
        Me.txt_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_count.Enabled = False
        Me.txt_count.Location = New System.Drawing.Point(117, 147)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(100, 20)
        Me.txt_count.TabIndex = 28
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.Enabled = False
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(116, 98)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(220, 21)
        Me.CboAlmacen.TabIndex = 19
        '
        'cboTipoArticulo
        '
        Me.cboTipoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoArticulo.Enabled = False
        Me.cboTipoArticulo.FormattingEnabled = True
        Me.cboTipoArticulo.Location = New System.Drawing.Point(116, 123)
        Me.cboTipoArticulo.Name = "cboTipoArticulo"
        Me.cboTipoArticulo.Size = New System.Drawing.Size(220, 21)
        Me.cboTipoArticulo.TabIndex = 18
        '
        'chk_TipoArticulo
        '
        Me.chk_TipoArticulo.AutoSize = True
        Me.chk_TipoArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_TipoArticulo.ForeColor = System.Drawing.Color.Navy
        Me.chk_TipoArticulo.Location = New System.Drawing.Point(6, 124)
        Me.chk_TipoArticulo.Name = "chk_TipoArticulo"
        Me.chk_TipoArticulo.Size = New System.Drawing.Size(85, 17)
        Me.chk_TipoArticulo.TabIndex = 27
        Me.chk_TipoArticulo.Text = "Tipo Articulo"
        Me.chk_TipoArticulo.UseVisualStyleBackColor = True
        '
        'chk_GuiaAnalisis
        '
        Me.chk_GuiaAnalisis.AutoSize = True
        Me.chk_GuiaAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_GuiaAnalisis.ForeColor = System.Drawing.Color.Navy
        Me.chk_GuiaAnalisis.Location = New System.Drawing.Point(221, 148)
        Me.chk_GuiaAnalisis.Name = "chk_GuiaAnalisis"
        Me.chk_GuiaAnalisis.Size = New System.Drawing.Size(101, 17)
        Me.chk_GuiaAnalisis.TabIndex = 26
        Me.chk_GuiaAnalisis.Text = "Guia de Analisis"
        Me.chk_GuiaAnalisis.UseVisualStyleBackColor = True
        '
        'chk_AlmDestino
        '
        Me.chk_AlmDestino.AutoSize = True
        Me.chk_AlmDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_AlmDestino.ForeColor = System.Drawing.Color.Navy
        Me.chk_AlmDestino.Location = New System.Drawing.Point(6, 98)
        Me.chk_AlmDestino.Name = "chk_AlmDestino"
        Me.chk_AlmDestino.Size = New System.Drawing.Size(106, 17)
        Me.chk_AlmDestino.TabIndex = 25
        Me.chk_AlmDestino.Text = "Almacen Destino"
        Me.chk_AlmDestino.UseVisualStyleBackColor = True
        '
        'chk_Count
        '
        Me.chk_Count.AutoSize = True
        Me.chk_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_Count.ForeColor = System.Drawing.Color.Navy
        Me.chk_Count.Location = New System.Drawing.Point(6, 149)
        Me.chk_Count.Name = "chk_Count"
        Me.chk_Count.Size = New System.Drawing.Size(76, 17)
        Me.chk_Count.TabIndex = 24
        Me.chk_Count.Text = "Var_Count"
        Me.chk_Count.UseVisualStyleBackColor = True
        '
        'chk_Account
        '
        Me.chk_Account.AutoSize = True
        Me.chk_Account.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_Account.ForeColor = System.Drawing.Color.Navy
        Me.chk_Account.Location = New System.Drawing.Point(340, 45)
        Me.chk_Account.Name = "chk_Account"
        Me.chk_Account.Size = New System.Drawing.Size(80, 17)
        Me.chk_Account.TabIndex = 23
        Me.chk_Account.Text = "Is_Account"
        Me.chk_Account.UseVisualStyleBackColor = True
        '
        'chk_autorizado
        '
        Me.chk_autorizado.AutoSize = True
        Me.chk_autorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_autorizado.ForeColor = System.Drawing.Color.Navy
        Me.chk_autorizado.Location = New System.Drawing.Point(104, 19)
        Me.chk_autorizado.Name = "chk_autorizado"
        Me.chk_autorizado.Size = New System.Drawing.Size(76, 17)
        Me.chk_autorizado.TabIndex = 16
        Me.chk_autorizado.Text = "Autorizado"
        Me.chk_autorizado.UseVisualStyleBackColor = True
        '
        'chk_centrocosto
        '
        Me.chk_centrocosto.AutoSize = True
        Me.chk_centrocosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_centrocosto.ForeColor = System.Drawing.Color.Navy
        Me.chk_centrocosto.Location = New System.Drawing.Point(104, 71)
        Me.chk_centrocosto.Name = "chk_centrocosto"
        Me.chk_centrocosto.Size = New System.Drawing.Size(102, 17)
        Me.chk_centrocosto.TabIndex = 18
        Me.chk_centrocosto.Text = "Centro de Costo"
        Me.chk_centrocosto.UseVisualStyleBackColor = True
        '
        'chk_ordenprod
        '
        Me.chk_ordenprod.AutoSize = True
        Me.chk_ordenprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_ordenprod.ForeColor = System.Drawing.Color.Navy
        Me.chk_ordenprod.Location = New System.Drawing.Point(340, 19)
        Me.chk_ordenprod.Name = "chk_ordenprod"
        Me.chk_ordenprod.Size = New System.Drawing.Size(127, 17)
        Me.chk_ordenprod.TabIndex = 22
        Me.chk_ordenprod.Text = "Orden de Produccion"
        Me.chk_ordenprod.UseVisualStyleBackColor = True
        '
        'chk_cliente
        '
        Me.chk_cliente.AutoSize = True
        Me.chk_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_cliente.ForeColor = System.Drawing.Color.Navy
        Me.chk_cliente.Location = New System.Drawing.Point(104, 45)
        Me.chk_cliente.Name = "chk_cliente"
        Me.chk_cliente.Size = New System.Drawing.Size(58, 17)
        Me.chk_cliente.TabIndex = 17
        Me.chk_cliente.Text = "Cliente"
        Me.chk_cliente.UseVisualStyleBackColor = True
        '
        'chk_almacen
        '
        Me.chk_almacen.AutoSize = True
        Me.chk_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_almacen.ForeColor = System.Drawing.Color.Navy
        Me.chk_almacen.Location = New System.Drawing.Point(221, 71)
        Me.chk_almacen.Name = "chk_almacen"
        Me.chk_almacen.Size = New System.Drawing.Size(67, 17)
        Me.chk_almacen.TabIndex = 21
        Me.chk_almacen.Text = "Almacen"
        Me.chk_almacen.UseVisualStyleBackColor = True
        '
        'chk_ordencompra
        '
        Me.chk_ordencompra.AutoSize = True
        Me.chk_ordencompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_ordencompra.ForeColor = System.Drawing.Color.Navy
        Me.chk_ordencompra.Location = New System.Drawing.Point(221, 19)
        Me.chk_ordencompra.Name = "chk_ordencompra"
        Me.chk_ordencompra.Size = New System.Drawing.Size(109, 17)
        Me.chk_ordencompra.TabIndex = 19
        Me.chk_ordencompra.Text = "Orden de Compra"
        Me.chk_ordencompra.UseVisualStyleBackColor = True
        '
        'chk_comentario
        '
        Me.chk_comentario.AutoSize = True
        Me.chk_comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_comentario.ForeColor = System.Drawing.Color.Navy
        Me.chk_comentario.Location = New System.Drawing.Point(221, 45)
        Me.chk_comentario.Name = "chk_comentario"
        Me.chk_comentario.Size = New System.Drawing.Size(79, 17)
        Me.chk_comentario.TabIndex = 20
        Me.chk_comentario.Text = "Comentario"
        Me.chk_comentario.UseVisualStyleBackColor = True
        '
        'chk_documento
        '
        Me.chk_documento.AutoSize = True
        Me.chk_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_documento.ForeColor = System.Drawing.Color.Navy
        Me.chk_documento.Location = New System.Drawing.Point(6, 71)
        Me.chk_documento.Name = "chk_documento"
        Me.chk_documento.Size = New System.Drawing.Size(81, 17)
        Me.chk_documento.TabIndex = 15
        Me.chk_documento.Text = "Documento"
        Me.chk_documento.UseVisualStyleBackColor = True
        '
        'chk_prove
        '
        Me.chk_prove.AutoSize = True
        Me.chk_prove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_prove.ForeColor = System.Drawing.Color.Navy
        Me.chk_prove.Location = New System.Drawing.Point(6, 45)
        Me.chk_prove.Name = "chk_prove"
        Me.chk_prove.Size = New System.Drawing.Size(75, 17)
        Me.chk_prove.TabIndex = 14
        Me.chk_prove.Text = "Proveedor"
        Me.chk_prove.UseVisualStyleBackColor = True
        '
        'chk_valorizado
        '
        Me.chk_valorizado.AutoSize = True
        Me.chk_valorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_valorizado.ForeColor = System.Drawing.Color.Navy
        Me.chk_valorizado.Location = New System.Drawing.Point(6, 19)
        Me.chk_valorizado.Name = "chk_valorizado"
        Me.chk_valorizado.Size = New System.Drawing.Size(75, 17)
        Me.chk_valorizado.TabIndex = 13
        Me.chk_valorizado.Text = "Valorizado"
        Me.chk_valorizado.UseVisualStyleBackColor = True
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(10, 34)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(152, 21)
        Me.cmb_tipo.TabIndex = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(59, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(10, 74)
        Me.txt_cod.MaxLength = 2
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(43, 20)
        Me.txt_cod.TabIndex = 1
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(57, 74)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(426, 20)
        Me.txt_des.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_grabar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(527, 25)
        Me.ToolStrip1.TabIndex = 202
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
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(81, 22)
        Me.btn_Editar.Text = "&Consultar"
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
        'chk_GuiaRemision
        '
        Me.chk_GuiaRemision.AutoSize = True
        Me.chk_GuiaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_GuiaRemision.ForeColor = System.Drawing.Color.Navy
        Me.chk_GuiaRemision.Location = New System.Drawing.Point(6, 195)
        Me.chk_GuiaRemision.Name = "chk_GuiaRemision"
        Me.chk_GuiaRemision.Size = New System.Drawing.Size(109, 17)
        Me.chk_GuiaRemision.TabIndex = 32
        Me.chk_GuiaRemision.Text = "Guia de Remisión"
        Me.chk_GuiaRemision.UseVisualStyleBackColor = True
        '
        'frm_CX_MA_TransaccionTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 402)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CX_MA_TransaccionTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Transaccion"
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        Me.gbCaracteristicas.ResumeLayout(False)
        Me.gbCaracteristicas.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents dgv_transacciones As System.Windows.Forms.DataGridView
    Friend WithEvents gbCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chk_cliente As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ordenprod As System.Windows.Forms.CheckBox
    Friend WithEvents chk_almacen As System.Windows.Forms.CheckBox
    Friend WithEvents chk_autorizado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_comentario As System.Windows.Forms.CheckBox
    Friend WithEvents chk_documento As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ordencompra As System.Windows.Forms.CheckBox
    Friend WithEvents chk_prove As System.Windows.Forms.CheckBox
    Friend WithEvents chk_centrocosto As System.Windows.Forms.CheckBox
    Friend WithEvents chk_valorizado As System.Windows.Forms.CheckBox
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents chk_TipoArticulo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_GuiaAnalisis As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AlmDestino As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Count As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Account As System.Windows.Forms.CheckBox
    Friend WithEvents txt_count As System.Windows.Forms.TextBox
    Friend WithEvents chk_lote_F As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkcodarticulo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_GuiaRemision As System.Windows.Forms.CheckBox
End Class
