Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing

Public Class frm_CO_LT_IngVoucher
    Dim TipoAnexo As String = String.Empty
    Dim tipoAnexoDet As Integer = 0
    Dim bol_edicion_Det As Boolean = False
    Public bol_edicion_Asiento As Boolean = False
    Public Flag_Estado_Fin As Boolean = False
    Public viene_de_compras As String
    Public id_compras As String

    Dim AsientoContableCabs As ClsOperaciones.Asiento_Contable
    Dim DtDetallesAsientoC As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim DtDatos As DataTable

    Dim dtdetalleAsiento As DataTable

    Public Sub GenerarColummnaDataTableAsientoContable()
        Try
            dtdetalleAsiento = New DataTable
            dtdetalleAsiento.Columns.Add("AD_IDCAB", Type.GetType("System.Int64")) '0
            dtdetalleAsiento.Columns.Add("AD_SECUENCIA", Type.GetType("System.Int64")) '1
            dtdetalleAsiento.Columns.Add("AD_CUENTA", Type.GetType("System.String")) '2
            dtdetalleAsiento.Columns.Add("DESC_CUENTA", Type.GetType("System.String")) '3
            dtdetalleAsiento.Columns.Add("AD_TANEXO", Type.GetType("System.Int64")) '4
            dtdetalleAsiento.Columns.Add("AD_IDANEXO", Type.GetType("System.String")) '5
            dtdetalleAsiento.Columns.Add("AD_TDOC", Type.GetType("System.String")) '6
            dtdetalleAsiento.Columns.Add("AD_SDOC", Type.GetType("System.String")) '7'
            dtdetalleAsiento.Columns.Add("AD_NDOC", Type.GetType("System.String")) '8
            dtdetalleAsiento.Columns.Add("AD_FDOC", Type.GetType("System.String")) '9
            dtdetalleAsiento.Columns.Add("AD_VDOC", Type.GetType("System.String")) '10'
            dtdetalleAsiento.Columns.Add("AD_DEBE", Type.GetType("System.Double")) '11'
            dtdetalleAsiento.Columns.Add("AD_HABER", Type.GetType("System.Double")) '12
            dtdetalleAsiento.Columns.Add("AD_TCAM", Type.GetType("System.Double")) '13'
            dtdetalleAsiento.Columns.Add("AD_SEC_ORI_DES", Type.GetType("System.Int64")) '14
            dtdetalleAsiento.Columns.Add("AD_IDCC", Type.GetType("System.String")) '15
            dtdetalleAsiento.Columns.Add("AD_ES_DESTINO", Type.GetType("System.Int64")) '16
            dtdetalleAsiento.Columns.Add("AD_IDMEDIOPAGO", Type.GetType("System.String")) '17
            dtdetalleAsiento.Columns.Add("AD_MONTO_ORI", Type.GetType("System.Double")) '18
            dtdetalleAsiento.Columns.Add("AD_PORCE_DESTINO", Type.GetType("System.Double")) '19
            dtdetalleAsiento.Columns.Add("AD_ES_CONCI", Type.GetType("System.Double")) '20
            dtdetalleAsiento.Columns.Add("AD_MES_CONCI", Type.GetType("System.Double")) '21
            dtdetalleAsiento.Columns.Add("AD_ES_INAFECTO", Type.GetType("System.Double")) '22
            dtdetalleAsiento.Columns.Add("AD_IDMONEDA", Type.GetType("System.Int64")) '23'
            dtdetalleAsiento.Columns.Add("AD_TDOC_REF", Type.GetType("System.String")) '24
            dtdetalleAsiento.Columns.Add("AD_SDOC_REF", Type.GetType("System.String")) '25
            dtdetalleAsiento.Columns.Add("AD_NDOC_REF", Type.GetType("System.String")) '26
            dtdetalleAsiento.Columns.Add("AD_FDOC_REF", Type.GetType("System.String")) '27
            dtdetalleAsiento.Columns.Add("AD_VDOC_REF", Type.GetType("System.String")) '28
            dtdetalleAsiento.Columns.Add("AD_GLOSA", Type.GetType("System.String")) '29
            dtdetalleAsiento.Columns.Add("AD_PERCEN_DETRACC", Type.GetType("System.Int64")) '30
            dtdetalleAsiento.Columns.Add("AD_CEN_COS", Type.GetType("System.String")) '31
            dtdetalleAsiento.PrimaryKey = New DataColumn() {dtdetalleAsiento.Columns("AD_SECUENCIA")}
            dgvDetalleAsiento.DataSource = Nothing
            ConfigurarGrillas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ConfigurarGrillas()
        Dim dt_Configurado As DataTable = dtdetalleAsiento
        dt_Configurado.DefaultView.RowFilter = "AD_SEC_ORI_DES=0"
        dt_Configurado.DefaultView.Sort = "AD_SECUENCIA ASC"
        dgvDetalleAsiento.DataSource = dt_Configurado
        For i As Integer = 0 To dtdetalleAsiento.Columns.Count() - 1
            dgvDetalleAsiento.Columns(i).Visible = False
            dgvDetalleAsiento.Columns(i).ReadOnly = True
        Next

        dgvDetalleAsiento.Columns(3).Width = 140
        dgvDetalleAsiento.Columns(29).Width = 240
        dgvDetalleAsiento.Columns(3).Width = 140
        dgvDetalleAsiento.Columns(5).Width = 80
        dgvDetalleAsiento.Columns(6).Width = 30
        dgvDetalleAsiento.Columns(7).Width = 40
        dgvDetalleAsiento.Columns(9).Width = 80
        dgvDetalleAsiento.Columns(2).Visible = True
        dgvDetalleAsiento.Columns(3).Visible = True

        dgvDetalleAsiento.Columns(6).Visible = True
        dgvDetalleAsiento.Columns(7).Visible = True
        dgvDetalleAsiento.Columns(8).Visible = True
        dgvDetalleAsiento.Columns(9).Visible = True


        dgvDetalleAsiento.Columns(5).Visible = True
        dgvDetalleAsiento.Columns(11).Visible = True
        dgvDetalleAsiento.Columns(12).Visible = True
        dgvDetalleAsiento.Columns(29).Visible = True
        dgvDetalleAsiento.Columns("AD_CEN_COS").Visible = True
        dgvDetalleAsiento.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleAsiento.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgvDetalleAsiento.Columns(11).DefaultCellStyle.Format = "##,##0.00"
        dgvDetalleAsiento.Columns(12).DefaultCellStyle.Format = "##,##0.00"

        dgvDetalleAsiento.Columns(2).HeaderText = "Cuenta Contable"
        dgvDetalleAsiento.Columns(3).HeaderText = "Descripcion Cuenta"
        dgvDetalleAsiento.Columns(6).HeaderText = "Tipo"
        dgvDetalleAsiento.Columns(7).HeaderText = "Serie"
        dgvDetalleAsiento.Columns(8).HeaderText = "Numero Documento"
        dgvDetalleAsiento.Columns(9).HeaderText = "Fecha"

        dgvDetalleAsiento.Columns(5).HeaderText = "Anexo"
        dgvDetalleAsiento.Columns(11).HeaderText = "Debe"
        dgvDetalleAsiento.Columns(12).HeaderText = "Haber"
        dgvDetalleAsiento.Columns(29).HeaderText = "Glosa"
        dgvDetalleAsiento.Columns("AD_CEN_COS").HeaderText = "Centro de Costos"
        If dgvDetalleAsiento.Rows.Count() <> 0 Then
            dgvDetalleAsiento.CurrentCell = dgvDetalleAsiento.Rows(dgvDetalleAsiento.Rows.Count - 1).Cells(2)
        End If
        ''dgvDetalleAsiento.Rows(dgvDetalleAsiento.Rows.Count - 1).Selected = True

    End Sub

    Private Sub Blank()
        Try
            txtcodigoRuc.Text = String.Empty
            txtdescripciontercero.Text = String.Empty
            txtTipoDoc.Text = String.Empty
            txtSerieDoc.Text = String.Empty
            txtNumeroDoc.Text = String.Empty
            dtpFechaDoc.Value = Date.Now
            dtpFechaVencimientoDoc.Value = Date.Now
            txtMontoIgv.Text = String.Empty
            txtTasa.Text = String.Empty
            txtMontoDoc.Text = String.Empty
            txtTipoDocRef.Text = String.Empty
            txtSerieDocRef.Text = String.Empty
            txtNumDocRef.Text = String.Empty
            txtFechaDocRef.Value = Date.Now
            txtTipoCambio.Text = String.Empty
            dtpFecha_PLE.Value = Date.Now
            chkdua.Checked = False
            txtDestino.Text = String.Empty
            txtdescripcionDestino.Text = String.Empty
            txtPorc_ISC.Text = String.Empty
            txtgravada.Text = String.Empty
            txt_ISC.Text = String.Empty
            txtPorc_Detrac.Text = String.Empty
            txtdetraccion.Text = String.Empty
            txtGlosaTransaccion.Text = String.Empty
            txt_glosa.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesCabecera() As Boolean
        Dim estado As Boolean = True
        Try
            If cmb_ope.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar una Operacion.", MsgBoxStyle.Information)
                cmb_ope.Focus()
                estado = False
                Exit Try
            End If
            If TipoAnexo = String.Empty Then
                MsgBox("No se asigno el Tipo de Anexo para esta transaccion.", MsgBoxStyle.Critical)
                estado = False
                btnTipoAnexo.Focus()
                Exit Try
            End If
            If txtcodigoRuc.Text = String.Empty Then
                MsgBox("Debe seleccionar el Ruc.", MsgBoxStyle.Information)
                estado = False
                txtcodigoRuc.Focus()
                Exit Try
            End If

            If bol_edicion_Asiento = False Then
                If txtTipoDoc.Text = String.Empty Then
                    MsgBox("Debe ingresar un Tipo de Documento.", MsgBoxStyle.Information)
                    txtTipoDoc.Focus()
                    estado = False
                    Exit Try
                ElseIf txtSerieDoc.Text = String.Empty Then
                    MsgBox("Debe ingresar una serie para el  Documento.", MsgBoxStyle.Information)
                    txtSerieDoc.Focus()
                    estado = False
                    Exit Try
                ElseIf txtNumeroDoc.Text = String.Empty Then
                    MsgBox("Debe ingresar un numero de Documento.", MsgBoxStyle.Information)
                    txtNumeroDoc.Focus()
                    estado = False
                    Exit Try
                End If
                If txtMontoIgv.Text = String.Empty Then
                    MsgBox("Debe ingresar el monto del Igv.", MsgBoxStyle.Information)
                    txtMontoIgv.Focus()
                    estado = False
                    Exit Try
                ElseIf txtTasa.Text = String.Empty Then
                    MsgBox("Debe ingresar una tasa.", MsgBoxStyle.Information)
                    txtTasa.Focus()
                    estado = False
                    Exit Try
                ElseIf txtMontoDoc.Text = String.Empty Then
                    MsgBox("Debe ingresar el Monto del Documento.", MsgBoxStyle.Information)
                    txtMontoDoc.Focus()
                    estado = False
                    Exit Try
                End If
                If txtTipoCambio.Text = String.Empty Then
                    MsgBox("No se cargo el dato del Tipo de Cambio.", MsgBoxStyle.Critical)
                    txtTipoCambio.Focus()
                    estado = False
                    Exit Try
                End If
            End If

            If Verificar_Apertura_Cierre_Modulos(dtp_fec_vou.Value.Month, dtp_fec_vou.Value.Year) = False Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As ClsOperaciones.Asiento_Contable
            VentasBl = New ClsOperaciones.Asiento_Contable
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "CONTABILIDAD")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar el Asiento Contable.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub frm_CO_LT_IngVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bol_edicion_Asiento Then
            Me.Text = "Voucher (Edicion)"
            If Flag_Estado_Fin = True Then
                'If cmb_ope.SelectedValue = 1 And cmb_sub.SelectedValue = "01" Then
                pnlFinalizarCompra.Visible = False
                gbCabecera.Enabled = False

                If txtdetraccion.Text <> "" Then
                    If CDbl(txtdetraccion.Text) > 0 Then
                        btn_act_detrac.Visible = True
                        gbCabecera.Enabled = True
                        btn_nuevo.Enabled = False
                    Else
                        btn_act_detrac.Visible = False
                    End If
                Else
                    btn_act_detrac.Visible = False
                End If
                ' End If
            Else
                'If cmb_ope.SelectedValue = 1 And cmb_sub.SelectedValue = "01" Then
                pnlFinalizarCompra.Visible = True
                ' Else
                'pnlFinalizarCompra.Visible = False
                'End If
                gbCabecera.Enabled = True
            End If
        Else
            GenerarColummnaDataTableAsientoContable()
            Me.Text = "Voucher (Nuevo) "
            bol_edicion_Asiento = False
            Call Cargar_Combos()
            Cargar_Moneda()
            ParametrosSistema()
            Call Iniciar()
            txtTipoCambio.Text = ClsVarComun.TCVenta
            cmb_ope.Select()
        End If
        If bol_edicion_Asiento = True Then
            txtcodigoRuc.Select()
        Else
            cmb_ope.Focus()
        End If

    End Sub

    Private Sub ParametrosSistema()
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TasaIgv")
            Dim Sql = String.Empty
            Sql = "SELECT * FROM  PARAMETERS"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                txtTasa.Text = DtDetallesAsientoC.Rows(0).Item("AMOUNT_TAX").ToString
            Else
                MsgBox("No se asigno la tasa del IGV. Verifique.", MsgBoxStyle.Critical)
                txtTasa.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CO_TB_MONEDA
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "MO_CODIGO"
        cboMoneda.DisplayMember = "MO_ABRE"
        AsientoContableCabs = Nothing
    End Sub

    Private Sub Cargar_Combos()
        Try
            Dim ope As New ClsOperaciones.CO_TB_OPERACION
            Dim dtOperaciones As DataTable
            dtOperaciones = New DataTable
            dtOperaciones = ope.get_Operaciones()
            cmb_ope.DisplayMember = "OP_DESCRIPCION"
            cmb_ope.ValueMember = "OP_ID"
            cmb_ope.DataSource = dtOperaciones
            ope = Nothing

            Dim fq As ClsOperaciones.freeQuery
            fq = New ClsOperaciones.freeQuery
            dtOperaciones = New DataTable("CentoCosto")
            dtOperaciones = fq.get_Centro_Costo()
            cmb_cc.DisplayMember = "DESCRIPCION"
            cmb_cc.ValueMember = "CODIGO"
            cmb_cc.DataSource = dtOperaciones
            fq = Nothing

            Dim mo As New ClsOperaciones.CO_TB_MONEDA
            dtOperaciones = New DataTable("Moneda")
            dtOperaciones = mo.get_Monedas()
            cmb_moneda.DisplayMember = "MO_ABRE"
            cmb_moneda.ValueMember = "MO_CODIGO"
            cmb_moneda.DataSource = dtOperaciones
            mo = Nothing

            Dim mp As New ClsOperaciones.CO_TB_MEDIOPAGO
            dtOperaciones = New DataTable("Medios")
            dtOperaciones = mp.get_Medios()
            cmb_mp.DisplayMember = "MP_DESCRIPCION"
            cmb_mp.ValueMember = "MP_CODIGO"
            cmb_mp.DataSource = dtOperaciones
            mp = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Private Sub Iniciar()
        gb_ref.Visible = False
        cmb_ope.Enabled = True
        cmb_sub.Enabled = True
        dtp_fec_vou.Text = Date.Now
        mtb_tc.Text = ""
        txt_glosa.Text = ""
        btn_ref.Enabled = False
        cmb_ope.SelectedIndex = -1
        cmb_sub.SelectedIndex = -1
        txtCuentaContable.Text = String.Empty
        cmb_mp.SelectedIndex = -1
        cmb_cc.SelectedIndex = -1
        cmb_moneda.SelectedValue = 1
        txtTipoDocAsiento.Text = String.Empty
        btn_grabar.Enabled = True
        gb_detalle_doc.Enabled = True
        btn_cancelar.Text = "Cancelar"
    End Sub

    Public Sub Cargar_Asiento_Editar(oper_ As Integer, id_ As Integer, sub_ As String, ayo_ As Integer, mes_ As Integer)
        Try
            Dim ds_Asiento As DataSet
            Dim DtAsientoDetalle As DataTable
            Dim ac As ClsOperaciones.Asiento_Contable
            ac = New ClsOperaciones.Asiento_Contable
            ds_Asiento = ac.get_Lista_Asientos_Edit(id_, sub_, ayo_, mes_)
            ac = Nothing
            For Each ff As DataRow In ds_Asiento.Tables(0).Rows
                Call Cargar_Combos()
                Cargar_Moneda()
                txt_idcab.Text = ff("AC_ID").ToString()
                cmb_ope.SelectedIndex = 0
                cmb_ope.SelectedValue = oper_
                cmb_sub.SelectedValue = ff("AC_IDSUBDIARIO").ToString()
                If Mid(sub_, 1, 2) = "CO" Then
                    txt_num_vou.Text = txt_num_vou.Text 'ff("AC_NUM_VOUCHER").ToString()
                Else
                    txt_num_vou.Text = ff("AC_NUM_VOUCHER").ToString()
                End If
                dtp_fec_vou.Text = ff("AC_FEC_VOUCHER").ToString()
                txt_glosa.Text = ff("AC_GLOSA_VOU").ToString()
                cboMoneda.SelectedValue = ff("AC_IDMONEDA").ToString()
                txtcodigoRuc.Text = ff("AC_RUC").ToString()
                Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero, txtcodigoRuc.Text)
                txtTipoDoc.Text = ff("AC_TIPO_DOC").ToString()
                txtSerieDoc.Text = ff("AC_SER_DOC").ToString()
                txtNumeroDoc.Text = ff("AC_NUM_DOC").ToString()
                dtpFechaDoc.Value = IIf(ff("AC_FEC_DOC").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC").ToString())
                dtpFechaVencimientoDoc.Value = IIf(ff("AC_FEC_DOC_VENCE").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC_VENCE").ToString())
                txtMontoIgv.Text = Format(CDbl(IIf(ff("AC_VAL_IGV").ToString() = String.Empty, 0, ff("AC_VAL_IGV").ToString())), "##,##0.00")
                Dim Igv As Double = 0.0
                Igv = txtMontoIgv.Text
                txtMontoIgv.Text = Format(Igv, "##,##0.00")
                txtTasa.Text = Format(CDbl(IIf(ff("AC_POR_IGV").ToString() = String.Empty, 0, ff("AC_POR_IGV").ToString())), "##,##0.00")
                txtMontoDoc.Text = Format(CDbl(IIf(ff("AC_TOTAL_DOC").ToString() = String.Empty, 0, ff("AC_TOTAL_DOC").ToString())), "##,##0.00")
                txtTipoDocRef.Text = ff("AC_TIPO_DOC_REF").ToString()
                txtSerieDocRef.Text = ff("AC_SER_DOC_REF").ToString()
                txtNumDocRef.Text = ff("AC_NUM_DOC_REF").ToString()
                txtFechaDocRef.Value = IIf(ff("AC_FEC_DOC_REF").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC_REF").ToString())
                txtTipoCambio.Text = Format(CDbl(ff("AC_TIPO_CAMBIO").ToString()), "##,##0.000")
                dtpFecha_PLE.Value = IIf(ff("AC_FEC_PLE").ToString() = String.Empty, Date.Now, ff("AC_FEC_PLE").ToString())
                chkdua.Checked = IIf(ff("AC_DUA").ToString() = 0, False, True)
                txtDestino.Text = ff("AC_DESTINO").ToString()
                Ayuda_Destinos(txtDestino.Text)
                txtPorc_ISC.Text = Format(CDbl(ff("AC_POR_ISC").ToString()), "##,##0.00")
                txt_ISC.Text = Format(CDbl(ff("AC_ISC").ToString()), "##,##0.00")
                txtPorc_Detrac.Text = Format(CDbl(ff("AC_POR_DETRAC").ToString()), "##,##0.00")
                txtdetraccion.Text = Format(CDbl(ff("AC_DETRAC").ToString()), "##,##0.00")
                txtGlosaTransaccion.Text = ff("AC_GLOSA_VOU").ToString() 'ff("AC_GLOSA_TRANSACCION").ToString()
                txt_glosa.Text = ff("AC_GLOSA_VOU").ToString()
                txtInafecta.Text = Format(CDbl(IIf(ff("AC_OP_INAFECTA").ToString() = String.Empty, 0, ff("AC_OP_INAFECTA").ToString())), "##,##0.00")
                txtgravada.Text = Format(CDbl(IIf(ff("AC_OP_GRAVADA").ToString() = String.Empty, 0, ff("AC_OP_GRAVADA").ToString())), "##,##0.00")

                txt_tipo_doc_detrac.Text = ff("AC_TIPO_DOC_DETRAC").ToString()
                txt_ser_doc_detrac.Text = ""
                txt_num_doc_detrac.Text = ff("AC_NUM_DOC_DETRAC").ToString()
                dtp_fec_detrac.Value = ff("AC_FEC_DOC_DETRAC").ToString()
                DatosTipoAnexo()
            Next
            ac = New ClsOperaciones.Asiento_Contable
            DtAsientoDetalle = New DataTable
            DtAsientoDetalle = ac.get_Lista_Asientos_Detalles_Edit(id_, ayo_, mes_)
            If DtAsientoDetalle.Rows.Count() <> 0 Then
                GenerarColummnaDataTableAsientoContable()
                For Each ff As DataRow In DtAsientoDetalle.Rows
                    Ingresar_Fila_Modo_edicion(ff("AD_SECUENCIA").ToString(), ff("AD_CUENTA").ToString(), ff("PC_DES_CTA").ToString, Integer.Parse(ff("AD_TANEXO").ToString()), ff("AD_IDANEXO").ToString(), _
                                       ff("AD_TDOC").ToString(), ff("AD_SDOC").ToString(), ff("AD_NDOC").ToString(), ff("AD_FDOC").ToString(), ff("AD_VDOC").ToString(), _
                                       Double.Parse(ff("AD_DEBE").ToString()), Double.Parse(ff("AD_HABER").ToString()), Double.Parse(ff("AD_MONTO_ORI").ToString()), _
                                       Double.Parse(ff("AD_TCAM").ToString()), ff("AD_IDCC").ToString(), ff("AD_IDMEDIOPAGO").ToString(), _
                                       Integer.Parse(ff("AD_IDMONEDA").ToString()), 0, 0, Integer.Parse(ff("AD_ES_INAFECTO").ToString()), _
                                       ff("AD_TDOC_REF").ToString(), ff("AD_SDOC_REF").ToString(), ff("AD_NDOC_REF").ToString(), ff("AD_FDOC_REF").ToString(), _
                                       ff("AD_VDOC_REF").ToString(), "", Integer.Parse(ff("AD_SEC_ORI_DES").ToString()), ff("AD_GLOSA").ToString(), _
                                       IIf(ff("AD_PERCEN_DETRACC").ToString = "", 0, ff("AD_PERCEN_DETRACC")), IIf(ff("AD_CEN_COS").ToString = "", "", ff("AD_CEN_COS")))
                Next
            Else
                GenerarColummnaDataTableAsientoContable()
            End If
            ConfigurarGrillas()
            Call Sumar_Totales()
            gb_ref.Visible = False
            btn_ref.Enabled = False
            btn_grabar.Enabled = True
            gb_detalle_doc.Enabled = True
            btn_cancelar.Text = "Cancelar"
            cmb_ope.Enabled = False
            cmb_sub.Enabled = False
            dtp_fec_vou.Enabled = False
            ds_Asiento = Nothing
            txtCuentaContable.Text = String.Empty
            cmb_mp.SelectedIndex = -1
            cmb_cc.SelectedIndex = -1
            txtTipoDocAsiento.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Numero_Voucher()
        If cmb_sub.SelectedIndex <> -1 Then
            Dim fecha As DateTime = DateTime.Parse(dtp_fec_vou.Value)
            Dim ac As New ClsOperaciones.Asiento_Contable
            txt_num_vou.Text = ac.get_Ult_num_voucher(cmb_sub.SelectedValue.ToString(), fecha.Year, Format(fecha.Month, "00"))
            ac = Nothing
        End If
    End Sub

    Private Sub DatosTipoAnexo()
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("DatosTipoAnexo")
            Dim Sql = String.Empty
            Sql = "SELECT * FROM CO_TB_SUBDIARIO WHERE SD_IDOPERACION='" & cmb_ope.SelectedValue.ToString & "'"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("SD_TIPO_ANEX").ToString) Then
                    MsgBox("No se asigno el Tipo de Anexo para esta transaccion.", MsgBoxStyle.Critical)
                    TipoAnexo = String.Empty
                    Exit Sub
                Else
                    TipoAnexo = DtDetallesAsientoC.Rows(0).Item("SD_TIPO_ANEX").ToString
                End If
            Else
                MsgBox("No se asigno el Tipo de Anexo para esta transaccion.", MsgBoxStyle.Critical)
                TipoAnexo = String.Empty
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_ope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ope.SelectedIndexChanged
        If cmb_ope.SelectedIndex >= 0 Then
            Dim su As New ClsOperaciones.CO_TB_SUBDIARIO
            cmb_sub.DataSource = su.get_Subdiario_x_Ope(cmb_ope.SelectedValue)
            cmb_sub.DisplayMember = "SD_DESCRIPCION"
            cmb_sub.ValueMember = "SD_ID"
            su = Nothing
            cmb_sub.SelectedIndex = 0
            Call Cargar_Numero_Voucher()
            If bol_edicion_Asiento = False Then
                DatosTipoAnexo()
            End If
            Label21.Text = cmb_ope.Text
        End If
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If dgvDetalleAsiento.RowCount = 0 Then
            MessageBox.Show("Ingrese cuentas contables al asiento", "Revise")
            Exit Sub
        End If
        If mtb_dif.Text <> 0 Then
            MessageBox.Show("El asiento no cuadra", "Revise")
            If cmb_ope.SelectedValue.ToString().Equals("3") Then
                Call Agregar_Linea_Dif_Cambio()
            End If
            Exit Sub
        End If
        Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
        Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
        Dim asiento As New ClsOperaciones.Asiento_Contable
        If bol_edicion_Asiento = False Then
            If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Call Cargar_Numero_Voucher()
            Else
                Dim codigo As String = String.Empty
                codigo = InputBox("Ingrese numero de asiento")
                If codigo = String.Empty Then
                    MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                codigo = dtp_fec_vou.Value.Month.ToString.PadLeft(2, Char.Parse("0")) & codigo.PadLeft(5, Char.Parse("0"))
                Dim ClsasientoBl As New ClsOperaciones.Asiento_Contable
                Dim dtcodigo As New DataTable
                dtcodigo = ClsasientoBl.ValidarCodigo(cmb_sub.SelectedValue.ToString, codigo, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                If dtcodigo.Rows.Count() <> 0 Then
                    MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    txt_num_vou.Text = codigo
                End If
            End If
        End If
        If Not bol_edicion_Asiento Then
validar_numero:
            If asiento.Existe_Num_Voucher(txt_num_vou.Text, cmb_sub.SelectedValue.ToString(), DateTime.Parse(dtp_fec_vou.Text).Year, DateTime.Parse(dtp_fec_vou.Text).Month) Then
                txt_num_vou.Text = (Integer.Parse(txt_num_vou.Text) + 1).ToString()
                GoTo validar_numero
            End If
        End If
        ''Ingresando Datos de la Cabecera del Asiento Contable
        cab.AC_ID = 0
        If bol_edicion_Asiento Then
            cab.AC_ID = Int64.Parse(txt_idcab.Text)
        End If

        cab.AC_IDSUBDIARIO = cmb_sub.SelectedValue.ToString()
        cab.AC_NUM_VOUCHER = Integer.Parse(txt_num_vou.Text)
        cab.AC_ANHO = DateTime.Parse(dtp_fec_vou.Text).Year
        cab.AC_MES = DateTime.Parse(dtp_fec_vou.Text).Month
        cab.AC_FEC_VOUCHER = dtp_fec_vou.Text
        cab.AC_IDMONEDA = Integer.Parse(cboMoneda.SelectedValue.ToString())
        cab.AC_DEBE = Double.Parse(mtb_tot_d.Text)
        cab.AC_HABER = Double.Parse(mtb_tot_h.Text)
        cab.AC_ESTADO = 1
        cab.AC_GLOSA_VOU = txt_glosa.Text.Trim()
        cab.AC_ES_INTERFACE = 0
        cab.AC_IDPLANILLA = ""
        cab.AC_RUC = txtcodigoRuc.Text
        cab.AC_TIPO_DOC = txtTipoDoc.Text
        cab.AC_SER_DOC = txtSerieDoc.Text.PadLeft(5, Char.Parse("0"))
        cab.AC_NUM_DOC = txtNumeroDoc.Text.PadLeft(15, Char.Parse("0"))
        cab.AC_FEC_DOC = dtpFechaDoc.Value.ToShortDateString
        cab.AC_FEC_DOC_VENCE = dtpFechaVencimientoDoc.Value.ToShortDateString
        cab.AC_POR_IGV = IIf(txtTasa.Text = String.Empty, 0, txtTasa.Text)
        cab.AC_VAL_IGV = IIf(txtMontoIgv.Text = String.Empty, 0, txtMontoIgv.Text)
        cab.AC_TOTAL_DOC = txtMontoDoc.Text
        cab.AC_TIPO_CAMBIO = txtTipoCambio.Text
        cab.AC_GLOSA_TRANSACCION = txtGlosaTransaccion.Text
        cab.AC_DESTINO = txtDestino.Text
        cab.AC_POR_ISC = IIf(txtPorc_ISC.Text = String.Empty, 0, txtPorc_ISC.Text)
        cab.AC_ISC = IIf(txt_ISC.Text = String.Empty, 0, txt_ISC.Text)
        cab.AC_POR_DETRAC = IIf(txtPorc_Detrac.Text = String.Empty, 0, txtPorc_Detrac.Text)
        cab.AC_FEC_PLE = dtpFecha_PLE.Value.ToShortDateString
        cab.AC_TIPO_DOC_REF = txtTipoDocRef.Text
        cab.AC_SER_DOC_REF = txtSerieDocRef.Text.PadLeft(5, Char.Parse("0"))
        cab.AC_NUM_DOC_REF = txtNumDocRef.Text.PadLeft(15, Char.Parse("0"))
        cab.AC_FEC_DOC_REF = txtFechaDocRef.Value.ToShortDateString
        cab.AC_DETRAC = IIf(txtdetraccion.Text = String.Empty, 0, txtdetraccion.Text)
        cab.AC_DUA = IIf(chkdua.Checked = True, 1, 0)
        cab.AC_OP_INAFECTA = IIf(txtInafecta.Text = String.Empty, 0, txtInafecta.Text)
        cab.AC_OP_GRAVADA = IIf(txtgravada.Text = String.Empty, 0, txtgravada.Text)
        ''Ingresando detalles del Asiento Contable
        Dim d As New ClsEntidades.CO_TB_ASIENTO_DET
        For Each cells As DataRow In dtdetalleAsiento.Rows
            d = New ClsEntidades.CO_TB_ASIENTO_DET
            d.AD_IDCAB = 0
            d.AD_SECUENCIA = Integer.Parse(cells("AD_SECUENCIA").ToString())
            d.AD_CUENTA = cells("AD_CUENTA").ToString()
            d.AD_TANEXO = Integer.Parse(cells("AD_TANEXO").ToString())
            d.AD_IDANEXO = cells("AD_IDANEXO").ToString()
            d.AD_TDOC = cells("AD_TDOC").ToString()
            d.AD_SDOC = cells("AD_SDOC").ToString()
            d.AD_NDOC = cells("AD_NDOC").ToString()
            d.AD_FDOC = cells("AD_FDOC").ToString()
            d.AD_VDOC = cells("AD_VDOC").ToString()
            d.AD_DEBE = Double.Parse(cells("AD_DEBE").ToString())
            d.AD_HABER = Double.Parse(cells("AD_HABER").ToString())
            d.AD_TCAM = Double.Parse(cells("AD_TCAM").ToString())
            d.AD_SEC_ORI_DES = Integer.Parse(cells("AD_SEC_ORI_DES").ToString())
            d.AD_IDCC = cells("AD_IDCC").ToString()
            d.AD_ES_DESTINO = Integer.Parse(cells("AD_ES_DESTINO").ToString())
            d.AD_IDMEDIOPAGO = cells("AD_IDMEDIOPAGO").ToString()
            d.AD_MONTO_ORI = Double.Parse(cells("AD_MONTO_ORI").ToString())
            d.AD_PORCE_DESTINO = Double.Parse(cells("AD_PORCE_DESTINO").ToString())
            d.AD_ES_CONCI = 0
            d.AD_ANHO_CONI = 0
            d.AD_MES_CONCI = 0
            d.AD_ES_INAFECTO = Integer.Parse(cells("AD_ES_INAFECTO").ToString())
            d.AD_IDMONEDA = Integer.Parse(cells("AD_IDMONEDA").ToString())
            d.AD_TDOC_REF = cells("AD_TDOC_REF").ToString()
            d.AD_SDOC_REF = IIf(String.IsNullOrEmpty(cells("AD_SDOC_REF").ToString), "", cells("AD_SDOC_REF").PadLeft(5, Char.Parse("0")))
            d.AD_NDOC_REF = IIf(String.IsNullOrEmpty(cells("AD_NDOC_REF").ToString), "", cells("AD_NDOC_REF").PadLeft(15, Char.Parse("0")))
            d.AD_FDOC_REF = cells("AD_FDOC_REF").ToString()
            d.AD_VDOC_REF = cells("AD_VDOC_REF").ToString()
            d.AD_GLOSA = cells("AD_GLOSA").ToString()
            detalles.Add(d)
        Next
        Try
            asiento.Guardar_Modifica_Asiento_Contable(cab, detalles, bol_edicion_Asiento)
            txt_idcab.Text = cab.AC_ID.ToString()
            MessageBox.Show("Transaccion realizada exitosamente.!", "Sistema")
            If MessageBox.Show("¿ Desea Imprimir el Comprobante ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If String.IsNullOrEmpty(txt_idcab.Text) Then Exit Sub
                Dim CodAsiento As String = Integer.Parse(txt_idcab.Text)
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA")
                Dim SQL As String = String.Empty
                SQL = "SELECT AD_TDOC FROM CO_TB_ASIENTO_DET WHERE AD_IDCAB='" & CodAsiento & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If
            btn_grabar.Enabled = False
            gb_detalle_doc.Enabled = False
            btn_cancelar.Text = "&Registrar Nuevo"
            If bol_edicion_Asiento Then
                btn_cancelar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al momento de grabar", "Sistema")
        End Try
    End Sub

    Private Sub Agregar_Linea_Dif_Cambio()
        Dim fqBL As New ClsOperaciones.freeQuery
        Dim cta77gan As String = fqBL.get_Cta77Gan()
        Dim cta66per As String = fqBL.get_Cta66Per()
        Dim dif As Double = Double.Parse(mtb_dif.Text)

        If cta77gan = String.Empty Then
            Throw New SyntaxErrorException("No esta configurado la cuenta de la dif de cambio")
        End If

        If cta66per = String.Empty Then
            Throw New SyntaxErrorException("No esta configurado la cuenta de la dif de cambio")
        End If
        Dim _Secuencia As Integer
        If dif < 0 Then
            _Secuencia = 0
            _Secuencia = Correlativo()
            Call Ingresar_Fila(_Secuencia, cta77gan, "Ganancia por Dif. de Cambio", 0, "", "", "", "", "", "", Math.Abs(dif), 0, Math.Abs(dif), 1, "", "", 1, 0, 0, 0, "", "", "", "", "", "", 0, "Diferencia de cambio")
        Else
            _Secuencia = 0
            _Secuencia = Correlativo()
            Call Ingresar_Fila(_Secuencia, cta77gan, "Perdida por Dif. de Cambio", 0, "", "", "", "", "", "", 0, Math.Abs(dif), Math.Abs(dif), 1, "", "", 1, 0, 0, 0, "", "", "", "", "", "", 0, "Diferencia de cambio")
        End If
        Call Sumar_Totales()
    End Sub

    Private Sub Ingresar_Fila(ByVal Sec_ As Integer, cuenta_ As String, des_cta_ As String, tanexo_ As Integer, anexo_ As String, tdoc_ As String, _
                              sdoc_ As String, ndoc_ As String, fdoc_ As String, vdoc_ As String, debe_ As Double, haber_ As Double, _
                              mon_ori_ As Double, tc_ As Double, cc_ As String, mp_ As String, moneda_ As Integer, esdestino_ As Integer, _
                              porce_desti_ As Double, esinafecto_ As Integer, tdocref_ As String, sdocref_ As String, ndocref_ As String, _
                              fdocref_ As String, vdocref_ As String, des_anexo_ As String, sec_ori_des_ As Integer, glosa_ As String)

        'Dim row As DataRow = dtdetalleAsiento.NewRow
        'row("AD_IDCAB") = 0
        'row("AD_SECUENCIA") = Sec_
        'row("AD_CUENTA") = cuenta_
        'row("DESC_CUENTA") = des_cta_
        'row("AD_TANEXO") = tanexo_
        'row("AD_IDANEXO") = anexo_
        'row("AD_TDOC") = tdoc_
        'row("AD_SDOC") = sdoc_
        'row("AD_NDOC") = ndoc_
        'row("AD_FDOC") = fdoc_
        'row("AD_VDOC") = vdoc_
        'row("AD_DEBE") = debe_
        'row("AD_HABER") = haber_
        'row("AD_TCAM") = tc_
        'row("AD_SEC_ORI_DES") = sec_ori_des_
        'row("AD_IDCC") = cc_
        'row("AD_ES_DESTINO") = esdestino_
        'row("AD_IDMEDIOPAGO") = mp_
        'row("AD_MONTO_ORI") = mon_ori_
        'row("AD_PORCE_DESTINO") = porce_desti_
        'row("AD_ES_CONCI") = 0
        'row("AD_MES_CONCI") = 0
        'row("AD_ES_INAFECTO") = esinafecto_
        'row("AD_IDMONEDA") = moneda_
        'row("AD_TDOC_REF") = tdocref_
        'row("AD_SDOC_REF") = sdocref_
        'row("AD_NDOC_REF") = ndocref_
        'row("AD_FDOC_REF") = fdocref_
        'row("AD_VDOC_REF") = vdocref_
        'row("AD_GLOSA") = glosa_
        'dtdetalleAsiento.Rows.Add(row)
        'dtdetalleAsiento.AcceptChanges()
        Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
        Dim d As New ClsEntidades.CO_TB_ASIENTO_DET
        Dim asiento As New ClsOperaciones.Asiento_Contable
        d = New ClsEntidades.CO_TB_ASIENTO_DET
        d.AD_IDCAB = txt_idcab.Text
        d.AD_SECUENCIA = Sec_
        d.AD_CUENTA = cuenta_
        d.AD_TANEXO = tanexo_
        d.AD_IDANEXO = anexo_
        d.AD_TDOC = tdoc_
        d.AD_SDOC = sdoc_
        d.AD_NDOC = ndoc_
        d.AD_FDOC = fdoc_
        d.AD_VDOC = vdoc_
        d.AD_DEBE = debe_
        d.AD_HABER = haber_
        d.AD_TCAM = tc_
        d.AD_SEC_ORI_DES = sec_ori_des_
        d.AD_IDCC = cc_
        d.AD_ES_DESTINO = 0
        d.AD_IDMEDIOPAGO = esdestino_
        d.AD_MONTO_ORI = mon_ori_
        d.AD_PORCE_DESTINO = porce_desti_
        d.AD_ES_CONCI = 0
        d.AD_ANHO_CONI = 0
        d.AD_MES_CONCI = 0
        d.AD_ES_INAFECTO = esinafecto_
        d.AD_IDMONEDA = moneda_
        d.AD_TDOC_REF = tdocref_
        d.AD_SDOC_REF = sdocref_
        d.AD_NDOC_REF = ndocref_
        d.AD_FDOC_REF = fdocref_
        d.AD_VDOC_REF = vdocref_
        d.AD_GLOSA = glosa_
        d.AD_PERCEN_DETRACC = IIf(txt_detraccion.Text = String.Empty, 0, txt_detraccion.Text)
        detalles.Add(d)
        asiento.Guardar_Asiento_Detalle_(detalles)
    End Sub

    Private Sub Ingresar_Fila_Modo_edicion(Sec As Integer, cuenta_ As String, des_cta_ As String, tanexo_ As Integer, anexo_ As String, tdoc_ As String, _
                            sdoc_ As String, ndoc_ As String, fdoc_ As String, vdoc_ As String, debe_ As Double, haber_ As Double, _
                            mon_ori_ As Double, tc_ As Double, cc_ As String, mp_ As String, moneda_ As Integer, esdestino_ As Integer, _
                            porce_desti_ As Double, esinafecto_ As Integer, tdocref_ As String, sdocref_ As String, ndocref_ As String, _
                            fdocref_ As String, vdocref_ As String, des_anexo_ As String, sec_ori_des_ As Integer, glosa_ As String, Detraccion As Integer, Cencos As String)

        Dim row As DataRow = dtdetalleAsiento.NewRow
        row("AD_IDCAB") = 0
        row("AD_SECUENCIA") = Sec
        row("AD_CUENTA") = cuenta_
        row("DESC_CUENTA") = des_cta_
        row("AD_TANEXO") = tanexo_
        row("AD_IDANEXO") = anexo_
        row("AD_TDOC") = tdoc_
        row("AD_SDOC") = sdoc_
        row("AD_NDOC") = ndoc_
        row("AD_FDOC") = fdoc_
        row("AD_VDOC") = vdoc_
        row("AD_DEBE") = debe_
        row("AD_HABER") = haber_
        row("AD_TCAM") = tc_
        row("AD_SEC_ORI_DES") = sec_ori_des_
        row("AD_IDCC") = cc_
        row("AD_ES_DESTINO") = esdestino_
        row("AD_IDMEDIOPAGO") = mp_
        row("AD_MONTO_ORI") = mon_ori_
        row("AD_PORCE_DESTINO") = porce_desti_
        row("AD_ES_CONCI") = 0
        row("AD_MES_CONCI") = 0
        row("AD_ES_INAFECTO") = esinafecto_
        row("AD_IDMONEDA") = moneda_
        row("AD_TDOC_REF") = tdocref_
        row("AD_SDOC_REF") = sdocref_
        row("AD_NDOC_REF") = ndocref_
        row("AD_FDOC_REF") = fdocref_
        row("AD_VDOC_REF") = vdocref_
        row("AD_GLOSA") = glosa_
        row("AD_PERCEN_DETRACC") = Detraccion
        row("AD_CEN_COS") = Cencos
        dtdetalleAsiento.Rows.Add(row)

        dtdetalleAsiento.AcceptChanges()
    End Sub


    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 2)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function

    Private Sub IngresarDetallesAsientoContable(ByVal _Sec As Integer, ByVal _Debe As Double, ByVal _Haber As Double, ByVal _MontoOriginal As Double, ByVal _TipoCambio As Double)
        Try
            'Dim row As DataRow = dtdetalleAsiento.NewRow
            'row("AD_IDCAB") = 0
            'row("AD_SECUENCIA") = _Sec
            'row("AD_CUENTA") = txtCuentaContable.Text
            'row("DESC_CUENTA") = txt_des_cta.Text
            'row("AD_TANEXO") = tipoAnexoDet
            'row("AD_IDANEXO") = txt_cod_ane.Text
            'row("AD_TDOC") = IIf(txtTipoDocAsiento.Text = String.Empty, "", txtTipoDocAsiento.Text)
            'row("AD_SDOC") = txt_ser.Text
            'row("AD_NDOC") = txt_num.Text
            'row("AD_FDOC") = IIf(mtb_fec_emi.MaskFull, mtb_fec_emi.Text, "")
            'row("AD_VDOC") = IIf(mtb_fec_ven.MaskFull, mtb_fec_ven.Text, "")
            'row("AD_DEBE") = _Debe
            'row("AD_HABER") = _Haber
            'row("AD_TCAM") = _TipoCambio
            'row("AD_SEC_ORI_DES") = 0
            'If cmb_cc.Enabled = False And txtCentroCosto.Visible = False Then
            '    row("AD_IDCC") = ""
            'Else
            '    If cmb_cc.Enabled = True And txtCentroCosto.Visible = False Then
            '        row("AD_IDCC") = "" = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
            '    Else
            '        row("AD_IDCC") = "" = TraerCodigo(txtCentroCosto.Text)
            '    End If
            'End If
            'row("AD_ES_DESTINO") = 0
            'If cmb_mp.Enabled = False Then
            '    row("AD_IDMEDIOPAGO") = ""
            'Else
            '    row("AD_IDMEDIOPAGO") = IIf(cmb_mp.SelectedIndex <> -1, cmb_mp.SelectedValue.ToString(), "")
            'End If
            'row("AD_MONTO_ORI") = _MontoOriginal
            'row("AD_PORCE_DESTINO") = 0
            'row("AD_ES_CONCI") = 0
            'row("AD_MES_CONCI") = 0
            'row("AD_ES_INAFECTO") = IIf(chk_inafecto.Checked, 1, 0)
            'row("AD_IDMONEDA") = Integer.Parse(cmb_moneda.SelectedValue.ToString())
            'row("AD_TDOC_REF") = IIf(txt_tdoc_ref.Text = String.Empty, "", txt_tdoc_ref.Text)
            'row("AD_SDOC_REF") = IIf(txt_sdoc_ref.Text = String.Empty, "", txt_sdoc_ref.Text)
            'row("AD_NDOC_REF") = IIf(txt_ndoc_ref.Text = String.Empty, "", txt_ndoc_ref.Text)
            'row("AD_FDOC_REF") = IIf(mtb_fec_emi_ref.MaskFull, mtb_fec_emi_ref.Text, "")
            'row("AD_VDOC_REF") = IIf(mtb_fec_ven_ref.MaskFull, mtb_fec_ven_ref.Text, "")
            'row("AD_GLOSA") = txt_glosa_det.Text.Trim()
            'dtdetalleAsiento.Rows.Add(row)
            'dtdetalleAsiento.AcceptChanges()

            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim d As New ClsEntidades.CO_TB_ASIENTO_DET
            Dim asiento As New ClsOperaciones.Asiento_Contable

            d = New ClsEntidades.CO_TB_ASIENTO_DET
            d.AD_IDCAB = txt_idcab.Text
            d.AD_SECUENCIA = _Sec
            d.AD_CUENTA = txtCuentaContable.Text
            d.AD_CEN_COS = txt_cen_cos.Text
            d.AD_TANEXO = tipoAnexoDet
            d.AD_IDANEXO = txt_cod_ane.Text
            d.AD_TDOC = IIf(txtTipoDocAsiento.Text = String.Empty, "", txtTipoDocAsiento.Text)
            d.AD_SDOC = txt_ser.Text
            d.AD_NDOC = txt_num.Text
            d.AD_FDOC = IIf(mtb_fec_emi.MaskFull, mtb_fec_emi.Text, "")
            d.AD_VDOC = IIf(mtb_fec_ven.MaskFull, mtb_fec_ven.Text, "")
            d.AD_DEBE = _Debe
            d.AD_HABER = _Haber
            d.AD_TCAM = _TipoCambio
            d.AD_SEC_ORI_DES = 0
            If cmb_cc.Enabled = False And txtCentroCosto.Visible = False Then
                d.AD_IDCC = ""
            Else
                If cmb_cc.Enabled = True And txtCentroCosto.Visible = False Then
                    d.AD_IDCC = "" = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
                    'd.AD_IDCC = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
                Else
                    d.AD_IDCC = "" = TraerCodigo(txtCentroCosto.Text)
                    'd.AD_IDCC = TraerCodigo(txtCentroCosto.Text)
                End If
            End If
            d.AD_ES_DESTINO = 0
            If cmb_mp.Enabled = False Then
                d.AD_IDMEDIOPAGO = ""
            Else
                d.AD_IDMEDIOPAGO = IIf(cmb_mp.SelectedIndex <> -1, cmb_mp.SelectedValue.ToString(), "")
            End If
            d.AD_MONTO_ORI = _MontoOriginal
            d.AD_PORCE_DESTINO = 0
            d.AD_ES_CONCI = 0
            d.AD_ANHO_CONI = 0
            d.AD_MES_CONCI = 0
            d.AD_ES_INAFECTO = IIf(chk_inafecto.Checked, 1, 0)
            d.AD_IDMONEDA = Integer.Parse(cmb_moneda.SelectedValue.ToString())
            d.AD_TDOC_REF = IIf(txt_tdoc_ref.Text = String.Empty, "", txt_tdoc_ref.Text)
            d.AD_SDOC_REF = IIf(txt_sdoc_ref.Text = String.Empty, "", txt_sdoc_ref.Text)
            d.AD_NDOC_REF = IIf(txt_ndoc_ref.Text = String.Empty, "", txt_ndoc_ref.Text)
            d.AD_FDOC_REF = IIf(mtb_fec_emi_ref.MaskFull, mtb_fec_emi_ref.Text, "")
            d.AD_VDOC_REF = IIf(mtb_fec_ven_ref.MaskFull, mtb_fec_ven_ref.Text, "")
            d.AD_GLOSA = txt_glosa_det.Text.Trim()
            d.AD_PERCEN_DETRACC = IIf(txt_detraccion.Text = String.Empty, 0, txt_detraccion.Text)
            detalles.Add(d)
            asiento.Guardar_Asiento_Detalle_(detalles)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetallesAsientoContable(ByVal _sec As Integer, ByVal _Debe As Double, ByVal _Haber As Double, ByVal _MontoOriginal As Double, ByVal _TipoCambio As Double)
        Try
            'For Each item As DataRow In dtdetalleAsiento.Select("AD_SECUENCIA=" & _sec & " or AD_SEC_ORI_DES=" & _sec)
            '    dtdetalleAsiento.BeginInit()
            '    item.Delete()
            '    dtdetalleAsiento.EndInit()
            '    dtdetalleAsiento.AcceptChanges()
            'Next
            'Dim row As DataRow = dtdetalleAsiento.NewRow
            'row("AD_IDCAB") = 0
            'row("AD_SECUENCIA") = _sec
            'row("AD_CUENTA") = txtCuentaContable.Text
            'row("DESC_CUENTA") = txt_des_cta.Text
            'row("AD_TANEXO") = tipoAnexoDet
            'row("AD_IDANEXO") = txt_cod_ane.Text
            'row("AD_TDOC") = IIf(txtTipoDocAsiento.Text = String.Empty, "", txtTipoDocAsiento.Text)
            'row("AD_SDOC") = txt_ser.Text
            'row("AD_NDOC") = txt_num.Text
            'row("AD_FDOC") = IIf(mtb_fec_emi.MaskFull, mtb_fec_emi.Text, "")
            'row("AD_VDOC") = IIf(mtb_fec_ven.MaskFull, mtb_fec_ven.Text, "")
            'row("AD_DEBE") = _Debe
            'row("AD_HABER") = _Haber
            'row("AD_TCAM") = _TipoCambio
            'row("AD_SEC_ORI_DES") = 0
            'If cmb_cc.Enabled = False And txtCentroCosto.Visible = False Then
            '    row("AD_IDCC") = ""
            'Else
            '    If cmb_cc.Enabled = True And txtCentroCosto.Visible = False Then
            '        row("AD_IDCC") = "" = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
            '    Else
            '        row("AD_IDCC") = "" = TraerCodigo(txtCentroCosto.Text)
            '    End If
            'End If
            'row("AD_ES_DESTINO") = 0
            'If cmb_mp.Enabled = False Then
            '    row("AD_IDMEDIOPAGO") = ""
            'Else
            '    row("AD_IDMEDIOPAGO") = IIf(cmb_mp.SelectedIndex <> -1, cmb_mp.SelectedValue.ToString(), "")
            'End If
            'row("AD_MONTO_ORI") = _MontoOriginal
            'row("AD_PORCE_DESTINO") = 0
            'row("AD_ES_CONCI") = 0
            'row("AD_MES_CONCI") = 0
            'row("AD_ES_INAFECTO") = IIf(chk_inafecto.Checked, 1, 0)
            'row("AD_IDMONEDA") = Integer.Parse(cmb_moneda.SelectedValue.ToString())
            'row("AD_TDOC_REF") = IIf(txt_tdoc_ref.Text = String.Empty, "", txt_tdoc_ref.Text)
            'row("AD_SDOC_REF") = IIf(txt_sdoc_ref.Text = String.Empty, "", txt_sdoc_ref.Text)
            'row("AD_NDOC_REF") = IIf(txt_ndoc_ref.Text = String.Empty, "", txt_ndoc_ref.Text)
            'row("AD_FDOC_REF") = IIf(mtb_fec_emi_ref.MaskFull, mtb_fec_emi_ref.Text, "")
            'row("AD_VDOC_REF") = IIf(mtb_fec_ven_ref.MaskFull, mtb_fec_ven_ref.Text, "")
            'row("AD_GLOSA") = txt_glosa_det.Text.Trim()
            'dtdetalleAsiento.Rows.Add(row)
            'dtdetalleAsiento.AcceptChanges()

            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim d As New ClsEntidades.CO_TB_ASIENTO_DET
            Dim asiento As New ClsOperaciones.Asiento_Contable

            d = New ClsEntidades.CO_TB_ASIENTO_DET
            d.AD_IDCAB = txt_idcab.Text
            d.AD_SECUENCIA = _sec
            d.AD_CUENTA = txtCuentaContable.Text
            d.AD_CEN_COS = txt_cen_cos.Text
            d.AD_TANEXO = tipoAnexoDet
            d.AD_IDANEXO = txt_cod_ane.Text
            d.AD_TDOC = IIf(txtTipoDocAsiento.Text = String.Empty, "", txtTipoDocAsiento.Text)
            d.AD_SDOC = txt_ser.Text
            d.AD_NDOC = txt_num.Text
            d.AD_FDOC = IIf(mtb_fec_emi.MaskFull, mtb_fec_emi.Text, "")
            d.AD_VDOC = IIf(mtb_fec_ven.MaskFull, mtb_fec_ven.Text, "")
            d.AD_DEBE = _Debe
            d.AD_HABER = _Haber
            d.AD_TCAM = _TipoCambio
            d.AD_SEC_ORI_DES = 0
            If cmb_cc.Enabled = False And txtCentroCosto.Visible = False Then
                d.AD_IDCC = ""
            Else
                If cmb_cc.Enabled = True And txtCentroCosto.Visible = False Then
                    d.AD_IDCC = "" = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
                    'd.AD_IDCC = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
                Else
                    d.AD_IDCC = "" = TraerCodigo(txtCentroCosto.Text)
                    'd.AD_IDCC = TraerCodigo(txtCentroCosto.Text)
                End If
            End If
            d.AD_ES_DESTINO = 0
            If cmb_mp.Enabled = False Then
                d.AD_IDMEDIOPAGO = ""
            Else
                d.AD_IDMEDIOPAGO = IIf(cmb_mp.SelectedIndex <> -1, cmb_mp.SelectedValue.ToString(), "")
            End If
            d.AD_MONTO_ORI = _MontoOriginal
            d.AD_PORCE_DESTINO = 0
            d.AD_ES_CONCI = 0
            d.AD_ANHO_CONI = 0
            d.AD_MES_CONCI = 0
            d.AD_ES_INAFECTO = IIf(chk_inafecto.Checked, 1, 0)
            d.AD_IDMONEDA = Integer.Parse(cmb_moneda.SelectedValue.ToString())
            d.AD_TDOC_REF = IIf(txt_tdoc_ref.Text = String.Empty, "", txt_tdoc_ref.Text)
            d.AD_SDOC_REF = IIf(txt_sdoc_ref.Text = String.Empty, "", txt_sdoc_ref.Text)
            d.AD_NDOC_REF = IIf(txt_ndoc_ref.Text = String.Empty, "", txt_ndoc_ref.Text)
            d.AD_FDOC_REF = IIf(mtb_fec_emi_ref.MaskFull, mtb_fec_emi_ref.Text, "")
            d.AD_VDOC_REF = IIf(mtb_fec_ven_ref.MaskFull, mtb_fec_ven_ref.Text, "")
            d.AD_GLOSA = txt_glosa_det.Text.Trim()
            d.AD_PERCEN_DETRACC = IIf(txt_detraccion.Text = String.Empty, 0, txt_detraccion.Text)
            detalles.Add(d)
            asiento.Actualizar_Asiento_Detalle_(detalles)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If btn_cancelar.Text = "Nuevo" Then
            Dim index_ope As Integer = cmb_ope.SelectedIndex
            Dim index_sub As Integer = cmb_sub.SelectedIndex
            Call Iniciar()
            cmb_ope.SelectedIndex = index_ope
            cmb_sub.SelectedIndex = index_sub
            mtb_tot_d.Text = 0
            mtb_tot_h.Text = 0
            mtb_dif.Text = 0
            txt_d1.Text = String.Empty
            txt_d2.Text = String.Empty
            GenerarColummnaDataTableAsientoContable()
            gbCabecera.Enabled = True
            gbDetalles.Enabled = False
            Blank()
            Nuevo_Detalle()
            cmb_ope.Focus()
        End If
    End Sub




    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txtCuentaContable.Text = String.Empty Then
            MessageBox.Show("Ingrese una cuenta contable", "Cuidado!")
            txtCuentaContable.Focus()
            Exit Sub
        Else
            If Strings.Left(txtCuentaContable.Text, 1) = "6" And Strings.Left(txtCuentaContable.Text, 2) = "60" And Strings.Left(txtCuentaContable.Text, 2) = "61" And txt_cen_cos.Text = "" And txt_cen_cos.Enabled = True Then
                MessageBox.Show("Ingrese una Centro de Costo", "Cuidado!")
                txt_cen_cos.Focus()
                Exit Sub
            End If
        End If
        If txt_cod_ane.Enabled Then
            If txt_cod_ane.Text.Trim().Length = 0 Then
                MessageBox.Show("Ingrese un anexo", "Cuidado!")
                Exit Sub
            End If
            Dim fq As New ClsOperaciones.freeQuery
            If Not fq.Existe_Anexo(txt_cod_ane.Text.Trim(), tipoAnexoDet) Then
                MsgBox("La cuenta Contable posee un Anexo distinto al Anexo del Tipo de Operacion.", MsgBoxStyle.Information)
                txt_cod_ane.Focus()
                Exit Sub
            End If
            fq = Nothing
        End If
        If mtb_tc.Text = String.Empty Then
            MsgBox("Debe agregar el Tipo de Cambio.", MsgBoxStyle.Information)
            mtb_fec_emi.Focus()
            Exit Sub
        End If
        If cmb_moneda.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un Tipo de Moneda.", MsgBoxStyle.Information)
            cmb_moneda.Focus()
            Exit Sub
        End If
        If cmb_cc.Enabled And cmb_cc.Visible = True Then
            If cmb_cc.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un centro de costo", "Sistema")
                cmb_cc.Focus()
                Exit Sub
            End If
        End If
        If txtCentroCosto.Visible = True And cmb_cc.Visible = False Then
            If txtCentroCosto.Text = String.Empty Then
                MsgBox("Seleccione un centro de costo", MsgBoxStyle.Information)
                txtCentroCosto.Focus()
                Exit Sub
            End If
        End If
        If cmb_mp.Enabled Then
            If cmb_mp.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un medio de pago", "Sistema")
                cmb_mp.Focus()
                Exit Sub
            End If
        End If
        If btn_ref.Enabled Then
            If txt_tdoc_ref.Text = "" Or txt_sdoc_ref.Text = "" Or txt_ndoc_ref.Text = "" Or Not mtb_fec_emi_ref.MaskFull Then
                MessageBox.Show("Complete los datos del documento de referencia", "Sistema")
                gb_ref.Visible = True
                Exit Sub
            End If
        End If

        If txt_cen_cos.Enabled And txt_cen_cos.Text = "" Then
            MessageBox.Show("Debe elegir un Centro de Costo", "Sistema")
            txt_cen_cos.Focus()
            Exit Sub
        End If

        Dim d As Double = 0
        Dim h As Double = 0
        Dim o As Double = 0
        Dim tc As Double = 0

        If mtb_debe.Text = "" And mtb_haber.Text = "" Then
            MessageBox.Show("Ingrese un valor en el Debe/Haber", "Sistema")
            mtb_debe.Focus()
            Exit Sub
        End If

        If mtb_debe.Text = "" Then mtb_debe.Text = "0"
        If mtb_haber.Text = "" Then mtb_haber.Text = "0"

        If Double.Parse(mtb_debe.Text.Trim) > 0 And Double.Parse(mtb_haber.Text.Trim) > 0 Then
            MessageBox.Show("No puede ingresar valores en el Debe y Haber en la misma cuenta.", "Cuidado")
            mtb_debe.Focus()
            Exit Sub
        End If
        If mtb_tc.Text.Trim() <> 0 Then
            tc = Double.Parse(mtb_tc.Text)
        End If
        If Integer.Parse(cmb_moneda.SelectedValue.ToString()) = 2 Then ' dolares
            If Double.Parse(mtb_debe.Text) <> 0 Then
                o = Double.Parse(mtb_debe.Text)
                d = Math.Round(o * tc, 2)
            Else
                o = Double.Parse(mtb_haber.Text)
                h = Math.Round(o * tc, 2)
            End If
        Else 'soles
            If Double.Parse(mtb_debe.Text) <> 0 Then
                d = Double.Parse(mtb_debe.Text)
                o = d
            Else
                h = Double.Parse(mtb_haber.Text)
                o = h
            End If
        End If
        Dim _Secuencia As Integer = 0
        If bol_edicion_Det Then
            If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
            _Secuencia = dgvDetalleAsiento.Item(1, dgvDetalleAsiento.CurrentRow.Index).Value
            EditarDetallesAsientoContable(_Secuencia, d, h, o, tc)
        Else
            _Secuencia = Correlativo()
            IngresarDetallesAsientoContable(_Secuencia, d, h, o, tc)
        End If
        ' //verificamos si la cuenta tiene destinos
        If txt_d1.Text.Length > 0 And txt_d2.Text.Length > 0 Then
            Dim pc As New ClsOperaciones.CO_TB_PLANCTAS
            Dim dt As DataTable
            Dim ult_secuencia As Integer = _Secuencia
            dt = pc.get_Cuenta(txt_d1.Text.Trim(), Date.Now.Year)
            If dt.Rows.Count > 0 Then
                _Secuencia = 0
                _Secuencia = Correlativo()
                Call Ingresar_Fila(_Secuencia, txt_d1.Text, dt.Rows(0)("PC_DES_CTA").ToString(), 0, "", txtTipoDocAsiento.Text, txt_ser.Text, txt_num.Text, "", "", d, h, o, tc, "", "", Integer.Parse(cmb_moneda.SelectedValue.ToString()), 1, 100, 0, "", "", "", "", "", "", ult_secuencia, txt_glosa_det.Text.Trim())
            End If
            dt = pc.get_Cuenta(txt_d1.Text.Trim(), Date.Now.Year)
            If dt.Rows.Count > 0 Then
                _Secuencia = 0
                _Secuencia = Correlativo()
                Call Ingresar_Fila(_Secuencia, txt_d2.Text, dt.Rows(0)("PC_DES_CTA").ToString(), 0, "", txtTipoDocAsiento.Text, txt_ser.Text, txt_num.Text, "", "", h, d, o, tc, "", "", Integer.Parse(cmb_moneda.SelectedValue.ToString()), 1, 100, 0, "", "", "", "", "", "", ult_secuencia, txt_glosa_det.Text.Trim())
            End If
            dt = Nothing
            pc = Nothing
        End If
        MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
        Call Sumar_Totales()
        pnlDetalles.Enabled = False
        bol_edicion_Det = False
        chk_inafecto.Checked = False
        txtCuentaContable.Select()
        ' mtb_fec_emi.Text = ""
        'mtb_fec_ven.Text = ""
        mtb_debe.Text = ""
        mtb_haber.Text = ""
        If viene_de_compras = "si" Then
            Call btn_can_Click(sender, e)
        End If

    End Sub

    'Public Function Correlativo() As Integer
    '    Dim Item As Integer = 0
    '    Item = IIf(String.IsNullOrEmpty(dtdetalleAsiento.Compute("Max(AD_SECUENCIA)", "").ToString), 0, dtdetalleAsiento.Compute("Max(AD_SECUENCIA)", ""))
    '    Item = Item + 1
    '    Return Item
    'End Function

    Public Function Correlativo() As Integer
        Dim Item As Integer = 0
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable
            DtDetallesAsientoC = AsientoContableCabs.Secuencia(txt_idcab.Text)
            Item = CInt(DtDetallesAsientoC.Rows(0).Item("Secuencia"))
        Catch ex As Exception
            Throw
        End Try
        Return Item
    End Function

    Private Sub Nuevo_Detalle()
        bol_edicion_Det = False
        Call Limpiar_Controles(gb_detalle_doc)
        cmb_cc.SelectedIndex = -1
        cmb_mp.SelectedIndex = -1
        txtCuentaContable.Text = String.Empty
        txtTipoDocAsiento.Text = String.Empty
        txt_tdoc_ref.Text = ""
        txt_sdoc_ref.Text = ""
        txt_ndoc_ref.Text = ""
        mtb_fec_emi_ref.Text = ""
        mtb_fec_ven_ref.Text = ""
        txt_d1.Text = ""
        txt_d2.Text = ""
        txt_cen_cos.Text = ""
        txt_cen_cos_des.Text = ""
    End Sub

    Public Sub Sumar_Totales()
        Dim td As Double = 0
        Dim th As Double = 0
        Dim td_r As Double = 0
        Dim th_r As Double = 0
        Dim dif As Double = 0
        For Each cells As DataRow In dtdetalleAsiento.Select("AD_SEC_ORI_DES=0", "")
            td += Double.Parse(cells("AD_DEBE").ToString())
            th += Double.Parse(cells("AD_HABER").ToString())
        Next

        td_r = Format(td, "##,##0.00") 'Math.Round(td, 2)
        th_r = Format(th, "##,##0.00") 'Math.Round(th, 2)
        dif = td_r - th_r
        mtb_tot_d.Text = Format(td, "##,##0.00")
        mtb_tot_h.Text = Format(th, "##,##0.00")
        mtb_dif.Text = Format(dif, "##,##0.00")
    End Sub

    Private Sub btn_can_Click(sender As Object, e As EventArgs) Handles btn_can.Click
        pnlDetalles.Enabled = True
        gb_detalle_doc.Enabled = False
        Nuevo_Detalle()
        dgvDetalleAsiento.Focus()
    End Sub

    Private Sub DetallesCuentaContable(ByVal _NumeroCuenta As String)
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("DetalleCuentaContable")
            DtDetallesAsientoC = AsientoContableCabs.DetalleCuentaContable(_NumeroCuenta)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                'If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA").ToString) Then
                '    cmb_moneda.SelectedIndex = -1
                'Else
                '    If DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA").ToString = 0 Then
                '        cmb_moneda.SelectedIndex = -1
                '    Else
                '        cmb_moneda.SelectedValue = DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA")
                '    End If
                'End If
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_ES_MP").ToString) Then
                    cmb_mp.SelectedIndex = -1
                    cmb_mp.Enabled = False
                Else
                    If DtDetallesAsientoC.Rows(0).Item("PC_ES_MP").ToString = 0 Then
                        cmb_mp.SelectedIndex = -1
                        cmb_mp.Enabled = False
                    Else
                        cmb_mp.SelectedIndex = -1
                        cmb_mp.Enabled = True
                    End If
                End If
                txt_d1.Text = DtDetallesAsientoC.Rows(0).Item("PC_DES_D").ToString
                txt_d2.Text = DtDetallesAsientoC.Rows(0).Item("PC_DES_H").ToString
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_ES_CC").ToString) Then
                    cmb_cc.SelectedIndex = -1
                    cmb_cc.Enabled = False
                Else
                    If DtDetallesAsientoC.Rows(0).Item("PC_ES_CC").ToString = 0 Then
                        cmb_cc.SelectedIndex = -1
                        cmb_cc.Enabled = False
                        cmb_cc.Visible = True
                        txtCentroCosto.Visible = False
                    Else
                        If txt_d1.Text = String.Empty And txt_d2.Text = String.Empty Then
                            txtCentroCosto.Visible = True
                            cmb_cc.Visible = False
                            txtCentroCosto.Text = String.Empty
                        Else
                            cmb_cc.SelectedIndex = -1
                            cmb_cc.Enabled = True
                            cmb_cc.Visible = True
                            txtCentroCosto.Visible = False
                            txtCentroCosto.Text = String.Empty
                        End If
                    End If
                End If
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString) Then
                    tipoAnexoDet = 0
                    txt_cod_ane.Text = ""
                    txt_des_ane.Text = ""
                    txt_cod_ane.Enabled = False
                    txt_des_ane.Enabled = False
                Else
                    If DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString = 0 Then
                        tipoAnexoDet = 0
                        txt_cod_ane.Text = ""
                        txt_des_ane.Text = ""
                        txt_cod_ane.Enabled = False
                        txt_des_ane.Enabled = False
                    Else
                        tipoAnexoDet = DtDetallesAsientoC.Rows(0).Item("PC_IDTIPO_ANEXO").ToString
                        TipoAnexo = tipoAnexoDet
                        txt_cod_ane.Enabled = True
                        txt_des_ane.Enabled = True
                    End If
                End If
                txt_d1.Text = DtDetallesAsientoC.Rows(0).Item("PC_DES_D").ToString
                txt_d2.Text = DtDetallesAsientoC.Rows(0).Item("PC_DES_H").ToString

                If Strings.Left(_NumeroCuenta, 1) = "6" And Strings.Left(_NumeroCuenta, 2) <> "60" And Strings.Left(_NumeroCuenta, 2) <> "61" Then
                    txt_cen_cos.Text = ""
                    txt_cen_cos_des.Text = ""
                    txt_cen_cos.Enabled = True
                    txt_cen_cos.BackColor = Color.Aquamarine
                Else
                    txt_cen_cos.Text = ""
                    txt_cen_cos_des.Text = ""
                    txt_cen_cos.Enabled = False
                    txt_cen_cos.BackColor = Color.Gainsboro
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_ane_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ane.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tercero(txt_cod_ane, txt_des_ane)
        ElseIf e.KeyCode = Keys.Enter Then
            If txt_cod_ane.Text = String.Empty Then
                Ayuda_Tercero(txt_cod_ane, txt_des_ane)
            Else
                Ayuda_Tercero(txt_cod_ane, txt_des_ane, txt_cod_ane.Text)
            End If
            txtTipoDocAsiento.Select()
        End If
    End Sub

    Private Sub txt_ser_Leave(sender As Object, e As EventArgs) Handles txt_ser.Leave
        If txt_ser.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then
                'If txtTipoDocAsiento.Text = "CP" Then
                '    txt_ser.Text = txt_ser.Text.PadLeft(5, Char.Parse("0"))
                'Else
                '    txt_ser.Text = txt_ser.Text.PadLeft(10, Char.Parse("0"))
                'End If

            ElseIf cmb_sub.SelectedValue = "02" Then
                txt_ser.Text = txt_ser.Text.PadLeft(4, Char.Parse("0"))
            End If

        End If
    End Sub

    Private Sub txt_num_Leave(sender As Object, e As EventArgs) Handles txt_num.Leave
        'If txt_num.Text.Trim().Length > 0 Then
        '    'If txtTipoDocAsiento.Text <> "VR" Then
        '    '    txt_num.Text = txt_num.Text.PadLeft(15, Char.Parse("0"))
        '    'End If
        'End If
        If txt_num.Text.Trim().Length > 0 Then
            If txtTipoDocAsiento.Text <> "VR" Then
                If txtTipoDocAsiento.Text <> "TB" Then
                    If cmb_sub.SelectedValue = "01" Then
                        'txt_num.Text = txt_num.Text.PadLeft(15, Char.Parse("0"))
                    ElseIf cmb_sub.SelectedValue = "02" Then
                        txt_num.Text = txt_num.Text.PadLeft(7, Char.Parse("0"))
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Modo_Edicion()
        Try
            bol_edicion_Det = True
            Dim fila As DataGridViewRow = dgvDetalleAsiento.CurrentRow
            tipoAnexoDet = Integer.Parse(fila.Cells("AD_TANEXO").Value.ToString())
            txtCuentaContable.Text = fila.Cells("AD_CUENTA").Value.ToString()
            If txtCuentaContable.Text <> String.Empty Then
                Ayuda_CuentaContable(txtCuentaContable.Text)
            End If
            If txt_des_cta.Text = "" Then
                txt_des_cta.Text = ""
            End If

            txt_cen_cos.Text = fila.Cells("AD_CEN_COS").Value.ToString()
            If txt_cen_cos.Text <> String.Empty Then
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDetallesAsientoC = New DataTable("DetalleCuentaContable")
                DtDetallesAsientoC = AsientoContableCabs.Detalle_Cen_Cos(txt_cen_cos.Text)
                If DtDetallesAsientoC.Rows.Count() <> 0 Then
                    txt_cen_cos_des.Text = DtDetallesAsientoC.Rows(0).Item("DESCRIPCION").ToString
                End If
            End If

            If fila.Cells("AD_TANEXO").Value.ToString() = "0" Then
                txt_cod_ane.Enabled = False
                txt_cod_ane.Text = ""
                txt_des_ane.Text = String.Empty
            Else
                txt_cod_ane.Enabled = True
                txt_cod_ane.Text = fila.Cells("AD_IDANEXO").Value.ToString
                Dim fq As New ClsOperaciones.freeQuery
                Dim dtdatosFee As DataTable
                dtdatosFee = New DataTable
                Select Case tipoAnexoDet
                    Case 1 'clientes
                        dtdatosFee = fq.get_Descripcion_Cliente(txt_cod_ane.Text.Trim())
                        If dtdatosFee.Rows.Count() <> 0 Then
                            txt_des_ane.Text = dtdatosFee.Rows(0).Item(0).ToString
                        End If
                    Case 2 ' proveedores
                        dtdatosFee = fq.get_Descripcion_Proveedor(txt_cod_ane.Text.Trim())
                        If dtdatosFee.Rows.Count() <> 0 Then
                            txt_des_ane.Text = dtdatosFee.Rows(0).Item(0).ToString
                        End If
                End Select
                fq = Nothing
            End If

            If fila.Cells("AD_TDOC").Value.ToString() = "" Then
                txtTipoDocAsiento.Text = String.Empty
                btn_ref.Enabled = False
            Else
                txtTipoDocAsiento.Text = fila.Cells("AD_TDOC").Value.ToString()
            End If

            If fila.Cells("AD_TDOC").Value.ToString() = "NC" Then
                btn_ref.Enabled = True
            Else
                btn_ref.Enabled = False
            End If

            txt_ser.Text = fila.Cells("AD_SDOC").Value.ToString()
            txt_num.Text = fila.Cells("AD_NDOC").Value.ToString()
            mtb_fec_emi.Text = fila.Cells("AD_FDOC").Value.ToString()
            mtb_fec_ven.Text = fila.Cells("AD_VDOC").Value.ToString()

            If fila.Cells("AD_IDMONEDA").Value.ToString() = 2 Then
                mtb_debe.Text = IIf(fila.Cells("AD_DEBE").Value.ToString() = 0, fila.Cells("AD_DEBE").Value, fila.Cells("AD_MONTO_ORI").Value)
                mtb_haber.Text = IIf(fila.Cells("AD_HABER").Value.ToString() = 0, fila.Cells("AD_HABER").Value, fila.Cells("AD_MONTO_ORI").Value)
            Else
                mtb_debe.Text = fila.Cells("AD_DEBE").Value.ToString()
                mtb_haber.Text = fila.Cells("AD_HABER").Value.ToString()
            End If
            mtb_tc.Text = fila.Cells("AD_TCAM").Value.ToString()

            If fila.Cells("AD_IDCC").Value.ToString() = "" Then
                cmb_cc.SelectedIndex = -1
                cmb_cc.Enabled = False
            Else
                cmb_cc.Enabled = True
                cmb_cc.SelectedValue = fila.Cells("AD_IDCC").Value.ToString()

                Dim _cuenta_fila As String = ""
                Dim _cuenta_dt As String = ""

                For Each row As DataRow In dtdetalleAsiento.Select("AD_SEC_ORI_DES=" & CInt(fila.Cells("AD_SECUENCIA").Value.ToString()) & " ", "")
                    _cuenta_fila = fila.Cells("AD_CUENTA").Value.ToString()
                    _cuenta_dt = Strings.Right(row("AD_CUENTA").ToString, Len(_cuenta_fila))
                    If _cuenta_fila = _cuenta_dt Then
                        txtCentroCosto.Text = row("AD_CUENTA").ToString
                    End If
                Next

            End If

            If fila.Cells("AD_IDMEDIOPAGO").Value.ToString() = "" Then
                cmb_mp.SelectedIndex = -1
                cmb_mp.Enabled = False
            Else
                cmb_mp.Enabled = True
                cmb_mp.SelectedValue = fila.Cells("AD_IDMEDIOPAGO").Value.ToString()
            End If

            chk_inafecto.Checked = False

            If Integer.Parse(fila.Cells("AD_ES_INAFECTO").Value.ToString()) = 1 Then
                chk_inafecto.Checked = True
            End If
            cmb_moneda.SelectedValue = fila.Cells("AD_IDMONEDA").Value.ToString()
            txt_tdoc_ref.Text = fila.Cells("AD_TDOC_REF").Value.ToString()
            txt_sdoc_ref.Text = fila.Cells("AD_SDOC_REF").Value.ToString()
            txt_ndoc_ref.Text = fila.Cells("AD_NDOC_REF").Value.ToString()
            mtb_fec_emi_ref.Text = fila.Cells("AD_FDOC_REF").Value.ToString()
            mtb_fec_ven_ref.Text = fila.Cells("AD_VDOC_REF").Value.ToString()
            txt_glosa_det.Text = fila.Cells("AD_GLOSA").Value.ToString()
            txt_detraccion.Text = IIf(fila.Cells("AD_PERCEN_DETRACC").Value.ToString() = "", 0, fila.Cells("AD_PERCEN_DETRACC").Value)
            txt_ser.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmb_sub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sub.SelectedIndexChanged
        Call Cargar_Numero_Voucher()
    End Sub

    Private Sub mtb_fec_vou_Leave(sender As Object, e As EventArgs)
        If Not bol_edicion_Asiento Then
            Call Cargar_Numero_Voucher()
        End If
    End Sub

    Private Sub btn_aceptar_ref_Click(sender As Object, e As EventArgs) Handles btn_aceptar_ref.Click
        gb_ref.Visible = False
    End Sub

    Private Sub btn_ref_Click(sender As Object, e As EventArgs) Handles btn_ref.Click
        gb_ref.Visible = True
    End Sub

    Private Sub txt_sdoc_ref_Leave(sender As Object, e As EventArgs) Handles txt_sdoc_ref.Leave
        If txt_sdoc_ref.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then
                txt_sdoc_ref.Text = txt_sdoc_ref.Text.PadLeft(10, Char.Parse("0"))
            Else
                txt_sdoc_ref.Text = txt_sdoc_ref.Text.PadLeft(3, Char.Parse("0"))
            End If

        End If
    End Sub

    Private Sub txt_ndoc_ref_Leave(sender As Object, e As EventArgs) Handles txt_ndoc_ref.Leave
        If txt_ndoc_ref.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then
                txt_ndoc_ref.Text = txt_ndoc_ref.Text.PadLeft(15, Char.Parse("0"))
            Else
                txt_ndoc_ref.Text = txt_ndoc_ref.Text.PadLeft(7, Char.Parse("0"))
            End If

        End If
    End Sub


    Private Sub txt_tdoc_ref_Leave(sender As Object, e As EventArgs) Handles txt_tdoc_ref.Leave
        txt_tdoc_ref.Text = txt_tdoc_ref.Text.ToUpper()
    End Sub

    Private Sub cmb_doc_SelectedIndexChanged(sender As Object, e As EventArgs)
        btn_ref.Enabled = txtTipoDocAsiento.Text.Equals("NC")
    End Sub


    Private Sub MostrandoDetalles(ByVal Codigo As Integer, ByVal año As String, ByVal mes As String)
        Dim ac As ClsOperaciones.Asiento_Contable
        Dim DtAsientoDetalle As DataTable
        ac = New ClsOperaciones.Asiento_Contable
        DtAsientoDetalle = New DataTable
        DtAsientoDetalle = ac.get_Lista_Asientos_Detalles_Edit(txt_idcab.Text, año, dtp_fec_vou.Value.Month)
        dgvDetalleAsiento.DataSource = Nothing
        If DtAsientoDetalle.Rows.Count() <> 0 Then
            GenerarColummnaDataTableAsientoContable()
            For Each ff As DataRow In DtAsientoDetalle.Rows
                Ingresar_Fila_Modo_edicion(ff("AD_SECUENCIA").ToString(), ff("AD_CUENTA").ToString(), ff("PC_DES_CTA").ToString, Integer.Parse(ff("AD_TANEXO").ToString()), ff("AD_IDANEXO").ToString(), _
                                   ff("AD_TDOC").ToString(), ff("AD_SDOC").ToString(), ff("AD_NDOC").ToString(), ff("AD_FDOC").ToString(), ff("AD_VDOC").ToString(), _
                                   Double.Parse(ff("AD_DEBE").ToString()), Double.Parse(ff("AD_HABER").ToString()), Double.Parse(ff("AD_MONTO_ORI").ToString()), _
                                   Double.Parse(ff("AD_TCAM").ToString()), ff("AD_IDCC").ToString(), ff("AD_IDMEDIOPAGO").ToString(), _
                                   Integer.Parse(ff("AD_IDMONEDA").ToString()), 0, 0, Integer.Parse(ff("AD_ES_INAFECTO").ToString()), _
                                   ff("AD_TDOC_REF").ToString(), ff("AD_SDOC_REF").ToString(), ff("AD_NDOC_REF").ToString(), ff("AD_FDOC_REF").ToString(), _
                                   ff("AD_VDOC_REF").ToString(), "", Integer.Parse(ff("AD_SEC_ORI_DES").ToString()), ff("AD_GLOSA").ToString(), IIf(ff("AD_PERCEN_DETRACC").ToString = "", 0, ff("AD_PERCEN_DETRACC")), _
                                   IIf(ff("AD_CEN_COS").ToString = "", "", ff("AD_CEN_COS")))
            Next
        Else
            GenerarColummnaDataTableAsientoContable()
        End If
        ConfigurarGrillas()
        Call Sumar_Totales()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        ''If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        ''Try
        ''    If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        ''        Dim Codigo As String = String.Empty
        ''        Codigo = dgvDetalleAsiento.Item(1, dgvDetalleAsiento.CurrentRow.Index).Value
        ''        'Borrando los Datos
        ''        For Each item As DataRow In dtdetalleAsiento.Select("AD_SECUENCIA=" & Codigo & " or AD_SEC_ORI_DES=" & Codigo)
        ''            dtdetalleAsiento.BeginInit()
        ''            item.Delete()
        ''            dtdetalleAsiento.EndInit()
        ''            dtdetalleAsiento.AcceptChanges()
        ''        Next
        ''        Call Sumar_Totales()
        ''    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = txt_idcab.Text
                Dim Item As String = dgvDetalleAsiento.Item(1, dgvDetalleAsiento.CurrentRow.Index).Value
                If Codigo = String.Empty Or Item = String.Empty Then Exit Sub
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDetallesAsientoC = New DataTable
                If AsientoContableCabs.Eliminar_Asiento_Compras_Varios(CInt(Codigo), CInt(Item)) = True Then
                    MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                End If
                Call Sumar_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If gbCabecera.Enabled = True Then
            txtTipoDocAsiento.Text = txtTipoDoc.Text
            txt_ser.Text = txtSerieDoc.Text
            txt_num.Text = txtNumeroDoc.Text
            mtb_fec_emi.Text = dtpFechaDoc.Value
            mtb_fec_ven.Text = dtpFechaVencimientoDoc.Value
            gbCabecera.Enabled = False
        End If
        gb_detalle_doc.Enabled = True
        pnlDetalles.Enabled = False
        txt_cod_ane.Text = txtcodigoRuc.Text
        txt_des_ane.Text = txtdescripciontercero.Text
        cmb_moneda.SelectedValue = cboMoneda.SelectedValue
        bol_edicion_Det = False
        txtCuentaContable.Select()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        'If dgvDetalleAsiento.Rows.Count > 0 Then
        '    If dgvDetalleAsiento.Rows.Count > 0 Then
        '        Modo_Edicion()
        '        gb_detalle_doc.Enabled = True
        '        pnlDetalles.Enabled = False
        '        txtCuentaContable.Select()
        '    End If
        'End If
        If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        If dgvDetalleAsiento.Rows.Count > 0 Then
            If dgvDetalleAsiento.Rows.Count > 0 Then
                Modo_Edicion()
                gb_detalle_doc.Enabled = True
                pnlDetalles.Enabled = False
                txtCuentaContable.Select()
            End If
        End If
    End Sub

    Private Sub Guardando_Cuentas_Contable_Cabecera()
        Try
            Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New ClsOperaciones.Asiento_Contable

            If Not bol_edicion_Asiento Then
                If asiento.Existe_Num_Voucher(txt_num_vou.Text, cmb_sub.SelectedValue.ToString(), DateTime.Parse(dtp_fec_vou.Text).Year, DateTime.Parse(dtp_fec_vou.Text).Month) Then
                    txt_num_vou.Text = (Integer.Parse(txt_num_vou.Text) + 1).ToString()
                End If
            End If
            ''Ingresando Datos de la Cabecera del Asiento Contable
            cab.AC_ID = 0
            If bol_edicion_Asiento Then
                cab.AC_ID = Int64.Parse(txt_idcab.Text)
            End If
            cab.AC_IDSUBDIARIO = cmb_sub.SelectedValue.ToString()
            cab.AC_NUM_VOUCHER = txt_num_vou.Text
            cab.AC_ANHO = DateTime.Parse(dtp_fec_vou.Text).Year
            cab.AC_MES = DateTime.Parse(dtp_fec_vou.Text).Month
            cab.AC_FEC_VOUCHER = dtp_fec_vou.Text
            cab.AC_IDMONEDA = Integer.Parse(cboMoneda.SelectedValue.ToString())
            cab.AC_DEBE = Double.Parse(mtb_tot_d.Text)
            cab.AC_HABER = Double.Parse(mtb_tot_h.Text)
            cab.AC_ESTADO = 1
            cab.AC_GLOSA_VOU = txt_glosa.Text.Trim()
            cab.AC_ES_INTERFACE = 0
            cab.AC_IDPLANILLA = ""
            cab.AC_RUC = txtcodigoRuc.Text
            cab.AC_TIPO_DOC = txtTipoDoc.Text
            cab.AC_SER_DOC = txtSerieDoc.Text
            cab.AC_NUM_DOC = txtNumeroDoc.Text
            cab.AC_FEC_DOC = dtpFechaDoc.Value.ToShortDateString
            cab.AC_FEC_DOC_VENCE = dtpFechaVencimientoDoc.Value.ToShortDateString
            cab.AC_POR_IGV = IIf(txtTasa.Text = String.Empty, 0, txtTasa.Text)
            cab.AC_VAL_IGV = IIf(txtMontoIgv.Text = String.Empty, 0, txtMontoIgv.Text)
            cab.AC_TOTAL_DOC = IIf(txtMontoDoc.Text = String.Empty, 0, txtMontoDoc.Text)
            cab.AC_TIPO_CAMBIO = txtTipoCambio.Text
            cab.AC_GLOSA_TRANSACCION = txtGlosaTransaccion.Text
            cab.AC_DESTINO = txtDestino.Text
            cab.AC_POR_ISC = IIf(txtPorc_ISC.Text = String.Empty, 0, txtPorc_ISC.Text)
            cab.AC_ISC = IIf(txt_ISC.Text = String.Empty, 0, txt_ISC.Text)
            cab.AC_POR_DETRAC = IIf(txtPorc_Detrac.Text = String.Empty, 0, txtPorc_Detrac.Text)
            cab.AC_FEC_PLE = dtpFecha_PLE.Value.ToShortDateString
            cab.AC_TIPO_DOC_REF = txtTipoDocRef.Text
            cab.AC_SER_DOC_REF = txtSerieDocRef.Text
            cab.AC_NUM_DOC_REF = txtNumDocRef.Text
            cab.AC_FEC_DOC_REF = txtFechaDocRef.Value.ToShortDateString
            cab.AC_DETRAC = IIf(txtdetraccion.Text = String.Empty, 0, txtdetraccion.Text)
            cab.AC_DUA = IIf(chkdua.Checked = True, 1, 0)
            cab.AC_OP_INAFECTA = IIf(txtInafecta.Text = String.Empty, 0, txtInafecta.Text)
            cab.AC_OP_GRAVADA = IIf(txtgravada.Text = String.Empty, 0, txtgravada.Text)
            cab.AC_ID_REGCOMPRA = Strings.Mid(id_compras, 3, Len(id_compras))

            cab.AC_TIPO_DOC_DETRAC = txt_tipo_doc_detrac.Text.Trim
            cab.AC_SER_DOC_DETRAC = txt_ser_doc_detrac.Text.Trim
            cab.AC_NUM_DOC_DETRAC = txt_num_doc_detrac.Text.Trim
            cab.AC_FEC_DOC_DETRAC = dtp_fec_detrac.Value

            asiento.Guardar_Asiento_Cabecera(cab)
            txt_idcab.Text = cab.AC_ID.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Modificando_Cuentas_Contable_Cabecera()
        Try
            Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New ClsOperaciones.Asiento_Contable

            If Not bol_edicion_Asiento Then
                If asiento.Existe_Num_Voucher(txt_num_vou.Text, cmb_sub.SelectedValue.ToString(), DateTime.Parse(dtp_fec_vou.Text).Year, DateTime.Parse(dtp_fec_vou.Text).Month) Then
                    txt_num_vou.Text = (Integer.Parse(txt_num_vou.Text) + 1).ToString()
                End If
            End If
            ''Ingresando Datos de la Cabecera del Asiento Contable
            cab.AC_ID = 0
            If bol_edicion_Asiento Then
                cab.AC_ID = Int64.Parse(txt_idcab.Text)
            End If
            cab.AC_IDSUBDIARIO = cmb_sub.SelectedValue.ToString()
            cab.AC_NUM_VOUCHER = txt_num_vou.Text
            cab.AC_ANHO = DateTime.Parse(dtp_fec_vou.Text).Year
            cab.AC_MES = DateTime.Parse(dtp_fec_vou.Text).Month
            cab.AC_FEC_VOUCHER = dtp_fec_vou.Text
            cab.AC_IDMONEDA = Integer.Parse(cboMoneda.SelectedValue.ToString())
            cab.AC_DEBE = Double.Parse(mtb_tot_d.Text)
            cab.AC_HABER = Double.Parse(mtb_tot_h.Text)
            cab.AC_ESTADO = 1
            cab.AC_GLOSA_VOU = txt_glosa.Text.Trim()
            cab.AC_ES_INTERFACE = 0
            cab.AC_IDPLANILLA = ""
            cab.AC_RUC = txtcodigoRuc.Text
            cab.AC_TIPO_DOC = txtTipoDoc.Text
            cab.AC_SER_DOC = txtSerieDoc.Text
            cab.AC_NUM_DOC = txtNumeroDoc.Text
            cab.AC_FEC_DOC = dtpFechaDoc.Value.ToShortDateString
            cab.AC_FEC_DOC_VENCE = dtpFechaVencimientoDoc.Value.ToShortDateString
            cab.AC_POR_IGV = IIf(txtTasa.Text = String.Empty, 0, txtTasa.Text)
            cab.AC_VAL_IGV = IIf(txtMontoIgv.Text = String.Empty, 0, txtMontoIgv.Text)
            cab.AC_TOTAL_DOC = IIf(txtMontoDoc.Text = String.Empty, 0, txtMontoDoc.Text)
            cab.AC_TIPO_CAMBIO = txtTipoCambio.Text
            cab.AC_GLOSA_TRANSACCION = txtGlosaTransaccion.Text
            cab.AC_DESTINO = txtDestino.Text
            cab.AC_POR_ISC = IIf(txtPorc_ISC.Text = String.Empty, 0, txtPorc_ISC.Text)
            cab.AC_ISC = IIf(txt_ISC.Text = String.Empty, 0, txt_ISC.Text)
            cab.AC_POR_DETRAC = IIf(txtPorc_Detrac.Text = String.Empty, 0, txtPorc_Detrac.Text)
            cab.AC_FEC_PLE = dtpFecha_PLE.Value.ToShortDateString
            cab.AC_TIPO_DOC_REF = txtTipoDocRef.Text
            cab.AC_SER_DOC_REF = txtSerieDocRef.Text
            cab.AC_NUM_DOC_REF = txtNumDocRef.Text
            cab.AC_FEC_DOC_REF = txtFechaDocRef.Value.ToShortDateString
            cab.AC_DETRAC = IIf(txtdetraccion.Text = String.Empty, 0, txtdetraccion.Text)
            cab.AC_DUA = IIf(chkdua.Checked = True, 1, 0)
            cab.AC_OP_INAFECTA = IIf(txtInafecta.Text = String.Empty, 0, txtInafecta.Text)
            cab.AC_OP_GRAVADA = IIf(txtgravada.Text = String.Empty, 0, txtgravada.Text)
            cab.AC_ID_REGCOMPRA = Strings.Mid(id_compras, 3, Len(id_compras))

            cab.AC_TIPO_DOC_DETRAC = txt_tipo_doc_detrac.Text.Trim
            cab.AC_SER_DOC_DETRAC = txt_ser_doc_detrac.Text.Trim
            cab.AC_NUM_DOC_DETRAC = txt_num_doc_detrac.Text.Trim
            cab.AC_FEC_DOC_DETRAC = dtp_fec_detrac.Value

            asiento.Modificar_Asiento_Cabecera(cab)
            txt_idcab.Text = cab.AC_ID.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        'If ValidacionesCabecera() = False Then Exit Sub
        'pnlDetalles.Enabled = True
        'gbDetalles.Enabled = True
        'gb_detalle_doc.Enabled = False
        'If bol_edicion_Asiento = False Then btnAgregar_Click(sender, e)
        If ValidacionesCabecera() = False Then Exit Sub
        If viene_de_compras = "si" Then
            bol_edicion_Asiento = False
        End If
        If bol_edicion_Asiento = False Then
            If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Call Cargar_Numero_Voucher()
            Else
                Dim codigo As String = String.Empty
                codigo = InputBox("Ingrese numero de asiento")
                If codigo = String.Empty Then
                    MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                codigo = Format(dtp_fec_vou.Value.Month, "00") & codigo.PadLeft(4, Char.Parse("0"))
                Dim ClsasientoBl As New ClsOperaciones.Asiento_Contable
                Dim dtcodigo As New DataTable
                dtcodigo = ClsasientoBl.ValidarCodigo_Cobranzas(cmb_sub.SelectedValue.ToString, codigo, dtpFecha_PLE.Value.Year, dtpFecha_PLE.Value.Month)
                If dtcodigo.Rows.Count() <> 0 Then
                    MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    txt_num_vou.Text = codigo
                End If
            End If
            Guardando_Cuentas_Contable_Cabecera()
        End If
        pnlDetalles.Enabled = True
        gbDetalles.Enabled = True
        gb_detalle_doc.Enabled = False
        If bol_edicion_Asiento = False Then
            ''   If cmb_ope.SelectedValue = 1 And cmb_sub.SelectedValue = "01" Then
            pnlFinalizarCompra.Visible = True
            ''Else
            'pnlFinalizarCompra.Visible = False
            'End If
            If viene_de_compras = "si" Then

            Else
                btnAgregar_Click(sender, e)
            End If
        Else
            Modificando_Cuentas_Contable_Cabecera()
        End If
        If viene_de_compras = "si" Then
            Dim clo_conta As New ClsOperaciones.Asiento_Contable
            clo_conta.GrabarDetalleAsientoCompra(id_compras, CInt(txt_idcab.Text), txt_num_vou.Text)
            MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
        End If

        dgvDetalleAsiento.Focus()
    End Sub

    Private Sub txtcodigoRuc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoRuc.MouseDoubleClick
        If cmb_ope.SelectedIndex > -1 Then
            Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero)
            txtTipoDoc.Select()
        Else
            MsgBox("Debe seleccionar primeramente una Operacion.", MsgBoxStyle.Information)
            cmb_ope.Select()
        End If
    End Sub

    Private Sub txtMontoIgv_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mtb_haber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoIgv_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtMontoDoc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub mtb_debe_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub mtb_haber_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub Ayuda_Destinos(Optional ByVal _Codigo As String = "")
        Try
            If _Codigo = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CONTA_SP_S_TIPO_DESTINO"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = False
                frm.Titulo = "Tipo de Destinos"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtDestino.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtdescripcionDestino.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("TipoDestino")
                DtDatos = AsientoContableCabs.Get_ManualDestino(_Codigo)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    txtDestino.Text = DtDatos.Rows(0).Item(0).ToString
                    txtdescripcionDestino.Text = DtDatos.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtDestino.Text = String.Empty
                    txtdescripcionDestino.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDestino_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtDestino.MouseDoubleClick
        Ayuda_Destinos()
    End Sub

    Private Sub txtDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDestino.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Destinos()
        If e.KeyCode = Keys.Enter Then
            If txtDestino.Text = String.Empty Then
                Ayuda_Destinos()
            Else
                Ayuda_Destinos(txtDestino.Text)
            End If
            cboMoneda.Select()
        End If
    End Sub

    Private Sub txtNumeroDoc_Leave(sender As Object, e As EventArgs) Handles txtNumeroDoc.Leave
        If txtNumeroDoc.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then 'compras
                txtNumeroDoc.Text = txtNumeroDoc.Text.PadLeft(15, Char.Parse("0"))
            ElseIf cmb_sub.SelectedValue = "02" Then 'ventas
                txtNumeroDoc.Text = txtNumeroDoc.Text.PadLeft(7, Char.Parse("0"))
            End If

        End If
    End Sub

    Private Sub txtSerieDoc_Leave(sender As Object, e As EventArgs) Handles txtSerieDoc.Leave
        If txtSerieDoc.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then 'compras
                txtSerieDoc.Text = txtSerieDoc.Text.PadLeft(10, Char.Parse("0"))
            ElseIf cmb_sub.SelectedValue = "02" Then 'ventas
                txtSerieDoc.Text = txtSerieDoc.Text.PadLeft(3, Char.Parse("0"))
            End If

        End If
    End Sub

    Private Sub Ayuda_TipoDocumento(ByVal Texto As TextBox, Optional ByVal _Codigo As String = "")
        Try
            If _Codigo = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
                frm.CadenaConsulta = sql
                frm.Titulo = "Tipo de Documentos de Referencias"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    If Texto.Name = "txtTipoDocAsiento" Then
                        If Texto.Text = "NC" Or Texto.Text = "ND" Then
                            btn_ref.Enabled = True
                        Else
                            btn_ref.Enabled = False
                        End If
                    End If
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("TipoDoc")
                DtDatos = AsientoContableCabs.Get_ManualTipoDocumento(_Codigo)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    Texto.Text = DtDatos.Rows(0).Item(0).ToString
                    If Texto.Text = "NC" Or Texto.Text = "ND" Then
                        btn_ref.Enabled = True
                    Else
                        btn_ref.Enabled = False
                    End If
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    Texto.Text = String.Empty
                    Texto.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtTipoDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDoc.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDoc)
        txtSerieDoc.Select()
    End Sub

    Private Sub txtTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDoc.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDocumento(txtTipoDoc)
        If e.KeyCode = Keys.Enter Then
            If txtTipoDoc.Text = String.Empty Then
                Ayuda_TipoDocumento(txtTipoDoc)
            Else
                Ayuda_TipoDocumento(txtTipoDoc, txtTipoDoc.Text)
            End If
            txtSerieDoc.Select()
        End If
    End Sub

    Private Sub txtTipoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDocumento(txtTipoDocRef)
        If e.KeyCode = Keys.Enter Then
            If txtTipoDocRef.Text = String.Empty Then
                Ayuda_TipoDocumento(txtTipoDocRef)
            Else
                Ayuda_TipoDocumento(txtTipoDocRef, txtTipoDocRef.Text)
            End If
        End If
    End Sub

    Private Sub txtTipoDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocRef.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDocRef)
    End Sub

    Private Sub txtTipoDocAsiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocAsiento.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento(txtTipoDocAsiento)
        ElseIf e.KeyCode = Keys.Enter Then
            If txtTipoDocAsiento.Text = String.Empty Then
                Ayuda_TipoDocumento(txtTipoDocAsiento)
            Else
                Ayuda_TipoDocumento(txtTipoDocAsiento, txtTipoDocAsiento.Text)
            End If
            txt_ser.Select()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim ope As Integer = Integer.Parse(cmb_ope.SelectedValue.ToString())
            If ope = 3 Or ope = 5 Then 'caja bancos o generales
                Dim dp As New frm_CO_LT_DocsPendientes
                dp.str_anexo = txt_cod_ane.Text
                dp.str_cuenta = txtCuentaContable.Text
                dp.int_ayo = Date.Now.Year
                dp.ShowDialog()
                If dp.aceptar Then
                    If dp.lista.Count > 0 Then
                        txtTipoDocAsiento.Text = dp.lista(0)
                        txt_ser.Text = dp.lista(1)
                        txt_num.Text = dp.lista(2)
                        mtb_fec_emi.Text = dp.lista(3)
                        mtb_fec_ven.Text = dp.lista(4)
                        If dp.lista(5).ToString = "MN" Then
                            cmb_moneda.SelectedValue = 1
                        Else
                            cmb_moneda.SelectedValue = 2
                        End If
                        mtb_haber.Text = dp.lista(6)
                        mtb_debe.Text = dp.lista(7)
                        txt_ser.Select()
                    End If
                Else
                    txtTipoDocAsiento.Focus()
                End If
                dp.Close()
            End If
        End If
    End Sub

    Private Sub txtTipoDocAsiento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocAsiento.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDocAsiento)
    End Sub

    Private Sub txtSerieDocRef_Leave(sender As Object, e As EventArgs) Handles txtSerieDocRef.Leave
        If txtSerieDocRef.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then
                txtSerieDocRef.Text = txtSerieDocRef.Text.PadLeft(10, Char.Parse("0"))
            Else
                txtSerieDocRef.Text = txtSerieDocRef.Text.PadLeft(3, Char.Parse("0"))
            End If

        End If
    End Sub

    Private Sub txtNumDocRef_Leave(sender As Object, e As EventArgs) Handles txtNumDocRef.Leave
        If txtNumDocRef.Text.Trim().Length > 0 Then
            If cmb_sub.SelectedValue = "01" Then
                txtNumDocRef.Text = txtNumDocRef.Text.PadLeft(15, Char.Parse("0"))
            Else
                txtNumDocRef.Text = txtNumDocRef.Text.PadLeft(7, Char.Parse("0"))
            End If

        End If
    End Sub



    Private Sub Ayuda_Tercero(ByVal Texto As TextBox, ByVal Descripcion As TextBox, Optional ByVal _Codigo As String = "")
        Try
            If _Codigo = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CONTA_SP_S_ANNEXED"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = TipoAnexo
                frm.Titulo = "Terceros"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("Terceros")
                DtDatos = AsientoContableCabs.Get_ManualTercero(_Codigo)
                If DtDatos.Rows.Count() <> 0 Then
                    Texto.Text = DtDatos.Rows(0).Item(2).ToString
                    Descripcion.Text = DtDatos.Rows(0).Item(3).ToString
                Else
                    Dim frm As New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "CONTA_SP_S_ANNEXED"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = TipoAnexo
                    frm.Titulo = "Terceros"
                    frm._Cadena_Filtro = _Codigo
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                        Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    End If
                    frm.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_CuentaContable(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            If _CodigoCuentaContable = String.Empty Then
                Dim frm As New FrmBuscar_CuentaContable
                Dim sql As String = String.Empty
                sql = "CO_SP_S_PLANCTAS_MOV"
                frm.CadenaConsulta = sql
                'frm._Flag_Filtro = True
                'frm.Filtros1 = Date.Now.Year
                frm.Titulo = "Plan de Cuentas Contable"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtCuentaContable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_des_cta.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    frm.Close()
                    If txtCuentaContable.Text = String.Empty Then Exit Sub
                    Dim cuentaContable = String.Empty
                    cuentaContable = txtCuentaContable.Text
                    DetallesCuentaContable(cuentaContable)
                End If
            Else
                'AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                'DtDatos = New DataTable("CuentaContable")
                'DtDatos = AsientoContableCabs.Get_ManualCuentaContable(_CodigoCuentaContable)
                'Dim codArticulo As String = String.Empty
                'If DtDatos.Rows.Count() <> 0 Then
                '    txtCuentaContable.Text = DtDatos.Rows(0).Item(0).ToString
                '    txt_des_cta.Text = DtDatos.Rows(0).Item(1).ToString
                '    If txtCuentaContable.Text = String.Empty Then Exit Sub
                '    Dim cuentaContable = String.Empty
                '    cuentaContable = txtCuentaContable.Text
                '    DetallesCuentaContable(cuentaContable)
                'Else
                Dim frm As New FrmBuscar_CuentaContable
                Dim sql As String = String.Empty
                sql = "CO_SP_S_PLANCTAS_MOV"
                frm.CadenaConsulta = sql
                'frm._Flag_Filtro = True
                'frm.Filtros1 = Date.Now.Year
                frm.Titulo = "Plan de Cuentas Contable"
                frm._Cadena_Filtro = _CodigoCuentaContable
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtCuentaContable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_des_cta.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    frm.Close()
                    If txtCuentaContable.Text = String.Empty Then Exit Sub
                    Dim cuentaContable = String.Empty
                    cuentaContable = txtCuentaContable.Text
                    DetallesCuentaContable(cuentaContable)
                End If
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_CuentaContable_Manual(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDatos = New DataTable("CuentaContable")
            DtDatos = AsientoContableCabs.Get_ManualCuentaContable(_CodigoCuentaContable)
            Dim codArticulo As String = String.Empty
            If DtDatos.Rows.Count() <> 0 Then
                txtCuentaContable.Text = DtDatos.Rows(0).Item(0).ToString
                txt_des_cta.Text = DtDatos.Rows(0).Item(1).ToString
                If txtCuentaContable.Text = String.Empty Then Exit Sub
                Dim cuentaContable = String.Empty
                cuentaContable = txtCuentaContable.Text
                DetallesCuentaContable(cuentaContable)
            Else
                MsgBox("No existe información con la cuenta asignada.", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCuentaContable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaContable.MouseDoubleClick
        Ayuda_CuentaContable(txtCuentaContable.Text.Trim)
        If txt_cen_cos.Enabled = False Then
            If txt_cod_ane.Enabled = False Then
                txtTipoDocAsiento.Select()
            Else
                txt_cod_ane.Select()
            End If
        Else
            txt_cen_cos.Select()
        End If


    End Sub

    Private Sub txtCuentaContable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_CuentaContable(txtCuentaContable.Text.Trim)
        If e.KeyCode = Keys.Enter Then
            If txtCuentaContable.Text = String.Empty Then
                Ayuda_CuentaContable(txtCuentaContable.Text.Trim)
            Else
                Ayuda_CuentaContable_Manual(txtCuentaContable.Text.Trim)
            End If
            If txt_cen_cos.Enabled = False Then
                If txt_cod_ane.Enabled = False Then
                    txtTipoDocAsiento.Select()
                Else
                    txt_cod_ane.Select()
                End If
            Else
                txt_cen_cos.Select()
            End If
        End If
    End Sub

    Private Sub txtcodigoRuc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoRuc.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmb_ope.SelectedIndex > -1 Then
                If TipoAnexo = String.Empty Then Exit Sub
                Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero)
            Else
                MsgBox("Debe seleccionar primeramente una Operacion.", MsgBoxStyle.Information)
                cmb_ope.Select()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If cmb_ope.SelectedIndex > -1 Then
                If TipoAnexo = String.Empty Then Exit Sub
                If txtcodigoRuc.Text = String.Empty Then
                    Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero)
                Else
                    Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero, txtcodigoRuc.Text)
                End If
            Else
                MsgBox("Debe seleccionar primeramente una Operacion.", MsgBoxStyle.Information)
                cmb_ope.Select()
            End If
            txtTipoDoc.Select()
        End If
    End Sub

    Private Sub txt_glosa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_glosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_nuevo.Select()
        End If
    End Sub


    Private Sub TipoAnexos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_TIPO_ANEXO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipos de Anexos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                If frm.Data_Matriz.Rows(0).Item(0).ToString = String.Empty Then
                    TipoAnexo = ""
                Else
                    TipoAnexo = frm.Data_Matriz.Rows(0).Item(0).ToString
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTipoAnexo_Click(sender As Object, e As EventArgs) Handles btnTipoAnexo.Click
        txtcodigoRuc.Text = String.Empty
        txtdescripciontercero.Text = String.Empty
        TipoAnexos()
    End Sub

    Private Sub cmb_ope_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ope.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_sub.Select()
        End If
    End Sub

    Private Sub cmb_sub_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_sub.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fec_vou.Select()
        End If
    End Sub

    Private Sub txtgravada_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPorc_ISC.Select()
        End If
    End Sub

    Private Sub txtFechaDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPorc_ISC.Select()
        End If
    End Sub

    Private Sub mtb_fec_emi_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_emi.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmb_moneda.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un tipo de Moneda.", MsgBoxStyle.Critical)
                cmb_moneda.Select()
                Exit Sub
            End If

            If IsDate(mtb_fec_emi.Text) = False Then
                MsgBox(" La Fecha Ingresada no posee un formato Correcto. ", MsgBoxStyle.Information, "Error al ingresar la fecha ")
                mtb_fec_emi.Select()
                Exit Sub
            End If
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TipoCambioFecha")
            Dim Sql = String.Empty
            Dim FechaIngr As Date
            Sql = "SELECT * FROM dbo.CO_TB_PLANCTAS WHERE PC_NUM_CTA='" & txtCuentaContable.Text & "'"
            DtDetallesAsientoC = AsientoContableCabs.Muestra_Opcion_TC(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                If DtDetallesAsientoC.Rows(0).Item("PC_TCAMBIO").ToString = 1 Then
                    If cboMoneda.SelectedValue = "1" Then
                        FechaIngr = mtb_fec_emi.Text
                    ElseIf cboMoneda.SelectedValue = "2" Then
                        If FechaIngr.ToString("dddd") = "martes" Then
                            FechaIngr = FechaIngr.AddDays(0)
                        ElseIf FechaIngr.ToString("ddddd") = "lunes" Then
                            FechaIngr = FechaIngr.AddDays(0)
                        Else
                            FechaIngr = FechaIngr.AddDays(0)
                        End If
                    End If
                Else
                    FechaIngr = mtb_fec_emi.Text
                End If
                SendKeys.Send("{TAB}")
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                mtb_tc.Text = String.Empty
                mtb_fec_emi.Focus()
            End If

            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TipoCambioFecha")
            Sql = "SELECT SELL_RATE FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr & "'"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                If cmb_sub.SelectedValue = "03" Then
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("BUY_RATE").ToString
                ElseIf cmb_sub.SelectedValue = "04" Then
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
                Else
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
                End If
                SendKeys.Send("{TAB}")
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                mtb_tc.Text = String.Empty
                mtb_fec_emi.Select()
            End If
        End If
    End Sub

    Private Sub dtpFechaDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim FechaIngr As Date
            FechaIngr = dtpFechaDoc.Value
            If FechaIngr.ToString("dddd") = "domingo" Then
                FechaIngr = FechaIngr.AddDays(0)
            ElseIf FechaIngr.ToString("ddddd") = "lunes" Then
                FechaIngr = FechaIngr.AddDays(0)
            End If
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TipoCambioFecha")
            Dim Sql = String.Empty
            Sql = "SELECT * FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr.ToString("dd/MM/yyyy") & "'"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                txtTipoCambio.Text = Math.Round(CDbl(DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString), 3)

                dtpFechaVencimientoDoc.Focus()
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                txtTipoCambio.Text = String.Empty
                dtpFechaDoc.Select()
            End If
        End If
    End Sub

    Private Sub dtp_fec_vou_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_vou.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFecha_PLE.Select()
        End If
    End Sub

    Private Sub txtSerieDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNumeroDoc.Select()
        End If
    End Sub

    Private Sub txtNumeroDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechaDoc.Select()
        End If
    End Sub

    Private Sub dtpFechaVencimientoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaVencimientoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDestino.Select()
        End If
    End Sub

    Private Sub txtInafecta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInafecta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgravada.Select()
        End If
    End Sub

    Private Sub txtgravada_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgravada.KeyDown
        If e.KeyCode = Keys.Enter Then
            If viene_de_compras = "si" Then
                txtMontoIgv.Select()
            Else
                Dim res As Double = 0
                res = CDbl(Val(txtgravada.Text) * (Val(txtTasa.Text) / 100))
                txtMontoIgv.Text = Math.Round(res, 2)
                txtMontoIgv.Select()
            End If

        End If
    End Sub

    Private Sub txtMontoIgv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoIgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            If viene_de_compras = "si" Then
                txtMontoDoc.Select()
            Else
                Dim res As Double = 0
                res = CDbl(Val(IIf(txtInafecta.Text = "", 0, txtInafecta.Text)) + Val(IIf(txtgravada.Text = "", 0, txtgravada.Text)) + Val(IIf(txtMontoIgv.Text = "", 0, txtMontoIgv.Text)))
                txtMontoDoc.Text = Math.Round(res, 2)
                txtMontoDoc.Select()
            End If

        End If
    End Sub

    Private Sub txtTasa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTasa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoDoc.Select()
        End If
    End Sub

    Private Sub cboMoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtInafecta.Select()
        End If
    End Sub

    Private Sub txt_ISC_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ISC.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPorc_Detrac.Select()
        End If
    End Sub

    Private Sub txtPorc_Detrac_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorc_Detrac.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdetraccion.Select()
        End If
    End Sub

    Private Sub txtdetraccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdetraccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGlosaTransaccion.Select()
        End If
    End Sub

    Private Sub txtGlosaTransaccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGlosaTransaccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_glosa.Select()
        End If
    End Sub

    Private Sub txt_ser_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num.Select()
        End If
    End Sub

    Private Sub txt_num_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_moneda.Select()
        End If
    End Sub

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_emi.Select()
        End If
    End Sub

    Private Sub mtb_debe_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            mtb_haber.Select()
        End If
    End Sub

    Private Sub mtb_haber_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_glosa_det.Select()
        End If
    End Sub

    Private Sub txt_glosa_det_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_glosa_det.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmb_cc.Enabled = False Then
                If txtCentroCosto.Visible = True Then
                    txtCentroCosto.Select()
                Else
                    If cmb_mp.Enabled = False Then
                        btn_ok_Click(sender, e)
                    Else
                        cmb_mp.Select()
                    End If
                End If
            Else
                If txtCentroCosto.Visible = True Then
                    txtCentroCosto.Select()
                Else
                    cmb_cc.Select()
                End If

            End If
        End If

    End Sub

    Private Sub cmb_cc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_cc.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_mp.Select()
        End If
    End Sub

    Private Sub cmb_mp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_mp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_ok.Select()
        End If
    End Sub

    Private Sub btn_can_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_can.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num.Select()
        End If
    End Sub

    Private Sub txtPorc_ISC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorc_ISC.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ISC.Select()
        End If

    End Sub

    Private Sub mtb_fec_ven_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_ven.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_debe.Select()
        End If
    End Sub

    Private Sub DetallesCentroCosto(Optional ByVal _CodigoCentroCosto As String = "")
        Try
            If _CodigoCentroCosto = String.Empty Then
                Dim frm As New FrmBuscar_Centro_Costo
                Dim sql As String = String.Empty
                sql = "CONTA_SP_S_DETALLES_CENTER_COST"
                frm.CadenaConsulta = sql
                frm.Titulo = "Centros de costo"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtCentroCosto.Text = String.Empty
                    txtCentroCosto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString & " : " & frm.Data_Matriz.Rows(0).Item(0).ToString
                    If txtCentroCosto.Text = String.Empty Then Exit Sub
                    txt_d1.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txt_d2.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("CentroCostoManual")
                DtDatos = AsientoContableCabs.Get_ManualCentroCosto(_CodigoCentroCosto)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    txtCentroCosto.Text = String.Empty
                    txtCentroCosto.Text = DtDatos.Rows(0).Item(1).ToString & " : " & DtDatos.Rows(0).Item(0).ToString
                    If txtCentroCosto.Text = String.Empty Then Exit Sub
                    txt_d1.Text = DtDatos.Rows(0).Item(1).ToString
                    txt_d2.Text = DtDatos.Rows(0).Item(2).ToString
                Else
                    Dim frm As New FrmBuscar_Centro_Costo
                    Dim sql As String = String.Empty
                    sql = "CONTA_SP_S_DETALLES_CENTER_COST"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Centros de costo"
                    frm._Cadena_Filtro = _CodigoCentroCosto
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        txtCentroCosto.Text = String.Empty
                        txtCentroCosto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString & " : " & frm.Data_Matriz.Rows(0).Item(0).ToString
                        If txtCentroCosto.Text = String.Empty Then Exit Sub
                        txt_d1.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                        txt_d2.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    End If
                    frm.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCentroCosto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCentroCosto.MouseDoubleClick
        DetallesCentroCosto(txtCuentaContable.Text.Trim)
        If cmb_mp.Enabled = False Then
            btn_ok.Focus()
        Else
            cmb_mp.Focus()
        End If
    End Sub

    Private Sub txtCentroCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCentroCosto.KeyDown
        If e.KeyCode = Keys.F1 Then
            DetallesCentroCosto(txtCuentaContable.Text.Trim)
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Enter Then
            If cmb_mp.Enabled = False Then
                'If txtCentroCosto.Text = String.Empty Then
                '    DetallesCentroCosto(txtCuentaContable.Text.Trim)
                'Else
                '    DetallesCentroCosto(txtCentroCosto.Text)
                'End If
                'btn_ok_Click(sender, e)
                btn_ok.Focus()
            Else
                cmb_mp.Focus()
            End If
        End If

    End Sub

    Private Sub mtb_debe_KeyDown_1(sender As Object, e As KeyEventArgs) Handles mtb_debe.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_haber.Select()
        End If
    End Sub

    Private Sub mtb_haber_KeyDown_1(sender As Object, e As KeyEventArgs) Handles mtb_haber.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_glosa_det.Select()
        End If
    End Sub

    Private Sub txtgravada_Leave(sender As Object, e As EventArgs) Handles txtgravada.Leave
        If viene_de_compras = "si" Then
            txtMontoIgv.Select()
        Else
            If txtgravada.Text.Trim().Length > 0 Then
                Dim res As Double = 0
                res = CDbl(Val(txtgravada.Text) * (Val(txtTasa.Text) / 100))
                txtMontoIgv.Text = res
                txtMontoIgv.Select()
            End If
        End If

    End Sub

    Public Sub Salir()
        Try
            If txt_idcab.Text = String.Empty Then Exit Sub
            If cmb_ope.SelectedIndex > -1 Then
                If Flag_Estado_Fin = True Then Exit Sub
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                AsientoContableCabs.UpdateComprasVarios(txt_idcab.Text, cmb_sub.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frm_CO_LT_IngVoucher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Salir()
    End Sub

    Private Sub FinalizarCompra()
        Try
            Dim carteraBE As ClsEntidades.CUSTOMER_BALANCE_PAY
            Dim CarteraBl As ClsOperaciones.Asiento_Contable
            CarteraBl = New ClsOperaciones.Asiento_Contable
            Dim dtFinalizarCompra As DataTable
            dtFinalizarCompra = New DataTable

            Dim ListaDetalles As New List(Of ClsEntidades.CUSTOMER_BALANCE_PAY)
            dtFinalizarCompra = CarteraBl.Finalizar_Compra_Detalles(txt_idcab.Text, cmb_sub.SelectedValue.ToString, txt_num_vou.Text, dtp_fec_vou.Value.ToString("dd/MM/yyyyy"))
            If dtFinalizarCompra.Rows.Count() <> 0 Then
                For Each item As DataRow In dtFinalizarCompra.Rows
                    carteraBE = New ClsEntidades.CUSTOMER_BALANCE_PAY
                    With carteraBE
                        CarteraBl = New ClsOperaciones.Asiento_Contable
                        Dim dtVerificarRuc As New DataTable
                        dtVerificarRuc = CarteraBl.Verificar_Ruc_Proveedor(item("AD_IDANEXO"))
                        If dtVerificarRuc.Rows.Count() = 0 Then
                            MsgBox("No existe el Proveedor con el Ruc especificado.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        .CUSTOMER_ID = dtVerificarRuc.Rows(0).Item("CODIGO").ToString
                        .DOCUMENT_ID = item("AD_TDOC")
                        .NUMBER_DOC = item("AD_SDOC") + item("AD_NDOC")
                        .DOC_DATE = item("AD_FDOC").ToString
                        .CADUCATE_DATE = item("AD_VDOC").ToString
                        .DOCUMENT_REF = ""
                        .NUMBER_REF = ""
                        .SALES_ID = "0000"
                        .AMOUNT = item("AMOUNT")
                        .AMOUNT_BALANCE = .AMOUNT
                        If item("AD_IDMONEDA") = 1 Then
                            .CURRENCY_ID = "MN"
                        ElseIf item("AD_IDMONEDA") = 2 Then
                            .CURRENCY_ID = "ME"
                        End If
                        .SELL_RATE = item("AD_TCAM")
                        .IS_DR_CR = "0"
                        .STATUS = "V"
                        .CREATE_DATE = Date.Now.ToShortDateString
                        .LAST_MODIFIED = Date.Now.ToShortDateString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .ACCOUNT = ""
                        .AMOUNT_COMM = 0
                        .TYPE_REC = ""
                        .REFERENCE_DATE = Date.Now.ToShortDateString
                        .IS_CHECK_DIF = ""
                        .AMOUNT_BALANCE_INI = item("AMOUNT")
                        .TERMS = ""
                        .PLACE_SALES = ""
                        .BANK_ID = ""
                        .BANK_DESCRIPTION = ""
                        .AMOUNT_PER = 0
                        .PERCENT_PER = 0
                        .ACCOUNT_PER = ""
                        .CUST_AUTO = 0
                        .SERIE_AUX = item("AD_SDOC")
                        .NUM_DOC_AUX = item("AD_NDOC")
                        .PERCENT_DETRAC = 0
                        .AMOUNT_DETRAC = item("AD_PERCEN_DETRACC")
                        .SALDO = .AMOUNT
                        .NUM_REF_ASIENTO = txt_idcab.Text
                        .VOUCHER_REF_ASIENTO = txt_num_vou.Text
                        .FECHA_REF_ASIENTO = dtp_fec_vou.Value.ToString("dd/MM/yyyyy")
                    End With
                    ListaDetalles.Add(carteraBE)
                Next
            End If
            CarteraBl = New ClsOperaciones.Asiento_Contable
            If CarteraBl.Guardar_Finalizar_Compras(ListaDetalles) Then
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                If AsientoContableCabs.UpdateCompras(txt_idcab.Text, cmb_sub.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text)) Then
                    MsgBox("Asiento Finalizado correctamente.", MsgBoxStyle.Information)
                    pnlFinalizarCompra.Visible = False
                    Flag_Estado_Fin = True
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click

        If dtdetalleAsiento.Rows.Count() = 0 Then
            MsgBox("Falta ingresar el detalle del Asiento.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        If dtdetalleAsiento.Rows.Count() <> 0 Then
            For Each row As DataRow In dtdetalleAsiento.Select("AD_CUENTA='' ", "")
                'MessageBox.Show("Falta ingresar cuentas contables en los items.", "Sistemas", MessageBoxButtons, MessageBoxIcon.Stop)
                MsgBox("Falta ingresar cuentas contables en los items.", MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            Next
        End If

        If cmb_ope.SelectedValue = 1 And (cmb_sub.SelectedValue = "01" Or cmb_sub.SelectedValue = "11") Then 'compras y compras no dommiciliadas
            'If mtb_tot_d.Text = 0 And mtb_tot_h.Text = 0 Then Exit Sub
            If Val(mtb_tot_d.Text) = Val(mtb_tot_h.Text) Then
                If MessageBox.Show("Se va a proceder a Finalizar la compra." & vbCrLf & "¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    FinalizarCompra()
                End If
            Else
                MsgBox("El asiento Contable no cuadra en valores, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        ElseIf cmb_ope.SelectedValue = 2 And cmb_sub.SelectedValue = "02" Then 'ventas
            'If mtb_tot_d.Text = 0 And mtb_tot_h.Text = 0 Then Exit Sub
            If Val(mtb_tot_d.Text) = Val(mtb_tot_h.Text) Then
                If MessageBox.Show("Se va a proceder a Finalizar el Asiento Contable." & vbCrLf & "¿Desea continuar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    FinalizarCompraVarios()
                End If
            Else
                MsgBox("El asiento Contable no cuadra en valores, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub FinalizarCompraVarios()
        Try
            Dim CarteraBl As ClsOperaciones.Asiento_Contable
            CarteraBl = New ClsOperaciones.Asiento_Contable
            If CarteraBl.Guardar_Finalizar_Compras_Varios(txt_idcab.Text, cmb_sub.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text)) Then
                MsgBox("Asiento Finalizado correctamente.", MsgBoxStyle.Information)
                pnlFinalizarCompra.Visible = False
                Flag_Estado_Fin = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_PLE_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha_PLE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcodigoRuc.Select()
        End If
    End Sub

    Private Sub txtGlosaTransaccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosaTransaccion.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtGlosaTransaccion.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_glosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_glosa.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_glosa.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_glosa_det_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_glosa_det.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_glosa_det.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_detraccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_detraccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_glosa_det.Select()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub


    Private Sub txt_tipo_doc_detrac_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tipo_doc_detrac.MouseDoubleClick
        Ayuda_TipoDocumento(txt_tipo_doc_detrac)
    End Sub

    Private Sub txt_tipo_doc_detrac_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_doc_detrac.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoDocumento(txt_tipo_doc_detrac)
        If e.KeyCode = Keys.Enter Then
            If txt_tipo_doc_detrac.Text = String.Empty Then
                Ayuda_TipoDocumento(txt_tipo_doc_detrac)
            Else
                Ayuda_TipoDocumento(txt_tipo_doc_detrac, txt_tipo_doc_detrac.Text)
                txt_ser_doc_detrac.Focus()
            End If
        End If
    End Sub


    Private Sub txt_ser_doc_detrac_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ser_doc_detrac.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_doc_detrac.Focus()
        End If
    End Sub

    Private Sub txt_num_doc_detrac_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_doc_detrac.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fec_detrac.Focus()
        End If
    End Sub

    Private Sub btn_act_detrac_Click(sender As Object, e As EventArgs) Handles btn_act_detrac.Click
        If MessageBox.Show("¿Desea actualizar los datos de la Detracción para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Guardando_Datos_Detraccion() = True Then
                MsgBox("Actualización generada correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error al actualizar los datos, verifique.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Function Guardando_Datos_Detraccion() As Boolean
        Dim _estado As Boolean = True
        Try
            Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New ClsOperaciones.Asiento_Contable

            cab.AC_ID = Int64.Parse(txt_idcab.Text)

            cab.AC_TIPO_DOC_DETRAC = txt_tipo_doc_detrac.Text.Trim
            cab.AC_SER_DOC_DETRAC = txt_ser_doc_detrac.Text.Trim
            cab.AC_NUM_DOC_DETRAC = txt_num_doc_detrac.Text.Trim
            cab.AC_FEC_DOC_DETRAC = dtp_fec_detrac.Value

            asiento.Guardar_Datos_Detraccion(cab)
        Catch ex As Exception
            _estado = False
            MsgBox(ex.Message)
        End Try
        Return _estado
    End Function

    Private Sub txt_tdoc_ref_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tdoc_ref.MouseDoubleClick
        Ayuda_TipoDocumento(txt_tdoc_ref)
    End Sub

    Private Sub txt_tdoc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tdoc_ref.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento(txt_tdoc_ref)
        ElseIf e.KeyCode = Keys.Enter Then
            If txtTipoDocAsiento.Text = String.Empty Then
                Ayuda_TipoDocumento(txt_tdoc_ref)
            End If
            txt_sdoc_ref.Select()
        End If
    End Sub

    Private Sub txt_sdoc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sdoc_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ndoc_ref.Select()
        End If
    End Sub

    Private Sub txt_ndoc_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ndoc_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_emi.Select()
        End If
    End Sub

    Private Sub mtb_fec_emi_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_emi_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_ven.Select()
        End If
    End Sub

    Private Sub mtb_fec_ven_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_ven_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar_ref.Focus()
        End If
    End Sub

    Private Sub txt_cen_cos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cen_cos.MouseDoubleClick
        Ayuda_Cen_Cos()
    End Sub

    Private Sub txt_cen_cos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cen_cos.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Cen_Cos()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_ane.Enabled = True Then
                txt_cod_ane.Focus()
            Else
                txtTipoDocAsiento.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Cen_Cos(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_CENCOS_MOV"
            frm.CadenaConsulta = sql
            'frm._Flag_Filtro = True
            'frm.Filtros1 = Date.Now.Year
            frm.Titulo = "Lista de Centros de Costos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cen_cos.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_cen_cos_des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                frm.Close()
                If txt_cod_ane.Enabled = True Then
                    txt_cod_ane.Focus()
                Else
                    txtTipoDocAsiento.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class