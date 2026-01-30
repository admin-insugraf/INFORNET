Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarDetalle_OrdenCompra

    Dim OrdenCompraBL As ClsOperaciones.PURCHASE_ORDER

    Dim dtArticulos As DataTable
    Dim dtlote As DataTable
    Dim dtDescuentos As DataTable
    Public dtdetalleArticulo As DataTable
    Public Flag_Modo_Edicion As Boolean = False

    Public fl_close As Boolean = False

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable("AsignarDetalle")
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT_REFERENCE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("FACTOR_REFERENCE", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PRICE", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("DISCOUNT_PER", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("DISCOUNT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AMOUNT_TAX", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PERCENT_TAX", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PRICE_NET", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AMOUNT_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AMOUNT_TOTAL_NET", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("QTY_OUT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("STATUS_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("COMMENT1", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("TEXT_COMMENT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("IS_VAT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PRICE_UNIT", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("CCOST_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PROJECT_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("AREA_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("COTI_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("REQUI_ID", Type.GetType("System.String"))
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
                    txtcodigoArticulo.Text = row("PART_ID").ToString
                    txtdescripcionArticulo.Text = row("DESCRIPTION")
                    txtunidadMedida.Text = row("UNIT")
                    txtunidadMedRef.Text = row("UNIT_REFERENCE")
                    txtcantidad.Text = row("QTY")
                    txtcantidadref.Text = IIf(row("FACTOR_REFERENCE").ToString = "", 0, row("FACTOR_REFERENCE"))
                    txtValorunitario.Text = row("PRICE")
                    txtporc_descuento.Text = row("DISCOUNT_PER")
                    txtdescuento.Text = row("DISCOUNT")
                    txtigv.Text = row("AMOUNT_TAX")
                    txttasa.Text = row("PERCENT_TAX")
                    txtvalorventaunit.Text = row("AMOUNT_TOTAL")
                    txtvalorventa.Text = row("PRICE_NET")
                    txtpreciounitario.Text = row("PRICE_UNIT")
                    txttotalneto.Text = row("AMOUNT_TOTAL_NET")
                    txtobservaciones.Text = row("COMMENT1")
                    txtGlosa.Text = row("TEXT_COMMENT")
                    chkigv.Checked = IIf(row("IS_VAT") = "1", True, False)
                    txtcentroCosto.Text = row("CCOST_ID")
                    txtproyecto.Text = row("PROJECT_ID")
                    txtarea.Text = row("AREA_ID")
                    If txtcantidadref.Text <> 0 Then
                        txtvalorventaref.Text = txtdescuento.Text
                    Else
                        txtvalorventaref.Text = 0
                    End If
                    txtvalorbruto.Text = Format(Val(txtdescuento.Text) + Val(txtvalorventa.Text), "0.00")
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
        End If
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcantidad.Focus()
                Exit Try
            ElseIf Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtcantidad.Focus()
                Exit Try
            ElseIf txtValorunitario.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
                Exit Try
            ElseIf Val(txtValorunitario.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
                estado = False
                txtValorunitario.Focus()
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
        row("PART_ID") = txtcodigoArticulo.Text
        row("DESCRIPTION") = txtdescripcionArticulo.Text
        row("UNIT") = txtunidadMedida.Text
        row("UNIT_REFERENCE") = txtunidadMedRef.Text
        row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
        row("FACTOR_REFERENCE") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
        row("PRICE") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
        row("DISCOUNT_PER") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
        row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
        row("AMOUNT_TAX") = IIf(txtigv.Text = "", 0, txtigv.Text)
        row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
        row("PRICE_NET") = IIf(txtvalorventa.Text = "", 0, txtvalorventa.Text)
        row("AMOUNT_TOTAL") = IIf(txtvalorventaunit.Text = "", 0, txtvalorventaunit.Text)
        row("AMOUNT_TOTAL_NET") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
        row("COMMENT1") = txtobservaciones.Text
        row("TEXT_COMMENT") = txtGlosa.Text
        row("IS_VAT") = IIf(chkigv.Checked = True, "1", "0")
        row("PRICE_UNIT") = IIf(txtpreciounitario.Text = "", 0.0, txtpreciounitario.Text)
        row("CCOST_ID") = txtcentroCosto.Text
        row("PROJECT_ID") = txtproyecto.Text
        row("AREA_ID") = txtarea.Text
        dtdetalleArticulo.Rows.Add(row)
        dtdetalleArticulo.AcceptChanges()
        Me.Close()
    End Sub

 

    Private Sub txtcantidadPractica_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtcantidadteorica_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub Ayuda_Unidad_Medida()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_UNIDAD_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista Unidad de Medida de Referencia"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtunidadMedRef.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtunidadMedRef.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_Centro_Costo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_CENTRO_COSTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcentroCosto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtcentroCosto.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarea.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtarea.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Proyecto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_PROYECTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtproyecto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            Else
                txtproyecto.Text = ""

            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtunidadMedRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtunidadMedRef.MouseDoubleClick
        Ayuda_Unidad_Medida()
    End Sub

    Private Sub txtcentroCosto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcentroCosto.MouseDoubleClick
        Ayuda_Centro_Costo()
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txtproyecto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtproyecto.MouseDoubleClick
        Ayuda_Proyecto()
    End Sub

    Private Sub Calcular_Importes_Detalle()
        Try
            Dim nValorVta As Double
            Dim nValorUniRef As Double
            Dim nValorUnit As Double
            Dim nPrecioUnit As Double
            Dim nDsctoUnit As Double
            Dim nValorBruto As Double
            Dim nTasaIGV As Double
            Dim nMontoIgv As Double
            Dim nMontodes As Double
            Dim nMontoTotal As Double
            nTasaIGV = (Val(txttasa.Text) / 100)
            If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
                'Aplicando descuento
                If chkigv.Checked = True Then
                    nValorUnit = Math.Round(Val(txtValorunitario.Text) / (1 + nTasaIGV), 6)
                Else
                    nValorUnit = Val(txtValorunitario.Text)
                End If
                If Val(txtcantidadref.Text) <> 0 And Val(txtcantidad.Text) <> 0 Then
                    nValorUniRef = Math.Round((Val(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
                    nDsctoUnit = nValorUniRef * (txtporc_descuento.Text) / 100
                    nValorUniRef = nValorUniRef - nDsctoUnit
                    nValorUnit = nValorUniRef
                Else
                    nValorUniRef = 0
                    nDsctoUnit = nValorUnit * (txtporc_descuento.Text) / 100
                    nValorUnit = nValorUnit - nDsctoUnit
                End If
                'Precio Unitario
                nPrecioUnit = nValorUnit * (1 + nTasaIGV)
                nValorVta = nValorUnit * Val(txtcantidad.Text)
                nMontodes = nDsctoUnit * Val(txtcantidad.Text)
                nMontoIgv = (nValorUnit * nTasaIGV) * Val(txtcantidad.Text)
                nMontoTotal = nValorVta + nMontoIgv
                nValorBruto = nValorVta + nMontodes

                txtvalorventaref.Text = Format(nValorUniRef, "0.00")
                txtvalorventaunit.Text = Format(nValorUnit, "0.00")
                txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
                txtvalorbruto.Text = Format(nValorBruto, "0.00")
                txtdescuento.Text = Format(nMontodes, "0.00")
                txtvalorventa.Text = Format(nValorVta, "0.00")
                txtigv.Text = Format(nMontoIgv, "0.00")
                txttotalneto.Text = Format(nMontoTotal, "0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub chkigv_CheckedChanged(sender As Object, e As EventArgs) Handles chkigv.CheckedChanged
        Calcular_Importes_Detalle()
        txtobservaciones.Focus()
    End Sub

    Private Sub txtcodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalorventaunit.KeyPress, txtvalorventaref.KeyPress, txtvalorventa.KeyPress, txtvalorbruto.KeyPress, txtunidadMedRef.KeyPress, txtunidadMedida.KeyPress, txttotalneto.KeyPress, txttasa.KeyPress, txtproyecto.KeyPress, txtpreciounitario.KeyPress, txtobservaciones.KeyPress, txtigv.KeyPress, txtGlosa.KeyPress, txtdescuento.KeyPress, txtcodigoArticulo.KeyPress, txtcentroCosto.KeyPress, txtcantidadref.KeyPress, txtarea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtdescripcionArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcionArticulo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtValorunitario_Leave(sender As Object, e As EventArgs) Handles txtValorunitario.Leave
        If txtValorunitario.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
        txtobservaciones.Focus()
    End Sub

    '        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    ''------
    '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    Private Sub txtporc_descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtporc_descuento.KeyPress
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

    Private Sub txtValorunitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorunitario.KeyPress
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

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
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

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        fl_close = True
        Me.Close()
    End Sub
End Class