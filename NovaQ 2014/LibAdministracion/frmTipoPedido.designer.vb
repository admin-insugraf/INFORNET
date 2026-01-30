<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.dgTiposPedido = New System.Windows.Forms.DataGridView()
        Me.gbTipoPedido = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpTransacciones = New System.Windows.Forms.GroupBox()
        Me.checkVincularTodos = New System.Windows.Forms.CheckBox()
        Me.chklstTransacciones = New System.Windows.Forms.CheckedListBox()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.ToolOpc.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgTiposPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTipoPedido.SuspendLayout()
        Me.GrpTransacciones.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolEditar, Me.ToolGrabar, Me.btn_eliminar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(699, 25)
        Me.ToolOpc.TabIndex = 16
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolNuevo.Image = CType(resources.GetObject("ToolNuevo.Image"), System.Drawing.Image)
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(62, 22)
        Me.ToolNuevo.Text = "&Nuevo"
        Me.ToolNuevo.ToolTipText = "Nuevo usuario"
        '
        'ToolEditar
        '
        Me.ToolEditar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolEditar.Image = CType(resources.GetObject("ToolEditar.Image"), System.Drawing.Image)
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(120, 22)
        Me.ToolEditar.Text = "&Consultar/Editar"
        Me.ToolEditar.ToolTipText = "Editar usuario"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolGrabar.Image = CType(resources.GetObject("ToolGrabar.Image"), System.Drawing.Image)
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(73, 22)
        Me.ToolGrabar.Text = "&Guardar"
        Me.ToolGrabar.ToolTipText = "Guardar usuario"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.ToolTipText = "Salir"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolCancelar.Image = CType(resources.GetObject("ToolCancelar.Image"), System.Drawing.Image)
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(76, 22)
        Me.ToolCancelar.Text = "C&ancelar"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(52, 22)
        Me.ToolSalir.Text = "&Salir"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Doble clic para editar"
        Me.Label8.Visible = False
        '
        'gbListado
        '
        Me.gbListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListado.Controls.Add(Me.Label8)
        Me.gbListado.Controls.Add(Me.dgTiposPedido)
        Me.gbListado.ForeColor = System.Drawing.Color.Navy
        Me.gbListado.Location = New System.Drawing.Point(18, 8)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(639, 553)
        Me.gbListado.TabIndex = 27
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "Listado "
        '
        'dgTiposPedido
        '
        Me.dgTiposPedido.AllowUserToAddRows = False
        Me.dgTiposPedido.AllowUserToDeleteRows = False
        Me.dgTiposPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTiposPedido.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgTiposPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTiposPedido.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgTiposPedido.Location = New System.Drawing.Point(9, 17)
        Me.dgTiposPedido.Name = "dgTiposPedido"
        Me.dgTiposPedido.ReadOnly = True
        Me.dgTiposPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTiposPedido.Size = New System.Drawing.Size(620, 524)
        Me.dgTiposPedido.TabIndex = 19
        '
        'gbTipoPedido
        '
        Me.gbTipoPedido.Controls.Add(Me.txtDescripcion)
        Me.gbTipoPedido.Controls.Add(Me.txtCodigo)
        Me.gbTipoPedido.Controls.Add(Me.Label2)
        Me.gbTipoPedido.Controls.Add(Me.Label1)
        Me.gbTipoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gbTipoPedido.ForeColor = System.Drawing.Color.Navy
        Me.gbTipoPedido.Location = New System.Drawing.Point(24, 37)
        Me.gbTipoPedido.Name = "gbTipoPedido"
        Me.gbTipoPedido.Size = New System.Drawing.Size(659, 85)
        Me.gbTipoPedido.TabIndex = 24
        Me.gbTipoPedido.TabStop = False
        Me.gbTipoPedido.Text = "Datos "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(70, 35)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(357, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(10, 35)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(70, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Código"
        '
        'GrpTransacciones
        '
        Me.GrpTransacciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpTransacciones.Controls.Add(Me.checkVincularTodos)
        Me.GrpTransacciones.Controls.Add(Me.chklstTransacciones)
        Me.GrpTransacciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrpTransacciones.ForeColor = System.Drawing.Color.Navy
        Me.GrpTransacciones.Location = New System.Drawing.Point(24, 147)
        Me.GrpTransacciones.Name = "GrpTransacciones"
        Me.GrpTransacciones.Size = New System.Drawing.Size(427, 458)
        Me.GrpTransacciones.TabIndex = 28
        Me.GrpTransacciones.TabStop = False
        Me.GrpTransacciones.Text = "Vincular Transacciones"
        '
        'checkVincularTodos
        '
        Me.checkVincularTodos.AutoSize = True
        Me.checkVincularTodos.ForeColor = System.Drawing.Color.Navy
        Me.checkVincularTodos.Location = New System.Drawing.Point(18, 17)
        Me.checkVincularTodos.Name = "checkVincularTodos"
        Me.checkVincularTodos.Size = New System.Drawing.Size(97, 17)
        Me.checkVincularTodos.TabIndex = 7
        Me.checkVincularTodos.Text = "Vincular Todos"
        Me.checkVincularTodos.UseVisualStyleBackColor = True
        '
        'chklstTransacciones
        '
        Me.chklstTransacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstTransacciones.CheckOnClick = True
        Me.chklstTransacciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstTransacciones.FormattingEnabled = True
        Me.chklstTransacciones.Location = New System.Drawing.Point(16, 45)
        Me.chklstTransacciones.Name = "chklstTransacciones"
        Me.chklstTransacciones.Size = New System.Drawing.Size(394, 394)
        Me.chklstTransacciones.TabIndex = 6
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.Controls.Add(Me.gbListado)
        Me.pnlPrincipal.Location = New System.Drawing.Point(15, 37)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(674, 571)
        Me.pnlPrincipal.TabIndex = 29
        '
        'frmTipoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 620)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.GrpTransacciones)
        Me.Controls.Add(Me.gbTipoPedido)
        Me.Controls.Add(Me.ToolOpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTipoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Pedido"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        CType(Me.dgTiposPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTipoPedido.ResumeLayout(False)
        Me.gbTipoPedido.PerformLayout()
        Me.GrpTransacciones.ResumeLayout(False)
        Me.GrpTransacciones.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbListado As System.Windows.Forms.GroupBox
    Friend WithEvents dgTiposPedido As System.Windows.Forms.DataGridView
    Friend WithEvents gbTipoPedido As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpTransacciones As System.Windows.Forms.GroupBox
    Friend WithEvents checkVincularTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chklstTransacciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
End Class
