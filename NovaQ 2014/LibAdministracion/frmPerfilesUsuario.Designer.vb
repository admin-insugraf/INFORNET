<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfilesUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfilesUsuario))
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.tcPerfiles = New System.Windows.Forms.TabControl()
        Me.tpListaPerfil = New System.Windows.Forms.TabPage()
        Me.dgwPerfiles = New System.Windows.Forms.DataGridView()
        Me.tpAccesos = New System.Windows.Forms.TabPage()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbHabilitado = New System.Windows.Forms.ComboBox()
        Me.txtDesPerfil = New System.Windows.Forms.TextBox()
        Me.txtCodPerfil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tvAccesos = New System.Windows.Forms.TreeView()
        Me.ToolOpc.SuspendLayout()
        Me.tcPerfiles.SuspendLayout()
        Me.tpListaPerfil.SuspendLayout()
        CType(Me.dgwPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAccesos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolGrabar, Me.ToolEditar, Me.btn_eliminar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(527, 25)
        Me.ToolOpc.TabIndex = 24
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.ForeColor = System.Drawing.Color.Black
        Me.ToolNuevo.Image = CType(resources.GetObject("ToolNuevo.Image"), System.Drawing.Image)
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(65, 22)
        Me.ToolNuevo.Text = "Nuevo "
        Me.ToolNuevo.ToolTipText = "Nuevo "
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolGrabar.ForeColor = System.Drawing.Color.Black
        Me.ToolGrabar.Image = CType(resources.GetObject("ToolGrabar.Image"), System.Drawing.Image)
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(66, 22)
        Me.ToolGrabar.Text = "Grabar"
        Me.ToolGrabar.ToolTipText = "Guardar perfil"
        '
        'ToolEditar
        '
        Me.ToolEditar.ForeColor = System.Drawing.Color.Black
        Me.ToolEditar.Image = CType(resources.GetObject("ToolEditar.Image"), System.Drawing.Image)
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(66, 22)
        Me.ToolEditar.Text = "Editar  "
        Me.ToolEditar.ToolTipText = "Editar  "
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(69, 22)
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.ToolTipText = "Eliminar"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolCancelar.ForeColor = System.Drawing.Color.Black
        Me.ToolCancelar.Image = CType(resources.GetObject("ToolCancelar.Image"), System.Drawing.Image)
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(71, 22)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSalir.ForeColor = System.Drawing.Color.Black
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(51, 22)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'tcPerfiles
        '
        Me.tcPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPerfiles.Controls.Add(Me.tpListaPerfil)
        Me.tcPerfiles.Controls.Add(Me.tpAccesos)
        Me.tcPerfiles.Location = New System.Drawing.Point(12, 37)
        Me.tcPerfiles.Name = "tcPerfiles"
        Me.tcPerfiles.SelectedIndex = 0
        Me.tcPerfiles.Size = New System.Drawing.Size(498, 502)
        Me.tcPerfiles.TabIndex = 26
        '
        'tpListaPerfil
        '
        Me.tpListaPerfil.Controls.Add(Me.dgwPerfiles)
        Me.tpListaPerfil.Location = New System.Drawing.Point(4, 22)
        Me.tpListaPerfil.Name = "tpListaPerfil"
        Me.tpListaPerfil.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListaPerfil.Size = New System.Drawing.Size(490, 476)
        Me.tpListaPerfil.TabIndex = 0
        Me.tpListaPerfil.Text = "Listado de perfiles"
        Me.tpListaPerfil.UseVisualStyleBackColor = True
        '
        'dgwPerfiles
        '
        Me.dgwPerfiles.AllowUserToAddRows = False
        Me.dgwPerfiles.AllowUserToDeleteRows = False
        Me.dgwPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPerfiles.Location = New System.Drawing.Point(15, 16)
        Me.dgwPerfiles.Name = "dgwPerfiles"
        Me.dgwPerfiles.ReadOnly = True
        Me.dgwPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPerfiles.Size = New System.Drawing.Size(459, 444)
        Me.dgwPerfiles.TabIndex = 0
        '
        'tpAccesos
        '
        Me.tpAccesos.BackColor = System.Drawing.Color.White
        Me.tpAccesos.Controls.Add(Me.chkTodos)
        Me.tpAccesos.Controls.Add(Me.GroupBox1)
        Me.tpAccesos.Controls.Add(Me.tvAccesos)
        Me.tpAccesos.Location = New System.Drawing.Point(4, 22)
        Me.tpAccesos.Name = "tpAccesos"
        Me.tpAccesos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccesos.Size = New System.Drawing.Size(490, 476)
        Me.tpAccesos.TabIndex = 1
        Me.tpAccesos.Text = "Accesos por perfil"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.ForeColor = System.Drawing.Color.Navy
        Me.chkTodos.Location = New System.Drawing.Point(19, 109)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(88, 17)
        Me.chkTodos.TabIndex = 28
        Me.chkTodos.Text = "Marcar todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbHabilitado)
        Me.GroupBox1.Controls.Add(Me.txtDesPerfil)
        Me.GroupBox1.Controls.Add(Me.txtCodPerfil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(17, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 95)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de perfil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Habilitado"
        '
        'cbHabilitado
        '
        Me.cbHabilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHabilitado.FormattingEnabled = True
        Me.cbHabilitado.Items.AddRange(New Object() {"SI", "NO"})
        Me.cbHabilitado.Location = New System.Drawing.Point(116, 66)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(183, 21)
        Me.cbHabilitado.TabIndex = 2
        '
        'txtDesPerfil
        '
        Me.txtDesPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesPerfil.Location = New System.Drawing.Point(116, 40)
        Me.txtDesPerfil.Name = "txtDesPerfil"
        Me.txtDesPerfil.Size = New System.Drawing.Size(296, 20)
        Me.txtDesPerfil.TabIndex = 1
        '
        'txtCodPerfil
        '
        Me.txtCodPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPerfil.Enabled = False
        Me.txtCodPerfil.Location = New System.Drawing.Point(116, 14)
        Me.txtCodPerfil.Name = "txtCodPerfil"
        Me.txtCodPerfil.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPerfil.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción de perfil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código de perfil"
        '
        'tvAccesos
        '
        Me.tvAccesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvAccesos.CheckBoxes = True
        Me.tvAccesos.Location = New System.Drawing.Point(17, 129)
        Me.tvAccesos.Name = "tvAccesos"
        Me.tvAccesos.Size = New System.Drawing.Size(453, 341)
        Me.tvAccesos.TabIndex = 26
        '
        'frmPerfilesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 553)
        Me.Controls.Add(Me.tcPerfiles)
        Me.Controls.Add(Me.ToolOpc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPerfilesUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación de perfiles de usuario"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.tcPerfiles.ResumeLayout(False)
        Me.tpListaPerfil.ResumeLayout(False)
        CType(Me.dgwPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAccesos.ResumeLayout(False)
        Me.tpAccesos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tcPerfiles As System.Windows.Forms.TabControl
    Friend WithEvents tpListaPerfil As System.Windows.Forms.TabPage
    Friend WithEvents dgwPerfiles As System.Windows.Forms.DataGridView
    Friend WithEvents tpAccesos As System.Windows.Forms.TabPage
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbHabilitado As System.Windows.Forms.ComboBox
    Friend WithEvents txtDesPerfil As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPerfil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tvAccesos As System.Windows.Forms.TreeView
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
End Class
