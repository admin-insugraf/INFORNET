Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports DllInventario

Public Class Frm_Requerimiento_OP
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

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_Procesos As DataTable
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
    Dim _id_requerimiento As Integer

    Private Sub Frm_Requerimiento_OP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            dtData = clsBusquedaBl.get_DatosGenerales_Requerimiento_Produccion_Op(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
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
                dgvCabeceraAlmacen.Columns("Estado").HeaderText = "Estado"
                dgvCabeceraAlmacen.Columns("CLIENTE").HeaderText = "Cliente"

                dgvCabeceraAlmacen.Columns("NUMERO_DOC").Width = 50
                dgvCabeceraAlmacen.Columns("FECHA_DOC").Width = 70
                dgvCabeceraAlmacen.Columns("COD_PRODUCTO").Width = 100
                dgvCabeceraAlmacen.Columns("PRODUCTO").Width = 200
                dgvCabeceraAlmacen.Columns("UNIDAD").Width = 50
                dgvCabeceraAlmacen.Columns("CANTIDAD").Width = 100
                dgvCabeceraAlmacen.Columns("Estado").Width = 100
                dgvCabeceraAlmacen.Columns("CLIENTE").Width = 250

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
            'If Modo_consultar = True Then
            '    btnGrabar.Enabled = False
            '    btnAprobar.Visible = True
            'Else
            '    btnGrabar.Enabled = True
            '    btnAprobar.Visible = False
            'End If
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
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
            Tool_Anular.Enabled = True
        End If
    End Sub

    Private Sub Nuevo()
        Try
            pnlprincipal.Visible = False
            GbTransaccion.Enabled = True
            Modo_consultar = False
            Call Limpiar_GroupBox(GroupBox1)
            Call Limpiar_GroupBox(gb_producto_producir)
            Call Limpiar_GroupBox(gb_insumos)
            dtpFecha.Value = Date.Today
            dtp_fecha_entrega.Value = Date.Today
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Procesos()
            txt_numero.Text = ""
            txtComentarios.Text = ""
            cbo_destinatario.SelectedIndex = -1
            _id_requerimiento = 0
            chk_urgente.Checked = False
            txtCodCliente.Focus()
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
            dtImprimir_OP = reporteBL.Get_Imprimir_Requerimiento_Orden_produccion(_Codigo)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_requerimiento_op.rpt", dtImprimir_OP, "", "", _
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
        If MessageBox.Show("Se va a ANULAR el registro seleccionado" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarDocumentosAlmacen(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value)
        End If
    End Sub

    Private Sub EliminarDocumentosAlmacen(ByVal opcion_ As Integer)
        Try
            Dim Usuario As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

            Me.Cursor = Cursors.WaitCursor
            If almacenBL.Eliminar_Requerimiento_Produccion_OP(opcion_) Then
                MsgBox("Requerimiento de Orden de Producción anulado correctamente.", MsgBoxStyle.Information)
                MostrandoDatosGeneralesCabeceraAlmacen()
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click_1(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count = 0 Then Exit Sub

        'For Each row As DataRow In dtdetalleArticuloPrincipal.Select("SALDO<0", "")
        '    MessageBox.Show("El stock es insuficiente para realizar la Producción. Verifique!!!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'Next

        If txtCodCliente.Text = "" Then
            MessageBox.Show("Debe elegir un Cliente.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'If txt_cod_producto_producir.Text.Trim = "" Then
        '    MsgBox("Debe elegir un codigo para Producir.", MsgBoxStyle.Exclamation, "Sistemas")
        '    txt_cod_producto_producir.Focus()
        '    Exit Sub
        'End If

        'If txt_cantidad_prod_producir.Text.Trim = "" Then
        '    MsgBox("Debe ingresar una cantidad a producir.", MsgBoxStyle.Exclamation, "Sistemas")
        '    txt_cantidad_prod_producir.Focus()
        '    Exit Sub
        'End If

        'If CDbl(txt_cantidad_prod_producir.Text) = 0 Then
        '    MsgBox("Debe ingresar una cantidad diferente de cero.", MsgBoxStyle.Exclamation, "Sistemas")
        '    txt_cantidad_prod_producir.Focus()
        '    Exit Sub
        'End If

        If MessageBox.Show("Se va a registrar un Requerimiento de Orden de Producción" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Generar_Produccion_Alimentos() = True Then
                Nuevo()
                MostrandoDatosGeneralesCabeceraAlmacen()
            End If
        End If
        

    End Sub

    Private Function Generar_Produccion_Alimentos() As Boolean
        Try
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE)
            Dim alm_cabBE As New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP
            Dim alm_detBE As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS


            With alm_cabBE
                If Modo_consultar = False Then
                    .ID = 0
                Else
                    .ID = txt_numero.Text
                End If

                .FECHA = dtpFecha.Value.ToString("dd/MM/yyyy")
                .STATUS = "V"
                .PART_ID = "" 'txt_cod_producto_producir.Text.Trim
                .CANTIDAD = 0 'CDbl(txt_cantidad_prod_producir.Text)
                .FACTOR = 1
                If txt_costo_prod_producir.Text = "" Then
                    .COSTO = 0
                Else
                    .COSTO = IIf(txt_costo_prod_producir.Text = "", 0, CDbl(txt_costo_prod_producir.Text))
                End If
                If txt_total_prod_producir.Text = "" Then
                    .TOTAL = 0
                Else
                    .TOTAL = IIf(txt_total_prod_producir.Text = "", 0, CDbl(txt_total_prod_producir.Text))
                End If
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .COD_CLIENTE = txtCodCliente.Text
                .OBSERVACIONES = txtComentarios.Text
                .NUMERO_PEDIDO = ""
                .ITEM_PEDIDO = ""
                .FECHA_ENTREGA = dtp_fecha_entrega.Value.ToString("dd/MM/yyyy")
                .VENDEDOR = txt_cod_vendedor.Text
                .DESTINATARIO = cbo_destinatario.Text
                .URGENTE = IIf(chk_urgente.Checked, "SI", "NO")
            End With

            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE
                With alm_detBE
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .CODIGO = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .COSTO = dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString
                    .CANTIDAD = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .TOTAL = dtdetalleArticuloPrincipal.Rows(i).Item("TOTAL").ToString
                    .PLANEAMIENTO = dtdetalleArticuloPrincipal.Rows(i).Item("PLANEAMIENTO").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            Me.Cursor = Cursors.WaitCursor
            '--PARTE DE ALMACEN
            If almacenBL.Guardar__Requerimiento_Produccion_OP(alm_cabBE, ls_det_alm, Modo_consultar) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                If Modo_consultar = False Then
                    msj = "Generación de Requerimiento de Orden" & vbCrLf & "de Producción correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                Else
                    msj = "Modificación de Requerimiento de Orden" & vbCrLf & "de Producción correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
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
        Call Botonera_Estado_Cambiar(True)

        _id_requerimiento = CInt(dgvCabeceraAlmacen.CurrentRow.Cells("NUMERO_DOC").Value)
        If MostrarModoEdicion(_id_requerimiento) Then
            pnlprincipal.Visible = False

            'If dgvCabeceraAlmacen.CurrentRow.Cells("ESTADO").Value = "PRODUCCION" Then
            '    btnAprobar.Visible = False
            'End If
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
            dtCabeceraAlm = clsAlmacenCabBl.get_Cabecera_Requerimiento_Produccion_OP(_codigo)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                GenerarColummnaDataTable_Procesos()

                GbTransaccion.Enabled = False
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    txt_numero.Text = dtCabeceraAlm.Rows(i).Item("NUMERO").ToString
                    txtCodCliente.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_ID").ToString
                    txtRazonSocial.Text = dtCabeceraAlm.Rows(i).Item("CLIENTE").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("OBSERVACIONES").ToString
                    dtpFecha.Value = dtCabeceraAlm.Rows(i).Item("FECHA").ToString
                    txt_cod_producto_producir.Text = dtCabeceraAlm.Rows(i).Item("COD_PRODUCTO").ToString
                    txt_des_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("PRODUCTO").ToString
                    txt_unidad_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("UNIDAD").ToString
                    txt_cantidad_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("CANTIDAD").ToString
                    txt_factor.Text = dtCabeceraAlm.Rows(i).Item("FACTOR").ToString
                    txt_costo_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("COSTO").ToString
                    txt_total_prod_producir.Text = dtCabeceraAlm.Rows(i).Item("TOTAL").ToString

                    dtp_fecha_entrega.Value = dtCabeceraAlm.Rows(i).Item("FECHA_ENTREGA").ToString
                    txt_cod_vendedor.Text = dtCabeceraAlm.Rows(i).Item("COD_VENDEDOR").ToString
                    txt_des_vendedor.Text = dtCabeceraAlm.Rows(i).Item("VENDEDOR").ToString
                    cbo_destinatario.Text = dtCabeceraAlm.Rows(i).Item("DESTINATARIO").ToString

                    If dtCabeceraAlm.Rows(i).Item("URGENTE").ToString = "SI" Then
                        chk_urgente.Checked = True
                    Else
                        chk_urgente.Checked = False
                    End If

                    If dtCabeceraAlm.Rows(i).Item("STATUS").ToString = "V" Then
                        btnGrabar.Enabled = True
                    Else
                        btnGrabar.Enabled = False
                    End If

                    txt_total_prod_producir.Text = Format(Double.Parse(txt_total_prod_producir.Text), "##,##0.00")
                    txt_cantidad_prod_producir.Text = Format(Double.Parse(txt_cantidad_prod_producir.Text), "##,##0.0000")
                    txt_costo_prod_producir.Text = Format(Double.Parse(txt_costo_prod_producir.Text), "##,##0.000000")

                Next
                '---Mostrando datos del Detalle
                dtdetalleArticuloPrincipal = clsAlmacenCabBl.get_Detalle_Requerimiento_Produccion_OP(_codigo)
                ConfigurarGrila()

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


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
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
            dtdetalleArticuloPrincipal.Columns.Add("PLANEAMIENTO", Type.GetType("System.String")) '10

            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Procesos()
        Try
            dtdetalleArticuloPrincipal_Procesos = New DataTable
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("ITEM", Type.GetType("System.Int16")) '0
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("PROCESO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("MAQUINA", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("INICIO", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("FIN", Type.GetType("System.String")) '4

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
                txt_cantidad_prod_producir.Select()
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
                txt_cantidad_prod_producir.Select()
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
            'txt_cod_insumo.Focus()
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
            btn_agregar_insumo.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_insumo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_insumo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'btn_add.Focus()
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

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs)
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

            txt_cod_vendedor.Select()

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

    
    Private Sub txt_cod_insumo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_insumo.MouseDoubleClick
        Mostrando_Producto_Insumos()
    End Sub

    Private Sub txt_cod_insumo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_insumo.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Producto_Insumos()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_insumo.Text = String.Empty Then
                Mostrando_Producto_Insumos()
            Else
                txt_cantidad_prod_producir.Select()
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

    Private Sub txt_cantidad_insumo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_insumo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_insumo_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_cantidad_insumo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso_Insumo() = False Then Exit Sub
            
            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
            row("CODIGO") = txt_cod_insumo.Text.Trim
            row("DESCRIPCION") = txt_des_insumo.Text.Trim
            row("UNIDAD") = txt_unidad_insumo.Text.Trim
            row("COSTO") = 0
            row("CANTIDAD") = txt_cantidad_insumo.Text
            row("TOTAL") = 0
            row("STOCK") = 0
            row("SALDO") = 0
            row("CONSULTA") = "Ver Stock"
            row("PLANEAMIENTO") = ""

            dtdetalleArticuloPrincipal.Rows.Add(row)
            dtdetalleArticuloPrincipal.AcceptChanges()
            Call Limpiar_GroupBox(gb_insumos)
            ConfigurarGrila()

            txt_cod_insumo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle_insumos.DataSource = Nothing
            dgvDetalle_insumos.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle_insumos.AutoResizeColumns()
            dgvDetalle_insumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalle_insumos.Columns(0).HeaderText = "Item"
            dgvDetalle_insumos.Columns(1).HeaderText = "Codigo"
            dgvDetalle_insumos.Columns(2).HeaderText = "Producto"
            dgvDetalle_insumos.Columns(3).HeaderText = "Unidad"
            dgvDetalle_insumos.Columns(4).Visible = False 'HeaderText = "Costo"
            dgvDetalle_insumos.Columns(5).HeaderText = "Cantidad"
            dgvDetalle_insumos.Columns(6).Visible = False 'HeaderText = "Total"
            dgvDetalle_insumos.Columns(7).Visible = False 'HeaderText = "Stock"
            dgvDetalle_insumos.Columns(8).Visible = False 'HeaderText = "Saldo"
            dgvDetalle_insumos.Columns(9).HeaderText = "Consulta"

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
            dgvDetalle_insumos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            If Modo_consultar = False Then 'NUEVO
                dgvDetalle_insumos.Columns(10).Visible = False 'HeaderText = "Saldo"
            Else
                dgvDetalle_insumos.Columns(10).Visible = True 'HeaderText = "Saldo"
                dgvDetalle_insumos.Columns(10).HeaderText = "Planeamiento"
            End If
        End If

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

        Return True

    End Function

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
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
            RehacerSecuencia_Insumo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_Insumo()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub cbo_destinatario_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_destinatario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtComentarios.Focus()
        End If
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

    Private Sub DerivaciónDePlaneamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerivaciónDePlaneamientoToolStripMenuItem.Click
        If dgvDetalle_insumos.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle_insumos.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "MANUFACTURA_SP_S_DERIVACION_PLANEAMIENTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE PLANEMIENTO"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & dgvDetalle_insumos.CurrentRow.Cells("Item").Value)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("PLANEAMIENTO") = frm.Data_Matriz.Rows(0).Item(1).ToString
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RegistrarDerivPlaneamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarDerivPlaneamientoToolStripMenuItem.Click
        If dtdetalleArticuloPrincipal.Rows.Count = 0 Then Exit Sub

        If MessageBox.Show("Se va a registrar la Derivación de Planeamiento" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Actualizar_Derivacion_Planeamiento() = True Then
                clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                dtdetalleArticuloPrincipal = clsAlmacenCabBl.get_Detalle_Requerimiento_Produccion_OP(_id_requerimiento)
                ConfigurarGrila()
                MostrandoDatosGeneralesCabeceraAlmacen()
            End If
        End If
    End Sub

    Private Function Actualizar_Derivacion_Planeamiento() As Boolean
        Try
            'PARTE DE LA PRODUCCION DE ALIMENTOS
            Dim ls_det_alm As New List(Of ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE)
            Dim alm_cabBE As New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP
            Dim alm_detBE As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS


            With alm_cabBE
                If Modo_consultar = False Then
                    .ID = 0
                Else
                    .ID = txt_numero.Text
                End If
            End With

            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                alm_detBE = New ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE
                With alm_detBE
                    .ID_CAB = alm_cabBE.ID
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                    .CODIGO = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .COSTO = dtdetalleArticuloPrincipal.Rows(i).Item("COSTO").ToString
                    .CANTIDAD = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                    .TOTAL = dtdetalleArticuloPrincipal.Rows(i).Item("TOTAL").ToString
                    .PLANEAMIENTO = dtdetalleArticuloPrincipal.Rows(i).Item("PLANEAMIENTO").ToString
                End With
                ls_det_alm.Add(alm_detBE)
            Next

            Me.Cursor = Cursors.WaitCursor
            '--PARTE DE ALMACEN
            If almacenBL.Guardar_Actualizacion_Derivacion_Planeamiento(alm_cabBE, ls_det_alm, Modo_consultar) Then
                Dim msj As String = String.Empty
                msj = String.Empty
                If Modo_consultar = False Then
                    msj = "Generación de Requerimiento de Orden" & vbCrLf & "de Producción correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
                Else
                    msj = "Actualización de Derivación de Planeamiento" & vbCrLf & "correctamente." '& vbCrLf & " Nro Documento: " & "NS" & " - " & alm_cabBE_almacen.NUMBER_DOCUMENT
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
End Class