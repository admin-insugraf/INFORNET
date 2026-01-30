Imports System.Windows.Forms

Public Class frm_CO_MA_TipoAnexos
    Dim bol_nuevo As Boolean = False
    Private Sub frm_CO_MA_TipoAnexos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Inicializa_Tool(ToolS_Mantenimiento)
        gb_data.Enabled = False
    End Sub

    Public Sub Cargar_Datos()
        Dim tipAnexBL As New ClsOperaciones.CO_TB_TIPO_ANEXO
        dgv_Lista.DataSource = tipAnexBL.get_Tipos()
        tipAnexBL = Nothing
        dgv_Lista.Columns(0).Width = 70
        dgv_Lista.Columns(0).HeaderText = "Codigo"
        dgv_Lista.Columns(1).HeaderText = "Descripcion"
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        txt_cod.Enabled = True

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles(gb_data)

        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True

        txt_cod.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        For i As Integer = 0 To dgv_Lista.Rows.Count - 1
            If dgv_Lista.Rows(i).Cells("TA_ID").Value.ToString().Equals(txt_cod.Text) Then
                MessageBox.Show("El codigo ya existe, no se puede continuar.", "Sistema")
                txt_cod.Focus()
                Exit Sub
            End If
        Next
        Dim tipAnexBL As New ClsOperaciones.CO_TB_TIPO_ANEXO
        If bol_nuevo Then
            tipAnexBL.Insert(CInt(txt_cod.Text), txt_des.Text.Trim())
        Else
            tipAnexBL.Update(CInt(txt_cod.Text), txt_des.Text.Trim())
        End If
        tipAnexBL = Nothing

        MessageBox.Show("Listo!", "Sistema")

        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)
    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        bol_nuevo = False
        txt_cod.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("TA_ID").Value.ToString()
        txt_des.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("TA_DESCRIPCION").Value.ToString()
        txt_cod.Enabled = False
        txt_des.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_Lista.SelectedIndex = 0
        gb_data.Enabled = False
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub
End Class