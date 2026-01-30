Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing


Public Class FrmMovimientoAlmacen

    Private edicion As Boolean
    Private _tipoMov As String
    Private _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String
    Public _MOV_VALORIZADO As String = String.Empty


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
    Dim Modo_actualizar As Boolean = False

    Dim dtdetalleArticuloPrincipal As DataTable
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
    Dim ref_fecha_doc As String


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

    Private Sub MostrandoTipoTransacciones()
        Try
            If ModoEdicion = True Then Exit Sub
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            Dim CodigoTransaccion As String = String.Empty
            CodigoTransaccion = cboTipoMovimiento.SelectedValue.ToString
            MostrarMovimientoBl.Get_TipoTransacciones(TipoMov, CodigoTransaccion)
            'Valorizado
            If MostrarMovimientoBl.IS_VALUED = "F" Then
                chkValorizado.Visible = False
            ElseIf MostrarMovimientoBl.IS_VALUED = "V" Then
                chkValorizado.Visible = True
                chkValorizado.Checked = False
            End If
            If MostrarMovimientoBl.IS_CUSTOMER = "N" Then
                txtcodigoTercero.Enabled = False
                lbltercero.Text = String.Empty
                txtcodigoTercero.Text = String.Empty
                txtcodigoTercero.BackColor = Drawing.Color.White
                txtcodigoTercero.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_CUSTOMER = "S" Then
                txtcodigoTercero.Enabled = True
                lbltercero.Text = String.Empty
                txtcodigoTercero.Text = String.Empty
                txtcodigoTercero.BackColor = Drawing.Color.Aquamarine
                txtcodigoTercero.ForeColor = Drawing.Color.Black
            End If
            If MostrarMovimientoBl.IS_VENDOR = "N" Then
                txtcodigoProveedor.Enabled = False
                lblproveedor.Text = String.Empty
                txtcodigoProveedor.Text = String.Empty
                txtcodigoProveedor.BackColor = Drawing.Color.White
                txtcodigoProveedor.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_VENDOR = "S" Then
                txtcodigoProveedor.Enabled = True
                lblproveedor.Text = String.Empty
                txtcodigoProveedor.Text = String.Empty
                txtcodigoProveedor.BackColor = Drawing.Color.Aquamarine
                txtcodigoProveedor.ForeColor = Drawing.Color.Black
            End If
            'Centro de Costo
            If MostrarMovimientoBl.IS_CCOST = "N" Then
                cbocentroCosto.Enabled = False
            ElseIf MostrarMovimientoBl.IS_CCOST = "S" Then
                cbocentroCosto.Enabled = True
            End If

            '' lote a Fabricar 
            If MostrarMovimientoBl.IS_LOTE_A_FABRICAR = "N" Then
                txtloteFabricar.Enabled = False
                txtloteFabricar.BackColor = Drawing.Color.White
                txtloteFabricar.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_LOTE_A_FABRICAR = "S" Then
                txtloteFabricar.Enabled = True
                txtloteFabricar.Text = String.Empty
                txtloteFabricar.BackColor = Drawing.Color.Aquamarine
                txtloteFabricar.ForeColor = Drawing.Color.Black
            End If

            ' Almacen   
            If MostrarMovimientoBl.WHO_ID = String.Empty Then
                CboAlmacen.Enabled = True
                CboAlmacen.SelectedIndex = 0
                CboAlmacen.BackColor = Drawing.Color.Aquamarine
                CboAlmacen.ForeColor = Drawing.Color.Black
            Else
                If CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID Then
                    CboAlmacen.Enabled = False
                    CboAlmacen.SelectedValue = MostrarMovimientoBl.WHO_ID
                    CboAlmacen.BackColor = Drawing.Color.White
                    CboAlmacen.ForeColor = Drawing.Color.Black
                Else
                    Cargar_Almacen()
                    Dim indice As Integer = -1
                    Dim i As Integer
                    Dim dato As String

                    For i = 0 To CboAlmacen.Items.Count() - 1
                        CboAlmacen.SelectedIndex = i
                        dato = CboAlmacen.SelectedValue
                        If dato = MostrarMovimientoBl.WHO_ID Then
                            indice = CboAlmacen.SelectedIndex
                            Exit For
                        End If
                    Next
                    If indice = -1 Then
                        CboAlmacen.Enabled = False
                        CboAlmacen.BackColor = Drawing.Color.White
                        CboAlmacen.ForeColor = Drawing.Color.Black
                        CboAlmacen.SelectedIndex = -1
                        MsgBox("Para este Tipo de Transaccion, usted no tiene Acceso.", MsgBoxStyle.Information)
                    Else
                        CboAlmacen.Enabled = False
                        CboAlmacen.BackColor = Drawing.Color.White
                        CboAlmacen.ForeColor = Drawing.Color.Black
                        CboAlmacen.SelectedIndex = indice
                    End If

                End If
            End If
            ' tipo Doc Ref   
            If MostrarMovimientoBl.IS_DOC_REF = "N" Then
                txtTipoDocumentoRef.Enabled = False
                txtNumeroReferencia.Enabled = False
                txtTipoDocumentoRef.Text = String.Empty
                txtNumeroReferencia.Text = String.Empty
                txtTipoDocumentoRef.BackColor = Drawing.Color.White
                txtNumeroReferencia.BackColor = Drawing.Color.White
                txtTipoDocumentoRef.ForeColor = Drawing.Color.White
                txtNumeroReferencia.ForeColor = Drawing.Color.White
            ElseIf MostrarMovimientoBl.IS_DOC_REF = "S" Then
                txtNumeroReferencia.Enabled = True
                txtTipoDocumentoRef.Enabled = True
                txtTipoDocumentoRef.Text = String.Empty
                txtNumeroReferencia.Text = String.Empty
                txtTipoDocumentoRef.BackColor = Drawing.Color.Aquamarine
                txtTipoDocumentoRef.ForeColor = Drawing.Color.Black
                txtNumeroReferencia.BackColor = Drawing.Color.Aquamarine
                txtNumeroReferencia.ForeColor = Drawing.Color.Black
            End If
            'Orden de compra
            If MostrarMovimientoBl.IS_ORDER_PURCHASE = "N" Then
                txtordenCompra.Enabled = False
                txtordenCompra.Text = String.Empty
                txtordenCompra.BackColor = Drawing.Color.White
                txtordenCompra.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_ORDER_PURCHASE = "S" Then
                txtordenCompra.Enabled = True
                txtordenCompra.Text = String.Empty
                txtordenCompra.BackColor = Drawing.Color.Aquamarine
                txtordenCompra.ForeColor = Drawing.Color.Black
            End If
            'Orden de Fabricacion
            If MostrarMovimientoBl.IS_ORDER_MANUFACT = "N" Then
                txtorderFabricacion.Enabled = False
                txtorderFabricacion.Text = String.Empty
                txtorderFabricacion.BackColor = Drawing.Color.White
                txtorderFabricacion.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_ORDER_MANUFACT = "S" Then
                txtorderFabricacion.Enabled = True
                txtorderFabricacion.Text = String.Empty
                txtorderFabricacion.BackColor = Drawing.Color.Aquamarine
                txtorderFabricacion.ForeColor = Drawing.Color.Black
            End If

            '' codigo de producto a Fabricar 
            If MostrarMovimientoBl.IS_COD_ARTICULO = "N" Then
                txtprodafabricar.Enabled = False
                txtprodafabricar.BackColor = Drawing.Color.White
                txtprodafabricar.ForeColor = Drawing.Color.Black
            ElseIf MostrarMovimientoBl.IS_COD_ARTICULO = "S" Then
                txtprodafabricar.Enabled = True
                txtprodafabricar.Text = String.Empty
                txtprodafabricar.BackColor = Drawing.Color.Aquamarine
                txtprodafabricar.ForeColor = Drawing.Color.Black
            End If

            'Tipo Articulo 
            TipoArticulo = String.Empty
            TipoArticulo = MostrarMovimientoBl.WHO_ID_PART_TYPE
            'Generacion de Guia de Analisis
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                PerteneceGuiaAnalisis = True
            ElseIf MostrarMovimientoBl.IS_GUIA_ANALISIS = "N" Then
                PerteneceGuiaAnalisis = False
            End If
            If cboTipoMovimiento.Text = "DEVOLUCION DE MERCADERIA REP. MEDICO" Then
                PictureBox3.Visible = True
            Else
                PictureBox3.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
        almacenBL = New ClsOperaciones.WAREHOUSE
        Dim dtAlmacenBusc As New DataTable
        dtAlmacenBusc = almacenBL.get_Almacenes_Busqueda(LibComunVar.ClsVarComun.AccesoAlmacenes)
        Dim rows As DataRow = dtAlmacenBusc.NewRow()
        rows.Item("CODIGO") = ""
        rows.Item("DESCRIPCION") = "(-SELECCIONE-)"
        dtAlmacenBusc.Rows.InsertAt(rows, 0)
        cboAlmacenBusqueda.DisplayMember = "DESCRIPCION"
        cboAlmacenBusqueda.ValueMember = "CODIGO"
        cboAlmacenBusqueda.DataSource = dtAlmacenBusc
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
            lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
        txtNumeroReferencia.Focus()
    End Sub



    Private Sub TipoDocumento(Optional ByVal _codigoTipoDoc As String = "")
        Try
            Dim frm As frmBuscar
            If _codigoTipoDoc = String.Empty Then
                frm = New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
                frm.CadenaConsulta = sql
                frm.Titulo = "Tipo de Documentos de Referencias"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtTipoDocumentoRef.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtNumeroReferencia.Focus()
                End If
                frm.Close()
            Else
                Dim AlmacenBl As New ClsOperaciones.WAREHOUSE_TRANS
                Dim dt_almacen As New DataTable("TipoDoc")
                dt_almacen = AlmacenBl.Tipo_documento_manual(_codigoTipoDoc)
                Dim codArticulo As String = String.Empty
                If dt_almacen.Rows.Count() <> 0 Then
                    txtTipoDocumentoRef.Text = dt_almacen.Rows(0).Item(0).ToString
                    lblTipoDocRef.Text = dt_almacen.Rows(0).Item(1).ToString
                    txtNumeroReferencia.Select()
                Else
                    frm = New frmBuscar
                    Dim sql As String = String.Empty
                    sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Tipo de Documentos de Referencias"
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        txtTipoDocumentoRef.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                        lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                        txtNumeroReferencia.Focus()
                    End If
                    frm.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub











    Private Sub Numero_documento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_NUMERO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            'lblTipoDocRef.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
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
            txtComentarios.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Producto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_PART_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Productos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtprodafabricar.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblprodafabricar.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
            txtComentarios.Select()
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


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NRO_BULTOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("MONTO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("OPT_ENTREGA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PROCEDENCIA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PAIS_ORIGEN", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUMERO_ANALISIS", Type.GetType("System.String"))
            dgvdetalleAlmacen.DataSource = Nothing
            dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
            dgvdetalleAlmacen.AutoResizeColumns()
            dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgvdetalleAlmacen.Columns(0).Width = 50
            dgvdetalleAlmacen.Columns(0).HeaderText = "Item"
            'dgvdetalleAlmacen.Columns(1).Width = 70
            dgvdetalleAlmacen.Columns(1).HeaderText = "Codigo"
            ' dgvdetalleAlmacen.Columns(2).Width = 220
            dgvdetalleAlmacen.Columns(2).HeaderText = "Articulo"
            ' dgvdetalleAlmacen.Columns(3).Width = 50
            dgvdetalleAlmacen.Columns(3).HeaderText = "Unidad"
            'dgvdetalleAlmacen.Columns(4).Width = 70
            dgvdetalleAlmacen.Columns(4).HeaderText = "Lote"
            ' dgvdetalleAlmacen.Columns(5).Width = 70
            dgvdetalleAlmacen.Columns(5).HeaderText = "Cantidad"
            'dgvdetalleAlmacen.Columns(6).Width = 90
            dgvdetalleAlmacen.Columns(6).HeaderText = "Protocolo"
            'dgvdetalleAlmacen.Columns(7).Width = 60
            dgvdetalleAlmacen.Columns(7).HeaderText = "Bultos"
            'dgvdetalleAlmacen.Columns(8).Width = 80
            dgvdetalleAlmacen.Columns(8).HeaderText = "Costo"
            dgvdetalleAlmacen.Columns(9).Visible = False
            dgvdetalleAlmacen.Columns(10).Visible = False
            dgvdetalleAlmacen.Columns(11).Visible = False
            dgvdetalleAlmacen.Columns(12).HeaderText = "N° Análisis"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function DatosLotes(Optional ByVal Lote As String = "", Optional ByVal CodigoPart As String = "") As String
        Dim Cadena As String = String.Empty
        Try
            Dim listaLot As New List(Of String)
            Dim cadena_lote As String = String.Empty
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                If edicion = True Then
                    If dtdetalleArticuloPrincipal.Rows.Count() = 1 Then
                        Exit Try
                    End If
                End If
                If Lote = String.Empty Then
                    For i As Integer = 0 To dgvdetalleAlmacen.Rows.Count() - 1
                        Dim lotes As String = String.Empty
                        lotes = dgvdetalleAlmacen.Item(4, i).Value
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    For j As Integer = 0 To listaLot.Count() - 1
                        cadena_lote += "'" & listaLot(j) & "',"
                    Next
                    Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                Else
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & CodigoPart & "' and LOTE NOT IN ('" & Lote & "')")
                        Dim lotes As String = String.Empty
                        lotes = item("LOTE")
                        If listaLot.Contains(lotes) = False Then
                            listaLot.Add(lotes)
                        End If
                    Next
                    If listaLot.Count() <> 0 Then
                        For j As Integer = 0 To listaLot.Count() - 1
                            cadena_lote += "'" & listaLot(j) & "',"
                        Next
                        Cadena = cadena_lote.Substring(0, cadena_lote.Length() - 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Cadena
    End Function

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


    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticuloInventario
            frmArticulo.EsValorizado = IIf(chkValorizado.Checked, True, False)
            frmArticulo.Flag_ModoEdicion = False
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.TipoMov = TipoMov
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            If TipoMov = "S" Then
                frmArticulo.ValidacionLotes = DatosLotes()
            End If
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                row("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                row("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                row("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                row("NRO_PROTOCOLO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO")
                row("NRO_BULTOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_BULTOS")
                row("MONTO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("MONTO")
                row("OPT_ENTREGA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA")
                row("PROCEDENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROCEDENCIA")
                row("PAIS_ORIGEN") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PAIS_ORIGEN")
                row("NUMERO_ANALISIS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NUMERO_ANALISIS")
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                If frmArticulo.dtDetallesBulto.Rows.Count() > 0 Then
                    If frmArticulo.Flag_ModoEdicion = False Then
                        AgregandoNuevosDatosBultos(frmArticulo.dtDetallesBulto, dtdetalleBultosPrincipal, dgvdetalleAlmacen.Rows.Count())
                    End If
                End If
                Fl_close = False
            Else
                Fl_close = True
            End If
            frmArticulo.Close()
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
                MostrandoTipoTransacciones()
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

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            clsBusquedaBl = New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Sub FrmInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TransaccionesTipos()
        Cargar_Almacen()
        Cargar_Moneda()
        Botonera_Estado_Cambiar(False)
        If TipoMov = "S" Then btn_act_costos.Visible = False Else btn_act_costos.Visible = True
        btnGuiaAnalisis.Visible = False
        btnEliminar.Visible = NIVEL_ACCESO()
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub txtTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocumentoRef.KeyDown
        If e.KeyCode = Keys.F1 Then TipoDocumento()
        If e.KeyCode = Keys.Enter Then
            If txtTipoDocumentoRef.Text = String.Empty Then
                TipoDocumento()
            Else
                TipoDocumento(txtTipoDocumentoRef.Text)
            End If
        End If

    End Sub

    Private Sub txtTipoDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDocumentoRef.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtTipoDocumentoRef.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        ' If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
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


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboTipoMovimiento.SelectedIndex = 0 Then Exit Sub
        If FechaFacturacion_Mes_anterior(dtpFecha.Value.Month, dtpFecha.Value.Year) = False Then
            Exit Sub
        End If

        If GbCabecera.Enabled = True Then
            If ValidarAgregacion() = False Then Exit Sub
            GbTransaccion.Enabled = False
            GbCabecera.Enabled = False
        End If
        edicion = False
        AgregandoArticulos()
        If dgvdetalleAlmacen.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub ModificandoArticulos()
        Try
            'GbCabecera.Enabled = False
            Dim frmArticulo As New FrmAsignarArticuloInventario
            Dim lote As String = dgvdetalleAlmacen.Item(4, dgvdetalleAlmacen.CurrentRow.Index).Value.ToString
            Dim CodigoArticulo As String = dgvdetalleAlmacen.Item(1, dgvdetalleAlmacen.CurrentRow.Index).Value
            frmArticulo.EsValorizado = IIf(chkValorizado.Checked, True, False)
            frmArticulo.AlmacenOrigen = CboAlmacen.SelectedValue.ToString
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            frmArticulo.Flag_ModoEdicion = True
            frmArticulo.Identificador = dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value
            frmArticulo.TipoMov = TipoMov
            frmArticulo.TransaccionTipoArticulo = TipoArticulo
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.BultosGenerarColummnaDataTable()
            frmArticulo.ItemLote = lote
            If lote = String.Empty Then
                frmArticulo.ValidacionLotes = DatosLotes()
            Else
                frmArticulo.ValidacionLotes = DatosLotes(lote, CodigoArticulo)
            End If
            Dim Codigo As String = dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("CODIGO") = item("CODIGO")
                row("DESCRIPCION") = item("DESCRIPCION")
                row("UNIDAD") = item("UNIDAD")
                row("LOTE") = item("LOTE")
                row("CANTIDAD") = item("CANTIDAD")
                row("NRO_PROTOCOLO") = item("NRO_PROTOCOLO")
                row("NRO_BULTOS") = item("NRO_BULTOS")
                row("MONTO") = item("MONTO")
                row("OPT_ENTREGA") = item("OPT_ENTREGA")
                row("PROCEDENCIA") = item("PROCEDENCIA")
                row("PAIS_ORIGEN") = item("PAIS_ORIGEN")
                row("NUMERO_ANALISIS") = item("NUMERO_ANALISIS")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            'Enviando datos de Bultos  seleccioandos a Modificar 
            For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value)
                Dim row As DataRow = frmArticulo.dtDetallesBulto.NewRow
                row("WAREHOUSE_ID") = item("WAREHOUSE_ID")
                row("DOCUMENT_ID") = item("DOCUMENT_ID")
                row("NUMBER_DOCUMENT") = item("NUMBER_DOCUMENT")
                row("DATE_DOCUMENT") = item("DATE_DOCUMENT")
                row("PART_ID") = item("PART_ID")
                row("LOTE") = item("LOTE")
                row("ITEM") = item("ITEM")
                row("QTY") = item("QTY")
                row("QTY_BULTOS") = item("QTY_BULTOS")
                row("IDENTIFICADOR") = item("IDENTIFICADOR")
                frmArticulo.dtDetallesBulto.Rows.Add(row)
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()
                        item("CODIGO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CODIGO")
                        item("DESCRIPCION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPCION")
                        item("UNIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIDAD")
                        item("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                        item("CANTIDAD") = frmArticulo.dtdetalleArticulo.Rows(0).Item("CANTIDAD")
                        item("NRO_PROTOCOLO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO")
                        item("NRO_BULTOS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NRO_BULTOS")
                        item("MONTO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("MONTO")
                        item("OPT_ENTREGA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA")
                        item("PROCEDENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PROCEDENCIA")
                        item("PAIS_ORIGEN") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PAIS_ORIGEN")
                        item("NUMERO_ANALISIS") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NUMERO_ANALISIS")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If
                'detalles de los bultos 
                'Borrando los Datos
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & frmArticulo.Identificador)
                    item.Delete()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                If frmArticulo.dtDetallesBulto.Rows.Count() <> 0 Then
                    'Agregando Nuevamente los Datos
                    AgregandoNuevosDatosBultos(frmArticulo.dtDetallesBulto, dtdetalleBultosPrincipal, frmArticulo.Identificador)
                End If
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvdetalleAlmacen.Item(0, dgvdetalleAlmacen.CurrentRow.Index).Value
                'Borrando los Datos del Articulo
                For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    rows.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                'Actualizando Numeracion  Articulo
                ActualizandoCorrelativoItem(dtdetalleArticuloPrincipal, "ITEM")
                'Borrando datos de los Bultos
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("IDENTIFICADOR=" & Codigo)
                    item.Delete()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                'Actualizando Numeracion  Bultos
                ActualizandoCorrelativoItem(dtdetalleBultosPrincipal, "IDENTIFICADOR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvdetalleAlmacen.CurrentRow Is Nothing Then Exit Sub
        edicion = True
        ModificandoArticulos()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvdetalleAlmacen.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
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


    Private Sub MostrandoDatosGeneralesCabeceraAlmacen()
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.get_DatosGeneralesAlmacen_E_S(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                 cboopcionesBusqueda.SelectedIndex, TipoMov, _documentId, LibComunVar.ClsVarComun.AccesoAlmacenes, cboAlmacenBusqueda.SelectedValue.ToString)
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv
                dgvCabeceraAlmacen.AutoResizeColumns()
                dgvCabeceraAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'dgvCabeceraAlmacen.Columns(0).Width = 40
                'dgvCabeceraAlmacen.Columns(1).Width = 200
                'dgvCabeceraAlmacen.Columns(2).Width = 35
                'dgvCabeceraAlmacen.Columns(4).Width = 120
                'dgvCabeceraAlmacen.Columns(5).Width = 40
                'dgvCabeceraAlmacen.Columns(6).Width = 40
                'dgvCabeceraAlmacen.Columns(7).Width = 250
                dgvCabeceraAlmacen.Columns(9).Visible = False
                dgvCabeceraAlmacen.Columns(5).Visible = False
                dgvCabeceraAlmacen.Columns("DOC_ID_REF").Visible = False
                dgvCabeceraAlmacen.Columns("NUM_ID_REF").Visible = False
                dgvCabeceraAlmacen.Columns("Codigo_Transaccion").Visible = False
                If TipoMov = "S" Then
                    dgvCabeceraAlmacen.Columns(10).Visible = False
                ElseIf TipoMov = "I" Then
                    dgvCabeceraAlmacen.Columns(10).Visible = True
                End If
                dgvCabeceraAlmacen.Columns("USUARIO").HeaderText = "Usuario Registro"
                dgvCabeceraAlmacen.Columns("FECHA_HORA_REGISTRO").HeaderText = "Fecha/Hora Registro"

                STRorden = dgvCabeceraAlmacen.Columns(0).Name & "+" & dgvCabeceraAlmacen.Columns(1).Name & "+" & dgvCabeceraAlmacen.Columns(2).Name & "+" & dgvCabeceraAlmacen.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            Else
                'MsgBox("No hay informacion para Mostrar", MsgBoxStyle.Information, "Sistema")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
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
            If Modo_consultar = True Then
                btnGrabar.Enabled = False
                btn_act_costos.Enabled = False
            Else
                btnGrabar.Enabled = True
                btn_act_costos.Enabled = False
            End If
            btnEliminar.Enabled = False
            btnGuiaAnalisis.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            lblCantidad.Visible = False
            Tool_Anular.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnGuiaAnalisis.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            lblCantidad.Visible = True
            Tool_Anular.Enabled = True
            btn_act_costos.Enabled = True
        End If
    End Sub

    Private Sub Limpiar()
        dtpFecha.MaxDate = Date.Today
        dtpFecha.Value = Date.Today
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
        lblTipoDocRef.Text = String.Empty
        Ref_documentid = String.Empty
        Ref_idalamacen = String.Empty
        Ref_numerodocument = String.Empty
        Ref_tipo = String.Empty
        Ref_trasactiontype = String.Empty
        txtprodafabricar.Text = String.Empty
        lblprodafabricar.Text = String.Empty
    End Sub



    Private Sub Nuevo()
        Try
            pnlprincipal.Visible = False
            GbCabecera.Enabled = False
            gbOpciones.Enabled = False
            GbTransaccion.Enabled = True
            Modo_actualizar = False
            Limpiar()
            GenerarColummnaDataTable()
            BultosGenerarColummnaDataTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
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
                    dtpFecha.Value = dtCabeceraAlm.Rows(i).Item("DATE_DOCUMENT").ToString
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
                    txtprodafabricar.Text = dtCabeceraAlm.Rows(i).Item("IS_COD_PRODUCTO").ToString
                    lblprodafabricar.Text = dtCabeceraAlm.Rows(i).Item("NOMBRE_COMERCIAL").ToString
                    _MOV_VALORIZADO = dtCabeceraAlm.Rows(i).Item("IS_VALUED").ToString
                    chkValorizado.Checked = IIf(_MOV_VALORIZADO = "V", True, False)
                Next
                '---Mostrando datos del Detalle
                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(idAlmacen, documentId, NumeroDocument)
                dgvDetalle.DataSource = Nothing
                dgvDetalle.Rows.Clear()
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                          dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                         dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, dtDetalleAlm.Rows(j).Item("AMOUNT").ToString)

                        'dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                        '   dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                        '   dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, 0.0)
                    Next
                End If
                dgvDetalle.Columns(4).DefaultCellStyle.Format = "N2"
                dgvDetalle.AutoResizeColumns()
                dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ' dgvDetalle.Rows(4).Visible = False
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


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        MostrarModoEdicion(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
        Modo_consultar = True
        pnlprincipal.Visible = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = True
        gbOpciones.Visible = False
        gbCabceraDocumento.Enabled = False
        gbLeyenda.Visible = False
        dgvdetalleAlmacen.Visible = False
        dgvDetalle.Visible = True
        Call Botonera_Estado_Cambiar(True)
    End Sub


    Private Function GenerarIngresoSalidaAlmacen() As Boolean
        Try
            Dim ls_det_alm As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim alm_cabBE As New ClsEntidades.WAREHOUSE_TRANS
            Dim alm_detBE As ClsEntidades.WAREHOUSE_TRANS_LINE
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Dim numero_bultos As String
            Dim qty_bultos As Double

            clsAlmacenCorrelativoBl = New LibCobranzas.ClsTransacciones.clsAlmacenCorrelativo
            clsAlmacenCorrelativoBl.Get_NumeroCorrelativoAlmacen(CboAlmacen.SelectedValue.ToString, TipoMov)
            'la parte de almacen
            With alm_cabBE
                If Modo_actualizar = True Then
                    .WAREHOUSE_ID = Ref_idalamacen
                    .DOCUMENT_ID = Ref_documentid
                    .NUMBER_DOCUMENT = Ref_numerodocument 'String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                Else
                    .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                    .DOCUMENT_ID = documentId
                    .NUMBER_DOCUMENT = String.Format("{0:0000000000}", CInt(clsAlmacenCorrelativoBl.NumeroCorrelativo + 1))
                End If
                Ref_idalamacen = .WAREHOUSE_ID
                Ref_documentid = .DOCUMENT_ID
                Ref_numerodocument = .NUMBER_DOCUMENT

                .DATE_DOCUMENT = CDate(dtpFecha.Value).ToShortDateString
                .TYPE_TRANS = TipoMov
                Ref_tipo = .TYPE_TRANS
                .TRANS_ID = cboTipoMovimiento.SelectedValue.ToString
                Ref_trasactiontype = .TRANS_ID
                .DOC_ID_REF = txtTipoDocumentoRef.Text
                .NUM_ID_REF = txtNumeroReferencia.Text
                .HOUR = String.Format("{0:HH:mm:ss}", DateTime.Now)
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .VAT_REGISTRATION = _RUC 'Ruc..
                .ADDR_DLV = _DIRECCION  'Direccion ..
                .VENDOR_ID = txtcodigoProveedor.Text
                .VENDOR_NAME = lblproveedor.Text
                .CUSTOMER_ID = txtcodigoTercero.Text
                .CUSTOMER_NAME = lbltercero.Text
                .SALES_TERM = ""
                .CURRENCY_TYPE = cboMoneda.SelectedValue
                .CURRENCY_EXCHANGE = LibComunVar.ClsVarComun.TCVenta
                .STATUS_GUIA = "V"
                .AMOUNT = 0
                .COMMENT = txtComentarios.Text
                .TYPE_GUIA = cboTipoMovimiento.SelectedValue.ToString
                .WAREHOUSE_REF = ""
                .UPDATE_DATE = Date.Now()
                .NUM_ORDER_MANUFACT = txtorderFabricacion.Text
                .NUMBER_PURCHASE = txtordenCompra.Text
                '.STATUS_CONTROL = "C"
                .IS_COD_PRODUCTO = txtprodafabricar.Text
            End With
            reporteBL = New ClsBuscar
            Dim _status_val As Integer
            dtImprimir = New DataTable("Transaccion")
            dtImprimir = reporteBL.Get_obtenerdatos_Transaccion(TipoMov, cboTipoMovimiento.SelectedValue.ToString)
            If dtImprimir.Rows.Count > 0 Then
                _status_val = IIf(dtImprimir.Rows(0).Item("IS_VALUED").ToString = "V", 1, 0)
            Else
                _status_val = 0
            End If
            If Modo_actualizar = True Then
                'Detalle de la Guia...
                For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                    alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                    With alm_detBE
                        .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                        .DOCUMENT_ID = documentId
                        .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                        .ITEM = dgvDetalle.Rows(i).Cells("item").Value
                        .PART_ID = dgvDetalle.Rows(i).Cells("codigo").Value
                        .AVERAGE_COST = CDbl(dgvDetalle.Rows(i).Cells("costo").Value)
                        .CURRENCY_ID = cboMoneda.SelectedValue.ToString

                        If dtImprimir.Rows.Count > 0 Then
                            .STATUS_VALUE = _status_val
                        Else
                            .STATUS_VALUE = _status_val
                        End If
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
            Else
                'Detalle de la Guia...
                For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                    alm_detBE = New ClsEntidades.WAREHOUSE_TRANS_LINE
                    With alm_detBE
                        .WAREHOUSE_ID = CboAlmacen.SelectedValue.ToString
                        .DOCUMENT_ID = documentId
                        .NUMBER_DOCUMENT = alm_cabBE.NUMBER_DOCUMENT
                        .ITEM = dtdetalleArticuloPrincipal.Rows(i).Item("ITEM").ToString
                        .PART_ID = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                        .QTY = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                        .QTY_DLV = 0
                        .QTY_REF = dtdetalleArticuloPrincipal.Rows(i).Item("CANTIDAD").ToString
                        .QTY_INVOICED = 0
                        .AMOUNT_SALES = 0
                        .AVERAGE_COST = CDbl(dtdetalleArticuloPrincipal.Rows(i).Item("MONTO").ToString)
                        .PART_DESCRIPTION = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                        .UNIT_PART = dtdetalleArticuloPrincipal.Rows(i).Item("UNIDAD").ToString
                        .NUMBER_LOT = dtdetalleArticuloPrincipal.Rows(i).Item("LOTE").ToString
                        .WAREHOUSE_REF = ""
                        .ACCOUNT = _ACCOUNT
                        '.STATUS_VALUE = IIf(chkValorizado.Checked = True, True, False)
                        .NUM_PROTOCOLOS = dtdetalleArticuloPrincipal.Rows(i).Item("NRO_PROTOCOLO").ToString
                        .OPT_ENTREGA = dtdetalleArticuloPrincipal.Rows(i).Item("OPT_ENTREGA").ToString
                        numero_bultos = dtdetalleArticuloPrincipal.Rows(i).Item("NRO_BULTOS").ToString
                        If numero_bultos = "" Then
                            qty_bultos = 0
                        Else
                            qty_bultos = CDbl(numero_bultos)
                        End If
                        'qty_bultos = IIf(numero_bultos = "", 0, CDbl(numero_bultos))
                        .QT_BULTOS = qty_bultos 'dtdetalleArticuloPrincipal.Rows(i).Item("NRO_BULTOS").ToString
                        .PROCEDENCIA = dtdetalleArticuloPrincipal.Rows(i).Item("PROCEDENCIA").ToString
                        .PAIS_ORIGEN = dtdetalleArticuloPrincipal.Rows(i).Item("PAIS_ORIGEN").ToString
                        .CURRENCY_ID = cboMoneda.SelectedValue.ToString
                        'reporteBL = New ClsBuscar
                        'dtImprimir = New DataTable("Transaccion")
                        'dtImprimir = reporteBL.Get_obtenerdatos_Transaccion(TipoMov, cboTipoMovimiento.SelectedValue.ToString)
                        If dtImprimir.Rows.Count > 0 Then
                            .STATUS_VALUE = _status_val 'IIf(dtImprimir.Rows(0).Item("IS_VALUED").ToString = "V", 1, 0)
                        Else
                            .STATUS_VALUE = _status_val
                        End If
                        .NUMBER_ANALIS = dtdetalleArticuloPrincipal.Rows(i).Item("NUMERO_ANALISIS").ToString
                    End With
                    ls_det_alm.Add(alm_detBE)
                Next
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim msj As String = String.Empty
            msj = String.Empty

            If Modo_actualizar = True Then
                If almacenBL.ActualizarInventarioAlmacen(alm_cabBE, ls_det_alm, txtloteFabricar.Text) Then
                    msj = "Documento actualizado Correctamente" & vbCrLf & "Nro Documento: " & documentId & " - " & alm_cabBE.NUMBER_DOCUMENT
                    MsgBox(msj, MsgBoxStyle.Information)
                End If
            Else
                If almacenBL.GuardarInventarioAlmacen(alm_cabBE, ls_det_alm, txtloteFabricar.Text) Then
                    msj = "Nuevo Documento Generado Correctamente" & vbCrLf & "Nro Documento: " & documentId & " - " & alm_cabBE.NUMBER_DOCUMENT
                    GenerarInsercionLotes(CboAlmacen.SelectedValue.ToString(), IIf(TipoMov = "I", "NI", "NS"), alm_cabBE.NUMBER_DOCUMENT, Date.Today, TipoMov)
                    MsgBox(msj, MsgBoxStyle.Information)
                    If MessageBox.Show("Se procedera a la Impresion del Documento" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'Imprimir ingreso o salida  Almacen
                        imprimirAlmacen(CboAlmacen.SelectedValue.ToString, documentId, alm_cabBE.NUMBER_DOCUMENT)
                    End If
                End If
            End If


            '--Generando el Numero de Analiss
            'If dtImprimir.Rows.Count > 0 And dtImprimir.Rows(0).Item("IS_GUIA_ANALISIS").ToString = "S" Then
            '    GenerarNumeroAnalisis(CboAlmacen.SelectedValue.ToString(), IIf(TipoMov = "I", "NI", "NS"), alm_cabBE.NUMBER_DOCUMENT)
            'End If

            '--Actualizando el Estado para Control de Calidad MP'
            'If CboAlmacen.SelectedValue.ToString = "18" And documentId = "NI" And TipoMov = "I" Then
            '    clsBusquedaBl = New ClsBuscar
            '    clsBusquedaBl.ActualizandoEstadoControl_C(CboAlmacen.SelectedValue.ToString(), IIf(TipoMov = "I", "NI", "NS"), alm_cabBE.NUMBER_DOCUMENT)
            'End If
            '--Actualizando el Estado para Control de Calidad PT'
            'If CboAlmacen.SelectedValue.ToString = "04" And documentId = "NI" And TipoMov = "I" And cboTipoMovimiento.SelectedValue = "IP" And txtTipoDocumentoRef.Text = "GP" Then
            '    clsBusquedaBl = New ClsBuscar
            '    clsBusquedaBl.ActualizandoEstadoControl_C(CboAlmacen.SelectedValue.ToString(), IIf(TipoMov = "I", "NI", "NS"), alm_cabBE.NUMBER_DOCUMENT)
            'End If
            '--guardando CantidadAsigandaLote
            Me.Cursor = Cursors.Default
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

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


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs)
        GenerarIngresoSalidaAlmacen()
        EnviarMail()
        Nuevo()
    End Sub

    Private Sub EnviarMail()
        Try
            Dim dt_envio_mail As DataTable
            dt_envio_mail = New DataTable
            dt_envio_mail = clsBusquedaBl.get_VerificarEnvioEmail(Ref_trasactiontype, Ref_tipo)
            If dt_envio_mail.Rows.Count() <> 0 Then
                If dt_envio_mail.Rows(0).Item("is_send_mail").ToString() = "1" Then
                    Dim envio_mail As New LibManufactura.FrmEnvioEmail
                    envio_mail._almacen_id = Ref_idalamacen
                    envio_mail._document_id = Ref_documentid
                    envio_mail._number_document = Ref_numerodocument
                    envio_mail._codigo_datos_email = dt_envio_mail.Rows(0).Item("codigo_envio_email").ToString
                    envio_mail.ShowDialog()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                        Dim frmG As New frmGuiaAnalisis
                        frmG.idAlmacen = Ref_idalamacen
                        frmG.documentId = Ref_documentid
                        frmG.NumeroDocumento = Ref_numerodocument
                        frmG.ShowDialog()
                        frmG.Close()
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

    Private Sub btnGuiaAnalisis_Click(sender As Object, e As EventArgs)
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

    Private Sub AnularDocumentosAlmacen()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim Num_Oc As String = String.Empty
            Dim Usuario As String = String.Empty
            Dim Num_GSI As String = String.Empty
            Dim Doc_GSI As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Num_Oc = dgvCabeceraAlmacen.CurrentRow.Cells("NUMBER_PURCHASE").ToString
            Num_GSI = dgvCabeceraAlmacen.CurrentRow.Cells("NUM_ID_REF").Value
            Doc_GSI = dgvCabeceraAlmacen.CurrentRow.Cells("DOC_ID_REF").Value
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.AnularDocumentosAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument, Usuario, Num_Oc, Num_GSI, Doc_GSI)
            Dim msj As String = String.Empty
            msj = "Documento anulado Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            MostrandoDatosGeneralesCabeceraAlmacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Dim TIPOTRANSACCION As String = String.Empty
        TIPOTRANSACCION = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value
        If TipoMov = "I" And TIPOTRANSACCION = "TD" Or TIPOTRANSACCION = "LC" Then
            MsgBox("No se puede eliminar la transaccion eliminela desde su origen.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarDocumentosAlmacen()
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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        pnlprincipal.Visible = True
        Modo_consultar = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        gbOpciones.Visible = True
        gbCabceraDocumento.Enabled = True
        gbLeyenda.Visible = True
        dgvdetalleAlmacen.Visible = True
        dgvDetalle.Visible = False
        Limpiar()
        MostrandoDatosGeneralesCabeceraAlmacen()
        Botonera_Estado_Cambiar(False)
        btnEliminar.Enabled = NIVEL_ACCESO()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If FechaFacturacion_Mes_anterior(dtpFecha.Value.Month, dtpFecha.Value.Year) = False Then
                Exit Sub
            End If
        End If
    End Sub
    Private Function FechaFacturacion_Mes_anterior(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            'Mes_Ant = "12"
            'Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            ' End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("El mes seleccionado se encuentra cerrado," & Chr(13) & "aperturar para proceder con el movimiento.", MsgBoxStyle.Critical)
                    Estado = False
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

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
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Dim LISTA_NI As String = ""
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                dtImprimir = New DataTable
                dtImprimir = reporteBL.Verificar_Devolucion_Rep_Medico(txtTipoDocumentoRef.Text, txtNumeroReferencia.Text)
                If dtImprimir.Rows.Count() <> 0 Then
                    For I = 0 To dtImprimir.Rows.Count - 1
                        LISTA_NI = LISTA_NI & dtImprimir.Rows(I).Item("ALMACEN").ToString & " " & dtImprimir.Rows(I).Item("DOCUMENT_ID").ToString & " " & dtImprimir.Rows(I).Item("NUMBER_DOCUMENT").ToString & " " & dtImprimir.Rows(I).Item("DATE_DOCUMENT").ToString & vbCrLf
                    Next
                    MsgBox("El documento de refencia elegido ya se encuentra" & vbCrLf & "registrado en los siguientes documentos:" & LISTA_NI, MsgBoxStyle.Information, "Aviso")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtordenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtordenCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtorderFabricacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtorderFabricacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboAlmacenBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmacenBusqueda.SelectedIndexChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub txtNumeroReferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroReferencia.KeyDown
        If cboTipoMovimiento.Text = "DEVOLUCION DE MERCADERIA REP. MEDICO" Then
            txtNumeroReferencia.ReadOnly = True
            If e.KeyCode = Keys.F1 Then
                Numero_documento()
            End If
        Else
            txtNumeroReferencia.ReadOnly = False
        End If
    End Sub

    Private Sub txtNumeroReferencia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtNumeroReferencia.MouseDoubleClick
        If cboTipoMovimiento.Text = "DEVOLUCION DE MERCADERIA REP. MEDICO" Then
            Numero_documento()
        End If

        If txtTipoDocumentoRef.Text = "RM" Then

            Try

                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_REQUERIMIENTO_MATERIAL"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Requerimientos de Material"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Requerimiento_Material(txtNumeroReferencia.Text, txtTipoDocumentoRef.Text)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
                        dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If txtTipoDocumentoRef.Text = "GD" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_GUIA_DEVOLUCION_AUTORIZADO"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Guias de Devolucion"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Guia_Devolucion(txtNumeroReferencia.Text, txtTipoDocumentoRef.Text)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
                        dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If txtTipoDocumentoRef.Text = "PE" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_LISTA_PARTE_ENTREGA"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Partes de Entrega"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Parte_Entrega(CInt(txtNumeroReferencia.Text))

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
                        dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If txtTipoDocumentoRef.Text = "OP" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_PRODUCCION_OP_PRODUCTOS_LISTA_OPS"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Ordenes de Producción"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Dim _ITEM As Integer
                    txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item("N.OP").ToString
                    _ITEM = frm.Data_Matriz.Rows(0).Item("ITEM").ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Orden_Produccion(CInt(txtNumeroReferencia.Text), _ITEM)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
                        dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If txtTipoDocumentoRef.Text = "OD" Then
            Try
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "ALM_SP_S_PRODUCCION_OP_PRODUCTOS_LISTA_ODS"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Ordenes de Desarrollo"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    Dim _ITEM As Integer
                    txtNumeroReferencia.Text = frm.Data_Matriz.Rows(0).Item("N.OP").ToString
                    _ITEM = frm.Data_Matriz.Rows(0).Item("ITEM").ToString

                    clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                    clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE

                    dtdetalleArticuloPrincipal = clsAlmacenDetBl.get_Orden_Desarrollo(CInt(txtNumeroReferencia.Text), _ITEM)

                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvdetalleAlmacen.DataSource = dtdetalleArticuloPrincipal
                        dgvdetalleAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en este Documento.", MsgBoxStyle.Information)
                        GenerarColummnaDataTable()
                    End If

                End If
                frm.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlprincipal.Visible = True
        Modo_consultar = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = False
        gbOpciones.Visible = True
        gbCabceraDocumento.Enabled = True
        gbLeyenda.Visible = True
        dgvdetalleAlmacen.Visible = True
        dgvDetalle.Visible = False
        Limpiar()
        MostrandoDatosGeneralesCabeceraAlmacen()
        Botonera_Estado_Cambiar(False)
        btnEliminar.Enabled = NIVEL_ACCESO()
    End Sub

    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        imprimirAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Dim TIPOTRANSACCION As String = String.Empty
        TIPOTRANSACCION = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value

        ref_fecha_doc = dgvCabeceraAlmacen.Item(4, dgvCabeceraAlmacen.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If TipoMov = "I" And TIPOTRANSACCION = "TD" Or TIPOTRANSACCION = "LC" Then
            MsgBox("No se puede eliminar la transaccion eliminela desde su origen.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EliminarDocumentosAlmacen()
        End If
    End Sub

    Private Function Verificar_Documento_cerrado(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            'If Mes_Ant = 1 Then
            'Mes_Ant = "12"
            'Anio_Ant = CInt(Anio_Ant) - 1
            'Else
            '    Mes_Ant = CInt(Mes_Ant) - 1
            '    Anio_Ant = anyo
            ' End If
            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.ValidarFechaVentas(Mes_Ant, Anio_Ant, "CIERRE")
            If dtCierre.Rows.Count() <> 0 Then
                ' Dim Resultado As Integer
                If dtCierre.Rows(0).Item(0) = 1 Then
                    MsgBox("El documento pertenece a un mes cerrado, no procede la transacción.", MsgBoxStyle.Critical)
                    Estado = False
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnGuiaAnalisis_Click_1(sender As Object, e As EventArgs) Handles btnGuiaAnalisis.Click
        GenerarGuiaAnalisis()
    End Sub

    Private Sub btnGrabar_Click_1(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Verificar_Apertura_Cierre_Modulos(dtpFecha.Value.Month, dtpFecha.Value.Year) = False Then
            Exit Sub
        End If

        Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS

        If dgvdetalleAlmacen.RowCount = 0 Then
            Exit Sub
        End If

        If TipoMov = "S" Then
            Dim cantidad_evaluar As Double
            Dim dt_cantidad As DataTable
            For Each Fila As DataGridViewRow In dgvdetalleAlmacen.Rows
                cantidad_evaluar = 0
                dt_cantidad = New DataTable
                If Not Fila Is Nothing Then
                    dt_cantidad = almacenBL.get_VerificarCantidad_Lote_Analis(CboAlmacen.SelectedValue.ToString, Fila.Cells("CODIGO").Value, Fila.Cells("LOTE").Value, Fila.Cells("NUMERO_ANALISIS").Value)
                    For Each MiDataRow As DataRow In dt_cantidad.Rows
                        cantidad_evaluar = MiDataRow("CANTIDAD")
                    Next
                    If cantidad_evaluar < Fila.Cells("CANTIDAD").Value Then
                        MsgBox("La cantidad ingresada es mayor que el stock" & Chr(13) & "Verificar el Item: " + Fila.Cells("ITEM").Value.ToString, MsgBoxStyle.Exclamation, "Sistemas")
                        Exit Sub
                    End If
                End If
            Next
        End If
        

        If GenerarIngresoSalidaAlmacen() Then
            'EnviarMail()
            If Modo_actualizar = True Then
                btnCancelar_Click(sender, e)
            Else
                Nuevo()
            End If
        End If
    End Sub

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "ALMACENES")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar el INGRESO/SALIDA.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        dtpFecha.MaxDate = "31/12/9998"
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        Modo_consultar = True
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
        MostrarModoEdicion(Ref_idalamacen, Ref_documentid, Ref_numerodocument)

        pnlprincipal.Visible = False
        GbCabecera.Enabled = False
        GbdetalleDocumento.Enabled = True
        gbOpciones.Visible = False
        gbCabceraDocumento.Enabled = True
        gbLeyenda.Visible = False
        dgvdetalleAlmacen.Visible = False
        dgvDetalle.Visible = True
        dgvDetalle.ReadOnly = True
        Call Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Nuevo()
    End Sub

    Private Sub dtpFecha_Leave(sender As Object, e As EventArgs) Handles dtpFecha.Leave
        If FechaFacturacion_Mes_anterior(dtpFecha.Value.Month, dtpFecha.Value.Year) = False Then
            Exit Sub
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If Modo_consultar = False Then
            If dtpFecha.Value <> Date.Now Then
                dtpFecha.MaxDate = Date.Now
            End If
        End If
    End Sub

    Private Sub txtNumeroReferencia_Leave(sender As Object, e As EventArgs) Handles txtNumeroReferencia.Leave
        If txtNumeroReferencia.Text.Trim().Length > 0 Then
            If documentId = "NI" And cboTipoMovimiento.SelectedValue = "IP" And CboAlmacen.SelectedValue = "04" And txtTipoDocumentoRef.Text = "GP" Then
                txtNumeroReferencia.Text = txtNumeroReferencia.Text.PadLeft(7, Char.Parse("0"))
            End If
        End If
    End Sub

    Private Sub dtpfechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicial.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub dtpfechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechafinal.ValueChanged
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub txtprodafabricar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprodafabricar.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Producto()
        End If
    End Sub

    Private Sub txtprodafabricar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprodafabricar.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtprodafabricar.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtprodafabricar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtprodafabricar.MouseDoubleClick
        Ayuda_Producto()
    End Sub

    Private Sub Tool_Anular_Click(sender As Object, e As EventArgs) Handles Tool_Anular.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        Dim TIPOTRANSACCION As String = String.Empty
        TIPOTRANSACCION = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value

        ref_fecha_doc = dgvCabeceraAlmacen.Item(4, dgvCabeceraAlmacen.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        If TipoMov = "I" And TIPOTRANSACCION = "TD" Or TIPOTRANSACCION = "LC" Then
            MsgBox("No se puede anular la transaccion. Anule desde su origen.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Se va a anular el registro" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AnularDocumentosAlmacen()
        End If
    End Sub

    Private Sub dgvCabeceraAlmacen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabeceraAlmacen.CellFormatting

        If dgvCabeceraAlmacen.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        Else
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabeceraAlmacen.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub dgvDetalle_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalle.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
        'AddHandler validar.KeyPress, AddressOf PresionaEnter_KeyPress
    End Sub
    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
       ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetalle.CurrentCell.ColumnIndex
        If columna = 10 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or _
           (caracter = ChrW(Keys.Back)) Or _
           (caracter = ".") And _
           (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btn_act_costos_Click(sender As Object, e As EventArgs) Handles btn_act_costos.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        dtpFecha.MaxDate = "31/12/9998"
        Ref_idalamacen = String.Empty
        Ref_documentid = String.Empty
        Ref_numerodocument = String.Empty
        Modo_consultar = True
        Modo_actualizar = True
        If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub

        ref_fecha_doc = dgvCabeceraAlmacen.Item(4, dgvCabeceraAlmacen.CurrentRow.Index).Value

        If Verificar_Documento_cerrado(CDate(ref_fecha_doc).Month, CDate(ref_fecha_doc).Year) = False Then
            Exit Sub
        End If

        MostrarModoEdicion(Ref_idalamacen, Ref_documentid, Ref_numerodocument)

        pnlprincipal.Visible = False
        GbCabecera.Enabled = True
        GbdetalleDocumento.Enabled = True 'True
        gbOpciones.Visible = False
        gbCabceraDocumento.Enabled = True 'False
        gbLeyenda.Visible = False
        dgvdetalleAlmacen.Visible = False
        dgvDetalle.Visible = True
        GbTransaccion.Enabled = False
        dgvDetalle.ReadOnly = False
        'dgvDetalle.Columns(0).DefaultCellStyle.Format = "N2"

        Call Botonera_Estado_Cambiar(True)
        If _MOV_VALORIZADO = "V" Then
            btnGrabar.Enabled = True
            dgvDetalle.Columns(10).Visible = True
        Else
            btnGrabar.Enabled = False
            dgvDetalle.Columns(10).Visible = False
        End If
    End Sub
End Class