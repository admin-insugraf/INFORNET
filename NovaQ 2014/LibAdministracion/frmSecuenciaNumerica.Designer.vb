<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecuenciaNumerica
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
        Me.tcSecuencias = New System.Windows.Forms.TabControl()
        Me.tpListado = New System.Windows.Forms.TabPage()
        Me.tpNumeroDoc = New System.Windows.Forms.TabPage()
        Me.ToolOpc = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.dgwListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtNumeroSerie = New System.Windows.Forms.TextBox()
        Me.txtUltNumero = New System.Windows.Forms.TextBox()
        Me.txtNomReporte = New System.Windows.Forms.TextBox()
        Me.tcSecuencias.SuspendLayout()
        Me.tpListado.SuspendLayout()
        Me.tpNumeroDoc.SuspendLayout()
        Me.ToolOpc.SuspendLayout()
        CType(Me.dgwListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcSecuencias
        '
        Me.tcSecuencias.Controls.Add(Me.tpListado)
        Me.tcSecuencias.Controls.Add(Me.tpNumeroDoc)
        Me.tcSecuencias.Location = New System.Drawing.Point(12, 39)
        Me.tcSecuencias.Name = "tcSecuencias"
        Me.tcSecuencias.SelectedIndex = 0
        Me.tcSecuencias.Size = New System.Drawing.Size(438, 329)
        Me.tcSecuencias.TabIndex = 0
        '
        'tpListado
        '
        Me.tpListado.Controls.Add(Me.dgwListado)
        Me.tpListado.Location = New System.Drawing.Point(4, 22)
        Me.tpListado.Name = "tpListado"
        Me.tpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListado.Size = New System.Drawing.Size(430, 303)
        Me.tpListado.TabIndex = 0
        Me.tpListado.Text = "Listado de secuencias"
        Me.tpListado.UseVisualStyleBackColor = True
        '
        'tpNumeroDoc
        '
        Me.tpNumeroDoc.Controls.Add(Me.txtNomReporte)
        Me.tpNumeroDoc.Controls.Add(Me.txtUltNumero)
        Me.tpNumeroDoc.Controls.Add(Me.txtNumeroSerie)
        Me.tpNumeroDoc.Controls.Add(Me.txtTipoDoc)
        Me.tpNumeroDoc.Controls.Add(Me.Label4)
        Me.tpNumeroDoc.Controls.Add(Me.Label3)
        Me.tpNumeroDoc.Controls.Add(Me.Label2)
        Me.tpNumeroDoc.Controls.Add(Me.Label1)
        Me.tpNumeroDoc.Location = New System.Drawing.Point(4, 22)
        Me.tpNumeroDoc.Name = "tpNumeroDoc"
        Me.tpNumeroDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNumeroDoc.Size = New System.Drawing.Size(430, 303)
        Me.tpNumeroDoc.TabIndex = 1
        Me.tpNumeroDoc.Text = "Número de secuencia"
        Me.tpNumeroDoc.UseVisualStyleBackColor = True
        '
        'ToolOpc
        '
        Me.ToolOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolEditar, Me.ToolGrabar, Me.ToolCancelar, Me.ToolSalir})
        Me.ToolOpc.Location = New System.Drawing.Point(0, 0)
        Me.ToolOpc.Name = "ToolOpc"
        Me.ToolOpc.Size = New System.Drawing.Size(469, 25)
        Me.ToolOpc.TabIndex = 23
        Me.ToolOpc.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolNuevo.Image = Global.LibAdministracion.My.Resources.Resources.add_file_261
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(23, 22)
        Me.ToolNuevo.Text = "ToolStripButton1"
        Me.ToolNuevo.ToolTipText = "Nuevo"
        '
        'ToolEditar
        '
        Me.ToolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolEditar.Image = Global.LibAdministracion.My.Resources.Resources.edit_261
        Me.ToolEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolEditar.Name = "ToolEditar"
        Me.ToolEditar.Size = New System.Drawing.Size(23, 22)
        Me.ToolEditar.Text = "ToolStripButton1"
        Me.ToolEditar.ToolTipText = "Editar"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolGrabar.Enabled = False
        Me.ToolGrabar.Image = Global.LibAdministracion.My.Resources.Resources.grabar1
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(23, 22)
        Me.ToolGrabar.Text = "ToolStripButton3"
        Me.ToolGrabar.ToolTipText = "Guardar"
        '
        'ToolCancelar
        '
        Me.ToolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolCancelar.Image = Global.LibAdministracion.My.Resources.Resources.cancelar1
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(23, 22)
        Me.ToolCancelar.Text = "ToolStripButton1"
        Me.ToolCancelar.ToolTipText = "Cancelar"
        '
        'ToolSalir
        '
        Me.ToolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolSalir.Image = Global.LibAdministracion.My.Resources.Resources.exit_261
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(23, 22)
        Me.ToolSalir.Text = "ToolStripButton2"
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'dgwListado
        '
        Me.dgwListado.AllowUserToAddRows = False
        Me.dgwListado.AllowUserToDeleteRows = False
        Me.dgwListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwListado.Location = New System.Drawing.Point(16, 19)
        Me.dgwListado.Name = "dgwListado"
        Me.dgwListado.ReadOnly = True
        Me.dgwListado.Size = New System.Drawing.Size(395, 265)
        Me.dgwListado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número de serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ultimo número generado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre del reporte"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(146, 25)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDoc.TabIndex = 4
        '
        'txtNumeroSerie
        '
        Me.txtNumeroSerie.Location = New System.Drawing.Point(146, 64)
        Me.txtNumeroSerie.Name = "txtNumeroSerie"
        Me.txtNumeroSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroSerie.TabIndex = 5
        '
        'txtUltNumero
        '
        Me.txtUltNumero.Location = New System.Drawing.Point(146, 103)
        Me.txtUltNumero.Name = "txtUltNumero"
        Me.txtUltNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtUltNumero.TabIndex = 6
        '
        'txtNomReporte
        '
        Me.txtNomReporte.Location = New System.Drawing.Point(146, 142)
        Me.txtNomReporte.Name = "txtNomReporte"
        Me.txtNomReporte.Size = New System.Drawing.Size(205, 20)
        Me.txtNomReporte.TabIndex = 7
        '
        'frmSecuenciaNumerica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 380)
        Me.Controls.Add(Me.ToolOpc)
        Me.Controls.Add(Me.tcSecuencias)
        Me.Name = "frmSecuenciaNumerica"
        Me.Text = "Secuencia de documentos"
        Me.tcSecuencias.ResumeLayout(False)
        Me.tpListado.ResumeLayout(False)
        Me.tpNumeroDoc.ResumeLayout(False)
        Me.tpNumeroDoc.PerformLayout()
        Me.ToolOpc.ResumeLayout(False)
        Me.ToolOpc.PerformLayout()
        CType(Me.dgwListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcSecuencias As System.Windows.Forms.TabControl
    Friend WithEvents tpListado As System.Windows.Forms.TabPage
    Friend WithEvents tpNumeroDoc As System.Windows.Forms.TabPage
    Friend WithEvents ToolOpc As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgwListado As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomReporte As System.Windows.Forms.TextBox
    Friend WithEvents txtUltNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDoc As System.Windows.Forms.TextBox
End Class
