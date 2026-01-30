<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OP_PLanta_Bandeja_Programacion_Despachos_Prog_Recojo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OP_PLanta_Bandeja_Programacion_Despachos_Prog_Recojo))
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod_vehiculo = New System.Windows.Forms.TextBox()
        Me.txt_des_vehiculo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.dtp_fecha_despacho = New System.Windows.Forms.DateTimePicker()
        Me.btn_prog_despacho_final = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod_trans = New System.Windows.Forms.TextBox()
        Me.txt_des_trans = New System.Windows.Forms.TextBox()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.BackColor = System.Drawing.Color.White
        Me.GroupBox14.Controls.Add(Me.Label5)
        Me.GroupBox14.Controls.Add(Me.txt_obs)
        Me.GroupBox14.Controls.Add(Me.Label4)
        Me.GroupBox14.Controls.Add(Me.txt_direccion)
        Me.GroupBox14.Controls.Add(Me.Label3)
        Me.GroupBox14.Controls.Add(Me.txt_cliente)
        Me.GroupBox14.Controls.Add(Me.Label2)
        Me.GroupBox14.Controls.Add(Me.txt_cod_vehiculo)
        Me.GroupBox14.Controls.Add(Me.txt_des_vehiculo)
        Me.GroupBox14.Controls.Add(Me.TextBox1)
        Me.GroupBox14.Controls.Add(Me.Label91)
        Me.GroupBox14.Controls.Add(Me.dtp_fecha_despacho)
        Me.GroupBox14.Controls.Add(Me.btn_prog_despacho_final)
        Me.GroupBox14.Controls.Add(Me.Label1)
        Me.GroupBox14.Controls.Add(Me.txt_cod_trans)
        Me.GroupBox14.Controls.Add(Me.txt_des_trans)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox14.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(490, 235)
        Me.GroupBox14.TabIndex = 282
        Me.GroupBox14.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(43, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 283
        Me.Label5.Text = "Obs."
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.White
        Me.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs.Location = New System.Drawing.Point(76, 166)
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(406, 20)
        Me.txt_obs.TabIndex = 282
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 281
        Me.Label4.Text = "Dirección"
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.White
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Location = New System.Drawing.Point(76, 136)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(406, 20)
        Me.txt_direccion.TabIndex = 280
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(33, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cliente.Location = New System.Drawing.Point(76, 106)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(406, 20)
        Me.txt_cliente.TabIndex = 278
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "Vehiculo"
        '
        'txt_cod_vehiculo
        '
        Me.txt_cod_vehiculo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_vehiculo.Location = New System.Drawing.Point(76, 50)
        Me.txt_cod_vehiculo.Name = "txt_cod_vehiculo"
        Me.txt_cod_vehiculo.ReadOnly = True
        Me.txt_cod_vehiculo.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_vehiculo.TabIndex = 276
        '
        'txt_des_vehiculo
        '
        Me.txt_des_vehiculo.BackColor = System.Drawing.Color.White
        Me.txt_des_vehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_vehiculo.Enabled = False
        Me.txt_des_vehiculo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_vehiculo.Location = New System.Drawing.Point(151, 50)
        Me.txt_des_vehiculo.MaxLength = 200
        Me.txt_des_vehiculo.Name = "txt_des_vehiculo"
        Me.txt_des_vehiculo.ReadOnly = True
        Me.txt_des_vehiculo.Size = New System.Drawing.Size(331, 20)
        Me.txt_des_vehiculo.TabIndex = 275
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-6, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(497, 20)
        Me.TextBox1.TabIndex = 274
        Me.TextBox1.Text = "DATOS DE RECOJO"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label91
        '
        Me.Label91.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label91.AutoSize = True
        Me.Label91.ForeColor = System.Drawing.Color.Navy
        Me.Label91.Location = New System.Drawing.Point(35, 82)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(37, 13)
        Me.Label91.TabIndex = 273
        Me.Label91.Text = "Fecha"
        '
        'dtp_fecha_despacho
        '
        Me.dtp_fecha_despacho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_fecha_despacho.CalendarFont = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_fecha_despacho.Checked = False
        Me.dtp_fecha_despacho.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_despacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_despacho.Location = New System.Drawing.Point(76, 76)
        Me.dtp_fecha_despacho.Name = "dtp_fecha_despacho"
        Me.dtp_fecha_despacho.Size = New System.Drawing.Size(95, 24)
        Me.dtp_fecha_despacho.TabIndex = 272
        Me.dtp_fecha_despacho.Tag = ""
        '
        'btn_prog_despacho_final
        '
        Me.btn_prog_despacho_final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prog_despacho_final.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prog_despacho_final.ForeColor = System.Drawing.Color.Navy
        Me.btn_prog_despacho_final.Image = CType(resources.GetObject("btn_prog_despacho_final.Image"), System.Drawing.Image)
        Me.btn_prog_despacho_final.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prog_despacho_final.Location = New System.Drawing.Point(187, 199)
        Me.btn_prog_despacho_final.Name = "btn_prog_despacho_final"
        Me.btn_prog_despacho_final.Size = New System.Drawing.Size(120, 23)
        Me.btn_prog_despacho_final.TabIndex = 271
        Me.btn_prog_despacho_final.Text = "Registrar Recojo"
        Me.btn_prog_despacho_final.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_prog_despacho_final.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "Transportista"
        '
        'txt_cod_trans
        '
        Me.txt_cod_trans.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cod_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_trans.Location = New System.Drawing.Point(76, 27)
        Me.txt_cod_trans.Name = "txt_cod_trans"
        Me.txt_cod_trans.ReadOnly = True
        Me.txt_cod_trans.Size = New System.Drawing.Size(64, 20)
        Me.txt_cod_trans.TabIndex = 188
        '
        'txt_des_trans
        '
        Me.txt_des_trans.BackColor = System.Drawing.Color.White
        Me.txt_des_trans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des_trans.Enabled = False
        Me.txt_des_trans.ForeColor = System.Drawing.Color.Maroon
        Me.txt_des_trans.Location = New System.Drawing.Point(151, 27)
        Me.txt_des_trans.MaxLength = 200
        Me.txt_des_trans.Name = "txt_des_trans"
        Me.txt_des_trans.ReadOnly = True
        Me.txt_des_trans.Size = New System.Drawing.Size(331, 20)
        Me.txt_des_trans.TabIndex = 186
        '
        'Frm_OP_PLanta_Bandeja_Programacion_Despachos_Prog_Recojo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 257)
        Me.Controls.Add(Me.GroupBox14)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_OP_PLanta_Bandeja_Programacion_Despachos_Prog_Recojo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programar recojo"
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_despacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_prog_despacho_final As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_trans As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_trans As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
End Class
