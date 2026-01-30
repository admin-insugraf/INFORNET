Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarArticulo

    Public AlmacenOrigen As String
    Public TipoDocumento As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim clsDescuento As New ClsTransacciones.clsDescuentosArticulos

    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    Public ValidacionLotes As String = String.Empty
    Public Flag_Modo_Edicion As Boolean = False
    Public ft_sin_descargo As Boolean = False
    Public fl_close As Boolean = False
    Public Qt_saldo As Double = 0.0
    Public flag_PrecioSinIgv As Boolean = False
    Public Flag_FacturaGuiaVenta As Boolean = False
    Public Flag_FacturaExistencias As Boolean = False
    Public ItemLote As String = String.Empty
    Public Flag_Cliente As String = String.Empty
    Public Fl_NC_REF As Boolean = False

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
            dtlote = clsArticuloBl.get_ArticuloLote(AlmacenOrigen, codigoArticulo, ValidacionLotes, TipoDocumento, Flag_FacturaGuiaVenta)
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"
                cboLotes.DataSource = dtlote
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
                            txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                            MostrarFechaVencimiento(cboLotes.Text)
                            cboLotes.Enabled = True
                            txtcantidad.Enabled = True
                            btnAceptar.Visible = True
                        Else
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

                End If
            Else
                cboLotes.Enabled = False
                cboLotes.DataSource = Nothing
                If TipoDocumento = "NC" Then
                    If txtcodigoArticulo.Text = "N0005" Or txtcodigoArticulo.Text = "N0006" Or txtcodigoArticulo.Text = "N0007" Or txtcodigoArticulo.Text = "N0008" Then
                        txtcantidad.Enabled = False
                        txtcantidad.Text = 1
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
            If dtDescuentos.Rows.Count() <> 0 Then
                If Not String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("TYPE_DISCOUNT").ToString) Then
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
                    txtprecioUnitario.Text = clsDescuento.EFFECTIVE_PRICE
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrandoArticulos()
        Try
            'Dim frm As New frmBuscar
            'Dim sql As String = String.Empty
            'Dim Stock As Double = 0.0
            'If TipoDocumento <> "NC" Then
            '    If Flag_FacturaExistencias Then
            '        sql = "FACT_SP_S_RECIVABLE_PART_EXIS"
            '    Else
            '        sql = "GUIA_SP_S_GUIA_REMISION_PART"
            '    End If
            '    frm.CadenaConsulta = sql
            '    frm._Flag_Filtro = True
            '    frm.Filtros1 = AlmacenOrigen
            '    frm.Titulo = "Seleccion de Articulos"
            '    frm.ShowDialog()
            '    If frm.Data_Matriz.Rows.Count > 0 Then
            '        txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            '        txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            '        txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            '        Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
            '        txtStock.Text = Format(Stock, "##,##0.0.0")
            '        If Flag_FacturaExistencias = False Then
            '            MostrandoLotes(txtcodigoArticulo.Text)
            '            cboLotes.Select()
            '        Else
            '            txtdescuento1.Focus()
            '        End If
            '        If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
            '    End If
            '    frm.Close()
            'Else
            '    If Flag_Modo_Edicion = False Then
            '        If TipoDocumento = "NC" Then
            '            sql = "FACT_SP_S_PRODUCTOS_COD_SERV"
            '            frm.CadenaConsulta = sql
            '            frm.Titulo = "Seleccion de Articulos"
            '            frm.ShowDialog()
            '            If frm.Data_Matriz.Rows.Count > 0 Then
            '                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            '                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            '                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            '                Stock = 0
            '                txtStock.Text = Format(0, "##,##0.0.0")
            '                If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
            '                txtcantidad.Text = 1
            '                txtcantidad.Enabled = False
            '            End If
            '            frm.Close()
            '        End If
            '    End If
            'End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            If Flag_FacturaExistencias Then
                sql = "FACT_SP_S_RECIVABLE_PART_EXIS"
            Else
                sql = "GUIA_SP_S_GUIA_REMISION_PART"
            End If
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtStock.Text = Format(Stock, "##,##0.0.0")
                If Flag_FacturaExistencias = False Then
                    MostrandoLotes(txtcodigoArticulo.Text)
                    cboLotes.Select()
                Else
                    txtdescuento1.Focus()
                End If
                If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
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
            dtDocumentoGuias = clsArticuloBl.get_VerificacionArticuloCodigo(AlmacenOrigen, _codigoArticulo, Flag_FacturaExistencias)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0")
                If Flag_FacturaExistencias = False Then
                    MostrandoLotes(txtcodigoArticulo.Text)
                    cboLotes.Select()
                Else
                    txtdescuento1.Focus()
                End If
                If Flag_Modo_Edicion = False Then
                    If Not String.IsNullOrEmpty(txtcodigoArticulo.Text) Then ArticulosPrecioDescuentos()
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

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
            End If
            If txtcodigoArticulo.Text = "N0008" Then
                txtdescripcionArticulo.ReadOnly = False
                txtdescripcionArticulo.BackColor = Drawing.Color.White
            Else
                txtdescripcionArticulo.ReadOnly = True
                txtdescripcionArticulo.BackColor = Drawing.Color.LightGray
            End If
        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticulo.Rows.Count() - 1
                    txtdescuento1.Text = dtdetalleArticulo.Rows(i).Item("%DESC.ART_1").ToString
                    txtdescuento2.Text = dtdetalleArticulo.Rows(i).Item("%DESC.ART_2").ToString
                    txtprecioUnitario.Text = dtdetalleArticulo.Rows(i).Item("PRECIO_INICIAL").ToString
                    txtcantidad.Text = dtdetalleArticulo.Rows(i).Item("CANTIDAD").ToString
                    AgregarArticuloManual(dtdetalleArticulo.Rows(i).Item("CODIGO").ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub FrmAsignarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TipoDocumento = "NC" Then
            btnNuevoLote.Visible = True
            btnNuevoLote.Enabled = True
        End If
        If Flag_Modo_Edicion = True Then
            ModoEdicion()
        Else
            GenerarColummnaDataTable()
        End If
        If Flag_FacturaGuiaVenta = True Then
            txtcodigoArticulo.Enabled = False
            txtcantidad.Enabled = False
            txtsaldo.Text = IIf(String.IsNullOrEmpty(Qt_saldo), 0, Qt_saldo)
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
            If Flag_FacturaExistencias = False Then
                If TipoDocumento <> "NC" Then
                    If CDbl(txtStockLote.Text) < txtcantidad.Text Then
                        MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                        estado = False
                        txtcantidad.Select()
                        Exit Try
                    End If
                End If
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("CANTIDAD") = txtcantidad.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("LOTE") = cboLotes.Text
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
            row("%DESC.ART_2") = CDbl(txtdescuento2.Text)
            row("VALOR_VENTA") = 0

            row("IMP_DESC_01") = 0
            row("IMP_DESC_02") = 0
            row("PRECIO_IGV") = 0
            row("IGV_ART") = 0
            row("IGV_ART_US") = 0
            row("PRECIO_INICIAL") = txtprecioUnitario.Text
            row("TOTAL_INICIAL") = Math.Round(row("CANTIDAD") * row("PRECIO_INICIAL"), 6)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("CANTIDAD") = txtcantidad.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("LOTE") = cboLotes.Text
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = CDbl(txtdescuento1.Text)
            row("%DESC.ART_2") = CDbl(txtdescuento2.Text)
            row("VALOR_VENTA") = Math.Round(row("CANTIDAD") * row("PREC_UNITARIO"), 6)
            row("IMP_DESC_01") = 0
            row("IMP_DESC_02") = 0
            row("PRECIO_IGV") = 0
            row("IGV_ART") = 0
            row("IGV_ART_US") = 0
            row("PRECIO_INICIAL") = CDbl(txtprecioUnitario.Text)
            row("TOTAL_INICIAL") = Math.Round(row("CANTIDAD") * row("PRECIO_INICIAL"), 6)
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
            btnAceptar_Click(sender, e)
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

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioUnitario.KeyPress
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
            txtdescuento1.Select()
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
        If Flag_FacturaGuiaVenta = True Then
            If e.KeyCode = Keys.Enter Then
                btnAceptar_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If txtcantidad.Enabled = False Then
                btnAceptar_Click(sender, e)
            End If
        End If
       
    End Sub

    Private Sub txtcodigoArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoArticulo.TextChanged

    End Sub
End Class