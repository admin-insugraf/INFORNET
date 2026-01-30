Imports System.Windows.Forms

Public Class FrmAceptacionLetras
    Private clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim clsClienteBl As ClsOperaciones.RECEIVABLE_LIST
    Dim dtDocumentos As DataTable
    Dim dtDetalleTerceros As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim _numero_asiento As String = ""
    Dim _opt_cambio_actualizacion_estado As String

    Private Function GenerarCambioEstado() As Boolean
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentos = New DataTable
            If clsLetrasBl.GeneracionCambioEstadoLetra(txtcodigoletra.Text, txtbanco.Text, txtComentario.Text, txtcodigoSituacion.Text, _
                                                       cboCuenta.SelectedValue, txtnumeracionBancaria.Text, dtpFechaActualizacion.Value.ToString("dd/MM/yyyy"), _
                                                       _opt_cambio_actualizacion_estado) Then
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

    Private Function GenerarCambioEstado_Grupal(ls_det_LT_GRUPAL As List(Of ClsEntidades.LETRAS_CAMBIO_GRUPAL)) As Boolean
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentos = New DataTable
            For i As Integer = 0 To ls_det_LT_GRUPAL.Count - 1
                If clsLetrasBl.GeneracionCambioEstadoLetra(ls_det_LT_GRUPAL(i).NUMERO_DOC, TextBox10.Text, "", TextBox4.Text, _
                                                       ComboBox1.SelectedValue, "", CDate(mtb_fec_emi.Text).ToString("dd/MM/yyyy"), _opt_cambio_actualizacion_estado) Then
                    'MsgBox("Actualización correcta de los datos.", MsgBoxStyle.Information)
                    'Return True
                Else
                    MsgBox("Hubo un error en la actualización de los datos", MsgBoxStyle.Critical)
                    Return False
                    Exit For
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function


    Private Sub MostrarDocumentosAceptados()
        Try
            Me.Cursor = Cursors.WaitCursor
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsLetrasBl.DocumentoLetrasAceptadas(cbo_estados.SelectedValue.ToString)
            dtv = dtDocumentos.DefaultView
            dgvDocumentos.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvDocumentos.DataSource = dtv
                dgvDocumentos.AutoResizeColumns()
                dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvDocumentos.Columns(8).HeaderText = "Cod. Estado"
                dgvDocumentos.Columns(5).DefaultCellStyle.Format = "N3"
                dgvDocumentos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDocumentos.Columns(9).HeaderText = "Estado"
                dgvDocumentos.Columns(10).HeaderText = "Moneda"
                dgvDocumentos.Columns(11).HeaderText = "Cuenta Contable"
                dgvDocumentos.Columns(12).Visible = False
                dgvDocumentos.Columns(13).Visible = False
                dgvDocumentos.Columns(14).Visible = False
                dgvDocumentos.Columns(15).HeaderText = "Número Unico"
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

            Else
                dgvDocumentos.DataSource = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MostrarBancos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_BANK"
            frm.CadenaConsulta = sql
            frm.Titulo = "Bancos"
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

    Private Sub MostrarBancosGrupal()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_BANK"
            frm.CadenaConsulta = sql
            frm.Titulo = "Bancos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox10.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox9.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                If String.IsNullOrEmpty(TextBox10.Text) Then
                    ComboBox1.DataSource = Nothing
                    Exit Sub
                End If
                frm.Close()
                MostrandoCuentasBancosGrupal(TextBox10.Text)
            Else
                TextBox10.Text = String.Empty
                TextBox9.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarSituacionLetra()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_ESTADO_LETRA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtcodigo_estado.Text
            frm.Filtros2 = txtmoneda.Text
            frm.Titulo = "Situacion de las Letras"
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

    Private Sub MostrarSituacionLetraGrupal()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_ESTADO_LETRA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TextBox7.Text
            frm.Filtros2 = TextBox6.Text
            frm.Titulo = "Situacion de las Letras"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox4.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox3.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                TextBox1.Text = frm.Data_Matriz.Rows(0).Item("MONEDA").ToString
                TextBox2.Text = frm.Data_Matriz.Rows(0).Item("CUENTA.CONTABLE").ToString
                TextBox10.Focus()
            Else
                TextBox4.Text = String.Empty
                TextBox3.Text = String.Empty
                TextBox1.Text = ""
                TextBox2.Text = ""
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
            dtBancoCuenta = BuscarBl.CuentasBancos(codigoBank)
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

    Private Sub MostrandoCuentasBancosGrupal(ByVal codigoBank As String)
        Try
            Dim BuscarBl As New ClsBuscar
            Dim dtBancoCuenta As DataTable
            dtBancoCuenta = New DataTable
            dtBancoCuenta = BuscarBl.CuentasBancos(codigoBank)
            ComboBox1.DataSource = Nothing
            If dtBancoCuenta.Rows.Count() <> 0 Then
                ComboBox1.ValueMember = "CODIGO"
                ComboBox1.DisplayMember = "DESCRIPCION"
                ComboBox1.DataSource = dtBancoCuenta
            Else
                ComboBox1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub FrmAceptacionLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Cargar_Estados_Letras()
        MostrarDocumentosAceptados()
    End Sub

    Private Sub Cargar_Estados_Letras()
        Try
            clsClienteBl = New ClsOperaciones.RECEIVABLE_LIST
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsClienteBl.get_Lista_Estados_Letras()
            Dim row As DataRow = dtDocumentos.NewRow()
            'row.Item("ID") = ""
            'row.Item("DESCRIPTION") = "Todos"
            'dtDocumentos.Rows.InsertAt(row, 0)
            cbo_estados.DataSource = dtDocumentos
            cbo_estados.DisplayMember = "DESCRIPTION"
            cbo_estados.ValueMember = "ID"
            cbo_estados.SelectedIndex = 0
            clsClienteBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            TextBox7.Text = String.Empty
            TextBox8.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox1.Text = String.Empty
            TextBox9.Text = String.Empty
            TextBox10.Text = String.Empty
            ComboBox1.DataSource = Nothing
            chktodos.Checked = False
            mtb_fec_emi.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
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

    Private Function validarGrupal() As Boolean
        Dim estado As Boolean = True
        Try
            If TextBox7.Text = String.Empty Then
                MsgBox("Es necesario escoger un Estado anterior de la Letra.", MsgBoxStyle.Information)
                TextBox7.Focus()
                estado = False
                Exit Try
            ElseIf TextBox4.Text = String.Empty Then
                MsgBox("Es necesario escoger un Estado actual de la letra", MsgBoxStyle.Information)
                TextBox4.Focus()
                estado = False
                Exit Try
            ElseIf TextBox10.Text = String.Empty Then
                MsgBox("Es necesario escoger un Banco", MsgBoxStyle.Information)
                estado = False
                txtbanco.Focus()
                Exit Try
            ElseIf ComboBox1.Text = String.Empty Then
                MsgBox("No se a cargo las cuentas el banco elegido.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If

            If dgv_pendientes.CurrentRow Is Nothing Then estado = False : Exit Try
            For Each row As DataGridViewRow In dgv_pendientes.Rows
                If row.Cells(0).Value = True Then
                    estado = True
                    Exit For
                End If
            Next
            If estado = False Then
                MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
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
        _numero_asiento = ac.get_Ult_num_voucher("09", fecha.Year, Format(fecha.Month, "00"))
        ac = Nothing
    End Sub
    Private Sub Cargar_Numero_Voucher_Grupal()
        Dim fecha As DateTime = DateTime.Parse(mtb_fec_emi.Text)
        Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
        _numero_asiento = ""
        _numero_asiento = ac.get_Ult_num_voucher("09", fecha.Year, Format(fecha.Month, "00"))
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
        SQL = "SELECT IS_GENERA_ASIENTO FROM dbo.STATUS_LETTER WHERE STATUS_ID='" & txtcodigoSituacion.Text & "' AND CURRENCY_ID='" & txtmonedaSituacion.Text & "'"
        dtAccepLetra_Contab = clsLetrasBl.VerificacionClienteVendedor(Sql)
        If dtAccepLetra_Contab.Rows.Count() <> 0 Then
            If dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "S" Then
                If MessageBox.Show("¿Desea numeración Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
                    dtcodigo = ClsasientoBl.ValidarCodigo("09", CodigoManual, dtpFechaActualizacion.Value.Year, dtpFechaActualizacion.Value.Month)
                    If dtcodigo.Rows.Count() <> 0 Then
                        MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        _numero_asiento = CodigoManual
                    End If
                End If
                Me.Cursor = Cursors.WaitCursor
                Dim CobranzaBl As New ClsOperaciones.LETTER_EXCHANGE
                If CobranzaBl.Contabilizar_Caja_Cambio_Estado(txtcodigoletra.Text, CDate(dtpFechaActualizacion.Value), _numero_asiento, _
                                                              txtmoneda.Text, txtcuentasituacion.Text) = True Then
                    MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information)
                    ImprimirVoucher(txtcodigoletra.Text, _numero_asiento)

                    Me.Cursor = Cursors.Default
                    If GenerarCambioEstado() = False Then Exit Sub
                    pnlPrincipal.Visible = True
                    MostrarDocumentosAceptados()
                    btnSalir_Click(sender, e)
                Else
                    Me.Cursor = Cursors.Default
                End If
                
            ElseIf dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "N" Then
                If GenerarCambioEstado() = False Then Exit Sub
                pnlPrincipal.Visible = True
                btnSalir_Click(sender, e)
                MostrarDocumentosAceptados()
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
                SQL = "SELECT *  FROM DBO.CO_TB_ASIENTO_CAB WHERE AC_IDSUBDIARIO = '09'   AND AC_NUM_VOUCHER ='" & _NUM_ASIENTO & "'"
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
        PnlCambioestadogrupal.Visible = False
        ToolStripButton3.Enabled = True
        ToolStripButton1.Enabled = True
        btnNuevo.Enabled = True
        'MostrarDocumentosAceptados()
    End Sub

    Private Sub txtbanco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtbanco.MouseDoubleClick
        MostrarBancos()
    End Sub

    Private Sub txtcodigoSituacion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoSituacion.MouseDoubleClick
        MostrarSituacionLetra()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
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
        Dim Estado As String = String.Empty
        _opt_cambio_actualizacion_estado = "cambio"
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString) Then Exit Sub
        CodigoLetras = dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value
        FechaVencimiento = dgvDocumentos.Item(4, dgvDocumentos.CurrentRow.Index).Value
        Moneda = dgvDocumentos.Item(6, dgvDocumentos.CurrentRow.Index).Value
        Estado = Strings.Right(Trim(dgvDocumentos.CurrentRow.Cells("STATUS_ACT").Value), 2)

        If Estado = "PA" Then
            MsgBox("La situación del documento," + Chr(13) + " no permite realizar actualizaciones.", MsgBoxStyle.Information, "Sistemas")
            Exit Sub
        Else
            pnlPrincipal.Visible = False
            PnlCambioestadogrupal.Visible = False
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

            ToolStripButton3.Enabled = False
            ToolStripButton1.Enabled = False
            btnNuevo.Enabled = False

            txtcodigoSituacion.Select()
        End If
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
        PnlCambioestadogrupal.Visible = False
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

        ToolStripButton3.Enabled = False
        ToolStripButton1.Enabled = False
        btnNuevo.Enabled = False

        txtnumeracionBancaria.Select()
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        For i As Integer = 0 To dgv_pendientes.RowCount - 1
            dgv_pendientes.Rows(i).Cells("chk_sel").Value = chktodos.Checked
            '    _total_pago = _total_pago + Val(dgv_pendientes.Rows(i).Cells("COL_SALDO").Value)
        Next
    End Sub

    Private Sub dgv_pendientes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_pendientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub Cargar_Documentos_Pendientes()
        Me.Cursor = Cursors.WaitCursor
        Dim saldosBL As New ClsOperaciones.CUSTOMER_BALANCE
        dgv_pendientes.DataSource = saldosBL.get_Letras_x_Situacion_Grupal(TextBox7.Text, TextBox6.Text)
        dgv_pendientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_pendientes.AutoResizeColumns()
        dgv_pendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        saldosBL = Nothing
        Me.Cursor = Cursors.Default
        'For i As Integer = 0 To dgv_pendientes.RowCount - 1
        '    dgv_pendientes.Rows(i).Cells("COL_SALDO").Value = dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value
        'Next
        'dgv_pendientes.Update()
    End Sub
    Private Sub Ayuda_Situacion_Letras(Optional ByVal _CodigoRuc As String = "")
        Try
            'Opcion  C AS BUSQUEDA POR CODIGO, R BUSQUEDA POR RUC ..
            If _CodigoRuc = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "CX_SP_S_ESTADOS_LETRAS"
                frm.CadenaConsulta = sql
                frm.Titulo = "Estado de Letras"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    TextBox7.Text = frm.Data_Matriz.Rows(0).Item(0).ToString 'frm.Data_Matriz.Rows(0).Item(0).ToString
                    TextBox5.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    TextBox6.Text = frm.Data_Matriz.Rows(0).Item(2).ToString 'frm.Data_Matriz.Rows(0).Item(0).ToString
                    TextBox8.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                    If TextBox7.Text <> String.Empty Then
                        Cargar_Documentos_Pendientes()
                        dgv_pendientes.Focus()
                    End If
                End If
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox7.MouseDoubleClick
        Ayuda_Situacion_Letras()
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Situacion_Letras("")
        End If
        If e.KeyCode = Keys.Enter Then
            If TextBox7.Text = String.Empty Then
                Ayuda_Situacion_Letras("")
            Else
                Ayuda_Situacion_Letras(TextBox7.Text)
            End If

        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.F1 Then MostrarSituacionLetraGrupal()
        If e.KeyCode = Keys.Enter Then
            TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseDoubleClick
        MostrarSituacionLetraGrupal()
    End Sub

    Private Sub TextBox10_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox10.MouseDoubleClick
        MostrarBancosGrupal()
    End Sub

    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.F1 Then MostrarBancosGrupal()
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_emi.Select()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlPrincipal.Visible = True
        PnlCambioestadogrupal.Visible = False
        ToolStripButton3.Enabled = True
        ToolStripButton1.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim CodigoLetras As String = String.Empty
        Dim FechaVencimiento As String = String.Empty
        Dim Moneda As String = String.Empty
        Dim Estado As String = String.Empty
        _opt_cambio_actualizacion_estado = "cambio"
        'If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub
        'If String.IsNullOrEmpty(dgvDocumentos.Item(1, dgvDocumentos.CurrentRow.Index).Value.ToString) Then Exit Sub
        pnlPrincipal.Visible = False
        PnlCambioestadogrupal.Visible = True
        ToolStripButton3.Enabled = False
        ToolStripButton1.Enabled = False
        btnNuevo.Enabled = False
        Blank()
        Call Cargar_Documentos_Pendientes()
        TextBox7.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQL As String
        If validarGrupal() = False Then Exit Sub

        Dim dtAccepLetra_Contab As New DataTable
        SQL = "SELECT IS_GENERA_ASIENTO FROM dbo.STATUS_LETTER WHERE STATUS_ID='" & TextBox7.Text & "' AND CURRENCY_ID='" & TextBox6.Text & "'"
        dtAccepLetra_Contab = clsLetrasBl.VerificacionClienteVendedor(SQL)
        If dtAccepLetra_Contab.Rows.Count() <> 0 Then
            If dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "S" Then
                If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Call Cargar_Numero_Voucher_Grupal()
                Else
                    Dim CodigoManual As String = String.Empty
                    CodigoManual = InputBox("Ingrese numero de asiento")
                    If CodigoManual = String.Empty Then
                        MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    CodigoManual = Format(CDate(mtb_fec_emi.Text).Month, "00") & CodigoManual.PadLeft(4, Char.Parse("0"))
                    Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                    Dim dtcodigo As New DataTable
                    dtcodigo = ClsasientoBl.ValidarCodigo("09", CodigoManual, CDate(mtb_fec_emi.Text).Year, CDate(mtb_fec_emi.Text).Month)
                    If dtcodigo.Rows.Count() <> 0 Then
                        MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        _numero_asiento = CodigoManual
                    End If
                End If
                Me.Cursor = Cursors.WaitCursor
                Dim planilladetBE As ClsEntidades.LETRAS_CAMBIO_GRUPAL
                Dim CobranzaBl As New ClsOperaciones.LETTER_EXCHANGE
                Dim ls_detalle As New List(Of ClsEntidades.LETRAS_CAMBIO_GRUPAL)

                For i As Integer = 0 To dgv_pendientes.RowCount - 1
                    If dgv_pendientes.Rows(i).Cells("chk_Sel").Value Then
                        planilladetBE = New ClsEntidades.LETRAS_CAMBIO_GRUPAL
                        With planilladetBE
                            .CUENTA = TextBox8.Text 'CUENTA ANTERIOR
                            .RUC = dgv_pendientes.Rows(i).Cells("CUSTOMER_ID").Value.ToString 'txt_cod_ane.Text
                            .TIPO_DOC = dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value.ToString
                            .SERIE_DOC = "000"
                            .NUMERO_DOC = dgv_pendientes.Rows(i).Cells("COL_NUM_DOC_AUX").Value.ToString
                            .FEC_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_DOC_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .FEC_VEN_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_CADUCATE_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .TIPO_MONEDA = IIf(dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value.ToString = "MN", 1, 2)
                            .TC = CDbl(dgv_pendientes.Rows(i).Cells("COL_TC").Value.ToString)
                            .MONTO_DOC = IIf(.TIPO_MONEDA = 1, CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString), CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString) * .TC)
                            .CLIENTE = dgv_pendientes.Rows(i).Cells("CODIGO_CLIENTE").Value.ToString 'txt_cod_ane.Text
                        End With
                        ls_detalle.Add(planilladetBE)
                        planilladetBE = New ClsEntidades.LETRAS_CAMBIO_GRUPAL
                        With planilladetBE
                            .CUENTA = TextBox2.Text ' CUENTA ACTUAL
                            .RUC = dgv_pendientes.Rows(i).Cells("CUSTOMER_ID").Value.ToString 'txt_cod_ane.Text
                            .TIPO_DOC = dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value.ToString
                            .SERIE_DOC = "000"
                            .NUMERO_DOC = dgv_pendientes.Rows(i).Cells("COL_NUM_DOC_AUX").Value.ToString
                            .FEC_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_DOC_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .FEC_VEN_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_CADUCATE_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .TIPO_MONEDA = IIf(dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value.ToString = "MN", 1, 2)
                            .TC = CDbl(dgv_pendientes.Rows(i).Cells("COL_TC").Value.ToString)
                            .MONTO_DOC = IIf(.TIPO_MONEDA = 1, CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString), CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString) * .TC)
                            .CLIENTE = dgv_pendientes.Rows(i).Cells("CODIGO_CLIENTE").Value.ToString 'txt_cod_ane.Text
                        End With
                        ls_detalle.Add(planilladetBE)
                    End If
                Next
                If CobranzaBl.Contabilizar_Caja_Cambio_Estado_Grupal(ls_detalle, txtcodigoletra.Text, CDate(mtb_fec_emi.Text), _numero_asiento, _
                                                              IIf(TextBox6.Text = "MN", 1, 2), "") = True Then
                    MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information)
                    'ImprimirVoucher(txtcodigoletra.Text, _numero_asiento)

                    Me.Cursor = Cursors.Default
                    If GenerarCambioEstado_Grupal(ls_detalle) = False Then Exit Sub
                    pnlPrincipal.Visible = True
                    PnlCambioestadogrupal.Visible = False
                    MostrarDocumentosAceptados()
                    btnSalir_Click(sender, e)
                Else
                    Me.Cursor = Cursors.Default
                End If

            ElseIf dtAccepLetra_Contab.Rows(0).Item("IS_GENERA_ASIENTO").ToString = "N" Then

                Dim ls_detalle As New List(Of ClsEntidades.LETRAS_CAMBIO_GRUPAL)
                Dim planilladetBE As ClsEntidades.LETRAS_CAMBIO_GRUPAL
                Dim CobranzaBl As New ClsOperaciones.LETTER_EXCHANGE

                For i As Integer = 0 To dgv_pendientes.RowCount - 1
                    If dgv_pendientes.Rows(i).Cells("chk_Sel").Value Then
                        planilladetBE = New ClsEntidades.LETRAS_CAMBIO_GRUPAL
                        With planilladetBE
                            .CUENTA = TextBox8.Text 'CUENTA ANTERIOR
                            .RUC = dgv_pendientes.Rows(i).Cells("CUSTOMER_ID").Value.ToString 'txt_cod_ane.Text
                            .TIPO_DOC = dgv_pendientes.Rows(i).Cells("COL_DOCUMENT_ID").Value.ToString
                            .SERIE_DOC = "000"
                            .NUMERO_DOC = dgv_pendientes.Rows(i).Cells("COL_NUM_DOC_AUX").Value.ToString
                            .FEC_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_DOC_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .FEC_VEN_DOC = CDate(dgv_pendientes.Rows(i).Cells("COL_CADUCATE_DATE").Value.ToString).ToString("dd/MM/yyyy")
                            .TIPO_MONEDA = IIf(dgv_pendientes.Rows(i).Cells("COL_COD_MON").Value.ToString = "MN", 1, 2)
                            .TC = CDbl(dgv_pendientes.Rows(i).Cells("COL_TC").Value.ToString)
                            .MONTO_DOC = IIf(.TIPO_MONEDA = 1, CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString), CDbl(dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value.ToString) * .TC)
                            .CLIENTE = dgv_pendientes.Rows(i).Cells("CODIGO_CLIENTE").Value.ToString 'txt_cod_ane.Text
                        End With
                        ls_detalle.Add(planilladetBE)
                    End If
                Next

                If GenerarCambioEstado_Grupal(ls_detalle) = False Then Exit Sub
                pnlPrincipal.Visible = True
                PnlCambioestadogrupal.Visible = False
                btnSalir_Click(sender, e)
                MostrarDocumentosAceptados()
            End If
        End If
    End Sub

    Private Sub mtb_fec_emi_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_emi.KeyDown
        
        If e.KeyCode = Keys.Enter Then
            If IsDate(mtb_fec_emi.Text) = False Then
                MsgBox(" La Fecha Ingresada no posee un formato Correcto. ", MsgBoxStyle.Information, "Error al ingresar la fecha ")
                mtb_fec_emi.Select()
                Exit Sub
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_estados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_estados.SelectedIndexChanged
        txtFiltro.Text = String.Empty
        MostrarDocumentosAceptados()
    End Sub
End Class