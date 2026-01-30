Imports System.Windows.Forms
Imports LibComunVar

Public Class FrmReporteDocumentosCancelados

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDetalleCliente As DataTable
    Dim dtDetalleVendedor As DataTable


 

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
            End If
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

    Private Sub FrmReporteDocumentosCancelados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub


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

    Private Sub ImprimirDocumentosCancelados()
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("PlanillaDocumentosCobro")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDocumentosCancelados(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txtclienteInicial.Text, txtclienteFinal.Text, txtVendedorInicial.Text, txtVendedorFinal.Text)
            If dtImprimir.Rows.Count() <> 0 Then
                Dim clienteInicial As String = txtclienteInicial.Text & " : " & txtclienteInicialDesc.Text
                Dim clientefinal As String = txtclienteFinal.Text & " : " & txtclienteFinalDesc.Text
                Dim VendedorInicial As String = txtVendedorInicial.Text & " : " & txtvendedorInicialDesc.Text
                Dim VendedorFinal As String = txtVendedorInicial.Text & " : " & txtvendedorFinDesc.Text
                'CrystalBL.Muestra_Reporte("rpt_PlanillaDocumentosCobro.rpt", "", "", "", "@FECHA_INICIAL;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FINAL;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "@CLIENTE_INICIAL;" & txtclienteInicial.Text, "@CLIENTE_FINAL;" & txtclienteFinal.Text, "@VENDEDOR_INICIAL;" & txtVendedorInicial.Text, "@VENDEDOR_FINAL;" & txtVendedorFinal.Text, "@CLI_INI;" & clienteInicial, "@CLI_FIN;" & clientefinal, "@VEN_INI;" & VendedorInicial, "@VEN_FIN;" & VendedorFinal)
                crystalBL.Muestra_Reporte("rpt_PlanillaDocumentosCobro.rpt", dtImprimir, "", "", "@CLI_INI;" & txtclienteInicial.Text, "@CLI_FIN;" & txtclienteFinal.Text, "@VEN_INI;" & txtVendedorInicial.Text, "@VEN_FIN;" & txtVendedorFinal.Text, "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))

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
        ImprimirDocumentosCancelados()
    End Sub

    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        If checkClientes.Checked Then
            reporteBL = New ClsBuscar
            dtDetalleCliente = New DataTable
            Dim Cadena As String = String.Empty
            Dim CodigoC As String = String.Empty
            Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM CUSTOMER "
            dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleCliente.Rows.Count() <> 0 Then
                CodigoC = String.Empty
                CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleCliente = New DataTable("DetallesClientes")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM CUSTOMER  WHERE ID= '" & CodigoC & "'"
                dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleCliente.Rows.Count() <> 0 Then
                    txtclienteInicial.Text = dtDetalleCliente.Rows(0).Item(0).ToString
                    txtclienteInicialDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
                Else
                    txtclienteInicial.Text = String.Empty
                    txtclienteInicialDesc.Text = String.Empty
                End If
            End If
            If txtclienteInicial.Text = String.Empty Then Exit Sub
            reporteBL = New ClsBuscar
            dtDetalleCliente = New DataTable
            Cadena = String.Empty
            Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM CUSTOMER "
            dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleCliente.Rows.Count() <> 0 Then
                CodigoC = String.Empty
                CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleCliente = New DataTable("DetallesClientes")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM CUSTOMER  WHERE ID= '" & CodigoC & "'"
                dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleCliente.Rows.Count() <> 0 Then
                    txtclienteFinal.Text = dtDetalleCliente.Rows(0).Item(0).ToString
                    txtclienteFinalDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
                Else
                    txtclienteFinal.Text = String.Empty
                    txtclienteFinalDesc.Text = String.Empty
                End If
            End If
        Else
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteFinal.Text = String.Empty
            txtclienteFinalDesc.Text = String.Empty
        End If

    End Sub

    Private Sub checkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedor.CheckedChanged

        If checkVendedor.Checked = True Then
            reporteBL = New ClsBuscar
            dtDetalleVendedor = New DataTable
            Dim Cadena As String = String.Empty
            Dim CodigoV As String = String.Empty
            Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM SALES_REP "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesVendedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM SALES_REP  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtVendedorInicial.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtvendedorInicialDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txtVendedorInicial.Text = String.Empty
                    txtvendedorInicialDesc.Text = String.Empty
                End If
            End If
            If txtVendedorInicial.Text = String.Empty Then Exit Sub
            Cadena = String.Empty
            Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM SALES_REP "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesVendedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM SALES_REP  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtVendedorFinal.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtvendedorFinDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txtVendedorFinal.Text = String.Empty
                    txtvendedorFinDesc.Text = String.Empty
                End If
            End If
        Else
            txtVendedorInicial.Text = String.Empty
            txtvendedorInicialDesc.Text = String.Empty
            txtVendedorFinal.Text = String.Empty
            txtvendedorFinDesc.Text = String.Empty
        End If



    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class