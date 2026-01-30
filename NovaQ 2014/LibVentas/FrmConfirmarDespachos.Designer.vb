<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmarDespachos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfirmarDespachos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkGuias = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_Despacho_Guia = New System.Windows.Forms.Button()
        Me.dtpdespachoGuia = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtFiltroGuia = New System.Windows.Forms.TextBox()
        Me.dgvdetalleGuias = New System.Windows.Forms.DataGridView()
        Me.lblCantidadGuias = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkFacturacion = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_Desp_Fact = New System.Windows.Forms.Button()
        Me.dtpDespachoFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFiltroFactura = New System.Windows.Forms.TextBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvdetalleGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1082, 552)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Relacion de Documentos pendientes de Despachar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkGuias)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.dgvdetalleGuias)
        Me.GroupBox3.Controls.Add(Me.lblCantidadGuias)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(18, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1052, 252)
        Me.GroupBox3.TabIndex = 179
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Guia Venta a Facturar"
        '
        'checkGuias
        '
        Me.checkGuias.AutoSize = True
        Me.checkGuias.ForeColor = System.Drawing.Color.Navy
        Me.checkGuias.Location = New System.Drawing.Point(12, 64)
        Me.checkGuias.Name = "checkGuias"
        Me.checkGuias.Size = New System.Drawing.Size(88, 17)
        Me.checkGuias.TabIndex = 181
        Me.checkGuias.Text = "Marcar todos"
        Me.checkGuias.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.btn_Despacho_Guia)
        Me.GroupBox7.Controls.Add(Me.dtpdespachoGuia)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(835, 80)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox7.TabIndex = 180
        Me.GroupBox7.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(9, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 15)
        Me.TextBox1.TabIndex = 169
        Me.TextBox1.Text = "CONFIRMACION DE DESPACHO"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Despacho_Guia
        '
        Me.btn_Despacho_Guia.Image = CType(resources.GetObject("btn_Despacho_Guia.Image"), System.Drawing.Image)
        Me.btn_Despacho_Guia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Despacho_Guia.Location = New System.Drawing.Point(8, 99)
        Me.btn_Despacho_Guia.Name = "btn_Despacho_Guia"
        Me.btn_Despacho_Guia.Size = New System.Drawing.Size(187, 42)
        Me.btn_Despacho_Guia.TabIndex = 127
        Me.btn_Despacho_Guia.Text = "Confirmar Despacho Guia"
        Me.btn_Despacho_Guia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Despacho_Guia.UseVisualStyleBackColor = True
        '
        'dtpdespachoGuia
        '
        Me.dtpdespachoGuia.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpdespachoGuia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdespachoGuia.Location = New System.Drawing.Point(9, 68)
        Me.dtpdespachoGuia.Name = "dtpdespachoGuia"
        Me.dtpdespachoGuia.Size = New System.Drawing.Size(184, 25)
        Me.dtpdespachoGuia.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "&Fecha Documento"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtFiltroGuia)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(509, 45)
        Me.GroupBox5.TabIndex = 179
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltroGuia
        '
        Me.txtFiltroGuia.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltroGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroGuia.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroGuia.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltroGuia.Name = "txtFiltroGuia"
        Me.txtFiltroGuia.Size = New System.Drawing.Size(497, 22)
        Me.txtFiltroGuia.TabIndex = 24
        '
        'dgvdetalleGuias
        '
        Me.dgvdetalleGuias.AllowUserToAddRows = False
        Me.dgvdetalleGuias.AllowUserToDeleteRows = False
        Me.dgvdetalleGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalleGuias.Location = New System.Drawing.Point(10, 88)
        Me.dgvdetalleGuias.Name = "dgvdetalleGuias"
        Me.dgvdetalleGuias.Size = New System.Drawing.Size(818, 152)
        Me.dgvdetalleGuias.TabIndex = 175
        '
        'lblCantidadGuias
        '
        Me.lblCantidadGuias.AutoSize = True
        Me.lblCantidadGuias.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidadGuias.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidadGuias.Location = New System.Drawing.Point(526, 33)
        Me.lblCantidadGuias.Name = "lblCantidadGuias"
        Me.lblCantidadGuias.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidadGuias.TabIndex = 178
        Me.lblCantidadGuias.Text = "."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkFacturacion)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.dgvDetalles)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(18, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Documentos de Facturacion"
        '
        'checkFacturacion
        '
        Me.checkFacturacion.AutoSize = True
        Me.checkFacturacion.Location = New System.Drawing.Point(12, 65)
        Me.checkFacturacion.Name = "checkFacturacion"
        Me.checkFacturacion.Size = New System.Drawing.Size(88, 17)
        Me.checkFacturacion.TabIndex = 176
        Me.checkFacturacion.Text = "Marcar todos"
        Me.checkFacturacion.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.btn_Desp_Fact)
        Me.GroupBox6.Controls.Add(Me.dtpDespachoFactura)
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Location = New System.Drawing.Point(834, 82)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 160)
        Me.GroupBox6.TabIndex = 175
        Me.GroupBox6.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(8, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 15)
        Me.TextBox3.TabIndex = 168
        Me.TextBox3.Text = "CONFIRMACION DE DESPACHO"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Desp_Fact
        '
        Me.btn_Desp_Fact.Image = CType(resources.GetObject("btn_Desp_Fact.Image"), System.Drawing.Image)
        Me.btn_Desp_Fact.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Desp_Fact.Location = New System.Drawing.Point(9, 97)
        Me.btn_Desp_Fact.Name = "btn_Desp_Fact"
        Me.btn_Desp_Fact.Size = New System.Drawing.Size(187, 42)
        Me.btn_Desp_Fact.TabIndex = 122
        Me.btn_Desp_Fact.Text = "Confirmar Despacho Facturacion"
        Me.btn_Desp_Fact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Desp_Fact.UseVisualStyleBackColor = True
        '
        'dtpDespachoFactura
        '
        Me.dtpDespachoFactura.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpDespachoFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDespachoFactura.Location = New System.Drawing.Point(10, 66)
        Me.dtpDespachoFactura.Name = "dtpDespachoFactura"
        Me.dtpDespachoFactura.Size = New System.Drawing.Size(184, 25)
        Me.dtpDespachoFactura.TabIndex = 126
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label45.Location = New System.Drawing.Point(7, 42)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(106, 17)
        Me.Label45.TabIndex = 125
        Me.Label45.Text = "&Fecha Documento"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFiltroFactura)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(511, 45)
        Me.GroupBox4.TabIndex = 120
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltroFactura
        '
        Me.txtFiltroFactura.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroFactura.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroFactura.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltroFactura.Name = "txtFiltroFactura"
        Me.txtFiltroFactura.Size = New System.Drawing.Size(499, 22)
        Me.txtFiltroFactura.TabIndex = 24
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(10, 88)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.Size = New System.Drawing.Size(818, 151)
        Me.dgvDetalles.TabIndex = 0
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(527, 35)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 174
        Me.lblCantidad.Text = "."
        '
        'FrmConfirmarDespachos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 573)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfirmarDespachos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Despachos"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvdetalleGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvdetalleGuias As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidadGuias As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroFactura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltroGuia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents dtpDespachoFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btn_Desp_Fact As System.Windows.Forms.Button
    Friend WithEvents btn_Despacho_Guia As System.Windows.Forms.Button
    Friend WithEvents dtpdespachoGuia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents checkGuias As System.Windows.Forms.CheckBox
    Friend WithEvents checkFacturacion As System.Windows.Forms.CheckBox
End Class
