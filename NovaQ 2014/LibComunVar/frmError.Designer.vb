<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(71, 59)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(142, 144)
        Me.txtError.TabIndex = 1
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtError)
        Me.Name = "frmError"
        Me.Text = "frmError"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtError As System.Windows.Forms.TextBox
End Class
