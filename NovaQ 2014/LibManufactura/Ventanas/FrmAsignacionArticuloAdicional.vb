Imports System.Windows.Forms
Imports LibCobranzas
Public Class FrmAsignacionArticuloAdicional
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

    Dim clsArticuloBl As LibCobranzas.ClsOperaciones.PART
    Dim _TipoControlInventario As String = ""
    Private Sub FrmAsignacionArticuloAdicional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Flag_Modo_Edicion = False Then
            GenerarColummnaDataTable()
            MostrandoAlmacenes()
            txtcodigoArticulo.Focus()
        End If
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("ALMACEN_SALIDA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DOC_SALIDA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUM_SALIDA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("ESTADO", Type.GetType("System.String"))

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
            row("LOTE") = cboLotes.Text
            row("QTY") = txtcantidad.Text
            row("ALMACEN_SALIDA") = cboalmacen.SelectedValue
            row("DOC_SALIDA") = ""
            row("NUM_SALIDA") = ""
            row("ESTADO") = ""
            
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub
    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try

            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            ElseIf txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation)
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


        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        If cboalmacen.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Almacen.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        MostrandoArticulos()
    End Sub
    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_S_I"
            frm._Flag_Filtro = True
            frm.Filtros1 = cboalmacen.SelectedValue
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                txtunidadarticulo.Text = frm.Data_Matriz.Rows(0).Item("UNID_MED").ToString

                txtstock.Text = Format(CType(frm.Data_Matriz.Rows(0).Item("STOCK").ToString, Decimal), "##,##0.00")

                If frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString = "S" Then
                    _TipoControlInventario = "LOTE"
                    MostrandoLotes(txtcodigoArticulo.Text)
                    cboLotes.Select()
                ElseIf frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString = "S" Then
                    _TipoControlInventario = "LIBRE"
                    cboLotes.Enabled = False
                    cboLotes.DataSource = Nothing
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
            dtlote = clsArticuloBl.get_InventarioArticuloLote(cboalmacen.SelectedValue, codigoArticulo, "", "S")
            If dtlote.Rows.Count() <> 0 Then

                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"
                cboLotes.DataSource = dtlote

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
        If cboalmacen.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Almacen.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
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
                cboalmacen.SelectedIndex = -1
            Else
                MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cboLotes_KeyDown(sender As Object, e As KeyEventArgs) Handles cboLotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub cboLotes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLotes.SelectedValueChanged
        If cboLotes.DataSource Is Nothing Then Exit Sub
        If cboLotes.Items.Count() <> 0 Then
            txtstock.Text = cboLotes.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtcantidad_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub cboalmacen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboalmacen.SelectedValueChanged
        If cboalmacen.DataSource Is Nothing Then Exit Sub
        If cboalmacen.Items.Count() <> 0 Then
            txtcodigoArticulo.Text = ""
            txtdescripcionArticulo.Text = ""
            txtunidadarticulo.Text = ""
            cboLotes.DataSource = Nothing
            txtcantidad.Text = ""
        End If
    End Sub

    
End Class