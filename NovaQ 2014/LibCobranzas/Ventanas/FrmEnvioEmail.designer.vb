<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnvioEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnvioEmail))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lbl_nombre_xml = New System.Windows.Forms.Label()
        Me.lbl_nombre_pdf = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblde = New System.Windows.Forms.Label()
        Me.lbldelinea = New System.Windows.Forms.Label()
        Me.txtremitente = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtMensaje)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(10, 17)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(435, 157)
        Me.txtMensaje.TabIndex = 7
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WebBrowser1)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_xml)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_pdf)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
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
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 463)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 235)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(456, 220)
        Me.WebBrowser1.TabIndex = 26
        '
        'lbl_nombre_xml
        '
        Me.lbl_nombre_xml.AutoSize = True
        Me.lbl_nombre_xml.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_xml.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_nombre_xml.Location = New System.Drawing.Point(62, 205)
        Me.lbl_nombre_xml.Name = "lbl_nombre_xml"
        Me.lbl_nombre_xml.Size = New System.Drawing.Size(134, 18)
        Me.lbl_nombre_xml.TabIndex = 23
        Me.lbl_nombre_xml.Text = "ENVIO DE EMAIL"
        '
        'lbl_nombre_pdf
        '
        Me.lbl_nombre_pdf.AutoSize = True
        Me.lbl_nombre_pdf.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_pdf.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_nombre_pdf.Location = New System.Drawing.Point(62, 169)
        Me.lbl_nombre_pdf.Name = "lbl_nombre_pdf"
        Me.lbl_nombre_pdf.Size = New System.Drawing.Size(134, 18)
        Me.lbl_nombre_pdf.TabIndex = 22
        Me.lbl_nombre_pdf.Text = "ENVIO DE EMAIL"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 197)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
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
        Me.txtremitente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremitente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremitente.Location = New System.Drawing.Point(65, 46)
        Me.txtremitente.Name = "txtremitente"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(501, 25)
        Me.ToolStrip1.TabIndex = 13
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
        'FrmEnvioEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 487)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEnvioEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblde As System.Windows.Forms.Label
    Friend WithEvents lbldelinea As System.Windows.Forms.Label
    Friend WithEvents txtremitente As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nombre_xml As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_pdf As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
