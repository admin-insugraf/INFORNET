<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAperturaVentasMensuales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAperturaVentasMensuales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfechaANIO = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaMES = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpfechaANIO)
        Me.GroupBox1.Controls.Add(Me.dtpfechaMES)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 66)
        Me.GroupBox1.TabIndex = 173
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(20, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Año :"
        '
        'dtpfechaANIO
        '
        Me.dtpfechaANIO.CustomFormat = " yyyy"
        Me.dtpfechaANIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaANIO.Location = New System.Drawing.Point(58, 10)
        Me.dtpfechaANIO.Name = "dtpfechaANIO"
        Me.dtpfechaANIO.Size = New System.Drawing.Size(126, 20)
        Me.dtpfechaANIO.TabIndex = 3
        '
        'dtpfechaMES
        '
        Me.dtpfechaMES.CustomFormat = "MMMM"
        Me.dtpfechaMES.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaMES.Location = New System.Drawing.Point(58, 40)
        Me.dtpfechaMES.Name = "dtpfechaMES"
        Me.dtpfechaMES.Size = New System.Drawing.Size(126, 20)
        Me.dtpfechaMES.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(300, 78)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&Desde el mes "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(23, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(161, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Desde inicio de Operaciones"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(253, 25)
        Me.ToolStrip1.TabIndex = 176
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(72, 22)
        Me.btn_ok.Text = "&Aceptar"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(52, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'FrmAperturaVentasMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(253, 100)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmAperturaVentasMensuales"
        Me.Text = "Apertura de Cierre de Ventas  Mensual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaANIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaMES As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
