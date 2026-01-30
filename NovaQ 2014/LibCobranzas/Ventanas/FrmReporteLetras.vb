Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmReporteLetras

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub Ayuda_Cliente(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Vendedor(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Vendedor"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If txtclienteInicial.Text = String.Empty Then
                MsgBox("Debe seleccionar un cliente inicial", MsgBoxStyle.Information)
                txtclienteInicial.Focus()
                estado = False
            ElseIf txtclienteFinal.Text = String.Empty Then
                MsgBox("Debe seleccionar un cliente final", MsgBoxStyle.Information)
                txtclienteFinal.Focus()
                estado = False
            ElseIf txtVendedorInicial.Text = String.Empty Then
                MsgBox("Debe seleccionar un vendedor inicial", MsgBoxStyle.Information)
                txtVendedorInicial.Focus()
                estado = False
            ElseIf txtVendedorFinal.Text = String.Empty Then
                MsgBox("Debe seleccionar un vendedor final", MsgBoxStyle.Information)
                txtVendedorFinal.Focus()
                estado = False
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirLetras()
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteLetras(txtclienteInicial.Text, txtclienteFinal.Text, txtVendedorInicial.Text, txtVendedorFinal.Text)
            If dtImprimir.Rows.Count() <> 0 Then
                Dim clienteInicial As String = txtclienteInicial.Text & " : " & txtclienteInicialDesc.Text
                Dim clientefinal As String = txtclienteFinal.Text & " : " & txtclienteFinalDesc.Text

                Dim VendedorInicial As String = txtVendedorInicial.Text & " : " & txtvendedorInicialDesc.Text
                Dim VendedorFinal As String = txtVendedorInicial.Text & " : " & txtvendedorFinDesc.Text
                crystalBL.Muestra_Reporte("rpt_Estado_Letras.rpt", "", "", "", "@CLIENTE_INICIAL;" & txtclienteInicial.Text, "@CLIENTE_FINAL;" & txtclienteFinal.Text, "@VENDEDOR_INICIAL;" & txtVendedorInicial.Text, "@VENDEDOR_FINAL;" & txtVendedorFinal.Text, "@CLI_INI;" & clienteInicial, "@CLI_FIN;" & clientefinal, "@VEN_INI;" & VendedorInicial, "@VEN_FIN;" & VendedorFinal, "@TIPOCAMBIO;" & LibComunVar.ClsVarComun.TCVenta)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
    End Sub

    Private Sub txtclienteFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteFinal.MouseDoubleClick
        Ayuda_Cliente(txtclienteFinal, txtclienteFinalDesc)
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorInicial.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
    End Sub

    Private Sub txtVendedorFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorFinal.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
    End Sub



    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Validaciones() = False Then Exit Sub
        ImprimirLetras()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class