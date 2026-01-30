<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Transportista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Transportista))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RucDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTransportista = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTelEmpresa = New System.Windows.Forms.TextBox()
        Me.txtDirEmpresa = New System.Windows.Forms.TextBox()
        Me.txtRucEmpresa = New System.Windows.Forms.TextBox()
        Me.txtNomEmpresa = New System.Windows.Forms.TextBox()
        Me.txtInscripcion = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtBrevete = New System.Windows.Forms.TextBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(533, 365)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(525, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Transportistas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.RucDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsTransportista
        Me.DataGridView1.Location = New System.Drawing.Point(5, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(516, 327)
        Me.DataGridView1.TabIndex = 1
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RucDataGridViewTextBoxColumn
        '
        Me.RucDataGridViewTextBoxColumn.DataPropertyName = "Ruc"
        Me.RucDataGridViewTextBoxColumn.HeaderText = "Ruc"
        Me.RucDataGridViewTextBoxColumn.Name = "RucDataGridViewTextBoxColumn"
        Me.RucDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "Dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "Dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsTransportista
        '
        Me.bsTransportista.DataSource = GetType(LibAlmacenes.Transportista)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtDni)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.txtInscripcion)
        Me.TabPage2.Controls.Add(Me.txtModelo)
        Me.TabPage2.Controls.Add(Me.txtBrevete)
        Me.TabPage2.Controls.Add(Me.txtPlaca)
        Me.TabPage2.Controls.Add(Me.txtTelefono)
        Me.TabPage2.Controls.Add(Me.txtDireccion)
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtRuc)
        Me.TabPage2.Controls.Add(Me.txtCodigo)
        Me.TabPage2.ForeColor = System.Drawing.Color.Navy
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(525, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edición de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(267, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(267, 183)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "N° de Inscripción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Modelo Vehiculo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Brevete"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Placa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RUC"
        '
        'txtDni
        '
        Me.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDni.Location = New System.Drawing.Point(223, 27)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTelEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtDirEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtRucEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtNomEmpresa)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 109)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Empresa"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(345, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Teléfono"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Dirección"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(345, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "RUC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Razón Social"
        '
        'txtTelEmpresa
        '
        Me.txtTelEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelEmpresa.Location = New System.Drawing.Point(345, 77)
        Me.txtTelEmpresa.Name = "txtTelEmpresa"
        Me.txtTelEmpresa.Size = New System.Drawing.Size(143, 20)
        Me.txtTelEmpresa.TabIndex = 3
        '
        'txtDirEmpresa
        '
        Me.txtDirEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirEmpresa.Location = New System.Drawing.Point(5, 77)
        Me.txtDirEmpresa.Name = "txtDirEmpresa"
        Me.txtDirEmpresa.Size = New System.Drawing.Size(334, 20)
        Me.txtDirEmpresa.TabIndex = 2
        '
        'txtRucEmpresa
        '
        Me.txtRucEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRucEmpresa.Location = New System.Drawing.Point(345, 38)
        Me.txtRucEmpresa.Name = "txtRucEmpresa"
        Me.txtRucEmpresa.Size = New System.Drawing.Size(143, 20)
        Me.txtRucEmpresa.TabIndex = 1
        '
        'txtNomEmpresa
        '
        Me.txtNomEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomEmpresa.Location = New System.Drawing.Point(5, 38)
        Me.txtNomEmpresa.Name = "txtNomEmpresa"
        Me.txtNomEmpresa.Size = New System.Drawing.Size(334, 20)
        Me.txtNomEmpresa.TabIndex = 0
        '
        'txtInscripcion
        '
        Me.txtInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInscripcion.Location = New System.Drawing.Point(139, 183)
        Me.txtInscripcion.Name = "txtInscripcion"
        Me.txtInscripcion.Size = New System.Drawing.Size(122, 20)
        Me.txtInscripcion.TabIndex = 8
        '
        'txtModelo
        '
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModelo.Location = New System.Drawing.Point(11, 183)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(122, 20)
        Me.txtModelo.TabIndex = 7
        '
        'txtBrevete
        '
        Me.txtBrevete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrevete.Location = New System.Drawing.Point(267, 144)
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Size = New System.Drawing.Size(122, 20)
        Me.txtBrevete.TabIndex = 6
        '
        'txtPlaca
        '
        Me.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlaca.Location = New System.Drawing.Point(139, 144)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(122, 20)
        Me.txtPlaca.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Location = New System.Drawing.Point(11, 144)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(122, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(11, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(312, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(11, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(312, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtRuc
        '
        Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuc.Location = New System.Drawing.Point(117, 27)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtRuc.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(11, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(545, 25)
        Me.ToolStrip1.TabIndex = 53
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'frm_Transportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 397)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Transportista"
        Me.Text = "Transportista"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents bsTransportista As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RucDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtDirEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtRucEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtInscripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtBrevete As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
End Class
