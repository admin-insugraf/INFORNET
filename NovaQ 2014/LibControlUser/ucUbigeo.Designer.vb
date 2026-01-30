<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUbigeo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUbigeo))
        Me.lblUbigeo = New System.Windows.Forms.Label()
        Me.txtCodUbigeo = New System.Windows.Forms.TextBox()
        Me.txtDesUbigeo = New System.Windows.Forms.TextBox()
        Me.pbHelp = New System.Windows.Forms.PictureBox()
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUbigeo
        '
        Me.lblUbigeo.AutoSize = True
        Me.lblUbigeo.Location = New System.Drawing.Point(3, 4)
        Me.lblUbigeo.Name = "lblUbigeo"
        Me.lblUbigeo.Size = New System.Drawing.Size(41, 13)
        Me.lblUbigeo.TabIndex = 0
        Me.lblUbigeo.Text = "Ubigeo"
        '
        'txtCodUbigeo
        '
        Me.txtCodUbigeo.Location = New System.Drawing.Point(51, 1)
        Me.txtCodUbigeo.Name = "txtCodUbigeo"
        Me.txtCodUbigeo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodUbigeo.TabIndex = 1
        '
        'txtDesUbigeo
        '
        Me.txtDesUbigeo.Location = New System.Drawing.Point(155, 1)
        Me.txtDesUbigeo.Name = "txtDesUbigeo"
        Me.txtDesUbigeo.Size = New System.Drawing.Size(387, 20)
        Me.txtDesUbigeo.TabIndex = 2
        '
        'pbHelp
        '
        Me.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHelp.Image = CType(resources.GetObject("pbHelp.Image"), System.Drawing.Image)
        Me.pbHelp.Location = New System.Drawing.Point(123, 0)
        Me.pbHelp.Name = "pbHelp"
        Me.pbHelp.Size = New System.Drawing.Size(26, 22)
        Me.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHelp.TabIndex = 3
        Me.pbHelp.TabStop = False
        '
        'ucUbigeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbHelp)
        Me.Controls.Add(Me.txtDesUbigeo)
        Me.Controls.Add(Me.txtCodUbigeo)
        Me.Controls.Add(Me.lblUbigeo)
        Me.Name = "ucUbigeo"
        Me.Size = New System.Drawing.Size(545, 22)
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUbigeo As System.Windows.Forms.Label
    Friend WithEvents txtCodUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents txtDesUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents pbHelp As System.Windows.Forms.PictureBox

End Class
