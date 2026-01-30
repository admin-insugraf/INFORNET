<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyudaVar
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
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.dgvdato = New System.Windows.Forms.DataGridView()
        Me.ToolOpc.SuspendLayout()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(12, 31)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(58, 13)
        Me.lblBuscar.TabIndex = 1
        Me.lblBuscar.Text = "Buscar por"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(12, 57)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(474, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(498, 25)
        Me.ToolOpc.TabIndex = 3
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'tAceptar
        '
        Me.tAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tAceptar.Image = Global.LibVentas.My.Resources.Resources.checkmark_26
        Me.tAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tAceptar.Name = "tAceptar"
        Me.tAceptar.Size = New System.Drawing.Size(23, 22)
        Me.tAceptar.Text = "ToolStripButton1"
        Me.tAceptar.ToolTipText = "Aceptar"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(12, 353)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 13)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "."
        '
        'dgvdato
        '
        Me.dgvdato.AllowUserToAddRows = False
        Me.dgvdato.AllowUserToDeleteRows = False
        Me.dgvdato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdato.Location = New System.Drawing.Point(12, 83)
        Me.dgvdato.Name = "dgvdato"
        Me.dgvdato.ReadOnly = True
        Me.dgvdato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdato.Size = New System.Drawing.Size(474, 267)
        Me.dgvdato.TabIndex = 6
        '
        'frmAyudaVar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 375)
        Me.Controls.Add(Me.dgvdato)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.lblBuscar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAyudaVar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAyudaVar"
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        CType(Me.dgvdato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents tAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dgvdato As System.Windows.Forms.DataGridView
End Class
