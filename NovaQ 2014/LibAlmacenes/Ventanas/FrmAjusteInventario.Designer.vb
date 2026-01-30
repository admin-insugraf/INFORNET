<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjusteInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjusteInventario))
        Me.gbCabecera = New System.Windows.Forms.GroupBox()
        Me.txtCodigoInventario = New System.Windows.Forms.TextBox()
        Me.gbDetalleArticulo = New System.Windows.Forms.GroupBox()
        Me.cbopart_Type = New System.Windows.Forms.ComboBox()
        Me.txtDescripcionArticulofinal = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.cboLine = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.checkArticulo = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtdescripcionArticuloInicial = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cboFamily = New System.Windows.Forms.ComboBox()
        Me.txtFinArticulo = New System.Windows.Forms.TextBox()
        Me.txtinicioArticulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CboAlmacen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.gbIngresomanual = New System.Windows.Forms.GroupBox()
        Me.cbo_almacen_adicional = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txtcantidadLote = New System.Windows.Forms.TextBox()
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtcantidadConteo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvdetalle = New System.Windows.Forms.DataGridView()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlGenerarAjuste = New System.Windows.Forms.Panel()
        Me.btn_Salir_Ajuste = New System.Windows.Forms.Button()
        Me.btn_Aceptar_Ajuste = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_almacen_ajuste = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtComentarioAjuste = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaInventario = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_Imprimir_Analisis = New System.Windows.Forms.ToolStripButton()
        Me.btn_ajuste_inventario = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.gbCabecera.SuspendLayout()
        Me.gbDetalleArticulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalle.SuspendLayout()
        Me.gbIngresomanual.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGenerarAjuste.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCabecera
        '
        Me.gbCabecera.Controls.Add(Me.txtCodigoInventario)
        Me.gbCabecera.Controls.Add(Me.gbDetalleArticulo)
        Me.gbCabecera.Controls.Add(Me.Label27)
        Me.gbCabecera.Controls.Add(Me.txtComentarios)
        Me.gbCabecera.Controls.Add(Me.Label1)
        Me.gbCabecera.Controls.Add(Me.dtpFecha)
        Me.gbCabecera.Controls.Add(Me.CboAlmacen)
        Me.gbCabecera.Controls.Add(Me.Label4)
        Me.gbCabecera.Location = New System.Drawing.Point(6, 26)
        Me.gbCabecera.Name = "gbCabecera"
        Me.gbCabecera.Size = New System.Drawing.Size(885, 165)
        Me.gbCabecera.TabIndex = 0
        Me.gbCabecera.TabStop = False
        '
        'txtCodigoInventario
        '
        Me.txtCodigoInventario.Location = New System.Drawing.Point(522, 15)
        Me.txtCodigoInventario.Name = "txtCodigoInventario"
        Me.txtCodigoInventario.Size = New System.Drawing.Size(99, 20)
        Me.txtCodigoInventario.TabIndex = 126
        Me.txtCodigoInventario.Visible = False
        '
        'gbDetalleArticulo
        '
        Me.gbDetalleArticulo.BackColor = System.Drawing.Color.White
        Me.gbDetalleArticulo.Controls.Add(Me.cbopart_Type)
        Me.gbDetalleArticulo.Controls.Add(Me.txtDescripcionArticulofinal)
        Me.gbDetalleArticulo.Controls.Add(Me.btn_ok)
        Me.gbDetalleArticulo.Controls.Add(Me.cboLine)
        Me.gbDetalleArticulo.Controls.Add(Me.ProgressBar1)
        Me.gbDetalleArticulo.Controls.Add(Me.Label19)
        Me.gbDetalleArticulo.Controls.Add(Me.PictureBox2)
        Me.gbDetalleArticulo.Controls.Add(Me.checkArticulo)
        Me.gbDetalleArticulo.Controls.Add(Me.Label18)
        Me.gbDetalleArticulo.Controls.Add(Me.txtdescripcionArticuloInicial)
        Me.gbDetalleArticulo.Controls.Add(Me.Label17)
        Me.gbDetalleArticulo.Controls.Add(Me.PictureBox3)
        Me.gbDetalleArticulo.Controls.Add(Me.cboFamily)
        Me.gbDetalleArticulo.Controls.Add(Me.txtFinArticulo)
        Me.gbDetalleArticulo.Controls.Add(Me.txtinicioArticulo)
        Me.gbDetalleArticulo.Controls.Add(Me.Label6)
        Me.gbDetalleArticulo.Controls.Add(Me.Label7)
        Me.gbDetalleArticulo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbDetalleArticulo.ForeColor = System.Drawing.Color.Navy
        Me.gbDetalleArticulo.Location = New System.Drawing.Point(21, 93)
        Me.gbDetalleArticulo.Name = "gbDetalleArticulo"
        Me.gbDetalleArticulo.Size = New System.Drawing.Size(858, 60)
        Me.gbDetalleArticulo.TabIndex = 45
        Me.gbDetalleArticulo.TabStop = False
        '
        'cbopart_Type
        '
        Me.cbopart_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopart_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbopart_Type.FormattingEnabled = True
        Me.cbopart_Type.Location = New System.Drawing.Point(43, 14)
        Me.cbopart_Type.Name = "cbopart_Type"
        Me.cbopart_Type.Size = New System.Drawing.Size(197, 21)
        Me.cbopart_Type.TabIndex = 51
        '
        'txtDescripcionArticulofinal
        '
        Me.txtDescripcionArticulofinal.BackColor = System.Drawing.Color.White
        Me.txtDescripcionArticulofinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionArticulofinal.Location = New System.Drawing.Point(561, 120)
        Me.txtDescripcionArticulofinal.Name = "txtDescripcionArticulofinal"
        Me.txtDescripcionArticulofinal.ReadOnly = True
        Me.txtDescripcionArticulofinal.Size = New System.Drawing.Size(230, 24)
        Me.txtDescripcionArticulofinal.TabIndex = 127
        Me.txtDescripcionArticulofinal.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(734, 14)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(42, 38)
        Me.btn_ok.TabIndex = 125
        Me.btn_ok.Text = " "
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'cboLine
        '
        Me.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboLine.FormattingEnabled = True
        Me.cboLine.Location = New System.Drawing.Point(531, 14)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.Size = New System.Drawing.Size(197, 21)
        Me.cboLine.TabIndex = 54
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 39)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(718, 13)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(494, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Linea"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(537, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'checkArticulo
        '
        Me.checkArticulo.AutoSize = True
        Me.checkArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkArticulo.Location = New System.Drawing.Point(797, 39)
        Me.checkArticulo.Name = "checkArticulo"
        Me.checkArticulo.Size = New System.Drawing.Size(115, 17)
        Me.checkArticulo.TabIndex = 5
        Me.checkArticulo.Text = "Todos los Articulos"
        Me.checkArticulo.UseVisualStyleBackColor = True
        Me.checkArticulo.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(247, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Familia"
        '
        'txtdescripcionArticuloInicial
        '
        Me.txtdescripcionArticuloInicial.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticuloInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticuloInicial.Location = New System.Drawing.Point(167, 119)
        Me.txtdescripcionArticuloInicial.Name = "txtdescripcionArticuloInicial"
        Me.txtdescripcionArticuloInicial.ReadOnly = True
        Me.txtdescripcionArticuloInicial.Size = New System.Drawing.Size(230, 24)
        Me.txtdescripcionArticuloInicial.TabIndex = 123
        Me.txtdescripcionArticuloInicial.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(11, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Tipo"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(142, 122)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 124
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'cboFamily
        '
        Me.cboFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboFamily.FormattingEnabled = True
        Me.cboFamily.Location = New System.Drawing.Point(291, 14)
        Me.cboFamily.Name = "cboFamily"
        Me.cboFamily.Size = New System.Drawing.Size(197, 21)
        Me.cboFamily.TabIndex = 52
        '
        'txtFinArticulo
        '
        Me.txtFinArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFinArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinArticulo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtFinArticulo.Location = New System.Drawing.Point(478, 121)
        Me.txtFinArticulo.Name = "txtFinArticulo"
        Me.txtFinArticulo.ReadOnly = True
        Me.txtFinArticulo.Size = New System.Drawing.Size(55, 22)
        Me.txtFinArticulo.TabIndex = 126
        Me.txtFinArticulo.Visible = False
        '
        'txtinicioArticulo
        '
        Me.txtinicioArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtinicioArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinicioArticulo.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtinicioArticulo.Location = New System.Drawing.Point(82, 120)
        Me.txtinicioArticulo.Name = "txtinicioArticulo"
        Me.txtinicioArticulo.ReadOnly = True
        Me.txtinicioArticulo.Size = New System.Drawing.Size(55, 22)
        Me.txtinicioArticulo.TabIndex = 122
        Me.txtinicioArticulo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Articulo Inicial"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Articulo Final"
        Me.Label7.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(32, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(243, 13)
        Me.Label27.TabIndex = 124
        Me.Label27.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(32, 53)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(605, 34)
        Me.txtComentarios.TabIndex = 123
        Me.txtComentarios.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(32, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(85, 14)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecha.TabIndex = 25
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.FormattingEnabled = True
        Me.CboAlmacen.Location = New System.Drawing.Point(263, 14)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(246, 21)
        Me.CboAlmacen.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(207, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Almacen "
        '
        'gbDetalle
        '
        Me.gbDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalle.Controls.Add(Me.gbIngresomanual)
        Me.gbDetalle.Controls.Add(Me.GroupBox3)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Location = New System.Drawing.Point(6, 197)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(885, 386)
        Me.gbDetalle.TabIndex = 1
        Me.gbDetalle.TabStop = False
        '
        'gbIngresomanual
        '
        Me.gbIngresomanual.Controls.Add(Me.cbo_almacen_adicional)
        Me.gbIngresomanual.Controls.Add(Me.Label10)
        Me.gbIngresomanual.Controls.Add(Me.txtdescripcionArticulo)
        Me.gbIngresomanual.Controls.Add(Me.txtcantidadLote)
        Me.gbIngresomanual.Controls.Add(Me.btninsertar)
        Me.gbIngresomanual.Controls.Add(Me.btneliminar)
        Me.gbIngresomanual.Controls.Add(Me.Label3)
        Me.gbIngresomanual.Controls.Add(Me.PictureBox4)
        Me.gbIngresomanual.Controls.Add(Me.txtArticulo)
        Me.gbIngresomanual.Controls.Add(Me.Label5)
        Me.gbIngresomanual.Controls.Add(Me.Label2)
        Me.gbIngresomanual.Controls.Add(Me.txtLote)
        Me.gbIngresomanual.Controls.Add(Me.txtcantidadConteo)
        Me.gbIngresomanual.Controls.Add(Me.PictureBox1)
        Me.gbIngresomanual.ForeColor = System.Drawing.Color.Navy
        Me.gbIngresomanual.Location = New System.Drawing.Point(13, 13)
        Me.gbIngresomanual.Name = "gbIngresomanual"
        Me.gbIngresomanual.Size = New System.Drawing.Size(859, 85)
        Me.gbIngresomanual.TabIndex = 133
        Me.gbIngresomanual.TabStop = False
        Me.gbIngresomanual.Text = "&Ingreso Manual"
        '
        'cbo_almacen_adicional
        '
        Me.cbo_almacen_adicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_almacen_adicional.FormattingEnabled = True
        Me.cbo_almacen_adicional.Location = New System.Drawing.Point(88, 13)
        Me.cbo_almacen_adicional.Name = "cbo_almacen_adicional"
        Me.cbo_almacen_adicional.Size = New System.Drawing.Size(245, 21)
        Me.cbo_almacen_adicional.TabIndex = 132
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(31, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Almacen "
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(221, 37)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(382, 20)
        Me.txtdescripcionArticulo.TabIndex = 126
        '
        'txtcantidadLote
        '
        Me.txtcantidadLote.Location = New System.Drawing.Point(627, 59)
        Me.txtcantidadLote.Name = "txtcantidadLote"
        Me.txtcantidadLote.Size = New System.Drawing.Size(19, 20)
        Me.txtcantidadLote.TabIndex = 125
        Me.txtcantidadLote.Visible = False
        '
        'btninsertar
        '
        Me.btninsertar.Image = CType(resources.GetObject("btninsertar.Image"), System.Drawing.Image)
        Me.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertar.Location = New System.Drawing.Point(691, 44)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(74, 31)
        Me.btninsertar.TabIndex = 125
        Me.btninsertar.Text = "&Adicionar"
        Me.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(778, 44)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(74, 31)
        Me.btneliminar.TabIndex = 127
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(40, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Articulo"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(197, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 127
        Me.PictureBox4.TabStop = False
        '
        'txtArticulo
        '
        Me.txtArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArticulo.Location = New System.Drawing.Point(88, 36)
        Me.txtArticulo.MaxLength = 10
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(103, 20)
        Me.txtArticulo.TabIndex = 125
        Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(7, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Cant. (Conteo)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(460, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Lote"
        Me.Label2.Visible = False
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.Aquamarine
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.Location = New System.Drawing.Point(494, 58)
        Me.txtLote.MaxLength = 10
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(103, 20)
        Me.txtLote.TabIndex = 129
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLote.Visible = False
        '
        'txtcantidadConteo
        '
        Me.txtcantidadConteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidadConteo.Location = New System.Drawing.Point(88, 59)
        Me.txtcantidadConteo.Name = "txtcantidadConteo"
        Me.txtcantidadConteo.Size = New System.Drawing.Size(103, 20)
        Me.txtcantidadConteo.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(602, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgvdetalle)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(860, 272)
        Me.GroupBox3.TabIndex = 132
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Detalles"
        '
        'dgvdetalle
        '
        Me.dgvdetalle.AllowUserToAddRows = False
        Me.dgvdetalle.AllowUserToDeleteRows = False
        Me.dgvdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalle.Location = New System.Drawing.Point(19, 19)
        Me.dgvdetalle.Name = "dgvdetalle"
        Me.dgvdetalle.Size = New System.Drawing.Size(834, 240)
        Me.dgvdetalle.TabIndex = 0
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(11, 32)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(909, 555)
        Me.pnlcabecera.TabIndex = 44
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(11, 13)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(887, 527)
        Me.dgvCabecera.TabIndex = 0
        '
        'pnlGenerarAjuste
        '
        Me.pnlGenerarAjuste.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlGenerarAjuste.Controls.Add(Me.btn_Salir_Ajuste)
        Me.pnlGenerarAjuste.Controls.Add(Me.btn_Aceptar_Ajuste)
        Me.pnlGenerarAjuste.Controls.Add(Me.GroupBox1)
        Me.pnlGenerarAjuste.Location = New System.Drawing.Point(266, 160)
        Me.pnlGenerarAjuste.Name = "pnlGenerarAjuste"
        Me.pnlGenerarAjuste.Size = New System.Drawing.Size(357, 234)
        Me.pnlGenerarAjuste.TabIndex = 48
        Me.pnlGenerarAjuste.Visible = False
        '
        'btn_Salir_Ajuste
        '
        Me.btn_Salir_Ajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir_Ajuste.ForeColor = System.Drawing.Color.Navy
        Me.btn_Salir_Ajuste.Image = CType(resources.GetObject("btn_Salir_Ajuste.Image"), System.Drawing.Image)
        Me.btn_Salir_Ajuste.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Salir_Ajuste.Location = New System.Drawing.Point(182, 182)
        Me.btn_Salir_Ajuste.Name = "btn_Salir_Ajuste"
        Me.btn_Salir_Ajuste.Size = New System.Drawing.Size(59, 45)
        Me.btn_Salir_Ajuste.TabIndex = 123
        Me.btn_Salir_Ajuste.Text = "Cancelar"
        Me.btn_Salir_Ajuste.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Salir_Ajuste.UseVisualStyleBackColor = True
        '
        'btn_Aceptar_Ajuste
        '
        Me.btn_Aceptar_Ajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar_Ajuste.ForeColor = System.Drawing.Color.Navy
        Me.btn_Aceptar_Ajuste.Image = CType(resources.GetObject("btn_Aceptar_Ajuste.Image"), System.Drawing.Image)
        Me.btn_Aceptar_Ajuste.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Aceptar_Ajuste.Location = New System.Drawing.Point(118, 182)
        Me.btn_Aceptar_Ajuste.Name = "btn_Aceptar_Ajuste"
        Me.btn_Aceptar_Ajuste.Size = New System.Drawing.Size(61, 45)
        Me.btn_Aceptar_Ajuste.TabIndex = 124
        Me.btn_Aceptar_Ajuste.Text = "Confirmar"
        Me.btn_Aceptar_Ajuste.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Aceptar_Ajuste.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_almacen_ajuste)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtComentarioAjuste)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInventario)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(19, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 158)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del Ajuste de  Inventario"
        '
        'cbo_almacen_ajuste
        '
        Me.cbo_almacen_ajuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_almacen_ajuste.FormattingEnabled = True
        Me.cbo_almacen_ajuste.Location = New System.Drawing.Point(97, 26)
        Me.cbo_almacen_ajuste.Name = "cbo_almacen_ajuste"
        Me.cbo_almacen_ajuste.Size = New System.Drawing.Size(194, 21)
        Me.cbo_almacen_ajuste.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(41, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "Almacen "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 13)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Datos Adicionales / Observaciones / Comentarios"
        '
        'txtComentarioAjuste
        '
        Me.txtComentarioAjuste.BackColor = System.Drawing.Color.White
        Me.txtComentarioAjuste.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarioAjuste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarioAjuste.Location = New System.Drawing.Point(6, 104)
        Me.txtComentarioAjuste.Name = "txtComentarioAjuste"
        Me.txtComentarioAjuste.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarioAjuste.Size = New System.Drawing.Size(307, 46)
        Me.txtComentarioAjuste.TabIndex = 127
        Me.txtComentarioAjuste.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Ingrese fecha de Ajuste"
        '
        'dtpFechaInventario
        '
        Me.dtpFechaInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInventario.Location = New System.Drawing.Point(156, 55)
        Me.dtpFechaInventario.Name = "dtpFechaInventario"
        Me.dtpFechaInventario.Size = New System.Drawing.Size(135, 20)
        Me.dtpFechaInventario.TabIndex = 27
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btnImprimir, Me.btn_Imprimir_Analisis, Me.btn_ajuste_inventario, Me.btn_cancelar, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(932, 25)
        Me.ToolStrip1.TabIndex = 181
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_nuevo.Text = "&Nuevo"
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
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(168, 22)
        Me.btnImprimir.Text = "&Imprimir Plantilla Conteo"
        '
        'btn_Imprimir_Analisis
        '
        Me.btn_Imprimir_Analisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Imprimir_Analisis.Image = CType(resources.GetObject("btn_Imprimir_Analisis.Image"), System.Drawing.Image)
        Me.btn_Imprimir_Analisis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Imprimir_Analisis.Name = "btn_Imprimir_Analisis"
        Me.btn_Imprimir_Analisis.Size = New System.Drawing.Size(147, 22)
        Me.btn_Imprimir_Analisis.Text = "&Analisis de Diferencia"
        '
        'btn_ajuste_inventario
        '
        Me.btn_ajuste_inventario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajuste_inventario.Image = CType(resources.GetObject("btn_ajuste_inventario.Image"), System.Drawing.Image)
        Me.btn_ajuste_inventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ajuste_inventario.Name = "btn_ajuste_inventario"
        Me.btn_ajuste_inventario.Size = New System.Drawing.Size(144, 22)
        Me.btn_ajuste_inventario.Text = "&Ajuste de Inventario"
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton3.Text = "&Salir"
        '
        'FrmAjusteInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 597)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlcabecera)
        Me.Controls.Add(Me.pnlGenerarAjuste)
        Me.Controls.Add(Me.gbCabecera)
        Me.Controls.Add(Me.gbDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAjusteInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAjusteInventario"
        Me.gbCabecera.ResumeLayout(False)
        Me.gbCabecera.PerformLayout()
        Me.gbDetalleArticulo.ResumeLayout(False)
        Me.gbDetalleArticulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbIngresomanual.ResumeLayout(False)
        Me.gbIngresomanual.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGenerarAjuste.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcantidadConteo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btninsertar As System.Windows.Forms.Button
    Friend WithEvents dgvdetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtcantidadLote As System.Windows.Forms.TextBox
    Private WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents gbIngresomanual As System.Windows.Forms.GroupBox
    Friend WithEvents gbDetalleArticulo As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionArticulofinal As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents checkArticulo As System.Windows.Forms.CheckBox
    Friend WithEvents txtdescripcionArticuloInicial As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFinArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtinicioArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoInventario As System.Windows.Forms.TextBox
    Friend WithEvents pnlGenerarAjuste As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInventario As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtComentarioAjuste As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Salir_Ajuste As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar_Ajuste As System.Windows.Forms.Button
    Friend WithEvents cbopart_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboFamily As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Imprimir_Analisis As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ajuste_inventario As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbo_almacen_adicional As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_almacen_ajuste As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
