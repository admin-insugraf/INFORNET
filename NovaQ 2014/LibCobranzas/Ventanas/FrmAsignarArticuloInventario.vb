Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarArticuloInventario

    Public AlmacenOrigen As String
    Public TipoMov As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Public dtdetalleArticulo As DataTable
    Public ValidacionLotes As String = String.Empty
    Public ft_sin_descargo As Boolean = False
    Public fl_close As Boolean = False
    Public Qt_saldo As Double = 0.0
    Public flag_PrecioSinIgv As Boolean = False
    Public ItemLote As String = String.Empty
    Dim fl_Lot As String = String.Empty
    Public dtDetallesBulto As DataTable

    Public Property EsValorizado As Boolean
    Dim FlagLote As Boolean = True
    Public Flag_ModoEdicion As Boolean = False
    Public Identificador As String = String.Empty
    Public TransaccionTipoArticulo As String = String.Empty
    Dim CantidadUpdate As Double

    Dim clsBusquedaBl As ClsBuscar
    Dim dtData As DataTable

    Public Sub BultosGenerarColummnaDataTable()
        dtDetallesBulto = New DataTable
        dtDetallesBulto.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("LOTE", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtDetallesBulto.Columns.Add("QTY", Type.GetType("System.Double"))
        dtDetallesBulto.Columns.Add("QTY_BULTOS", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticulo.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("NRO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NRO_BULTOS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("MONTO", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("OPT_ENTREGA", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PROCEDENCIA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PAIS_ORIGEN", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub MostrarFechaVencimiento(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        cadena = "SELECT CADUCATE_DATE FROM lot WHERE LOT_ID='" & codigooLote & "' and WHO_ID='" & AlmacenOrigen & "' "
        Dim fecha As String = String.Empty
        dtTableFecha = LibData.Run_Query_DataTable(cadena)
        LibData.Dispose()
        If dtTableFecha.Rows.Count() <> 0 Then
            fecha = dtTableFecha.Rows(0).Item(0).ToString()
            dtpFechaVencimiento.Text = Format(fecha, "Short date")
        End If
    End Sub

    Private Sub MostrandoLotes(ByVal codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            '++Informacion de Lotes
            dtlote = New DataTable
            dtlote = clsArticuloBl.get_InventarioArticuloLote(AlmacenOrigen, codigoArticulo, ValidacionLotes, TipoMov)
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DataSource = dtlote
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"
                If cboLotes.Items.Count() <> 0 Then
                    cboLotes.SelectedIndex = 0
                    If ItemLote <> String.Empty Then
                        cboLotes.Text = ItemLote.ToString
                    End If
                    txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                    MostrarFechaVencimiento(cboLotes.Text)
                    cboLotes.Enabled = True
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                End If
            Else
                MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad, Verifique.", MsgBoxStyle.Information)
                cboLotes.Enabled = False
                txtcantidad.Enabled = False
                btnAceptar.Visible = False
                txtcantidad.Text = String.Empty
                txtStockLote.Text = String.Empty
                cboLotes.DataSource = Nothing
                txtcodigoArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoArticulos(ByVal TipoMovimiento As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            If TipoMovimiento = "S" Then
                sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_S_TRASL"
            End If
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm._Flag_Inventario = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtStock.Text = Format(Stock, "##,##0.0.0")
                If TipoMovimiento = "I" Then
                    fl_Lot = String.Empty
                    fl_Lot = frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    cboLotes.Select()
                ElseIf TipoMovimiento = "S" Then
                    fl_Lot = String.Empty
                    fl_Lot = frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    'btnNuevoLote.Enabled = False
                    'MostrandoLotes(txtcodigoArticulo.Text)
                    'cboLotes.Select()
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LimpiarLotes()
        cboLotes.DataSource = Nothing
        txtStockLote.Text = ""
        dtpFechaVencimiento.Text = Date.Now
        GroupBox4.Enabled = False
        FlagLote = False
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsArticuloBl.get_InventarioVerificacionArticuloCodigo(AlmacenOrigen, _codigoArticulo, TransaccionTipoArticulo, TipoMov)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0")
                If TipoMov = "I" Then
                    fl_Lot = String.Empty
                    fl_Lot = dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    cboLotes.Select()
                ElseIf TipoMov = "S" Then
                    fl_Lot = String.Empty
                    fl_Lot = dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    cboLotes.Select()
                    'MostrandoLotes(txtcodigoArticulo.Text)
                    'cboLotes.Select()
                End If
            Else
                MsgBox("No hay informacion con el Codigo Especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtStock.Text = String.Empty
                txtStockLote.Text = String.Empty
                cboLotes.DataSource = Nothing
                txtcodigoArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos(TipoMov)
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos(TipoMov)
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
            End If
        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                AgregarArticuloManual(dtdetalleArticulo.Rows(0).Item("CODIGO").ToString)
                CantidadUpdate = 0.0
                CantidadUpdate = dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                txtcantidad.Text = dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                cboLotes.Text = dtdetalleArticulo.Rows(0).Item("LOTE").ToString
                txtnumeroProtocolo.Text = dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO").ToString
                txtMonto.Text = dtdetalleArticulo.Rows(0).Item("MONTO").ToString
                txtnumerobultos.Text = dtdetalleArticulo.Rows(0).Item("NRO_BULTOS").ToString
                If dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA").ToString = "0" Then
                    rbparcial.Checked = True
                ElseIf dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA").ToString = "1" Then
                    rbfinal.Checked = True
                End If
                If String.IsNullOrEmpty(dtdetalleArticulo.Rows(0).Item("NRO_BULTOS").ToString) Then
                    txtnumerobultos.Text = ""
                Else
                    LLenarDatosBultos(Flag_ModoEdicion)
                    AjustarTamaño(True)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos(TipoMov)
    End Sub

    Private Sub FrmAsignarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsValorizado = True Then
            txtMonto.Enabled = True
        End If
        If TipoMov = "S" Then
            btnNuevoLote.Visible = True
            btnNuevoLote.Enabled = True
        End If
        If Flag_ModoEdicion = True Then
            ModoEdicion()
        Else
            GenerarColummnaDataTable()
            BultosGenerarColummnaDataTable()
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If String.IsNullOrEmpty(txtcodigoArticulo.Text) Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Information)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            Else
                clsArticuloBl = New ClsOperaciones.PART
                dtDocumentoGuias = New DataTable
                dtDocumentoGuias = clsArticuloBl.get_InventarioVerificacionArticuloCodigo(AlmacenOrigen, txtcodigoArticulo.Text, TransaccionTipoArticulo, TipoMov)
                If dtDocumentoGuias.Rows.Count() = 0 Then
                    MsgBox("Error de Codigo de Articulo, verifique.", MsgBoxStyle.Information)
                    txtcodigoArticulo.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            If FlagLote = True Then
                If String.IsNullOrEmpty(cboLotes.Text) Then
                    MsgBox("Es necesario elegir un Lote, si no existe puede Crearlo.", MsgBoxStyle.Information)
                    cboLotes.Focus()
                    estado = False
                    Exit Try
                End If
            End If

            If String.IsNullOrEmpty(txtcantidad.Text) Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information)
                estado = False
                txtcantidad.Select()
                Exit Try
            ElseIf Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If
            If Flag_ModoEdicion Then
                If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
                    If txtnumerobultos.TextLength <> 0 Then
                        LLenarDatosBultos(False)
                        CantidadUpdate = txtcantidad.Text
                        AjustarTamaño(True)
                        MsgBox("Se modificaron los datos  en relacion a los Bultos.", MsgBoxStyle.Information)
                        estado = False
                        Exit Try
                    End If
                End If
            End If
            If txtnumerobultos.TextLength <> 0 Then
                If Val(txtnumerobultos.Text) <= 0 Then
                    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
                    txtnumerobultos.Focus()
                    estado = False
                    Exit Try
                End If
                If txtcantidad.Text < Val(txtnumerobultos.Text) Then
                    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                    txtnumerobultos.Select()
                    estado = False
                    Exit Try
                End If
                If dtDetallesBulto.Rows.Count() = 0 Then
                    AjustarTamaño(True)
                    GenerarColummnaDataTable()
                    LLenarDatosBultos(Flag_ModoEdicion)
                    MsgBox("No se agrego Datos de los Bultos.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
            Else
                BultosGenerarColummnaDataTable()
            End If
            If TipoMov = "S" Then
                If fl_Lot = "S" Then
                    If CDbl(txtStockLote.Text) < CDbl(txtcantidad.Text) Then
                        MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                        estado = False
                        txtcantidad.Select()
                        Exit Try
                    End If
                ElseIf fl_Lot = "N" Then
                    If CDbl(txtStock.Text) < CDbl(txtcantidad.Text) Then
                        MsgBox("La cantidad debe ser menor o igual que el  Stock por articulo.", MsgBoxStyle.Information)
                        estado = False
                        txtcantidad.Select()
                        Exit Try
                    End If
                End If
            End If
            If EsValorizado Then
                If String.IsNullOrEmpty(txtMonto.Text) Then
                    MsgBox("Se debe ingresar un Monto.", MsgBoxStyle.Information)
                    estado = False
                    txtMonto.Select()
                    Exit Try
                End If
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_ModoEdicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            If FlagLote = True Then
                row("LOTE") = cboLotes.Text
            Else
                row("LOTE") = cboLotes.Text
            End If
            row("CANTIDAD") = txtcantidad.Text
            row("NRO_PROTOCOLO") = IIf(txtnumeroProtocolo.Text = String.Empty, 0, txtnumeroProtocolo.Text)
            row("NRO_BULTOS") = IIf(txtnumerobultos.Text = String.Empty, "", txtnumerobultos.Text)
            If EsValorizado Then
                row("MONTO") = CDbl(txtmonto.Text)
            Else
                row("MONTO") = 0
            End If
            If rbparcial.Checked = True Then
                row("OPT_ENTREGA") = "0"
            ElseIf rbfinal.Checked = True Then
                row("OPT_ENTREGA") = "1"
            End If
            row("PROCEDENCIA") = txtprocedencia.Text
            row("PAIS_ORIGEN") = txtpais_origen.Text
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            If FlagLote = True Then
                row("LOTE") = cboLotes.Text
            Else
                row("LOTE") = cboLotes.Text
            End If
            row("CANTIDAD") = txtcantidad.Text
            row("NRO_PROTOCOLO") = IIf(txtnumeroProtocolo.Text = String.Empty, 0, txtnumeroProtocolo.Text)
            row("NRO_BULTOS") = IIf(txtnumerobultos.Text = String.Empty, "", txtnumerobultos.Text)
            If EsValorizado Then
                row("MONTO") = CDbl(txtmonto.Text)
            Else
                row("MONTO") = 0
            End If
            If rbparcial.Checked = True Then
                row("OPT_ENTREGA") = "0"
            ElseIf rbfinal.Checked = True Then
                row("OPT_ENTREGA") = "1"
            End If
            row("PROCEDENCIA") = txtprocedencia.Text
            row("PAIS_ORIGEN") = txtpais_origen.Text
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumerobultos.Focus()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        fl_close = True
        Me.Close()
    End Sub

    Private Sub txtcodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoArticulo.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtcodigoArticulo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboLotes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLotes.SelectedValueChanged
        If cboLotes.DataSource Is Nothing Then Exit Sub
        If cboLotes.Items.Count() <> 0 Then
            txtStockLote.Text = cboLotes.SelectedValue.ToString
            MostrarFechaVencimiento(cboLotes.Text)
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cboLotes_KeyDown(sender As Object, e As KeyEventArgs) Handles cboLotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumeroProtocolo.Focus()
        End If
    End Sub

    Private Sub btnNuevoLote_Click(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim frm As New frmAgregarLote
        frm.idProducto = txtcodigoArticulo.Text
        frm.idAlmacen = AlmacenOrigen
        frm.ShowDialog()
        MostrandoLotes(txtcodigoArticulo.Text)
        frm.Close()
    End Sub


    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(951, 401)
            Me.GroupBox2.Enabled = False
        Else
            Size = New System.Drawing.Size(588, 401)
            Me.GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataGridView, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = txtcodigoArticulo.Text
                If cboLotes.Text = String.Empty Then
                    row("LOTE") = ""
                Else
                    row("LOTE") = cboLotes.SelectedValue.ToString
                End If
                row("ITEM") = i + 1
                row("QTY") = txtcantidad.Text
                row("QTY_BULTOS") = CDbl(TablaOrigen.Item(2, i).Value)
                row("IDENTIFICADOR") = indice
                dtDetallesBulto.Rows.Add(row)
                dtDetallesBulto.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarDatosBultos(ByVal opcion As Boolean)
        Try
            If opcion Then
                BultosGenerarColummnaDataTable()
                AgregandoNuevosDatosBultos(dgvDetallesBulto, dtDetallesBulto, Identificador)
            Else
                BultosGenerarColummnaDataTable()
                AgregandoNuevosDatosBultos(dgvDetallesBulto, dtDetallesBulto, Identificador)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GuardarBultos() As Boolean
        Dim res As Boolean = True
        Try
            Dim SubTotal As Decimal
            Dim valor As String = String.Empty
            For i As Integer = 0 To dgvDetallesBulto.Rows.Count() - 1
                Dim value As Object = dgvDetallesBulto.Item(2, i).Value
                'If ((Convert.ToString(value) = String.Empty) OrElse (Not (IsNumeric(value)))) Then
                If (String.IsNullOrEmpty(value) OrElse (Not (IsNumeric(value)))) Then
                    MsgBox("No se ingreso un Numero en la posicion :" & i + 1, MsgBoxStyle.Information)
                    dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, i)
                    res = False
                    Exit Try
                End If
                SubTotal += value
            Next
            'Mostrando La cantidad Asignada.
            txtCantidadAsiganda.Text = SubTotal
            If CDbl(txtcantidad.Text) <> SubTotal Then
                MsgBox("La Cantidad Asignada a cada Bultos en total debe ser igual a : " & txtcantidad.Text, MsgBoxStyle.Information)
                res = False
                Exit Try
            End If
            AgregarDatosBultos(Flag_ModoEdicion)
            AjustarTamaño(False)
        Catch ex As Exception
            res = False
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub
    Private Sub txtnumeroProtocolo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumeroProtocolo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmonto.Focus()
        End If
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
       ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetallesBulto.CurrentCell.ColumnIndex
        If columna = 2 Then
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

    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
   ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetallesBulto.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress

    End Sub

    Private Sub LLenarDatosBultos(ByVal Opcion As Boolean)
        Try
            If Opcion = True Then
                If dtDetallesBulto.Rows.Count() <> 0 Then
                    dgvDetallesBulto.Rows.Clear()
                    For i As Integer = 0 To dtDetallesBulto.Rows.Count() - 1
                        dgvDetallesBulto.Rows.Add(i + 1, dtDetallesBulto.Rows(i).Item("QTY"), dtDetallesBulto.Rows(i).Item("QTY_BULTOS"))
                    Next
                    txtCantidadAsiganda.Text = txtcantidad.Text
                Else
                    Dim CantidadTotal As String = String.Empty
                    If IsNumeric(txtcantidad.Text) Or txtcantidad.Text <> String.Empty Then
                        dgvDetallesBulto.Rows.Clear()
                        For i As Integer = 0 To txtnumerobultos.Text - 1
                            dgvDetallesBulto.Rows.Add(i + 1, txtcantidad.Text, "0.0")
                        Next
                    End If
                End If
            Else
                If dtDetallesBulto.Rows.Count() <> 0 Then dgvDetallesBulto.Rows.Clear()
                Dim CantidadTotal As String = String.Empty
                If IsNumeric(txtcantidad.Text) Or txtcantidad.Text <> String.Empty Then
                    dgvDetallesBulto.Rows.Clear()
                    For i As Integer = 0 To txtnumerobultos.Text - 1
                        dgvDetallesBulto.Rows.Add(i + 1, txtcantidad.Text, "0.0")
                    Next
                End If
                dgvDetallesBulto.BeginEdit(True)
                dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, 0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgvDetallesBulto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetallesBulto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarBultos_Click(sender, e)
        End If
    End Sub

    Private Sub btnAceptarBultos_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAceptarBultos.KeyDown
        If e.KeyCode = Keys.Enter Then
            GuardarBultos()
        End If
    End Sub

    Private Sub btnAceptarBultos_Click(sender As Object, e As EventArgs) Handles btnAceptarBultos.Click
        If GuardarBultos() = False Then
            Exit Sub
        Else
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub txtnumerobultos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumerobultos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If txtcantidad.Text = String.Empty Then
            '    txtcantidad.Focus()
            '    Exit Sub
            'End If
            'If txtnumerobultos.TextLength <> 0 Then
            'If Val(txtnumerobultos.Text) <= 0 Then
            '    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
            '    txtnumerobultos.Focus()
            '    Exit Sub
            'End If
            'If txtnumerobultos.Text = String.Empty Then
            '    txtnumerobultos.Focus()
            '    Exit Sub
            'End If
            'If txtcantidad.Text < Val(txtnumerobultos.Text) Then
            '    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'If Flag_ModoEdicion Then
            '    If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
            '        LLenarDatosBultos(False)
            '        CantidadUpdate = txtcantidad.Text
            '        AjustarTamaño(True)
            '    ElseIf txtnumerobultos.TextLength <> 0 Then
            '        LLenarDatosBultos(False)
            '        AjustarTamaño(True)
            '    End If
            'Else
            '    AjustarTamaño(True)
            '    'BultosGenerarColummnaDataTable()
            '    LLenarDatosBultos(Flag_ModoEdicion)
            'End If
            'Else
            'btnAceptar_Click(sender, e)
            txtprocedencia.Focus()
            'End If
        End If
    End Sub

    Private Sub SalirBultos_Click(sender As Object, e As EventArgs) Handles SalirBultos.Click
        AjustarTamaño(False)
    End Sub

    Private Sub txtnumeroProtocolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroProtocolo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcodigoArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoArticulo.TextChanged

    End Sub

    Private Sub txtcodigoArticulo_TabIndexChanged(sender As Object, e As EventArgs) Handles txtcodigoArticulo.TabIndexChanged

    End Sub

    Private Sub txtprocedencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprocedencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            'btnAceptar_Click(sender, e)
            txtpais_origen.Focus()
        End If
    End Sub

    Private Sub txtpais_origen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpais_origen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcantidad.Text = String.Empty Then
                txtcantidad.Focus()
                Exit Sub
            End If
            If txtnumerobultos.TextLength <> 0 Then
                If Val(txtnumerobultos.Text) <= 0 Then
                    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
                    txtnumerobultos.Focus()
                    Exit Sub
                End If
                If txtnumerobultos.Text = String.Empty Then
                    txtnumerobultos.Focus()
                    Exit Sub
                End If
                If txtcantidad.Text < Val(txtnumerobultos.Text) Then
                    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If Flag_ModoEdicion Then
                    If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
                        LLenarDatosBultos(False)
                        CantidadUpdate = txtcantidad.Text
                        AjustarTamaño(True)
                    ElseIf txtnumerobultos.TextLength <> 0 Then
                        LLenarDatosBultos(False)
                        AjustarTamaño(True)
                    End If
                Else
                    AjustarTamaño(True)
                    'BultosGenerarColummnaDataTable()
                    LLenarDatosBultos(Flag_ModoEdicion)
                End If
            Else
                btnAceptar_Click(sender, e)
            End If
        End If
    End Sub
End Class