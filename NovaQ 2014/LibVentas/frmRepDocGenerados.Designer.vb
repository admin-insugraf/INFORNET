<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepDocGenerados
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
        Me.tOpciones = New System.Windows.Forms.ToolStrip()
        Me.tImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tOpciones
        '
        Me.tOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tImprimir, Me.tSalir})
        Me.tOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tOpciones.Name = "tOpciones"
        Me.tOpciones.Size = New System.Drawing.Size(418, 25)
        Me.tOpciones.TabIndex = 6
        Me.tOpciones.Text = "ToolStrip1"
        '
        'tImprimir
        '
        Me.tImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tImprimir.Image = Global.LibVentas.My.Resources.Resources.imprimir
        Me.tImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tImprimir.Name = "tImprimir"
        Me.tImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tImprimir.Text = "ToolStripButton1"
        Me.tImprimir.ToolTipText = "Imprimir"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 63)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha facturación"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(244, 26)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaFin.TabIndex = 11
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(65, 26)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaIni.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde"
        '
        'frmRepDocGenerados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 218)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tOpciones)
        Me.Name = "frmRepDocGenerados"
        Me.Text = "Reporte de documentos emitidos por fecha"
        Me.tOpciones.ResumeLayout(False)
        Me.tOpciones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
