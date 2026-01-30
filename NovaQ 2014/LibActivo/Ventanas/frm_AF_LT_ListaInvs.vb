Public Class frm_AF_LT_ListaInvs
    Public gint_num_inv As Integer = 0

    Private Sub frm_AF_LT_ListaInvs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Lista()
    End Sub

    Private Sub Cargar_Lista()
        Dim inventarioBL As New ClsOperaciones.AF_LT_TOMA_INV_C
        Dim dt_tmp As DataTable = inventarioBL.get_Lista_Invs()
        inventarioBL = Nothing
        dgv_lista.DataSource = dt_tmp

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If dgv_lista.Rows.Count = 0 Then
            MsgBox("No hay Inventarios registrados.")
            gint_num_inv = 0
            Me.Close()
        End If

        If dgv_lista.CurrentRow Is Nothing Then
            gint_num_inv = 0
            Me.Close()
        End If

        gint_num_inv = dgv_lista.CurrentRow.Cells("col_NUMERO").Value
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        gint_num_inv = 0
        Me.Close()
    End Sub

    Private Sub dgv_lista_DoubleClick(sender As Object, e As EventArgs) Handles dgv_lista.DoubleClick
        Call btn_aceptar_Click(sender, e)
    End Sub
End Class