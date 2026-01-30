Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmReportePendienteCobro_Pago
    Dim dtDocumentosPrincipal As DataTable
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE_PAY
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
                dgvDocumentos.Columns(0).HeaderText = "Selec"
                dgvDocumentos.Columns(1).Width = 100
                dgvDocumentos.Columns(1).ReadOnly = True
                dgvDocumentos.Columns(1).HeaderText = "Codigo"
                dgvDocumentos.Columns(2).Width = 300
                dgvDocumentos.Columns(2).ReadOnly = True
                dgvDocumentos.Columns(2).HeaderText = "Proveedor"
                dgvDocumentos.Columns(3).Width = 120
                dgvDocumentos.Columns(3).ReadOnly = True
                dgvDocumentos.Columns(3).HeaderText = "Ruc"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarDocumentosPendiente_Cliente()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE_PAY
            dtDetalleClientes = New DataTable
            dtv = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.MostrandoClientesDocPendientes()
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtv = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtv
                dgvDocumentos.Columns(4).Visible = False
                dgvDocumentos.Columns(5).Visible = False
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
        Cargar_Documentos()
        MostrarDocumentosPendiente_Cliente()
        txtFiltro.Select()
    End Sub

    Private Sub Cargar_Documentos()
        Try

            Dim documentosBL As ClsOperaciones.DOCUMENT_TYPE
            documentosBL = New ClsOperaciones.DOCUMENT_TYPE

            Dim dtAlmacen As DataTable
            dtAlmacen = New DataTable
            dtAlmacen = documentosBL.get_Tipo_Doc_Pagos()
            chklstdocumentos.Items.Clear()
            If dtAlmacen.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstdocumentos.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
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
            Dim iddocumentos As String = String.Empty
            Dim j As Integer = 0

            Me.Cursor = Cursors.WaitCursor

            'DOCUMENTOS MARCADOS
            Do While j <= chklstdocumentos.CheckedItems.Count - 1
                iddocumentos = iddocumentos & """" & TraerCodigo(chklstdocumentos.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If iddocumentos.Length() <> 0 Then
                iddocumentos = Mid(iddocumentos, 1, iddocumentos.Length - 1)
            End If

            If rbClientes.Checked = True Then
                dtImprimir = New DataTable("Proveedores")
                dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesProveedor(_Codigo, iddocumentos)
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("REP_PEN_PAGOS_PROVEEDOR.rpt", dtImprimir, "", "", "@codigo;" & _Codigo, _
                                              "@TIPO_DOC;" & iddocumentos, _
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

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
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
            MsgBox("No selecciono ningun Proveedor.", MsgBoxStyle.Exclamation)
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
            End If
        Next
        If _Codigo.Length() <> 0 Then
            _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
            ImprimirDocumentosPendientes(_Codigo)
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

    Private Sub rbClientes_Click(sender As Object, e As EventArgs) Handles rbClientes.Click
        checkTodos.Checked = False
        MostrarDocumentosPendiente_Cliente()
        txtFiltro.Text = String.Empty
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        pnlFecha.Visible = False
        gbReporte.Enabled = True
    End Sub

    Private Sub rbFechas_Click(sender As Object, e As EventArgs) Handles rbFechas.Click
        checkTodos.Checked = False
        dgvDocumentos.DataSource = Nothing
        dtpFechainicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpFechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)

        dtpFechainicial_emision.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpFechafinal_emision.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)

        gbReporte.Enabled = False
        pnlFecha.Visible = True
        pnlMensual.Visible = False
    End Sub


    Private Sub ImprimirDocumentosPorVencimiento()
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")
            Dim iddocumentos As String = String.Empty
            Dim j As Integer = 0

            Me.Cursor = Cursors.WaitCursor

            'DOCUMENTOS MARCADOS
            Do While j <= chklstdocumentos.CheckedItems.Count - 1
                iddocumentos = iddocumentos & """" & TraerCodigo(chklstdocumentos.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If iddocumentos.Length() <> 0 Then
                iddocumentos = Mid(iddocumentos, 1, iddocumentos.Length - 1)
            End If

            dtImprimir = reporteBL.EjecutarReporteDocumentosVencimiento_Fechas_Pago(dtpFechainicial.Value.ToString("dd/MM/yyyy"), _
                                                                                    dtpFechafinal.Value.ToString("dd/MM/yyyy").Trim, _
                                                                                    IIf(checkDocumentos.Checked, "", iddocumentos))
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PAGOS_PEN_FECHAS_2.rpt", dtImprimir, "", "", "@FECHA_INICIAL;" & dtpFechainicial.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FINAL;" & dtpFechafinal.Value.ToString("dd/MM/yyyy"), _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "fecha;" & "Del: " & dtpFechainicial.Value.ToString("dd/MM/yyyy") & " Al: " & dtpFechafinal.Value.ToString("dd/MM/yyyy"))
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimirDocumentosPorEmision()
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")
            Dim iddocumentos As String = String.Empty
            Dim j As Integer = 0

            Me.Cursor = Cursors.WaitCursor

            'DOCUMENTOS MARCADOS
            Do While j <= chklstdocumentos.CheckedItems.Count - 1
                iddocumentos = iddocumentos & """" & TraerCodigo(chklstdocumentos.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If iddocumentos.Length() <> 0 Then
                iddocumentos = Mid(iddocumentos, 1, iddocumentos.Length - 1)
            End If

            dtImprimir = reporteBL.EjecutarReporteDocumentosEmision_Fechas_Pago(dtpFechainicial_emision.Value.ToString("dd/MM/yyyy"), _
                                                                                dtpFechafinal_emision.Value.ToString("dd/MM/yyyy"), _
                                                                                IIf(checkDocumentos.Checked, "", iddocumentos))
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PAGOS_PEN_FECHAS_2.rpt", dtImprimir, "", "", "@FECHA_INICIAL;" & dtpFechainicial_emision.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FINAL;" & dtpFechafinal_emision.Value.ToString("dd/MM/yyyy"), _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "fecha;" & "Del: " & dtpFechainicial_emision.Value.ToString("dd/MM/yyyy") & " Al: " & dtpFechafinal_emision.Value.ToString("dd/MM/yyyy"))
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimirDocumentos_Mensual()
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Fechas")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDocumentos_Mensual_Pago(dtp_mensual.Value.Month, dtp_mensual.Value.Year, IIf(rdb_pendiente.Checked, 1, IIf(rdb_todos.Checked, 0, 2)), ModFunciones.Ultimo_Dia_Mes(dtp_mensual.Value))
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PAGOS_PEN_FECHAS.rpt", dtImprimir, "", "", "@MES;" & dtpFechainicial_emision.Value.Month,
                                          "@ANIO;" & dtpFechafinal_emision.Value.Year, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString,
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "HASTA;" & ModFunciones.Ultimo_Dia_Mes(dtp_mensual.Value))
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If CDate(dtpFechainicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpFechainicial.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpFechainicial.Focus()
            Exit Sub
        End If

        If chklstdocumentos.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ningun Tipo de Documento.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ImprimirDocumentosPorVencimiento()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlFecha.Visible = False
        pnlMensual.Visible = False
        gbReporte.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CDate(dtpFechainicial_emision.Value.ToString("dd/MM/yyyy")) > CDate(dtpFechainicial_emision.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpFechainicial_emision.Focus()
            Exit Sub
        End If

        If chklstdocumentos.CheckedItems.Count = 0 Then
            MsgBox("No selecciono ningun Tipo de Documento.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ImprimirDocumentosPorEmision()
    End Sub

    Private Sub rbMensual_Click(sender As Object, e As EventArgs) Handles rbMensual.Click
        checkTodos.Checked = False
        dgvDocumentos.DataSource = Nothing
        dtp_mensual.Value = ClsVarComun.FechaSistema
        gbReporte.Enabled = False
        pnlFecha.Visible = False
        pnlMensual.Visible = True
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlFecha.Visible = False
        pnlMensual.Visible = False
        gbReporte.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ImprimirDocumentos_Mensual()
    End Sub

    Private Sub checkDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles checkDocumentos.CheckedChanged
        Dim i As Integer = 0
        Do While i <= chklstdocumentos.Items.Count - 1
            chklstdocumentos.SetItemChecked(i, checkDocumentos.Checked)
            i = i + 1
        Loop
    End Sub
End Class