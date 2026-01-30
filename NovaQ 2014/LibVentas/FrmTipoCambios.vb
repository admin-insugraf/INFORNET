Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmTipoCambios

    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim Modo_consultar As Boolean = False

    Dim ClsTipoCambioBl As ClsOperaciones.CURRENCY_EXCHANGE
    Dim CLsTipoCambioEnt As ClsEntidades.CURRENCY_EXCHANGE
    Dim dttipoCambio As DataTable



    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            nuevo()
            gbFiltroTipoCambio.Visible = False
            gbGenerarTipoCambio.Visible = True
            btn_grabar.Enabled = True
            If Modo_consultar = True Then
                'txtMoneda.Enabled = False
                dtpFecha.Enabled = False
            Else
                'txtMoneda.Enabled = True
                dtpFecha.Enabled = True
            End If
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            gbFiltroTipoCambio.Visible = True
            gbGenerarTipoCambio.Visible = False
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            If Modo_consultar = True Then
                ' txtMoneda.Enabled = False
                dtpFecha.Enabled = False
            Else
                'txtMoneda.Enabled = True
                dtpFecha.Enabled = True
            End If
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub nuevo()
        ' txtMoneda.Text = String.Empty
        dtpFecha.Value = Date.Now
        txtTipoCompra.Text = String.Empty
        txtTipoVenta.Text = String.Empty
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        rbMesProceso.Checked = True
        txtTipoCompra.Select()
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If txtMoneda.Text = String.Empty Then
                MsgBox("Debe Ingresar un Tipo de Moneda", MsgBoxStyle.Information)
                estado = False
                txtMoneda.Focus()
                Exit Try
            ElseIf txtTipoCompra.Text = String.Empty Then
                MsgBox("Debe Ingresar el Tipo de Cambio de Compra", MsgBoxStyle.Information)
                estado = False
                txtTipoCompra.Focus()
                Exit Try
            ElseIf txtTipoVenta.Text = String.Empty Then
                MsgBox("Debe Ingresar el Tipo de Cambio de Venta", MsgBoxStyle.Information)
                estado = False
                txtTipoVenta.Focus()
                Exit Try
            End If
            'If CDate(dtpFecha.Value.ToString("dd/MM/yyyy")) > CDate(Date.Now.ToShortDateString) Then
            '    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    dtpFecha.Focus()
            '    estado = False
            '    Exit Try
            'End If

            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            dttipoCambio = New DataTable("Verificar_TipoC")
            dttipoCambio = ClsTipoCambioBl.get_VerificarTipoCambio(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day)
            If dttipoCambio.Rows.Count() <> 0 Then
                MsgBox("Ya se Ingreso el Tipo de Cambio para esta Fecha.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Function GuardarTipoCambio() As Boolean
        Dim resultado As Boolean = True
        Try
            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            CLsTipoCambioEnt = New ClsEntidades.CURRENCY_EXCHANGE
            CLsTipoCambioEnt.CURRENCY_ID = txtMoneda.Text
            CLsTipoCambioEnt.CURRENCY_DATE = dtpFecha.Value.ToString("dd/MM/yyyy")
            CLsTipoCambioEnt.BUY_RATE = txtTipoCompra.Text
            CLsTipoCambioEnt.BUY_EQUIV = 0
            CLsTipoCambioEnt.SELL_RATE = txtTipoVenta.Text
            CLsTipoCambioEnt.SELL_EQUIV = 0
            CLsTipoCambioEnt.USUARIO = LibComunVar.ClsVarComun.USUARIO
            CLsTipoCambioEnt.TERMINAL = Environment.MachineName
            resultado = ClsTipoCambioBl.Guardar(CLsTipoCambioEnt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function
   

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Modo_consultar = False Then
            If Validaciones() = False Then Exit Sub
            If GuardarTipoCambio() = True Then
                MsgBox("Tipo de Cambio Guardado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo agregar el Tipo de Cambio.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            If txtTipoCompra.Text = String.Empty Then
                MsgBox("Debe Ingresar el Tipo de Cambio de Compra", MsgBoxStyle.Information)
                txtTipoCompra.Focus()
                Exit Sub
            ElseIf txtTipoVenta.Text = String.Empty Then
                MsgBox("Debe Ingresar el Tipo de Cambio de Venta", MsgBoxStyle.Information)
                txtTipoVenta.Focus()
                Exit Sub
            End If
            If ModificarTipoCambio() = True Then
                MsgBox("Tipo de Cambio Modificado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo modificar el Tipo de Cambio.", MsgBoxStyle.Critical)
            End If
        End If
        Modo_consultar = False
        Botonera_Estado_Cambiar(False)
        'rbMesProceso.Checked = True
        MostrandoTipoCambio(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
    End Sub


    Private Function ModificarTipoCambio() As Boolean
        Dim resultado As Boolean = True
        Try
            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            CLsTipoCambioEnt = New ClsEntidades.CURRENCY_EXCHANGE
            CLsTipoCambioEnt.CURRENCY_ID = txtMoneda.Text
            CLsTipoCambioEnt.CURRENCY_DATE = dtpFecha.Value.ToString("dd/MM/yyyy")
            CLsTipoCambioEnt.BUY_RATE = txtTipoCompra.Text
            CLsTipoCambioEnt.SELL_RATE = txtTipoVenta.Text
            CLsTipoCambioEnt.USUARIO = LibComunVar.ClsVarComun.USUARIO
            CLsTipoCambioEnt.TERMINAL = Environment.MachineName
            resultado = ClsTipoCambioBl.Modificar(CLsTipoCambioEnt)
        Catch ex As Exception
            resultado = False
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function
    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvDetallesTipoC.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        'txtMoneda.Text = dgvDetallesTipoC.Item(0, dgvDetallesTipoC.CurrentRow.Index).Value
        dtpFecha.Value = dgvDetallesTipoC.Item(1, dgvDetallesTipoC.CurrentRow.Index).Value
        txtTipoVenta.Text = dgvDetallesTipoC.Item(3, dgvDetallesTipoC.CurrentRow.Index).Value
        txtTipoCompra.Text = dgvDetallesTipoC.Item(2, dgvDetallesTipoC.CurrentRow.Index).Value
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
    End Sub

 

    Private Sub MostrandoTipoCambio(ByVal Anio As String, ByVal Mes As String, Optional ByVal Dia As String = "")
        Try
            ClsTipoCambioBl = New ClsOperaciones.CURRENCY_EXCHANGE
            dttipoCambio = New DataTable
            If String.IsNullOrEmpty(Dia) Then
                dttipoCambio = ClsTipoCambioBl.get_TipoCambioPeriodo(Anio, Mes)
            Else
                dttipoCambio = ClsTipoCambioBl.get_TipoCambioPeriodo(Anio, Mes, Dia)
            End If
            If dttipoCambio.Rows.Count() <> 0 Then
                dgvDetallesTipoC.DataSource = dttipoCambio
                dgvDetallesTipoC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                dgvDetallesTipoC.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmTipoCambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botonera_Estado_Cambiar(False)
        dgvDetallesTipoC.Select()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        If dtpFechaMes.Enabled = True Then
            MostrandoTipoCambio(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
        ElseIf dtpFechaDia.Enabled = True Then
            MostrandoTipoCambio(dtpFechaDia.Value.Year, dtpFechaDia.Value.Month, dtpFechaDia.Value.Day)
        End If
    End Sub

    Private Sub rbMesProceso_CheckedChanged(sender As Object, e As EventArgs) Handles rbMesProceso.CheckedChanged
        If rbMesProceso.Checked = True Then
            dtpFechaMes.Enabled = True
            MostrandoTipoCambio(dtpFechaMes.Value.Year, dtpFechaMes.Value.Month)
        Else
            dtpFechaMes.Enabled = False
        End If
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked = True Then
            dtpFechaDia.Enabled = True
            MostrandoTipoCambio(dtpFechaDia.Value.Year, dtpFechaDia.Value.Month, dtpFechaDia.Value.Day)
        Else
            dtpFechaDia.Enabled = False
        End If
    End Sub

    Private Sub txtMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMoneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTipoVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoVenta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTipoCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTipoVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub
End Class