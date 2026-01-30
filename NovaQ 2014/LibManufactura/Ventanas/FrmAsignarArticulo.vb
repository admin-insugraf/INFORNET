Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmAsignarArticulo

    Public AlmacenOrigen As String
    Public MonedaOrigen As String
    Public EstadoOrigen As Boolean = False
    Public _id_item As String

    Public TipoDocumento As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE

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

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("QTY_TEORICA", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("AVERAGE_COST", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("EQUIVALENCIA", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("TYPE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("POR_EXCESO", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("DESCARGA_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticulo.PrimaryKey = New DataColumn() {dtdetalleArticulo.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "CTR_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = AlmacenOrigen
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                cbounidadMedida.SelectedValue = frm.Data_Matriz.Rows(0).Item("UNIDAD").ToString
                If MonedaOrigen = "MN" Then
                    Stock = frm.Data_Matriz.Rows(0).Item("COSTO_MN").ToString
                ElseIf MonedaOrigen = "ME" Then
                    Stock = frm.Data_Matriz.Rows(0).Item("COSTO_ME").ToString
                End If
                txtcosto.Text = Format(Stock, "##,##0.00")
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            ManufacturaBl = New ClsOperaciones.FORMULATION
            dtDocumentoGuias = New DataTable("Part_Manufactura")
            Dim Stock As Double = 0.0
            dtDocumentoGuias = ManufacturaBl.Mostrar_Articulo_Manual(AlmacenOrigen, _codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                cbounidadMedida.SelectedValue = dtDocumentoGuias.Rows(0).Item("UNIDAD").ToString
                If Flag_Modo_Edicion = False Then
                    If MonedaOrigen = "MN" Then
                        Stock = dtDocumentoGuias.Rows(0).Item("COSTO_MN").ToString
                    ElseIf MonedaOrigen = "ME" Then
                        Stock = dtDocumentoGuias.Rows(0).Item("COSTO_ME").ToString
                    End If
                    txtcosto.Text = Format(Stock, "##,##0.00")
                End If
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtcosto.Text = String.Empty
                txtcodigoArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
            End If
            'If txtcodigoArticulo.Text = "N0008" Then
            '    txtdescripcionArticulo.ReadOnly = False
            '    txtdescripcionArticulo.BackColor = Drawing.Color.White
            'Else
            '    txtdescripcionArticulo.ReadOnly = True
            '    txtdescripcionArticulo.BackColor = Drawing.Color.LightGray
            'End If
        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticulo.Rows.Count() - 1
                    txtcantidadPractica.Text = dtdetalleArticulo.Rows(i).Item("QTY").ToString
                    txtcantidadteorica.Text = dtdetalleArticulo.Rows(i).Item("QTY_TEORICA").ToString
                    txtcosto.Text = dtdetalleArticulo.Rows(i).Item("AVERAGE_COST").ToString
                    cbounidadMedida.SelectedValue = dtdetalleArticulo.Rows(i).Item("UNIT").ToString
                    chkindicacion.Checked = IIf(dtdetalleArticulo.Rows(i).Item("DESCARGA_TOTAL").ToString = 1, True, False)
                    txtexceso.Text = dtdetalleArticulo.Rows(i).Item("POR_EXCESO").ToString
                    TIPO_PROD = dtdetalleArticulo.Rows(i).Item("TYPE").ToString
                    AgregarArticuloManual(dtdetalleArticulo.Rows(i).Item("PART_ID").ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            ManufacturaBl = New ClsOperaciones.FORMULATION
            Dim dtUnidad As New DataTable
            dtUnidad = ManufacturaBl.UnidadesReferencia()
            If dtUnidad.Rows.Count() <> 0 Then
                cbounidadMedida.ValueMember = "CODIGO"
                cbounidadMedida.DisplayMember = "DESCRIPCION"
                cbounidadMedida.DataSource = dtUnidad
            Else
                MsgBox("No hay Unidades para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmAsignarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ayuda_Unidad_Medida()
        If Flag_Modo_Edicion = True Then
            ModoEdicion()
        Else
            GenerarColummnaDataTable()
            chkindicacion.Checked = False
            txtexceso.Text = 0
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
            ElseIf txtcantidadPractica.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information)
                estado = False
                txtcantidadPractica.Focus()
                Exit Try
            ElseIf txtcantidadteorica.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad Teorica.", MsgBoxStyle.Information)
                estado = False
                txtcantidadteorica.Select()
                Exit Try
            End If
            'If Val(txtcosto.Text) <= 0 Then
            '    MsgBox("El precio debe ser mayor a Cero", MsgBoxStyle.Information)
            '    estado = False
            '    txtcosto.Focus()
            '    Exit Try
            'End If
            If Val(txtcantidadPractica.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtcantidadPractica.Focus()
                Exit Try
            End If
            If Val(txtcantidadteorica.Text) <= 0 Then
                MsgBox("La cantidad Teorica debe ser mayor a Cero", MsgBoxStyle.Information)
                estado = False
                txtcantidadteorica.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
            row("PART_ID") = txtcodigoArticulo.Text
            row("DESCRIPTION") = txtdescripcionArticulo.Text
            row("UNIT") = cbounidadMedida.SelectedValue
            row("QTY") = If(txtcantidadPractica.Text = String.Empty, 0, txtcantidadPractica.Text)
            row("QTY_TEORICA") = If(txtcantidadteorica.Text = String.Empty, 0, txtcantidadteorica.Text)
            row("AVERAGE_COST") = If(txtcosto.Text = String.Empty, 0, txtcosto.Text)
            row("EQUIVALENCIA") = txtequivalencia.Text
            row("TYPE") = TIPO_PROD
            row("POR_EXCESO") = IIf(txtexceso.Text = String.Empty, 0, txtexceso.Text)
            row("DESCARGA_TOTAL") = IIf(chkindicacion.Checked, 1, 0)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = _id_item 'dtdetalleArticulo.Rows.Count() + 1
            row("PART_ID") = txtcodigoArticulo.Text
            row("DESCRIPTION") = txtdescripcionArticulo.Text
            row("UNIT") = cbounidadMedida.SelectedValue
            row("QTY") = If(txtcantidadPractica.Text = String.Empty, 0, txtcantidadPractica.Text)
            row("QTY_TEORICA") = If(txtcantidadteorica.Text = String.Empty, 0, txtcantidadteorica.Text)
            row("AVERAGE_COST") = If(txtcosto.Text = String.Empty, 0, txtcosto.Text)
            row("EQUIVALENCIA") = txtequivalencia.Text
            row("TYPE") = TIPO_PROD
            row("POR_EXCESO") = IIf(txtexceso.Text = String.Empty, 0, txtexceso.Text)
            row("DESCARGA_TOTAL") = IIf(chkindicacion.Checked, 1, 0)
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
        End If
        Me.Close()
    End Sub

 

    Private Sub txtcodigoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            txtcodigoArticulo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub txtcantidadPractica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadPractica.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        '------
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidadteorica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadteorica.KeyPress
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

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
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

    Private Sub Ayuda_Unidad_Medida_Equivalencia()
        Try
            ManufacturaBl = New ClsOperaciones.FORMULATION
            Dim dtUnidad As New DataTable
            dtUnidad = ManufacturaBl.UnidadesReferencia_Equivalencia(cbounidadMedida.SelectedValue.ToString)
            If dtUnidad.Rows.Count() <> 0 Then
                txtequivalencia.Text = dtUnidad.Rows(0).Item(0).ToString
            Else
                MsgBox("No hay Equivalencia para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbounidadMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbounidadMedida.SelectedIndexChanged
        If cbounidadMedida.DataSource Is Nothing Then Exit Sub
        If cbounidadMedida.SelectedIndex <> -1 Then
            Ayuda_Unidad_Medida_Equivalencia()
        End If
    End Sub

    Private Sub txtcantidadPractica_Leave(sender As Object, e As EventArgs) Handles txtcantidadPractica.Leave
        ' If txtcantidadPractica.Text = String.Empty Then Exit Sub
        'txtcantidadteorica.Text = txtcantidadPractica.Text
    End Sub
 
    Private Sub txtexceso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtexceso.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub txtcodigoArticulo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtequivalencia.KeyPress, txtdescripcionArticulo.KeyPress, txtcodigoArticulo.KeyPress, cbounidadMedida.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtexceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtexceso.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcantidadPractica_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidadPractica.KeyDown
        If txtcantidadPractica.Text = String.Empty Then Exit Sub
        txtcantidadteorica.Text = txtcantidadPractica.Text

        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        fl_close = True
        Me.Close()
    End Sub

 
    Private Sub txtcantidadPractica_TextChanged(sender As Object, e As EventArgs) Handles txtcantidadPractica.TextChanged
        txtcantidadteorica.Text = txtcantidadPractica.Text
    End Sub
End Class