Imports System.Windows.Forms

Public Class frm_CX_MA_Banco_Cuenta
    Dim bol_nuevo As Boolean = False
    Public pCodBanco As String = String.Empty

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

    Private Sub frm_CX_MA_Banco_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Data()
        Call Cargar_Monedas()
        Call Cargar_Documentos()
        dgv_cuentas.Columns(0).Width = 100
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub Cargar_Data()
        Dim bancoBL As New ClsOperaciones.ACCOUNT_BANK
        dgv_cuentas.DataSource = bancoBL.get_Cuentas_Corrientes_2(pCodBanco)
        bancoBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmb_moneda.DataSource = monedaBL.get_Monedas
        cmb_moneda.DisplayMember = "NAME"
        cmb_moneda.ValueMember = "ID"
        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentoBL As New ClsOperaciones.DOCUMENT_TYPE
        cmb_tipo_doc.DataSource = documentoBL.get_Documentos_xCmb()
        cmb_tipo_doc.DisplayMember = "DES"
        cmb_tipo_doc.ValueMember = "COD"
        documentoBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        tc_bancos.SelectedIndex = 1
        cmb_moneda.SelectedIndex = 1
        cmb_tipo_doc.SelectedIndex = 0
        gb_data.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
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


        Dim cuentaBL As New ClsOperaciones.ACCOUNT_BANK
        Dim cuentaBE As New ClsEntidades.ACCOUNT_BANK

        With cuentaBE
            .BANK_ID = pCodBanco
            .ACCOUNT_BANK_ID = txt_cod.Text.Trim
            .ACCOUNT_BANK_DES = txt_des.Text.Trim
            .NUMBER_ACCOUNT = txt_num_cta.Text.Trim
            .CURRENCY_ID = cmb_moneda.SelectedValue.ToString
            .TYPE_DOC = cmb_tipo_doc.SelectedValue.ToString
            .TYPE_ANNEX = txtAnexo.Text
        End With

        If bol_nuevo Then
            cuentaBL.Insert(cuentaBE)
        Else
            cuentaBL.Update(cuentaBE)
        End If

        Call Avisar("Listo!")
        Call Cargar_Data()
        Call btn_cancelar_Click(sender, e)

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_cuentas.Rows.Count = 0 Then Exit Sub
        If dgv_cuentas.CurrentRow Is Nothing Then Exit Sub

        txt_cod.Text = dgv_cuentas.CurrentRow.Cells("col_id").Value
        txt_des.Text = dgv_cuentas.CurrentRow.Cells("col_des").Value
        txt_num_cta.Text = dgv_cuentas.CurrentRow.Cells("col_num").Value.ToString
        cmb_moneda.SelectedValue = dgv_cuentas.CurrentRow.Cells("col_mon").Value
        cmb_tipo_doc.SelectedValue = dgv_cuentas.CurrentRow.Cells("col_tipo").Value
        txtAnexo.Text = IIf(String.IsNullOrEmpty(dgv_cuentas.CurrentRow.Cells("col_anexo").Value.ToString), "", dgv_cuentas.CurrentRow.Cells("col_anexo").Value)
        bol_nuevo = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        tc_bancos.SelectedIndex = 1
        txt_cod.Enabled = False
        txt_des.Focus()
        Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_cuentas.Rows.Count = 0 Then Exit Sub
        If dgv_cuentas.CurrentRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim bancoBL As New ClsOperaciones.ACCOUNT_BANK
            Dim bancoBE As New ClsEntidades.ACCOUNT_BANK
            bancoBE.BANK_ID = pCodBanco
            bancoBE.ACCOUNT_BANK_ID = dgv_cuentas.CurrentRow.Cells("col_id").Value.ToString
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
    End Sub


    Private Sub cmb_moneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_moneda.SelectedIndexChanged, cmb_tipo_doc.SelectedIndexChanged

    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_cta.Focus()
        End If
    End Sub

    Private Sub txt_num_cta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_cta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F1 Then
            Ayuda_Cta_Contable()
        End If
    End Sub

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_tipo_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tipo_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub Ayuda_TipoAnexo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_ANEXO_BANCOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipos de Anexos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtAnexo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Cta_Contable()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_num_cta.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtAnexo.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
    Private Sub txtAnexo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtAnexo.MouseDoubleClick
        Ayuda_TipoAnexo()
    End Sub

    Private Sub txtAnexo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnexo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F1 Then
            Ayuda_TipoAnexo()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txt_num_cta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_num_cta.MouseDoubleClick
        Ayuda_Cta_Contable()
    End Sub
End Class