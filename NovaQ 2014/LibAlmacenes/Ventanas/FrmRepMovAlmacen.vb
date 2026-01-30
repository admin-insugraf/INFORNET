Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Public Class FrmRepMovAlmacen
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Private Sub FrmRepMovAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
        cbotipodoc.SelectedIndex = 0
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
                chklstAlmacenes.SelectedIndex = 1
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticuloInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtmovinicial.MouseDoubleClick
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_TRANSACTION_TYPE_ARTICULO_AYUDA"
            frm._Flag_Filtro = True
            frm._Flag_Inventario = True
            frm.Filtros1 = IIf(cbotipodoc.SelectedIndex = 0, "I", "S")
            frm.Filtros2 = ""
            frm.CadenaConsulta = sql
            frm.Titulo = "Transacciones"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtmovinicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtmovinicialdesc.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticuloInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmovinicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticuloInicial_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            txtmovfinal.Focus()
        End If
    End Sub

    Private Sub txtarticulofinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtmovfinal.MouseDoubleClick
        Try
            If txtmovinicial.Text = String.Empty Then Exit Sub
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_TRANSACTION_TYPE_ARTICULO_AYUDA"
            frm._Flag_Filtro = True
            frm._Flag_Inventario = True
            frm.Filtros1 = IIf(cbotipodoc.SelectedIndex = 0, "I", "S")
            frm.Filtros2 = ""
            frm.CadenaConsulta = sql
            frm.Titulo = "Transacciones"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtmovfinal.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtmovfinaldesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticulofinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmovfinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticulofinal_MouseDoubleClick(Nothing, Nothing)
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
        If chklstAlmacenes.CheckedItems.Count() = 0 Then
            MsgBox("Debe seleccionar al menos un Almacen.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If ValidacionesLotes(refIDE, reffechaINI, reffechaFIN, refART1, refART2, refTODOSMOV, refTODOS, refmesAnt, refanoAnt, refmesActual, refanoAct, refLOTE) = False Then Exit Sub
        ''Mostrando Reportes 
        MostrarReportes(refIDE, reffechaINI, reffechaFIN, refART1, refART2, refTODOSMOV, refTODOS, refmesAnt, refanoAnt, refmesActual, refanoAct, refLOTE)
    End Sub
    Private Function ValidacionesLotes(ByRef IDE As String, ByRef fechaINI As String,
                       ByRef fechaFIN As String, ByRef ART1 As String, ByRef ART2 As String, ByRef TODOSMOV As String, ByRef TODOS As String,
                       ByRef mesAnt As String, ByRef anoAnt As String, ByRef mesActual As String, ByRef anoAct As String, ByRef LOTE As String) As Boolean
        Dim estado As Boolean = True
        Try

            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            fechaINI = dtpfechaInicio.Value.ToString("yyyy") + dtpfechaInicio.Value.ToString("MM")
            fechaFIN = dtpfechaFin.Value.ToString("yyyy") + dtpfechaFin.Value.ToString("MM")

            
                If txtmovinicial.Text <> "" And txtmovfinal.Text = "" Then
                    ART1 = txtmovinicial.Text
                    ART2 = txtmovinicial.Text
                ElseIf txtmovinicial.Text = "" And txtmovfinal.Text = "" Then
                    MessageBox.Show("Debe elegir por lo menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtmovinicial.Focus()
                    estado = False
                    Exit Try
                End If



        Catch ex As Exception
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
            Dim mesact As String
            Me.Cursor = Cursors.WaitCursor
            lista = New List(Of String)
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If

            If Month(dtpfechaInicio.Value) = 1 Then
                mesAnt = "12"
                mesact = "01"
                anoAnt = Format(Year(dtpfechaInicio.Value) - 1, "0000")
                anoAct = Year(dtpfechaFin.Value)
            Else
                mesAnt = Format(Month(dtpfechaInicio.Value) - 1, "00")
                mesact = Format(Month(dtpfechaInicio.Value), "00")
                anoAnt = Format(Year(dtpfechaInicio.Value), "0000")
                anoAct = Format(Year(dtpfechaFin.Value), "0000")
            End If

            DT_NOM_EMPRESA = New DataTable
            DT_NOM_EMPRESA = reporteBL.Get_Nombre_Empresa()
            If DT_NOM_EMPRESA.Rows.Count > 0 Then
                NOMBRE_EMPRESA = DT_NOM_EMPRESA.Rows(0).Item("REPORT_SCREEN").ToString
            Else
                NOMBRE_EMPRESA = ""
            End If

            dtReporteKardex = New DataTable("articulo_todos")
            dtReporteKardex = reporteBL.Get_ImprimirReporte_Stock_Lotes_Mensual(idAlmacen, fechaINI, fechaFIN, ART1, ART2)
            If dtReporteKardex.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("RPTSTKLOTESMENSUAL.rpt", "", "", "", "", "ART_INI;" & ART1, "ART_FIN;" & ART2, "@MES_INICIAL;" & fechaINI, "@MES_FINAL;" & fechaFIN, "@ALMACEN;" & idAlmacen, "EMPRESA;" & NOMBRE_EMPRESA, "@ART_INICIO;" & ART1, "@ART_FIN;" & ART2)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub checkLote_CheckedChanged(sender As Object, e As EventArgs)
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleCliente As New DataTable


        reporteBL = New ClsBuscar
        dtDetalleCliente = New DataTable
        Dim Cadena As String = String.Empty
        Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM PART "
        dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        If dtDetalleCliente.Rows.Count() <> 0 Then
            txtmovinicial.Text = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
            txtmovinicial.Enabled = False
        Else
            txtmovinicial.Text = String.Empty
        End If
        If txtmovinicial.Text = String.Empty Then Exit Sub
        reporteBL = New ClsBuscar
        dtDetalleCliente = New DataTable
        Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM PART "
        dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        If dtDetalleCliente.Rows.Count() <> 0 Then
            txtmovfinal.Text = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
            txtmovfinal.Enabled = False
        Else
            txtmovfinal.Text = String.Empty
        End If

    End Sub

    Private Sub dtpfechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpfechaFin.Focus()
        End If
    End Sub

    Private Sub dtpfechaFin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaFin.KeyDown
        If e.KeyCode = Keys.Enter Then
            checkAlmacen.Focus()
        End If
    End Sub

    Private Sub checkAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles checkAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklstAlmacenes.Focus()
        End If
    End Sub

    Private Sub chklstAlmacenes_KeyDown(sender As Object, e As KeyEventArgs) Handles chklstAlmacenes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmovinicial.Focus()
        End If
    End Sub

    Private Sub checkLote_KeyDown(sender As Object, e As KeyEventArgs)
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