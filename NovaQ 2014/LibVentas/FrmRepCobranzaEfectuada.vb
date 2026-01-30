Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmRepCobranzaEfectuada
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dt_tmp As DataTable
    Dim dtDatosCompany As DataTable
    Dim _opcion As String = ""
    Public GRUPO_COBRANZA As String

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


        If rb_cliente.Checked = True Then
            If checkClientes.Checked = True Then
                Flag_Todos = "SI"
            Else
                Flag_Todos = "NO"
                If txtclienteInicial.Text = "" Then
                    MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                    txtclienteInicial.Select()
                    Exit Sub
                    'ElseIf txtclienteFinal.Text = "" Then
                    '    MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                    '    txtclienteFinal.Select()
                    '    Exit Sub
                End If
            End If
            _cliente_inicial = txtclienteInicial.Text
            _cliente_final = txtclienteInicial.Text
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

            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""

            dtImprimir = reporteBL.EjecutarReporteCobranzaEfectuadaVendedor(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, _
                                                                            documento_inicial, documento_final, opcion, txt_cod_concepto.Text.Trim, GRUPO_COBRANZA)

            If rb_cliente.Checked = True Then
                Nombre_rep = "REP_COBRANZAS_EFECTUADAS_CLIENTE.rpt"
                filtro_uno = txtclienteInicialDesc.Text
                filtro_dos = txtclienteFinalDesc.Text
            ElseIf rb_vendedor.Checked = True Then
                Nombre_rep = "REP_COBRANZAS_EFECTUADAS_VENDEDOR.rpt"
                filtro_uno = txtvendedorInicialDesc.Text
                filtro_dos = txtvendedorFinDesc.Text
            ElseIf rb_documento.Checked = True Then
                Nombre_rep = "REP_COBRANZAS_EFECTUADAS_DOCUMENTO.rpt"
                filtro_uno = txtdocumentoInicial.Text
                filtro_dos = txtdocumentoFinal.Text
            End If

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                If rb_cliente.Checked = True Then
                    crystalBL.Muestra_Reporte(Nombre_rep, dtImprimir, "", "", "@FECHA_INICIAL;" & FechaIni, "@FECHA_FINAL;" & FechaFin, "@CLIENTE_INICIAL;" & cliente_inicial, "@CLIENTE_FINAL;" & cliente_final, "@OPCION_TODOS;" & TODOS, "INICIO;" & filtro_uno, "FIN;" & filtro_dos, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                ElseIf rb_vendedor.Checked = True Then
                    crystalBL.Muestra_Reporte(Nombre_rep, "", "", "", "INICIO;" & filtro_uno, "FIN;" & filtro_dos, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                ElseIf rb_documento.Checked = True Then
                    crystalBL.Muestra_Reporte(Nombre_rep, "", "", "", "@FECHA_INICIAL;" & FechaIni, "@FECHA_FINAL;" & FechaFin, "@DOCUMENTO_INICIAL;" & documento_inicial, "@DOCUMENTO_FINAL;" & documento_final, "@OPCION_TODOS;" & TODOS, "INICIO;" & filtro_uno, "FIN;" & filtro_dos, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                End If

            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
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
    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        txtclienteInicial.Enabled = Not checkClientes.Checked
        txtclienteInicialDesc.Enabled = Not checkClientes.Checked
        txtclienteInicial.Text = ""
        txtclienteInicialDesc.Text = ""
        'Dim reporteBL As New ClsBuscar
        'Dim dtDetalleCliente As New DataTable

        'If checkClientes.Checked Then
        '    gb_clientes.Enabled = False
        '    reporteBL = New ClsBuscar
        '    dtDetalleCliente = New DataTable
        '    Dim Cadena As String = String.Empty
        '    Dim CodigoC As String = String.Empty
        '    Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM CUSTOMER "
        '    dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        '    If dtDetalleCliente.Rows.Count() <> 0 Then
        '        CodigoC = String.Empty
        '        CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
        '        reporteBL = New ClsBuscar
        '        dtDetalleCliente = New DataTable("DetallesClientes")
        '        Cadena = String.Empty
        '        Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM CUSTOMER  WHERE ID= '" & CodigoC & "'"
        '        dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        '        If dtDetalleCliente.Rows.Count() <> 0 Then
        '            txtclienteInicial.Text = dtDetalleCliente.Rows(0).Item(0).ToString
        '            txtclienteInicialDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
        '        Else
        '            txtclienteInicial.Text = String.Empty
        '            txtclienteInicialDesc.Text = String.Empty
        '        End If
        '    End If
        '    If txtclienteInicial.Text = String.Empty Then Exit Sub
        '    reporteBL = New ClsBuscar
        '    dtDetalleCliente = New DataTable
        '    Cadena = String.Empty
        '    Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM CUSTOMER "
        '    dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        '    If dtDetalleCliente.Rows.Count() <> 0 Then
        '        CodigoC = String.Empty
        '        CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
        '        reporteBL = New ClsBuscar
        '        dtDetalleCliente = New DataTable("DetallesClientes")
        '        Cadena = String.Empty
        '        Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM CUSTOMER  WHERE ID= '" & CodigoC & "'"
        '        dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
        '        If dtDetalleCliente.Rows.Count() <> 0 Then
        '            txtclienteFinal.Text = dtDetalleCliente.Rows(0).Item(0).ToString
        '            txtclienteFinalDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
        '        Else
        '            txtclienteFinal.Text = String.Empty
        '            txtclienteFinalDesc.Text = String.Empty
        '        End If
        '    End If
        'Else
        '    gb_clientes.Enabled = True
        '    txtclienteInicial.Text = String.Empty
        '    txtclienteInicialDesc.Text = String.Empty
        '    txtclienteFinal.Text = String.Empty
        '    txtclienteFinalDesc.Text = String.Empty
        'End If
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

    Private Sub FrmRepCobranzaEfectuada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub rb_documento_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rb_vendedor_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rb_cliente_Click(sender As Object, e As EventArgs)

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

    Private Sub txtdocumentoFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtdocumentoFinal.MouseDoubleClick
        Ayuda_Documento(txtdocumentoFinal, txtdocumentoFinalDesc)
    End Sub

    Private Sub txtdocumentoFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumentoFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Documento(txtdocumentoFinal, txtdocumentoFinalDesc)
        End If
    End Sub

    Private Sub txtdocumentoInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtdocumentoInicial.MouseDoubleClick
        Ayuda_Documento(txtdocumentoInicial, txtdocumentoInicialDesc)
    End Sub

    Private Sub txtdocumentoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumentoInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Documento(txtdocumentoInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub txtVendedorFinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorFinal.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
    End Sub

    Private Sub txtVendedorInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtVendedorInicial.MouseDoubleClick
        Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
    End Sub

    Private Sub txtVendedorInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorInicial, txtvendedorInicialDesc)
        End If
    End Sub

    Private Sub txtVendedorFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVendedorFinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtVendedorFinal, txtvendedorFinDesc)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Formato_Concar.Visible = False
        GroupBox4.Enabled = True
        rb_cliente.Checked = True
    End Sub
    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString & "\"
        End If
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        'Detenemos el proceso de forma segura
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Deshabilitamos el boton por posibles equibocaiones
        Me.Cursor = Cursors.WaitCursor
        Me.btnIniciar.Enabled = False
        Me.ProgressBar2.Visible = True
        Me.Label3.Visible = False
        'Iniciamos el proceso de exportacion de la tabla a Excel
        Me.BackgroundWorker1.RunWorkerAsync()
        'ProgressBar2.Visible = False
        'Label3.Visible = True
        'Me.btnIniciar.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                  ByRef tipo_Reporte As Integer) As Boolean

        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            '--
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            ' -------------
            If rb_excel.Checked = True Then
                _opcion = "4"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim reporteBL As New ClsBuscar
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim clase_excel As New ClsReporteGenerales.ReportesGerenciales

        Try

            ' ---Validaciones generales
            If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
            If txtArchivo.Text = "" Then
                MessageBox.Show("Ingrese una ruta correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Try
                Exit Sub
            End If
            If txtRuta.Text = "" Then
                MessageBox.Show("Ingrese un nombre para el archivo a generar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Try
                Exit Sub
            End If
            ' -----Mostrando el Reporte
            'MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            NombreStore = "CXC_S_PEND_POR_DIA"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.EjecutarReporteCobranzaEfectuadaVendedor(Ref_fecIni, Ref_fecFin, "", "", "", "", "", "", "", _opcion, txt_cod_concepto.Text.Trim, GRUPO_COBRANZA)
            If dt_tmp.Rows.Count() <> 0 Then
                For i = 1 To 100
                    If Me.BackgroundWorker1.CancellationPending = True Then
                        MsgBox("El proceso de exportación ha sido cancelado.", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                    BackgroundWorker1.ReportProgress(i)
                    'Indica el tiempo en el que se realizara la tarea en segundo plano
                    Threading.Thread.Sleep(1) ' 0 es casi instantaneo
                Next
                'Indicamos la ruta donde se guardara el archivo, en este caso es el escritorio.
                Dim Ruta As String = Me.txtRuta.Text
                'Indicamos el nombre del archivo sin la extencion.
                Dim Archivo = Me.txtArchivo.Text
                'Llamamos a la funcion ExportarSQLExcel de la Clase ExportarExcel.

                e.Result = clase_excel.ExportarSQLExcel_Rep_Cobranza_Efectuada_Diario(dt_tmp, Ruta, Archivo)

            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            'Me.btnIniciar.Enabled = True
            MessageBox.Show(ex.Message)

        End Try
        crystalBL = Nothing
        reporteBL = Nothing

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Notificar el progreso de la tarea
        Me.ProgressBar1.Value = e.ProgressPercentage
        'Representa el porcentaje del progreso en el Label1.Text
        Label3.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Volvemos a habilitar el boton
        Me.btnIniciar.Enabled = True
        'Ponemos en cero la barra de progreso
        Me.ProgressBar1.Value = 0
        Me.ProgressBar2.Visible = False
        Me.Label3.Visible = True
        'Eliminamos el texto del Label1
        Label3.Text = ""
    End Sub

    Private Sub rb_excel_CheckedChanged(sender As Object, e As EventArgs) Handles rb_excel.CheckedChanged
        If rb_excel.Checked = True Then
            Panel_Formato_Concar.Visible = True
            GroupBox4.Enabled = False
            txtRuta.Text = ""
            txtArchivo.Text = "Rep_Cobranza_Efectuada_Diario"
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = 5
            ProgressBar2.Value = 0

            If ProgressBar2.Value < ProgressBar2.Maximum Then
                ProgressBar2.Value += 1
                If ProgressBar2.Value = ProgressBar2.Maximum Then
                    MsgBox("Finished!")
                End If
            End If
        End If
    End Sub

    Private Sub rb_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cliente.CheckedChanged
        If rb_cliente.Checked = True Then
            blank()
            pnl_vendedor.Visible = False
            pnl_cliente.Visible = True
            pnl_documento.Visible = False
        End If
        
    End Sub

    Private Sub rb_vendedor_CheckedChanged(sender As Object, e As EventArgs) Handles rb_vendedor.CheckedChanged
        If rb_vendedor.Checked = True Then
            blank()
            pnl_vendedor.Visible = True
            pnl_cliente.Visible = False
            pnl_documento.Visible = False
        End If
    End Sub

    Private Sub rb_documento_CheckedChanged(sender As Object, e As EventArgs) Handles rb_documento.CheckedChanged
        If rb_documento.Checked = True Then
            blank()
            pnl_vendedor.Visible = False
            pnl_cliente.Visible = False
            pnl_documento.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txt_cod_concepto.Enabled = Not CheckBox1.Checked
        txt_des_concepto.Enabled = Not CheckBox1.Checked
        txt_cod_concepto.Text = ""
        txt_des_concepto.Text = ""
    End Sub

    Private Sub txt_cod_concepto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_concepto.MouseDoubleClick
        Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)
    End Sub

    Private Sub txt_cod_concepto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_concepto.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)
        End If
    End Sub
    Private Sub Ayuda_Concepto(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CONCEPTO_COBRO_CONSULTA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = GRUPO_COBRANZA
            frm.Titulo = "Conceptos de Cobranza"
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
End Class