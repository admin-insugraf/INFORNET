Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Imports LibCompras

Public Class FrmSolicitudCotizacion
    Public Modo_consultar As Boolean = False
    Public Modo_actualizar_cotizacion As Boolean = False
    Private clsFacturaBl As ClsOperaciones.USUARIO
    Private cabeceraPQ As ClsEntidades.PURCHASE_QUOTE
    Private detallePQ As ClsEntidades.PURCHASE_QUOTE_LINE
    Dim ls_det As List(Of ClsEntidades.PURCHASE_QUOTE_LINE)
    Private dtDocumentoSolCotizacion As DataTable
    Private dtNumeracionSolCotizacion As DataTable
    Private dtDocumentosListaRequisicion As DataTable
    Private dtDatosRequisicion As DataTable
    Private dtDetalleFact As DataTable
    Private DTCABECERAPQ As DataTable
    Private DTDETALLEPQ As DataTable
    Private dtv As DataView
    Private STRorden As String

    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String

    Public dtdetalleArticuloPrincipal As DataTable
    Public dtListaRequisiciones As DataTable
    Private dtdetalleArticulo As DataTable
    Public Flag_Modo_Edicion As Boolean = False
    Public _item As String
    Dim reporteBL As ClsOperaciones.USUARIO
    Private crystalBL As LibReportes.ClsReporte
    Private dtImprimir As DataTable

    Dim dtProveedorPrincipal As DataTable
    Private Sub FrmSolicitudCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        txtFiltro.Select()
        GenerarColummnaDataTableProveedor()
    End Sub

    Public Sub GenerarColummnaDataTableProveedor()
        Try
            dtProveedorPrincipal = New DataTable("Proveedores")
            dtProveedorPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtProveedorPrincipal.Columns.Add("ID", Type.GetType("System.String"))
            dtProveedorPrincipal.Columns.Add("NAME", Type.GetType("System.String"))
            dtProveedorPrincipal.Columns.Add("VAT_REGISTRATION", Type.GetType("System.String"))
            dtProveedorPrincipal.Columns.Add("NUMERACION", Type.GetType("System.String"))
            dtProveedorPrincipal.PrimaryKey = New DataColumn() {dtProveedorPrincipal.Columns("ITEM")}
            dgv_proveedor.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub configurarGrilla()
        dgv_proveedor.DataSource = dtProveedorPrincipal
        dgv_proveedor.Columns(0).Visible = False
        dgv_proveedor.Columns(4).Visible = False
        dgv_proveedor.Columns(1).Width = 80
        dgv_proveedor.Columns(2).Width = 210
        dgv_proveedor.Columns(3).Width = 80
        dgv_proveedor.Columns("ID").HeaderText = "Codigo"
        dgv_proveedor.Columns("NAME").HeaderText = "Proveedor"
        dgv_proveedor.Columns("VAT_REGISTRATION").HeaderText = "Ruc"
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnImprimir.Enabled = False
            btnGrabar.Enabled = True
            btnact_coti.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            tc_tipos.Visible = Opcion
            tc_registro_coti.Visible = Not Opcion
        Else
            btnNuevo.Enabled = True
            btnImprimir.Enabled = True
            btnGrabar.Enabled = False
            btnact_coti.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            tc_tipos.Visible = Opcion
            tc_registro_coti.Visible = Opcion
        End If
    End Sub
    Public Sub Botonera_Estado_Cambiar_Reg_Cotizacion(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnImprimir.Enabled = False
            btnGrabar.Enabled = True
            btnact_coti.Enabled = False
            btnAnular.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            tc_tipos.Visible = Not Opcion
            tc_registro_coti.Visible = Opcion
        Else
            btnNuevo.Enabled = True
            btnImprimir.Enabled = True
            btnGrabar.Enabled = False
            btnact_coti.Enabled = True
            btnAnular.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            tc_tipos.Visible = Opcion
            tc_registro_coti.Visible = Opcion
        End If
    End Sub
    Private Sub DocumentosSolicitudCotizacion()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsFacturaBl = New ClsOperaciones.USUARIO
            dtDocumentoSolCotizacion = New DataTable
            dtv = New DataView
            dtDocumentoSolCotizacion = clsFacturaBl.get_DatosGeneralesSolicitudCotizacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                            cboopcionesBusqueda.SelectedIndex)
            dgvDocumentosFactura.DataSource = Nothing
            If dtDocumentoSolCotizacion.Rows.Count() <> 0 Then
                dtv = dtDocumentoSolCotizacion.DefaultView
                dgvDocumentosFactura.DataSource = dtv
                'dgvDocumentosFactura.Columns(0).Width = 80
                'dgvDocumentosFactura.Columns(1).Width = 80
                'dgvDocumentosFactura.Columns(2).Width = 220
                'dgvDocumentosFactura.Columns(3).Width = 220
                'dgvDocumentosFactura.Columns(4).Width = 145
                'dgvDocumentosFactura.Columns(5).Width = 80
                'dgvDocumentosFactura.Columns(6).Width = 100
                dgvDocumentosFactura.AutoResizeColumns()
                dgvDocumentosFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvDocumentosFactura.Columns(1).Name & "+" & dgvDocumentosFactura.Columns(2).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboopcionesBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboopcionesBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentosFactura.Select()
        End If
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
        DocumentosSolicitudCotizacion()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosSolicitudCotizacion()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosSolicitudCotizacion()
        End If
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvDocumentosFactura.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvDocumentosFactura.Columns(2).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvDocumentosFactura.Columns(0).Name & "+" & dgvDocumentosFactura.Columns(2).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboopcionesBusqueda.Select()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Modo_consultar = False
        Modo_actualizar_cotizacion = False
        Botonera_Estado_Cambiar(True)
        Nuevo()
        CONTROLES(True, 0)
        dtfecha.Select()
        pnl_prov.Visible = True
        btn_agregar_requisicion.Visible = True
        Label2.Visible = False
        txtnumero.Visible = False
    End Sub

    Private Sub Nuevo()
        Try
            dgvDocumentosFactura.Visible = False
            pnlFiltros.Visible = False
            Limpiar()
            GenerarColummnaDataTable()
            GenerarColummnaDataTableProveedor()
            dtfecha.Value = Date.Now
            'clsFacturaBl = New ClsOperaciones.USUARIO
            'dtNumeracionSolCotizacion = New DataTable
            'dtNumeracionSolCotizacion = clsFacturaBl.get_Numeracion_Sol_Cotizacion()
            'If dtNumeracionSolCotizacion.Rows.Count > 0 Then
            '    txtnumero.Text = dtNumeracionSolCotizacion.Rows(0).Item(0).ToString
            'Else
            '    MsgBox("No existe numeración para la Solicitud de Cotización.", MsgBoxStyle.Information, "Aviso")
            '    Exit Sub
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Nuevo_Registro_Cotizacion()
        Try
            dgvDocumentosFactura.Visible = False
            pnlFiltros.Visible = False
            Limpiar_Cotizacion()
            'GenerarColummnaDataTable_Registro_Cotizacion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar_Cotizacion()
        txtcod_proveedor.Text = String.Empty
        txtcod_proveedor_Reg.Text = String.Empty
        txtproveedor_reg.Text = String.Empty
        txtobservaciones_reg.Text = String.Empty

        txtnum_cotizacion_reg.Text = String.Empty
        txtfp_cotizacion_reg.Text = String.Empty
        txtfp_des_cotizacion_reg.Text = String.Empty
        txtte_cotizacion_reg.Text = String.Empty
        txtvo_cotizacion_reg.Text = String.Empty
    End Sub
    Private Sub Limpiar_Cotizacion_Detalle()
        txtcod_prod_reg.Text = String.Empty
        txtdes_pro_reg.Text = String.Empty
        txtuni_reg.Text = String.Empty
        txtcantidad_reg.Text = String.Empty

        txtprecio_reg.Text = String.Empty
        txtigvpor_reg.Text = String.Empty
        txtdescpor_reg.Text = String.Empty
        txtgarantia_reg.Text = String.Empty
        txtcalidad_reg.Text = String.Empty

        txtmarca_reg.Text = String.Empty
        chkigvinc_reg.Checked = False
    End Sub
    Private Sub Limpiar()
        txtnum_cotizacion_reg.Text = String.Empty
        txtrazon_proveedor.Text = String.Empty
        txtruc.Text = String.Empty
        txtobservacionesgenerales.Text = String.Empty
        txtnumero.Text = String.Empty
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("GLOSA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("AREA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUMERO_REQUERIMIENTO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("TIPO_REQUERIMIENTO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.Columns(0).Width = 40
            dgvDetalle.Columns(1).Width = 80
            dgvDetalle.Columns(2).Width = 280
            dgvDetalle.Columns(3).Width = 60
            dgvDetalle.Columns(4).Width = 80
            dgvDetalle.Columns(5).Width = 400
            dgvDetalle.Columns(6).Width = 300
            dgvDetalle.Columns(7).Width = 200
            dgvDetalle.Columns(8).Width = 200
            dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.000000"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable_Registro_Cotizacion()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO", Type.GetType("System.Double")) '5
            dtdetalleArticuloPrincipal.Columns.Add("IGV", Type.GetType("System.Double")) '6
            dtdetalleArticuloPrincipal.Columns.Add("DESCUENTO", Type.GetType("System.Double")) '7
            dtdetalleArticuloPrincipal.Columns.Add("GARANTIA", Type.GetType("System.String")) '8
            dtdetalleArticuloPrincipal.Columns.Add("CALIDAD", Type.GetType("System.String")) '9
            dtdetalleArticuloPrincipal.Columns.Add("MARCA_MODELO", Type.GetType("System.String")) '10
            dtdetalleArticuloPrincipal.Columns.Add("FECHA_ENTREGA", Type.GetType("System.String")) '11
            dtdetalleArticuloPrincipal.Columns.Add("IS_VAT", Type.GetType("System.String")) '11
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
            dgvdet_cotizacion_reg.DataSource = Nothing
            dgvdet_cotizacion_reg.DataSource = dtdetalleArticuloPrincipal
            dgvdet_cotizacion_reg.Columns(0).Width = 60
            dgvdet_cotizacion_reg.Columns(1).Width = 100
            dgvdet_cotizacion_reg.Columns(2).Width = 350
            dgvdet_cotizacion_reg.Columns(3).Width = 80
            dgvdet_cotizacion_reg.Columns(4).Width = 200
            dgvdet_cotizacion_reg.Columns(5).Width = 200
            dgvdet_cotizacion_reg.Columns(6).Width = 200
            dgvdet_cotizacion_reg.Columns(7).Width = 200
            dgvdet_cotizacion_reg.Columns(8).Width = 350
            dgvdet_cotizacion_reg.Columns(9).Width = 350
            dgvdet_cotizacion_reg.Columns(10).Width = 350
            dgvdet_cotizacion_reg.Columns(11).Width = 200
            dgvdet_cotizacion_reg.Columns(12).Width = 100
            dgvdet_cotizacion_reg.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("PRECIO").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("IGV").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("DESCUENTO").DefaultCellStyle.Format = "##,##0.000000"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Formato_Grilla()
        If dtdetalleArticuloPrincipal.Rows.Count <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.Columns(0).Width = 60
            dgvDetalle.Columns(1).Width = 100
            dgvDetalle.Columns(2).Width = 350
            dgvDetalle.Columns(3).Width = 80
            dgvDetalle.Columns(4).Width = 200
            dgvDetalle.Columns(5).Width = 400
            dgvDetalle.Columns(6).Width = 300
            dgvDetalle.Columns(7).Width = 200
            dgvDetalle.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.000000"
        End If
    End Sub
    Public Sub Formato_Grilla_Reg_Cotizacion()
        If dtdetalleArticuloPrincipal.Rows.Count <> 0 Then
            dgvdet_cotizacion_reg.DataSource = Nothing
            dgvdet_cotizacion_reg.DataSource = dtdetalleArticuloPrincipal
            dgvdet_cotizacion_reg.Columns(0).Width = 60
            dgvdet_cotizacion_reg.Columns(1).Width = 100
            dgvdet_cotizacion_reg.Columns(2).Width = 350
            dgvdet_cotizacion_reg.Columns(3).Width = 80
            dgvdet_cotizacion_reg.Columns(4).Width = 200
            dgvdet_cotizacion_reg.Columns(5).Width = 200
            dgvdet_cotizacion_reg.Columns(6).Width = 200
            dgvdet_cotizacion_reg.Columns(7).Width = 200
            dgvdet_cotizacion_reg.Columns(8).Width = 350
            dgvdet_cotizacion_reg.Columns(9).Width = 350
            dgvdet_cotizacion_reg.Columns(10).Width = 350
            dgvdet_cotizacion_reg.Columns(11).Width = 200
            dgvdet_cotizacion_reg.Columns("CANTIDAD").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("PRECIO").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("IGV").DefaultCellStyle.Format = "##,##0.000000"
            dgvdet_cotizacion_reg.Columns("DESCUENTO").DefaultCellStyle.Format = "##,##0.000000"
        End If
    End Sub
    Private Sub txtcod_proveedor_DoubleClick(sender As Object, e As EventArgs) Handles txtcod_proveedor.DoubleClick
        Ayuda_Proveedores(txtcod_proveedor.Text)
    End Sub
    Private Sub Ayuda_Forma_Pago(Optional ByVal _CodigoFP As String = "")
        Try
            If _CodigoFP = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "COMPRAS_SP_S_MUESTRA_TERM_PURCHASE"
                frm.CadenaConsulta = sql
                frm.Titulo = "Forma de Pago"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtfp_cotizacion_reg.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtfp_des_cotizacion_reg.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsOperaciones.USUARIO
                dtDetalleFact = New DataTable("Forma_Pago")
                dtDetalleFact = clsFacturaBl.get_Datos_Forma_Pago(_CodigoFP)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtfp_cotizacion_reg.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtfp_des_cotizacion_reg.Text = dtDetalleFact.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtfp_cotizacion_reg.Text = String.Empty
                    txtfp_des_cotizacion_reg.Text = String.Empty
                    txtfp_cotizacion_reg.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ayuda_Proveedores(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "COMPRAS_SP_S_MUESTRA_VENDOR"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcod_proveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtrazon_proveedor.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtruc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsOperaciones.USUARIO
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.get_Datos_Provedor(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtcod_proveedor.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtrazon_proveedor.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txtruc.Text = dtDetalleFact.Rows(0).Item(2).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtcod_proveedor.Text = String.Empty
                    txtrazon_proveedor.Text = String.Empty
                    txtruc.Text = String.Empty
                    txtcod_proveedor.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ayuda_Articulos(Optional ByVal _CodigoArticulo As String = "")
        Try
            If _CodigoArticulo = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "COMPRAS_SP_S_MUESTRA_ARTICULOS_SOLICITUD_COTIZACION"
                frm.CadenaConsulta = sql
                frm.Titulo = "Articulos"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                End If
                frm.Close()
            Else
                clsFacturaBl = New ClsOperaciones.USUARIO
                dtDetalleFact = New DataTable("Articulos")
                dtDetalleFact = clsFacturaBl.get_Datos_Articulo(_CodigoArticulo)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtcodigoArticulo.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtdescripcionArticulo.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txtunidadMedida.Text = dtDetalleFact.Rows(0).Item(2).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtcodigoArticulo.Text = String.Empty
                    txtdescripcionArticulo.Text = String.Empty
                    txtunidadMedida.Text = String.Empty
                    txtcodigoArticulo.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcod_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcod_proveedor.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Proveedores()
        If e.KeyCode = Keys.Enter Then
            If txtcod_proveedor.Text = String.Empty Then
                Ayuda_Proveedores()
            Else
                Ayuda_Proveedores(txtcod_proveedor.Text)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvDocumentosFactura.Visible = True
        pnlFiltros.Visible = True
        Botonera_Estado_Cambiar(False)
        'Modo_consultar = False
        Limpiar()
        DocumentosSolicitudCotizacion()
        pnl_prov.Visible = True
        btn_agregar_requisicion.Visible = True
        Label2.Visible = False
        txtnumero.Visible = False
    End Sub
    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice_tab As Integer)
        tc_tipos.TabPages(0).Enabled = False
        tc_tipos.TabPages(1).Enabled = False
        tc_tipos.TabPages(2).Enabled = False
        tc_tipos.TabPages(3).Enabled = False
        tc_tipos.TabPages(_indice_tab).Enabled = opcion
        tc_tipos.SelectTab(_indice_tab)
    End Sub
    Private Sub CONTROLES_Reg_Cotizacion(ByVal opcion As Boolean, ByVal _indice_tab As Integer)
        tc_registro_coti.TabPages(0).Enabled = False
        tc_registro_coti.TabPages(1).Enabled = False
        tc_registro_coti.TabPages(_indice_tab).Enabled = opcion
        tc_registro_coti.SelectTab(_indice_tab)
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        CONTROLES(True, 1)
        txtcodigoArticulo.Enabled = True
        txtcodigoArticulo.Select()
    End Sub


    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Articulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                Ayuda_Articulos()
                txtcantidad_articulo.Select()
            Else
                Ayuda_Articulos(txtcodigoArticulo.Text)
                txtcantidad_articulo.Select()
            End If
        End If
    End Sub

    Private Sub txtcodigoArticulo_DoubleClick(sender As Object, e As EventArgs) Handles txtcodigoArticulo.DoubleClick
        Ayuda_Articulos(txtcodigoArticulo.Text)
    End Sub

    Private Sub btncancelaritem_Click(sender As Object, e As EventArgs) Handles btncancelaritem.Click
        txtcodigoArticulo.Text = String.Empty
        txtdescripcionArticulo.Text = String.Empty
        txtunidadMedida.Text = String.Empty
        txtcantidad_articulo.Text = String.Empty
        txtarea.Text = String.Empty
        txtobservaciones_articulo.Text = String.Empty
        CONTROLES(True, 0)
        Formato_Grilla()
        'txtcod_proveedor.Focus()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("CANTIDAD") = txtcantidad_articulo.Text
            row("GLOSA") = txtobservaciones_articulo.Text
            row("AREA") = txtarea.Text
            row("NUMERO_REQUERIMIENTO") = ""
            dtdetalleArticuloPrincipal.Rows.Add(row)
            dtdetalleArticuloPrincipal.AcceptChanges()
            txtcodigoArticulo.Text = String.Empty
            txtdescripcionArticulo.Text = String.Empty
            txtunidadMedida.Text = String.Empty
            txtcantidad_articulo.Text = String.Empty
            txtarea.Text = String.Empty
            txtobservaciones_articulo.Text = String.Empty
            txtcodigoArticulo.Select()
        Else
            'Agregando los datos a devolver
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _item)
                dtdetalleArticuloPrincipal.BeginInit()
                item("CODIGO") = txtcodigoArticulo.Text
                item("DESCRIPCION") = txtdescripcionArticulo.Text
                item("CANTIDAD") = txtcantidad_articulo.Text
                item("GLOSA") = txtobservaciones_articulo.Text
                item("AREA") = txtarea.Text
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
            btncancelaritem_Click(sender, e)
        End If
        'Formato_Grilla()
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub
    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        Flag_Modo_Edicion = True
        ModificandoArticulos()
    End Sub
    Private Sub ModificandoArticulos()
        Try
            _item = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim _codigo As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim _descripcion As String = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim _unidad As String = dgvDetalle.Item(3, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim _cantidad As Double = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value
            Dim _glosa As String = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            Dim _area As String = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value.ToString

            txtcodigoArticulo.Text = _codigo
            txtcodigoArticulo.Enabled = False
            txtdescripcionArticulo.Text = _descripcion
            txtunidadMedida.Text = _unidad
            txtcantidad_articulo.Text = _cantidad
            txtarea.Text = _area
            txtobservaciones_articulo.Text = _glosa
            CONTROLES(True, 1)
            txtcantidad_articulo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ModificandoArticulos_ActCotizacion()
        Try
            _item = dgvdet_cotizacion_reg.Item(0, dgvdet_cotizacion_reg.CurrentRow.Index).Value.ToString

            Dim _codigo As String = dgvdet_cotizacion_reg.Item(1, dgvdet_cotizacion_reg.CurrentRow.Index).Value.ToString
            Dim _descripcion As String = dgvdet_cotizacion_reg.Item(2, dgvdet_cotizacion_reg.CurrentRow.Index).Value.ToString
            Dim _unidad As String = dgvdet_cotizacion_reg.Item(3, dgvdet_cotizacion_reg.CurrentRow.Index).Value.ToString
            Dim _cantidad As Double = dgvdet_cotizacion_reg.Item(4, dgvdet_cotizacion_reg.CurrentRow.Index).Value
            Dim _precio As Double = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(5, dgvdet_cotizacion_reg.CurrentRow.Index).Value), 0, dgvdet_cotizacion_reg.Item(5, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _igv As Double = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(6, dgvdet_cotizacion_reg.CurrentRow.Index).Value), 0, dgvdet_cotizacion_reg.Item(6, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _descuento As Double = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(7, dgvdet_cotizacion_reg.CurrentRow.Index).Value), 0, dgvdet_cotizacion_reg.Item(7, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _garantia As String = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(8, dgvdet_cotizacion_reg.CurrentRow.Index).Value), "", dgvdet_cotizacion_reg.Item(8, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _calidad As String = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(9, dgvdet_cotizacion_reg.CurrentRow.Index).Value), "", dgvdet_cotizacion_reg.Item(9, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _marca_modelo As String = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(10, dgvdet_cotizacion_reg.CurrentRow.Index).Value), "", dgvdet_cotizacion_reg.Item(10, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _fecha As String = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(11, dgvdet_cotizacion_reg.CurrentRow.Index).Value), "", dgvdet_cotizacion_reg.Item(11, dgvdet_cotizacion_reg.CurrentRow.Index).Value)
            Dim _is_vat As String = IIf(IsDBNull(dgvdet_cotizacion_reg.Item(12, dgvdet_cotizacion_reg.CurrentRow.Index).Value), "0", dgvdet_cotizacion_reg.Item(12, dgvdet_cotizacion_reg.CurrentRow.Index).Value)

            txtcod_prod_reg.Text = _codigo
            txtdes_pro_reg.Text = _descripcion
            txtuni_reg.Text = _unidad
            txtcantidad_reg.Text = _cantidad
            txtprecio_reg.Text = _precio
            txtigvpor_reg.Text = _igv
            txtdescpor_reg.Text = _descuento
            txtgarantia_reg.Text = _garantia
            txtcalidad_reg.Text = _calidad
            txtmarca_reg.Text = _marca_modelo
            dtfec_entrega_reg.Value = IIf(_fecha = "", Date.Now, _fecha)
            chkigvinc_reg.Checked = IIf(_is_vat = "0", False, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Modo_actualizar_cotizacion = False Then
            If dgvDetalle.CurrentRow Is Nothing Then MsgBox("La Solicitud de Cotización no tiene detalles.!", MsgBoxStyle.Critical, "Aviso") : Exit Sub
            If ValidacionesGenerales() = False Then Exit Sub
            If Modo_consultar = False Then
                If MsgBox("Desea guardar la Solicitud de Cotización?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                            If dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD") = 0 Then
                                MessageBox.Show("Falta ingresar la cantidad a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next
                    End If
                    If GuardarFacturacion() = True Then
                        Nuevo()
                    End If
                    Me.Cursor = Cursors.Default
                End If
            ElseIf Modo_consultar = True Then
                If MsgBox("Desea actualizar la Solicitud de Cotización?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                            If dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD") = 0 Then
                                MessageBox.Show("Falta ingresar la cantidad a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next
                    End If
                    If Actualizacion_Solicitud_Cotizacion() = True Then
                        Actualiza_Estado_Requerimiento_Solicitud_Cotizacion(txtnumero.Text, "E")
                        Nuevo()
                        btnCancelar_Click(sender, e)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If
        ElseIf Modo_actualizar_cotizacion = True Then
            If dgvdet_cotizacion_reg.CurrentRow Is Nothing Then MsgBox("La Cotización no tiene detalles.!", MsgBoxStyle.Critical, "Aviso") : Exit Sub
            If ValidacionesGenerales_Act_Cotizacion() = False Then Exit Sub
            If MsgBox("Desea actualizar la Cotización?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                        If dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO") = 0 Then
                            MessageBox.Show("Falta ingresar el precio a los Articulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Next
                End If
                If Guardar_ActCotizacion() = True Then
                    Actualiza_Estado_Requerimiento_Solicitud_Cotizacion(txtnumero.Text, "A")
                End If
                Me.Cursor = Cursors.Default
                btnCancelar_Click(sender, e)
            End If
        End If
    End Sub
    Private Function ValidacionesGenerales_Act_Cotizacion() As Boolean
        Dim estado As Boolean = True
        Try
            If txtnum_cotizacion_reg.Text = String.Empty Then
                MsgBox("Debe ingresar un número de Cotización brindada por el Proveedor.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If cmbmoneda_cotizacion_reg.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar una moneda para la Cotización, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            If txtfp_cotizacion_reg.Text = String.Empty Then
                MsgBox("Debe elegir una Forma de Pago.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            'If txtnumero.Text = String.Empty Then
            '    MsgBox("Debe obtener un número de Solicitud de Cotización.", MsgBoxStyle.Information)
            '    estado = False
            '    Exit Try
            'End If
            If Modo_consultar = False Then
                If dtProveedorPrincipal.Rows.Count() = 0 Then
                    MsgBox("Debe seleccionar un Proveedor, para poder continuar.", MsgBoxStyle.Critical)
                    btn_agregar_proveedor.Select()
                    estado = False
                    Exit Try
                End If
            End If
            If txtobservacionesgenerales.Text = String.Empty Then
                MsgBox("Debe ingresar una Observación General.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    'Private Function Actualiza_Numeracion_Solicitud_Cotizacion() As Boolean
    '    Dim indicadorANSC As Boolean = True
    '    Try
    '        clsFacturaBl = New ClsOperaciones.USUARIO
    '        If clsFacturaBl.ActualizandoNumeracionPurchaseQuote(CDbl(txtnumero.Text)) = False Then
    '            MsgBox("Hubo un Error en la actualización de la numeración de la Solicitud de Cotización.", MsgBoxStyle.Critical)
    '            indicadorANSC = False
    '            Exit Try
    '        End If
    '    Catch ex As Exception
    '        indicadorANSC = False
    '        MsgBox(ex.Message)
    '    End Try
    '    Return indicadorANSC
    'End Function

    Private Function Actualiza_Estado_Requerimiento_Solicitud_Cotizacion(ByVal _numero As String, ByVal opcion As String) As Boolean
        Dim indicadorAERSC As Boolean = True
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            If clsFacturaBl.ActualizandoEstadoRequirementPurchaseQuote(_numero, opcion) = False Then
                MsgBox("Hubo un Error en la actualización del estado de los Requerimientos adjuntos a la Solicitud de Cotización.", MsgBoxStyle.Critical)
                indicadorAERSC = False
                Exit Try
            End If
        Catch ex As Exception
            indicadorAERSC = False
            MsgBox(ex.Message)
        End Try
        Return indicadorAERSC
    End Function

    Private Function GuardarFacturacion() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            clsFacturaBl = New ClsOperaciones.USUARIO
            cabeceraPQ = New ClsEntidades.PURCHASE_QUOTE
            ls_det = New List(Of ClsEntidades.PURCHASE_QUOTE_LINE)

            With cabeceraPQ
                .ID = ""
                .DOCUMENT_DATE = dtfecha.Value.ToString("dd/MM/yyyy")
                .VENDOR_ID = ""
                .CURRENCY_ID = ""
                .COMMENT = ""
                .COMMENT_COT = txtobservacionesgenerales.Text
                .QUOTE_DATE = dtfecha.Value.ToString("dd/MM/yyyy")
                .SCTIPCAM = LibComunVar.ClsVarComun.TCVenta
                .SCVALIDEZ = ""
                .SCTIEMENT = ""
                .SCFORPAG = ""
                .SCNCOTIZ = ""
                .CREATE_DATE = Date.Now
                .UPDATE_DATE = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PROJECT_ID = ""
                .STATUS = "P"
            End With
            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detallePQ = New ClsEntidades.PURCHASE_QUOTE_LINE
                With detallePQ
                    .ID = ""
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO"))
                    .PART_DESCRIPTION = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION")), "", dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION"))
                    .UNIT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD")), "", dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD"))
                    .QTY = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                    .PRICE = 0
                    .AMOUNT_TAX = 0
                    .AMOUNT = 0
                    .GUARANTEE = ""
                    .QUALITY = ""
                    .MARK = ""
                    .COMMENT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("GLOSA")), "", dtdetalleArticuloPrincipal.Rows(i).Item("GLOSA"))
                    .CURRENCY_ID = ""
                    .DISCOUNT = 0
                    .DLV_DATE = ""
                    .IS_VAT = ""
                    .PROJECT_ID = ""
                    .CC_ID = ""
                    .AREA_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("AREA")), "", dtdetalleArticuloPrincipal.Rows(i).Item("AREA"))
                    .REQUI_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("NUMERO_REQUERIMIENTO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("NUMERO_REQUERIMIENTO"))
                    .REQUI_TYPE = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_REQUERIMIENTO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_REQUERIMIENTO"))
                End With
                ls_det.Add(detallePQ)
            Next

            ''GUARDANDO DATOS DE LA SOLICITUD DE COTIZACION
            Dim Ref_Num_Sol_Cot As String = ""
            If clsFacturaBl.GuardandoPurchaseQuote(cabeceraPQ, ls_det, dtProveedorPrincipal, Ref_Num_Sol_Cot) = False Then
                MsgBox("Hubo un Error en la Generacion de la Solicitud de Cotización", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            Else
                If MsgBox("Desea imprimir la Solicitud de Cotización?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    imprimirFacturacion(Ref_Num_Sol_Cot, "SC")
                End If
            End If
        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function
    Private Function Guardar_ActCotizacion() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera Act. Cotizacion
            clsFacturaBl = New ClsOperaciones.USUARIO
            cabeceraPQ = New ClsEntidades.PURCHASE_QUOTE
            ls_det = New List(Of ClsEntidades.PURCHASE_QUOTE_LINE)

            With cabeceraPQ
                .ID = txtnumero_reg.Text
                .DOCUMENT_DATE = dtfecha_reg.Value.ToString("dd/MM/yyyy")
                .VENDOR_ID = txtcod_proveedor_Reg.Text
                .CURRENCY_ID = IIf(cmbmoneda_cotizacion_reg.SelectedIndex = 0, "MN", "ME")
                .COMMENT = ""
                .COMMENT_COT = txtobservaciones_reg.Text
                .QUOTE_DATE = dtfecha_cotizacion_reg.Value.ToString("dd/MM/yyyy")
                .SCTIPCAM = LibComunVar.ClsVarComun.TCVenta
                .SCVALIDEZ = txtvo_cotizacion_reg.Text
                .SCTIEMENT = txtte_cotizacion_reg.Text
                .SCFORPAG = txtfp_cotizacion_reg.Text
                .SCNCOTIZ = txtnum_cotizacion_reg.Text
                .CREATE_DATE = Date.Now
                .UPDATE_DATE = Date.Now
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PROJECT_ID = ""
                .STATUS = "AC"
            End With
            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detallePQ = New ClsEntidades.PURCHASE_QUOTE_LINE
                With detallePQ
                    .ID = txtnumero_reg.Text
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO"))
                    .PART_DESCRIPTION = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION")), "", dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION"))
                    .UNIT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD")), "", dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD"))
                    .QTY = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                    .PRICE = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("PRECIO"))
                    .AMOUNT_TAX = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("IGV")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("IGV"))
                    .AMOUNT = 0
                    .GUARANTEE = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("GARANTIA")), "", dtdetalleArticuloPrincipal.Rows(i).Item("GARANTIA"))
                    .QUALITY = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CALIDAD")), "", dtdetalleArticuloPrincipal.Rows(i).Item("CALIDAD"))
                    .MARK = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("MARCA_MODELO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("MARCA_MODELO"))
                    .COMMENT = ""
                    .CURRENCY_ID = cmbmoneda_cotizacion_reg.Text
                    .DISCOUNT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("DESCUENTO")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("DESCUENTO"))
                    .DLV_DATE = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("FECHA_ENTREGA")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("FECHA_ENTREGA"))
                    .IS_VAT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("IS_VAT")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("IS_VAT"))
                    .PROJECT_ID = ""
                    .CC_ID = ""
                    .AREA_ID = ""
                    .REQUI_ID = ""
                End With
                ls_det.Add(detallePQ)
            Next

            ''GUARDANDO DATOS DE ACTUALIZACION DE COTIZACION
            If clsFacturaBl.Guardando_ActCotizacion(cabeceraPQ, ls_det) = False Then
                MsgBox("Hubo un Error en la Actualización de la Cotización", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If
        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function
    Private Function Actualizacion_Solicitud_Cotizacion() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            clsFacturaBl = New ClsOperaciones.USUARIO
            cabeceraPQ = New ClsEntidades.PURCHASE_QUOTE
            ls_det = New List(Of ClsEntidades.PURCHASE_QUOTE_LINE)

            With cabeceraPQ
                .ID = txtnumero.Text
                .DOCUMENT_DATE = dtfecha.Value.ToString("dd/MM/yyyy")
                .VENDOR_ID = txtcod_proveedor.Text
                .CURRENCY_ID = ""
                .COMMENT = ""
                .COMMENT_COT = txtobservacionesgenerales.Text
                .QUOTE_DATE = dtfecha.Value.ToString("dd/MM/yyyy")
                .SCTIPCAM = LibComunVar.ClsVarComun.TCVenta
                .SCVALIDEZ = ""
                .SCTIEMENT = ""
                .SCFORPAG = ""
                .SCNCOTIZ = ""
                .CREATE_DATE = Date.Now
                .UPDATE_DATE = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PROJECT_ID = ""
                .STATUS = "P"
            End With
            'Detalle de Factura
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                detallePQ = New ClsEntidades.PURCHASE_QUOTE_LINE
                With detallePQ
                    .ID = txtnumero.Text
                    .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM")
                    .PART_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO"))
                    .PART_DESCRIPTION = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION")), "", dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION"))
                    .UNIT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD")), "", dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD"))
                    .QTY = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD")), 0, dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD"))
                    .PRICE = 0
                    .AMOUNT_TAX = 0
                    .AMOUNT = 0
                    .GUARANTEE = ""
                    .QUALITY = ""
                    .MARK = ""
                    .COMMENT = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("GLOSA")), "", dtdetalleArticuloPrincipal.Rows(i).Item("GLOSA"))
                    .CURRENCY_ID = ""
                    .DISCOUNT = 0
                    .DLV_DATE = ""
                    .IS_VAT = ""
                    .PROJECT_ID = ""
                    .CC_ID = ""
                    .AREA_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("AREA")), "", dtdetalleArticuloPrincipal.Rows(i).Item("AREA"))
                    .REQUI_ID = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("NUMERO_REQUERIMIENTO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("NUMERO_REQUERIMIENTO"))
                    .REQUI_TYPE = IIf(IsDBNull(dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_REQUERIMIENTO")), "", dtdetalleArticuloPrincipal.Rows(i).Item("TIPO_REQUERIMIENTO"))
                End With
                ls_det.Add(detallePQ)
            Next

            ''GUARDANDO DATOS DE LA SOLICITUD DE COTIZACION
            If clsFacturaBl.ActualizandoPurchaseQuote(cabeceraPQ, ls_det) = False Then
                MsgBox("Hubo un Error en la Generacion de la Solicitud de Cotización", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If
        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function
    Private Sub imprimirFacturacion(ByVal _NUMBER_DOCUMENT As String, ByVal _tipo_estado As String)
        Try
            reporteBL = New ClsOperaciones.USUARIO
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Dim STRmontotexto As String = String.Empty

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.get_Imprimir_Sol_cotizacion(_NUMBER_DOCUMENT, _tipo_estado)
            If dtImprimir.Rows.Count() <> 0 Then
                If _tipo_estado = "SC" Then
                    crystalBL.Muestra_Reporte("rpt_Impresion_Sol_Cotizacion.rpt", dtImprimir, "", "", "@NUMERO;" & _NUMBER_DOCUMENT, "@TIPO;" & _tipo_estado)
                ElseIf _tipo_estado = "CT" Then
                    crystalBL.Muestra_Reporte("rpt_Impresion_Act_Cotizacion.rpt", dtImprimir, "", "", "@NUMERO;" & _NUMBER_DOCUMENT, "@TIPO;" & _tipo_estado)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim codigo As String, tipo_estado As String
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        codigo = dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value
        tipo_estado = dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value
        If tipo_estado = "EMITIDO" Then
            imprimirFacturacion(codigo, "SC")
        ElseIf tipo_estado = "COTIZACION ACT." Then
            imprimirFacturacion(codigo, "CT")
        ElseIf tipo_estado = "ANULADO" Then
            MsgBox("La Sol. de Cotización se encuentra Anulado, no se puede imprimir.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msj As String, numero_documento As String
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        numero_documento = IIf(IsDBNull(dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value)
        If ValidacionConsultas(numero_documento) = False Then
            MsgBox("No procede la eliminación por encontrarse en un estado superior al de EMITIDO.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        numero_documento = IIf(IsDBNull(dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value)
        If MessageBox.Show("¿Desea Eliminar la Solicitud de Cotización N°: " & numero_documento & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            If EliminarFacturas(numero_documento) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Eliminacion", MsgBoxStyle.Information)
                Exit Sub
            End If
            msj = String.Empty
            msj = "Documento Eliminado Correctamente." & vbCrLf & " Solicitud de Cotización N°: " & numero_documento
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            DocumentosSolicitudCotizacion()
        End If
    End Sub
    Private Function EliminarFacturas(ByVal _numero_documento As String) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            clsFacturaBl.EliminacionSolCotizacion(_numero_documento)
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Function AnularSolicitudCotizacion(ByVal _numero_documento As String) As Boolean
        Dim estado As Boolean = True
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            clsFacturaBl.AnularSolCotizacion(_numero_documento)
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Function ValidacionConsultas(ByRef _estado As String) As Boolean
        Dim estado As Boolean = False
        Try
            If _estado = String.Empty Or _estado = "EMITIDO" Then
                estado = True
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim codigo_documento As String, numero_documento_anulacion As String
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        numero_documento_anulacion = IIf(IsDBNull(dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value)
        If numero_documento_anulacion = "ANULADO" Then
            MsgBox("No se puede modificar la Solicitud de Cotización por estar en el estado ANULADO.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        Nuevo()
        Modo_consultar = True
        codigo_documento = dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value.ToString
        MostrarModoConsultar(codigo_documento)
        Botonera_Estado_Cambiar(True)
        pnl_prov.Visible = False
        btn_agregar_requisicion.Visible = False
        Label2.Visible = True
        txtnumero.Visible = True
        If numero_documento_anulacion = "EMITIDO" Then
            btnGrabar.Enabled = True
        Else
            btnGrabar.Enabled = False
        End If
    End Sub

    Private Sub MostrarModoConsultar(ByVal codigo_documento As String)
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            DTCABECERAPQ = New DataTable
            DTDETALLEPQ = New DataTable
            '---Mostrando Datos de Cabecera
            DTCABECERAPQ = clsFacturaBl.DatosGeneralesSolicitudCotizacion_Cabecera(codigo_documento)
            If DTCABECERAPQ.Rows.Count() <> 0 Then
                For i As Integer = 0 To DTCABECERAPQ.Rows.Count() - 1
                    txtnumero.Text = DTCABECERAPQ.Rows(i).Item("ID").ToString
                    txtcod_proveedor.Text = DTCABECERAPQ.Rows(i).Item("VENDOR_ID").ToString
                    txtrazon_proveedor.Text = DTCABECERAPQ.Rows(i).Item("NAME").ToString
                    txtruc.Text = DTCABECERAPQ.Rows(i).Item("VAT_REGISTRATION").ToString
                    txtobservacionesgenerales.Text = DTCABECERAPQ.Rows(i).Item("COMMENT_COT").ToString
                    dtfecha.Value = DTCABECERAPQ.Rows(i).Item("DOCUMENT_DATE").ToString
                Next
                
                '---Mostrando datos del Detalle
                clsFacturaBl = New ClsOperaciones.USUARIO
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = clsFacturaBl.DatosGeneralesSolicitudCotizacion_Detalle(codigo_documento)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModo_ActualizarCotizacion(ByVal codigo_documento As String)
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            DTCABECERAPQ = New DataTable
            DTDETALLEPQ = New DataTable
            '---Mostrando Datos de Cabecera
            DTCABECERAPQ = clsFacturaBl.DatosGeneralesSolicitudCotizacion_Cabecera(codigo_documento)
            If DTCABECERAPQ.Rows.Count() <> 0 Then
                For i As Integer = 0 To DTCABECERAPQ.Rows.Count() - 1
                    txtnumero_reg.Text = DTCABECERAPQ.Rows(i).Item("ID").ToString
                    txtcod_proveedor_Reg.Text = DTCABECERAPQ.Rows(i).Item("VENDOR_ID").ToString
                    txtproveedor_reg.Text = DTCABECERAPQ.Rows(i).Item("NAME").ToString
                    txtobservaciones_reg.Text = DTCABECERAPQ.Rows(i).Item("COMMENT_COT").ToString
                    dtfecha_reg.Value = DTCABECERAPQ.Rows(i).Item("DOCUMENT_DATE").ToString

                    txtnum_cotizacion_reg.Text = IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("SCNCOTIZ").ToString), "", DTCABECERAPQ.Rows(i).Item("SCNCOTIZ").ToString)
                    dtfecha_cotizacion_reg.Value = CDate(IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("QUOTE_DATE").ToString), Date.Now, DTCABECERAPQ.Rows(i).Item("QUOTE_DATE").ToString))
                    cmbmoneda_cotizacion_reg.SelectedIndex = IIf(IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("CURRENCY_ID").ToString), "MN", DTCABECERAPQ.Rows(i).Item("CURRENCY_ID").ToString) = "MN", 0, 1)
                    txtfp_cotizacion_reg.Text = IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("SCFORPAG").ToString), "", DTCABECERAPQ.Rows(i).Item("SCFORPAG").ToString)
                    txtfp_des_cotizacion_reg.Text = IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("CONCEPTO_FORMA_PAGO").ToString), "", DTCABECERAPQ.Rows(i).Item("CONCEPTO_FORMA_PAGO").ToString)
                    txtte_cotizacion_reg.Text = IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("SCTIEMENT").ToString), "", DTCABECERAPQ.Rows(i).Item("SCTIEMENT").ToString)
                    txtvo_cotizacion_reg.Text = IIf(IsDBNull(DTCABECERAPQ.Rows(i).Item("SCVALIDEZ").ToString), "", DTCABECERAPQ.Rows(i).Item("SCVALIDEZ").ToString)
                Next

                '---Mostrando datos del Detalle
                clsFacturaBl = New ClsOperaciones.USUARIO
                GenerarColummnaDataTable_Registro_Cotizacion()
                dtdetalleArticuloPrincipal = clsFacturaBl.DatosGenerales_Act_Coti_SolicitudCotizacion_Detalle(codigo_documento)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dgvdet_cotizacion_reg.DataSource = dtdetalleArticuloPrincipal
                Else
                    MsgBox("No hay detalles a Mostrar para este Documento.", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_agregar_requisicion.Click
        CONTROLES(True, 2)
        GenerarColummnaDataTableListaRequisiciones()
        Lista_de_Requisiones()
        dgvListaRequisiciones.Select()
    End Sub
    Private Sub Lista_de_Requisiones()
        Try
            clsFacturaBl = New ClsOperaciones.USUARIO
            dtDocumentosListaRequisicion = New DataTable
            dtDocumentosListaRequisicion = clsFacturaBl.DatosListaRequisiciones("RQ")
            dgvListaRequisiciones.DataSource = Nothing
            If dtDocumentosListaRequisicion.Rows.Count() <> 0 Then
                dgvListaRequisiciones.DataSource = dtDocumentosListaRequisicion
                dgvListaRequisiciones.Columns(0).Width = 40
                dgvListaRequisiciones.Columns(1).Width = 100
                dgvListaRequisiciones.Columns(2).Width = 100
                dgvListaRequisiciones.Columns(3).Width = 350
                dgvListaRequisiciones.Columns(4).Width = 300
                dgvListaRequisiciones.Columns(5).Width = 300
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTableListaRequisiciones()
        Try
            dtListaRequisiciones = New DataTable
            dtListaRequisiciones.Columns.Add("TIPO", Type.GetType("System.String"))
            dtListaRequisiciones.Columns.Add("NUMERO", Type.GetType("System.String"))
            dtListaRequisiciones.Columns.Add("FECHA", Type.GetType("System.String"))
            dtListaRequisiciones.Columns.Add("TITULO", Type.GetType("System.String"))
            dtListaRequisiciones.Columns.Add("AREA", Type.GetType("System.String"))
            dtListaRequisiciones.Columns.Add("SOLICITANTE", Type.GetType("System.String"))

            dgvListaRequisiciones.DataSource = Nothing
            dgvListaRequisiciones.DataSource = dtListaRequisiciones
            dgvListaRequisiciones.Columns(0).Width = 40
            dgvListaRequisiciones.Columns(1).Width = 100
            dgvListaRequisiciones.Columns(2).Width = 200
            dgvListaRequisiciones.Columns(3).Width = 1000
            dgvListaRequisiciones.Columns(4).Width = 400
            dgvListaRequisiciones.Columns(5).Width = 400
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarListaRequi_Click(sender As Object, e As EventArgs) Handles btnCancelarListaRequi.Click
        CONTROLES(True, 0)
        Formato_Grilla()
        dgvDetalle.Focus()
    End Sub

    Private Sub btnAceptarListaRequi_Click(sender As Object, e As EventArgs) Handles btnAceptarListaRequi.Click
        Dim _numero_requisicion As String, _tipo_requisicion As String, i As Integer
        If dgvListaRequisiciones.CurrentRow Is Nothing Then Exit Sub
        Try
            _numero_requisicion = dgvListaRequisiciones.Item(1, dgvListaRequisiciones.CurrentRow.Index).Value.ToString
            _tipo_requisicion = dgvListaRequisiciones.Item(0, dgvListaRequisiciones.CurrentRow.Index).Value.ToString
            clsFacturaBl = New ClsOperaciones.USUARIO
            dtDatosRequisicion = New DataTable
            dtDatosRequisicion = clsFacturaBl.DatosListaRequisicion_especifica(_numero_requisicion, _tipo_requisicion)
            If dtDatosRequisicion.Rows.Count() <> 0 Then
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    dtdetalleArticuloPrincipal.Rows.Clear()
                End If
                For i = 0 To dtDatosRequisicion.Rows.Count - 1
                    Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                    row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                    row("CODIGO") = dtDatosRequisicion.Rows(i).Item("CODIGO")
                    row("DESCRIPCION") = dtDatosRequisicion.Rows(i).Item("DESCRIPCION")
                    row("UNIDAD") = dtDatosRequisicion.Rows(i).Item("UNIDAD")
                    row("CANTIDAD") = dtDatosRequisicion.Rows(i).Item("CANTIDAD")
                    row("GLOSA") = dtDatosRequisicion.Rows(i).Item("GLOSA")
                    row("AREA") = dtDatosRequisicion.Rows(i).Item("AREA")
                    row("NUMERO_REQUERIMIENTO") = dtDatosRequisicion.Rows(i).Item("NUMERO_REQUERIMIENTO")
                    row("TIPO_REQUERIMIENTO") = dtDatosRequisicion.Rows(i).Item("TIPO_REQUERIMIENTO")
                    dtdetalleArticuloPrincipal.Rows.Add(row)
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                btnCancelarListaRequi_Click(sender, e)
            Else
            MsgBox("No existe datos para agregar a la Solicitud de Cotización.", MsgBoxStyle.Information, "Aviso")
            Exit Try
            Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtcod_proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_proveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtobservacionesgenerales.Focus()
    End Sub

    Private Sub txtobservaciones_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtobservaciones_articulo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btnAceptar.Focus()
    End Sub

    Private Sub txtcantidad_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad_articulo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtobservaciones_articulo.Focus()
    End Sub

    Private Sub dgvListaRequisiciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvListaRequisiciones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btnAceptarListaRequi.Focus()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim msj As String, numero_documento As String
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        numero_documento = IIf(IsDBNull(dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value)
        If numero_documento = "ANULADO" Then
            MsgBox("El documento se encuentra ANULADO!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        If ValidacionConsultas(numero_documento) = False Then
            MsgBox("No procede la Anulación por encontrarse en un estado superior al de EMITIDO.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        numero_documento = IIf(IsDBNull(dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value)
        If MessageBox.Show("¿Desea Anular la Solicitud de Cotización N°: " & numero_documento & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            If AnularSolicitudCotizacion(numero_documento) = False Then
                MsgBox("Hubo un error, no se completo el Proceso de Anulación", MsgBoxStyle.Information)
                Exit Sub
            End If
            msj = String.Empty
            msj = "Documento Anulado Correctamente." & vbCrLf & " Solicitud de Cotización N°: " & numero_documento
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            DocumentosSolicitudCotizacion()
        End If
    End Sub

    Private Sub btnact_coti_Click(sender As Object, e As EventArgs) Handles btnact_coti.Click
        Dim codigo_documento As String, numero_documento_anulacion As String
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub
        numero_documento_anulacion = IIf(IsDBNull(dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value), "", dgvDocumentosFactura.Item(5, dgvDocumentosFactura.CurrentRow.Index).Value)
        If numero_documento_anulacion = "ANULADO" Then
            MsgBox("No se puede modificar la Solicitud de Cotización por estar en el estado ANULADO.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        Modo_actualizar_cotizacion = True
        codigo_documento = dgvDocumentosFactura.Item(0, dgvDocumentosFactura.CurrentRow.Index).Value.ToString
        Botonera_Estado_Cambiar_Reg_Cotizacion(True)
        Nuevo_Registro_Cotizacion()
        CONTROLES_Reg_Cotizacion(True, 0)
        'tc_registro_coti.Location = New Point(4, 76)
        MostrarModo_ActualizarCotizacion(codigo_documento)
        txtnum_cotizacion_reg.Select()
    End Sub

    Private Sub btnmodificar_reg_Click(sender As Object, e As EventArgs) Handles btnmodificar_reg.Click
        If dgvdet_cotizacion_reg.CurrentRow Is Nothing Then Exit Sub
        Limpiar_Cotizacion_Detalle()
        CONTROLES_Reg_Cotizacion(True, 1)
        ModificandoArticulos_ActCotizacion()
        txtprecio_reg.Select()
    End Sub

    Private Sub btncancelar_Reg_Click(sender As Object, e As EventArgs) Handles btncancelar_Reg.Click
        CONTROLES_Reg_Cotizacion(True, 0)
        Formato_Grilla_Reg_Cotizacion()
        dgvdet_cotizacion_reg.Select()
    End Sub

    Private Sub txtprecio_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_reg.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then chkigvinc_reg.Focus()
    End Sub

    Private Sub txtigvpor_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtigvpor_reg.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then txtdescpor_reg.Focus()
    End Sub

    Private Sub txtdescpor_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescpor_reg.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then txtgarantia_reg.Focus()
    End Sub

    Private Sub txtfp_cotizacion_reg_DoubleClick(sender As Object, e As EventArgs) Handles txtfp_cotizacion_reg.DoubleClick
        Ayuda_Forma_Pago(txtfp_cotizacion_reg.Text)
    End Sub

    Private Sub txtfp_cotizacion_reg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfp_cotizacion_reg.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Forma_Pago()
        If e.KeyCode = Keys.Enter Then
            If txtfp_des_cotizacion_reg.Text = String.Empty Then
                Ayuda_Forma_Pago()
            Else
                Ayuda_Forma_Pago(txtfp_cotizacion_reg.Text)
            End If
        End If

    End Sub

    Private Sub txtfp_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfp_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtte_cotizacion_reg.Focus()
    End Sub

    Private Sub txtnum_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then dtfecha_cotizacion_reg.Focus()
    End Sub

    Private Sub dtfecha_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtfecha_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then cmbmoneda_cotizacion_reg.Focus()
    End Sub

    Private Sub cmbmoneda_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbmoneda_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtfp_cotizacion_reg.Focus()
    End Sub

    Private Sub txtte_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtte_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtvo_cotizacion_reg.Focus()
    End Sub

    Private Sub txtvo_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvo_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then dgvdet_cotizacion_reg.Focus()
    End Sub

    Private Sub dgvdet_cotizacion_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvdet_cotizacion_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btnmodificar_reg.Focus()
    End Sub

    Private Sub btnaceptar_reg_Click(sender As Object, e As EventArgs) Handles btnaceptar_reg.Click
        'Actualizo los datos de cotizacion
        For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _item)
            dtdetalleArticuloPrincipal.BeginInit()
            item("CODIGO") = txtcod_prod_reg.Text
            item("DESCRIPCION") = txtdes_pro_reg.Text
            item("CANTIDAD") = txtcantidad_reg.Text
            item("PRECIO") = txtprecio_reg.Text
            item("IGV") = txtigvpor_reg.Text
            item("DESCUENTO") = txtdescpor_reg.Text
            item("GARANTIA") = txtgarantia_reg.Text
            item("CALIDAD") = txtcalidad_reg.Text
            item("MARCA_MODELO") = txtmarca_reg.Text
            item("FECHA_ENTREGA") = CDate(dtfec_entrega_reg.Value).ToShortDateString
            item("IS_VAT") = IIf(chkigvinc_reg.Checked = True, "1", "0")
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
        btncancelar_Reg_Click(sender, e)
    End Sub

    Private Sub chkigvinc_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkigvinc_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtigvpor_reg.Focus()
    End Sub

    Private Sub txtgarantia_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgarantia_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtcalidad_reg.Focus()
    End Sub

    Private Sub txtcalidad_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcalidad_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtmarca_reg.Focus()
    End Sub

    Private Sub txtmarca_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmarca_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then dtfec_entrega_reg.Focus()
    End Sub

    Private Sub dtfec_entrega_reg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtfec_entrega_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btnaceptar_reg.Focus()
    End Sub

    Private Sub dtfecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtfecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtnumero.Focus()
    End Sub

    Private Sub ListadoProveedores()
        Try
            Dim Cotizacionbl As New ClsOperaciones.USUARIO
            Dim dtDocumentosProv As New DataTable
            dtv_proveedor = New DataView
            dtDocumentosProv = Cotizacionbl.Lista_Proveedores()
            dgv_lista_proveedor.DataSource = Nothing
            dtv_proveedor = dtDocumentosProv.DefaultView
            If dtDocumentosProv.Rows.Count() <> 0 Then
                dgv_lista_proveedor.DataSource = dtv_proveedor
                dgv_lista_proveedor.Columns(0).Width = 80
                dgv_lista_proveedor.Columns(1).Width = 210
                dgv_lista_proveedor.Columns(2).Width = 80

                dgv_lista_proveedor.Columns(0).HeaderText = "Codigo"
                dgv_lista_proveedor.Columns(1).HeaderText = "Proveedor"
                dgv_lista_proveedor.Columns(2).HeaderText = "Ruc"

                STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name & "+" & dgv_lista_proveedor.Columns(1).Name & "+" & dgv_lista_proveedor.Columns(2).Name
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = String.Empty Then
            dtv_proveedor.RowFilter = String.Empty
            Exit Sub
        Else
            dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
            If dtv_proveedor.Count() = 0 Then
                STRorden_proveedor = String.Empty
                STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name
                dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                If dtv_proveedor.Count() = 0 Then
                    STRorden_proveedor = String.Empty
                    STRorden_proveedor = dgv_lista_proveedor.Columns(1).Name
                    dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                    If dtv_proveedor.Count() = 0 Then
                        STRorden_proveedor = String.Empty
                        STRorden_proveedor = dgv_lista_proveedor.Columns(0).Name & "+" & dgv_lista_proveedor.Columns(1).Name & "+" & dgv_lista_proveedor.Columns(2).Name
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub btn_agregar_proveedor_Click(sender As Object, e As EventArgs) Handles btn_agregar_proveedor.Click
        CONTROLES(True, 3)
        ListadoProveedores()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        CONTROLES(True, 0)
    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click

        Dim _ID As String = ""
        Dim _NAME As String = ""
        Dim _VAT_REGISTRATION As String = ""
        _ID = dgv_lista_proveedor.Item(0, dgv_lista_proveedor.CurrentRow.Index).Value
        _NAME = dgv_lista_proveedor.Item(1, dgv_lista_proveedor.CurrentRow.Index).Value
        _VAT_REGISTRATION = dgv_lista_proveedor.Item(2, dgv_lista_proveedor.CurrentRow.Index).Value
        'Validaciones
        If dtProveedorPrincipal.Rows.Count() <> 0 Then
            Dim Resultado() As DataRow
            Resultado = dtProveedorPrincipal.Select("ID='" & _ID & "' and NAME='" & _NAME & "' and VAT_REGISTRATION='" & _VAT_REGISTRATION & "' ", "")
            If Resultado.Count() <> 0 Then
                'MsgBox("El documento ya se ingreso anteriormente.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Dim row As DataRow = dtProveedorPrincipal.NewRow
        row("ITEM") = dtProveedorPrincipal.Rows.Count() + 1
        row("ID") = _ID
        row("NAME") = _NAME
        row("VAT_REGISTRATION") = _VAT_REGISTRATION
        dtProveedorPrincipal.Rows.Add(row)
        dtProveedorPrincipal.AcceptChanges()
        If dtProveedorPrincipal.Rows.Count() <> 0 Then
            configurarGrilla()
        End If
        dgv_lista_proveedor.Focus()
    End Sub


    Private Sub RehacerCorrelativo()
        Dim i As Integer = 0
        For Each items As DataRow In dtProveedorPrincipal.Rows
            i += 1
            dtProveedorPrincipal.BeginInit()
            items("ITEM") = i
            dtProveedorPrincipal.EndInit()
            dtProveedorPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        Try
            If dgv_proveedor.CurrentRow Is Nothing Then
                dgv_proveedor.Focus()
            End If
            If dtProveedorPrincipal.Rows.Count = 0 Then Exit Sub
            Dim Codigo As String = String.Empty
            Codigo = dgv_proveedor.Item(0, dgv_proveedor.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtProveedorPrincipal.Select("ITEM=" & Codigo)
                dtProveedorPrincipal.BeginInit()
                item.Delete()
                dtProveedorPrincipal.EndInit()
                dtProveedorPrincipal.AcceptChanges()
            Next
            RehacerCorrelativo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        CONTROLES(True, 0)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class