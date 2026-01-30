Imports System.Windows.Forms
Imports System.Drawing
Imports LibComunVar
Imports LibContabilidad
Imports LibSeguridad.ClsUsuario
Imports System.Data.SqlClient.SqlConnection

Public Class FrmMovimientosCaja
    Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Public dtUsuarioAcceso As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Public tipo_cambio_planilla As Double
    Dim opt_planilla_detalle As String
    Dim opt_rendicion As String
    Dim bol_activar_cmbs As Boolean = False
    Dim dtvC As DataView
    Dim dtvD As DataView
    Dim STRorden As String = String.Empty
    Dim clsBuscar As ClsBuscar

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim clsClienteBl As ClsOperaciones.RECEIVABLE_LIST
    Dim dtDetalleTerceros As DataTable
    Dim _total_pago As Double
    Dim FechaActualPlanilla As String = String.Empty
    Dim _NUMERACION As String = String.Empty

    Dim _CODIGO_PLANILLA As String = String.Empty
    Dim _FECHA_PLANILLA As String = String.Empty
    Dim _FLAG_CONTA As Boolean = False
    Dim _FLAG_EDICION As Boolean = False
    Dim _ITEM_DETALLE As Integer = 0
    Dim dtDocumentosPrincipal As DataTable
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtDetalleClientes As DataTable
    Dim dtvcliente As DataView
    Dim _inicio As String = "si"
    Dim ESTADO_MODIF_DETALLE_RENDICION As Boolean

    Private Sub FrmMovimientosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Moneda()
        Call Cargar_Conceptos()
        Call Cargar_Documentos()
        Call Cargar_Personal()
        Call Cargar_TipoDoc()
        Call Cargar_TipoCompania()
        Formating()
        CONTROLES(True, 0)
        dtp_fecha_ini.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_fecha_fin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        _inicio = "no"
        dtp_fecha_ini.Select()
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmbmoneda.DataSource = monedaBL.get_TiposCambio()
        cmbmoneda.ValueMember = "CODIGO"
        cmbmoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        For i As Integer = 0 To tc_planilla.TabPages.Count() - 1
            tc_planilla.TabPages(i).Enabled = False
        Next
        'If _indice = 0 Then
        '    ToolStrip1.Enabled = True
        'Else
        '    ToolStrip1.Enabled = False
        'End If
        tc_planilla.TabPages(_indice).Enabled = opcion
        tc_planilla.SelectTab(_indice)
    End Sub

#Region "subprocesos"

    Private Sub Iniciar_Formulario()
        bol_activar_cmbs = True
    End Sub

    Private Sub Cargar_Conceptos()
        Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New ClsOperaciones.DOCUMENT_TYPE
        cmbconcepto.DataSource = documentosBL.get_Conceptos()
        cmbconcepto.ValueMember = "COD"
        cmbconcepto.DisplayMember = "DES"
        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New ClsOperaciones.DOCUMENT_TYPE
        cmbdocumento.DataSource = documentosBL.get_Documentos_CajaChica()
        cmbdocumento.ValueMember = "COD"
        cmbdocumento.DisplayMember = "DES"

        cmb_documento_rendicion.DataSource = documentosBL.get_Documentos_CajaChica()
        cmb_documento_rendicion.ValueMember = "COD"
        cmb_documento_rendicion.DisplayMember = "DES"

        ComboBox1.DataSource = documentosBL.get_Documentos_CajaChica()
        ComboBox1.ValueMember = "COD"
        ComboBox1.DisplayMember = "DES"

        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Personal()
        Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New ClsOperaciones.DOCUMENT_TYPE
        cmbpersonal.DataSource = documentosBL.get_Personal()
        cmbpersonal.ValueMember = "COD"
        cmbpersonal.DisplayMember = "DES"
        documentosBL = Nothing
    End Sub

    Private Sub Consultar_Planillas_Cab_xfecha()
        Me.Cursor = Cursors.WaitCursor
        Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST
        dtvC = New DataView
        Dim fecha_ini As String = CDate(dtp_fecha_ini.Value).ToShortDateString
        Dim fecha_fin As String = CDate(dtp_fecha_fin.Value).ToShortDateString
        dtvC = planillaBL.get_planilla_x_fecha_caja_chica(fecha_ini, fecha_fin).DefaultView
        dgv_planillas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dgv_planillas.DataSource = dtvC

        dgv_planillas.Columns(0).HeaderText = "N° Planilla"
        dgv_planillas.Columns(1).HeaderText = "Fecha"
        dgv_planillas.Columns(2).HeaderText = "Saldo Inicial MN"
        dgv_planillas.Columns(2).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(3).HeaderText = "Ingresos MN"
        dgv_planillas.Columns(3).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(4).HeaderText = "Egresos MN"
        dgv_planillas.Columns(4).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(5).HeaderText = "Saldo Final MN"
        dgv_planillas.Columns(5).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_planillas.Columns(6).HeaderText = "Saldo Inicial ME"
        dgv_planillas.Columns(6).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(7).HeaderText = "Ingresos ME"
        dgv_planillas.Columns(7).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(8).HeaderText = "Egresos ME"
        dgv_planillas.Columns(8).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(9).HeaderText = "Saldo Final ME"
        dgv_planillas.Columns(9).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_planillas.Columns(10).HeaderText = "Estado"
        dgv_planillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        STRorden = String.Empty
        STRorden = dgv_planillas.Columns(0).Name
        lblCantidad.Text = "Se encontraron " & dtvC.Count & " registros"
        planillaBL = Nothing
        Formating()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Formating()
        'For i As Integer = 0 To dgv_planillas.Columns.Count - 1
        '    dgv_planillas.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        'Next
        'For i As Integer = 0 To dgv_planillas.Rows.Count() - 1
        '    If String.IsNullOrEmpty(dgv_planillas.Item(4, i).Value.ToString) Then
        '        dgv_planillas.Rows(i).DefaultCellStyle.ForeColor = Color.Red
        '        dgv_planillas.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Red
        '    Else
        '        dgv_planillas.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
        '        dgv_planillas.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Blue
        '    End If
        'Next
        'dgv_planillas.Update()
    End Sub
#End Region

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Call Consultar_Planillas_Cab_xfecha()
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "CAJA_CHICA")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Planilla de Caja Chica.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btn_crear_planilla_Click(sender As Object, e As EventArgs) Handles btn_crear_planilla.Click
        Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST
        Dim planillaBE As New ClsEntidades.RECEIVABLE_CAJA_CHICA
        Dim numero_planilla As String = String.Empty
        Dim correlativo_planilla As String = String.Empty
        Dim fecha_puente As Date, fecha_a_guardar As Date, dtTipoCamb_tc As DataTable, tc_a_guardar As Double, tc_a_guardar_ME As Double
        Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

        dtTipoCamb_tc = Nothing
        dtTipoCamb_tc = cl.Verifircar_Planilla_Caja_chica(dtp_fec_nueva_pla.Value.ToString("dd/MM/yyyy"))
        If dtTipoCamb_tc.Rows.Count() > 0 Then
            MsgBox("Existe una planilla con la fecha elegida, proceda a modificar dicha planilla.", MsgBoxStyle.Critical, "Sistema")
            Exit Sub
        End If

        If Verificar_Apertura_Cierre_Modulos(dtp_fec_nueva_pla.Value.Month, dtp_fec_nueva_pla.Value.Year) = False Then
            Exit Sub
        End If

        'correlativo_planilla = planillaBL.Obtener_correlativo_CajaChica(correlativo_planilla)
        'If CDbl(correlativo_planilla) - 1 > 0 Then
        '    dtTipoCamb_tc = cl.get_Obtener_Saldo_Final(CStr(CDbl(correlativo_planilla) - 1).PadLeft(6, Char.Parse("0")))
        '    If dtTipoCamb_tc.Rows.Count() <> 0 Then
        '        If dtTipoCamb_tc.Rows(0).Item("STATUS") <> "C" And dtTipoCamb_tc.Rows(0).Item("STATUS") <> "R" Then
        '            MsgBox("La planilla anterior no se encuentra cerrado." & Chr(13) & "Realize el cierre respectivo para crear una nueva planilla.", MsgBoxStyle.Critical, "Sistema")
        '            Exit Sub
        '        End If
        '        If CDbl(dtTipoCamb_tc.Rows(0).Item("SALDO_FINAL")) = 0 And dtTipoCamb_tc.Rows(0).Item("STATUS") <> "R" Then
        '            MsgBox("La planilla anterior no se encuentra CONFORME." & Chr(13) & " Realize el proceso de Conformidad para crear una nueva planilla.", MsgBoxStyle.Critical, "Sistema")
        '            Exit Sub
        '        End If
        '    Else
        '        MsgBox("La planilla anterior no se encuentra registrado en el sistema." & Chr(13) & " Verifique que exista en el sistema.", MsgBoxStyle.Critical, "Sistema")
        '        Exit Sub
        '    End If
        'End If

        

        With planillaBE
            .ID = 0
            .DATE_PLA = CDate(dtp_fec_nueva_pla.Value).ToShortDateString
            fecha_puente = dtp_fec_nueva_pla.Text
            fecha_a_guardar = fecha_puente
            cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            dtTipoCamb_tc = cl.get_VerificarTipoCambio(fecha_a_guardar.Year.ToString, fecha_a_guardar.Month.ToString, fecha_a_guardar.Day.ToString)
            If dtTipoCamb_tc.Rows.Count() <> 0 Then
                tc_a_guardar = dtTipoCamb_tc.Rows(0).Item("Tipo_Venta")
            Else
                tc_a_guardar = 0
            End If
            .AMOUNT = 0
            .AMOUNT_US = 0
            .AMOUNT_CH_DIF = 0
            .AMOUNT_CH_DIF_US = 0
            .VOUCHER_ID = 0
            .STATUS = "P"
            .CREATE_DATE = Now.Date.ToShortDateString
            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            .SALES_ID = ""
            .VOUCHER_ID_US = 0
            .SELL_RATE = tc_a_guardar
            .SALDO_INICIAL = 0
            .INGRESOS = 0
            .EGRESOS = 0
            .SALDO_FINAL = 0

            .SALDO_INICIAL_ME = 0
            .INGRESOS_ME = 0
            .EGRESOS_ME = 0
            .SALDO_FINAL_ME = 0

        End With
        planillaBL.InsertCajaChica(planillaBE, True, numero_planilla)
        planillaBE = Nothing
        planillaBL = Nothing
        txt_numero_planilla.Text = numero_planilla
        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

        dtTipoCamb_tc = cl.get_Obtener_Saldo_Final(CStr(CDbl(numero_planilla) - 1).PadLeft(6, Char.Parse("0")))
        If dtTipoCamb_tc.Rows.Count() <> 0 Then
            tc_a_guardar = dtTipoCamb_tc.Rows(0).Item("SALDO_FINAL")
            tc_a_guardar_ME = dtTipoCamb_tc.Rows(0).Item("SALDO_FINAL_ME")
            Dim CONSULTA As String = String.Empty
            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=" & tc_a_guardar & ",SALDO_INICIAL_ME=" & tc_a_guardar_ME & " WHERE ID='" & numero_planilla & "' "
            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            clsReceivablaBl.Ejecuta_consulta(CONSULTA)
        Else
            tc_a_guardar = 0
        End If

        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        Call Consultar_Planillas_Cab_xfecha()
        dtp_fec_nueva_pla.Value = Date.Now
        pnlNuevaPlanilla.Visible = False
        dtp_fec_nueva_pla.Value = Date.Now
        dgv_planillas.Select()
    End Sub

    Private Sub btn_nuevo_det_Click(sender As Object, e As EventArgs) Handles btn_nuevo_det.Click
        _FLAG_EDICION = False
        cmbdocumento.SelectedIndex = -1
        cmbconcepto.SelectedIndex = -1
        cmbpersonal.SelectedIndex = -1
        cmbmovimiento.SelectedIndex = 0
        cmbmoneda.SelectedIndex = 0
        txtserie_documento.Text = ""
        txtnumero_documento.Text = ""
        txtmonto.Text = "0.00"
        txtobservaciones.Text = ""
        cmbdocumento.Focus()
    End Sub
    Private Sub btn_cancelar_crear_Click(sender As Object, e As EventArgs) Handles btn_cancelar_crear.Click
        pnlNuevaPlanilla.Visible = False
        dtp_fec_nueva_pla.Value = Date.Now
        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        dgv_planillas.Select()
    End Sub
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        ' tc_planilla.SelectTab(0)
        Tool_Conforme.Visible = False
        CONTROLES(True, 0)
        btn_consultar.Enabled = True
        btn_Nue_Pla.Enabled = True
        btn_edit_pla.Enabled = True
        btn_elimianr_planilla.Enabled = True
        Tool_Salir.Enabled = True
        Tool_Aperturar.Enabled = True
        ToolStripButton1.Enabled = True
        btn_act_salddos.Enabled = True
    End Sub
    Private Sub btn_Nue_Pla_Click(sender As Object, e As EventArgs) Handles btn_Nue_Pla.Click
        gb_ListaCab.Enabled = False
        dgv_planillas.Enabled = False
        pnlNuevaPlanilla.Visible = True
        dtp_fec_nueva_pla.Focus()
    End Sub
    Private Sub Edicion_Planilla()
        If dgv_planillas.RowCount = 0 Then Exit Sub
        Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
        Dim dt_detalle As DataTable = Nothing
        Dim num_planilla As String = txt_numero_planilla.Text
        dt_detalle = New DataTable
        dtvD = New DataView
        dt_detalle = planillaBL.get_planilla_Det_xID(num_planilla)
        If dt_detalle.Rows.Count() <> 0 Then
            dtvD = dt_detalle.DefaultView
            dgv_detalles.DataSource = dtvD
            dgv_detalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_detalles.Columns(1).Width = 30
            dgv_detalles.Columns(1).HeaderText = "Item"
            dgv_detalles.Columns(2).Width = 85
            dgv_detalles.Columns(2).HeaderText = "Emision"
            dgv_detalles.Columns(3).Width = 45
            dgv_detalles.Columns(3).HeaderText = "TipoDoc"
            dgv_detalles.Columns(4).Width = 90
            dgv_detalles.Columns(4).HeaderText = "NroDocumento"
            dgv_detalles.Columns(6).Width = 300
            dgv_detalles.Columns(6).HeaderText = "Cliente"
            dgv_detalles.Columns(9).Width = 40
            dgv_detalles.Columns(9).HeaderText = "Mon"
            dgv_detalles.Columns(10).Width = 100
            dgv_detalles.Columns(10).HeaderText = "Monto"
            dgv_detalles.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalles.Columns(13).Width = 40
            dgv_detalles.Columns(13).HeaderText = "Codigo"
            dgv_detalles.Columns(14).Width = 200
            dgv_detalles.Columns(14).HeaderText = "Banco"
            dgv_detalles.Columns(15).Width = 100
            dgv_detalles.Columns(15).HeaderText = "NroCuenta"
            dgv_detalles.Columns(16).Width = 100
            dgv_detalles.Columns(16).HeaderText = "Comentario"
            dgv_detalles.Columns(19).HeaderText = "R.u.c"
            dgv_detalles.Columns(19).Width = 100
            dgv_detalles.Columns(19).DisplayIndex = 5
            dgv_detalles.Columns(0).Visible = False
            dgv_detalles.Columns(5).Visible = False
            dgv_detalles.Columns(7).Visible = False
            dgv_detalles.Columns(11).Visible = False
            dgv_detalles.Columns(12).Visible = False
            dgv_detalles.Columns(8).Visible = False
            dgv_detalles.Columns(17).Visible = False
            dgv_detalles.Columns(18).Visible = False

            STRorden = dgv_detalles.Columns(0).Name & "+" & dgv_detalles.Columns(3).Name & "+" & dgv_detalles.Columns(4).Name & "+" & dgv_detalles.Columns(5).Name
        Else
            dgv_detalles.DataSource = Nothing
        End If

    End Sub
    Private Sub Editar_Planilla()
        If dgv_planillas.RowCount = 0 Then Exit Sub
        Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
        Dim dt_detalle As DataTable = Nothing
        Dim num_planilla As String = ""
        Dim num_voucher As String = ""
        FechaActualPlanilla = String.Empty
        _FLAG_CONTA = False
        num_planilla = dgv_planillas.CurrentRow.Cells("PLANILLA").Value.ToString
        If dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString = "APERTURADO" Then
            _FLAG_CONTA = False
        Else
            _FLAG_CONTA = True
        End If

        If dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString = "CERRADO" Then
            Tool_Conforme.Visible = NIVEL_ACCESO()
        Else
            Tool_Conforme.Visible = False
        End If
        ''Fecha de la Planilla
        FechaActualPlanilla = CDate(dgv_planillas.CurrentRow.Cells("FECHA_PLANILLA").Value.ToString).ToString("dd/MM/yyyy")
        txt_numero_planilla.Text = num_planilla
        txt_fecha_planilla.Text = FechaActualPlanilla 'num_voucher

        dt_detalle = New DataTable
        dtvD = New DataView
        dt_detalle = planillaBL.get_planilla_Det_Caja_Chica(num_planilla)
        If dt_detalle.Rows.Count() <> 0 Then
            dtvD = dt_detalle.DefaultView
            tipo_cambio_planilla = CDbl(dt_detalle.Rows(0).Item("SELL_RATE").ToString)
            dgv_detalles.DataSource = dtvD
            'dgv_detalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            CONFIGURAR_GRILLA()
            txtsaldoinicial.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_MN").ToString, Decimal), "##,##00.00")
            txtingresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_MN)", ""), Decimal), "##,##00.00")
            txtegresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_MN)", ""), Decimal), "##,##00.00")
            txtsaldofinal.Text = Format(CType((CDbl(txtsaldoinicial.Text) + CDbl(txtingresos.Text)) - CDbl(txtegresos.Text), Decimal), "##,##00.00")

            txtsaldoinicial_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_ME").ToString, Decimal), "##,##00.00")
            txtingresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_ME)", ""), Decimal), "##,##00.00")
            txtegresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_ME)", ""), Decimal), "##,##00.00")
            txtsaldofinal_ME.Text = Format(CType((CDbl(txtsaldoinicial_ME.Text) + CDbl(txtingresos_ME.Text)) - CDbl(txtegresos_ME.Text), Decimal), "##,##00.00")
            
        Else
            dgv_detalles.DataSource = Nothing
            txtsaldoinicial.Text = Format(CType(dgv_planillas.CurrentRow.Cells("SALDO_INICIAL_MN").Value.ToString, Decimal), "##,##00.00")
            txtingresos.Text = Format(CType(dgv_planillas.CurrentRow.Cells("INGRESOS_MN").Value.ToString, Decimal), "##,##00.00")
            txtegresos.Text = Format(CType(dgv_planillas.CurrentRow.Cells("EGRESOS_MN").Value.ToString, Decimal), "##,##00.00")
            txtsaldofinal.Text = Format(CType((CDbl(txtsaldoinicial.Text) + CDbl(txtingresos.Text)) - CDbl(txtegresos.Text), Decimal), "##,##00.00")

            txtsaldoinicial_ME.Text = Format(CType(dgv_planillas.CurrentRow.Cells("SALDO_INICIAL_ME").Value.ToString, Decimal), "##,##00.00")
            txtingresos_ME.Text = Format(CType(dgv_planillas.CurrentRow.Cells("INGRESOS_ME").Value.ToString, Decimal), "##,##00.00")
            txtegresos_ME.Text = Format(CType(dgv_planillas.CurrentRow.Cells("EGRESOS_ME").Value.ToString, Decimal), "##,##00.00")
            txtsaldofinal_ME.Text = Format(CType((CDbl(txtsaldoinicial_ME.Text) + CDbl(txtingresos_ME.Text)) - CDbl(txtegresos_ME.Text), Decimal), "##,##00.00")
        End If
    End Sub

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
        If txt_numero_planilla.Text = String.Empty Then Exit Sub
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            _ITEM_DETALLE = dgv_detalles.CurrentRow.Cells("ITEM").Value.ToString
            planilladetBL.Eliminar_CajaChica_Det(Format(_ITEM_DETALLE, "000"), txt_numero_planilla.Text)

            MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dtvD = New DataView
            dt_detalle = planillaBL.get_planilla_Det_Caja_Chica(txt_numero_planilla.Text)
            If dt_detalle.Rows.Count() <> 0 Then
                dtvD = dt_detalle.DefaultView
                dgv_detalles.DataSource = dtvD
                CONFIGURAR_GRILLA()
                txtsaldoinicial.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_MN").ToString, Decimal), "##,##00.00")
                txtingresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_MN)", ""), Decimal), "##,##00.00")
                txtegresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_MN)", ""), Decimal), "##,##00.00")
                txtsaldofinal.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_MN").ToString, Decimal), "##,##00.00")

                txtsaldoinicial_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_ME").ToString, Decimal), "##,##00.00")
                txtingresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_ME)", ""), Decimal), "##,##00.00")
                txtegresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_ME)", ""), Decimal), "##,##00.00")
                txtsaldofinal_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_ME").ToString, Decimal), "##,##00.00")
            Else
                dgv_detalles.DataSource = Nothing
                'txtsaldoinicial.Text = "0.0"
                txtingresos.Text = "0.0"
                txtegresos.Text = "0.0"
                txtsaldofinal.Text = Format(CType((CDbl(txtsaldoinicial.Text) + CDbl(txtingresos.Text)) - CDbl(txtegresos.Text), Decimal), "##,##00.00")

                txtingresos_ME.Text = "0.0"
                txtegresos_ME.Text = "0.0"
                txtsaldofinal_ME.Text = Format(CType((CDbl(txtsaldoinicial_ME.Text) + CDbl(txtingresos_ME.Text)) - CDbl(txtegresos_ME.Text), Decimal), "##,##00.00")
            End If
            btn_nuevo_det_Click(sender, e)
        End If
    End Sub




    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            Dim wbusqueda As String = UCase(txtFiltro.Text)
            Dim myCurrencyManager As CurrencyManager
            myCurrencyManager = CType(Me.BindingContext(dtvC), CurrencyManager)
            Dim INTnewpos As Integer
            dtvC.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            Formating()
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtvC.Count & " registros"
        End If
        
    End Sub

    Private Sub ImprimirVoucher(ByRef _DOCUMENT_ID As String)
        Try
            ''Imprimiendo
            If MessageBox.Show("¿Desea imprimir el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA_ASIENTO")
                Dim SQL As String = String.Empty
                SQL = "SELECT *  FROM DBO.CO_TB_ASIENTO_CAB WHERE AC_IDSUBDIARIO = '03'   AND AC_IDPLANILLA ='" & _DOCUMENT_ID & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    Dim CodAsiento As String = dtImprimir.Rows(0).Item("AC_ID").ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE_CAJA_BANCO")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
        Try
            If dgv_planillas.RowCount() = 0 Then
                MsgBox("No hay documentos para Contabilizar.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If dgv_planillas.CurrentRow Is Nothing Then
                    dgv_planillas.Focus()
                    Exit Sub
                End If
            End If
            _CODIGO_PLANILLA = String.Empty
            _FECHA_PLANILLA = String.Empty
            _CODIGO_PLANILLA = dgv_planillas.Item(0, dgv_planillas.CurrentRow.Index).Value
            _FECHA_PLANILLA = CDate(dgv_planillas.Item(1, dgv_planillas.CurrentRow.Index).Value)
            If String.IsNullOrEmpty(_CODIGO_PLANILLA) Then Exit Sub
            If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim fecha As DateTime = DateTime.Parse(_FECHA_PLANILLA)
                Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
                _NUMERACION = String.Empty
                _NUMERACION = ac.get_Ult_num_voucher("03", fecha.Year, Format(fecha.Month, "00"))
                ac = Nothing
            Else
                Dim codigo As String = String.Empty
                codigo = InputBox("Ingrese numero de asiento")
                If codigo = String.Empty Then
                    MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                codigo = Format(CDate(_FECHA_PLANILLA).Month, "00") & codigo.PadLeft(4, Char.Parse("0"))
                Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                Dim dtcodigo As New DataTable
                dtcodigo = ClsasientoBl.ValidarCodigo("03", codigo, CDate(_FECHA_PLANILLA).Year, CDate(_FECHA_PLANILLA).Month)
                If dtcodigo.Rows.Count() <> 0 Then
                    MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    _NUMERACION = codigo
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim ClsCobranzaBl As New ClsOperaciones.RECEIVABLE_LIST
            If ClsCobranzaBl.Contabilizar_Caja_Cobranzas(_CODIGO_PLANILLA, CDate(_FECHA_PLANILLA), _NUMERACION) = True Then
                btn_consultar_Click(sender, e)
                MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information)
                'ImprimirVoucher(_CODIGO_PLANILLA)
            End If
            dgv_planillas.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub btn_elimianr_planilla_Click(sender As Object, e As EventArgs) Handles btn_elimianr_planilla.Click
        If dgv_planillas.RowCount() = 0 Then Exit Sub
        If dgv_planillas.CurrentRow Is Nothing Then Exit Sub
        If dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString <> "APERTURADO" Then
            MsgBox("La planilla de Caja Chica se encuentra en un estado superior al" & Chr(13) & " de APERTURADO, no procede la eliminación.", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim PlanillaBl As New ClsOperaciones.RECEIVABLE_LIST
            PlanillaBl.Eliminar_CajaChica(dgv_planillas.Item(0, dgv_planillas.CurrentRow.Index).Value)
            MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information)
            btn_consultar_Click(sender, e)
            dgv_planillas.Focus()
        End If
    End Sub
    'Private Sub frm_CX_LT_PlanillaCobs_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    '    If e.Alt AndAlso e.KeyCode = Keys.X Then
    '        If MessageBox.Show("Se va a Cerrar el Formualario" & vbCrLf & "¿Desea continuar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Me.Close()
    '        End If
    '    End If

    'End Sub

    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_planilla_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_planilla.Selecting
        If Not tc_planilla.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_edit_pla_Click(sender As Object, e As EventArgs) Handles btn_edit_pla.Click
        If dgv_planillas.Rows.Count() = 0 Then
            MsgBox("No hay ninguna Planilla para editar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        CONTROLES(True, 1)
        Editar_Planilla()
        btn_nuevo_det.Enabled = Not _FLAG_CONTA

        btn_grabar_det.Enabled = Not _FLAG_CONTA
        btnEliminarRegistro.Enabled = Not _FLAG_CONTA
        Button3.Enabled = Not _FLAG_CONTA
        Button4.Enabled = Not _FLAG_CONTA
        Button5.Enabled = Not _FLAG_CONTA


        Tool_Conforme.Visible = False


        btn_consultar.Enabled = False
        btn_Nue_Pla.Enabled = False
        btn_edit_pla.Enabled = False
        btn_elimianr_planilla.Enabled = False
        Tool_Salir.Enabled = False
        Tool_Aperturar.Enabled = False
        ToolStripButton1.Enabled = False
        btn_act_salddos.Enabled = False

        btn_nuevo_det_Click(sender, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gb_ListaCab.Enabled = False
        dgv_planillas.Enabled = False
        ToolStrip1.Enabled = False
        pnl_reportar_planillas.Visible = True
        dtp_fec_ini_rp.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_fec_fin_rp.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtp_fec_ini_rp.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnl_reportar_planillas.Visible = False
        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        ToolStrip1.Enabled = True
        dgv_planillas.Select()
    End Sub

    Private Sub txtfiltrocliente_TextChanged(sender As Object, e As EventArgs)
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtvcliente), CurrencyManager)
        Dim INTnewpos As Integer
        dtvcliente.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtvC.Count & " registros"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CDate(dtp_fec_ini_rp.Value.ToString("dd/MM/yyyy")) > CDate(dtp_fec_fin_rp.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtp_fec_ini_rp.Focus()
            Exit Sub
        End If
        If chk_todos_conceptos.Checked = False Then
            If txt_cod_concepto.Text = "" Then
                MessageBox.Show("Debe elegir un Concepto de Mov. de Caja Chica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_cod_concepto.Focus()
                Exit Sub
            End If
        End If
        If chk_todos_personal.Checked = False Then
            If txt_cod_personal.Text = "" Then
                MessageBox.Show("Debe elegir un Personal de Mov. de Caja Chica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_cod_personal.Focus()
                Exit Sub
            End If
        End If
        If chk_todos_rendicion.Checked = False Then
            If txt_cod_rendicion.Text = "" Then
                MessageBox.Show("Debe elegir un Estado de Rendición de Caja Chica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_cod_rendicion.Focus()
                Exit Sub
            End If
        End If
        Imprimir_Planillas_Varios(dtp_fec_ini_rp.Value.ToString("dd/MM/yyyy"), dtp_fec_fin_rp.Value.ToString("dd/MM/yyyy"), txt_cod_concepto.Text.Trim, txt_cod_personal.Text.Trim, txt_cod_rendicion.Text.Trim)
    End Sub
    Private Sub Imprimir_Planillas_Varios(ByVal _fecha_inicio As String, ByVal _fecha_fin As String, cod_concepto_ As String, cod_personal_ As String, cod_rendicion_ As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtDatosCompany As DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = New DataTable("Planilla")
            dtImprimir = reporteBL.EjecutarReporte_PLanilla_Varios_CChica(_fecha_inicio, _fecha_fin, cod_concepto_, cod_personal_, cod_rendicion_)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PLA_CAJA_CHICA_VARIOS.rpt", dtImprimir, "", "", "@FECHA_INI;" & _fecha_inicio, "@FECHA_FIN;" & _fecha_fin, "@COD_CONCEPTO;" & cod_concepto_, "@COD_PERSONAL;" & cod_personal_, "@COD_RENDICION;" & cod_rendicion_, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "FECHAS;" & "Desde : " & _fecha_inicio & " Al : " & _fecha_fin)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtserie_documento_Leave(sender As Object, e As EventArgs) Handles txtserie_documento.Leave
        If txtserie_documento.Text.Trim().Length > 0 Then
            txtserie_documento.Text = txtserie_documento.Text.PadLeft(5, Char.Parse("0"))
        End If
    End Sub

    Private Sub txtnumero_documento_Leave(sender As Object, e As EventArgs) Handles txtnumero_documento.Leave
        If txtnumero_documento.Text.Trim().Length > 0 Then
            txtnumero_documento.Text = txtnumero_documento.Text.PadLeft(15, Char.Parse("0"))
        End If
    End Sub

    Private Sub cmbdocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbdocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserie_documento.Focus()
        End If
    End Sub

    Private Sub txtserie_documento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie_documento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumero_documento.Focus()
        End If
    End Sub

    Private Sub txtnumero_documento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumero_documento.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbconcepto.Focus()
        End If
    End Sub

    Private Sub cmbconcepto_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbconcepto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpersonal.Focus()
        End If
    End Sub

    Private Sub cmbpersonal_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbpersonal.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbmovimiento.Focus()
        End If
    End Sub

    Private Sub cmbmovimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmovimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmonto.Select()
        End If
    End Sub

    Private Sub txtmonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbmoneda.Focus()
        End If
    End Sub

    Private Sub cmbmoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_det.Focus()
        End If
    End Sub

    Private Sub txtnumero_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumero_documento.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtserie_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserie_documento.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Function Validar() As Boolean
        If cmbdocumento.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un documento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbdocumento.Focus()
            Return False
            Exit Function
        End If

        If txtserie_documento.Text = "" Then
            MessageBox.Show("Debe ingresar una serie  para el documento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtserie_documento.Focus()
            Return False
            Exit Function
        End If

        If txtnumero_documento.Text = "" Then
            MessageBox.Show("Debe ingresar una número  para el documento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtnumero_documento.Focus()
            Return False
            Exit Function
        End If

        If cmbconcepto.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un concepto.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbconcepto.Focus()
            Return False
            Exit Function
        End If

        If cmbpersonal.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un personal.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbpersonal.Focus()
            Return False
            Exit Function
        End If

        If cmbmovimiento.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un movimiento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbmovimiento.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txtmonto.Text) = 0 Then
            MessageBox.Show("Ingrese un monto del movimiento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtmonto.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txtmonto.Text) < 0 Then
            MessageBox.Show("Ingrese un monto positivo del movimiento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtmonto.Focus()
            Return False
            Exit Function
        End If

        If cmbmoneda.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una moneda.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbmoneda.Focus()
            Return False
            Exit Function
        End If
        If cmbmovimiento.SelectedIndex = 1 Then
            If cmbmoneda.SelectedValue.ToString = "MN" Then
                If CDbl(txtmonto.Text) > CDbl(txtsaldofinal.Text) Then
                    MessageBox.Show("Saldo insuficiente, no puede realizar el movimiento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtmonto.Focus()
                    Return False
                    Exit Function
                End If
            ElseIf cmbmoneda.SelectedValue.ToString = "ME" Then
                If CDbl(txtmonto.Text) > CDbl(txtsaldofinal_ME.Text) Then
                    MessageBox.Show("Saldo insuficiente, no puede realizar el movimiento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtmonto.Focus()
                    Return False
                    Exit Function
                End If
            End If
            
        End If
        
        Return True
    End Function

    Function Validar_Datos_Rendicion() As Boolean
        If cmb_documento_rendicion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un documento de sustento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_documento_rendicion.Focus()
            Return False
            Exit Function
        End If

        If txt_serie_rendicion.Text = "" Then
            MessageBox.Show("Debe ingresar una serie  para el documento de sustento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_serie_rendicion.Focus()
            Return False
            Exit Function
        End If

        If txt_numero_rendicion.Text = "" Then
            MessageBox.Show("Debe ingresar una número  para el documento de sustento.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_numero_rendicion.Focus()
            Return False
            Exit Function
        End If


        Return True
    End Function

    Function Validar_Datos_Rendicion_Varios() As Boolean
        If TextBox4.Text = "" Then
            MessageBox.Show("Debe ingresar un Proveedor valido.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TextBox4.Focus()
            Return False
            Exit Function
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un documento de sustento.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ComboBox1.Focus()
            Return False
            Exit Function
        End If

        If TextBox8.Text = "" Then
            MessageBox.Show("Debe ingresar una serie  para el documento de sustento.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TextBox8.Focus()
            Return False
            Exit Function
        End If

        If TextBox7.Text = "" Then
            MessageBox.Show("Debe ingresar una número  para el documento de sustento.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TextBox7.Focus()
            Return False
            Exit Function
        End If


        If TextBox10.Text = "" Then TextBox10.Text = "0.0"
        If TextBox9.Text = "" Then TextBox9.Text = "0.0"
        If TextBox11.Text = "" Then TextBox11.Text = "0.0"
        If TextBox12.Text = "" Then TextBox12.Text = "0.0"

        Return True
    End Function

    Private Sub btn_grabar_det_Click(sender As Object, e As EventArgs) Handles btn_grabar_det.Click
        Dim estado As Boolean = False
        If Validar() = False Then Exit Sub
        If MessageBox.Show("¿Desea guardar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '______________ Comenzamos a Grabar ____________________________________________

            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim planilladetBE As ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA
            Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA)


            planilladetBE = New ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA

            With planilladetBE
                .ID = txt_numero_planilla.Text.Trim
                .ITEM = Format(_ITEM_DETALLE, "000")
                .TYPE_DOC = cmbdocumento.SelectedValue.ToString
                .NUMBER_DOC = txtserie_documento.Text.Trim + txtnumero_documento.Text.Trim
                .TYPE_OPERATION = cmbconcepto.SelectedValue.ToString
                .REC_ID = ""
                .DATE_PLA = txt_fecha_planilla.Text
                .AMOUNT = 0
                .CURRENCY_ID = cmbmoneda.SelectedValue.ToString
                .SELL_RATE = tipo_cambio_planilla
                .CREATE_DATE = Now.Date.ToShortDateString
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COMMENT = txtobservaciones.Text.Trim
                .SALES_ID = String.Empty
                .BANK_ID = String.Empty
                .BANK_DESCRIPTION = String.Empty
                .DOC_REF = String.Empty
                .NUM_REF = String.Empty
                .BANK_BUSSINESS_ID = String.Empty
                .ACCOUNT_BANK_CHECK = String.Empty
                .IS_CASH_BANK = "0"
                .AMOUNT_PER = 0
                .PAY_AUTO = 0
                .ANNEX_ID_AUX = String.Empty
                .DOCUMET_ID = cmbdocumento.SelectedValue.ToString
                .NUMBER_SERIE = txtserie_documento.Text.Trim
                .NUMBER_DOCUMENT = txtnumero_documento.Text.Trim
                .MEDIOS_PAGO = String.Empty
                .OPT_AN = String.Empty
                .ID_PERSONAL = cmbpersonal.SelectedValue.ToString
                .ID_MOVIMIENTO = cmbmovimiento.Text
                .MONTO_INGRESO = IIf(cmbmovimiento.Text = "Ingreso", CDbl(txtmonto.Text), 0)
                .MONTO_EGRESO = IIf(cmbmovimiento.Text = "Egreso", CDbl(txtmonto.Text), 0)
                .STATUS = "P"
            End With
            ls_detalle.Add(planilladetBE)
            If _FLAG_EDICION = False Then
                planilladetBL.Insert_CajaChica_Det(ls_detalle)
            ElseIf _FLAG_EDICION = True Then
                planilladetBL.Actualizacion_CajaChica_Det(ls_detalle)
            End If

            planilladetBL = Nothing

            'MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dtvD = New DataView
            dt_detalle = planillaBL.get_planilla_Det_Caja_Chica(txt_numero_planilla.Text)
            If dt_detalle.Rows.Count() <> 0 Then
                dtvD = dt_detalle.DefaultView
                dgv_detalles.DataSource = dtvD
                CONFIGURAR_GRILLA()

                txtsaldoinicial.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_MN").ToString, Decimal), "##,##00.00")
                txtingresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_MN)", ""), Decimal), "##,##00.00")
                txtegresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_MN)", ""), Decimal), "##,##00.00")
                txtsaldofinal.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_MN").ToString, Decimal), "##,##00.00")

                txtsaldoinicial_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_ME").ToString, Decimal), "##,##00.00")
                txtingresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_ME)", ""), Decimal), "##,##00.00")
                txtegresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_ME)", ""), Decimal), "##,##00.00")
                txtsaldofinal_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_ME").ToString, Decimal), "##,##00.00")

            Else
                dgv_detalles.DataSource = Nothing
                txtsaldoinicial.Text = "0.0"
                txtingresos.Text = "0.0"
                txtegresos.Text = "0.0"
                txtsaldofinal.Text = "0.0"

                txtsaldoinicial_ME.Text = "0.0"
                txtingresos_ME.Text = "0.0"
                txtegresos_ME.Text = "0.0"
                txtsaldofinal_ME.Text = "0.0"
            End If

            btn_nuevo_det_Click(sender, e)
        End If

    End Sub

    Private Sub dgv_detalles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_detalles.MouseDoubleClick
        If dgv_detalles.RowCount = 0 Then Exit Sub

        If dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString = "CERRADO" Then
            MessageBox.Show("La planilla se encuentra CERRADO, verifique", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("¿Desea modificar el registro N° " & dgv_detalles.CurrentRow.Cells("ITEM").Value.ToString & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _FLAG_EDICION = True
                _ITEM_DETALLE = dgv_detalles.CurrentRow.Cells("ITEM").Value.ToString
                cmbdocumento.SelectedValue = dgv_detalles.CurrentRow.Cells("DOCUMET_ID").Value.ToString
                txtserie_documento.Text = dgv_detalles.CurrentRow.Cells("NUMBER_SERIE").Value.ToString
                txtnumero_documento.Text = dgv_detalles.CurrentRow.Cells("NUMBER_DOCUMENT").Value.ToString
                cmbconcepto.SelectedValue = dgv_detalles.CurrentRow.Cells("ID_MOVIMIENTO").Value.ToString
                cmbpersonal.SelectedValue = dgv_detalles.CurrentRow.Cells("ID_PERSONAL").Value.ToString
                cmbmovimiento.SelectedIndex = IIf(dgv_detalles.CurrentRow.Cells("TIPO_MOVIMIENTO").Value.ToString = "I", 0, 1)
                txtmonto.Text = IIf(dgv_detalles.CurrentRow.Cells("TIPO_MOVIMIENTO").Value.ToString = "I", CDbl(dgv_detalles.CurrentRow.Cells("MONTO_INGRESO").Value.ToString), CDbl(dgv_detalles.CurrentRow.Cells("MONTO_EGRESO").Value.ToString))
                cmbmoneda.SelectedValue = dgv_detalles.CurrentRow.Cells("CURRENCY_ID").Value.ToString
                txtobservaciones.Text = dgv_detalles.CurrentRow.Cells("COMMENT").Value.ToString
                cmbdocumento.Focus()
            End If
        End If

        
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv_detalles.Rows.Count = 0 Then Exit Sub
        For i As Integer = 0 To dgv_detalles.Rows.Count - 1
            If dgv_detalles.Rows(i).Cells("ESTADO").Value = "X RENDIR" Then
                MessageBox.Show("Existen movimientos X RENDIR, verifique", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        If MessageBox.Show("Se va a realizar el cierre de Caja." & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL.Cerrar_CajaChica(txt_numero_planilla.Text)

            MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btn_consultar_Click(sender, e)
            btn_regresar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_imprimir_det_Click(sender As Object, e As EventArgs) Handles btn_imprimir_det.Click
        Try
            If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
            If txt_numero_planilla.Text = String.Empty Then Exit Sub

            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtDatosCompany As DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = New DataTable("CajaChica")
            dtImprimir = reporteBL.Reporte_Caja_Chica(txt_numero_planilla.Text)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PLA_CAJA_CHICA.rpt", "", "", "", "@ID_PLANILLA;" & txt_numero_planilla.Text, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub btn_actualizar_rendicion_Click(sender As Object, e As EventArgs) Handles btn_actualizar_rendicion.Click
        Dim estado As Boolean = False
        If Validar_Datos_Rendicion() = False Then Exit Sub
        If MessageBox.Show("¿Desea actualizar el registro con los Datos de Sustento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '______________ Comenzamos a Grabar ____________________________________________

            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim planilladetBE As ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA
            Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA)


            planilladetBE = New ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA

            With planilladetBE
                .ID = txt_numero_planilla.Text.Trim
                .ITEM = Format(_ITEM_DETALLE, "000")
                .USUARIO_DOC_RENDICION = LibComunVar.ClsVarComun.USUARIO
                .TERMINAL_DOC_RENDICION = Environment.MachineName
                .STATUS = "R"
                .TYPE_DOC_RENDICION = cmb_documento_rendicion.SelectedValue
                .SERIE_DOC_RENDICION = txt_serie_rendicion.Text.Trim
                .NUMERO_DOC_RENDICION = txt_numero_rendicion.Text.Trim
                .FECHA_DOC_RENDICION = dtp_fecha_rendicion.Value.ToString("dd/MM/yyyy")
                .OBS_DOC_RENDICION = txt_obs_rendicion.Text.Trim
                .COD_PROV_RENDICION = txtproveedor.Text.Trim
            End With
            ls_detalle.Add(planilladetBE)
            planilladetBL.Actualizacion_CajaChica_Rendicion(ls_detalle)


            planilladetBL = Nothing

            MessageBox.Show("Actualización Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dtvD = New DataView
            dt_detalle = planillaBL.get_planilla_Det_Caja_Chica(txt_numero_planilla.Text)
            If dt_detalle.Rows.Count() <> 0 Then
                dtvD = dt_detalle.DefaultView
                dgv_detalles.DataSource = dtvD
                CONFIGURAR_GRILLA()
                txtsaldoinicial.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_MN").ToString, Decimal), "##,##00.00")
                txtingresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_MN)", ""), Decimal), "##,##00.00")
                txtegresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_MN)", ""), Decimal), "##,##00.00")
                txtsaldofinal.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_MN").ToString, Decimal), "##,##00.00")

                txtsaldoinicial_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_ME").ToString, Decimal), "##,##00.00")
                txtingresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_ME)", ""), Decimal), "##,##00.00")
                txtegresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_ME)", ""), Decimal), "##,##00.00")
                txtsaldofinal_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_ME").ToString, Decimal), "##,##00.00")
            Else
                dgv_detalles.DataSource = Nothing
                txtsaldoinicial.Text = "0.0"
                txtingresos.Text = "0.0"
                txtegresos.Text = "0.0"
                txtsaldofinal.Text = "0.0"

                txtsaldoinicial_ME.Text = "0.0"
                txtingresos_ME.Text = "0.0"
                txtegresos_ME.Text = "0.0"
                txtsaldofinal_ME.Text = "0.0"
            End If

            btn_cancelar_rendicion_Click(sender, e)
            End If
    End Sub

    Private Sub CONFIGURAR_GRILLA()
        If dgv_detalles.Rows.Count > 0 Then
            dgv_detalles.Columns(0).Visible = False
            dgv_detalles.Columns(1).HeaderText = "Item"
            dgv_detalles.Columns(2).HeaderText = "T.D."
            dgv_detalles.Columns(3).HeaderText = "Ser. Doc."
            dgv_detalles.Columns(4).HeaderText = "N° Doc."
            dgv_detalles.Columns(5).HeaderText = "Observacion"
            dgv_detalles.Columns(6).HeaderText = "Mon."
            dgv_detalles.Columns(7).HeaderText = "Ingresos"
            dgv_detalles.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalles.Columns(8).HeaderText = "Egresos"
            dgv_detalles.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalles.Columns(9).Visible = False
            dgv_detalles.Columns(10).Visible = False
            dgv_detalles.Columns(11).Visible = False
            dgv_detalles.Columns(12).Visible = False
            dgv_detalles.Columns(13).HeaderText = "Personal"
            dgv_detalles.Columns(14).Visible = False
            dgv_detalles.Columns(15).Visible = True
            dgv_detalles.Columns(15).HeaderText = "Concepto"
            dgv_detalles.Columns(16).Visible = False

            dgv_detalles.Columns(17).Visible = False '.HeaderText = "T.D.Rend."
            dgv_detalles.Columns(18).Visible = False '.HeaderText = "N° Doc. Rend."
            dgv_detalles.Columns(19).Visible = False '.HeaderText = "Fecha Doc. Rend."
            dgv_detalles.Columns(20).Visible = False '.HeaderText = "Cod. Proveedor"
            dgv_detalles.Columns(21).Visible = False '.HeaderText = "Proveedor"
            dgv_detalles.Columns(22).HeaderText = "Estado"

            dgv_detalles.Columns(23).Visible = False
            dgv_detalles.Columns(24).Visible = False
            dgv_detalles.Columns(25).Visible = False
            dgv_detalles.Columns(26).Visible = False

            dgv_detalles.Columns(27).Visible = False
            dgv_detalles.Columns(28).Visible = False
            dgv_detalles.Columns(29).Visible = False
            dgv_detalles.Columns(30).Visible = False

            dgv_detalles.AutoResizeColumns()
            dgv_detalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
        
    End Sub

    Private Sub txt_serie_rendicion_Leave(sender As Object, e As EventArgs) Handles txt_serie_rendicion.Leave
        If txt_serie_rendicion.Text.Trim().Length > 0 Then
            txt_serie_rendicion.Text = txt_serie_rendicion.Text.PadLeft(5, Char.Parse("0"))
        End If
    End Sub

    Private Sub txt_serie_rendicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_serie_rendicion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_serie_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_serie_rendicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_numero_rendicion.Focus()
        End If
    End Sub

    Private Sub txt_numero_rendicion_Leave(sender As Object, e As EventArgs) Handles txt_numero_rendicion.Leave
        If txt_numero_rendicion.Text.Trim().Length > 0 Then
            txt_numero_rendicion.Text = txt_numero_rendicion.Text.PadLeft(15, Char.Parse("0"))
        End If
    End Sub

    Private Sub txt_numero_rendicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_rendicion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numero_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_rendicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fecha_rendicion.Focus()
        End If
    End Sub

    Private Sub cmb_documento_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_documento_rendicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_serie_rendicion.Focus()
        End If
    End Sub

    Private Sub dtp_fecha_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_rendicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs_rendicion.Focus()
        End If
    End Sub

    Private Sub txt_obs_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obs_rendicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_actualizar_rendicion.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
        If txt_numero_planilla.Text = String.Empty Then Exit Sub

        If dgv_detalles.CurrentRow.Cells("ESTADO").Value.ToString = "RENDIDO" Then
            MessageBox.Show("El registro se encuentra en el estado RENDIDO," & Chr(13) & " no procede la actualización.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If dgv_detalles.CurrentRow.Cells("ESTADO").Value.ToString = "X RENDIR" Then
            opt_rendicion = "individual"
            _ITEM_DETALLE = dgv_detalles.CurrentRow.Cells("ITEM").Value.ToString
            GroupBox4.Enabled = False
            dgv_detalles.Enabled = False
            ToolStrip1.Enabled = False
            Call Limpiar_GroupBox(GroupBox1)
            cmb_documento_rendicion.SelectedIndex = -1
            pnl_rendicion.Visible = True
            cmb_documento_rendicion.Focus()
        End If
        
    End Sub

    Private Sub btn_cancelar_rendicion_Click(sender As Object, e As EventArgs) Handles btn_cancelar_rendicion.Click
        GroupBox4.Enabled = True
        dgv_detalles.Enabled = True
        ToolStrip1.Enabled = True
        pnl_rendicion.Visible = False
    End Sub

    Private Sub dgv_detalles_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_detalles.CellFormatting
        If dgv_detalles.Rows(e.RowIndex).Cells("ESTADO").Value = "X RENDIR" Then
            dgv_detalles.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgv_detalles.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgv_detalles.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalles.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub cmbpersonal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbpersonal.SelectedValueChanged
        If _inicio = "no" Then
            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dtvD = New DataView
            dt_detalle = planillaBL.get_validar_personal_pendiente_a_rendir(cmbpersonal.SelectedValue)
            If dt_detalle.Rows.Count() <> 0 Then
                MessageBox.Show("El personal elegido tiene documentos," & Chr(13) & " pendientes por rendir.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        
    End Sub

    Private Sub Tool_Conforme_Click(sender As Object, e As EventArgs) Handles Tool_Conforme.Click
        Dim dtTipoCamb_tc As DataTable
        Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

        For i As Integer = 0 To dgv_detalles.Rows.Count - 1
            If dgv_detalles.Rows(i).Cells("ESTADO").Value = "X RENDIR" Then
                MessageBox.Show("Existen movimientos X RENDIR, verifique", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        If CDbl(txt_numero_planilla.Text) - 1 > 0 Then
            dtTipoCamb_tc = cl.get_Obtener_Saldo_Final(CStr(CDbl(txt_numero_planilla.Text) - 1).PadLeft(6, Char.Parse("0")))
            If dtTipoCamb_tc.Rows.Count() <> 0 Then
                If dtTipoCamb_tc.Rows(0).Item("STATUS") <> "R" Then
                    MsgBox("La planilla anterior no se encuentra CONFORME." & Chr(13) & "Realize el proceso de Conformidad respectivo para realizar el proceso.", MsgBoxStyle.Critical, "Sistema")
                    Exit Sub
                End If
            Else
                MsgBox("La planilla anterior no se encuentra registrado en el sistema." & Chr(13) & " Verifique que exista en el sistema.", MsgBoxStyle.Critical, "Sistema")
                Exit Sub
            End If
        End If
        If MessageBox.Show("Se va a realizar la Conformidad de Caja Chica." & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL.Conformidad_CajaChica(txt_numero_planilla.Text)

            MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btn_consultar_Click(sender, e)
            btn_regresar_Click(sender, e)
        End If
    End Sub

    Private Sub txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_det.Focus()
        End If
    End Sub

    Private Sub dgv_planillas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_planillas.CellFormatting
        If dgv_planillas.Rows(e.RowIndex).Cells("FLAG_CONTA").Value <> "CERRADO" Then
            dgv_planillas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgv_planillas.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgv_planillas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_planillas.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub btnprovnuevo_Click(sender As Object, e As EventArgs) Handles btnprovnuevo.Click
        panel_estado_cuenta.Visible = True
        pnl_rendicion.Enabled = False
        txt_ruc_prov_nuevo.Text = String.Empty
        txt_razon_social_prov_nuevo.Text = String.Empty
        Call Cargar_TipoDoc()
        txt_ruc_prov_nuevo.Focus()
    End Sub

    Private Sub txt_ruc_prov_nuevo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc_prov_nuevo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Consultando_Ruc() Then
                txt_razon_social_prov_nuevo.Focus()
            End If
        End If
    End Sub
    Private Function Consultando_Ruc() As Boolean
        Try
            Dim clienteBl As ClsOperaciones.CUSTOMER
            Dim dt_ruc As New DataTable
            clienteBl = New ClsOperaciones.CUSTOMER
            dt_ruc = clienteBl.Validacion_Ruc_Proveedor(txt_ruc_prov_nuevo.Text)
            If dt_ruc.Rows.Count() = 0 Then
                Return True
            Else
                MsgBox("El número del documento ingresado ya existe en la base de datos." & Chr(13) & " Ingrese uno correcto.", MsgBoxStyle.Critical, "Sistemas")
                Return False
                txt_ruc_prov_nuevo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txt_ruc_prov_nuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc_prov_nuevo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_razon_social_prov_nuevo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_razon_social_prov_nuevo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ap_paterno.Select()
        End If
    End Sub

    Private Sub btn_cancel_nuevo_prov_Click(sender As Object, e As EventArgs) Handles btn_cancel_nuevo_prov.Click
        If opt_rendicion = "individual" Then
            panel_estado_cuenta.Visible = False
            pnl_rendicion.Enabled = True
        ElseIf opt_rendicion = "varios" Then
            panel_estado_cuenta.Visible = False
            Panel2.Visible = True
            Panel2.Enabled = True
        End If
        
    End Sub

    Private Sub btn_nuevo_prov_Click(sender As Object, e As EventArgs) Handles btn_nuevo_prov.Click
        Try
            If cmb_td.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Tipo de documento.", MsgBoxStyle.Critical, "Sistemas")
                cmb_td.Focus()
                Exit Sub
            End If
            If Consultando_Ruc() = False Then
                MsgBox("El número del documento ingresado ya existe en la base de datos." & Chr(13) & " Ingrese uno correcto.", MsgBoxStyle.Critical, "Sistemas")
                Exit Sub
            End If
            If txt_ruc_prov_nuevo.Text = String.Empty Then
                MsgBox("Debe ingresar un número de Documento.", MsgBoxStyle.Critical)
                txt_ruc_prov_nuevo.Focus()
                Exit Sub
            End If
            If cmb_td.SelectedValue = "01" Then 'si es DNi
                If Len(txt_ruc_prov_nuevo.Text) <> 8 Then
                    MsgBox("El numero de DNI del Proveedor debe tener 8 digitos.", MsgBoxStyle.Exclamation)
                    txt_ruc_prov_nuevo.Focus()
                    Exit Sub
                ElseIf txt_razon_social_prov_nuevo.Text = String.Empty Then
                    MsgBox("Debe ingresar la Razón Social del Proveedor.", MsgBoxStyle.Exclamation)
                    txt_razon_social_prov_nuevo.Focus()
                    Exit Sub
                ElseIf txt_ap_paterno.Text = String.Empty Then
                    MsgBox("Debe ingresar el Apellido Paterno del Proveedor.", MsgBoxStyle.Exclamation)
                    txt_ap_paterno.Focus()
                    Exit Sub
                ElseIf txt_ap_materno.Text = String.Empty Then
                    MsgBox("Debe ingresar el Apellido Materno del Proveedor.", MsgBoxStyle.Exclamation)
                    txt_ap_materno.Focus()
                    Exit Sub
                ElseIf txt_pri_nombre.Text = String.Empty Then
                    MsgBox("Debe ingresar el Primer Nombre del Proveedor.", MsgBoxStyle.Exclamation)
                    txt_pri_nombre.Focus()
                    Exit Sub
                End If

            Else 'If cmb_td.SelectedValue = "06" Then 'si es RUC
                If Len(txt_ruc_prov_nuevo.Text) <> 11 Then
                    MsgBox("El numero de RUC del Proveedor debe tener 11 digitos.", MsgBoxStyle.Exclamation)
                    txt_ruc_prov_nuevo.Focus()
                    Exit Sub
                ElseIf txt_razon_social_prov_nuevo.Text = String.Empty Then
                    MsgBox("Debe ingresar la Razón Social del Proveedor.", MsgBoxStyle.Exclamation)
                    txt_razon_social_prov_nuevo.Focus()
                    Exit Sub
                End If
            End If

            If cmb_tc.SelectedValue = "01" Or cmb_tc.SelectedValue = "02" Then
                If txt_ap_paterno.Text.Trim = "" Then
                    MsgBox("Debe ingresar el Apellido Paterno.", MsgBoxStyle.Critical, "Sistemas")
                    txt_ap_paterno.Focus()
                    Exit Sub
                End If
                If txt_ap_materno.Text.Trim = "" Then
                    MsgBox("Debe ingresar el Apellido Materno.", MsgBoxStyle.Critical, "Sistemas")
                    txt_ap_materno.Focus()
                    Exit Sub
                End If
                If txt_pri_nombre.Text.Trim = "" Then
                    MsgBox("Debe ingresar el Primer Nombre.", MsgBoxStyle.Critical, "Sistemas")
                    txt_pri_nombre.Focus()
                    Exit Sub
                End If
            End If


            Me.Cursor = Cursors.WaitCursor
            Dim CONSULTA As String = String.Empty
            CONSULTA = "INSERT INTO dbo.VENDOR (ID, NAME, VAT_REGISTRATION, STATUS, CREATE_DATE, CREATE_USER,DOCUMENT_TYPE_PERSON_ID,AP_PATERNO, AP_MATERNO, PRIMER_NOMBRE, SEGUNDO_NOMBRE,TYPE_COMPANY) " _
                    & " VALUES ('" & txt_ruc_prov_nuevo.Text.Trim & "', '" & txt_razon_social_prov_nuevo.Text.Trim & "', '" & txt_ruc_prov_nuevo.Text.Trim & "', 'V', getdate(),'" & LibComunVar.ClsVarComun.USUARIO & "','" & cmb_td.SelectedValue & "','" & txt_ap_paterno.Text.Trim & "','" & txt_ap_materno.Text.Trim & "','" & txt_pri_nombre.Text.Trim & "','" & txt_seg_nombre.Text.Trim & "','" & cmb_tc.SelectedValue & "') "

            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                Dim sql As String = String.Empty
                sql = " DELETE FROM dbo.ANNEXED WHERE ID='" & txt_ruc_prov_nuevo.Text.Trim & "' AND TYPE='2' "
                If clsReceivablaBl.Ejecuta_consulta(sql) Then
                    sql = " INSERT INTO dbo.ANNEXED (ID, TYPE, VAT_REGISTRATION, NAME, REFERENCE,BUSINESS,AP_PATERNO, AP_MATERNO, PRIMER_NOMBRE, SEGUNDO_NOMBRE) VALUES ( '" & txt_ruc_prov_nuevo.Text.Trim & "', '2', '" & txt_ruc_prov_nuevo.Text.Trim & "', '" & txt_razon_social_prov_nuevo.Text.Trim & "', 'A','" & CInt(cmb_td.SelectedValue) & "','" & txt_ap_paterno.Text.Trim & "','" & txt_ap_materno.Text.Trim & "','" & txt_pri_nombre.Text.Trim & "','" & txt_seg_nombre.Text.Trim & "')"
                    If clsReceivablaBl.Ejecuta_consulta(sql) = False Then
                        MsgBox("No se pudo registrar el Proveedor en los Anexos de Contabilidad.", MsgBoxStyle.Critical)
                    End If
                Else
                    'MsgBox("No se pudo eliminar el Proveedor en los Anexos de Contabilidad.", MsgBoxStyle.Critical)
                    sql = " INSERT INTO dbo.ANNEXED (ID, TYPE, VAT_REGISTRATION, NAME, REFERENCE,BUSINESS,AP_PATERNO, AP_MATERNO, PRIMER_NOMBRE, SEGUNDO_NOMBRE) VALUES ( '" & txt_ruc_prov_nuevo.Text.Trim & "', '2', '" & txt_ruc_prov_nuevo.Text.Trim & "', '" & txt_razon_social_prov_nuevo.Text.Trim & "', 'A','" & CInt(cmb_td.SelectedValue) & "','" & txt_ap_paterno.Text.Trim & "','" & txt_ap_materno.Text.Trim & "','" & txt_pri_nombre.Text.Trim & "','" & txt_seg_nombre.Text.Trim & "')"
                    If clsReceivablaBl.Ejecuta_consulta(sql) = False Then
                        MsgBox("No se pudo registrar el Proveedor en los Anexos de Contabilidad.", MsgBoxStyle.Critical)
                    End If
                End If

                If opt_rendicion = "individual" Then
                    Ayuda_Proveedor(txt_ruc_prov_nuevo.Text.Trim)
                    btn_cancel_nuevo_prov_Click(sender, e)
                ElseIf opt_rendicion = "varios" Then
                    Ayuda_Proveedor_Varios(txt_ruc_prov_nuevo.Text.Trim)
                    btn_cancel_nuevo_prov_Click(sender, e)
                End If

            Else
                MsgBox("Proveedor no se llego a registrar.", MsgBoxStyle.Critical)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Ayuda_Proveedor(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PUR_SP_S_PROVEEDORES"
                frm.CadenaConsulta = sql
                frm.Titulo = "Proveedores"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtproveedor_desc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    cmb_documento_rendicion.Focus()
                End If
                frm.Close()
            Else
                Dim dtDetalleFact As DataTable
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualProveedor(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtproveedor.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtproveedor_desc.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    cmb_documento_rendicion.Focus()
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtproveedor.Text = String.Empty
                    txtproveedor_desc.Text = String.Empty
                    txtproveedor.Focus()
                    Exit Sub
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Proveedor_Varios(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PUR_SP_S_PROVEEDORES"
                frm.CadenaConsulta = sql
                frm.Titulo = "Proveedores"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    TextBox4.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    TextBox3.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    ComboBox1.Focus()
                End If
                frm.Close()
            Else
                Dim dtDetalleFact As DataTable
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualProveedor(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    TextBox4.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    TextBox3.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    ComboBox1.Focus()
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    TextBox4.Text = String.Empty
                    TextBox3.Text = String.Empty
                    TextBox4.Focus()
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtproveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtproveedor.MouseDoubleClick
        Ayuda_Proveedor()
    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor()
        End If
    End Sub

    Private Sub Tool_Aperturar_Click(sender As Object, e As EventArgs) Handles Tool_Aperturar.Click
        If dgv_planillas.Rows.Count = 0 Then Exit Sub
        If dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString = "APERTURADO" Then
            MessageBox.Show("No se puede APERTURAR la planilla" & Chr(13) & "por encontrarse en el mismo estado. Verifique!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Se va a realizar la Apertura de la Planilla de Caja Chica." & vbCrLf & "¿Desea continuar?", "Aperturar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL.Aperturar_CajaChica(dgv_planillas.CurrentRow.Cells("PLANILLA").Value.ToString)

            MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btn_consultar_Click(sender, e)
            'btn_regresar_Click(sender, e)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        
        If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
        If txt_numero_planilla.Text = String.Empty Then Exit Sub

        opt_rendicion = "varios"
        _ITEM_DETALLE = dgv_detalles.CurrentRow.Cells("ITEM").Value.ToString
        GenerarColummnaDataTable_Rendicion_Varios()
        Cargar_Rendicion_Varios(txt_numero_planilla.Text, Format(_ITEM_DETALLE, "000"))
        GroupBox4.Enabled = False
        dgv_detalles.Enabled = False
        ToolStrip1.Enabled = False
        Call Limpiar_GroupBox(GroupBox5)

        TextBox10.Text = "0.0"
        TextBox9.Text = "0.0"
        TextBox11.Text = "0.0"
        TextBox12.Text = "0.0"

        CheckBox1.Checked = True
        DateTimePicker1.Value = Date.Now
        ComboBox1.SelectedIndex = -1
        Panel2.Visible = True
        ESTADO_MODIF_DETALLE_RENDICION = False
        TextBox4.Focus()
        ' End If

    End Sub

    Public Sub GenerarColummnaDataTable_Rendicion_Varios()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ID_CAJA_CHICA", Type.GetType("System.String")) '1
        dtdetalleArticuloPrincipal.Columns.Add("ITEM_CAJA_CHICA", Type.GetType("System.String")) '0
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '2
        dtdetalleArticuloPrincipal.Columns.Add("TIPO_DOC", Type.GetType("System.String")) '3
        dtdetalleArticuloPrincipal.Columns.Add("SERIE", Type.GetType("System.String")) '4
        dtdetalleArticuloPrincipal.Columns.Add("NUMERO_DOC", Type.GetType("System.String")) '5
        dtdetalleArticuloPrincipal.Columns.Add("FECHA_DOC", Type.GetType("System.String")) '6
        dtdetalleArticuloPrincipal.Columns.Add("VENDOR_ID", Type.GetType("System.String")) '7
        dtdetalleArticuloPrincipal.Columns.Add("VENDOR", Type.GetType("System.String")) '8
        dtdetalleArticuloPrincipal.Columns.Add("OBS", Type.GetType("System.String")) '9

        dtdetalleArticuloPrincipal.Columns.Add("VVA", Type.GetType("System.Double")) '10
        dtdetalleArticuloPrincipal.Columns.Add("VVI", Type.GetType("System.Double")) '11
        dtdetalleArticuloPrincipal.Columns.Add("IGV", Type.GetType("System.Double")) '12
        dtdetalleArticuloPrincipal.Columns.Add("TOTAL", Type.GetType("System.Double")) '13
        dtdetalleArticuloPrincipal.Columns.Add("RC", Type.GetType("System.String")) '14

        dgvDetalle.DataSource = Nothing
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal

        dgvDetalle.Columns(2).HeaderText = "Item"
        dgvDetalle.Columns(3).HeaderText = "T. Doc."
        dgvDetalle.Columns(4).HeaderText = "Serie Doc."
        dgvDetalle.Columns(5).HeaderText = "N° Doc."
        dgvDetalle.Columns(6).HeaderText = "Fecha Doc."
        dgvDetalle.Columns(7).HeaderText = "Cod. Proveedor"
        dgvDetalle.Columns(8).HeaderText = "Proveedor"
        dgvDetalle.Columns(9).HeaderText = "Observación"

        dgvDetalle.Columns(10).HeaderText = "Val. Ven. Afecta"
        dgvDetalle.Columns(11).HeaderText = "Val. Ven. Inafecta"
        dgvDetalle.Columns(12).HeaderText = "I. G. V."
        dgvDetalle.Columns(13).HeaderText = "Total"
        dgvDetalle.Columns(14).HeaderText = "Reg. en Compras"

        dgvDetalle.Columns(0).Visible = False
        dgvDetalle.Columns(1).Visible = False
        
        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Cargar_Rendicion_Varios(ByVal _codigo_caja_chica As String, ByVal _codigo_item As String)
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        Dim CADENA As String
        CADENA = "SELECT ID_CAJA_CHICA, ITEM_CAJA_CHICA, ITEM, TIPO_DOC,SERIE, NUMERO_DOC,CONVERT(VARCHAR,FECHA_DOC,103) FECHA_DOC, VENDOR_ID, VENDOR, OBS, VVA, VVI, IGV, TOTAL, RC    "
        CADENA = CADENA & " FROM dbo.RECEIVABLE_LINE_CAJA_CHICA_RENDICION_VARIOS WHERE ID_CAJA_CHICA='" & _codigo_caja_chica & "' AND ITEM_CAJA_CHICA='" & _codigo_item & "' ORDER BY CONVERT(INT,ITEM)  "


        dtdetalleArticuloPrincipal = tipoDocBL.get_Direc_entrega(CADENA)
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
        tipoDocBL = Nothing
    End Sub

    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseDoubleClick
        Ayuda_Proveedor_Varios()
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor_Varios()
        End If
        If e.KeyCode = Keys.Enter Then
            If TextBox4.Text = "" Then
                Ayuda_Proveedor_Varios()
            Else
                ComboBox1.Focus()
            End If

        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox8.Focus()
        End If
    End Sub

    
    Private Sub TextBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox10.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Select()
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Call Limpiar_GroupBox(GroupBox5)
        TextBox10.Text = "0.0"
        TextBox9.Text = "0.0"
        TextBox11.Text = "0.0"
        TextBox12.Text = "0.0"
        CheckBox1.Checked = True
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now
        ESTADO_MODIF_DETALLE_RENDICION = False
        TextBox4.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        panel_estado_cuenta.Visible = True
        Panel2.Visible = False
        Panel2.Enabled = False
        txt_ruc_prov_nuevo.Text = String.Empty
        txt_razon_social_prov_nuevo.Text = String.Empty
        Call Cargar_TipoDoc()
        txt_ruc_prov_nuevo.Focus()
    End Sub
    Private Sub Cargar_TipoDoc()
        Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New ClsOperaciones.DOCUMENT_TYPE
        cmb_td.DataSource = documentosBL.get_Tipo_Doc_Prov()
        cmb_td.ValueMember = "DOCUMENT_TYPE_ID"
        cmb_td.DisplayMember = "DESCRIPTION"
        documentosBL = Nothing

    End Sub

    Private Sub Cargar_TipoCompania()
        Dim companiaBL As New ClsOperaciones.COMPANY_TYPE
        cmb_tc.DataSource = companiaBL.get_TiposCompanis()
        cmb_tc.DisplayMember = "DESCRIPTION"
        cmb_tc.ValueMember = "COMPANY_TYPE_ID"
        companiaBL = Nothing
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle.RowCount = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If dgvDetalle.CurrentRow.Cells("RC").Value = "SIR" Then
            MsgBox("No se puede eliminar el item, por estar registrado en Compras.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If MsgBox("Seguro de eliminar el item elegido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Dim CONSULTA As String = String.Empty
            Dim clienteBL As ClsOperaciones.CUSTOMER
            CONSULTA = "DELETE dbo.RECEIVABLE_LINE_CAJA_CHICA_RENDICION_VARIOS WHERE ID_CAJA_CHICA='" & txt_numero_planilla.Text.Trim & "' AND ITEM_CAJA_CHICA='" & Format(_ITEM_DETALLE, "000") & "' and ITEM='" & dgvDetalle.CurrentRow.Cells("ITEM").Value & "' "

            clienteBL = New ClsOperaciones.CUSTOMER
            If clienteBL.Ejecuta_consulta(CONSULTA) Then
                'MsgBox("Eliminado exitosamente.", MsgBoxStyle.Information)
                Call Limpiar_GroupBox(GroupBox5)
                ComboBox1.SelectedIndex = -1
                DateTimePicker1.Value = Date.Now

                Cargar_Rendicion_Varios(txt_numero_planilla.Text, Format(_ITEM_DETALLE, "000"))
                ESTADO_MODIF_DETALLE_RENDICION = False
                TextBox4.Focus()
            Else
                MsgBox("El item elegido no se llego a eliminar.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If Validar_Datos_Rendicion_Varios() = False Then Exit Sub

        Dim CONSULTA As String = String.Empty
        Dim clienteBL As ClsOperaciones.CUSTOMER

        'CONSULTA = "INSERT INTO dbo.RECEIVABLE_LINE_CAJA_CHICA_RENDICION_VARIOS(ID_CAJA_CHICA, ITEM_CAJA_CHICA, ITEM, TIPO_DOC, NUMERO_DOC,FECHA_DOC, VENDOR_ID, VENDOR, OBS , CREATE_USER, CREATE_DATE, VVA, VVI, IGV, TOTAL, RC, SERIE)" _
        '        & " VALUES('" & txt_numero_planilla.Text & "','" & Format(_ITEM_DETALLE, "000") & "','" & Format(dtdetalleArticuloPrincipal.Rows.Count + 1, "000") & "','" & ComboBox1.SelectedValue & "','" & TextBox7.Text.Trim & "','" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "','" & TextBox4.Text.Trim & "','" & TextBox3.Text.Trim & "','" & TextBox5.Text.Trim & "','" & LibComunVar.ClsVarComun.USUARIO & "',getdate()," & CDbl(TextBox10.Text) & "," & CDbl(TextBox9.Text) & "," & CDbl(TextBox11.Text) & "," & CDbl(TextBox12.Text) & ",'" & IIf(CheckBox1.Checked, "SI", "NO") & "','" & TextBox8.Text.Trim & "') "

        If ESTADO_MODIF_DETALLE_RENDICION = False Then
            CONSULTA = "INSERT INTO dbo.RECEIVABLE_LINE_CAJA_CHICA_RENDICION_VARIOS(ID_CAJA_CHICA, ITEM_CAJA_CHICA, ITEM, TIPO_DOC, NUMERO_DOC,FECHA_DOC, VENDOR_ID, VENDOR, OBS , CREATE_USER, CREATE_DATE, VVA, VVI, IGV, TOTAL, RC, SERIE)" _
                & " VALUES('" & txt_numero_planilla.Text & "','" & Format(_ITEM_DETALLE, "000") & "','" & Format(dtdetalleArticuloPrincipal.Rows.Count + 1, "000") & "','" & ComboBox1.SelectedValue & "','" & TextBox7.Text.Trim & "','" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "','" & TextBox4.Text.Trim & "','" & TextBox3.Text.Trim & "','" & TextBox5.Text.Trim & "','" & LibComunVar.ClsVarComun.USUARIO & "',getdate()," & IIf(TextBox10.Text.Trim = "", 0, CDbl(TextBox10.Text)) & "," & IIf(TextBox9.Text.Trim = "", 0, CDbl(TextBox9.Text)) & "," & IIf(TextBox11.Text.Trim = "", 0, CDbl(TextBox11.Text)) & "," & IIf(TextBox12.Text.Trim = "", 0, CDbl(TextBox12.Text)) & ",'" & IIf(CheckBox1.Checked, "SI", "NO") & "','" & TextBox8.Text.Trim & "') "
        ElseIf ESTADO_MODIF_DETALLE_RENDICION = True Then
            CONSULTA = "UPDATE dbo.RECEIVABLE_LINE_CAJA_CHICA_RENDICION_VARIOS SET TIPO_DOC='" & ComboBox1.SelectedValue & "'," _
                        & " NUMERO_DOC='" & TextBox7.Text.Trim & "',FECHA_DOC='" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "'," _
                        & " VENDOR_ID='" & TextBox4.Text.Trim & "',VENDOR='" & TextBox3.Text.Trim & "',OBS='" & TextBox5.Text.Trim & "'," _
                        & " CREATE_USER='" & LibComunVar.ClsVarComun.USUARIO & "',CREATE_DATE=getdate(),VVA=" & IIf(TextBox10.Text.Trim = "", 0, CDbl(TextBox10.Text)) & "," _
                        & " VVI=" & IIf(TextBox9.Text.Trim = "", 0, CDbl(TextBox9.Text)) & ",IGV=" & IIf(TextBox11.Text.Trim = "", 0, CDbl(TextBox11.Text)) & "," _
                        & " TOTAL=" & IIf(TextBox12.Text.Trim = "", 0, CDbl(TextBox12.Text)) & ",RC='" & IIf(CheckBox1.Checked, "SI", "NO") & "'," _
                        & " SERIE='" & TextBox8.Text.Trim & "' " _
                        & " WHERE ID_CAJA_CHICA='" & txt_numero_planilla.Text & "' AND ITEM_CAJA_CHICA='" & Format(_ITEM_DETALLE, "000") & "' " _
                        & " AND ITEM='" & Format(CInt(dgvDetalle.CurrentRow.Cells("ITEM").Value), "000") & "' "

        End If

        clienteBL = New ClsOperaciones.CUSTOMER
        If clienteBL.Ejecuta_consulta(CONSULTA) Then
            'MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
            Cargar_Rendicion_Varios(txt_numero_planilla.Text, Format(_ITEM_DETALLE, "000"))
            Call Limpiar_GroupBox(GroupBox5)
            TextBox10.Text = "0.0"
            TextBox9.Text = "0.0"
            TextBox11.Text = "0.0"
            TextBox12.Text = "0.0"
            CheckBox1.Checked = False
            ComboBox1.SelectedIndex = -1
            DateTimePicker1.Value = Date.Now
            ESTADO_MODIF_DETALLE_RENDICION = False
            TextBox4.Focus()
        Else
            MsgBox("No se llego a registrar.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim CONSULTA As String = String.Empty
        Dim clienteBL As ClsOperaciones.CUSTOMER

        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            CONSULTA = "UPDATE dbo.RECEIVABLE_LINE_CAJA_CHICA SET STATUS='R' WHERE ID='" & txt_numero_planilla.Text & "' AND ITEM='" & Format(_ITEM_DETALLE, "000") & "'"
        Else
            CONSULTA = "UPDATE dbo.RECEIVABLE_LINE_CAJA_CHICA SET STATUS='P' WHERE ID='" & txt_numero_planilla.Text & "' AND ITEM='" & Format(_ITEM_DETALLE, "000") & "'"
        End If


        clienteBL = New ClsOperaciones.CUSTOMER
        If clienteBL.Ejecuta_consulta(CONSULTA) Then
            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dtvD = New DataView
            dt_detalle = planillaBL.get_planilla_Det_Caja_Chica(txt_numero_planilla.Text)
            If dt_detalle.Rows.Count() <> 0 Then
                dtvD = dt_detalle.DefaultView
                dgv_detalles.DataSource = dtvD
                CONFIGURAR_GRILLA()
                txtsaldoinicial.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_MN").ToString, Decimal), "##,##00.00")
                txtingresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_MN)", ""), Decimal), "##,##00.00")
                txtegresos.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_MN)", ""), Decimal), "##,##00.00")
                txtsaldofinal.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_MN").ToString, Decimal), "##,##00.00")

                txtsaldoinicial_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_INICIAL_ME").ToString, Decimal), "##,##00.00")
                txtingresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_INGRESO_ME)", ""), Decimal), "##,##00.00")
                txtegresos_ME.Text = Format(CType(dt_detalle.Compute("sum(MONTO_EGRESO_ME)", ""), Decimal), "##,##00.00")
                txtsaldofinal_ME.Text = Format(CType(dt_detalle.Rows(0).Item("SALDO_FINAL_ME").ToString, Decimal), "##,##00.00")
            Else
                dgv_detalles.DataSource = Nothing
                txtsaldoinicial.Text = "0.0"
                txtingresos.Text = "0.0"
                txtegresos.Text = "0.0"
                txtsaldofinal.Text = "0.0"

                txtsaldoinicial_ME.Text = "0.0"
                txtingresos_ME.Text = "0.0"
                txtegresos_ME.Text = "0.0"
                txtsaldofinal_ME.Text = "0.0"
            End If

            GroupBox4.Enabled = True
            dgv_detalles.Enabled = True
            ToolStrip1.Enabled = True
            Panel2.Visible = False
        End If

        
    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles TextBox8.Leave
        If TextBox8.Text.Trim().Length > 0 Then
            TextBox8.Text = TextBox8.Text.PadLeft(10, Char.Parse("0"))
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        If TextBox7.Text.Trim().Length > 0 Then
            TextBox7.Text = TextBox7.Text.PadLeft(15, Char.Parse("0"))
        End If
    End Sub

    Private Sub txt_ruc_prov_nuevo_Leave(sender As Object, e As EventArgs) Handles txt_ruc_prov_nuevo.Leave
        Consultando_Ruc()
    End Sub

    Private Sub dtp_fecha_ini_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_ini.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fecha_fin.Focus()
        End If
    End Sub

    Private Sub dtp_fecha_fin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_fin.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar_Click(sender, e)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Text = "Se registra en Compras? SI"
        Else
            CheckBox1.Text = "Se registra en Compras? NO"
        End If
    End Sub

    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox12.Focus()
        End If
    End Sub

    Private Sub TextBox12_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub dtp_fec_ini_rp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_ini_rp.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fec_fin_rp.Focus()
        End If
    End Sub

    Private Sub btn_act_salddos_Click(sender As Object, e As EventArgs) Handles btn_act_salddos.Click
        Try
            If MessageBox.Show("¿Desea actualizar los saldos en general de todas las planillas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Dim dt_planillas As DataTable
                Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
                Dim saldo_final_mn As Double = 0
                Dim saldo_final_me As Double = 0
                Dim CONSULTA As String = String.Empty
                '******PRIMER PROCESO DE ACTUALIZAR LOS MOVIMIENTOS DE INGRESO Y SALIDA DE CADA PLANILLA******
                dt_planillas = New DataTable
                dtvD = New DataView
                dt_planillas = planillaBL.get_Mov_por_planilla_Caja_Chica()
                If dt_planillas.Rows.Count() <> 0 Then
                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                    ProgressBar1.Visible = True
                    ProgressBar1.Minimum = 0
                    ProgressBar1.Maximum = dt_planillas.Rows.Count()
                    For i As Integer = 0 To dt_planillas.Rows.Count - 1
                        ProgressBar1.Value = i
                        If i = 0 Then
                            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=0,INGRESOS=0,EGRESOS=0,SALDO_FINAL=0,SALDO_INICIAL_ME=0,INGRESOS_ME=0,EGRESOS_ME=0,SALDO_FINAL_ME=0 WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"

                            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                MsgBox("Error al actualizar a cero el Saldo Inicial y Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical, "Indice " & CStr(i))
                            End If
                            saldo_final_mn = CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_MN")) - CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_MN"))
                            saldo_final_me = CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_ME")) - CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_ME"))
                            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET INGRESOS=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_MN")), 2) & ",EGRESOS=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_MN")), 2) & ",INGRESOS_ME=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_ME")), 2) & ",EGRESOS_ME=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_ME")), 2) & ", SALDO_FINAL=" & Math.Round(saldo_final_mn, 2) & ",SALDO_FINAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                            'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                MsgBox("Error al actualizar los INGRESOS, EGRESOS y SALDO FINAL de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical, "Indice " & CStr(i))
                            End If
                        ElseIf i > 0 Then
                            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=0,INGRESOS=0,EGRESOS=0,SALDO_FINAL=0,SALDO_INICIAL_ME=0,INGRESOS_ME=0,EGRESOS_ME=0,SALDO_FINAL_ME=0 WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                            'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                MsgBox("Error al actualizar a cero el Saldo Inicial y Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical, "Indice " & CStr(i))
                            End If
                            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=" & Math.Round(saldo_final_mn, 2) & ",SALDO_INICIAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                            'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                MsgBox("Error al actualizar el SALDO INICIAL de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical, "Indice " & CStr(i))
                            End If

                            saldo_final_mn = Math.Round(saldo_final_mn, 2) + CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_MN")) - CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_MN"))
                            saldo_final_me = Math.Round(saldo_final_me, 2) + CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_ME")) - CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_ME"))

                            CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET INGRESOS=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_MN")), 2) & ",EGRESOS=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_MN")), 2) & ",INGRESOS_ME=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_INGRESO_ME")), 2) & ",EGRESOS_ME=" & Math.Round(CDbl(dt_planillas.Rows(i).Item("MONTO_EGRESO_ME")), 2) & ", SALDO_FINAL=" & Math.Round(saldo_final_mn, 2) & ",SALDO_FINAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                            'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                            If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                MsgBox("Error al actualizar los INGRESOS, EGRESOS y SALDO FINAL de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical, "Indice " & CStr(i))
                            End If
                        End If
                        ProgressBar1.PerformStep()
                    Next
                    ProgressBar1.Value = dt_planillas.Rows.Count()
                    'ProgressBar1.Visible = True
                End If
                '******FIN DE PRIMER PROCESO DE ACTUALIZAR LOS MOVIMIENTOS DE INGRESO Y SALIDA DE CADA PLANILLA******
                saldo_final_mn = 0
                saldo_final_me = 0
                dt_planillas = New DataTable
                dtvD = New DataView
                dt_planillas = planillaBL.get_planilla_Caja_Chica()
                If dt_planillas.Rows.Count() <> 0 Then
                    'ProgressBar1.Visible = True
                    ProgressBar1.Minimum = 0
                    ProgressBar1.Maximum = dt_planillas.Rows.Count()
                    For i As Integer = 0 To dt_planillas.Rows.Count - 1
                        ProgressBar1.Value = i
                        If i = 0 Then
                            saldo_final_mn = CDbl(dt_planillas.Rows(i).Item("SALDO_INICIAL")) + CDbl(dt_planillas.Rows(i).Item("INGRESOS")) - CDbl(dt_planillas.Rows(i).Item("EGRESOS"))
                            saldo_final_me = CDbl(dt_planillas.Rows(i).Item("SALDO_INICIAL_ME")) + CDbl(dt_planillas.Rows(i).Item("INGRESOS_ME")) - CDbl(dt_planillas.Rows(i).Item("EGRESOS_ME"))
                            If Math.Round(saldo_final_mn, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_FINAL")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_FINAL=" & Math.Round(saldo_final_mn, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If
                            If Math.Round(saldo_final_me, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_FINAL_ME")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_FINAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If
                        ElseIf i > 0 Then
                            If Math.Round(saldo_final_mn, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_INICIAL")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL=" & Math.Round(saldo_final_mn, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Inicial de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If
                            If Math.Round(saldo_final_me, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_INICIAL_ME")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_INICIAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Inicial de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If
                            saldo_final_mn = Math.Round(saldo_final_mn, 2) + CDbl(dt_planillas.Rows(i).Item("INGRESOS")) - CDbl(dt_planillas.Rows(i).Item("EGRESOS"))
                            saldo_final_me = Math.Round(saldo_final_me, 2) + CDbl(dt_planillas.Rows(i).Item("INGRESOS_ME")) - CDbl(dt_planillas.Rows(i).Item("EGRESOS_ME"))
                            If Math.Round(saldo_final_mn, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_FINAL")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_FINAL=" & Math.Round(saldo_final_mn, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If

                            If Math.Round(saldo_final_me, 2) <> CDbl(dt_planillas.Rows(i).Item("SALDO_FINAL_ME")) Then
                                CONSULTA = "UPDATE dbo.RECEIVABLE_CAJA_CHICA SET SALDO_FINAL_ME=" & Math.Round(saldo_final_me, 2) & " WHERE ID='" & dt_planillas.Rows(i).Item("ID") & "'"
                                'clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) = False Then
                                    MsgBox("Error al actualizar el Saldo Final de la Planilla N° " & dt_planillas.Rows(i).Item("ID"), MsgBoxStyle.Critical)
                                End If
                            End If
                        End If
                        ProgressBar1.PerformStep()
                    Next
                    ProgressBar1.Value = dt_planillas.Rows.Count()
                    MsgBox("Actualización de Saldos correcto.", MsgBoxStyle.Information)
                    ProgressBar1.Visible = False
                    clsReceivablaBl = Nothing
                End If

                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ProgressBar1.Visible = False
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_todos_conceptos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_conceptos.CheckedChanged
        If chk_todos_conceptos.Checked = True Then
            txt_cod_concepto.Text = ""
            txt_des_concepto.Text = ""
            txt_des_concepto.Enabled = False
            txt_cod_concepto.Enabled = False
        Else
            txt_cod_concepto.Text = ""
            txt_des_concepto.Text = ""
            txt_des_concepto.Enabled = True
            txt_cod_concepto.Enabled = True
        End If
    End Sub

    Private Sub chk_todos_personal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_personal.CheckedChanged
        If chk_todos_personal.Checked = True Then
            txt_cod_personal.Text = ""
            txt_desc_personal.Text = ""
            txt_cod_personal.Enabled = False
            txt_desc_personal.Enabled = False
        Else
            txt_cod_personal.Text = ""
            txt_desc_personal.Text = ""
            txt_cod_personal.Enabled = True
            txt_desc_personal.Enabled = True
        End If
    End Sub

    Private Sub txt_cod_concepto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_concepto.MouseDoubleClick
        Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)
    End Sub

    Private Sub txt_cod_concepto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_concepto.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_concepto.Text = "" Then
                Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)

            Else
                txt_cod_personal.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Concepto(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CCAJA_CHICA_SP_S_CONCEPTOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Concepto"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_personal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_personal.MouseDoubleClick
        Ayuda_Personal(txt_cod_personal, txt_desc_personal)
    End Sub

    Private Sub txt_cod_personal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Personal(txt_cod_personal, txt_desc_personal)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_concepto.Text = "" Then
                Ayuda_Personal(txt_cod_personal, txt_desc_personal)
            Else
                txt_cod_rendicion.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Personal(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CCAJA_CHICA_SP_S_PERSONAL"
            frm.CadenaConsulta = sql
            frm.Titulo = "Personal"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_rendicion.CheckedChanged
        If chk_todos_rendicion.Checked = True Then
            txt_cod_rendicion.Text = ""
            txt_desc_rendicion.Text = ""
            txt_cod_rendicion.Enabled = False
            txt_desc_rendicion.Enabled = False
        Else
            txt_cod_rendicion.Text = ""
            txt_desc_rendicion.Text = ""
            txt_cod_rendicion.Enabled = True
            txt_desc_rendicion.Enabled = True
        End If
    End Sub

    Private Sub txt_cod_rendicion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_rendicion.MouseDoubleClick
        Ayuda_Rendicion(txt_cod_rendicion, txt_desc_rendicion)
    End Sub

    Private Sub txt_cod_rendicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_rendicion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Rendicion(txt_cod_rendicion, txt_desc_rendicion)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_concepto.Text = "" Then
                Ayuda_Rendicion(txt_cod_rendicion, txt_desc_rendicion)
            Else
                Button2.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Rendicion(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CCAJA_CHICA_SP_S_ESTADO_RENDICION"
            frm.CadenaConsulta = sql
            frm.Titulo = "Estado de Rendición"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_ap_paterno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_paterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ap_materno.Select()
        End If
    End Sub

    Private Sub txt_ap_materno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_materno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pri_nombre.Select()
        End If
    End Sub

    Private Sub txt_pri_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pri_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_seg_nombre.Select()
        End If
    End Sub

    Private Sub txt_seg_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_seg_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_dir.Select()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Call Limpiar_GroupBox(GroupBox5)
        TextBox10.Text = "0.0"
        TextBox9.Text = "0.0"
        TextBox11.Text = "0.0"
        TextBox12.Text = "0.0"
        CheckBox1.Checked = False
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now

        If dgvDetalle.RowCount = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If dgvDetalle.CurrentRow.Cells("RC").Value = "SIR" Then
            MsgBox("El documento no se puede modificar, ya se encuentra registrado en Compras. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM='" & dgvDetalle.CurrentRow.Cells("ITEM").Value & "'")
            TextBox4.Text = row("VENDOR_ID") 'ID PROVEEDOR
            TextBox3.Text = row("VENDOR") ' PROVEEDOR
            ComboBox1.SelectedValue = row("TIPO_DOC") ' TIPO DOC
            TextBox8.Text = row("SERIE") ' SERIE
            TextBox7.Text = row("NUMERO_DOC") ' NUMERO
            TextBox10.Text = row("VVA") ' VVA
            TextBox9.Text = row("VVI") ' VVI
            TextBox11.Text = row("IGV") ' IGV
            TextBox12.Text = row("TOTAL") ' TOTAL
            If row("RC") = "SI" Then
                CheckBox1.Checked = True
            ElseIf row("RC") = "NO" Then
                CheckBox1.Checked = False
            End If
            DateTimePicker1.Value = row("FECHA_DOC") 'FECHA
            TextBox5.Text = row("OBS") ' OBS
        Next
        ESTADO_MODIF_DETALLE_RENDICION = True
        TextBox4.Focus()
    End Sub
End Class
