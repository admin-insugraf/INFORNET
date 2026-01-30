Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Imports LibVentas
Imports System.IO
Public Class FrmImportarExportarMovimientos
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable
    Private myStream As StreamReader
    Private myDataRow As DataRow
    Private Sub FrmImportarExportarMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 5
        ProgressBar2.Value = 0

        If ProgressBar2.Value < ProgressBar2.Maximum Then
            ProgressBar2.Value += 1
            If ProgressBar2.Value = ProgressBar2.Maximum Then
                MsgBox("Finished!")
            End If
        End If
        dtpfechaInicio.Select()
    End Sub
    Private Sub FrmRegVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'para detener el proceso en caso de cerrar el formulario.
        Me.BackgroundWorker1.CancelAsync()
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
            If rdbsunat.Checked = False And rdbconcar.Checked = False Then
                MessageBox.Show("Debe elegir una de las opciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rdbsunat.Focus()
                estado = False
                Exit Try
            End If

            If rdbsunat.Checked = True Then
                tipo_Reporte = 1
            ElseIf rdbconcar.Checked = True Then
                tipo_Reporte = 2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        'Detenemos el proceso de forma segura
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        If rdbsunat.Checked = True Then
            Dim Carpeta As New FolderBrowserDialog
            If Carpeta.ShowDialog() = DialogResult.OK Then
                Me.txtRuta.Text = Carpeta.SelectedPath.ToString & "\"
            End If
        ElseIf rdbconcar.Checked = True Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.txtRuta.Text = openFileDialog1.FileName()
            End If
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
        If txtArchivo.Text = "" Then
            MessageBox.Show("Ingrese una ruta correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtRuta.Text = "" Then
            MessageBox.Show("Ingrese un nombre para el archivo a generar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim i As Integer
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim clase_excel As New ClsReporteGenerales.ReportesGerenciales

        Try
            If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
            Dim Ruta As String = Me.txtRuta.Text
            Dim Archivo = Me.txtArchivo.Text
            If rdbsunat.Checked = True Then
                'MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
                NombreStore = "SP_EXPORTAR_MOV_RECEIVABLE"
                dt_tmp = New DataTable
                'Me.Cursor = Cursors.WaitCursor
                dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
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
                    If CreateTextDelimiterFile(Ruta & Archivo, dt_tmp, ChrW(Keys.Tab), False, False) = True Then
                        MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("No hay informacion disponible para generar el archivo.", MsgBoxStyle.Information)
                End If
                'Me.Cursor = Cursors.Default
            ElseIf rdbconcar.Checked = True Then
                If ImportarMovimientos(Ruta) = True Then
                    MsgBox("Los datos han sido importados correctamente.", MsgBoxStyle.Information)
                Else
                    MessageBox.Show("No se logró hacer la importación del archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            'Me.btnIniciar.Enabled = True
            MessageBox.Show(ex.Message)
        End Try
        crystalBL = Nothing
        reporteBL = Nothing

    End Sub
    
    Private Function ImportarTxtStream(ByVal STRRuta As String) As StreamReader
        Try
            Dim myStream As Stream = Nothing
            Dim myStreamRead As StreamReader = Nothing
            Dim myLinea As String = Nothing
            myStream = New FileStream(STRRuta, FileMode.Open, FileAccess.Read)
            myStreamRead = New StreamReader(myStream)
            Return myStreamRead
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Function CaracterEspecial(ByVal STRCadena As String) As String
        Dim myCaracEspecial() As Char = {"�", "*"}
        Dim myLetra As String, myCadena As String = Nothing
        Dim BYTCuenta As Byte

        If STRCadena.Length > 0 Then
            For BYTCuenta = 0 To STRCadena.Length - 1
                myLetra = STRCadena.Substring(BYTCuenta, 1)
                If myCaracEspecial.Contains(myLetra) = False Then
                    myCadena = myCadena & myLetra
                End If
            Next
        End If
        If myCadena Is Nothing Then
            myCadena = "xxx"
        End If
        Return myCadena
    End Function
    Public Function ImportarMovimientos(ByVal STRRuta As String) As Boolean
        Dim INTLine As Integer = 0
        Dim STRLinea As String = Nothing
        Dim STRTipoDoc As String = String.Empty
        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Try
            myStream = ImportarTxtStream(STRRuta)
            dtTable = New DataTable("CUSTOMER_BALANCE")
            With dtTable.Columns
                .Add(New DataColumn("CUSTOMER_ID", GetType(String)))
                .Add(New DataColumn("DOCUMENT_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_DOC", GetType(String)))
                .Add(New DataColumn("DOC_DATE", GetType(Date)))
                .Add(New DataColumn("CADUCATE_DATE", GetType(Date)))
                .Add(New DataColumn("DOCUMENT_REF", GetType(String)))
                .Add(New DataColumn("NUMBER_REF", GetType(String)))
                .Add(New DataColumn("SALES_ID", GetType(String)))
                .Add(New DataColumn("AMOUNT", GetType(Double)))
                .Add(New DataColumn("AMOUNT_BALANCE", GetType(Double)))
                .Add(New DataColumn("CURRENCY_ID", GetType(String)))
                .Add(New DataColumn("SELL_RATE", GetType(Double)))
                .Add(New DataColumn("IS_DR_CR", GetType(String)))
                .Add(New DataColumn("STATUS", GetType(String)))
                .Add(New DataColumn("CREATE_DATE", GetType(Date)))
                .Add(New DataColumn("LAST_MODIFIED", GetType(Date)))
                .Add(New DataColumn("USER_ID", GetType(String)))
                .Add(New DataColumn("ACCOUNT", GetType(String)))
                .Add(New DataColumn("AMOUNT_COMM", GetType(Double)))
                .Add(New DataColumn("TYPE_REC", GetType(String)))
                .Add(New DataColumn("REFERENCE_DATE", GetType(Date)))
                .Add(New DataColumn("IS_CHECK_DIF", GetType(String)))
                .Add(New DataColumn("AMOUNT_BALANCE_INI", GetType(Double)))
                .Add(New DataColumn("TERMS", GetType(String)))
                .Add(New DataColumn("PLACE_SALES", GetType(String)))
                .Add(New DataColumn("BANK_ID", GetType(String)))
                .Add(New DataColumn("BANK_DESCRIPTION", GetType(String)))
                .Add(New DataColumn("AMOUNT_PER", GetType(Double)))
                .Add(New DataColumn("PERCENT_PER", GetType(Double)))
                .Add(New DataColumn("ACCOUNT_PER", GetType(String)))
                .Add(New DataColumn("CUST_AUTO", GetType(String)))
                .Add(New DataColumn("SERIE_AUX", GetType(String)))
                .Add(New DataColumn("NUM_DOC_AUX", GetType(String)))
                .Add(New DataColumn("AMOUNT_DETRAC", GetType(Double)))
                .Add(New DataColumn("PERCENT_DETRAC", GetType(Double)))
                .Add(New DataColumn("SALDO", GetType(Double)))
                .Add(New DataColumn("NUM_REF_ASIENTO", GetType(Integer)))
                .Add(New DataColumn("VOUCHER_REF_ASIENTO", GetType(String)))
                .Add(New DataColumn("FECHA_REF_ASIENTO", GetType(Date)))
            End With

            dtTableR = New DataTable("RECEIVABLE")
            With dtTableR.Columns
                .Add(New DataColumn("DOCUMENT_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_SERIE", GetType(String)))
                .Add(New DataColumn("NUMBER_DOCUMENT", GetType(String)))
                .Add(New DataColumn("DOCUMENT_DATE", GetType(Date)))
                .Add(New DataColumn("CADUCATE_DATE", GetType(Date)))
                .Add(New DataColumn("DR_CR", GetType(String)))
                .Add(New DataColumn("SALES_REP_ID", GetType(String)))
                .Add(New DataColumn("PLACE_SALES", GetType(String)))
                .Add(New DataColumn("NUMBER_QUOTE", GetType(String)))
                .Add(New DataColumn("NUMBER_ORDER_PUR", GetType(String)))
                .Add(New DataColumn("CFDESCPG", GetType(String)))
                .Add(New DataColumn("POINT_ORIG", GetType(String)))
                .Add(New DataColumn("POINT_BOARD", GetType(String)))
                .Add(New DataColumn("POINT_ARRIVAL", GetType(String)))
                .Add(New DataColumn("RECEIVABLE_TYPE", GetType(String)))
                .Add(New DataColumn("CUSTOMER_ID", GetType(String)))
                .Add(New DataColumn("CUSTOMER_NAME", GetType(String)))
                .Add(New DataColumn("CUSTOMER_ADDR", GetType(String)))
                .Add(New DataColumn("VAT_REGISTRATION", GetType(String)))
                .Add(New DataColumn("WAREHOUSE_ID", GetType(String)))
                .Add(New DataColumn("AMOUNT", GetType(Double)))
                .Add(New DataColumn("TERMS_ID", GetType(String)))
                .Add(New DataColumn("BALANCE", GetType(Double)))
                .Add(New DataColumn("SELL_RATE", GetType(Double)))
                .Add(New DataColumn("CURRENCY_ID", GetType(String)))
                .Add(New DataColumn("DOCUMENT_REF", GetType(String)))
                .Add(New DataColumn("SERIE_REF", GetType(String)))
                .Add(New DataColumn("NUMBER_REF", GetType(String)))
                .Add(New DataColumn("NUMBER_ORDER", GetType(String)))
                .Add(New DataColumn("CREATE_DATE", GetType(Date)))
                .Add(New DataColumn("LAST_MODIFIED", GetType(Date)))
                .Add(New DataColumn("STATUS", GetType(String)))
                .Add(New DataColumn("USER_ID", GetType(String)))
                .Add(New DataColumn("COMMENT", GetType(String)))
                .Add(New DataColumn("IS_GUIA_REC", GetType(String)))
                .Add(New DataColumn("NUMBER_REGISTRATION", GetType(String)))
                .Add(New DataColumn("DISCOUNT_PERCENT", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_PERCENT_SP", GetType(Double)))
                .Add(New DataColumn("CARD_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_CARD", GetType(String)))
                .Add(New DataColumn("AMOUNT_CARD_US", GetType(Double)))
                .Add(New DataColumn("AMOUNT_CARD", GetType(Double)))
                .Add(New DataColumn("BANK_CHECK", GetType(String)))
                .Add(New DataColumn("NUMBER_CHECK", GetType(String)))
                .Add(New DataColumn("AMOUNT_CH_US", GetType(Double)))
                .Add(New DataColumn("AMOUNT_CH", GetType(Double)))
                .Add(New DataColumn("VOUCHER_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_TRA", GetType(String)))
                .Add(New DataColumn("AMOUNT_TAX", GetType(Double)))
                .Add(New DataColumn("DISCOUNTV", GetType(Double)))
                .Add(New DataColumn("DISCOUNTP", GetType(Double)))
                .Add(New DataColumn("LIST_GUIA", GetType(String)))
                .Add(New DataColumn("IS_PRINT", GetType(String)))
                .Add(New DataColumn("DISCOUNT_RECIVABLE", GetType(Double)))
                .Add(New DataColumn("IS_CLOSED", GetType(String)))
                .Add(New DataColumn("SUB_ID", GetType(String)))
                .Add(New DataColumn("TOTAL_ERROR", GetType(Double)))
                .Add(New DataColumn("PROMISE_DAYS", GetType(Integer)))
                .Add(New DataColumn("SHIPPER_TYPE", GetType(String)))
                .Add(New DataColumn("ZONE_FREIGTH", GetType(String)))
                .Add(New DataColumn("AMOUNT_FREIGTH", GetType(Double)))
                .Add(New DataColumn("IS_GUIA", GetType(String)))
                .Add(New DataColumn("IS_CASH_BANK", GetType(String)))
                .Add(New DataColumn("TAX_TYPE", GetType(Integer)))
                .Add(New DataColumn("REC_AUTO", GetType(String)))
                .Add(New DataColumn("TRAMA_ID", GetType(String)))
                .Add(New DataColumn("VEHICULO_ID", GetType(String)))
                .Add(New DataColumn("EMPTRA_ID", GetType(String)))
                .Add(New DataColumn("ISC", GetType(Double)))
                .Add(New DataColumn("DOCUMENT_TYPE_COMP_PER", GetType(String)))
                .Add(New DataColumn("SERIE_COMP_PER", GetType(String)))
                .Add(New DataColumn("NUMBER_COMP_PER", GetType(String)))
                .Add(New DataColumn("ESTADO_DESPACHO", GetType(String)))
                .Add(New DataColumn("AMOUNT_DETRAC", GetType(Double)))
                .Add(New DataColumn("PERCENT_DETRAC", GetType(Double)))
                .Add(New DataColumn("MOV_OPTION_ID", GetType(String)))
                .Add(New DataColumn("AC_ID", GetType(Integer)))
                .Add(New DataColumn("AC_IDSUBDIARIO", GetType(String)))
                .Add(New DataColumn("AC_NUM_VOUCHER", GetType(String)))
            End With

            dtTableRL = New DataTable("RECEIVABLE_LINE")
            With dtTableRL.Columns
                .Add(New DataColumn("DOCUMENT_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_SERIE", GetType(String)))
                .Add(New DataColumn("NUMBER_DOCUMENT", GetType(String)))
                .Add(New DataColumn("ITEM", GetType(String)))
                .Add(New DataColumn("PART_ID", GetType(String)))
                .Add(New DataColumn("QTY", GetType(Double)))
                .Add(New DataColumn("PRICE_SALES", GetType(Double)))
                .Add(New DataColumn("PRICE_ORI", GetType(Double)))
                .Add(New DataColumn("DISCOUNT", GetType(Double)))
                .Add(New DataColumn("AMOUNT_TAX", GetType(Double)))
                .Add(New DataColumn("TAX_PERCENT", GetType(Double)))
                .Add(New DataColumn("AMOUNT_US", GetType(Double)))
                .Add(New DataColumn("AMOUNT", GetType(Double)))
                .Add(New DataColumn("UNIT", GetType(String)))
                .Add(New DataColumn("STATUS", GetType(String)))
                .Add(New DataColumn("PART_SERIE", GetType(String)))
                .Add(New DataColumn("WAREHOUSE_ID", GetType(String)))
                .Add(New DataColumn("TEXT_DESCRIPTION", GetType(String)))
                .Add(New DataColumn("DFTR", GetType(String)))
                .Add(New DataColumn("STOCK", GetType(String)))
                .Add(New DataColumn("PART_DESCRIPTION", GetType(String)))
                .Add(New DataColumn("QTY_REF", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_PERCENT", GetType(Double)))
                .Add(New DataColumn("BALANCE_PART", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_CUSTOMER", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_SP", GetType(Double)))
                .Add(New DataColumn("PART_LOT", GetType(String)))
                .Add(New DataColumn("NUMBER_GUIA", GetType(String)))
                .Add(New DataColumn("PART_TAX", GetType(String)))
                .Add(New DataColumn("DISCOUNT1", GetType(Double)))
                .Add(New DataColumn("DISCOUNT2", GetType(Double)))
                .Add(New DataColumn("PERCENT1", GetType(Double)))
                .Add(New DataColumn("PERCENT2", GetType(Double)))
                .Add(New DataColumn("PRICE_LIST_ID", GetType(String)))
                .Add(New DataColumn("SHIPPER_QTY", GetType(Double)))
                .Add(New DataColumn("BUDGET_ID", GetType(String)))
                .Add(New DataColumn("ORDER_ID", GetType(String)))
                .Add(New DataColumn("BRUTE_QTY", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_QTY_BRUTE", GetType(Double)))
                .Add(New DataColumn("UM_REFERENCE", GetType(String)))
                .Add(New DataColumn("QTY_REFERENCE", GetType(Double)))
                .Add(New DataColumn("COMISION", GetType(Double)))
                .Add(New DataColumn("TIPOISC", GetType(Double)))
                .Add(New DataColumn("ISCPOR", GetType(Double)))
                .Add(New DataColumn("ISC", GetType(Double)))
            End With

            dtTableWT = New DataTable("WAREHOUSE_TRANS")
            With dtTableWT.Columns
                .Add(New DataColumn("WAREHOUSE_ID", GetType(String)))
                .Add(New DataColumn("DOCUMENT_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_DOCUMENT", GetType(String)))
                .Add(New DataColumn("DATE_DOCUMENT", GetType(Date)))
                .Add(New DataColumn("TYPE_TRANS", GetType(String)))
                .Add(New DataColumn("TRANS_ID", GetType(String)))
                .Add(New DataColumn("DOCUMENT_STATUS", GetType(String)))
                .Add(New DataColumn("DOC_ID_REF", GetType(String)))
                .Add(New DataColumn("NUM_ID_REF", GetType(String)))
                .Add(New DataColumn("AUTORIZED_ID", GetType(String)))
                .Add(New DataColumn("DATE_RETURN", GetType(String)))
                .Add(New DataColumn("VENDOR_ID", GetType(String)))
                .Add(New DataColumn("CCOST_ID", GetType(String)))
                .Add(New DataColumn("WAREHOUSE_REF", GetType(String)))
                .Add(New DataColumn("COMMENT", GetType(String)))
                .Add(New DataColumn("UPDATE_DATE", GetType(Date)))
                .Add(New DataColumn("HOUR", GetType(String)))
                .Add(New DataColumn("USER_ID", GetType(String)))
                .Add(New DataColumn("CUSTOMER_ID", GetType(String)))
                .Add(New DataColumn("VAT_REGISTRATION", GetType(String)))
                .Add(New DataColumn("CUSTOMER_NAME", GetType(String)))
                .Add(New DataColumn("SALES_TERM", GetType(String)))
                .Add(New DataColumn("CURRENCY_TYPE", GetType(String)))
                .Add(New DataColumn("SALES_ID", GetType(String)))
                .Add(New DataColumn("CURRENCY_EXCHANGE", GetType(Double)))
                .Add(New DataColumn("TYPE_GUIA", GetType(String)))
                .Add(New DataColumn("STATUS_GUIA", GetType(String)))
                .Add(New DataColumn("RECEIVABLE_GUIA", GetType(String)))
                .Add(New DataColumn("ADDR_DLV", GetType(String)))
                .Add(New DataColumn("CARRIER_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_PURCHASE", GetType(String)))
                .Add(New DataColumn("IS_GUIA_RETURN", GetType(String)))
                .Add(New DataColumn("VENDOR_NAME", GetType(String)))
                .Add(New DataColumn("NUMBER_ORDER", GetType(String)))
                .Add(New DataColumn("NUMBER_ESTIMATING", GetType(String)))
                .Add(New DataColumn("DISCOUNT_PER_CUST", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_PER_SP", GetType(Double)))
                .Add(New DataColumn("AMOUNT", GetType(Double)))
                .Add(New DataColumn("CARRIER_NAME", GetType(String)))

                .Add(New DataColumn("CARRIER_ADDR", GetType(String)))
                .Add(New DataColumn("CARRIER_VAT", GetType(String)))
                .Add(New DataColumn("NUMBER_REGISTRATION", GetType(String)))
                .Add(New DataColumn("NUMBER_IMPORT", GetType(String)))
                .Add(New DataColumn("NUMBER_LIQ", GetType(String)))
                .Add(New DataColumn("PRINTER_STATUS", GetType(String)))
                .Add(New DataColumn("STATUS_CLOSE", GetType(String)))
                .Add(New DataColumn("TYPE_SHIPPER", GetType(String)))
                .Add(New DataColumn("ZONE_FREIGHT", GetType(String)))
                .Add(New DataColumn("IS_GUIA", GetType(String)))
                .Add(New DataColumn("IS_POST", GetType(String)))
                .Add(New DataColumn("FREIGHT", GetType(Double)))
                .Add(New DataColumn("ORDER_REF", GetType(String)))
                .Add(New DataColumn("COST", GetType(Double)))
                .Add(New DataColumn("RECEP_NAME", GetType(String)))
                .Add(New DataColumn("DOCUMENT_RECEP", GetType(String)))
                .Add(New DataColumn("NUM_ORDER_MANUFACT", GetType(String)))
                .Add(New DataColumn("INTERFACE", GetType(String)))
                .Add(New DataColumn("ACCOUNT", GetType(String)))
                .Add(New DataColumn("PROJECT_ID", GetType(String)))
                .Add(New DataColumn("TRAMA_ID", GetType(String)))
                .Add(New DataColumn("VEHICULO_ID", GetType(String)))
                .Add(New DataColumn("EMPTRA_ID", GetType(String)))
                .Add(New DataColumn("FECHA_DESPACHO", GetType(String)))
                .Add(New DataColumn("HORA_DESPACHO", GetType(String)))
                .Add(New DataColumn("STATUS_CONTROL", GetType(String)))
                .Add(New DataColumn("IS_LOTE_A_FABRICAR", GetType(String)))
                .Add(New DataColumn("MOV_OPTION_ID", GetType(String)))
            End With

            dtTableWTL = New DataTable("WAREHOUSE_TRANS_LINE")
            With dtTableWTL.Columns
                .Add(New DataColumn("WAREHOUSE_ID", GetType(String)))
                .Add(New DataColumn("DOCUMENT_ID", GetType(String)))
                .Add(New DataColumn("NUMBER_DOCUMENT", GetType(String)))
                .Add(New DataColumn("ITEM", GetType(Integer)))
                .Add(New DataColumn("PART_ID", GetType(String)))
                .Add(New DataColumn("REF_ID", GetType(String)))
                .Add(New DataColumn("QTY", GetType(Double)))
                .Add(New DataColumn("QTY_DLV", GetType(Double)))
                .Add(New DataColumn("QTY_REF", GetType(Double)))
                .Add(New DataColumn("QTY_INVOICED", GetType(Double)))
                .Add(New DataColumn("NUM_ORDER", GetType(String)))
                .Add(New DataColumn("UNIT_PRICE", GetType(Double)))
                .Add(New DataColumn("AVERAGE_COST", GetType(Double)))
                .Add(New DataColumn("AMOUNT_SALES", GetType(Double)))
                .Add(New DataColumn("DISCOUNT", GetType(Double)))
                .Add(New DataColumn("STOCK", GetType(String)))
                .Add(New DataColumn("AMOUNT_TAX", GetType(Double)))
                .Add(New DataColumn("AMOUNT", GetType(Double)))
                .Add(New DataColumn("AMOUNT_US", GetType(Double)))
                .Add(New DataColumn("NUMBER_SERIE", GetType(String)))
                .Add(New DataColumn("STATUS_DOC", GetType(String)))
                .Add(New DataColumn("DATE_DOC", GetType(Date)))
                .Add(New DataColumn("CCOST_ID", GetType(String)))
                .Add(New DataColumn("WAREHOUSE_REF", GetType(String)))
                .Add(New DataColumn("TEXT_COMMENT", GetType(String)))
                .Add(New DataColumn("STATUS", GetType(String)))
                .Add(New DataColumn("TRANS_ID", GetType(String)))
                .Add(New DataColumn("VAL_AMOUNT", GetType(Double)))
                .Add(New DataColumn("NUM_VOUCHER", GetType(String)))
                .Add(New DataColumn("CURRENCY_ID", GetType(String)))
                .Add(New DataColumn("TYPE", GetType(String)))
                .Add(New DataColumn("TYPE_EXCHANGE", GetType(Double)))
                .Add(New DataColumn("PRICE_SALES", GetType(Double)))
                .Add(New DataColumn("TOTAL_SALES", GetType(String)))
                .Add(New DataColumn("DATE_CADUCATE", GetType(Date)))
                .Add(New DataColumn("RETURN_AMOUNT", GetType(Double)))
                .Add(New DataColumn("AUTHORIZED", GetType(String)))
                .Add(New DataColumn("PART_DESCRIPTION", GetType(String)))
                .Add(New DataColumn("DISCOUNT_PERCENT", GetType(Double)))

                .Add(New DataColumn("TAX_PERCENT", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_CUST", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_SP", GetType(Double)))
                .Add(New DataColumn("NUMBER_INVOICE", GetType(String)))
                .Add(New DataColumn("NUMBER_LOT", GetType(String)))
                .Add(New DataColumn("UNIT_PART", GetType(String)))
                .Add(New DataColumn("ORDER_MANUFACT_ID", GetType(String)))
                .Add(New DataColumn("EQUIP_ID", GetType(String)))
                .Add(New DataColumn("FREIGTH", GetType(Double)))
                .Add(New DataColumn("ITEMI", GetType(String)))
                .Add(New DataColumn("QTY_BRUTE", GetType(Double)))
                .Add(New DataColumn("DISCOUNT_PER_QTY", GetType(Double)))
                .Add(New DataColumn("STATUS_VALUE", GetType(String)))
                .Add(New DataColumn("UNIT_REFERENCE", GetType(String)))
                .Add(New DataColumn("QTY_REFERENCE", GetType(Double)))
                .Add(New DataColumn("COMMENT", GetType(String)))
                .Add(New DataColumn("REFERENCE", GetType(String)))
                .Add(New DataColumn("ACCOUNT", GetType(String)))
                .Add(New DataColumn("COMMENT_TEXT", GetType(String)))
                .Add(New DataColumn("PROJECT_ID", GetType(String)))
                .Add(New DataColumn("QT_BULTOS", GetType(Integer)))
                .Add(New DataColumn("OPT_ENTREGA", GetType(String)))
                .Add(New DataColumn("NUM_PROTOCOLOS", GetType(String)))
                .Add(New DataColumn("NUMBER_ANALIS", GetType(String)))
                .Add(New DataColumn("PROCEDENCIA", GetType(String)))
                .Add(New DataColumn("PAIS_ORIGEN", GetType(String)))
                .Add(New DataColumn("QTY_BULTOS_ANALIZADOS", GetType(Integer)))
            End With
            Dim Separo() As String
            Do While myStream.Peek > -1
                STRLinea = myStream.ReadLine
                INTLine += 1
                Separo = Split(STRLinea, vbTab)
                If Separo.Length > 1 Then
                    If Separo(0).Length > 0 And Separo(0) = "CUSTOMER_BALANCE" Then
                        myDataRow = dtTable.NewRow
                        myDataRow("CUSTOMER_ID") = Separo(1)
                        myDataRow("DOCUMENT_ID") = Separo(2)
                        myDataRow("NUMBER_DOC") = Separo(3)
                        myDataRow("DOC_DATE") = Separo(4)
                        myDataRow("CADUCATE_DATE") = Separo(5)
                        myDataRow("DOCUMENT_REF") = Separo(6)
                        myDataRow("NUMBER_REF") = Separo(7)
                        myDataRow("SALES_ID") = Separo(8)
                        myDataRow("AMOUNT") = Separo(9)
                        myDataRow("AMOUNT_BALANCE") = Separo(10)
                        myDataRow("CURRENCY_ID") = Separo(11)
                        myDataRow("SELL_RATE") = Separo(12)
                        myDataRow("IS_DR_CR") = Separo(13)
                        myDataRow("STATUS") = Separo(14)
                        myDataRow("CREATE_DATE") = Separo(15)
                        myDataRow("LAST_MODIFIED") = Separo(16)
                        myDataRow("USER_ID") = Separo(17)
                        myDataRow("ACCOUNT") = Separo(18)
                        myDataRow("AMOUNT_COMM") = Separo(19)
                        myDataRow("TYPE_REC") = Separo(20)
                        myDataRow("REFERENCE_DATE") = Separo(21)
                        myDataRow("IS_CHECK_DIF") = Separo(22)
                        myDataRow("AMOUNT_BALANCE_INI") = Separo(23)
                        myDataRow("TERMS") = Separo(24)
                        myDataRow("PLACE_SALES") = Separo(25)
                        myDataRow("BANK_ID") = Separo(26)
                        myDataRow("BANK_DESCRIPTION") = Separo(27)
                        myDataRow("AMOUNT_PER") = Separo(28)
                        myDataRow("PERCENT_PER") = Separo(29)
                        myDataRow("ACCOUNT_PER") = Separo(30)
                        myDataRow("CUST_AUTO") = Separo(31)
                        myDataRow("SERIE_AUX") = Separo(32)
                        myDataRow("NUM_DOC_AUX") = Separo(33)
                        myDataRow("AMOUNT_DETRAC") = Separo(34)
                        myDataRow("PERCENT_DETRAC") = Separo(35)
                        If Separo(36) = "" Or IsDBNull(Separo(36)) Then
                            myDataRow("SALDO") = 0
                        Else
                            myDataRow("SALDO") = Separo(36)
                        End If

                        If Separo(37) = "" Or IsDBNull(Separo(37)) Then
                            myDataRow("NUM_REF_ASIENTO") = 0
                        Else
                            myDataRow("NUM_REF_ASIENTO") = Separo(37)
                        End If

                        If Separo(38) = "" Or IsDBNull(Separo(38)) Then
                            myDataRow("VOUCHER_REF_ASIENTO") = ""
                        Else
                            myDataRow("VOUCHER_REF_ASIENTO") = Separo(38)
                        End If

                        If Separo(39) = "" Or IsDBNull(Separo(39)) Then
                            myDataRow("FECHA_REF_ASIENTO") = Date.Today.ToString("dd/MM/yyyy")
                        Else
                            myDataRow("FECHA_REF_ASIENTO") = Separo(39)
                        End If

                        dtTable.Rows.Add(myDataRow)
                    End If
                End If
            Loop

            myStream = ImportarTxtStream(STRRuta)
            Do While myStream.Peek > -1
                STRLinea = myStream.ReadLine
                INTLine += 1
                Separo = Split(STRLinea, vbTab)
                If Separo.Length > 1 Then
                    If Separo(0).Length > 0 And Separo(0) = "RECEIVABLE" Then
                        myDataRow = dtTableR.NewRow
                        myDataRow("DOCUMENT_ID") = Separo(1)
                        myDataRow("NUMBER_SERIE") = Separo(2)
                        myDataRow("NUMBER_DOCUMENT") = Separo(3)
                        myDataRow("DOCUMENT_DATE") = Separo(4)
                        myDataRow("CADUCATE_DATE") = Separo(5)
                        myDataRow("DR_CR") = Separo(6)
                        myDataRow("SALES_REP_ID") = Separo(7)
                        myDataRow("PLACE_SALES") = Separo(8)
                        myDataRow("NUMBER_QUOTE") = Separo(9)
                        myDataRow("NUMBER_ORDER_PUR") = Separo(10)
                        myDataRow("CFDESCPG") = Separo(11)
                        myDataRow("POINT_ORIG") = Separo(12)
                        myDataRow("POINT_BOARD") = Separo(13)
                        myDataRow("POINT_ARRIVAL") = Separo(14)
                        myDataRow("RECEIVABLE_TYPE") = Separo(15)
                        myDataRow("CUSTOMER_ID") = Separo(16)
                        myDataRow("CUSTOMER_NAME") = Separo(17)
                        myDataRow("CUSTOMER_ADDR") = Separo(18)
                        myDataRow("VAT_REGISTRATION") = Separo(19)
                        myDataRow("WAREHOUSE_ID") = Separo(20)
                        myDataRow("AMOUNT") = Separo(21)
                        myDataRow("TERMS_ID") = Separo(22)
                        myDataRow("BALANCE") = Separo(23)
                        myDataRow("SELL_RATE") = Separo(24)
                        myDataRow("CURRENCY_ID") = Separo(25)
                        myDataRow("DOCUMENT_REF") = Separo(26)
                        myDataRow("SERIE_REF") = Separo(27)
                        myDataRow("NUMBER_REF") = Separo(28)
                        myDataRow("NUMBER_ORDER") = Separo(29)
                        myDataRow("CREATE_DATE") = Separo(30)

                        If Separo(31) = "" Or IsDBNull(Separo(31)) Then
                            myDataRow("LAST_MODIFIED") = Date.Today.ToString("dd/MM/yyyy")
                        Else
                            myDataRow("LAST_MODIFIED") = Separo(31)
                        End If


                        myDataRow("STATUS") = Separo(32)
                        myDataRow("USER_ID") = Separo(33)
                        myDataRow("COMMENT") = Separo(34)
                        myDataRow("IS_GUIA_REC") = Separo(35)

                        myDataRow("NUMBER_REGISTRATION") = Separo(36)
                        myDataRow("DISCOUNT_PERCENT") = Separo(37)
                        myDataRow("DISCOUNT_PERCENT_SP") = Separo(38)
                        myDataRow("CARD_ID") = Separo(39)
                        myDataRow("NUMBER_CARD") = Separo(40)
                        myDataRow("AMOUNT_CARD_US") = Separo(41)
                        myDataRow("AMOUNT_CARD") = Separo(42)
                        myDataRow("BANK_CHECK") = Separo(43)
                        myDataRow("NUMBER_CHECK") = Separo(44)
                        myDataRow("AMOUNT_CH_US") = Separo(45)
                        myDataRow("AMOUNT_CH") = Separo(46)
                        myDataRow("VOUCHER_ID") = Separo(47)
                        myDataRow("NUMBER_TRA") = Separo(48)
                        myDataRow("AMOUNT_TAX") = Separo(49)
                        myDataRow("DISCOUNTV") = Separo(50)
                        myDataRow("DISCOUNTP") = Separo(51)
                        myDataRow("LIST_GUIA") = Separo(52)
                        myDataRow("IS_PRINT") = Separo(53)
                        myDataRow("DISCOUNT_RECIVABLE") = Separo(54)
                        myDataRow("IS_CLOSED") = Separo(55)
                        myDataRow("SUB_ID") = Separo(56)
                        myDataRow("TOTAL_ERROR") = Separo(57)
                        myDataRow("PROMISE_DAYS") = Separo(58)
                        myDataRow("SHIPPER_TYPE") = Separo(59)
                        myDataRow("ZONE_FREIGTH") = Separo(60)
                        myDataRow("AMOUNT_FREIGTH") = Separo(61)
                        myDataRow("IS_GUIA") = Separo(62)
                        myDataRow("IS_CASH_BANK") = Separo(63)
                        myDataRow("TAX_TYPE") = Separo(64)
                        myDataRow("REC_AUTO") = Separo(65)
                        myDataRow("TRAMA_ID") = Separo(66)
                        myDataRow("VEHICULO_ID") = Separo(67)
                        myDataRow("EMPTRA_ID") = Separo(68)
                        myDataRow("ISC") = Separo(69)
                        myDataRow("DOCUMENT_TYPE_COMP_PER") = Separo(70)

                        myDataRow("SERIE_COMP_PER") = Separo(71)
                        myDataRow("NUMBER_COMP_PER") = Separo(72)
                        myDataRow("ESTADO_DESPACHO") = Separo(73)
                        myDataRow("AMOUNT_DETRAC") = Separo(74)
                        myDataRow("PERCENT_DETRAC") = Separo(75)
                        myDataRow("MOV_OPTION_ID") = Separo(76)

                        If Separo(77) = "" Or IsDBNull(Separo(77)) Then
                            myDataRow("AC_ID") = 0
                        Else
                            myDataRow("AC_ID") = Separo(77)
                        End If


                        If Separo(78) = "" Or IsDBNull(Separo(78)) Then
                            myDataRow("AC_IDSUBDIARIO") = ""
                        Else
                            myDataRow("AC_IDSUBDIARIO") = Separo(78)
                        End If


                        If Separo(79) = "" Or IsDBNull(Separo(79)) Then
                            myDataRow("AC_NUM_VOUCHER") = ""
                        Else
                            myDataRow("AC_NUM_VOUCHER") = Separo(79)
                        End If

                        dtTableR.Rows.Add(myDataRow)
                    End If
                End If
            Loop

            myStream = ImportarTxtStream(STRRuta)
            Do While myStream.Peek > -1
                STRLinea = myStream.ReadLine
                INTLine += 1
                Separo = Split(STRLinea, vbTab)
                If Separo.Length > 1 Then
                    If Separo(0).Length > 0 And Separo(0) = "RECEIVABLE_LINE" Then
                        myDataRow = dtTableRL.NewRow
                        myDataRow("DOCUMENT_ID") = Separo(1)
                        myDataRow("NUMBER_SERIE") = Separo(2)
                        myDataRow("NUMBER_DOCUMENT") = Separo(3)
                        myDataRow("ITEM") = Separo(4)
                        myDataRow("PART_ID") = Separo(5)
                        myDataRow("QTY") = Separo(6)
                        myDataRow("PRICE_SALES") = Separo(7)
                        myDataRow("PRICE_ORI") = Separo(8)
                        myDataRow("DISCOUNT") = Separo(9)
                        myDataRow("AMOUNT_TAX") = Separo(10)
                        myDataRow("TAX_PERCENT") = Separo(11)
                        myDataRow("AMOUNT_US") = Separo(12)
                        myDataRow("AMOUNT") = Separo(13)
                        myDataRow("UNIT") = Separo(14)
                        myDataRow("STATUS") = Separo(15)
                        myDataRow("PART_SERIE") = Separo(16)
                        myDataRow("WAREHOUSE_ID") = Separo(17)
                        myDataRow("TEXT_DESCRIPTION") = Separo(18)
                        myDataRow("DFTR") = Separo(19)
                        myDataRow("STOCK") = Separo(20)
                        myDataRow("PART_DESCRIPTION") = Separo(21)
                        myDataRow("QTY_REF") = Separo(22)
                        myDataRow("DISCOUNT_PERCENT") = Separo(23)
                        myDataRow("BALANCE_PART") = Separo(24)
                        myDataRow("DISCOUNT_CUSTOMER") = Separo(25)
                        myDataRow("DISCOUNT_SP") = Separo(26)
                        myDataRow("PART_LOT") = Separo(27)
                        myDataRow("NUMBER_GUIA") = Separo(28)
                        myDataRow("PART_TAX") = Separo(29)
                        myDataRow("DISCOUNT1") = Separo(30)
                        myDataRow("DISCOUNT2") = Separo(31)
                        myDataRow("PERCENT1") = Separo(32)
                        myDataRow("PERCENT2") = Separo(33)
                        myDataRow("PRICE_LIST_ID") = Separo(34)
                        myDataRow("SHIPPER_QTY") = Separo(35)

                        myDataRow("BUDGET_ID") = Separo(36)
                        myDataRow("ORDER_ID") = Separo(37)
                        myDataRow("BRUTE_QTY") = Separo(38)
                        myDataRow("DISCOUNT_QTY_BRUTE") = Separo(39)
                        myDataRow("UM_REFERENCE") = Separo(40)
                        myDataRow("QTY_REFERENCE") = Separo(41)
                        myDataRow("COMISION") = Separo(42)
                        myDataRow("TIPOISC") = Separo(43)
                        myDataRow("ISCPOR") = Separo(44)
                        myDataRow("ISC") = Separo(45)
                        
                        dtTableRL.Rows.Add(myDataRow)
                    End If
                End If
            Loop

            myStream = ImportarTxtStream(STRRuta)
            Do While myStream.Peek > -1
                STRLinea = myStream.ReadLine
                INTLine += 1
                Separo = Split(STRLinea, vbTab)
                If Separo.Length > 1 Then
                    If Separo(0).Length > 0 And Separo(0) = "WAREHOUSE_TRANS" Then
                        myDataRow = dtTableWT.NewRow
                        myDataRow("WAREHOUSE_ID") = Separo(1)
                        myDataRow("DOCUMENT_ID") = Separo(2)
                        myDataRow("NUMBER_DOCUMENT") = Separo(3)
                        myDataRow("DATE_DOCUMENT") = Separo(4)
                        myDataRow("TYPE_TRANS") = Separo(5)
                        myDataRow("TRANS_ID") = Separo(6)

                        If Separo(7) = "" Or IsDBNull(Separo(7)) Then
                            myDataRow("DOCUMENT_STATUS") = ""
                        Else
                            myDataRow("DOCUMENT_STATUS") = Separo(7)
                        End If

                        If Separo(8) = "" Or IsDBNull(Separo(8)) Then
                            myDataRow("DOC_ID_REF") = ""
                        Else
                            myDataRow("DOC_ID_REF") = Separo(8)
                        End If


                        If Separo(9) = "" Or IsDBNull(Separo(9)) Then
                            myDataRow("NUM_ID_REF") = ""
                        Else
                            myDataRow("NUM_ID_REF") = Separo(9)
                        End If


                        If Separo(10) = "" Or IsDBNull(Separo(10)) Then
                            myDataRow("AUTORIZED_ID") = ""
                        Else
                            myDataRow("AUTORIZED_ID") = Separo(10)
                        End If


                        If Separo(11) = "" Or IsDBNull(Separo(11)) Then
                            myDataRow("DATE_RETURN") = ""
                        Else
                            myDataRow("DATE_RETURN") = Separo(11)
                        End If


                        If Separo(12) = "" Or IsDBNull(Separo(12)) Then
                            myDataRow("VENDOR_ID") = ""
                        Else
                            myDataRow("VENDOR_ID") = Separo(12)
                        End If


                        If Separo(13) = "" Or IsDBNull(Separo(13)) Then
                            myDataRow("CCOST_ID") = ""
                        Else
                            myDataRow("CCOST_ID") = Separo(13)
                        End If


                        If Separo(14) = "" Or IsDBNull(Separo(14)) Then
                            myDataRow("WAREHOUSE_REF") = ""
                        Else
                            myDataRow("WAREHOUSE_REF") = Separo(14)
                        End If



                        myDataRow("COMMENT") = Separo(15)

                        If Separo(16) = "" Or IsDBNull(Separo(16)) Then
                            myDataRow("UPDATE_DATE") = Date.Today.ToString("dd/MM/yyyy")
                        Else
                            myDataRow("UPDATE_DATE") = Separo(16)
                        End If


                        If Separo(17) = "" Or IsDBNull(Separo(17)) Then
                            myDataRow("HOUR") = ""
                        Else
                            myDataRow("HOUR") = Separo(17)
                        End If



                        myDataRow("USER_ID") = Separo(18)
                        myDataRow("CUSTOMER_ID") = Separo(19)
                        myDataRow("VAT_REGISTRATION") = Separo(20)
                        myDataRow("CUSTOMER_NAME") = Separo(21)

                        If Separo(22) = "" Or IsDBNull(Separo(22)) Then
                            myDataRow("SALES_TERM") = ""
                        Else
                            myDataRow("SALES_TERM") = Separo(22)
                        End If



                        myDataRow("CURRENCY_TYPE") = Separo(23)

                        If Separo(24) = "" Or IsDBNull(Separo(24)) Then
                            myDataRow("SALES_ID") = ""
                        Else
                            myDataRow("SALES_ID") = Separo(24)
                        End If



                        myDataRow("CURRENCY_EXCHANGE") = Separo(25)

                        If Separo(26) = "" Or IsDBNull(Separo(26)) Then
                            myDataRow("TYPE_GUIA") = ""
                        Else
                            myDataRow("TYPE_GUIA") = Separo(26)
                        End If



                        myDataRow("STATUS_GUIA") = Separo(27)

                        If Separo(28) = "" Or IsDBNull(Separo(28)) Then
                            myDataRow("RECEIVABLE_GUIA") = ""
                        Else
                            myDataRow("RECEIVABLE_GUIA") = Separo(28)
                        End If


                        If Separo(29) = "" Or IsDBNull(Separo(29)) Then
                            myDataRow("ADDR_DLV") = ""
                        Else
                            myDataRow("ADDR_DLV") = Separo(29)
                        End If



                        myDataRow("CARRIER_ID") = Separo(30)
                        myDataRow("NUMBER_PURCHASE") = Separo(31)

                        If Separo(32) = "" Or IsDBNull(Separo(32)) Then
                            myDataRow("IS_GUIA_RETURN") = ""
                        Else
                            myDataRow("IS_GUIA_RETURN") = Separo(32)
                        End If


                        If Separo(33) = "" Or IsDBNull(Separo(33)) Then
                            myDataRow("VENDOR_NAME") = ""
                        Else
                            myDataRow("VENDOR_NAME") = Separo(33)
                        End If


                        If Separo(34) = "" Or IsDBNull(Separo(34)) Then
                            myDataRow("NUMBER_ORDER") = ""
                        Else
                            myDataRow("NUMBER_ORDER") = Separo(34)
                        End If


                        If Separo(35) = "" Or IsDBNull(Separo(35)) Then
                            myDataRow("NUMBER_ESTIMATING") = ""
                        Else
                            myDataRow("NUMBER_ESTIMATING") = Separo(35)
                        End If


                        myDataRow("DISCOUNT_PER_CUST") = Separo(36)
                        myDataRow("DISCOUNT_PER_SP") = Separo(37)
                        myDataRow("AMOUNT") = Separo(38)
                        myDataRow("CARRIER_NAME") = Separo(39)
                        myDataRow("CARRIER_ADDR") = Separo(40)

                        If Separo(41) = "" Or IsDBNull(Separo(41)) Then
                            myDataRow("CARRIER_VAT") = ""
                        Else
                            myDataRow("CARRIER_VAT") = Separo(41)
                        End If


                        If Separo(42) = "" Or IsDBNull(Separo(42)) Then
                            myDataRow("NUMBER_REGISTRATION") = ""
                        Else
                            myDataRow("NUMBER_REGISTRATION") = Separo(42)
                        End If


                        If Separo(43) = "" Or IsDBNull(Separo(43)) Then
                            myDataRow("NUMBER_IMPORT") = ""
                        Else
                            myDataRow("NUMBER_IMPORT") = Separo(43)
                        End If


                        If Separo(44) = "" Or IsDBNull(Separo(44)) Then
                            myDataRow("NUMBER_LIQ") = ""
                        Else
                            myDataRow("NUMBER_LIQ") = Separo(44)
                        End If


                        If Separo(45) = "" Or IsDBNull(Separo(45)) Then
                            myDataRow("PRINTER_STATUS") = ""
                        Else
                            myDataRow("PRINTER_STATUS") = Separo(45)
                        End If


                        myDataRow("STATUS_CLOSE") = Separo(46)

                        If Separo(47) = "" Or IsDBNull(Separo(47)) Then
                            myDataRow("TYPE_SHIPPER") = ""
                        Else
                            myDataRow("TYPE_SHIPPER") = Separo(47)
                        End If


                        If Separo(48) = "" Or IsDBNull(Separo(48)) Then
                            myDataRow("ZONE_FREIGHT") = ""
                        Else
                            myDataRow("ZONE_FREIGHT") = Separo(48)
                        End If



                        myDataRow("IS_GUIA") = Separo(49)
                        myDataRow("IS_POST") = Separo(50)
                        myDataRow("FREIGHT") = Separo(51)

                        If Separo(52) = "" Or IsDBNull(Separo(52)) Then
                            myDataRow("ORDER_REF") = ""
                        Else
                            myDataRow("ORDER_REF") = Separo(52)
                        End If



                        myDataRow("COST") = Separo(53)

                        If Separo(54) = "" Or IsDBNull(Separo(54)) Then
                            myDataRow("RECEP_NAME") = ""
                        Else
                            myDataRow("RECEP_NAME") = Separo(54)
                        End If


                        If Separo(55) = "" Or IsDBNull(Separo(55)) Then
                            myDataRow("DOCUMENT_RECEP") = ""
                        Else
                            myDataRow("DOCUMENT_RECEP") = Separo(55)
                        End If


                        If Separo(56) = "" Or IsDBNull(Separo(56)) Then
                            myDataRow("NUM_ORDER_MANUFACT") = ""
                        Else
                            myDataRow("NUM_ORDER_MANUFACT") = Separo(56)
                        End If


                        myDataRow("INTERFACE") = Separo(57)

                        If Separo(58) = "" Or IsDBNull(Separo(58)) Then
                            myDataRow("ACCOUNT") = ""
                        Else
                            myDataRow("ACCOUNT") = Separo(58)
                        End If


                        If Separo(59) = "" Or IsDBNull(Separo(59)) Then
                            myDataRow("PROJECT_ID") = ""
                        Else
                            myDataRow("PROJECT_ID") = Separo(59)
                        End If


                        If Separo(60) = "" Or IsDBNull(Separo(60)) Then
                            myDataRow("TRAMA_ID") = ""
                        Else
                            myDataRow("TRAMA_ID") = Separo(60)
                        End If


                        If Separo(61) = "" Or IsDBNull(Separo(61)) Then
                            myDataRow("VEHICULO_ID") = ""
                        Else
                            myDataRow("VEHICULO_ID") = Separo(61)
                        End If


                        If Separo(62) = "" Or IsDBNull(Separo(62)) Then
                            myDataRow("EMPTRA_ID") = ""
                        Else
                            myDataRow("EMPTRA_ID") = Separo(62)
                        End If


                        If Separo(63) = "" Or IsDBNull(Separo(63)) Then
                            myDataRow("FECHA_DESPACHO") = ""
                        Else
                            myDataRow("FECHA_DESPACHO") = Separo(63)
                        End If


                        If Separo(64) = "" Or IsDBNull(Separo(64)) Then
                            myDataRow("HORA_DESPACHO") = ""
                        Else
                            myDataRow("HORA_DESPACHO") = Separo(64)
                        End If


                        If Separo(65) = "" Or IsDBNull(Separo(65)) Then
                            myDataRow("STATUS_CONTROL") = ""
                        Else
                            myDataRow("STATUS_CONTROL") = Separo(65)
                        End If


                        If Separo(66) = "" Or IsDBNull(Separo(66)) Then
                            myDataRow("IS_LOTE_A_FABRICAR") = ""
                        Else
                            myDataRow("IS_LOTE_A_FABRICAR") = Separo(66)
                        End If


                        If Separo(67) = "" Or IsDBNull(Separo(67)) Then
                            myDataRow("MOV_OPTION_ID") = ""
                        Else
                            myDataRow("MOV_OPTION_ID") = Separo(67)
                        End If


                        dtTableWT.Rows.Add(myDataRow)
                    End If
                End If
            Loop

            myStream = ImportarTxtStream(STRRuta)
            Do While myStream.Peek > -1
                STRLinea = myStream.ReadLine
                INTLine += 1
                Separo = Split(STRLinea, vbTab)
                If Separo.Length > 1 Then
                    If Separo(0).Length > 0 And Separo(0) = "WAREHOUSE_TRANS_LINE" Then
                        myDataRow = dtTableWTL.NewRow
                        myDataRow("WAREHOUSE_ID") = Separo(1)
                        myDataRow("DOCUMENT_ID") = Separo(2)
                        myDataRow("NUMBER_DOCUMENT") = Separo(3)
                        myDataRow("ITEM") = Separo(4)
                        myDataRow("PART_ID") = Separo(5)

                        If Separo(6) = "" Or IsDBNull(Separo(6)) Then
                            myDataRow("REF_ID") = ""
                        Else
                            myDataRow("REF_ID") = Separo(6)
                        End If



                        myDataRow("QTY") = Separo(7)
                        myDataRow("QTY_DLV") = Separo(8)
                        myDataRow("QTY_REF") = Separo(9)
                        myDataRow("QTY_INVOICED") = Separo(10)

                        If Separo(11) = "" Or IsDBNull(Separo(11)) Then
                            myDataRow("NUM_ORDER") = ""
                        Else
                            myDataRow("NUM_ORDER") = Separo(11)
                        End If



                        myDataRow("UNIT_PRICE") = Separo(12)
                        myDataRow("AVERAGE_COST") = Separo(13)
                        myDataRow("AMOUNT_SALES") = Separo(14)
                        myDataRow("DISCOUNT") = Separo(15)

                        If Separo(16) = "" Or IsDBNull(Separo(16)) Then
                            myDataRow("STOCK") = ""
                        Else
                            myDataRow("STOCK") = Separo(16)
                        End If



                        myDataRow("AMOUNT_TAX") = Separo(17)
                        myDataRow("AMOUNT") = Separo(18)
                        myDataRow("AMOUNT_US") = Separo(19)

                        If Separo(20) = "" Or IsDBNull(Separo(20)) Then
                            myDataRow("NUMBER_SERIE") = ""
                        Else
                            myDataRow("NUMBER_SERIE") = Separo(20)
                        End If


                        If Separo(21) = "" Or IsDBNull(Separo(21)) Then
                            myDataRow("STATUS_DOC") = ""
                        Else
                            myDataRow("STATUS_DOC") = Separo(21)
                        End If


                        If Separo(22) = "" Or IsDBNull(Separo(22)) Then
                            myDataRow("DATE_DOC") = Date.Today.ToString("dd/MM/yyyy")
                        Else
                            myDataRow("DATE_DOC") = Separo(22)
                        End If


                        If Separo(23) = "" Or IsDBNull(Separo(23)) Then
                            myDataRow("CCOST_ID") = ""
                        Else
                            myDataRow("CCOST_ID") = Separo(23)
                        End If


                        If Separo(24) = "" Or IsDBNull(Separo(24)) Then
                            myDataRow("WAREHOUSE_REF") = ""
                        Else
                            myDataRow("WAREHOUSE_REF") = Separo(24)
                        End If


                        If Separo(25) = "" Or IsDBNull(Separo(25)) Then
                            myDataRow("TEXT_COMMENT") = ""
                        Else
                            myDataRow("TEXT_COMMENT") = Separo(25)
                        End If


                        If Separo(26) = "" Or IsDBNull(Separo(26)) Then
                            myDataRow("STATUS") = ""
                        Else
                            myDataRow("STATUS") = Separo(26)
                        End If


                        If Separo(27) = "" Or IsDBNull(Separo(27)) Then
                            myDataRow("TRANS_ID") = ""
                        Else
                            myDataRow("TRANS_ID") = Separo(27)
                        End If



                        myDataRow("VAL_AMOUNT") = Separo(28)

                        If Separo(29) = "" Or IsDBNull(Separo(29)) Then
                            myDataRow("NUM_VOUCHER") = ""
                        Else
                            myDataRow("NUM_VOUCHER") = Separo(29)
                        End If


                        If Separo(30) = "" Or IsDBNull(Separo(30)) Then
                            myDataRow("CURRENCY_ID") = ""
                        Else
                            myDataRow("CURRENCY_ID") = Separo(30)
                        End If


                        If Separo(31) = "" Or IsDBNull(Separo(31)) Then
                            myDataRow("TYPE") = ""
                        Else
                            myDataRow("TYPE") = Separo(31)
                        End If



                        myDataRow("TYPE_EXCHANGE") = Separo(32)
                        myDataRow("PRICE_SALES") = Separo(33)

                        If Separo(34) = "" Or IsDBNull(Separo(34)) Then
                            myDataRow("TOTAL_SALES") = ""
                        Else
                            myDataRow("TOTAL_SALES") = Separo(34)
                        End If


                        If Separo(35) = "" Or IsDBNull(Separo(35)) Then
                            myDataRow("DATE_CADUCATE") = Date.Today.ToString("dd/MM/yyyy")
                        Else
                            myDataRow("DATE_CADUCATE") = Separo(35)
                        End If



                        myDataRow("RETURN_AMOUNT") = Separo(36)

                        If Separo(37) = "" Or IsDBNull(Separo(37)) Then
                            myDataRow("AUTHORIZED") = ""
                        Else
                            myDataRow("AUTHORIZED") = Separo(37)
                        End If



                        myDataRow("PART_DESCRIPTION") = Separo(38)
                        myDataRow("DISCOUNT_PERCENT") = Separo(39)
                        myDataRow("TAX_PERCENT") = Separo(40)
                        myDataRow("DISCOUNT_CUST") = Separo(41)
                        myDataRow("DISCOUNT_SP") = Separo(42)

                        If Separo(43) = "" Or IsDBNull(Separo(43)) Then
                            myDataRow("NUMBER_INVOICE") = ""
                        Else
                            myDataRow("NUMBER_INVOICE") = Separo(43)
                        End If


                        If Separo(44) = "" Or IsDBNull(Separo(44)) Then
                            myDataRow("NUMBER_LOT") = ""
                        Else
                            myDataRow("NUMBER_LOT") = Separo(44)
                        End If



                        myDataRow("UNIT_PART") = Separo(45)

                        If Separo(46) = "" Or IsDBNull(Separo(46)) Then
                            myDataRow("ORDER_MANUFACT_ID") = ""
                        Else
                            myDataRow("ORDER_MANUFACT_ID") = Separo(46)
                        End If


                        If Separo(47) = "" Or IsDBNull(Separo(47)) Then
                            myDataRow("EQUIP_ID") = ""
                        Else
                            myDataRow("EQUIP_ID") = Separo(47)
                        End If


                        If Separo(48) = "" Or IsDBNull(Separo(48)) Then
                            myDataRow("FREIGTH") = 0
                        Else
                            myDataRow("FREIGTH") = Separo(48)
                        End If


                        If Separo(49) = "" Or IsDBNull(Separo(49)) Then
                            myDataRow("ITEMI") = ""
                        Else
                            myDataRow("ITEMI") = Separo(49)
                        End If


                        myDataRow("QTY_BRUTE") = Separo(50)
                        myDataRow("DISCOUNT_PER_QTY") = Separo(51)
                        myDataRow("STATUS_VALUE") = Separo(52)

                        If Separo(53) = "" Or IsDBNull(Separo(53)) Then
                            myDataRow("UNIT_REFERENCE") = ""
                        Else
                            myDataRow("UNIT_REFERENCE") = Separo(53)
                        End If



                        myDataRow("QTY_REFERENCE") = Separo(54)

                        If Separo(55) = "" Or IsDBNull(Separo(55)) Then
                            myDataRow("COMMENT") = ""
                        Else
                            myDataRow("COMMENT") = Separo(55)
                        End If


                        If Separo(56) = "" Or IsDBNull(Separo(56)) Then
                            myDataRow("REFERENCE") = ""
                        Else
                            myDataRow("REFERENCE") = Separo(56)
                        End If


                        If Separo(57) = "" Or IsDBNull(Separo(57)) Then
                            myDataRow("ACCOUNT") = ""
                        Else
                            myDataRow("ACCOUNT") = Separo(57)
                        End If


                        If Separo(58) = "" Or IsDBNull(Separo(58)) Then
                            myDataRow("COMMENT_TEXT") = ""
                        Else
                            myDataRow("COMMENT_TEXT") = Separo(58)
                        End If


                        If Separo(59) = "" Or IsDBNull(Separo(59)) Then
                            myDataRow("PROJECT_ID") = ""
                        Else
                            myDataRow("PROJECT_ID") = Separo(59)
                        End If


                        If Separo(60) = "" Or IsDBNull(Separo(60)) Then
                            myDataRow("QT_BULTOS") = 0
                        Else
                            myDataRow("QT_BULTOS") = Separo(60)
                        End If


                        If Separo(61) = "" Or IsDBNull(Separo(61)) Then
                            myDataRow("OPT_ENTREGA") = ""
                        Else
                            myDataRow("OPT_ENTREGA") = Separo(61)
                        End If


                        If Separo(62) = "" Or IsDBNull(Separo(62)) Then
                            myDataRow("NUM_PROTOCOLOS") = ""
                        Else
                            myDataRow("NUM_PROTOCOLOS") = Separo(62)
                        End If


                        If Separo(63) = "" Or IsDBNull(Separo(63)) Then
                            myDataRow("NUMBER_ANALIS") = ""
                        Else
                            myDataRow("NUMBER_ANALIS") = Separo(63)
                        End If


                        If Separo(64) = "" Or IsDBNull(Separo(64)) Then
                            myDataRow("PROCEDENCIA") = ""
                        Else
                            myDataRow("PROCEDENCIA") = Separo(64)
                        End If


                        If Separo(65) = "" Or IsDBNull(Separo(65)) Then
                            myDataRow("PAIS_ORIGEN") = ""
                        Else
                            myDataRow("PAIS_ORIGEN") = Separo(65)
                        End If


                        If Separo(66) = "" Or IsDBNull(Separo(66)) Then
                            myDataRow("QTY_BULTOS_ANALIZADOS") = 0
                        Else
                            myDataRow("QTY_BULTOS_ANALIZADOS") = Separo(66)
                        End If

                        dtTableWTL.Rows.Add(myDataRow)
                    End If
                End If
            Loop


            If reporteBL.Ejecutar_Eliminacion_Movimientos_Temporales("SP_IMPORTAR_LIMPIAR_CUSTOMER_BALANCE_IMPORTACION") = True Then
                If reporteBL.CopyDataTableBulk(dtTable, dtTableR, dtTableRL, dtTableWT, dtTableWTL, "CUSTOMER_BALANCE_IMPORTACION", "RECEIVABLE_IMPORTACION", "RECEIVABLE_LINE_IMPORTACION", "WAREHOUSE_TRANS_IMPORTACION", "WAREHOUSE_TRANS_LINE_IMPORTACION") Then
                    If reporteBL.Ejecutar_Importacion_Movimientos("SP_IMP_MOV_CUSTOMER_BALANCE", "SP_IMP_MOV_RECEIVABLE", "SP_IMP_MOV_RECEIVABLE_LINE", "SP_IMP_MOV_WAREHOUSE_TRANS", "SP_IMP_MOV_WAREHOUSE_TRANS_LINE") = True Then
                        Return True
                    Else
                        Return False
                    End If
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
   

    Private Function CreateTextDelimiterFile(ByVal fileName As String, _
                                         ByVal dt As DataTable, _
                                         ByVal separatorChar As Char, _
                                         ByVal hdr As Boolean, _
                                         ByVal textDelimiter As Boolean) As Boolean

        Dim i As Integer
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim clase_excel As New ClsReporteGenerales.ReportesGerenciales

        ' Si no se ha especificado un nombre de archivo,
        ' o el objeto DataTable no es válido, provocamos
        ' una excepción de argumentos no válidos.
        '
        If (fileName = String.Empty) OrElse _
           (dt Is Nothing) Then Throw New System.ArgumentException("Argumentos no válidos.")

        ' Si el archivo existe, solicito confirmación para sobreescribirlo.
        '
        If (IO.File.Exists(fileName)) Then
            If (MessageBox.Show("Ya existe un archivo de texto con el mismo nombre." & Environment.NewLine & _
                               "¿Desea sobrescribirlo?", _
                               "Crear archivo de texto delimitado", _
                               MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Information) = DialogResult.No) Then Return False
        End If

        Dim sw As System.IO.StreamWriter

        Try
            Dim col As Integer = 0
            Dim value As String = String.Empty
            sw = New IO.StreamWriter(fileName, False, System.Text.Encoding.Default)
            If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Return False : Exit Function
            NombreStore = "SP_EXPORTAR_MOV_RECEIVABLE"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                For Each dr As DataRow In dt_tmp.Rows
                    For Each dc As DataColumn In dt_tmp.Columns
                        If ((dc.DataType Is System.Type.GetType("System.String")) And _
                           (textDelimiter = True)) Then
                            value &= """" & dr.Item(col).ToString & """" & separatorChar
                        Else
                            value &= dr.Item(col).ToString & separatorChar
                        End If
                        col += 1
                    Next
                    sw.WriteLine(value.Remove(value.Length - 1, 1))
                    value = String.Empty
                    col = 0

                Next ' Siguiente fila

            End If
            NombreStore = "SP_EXPORTAR_MOV_RECEIVABLE_LINE"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                For Each dr As DataRow In dt_tmp.Rows
                    For Each dc As DataColumn In dt_tmp.Columns
                        If ((dc.DataType Is System.Type.GetType("System.String")) And _
                           (textDelimiter = True)) Then
                            value &= """" & dr.Item(col).ToString & """" & separatorChar
                        Else
                            value &= dr.Item(col).ToString & separatorChar
                        End If
                        col += 1
                    Next
                    sw.WriteLine(value.Remove(value.Length - 1, 1))
                    value = String.Empty
                    col = 0

                Next ' Siguiente fila

            End If
            NombreStore = "SP_EXPORTAR_MOV_WAREHOUSE_TRANS"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                For Each dr As DataRow In dt_tmp.Rows
                    For Each dc As DataColumn In dt_tmp.Columns
                        If ((dc.DataType Is System.Type.GetType("System.String")) And _
                           (textDelimiter = True)) Then
                            value &= """" & dr.Item(col).ToString & """" & separatorChar
                        Else
                            value &= dr.Item(col).ToString & separatorChar
                        End If
                        col += 1
                    Next
                    sw.WriteLine(value.Remove(value.Length - 1, 1))
                    value = String.Empty
                    col = 0

                Next ' Siguiente fila

            End If
            NombreStore = "SP_EXPORTAR_MOV_WAREHOUSE_TRANS_LINE"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                For Each dr As DataRow In dt_tmp.Rows
                    For Each dc As DataColumn In dt_tmp.Columns
                        If ((dc.DataType Is System.Type.GetType("System.String")) And _
                           (textDelimiter = True)) Then
                            value &= """" & dr.Item(col).ToString & """" & separatorChar
                        Else
                            value &= dr.Item(col).ToString & separatorChar
                        End If
                        col += 1
                    Next
                    sw.WriteLine(value.Remove(value.Length - 1, 1))
                    value = String.Empty
                    col = 0

                Next ' Siguiente fila

            End If
            NombreStore = "SP_EXPORTAR_MOV_CUSTOMER_BALANCE"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ExportarMovimientos(NombreStore, Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
            If dt_tmp.Rows.Count() <> 0 Then
                For Each dr As DataRow In dt_tmp.Rows
                    For Each dc As DataColumn In dt_tmp.Columns
                        If ((dc.DataType Is System.Type.GetType("System.String")) And _
                           (textDelimiter = True)) Then
                            value &= """" & dr.Item(col).ToString & """" & separatorChar
                        Else
                            value &= dr.Item(col).ToString & separatorChar
                        End If
                        col += 1
                    Next
                    sw.WriteLine(value.Remove(value.Length - 1, 1))
                    value = String.Empty
                    col = 0

                Next ' Siguiente fila

            End If
            sw.Close()
            ' Se ha creado con éxito el archivo de texto.
            Return True
        Catch ex As Exception
            Return False
        Finally
            sw = Nothing
        End Try
    End Function

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Notificar el progreso de la tarea
        Me.ProgressBar1.Value = e.ProgressPercentage
        'Representa el porcentaje del progreso en el Label1.Text
        Label1.Text = e.ProgressPercentage & "%"
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
    Private Sub dtpfechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaInicio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub rdbsunat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbsunat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rdbconcar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbconcar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub rdbsunat_CheckedChanged(sender As Object, e As EventArgs) Handles rdbsunat.CheckedChanged
        If rdbsunat.Checked = True Then
            txtArchivo.Text = "Exportar_Movimientos"
        End If
    End Sub

    Private Sub rdbconcar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbconcar.CheckedChanged
        If rdbconcar.Checked = True Then
            txtArchivo.Text = "Importar_Movimientos"
        End If
    End Sub
End Class