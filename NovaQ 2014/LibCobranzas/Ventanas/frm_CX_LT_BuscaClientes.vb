Public Class frm_CX_LT_BuscaClientes

    Dim dv_Data As New DataView
    Public ls_cliente As New List(Of String)
    Public bol_aceptar As Boolean = False

    Private Sub frm_CX_LT_BuscaClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub frm_CX_LT_BuscaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Clientes()
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        bol_aceptar = False
        Me.Close()
    End Sub

    Private Sub txt_filtro_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Down Then
            dgv_clientes.Focus()
        End If
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            bol_aceptar = False
            Me.Close()
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Try
            If txt_filtro.Text.Length > 0 Then
                If chk_empieza.CheckAlign Then
                    dv_Data.RowFilter = "CI_NAME like '" & txt_filtro.Text.Trim & "%'"
                Else
                    dv_Data.RowFilter = "CI_NAME like '%" & txt_filtro.Text.Trim & "%'"
                End If
            Else
                dv_Data.RowFilter = ""
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Cargar_Clientes()
        Dim clienteBL As New ClsOperaciones.CUSTOMER
        Dim dt_clientes As DataTable = clienteBL.get_Clientes()
        dv_Data = dt_clientes.DefaultView
        dgv_clientes.DataSource = dv_Data
        clienteBL = Nothing
    End Sub

    Private Sub dgv_clientes_DoubleClick(sender As Object, e As EventArgs) Handles dgv_clientes.DoubleClick
        Call aceptar()
    End Sub

    Private Sub aceptar()
        If dgv_clientes.CurrentRow Is Nothing Then Exit Sub
        If dgv_clientes.RowCount = 0 Then Exit Sub

        ls_cliente.Clear()
        ls_cliente.Add(dgv_clientes.CurrentRow.Cells("CI_ID").Value.ToString)
        ls_cliente.Add(dgv_clientes.CurrentRow.Cells("CI_NAME").Value.ToString)
        bol_aceptar = True
        Me.Close()
    End Sub

    Private Sub dgv_clientes_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles dgv_clientes.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Call aceptar()
        End If
        If e.KeyCode = Windows.Forms.Keys.Up Then
            If dgv_clientes.CurrentRow Is Nothing Then Exit Sub
            If dgv_clientes.CurrentRow.Index = 0 Then
                txt_filtro.Focus()
            End If
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Call aceptar()
    End Sub
End Class