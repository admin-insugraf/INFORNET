Imports System.Windows.Forms
Imports LibComunVar


Public Class FrmReporteDocumentosCancelados_Pago

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDetalleCliente As DataTable
    Dim dtDetalleVendedor As DataTable
    Dim dt_tmp As DataTable
    Dim dtDatosCompany As DataTable
    Dim cliente_inicial As String, cliente_final As String
    Public GRUPO_COBRANZA As String

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If checkClientes.Checked = False Then
                If txtclienteInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Proveedor.", MsgBoxStyle.Exclamation)
                    txtclienteInicial.Focus()
                    estado = False
                End If
            End If
            If CheckBox1.Checked = False Then
                If TextBox4.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Tipo de Documento.", MsgBoxStyle.Exclamation)
                    TextBox4.Focus()
                    estado = False
                End If
            End If
            If CheckBox2.Checked = False Then
                If txt_cod_concepto.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Concepto de Pago.", MsgBoxStyle.Exclamation)
                    txt_cod_concepto.Focus()
                    estado = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub FrmReporteDocumentosCancelados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        checkVendedor.Checked = True
        CheckBox1.Checked = True
    End Sub


    Private Sub Ayuda_Cliente(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_AYU_PAY"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
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
            dtImprimir = New DataTable("PlanillaDocumentosCobro_Pago")

            If checkClientes.Checked = True Then
                CLIENTE_INICIAL = ""
                CLIENTE_FINAL = ""
            Else
                CLIENTE_INICIAL = txtclienteInicial.Text
                cliente_final = txtclienteInicial.Text
            End If

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDocumentosCancelados_Pago(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"),
                                                                            cliente_inicial, cliente_final, IIf(CheckBox1.Checked, "", TextBox4.Text.Trim), txtVendedorFinal.Text, _
                                                                            txt_cod_concepto.Text, GRUPO_COBRANZA)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_PAGOS_EFECTUADAS_PROVEEDOR.rpt", dtImprimir, "", "", _
                                          "INICIO;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_INICIAL;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECHA_FINAL;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@PROVEEDOR_INICIAL;" & txtclienteInicial.Text, "@PROVEEDOR_FINAL;" & txtclienteFinal.Text, _
                                          "@TIPO_DOCUMENTO;" & IIf(CheckBox1.Checked, "", TextBox4.Text.Trim), _
                                          "@CONCEPTO_PAGO;" & txt_cod_concepto.Text.Trim, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
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
            'reporteBL = New ClsBuscar
            'dtDetalleCliente = New DataTable
            'Dim Cadena As String = String.Empty
            'Dim CodigoC As String = String.Empty
            'Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM VENDOR "
            'dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            'If dtDetalleCliente.Rows.Count() <> 0 Then
            '    CodigoC = String.Empty
            '    CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
            '    reporteBL = New ClsBuscar
            '    dtDetalleCliente = New DataTable("detallesProveedor")
            '    Cadena = String.Empty
            '    Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION] FROM VENDOR   WHERE ID= '" & CodigoC & "'"
            '    dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            '    If dtDetalleCliente.Rows.Count() <> 0 Then
            '        txtclienteInicial.Text = dtDetalleCliente.Rows(0).Item(0).ToString
            '        txtclienteInicialDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
            '    Else
            '        txtclienteInicial.Text = String.Empty
            '        txtclienteInicialDesc.Text = String.Empty
            '    End If
            'End If
            'If txtclienteInicial.Text = String.Empty Then Exit Sub
            'reporteBL = New ClsBuscar
            'dtDetalleCliente = New DataTable
            'Cadena = String.Empty
            'Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM VENDOR  "
            'dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            'If dtDetalleCliente.Rows.Count() <> 0 Then
            '    CodigoC = String.Empty
            '    CodigoC = dtDetalleCliente.Rows(0).Item("CODIGO").ToString
            '    reporteBL = New ClsBuscar
            '    dtDetalleCliente = New DataTable("DetallesClientes")
            '    Cadena = String.Empty
            '    Cadena = "SELECT ID AS [CODIGO], NAME AS [DESCRIPCION ]FROM VENDOR  WHERE ID= '" & CodigoC & "'"
            '    dtDetalleCliente = reporteBL.MostrandoDescripcion(Cadena)
            '    If dtDetalleCliente.Rows.Count() <> 0 Then
            '        txtclienteFinal.Text = dtDetalleCliente.Rows(0).Item(0).ToString
            '        txtclienteFinalDesc.Text = dtDetalleCliente.Rows(0).Item(1).ToString
            '    Else
            '        txtclienteFinal.Text = String.Empty
            '        txtclienteFinalDesc.Text = String.Empty
            '    End If
            'End If
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteInicial.Enabled = False
            txtclienteInicialDesc.Enabled = False

            'txtclienteFinal.Enabled = False
            'txtclienteFinalDesc.Enabled = False
        Else
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteFinal.Text = String.Empty
            txtclienteFinalDesc.Text = String.Empty

            txtclienteInicial.Enabled = True
            txtclienteFinal.Enabled = True
            txtclienteInicialDesc.Enabled = True
            txtclienteFinalDesc.Enabled = True
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

    Private Sub rb_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cliente.CheckedChanged
        If rb_cliente.Checked = True Then
            blank()
            GroupBox2.Visible = True
            Panel_Formato_Concar.Visible = False
        End If
    End Sub
    Public Sub blank()
        checkVendedor.Checked = False
        checkClientes.Checked = False
       
        txtclienteInicial.Text = ""
        txtclienteInicialDesc.Text = ""
        txtclienteFinal.Text = ""
        txtclienteFinalDesc.Text = ""
        txtvendedorFinDesc.Text = ""
        txtvendedorInicialDesc.Text = ""
        txtVendedorInicial.Text = ""
        txtVendedorFinal.Text = ""
        txtRuta.Text = ""
        txtArchivo.Text = ""
    End Sub

    Private Sub rb_excel_CheckedChanged(sender As Object, e As EventArgs) Handles rb_excel.CheckedChanged
        If rb_excel.Checked = True Then
            blank()
            Panel_Formato_Concar.Visible = True
            GroupBox5.Enabled = False
            txtRuta.Text = ""
            txtArchivo.Text = "Rep_Pagos_Efectuados_Diario"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox5.Enabled = True
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
            dt_tmp = reporteBL.EjecutarReporteDocumentosCancelados_Pago_Diario(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txtclienteInicial.Text, txtclienteFinal.Text, txtVendedorInicial.Text, txtVendedorFinal.Text)
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

                e.Result = reporteBL.ExportarSQLExcel_Rep_Pagos_Efectuada_Diario(dt_tmp, Ruta, Archivo)

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

    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseDoubleClick
        Ayuda_Tipo_Documento(TextBox4, TextBox2)
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Documento(TextBox4, TextBox2)
        End If
    End Sub
    Private Sub Ayuda_Tipo_Documento(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_TIPO_DOC"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipos de Documento"
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox2.Enabled = False
            TextBox4.Enabled = False

        Else
            TextBox2.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox2.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        txt_cod_concepto.Enabled = Not CheckBox2.Checked
        txt_des_concepto.Enabled = Not CheckBox2.Checked
        txt_cod_concepto.Text = ""
        txt_des_concepto.Text = ""
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
            sql = "CX_SP_S_CONCEPTO_PAGO_CONSULTA"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = GRUPO_COBRANZA
            frm.Titulo = "Conceptos de Pago"
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

    Private Sub txt_cod_concepto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_concepto.MouseDoubleClick
        Ayuda_Concepto(txt_cod_concepto, txt_des_concepto)
    End Sub
End Class