
Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Public Class FrmReporteKardex_BA
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte

    Private Sub FrmReporteKardex_BA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
    End Sub

    Private Sub txtarticuloInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticuloInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticuloInicial_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtarticuloInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarticuloInicial.KeyPress

    End Sub

    Private Sub txtarticuloInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticuloInicial.MouseDoubleClick
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticuloInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
            End If
            frm.Close()
            checkLote.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticulofinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulofinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticulofinal_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtarticulofinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticulofinal.MouseDoubleClick
        Try
            If txtarticuloInicial.Text = String.Empty Then Exit Sub
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticulofinal.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
            If txtarticuloInicial.Text = txtarticulofinal.Text Then
                checkLote.Visible = True
                'TxtLote.Visible = True
            Else
                checkLote.Visible = False
                TxtLote.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtLote_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtLote.MouseDoubleClick
        Try
            If txtarticulofinal.Text = String.Empty Then Exit Sub
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_LOTE_CODIGO_AYUDA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtarticuloInicial.Text
            frm.Titulo = "Lotes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TxtLote.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkLote_CheckedChanged(sender As Object, e As EventArgs) Handles checkLote.CheckedChanged
        If checkLote.Checked = True Then
            TxtLote.Visible = True
            TxtLote.Text = String.Empty
            If txtarticulofinal.Text = String.Empty Then
                txtarticulofinal.Text = txtarticuloInicial.Text
            End If
        Else
            TxtLote.Visible = False
            TxtLote.Text = String.Empty
        End If
    End Sub

    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtarticuloInicial_TextChanged(sender As Object, e As EventArgs) Handles txtarticuloInicial.TextChanged

    End Sub

    Private Sub txtarticulofinal_TextChanged(sender As Object, e As EventArgs) Handles txtarticulofinal.TextChanged

    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes.Items.Count - 1
            chklstAlmacenes.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Public Property NombreReporte As String
        Get
            Return _NombreReporte
        End Get
        Set(value As String)
            _NombreReporte = value
        End Set
    End Property

  

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
            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fechaINI = (DateDiff("d", fechaINI, "01/01/1900") * -1)
            fechaFIN = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            fechaFIN = (DateDiff("d", fechaFIN, "01/01/1900") * -1)

            mesAnt = dtpfechaInicio.Value.AddMonths(-1).Month
            anoAnt = dtpfechaInicio.Value.AddYears(-1).Year

            mesActual = DateTime.Now.Month
            anoAct = DateTime.Now.Year

            Select Case NombreReporte
                Case "ReporteKardexReferenciaArticulo"
                    ART1 = txtarticuloInicial.Text
                    ART2 = txtarticulofinal.Text
                    If ART1 = String.Empty Then
                        estado = False
                        MsgBox("Debe seleccionar un articulo", MsgBoxStyle.Information)
                        txtarticuloInicial.Focus()
                        Exit Try
                    ElseIf ART2 = String.Empty Then
                        ART2 = ART1
                    End If
                    If ART1 = ART2 Then
                        If checkLote.Checked = True Then
                            LOTE = TxtLote.Text
                            If LOTE = String.Empty Then
                                estado = False
                                MsgBox("Debe seleccionar un lote", MsgBoxStyle.Information)
                                Exit Try
                            End If
                        End If
                    End If
                Case "ReporteKardexReferenciaLote"
                    ART1 = ""
                    ART2 = ""
                    TODOSMOV = "0"
                    TODOS = "1"
                    LOTE = "" ' txtLoteInicial.Text
                    If LOTE = String.Empty Then
                        MsgBox("Debe seleccionar un lote", MsgBoxStyle.Information)
                        'txtLoteInicial.Focus()
                        estado = False
                        Exit Try
                    End If
            End Select
            IDE = System.Net.Dns.GetHostName()
            If IDE = String.Empty Then
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
            Me.Cursor = Cursors.WaitCursor
            lista = New List(Of String)
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = TraerCodigo(chklstAlmacenes.CheckedItems(i))
                i = i + 1
                lista.Add(idAlmacen)
            Loop
            DT_NOM_EMPRESA = New DataTable
            DT_NOM_EMPRESA = reporteBL.Get_Nombre_Empresa()
            If DT_NOM_EMPRESA.Rows.Count > 0 Then
                NOMBRE_EMPRESA = DT_NOM_EMPRESA.Rows(0).Item("REPORT_SCREEN").ToString
            Else
                NOMBRE_EMPRESA = ""
            End If
            Select Case NombreReporte
                Case "ReporteKardexReferenciaArticulo"
                    If checkLote.Checked = True Then
                        If checkAlmacen.Checked = True Then
                            dtReporteKardex = New DataTable("articulo_todos")
                            dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos_todos(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                            If dtReporteKardex.Rows.Count() <> 0 Then
                                crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "VARIOS", "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                            Else
                                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                            End If
                        Else
                            If lista.Count() = 1 Then
                                dtReporteKardex = New DataTable("articulos")
                                dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos(IDE, lista(0).ToString, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                                If dtReporteKardex.Rows.Count() <> 0 Then
                                    crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & lista(0), "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                                Else
                                    MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                                End If
                            Else
                                dtReporteKardex = New DataTable("articulo_todos")
                                dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos_todos(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                                If dtReporteKardex.Rows.Count() <> 0 Then
                                    crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "VARIOS", "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                                Else
                                    MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                                End If
                            End If
                        End If
                    Else
                        If checkAlmacen.Checked = True Then
                            dtReporteKardex = New DataTable("articulo_lote_todos")
                            dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos_lotes_todos(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                            If dtReporteKardex.Rows.Count() <> 0 Then
                                crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, _
                                 "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "Todos los Almacenes", "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                            Else
                                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                            End If
                        Else
                            If lista.Count() = 1 Then
                                dtReporteKardex = New DataTable("articulos")
                                dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos_Balance_Alcohol(IDE, lista(0).ToString, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                                If dtReporteKardex.Rows.Count() <> 0 Then
                                    crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima_Balances_Alcohol.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, _
                                                             "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & lista(0), "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                                Else
                                    MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                                End If
                            Else
                                dtReporteKardex = New DataTable("articulo_lote_todos")
                                dtReporteKardex = reporteBL.Get_ImprimirReporte_Articulos_lotes_todos_Balances_Alcohol(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                                If dtReporteKardex.Rows.Count() <> 0 Then
                                    crystalBL.Muestra_Reporte("rpt_kardex_referencia_articulo_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@ART_INI;" & ART1, "@ART_FIN;" & ART2, _
                                     "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "Todos los Almacenes", "@USER;" & ClsVarComun.USUARIO.ToUpper, "@EMPRESA;" & NOMBRE_EMPRESA)
                                Else
                                    MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                                End If
                            End If
                        End If

                    End If
                Case "ReporteKardexReferenciaLote"
                    If checkAlmacen.Checked = True Then
                        dtReporteKardex = New DataTable("Lotes_todos")
                        dtReporteKardex = reporteBL.Get_ImprimirReporte_Lotes_todos(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                        If dtReporteKardex.Rows.Count() <> 0 Then
                            crystalBL.Muestra_Reporte("rpt_kardex_referencia_lotes_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@LOTE_INI;" & LOTE, "@LOTE_FIN;" & LOTE, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "Todos los Almacenes")
                        Else
                            MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                        End If
                    Else
                        If lista.Count() = 1 Then
                            dtReporteKardex = New DataTable("Lotes")
                            dtReporteKardex = reporteBL.Get_ImprimirReporte_Lotes(IDE, lista(0), fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                            If dtReporteKardex.Rows.Count() <> 0 Then
                                crystalBL.Muestra_Reporte("rpt_kardex_referencia_lotes_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@LOTE_INI;" & LOTE, "@LOTE_FIN;" & LOTE, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & lista(0))
                            Else
                                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                            End If
                        Else
                            dtReporteKardex = New DataTable("Lotes_todos")
                            dtReporteKardex = reporteBL.Get_ImprimirReporte_Lotes_todos(IDE, lista, fechaINI, fechaFIN, ART1, ART2, TODOSMOV, TODOS, mesAnt, anoAnt, mesActual, anoAct, LOTE)
                            If dtReporteKardex.Rows.Count() <> 0 Then
                                crystalBL.Muestra_Reporte("rpt_kardex_referencia_lotes_Materia_Prima.rpt", dtReporteKardex, "", "", "", "@LOTE_INI;" & LOTE, "@LOTE_FIN;" & LOTE, "@FECHA_INI;" & dtpfechaInicio.Value, "@FECHA_FIN;" & dtpfechaFin.Value, "@ALMACEN;" & "Todos los Almacenes")
                            Else
                                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
                            End If
                        End If
                    End If
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

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

End Class