Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmStkMensual_Almacen
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Private Sub FrmStkMensual_Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MostrandoAlmacenes()
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicio.Focus()
    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtAlmacen.Rows.Count() <> 0 Then
                chklstAlmacenes.Items.Clear()
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtAlmacen.Rows(i).Item("DESCRIPCION").ToString)
                Next
                'chklstAlmacenes.SelectedIndex = 1
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim refIDE As String = String.Empty
        Dim Refalma As String = String.Empty
        Dim reffechaINI As String = String.Empty
        Dim reffechaFIN As String = String.Empty
        Dim refART1 As String = String.Empty
        Dim refART2 As String = String.Empty
        Dim refTODOSMOV As String = String.Empty
        Dim refTODOS As String = String.Empty
        Dim refmesAnt As String = String.Empty
        Dim refanoAnt As String = String.Empty
        Dim refmesActual As String = String.Empty
        Dim refanoAct As String = String.Empty
        Dim refLOTE As String = String.Empty
        'Validaciones Generales


        If ValidacionesLotes(refIDE, reffechaINI, reffechaFIN, refART1, refART2, refTODOSMOV, refTODOS, refmesAnt, refanoAnt, refmesActual, refanoAct, refLOTE) = False Then Exit Sub
        ''Mostrando Reportes 
        MostrarReportes(refIDE, reffechaINI, reffechaFIN, refART1, refART2, refTODOSMOV, refTODOS, refmesAnt, refanoAnt, refmesActual, refanoAct, refLOTE)
    End Sub
    Private Function ValidacionesLotes(ByRef IDE As String, ByRef fechaINI As String,
                       ByRef fechaFIN As String, ByRef ART1 As String, ByRef ART2 As String, ByRef TODOSMOV As String, ByRef TODOS As String,
                       ByRef mesAnt As String, ByRef anoAnt As String, ByRef mesActual As String, ByRef anoAct As String, ByRef LOTE As String) As Boolean
        Dim estado As Boolean = True
        Try
            If chklstAlmacenes.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos un almacen.", MsgBoxStyle.Exclamation)
                estado = False
                Exit Try
            End If
            ART1 = ""
            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")

        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function
    Public Sub MostrarReportes(ByVal IDE As String, ByVal fechaINI As String,
                       ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                       ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Dim lista As New List(Of String)
            Dim idAlmacen As String = String.Empty
            Dim i As Integer = 0
            Dim DT_NOM_EMPRESA As DataTable, NOMBRE_EMPRESA As String
            Me.Cursor = Cursors.WaitCursor
            lista = New List(Of String)
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If

            DT_NOM_EMPRESA = New DataTable
            DT_NOM_EMPRESA = reporteBL.Get_Nombre_Empresa()
            If DT_NOM_EMPRESA.Rows.Count > 0 Then
                NOMBRE_EMPRESA = DT_NOM_EMPRESA.Rows(0).Item("REPORT_SCREEN").ToString
            Else
                NOMBRE_EMPRESA = ""
            End If

            Dim anio_anterior_ As String
            anio_anterior_ = (dtpfechaInicio.Value.Year - 1)
            dtReporteKardex = New DataTable("articulo_todos")
            dtReporteKardex = reporteBL.Get_ImprimirReporte_Stock_Mensual_Almacen(ART1, idAlmacen, "", _
                                                                          dtpfechaInicio.Value.Year.ToString, dtpfechaInicio.Value.ToString("dd/MM/yyyy"))
            If dtReporteKardex.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("RPTSTKMENSUAL_ALMACEN.rpt", dtReporteKardex, "", "", "", "ART_INI;" & "", _
                                          "@FECHA;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@ANIO;" & dtpfechaInicio.Value.Year.ToString, "@MES;" & "", _
                                          "@ALMACEN;" & idAlmacen, "@FAMILIA_ID;" & ART1, "EMPRESA;" & NOMBRE_EMPRESA, _
                                          "FECHA;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"))
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub checkAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles checkAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklstAlmacenes.Focus()
        End If
    End Sub

    Private Sub chklstAlmacenes_KeyDown(sender As Object, e As KeyEventArgs) Handles chklstAlmacenes.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMostrar.Select()
        End If
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes.Items.Count - 1
            chklstAlmacenes.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub
End Class