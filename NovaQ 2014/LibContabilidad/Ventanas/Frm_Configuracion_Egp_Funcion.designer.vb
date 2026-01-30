<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Configuracion_Egp_Funcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Configuracion_Egp_Funcion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlDetalleconcepto = New System.Windows.Forms.Panel()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.pnlcabeceraConcepto = New System.Windows.Forms.Panel()
        Me.txtdescripcionConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_des_cta = New System.Windows.Forms.TextBox()
        Me.txtcodigoConcepto = New System.Windows.Forms.TextBox()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.ToolStrip()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnsalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetalleconcepto.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcabeceraConcepto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnlcabecera)
        Me.GroupBox1.Controls.Add(Me.pnlDetalleconcepto)
        Me.GroupBox1.Controls.Add(Me.pnlcabeceraConcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 341)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(9, 19)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(564, 316)
        Me.pnlcabecera.TabIndex = 38
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 14)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(535, 296)
        Me.dgvCabecera.TabIndex = 0
        '
        'pnlDetalleconcepto
        '
        Me.pnlDetalleconcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlDetalleconcepto.Controls.Add(Me.dgvDetalle)
        Me.pnlDetalleconcepto.Controls.Add(Me.btneliminar)
        Me.pnlDetalleconcepto.Controls.Add(Me.Label3)
        Me.pnlDetalleconcepto.Controls.Add(Me.btnmodificar)
        Me.pnlDetalleconcepto.Controls.Add(Me.btninsertar)
        Me.pnlDetalleconcepto.Location = New System.Drawing.Point(9, 97)
        Me.pnlDetalleconcepto.Name = "pnlDetalleconcepto"
        Me.pnlDetalleconcepto.Size = New System.Drawing.Size(563, 238)
        Me.pnlDetalleconcepto.TabIndex = 39
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(11, 36)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(542, 194)
        Me.dgvDetalle.TabIndex = 1
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.Location = New System.Drawing.Point(474, 4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(79, 26)
        Me.btneliminar.TabIndex = 124
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Detalles de los Registros"
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.Location = New System.Drawing.Point(377, 51)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 40)
        Me.btnmodificar.TabIndex = 123
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.UseVisualStyleBackColor = True
        Me.btnmodificar.Visible = False
        '
        'btninsertar
        '
        Me.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertar.Image = CType(resources.GetObject("btninsertar.Image"), System.Drawing.Image)
        Me.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btninsertar.Location = New System.Drawing.Point(386, 4)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(79, 26)
        Me.btninsertar.TabIndex = 119
        Me.btninsertar.Text = "&Adicionar"
        Me.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'pnlcabeceraConcepto
        '
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtdescripcionConcepto)
        Me.pnlcabeceraConcepto.Controls.Add(Me.Label1)
        Me.pnlcabeceraConcepto.Controls.Add(Me.PictureBox1)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txt_des_cta)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtcodigoConcepto)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtCuentaContable)
        Me.pnlcabeceraConcepto.Controls.Add(Me.PictureBox6)
        Me.pnlcabeceraConcepto.Controls.Add(Me.Label2)
        Me.pnlcabeceraConcepto.Location = New System.Drawing.Point(9, 19)
        Me.pnlcabeceraConcepto.Name = "pnlcabeceraConcepto"
        Me.pnlcabeceraConcepto.Size = New System.Drawing.Size(563, 72)
        Me.pnlcabeceraConcepto.TabIndex = 39
        '
        'txtdescripcionConcepto
        '
        Me.txtdescripcionConcepto.BackColor = System.Drawing.Color.White
        Me.txtdescripcionConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionConcepto.Location = New System.Drawing.Point(210, 12)
        Me.txtdescripcionConcepto.Name = "txtdescripcionConcepto"
        Me.txtdescripcionConcepto.ReadOnly = True
        Me.txtdescripcionConcepto.Size = New System.Drawing.Size(343, 20)
        Me.txtdescripcionConcepto.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concepto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'txt_des_cta
        '
        Me.txt_des_cta.BackColor = System.Drawing.Color.White
        Me.txt_des_cta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_cta.Location = New System.Drawing.Point(210, 38)
        Me.txt_des_cta.Name = "txt_des_cta"
        Me.txt_des_cta.ReadOnly = True
        Me.txt_des_cta.Size = New System.Drawing.Size(343, 20)
        Me.txt_des_cta.TabIndex = 114
        '
        'txtcodigoConcepto
        '
        Me.txtcodigoConcepto.BackColor = System.Drawing.Color.White
        Me.txtcodigoConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoConcepto.Location = New System.Drawing.Point(96, 12)
        Me.txtcodigoConcepto.Name = "txtcodigoConcepto"
        Me.txtcodigoConcepto.ReadOnly = True
        Me.txtcodigoConcepto.Size = New System.Drawing.Size(90, 20)
        Me.txtcodigoConcepto.TabIndex = 121
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContable.Location = New System.Drawing.Point(96, 38)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(90, 20)
        Me.txtCuentaContable.TabIndex = 115
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(190, 39)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 116
        Me.PictureBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Cuenta Contable"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(315, 63)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(69, 52)
        Me.btn_eliminar.TabIndex = 42
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        Me.btn_eliminar.Visible = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Nuevo.Location = New System.Drawing.Point(114, 64)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(69, 52)
        Me.btn_Nuevo.TabIndex = 44
        Me.btn_Nuevo.Tag = "Nuevo Registro"
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        Me.btn_Nuevo.Visible = False
        '
        'btn_menu
        '
        Me.btn_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.btnGrabar, Me.btnCancelar, Me.btnsalir})
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(602, 25)
        Me.btn_menu.TabIndex = 200
        Me.btn_menu.Text = "ToolStrip1"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 22)
        Me.btnConsultar.Text = "&Consultar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 22)
        Me.btnGrabar.Text = "&Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(52, 22)
        Me.btnsalir.Text = "&Salir"
        '
        'Frm_Configuracion_Egp_Funcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 378)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Configuracion_Egp_Funcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de E.G.P. por Función"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetalleconcepto.ResumeLayout(False)
        Me.pnlDetalleconcepto.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcabeceraConcepto.ResumeLayout(False)
        Me.pnlcabeceraConcepto.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_menu.ResumeLayout(False)
        Me.btn_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDetalleconcepto As System.Windows.Forms.Panel
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btninsertar As System.Windows.Forms.Button
    Friend WithEvents pnlcabeceraConcepto As System.Windows.Forms.Panel
    Private WithEvents txtdescripcionConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txt_des_cta As System.Windows.Forms.TextBox
    Private WithEvents txtcodigoConcepto As System.Windows.Forms.TextBox
    Private WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_menu As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsalir As System.Windows.Forms.ToolStripButton
End Class
