<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoNumeracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoNumeracion))
        Me.pnlTipoNumeracion = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gb_tipo_cambio = New System.Windows.Forms.GroupBox()
        Me.lbltipo_cambio = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gb_resumen_pago = New System.Windows.Forms.GroupBox()
        Me.lblvuelto = New System.Windows.Forms.Label()
        Me.lblfalta_pagar = New System.Windows.Forms.Label()
        Me.lblpagado = New System.Windows.Forms.Label()
        Me.lblmonto_venta = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTOTALT = New System.Windows.Forms.TextBox()
        Me.TXTTOTALE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb_pago_tarjeta = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_num_operacion_american = New System.Windows.Forms.TextBox()
        Me.txt_num_operacion_diners = New System.Windows.Forms.TextBox()
        Me.txt_num_operacion_master = New System.Windows.Forms.TextBox()
        Me.txt_num_operacion_visa = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AMOUNT_AMERICAN_EXPRES = New System.Windows.Forms.TextBox()
        Me.AMOUNT_DINERS = New System.Windows.Forms.TextBox()
        Me.AMOUNT_CARD_MASTER = New System.Windows.Forms.TextBox()
        Me.AMOUNT_CARD_VISA = New System.Windows.Forms.TextBox()
        Me.gb_pago_efectivo = New System.Windows.Forms.GroupBox()
        Me.TxEfeDol = New System.Windows.Forms.TextBox()
        Me.TxEfeSol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdb_credito = New System.Windows.Forms.RadioButton()
        Me.rdb_contado = New System.Windows.Forms.RadioButton()
        Me.txtNumeracionManual = New System.Windows.Forms.TextBox()
        Me.btnSalirNumeracion = New System.Windows.Forms.Button()
        Me.btnAceptarNumeracion = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbAutomatica = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.gb_modo_pago = New System.Windows.Forms.GroupBox()
        Me.txt_cod_modo_pago = New System.Windows.Forms.TextBox()
        Me.txt_des_modo_pago = New System.Windows.Forms.TextBox()
        Me.pnlTipoNumeracion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gb_tipo_cambio.SuspendLayout()
        Me.gb_resumen_pago.SuspendLayout()
        Me.gb_pago_tarjeta.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_pago_efectivo.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gb_modo_pago.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTipoNumeracion
        '
        Me.pnlTipoNumeracion.BackColor = System.Drawing.Color.Transparent
        Me.pnlTipoNumeracion.Controls.Add(Me.GroupBox4)
        Me.pnlTipoNumeracion.Controls.Add(Me.txtTitulo)
        Me.pnlTipoNumeracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTipoNumeracion.Location = New System.Drawing.Point(0, 0)
        Me.pnlTipoNumeracion.Name = "pnlTipoNumeracion"
        Me.pnlTipoNumeracion.Size = New System.Drawing.Size(835, 499)
        Me.pnlTipoNumeracion.TabIndex = 111
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gb_modo_pago)
        Me.GroupBox4.Controls.Add(Me.gb_tipo_cambio)
        Me.GroupBox4.Controls.Add(Me.gb_resumen_pago)
        Me.GroupBox4.Controls.Add(Me.gb_pago_tarjeta)
        Me.GroupBox4.Controls.Add(Me.gb_pago_efectivo)
        Me.GroupBox4.Controls.Add(Me.rdb_credito)
        Me.GroupBox4.Controls.Add(Me.rdb_contado)
        Me.GroupBox4.Controls.Add(Me.txtNumeracionManual)
        Me.GroupBox4.Controls.Add(Me.btnSalirNumeracion)
        Me.GroupBox4.Controls.Add(Me.btnAceptarNumeracion)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(813, 479)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'gb_tipo_cambio
        '
        Me.gb_tipo_cambio.Controls.Add(Me.lbltipo_cambio)
        Me.gb_tipo_cambio.Controls.Add(Me.Label11)
        Me.gb_tipo_cambio.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tipo_cambio.ForeColor = System.Drawing.Color.Green
        Me.gb_tipo_cambio.Location = New System.Drawing.Point(442, 329)
        Me.gb_tipo_cambio.Name = "gb_tipo_cambio"
        Me.gb_tipo_cambio.Size = New System.Drawing.Size(354, 77)
        Me.gb_tipo_cambio.TabIndex = 117
        Me.gb_tipo_cambio.TabStop = False
        Me.gb_tipo_cambio.Text = "Tipo de Cambio"
        '
        'lbltipo_cambio
        '
        Me.lbltipo_cambio.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo_cambio.ForeColor = System.Drawing.Color.Red
        Me.lbltipo_cambio.Location = New System.Drawing.Point(206, 35)
        Me.lbltipo_cambio.Name = "lbltipo_cambio"
        Me.lbltipo_cambio.Size = New System.Drawing.Size(140, 26)
        Me.lbltipo_cambio.TabIndex = 1
        Me.lbltipo_cambio.Text = "Venta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 26)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Venta"
        '
        'gb_resumen_pago
        '
        Me.gb_resumen_pago.Controls.Add(Me.lblvuelto)
        Me.gb_resumen_pago.Controls.Add(Me.lblfalta_pagar)
        Me.gb_resumen_pago.Controls.Add(Me.lblpagado)
        Me.gb_resumen_pago.Controls.Add(Me.lblmonto_venta)
        Me.gb_resumen_pago.Controls.Add(Me.Label9)
        Me.gb_resumen_pago.Controls.Add(Me.Label8)
        Me.gb_resumen_pago.Controls.Add(Me.Label7)
        Me.gb_resumen_pago.Controls.Add(Me.Label6)
        Me.gb_resumen_pago.Controls.Add(Me.Label5)
        Me.gb_resumen_pago.Controls.Add(Me.TXTTOTALT)
        Me.gb_resumen_pago.Controls.Add(Me.TXTTOTALE)
        Me.gb_resumen_pago.Controls.Add(Me.Label3)
        Me.gb_resumen_pago.Controls.Add(Me.Label4)
        Me.gb_resumen_pago.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_resumen_pago.ForeColor = System.Drawing.Color.Green
        Me.gb_resumen_pago.Location = New System.Drawing.Point(442, 23)
        Me.gb_resumen_pago.Name = "gb_resumen_pago"
        Me.gb_resumen_pago.Size = New System.Drawing.Size(354, 302)
        Me.gb_resumen_pago.TabIndex = 116
        Me.gb_resumen_pago.TabStop = False
        Me.gb_resumen_pago.Text = "Resumen de Pago (Moneda Nacional)"
        '
        'lblvuelto
        '
        Me.lblvuelto.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.ForeColor = System.Drawing.Color.Orange
        Me.lblvuelto.Location = New System.Drawing.Point(201, 262)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(145, 26)
        Me.lblvuelto.TabIndex = 12
        Me.lblvuelto.Text = "0"
        Me.lblvuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfalta_pagar
        '
        Me.lblfalta_pagar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfalta_pagar.ForeColor = System.Drawing.Color.Orange
        Me.lblfalta_pagar.Location = New System.Drawing.Point(201, 206)
        Me.lblfalta_pagar.Name = "lblfalta_pagar"
        Me.lblfalta_pagar.Size = New System.Drawing.Size(145, 26)
        Me.lblfalta_pagar.TabIndex = 11
        Me.lblfalta_pagar.Text = "Falta Pagar"
        Me.lblfalta_pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpagado
        '
        Me.lblpagado.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagado.ForeColor = System.Drawing.Color.Lime
        Me.lblpagado.Location = New System.Drawing.Point(201, 171)
        Me.lblpagado.Name = "lblpagado"
        Me.lblpagado.Size = New System.Drawing.Size(145, 26)
        Me.lblpagado.TabIndex = 10
        Me.lblpagado.Text = "Pagado"
        Me.lblpagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblmonto_venta
        '
        Me.lblmonto_venta.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto_venta.ForeColor = System.Drawing.Color.Red
        Me.lblmonto_venta.Location = New System.Drawing.Point(201, 134)
        Me.lblmonto_venta.Name = "lblmonto_venta"
        Me.lblmonto_venta.Size = New System.Drawing.Size(145, 26)
        Me.lblmonto_venta.TabIndex = 9
        Me.lblmonto_venta.Text = "Monto Venta"
        Me.lblmonto_venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Vuelto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 26)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Falta Pagar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pagado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Monto Venta"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(331, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "---------------------------------------------"
        '
        'TXTTOTALT
        '
        Me.TXTTOTALT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTOTALT.ForeColor = System.Drawing.Color.Maroon
        Me.TXTTOTALT.Location = New System.Drawing.Point(206, 70)
        Me.TXTTOTALT.Name = "TXTTOTALT"
        Me.TXTTOTALT.Size = New System.Drawing.Size(135, 29)
        Me.TXTTOTALT.TabIndex = 3
        Me.TXTTOTALT.Text = "0"
        Me.TXTTOTALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTOTALE
        '
        Me.TXTTOTALE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTOTALE.ForeColor = System.Drawing.Color.Maroon
        Me.TXTTOTALE.Location = New System.Drawing.Point(206, 32)
        Me.TXTTOTALE.Name = "TXTTOTALE"
        Me.TXTTOTALE.Size = New System.Drawing.Size(135, 29)
        Me.TXTTOTALE.TabIndex = 2
        Me.TXTTOTALE.Text = "0"
        Me.TXTTOTALE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Tarjeta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Efectivo"
        '
        'gb_pago_tarjeta
        '
        Me.gb_pago_tarjeta.Controls.Add(Me.Label10)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_num_operacion_american)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_num_operacion_diners)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_num_operacion_master)
        Me.gb_pago_tarjeta.Controls.Add(Me.txt_num_operacion_visa)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox4)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox3)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox2)
        Me.gb_pago_tarjeta.Controls.Add(Me.PictureBox1)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_AMERICAN_EXPRES)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_DINERS)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_CARD_MASTER)
        Me.gb_pago_tarjeta.Controls.Add(Me.AMOUNT_CARD_VISA)
        Me.gb_pago_tarjeta.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_tarjeta.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_tarjeta.Location = New System.Drawing.Point(15, 138)
        Me.gb_pago_tarjeta.Name = "gb_pago_tarjeta"
        Me.gb_pago_tarjeta.Size = New System.Drawing.Size(421, 254)
        Me.gb_pago_tarjeta.TabIndex = 115
        Me.gb_pago_tarjeta.TabStop = False
        Me.gb_pago_tarjeta.Text = "Pago con Tarjeta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "N° Operación"
        '
        'txt_num_operacion_american
        '
        Me.txt_num_operacion_american.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_operacion_american.ForeColor = System.Drawing.Color.Maroon
        Me.txt_num_operacion_american.Location = New System.Drawing.Point(276, 207)
        Me.txt_num_operacion_american.MaxLength = 50
        Me.txt_num_operacion_american.Name = "txt_num_operacion_american"
        Me.txt_num_operacion_american.Size = New System.Drawing.Size(135, 29)
        Me.txt_num_operacion_american.TabIndex = 15
        '
        'txt_num_operacion_diners
        '
        Me.txt_num_operacion_diners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_operacion_diners.ForeColor = System.Drawing.Color.Maroon
        Me.txt_num_operacion_diners.Location = New System.Drawing.Point(276, 151)
        Me.txt_num_operacion_diners.MaxLength = 50
        Me.txt_num_operacion_diners.Name = "txt_num_operacion_diners"
        Me.txt_num_operacion_diners.Size = New System.Drawing.Size(135, 29)
        Me.txt_num_operacion_diners.TabIndex = 14
        '
        'txt_num_operacion_master
        '
        Me.txt_num_operacion_master.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_operacion_master.ForeColor = System.Drawing.Color.Maroon
        Me.txt_num_operacion_master.Location = New System.Drawing.Point(276, 95)
        Me.txt_num_operacion_master.MaxLength = 50
        Me.txt_num_operacion_master.Name = "txt_num_operacion_master"
        Me.txt_num_operacion_master.Size = New System.Drawing.Size(135, 29)
        Me.txt_num_operacion_master.TabIndex = 13
        '
        'txt_num_operacion_visa
        '
        Me.txt_num_operacion_visa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_operacion_visa.ForeColor = System.Drawing.Color.Maroon
        Me.txt_num_operacion_visa.Location = New System.Drawing.Point(276, 39)
        Me.txt_num_operacion_visa.MaxLength = 50
        Me.txt_num_operacion_visa.Name = "txt_num_operacion_visa"
        Me.txt_num_operacion_visa.Size = New System.Drawing.Size(135, 29)
        Me.txt_num_operacion_visa.TabIndex = 12
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(17, 196)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(17, 140)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'AMOUNT_AMERICAN_EXPRES
        '
        Me.AMOUNT_AMERICAN_EXPRES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_AMERICAN_EXPRES.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_AMERICAN_EXPRES.Location = New System.Drawing.Point(133, 207)
        Me.AMOUNT_AMERICAN_EXPRES.Name = "AMOUNT_AMERICAN_EXPRES"
        Me.AMOUNT_AMERICAN_EXPRES.Size = New System.Drawing.Size(135, 29)
        Me.AMOUNT_AMERICAN_EXPRES.TabIndex = 7
        Me.AMOUNT_AMERICAN_EXPRES.Text = "0"
        Me.AMOUNT_AMERICAN_EXPRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_DINERS
        '
        Me.AMOUNT_DINERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_DINERS.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_DINERS.Location = New System.Drawing.Point(133, 151)
        Me.AMOUNT_DINERS.Name = "AMOUNT_DINERS"
        Me.AMOUNT_DINERS.Size = New System.Drawing.Size(135, 29)
        Me.AMOUNT_DINERS.TabIndex = 6
        Me.AMOUNT_DINERS.Text = "0"
        Me.AMOUNT_DINERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_CARD_MASTER
        '
        Me.AMOUNT_CARD_MASTER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_CARD_MASTER.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_CARD_MASTER.Location = New System.Drawing.Point(133, 95)
        Me.AMOUNT_CARD_MASTER.Name = "AMOUNT_CARD_MASTER"
        Me.AMOUNT_CARD_MASTER.Size = New System.Drawing.Size(135, 29)
        Me.AMOUNT_CARD_MASTER.TabIndex = 5
        Me.AMOUNT_CARD_MASTER.Text = "0"
        Me.AMOUNT_CARD_MASTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AMOUNT_CARD_VISA
        '
        Me.AMOUNT_CARD_VISA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AMOUNT_CARD_VISA.ForeColor = System.Drawing.Color.Maroon
        Me.AMOUNT_CARD_VISA.Location = New System.Drawing.Point(133, 39)
        Me.AMOUNT_CARD_VISA.Name = "AMOUNT_CARD_VISA"
        Me.AMOUNT_CARD_VISA.Size = New System.Drawing.Size(135, 29)
        Me.AMOUNT_CARD_VISA.TabIndex = 4
        Me.AMOUNT_CARD_VISA.Text = "0"
        Me.AMOUNT_CARD_VISA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_pago_efectivo
        '
        Me.gb_pago_efectivo.Controls.Add(Me.TxEfeDol)
        Me.gb_pago_efectivo.Controls.Add(Me.TxEfeSol)
        Me.gb_pago_efectivo.Controls.Add(Me.Label2)
        Me.gb_pago_efectivo.Controls.Add(Me.Label1)
        Me.gb_pago_efectivo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pago_efectivo.ForeColor = System.Drawing.Color.Green
        Me.gb_pago_efectivo.Location = New System.Drawing.Point(15, 55)
        Me.gb_pago_efectivo.Name = "gb_pago_efectivo"
        Me.gb_pago_efectivo.Size = New System.Drawing.Size(421, 77)
        Me.gb_pago_efectivo.TabIndex = 114
        Me.gb_pago_efectivo.TabStop = False
        Me.gb_pago_efectivo.Text = "Pago en Efectivo"
        '
        'TxEfeDol
        '
        Me.TxEfeDol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxEfeDol.ForeColor = System.Drawing.Color.Maroon
        Me.TxEfeDol.Location = New System.Drawing.Point(133, 70)
        Me.TxEfeDol.Name = "TxEfeDol"
        Me.TxEfeDol.Size = New System.Drawing.Size(135, 29)
        Me.TxEfeDol.TabIndex = 3
        Me.TxEfeDol.Text = "0"
        Me.TxEfeDol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxEfeDol.Visible = False
        '
        'TxEfeSol
        '
        Me.TxEfeSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxEfeSol.ForeColor = System.Drawing.Color.Maroon
        Me.TxEfeSol.Location = New System.Drawing.Point(133, 32)
        Me.TxEfeSol.Name = "TxEfeSol"
        Me.TxEfeSol.Size = New System.Drawing.Size(135, 29)
        Me.TxEfeSol.TabIndex = 2
        Me.TxEfeSol.Text = "0"
        Me.TxEfeSol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dolares"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soles"
        '
        'rdb_credito
        '
        Me.rdb_credito.AutoSize = True
        Me.rdb_credito.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_credito.ForeColor = System.Drawing.Color.Green
        Me.rdb_credito.Location = New System.Drawing.Point(147, 16)
        Me.rdb_credito.Name = "rdb_credito"
        Me.rdb_credito.Size = New System.Drawing.Size(90, 26)
        Me.rdb_credito.TabIndex = 113
        Me.rdb_credito.Text = "Credito"
        Me.rdb_credito.UseVisualStyleBackColor = True
        '
        'rdb_contado
        '
        Me.rdb_contado.AutoSize = True
        Me.rdb_contado.Checked = True
        Me.rdb_contado.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_contado.ForeColor = System.Drawing.Color.Green
        Me.rdb_contado.Location = New System.Drawing.Point(43, 16)
        Me.rdb_contado.Name = "rdb_contado"
        Me.rdb_contado.Size = New System.Drawing.Size(98, 26)
        Me.rdb_contado.TabIndex = 112
        Me.rdb_contado.TabStop = True
        Me.rdb_contado.Text = "Contado"
        Me.rdb_contado.UseVisualStyleBackColor = True
        '
        'txtNumeracionManual
        '
        Me.txtNumeracionManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeracionManual.Enabled = False
        Me.txtNumeracionManual.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeracionManual.ForeColor = System.Drawing.Color.Maroon
        Me.txtNumeracionManual.Location = New System.Drawing.Point(442, 437)
        Me.txtNumeracionManual.MaxLength = 10
        Me.txtNumeracionManual.Name = "txtNumeracionManual"
        Me.txtNumeracionManual.Size = New System.Drawing.Size(173, 29)
        Me.txtNumeracionManual.TabIndex = 111
        '
        'btnSalirNumeracion
        '
        Me.btnSalirNumeracion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSalirNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirNumeracion.Image = CType(resources.GetObject("btnSalirNumeracion.Image"), System.Drawing.Image)
        Me.btnSalirNumeracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalirNumeracion.Location = New System.Drawing.Point(727, 421)
        Me.btnSalirNumeracion.Name = "btnSalirNumeracion"
        Me.btnSalirNumeracion.Size = New System.Drawing.Size(69, 45)
        Me.btnSalirNumeracion.TabIndex = 10
        Me.btnSalirNumeracion.Text = "&Cancelar"
        Me.btnSalirNumeracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirNumeracion.UseVisualStyleBackColor = True
        '
        'btnAceptarNumeracion
        '
        Me.btnAceptarNumeracion.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAceptarNumeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarNumeracion.Image = CType(resources.GetObject("btnAceptarNumeracion.Image"), System.Drawing.Image)
        Me.btnAceptarNumeracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptarNumeracion.Location = New System.Drawing.Point(653, 421)
        Me.btnAceptarNumeracion.Name = "btnAceptarNumeracion"
        Me.btnAceptarNumeracion.Size = New System.Drawing.Size(69, 45)
        Me.btnAceptarNumeracion.TabIndex = 11
        Me.btnAceptarNumeracion.Text = "&Grabar"
        Me.btnAceptarNumeracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptarNumeracion.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbAutomatica)
        Me.GroupBox5.Controls.Add(Me.rbManual)
        Me.GroupBox5.Location = New System.Drawing.Point(442, 400)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(173, 34)
        Me.GroupBox5.TabIndex = 110
        Me.GroupBox5.TabStop = False
        '
        'rbAutomatica
        '
        Me.rbAutomatica.AutoSize = True
        Me.rbAutomatica.ForeColor = System.Drawing.Color.Navy
        Me.rbAutomatica.Location = New System.Drawing.Point(8, 10)
        Me.rbAutomatica.Name = "rbAutomatica"
        Me.rbAutomatica.Size = New System.Drawing.Size(87, 21)
        Me.rbAutomatica.TabIndex = 4
        Me.rbAutomatica.Text = "Automatica"
        Me.rbAutomatica.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.ForeColor = System.Drawing.Color.Navy
        Me.rbManual.Location = New System.Drawing.Point(101, 10)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(67, 21)
        Me.rbManual.TabIndex = 4
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTitulo.ForeColor = System.Drawing.Color.Navy
        Me.txtTitulo.Location = New System.Drawing.Point(3, 5)
        Me.txtTitulo.MaxLength = 10
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(259, 22)
        Me.txtTitulo.TabIndex = 112
        Me.txtTitulo.Text = "FACTURAS"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTitulo.Visible = False
        '
        'gb_modo_pago
        '
        Me.gb_modo_pago.Controls.Add(Me.txt_des_modo_pago)
        Me.gb_modo_pago.Controls.Add(Me.txt_cod_modo_pago)
        Me.gb_modo_pago.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_modo_pago.ForeColor = System.Drawing.Color.Green
        Me.gb_modo_pago.Location = New System.Drawing.Point(15, 392)
        Me.gb_modo_pago.Name = "gb_modo_pago"
        Me.gb_modo_pago.Size = New System.Drawing.Size(421, 77)
        Me.gb_modo_pago.TabIndex = 118
        Me.gb_modo_pago.TabStop = False
        Me.gb_modo_pago.Text = "Modo de Pago"
        '
        'txt_cod_modo_pago
        '
        Me.txt_cod_modo_pago.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_modo_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_modo_pago.ForeColor = System.Drawing.Color.Maroon
        Me.txt_cod_modo_pago.Location = New System.Drawing.Point(17, 32)
        Me.txt_cod_modo_pago.Name = "txt_cod_modo_pago"
        Me.txt_cod_modo_pago.ReadOnly = True
        Me.txt_cod_modo_pago.Size = New System.Drawing.Size(79, 29)
        Me.txt_cod_modo_pago.TabIndex = 2
        Me.txt_cod_modo_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_des_modo_pago
        '
        Me.txt_des_modo_pago.BackColor = System.Drawing.Color.White
        Me.txt_des_modo_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_modo_pago.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_modo_pago.Location = New System.Drawing.Point(102, 32)
        Me.txt_des_modo_pago.Name = "txt_des_modo_pago"
        Me.txt_des_modo_pago.ReadOnly = True
        Me.txt_des_modo_pago.Size = New System.Drawing.Size(309, 29)
        Me.txt_des_modo_pago.TabIndex = 3
        '
        'FrmTipoNumeracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 499)
        Me.Controls.Add(Me.pnlTipoNumeracion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipoNumeracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CANCELACION DEL DOCUMENTO"
        Me.pnlTipoNumeracion.ResumeLayout(False)
        Me.pnlTipoNumeracion.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gb_tipo_cambio.ResumeLayout(False)
        Me.gb_tipo_cambio.PerformLayout()
        Me.gb_resumen_pago.ResumeLayout(False)
        Me.gb_resumen_pago.PerformLayout()
        Me.gb_pago_tarjeta.ResumeLayout(False)
        Me.gb_pago_tarjeta.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_pago_efectivo.ResumeLayout(False)
        Me.gb_pago_efectivo.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_modo_pago.ResumeLayout(False)
        Me.gb_modo_pago.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTipoNumeracion As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeracionManual As System.Windows.Forms.TextBox
    Friend WithEvents btnSalirNumeracion As System.Windows.Forms.Button
    Friend WithEvents btnAceptarNumeracion As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAutomatica As System.Windows.Forms.RadioButton
    Friend WithEvents rbManual As System.Windows.Forms.RadioButton
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents gb_pago_tarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents gb_pago_efectivo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_credito As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_contado As System.Windows.Forms.RadioButton
    Friend WithEvents TxEfeDol As System.Windows.Forms.TextBox
    Friend WithEvents TxEfeSol As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AMOUNT_AMERICAN_EXPRES As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_DINERS As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_CARD_MASTER As System.Windows.Forms.TextBox
    Friend WithEvents AMOUNT_CARD_VISA As System.Windows.Forms.TextBox
    Friend WithEvents gb_resumen_pago As System.Windows.Forms.GroupBox
    Friend WithEvents TXTTOTALT As System.Windows.Forms.TextBox
    Friend WithEvents TXTTOTALE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblvuelto As System.Windows.Forms.Label
    Friend WithEvents lblfalta_pagar As System.Windows.Forms.Label
    Friend WithEvents lblpagado As System.Windows.Forms.Label
    Friend WithEvents lblmonto_venta As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gb_tipo_cambio As System.Windows.Forms.GroupBox
    Friend WithEvents lbltipo_cambio As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_num_operacion_american As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_operacion_diners As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_operacion_master As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_operacion_visa As System.Windows.Forms.TextBox
    Friend WithEvents gb_modo_pago As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cod_modo_pago As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_modo_pago As System.Windows.Forms.TextBox
End Class
