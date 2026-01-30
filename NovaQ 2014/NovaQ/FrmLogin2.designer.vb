<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin2))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnminimizar = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(250, 330)
        Me.panel1.TabIndex = 1
        '
        'pictureBox3
        '
        Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(250, 330)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox3.TabIndex = 0
        Me.pictureBox3.TabStop = False
        '
        'btnminimizar
        '
        Me.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimizar.Image = CType(resources.GetObject("btnminimizar.Image"), System.Drawing.Image)
        Me.btnminimizar.Location = New System.Drawing.Point(740, 3)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(15, 15)
        Me.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnminimizar.TabIndex = 14
        Me.btnminimizar.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(761, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(15, 15)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.TabStop = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.ForeColor = System.Drawing.Color.LightGray
        Me.btnIngresar.Location = New System.Drawing.Point(310, 264)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(408, 40)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "ACCEDER"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(310, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(408, 40)
        Me.label1.TabIndex = 12
        Me.label1.Text = "LOGIN"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Silver
        Me.txtpassword.Location = New System.Drawing.Point(310, 197)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(408, 20)
        Me.txtpassword.TabIndex = 10
        Me.txtpassword.Text = "Contraseña"
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.ForeColor = System.Drawing.Color.Silver
        Me.txtusuario.Location = New System.Drawing.Point(310, 132)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(408, 20)
        Me.txtusuario.TabIndex = 9
        Me.txtusuario.Text = "Usuario"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(191, 295)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 17
        Me.dtpFecha.Visible = False
        '
        'cboEmpresas
        '
        Me.cboEmpresas.BackColor = System.Drawing.Color.White
        Me.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpresas.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.Location = New System.Drawing.Point(416, 69)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(302, 29)
        Me.cboEmpresas.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(307, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(413, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "---------------------------------------------------------------------------------" & _
    "--------------------------------------------------------------"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(307, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "---------------------------------------------------------------------------------" & _
    "--------------------------------------------------------------"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(307, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Empresa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(543, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Actualizar Sistema"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmLogin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 330)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboEmpresas)
        Me.Controls.Add(Me.btnminimizar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin2"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin2"
        Me.panel1.ResumeLayout(False)
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents btnminimizar As System.Windows.Forms.PictureBox
    Private WithEvents btnSalir As System.Windows.Forms.PictureBox
    Private WithEvents btnIngresar As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtpassword As System.Windows.Forms.TextBox
    Private WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEmpresas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
