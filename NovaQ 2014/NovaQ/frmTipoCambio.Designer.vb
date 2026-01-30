<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCambio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgTipoCambio = New System.Windows.Forms.DataGridView()
        Me.ToolOpc.SuspendLayout()
        CType(Me.dgTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolEditar, Me.ToolGrabar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(384, 25)
        Me.ToolOpc.TabIndex = 21
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolNuevo.Image = Global.AppNovaQ.My.Resources.Resource1.add_file_26
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(23, 22)
        Me.ToolNuevo.Text = "ToolStripButton1"
        Me.ToolNuevo.ToolTipText = "Nuevo"
        '
        'ToolEditar
        '
        Me.ToolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolEditar.Image = Global.AppNovaQ.My.Resources.Resource1.edit_26
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(23, 22)
        Me.ToolEditar.Text = "ToolStripButton1"
        Me.ToolEditar.ToolTipText = "Editar"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolGrabar.Enabled = False
        Me.ToolGrabar.Image = Global.AppNovaQ.My.Resources.Resource1.grabar1
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(23, 22)
        Me.ToolGrabar.Text = "ToolStripButton3"
        Me.ToolGrabar.ToolTipText = "Guardar"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolCancelar.Image = Global.AppNovaQ.My.Resources.Resource1.cancelar
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(23, 22)
        Me.ToolCancelar.Text = "ToolStripButton1"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolSalir.Image = Global.AppNovaQ.My.Resources.Resource1.exit_26
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(23, 22)
        Me.ToolSalir.Text = "ToolStripButton2"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(213, 65)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(96, 23)
        Me.btnRefrescar.TabIndex = 29
        Me.btnRefrescar.Text = "Ver"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Fecha del dia"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(100, 67)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(94, 21)
        Me.dtpFecha.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tipo de Cambio"
        '
        'dgTipoCambio
        '
        Me.dgTipoCambio.AllowUserToAddRows = False
        Me.dgTipoCambio.AllowUserToDeleteRows = False
        Me.dgTipoCambio.AllowUserToOrderColumns = True
        Me.dgTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTipoCambio.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgTipoCambio.Location = New System.Drawing.Point(12, 93)
        Me.dgTipoCambio.Name = "dgTipoCambio"
        Me.dgTipoCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgTipoCambio.Size = New System.Drawing.Size(365, 389)
        Me.dgTipoCambio.TabIndex = 25
        '
        'frmTipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 490)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgTipoCambio)
        Me.Controls.Add(Me.ToolOpc)
        Me.Name = "frmTipoCambio"
        Me.Text = "Tipo de cambio"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        CType(Me.dgTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgTipoCambio As System.Windows.Forms.DataGridView
End Class
