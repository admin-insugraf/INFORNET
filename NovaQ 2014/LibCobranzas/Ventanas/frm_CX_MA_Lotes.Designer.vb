<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Lotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Lotes))
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvLotes = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtrs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprotocolo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtacta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtensayo = New System.Windows.Forms.TextBox()
        Me.dtp_fec_ven = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_fec_reg = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAlmacen = New System.Windows.Forms.CheckBox()
        Me.chklstAlmacenes = New System.Windows.Forms.CheckedListBox()
        Me.txt_comentario = New System.Windows.Forms.RichTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.TextBox()
        Me.txt_can = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_des_arti = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tc_tipos.Location = New System.Drawing.Point(12, 30)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(854, 349)
        Me.tc_tipos.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgvLotes)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(846, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Lotes"
        '
        'dgvLotes
        '
        Me.dgvLotes.AllowUserToAddRows = False
        Me.dgvLotes.AllowUserToDeleteRows = False
        Me.dgvLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Location = New System.Drawing.Point(8, 57)
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.ReadOnly = True
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLotes.Size = New System.Drawing.Size(832, 340)
        Me.dgvLotes.TabIndex = 128
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(13, 402)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 127
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(830, 45)
        Me.GroupBox3.TabIndex = 126
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
        Me.txtFiltro.Size = New System.Drawing.Size(817, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(846, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.Label10)
        Me.gb_data.Controls.Add(Me.txtrs)
        Me.gb_data.Controls.Add(Me.Label9)
        Me.gb_data.Controls.Add(Me.txtprotocolo)
        Me.gb_data.Controls.Add(Me.Label8)
        Me.gb_data.Controls.Add(Me.txtacta)
        Me.gb_data.Controls.Add(Me.Label7)
        Me.gb_data.Controls.Add(Me.txtensayo)
        Me.gb_data.Controls.Add(Me.dtp_fec_ven)
        Me.gb_data.Controls.Add(Me.dtp_fec_reg)
        Me.gb_data.Controls.Add(Me.GroupBox1)
        Me.gb_data.Controls.Add(Me.txt_comentario)
        Me.gb_data.Controls.Add(Me.PictureBox4)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label5)
        Me.gb_data.Controls.Add(Me.Label4)
        Me.gb_data.Controls.Add(Me.Label2)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_lote)
        Me.gb_data.Controls.Add(Me.txt_can)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_des_arti)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(840, 317)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(209, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Registro Sanitario"
        '
        'txtrs
        '
        Me.txtrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrs.Location = New System.Drawing.Point(211, 208)
        Me.txtrs.MaxLength = 20
        Me.txtrs.Name = "txtrs"
        Me.txtrs.Size = New System.Drawing.Size(273, 20)
        Me.txtrs.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(210, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "N° Protocolo"
        '
        'txtprotocolo
        '
        Me.txtprotocolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprotocolo.Location = New System.Drawing.Point(212, 161)
        Me.txtprotocolo.MaxLength = 20
        Me.txtprotocolo.Name = "txtprotocolo"
        Me.txtprotocolo.Size = New System.Drawing.Size(273, 20)
        Me.txtprotocolo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(211, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "N° de Acta de muestreo"
        '
        'txtacta
        '
        Me.txtacta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacta.Location = New System.Drawing.Point(213, 118)
        Me.txtacta.MaxLength = 20
        Me.txtacta.Name = "txtacta"
        Me.txtacta.Size = New System.Drawing.Size(273, 20)
        Me.txtacta.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(211, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Informe de Ensayo"
        '
        'txtensayo
        '
        Me.txtensayo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtensayo.Location = New System.Drawing.Point(213, 76)
        Me.txtensayo.MaxLength = 20
        Me.txtensayo.Name = "txtensayo"
        Me.txtensayo.Size = New System.Drawing.Size(273, 20)
        Me.txtensayo.TabIndex = 7
        '
        'dtp_fec_ven
        '
        Me.dtp_fec_ven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtp_fec_ven.Location = New System.Drawing.Point(25, 212)
        Me.dtp_fec_ven.Mask = "00/00/0000"
        Me.dtp_fec_ven.Name = "dtp_fec_ven"
        Me.dtp_fec_ven.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fec_ven.TabIndex = 6
        Me.dtp_fec_ven.ValidatingType = GetType(Date)
        '
        'dtp_fec_reg
        '
        Me.dtp_fec_reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtp_fec_reg.Location = New System.Drawing.Point(25, 164)
        Me.dtp_fec_reg.Mask = "00/00/0000"
        Me.dtp_fec_reg.Name = "dtp_fec_reg"
        Me.dtp_fec_reg.Size = New System.Drawing.Size(95, 20)
        Me.dtp_fec_reg.TabIndex = 5
        Me.dtp_fec_reg.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkAlmacen)
        Me.GroupBox1.Controls.Add(Me.chklstAlmacenes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(503, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 286)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Acceso de los Almacenes"
        '
        'checkAlmacen
        '
        Me.checkAlmacen.AutoSize = True
        Me.checkAlmacen.ForeColor = System.Drawing.Color.Navy
        Me.checkAlmacen.Location = New System.Drawing.Point(232, 1)
        Me.checkAlmacen.Name = "checkAlmacen"
        Me.checkAlmacen.Size = New System.Drawing.Size(92, 17)
        Me.checkAlmacen.TabIndex = 7
        Me.checkAlmacen.Text = "Activar Todos"
        Me.checkAlmacen.UseVisualStyleBackColor = True
        '
        'chklstAlmacenes
        '
        Me.chklstAlmacenes.CheckOnClick = True
        Me.chklstAlmacenes.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chklstAlmacenes.FormattingEnabled = True
        Me.chklstAlmacenes.Location = New System.Drawing.Point(10, 22)
        Me.chklstAlmacenes.Name = "chklstAlmacenes"
        Me.chklstAlmacenes.Size = New System.Drawing.Size(303, 259)
        Me.chklstAlmacenes.TabIndex = 6
        '
        'txt_comentario
        '
        Me.txt_comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comentario.Location = New System.Drawing.Point(25, 254)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(461, 54)
        Me.txt_comentario.TabIndex = 11
        Me.txt_comentario.Text = ""
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(101, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 111
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(24, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cod Articulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(23, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Comentario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(23, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Vencimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Registro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(25, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(24, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lote"
        '
        'txt_lote
        '
        Me.txt_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lote.Location = New System.Drawing.Point(26, 76)
        Me.txt_lote.MaxLength = 20
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(155, 20)
        Me.txt_lote.TabIndex = 3
        '
        'txt_can
        '
        Me.txt_can.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_can.Enabled = False
        Me.txt_can.Location = New System.Drawing.Point(27, 119)
        Me.txt_can.Name = "txt_can"
        Me.txt_can.Size = New System.Drawing.Size(48, 20)
        Me.txt_can.TabIndex = 4
        Me.txt_can.Text = "0"
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(26, 38)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.ReadOnly = True
        Me.txt_cod.Size = New System.Drawing.Size(74, 20)
        Me.txt_cod.TabIndex = 2
        '
        'txt_des_arti
        '
        Me.txt_des_arti.BackColor = System.Drawing.Color.White
        Me.txt_des_arti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_arti.Location = New System.Drawing.Point(121, 38)
        Me.txt_des_arti.Name = "txt_des_arti"
        Me.txt_des_arti.ReadOnly = True
        Me.txt_des_arti.Size = New System.Drawing.Size(365, 20)
        Me.txt_des_arti.TabIndex = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(879, 25)
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
        Me.btn_eliminar.Visible = False
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
        'frm_CX_MA_Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 386)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Lotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes"
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_des_arti As System.Windows.Forms.TextBox
    Friend WithEvents txt_lote As System.Windows.Forms.TextBox
    Friend WithEvents txt_can As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents chklstAlmacenes As System.Windows.Forms.CheckedListBox
    Private WithEvents dtp_fec_ven As System.Windows.Forms.MaskedTextBox
    Private WithEvents dtp_fec_reg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtrs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprotocolo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtacta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtensayo As System.Windows.Forms.TextBox
End Class
