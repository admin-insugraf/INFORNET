<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion_SUNAT_Com_Retencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion_SUNAT_Com_Retencion))
        Me.btn_generar_cpe = New System.Windows.Forms.Button()
        Me.btn_estado_sunat = New System.Windows.Forms.Button()
        Me.btn_comunicacion_baja = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_actualiza_estado = New System.Windows.Forms.Button()
        Me.btn_reenvio_email = New System.Windows.Forms.Button()
        Me.btn_ver_pdf = New System.Windows.Forms.Button()
        Me.btn_ver_cdr = New System.Windows.Forms.Button()
        Me.btn_reenviar_doc_sunat = New System.Windows.Forms.Button()
        Me.btn_verifica_estado_manual = New System.Windows.Forms.Button()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.dgvDocumentosFactura2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboOpcionTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvDocumentosFactura2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_generar_cpe
        '
        Me.btn_generar_cpe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generar_cpe.BackColor = System.Drawing.Color.Transparent
        Me.btn_generar_cpe.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_generar_cpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generar_cpe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar_cpe.Image = CType(resources.GetObject("btn_generar_cpe.Image"), System.Drawing.Image)
        Me.btn_generar_cpe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_cpe.Location = New System.Drawing.Point(362, 380)
        Me.btn_generar_cpe.Name = "btn_generar_cpe"
        Me.btn_generar_cpe.Size = New System.Drawing.Size(131, 43)
        Me.btn_generar_cpe.TabIndex = 209
        Me.btn_generar_cpe.Text = "GENERAR CPE"
        Me.btn_generar_cpe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_cpe.UseVisualStyleBackColor = False
        '
        'btn_estado_sunat
        '
        Me.btn_estado_sunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_estado_sunat.BackColor = System.Drawing.Color.Transparent
        Me.btn_estado_sunat.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_estado_sunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estado_sunat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estado_sunat.Image = CType(resources.GetObject("btn_estado_sunat.Image"), System.Drawing.Image)
        Me.btn_estado_sunat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estado_sunat.Location = New System.Drawing.Point(362, 429)
        Me.btn_estado_sunat.Name = "btn_estado_sunat"
        Me.btn_estado_sunat.Size = New System.Drawing.Size(131, 43)
        Me.btn_estado_sunat.TabIndex = 208
        Me.btn_estado_sunat.Text = "ESTADO SUNAT"
        Me.btn_estado_sunat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_estado_sunat.UseVisualStyleBackColor = False
        '
        'btn_comunicacion_baja
        '
        Me.btn_comunicacion_baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_comunicacion_baja.BackColor = System.Drawing.Color.Transparent
        Me.btn_comunicacion_baja.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_comunicacion_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_comunicacion_baja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comunicacion_baja.Image = CType(resources.GetObject("btn_comunicacion_baja.Image"), System.Drawing.Image)
        Me.btn_comunicacion_baja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_comunicacion_baja.Location = New System.Drawing.Point(5, 429)
        Me.btn_comunicacion_baja.Name = "btn_comunicacion_baja"
        Me.btn_comunicacion_baja.Size = New System.Drawing.Size(192, 43)
        Me.btn_comunicacion_baja.TabIndex = 207
        Me.btn_comunicacion_baja.Text = "COMUNICACIONES DE BAJA"
        Me.btn_comunicacion_baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_comunicacion_baja.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(5, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 43)
        Me.Button3.TabIndex = 206
        Me.Button3.Text = "REPORTE DE DOCUMENTOS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(202, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 43)
        Me.Button2.TabIndex = 205
        Me.Button2.Text = "RESUMENES DE BOLETAS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(500, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 43)
        Me.Button1.TabIndex = 204
        Me.Button1.Text = "CDR SUNAT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Obtener CDR Manual)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_actualiza_estado
        '
        Me.btn_actualiza_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_actualiza_estado.BackColor = System.Drawing.Color.Transparent
        Me.btn_actualiza_estado.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_actualiza_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualiza_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualiza_estado.Image = CType(resources.GetObject("btn_actualiza_estado.Image"), System.Drawing.Image)
        Me.btn_actualiza_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualiza_estado.Location = New System.Drawing.Point(5, 380)
        Me.btn_actualiza_estado.Name = "btn_actualiza_estado"
        Me.btn_actualiza_estado.Size = New System.Drawing.Size(192, 43)
        Me.btn_actualiza_estado.TabIndex = 203
        Me.btn_actualiza_estado.Text = "ACTUALIZAR ESTADO DOC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(CDR SUNAT)"
        Me.btn_actualiza_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualiza_estado.UseVisualStyleBackColor = False
        '
        'btn_reenvio_email
        '
        Me.btn_reenvio_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reenvio_email.BackColor = System.Drawing.Color.Transparent
        Me.btn_reenvio_email.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_reenvio_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reenvio_email.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reenvio_email.Image = CType(resources.GetObject("btn_reenvio_email.Image"), System.Drawing.Image)
        Me.btn_reenvio_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reenvio_email.Location = New System.Drawing.Point(920, 429)
        Me.btn_reenvio_email.Name = "btn_reenvio_email"
        Me.btn_reenvio_email.Size = New System.Drawing.Size(157, 43)
        Me.btn_reenvio_email.TabIndex = 202
        Me.btn_reenvio_email.Text = "REENVIO DE COMPROBANTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Reenviar PDF y XML al cliente)"
        Me.btn_reenvio_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reenvio_email.UseVisualStyleBackColor = False
        '
        'btn_ver_pdf
        '
        Me.btn_ver_pdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btn_ver_pdf.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ver_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ver_pdf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_pdf.Image = CType(resources.GetObject("btn_ver_pdf.Image"), System.Drawing.Image)
        Me.btn_ver_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ver_pdf.Location = New System.Drawing.Point(710, 429)
        Me.btn_ver_pdf.Name = "btn_ver_pdf"
        Me.btn_ver_pdf.Size = New System.Drawing.Size(204, 43)
        Me.btn_ver_pdf.TabIndex = 201
        Me.btn_ver_pdf.Text = "VER PDF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Mostrar PDF enviado al cliente)"
        Me.btn_ver_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ver_pdf.UseVisualStyleBackColor = False
        '
        'btn_ver_cdr
        '
        Me.btn_ver_cdr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ver_cdr.BackColor = System.Drawing.Color.Transparent
        Me.btn_ver_cdr.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_ver_cdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ver_cdr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_cdr.Image = CType(resources.GetObject("btn_ver_cdr.Image"), System.Drawing.Image)
        Me.btn_ver_cdr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ver_cdr.Location = New System.Drawing.Point(920, 380)
        Me.btn_ver_cdr.Name = "btn_ver_cdr"
        Me.btn_ver_cdr.Size = New System.Drawing.Size(157, 43)
        Me.btn_ver_cdr.TabIndex = 200
        Me.btn_ver_cdr.Text = "VER CDR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Información detallada de CDR)"
        Me.btn_ver_cdr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ver_cdr.UseVisualStyleBackColor = False
        '
        'btn_reenviar_doc_sunat
        '
        Me.btn_reenviar_doc_sunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reenviar_doc_sunat.BackColor = System.Drawing.Color.Transparent
        Me.btn_reenviar_doc_sunat.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_reenviar_doc_sunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reenviar_doc_sunat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reenviar_doc_sunat.Image = CType(resources.GetObject("btn_reenviar_doc_sunat.Image"), System.Drawing.Image)
        Me.btn_reenviar_doc_sunat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reenviar_doc_sunat.Location = New System.Drawing.Point(710, 380)
        Me.btn_reenviar_doc_sunat.Name = "btn_reenviar_doc_sunat"
        Me.btn_reenviar_doc_sunat.Size = New System.Drawing.Size(204, 43)
        Me.btn_reenviar_doc_sunat.TabIndex = 199
        Me.btn_reenviar_doc_sunat.Text = "REENVIAR DOCUMENTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Volver a Enviar a SUNAT)"
        Me.btn_reenviar_doc_sunat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reenviar_doc_sunat.UseVisualStyleBackColor = False
        '
        'btn_verifica_estado_manual
        '
        Me.btn_verifica_estado_manual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_verifica_estado_manual.BackColor = System.Drawing.Color.Transparent
        Me.btn_verifica_estado_manual.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_verifica_estado_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verifica_estado_manual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verifica_estado_manual.Image = CType(resources.GetObject("btn_verifica_estado_manual.Image"), System.Drawing.Image)
        Me.btn_verifica_estado_manual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_verifica_estado_manual.Location = New System.Drawing.Point(500, 380)
        Me.btn_verifica_estado_manual.Name = "btn_verifica_estado_manual"
        Me.btn_verifica_estado_manual.Size = New System.Drawing.Size(204, 43)
        Me.btn_verifica_estado_manual.TabIndex = 198
        Me.btn_verifica_estado_manual.Text = "VERIFICACION ESTADO DOC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(CDR valido)"
        Me.btn_verifica_estado_manual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_verifica_estado_manual.UseVisualStyleBackColor = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.dgvDocumentosFactura2)
        Me.pnlPrincipal.Controls.Add(Me.Label1)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox4)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox3)
        Me.pnlPrincipal.Controls.Add(Me.GroupBox2)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidad)
        Me.pnlPrincipal.Controls.Add(Me.gbRangofechas)
        Me.pnlPrincipal.Location = New System.Drawing.Point(5, 9)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1072, 366)
        Me.pnlPrincipal.TabIndex = 197
        '
        'dgvDocumentosFactura2
        '
        Me.dgvDocumentosFactura2.AllowUserToAddRows = False
        Me.dgvDocumentosFactura2.AllowUserToDeleteRows = False
        Me.dgvDocumentosFactura2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDocumentosFactura2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentosFactura2.Location = New System.Drawing.Point(8, 112)
        Me.dgvDocumentosFactura2.MultiSelect = False
        Me.dgvDocumentosFactura2.Name = "dgvDocumentosFactura2"
        Me.dgvDocumentosFactura2.ReadOnly = True
        Me.dgvDocumentosFactura2.Size = New System.Drawing.Size(1054, 222)
        Me.dgvDocumentosFactura2.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 19)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "COMPROBANTES DE RETENCION ELECTRONICA"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboOpcionTipoDoc)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(337, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(138, 45)
        Me.GroupBox4.TabIndex = 122
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documento"
        Me.GroupBox4.Visible = False
        '
        'cboOpcionTipoDoc
        '
        Me.cboOpcionTipoDoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionTipoDoc.FormattingEnabled = True
        Me.cboOpcionTipoDoc.Items.AddRange(New Object() {"Todos", "CR"})
        Me.cboOpcionTipoDoc.Location = New System.Drawing.Point(6, 15)
        Me.cboOpcionTipoDoc.Name = "cboOpcionTipoDoc"
        Me.cboOpcionTipoDoc.Size = New System.Drawing.Size(125, 25)
        Me.cboOpcionTipoDoc.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 45)
        Me.GroupBox3.TabIndex = 119
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
        Me.txtFiltro.Size = New System.Drawing.Size(448, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(480, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 45)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(6, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Maroon
        Me.lblCantidad.Location = New System.Drawing.Point(11, 337)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(12, 16)
        Me.lblCantidad.TabIndex = 118
        Me.lblCantidad.Text = "."
        '
        'gbRangofechas
        '
        Me.gbRangofechas.Controls.Add(Me.Label25)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label26)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRangofechas.ForeColor = System.Drawing.Color.Navy
        Me.gbRangofechas.Location = New System.Drawing.Point(664, 56)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(359, 45)
        Me.gbRangofechas.TabIndex = 121
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(185, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Fecha Final"
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(258, 13)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(7, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Fecha inicial"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(85, 15)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'FrmFacturacion_SUNAT_Com_Retencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 481)
        Me.Controls.Add(Me.btn_generar_cpe)
        Me.Controls.Add(Me.btn_estado_sunat)
        Me.Controls.Add(Me.btn_comunicacion_baja)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_actualiza_estado)
        Me.Controls.Add(Me.btn_reenvio_email)
        Me.Controls.Add(Me.btn_ver_pdf)
        Me.Controls.Add(Me.btn_ver_cdr)
        Me.Controls.Add(Me.btn_reenviar_doc_sunat)
        Me.Controls.Add(Me.btn_verifica_estado_manual)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacion_SUNAT_Com_Retencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de Retención"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvDocumentosFactura2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_generar_cpe As System.Windows.Forms.Button
    Friend WithEvents btn_estado_sunat As System.Windows.Forms.Button
    Friend WithEvents btn_comunicacion_baja As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_actualiza_estado As System.Windows.Forms.Button
    Friend WithEvents btn_reenvio_email As System.Windows.Forms.Button
    Friend WithEvents btn_ver_pdf As System.Windows.Forms.Button
    Friend WithEvents btn_ver_cdr As System.Windows.Forms.Button
    Friend WithEvents btn_reenviar_doc_sunat As System.Windows.Forms.Button
    Friend WithEvents btn_verifica_estado_manual As System.Windows.Forms.Button
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents dgvDocumentosFactura2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboOpcionTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
End Class
