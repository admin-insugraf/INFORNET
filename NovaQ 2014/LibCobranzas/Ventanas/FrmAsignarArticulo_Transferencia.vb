Imports System.Windows.Forms
Imports LibComunVar
Public Class FrmAsignarArticulo_Transferencia
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
    Public Qt_saldo As Double = 0.0
    Public _IS_LOT As String
    Public _IS_LIBRE As String
    Public frm As New frm_GuiaRemision_tranferencia_Interna

    Public Sub GenerarColummnaDataTable()
        dtdetalleArticulo = New DataTable
        dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleArticulo.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtdetalleArticulo.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dtdetalleArticulo.Columns.Add("UNIDAD", Type.GetType("System.String"))
        dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
    End Sub
    Private Sub MostrarFechaVencimiento(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        'cadena = "SELECT CADUCATE_DATE FROM lot WHERE LOT_ID='" & codigooLote & "' and WHO_ID='" & AlmacenOrigen & "' "
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
            dtlote = clsArticuloBl.get_ArticuloLote(AlmacenOrigen, codigoArticulo, ValidacionLotes)
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DataSource = dtlote
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"
                If cboLotes.Items.Count() <> 0 Then
                    cboLotes.SelectedIndex = 0
                    txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                    MostrarFechaVencimiento(cboLotes.Text)
                    cboLotes.Enabled = True
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                End If
            Else
                MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad.", MsgBoxStyle.Information)
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

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "GUIA_SP_S_GUIA_REMISION_PART"
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
                If frm.Data_Matriz.Rows(0).Item(4).ToString = "N" And frm.Data_Matriz.Rows(0).Item(5).ToString = "N" Then
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                    txtdescripcionArticulo.ReadOnly = False
                    _IS_LIBRE = "N"
                    _IS_LOT = "N"
                ElseIf frm.Data_Matriz.Rows(0).Item(4).ToString = "S" And frm.Data_Matriz.Rows(0).Item(5).ToString = "N" Then
                    MostrandoLotes(txtcodigoArticulo.Text)
                    cboLotes.Select()
                    _IS_LIBRE = "N"
                    _IS_LOT = "S"
                ElseIf frm.Data_Matriz.Rows(0).Item(4).ToString = "N" And frm.Data_Matriz.Rows(0).Item(5).ToString = "S" Then
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                    _IS_LIBRE = "S"
                    _IS_LOT = "N"
                End If
                
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
            dtDocumentoGuias = clsArticuloBl.get_VerificacionArticuloCodigo(AlmacenOrigen, _codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                If ft_sin_descargo Then
                    txtcodigoArticulo.Enabled = False
                Else
                    txtcodigoArticulo.Enabled = True
                End If
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0")
                If dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString = "N" And dtDocumentoGuias.Rows(0).Item("IS_STOCKED").ToString = "N" Then
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                    txtdescripcionArticulo.ReadOnly = False
                    _IS_LIBRE = "N"
                    _IS_LOT = "N"
                ElseIf dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString = "S" And dtDocumentoGuias.Rows(0).Item("IS_STOCKED").ToString = "N" Then
                    MostrandoLotes(codArticulo)
                    cboLotes.Select()
                    _IS_LIBRE = "N"
                    _IS_LOT = "S"
                ElseIf dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString = "N" And dtDocumentoGuias.Rows(0).Item("IS_STOCKED").ToString = "S" Then
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                    _IS_LIBRE = "S"
                    _IS_LOT = "N"
                End If
                
            Else
                If ft_sin_descargo = True Then
                    MsgBox("No hay informacion con el codigo Articulo especificado", MsgBoxStyle.Information)
                    fl_close = True
                    Me.Close()
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
                codigoArticulo = txtcodigoArticulo.Text
                AgregarArticuloManual(codigoArticulo)
            End If
        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtdetalleArticulo.Rows.Count() - 1
                    AgregarArticuloManual(dtdetalleArticulo.Rows(i).Item("CODIGO").ToString)
                    txtcantidad.Text = dtdetalleArticulo.Rows(i).Item("CANTIDAD").ToString
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
            If ft_sin_descargo = True Then
                Label6.Visible = True
                txtSaldo.Visible = True
                txtSaldo.Text = Format(Qt_saldo, "##,##0.0.0")
            Else
                Label6.Visible = False
                txtSaldo.Visible = False
            End If
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
                Exit Try
            End If


            
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        If txtcantidad.Text = String.Empty Then
            txtcantidad.Focus()
            Exit Sub
        End If
        If Val(txtcantidad.Text) <= 0 Then
            MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
            txtcantidad.Focus()
            Exit Sub
        End If
        If _IS_LOT = "S" And _IS_LIBRE = "N" Then
            If CDbl(txtStockLote.Text) < CDbl(txtcantidad.Text) Then
                MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                txtcantidad.Select()
                Exit Sub
            End If
        ElseIf _IS_LOT = "N" And _IS_LIBRE = "N" Then

        ElseIf _IS_LOT = "N" And _IS_LIBRE = "S" Then
            If CDbl(txtStock.Text) < CDbl(txtcantidad.Text) Then
                MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                txtcantidad.Select()
                Exit Sub
            End If
        End If
        
        If ft_sin_descargo = True Then
            If CDbl(txtSaldo.Text) < txtcantidad.Text Then
                MsgBox("La cantidad debe ser menor o igual que el  Saldo.", MsgBoxStyle.Information)
                txtcantidad.Select()
                Exit Sub
            End If
        End If

        If Flag_Modo_Edicion = False Then
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("LOTE") = cboLotes.Text
            row("CANTIDAD") = txtcantidad.Text
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
            row("LOTE") = cboLotes.Text
            row("CANTIDAD") = txtcantidad.Text
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
    End Sub

    Private Sub cboLotes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLotes.SelectedValueChanged
        If cboLotes.DataSource Is Nothing Then Exit Sub
        If cboLotes.Items.Count() <> 0 Then
            txtStockLote.Text = cboLotes.SelectedValue.ToString
            MostrarFechaVencimiento(cboLotes.Text)
        End If
    End Sub

    Private Sub cboLotes_KeyDown(sender As Object, e As KeyEventArgs) Handles cboLotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

End Class