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
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.dgwDatos = New System.Windows.Forms.DataGridView()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.tAceptar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolOpc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(14, 363)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(38, 13)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Label2"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(14, 67)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(547, 20)
        Me.txtFiltro.TabIndex = 8
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(14, 41)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(58, 13)
        Me.lblBuscar.TabIndex = 7
        Me.lblBuscar.Text = "Buscar por"
        '
        'dgwDatos
        '
        Me.dgwDatos.AllowUserToAddRows = False
        Me.dgwDatos.AllowUserToDeleteRows = False
        Me.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDatos.Location = New System.Drawing.Point(14, 93)
        Me.dgwDatos.Name = "dgwDatos"
        Me.dgwDatos.ReadOnly = True
        Me.dgwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDatos.Size = New System.Drawing.Size(547, 264)
        Me.dgwDatos.TabIndex = 6
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tAceptar})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(574, 25)
        Me.ToolOpc.TabIndex = 10
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'tAceptar
        '
        Me.tAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tAceptar.Image = Global.LibProveedores.My.Resources.Resource1.checkmark_26
        Me.tAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tAceptar.Name = "tAceptar"
        Me.tAceptar.Size = New System.Drawing.Size(23, 22)
        Me.tAceptar.Text = "ToolStripButton1"
        Me.tAceptar.ToolTipText = "Aceptar"
        '
        'frmAyudaVar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 416)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.dgwDatos)
        Me.Name = "frmAyudaVar"
        Me.Text = "frmAyudaVar"
        CType(Me.dgwDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents dgwDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents tAceptar As System.Windows.Forms.ToolStripButton
End Class
