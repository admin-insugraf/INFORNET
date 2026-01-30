<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegCompras))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.gbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdbconcar = New System.Windows.Forms.RadioButton()
        Me.rdbsunat = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.checkTipoDoc = New System.Windows.Forms.CheckBox()
        Me.chklstDocumentos = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpfechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfechaFin = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.gbDatosGenerales.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(114, 43)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(202, 19)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "REGISTRO DE COMPRAS"
        '
        'gbDatosGenerales
        '
        Me.gbDatosGenerales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDatosGenerales.BackColor = System.Drawing.Color.White
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox7)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox4)
        Me.gbDatosGenerales.Controls.Add(Me.GroupBox3)
        Me.gbDatosGenerales.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gbDatosGenerales.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGenerales.Location = New System.Drawing.Point(12, 71)
        Me.gbDatosGenerales.Name = "gbDatosGenerales"
        Me.gbDatosGenerales.Size = New System.Drawing.Size(394, 357)
        Me.gbDatosGenerales.TabIndex = 12
        Me.gbDatosGenerales.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.rdbconcar)
        Me.GroupBox7.Controls.Add(Me.rdbsunat)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(26, 71)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(350, 39)
        Me.GroupBox7.TabIndex = 114
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opciones"
        '
        'rdbconcar
        '
        Me.rdbconcar.AutoSize = True
        Me.rdbconcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdbconcar.ForeColor = System.Drawing.Color.Navy
        Me.rdbconcar.Location = New System.Drawing.Point(215, 18)
        Me.rdbconcar.Name = "rdbconcar"
        Me.rdbconcar.Size = New System.Drawing.Size(104, 17)
        Me.rdbconcar.TabIndex = 3
        Me.rdbconcar.TabStop = True
        Me.rdbconcar.Text = "Formato Insugraf"
        Me.rdbconcar.UseVisualStyleBackColor = True
        '
        'rdbsunat
        '
        Me.rdbsunat.AutoSize = True
        Me.rdbsunat.Checked = True
        Me.rdbsunat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdbsunat.ForeColor = System.Drawing.Color.Navy
        Me.rdbsunat.Location = New System.Drawing.Point(20, 18)
        Me.rdbsunat.Name = "rdbsunat"
        Me.rdbsunat.Size = New System.Drawing.Size(94, 17)
        Me.rdbsunat.TabIndex = 2
        Me.rdbsunat.TabStop = True
        Me.rdbsunat.Text = "Formato Sunat"
        Me.rdbsunat.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.checkTipoDoc)
        Me.GroupBox4.Controls.Add(Me.chklstDocumentos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(26, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(350, 228)
        Me.GroupBox4.TabIndex = 113
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Documentos"
        '
        'checkTipoDoc
        '
        Me.checkTipoDoc.AutoSize = True
        Me.checkTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.checkTipoDoc.ForeColor = System.Drawing.Color.Navy
        Me.checkTipoDoc.Location = New System.Drawing.Point(15, 18)
        Me.checkTipoDoc.Name = "checkTipoDoc"
        Me.checkTipoDoc.Size = New System.Drawing.Size(154, 17)
        Me.checkTipoDoc.TabIndex = 7
        Me.checkTipoDoc.Text = "Activar /Desactivar. Todos"
        Me.checkTipoDoc.UseVisualStyleBackColor = True
        '
        'chklstDocumentos
        '
        Me.chklstDocumentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chklstDocumentos.CheckOnClick = True
        Me.chklstDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chklstDocumentos.FormattingEnabled = True
        Me.chklstDocumentos.Location = New System.Drawing.Point(12, 40)
        Me.chklstDocumentos.Name = "chklstDocumentos"
        Me.chklstDocumentos.Size = New System.Drawing.Size(326, 169)
        Me.chklstDocumentos.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtpfechaInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpfechaFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(26, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 54)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(166, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Final :"
        '
        'dtpfechaInicio
        '
        Me.dtpfechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicio.Location = New System.Drawing.Point(54, 26)
        Me.dtpfechaInicio.Name = "dtpfechaInicio"
        Me.dtpfechaInicio.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Inicial :"
        '
        'dtpfechaFin
        '
        Me.dtpfechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFin.Location = New System.Drawing.Point(205, 26)
        Me.dtpfechaFin.Name = "dtpfechaFin"
        Me.dtpfechaFin.Size = New System.Drawing.Size(105, 20)
        Me.dtpfechaFin.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMostrar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 25)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(121, 22)
        Me.btnMostrar.Text = "Mostrar Reporte"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'FrmRegCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 436)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbDatosGenerales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de compras"
        Me.gbDatosGenerales.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents checkTipoDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chklstDocumentos As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMostrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbconcar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbsunat As System.Windows.Forms.RadioButton
End Class
