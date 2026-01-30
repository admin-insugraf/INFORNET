Imports System.Windows.Forms
Public Class FrmEstadoLetrasCobranzas
    Dim bol_nuevo As Boolean = False

    Private Sub FrmEstadoLetrasCobranzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Call Cargar_Monedas()
        Botonera_Estado_Cambiar(False)
        Call Iniciar_Form()
    End Sub

    Private Sub Iniciar_Form()
        tc_tipos.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Datos()
        Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE
        dgv_lista.DataSource = conceptosBL.get_Situacion_Letras
        dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_lista.Columns(0).HeaderText = "Codigo"
        dgv_lista.Columns(1).HeaderText = "Moneda"
        dgv_lista.Columns(2).HeaderText = "Descripción"
        dgv_lista.Columns(3).HeaderText = "Cuenta Contable"
        dgv_lista.Columns(4).Visible = False
        dgv_lista.Columns(5).Visible = False
        conceptosBL = Nothing
    End Sub

    Private Sub Cargar_Transacciones()

    End Sub

    Private Sub Cargar_Monedas()
        Dim monedasBL As New ClsOperaciones.CURRENCY_TYPE
        cmb_moneda.DataSource = monedasBL.get_Monedas
        cmb_moneda.DisplayMember = "NAME"
        cmb_moneda.ValueMember = "ID"
        monedasBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Limpiar_GroupBox(gb_datos)
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = bol_nuevo
        tc_tipos.SelectedIndex = 1
        txt_cod.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE
        Dim conceptosBE As New ClsEntidades.STATUS_LETTER
        'Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE
        Dim dt_validador As DataTable
        If bol_nuevo Then
            dt_validador = conceptosBL.get_Valida_Cod_Situacion_Letter(txt_cod.Text, cmb_moneda.SelectedValue)
            If dt_validador.Rows.Count > 0 Then
                Call Avisar("El codigo ingresado ya esta en uso.!!!")
                txt_cod.Text = ""
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With conceptosBE
            .STATUS_ID = txt_cod.Text.Trim
            .CURRENCY_ID = cmb_moneda.SelectedValue
            .DESCRIPTION = txt_des.Text.Trim
            .ACCOUNT = txt_cuenta.Text.Trim
            .EVENTO = ""
            .IS_GENERA_ASIENTO = IIf(chk_genera_asiento.Checked, "S", "N")
        End With

        If bol_nuevo Then
            conceptosBL.Insert_Status_Letter(conceptosBE)
        Else
            conceptosBL.Update_Status_Letter(conceptosBE)
        End If

        conceptosBL = Nothing
        conceptosBE = Nothing
        Avisar("Proceso generado correctamente!")
        btn_cancelar_Click(sender, e)
        tc_tipos.SelectedIndex = 0
        dgv_lista.Focus()
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        bol_nuevo = False
        Call Limpiar_GroupBox(gb_datos)
        gb_datos.Enabled = True
        txt_cod.Text = dgv_lista.CurrentRow.Cells("STATUS_ID").Value.ToString
        txt_des.Text = dgv_lista.CurrentRow.Cells("DESCRIPTION").Value.ToString
        txt_cuenta.Text = dgv_lista.CurrentRow.Cells("ACCOUNT").Value.ToString
        cmb_moneda.SelectedValue = dgv_lista.CurrentRow.Cells("CURRENCY_ID").Value.ToString
        chk_genera_asiento.Checked = IIf(dgv_lista.CurrentRow.Cells("IS_GENERA_ASIENTO").Value = "S", True, False)

        tc_tipos.SelectedIndex = 1
        txt_cuenta.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE
            Dim conceptosBE As New ClsEntidades.STATUS_LETTER
            conceptosBE.STATUS_ID = dgv_lista.CurrentRow.Cells("STATUS_ID").Value.ToString
            conceptosBE.CURRENCY_ID = dgv_lista.CurrentRow.Cells("CURRENCY_ID").Value.ToString
            conceptosBL.Delete_Situacion_Letras(conceptosBE)
            conceptosBE = Nothing
            conceptosBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Proceso generado correctamente!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        tc_tipos.SelectedIndex = 0
        Cargar_Datos()
    End Sub


    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE
            Dim dt_validador As DataTable
            dt_validador = conceptosBL.get_Valida_Cod_Situacion_Letter(txt_cod.Text, cmb_moneda.SelectedValue)
            If dt_validador.Rows.Count > 0 Then
                Call Avisar("El codigo ingresado ya esta en uso.!!!")
                txt_cod.Text = ""
                txt_cod.Focus()
            Else
                SendKeys.Send(vbTab)
            End If

        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    Ayuda_CuentasContables(txt_cuenta)
        'End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cuenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cuenta.MouseDoubleClick
        Ayuda_CuentasContables(txt_cuenta)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub txt_cuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cuenta)
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class