Imports System.Windows.Forms

Public Class frm_CO_LT_BuscaAnexo

    Public ls_anexo As New List(Of String)
    Public tipoAnexo As Integer
    Public bol_aceptar As Boolean = False
    Dim dv_data As DataView

    Private Sub frm_CO_LT_BuscaAnexo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub frm_CO_LT_BuscaAnexo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_campo.SelectedIndex = 1
        txt_filtro.Text = ""
        Dim fq As New ClsOperaciones.freeQuery
        dv_data = fq.get_Annexed_Ayuda(tipoAnexo).DefaultView
        dgv_Anexos.DataSource = dv_data
        fq = Nothing
        dgv_Anexos.Columns(0).Width = 100
        dgv_Anexos.Columns(1).Width = 400
    End Sub

    Private Sub txt_filtro_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_Aceptar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            bol_aceptar = False
            Me.Close()
        End If
        If e.KeyCode = Keys.Down Then
            dgv_Anexos.Focus()
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        If txt_filtro.Text = "" Then
            dv_data.RowFilter = ""
        Else
            dv_data.RowFilter = cmb_campo.Text & " like '%" & txt_filtro.Text.Trim() & "%'"
        End If
    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        ls_anexo.Clear()

        If dgv_Anexos.RowCount > 0 Then
            Dim ff As DataGridViewRow = dgv_Anexos.CurrentRow
            If ff Is Nothing Then
                'ls_anexo.Add(dgv_Anexos.CurrentRow.Cells("RUC").Value.ToString())
                'ls_anexo.Add(dgv_Anexos.CurrentRow.Cells("DESCRIPCION").Value.ToString())
                'bol_aceptar = True
                'Me.Close()
                bol_aceptar = False
                Me.Close()
            Else
                'bol_aceptar = False
                'Me.Close()
                ls_anexo.Add(dgv_Anexos.CurrentRow.Cells("RUC").Value.ToString())
                ls_anexo.Add(dgv_Anexos.CurrentRow.Cells("DESCRIPCION").Value.ToString())
                bol_aceptar = True
                Me.Close()
            End If
        Else
            bol_aceptar = False
            Me.Close()
        End If
    End Sub

    Private Sub dgv_Anexos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_Anexos.KeyDown
        If e.KeyCode = Keys.Up Then
            If dgv_Anexos.CurrentRow.Index = 0 Then
                txt_filtro.Focus()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            btn_Aceptar_Click(sender, e)
        End If
    End Sub
End Class