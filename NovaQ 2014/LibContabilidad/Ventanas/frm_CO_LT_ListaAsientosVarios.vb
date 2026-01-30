Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing


Public Class frm_CO_LT_ListaAsientosVarios
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim AsientoCabeceraBl As ClsOperaciones.Asiento_Contable
    Dim Fila As Integer = 0

    Dim TipoAnexo As String = String.Empty
    Dim tipoAnexoDet As Integer = 0
    Dim bol_edicion_Det As Boolean = False
    Public bol_edicion_Asiento As Boolean = False

    Dim AsientoContableCabs As ClsOperaciones.Asiento_Contable
    Dim DtDetallesAsientoC As DataTable
    Dim DtDatos As DataTable

    'Dim reporteBL As ClsBuscar
    'Dim crystalBL As LibReportes.ClsReporte
    'Dim dtImprimir As DataTable
    Public Flag_Estado_Fin As Boolean = False

    Dim NumeracionAsientoContable As String

    Dim dtdetalleAsiento As DataTable
    Public id_asiento As String

    Private Sub frm_CO_LT_ListaAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Operaciones()
        Call Cargar_Meses_en_Combo(cmb_meses)
        Call Cargar_Combos()
        Call Cargar_Moneda()
        Call ParametrosSistema()
        cmb_ope.Focus()
    End Sub

    Private Sub Formating()
        'For i As Integer = 0 To dgv_asientos.Columns.Count - 1
        '    dgv_asientos.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        'Next
        For i As Integer = 0 To dgv_asientos.Rows.Count() - 1
            If dgv_asientos.Item(6, i).Value = "P" Then
                dgv_asientos.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                dgv_asientos.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Red
            End If
        Next

        dgv_asientos.Update()
    End Sub

    Public Sub Cargar_Lista_Asientos()
        If cmb_sub.SelectedIndex <> -1 Then
            If cmb_meses.SelectedIndex <> -1 Then

                Dim ac As New ClsOperaciones.Asiento_Contable
                Dim dtListaAsientos As DataTable
                dtListaAsientos = New DataTable
                dtListaAsientos = ac.get_Lista_Asientos(cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1)
                dgv_asientos.DataSource = dtListaAsientos

                For i = 0 To dgv_asientos.ColumnCount - 1
                    dgv_asientos.Columns(i).Visible = False
                Next
                ac = Nothing
                '     //formateamos la grilla
                dgv_asientos.Columns("AC_ID").Visible = False
                dgv_asientos.Columns("AC_NUM_VOUCHER").Width = 60
                dgv_asientos.Columns("AC_NUM_VOUCHER").Visible = True
                dgv_asientos.Columns("AC_FEC_VOUCHER").Width = 70
                dgv_asientos.Columns("AC_FEC_VOUCHER").Visible = True
                dgv_asientos.Columns("AC_IDMONEDA").Width = 40
                dgv_asientos.Columns("AC_IDMONEDA").Visible = True
                dgv_asientos.Columns("AC_DEBE").Width = 100
                dgv_asientos.Columns("AC_DEBE").Visible = True
                dgv_asientos.Columns("AC_HABER").Width = 100
                dgv_asientos.Columns("AC_HABER").Visible = True
                dgv_asientos.Columns("AC_ESTADO").Width = 55
                dgv_asientos.Columns("AC_ESTADO").Visible = True
                dgv_asientos.Columns("AC_GLOSA_VOU").Width = 450
                dgv_asientos.Columns("AC_GLOSA_VOU").Visible = True
                dgv_asientos.Columns("AC_ES_INTERFACE").Visible = False
                dgv_asientos.Columns("AC_IDMONEDA").Visible = True



                dgv_asientos.Columns("AC_FEC_VOUCHER").HeaderText = "Fecha"
                dgv_asientos.Columns("AC_NUM_VOUCHER").HeaderText = "Num.Vou"
                dgv_asientos.Columns("AC_DEBE").HeaderText = "Debe"
                dgv_asientos.Columns("AC_HABER").HeaderText = "Haber"
                dgv_asientos.Columns("AC_ESTADO").HeaderText = "Estado"
                dgv_asientos.Columns("AC_GLOSA_VOU").HeaderText = "Glosa"
                dgv_asientos.Columns("AC_IDMONEDA").HeaderText = "Mon"

                dgv_asientos.Columns("AC_DEBE").DefaultCellStyle.Format = "N2"
                dgv_asientos.Columns("AC_HABER").DefaultCellStyle.Format = "N2"
                dgv_asientos.Columns("AC_FEC_VOUCHER").DefaultCellStyle.Format = "d"

                dgv_asientos.Columns("AC_DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv_asientos.Columns("AC_HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgv_asientos.Columns("AC_NUM_VOUCHER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv_asientos.Columns("AC_ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Formating()
            End If
        End If
    End Sub

    Public Sub Cargar_Operaciones()
        Dim ope As New ClsOperaciones.CO_TB_OPERACION
        Dim dtdetalle As New DataTable
        dtdetalle = ope.get_OperacionesVarios()
        cmb_ope.DisplayMember = "OP_DESCRIPCION"
        cmb_ope.ValueMember = "OP_ID"
        cmb_ope.DataSource = dtdetalle
        ope = Nothing
        cmb_ope.SelectedIndex = -1
    End Sub

    Private Sub cmb_ope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ope.SelectedIndexChanged
        If cmb_ope.SelectedIndex >= 0 Then
            Dim ope As Integer = Integer.Parse(cmb_ope.SelectedValue.ToString())
            Dim su As New ClsOperaciones.CO_TB_SUBDIARIO
            cmb_sub.DataSource = su.get_Subdiario_x_Ope(ope)
            cmb_sub.DisplayMember = "SD_DESCRIPCION"
            cmb_sub.ValueMember = "SD_ID"
            su = Nothing
            cmb_sub.SelectedIndex = 0
            cmb_ope.Focus()
        End If
    End Sub

    Private Sub tool_nuevo_Click(sender As Object, e As EventArgs) Handles tool_nuevo.Click
        Botonera_Estado_Cambiar(True)
        dgv_asientos.Visible = False
        groupBox1.Visible = False

        If bol_edicion_Asiento Then
            Me.Text = "Voucher (Edicion) "
            If Flag_Estado_Fin = True Then
                'If cmb_ope.SelectedValue = 5 And cmb_sub.SelectedValue = "08" Then
                'pnlFinalizarCompra.Visible = False
                btn_remplaza_finalizar.Visible = False
                gbCabecera.Enabled = False
                '' End If
            Else
                'If cmb_ope.SelectedValue = 5 And cmb_sub.SelectedValue = "08" Then
                'pnlFinalizarCompra.Visible = True
                btn_remplaza_finalizar.Visible = True
                'Else
                '    pnlFinalizarCompra.Visible = False
                'End If
                gbCabecera.Enabled = True
            End If
            txt_glosa.Select()
        Else
            GenerarColummnaDataTableAsientoContable()
            Me.Text = "Voucher (Nuevo) "
            bol_edicion_Asiento = False
            'Call Cargar_Combos()
            'Cargar_Moneda()
            Call Iniciar()
            txtTipoCambio.Text = ClsVarComun.TCVenta

            gbCabecera.Enabled = True

            pnlDetalles.Enabled = True
            GroupBox2.Enabled = False
            gbDetalles.Enabled = True
            gb_detalle_doc.Enabled = False
            dgvDetalleAsiento.Enabled = True

            cmb_ope_detalle.Select()
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            tool_nuevo.Enabled = False
            btn_importar_asientos.Enabled = False
            tool_editar.Enabled = False
            tool_eliminar.Enabled = False
            tool_imprimir.Enabled = False
            tool_anular.Enabled = False
            tool_actualizar.Enabled = False
            Tool_reaperturar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            tool_nuevo.Enabled = True
            btn_importar_asientos.Enabled = True
            tool_editar.Enabled = True
            tool_eliminar.Enabled = True
            tool_imprimir.Enabled = True
            tool_anular.Enabled = True
            tool_actualizar.Enabled = True
            Tool_reaperturar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub tool_editar_Click(sender As Object, e As EventArgs) Handles tool_editar.Click

        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount > 0 Then
            If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                MsgBox("El Asiento contable no posee codigo, no se puede Modificar.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Not dgv_asientos.CurrentRow Is Nothing Then

                Fila = dgv_asientos.CurrentRow.Index
                Dim id As Integer = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())


                'Dim ff As New frm_CO_LT_IngVoucherVarios
                'ff.id_asiento = id
                'ff.bol_edicion_Asiento = True
                'Dim EstaDoc As String = String.Empty
                'EstaDoc = dgv_asientos.CurrentRow.Cells("AC_ESTADO").Value.ToString() 'dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
                'If EstaDoc = "F" Then ff.Flag_Estado_Fin = True Else ff.Flag_Estado_Fin = False
                'ff.GenerarColummnaDataTableAsientoContable()
                'ff.Cargar_Asiento_Editar(Integer.Parse(cmb_ope.SelectedValue.ToString()), id, cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1)
                'ff.ShowDialog()
                'Cargar_Lista_Asientos()
                'If dgv_asientos.Rows.Count() <> 0 Then
                '    dgv_asientos.CurrentCell = dgv_asientos.Rows(Fila).Cells(2)
                'End If

                Try
                    id_asiento = id
                    bol_edicion_Asiento = True
                    Me.Cursor = Cursors.WaitCursor
                    Dim EstaDoc As String = String.Empty
                    EstaDoc = dgv_asientos.CurrentRow.Cells("AC_ESTADO").Value.ToString() 'dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
                    If EstaDoc = "F" Then Flag_Estado_Fin = True Else Flag_Estado_Fin = False
                    GenerarColummnaDataTableAsientoContable()
                    Cargar_Asiento_Editar(Integer.Parse(cmb_ope.SelectedValue.ToString()), id, cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1)
                    Botonera_Estado_Cambiar(True)
                    dgv_asientos.Visible = False
                    groupBox1.Visible = False

                    If Flag_Estado_Fin = True Then
                        'pnlFinalizarCompra.Visible = False
                        btn_remplaza_finalizar.Visible = False
                        gbCabecera.Enabled = False
                        pnlDetalles.Enabled = True
                        GroupBox2.Enabled = False
                        gbDetalles.Enabled = True
                        gb_detalle_doc.Enabled = False
                        dgvDetalleAsiento.Enabled = True
                    Else
                        'pnlFinalizarCompra.Visible = True
                        btn_remplaza_finalizar.Visible = True
                        btn_remplaza_finalizar.Enabled = True
                        gbCabecera.Enabled = True

                        pnlDetalles.Enabled = True
                        GroupBox2.Enabled = False
                        gbDetalles.Enabled = True
                        gb_detalle_doc.Enabled = False
                        dgvDetalleAsiento.Enabled = True
                        cboMoneda.Enabled = True
                    End If
                    txt_glosa.Select()

                    'txt_glosa.Focus()
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message)
                End Try
                
            End If
        End If
    End Sub

    Private Sub tool_eliminar_Click(sender As Object, e As EventArgs) Handles tool_eliminar.Click
        Dim ac As ClsOperaciones.Asiento_Contable
        Dim dtVerficar As DataTable

        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount > 0 Then
            If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                MsgBox("El Asiento contable no posee codigo.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim _ESTADO As String = String.Empty
            _ESTADO = dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
            If _ESTADO = "A" Then
                MsgBox("El asiento se encuentra Anulado.", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf _ESTADO = "F" Then
                MsgBox("El asiento se encuentra Finalizado.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Verificar_Apertura_Cierre_Modulos(CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Month, CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Year) = False Then
                Exit Sub
            End If

            If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "08" Then 'valida compras varios
                Dim _CODIGO As Integer = 0
                Dim _VOUCHER As String = String.Empty
                Dim _FECHA As Date

                ac = New ClsOperaciones.Asiento_Contable
                _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                dtVerficar = ac.Verificacion_Compras_Varios_pagos(_CODIGO, _VOUCHER, _FECHA)
                If dtVerficar.Rows.Count <> 0 Then
                    MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Pagos.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                dtVerficar.Clear()
                dtVerficar = Nothing
                dtVerficar = ac.Verificacion_Compras_Varios_Canje_Letras(_CODIGO, _VOUCHER, _FECHA)
                If dtVerficar.Rows.Count <> 0 Then
                    MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Canje por Letras.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                dtVerficar.Clear()
                dtVerficar = Nothing
            End If
            If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "09" Then 'valida letras de cobranza
                Dim _CODIGO As Integer = 0
                Dim _VOUCHER As String = String.Empty
                Dim _FECHA As Date

                ac = New ClsOperaciones.Asiento_Contable
                _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                dtVerficar = ac.Verificacion_Aceptacion_Letras_Cob(_CODIGO, _VOUCHER, _FECHA)
                If dtVerficar.Rows.Count <> 0 Then
                    MsgBox("El documento no se puede Eliminar, porque las Letras adjuntas" & Chr(13) & " se encuentran en un estado superior al de Letra en Cartera.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                dtVerficar.Clear()
                dtVerficar = Nothing
            End If
            If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "10" Then 'valida letras de cobranza
                Dim _CODIGO As Integer = 0
                Dim _VOUCHER As String = String.Empty
                Dim _FECHA As Date

                ac = New ClsOperaciones.Asiento_Contable
                _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                dtVerficar = ac.Verificacion_Aceptacion_Letras_Pagos(_CODIGO, _VOUCHER, _FECHA)
                If dtVerficar.Rows.Count <> 0 Then
                    MsgBox("El documento no se puede Eliminar, porque las Letras adjuntas" & Chr(13) & " se encuentran en un estado superior al de Letra en Cartera.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                dtVerficar.Clear()
                dtVerficar = Nothing
            End If
            If Not dgv_asientos.CurrentRow Is Nothing Then
                If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    ac = New ClsOperaciones.Asiento_Contable
                    Dim id As Integer = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                    'If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "08" Then
                    '    Dim _CODIGO As Integer = 0
                    '    Dim _VOUCHER As String = String.Empty
                    '    Dim _FECHA As Date
                    '    _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                    '    _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                    '    _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                    '    dtVerficar = ac.Verificacion_Compras_Varios(_CODIGO, _VOUCHER, _FECHA)
                    '    If dtVerficar.Rows.Count <> 0 Then
                    '        MsgBox("El documento no se puede Eliminar, porque se encuentra en la Cartera de Pago, Reaperture", MsgBoxStyle.Critical)
                    '        Exit Sub
                    '    End If
                    'End If
                    ac = New ClsOperaciones.Asiento_Contable
                    If ac.Delete(id, cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1) = True Then
                        MsgBox("Documento Eliminado correctamente.", MsgBoxStyle.Information)
                    End If
                    ac = Nothing
                    Call Cargar_Lista_Asientos()
                End If
            End If
        End If
    End Sub

    Private Sub tool_anular_Click(sender As Object, e As EventArgs) Handles tool_anular.Click
        Dim ac As ClsOperaciones.Asiento_Contable
        Dim dtVerficar As DataTable

        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        Dim EstaDoc As String = String.Empty
        If String.IsNullOrEmpty(dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value.ToString) Then
            MsgBox("El documento no posee Estado.", MsgBoxStyle.Information)
            Exit Sub
        Else
            EstaDoc = dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
            If EstaDoc = "A" Then
                MsgBox("El documento ya se encuentra Anulado.", MsgBoxStyle.Information)
                Exit Sub
            ElseIf EstaDoc = "F" Then
                MsgBox("El asiento se encuentra Finalizado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        If Verificar_Apertura_Cierre_Modulos(CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Month, CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Year) = False Then
            Exit Sub
        End If
        If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "08" Then 'valida compras varios
            Dim _CODIGO As Integer = 0
            Dim _VOUCHER As String = String.Empty
            Dim _FECHA As Date

            ac = New ClsOperaciones.Asiento_Contable
            _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
            _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
            _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
            dtVerficar = ac.Verificacion_Compras_Varios_pagos(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Anular, porque se encuentra en la Planilla de Pagos.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtVerficar.Clear()
            dtVerficar = Nothing
            dtVerficar = ac.Verificacion_Compras_Varios_Canje_Letras(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Anular, porque se encuentra en la Planilla de Canje por Letras.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtVerficar.Clear()
            dtVerficar = Nothing
        End If
        If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "09" Then 'valida letras de cobranza
            Dim _CODIGO As Integer = 0
            Dim _VOUCHER As String = String.Empty
            Dim _FECHA As Date

            ac = New ClsOperaciones.Asiento_Contable
            _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
            _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
            _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
            dtVerficar = ac.Verificacion_Aceptacion_Letras_Cob(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Anular, porque las Letras adjuntas" & Chr(13) & " se encuentran en un estado superior al de Letra en Cartera.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtVerficar.Clear()
            dtVerficar = Nothing
        End If
        If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "10" Then 'valida letras de cobranza
            Dim _CODIGO As Integer = 0
            Dim _VOUCHER As String = String.Empty
            Dim _FECHA As Date

            ac = New ClsOperaciones.Asiento_Contable
            _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
            _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
            _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
            dtVerficar = ac.Verificacion_Aceptacion_Letras_Pagos(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Anular, porque las Letras adjuntas" & Chr(13) & " se encuentran en un estado superior al de Letra en Cartera.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtVerficar.Clear()
            dtVerficar = Nothing
        End If
        If MessageBox.Show("Seguro de Anular?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            Dim id As Integer = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
            ac = New ClsOperaciones.Asiento_Contable
            If ac.Anular(id, cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1) = True Then
                MsgBox("Documento Anulado correctamente.", MsgBoxStyle.Information)
            End If
            ac = Nothing
            Call Cargar_Lista_Asientos()
        End If
    End Sub

    Private Sub tool_imprimir_Click(sender As Object, e As EventArgs) Handles tool_imprimir.Click
        If dgv_asientos.RowCount > 0 Then
            If dgv_asientos.CurrentRow Is Nothing Then
                dgv_asientos.Focus()
                Exit Sub
            End If
            If Not dgv_asientos.CurrentRow Is Nothing Then
                If String.IsNullOrEmpty(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString()) Then Exit Sub
                Dim CodAsiento As String = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA")
                Dim SQL As String = String.Empty
                'SQL = "SELECT AD_TDOC FROM CO_TB_ASIENTO_DET WHERE AD_IDCAB='" & CodAsiento & "' AND AD_TDOC<>'' AND AD_SDOC<>'' AND AD_NDOC<>''"
                SQL = "SELECT AD_TDOC FROM CO_TB_ASIENTO_DET WHERE AD_IDCAB='" & CodAsiento & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    ' Dim TipoDoc As String = dtImprimir.Rows(0).Item("AD_TDOC").ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        'crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento, "@TIPO_CAMBIO;" & ClsVarComun.TCVenta, "@TIPO_DOC;" & TipoDoc)
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", dtImprimir, "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If

            End If
        End If
    End Sub

    Private Sub tool_salir_Click(sender As Object, e As EventArgs) Handles tool_salir.Click
        Me.Close()
    End Sub

    Private Sub cmb_meses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_meses.SelectedIndexChanged
        Call Cargar_Lista_Asientos()
        cmb_meses.Focus()
    End Sub

    Private Sub cmb_sub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sub.SelectedIndexChanged
        Call Cargar_Lista_Asientos()
        cmb_sub.Focus()
    End Sub
    Private Sub tool_actualizar_Click(sender As Object, e As EventArgs) Handles tool_actualizar.Click
        Call Cargar_Lista_Asientos()
    End Sub

    Private Sub dgv_asientos_DoubleClick(sender As Object, e As EventArgs)
        Call tool_editar_Click(sender, e)
    End Sub

    Private Sub dtp_Año_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_Año.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Lista_Asientos()
            dgv_asientos.Focus()
        End If
    End Sub

    Private Sub cmb_ope_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_ope.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_sub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_sub.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub Tool_reaperturar_Click(sender As Object, e As EventArgs) Handles Tool_reaperturar.Click
        Dim ac As ClsOperaciones.Asiento_Contable
        Dim dtVerficar As DataTable

        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount <> 0 Then
            If cmb_ope.SelectedIndex = -1 Then Exit Sub
            Dim _ESTADO As String = String.Empty
            _ESTADO = dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
            If _ESTADO = "A" Then
                MsgBox("El asiento se encuentra Anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Verificar_Apertura_Cierre_Modulos(CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Month, CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Year) = False Then
                Exit Sub
            End If

            If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "08" Or cmb_sub.SelectedValue = "10" Then
                If _ESTADO = "F" Then
                    If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                        MsgBox("El Asiento contable no posee codigo, no se puede Reaperturar.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    If String.IsNullOrEmpty(dgv_asientos.Item(1, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                        MsgBox("El Asiento contable no posee numero Voucher, no se puede Reaperturar.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    Dim _CODIGO As Integer = 0
                    Dim _VOUCHER As String = String.Empty
                    Dim _FECHA As Date
                    _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                    _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                    _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                    '+++++
                    AsientoCabeceraBl = New ClsOperaciones.Asiento_Contable
                    If AsientoCabeceraBl.ConsultandoDocEliminacion(_CODIGO) = False Then Exit Sub
                    AsientoCabeceraBl = Nothing
                    '+++++
                    AsientoCabeceraBl = New ClsOperaciones.Asiento_Contable
                    If AsientoCabeceraBl.ReaperturandoAsiento(_CODIGO, _VOUCHER, _FECHA) = True Then
                        MsgBox("El asiento se aperturo exitosamente.", MsgBoxStyle.Information, "Sistemas")
                        Cargar_Lista_Asientos()
                    End If
                End If
            Else
                If cmb_ope.SelectedValue = "5" And cmb_sub.SelectedValue = "09" Then 'valida letras de cobranza
                    If _ESTADO = "F" Then
                        If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                            MsgBox("El Asiento contable no posee codigo, no se puede Reaperturar.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(dgv_asientos.Item(1, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                            MsgBox("El Asiento contable no posee numero Voucher, no se puede Reaperturar.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        Dim _CODIGO As Integer = 0
                        Dim _VOUCHER As String = String.Empty
                        Dim _FECHA As Date
                        '+++++
                        ac = New ClsOperaciones.Asiento_Contable
                        _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                        _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                        _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                        dtVerficar = ac.Verificacion_Aceptacion_Letras_Cob(_CODIGO, _VOUCHER, _FECHA)
                        If dtVerficar.Rows.Count <> 0 Then
                            MsgBox("El documento no se puede aperturar, porque las Letras adjuntas" & Chr(13) & " se encuentran en un estado superior al de Letra en Cartera.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        dtVerficar.Clear()
                        dtVerficar = Nothing
                        '+++++
                        AsientoCabeceraBl = New ClsOperaciones.Asiento_Contable
                        If AsientoCabeceraBl.ReaperturandoAsiento(_CODIGO, _VOUCHER, _FECHA) = True Then
                            MsgBox("El asiento se aperturo exitosamente.", MsgBoxStyle.Information, "Sistemas")
                            Cargar_Lista_Asientos()
                        End If
                    End If
                Else
                    If _ESTADO = "F" Then
                        If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                            MsgBox("El Asiento contable no posee codigo, no se puede Reaperturar.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        If String.IsNullOrEmpty(dgv_asientos.Item(1, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                            MsgBox("El Asiento contable no posee numero Voucher, no se puede Reaperturar.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        Dim _CODIGO As Integer = 0
                        Dim _VOUCHER As String = String.Empty
                        Dim _FECHA As Date
                        _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                        _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                        _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                        AsientoCabeceraBl = New ClsOperaciones.Asiento_Contable
                        If AsientoCabeceraBl.ReaperturandoAsiento_Varios(_CODIGO, _VOUCHER, _FECHA) = True Then
                            MsgBox("El asiento de aperturo exitosamente.", MsgBoxStyle.Information, "Sistemas")
                            Cargar_Lista_Asientos()
                        End If
                    End If
                End If
                
            End If
            
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        
        If bol_edicion_Asiento = True Then
            Botonera_Estado_Cambiar(False)
            dgv_asientos.Visible = True
            groupBox1.Visible = True
            Cargar_Lista_Asientos()
            If dgv_asientos.Rows.Count() <> 0 Then
                dgv_asientos.CurrentCell = dgv_asientos.Rows(Fila).Cells(2)
            End If
            bol_edicion_Asiento = False
            btn_remplaza_finalizar.Visible = False
        Else
            Botonera_Estado_Cambiar(False)
            dgv_asientos.Visible = True
            groupBox1.Visible = True
            Cargar_Lista_Asientos()
            bol_edicion_Asiento = False
            btn_remplaza_finalizar.Visible = False
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
                MsgBox("No se asigno los parametros, verifique.", MsgBoxStyle.Critical)
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
            dtOperaciones = ope.get_OperacionesVarios()
            cmb_ope_detalle.DisplayMember = "OP_DESCRIPCION"
            cmb_ope_detalle.ValueMember = "OP_ID"
            cmb_ope_detalle.DataSource = dtOperaciones
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
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub

    Private Sub Iniciar()
        gb_ref.Visible = False
        cmb_ope_detalle.Enabled = True
        cmb_sub_detalle.Enabled = True
        dtp_fec_vou.Enabled = True
        cboMoneda.Enabled = True
        dtp_fec_vou.Text = Date.Now
        dtp_fec_vou.Text = ""
        txt_glosa.Text = ""

        mtb_tot_d.Text = "0"
        mtb_tot_h.Text = "0"
        mtb_dif.Text = "0"
        mtb_tot_d_dolares.Text = "0"
        mtb_tot_h_dolares.Text = "0"
        mtb_dif_dolares.Text = "0"

        btn_ref.Enabled = False
        cmb_ope_detalle.SelectedIndex = -1
        cmb_sub_detalle.SelectedIndex = 0
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
            Dim ac As ClsOperaciones.Asiento_Contable
            ac = New ClsOperaciones.Asiento_Contable
            ds_Asiento = ac.get_Lista_Asientos_Edit(id_, sub_, ayo_, mes_)
            ac = Nothing
            For Each ff As DataRow In ds_Asiento.Tables(0).Rows
                
                txt_idcab.Text = ff("AC_ID").ToString()
                cmb_ope_detalle.SelectedIndex = 1
                cmb_ope_detalle.SelectedValue = oper_
                cmb_sub_detalle.SelectedValue = ff("AC_IDSUBDIARIO").ToString()
                txt_num_vou.Text = ff("AC_NUM_VOUCHER").ToString()
                dtp_fec_vou.Text = ff("AC_FEC_VOUCHER").ToString()
                txt_glosa.Text = ff("AC_GLOSA_VOU").ToString()
                cboMoneda.SelectedValue = ff("AC_IDMONEDA").ToString()
                txtcodigoRuc.Text = ff("AC_RUC").ToString()
                txtTipoDoc.Text = ff("AC_TIPO_DOC").ToString()
                txtSerieDoc.Text = ff("AC_SER_DOC").ToString()
                txtNumeroDoc.Text = ff("AC_NUM_DOC").ToString()
                dtpFechaDoc.Value = IIf(ff("AC_FEC_DOC").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC").ToString())
                dtpFechaVencimientoDoc.Value = IIf(ff("AC_FEC_DOC_VENCE").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC_VENCE").ToString())
                txtMontoIgv.Text = IIf(ff("AC_VAL_IGV").ToString() = String.Empty, 0, ff("AC_VAL_IGV").ToString())
                txtTasa.Text = IIf(ff("AC_POR_IGV").ToString() = String.Empty, 0, ff("AC_POR_IGV").ToString())
                txtMontoDoc.Text = IIf(ff("AC_TOTAL_DOC").ToString() = String.Empty, 0, ff("AC_TOTAL_DOC").ToString())
                txtTipoDocRef.Text = ff("AC_TIPO_DOC_REF").ToString()
                txtSerieDocRef.Text = ff("AC_SER_DOC_REF").ToString()
                txtNumDocRef.Text = ff("AC_NUM_DOC_REF").ToString()
                txtFechaDocRef.Value = IIf(ff("AC_FEC_DOC_REF").ToString() = String.Empty, Date.Now, ff("AC_FEC_DOC_REF").ToString())
                txtTipoCambio.Text = ff("AC_TIPO_CAMBIO").ToString()
                dtpFecha_PLE.Value = IIf(ff("AC_FEC_PLE").ToString() = String.Empty, Date.Now, ff("AC_FEC_PLE").ToString())
                If String.IsNullOrEmpty(ff("AC_DUA").ToString()) Then
                    chkdua.Checked = False
                Else
                    chkdua.Checked = IIf(ff("AC_DUA").ToString() = 0, False, True)
                End If
                txtDestino.Text = ff("AC_DESTINO").ToString()
                txtPorc_ISC.Text = ff("AC_POR_ISC").ToString()
                txt_ISC.Text = ff("AC_ISC").ToString()
                txtPorc_Detrac.Text = ff("AC_POR_DETRAC").ToString()
                txtdetraccion.Text = ff("AC_DETRAC").ToString()
                txtGlosaTransaccion.Text = ff("AC_GLOSA_TRANSACCION").ToString()
                txt_glosa.Text = ff("AC_GLOSA_VOU").ToString()
                'DatosTipoAnexo()
            Next
            MostrandoDetalles(id_, ayo_, mes_)
            gb_ref.Visible = False
            btn_ref.Enabled = False
            ' dgv_asiento.Height = 255
            btn_grabar.Enabled = True
            gb_detalle_doc.Enabled = True
            btn_cancelar.Text = "Cancelar"
            cmb_ope_detalle.Enabled = False
            cmb_sub_detalle.Enabled = False
            dtp_fec_vou.Enabled = False
            cboMoneda.Enabled = False
            ds_Asiento = Nothing
            txtCuentaContable.Text = String.Empty
            cmb_mp.SelectedIndex = -1
            cmb_cc.SelectedIndex = -1
            txtTipoDocAsiento.Text = String.Empty
            'If cmb_ope_detalle.SelectedValue.ToString = 5 And cmb_sub_detalle.SelectedValue = "08" Then
            '    btn_grabar.Enabled = False
            'Else
            '    btn_grabar.Enabled = True
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            dtdetalleAsiento = DtAsientoDetalle
            ' ''For Each ff As DataRow In DtAsientoDetalle.Rows
            ' ''    Ingresar_Fila_Modo_Edicion(ff("AD_SECUENCIA").ToString(), ff("AD_CUENTA").ToString(), ff("PC_DES_CTA").ToString, Integer.Parse(ff("AD_TANEXO").ToString()), ff("AD_IDANEXO").ToString(), _
            ' ''                       ff("AD_TDOC").ToString(), ff("AD_SDOC").ToString(), ff("AD_NDOC").ToString(), ff("AD_FDOC").ToString(), ff("AD_VDOC").ToString(), _
            ' ''                       Double.Parse(ff("AD_DEBE").ToString()), Double.Parse(ff("AD_HABER").ToString()), Double.Parse(ff("AD_MONTO_ORI").ToString()), _
            ' ''                       Double.Parse(ff("AD_TCAM").ToString()), ff("AD_IDCC").ToString(), ff("AD_IDMEDIOPAGO").ToString(), _
            ' ''                       Integer.Parse(ff("AD_IDMONEDA").ToString()), 0, 0, Integer.Parse(ff("AD_ES_INAFECTO").ToString()), _
            ' ''                       ff("AD_TDOC_REF").ToString(), ff("AD_SDOC_REF").ToString(), ff("AD_NDOC_REF").ToString(), ff("AD_FDOC_REF").ToString(), _
            ' ''                       ff("AD_VDOC_REF").ToString(), "", Integer.Parse(ff("AD_SEC_ORI_DES").ToString()), ff("AD_GLOSA").ToString(), IIf(ff("AD_PERCEN_DETRACC").ToString = "", 0, ff("AD_PERCEN_DETRACC")), _
            ' ''                       Double.Parse(ff("AD_DEBE_DOLARES").ToString()), Double.Parse(ff("AD_HABER_DOLARES").ToString()), Double.Parse(ff("AD_TCAM_DET").ToString()))
            ' ''Next
        Else
            GenerarColummnaDataTableAsientoContable()
        End If
        ConfigurarGrillas()
        Call Sumar_Totales()
        'If cmb_sub.SelectedValue = "03" Then
        '    btnModificar.Enabled = False
        'Else
        '    btnModificar.Enabled = True
        'End If
    End Sub

    'Private Sub Ingresar_Fila_Modo_Edicion(Sec As String, cuenta_ As String, des_cta_ As String, tanexo_ As Integer, anexo_ As String, tdoc_ As String, _
    '                        sdoc_ As String, ndoc_ As String, fdoc_ As String, vdoc_ As String, debe_ As Double, haber_ As Double, _
    '                        mon_ori_ As Double, tc_ As Double, cc_ As String, mp_ As String, moneda_ As Integer, esdestino_ As Integer, _
    '                        porce_desti_ As Double, esinafecto_ As Integer, tdocref_ As String, sdocref_ As String, ndocref_ As String, _
    '                        fdocref_ As String, vdocref_ As String, des_anexo_ As String, sec_ori_des_ As Integer, glosa_ As String, Detraccion As Integer, _
    '                        debe_dolares_ As Double, haber_dolares_ As Double, tc_det_ As Double)
    '    Try

    '        Dim row As DataRow = dtdetalleAsiento.NewRow
    '        row("AD_IDCAB") = 0
    '        row("AD_SECUENCIA") = Sec
    '        row("AD_CUENTA") = cuenta_
    '        row("DESC_CUENTA") = des_cta_
    '        row("AD_TANEXO") = tanexo_
    '        row("AD_IDANEXO") = anexo_
    '        row("AD_TDOC") = tdoc_
    '        row("AD_SDOC") = sdoc_
    '        row("AD_NDOC") = ndoc_
    '        row("AD_FDOC") = fdoc_
    '        row("AD_VDOC") = vdoc_
    '        row("AD_DEBE") = debe_
    '        row("AD_HABER") = haber_
    '        row("AD_TCAM") = tc_
    '        row("AD_SEC_ORI_DES") = sec_ori_des_
    '        row("AD_IDCC") = cc_
    '        row("AD_ES_DESTINO") = esdestino_
    '        row("AD_IDMEDIOPAGO") = mp_
    '        row("AD_MONTO_ORI") = mon_ori_
    '        row("AD_PORCE_DESTINO") = porce_desti_
    '        row("AD_ES_CONCI") = 0
    '        row("AD_MES_CONCI") = 0
    '        row("AD_ES_INAFECTO") = esinafecto_
    '        row("AD_IDMONEDA") = moneda_
    '        row("AD_TDOC_REF") = tdocref_
    '        row("AD_SDOC_REF") = sdocref_
    '        row("AD_NDOC_REF") = ndocref_
    '        row("AD_FDOC_REF") = fdocref_
    '        row("AD_VDOC_REF") = vdocref_
    '        row("AD_GLOSA") = glosa_
    '        row("AD_PERCEN_DETRACC") = Detraccion
    '        row("AD_DEBE_DOLARES") = debe_dolares_
    '        row("AD_HABER_DOLARES") = haber_dolares_
    '        row("AD_TCAM_DET") = tc_det_
    '        dtdetalleAsiento.Rows.Add(row)
    '        dtdetalleAsiento.AcceptChanges()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Cargar_Numero_Voucher()
        If cmb_sub_detalle.SelectedIndex <> -1 Then
            Dim fecha As DateTime = DateTime.Parse(dtp_fec_vou.Value)
            Dim ac As New ClsOperaciones.Asiento_Contable
            txt_num_vou.Text = ac.get_Ult_num_voucher(cmb_sub_detalle.SelectedValue.ToString(), fecha.Year, Format(fecha.Month, "00"))
            ac = Nothing
        End If
    End Sub

    Private Sub DatosTipoAnexo()
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("DatosTipoAnexo")
            Dim Sql = String.Empty
            Sql = "SELECT * FROM CO_TB_SUBDIARIO WHERE SD_IDOPERACION='" & cmb_ope_detalle.SelectedValue.ToString & "'"
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

    'Private Sub cmb_ope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ope.SelectedIndexChanged
    '    If cmb_ope.SelectedIndex >= 0 Then
    '        Dim su As New ClsOperaciones.CO_TB_SUBDIARIO
    '        cmb_sub.DisplayMember = "SD_DESCRIPCION"
    '        cmb_sub.ValueMember = "SD_ID"
    '        cmb_sub.DataSource = su.get_Subdiario_x_Ope(cmb_ope.SelectedValue)
    '        su = Nothing
    '        cmb_sub.SelectedIndex = 0
    '        Call Cargar_Numero_Voucher()
    '        Label21.Text = cmb_ope.Text
    '        If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
    '            btn_grabar.Enabled = False
    '        Else
    '            btn_grabar.Enabled = True
    '        End If
    '    End If
    'End Sub

    Private Sub Modificar_Cuentas_Contable_Cabecera()
        Try
            Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New ClsOperaciones.Asiento_Contable
            ''Ingresando Datos de la Cabecera del Asiento Contable
            cab.AC_ID = Int64.Parse(txt_idcab.Text)
            cab.AC_IDSUBDIARIO = cmb_sub_detalle.SelectedValue.ToString()
            cab.AC_NUM_VOUCHER = txt_num_vou.Text
            cab.AC_FEC_VOUCHER = dtp_fec_vou.Text
            cab.AC_GLOSA_VOU = txt_glosa.Text
            cab.AC_IDMONEDA = Integer.Parse(cboMoneda.SelectedValue.ToString())
            asiento.Actualizar_Asiento_Cabecera(cab)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardando_Cuentas_Contable_Cabecera()
        Try
            Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New ClsOperaciones.Asiento_Contable

            If Not bol_edicion_Asiento Then
                If asiento.Existe_Num_Voucher(txt_num_vou.Text, cmb_sub_detalle.SelectedValue.ToString(), DateTime.Parse(dtp_fec_vou.Text).Year, DateTime.Parse(dtp_fec_vou.Text).Month) Then
                    txt_num_vou.Text = (Integer.Parse(txt_num_vou.Text) + 1).ToString()
                End If
            End If
            ''Ingresando Datos de la Cabecera del Asiento Contable
            cab.AC_ID = 0
            If bol_edicion_Asiento Then
                cab.AC_ID = Int64.Parse(txt_idcab.Text)
            End If
            cab.AC_IDSUBDIARIO = cmb_sub_detalle.SelectedValue.ToString()
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
            asiento.Guardar_Asiento_Cabecera(cab)
            txt_idcab.Text = cab.AC_ID.ToString()
            id_asiento = cab.AC_ID.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If dgvDetalleAsiento.RowCount = 0 Then
            MessageBox.Show("Ingrese cuentas contables al asiento", "Revise")
            Exit Sub
        End If
        If mtb_dif.Text <> 0 Then
            MessageBox.Show("El asiento no cuadra", "Revise")
            If cmb_ope_detalle.SelectedValue.ToString().Equals("3") Then
                Call Agregar_Linea_Dif_Cambio()
            End If
            Exit Sub
        End If
        If bol_edicion_Asiento = False Then
            If MessageBox.Show("¿Desea numeracion Automatica?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
                dtcodigo = ClsasientoBl.ValidarCodigo(cmb_sub_detalle.SelectedValue.ToString, codigo, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                If dtcodigo.Rows.Count() <> 0 Then
                    MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    txt_num_vou.Text = codigo
                End If
            End If
        End If

        Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
        Dim detalles As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)
        Dim asiento As New ClsOperaciones.Asiento_Contable

        If Not bol_edicion_Asiento Then
validar_numero:
            If asiento.Existe_Num_Voucher(txt_num_vou.Text, cmb_sub_detalle.SelectedValue.ToString(), DateTime.Parse(dtp_fec_vou.Text).Year, DateTime.Parse(dtp_fec_vou.Text).Month) Then
                txt_num_vou.Text = (Integer.Parse(txt_num_vou.Text) + 1).ToString()
                GoTo validar_numero
            End If
        End If
        ''Ingresando Datos de la Cabecera del Asiento Contable
        cab.AC_ID = 0
        If bol_edicion_Asiento Then
            cab.AC_ID = Int64.Parse(txt_idcab.Text)
        End If
        cab.AC_IDSUBDIARIO = cmb_sub_detalle.SelectedValue.ToString()
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
        cab.AC_TIPO_CAMBIO = IIf(String.IsNullOrEmpty(txtTipoCambio.Text), 0, txtTipoCambio.Text)
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

    Private Sub Ingresar_Fila(Sec_ As Integer, cuenta_ As String, des_cta_ As String, tanexo_ As Integer, anexo_ As String, tdoc_ As String, _
                              sdoc_ As String, ndoc_ As String, fdoc_ As String, vdoc_ As String, debe_ As Double, haber_ As Double, _
                              mon_ori_ As Double, tc_ As Double, cc_ As String, mp_ As String, moneda_ As Integer, esdestino_ As Integer, _
                              porce_desti_ As Double, esinafecto_ As Integer, tdocref_ As String, sdocref_ As String, ndocref_ As String, _
                              fdocref_ As String, vdocref_ As String, des_anexo_ As String, sec_ori_des_ As Integer, glosa_ As String)
        Try

            '  If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
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
            'Else
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
            ' End If
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

    Private Sub IngresarDetallesAsientoContable(ByVal _Sec As Integer, ByVal _Debe As Double, ByVal _Haber As Double, ByVal _MontoOriginal As Double, ByVal _TipoCambio As Double)
        Try

            ''Guardando los Datos del detalles
            ' If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
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
                Else
                    d.AD_IDCC = "" = TraerCodigo(txtCentroCosto.Text)
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
            '  Else
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
            ' End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetallesAsientoContable(ByVal _sec As Integer, ByVal _Debe As Double, ByVal _Haber As Double, ByVal _MontoOriginal As Double, ByVal _TipoCambio As Double)
        Try
            ' If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
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
                Else
                    d.AD_IDCC = "" = TraerCodigo(txtCentroCosto.Text)
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
            ' Else
            '    For Each item As DataRow In dtdetalleAsiento.Select("AD_SECUENCIA=" & _sec & " or AD_SEC_ORI_DES=" & _sec)
            '        dtdetalleAsiento.BeginInit()
            '        item.Delete()
            '        dtdetalleAsiento.EndInit()
            '        dtdetalleAsiento.AcceptChanges()
            '    Next
            '    Dim row As DataRow = dtdetalleAsiento.NewRow
            '    row("AD_IDCAB") = 0
            '    row("AD_SECUENCIA") = _sec
            '    row("AD_CUENTA") = txtCuentaContable.Text
            '    row("DESC_CUENTA") = txt_des_cta.Text
            '    row("AD_TANEXO") = tipoAnexoDet
            '    row("AD_IDANEXO") = txt_cod_ane.Text
            '    row("AD_TDOC") = IIf(txtTipoDocAsiento.Text = String.Empty, "", txtTipoDocAsiento.Text)
            '    row("AD_SDOC") = txt_ser.Text
            '    row("AD_NDOC") = txt_num.Text
            '    row("AD_FDOC") = IIf(mtb_fec_emi.MaskFull, mtb_fec_emi.Text, "")
            '    row("AD_VDOC") = IIf(mtb_fec_ven.MaskFull, mtb_fec_ven.Text, "")
            '    row("AD_DEBE") = _Debe
            '    row("AD_HABER") = _Haber
            '    row("AD_TCAM") = _TipoCambio
            '    row("AD_SEC_ORI_DES") = 0
            '    If cmb_cc.Enabled = False And txtCentroCosto.Visible = False Then
            '        row("AD_IDCC") = ""
            '    Else
            '        If cmb_cc.Enabled = True And txtCentroCosto.Visible = False Then
            '            row("AD_IDCC") = "" = IIf(cmb_cc.SelectedIndex <> -1, cmb_cc.SelectedValue.ToString(), "")
            '        Else
            '            row("AD_IDCC") = "" = TraerCodigo(txtCentroCosto.Text)
            '        End If
            '    End If
            '    row("AD_ES_DESTINO") = 0
            '    If cmb_mp.Enabled = False Then
            '        row("AD_IDMEDIOPAGO") = ""
            '    Else
            '        row("AD_IDMEDIOPAGO") = IIf(cmb_mp.SelectedIndex <> -1, cmb_mp.SelectedValue.ToString(), "")
            '    End If
            '    row("AD_MONTO_ORI") = _MontoOriginal
            '    row("AD_PORCE_DESTINO") = 0
            '    row("AD_ES_CONCI") = 0
            '    row("AD_MES_CONCI") = 0
            '    row("AD_ES_INAFECTO") = IIf(chk_inafecto.Checked, 1, 0)
            '    row("AD_IDMONEDA") = Integer.Parse(cmb_moneda.SelectedValue.ToString())
            '    row("AD_TDOC_REF") = IIf(txt_tdoc_ref.Text = String.Empty, "", txt_tdoc_ref.Text)
            '    row("AD_SDOC_REF") = IIf(txt_sdoc_ref.Text = String.Empty, "", txt_sdoc_ref.Text)
            '    row("AD_NDOC_REF") = IIf(txt_ndoc_ref.Text = String.Empty, "", txt_ndoc_ref.Text)
            '    row("AD_FDOC_REF") = IIf(mtb_fec_emi_ref.MaskFull, mtb_fec_emi_ref.Text, "")
            '    row("AD_VDOC_REF") = IIf(mtb_fec_ven_ref.MaskFull, mtb_fec_ven_ref.Text, "")
            '    row("AD_GLOSA") = txt_glosa_det.Text.Trim()
            '    dtdetalleAsiento.Rows.Add(row)
            '    dtdetalleAsiento.AcceptChanges()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
    '    If btn_cancelar.Text = "Nuevo" Then
    '        Dim index_ope As Integer = cmb_ope.SelectedIndex
    '        Dim index_sub As Integer = cmb_sub.SelectedIndex
    '        Call Iniciar()
    '        cmb_ope.SelectedIndex = index_ope
    '        cmb_sub.SelectedIndex = index_sub
    '        mtb_tot_d.Text = 0
    '        mtb_tot_h.Text = 0
    '        mtb_dif.Text = 0
    '        txt_d1.Text = String.Empty
    '        txt_d2.Text = String.Empty
    '        txt_glosa.Text = String.Empty
    '        cboMoneda.SelectedIndex = 0
    '        dtp_fec_vou.Value = Date.Now
    '        GenerarColummnaDataTableAsientoContable()
    '        Blank()
    '        Nuevo_Detalle()
    '        cmb_ope.Focus()
    '    End If
    'End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txtCuentaContable.Text = String.Empty Then
            MessageBox.Show("Ingrese una cuenta contable", "Cuidado!")
            txtCuentaContable.Focus()
            Exit Sub
        Else
            If Strings.Left(txtCuentaContable.Text, 1) = "6" And Strings.Left(txtCuentaContable.Text, 2) <> "60" And Strings.Left(txtCuentaContable.Text, 1) <> "61" And txt_cen_cos.Text = "" And txt_cen_cos.Enabled = True Then
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
                MessageBox.Show("El Anexo no existe,", "Cuidado!")
                txt_cod_ane.Focus()
                Exit Sub
            End If
            fq = Nothing
        End If

        If cmb_moneda.SelectedIndex = -1 Then
            MsgBox("Debe elegir un tipo de Moneda.", MsgBoxStyle.Information)
            cmb_moneda.Focus()
            Exit Sub
        End If


        If mtb_tc.Text = String.Empty Then
            MsgBox("Debe agregar el Tipo de Cambio.", MsgBoxStyle.Information)
            mtb_fec_emi.Focus()
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
        Dim d As Double = 0
        Dim h As Double = 0
        Dim o As Double = 0
        Dim tc As Double = 0

        If mtb_debe.Text.Trim = String.Empty And mtb_haber.Text.Trim = String.Empty Then
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
            If mtb_debe.Text <> 0 Then
                o = Double.Parse(mtb_debe.Text)
                d = Math.Round(o * tc, 2)
            Else
                o = Double.Parse(mtb_haber.Text)
                h = Math.Round(o * tc, 2)
            End If
        Else 'soles
            If mtb_debe.Text <> 0 Then
                d = Double.Parse(mtb_debe.Text)
                o = d
            Else
                h = Double.Parse(mtb_haber.Text)
                o = h
            End If
        End If
        'Habilitando el Control
        pnlDetalles.Enabled = True
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
        If txt_d1.Text.Trim.Length > 0 And txt_d2.Text.Trim.Length > 0 Then
            Dim pc As New ClsOperaciones.CO_TB_PLANCTAS
            Dim dt As DataTable
            Dim ult_secuencia As Integer = _Secuencia
            dt = pc.get_Cuenta(txt_d1.Text.Trim(), Date.Now.Year)
            If dt.Rows.Count > 0 Then
                _Secuencia = 0
                _Secuencia = Correlativo()
                Call Ingresar_Fila(_Secuencia, txt_d1.Text, dt.Rows(0)("PC_DES_CTA").ToString(), 0, "", "", "", "", "", "", d, h, o, tc, "", "", Integer.Parse(cmb_moneda.SelectedValue.ToString()), 1, 100, 0, "", "", "", "", "", "", ult_secuencia, txt_glosa_det.Text.Trim())
            End If
            dt = pc.get_Cuenta(txt_d1.Text.Trim(), Date.Now.Year)
            If dt.Rows.Count > 0 Then
                _Secuencia = 0
                _Secuencia = Correlativo()
                Call Ingresar_Fila(_Secuencia, txt_d2.Text, dt.Rows(0)("PC_DES_CTA").ToString(), 0, "", "", "", "", "", "", h, d, o, tc, "", "", Integer.Parse(cmb_moneda.SelectedValue.ToString()), 1, 100, 0, "", "", "", "", "", "", ult_secuencia, txt_glosa_det.Text.Trim())
            End If
            dt = Nothing
            pc = Nothing
        End If
        'If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
        MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
        'End If
        Call Sumar_Totales()
        pnlDetalles.Enabled = False
        bol_edicion_Det = False
        txtCuentaContable.Select()
        'mtb_fec_emi.Text = ""
        mtb_fec_ven.Text = ""
        mtb_debe.Text = ""
        mtb_haber.Text = ""
    End Sub

    Public Function Correlativo() As Integer
        Dim Item As Integer = 0
        Try
            ' If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable
            DtDetallesAsientoC = AsientoContableCabs.Secuencia(txt_idcab.Text)
            Item = CInt(DtDetallesAsientoC.Rows(0).Item("Secuencia"))
            'Else
            '    Item = IIf(String.IsNullOrEmpty(dtdetalleAsiento.Compute("Max(AD_SECUENCIA)", "").ToString), 0, dtdetalleAsiento.Compute("Max(AD_SECUENCIA)", ""))
            '    Item = Item + 1
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
        Return Item
    End Function


    'Private Function SECUENCIA() As Integer
    '    Dim Item As String = String.Empty
    '    Try
    '        If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
    '            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
    '            DtDetallesAsientoC = New DataTable
    '            DtDetallesAsientoC = AsientoContableCabs.Secuencia(txt_idcab.Text)
    '            Item = DtDetallesAsientoC.Rows(0).Item("Secuencia").ToString
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Return Item
    'End Function

    Private Sub Nuevo_Detalle()
        bol_edicion_Det = False
        Call Limpiar_Controles(gb_detalle_doc)
        cmb_cc.SelectedIndex = -1
        cmb_mp.SelectedIndex = -1
        txtCuentaContable.Text = String.Empty
        txt_cen_cos.Text = ""
        txt_cen_cos_des.Text = ""
        txtTipoDocAsiento.Text = String.Empty
        txt_tdoc_ref.Text = ""
        txt_sdoc_ref.Text = ""
        txt_ndoc_ref.Text = ""
        mtb_fec_emi_ref.Text = ""
        mtb_fec_ven_ref.Text = ""
        txt_d1.Text = ""
        txt_d2.Text = ""
        'txtCuentaContable.Focus()
    End Sub

    Public Sub Sumar_Totales()
        Dim td As Double = 0
        Dim th As Double = 0
        Dim dif As Double = 0

        Dim td_dolares As Double = 0
        Dim th_dolares As Double = 0
        Dim dif_dolares As Double = 0

        For Each cells As DataRow In dtdetalleAsiento.Select("AD_SEC_ORI_DES=0", "")
            td += Math.Round(Double.Parse(cells("AD_DEBE")), 6)
            th += Math.Round(Double.Parse(cells("AD_HABER")), 6)
            td_dolares += Math.Round(Double.Parse(cells("AD_DEBE_DOLARES")), 6)
            th_dolares += Math.Round(Double.Parse(cells("AD_HABER_DOLARES")), 6)
        Next
        dif = Math.Round(td, 2) - Math.Round(th, 2)
        dif_dolares = Math.Round(td_dolares, 2) - Math.Round(th_dolares, 2)
        mtb_tot_d.Text = Format(td, "##,##0.00")
        mtb_tot_h.Text = Format(th, "##,##0.00")
        mtb_dif.Text = Format(Math.Round(dif, 2), "##,##0.00")

        mtb_tot_d_dolares.Text = Format(td_dolares, "##,##0.00")
        mtb_tot_h_dolares.Text = Format(th_dolares, "##,##0.00")
        mtb_dif_dolares.Text = Format(Math.Round(dif_dolares, 2), "##,##0.00")

    End Sub

    Private Sub btn_can_Click(sender As Object, e As EventArgs) Handles btn_can.Click
        pnlDetalles.Enabled = True
        gb_detalle_doc.Enabled = False
        btn_remplaza_finalizar.Enabled = True
        Nuevo_Detalle()
        dgvDetalleAsiento.Focus()
    End Sub

    Private Sub DetallesCuentaContable(ByVal _NumeroCuenta As String)
        Try
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("DetalleCuentaContable")
            DtDetallesAsientoC = AsientoContableCabs.DetalleCuentaContable(_NumeroCuenta)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                If String.IsNullOrEmpty(DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA").ToString) Then
                    cmb_moneda.SelectedIndex = -1
                Else
                    If DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA").ToString = 0 Then
                        'cmb_moneda.SelectedIndex = -1
                    Else
                        ' cmb_moneda.SelectedValue = DtDetallesAsientoC.Rows(0).Item("PC_IDMONEDA")
                    End If
                End If
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
                        'If bol_edicion_Det = False Then
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
                        'End If

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
                        TipoAnexo = CInt(tipoAnexoDet)
                        txt_cod_ane.Enabled = True
                        txt_des_ane.Enabled = True
                    End If
                End If

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
                    txtTipoDocAsiento.Focus()
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("Terceros")
                DtDatos = AsientoContableCabs.Get_ManualTercero(_Codigo)
                If DtDatos.Rows.Count() <> 0 Then
                    Texto.Text = DtDatos.Rows(0).Item(2).ToString
                    Descripcion.Text = DtDatos.Rows(0).Item(3).ToString
                    txtTipoDocAsiento.Focus()
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
                        txtTipoDocAsiento.Focus()
                    End If
                    frm.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_cod_ane_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ane.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tercero(txt_cod_ane, txt_des_ane)
            txtTipoDocAsiento.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            If txt_cod_ane.Text = String.Empty Then
                Ayuda_Tercero(txt_cod_ane, txt_des_ane)
            Else
                Ayuda_Tercero(txt_cod_ane, txt_des_ane, txt_cod_ane.Text)
            End If
        End If
    End Sub

    Private Sub txt_ser_Leave(sender As Object, e As EventArgs) Handles txt_ser.Leave
        'If txt_ser.Text.Trim().Length > 0 Then
        '    If txtTipoDocAsiento.Text <> "VR" Or txtTipoDocAsiento.Text <> "TB" Then
        '        If cmb_sub.SelectedValue = "08" Then
        '            txt_ser.Text = txt_ser.Text.PadLeft(5, Char.Parse("0"))
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub txt_num_Leave(sender As Object, e As EventArgs) Handles txt_num.Leave
        'If txt_num.Text.Trim().Length > 0 Then
        '    If txtTipoDocAsiento.Text <> "VR" Or txtTipoDocAsiento.Text <> "TB" Then
        '        If cmb_sub.SelectedValue = "08" Then
        '            txt_num.Text = txt_num.Text.PadLeft(15, Char.Parse("0"))
        '        End If
        '    End If
        'End If
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

            If fila.Cells("AD_TDOC").Value.ToString() = "NC" Or fila.Cells("AD_TDOC").Value.ToString() = "ND" Then
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
                mtb_debe.Text = IIf(String.IsNullOrEmpty(fila.Cells("AD_DEBE").Value.ToString()), 0, fila.Cells("AD_DEBE").Value.ToString())
                mtb_haber.Text = IIf(String.IsNullOrEmpty(fila.Cells("AD_HABER").Value.ToString()), 0, fila.Cells("AD_HABER").Value.ToString())
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
            txt_ser.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub cmb_sub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sub.SelectedIndexChanged
    '    Call Cargar_Numero_Voucher()
    '    If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
    '        btn_grabar.Enabled = False
    '    Else
    '        btn_grabar.Enabled = True
    '    End If
    'End Sub

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
            txt_sdoc_ref.Text = txt_sdoc_ref.Text.PadLeft(5, Char.Parse("0"))
        End If
    End Sub

    Private Sub txt_ndoc_ref_Leave(sender As Object, e As EventArgs) Handles txt_ndoc_ref.Leave
        If txt_ndoc_ref.Text.Trim().Length > 0 Then
            txt_ndoc_ref.Text = txt_ndoc_ref.Text.PadLeft(15, Char.Parse("0"))
        End If
    End Sub

    Private Sub mtb_fec_ven_ref_Enter(sender As Object, e As EventArgs) Handles mtb_fec_ven_ref.Enter
        mtb_fec_ven_ref.Text = mtb_fec_emi_ref.Text
    End Sub

    Private Sub txt_tdoc_ref_Leave(sender As Object, e As EventArgs) Handles txt_tdoc_ref.Leave
        txt_tdoc_ref.Text = txt_tdoc_ref.Text.ToUpper()
    End Sub

    Private Sub cmb_doc_SelectedIndexChanged(sender As Object, e As EventArgs)
        btn_ref.Enabled = txtTipoDocAsiento.Text.Equals("NC")
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
                Dim Codigo As String = txt_idcab.Text
                Dim Item As String = dgvDetalleAsiento.Item(1, dgvDetalleAsiento.CurrentRow.Index).Value
                If Codigo = String.Empty Or Item = String.Empty Then Exit Sub
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDetallesAsientoC = New DataTable
                If AsientoContableCabs.Eliminar_Asiento_Compras_Varios(CInt(Codigo), CInt(Item)) = True Then
                    MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                End If
                'Else
                '    Dim Codigo As String = String.Empty
                '    Codigo = dgvDetalleAsiento.Item(1, dgvDetalleAsiento.CurrentRow.Index).Value
                '    'Borrando los Datos
                '    For Each item As DataRow In dtdetalleAsiento.Select("AD_SECUENCIA=" & Codigo & " or AD_SEC_ORI_DES=" & Codigo)
                '        dtdetalleAsiento.BeginInit()
                '        item.Delete()
                '        dtdetalleAsiento.EndInit()
                '        dtdetalleAsiento.AcceptChanges()
                '    Next
                'End If
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
            mtb_fec_emi.Text = ""
            mtb_fec_ven.Text = ""
            gbCabecera.Enabled = False
        End If
        gb_detalle_doc.Enabled = True
        pnlDetalles.Enabled = False
        txt_cod_ane.Text = txtcodigoRuc.Text
        txt_des_ane.Text = txtdescripciontercero.Text
        bol_edicion_Det = False
        btn_remplaza_finalizar.Enabled = False
        txt_cen_cos.Text = ""
        txt_cen_cos_des.Text = ""
        txtCuentaContable.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalleAsiento.CurrentRow Is Nothing Then Exit Sub
        If dgvDetalleAsiento.Rows.Count > 0 Then
            If dgvDetalleAsiento.Rows.Count > 0 Then
                Modo_Edicion()
                gb_detalle_doc.Enabled = True
                pnlDetalles.Enabled = False
                btn_remplaza_finalizar.Enabled = False
                txtCuentaContable.Select()
            End If
        End If
    End Sub

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

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        ' If cmb_ope.SelectedValue.ToString = 5 And cmb_sub.SelectedValue = "08" Then
        If cmb_ope_detalle.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una Operacion.", MsgBoxStyle.Information)
            cmb_ope_detalle.Focus()
            Exit Sub
        End If
        If Verificar_Apertura_Cierre_Modulos(dtp_fec_vou.Value.Month, dtp_fec_vou.Value.Year) = False Then
            Exit Sub
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
                dtcodigo = ClsasientoBl.ValidarCodigo(cmb_sub_detalle.SelectedValue.ToString, codigo, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                If dtcodigo.Rows.Count() <> 0 Then
                    MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    txt_num_vou.Text = codigo
                End If
            End If
            Guardando_Cuentas_Contable_Cabecera()
        Else
            Modificar_Cuentas_Contable_Cabecera()
        End If

        ' End If
        pnlDetalles.Enabled = True
        gbDetalles.Enabled = True
        gb_detalle_doc.Enabled = False
        GroupBox2.Enabled = True
        If bol_edicion_Asiento = False Then
            btn_remplaza_finalizar.Visible = True 'pnlFinalizarCompra.Visible = True
            If cmb_ope_detalle.SelectedValue = 5 And cmb_sub_detalle.SelectedValue = "18" Then 'asiento de cierre
                pnl_opt_cierre.Visible = True
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                RadioButton5.Checked = False
                RadioButton6.Checked = False
                RadioButton7.Checked = False
                RadioButton8.Checked = False
                RadioButton9.Checked = False
                RadioButton10.Checked = False
                RadioButton11.Checked = False
                RadioButton12.Checked = False
                RadioButton13.Checked = False
                RadioButton14.Checked = False
                RadioButton15.Checked = False
                RadioButton16.Checked = False
                RadioButton17.Checked = False
            Else
                btnAgregar.Focus()
            End If
        Else
            btnAgregar.Focus()
        End If
        
    End Sub

    Private Sub txtcodigoRuc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoRuc.MouseDoubleClick
        If cmb_ope_detalle.SelectedIndex > -1 Then
            Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero)
        Else
            MsgBox("Debe seleccionar primeramente una Operacion.", MsgBoxStyle.Information)
            cmb_ope_detalle.Focus()
        End If
    End Sub


    Private Sub dtpOtraFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpOtraFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TipoCambioFecha")
            Dim Sql = String.Empty
            Sql = "SELECT * FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & dtpOtraFecha.Value.ToString("dd/MM/yyyy") & "'"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                txtTipoCambio.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                txtTipoCambio.Text = String.Empty
            End If
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

    Private Sub frm_CO_LT_IngVoucher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDocRef.KeyPress, txtTipoDoc.KeyPress, txtTipoCambio.KeyPress, txtTasa.KeyPress, txtSerieDocRef.KeyPress, txtSerieDoc.KeyPress, txtPorc_ISC.KeyPress, txtPorc_Detrac.KeyPress, txtNumeroDoc.KeyPress, txtNumDocRef.KeyPress, txtGlosaTransaccion.KeyPress, txtFechaDocRef.KeyPress, txtdetraccion.KeyPress, txtDestino.KeyPress, txtcodigoRuc.KeyPress, txt_ISC.KeyPress, MyBase.KeyPress, dtpFechaVencimientoDoc.KeyPress, dtpFechaDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtMontoIgv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtMontoIgv.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtMontoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoDoc.KeyPress
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

    Private Sub Ayuda_Destinos()
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDestino_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtDestino.MouseDoubleClick
        Ayuda_Destinos()
    End Sub

    Private Sub txtDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDestino.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Destinos()
        End If
    End Sub

    Private Sub txtNumeroDoc_Leave(sender As Object, e As EventArgs) Handles txtNumeroDoc.Leave
        If txtNumeroDoc.Text.Trim().Length > 0 Then
            txtNumeroDoc.Text = txtNumeroDoc.Text.PadLeft(15, Char.Parse("0"))
        End If
    End Sub

    Private Sub txtSerieDoc_Leave(sender As Object, e As EventArgs) Handles txtSerieDoc.Leave
        If txtSerieDoc.Text.Trim().Length > 0 Then
            txtSerieDoc.Text = txtSerieDoc.Text.PadLeft(5, Char.Parse("0"))
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
                        If cmb_sub_detalle.SelectedValue = "08" Then
                            If Texto.Text = "NC" Or Texto.Text = "ND" Then
                                btn_ref.Enabled = True
                            Else
                                btn_ref.Enabled = False
                            End If
                        End If

                    End If
                    txt_ser.Focus()
                End If
                frm.Close()
            Else
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                DtDatos = New DataTable("CuentaContable")
                DtDatos = AsientoContableCabs.Get_ManualTipoDocumento(_Codigo)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    Texto.Text = DtDatos.Rows(0).Item(0).ToString
                    If cmb_sub_detalle.SelectedValue = "08" Then
                        If Texto.Text = "NC" Or Texto.Text = "ND" Then
                            btn_ref.Enabled = True
                        Else
                            btn_ref.Enabled = False
                        End If
                    End If
                    txt_ser.Focus()
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    Texto.Text = String.Empty
                    Texto.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtTipoDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDoc.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDoc)
    End Sub

    Private Sub txtTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDoc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento(txtTipoDoc)
        End If
    End Sub

    Private Sub txtTipoDocRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento(txtTipoDocRef)
        End If
    End Sub

    Private Sub txtTipoDocRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocRef.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDocRef)
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocAsiento.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento(txtTipoDocAsiento)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim ope As Integer = Integer.Parse(cmb_ope_detalle.SelectedValue.ToString())
            If ope = 3 Or ope = 5 Then 'caja bancos o generales
                Dim dp As New Frm_Co_Doc_Pendientes
                dp.str_anexo = txt_cod_ane.Text
                dp.str_cuenta = txtCuentaContable.Text
                dp.int_ayo = dtp_fec_vou.Value.Year
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
                        txtTipoDocAsiento.Focus()
                    End If
                Else
                    txtTipoDocAsiento.Focus()
                End If
                dp.Close()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If txtTipoDocAsiento.Text = String.Empty Then
                Ayuda_TipoDocumento(txtTipoDocAsiento)
            Else
                Ayuda_TipoDocumento(txtTipoDocAsiento, txtTipoDocAsiento.Text)
            End If
        End If
    End Sub

    Private Sub txtTipoDocAsiento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocAsiento.MouseDoubleClick
        Ayuda_TipoDocumento(txtTipoDocAsiento)
    End Sub

    Private Sub txtSerieDocRef_Leave(sender As Object, e As EventArgs) Handles txtSerieDocRef.Leave
        'If txtSerieDocRef.Text.Trim().Length > 0 Then
        '    txtSerieDocRef.Text = txtSerieDocRef.Text.PadLeft(5, Char.Parse("0"))
        'End If
    End Sub

    Private Sub txtNumDocRef_Leave(sender As Object, e As EventArgs) Handles txtNumDocRef.Leave
        'If txtNumDocRef.Text.Trim().Length > 0 Then
        '    txtNumDocRef.Text = txtNumDocRef.Text.PadLeft(15, Char.Parse("0"))
        'End If
    End Sub

    Private Sub txt_ser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmb_moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_moneda.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub

    Private Sub mtb_tc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mtb_debe_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles cmb_mp.KeyPress, cmb_cc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub mtb_fec_ven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_fec_ven.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub

    Private Sub Ayuda_CuentaContable(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            If _CodigoCuentaContable = String.Empty Then
                'Dim frm As New frmBuscar
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
                    If txt_cen_cos.Enabled = True Then
                        txt_cen_cos.Focus()
                    Else
                        If txt_cod_ane.Enabled = True Then
                            txt_cod_ane.Focus()
                        Else
                            txtTipoDocAsiento.Focus()
                        End If
                    End If
                End If
            Else
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
                    If txt_cen_cos.Enabled = True Then
                        txt_cen_cos.Focus()
                    Else
                        If txt_cod_ane.Enabled = True Then
                            txt_cod_ane.Focus()
                        Else
                            txtTipoDocAsiento.Focus()
                        End If
                    End If
                Else
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
                        If txt_cen_cos.Enabled = True Then
                            txt_cen_cos.Focus()
                        Else
                            If txt_cod_ane.Enabled = True Then
                                txt_cod_ane.Focus()
                            Else
                                txtTipoDocAsiento.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCuentaContable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaContable.MouseDoubleClick
        Ayuda_CuentaContable()
    End Sub

    Private Sub txtCuentaContable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_CuentaContable()
        If e.KeyCode = Keys.Enter Then
            If txtCuentaContable.Text = String.Empty Then
                Ayuda_CuentaContable()
            Else
                Ayuda_CuentaContable(txtCuentaContable.Text)
            End If
        End If
    End Sub

    Private Sub txtcodigoRuc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoRuc.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmb_ope_detalle.SelectedIndex > -1 Then
                If TipoAnexo = String.Empty Then Exit Sub
                Ayuda_Tercero(txtcodigoRuc, txtdescripciontercero)
            Else
                MsgBox("Debe seleccionar primeramente una Operacion.", MsgBoxStyle.Information)
                cmb_ope_detalle.Focus()
            End If
        End If
    End Sub

    

    Private Sub txt_glosa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_glosa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub TipoAnexos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_TIPO_ANEXO_VARIOS"
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

    Private Sub btnTipoAnexo_Click(sender As Object, e As EventArgs)
        txtcodigoRuc.Text = String.Empty
        txtdescripciontercero.Text = String.Empty
        TipoAnexos()

    End Sub

    'Private Sub cmb_ope_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ope.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        cmb_sub.Select()
    '    End If
    'End Sub

    'Private Sub cmb_sub_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_sub.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        dtp_fec_vou.Focus()
    '    End If
    'End Sub

    'Private Sub dtp_fec_vou_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_vou.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        cboMoneda.Focus()
    '    End If
    'End Sub

    'Private Sub cboMoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMoneda.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_glosa.Focus()
    '    End If
    'End Sub


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
                    txtCentroCosto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString & " : " & frm.Data_Matriz.Rows(0).Item(1).ToString
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
                    txtCentroCosto.Text = DtDatos.Rows(0).Item(0).ToString & " : " & DtDatos.Rows(0).Item(1).ToString
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
                        txtCentroCosto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString & " : " & frm.Data_Matriz.Rows(0).Item(1).ToString
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

    Private Sub txtCentroCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCentroCosto.KeyDown
        If e.KeyCode = Keys.F1 Then
            DetallesCentroCosto()
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Enter Then
            If cmb_mp.Enabled = False Then
                If txtCentroCosto.Text = String.Empty Then
                    DetallesCentroCosto()
                Else
                    DetallesCentroCosto(txtCentroCosto.Text)
                End If
                'btn_ok_Click(sender, e)
                SendKeys.Send("{TAB}")
            Else
                cmb_mp.Focus()
            End If
        End If
    End Sub

    Private Sub txtCentroCosto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCentroCosto.MouseDoubleClick
        DetallesCentroCosto()
    End Sub

    Private Sub txtCentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentroCosto.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
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
                mtb_fec_emi.Focus()
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
                    'If cboMoneda.SelectedValue = "1" Then
                    FechaIngr = mtb_fec_emi.Text
                    'ElseIf cboMoneda.SelectedValue = "2" Then
                    If Strings.Left(Trim(txtCuentaContable.Text), 2) = "10" Then
                        If FechaIngr.ToString("dddd") = "domingo" Then
                            FechaIngr = FechaIngr.AddDays(0)
                        ElseIf FechaIngr.ToString("ddddd") = "lunes" Then
                            FechaIngr = FechaIngr.AddDays(0)
                        Else
                            FechaIngr = FechaIngr.AddDays(0)
                        End If
                    Else
                        FechaIngr = FechaIngr
                    End If

                    'End If
                Else
                    FechaIngr = mtb_fec_emi.Text
                End If
                mtb_fec_ven.Focus()
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                mtb_tc.Text = String.Empty
                mtb_fec_emi.Focus()
            End If

            AsientoContableCabs = New ClsOperaciones.Asiento_Contable
            DtDetallesAsientoC = New DataTable("TipoCambioFecha")
            Sql = "SELECT SELL_RATE, BUY_RATE FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr & "'"
            DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(Sql)
            If DtDetallesAsientoC.Rows.Count() <> 0 Then
                If cmb_sub.SelectedValue = "03" Then
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
                ElseIf cmb_sub.SelectedValue = "04" Then
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
                Else
                    mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
                End If
                mtb_fec_ven.Focus()
            Else
                MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
                mtb_tc.Text = String.Empty
                mtb_fec_emi.Focus()
            End If
        End If
    End Sub

    Public Sub Salir()
        Try
            If txt_idcab.Text = String.Empty Then Exit Sub
            If cmb_ope_detalle.SelectedIndex > -1 Then
                If Flag_Estado_Fin = True Then Exit Sub
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                AsientoContableCabs.UpdateComprasVarios(txt_idcab.Text, cmb_sub_detalle.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_CO_LT_IngVoucherVarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Salir()
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

    Private Sub mtb_debe_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles mtb_debe.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mtb_haber_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles mtb_haber.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FinalizarCompra()
        Try
            Dim carteraBE As ClsEntidades.CUSTOMER_BALANCE_PAY
            Dim CarteraBl As ClsOperaciones.Asiento_Contable
            CarteraBl = New ClsOperaciones.Asiento_Contable
            Dim dtFinalizarCompra As DataTable
            dtFinalizarCompra = New DataTable

            Dim ListaDetalles As New List(Of ClsEntidades.CUSTOMER_BALANCE_PAY)
            dtFinalizarCompra = CarteraBl.Finalizar_Compra_Detalles(txt_idcab.Text, cmb_sub_detalle.SelectedValue.ToString, txt_num_vou.Text, dtp_fec_vou.Value.ToString("dd/MM/yyyyy"))
            If dtFinalizarCompra.Rows.Count() <> 0 Then
                Dim resul() As DataRow = dtFinalizarCompra.Select("AD_TDOC='VR'", "")
                If resul.Count = 1 Then
                    For Each item As DataRow In dtFinalizarCompra.Rows
                        carteraBE = New ClsEntidades.CUSTOMER_BALANCE_PAY
                        With carteraBE
                            CarteraBl = New ClsOperaciones.Asiento_Contable
                            Dim dtVerificarRuc As New DataTable
                            dtVerificarRuc = CarteraBl.Verificar_codigo_Empleado(item("AD_IDANEXO"))
                            If dtVerificarRuc.Rows.Count() = 0 Then
                                MsgBox("No existe el codigo de Empleado.", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                            .CUSTOMER_ID = dtVerificarRuc.Rows(0).Item("VAT_REGISTRATION").ToString
                            .DOCUMENT_ID = item("AD_TDOC")
                            .NUMBER_DOC = item("AD_SDOC") + item("AD_NDOC")
                            .DOC_DATE = item("AD_FDOC").ToString
                            .CADUCATE_DATE = item("AD_VDOC").ToString
                            .DOCUMENT_REF = ""
                            .NUMBER_REF = ""
                            .SALES_ID = "00"
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
                            .PERCENT_DETRAC = item("AD_PERCEN_DETRACC")
                            .AMOUNT_DETRAC = 0
                            .SALDO = .AMOUNT
                            .NUM_REF_ASIENTO = txt_idcab.Text
                            .VOUCHER_REF_ASIENTO = txt_num_vou.Text
                            .FECHA_REF_ASIENTO = dtp_fec_vou.Value.ToString("dd/MM/yyyyy")
                        End With
                        ListaDetalles.Add(carteraBE)
                    Next
                Else
                    For Each item As DataRow In dtFinalizarCompra.Rows
                        carteraBE = New ClsEntidades.CUSTOMER_BALANCE_PAY
                        With carteraBE
                            CarteraBl = New ClsOperaciones.Asiento_Contable
                            Dim dtVerificarRuc As New DataTable
                            dtVerificarRuc = CarteraBl.Verificar_Ruc_Proveedor(item("AD_IDANEXO"))
                            If dtVerificarRuc.Rows.Count() = 0 Then
                                MsgBox("No existe el Proveedor con el Ruc.", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                            .CUSTOMER_ID = dtVerificarRuc.Rows(0).Item("CODIGO").ToString
                            .DOCUMENT_ID = item("AD_TDOC")
                            .NUMBER_DOC = item("AD_SDOC") + item("AD_NDOC")
                            .DOC_DATE = item("AD_FDOC").ToString
                            .CADUCATE_DATE = item("AD_VDOC").ToString
                            .DOCUMENT_REF = ""
                            .NUMBER_REF = ""
                            .SALES_ID = "00"
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
                            .PERCENT_DETRAC = item("AD_PERCEN_DETRACC")
                            .AMOUNT_DETRAC = 0
                            .SALDO = .AMOUNT
                            .NUM_REF_ASIENTO = txt_idcab.Text
                            .VOUCHER_REF_ASIENTO = txt_num_vou.Text
                            .FECHA_REF_ASIENTO = dtp_fec_vou.Value.ToString("dd/MM/yyyyy")
                        End With
                        ListaDetalles.Add(carteraBE)
                    Next
                End If
            End If
            CarteraBl = New ClsOperaciones.Asiento_Contable
            If CarteraBl.Guardar_Finalizar_Compras(ListaDetalles) Then
                MsgBox("Proceso de Compra generada correctamente.", MsgBoxStyle.Information)
                AsientoContableCabs = New ClsOperaciones.Asiento_Contable
                AsientoContableCabs.UpdateCompras(txt_idcab.Text, cmb_sub_detalle.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text))
                pnlFinalizarCompra.Visible = False
                Flag_Estado_Fin = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click
        If dtdetalleAsiento.Rows.Count() = 0 Then
            MsgBox("Falta ingresar el detalle del Asiento.", MsgBoxStyle.Exclamation, "Sistemas")
        End If

        If dtdetalleAsiento.Rows.Count() <> 0 Then
            For Each row As DataRow In dtdetalleAsiento.Select("AD_CUENTA='' ", "")
                'MessageBox.Show("Falta ingresar cuentas contables en los items.", "Sistemas", MessageBoxButtons, MessageBoxIcon.Stop)
                MsgBox("Falta ingresar cuentas contables en los items.", MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            Next
        End If
        If cmb_ope_detalle.SelectedValue = 5 And cmb_sub_detalle.SelectedValue = "08" Then
            'If mtb_tot_d.Text = 0 And mtb_tot_h.Text = 0 Then Exit Sub
            If Val(mtb_tot_d.Text) = Val(mtb_tot_h.Text) Then
                If MessageBox.Show("Se va a proceder a Finalizar la compra." & vbCrLf & "¿Desea continuar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    FinalizarCompra()
                    btn_cancelar_Click(sender, e)
                End If
            Else
                MsgBox("El asiento Contable no cuadra, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            'If mtb_tot_d.Text = 0 And mtb_tot_h.Text = 0 Then Exit Sub
            If Val(mtb_tot_d.Text) = Val(mtb_tot_h.Text) Then
                If MessageBox.Show("Se va a proceder a Finalizar el Asiento Contable." & vbCrLf & "¿Desea continuar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    FinalizarCompraVarios()
                    btn_cancelar_Click(sender, e)
                    'If MsgBox("Desea imprimir el comprobante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    '    'impresion de asientos
                    '    reporteBL = New ClsBuscar
                    '    crystalBL = New LibReportes.ClsReporte
                    '    Me.Cursor = Cursors.WaitCursor
                    '    dtImprimir = New DataTable("CONSULTA")
                    '    Dim SQL As String = String.Empty
                    '    'SQL = "SELECT AD_TDOC FROM CO_TB_ASIENTO_DET WHERE AD_IDCAB='" & CodAsiento & "' AND AD_TDOC<>'' AND AD_SDOC<>'' AND AD_NDOC<>''"
                    '    SQL = "SELECT AD_TDOC FROM CO_TB_ASIENTO_DET WHERE AD_IDCAB='" & id_asiento & "'"
                    '    dtImprimir = reporteBL.EjecutarConsulta(SQL)
                    '    If dtImprimir.Rows.Count() <> 0 Then
                    '        ' Dim TipoDoc As String = dtImprimir.Rows(0).Item("AD_TDOC").ToString
                    '        reporteBL = New ClsBuscar
                    '        dtImprimir = New DataTable("REPORTE")
                    '        dtImprimir = reporteBL.EjecutarReporteVoucher(id_asiento)
                    '        If dtImprimir.Rows.Count() <> 0 Then
                    '            'crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento, "@TIPO_CAMBIO;" & ClsVarComun.TCVenta, "@TIPO_DOC;" & TipoDoc)
                    '            crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", dtImprimir, "", "", "@AC_ID;" & id_asiento)
                    '        End If
                    '        Me.Cursor = Cursors.Default
                    '    End If
                    'End If
                End If
            Else
                MsgBox("Los valores del Asiento Contable son diferentes. Verifique!", MsgBoxStyle.Critical, "Contabilidad")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub FinalizarCompraVarios()
        Try
            Dim CarteraBl As ClsOperaciones.Asiento_Contable
            CarteraBl = New ClsOperaciones.Asiento_Contable
            If CarteraBl.Guardar_Finalizar_Compras_Varios(txt_idcab.Text, cmb_sub_detalle.SelectedValue.ToString, txt_num_vou.Text, Double.Parse(mtb_tot_d.Text), Double.Parse(mtb_tot_h.Text)) Then
                MsgBox("Proceso de Finalizacion generada correctamente.", MsgBoxStyle.Information)

                pnlFinalizarCompra.Visible = False
                Flag_Estado_Fin = True
                'Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_emi.Select() 'mtb_tc.Focus()
        End If
    End Sub

    Private Sub mtb_tc_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_tc.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_emi.Focus()
        End If
    End Sub

    Private Sub mtb_fec_ven_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_ven.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_debe.Focus()
        End If
    End Sub

    Public Sub GenerarColummnaDataTableAsientoContable()
        Try
            dtdetalleAsiento = New DataTable
            dtdetalleAsiento.Columns.Add("AD_IDCAB", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_SECUENCIA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_CUENTA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("DESC_CUENTA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_TANEXO", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDANEXO", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_TDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_SDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_NDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_FDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_VDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_DEBE", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_HABER", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_TCAM", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_SEC_ORI_DES", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDCC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_ES_DESTINO", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDMEDIOPAGO", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_MONTO_ORI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_PORCE_DESTINO", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_ES_CONCI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_MES_CONCI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_ES_INAFECTO", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_IDMONEDA", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_TDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_SDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_NDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_FDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_VDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_GLOSA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_PERCEN_DETRACC", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_DEBE_DOLARES", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_HABER_DOLARES", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_TCAM_DET", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_CEN_COS", Type.GetType("System.String"))
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
        'dt_Configurado.DefaultView.Sort = "AD_SECUENCIA"
        dgvDetalleAsiento.DataSource = dt_Configurado
        For i As Integer = 0 To dtdetalleAsiento.Columns.Count() - 1
            dgvDetalleAsiento.Columns(i).Visible = False
            dgvDetalleAsiento.Columns(i).ReadOnly = True
        Next

        dgvDetalleAsiento.Columns(0).Width = 60
        dgvDetalleAsiento.Columns(2).Width = 55
        dgvDetalleAsiento.Columns(3).Width = 140
        dgvDetalleAsiento.Columns(5).Width = 80
        dgvDetalleAsiento.Columns(6).Width = 30
        dgvDetalleAsiento.Columns(7).Width = 40
        dgvDetalleAsiento.Columns(9).Width = 70
        dgvDetalleAsiento.Columns(2).Visible = True
        dgvDetalleAsiento.Columns(3).Visible = True

        dgvDetalleAsiento.Columns(6).Visible = True
        dgvDetalleAsiento.Columns(7).Visible = True
        dgvDetalleAsiento.Columns(8).Visible = True
        dgvDetalleAsiento.Columns(9).Visible = True


        dgvDetalleAsiento.Columns(5).Visible = True
        dgvDetalleAsiento.Columns(11).Visible = True
        dgvDetalleAsiento.Columns(12).Visible = True

        dgvDetalleAsiento.Columns(11).Visible = True
        dgvDetalleAsiento.Columns(12).Visible = True

        dgvDetalleAsiento.Columns(31).Visible = True
        dgvDetalleAsiento.Columns(32).Visible = True
        dgvDetalleAsiento.Columns(33).Visible = True
        dgvDetalleAsiento.Columns("AD_CEN_COS").Visible = False

        dgvDetalleAsiento.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleAsiento.Columns(32).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleAsiento.Columns(33).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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
        dgvDetalleAsiento.Columns(11).HeaderText = "Debe Soles"
        dgvDetalleAsiento.Columns(12).HeaderText = "Haber Soles"

        dgvDetalleAsiento.Columns(31).DefaultCellStyle.Format = "##,##0.00"
        dgvDetalleAsiento.Columns(32).DefaultCellStyle.Format = "##,##0.00"
        dgvDetalleAsiento.Columns(33).DefaultCellStyle.Format = "##,##0.000"
        dgvDetalleAsiento.Columns(31).HeaderText = "Debe Dolares"
        dgvDetalleAsiento.Columns(32).HeaderText = "Haber Dolares"
        dgvDetalleAsiento.Columns(33).HeaderText = "Tip. Cambio"

        dgvDetalleAsiento.Columns(11).Width = 90
        dgvDetalleAsiento.Columns(12).Width = 90
        dgvDetalleAsiento.Columns(31).Width = 90
        dgvDetalleAsiento.Columns(32).Width = 90
        dgvDetalleAsiento.Columns(33).Width = 90

        If bol_edicion_Asiento = False Then
            If dgvDetalleAsiento.Rows.Count() <> 0 Then
                dgvDetalleAsiento.CurrentCell = dgvDetalleAsiento.Rows(dgvDetalleAsiento.Rows.Count - 1).Cells(2)
            End If
        End If
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
            dtpOtraFecha.Value = Date.Now
            dtpFecha_PLE.Value = Date.Now
            chkdua.Checked = False
            'cboMoneda.SelectedIndex = 0
            txtDestino.Text = String.Empty
            txtdescripcionDestino.Text = String.Empty
            txtPorc_ISC.Text = String.Empty
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub cmb_ope_detalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ope_detalle.SelectedIndexChanged
        If cmb_ope_detalle.SelectedIndex >= 0 Then
            Dim su As New ClsOperaciones.CO_TB_SUBDIARIO
            cmb_sub_detalle.DisplayMember = "SD_DESCRIPCION"
            cmb_sub_detalle.ValueMember = "SD_ID"
            cmb_sub_detalle.DataSource = su.get_Subdiario_x_Ope(cmb_ope_detalle.SelectedValue)
            su = Nothing
            cmb_sub_detalle.SelectedIndex = 0
            Call Cargar_Numero_Voucher()
            Label21.Text = cmb_ope_detalle.Text
            'If cmb_ope_detalle.SelectedValue.ToString = 5 And cmb_sub_detalle.SelectedValue = "08" Then
            '    btn_grabar.Enabled = False
            'Else
            '    btn_grabar.Enabled = True
            'End If
        End If
    End Sub

    Private Sub cmb_ope_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ope_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_sub_detalle.Select()
        End If
    End Sub

    Private Sub cmb_sub_detalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sub_detalle.SelectedIndexChanged
        Call Cargar_Numero_Voucher()
        'If cmb_ope_detalle.SelectedValue.ToString = 5 And cmb_sub_detalle.SelectedValue = "08" Then
        '    btn_grabar.Enabled = False
        'Else
        '    btn_grabar.Enabled = True
        'End If
    End Sub

    Private Sub cmb_sub_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_sub_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fec_vou.Focus()
        End If
    End Sub

    Private Sub txt_cod_ane_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_ane.MouseDoubleClick
        Ayuda_Tercero(txt_cod_ane, txt_des_ane)
    End Sub

    Private Sub dtp_fec_vou_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_vou.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboMoneda.Focus()
        End If
    End Sub

    Private Sub cboMoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_glosa.Focus()
        End If
    End Sub

    Private Sub btn_remplaza_finalizar_Click(sender As Object, e As EventArgs) Handles btn_remplaza_finalizar.Click
        btn_Finalizar_Click(sender, e)
    End Sub

    Private Sub btn_cancelar_opt_cierre_Click(sender As Object, e As EventArgs) Handles btn_cancelar_opt_cierre.Click
        pnl_opt_cierre.Visible = False
    End Sub

    Private Sub btn_aceptar_opt_cierre_Click(sender As Object, e As EventArgs) Handles btn_aceptar_opt_cierre.Click
        Try
            Dim asiento As New ClsOperaciones.Asiento_Contable

            Dim nombre_store As String = ""
            If RadioButton1.Checked Then nombre_store = "CO_SP_S_CI_1"
            If RadioButton2.Checked Then nombre_store = "CO_SP_S_CI_2"
            If RadioButton3.Checked Then nombre_store = "CO_SP_S_CI_3"
            If RadioButton4.Checked Then nombre_store = "CO_SP_S_CI_4"
            If RadioButton5.Checked Then nombre_store = "CO_SP_S_CI_5"
            If RadioButton6.Checked Then nombre_store = "CO_SP_S_CI_6"
            If RadioButton7.Checked Then nombre_store = "CO_SP_S_CI_7"
            If RadioButton8.Checked Then nombre_store = "CO_SP_S_CI_8"
            If RadioButton9.Checked Then nombre_store = "CO_SP_S_CI_9"
            If RadioButton10.Checked Then nombre_store = "CO_SP_S_CI_10"
            If RadioButton11.Checked Then nombre_store = "CO_SP_S_CI_11"
            If RadioButton12.Checked Then nombre_store = "CO_SP_S_CI_12"
            If RadioButton13.Checked Then
                MsgBox("La opción elegida debe generarse manualmente.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            If RadioButton14.Checked Then
                MsgBox("La opción elegida debe generarse manualmente.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            If RadioButton15.Checked Then nombre_store = "CO_SP_S_CI_15"
            If RadioButton16.Checked Then nombre_store = "CO_SP_S_CI_16"
            If RadioButton17.Checked Then nombre_store = "CO_SP_S_CI_17"

            Me.Cursor = Cursors.WaitCursor
            If asiento.Guardar_Asiento_Cierre(nombre_store, dtp_fec_vou.Value.Year, CInt(txt_idcab.Text)) Then
                MostrandoDetalles(txt_idcab.Text, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                Call Sumar_Totales()
                MsgBox("Detalle de asiento generado correctamente.", MsgBoxStyle.Information, "Aviso")
                btn_cancelar_opt_cierre_Click(sender, e)
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_importar_asientos_Click(sender As Object, e As EventArgs) Handles btn_importar_asientos.Click
        toolStrip1.Enabled = False
        groupBox1.Enabled = False
        dgv_asientos.Enabled = False
        txt_ruta.Text = ""
        dgvdetalles_asientos.DataSource = Nothing
        CentrarControl(pnl_importar_asientos)
        pnl_importar_asientos.Visible = True
    End Sub

    Private Sub btn_cancelar_importacion_Click(sender As Object, e As EventArgs) Handles btn_cancelar_importacion.Click
        toolStrip1.Enabled = True
        groupBox1.Enabled = True
        dgv_asientos.Enabled = True
        pnl_importar_asientos.Visible = False
    End Sub

    Private Sub btn_ruta_Click(sender As Object, e As EventArgs) Handles btn_ruta.Click
        Try
            Dim myFileDialog As New OpenFileDialog()
            Dim xSheet As String = ""

            With myFileDialog
                .Filter = "Excel  files(.xlsx)|*.xlsx|Excel files (*.xls)|*.xls" '"Excel Files |*.xls|*.xlsx"
                .Title = "Open File"
                .ShowDialog()
            End With

            txt_ruta.Text = myFileDialog.FileName.ToString()
            If myFileDialog.FileName.ToString() = "" Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            Dim dt_datos As DataTable
            Dim ds_datos As DataSet
            Call Cargar(dgvdetalles_asientos, myFileDialog.FileName.ToString(), "Hoja1")
            If dgvdetalles_asientos.Rows.Count = 0 Then Me.Cursor = Cursors.Default : Exit Sub
            ds_datos = dgvdetalles_asientos.DataSource
            dt_datos = ds_datos.Tables(0)


            If dgvdetalles_asientos.Rows.Count > 0 Then
                Dim asiento As New ClsOperaciones.Asiento_Contable
                If asiento.Ejecutar_Eliminacion_Movimientos_Temporales("SP_IMPORTAR_LIMPIAR_ASIENTOS_AUTO") = True Then
                    If asiento.CopyDataTableBulk_Importar_Asientos(dt_datos, "IMP_ASIENTOS_AUTO") Then
                        asiento = New ClsOperaciones.Asiento_Contable
                        Dim dtDocumentos_importador_compras As New DataTable
                        dtDocumentos_importador_compras = asiento.Mostrar_Asientos_Importados()
                        If dtDocumentos_importador_compras.Rows.Count > 0 Then
                            dgvdetalles_asientos.DataSource = dtDocumentos_importador_compras
                        Else
                            dgvdetalles_asientos.DataSource = Nothing
                        End If
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub btn_aceptar_importacion_Click(sender As Object, e As EventArgs) Handles btn_aceptar_importacion.Click
        If dgvdetalles_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgvdetalles_asientos.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            If MessageBox.Show("¿Desea importar los asientos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim asiento As New ClsOperaciones.Asiento_Contable
                If asiento.Guardar_Importacion_Asientos() Then
                    MsgBox("Importación exitosa.", MsgBoxStyle.Information, "Aviso")
                    btn_cancelar_importacion_Click(sender, e)
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

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