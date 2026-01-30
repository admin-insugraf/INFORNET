<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteProdPrecDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteProdPrecDesc))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkmarca = New System.Windows.Forms.CheckBox()
        Me.chkgenerico = New System.Windows.Forms.CheckBox()
        Me.chkmuestramedica = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(381, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(121, 22)
        Me.btnMostrar.Text = "Mostrar Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkmuestramedica)
        Me.GroupBox4.Controls.Add(Me.chkgenerico)
        Me.GroupBox4.Controls.Add(Me.chkmarca)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 159)
        Me.GroupBox4.TabIndex = 114
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipos de Productos"
        '
        'chkmarca
        '
        Me.chkmarca.AutoSize = True
        Me.chkmarca.Location = New System.Drawing.Point(31, 33)
        Me.chkmarca.Name = "chkmarca"
        Me.chkmarca.Size = New System.Drawing.Size(122, 17)
        Me.chkmarca.TabIndex = 0
        Me.chkmarca.Text = "Productos de Marca"
        Me.chkmarca.UseVisualStyleBackColor = True
        '
        'chkgenerico
        '
        Me.chkgenerico.AutoSize = True
        Me.chkgenerico.Location = New System.Drawing.Point(31, 63)
        Me.chkgenerico.Name = "chkgenerico"
        Me.chkgenerico.Size = New System.Drawing.Size(125, 17)
        Me.chkgenerico.TabIndex = 1
        Me.chkgenerico.Text = "Productos Genericos"
        Me.chkgenerico.UseVisualStyleBackColor = True
        '
        'chkmuestramedica
        '
        Me.chkmuestramedica.AutoSize = True
        Me.chkmuestramedica.Location = New System.Drawing.Point(31, 95)
        Me.chkmuestramedica.Name = "chkmuestramedica"
        Me.chkmuestramedica.Size = New System.Drawing.Size(112, 17)
        Me.chkmuestramedica.TabIndex = 2
        Me.chkmuestramedica.Text = "Muestras Medicas"
        Me.chkmuestramedica.UseVisualStyleBackColor = True
        '
        'FrmReporteProdPrecDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 215)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReporteProdPrecDesc"
        Me.Text = "Rep. Precios y Dsctos."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkmuestramedica As System.Windows.Forms.CheckBox
    Friend WithEvents chkgenerico As System.Windows.Forms.CheckBox
    Friend WithEvents chkmarca As System.Windows.Forms.CheckBox
End Class
