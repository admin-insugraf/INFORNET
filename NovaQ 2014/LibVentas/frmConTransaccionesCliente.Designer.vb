<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConTransaccionesCliente
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
        Me.components = New System.ComponentModel.Container()
        Me.dgwDocumentoCab = New System.Windows.Forms.DataGridView()
        Me.cmsTransaccion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsAnularDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsImprimirDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgwDocumentoDet = New System.Windows.Forms.DataGridView()
        Me.tOpciones = New System.Windows.Forms.ToolStrip()
        Me.tConsultar = New System.Windows.Forms.ToolStripButton()
        Me.tSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgwDocumentoCab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTransaccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgwDocumentoDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwDocumentoCab
        '
        Me.dgwDocumentoCab.AllowUserToAddRows = False
        Me.dgwDocumentoCab.AllowUserToDeleteRows = False
        Me.dgwDocumentoCab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwDocumentoCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDocumentoCab.ContextMenuStrip = Me.cmsTransaccion
        Me.dgwDocumentoCab.Location = New System.Drawing.Point(13, 104)
        Me.dgwDocumentoCab.Name = "dgwDocumentoCab"
        Me.dgwDocumentoCab.ReadOnly = True
        Me.dgwDocumentoCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDocumentoCab.Size = New System.Drawing.Size(809, 249)
        Me.dgwDocumentoCab.TabIndex = 0
        '
        'cmsTransaccion
        '
        Me.cmsTransaccion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnularDocumento, Me.tsImprimirDocumento})
        Me.cmsTransaccion.Name = "cmsTransaccion"
        Me.cmsTransaccion.Size = New System.Drawing.Size(186, 70)
        '
        'tsAnularDocumento
        '
        Me.tsAnularDocumento.Image = Global.LibVentas.My.Resources.Resources.delete_26
        Me.tsAnularDocumento.Name = "tsAnularDocumento"
        Me.tsAnularDocumento.Size = New System.Drawing.Size(185, 22)
        Me.tsAnularDocumento.Text = "Anular documento"
        '
        'tsImprimirDocumento
        '
        Me.tsImprimirDocumento.Image = Global.LibVentas.My.Resources.Resources.imprimir
        Me.tsImprimirDocumento.Name = "tsImprimirDocumento"
        Me.tsImprimirDocumento.Size = New System.Drawing.Size(185, 22)
        Me.tsImprimirDocumento.Text = "Imprimir documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha facturación"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(244, 23)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaFin.TabIndex = 11
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(65, 23)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaIni.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde"
        '
        'dgwDocumentoDet
        '
        Me.dgwDocumentoDet.AllowUserToAddRows = False
        Me.dgwDocumentoDet.AllowUserToDeleteRows = False
        Me.dgwDocumentoDet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwDocumentoDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDocumentoDet.Location = New System.Drawing.Point(13, 387)
        Me.dgwDocumentoDet.Name = "dgwDocumentoDet"
        Me.dgwDocumentoDet.ReadOnly = True
        Me.dgwDocumentoDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDocumentoDet.Size = New System.Drawing.Size(809, 180)
        Me.dgwDocumentoDet.TabIndex = 10
        '
        'tOpciones
        '
        Me.tOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tConsultar, Me.tSalir})
        Me.tOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tOpciones.Name = "tOpciones"
        Me.tOpciones.Size = New System.Drawing.Size(838, 25)
        Me.tOpciones.TabIndex = 11
        Me.tOpciones.Text = "ToolStrip1"
        '
        'tConsultar
        '
        Me.tConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tConsultar.Image = Global.LibVentas.My.Resources.Resources.search_26
        Me.tConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tConsultar.Name = "tConsultar"
        Me.tConsultar.Size = New System.Drawing.Size(23, 22)
        Me.tConsultar.Text = "ToolStripButton1"
        Me.tConsultar.ToolTipText = "Consultar"
        '
        'tSalir
        '
        Me.tSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tSalir.Image = Global.LibVentas.My.Resources.Resources.exit_26
        Me.tSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSalir.Name = "tSalir"
        Me.tSalir.Size = New System.Drawing.Size(23, 22)
        Me.tSalir.Text = "ToolStripButton2"
        Me.tSalir.ToolTipText = "Salir"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Detalle de documento"
        '
        'frmConTransaccionesCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 579)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tOpciones)
        Me.Controls.Add(Me.dgwDocumentoDet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgwDocumentoCab)
        Me.Name = "frmConTransaccionesCliente"
        Me.Text = "Transacciones de cliente"
        CType(Me.dgwDocumentoCab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTransaccion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgwDocumentoDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tOpciones.ResumeLayout(False)
        Me.tOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgwDocumentoCab As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgwDocumentoDet As System.Windows.Forms.DataGridView
    Friend WithEvents tOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmsTransaccion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsAnularDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsImprimirDocumento As System.Windows.Forms.ToolStripMenuItem
End Class
