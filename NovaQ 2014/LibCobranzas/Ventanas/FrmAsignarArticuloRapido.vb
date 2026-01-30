Imports System.Windows.Forms
Imports LibCobranzas
Public Class FrmAsignarArticuloRapido

    Public AlmacenOrigen As String
    Public TipoDocumento As String
    Public NumeroSerie As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim clsDescuento As New ClsTransacciones.clsDescuentosArticulos
    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    Public ValidacionLotes As String = String.Empty
    'Public ValidacionLotes As List(Of FrmFacturacionRapida.StructuraPart)
    Dim dtValidacionLotes As DataTable
    Public Flag_Modo_Edicion As Boolean = False
    Public ft_sin_descargo As Boolean = False
    Public fl_close As Boolean = False
    Public Qt_saldo As Double = 0.0
    Public flag_PrecioSinIgv As Boolean = False
    Public Flag_FacturaGuiaVenta As Boolean = False
    Public Flag_FacturaExistencias As Boolean = False
    Public Flag_Factura_directa As Boolean = False
    Public Flag_Factura_Rep_medico As Boolean = False
    Public _ARTS_INICIALES As String = ""

    Public Flag_Factura_Pedido As Boolean = False
    Public Flag_Factura_Dev As Boolean = False

    Public _DT_SALDO_INICIAL As DataTable
    Public _DT_SALDO_PRINCIPAL As DataTable

    Public _ARTICULO As String = String.Empty
    Public _LOTE As String = String.Empty
    Public _CANTIDAD As Double = 0

    Public Flag_Cliente As String = String.Empty
    Public Fl_NC_REF As Boolean = False
    Dim _TipoControlInventario As String = ""

    Private Sub FrmAsignarArticuloRapido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmAsignarArticuloRapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In ValidacionLotes
            Dim row As DataRow = dtValidacionLotes.NewRow
            'row("CODIGO") = item.Codigo
            'row("CANTIDAD") = item.Cantidad
            'row("LOTE") = item.Lote
            dtValidacionLotes.Rows.Add(row)
            dtValidacionLotes.AcceptChanges()
        Next
        If TipoDocumento = "NC" Then
            btnNuevoLote.Visible = True
            btnNuevoLote.Enabled = True
        End If
        If Flag_Modo_Edicion = True Then
            ModoEdicion()
            If Flag_Factura_Rep_medico = True Then
                gb_articulo.Enabled = False
                GroupBox4.Enabled = False
            Else
                If Flag_Factura_Pedido = True Then
                    gb_articulo.Enabled = False
                ElseIf Flag_Factura_Dev = True Then
                    gb_articulo.Enabled = False
                Else
                    gb_articulo.Enabled = True
                End If
                GroupBox4.Enabled = True
            End If
        Else
            GenerarColummnaDataTable()

        End If
        If Flag_FacturaGuiaVenta = True Then
            txtsaldo.Text = IIf(String.IsNullOrEmpty(Qt_saldo), 0, Qt_saldo)
            If Flag_FacturaGuiaVenta = True Then
            End If
            txtsaldo.Text = Format(Qt_saldo, "##,##0.0.0")
        Else
            If TipoDocumento = "NC" Then
                If txtcodigoArticulo.Text = "N0005" Or txtcodigoArticulo.Text = "N0006" Or txtcodigoArticulo.Text = "N0007" Then
                    txtcantidad.Enabled = False
                    txtcantidad.Text = 1
                End If
            Else
                txtcantidad.Enabled = True
            End If
            txtcodigoArticulo.Enabled = True
        End If
        If Flag_FacturaExistencias = True Then
            GroupBox4.Enabled = False
            txtlotemanual.Text = _LOTE
            txtlotemanual.Visible = True
        Else
            GroupBox4.Enabled = True
            txtlotemanual.Visible = False
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Information)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            ElseIf txtprecioUnitario.Text = String.Empty Then
                MsgBox("Debe ingresar el Precio Unitario.", MsgBoxStyle.Information)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            ElseIf txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information)
                estado = False
                txtcantidad.Select()
                Exit Try
            End If
            If txtigvpor.Text = "" Then
                MsgBox("El I.G.V. no puede estar en blanco.", MsgBoxStyle.Information)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            End If
            If Val(txtigvpor.Text) < 0 Then
                MsgBox("El I.G.V. debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtigvpor.Focus()
                Exit Try
            End If
            If Val(txtprecioUnitario.Text) <= 0 Then
                MsgBox("El precio debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            End If
            If Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If

            If txtcantidad.Text = String.Empty Then
                txtcantidad.Focus()
                estado = False
                Exit Try
            End If

            Dim LibData As New LibConexion.ClsData
            Dim dtTableFecha As DataTable
            Dim cadena As String
            cadena = "SELECT * FROM dbo.NUMBER_DOCUMENT WHERE TYPE_DOC='" & TipoDocumento & "' AND NUMBER_SERIE='" & NumeroSerie & "' "
            Dim FLAG_VALIDA_STOCK As String = String.Empty
            dtTableFecha = LibData.Run_Query_DataTable(cadena)
            If dtTableFecha.Rows.Count() <> 0 Then
                FLAG_VALIDA_STOCK = dtTableFecha.Rows(0).Item("IS_STOCK").ToString()
            End If

            If FLAG_VALIDA_STOCK = "S" Then
                If Flag_FacturaExistencias = False Then
                    If TipoDocumento <> "NC" And TipoDocumento <> "ND" Then
                        If Flag_FacturaGuiaVenta = False Then
                            If _TipoControlInventario = "LOTE" Then
                                If CDbl(IIf(txtStockLote.Text = "", 0, txtStockLote.Text)) < CDbl(txtcantidad.Text) Then
                                    MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                                    estado = False
                                    txtcantidad.Select()
                                    Exit Try
                                End If
                            ElseIf _TipoControlInventario = "LIBRE" Then
                                If CDbl(IIf(txtStock.Text = "", 0, txtStock.Text)) < CDbl(txtcantidad.Text) Then
                                    MsgBox("La cantidad debe ser menor o igual que el  Stock.", MsgBoxStyle.Information)
                                    estado = False
                                    txtcantidad.Select()
                                    Exit Try
                                End If
                            End If
                            If Flag_Factura_Pedido = True Then
                                If CDbl(IIf(txtsaldo.Text = "", 0, txtsaldo.Text)) < CDbl(txtcantidad.Text) Then
                                    MsgBox("La cantidad debe ser menor o igual que el  saldo.", MsgBoxStyle.Information)
                                    estado = False
                                    txtcantidad.Select()
                                    Exit Try
                                End If
                            End If
                        Else
                            If Flag_Cliente = "DL0211" Or Flag_Cliente = "DL0017" Then

                            Else
                                If Flag_Modo_Edicion = True Then
                                    If _TipoControlInventario = "LOTE" Then
                                        If CDbl(IIf(txtsaldo.Text = "", 0, txtsaldo.Text)) < CDbl(txtcantidad.Text) Then
                                            MsgBox("La cantidad debe ser menor o igual que el  saldo.", MsgBoxStyle.Information)
                                            estado = False
                                            txtcantidad.Select()
                                            Exit Try
                                        End If
                                    ElseIf _TipoControlInventario = "LIBRE" Then
                                        If CDbl(IIf(txtStock.Text = "", 0, txtStock.Text)) < CDbl(txtcantidad.Text) Then
                                            MsgBox("La cantidad debe ser menor o igual que el  saldo.", MsgBoxStyle.Information)
                                            estado = False
                                            txtcantidad.Select()
                                            Exit Try
                                        End If
                                    End If
                                Else
                                    'If txtStockLote.Text = 0 Or txtStockLote.Text = String.Empty Then
                                    '    MsgBox("Ya se ingreso el total del saldo para el Lote.", MsgBoxStyle.Information)
                                    '    estado = False
                                    '    txtcodigoArticulo.Select()
                                    'End If
                                    'If CDbl(txtStockLote.Text) < CDbl(txtcantidad.Text) Then
                                    '    MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                                    '    estado = False
                                    '    txtcantidad.Select()
                                    '    Exit Try
                                    'End If
                                    If Flag_Factura_Pedido = True Then
                                        If CDbl(IIf(txtsaldo.Text = "", 0, txtsaldo.Text)) < CDbl(txtcantidad.Text) Then
                                            MsgBox("La cantidad debe ser menor o igual que el  saldo.", MsgBoxStyle.Information)
                                            estado = False
                                            txtcantidad.Select()
                                            Exit Try
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click, Button1.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("CANTIDAD") = txtcantidad.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            If Flag_FacturaExistencias Then
                row("LOTE") = txtlotemanual.Text
            Else
                row("LOTE") = cboLotes.Text
            End If
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
            row("%DESC.ART_2") = CDbl(txtdescuento2.Text)
            row("VALOR_VENTA") = 0
            row("IGV_POR") = CDbl(txtigvpor.Text)
            row("IMP_DESC_01") = 0
            row("IMP_DESC_02") = 0
            row("PRECIO_IGV") = 0
            row("IGV_ART") = CDbl(txtigvpor.Text)
            row("IGV_ART_US") = CDbl(txtigvpor.Text)
            row("PRECIO_INICIAL") = txtprecioUnitario.Text
            row("TOTAL_INICIAL") = Math.Round(row("CANTIDAD") * row("PRECIO_INICIAL"), 6)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            'row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("CANTIDAD") = txtcantidad.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            If Flag_FacturaExistencias Then
                row("LOTE") = txtlotemanual.Text
            Else
                row("LOTE") = cboLotes.Text
            End If
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
            row("%DESC.ART_2") = CDbl(txtdescuento2.Text)
            row("VALOR_VENTA") = Math.Round(row("CANTIDAD") * row("PREC_UNITARIO"), 6)
            row("IMP_DESC_01") = 0
            row("IMP_DESC_02") = 0
            row("PRECIO_IGV") = 0
            row("IGV_ART") = 0
            row("IGV_ART_US") = 0
            row("PRECIO_INICIAL") = txtprecioUnitario.Text
            row("TOTAL_INICIAL") = Math.Round(row("CANTIDAD") * row("PRECIO_INICIAL"), 6)
            row("IGV_POR") = CDbl(txtigvpor.Text)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
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
            btnAceptar_Click(sender, e)
        End If
    End Sub



    Private Sub txtcodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoArticulo.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtcodigoArticulo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        'If e.KeyChar = ChrW(Keys.Enter) Then txtprecioUnitario.Focus()
    End Sub

    Private Sub cboLotes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLotes.SelectedValueChanged
        If cboLotes.DataSource Is Nothing Then Exit Sub
        If cboLotes.Items.Count() <> 0 Then
            If Flag_FacturaGuiaVenta = False Then
                txtStockLote.Text = cboLotes.SelectedValue.ToString
                MostrarFechaVencimiento(cboLotes.Text)
            End If
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioUnitario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtcantidad.Focus()
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescuento1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento1.KeyPress
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

    Private Sub txtdescuento2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento2.KeyPress
        ' If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
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
            txtcantidad.Select()
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

    Private Sub txtprecioUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioUnitario.KeyDown
        'If Flag_FacturaGuiaVenta = True Then
        '    If e.KeyCode = Keys.Enter Then
        '        btnAceptar_Click(sender, e)
        '    End If
        'End If
        'If e.KeyCode = Keys.Enter Then
        '    If txtcantidad.Enabled = False Then
        '        btnAceptar_Click(sender, e)
        '    End If
        'End If
    End Sub

    Private Sub txtdescuento2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescuento2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub txtlotemanual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlotemanual.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click, Button2.Click
        fl_close = True
        Me.Close()
    End Sub

    Private Sub txtcodigoArticulo_Leave(sender As Object, e As EventArgs) Handles txtcodigoArticulo.Leave
        If txtcodigoArticulo.Text = "" Then Exit Sub
        AgregarArticuloManual(txtcodigoArticulo.Text)

        'If txtcodigoArticulo.Text = "N0008" Or txtcodigoArticulo.Text = "N0006" Or Strings.Left(Trim(txtcodigoArticulo.Text), 2) = "ND" Or Strings.Left(Trim(txtcodigoArticulo.Text), 2) = "NC" Then
        '    'txtdescripcionArticulo.ReadOnly = False
        '    txtdescripcionArticulo.BackColor = Drawing.Color.White
        'Else
        '    txtdescripcionArticulo.ReadOnly = True
        '    txtdescripcionArticulo.BackColor = Drawing.Color.White
        'End If
    End Sub


    Private Sub txtigvpor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtigvpor.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub txtigvpor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtigvpor.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Public Sub GenerarColummnValidacionLotesGenerales()
        Try
            dtValidacionLotes = New DataTable
            dtValidacionLotes.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtValidacionLotes.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtValidacionLotes.Columns.Add("LOTE", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticulo.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PREC_UNITARIO", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("%DESC.ART_1", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("%DESC.ART_2", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("VALOR_VENTA", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IMP_DESC_01", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IMP_DESC_02", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PRECIO_IGV", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IGV_ART", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IGV_ART_US", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PRECIO_INICIAL", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("IGV_POR", Type.GetType("System.Double"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrarFechaVencimiento(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        cadena = "SELECT CADUCATE_DATE FROM lot  WHERE  PART_ID ='" & txtcodigoArticulo.Text & "' and  LOT_ID='" & codigooLote & "' and WHO_ID='" & AlmacenOrigen & "' "
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
            dtlote = clsArticuloBl.Fact_ArticuloLote(AlmacenOrigen, codigoArticulo, dtValidacionLotes, TipoDocumento, Flag_Factura_directa, Flag_Modo_Edicion, _LOTE, _CANTIDAD)
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"
                cboLotes.DataSource = dtlote
                If Flag_FacturaGuiaVenta = False Then
                    DgvDetalleLote.DataSource = dtlote
                    DgvDetalleLote.RowHeadersVisible = False
                    DgvDetalleLote.Columns(0).Width = 165
                    DgvDetalleLote.Columns(1).Width = 165
                End If
                If cboLotes.Items.Count() <> 0 Then
                    If Flag_Modo_Edicion = False Then
                        clsArticuloBl = New ClsOperaciones.PART
                        dtlote = New DataTable
                        dtlote = clsArticuloBl.get_UltimoLote(AlmacenOrigen, codigoArticulo)
                        If dtlote.Rows.Count() <> 0 Then
                            For i As Integer = 0 To cboLotes.Items.Count() - 1
                                cboLotes.SelectedIndex = i
                                Dim Lot As String = dtlote.Rows(0).Item("NUMBER_LOT").ToString
                                If cboLotes.Text.ToString = Lot Then
                                    Exit For
                                Else
                                    cboLotes.SelectedIndex = 0
                                End If
                            Next
                            If Flag_FacturaGuiaVenta = False Then
                                txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                                MostrarFechaVencimiento(cboLotes.Text)
                            Else
                                ''Guias de ventas Rastro
                                ''Guias de ventas Rastro
                                If Flag_Modo_Edicion = False Then
                                    Dim _CANTIDAD_TOTAL_LOTE As Double = 0.0
                                    Dim _CANTIDAD_LOTE As Double = 0.0
                                    Dim _DIF_CANTIDAD As Double = 0.0

                                    Dim Exis() As DataRow = _DT_SALDO_INICIAL.Select("LOTE ='" & cboLotes.Text & "'", "")
                                    If Exis.Count() <> 0 Then
                                        _CANTIDAD_TOTAL_LOTE = _DT_SALDO_INICIAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                        _CANTIDAD_LOTE = _DT_SALDO_PRINCIPAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                        If _CANTIDAD_TOTAL_LOTE = _CANTIDAD_LOTE Then
                                            txtStockLote.Text = _DIF_CANTIDAD
                                        Else
                                            _DIF_CANTIDAD = _CANTIDAD_TOTAL_LOTE - _CANTIDAD_LOTE
                                            txtStockLote.Text = _DIF_CANTIDAD
                                        End If
                                    End If
                                End If
                            End If
                            cboLotes.Enabled = True
                            txtcantidad.Enabled = True
                            btnAceptar.Visible = True
                        Else
                            cboLotes.SelectedIndex = 0
                            If _LOTE <> String.Empty Then
                                cboLotes.Text = _LOTE.ToString
                            End If
                            If Flag_FacturaGuiaVenta = False Then
                                txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                                MostrarFechaVencimiento(cboLotes.Text)
                            Else
                                ''Guias de ventas Rastro
                                ''Guias de ventas Rastro
                                If Flag_Modo_Edicion = False Then
                                    Dim _CANTIDAD_TOTAL_LOTE As Double = 0.0
                                    Dim _CANTIDAD_LOTE As Double = 0.0
                                    Dim _DIF_CANTIDAD As Double = 0.0
                                    Dim Exis() As DataRow = _DT_SALDO_INICIAL.Select("LOTE ='" & cboLotes.Text & "'", "")
                                    If Exis.Count() <> 0 Then
                                        _CANTIDAD_TOTAL_LOTE = _DT_SALDO_INICIAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                        _CANTIDAD_LOTE = _DT_SALDO_PRINCIPAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                        If _CANTIDAD_TOTAL_LOTE = _CANTIDAD_LOTE Then
                                            txtStockLote.Text = _CANTIDAD_TOTAL_LOTE
                                        Else
                                            _DIF_CANTIDAD = _CANTIDAD_TOTAL_LOTE - _CANTIDAD_LOTE
                                            txtStockLote.Text = _DIF_CANTIDAD
                                        End If
                                    End If

                                End If
                            End If
                            cboLotes.Enabled = True
                            txtcantidad.Enabled = True
                            btnAceptar.Visible = True
                        End If
                    Else
                        cboLotes.SelectedIndex = 0
                        If _LOTE <> String.Empty Then
                            cboLotes.Text = _LOTE.ToString
                        End If
                        If Flag_FacturaGuiaVenta = False Then
                            txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                            MostrarFechaVencimiento(cboLotes.Text)
                        Else
                            ''Guias de ventas Rastro
                            If Flag_Modo_Edicion = False Then
                                Dim _CANTIDAD_TOTAL_LOTE As Double = 0.0
                                Dim _CANTIDAD_LOTE As Double = 0.0
                                Dim _DIF_CANTIDAD As Double = 0.0
                                Dim Exis() As DataRow = _DT_SALDO_INICIAL.Select("LOTE ='" & cboLotes.Text & "'", "")
                                If Exis.Count() <> 0 Then
                                    _CANTIDAD_TOTAL_LOTE = _DT_SALDO_INICIAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                    _CANTIDAD_LOTE = _DT_SALDO_PRINCIPAL.Compute("SUM (CANTIDAD)", "LOTE ='" & cboLotes.Text & "'")
                                    If _CANTIDAD_TOTAL_LOTE = _CANTIDAD_LOTE Then
                                        txtStockLote.Text = _CANTIDAD_TOTAL_LOTE
                                    Else
                                        _DIF_CANTIDAD = _CANTIDAD_TOTAL_LOTE - _CANTIDAD_LOTE
                                        txtStockLote.Text = _DIF_CANTIDAD
                                    End If
                                Else
                                    txtStockLote.Text = 0
                                End If
                            End If
                        End If
                        cboLotes.Enabled = True
                        txtcantidad.Enabled = True
                        btnAceptar.Visible = True
                    End If
                End If
            Else
                cboLotes.Enabled = False
                cboLotes.DataSource = Nothing
                DgvDetalleLote.DataSource = Nothing
                If TipoDocumento = "NC" Or TipoDocumento = "ND" Then
                    If txtcodigoArticulo.Text = "N0005" Or txtcodigoArticulo.Text = "N0006" Or txtcodigoArticulo.Text = "N0007" Or txtcodigoArticulo.Text = "N0008" Then
                        If TipoDocumento = "NC" Then
                            txtcantidad.Enabled = False
                            txtcantidad.Text = 1
                        End If

                    End If
                Else
                    MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad, Verifique.", MsgBoxStyle.Information)
                    txtcantidad.Enabled = False
                    btnAceptar.Visible = False
                    txtcantidad.Text = String.Empty
                    txtStockLote.Text = String.Empty
                    txtcodigoArticulo.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ArticulosPrecioDescuentos()
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDescuentos = New DataTable
            dtDescuentos = clsArticuloBl.DescuentosCliente(Flag_Cliente)
            'If dtDescuentos.Rows.Count() <> 0 Then
            ' If Not String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("TYPE_DISCOUNT").ToString) Then
            clsDescuento = New ClsTransacciones.clsDescuentosArticulos
            clsDescuento.DescuentosArticulos(txtcodigoArticulo.Text)
            Select Case dtDescuentos.Rows(0).Item("TYPE_DISCOUNT").ToString
                Case "1"
                    txtdescuento1.Text = clsDescuento.DCTO1
                    txtdescuento2.Text = clsDescuento.DCTO2
                Case "0"
                    txtdescuento1.Text = clsDescuento.DCTO3
                    txtdescuento2.Text = clsDescuento.DCTO4
            End Select
            ' End If
            'End If
            txtprecioUnitario.Text = Format(clsDescuento.EFFECTIVE_PRICE, "##,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            'If Flag_FacturaExistencias Then
            If Flag_Factura_directa = False Then
                sql = "FACT_SP_S_RECIVABLE_PART_EXIS"
            Else
                If TipoDocumento = "NC" Or TipoDocumento = "ND" Then
                    sql = "GUIA_SP_S_GUIA_REMISION_PART"
                Else
                    If Flag_Factura_Pedido = True Then
                        sql = "GUIA_SP_S_GUIA_REMISION_PART_POS_PED"
                    Else
                        sql = "GUIA_SP_S_GUIA_REMISION_PART_POS"
                    End If

                End If
            End If
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm._flag_detalles = "si"
            frm.Filtros1 = AlmacenOrigen
            If Flag_Factura_Pedido = True Then
                frm.Filtros2 = _ARTS_INICIALES
            End If
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString

                clsArticuloBl = New ClsOperaciones.PART
                Dim ds_tmp As DataSet = clsArticuloBl.get_Imagen_Producto(txtcodigoArticulo.Text)

                If ds_tmp.Tables(0).Rows.Count > 0 Then
                    If ds_tmp.Tables(0).Rows(0)("IMAGEN").ToString = String.Empty Then
                        dgv_detalle.DataSource = ds_tmp.Tables(0)
                        dgv_detalle.Rows(0).Cells("col_img").Value = Nothing
                        pb_img.Image = Nothing
                    Else
                        dgv_detalle.DataSource = ds_tmp.Tables(0)
                        dgv_detalle.Rows(0).Cells("col_img").Value = Bytes2Image(ds_tmp.Tables(0).Rows(0)("IMAGEN"))
                        pb_img.Image = dgv_detalle.Rows(0).Cells("col_img").Value
                    End If
                Else
                    pb_img.Image = Nothing
                End If


                Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtStock.Text = Format(Stock, "##,##0.00")
                If Flag_FacturaExistencias = False Then
                    If frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString = "S" Then
                        _TipoControlInventario = "LOTE"
                        MostrandoLotes(txtcodigoArticulo.Text)
                        If Flag_Factura_Pedido Then
                            cboLotes.SelectedIndex = 0
                        Else
                            cboLotes.Select()
                        End If
                    ElseIf frm.Data_Matriz.Rows(0).Item("IS_STOCKED").ToString = "S" Then
                        _TipoControlInventario = "LIBRE"
                    Else
                        _TipoControlInventario = "LIBRE"
                    End If
                    If Flag_Factura_Pedido = True Then
                        txtsaldo.Text = _DT_SALDO_INICIAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'") - _DT_SALDO_PRINCIPAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'")
                        txtsaldo.Text = Format(CDbl(txtsaldo.Text), "##,##0.0.0")
                        If txtsaldo.Text = 0 Then
                            btnAceptar.Visible = False
                            MsgBox("El saldo es igual a cero, no se pueden agregar mas items.", MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            btnAceptar.Visible = True
                        End If
                    End If
                Else
                    txtcantidad.Focus()
                End If
                ' If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
                txtprecioUnitario.Text = 0
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsArticuloBl.get_VerificacionArticuloCodigoFactura(AlmacenOrigen, _codigoArticulo, Flag_Factura_directa, TipoDocumento, Flag_Factura_Pedido, _ARTS_INICIALES)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                If Flag_Modo_Edicion = False Then
                    txtigvpor.Text = Math.Round(CDbl(dtDocumentoGuias.Rows(0).Item("IGV").ToString), 2)
                End If

                clsArticuloBl = New ClsOperaciones.PART
                Dim ds_tmp As DataSet = clsArticuloBl.get_Imagen_Producto(codArticulo)

                If ds_tmp.Tables(0).Rows.Count > 0 Then
                    If ds_tmp.Tables(0).Rows(0)("IMAGEN").ToString = String.Empty Then
                        dgv_detalle.DataSource = ds_tmp.Tables(0)
                        dgv_detalle.Rows(0).Cells("col_img").Value = Nothing
                        pb_img.Image = Nothing
                    Else
                        dgv_detalle.DataSource = ds_tmp.Tables(0)
                        dgv_detalle.Rows(0).Cells("col_img").Value = Bytes2Image(ds_tmp.Tables(0).Rows(0)("IMAGEN"))
                        pb_img.Image = dgv_detalle.Rows(0).Cells("col_img").Value
                    End If
                Else
                    pb_img.Image = Nothing
                End If

                If Flag_FacturaGuiaVenta = False Then txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0")
                If Flag_FacturaExistencias = False Then
                    If dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString = "S" Then
                        _TipoControlInventario = "LOTE"
                        MostrandoLotes(txtcodigoArticulo.Text)
                        If Flag_Factura_Pedido Then
                            cboLotes.SelectedIndex = 0
                        Else
                            cboLotes.Select()
                        End If

                    ElseIf dtDocumentoGuias.Rows(0).Item("IS_STOCKED").ToString = "S" Then
                        _TipoControlInventario = "LIBRE"
                    Else
                        _TipoControlInventario = ""
                    End If
                    If Flag_Factura_Pedido = True Then
                        If Flag_Modo_Edicion Then
                            txtsaldo.Text = _DT_SALDO_INICIAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'") - _DT_SALDO_PRINCIPAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'") + dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                            txtsaldo.Text = Format(CDbl(txtsaldo.Text), "##,##0.0.0")
                        Else
                            txtsaldo.Text = _DT_SALDO_INICIAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'") - _DT_SALDO_PRINCIPAL.Compute("SUM(CANTIDAD)", "CODIGO='" & txtcodigoArticulo.Text & "'")
                            txtsaldo.Text = Format(CDbl(txtsaldo.Text), "##,##0.0.0")
                        End If
                        If txtsaldo.Text = 0 Then
                            btnAceptar.Visible = False
                            MsgBox("El saldo es igual a cero, no se pueden agregar mas items.", MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            btnAceptar.Visible = True
                        End If
                    End If
                Else : txtdescuento1.Focus()

                End If
                If Flag_Factura_Rep_medico = True Then
                    'If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
                Else
                    If Flag_Modo_Edicion = False Then
                        'If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
                        txtprecioUnitario.Text = 0
                    Else
                        If Flag_Factura_Pedido = True Then
                            If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then
                                If dtdetalleArticulo.Rows.Count() <> 0 Then
                                    txtprecioUnitario.Text = IIf(String.IsNullOrEmpty(dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL").ToString), 0, dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL"))
                                Else
                                    txtprecioUnitario.Text = 0
                                End If
                                If txtprecioUnitario.Text = 0 Then
                                    ' ArticulosPrecioDescuentos()
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
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
        If e.KeyCode = Keys.F1 Then
            MostrandoArticulos()
            If txtprecioUnitario.Text <> "" Then
                If CDbl(txtprecioUnitario.Text) = 0 Then
                    txtprecioUnitario.Select()
                Else
                    txtcantidad.Text = "1"
                    Button1.Select()
                End If
            Else
                txtcodigoArticulo.Select()
            End If
            
        End If
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
                If CDbl(txtprecioUnitario.Text) = 0 Then
                    txtprecioUnitario.Select()
                Else
                    txtcantidad.Text = "1"
                    Button1.Select()
                End If
            End If
            'If txtcodigoArticulo.Text = "N0008" Or txtcodigoArticulo.Text = "N0006" Or Strings.Left(Trim(txtcodigoArticulo.Text), 2) = "ND" Or Strings.Left(Trim(txtcodigoArticulo.Text), 2) = "NC" Then
            '    txtdescripcionArticulo.ReadOnly = False
            '    txtdescripcionArticulo.BackColor = Drawing.Color.White
            'Else
            '    txtdescripcionArticulo.ReadOnly = True
            '    txtdescripcionArticulo.BackColor = Drawing.Color.White
            'End If
        End If
        
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                txtdescuento1.Text = dtdetalleArticulo.Rows(0).Item("%DESC.ART_1").ToString
                txtdescuento2.Text = dtdetalleArticulo.Rows(0).Item("%DESC.ART_2").ToString
                txtprecioUnitario.Text = dtdetalleArticulo.Rows(0).Item("PRECIO_INICIAL").ToString
                txtcantidad.Text = dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                txtigvpor.Text = dtdetalleArticulo.Rows(0).Item("IGV_POR").ToString
                AgregarArticuloManual(dtdetalleArticulo.Rows(0).Item("CODIGO").ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
        If CDbl(txtprecioUnitario.Text) = 0 Then
            txtprecioUnitario.Select()
        Else
            txtcantidad.Text = "1"
            Button1.Select()
        End If
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged

    End Sub
End Class