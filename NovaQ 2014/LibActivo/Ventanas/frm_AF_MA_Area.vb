Imports System.Windows.Forms

Public Class frm_AF_MA_Area
    Dim bol_nuevo As Boolean = False
    Private Sub frm_AF_MA_Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Datos()
        Dim cateBL As New ClsOperaciones.AF_MA_AREA
        dgv_lista.DataSource = cateBL.get_areas
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
            MsgBox("Ingrese codigo")
            txt_cod.Focus()
            Exit Sub
        End If

        Dim catBE As New ClsEntidades.AF_MA_AREA
        Dim catBL As New ClsOperaciones.AF_MA_AREA

        With catBE
            .AR_ID = txt_cod.Text.Trim
            .AR_DESCRIPCION = txt_des.Text.Trim
            .AR_ESTADO = IIf(chk_estado.Checked, 1, 0)
        End With

        If bol_nuevo Then
            catBL.insert(catBE)
        Else
            catBL.update(catBE)
        End If

        catBE = Nothing
        catBL = Nothing
        Call Cargar_Datos()
        MsgBox("Listo!")
        Tool_Cancelar_Click(sender, e)
    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        txt_cod.Text = dgv_lista.CurrentRow.Cells("AR_ID").Value
        txt_des.Text = dgv_lista.CurrentRow.Cells("AR_DESCRIPCION").Value
        chk_estado.Checked = IIf(dgv_lista.CurrentRow.Cells("AR_ESTADO").Value = 1, True, False)

        txt_cod.Enabled = False
        txt_des.Focus()
        tc_cat.SelectedIndex = 1
    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_cat.SelectedIndex = 0
        gb_datos.Enabled = False
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de Eliminar?", MsgBoxStyle.Question, "Cuidado!") = MsgBoxResult.Yes Then
            Dim catBE As New ClsEntidades.AF_MA_AREA
            Dim catBL As New ClsOperaciones.AF_MA_AREA
            With catBE
                .AR_ID = dgv_lista.CurrentRow.Cells("AR_ID").Value
            End With
            catBL.delete(catBE)
            catBE = Nothing
            catBL = Nothing
            MsgBox("Listo!")
            Call Cargar_Datos()
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class