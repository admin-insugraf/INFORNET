<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCentroCosto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCentroCosto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtdecripcionHaber = New System.Windows.Forms.TextBox()
        Me.txtdescripcionDebe = New System.Windows.Forms.TextBox()
        Me.txtcuentaDebe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcuentaHaber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.checkTipo = New System.Windows.Forms.CheckBox()
        Me.checkEstado = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnode_key = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnode_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbDestino.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbDestino)
        Me.GroupBox1.Controls.Add(Me.checkTipo)
        Me.GroupBox1.Controls.Add(Me.checkEstado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtLevel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtnode_key)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnode_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 281)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.PictureBox8)
        Me.gbDestino.Controls.Add(Me.PictureBox7)
        Me.gbDestino.Controls.Add(Me.txtdecripcionHaber)
        Me.gbDestino.Controls.Add(Me.txtdescripcionDebe)
        Me.gbDestino.Controls.Add(Me.txtcuentaDebe)
        Me.gbDestino.Controls.Add(Me.Label5)
        Me.gbDestino.Controls.Add(Me.txtcuentaHaber)
        Me.gbDestino.Controls.Add(Me.Label7)
        Me.gbDestino.Enabled = False
        Me.gbDestino.ForeColor = System.Drawing.Color.Navy
        Me.gbDestino.Location = New System.Drawing.Point(20, 191)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(436, 81)
        Me.gbDestino.TabIndex = 49
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "&Destinos :  Cuentas Contables"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(138, 50)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox8.TabIndex = 132
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(138, 20)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 131
        Me.PictureBox7.TabStop = False
        '
        'txtdecripcionHaber
        '
        Me.txtdecripcionHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdecripcionHaber.Location = New System.Drawing.Point(162, 48)
        Me.txtdecripcionHaber.Name = "txtdecripcionHaber"
        Me.txtdecripcionHaber.ReadOnly = True
        Me.txtdecripcionHaber.Size = New System.Drawing.Size(263, 20)
        Me.txtdecripcionHaber.TabIndex = 130
        '
        'txtdescripcionDebe
        '
        Me.txtdescripcionDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionDebe.Location = New System.Drawing.Point(162, 20)
        Me.txtdescripcionDebe.Name = "txtdescripcionDebe"
        Me.txtdescripcionDebe.ReadOnly = True
        Me.txtdescripcionDebe.Size = New System.Drawing.Size(263, 20)
        Me.txtdescripcionDebe.TabIndex = 129
        '
        'txtcuentaDebe
        '
        Me.txtcuentaDebe.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaDebe.Location = New System.Drawing.Point(64, 19)
        Me.txtcuentaDebe.Name = "txtcuentaDebe"
        Me.txtcuentaDebe.ReadOnly = True
        Me.txtcuentaDebe.Size = New System.Drawing.Size(68, 20)
        Me.txtcuentaDebe.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(10, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "_Haber"
        '
        'txtcuentaHaber
        '
        Me.txtcuentaHaber.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaHaber.Location = New System.Drawing.Point(64, 49)
        Me.txtcuentaHaber.Name = "txtcuentaHaber"
        Me.txtcuentaHaber.ReadOnly = True
        Me.txtcuentaHaber.Size = New System.Drawing.Size(68, 20)
        Me.txtcuentaHaber.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(13, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "_Debe"
        '
        'checkTipo
        '
        Me.checkTipo.AutoSize = True
        Me.checkTipo.ForeColor = System.Drawing.Color.Navy
        Me.checkTipo.Location = New System.Drawing.Point(23, 168)
        Me.checkTipo.Name = "checkTipo"
        Me.checkTipo.Size = New System.Drawing.Size(129, 17)
        Me.checkTipo.TabIndex = 49
        Me.checkTipo.Text = "&Tipo Cuenta Contable"
        Me.checkTipo.UseVisualStyleBackColor = True
        '
        'checkEstado
        '
        Me.checkEstado.AutoSize = True
        Me.checkEstado.Checked = True
        Me.checkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkEstado.ForeColor = System.Drawing.Color.Navy
        Me.checkEstado.Location = New System.Drawing.Point(297, 140)
        Me.checkEstado.Name = "checkEstado"
        Me.checkEstado.Size = New System.Drawing.Size(105, 17)
        Me.checkEstado.TabIndex = 33
        Me.checkEstado.Text = "Activo / Inactivo"
        Me.checkEstado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(246, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "&Estado"
        '
        'txtLevel
        '
        Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLevel.Location = New System.Drawing.Point(84, 137)
        Me.txtLevel.MaxLength = 1
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(152, 20)
        Me.txtLevel.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(13, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "&Level_Cost"
        '
        'txtnode_key
        '
        Me.txtnode_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnode_key.Location = New System.Drawing.Point(84, 108)
        Me.txtnode_key.Name = "txtnode_key"
        Me.txtnode_key.Size = New System.Drawing.Size(361, 20)
        Me.txtnode_key.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(17, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "&Node_key"
        '
        'txtnode_id
        '
        Me.txtnode_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnode_id.Location = New System.Drawing.Point(84, 79)
        Me.txtnode_id.Name = "txtnode_id"
        Me.txtnode_id.Size = New System.Drawing.Size(152, 20)
        Me.txtnode_id.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(25, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Node_Id"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Location = New System.Drawing.Point(84, 49)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(361, 20)
        Me.txtdescripcion.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "&Descripcion "
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(84, 16)
        Me.txtcodigo.MaxLength = 41
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtcodigo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(33, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "&Codigo"
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcabecera.Controls.Add(Me.lblCantidad)
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(10, 29)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(468, 313)
        Me.pnlcabecera.TabIndex = 32
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(17, 283)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 119
        Me.lblCantidad.Text = "."
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 56)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(433, 219)
        Me.dgvCabecera.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(462, 45)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(438, 21)
        Me.txtFiltro.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(490, 25)
        Me.ToolStrip1.TabIndex = 121
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
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
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
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'FrmCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 350)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.pnlcabecera)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcabecera.ResumeLayout(False)
        Me.pnlcabecera.PerformLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents txtcuentaDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcuentaHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnode_key As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnode_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Friend WithEvents checkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdecripcionHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionDebe As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Public WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Public WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Public WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Public WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
End Class
