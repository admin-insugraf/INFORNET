Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmProyeccionCobranza
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub rb_cliente_Click(sender As Object, e As EventArgs) Handles rb_cliente.Click
        blank()
        pnl_vendedor.Visible = False
        pnl_cliente.Visible = True
    End Sub

    Private Sub rb_vendedor_Click(sender As Object, e As EventArgs) Handles rb_vendedor.Click
        blank()
        pnl_cliente.Visible = False
        pnl_vendedor.Visible = True
    End Sub
    Public Sub blank()
        checkVendedor.Checked = False
        gb_vendedor.Enabled = True
        gb_clientes.Enabled = True
        checkClientes.Checked = False
        txtclienteInicial.Text = ""
        txtclienteInicialDesc.Text = ""
        txtvendedorFinDesc.Text = ""
        txtvendedorFinDesc.Text = ""
    End Sub

    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleCliente As New DataTable

        If checkClientes.Checked Then
            gb_clientes.Enabled = False
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
            gb_clientes.Enabled = True
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteFinal.Text = String.Empty
            txtclienteFinalDesc.Text = String.Empty
        End If
    End Sub

    Private Sub checkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedor.CheckedChanged
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleVendedor As New DataTable
        If checkVendedor.Checked = True Then
            gb_vendedor.Enabled = False
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
            'If cboOpcionTipoDoc.Text <> "GS" Then
            '    If txtVendedorInicial.Text = String.Empty Then Exit Sub
            'End If
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
            gb_vendedor.Enabled = True
            txtVendedorInicial.Text = String.Empty
            txtvendedorInicialDesc.Text = String.Empty
            txtVendedorFinal.Text = String.Empty
            txtvendedorFinDesc.Text = String.Empty
        End If
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
    End Sub

    Private Sub txtclienteFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txtclienteFinal, txtclienteFinalDesc)
        End If
    End Sub

    Private Sub txtclienteFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteFinal.MouseDoubleClick
        Ayuda_Cliente(txtclienteFinal, txtclienteFinalDesc)
    End Sub

    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
        End If
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorInicial.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
    End Sub

    Private Sub txtVendedorFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
        End If
    End Sub

    Private Sub txtVendedorFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorFinal.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
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

    Private Sub FrmProyeccionCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.MinDate = CDate(ClsVarComun.FechaSistema)
        dtpfechaFin.MinDate = CDate(ClsVarComun.FechaSistema)
        dtpfechaInicio.Value = CDate(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim _cliente_inicial As String = String.Empty
        Dim _cliente_final As String = String.Empty
        Dim _vendedor_inicial As String = String.Empty
        Dim _vendedor_final As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        Dim Filtro_1 As String = ""
        Dim Filtro_2 As String = ""

        If rb_cliente.Checked = True Then
            If checkClientes.Checked = True Then
                Flag_Todos = "SI"
            Else
                Flag_Todos = "NO"
                If txtclienteInicial.Text = "" Then
                    MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                    txtclienteInicial.Select()
                    Exit Sub
                ElseIf txtclienteFinal.Text = "" Then
                    MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                    txtclienteFinal.Select()
                    Exit Sub
                End If
            End If
            _cliente_inicial = txtclienteInicial.Text
            _cliente_final = txtclienteFinal.Text
        End If
        If rb_vendedor.Checked = True Then
            If checkVendedor.Checked = True Then
                Flag_Todos = "SI"
            Else
                Flag_Todos = "NO"

                If txtVendedorInicial.Text = "" Then
                    MsgBox("Seleccione un vendedor.", MsgBoxStyle.Critical)
                    txtVendedorInicial.Select()
                    Exit Sub
                End If


                If txtVendedorFinal.Text = "" Then
                    MsgBox("Seleccione un vendedor.", MsgBoxStyle.Critical)
                    txtVendedorFinal.Select()
                    Exit Sub
                End If

            End If
            _vendedor_inicial = txtVendedorInicial.Text
            _vendedor_final = txtVendedorFinal.Text
        End If

        MostrarReporte(Ref_fecIni, Ref_fecFin, Flag_Todos, _cliente_inicial, _cliente_final, _vendedor_inicial, _vendedor_final)
    End Sub
    Private Function Validaciones(ByRef FechaIni As String, ByRef FechaFin As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            FechaIni = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            FechaFin = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            'validacion
            If txtplazo1.Text = "" Or Val(txtplazo1.Text) = 0 Then
                MsgBox("Falta ingresar un plazo de días!.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtplazo5.Text = "" Or Val(txtplazo5.Text) = 0 Then
                MsgBox("Falta ingresar un plazo de días!.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtplazo2.Text = "" Or Val(txtplazo2.Text) = 0 Then
                MsgBox("Falta ingresar un plazo de días!.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtplazo3.Text = "" Or Val(txtplazo3.Text) = 0 Then
                MsgBox("Falta ingresar un plazo de días!.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If txtplazo4.Text = "" Or Val(txtplazo4.Text) = 0 Then
                MsgBox("Falta ingresar un plazo de días!.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
            If FechaIni = String.Empty Or FechaFin = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function
    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarReporteProyCobranza(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final)
            Dim Nombre_rep As String = ""
            If rb_cliente.Checked = True Then
                Nombre_rep = "REPPROYECCOBRANZA_CLIENTE.rpt"
            ElseIf rb_vendedor.Checked = True Then
                Nombre_rep = "REPPROYECCOBRANZA_VENDEDOR.rpt"
            End If


            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, "", "", "", "XVEN1;" & txtvendedorInicialDesc.Text, "XVEN2;" & txtvendedorFinDesc.Text, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                                     "XPLAZO1;" & Val(txtplazo1.Text), "XPLAZO2;" & Val(txtplazo2.Text), "XPLAZO3;" & Val(txtplazo3.Text), "XPLAZO4;" & Val(txtplazo4.Text), "XPLAZOMAS;" & Val(txtplazo5.Text))
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtplazo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo2.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo3.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo4.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtplazo5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo5.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class