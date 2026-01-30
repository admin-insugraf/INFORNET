Imports System.Windows.Forms
Imports LibCobranzas
Public Class FrmAsignarArticuloLiquidacion
    Public AlmacenOrigen As String
    Public MonedaOrigen As String
    Public EstadoOrigen As Boolean = False
    Public _id_item As String

    Public _ID_FORMULA As String
    Public _ID_OF As String
    Public _MONEDA As String
    Public _CANTIDAD_OF As Double
    Public _CANTIDAD_TERMINADA As Double
    Public _CANTIDAD_SALDO As Double

    Public TipoDocumento As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim ManufactutraBl As ClsOperaciones.FORMULATION
    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    'Public ValidacionLotes As String = String.Empty
    Public Flag_Modo_Edicion As Boolean = False
    ''Producccion
    Public TIPO_FORMULA = String.Empty
    Public TIPO_PROD As String = String.Empty
    Dim ManufacturaBl As ClsOperaciones.FORMULATION
    Public fl_close As Boolean = False
    Public cantidad_a_liquidar As Double
    Public capacidad_presentacion As Double

    Dim clsArticuloBl As LibCobranzas.ClsOperaciones.PART

    Private Sub FrmAsignarArticuloLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Flag_Modo_Edicion = False Then
            GenerarColummnaDataTable()
            MostrandoAlmacenes()
            MostrandoAlmacenesIngreso()
        End If
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PART_ID_PRES", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION_PRES", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT_PRES", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_PROM", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_ULT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_PRES_PROM", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_PRES_ULT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("WHO_PRES", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_TOTAL_PROM", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST_TOTAL_ULT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("WHO_INGRESO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("WHO_DES_INGRESO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY_REAL", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("TIPO_LIQUIDACION", Type.GetType("System.String"))
            dtdetalleArticulo.PrimaryKey = New DataColumn() {dtdetalleArticulo.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        fl_close = True
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("PART_ID") = txtcodigoArticulo.Text
            row("DESCRIPTION") = txtdescripcionArticulo.Text
            row("UNIT") = txtunidadarticulo.Text
            row("PART_ID_PRES") = txtcodigopres.Text
            row("DESCRIPTION_PRES") = txtdescripcionpres.Text
            row("UNIT_PRES") = txtunidadpres.Text
            row("QTY") = cantidad_a_liquidar
            row("AVERAGE_COST_PROM") = If(txtcpinsumos.Text = String.Empty, 0, txtcpinsumos.Text)
            row("AVERAGE_COST_ULT") = If(txtucinsumos.Text = String.Empty, 0, txtucinsumos.Text)
            row("AVERAGE_COST_PRES_PROM") = If(txtcpee.Text = String.Empty, 0, txtcpee.Text)
            row("AVERAGE_COST_PRES_ULT") = If(txtucee.Text = String.Empty, 0, txtucee.Text)
            row("WHO_PRES") = cboalmacen.SelectedValue.ToString
            row("AVERAGE_COST_TOTAL_PROM") = If(txtcpcosto.Text = String.Empty, 0, txtcpcosto.Text)
            row("AVERAGE_COST_TOTAL_ULT") = If(txtuccosto.Text = String.Empty, 0, txtuccosto.Text)
            row("WHO_INGRESO") = cboalmaceningreso.SelectedValue.ToString
            row("WHO_DES_INGRESO") = cboalmaceningreso.Text
            row("QTY_REAL") = CDbl(txtcantidad.Text)
            If rdb_liquidacion.Checked Then
                row("TIPO_LIQUIDACION") = "L"
            ElseIf rdb_adicional.Checked Then
                row("TIPO_LIQUIDACION") = "A"
            Else
                row("TIPO_LIQUIDACION") = ""
            End If
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub
    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If rdb_liquidacion.Checked Then
                If txtcodigoArticulo.Text = String.Empty Then
                    MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                    txtcodigoArticulo.Focus()
                    estado = False
                    Exit Try
                ElseIf txtcantidad.Text = String.Empty Then
                    MsgBox("Debe ingresar una cantidad a liquidar.", MsgBoxStyle.Exclamation)
                    estado = False
                    txtcantidad.Focus()
                    Exit Try
                End If
                If CDbl(txtcantidad.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                    estado = False
                    txtcantidad.Focus()
                    Exit Try
                End If
                'If txtcodigopres.Text = String.Empty Then
                '    MsgBox("Debe asignar una presentación al articulo que esta liquidando.", MsgBoxStyle.Exclamation)
                '    txtcodigopres.Focus()
                '    estado = False
                '    Exit Try
                'End If

                'If CDbl(txtcpinsumos.Text) <= 0 And CDbl(txtcpee.Text) <= 0 And CDbl(txtcpcosto.Text) <= 0 And CDbl(txtucinsumos.Text) <= 0 And CDbl(txtucee.Text) <= 0 And CDbl(txtuccosto.Text) <= 0 Then
                '    MsgBox("No se llevo a cabo el calculo de los costos, proceda a ejecutarlo.", MsgBoxStyle.Exclamation)
                '    estado = False
                '    txtcantidad.Focus()
                '    Exit Try
                'End If
                'If txtcodigopres.Text.Trim <> "EE00012" Then
                '    If CDbl(txtcantidad.Text) > CDbl(txtstock.Text) Then
                '        MsgBox("El stock de los envases y embalajes es insuficiente para cubrir la liquidación.", MsgBoxStyle.Exclamation)
                '        txtcantidad.Focus()
                '        estado = False
                '        Exit Try
                '    End If
                'End If

                If cantidad_a_liquidar > _CANTIDAD_SALDO Then
                    MsgBox("La cantidad a liquidar supera el saldo correspondiente.", MsgBoxStyle.Exclamation)
                    txtcantidad.Focus()
                    estado = False
                    Exit Try
                End If
            ElseIf rdb_adicional.Checked Then
                If txtcodigoArticulo.Text = String.Empty Then
                    MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                    txtcodigoArticulo.Focus()
                    estado = False
                    Exit Try
                ElseIf txtcantidad.Text = String.Empty Then
                    MsgBox("Debe ingresar una cantidad a liquidar.", MsgBoxStyle.Exclamation)
                    estado = False
                    txtcantidad.Focus()
                    Exit Try
                End If
                If CDbl(txtcantidad.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                    estado = False
                    txtcantidad.Focus()
                    Exit Try
                End If
                If CDbl(txtcantidad.Text) > CDbl(txtstock.Text) Then
                    MsgBox("El stock del Producto es insuficiente para cubrir el Adicional.", MsgBoxStyle.Exclamation)
                    txtcantidad.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub
    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            If rdb_liquidacion.Checked Then
                sql = "PROD_SP_S_ARTICULO"
            Else
                sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_S_I"
                frm._Flag_Filtro = True
                frm.Filtros1 = "02"
                frm.Filtros2 = ""
            End If
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                If rdb_liquidacion.Checked Then
                    txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                    txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                    txtunidadarticulo.Text = frm.Data_Matriz.Rows(0).Item("UNIDAD").ToString

                    txtcodigopres.Text = frm.Data_Matriz.Rows(0).Item("CODIGO.PRES").ToString
                    txtdescripcionpres.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION.PRES").ToString
                    txtunidadpres.Text = frm.Data_Matriz.Rows(0).Item("UNIDAD.PRES").ToString

                    ManufactutraBl = New ClsOperaciones.FORMULATION
                    Dim dtStock As New DataTable
                    dtStock = ManufactutraBl.Obtener_Stock(txtcodigoArticulo.Text, cboalmacen.SelectedValue.ToString)
                    If dtStock.Rows.Count > 0 Then
                        txtstock.Text = Format(CType(dtStock.Rows(0).Item("QTY_ON_HAND").ToString, Decimal), "##,##0.00")
                        cantidad_a_liquidar = CType(dtStock.Rows(0).Item("QTY_PRESENTACION").ToString, Decimal)
                        capacidad_presentacion = CType(dtStock.Rows(0).Item("QTY_PRESENTACION").ToString, Decimal)
                    Else
                        txtstock.Text = 0
                        cantidad_a_liquidar = 0
                        capacidad_presentacion = 0
                    End If

                    'If txtcodigopres.Text.Trim = "EE00012" Then
                    '    Label9.Visible = False
                    '    cboalmacen.Visible = False
                    '    Label10.Visible = False
                    '    txtstock.Visible = False
                    '    cantidad_a_liquidar = 1
                    'Else
                    '    Label9.Visible = True
                    '    cboalmacen.Visible = True
                    '    Label10.Visible = True
                    '    txtstock.Visible = True
                    'End If
                ElseIf rdb_adicional.Checked Then
                    txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                    txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                    txtunidadarticulo.Text = frm.Data_Matriz.Rows(0).Item("UNID_MED").ToString

                    txtcodigopres.Text = ""
                    txtdescripcionpres.Text = ""
                    txtunidadpres.Text = ""

                    txtstock.Text = Format(CType(frm.Data_Matriz.Rows(0).Item("STOCK").ToString, Decimal), "##,##0.00")
                    cantidad_a_liquidar = CType(0, Decimal)
                    capacidad_presentacion = 0

                    'If txtcodigopres.Text.Trim = "EE00012" Then
                    '    Label9.Visible = False
                    '    cboalmacen.Visible = False
                    '    Label10.Visible = False
                    '    txtstock.Visible = False
                    'Else
                    '    Label9.Visible = True
                    '    cboalmacen.Visible = True
                    '    Label10.Visible = True
                    '    txtstock.Visible = True
                    'End If
                    Dim fl_Lot As String
                    fl_Lot = String.Empty
                    fl_Lot = frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        cboLotes.DataSource = Nothing
                    End If
                End If
                

                txtcantidad.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoLotes(ByVal codigoArticulo As String)
        Try
            clsArticuloBl = New LibCobranzas.ClsOperaciones.PART
            '++Informacion de Lotes
            Dim ItemLote As String = String.Empty
            dtlote = New DataTable
            dtlote = clsArticuloBl.get_InventarioArticuloLote("02", codigoArticulo, "", "S")
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DataSource = dtlote
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"

                If cboLotes.Items.Count() <> 0 Then
                    cboLotes.SelectedIndex = 0
                    If ItemLote <> String.Empty Then
                        cboLotes.Text = ItemLote.ToString
                    End If
                    txtstock.Text = Format(cboLotes.SelectedValue, "##,##0.000000")
                    cboLotes.Enabled = True
                End If
            Else
                MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad, Verifique.", MsgBoxStyle.Information)
                cboLotes.Enabled = False
                txtstock.Text = String.Empty
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
        End If
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = "" Then
                MostrandoArticulos()
            Else
                txtcantidad.Focus()
            End If
        End If
    End Sub
    Private Sub MostrandoAlmacenes()
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtAlmacen As New DataTable
            dtAlmacen = ManufactutraBl.Mostrar_Almacenes_LiquidacionOF()
            cboalmacen.DataSource = Nothing
            If dtAlmacen.Rows.Count() <> 0 Then
                cboalmacen.DisplayMember = "DESCRIPCION"
                cboalmacen.ValueMember = "CODIGO"
                cboalmacen.DataSource = dtAlmacen
                cboalmacen.SelectedIndex = 0
            Else
                MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoAlmacenesIngreso()
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtAlmacen As New DataTable
            dtAlmacen = ManufactutraBl.Mostrar_Almacenes_LiquidacionOF()
            cboalmaceningreso.DataSource = Nothing
            If dtAlmacen.Rows.Count() <> 0 Then
                cboalmaceningreso.DisplayMember = "DESCRIPCION"
                cboalmaceningreso.ValueMember = "CODIGO"
                cboalmaceningreso.DataSource = dtAlmacen
                cboalmaceningreso.SelectedIndex = 0
            Else
                MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboalmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboalmacen.SelectedIndexChanged
        ManufactutraBl = New ClsOperaciones.FORMULATION
        Dim dtStock As New DataTable
        dtStock = ManufactutraBl.Obtener_Stock(txtcodigopres.Text, cboalmacen.SelectedValue.ToString)
        If dtStock.Rows.Count > 0 Then
            txtstock.Text = Format(CType(dtStock.Rows(0).Item("QTY_ON_HAND").ToString, Decimal), "##,##0.00")
            cantidad_a_liquidar = CType(dtStock.Rows(0).Item("QTY_PRESENTACION").ToString, Decimal)
        Else
            txtstock.Text = 0
            cantidad_a_liquidar = 0
        End If
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
            If txtcantidad.Text = "" Then Exit Sub
            If rdb_liquidacion.Checked Then
                ManufactutraBl = New ClsOperaciones.FORMULATION
                Dim dtStock As New DataTable
                ManufactutraBl = New ClsOperaciones.FORMULATION
                dtStock = ManufactutraBl.Obtener_Stock(txtcodigoArticulo.Text, cboalmacen.SelectedValue.ToString)
                If dtStock.Rows.Count > 0 Then
                    cantidad_a_liquidar = CType(dtStock.Rows(0).Item("QTY_PRESENTACION").ToString, Decimal)
                Else
                    cantidad_a_liquidar = 1 '0
                End If

                If txtcodigopres.Text = "EE00012" Then
                    cantidad_a_liquidar = 1
                End If

                If txtcantidad.Text = "" Then
                    cantidad_a_liquidar = 0 * cantidad_a_liquidar
                Else
                    cantidad_a_liquidar = Val(txtcantidad.Text) * cantidad_a_liquidar
                End If


                dtStock = ManufactutraBl.Obtener_Costo_Produccion(_ID_FORMULA, _ID_OF, _MONEDA, _CANTIDAD_OF, _CANTIDAD_TERMINADA, LibComunVar.ClsVarComun.TCVenta)
                If dtStock.Rows.Count > 0 Then
                    txtcpinsumos.Text = Format(CType(dtStock.Rows(0).Item("COSTO_PROMEDIO").ToString, Decimal), "##,##0.000000")
                    txtucinsumos.Text = Format(CType(dtStock.Rows(0).Item("COSTO_ULTIMO").ToString, Decimal), "##,##0.000000")
                Else
                    txtcpinsumos.Text = Format(0, "##,##0.00")
                    txtucinsumos.Text = Format(0, "##,##0.00")
                End If
                dtStock = Nothing
                dtStock = ManufactutraBl.Obtener_Costo_Produccion_EE(txtcodigopres.Text, _MONEDA, cboalmacen.SelectedValue.ToString, LibComunVar.ClsVarComun.TCVenta)
                If dtStock.Rows.Count > 0 Then
                    txtcpee.Text = Format((CType(dtStock.Rows(0).Item("COSTO_PROMEDIO").ToString, Decimal) * CType(txtcantidad.Text, Decimal)) / cantidad_a_liquidar, "##,##0.000000")
                    txtucee.Text = Format((CType(dtStock.Rows(0).Item("COSTO_ULTIMO").ToString, Decimal) * CType(txtcantidad.Text, Decimal)) / cantidad_a_liquidar, "##,##0.000000")
                Else
                    txtcpee.Text = Format(0, "##,##0.00")
                    txtucee.Text = Format(0, "##,##0.00")
                End If
                txtcpcosto.Text = Format(Val(txtcpinsumos.Text) + Val(txtcpee.Text), "##,##0.000000")
                txtuccosto.Text = Format(Val(txtucinsumos.Text) + Val(txtucee.Text), "##,##0.000000")
            ElseIf rdb_adicional.Checked Then
                cantidad_a_liquidar = Val(txtcantidad.Text)
                txtcpinsumos.Text = Format(0, "##,##0.00")
                txtucinsumos.Text = Format(0, "##,##0.00")
                txtcpee.Text = Format(0, "##,##0.00")
                txtucee.Text = Format(0, "##,##0.00")
                txtcpcosto.Text = Format(Val(txtcpinsumos.Text) + Val(txtcpee.Text), "##,##0.000000")
                txtuccosto.Text = Format(Val(txtucinsumos.Text) + Val(txtucee.Text), "##,##0.000000")
            End If
            'btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub rdb_adicional_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_adicional.CheckedChanged
        txtcodigoArticulo.Focus()
        Label11.Text = "Almacen de Egreso"
    End Sub

    Private Sub rdb_liquidacion_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_liquidacion.CheckedChanged
        txtcodigoArticulo.Focus()
        Label11.Text = "Almacen de Ingreso"
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If txtcantidad.Text = "" Then
            cantidad_a_liquidar = 0
        Else
            cantidad_a_liquidar = 0
            cantidad_a_liquidar = Val(txtcantidad.Text) * capacidad_presentacion
        End If
    End Sub
End Class