<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bwsNotaIngSal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bwsNotaIngSal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cboopcionesBusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpfechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbRangofechas = New System.Windows.Forms.GroupBox()
        Me.dgvCabeceraAlmacen = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnConsultarDocumento = New System.Windows.Forms.Button()
        Me.btnNuevoDocumento = New System.Windows.Forms.Button()
        Me.btnEliminarDocum = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnDocumentoGuiaAnalisis = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRangofechas.SuspendLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(12, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(509, 22)
        Me.txtFiltro.TabIndex = 4
        '
        'cboopcionesBusqueda
        '
        Me.cboopcionesBusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboopcionesBusqueda.FormattingEnabled = True
        Me.cboopcionesBusqueda.Items.AddRange(New Object() {"Todos", "Mes de Proceso", "Rango Fechas"})
        Me.cboopcionesBusqueda.Location = New System.Drawing.Point(16, 15)
        Me.cboopcionesBusqueda.Name = "cboopcionesBusqueda"
        Me.cboopcionesBusqueda.Size = New System.Drawing.Size(170, 25)
        Me.cboopcionesBusqueda.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.cboopcionesBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(545, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 48)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones  de Busquedas:"
        '
        'dtpfechaInicial
        '
        Me.dtpfechaInicial.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechaInicial.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaInicial.Location = New System.Drawing.Point(110, 16)
        Me.dtpfechaInicial.Name = "dtpfechaInicial"
        Me.dtpfechaInicial.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechaInicial.TabIndex = 7
        Me.dtpfechaInicial.Tag = ""
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.CalendarFont = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dtpfechafinal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(278, 16)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(97, 24)
        Me.dtpfechafinal.TabIndex = 6
        Me.dtpfechafinal.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha Final"
        '
        'gbRangofechas
        '
        Me.gbRangofechas.BackColor = System.Drawing.Color.Silver
        Me.gbRangofechas.Controls.Add(Me.Label2)
        Me.gbRangofechas.Controls.Add(Me.dtpfechafinal)
        Me.gbRangofechas.Controls.Add(Me.Label1)
        Me.gbRangofechas.Controls.Add(Me.dtpfechaInicial)
        Me.gbRangofechas.Location = New System.Drawing.Point(753, 82)
        Me.gbRangofechas.Name = "gbRangofechas"
        Me.gbRangofechas.Size = New System.Drawing.Size(382, 48)
        Me.gbRangofechas.TabIndex = 10
        Me.gbRangofechas.TabStop = False
        Me.gbRangofechas.Text = "Rango de Fechas"
        Me.gbRangofechas.Visible = False
        '
        'dgvCabeceraAlmacen
        '
        Me.dgvCabeceraAlmacen.AllowUserToAddRows = False
        Me.dgvCabeceraAlmacen.AllowUserToDeleteRows = False
        Me.dgvCabeceraAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabeceraAlmacen.Location = New System.Drawing.Point(12, 19)
        Me.dgvCabeceraAlmacen.Name = "dgvCabeceraAlmacen"
        Me.dgvCabeceraAlmacen.ReadOnly = True
        Me.dgvCabeceraAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabeceraAlmacen.Size = New System.Drawing.Size(1104, 500)
        Me.dgvCabeceraAlmacen.TabIndex = 7
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(9, 522)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "."
        '
        'btnConsultarDocumento
        '
        Me.btnConsultarDocumento.FlatAppearance.BorderSize = 0
        Me.btnConsultarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarDocumento.Image = CType(resources.GetObject("btnConsultarDocumento.Image"), System.Drawing.Image)
        Me.btnConsultarDocumento.Location = New System.Drawing.Point(82, 3)
        Me.btnConsultarDocumento.Name = "btnConsultarDocumento"
        Me.btnConsultarDocumento.Size = New System.Drawing.Size(63, 67)
        Me.btnConsultarDocumento.TabIndex = 1
        Me.btnConsultarDocumento.Text = "&Consultar"
        Me.btnConsultarDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultarDocumento.UseVisualStyleBackColor = True
        '
        'btnNuevoDocumento
        '
        Me.btnNuevoDocumento.FlatAppearance.BorderSize = 0
        Me.btnNuevoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoDocumento.Image = Global.LibAlmacenes.My.Resources.Resources.add_file_26
        Me.btnNuevoDocumento.Location = New System.Drawing.Point(13, 3)
        Me.btnNuevoDocumento.Name = "btnNuevoDocumento"
        Me.btnNuevoDocumento.Size = New System.Drawing.Size(63, 67)
        Me.btnNuevoDocumento.TabIndex = 8
        Me.btnNuevoDocumento.Text = "&Nuevo"
        Me.btnNuevoDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoDocumento.UseVisualStyleBackColor = True
        '
        'btnEliminarDocum
        '
        Me.btnEliminarDocum.FlatAppearance.BorderSize = 0
        Me.btnEliminarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDocum.Image = CType(resources.GetObject("btnEliminarDocum.Image"), System.Drawing.Image)
        Me.btnEliminarDocum.Location = New System.Drawing.Point(151, 3)
        Me.btnEliminarDocum.Name = "btnEliminarDocum"
        Me.btnEliminarDocum.Size = New System.Drawing.Size(63, 67)
        Me.btnEliminarDocum.TabIndex = 9
        Me.btnEliminarDocum.Text = "&Eliminar"
        Me.btnEliminarDocum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarDocum.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.FlatAppearance.BorderSize = 0
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.Location = New System.Drawing.Point(221, 3)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(63, 67)
        Me.btnimprimir.TabIndex = 10
        Me.btnimprimir.Text = "&Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnDocumentoGuiaAnalisis
        '
        Me.btnDocumentoGuiaAnalisis.FlatAppearance.BorderSize = 0
        Me.btnDocumentoGuiaAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumentoGuiaAnalisis.Image = CType(resources.GetObject("btnDocumentoGuiaAnalisis.Image"), System.Drawing.Image)
        Me.btnDocumentoGuiaAnalisis.Location = New System.Drawing.Point(290, 3)
        Me.btnDocumentoGuiaAnalisis.Name = "btnDocumentoGuiaAnalisis"
        Me.btnDocumentoGuiaAnalisis.Size = New System.Drawing.Size(78, 67)
        Me.btnDocumentoGuiaAnalisis.TabIndex = 11
        Me.btnDocumentoGuiaAnalisis.Text = "&Guia Analisis"
        Me.btnDocumentoGuiaAnalisis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDocumentoGuiaAnalisis.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.dgvCabeceraAlmacen)
        Me.GroupBox3.Controls.Add(Me.lblCantidad)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1123, 546)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(LibAlmacenes.NotaPedidoBrowse)
        '
        'bwsNotaIngSal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1147, 691)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnNuevoDocumento)
        Me.Controls.Add(Me.btnDocumentoGuiaAnalisis)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnEliminarDocum)
        Me.Controls.Add(Me.gbRangofechas)
        Me.Controls.Add(Me.btnConsultarDocumento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "bwsNotaIngSal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento Almacen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbRangofechas.ResumeLayout(False)
        Me.gbRangofechas.PerformLayout()
        CType(Me.dgvCabeceraAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboopcionesBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbRangofechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCabeceraAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents btnConsultarDocumento As System.Windows.Forms.Button
    Friend WithEvents btnNuevoDocumento As System.Windows.Forms.Button
    Friend WithEvents btnEliminarDocum As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnDocumentoGuiaAnalisis As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
