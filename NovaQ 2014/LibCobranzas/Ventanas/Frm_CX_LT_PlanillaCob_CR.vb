Imports System.Windows.Forms
Imports System.Drawing
Imports LibComunVar
Imports LibContabilidad
Imports LibSeguridad.ClsUsuario
Imports System.Data.SqlClient.SqlConnection

Public Class Frm_CX_LT_PlanillaCob_CR

    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Public dtUsuarioAcceso As DataTable
    Public tipo_cambio_planilla As Double
    Dim opt_planilla_detalle As String
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

    Dim dtDocumentosPrincipal As DataTable
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtDetalleClientes As DataTable
    Dim dtvcliente As DataView
    Dim tipo_doc_aplica_fp As String = String.Empty



    Private Sub Frm_CX_LT_PlanillaCob_CR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Cargar_Tipo_Cobranza()
        'Call Cargar_Bancos()
        Call Cargar_Documentos()
        Call Iniciar_Formulario()
        Formating()
        dtp_fecha_ini.Value = ModFunciones.Primer_Dia_Mes(Date.Now)
        dtp_fecha_fin.Value = ModFunciones.Ultimo_Dia_Mes(Date.Now)
        CONTROLES(True, 0)
        txtserieDoc.CharacterCasing = CharacterCasing.Upper
        dtp_fecha_ini.Select()
    End Sub


#Region "subprocesos"

    Private Sub Iniciar_Formulario()
        bol_activar_cmbs = True
    End Sub

    Private Sub Sumar_Marcados()
        Dim totalMN As Double = 0
        Dim totalME As Double = 0
        dgv_pendientes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For i As Integer = 0 To dgv_pendientes.Rows.Count - 1
            If dgv_pendientes.Rows(i).Cells("chk_Sel").Value = True Then
                If dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value = "MN" Then
                    totalMN += dgv_pendientes.Rows(i).Cells("COL_SALDO").Value
                ElseIf dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value = "ME" Then
                    totalME += dgv_pendientes.Rows(i).Cells("COL_SALDO").Value
                End If
            End If
        Next
        mtb_total_cobMN.Text = totalMN
        mtb_total_cobME.Text = totalME

        mtb_total_cobMN.Text = Format(Double.Parse(mtb_total_cobMN.Text), "##,##0.00")
        mtb_total_cobME.Text = Format(Double.Parse(mtb_total_cobME.Text), "##,##0.00")
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
        documentosBL = New ClsOperaciones.DOCUMENT_TYPE
        cmb_tipo_doc.DataSource = documentosBL.get_DocumentosCR()
        cmb_tipo_doc.ValueMember = "COD"
        cmb_tipo_doc.DisplayMember = "DES"
        documentosBL = Nothing
    End Sub

    Private Sub Cargar_Bancos()
        Dim bancoBL As New ClsOperaciones.BANK
        cmb_banco.DisplayMember = "NAME"
        cmb_banco.ValueMember = "ID"
        cmb_banco.DataSource = bancoBL.get_Bancos
        bancoBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Cobranza()
        Dim tipoCobranzaBL As New ClsOperaciones.TYPE_RECEIVE
        cmb_tipo_cob.DisplayMember = "DES"
        cmb_tipo_cob.ValueMember = "COD"
        cmb_tipo_cob.DataSource = tipoCobranzaBL.get_Tipos_CR()
        tipoCobranzaBL = Nothing
    End Sub

    Private Sub Cargar_Documentos_Pendientes()
        Dim saldosBL As New ClsOperaciones.CUSTOMER_BALANCE
        dgv_pendientes.DataSource = saldosBL.get_Documentos_Pendientes_x_Clientes(txt_cod_ane.Text, txt_fecha_planilla.Text)
        'dgv_pendientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgv_pendientes.AutoResizeColumns()
        'dgv_pendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        saldosBL = Nothing
        For i As Integer = 0 To dgv_pendientes.RowCount - 1
            dgv_pendientes.Rows(i).Cells("COL_SALDO").Value = dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value
        Next
        dgv_pendientes.Update()
    End Sub

    Private Sub Consultar_Planillas_Cab_xfecha()
        Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST
        dtvC = New DataView
        Dim fecha_ini As String = CDate(dtp_fecha_ini.Value).ToShortDateString
        Dim fecha_fin As String = CDate(dtp_fecha_fin.Value).ToShortDateString
        dtvC = planillaBL.get_planilla_x_fecha_CR(fecha_ini, fecha_fin).DefaultView
        dgv_planillas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dgv_planillas.DataSource = dtvC

        dgv_planillas.Columns(0).HeaderText = "N° Planilla"
        dgv_planillas.Columns(1).HeaderText = "Fecha"
        dgv_planillas.Columns(2).HeaderText = "Total Cobranza Soles"
        dgv_planillas.Columns(3).HeaderText = "Total Cobranza Dolares"
        dgv_planillas.Columns(4).HeaderText = "N° Voucher"
        dgv_planillas.Columns(5).Visible = False
        dgv_planillas.Columns(2).DefaultCellStyle.Format = "N2"
        dgv_planillas.Columns(3).DefaultCellStyle.Format = "N2"

        dgv_planillas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_planillas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        STRorden = String.Empty
        STRorden = dgv_planillas.Columns(0).Name '& "+" & dgv_planillas.Columns(4).Name
        lblCantidad.Text = "Se encontraron " & dtvC.Count & " registros"
        planillaBL = Nothing
        Formating()
    End Sub

    Private Sub Formating()
        For i As Integer = 0 To dgv_planillas.Columns.Count - 1
            dgv_planillas.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        'For Each row As DataGridViewRow In dgv_planillas.Rows
        '    If String.IsNullOrEmpty(row.Cells("FLAG_CONTA").Value.ToString) Then
        '        row.DefaultCellStyle.BackColor = Color.Red
        '        row.DefaultCellStyle.ForeColor = Color.White
        '    Else
        '        row.DefaultCellStyle.BackColor = Color.Blue
        '        row.DefaultCellStyle.ForeColor = Color.White
        '    End If
        'Next
        For i As Integer = 0 To dgv_planillas.Rows.Count() - 1
            If String.IsNullOrEmpty(dgv_planillas.Item(4, i).Value.ToString) Then
                dgv_planillas.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                dgv_planillas.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Red
            Else
                dgv_planillas.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                dgv_planillas.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Blue
            End If
        Next
        dgv_planillas.Update()
    End Sub

    Private Sub Ayuda_Vendedor()
        Dim frm_ayuda As New frm_CX_LT_Ayuda
        frm_ayuda.p_ops = 1
        frm_ayuda.ShowDialog()
        If frm_ayuda.p_bol_aceptar Then
        End If
    End Sub

#End Region

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Call Consultar_Planillas_Cab_xfecha()
        dgv_planillas.Focus()
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
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "CAJA_BANCOS")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Planilla de Cobro.", MsgBoxStyle.Critical)
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
        Dim planillaBE As New ClsEntidades.RECEIVABLE_LIST
        Dim numero_planilla As String = String.Empty
        Dim fecha_puente As Date, fecha_a_guardar As Date, dtTipoCamb_tc As DataTable, tc_a_guardar As Double

        Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
        cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

        dtTipoCamb_tc = Nothing
        dtTipoCamb_tc = cl.Verifircar_Planilla_Cobros_CR(dtp_fec_nueva_pla.Value.ToString("dd/MM/yyyy"))
        If dtTipoCamb_tc.Rows.Count() > 0 Then
            MsgBox("Existe una planilla con la fecha elegida" & Chr(13) & " proceda a modificar dicha planilla.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If

        If Verificar_Apertura_Cierre_Modulos(dtp_fec_nueva_pla.Value.Month, dtp_fec_nueva_pla.Value.Year) = False Then
            Exit Sub
        End If

        With planillaBE
            .ID = 0
            .DATE_PLA = CDate(dtp_fec_nueva_pla.Value).ToShortDateString

            'Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            fecha_puente = dtp_fec_nueva_pla.Text
            If fecha_puente.ToString("dddd") = "domingo" Then
                fecha_a_guardar = fecha_puente.AddDays(0) '(-3)
            ElseIf fecha_puente.ToString("ddddd") = "lunes" Then
                fecha_a_guardar = fecha_puente.AddDays(0)
            Else
                fecha_a_guardar = fecha_puente.AddDays(0)
            End If
            'End If
            cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE

            dtTipoCamb_tc = cl.get_VerificarTipoCambio(fecha_a_guardar.Year.ToString, fecha_a_guardar.Month.ToString, fecha_a_guardar.Day.ToString)
            If dtTipoCamb_tc.Rows.Count() <> 0 Then
                tc_a_guardar = dtTipoCamb_tc.Rows(0).Item("Tipo_Venta")
            Else
                MsgBox("No existe el Tipo de Cambio para la fecha elegida. Verifique!!!", MsgBoxStyle.Critical, "Sistemas")
                Exit Sub
            End If

            .AMOUNT = 0
            .AMOUNT_US = 0
            .AMOUNT_CH_DIF = 0
            .AMOUNT_CH_DIF_US = 0
            .VOUCHER_ID = 0
            .STATUS = "1"
            .CREATE_DATE = Now.Date.ToShortDateString
            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            .SALES_ID = ""
            .VOUCHER_ID_US = 0
            .SELL_RATE = Math.Round(tc_a_guardar, 3)
        End With
        planillaBL.Insert_CR(planillaBE, True, numero_planilla)
        planillaBE = Nothing
        planillaBL = Nothing
        txt_numero_planilla.Text = numero_planilla
        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        Call Consultar_Planillas_Cab_xfecha()
        dtp_fec_nueva_pla.Value = Date.Now
        pnlNuevaPlanilla.Visible = False
        dtp_fec_nueva_pla.Value = Date.Now
        dgv_planillas.Select()
    End Sub

    Private Sub btn_nuevo_det_Click(sender As Object, e As EventArgs) Handles btn_nuevo_det.Click
        cmb_tipo_cob.SelectedIndex = -1
        cmb_cta_cte.SelectedIndex = -1
        cmb_banco.SelectedIndex = -1
        CONTROLES(True, 2)
        mtb_fec_cob.Text = FechaActualPlanilla
        txt_tipo_cambio_detalle_cr.Text = txt_tc_planilla.Text
        txt_cod_ane.Focus()
    End Sub

    Private Sub btn_cancelar_crear_Click(sender As Object, e As EventArgs) Handles btn_cancelar_crear.Click
        pnlNuevaPlanilla.Visible = False
        dtp_fec_nueva_pla.Value = Date.Now
        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        dgv_planillas.Select()
    End Sub

    Private Sub btn_grabar_det_Click(sender As Object, e As EventArgs) Handles btn_grabar_det.Click
        Dim estado As Boolean = False
        If txt_cod_ane.Text = String.Empty Then
            MessageBox.Show("Seleccione un cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_cod_ane.Focus()
            Exit Sub
        End If

        If txt_tipo_cambio_detalle_cr.Text = String.Empty Then
            MessageBox.Show("Debe Ingresar un Tipo de Cambio.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_tipo_cambio_detalle_cr.Focus()
            Exit Sub
        End If

        If dgv_pendientes.CurrentRow Is Nothing Then Exit Sub
        For Each row As DataGridViewRow In dgv_pendientes.Rows
            If row.Cells(0).Value = True Then
                estado = True
                Exit For
            End If
        Next
        If estado = False Then
            MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dgv_pendientes.Focus()
            Exit Sub
        End If
        If gb_aplidoc.Enabled = False And gb_banco.Enabled = True Or gb_Efectivo.Enabled Then
            For Each row As DataGridViewRow In dgv_pendientes.Rows
                If row.Cells(0).Value = True Then
                    If row.Cells(1).Value = 0 Then
                        MessageBox.Show("Al seleccionar un registro debe ingresar una cantidad diferente de 0.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If
                End If
            Next
        End If
        '______________validamos algo____________________________________________
        If cmb_tipo_cob.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un Concepto de Cobranza", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_tipo_cob.Focus()
            Exit Sub
        End If
        'Validamos info de Banco
        If gb_banco.Enabled Then
            If cmb_banco.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un banco", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmb_banco.Focus()
                Exit Sub
            End If
            If cmb_cta_cte.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una cuenta corriente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmb_cta_cte.Focus()
                Exit Sub
            End If

            If txtdocRefBancos.Text = String.Empty Then
                MessageBox.Show("Seleccione un doc. de referencia", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtdocRefBancos.Focus()
                Exit Sub
            End If

            If txt_num_ref_ban.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese un número de referencia", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txt_num_ref_ban.Focus()
                Exit Sub
            End If
        End If
        'Validacion de aplicacion de documentos
        If gb_aplidoc.Enabled Then
            If cmb_tipo_doc.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un tipo de Documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmb_tipo_doc.Focus()
                Exit Sub
            End If
            If txtserieDoc.Text = String.Empty Then
                MsgBox("Debe ingresar la serie del documento.", MsgBoxStyle.Exclamation)
                txtserieDoc.Focus()
                Exit Sub
            ElseIf txtnumDoc.Text = String.Empty Then
                MsgBox("Debe ingresar el Nro del documento.", MsgBoxStyle.Exclamation)
                txtnumDoc.Focus()
                Exit Sub
            End If
            If txtmonto.Text = String.Empty Then
                MessageBox.Show("Debe ingresar el monto del documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtmonto.Focus()
                Exit Sub
            Else
                If txtmonto.Text = 0 Then
                    MessageBox.Show("El monto debe ser mayor a cero.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtmonto.Focus()
                    Exit Sub
                End If
            End If

            If Strings.Left(mtb_fecha_aplic_doc.Text, 2).Trim = String.Empty Then
                MsgBox("Debe ingresar la fecha del documento.", MsgBoxStyle.Exclamation)
                mtb_fecha_aplic_doc.Focus()
                Exit Sub
            Else
                If IsDate(mtb_fecha_aplic_doc.Text) = False Then
                    MsgBox(" La Fecha Ingresada no posee un formato Correcto. ", MsgBoxStyle.Exclamation, "Error al ingresar la fecha ")
                    mtb_fecha_aplic_doc.Select()
                    Exit Sub
                End If
            End If


            Dim planillaBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable

            If cmb_tipo_doc.SelectedValue = "NC" Then
                txtnumDoc.Text = String.Format("{0:0000000}", CInt(txtnumDoc.Text.Trim))
                dt_detalle = New DataTable
                dt_detalle = planillaBL.VerificandoNumeracionDocumentosNC(txt_cod_ane.Text, txtserieDoc.Text & txtnumDoc.Text)
                If dt_detalle.Rows.Count() = 0 Then
                    MsgBox("No hay informacion con el Nro. documento especificado. Verifique!", MsgBoxStyle.Exclamation)
                    txtserieDoc.Text = String.Empty
                    txtnumDoc.Text = String.Empty
                    txtmonto.Text = 0
                    mtb_fecha_aplic_doc.Text = String.Empty
                    Exit Sub
                End If
                If Math.Abs(CDbl(txtmonto.Text)) > Math.Abs(CDbl(dt_detalle.Rows(0).Item("AMOUNT_BALANCE"))) Then
                    MsgBox("La cantidad debe ser menor o igual que el total de la Nota Credito.", MsgBoxStyle.Exclamation)
                    txtmonto.Select()
                    Exit Sub
                End If

            End If

        End If
        'Validacion de Aplicacion de doc Efectivo
        If gb_Efectivo.Enabled = True Then
            If txt_efectivo_doc_Ref.Text = String.Empty Then
                MessageBox.Show("Seleccione un tipo de Documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txt_efectivo_doc_Ref.Focus()
                Exit Sub
            End If
            If txtEfectoNumerodocRef.Text = String.Empty Then
                MsgBox("Debe ingresar un  número de documento de referencia.", MsgBoxStyle.Exclamation)
                txtEfectoNumerodocRef.Focus()
                Exit Sub
            End If
        End If

        'Validacion de Aplicacion de doc Saldos
        If gb_aplicacionSaldos.Enabled = True Then
            If txtreferenciaSaldo.Text = String.Empty Then
                MessageBox.Show("Seleccione un tipo de Documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtreferenciaSaldo.Focus()
                Exit Sub
            End If
            If txtnumerosaldo.Text = String.Empty Then
                MsgBox("Debe ingresar un  número de documento.", MsgBoxStyle.Exclamation)
                txtnumerosaldo.Focus()
                Exit Sub
            End If
        End If

        '______________ Comenzamos a Grabar ____________________________________________

        Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
        planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
        Dim planilladetBE As ClsEntidades.RECEIVABLE_LIST_LINE
        Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LIST_LINE)
        For i As Integer = 0 To dgv_pendientes.RowCount - 1
            planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
            If dgv_pendientes.Rows(i).Cells("chk_Sel").Value Then
                If gb_aplidoc.Enabled = True And gb_banco.Enabled = False Then
                    If cmb_tipo_doc.SelectedValue = "NC" Then
                        If dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value = "NC" Then
                            MessageBox.Show("Debe seleccionar un TipoDoc diferente a Nota Credito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                    ElseIf cmb_tipo_doc.SelectedValue = "FP" Then 'Or cmb_tipo_doc.SelectedValue = "CR" Then
                        If Math.Abs(CDbl(txtmonto.Text)) > Math.Abs(CDbl(dgv_pendientes.Rows(i).Cells("COL_SALDO").Value.ToString)) Then
                            MessageBox.Show("El monto a aplicar es MAYOR al saldo del documento a cobrar. Verifique!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If
                    ElseIf cmb_tipo_doc.SelectedValue = "CR" Then
                        If Math.Abs(CDbl(mtb_total_cobMN.Text)) > 0 Then
                            If Math.Abs(CDbl(txtmonto.Text)) > Math.Abs(CDbl(mtb_total_cobMN.Text)) Then
                                MessageBox.Show("El monto a aplicar es MAYOR al saldo del documento a cobrar. Verifique!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End If
                        Else
                            If (Math.Abs(CDbl(txtmonto.Text)) - Math.Abs(CDbl(mtb_total_cobME.Text) * CDbl(txt_tipo_cambio_detalle_cr.Text))) > 2 Then
                                MessageBox.Show("El monto a aplicar es MAYOR al saldo del documento a cobrar. Verifique!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                With planilladetBE
                    .ID = txt_numero_planilla.Text.Trim
                    .ITEM = 0
                    .TYPE_DOC = dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value.ToString
                    .NUMBER_DOC = dgv_pendientes.Rows(i).Cells("COL_NUM_DOC_AUX").Value.ToString
                    .TYPE_OPERATION = "F"
                    .REC_ID = cmb_tipo_cob.SelectedValue
                    .DATE_PLA = mtb_fec_cob.Text
                    If gb_aplidoc.Enabled = True And gb_banco.Enabled = False Then
                        If cmb_tipo_doc.SelectedValue = "NC" Or cmb_tipo_doc.SelectedValue = "FP" Then
                            .AMOUNT = (Math.Abs(CDbl(txtmonto.Text)))
                        Else
                            .AMOUNT = dgv_pendientes.Rows(i).Cells("COL_SALDO").Value.ToString
                        End If
                    Else
                        .AMOUNT = dgv_pendientes.Rows(i).Cells("COL_SALDO").Value.ToString
                    End If
                    .CURRENCY_ID = dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value.ToString
                    .SELL_RATE = Math.Round(CDbl(txt_tipo_cambio_detalle_cr.Text), 3)
                    .CREATE_DATE = Now.Date.ToShortDateString
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .COMMENT = txt_glosa.Text.Trim
                    .SALES_ID = dgv_pendientes.Rows(i).Cells("COL_SALES_ID").Value.ToString
                    .BANK_ID = String.Empty
                    .BANK_DESCRIPTION = String.Empty
                    .DOC_REF = String.Empty
                    .NUM_REF = String.Empty
                    .SERIE_REF = String.Empty
                    .BANK_BUSSINESS_ID = String.Empty
                    .ACCOUNT_BANK_CHECK = String.Empty
                    If gb_banco.Enabled Then
                        .BANK_ID = cmb_banco.SelectedValue
                        .BANK_DESCRIPTION = cmb_banco.SelectedText
                        .DOC_REF = TraerCodigo(txtdocRefBancos.Text)
                        .NUM_REF = txt_num_ref_ban.Text.Trim
                        .BANK_BUSSINESS_ID = cmb_cta_cte.SelectedValue
                        .ACCOUNT_BANK_CHECK = cmb_cta_cte.SelectedText
                    End If
                    If gb_aplidoc.Enabled = True And gb_banco.Enabled = False Then
                        If cmb_tipo_doc.SelectedValue = "NC" Then
                            .DOC_REF = cmb_tipo_doc.SelectedValue.ToString
                            .NUM_REF = txtserieDoc.Text & txtnumDoc.Text
                        ElseIf cmb_tipo_doc.SelectedValue = "FP" Or cmb_tipo_doc.SelectedValue = "CR" Then
                            .DOC_REF = cmb_tipo_doc.SelectedValue.ToString
                            .SERIE_REF = txtserieDoc.Text
                            .NUM_REF = txtnumDoc.Text
                        End If
                    End If
                    If gb_Efectivo.Enabled = True And gb_aplidoc.Enabled = False And gb_banco.Enabled = False Then
                        .DOC_REF = TraerCodigo(txt_efectivo_doc_Ref.Text)
                        .NUM_REF = txtEfectoNumerodocRef.Text
                    End If
                    If gb_aplicacionSaldos.Enabled = True And gb_Efectivo.Enabled = False And gb_aplidoc.Enabled = False And gb_banco.Enabled = False Then
                        .DOC_REF = TraerCodigo(txtreferenciaSaldo.Text)
                        .NUM_REF = txtnumerosaldo.Text
                    End If
                    .LIST_ID = 0
                    .IS_CASH_BANK = "0"
                    .AMOUNT_PER = 0
                    .PAY_AUTO = 0
                    .ANNEX_ID_AUX = dgv_pendientes.Rows(i).Cells("CUSTOMER_ID").Value.ToString 'txt_cod_ane.Text
                    .DOCUMET_ID = dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value.ToString
                    .NUMBER_SERIE = dgv_pendientes.Rows(i).Cells("SERIE_AUX").Value.ToString
                    .NUMBER_DOCUMENT = dgv_pendientes.Rows(i).Cells("NUM_DOC_AUX").Value.ToString
                    .MEDIOS_PAGO = 0

                    If Strings.Left(mtb_fecha_aplic_doc.Text, 2).Trim = "" Then
                        .DATE_REF = ""
                    Else
                        .DATE_REF = CDate(mtb_fecha_aplic_doc.Text).ToString("dd/MM/yyyy")
                    End If
                    If txt_itf.Text = "" Then
                        .AMOUNT_ITF = CDbl(0)
                    Else
                        .AMOUNT_ITF = CDbl(txt_itf.Text)
                    End If
                    If txt_comisiones.Text = "" Then
                        .AMOUNT_COMISIONES = CDbl(0)
                    Else
                        .AMOUNT_COMISIONES = CDbl(txt_comisiones.Text)
                    End If

                End With
                ls_detalle.Add(planilladetBE)
                If gb_aplidoc.Enabled = True And gb_banco.Enabled = False Then
                    If cmb_tipo_doc.SelectedValue = "NC" Or cmb_tipo_doc.SelectedValue = "FP" Then
                        Exit For
                    End If
                End If
            End If
        Next
        Dim ESTADO_GRABADO As Boolean = False
        If gb_aplidoc.Enabled = True And gb_banco.Enabled = False Then
            If cmb_tipo_doc.SelectedValue = "NC" Then
                ' ESTADO_GRABADO = planilladetBL.InsertNC(ls_detalle, cmb_tipo_doc.SelectedValue.ToString, txtserieDoc.Text, txtnumDoc.Text, (Math.Abs(CDbl(txtmonto.Text))) * -1, txt_cod_mon.Text, FechaActualPlanilla)
            ElseIf cmb_tipo_doc.SelectedValue = "FP" Then
                'ESTADO_GRABADO = planilladetBL.InsertFP(ls_detalle, tipo_doc_aplica_fp, txtserieDoc.Text, txtnumDoc.Text, (Math.Abs(CDbl(txtmonto.Text))) * -1, txt_cod_mon.Text, FechaActualPlanilla)
            Else
                ESTADO_GRABADO = planilladetBL.Insert_CR(ls_detalle, txt_cod_mon.Text, FechaActualPlanilla)
            End If
        Else
            'ESTADO_GRABADO = planilladetBL.Insert(ls_detalle, txt_cod_mon.Text, FechaActualPlanilla)
        End If
        planilladetBL = Nothing

        If ESTADO_GRABADO Then
            MessageBox.Show("Proceso Generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmb_tipo_cob.SelectedIndex = -1
            Blank()
            txtdocRefBancos.Text = String.Empty
            tc_tipCob.SelectedIndex = 0
            If dgv_pendientes.RowCount() <> 0 Then
                For n As Integer = dgv_pendientes.Rows.Count - 1 To 0 Step -1
                    Dim row As DataGridViewRow = dgv_pendientes.Rows(n)
                    dgv_pendientes.Rows.Remove(row)
                Next
            End If
            'dgv_pendientes.DataSource = Nothing
            txt_tipo_cambio_detalle_cr.Text = txt_tc_planilla.Text
            txt_cod_ane.Text = ""
            txt_des_ane.Text = ""
            txt_cod_ane.Focus()
        Else
            MessageBox.Show("Proceso incorrecto, verifique los datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Blank()
        txt_glosa.Text = String.Empty
        mtb_fecha_aplic_doc.Text = String.Empty
        txt_cod_mon.Text = String.Empty
        txt_cta_conta.Text = String.Empty
        txt_num_ref_ban.Text = String.Empty
        cmb_banco.SelectedIndex = -1
        cmb_cta_cte.SelectedIndex = -1
        txtserieDoc.Text = String.Empty
        txtnumDoc.Text = String.Empty
        txtmonto.Text = 0
        cmb_tipo_doc.SelectedIndex = 0
        txt_efectivo_doc_Ref.Text = String.Empty
        txtEfectoNumerodocRef.Text = String.Empty
        tipo_doc_aplica_fp = String.Empty
        txt_itf.Text = 0
        txt_comisiones.Text = 0
    End Sub

    Private Sub btn_cancelar_det_Click(sender As Object, e As EventArgs) Handles btn_cancelar_det.Click
        'tc_planilla.SelectTab(1)
        CONTROLES(True, 1)
        txt_cod_ane.Text = String.Empty
        txt_des_ane.Text = String.Empty
        mtb_total_cobMN.Text = 0
        If dgv_pendientes.RowCount() <> 0 Then
            For n As Integer = dgv_pendientes.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgv_pendientes.Rows(n)
                dgv_pendientes.Rows.Remove(row)
            Next
        End If
        Blank()
        If txt_numero_planilla.Text = String.Empty Then Exit Sub
        'Edicion_Planilla()
        Editar_Planilla()
        Sumar_Montos_DetPlanilla()
    End Sub

    Private Sub cmb_tipo_cob_Enter(sender As Object, e As EventArgs) Handles cmb_tipo_cob.Enter
        Call Sumar_Marcados()
    End Sub

    Private Sub cmb_tipo_cob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_cob.SelectedIndexChanged
        'validamos si es banco,aplicacion de documentos, efectivo
        gb_banco.Enabled = False
        gb_aplidoc.Enabled = False
        gb_Efectivo.Enabled = False
        gb_aplicacionSaldos.Enabled = False

        If bol_activar_cmbs Then
            If cmb_tipo_cob.SelectedIndex <> -1 Then
                Dim tipocobBL As ClsOperaciones.TYPE_RECEIVE
                tipocobBL = New ClsOperaciones.TYPE_RECEIVE
                Dim tipocobBE As New ClsEntidades.TYPE_RECEIVE
                tipocobBE.RECEIVE_ID = cmb_tipo_cob.SelectedValue.ToString
                tipocobBL.get_Tipo_x_Cod(tipocobBE)
                tipocobBL = Nothing
                txtserieDoc.Text = String.Empty
                txtnumDoc.Text = String.Empty
                txtmonto.Text = "0.0"
                txtdocRefBancos.Text = String.Empty
                txt_num_ref_ban.Text = String.Empty
                txt_efectivo_doc_Ref.Text = String.Empty
                txtEfectoNumerodocRef.Text = String.Empty
                txtreferenciaSaldo.Text = String.Empty
                txtnumerosaldo.Text = String.Empty
                txt_itf.Text = "0.0"

                If tipocobBE.BANK_ID = 1 Then 'cobro en banco
                    gb_banco.Enabled = True
                    gb_aplidoc.Enabled = False
                    gb_Efectivo.Enabled = False
                    tc_tipCob.SelectedIndex = 1
                    tipocobBL = New ClsOperaciones.TYPE_RECEIVE
                    Dim dtSolucion As New DataTable
                    dtSolucion = tipocobBL.Conceptos_Cobranza(cmb_tipo_cob.SelectedValue.ToString)
                    cmb_banco.DataSource = Nothing
                    cmb_cta_cte.DataSource = Nothing
                    If dtSolucion.Rows.Count() <> 0 Then
                        cmb_banco.DisplayMember = "NAME"
                        cmb_banco.ValueMember = "ID"
                        cmb_banco.DataSource = dtSolucion
                    End If
                    cmb_banco.Select()
                End If
                'If tipocobBE.IS_APPL = 1 And tipocobBE.TRANS_TYPE = 0 Then
                '    gb_banco.Enabled = False
                '    gb_aplidoc.Enabled = False
                '    gb_Efectivo.Enabled = True
                '    txt_num_ref_ban.Text = String.Empty
                '    cmb_banco.SelectedIndex = -1
                '    cmb_cta_cte.SelectedIndex = -1
                '    txtserieDoc.Text = String.Empty
                '    txtnumDoc.Text = String.Empty
                '    txtmonto.Text = String.Empty
                '    tc_tipCob.SelectedIndex = 2
                '    txt_efectivo_doc_Ref.Text = String.Empty
                'End If

                If tipocobBE.IS_APPL = 1 And tipocobBE.TRANS_TYPE = 3 Then 'aplicacion de NC
                    gb_aplidoc.Enabled = True
                    gb_banco.Enabled = False
                    gb_Efectivo.Enabled = False
                    txt_num_ref_ban.Text = String.Empty
                    cmb_banco.SelectedIndex = -1
                    cmb_cta_cte.SelectedIndex = -1
                    gb_aplidoc.Enabled = True
                    tc_tipCob.SelectedIndex = 0
                    txt_efectivo_doc_Ref.Text = String.Empty
                    txtEfectoNumerodocRef.Text = String.Empty
                    cmb_tipo_doc.Select()
                End If

                If tipocobBE.IS_APPL = 0 And tipocobBE.TRANS_TYPE = 7 Then 'aplicacion de saldos
                    gb_banco.Enabled = False
                    gb_aplidoc.Enabled = False
                    gb_Efectivo.Enabled = False
                    gb_aplicacionSaldos.Enabled = True
                    txt_num_ref_ban.Text = String.Empty
                    cmb_banco.SelectedIndex = -1
                    cmb_cta_cte.SelectedIndex = -1
                    tc_tipCob.SelectedIndex = 3
                    txt_efectivo_doc_Ref.Text = String.Empty
                    txtEfectoNumerodocRef.Text = String.Empty
                    txtreferenciaSaldo.Text = String.Empty
                    txtnumerosaldo.Text = String.Empty
                    txtreferenciaSaldo.Select()
                End If
                If tipocobBE.BANK_ID = 0 And tipocobBE.IS_CHECK_DIF = 0 And tipocobBE.IS_APPL = 0 And tipocobBE.TRANS_TYPE = 0 And tipocobBE.IS_CREDIT_CARD = 0 Then 'pago en efectivo
                    gb_banco.Enabled = False
                    gb_aplidoc.Enabled = False
                    gb_Efectivo.Enabled = True
                    gb_aplicacionSaldos.Enabled = False
                    txt_num_ref_ban.Text = String.Empty
                    cmb_banco.SelectedIndex = -1
                    cmb_cta_cte.SelectedIndex = -1
                    tc_tipCob.SelectedIndex = 2
                    txt_efectivo_doc_Ref.Text = String.Empty
                    txtEfectoNumerodocRef.Text = String.Empty
                    txtreferenciaSaldo.Text = String.Empty
                    txtnumerosaldo.Text = String.Empty
                    txt_efectivo_doc_Ref.Select()
                End If
                txt_cod_mon.Text = tipocobBE.CURRENCY_ID
                txt_cta_conta.Text = tipocobBE.ACCOUNT
                ' mtb_fec_cob.Text = Date.Now.ToShortDateString
            End If
        End If
        Calculando_Montos(txt_cod_mon.Text)
    End Sub

    Private Sub Calculando_Montos(ByVal MonedaCobranza As String)
        If dgv_pendientes.RowCount() = 0 Then Exit Sub
        If txt_cod_mon.Text = "" Then Exit Sub
        Try
            Dim AMOUNT As Double = 0.0
            Dim AMOUNT_SALDO As Double = 0.0

            Dim CURRENCY_ID As String = ""
            For i As Integer = 0 To dgv_pendientes.RowCount - 1
                If dgv_pendientes.Rows(i).Cells("chk_Sel").Value = False Then
                    Continue For
                Else
                    AMOUNT = dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString 'dgv_pendientes.Rows(i).Cells("COL_SALDO").Value.ToString
                    AMOUNT_SALDO = dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString


                    CURRENCY_ID = dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value.ToString
                    If dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value <> "NC" Then
                        If CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                AMOUNT = AMOUNT
                            Else
                                AMOUNT = AMOUNT * CDbl(txt_tipo_cambio_detalle_cr.Text) 'dgv_pendientes.Rows(i).Cells("COL_TC").Value
                            End If
                        ElseIf CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                AMOUNT = AMOUNT
                            Else
                                AMOUNT = AMOUNT / CDbl(txt_tipo_cambio_detalle_cr.Text) 'dgv_pendientes.Rows(i).Cells("COL_TC").Value
                            End If
                        End If
                    Else
                        If CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                AMOUNT = (Math.Abs(AMOUNT)) * -1
                            Else
                                AMOUNT = (Math.Abs(AMOUNT * CDbl(txt_tipo_cambio_detalle_cr.Text)) * -1) 'dgv_pendientes.Rows(i).Cells("COL_TC").Value) * -1)
                            End If
                        ElseIf CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                AMOUNT = (Math.Abs(AMOUNT) * -1)
                            Else
                                AMOUNT = (Math.Abs(AMOUNT / CDbl(txt_tipo_cambio_detalle_cr.Text)) * -1) 'dgv_pendientes.Rows(i).Cells("COL_TC").Value) * -1)
                            End If
                        End If
                    End If
                    dgv_pendientes.Rows(i).Cells("COL_SALDO").Value = IIf(String.IsNullOrEmpty(AMOUNT), 0, Math.Round(AMOUNT, 2))
                    dgv_pendientes.Update()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmb_banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_banco.SelectedIndexChanged
        If cmb_banco.SelectedIndex = -1 Then Exit Sub
        If bol_activar_cmbs Then
            Dim ctasctesbl As New ClsOperaciones.ACCOUNT_BANK
            Dim dtsoluciones As New DataTable
            dtsoluciones = ctasctesbl.get_Cuentas_Corrientes(cmb_banco.SelectedValue)
            cmb_cta_cte.DataSource = Nothing
            If dtsoluciones.Rows.Count() <> 0 Then
                cmb_cta_cte.DisplayMember = "des"
                cmb_cta_cte.ValueMember = "cod"
                cmb_cta_cte.DataSource = dtsoluciones
            End If
            ctasctesbl = Nothing
        End If
    End Sub

    Private Sub cmb_tipo_cob_Leave(sender As Object, e As EventArgs) Handles cmb_tipo_cob.Leave
        Call Sumar_Marcados()
    End Sub

    Private Sub dgv_pendientes_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellValidated
        Call Sumar_Marcados()
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        ' tc_planilla.SelectTab(0)
        CONTROLES(True, 0)
    End Sub

    Private Sub txt_cod_ane_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ane.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes("")
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_ane.Text = String.Empty Then Ayuda_Clientes("")
            Ayuda_Clientes(txt_cod_ane.Text)
        End If
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
            lblCantidadDetall.Text = "Se encontraron " & dtvD.Count & " registros"
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
        If String.IsNullOrEmpty(dgv_planillas.CurrentRow.Cells("FLAG_CONTA").Value.ToString) Then
            _FLAG_CONTA = False
        Else
            _FLAG_CONTA = True
        End If
        ''Fecha de la Planilla
        FechaActualPlanilla = dgv_planillas.Item(1, dgv_planillas.CurrentRow.Index).Value
        txt_numero_planilla.Text = num_planilla
        txt_voucher.Text = num_voucher

        txt_fecha_planilla.Text = FechaActualPlanilla
        txt_tc_planilla.Text = dgv_planillas.CurrentRow.Cells("TIPO_CAMBIO").Value
        txt_tc_planilla.Text = Format(Double.Parse(txt_tc_planilla.Text), "##,##0.000")
        tipo_cambio_planilla = CDbl(txt_tc_planilla.Text)


        dt_detalle = New DataTable
        dtvD = New DataView
        dt_detalle = planillaBL.get_planilla_Det_xID_CR(num_planilla)
        If dt_detalle.Rows.Count() <> 0 Then
            dtvD = dt_detalle.DefaultView

            dgv_detalles.DataSource = dtvD
            dgv_detalles.AutoResizeColumns()
            dgv_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv_detalles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv_detalles.Columns(1).Width = 30
            dgv_detalles.Columns(1).HeaderText = "Item"
            dgv_detalles.Columns(2).Visible = False
            dgv_detalles.Columns(3).Width = 30
            dgv_detalles.Columns(3).HeaderText = "Doc"
            dgv_detalles.Columns(4).Width = 80
            dgv_detalles.Columns(4).HeaderText = "Nro"

            dgv_detalles.Columns(6).Width = 250
            dgv_detalles.Columns(6).HeaderText = "Cliente"
            dgv_detalles.Columns(9).Width = 40
            dgv_detalles.Columns(9).HeaderText = "Mon"
            dgv_detalles.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_detalles.Columns(10).Width = 80
            dgv_detalles.Columns(10).HeaderText = "Monto"
            dgv_detalles.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgv_detalles.Columns(13).Width = 40
            dgv_detalles.Columns(13).Visible = False
            'dgv_detalles.Columns(14).Width = 180
            dgv_detalles.Columns(14).Visible = False
            dgv_detalles.Columns(15).Width = 80
            dgv_detalles.Columns(15).HeaderText = "Cuenta Contable"
            dgv_detalles.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgv_detalles.Columns(16).Width = 80
            dgv_detalles.Columns(16).Visible = False
            dgv_detalles.Columns(19).HeaderText = "Ruc"
            dgv_detalles.Columns(19).DisplayIndex = 5
            dgv_detalles.Columns(19).Width = 80
            dgv_detalles.Columns(20).Visible = False

            dgv_detalles.Columns(21).HeaderText = "Banco"
            dgv_detalles.Columns(21).Visible = False
            dgv_detalles.Columns(22).Width = 80
            dgv_detalles.Columns(22).HeaderText = "Doc. Referencia"
            dgv_detalles.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_detalles.Columns(23).Width = 140
            dgv_detalles.Columns(23).HeaderText = "Nro. Referencia"
            dgv_detalles.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_detalles.Columns(24).HeaderText = "Observaciones"

            dgv_detalles.Columns(25).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalles.Columns(25).HeaderText = "Interes Ganado"
            dgv_detalles.Columns(25).Visible = False

            dgv_detalles.Columns(26).DefaultCellStyle.Format = "##,##0.00"
            dgv_detalles.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalles.Columns(26).HeaderText = "Comisiones/Portes"
            dgv_detalles.Columns(26).Visible = False

            dgv_detalles.Columns(27).DefaultCellStyle.Format = "##,##0.000"
            dgv_detalles.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgv_detalles.Columns(0).Visible = False
            dgv_detalles.Columns(5).Visible = False
            dgv_detalles.Columns(7).Visible = False
            dgv_detalles.Columns(8).Visible = False
            dgv_detalles.Columns(11).Visible = False
            dgv_detalles.Columns(12).Visible = False
            dgv_detalles.Columns(17).Visible = False
            dgv_detalles.Columns(18).Visible = False
            dgv_detalles.Columns(28).Visible = False

            dgv_detalles.Columns(29).HeaderText = "N° Voucher"

            STRorden = dgv_detalles.Columns(3).Name & "+" & dgv_detalles.Columns(4).Name & "+" & dgv_detalles.Columns(5).Name & "+" & dgv_detalles.Columns(6).Name
            lblCantidadDetall.Text = "Se encontraron " & dtvD.Count & " registros"
        Else
            dgv_detalles.DataSource = Nothing
        End If
    End Sub

    Private Sub Sumar_Montos_DetPlanilla()
        Dim s As Double = 0
        Dim d As Double = 0

        For i As Integer = 0 To dgv_detalles.Rows.Count - 1
            If dgv_detalles.Rows(i).Cells("CURRENCY_ID").Value = "MN" Then
                s += dgv_detalles.Rows(i).Cells("AMOUNT").Value
            Else
                d += dgv_detalles.Rows(i).Cells("AMOUNT").Value
            End If
        Next
        mtb_tot_soles.Text = s
        mtb_tot_dolares.Text = d
        mtb_tot_soles.Text = Format(Double.Parse(mtb_tot_soles.Text), "##,##0.00")
        mtb_tot_dolares.Text = Format(Double.Parse(mtb_tot_dolares.Text), "##,##0.00")
    End Sub


    Private Sub txt_cod_ven_DoubleClick(sender As Object, e As EventArgs)
        Call Ayuda_Vendedor()
    End Sub

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
        If txt_numero_planilla.Text = String.Empty Then Exit Sub
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim CodCliente As String = String.Empty
            Dim tipoDoc As String = String.Empty
            Dim TipoDocRef As String = String.Empty
            Dim numeroDoc As String = String.Empty
            Dim NumDocRef As String = String.Empty
            Dim CodigoPlanilla As String = String.Empty
            Dim Item As String = String.Empty
            Dim MonDoc As String = String.Empty
            Dim Consulta As String = String.Empty
            Dim MontodoC As Double = 0
            Dim Tipo_Cambio_Detalle As Double = 0
            Dim TipoDocCobranza As String = String.Empty
            Dim NumDocCobranza As String = String.Empty
            Dim Concepto_Cobro As String = String.Empty

            Dim dtValidacion As DataTable, _genera_validacion_al_eliminar As String = ""
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion("PLA", "000")
            If dtValidacion.Rows.Count > 0 Then
                _genera_validacion_al_eliminar = dtValidacion.Rows(0).Item("IS_DELETE_PLANILLA_COBROS").ToString
            End If
            If _genera_validacion_al_eliminar = "S" Then
                opt_planilla_detalle = "D"
                gb_pas_elimina_planilla.Visible = True
                tc_planilla.Enabled = False
                ToolStrip1.Enabled = False
                txtpassword.Text = ""
                txtpassword.Focus()
            Else
                CodigoPlanilla = dgv_detalles.CurrentRow.Cells("ID").Value
                Item = Format(dgv_detalles.CurrentRow.Cells("ITEM").Value, "000")
                tipoDoc = dgv_detalles.CurrentRow.Cells("TYPE_DOC").Value
                numeroDoc = dgv_detalles.CurrentRow.Cells("NUMBER_DOC").Value
                CodCliente = dgv_detalles.CurrentRow.Cells("ANNEX_ID_AUX").Value
                MonDoc = dgv_detalles.CurrentRow.Cells("CURRENCY_ID").Value
                MontodoC = dgv_detalles.CurrentRow.Cells("AMOUNT").Value
                Concepto_Cobro = dgv_detalles.CurrentRow.Cells("RECEIVE_ID").Value
                Tipo_Cambio_Detalle = CDbl(dgv_detalles.CurrentRow.Cells("SELL_RATE").Value)

                TipoDocRef = IIf(IsDBNull(dgv_detalles.CurrentRow.Cells("DOCUMET_ID").Value), "", dgv_detalles.CurrentRow.Cells("DOCUMET_ID").Value)
                NumDocRef = IIf(IsDBNull(dgv_detalles.CurrentRow.Cells("NUMBER_DOCUMENT").Value), "", dgv_detalles.CurrentRow.Cells("NUMBER_DOCUMENT").Value)
                TipoDocCobranza = dgv_detalles.CurrentRow.Cells("DOC_REF").Value
                NumDocCobranza = dgv_detalles.CurrentRow.Cells("NUM_REF").Value
                If CodigoPlanilla = String.Empty Or Item = String.Empty Or tipoDoc = String.Empty Or numeroDoc = String.Empty Then Exit Sub
                Dim planillaBL As ClsOperaciones.RECEIVABLE_LIST_LINE
                Dim dt_detalle As DataTable
                planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                clsBuscar = New ClsBuscar
                dt_detalle = New DataTable("DatosDocumento")
                'Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & TipoDocRef & "' AND NUMBER_DOC='" & NumDocRef & "'"
                Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & tipoDoc & "' AND NUMBER_DOC='" & numeroDoc & "'"
                dt_detalle = clsBuscar.MostrandoDescripcion(Consulta)
                If dt_detalle.Rows.Count() <> 0 Then
                    Dim Moneda_Cartera As String = String.Empty
                    Dim TipoD_Cartera As String = String.Empty

                    Moneda_Cartera = dt_detalle.Rows(0).Item("CURRENCY_ID")
                    TipoD_Cartera = dt_detalle.Rows(0).Item("DOCUMENT_ID")
                    If TipoD_Cartera <> "NC" Then
                        If Moneda_Cartera = "ME" Then
                            If MonDoc = "ME" Then
                                MontodoC = MontodoC
                            Else
                                MontodoC = MontodoC / Tipo_Cambio_Detalle ' ClsVarComun.TCCompra
                            End If
                        ElseIf Moneda_Cartera = "MN" Then
                            If MonDoc = "MN" Then
                                MontodoC = MontodoC
                            Else
                                MontodoC = MontodoC * Tipo_Cambio_Detalle ' ClsVarComun.TCVenta
                            End If
                        End If
                    Else
                        If Moneda_Cartera = "ME" Then
                            If MonDoc = "ME" Then
                                MontodoC = (Math.Abs(MontodoC)) * -1
                            Else
                                MontodoC = (Math.Abs(MontodoC / Tipo_Cambio_Detalle)) * -1 ' ClsVarComun.TCCompra)) * -1
                            End If
                        ElseIf Moneda_Cartera = "MN" Then
                            If MonDoc = "MN" Then
                                MontodoC = (Math.Abs(MontodoC)) * -1
                            Else
                                MontodoC = (Math.Abs(MontodoC * Tipo_Cambio_Detalle)) * -1 ' ClsVarComun.TCVenta)) * -1
                            End If
                        End If
                    End If
                    planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                    If planillaBL.ActualizacionDocumentosEliminados_CR(CodCliente, tipoDoc, numeroDoc, MontodoC) = True Then
                        'If TipoDocCobranza = "NC" Then
                        '    Dim MonedaNC As String = String.Empty
                        '    Consulta = String.Empty
                        '    dt_detalle = New DataTable("DatosNC")
                        '    Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & TipoDocCobranza & "' AND NUMBER_DOC='" & NumDocCobranza & "'"
                        '    dt_detalle = clsBuscar.MostrandoDescripcion(Consulta)
                        '    If dt_detalle.Rows.Count() <> 0 Then
                        '        MonedaNC = dt_detalle.Rows(0).Item("CURRENCY_ID")
                        '        If MonedaNC = "ME" Then
                        '            If MonDoc = "ME" Then
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value)
                        '            Else
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value) / Tipo_Cambio_Detalle ' ClsVarComun.TCCompra
                        '            End If
                        '        ElseIf MonedaNC = "MN" Then
                        '            If MonDoc = "MN" Then
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value)
                        '            Else
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value) * Tipo_Cambio_Detalle ' ClsVarComun.TCVenta
                        '            End If
                        '        End If
                        '        planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                        '        If planillaBL.ActualizacionDocumentosEliminados(CodCliente, TipoDocCobranza, NumDocCobranza, (Math.Abs(CDbl(MontodoC))) * -1) = False Then
                        '            MsgBox("Error al restaurar valor de la NC aplicada. Verifique!", MsgBoxStyle.Critical, "Sistemas")
                        '            Exit Sub
                        '        End If
                        '    End If
                        'ElseIf Concepto_Cobro = "23" Or Concepto_Cobro = "24" Then
                        '    Dim MonedaNC As String = String.Empty
                        '    Consulta = String.Empty
                        '    dt_detalle = New DataTable("DatosNC")
                        '    Consulta = "SELECT * FROM DBO.CUSTOMER_BALANCE_PAY  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & TipoDocCobranza & "' AND NUMBER_DOC='" & NumDocCobranza & "'"
                        '    dt_detalle = clsBuscar.MostrandoDescripcion(Consulta)
                        '    If dt_detalle.Rows.Count() <> 0 Then
                        '        MonedaNC = dt_detalle.Rows(0).Item("CURRENCY_ID")
                        '        If MonedaNC = "ME" Then
                        '            If MonDoc = "ME" Then
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value)
                        '            Else
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value) / Tipo_Cambio_Detalle ' ClsVarComun.TCCompra
                        '            End If
                        '        ElseIf MonedaNC = "MN" Then
                        '            If MonDoc = "MN" Then
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value)
                        '            Else
                        '                MontodoC = CDbl(dgv_detalles.CurrentRow.Cells("AMOUNT").Value) * Tipo_Cambio_Detalle ' ClsVarComun.TCVenta
                        '            End If
                        '        End If
                        '        planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                        '        If planillaBL.ActualizacionDocumentosEliminados_FP(CodCliente, TipoDocCobranza, NumDocCobranza, Math.Abs(CDbl(MontodoC))) = False Then
                        '            MsgBox("Error al restaurar valor de la FP aplicada. Verifique!", MsgBoxStyle.Critical, "Sistemas")
                        '            Exit Sub
                        '        End If
                        '    End If
                        'End If
                        planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                        If planillaBL.EliminarDetallesPlanillas_CR(txt_numero_planilla.Text, Item, tipoDoc, numeroDoc) = True Then
                            MsgBox("Eliminado Correctamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("Error de eliminacion.", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Error al restaurar el valor del Documento. Verifique!", MsgBoxStyle.Critical)
                    End If
                End If

                Editar_Planilla()
            End If


        End If
    End Sub

    Private Sub dgv_pendientes_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgv_pendientes.CellValidating
        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString) Then
                e.Cancel = True
            End If
        End If
    End Sub


    'Private Sub txtnumDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumDoc.KeyDown
    '    'If cmb_tipo_doc.SelectedValue = "NC" Then
    '    '    If e.KeyCode = Keys.Enter Then
    '    '        If dgv_pendientes.CurrentRow Is Nothing Then Exit Sub
    '    '        For Each row As DataGridViewRow In dgv_pendientes.Rows
    '    '            If row.Cells(0).Value = True Then
    '    '                If row.Cells("COL_DOCUMENT_ID").Value = "NC" Then
    '    '                    MessageBox.Show("Debe marcar con un check un TipoDoc diferente a Nota Credito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    '                    Exit Sub
    '    '                End If
    '    '            End If
    '    '        Next
    '    '        If txtserieDoc.Text = String.Empty Then
    '    '            MsgBox("Debe ingresar la serie del documento.", MsgBoxStyle.Information)
    '    '            txtserieDoc.Focus()
    '    '            Exit Sub
    '    '        ElseIf txtnumDoc.Text = String.Empty Then
    '    '            MsgBox("Debe ingresar el Nro del documento.", MsgBoxStyle.Information)
    '    '            txtnumDoc.Focus()
    '    '            Exit Sub
    '    '        ElseIf txt_cod_ane.Text = String.Empty Then
    '    '            MessageBox.Show("Seleccione un cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    '            txt_cod_ane.Focus()
    '    '            Exit Sub
    '    '        End If
    '    '        Dim estado As Boolean = False
    '    '        For Each row As DataGridViewRow In dgv_pendientes.Rows
    '    '            If row.Cells(0).Value = True Then
    '    '                estado = True
    '    '                Exit For
    '    '            End If
    '    '        Next
    '    '        If estado = False Then
    '    '            MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    '            dgv_pendientes.Focus()
    '    '            Exit Sub
    '    '        End If
    '    '        VerficarNotaC()
    '    '    End If
    '    'End If
    'End Sub

    Private Function VerficarNotaC() As Boolean
        Try
            txtnumDoc.Text = String.Format("{0:0000000}", CInt(txtnumDoc.Text.Trim))
            'txtnumDoc.Text =txtnumDoc.Text
            Dim planillaBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim dt_detalle As DataTable
            dt_detalle = New DataTable
            dt_detalle = planillaBL.VerificandoNumeracionDocumentosNC(txt_cod_ane.Text, txtserieDoc.Text & txtnumDoc.Text)
            If dt_detalle.Rows.Count() <> 0 Then
                txtnumDoc.Text = Strings.Right(dt_detalle.Rows(0).Item("NUMBER_DOC").ToString, 7)
                txtmonto.Text = dt_detalle.Rows(0).Item("AMOUNT_BALANCE").ToString
                txtmonto.Select()
            Else
                MsgBox("No hay informacion con el Nro. documento especificado, verifique.", MsgBoxStyle.Information)
                txtserieDoc.Text = String.Empty
                txtnumDoc.Text = String.Empty
                txtmonto.Text = 0
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If STRorden = "" Then
            Dim wbusqueda As String = UCase(txtFiltro.Text)
            Dim myCurrencyManager As CurrencyManager
            myCurrencyManager = CType(Me.BindingContext(dtvD), CurrencyManager)
            Dim INTnewpos As Integer
            dtvD.RowFilter = STRorden & " like '%" & txtbuscar.Text & "%'"
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtvD.Count & " registros"
        End If

    End Sub

    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtbuscar.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ImprimirVoucher(ByRef _DOCUMENT_ID As String, ByRef _NUMERO_CR As String)
        Try
            ''Imprimiendo
            If MessageBox.Show("¿Desea imprimir el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA_ASIENTO")
                Dim SQL As String = String.Empty
                SQL = "SELECT *  FROM DBO.CO_TB_ASIENTO_CAB WHERE AC_IDSUBDIARIO = '14'   AND AC_IDPLANILLA ='" & _DOCUMENT_ID & "' AND AC_NUMERO_CR='" & _NUMERO_CR & "' "
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
                MsgBox("No hay planillas para Contabilizar.", MsgBoxStyle.Critical)
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

            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim ClsCobranzaBl As New ClsOperaciones.RECEIVABLE_LIST
            Dim dt_detalle As DataTable = Nothing
            dt_detalle = New DataTable
            dt_detalle = planillaBL.get_Detalle_Cobros_CR(_CODIGO_PLANILLA)
            If dt_detalle.Rows.Count() <> 0 Then
                Me.Cursor = Cursors.WaitCursor

                Dim fecha As DateTime = DateTime.Parse(_FECHA_PLANILLA)

                For I As Integer = 0 To dt_detalle.Rows.Count - 1
                    Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
                    _NUMERACION = String.Empty
                    _NUMERACION = ac.get_Ult_num_voucher("14", fecha.Year, Format(fecha.Month, "00"))
                    ac = Nothing


                    If ClsCobranzaBl.Contabilizar_Caja_Cobranzas_CR(_CODIGO_PLANILLA, CDate(_FECHA_PLANILLA), _NUMERACION, dt_detalle.Rows(I).Item("NUMERO").ToString) = True Then
                        MsgBox("Retención contabilizada correctamente." & Chr(13) & "CR N° " & dt_detalle.Rows(I).Item("NUMERO").ToString, MsgBoxStyle.Information)
                        ImprimirVoucher(_CODIGO_PLANILLA, dt_detalle.Rows(I).Item("NUMERO").ToString)
                    Else
                        MsgBox("Error al contabilizar Retención." & Chr(13) & "CR N° " & dt_detalle.Rows(I).Item("NUMERO").ToString, MsgBoxStyle.Critical)
                        Continue For
                    End If
                Next

                ClsCobranzaBl.Actualiza_Estado_Planilla_CR(_CODIGO_PLANILLA)

                btn_consultar_Click(sender, e)
                dgv_planillas.Focus()
            Else
                Me.Cursor = Cursors.Default
                MsgBox("La Planilla no tiene detalles. Verifique!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_TipoDoc(ByVal texto As TextBox, Optional ByVal _Codigo As String = "")
        Try
            If _Codigo = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CX_SP_S_TIPO_DOC"
                frm.CadenaConsulta = sql
                frm.Titulo = "Vendedor"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString & " : " & frm.Data_Matriz.Rows(0).Item(1).ToString

                End If
                frm.Close()
            Else
                Dim clsCobranzaBl As New ClsOperaciones.RECEIVABLE_LIST
                Dim dtDetalleCob As New DataTable
                dtDetalleCob = clsCobranzaBl.ManualTipoDocumento(_Codigo)
                If dtDetalleCob.Rows.Count() <> 0 Then
                    texto.Text = dtDetalleCob.Rows(0).Item(0) & " : " & dtDetalleCob.Rows(0).Item(1)
                Else
                    MsgBox("No hay informacion con el Codigo especificado.", MsgBoxStyle.Critical)
                    texto.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Lista_Anticipos(ByVal texto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_ANTICIPOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Anticipos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString & frm.Data_Matriz.Rows(0).Item(2).ToString
            End If
            frm.Close()
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


    Private Sub txtdocRefBancos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtdocRefBancos.MouseDoubleClick
        Ayuda_TipoDoc(txtdocRefBancos)
    End Sub

    Private Sub txtdocRefBancos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocRefBancos.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDoc(txtdocRefBancos)
        If e.KeyCode = Keys.Enter Then
            If txtdocRefBancos.Text = String.Empty Then
                Ayuda_TipoDoc(txtdocRefBancos)
            Else
                Ayuda_TipoDoc(txtdocRefBancos, txtdocRefBancos.Text)
            End If
        End If
    End Sub

    Private Sub txt_efectivo_doc_Ref_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_efectivo_doc_Ref.MouseDoubleClick
        Ayuda_TipoDoc(txt_efectivo_doc_Ref)
    End Sub

    Private Sub txt_efectivo_doc_Ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_efectivo_doc_Ref.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDoc(txt_efectivo_doc_Ref)
        If e.KeyCode = Keys.Enter Then
            If txt_efectivo_doc_Ref.Text = String.Empty Then
                Ayuda_TipoDoc(txt_efectivo_doc_Ref)
            Else
                Ayuda_TipoDoc(txt_efectivo_doc_Ref, txt_efectivo_doc_Ref.Text)
            End If
        End If
    End Sub

    Private Sub cmb_tipo_cob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_glosa.KeyPress, txt_cta_conta.KeyPress, txt_cod_mon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txt_cta_conta.Text = "" Then
                MsgBox("Debe ingresar el numero de cuenta", MsgBoxStyle.Information)
                txt_cta_conta.Text = String.Empty
                txt_cta_conta.Focus()
                cmb_tipo_cob.SelectedIndex = -1
                Exit Sub
            Else
                Try
                    Dim planillaBL As ClsOperaciones.RECEIVABLE_LIST_LINE
                    planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                    Dim dt_detalle As DataTable
                    Dim _indice As Integer
                    Dim _id_cod As String
                    dt_detalle = New DataTable
                    dt_detalle = planillaBL.VerificandoBancodeCuenta(txt_cta_conta.Text)
                    If dt_detalle.Rows.Count() <> 0 Then
                        _id_cod = dt_detalle.Rows(0).Item("RECEIVE_ID").ToString
                        cmb_tipo_cob.SelectedValue = _id_cod
                    Else
                        MsgBox("No hay informacion con el Nro. de cuenta especificado, verifique.", MsgBoxStyle.Information)
                        cmb_tipo_cob.SelectedIndex = -1
                        txt_cta_conta.Text = String.Empty
                        txt_cta_conta.Focus()
                        Exit Sub
                    End If
                    'SendKeys.Send("{TAB}")
                    If gb_aplidoc.Enabled = True Then
                        cmb_tipo_doc.Focus()
                    ElseIf gb_banco.Enabled = True Then
                        cmb_banco.Focus()
                    ElseIf gb_Efectivo.Enabled = True Then
                        txt_efectivo_doc_Ref.Focus()
                    ElseIf gb_aplicacionSaldos.Enabled = True Then
                        txtreferenciaSaldo.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub cmb_tipo_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_tipo_doc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtserieDoc.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_banco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_banco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then cmb_cta_cte.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_efectivo_doc_Ref_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_efectivo_doc_Ref.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtEfectoNumerodocRef.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        For i As Integer = 0 To dgv_pendientes.RowCount - 1
            dgv_pendientes.Rows(i).Cells("chk_sel").Value = chktodos.Checked
            '    _total_pago = _total_pago + Val(dgv_pendientes.Rows(i).Cells("COL_SALDO").Value)
        Next
        Call Sumar_Marcados()
    End Sub

    Private Sub dgv_pendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellContentClick

    End Sub

    Private Sub dgv_pendientes_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_pendientes.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgv_pendientes.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgv_pendientes.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgv_pendientes_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellValueChanged
        If e.ColumnIndex = 0 Then
            Sumar_Marcados()
        End If
    End Sub

    Private Sub txtnumDoc_Leave(sender As Object, e As EventArgs) Handles txtnumDoc.Leave

    End Sub

    Private Sub txtserieDoc_Leave(sender As Object, e As EventArgs) Handles txtserieDoc.Leave
        'If cmb_tipo_doc.SelectedValue <> "FP" Then
        '    If txtserieDoc.Text.Trim().Length > 0 Then
        '        txtserieDoc.Text = txtserieDoc.Text.PadLeft(3, Char.Parse("0"))
        '    End If
        'End If

    End Sub

    Private Sub btn_elimianr_planilla_Click(sender As Object, e As EventArgs) Handles btn_elimianr_planilla.Click
        If dgv_planillas.RowCount() = 0 Then Exit Sub
        If dgv_planillas.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Se va a eliminar la PLANILLA elegida" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtValidacion As DataTable, _genera_validacion_al_eliminar As String = String.Empty
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion("PLA", "000")
            If dtValidacion.Rows.Count > 0 Then
                _genera_validacion_al_eliminar = dtValidacion.Rows(0).Item("IS_DELETE_PLANILLA_COBROS").ToString
            End If
            If _genera_validacion_al_eliminar = "S" Then
                opt_planilla_detalle = "P"
                gb_pas_elimina_planilla.Visible = True
                tc_planilla.Enabled = False
                ToolStrip1.Enabled = False
                txtpassword.Text = ""
                txtpassword.Focus()
            Else
                Dim PlanillaBl As New ClsOperaciones.RECEIVABLE_LIST
                Dim DTRESULTADOS As DataTable
                DTRESULTADOS = New DataTable
                DTRESULTADOS = PlanillaBl.EliminarPlanilla_CR(dgv_planillas.Item(0, dgv_planillas.CurrentRow.Index).Value)
                If DTRESULTADOS.Rows.Count() <> 0 Then
                    MsgBox("No se puede eliminar la Planilla", MsgBoxStyle.Exclamation)
                Else
                    btn_consultar_Click(sender, e)
                    dgv_planillas.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub dgv_pendientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_pendientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tipo_cambio_detalle_cr.Focus()
        End If
    End Sub

    Private Sub Ayuda_CuentaContable(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            If _CodigoCuentaContable = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CO_SP_S_PLANCTAS_MOV"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = Date.Now.Year
                frm.Titulo = "Plan de Cuentas Contable"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cta_conta.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                End If
            Else
                Dim AsientoContableCabs As New LibContabilidad.ClsOperaciones.Asiento_Contable
                Dim DtDatos As DataTable
                DtDatos = New DataTable("CuentaContable")
                DtDatos = AsientoContableCabs.Get_ManualCuentaContable(_CodigoCuentaContable)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    txt_cta_conta.Text = DtDatos.Rows(0).Item(0).ToString
                Else
                    Dim frm As New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "CO_SP_S_PLANCTAS_MOV"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = Date.Now.Year
                    frm.Titulo = "Plan de Cuentas Contable"
                    frm._Cadena_Filtro = _CodigoCuentaContable
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        txt_cta_conta.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_cta_conta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_conta.MouseDoubleClick
        Ayuda_CuentaContable()
    End Sub

    Private Sub txt_cta_conta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_conta.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_CuentaContable()
        If e.KeyCode = Keys.Enter Then
            If txt_cta_conta.Text = String.Empty Then
                Ayuda_CuentaContable()
            Else
                Ayuda_CuentaContable(txt_cta_conta.Text)
            End If
        End If
    End Sub
    Private Sub frm_CX_LT_PlanillaCobs_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.X Then
            If MessageBox.Show("Se va a Cerrar el Formualario" & vbCrLf & "¿Desea continuar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_planilla_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_planilla.Selecting
        If Not tc_planilla.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtreferenciaSaldo_DoubleClick(sender As Object, e As EventArgs) Handles txtreferenciaSaldo.DoubleClick
        Ayuda_TipoDoc(txtreferenciaSaldo)
        If Strings.Left(txtreferenciaSaldo.Text, 2) = "AN" Then
            txtnumerosaldo.ReadOnly = True
        Else
            txtnumerosaldo.ReadOnly = False
        End If
    End Sub

    Private Sub txtreferenciaSaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtreferenciaSaldo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDoc(txtreferenciaSaldo)
        If Strings.Left(txtreferenciaSaldo.Text, 2) = "AN" Then
            txtnumerosaldo.ReadOnly = True
        Else
            txtnumerosaldo.ReadOnly = False
        End If
        If e.KeyCode = Keys.Enter Then
            If txtreferenciaSaldo.Text = String.Empty Then
                Ayuda_TipoDoc(txtreferenciaSaldo)
            Else
                Ayuda_TipoDoc(txtreferenciaSaldo, txtreferenciaSaldo.Text)
            End If
            If Strings.Left(txtreferenciaSaldo.Text, 2) = "AN" Then
                txtnumerosaldo.ReadOnly = True
            Else
                txtnumerosaldo.ReadOnly = False
            End If
        End If

    End Sub

    Private Sub txtreferenciaSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreferenciaSaldo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtnumerosaldo.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnumerosaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerosaldo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btn_grabar_det.Focus() ' SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_edit_pla_Click(sender As Object, e As EventArgs) Handles btn_edit_pla.Click
        If dgv_planillas.Rows.Count() = 0 Then
            MsgBox("No hay ninguna Planilla para editar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        CONTROLES(True, 1)
        CheckBox1.Checked = False
        Editar_Planilla()
        Sumar_Montos_DetPlanilla()
        btn_nuevo_det.Enabled = Not _FLAG_CONTA
        btnEliminarRegistro.Enabled = Not _FLAG_CONTA
        btn_gen_cob_contado.Enabled = Not _FLAG_CONTA
        Button5.Enabled = Not _FLAG_CONTA
        CheckBox1.Enabled = Not _FLAG_CONTA
        btn_nuevo_det.Select()
    End Sub

    Private Sub txt_cod_ane_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_ane.MouseDoubleClick
        Ayuda_Clientes()
    End Sub

    Private Sub gb_Efectivo_Enter(sender As Object, e As EventArgs) Handles gb_Efectivo.Enter
    End Sub


    Private Sub optrangocobro_CheckedChanged(sender As Object, e As EventArgs) Handles optrangocobro.CheckedChanged
        If optrangocobro.Checked = True Then
            GroupBox6.Visible = True
            GroupBox8.Visible = False
        End If
    End Sub

    Private Sub optexcel_CheckedChanged(sender As Object, e As EventArgs) Handles optexcel.CheckedChanged
        If optexcel.Checked = True Then
            GroupBox8.Visible = True
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub optexcel_Click(sender As Object, e As EventArgs) Handles optexcel.Click
        checkTodos.Checked = False
        MostrarDocumentosPendiente_Cliente()
        txtFiltro.Text = String.Empty
        If optexcel.Checked = True Then
            GroupBox8.Visible = True
            GroupBox6.Visible = False
        End If
    End Sub
    Private Sub MostrarDocumentosPendiente_Cliente()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalleClientes = New DataTable
            dtvcliente = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.MostrandoClientesDocPendientes()
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtvcliente = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtvcliente
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))

            dtDocumentosPrincipal.Columns.Add("CUSTOMER_ID", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NAME", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("VAT_REGISTRATION", Type.GetType("System.Double"))
            dgvDocumentos.DataSource = Nothing
            dgvDocumentos.DataSource = dtDocumentosPrincipal
            dgvDocumentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDocumentos.Columns(0).Width = 40
            dgvDocumentos.Columns(0).ReadOnly = False
            dgvDocumentos.Columns(0).HeaderText = "SELEC"
            dgvDocumentos.Columns(1).Width = 100
            dgvDocumentos.Columns(1).ReadOnly = True
            dgvDocumentos.Columns(1).HeaderText = "Codigo"
            dgvDocumentos.Columns(2).Width = 300
            dgvDocumentos.Columns(2).ReadOnly = True
            dgvDocumentos.Columns(2).HeaderText = "Proveedor"
            dgvDocumentos.Columns(3).Width = 120
            dgvDocumentos.Columns(3).ReadOnly = True
            dgvDocumentos.Columns(3).HeaderText = "Ruc"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        If checkTodos.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=False")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = True
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.WaitCursor
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = False
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dgvDocumentos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDocumentos.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvDocumentos.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim sel_proveedor As String = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString
            For Each row As DataRow In dtDocumentosPrincipal.Select("CUSTOMER_ID='" & sel_proveedor & "' ")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = True
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gb_ListaCab.Enabled = False
        dgv_planillas.Enabled = False
        Panel1.Visible = True
        optrangocobro.Checked = True
        optrangocobro.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        gb_ListaCab.Enabled = True
        dgv_planillas.Enabled = True
        dgv_planillas.Select()
    End Sub

    Private Sub txtfiltrocliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfiltrocliente.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtfiltrocliente.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
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
        Dim Estado As Boolean = False
        Dim _codigo_planilla As String
        If optrangocobro.Checked = True Then
            If MsgBox("Desea imprimir solo el registro seleccionado." & Chr(13) & _
                    "Si presiona sobre no," & Chr(13) & _
                    "se imprimiran todos los registros.", vbInformation + vbYesNo) = vbYes Then
                If dgv_planillas.Columns.Count > 0 Then
                    _codigo_planilla = dgv_planillas.Item(0, dgv_planillas.CurrentRow.Index).Value
                Else
                    _codigo_planilla = ""
                End If
                If _codigo_planilla = "" Then
                    MsgBox("No selecciono ninguna Planilla.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                ImprimirDocumentosPendientes(_codigo_planilla, 1)
            Else
                _codigo_planilla = ""
                ImprimirDocumentosPendientes(_codigo_planilla, 0)
            End If
        ElseIf optexcel.Checked = True Then
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                Estado = True
                Exit For
            Next
            If Estado = False Then
                MsgBox("No selecciono ningun Registro.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim _Codigo As String = String.Empty
            If checkTodos.Checked = True Then
                ImprimirDocumentosPendientes("", 1)
            Else
                For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                    _Codigo = _Codigo & """" & row("CUSTOMER_ID").ToString() & """" & ","
                Next
                If _Codigo.Length() <> 0 Then
                    _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
                    ImprimirDocumentosPendientes(_Codigo, 0)
                End If
            End If


        End If
    End Sub
    Private Sub ImprimirDocumentosPendientes(ByVal _Codigo As String, ByVal _OPCION As Integer)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtDatosCompany As DataTable
            Me.Cursor = Cursors.WaitCursor
            If optrangocobro.Checked = True Then
                dtImprimir = New DataTable("Planilla")
                dtImprimir = reporteBL.EjecutarReporte_PLanilla_Cobranza_CR(_Codigo, _OPCION)
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                If dtImprimir.Rows.Count() <> 0 Then
                    If optresumido.Checked = True Then
                        crystalBL.Muestra_Reporte("REP_PLA_COB_RESUMIDO.rpt", dtImprimir, "", "", _
                                                  "@cod;" & _Codigo, "@TIP;" & _OPCION, _
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                  "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    ElseIf optdetallado.Checked = True Then
                        crystalBL.Muestra_Reporte("REP_PLA_COB_DETALLADO.rpt", dtImprimir, "", "", _
                                                  "@cod;" & _Codigo, "@TIP;" & _OPCION, _
                                                  "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                  "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    End If
                Else
                    MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
                End If
            ElseIf optexcel.Checked = True Then
                dtImprimir = New DataTable("Clientes")
                dtImprimir = reporteBL.EjecutarReporte_Plan_Cob_Cliente_Codigo_CR(_Codigo, _OPCION)
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("REP_PLA_COB_CLIENTE.rpt", dtImprimir, "", "", _
                                              "@codigo;" & _Codigo, "@TIP;" & _OPCION, _
                                              "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                              "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                Else
                    MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtfiltrocliente_TextChanged_1(sender As Object, e As EventArgs) Handles txtfiltrocliente.TextChanged
        Dim wbusqueda As String = UCase(txtfiltrocliente.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtvcliente), CurrencyManager)
        Dim INTnewpos As Integer
        dtvcliente.RowFilter = STRorden & " like '%" & txtfiltrocliente.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtvcliente.Count & " registros"
    End Sub

    Private Sub txtnumerosaldo_DoubleClick(sender As Object, e As EventArgs) Handles txtnumerosaldo.DoubleClick
        Ayuda_Lista_Anticipos(txtnumerosaldo)
    End Sub

    Private Sub txtnumerosaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumerosaldo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Lista_Anticipos(txtnumerosaldo)
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                Dim dtValidacion As DataTable
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtValidacion = New DataTable("Validacion")
                dtValidacion = clsFacturaBl.Get_Validacion_Doc_Cobro(Strings.Left(Trim(txtreferenciaSaldo.Text), 2), Trim(txtnumerosaldo.Text))
                If dtValidacion.Rows.Count > 0 Then
                    MessageBox.Show("El documento de Referencia ingresado, se encuentra " & vbNewLine & "registrado en el Sistema, ingrese el número correcto!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtnumerosaldo.Text = ""
                    txtnumerosaldo.Focus()
                Else
                    btn_grabar_det.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtpassword.Text = String.Empty Then
            MessageBox.Show("Debe ingresar un contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpassword.Focus()
            Exit Sub
        End If
        If ValidarUsuariosIngreso() = True Then
            If opt_planilla_detalle = "P" Then
                Dim PlanillaBl As New ClsOperaciones.RECEIVABLE_LIST
                Dim DTRESULTADOS As DataTable
                DTRESULTADOS = New DataTable
                DTRESULTADOS = PlanillaBl.EliminarPlanilla(dgv_planillas.Item(0, dgv_planillas.CurrentRow.Index).Value)
                If DTRESULTADOS.Rows.Count() <> 0 Then
                    MsgBox("No se puede eliminar la Planilla", MsgBoxStyle.Information)
                Else
                    gb_pas_elimina_planilla.Visible = False
                    tc_planilla.Enabled = True
                    ToolStrip1.Enabled = True
                    btn_consultar_Click(sender, e)
                    dgv_planillas.Focus()
                End If
            ElseIf opt_planilla_detalle = "D" Then
                If dgv_detalles.CurrentRow Is Nothing Then Exit Sub
                If txt_numero_planilla.Text = String.Empty Then Exit Sub
                Dim CodCliente As String = String.Empty
                Dim tipoDoc As String = String.Empty
                Dim TipoDocRef As String = String.Empty
                Dim numeroDoc As String = String.Empty
                Dim NumDocRef As String = String.Empty
                Dim CodigoPlanilla As String = String.Empty
                Dim Item As String = String.Empty
                Dim MonDoc As String = String.Empty
                Dim Consulta As String = String.Empty
                Dim MontodoC As Double = 0
                Dim TipoDocCobranza As String = String.Empty
                Dim NumDocCobranza As String = String.Empty

                CodigoPlanilla = dgv_detalles.Item(0, dgv_detalles.CurrentRow.Index).Value
                Item = Format(dgv_detalles.Item(1, dgv_detalles.CurrentRow.Index).Value, "000")
                tipoDoc = dgv_detalles.Item(3, dgv_detalles.CurrentRow.Index).Value
                numeroDoc = dgv_detalles.Item(4, dgv_detalles.CurrentRow.Index).Value
                CodCliente = dgv_detalles.Item(5, dgv_detalles.CurrentRow.Index).Value
                MonDoc = dgv_detalles.Item(9, dgv_detalles.CurrentRow.Index).Value
                MontodoC = dgv_detalles.Item(10, dgv_detalles.CurrentRow.Index).Value

                TipoDocRef = IIf(IsDBNull(dgv_detalles.Item(11, dgv_detalles.CurrentRow.Index).Value), "", dgv_detalles.Item(11, dgv_detalles.CurrentRow.Index).Value)
                NumDocRef = IIf(IsDBNull(dgv_detalles.Item(12, dgv_detalles.CurrentRow.Index).Value), "", dgv_detalles.Item(12, dgv_detalles.CurrentRow.Index).Value)
                TipoDocCobranza = dgv_detalles.Item(17, dgv_detalles.CurrentRow.Index).Value
                NumDocCobranza = dgv_detalles.Item(18, dgv_detalles.CurrentRow.Index).Value
                If CodigoPlanilla = String.Empty Or Item = String.Empty Or tipoDoc = String.Empty Or numeroDoc = String.Empty Then Exit Sub
                Dim planillaBL As ClsOperaciones.RECEIVABLE_LIST_LINE
                Dim dt_detalle As DataTable
                planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                clsBuscar = New ClsBuscar
                dt_detalle = New DataTable("DatosDocumento")
                'Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & TipoDocRef & "' AND NUMBER_DOC='" & NumDocRef & "'"
                Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & tipoDoc & "' AND NUMBER_DOC='" & numeroDoc & "'"
                dt_detalle = clsBuscar.MostrandoDescripcion(Consulta)
                If dt_detalle.Rows.Count() <> 0 Then
                    Dim Moneda As String = String.Empty
                    Dim TipoD As String = String.Empty

                    Moneda = dt_detalle.Rows(0).Item("CURRENCY_ID")
                    TipoD = dt_detalle.Rows(0).Item("DOCUMENT_ID")
                    If TipoD <> "NC" Then
                        If Moneda = "ME" Then
                            If MonDoc = "ME" Then
                                MontodoC = MontodoC
                            Else
                                MontodoC = MontodoC / ClsVarComun.TCCompra
                            End If
                        ElseIf Moneda = "MN" Then
                            If MonDoc = "MN" Then
                                MontodoC = MontodoC
                            Else
                                MontodoC = MontodoC * ClsVarComun.TCVenta
                            End If
                        End If
                    Else
                        If Moneda = "ME" Then
                            If MonDoc = "ME" Then
                                MontodoC = (Math.Abs(MontodoC)) * -1
                            Else
                                MontodoC = (Math.Abs(MontodoC / ClsVarComun.TCCompra)) * -1
                            End If
                        ElseIf Moneda = "MN" Then
                            If MonDoc = "MN" Then
                                MontodoC = (Math.Abs(MontodoC)) * -1
                            Else
                                MontodoC = (Math.Abs(MontodoC * ClsVarComun.TCVenta)) * -1
                            End If
                        End If
                    End If
                    planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                    If planillaBL.ActualizacionDocumentosEliminados(CodCliente, tipoDoc, numeroDoc, MontodoC) = True Then
                        If TipoDocCobranza = "NC" Then
                            Dim MonedaNC As String = String.Empty
                            Consulta = String.Empty
                            dt_detalle = New DataTable("DatosNC")
                            Consulta = "SELECT * FROM CUSTOMER_BALANCE  WHERE CUSTOMER_ID= '" & CodCliente & "' AND DOCUMENT_ID='" & TipoDocCobranza & "' AND NUMBER_DOC='" & NumDocCobranza & "'"
                            dt_detalle = clsBuscar.MostrandoDescripcion(Consulta)
                            If dt_detalle.Rows.Count() <> 0 Then
                                MonedaNC = dt_detalle.Rows(0).Item("CURRENCY_ID")
                                If MonedaNC = "ME" Then
                                    If MonDoc = "ME" Then
                                        MontodoC = MontodoC
                                    Else
                                        MontodoC = MontodoC / ClsVarComun.TCCompra
                                    End If
                                ElseIf MonedaNC = "MN" Then
                                    If MonDoc = "MN" Then
                                        MontodoC = MontodoC
                                    Else
                                        MontodoC = MontodoC * ClsVarComun.TCVenta
                                    End If
                                End If
                                planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                                If planillaBL.ActualizacionDocumentosEliminados(CodCliente, TipoDocCobranza, NumDocCobranza, (Math.Abs(CDbl(MontodoC))) * -1) = True Then

                                End If
                            End If
                        End If
                        planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                        If planillaBL.EliminarDetallesPlanillas(txt_numero_planilla.Text, Item, tipoDoc, numeroDoc) = True Then
                            MsgBox("Eliminado Correctamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("Error de eliminacion", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Error de eliminacion", MsgBoxStyle.Critical)
                    End If
                End If

                'planillaBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                'dt_detalle = New DataTable
                'dt_detalle = planillaBL.get_planilla_Det_xID(txt_numero_planilla.Text)
                'If dt_detalle.Rows.Count() <> 0 Then
                '    dgv_detalles.DataSource = Nothing
                '    dgv_detalles.DataSource = dt_detalle
                'Else
                '    dgv_detalles.DataSource = Nothing
                'End If
                gb_pas_elimina_planilla.Visible = False
                tc_planilla.Enabled = True
                ToolStrip1.Enabled = True
                dgv_detalles.Focus()
                Editar_Planilla()
            End If

        Else
            txtpassword.Text = ""
            txtpassword.Focus()
        End If
    End Sub
    Private Function ValidarUsuariosIngreso() As Boolean
        Dim estado As Boolean = True
        Dim STRUserSys As String, STRPassSys As String
        Try
            ClsUsuarioBl = New LibSeguridad.ClsUsuario
            ClsData = New LibConexion.ClsData
            dtUsuarioAcceso = New DataTable
            Dim codigoUsuario As String = String.Empty
            codigoUsuario = "admin"
            dtUsuarioAcceso = ClsUsuarioBl.ValidarUsuariosIngresos(codigoUsuario)
            If dtUsuarioAcceso.Rows.Count() <> 0 Then
                If ClsUsuarioBl.ESTADO = "N" Then
                    MessageBox.Show("El estado del usuario ingresado se encuentra Inactivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estado = False
                    Exit Try
                Else
                    STRUserSys = ClsUsuarioBl.CODUSUARIO
                    STRPassSys = ClsUsuarioBl.PASSUSUARIO
                    STRPassSys = ClsData.DesEncryptString(STRPassSys)
                    If txtpassword.Text = STRPassSys Then
                        estado = True
                        Exit Try
                    ElseIf txtpassword.Text <> STRPassSys Then
                        MessageBox.Show("El password ingresado es incorrecto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = False
                        Exit Try
                    End If
                End If
            Else
                MessageBox.Show("El Usuario ingresado es incorrecto o no Existe, Verifique.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gb_pas_elimina_planilla.Visible = False
        tc_planilla.Enabled = True
        ToolStrip1.Enabled = True
        'dgv_planillas.Focus()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub

    Private Sub txt_num_ref_ban_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_ref_ban.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dtValidacion As DataTable
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion_Doc_Cobro(Strings.Left(Trim(txtdocRefBancos.Text), 2), Trim(txt_num_ref_ban.Text))
            If dtValidacion.Rows.Count > 0 Then
                MessageBox.Show("El documento de Referencia ingresado, se encuentra " & vbNewLine & "registrado en el Sistema. Verifique!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_num_ref_ban.Text = ""
                txt_comisiones.Focus()
            Else
                txt_comisiones.Focus()
            End If
        End If
    End Sub

    Private Sub txtEfectoNumerodocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectoNumerodocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dtValidacion As DataTable
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtValidacion = New DataTable("Validacion")
            dtValidacion = clsFacturaBl.Get_Validacion_Doc_Cobro(Strings.Left(Trim(txt_efectivo_doc_Ref.Text), 2), Trim(txtEfectoNumerodocRef.Text))
            If dtValidacion.Rows.Count > 0 Then
                MessageBox.Show("El documento de Referencia ingresado, se encuentra " & vbNewLine & "registrado en el Sistema, ingrese el número correcto!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEfectoNumerodocRef.Text = ""
                txtEfectoNumerodocRef.Focus()
            Else
                btn_grabar_det.Focus()
            End If
        End If
    End Sub


    Private Sub txtnumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumDoc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtmonto_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_cta_cte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_cta_cte.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtdocRefBancos.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtdocRefBancos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdocRefBancos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txt_num_ref_ban.Focus() 'SendKeys.Send("{TAB}")
    End Sub


    Private Sub txtEfectoNumerodocRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectoNumerodocRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btn_grabar_det.Focus() 'SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_gen_cob_contado_Click(sender As Object, e As EventArgs) Handles btn_gen_cob_contado.Click

        If MessageBox.Show("Se va a Generar la Cobranza al Contado" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
            planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
            Dim planilladetBE As ClsEntidades.RECEIVABLE_LIST_LINE
            Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LIST_LINE)
            Dim fecha_puente As Date
            Dim dtTipoCamb_tc As DataTable
            Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
            fecha_puente = dgv_planillas.Item(1, dgv_planillas.CurrentRow.Index).Value

            dtTipoCamb_tc = cl.get_VerificarCob_Contado(fecha_puente)
            If dtTipoCamb_tc.Rows.Count() <> 0 Then
                Me.Cursor = Cursors.WaitCursor

                For i As Integer = 0 To dtTipoCamb_tc.Rows.Count - 1
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE

                    With planilladetBE
                        .ID = txt_numero_planilla.Text.Trim
                        .ITEM = 0
                        .TYPE_DOC = dtTipoCamb_tc.Rows(i).Item("DOCUMENT_ID").ToString
                        .NUMBER_DOC = dtTipoCamb_tc.Rows(i).Item("NUMBER_DOC").ToString
                        .TYPE_OPERATION = "F"
                        If dtTipoCamb_tc.Rows(i).Item("CURRENCY_ID").ToString = "MN" Then
                            .REC_ID = "17"
                        Else
                            .REC_ID = "25"
                        End If
                        .DATE_PLA = fecha_puente
                        .AMOUNT = dtTipoCamb_tc.Rows(i).Item("AMOUNT_BALANCE").ToString
                        .CURRENCY_ID = dtTipoCamb_tc.Rows(i).Item("CURRENCY_ID").ToString
                        .SELL_RATE = Math.Round(tipo_cambio_planilla, 3)
                        .CREATE_DATE = Now.Date.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .COMMENT = "" 'txt_glosa.Text.Trim
                        .SALES_ID = dtTipoCamb_tc.Rows(i).Item("SALES_ID").ToString
                        .BANK_ID = String.Empty
                        .BANK_DESCRIPTION = String.Empty
                        .DOC_REF = String.Empty
                        .NUM_REF = String.Empty
                        .BANK_BUSSINESS_ID = String.Empty
                        .ACCOUNT_BANK_CHECK = String.Empty
                        .LIST_ID = 0
                        .IS_CASH_BANK = "0"
                        .AMOUNT_PER = 0
                        .PAY_AUTO = 0
                        .ANNEX_ID_AUX = dtTipoCamb_tc.Rows(i).Item("CUSTOMER_ID").ToString 'txt_cod_ane.Text
                        .DOCUMET_ID = dtTipoCamb_tc.Rows(i).Item("DOCUMENT_ID").ToString
                        .NUMBER_SERIE = dtTipoCamb_tc.Rows(i).Item("SERIE_AUX").ToString
                        .NUMBER_DOCUMENT = dtTipoCamb_tc.Rows(i).Item("NUM_DOC_AUX").ToString
                        .MEDIOS_PAGO = 0
                        .DATE_REF = ""
                        .AMOUNT_ITF = 0
                    End With
                    ls_detalle.Add(planilladetBE)
                Next

                planilladetBL.Insert_Cob_Contado(ls_detalle, txt_cod_mon.Text, FechaActualPlanilla)
                planilladetBL = Nothing

                MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information, "Sistemas")
                Editar_Planilla()
                Sumar_Montos_DetPlanilla()

                Me.Cursor = Cursors.Default

            Else
                MsgBox("No existe Cobranza al contado para la planilla elegida.", MsgBoxStyle.Information, "Sistema")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If


        End If




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

    Private Sub mtb_fecha_aplic_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fecha_aplic_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsDate(mtb_fecha_aplic_doc.Text) = False Then
                MsgBox(" La Fecha Ingresada no posee un formato Correcto. ", MsgBoxStyle.Information, "Error al ingresar la fecha ")
                mtb_fecha_aplic_doc.Select()
                Exit Sub
            End If
            btn_grabar_det.Focus()
        End If
    End Sub

    Private Sub txtmonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fecha_aplic_doc.Focus()
        End If
    End Sub

    Private Sub txtnumDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumDoc.KeyDown
        'If e.KeyCode = Keys.F1 Then Ayuda_Facturas_Proveedor(txtserieDoc, txtnumDoc)
        If e.KeyCode = Keys.Enter Then
            txtmonto.Focus()
        End If

    End Sub

    Private Sub txtserieDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserieDoc.KeyDown
        'If e.KeyCode = Keys.F1 Then Ayuda_Facturas_Proveedor(txtserieDoc, txtnumDoc)
        If e.KeyCode = Keys.Enter Then
            txtnumDoc.Focus()
        End If
    End Sub

    Private Sub txt_itf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_itf.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_itf_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_itf.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_det.Focus()
        End If
    End Sub

    Private Sub txt_comisiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_comisiones.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_comisiones_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comisiones.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_itf.Focus()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_tc_planilla.ReadOnly = False
        Else
            txt_tc_planilla.ReadOnly = True
        End If
    End Sub

    Private Sub txt_tc_planilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tc_planilla.KeyPress
        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If

        If Not Char.IsPunctuation(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            If Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("Seguro de actualizar el Tipo de Cambio de la Planilla?" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim planilladetBL As ClsOperaciones.RECEIVABLE_LIST_LINE
                planilladetBL = New ClsOperaciones.RECEIVABLE_LIST_LINE
                Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LIST_LINE)
                Dim cl As LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
                cl = New LibCobranzas.ClsOperaciones.CURRENCY_EXCHANGE
                Dim tc_puente As Double = CDbl(txt_tc_planilla.Text.Trim)
                Me.Cursor = Cursors.WaitCursor
                planilladetBL.Actualizar_Tipo_Cambio_Planilla_Cobro(txt_numero_planilla.Text.Trim, CDbl(txt_tc_planilla.Text.Trim))
                planilladetBL = Nothing
                MsgBox("Actualización correcta.", MsgBoxStyle.Information, "Sistemas")
                Editar_Planilla()
                CheckBox1.Checked = False
                txt_tc_planilla.ReadOnly = True
                'txt_tc_planilla.Text = dgv_planillas.CurrentRow.Cells("TIPO_CAMBIO").Value
                txt_tc_planilla.Text = Format(Double.Parse(tc_puente), "##,##0.000")
                tipo_cambio_planilla = CDbl(txt_tc_planilla.Text)

                'Sumar_Montos_DetPlanilla()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If dgv_detalles.RowCount = 0 Then Exit Sub
        'If dgv_detalles.CurrentRow Is Nothing Then Exit Sub

        gb_sumatoria_ref.Visible = True
        Sumatoria_Planilla_Referencia()
        GroupBox4.Enabled = False
        dgv_detalles.Enabled = False
    End Sub

    Private Sub Sumatoria_Planilla_Referencia()
        Try
            If dgv_planillas.RowCount = 0 Then Exit Sub
            Dim planillaBL As New ClsOperaciones.RECEIVABLE_LIST_LINE_PAY
            Dim dt_detalle_sumatoria As DataTable = Nothing
            Dim num_planilla As String = ""
            num_planilla = dgv_planillas.CurrentRow.Cells("PLANILLA").Value.ToString

            dt_detalle_sumatoria = New DataTable
            dt_detalle_sumatoria = planillaBL.get_planilla_Sumatoria_Ref_Pago_Cliente_CR(num_planilla)
            dgv_sumatoria_ref.DataSource = Nothing
            If dt_detalle_sumatoria.Rows.Count() <> 0 Then
                dgv_sumatoria_ref.DataSource = dt_detalle_sumatoria
                dgv_sumatoria_ref.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv_sumatoria_ref.AutoResizeColumns()
                dgv_sumatoria_ref.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgv_sumatoria_ref.Columns(0).HeaderText = "Tip. Doc. Ref."
                dgv_sumatoria_ref.Columns(1).HeaderText = "Num. Ref."
                dgv_sumatoria_ref.Columns(2).HeaderText = "Moneda"
                dgv_sumatoria_ref.Columns(3).HeaderText = "Monto"

                dgv_sumatoria_ref.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                dgv_sumatoria_ref.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Else
                dgv_sumatoria_ref.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_sumatoria_ref_Click(sender As Object, e As EventArgs) Handles btn_salir_sumatoria_ref.Click
        gb_sumatoria_ref.Visible = False

        GroupBox4.Enabled = True
        dgv_detalles.Enabled = True
    End Sub

    Private Sub txtnumDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtnumDoc.MouseDoubleClick
        'Ayuda_Facturas_Proveedor(txtserieDoc, txtnumDoc)
    End Sub

    Private Sub txtserieDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtserieDoc.MouseDoubleClick
        'Ayuda_Facturas_Proveedor(txtserieDoc, txtnumDoc)
    End Sub

    Private Sub Ayuda_Facturas_Proveedor(ByVal texto As TextBox, ByVal texto_dos As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_FACTURAS_PROVEEDOR"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_ane.Text.Trim
            frm.Titulo = "Lista de Facturas de Proveedor"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                tipo_doc_aplica_fp = frm.Data_Matriz.Rows(0).Item(0).ToString
                texto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                texto_dos.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtmonto.Text = frm.Data_Matriz.Rows(0).Item(6).ToString
                mtb_fecha_aplic_doc.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        For i As Integer = 0 To tc_planilla.TabPages.Count() - 1
            tc_planilla.TabPages(i).Enabled = False
        Next
        If _indice = 0 Then
            ToolStrip1.Enabled = True
        Else
            ToolStrip1.Enabled = False
        End If
        tc_planilla.TabPages(_indice).Enabled = opcion
        tc_planilla.SelectTab(_indice)
    End Sub

    Private Sub Ayuda_Clientes(Optional ByVal _CodigoRuc As String = "")
        Try
            'Opcion  C AS BUSQUEDA POR CODIGO, R BUSQUEDA POR RUC ..
            If _CodigoRuc = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CX_SP_S_CLIENTES"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cod_ane.Text = frm.Data_Matriz.Rows(0).Item(0).ToString 'frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_des_ane.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    If txt_cod_ane.Text <> String.Empty Then
                        Cargar_Documentos_Pendientes()
                        dgv_pendientes.Focus()
                    End If
                End If
                frm.Close()
            Else
                clsClienteBl = New ClsOperaciones.RECEIVABLE_LIST
                dtDetalleTerceros = New DataTable("Clientes_RUC")
                dtDetalleTerceros = clsClienteBl.ManualClienteRuc(_CodigoRuc)
                If dtDetalleTerceros.Rows.Count() <> 0 Then
                    txt_cod_ane.Text = dtDetalleTerceros.Rows(0).Item(2).ToString
                    txt_des_ane.Text = dtDetalleTerceros.Rows(0).Item(1).ToString
                    If txt_cod_ane.Text <> String.Empty Then
                        Cargar_Documentos_Pendientes()
                        dgv_pendientes.Focus()
                    End If
                Else
                    Dim frm As New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "CX_SP_S_CLIENTES"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Clientes"
                    frm._Cadena_Filtro = _CodigoRuc
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        txt_cod_ane.Text = frm.Data_Matriz.Rows(0).Item(0).ToString 'frm.Data_Matriz.Rows(0).Item(0).ToString
                        txt_des_ane.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                        If txt_cod_ane.Text <> String.Empty Then
                            Cargar_Documentos_Pendientes()
                            dgv_pendientes.Focus()
                        End If
                    End If
                    frm.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna  
        Dim columna As Integer = dgv_pendientes.CurrentCell.ColumnIndex

        If columna = 1 Or columna = 2 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ".") And (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgv_pendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellClick
        Call Sumar_Marcados()
    End Sub

    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
   ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgv_pendientes.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
    End Sub

    Private Sub txtbuscar_TextAlignChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextAlignChanged

    End Sub


    Private Sub txt_tipo_cambio_detalle_cr_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_cambio_detalle_cr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cta_conta.Focus()
        End If
    End Sub

    Private Sub txt_tipo_cambio_detalle_cr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tipo_cambio_detalle_cr.KeyPress
        If Not Char.IsPunctuation(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            If Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_tipo_cambio_detalle_cr_Leave(sender As Object, e As EventArgs) Handles txt_tipo_cambio_detalle_cr.Leave
        If txt_tipo_cambio_detalle_cr.Text = String.Empty Then
            MessageBox.Show("Debe Ingresar un Tipo de Cambio.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_tipo_cambio_detalle_cr.Focus()
            Exit Sub
        End If
        If CDbl(txt_tipo_cambio_detalle_cr.Text) = 0 Then
            MessageBox.Show("Debe Ingresar un Tipo de Cambio diferente de cero.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_tipo_cambio_detalle_cr.Focus()
            Exit Sub
        End If
    End Sub
End Class