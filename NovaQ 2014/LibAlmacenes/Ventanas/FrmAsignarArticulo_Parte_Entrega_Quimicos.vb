Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing

Public Class FrmAsignarArticulo_Parte_Entrega_Quimicos
    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Public AlmacenOrigen As String
    Public TipoMov As String
    Dim clsTransaccionTipoBl As ClsOperaciones.TRANSACTION_TYPE
    Dim clsArticuloBl As ClsOperaciones.PART
    Dim dtDocumentoGuias As DataTable
    Dim dtlote As DataTable
    Public dtdetalleArticulo As DataTable
    Public ValidacionLotes As String = String.Empty
    Public ft_sin_descargo As Boolean = False
    Public fl_close As Boolean = False
    Public Qt_saldo As Double = 0.0
    Public flag_PrecioSinIgv As Boolean = False
    Public ItemLote As String = String.Empty
    Dim fl_Lot As String = String.Empty
    Public dtDetallesBulto As DataTable

    Public Property EsValorizado As Boolean
    Dim FlagLote As Boolean = True
    Public Flag_ModoEdicion As Boolean = False
    Public Identificador As String = String.Empty
    Public TransaccionTipoArticulo As String = String.Empty
    Dim CantidadUpdate As Double

    Dim clsBusquedaBl As ClsBuscar
    Dim dtData As DataTable
    Dim _codigo_interno As Integer
    Dim dt_presentaciones As DataTable
    Dim _UM As String
    Dim _CANTIDAD_PRESENTACION As Double

    Private Sub FrmAsignarArticulo_Parte_Entrega_Quimicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EsValorizado = True Then
            txtmonto.Enabled = True
        End If
        If TipoMov = "S" Then
            btnNuevoLote.Visible = True
            btnNuevoLote.Enabled = True
        End If
        If Flag_ModoEdicion = True Then
            ModoEdicion()
        Else
            GenerarColummnaDataTable()
            BultosGenerarColummnaDataTable()
            GenerarColummnaDataTable_Incripciones_RS()
            _UM = ""
            _CANTIDAD_PRESENTACION = 0
            txt_numero_lote.Text = ""
            dtp_f_vcto.Value = Date.Now
            dtp_f_vcto.Checked = False
            dtp_f_fab.Value = Date.Now
            dtp_f_fab.Checked = False
            txt_numero_op.Focus()
        End If
    End Sub

    Public Sub GenerarColummnaDataTable_Incripciones_RS()
        dt_presentaciones = New DataTable
        dt_presentaciones.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dt_presentaciones.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt_presentaciones.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dt_presentaciones.Columns.Add("UNIDAD", Type.GetType("System.String"))
        dt_presentaciones.Columns.Add("CANTIDAD_PRESENTACION", Type.GetType("System.Double"))
        dt_presentaciones.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dt_presentaciones.Columns.Add("CONVERSION", Type.GetType("System.Double"))
        dt_presentaciones.Columns.Add("OBSERVACION", Type.GetType("System.String"))
        dgv_incripciones_regsanit.DataSource = Nothing
        dgv_incripciones_regsanit.DataSource = dt_presentaciones

        dgv_incripciones_regsanit.Columns("ITEM").HeaderText = "Item"
        dgv_incripciones_regsanit.Columns("CODIGO").HeaderText = "Codigo"
        dgv_incripciones_regsanit.Columns("DESCRIPCION").HeaderText = "Descripción"
        dgv_incripciones_regsanit.Columns("UNIDAD").HeaderText = "Unidad"
        dgv_incripciones_regsanit.Columns("CANTIDAD_PRESENTACION").HeaderText = "Cantidad Presentación"
        dgv_incripciones_regsanit.Columns("CANTIDAD").HeaderText = "Cantidad"
        dgv_incripciones_regsanit.Columns("CONVERSION").HeaderText = "Conversión"
        dgv_incripciones_regsanit.Columns("OBSERVACION").HeaderText = "Observación"

        dgv_incripciones_regsanit.AutoResizeColumns()
        dgv_incripciones_regsanit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If String.IsNullOrEmpty(txtcodigoArticulo.Text) Then
                MsgBox("Debe seleccionar o ingresar el codigo de un Articulo.", MsgBoxStyle.Exclamation)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            Else
                clsArticuloBl = New ClsOperaciones.PART
                dtDocumentoGuias = New DataTable
                dtDocumentoGuias = clsArticuloBl.get_InventarioVerificacionArticuloCodigo(AlmacenOrigen, txtcodigoArticulo.Text, TransaccionTipoArticulo, TipoMov)
                If dtDocumentoGuias.Rows.Count() = 0 Then
                    MsgBox("Error de Codigo de Articulo, verifique.", MsgBoxStyle.Exclamation)
                    txtcodigoArticulo.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            'If FlagLote = True Then
            '    If String.IsNullOrEmpty(cboLotes.Text) Then
            '        MsgBox("Es necesario elegir un Lote, si no existe puede Crearlo.", MsgBoxStyle.Exclamation)
            '        cboLotes.Focus()
            '        estado = False
            '        Exit Try
            '    End If
            'End If

            If String.IsNullOrEmpty(txtcantidad.Text) Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Select()
                Exit Try
            ElseIf Val(txtcantidad.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                estado = False
                txtcantidad.Focus()
                Exit Try
            End If
            If Flag_ModoEdicion Then
                If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
                    If txtnumerobultos.TextLength <> 0 Then
                        'LLenarDatosBultos(False)
                        CantidadUpdate = txtcantidad.Text
                        AjustarTamaño(True)
                        MsgBox("Se modificaron los datos  en relacion a los Bultos.", MsgBoxStyle.Exclamation)
                        estado = False
                        Exit Try
                    End If
                End If
            End If
            If txtnumerobultos.TextLength <> 0 Then
                If Val(txtnumerobultos.Text) <= 0 Then
                    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Exclamation)
                    txtnumerobultos.Focus()
                    estado = False
                    Exit Try
                End If
                'If txtcantidad.Text < Val(txtnumerobultos.Text) Then
                '    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                '    txtnumerobultos.Select()
                '    estado = False
                '    Exit Try
                'End If
                If dtDetallesBulto.Rows.Count() = 0 Then
                    AjustarTamaño(True)
                    GenerarColummnaDataTable()
                    'LLenarDatosBultos(Flag_ModoEdicion)
                    MsgBox("No se agrego Datos de los Bultos.", MsgBoxStyle.Exclamation)
                    estado = False
                    Exit Try
                End If
            Else
                BultosGenerarColummnaDataTable()
            End If
            If TipoMov = "S" Then
                'If fl_Lot = "S" Then
                '    If CDbl(txtStockLote.Text) < txtcantidad.Text Then
                '        MsgBox("La cantidad debe ser menor o igual que el  Stock por Lote.", MsgBoxStyle.Information)
                '        estado = False
                '        txtcantidad.Select()
                '        Exit Try
                '    End If
                '    If txtstockanalisis.Text <> "" And cbonumanalisis.Items.Count <> 0 Then
                '        If CDbl(txtstockanalisis.Text) < txtcantidad.Text Then
                '            MsgBox("La cantidad debe ser menor o igual que el  Stock por Análisis.", MsgBoxStyle.Information)
                '            estado = False
                '            txtcantidad.Select()
                '            Exit Try
                '        End If
                '    End If
                'ElseIf fl_Lot = "N" Then
                '    If CDbl(txtStock.Text) < txtcantidad.Text Then
                '        MsgBox("La cantidad debe ser menor o igual que el  Stock por articulo.", MsgBoxStyle.Information)
                '        estado = False
                '        txtcantidad.Select()
                '        Exit Try
                '    End If
                '    If txtstockanalisis.Text <> "" And cbonumanalisis.Items.Count <> 0 Then
                '        If CDbl(txtstockanalisis.Text) < txtcantidad.Text Then
                '            MsgBox("La cantidad debe ser menor o igual que el  Stock por Análisis.", MsgBoxStyle.Information)
                '            estado = False
                '            txtcantidad.Select()
                '            Exit Try
                '        End If
                '    End If
                'End If
            End If
            If EsValorizado Then
                If String.IsNullOrEmpty(txtmonto.Text) Then
                    MsgBox("Se debe ingresar un Monto.", MsgBoxStyle.Exclamation)
                    estado = False
                    txtmonto.Select()
                    Exit Try
                End If
            End If

            If dt_presentaciones.Rows.Count = 0 Then
                MsgBox("Debe elegir las presentaciones del producto.", MsgBoxStyle.Exclamation)
                estado = False
                Exit Try
            End If

            If CDbl(txt_Saldo.Text) < 0 Then
                MsgBox("La cantidad de las presentaciones es mayor a la cantidad de la producción.", MsgBoxStyle.Exclamation)
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
        If Flag_ModoEdicion = False Then

            For i As Integer = 0 To dt_presentaciones.Rows.Count - 1
                'Agregando los datos a devolver
                Dim row As DataRow = dtdetalleArticulo.NewRow
                row("ITEM") = dt_presentaciones.Rows(i).Item("ITEM").ToString
                row("CODIGO") = dt_presentaciones.Rows(i).Item("CODIGO").ToString 'txtcodigoArticulo.Text
                row("DESCRIPCION") = dt_presentaciones.Rows(i).Item("DESCRIPCION").ToString
                row("UNIDAD") = dt_presentaciones.Rows(i).Item("UNIDAD").ToString
                row("LOTE") = txt_numero_lote.Text
                If dtp_f_vcto.Checked Then
                    row("F_VENCIMIENTO") = dtp_f_vcto.Value.ToString("dd/MM/yyyy")
                Else
                    row("F_VENCIMIENTO") = ""
                End If
                If dtp_f_fab.Checked Then
                    row("F_FABRICACION") = dtp_f_fab.Value.ToString("dd/MM/yyyy")
                Else
                    row("F_FABRICACION") = ""
                End If
                row("CANTIDAD") = dt_presentaciones.Rows(i).Item("CANTIDAD").ToString
                row("NRO_PROTOCOLO") = "" 'IIf(txtnumeroProtocolo.Text = String.Empty, 0, txtnumeroProtocolo.Text)
                row("NRO_BULTOS") = "" 'IIf(txtnumerobultos.Text = String.Empty, "", txtnumerobultos.Text)
                row("MONTO") = _codigo_interno
                If rbparcial.Checked = True Then
                    row("OPT_ENTREGA") = "0"
                ElseIf rbfinal.Checked = True Then
                    row("OPT_ENTREGA") = "1"
                End If
                row("PROCEDENCIA") = "" 'txtprocedencia.Text
                row("PAIS_ORIGEN") = "" 'txtpais_origen.Text
                row("NUMERO_ANALISIS") = txt_numero_op.Text 'cbonumanalisis.Text
                row("OBSERVACIONES") = dt_presentaciones.Rows(i).Item("OBSERVACION").ToString 'txt_observaciones.Text 'cbonumanalisis.Text
                dtdetalleArticulo.Rows.Add(row)
                dtdetalleArticulo.AcceptChanges()
            Next
            
        Else
            'Agregando los datos a devolver
            GenerarColummnaDataTable()
            Dim row As DataRow = dtdetalleArticulo.NewRow
            row("ITEM") = dtdetalleArticulo.Rows.Count() + 1
            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("LOTE") = txt_numero_lote.Text
            If dtp_f_vcto.Checked Then
                row("F_VENCIMIENTO") = dtp_f_vcto.Value.ToString("dd/MM/yyyy")
            Else
                row("F_VENCIMIENTO") = ""
            End If
            If dtp_f_fab.Checked Then
                row("F_FABRICACION") = dtp_f_fab.Value.ToString("dd/MM/yyyy")
            Else
                row("F_FABRICACION") = ""
            End If
            row("CANTIDAD") = txtcantidad.Text
            row("NRO_PROTOCOLO") = IIf(txtnumeroProtocolo.Text = String.Empty, 0, txtnumeroProtocolo.Text)
            row("NRO_BULTOS") = IIf(txtnumerobultos.Text = String.Empty, "", txtnumerobultos.Text)
            row("MONTO") = _codigo_interno
            If rbparcial.Checked = True Then
                row("OPT_ENTREGA") = "0"
            ElseIf rbfinal.Checked = True Then
                row("OPT_ENTREGA") = "1"
            End If
            row("PROCEDENCIA") = txtprocedencia.Text
            row("PAIS_ORIGEN") = txtpais_origen.Text
            row("NUMERO_ANALISIS") = txt_numero_op.Text 'cbonumanalisis.Text
            row("OBSERVACIONES") = "" 'txt_observaciones.Text 'cbonumanalisis.Text
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
            If TipoMov = "S" Or TipoMov = "I" Then
                MostrandoNumerosAnalisis(txtcodigoArticulo.Text)
            End If
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs)
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
            txtnumeroProtocolo.Focus()
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


    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(952, 523)
            Me.GroupBox2.Enabled = False
        Else
            Size = New System.Drawing.Size(594, 523)
            Me.GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub AgregandoNuevosDatosBultos(TablaOrigen As DataGridView, ByVal TablaDestino As DataTable, ByVal indice As String)
        Try
            For i As Integer = 0 To TablaOrigen.Rows.Count() - 1
                Dim row As DataRow = TablaDestino.NewRow
                row("WAREHOUSE_ID") = ""
                row("DOCUMENT_ID") = ""
                row("NUMBER_DOCUMENT") = ""
                row("DATE_DOCUMENT") = Date.Now()
                row("PART_ID") = txtcodigoArticulo.Text
                If cboLotes.Text = String.Empty Then
                    row("LOTE") = ""
                Else
                    row("LOTE") = cboLotes.Text 'cboLotes.SelectedValue.ToString
                End If
                row("ITEM") = i + 1
                row("QTY") = txtcantidad.Text
                row("QTY_BULTOS") = CDbl(TablaOrigen.Item(2, i).Value)
                row("IDENTIFICADOR") = indice
                dtDetallesBulto.Rows.Add(row)
                dtDetallesBulto.AcceptChanges()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub
    Private Sub txtnumeroProtocolo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumeroProtocolo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmonto.Focus()
        End If
    End Sub


    Private Sub txtnumerobultos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumerobultos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If txtcantidad.Text = String.Empty Then
            '    txtcantidad.Focus()
            '    Exit Sub
            'End If
            'If txtnumerobultos.TextLength <> 0 Then
            'If Val(txtnumerobultos.Text) <= 0 Then
            '    MsgBox("El numero de Bultos debe ser mayor a Cero", MsgBoxStyle.Information)
            '    txtnumerobultos.Focus()
            '    Exit Sub
            'End If
            'If txtnumerobultos.Text = String.Empty Then
            '    txtnumerobultos.Focus()
            '    Exit Sub
            'End If
            'If txtcantidad.Text < Val(txtnumerobultos.Text) Then
            '    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            'If Flag_ModoEdicion Then
            '    If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
            '        LLenarDatosBultos(False)
            '        CantidadUpdate = txtcantidad.Text
            '        AjustarTamaño(True)
            '    ElseIf txtnumerobultos.TextLength <> 0 Then
            '        LLenarDatosBultos(False)
            '        AjustarTamaño(True)
            '    End If
            'Else
            '    AjustarTamaño(True)
            '    'BultosGenerarColummnaDataTable()
            '    LLenarDatosBultos(Flag_ModoEdicion)
            'End If
            'Else
            'btnAceptar_Click(sender, e)
            txtprocedencia.Focus()
            'End If
        End If
    End Sub



    Private Sub txtnumeroProtocolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroProtocolo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtprocedencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprocedencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            'btnAceptar_Click(sender, e)
            txtpais_origen.Focus()
        End If
    End Sub

    Private Sub txtpais_origen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpais_origen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcantidad.Text = String.Empty Then
                txtcantidad.Focus()
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
                'If txtcantidad.Text < Val(txtnumerobultos.Text) Then
                '    MsgBox("El numero de Bultos debe ser menor o igual que la Cantidad ingresada.", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
                If Flag_ModoEdicion Then
                    If Val(CantidadUpdate) <> Val(txtcantidad.Text) Then
                        'LLenarDatosBultos(False)
                        CantidadUpdate = txtcantidad.Text
                        AjustarTamaño(True)
                    ElseIf txtnumerobultos.TextLength <> 0 Then
                        'LLenarDatosBultos(False)
                        AjustarTamaño(True)
                    End If
                Else
                    AjustarTamaño(True)
                    'BultosGenerarColummnaDataTable()
                    'LLenarDatosBultos(Flag_ModoEdicion)
                End If
            Else
                btnAceptar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        fl_close = True
        Me.Close()
    End Sub


    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtmonto_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtmonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub cbonumanalisis_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbonumanalisis.SelectedValueChanged
        If cbonumanalisis.DataSource Is Nothing Then Exit Sub
        If cbonumanalisis.Items.Count() <> 0 Then
            txtstockanalisis.Text = cbonumanalisis.SelectedValue.ToString
        End If
    End Sub


    Public Sub BultosGenerarColummnaDataTable()
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
        dtDetallesBulto.Columns.Add("QTY_BULTOS", Type.GetType("System.String"))
        dtDetallesBulto.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"))
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticulo.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("NRO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NRO_BULTOS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("MONTO", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("OPT_ENTREGA", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("PROCEDENCIA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PAIS_ORIGEN", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMERO_ANALISIS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("OBSERVACIONES", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("F_VENCIMIENTO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("F_FABRICACION", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub MostrarFechaVencimiento(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        cadena = "SELECT CADUCATE_DATE FROM lot  WHERE  PART_ID ='" & txtcodigoArticulo.Text & "' and  LOT_ID='" & codigooLote & "' and WHO_ID='" & AlmacenOrigen & "' "
        Dim fecha As String = String.Empty
        dtTableFecha = LibData.Run_Query_DataTable(cadena)
        LibData.Dispose()
        If dtTableFecha.Rows.Count() <> 0 Then
            fecha = dtTableFecha.Rows(0).Item(0).ToString()
            dtpFechaVencimiento.Text = Format(fecha, "Short date")
        End If
    End Sub

    Private Sub MostrarNumerosAnalisis(ByVal codigooLote As String)
        Dim cadena As String = String.Empty
        Dim dtTableFecha As New DataTable
        Dim LibData As New LibConexion.ClsData
        cadena = "SELECT QTY_ON_HAND AS [CANTIDAD], NUM_ANALISIS AS [NUM_ANALISIS]  FROM NUMBER_ANALISIS  WHERE  PART_ID ='" & txtcodigoArticulo.Text & "' and  LOT_ID='" & codigooLote & "' and WHO_ID='" & AlmacenOrigen & "' "
        Dim fecha As String = String.Empty
        dtTableFecha = LibData.Run_Query_DataTable(cadena)
        LibData.Dispose()
        If dtTableFecha.Rows.Count() <> 0 Then
            cbonumanalisis.DataSource = dtTableFecha.Rows(0).Item(0).ToString()

        End If
    End Sub

    Private Sub MostrandoNumerosAnalisis(ByVal codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            '++Informacion de Lotes
            dtlote = New DataTable
            dtlote = clsArticuloBl.get_InventarioArticuloNumeroAnalisis(AlmacenOrigen, codigoArticulo, cboLotes.Text, TipoMov)
            If dtlote.Rows.Count() <> 0 Then
                cbonumanalisis.DataSource = dtlote
                cbonumanalisis.DisplayMember = "NUM_ANALISIS"
                cbonumanalisis.ValueMember = "CANTIDAD"
                If cbonumanalisis.Items.Count() <> 0 Then
                    cbonumanalisis.SelectedIndex = 0
                    'If ItemLote <> String.Empty Then
                    '    cboLotes.Text = ItemLote.ToString
                    'End If
                    'txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                    txtstockanalisis.Text = Format(cbonumanalisis.SelectedValue, "##,##0.000000")
                    'txtStockLote.Text = cboLotes.SelectedValue
                    cbonumanalisis.Enabled = True
                End If
            Else
                cbonumanalisis.Enabled = False
                txtstockanalisis.Enabled = False
                txtstockanalisis.Text = String.Empty
                cbonumanalisis.DataSource = Nothing
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
            dtlote = clsArticuloBl.get_InventarioArticuloLote(AlmacenOrigen, codigoArticulo, ValidacionLotes, TipoMov)
            If dtlote.Rows.Count() <> 0 Then
                cboLotes.DataSource = dtlote
                cboLotes.DisplayMember = "LOTE"
                cboLotes.ValueMember = "CANTIDAD"

                If cboLotes.Items.Count() <> 0 Then
                    cboLotes.SelectedIndex = 0
                    If ItemLote <> String.Empty Then
                        cboLotes.Text = ItemLote.ToString
                    End If
                    'txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.0.0")
                    txtStockLote.Text = Format(cboLotes.SelectedValue, "##,##0.000000")
                    'txtStockLote.Text = cboLotes.SelectedValue
                    MostrarFechaVencimiento(cboLotes.Text)
                    cboLotes.Enabled = True
                    txtcantidad.Enabled = True
                    btnAceptar.Visible = True
                End If
            Else
                MsgBox("No hay lotes  para este Articulo o  ya se agregaron con Anterioridad, Verifique.", MsgBoxStyle.Information)
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

    Private Sub Mostrando_Producto_Insumos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "MANUFACTURA_SP_S_ARTICULO_QUIMICOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Productos a producir"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_prod_presentacion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_prod_presentacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _UM = frm.Data_Matriz.Rows(0).Item(2).ToString
                _CANTIDAD_PRESENTACION = frm.Data_Matriz.Rows(0).Item(3).ToString
                txt_cantidad_presentacion.Select()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoArticulos(ByVal TipoMovimiento As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            If TipoMovimiento = "I" Then
                sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_I"
            ElseIf TipoMovimiento = "S" Then
                sql = "ALM_SP_S_WAREHOUSE_PRODUCTO_S"
            End If
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm._Flag_Inventario = True
            frm.Filtros1 = AlmacenOrigen
            frm.Filtros2 = TransaccionTipoArticulo
            frm._Flag_Ajuste_Automatico = True
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                Stock = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtStock.Text = Format(Stock, "##,##0.0.0.0")
                If TipoMovimiento = "I" Then
                    fl_Lot = String.Empty
                    fl_Lot = frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    cboLotes.Select()
                ElseIf TipoMovimiento = "S" Then
                    fl_Lot = String.Empty
                    fl_Lot = frm.Data_Matriz.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        MostrandoLotes(txtcodigoArticulo.Text)
                        MostrandoNumerosAnalisis(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                        MostrandoNumerosAnalisis(txtcodigoArticulo.Text)
                    End If
                    'btnNuevoLote.Enabled = False
                    'MostrandoLotes(txtcodigoArticulo.Text)
                    'cboLotes.Select()
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LimpiarLotes()
        cboLotes.DataSource = Nothing
        txtStockLote.Text = ""
        dtpFechaVencimiento.Text = Date.Now
        GroupBox4.Enabled = False
        FlagLote = False
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            clsArticuloBl = New ClsOperaciones.PART
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsArticuloBl.get_InventarioVerificacionArticuloCodigo(AlmacenOrigen, _codigoArticulo, TransaccionTipoArticulo, TipoMov)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                codArticulo = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNID_MED").ToString
                txtStock.Text = Format(dtDocumentoGuias.Rows(0).Item("STOCK"), "##,##0.0.0.0")
                If TipoMov = "I" Then
                    fl_Lot = String.Empty
                    fl_Lot = dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        'MostrandoLotes(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                    End If
                    cboLotes.Select()
                    cbonumanalisis.Enabled = False
                    txtstockanalisis.Enabled = False
                    txtstockanalisis.Text = String.Empty
                    cbonumanalisis.DataSource = Nothing
                ElseIf TipoMov = "S" Then
                    fl_Lot = String.Empty
                    fl_Lot = dtDocumentoGuias.Rows(0).Item("IS_LOT").ToString
                    If fl_Lot = "S" Then
                        GroupBox4.Enabled = True
                        btnNuevoLote.Enabled = True
                        'MostrandoLotes(txtcodigoArticulo.Text)
                        'MostrandoNumerosAnalisis(txtcodigoArticulo.Text)
                    ElseIf fl_Lot = "N" Then
                        btnNuevoLote.Enabled = False
                        LimpiarLotes()
                        MostrandoNumerosAnalisis(txtcodigoArticulo.Text)
                    End If
                    cboLotes.Select()
                    'MostrandoLotes(txtcodigoArticulo.Text)
                    'cboLotes.Select()
                End If
            Else
                MsgBox("No hay informacion con el Codigo Especificado", MsgBoxStyle.Information)
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

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        'If e.KeyCode = Keys.F1 Then MostrandoArticulos(TipoMov)
        'If e.KeyCode = Keys.Enter Then
        '    If txtcodigoArticulo.Text = String.Empty Then
        '        MostrandoArticulos(TipoMov)
        '    Else
        '        Dim codigoArticulo As String = String.Empty
        '        codigoArticulo = txtcodigoArticulo.Text.Trim
        '        AgregarArticuloManual(codigoArticulo)
        '    End If
        'End If
    End Sub

    Private Sub ModoEdicion()
        Try
            'Obteniendo los datos para Mostrarlos
            If dtdetalleArticulo.Rows.Count() <> 0 Then
                AgregarArticuloManual(dtdetalleArticulo.Rows(0).Item("CODIGO").ToString)
                CantidadUpdate = 0.0
                CantidadUpdate = dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                txtcantidad.Text = dtdetalleArticulo.Rows(0).Item("CANTIDAD").ToString
                cboLotes.Text = dtdetalleArticulo.Rows(0).Item("LOTE").ToString
                txtnumeroProtocolo.Text = dtdetalleArticulo.Rows(0).Item("NRO_PROTOCOLO").ToString
                txtmonto.Text = dtdetalleArticulo.Rows(0).Item("MONTO").ToString
                _codigo_interno = dtdetalleArticulo.Rows(0).Item("MONTO").ToString
                txtnumerobultos.Text = dtdetalleArticulo.Rows(0).Item("NRO_BULTOS").ToString
                txt_numero_op.Text = dtdetalleArticulo.Rows(0).Item("NUMERO_ANALISIS").ToString
                'txt_observaciones.Text = dtdetalleArticulo.Rows(0).Item("OBSERVACIONES").ToString
                If dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA").ToString = "0" Then
                    rbparcial.Checked = True
                ElseIf dtdetalleArticulo.Rows(0).Item("OPT_ENTREGA").ToString = "1" Then
                    rbfinal.Checked = True
                End If
                If String.IsNullOrEmpty(dtdetalleArticulo.Rows(0).Item("NRO_BULTOS").ToString) Then
                    txtnumerobultos.Text = ""
                Else
                    'LLenarDatosBultos(Flag_ModoEdicion)
                    AjustarTamaño(True)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        'MostrandoArticulos(TipoMov)
    End Sub

    Private Sub TextBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_numero_op.MouseDoubleClick
        Mostrando_Ops(TipoMov)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_op.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Ops(TipoMov)
        If e.KeyCode = Keys.Enter Then
            If txt_numero_op.Text = String.Empty Then
                Mostrando_Ops(TipoMov)
            Else
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
                txt_cod_prod_presentacion.Focus()
            End If
        End If
    End Sub

    Private Sub Mostrando_Ops(ByVal TipoMovimiento As String)
        Try
            Dim frm As New frmBuscar_Parte_Entrega
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            _codigo_interno = 0
            sql = "ALM_SP_S_PRODUCCION_OP_PRODUCTOS_I"
            frm.CadenaConsulta = sql
            frm._Flag_Ajuste_Automatico = True
            frm.Titulo = "Seleccion de O.P."
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_numero_op.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txtcantidad.Text = frm.Data_Matriz.Rows(0).Item("CANTIDAD").ToString

                _codigo_interno = frm.Data_Matriz.Rows(0).Item("CODIGO_INTERNO").ToString
                Dim codigoArticulo As String = String.Empty
                codigoArticulo = txtcodigoArticulo.Text.Trim
                AgregarArticuloManual(codigoArticulo)
                txtcantidad.Focus()
            Else
                txt_numero_op.Text = ""
                txtcodigoArticulo.Text = ""
                txtdescripcionArticulo.Text = ""
                txtunidadMedida.Text = ""
                _codigo_interno = 0
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_observaciones_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_cantidad_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_presentacion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_prod_presentacion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_prod_presentacion.MouseDoubleClick
        Mostrando_Producto_Insumos()
    End Sub

    Private Sub txt_cod_prod_presentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_prod_presentacion.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_cod_prod_presentacion.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_prod_presentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prod_presentacion.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Producto_Insumos() 'MostrandoArticulos(TipoMov)
        If e.KeyCode = Keys.Enter Then
            If txt_cod_prod_presentacion.Text = String.Empty Then
                Mostrando_Producto_Insumos()
            Else
                txt_cantidad_presentacion.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cantidad_presentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_presentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs_presentacion.Focus()
        End If
    End Sub

    Private Sub txt_obs_presentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obs_presentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso() = False Then Exit Sub
            If dt_presentaciones.Rows.Count > 0 Then
                For Each rows As DataRow In dt_presentaciones.Select("CODIGO='" & txt_cod_prod_presentacion.Text.Trim & "' ")
                    MsgBox("La presentación elegida ya se encuentra registrado.", MsgBoxStyle.Information, "Aviso")
                    Exit Try
                Next
            End If
            Dim row As DataRow = dt_presentaciones.NewRow
            row("ITEM") = dt_presentaciones.Rows.Count() + 1
            row("CODIGO") = txt_cod_prod_presentacion.Text.Trim
            row("DESCRIPCION") = txt_des_prod_presentacion.Text
            row("UNIDAD") = _UM
            row("CANTIDAD_PRESENTACION") = _CANTIDAD_PRESENTACION
            row("CANTIDAD") = CDbl(txt_cantidad_presentacion.Text)
            row("CONVERSION") = CDbl(row("CANTIDAD_PRESENTACION")) * CDbl(row("CANTIDAD"))
            row("OBSERVACION") = txt_obs_presentacion.Text
            dt_presentaciones.Rows.Add(row)
            dt_presentaciones.AcceptChanges()
            txt_cod_prod_presentacion.Text = String.Empty
            txt_des_prod_presentacion.Text = String.Empty
            txt_cantidad_presentacion.Text = String.Empty
            txt_obs_presentacion.Text = String.Empty
            _UM = String.Empty
            _CANTIDAD_PRESENTACION = 0
            CalcularTotales()
            txt_cod_prod_presentacion.Focus()
            dgv_incripciones_regsanit.DataSource = dt_presentaciones
            'dgvDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CalcularTotales()
        Try
            If dt_presentaciones.Rows.Count() <> 0 Then
                txt_total_conversion.Text = Format(dt_presentaciones.Compute("sum (CONVERSION) ", ""), "0.00")
                txt_Saldo.Text = Format(CDbl(txtcantidad.Text) - CDbl(dt_presentaciones.Compute("sum (CONVERSION) ", "")), "0.00")
            Else
                txt_total_conversion.Text = "0.00"
                txt_Saldo.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Validacion_Ingreso() As Boolean

        If txt_cod_prod_presentacion.Text.Trim = "" Then
            MsgBox("Debe elegir una presentación.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        If txt_cantidad_presentacion.Text.Trim = "" Then
            MsgBox("Debe indicar una cantidad.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgv_incripciones_regsanit.RowCount = 0 Then Exit Sub
        If dgv_incripciones_regsanit.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo_Incripciones_Reg_Sanit()
        End If
    End Sub

    Private Sub EliminandoArticulo_Incripciones_Reg_Sanit()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_incripciones_regsanit.Item(0, dgv_incripciones_regsanit.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dt_presentaciones.Select("ITEM=" & Codigo)
                item.Delete()
                dt_presentaciones.AcceptChanges()
            Next
            RehacerSecuencia()
            CalcularTotales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dt_presentaciones.Rows
            i += 1
            dt_presentaciones.BeginInit()
            items("ITEM") = i
            dt_presentaciones.EndInit()
            dt_presentaciones.AcceptChanges()
        Next
    End Sub

    Private Sub dtp_f_fab_ValueChanged(sender As Object, e As EventArgs) Handles dtp_f_fab.ValueChanged
        If dtp_f_fab.Checked = True Then
            txt_numero_lote.Text = Format(dtp_f_fab.Value.Day, "00") & Format(dtp_f_fab.Value.Month, "00") & Strings.Right(dtp_f_fab.Value.Year.ToString, 2)
        Else
            txt_numero_lote.Text = ""
        End If
    End Sub
End Class