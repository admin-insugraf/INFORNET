<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValida_CPE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValida_CPE))
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.btn_ValidaAcceso = New System.Windows.Forms.Button()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.btn_retenciónpercepcion = New System.Windows.Forms.Button()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_FoliosRestantes = New System.Windows.Forms.Button()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_Enviar = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Reversión = New System.Windows.Forms.Button()
        Me.cmb_TipoDocumentoDocumentosReversion = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_Motivo_Reversion = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txt_seriecorrelativoReversion = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_ComunicacionBaja = New System.Windows.Forms.Button()
        Me.cmb_TipoDocumentoDocumentos = New System.Windows.Forms.ComboBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txt_SerieCorrelativo = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ruc_emisor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_fecha_emision = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmb_ConsultaStatus = New System.Windows.Forms.ComboBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.btn_EstatusDocumento = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Descarga = New System.Windows.Forms.Button()
        Me.cmb_DescargaArchivo = New System.Windows.Forms.ComboBox()
        Me.txt_descarga_doc = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.cmb_TipoDocumentoDescarga = New System.Windows.Forms.ComboBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.groupBox7.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Controls.Add(Me.groupBox7)
        Me.panel2.Controls.Add(Me.groupBox6)
        Me.panel2.Controls.Add(Me.groupBox5)
        Me.panel2.Controls.Add(Me.groupBox4)
        Me.panel2.Controls.Add(Me.groupBox3)
        Me.panel2.Controls.Add(Me.groupBox2)
        Me.panel2.Controls.Add(Me.groupBox1)
        Me.panel2.Location = New System.Drawing.Point(4, 7)
        Me.panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(801, 401)
        Me.panel2.TabIndex = 26
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.btn_ValidaAcceso)
        Me.panel3.Controls.Add(Me.txt_ruc)
        Me.panel3.Controls.Add(Me.txt_pass)
        Me.panel3.Controls.Add(Me.label1)
        Me.panel3.Controls.Add(Me.label2)
        Me.panel3.Controls.Add(Me.txt_user)
        Me.panel3.Controls.Add(Me.label3)
        Me.panel3.Location = New System.Drawing.Point(-1, -1)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(801, 41)
        Me.panel3.TabIndex = 54
        '
        'btn_ValidaAcceso
        '
        Me.btn_ValidaAcceso.Location = New System.Drawing.Point(664, 6)
        Me.btn_ValidaAcceso.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_ValidaAcceso.Name = "btn_ValidaAcceso"
        Me.btn_ValidaAcceso.Size = New System.Drawing.Size(126, 27)
        Me.btn_ValidaAcceso.TabIndex = 0
        Me.btn_ValidaAcceso.Text = "Credenciales"
        Me.btn_ValidaAcceso.UseVisualStyleBackColor = True
        '
        'txt_ruc
        '
        Me.txt_ruc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_ruc.Location = New System.Drawing.Point(72, 9)
        Me.txt_ruc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(81, 20)
        Me.txt_ruc.TabIndex = 12
        Me.txt_ruc.Text = "20417180134"
        Me.txt_ruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_pass
        '
        Me.txt_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_pass.Location = New System.Drawing.Point(487, 9)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.ReadOnly = True
        Me.txt_pass.Size = New System.Drawing.Size(158, 20)
        Me.txt_pass.TabIndex = 17
        Me.txt_pass.Text = "LMgz5irMoFXABNgtuEp0EA=="
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 13)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(33, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "RUC:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(162, 13)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Usuario:"
        '
        'txt_user
        '
        Me.txt_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_user.Location = New System.Drawing.Point(212, 9)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.ReadOnly = True
        Me.txt_user.Size = New System.Drawing.Size(200, 20)
        Me.txt_user.TabIndex = 16
        Me.txt_user.Text = "f46a73fb-feec-46e7-8fae-87ec69fa6936"
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(419, 13)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Contraseña:"
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.btn_retenciónpercepcion)
        Me.groupBox7.Enabled = False
        Me.groupBox7.Location = New System.Drawing.Point(537, 185)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(263, 61)
        Me.groupBox7.TabIndex = 53
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "Percepcion Retencion"
        '
        'btn_retenciónpercepcion
        '
        Me.btn_retenciónpercepcion.Location = New System.Drawing.Point(9, 20)
        Me.btn_retenciónpercepcion.Name = "btn_retenciónpercepcion"
        Me.btn_retenciónpercepcion.Size = New System.Drawing.Size(244, 32)
        Me.btn_retenciónpercepcion.TabIndex = 53
        Me.btn_retenciónpercepcion.Text = "PercepcionRetencion"
        Me.btn_retenciónpercepcion.UseVisualStyleBackColor = True
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.btn_FoliosRestantes)
        Me.groupBox6.Enabled = False
        Me.groupBox6.Location = New System.Drawing.Point(535, 113)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(263, 61)
        Me.groupBox6.TabIndex = 52
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Folios Restantes"
        '
        'btn_FoliosRestantes
        '
        Me.btn_FoliosRestantes.Location = New System.Drawing.Point(9, 20)
        Me.btn_FoliosRestantes.Name = "btn_FoliosRestantes"
        Me.btn_FoliosRestantes.Size = New System.Drawing.Size(244, 32)
        Me.btn_FoliosRestantes.TabIndex = 53
        Me.btn_FoliosRestantes.Text = "FoliosRestantes"
        Me.btn_FoliosRestantes.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.btn_Enviar)
        Me.groupBox5.Enabled = False
        Me.groupBox5.Location = New System.Drawing.Point(535, 46)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(263, 61)
        Me.groupBox5.TabIndex = 51
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Factura Boleta"
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Location = New System.Drawing.Point(9, 21)
        Me.btn_Enviar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(244, 35)
        Me.btn_Enviar.TabIndex = 21
        Me.btn_Enviar.Text = "FacturaBoleta"
        Me.btn_Enviar.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.btn_Reversión)
        Me.groupBox4.Controls.Add(Me.cmb_TipoDocumentoDocumentosReversion)
        Me.groupBox4.Controls.Add(Me.label6)
        Me.groupBox4.Controls.Add(Me.label7)
        Me.groupBox4.Controls.Add(Me.txt_Motivo_Reversion)
        Me.groupBox4.Controls.Add(Me.label8)
        Me.groupBox4.Controls.Add(Me.txt_seriecorrelativoReversion)
        Me.groupBox4.Enabled = False
        Me.groupBox4.Location = New System.Drawing.Point(7, 208)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(254, 185)
        Me.groupBox4.TabIndex = 50
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Reversión de comprobantes"
        '
        'btn_Reversión
        '
        Me.btn_Reversión.Location = New System.Drawing.Point(76, 116)
        Me.btn_Reversión.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Reversión.Name = "btn_Reversión"
        Me.btn_Reversión.Size = New System.Drawing.Size(166, 28)
        Me.btn_Reversión.TabIndex = 47
        Me.btn_Reversión.Text = "Reversion"
        Me.btn_Reversión.UseVisualStyleBackColor = True
        '
        'cmb_TipoDocumentoDocumentosReversion
        '
        Me.cmb_TipoDocumentoDocumentosReversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDocumentoDocumentosReversion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_TipoDocumentoDocumentosReversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.cmb_TipoDocumentoDocumentosReversion.FormattingEnabled = True
        Me.cmb_TipoDocumentoDocumentosReversion.Items.AddRange(New Object() {"RETENCION", "PERCEPCION"})
        Me.cmb_TipoDocumentoDocumentosReversion.Location = New System.Drawing.Point(77, 20)
        Me.cmb_TipoDocumentoDocumentosReversion.Name = "cmb_TipoDocumentoDocumentosReversion"
        Me.cmb_TipoDocumentoDocumentosReversion.Size = New System.Drawing.Size(165, 23)
        Me.cmb_TipoDocumentoDocumentosReversion.TabIndex = 46
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(7, 23)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(57, 15)
        Me.label6.TabIndex = 45
        Me.label6.Text = "Tipo Doc:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(7, 53)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(60, 15)
        Me.label7.TabIndex = 44
        Me.label7.Text = "Serl-Corr:"
        '
        'txt_Motivo_Reversion
        '
        Me.txt_Motivo_Reversion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Motivo_Reversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_Motivo_Reversion.Location = New System.Drawing.Point(77, 84)
        Me.txt_Motivo_Reversion.MaxLength = 11
        Me.txt_Motivo_Reversion.Name = "txt_Motivo_Reversion"
        Me.txt_Motivo_Reversion.Size = New System.Drawing.Size(165, 23)
        Me.txt_Motivo_Reversion.TabIndex = 42
        Me.txt_Motivo_Reversion.Text = "Hay no lose"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(7, 84)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 15)
        Me.label8.TabIndex = 43
        Me.label8.Text = "Motivo:"
        '
        'txt_seriecorrelativoReversion
        '
        Me.txt_seriecorrelativoReversion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_seriecorrelativoReversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_seriecorrelativoReversion.Location = New System.Drawing.Point(77, 52)
        Me.txt_seriecorrelativoReversion.MaxLength = 11
        Me.txt_seriecorrelativoReversion.Name = "txt_seriecorrelativoReversion"
        Me.txt_seriecorrelativoReversion.Size = New System.Drawing.Size(165, 23)
        Me.txt_seriecorrelativoReversion.TabIndex = 41
        Me.txt_seriecorrelativoReversion.Text = "F001-136"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btn_ComunicacionBaja)
        Me.groupBox3.Controls.Add(Me.cmb_TipoDocumentoDocumentos)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Controls.Add(Me.label26)
        Me.groupBox3.Controls.Add(Me.txt_Motivo)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.txt_SerieCorrelativo)
        Me.groupBox3.Enabled = False
        Me.groupBox3.Location = New System.Drawing.Point(6, 46)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(254, 153)
        Me.groupBox3.TabIndex = 49
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Comunicación baja"
        '
        'btn_ComunicacionBaja
        '
        Me.btn_ComunicacionBaja.Location = New System.Drawing.Point(76, 113)
        Me.btn_ComunicacionBaja.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_ComunicacionBaja.Name = "btn_ComunicacionBaja"
        Me.btn_ComunicacionBaja.Size = New System.Drawing.Size(166, 28)
        Me.btn_ComunicacionBaja.TabIndex = 47
        Me.btn_ComunicacionBaja.Text = "ComunicacionBaja"
        Me.btn_ComunicacionBaja.UseVisualStyleBackColor = True
        '
        'cmb_TipoDocumentoDocumentos
        '
        Me.cmb_TipoDocumentoDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDocumentoDocumentos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_TipoDocumentoDocumentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.cmb_TipoDocumentoDocumentos.FormattingEnabled = True
        Me.cmb_TipoDocumentoDocumentos.Items.AddRange(New Object() {"FACTURA", "BOLETA", "NOTA CREDITO", "NOTA DEBITO"})
        Me.cmb_TipoDocumentoDocumentos.Location = New System.Drawing.Point(77, 20)
        Me.cmb_TipoDocumentoDocumentos.Name = "cmb_TipoDocumentoDocumentos"
        Me.cmb_TipoDocumentoDocumentos.Size = New System.Drawing.Size(165, 23)
        Me.cmb_TipoDocumentoDocumentos.TabIndex = 46
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(7, 23)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(57, 15)
        Me.label11.TabIndex = 45
        Me.label11.Text = "Tipo Doc:"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label26.Location = New System.Drawing.Point(7, 53)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(60, 15)
        Me.label26.TabIndex = 44
        Me.label26.Text = "Serl-Corr:"
        '
        'txt_Motivo
        '
        Me.txt_Motivo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_Motivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_Motivo.Location = New System.Drawing.Point(77, 84)
        Me.txt_Motivo.MaxLength = 11
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(165, 23)
        Me.txt_Motivo.TabIndex = 42
        Me.txt_Motivo.Text = "Hay no lose"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(7, 84)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(50, 15)
        Me.label10.TabIndex = 43
        Me.label10.Text = "Motivo:"
        '
        'txt_SerieCorrelativo
        '
        Me.txt_SerieCorrelativo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_SerieCorrelativo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_SerieCorrelativo.Location = New System.Drawing.Point(77, 52)
        Me.txt_SerieCorrelativo.MaxLength = 11
        Me.txt_SerieCorrelativo.Name = "txt_SerieCorrelativo"
        Me.txt_SerieCorrelativo.Size = New System.Drawing.Size(165, 23)
        Me.txt_SerieCorrelativo.TabIndex = 41
        Me.txt_SerieCorrelativo.Text = "F001-136"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnlimpiar)
        Me.groupBox2.Controls.Add(Me.Label15)
        Me.groupBox2.Controls.Add(Me.txt_ruc_emisor)
        Me.groupBox2.Controls.Add(Me.Label14)
        Me.groupBox2.Controls.Add(Me.txt_total)
        Me.groupBox2.Controls.Add(Me.Label9)
        Me.groupBox2.Controls.Add(Me.txt_fecha_emision)
        Me.groupBox2.Controls.Add(Me.txt_numero)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.cmb_ConsultaStatus)
        Me.groupBox2.Controls.Add(Me.txt_serie)
        Me.groupBox2.Controls.Add(Me.btn_EstatusDocumento)
        Me.groupBox2.ForeColor = System.Drawing.Color.Navy
        Me.groupBox2.Location = New System.Drawing.Point(266, 208)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(263, 185)
        Me.groupBox2.TabIndex = 48
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Estatus Documento"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(6, 148)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 28)
        Me.btnlimpiar.TabIndex = 48
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(6, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 15)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Ruc Emisor:"
        '
        'txt_ruc_emisor
        '
        Me.txt_ruc_emisor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_ruc_emisor.Location = New System.Drawing.Point(90, 20)
        Me.txt_ruc_emisor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_ruc_emisor.MaxLength = 11
        Me.txt_ruc_emisor.Name = "txt_ruc_emisor"
        Me.txt_ruc_emisor.Size = New System.Drawing.Size(164, 20)
        Me.txt_ruc_emisor.TabIndex = 46
        Me.txt_ruc_emisor.Text = "12345678901"
        Me.txt_ruc_emisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(6, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_total.Location = New System.Drawing.Point(89, 123)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(164, 20)
        Me.txt_total.TabIndex = 44
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Fecha Emi:"
        '
        'txt_fecha_emision
        '
        Me.txt_fecha_emision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_fecha_emision.Location = New System.Drawing.Point(89, 99)
        Me.txt_fecha_emision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_fecha_emision.MaxLength = 10
        Me.txt_fecha_emision.Name = "txt_fecha_emision"
        Me.txt_fecha_emision.Size = New System.Drawing.Size(164, 20)
        Me.txt_fecha_emision.TabIndex = 42
        Me.txt_fecha_emision.Text = "01/01/2021"
        Me.txt_fecha_emision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_numero
        '
        Me.txt_numero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_numero.Location = New System.Drawing.Point(161, 74)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_numero.MaxLength = 8
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(92, 20)
        Me.txt_numero.TabIndex = 41
        Me.txt_numero.Text = "584"
        Me.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label5.Location = New System.Drawing.Point(6, 77)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 15)
        Me.label5.TabIndex = 40
        Me.label5.Text = "Serl-Corr:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label4.Location = New System.Drawing.Point(6, 50)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 15)
        Me.label4.TabIndex = 39
        Me.label4.Text = "Tipo Doc:"
        '
        'cmb_ConsultaStatus
        '
        Me.cmb_ConsultaStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ConsultaStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.cmb_ConsultaStatus.FormattingEnabled = True
        Me.cmb_ConsultaStatus.Items.AddRange(New Object() {"Factura", "Boleta", "Nota Crédito", "Nota Débito", "Retención", "Percepcion"})
        Me.cmb_ConsultaStatus.Location = New System.Drawing.Point(89, 47)
        Me.cmb_ConsultaStatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_ConsultaStatus.Name = "cmb_ConsultaStatus"
        Me.cmb_ConsultaStatus.Size = New System.Drawing.Size(164, 21)
        Me.cmb_ConsultaStatus.TabIndex = 20
        '
        'txt_serie
        '
        Me.txt_serie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_serie.Location = New System.Drawing.Point(89, 74)
        Me.txt_serie.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_serie.MaxLength = 4
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(65, 20)
        Me.txt_serie.TabIndex = 19
        Me.txt_serie.Text = "F001"
        Me.txt_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_EstatusDocumento
        '
        Me.btn_EstatusDocumento.Location = New System.Drawing.Point(89, 148)
        Me.btn_EstatusDocumento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_EstatusDocumento.Name = "btn_EstatusDocumento"
        Me.btn_EstatusDocumento.Size = New System.Drawing.Size(166, 28)
        Me.btn_EstatusDocumento.TabIndex = 18
        Me.btn_EstatusDocumento.Text = "EstatusDocumento"
        Me.btn_EstatusDocumento.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btn_Descarga)
        Me.groupBox1.Controls.Add(Me.cmb_DescargaArchivo)
        Me.groupBox1.Controls.Add(Me.txt_descarga_doc)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.cmb_TipoDocumentoDescarga)
        Me.groupBox1.Controls.Add(Me.label25)
        Me.groupBox1.Enabled = False
        Me.groupBox1.Location = New System.Drawing.Point(266, 46)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(263, 153)
        Me.groupBox1.TabIndex = 47
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Descarga Archivos"
        '
        'btn_Descarga
        '
        Me.btn_Descarga.Location = New System.Drawing.Point(89, 116)
        Me.btn_Descarga.Name = "btn_Descarga"
        Me.btn_Descarga.Size = New System.Drawing.Size(164, 28)
        Me.btn_Descarga.TabIndex = 32
        Me.btn_Descarga.Text = "DescargaArchivos"
        Me.btn_Descarga.UseVisualStyleBackColor = True
        '
        'cmb_DescargaArchivo
        '
        Me.cmb_DescargaArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DescargaArchivo.FormattingEnabled = True
        Me.cmb_DescargaArchivo.Items.AddRange(New Object() {"PDF", "XML", "CDR"})
        Me.cmb_DescargaArchivo.Location = New System.Drawing.Point(89, 29)
        Me.cmb_DescargaArchivo.Name = "cmb_DescargaArchivo"
        Me.cmb_DescargaArchivo.Size = New System.Drawing.Size(164, 21)
        Me.cmb_DescargaArchivo.TabIndex = 33
        '
        'txt_descarga_doc
        '
        Me.txt_descarga_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt_descarga_doc.Location = New System.Drawing.Point(89, 87)
        Me.txt_descarga_doc.MaxLength = 30
        Me.txt_descarga_doc.Name = "txt_descarga_doc"
        Me.txt_descarga_doc.Size = New System.Drawing.Size(164, 20)
        Me.txt_descarga_doc.TabIndex = 34
        Me.txt_descarga_doc.Text = "F001-136"
        Me.txt_descarga_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label12.Location = New System.Drawing.Point(1, 32)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(36, 15)
        Me.label12.TabIndex = 36
        Me.label12.Text = "Arch:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label13.Location = New System.Drawing.Point(1, 93)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(60, 15)
        Me.label13.TabIndex = 35
        Me.label13.Text = "Serl-Corr:"
        '
        'cmb_TipoDocumentoDescarga
        '
        Me.cmb_TipoDocumentoDescarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDocumentoDescarga.FormattingEnabled = True
        Me.cmb_TipoDocumentoDescarga.Items.AddRange(New Object() {"FACTURA", "BOLETA", "NOTA CREDITO", "NOTA DEBITO", "RETENCION", "PERCEPCION"})
        Me.cmb_TipoDocumentoDescarga.Location = New System.Drawing.Point(89, 58)
        Me.cmb_TipoDocumentoDescarga.Name = "cmb_TipoDocumentoDescarga"
        Me.cmb_TipoDocumentoDescarga.Size = New System.Drawing.Size(164, 21)
        Me.cmb_TipoDocumentoDescarga.TabIndex = 37
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label25.Location = New System.Drawing.Point(1, 61)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(57, 15)
        Me.label25.TabIndex = 38
        Me.label25.Text = "Tipo Doc:"
        '
        'FrmValida_CPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 415)
        Me.Controls.Add(Me.panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmValida_CPE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Validez de CPE"
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents btn_ValidaAcceso As System.Windows.Forms.Button
    Private WithEvents txt_ruc As System.Windows.Forms.TextBox
    Private WithEvents txt_pass As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_user As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents btn_retenciónpercepcion As System.Windows.Forms.Button
    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Private WithEvents btn_FoliosRestantes As System.Windows.Forms.Button
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents btn_Enviar As System.Windows.Forms.Button
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents btn_Reversión As System.Windows.Forms.Button
    Private WithEvents cmb_TipoDocumentoDocumentosReversion As System.Windows.Forms.ComboBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_Motivo_Reversion As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txt_seriecorrelativoReversion As System.Windows.Forms.TextBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btn_ComunicacionBaja As System.Windows.Forms.Button
    Private WithEvents cmb_TipoDocumentoDocumentos As System.Windows.Forms.ComboBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label26 As System.Windows.Forms.Label
    Private WithEvents txt_Motivo As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents txt_SerieCorrelativo As System.Windows.Forms.TextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnlimpiar As System.Windows.Forms.Button
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents btn_EstatusDocumento As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btn_Descarga As System.Windows.Forms.Button
    Private WithEvents cmb_DescargaArchivo As System.Windows.Forms.ComboBox
    Private WithEvents txt_descarga_doc As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents cmb_TipoDocumentoDescarga As System.Windows.Forms.ComboBox
    Private WithEvents label25 As System.Windows.Forms.Label
    Public WithEvents txt_ruc_emisor As System.Windows.Forms.TextBox
    Public WithEvents txt_total As System.Windows.Forms.TextBox
    Public WithEvents txt_fecha_emision As System.Windows.Forms.TextBox
    Public WithEvents txt_numero As System.Windows.Forms.TextBox
    Public WithEvents cmb_ConsultaStatus As System.Windows.Forms.ComboBox
    Public WithEvents txt_serie As System.Windows.Forms.TextBox
End Class
