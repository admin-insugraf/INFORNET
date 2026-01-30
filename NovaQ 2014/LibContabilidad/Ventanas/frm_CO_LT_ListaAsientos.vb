Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing

Public Class frm_CO_LT_ListaAsientos


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub frm_CO_LT_ListaAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Operaciones()
        Call Cargar_Meses_en_Combo(cmb_meses)
    End Sub

    Private Sub Formating()
        For i As Integer = 0 To dgv_asientos.Columns.Count - 1
            dgv_asientos.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        For Each row As DataGridViewRow In dgv_asientos.Rows
            If row.Cells("AC_ESTADO").Value.ToString = "P" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.White
            Else
                row.DefaultCellStyle.BackColor = Color.White
                row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        dgv_asientos.Update()
    End Sub

    Private Sub Cargar_Lista_Asientos()
        If cmb_sub.SelectedIndex <> -1 Then
            If cmb_meses.SelectedIndex <> -1 Then
                Dim ac As New ClsOperaciones.Asiento_Contable
                Dim dtListaAsientos As DataTable
                dtListaAsientos = New DataTable
                dtListaAsientos = ac.get_Lista_Asientos(cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1)
                dgv_asientos.DataSource = dtListaAsientos
                ac = Nothing

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

                dgv_asientos.Columns("AC_RUC").Width = 100
                dgv_asientos.Columns("AC_RUC").Visible = True
                dgv_asientos.Columns("AC_NOMBRE").Width = 250
                dgv_asientos.Columns("AC_NOMBRE").Visible = True
                dgv_asientos.Columns("AC_TIPO_DOC").Width = 50
                dgv_asientos.Columns("AC_TIPO_DOC").Visible = True
                dgv_asientos.Columns("AC_SER_DOC").Width = 80
                dgv_asientos.Columns("AC_SER_DOC").Visible = True
                dgv_asientos.Columns("AC_NUM_DOC").Width = 100
                dgv_asientos.Columns("AC_NUM_DOC").Visible = True
                dgv_asientos.Columns("AC_FEC_DOC").Width = 70
                dgv_asientos.Columns("AC_FEC_DOC").Visible = True

                dgv_asientos.Columns("AC_GLOSA_VOU").Width = 450
                dgv_asientos.Columns("AC_GLOSA_VOU").Visible = True
                dgv_asientos.Columns("AC_ES_INTERFACE").Visible = False
                dgv_asientos.Columns("AC_IDMONEDA").Visible = True

                dgv_asientos.Columns("AC_RUC").HeaderText = "Ruc"
                dgv_asientos.Columns("AC_NOMBRE").HeaderText = "Descripción"
                dgv_asientos.Columns("AC_TIPO_DOC").HeaderText = "Tip. Doc."
                dgv_asientos.Columns("AC_SER_DOC").HeaderText = "Ser. Doc."
                dgv_asientos.Columns("AC_NUM_DOC").HeaderText = "N° Doc."
                dgv_asientos.Columns("AC_FEC_DOC").HeaderText = "Fecha Doc."
                dgv_asientos.Columns("AC_FEC_DOC").DefaultCellStyle.Format = "d"

                dgv_asientos.Columns("AC_FEC_VOUCHER").HeaderText = "Fecha Voucher"
                dgv_asientos.Columns("AC_NUM_VOUCHER").HeaderText = "Num. Voucher"
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
        dtdetalle = ope.get_Operaciones()
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
        Dim ff As New frm_CO_LT_IngVoucher
        'ff.ShowDialog()
        ff.Show()
        Cargar_Lista_Asientos()
    End Sub

    Private Sub tool_editar_Click(sender As Object, e As EventArgs) Handles tool_editar.Click
        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount > 0 Then
            If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                MsgBox("El Asiento contable no posee codigo, no se puede Modificar.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Not dgv_asientos.CurrentRow Is Nothing Then
                Dim id As Integer = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                Dim ff As New frm_CO_LT_IngVoucher
                ff.bol_edicion_Asiento = True
                Dim EstaDoc As String = String.Empty
                EstaDoc = dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
                If EstaDoc = "F" Then ff.Flag_Estado_Fin = True Else ff.Flag_Estado_Fin = False
                ff.GenerarColummnaDataTableAsientoContable()
                ff.Cargar_Asiento_Editar(Integer.Parse(cmb_ope.SelectedValue.ToString()), id, cmb_sub.SelectedValue.ToString(), dtp_Año.Value.Year, cmb_meses.SelectedIndex + 1)
                ff.Show()
                Cargar_Lista_Asientos()
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

    Private Sub tool_eliminar_Click(sender As Object, e As EventArgs) Handles tool_eliminar.Click
        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount > 0 Then
            If String.IsNullOrEmpty(dgv_asientos.Item(0, dgv_asientos.CurrentRow.Index).Value.ToString) Then
                MsgBox("El Asiento contable no posee codigo.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Not dgv_asientos.CurrentRow Is Nothing Then
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
                If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Dim ac As ClsOperaciones.Asiento_Contable
                    ac = New ClsOperaciones.Asiento_Contable
                    Dim dtVerficar As DataTable
                    Dim id As Integer = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                    If cmb_ope.SelectedValue = "1" And (cmb_sub.SelectedValue = "01" Or cmb_sub.SelectedValue = "11") Then
                        Dim _CODIGO As Integer = 0
                        Dim _VOUCHER As String = String.Empty
                        Dim _FECHA As Date
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
                    ElseIf cmb_ope.SelectedValue = "2" And cmb_sub.SelectedValue = "02" Then
                        Dim _CODIGO As Integer = 0
                        Dim _VOUCHER As String = String.Empty
                        Dim _FECHA As Date
                        _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
                        _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
                        _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
                        dtVerficar = ac.Verificacion_Compras_Varios_Ventas(_CODIGO, _VOUCHER, _FECHA)
                        If dtVerficar.Rows.Count <> 0 Then
                            MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Cobranzas.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        dtVerficar.Clear()
                        dtVerficar = Nothing
                        dtVerficar = ac.Verificacion_Ventas_Canje_Letras(_CODIGO, _VOUCHER, _FECHA)
                        If dtVerficar.Rows.Count <> 0 Then
                            MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Canje por Letras.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        dtVerficar.Clear()
                        dtVerficar = Nothing
                    End If
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
            End If
            If EstaDoc = "F" Then
                MsgBox("El asiento se encuentra Finalizado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        If Verificar_Apertura_Cierre_Modulos(CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Month, CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Year) = False Then
            Exit Sub
        End If

        If cmb_ope.SelectedValue = "1" And cmb_sub.SelectedValue = "01" Then
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
        ElseIf cmb_ope.SelectedValue = "2" And cmb_sub.SelectedValue = "02" Then
            Dim _CODIGO As Integer = 0
            Dim _VOUCHER As String = String.Empty
            Dim _FECHA As Date
            _CODIGO = Integer.Parse(dgv_asientos.CurrentRow.Cells("AC_ID").Value.ToString())
            _VOUCHER = dgv_asientos.CurrentRow.Cells("AC_NUM_VOUCHER").Value.ToString()
            _FECHA = Date.Parse(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value.ToString())
            dtVerficar = ac.Verificacion_Compras_Varios_Ventas(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Cobranzas.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            dtVerficar.Clear()
            dtVerficar = Nothing
            dtVerficar = ac.Verificacion_Ventas_Canje_Letras(_CODIGO, _VOUCHER, _FECHA)
            If dtVerficar.Rows.Count <> 0 Then
                MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Canje por Letras.", MsgBoxStyle.Critical)
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
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", "", "", "", "@AC_ID;" & CodAsiento)
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

    Private Sub cmb_meses_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_meses.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub Tool_reaperturar_Click(sender As Object, e As EventArgs) Handles Tool_reaperturar.Click
        Dim dtVerficar As DataTable
        Dim ac As ClsOperaciones.Asiento_Contable

        If dgv_asientos.CurrentRow Is Nothing Then Exit Sub
        If dgv_asientos.RowCount <> 0 Then
            If cmb_ope.SelectedIndex = -1 Then Exit Sub
            Dim AsientoCabeceraBl As New ClsOperaciones.Asiento_Contable
            Dim _ESTADO As String = String.Empty
            _ESTADO = dgv_asientos.Item(6, dgv_asientos.CurrentRow.Index).Value
            If _ESTADO = "A" Then
                MsgBox("El asiento se encuentra Anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Verificar_Apertura_Cierre_Modulos(CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Month, CDate(dgv_asientos.CurrentRow.Cells("AC_FEC_VOUCHER").Value).Year) = False Then
                Exit Sub
            End If

            If cmb_ope.SelectedValue = "1" And (cmb_sub.SelectedValue = "01" Or cmb_sub.SelectedValue = "11") Then
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
                        MsgBox("El asiento de aperturo exitosamente.", MsgBoxStyle.Information, "Sistemas")
                        Cargar_Lista_Asientos()
                    End If
                End If
            ElseIf cmb_ope.SelectedValue = "2" And cmb_sub.SelectedValue = "02" Then
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
                    ac = New ClsOperaciones.Asiento_Contable

                    dtVerficar = ac.Verificacion_Compras_Varios_Ventas(_CODIGO, _VOUCHER, _FECHA)
                    If dtVerficar.Rows.Count <> 0 Then
                        MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Cobranzas.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    dtVerficar.Clear()
                    dtVerficar = Nothing
                    dtVerficar = ac.Verificacion_Ventas_Canje_Letras(_CODIGO, _VOUCHER, _FECHA)
                    If dtVerficar.Rows.Count <> 0 Then
                        MsgBox("El documento no se puede Eliminar, porque se encuentra en la Planilla de Canje por Letras.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    dtVerficar.Clear()
                    dtVerficar = Nothing


                    AsientoCabeceraBl = New ClsOperaciones.Asiento_Contable
                    If AsientoCabeceraBl.ReaperturandoAsiento_Varios(_CODIGO, _VOUCHER, _FECHA) = True Then
                        MsgBox("El asiento de aperturo exitosamente.", MsgBoxStyle.Information, "Sistemas")
                        Cargar_Lista_Asientos()
                    End If
                End If
            End If
        End If
    End Sub
End Class