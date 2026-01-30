<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MA_Fondo_Pensiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MA_Fondo_Pensiones))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_prima_seguro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_comision_mixta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_comision_variable = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_aporte_obligatorio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(667, 25)
        Me.ToolStrip1.TabIndex = 193
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(81, 22)
        Me.btn_Editar.Text = "&Consultar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(5, 13)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(632, 390)
        Me.pnlcabecera.TabIndex = 32
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 12)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(603, 363)
        Me.dgvCabecera.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnlcabecera)
        Me.GroupBox1.Controls.Add(Me.txt_prima_seguro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_comision_mixta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_comision_variable)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_aporte_obligatorio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ruc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 411)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        '
        'txt_prima_seguro
        '
        Me.txt_prima_seguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prima_seguro.Location = New System.Drawing.Point(41, 295)
        Me.txt_prima_seguro.Name = "txt_prima_seguro"
        Me.txt_prima_seguro.Size = New System.Drawing.Size(152, 20)
        Me.txt_prima_seguro.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(41, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Prima Seguro"
        '
        'txt_comision_mixta
        '
        Me.txt_comision_mixta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comision_mixta.Location = New System.Drawing.Point(41, 242)
        Me.txt_comision_mixta.Name = "txt_comision_mixta"
        Me.txt_comision_mixta.Size = New System.Drawing.Size(152, 20)
        Me.txt_comision_mixta.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(41, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Comisión Mixta"
        '
        'txt_comision_variable
        '
        Me.txt_comision_variable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comision_variable.Location = New System.Drawing.Point(41, 192)
        Me.txt_comision_variable.Name = "txt_comision_variable"
        Me.txt_comision_variable.Size = New System.Drawing.Size(152, 20)
        Me.txt_comision_variable.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(41, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Comisión Variable"
        '
        'txt_aporte_obligatorio
        '
        Me.txt_aporte_obligatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_aporte_obligatorio.Location = New System.Drawing.Point(41, 144)
        Me.txt_aporte_obligatorio.Name = "txt_aporte_obligatorio"
        Me.txt_aporte_obligatorio.Size = New System.Drawing.Size(152, 20)
        Me.txt_aporte_obligatorio.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(41, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Aporte Obligatorio"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Location = New System.Drawing.Point(41, 95)
        Me.txtdescripcion.MaxLength = 50
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(360, 20)
        Me.txtdescripcion.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(38, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Descripción"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(41, 49)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(103, 20)
        Me.txtcodigo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(38, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Código"
        '
        'txt_ruc
        '
        Me.txt_ruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc.Location = New System.Drawing.Point(271, 49)
        Me.txt_ruc.MaxLength = 20
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(103, 20)
        Me.txt_ruc.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(268, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Ruc"
        '
        'Frm_MA_Fondo_Pensiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 453)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_MA_Fondo_Pensiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fondo de Pensiones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_prima_seguro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_comision_mixta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_comision_variable As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_aporte_obligatorio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
