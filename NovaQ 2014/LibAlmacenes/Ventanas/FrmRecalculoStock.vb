Imports System.Windows.Forms

Public Class FrmRecalculoStock

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtReporteRecalculo As DataTable

    Dim clsBusquedaBl As ClsBuscar
    Dim dtUltimoMes As DataTable
    Dim dtAlmacen As DataTable


    Private Sub UltimoMesSinValorizar()
        Try
            clsBusquedaBl = New ClsBuscar
            dtUltimoMes = New DataTable
            dtUltimoMes = clsBusquedaBl.Get_MesSinValorizar()
            If dtUltimoMes.Rows.Count() <> 0 Then
                dtpfechaInicio.Value = dtUltimoMes.Rows(0).Item("Fecha").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function MostrandoAlmacenes() As String
        Dim Cadena As String = String.Empty
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtAlmacen.Rows.Count() <> 0 Then
                Dim id As String = ""
                Dim i As Integer = 0
                Do While i <= dtAlmacen.Rows.Count() - 1
                    id = id & """" & dtAlmacen.Rows(i).Item("CODIGO") & """" & ","
                    i = i + 1
                Loop
                id = Mid(id, 1, id.Length - 1)
                Cadena = id
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function

    Private Sub FrmRecalculoStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltimoMesSinValorizar()
    End Sub

    Private Sub checkArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles checkArticulo.CheckedChanged
        If checkArticulo.Checked Then
            GbArticulos.Enabled = False
        Else
            GbArticulos.Enabled = True
        End If
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick

    End Sub

    Private Sub txtFinArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinArticulo.MouseDoubleClick

    End Sub
    Private Function Validaciones(ByRef IDE As String, ByRef alma As String,
                               ByRef fechaInicial As String, ByRef FechaFinal As String,
                              ByRef todos As String) As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            'AÑO 
            fechaInicial = dtpfechaInicio.Value
            FechaFinal = dtpfechaFin.Value

            IDE = System.Net.Dns.GetHostName()
            alma = MostrandoAlmacenes()

            'Seleccionando ARTICULO
            If checkArticulo.Checked = True Then
                todos = 0
            Else
                If txtinicioArticulo.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                    txtinicioArticulo.Focus()
                    Exit Try
                ElseIf txtFinArticulo.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                    txtFinArticulo.Focus()
                    Exit Try
                End If
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Public Sub MostrarReportes(ByVal IDE As String, ByVal almacen As String, ByVal fechaInicial As String, ByVal FechaFinal As String, ByVal todos As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dtReporteRecalculo = New DataTable()
            dtReporteRecalculo = reporteBL.Get_ImprimirReporte_Recalculo_Stock(IDE, almacen, fechaInicial, FechaFinal, todos, ProgressBar1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim refIDE As String = String.Empty
        Dim Refalma As String = String.Empty
        Dim refTODOS As String = String.Empty
        Dim refFechaIni As String = String.Empty
        Dim refFechaFin As String = String.Empty
        If Validaciones(refIDE, Refalma, refFechaIni, refFechaFin, refTODOS) = False Then Exit Sub
        If MsgBox("Este proceso actualizará el stock tomando como punto de partida el saldo del mes anterior " & Chr("13") & "Desea proceder?", vbInformation + vbYesNo, "Aviso") = vbYes Then
            ProgressBar1.Visible = True
            MostrarReportes(refIDE, Refalma, refFechaIni, refFechaFin, refTODOS)
            MsgBox("Proceso concluido exitosamente.", MsgBoxStyle.Information, "Aviso")
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class