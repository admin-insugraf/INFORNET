Public Class frm_AF_MA_Categoria
    Dim bol_nuevo As Boolean = False

    Private Sub frm_AF_MA_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Call Cargar_Datos()
        Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Datos()
        Dim cateBL As New ClsOperaciones.AF_MA_CATEGORIA
        dgv_lista.DataSource = cateBL.get_Categoria_01()
        dgv_lista.Columns("CA_ID").HeaderText = "Codigo"
        dgv_lista.Columns("CA_DESCRIPCION").HeaderText = "Descripción"
        dgv_lista.Columns("CA_TASA").HeaderText = "Tasa"
        dgv_lista.Columns("CA_ESTADO").Visible = False
        dgv_lista.AutoResizeColumns()
        dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        cateBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        tc_cat.SelectedIndex = 1
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Limpiar_Controles(gb_datos)
        chk_estado.Checked = True
        gb_datos.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
        txt_cod.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text.Trim.Length = 0 Then
            MsgBox("Ingrese codigo", MsgBoxStyle.Exclamation)
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            MsgBox("Ingrese la descripción", MsgBoxStyle.Exclamation)
            txt_des.Focus()
            Exit Sub
        End If

        If txt_tasa.Text.Trim.Length = 0 Then
            MsgBox("Ingrese una tasa", MsgBoxStyle.Exclamation)
            txt_tasa.Focus()
            Exit Sub
        End If

        Dim catBE As New ClsEntidades.AF_MA_CATEGORIA
        Dim catBL As New ClsOperaciones.AF_MA_CATEGORIA

        With catBE
            .CA_ID = txt_cod.Text.Trim
            .CA_DESCRIPCION = txt_des.Text.Trim
            .CA_TASA = txt_tasa.Text.Trim
            .CA_ESTADO = IIf(chk_estado.Checked, 1, 0)
        End With

        If bol_nuevo Then
            catBL.Insert(catBE)
        Else
            catBL.Update(catBE)
        End If

        catBE = Nothing
        catBL = Nothing

        MsgBox("Categoria registrado correctamente.", MsgBoxStyle.Information)
        Call Cargar_Datos()
        Tool_Cancelar_Click(sender, e)


    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        tc_cat.SelectedIndex = 1
        bol_nuevo = False
        gb_datos.Enabled = True
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        txt_cod.Text = dgv_lista.CurrentRow.Cells("CA_ID").Value
        txt_des.Text = dgv_lista.CurrentRow.Cells("CA_DESCRIPCION").Value
        txt_tasa.Text = dgv_lista.CurrentRow.Cells("CA_TASA").Value
        chk_estado.Checked = IIf(dgv_lista.CurrentRow.Cells("CA_ESTADO").Value = 1, True, False)

        txt_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_cat.SelectedIndex = 0
        gb_datos.Enabled = False
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de Eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim catBE As New ClsEntidades.AF_MA_CATEGORIA
            Dim catBL As New ClsOperaciones.AF_MA_CATEGORIA
            With catBE
                .CA_ID = dgv_lista.CurrentRow.Cells("CA_ID").Value
            End With
            catBL.Delete(catBE)
            catBE = Nothing
            catBL = Nothing
            MsgBox("Categoria eliminado correctamente", MsgBoxStyle.Information)
            Call Cargar_Datos()
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class