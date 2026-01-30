<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticuloActualizacionDescuentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticuloActualizacionDescuentos))
        Me.rbmuestramedica = New System.Windows.Forms.RadioButton()
        Me.rbmaquila = New System.Windows.Forms.RadioButton()
        Me.rbgenericos = New System.Windows.Forms.RadioButton()
        Me.rbmarca = New System.Windows.Forms.RadioButton()
        Me.DgvdetalleArticulo = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbopciones = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnRetornar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbopciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbmuestramedica
        '
        Me.rbmuestramedica.AutoSize = True
        Me.rbmuestramedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmuestramedica.ForeColor = System.Drawing.Color.Navy
        Me.rbmuestramedica.Location = New System.Drawing.Point(405, 12)
        Me.rbmuestramedica.Name = "rbmuestramedica"
        Me.rbmuestramedica.Size = New System.Drawing.Size(149, 17)
        Me.rbmuestramedica.TabIndex = 3
        Me.rbmuestramedica.Text = "&Productos Muesta Medica"
        Me.rbmuestramedica.UseVisualStyleBackColor = True
        '
        'rbmaquila
        '
        Me.rbmaquila.AutoSize = True
        Me.rbmaquila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmaquila.ForeColor = System.Drawing.Color.Navy
        Me.rbmaquila.Location = New System.Drawing.Point(280, 12)
        Me.rbmaquila.Name = "rbmaquila"
        Me.rbmaquila.Size = New System.Drawing.Size(108, 17)
        Me.rbmaquila.TabIndex = 2
        Me.rbmaquila.Text = "&Producto Maquila"
        Me.rbmaquila.UseVisualStyleBackColor = True
        '
        'rbgenericos
        '
        Me.rbgenericos.AutoSize = True
        Me.rbgenericos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbgenericos.ForeColor = System.Drawing.Color.Navy
        Me.rbgenericos.Location = New System.Drawing.Point(154, 12)
        Me.rbgenericos.Name = "rbgenericos"
        Me.rbgenericos.Size = New System.Drawing.Size(106, 17)
        Me.rbgenericos.TabIndex = 1
        Me.rbgenericos.Text = "&Productos Marca"
        Me.rbgenericos.UseVisualStyleBackColor = True
        '
        'rbmarca
        '
        Me.rbmarca.AutoSize = True
        Me.rbmarca.Checked = True
        Me.rbmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbmarca.ForeColor = System.Drawing.Color.Navy
        Me.rbmarca.Location = New System.Drawing.Point(6, 12)
        Me.rbmarca.Name = "rbmarca"
        Me.rbmarca.Size = New System.Drawing.Size(139, 17)
        Me.rbmarca.TabIndex = 0
        Me.rbmarca.TabStop = True
        Me.rbmarca.Text = "&Productos de Genericos"
        Me.rbmarca.UseVisualStyleBackColor = True
        '
        'DgvdetalleArticulo
        '
        Me.DgvdetalleArticulo.AllowUserToAddRows = False
        Me.DgvdetalleArticulo.AllowUserToDeleteRows = False
        Me.DgvdetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvdetalleArticulo.Location = New System.Drawing.Point(5, 69)
        Me.DgvdetalleArticulo.Name = "DgvdetalleArticulo"
        Me.DgvdetalleArticulo.Size = New System.Drawing.Size(1065, 435)
        Me.DgvdetalleArticulo.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(649, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(401, 11)
        Me.ProgressBar1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(576, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "&Procesar ..."
        '
        'gbopciones
        '
        Me.gbopciones.Controls.Add(Me.ProgressBar1)
        Me.gbopciones.Controls.Add(Me.rbmuestramedica)
        Me.gbopciones.Controls.Add(Me.rbmaquila)
        Me.gbopciones.Controls.Add(Me.rbmarca)
        Me.gbopciones.Controls.Add(Me.rbgenericos)
        Me.gbopciones.Controls.Add(Me.Label1)
        Me.gbopciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbopciones.ForeColor = System.Drawing.Color.Navy
        Me.gbopciones.Location = New System.Drawing.Point(7, 30)
        Me.gbopciones.Name = "gbopciones"
        Me.gbopciones.Size = New System.Drawing.Size(1054, 33)
        Me.gbopciones.TabIndex = 19
        Me.gbopciones.TabStop = False
        Me.gbopciones.Text = "Tipo de articulo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGrabar, Me.btn_Cancelar, Me.btnRetornar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1075, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(77, 22)
        Me.btnGrabar.Text = "&Procesar"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_Cancelar.Text = "&Cancelar"
        '
        'btnRetornar
        '
        Me.btnRetornar.Image = CType(resources.GetObject("btnRetornar.Image"), System.Drawing.Image)
        Me.btnRetornar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(52, 22)
        Me.btnRetornar.Text = "&Salir"
        '
        'FrmArticuloActualizacionDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 510)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbopciones)
        Me.Controls.Add(Me.DgvdetalleArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArticuloActualizacionDescuentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo Actualizacion de Descuentos"
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbopciones.ResumeLayout(False)
        Me.gbopciones.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbmuestramedica As System.Windows.Forms.RadioButton
    Friend WithEvents rbmaquila As System.Windows.Forms.RadioButton
    Friend WithEvents rbgenericos As System.Windows.Forms.RadioButton
    Friend WithEvents rbmarca As System.Windows.Forms.RadioButton
    Friend WithEvents DgvdetalleArticulo As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbopciones As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRetornar As System.Windows.Forms.ToolStripButton
End Class
