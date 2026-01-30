Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports DllInventario

Public Class Frm_Generar_OP
    Private edicion As Boolean
    Private _tipoMov As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String


    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim dtTransaccionTipo As DataTable

    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
    Dim clsAlmacenCorrelativoBl_Ingreso As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

    Dim dtv As DataView
    Dim STRorden As String
    Dim dtData As DataTable
    Dim Modo_consultar As Boolean = False

    Dim dtdetalleArticuloPrincipal_productos As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_puente As DataTable
    Dim dtdetalleArticuloPrincipal_Procesos As DataTable
    Dim dtdetalleArticuloPrincipal_Procesos_puente As DataTable
    Dim dtdetalleBultosPrincipal As DataTable

    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim Fl_close As Boolean = False

    Dim clsBusquedaBl As ClsBuscar
    Dim TipoArticulo As String = String.Empty
    Dim PerteneceGuiaAnalisis As Boolean = False

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty
    Dim Ref_trasactiontype As String = String.Empty
    Dim Ref_tipo As String = String.Empty

    Dim _STOCK As Double
    Dim _COSTO As Double

    Dim clsBusquedaBl_val As ClsBuscar
    Dim dtUltimoMes As DataTable
    'Dim dtAlmacen As DataTable
    Dim dtTipoCambio As DataTable
    Dim dtDocumentosSinVal As DataTable
    Dim dtSaldoNegativo As DataTable
    Dim dtStockArticulo As DataTable
    Dim dtRevalorizaLotes As DataTable
    Dim dtDatosCompany As DataTable

    Dim _Fecha_Inicio As Date
    Dim _Fecha_Fin As Date

    Dim _Flag_edicion As Boolean = False
    Dim _Codigo_Ini As String = ""
    Dim _contador_despachos As Integer
    Dim _nuevo_edicion As Boolean = False

    Private Sub Frm_Generar_OP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
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
            myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
            Dim INTnewpos As Integer
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub


    Private Sub MostrandoDatosGeneralesCabeceraAlmacen()
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable

            dtData = clsBusquedaBl.get_DatosGenerales_Produccion_Op(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                 cboopcionesBusqueda.SelectedIndex)
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv

                dgvCabeceraAlmacen.Columns("NUMERO_DOC").HeaderText = "N° Doc."
                dgvCabeceraAlmacen.Columns("FECHA_DOC").HeaderText = "Fecha Doc."
                dgvCabeceraAlmacen.Columns("COD_PRODUCTO").HeaderText = "Cod. Producto"
                dgvCabeceraAlmacen.Columns("PRODUCTO").HeaderText = "Producto"
                dgvCabeceraAlmacen.Columns("UNIDAD").HeaderText = "Unidad"
                dgvCabeceraAlmacen.Columns("CANTIDAD").HeaderText = "Cantidad"
                dgvCabeceraAlmacen.Columns("N_REQUERIMIENTO").HeaderText = "N° Req."
                dgvCabeceraAlmacen.Columns("Estado").HeaderText = "Estado"
                dgvCabeceraAlmacen.Columns("CLIENTE").HeaderText = "Cliente"
                dgvCabeceraAlmacen.Columns("FECHA_ENTREGA").HeaderText = "Fecha de Entrega"
                dgvCabeceraAlmacen.Columns("Estado_Liquidacion").HeaderText = "Estado de Liquidación"
                dgvCabeceraAlmacen.Columns("Estado.Dispensacion").HeaderText = "Estado de Dispensación"
                dgvCabeceraAlmacen.Columns("Estado.Parte.Entrega").HeaderText = "Estado Parte Entrega"

                dgvCabeceraAlmacen.Columns("NUMERO_DOC").Width = 50
                dgvCabeceraAlmacen.Columns("FECHA_DOC").Width = 70
                dgvCabeceraAlmacen.Columns("COD_PRODUCTO").Width = 100
                dgvCabeceraAlmacen.Columns("PRODUCTO").Width = 250
                dgvCabeceraAlmacen.Columns("UNIDAD").Width = 70
                dgvCabeceraAlmacen.Columns("CANTIDAD").Width = 100
                dgvCabeceraAlmacen.Columns("N_REQUERIMIENTO").Width = 70
                dgvCabeceraAlmacen.Columns("Estado").Width = 100
                dgvCabeceraAlmacen.Columns("CLIENTE").Width = 250
                dgvCabeceraAlmacen.Columns("FECHA_ENTREGA").Width = 100
                dgvCabeceraAlmacen.Columns("Estado_Liquidacion").Width = 150
                dgvCabeceraAlmacen.Columns("Estado.Dispensacion").Width = 100
                dgvCabeceraAlmacen.Columns("Estado.Parte.Entrega").Width = 100

                dgvCabeceraAlmacen.Columns("CANTIDAD").DefaultCellStyle.Format = "N4"
                dgvCabeceraAlmacen.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                STRorden = dgvCabeceraAlmacen.Columns("NUMERO_DOC").Name & "+" & dgvCabeceraAlmacen.Columns("COD_PRODUCTO").Name & "+" & dgvCabeceraAlmacen.Columns("PRODUCTO").Name & "+" & dgvCabeceraAlmacen.Columns("CLIENTE").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Visible = False
            Case 1
                gbRangofechas.Visible = False
            Case 2
                gbRangofechas.Visible = True
        End Select
        txtFiltro.Text = String.Empty
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub
    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            If Modo_consultar = True Then
                'btnGrabar.Enabled = False
                btnAprobar.Visible = True
                btn_elegir_op.Visible = False
            Else
                'btnGrabar.Enabled = True
                btnAprobar.Visible = False
                btn_elegir_op.Visible = True
            End If
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
            Tool_Anular.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnAprobar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
            Tool_Anular.Enabled = True
            btnAprobar.Visible = False
        End If
    End Sub

    Private Sub Nuevo()
        Try
            pnlprincipal.Visible = False
            GbTransaccion.Enabled = True
            Modo_consultar = False
            GenerarColummnaDataTable_Productos()
            GenerarColummnaDataTable_Insumos()
            GenerarColummnaDataTable_Procesos()

            GenerarColummnaDataTable_Insumos_Puente()
            GenerarColummnaDataTable_Procesos_Puente()

            Limpiar_GroupBox(GbTransaccion)
            gb_productos.Visible = True
            gbOpciones.Visible = True
            _contador_despachos = 0
            _nuevo_edicion = False
            dtpFecha.Value = Date.Now
            btnAgregar.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub AnularDocumentosAlmacen()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim Num_Oc As String = String.Empty
            Dim Usuario As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            'If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Num_Oc = dgvCabeceraAlmacen.CurrentRow.Cells("NUMBER_PURCHASE").ToString
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            'almacenBL.AnularDocumentosAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument, Usuario, Num_Oc, txt_observaciones_generales.Text)
            Dim msj As String = String.Empty
            msj = "Documento anulado Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            MostrandoDatosGeneralesCabeceraAlmacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub imprimirOp(ByVal _Codigo As Integer, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As New DataTable()
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.Get_Imprimir_Orden_produccion(_Codigo)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Insugraf_ii.rpt", dtImprimir_OP, "", "", _
                                          "@ID_CAB;" & _Codigo, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
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

    Private Sub imprimirOp_II(ByVal _Codigo As Integer, ByVal _item As Integer)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As New DataTable()
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.Get_Imprimir_Orden_produccion_II(_Codigo, _item)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Insugraf_ii.rpt", dtImprimir_OP, "", "", _
                                          "@ID_CAB;" & _Codigo, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
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


    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Private Sub cboAlmacenBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs)
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlprincipal.Visible = True
        Modo_consultar = False
        btn_elegir_op.Visible = False
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        'If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirOp(CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value), "")
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub

        If dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "PRODUCCION" Then
            MsgBox("No se puede eliminar la Orden de Producción" & Chr(13) & "se encuentra en un estado superior a EMITIDO.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Se va a eliminar el registro seleccionado" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarDocumentosAlmacen(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value)
        End If
    End Sub

    Private Sub EliminarDocumentosAlmacen(ByVal opcion_ As Integer)
        Try
            Dim Usuario As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            Me.Cursor = Cursors.WaitCursor
            If almacenBL.Eliminar_Produccion_OP(opcion_) Then
                MsgBox("Documento eliminado Correctamente.", MsgBoxStyle.Information)
                MostrandoDatosGeneralesCabeceraAlmacen()
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click_1(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal_productos.Rows.Count = 0 Then Exit Sub

        'For Each row As DataRow In dtdetalleArticuloPrincipal.Select("SALDO<0", "")
        '    MessageBox.Show("El stock es insuficiente para realizar la Producción. Verifique!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'Next
        

        If MessageBox.Show("Se va a registrar la Orden de Producción" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Generar_Produccion_Alimentos() = True Then
                Nuevo()
                MostrandoDatosGeneralesCabeceraAlmacen()
            End If
        End If
    End Sub

    Private Function Generar_Produccion_Alimentos() As Boolean
        Try
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.PRODUCCION_OP_LINE)
            Dim ls_det_alm_procesos As New List(Of ClsEntidades.PRODUCCION_OP_LINE_PROCESOS)
            Dim alm_cabBE As New ClsEntidades.PRODUCCION_OP
            Dim alm_cab As New ClsEntidades.PRODUCCION_OP
            Dim ls_det As New List(Of ClsEntidades.PRODUCCION_OP)
            Dim alm_detBE As ClsEntidades.PRODUCCION_OP_LINE
            Dim alm_detBE_procesos As ClsEntidades.PRODUCCION_OP_LINE_PROCESOS
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            With alm_cab
                If Modo_consultar = False Then
                    .ID = 0
                Else
                    .ID = txt_numero.Text
                End If
                .FECHA = dtpFecha.Value.ToString("dd/MM/yyyy")
                .STATUS = "V"
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
            End With

            For i As Integer = 0 To dtdetalleArticuloPrincipal_productos.Rows.Count() - 1
                alm_cabBE = New ClsEntidades.PRODUCCION_OP
                With alm_cabBE
                    .ID_CAB = alm_cab.ID
                    .ITEM = dtdetalleArticuloPrincipal_productos.Rows(i).Item("ITEM").ToString
                    .COD_CLIENTE = dtdetalleArticuloPrincipal_productos.Rows(i).Item("CODIGO_CLIENTE").ToString
                    .FECHA_ENTREGA = dtdetalleArticuloPrincipal_productos.Rows(i).Item("FECHA_ENTREGA").ToString
                    .VENDEDOR = dtdetalleArticuloPrincipal_productos.Rows(i).Item("CODIGO_VENDEDOR").ToString
                    .DESTINATARIO = dtdetalleArticuloPrincipal_productos.Rows(i).Item("DESTINATARIO").ToString
                    .URGENTE = dtdetalleArticuloPrincipal_productos.Rows(i).Item("URGENTE").ToString
                    .OBSERVACIONES = dtdetalleArticuloPrincipal_productos.Rows(i).Item("OBSERVACIONES").ToString
                    .PART_ID = dtdetalleArticuloPrincipal_productos.Rows(i).Item("CODIGO").ToString
                    .CANTIDAD = dtdetalleArticuloPrincipal_productos.Rows(i).Item("CANTIDAD").ToString
                    .FACTOR = dtdetalleArticuloPrincipal_productos.Rows(i).Item("FACTOR").ToString
                    If IsDBNull(dtdetalleArticuloPrincipal_productos.Rows(i).Item("ID_REQUERIMIENTO").ToString) Then
                        .ID_REQUERIMIENTO = "0"
                    Else
                        If dtdetalleArticuloPrincipal_productos.Rows(i).Item("ID_REQUERIMIENTO").ToString = "" Then
                            .ID_REQUERIMIENTO = "0"
                        Else
                            .ID_REQUERIMIENTO = dtdetalleArticuloPrincipal_productos.Rows(i).Item("ID_REQUERIMIENTO").ToString
                        End If
                    End If

                    If IsDBNull(dtdetalleArticuloPrincipal_productos.Rows(i).Item("ITEM_REQUERIMIENTO").ToString) Then
                        .ITEM_REQUERIMIENTO = "0"
                    Else
                        If dtdetalleArticuloPrincipal_productos.Rows(i).Item("ITEM_REQUERIMIENTO").ToString = "" Then
                            .ITEM_REQUERIMIENTO = "0"
                        Else
                            .ITEM_REQUERIMIENTO = dtdetalleArticuloPrincipal_productos.Rows(i).Item("ITEM_REQUERIMIENTO").ToString
                        End If
                    End If

                End With
                ls_det.Add(alm_cabBE)
            Next
            

            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.PRODUCCION_OP_LINE
                With alm_detBE
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .ITEM_PRODUCTO = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM_PRODUCTO").ToString
                    .CODIGO = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .COSTO = dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString
                    .CANTIDAD = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .TOTAL = dtdetalleArticuloPrincipal.Rows(i).Item("TOTAL").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            For i As Integer = 0 To dtdetalleArticuloPrincipal_Procesos.Rows.Count() - 1
                alm_detBE_procesos = New ClsEntidades.PRODUCCION_OP_LINE_PROCESOS
                With alm_detBE_procesos
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("ITEM").ToString
                    .ITEM_PRODUCTO = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("ITEM_PRODUCTO").ToString
                    .PROCESO = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("PROCESO").ToString
                    .MAQUINA = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("MAQUINA").ToString
                    .INICIO = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("INICIO").ToString
                    .FIN = dtdetalleArticuloPrincipal_Procesos.Rows(i).Item("FIN").ToString
                End With
                ls_det_alm_procesos.Add(alm_detBE_procesos)
            Next

            Me.Cursor = Cursors.WaitCursor
            '--PARTE DE ALMACEN
            If almacenBL.Guardar_Produccion_OP(alm_cab, ls_det, ls_det_alm, ls_det_alm_procesos, Modo_consultar) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                If Modo_consultar = False Then
                    msj = "Generación de Orden de Producción correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                Else
                    msj = "Modificación de Orden de Producción correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                End If
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        dtp_inicio.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        dtp_fin.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        Call Botonera_Estado_Cambiar(True)

        If MostrarModoEdicion(CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value)) Then
            TabControl1.SelectedIndex = 0
            pnlprincipal.Visible = False

            If dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "PRODUCCION" Or
                dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "P.E. PARCIAL" Or
                dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "P.E TOTAL" Then
                btnAprobar.Visible = False
                btnGrabar.Enabled = False
            End If
        End If

    End Sub

    Private Function MostrarModoEdicion(ByVal _codigo As Integer) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_Cabecera_Produccion_OP(_codigo)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                GbTransaccion.Enabled = False
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    txt_numero.Text = dtCabeceraAlm.Rows(i).Item("NUMERO").ToString
                    dtpFecha.Value = dtCabeceraAlm.Rows(i).Item("FECHA").ToString
                Next
                GenerarColummnaDataTable_Productos()
                GenerarColummnaDataTable_Insumos()
                GenerarColummnaDataTable_Procesos()

                GenerarColummnaDataTable_Insumos_Puente()
                GenerarColummnaDataTable_Procesos_Puente()

                dtdetalleArticuloPrincipal_productos = clsAlmacenDetBl.get_Detalle_Produccion_OP_Productos(_codigo)
                dgvDetalle.DataSource = Nothing
                If dtdetalleArticuloPrincipal_productos.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal_productos
                    dgvDetalle.AutoResizeColumns()
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvDetalle.Columns(0).Visible = False
                    dgvDetalle.Columns(1).Visible = False
                    dgvDetalle.Columns(2).HeaderText = "Item"
                    dgvDetalle.Columns(3).Visible = False
                    dgvDetalle.Columns(4).HeaderText = "Cliente"
                    dgvDetalle.Columns(5).HeaderText = "Fecha de Entrega"
                    dgvDetalle.Columns(6).Visible = False 'HeaderText = "Precio"
                    dgvDetalle.Columns(7).HeaderText = "Vendedor"
                    dgvDetalle.Columns(8).HeaderText = "Destinatario"
                    dgvDetalle.Columns(9).HeaderText = "Urgente"
                    dgvDetalle.Columns(10).Visible = False 'HeaderText = "Saldo"
                    dgvDetalle.Columns(11).HeaderText = "Codigo"
                    dgvDetalle.Columns(12).HeaderText = "Producto"
                    dgvDetalle.Columns(13).HeaderText = "Unidad"
                    dgvDetalle.Columns(14).HeaderText = "Cantidad"
                    dgvDetalle.Columns(15).Visible = False
                    dgvDetalle.Columns(16).Visible = False

                    If Modo_consultar = True Then
                        dgvDetalle.Columns(17).Visible = False
                    End If
                End If

                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Detalle_Produccion_OP(_codigo)

                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal_Procesos = clsAlmacenDetBl.get_Detalle_Produccion_OP_Procesos(_codigo)
                

            End If
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
            Return False
        End Try
    End Function

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
    End Sub



    Private Sub dtpfechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicial.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub dtpfechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechafinal.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub Tool_Anular_Click(sender As Object, e As EventArgs) Handles Tool_Anular.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Dim TIPOTRANSACCION As String = String.Empty
        TIPOTRANSACCION = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value
        'If TipoMov = "I" And (TIPOTRANSACCION = "TD" Or TIPOTRANSACCION = "LC") Then
        '    MsgBox("No se puede anular la transaccion. Anule desde su origen.", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        If dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value.ToString = "ANULADO" Then
            MsgBox("El documento se encuentra ANULADO, no procede la anulación.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ToolStrip1.Enabled = False
        pnlprincipal.Enabled = False
    End Sub

    Private Sub dgvCabeceraAlmacen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabeceraAlmacen.CellFormatting

        If dgvCabeceraAlmacen.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Public Sub GenerarColummnaDataTable_Productos()
        Try
            dtdetalleArticuloPrincipal_productos = New DataTable
            dtdetalleArticuloPrincipal_productos.Columns.Add("Sel", Type.GetType("System.Boolean")) '0
            dtdetalleArticuloPrincipal_productos.Columns.Add("Nuevo Orden", Type.GetType("System.String")) '0
            dtdetalleArticuloPrincipal_productos.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_productos.Columns.Add("CODIGO_CLIENTE", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal_productos.Columns.Add("CLIENTE", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal_productos.Columns.Add("FECHA_ENTREGA", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal_productos.Columns.Add("CODIGO_VENDEDOR", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal_productos.Columns.Add("VENDEDOR", Type.GetType("System.String")) '5
            dtdetalleArticuloPrincipal_productos.Columns.Add("DESTINATARIO", Type.GetType("System.String")) '6
            dtdetalleArticuloPrincipal_productos.Columns.Add("URGENTE", Type.GetType("System.String")) '7
            dtdetalleArticuloPrincipal_productos.Columns.Add("OBSERVACIONES", Type.GetType("System.String")) '8
            dtdetalleArticuloPrincipal_productos.Columns.Add("CODIGO", Type.GetType("System.String")) '9
            dtdetalleArticuloPrincipal_productos.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '10
            dtdetalleArticuloPrincipal_productos.Columns.Add("UNIDAD", Type.GetType("System.String")) '11
            dtdetalleArticuloPrincipal_productos.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '12
            dtdetalleArticuloPrincipal_productos.Columns.Add("ID_REQUERIMIENTO", Type.GetType("System.String")) '13
            dtdetalleArticuloPrincipal_productos.Columns.Add("ITEM_REQUERIMIENTO", Type.GetType("System.String")) '14
            dtdetalleArticuloPrincipal_productos.Columns.Add("STOCK", Type.GetType("System.String")) '15
            dtdetalleArticuloPrincipal_productos.Columns.Add("FACTOR", Type.GetType("System.Double")) '16

            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal_productos
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle.Columns(0).HeaderText = "Sel"
            dgvDetalle.Columns(1).HeaderText = "Nuevo Orden"
            dgvDetalle.Columns(2).HeaderText = "Item"
            dgvDetalle.Columns(3).Visible = False
            dgvDetalle.Columns(4).HeaderText = "Cliente"
            dgvDetalle.Columns(5).HeaderText = "Fecha de Entrega"
            dgvDetalle.Columns(6).Visible = False 'HeaderText = "Precio"
            dgvDetalle.Columns(7).HeaderText = "Vendedor"
            dgvDetalle.Columns(8).HeaderText = "Destinatario"
            dgvDetalle.Columns(9).HeaderText = "Urgente"
            dgvDetalle.Columns(10).Visible = False 'HeaderText = "Saldo"
            dgvDetalle.Columns(11).HeaderText = "Codigo"
            dgvDetalle.Columns(12).HeaderText = "Producto"
            dgvDetalle.Columns(13).HeaderText = "Unidad"
            dgvDetalle.Columns(14).HeaderText = "Cantidad"
            dgvDetalle.Columns(15).Visible = False 'HeaderText = "Saldo"
            dgvDetalle.Columns(16).Visible = False 'HeaderText = "Saldo"
            dgvDetalle.Columns(17).HeaderText = "Stock"
            dgvDetalle.Columns(18).Visible = False 'HeaderText = "Saldo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Insumos()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal.Columns.Add("COSTO", Type.GetType("System.Double")) '4
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '5
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL", Type.GetType("System.Double")) '6
            dtdetalleArticuloPrincipal.Columns.Add("STOCK", Type.GetType("System.Double")) '7
            dtdetalleArticuloPrincipal.Columns.Add("SALDO", Type.GetType("System.Double")) '8
            dtdetalleArticuloPrincipal.Columns.Add("CONSULTA", Type.GetType("System.String")) '9

            'dgvDetalle_insumos.DataSource = Nothing
            'dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal
            'dgvDetalle_insumos.AutoResizeColumns()
            'dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgvDetalle_insumos.Columns(0).Visible = False
            'dgvDetalle_insumos.Columns(1).HeaderText = "Item"
            'dgvDetalle_insumos.Columns(2).HeaderText = "Codigo"
            'dgvDetalle_insumos.Columns(3).HeaderText = "Articulo"
            'dgvDetalle_insumos.Columns(4).HeaderText = "Unidad"
            'dgvDetalle_insumos.Columns(5).Visible = False 'HeaderText = "Precio"
            'dgvDetalle_insumos.Columns(6).HeaderText = "Cantidad"
            'dgvDetalle_insumos.Columns(7).Visible = False 'HeaderText = "Total"
            'dgvDetalle_insumos.Columns(8).Visible = False 'HeaderText = "Stock"
            'dgvDetalle_insumos.Columns(9).Visible = False 'HeaderText = "Saldo"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Insumos_Puente()
        Try
            dtdetalleArticuloPrincipal_puente = New DataTable
            dtdetalleArticuloPrincipal_puente.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_puente.Columns.Add("CODIGO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal_puente.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal_puente.Columns.Add("UNIDAD", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal_puente.Columns.Add("COSTO", Type.GetType("System.Double")) '4
            dtdetalleArticuloPrincipal_puente.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '5
            dtdetalleArticuloPrincipal_puente.Columns.Add("TOTAL", Type.GetType("System.Double")) '6
            dtdetalleArticuloPrincipal_puente.Columns.Add("STOCK", Type.GetType("System.Double")) '7
            dtdetalleArticuloPrincipal_puente.Columns.Add("SALDO", Type.GetType("System.Double")) '8
            dtdetalleArticuloPrincipal_puente.Columns.Add("CONSULTA", Type.GetType("System.String")) '9

            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal_puente
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Procesos()
        Try
            dtdetalleArticuloPrincipal_Procesos = New DataTable
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("ITEM_PRODUCTO", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("PROCESO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("MAQUINA", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("INICIO", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("FIN", Type.GetType("System.String")) '4

            'dgv_procesos.DataSource = Nothing
            'dgv_procesos.DataSource = dtdetalleArticuloPrincipal_Procesos
            'dgv_procesos.AutoResizeColumns()
            'dgv_procesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgv_procesos.Columns(0).Visible = False
            'dgv_procesos.Columns(1).HeaderText = "Item"
            'dgv_procesos.Columns(2).HeaderText = "Proceso"
            'dgv_procesos.Columns(3).HeaderText = "Maquina"
            'dgv_procesos.Columns(4).HeaderText = "Inicio"
            'dgv_procesos.Columns(5).HeaderText = "Fin"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Procesos_Puente()
        Try
            dtdetalleArticuloPrincipal_Procesos_puente = New DataTable
            dtdetalleArticuloPrincipal_Procesos_puente.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_Procesos_puente.Columns.Add("PROCESO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal_Procesos_puente.Columns.Add("MAQUINA", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal_Procesos_puente.Columns.Add("INICIO", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal_Procesos_puente.Columns.Add("FIN", Type.GetType("System.String")) '4

            dgv_procesos.DataSource = dtdetalleArticuloPrincipal_Procesos_puente
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_cod_principio_activo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_producto_producir.MouseDoubleClick
        Mostrando_Producto_Produccion()
    End Sub
    Private Sub Mostrando_Producto_Produccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "MANUFACTURA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Productos a Producir"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_producto_producir.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_prod_producir.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_unidad_prod_producir.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_cantidad_prod_producir.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txt_factor.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_principio_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_producto_producir.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Producto_Produccion()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_producto_producir.Text = String.Empty Then
                Mostrando_Producto_Produccion()
            Else
                txt_factor.Select()
            End If
        End If
    End Sub

    Private Sub txt_cantidad_prod_producir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_prod_producir.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_prod_producir_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_prod_producir.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_insumo.Focus()
        End If
    End Sub

    Private Sub txt_cod_insumo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_insumo.MouseDoubleClick
        Mostrando_Producto_Insumos()
    End Sub

    Private Sub txt_cod_insumo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_insumo.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Producto_Insumos()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_insumo.Text = String.Empty Then
                Mostrando_Producto_Insumos()
            Else
                txt_cantidad_insumo.Select()
            End If
        End If
    End Sub
    Private Sub Mostrando_Producto_Insumos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "MANUFACTURA_SP_S_ARTICULO_INSUMOS_PRODUCCION_ALIMENTOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Productos a producir"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_insumo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_insumo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_unidad_insumo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                _STOCK = 0 'frm.Data_Matriz.Rows(0).Item(3)
                _COSTO = 0 'frm.Data_Matriz.Rows(0).Item(4)
                txt_cantidad_insumo.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle_insumos.RowCount = 0 Then Exit Sub
        If dgvDetalle_insumos.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Eliminando_Insumo()

        End If
    End Sub
    Private Sub Eliminando_Insumo()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalle_insumos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_puente.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_puente.AcceptChanges()
            Next
            RehacerSecuencia_Insumo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_Insumo()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_puente.Rows
            i += 1
            dtdetalleArticuloPrincipal_puente.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_puente.EndInit()
            dtdetalleArticuloPrincipal_puente.AcceptChanges()
        Next
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso_Insumo() = False Then Exit Sub
            'If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            '    For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & txt_cod_insumo.Text.Trim & "' ")
            '        MsgBox("El codigo del Insumo elegido ya se encuentra adjuntado.", MsgBoxStyle.Exclamation, "Aviso")
            '        Exit Try
            '    Next
            'End If
            Dim row As DataRow = dtdetalleArticuloPrincipal_puente.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal_puente.Rows.Count() + 1
            row("CODIGO") = txt_cod_insumo.Text.Trim
            row("DESCRIPCION") = txt_des_insumo.Text.Trim
            row("UNIDAD") = txt_unidad_insumo.Text.Trim
            row("COSTO") = _COSTO
            row("CANTIDAD") = txt_cantidad_insumo.Text
            row("TOTAL") = _COSTO * CDbl(txt_cantidad_insumo.Text)

            row("STOCK") = _STOCK
            row("SALDO") = _STOCK - CDbl(txt_cantidad_insumo.Text)
            row("CONSULTA") = "Ver Stock"
            
            dtdetalleArticuloPrincipal_puente.Rows.Add(row)
            dtdetalleArticuloPrincipal_puente.AcceptChanges()
            Call Limpiar_GroupBox(gb_insumos)
            ConfigurarGrila()

            txt_cod_insumo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Validacion_Ingreso_Insumo() As Boolean

        If txt_cod_insumo.Text.Trim = "" Then
            MsgBox("Debe elegir un insumo.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cod_insumo.Focus()
            Return False
            Exit Function
        End If

        If txt_cantidad_insumo.Text.Trim = "" Then
            MsgBox("Debe ingresar una cantidad del insumo.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_insumo.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txt_cantidad_insumo.Text) = 0 Then
            MsgBox("Debe ingresar una cantidad diferente de cero.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_insumo.Focus()
            Return False
            Exit Function
        End If

        If txt_factor.Text = "" Then
            txt_factor.Text = "0"
        End If
        'If cbo_destinatario.SelectedIndex = -1 Then
        '    MsgBox("Debe elegir un destinatario.", MsgBoxStyle.Exclamation, "Sistemas")
        '    cbo_destinatario.Focus()
        '    Return False
        '    Exit Function
        'End If

        Return True

    End Function
    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal_puente.Rows.Count() <> 0 Then
            dgvDetalle_insumos.DataSource = Nothing
            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal_puente
            dgvDetalle_insumos.AutoResizeColumns()
            dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalle_insumos.Columns(0).HeaderText = "Item"
            dgvDetalle_insumos.Columns(1).HeaderText = "Codigo"
            dgvDetalle_insumos.Columns(2).HeaderText = "Producto"
            dgvDetalle_insumos.Columns(3).HeaderText = "Unidad"
            dgvDetalle_insumos.Columns(4).Visible = False 'HeaderText = "Costo"
            dgvDetalle_insumos.Columns(5).HeaderText = "Cantidad"
            dgvDetalle_insumos.Columns(6).Visible = False 'HeaderText = "Total"
            dgvDetalle_insumos.Columns(7).HeaderText = "Stock"
            dgvDetalle_insumos.Columns(8).Visible = False 'HeaderText = "Saldo"
            dgvDetalle_insumos.Columns("CONSULTA").HeaderText = "Consulta"

            dgvDetalle_insumos.Columns(4).DefaultCellStyle.Format = "N6"
            dgvDetalle_insumos.Columns(5).DefaultCellStyle.Format = "N4"
            dgvDetalle_insumos.Columns(6).DefaultCellStyle.Format = "N2"
            dgvDetalle_insumos.Columns(7).DefaultCellStyle.Format = "N4"
            dgvDetalle_insumos.Columns(8).DefaultCellStyle.Format = "N4"

            dgvDetalle_insumos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle_insumos.Columns("CONSULTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

    End Sub

    Private Sub ConfigurarGrila_Productos()
        If dtdetalleArticuloPrincipal_productos.Rows.Count() <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal_productos
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalle.Columns(0).HeaderText = "Sel"
            dgvDetalle.Columns(1).HeaderText = "Nuevo Orden"

            dgvDetalle.Columns(2).HeaderText = "Item"
            dgvDetalle.Columns(3).Visible = False
            dgvDetalle.Columns(4).HeaderText = "Cliente"
            dgvDetalle.Columns(5).HeaderText = "Fecha de Entrega"
            dgvDetalle.Columns(6).Visible = False 'HeaderText = "Precio"
            dgvDetalle.Columns(7).HeaderText = "Vendedor"
            dgvDetalle.Columns(8).HeaderText = "Destinatario"
            dgvDetalle.Columns(9).HeaderText = "Urgente"
            dgvDetalle.Columns(10).Visible = False 'HeaderText = "Saldo"
            dgvDetalle.Columns(11).HeaderText = "Codigo"
            dgvDetalle.Columns(12).HeaderText = "Producto"
            dgvDetalle.Columns(13).HeaderText = "Unidad"
            dgvDetalle.Columns(14).HeaderText = "Cantidad"

            dgvDetalle.Columns("STOCK").HeaderText = "Stock"
            dgvDetalle.Columns("FACTOR").HeaderText = "Factor"

            dgvDetalle.Columns("ID_REQUERIMIENTO").Visible = False
            dgvDetalle.Columns("ITEM_REQUERIMIENTO").Visible = False

            dgvDetalle.Columns(14).DefaultCellStyle.Format = "N2"
            dgvDetalle.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalle.Columns(17).DefaultCellStyle.Format = "N2"
            dgvDetalle.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            If _nuevo_edicion Then
                dgvDetalle.Columns(0).Visible = False
                dgvDetalle.Columns(1).Visible = False
            End If
            
        End If

    End Sub

    Private Sub ConfigurarGrila_Proceso()
        If dtdetalleArticuloPrincipal_Procesos_puente.Rows.Count() <> 0 Then
            dgv_procesos.DataSource = Nothing
            dgv_procesos.DataSource = dtdetalleArticuloPrincipal_Procesos_puente
            dgv_procesos.AutoResizeColumns()
            dgv_procesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgv_procesos.Columns(0).HeaderText = "Item"
            dgv_procesos.Columns(1).HeaderText = "Proceso"
            dgv_procesos.Columns(2).HeaderText = "Maquina"
            dgv_procesos.Columns(3).HeaderText = "Inicio"
            dgv_procesos.Columns(4).HeaderText = "Fin"

        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_factor.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_factor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_factor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cantidad_prod_producir.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_insumo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_insumo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_insumo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_insumo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    'Private Sub btn_agregar_insumo_Click(sender As Object, e As EventArgs) Handles btn_agregar_insumo.Click
    '    Try
    '        If txt_cod_producto_producir.Text.Trim = "" Then
    '            MsgBox("Debe elegir un producto a producir.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
    '            txt_cod_producto_producir.Focus()
    '            Exit Sub
    '        End If
    '        If CDbl(txt_cantidad_prod_producir.Text) = 0 Then
    '            MsgBox("La cantidad del producto a producir debe ser mayor a cero. Verifique!!!", MsgBoxStyle.Exclamation, "Sistemas Lusa")
    '            Exit Sub
    '        End If

    '        If txt_factor.Text.Trim = "" Then
    '            MsgBox("Debe ingresar un dato en el campo Factor.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
    '            txt_factor.Focus()
    '            Exit Sub
    '        End If

    '        If CDbl(txt_factor.Text) = 0 Then
    '            MsgBox("Debe ingresar un Factor diferente de cero.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
    '            txt_factor.Focus()
    '            Exit Sub
    '        End If

    '        If Revalorizar_Insumos() Then
    '            clsBusquedaBl = New ClsBuscar
    '            dtdetalleArticuloPrincipal = clsBusquedaBl.get_Datos_Alimentos(txt_cod_producto_producir.Text.Trim, CInt(txt_factor.Text))

    '            ConfigurarGrila()

    '            txt_cantidad_prod_producir.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero)

    '            txt_total_prod_producir.Text = Math.Round(dtdetalleArticuloPrincipal.Compute("Sum(TOTAL)", ""), 4, MidpointRounding.AwayFromZero)
    '            txt_costo_prod_producir.Text = Math.Round(CDbl(txt_total_prod_producir.Text) / (CDbl(txt_cantidad_prod_producir.Text)), 6)

    '            txt_total_prod_producir.Text = Format(Double.Parse(txt_total_prod_producir.Text), "##,##0.00")
    '            txt_cantidad_prod_producir.Text = Format(Double.Parse(txt_cantidad_prod_producir.Text), "##,##0.0000")
    '            txt_costo_prod_producir.Text = Format(Double.Parse(txt_costo_prod_producir.Text), "##,##0.000000")

    '            txt_cod_insumo.Focus()
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Function Revalorizar_Insumos() As Boolean
    '    Try
    '        Dim ide As String
    '        clsBusquedaBl_val = New ClsBuscar
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza

    '        UltimoMesRevalorizado()

    '        Me.Cursor = Cursors.WaitCursor
    '        If Busca_TipoCambio_Cero() Then
    '            If Busca_Documentos_Sin_Valorizar() Then
    '                If Busca_Saldos_Negativos() Then
    '                    If Validacion_Stock_Articulo() Then
    '                        If Revaloriza_lotes() Then
    '                            If Revaloriza_Todos() Then
    '                                ide = System.Environment.MachineName
    '                                clsBusquedaBl_val.Delete_Temp(ide)
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        Me.Cursor = Cursors.Default
    '        Return True
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Private Sub dgvDetalle_insumos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        If CDbl(dgvDetalle_insumos.Rows(e.RowIndex).Cells("SALDO").Value) < 0 Then
            dgvDetalle_insumos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDetalle_insumos.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDetalle_insumos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDetalle_insumos.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub


    'Private Function Busca_Documentos_Sin_Valorizar() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        Dim RSdocumentos As DataTable

    '        clsBusquedaBl = New ClsBuscar
    '        'dtDatosCompany = New DataTable
    '        'dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        RSdocumentos = clsBusquedaBl_val.Get_Documentos_Sin_Valorizar("V", "NI", "A", "N", "N", "N")

    '        If RSdocumentos.Rows.Count > 0 Then
    '            MsgBox("Existen " & RSdocumentos.Rows.Count & " documentos sin Valorizar.", MsgBoxStyle.Information)
    '        End If
    '        RSdocumentos = Nothing

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    'Private Function Busca_Saldos_Negativos() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        Dim RSsaldos As ADODB.Recordset
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza

    '        RSsaldos = New ADODB.Recordset
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza
    '        clsBusquedaBl = New ClsBuscar

    '        dtDatosCompany = New DataTable
    '        dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        RSsaldos = objRevaloriza.Get_Saldos_Negativos("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString)
    '        If RSsaldos.RecordCount > 0 Then
    '            MsgBox("Existen " & RSsaldos.RecordCount & " artículos con saldos negativos", MsgBoxStyle.Information)
    '        End If
    '        RSsaldos.Close()
    '        RSsaldos = Nothing
    '        objRevaloriza = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    'Private Function Validacion_Stock_Articulo() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
    '        Dim INTnroreg As Integer
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza
    '        clsBusquedaBl = New ClsBuscar

    '        dtDatosCompany = New DataTable
    '        dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        INTnroreg = objRevaloriza.Validacion_StkArt("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
    '                    "N", "N", "N")
    '        objRevaloriza = Nothing

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    'Private Sub UltimoMesRevalorizado()
    '    Try
    '        clsBusquedaBl = New ClsBuscar
    '        dtUltimoMes = New DataTable
    '        dtUltimoMes = clsBusquedaBl.Get_MesSinRevalorizar()
    '        If dtUltimoMes.Rows.Count() <> 0 Then
    '            _Fecha_Inicio = dtUltimoMes.Rows(0).Item(0).ToString()
    '            If _Fecha_Inicio > Date.Now() Then
    '                _Fecha_Fin = _Fecha_Inicio.Date
    '            Else
    '                _Fecha_Fin = Date.Now
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Function Revaloriza_lotes() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        clsBusquedaBl = New ClsBuscar
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza
    '        dtDatosCompany = New DataTable
    '        dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        Call objRevaloriza.Revaloriza_Lotes("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
    '                    _Fecha_Inicio.Date.ToString("dd/MM/yyyy"), _Fecha_Fin.Date.ToString("dd/MM/yyyy"))
    '        objRevaloriza = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    'Private Function Busca_TipoCambio_Cero() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        Dim RStcambio As ADODB.Recordset
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza

    '        clsBusquedaBl = New ClsBuscar
    '        RStcambio = New ADODB.Recordset
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza
    '        dtRevalorizaLotes = New DataTable

    '        'If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
    '        '    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '    dtpfechaInicio.Focus()
    '        '    estado = False
    '        '    Exit Try
    '        'End If
    '        'AÑO 
    '        'Dim fechaInicial As Date = dtpfechaInicio.Value
    '        'Dim FechaFinal As Date = dtpfechaFin.Value
    '        'Nombre de la Pc
    '        dtDatosCompany = New DataTable
    '        dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        RStcambio = objRevaloriza.Get_Documentos_TCambio_Cero("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, "V", "I")
    '        If RStcambio.RecordCount > 0 Then
    '            MessageBox.Show("Existen " & RStcambio.RecordCount & " documentos sin tipo de cambio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '        RStcambio.Close()
    '        RStcambio = Nothing
    '        objRevaloriza = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    'Private Function Revaloriza_Todos() As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        clsBusquedaBl = New ClsBuscar
    '        Dim objRevaloriza As DllInventario.ClsProcesoRevaloriza
    '        objRevaloriza = New DllInventario.ClsProcesoRevaloriza
    '        dtDatosCompany = New DataTable
    '        dtDatosCompany = clsBusquedaBl.Obtener_Datos_Empresa()

    '        Call objRevaloriza.Revaloriza_Total("NovaQ", "NovaQ", dtDatosCompany.Rows(0).Item("ID").ToString, _
    '                       _Fecha_Inicio.Date.ToString("dd/MM/yyyy"), _Fecha_Fin.Date.ToString("dd/MM/yyyy"))
    '        objRevaloriza = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        estado = False
    '    End Try
    '    Return estado
    'End Function

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        If MessageBox.Show("Se va a APROBAR la Orden de Producción" & vbCrLf & "¿Desea continuar?", "Aprobar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Generar_Descarga_Insumos() = True Then
                MostrandoDatosGeneralesCabeceraAlmacen()
                btnCancelar_Click_1(sender, e)
            End If
        End If
    End Sub

    Private Function Generar_Descarga_Insumos() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.PRODUCCION_OP_LINE)
            Dim alm_cabBE As New ClsEntidades.PRODUCCION_OP
            'Dim alm_detBE As ClsEntidades.PRODUCCION_OP_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            With alm_cabBE
                .ID = txt_numero.Text
            End With

            'PARTE DE LA PRODUCCION DE OP
            '--PARTE DE ALMACEN
            Dim ls_det_alm_almacen As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE_almacen As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE_almacen As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL_almacen As New ClsOperaciones.WAREHOUSE_TRANS

            'If dtdetalleArticuloPrincipal.Rows.Count() > 0 Then
            '    clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
            '    clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen("01", "S")
            '    'la parte de almacen
            '    With alm_cabBE_almacen
            '        .WAREHOUSE_ID = "01"
            '        Ref_idalamacen = .WAREHOUSE_ID
            '        .DOCUMENT_ID = "NS"
            '        Ref_documentid = .DOCUMENT_ID
            '        .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
            '        Ref_numerodocument = .NUMBER_DOCUMENT
            '        .DATE_DOCUMENT = CDate(dtpFecha.Value).ToShortDateString
            '        .TYPE_TRANS = "S"
            '        Ref_tipo = .TYPE_TRANS
            '        .TRANS_ID = "SP"
            '        Ref_trasactiontype = .TRANS_ID
            '        .DOC_ID_REF = "OP"
            '        .NUM_ID_REF = txt_numero.Text
            '        .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
            '        .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '        .VAT_REGISTRATION = "" 'Ruc..
            '        .ADDR_DLV = ""  'Direccion ..
            '        .VENDOR_ID = ""
            '        .VENDOR_NAME = ""
            '        .CUSTOMER_ID = ""
            '        .CUSTOMER_NAME = ""
            '        .SALES_TERM = ""
            '        .CURRENCY_TYPE = "MN"
            '        .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
            '        .STATUS_GUIA = "V"
            '        .AMOUNT = 0
            '        .COMMENT = ""
            '        .TYPE_GUIA = "SP"
            '        .WAREHOUSE_REF = ""
            '        .UPDATE_DATE = Date.Now()
            '        .NUM_ORDER_MANUFACT = ""
            '        .NUMBER_PURCHASE = ""

            '    End With
            'End If
            
            'For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
            '    alm_detBE_almacen = New ClsEntidades.WAREHOUSE_TRANS_LINE
            '    With alm_detBE_almacen
            '        .WAREHOUSE_ID = "01"
            '        .DOCUMENT_ID = "NS"
            '        .NUMBER_DOCUMENT = alm_cabBE_almacen.NUMBER_DOCUMENT
            '        .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
            '        .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
            '        .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
            '        .QTY_DLV = .QTY
            '        .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
            '        .QTY_INVOICED = 0
            '        .AMOUNT_SALES = 0
            '        .AVERAGE_COST = CDbl(dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString)
            '        .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
            '        .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
            '        .NUMBER_LOT = ""
            '        .WAREHOUSE_REF = ""
            '        .ACCOUNT = _ACCOUNT
            '        .NUM_PROTOCOLOS = ""
            '        .OPT_ENTREGA = ""
            '        .QT_BULTOS = 0
            '        .PROCEDENCIA = ""
            '        .PAIS_ORIGEN = ""
            '        .CURRENCY_ID = "MN"
            '        .STATUS_VALUE = 0
            '        .NUMBER_ANALIS = ""
            '    End With
            '    ls_det_alm_almacen.Add(alm_detBE_almacen)
            'Next
            '--PARTE DE ALMACEN

            If almacenBL.Guardar_Descarga_OP(alm_cabBE, alm_cabBE_almacen, ls_det_alm_almacen) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                msj = "Orden de Producción aprobado correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                MsgBox(msj, MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodCliente.MouseDoubleClick
        Ayuda_Clientes()
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes()
        If e.KeyCode = Keys.Enter Then
            If txtCodCliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                txt_cod_vendedor.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_ORDER_CLIENTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

            txtComentarios.Select()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_vendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vendedor.MouseDoubleClick
        Ayuda_Vendedor2()
    End Sub

    Private Sub txt_cod_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vendedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor2()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_vendedor.Text = "" Then
                Ayuda_Vendedor2()
            Else
                cbo_destinatario.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Vendedor2(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Vendedor"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cod_vendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    txt_des_vendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_procesos_Click(sender As Object, e As EventArgs) Handles btn_add_procesos.Click
        Try
            If Validacion_Ingreso_Proceso() = False Then Exit Sub
            
            Dim row As DataRow = dtdetalleArticuloPrincipal_Procesos_puente.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal_Procesos_puente.Rows.Count() + 1
            row("PROCESO") = txt_proceso.Text.Trim
            row("MAQUINA") = txt_maquina.Text.Trim
            row("INICIO") = dtp_inicio.Value.ToLongTimeString
            row("FIN") = dtp_fin.Value.ToLongTimeString

            dtdetalleArticuloPrincipal_Procesos_puente.Rows.Add(row)
            dtdetalleArticuloPrincipal_Procesos_puente.AcceptChanges()
            Call Limpiar_GroupBox(gb_procesos)
            ConfigurarGrila_Proceso()

            txt_proceso.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Validacion_Ingreso_Proceso() As Boolean

        If txt_proceso.Text.Trim = "" Then
            MsgBox("Debe indicar un Proceso.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_proceso.Focus()
            Return False
            Exit Function
        End If

        If txt_maquina.Text.Trim = "" Then
            MsgBox("Debe indicar una maquina.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_maquina.Focus()
            Return False
            Exit Function
        End If


        Return True

    End Function

    Private Sub btn_del_procesos_Click(sender As Object, e As EventArgs) Handles btn_del_procesos.Click
        If dgv_procesos.RowCount = 0 Then Exit Sub
        If dgv_procesos.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Eliminando_Proceso()

        End If
    End Sub

    Private Sub Eliminando_Proceso()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_procesos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Procesos_puente.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Procesos_puente.AcceptChanges()
            Next
            RehacerSecuencia_Proceso()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_Proceso()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Procesos_puente.Rows
            i += 1
            dtdetalleArticuloPrincipal_Procesos_puente.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Procesos_puente.EndInit()
            dtdetalleArticuloPrincipal_Procesos_puente.AcceptChanges()
        Next
    End Sub

    Private Sub txt_proceso_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proceso.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Proceso()
        If e.KeyCode = Keys.Enter Then
            If txt_proceso.Text = String.Empty Then
                Ayuda_Proceso()
            Else
                txt_maquina.Focus()
            End If
        End If
        
    End Sub

    Private Sub txt_maquina_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_maquina.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Maquinas()
        If e.KeyCode = Keys.Enter Then
            If txt_maquina.Text = String.Empty Then
                Ayuda_Maquinas()
            Else
                btn_add_procesos.Focus()
            End If
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            _Flag_edicion = False
            
            blank()

            gb_productos.Visible = False
            gbOpciones.Visible = False
            ToolStrip1.Enabled = False
            GbTransaccion.Enabled = False

            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                For j As Integer = 0 To dgvDetalle.Columns.Count - 1
                    dgvDetalle.Rows(i).Cells(j).ReadOnly = True
                Next
            Next
            _nuevo_edicion = True
            dgvDetalle.Columns(0).Visible = False
            dgvDetalle.Columns(1).Visible = False

            txtCodCliente.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub blank()
        Call Limpiar_GroupBox(GroupBox1)
        Call Limpiar_GroupBox(gb_producto_producir)
        Call Limpiar_GroupBox(gb_insumos)
        Call Limpiar_GroupBox(gb_procesos)
        dtp_fecha_entrega.Value = Date.Today
        txtComentarios.Text = ""
        cbo_destinatario.SelectedIndex = -1
        chk_urgente.Checked = False
        dtp_inicio.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        dtp_fin.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        TabControl1.SelectedIndex = 0
        GenerarColummnaDataTable_Insumos_Puente()
        GenerarColummnaDataTable_Procesos_Puente()
    End Sub

    Private Sub cbo_destinatario_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_destinatario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtComentarios.Focus()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ConfigurarGrila_Productos()
        gb_productos.Visible = True
        gbOpciones.Visible = True
        ToolStrip1.Enabled = True
        GbTransaccion.Enabled = True

    End Sub
    Function ValidacionesGeneralesArticulo() As Boolean
        If txtCodCliente.Text = "" Then
            MessageBox.Show("Debe elegir un Cliente.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
            Exit Function
        End If

        If txt_cod_producto_producir.Text.Trim = "" Then
            MsgBox("Debe elegir un codigo para Producir.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cod_producto_producir.Focus()
            Return False
            Exit Function
        End If

        If txt_cantidad_prod_producir.Text.Trim = "" Then
            MsgBox("Debe ingresar una cantidad a producir.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_prod_producir.Focus()
            Return False
            Exit Function
        End If

        If CDbl(txt_cantidad_prod_producir.Text) = 0 Then
            MsgBox("Debe ingresar una cantidad diferente de cero.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_cantidad_prod_producir.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidacionesGeneralesArticulo() = False Then Exit Sub
            If _Flag_edicion = False Then
                Dim _item As String = ""
                Dim row As DataRow = dtdetalleArticuloPrincipal_productos.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal_productos.Rows.Count() + 1
                _item = row("ITEM")
                row("CODIGO_CLIENTE") = txtCodCliente.Text
                row("CLIENTE") = txtRazonSocial.Text
                row("FECHA_ENTREGA") = dtp_fecha_entrega.Value.ToString("dd/MM/yyyy")
                row("CODIGO_VENDEDOR") = txt_cod_vendedor.Text
                row("VENDEDOR") = txt_des_vendedor.Text
                row("DESTINATARIO") = cbo_destinatario.Text
                If chk_urgente.Checked Then
                    row("URGENTE") = "SI"
                Else
                    row("URGENTE") = ""
                End If
                row("OBSERVACIONES") = txtComentarios.Text
                row("CODIGO") = txt_cod_producto_producir.Text
                row("DESCRIPCION") = txt_des_prod_producir.Text
                row("UNIDAD") = txt_unidad_prod_producir.Text
                row("CANTIDAD") = txt_cantidad_prod_producir.Text
                row("FACTOR") = IIf(txt_factor.Text = "", 0, CDbl(txt_factor.Text))

                dtdetalleArticuloPrincipal_productos.Rows.Add(row)
                dtdetalleArticuloPrincipal_productos.AcceptChanges()

                For Each row2 As DataRow In dtdetalleArticuloPrincipal_puente.Rows
                    Dim rowx As DataRow = dtdetalleArticuloPrincipal.NewRow
                    rowx("ITEM_PRODUCTO") = _item
                    rowx("ITEM") = row2("ITEM")
                    rowx("CODIGO") = row2("CODIGO")
                    rowx("DESCRIPCION") = row2("DESCRIPCION")
                    rowx("UNIDAD") = row2("UNIDAD")
                    rowx("COSTO") = 0
                    rowx("CANTIDAD") = row2("CANTIDAD")
                    rowx("TOTAL") = 0
                    rowx("STOCK") = row2("STOCK")
                    rowx("SALDO") = 0
                    rowx("CONSULTA") = row2("CONSULTA")
                    dtdetalleArticuloPrincipal.Rows.Add(rowx)
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For Each row2 As DataRow In dtdetalleArticuloPrincipal_Procesos_puente.Rows
                    Dim rowx As DataRow = dtdetalleArticuloPrincipal_Procesos.NewRow
                    rowx("ITEM_PRODUCTO") = _item
                    rowx("ITEM") = row2("ITEM")
                    rowx("PROCESO") = row2("PROCESO")
                    rowx("MAQUINA") = row2("MAQUINA")
                    rowx("INICIO") = row2("INICIO")
                    rowx("FIN") = row2("FIN")
                    dtdetalleArticuloPrincipal_Procesos.Rows.Add(rowx)
                    dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
                Next

                blank()
                txtCodCliente.Select()
            Else
                For Each row As DataRow In dtdetalleArticuloPrincipal_productos.Select("ITEM=" & _Codigo_Ini)
                    dtdetalleArticuloPrincipal_productos.BeginInit()
                    row("CODIGO_CLIENTE") = txtCodCliente.Text
                    row("CLIENTE") = txtRazonSocial.Text
                    row("FECHA_ENTREGA") = dtp_fecha_entrega.Value.ToString("dd/MM/yyyy")
                    row("CODIGO_VENDEDOR") = txt_cod_vendedor.Text
                    row("VENDEDOR") = txt_des_vendedor.Text
                    row("DESTINATARIO") = cbo_destinatario.Text
                    If chk_urgente.Checked Then
                        row("URGENTE") = "SI"
                    Else
                        row("URGENTE") = ""
                    End If
                    row("OBSERVACIONES") = txtComentarios.Text
                    row("CODIGO") = txt_cod_producto_producir.Text
                    row("DESCRIPCION") = txt_des_prod_producir.Text
                    row("UNIDAD") = txt_unidad_prod_producir.Text
                    row("CANTIDAD") = txt_cantidad_prod_producir.Text
                    row("FACTOR") = IIf(txt_factor.Text = "", 0, CDbl(txt_factor.Text))

                    dtdetalleArticuloPrincipal_productos.EndInit()
                    dtdetalleArticuloPrincipal_productos.AcceptChanges()
                Next

                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                    item.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For Each row2 As DataRow In dtdetalleArticuloPrincipal_puente.Rows
                    Dim rowx As DataRow = dtdetalleArticuloPrincipal.NewRow
                    rowx("ITEM_PRODUCTO") = _Codigo_Ini
                    rowx("ITEM") = row2("ITEM")
                    rowx("CODIGO") = row2("CODIGO")
                    rowx("DESCRIPCION") = row2("DESCRIPCION")
                    rowx("UNIDAD") = row2("UNIDAD")
                    rowx("COSTO") = 0
                    rowx("CANTIDAD") = row2("CANTIDAD")
                    rowx("TOTAL") = 0
                    rowx("STOCK") = row2("STOCK")
                    rowx("SALDO") = 0
                    rowx("CONSULTA") = row2("CONSULTA")
                    dtdetalleArticuloPrincipal.Rows.Add(rowx)
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For Each item As DataRow In dtdetalleArticuloPrincipal_Procesos.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                    item.Delete()
                    dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
                Next

                For Each row2 As DataRow In dtdetalleArticuloPrincipal_Procesos_puente.Rows
                    Dim rowx As DataRow = dtdetalleArticuloPrincipal_Procesos.NewRow
                    rowx("ITEM_PRODUCTO") = _Codigo_Ini
                    rowx("ITEM") = row2("ITEM")
                    rowx("PROCESO") = row2("PROCESO")
                    rowx("MAQUINA") = row2("MAQUINA")
                    rowx("INICIO") = row2("INICIO")
                    rowx("FIN") = row2("FIN")
                    dtdetalleArticuloPrincipal_Procesos.Rows.Add(rowx)
                    dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
                Next

                btn_cancel.PerformClick()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

            _Flag_edicion = True
            _Codigo_Ini = String.Empty
            _Codigo_Ini = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value

            blank()
            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                For j As Integer = 0 To dgvDetalle.Columns.Count - 1
                    dgvDetalle.Rows(i).Cells(j).ReadOnly = True
                Next
            Next

            _nuevo_edicion = True

            For Each row As DataRow In dtdetalleArticuloPrincipal_productos.Select("ITEM=" & _Codigo_Ini)
                txt_cod_producto_producir.Text = row("CODIGO")
                txt_des_prod_producir.Text = row("DESCRIPCION")
                txt_unidad_prod_producir.Text = row("UNIDAD")
                txt_cantidad_prod_producir.Text = row("CANTIDAD")
                txt_factor.Text = row("FACTOR")

                txtCodCliente.Text = row("CODIGO_CLIENTE")
                txtRazonSocial.Text = row("CLIENTE")
                dtp_fecha_entrega.Value = row("FECHA_ENTREGA")
                txt_cod_vendedor.Text = row("CODIGO_VENDEDOR")
                txt_des_vendedor.Text = row("VENDEDOR")
                cbo_destinatario.Text = row("DESTINATARIO")
                If row("URGENTE") = "SI" Then
                    chk_urgente.Checked = True
                Else
                    chk_urgente.Checked = False
                End If
                txtComentarios.Text = row("OBSERVACIONES")
            Next

            For Each row2 As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                Dim rowx As DataRow = dtdetalleArticuloPrincipal_puente.NewRow
                rowx("ITEM") = row2("ITEM")
                rowx("CODIGO") = row2("CODIGO")
                rowx("DESCRIPCION") = row2("DESCRIPCION")
                rowx("UNIDAD") = row2("UNIDAD")
                rowx("COSTO") = 0
                rowx("CANTIDAD") = row2("CANTIDAD")
                rowx("TOTAL") = 0
                rowx("STOCK") = row2("STOCK")
                rowx("SALDO") = 0
                rowx("CONSULTA") = row2("CONSULTA")
                dtdetalleArticuloPrincipal_puente.Rows.Add(rowx)
                dtdetalleArticuloPrincipal_puente.AcceptChanges()
            Next

            For Each row2 As DataRow In dtdetalleArticuloPrincipal_Procesos.Select("ITEM_PRODUCTO=" & _Codigo_Ini)
                Dim rowx As DataRow = dtdetalleArticuloPrincipal_Procesos_puente.NewRow
                rowx("ITEM") = row2("ITEM")
                rowx("PROCESO") = row2("PROCESO")
                rowx("MAQUINA") = row2("MAQUINA")
                rowx("INICIO") = row2("INICIO")
                rowx("FIN") = row2("FIN")
                dtdetalleArticuloPrincipal_Procesos_puente.Rows.Add(rowx)
                dtdetalleArticuloPrincipal_Procesos_puente.AcceptChanges()
            Next

            gb_productos.Visible = False
            gbOpciones.Visible = False
            ToolStrip1.Enabled = False
            GbTransaccion.Enabled = False
            ConfigurarGrila()
            ConfigurarGrila_Proceso()

            txtCodCliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal_productos.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal_productos.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal_productos.EndInit()
                    dtdetalleArticuloPrincipal_productos.AcceptChanges()
                Next

                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM_PRODUCTO=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                For Each item As DataRow In dtdetalleArticuloPrincipal_Procesos.Select("ITEM_PRODUCTO=" & Codigo)
                    dtdetalleArticuloPrincipal_Procesos.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal_Procesos.EndInit()
                    dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        'dtdetalleArticuloPrincipal_productos.Rows.Clear()
        Ayuda_OrdenesCompra()
        btnAgregar.Select()
    End Sub

    Private Sub Ayuda_OrdenesCompra()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim ID_COMPRA As String = ""
            sql = "COMPRA_SP_S_REQUERIMIENTO_PRODUCCION_OP"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE REQUERIMIENTOS DE ORDEN DE PRODUCCION"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                ID_COMPRA = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
            If ID_COMPRA = "" Then Exit Sub
            'DETALLES
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            Dim dt_req_op As DataTable
            dt_req_op = New DataTable

            dt_req_op = clsAlmacenCabBl.get_Detalle_Produccion_OP_Productos_Requerimientos(ID_COMPRA)
            If dt_req_op.Rows.Count() <> 0 Then
                _contador_despachos = 0
                _nuevo_edicion = False
                For i As Integer = 0 To dt_req_op.Rows.Count - 1
                    Dim row As DataRow = dtdetalleArticuloPrincipal_productos.NewRow
                    row("Sel") = dt_req_op.Rows(i).Item("Sel").ToString
                    row("Nuevo Orden") = dt_req_op.Rows(i).Item("Nuevo Orden").ToString
                    row("ITEM") = dtdetalleArticuloPrincipal_productos.Rows.Count() + 1
                    row("CODIGO_CLIENTE") = dt_req_op.Rows(i).Item("CUSTOMER_ID").ToString
                    row("CLIENTE") = dt_req_op.Rows(i).Item("CLIENTE").ToString
                    row("FECHA_ENTREGA") = dt_req_op.Rows(i).Item("FECHA_ENTREGA").ToString
                    row("CODIGO_VENDEDOR") = dt_req_op.Rows(i).Item("VENDEDOR").ToString
                    row("VENDEDOR") = dt_req_op.Rows(i).Item("NOMBRE_VENDEDOR").ToString
                    row("DESTINATARIO") = dt_req_op.Rows(i).Item("DESTINATARIO").ToString
                    If dt_req_op.Rows(i).Item("URGENTE").ToString = "SI" Then
                        row("URGENTE") = "SI"
                    Else
                        row("URGENTE") = ""
                    End If
                    row("OBSERVACIONES") = dt_req_op.Rows(i).Item("OBSERVACIONES").ToString
                    row("CODIGO") = dt_req_op.Rows(i).Item("CODIGO").ToString
                    row("DESCRIPCION") = dt_req_op.Rows(i).Item("DESCRIPTION").ToString
                    row("UNIDAD") = dt_req_op.Rows(i).Item("UNIT_OF_MEASUREMENT").ToString
                    row("CANTIDAD") = dt_req_op.Rows(i).Item("CANTIDAD_OFI").ToString
                    row("ID_REQUERIMIENTO") = dt_req_op.Rows(i).Item("ID").ToString
                    row("ITEM_REQUERIMIENTO") = dt_req_op.Rows(i).Item("ITEM").ToString
                    row("STOCK") = dt_req_op.Rows(i).Item("STOCK").ToString
                    row("FACTOR") = 0

                    dtdetalleArticuloPrincipal_productos.Rows.Add(row)
                    dtdetalleArticuloPrincipal_productos.AcceptChanges()
                Next
                
                ConfigurarGrila_Productos()
                For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                    For j As Integer = 1 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Rows(i).Cells(0).ReadOnly = False
                        dgvDetalle.Rows(i).Cells(j).ReadOnly = True
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        
        imprimirOp_II(CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value), CInt(dgvDetalle.CurrentRow.Cells("ITEM").Value))
    End Sub

    Private Sub btn_formula_Click(sender As Object, e As EventArgs) Handles btn_formula.Click
        Try
            If txt_factor.Text = "" Then txt_factor.Text = "0"
            If txt_cantidad_prod_producir.Text = "" Then txt_cantidad_prod_producir.Text = "0"

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "MANUFACTURA_SP_S_FORMULATION"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Formulas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
                GenerarColummnaDataTable_Insumos_Puente()
                dtdetalleArticuloPrincipal_puente = clsAlmacenDetBl.get_Detalle_Formula(frm.Data_Matriz.Rows(0).Item(0).ToString,
                                                                                        CDbl(txt_factor.Text), CDbl(txt_cantidad_prod_producir.Text))
                ConfigurarGrila()

                GenerarColummnaDataTable_Procesos_Puente()
                dtdetalleArticuloPrincipal_Procesos_puente = clsAlmacenDetBl.get_Detalle_Formula_Procesos(frm.Data_Matriz.Rows(0).Item(0).ToString,
                                                                                        CDbl(txt_factor.Text), CDbl(txt_cantidad_prod_producir.Text))
                ConfigurarGrila_Proceso()

                txt_cod_insumo.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_factor_Leave(sender As Object, e As EventArgs) Handles txt_factor.Leave
        If txt_factor.Text = "" Then
            txt_factor.Text = "0"
        End If
    End Sub

    Private Sub txt_proceso_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_proceso.MouseDoubleClick
        Ayuda_Proceso()
    End Sub
    Private Sub Ayuda_Proceso()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_PROCESOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Procesos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_proceso.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_maquina_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_maquina.MouseDoubleClick
        Ayuda_Maquinas()
    End Sub

    Private Sub Ayuda_Maquinas()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MAQUINAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Maquinas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_maquina.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellValueChanged
        If e.ColumnIndex = 0 Then
            If dgvDetalle.CurrentRow.Cells(0).Value = True Then
                dgvDetalle.CurrentRow.Cells(1).Value = _contador_despachos + 1
                _contador_despachos = _contador_despachos + 1
            Else
                dgvDetalle.CurrentRow.Cells(1).Value = ""
                _contador_despachos = _contador_despachos - 1
                '_contador_despachos = 0
            End If

        End If
    End Sub

    Private Sub dgvDetalle_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDetalle.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvDetalle.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub AplicarNuevoOrdenDeItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicarNuevoOrdenDeItemsToolStripMenuItem.Click
        dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle.RowCount() = 0 Then
            MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim estado As Boolean = True
            For Each row As DataGridViewRow In dgvDetalle.Rows
                If row.Cells(0).Value = False Then
                    estado = False
                    Exit For
                End If
            Next
            If estado = False Then
                MessageBox.Show("Debe seleccionar todos los items!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dgvDetalle.Focus()
                Exit Sub
            End If
        End If
        dgvDetalle.Refresh()

        For Each item As DataRow In dtdetalleArticuloPrincipal_productos.Rows
            dtdetalleArticuloPrincipal_productos.BeginInit()
            item("ITEM") = item("Nuevo Orden")
            item("Nuevo Orden") = ""
            item("Sel") = False
            dtdetalleArticuloPrincipal_productos.EndInit()
            dtdetalleArticuloPrincipal_productos.AcceptChanges()
        Next

        _contador_despachos = 0
    End Sub

    Private Sub btn_elegir_op_Click(sender As Object, e As EventArgs) Handles btn_elegir_op.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim ID_COMPRA As String = ""
            sql = "COMPRA_SP_S_PRODUCCION_OP"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE ORDENES DE PRODUCCION"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                ID_COMPRA = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
            If ID_COMPRA = "" Then Me.Cursor = Cursors.Default : Exit Sub


            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_Cabecera_Produccion_OP(ID_COMPRA)
            If dtCabeceraAlm.Rows.Count() <> 0 Then

                GenerarColummnaDataTable_Productos()
                GenerarColummnaDataTable_Insumos()
                GenerarColummnaDataTable_Procesos()

                GenerarColummnaDataTable_Insumos_Puente()
                GenerarColummnaDataTable_Procesos_Puente()

                dtdetalleArticuloPrincipal_productos = clsAlmacenDetBl.get_Detalle_Produccion_OP_Productos(ID_COMPRA)
                dgvDetalle.DataSource = Nothing
                If dtdetalleArticuloPrincipal_productos.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal_productos
                    dgvDetalle.AutoResizeColumns()
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvDetalle.Columns(0).Visible = False
                    dgvDetalle.Columns(1).Visible = False
                    dgvDetalle.Columns(2).HeaderText = "Item"
                    dgvDetalle.Columns(3).Visible = False
                    dgvDetalle.Columns(4).HeaderText = "Cliente"
                    dgvDetalle.Columns(5).HeaderText = "Fecha de Entrega"
                    dgvDetalle.Columns(6).Visible = False 'HeaderText = "Precio"
                    dgvDetalle.Columns(7).HeaderText = "Vendedor"
                    dgvDetalle.Columns(8).HeaderText = "Destinatario"
                    dgvDetalle.Columns(9).HeaderText = "Urgente"
                    dgvDetalle.Columns(10).Visible = False 'HeaderText = "Saldo"
                    dgvDetalle.Columns(11).HeaderText = "Codigo"
                    dgvDetalle.Columns(12).HeaderText = "Producto"
                    dgvDetalle.Columns(13).HeaderText = "Unidad"
                    dgvDetalle.Columns(14).HeaderText = "Cantidad"
                    dgvDetalle.Columns(15).Visible = False
                    dgvDetalle.Columns(16).Visible = False

                    If Modo_consultar = True Then
                        dgvDetalle.Columns(17).Visible = False
                    End If
                End If

                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Detalle_Produccion_OP(ID_COMPRA)

                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal_Procesos = clsAlmacenDetBl.get_Detalle_Produccion_OP_Procesos(ID_COMPRA)


            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDetalle_insumos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle_insumos.CellClick
        If dgvDetalle_insumos.RowCount() = 0 Then Exit Sub
        If dgvDetalle_insumos.CurrentRow Is Nothing Then Exit Sub

        If e.ColumnIndex = 9 Then '
            Try
                Dim frm As New Frm_Consulta_Stock
                frm._codigo_producto = dgvDetalle_insumos.CurrentRow.Cells("CODIGO").Value
                frm.ShowDialog()

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub dgvCabeceraAlmacen_CellClick(sender As Object, e As DataGridViewCellEventArgs)
       
    End Sub

    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" Then
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                Else
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCabeceraAlmacen_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabeceraAlmacen.CellClick
        If dgvCabeceraAlmacen.RowCount() = 0 Then Exit Sub
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub

        If e.ColumnIndex = 10 Then '
            Try
                reporteBL = New ClsBuscar
                dtImprimir = New DataTable
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = reporteBL.Ejecutar_Lista_Dispensacion_x_OP(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value)
                If dtImprimir.Rows.Count() <> 0 Then
                    For i As Integer = 0 To dtImprimir.Rows.Count - 1
                        Ref_idalamacen = dtImprimir.Rows(i).Item("WAREHOUSE_ID").ToString
                        Ref_documentid = dtImprimir.Rows(i).Item("DOCUMENT_ID").ToString
                        Ref_numerodocument = dtImprimir.Rows(i).Item("NUMBER_DOCUMENT").ToString

                        imprimirAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
                    Next
                    Me.Cursor = Cursors.Default
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class