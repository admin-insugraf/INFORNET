Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmControl_Liberacion

    Private edicion As Boolean
    Private _tipoMov As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String
    Public flag_modificacion As Integer = 0

    Friend _indice_grilla As String
    Friend _codigo_articulo As String
    Friend _descripcion_articulo As String
    Friend _unidad_medida As String
    Friend _lote As String
    Friend _fecha_vencimiento As Date
    Friend _numero_protocolo As String
    Friend _cantidad As Double
    Friend _numero_bultos As Double
    Friend _valora As Double
    Friend _opt_final_parcial As String
    Friend _numero_analisis As String
    Friend _procedencia_texto As String
    Friend _pais_origen_texto As String
    Public FechaPrincipal As String = String.Empty

    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenCabBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim dtTransaccionTipo As DataTable
    

    Dim clsAlmacenCorrelativoBl As ClsTransacciones.clsAlmacenCorrelativo

    Dim dtv As DataView
    Dim STRorden As String
    Dim dtData As DataTable
    Dim Modo_consultar As Boolean = False

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleBultosPrincipal As DataTable

    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim Fl_close As Boolean = False

    Dim clsBusquedaBl As ClsBuscar
    Dim TipoArticulo As String
    Dim PerteneceGuiaAnalisis As Boolean = False
    

    Dim _DIRECCION As String = String.Empty
    Dim _RUC As String = String.Empty
    Dim _STATUS_GUIA As String = String.Empty
    Dim _ACCOUNT As String = String.Empty

    Dim Ref_idalamacen As String = String.Empty
    Dim Ref_documentid As String = String.Empty
    Dim Ref_numerodocument As String = String.Empty

    Dim almacen_destino As String = String.Empty
    Dim almacen_destino_nombre As String = String.Empty
    Dim mensaje_final As String = String.Empty
    Public _Estado As String = String.Empty


    Public Property TipoMov() As String
        Get
            Return _tipoMov
        End Get
        Set(value As String)
            _tipoMov = value
            If _tipoMov = "I" Then
                chkValorizado.Visible = False
            End If
        End Set
    End Property

    Public Property documentId() As String
        Get
            Return _documentId
        End Get
        Set(value As String)
            _documentId = value
        End Set
    End Property




    Public Property ModoEdicion() As Boolean
        Get
            Return _ModoEdicion
        End Get
        Set(value As Boolean)
            _ModoEdicion = value
            If _ModoEdicion = True Then
            End If
        End Set
    End Property

    Public Property idAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(value As String)
            _idAlmacen = value
        End Set
    End Property



    Public Property NumeroDocumento() As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            _NumeroDocumento = value
        End Set
    End Property

    Public Property Data_Matriz() As DataTable
        Get
            Return dtdetalleBultosPrincipal
        End Get
        Set(ByVal Value As DataTable)
            dtdetalleBultosPrincipal = Value
        End Set
    End Property

    'Private Sub MostrandoTipoTransacciones()
    '    Try
    '        If ModoEdicion = True Then Exit Sub
    '        MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
    '        Dim CodigoTransaccion As String = String.Empty
    '        CodigoTransaccion = cboTipoMovimiento.SelectedValue.ToString
    '        MostrarMovimientoBl.Get_TipoTransacciones(TipoMov, CodigoTransaccion)
    '        'Valorizado
    '        If MostrarMovimientoBl.IS_VALUED = "F" Then
    '            chkValorizado.Visible = False
    '        ElseIf MostrarMovimientoBl.IS_VALUED = "V" Then
    '            chkValorizado.Visible = True
    '            chkValorizado.Checked = False
    '        End If
    '        If MostrarMovimientoBl.IS_CUSTOMER = "N" Then
    '            txtcodigoTercero.Enabled = False
    '            lbltercero.Text = String.Empty
    '            txtcodigoTercero.Text = String.Empty
    '            txtcodigoTercero.BackColor = Drawing.Color.White
    '            txtcodigoTercero.ForeColor = Drawing.Color.Black
    '        ElseIf MostrarMovimientoBl.IS_CUSTOMER = "S" Then
    '            txtcodigoTercero.Enabled = True
    '            lbltercero.Text = String.Empty
    '            txtcodigoTercero.Text = String.Empty
    '            txtcodigoTercero.BackColor = Drawing.Color.Aquamarine
    '            txtcodigoTercero.ForeColor = Drawing.Color.Black
    '        End If
    '        If MostrarMovimientoBl.IS_VENDOR = "N" Then
    '            txtcodigoProveedor.Enabled = False
    '            lblproveedor.Text = String.Empty
    '            txtcodigoProveedor.Text = String.Empty
    '            txtcodigoProveedor.BackColor = Drawing.Color.White
    '            txtcodigoProveedor.ForeColor = Drawing.Color.Black
    '        ElseIf MostrarMovimientoBl.IS_VENDOR = "S" Then
    '            txtcodigoProveedor.Enabled = True
    '            lblproveedor.Text = String.Empty
    '            txtcodigoProveedor.Text = String.Empty
    '            txtcodigoProveedor.BackColor = Drawing.Color.Aquamarine
    '            txtcodigoProveedor.ForeColor = Drawing.Color.Black
    '        End If
    '        'Centro de Costo
    '        If MostrarMovimientoBl.IS_CCOST = "N" Then
    '            cbocentroCosto.Enabled = False
    '        ElseIf MostrarMovimientoBl.IS_CCOST = "S" Then
    '            cbocentroCosto.Enabled = True
    '        End If
    '        ' Almacen   
    '        If MostrarMovimientoBl.WHO_ID = String.Empty Then
    '            CboAlmacen.Enabled = True
    '            CboAlmacen.SelectedIndex = 0
    '            CboAlmacen.BackColor = Drawing.Color.Aquamarine
    '            CboAlmacen.ForeColor = Drawing.Color.Black
    '        Else
    '            If CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID Then
    '                CboAlmacen.Enabled = False
    '                CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID
    '                CboAlmacen.BackColor = Drawing.Color.White
    '                CboAlmacen.ForeColor = Drawing.Color.Black
    '            Else
    '                'Cargar_Almacen()
    '                CboAlmacen.SelectedIndex = 0
    '                CboAlmacen.Enabled = False
    '                CboAlmacen.BackColor = Drawing.Color.White
    '                CboAlmacen.ForeColor = Drawing.Color.Black
    '                MsgBox("Para este Tipo de Transaccion, usted no tiene Acceso.", MsgBoxStyle.Information)
    '            End If
    '        End If
    '        ' tipo Doc Ref   
    '        If MostrarMovimientoBl.IS_DOC_REF = "N" Then
    '            txtTipoDocumentoRef.Enabled = False
    '            txtNumeroReferencia.Enabled = False
    '            txtTipoDocumentoRef.Text = String.Empty
    '            txtNumeroReferencia.Text = String.Empty
    '            txtTipoDocumentoRef.BackColor = Drawing.Color.White
    '            txtNumeroReferencia.BackColor = Drawing.Color.White
    '            txtTipoDocumentoRef.ForeColor = Drawing.Color.White
    '            txtNumeroReferencia.ForeColor = Drawing.Color.White
    '        ElseIf MostrarMovimientoBl.IS_DOC_REF = "S" Then
    '            txtNumeroReferencia.Enabled = True
    '            txtTipoDocumentoRef.Enabled = True
    '            txtTipoDocumentoRef.Text = String.Empty
    '            txtNumeroReferencia.Text = String.Empty
    '            txtTipoDocumentoRef.BackColor = Drawing.Color.Aquamarine
    '            txtTipoDocumentoRef.ForeColor = Drawing.Color.Black
    '            txtNumeroReferencia.BackColor = Drawing.Color.Aquamarine
    '            txtNumeroReferencia.ForeColor = Drawing.Color.Black
    '        End If
    '        'Orden de compra
    '        If MostrarMovimientoBl.IS_ORDER_PURCHASE = "N" Then
    '            txtordenCompra.Enabled = False
    '            txtordenCompra.Text = String.Empty
    '            txtordenCompra.BackColor = Drawing.Color.White
    '            txtordenCompra.ForeColor = Drawing.Color.Black
    '        ElseIf MostrarMovimientoBl.IS_ORDER_PURCHASE = "S" Then
    '            txtordenCompra.Enabled = True
    '            txtordenCompra.Text = String.Empty
    '            txtordenCompra.BackColor = Drawing.Color.Aquamarine
    '            txtordenCompra.ForeColor = Drawing.Color.Black
    '        End If
    '        'Orden de Fabricacion
    '        If MostrarMovimientoBl.IS_ORDER_MANUFACT = "N" Then
    '            txtorderFabricacion.Enabled = False
    '            txtorderFabricacion.Text = String.Empty
    '            txtorderFabricacion.BackColor = Drawing.Color.White
    '            txtorderFabricacion.ForeColor = Drawing.Color.Black
    '        ElseIf MostrarMovimientoBl.IS_ORDER_MANUFACT = "S" Then
    '            txtorderFabricacion.Enabled = True
    '            txtorderFabricacion.Text = String.Empty
    '            txtorderFabricacion.BackColor = Drawing.Color.Aquamarine
    '            txtorderFabricacion.ForeColor = Drawing.Color.Black
    '        End If
    '        'Tipo Articulo 
    '        TipoArticulo = String.Empty
    '        TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
    '        'Generacion de Guia de Analisis
    '        If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
    '            PerteneceGuiaAnalisis = True
    '        ElseIf MostrarMovimientoBl.IS_GUIA_ANALISIS = "N" Then
    '            PerteneceGuiaAnalisis = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub TransaccionesTipos()
        Try
            clsTransaccionTipoBl = New ClsOperaciones.TRANSACTION_TYPE
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_InventarioTransaccionesTipo("I")
            Dim row As DataRow = dtTransaccionTipo.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            dtTransaccionTipo.Rows.InsertAt(row, 0)
            If dtTransaccionTipo.Rows.Count() <> 0 Then
                cboTipoMovimiento.DataSource = dtTransaccionTipo
                cboTipoMovimiento.DisplayMember = "DESCRIPCION"
                cboTipoMovimiento.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Almacen()
        almacenBL = New ClsOperaciones.WAREHOUSE
        dtAlmacen = New DataTable
        dtAlmacen = almacenBL.get_Almacenes_Ayuda(LibComunVar.ClsVarComun.AccesoAlmacenes)
        Dim row As DataRow = dtAlmacen.NewRow()
        row.Item("CODIGO") = ""
        row.Item("DESCRIPCION") = "(-SELECCIONE-)"
        dtAlmacen.Rows.InsertAt(row, 0)
        CboAlmacen.DataSource = dtAlmacen
        CboAlmacen.DisplayMember = "DESCRIPCION"
        CboAlmacen.ValueMember = "CODIGO"
        almacenBL = Nothing
    End Sub

    Private Sub TipoDocumento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtTipoDocumentoRef.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            'lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
        txtNumeroReferencia.Focus()
    End Sub

    Private Sub Ayuda_Proveedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_VENDOR_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoProveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblproveedor.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _RUC = String.Empty
                _DIRECCION = String.Empty
                _RUC = frm.Data_Matriz.Rows(0).Item(2).ToString
                _DIRECCION = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Cliente()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoTercero.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbltercero.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _RUC = String.Empty
                _DIRECCION = String.Empty
                _RUC = frm.Data_Matriz.Rows(0).Item(2).ToString
                _DIRECCION = frm.Data_Matriz.Rows(0).Item(3).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BultosGenerarColummnaDataTable()
        dtdetalleBultosPrincipal = New DataTable
        dtdetalleBultosPrincipal.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleBultosPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_BULTOS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    

    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataTable, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = TablaOrigen.Rows(i).Item("PART_ID")
                row("LOTE") = TablaOrigen.Rows(i).Item("LOTE")
                row("ITEM") = i + 1
                row("QTY") = TablaOrigen.Rows(i).Item("QTY")
                row("QTY_BULTOS") = TablaOrigen.Rows(i).Item("QTY_BULTOS")
                row("IDENTIFICADOR") = indice
                dtdetalleBultosPrincipal.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub cmbTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimiento.SelectedIndexChanged
        If cboTipoMovimiento.Items.Count() <> 0 Then
            If cboTipoMovimiento.SelectedIndex = 0 Then
                GbCabecera.Enabled = False
                GbdetalleDocumento.Enabled = False
                gbOpciones.Enabled = False
            Else
                GbCabecera.Enabled = True
                GbdetalleDocumento.Enabled = True
                gbOpciones.Enabled = True
                ' MostrandoTipoTransacciones()
            End If
        End If
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub FrmInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TransaccionesTipos()
        Cargar_Almacen()
        Cargar_Moneda()
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        cboEstados.SelectedIndex = 0
        cboopcionesBusqueda.SelectedIndex = 0
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub txtTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocumentoRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            TipoDocumento()
        End If
    End Sub

    Private Sub txtTipoDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDocumentoRef.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtTipoDocumentoRef.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTipoDocumento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDocumentoRef.MouseDoubleClick
        TipoDocumento()
    End Sub

    Private Sub txtcodigoProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoProveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor()
        End If
    End Sub

    Private Sub txtcodigoTercero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoTercero.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente()
        End If
    End Sub

    Private Sub txtcodigoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoProveedor.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtcodigoProveedor.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcodigoTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoTercero.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtcodigoTercero.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcodigoProveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoProveedor.MouseDoubleClick
        Ayuda_Proveedor()
    End Sub

    Private Sub txtcodigoTercero_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoTercero.MouseDoubleClick
        Ayuda_Cliente()
    End Sub

    Private Function ValidarAgregacion() As Boolean
        Dim res As Boolean = True
        Dim msg As String = String.Empty
        Try
            Dim controles As Control = GbCabecera
            For Each ctrl As Control In controles.Controls
                'si es Label continuar
                If TypeOf (ctrl) Is Label Then Continue For
                '---------
                If TypeOf (ctrl) Is TextBox Then
                    '---validando Cajas de Texto
                    If ctrl.Enabled = True Then
                        If ctrl.Text = String.Empty Then
                            msg = "Es necesario ingresar: " & ctrl.Tag
                            MsgBox(msg, MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                ElseIf TypeOf (ctrl) Is ComboBox Then
                    Dim combo As ComboBox = DirectCast(ctrl, ComboBox)
                    '---validando Combo  Box
                    If ctrl.Enabled = True Then
                        If ctrl.Text = "(-SELECCIONE-)" Then
                            MsgBox("Es necesario seleccionar al menos un item", MsgBoxStyle.Information)
                            ctrl.Focus()
                            res = False
                            Exit Try
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function


    Private Sub ActualizandoCorrelativoItem(ByVal DatatableDetalles As DataTable, ByVal DatatableColumna As String)
        'Actualizando Numeracion
        Dim ident As String = String.Empty
        Dim lista As New List(Of String)
        For Each rows As DataRow In DatatableDetalles.Rows
            ident = rows(DatatableColumna)
            If lista.Contains(ident) = False Then
                lista.Add(ident)
                Continue For
            End If
        Next
        For i As Integer = 0 To lista.Count() - 1
            For Each items As DataRow In DatatableDetalles.Select(DatatableColumna & "=" & lista(i))
                DatatableDetalles.BeginInit()
                items(DatatableColumna) = i + 1
                DatatableDetalles.EndInit()
                DatatableDetalles.AcceptChanges()
            Next
        Next
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'If dgvdetalleAlmacen.CurrentRow Is Nothing Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        ModificandoArticulos()
    End Sub
    Private Sub ModificandoArticulos()
        Try
            'GbCabecera.Enabled = False
            Dim frmArticulo As New FrmControl_Liberacion_Modificar_Prod
            Dim lotes As String
            Dim Part_Id As String = String.Empty
            Part_Id = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value.ToString
            If Part_Id = String.Empty Then Exit Sub
            _indice_grilla = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.txtcodigoArticulo.Text = Part_Id
            frmArticulo.txtdescripcionArticulo.Text = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtunidadMedida.Text = dgvDetalle.Item(3, dgvDetalle.CurrentRow.Index).Value.ToString
            lotes = dgvDetalle.Item(9, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtlote.Text = lotes 'dgvDetalle.Item(9, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.btnNuevoLote.Enabled = False
            FechaPrincipal = String.Empty
            FechaPrincipal = dgvDetalle.Item(10, dgvDetalle.CurrentRow.Index).Value
            frmArticulo.dtpFechaVencimiento.Value = IIf(String.IsNullOrEmpty(dgvDetalle.Item(10, dgvDetalle.CurrentRow.Index).Value.ToString), Date.Now, dgvDetalle.Item(10, dgvDetalle.CurrentRow.Index).Value)
            frmArticulo.GroupBox7.Enabled = False
            frmArticulo.txtnumeroProtocolo.Text = dgvDetalle.Item(8, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtmonto.Enabled = False
            frmArticulo.txtcantidad.Text = dgvDetalle.Item(5, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtnumerobultos.Text = dgvDetalle.Item(6, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtvaloracion.Text = dgvDetalle.Item(13, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.rbfinal.Checked = IIf(dgvDetalle.Item(13, dgvDetalle.CurrentRow.Index).Value.ToString = "Final", True, False)
            frmArticulo.rbparcial.Checked = IIf(dgvDetalle.Item(13, dgvDetalle.CurrentRow.Index).Value.ToString = "Parcial", True, False)
            frmArticulo.txtnumanalisis.Text = dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value.ToString
            _procedencia_texto = dgvDetalle.Item(11, dgvDetalle.CurrentRow.Index).Value.ToString
            _pais_origen_texto = dgvDetalle.Item(12, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.txtcomentarios.Text = dgvDetalle.Item(14, dgvDetalle.CurrentRow.Index).Value.ToString
            frmArticulo.GroupBox1.Enabled = False
            frmArticulo.GroupBox5.Enabled = False
            frmArticulo.GroupBox4.Enabled = False
            frmArticulo.txtnumeroProtocolo.Enabled = False
            frmArticulo.txtcantidad.Enabled = False
            frmArticulo.txtnumerobultos.Enabled = False
            frmArticulo.txtnumanalisis.Enabled = False
            Dim AlmacenBl As New ClsOperaciones.WAREHOUSE_TRANS
            Dim dtTipoArt As New DataTable
            dtTipoArt = AlmacenBl.Mostrando_Tipo_Articulo(Part_Id)
            If dtTipoArt.Rows.Count() <> 0 Then
                frmArticulo.TipoArticulo = dtTipoArt.Rows(0).Item("CODIGO_LIBERACION").ToString
            Else

            End If
            'Enviando datos seleccioandos a Modificar
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index)
                _codigo_articulo = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                dgvDetalle.Rows.Add(_indice_grilla, frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO"), _
                                    frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("NUMERO_ANALISIS"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("NUMERO_BULTOS"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("NUMERO_PROTOCOLO"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE"), _
                   FechaPrincipal, _
                   _procedencia_texto, _
                   _pais_origen_texto, _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("VALORACION"), _
                   frmArticulo.dtdetalleArticulo.Rows(0).Item("COMENTARIO"))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
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
                STRorden = dgvCabeceraAlmacen.Columns(3).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabeceraAlmacen.Columns(5).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabeceraAlmacen.Columns(3).Name & "+" & dgvCabeceraAlmacen.Columns(5).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        'Try
        '    If txtFiltro.Text = String.Empty Then
        '        dtv.RowFilter = String.Empty
        '        Exit Sub
        '    Else
        '        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        '        If dtv.Count() = 0 Then
        '            dtv.RowFilter = String.Empty
        '            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        '        End If
        '    End If
        '    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


    Private Sub MostrandoDatosGeneralesCabeceraAlmacen()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.Default
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.get_DatosGeneralesAlmacen_E_S_Control(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                         cboopcionesBusqueda.SelectedIndex, "S", "GA", LibComunVar.ClsVarComun.AccesoAlmacenes, cboEstados.Text)
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv
                dgvCabeceraAlmacen.Columns(0).HeaderText = "Cod. Almacen"
                dgvCabeceraAlmacen.Columns(1).HeaderText = "Des. Almacen"
                dgvCabeceraAlmacen.Columns(2).HeaderText = "T. G.A."
                dgvCabeceraAlmacen.Columns(3).HeaderText = "N° G.A."
                dgvCabeceraAlmacen.Columns(4).HeaderText = "Fecha G.A."
                dgvCabeceraAlmacen.Columns(5).HeaderText = "N° Ingreso"
                dgvCabeceraAlmacen.Columns(6).HeaderText = "Cod. Trans."
                dgvCabeceraAlmacen.Columns(7).HeaderText = "Des. Trans."
                dgvCabeceraAlmacen.Columns(8).HeaderText = "Des. Estado"
                dgvCabeceraAlmacen.AutoResizeColumns()
                dgvCabeceraAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvCabeceraAlmacen.Columns(3).Name & "+" & dgvCabeceraAlmacen.Columns(5).Name
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
            btnEliminar.Enabled = True
            btnGuiaAnalisis.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = False
            btnGuiaAnalisis.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
        End If
    End Sub

    Private Sub Limpiar()
        dtpFecha.Value = Now
        cboTipoMovimiento.SelectedIndex = 0
        CboAlmacen.SelectedIndex = 0
        txtTipoDocumentoRef.Text = String.Empty
        txtNumeroReferencia.Text = String.Empty
        cboMoneda.SelectedIndex = 0
        txtordenCompra.Text = String.Empty
        txtorderFabricacion.Text = String.Empty
        txtcodigoProveedor.Text = String.Empty
        lblproveedor.Text = String.Empty
        txtcodigoTercero.Text = String.Empty
        lbltercero.Text = String.Empty
        txtComentarios.Text = String.Empty
        almacen_destino = String.Empty
        almacen_destino_nombre = String.Empty
        mensaje_final = String.Empty
        txt_Tipo_Ref.Text = ""
        txt_Numero_Ref.Text = ""
        pnl_guia_analisis.Visible = False
        dtp_fecha_ref.Value = Today
        dtp_fecha_guia.Text = ""
        txt_tipo_guia.Text = ""
        txt_nro_guia.Text = ""

    End Sub

    Private Sub Nuevo()
        Try
            dgvCabeceraAlmacen.Visible = False
            pnlfiltros.Visible = False
            GbCabecera.Enabled = False
            gbOpciones.Enabled = False
            GbTransaccion.Enabled = True
            Limpiar()
            BultosGenerarColummnaDataTable()
            dgvDetalle.DataSource = Nothing
            dgvDetalle.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
    End Sub

    Private Function ValidacionGeneral(ByRef idalamacen As String, ByRef documentid As String, ByRef numerodocument As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            idalamacen = dgvCabeceraAlmacen.Item(0, dgvCabeceraAlmacen.CurrentRow.Index).Value
            documentid = dgvCabeceraAlmacen.Item(2, dgvCabeceraAlmacen.CurrentRow.Index).Value
            numerodocument = dgvCabeceraAlmacen.Item(3, dgvCabeceraAlmacen.CurrentRow.Index).Value
            'validacion
            If idalamacen = String.Empty Or documentid = String.Empty Or numerodocument = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Function FechaGuia(ByVal almacen As String, ByVal Tipo As String, ByVal numero As String) As Date
        Dim FechaGuias As Date
        Try
            clsAlmacenCabBl = New ClsOperaciones.WAREHOUSE_TRANS
            Dim dtFechaG As New DataTable
            dtFechaG = clsAlmacenCabBl.FechaGuiaAnalasis(almacen, Tipo, numero)
            FechaGuias = dtFechaG.Rows(0).Item(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FechaGuias
    End Function


    Private Sub MostrarModoEdicion(ByVal idAlmacen As String, ByVal documentId As String, ByVal NumeroDocument As String, ByVal ESTADO As String)
        Try
            clsAlmacenCabBl = New ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen_CONTROL(idAlmacen, documentId, NumeroDocument)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    'dtpFecha.Text = FechaGuia(idAlmacen, documentId, NumeroDocument)
                    txt_Tipo_Ref.Text = dtCabeceraAlm.Rows(i).Item("DOCUMENT_ID").ToString
                    txt_Numero_Ref.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_DOCUMENT").ToString
                    dtp_fecha_ref.Value = dtCabeceraAlm.Rows(i).Item("DATE_DOCUMENT").ToString
                    cboTipoMovimiento.SelectedValue = dtCabeceraAlm.Rows(i).Item("TRANS_ID").ToString
                    CboAlmacen.SelectedValue = dtCabeceraAlm.Rows(i).Item(0).ToString
                    txtTipoDocumentoRef.Text = dtCabeceraAlm.Rows(i).Item("DOC_ID_REF").ToString
                    txtNumeroReferencia.Text = dtCabeceraAlm.Rows(i).Item("NUM_ID_REF").ToString
                    txtorderFabricacion.Text = dtCabeceraAlm.Rows(i).Item("NUM_ORDER_MANUFACT").ToString
                    txtcodigoProveedor.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_ID").ToString
                    lblproveedor.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_NAME").ToString
                    txtcodigoTercero.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_ID").ToString
                    lbltercero.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("COMMENT").ToString
                    txtordenCompra.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_PURCHASE").ToString
                Next
                ''Guia de analisis
                'clsAlmacenCabBl = New ClsOperaciones.WAREHOUSE_TRANS
                'Dim dtGuia_Analisis As New DataTable
                'dtGuia_Analisis = clsAlmacenCabBl.Verificando_Guia_A(txt_Tipo_Ref.Text, txt_Numero_Ref.Text)
                ' If dtGuia_Analisis.Rows.Count() <> 0 Then
                pnl_guia_analisis.Visible = True
                txt_tipo_guia.Text = txt_Tipo_Ref.Text 'dtGuia_Analisis.Rows(0).Item(0).ToString
                txt_nro_guia.Text = txt_Numero_Ref.Text 'dtGuia_Analisis.Rows(0).Item(1).ToString
                dtp_fecha_guia.Text = dtp_fecha_ref.Value 'dtGuia_Analisis.Rows(0).Item(2).ToString
                'Else
                '   pnl_guia_analisis.Visible = False
                'End If
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen_CONTROL(idAlmacen, txt_Tipo_Ref.Text, txt_Numero_Ref.Text, ESTADO)
                'dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen_CONTROL(idAlmacen, txt_tipo_guia.Text, txt_nro_guia.Text, ESTADO
                dgvDetalle.DataSource = Nothing
                dgvDetalle.Rows.Clear()
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    Dim FechaIni As String = String.Empty
                    Dim Fechas As Date
                    'Dim _numero_analisis As Integer
                    'Dim _DT_NUMERO_ANALISIS As DataTable
                    '_DT_NUMERO_ANALISIS = clsAlmacenCabBl.ObteniendoNumeroAnalisis(dtpFecha.Value.Year.ToString)
                    'If _DT_NUMERO_ANALISIS.Rows.Count > 0 Then
                    '    _numero_analisis = Val(_DT_NUMERO_ANALISIS.Rows(0).Item("CORRELATIVO").ToString)
                    'End If
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        FechaIni = IIf(String.IsNullOrEmpty(dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO").ToString), "", dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO"))
                        If FechaIni <> String.Empty Then
                            Fechas = dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO")
                            FechaIni = Fechas.ToString("MMMM yyyy")
                        End If
                        'dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, Format(_numero_analisis + j, "00000"), dtDetalleAlm.Rows(j).Item("QTY").ToString, _<

                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                        dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                           dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, FechaIni, dtDetalleAlm.Rows(j).Item("PROCEDENCIA").ToString, dtDetalleAlm.Rows(j).Item("PAIS_ORIGEN").ToString, dtDetalleAlm.Rows(j).Item("VALORACION").ToString, "")
                    Next
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For i = 0 To dgvDetalle.Columns.Count - 1
                        dgvDetalle.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Next

                    dtpFecha.MinDate = FechaGuia(idAlmacen, documentId, NumeroDocument)

                Else
                    MsgBox("No se genero previamente la Guia de Analisis.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Recalcula_num_Analisis()
        _Estado = dgvCabeceraAlmacen.Item(8, dgvCabeceraAlmacen.CurrentRow.Index).Value
        _idAlmacen = dgvCabeceraAlmacen.Item(0, dgvCabeceraAlmacen.CurrentRow.Index).Value
        '---Mostrando datos del Detalle
        dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen_CONTROL(idAlmacen, txt_Tipo_Ref.Text, txt_Numero_Ref.Text, _Estado)
        dgvDetalle.DataSource = Nothing
        dgvDetalle.Rows.Clear()
        If dtDetalleAlm.Rows.Count() <> 0 Then
            Dim FechaIni As String = String.Empty
            Dim Fechas As Date
            Dim _numero_analisis As Integer
            Dim _DT_NUMERO_ANALISIS As DataTable
            _DT_NUMERO_ANALISIS = clsAlmacenCabBl.ObteniendoNumeroAnalisis(dtpFecha.Value.Year.ToString)
            If _DT_NUMERO_ANALISIS.Rows.Count > 0 Then
                _numero_analisis = Val(_DT_NUMERO_ANALISIS.Rows(0).Item("CORRELATIVO").ToString)
            End If
            For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                FechaIni = IIf(String.IsNullOrEmpty(dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO").ToString), "", dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO"))
                If FechaIni <> String.Empty Then
                    Fechas = dtDetalleAlm.Rows(j).Item("FECHA_VENCIMIENTO")
                    FechaIni = Fechas.ToString("MMMM yyyy")
                End If

                'dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                   dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, Format(_numero_analisis + j, "00000"), dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                   dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, FechaIni, dtDetalleAlm.Rows(j).Item("PROCEDENCIA").ToString, dtDetalleAlm.Rows(j).Item("PAIS_ORIGEN").ToString, dtDetalleAlm.Rows(j).Item("VALORACION").ToString, "")
            Next
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dtpFecha.MinDate = FechaGuia(idAlmacen, txt_Tipo_Ref.Text, txt_Numero_Ref.Text)
            ''Guia de analisis
            clsAlmacenCabBl = New ClsOperaciones.WAREHOUSE_TRANS
            Dim dtGuia_Analisis As New DataTable
            dtGuia_Analisis = clsAlmacenCabBl.Verificando_Guia_A(txt_Tipo_Ref.Text, txt_Numero_Ref.Text)
            If dtGuia_Analisis.Rows.Count() <> 0 Then
                pnl_guia_analisis.Visible = True
                txt_tipo_guia.Text = dtGuia_Analisis.Rows(0).Item(0).ToString
                txt_nro_guia.Text = dtGuia_Analisis.Rows(0).Item(1).ToString
                dtp_fecha_guia.Text = dtGuia_Analisis.Rows(0).Item(2).ToString
            Else
                pnl_guia_analisis.Visible = False
            End If
        Else
            MsgBox("No se genero previamente la Guia de Analisis.", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty

        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        _Estado = dgvCabeceraAlmacen.CurrentRow.Cells("estado").Value ' dgvCabeceraAlmacen.Item(8, dgvCabeceraAlmacen.CurrentRow.Index).Value
        Limpiar()
        MostrarModoEdicion(Ref_idalamacen, Ref_documentid, Ref_numerodocument, _Estado)
        If _Estado = "CUARENTENA" Then
            gbOpciones.Enabled = True
            btnGrabar.Enabled = True
            btnEliminar.Enabled = True
        Else
            gbOpciones.Enabled = False
            btnGrabar.Enabled = False
            btnEliminar.Enabled = False
        End If
        pnlfiltros.Visible = False
        dgvCabeceraAlmacen.Visible = False
        GbCabecera.Enabled = False
        GbTransaccion.Enabled = False
        GbdetalleDocumento.Enabled = True
        gbOpciones.Visible = True ' False
        btnAgregar.Enabled = False
        btnQuitar.Enabled = False
        gbCabceraDocumento.Enabled = True 'False
        dgvDetalle.Visible = True 'False
    End Sub


    Private Sub GenerarIngresoSalidaAlmacen(ByVal _Flag_Tipo As String)
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim ls_det_alm_ingreso As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim alm_cabBE_ingreso As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE_ingreso As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Dim CORRELATIVO_NS As String
            Dim CORRELATIVO_NI As String
            Dim msj As String = String.Empty
            msj = String.Empty

            Me.Cursor = Cursors.WaitCursor
            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, "S")
            CORRELATIVO_NS = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
            'la parte de almacen de la NS
            With alm_cabBE
                .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                .DOCUMENT_ID = "NS"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = dtpFecha.Value.ToShortDateString
                .TYPE_TRANS = "S"
                .TRANS_ID = "TD"
                .DOC_ID_REF = txt_Tipo_Ref.Text
                .NUM_ID_REF = txt_Numero_Ref.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = "20417180134" '_RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = "" 'txtcodigoProveedor.Text
                .VENDOR_NAME = "" 'lblproveedor.Text
                .CUSTOMER_ID = "JL0111" 'txtcodigoTercero.Text
                .CUSTOMER_NAME = "LABORATORIOS UNIDOS S.A." 'lbltercero.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cboMoneda.SelectedValue
                .CURRENCY_EXCHANGE = 0
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = cboTipoMovimiento.SelectedValue.ToString
                .WAREHOUSE_REF = ""
                .UPDATE_DATE = Date.Now()
                .NUM_ORDER_MANUFACT = txtorderFabricacion.Text
                .NUMBER_PURCHASE = txtordenCompra.Text
            End With
            'Detalle de la salida...
            For i = 0 To dgvDetalle.Rows.Count - 1
                alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE
                    .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                    .DOCUMENT_ID = "NS"
                    .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                    .ITEM = CInt(dgvDetalle.Rows(i).Cells(0).Value)
                    .PART_ID = dgvDetalle.Rows(i).Cells(1).Value
                    .QTY = IIf(String.IsNullOrEmpty(dgvDetalle.Rows(i).Cells(5).Value), 0, dgvDetalle.Rows(i).Cells(5).Value)
                    .QTY_DLV = 0
                    .QTY_REF = dgvDetalle.Rows(i).Cells(5).Value
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dgvDetalle.Rows(i).Cells(2).Value
                    .UNIT_PART = dgvDetalle.Rows(i).Cells(3).Value
                    .NUMBER_LOT = dgvDetalle.Rows(i).Cells(9).Value
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                    .STATUS_VALUE = False
                    .NUM_PROTOCOLOS = dgvDetalle.Rows(i).Cells(8).Value
                    .OPT_ENTREGA = IIf(dgvDetalle.Rows(i).Cells(7).Value = "Final", 0, 1)
                    .QT_BULTOS = IIf(IsDBNull(dgvDetalle.Rows(i).Cells(6).Value), 0, dgvDetalle.Rows(i).Cells(6).Value)
                    .PROCEDENCIA = dgvDetalle.Rows(i).Cells(11).Value
                    .PAIS_ORIGEN = dgvDetalle.Rows(i).Cells(12).Value
                    .COMMENT = dgvDetalle.Rows(i).Cells(14).Value
                    .NUMBER_ANALIS = dgvDetalle.Rows(i).Cells(4).Value '+ "/" + dtpFecha.Value.Year.ToString
                    almacenBL.Actualiza_valoracion_lote(.PART_ID, .NUMBER_LOT, dgvDetalle.Rows(i).Cells(13).Value)
                End With
                ls_det_alm.Add(alm_detBE)
            Next
            almacenBL.GuardarInventarioAlmacen_Control_Calidad(alm_cabBE, ls_det_alm)

            almacenBL.Actualiza_Estado_Liberacion(Ref_idalamacen, Ref_documentid, Ref_numerodocument, _Flag_Tipo)
            'almacenBL.Actualiza_Numero_Analisis_Liberacion(alm_cabBE.WAREHOUSE_ID, alm_cabBE.DOCUMENT_ID, alm_cabBE.NUMBER_DOCUMENT, dtpFecha.Value.Year.ToString)

            msj = "Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & alm_cabBE.DOCUMENT_ID & " - " & alm_cabBE.NUMBER_DOCUMENT & vbCrLf & " Almacen: Cuarentena "
            MsgBox(msj, MsgBoxStyle.Information)

            'la parte de almacen de la NI
            clsAlmacenCorrelativoBl = New ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(almacen_destino, "I")
            CORRELATIVO_NI = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
            With alm_cabBE_ingreso
                .WAREHOUSE_ID = almacen_destino
                .DOCUMENT_ID = "NI"
                .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_DOCUMENT = CDate(dtpFecha.Value).ToShortDateString
                .TYPE_TRANS = "I"
                .TRANS_ID = "TD"
                .DOC_ID_REF = "NS" 'txtTipoDocumentoRef.Text
                .NUM_ID_REF = CORRELATIVO_NS 'txtNumeroReferencia.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = "20417180134" '_RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = "" 'txtcodigoProveedor.Text
                .VENDOR_NAME = "" 'lblproveedor.Text
                .CUSTOMER_ID = "JL0111" 'txtcodigoTercero.Text
                .CUSTOMER_NAME = "LABORATORIOS UNIDOS S.A." 'lbltercero.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cboMoneda.SelectedValue
                .CURRENCY_EXCHANGE = 0
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = cboTipoMovimiento.SelectedValue.ToString
                .WAREHOUSE_REF = CboAlmacen.SelectedValue.ToString
                .UPDATE_DATE = Date.Now()
                .NUM_ORDER_MANUFACT = txtorderFabricacion.Text
                .NUMBER_PURCHASE = txtordenCompra.Text
            End With
            'Detalle del ingreso...
            For i = 0 To dgvDetalle.Rows.Count - 1
                alm_detBE_ingreso = New ClsEntidades.WAREHOUSE_TRANS_LINE
                With alm_detBE_ingreso
                    .WAREHOUSE_ID = almacen_destino
                    .DOCUMENT_ID = "NI"
                    .NUMBER_DOCUMENT = alm_cabBE_ingreso.NUMBER_DOCUMENT
                    .ITEM = CInt(dgvDetalle.Rows(i).Cells(0).Value)
                    .PART_ID = dgvDetalle.Rows(i).Cells(1).Value
                    .QTY = dgvDetalle.Rows(i).Cells(5).Value
                    .QTY_DLV = 0
                    .QTY_REF = dgvDetalle.Rows(i).Cells(5).Value
                    .QTY_INVOICED = 0
                    .AMOUNT_SALES = 0
                    .PART_DESCRIPTION = dgvDetalle.Rows(i).Cells(2).Value
                    .UNIT_PART = dgvDetalle.Rows(i).Cells(3).Value
                    .NUMBER_LOT = dgvDetalle.Rows(i).Cells(9).Value
                    .WAREHOUSE_REF = ""
                    .ACCOUNT = _ACCOUNT
                    .STATUS_VALUE = False
                    .NUM_PROTOCOLOS = dgvDetalle.Rows(i).Cells(8).Value
                    .OPT_ENTREGA = IIf(dgvDetalle.Rows(i).Cells(7).Value = "Final", 0, 1)
                    .QT_BULTOS = dgvDetalle.Rows(i).Cells(6).Value
                    .PROCEDENCIA = dgvDetalle.Rows(i).Cells(10).Value
                    .PAIS_ORIGEN = dgvDetalle.Rows(i).Cells(11).Value
                    .COMMENT = dgvDetalle.Rows(i).Cells(14).Value
                    .NUMBER_ANALIS = dgvDetalle.Rows(i).Cells(4).Value '+ "/" + dtpFecha.Value.Year.ToString
                End With
                ls_det_alm_ingreso.Add(alm_detBE_ingreso)
            Next
            almacenBL.GuardarInventarioAlmacen_Control_Calidad(alm_cabBE_ingreso, ls_det_alm_ingreso)

            msj = "Documento Generado Correctamente," & vbCrLf & " Nro Documento: " & alm_cabBE_ingreso.DOCUMENT_ID & " - " & alm_cabBE_ingreso.NUMBER_DOCUMENT & vbCrLf & " Almacen: " & almacen_destino_nombre & " "
            MsgBox(msj, MsgBoxStyle.Information)
            MsgBox(mensaje_final, MsgBoxStyle.Information)
            'If MessageBox.Show("Se procedera a la Impresion del Documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    'Imprimir ingreso o salida  Almacen
            '    imprimirAlmacen(CboAlmacen.SelectedValue.ToString, documentId, alm_cabBE.NUMBER_DOCUMENT)
            'End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarNumeroAnalisis(ByVal idlamacen As String, ByVal documentId As String, ByVal NumeroDocumento As String)
        Try
            clsBusquedaBl = New ClsBuscar
            clsBusquedaBl.ActualizandoNumeroAnalisis(idlamacen, documentId, NumeroDocumento)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GenerarInsercionLotes(ByVal WAREHOUSE_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String, _
                                      ByVal DATE_DOCUMENT As String, ByVal TYPE_TRANS As String)
        Try
            clsBusquedaBl = New ClsBuscar
            For i As Integer = 0 To dtdetalleBultosPrincipal.Rows.Count() - 1

                clsBusquedaBl.InsertarCantidadLotes(WAREHOUSE_ID, DOCUMENT_ID, NUMBER_DOCUMENT, DATE_DOCUMENT, TYPE_TRANS, dtdetalleBultosPrincipal.Rows(i).Item("PART_ID").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("LOTE").ToString(), dtdetalleBultosPrincipal.Rows(i).Item("QTY").ToString(), _
                                                    dtdetalleBultosPrincipal.Rows(i).Item("QTY_BULTOS").ToString(), i + 1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If dgvDetalle.RowCount() = 0 Then
            MsgBox("No se genero previamente la Guia de analisis.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim ListaAlm As New List(Of String)
        Dim Flag_indicador As Boolean = False
        For Each row As DataGridViewRow In dgvDetalle.Rows
            If String.IsNullOrEmpty(row.Cells(5).Value.ToString) Then
                Flag_indicador = True
                Exit For
            End If
        Next
        If Flag_indicador = True Then
            MsgBox("No se genero previamente la Guia de Analisis", MsgBoxStyle.Critical)
            Exit Sub
        End If
        For Each row As DataGridViewRow In dgvDetalle.Rows
            Dim AlmacenBl As New ClsOperaciones.WAREHOUSE_TRANS
            Dim dtTipoArt As New DataTable
            dtTipoArt = AlmacenBl.Mostrando_Tipo_Articulo(row.Cells(1).Value)
            If dtTipoArt.Rows.Count() <> 0 Then
                If ListaAlm.Contains(dtTipoArt.Rows(0).Item("WAREHOUSE_ID_DEFAULT").ToString()) = False Then
                    ListaAlm.Add(dtTipoArt.Rows(0).Item("WAREHOUSE_ID_DEFAULT").ToString())
                    ListaAlm.Add(dtTipoArt.Rows(0).Item("NOMBRE_ALMACEN").ToString())
                End If
            End If
        Next
        If ListaAlm.Count() > 2 Then
            MsgBox("Los items pertenecen a distintos Almacenes.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If ListaAlm.Count() <> 0 Then
                If MsgBox("Desea continuar con la liberación de los insumos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    mensaje_final = "Se aprobarón los insumos."
                    almacen_destino = ListaAlm(0)
                    almacen_destino_nombre = ListaAlm(1) '"MATERIA PRIMA"
                    GenerarIngresoSalidaAlmacen("L")
                    btnCancelar_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub GenerarGuiaAnalisis()
        Try
            If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
            Ref_idalamacen = String.Empty
            Ref_documentid = String.Empty
            Ref_numerodocument = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            ' Verificando si posee opcion a Guia de Analisis
            Dim TipoTransaccion As String = dgvCabeceraAlmacen.Item(5, dgvCabeceraAlmacen.CurrentRow.Index).Value
            Dim codigoTipoTransaccion As String = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value
            'validacion
            If String.IsNullOrEmpty(TipoTransaccion) Or String.IsNullOrEmpty(codigoTipoTransaccion) Then Exit Sub
            'consulta
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            MostrarMovimientoBl.Get_TipoTransacciones(TipoTransaccion, codigoTipoTransaccion)
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                clsBusquedaBl = New ClsBuscar
                dtData = New DataTable("VerificandoGuia")
                dtData = clsBusquedaBl.get_VerificarGuiaAnalisis(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
                If dtData.Rows.Count() <> 0 Then
                    If CInt(dtData.Rows(0).Item("Resultado").ToString()) = 0 Then
                        'Dim frmG As New frmGuiaAnalisis
                        'frmG.idAlmacen = Ref_idalamacen
                        'frmG.documentId = Ref_documentid
                        'frmG.NumeroDocumento = Ref_numerodocument
                        'frmG.ShowDialog()
                        'frmG.Close()
                    ElseIf CInt(dtData.Rows(0).Item("Resultado").ToString()) = 1 Then
                        MsgBox("Ya se genero Anteriormente una Guia de Analisis, para este Documento", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("EL Documento seleccionado, no permite la generacion de Guia de Analisis.", MsgBoxStyle.Information, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuiaAnalisis_Click(sender As Object, e As EventArgs) Handles btnGuiaAnalisis.Click
        GenerarGuiaAnalisis()
    End Sub


    Private Sub EliminarDocumentosAlmacen()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim Usuario As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.EliminarDocumentosAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument, Usuario)
            Dim msj As String = String.Empty
            msj = "Documento Eliminada Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            MostrandoDatosGeneralesCabeceraAlmacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDetalle.RowCount() = 0 Then
            MsgBox("No se genero previamente la Guia de analisis.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim ListaAlm As New List(Of String)
        For Each row As DataGridViewRow In dgvDetalle.Rows
            Dim AlmacenBl As New ClsOperaciones.WAREHOUSE_TRANS
            Dim dtTipoArt As New DataTable
            dtTipoArt = AlmacenBl.Mostrando_Tipo_Articulo(row.Cells(1).Value)
            If dtTipoArt.Rows.Count() <> 0 Then
                If ListaAlm.Contains(dtTipoArt.Rows(0).Item("WAREHOUSE_ID_RECHAZADOS").ToString()) = False Then
                    ListaAlm.Add(dtTipoArt.Rows(0).Item("WAREHOUSE_ID_RECHAZADOS").ToString())
                    ListaAlm.Add(dtTipoArt.Rows(0).Item("NOMBRE_ALMACEN_RECHAZADO").ToString())
                End If
            End If
        Next
        If ListaAlm.Count() > 2 Then
            MsgBox("Los items pertenecen a distintos Almacenes.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If ListaAlm.Count() <> 0 Then
                If MsgBox("Desea continuar con el rechazo de los insumos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    mensaje_final = "Se rechazarón los insumos."
                    almacen_destino = ListaAlm(0)
                    almacen_destino_nombre = ListaAlm(1) '"RECHAZADOS MATERIA PRIMA"
                    GenerarIngresoSalidaAlmacen("R")
                    btnCancelar_Click(sender, e)
                End If

            End If
        End If
    End Sub


    Private Sub imprimirAlmacen(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvCabeceraAlmacen.Visible = True
        pnlfiltros.Visible = True
        Modo_consultar = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        gbOpciones.Visible = True
        gbCabceraDocumento.Enabled = True
        dgvDetalle.Visible = False
        Limpiar()
        MostrandoDatosGeneralesCabeceraAlmacen()
        Botonera_Estado_Cambiar(False)
    End Sub

 

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboTipoMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoMovimiento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboAlmacen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMoneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbocentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbocentroCosto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtNumeroReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroReferencia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtordenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtordenCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtorderFabricacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtorderFabricacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstados.SelectedIndexChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub dgvCabeceraAlmacen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabeceraAlmacen.CellFormatting
        'If String.IsNullOrEmpty(dgvCabeceraAlmacen.Rows(e.RowIndex).Cells(5).Value.ToString) Then
        '    dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        '    dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        'Else
        '    dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        '    dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        'End If
    End Sub

    Private Sub dgvCabeceraAlmacen_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCabeceraAlmacen.ColumnHeaderMouseClick
        STRorden = dgvCabeceraAlmacen.Columns(e.ColumnIndex).Name
        txtFiltro.Focus()
        txtFiltro.Clear()
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Recalcula_num_Analisis()
        'End If
    End Sub

    
End Class