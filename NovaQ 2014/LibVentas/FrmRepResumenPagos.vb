Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmRepResumenPagos
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmRepResumenPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
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

    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
        End If
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorInicial.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
    End Sub

    Private Sub txtVendedorFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorFinal.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
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
            Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM VENDOR "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM VENDOR  WHERE ID= '" & CodigoV & "'"
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
            Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM VENDOR "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM VENDOR  WHERE ID= '" & CodigoV & "'"
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
            sql = "COMPRAS_SP_S_VENDOR"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Proveedor"
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
    Private Sub txtdocumentoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumentoInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Documento(txtdocumentoInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub txtdocumentoInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtdocumentoInicial.MouseDoubleClick
        Ayuda_Documento(txtdocumentoInicial, txtdocumentoInicialDesc)
    End Sub

    Private Sub txtdocumentoFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumentoFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Documento(txtdocumentoFinal, txtdocumentoFinalDesc)
        End If
    End Sub


    Private Sub txtdocumentoFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtdocumentoFinal.MouseDoubleClick
        Ayuda_Documento(txtdocumentoFinal, txtdocumentoFinalDesc)
    End Sub
    Private Sub Ayuda_Documento(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_RECEIVABLE_TIPO_DOCUMENTO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Tipo de Documento"
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

    Private Sub checkDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles checkDocumentos.CheckedChanged
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleVendedor As New DataTable
        If checkDocumentos.Checked = True Then
            gb_documentos.Enabled = False
            reporteBL = New ClsBuscar
            dtDetalleVendedor = New DataTable
            Dim Cadena As String = String.Empty
            Dim CodigoV As String = String.Empty
            Cadena = "SELECT MIN(TYPE_ID) AS [CODIGO]  FROM DBO.DOCUMENT_TYPE "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesDocumento")
                Cadena = String.Empty
                Cadena = "SELECT TYPE_ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM dbo.DOCUMENT_TYPE  WHERE TYPE_ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtdocumentoInicial.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtdocumentoInicialDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txtdocumentoInicial.Text = String.Empty
                    txtdocumentoInicialDesc.Text = String.Empty
                End If
            End If
            'If cboOpcionTipoDoc.Text <> "GS" Then
            '    If txtVendedorInicial.Text = String.Empty Then Exit Sub
            'End If
            Cadena = String.Empty
            Cadena = "SELECT MAX(TYPE_ID) AS [CODIGO]  FROM DBO.DOCUMENT_TYPE "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesDocumento")
                Cadena = String.Empty
                Cadena = "SELECT TYPE_ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM dbo.DOCUMENT_TYPE  WHERE TYPE_ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txtdocumentoFinal.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txtdocumentoFinalDesc.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txtdocumentoFinal.Text = String.Empty
                    txtdocumentoFinalDesc.Text = String.Empty
                End If
            End If
        Else
            gb_documentos.Enabled = True
            txtdocumentoInicial.Text = String.Empty
            txtdocumentoInicialDesc.Text = String.Empty
            txtdocumentoFinal.Text = String.Empty
            txtdocumentoFinalDesc.Text = String.Empty
        End If
    End Sub

    Private Sub rb_cliente_Click(sender As Object, e As EventArgs) Handles rb_cliente.Click
        blank()
        pnl_vendedor.Visible = False
        pnl_cliente.Visible = True
        pnl_documento.Visible = False
    End Sub

    Private Sub rb_vendedor_Click(sender As Object, e As EventArgs) Handles rb_vendedor.Click
        blank()
        pnl_vendedor.Visible = True
        pnl_cliente.Visible = False
        pnl_documento.Visible = False
    End Sub

    Private Sub rb_documento_Click(sender As Object, e As EventArgs) Handles rb_documento.Click
        blank()
        pnl_vendedor.Visible = False
        pnl_cliente.Visible = False
        pnl_documento.Visible = True
    End Sub
    Public Sub blank()
        checkVendedor.Checked = False
        checkClientes.Checked = False
        checkDocumentos.Checked = False
        gb_vendedor.Enabled = True
        gb_clientes.Enabled = True
        gb_documentos.Enabled = True
        txtclienteInicial.Text = ""
        txtclienteInicialDesc.Text = ""
        txtclienteFinal.Text = ""
        txtclienteFinalDesc.Text = ""
        txtvendedorFinDesc.Text = ""
        txtvendedorInicialDesc.Text = ""
        txtVendedorInicial.Text = ""
        txtVendedorFinal.Text = ""
        txtdocumentoInicial.Text = ""
        txtdocumentoInicialDesc.Text = ""
        txtdocumentoFinal.Text = ""
        txtdocumentoFinalDesc.Text = ""
    End Sub
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
        If Validaciones(Ref_fecIni, Ref_fecFin) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        Dim Filtro_1 As String = ""
        Dim Filtro_2 As String = ""
        Dim _opcion As String = ""

        If rb_cliente.Checked = True Then
            If checkClientes.Checked = True Then
                Flag_Todos = "SI"
            Else
                Flag_Todos = "NO"
                If txtclienteInicial.Text = "" Then
                    MsgBox("Seleccione un proveedor.", MsgBoxStyle.Critical)
                    txtclienteInicial.Select()
                    Exit Sub
                ElseIf txtclienteFinal.Text = "" Then
                    MsgBox("Seleccione un proveedor.", MsgBoxStyle.Critical)
                    txtclienteFinal.Select()
                    Exit Sub
                End If
            End If
            _cliente_inicial = txtclienteInicial.Text
            _cliente_final = txtclienteFinal.Text
            _opcion = "1"
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
            _opcion = "2"
        End If

        If rb_documento.Checked = True Then
            If checkDocumentos.Checked = True Then
                Flag_Todos = "SI"
            Else
                Flag_Todos = "NO"

                If txtdocumentoInicial.Text = "" Then
                    MsgBox("Seleccione un Documento.", MsgBoxStyle.Critical)
                    txtdocumentoInicial.Select()
                    Exit Sub
                End If


                If txtdocumentoFinal.Text = "" Then
                    MsgBox("Seleccione un Documento.", MsgBoxStyle.Critical)
                    txtdocumentoFinal.Select()
                    Exit Sub
                End If

            End If
            _documento_inicial = txtdocumentoInicial.Text
            _documento_final = txtdocumentoFinal.Text
            _opcion = "3"
        End If

        MostrarReporte(Ref_fecIni, Ref_fecFin, Flag_Todos, _cliente_inicial, _cliente_final, _vendedor_inicial, _vendedor_final, _documento_inicial, _documento_final, _opcion)
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
            If FechaIni = String.Empty Or FechaFin = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function
    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, ByVal documento_final As String, ByVal opcion As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarResumenPagos(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final, documento_inicial, documento_final, opcion)
            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""
            If rb_cliente.Checked = True Then
                Nombre_rep = "REPRESUMENPAGOSCLIENTE.rpt"
                filtro_uno = txtclienteInicialDesc.Text
                filtro_dos = txtclienteFinalDesc.Text
            ElseIf rb_vendedor.Checked = True Then
                Nombre_rep = ".rpt"
                filtro_uno = txtvendedorInicialDesc.Text
                filtro_dos = txtvendedorFinDesc.Text
            ElseIf rb_documento.Checked = True Then
                Nombre_rep = "REPRESUMENPAGOSDOCUMENTO.rpt"
                filtro_uno = txtdocumentoInicial.Text
                filtro_dos = txtdocumentoFinal.Text
            End If

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

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub txtVendedorFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
        End If
    End Sub
End Class