Imports System.Windows.Forms

Public Class frm_AF_LT_AyudaActivo

    Public ent_activo As ClsEntidades.AF_MA_ACTIVO
    Public bol_aceptar As Boolean = False
    Dim dt_data As DataTable

    Private Sub frm_AF_LT_AyudaActivo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub frm_AF_LT_AyudaActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        dt_data = activoBL.get_Lista_05_AyudaActivos()
        dgv_ayuda.DataSource = dt_data
        dgv_ayuda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        activoBL = Nothing
    End Sub

    Private Sub Tool_aceptar_Click(sender As Object, e As EventArgs) Handles Tool_aceptar.Click

        If dgv_ayuda.RowCount = 0 Then Exit Sub
        If dgv_ayuda.CurrentRow Is Nothing Then Exit Sub

        ent_activo = New ClsEntidades.AF_MA_ACTIVO
        ent_activo.AC_IDACTIVO = dgv_ayuda.CurrentRow.Cells("AC_IDACTIVO").Value
        ent_activo.AC_ACTIVO_DES = dgv_ayuda.CurrentRow.Cells("AC_ACTIVO_DES").Value
        ent_activo.AC_CODIGO_ALT = dgv_ayuda.CurrentRow.Cells("AC_CODIGO_ALT").Value
        bol_aceptar = True
        Me.Close()

    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        bol_aceptar = False
        Me.Close()
    End Sub

    Private Sub txt_filtro_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Call Filtrar()
    End Sub

    Private Sub chk_comienza_CheckedChanged(sender As Object, e As EventArgs) Handles chk_comienza.CheckedChanged
        Call Filtrar()
    End Sub

    Private Sub Filtrar()
        Try
            If txt_filtro.Text.Trim = "" Then
                dt_data.DefaultView.RowFilter = Nothing
            End If

            If chk_comienza.Checked Then
                dt_data.DefaultView.RowFilter = "AC_ACTIVO_DES like '" & txt_filtro.Text.Trim & "%'"
            Else
                dt_data.DefaultView.RowFilter = "AC_ACTIVO_DES like '%" & txt_filtro.Text.Trim & "%'"
            End If
        Catch ex As Exception
            'dgv_ayuda.DataSource = dt_data.DefaultView.RowFilter = Nothing
        End Try

    End Sub

    Private Sub dgv_ayuda_DoubleClick(sender As Object, e As EventArgs) Handles dgv_ayuda.DoubleClick
        Tool_aceptar_Click(sender, e)
    End Sub
End Class