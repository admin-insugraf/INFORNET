<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprasConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprasConceptos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.btnAgregarDetalles = New System.Windows.Forms.Button()
        Me.txtdescripcionConcepto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlcabecera)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionConcepto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigoConcepto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 282)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Controls.Add(Me.btnAgregarDetalles)
        Me.pnlcabecera.Location = New System.Drawing.Point(16, 13)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(376, 261)
        Me.pnlcabecera.TabIndex = 32
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 12)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(352, 201)
        Me.dgvCabecera.TabIndex = 0
        '
        'btnAgregarDetalles
        '
        Me.btnAgregarDetalles.Image = CType(resources.GetObject("btnAgregarDetalles.Image"), System.Drawing.Image)
        Me.btnAgregarDetalles.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAgregarDetalles.Location = New System.Drawing.Point(14, 217)
        Me.btnAgregarDetalles.Name = "btnAgregarDetalles"
        Me.btnAgregarDetalles.Size = New System.Drawing.Size(123, 41)
        Me.btnAgregarDetalles.TabIndex = 32
        Me.btnAgregarDetalles.Tag = "Nuevo Registro"
        Me.btnAgregarDetalles.Text = "&Agregar Detalles"
        Me.btnAgregarDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarDetalles.UseVisualStyleBackColor = True
        '
        'txtdescripcionConcepto
        '
        Me.txtdescripcionConcepto.Location = New System.Drawing.Point(16, 148)
        Me.txtdescripcionConcepto.Name = "txtdescripcionConcepto"
        Me.txtdescripcionConcepto.Size = New System.Drawing.Size(360, 20)
        Me.txtdescripcionConcepto.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "&Descripcion de Concepto de Compras"
        '
        'txtcodigoConcepto
        '
        Me.txtcodigoConcepto.Location = New System.Drawing.Point(16, 102)
        Me.txtcodigoConcepto.Name = "txtcodigoConcepto"
        Me.txtcodigoConcepto.Size = New System.Drawing.Size(152, 20)
        Me.txtcodigoConcepto.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "&Codigo de Concepto de Compras"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(345, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(69, 52)
        Me.btn_salir.TabIndex = 27
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(278, 12)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(69, 52)
        Me.btn_cancelar.TabIndex = 28
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(211, 12)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(69, 52)
        Me.btn_eliminar.TabIndex = 29
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Editar.Location = New System.Drawing.Point(144, 12)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(69, 52)
        Me.btn_Editar.TabIndex = 30
        Me.btn_Editar.Text = "&Modificar"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(77, 12)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(69, 52)
        Me.btn_grabar.TabIndex = 26
        Me.btn_grabar.Text = "&Guardar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Nuevo.Location = New System.Drawing.Point(10, 12)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(69, 52)
        Me.btn_Nuevo.TabIndex = 31
        Me.btn_Nuevo.Tag = "Nuevo Registro"
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'FrmComprasConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(428, 366)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmComprasConceptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDetalles As System.Windows.Forms.Button
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents txtdescripcionConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
