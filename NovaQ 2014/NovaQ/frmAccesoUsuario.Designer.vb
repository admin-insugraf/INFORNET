<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesoUsuario
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
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tvAccesos = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.ToolOpc.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolGrabar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(486, 25)
        Me.ToolOpc.TabIndex = 20
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolGrabar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolGrabar.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolGrabar.Image = Global.AppNovaQ.My.Resources.Resource1.grabar1
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(23, 22)
        Me.ToolGrabar.Text = "Grabar"
        Me.ToolGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolGrabar.ToolTipText = "Guardar accesos"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolCancelar.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolCancelar.Image = Global.AppNovaQ.My.Resources.Resource1.cancelar
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(23, 22)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSalir.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolSalir.Image = Global.AppNovaQ.My.Resources.Resource1.exit_26
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(23, 22)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(75, 45)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(274, 21)
        Me.cboUsuario.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Usuario"
        '
        'tvAccesos
        '
        Me.tvAccesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvAccesos.CheckBoxes = True
        Me.tvAccesos.Location = New System.Drawing.Point(18, 113)
        Me.tvAccesos.Name = "tvAccesos"
        Me.tvAccesos.Size = New System.Drawing.Size(453, 423)
        Me.tvAccesos.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Perfil"
        '
        'cboPerfil
        '
        Me.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(75, 80)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(274, 21)
        Me.cboPerfil.TabIndex = 26
        '
        'frmAccesoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 548)
        Me.Controls.Add(Me.cboPerfil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tvAccesos)
        Me.Controls.Add(Me.ToolOpc)
        Me.Name = "frmAccesoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso por usuario"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tvAccesos As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPerfil As System.Windows.Forms.ComboBox
End Class
