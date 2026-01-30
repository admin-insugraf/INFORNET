<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tipo_Documento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Tipo_Documento))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_cta_dolares_desc = New System.Windows.Forms.TextBox()
        Me.txt_cta_soles_desc = New System.Windows.Forms.TextBox()
        Me.txt_cta_dolares = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cta_soles = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cod_sunat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(520, 25)
        Me.ToolStrip1.TabIndex = 108
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 32)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(498, 303)
        Me.tc_tipos.TabIndex = 107
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_Lista)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(490, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Tipos"
        '
        'dgv_Lista
        '
        Me.dgv_Lista.AllowUserToAddRows = False
        Me.dgv_Lista.AllowUserToDeleteRows = False
        Me.dgv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lista.Location = New System.Drawing.Point(6, 57)
        Me.dgv_Lista.Name = "dgv_Lista"
        Me.dgv_Lista.ReadOnly = True
        Me.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Lista.Size = New System.Drawing.Size(478, 192)
        Me.dgv_Lista.TabIndex = 123
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(9, 254)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 122
        Me.lblCantidad.Text = "."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(478, 45)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(455, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(490, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.txt_cod)
        Me.gb_datos.Controls.Add(Me.PictureBox2)
        Me.gb_datos.Controls.Add(Me.PictureBox1)
        Me.gb_datos.Controls.Add(Me.PictureBox5)
        Me.gb_datos.Controls.Add(Me.txt_cta_dolares_desc)
        Me.gb_datos.Controls.Add(Me.txt_cta_soles_desc)
        Me.gb_datos.Controls.Add(Me.txt_cta_dolares)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.txt_cta_soles)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.txt_cod_sunat)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.txt_des)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Location = New System.Drawing.Point(13, 6)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(463, 265)
        Me.gb_datos.TabIndex = 3
        Me.gb_datos.TabStop = False
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.White
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(18, 37)
        Me.txt_cod.MaxLength = 4
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod.TabIndex = 126
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(88, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(88, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(88, 162)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox5.TabIndex = 123
        Me.PictureBox5.TabStop = False
        '
        'txt_cta_dolares_desc
        '
        Me.txt_cta_dolares_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_dolares_desc.Enabled = False
        Me.txt_cta_dolares_desc.Location = New System.Drawing.Point(112, 207)
        Me.txt_cta_dolares_desc.MaxLength = 200
        Me.txt_cta_dolares_desc.Name = "txt_cta_dolares_desc"
        Me.txt_cta_dolares_desc.ReadOnly = True
        Me.txt_cta_dolares_desc.Size = New System.Drawing.Size(340, 20)
        Me.txt_cta_dolares_desc.TabIndex = 9
        '
        'txt_cta_soles_desc
        '
        Me.txt_cta_soles_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_soles_desc.Enabled = False
        Me.txt_cta_soles_desc.Location = New System.Drawing.Point(112, 162)
        Me.txt_cta_soles_desc.MaxLength = 200
        Me.txt_cta_soles_desc.Name = "txt_cta_soles_desc"
        Me.txt_cta_soles_desc.ReadOnly = True
        Me.txt_cta_soles_desc.Size = New System.Drawing.Size(340, 20)
        Me.txt_cta_soles_desc.TabIndex = 8
        '
        'txt_cta_dolares
        '
        Me.txt_cta_dolares.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_dolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_dolares.Location = New System.Drawing.Point(18, 207)
        Me.txt_cta_dolares.MaxLength = 10
        Me.txt_cta_dolares.Name = "txt_cta_dolares"
        Me.txt_cta_dolares.ReadOnly = True
        Me.txt_cta_dolares.Size = New System.Drawing.Size(64, 20)
        Me.txt_cta_dolares.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(20, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cta. Dolares"
        '
        'txt_cta_soles
        '
        Me.txt_cta_soles.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_soles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_soles.Location = New System.Drawing.Point(18, 162)
        Me.txt_cta_soles.MaxLength = 10
        Me.txt_cta_soles.Name = "txt_cta_soles"
        Me.txt_cta_soles.ReadOnly = True
        Me.txt_cta_soles.Size = New System.Drawing.Size(64, 20)
        Me.txt_cta_soles.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(20, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cta. Soles"
        '
        'txt_cod_sunat
        '
        Me.txt_cod_sunat.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_sunat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_sunat.Location = New System.Drawing.Point(18, 117)
        Me.txt_cod_sunat.MaxLength = 2
        Me.txt_cod_sunat.Name = "txt_cod_sunat"
        Me.txt_cod_sunat.ReadOnly = True
        Me.txt_cod_sunat.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_sunat.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(20, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cod. Sunat"
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(18, 76)
        Me.txt_des.MaxLength = 200
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(434, 20)
        Me.txt_des.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Frm_Tipo_Documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 339)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Tipo_Documento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Documento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Lista As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_sunat As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_dolares_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_soles_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_dolares As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_soles As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
End Class
