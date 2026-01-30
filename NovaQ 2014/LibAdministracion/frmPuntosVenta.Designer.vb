<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuntosVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPuntosVenta))
        Me.tcPtoVenta = New System.Windows.Forms.TabControl()
        Me.tpListado = New System.Windows.Forms.TabPage()
        Me.dgwPuntosVenta = New System.Windows.Forms.DataGridView()
        Me.tpDatos = New System.Windows.Forms.TabPage()
        Me.gbDocPtoVenta = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgwDocumentos = New System.Windows.Forms.DataGridView()
        Me.gbPtoVenta = New System.Windows.Forms.GroupBox()
        Me.cbAlmacen = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.tcPtoVenta.SuspendLayout()
        Me.tpListado.SuspendLayout()
        CType(Me.dgwPuntosVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDatos.SuspendLayout()
        Me.gbDocPtoVenta.SuspendLayout()
        CType(Me.dgwDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPtoVenta.SuspendLayout()
        Me.ToolOpc.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcPtoVenta
        '
        Me.tcPtoVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPtoVenta.Controls.Add(Me.tpListado)
        Me.tcPtoVenta.Controls.Add(Me.tpDatos)
        Me.tcPtoVenta.Location = New System.Drawing.Point(12, 38)
        Me.tcPtoVenta.Name = "tcPtoVenta"
        Me.tcPtoVenta.SelectedIndex = 0
        Me.tcPtoVenta.Size = New System.Drawing.Size(504, 394)
        Me.tcPtoVenta.TabIndex = 9
        '
        'tpListado
        '
        Me.tpListado.Controls.Add(Me.dgwPuntosVenta)
        Me.tpListado.Location = New System.Drawing.Point(4, 22)
        Me.tpListado.Name = "tpListado"
        Me.tpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListado.Size = New System.Drawing.Size(496, 368)
        Me.tpListado.TabIndex = 0
        Me.tpListado.Text = "Listado de puntos de venta"
        Me.tpListado.UseVisualStyleBackColor = True
        '
        'dgwPuntosVenta
        '
        Me.dgwPuntosVenta.AllowUserToAddRows = False
        Me.dgwPuntosVenta.AllowUserToDeleteRows = False
        Me.dgwPuntosVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwPuntosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPuntosVenta.Location = New System.Drawing.Point(14, 17)
        Me.dgwPuntosVenta.Name = "dgwPuntosVenta"
        Me.dgwPuntosVenta.ReadOnly = True
        Me.dgwPuntosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPuntosVenta.Size = New System.Drawing.Size(466, 334)
        Me.dgwPuntosVenta.TabIndex = 0
        '
        'tpDatos
        '
        Me.tpDatos.Controls.Add(Me.gbDocPtoVenta)
        Me.tpDatos.Controls.Add(Me.gbPtoVenta)
        Me.tpDatos.Location = New System.Drawing.Point(4, 22)
        Me.tpDatos.Name = "tpDatos"
        Me.tpDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDatos.Size = New System.Drawing.Size(496, 368)
        Me.tpDatos.TabIndex = 1
        Me.tpDatos.Text = "Datos punto de venta"
        Me.tpDatos.UseVisualStyleBackColor = True
        '
        'gbDocPtoVenta
        '
        Me.gbDocPtoVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDocPtoVenta.Controls.Add(Me.btnQuitar)
        Me.gbDocPtoVenta.Controls.Add(Me.btnAgregar)
        Me.gbDocPtoVenta.Controls.Add(Me.dgwDocumentos)
        Me.gbDocPtoVenta.ForeColor = System.Drawing.Color.Navy
        Me.gbDocPtoVenta.Location = New System.Drawing.Point(14, 186)
        Me.gbDocPtoVenta.Name = "gbDocPtoVenta"
        Me.gbDocPtoVenta.Size = New System.Drawing.Size(467, 176)
        Me.gbDocPtoVenta.TabIndex = 10
        Me.gbDocPtoVenta.TabStop = False
        Me.gbDocPtoVenta.Text = "Documentos por punto de venta"
        '
        'btnQuitar
        '
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Image = CType(resources.GetObject("btnQuitar.Image"), System.Drawing.Image)
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(382, 56)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(71, 23)
        Me.btnQuitar.TabIndex = 1
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(383, 29)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(71, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgwDocumentos
        '
        Me.dgwDocumentos.AllowUserToAddRows = False
        Me.dgwDocumentos.AllowUserToDeleteRows = False
        Me.dgwDocumentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgwDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDocumentos.Location = New System.Drawing.Point(6, 21)
        Me.dgwDocumentos.Name = "dgwDocumentos"
        Me.dgwDocumentos.ReadOnly = True
        Me.dgwDocumentos.Size = New System.Drawing.Size(371, 143)
        Me.dgwDocumentos.TabIndex = 0
        '
        'gbPtoVenta
        '
        Me.gbPtoVenta.Controls.Add(Me.cbAlmacen)
        Me.gbPtoVenta.Controls.Add(Me.txtDireccion)
        Me.gbPtoVenta.Controls.Add(Me.txtDescripcion)
        Me.gbPtoVenta.Controls.Add(Me.txtCodigo)
        Me.gbPtoVenta.Controls.Add(Me.Label4)
        Me.gbPtoVenta.Controls.Add(Me.Label3)
        Me.gbPtoVenta.Controls.Add(Me.Label2)
        Me.gbPtoVenta.Controls.Add(Me.Label1)
        Me.gbPtoVenta.ForeColor = System.Drawing.Color.Navy
        Me.gbPtoVenta.Location = New System.Drawing.Point(13, 13)
        Me.gbPtoVenta.Name = "gbPtoVenta"
        Me.gbPtoVenta.Size = New System.Drawing.Size(468, 158)
        Me.gbPtoVenta.TabIndex = 9
        Me.gbPtoVenta.TabStop = False
        Me.gbPtoVenta.Text = "Datos de punto de venta"
        '
        'cbAlmacen
        '
        Me.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlmacen.FormattingEnabled = True
        Me.cbAlmacen.Location = New System.Drawing.Point(131, 122)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Size = New System.Drawing.Size(331, 21)
        Me.cbAlmacen.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(131, 87)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(331, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(331, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(130, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(71, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Almacén"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código"
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolEditar, Me.ToolGrabar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(529, 25)
        Me.ToolOpc.TabIndex = 22
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.Image = CType(resources.GetObject("ToolNuevo.Image"), System.Drawing.Image)
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(62, 22)
        Me.ToolNuevo.Text = "Nuevo"
        Me.ToolNuevo.ToolTipText = "Nuevo"
        '
        'ToolEditar
        '
        Me.ToolEditar.Image = CType(resources.GetObject("ToolEditar.Image"), System.Drawing.Image)
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(79, 22)
        Me.ToolEditar.Text = "Modificar"
        Me.ToolEditar.ToolTipText = "Editar"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Enabled = False
        Me.ToolGrabar.Image = CType(resources.GetObject("ToolGrabar.Image"), System.Drawing.Image)
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(73, 22)
        Me.ToolGrabar.Text = "Guardar"
        Me.ToolGrabar.ToolTipText = "Guardar"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Enabled = False
        Me.ToolCancelar.Image = CType(resources.GetObject("ToolCancelar.Image"), System.Drawing.Image)
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(76, 22)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(52, 22)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'frmPuntosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 444)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.tcPtoVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPuntosVenta"
        Me.Text = "Puntos de venta"
        Me.tcPtoVenta.ResumeLayout(False)
        Me.tpListado.ResumeLayout(False)
        CType(Me.dgwPuntosVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDatos.ResumeLayout(False)
        Me.gbDocPtoVenta.ResumeLayout(False)
        CType(Me.dgwDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPtoVenta.ResumeLayout(False)
        Me.gbPtoVenta.PerformLayout()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcPtoVenta As System.Windows.Forms.TabControl
    Friend WithEvents tpListado As System.Windows.Forms.TabPage
    Friend WithEvents dgwPuntosVenta As System.Windows.Forms.DataGridView
    Friend WithEvents tpDatos As System.Windows.Forms.TabPage
    Friend WithEvents gbPtoVenta As System.Windows.Forms.GroupBox
    Friend WithEvents cbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbDocPtoVenta As System.Windows.Forms.GroupBox
    Friend WithEvents dgwDocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
