Imports System.Windows.Forms
Public Class FrmCalendario
    Protected dtHelp As New DataTable
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        Call DevuelveDatos()
    End Sub
    Private Sub DevuelveDatos()
        Try
            Dim miFila As DataRow
            dtHelp = New DataTable

            dtHelp.Columns.Add("fecha")
            miFila = dtHelp.NewRow
            miFila("fecha") = MonthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy")
            dtHelp.Rows.Add(miFila)
            Data_Matriz = dtHelp
            'txtBuscar.Clear()
            Me.Close()
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Property Data_Matriz() As DataTable
        Get
            Return dtHelp
        End Get
        Set(ByVal Value As DataTable)
            dtHelp = Value
        End Set
    End Property

   
End Class