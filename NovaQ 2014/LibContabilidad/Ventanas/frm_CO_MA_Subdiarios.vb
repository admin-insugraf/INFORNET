Imports System.Windows.Forms

Public Class frm_CO_MA_Subdiarios

    Dim bol_nuevo As Boolean = False

    Private Sub frm_CO_MA_Subdiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Combo()
        Call Cargar_Datos()
        Call Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Combo()
        Dim operacionBL As New ClsOperaciones.CO_TB_OPERACION
        cmb_Ope.DataSource = operacionBL.get_OperacionesTodos()
        cmb_Ope.DisplayMember = "OP_DESCRIPCION"
        cmb_Ope.ValueMember = "OP_ID"
        operacionBL = Nothing
    End Sub

    Private Sub Cargar_Datos()
        Dim subdiarioBL As New ClsOperaciones.CO_TB_SUBDIARIO
        Dim dt_data As DataTable = subdiarioBL.get_Subdiarios
        dgv_Lista.DataSource = dt_data
        subdiarioBL = Nothing

        For i As Integer = 0 To dgv_Lista.ColumnCount - 1
            dgv_Lista.Columns(i).Visible = False
        Next

        dgv_Lista.Columns("SD_ID").Visible = True
        dgv_Lista.Columns("SD_DESCRIPCION").Visible = True

        dgv_Lista.Columns("SD_ID").HeaderText = "Numero"
        dgv_Lista.Columns("SD_DESCRIPCION").HeaderText = "Descripcion"
        dgv_Lista.Columns("SD_DESCRIPCION").Width = 350

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles(gb_data)

        chk_ape.Checked = False
        chk_cie.Checked = False
        chk_estado.Checked = True
        chk_DifCam.Checked = False
        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True

        txt_cod.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If txt_cod.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el codigo", "Sistema")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese la descripcion", "Sistema")
            txt_des.Focus()
            Exit Sub
        End If


        Dim subdiarioBL As New ClsOperaciones.CO_TB_SUBDIARIO

        If bol_nuevo Then
            subdiarioBL.Insert(txt_cod.Text.Trim, txt_des.Text.Trim, txt_abre.Text.Trim, IIf(chk_ape.Checked, 1, 0), IIf(chk_cie.Checked, 1, 0), IIf(chk_estado.Checked, 1, 0), cmb_Ope.SelectedValue, IIf(chk_DifCam.Checked, 1, 0))
        Else
            subdiarioBL.Update(txt_cod.Text.Trim, txt_des.Text.Trim, txt_abre.Text.Trim, IIf(chk_ape.Checked, 1, 0), IIf(chk_cie.Checked, 1, 0), IIf(chk_estado.Checked, 1, 0), cmb_Ope.SelectedValue, IIf(chk_DifCam.Checked, 1, 0))
        End If

        subdiarioBL = Nothing

        MessageBox.Show("Listo!", "Sistema")

        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        Call Limpiar_Controles(gb_data)

        bol_nuevo = False
        chk_cie.Checked = False
        chk_ape.Checked = False
        chk_estado.Checked = False
        chk_DifCam.Checked = False

        txt_cod.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ID").Value.ToString()
        txt_des.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_DESCRIPCION").Value.ToString()
        txt_abre.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ABREVIATURA").Value.ToString()
        cmb_Ope.SelectedValue = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_IDOPERACION").Value.ToString()
        chk_ape.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ES_APER").Value.ToString() = "1", True, False)
        chk_cie.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ES_CIER").Value.ToString() = "1", True, False)
        chk_estado.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ISTATUS").Value.ToString() = "1", True, False)
        chk_DifCam.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ES_DIFCAM").Value.ToString() = "1", True, False)
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        tc_Lista.SelectedIndex = 1

    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_Lista.SelectedIndex = 0
        gb_data.Enabled = False
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_Lista.Rows.Count > 0 Then
            If MessageBox.Show("Seguro de eliminar?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim cod As String = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("SD_ID").Value.ToString()
                Dim subdiarioBL As New ClsOperaciones.CO_TB_SUBDIARIO
                subdiarioBL.Delete(cod)
                subdiarioBL = Nothing
                MessageBox.Show("Listo!", "Sistema")
                Call Cargar_Datos()
            End If
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_abre.Focus()
        End If
    End Sub

    Private Sub txt_abre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_abre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_Ope.Focus()
        End If
    End Sub
End Class