Imports System.Windows.Forms
Imports LibCobranzas

Public Class frmLineaNotaPedido
    Public Property Objeto As LineaNotaPedido
    Public Property EsValorizado As Boolean
    Public Property IDAlmacen As String
    Dim FlagLote As Boolean = True
    Dim clsBusquedaBl As ClsBuscar
    Dim dtData As DataTable
    Public dtDetallesBulto As DataTable
    Public Flag_ModoEdicion As Boolean = False
    Public Identificador As String = String.Empty
    Public TransaccionTipoArticulo As String = String.Empty
    Public ValidacionLotes As String = String.Empty
    Public TipoMov As String = String.Empty
    Public AlmacenOrigen As String = String.Empty

    Dim clsArticuloBl As ClsOperaciones.PART
    Dim dtlote As DataTable

    Private mEditRow As Integer = -1

    Private Sub LlenarCombos()
        Using context = AlmacenContext.CrearContext() 'New AlmacenContext()
            Dim lstUnidad = (From u In context.Unidades
                             Select u).ToList()
            bsUnidad.DataSource = lstUnidad
        End Using
        txtMonto.Visible = EsValorizado
        Label5.Visible = EsValorizado
    End Sub

    Public Function ShowAgregar() As System.Windows.Forms.DialogResult
        LlenarCombos()
        GenerarColummnaDataTable()
        txtarticulo.Select()
        Return Me.ShowDialog()
    End Function

    Public Function ShowEditar(linea As LineaNotaPedido) As DialogResult
        LlenarCombos()
        Objeto = linea
        txtarticulo.Text = linea.IDArticulo
        lblArticulodescripcion.Text = linea.Articulo
        cmbUnidad.SelectedValue = linea.UnitArticulo
        txtCantidad.Text = linea.Cantidad.ToString("N2")
        txtMonto.Text = linea.Monto.ToString("N2")
        txtnumerobultos.Text = IIf(linea.QT_BULTOS.ToString = String.Empty, "", linea.QT_BULTOS)
        txtnumeroProtocolo.Text = linea.NUM_PROTOCOLOS

        If linea.OPT_ENTREGA = "0" Then
            rbparcial.Checked = True
        ElseIf linea.OPT_ENTREGA = "1" Then
            rbfinal.Checked = True
        End If

        Using context = AlmacenContext.CrearContext()
            Dim art = (From a In context.Articulos
                       Where a.Codigo = linea.IDArticulo
                       Select a).First()
            If art.EsLote Then
                LlenarLotes(art)
                If cmbLote.SelectedIndex <> -1 Then
                    cmbLote.SelectedIndex = 0
                    MostrarFechaVencimiento()
                Else
                    lblFechaVencimiento.Text = ""
                End If
            Else : LimpiarLotes()
            End If
        End Using
        If Convert.ToString(txtnumerobultos.Text) = String.Empty Then
            Return Me.ShowDialog()
        Else
            LLenarDatosBultos(Flag_ModoEdicion)
            AjustarTamaño(True)
        End If
        Return Me.ShowDialog()
    End Function

    Private Sub MostrarFechaVencimiento()
        Dim cadena As String = String.Empty
        Dim dtTable As New DataTable
        Dim LibData As New LibConexion.ClsData
        If cmbLote.SelectedIndex = -1 Then Exit Sub
        Dim codigoLote As String = String.Empty
        codigoLote = cmbLote.SelectedValue.ToString
        cadena = "SELECT CADUCATE_DATE FROM lot WHERE LOT_ID='" & codigoLote & "'"
        Dim fecha As String = String.Empty
        dtTable = LibData.Run_Query_DataTable(cadena)
        LibData.Dispose()
        fecha = dtTable.Rows(0).Item(0).ToString()
        lblFechaVencimiento.Text = Format(fecha, "Short date")
    End Sub

    Private Sub LlenarLotes(articulo As Articulo)
        Dim qry = (From l In articulo.Lotes
           Where l.IDAlmacen = Me.IDAlmacen
           Select l)
        bsLote.DataSource = qry.ToList()
        cmbLote.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        btnNuevoLote.Visible = True
        lblFechaVencimiento.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub LimpiarLotes()
        bsLote.DataSource = New List(Of Lote)()
        cmbLote.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        btnNuevoLote.Visible = False
        FlagLote = False
        lblFechaVencimiento.Visible = False
    End Sub

    Private Function Validar() As Boolean
        Dim res As Boolean = True
        Try
            If String.IsNullOrEmpty(txtarticulo.Text) Then
                MsgBox("Es necesario elegir un Articulo.", MsgBoxStyle.Information)
                txtarticulo.Focus()
                res = False
                Exit Try
            Else
                clsBusquedaBl = New ClsBuscar
                dtData = New DataTable
                dtData = clsBusquedaBl.MostrarDescripcionArticulo(txtarticulo.Text, TransaccionTipoArticulo)
                If dtData.Rows.Count() = 0 Then
                    MsgBox("Error de codigo de Articulo, verifique.", MsgBoxStyle.Information)
                    res = False
                    Exit Try
                End If
            End If
            If FlagLote = True Then
                If String.IsNullOrEmpty(cmbLote.Text) Then
                    MsgBox("Es necesario elegir un Lote, si no existe puede Crearlo.", MsgBoxStyle.Information)
                    cmbLote.Focus()
                    res = False
                    Exit Try
                End If
            End If

            Try
                Dim valor = CDec(txtCantidad.Text)
            Catch ex As Exception
                errores.SetError(txtCantidad, "Debe ser un numero")
                res = False
            End Try

            If txtnumerobultos.TextLength <> 0 Then
                If Val(txtnumerobultos.Text) <= 0 Then
                    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
                    txtnumerobultos.Focus()
                    res = False
                    Exit Try
                End If
                If txtCantidad.Text < Val(txtnumerobultos.Text) Then
                    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                    txtnumerobultos.Select()
                    res = False
                    Exit Try
                End If
                If dtDetallesBulto.Rows.Count() = 0 Then
                    AjustarTamaño(True)
                    GenerarColummnaDataTable()
                    LLenarDatosBultos(Flag_ModoEdicion)
                    MsgBox("No se agrego Datos de los Bultos.", MsgBoxStyle.Information)
                    res = False
                    Exit Try
                End If
            End If

            If EsValorizado Then
                Try
                    Dim valor = CDec(txtMonto.Text)
                Catch ex As Exception
                    errores.SetError(txtMonto, "Debe ser un numero")
                    res = False
                End Try
            End If
        Catch ex As Exception
            res = False
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Private Sub AgregarProducto()
        If Validar() Then
            If IsNothing(Objeto) Then Objeto = New LineaNotaPedido
            Objeto.IDArticulo = txtarticulo.Text
            Objeto.Articulo = lblArticulodescripcion.Text
            Objeto.UnitArticulo = cmbUnidad.SelectedValue
            Objeto.Cantidad = txtCantidad.Text
            If EsValorizado Then
                Objeto.Monto = txtMonto.Text
            Else
                Objeto.Monto = 0
            End If
            If FlagLote = True Then
                Objeto.Lote = cmbLote.SelectedValue
            Else
                Objeto.Lote = ""
            End If
            If txtnumerobultos.Text = String.Empty Then
                Objeto.QT_BULTOS = ""
            Else
                Objeto.QT_BULTOS = txtnumerobultos.Text
            End If
            Objeto.NUM_PROTOCOLOS = txtnumeroProtocolo.Text
            If rbparcial.Checked = True Then
                Objeto.OPT_ENTREGA = "0"
            ElseIf rbfinal.Checked = True Then
                Objeto.OPT_ENTREGA = "1"
            End If
            'If dtDetallesBulto.Rows.Count() = 0 Then
            '    AjustarTamaño(True)
            '    GenerarColummnaDataTable()
            '    LLenarDatosBultos(Flag_ModoEdicion)
            '    MsgBox("No se agrego Datos de los Bultos.", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            DialogResult = DialogResult.OK
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        AgregarProducto()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub CodigoArticulo()
        Try
            Dim frmA As New bscArticulo
            frmA.Transaccion_TipoArticulo = TransaccionTipoArticulo
            If frmA.ShowDialog() = DialogResult.OK Then
                Using context = AlmacenContext.CrearContext()
                    Dim art = (From a In context.Articulos
                               Where a.Codigo = frmA.Objeto
                               Select a).First()
                    txtarticulo.Text = art.Codigo
                    lblArticulodescripcion.Text = art.Descripcion
                    cmbUnidad.SelectedValue = art.Unidad
                    cmbUnidad.Enabled = False
                    If art.EsLote Then
                        LlenarLotes(art)
                        If cmbLote.SelectedIndex <> -1 Then
                            cmbLote.SelectedIndex = 0
                            MostrarFechaVencimiento()
                            cmbLote.Select()
                        Else
                            lblFechaVencimiento.Text = ""
                        End If
                    Else : LimpiarLotes()
                    End If
                End Using
                GenerarColummnaDataTable()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrandoLotes(ByVal codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            '++Informacion de Lotes
            dtlote = New DataTable
            dtlote = clsArticuloBl.get_ArticuloLote(AlmacenOrigen, codigoArticulo, ValidacionLotes)
            If dtlote.Rows.Count() <> 0 Then


                bsLote.DataSource = New List(Of Lote)()
                bsLote.DataSource = dtlote
                cmbLote.Visible = True
                'If bsLote.Items.Count() <> 0 Then
                '    cboLotes.SelectedIndex = 0
                '    If ItemLote <> String.Empty Then
                '        cboLotes.Text = ItemLote.ToString
                '    End If
                '    txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                '    MostrarFechaVencimiento(cboLotes.Text)
                '    cboLotes.Enabled = True
                '    txtCantidad.Enabled = True
                '    btnAceptar.Visible = True
                'End If
            Else
                'MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad, Verifique.", MsgBoxStyle.Information)
                'cboLotes.Enabled = False
                'txtCantidad.Enabled = False
                'btnAceptar.Visible = False
                'txtCantidad.Text = String.Empty
                'txtStockLote.Text = String.Empty
                'cboLotes.DataSource = Nothing
                'txtcodigoArticulo.Focus()
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
                txtarticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lblArticulodescripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                cmbUnidad.SelectedValue = frm.Data_Matriz.Rows(0).Item(2).ToString
                Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtStock.Text = Format(Stock, "##,##0.0.0")

                MostrandoLotes(txtarticulo.Text)

                '    Using context = AlmacenContext.CrearContext()
                '        Dim art = (From a In context.Articulos
                '                              Where a.Codigo = txtarticulo.Text
                '                              Select a).First()

                '    End Using

                '    LlenarLotes(art)
                '    If cmbLote.SelectedIndex <> -1 Then
                '        cmbLote.SelectedIndex = 0
                '        MostrarFechaVencimiento()
                '        cmbLote.Select()
                '    Else
                '        lblFechaVencimiento.Text = ""
                '    End If
                'Else : LimpiarLotes()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticulo_DoubleClick(sender As Object, e As EventArgs) Handles txtarticulo.DoubleClick
        If TipoMov = "S" Then
            MostrandoArticulos()
        Else
            CodigoArticulo()
        End If

    End Sub

    Private Sub cmbLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLote.SelectedIndexChanged
        MostrarFechaVencimiento()
    End Sub

    Private Sub btnNuevoLote_Click(sender As Object, e As EventArgs) Handles btnNuevoLote.Click
        Dim frm As New frmAgregarLote
        frm.idProducto = txtarticulo.Text
        frm.idAlmacen = IDAlmacen
        frm.ShowDialog()
        If frm.indicador = True Then Exit Sub
        Using context = AlmacenContext.CrearContext()
            Dim art = (From a In context.Articulos
                                  Where a.Codigo = frm.txtcodigoArticulo.Text
                                  Select a).First()
            LlenarLotes(art)
            cmbLote.SelectedIndex = 0
            MostrarFechaVencimiento()
        End Using
        frm.Close()
    End Sub

    Private Sub txtnumerobultos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerobultos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub cmbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmbLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbLote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtnumeroProtocolo.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnumeroProtocolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroProtocolo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub txtarticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulo.KeyDown
        If e.KeyCode = Keys.F1 Then CodigoArticulo()
        If e.KeyCode = Keys.Enter Then
            If txtarticulo.Text = String.Empty Then Exit Sub
            Dim codigoArticulo As String = String.Empty
            clsBusquedaBl = New ClsBuscar
            dtData = New DataTable
            dtData = clsBusquedaBl.MostrarDescripcionArticulo(txtarticulo.Text, TransaccionTipoArticulo)
            If dtData.Rows.Count() <> 0 Then
                codigoArticulo = dtData.Rows(0).Item("Codigo").ToString
                Using context = AlmacenContext.CrearContext()
                    Dim art = (From a In context.Articulos
                               Where a.Codigo = codigoArticulo
                               Select a).First()
                    txtarticulo.Text = art.Codigo
                    lblArticulodescripcion.Text = art.Descripcion
                    cmbUnidad.SelectedValue = art.Unidad
                    cmbUnidad.Enabled = False
                    If art.EsLote Then
                        LlenarLotes(art)
                        If cmbLote.SelectedIndex <> -1 Then
                            cmbLote.SelectedIndex = 0
                            MostrarFechaVencimiento()
                        Else
                            lblFechaVencimiento.Text = ""
                        End If
                    Else : LimpiarLotes()
                    End If
                    cmbLote.Focus()
                End Using
                GenerarColummnaDataTable()
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtarticulo.Text = String.Empty
                lblArticulodescripcion.Text = String.Empty
                LimpiarLotes()
            End If
        End If
    End Sub

    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(961, 315)
            Me.GroupBox1.Enabled = False
        Else
            Size = New System.Drawing.Size(602, 315)
            Me.GroupBox1.Enabled = True
        End If
    End Sub

    Public Sub GenerarColummnaDataTable()
        dtDetallesBulto = New DataTable
        dtDetallesBulto.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("LOTE", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtDetallesBulto.Columns.Add("QTY", Type.GetType("System.Double"))
        dtDetallesBulto.Columns.Add("QTY_BULTOS", Type.GetType("System.Double"))
        dtDetallesBulto.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    Private Sub LLenarDatosBultos(ByVal Opcion As Boolean)
        Try
            If Opcion = True Then
                If dtDetallesBulto.Rows.Count() <> 0 Then
                    dgvDetallesBulto.Rows.Clear()
                    For i As Integer = 0 To dtDetallesBulto.Rows.Count() - 1
                        dgvDetallesBulto.Rows.Add(i + 1, dtDetallesBulto.Rows(i).Item("QTY"), dtDetallesBulto.Rows(i).Item("QTY_BULTOS"))
                    Next
                    txtCantidadAsiganda.Text = txtCantidad.Text
                Else
                    Dim CantidadTotal As String = String.Empty
                    If IsNumeric(txtCantidad.Text) Or txtCantidad.Text <> String.Empty Then
                        dgvDetallesBulto.Rows.Clear()
                        For i As Integer = 0 To txtnumerobultos.Text - 1
                            dgvDetallesBulto.Rows.Add(i + 1, txtCantidad.Text, "0.0")
                        Next
                    End If
                End If
            Else
                If dtDetallesBulto.Rows.Count() <> 0 Then dgvDetallesBulto.Rows.Clear()

                Dim CantidadTotal As String = String.Empty
                If IsNumeric(txtCantidad.Text) Or txtCantidad.Text <> String.Empty Then
                    dgvDetallesBulto.Rows.Clear()
                    For i As Integer = 0 To txtnumerobultos.Text - 1
                        dgvDetallesBulto.Rows.Add(i + 1, txtCantidad.Text, "0.0")
                    Next
                End If
                dgvDetallesBulto.BeginEdit(True)
                dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, 0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataGridView, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = txtarticulo.Text
                If cmbLote.Text = String.Empty Then
                    row("LOTE") = ""
                Else
                    row("LOTE") = cmbLote.SelectedValue.ToString
                End If
                row("ITEM") = i + 1
                row("QTY") = txtCantidad.Text
                row("QTY_BULTOS") = CDbl(TablaOrigen.Item(2, i).Value)
                row("IDENTIFICADOR") = indice
                dtDetallesBulto.Rows.Add(row)
                dtDetallesBulto.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarDatosBultos(ByVal opcion As Boolean)
        Try
            If opcion Then
                GenerarColummnaDataTable()
                AgregandoNuevosDatosBultos(dgvDetallesBulto, dtDetallesBulto, Identificador)
            Else
                GenerarColummnaDataTable()
                AgregandoNuevosDatosBultos(dgvDetallesBulto, dtDetallesBulto, Identificador)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnumerobultos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumerobultos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCantidad.Text = String.Empty Then
                txtCantidad.Focus()
                Exit Sub
            End If
            If txtnumerobultos.TextLength <> 0 Then
                If Val(txtnumerobultos.Text) <= 0 Then
                    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
                    txtnumerobultos.Focus()
                    Exit Sub
                End If
                If txtnumerobultos.Text = String.Empty Then
                    txtnumerobultos.Focus()
                    Exit Sub
                End If
                If txtCantidad.Text < Val(txtnumerobultos.Text) Then
                    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                AjustarTamaño(True)
                GenerarColummnaDataTable()
                LLenarDatosBultos(Flag_ModoEdicion)
            Else
                btnAceptar_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub GuardarBultos()
        Try
            Dim SubTotal As Decimal
            Dim valor As String = String.Empty
            For i As Integer = 0 To dgvDetallesBulto.Rows.Count() - 1
                Dim value As Object = dgvDetallesBulto.Item(2, i).Value
                If ((Convert.ToString(value) = String.Empty) OrElse (Not (IsNumeric(value)))) Then
                    MsgBox("No se ingreso un Numero en la posicion :" & i + 1, MsgBoxStyle.Information)
                    dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, i)
                    Exit Sub
                End If
                SubTotal += value
            Next
            'Mostrando La cantidad Asignada.
            txtCantidadAsiganda.Text = SubTotal
            If txtCantidad.Text <> SubTotal Then
                MsgBox("La Cantidad Asignada a cada Bultos en total debe ser igual a : " & txtCantidad.Text, MsgBoxStyle.Information)
                Exit Sub
            End If
            AgregarDatosBultos(Flag_ModoEdicion)
            AjustarTamaño(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptarBultos_Click(sender As Object, e As EventArgs) Handles btnAceptarBultos.Click
        GuardarBultos()
        btnAceptar.Focus()
    End Sub

    Private Sub SalirBultos_Click(sender As Object, e As EventArgs) Handles SalirBultos.Click
        AjustarTamaño(False)
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
          ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetallesBulto.CurrentCell.ColumnIndex
        If columna = 2 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or _
           (caracter = ChrW(Keys.Back)) Or _
           (caracter = ".") And _
           (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
       ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetallesBulto.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress

    End Sub
    Private Sub dgvDetallesBulto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetallesBulto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarBultos.Focus()
        End If
    End Sub

    Private Sub btnAceptarBultos_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAceptarBultos.KeyDown
        If e.KeyCode = Keys.Enter Then
            GuardarBultos()
        End If
    End Sub
End Class