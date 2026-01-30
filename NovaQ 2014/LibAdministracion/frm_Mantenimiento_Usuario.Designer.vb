<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mantenimiento_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Mantenimiento_Usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.gbUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtConfirmaPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.gbUsuarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descripción Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nivel acceso"
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUsuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtCodUsuario.Location = New System.Drawing.Point(10, 37)
        Me.txtCodUsuario.MaxLength = 20
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(295, 21)
        Me.txtCodUsuario.TabIndex = 1
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtNombreUsuario.Location = New System.Drawing.Point(9, 75)
        Me.txtNombreUsuario.MaxLength = 50
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(296, 21)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(157, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "&Perfil de Acceso"
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.ForeColor = System.Drawing.Color.Black
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(10, 121)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(128, 24)
        Me.cboNivel.TabIndex = 27
        '
        'cboPerfil
        '
        Me.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfil.ForeColor = System.Drawing.Color.Black
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(159, 121)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(128, 24)
        Me.cboPerfil.TabIndex = 28
        '
        'gbUsuarios
        '
        Me.gbUsuarios.Controls.Add(Me.cboPerfil)
        Me.gbUsuarios.Controls.Add(Me.cboNivel)
        Me.gbUsuarios.Controls.Add(Me.Label9)
        Me.gbUsuarios.Controls.Add(Me.txtNombreUsuario)
        Me.gbUsuarios.Controls.Add(Me.txtCodUsuario)
        Me.gbUsuarios.Controls.Add(Me.Label5)
        Me.gbUsuarios.Controls.Add(Me.Label2)
        Me.gbUsuarios.Controls.Add(Me.Label1)
        Me.gbUsuarios.Enabled = False
        Me.gbUsuarios.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbUsuarios.ForeColor = System.Drawing.Color.Black
        Me.gbUsuarios.Location = New System.Drawing.Point(24, 58)
        Me.gbUsuarios.Name = "gbUsuarios"
        Me.gbUsuarios.Size = New System.Drawing.Size(324, 157)
        Me.gbUsuarios.TabIndex = 25
        Me.gbUsuarios.TabStop = False
        '
        'txtConfirmaPassword
        '
        Me.txtConfirmaPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmaPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmaPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmaPassword.Location = New System.Drawing.Point(170, 39)
        Me.txtConfirmaPassword.MaxLength = 15
        Me.txtConfirmaPassword.Name = "txtConfirmaPassword"
        Me.txtConfirmaPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaPassword.Size = New System.Drawing.Size(143, 21)
        Me.txtConfirmaPassword.TabIndex = 4
        Me.txtConfirmaPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(171, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Repetir Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(22, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contraseña Nueva"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(21, 38)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(143, 21)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtConfirmaPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(23, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 67)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento de contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(0, 32)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(369, 21)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = "CAMBIO DE CONTRASEÑA"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_aceptar, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(369, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(123, 22)
        Me.btn_aceptar.Text = "Aceptar Cambios"
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
        'frm_Mantenimiento_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(369, 301)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Mantenimiento_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Mantenimiento_Usuario"
        Me.gbUsuarios.ResumeLayout(False)
        Me.gbUsuarios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
    Friend WithEvents cboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents gbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmaPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
