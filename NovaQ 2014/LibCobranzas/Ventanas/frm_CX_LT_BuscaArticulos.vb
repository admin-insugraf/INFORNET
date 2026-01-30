Imports System.Windows.Forms

Public Class frm_CX_LT_BuscaArticulos
    Dim dv_Data As New DataView
    Public ls_cliente As New List(Of String)
    Public bol_aceptar As Boolean = False
    Public bol_OnlyLote As Boolean = False

    Private Sub frm_CX_LT_BuscaArticulos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub
    Private Sub frm_CX_LT_BuscaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Articulos()
    End Sub

    Private Sub aceptar()
        If dgv_articulos.CurrentRow Is Nothing Then Exit Sub
        If dgv_articulos.RowCount = 0 Then Exit Sub

        ls_cliente.Clear()
        ls_cliente.Add(dgv_articulos.CurrentRow.Cells("col_cod").Value.ToString)
        ls_cliente.Add(dgv_articulos.CurrentRow.Cells("col_des").Value.ToString)
        ls_cliente.Add(dgv_articulos.CurrentRow.Cells("col_um").Value.ToString)

        bol_aceptar = True
        Me.Close()
    End Sub

    Private Sub Cargar_Articulos()
        Dim articuloBL As New ClsOperaciones.PART
        If bol_OnlyLote Then
            dv_Data = articuloBL.get_articulos_Ayuda_Lote.DefaultView
        Else
            dv_Data = articuloBL.get_articulos_Ayuda.DefaultView
        End If

        dgv_articulos.DataSource = dv_Data
        articuloBL = Nothing
    End Sub


    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub dgv_articulos_DoubleClick(sender As Object, e As EventArgs) Handles dgv_articulos.DoubleClick
        Call aceptar()
    End Sub

    Private Sub dgv_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_articulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call aceptar()
        End If
        If e.KeyCode = Keys.Up Then
            If dgv_articulos.CurrentRow Is Nothing Then Exit Sub
            If dgv_articulos.CurrentRow.Index = 0 Then
                txt_filtro.Focus()
            End If
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Call aceptar()
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Try
            If txt_filtro.Text.Length > 0 Then
                If chk_empieza.CheckAlign Then
                    dv_Data.RowFilter = "DES like '" & txt_filtro.Text.Trim & "%'"
                Else
                    dv_Data.RowFilter = "DES like '%" & txt_filtro.Text.Trim & "%'"
                End If
            Else
                dv_Data.RowFilter = ""
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class