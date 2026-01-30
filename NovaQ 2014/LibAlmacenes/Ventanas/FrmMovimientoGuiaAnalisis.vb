Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmMovimientoGuiaAnalisis

    Private edicion As Boolean
    Private _tipoMov As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String


    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenCabBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim dtTransaccionTipo As DataTable

    Dim clsAlmacenCorrelativoBl As LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo

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
    Dim Ref_trasactiontype As String = String.Empty
    Dim Ref_tipo As String = String.Empty



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
    '                Cargar_Almacen()
    '                Dim indice As Integer = -1
    '                Dim i As Integer
    '                Dim dato As String

    '                For i = 0 To CboAlmacen.Items.Count() - 1
    '                    CboAlmacen.SelectedIndex = i
    '                    dato = CboAlmacen.SelectedValue
    '                    If dato = MostrarMovimientoBl.WHO_ID Then
    '                        indice = CboAlmacen.SelectedIndex
    '                        Exit For
    '                    End If
    '                Next
    '                If indice = -1 Then
    '                    CboAlmacen.Enabled = False
    '                    CboAlmacen.BackColor = Drawing.Color.White
    '                    CboAlmacen.ForeColor = Drawing.Color.Black
    '                    CboAlmacen.SelectedIndex = -1
    '                    MsgBox("Para este Tipo de Transaccion, usted no tiene Acceso.", MsgBoxStyle.Information)
    '                Else
    '                    CboAlmacen.Enabled = False
    '                    CboAlmacen.BackColor = Drawing.Color.White
    '                    CboAlmacen.ForeColor = Drawing.Color.Black
    '                    CboAlmacen.SelectedIndex = indice
    '                End If

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
            clsTransaccionTipoBl = New LibCobranzas.ClsOperaciones.TRANSACTION_TYPE
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_InventarioTransaccionesTipo(TipoMov)
            Dim row As DataRow = dtTransaccionTipo.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            dtTransaccionTipo.Rows.InsertAt(row, 0)
            If dtTransaccionTipo.Rows.Count() <> 0 Then
                cboTipoMovimiento.DisplayMember = "DESCRIPCION"
                cboTipoMovimiento.ValueMember = "CODIGO"
                cboTipoMovimiento.DataSource = dtTransaccionTipo
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


    

    Private Sub cmbTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimiento.SelectedIndexChanged
        If cboTipoMovimiento.Items.Count() <> 0 Then
            If cboTipoMovimiento.SelectedIndex = 0 Then
                GbCabecera.Enabled = False
                GbdetalleDocumento.Enabled = False
            Else
                GbCabecera.Enabled = True
                GbdetalleDocumento.Enabled = True
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
        TransaccionesTipos()
        Cargar_Almacen()
        Cargar_Moneda()
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        cboopcionesBusqueda.SelectedIndex = 0
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
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


    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'Dim wbusqueda As String = UCase(txtFiltro.Text)
        'Dim myCurrencyManager As CurrencyManager
        'myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        'Dim INTnewpos As Integer
        'dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        'myCurrencyManager.Position = INTnewpos
        'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

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
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.DatosGeneralesGuiaAnalisis(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), cboopcionesBusqueda.SelectedIndex, LibComunVar.ClsVarComun.AccesoAlmacenes)
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv
                dgvCabeceraAlmacen.AutoResizeColumns()
                dgvCabeceraAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'dgvCabeceraAlmacen.Columns(0).Width = 70
                'dgvCabeceraAlmacen.Columns(1).Width = 160
                'dgvCabeceraAlmacen.Columns(2).Width = 70
                'dgvCabeceraAlmacen.Columns(7).Width = 250
                STRorden = dgvCabeceraAlmacen.Columns(3).Name & "+" & dgvCabeceraAlmacen.Columns(5).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            Else
                MsgBox("No hay informacion para Mostrar", MsgBoxStyle.Information, "Sistema")
            End If
        Catch ex As Exception
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
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
        Else
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
        ' lblTipoDocRef.Text = String.Empty
        Ref_documentid = String.Empty
        Ref_idalamacen = String.Empty
        Ref_numerodocument = String.Empty
        Ref_tipo = String.Empty
        Ref_trasactiontype = String.Empty
        txt_Tipo_Ref.Text = ""
        txt_Numero_Ref.Text = ""
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

    Private Sub MostrarModoEdicion(ByVal idAlmacen As String, ByVal documentId As String, ByVal NumeroDocument As String)
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen(idAlmacen, documentId, NumeroDocument)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    txt_Tipo_Ref.Text = dtCabeceraAlm.Rows(i).Item("DOCUMENT_ID").ToString
                    txt_Numero_Ref.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_DOCUMENT").ToString
                    dtpFecha.Text = dtCabeceraAlm.Rows(i).Item("DATE_DOCUMENT").ToString
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
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(idAlmacen, documentId, NumeroDocument)
                dgvDetalle.DataSource = Nothing
                dgvDetalle.Rows.Clear()
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                           dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                           dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, 0.0)
                    Next
                End If
                'Dim total As Double = 0.0
                'For Each row As DataGridViewRow In dgvDetalle.Rows
                '    total += CDbl(row.Cells(5).Value)
                'Next
                'txtTotal.Text = Format(total, "##.##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        MostrarModoEdicion(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        Modo_consultar = True
        pnlfiltros.Visible = False
        dgvCabeceraAlmacen.Visible = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = True
        gbCabceraDocumento.Enabled = False
        dgvDetalle.Visible = True
        Call Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub imprimirAlmacen(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAnalisis(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis_Analisis.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
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
        gbCabceraDocumento.Enabled = True
        dgvDetalle.Visible = False
        Limpiar()
        MostrandoDatosGeneralesCabeceraAlmacen()
        Botonera_Estado_Cambiar(False)
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
            If almacenBL.EliminarDocumentos_Guia_Analisis(Ref_idalamacen, Ref_documentid, Ref_numerodocument, Usuario) = True Then
                Dim msj As String = String.Empty
                msj = "Documento Anulado Correctamente, Nro Documento: " & Ref_numerodocument
                MsgBox(msj, MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
            MostrandoDatosGeneralesCabeceraAlmacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabeceraAlmacen.RowCount() = 0 Then Exit Sub
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("¿Desea Anular el Documento.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarDocumentosAlmacen()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub
End Class