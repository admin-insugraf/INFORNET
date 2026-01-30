Imports LibCompras
Imports LibComunVar
Imports LibCobranzas
Imports System.IO
Imports System.Collections.Specialized

Public Class FrmRequisiciones_Materiales
    Dim Modo_consultar As Boolean = False
    Dim dtdetallePrincipal As DataTable
    Private _tipoMov As String = String.Empty

    Dim clsRequisionesBl As ClsOperaciones.REQUIREMENT
    Dim dtDocumentos As DataTable
    Dim dtv As DataView
    Dim STRorden As String = ""

    Dim CORRELATIVOBL As ClsTransacciones.REQUIREMENT
    Dim _Flag_edicion As Boolean = False
    Dim _Codigo_Ini As String = ""

    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtAlmacen As DataTable
    Private mySetting As NameValueCollection

    Private Sub FrmRequisiciones_Materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        GenerarColummnaDataTable()
        'btnNuevo_Click(sender, e)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Areas()
        cboopcionesBusqueda.SelectedIndex = 1
        
    End Sub

    Private Sub Cargar_Areas()
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtAlmacen = New DataTable
            dtAlmacen = clsRequisionesBl.get_Lista_Areas()
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("ID") = ""
            row.Item("DESCRIPTION") = "Todos"
            dtAlmacen.Rows.InsertAt(row, 0)
            cboareas.DataSource = dtAlmacen
            cboareas.DisplayMember = "DESCRIPTION"
            cboareas.ValueMember = "ID"
            cboareas.SelectedIndex = 0
            clsRequisionesBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsRequisionesBl.get_DatosGeneralesRequisiciones_RM(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex, TipoMov, cboareas.SelectedValue.ToString)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 6 To dgvCabecera.ColumnCount() - 1
                    dgvCabecera.Columns(i).Visible = False
                Next
                dgvCabecera.Columns(8).Visible = True
                dgvCabecera.Columns(4).Visible = False
                dgvCabecera.Columns("Solicitante").Visible = True
                dgvCabecera.Columns("Comentario").Visible = False
                dgvCabecera.Columns("Area").Visible = False

                STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(5).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
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
                STRorden = dgvCabecera.Columns(1).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(3).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(4).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns(5).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name & "+" & dgvCabecera.Columns(5).Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub Ayuda_Solicitante()
        Try

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_SOLICITANTE_REQ_MATERIALES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Solicitantes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtarea.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de areas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarea.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_area.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtsolicitante.MouseDoubleClick
        Ayuda_Solicitante()
    End Sub

    Private Sub txtsolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Solicitante()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtsolicitante.Text = "" Then
                Ayuda_Solicitante()
            Else
                txtcodigoArticulo_2.Focus()
            End If
        End If
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txtarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarea.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Area()
        End If
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TipoMov
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo_2.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo_2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida_2.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                Mostrar_Stock()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar_Stock()
        Try
            If txtcodigoArticulo_2.Text = "" Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            pnl_stock.Visible = True
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            Dim dtdetalle_part As New DataTable
            dtdetalle_part = clsRequisionesBl.Datos_Stock_Req_Materiales(txtcodigoArticulo_2.Text)
            dgv_stock.DataSource = Nothing
            dgv_stock.DataSource = dtdetalle_part
            If dtdetalle_part.Rows.Count() <> 0 Then
                dgv_stock.Columns(0).Width = 50
                dgv_stock.Columns(1).Width = 300
                dgv_stock.Columns(2).Width = 95
                dgv_stock.Columns(2).DefaultCellStyle.Format = "N4"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub blank()
        txtcodigoArticulo_2.Text = ""
        txtdescripcionArticulo_2.Text = ""
        txtunidadMedida_2.Text = ""
        txtcantidad_2.Text = ""
        txtobservacion_2.Text = ""
        txt_orden_produccion.Text = ""
        dgv_stock.DataSource = Nothing
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetallePrincipal.Rows
            i += 1
            dtdetallePrincipal.BeginInit()
            items("ITEM") = i
            dtdetallePrincipal.EndInit()
            dtdetallePrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
        GbCabecera.Enabled = True
        DocumentosRequisiones()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If rdb_sol_mp.Checked = False And rdb_sol_complementos.Checked = False Then
                MsgBox("Debe un tipo de Requerimiento.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If dgvDetalle.RowCount() = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim MSJ As String = ""
            Dim MSJ_RES As String = ""
            If Modo_consultar = True Then
                MSJ = "¿Desea Modificar la Requisicion.?"
                MSJ_RES = "Actualizado Exitosamente."
            Else
                MSJ = "¿Desea Generar la Requisicion.?"
                MSJ_RES = "Guardado Exitosamente."
            End If
            If MessageBox.Show(MSJ, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If GuardarModificarRequisiciones() = True Then
                    MsgBox(MSJ_RES, MsgBoxStyle.Information)
                    btnNuevo_Click(sender, e)
                Else
                    MsgBox("No se genero ningun documento.", MsgBoxStyle.Critical, "Aviso")
                End If

            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GuardarModificarRequisiciones() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            Dim cabeceraBL As New ClsOperaciones.REQUIREMENT
            Dim cabeceraBE As New ClsEntidades.REQUIREMENT
            Dim ls_det As New List(Of ClsEntidades.REQUIREMENT_LINE)
            Dim detalle As New ClsEntidades.REQUIREMENT_LINE

            With cabeceraBE
                .TYPE = txttipoDoc.Text
                If Modo_consultar = True Then
                    .ID = txtcodigo.Text
                    .STATUS = txtestado.Text
                Else
                    .ID = Numeracion()
                    .STATUS = "P"
                End If
                .REQUIRED_USER = txtsolicitante.Text
                .REQUIRED_DATE = dtpFechad.Value
                .COMMENT = txtcomentario.Text
                .AREA_ID = txtarea.Text
                .CREATE_DATE = Date.Now
                .UPDATE_DATE = Date.Now
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PROJECT_ID = ""
                If rdb_breña.Checked Then
                    .SEDE = "BREÑA"
                ElseIf rdb_campoy.Checked Then
                    .SEDE = "CAMPOY"
                End If
                .TIPO = IIf(rdb_sol_mp.Checked, rdb_sol_mp.Text, rdb_sol_complementos.Text)
            End With

            'Detalle de Factura
            For i As Integer = 0 To dtdetallePrincipal.Rows.Count() - 1
                detalle = New ClsEntidades.REQUIREMENT_LINE
                With detalle
                    .ID = cabeceraBE.ID
                    .TYPE = TipoMov
                    .ITEM = dtdetallePrincipal.Rows(i).Item("ITEM")
                    .PART_ID = dtdetallePrincipal.Rows(i).Item("PART_ID")
                    .PART_DESCRIPTION = dtdetallePrincipal.Rows(i).Item("PART_DESCRIPTION")
                    .UNIT = dtdetallePrincipal.Rows(i).Item("UNIT")
                    .QTY = dtdetallePrincipal.Rows(i).Item("QTY")
                    .STATUS = "P"
                    .DOCUMENT_DATE = dtpFechad.Value
                    .AMOUNT_BALANCE = dtdetallePrincipal.Rows(i).Item("AMOUNT_BALANCE")
                    .CCOST_ID = dtdetallePrincipal.Rows(i).Item("CCOST_ID")
                    .COMMENT = dtdetallePrincipal.Rows(i).Item("COMMENT")
                    .PROJECT_ID = dtdetallePrincipal.Rows(i).Item("PROJECT_ID")

                    If String.IsNullOrEmpty(dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD").ToString) Then
                        .COD_PRIORIDAD = "0"
                    Else
                        If dtdetallePrincipal.Rows(i).Item("COD_PRIORIDAD") = "Urgente" Then
                            .COD_PRIORIDAD = "1"
                        End If
                    End If
                    .ID_VENDOR = dtdetallePrincipal.Rows(i).Item("ID_VENDOR").ToString
                    .NUMERO_OP = dtdetallePrincipal.Rows(i).Item("NUMERO_OP").ToString
                End With
                ls_det.Add(detalle)
            Next
            ''GUARDANDO DATOS DE LA FACTURACION
            If Modo_consultar = True Then
                If cabeceraBL.ActualizarRequisiciones_RM(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Actualización del Requerimiento", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            Else
                If cabeceraBL.GuardarRequerimientos_RM(cabeceraBE, ls_det) = False Then
                    MsgBox("Hubo un Error en la Generación del Requerimiento", MsgBoxStyle.Critical)
                    indicadorF = False
                    Exit Try
                End If
            End If
            'If MessageBox.Show("¿Desea imprimir el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            imprimirRequisicion(TipoMov, cabeceraBE.ID)
            'End If
            'EnviarMail(cabeceraBE.ID, TipoMov, Ruta_Reportes() & "\" & TipoMov & cabeceraBE.ID & ".pdf")
        Catch ex As Exception
            MsgBox(ex.Message)
            indicadorF = False
        End Try
        Return indicadorF
    End Function

    Private Function Ruta_Reportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta = mySetting("Reportes")
        Return STRRuta
    End Function

    Private Sub EnviarMail(ByVal Numerodoc As String, ByVal _Tipodoc As String, ByVal StrNomArchivo_PDF As String)
        Try
            'Dim envio_mail As New LibManufactura.FrmEnvioEmail_Requerimiento
            'envio_mail._document_id = _Tipodoc
            'envio_mail._number_document = Numerodoc
            'envio_mail._codigo_datos_email = "02"
            'envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
            'envio_mail._archivo_pdf = StrNomArchivo_PDF
            'envio_mail._nombre_documento = _Tipodoc & Numerodoc
            'envio_mail.ShowDialog()
            'envio_mail.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            Dim estadoInicial As String = ""
            estadoInicial = dgvCabecera.Item(13, dgvCabecera.CurrentRow.Index).Value
            If estadoInicial = "A" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If estadoInicial = "O" Then
                MsgBox("El documento ya se encuentra anexado a una Orden de compra no se puede anular.", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf estadoInicial = "SC" Or estadoInicial = "AC" Then
                MsgBox("El documento ya se encuentra anexado a una Cotización no se puede anular.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿Desea anular el documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsRequisionesBl = New ClsOperaciones.REQUIREMENT
                Dim _CODIGO_REQUES As String = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
                If clsRequisionesBl.Anular_Requisicion(_CODIGO_REQUES, TipoMov) = False Then
                    MsgBox("Hubo un error, no se completo el Proceso de anulacion", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Me.Cursor = Cursors.Default
                btnCancelar_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        Modo_consultar = True
        limpiar()
        'Dim estado As String = dgvCabecera.Item(8, dgvCabecera.CurrentRow.Index).Value
        'If estado <> "EMITIDO" Then
        '    btnGrabar.Enabled = False
        'End If
        pnlCabecera.Visible = False
        MostrarModoConsultar()
    End Sub


    Private Sub MostrarModoConsultar()
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtCabeceraReq = New DataTable
            dtDetalleReq = New DataTable
            '---Mostrando Datos de Cabecera
            Dim codigo As String = ""
            codigo = dgvCabecera.CurrentRow.Cells("Codigo").Value

            dtCabeceraReq = clsRequisionesBl.Get_cabecera_Requisiciones_materiales_RM(TipoMov, codigo)
            If dtCabeceraReq.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraReq.Rows(0).Item("Codigo").ToString
                txttipoDoc.Text = dtCabeceraReq.Rows(0).Item("Tipo").ToString
                txtsolicitante.Text = IIf(String.IsNullOrEmpty(dtCabeceraReq.Rows(0).Item("REQUIRED_USER").ToString), "", dtCabeceraReq.Rows(0).Item("REQUIRED_USER").ToString)
                txtdescripcion_solicitante.Text = IIf(String.IsNullOrEmpty(dtCabeceraReq.Rows(0).Item("Solicitante").ToString), "", dtCabeceraReq.Rows(0).Item("Solicitante").ToString)
                txtarea.Text = dtCabeceraReq.Rows(0).Item("AREA_ID").ToString
                txtdescripcion_area.Text = dtCabeceraReq.Rows(0).Item("Area").ToString
                txtcomentario.Text = dtCabeceraReq.Rows(0).Item("Comentario").ToString
                dtpFechad.Value = dtCabeceraReq.Rows(0).Item("Fecha").ToString
                txtestado.Text = dtCabeceraReq.Rows(0).Item("STATUS").ToString
                lbl_usuario.Text = dtCabeceraReq.Rows(0).Item("USER_ID").ToString

                If dtCabeceraReq.Rows(0).Item("SEDE").ToString = "BREÑA" Then
                    rdb_breña.Checked = True
                ElseIf dtCabeceraReq.Rows(0).Item("SEDE").ToString = "CAMPOY" Then
                    rdb_campoy.Checked = True
                End If

                If dtCabeceraReq.Rows(0).Item("TIPO_SOLICITUD").ToString = rdb_sol_mp.Text Then
                    rdb_sol_mp.Checked = True
                ElseIf dtCabeceraReq.Rows(0).Item("TIPO_SOLICITUD").ToString = rdb_sol_complementos.Text Then
                    rdb_sol_complementos.Checked = True
                End If

                If dtCabeceraReq.Rows(0).Item("Estado").ToString <> "EMITIDO" Then
                    btnGrabar.Enabled = False
                    GroupBox5.Enabled = False
                Else
                    GroupBox5.Enabled = True
                End If
            End If

            GenerarColummnaDataTable()
            dtdetallePrincipal = clsRequisionesBl.DatosRequisicionDetalleModoEdicion_RM(TipoMov, codigo)
            If dtdetallePrincipal.Rows.Count() <> 0 Then
                configurarGrilla()
            End If
            rdb_breña.Enabled = False
            rdb_campoy.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub imprimirRequisicion(ByVal tipo As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim fq As New LibContabilidad.ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty

            If dt_info_emp.Rows.Count > 0 Then
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            End If


            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteRequisiciones_RM(tipo, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte_Exporta_PDF_II("rpt_Compras_requisiciones_materiales.rpt", dtImprimir, "", "", tipo & numerodocument, _
                                                      "@TYPE;" & tipo, "@ID;" & numerodocument, _
                                                      "RUC;" & ruc, "EMPRESA;" & razon)
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _CODIGO_REQUES As String = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        imprimirRequisicion(TipoMov, _CODIGO_REQUES)
    End Sub

    Private Sub dtpFechad_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcomentario.Select()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub


    Private Sub txtcomentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomentario.KeyDown
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub

    Private Sub dgvCabecera_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCabecera.MouseDoubleClick
        btnConsultar_Click(sender, e)
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_UNIDAD_MEDIDA"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTADO DE UNIDADES DE MEDIDA"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtunidadMedida_2.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboareas.SelectedIndexChanged
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub

    Private Sub rdb_breña_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_breña.CheckedChanged
        If Modo_consultar = False Then
            If rdb_breña.Checked Then
                txtcodigo.Text = Numeracion()
            End If
        End If

    End Sub

    Private Sub rdb_campoy_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_campoy.CheckedChanged
        If Modo_consultar = False Then
            If rdb_campoy.Checked Then
                txtcodigo.Text = Numeracion()
            End If
        End If

    End Sub

    Public Property TipoMov() As String
        Get
            Return _tipoMov
        End Get
        Set(value As String)
            _tipoMov = value
        End Set
    End Property

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetallePrincipal = New DataTable("Requisiciones")
            dtdetallePrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetallePrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("AMOUNT_BALANCE", Type.GetType("System.Double"))
            dtdetallePrincipal.Columns.Add("COMMENT", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("CCOST_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("PROJECT_ID", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("COD_PRIORIDAD", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("ID_VENDOR", Type.GetType("System.String"))
            dtdetallePrincipal.Columns.Add("NUMERO_OP", Type.GetType("System.String"))
            dtdetallePrincipal.PrimaryKey = New DataColumn() {dtdetallePrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub configurarGrilla()
        dgvDetalle.DataSource = dtdetallePrincipal
        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        For i As Integer = 7 To dgvDetalle.Columns.Count() - 1
            dgvDetalle.Columns(i).Visible = False
        Next
        dgvDetalle.Columns(5).Visible = False
        dgvDetalle.Columns(9).Visible = False
        dgvDetalle.Columns(10).Visible = False
        dgvDetalle.Columns("ITEM").HeaderText = "Item"
        dgvDetalle.Columns("PART_ID").HeaderText = "Codigo"
        dgvDetalle.Columns("PART_DESCRIPTION").HeaderText = "Descripción"
        dgvDetalle.Columns("UNIT").HeaderText = "Unidad"
        dgvDetalle.Columns("QTY").HeaderText = "Cantidad"
        dgvDetalle.Columns("AMOUNT_BALANCE").HeaderText = "Monto"
        dgvDetalle.Columns("COMMENT").HeaderText = "Comentario"
        dgvDetalle.Columns("COD_PRIORIDAD").HeaderText = "Prioridad"
        dgvDetalle.Columns("ID_VENDOR").HeaderText = "Proveedor"
        dgvDetalle.Columns("NUMERO_OP").Visible = True
        dgvDetalle.Columns("NUMERO_OP").HeaderText = "N° O.P."
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Sub limpiar()
        txtarea.Text = ""
        txtdescripcion_area.Text = ""
        txtsolicitante.Text = ""
        txtdescripcion_solicitante.Text = ""
        txtcomentario.Text = ""
        txttipoDoc.Text = ""
        txtcodigo.Text = ""
        dtpFechad.Value = Date.Today
        'rdb_breña.Checked = True
        'rdb_campoy.Checked = False
        rdb_breña.Enabled = True
        rdb_campoy.Enabled = True
        dtdetallePrincipal.Rows.Clear()
        dgvDetalle.DataSource = Nothing
        lbl_usuario.Text = ""
        GroupBox5.Enabled = True
        rdb_sol_mp.Checked = False
        rdb_sol_complementos.Checked = False
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            GenerarColummnaDataTable()
            configurarGrilla()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_consultar = False
            _Flag_edicion = False
            GbCabecera.Enabled = True
            txttipoDoc.Text = TipoMov
            txtcodigo.Text = Numeracion()
            txtsolicitante.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.REQUIREMENT
            CORRELATIVOBL.NumeroCorrelativoRequisicion(TipoMov)
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                If rdb_breña.Checked Then
                    Correlativo = String.Format("{0:0000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
                ElseIf rdb_campoy.Checked Then
                    'Correlativo = "C" & String.Format("{0:000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
                    Correlativo = String.Format("{0:0000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub txtcodigoArticulo_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo_2.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub txtcodigoArticulo_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo_2.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo_2.Text = String.Empty Then
                MostrandoArticulos()
            Else
                txtcantidad_2.Select()
            End If
        End If
    End Sub

    Private Sub txtunidadMedida_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadMedida_2.MouseDoubleClick
        'Ayuda_Unidad_Medida()
    End Sub

    Private Sub txtunidadMedida_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunidadMedida_2.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    Ayuda_Unidad_Medida()
        'End If
        If e.KeyCode = Keys.Enter Then
            'If txtunidadMedida_2.Text = "" Then
            '    Ayuda_Unidad_Medida()
            'Else
            '    txtcantidad_2.Focus()
            'End If
            txtcantidad_2.Focus()
        End If
    End Sub

    Private Sub txtcantidad_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad_2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_orden_produccion.Focus()
        End If
    End Sub

    Private Sub txtobservacion_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservacion_2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar_2.Focus()
        End If
    End Sub

    Private Sub btnAgregar_2_Click(sender As Object, e As EventArgs) Handles btnAgregar_2.Click
        Try
            If txtcodigoArticulo_2.Text = "" Then
                MsgBox("Debe seleccionar un Producto.", MsgBoxStyle.Critical)
                txtcodigoArticulo_2.Select()
                Exit Sub
            End If
            If txtunidadMedida_2.Text = "" Then
                MsgBox("Debe seleccionar una Unidad de Medida.", MsgBoxStyle.Critical)
                txtunidadMedida_2.Select()
                Exit Sub
            End If
            If txtcantidad_2.Text = "" Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Critical)
                txtcantidad_2.Select()
                Exit Sub
            ElseIf Val(txtcantidad_2.Text) = 0 Then
                MsgBox("Debe ingresar una cantidad diferente de 0.", MsgBoxStyle.Critical)
                txtcantidad_2.Select()
                Exit Sub
            End If
            'If txt_orden_produccion.Text.Trim = "" Then
            '    MsgBox("Debe seleccionar una Orden de Producción.", MsgBoxStyle.Critical)
            '    txt_orden_produccion.Select()
            '    Exit Sub
            'End If

            Me.Cursor = Cursors.WaitCursor

            If _Flag_edicion = False Then 'nuevo producto
                Dim row As DataRow = dtdetallePrincipal.NewRow
                row("ITEM") = dtdetallePrincipal.Rows.Count() + 1
                row("PART_ID") = txtcodigoArticulo_2.Text
                row("PART_DESCRIPTION") = txtdescripcionArticulo_2.Text
                row("UNIT") = txtunidadMedida_2.Text
                row("QTY") = txtcantidad_2.Text
                row("AMOUNT_BALANCE") = 0
                row("CCOST_ID") = ""
                row("COMMENT") = txtobservacion_2.Text
                row("PROJECT_ID") = ""
                row("COD_PRIORIDAD") = ""
                row("ID_VENDOR") = ""
                row("NUMERO_OP") = txt_orden_produccion.Text
                dtdetallePrincipal.Rows.Add(row)
                dtdetallePrincipal.AcceptChanges()
                configurarGrilla()
                blank()
                txtcodigoArticulo_2.Select()
            Else
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetallePrincipal.BeginInit()
                    item("PART_ID") = txtcodigoArticulo_2.Text
                    item("PART_DESCRIPTION") = txtdescripcionArticulo_2.Text
                    item("UNIT") = txtunidadMedida_2.Text
                    item("QTY") = txtcantidad_2.Text
                    item("COMMENT") = txtobservacion_2.Text
                    item("COD_PRIORIDAD") = ""
                    item("ID_VENDOR") = ""
                    item("NUMERO_OP") = txt_orden_produccion.Text
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()
                Next
                configurarGrilla()
                blank()
                btnModificar_2.Enabled = True
                btnquitar_2.Enabled = True
                btnGrabar.Enabled = True
                txtcodigoArticulo_2.Select()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_2_Click(sender As Object, e As EventArgs) Handles btnModificar_2.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            _Flag_edicion = True
            _Codigo_Ini = String.Empty
            _Codigo_Ini = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            blank()
            Me.Cursor = Cursors.WaitCursor
            For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & _Codigo_Ini)
                txtcodigoArticulo_2.Text = item("PART_ID")
                txtdescripcionArticulo_2.Text = item("PART_DESCRIPTION")
                txtunidadMedida_2.Text = item("UNIT")
                txtcantidad_2.Text = CDbl(item("QTY"))
                txtobservacion_2.Text = item("COMMENT")
                txt_orden_produccion.Text = item("NUMERO_OP")
                txtcodigoArticulo_2.Focus()
                btnModificar_2.Enabled = False
                btnquitar_2.Enabled = False
                btnGrabar.Enabled = False
                Mostrar_Stock()
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_2_Click(sender As Object, e As EventArgs) Handles btnquitar_2.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetallePrincipal.Select("ITEM=" & Codigo)
                    dtdetallePrincipal.BeginInit()
                    item.Delete()
                    dtdetallePrincipal.EndInit()
                    dtdetallePrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_orden_produccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_orden_produccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_OrdenProduccion()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_orden_produccion.Text = "" Then
                Ayuda_OrdenProduccion()
            Else
                txtobservacion_2.Focus()
            End If

        End If
    End Sub

    Private Sub txt_orden_produccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_orden_produccion.MouseDoubleClick
        Ayuda_OrdenProduccion()
    End Sub
    Private Sub Ayuda_OrdenProduccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MANTENIMIENTO_OP_BANDEJA_PRE_PRENSA_REQUERIMIENTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Ordenes de Producción"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_orden_produccion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("Estado").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub
End Class