Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmStkMensual
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Private Sub FrmStkMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicio.Focus()
    End Sub
    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarLineas_Ayuda(txtarticuloInicial.Text)
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

    Private Sub txtarticuloInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticuloInicial.MouseDoubleClick
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_TIPO_ARTICULO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipo de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticuloInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtfamiliadesc.Text = frm.Data_Matriz.Rows(0).Item(1)
                MostrandoAlmacenes()
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticuloInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticuloInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticuloInicial_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            checkAlmacen.Focus()
        End If
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
            If txtarticuloInicial.Text = "" Then
                MessageBox.Show("Debe seleccionar un Tipo de Articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtarticuloInicial.Focus()
                estado = False
                Exit Try
            End If
            If chklstAlmacenes.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos una Familia.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            ART1 = txtarticuloInicial.Text
            fechaINI = dtpfechaInicio.Value.ToString("yyyy") + dtpfechaInicio.Value.ToString("MM")

        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
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

            dtReporteKardex = New DataTable("articulo_todos")
            dtReporteKardex = reporteBL.Get_ImprimirReporte_Stock_Mensual(ART1, idAlmacen, Format(dtpfechaInicio.Value.Month, "00"), dtpfechaInicio.Value.Year.ToString, dtpfechaInicio.Value.ToString("dd/MM/yyyy"))
            If dtReporteKardex.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("RPTSTKMENSUAL.rpt", dtReporteKardex, "", "", "", "ART_INI;" & txtfamiliadesc.Text, _
                                          "@FECHA;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@ANIO;" & dtpfechaInicio.Value.Year.ToString, _
                                          "@MES;" & dtpfechaInicio.Value.Month.ToString, "@LINEAS;" & idAlmacen, "@FAMILIA_ID;" & ART1, "EMPRESA;" & NOMBRE_EMPRESA, _
                                          "MES_ANIO;" & dtpfechaInicio.Value.ToString("MMMM") & "/" & dtpfechaInicio.Value.Year.ToString)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub dtpfechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtarticuloInicial.Focus()
        End If
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