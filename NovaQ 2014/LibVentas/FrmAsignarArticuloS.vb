Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarArticuloS
    Public AlmacenOrigen As String

    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Public dtdetalleArticulo As DataTable
    Public ValidacionLotes As String = String.Empty
    Public Flag_Modo_Edicion As Boolean = False
    Public ft_sin_descargo As Boolean = False
    Public fl_close As Boolean = False
    Public CodigoArticulo As String = String.Empty
    Public ListaValidacionArticulo As List(Of String)



    Public Sub GenerarColummnaDataTable()
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

        dtdetalleArticulo.Columns.Add("PRECIO_INICIAL", Type.GetType("System.String"))
        dtdetalleArticulo.Columns.Add("TOTAL_INICIAL", Type.GetType("System.Double"))
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PED_SP_S_ORDERS_PART"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
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
            dtDocumentoGuias = clsArticuloBl.get_VerificacionArticuloCodigoPedido(AlmacenOrigen, _codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                If ft_sin_descargo Then
                    txtcodigoArticulo.Enabled = False
                Else
                    txtcodigoArticulo.Enabled = True
                End If
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtcodigoArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then Exit Sub
            Dim codigoArticulo As String = String.Empty
            codigoArticulo = txtcodigoArticulo.Text
            AgregarArticuloManual(codigoArticulo)
        End If

    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticulo.Rows.Count() - 1
                    AgregarArticuloManual(dtdetalleArticulo.Rows(i).Item("CODIGO").ToString)
                    txtcantidad.Text = dtdetalleArticulo.Rows(i).Item("CANTIDAD").ToString
                    txtprecioUnitario.Text = dtdetalleArticulo.Rows(i).Item("PRECIO_INICIAL").ToString
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
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
            If txtcodigoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            ElseIf txtcantidad.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information)
                estado = False
                txtcantidad.Focus()
                Exit Try
            ElseIf txtprecioUnitario.Text = String.Empty Then
                MsgBox("Debe ingresar el Precio Unitario.", MsgBoxStyle.Information)
                estado = False
                txtprecioUnitario.Focus()
                Exit Try
            End If

            If Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
                txtcantidad.Focus()
                Exit Try
            End If
            If Val(txtprecioUnitario.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
                txtprecioUnitario.Focus()
                Exit Try
            End If
            If ListaValidacionArticulo IsNot Nothing Then
                If ListaValidacionArticulo.Count() <> 0 Then
                    For i As Integer = 0 To ListaValidacionArticulo.Count() - 1
                        If ListaValidacionArticulo.Item(i) = txtcodigoArticulo.Text Then
                            MsgBox("El articulo ya se agrego con Anterioridad", MsgBoxStyle.Information)
                            txtcodigoArticulo.Focus()
                            estado = False
                            Exit Try
                        End If
                    Next
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
            row("LOTE") = ""
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = 0
            row("%DESC.ART_2") = 0
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
            row("LOTE") = ""
            row("PREC_UNITARIO") = 0
            row("%DESC.ART_1") = 0
            row("%DESC.ART_2") = 0
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
            btnAceptar.Focus()
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
End Class