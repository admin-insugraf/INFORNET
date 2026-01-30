<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuiaAnalisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuiaAnalisis))
        Me.gbCabceraDocumento = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdescripciontipoMov = New System.Windows.Forms.TextBox()
        Me.txtcodigotipoMov = New System.Windows.Forms.TextBox()
        Me.txtalmacenDestinodesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclientedesc = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbLeyenda = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproveedordesc = New System.Windows.Forms.TextBox()
        Me.txtCodigoalmacenDestino = New System.Windows.Forms.TextBox()
        Me.txtcentroCosto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtorderFabricacion = New System.Windows.Forms.TextBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox()
        Me.txtcodigoTercero = New System.Windows.Forms.TextBox()
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.txtcodigoProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.cboserieguia = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbCabceraDocumento.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbLeyenda.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCabceraDocumento
        '
        Me.gbCabceraDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox2)
        Me.gbCabceraDocumento.Controls.Add(Me.GroupBox3)
        Me.gbCabceraDocumento.Location = New System.Drawing.Point(9, 24)
        Me.gbCabceraDocumento.Name = "gbCabceraDocumento"
        Me.gbCabceraDocumento.Size = New System.Drawing.Size(1054, 401)
        Me.gbCabceraDocumento.TabIndex = 41
        Me.gbCabceraDocumento.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboserieguia)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtdescripciontipoMov)
        Me.GroupBox2.Controls.Add(Me.txtcodigotipoMov)
        Me.GroupBox2.Controls.Add(Me.txtalmacenDestinodesc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtclientedesc)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.gbLeyenda)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtproveedordesc)
        Me.GroupBox2.Controls.Add(Me.txtCodigoalmacenDestino)
        Me.GroupBox2.Controls.Add(Me.txtcentroCosto)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtComentarios)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtorderFabricacion)
        Me.GroupBox2.Controls.Add(Me.txtNumeroReferencia)
        Me.GroupBox2.Controls.Add(Me.txtcodigoTercero)
        Me.GroupBox2.Controls.Add(Me.txtTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.txtcodigoProveedor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1040, 193)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'txtdescripciontipoMov
        '
        Me.txtdescripciontipoMov.BackColor = System.Drawing.Color.White
        Me.txtdescripciontipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripciontipoMov.Location = New System.Drawing.Point(146, 29)
        Me.txtdescripciontipoMov.Name = "txtdescripciontipoMov"
        Me.txtdescripciontipoMov.Size = New System.Drawing.Size(193, 20)
        Me.txtdescripciontipoMov.TabIndex = 113
        Me.txtdescripciontipoMov.Tag = ""
        '
        'txtcodigotipoMov
        '
        Me.txtcodigotipoMov.BackColor = System.Drawing.Color.White
        Me.txtcodigotipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigotipoMov.Location = New System.Drawing.Point(112, 29)
        Me.txtcodigotipoMov.Name = "txtcodigotipoMov"
        Me.txtcodigotipoMov.Size = New System.Drawing.Size(28, 20)
        Me.txtcodigotipoMov.TabIndex = 112
        Me.txtcodigotipoMov.Tag = ""
        '
        'txtalmacenDestinodesc
        '
        Me.txtalmacenDestinodesc.BackColor = System.Drawing.Color.White
        Me.txtalmacenDestinodesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalmacenDestinodesc.Location = New System.Drawing.Point(572, 68)
        Me.txtalmacenDestinodesc.Name = "txtalmacenDestinodesc"
        Me.txtalmacenDestinodesc.ReadOnly = True
        Me.txtalmacenDestinodesc.Size = New System.Drawing.Size(151, 20)
        Me.txtalmacenDestinodesc.TabIndex = 114
        Me.txtalmacenDestinodesc.Tag = "Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tipo de Transaccion"
        '
        'txtclientedesc
        '
        Me.txtclientedesc.BackColor = System.Drawing.Color.White
        Me.txtclientedesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclientedesc.Location = New System.Drawing.Point(82, 108)
        Me.txtclientedesc.Name = "txtclientedesc"
        Me.txtclientedesc.ReadOnly = True
        Me.txtclientedesc.Size = New System.Drawing.Size(444, 20)
        Me.txtclientedesc.TabIndex = 113
        Me.txtclientedesc.Tag = "Proveedor"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(5, 28)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'gbLeyenda
        '
        Me.gbLeyenda.Controls.Add(Me.TextBox1)
        Me.gbLeyenda.Controls.Add(Me.Label12)
        Me.gbLeyenda.ForeColor = System.Drawing.Color.Navy
        Me.gbLeyenda.Location = New System.Drawing.Point(868, 152)
        Me.gbLeyenda.Name = "gbLeyenda"
        Me.gbLeyenda.Size = New System.Drawing.Size(161, 30)
        Me.gbLeyenda.TabIndex = 109
        Me.gbLeyenda.TabStop = False
        Me.gbLeyenda.Text = "Leyenda"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(59, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 15)
        Me.TextBox1.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(80, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Ingresar datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha de Guia"
        '
        'txtproveedordesc
        '
        Me.txtproveedordesc.BackColor = System.Drawing.Color.White
        Me.txtproveedordesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedordesc.Location = New System.Drawing.Point(82, 68)
        Me.txtproveedordesc.Name = "txtproveedordesc"
        Me.txtproveedordesc.ReadOnly = True
        Me.txtproveedordesc.Size = New System.Drawing.Size(444, 20)
        Me.txtproveedordesc.TabIndex = 112
        Me.txtproveedordesc.Tag = "Proveedor"
        '
        'txtCodigoalmacenDestino
        '
        Me.txtCodigoalmacenDestino.BackColor = System.Drawing.Color.White
        Me.txtCodigoalmacenDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoalmacenDestino.Location = New System.Drawing.Point(534, 68)
        Me.txtCodigoalmacenDestino.Name = "txtCodigoalmacenDestino"
        Me.txtCodigoalmacenDestino.ReadOnly = True
        Me.txtCodigoalmacenDestino.Size = New System.Drawing.Size(32, 20)
        Me.txtCodigoalmacenDestino.TabIndex = 111
        Me.txtCodigoalmacenDestino.Tag = "Proveedor"
        '
        'txtcentroCosto
        '
        Me.txtcentroCosto.BackColor = System.Drawing.Color.White
        Me.txtcentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcentroCosto.Location = New System.Drawing.Point(534, 29)
        Me.txtcentroCosto.Name = "txtcentroCosto"
        Me.txtcentroCosto.ReadOnly = True
        Me.txtcentroCosto.Size = New System.Drawing.Size(189, 20)
        Me.txtcentroCosto.TabIndex = 110
        Me.txtcentroCosto.Tag = "Proveedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Datos Adicionales:"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.White
        Me.txtComentarios.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtComentarios.Location = New System.Drawing.Point(9, 147)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtComentarios.Size = New System.Drawing.Size(853, 35)
        Me.txtComentarios.TabIndex = 10
        Me.txtComentarios.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(537, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Orden de Fabricacion"
        '
        'txtorderFabricacion
        '
        Me.txtorderFabricacion.BackColor = System.Drawing.Color.White
        Me.txtorderFabricacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtorderFabricacion.Enabled = False
        Me.txtorderFabricacion.Location = New System.Drawing.Point(534, 108)
        Me.txtorderFabricacion.Name = "txtorderFabricacion"
        Me.txtorderFabricacion.Size = New System.Drawing.Size(189, 20)
        Me.txtorderFabricacion.TabIndex = 7
        Me.txtorderFabricacion.Tag = "Orden de Fabricacion"
        Me.txtorderFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.BackColor = System.Drawing.Color.White
        Me.txtNumeroReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroReferencia.Enabled = False
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(418, 29)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroReferencia.TabIndex = 4
        Me.txtNumeroReferencia.Tag = "Numero documento Referencia"
        '
        'txtcodigoTercero
        '
        Me.txtcodigoTercero.BackColor = System.Drawing.Color.White
        Me.txtcodigoTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoTercero.Location = New System.Drawing.Point(9, 108)
        Me.txtcodigoTercero.Name = "txtcodigoTercero"
        Me.txtcodigoTercero.ReadOnly = True
        Me.txtcodigoTercero.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoTercero.TabIndex = 9
        Me.txtcodigoTercero.Tag = "Cliente"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.BackColor = System.Drawing.Color.White
        Me.txtTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDocumento.Location = New System.Drawing.Point(345, 29)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(67, 20)
        Me.txtTipoDocumento.TabIndex = 3
        Me.txtTipoDocumento.Tag = "Tipo documento Referencia"
        Me.txtTipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoProveedor
        '
        Me.txtcodigoProveedor.BackColor = System.Drawing.Color.White
        Me.txtcodigoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoProveedor.Location = New System.Drawing.Point(9, 68)
        Me.txtcodigoProveedor.Name = "txtcodigoProveedor"
        Me.txtcodigoProveedor.ReadOnly = True
        Me.txtcodigoProveedor.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoProveedor.TabIndex = 8
        Me.txtcodigoProveedor.Tag = "Proveedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Centro Costo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(344, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Tip Doc Ref."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Navy
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 52)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(56, 13)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Proveedor"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(431, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Num. Doc Ref."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Navy
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 91)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(39, 13)
        Me.LinkLabel2.TabIndex = 33
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cliente"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(537, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Almacen de Destino"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1040, 187)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(10, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(1018, 168)
        Me.dgvDetalle.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1070, 25)
        Me.ToolStrip1.TabIndex = 192
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripButton1.Text = "&Modificar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 22)
        Me.btnAceptar.Text = "&Guardar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton2.Text = "&Eliminar"
        '
        'cboserieguia
        '
        Me.cboserieguia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboserieguia.FormattingEnabled = True
        Me.cboserieguia.Location = New System.Drawing.Point(729, 28)
        Me.cboserieguia.Name = "cboserieguia"
        Me.cboserieguia.Size = New System.Drawing.Size(106, 21)
        Me.cboserieguia.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(726, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Serie Guia de Analisis"
        '
        'frmGuiaAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 432)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbCabceraDocumento)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuiaAnalisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Guia de analisis"
        Me.gbCabceraDocumento.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbLeyenda.ResumeLayout(False)
        Me.gbLeyenda.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCabceraDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorderFabricacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoTercero As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodigotipoMov As System.Windows.Forms.TextBox
    Friend WithEvents txtclientedesc As System.Windows.Forms.TextBox
    Friend WithEvents txtproveedordesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoalmacenDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtcentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtalmacenDestinodesc As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtdescripciontipoMov As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboserieguia As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
