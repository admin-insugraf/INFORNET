Imports System.Windows.Forms

Public Class frm_CX_MA_ConceptosPago
    Dim bol_nuevo As Boolean = False


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
    Private Sub frm_CX_MA_ConcepCob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE_PAY
        dgv_lista.DataSource = conceptosBL.get_Conceptos_Pago_Proveedor
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
        If txt_cod.Text.Trim = "" Then
            Avisar("Ingrese el codigo")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE_PAY
        Dim conceptosBE As New ClsEntidades.TYPE_RECEIVE_PAY
        With conceptosBE
            .TYPE = ""
            .RECEIVE_ID = txt_cod.Text.Trim
            .DESCRIPTION = txt_des.Text.Trim
            .CURRENCY_ID = cmb_moneda.SelectedValue
            .ACCOUNT = txt_cuenta.Text.Trim
            .VENDOR_ID = 0
            .BANK_ID = IIf(chk_banco.Checked, 1, 0)
            .USER_ID = LibComunVar.ClsVarComun.USUARIO 'gUsuarioSis
            .DATEE = Date.Now.ToShortDateString
            .EFFECTIVE_DATE = Date.Now.ToShortDateString
            .IS_CHECK_DIF = IIf(chk_cheque.Checked, 1, 0)
            .IS_APPL = IIf(chk_aplica.Checked, 1, 0)
            .TRANS_TYPE = cmb_tip_trans.SelectedIndex
            .IS_CREDIT_CARD = IIf(chk_tarjeta.Checked, 1, 0)
        End With

        If bol_nuevo Then
            conceptosBL.Insert_Pago_proveedores(conceptosBE)
        Else
            conceptosBL.Update_Pago_proveedores(conceptosBE)
        End If
        conceptosBL = Nothing
        conceptosBE = Nothing
        Call Avisar("Cambios Correctos!")
        tc_tipos.SelectedIndex = 0
        dgv_lista.Focus()
        btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        bol_nuevo = False
        Call Limpiar_GroupBox(gb_datos)
        gb_datos.Enabled = True
        txt_cod.Text = dgv_lista.CurrentRow.Cells("col_cod").Value.ToString
        txt_des.Text = dgv_lista.CurrentRow.Cells("col_des").Value.ToString
        txt_cuenta.Text = dgv_lista.CurrentRow.Cells("col_cuenta").Value.ToString
        cmb_moneda.SelectedValue = dgv_lista.CurrentRow.Cells("col_mon").Value.ToString

        chk_banco.Checked = IIf(dgv_lista.CurrentRow.Cells("col_banco").Value = "1", True, False)
        chk_aplica.Checked = IIf(dgv_lista.CurrentRow.Cells("col_apli").Value = "1", True, False)
        chk_tarjeta.Checked = IIf(dgv_lista.CurrentRow.Cells("col_tar").Value = "1", True, False)
        chk_cheque.Checked = IIf(dgv_lista.CurrentRow.Cells("col_cheque").Value = "1", True, False)
        cmb_tip_trans.SelectedIndex = dgv_lista.CurrentRow.Cells("col_tiptrans").Value

        txt_cod.Enabled = bol_nuevo
        tc_tipos.SelectedIndex = 1

        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            Dim conceptosBL As New ClsOperaciones.TYPE_RECEIVE_PAY
            Dim conceptosBE As New ClsEntidades.TYPE_RECEIVE_PAY
            conceptosBE.RECEIVE_ID = dgv_lista.CurrentRow.Cells("col_cod").Value.ToString
            conceptosBL.Delete_Pago_proveedores(conceptosBE)
            conceptosBE = Nothing
            conceptosBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Listo!")
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
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown, txt_cuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cuenta)
        End If
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
End Class