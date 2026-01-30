Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmReportePendienteCobro
    Dim dtDocumentosPrincipal As DataTable
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtDetalleClientes As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))
            If rbClientes.Checked = True Then
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
                dgvDocumentos.Columns(2).HeaderText = "Cliente"
                dgvDocumentos.Columns(3).Width = 120
                dgvDocumentos.Columns(3).ReadOnly = True
                dgvDocumentos.Columns(3).HeaderText = "Ruc"
            ElseIf rbVendedor.Checked = True Then
                dtDocumentosPrincipal.Columns.Add("SALES_ID", Type.GetType("System.Double"))
                dtDocumentosPrincipal.Columns.Add("NAME_VENDEDOR", Type.GetType("System.Double"))
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
                dgvDocumentos.Columns(2).HeaderText = "Vendedor"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarDocumentosPendiente_Cliente()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalleClientes = New DataTable
            dtv = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.MostrandoClientesDocPendientes()
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtv = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtv
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
                lblCantidad.Text = "Se encontraron 0 registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmReportePendienteCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtp_fi_opt.Value = "01/01/2016"
        dtp_ff_opt.Value = "31/12/" + CStr(ClsVarComun.FechaSistema.Year)
        Cargar_Documentos()
        MostrarDocumentosPendiente_Cliente()
        rdb_detallado.Checked = True
        rpt_mensual.Checked = False
        gb_tipo.Visible = True
        chk_todos_series.Checked = True
        txtFiltro.Focus()
    End Sub

    Private Sub Cargar_Documentos()
        Try

            Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
            documentosBL = New ClsOperaciones.DOCUMENT_TYPE
            cmb_tipo_cob.DataSource = documentosBL.get_Series()
            cmb_tipo_cob.ValueMember = "COD"
            cmb_tipo_cob.DisplayMember = "DES"

            Dim dtAlmacen As DataTable
            dtAlmacen = New DataTable
            dtAlmacen = documentosBL.get_Series()
            chklstAlmacenes.Items.Clear()
            chklstAlmacenes2.Items.Clear()
            If dtAlmacen.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
                    chklstAlmacenes2.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
                Next
                'documentosBL = Nothing
            End If

            dtAlmacen = New DataTable
            dtAlmacen = documentosBL.get_Tipo_Doc_Cobranza()
            chklstdocumentos.Items.Clear()
            chklstdocumentos2.Items.Clear()
            If dtAlmacen.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstdocumentos.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
                    chklstdocumentos2.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
                Next
            End If

            documentosBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ImprimirDocumentosPendientes(ByVal _Codigo As String)
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim idAlmacen As String = String.Empty
            Dim iddocumentos As String = String.Empty
            Dim i As Integer = 0
            Dim j As Integer = 0

            Me.Cursor = Cursors.WaitCursor
            'SERIES MARCADAS
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & chklstAlmacenes.CheckedItems(i) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If
            'DOCUMENTOS MARCADOS
            Do While j <= chklstdocumentos.CheckedItems.Count - 1
                iddocumentos = iddocumentos & """" & TraerCodigo(chklstdocumentos.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If iddocumentos.Length() <> 0 Then
                iddocumentos = Mid(iddocumentos, 1, iddocumentos.Length - 1)
            End If

            If rbClientes.Checked = True Then
                
                dtImprimir = New DataTable
                If rdb_ambos.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesCliente(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "3", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                ElseIf rdb_solo_retencion.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesCliente(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "1", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                ElseIf rdb_solo_saldos.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesCliente(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "2", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                End If
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                If dtImprimir.Rows.Count() <> 0 Then
                    If rdb_solo_retencion.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Retencion.rpt", dtImprimir, "", "", _
                                                      "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                      "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Retencion_Resumido.rpt", dtImprimir, "", "", _
                                                      "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                      "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    ElseIf rdb_solo_saldos.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Saldos.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Saldos_Resumido.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    ElseIf rdb_ambos.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Resumido.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    End If

                Else
                    MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
                End If
            ElseIf rbVendedor.Checked = True Then
                dtImprimir = New DataTable
                If rdb_ambos.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesVendedor(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "3", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                ElseIf rdb_solo_retencion.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesVendedor(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "1", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                ElseIf rdb_solo_saldos.Checked Then
                    dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesVendedor(_Codigo, IIf(checkTodos.Checked, "0", "1"), dtp_fi_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       dtp_ff_opt.Value.ToString("dd/MM/yyyy"), _
                                                                                       IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")), "2", _
                                                                                       IIf(checkAlmacen.Checked, "", idAlmacen), _
                                                                                       IIf(rdb_soles.Checked, "MN", IIf(rdb_dolares.Checked, "ME", "")), _
                                                                                       iddocumentos)
                End If

                'dtImprimir = reporteBL.EjecutarReporteDocumentosPendientes_Vendedor(_Codigo, dtp_fi_opt.Value.ToString("dd/MM/yyyy"), dtp_ff_opt.Value.ToString("dd/MM/yyyy"), IIf(rdb_emision.Checked, "0", IIf(rdb_vcto.Checked, "1", "")))
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                If dtImprimir.Rows.Count() <> 0 Then
                    'If rdb_detallado.Checked Then
                    '    crystalBL.Muestra_Reporte("REP_COB_PEND_VENDEDOR.rpt", dtImprimir, "", "", "@codigo;" & _Codigo, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    'ElseIf rdb_resumido.Checked Then
                    '    crystalBL.Muestra_Reporte("REP_COB_PEND_VENDEDOR_RESUMIDO.rpt", dtImprimir, "", "", "@codigo;" & _Codigo, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    'End If
                    If rdb_solo_retencion.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Retencion.rpt", dtImprimir, "", "", _
                                                      "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                      "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Retencion_Resumido.rpt", dtImprimir, "", "", _
                                                      "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                      "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    ElseIf rdb_solo_saldos.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Saldos.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Solo_Saldos_Resumido.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    ElseIf rdb_ambos.Checked Then
                        If rdb_detallado_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        ElseIf rdb_resumido_general.Checked Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult_Resumido.rpt", dtImprimir, "", "", "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                        End If

                    End If
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

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta) Then
            MsgBox("No se asigno el tipo de Cambio.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Estado As Boolean = False
        For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
            Estado = True
            Exit For
        Next
        If Estado = False Then
            MsgBox("No selecciono ningun Cliente.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If chklstAlmacenes.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ninguna Serie.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If chklstdocumentos.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ningun Tipo de Documento.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim _Codigo As String = String.Empty

        For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
            If rbClientes.Checked = True Then
                _Codigo = _Codigo & """" & row("CUSTOMER_ID").ToString() & """" & ","
            ElseIf rbVendedor.Checked = True Then
                _Codigo = _Codigo & """" & row("SALES_ID").ToString() & """" & ","
            End If
        Next
        If _Codigo.Length() <> 0 Then
            _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
            ImprimirDocumentosPendientes(_Codigo)
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvDocumentos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDocumentos.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvDocumentos.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim sel_proveedor As String = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString
            If rbClientes.Checked = True Then
                For Each row As DataRow In dtDocumentosPrincipal.Select("CUSTOMER_ID='" & sel_proveedor & "' ")
                    dtDocumentosPrincipal.BeginInit()
                    If row("Sel") = True Then
                        row("Sel") = False
                    Else
                        row("Sel") = True
                    End If
                    dtDocumentosPrincipal.EndInit()
                    dtDocumentosPrincipal.AcceptChanges()
                Next
            ElseIf rbVendedor.Checked = True Then
                For Each row As DataRow In dtDocumentosPrincipal.Select("SALES_ID='" & sel_proveedor & "' ")
                    dtDocumentosPrincipal.BeginInit()
                    If row("Sel") = True Then
                        row("Sel") = False
                    Else
                        row("Sel") = True
                    End If
                    dtDocumentosPrincipal.EndInit()
                    dtDocumentosPrincipal.AcceptChanges()
                Next
            End If
            
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        If checkTodos.Checked = True Then

            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=False")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = True
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        Else
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = False
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub MostrarDocumentosPendiente_Vendedor()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalleClientes = New DataTable
            dtv = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.MostrandoVendedorDocPendientes()
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtv = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtv
                If rbClientes.Checked = True Then
                    STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
                Else
                    STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name
                End If
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbClientes_Click(sender As Object, e As EventArgs) Handles rbClientes.Click
        checkTodos.Checked = False
        MostrarDocumentosPendiente_Cliente()
        txtFiltro.Text = String.Empty
        If rbClientes.Checked Then
            rdb_detallado.Visible = False
            rdb_resumido.Visible = False
            gb_tipo.Visible = True
            rdb_ambos.Checked = True
        End If
    End Sub

    Private Sub rbVendedor_Click(sender As Object, e As EventArgs) Handles rbVendedor.Click
        checkTodos.Checked = False
        MostrarDocumentosPendiente_Vendedor()
        txtFiltro.Text = String.Empty

        If rbVendedor.Checked Then
            rdb_detallado.Visible = True
            rdb_resumido.Visible = True
            rdb_detallado.Checked = True
            gb_tipo.Visible = False
        Else
            rdb_detallado.Visible = False
            rdb_resumido.Visible = False
            rdb_detallado.Checked = True
            gb_tipo.Visible = False
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        pnlFecha.Visible = False
        pnlMensual.Visible = False
        gbReporte.Enabled = True
        rbClientes.Checked = True
        rbClientes.Focus()
    End Sub

    Private Sub rbFechas_Click(sender As Object, e As EventArgs) Handles rbFechas.Click
        checkTodos.Checked = False
        dgvDocumentos.DataSource = Nothing
        dtpFechainicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpFechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        gbReporte.Enabled = False
        pnlFecha.Visible = True
        pnlMensual.Visible = False
        If rbFechas.Checked Then
            rdb_detallado.Visible = False
            rdb_resumido.Visible = False
            gb_tipo.Visible = False
        End If
    End Sub


    Private Sub ImprimirDocumentosPorVencimiento()
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDocumentosVencimiento_Fechas(dtpFechainicial.Value.ToString("dd/MM/yyyy"), dtpFechafinal.Value.ToString("dd/MM/yyyy"))
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_COB_PEN_FECHAS.rpt", dtImprimir, "", "", "@FECHA_INICIAL;" & dtpFechainicial.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FINAL;" & dtpFechafinal.Value.ToString("dd/MM/yyyy"), "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirDocumentos_Mensuales()
        Try
            Dim dtDatosCompany As DataTable
            Dim idAlmacen As String = ""
            Dim iddocumentos As String = ""
            Dim i As Integer
            Dim j As Integer
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")

            Me.Cursor = Cursors.WaitCursor

            'SERIES MARCADAS
            Do While i <= chklstAlmacenes2.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & chklstAlmacenes2.CheckedItems(i) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If

            'DOCUMENTOS MARCADOS
            Do While j <= chklstdocumentos2.CheckedItems.Count - 1
                iddocumentos = iddocumentos & """" & TraerCodigo(chklstdocumentos2.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If iddocumentos.Length() <> 0 Then
                iddocumentos = Mid(iddocumentos, 1, iddocumentos.Length - 1)
            End If

            dtImprimir = reporteBL.EjecutarReporteDocumentos_Mensuales(dtp_mensual.Value.Month, dtp_mensual.Value.Year, "N", IIf(checkAlmacen2.Checked, "", idAlmacen), iddocumentos)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_COB_PEN_FECHAS.rpt", dtImprimir, "", "", _
                                          "@OPCION;" & "N", _
                                          "@MES;" & dtp_mensual.Value.Month, _
                                          "@ANIO;" & dtp_mensual.Value.Year, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "MES_ANIO;" & dtp_mensual.Value.ToString("MMMM/yyyy"))
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirDocumentosPorEmision()
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDocumentosEmision_Fechas(dtpemisioninicio.Value.ToString("dd/MM/yyyy"), dtpemision_fin.Value.ToString("dd/MM/yyyy"))
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_COB_PEN_FECHAS.rpt", dtImprimir, "", "", "@FECHA_INICIAL;" & dtpemisioninicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FINAL;" & dtpemision_fin.Value.ToString("dd/MM/yyyy"), "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If CDate(dtpFechainicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpFechafinal.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpFechainicial.Focus()
            Exit Sub
        End If
        ImprimirDocumentosPorVencimiento()
    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlFecha.Visible = False
        gbReporte.Enabled = True
        rbClientes.Checked = True
        rbClientes.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CDate(dtpemisioninicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpemision_fin.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpemisioninicio.Focus()
            Exit Sub
        End If
        ImprimirDocumentosPorEmision()
    End Sub

    Private Sub rbClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles rbClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFiltro.Select()
        End If
    End Sub

    Private Sub rbVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles rbVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFiltro.Select()
        End If
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentos.Select()
        End If
    End Sub

    Private Sub rbMes_Click(sender As Object, e As EventArgs) Handles rbMes.Click
        checkTodos.Checked = False
        dgvDocumentos.DataSource = Nothing
        dtp_mensual.Value = ClsVarComun.FechaSistema
        gbReporte.Enabled = False
        pnlFecha.Visible = False
        pnlMensual.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        gbReporte.Enabled = True
        pnlMensual.Visible = False
        rpt_mensual.Checked = False
        ToolStrip1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If chklstAlmacenes2.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ninguna Serie.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If chklstdocumentos2.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ningun Tipo de Documento.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ImprimirDocumentos_Mensuales()
    End Sub

    Private Sub chk_todos_series_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_series.CheckedChanged
        If chk_todos_series.Checked = True Then
            cmb_tipo_cob.Enabled = False
            cmb_tipo_cob.SelectedIndex = -1
        Else
            cmb_tipo_cob.Enabled = True
            cmb_tipo_cob.SelectedIndex = -1
        End If
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        'chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes.Items.Count - 1
            chklstAlmacenes.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub checkDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles checkDocumentos.CheckedChanged
        Dim i As Integer = 0
        Do While i <= chklstdocumentos.Items.Count - 1
            chklstdocumentos.SetItemChecked(i, checkDocumentos.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub rpt_mensual_CheckedChanged(sender As Object, e As EventArgs) Handles rpt_mensual.CheckedChanged
        If rpt_mensual.Checked Then
            gbReporte.Enabled = False
            pnlMensual.Visible = True
            ToolStrip1.Enabled = False
        Else
            gbReporte.Enabled = True
            pnlMensual.Visible = False
            ToolStrip1.Enabled = True
        End If
    End Sub

    Private Sub checkAlmacen2_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen2.CheckedChanged
        'chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes2.Items.Count - 1
            chklstAlmacenes2.SetItemChecked(i, checkAlmacen2.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub checkDocumentos2_CheckedChanged(sender As Object, e As EventArgs) Handles checkDocumentos2.CheckedChanged
        Dim i As Integer = 0
        Do While i <= chklstdocumentos2.Items.Count - 1
            chklstdocumentos2.SetItemChecked(i, checkDocumentos2.Checked)
            i = i + 1
        Loop
    End Sub
End Class