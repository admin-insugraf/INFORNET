<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarArticulo_Pt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarArticulo_Pt))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_costo_final = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_costos_varios = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_costo_unitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_factor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbounidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtdescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.gb_principios_activos = New System.Windows.Forms.GroupBox()
        Me.txt_costo_costos_varios = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.txt_des_costos_varios = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_costos_varios = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dgvDetalle_costosvarios = New System.Windows.Forms.DataGridView()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_des_formula_ee = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.txt_cod_formula_ee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_principios_activos.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle_costosvarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(623, 25)
        Me.ToolStrip1.TabIndex = 188
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(76, 22)
        Me.btn_salir.Text = "&Cancelar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txt_costo_final)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_igv)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_subtotal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txt_costos_varios)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_costo_unitario)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 481)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(599, 88)
        Me.GroupBox4.TabIndex = 187
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Costos"
        '
        'txt_costo_final
        '
        Me.txt_costo_final.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_costo_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_costo_final.ForeColor = System.Drawing.Color.Maroon
        Me.txt_costo_final.Location = New System.Drawing.Point(442, 51)
        Me.txt_costo_final.Name = "txt_costo_final"
        Me.txt_costo_final.Size = New System.Drawing.Size(97, 21)
        Me.txt_costo_final.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(379, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Costo Final"
        '
        'txt_igv
        '
        Me.txt_igv.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_igv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_igv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_igv.ForeColor = System.Drawing.Color.Green
        Me.txt_igv.Location = New System.Drawing.Point(264, 51)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.Size = New System.Drawing.Size(97, 21)
        Me.txt_igv.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(189, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "I,G,V."
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_subtotal.ForeColor = System.Drawing.Color.Green
        Me.txt_subtotal.Location = New System.Drawing.Point(73, 51)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(97, 21)
        Me.txt_subtotal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(11, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sub total"
        '
        'txt_costos_varios
        '
        Me.txt_costos_varios.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_costos_varios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costos_varios.Location = New System.Drawing.Point(264, 20)
        Me.txt_costos_varios.Name = "txt_costos_varios"
        Me.txt_costos_varios.Size = New System.Drawing.Size(97, 20)
        Me.txt_costos_varios.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(189, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Costos Varios"
        '
        'txt_costo_unitario
        '
        Me.txt_costo_unitario.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_costo_unitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_unitario.Location = New System.Drawing.Point(73, 20)
        Me.txt_costo_unitario.Name = "txt_costo_unitario"
        Me.txt_costo_unitario.Size = New System.Drawing.Size(97, 20)
        Me.txt_costo_unitario.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Costo Unit."
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txt_factor)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txt_cantidad)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.cbounidadMedida)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(599, 46)
        Me.GroupBox5.TabIndex = 186
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles del Articulo"
        '
        'txt_factor
        '
        Me.txt_factor.BackColor = System.Drawing.Color.White
        Me.txt_factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_factor.Location = New System.Drawing.Point(470, 15)
        Me.txt_factor.Name = "txt_factor"
        Me.txt_factor.Size = New System.Drawing.Size(73, 20)
        Me.txt_factor.TabIndex = 222
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(399, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "Factor Equi."
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.White
        Me.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad.Location = New System.Drawing.Point(310, 15)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(79, 20)
        Me.txt_cantidad.TabIndex = 220
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(252, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 221
        Me.Label9.Text = "Cantidad"
        '
        'cbounidadMedida
        '
        Me.cbounidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounidadMedida.FormattingEnabled = True
        Me.cbounidadMedida.Location = New System.Drawing.Point(90, 15)
        Me.cbounidadMedida.Name = "cbounidadMedida"
        Me.cbounidadMedida.Size = New System.Drawing.Size(153, 21)
        Me.cbounidadMedida.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unid. Med"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArticulo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 45)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(161, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'txtdescripcionArticulo
        '
        Me.txtdescripcionArticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArticulo.Location = New System.Drawing.Point(186, 14)
        Me.txtdescripcionArticulo.Name = "txtdescripcionArticulo"
        Me.txtdescripcionArticulo.ReadOnly = True
        Me.txtdescripcionArticulo.Size = New System.Drawing.Size(358, 20)
        Me.txtdescripcionArticulo.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(8, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Articulo"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(54, 14)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoArticulo.TabIndex = 1
        '
        'gb_principios_activos
        '
        Me.gb_principios_activos.Controls.Add(Me.txt_costo_costos_varios)
        Me.gb_principios_activos.Controls.Add(Me.Label8)
        Me.gb_principios_activos.Controls.Add(Me.btn_up)
        Me.gb_principios_activos.Controls.Add(Me.txt_des_costos_varios)
        Me.gb_principios_activos.Controls.Add(Me.PictureBox12)
        Me.gb_principios_activos.Controls.Add(Me.txt_cod_costos_varios)
        Me.gb_principios_activos.Controls.Add(Me.btn_add)
        Me.gb_principios_activos.Controls.Add(Me.btn_del)
        Me.gb_principios_activos.Controls.Add(Me.dgvDetalle_costosvarios)
        Me.gb_principios_activos.Controls.Add(Me.Label42)
        Me.gb_principios_activos.Location = New System.Drawing.Point(12, 171)
        Me.gb_principios_activos.Name = "gb_principios_activos"
        Me.gb_principios_activos.Size = New System.Drawing.Size(599, 304)
        Me.gb_principios_activos.TabIndex = 189
        Me.gb_principios_activos.TabStop = False
        '
        'txt_costo_costos_varios
        '
        Me.txt_costo_costos_varios.BackColor = System.Drawing.Color.White
        Me.txt_costo_costos_varios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_costo_costos_varios.Location = New System.Drawing.Point(73, 56)
        Me.txt_costo_costos_varios.Name = "txt_costo_costos_varios"
        Me.txt_costo_costos_varios.Size = New System.Drawing.Size(97, 20)
        Me.txt_costo_costos_varios.TabIndex = 218
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(7, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "Costo Unit."
        '
        'btn_up
        '
        Me.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.ForeColor = System.Drawing.Color.Green
        Me.btn_up.Image = CType(resources.GetObject("btn_up.Image"), System.Drawing.Image)
        Me.btn_up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_up.Location = New System.Drawing.Point(433, 55)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(74, 23)
        Me.btn_up.TabIndex = 217
        Me.btn_up.Text = "Modificar"
        Me.btn_up.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_up.UseVisualStyleBackColor = True
        '
        'txt_des_costos_varios
        '
        Me.txt_des_costos_varios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_costos_varios.ForeColor = System.Drawing.Color.Black
        Me.txt_des_costos_varios.Location = New System.Drawing.Point(137, 30)
        Me.txt_des_costos_varios.Name = "txt_des_costos_varios"
        Me.txt_des_costos_varios.ReadOnly = True
        Me.txt_des_costos_varios.Size = New System.Drawing.Size(452, 20)
        Me.txt_des_costos_varios.TabIndex = 216
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(112, 31)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox12.TabIndex = 215
        Me.PictureBox12.TabStop = False
        '
        'txt_cod_costos_varios
        '
        Me.txt_cod_costos_varios.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_costos_varios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_costos_varios.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_costos_varios.Location = New System.Drawing.Point(7, 30)
        Me.txt_cod_costos_varios.Name = "txt_cod_costos_varios"
        Me.txt_cod_costos_varios.ReadOnly = True
        Me.txt_cod_costos_varios.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_costos_varios.TabIndex = 214
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Green
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(353, 55)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(74, 23)
        Me.btn_add.TabIndex = 49
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.ForeColor = System.Drawing.Color.Green
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(513, 55)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(74, 23)
        Me.btn_del.TabIndex = 48
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'dgvDetalle_costosvarios
        '
        Me.dgvDetalle_costosvarios.AllowUserToAddRows = False
        Me.dgvDetalle_costosvarios.AllowUserToDeleteRows = False
        Me.dgvDetalle_costosvarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle_costosvarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle_costosvarios.Location = New System.Drawing.Point(8, 83)
        Me.dgvDetalle_costosvarios.Name = "dgvDetalle_costosvarios"
        Me.dgvDetalle_costosvarios.ReadOnly = True
        Me.dgvDetalle_costosvarios.Size = New System.Drawing.Size(581, 210)
        Me.dgvDetalle_costosvarios.TabIndex = 47
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Navy
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(-3, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(602, 19)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = " LISTA DE COSTOS VARIOS"
        '
        'txt_des_formula_ee
        '
        Me.txt_des_formula_ee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_formula_ee.ForeColor = System.Drawing.Color.Black
        Me.txt_des_formula_ee.Location = New System.Drawing.Point(204, 140)
        Me.txt_des_formula_ee.Name = "txt_des_formula_ee"
        Me.txt_des_formula_ee.ReadOnly = True
        Me.txt_des_formula_ee.Size = New System.Drawing.Size(407, 20)
        Me.txt_des_formula_ee.TabIndex = 200
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(178, 141)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox10.TabIndex = 199
        Me.PictureBox10.TabStop = False
        '
        'txt_cod_formula_ee
        '
        Me.txt_cod_formula_ee.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_formula_ee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_formula_ee.ForeColor = System.Drawing.Color.Black
        Me.txt_cod_formula_ee.Location = New System.Drawing.Point(81, 140)
        Me.txt_cod_formula_ee.Name = "txt_cod_formula_ee"
        Me.txt_cod_formula_ee.ReadOnly = True
        Me.txt_cod_formula_ee.Size = New System.Drawing.Size(90, 20)
        Me.txt_cod_formula_ee.TabIndex = 197
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(12, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Formula E.E."
        '
        'FrmAsignarArticulo_Pt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 577)
        Me.Controls.Add(Me.txt_des_formula_ee)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.txt_cod_formula_ee)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gb_principios_activos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarArticulo_Pt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Elegir Producto Terminado"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_principios_activos.ResumeLayout(False)
        Me.gb_principios_activos.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle_costosvarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAceptar As ToolStripButton
    Friend WithEvents btn_salir As ToolStripButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_costo_unitario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbounidadMedida As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtdescripcionArticulo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtcodigoArticulo As TextBox
    Friend WithEvents txt_costo_final As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_igv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_costos_varios As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gb_principios_activos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_des_costos_varios As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_costos_varios As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle_costosvarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txt_des_formula_ee As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_cod_formula_ee As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_up As System.Windows.Forms.Button
    Friend WithEvents txt_costo_costos_varios As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_factor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
