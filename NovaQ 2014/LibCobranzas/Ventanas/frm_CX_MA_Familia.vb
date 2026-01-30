Imports System.Windows.Forms

Public Class frm_CX_MA_Familia
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

    Private Sub frm_CX_MA_Familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Data()
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub Cargar_Data()
        Dim familiaBL As New ClsOperaciones.FAMILY
        dgv_familia.DataSource = familiaBL.get_familias()
        dgv_familia.AutoResizeColumns()
        dgv_familia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        familiaBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        tc_familia.SelectedIndex = 1
        gb_data.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
        txt_cod.Focus()
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
        If txt_abreviatura.Text.Trim = "" Then
            Call Avisar("Ingrese el codigo abreviado de la Familia.")
            txt_abreviatura.Focus()
            Exit Sub
        End If

        Dim familiaBL As New ClsOperaciones.FAMILY
        Dim familiaBE As New ClsEntidades.FAMILY

        With familiaBE
            .ID = txt_cod.Text.Trim
            .NAME = txt_des.Text.Trim
            .ABREVITURA = txt_abreviatura.Text.Trim
        End With

        If bol_nuevo Then
            familiaBL.Insert(familiaBE)
            Avisar("Generación de Familia correctamente!")
        Else
            familiaBL.Update(familiaBE)
            Avisar("Modificaión de Familia correctamente!")
        End If

        familiaBE = Nothing
        familiaBL = Nothing
        Call btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_familia.Rows.Count = 0 Then Exit Sub
        If dgv_familia.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)

        txt_cod.Text = dgv_familia.CurrentRow.Cells("col_id").Value
        txt_des.Text = dgv_familia.CurrentRow.Cells("col_des").Value
        txt_abreviatura.Text = dgv_familia.CurrentRow.Cells("col_codigo").Value

        bol_nuevo = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        tc_familia.SelectedIndex = 1
        txt_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_familia.Rows.Count = 0 Then Exit Sub
        If dgv_familia.CurrentRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim familiaBL As New ClsOperaciones.FAMILY
            Dim familiaBE As New ClsEntidades.FAMILY
            familiaBE.ID = dgv_familia.CurrentRow.Cells("col_id").Value.ToString
            familiaBL.Delete(familiaBE)
            familiaBE = Nothing
            familiaBL = Nothing
            Call Avisar("Eliminación exitosa!")
            Call Cargar_Data()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_familia.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
        Cargar_Data()
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

    Private Sub btn_lineas_Click(sender As Object, e As EventArgs) Handles btn_lineas.Click
        If dgv_familia.Rows.Count = 0 Then Exit Sub
        If dgv_familia.CurrentRow Is Nothing Then Exit Sub

        Dim f As New frm_CX_MA_Familia_Lineas
        f.pCodFamilia = dgv_familia.CurrentRow.Cells("col_id").Value.ToString
        f.ShowDialog()
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub txt_abreviatura_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_abreviatura.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub
End Class