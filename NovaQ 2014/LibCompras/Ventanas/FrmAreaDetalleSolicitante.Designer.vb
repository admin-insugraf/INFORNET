<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaDetalleSolicitante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAreaDetalleSolicitante))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlcabecera)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(9, 19)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(495, 217)
        Me.pnlcabecera.TabIndex = 38
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 10)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(458, 200)
        Me.dgvCabecera.TabIndex = 0
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Location = New System.Drawing.Point(35, 131)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(360, 20)
        Me.txtdescripcion.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(32, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "&Descripcion de solicitante"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(35, 85)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtcodigo.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(32, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "&Codigo de solicitante"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(525, 25)
        Me.ToolStrip1.TabIndex = 182
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
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
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
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "&Salir"
        '
        'FrmAreaDetalleSolicitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 281)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAreaDetalleSolicitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
