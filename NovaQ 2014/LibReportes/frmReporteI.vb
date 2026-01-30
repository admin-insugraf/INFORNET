Imports System.Windows.Forms

Public Class frmReporteI
    Private STRTitulo As String

    Public Property Titulo As String
        Get
            Return STRTitulo
        End Get
        Set(value As String)
            STRTitulo = value
        End Set
    End Property

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Titulo
        Me.WindowState = FormWindowState.Maximized
        Me.CRVisor1.RefreshReport()
    End Sub

End Class