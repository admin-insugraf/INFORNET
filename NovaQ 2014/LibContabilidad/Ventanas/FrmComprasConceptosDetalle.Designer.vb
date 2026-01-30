<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprasConceptosDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprasConceptosDetalle))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlcabecera = New System.Windows.Forms.Panel()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.pnlDetalleconcepto = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.pnlcabeceraConcepto = New System.Windows.Forms.Panel()
        Me.txtdescripcionConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_des_cta = New System.Windows.Forms.TextBox()
        Me.txtcodigoConcepto = New System.Windows.Forms.TextBox()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.pnlcabecera.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetalleconcepto.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcabeceraConcepto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlcabecera)
        Me.GroupBox1.Controls.Add(Me.pnlDetalleconcepto)
        Me.GroupBox1.Controls.Add(Me.pnlcabeceraConcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'pnlcabecera
        '
        Me.pnlcabecera.Controls.Add(Me.dgvCabecera)
        Me.pnlcabecera.Location = New System.Drawing.Point(9, 19)
        Me.pnlcabecera.Name = "pnlcabecera"
        Me.pnlcabecera.Size = New System.Drawing.Size(571, 283)
        Me.pnlcabecera.TabIndex = 38
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Location = New System.Drawing.Point(14, 14)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecera.Size = New System.Drawing.Size(534, 263)
        Me.dgvCabecera.TabIndex = 0
        '
        'pnlDetalleconcepto
        '
        Me.pnlDetalleconcepto.Controls.Add(Me.Label4)
        Me.pnlDetalleconcepto.Controls.Add(Me.dgvDetalle)
        Me.pnlDetalleconcepto.Controls.Add(Me.btneliminar)
        Me.pnlDetalleconcepto.Controls.Add(Me.Label3)
        Me.pnlDetalleconcepto.Controls.Add(Me.btnmodificar)
        Me.pnlDetalleconcepto.Controls.Add(Me.btninsertar)
        Me.pnlDetalleconcepto.Location = New System.Drawing.Point(9, 97)
        Me.pnlDetalleconcepto.Name = "pnlDetalleconcepto"
        Me.pnlDetalleconcepto.Size = New System.Drawing.Size(563, 205)
        Me.pnlDetalleconcepto.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(13, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "&Double click para editar un registro."
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(11, 47)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(542, 133)
        Me.dgvDetalle.TabIndex = 1
        '
        'btneliminar
        '
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.Location = New System.Drawing.Point(464, 4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(88, 40)
        Me.btneliminar.TabIndex = 124
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "&Detalles de los Registros"
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.Location = New System.Drawing.Point(377, 4)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(88, 40)
        Me.btnmodificar.TabIndex = 123
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btninsertar
        '
        Me.btninsertar.Image = CType(resources.GetObject("btninsertar.Image"), System.Drawing.Image)
        Me.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btninsertar.Location = New System.Drawing.Point(290, 4)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(88, 40)
        Me.btninsertar.TabIndex = 119
        Me.btninsertar.Text = "&Adicionar"
        Me.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'pnlcabeceraConcepto
        '
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtdescripcionConcepto)
        Me.pnlcabeceraConcepto.Controls.Add(Me.Label1)
        Me.pnlcabeceraConcepto.Controls.Add(Me.PictureBox1)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txt_des_cta)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtcodigoConcepto)
        Me.pnlcabeceraConcepto.Controls.Add(Me.txtCuentaContable)
        Me.pnlcabeceraConcepto.Controls.Add(Me.PictureBox6)
        Me.pnlcabeceraConcepto.Controls.Add(Me.Label2)
        Me.pnlcabeceraConcepto.Location = New System.Drawing.Point(9, 19)
        Me.pnlcabeceraConcepto.Name = "pnlcabeceraConcepto"
        Me.pnlcabeceraConcepto.Size = New System.Drawing.Size(563, 72)
        Me.pnlcabeceraConcepto.TabIndex = 39
        '
        'txtdescripcionConcepto
        '
        Me.txtdescripcionConcepto.Location = New System.Drawing.Point(210, 12)
        Me.txtdescripcionConcepto.Name = "txtdescripcionConcepto"
        Me.txtdescripcionConcepto.ReadOnly = True
        Me.txtdescripcionConcepto.Size = New System.Drawing.Size(343, 20)
        Me.txtdescripcionConcepto.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concepto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'txt_des_cta
        '
        Me.txt_des_cta.Location = New System.Drawing.Point(210, 38)
        Me.txt_des_cta.Name = "txt_des_cta"
        Me.txt_des_cta.ReadOnly = True
        Me.txt_des_cta.Size = New System.Drawing.Size(343, 20)
        Me.txt_des_cta.TabIndex = 114
        '
        'txtcodigoConcepto
        '
        Me.txtcodigoConcepto.Location = New System.Drawing.Point(96, 12)
        Me.txtcodigoConcepto.Name = "txtcodigoConcepto"
        Me.txtcodigoConcepto.ReadOnly = True
        Me.txtcodigoConcepto.Size = New System.Drawing.Size(90, 20)
        Me.txtcodigoConcepto.TabIndex = 121
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Location = New System.Drawing.Point(96, 38)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(90, 20)
        Me.txtCuentaContable.TabIndex = 115
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(190, 39)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 116
        Me.PictureBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Cuenta Contable"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(449, 6)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(69, 52)
        Me.btn_salir.TabIndex = 33
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(382, 6)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(69, 52)
        Me.btn_cancelar.TabIndex = 34
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(315, 6)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(69, 52)
        Me.btn_eliminar.TabIndex = 35
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Editar.Location = New System.Drawing.Point(248, 6)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(69, 52)
        Me.btn_Editar.TabIndex = 36
        Me.btn_Editar.Text = "&Modificar"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_grabar.Location = New System.Drawing.Point(181, 6)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(69, 52)
        Me.btn_grabar.TabIndex = 32
        Me.btn_grabar.Text = "&Guardar"
        Me.btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Nuevo.Location = New System.Drawing.Point(114, 6)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(69, 52)
        Me.btn_Nuevo.TabIndex = 37
        Me.btn_Nuevo.Tag = "Nuevo Registro"
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'FrmComprasConceptosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(602, 378)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmComprasConceptosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos Compras Detalles"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlcabecera.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetalleconcepto.ResumeLayout(False)
        Me.pnlDetalleconcepto.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcabeceraConcepto.ResumeLayout(False)
        Me.pnlcabeceraConcepto.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Private WithEvents txt_des_cta As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txtcodigoConcepto As System.Windows.Forms.TextBox
    Private WithEvents txtdescripcionConcepto As System.Windows.Forms.TextBox
    Friend WithEvents btninsertar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDetalleconcepto As System.Windows.Forms.Panel
    Friend WithEvents pnlcabeceraConcepto As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
