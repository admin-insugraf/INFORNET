Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports LibComunVar
Imports System.Net.http

Public Class Frm_PR_Calculo_Planilla
    Dim clsPedidoBl As ClsOperaciones.ORDERS
    Dim dtGeneraAFP As DataTable
    Dim dtv_bandeja_pre_prensa As DataView
    Dim dtv_bandeja_pre_prensa_op As DataView
    Dim STRorden_bandeja_pre_prensa As String = String.Empty
    Dim STRorden_bandeja_pre_prensa_op As String = String.Empty
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtdetalle_pre_prensa As DataTable
    Dim flag_modificar_logistica As Boolean = False
    Dim pl_planilla_cab As ClsEntidades.PL_PLANILLA
    Dim pl_planilla_det As ClsEntidades.PL_PLANILLA_LINE
    Dim pl_planilla_det_conceptos_variables As ClsEntidades.PL_PLANILLA_LINE_CONCEPTOS_VARIABLES
    Dim Codigo_logistica As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS
    Dim id_op_planeamiento As Integer
    Dim vendedorBL As LibCobranzas.ClsOperaciones.SALES_REP
    Dim _inicio As Boolean = False
    Dim _codigo_planilla As Integer = 0
    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String
    Dim dtTrabajos_Mantenimiento As DataTable
    Dim Modo_actualizar As Boolean = False

    'Dim Cab_Certificado_Calidad As ClsEntidades.PLANILLA_LETRAS_BANCO
    'Dim Det_Certificado_Calidad As ClsEntidades.PLANILLA_LETRAS_BANCO_LINE

    Dim dtDocumentos As DataTable
    Dim dtDocumentos_ingresos_Descuentos_variables As DataTable
    Dim dt_ingresos_variables As DataTable
    Dim dt_descuentos_variables As DataTable
    Dim dtv As DataView
    Dim dtv_conceptos_variables As DataView
    Dim STRorden As String = ""
    Dim STRorden_conceptos_variables As String = ""
    Dim _codigo_personal As String = ""
    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable
    Private Sub Frm_PR_Calculo_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        _inicio = False
        dtpfechaInicial.Value = "01/01/" & ClsVarComun.FechaSistema.Year.ToString
        dtpfechafinal.Value = "31/12/" & ClsVarComun.FechaSistema.Year.ToString
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            _inicio = True
            _codigo_planilla = 0
            Modo_actualizar = False
            btn_exportar.Visible = False
            dtpFecha_planilla.Enabled = True
            txtcodigo.Text = "" 'Numeracion()
            Label18.Visible = True
            btn_Finalizar.Visible = False
            btn_anexar.Visible = True
            CONTROLES(TabPage2, False)
            checkTodos.Checked = False
            btn_exportar_ftp.Visible = False
            'tc_tipos.SelectedIndex = 0

            txt_titulo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_tipos.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        '-----------------------------------
        Select Case tc_tipos.SelectedIndex
            Case 0
                tc_tipos.SelectedIndex = indice + 1
            Case 1
                tc_tipos.SelectedIndex = indice - 1
        End Select
        ' ----------------------------------
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            'vendedorBL = New LibCobranzas.ClsOperaciones.SALES_REP
            'Dim dtdetalles As DataTable
            'dtdetalles = New DataTable("CodigoVendedor")
            'dtdetalles = vendedorBL.get_Codigo_Calculo_Planillas_RRHH(dtpFecha_inicial.Value.Year)
            'If dtdetalles.Rows.Count() <> 0 Then
            '    Correlativo = String.Format("{0:00000}", CInt(dtdetalles.Rows(0).Item("NUMBER").ToString) + 1) & "-" & dtpFecha_inicial.Value.Year.ToString
            'End If
            Correlativo = String.Format("{0:00000}", dtpFecha_planilla.Value.Month) & "-" & dtpFecha_planilla.Value.Year.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub limpiar()
        txtcodigo.Text = ""
        dtpFecha_planilla.Value = Date.Now
        txt_titulo.Text = ""
        mtb_total_afp.Text = "0.00"
        mtb_total_aportes.Text = "0.00"
        mtb_total_neto_pagar.Text = "0.00"
        mtb_total_onp.Text = "0.00"
        pnl_exporta_boletas.Visible = False
        If dgvDetalle1.RowCount() <> 0 Then
            For n As Integer = dgvDetalle1.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgvDetalle1.Rows(n)
                dgvDetalle1.Rows.Remove(row)
            Next
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_reapertura_planilla.Enabled = False
            btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btn_exportar.Enabled = True
            'btn_exportar_ftp.Visible = True
        Else
            btnNuevo.Enabled = True
            btn_reapertura_planilla.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btn_exportar.Enabled = False
            'btn_exportar_ftp.Visible = False
        End If
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        Ayuda_Anexa_Personal()
    End Sub

    Private Sub Ayuda_Anexa_Personal()
        Try
            Me.Cursor = Cursors.WaitCursor

            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            Dim dt_adelanto_quincena As DataTable
            dt_adelanto_quincena = New DataTable
            Dim _posicion_personal As Integer
            dtv = New DataView
            dtDocumentos = clsPedidoBl.Ejecutar_Anexar_Personal(dtpFecha_planilla.Value.Month, dtpFecha_planilla.Value.Year,
                                                                ModFunciones.Primer_Dia_Mes(dtpFecha_planilla.Value), ModFunciones.Ultimo_Dia_Mes(dtpFecha_planilla.Value))
            If dtDocumentos.Rows.Count > 0 Then
                dgvDetalle1.DataSource = dtDocumentos
                Formato_Grilla()
                Sumar_Marcados()
                checkTodos.Checked = True
                dgvDetalle1.Update()

                GenerarColummnaDataTable_Ingresos_Descuentos_Variables()
                dt_adelanto_quincena = clsPedidoBl.Get_Ejecutar_Anexar_Adelanto_Personal(dtpFecha_planilla.Value.Month, dtpFecha_planilla.Value.Year)
                If dt_adelanto_quincena.Rows.Count > 0 Then
                    For i As Integer = 0 To dt_adelanto_quincena.Rows.Count - 1
                        _posicion_personal = 0
                        For Each item As DataRow In dtDocumentos.Select("CODIGO='" & dt_adelanto_quincena.Rows(i).Item("COD_PERSONAL").ToString & "'")
                            _posicion_personal = item("ITEM")
                        Next
                        Dim row2 As DataRow = dtDocumentos_ingresos_Descuentos_variables.NewRow
                        row2("ITEM") = _posicion_personal
                        row2("TIPO") = dt_adelanto_quincena.Rows(i).Item("TIPO").ToString
                        row2("COD_PERSONAL") = dt_adelanto_quincena.Rows(i).Item("COD_PERSONAL").ToString
                        row2("COD_CONCEPTO") = dt_adelanto_quincena.Rows(i).Item("COD_CONCEPTO").ToString
                        row2("CONCEPTO") = dt_adelanto_quincena.Rows(i).Item("CONCEPTO").ToString
                        row2("MONTO") = dt_adelanto_quincena.Rows(i).Item("MONTO").ToString
                        dtDocumentos_ingresos_Descuentos_variables.Rows.Add(row2)
                        dtDocumentos_ingresos_Descuentos_variables.AcceptChanges()
                    Next
                End If
                btn_anexar.Visible = False
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        'limpiar()
        GbCabecera.Enabled = False
        btn_exportar_ftp.Visible = False
        btn_Generar_Plame.Visible = False
        btn_afpnet.Visible = False
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Function Validar_Calculo_Planilla() As Boolean
        Try
            'If txtcodigo.Text = "" Then
            '    MsgBox("La Planilla no tiene codigo.", MsgBoxStyle.Exclamation)
            '    Return False
            'End If

            If txt_titulo.Text = "" Then
                MsgBox("Debe ingresar un TITULO a la Planilla.", MsgBoxStyle.Exclamation)
                txt_titulo.Focus()
                Return False
            End If


            'VARIABLES
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvDetalle1.RowCount() = 0 Then
                MsgBox("No hay items para procesar.", MsgBoxStyle.Exclamation)
                dgvDetalle1.Focus()
                CONTROLES(TabPage1, True)
                CONTROLES(TabPage2, False)
                'tc_tipos.SelectedIndex = 0
                Return False
            Else
                Dim estado As Boolean = False
                Dim item_marcados As Integer = 0
                For Each row As DataGridViewRow In dgvDetalle1.Rows
                    If row.Cells("Sel").Value = True Then
                        item_marcados = item_marcados + 1
                        Exit For
                    End If
                Next
                If item_marcados = 0 Then
                    MessageBox.Show("Debe seleccionar al menos un item.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvDetalle1.Focus()
                    CONTROLES(TabPage1, True)
                    CONTROLES(TabPage2, False)
                    'tc_tipos.SelectedIndex = 0
                    Return False
                End If
            End If
            dgvDetalle1.Refresh()

            'If Modo_actualizar = False Then
            '    vendedorBL = New LibCobranzas.ClsOperaciones.SALES_REP
            '    Dim dtdetalles As DataTable
            '    dtdetalles = New DataTable("CodigoVendedor")
            '    dtdetalles = vendedorBL.get_Verifico_Calculo_Planilla_RRHH(dtpFecha_planilla.Value.Month, dtpFecha_planilla.Value.Year)
            '    If dtdetalles.Rows.Count() <> 0 Then
            '        MsgBox("Existe una Planilla con el mes/año elegido.", MsgBoxStyle.Exclamation)
            '        Return False
            '    End If
            'End If

            If Verificar_Apertura_Cierre_Modulos(dtpFecha_planilla.Value.Month, dtpFecha_planilla.Value.Year) = False Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "RECURSOS_HUMANOS")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Planilla.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Validar_Calculo_Planilla() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de registrar la Planilla de Sueldos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New ClsOperaciones.ORDERS
                pl_planilla_cab = New ClsEntidades.PL_PLANILLA
                pl_planilla_det = New ClsEntidades.PL_PLANILLA_LINE
                pl_planilla_det_conceptos_variables = New ClsEntidades.PL_PLANILLA_LINE_CONCEPTOS_VARIABLES
                Dim lista_pl_planilla_det As New List(Of ClsEntidades.PL_PLANILLA_LINE)
                Dim lista_pl_planilla_det_conceptos_variables As New List(Of ClsEntidades.PL_PLANILLA_LINE_CONCEPTOS_VARIABLES)

                With pl_planilla_cab
                    .ID = _codigo_planilla
                    .CODIGO = txtcodigo.Text
                    .TITULO = txt_titulo.Text
                    .MES_ANIO = ModFunciones.Primer_Dia_Mes(dtpFecha_planilla.Value.ToString("dd/MM/yyyy"))
                    .STATUS = "V"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                End With

                For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                    If dgvDetalle1.Rows(i).Cells("Sel").Value Then
                        pl_planilla_det = New ClsEntidades.PL_PLANILLA_LINE
                        With pl_planilla_det
                            .ID_CAB = _codigo_planilla
                            .ITEM = dgvDetalle1.Rows(i).Cells("ITEM").Value
                            .CODIGO = dgvDetalle1.Rows(i).Cells("CODIGO").Value
                            .NUMERO_DOC = dgvDetalle1.Rows(i).Cells("NUMERO_DOC").Value
                            .BASICO = dgvDetalle1.Rows(i).Cells("BASICO").Value
                            .FALTAS_D = dgvDetalle1.Rows(i).Cells("FALTAS_D").Value
                            .TARDANZAS_H = dgvDetalle1.Rows(i).Cells("TARDANZAS_H").Value
                            .TRABAJO_DESCANSO_DIAS = dgvDetalle1.Rows(i).Cells("TRABAJO_DESCANSO_DIAS").Value
                            .DIAS_MES = dgvDetalle1.Rows(i).Cells("DIAS_MES").Value
                            .DOMINGOS_FERIADOS = dgvDetalle1.Rows(i).Cells("DOMINGOS_FERIADOS").Value
                            .DIAS_EFECTIVOS = dgvDetalle1.Rows(i).Cells("DIAS_EFECTIVOS").Value
                            .HORAS_TRABAJADAS = dgvDetalle1.Rows(i).Cells("HORAS_TRABAJADAS").Value
                            .TOTAL_HORAS_NORMALES = dgvDetalle1.Rows(i).Cells("TOTAL_HORAS_NORMALES").Value
                            .HR_EXT_25 = dgvDetalle1.Rows(i).Cells("HR_EXT_25").Value
                            .HR_EXT_35 = dgvDetalle1.Rows(i).Cells("HR_EXT_35").Value
                            .HR_EXT_100 = dgvDetalle1.Rows(i).Cells("HR_EXT_100").Value
                            .TOTAL_HR_EXT = dgvDetalle1.Rows(i).Cells("TOTAL_HR_EXT").Value
                            .INASISTENCIA = dgvDetalle1.Rows(i).Cells("INASISTENCIA").Value
                            .TARDANZAS = dgvDetalle1.Rows(i).Cells("TARDANZAS").Value
                            .TRABAJO_DESCANSO = dgvDetalle1.Rows(i).Cells("TRABAJO_DESCANSO").Value
                            .REMUNERACION_BASICA_EFECTIVA = dgvDetalle1.Rows(i).Cells("REMUNERACION_BASICA_EFECTIVA").Value
                            .ASIG_FAMILIAR = dgvDetalle1.Rows(i).Cells("ASIG_FAMILIAR").Value
                            .COMISIONES = dgvDetalle1.Rows(i).Cells("COMISIONES").Value
                            .REM_HR_EXT_25 = dgvDetalle1.Rows(i).Cells("REM_HR_EXT_25").Value
                            .REM_HR_EXT_35 = dgvDetalle1.Rows(i).Cells("REM_HR_EXT_35").Value
                            .REM_HR_EXT_100 = dgvDetalle1.Rows(i).Cells("REM_HR_EXT_100").Value
                            .TOTAL_REM_HR_EXT = dgvDetalle1.Rows(i).Cells("TOTAL_REM_HR_EXT").Value
                            .TOTAL_REMUNERACION = dgvDetalle1.Rows(i).Cells("TOTAL_REMUNERACION").Value
                            .REMUNERACION_AFECTA_ESSALUD = dgvDetalle1.Rows(i).Cells("REMUNERACION_AFECTA_ESSALUD").Value
                            .REMUNERACION_AFECTA_AFP = dgvDetalle1.Rows(i).Cells("REMUNERACION_AFECTA_AFP").Value
                            .TOTAL_INGRESOS = dgvDetalle1.Rows(i).Cells("TOTAL_INGRESOS").Value
                            .ESSALUD_VIDA_ASEG_PENSION = dgvDetalle1.Rows(i).Cells("ESSALUD_VIDA_ASEG_PENSION").Value
                            .ONP = dgvDetalle1.Rows(i).Cells("ONP").Value
                            .AFP_APORTE_OBLIGATORIO = dgvDetalle1.Rows(i).Cells("AFP_APORTE_OBLIGATORIO").Value
                            .AFP_COMISION = dgvDetalle1.Rows(i).Cells("AFP_COMISION").Value
                            .AFP_PRIMA_SEG = dgvDetalle1.Rows(i).Cells("AFP_PRIMA_SEG").Value
                            .TOTAL_AFP = dgvDetalle1.Rows(i).Cells("TOTAL_AFP").Value
                            .TOTAL_DESCUENTOS = dgvDetalle1.Rows(i).Cells("TOTAL_DESCUENTOS").Value
                            .NETO_PAGAR = dgvDetalle1.Rows(i).Cells("NETO_PAGAR").Value
                            .ESSALUD = dgvDetalle1.Rows(i).Cells("ESSALUD").Value
                            .SCTR_SALUD = dgvDetalle1.Rows(i).Cells("SCTR_SALUD").Value
                            .SCTR_PENSION = dgvDetalle1.Rows(i).Cells("SCTR_PENSION").Value
                            .SENATI = dgvDetalle1.Rows(i).Cells("SENATI").Value
                            .TOTAL_APORTES = dgvDetalle1.Rows(i).Cells("TOTAL_APORTES").Value

                            .AFP_ID = dgvDetalle1.Rows(i).Cells("AFP_ID").Value
                            .APORTE_OBLIGATORIO = dgvDetalle1.Rows(i).Cells("APORTE_OBLIGATORIO").Value
                            .COMISION_VARIABLE = dgvDetalle1.Rows(i).Cells("COMISION_VARIABLE").Value
                            .COMISION_MIXTA = dgvDetalle1.Rows(i).Cells("COMISION_MIXTA").Value
                            .PRIMA_SEGURO = dgvDetalle1.Rows(i).Cells("PRIMA_SEGURO").Value
                            .ADELANTO = dgvDetalle1.Rows(i).Cells("ADELANTO").Value
                            .SUSPENSION_PERFECTA = dgvDetalle1.Rows(i).Cells("SUSPENSION_PERFECTA").Value

                            .EPS = dgvDetalle1.Rows(i).Cells("EPS").Value
                            .EPS_POR = dgvDetalle1.Rows(i).Cells("EPS_POR").Value

                        End With
                        lista_pl_planilla_det.Add(pl_planilla_det)
                    End If
                Next

                For i As Integer = 0 To dtDocumentos_ingresos_Descuentos_variables.Rows.Count - 1
                    pl_planilla_det_conceptos_variables = New ClsEntidades.PL_PLANILLA_LINE_CONCEPTOS_VARIABLES
                    With pl_planilla_det_conceptos_variables
                        .ID_CAB = _codigo_planilla
                        .CODIGO = dtDocumentos_ingresos_Descuentos_variables.Rows(i).Item("COD_PERSONAL").ToString
                        .NUMERO_DOC = ""
                        .ITEM = dtDocumentos_ingresos_Descuentos_variables.Rows(i).Item("ITEM").ToString
                        .TIPO = dtDocumentos_ingresos_Descuentos_variables.Rows(i).Item("TIPO").ToString
                        .COD_CONCEPTO = dtDocumentos_ingresos_Descuentos_variables.Rows(i).Item("COD_CONCEPTO").ToString
                        .MONTO = dtDocumentos_ingresos_Descuentos_variables.Rows(i).Item("MONTO")
                    End With
                    lista_pl_planilla_det_conceptos_variables.Add(pl_planilla_det_conceptos_variables)
                Next

                If clsPedidoBl.Guardar_Planilla(pl_planilla_cab, lista_pl_planilla_det, _codigo_planilla, lista_pl_planilla_det_conceptos_variables, Modo_actualizar) Then
                    MsgBox("Planilla de Sueldos registrado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    DocumentosRequisiones()
                    MostrarModoConsultar(_codigo_planilla)
                    Modo_actualizar = True
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sumar_Marcados()
        Dim total_neto_pagar As Double = 0
        Dim total_afp As Double = 0
        Dim total_onp As Double = 0
        Dim total_aportes As Double = 0

        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
            If dgvDetalle1.Rows(i).Cells("Sel").Value = True Then
                total_neto_pagar += dgvDetalle1.Rows(i).Cells("NETO_PAGAR").Value
                total_afp += dgvDetalle1.Rows(i).Cells("TOTAL_AFP").Value
                total_onp += dgvDetalle1.Rows(i).Cells("ONP").Value
                total_aportes += dgvDetalle1.Rows(i).Cells("TOTAL_APORTES").Value
            End If
        Next
        mtb_total_neto_pagar.Text = total_neto_pagar
        mtb_total_afp.Text = total_afp
        mtb_total_onp.Text = total_onp
        mtb_total_aportes.Text = total_aportes

        mtb_total_neto_pagar.Text = Format(Double.Parse(mtb_total_neto_pagar.Text), "##,##0.00")
        mtb_total_afp.Text = Format(Double.Parse(mtb_total_afp.Text), "##,##0.00")
        mtb_total_onp.Text = Format(Double.Parse(mtb_total_onp.Text), "##,##0.00")
        mtb_total_aportes.Text = Format(Double.Parse(mtb_total_aportes.Text), "##,##0.00")
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("TITULO").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name & "+" & dgvCabecera.Columns("TITULO").Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    System.Windows.Forms.MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsPedidoBl.get_Lista_Planillas_RRHH(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"),
                                                                           cboopcionesBusqueda.SelectedIndex)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                dgvCabecera.Columns("ID").Visible = False
                dgvCabecera.Columns("FECHA").Visible = False
                dgvCabecera.Columns("NUMERO_PLANILLA").HeaderText = "N° PLANILLA"
                dgvCabecera.Columns("TITULO").HeaderText = "TITULO"
                dgvCabecera.Columns("MES_ANIO").HeaderText = "MES/AÑO"
                dgvCabecera.Columns("ESTADO").HeaderText = "ESTADO"
                dgvCabecera.Columns("BOLETAS_ENVIADAS").HeaderText = "BOLETAS ENVIADAS AL API"

                dgvCabecera.Columns("NUMERO_PLANILLA").Width = 100
                dgvCabecera.Columns("TITULO").Width = 400
                dgvCabecera.Columns("MES_ANIO").Width = 100
                dgvCabecera.Columns("ESTADO").Width = 100
                dgvCabecera.Columns("BOLETAS_ENVIADAS").Width = 120

                STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name & "+" & dgvCabecera.Columns("TITULO").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Botonera_Estado_Cambiar(True)
            Modo_actualizar = True
            btn_exportar.Visible = True
            limpiar()
            _inicio = True
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            dtpFecha_planilla.Enabled = False

            _codigo_planilla = dgvCabecera.CurrentRow.Cells("ID").Value
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("NUMERO_PLANILLA").Value
            txt_titulo.Text = dgvCabecera.CurrentRow.Cells("TITULO").Value
            dtpFecha_planilla.Value = dgvCabecera.CurrentRow.Cells("FECHA").Value

            If dgvCabecera.CurrentRow.Cells("ESTADO").Value = "FINALIZADO" Then
                btn_Finalizar.Visible = False
                btn_anexar.Visible = False
                btnGrabar.Enabled = False
                btn_Generar_Plame.Visible = True
                btn_afpnet.Visible = True
            Else
                btn_Finalizar.Visible = True
                btn_anexar.Visible = False
                btn_Generar_Plame.Visible = False
                btn_afpnet.Visible = False
            End If

            Label18.Visible = False
            MostrarModoConsultar(_codigo_planilla)
            CONTROLES(TabPage1, True)
            CONTROLES(TabPage2, False)
            btn_exportar_ftp.Visible = True
            'tc_tipos.SelectedIndex = 0

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModoConsultar(ByVal _codigo As Integer)
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            'Mostrando datos del detalle
            dtDocumentos = New DataTable
            dtDocumentos = clsPedidoBl.Get_Datos_Detalle_Planilla(_codigo)
            If dtDocumentos.Rows.Count > 0 Then
                dgvDetalle1.DataSource = dtDocumentos
                Formato_Grilla()
                checkTodos.Checked = True
                Sumar_Marcados()
                dgvDetalle1.Update()
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            dtDocumentos_ingresos_Descuentos_variables = New DataTable
            dtDocumentos_ingresos_Descuentos_variables = clsPedidoBl.Get_Datos_Detalle_Conceptos_variables_Planilla(_codigo)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Formato_Grilla()

        If dtDocumentos.Rows.Count() <> 0 Then
            dgvDetalle1.Columns("Sel").Width = 30
            dgvDetalle1.Columns("ITEM").Width = 30
            dgvDetalle1.Columns("NUMERO_DOC").Width = 70
            dgvDetalle1.Columns("APELLIDOS_NOMBRES").Width = 300
            dgvDetalle1.Columns("BASICO").Width = 100
            dgvDetalle1.Columns("BASICO").Frozen = True
            dgvDetalle1.Columns("SUSPENSION_PERFECTA").Width = 100
            dgvDetalle1.Columns("FALTAS_D").Width = 100
            dgvDetalle1.Columns("TARDANZAS_H").Width = 100
            dgvDetalle1.Columns("TRABAJO_DESCANSO_DIAS").Width = 100
            dgvDetalle1.Columns("DIAS_MES").Width = 100
            dgvDetalle1.Columns("DOMINGOS_FERIADOS").Width = 100
            dgvDetalle1.Columns("DIAS_EFECTIVOS").Width = 100
            dgvDetalle1.Columns("HORAS_TRABAJADAS").Width = 100
            dgvDetalle1.Columns("TOTAL_HORAS_NORMALES").Width = 100
            dgvDetalle1.Columns("HR_EXT_25").Width = 100
            dgvDetalle1.Columns("HR_EXT_35").Width = 100
            dgvDetalle1.Columns("HR_EXT_100").Width = 100
            dgvDetalle1.Columns("TOTAL_HR_EXT").Width = 100
            dgvDetalle1.Columns("INASISTENCIA").Width = 100
            dgvDetalle1.Columns("TARDANZAS").Width = 100
            dgvDetalle1.Columns("TRABAJO_DESCANSO").Width = 100
            dgvDetalle1.Columns("REMUNERACION_BASICA_EFECTIVA").Width = 100
            dgvDetalle1.Columns("ASIG_FAMILIAR").Width = 100
            dgvDetalle1.Columns("COMISIONES").Width = 100
            dgvDetalle1.Columns("REM_HR_EXT_25").Width = 100
            dgvDetalle1.Columns("REM_HR_EXT_35").Width = 100
            dgvDetalle1.Columns("REM_HR_EXT_100").Width = 100
            dgvDetalle1.Columns("TOTAL_REM_HR_EXT").Width = 100
            dgvDetalle1.Columns("TOTAL_REMUNERACION").Width = 100
            dgvDetalle1.Columns("REMUNERACION_AFECTA_ESSALUD").Width = 100
            dgvDetalle1.Columns("OTROS_INGRESOS").Width = 100
            dgvDetalle1.Columns("REMUNERACION_AFECTA_AFP").Width = 100
            dgvDetalle1.Columns("TOTAL_INGRESOS").Width = 100
            dgvDetalle1.Columns("ESSALUD_VIDA_ASEG_PENSION").Width = 100
            dgvDetalle1.Columns("ONP").Width = 100
            dgvDetalle1.Columns("AFP_APORTE_OBLIGATORIO").Width = 100
            dgvDetalle1.Columns("AFP_COMISION").Width = 100
            dgvDetalle1.Columns("AFP_PRIMA_SEG").Width = 100
            dgvDetalle1.Columns("TOTAL_AFP").Width = 100
            dgvDetalle1.Columns("ADELANTO").Width = 100
            dgvDetalle1.Columns("OTROS_DESCUENTOS").Width = 100
            dgvDetalle1.Columns("TOTAL_DESCUENTOS").Width = 100
            dgvDetalle1.Columns("NETO_PAGAR").Width = 100
            dgvDetalle1.Columns("ESSALUD").Width = 100
            dgvDetalle1.Columns("EPS").Width = 100
            dgvDetalle1.Columns("SCTR_SALUD").Width = 100
            dgvDetalle1.Columns("SCTR_PENSION").Width = 100
            dgvDetalle1.Columns("SENATI").Width = 100
            dgvDetalle1.Columns("TOTAL_APORTES").Width = 100

            dgvDetalle1.Columns("BASICO").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("DIAS_MES").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("SUSPENSION_PERFECTA").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("FALTAS_D").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("TARDANZAS_H").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TRABAJO_DESCANSO_DIAS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("DIAS_MES").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("DOMINGOS_FERIADOS").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("DIAS_EFECTIVOS").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("HORAS_TRABAJADAS").DefaultCellStyle.Format = "N0"
            dgvDetalle1.Columns("TOTAL_HORAS_NORMALES").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("HR_EXT_25").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("HR_EXT_35").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("HR_EXT_100").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_HR_EXT").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("INASISTENCIA").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TARDANZAS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TRABAJO_DESCANSO").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REMUNERACION_BASICA_EFECTIVA").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ASIG_FAMILIAR").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("COMISIONES").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REM_HR_EXT_25").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REM_HR_EXT_35").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REM_HR_EXT_100").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_REM_HR_EXT").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_REMUNERACION").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REMUNERACION_AFECTA_ESSALUD").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("REMUNERACION_AFECTA_AFP").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("OTROS_INGRESOS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_INGRESOS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ESSALUD_VIDA_ASEG_PENSION").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ONP").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("AFP_APORTE_OBLIGATORIO").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("AFP_COMISION").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("AFP_PRIMA_SEG").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_AFP").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ADELANTO").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("OTROS_DESCUENTOS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_DESCUENTOS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("NETO_PAGAR").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ESSALUD").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("EPS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("SCTR_SALUD").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("SCTR_PENSION").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("SENATI").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_APORTES").DefaultCellStyle.Format = "N2"


            dgvDetalle1.Columns("BASICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("DIAS_MES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("SUSPENSION_PERFECTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("FALTAS_D").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TARDANZAS_H").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TRABAJO_DESCANSO_DIAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("DIAS_MES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("DOMINGOS_FERIADOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("DIAS_EFECTIVOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("HORAS_TRABAJADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_HORAS_NORMALES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("HR_EXT_25").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("HR_EXT_35").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("HR_EXT_100").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_HR_EXT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("INASISTENCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TARDANZAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TRABAJO_DESCANSO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REMUNERACION_BASICA_EFECTIVA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ASIG_FAMILIAR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("COMISIONES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REM_HR_EXT_25").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REM_HR_EXT_35").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REM_HR_EXT_100").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_REM_HR_EXT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_REMUNERACION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REMUNERACION_AFECTA_ESSALUD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("REMUNERACION_AFECTA_AFP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("OTROS_INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ESSALUD_VIDA_ASEG_PENSION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ONP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("AFP_APORTE_OBLIGATORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("AFP_COMISION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("AFP_PRIMA_SEG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_AFP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ADELANTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("OTROS_DESCUENTOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_DESCUENTOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("NETO_PAGAR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ESSALUD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("EPS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("SCTR_SALUD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("SCTR_PENSION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("SENATI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_APORTES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dgvDetalle1.Columns("ITEM").ReadOnly = True
            dgvDetalle1.Columns("NUMERO_DOC").ReadOnly = True
            dgvDetalle1.Columns("APELLIDOS_NOMBRES").ReadOnly = True
            dgvDetalle1.Columns("BASICO").ReadOnly = True
            'dgvDetalle1.Columns("DIAS_MES").ReadOnly = False
            dgvDetalle1.Columns("TOTAL_HR_EXT").ReadOnly = True
            dgvDetalle1.Columns("REMUNERACION_BASICA_EFECTIVA").ReadOnly = True
            dgvDetalle1.Columns("ASIG_FAMILIAR").ReadOnly = True
            dgvDetalle1.Columns("REM_HR_EXT_25").ReadOnly = True
            dgvDetalle1.Columns("REM_HR_EXT_35").ReadOnly = True
            dgvDetalle1.Columns("REM_HR_EXT_100").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_REM_HR_EXT").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_REMUNERACION").ReadOnly = True
            dgvDetalle1.Columns("REMUNERACION_AFECTA_ESSALUD").ReadOnly = True
            dgvDetalle1.Columns("REMUNERACION_AFECTA_AFP").ReadOnly = True
            dgvDetalle1.Columns("OTROS_INGRESOS").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_INGRESOS").ReadOnly = True
            dgvDetalle1.Columns("ESSALUD_VIDA_ASEG_PENSION").ReadOnly = True
            dgvDetalle1.Columns("ONP").ReadOnly = True
            dgvDetalle1.Columns("AFP_APORTE_OBLIGATORIO").ReadOnly = True
            dgvDetalle1.Columns("AFP_COMISION").ReadOnly = True
            dgvDetalle1.Columns("AFP_PRIMA_SEG").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_AFP").ReadOnly = True
            dgvDetalle1.Columns("ADELANTO").ReadOnly = True
            dgvDetalle1.Columns("OTROS_DESCUENTOS").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_DESCUENTOS").ReadOnly = True
            dgvDetalle1.Columns("NETO_PAGAR").ReadOnly = True
            dgvDetalle1.Columns("ESSALUD").ReadOnly = True
            dgvDetalle1.Columns("EPS").ReadOnly = True
            dgvDetalle1.Columns("SCTR_SALUD").ReadOnly = True
            dgvDetalle1.Columns("SCTR_PENSION").ReadOnly = True
            dgvDetalle1.Columns("SENATI").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_APORTES").ReadOnly = True

        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btn_exportar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Carpeta As New FolderBrowserDialog
            Dim ruta_archivo As String
            If Carpeta.ShowDialog() = DialogResult.OK Then
                ruta_archivo = Carpeta.SelectedPath.ToString & "\"
            End If

            Const xlEdgeLeft = 7
            Const xlEdgeRight = 10
            Const xlEdgeTop = 8
            Const xlEdgeBottom = 9
            Const xlInsideHorizontal = 12
            Const xlInsideVertical = 11
            Const xlContinuous = 1
            Const xlThin = 2

            Dim excel As Object
            Dim wBook As Object
            Dim wSheet As Object

            excel = CreateObject("Excel.Application")
            'wBook = excel.Workbooks.Add
            'wSheet = wBook.Worksheets(1)


            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            wSheet.Name = "PLANILLA"

            excel.Cells(1, 1) = "Empresa"
            excel.Cells(2, 1) = "Ruc"
            excel.Cells(1, 3) = LibComunVar.ClsVarComun.NomEmpresa
            excel.Cells(2, 3) = "'" & LibComunVar.ClsVarComun.RucEmpresa

            excel.Cells(4, 3) = "PLANILLA MES DE " & UCase(dtpFecha_planilla.Value.ToString("MMMM")) & " " & dtpFecha_planilla.Value.ToString("yyyy")
            excel.Cells(4, 3).HorizontalAlignment = 3
            wSheet.Range("B4", "AM4").Merge(True)

            Dim cont_filas_tmp As Integer = 0
            cont_filas_tmp = 7

            excel.Cells(cont_filas_tmp, 2) = "N°"
            excel.Cells(cont_filas_tmp, 3) = "APELLIDOS Y NOMBRES"
            excel.Cells(cont_filas_tmp, 4) = "AFP/ONP"
            excel.Cells(cont_filas_tmp, 5) = "BASICO"
            excel.Cells(cont_filas_tmp, 6) = "SUSPENSION PERFECTA"
            excel.Cells(cont_filas_tmp, 7) = "INASISTENCIAS (DIAS)"
            excel.Cells(cont_filas_tmp, 8) = "TARDANZAS (HORAS)"
            excel.Cells(cont_filas_tmp, 9) = "HR. EXT. 25%"
            excel.Cells(cont_filas_tmp, 10) = "HR. EXT. 35%"
            excel.Cells(cont_filas_tmp, 11) = "HR. EXT. 100%"
            excel.Cells(cont_filas_tmp, 12) = "TOTAL HR. EXT."
            excel.Cells(cont_filas_tmp, 13) = "INASISTENCIAS"
            excel.Cells(cont_filas_tmp, 14) = "TARDANZAS"
            excel.Cells(cont_filas_tmp, 15) = "REM. BASICA EFECTIVA"
            excel.Cells(cont_filas_tmp, 16) = "ASIG. FAMILIAR"
            excel.Cells(cont_filas_tmp, 17) = "REM. HR. EXT. 25%"
            excel.Cells(cont_filas_tmp, 18) = "REM. HR. EXT. 35%"
            excel.Cells(cont_filas_tmp, 19) = "REM. HR. EXT. 100%"
            excel.Cells(cont_filas_tmp, 20) = "TOTAL HORAS EXTRAS"
            excel.Cells(cont_filas_tmp, 21) = "TOTAL REMUNERACION"
            excel.Cells(cont_filas_tmp, 22) = "REMUN. AFECTA A ESSALUD"
            excel.Cells(cont_filas_tmp, 23) = "REMUN. AFECTA A AFP"
            excel.Cells(cont_filas_tmp, 24) = "OTROS INGRESOS"
            excel.Cells(cont_filas_tmp, 25) = "TOTAL INGRESOS"
            excel.Cells(cont_filas_tmp, 26) = "ONP"
            excel.Cells(cont_filas_tmp, 27) = "AFP APORT. OBLIGATORIO"
            excel.Cells(cont_filas_tmp, 28) = "AFP COMISION"
            excel.Cells(cont_filas_tmp, 29) = "AFP PRIMA SEG."
            excel.Cells(cont_filas_tmp, 30) = "TOTAL AFP"
            excel.Cells(cont_filas_tmp, 31) = "ADELANTO"
            excel.Cells(cont_filas_tmp, 32) = "OTROS DESCUENTOS"
            excel.Cells(cont_filas_tmp, 33) = "TOTAL DESCUENTOS"
            excel.Cells(cont_filas_tmp, 34) = "NETO A PAGAR"
            excel.Cells(cont_filas_tmp, 35) = "ESSALUD %"
            excel.Cells(cont_filas_tmp, 36) = "SCTR SALUD"
            excel.Cells(cont_filas_tmp, 37) = "SCTR PENSION"
            excel.Cells(cont_filas_tmp, 38) = "SENATI"
            excel.Cells(cont_filas_tmp, 39) = "TOTAL APORTES"

            wSheet.Range("B4", "B4").Font.Bold = True
            wSheet.Range("B4", "B4").Font.Underline = 2
            wSheet.Range("B4", "B4").Font.Size = 16

            wSheet.Range("B6", "N6").Merge(True)
            wSheet.Range("B6:N6").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)

            wSheet.Range("O6", "Y6").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("B6", "W6").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("AH6", "AH6").Interior.Color = Color.Pink
            wSheet.Range("O6", "Y6").Font.Color = Color.White
            wSheet.Range("O6", "Y6").Merge(True)
            excel.Cells(6, 15) = "INGRESOS"
            excel.Cells(6, 15).HorizontalAlignment = 3

            wSheet.Range("Z6", "AG6").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("Z6", "AG6").Font.Color = Color.White
            wSheet.Range("Z6", "AG6").Merge(True)
            excel.Cells(6, 26) = "DESCUENTOS"
            excel.Cells(6, 26).HorizontalAlignment = 3

            wSheet.Range("AI6", "AM6").Interior.Color = RGB(235, 241, 222)
            wSheet.Range("AI6", "AM6").Font.Color = Color.Black
            wSheet.Range("AI6", "AM6").Merge(True)
            excel.Cells(6, 35) = "APORTES DEL EMPLEADOR"
            excel.Cells(6, 35).HorizontalAlignment = 3

            wSheet.Range("O7", "Y7").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("B7", "W7").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("AH7", "AH7").Interior.Color = Color.Pink
            wSheet.Range("B7", "Y7").Font.Color = Color.White
            wSheet.Range("Z7", "AG7").Interior.Color = RGB(49, 134, 155)
            wSheet.Range("Z7", "AG7").Font.Color = Color.White
            wSheet.Range("AI7", "AM7").Interior.Color = RGB(235, 241, 222)
            wSheet.Range("AI7", "AM7").Font.Color = Color.Black

            With wSheet.Range("N6", "AM6").Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("N6", "AM6").Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("N6", "AM6").Borders(xlEdgeLeft)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("N6", "W6").Borders(xlEdgeRight)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("N6", "AD6").Borders(xlEdgeRight)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("AF6", "AJ6").Borders(xlEdgeLeft)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With
            With wSheet.Range("N6", "AJ6").Borders(xlEdgeRight)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With

            With wSheet.Range("B7", "AJ7").Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
                '.TintAndShade = 0
            End With

            With wSheet.Range("B7", "AJ7").Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With

            wSheet.Range("B7:B7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("C7:C7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("D7:D7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("E7:E7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("F7:F7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("G7:G7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("H7:H7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("I7:I7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("J7:J7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("K7:K7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("L7:L7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("M7:M7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("N7:N7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("O7:O7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("P7:P7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("Q7:Q7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("R7:R7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("S7:S7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("T7:T7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("U7:U7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("V7:V7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("W7:W7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("X7:X7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("Y7:Y7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("Z7:Z7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AA7:AA7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AB7:AB7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AC7:AC7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AD7:AD7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AE7:AE7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AF7:AF7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AG7:AG7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AH7:AH7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AI7:AI7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AJ7:AJ7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AK7:AK7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AL7:AL7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AM7:AM7").BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)

            cont_filas_tmp = 8

            For f As Integer = 0 To dgvDetalle1.Rows.Count - 1
                excel.Cells(cont_filas_tmp + f, 2) = dgvDetalle1.Rows(f).Cells("ITEM").Value
                With wSheet.Range("B" & cont_filas_tmp + f, "B" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 3) = dgvDetalle1.Rows(f).Cells("APELLIDOS_NOMBRES").Value
                With wSheet.Range("C" & cont_filas_tmp + f, "C" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 4) = dgvDetalle1.Rows(f).Cells("AFP_ID").Value
                With wSheet.Range("D" & cont_filas_tmp + f, "D" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 5) = dgvDetalle1.Rows(f).Cells("BASICO").Value
                With wSheet.Range("E" & cont_filas_tmp + f, "E" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("E" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 6) = dgvDetalle1.Rows(f).Cells("SUSPENSION_PERFECTA").Value
                With wSheet.Range("F" & cont_filas_tmp + f, "F" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With

                excel.Cells(cont_filas_tmp + f, 7) = dgvDetalle1.Rows(f).Cells("FALTAS_D").Value
                With wSheet.Range("G" & cont_filas_tmp + f, "G" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With

                excel.Cells(cont_filas_tmp + f, 8) = dgvDetalle1.Rows(f).Cells("TARDANZAS_H").Value
                With wSheet.Range("H" & cont_filas_tmp + f, "H" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With

                excel.Cells(cont_filas_tmp + f, 9) = dgvDetalle1.Rows(f).Cells("HR_EXT_25").Value
                With wSheet.Range("I" & cont_filas_tmp + f, "I" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With

                excel.Cells(cont_filas_tmp + f, 10) = dgvDetalle1.Rows(f).Cells("HR_EXT_35").Value
                With wSheet.Range("J" & cont_filas_tmp + f, "J" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 11) = dgvDetalle1.Rows(f).Cells("HR_EXT_100").Value
                With wSheet.Range("K" & cont_filas_tmp + f, "K" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 12) = dgvDetalle1.Rows(f).Cells("TOTAL_HR_EXT").Value
                With wSheet.Range("L" & cont_filas_tmp + f, "L" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                excel.Cells(cont_filas_tmp + f, 13) = dgvDetalle1.Rows(f).Cells("INASISTENCIA").Value
                With wSheet.Range("M" & cont_filas_tmp + f, "M" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("M" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 14) = dgvDetalle1.Rows(f).Cells("TARDANZAS").Value
                With wSheet.Range("N" & cont_filas_tmp + f, "N" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("N" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 15) = dgvDetalle1.Rows(f).Cells("REMUNERACION_BASICA_EFECTIVA").Value
                With wSheet.Range("O" & cont_filas_tmp + f, "O" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("O" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 16) = dgvDetalle1.Rows(f).Cells("ASIG_FAMILIAR").Value
                With wSheet.Range("P" & cont_filas_tmp + f, "P" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("P" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 17) = dgvDetalle1.Rows(f).Cells("REM_HR_EXT_25").Value
                With wSheet.Range("Q" & cont_filas_tmp + f, "Q" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("Q" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 18) = dgvDetalle1.Rows(f).Cells("REM_HR_EXT_35").Value
                With wSheet.Range("R" & cont_filas_tmp + f, "R" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("R" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 19) = dgvDetalle1.Rows(f).Cells("REM_HR_EXT_100").Value
                With wSheet.Range("S" & cont_filas_tmp + f, "S" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("S" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 20) = dgvDetalle1.Rows(f).Cells("TOTAL_REM_HR_EXT").Value
                With wSheet.Range("T" & cont_filas_tmp + f, "T" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("T" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 21) = dgvDetalle1.Rows(f).Cells("TOTAL_REMUNERACION").Value
                With wSheet.Range("U" & cont_filas_tmp + f, "U" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("U" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 22) = dgvDetalle1.Rows(f).Cells("REMUNERACION_AFECTA_ESSALUD").Value
                With wSheet.Range("V" & cont_filas_tmp + f, "V" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("V" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 23) = dgvDetalle1.Rows(f).Cells("REMUNERACION_AFECTA_AFP").Value
                With wSheet.Range("W" & cont_filas_tmp + f, "W" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("W" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 24) = dgvDetalle1.Rows(f).Cells("OTROS_INGRESOS").Value
                With wSheet.Range("X" & cont_filas_tmp + f, "X" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("X" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 25) = dgvDetalle1.Rows(f).Cells("TOTAL_INGRESOS").Value
                With wSheet.Range("Y" & cont_filas_tmp + f, "Y" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("Y" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 26) = dgvDetalle1.Rows(f).Cells("ONP").Value
                With wSheet.Range("Z" & cont_filas_tmp + f, "Z" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("Z" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 27) = dgvDetalle1.Rows(f).Cells("AFP_APORTE_OBLIGATORIO").Value
                With wSheet.Range("AA" & cont_filas_tmp + f, "AA" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AA" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 28) = dgvDetalle1.Rows(f).Cells("AFP_COMISION").Value
                With wSheet.Range("AB" & cont_filas_tmp + f, "AB" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AB" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 29) = dgvDetalle1.Rows(f).Cells("AFP_PRIMA_SEG").Value
                With wSheet.Range("AC" & cont_filas_tmp + f, "AC" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AC" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 30) = dgvDetalle1.Rows(f).Cells("TOTAL_AFP").Value
                With wSheet.Range("AD" & cont_filas_tmp + f, "AD" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AD" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 31) = dgvDetalle1.Rows(f).Cells("ADELANTO").Value
                With wSheet.Range("AE" & cont_filas_tmp + f, "AE" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AE" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 32) = dgvDetalle1.Rows(f).Cells("OTROS_DESCUENTOS").Value
                With wSheet.Range("AF" & cont_filas_tmp + f, "AF" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AF" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 33) = dgvDetalle1.Rows(f).Cells("TOTAL_DESCUENTOS").Value
                With wSheet.Range("AG" & cont_filas_tmp + f, "AG" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AG" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 34) = dgvDetalle1.Rows(f).Cells("NETO_PAGAR").Value
                With wSheet.Range("AH" & cont_filas_tmp + f, "AH" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AH" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 35) = dgvDetalle1.Rows(f).Cells("ESSALUD").Value
                With wSheet.Range("AI" & cont_filas_tmp + f, "AI" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AI" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 36) = dgvDetalle1.Rows(f).Cells("SCTR_SALUD").Value
                With wSheet.Range("AJ" & cont_filas_tmp + f, "AJ" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AJ" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 37) = dgvDetalle1.Rows(f).Cells("SCTR_PENSION").Value
                With wSheet.Range("AK" & cont_filas_tmp + f, "AK" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AK" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 38) = dgvDetalle1.Rows(f).Cells("SENATI").Value
                With wSheet.Range("AL" & cont_filas_tmp + f, "AL" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AL" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"

                excel.Cells(cont_filas_tmp + f, 39) = dgvDetalle1.Rows(f).Cells("TOTAL_APORTES").Value
                With wSheet.Range("AM" & cont_filas_tmp + f, "AM" & cont_filas_tmp + f).Borders(xlEdgeLeft)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
                wSheet.Range("AM" & cont_filas_tmp + f).NumberFormat = "#,##0.00_);[Red](#,##0.00)"
                With wSheet.Range("AM" & cont_filas_tmp + f, "AM" & cont_filas_tmp + f).Borders(xlEdgeRight)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .Color = RGB(255, 153, 0)
                End With
            Next

            cont_filas_tmp = cont_filas_tmp + dgvDetalle1.Rows.Count - 1
            excel.Cells(cont_filas_tmp + 1, 3) = "TOTALES"
            wSheet.Range("B" & cont_filas_tmp + 1, "D" & cont_filas_tmp + 1).Merge(True)
            excel.Cells(cont_filas_tmp + 1, 2).HorizontalAlignment = 4
            wSheet.Range("B" & cont_filas_tmp + 1 & ":B" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            With wSheet.Range("C" & cont_filas_tmp + 1, "C" & cont_filas_tmp + 1).Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("D" & cont_filas_tmp + 1, "D" & cont_filas_tmp + 1).Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With

            wSheet.Range("E" & cont_filas_tmp + 1).Formula = "=SUM(E8:E" & cont_filas_tmp & ")"
            wSheet.Range("O" & cont_filas_tmp + 1).Formula = "=SUM(O8:O" & cont_filas_tmp & ")"
            wSheet.Range("P" & cont_filas_tmp + 1).Formula = "=SUM(P8:P" & cont_filas_tmp & ")"
            wSheet.Range("U" & cont_filas_tmp + 1).Formula = "=SUM(U8:U" & cont_filas_tmp & ")"
            wSheet.Range("T" & cont_filas_tmp + 1).Formula = "=SUM(T8:T" & cont_filas_tmp & ")"
            wSheet.Range("X" & cont_filas_tmp + 1).Formula = "=SUM(X8:X" & cont_filas_tmp & ")"
            wSheet.Range("Y" & cont_filas_tmp + 1).Formula = "=SUM(Y8:Y" & cont_filas_tmp & ")"
            wSheet.Range("Z" & cont_filas_tmp + 1).Formula = "=SUM(Z8:Z" & cont_filas_tmp & ")"
            wSheet.Range("AA" & cont_filas_tmp + 1).Formula = "=SUM(AA8:AA" & cont_filas_tmp & ")"
            wSheet.Range("AB" & cont_filas_tmp + 1).Formula = "=SUM(AB8:AB" & cont_filas_tmp & ")"
            wSheet.Range("AC" & cont_filas_tmp + 1).Formula = "=SUM(AC8:AC" & cont_filas_tmp & ")"
            wSheet.Range("AD" & cont_filas_tmp + 1).Formula = "=SUM(AD8:AD" & cont_filas_tmp & ")"
            wSheet.Range("AE" & cont_filas_tmp + 1).Formula = "=SUM(AE8:AE" & cont_filas_tmp & ")"
            wSheet.Range("AF" & cont_filas_tmp + 1).Formula = "=SUM(AF8:AF" & cont_filas_tmp & ")"
            wSheet.Range("AG" & cont_filas_tmp + 1).Formula = "=SUM(AG8:AG" & cont_filas_tmp & ")"
            wSheet.Range("AH" & cont_filas_tmp + 1).Formula = "=SUM(AH8:AH" & cont_filas_tmp & ")"
            wSheet.Range("AI" & cont_filas_tmp + 1).Formula = "=SUM(AI8:AI" & cont_filas_tmp & ")"
            wSheet.Range("AJ" & cont_filas_tmp + 1).Formula = "=SUM(AJ8:AJ" & cont_filas_tmp & ")"
            wSheet.Range("AK" & cont_filas_tmp + 1).Formula = "=SUM(AK8:AK" & cont_filas_tmp & ")"
            wSheet.Range("AL" & cont_filas_tmp + 1).Formula = "=SUM(AL8:AL" & cont_filas_tmp & ")"
            wSheet.Range("AM" & cont_filas_tmp + 1).Formula = "=SUM(AM8:AM" & cont_filas_tmp & ")"

            wSheet.Range("E" & cont_filas_tmp + 1 & ":E" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("O" & cont_filas_tmp + 1 & ":O" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("P" & cont_filas_tmp + 1 & ":P" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("U" & cont_filas_tmp + 1 & ":U" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("T" & cont_filas_tmp + 1 & ":T" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("X" & cont_filas_tmp + 1 & ":X" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("Y" & cont_filas_tmp + 1 & ":Y" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("Z" & cont_filas_tmp + 1 & ":Z" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AA" & cont_filas_tmp + 1 & ":AA" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AB" & cont_filas_tmp + 1 & ":AB" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AC" & cont_filas_tmp + 1 & ":AC" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AD" & cont_filas_tmp + 1 & ":AD" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AE" & cont_filas_tmp + 1 & ":AE" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AF" & cont_filas_tmp + 1 & ":AF" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AG" & cont_filas_tmp + 1 & ":AG" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AH" & cont_filas_tmp + 1 & ":AH" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AI" & cont_filas_tmp + 1 & ":AI" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AJ" & cont_filas_tmp + 1 & ":AJ" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AK" & cont_filas_tmp + 1 & ":AK" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AL" & cont_filas_tmp + 1 & ":AL" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)
            wSheet.Range("AM" & cont_filas_tmp + 1 & ":AM" & cont_filas_tmp + 1).BorderAround(Color:=RGB(255, 153, 0), Weight:=xlThin)


            With wSheet.Range("B" & cont_filas_tmp + 1, "B" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("C" & cont_filas_tmp + 1, "C" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("D" & cont_filas_tmp + 1, "D" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("E" & cont_filas_tmp + 1, "E" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("F" & cont_filas_tmp + 1, "F" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("G" & cont_filas_tmp + 1, "G" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("H" & cont_filas_tmp + 1, "H" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("I" & cont_filas_tmp + 1, "I" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("J" & cont_filas_tmp + 1, "J" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("K" & cont_filas_tmp + 1, "K" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("L" & cont_filas_tmp + 1, "L" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("M" & cont_filas_tmp + 1, "M" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("N" & cont_filas_tmp + 1, "N" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("O" & cont_filas_tmp + 1, "O" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("P" & cont_filas_tmp + 1, "P" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("Q" & cont_filas_tmp + 1, "Q" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("R" & cont_filas_tmp + 1, "R" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("S" & cont_filas_tmp + 1, "S" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("T" & cont_filas_tmp + 1, "T" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("U" & cont_filas_tmp + 1, "U" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("V" & cont_filas_tmp + 1, "V" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("W" & cont_filas_tmp + 1, "W" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("X" & cont_filas_tmp + 1, "X" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("Y" & cont_filas_tmp + 1, "Y" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("Z" & cont_filas_tmp + 1, "Z" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AA" & cont_filas_tmp + 1, "AA" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AB" & cont_filas_tmp + 1, "AB" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AC" & cont_filas_tmp + 1, "AC" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AD" & cont_filas_tmp + 1, "AD" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AE" & cont_filas_tmp + 1, "AE" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AF" & cont_filas_tmp + 1, "AF" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AG" & cont_filas_tmp + 1, "AG" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AH" & cont_filas_tmp + 1, "AH" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AI" & cont_filas_tmp + 1, "AI" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AJ" & cont_filas_tmp + 1, "AJ" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AK" & cont_filas_tmp + 1, "AK" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AL" & cont_filas_tmp + 1, "AL" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With
            With wSheet.Range("AM" & cont_filas_tmp + 1, "AM" & cont_filas_tmp + 1).Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .Color = RGB(255, 153, 0)
            End With

            'excel.Cells(cont_filas_tmp, 4) = txt_tot_debe.Text
            'excel.Cells(cont_filas_tmp, 5) = txt_tot_haber.Text

            wSheet.Columns.AutoFit()

            '****************** finalizamos *******************
            Dim strFileName As String = ruta_archivo & "Planilla_" & Format(CDate(dtpFecha_planilla.Value).Month, "00") & " - " & CDate(dtpFecha_planilla.Value).Year & ".xls"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            excel.Workbooks.Open(strFileName)
            excel.Visible = True

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_inicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_planilla.ValueChanged
        'If _inicio = True And Modo_actualizar = False Then
        '    txtcodigo.Text = Numeracion()
        'End If
    End Sub

    Private Sub dgvDetalle1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle1.CellFormatting
        If dgvDetalle1.Columns(e.ColumnIndex).Name = "FALTAS_D" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "TARDANZAS_H" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "SUSPENSION_PERFECTA" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "HR_EXT_25" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "HR_EXT_35" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "HR_EXT_100" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "TRABAJO_DESCANSO_DIAS" Then
            e.CellStyle.ForeColor = Color.Red
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_HR_EXT" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "INASISTENCIA" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "TARDANZAS" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "TRABAJO_DESCANSO" Then
            e.CellStyle.BackColor = Color.LightPink
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "REMUNERACION_BASICA_EFECTIVA" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "ASIG_FAMILIAR" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "COMISIONES" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "REM_HR_EXT_25" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "REM_HR_EXT_35" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "REM_HR_EXT_100" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_REM_HR_EXT" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_REMUNERACION" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "REMUNERACION_AFECTA_ESSALUD" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "REMUNERACION_AFECTA_AFP" Then
            e.CellStyle.BackColor = Color.Aquamarine
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "ESSALUD_VIDA_ASEG_PENSION" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "AFP_APORTE_OBLIGATORIO" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "AFP_COMISION" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "AFP_PRIMA_SEG" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "ADELANTO" Then
            e.CellStyle.BackColor = Color.Azure
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_DESCUENTOS" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_INGRESOS" Then
            e.CellStyle.BackColor = Color.LightGoldenrodYellow
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "ONP" Then
            e.CellStyle.BackColor = Color.Lavender
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_AFP" Then
            e.CellStyle.BackColor = Color.LavenderBlush
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "NETO_PAGAR" Then
            e.CellStyle.BackColor = Color.Pink
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "ESSALUD" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "SCTR_SALUD" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "SCTR_PENSION" Or
            dgvDetalle1.Columns(e.ColumnIndex).Name = "SENATI" Or dgvDetalle1.Columns(e.ColumnIndex).Name = "EPS" Then
            e.CellStyle.BackColor = Color.LightSeaGreen
        End If

        If dgvDetalle1.Columns(e.ColumnIndex).Name = "TOTAL_APORTES" Then
            e.CellStyle.BackColor = Color.LightSkyBlue
        End If

    End Sub

    Private Sub RegistrarIngresosdescuentosVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarIngresosdescuentosVariablesToolStripMenuItem.Click
        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            GenerarColummnaDataTable_Ingresos_Variables()
            GenerarColummnaDataTable_Descuentos_Variables()

            _codigo_personal = dgvDetalle1.CurrentRow.Cells("CODIGO").Value
            txt_personal_id_variables.Text = dgvDetalle1.CurrentRow.Cells("APELLIDOS_NOMBRES").Value

            For Each row As DataRow In dtDocumentos_ingresos_Descuentos_variables.Select("TIPO='I' AND COD_PERSONAL='" & _codigo_personal & "'")
                Dim row2 As DataRow = dt_ingresos_variables.NewRow
                row2("ITEM") = dt_ingresos_variables.Rows.Count() + 1
                row2("TIPO") = row("TIPO")
                row2("COD_PERSONAL") = row("COD_PERSONAL")
                row2("COD_CONCEPTO") = row("COD_CONCEPTO")
                row2("CONCEPTO") = row("CONCEPTO")
                row2("MONTO") = row("MONTO")
                dt_ingresos_variables.Rows.Add(row2)
                dt_ingresos_variables.AcceptChanges()
            Next
            'dgv_ingresos.DataSource = dt_ingresos_variables


            For Each row As DataRow In dtDocumentos_ingresos_Descuentos_variables.Select("TIPO='D' AND COD_PERSONAL='" & _codigo_personal & "'")
                Dim row2 As DataRow = dt_descuentos_variables.NewRow
                row2("ITEM") = dt_descuentos_variables.Rows.Count() + 1
                row2("TIPO") = row("TIPO")
                row2("COD_PERSONAL") = row("COD_PERSONAL")
                row2("COD_CONCEPTO") = row("COD_CONCEPTO")
                row2("CONCEPTO") = row("CONCEPTO")
                row2("MONTO") = row("MONTO")
                dt_descuentos_variables.Rows.Add(row2)
                dt_descuentos_variables.AcceptChanges()
            Next
            'dgv_descuentos.DataSource = dt_descuentos_variables

            Muestra_Conceptos_Variables()
            GbCabecera.Enabled = False
            btn_menu.Enabled = False
            CONTROLES(TabPage1, False)
            CONTROLES(TabPage2, True)
            'tc_tipos.SelectedIndex = 1

            txtbusqueda.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub GenerarColummnaDataTable_Ingresos_Descuentos_Variables()
        dtDocumentos_ingresos_Descuentos_variables = New DataTable
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("TIPO", Type.GetType("System.String")) '1
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("COD_PERSONAL", Type.GetType("System.String")) '2
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("COD_CONCEPTO", Type.GetType("System.String")) '3
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("CONCEPTO", Type.GetType("System.String")) '4
        dtDocumentos_ingresos_Descuentos_variables.Columns.Add("MONTO", Type.GetType("System.Double")) '5
    End Sub

    Public Sub GenerarColummnaDataTable_Ingresos_Variables()
        dt_ingresos_variables = New DataTable
        dt_ingresos_variables.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dt_ingresos_variables.Columns.Add("TIPO", Type.GetType("System.String")) '1
        dt_ingresos_variables.Columns.Add("COD_PERSONAL", Type.GetType("System.String")) '2
        dt_ingresos_variables.Columns.Add("COD_CONCEPTO", Type.GetType("System.String")) '3
        dt_ingresos_variables.Columns.Add("CONCEPTO", Type.GetType("System.String")) '4
        dt_ingresos_variables.Columns.Add("MONTO", Type.GetType("System.Double")) '5

        dgv_ingresos.DataSource = Nothing
        dgv_ingresos.DataSource = dt_ingresos_variables
        dgv_ingresos.AutoResizeColumns()
        dgv_ingresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgv_ingresos.Columns("TIPO").Visible = False
        dgv_ingresos.Columns("COD_PERSONAL").Visible = False
        dgv_ingresos.Columns("COD_CONCEPTO").Visible = False
        dgv_ingresos.Columns("MONTO").DefaultCellStyle.Format = "N2"
        dgv_ingresos.Columns("MONTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_ingresos.Columns("ITEM").ReadOnly = True
        dgv_ingresos.Columns("TIPO").ReadOnly = True
        dgv_ingresos.Columns("COD_PERSONAL").ReadOnly = True
        dgv_ingresos.Columns("COD_CONCEPTO").ReadOnly = True
        dgv_ingresos.Columns("CONCEPTO").ReadOnly = True
    End Sub

    Public Sub GenerarColummnaDataTable_Descuentos_Variables()
        dt_descuentos_variables = New DataTable
        dt_descuentos_variables.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dt_descuentos_variables.Columns.Add("TIPO", Type.GetType("System.String")) '1
        dt_descuentos_variables.Columns.Add("COD_PERSONAL", Type.GetType("System.String")) '2
        dt_descuentos_variables.Columns.Add("COD_CONCEPTO", Type.GetType("System.String")) '3
        dt_descuentos_variables.Columns.Add("CONCEPTO", Type.GetType("System.String")) '4
        dt_descuentos_variables.Columns.Add("MONTO", Type.GetType("System.Double")) '5

        dgv_descuentos.DataSource = Nothing
        dgv_descuentos.DataSource = dt_descuentos_variables
        dgv_descuentos.AutoResizeColumns()
        dgv_descuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgv_descuentos.Columns("TIPO").Visible = False
        dgv_descuentos.Columns("COD_PERSONAL").Visible = False
        dgv_descuentos.Columns("COD_CONCEPTO").Visible = False
        dgv_descuentos.Columns("MONTO").DefaultCellStyle.Format = "N2"
        dgv_descuentos.Columns("MONTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_descuentos.Columns("ITEM").ReadOnly = True
        dgv_descuentos.Columns("TIPO").ReadOnly = True
        dgv_descuentos.Columns("COD_PERSONAL").ReadOnly = True
        dgv_descuentos.Columns("COD_CONCEPTO").ReadOnly = True
        dgv_descuentos.Columns("CONCEPTO").ReadOnly = True

    End Sub

    Private Sub Muestra_Conceptos_Variables()
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            Dim dt_conceptos_variables As DataTable
            dt_conceptos_variables = New DataTable
            dtv_conceptos_variables = New DataView
            dt_conceptos_variables = clsPedidoBl.get_Lista_Conceptos_Variables_RRHH()
            dgv_lista_conceptos_variables.DataSource = Nothing
            dtv_conceptos_variables = dt_conceptos_variables.DefaultView
            If dt_conceptos_variables.Rows.Count() <> 0 Then
                dgv_lista_conceptos_variables.DataSource = dtv_conceptos_variables
                dgv_lista_conceptos_variables.Columns(0).Visible = False
                dgv_lista_conceptos_variables.AutoResizeColumns()
                dgv_lista_conceptos_variables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                STRorden_conceptos_variables = dgv_lista_conceptos_variables.Columns("DESCRIPCION").Name
            Else
                STRorden_conceptos_variables = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If STRorden_conceptos_variables = "" Then Exit Sub
        If txtbusqueda.Text = String.Empty Then
            dtv_conceptos_variables.RowFilter = String.Empty
            Exit Sub
        Else
            dtv_conceptos_variables.RowFilter = STRorden_conceptos_variables & " like '%" & txtbusqueda.Text & "%'"
            If dtv_conceptos_variables.Count() = 0 Then
                STRorden_conceptos_variables = String.Empty
                STRorden_conceptos_variables = dgv_lista_conceptos_variables.Columns("DESCRIPCION").Name
                dtv_conceptos_variables.RowFilter = STRorden_conceptos_variables & " like '%" & txtbusqueda.Text & "%'"
            End If
        End If
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click

        If dgv_lista_conceptos_variables.CurrentRow Is Nothing Then Exit Sub

        Dim _CODIGO As String = ""
        Dim _NAME As String = ""
        Dim _TIPO As String = ""
        Dim _item As Integer = 0

        _CODIGO = dgv_lista_conceptos_variables.CurrentRow.Cells("CODIGO").Value
        _NAME = dgv_lista_conceptos_variables.CurrentRow.Cells("DESCRIPCION").Value
        _TIPO = dgv_lista_conceptos_variables.CurrentRow.Cells("TIPO").Value

        'Validaciones

        If _TIPO = "INGRESO" Then
            If dt_ingresos_variables.Rows.Count() <> 0 Then
                Dim Resultado() As DataRow
                Resultado = dt_ingresos_variables.Select("COD_CONCEPTO='" & _CODIGO & "'", "")
                If Resultado.Count() <> 0 Then
                    MsgBox("El concepto variable ya se registro anteriormente.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            Dim row2 As DataRow = dt_ingresos_variables.NewRow
            row2("ITEM") = dt_ingresos_variables.Rows.Count() + 1
            row2("TIPO") = "I"
            row2("COD_PERSONAL") = _codigo_personal
            row2("COD_CONCEPTO") = _CODIGO
            row2("CONCEPTO") = _NAME
            row2("MONTO") = 0
            dt_ingresos_variables.Rows.Add(row2)
            dt_ingresos_variables.AcceptChanges()

        ElseIf _TIPO = "DESCUENTO" Then
            If dt_descuentos_variables.Rows.Count() <> 0 Then
                Dim Resultado() As DataRow
                Resultado = dt_descuentos_variables.Select("COD_CONCEPTO='" & _CODIGO & "'", "")
                If Resultado.Count() <> 0 Then
                    MsgBox("El concepto variable ya se registro anteriormente.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            Dim row2 As DataRow = dt_descuentos_variables.NewRow
            row2("ITEM") = dt_descuentos_variables.Rows.Count() + 1
            row2("TIPO") = "D"
            row2("COD_PERSONAL") = _codigo_personal
            row2("COD_CONCEPTO") = _CODIGO
            row2("CONCEPTO") = _NAME
            row2("MONTO") = 0
            dt_descuentos_variables.Rows.Add(row2)
            dt_descuentos_variables.AcceptChanges()

        End If

    End Sub

    Private Sub EliminarIngresoVariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarIngresoVariableToolStripMenuItem.Click
        If dgv_ingresos.CurrentRow Is Nothing Then Exit Sub

        Try
            If dt_ingresos_variables.Rows.Count = 0 Then Exit Sub
            Dim Codigo As String = String.Empty
            Codigo = dgv_ingresos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dt_ingresos_variables.Select("ITEM=" & Codigo)
                dt_ingresos_variables.BeginInit()
                item.Delete()
                dt_ingresos_variables.EndInit()
                dt_ingresos_variables.AcceptChanges()
            Next
            RehacerCorrelativo_Ingresos_Variables()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerCorrelativo_Ingresos_Variables()
        Dim i As Integer = 0
        For Each items As DataRow In dt_ingresos_variables.Rows
            i += 1
            dt_ingresos_variables.BeginInit()
            items("ITEM") = i
            dt_ingresos_variables.EndInit()
            dt_ingresos_variables.AcceptChanges()
        Next
    End Sub

    Private Sub EliminarDescuentoVariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDescuentoVariableToolStripMenuItem.Click
        If dgv_descuentos.CurrentRow Is Nothing Then Exit Sub

        Try
            If dt_descuentos_variables.Rows.Count = 0 Then Exit Sub
            Dim Codigo As String = String.Empty
            Codigo = dgv_descuentos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dt_descuentos_variables.Select("ITEM=" & Codigo)
                dt_descuentos_variables.BeginInit()
                item.Delete()
                dt_descuentos_variables.EndInit()
                dt_descuentos_variables.AcceptChanges()
            Next
            RehacerCorrelativo_Descuentos_Variables()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerCorrelativo_Descuentos_Variables()
        Dim i As Integer = 0
        For Each items As DataRow In dt_descuentos_variables.Rows
            i += 1
            dt_descuentos_variables.BeginInit()
            items("ITEM") = i
            dt_descuentos_variables.EndInit()
            dt_descuentos_variables.AcceptChanges()
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtbusqueda.Text = ""
        dgv_lista_conceptos_variables.DataSource = Nothing
        GbCabecera.Enabled = True
        btn_menu.Enabled = True
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        'tc_tipos.SelectedIndex = 0
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If dt_ingresos_variables.Rows.Count = 0 And dt_descuentos_variables.Rows.Count = 0 Then
            MsgBox("Debe agregar un concepto variable.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            For Each item As DataRow In dtDocumentos_ingresos_Descuentos_variables.Select("COD_PERSONAL='" & _codigo_personal & "'")
                dtDocumentos_ingresos_Descuentos_variables.BeginInit()
                item.Delete()
                dtDocumentos_ingresos_Descuentos_variables.EndInit()
                dtDocumentos_ingresos_Descuentos_variables.AcceptChanges()
            Next

            For i As Integer = 0 To dt_ingresos_variables.Rows.Count - 1
                Dim row2 As DataRow = dtDocumentos_ingresos_Descuentos_variables.NewRow
                row2("ITEM") = dt_ingresos_variables.Rows(i).Item("ITEM").ToString
                row2("TIPO") = dt_ingresos_variables.Rows(i).Item("TIPO").ToString
                row2("COD_PERSONAL") = dt_ingresos_variables.Rows(i).Item("COD_PERSONAL").ToString
                row2("COD_CONCEPTO") = dt_ingresos_variables.Rows(i).Item("COD_CONCEPTO").ToString
                row2("CONCEPTO") = dt_ingresos_variables.Rows(i).Item("CONCEPTO").ToString
                row2("MONTO") = dt_ingresos_variables.Rows(i).Item("MONTO")
                dtDocumentos_ingresos_Descuentos_variables.Rows.Add(row2)
                dtDocumentos_ingresos_Descuentos_variables.AcceptChanges()
            Next

            For i As Integer = 0 To dt_descuentos_variables.Rows.Count - 1
                Dim row2 As DataRow = dtDocumentos_ingresos_Descuentos_variables.NewRow
                row2("ITEM") = dt_descuentos_variables.Rows(i).Item("ITEM").ToString
                row2("TIPO") = dt_descuentos_variables.Rows(i).Item("TIPO").ToString
                row2("COD_PERSONAL") = dt_descuentos_variables.Rows(i).Item("COD_PERSONAL").ToString
                row2("COD_CONCEPTO") = dt_descuentos_variables.Rows(i).Item("COD_CONCEPTO").ToString
                row2("CONCEPTO") = dt_descuentos_variables.Rows(i).Item("CONCEPTO").ToString
                row2("MONTO") = dt_descuentos_variables.Rows(i).Item("MONTO")
                dtDocumentos_ingresos_Descuentos_variables.Rows.Add(row2)
                dtDocumentos_ingresos_Descuentos_variables.AcceptChanges()
            Next

            txtbusqueda.Text = ""
            dgv_lista_conceptos_variables.DataSource = Nothing

            GbCabecera.Enabled = True
            btn_menu.Enabled = True
            CONTROLES(TabPage1, True)
            CONTROLES(TabPage2, False)
            'tc_tipos.SelectedIndex = 0
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click
        Try
            If MsgBox("Esta seguro de Finalizar la Planilla de Sueldos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New ClsOperaciones.ORDERS
                pl_planilla_cab = New ClsEntidades.PL_PLANILLA

                With pl_planilla_cab
                    .ID = _codigo_planilla
                    .CODIGO = txtcodigo.Text
                    .TITULO = txt_titulo.Text
                    .MES_ANIO = ModFunciones.Primer_Dia_Mes(dtpFecha_planilla.Value.ToString("dd/MM/yyyy"))
                    .STATUS = "F"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                End With

                If clsPedidoBl.Finalizacion_Planilla(pl_planilla_cab) Then
                    MsgBox("Planilla de Sueldos Finalizado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimirBoletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirBoletaToolStripMenuItem.Click
        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            Dim dt_imprime_planilla As DataTable
            Dim dtDatosCompany As DataTable
            dtDatosCompany = New DataTable
            dtDatosCompany = clsPedidoBl.Obtener_Datos_Empresa()

            _codigo_personal = dgvDetalle1.CurrentRow.Cells("CODIGO").Value
            'Dim _codigo_planilla As String = _codigo_planilla
            dt_imprime_planilla = clsPedidoBl.Rpt_Imprime_Boleta_RR_HH(_codigo_planilla, _codigo_personal)

            If dt_imprime_planilla.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte_BP("rpt_Boleta_Pago_RRHH.rpt", dt_imprime_planilla, "", "", dt_imprime_planilla.Rows(0).Item("NOMBRE_ARCHIVO").ToString,
                                                  "@ID;" & _codigo_planilla,
                                                  "@CODIGO_PERSONAL;" & _codigo_personal,
                                                  "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString,
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub dgvDetalle1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle1.CellEndEdit
        Sumar_Marcados()
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        If checkTodos.Checked = True Then
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                dgvDetalle1.Rows(i).Cells("Sel").Value = True
            Next
        Else
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                dgvDetalle1.Rows(i).Cells("Sel").Value = False
            Next
        End If
        Sumar_Marcados()
    End Sub

    Private Sub btn_reapertura_planilla_Click(sender As Object, e As EventArgs) Handles btn_reapertura_planilla.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            If dgvCabecera.CurrentRow.Cells("ESTADO").Value = "FINALIZADO" Then
                If MessageBox.Show("Seguro de Aperturar la Planilla", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim clienteBE As New ClsEntidades.PL_EMPLOYEE
                    Dim clienteBL As New ClsOperaciones.CUSTOMER
                    clienteBE.EMPLOYEE_ID = dgvCabecera.CurrentRow.Cells("ID").Value
                    If clienteBL.Apertura_Planilla(clienteBE) Then
                        clienteBE = Nothing
                        clienteBL = Nothing
                        MessageBox.Show("Apertura de Planilla correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call DocumentosRequisiones()
                    End If

                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exportar_ftp_Click(sender As Object, e As EventArgs) Handles btn_exportar_ftp.Click
        pnl_exporta_boletas.Visible = True
        dtpFecha_planilla_2.Value = dtpFecha_planilla.Value
        txtRuta.Text = ""
        'btn_exportar_ftp.Visible = False
        'btn_exporta_boletas.Visible = False
        btn_genera_pdf_boletas.Visible = True
        btn_menu.Enabled = False
        tc_tipos.Enabled = False
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_genera_pdf_boletas.Click
        If txtRuta.Text.Trim = "" Then MsgBox("Debe elegir una ruta!!!", MsgBoxStyle.Exclamation, "Aviso") : Exit Sub

        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            Dim dt_imprime_planilla As DataTable
            Dim dtDatosCompany As DataTable
            dtDatosCompany = New DataTable
            dtDatosCompany = clsPedidoBl.Obtener_Datos_Empresa()

            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                If dgvDetalle1.Rows(i).Cells("Sel").Value Then
                    _codigo_personal = dgvDetalle1.Rows(i).Cells("CODIGO").Value
                    dt_imprime_planilla = clsPedidoBl.Rpt_Imprime_Boleta_RR_HH(dgvCabecera.CurrentRow.Cells("ID").Value, _codigo_personal)

                    If dt_imprime_planilla.Rows.Count() <> 0 Then
                        'crystalBL.Muestra_Reporte_BP("rpt_Boleta_Pago_RRHH.rpt", dt_imprime_planilla, "", "", dt_imprime_planilla.Rows(0).Item("NOMBRE_ARCHIVO").ToString,
                        '                                  "@ID;" & dgvCabecera.CurrentRow.Cells("ID").Value,
                        '                                  "@CODIGO_PERSONAL;" & _codigo_personal,
                        '                                  "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString,
                        '                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)

                        crystalBL.Muestra_Reporte_Exporta_PDF("rpt_Boleta_Pago_RRHH.rpt", dt_imprime_planilla, "", "", dt_imprime_planilla.Rows(0).Item("NOMBRE_ARCHIVO").ToString,
                                                              txtRuta.Text,
                                                          "@ID;" & dgvCabecera.CurrentRow.Cells("ID").Value,
                                                          "@CODIGO_PERSONAL;" & _codigo_personal,
                                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString,
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                        'Else
                        '    MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                End If
            Next
            MsgBox("Generación de Boletas correctamente.", MsgBoxStyle.Information, "Aviso")
            'btn_exporta_boletas.Visible = True
            'btn_genera_pdf_boletas.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_exporta_boletas_Click(sender As Object, e As EventArgs) Handles btn_exporta_boletas.Click
        If txtRuta.Text.Trim = "" Then MsgBox("Debe elegir una ruta!!!", MsgBoxStyle.Exclamation, "Aviso") : Exit Sub

        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Dim appPath As String = Application.StartupPath()
        Dim proces As New Process()
        proces.StartInfo.FileName = appPath & "/EnvioBoletas/WinFormsApp1.exe"
        proces.Start()

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            pl_planilla_det = New ClsEntidades.PL_PLANILLA_LINE
            Dim lista_pl_planilla_det As New List(Of ClsEntidades.PL_PLANILLA_LINE)

            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                If dgvDetalle1.Rows(i).Cells("Sel").Value Then
                    Dim dni As String = dgvDetalle1.Rows(i).Cells("NUMERO_DOC").Value
                    Dim anio As String = dtpFecha_planilla_2.Value.Year
                    Dim mes As String = Format(dtpFecha_planilla_2.Value.Month, "00")

                    Dim StrNomArchivo_PDF As String = txtRuta.Text & "\" & dni & "_" & anio & "_" & mes & ".pdf"

                    If Not File.Exists(StrNomArchivo_PDF) Then Continue For

                    pl_planilla_det = New ClsEntidades.PL_PLANILLA_LINE
                    With pl_planilla_det
                        .ID_CAB = dgvCabecera.CurrentRow.Cells("ID").Value
                        .ITEM = dgvDetalle1.Rows(i).Cells("ITEM").Value
                        .CODIGO = dgvDetalle1.Rows(i).Cells("CODIGO").Value
                        .NUMERO_DOC = dgvDetalle1.Rows(i).Cells("NUMERO_DOC").Value
                        .AFP_ID = dni & "_" & anio & "_" & mes & ".pdf"
                    End With
                    lista_pl_planilla_det.Add(pl_planilla_det)

                End If
            Next

            If clsPedidoBl.Exportar_Boletas_Planilla(lista_pl_planilla_det) Then
                DocumentosRequisiones()
                'MsgBox("Exportación de Boletas correctamente.", MsgBoxStyle.Information, "Aviso")
                btn_cancelar_exp_Click(sender, e)
                Me.Cursor = Cursors.Default
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_exp_Click(sender As Object, e As EventArgs) Handles btn_cancelar_exp.Click
        btn_menu.Enabled = True
        tc_tipos.Enabled = True
        pnl_exporta_boletas.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Dim frm As New Form1
        'frm.ShowDialog()
        Dim appPath As String = Application.StartupPath()
        Dim proces As New Process()
        proces.StartInfo.FileName = appPath & "/EnvioBoletas/WinFormsApp1.exe"
        proces.Start()
    End Sub

    Private Sub btn_afpnet_Click(sender As Object, e As EventArgs) Handles btn_afpnet.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Carpeta As New FolderBrowserDialog
            Dim ruta_archivo As String
            If Carpeta.ShowDialog() = DialogResult.OK Then
                ruta_archivo = Carpeta.SelectedPath.ToString & "\"
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Const xlEdgeLeft = 7
            Const xlEdgeRight = 10
            Const xlEdgeTop = 8
            Const xlEdgeBottom = 9
            Const xlInsideHorizontal = 12
            Const xlInsideVertical = 11
            Const xlContinuous = 1
            Const xlThin = 2

            Dim excel As Object
            Dim wBook As Object
            Dim wSheet As Object

            excel = CreateObject("Excel.Application")

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            wSheet.Name = "AFP"

            Dim cont_filas_tmp As Integer = 1

            clsPedidoBl = New ClsOperaciones.ORDERS
            'Mostrando datos del detalle
            dtGeneraAFP = New DataTable
            dtGeneraAFP = clsPedidoBl.Get_Datos_GeneraAFPNet(dgvCabecera.CurrentRow.Cells("ID").Value)

            If dtDocumentos.Rows.Count > 0 Then
                For f As Integer = 0 To dtGeneraAFP.Rows.Count - 1
                    excel.Cells(cont_filas_tmp + f, 1) = dtGeneraAFP.Rows(f)("SECUENCIA")
                    excel.Cells(cont_filas_tmp + f, 2) = dtGeneraAFP.Rows(f)("CUSPP")
                    excel.Cells(cont_filas_tmp + f, 3) = dtGeneraAFP.Rows(f)("TIPO_DOC")
                    excel.Cells(cont_filas_tmp + f, 4) = "'" + dtGeneraAFP.Rows(f)("NUMERO_DOC")

                    excel.Cells(cont_filas_tmp + f, 5) = dtGeneraAFP.Rows(f)("AP_PATERNO")
                    excel.Cells(cont_filas_tmp + f, 6) = dtGeneraAFP.Rows(f)("AP_MATERNO")
                    excel.Cells(cont_filas_tmp + f, 7) = dtGeneraAFP.Rows(f)("NOMBRES")
                    excel.Cells(cont_filas_tmp + f, 8) = dtGeneraAFP.Rows(f)("RELACION_LABORAL")
                    excel.Cells(cont_filas_tmp + f, 9) = dtGeneraAFP.Rows(f)("INICIO_RL")
                    excel.Cells(cont_filas_tmp + f, 10) = dtGeneraAFP.Rows(f)("CESE_RL")
                    excel.Cells(cont_filas_tmp + f, 11) = dtGeneraAFP.Rows(f)("EXCEPCION_APORTAR")
                    excel.Cells(cont_filas_tmp + f, 12) = dtGeneraAFP.Rows(f)("REMUNERACION_ASEGURABLE")
                    excel.Cells(cont_filas_tmp + f, 13) = dtGeneraAFP.Rows(f)("APORTE_AFILIADO_CON")
                    excel.Cells(cont_filas_tmp + f, 14) = dtGeneraAFP.Rows(f)("APORTE_AFILIADO_SIN")
                    excel.Cells(cont_filas_tmp + f, 15) = dtGeneraAFP.Rows(f)("APORTE_EMPLEADOR")
                    excel.Cells(cont_filas_tmp + f, 16) = dtGeneraAFP.Rows(f)("DEPENDIENTE_NORMAL")
                    excel.Cells(cont_filas_tmp + f, 17) = dtGeneraAFP.Rows(f)("AFP_BLANCO")
                Next
            End If

            wSheet.Columns.AutoFit()

            '****************** finalizamos *******************
            Dim strFileName As String = ruta_archivo & "Planilla_Nuevo_Formato_" & Format(CDate(dtpFecha_planilla.Value).Month, "00") & " - " & CDate(dtpFecha_planilla.Value).Year & ".xls"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            excel.Workbooks.Open(strFileName)
            excel.Visible = True

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Generar_Plame_Click(sender As Object, e As EventArgs) Handles btn_Generar_Plame.Click
        pnl_exportar_plame.Visible = True
        pnl_exportar_plame.BringToFront()
        dtp_plame.Value = dtpFecha_planilla.Value
        txt_ruta_plame.Text = ""
        'btn_exportar_ftp.Visible = False
        'btn_exporta_boletas.Visible = False
        btn_exp_plames.Visible = True
        btn_menu.Enabled = False
        tc_tipos.Enabled = False
        chk_jor.Checked = False
        chk_Remuneración.Checked = False
        chk_tasa_sctr.Checked = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        btn_menu.Enabled = True
        tc_tipos.Enabled = True
        pnl_exportar_plame.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txt_ruta_plame.Text = Carpeta.SelectedPath.ToString
        End If
    End Sub

    Private Sub btn_exp_plames_Click(sender As Object, e As EventArgs) Handles btn_exp_plames.Click
        If txt_ruta_plame.Text.Trim = "" Then MsgBox("Debe elegir una ruta!!!", MsgBoxStyle.Exclamation, "Aviso") : Exit Sub

        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            If chk_jor.Checked = False And chk_Remuneración.Checked = False And chk_tasa_sctr.Checked = False Then
                MsgBox("Debe seleccionar al menos una opción.", MsgBoxStyle.Information, "Aviso")
            Else
                If chk_jor.Checked Then GeneraPlameJor()
                If chk_Remuneración.Checked Then GeneraPlameRem()
                If chk_tasa_sctr.Checked Then GeneraPlameTas()
                chk_jor.Checked = False
                chk_Remuneración.Checked = False
                chk_tasa_sctr.Checked = False

                MsgBox("Generación de Plame correctamente.", MsgBoxStyle.Information, "Aviso")
            End If

            'btn_exporta_boletas.Visible = True
            'btn_genera_pdf_boletas.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GeneraPlameJor()
        clsPedidoBl = New ClsOperaciones.ORDERS
        clsPedidoBl.get_PLE_Planilla_Plame_Jor(dtp_plame.Value.Year.ToString, dtp_plame.Value.Month.ToString, dgvCabecera.CurrentRow.Cells("ID").Value, txt_ruta_plame.Text)
        clsPedidoBl = Nothing
    End Sub
    Private Sub GeneraPlameRem()
        clsPedidoBl = New ClsOperaciones.ORDERS
        clsPedidoBl.get_PLE_Planilla_Plame_Rem(dtp_plame.Value.Year.ToString, dtp_plame.Value.Month.ToString, dgvCabecera.CurrentRow.Cells("ID").Value, txt_ruta_plame.Text)
        clsPedidoBl = Nothing
    End Sub
    Private Sub GeneraPlameTas()
        clsPedidoBl = New ClsOperaciones.ORDERS
        clsPedidoBl.get_PLE_Planilla_Plame_Tas(dtp_plame.Value.Year.ToString, dtp_plame.Value.Month.ToString, dgvCabecera.CurrentRow.Cells("ID").Value, txt_ruta_plame.Text)
        clsPedidoBl = Nothing
    End Sub
End Class