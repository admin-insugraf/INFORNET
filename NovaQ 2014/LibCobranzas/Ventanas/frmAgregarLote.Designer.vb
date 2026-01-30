<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarLote))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdescripcionArt = New System.Windows.Forms.TextBox()
        Me.txtdescripcionAlm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodigoArticulo = New System.Windows.Forms.TextBox()
        Me.txtcodigoAlmacen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpfechaFabricacion = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodigoLote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.btnaceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolOpc.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdescripcionArt)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionAlm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArticulo)
        Me.GroupBox1.Controls.Add(Me.txtcodigoAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(17, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Lote."
        '
        'txtdescripcionArt
        '
        Me.txtdescripcionArt.BackColor = System.Drawing.Color.White
        Me.txtdescripcionArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionArt.Location = New System.Drawing.Point(240, 51)
        Me.txtdescripcionArt.Name = "txtdescripcionArt"
        Me.txtdescripcionArt.ReadOnly = True
        Me.txtdescripcionArt.Size = New System.Drawing.Size(312, 20)
        Me.txtdescripcionArt.TabIndex = 104
        Me.txtdescripcionArt.Tag = "104"
        '
        'txtdescripcionAlm
        '
        Me.txtdescripcionAlm.BackColor = System.Drawing.Color.White
        Me.txtdescripcionAlm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcionAlm.Location = New System.Drawing.Point(240, 25)
        Me.txtdescripcionAlm.Name = "txtdescripcionAlm"
        Me.txtdescripcionAlm.ReadOnly = True
        Me.txtdescripcionAlm.Size = New System.Drawing.Size(312, 20)
        Me.txtdescripcionAlm.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripcion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Descripcion:"
        '
        'txtcodigoArticulo
        '
        Me.txtcodigoArticulo.BackColor = System.Drawing.Color.White
        Me.txtcodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoArticulo.Location = New System.Drawing.Point(99, 51)
        Me.txtcodigoArticulo.Name = "txtcodigoArticulo"
        Me.txtcodigoArticulo.ReadOnly = True
        Me.txtcodigoArticulo.Size = New System.Drawing.Size(65, 20)
        Me.txtcodigoArticulo.TabIndex = 102
        '
        'txtcodigoAlmacen
        '
        Me.txtcodigoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtcodigoAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigoAlmacen.Location = New System.Drawing.Point(99, 25)
        Me.txtcodigoAlmacen.Name = "txtcodigoAlmacen"
        Me.txtcodigoAlmacen.ReadOnly = True
        Me.txtcodigoAlmacen.Size = New System.Drawing.Size(65, 20)
        Me.txtcodigoAlmacen.TabIndex = 101
        Me.txtcodigoAlmacen.Tag = "101"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Almacen:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(186, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CREACION DE UN NUEVO LOTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfechaFabricacion)
        Me.GroupBox2.Controls.Add(Me.dtpfechaVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtComentarios)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtcodigoLote)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(17, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 169)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del Lote."
        '
        'dtpfechaFabricacion
        '
        Me.dtpfechaFabricacion.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFabricacion.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFabricacion.Location = New System.Drawing.Point(106, 58)
        Me.dtpfechaFabricacion.Name = "dtpfechaFabricacion"
        Me.dtpfechaFabricacion.Size = New System.Drawing.Size(152, 25)
        Me.dtpfechaFabricacion.TabIndex = 3
        Me.dtpfechaFabricacion.Tag = ""
        '
        'dtpfechaVencimiento
        '
        Me.dtpfechaVencimiento.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaVencimiento.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaVencimiento.Location = New System.Drawing.Point(363, 58)
        Me.dtpfechaVencimiento.Name = "dtpfechaVencimiento"
        Me.dtpfechaVencimiento.Size = New System.Drawing.Size(152, 25)
        Me.dtpfechaVencimiento.TabIndex = 2
        Me.dtpfechaVencimiento.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Datos Adicionales:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Location = New System.Drawing.Point(9, 104)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(537, 56)
        Me.txtComentarios.TabIndex = 4
        Me.txtComentarios.Tag = ""
        Me.txtComentarios.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Fabricacion"
        '
        'txtcodigoLote
        '
        Me.txtcodigoLote.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoLote.ForeColor = System.Drawing.Color.Navy
        Me.txtcodigoLote.Location = New System.Drawing.Point(106, 20)
        Me.txtcodigoLote.Name = "txtcodigoLote"
        Me.txtcodigoLote.Size = New System.Drawing.Size(149, 23)
        Me.txtcodigoLote.TabIndex = 1
        Me.txtcodigoLote.Tag = ""
        Me.txtcodigoLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha Vencimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Codigo Lote:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.ToolOpc)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 345)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'ToolOpc
        '
        Me.ToolOpc.BackColor = System.Drawing.Color.Transparent
        Me.ToolOpc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnaceptar, Me.ToolStripButton1})
        Me.ToolOpc.Location = New System.Drawing.Point(3, 16)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(585, 25)
        Me.ToolOpc.TabIndex = 6
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(72, 22)
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.ToolTipText = "Aceptar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        '
        'frmAgregarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(621, 378)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarLote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcionArt As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcionAlm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoLote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFabricacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents btnaceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
