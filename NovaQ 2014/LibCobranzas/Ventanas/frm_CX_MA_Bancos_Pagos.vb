Imports System.Windows.Forms

Public Class frm_CX_MA_Bancos_Pagos
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


    Private Sub frm_CX_MA_Bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Data()
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub Ayuda_Conceptos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CONCEPTOS_PAY"
            frm.CadenaConsulta = sql
            frm.Titulo = "Concepto de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtTipoCobranzas.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Cargar_Data()
        Dim bancoBL As New ClsOperaciones.BANK_PAY
        dgv_bancos.DataSource = bancoBL.get_Bancos()
        bancoBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        tc_bancos.SelectedIndex = 1
        gb_data.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
        txt_cod.Focus()

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_bancos.Rows.Count = 0 Then Exit Sub
        If dgv_bancos.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        txt_cod.Text = dgv_bancos.CurrentRow.Cells("col_id").Value
        txt_des.Text = dgv_bancos.CurrentRow.Cells("col_des").Value
        txtTipoCobranzas.Text = IIf(String.IsNullOrEmpty(dgv_bancos.CurrentRow.Cells("col_cobranza").Value.ToString), "", dgv_bancos.CurrentRow.Cells("col_cobranza").Value)

        bol_nuevo = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        tc_bancos.SelectedIndex = 1
        txt_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_bancos.Rows.Count = 0 Then Exit Sub
        If dgv_bancos.CurrentRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim bancoBL As New ClsOperaciones.BANK_PAY
            Dim bancoBE As New ClsEntidades.BANK_PAY
            bancoBE.ID = dgv_bancos.CurrentRow.Cells("col_id").Value.ToString
            bancoBL.Delete(bancoBE)
            bancoBE = Nothing
            bancoBL = Nothing
            Call Avisar("Listo!")
            Call Cargar_Data()
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_bancos.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
        Cargar_Data()
    End Sub



    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_cod.Text.Trim = "" Then
            Call Avisar("Ingrese el codigo")
            txt_cod.Focus()
            Exit Sub
        End If
        If txt_des.Text.Trim = "" Then
            Call Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        If txtTipoCobranzas.Text = String.Empty Then
            MsgBox("Debe escoger una Forma de Cobranza", MsgBoxStyle.Information)
            txtTipoCobranzas.Focus()
            Exit Sub
        End If

        Dim bancoBL As New ClsOperaciones.BANK_PAY
        Dim bancoBE As New ClsEntidades.BANK_PAY

        With bancoBE
            .ID = txt_cod.Text.Trim
            .NAME = txt_des.Text.Trim
            .RECEIVE_ID = txtTipoCobranzas.Text
        End With

        If bol_nuevo Then
            bancoBL.Insert(bancoBE)
        Else
            bancoBL.Update(bancoBE)
        End If

        Call Cargar_Data()
        Call Avisar("Listo!")
        bancoBE = Nothing
        bancoBL = Nothing
        Call btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_cta_cte_Click(sender As Object, e As EventArgs) Handles btn_cta_cte.Click
        If dgv_bancos.Rows.Count = 0 Then Exit Sub
        If dgv_bancos.CurrentRow Is Nothing Then Exit Sub

        Dim f As New frm_CX_MA_Banco_Cuenta_Pago
        f.pCodBanco = dgv_bancos.CurrentRow.Cells("col_id").Value.ToString
        f.ShowDialog()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub txtTipoCobranzas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoCobranzas.MouseDoubleClick
        Ayuda_Conceptos()
    End Sub

    Private Sub txtTipoCobranzas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoCobranzas.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Conceptos()
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class