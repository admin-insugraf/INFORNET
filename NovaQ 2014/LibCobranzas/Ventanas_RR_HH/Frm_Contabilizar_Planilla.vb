Imports System.Drawing
Imports System.Windows.Forms
Imports LibComunVar
Imports LibContabilidad
Imports LibActivo

Public Class Frm_Contabilizar_Planilla

    Private Sub Frm_Contabilizar_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Subdiario()
        txt_numero_planilla.Text = ""
    End Sub

    Private Sub Cargar_Subdiario()
        Dim su As New LibActivo.ClsOperaciones.AF_MA_ACTIVO
        cmb_subdiario.DataSource = su.get_Subdiario_x_Ope(5)
        cmb_subdiario.DisplayMember = "SD_DESCRIPCION"
        cmb_subdiario.ValueMember = "SD_ID"
        su = Nothing
    End Sub

    Private Sub Tool_Procesar_Click(sender As Object, e As EventArgs) Handles Tool_Procesar.Click
        If txt_numero_planilla.Text = "" Then ' cmb_mes.SelectedIndex = 0 Then
            MsgBox("Debe elegir un N° de Planilla.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_numero_planilla.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim activoBL As New LibActivo.ClsOperaciones.AF_MA_ACTIVO
        Dim dt_tmp As DataTable = activoBL.Procesar_Asiento_Contable_Planilla(txt_numero_planilla.Text)
        Dim total As Double = 0
       
        Dim cont As Integer = 0
        dgv_vista.Rows.Clear()
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            dgv_vista.Rows.Add()
            dgv_vista.Rows(cont).Cells("col_item").Value = dt_tmp.Rows(i)("item")
            dgv_vista.Rows(cont).Cells("col_num").Value = dt_tmp.Rows(i)("cuenta_contable")
            dgv_vista.Rows(cont).Cells("col_des").Value = dt_tmp.Rows(i)("cuenta")
            dgv_vista.Rows(cont).Cells("col_debe").Value = dt_tmp.Rows(i)("debe")
            dgv_vista.Rows(cont).Cells("col_haber").Value = dt_tmp.Rows(i)("haber")
            dgv_vista.Rows(cont).Cells("col_item_destino").Value = dt_tmp.Rows(i)("item_destino")
            dgv_vista.Rows(cont).Cells("col_porcentaje").Value = dt_tmp.Rows(i)("porcentaje")

            dgv_vista.Rows(cont).Cells("ANEXO").Value = dt_tmp.Rows(i)("ANEXO")
            dgv_vista.Rows(cont).Cells("TIPO_ANEXO").Value = dt_tmp.Rows(i)("TIPO_ANEXO")

            dgv_vista.Update()
            cont += 1
        Next

        dgv_vista.Columns(0).Width = 30
        dgv_vista.Columns(1).Width = 60
        dgv_vista.Columns(2).Width = 300
        dgv_vista.Columns(3).Width = 100
        dgv_vista.Columns(4).Width = 100
        dgv_vista.Columns(5).Width = 150
        dgv_vista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.Cursor = Cursors.Default

        txt_tot_debe.Text = dt_tmp.Compute("sum(DEBE)", "ITEM_DESTINO=0")
        txt_tot_haber.Text = dt_tmp.Compute("sum(HABER)", "ITEM_DESTINO=0")

        txt_tot_debe.Text = Format(Double.Parse(txt_tot_debe.Text), "##,##0.00")
        txt_tot_haber.Text = Format(Double.Parse(txt_tot_haber.Text), "##,##0.00")

        'dgv_vista.DataSource = dt_tmp

        MsgBox("Listo! - Asiento Generado", MsgBoxStyle.Information, "Sistema Activo")

        dtp_fec_vou.Focus()
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Generar_Click(sender As Object, e As EventArgs) Handles Tool_Generar.Click
        Try

            If MessageBox.Show("¿Desea generar el Comprobante de Planilla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim tc As Double = 0.0
                Dim num_voucher As String = String.Empty

                If mtb_tc.Text.Trim() <> 0 Then
                    tc = Double.Parse(mtb_tc.Text)
                End If

                If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
                    num_voucher = ac.get_Ult_num_voucher(cmb_subdiario.SelectedValue, dtp_fec_vou.Value.Year, Format(dtp_fec_vou.Value.Month, "00"))
                    ac = Nothing
                Else
                    Dim codigo As String = String.Empty
                    codigo = InputBox("Ingrese numero de asiento")
                    If codigo = String.Empty Then
                        MsgBox("Es necesario una numeración.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    codigo = Format(dtp_fec_vou.Value.Month, "00") & codigo.PadLeft(4, Char.Parse("0"))
                    Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                    Dim dtcodigo As New DataTable
                    dtcodigo = ClsasientoBl.ValidarCodigo(cmb_subdiario.SelectedValue, codigo, dtp_fec_vou.Value.Year, dtp_fec_vou.Value.Month)
                    If dtcodigo.Rows.Count() <> 0 Then
                        MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        num_voucher = codigo
                    End If
                End If
                If IngresarDetallesAsientoContable(tc, num_voucher) = True Then
                    MsgBox("Asiento Contable generado correctamente", MsgBoxStyle.Information, "Aviso")
                    txt_numero_planilla.Text = ""
                    dtp_fec_vou.Value = Date.Now
                    mtb_tc.Text = ""
                    txt_glosa.Text = ""
                    dgv_vista.Rows.Clear()
                    txt_numero_planilla.Focus()
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Function IngresarDetallesAsientoContable(ByVal _TipoCambio As Double, ByVal _num_voucher As String) As Boolean
        Dim _RESULTADO As Boolean = True
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New LibContabilidad.ClsOperaciones.Asiento_Contable
            Dim d As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
            Dim id_asiento As Integer

            cab.AC_ID = 0
            cab.AC_IDSUBDIARIO = cmb_subdiario.SelectedValue
            cab.AC_NUM_VOUCHER = _num_voucher
            cab.AC_ANHO = DateTime.Parse(dtp_fec_vou.Text).Year
            cab.AC_MES = DateTime.Parse(dtp_fec_vou.Text).Month
            cab.AC_FEC_VOUCHER = dtp_fec_vou.Value.ToString("dd/MM/yyyy")
            cab.AC_IDMONEDA = 1
            cab.AC_DEBE = Double.Parse(txt_tot_debe.Text)
            cab.AC_HABER = Double.Parse(txt_tot_haber.Text)
            cab.AC_ESTADO = 1
            cab.AC_GLOSA_VOU = txt_glosa.Text.Trim()
            cab.AC_ES_INTERFACE = 0
            cab.AC_IDPLANILLA = ""
            cab.AC_RUC = ""
            cab.AC_TIPO_DOC = ""
            cab.AC_SER_DOC = ""
            cab.AC_NUM_DOC = ""
            cab.AC_FEC_DOC = dtp_fec_vou.Value.ToString("dd/MM/yyyy")
            cab.AC_FEC_DOC_VENCE = dtp_fec_vou.Value.ToString("dd/MM/yyyy")
            cab.AC_POR_IGV = 0
            cab.AC_VAL_IGV = 0
            cab.AC_TOTAL_DOC = 0
            cab.AC_TIPO_CAMBIO = _TipoCambio
            cab.AC_GLOSA_TRANSACCION = txt_glosa.Text
            cab.AC_DESTINO = ""
            cab.AC_POR_ISC = 0
            cab.AC_ISC = 0
            cab.AC_POR_DETRAC = 0
            cab.AC_FEC_PLE = dtp_fec_vou.Value.ToShortDateString
            cab.AC_TIPO_DOC_REF = ""
            cab.AC_SER_DOC_REF = ""
            cab.AC_NUM_DOC_REF = ""
            cab.AC_FEC_DOC_REF = ""
            cab.AC_DETRAC = 0
            cab.AC_DUA = 0
            asiento.Guardar_Asiento_Cabecera(cab)
            id_asiento = cab.AC_ID.ToString()

            For I As Integer = 0 To dgv_vista.Rows.Count - 1
                d = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                d.AD_IDCAB = id_asiento
                d.AD_SECUENCIA = dgv_vista.Rows(I).Cells("col_item").Value
                d.AD_CUENTA = dgv_vista.Rows(I).Cells("col_num").Value
                d.AD_TANEXO = dgv_vista.Rows(I).Cells("TIPO_ANEXO").Value
                d.AD_IDANEXO = dgv_vista.Rows(I).Cells("ANEXO").Value
                d.AD_TDOC = "PL"
                d.AD_SDOC = ""
                d.AD_NDOC = Strings.Left(dtp_fec_vou.Value.ToString("MM"), 3) & dtp_fec_vou.Value.Year.ToString
                d.AD_FDOC = dtp_fec_vou.Value.ToString("dd/MM/yyyy")
                d.AD_VDOC = ""
                d.AD_DEBE = dgv_vista.Rows(I).Cells("col_debe").Value
                d.AD_HABER = dgv_vista.Rows(I).Cells("col_haber").Value
                d.AD_TCAM = _TipoCambio
                d.AD_SEC_ORI_DES = dgv_vista.Rows(I).Cells("col_item_destino").Value
                d.AD_IDCC = ""
                d.AD_ES_DESTINO = 0
                d.AD_IDMEDIOPAGO = ""
                d.AD_MONTO_ORI = d.AD_DEBE + d.AD_HABER
                d.AD_PORCE_DESTINO = dgv_vista.Rows(I).Cells("col_porcentaje").Value
                d.AD_ES_CONCI = 0
                d.AD_ANHO_CONI = 0
                d.AD_MES_CONCI = 0
                d.AD_ES_INAFECTO = 0
                d.AD_IDMONEDA = 1
                d.AD_TDOC_REF = ""
                d.AD_SDOC_REF = ""
                d.AD_NDOC_REF = ""
                d.AD_FDOC_REF = ""
                d.AD_VDOC_REF = ""
                d.AD_GLOSA = txt_glosa.Text.Trim()
                d.AD_PERCEN_DETRACC = 0
                detalles.Add(d)
            Next
            asiento.Guardar_Asiento_Detalle_Activo_Fijo(detalles, cab)
            _RESULTADO = True
            Me.Cursor = Cursors.Default
            Return _RESULTADO

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Tool_exportar_Click(sender As Object, e As EventArgs) Handles Tool_exportar.Click


        'Me.Cursor = Cursors.WaitCursor

        'Dim Carpeta As New FolderBrowserDialog
        'Dim ruta_archivo As String
        'If Carpeta.ShowDialog() = DialogResult.OK Then
        '    ruta_archivo = Carpeta.SelectedPath.ToString & "\"
        'End If

        'Const xlEdgeLeft = 7
        'Const xlEdgeRight = 10
        'Const xlEdgeTop = 8
        'Const xlEdgeBottom = 9
        'Const xlInsideHorizontal = 12
        'Const xlInsideVertical = 11
        'Const xlContinuous = 1
        'Const xlThin = 2

        'Dim excel As Object
        'Dim wBook As Object
        'Dim wSheet As Object

        'excel = CreateObject("Excel.Application")
        ''wBook = excel.Workbooks.Add
        ''wSheet = wBook.Worksheets(1)


        'wBook = excel.Workbooks.Add()
        'wSheet = wBook.ActiveSheet()

        'wSheet.Name = "Asiento Contable"

        'excel.Cells(1, 1) = "Empresa"
        'excel.Cells(2, 1) = "Ruc"
        'excel.Cells(1, 3) = LibComunVar.ClsVarComun.NomEmpresa
        'excel.Cells(2, 3) = "'" & LibComunVar.ClsVarComun.RucEmpresa

        'wSheet.Range("A1", "C2").Font.Bold = True

        'excel.Cells(4, 3) = "Asientos Contables - Depreciación y Amortización Acumulada"
        'excel.Cells(5, 3) = Format(CDate(mtb_fec_proc.Text).Month, "00") & " - " & CDate(mtb_fec_proc.Text).Year
        'excel.Cells(6, 3) = "(Expresado en Nuevos Soles)"

        'wSheet.Range("C4", "C6").Font.Bold = True
        'wSheet.Range("C4", "C6").HorizontalAlignment = 3

        'Dim cont_filas_tmp As Integer = 0
        'cont_filas_tmp = 8

        'excel.Cells(cont_filas_tmp, 2) = "Num. Cuenta"
        'excel.Cells(cont_filas_tmp, 3) = "Cuenta Contable"
        'excel.Cells(cont_filas_tmp, 4) = "DEBE"
        'excel.Cells(cont_filas_tmp, 5) = "HABER"

        'wSheet.Range("B8", "F8").Font.Bold = True

        'With wSheet.Range("B8", "F8").Borders(xlEdgeBottom)
        '    .Weight = xlThin
        '    .LineStyle = xlContinuous
        '    .ColorIndex = 0
        '    '.TintAndShade = 0
        'End With

        'With wSheet.Range("B8", "F8").Borders(xlEdgeTop)
        '    .Weight = xlThin
        '    .LineStyle = xlContinuous
        '    .ColorIndex = 0
        '    '.TintAndShade = 0
        'End With


        'cont_filas_tmp = 9

        'For f As Integer = 0 To dgv_vista.Rows.Count - 1
        '    excel.Cells(cont_filas_tmp + f, 2) = dgv_vista.Rows(f).Cells("col_num").Value
        '    excel.Cells(cont_filas_tmp + f, 3) = dgv_vista.Rows(f).Cells("col_des").Value
        '    excel.Cells(cont_filas_tmp + f, 4) = dgv_vista.Rows(f).Cells("col_debe").Value
        '    excel.Cells(cont_filas_tmp + f, 5) = dgv_vista.Rows(f).Cells("col_haber").Value
        'Next

        'cont_filas_tmp = cont_filas_tmp + dgv_vista.Rows.Count + 1

        'excel.Cells(cont_filas_tmp, 3) = "Totales"
        'excel.Cells(cont_filas_tmp, 4) = txt_tot_debe.Text
        'excel.Cells(cont_filas_tmp, 5) = txt_tot_haber.Text



        'wSheet.Columns.AutoFit()

        ''****************** finalizamos *******************
        'Dim strFileName As String = ruta_archivo & "Asiento_Contable_Depreciacion_" & Format(CDate(mtb_fec_proc.Text).Month, "00") & " - " & CDate(mtb_fec_proc.Text).Year & ".xls"
        'Dim blnFileOpen As Boolean = False
        'Try
        '    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
        '    fileTemp.Close()
        'Catch ex As Exception
        '    blnFileOpen = False
        '    Me.Cursor = Cursors.Default
        'End Try

        'If System.IO.File.Exists(strFileName) Then
        '    System.IO.File.Delete(strFileName)
        'End If

        'wBook.SaveAs(strFileName)
        'excel.Workbooks.Open(strFileName)
        'excel.Visible = True

        'Me.Cursor = Cursors.Default

    End Sub


    Private Sub txtmes_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Tool_Procesar_Click(sender, e)
        End If

    End Sub

    Private Sub txtmes_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub mtb_fec_proc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Tool_Procesar_Click(sender, e)
        End If
    End Sub

    Private Sub dtp_fec_vou_Leave(sender As Object, e As EventArgs) Handles dtp_fec_vou.Leave
        Dim AsientoContableCabs As LibContabilidad.ClsOperaciones.Asiento_Contable
        Dim DtDetallesAsientoC As DataTable
        Dim SQL As String = String.Empty
        AsientoContableCabs = New LibContabilidad.ClsOperaciones.Asiento_Contable
        DtDetallesAsientoC = New DataTable("TipoCambioFecha")
        SQL = "SELECT SELL_RATE, BUY_RATE FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & dtp_fec_vou.Value.ToString("dd/MM/yyyy") & "'"
        DtDetallesAsientoC = AsientoContableCabs.MuestraDescripcion(SQL)
        If DtDetallesAsientoC.Rows.Count() <> 0 Then
            mtb_tc.Text = DtDetallesAsientoC.Rows(0).Item("SELL_RATE").ToString
            txt_glosa.Focus()
        Else
            MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Critical)
            mtb_tc.Text = String.Empty
            dtp_fec_vou.Focus()
        End If

    End Sub

    Private Sub dtp_fec_vou_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fec_vou.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_glosa.Focus()
        End If
    End Sub

    Private Sub txt_numero_planilla_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_numero_planilla.MouseDoubleClick
        Ayuda_PLanillas(txt_numero_planilla, txt_descripcion_planilla)
    End Sub

    Private Sub txt_numero_planilla_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_planilla.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_PLanillas(txt_numero_planilla, txt_descripcion_planilla)
        End If
    End Sub

    Private Sub Ayuda_PLanillas(ByVal CajaTexto As TextBox, ByVal CajaTexto_des As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_PL_PLANILLA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Planillas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                CajaTexto_des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Else
                CajaTexto.Text = ""
                CajaTexto_des.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class