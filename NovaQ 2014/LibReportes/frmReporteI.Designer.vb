<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteI
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRVisor1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer() 'Microsoft.Reporting.WinForms.ReportViewer()
        Me.CRVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CRVisor"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(453, 376)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CRVisor1
        '
        Me.CRVisor1.Location = New System.Drawing.Point(328, 35)
        Me.CRVisor1.Name = "CRVisor1"
        Me.CRVisor1.Size = New System.Drawing.Size(396, 246)
        Me.CRVisor1.TabIndex = 1
        '
        'CRVisor
        '
        Me.CRVisor.ActiveViewIndex = -1
        Me.CRVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVisor.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVisor.Location = New System.Drawing.Point(0, 0)
        Me.CRVisor.Name = "CRVisor"
        Me.CRVisor.Size = New System.Drawing.Size(453, 376)
        Me.CRVisor.TabIndex = 0
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 376)
        Me.Controls.Add(Me.CRVisor1)
        Me.Controls.Add(Me.CRVisor)
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVisor1 As CrystalDecisions.Windows.Forms.CrystalReportViewer 'Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents CRVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
