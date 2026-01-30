Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmFacturacionRapida_Despachos_Hab_facturacion

    Public NumeracionGuiaRemision As String
    Public NumeracionFactura As String
    Public NumeracionFacturaNotaC As String
    Public NumeracionFacturaNotaD As String
    Public NumeracionFacturaCP As String
    Public NumeracionGeneral As String

    Public fl_datos As Boolean = False
    Public Almacen As String = String.Empty
    Public Serie As String = String.Empty
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtdetalles As DataTable
    Public TipoNumeracion As String = String.Empty
    Public TipoDocumento As String = String.Empty
    Public Modo_edicion As Boolean = False
    Public Numero_edicion As String = ""
    Public dt_detalle_pagos As DataTable
    Public monto_ventas As Double
    Public _moneda As String
    Public _cliente As String
    Public _numero_completo_comprobante As String
    Public _tipo_comprobante As String
    Public _serie_comprobante As String
    Public _numero_comprobante As String
    Dim cabeceraBL As LibCobranzas.ClsOperaciones.RECEIVABLE

    Public item_pedido As Integer
    Public producto_pedido As String
    Public cantidad_pedido As Double
    Public pedido As String
    Public flag_hab As Boolean = False

    Private Sub FrmFacturacionRapida_Despachos_Hab_facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarColummnaDataTable()
        txt_cantidad_hab.Text = ""
        txt_observaciones_hab.Text = ""
        dtp_fecha_hab.Value = Date.Now
        txt_producto.Text = producto_pedido
        txt_Cantidad.Text = cantidad_pedido
        lbl_cantidad_total.Text = Format(cantidad_pedido, "#,###,###.#0")

        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        dt_detalle_pagos = monedaBL.Mostrar_Lista_habilitaciones(pedido, item_pedido)
        dgv_detalle_cobro.DataSource = dt_detalle_pagos

        Dim cantidad_habilitada As Double = 0
        If dt_detalle_pagos.Rows.Count > 0 Then
            cantidad_habilitada = Math.Abs(Math.Round(dt_detalle_pagos.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
        End If
        lbl_cantidad_total_hab.Text = Format(cantidad_habilitada, "##,##0.00")

        txt_cantidad_hab.Select()
    End Sub

    Private Sub AMOUNT_BCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_hab.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_add_regsanit_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_registro() = False Then Exit Sub

            Dim row As DataRow = dt_detalle_pagos.NewRow
            Dim _MONTO_PAGADO As Double = 0
            Dim _ultimo_item As Integer = 0

            If dt_detalle_pagos.Rows.Count > 0 Then
                _MONTO_PAGADO = Math.Abs(Math.Round(dt_detalle_pagos.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
            End If
            _MONTO_PAGADO = _MONTO_PAGADO + Math.Abs(CDbl(txt_cantidad_hab.Text))
            If Math.Abs(CDbl(lbl_cantidad_total.Text)) < _MONTO_PAGADO Then
                MsgBox("La cantidad total habilitada es mayor a la cantidad del pedido. Verifique!!!", MsgBoxStyle.Critical, "Sistemas")
                Exit Sub
            End If

            For Each items As DataRow In dt_detalle_pagos.Select("ITEM<>0", "ITEM DESC")
                _ultimo_item = items("ITEM")
                Exit For
            Next

            row("ITEM") = _ultimo_item + 1
            row("CANTIDAD") = CDbl(txt_cantidad_hab.Text)
            row("OBSERVACIONES") = txt_observaciones_hab.Text
            row("FECHA") = dtp_fecha_hab.Value.ToString("dd/MM/yyyy")
            row("ESTADO") = "PENDIENTE"
            dt_detalle_pagos.Rows.Add(row)
            dt_detalle_pagos.AcceptChanges()
            txt_cantidad_hab.Text = ""
            txt_observaciones_hab.Text = ""
            dtp_fecha_hab.Value = Date.Now
            txt_cantidad_hab.Focus()
            dgv_detalle_cobro.DataSource = dt_detalle_pagos

            If dt_detalle_pagos.Rows.Count > 0 Then
                _MONTO_PAGADO = Math.Abs(Math.Round(dt_detalle_pagos.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
            End If
            lbl_cantidad_total_hab.Text = Format(_MONTO_PAGADO, "##,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Validacion_registro() As Boolean

        If txt_cantidad_hab.Text.Trim = "" Then
            MsgBox("Debe digitar una cantidad.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        Else
            If CDbl(txt_cantidad_hab.Text) = 0 Then
                MsgBox("Debe digitar una cantidad mayor a cero.", MsgBoxStyle.Exclamation, "Sistemas")
                Return False
                Exit Function
            End If
        End If

        Return True

    End Function

    Public Sub GenerarColummnaDataTable()
        dt_detalle_pagos = New DataTable
        dt_detalle_pagos.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dt_detalle_pagos.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '1
        dt_detalle_pagos.Columns.Add("FECHA", Type.GetType("System.String")) '2
        dt_detalle_pagos.Columns.Add("OBSERVACIONES", Type.GetType("System.String")) '3
        dt_detalle_pagos.Columns.Add("ESTADO", Type.GetType("System.String")) '3
        dgv_detalle_cobro.DataSource = Nothing
        dgv_detalle_cobro.DataSource = dt_detalle_pagos

        dgv_detalle_cobro.Columns(0).HeaderText = "Item"
        dgv_detalle_cobro.Columns(1).HeaderText = "Cantidad"
        dgv_detalle_cobro.Columns(2).HeaderText = "Fecha"
        dgv_detalle_cobro.Columns(3).HeaderText = "Observaciones"
        dgv_detalle_cobro.Columns(4).HeaderText = "Estado"

        dgv_detalle_cobro.Columns(1).DefaultCellStyle.Format = "N2"
        dgv_detalle_cobro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgv_detalle_cobro.AutoResizeColumns()
        dgv_detalle_cobro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btn_del_regsanit_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgv_detalle_cobro.RowCount = 0 Then Exit Sub
        If dgv_detalle_cobro.CurrentRow Is Nothing Then Exit Sub
        Dim _MONTO_PAGADO As Double = 0

        If dgv_detalle_cobro.CurrentRow.Cells("ESTADO").Value <> "PENDIENTE" Then
            MsgBox("No se puede eliminar el item. Verifique!!!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo_Incripciones_Reg_Sanit()
        End If
        If dt_detalle_pagos.Rows.Count > 0 Then
            _MONTO_PAGADO = Math.Abs(Math.Round(dt_detalle_pagos.Compute("Sum(CANTIDAD)", ""), 4, MidpointRounding.AwayFromZero))
        End If
        lbl_cantidad_total_hab.Text = Format(_MONTO_PAGADO, "##,##0.00")
    End Sub
    Private Sub EliminandoArticulo_Incripciones_Reg_Sanit()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_detalle_cobro.Item(0, dgv_detalle_cobro.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dt_detalle_pagos.Select("ITEM=" & Codigo)
                item.Delete()
                dt_detalle_pagos.AcceptChanges()
            Next
            'RehacerSecuencia_Incripciones_RegSanit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_Incripciones_RegSanit()
        Dim i As Integer = 0
        For Each items As DataRow In dt_detalle_pagos.Rows
            i += 1
            dt_detalle_pagos.BeginInit()
            items("ITEM") = i
            dt_detalle_pagos.EndInit()
            dt_detalle_pagos.AcceptChanges()
        Next
    End Sub

    Private Sub txt_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_hab.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_observaciones_hab.Focus()
        End If
    End Sub

    Private Sub txt_num_operacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observaciones_hab.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fecha_hab.Focus()
        End If
    End Sub

    Private Sub btnAceptarNumeracion_Click(sender As Object, e As EventArgs) Handles btnAceptarNumeracion.Click
        If dt_detalle_pagos.Rows.Count = 0 Then
            MsgBox("Debe registrar al menos una habilitación. Verifique!!!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            Dim planilladetBE As ClsEntidades.RECEIVABLE_LIST_LINE
            Dim ls_detalle As New List(Of ClsEntidades.RECEIVABLE_LIST_LINE)

            If dt_detalle_pagos.Rows.Count > 0 Then
                For i As Integer = 0 To dt_detalle_pagos.Rows.Count - 1
                    planilladetBE = New ClsEntidades.RECEIVABLE_LIST_LINE
                    With planilladetBE
                        .ID = pedido
                        .ITEM = item_pedido
                        .LIST_ID = dt_detalle_pagos.Rows(i).Item("ITEM")
                        .AMOUNT = dt_detalle_pagos.Rows(i).Item("CANTIDAD")
                        .DATE_PLA = CDate(dt_detalle_pagos.Rows(i).Item("FECHA").ToString).ToShortDateString
                        .NUM_REF = dt_detalle_pagos.Rows(i).Item("OBSERVACIONES").ToString
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .PAY_AUTO = dt_detalle_pagos.Rows(i).Item("ESTADO")
                    End With
                    ls_detalle.Add(planilladetBE)
                Next
            End If

            If cabeceraBL.Registro_Hab_Facturacion(ls_detalle, pedido, item_pedido) = False Then
                MsgBox("Hubo un Error en el registro de la Habilitación para Facturación.", MsgBoxStyle.Critical)
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                MsgBox("Registro de Habilitación correctamente.", MsgBoxStyle.Information)
                flag_hab = True
                Me.Cursor = Cursors.Default
                Me.Close()
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalirNumeracion_Click(sender As Object, e As EventArgs) Handles btnSalirNumeracion.Click
        Me.Close()
    End Sub

    Private Sub dtp_fecha_hab_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_hab.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub
End Class