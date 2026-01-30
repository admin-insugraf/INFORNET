<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Envio_Email_Rpta_Pre_Flyte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Envio_Email_Rpta_Pre_Flyte))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lbl_nombre_pdf = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblde = New System.Windows.Forms.Label()
        Me.lbldelinea = New System.Windows.Forms.Label()
        Me.txtremitente = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(501, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.Color.Navy
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 22)
        Me.btnCancelar.Text = "&Enviar "
        '
        'btn_salir
        '
        Me.btn_salir.ForeColor = System.Drawing.Color.Navy
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(49, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.WebBrowser1)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_pdf)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblde)
        Me.GroupBox1.Controls.Add(Me.lbldelinea)
        Me.GroupBox1.Controls.Add(Me.txtremitente)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAsunto)
        Me.GroupBox1.Controls.Add(Me.txtPara)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 463)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 170)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(456, 283)
        Me.WebBrowser1.TabIndex = 20
        '
        'lbl_nombre_pdf
        '
        Me.lbl_nombre_pdf.AutoSize = True
        Me.lbl_nombre_pdf.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_pdf.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_nombre_pdf.Location = New System.Drawing.Point(65, 170)
        Me.lbl_nombre_pdf.Name = "lbl_nombre_pdf"
        Me.lbl_nombre_pdf.Size = New System.Drawing.Size(134, 18)
        Me.lbl_nombre_pdf.TabIndex = 26
        Me.lbl_nombre_pdf.Text = "ENVIO DE EMAIL"
        Me.lbl_nombre_pdf.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 162)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.ForeColor = System.Drawing.Color.Navy
        Me.lblde.Location = New System.Drawing.Point(19, 49)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(24, 13)
        Me.lblde.TabIndex = 17
        Me.lblde.Text = "De:"
        '
        'lbldelinea
        '
        Me.lbldelinea.AutoSize = True
        Me.lbldelinea.Location = New System.Drawing.Point(30, 67)
        Me.lbldelinea.Name = "lbldelinea"
        Me.lbldelinea.Size = New System.Drawing.Size(433, 13)
        Me.lbldelinea.TabIndex = 19
        Me.lbldelinea.Text = "---------------------------------------------------------------------------------" & _
    "-------------------------------------------------------------"
        '
        'txtremitente
        '
        Me.txtremitente.BackColor = System.Drawing.Color.White
        Me.txtremitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremitente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremitente.Location = New System.Drawing.Point(65, 46)
        Me.txtremitente.Name = "txtremitente"
        Me.txtremitente.ReadOnly = True
        Me.txtremitente.Size = New System.Drawing.Size(401, 21)
        Me.txtremitente.TabIndex = 18
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(169, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(110, 16)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "ENVIO DE EMAIL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtMensaje)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.Maroon
        Me.txtMensaje.Location = New System.Drawing.Point(10, 17)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(435, 118)
        Me.txtMensaje.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(436, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "---------------------------------------------------------------------------------" & _
    "--------------------------------------------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Para:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------------------------------------------------------------------------" & _
    "-------------------------------------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(19, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Asunto:"
        '
        'txtAsunto
        '
        Me.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsunto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(65, 124)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(400, 21)
        Me.txtAsunto.TabIndex = 7
        '
        'txtPara
        '
        Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPara.Location = New System.Drawing.Point(65, 85)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(401, 21)
        Me.txtPara.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(19, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Obs.:"
        Me.Label6.Visible = False
        '
        'txt_observaciones
        '
        Me.txt_observaciones.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.ForeColor = System.Drawing.Color.Navy
        Me.txt_observaciones.Location = New System.Drawing.Point(63, 230)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(400, 21)
        Me.txt_observaciones.TabIndex = 22
        Me.txt_observaciones.Visible = False
        '
        'Frm_Envio_Email_Rpta_Pre_Flyte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 487)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Envio_Email_Rpta_Pre_Flyte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lbl_nombre_pdf As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblde As System.Windows.Forms.Label
    Friend WithEvents lbldelinea As System.Windows.Forms.Label
    Friend WithEvents txtremitente As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
End Class
