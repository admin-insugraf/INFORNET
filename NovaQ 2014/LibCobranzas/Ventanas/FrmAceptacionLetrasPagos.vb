Imports System.Windows.Forms
Public Class FrmAceptacionLetrasPagos
    Private clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtDocumentos As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim _numero_asiento As String = ""
    Dim _opt_cambio_actualizacion_estado As String
    Private Sub FrmAceptacionLetrasPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MostrarDocumentosAceptados()
    End Sub


    Public Sub Blank()
        Try
            txtcodigoletra.Text = String.Empty
            dtpVencimiento.Value = Date.Now
            txtcodigoSituacion.Text = String.Empty
            txtdescripcionSituacion.Text = String.Empty
            txtbanco.Text = String.Empty
            txtdescripcionBanco.Text = String.Empty
            cboCuenta.DataSource = Nothing
            txtnumeracionBancaria.Text = String.Empty
            dtpFechaActualizacion.Value = Date.Now
            txtComentario.Text = String.Empty
            txtmoneda.Text = String.Empty
            txtcodigo_estado.Text = ""
            txtdescripcion_estado.Text = ""
            txtmoneda_estado.Text = ""
            txtcuentacontable_estado.Text = ""
            txtmonedaSituacion.Text = ""
            txtcuentasituacion.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs)
        Dim CodigoLetras As String = String.Empty
        Dim FechaVencimiento As String = String.Empty
        Dim Moneda As String = String.Empty
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString) Then Exit Sub
        CodigoLetras = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value
        FechaVencimiento = dgvDocumentos.Item(4, dgvDocumentos.CurrentRow.Index).Value
        Moneda = dgvDocumentos.Item(6, dgvDocumentos.CurrentRow.Index).Value

        pnlPrincipal.Visible = False
        Blank()
        txtcodigoletra.Text = CodigoLetras
        dtpVencimiento.Value = FechaVencimiento
        txtmoneda.Text = Moneda

        ''DETALLES DEL ESTADO ACTUAL
        txtcodigo_estado.Text = dgvDocumentos.Item(8, dgvDocumentos.CurrentRow.Index).Value
        txtdescripcion_estado.Text = dgvDocumentos.Item(9, dgvDocumentos.CurrentRow.Index).Value
        txtmoneda_estado.Text = dgvDocumentos.Item(10, dgvDocumentos.CurrentRow.Index).Value
        txtcuentacontable_estado.Text = dgvDocumentos.Item(11, dgvDocumentos.CurrentRow.Index).Value
        txtcodigoSituacion.Select()

    End Sub

    Private Function validar() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcodigoletra.Text = String.Empty Then
                MsgBox("No se a cargo el Codigo de la Letra", MsgBoxStyle.Information)
                txtcodigoletra.Focus()
                estado = False
                Exit Try
            ElseIf txtcodigoSituacion.Text = String.Empty Then
                MsgBox("Es necesario escoger un Estado", MsgBoxStyle.Information)
                txtcodigoSituacion.Focus()
                estado = False
                Exit Try
            ElseIf txtbanco.Text = String.Empty Then
                MsgBox("Es necesario escoger un Banco", MsgBoxStyle.Information)
                estado = False
                txtbanco.Focus()
                Exit Try
            ElseIf cboCuenta.Text = String.Empty Then
                MsgBox("No se a cargo el Codigo de la Letra", MsgBoxStyle.Information)
                estado = False
                Exit Try
            ElseIf txtnumeracionBancaria.Text = String.Empty Then
                'MsgBox("No se a cargo el Codigo de la Letra", MsgBoxStyle.Information)
                'estado = False
                'txtnumeracionBancaria.Focus()
                'Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub Cargar_Numero_Voucher()
        Dim fecha As DateTime = DateTime.Parse(dtpFechaActualizacion.Value)
        Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
        _numero_asiento = ""
        _numero_asiento = ac.get_Ult_num_voucher("10", fecha.Year, Format(fecha.Month, "00"))
        ac = Nothing
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim SQL As String
        If validar() = False Then Exit Sub
        If _opt_cambio_actualizacion_estado = "actualizacion" Then
            If GenerarCambioEstado() = False Then Exit Sub
            pnlPrincipal.Visible = True
            btnSalir_Click(sender, e)
            MostrarDocumentosAceptados()
            Exit Sub
        End If

        Dim dtAccepLetra_Contab As New DataTable
        SQL = "SELECT IS_GENERA_ASIENTO FROM dbo.STATUS_LETTER_PAY WHERE STATUS_ID='" & txtcodigoSituacion.Text & "' AND CURRENCY_ID='" & txtmonedaSituacion.Text & "'"
        dtAccepLetra_Contab = clsLetrasBl.VerificacionClienteVendedor(SQL)
        If dtAccepLetra_Contab.Rows.Count() <> 0 Then
            If dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "S" Then
                If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Call Cargar_Numero_Voucher()
                Else
                    Dim CodigoManual As String = String.Empty
                    CodigoManual = InputBox("Ingrese numero de asiento")
                    If CodigoManual = String.Empty Then
                        MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    CodigoManual = Format(dtpFechaActualizacion.Value.Month, "00") & CodigoManual.PadLeft(4, Char.Parse("0"))
                    Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                    Dim dtcodigo As New DataTable
                    dtcodigo = ClsasientoBl.ValidarCodigo("10", CodigoManual, dtpFechaActualizacion.Value.Year, dtpFechaActualizacion.Value.Month)
                    If dtcodigo.Rows.Count() <> 0 Then
                        MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        _numero_asiento = CodigoManual
                    End If
                End If
                Me.Cursor = Cursors.WaitCursor
                Dim CobranzaBl As New ClsOperaciones.LETTER_EXCHANGE
                If CobranzaBl.Contabilizar_Caja_Cambio_Estado_Letras_Pagos(txtcodigoletra.Text, CDate(dtpFechaActualizacion.Value), _numero_asiento, _
                                                              txtmoneda.Text, txtcuentasituacion.Text) = True Then
                    ' MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information)
                    If GenerarCambioEstado() = False Then Me.Cursor = Cursors.Default : Exit Sub
                    ImprimirVoucher(txtcodigoletra.Text, _numero_asiento)
                    pnlPrincipal.Visible = True
                    MostrarDocumentosAceptados()
                    btnSalir_Click(sender, e)
                    Me.Cursor = Cursors.Default
                Else
                    Me.Cursor = Cursors.Default
                End If
                
            ElseIf dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "N" Then
                If GenerarCambioEstado() = False Then Me.Cursor = Cursors.Default : Exit Sub
                pnlPrincipal.Visible = True
                btnSalir_Click(sender, e)
                MostrarDocumentosAceptados()
                Me.Cursor = Cursors.Default
            End If
        End If


    End Sub

    Private Sub ImprimirVoucher(ByRef _DOCUMENT_ID As String, ByRef _NUM_ASIENTO As String)
        Try
            ''Imprimiendo
            If MessageBox.Show("¿Desea imprimir el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim reporteBL As New ClsBuscar
                Dim crystalBL As New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                Dim dtImprimir As New DataTable("CambioEstado")
                Dim SQL As String = String.Empty
                SQL = "SELECT *  FROM DBO.CO_TB_ASIENTO_CAB WHERE AC_IDSUBDIARIO = '10'   AND AC_NUM_VOUCHER ='" & _NUM_ASIENTO & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    Dim CodAsiento As String = dtImprimir.Rows(0).Item("AC_ID").ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE_LETRA_CAJA_ESTADO")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", dtImprimir, "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        pnlPrincipal.Visible = True
        'MostrarDocumentosAceptados()
    End Sub

    Private Sub txtbanco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtbanco.MouseDoubleClick
        MostrarBancos()
    End Sub

    Private Sub txtcodigoSituacion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoSituacion.MouseDoubleClick
        MostrarSituacionLetra()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs)
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodigoSituacion_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtcodigoSituacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoSituacion.KeyDown
        If e.KeyCode = Keys.F1 Then MostrarSituacionLetra()
        If e.KeyCode = Keys.Enter Then
            txtbanco.Focus()
        End If
    End Sub

    Private Sub txtbanco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbanco.KeyDown
        If e.KeyCode = Keys.F1 Then MostrarBancos()
        If e.KeyCode = Keys.Enter Then
            cboCuenta.Focus()
        End If
    End Sub

    Private Sub cboCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnumeracionBancaria.Focus()
        End If
    End Sub

    Private Sub txtnumeracionBancaria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumeracionBancaria.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Select()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim CodigoLetras As String = String.Empty
        Dim FechaVencimiento As String = String.Empty
        Dim Moneda As String = String.Empty
        _opt_cambio_actualizacion_estado = "cambio"
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString) Then Exit Sub
        CodigoLetras = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value
        FechaVencimiento = dgvDocumentos.Item(4, dgvDocumentos.CurrentRow.Index).Value
        Moneda = dgvDocumentos.Item(6, dgvDocumentos.CurrentRow.Index).Value

        pnlPrincipal.Visible = False
        Blank()
        txtcodigoletra.Text = CodigoLetras
        dtpVencimiento.Value = FechaVencimiento
        txtmoneda.Text = Moneda

        ''DETALLES DEL ESTADO ACTUAL
        txtcodigo_estado.Text = dgvDocumentos.Item(8, dgvDocumentos.CurrentRow.Index).Value
        txtdescripcion_estado.Text = dgvDocumentos.Item(9, dgvDocumentos.CurrentRow.Index).Value
        txtmoneda_estado.Text = dgvDocumentos.Item(10, dgvDocumentos.CurrentRow.Index).Value
        txtcuentacontable_estado.Text = dgvDocumentos.Item(11, dgvDocumentos.CurrentRow.Index).Value

        txtcodigoSituacion.Enabled = True
        txtdescripcionSituacion.Enabled = True
        txtmonedaSituacion.Enabled = True
        txtcuentasituacion.Enabled = True
        txtbanco.Enabled = True
        txtdescripcionBanco.Enabled = True
        cboCuenta.Enabled = True
        cboCuenta.Text = ""

        txtcodigoSituacion.Select()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim CodigoLetras As String = String.Empty
        Dim FechaVencimiento As String = String.Empty
        Dim Moneda As String = String.Empty
        _opt_cambio_actualizacion_estado = "actualizacion"
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString) Then Exit Sub
        CodigoLetras = dgvDocumentos.CurrentRow.Cells("nrodoc").Value 'dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value
        FechaVencimiento = dgvDocumentos.CurrentRow.Cells("vencimiento").Value 'dgvDocumentos.Item(4, dgvDocumentos.CurrentRow.Index).Value
        Moneda = dgvDocumentos.CurrentRow.Cells("moneda").Value 'dgvDocumentos.Item(6, dgvDocumentos.CurrentRow.Index).Value

        pnlPrincipal.Visible = False
        Blank()
        txtcodigoletra.Text = CodigoLetras
        dtpVencimiento.Value = FechaVencimiento
        txtmoneda.Text = Moneda

        ''DETALLES DEL ESTADO ACTUAL
        txtcodigo_estado.Text = dgvDocumentos.CurrentRow.Cells("status_act").Value 'dgvDocumentos.Item(8, dgvDocumentos.CurrentRow.Index).Value
        txtdescripcion_estado.Text = dgvDocumentos.CurrentRow.Cells("description").Value 'dgvDocumentos.Item(9, dgvDocumentos.CurrentRow.Index).Value
        txtmoneda_estado.Text = dgvDocumentos.CurrentRow.Cells("currency_id").Value 'dgvDocumentos.Item(10, dgvDocumentos.CurrentRow.Index).Value
        txtcuentacontable_estado.Text = dgvDocumentos.CurrentRow.Cells("account").Value 'dgvDocumentos.Item(11, dgvDocumentos.CurrentRow.Index).Value

        txtcodigoSituacion.Text = dgvDocumentos.CurrentRow.Cells("status_act").Value
        txtdescripcionSituacion.Text = dgvDocumentos.CurrentRow.Cells("description").Value
        txtmonedaSituacion.Text = dgvDocumentos.CurrentRow.Cells("currency_id").Value
        txtcuentasituacion.Text = dgvDocumentos.CurrentRow.Cells("account").Value
        txtbanco.Text = dgvDocumentos.CurrentRow.Cells("bank_id").Value
        txtdescripcionBanco.Text = dgvDocumentos.CurrentRow.Cells("nombre_banco").Value
        cboCuenta.Text = dgvDocumentos.CurrentRow.Cells("cuenta_bancaria_banco").Value
        txtnumeracionBancaria.Text = dgvDocumentos.CurrentRow.Cells("numero_unico").Value

        txtcodigoSituacion.Enabled = False
        txtdescripcionSituacion.Enabled = False
        txtmonedaSituacion.Enabled = False
        txtcuentasituacion.Enabled = False
        txtbanco.Enabled = False
        txtdescripcionBanco.Enabled = False
        cboCuenta.Enabled = False


        txtnumeracionBancaria.Select()
    End Sub

    Private Function GenerarCambioEstado() As Boolean
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentos = New DataTable
            If clsLetrasBl.GeneracionCambioEstadoLetraPago(txtcodigoletra.Text, txtbanco.Text, txtComentario.Text, txtcodigoSituacion.Text, _
                                                       cboCuenta.SelectedValue, txtnumeracionBancaria.Text, dtpFechaActualizacion.Value.ToString("dd/MM/yyyy"), _opt_cambio_actualizacion_estado) Then
                MsgBox("Actualización correcta de los datos.", MsgBoxStyle.Information)
                Return True
            Else
                MsgBox("Hubo un error en la actualización de los datos", MsgBoxStyle.Critical)
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function


    Private Sub MostrarDocumentosAceptados()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsLetrasBl.DocumentoLetrasAceptadasPagos
            dtv = dtDocumentos.DefaultView
            dgvDocumentos.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvDocumentos.DataSource = dtv
                dgvDocumentos.Columns(0).Width = 50
                dgvDocumentos.Columns(1).Width = 75
                dgvDocumentos.Columns(2).Width = 60
                dgvDocumentos.Columns(3).Width = 160
                dgvDocumentos.Columns(4).Width = 80
                dgvDocumentos.Columns(5).Width = 70
                dgvDocumentos.Columns(6).Width = 50

                dgvDocumentos.Columns(8).HeaderText = "Cod. Estado"
                dgvDocumentos.Columns(9).HeaderText = "Estado"
                dgvDocumentos.Columns(10).HeaderText = "Moneda"
                dgvDocumentos.Columns(11).HeaderText = "Cuenta Contable"
                dgvDocumentos.Columns(12).Visible = False
                dgvDocumentos.Columns(13).Visible = False
                dgvDocumentos.Columns(14).Visible = False
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                dgvDocumentos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MostrarBancos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_BANK_PAY"
            frm.CadenaConsulta = sql
            frm.Titulo = "Bancos de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtbanco.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionBanco.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                If String.IsNullOrEmpty(txtbanco.Text) Then
                    cboCuenta.DataSource = Nothing
                    Exit Sub
                End If
                frm.Close()
                MostrandoCuentasBancos(txtbanco.Text)
            Else
                txtbanco.Text = String.Empty
                txtdescripcionBanco.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarSituacionLetra()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_ESTADO_LETRA_PAGO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtcodigo_estado.Text
            frm.Filtros2 = txtmoneda.Text
            frm.Titulo = "Situacion de las Letras de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoSituacion.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionSituacion.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                txtmonedaSituacion.Text = frm.Data_Matriz.Rows(0).Item("MONEDA").ToString
                txtcuentasituacion.Text = frm.Data_Matriz.Rows(0).Item("CUENTA.CONTABLE").ToString
                If Trim(dgvDocumentos.CurrentRow.Cells("bank_id").Value) <> "" And Trim(dgvDocumentos.CurrentRow.Cells("nombre_banco").Value) <> "" And Trim(dgvDocumentos.CurrentRow.Cells("cuenta_bancaria_banco").Value) <> "" Then
                    txtbanco.Text = dgvDocumentos.CurrentRow.Cells("bank_id").Value
                    txtdescripcionBanco.Text = dgvDocumentos.CurrentRow.Cells("nombre_banco").Value
                    cboCuenta.Text = dgvDocumentos.CurrentRow.Cells("cuenta_bancaria_banco").Value
                    txtnumeracionBancaria.Text = dgvDocumentos.CurrentRow.Cells("numero_unico").Value

                    txtbanco.Enabled = False
                    txtdescripcionBanco.Enabled = False
                    cboCuenta.Enabled = False
                    'txtnumeracionBancaria.Enabled = False
                    btnAceptar.Select()
                Else
                    txtcodigoSituacion.Focus()
                End If

            Else
                txtbanco.Text = String.Empty
                txtdescripcionBanco.Text = String.Empty
                txtmonedaSituacion.Text = ""
                txtcuentasituacion.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frm.Close()
    End Sub

    Private Sub MostrandoCuentasBancos(ByVal codigoBank As String)
        Try
            Dim BuscarBl As New ClsBuscar
            Dim dtBancoCuenta As DataTable
            dtBancoCuenta = New DataTable
            dtBancoCuenta = BuscarBl.CuentasBancos_Pagos(codigoBank)
            cboCuenta.DataSource = Nothing
            If dtBancoCuenta.Rows.Count() <> 0 Then
                cboCuenta.ValueMember = "CODIGO"
                cboCuenta.DisplayMember = "DESCRIPCION"
                cboCuenta.DataSource = dtBancoCuenta
            Else
                cboCuenta.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    
    Private Sub txtFiltro_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged_1(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub
End Class