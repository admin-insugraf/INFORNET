Imports System.Windows.Forms
Public Class frm_AF_RP_deter_depreci

    Private Sub frm_AF_RP_deter_depreci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        mtb_fec_proc.Text = "" 'LibComunVar.ClsVarComun.FechaSistema
        mtb_fec_proc.Focus()
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click

        If Not mtb_fec_proc.MaskFull Then
            MsgBox("Ingrese la fecha de corte")
            mtb_fec_proc.Focus()
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim activoBL As New ClsOperaciones.ReportesAF
            Dim dt_tmp As DataTable = activoBL.get_reporte_determeinacion_depreciacion(mtb_fec_proc.Text)
            dgv_listado.DataSource = dt_tmp
            dgv_listado.Focus()
            activoBL = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
        
    End Sub

    Private Sub Tool_exportar_Click(sender As Object, e As EventArgs) Handles Tool_exportar.Click

        If dgv_listado.RowCount = 0 Then Exit Sub

        Dim Carpeta As New FolderBrowserDialog
        Dim ruta_archivo As String
        If Carpeta.ShowDialog() = DialogResult.OK Then
            ruta_archivo = Carpeta.SelectedPath.ToString & "\"
        End If


        Me.Cursor = Cursors.WaitCursor

        Const xlEdgeLeft = 7
        Const xlEdgeRight = 10
        Const xlEdgeTop = 8
        Const xlEdgeBottom = 9
        Const xlInsideHorizontal = 12
        Const xlInsideVertical = 11
        Const xlContinuous = 1
        Const xlThin = 2

        Dim excel As Object
        Dim wBook As Object
        Dim wSheet As Object

        excel = CreateObject("Excel.Application")
        wBook = excel.Workbooks.Add
        wSheet = wBook.Worksheets(1)


        'wBook = excel.Workbooks.Add()
        'wSheet = wBook.ActiveSheet()

        wSheet.Name = "Depreciación por Activo"

        excel.Cells(1, 1) = "Empresa"
        excel.Cells(2, 1) = "Ruc"
        excel.Cells(1, 2) = LibComunVar.ClsVarComun.NomEmpresa
        excel.Cells(2, 2) = "'" & LibComunVar.ClsVarComun.RucEmpresa
        wSheet.Range("B1", "B2").Font.Bold = True


        excel.Cells(5, 2) = "Depreciación Acumulada al " & mtb_fec_proc.Text
        'http://www.functionx.com/vbaexcel/cells/Lesson2.htm

        wSheet.Range("B5", "B5").Font.Size = 14
        wSheet.Range("B5", "B5").Font.Bold = True
        wSheet.Range("B5", "B5").Font.Name = "Cambria"
        wSheet.Range("B5", "B5").Font.ThemeColor = 5
        wSheet.Range("B5", "H5").MergeCells = True
        wSheet.Range("B5", "H5").HorizontalAlignment = 3



        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 8

        excel.Cells(cont_filas_tmp, 2) = "ACTIVO"
        excel.Cells(cont_filas_tmp, 3) = "FECHA"
        excel.Cells(cont_filas_tmp, 4) = "SALDO INICIAL"
        excel.Cells(cont_filas_tmp, 5) = "MEJORAS"
        excel.Cells(cont_filas_tmp, 6) = "FAMILIA"
        excel.Cells(cont_filas_tmp, 7) = "TASA%"
        excel.Cells(cont_filas_tmp, 8) = "AÑOS A DEPRECIAR"
        excel.Cells(cont_filas_tmp, 9) = "DEPREC. ANUAL"
        excel.Cells(cont_filas_tmp, 10) = "MESES A DEPRECIAR"
        excel.Cells(cont_filas_tmp, 11) = "DEPRE. MENSUAL"
        excel.Cells(cont_filas_tmp, 12) = "DEPRE. ACUMULADA DEL EJERCICIO"
        excel.Cells(cont_filas_tmp, 13) = "AÑOS TRANSCURRIDOS"
        excel.Cells(cont_filas_tmp, 14) = "MESES TRANSCURRIDOS"
        excel.Cells(cont_filas_tmp, 15) = "ACUMULADO A LA FECHA"
        wSheet.Range("B8", "O8").Font.Bold = True
        wSheet.Range("B8", "O8").HorizontalAlignment = 3
        wSheet.Range("B8", "O8").VerticalAlignment = 3
        wSheet.Range("B8", "O8").Font.Size = 12
        wSheet.Range("B8", "O8").Font.ThemeColor = 4
        wSheet.Range("B8", "O8").Interior.ColorIndex = 20
        'colores de excel por interior indeces
        ''http://dmcritchie.mvps.org/excel/colors.htm


        wSheet.Range("D9", "E11").EntireColumn.NumberFormat = "###,###,###.00"
        wSheet.Range("O9", "O11").EntireColumn.NumberFormat = "###,###,###.00"


        'puntuados suaves
        'Range("H16").Borders(xlEdgeBottom).LineStyle = xlContinuous
        'Range("H16:I16").Borders(xlEdgeBottom).Weight = xlMedium


        'With wSheet.Range("B5", "B5").Borders(xlEdgeBottom)
        '    .Weight = xlThin
        '    .LineStyle = xlContinuous
        '    .ColorIndex = 0
        '    '.TintAndShade = 0
        'End With

        With wSheet.Range("B8", "O8").Borders(xlEdgeBottom)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With

        With wSheet.Range("B8", "O8").Borders(xlEdgeTop)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With


        Dim cta_Activo_ant As String = ""

        'If dgv_listado.Rows.Count > 0 Then
        '    cta_Activo_ant = dgv_listado.Rows(0).Cells("FA_CUENTA_ACTIVO").Value.ToString
        'End If

        cont_filas_tmp = 9
        For f As Integer = 0 To dgv_listado.Rows.Count - 1

            If dgv_listado.Rows(f).Cells("FA_CUENTA_ACTIVO").Value <> cta_Activo_ant Then

                cta_Activo_ant = dgv_listado.Rows(f).Cells("FA_CUENTA_ACTIVO").Value.ToString

                excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("FA_CUENTA_ACTIVO").Value & " " & dgv_listado.Rows(f).Cells("FAMILIA").Value
                wSheet.Range("B" & cont_filas_tmp + f, "B" & cont_filas_tmp + f).Font.Bold = True
                excel.Cells(cont_filas_tmp + f, 3) = "" 'dgv_listado.Rows(f).Cells("FECHA").Value
                excel.Cells(cont_filas_tmp + f, 4) = "" 'dgv_listado.Rows(f).Cells("SALDO_INICIAL").Value
                excel.Cells(cont_filas_tmp + f, 5) = "" 'dgv_listado.Rows(f).Cells("MEJORAS").Value
                excel.Cells(cont_filas_tmp + f, 6) = "" 'dgv_listado.Rows(f).Cells("FAMILIA").Value
                excel.Cells(cont_filas_tmp + f, 7) = "" 'dgv_listado.Rows(f).Cells("TASA_DEP").Value
                excel.Cells(cont_filas_tmp + f, 8) = "" 'dgv_listado.Rows(f).Cells("TB1_AÑOS_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 9) = "" 'dgv_listado.Rows(f).Cells("TB1_DEPRE_ANUAL").Value
                excel.Cells(cont_filas_tmp + f, 10) = "" 'dgv_listado.Rows(f).Cells("TB1_MESES_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 11) = "" 'dgv_listado.Rows(f).Cells("TB1_DEPRE_MENSUAL").Value
                excel.Cells(cont_filas_tmp + f, 12) = "" 'dgv_listado.Rows(f).Cells("TB1_DEPRE_MENSUAL").Value
                excel.Cells(cont_filas_tmp + f, 13) = "" 'dgv_listado.Rows(f).Cells("TB2_AÑOS_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 14) = "" 'dgv_listado.Rows(f).Cells("TB2_MESES_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 15) = "" 'dgv_listado.Rows(f).Cells("A_LA_FECHA").Value

                cont_filas_tmp = cont_filas_tmp + 1
                excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("ACTIVO").Value
                excel.Cells(cont_filas_tmp + f, 3) = dgv_listado.Rows(f).Cells("FECHA").Value
                excel.Cells(cont_filas_tmp + f, 4) = dgv_listado.Rows(f).Cells("SALDO_INICIAL").Value
                excel.Cells(cont_filas_tmp + f, 5) = dgv_listado.Rows(f).Cells("MEJORAS").Value
                excel.Cells(cont_filas_tmp + f, 6) = dgv_listado.Rows(f).Cells("FAMILIA").Value
                excel.Cells(cont_filas_tmp + f, 7) = dgv_listado.Rows(f).Cells("TASA_DEP").Value
                excel.Cells(cont_filas_tmp + f, 8) = dgv_listado.Rows(f).Cells("TB1_AÑOS_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 9) = dgv_listado.Rows(f).Cells("TB1_DEPRE_ANUAL").Value
                excel.Cells(cont_filas_tmp + f, 10) = dgv_listado.Rows(f).Cells("TB1_MESES_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 11) = dgv_listado.Rows(f).Cells("TB1_DEPRE_MENSUAL").Value
                excel.Cells(cont_filas_tmp + f, 12) = dgv_listado.Rows(f).Cells("TB1_DEPRE_EJERCICIO").Value
                excel.Cells(cont_filas_tmp + f, 13) = dgv_listado.Rows(f).Cells("TB2_AÑOS_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 14) = dgv_listado.Rows(f).Cells("TB2_MESES_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 15) = dgv_listado.Rows(f).Cells("A_LA_FECHA").Value

            Else
                excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("ACTIVO").Value
                excel.Cells(cont_filas_tmp + f, 3) = dgv_listado.Rows(f).Cells("FECHA").Value
                excel.Cells(cont_filas_tmp + f, 4) = dgv_listado.Rows(f).Cells("SALDO_INICIAL").Value
                excel.Cells(cont_filas_tmp + f, 5) = dgv_listado.Rows(f).Cells("MEJORAS").Value
                excel.Cells(cont_filas_tmp + f, 6) = dgv_listado.Rows(f).Cells("FAMILIA").Value
                excel.Cells(cont_filas_tmp + f, 7) = dgv_listado.Rows(f).Cells("TASA_DEP").Value
                excel.Cells(cont_filas_tmp + f, 8) = dgv_listado.Rows(f).Cells("TB1_AÑOS_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 9) = dgv_listado.Rows(f).Cells("TB1_DEPRE_ANUAL").Value
                excel.Cells(cont_filas_tmp + f, 10) = dgv_listado.Rows(f).Cells("TB1_MESES_A_DEPRECIAR").Value
                excel.Cells(cont_filas_tmp + f, 11) = dgv_listado.Rows(f).Cells("TB1_DEPRE_MENSUAL").Value
                excel.Cells(cont_filas_tmp + f, 12) = dgv_listado.Rows(f).Cells("TB1_DEPRE_EJERCICIO").Value
                excel.Cells(cont_filas_tmp + f, 13) = dgv_listado.Rows(f).Cells("TB2_AÑOS_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 14) = dgv_listado.Rows(f).Cells("TB2_MESES_TRANSCURRIDOS").Value
                excel.Cells(cont_filas_tmp + f, 15) = dgv_listado.Rows(f).Cells("A_LA_FECHA").Value
                'excel.Cells(cont_filas_tmp + f, 14) = dgv_listado.Rows(f).Cells("SERIE").Value
            End If

        Next

        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        'Dim strFileName As String = "C:\" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second & ".xls"
        Dim strFileName As String = ruta_archivo & "Depreciacion_x_Activo_" & CDate(mtb_fec_proc.Text).Year & "_" & CDate(mtb_fec_proc.Text).Month & ".xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mtb_fec_proc_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_proc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_procesar_Click(sender, e)
        End If
    End Sub
End Class