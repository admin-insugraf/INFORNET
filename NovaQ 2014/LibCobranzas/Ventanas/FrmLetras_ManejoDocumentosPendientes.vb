Imports System.Windows.Forms

Public Class FrmLetras_ManejoDocumentosPendientes
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtCabecera As DataTable
    Dim dtDetalle As DataTable
    Dim dtDatosAdicionales As DataTable
    Dim Flag_Modo_Edicion As Boolean = False

    Dim EntidadCliente As ClsEntidades.CUSTOMER_BALANCE

    Private Sub MostrarDocumentosPendiente()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtCabecera = New DataTable
            dtv = New DataView
            dtCabecera = clsLetrasBl.MostrandoClientesManejoDocumento()
            If dtCabecera.Rows.Count() <> 0 Then
                dtv = dtCabecera.DefaultView
                dgvCabecera.DataSource = dtv
                dgvCabecera.Columns(0).Width = 80
                dgvCabecera.Columns(0).HeaderText = "Codigo"
                dgvCabecera.Columns(1).Width = 450
                dgvCabecera.Columns(1).HeaderText = "Cliente"
                dgvCabecera.Columns(2).Width = 100
                dgvCabecera.Columns(2).HeaderText = "Ruc"
                dgvCabecera.Columns(3).Width = 550
                dgvCabecera.Columns(3).HeaderText = "Direccion"
                'dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name '& "+" & dgvCabecera.Columns(3).Name
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarDocumentosPendienteDetalles(ByVal _CodigoCliente As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalle = New DataTable
            dtDetalle = clsLetrasBl.MostrandoClientesManejoDocumentoDetalles(_CodigoCliente)
            If dtDetalle.Rows.Count() <> 0 Then
                dgvDetalles.DataSource = Nothing
                dgvDetalles.DataSource = dtDetalle
                dgvDetalles.Columns(7).DefaultCellStyle.Format = "##,##0.00"
                dgvDetalles.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDetalles.Columns(6).DefaultCellStyle.Format = "##,##0.00"
                dgvDetalles.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'dgvDetalles.Columns(7).Visible = False
                dgvDetalles.Columns(8).Visible = False
                dgvDetalles.Columns(9).Visible = False
                dgvDetalles.Columns(11).Visible = False
                dgvDetalles.Columns(12).Visible = False
                'dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                dgvDetalles.DataSource = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'Dim wbusqueda As String = UCase(txtFiltro.Text)
        'Dim myCurrencyManager As CurrencyManager
        'myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        'Dim INTnewpos As Integer
        'dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        'myCurrencyManager.Position = INTnewpos
        'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        If STRorden = "" Then

        ElseIf txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(2).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns(3).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub Ayuda_Vendedor(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Cobrador"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcodigoVendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    txtdescripcionVendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            Else
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                dtDatosAdicionales = New DataTable("VendedorManual")
                dtDatosAdicionales = clsLetrasBl.Get_ManualVendedor(_CodigoVendedor)
                If dtDatosAdicionales.Rows.Count() <> 0 Then
                    txtcodigoVendedor.Text = dtDatosAdicionales.Rows(0).Item(0)
                    txtdescripcionVendedor.Text = dtDatosAdicionales.Rows(0).Item(1)
                Else
                    MsgBox("No hay informacion con el codigo de Vendedor especificado.", MsgBoxStyle.Critical)
                    txtcodigoVendedor.Text = String.Empty
                    txtdescripcionVendedor.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_TipoDocumento()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_TIPO_DOCUMENTOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cobrador"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoTipoDoc.Text = frm.Data_Matriz.Rows(0).Item(0)
                If Flag_Modo_Edicion = False Then
                    If txtcodigoTipoDoc.Text = "LT" Then
                        txtserie.Text = ""
                        txtserie.Enabled = False
                        txtnumeroDoc.MaxLength = 10
                        txtnumeroDoc.Text = String.Empty
                    ElseIf txtcodigoTipoDoc.Text = "AN" Then
                        txtserie.Text = "001"
                        txtserie.ReadOnly = True
                        txtnumeroDoc.MaxLength = 10
                        txtnumeroDoc.ReadOnly = True
                        clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                        dtDatosAdicionales = New DataTable("DocumentosAnticipos")
                        dtDatosAdicionales = clsLetrasBl.Get_DocumentoAnticipos(txtcodigoCliente.Text)
                        If dtDatosAdicionales.Rows.Count > 0 Then
                            txtnumeroDoc.Text = CInt(dtDatosAdicionales.Rows(0).Item("CORRELATIVO").ToString) + 1
                        End If
                    Else
                        txtnumeroDoc.ReadOnly = False
                        txtnumeroDoc.ReadOnly = False
                        txtserie.Text = String.Empty
                        txtnumeroDoc.Text = String.Empty
                        txtserie.Enabled = True
                        txtnumeroDoc.MaxLength = 7
                    End If
                End If
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmLetras_ManejoDocumentosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If LibComunVar.ClsVarComun.MANEJO_CARTERA = "SI" Then
            btnNuevo.Visible = True
            btnModificar.Visible = True
            btnEliminar.Visible = True
        Else
            btnNuevo.Visible = False
            btnModificar.Visible = False
            btnEliminar.Visible = False
        End If
        
        MostrarDocumentosPendiente()
        Cargar_Moneda()
        txtFiltro.Select()
    End Sub

    Private Sub dgvCabecera_SelectionChanged(sender As Object, e As EventArgs)
        'If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        'If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
        'Dim CodigoCliente As String = String.Empty
        'CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        'MostrarDocumentosPendienteDetalles(CodigoCliente)
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Blank()
        txtcodigoTipoDoc.Text = String.Empty
        txtnumeroDoc.Text = String.Empty
        dtpEmision.Value = Date.Now()
        dtpVencimiento.Value = Date.Now
        txtcodigoVendedor.Text = String.Empty
        txtdescripcionVendedor.Text = String.Empty
        cboMoneda.SelectedIndex = 0
        txttipoCambio.Text = String.Empty
        txtImporte.Text = "0.00"
        txtSaldo.Text = "0.00"
        cboDatosContables.SelectedIndex = 0
        txtserie.Text = "001"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
            If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
            Dim CodigoCliente As String = String.Empty
            Dim DescripcionCliente As String = String.Empty
            CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            DescripcionCliente = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            pnlModificaciones.Visible = True
            txtMensaje.Text = "NUEVO DOCUMENTO"
            Blank()
            Flag_Modo_Edicion = False
            gbDatos.Enabled = False
            txtnumeroDoc.Enabled = True
            txtcodigoCliente.Text = CodigoCliente
            txtdescripcionCliente.Text = DescripcionCliente
            txtcodigoTipoDoc.Enabled = True
            txtserie.Enabled = True
            txttipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
            txtcodigoTipoDoc.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
            If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
            Dim CodigoCliente As String = String.Empty
            Dim TipoDoc As String = String.Empty
            Dim NumeroDoc As String = String.Empty
            Dim SERIE_DOC As String = String.Empty
            Dim NUMERO_DOC As String = String.Empty
            Dim DescripcionCliente As String = String.Empty
            CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            DescripcionCliente = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            TipoDoc = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            NumeroDoc = dgvDetalles.Item(1, dgvDetalles.CurrentRow.Index).Value
            SERIE_DOC = dgvDetalles.Item(11, dgvDetalles.CurrentRow.Index).Value
            NUMERO_DOC = dgvDetalles.Item(12, dgvDetalles.CurrentRow.Index).Value
            pnlModificaciones.Visible = True
            txtMensaje.Text = "MODIFICACION DEL DOCUMENTO"
            Blank()
            gbDatos.Enabled = False
            Flag_Modo_Edicion = True
            txtcodigoCliente.Text = CodigoCliente
            txtdescripcionCliente.Text = DescripcionCliente
            txtcodigoTipoDoc.Enabled = False
            txtserie.Enabled = False
            txtnumeroDoc.Enabled = False
            txtcodigoTipoDoc.Text = TipoDoc
            txtserie.Text = SERIE_DOC
            txtnumeroDoc.Text = NUMERO_DOC
            

            dtpVencimiento.Value = IIf(String.IsNullOrEmpty(dgvDetalles.Item(3, dgvDetalles.CurrentRow.Index).Value.ToString), Date.Now, dgvDetalles.Item(3, dgvDetalles.CurrentRow.Index).Value)
            If String.IsNullOrEmpty(dgvDetalles.Item(5, dgvDetalles.CurrentRow.Index).Value.ToString) Then
                cboMoneda.SelectedIndex = 0
            Else
                cboMoneda.SelectedValue = dgvDetalles.Item(5, dgvDetalles.CurrentRow.Index).Value
            End If
            txtImporte.Text = IIf(String.IsNullOrEmpty(dgvDetalles.Item(6, dgvDetalles.CurrentRow.Index).Value.ToString), 0, dgvDetalles.Item(6, dgvDetalles.CurrentRow.Index).Value)
            txtSaldo.Text = IIf(String.IsNullOrEmpty(dgvDetalles.Item(7, dgvDetalles.CurrentRow.Index).Value.ToString), 0, dgvDetalles.Item(7, dgvDetalles.CurrentRow.Index).Value)
            If String.IsNullOrEmpty(dgvDetalles.Item(8, dgvDetalles.CurrentRow.Index).Value.ToString) Then
                txttipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
            Else
                txttipoCambio.Text = dgvDetalles.Item(8, dgvDetalles.CurrentRow.Index).Value
            End If
            'Verificacion
            If String.IsNullOrEmpty(dgvDetalles.Item(9, dgvDetalles.CurrentRow.Index).Value.ToString) Then
                txtcodigoVendedor.Text = String.Empty
                txtdescripcionVendedor.Text = String.Empty
            Else
                Ayuda_Vendedor(dgvDetalles.Item(9, dgvDetalles.CurrentRow.Index).Value)
            End If

            If Val(txtImporte.Text) < 0 Then
                cboDatosContables.SelectedIndex = 1
            Else
                cboDatosContables.SelectedIndex = 0
            End If
            dtpEmision.Value = IIf(String.IsNullOrEmpty(dgvDetalles.Item(2, dgvDetalles.CurrentRow.Index).Value.ToString), Date.Now, dgvDetalles.Item(2, dgvDetalles.CurrentRow.Index).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarActualizar(ByVal Estado As Boolean)
        If Estado = False Then
            EntidadCliente = New ClsEntidades.CUSTOMER_BALANCE
            With EntidadCliente
                .CUSTOMER_ID = txtcodigoCliente.Text
                .DOCUMENT_ID = txtcodigoTipoDoc.Text
                If txtcodigoTipoDoc.Text <> "LT" Then
                    txtnumeroDoc.Text = String.Format("{0:0000000}", CInt(txtnumeroDoc.Text.Trim))
                    .NUMBER_DOC = txtserie.Text.Trim & txtnumeroDoc.Text
                Else
                    'txtnumeroDoc.Text = txtnumeroDoc.Text.Trim 'String.Format("{0:0000000000}", CInt(txtnumeroDoc.Text.Trim))
                    .NUMBER_DOC = txtnumeroDoc.Text
                End If
                .DOC_DATE = dtpEmision.Value.ToString("dd/MMMM/yyyy")
                .CADUCATE_DATE = dtpVencimiento.Value.ToString("dd/MMMM/yyyy")
                .DOCUMENT_REF = ""
                .NUMBER_REF = ""
                .SALES_ID = txtcodigoVendedor.Text
                .AMOUNT = IIf(cboDatosContables.SelectedIndex = 0, txtImporte.Text, txtImporte.Text * -1)
                .AMOUNT_BALANCE = IIf(cboDatosContables.SelectedIndex = 0, txtSaldo.Text, txtSaldo.Text * -1)
                .CURRENCY_ID = cboMoneda.SelectedValue.ToString
                .SELL_RATE = CDbl(txttipoCambio.Text) ' IIf(String.IsNullOrEmpty(txttipoCambio.Text), LibComunVar.ClsVarComun.TCVenta, txttipoCambio.Text)
                .IS_DR_CR = IIf(cboDatosContables.SelectedIndex = 0, "D", "H")
                .STATUS = "V"
                .CREATE_DATE = Date.Now.ToShortDateString
                .LAST_MODIFIED = Date.Now.ToShortDateString
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .ACCOUNT = ""
                .AMOUNT_COMM = 0
                .TYPE_REC = 0
                .REFERENCE_DATE = Date.Now.ToShortDateString
                .IS_CHECK_DIF = 0
                .AMOUNT_BALANCE_INI = txtImporte.Text
                .TERMS = 0
                .PLACE_SALES = ""
                .BANK_ID = 0
                .BANK_DESCRIPTION = 0
                .AMOUNT_PER = 0
                .PERCENT_PER = 0
                .ACCOUNT_PER = 0
                .CUST_AUTO = 0
                .SERIE_AUX = txtserie.Text
                .NUM_DOC_AUX = txtnumeroDoc.Text
                .PERCENT_DETRAC = 0
                .AMOUNT_DETRAC = 0
                .SALDO = IIf(cboDatosContables.SelectedIndex = 0, txtSaldo.Text, txtSaldo.Text * -1)
            End With
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            If clsLetrasBl.GuardandoCarteraClientes(EntidadCliente) = True Then
                MsgBox("Documento Guardado Exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error en la generacion del Documento.", MsgBoxStyle.Critical)
            End If
        Else
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            If clsLetrasBl.ActualizandoCarteraClientes(txtcodigoCliente.Text, txtcodigoTipoDoc.Text, txtserie.Text + txtnumeroDoc.Text, dtpEmision.Value.ToString("dd/MM/yyyy"), dtpVencimiento.Value.ToString("dd/MM/yy"), _
                                                        txtcodigoVendedor.Text, cboMoneda.SelectedValue.ToString, IIf(String.IsNullOrEmpty(txttipoCambio.Text), LibComunVar.ClsVarComun.TCVenta, txttipoCambio.Text), _
                                                        LibComunVar.ClsVarComun.USUARIO, IIf(cboDatosContables.SelectedIndex = 0, txtImporte.Text, txtImporte.Text * -1), IIf(cboDatosContables.SelectedIndex = 0, txtSaldo.Text, txtSaldo.Text * -1)) = True Then
                MsgBox("Documento Modificado Exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error en la Modificacion del Documento.", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Function validaciones() As Boolean
        Try
            If txtcodigoCliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente", MsgBoxStyle.Information)
                txtcodigoCliente.Focus()
                Return False
            ElseIf txtcodigoTipoDoc.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo de Documento", MsgBoxStyle.Information)
                txtcodigoTipoDoc.Focus()
                Return False
            ElseIf txtserie.Text = String.Empty And txtcodigoTipoDoc.Text <> "LT" Then
                MsgBox("Debe ingresar una serie", MsgBoxStyle.Information)
                txtserie.Focus()
                Return False
            End If
            If txtnumeroDoc.Text = String.Empty Then
                MsgBox("Debe ingresar un numero de documento", MsgBoxStyle.Information)
                txtnumeroDoc.Focus()
                Return False
            Else
                If Flag_Modo_Edicion = False Then
                    clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                    dtDatosAdicionales = New DataTable("VerificarNumeracion")
                    dtDatosAdicionales = clsLetrasBl.VerificacionNumeracion(txtcodigoCliente.Text, txtcodigoTipoDoc.Text, txtnumeroDoc.Text)
                    If dtDatosAdicionales.Rows.Count() <> 0 Then
                        MsgBox("El Nro.Documento ingresado ya existe, verifique", MsgBoxStyle.Information)
                        txtnumeroDoc.Focus()
                        Return False
                    End If
                End If
            End If
            If CDate(dtpEmision.Value.ToString("dd/MM/yyyy")) > CDate(dtpVencimiento.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpEmision.Focus()
                Return False
            End If
            If txttipoCambio.Text = String.Empty Or CDbl(txttipoCambio.Text) = 0 Then
                MsgBox("Debe ingresar el tipo de cambio de la fecha elegida.", MsgBoxStyle.Information)
                txttipoCambio.Focus()
                Return False
            End If
            If txtcodigoVendedor.Text = String.Empty Then
                MsgBox("Debe seleccionar un Vendedor", MsgBoxStyle.Information)
                txtcodigoVendedor.Focus()
                Return False
            End If
            If txtImporte.Text = String.Empty Then
                MsgBox("Debe ingresar un Importe", MsgBoxStyle.Information)
                txtImporte.Focus()
                Return False
            Else
                If Val(txtImporte.Text) = 0 Then
                    MsgBox("El Importe debe ser mayor a Cero", MsgBoxStyle.Information)
                    txtImporte.Focus()
                    Return False
                End If
            End If
            If txtSaldo.Text = String.Empty Then
                MsgBox("Debe ingresar un Saldo", MsgBoxStyle.Information)
                txtSaldo.Focus()
                Return False
            Else
                'If Val(txtSaldo.Text) = 0 Then
                '    MsgBox("El Saldo debe ser mayor a Cero", MsgBoxStyle.Information)
                '    txtSaldo.Focus()
                '    Return False
                'End If
            End If
            'If CDbl(txtImporte.Text) < CDbl(txtSaldo.Text) Then
            '    MsgBox("El importe debe ser mayor o igual que el saldo del documento.", MsgBoxStyle.Information)
            '    txtSaldo.Select()
            '    Exit Try
            'End If
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If validaciones() = False Then Exit Sub
        AgregarActualizar(Flag_Modo_Edicion)
        pnlModificaciones.Visible = False
        gbDatos.Enabled = True
        If dgvCabecera.CurrentRow Is Nothing Then
            MostrarDocumentosPendiente()
        Else
            MostrarDocumentosPendienteDetalles(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value)
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        pnlModificaciones.Visible = False
        gbDatos.Enabled = True
    End Sub
 
    Private Sub txtcodigoVendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoVendedor.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub

    Private Sub txtcodigoTipoDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoTipoDoc.MouseDoubleClick
        Ayuda_TipoDocumento()
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttipoCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipoCambio.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
 
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim CodigoCliente As String = String.Empty
            Dim TipoDoc As String = String.Empty
            Dim NumeroDoc As String = String.Empty
            CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            TipoDoc = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            NumeroDoc = dgvDetalles.Item(1, dgvDetalles.CurrentRow.Index).Value
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            If clsLetrasBl.EliminacionCarteraClientes(CodigoCliente, TipoDoc, NumeroDoc) = True Then
                MsgBox("La eliminacion del Documento se a realizado correctamente", MsgBoxStyle.Information)
                If dgvCabecera.CurrentRow Is Nothing Then
                    MostrarDocumentosPendiente()
                Else
                    MostrarDocumentosPendienteDetalles(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value)
                End If

            Else
                MsgBox("Hubo un error en la eliminacion del Documento", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtserie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserie.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodigoTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoTipoDoc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoDocumento()
        ElseIf e.KeyCode = Keys.Enter Then
            txtserie.Focus()
        End If
    End Sub

    Private Sub txtcodigoVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoVendedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        ElseIf e.KeyCode = Keys.Enter Then
            cboMoneda.Focus()
        End If
    End Sub

    Private Sub txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumeroDoc.Focus()
        End If
    End Sub

    Private Sub txtnumeroDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumeroDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpEmision.Focus()
        End If
    End Sub

    Private Sub dtpEmision_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpEmision.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpVencimiento.Focus()
        End If
    End Sub

    Private Sub dtpVencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcodigoVendedor.Focus()
        End If
    End Sub

    Private Sub cboMoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttipoCambio.Focus()
        End If
    End Sub

    Private Sub txtImporte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtImporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSaldo.Focus()
        End If
    End Sub

    Private Sub txtSaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSaldo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboDatosContables.Focus()
        End If
    End Sub

    Private Sub cboDatosContables_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDatosContables.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_ok.Focus()
        End If
    End Sub

    Private Sub txtserie_Leave(sender As Object, e As EventArgs) Handles txtserie.Leave
        If txtserie.Text.Trim().Length > 0 Then
            txtserie.Text = txtserie.Text.PadLeft(3, Char.Parse("0"))
        End If
    End Sub

    Private Sub txtnumeroDoc_Leave(sender As Object, e As EventArgs) Handles txtnumeroDoc.Leave
        If txtnumeroDoc.Text.Trim().Length > 0 Then
            txtnumeroDoc.Text = txtnumeroDoc.Text.PadLeft(7, Char.Parse("0"))
        End If
    End Sub

    Private Sub dgvCabecera_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCabecera.CellMouseClick
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
        Dim CodigoCliente As String = String.Empty
        CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        MostrarDocumentosPendienteDetalles(CodigoCliente)
    End Sub

    Private Sub dtpEmision_ValueChanged(sender As Object, e As EventArgs) Handles dtpEmision.ValueChanged
        validar_Fecha()
    End Sub
    Public Sub validar_Fecha()
        Dim FechaIngr As Date
        FechaIngr = dtpEmision.Value
        Dim facturacionBl As New ClsOperaciones.RECEIVABLE
        Dim dtFecha As New DataTable("TipoCambioFecha")
        Dim Sql = String.Empty
        Sql = "SELECT ISNULL(SELL_RATE,0) [SELL_RATE] FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr.ToShortDateString & "'"
        dtFecha = facturacionBl.Muestra_consulta(Sql)
        If dtFecha.Rows.Count() <> 0 Then
            txtTipoCambio.Text = CDbl(dtFecha.Rows(0).Item("SELL_RATE"))
            txtTipoCambio.Text = Format(CDbl(txtTipoCambio.Text), "##,##0.000")
            'SendKeys.Send("{TAB}")
            dtpVencimiento.Focus()
        Else
            MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
            txttipoCambio.Text = String.Empty
            dtpEmision.Focus()
        End If
    End Sub

    Private Sub dgvCabecera_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabecera.CellEnter
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value.ToString) Then Exit Sub
        Dim CodigoCliente As String = String.Empty
        CodigoCliente = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        MostrarDocumentosPendienteDetalles(CodigoCliente)
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvCabecera.Focus()
        End If
    End Sub

    Private Sub txttipoCambio_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtImporte.Focus()
        End If
    End Sub
End Class