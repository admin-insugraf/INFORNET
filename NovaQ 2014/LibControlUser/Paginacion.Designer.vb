<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paginacion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPagina = New System.Windows.Forms.NumericUpDown()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        CType(Me.txtPagina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(161, 14)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 16)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(143, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "de"
        '
        'txtPagina
        '
        Me.txtPagina.Enabled = False
        Me.txtPagina.Location = New System.Drawing.Point(85, 12)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.Size = New System.Drawing.Size(55, 20)
        Me.txtPagina.TabIndex = 11
        '
        'btnLast
        '
        Me.btnLast.Enabled = False
        Me.btnLast.FlatAppearance.BorderSize = 0
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Image = Global.LibControlUser.My.Resources.Resources.last
        Me.btnLast.Location = New System.Drawing.Point(258, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(35, 35)
        Me.btnLast.TabIndex = 10
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = Global.LibControlUser.My.Resources.Resources._next
        Me.btnNext.Location = New System.Drawing.Point(217, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 35)
        Me.btnNext.TabIndex = 9
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Image = Global.LibControlUser.My.Resources.Resources.previos
        Me.btnPrevious.Location = New System.Drawing.Point(44, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(35, 35)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Enabled = False
        Me.btnFirst.FlatAppearance.BorderSize = 0
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Image = Global.LibControlUser.My.Resources.Resources.first
        Me.btnFirst.Location = New System.Drawing.Point(3, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(35, 35)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'Paginacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "Paginacion"
        Me.Size = New System.Drawing.Size(630, 41)
        CType(Me.txtPagina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button

End Class
