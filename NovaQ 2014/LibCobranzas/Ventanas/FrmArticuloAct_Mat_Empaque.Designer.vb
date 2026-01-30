<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticuloAct_Mat_Empaque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticuloAct_Mat_Empaque))
        Me.gb_pas_elimina_planilla = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnRetornar = New System.Windows.Forms.ToolStripButton()
        Me.gbopciones = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.rb_insertos = New System.Windows.Forms.RadioButton()
        Me.rb_cajas = New System.Windows.Forms.RadioButton()
        Me.rb_etiquetas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvdetalleArticulo = New System.Windows.Forms.DataGridView()
        Me.gb_pas_elimina_planilla.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbopciones.SuspendLayout()
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_pas_elimina_planilla
        '
        Me.gb_pas_elimina_planilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_pas_elimina_planilla.Controls.Add(Me.txtpassword)
        Me.gb_pas_elimina_planilla.Controls.Add(Me.Button3)
        Me.gb_pas_elimina_planilla.Controls.Add(Me.Button4)
        Me.gb_pas_elimina_planilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_pas_elimina_planilla.ForeColor = System.Drawing.Color.Navy
        Me.gb_pas_elimina_planilla.Location = New System.Drawing.Point(261, 112)
        Me.gb_pas_elimina_planilla.Name = "gb_pas_elimina_planilla"
        Me.gb_pas_elimina_planilla.Size = New System.Drawing.Size(284, 96)
        Me.gb_pas_elimina_planilla.TabIndex = 25
        Me.gb_pas_elimina_planilla.TabStop = False
        Me.gb_pas_elimina_planilla.Text = "Password de Administrador"
        Me.gb_pas_elimina_planilla.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(6, 20)
        Me.txtpassword.MaxLength = 10
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(269, 22)
        Me.txtpassword.TabIndex = 216
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(142, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 39)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(64, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 39)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Continuar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGrabar, Me.btn_Cancelar, Me.btnRetornar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 25)
        Me.ToolStrip1.TabIndex = 24
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
        Me.btn_Cancelar.Visible = False
        '
        'btnRetornar
        '
        Me.btnRetornar.Image = CType(resources.GetObject("btnRetornar.Image"), System.Drawing.Image)
        Me.btnRetornar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(52, 22)
        Me.btnRetornar.Text = "&Salir"
        '
        'gbopciones
        '
        Me.gbopciones.Controls.Add(Me.ProgressBar1)
        Me.gbopciones.Controls.Add(Me.rb_insertos)
        Me.gbopciones.Controls.Add(Me.rb_cajas)
        Me.gbopciones.Controls.Add(Me.rb_etiquetas)
        Me.gbopciones.Controls.Add(Me.Label1)
        Me.gbopciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbopciones.ForeColor = System.Drawing.Color.Navy
        Me.gbopciones.Location = New System.Drawing.Point(3, 29)
        Me.gbopciones.Name = "gbopciones"
        Me.gbopciones.Size = New System.Drawing.Size(734, 39)
        Me.gbopciones.TabIndex = 23
        Me.gbopciones.TabStop = False
        Me.gbopciones.Text = "Tipo de Materiales de Empaque"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(330, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(394, 14)
        Me.ProgressBar1.TabIndex = 12
        '
        'rb_insertos
        '
        Me.rb_insertos.AutoSize = True
        Me.rb_insertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_insertos.ForeColor = System.Drawing.Color.Navy
        Me.rb_insertos.Location = New System.Drawing.Point(134, 17)
        Me.rb_insertos.Name = "rb_insertos"
        Me.rb_insertos.Size = New System.Drawing.Size(62, 17)
        Me.rb_insertos.TabIndex = 2
        Me.rb_insertos.Text = "Insertos"
        Me.rb_insertos.UseVisualStyleBackColor = True
        '
        'rb_cajas
        '
        Me.rb_cajas.AutoSize = True
        Me.rb_cajas.Checked = True
        Me.rb_cajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_cajas.ForeColor = System.Drawing.Color.Navy
        Me.rb_cajas.Location = New System.Drawing.Point(6, 17)
        Me.rb_cajas.Name = "rb_cajas"
        Me.rb_cajas.Size = New System.Drawing.Size(51, 17)
        Me.rb_cajas.TabIndex = 0
        Me.rb_cajas.TabStop = True
        Me.rb_cajas.Text = "Cajas"
        Me.rb_cajas.UseVisualStyleBackColor = True
        '
        'rb_etiquetas
        '
        Me.rb_etiquetas.AutoSize = True
        Me.rb_etiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb_etiquetas.ForeColor = System.Drawing.Color.Navy
        Me.rb_etiquetas.Location = New System.Drawing.Point(61, 17)
        Me.rb_etiquetas.Name = "rb_etiquetas"
        Me.rb_etiquetas.Size = New System.Drawing.Size(69, 17)
        Me.rb_etiquetas.TabIndex = 1
        Me.rb_etiquetas.Text = "Etiquetas"
        Me.rb_etiquetas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(255, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "&Procesar ..."
        '
        'DgvdetalleArticulo
        '
        Me.DgvdetalleArticulo.AllowUserToAddRows = False
        Me.DgvdetalleArticulo.AllowUserToDeleteRows = False
        Me.DgvdetalleArticulo.AllowUserToResizeColumns = False
        Me.DgvdetalleArticulo.AllowUserToResizeRows = False
        Me.DgvdetalleArticulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvdetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvdetalleArticulo.Location = New System.Drawing.Point(5, 74)
        Me.DgvdetalleArticulo.Name = "DgvdetalleArticulo"
        Me.DgvdetalleArticulo.Size = New System.Drawing.Size(732, 454)
        Me.DgvdetalleArticulo.TabIndex = 22
        '
        'FrmArticuloAct_Mat_Empaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 533)
        Me.Controls.Add(Me.gb_pas_elimina_planilla)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbopciones)
        Me.Controls.Add(Me.DgvdetalleArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmArticuloAct_Mat_Empaque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de precios Material de Empaque"
        Me.gb_pas_elimina_planilla.ResumeLayout(False)
        Me.gb_pas_elimina_planilla.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbopciones.ResumeLayout(False)
        Me.gbopciones.PerformLayout()
        CType(Me.DgvdetalleArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_pas_elimina_planilla As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRetornar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbopciones As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents rb_insertos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cajas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_etiquetas As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvdetalleArticulo As System.Windows.Forms.DataGridView
End Class
