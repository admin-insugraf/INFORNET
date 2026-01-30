Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarDetalle


    Public MonedaOrigen As String = String.Empty

    Public FechaVencimientoOrigen As String = String.Empty
    Public RsOrigen As String = String.Empty
    Public VolumenOrigen As String = String.Empty
    Public ComposicionOrigen As String = String.Empty
    Public NUMERO_OF As String = String.Empty


    Public TipoDocumento As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE

    Dim dtArticulos As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    'Public ValidacionLotes As String = String.Empty
    Public Flag_Modo_Edicion As Boolean = False
    ''Producccion
    Public TIPO_FORMULA = String.Empty
    Public TIPO_PROD As String = String.Empty
    Dim OrdenProduccionBL As ClsOperaciones.ORDER_PRODUCTION
    Public fl_close As Boolean = False

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION_PART", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT_PART", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PART_FORM", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION_FORM", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PART_FORM_EE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION_FORM_EE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMERO_OF", Type.GetType("System.String"))
            dtdetalleArticulo.PrimaryKey = New DataColumn() {dtdetalleArticulo.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For Each row As DataRow In dtdetalleArticulo.Rows
                    txt_cod_articulo.Text = row("PART_ID").ToString
                    txt_des_articulo.Text = row("DESCRIPTION_PART")
                    txtunidadMedida.Text = row("UNIT_PART")
                    txtcantidad.Text = row("QTY")
                    txt_cod_formula.Text = IIf(row("PART_FORM") = "", "xxx", row("PART_FORM"))
                    txt_des_formula.Text = row("DESCRIPTION_FORM")
                    cboformula_ee.SelectedValue = IIf(row("PART_FORM_EE") = "", "xxx", row("PART_FORM_EE"))
                    'cboformula_ee.Text = row("DESCRIPTION_FORM_EE")
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub FrmAsignarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Flag_Modo_Edicion = True Then
            ModoEdicion()
        Else
            GenerarColummnaDataTable()
            txtVolumen.Text = 0
            txt_cod_articulo.Focus()
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If Flag_Modo_Edicion = False Then
                If txt_cod_articulo.Text = "" Then
                    MsgBox("Debe seleccionar el codigo de un producto a fabricar.", MsgBoxStyle.Exclamation)
                    txt_cod_articulo.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            If txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If
            If Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If
            If txt_cod_formula.Text = "" Then
                MsgBox("Debe seleccionar el codigo de una formula.", MsgBoxStyle.Exclamation)
                estado = False
                txt_cod_formula.Focus()
                Exit Try
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If Flag_Modo_Edicion = True Then
            GenerarColummnaDataTable()
        End If
        Dim row As DataRow = dtdetalleArticulo.NewRow
        row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
        row("PART_ID") = txt_cod_articulo.Text
        row("DESCRIPTION_PART") = txt_des_articulo.Text
        row("UNIT_PART") = txtunidadMedida.Text
        row("QTY") = If(txtcantidad.Text = String.Empty, 0, txtcantidad.Text)
        row("PART_FORM") = txt_cod_formula.Text
        row("DESCRIPTION_FORM") = txt_des_formula.Text
        row("PART_FORM_EE") = ""
        row("DESCRIPTION_FORM_EE") = ""
        row("NUMERO_OF") = NUMERO_OF
        dtdetalleArticulo.Rows.Add(row)
        dtdetalleArticulo.AcceptChanges()
        FechaVencimientoOrigen = dtpVencimiento.Value
        RsOrigen = txtrsn.Text
        VolumenOrigen = txtVolumen.Text
        ComposicionOrigen = txtcomposicion.Text
        Me.Close()
    End Sub

 

    Private Sub MostrandoDetallesArticulos()
        Try
            OrdenProduccionBL = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDetallesPart As New DataTable
            Dim FECHA_VENCIMIENTO_LOTE As Date

            dtDetallesPart = OrdenProduccionBL.Mostrando_Detalles_Articulos(cboArticulo.SelectedValue.ToString)
            If dtDetallesPart.Rows.Count() <> 0 Then
                txtunidadMedida.Text = dtDetallesPart.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                txtcantidad.Text = dtDetallesPart.Rows(0).Item("QTY_LOT").ToString
                txtVolumen.Text = dtDetallesPart.Rows(0).Item("VOLUMEN_LLENADO").ToString
                txtcomposicion.Text = dtDetallesPart.Rows(0).Item("QTY_AMPOLLA").ToString
                txtrsn.Text = dtDetallesPart.Rows(0).Item("RS").ToString
                txtcantidad.Text = dtDetallesPart.Rows(0).Item("QTY_LOT").ToString
                cboformula_mp.SelectedValue = dtDetallesPart.Rows(0).Item("MODEL1").ToString
                cboformula_ee.SelectedValue = dtDetallesPart.Rows(0).Item("MODEL2").ToString
                FECHA_VENCIMIENTO_LOTE = DateAdd("m", dtDetallesPart.Rows(0).Item("QTY_MESES"), FechaVencimientoOrigen)
                dtpVencimiento.Value = FECHA_VENCIMIENTO_LOTE
            Else
                ' MsgBox("No hay Equivalencia para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArticulo.SelectedIndexChanged
        If cboArticulo.DataSource Is Nothing Then Exit Sub
        If cboArticulo.SelectedIndex = -1 Then Exit Sub
        If Flag_Modo_Edicion = False Then
            If cboArticulo.SelectedIndex = 0 Then
                cboformula_mp.Enabled = True
                cboformula_ee.Enabled = True
                Exit Sub
            Else
                cboformula_mp.Enabled = True
                cboformula_ee.Enabled = True
            End If
        Else
            If cboArticulo.SelectedIndex = -1 Then
                cboformula_mp.Enabled = True
                cboformula_ee.Enabled = True
                Exit Sub
            Else
                cboformula_mp.Enabled = True
                cboformula_ee.Enabled = True
            End If
        End If
        MostrandoDetallesArticulos()
    End Sub

    Private Sub txtcomposicion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcomposicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
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

    Private Sub txtrsn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrsn.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcomposicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomposicion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cboArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVolumen.KeyPress, txtunidadMedida.KeyPress, txtrsn.KeyPress, txtcantidad.KeyPress, dtpVencimiento.KeyPress, cboformula_mp.KeyPress, cboformula_ee.KeyPress, cboArticulo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        fl_close = True
        Me.Close()
    End Sub

    Private Sub txt_cod_articulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_articulo.MouseDoubleClick
        Ayuda_Articulos()
    End Sub
    Private Sub Ayuda_Articulos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "lista_producto"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Productos a Fabricar"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_articulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_articulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            txt_cod_formula.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
            txt_des_formula.Text = frm.Data_Matriz.Rows(0).Item(4).ToString
        End If
        frm.Close()
    End Sub

    Private Sub txt_cod_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_articulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Articulos()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_articulo.Text = "" Then
                Ayuda_Articulos()
            Else
                txtcantidad.Focus()
            End If

        End If
    End Sub
    Private Sub Ayuda_Formulas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "lista_formula"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Formulas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_formula.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_formula.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub txt_cod_formula_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_formula.MouseDoubleClick
        Ayuda_Formulas()
    End Sub

    Private Sub txt_cod_formula_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_formula.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Formulas()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_formula.Text = "" Then
                Ayuda_Formulas()
            Else
                btnAceptar.Select()
            End If

        End If
    End Sub
End Class