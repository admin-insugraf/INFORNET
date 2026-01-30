<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Familia_Lineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Familia_Lineas))
        Me.tc_familia = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_lineas_familia = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.chkmostrarfacturacion = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTipoArticulo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txttipoArticulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.tc_familia.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_lineas_familia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_familia
        '
        Me.tc_familia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_familia.Controls.Add(Me.TabPage1)
        Me.tc_familia.Controls.Add(Me.TabPage2)
        Me.tc_familia.Location = New System.Drawing.Point(12, 39)
        Me.tc_familia.Name = "tc_familia"
        Me.tc_familia.SelectedIndex = 0
        Me.tc_familia.Size = New System.Drawing.Size(620, 296)
        Me.tc_familia.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_lineas_familia)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Lineas de Familia"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_lineas_familia
        '
        Me.dgv_lineas_familia.AllowUserToAddRows = False
        Me.dgv_lineas_familia.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_lineas_familia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lineas_familia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lineas_familia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_lineas_familia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lineas_familia.Location = New System.Drawing.Point(3, 3)
        Me.dgv_lineas_familia.Name = "dgv_lineas_familia"
        Me.dgv_lineas_familia.ReadOnly = True
        Me.dgv_lineas_familia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lineas_familia.Size = New System.Drawing.Size(606, 264)
        Me.dgv_lineas_familia.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 270)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.txtcodigo)
        Me.gb_data.Controls.Add(Me.chkmostrarfacturacion)
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.lblTipoArticulo)
        Me.gb_data.Controls.Add(Me.Label20)
        Me.gb_data.Controls.Add(Me.txttipoArticulo)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(606, 264)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Letra Inicial"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Location = New System.Drawing.Point(80, 83)
        Me.txtcodigo.MaxLength = 2
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(41, 20)
        Me.txtcodigo.TabIndex = 112
        '
        'chkmostrarfacturacion
        '
        Me.chkmostrarfacturacion.AutoSize = True
        Me.chkmostrarfacturacion.ForeColor = System.Drawing.Color.Navy
        Me.chkmostrarfacturacion.Location = New System.Drawing.Point(82, 139)
        Me.chkmostrarfacturacion.Name = "chkmostrarfacturacion"
        Me.chkmostrarfacturacion.Size = New System.Drawing.Size(173, 17)
        Me.chkmostrarfacturacion.TabIndex = 111
        Me.chkmostrarfacturacion.Text = "Mostrar en Facturación y Guias"
        Me.chkmostrarfacturacion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(123, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'lblTipoArticulo
        '
        Me.lblTipoArticulo.AutoSize = True
        Me.lblTipoArticulo.Location = New System.Drawing.Point(147, 113)
        Me.lblTipoArticulo.Name = "lblTipoArticulo"
        Me.lblTipoArticulo.Size = New System.Drawing.Size(16, 13)
        Me.lblTipoArticulo.TabIndex = 109
        Me.lblTipoArticulo.Text = "..."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(13, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Tipo Articulo"
        '
        'txttipoArticulo
        '
        Me.txttipoArticulo.BackColor = System.Drawing.Color.White
        Me.txttipoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttipoArticulo.Location = New System.Drawing.Point(80, 109)
        Me.txttipoArticulo.Name = "txttipoArticulo"
        Me.txttipoArticulo.ReadOnly = True
        Me.txttipoArticulo.Size = New System.Drawing.Size(41, 20)
        Me.txttipoArticulo.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(36, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(13, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(80, 33)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod.TabIndex = 2
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(80, 59)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(334, 20)
        Me.txt_des.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(635, 25)
        Me.ToolStrip1.TabIndex = 204
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
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton8.Text = "&Salir"
        '
        'frm_CX_MA_Familia_Lineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 347)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_familia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CX_MA_Familia_Lineas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Familia Lineas"
        Me.tc_familia.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_lineas_familia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_familia As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lineas_familia As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipoArticulo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txttipoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents chkmostrarfacturacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
End Class
