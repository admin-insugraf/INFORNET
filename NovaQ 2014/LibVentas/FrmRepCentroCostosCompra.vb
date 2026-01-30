Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmRepCentroCostosCompra
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmRepCentroCostosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleVendedor As New DataTable
        If checkClientes.Checked = True Then
            gb_clientes.Enabled = False
            reporteBL = New ClsBuscar
            dtDetalleVendedor = New DataTable
            Dim Cadena As String = String.Empty
            Dim CodigoV As String = String.Empty
            Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM dbo.CENTRO_COSTOS "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], DESCRIPTION AS [DESCRIPCION ]FROM dbo.CENTRO_COSTOS  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtclienteInicial.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtclienteInicialDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txtclienteInicial.Text = String.Empty
                    txtclienteInicialDesc.Text = String.Empty
                End If
            End If
            'If cboOpcionTipoDoc.Text <> "GS" Then
            '    If txtVendedorInicial.Text = String.Empty Then Exit Sub
            'End If
            Cadena = String.Empty
            Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM dbo.CENTRO_COSTOS "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], DESCRIPTION AS [DESCRIPCION ]FROM dbo.CENTRO_COSTOS  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtclienteFinal.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtclienteFinalDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
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

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Proveedor(txtclienteInicial, txtclienteInicialDesc)
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor(txtclienteInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub txtclienteFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteFinal.MouseDoubleClick
        Ayuda_Proveedor(txtclienteFinal, txtclienteFinalDesc)
    End Sub

    Private Sub txtclienteFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor(txtclienteFinal, txtclienteFinalDesc)
        End If
    End Sub
    Private Sub Ayuda_Proveedor(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_CENTROS_COSTOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Centros de Costo"
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

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Function Validaciones(ByRef FechaIni As String, ByRef FechaFin As String, ByRef cc_ini As String, ByRef cc_fin As String) As Boolean
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
            cc_ini = txtclienteInicial.Text
            cc_fin = txtclienteFinal.Text
            'validacion
            If FechaIni = String.Empty Or FechaFin = String.Empty Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim _cliente_inicial As String = String.Empty
        Dim _cliente_final As String = String.Empty
        Dim _vendedor_inicial As String = String.Empty
        Dim _vendedor_final As String = String.Empty
        Dim _documento_inicial As String = String.Empty
        Dim _documento_final As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin, _cliente_inicial, _cliente_final) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        Dim Filtro_1 As String = ""
        Dim Filtro_2 As String = ""
        Dim _opcion As String = ""

        If checkClientes.Checked = True Then
            Flag_Todos = "SI"
        Else
            Flag_Todos = "NO"
        End If

        MostrarReporte(Ref_fecIni, Ref_fecFin, Flag_Todos, _cliente_inicial, _cliente_final, _vendedor_inicial, _vendedor_final, _documento_inicial, _documento_final, _opcion)
    End Sub
    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                            ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, ByVal documento_final As String, ByVal opcion As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarRepCentrosCostos(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final)
            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""

            Nombre_rep = "REPCENTROSCOSTOSMOV.rpt"
            filtro_uno = txtclienteInicialDesc.Text
            filtro_dos = txtclienteFinalDesc.Text

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, "", "", "", "INICIO;" & filtro_uno, "FIN;" & filtro_dos, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class