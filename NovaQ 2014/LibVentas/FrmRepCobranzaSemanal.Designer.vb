<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepCobranzaSemanal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepCobranzaSemanal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.pnl_cliente = New System.Windows.Forms.GroupBox()
        Me.gb_clientes = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtclienteInicialDesc = New System.Windows.Forms.TextBox()
        Me.txtclienteInicial = New System.Windows.Forms.TextBox()
        Me.checkClientes = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnl_cliente.SuspendLayout()
        Me.gb_clientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(421, 25)
        Me.ToolStrip1.TabIndex = 183
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(118, 22)
        Me.btnMostrar.Text = "&Mostrar reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "&Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 57)
        Me.GroupBox3.TabIndex = 184
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Rango de Vencimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(197, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(238, 22)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(103, 25)
        Me.dtpfechaFin.TabIndex = 2
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Palatino Linotype", 10.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(49, 22)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(103, 26)
        Me.dtpfechaInicio.TabIndex = 1
        '
        'pnl_cliente
        '
        Me.pnl_cliente.Controls.Add(Me.gb_clientes)
        Me.pnl_cliente.Controls.Add(Me.checkClientes)
        Me.pnl_cliente.ForeColor = System.Drawing.Color.Navy
        Me.pnl_cliente.Location = New System.Drawing.Point(12, 95)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(400, 77)
        Me.pnl_cliente.TabIndex = 192
        Me.pnl_cliente.TabStop = False
        Me.pnl_cliente.Text = "Rango de Clientes"
        '
        'gb_clientes
        '
        Me.gb_clientes.Controls.Add(Me.Label7)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicialDesc)
        Me.gb_clientes.Controls.Add(Me.txtclienteInicial)
        Me.gb_clientes.Location = New System.Drawing.Point(3, 30)
        Me.gb_clientes.Name = "gb_clientes"
        Me.gb_clientes.Size = New System.Drawing.Size(394, 38)
        Me.gb_clientes.TabIndex = 179
        Me.gb_clientes.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(7, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Inicial"
        '
        'txtclienteInicialDesc
        '
        Me.txtclienteInicialDesc.BackColor = System.Drawing.Color.White
        Me.txtclienteInicialDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicialDesc.Location = New System.Drawing.Point(119, 11)
        Me.txtclienteInicialDesc.Name = "txtclienteInicialDesc"
        Me.txtclienteInicialDesc.ReadOnly = True
        Me.txtclienteInicialDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtclienteInicialDesc.TabIndex = 176
        '
        'txtclienteInicial
        '
        Me.txtclienteInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtclienteInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtclienteInicial.Location = New System.Drawing.Point(47, 11)
        Me.txtclienteInicial.Name = "txtclienteInicial"
        Me.txtclienteInicial.ReadOnly = True
        Me.txtclienteInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtclienteInicial.TabIndex = 173
        '
        'checkClientes
        '
        Me.checkClientes.AutoSize = True
        Me.checkClientes.ForeColor = System.Drawing.Color.Navy
        Me.checkClientes.Location = New System.Drawing.Point(269, 12)
        Me.checkClientes.Name = "checkClientes"
        Me.checkClientes.Size = New System.Drawing.Size(111, 17)
        Me.checkClientes.TabIndex = 183
        Me.checkClientes.Text = "Todos los clientes"
        Me.checkClientes.UseVisualStyleBackColor = True
        '
        'FrmRepCobranzaSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(421, 180)
        Me.Controls.Add(Me.pnl_cliente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRepCobranzaSemanal"
        Me.Text = "Rep. Cobranza Semanal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnl_cliente.ResumeLayout(False)
        Me.pnl_cliente.PerformLayout()
        Me.gb_clientes.ResumeLayout(False)
        Me.gb_clientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnl_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gb_clientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtclienteInicialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtclienteInicial As System.Windows.Forms.TextBox
    Friend WithEvents checkClientes As System.Windows.Forms.CheckBox
End Class
