Imports System.Windows.Forms

Public Class frm_AF_LT_Deprecioacion_Anual

    Private Sub frm_AF_LT_Deprecioacion_Anual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Procesar_Click(sender As Object, e As EventArgs) Handles Tool_Procesar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        Dim dt_tmp As DataTable = activoBL.Procesar_Depreciacion_Anual(nud_anho.Value)
        activoBL = Nothing

        dgv_data.DataSource = dt_tmp

        Me.Cursor = Cursors.Default

        MsgBox("Listo!", MsgBoxStyle.Information, "Sistema Activo")

    End Sub

    Private Sub Tool_exportar_Click(sender As Object, e As EventArgs) Handles Tool_exportar.Click
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
        'wBook = excel.Workbooks.Add
        'wSheet = wBook.Worksheets(1)


        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        wSheet.Name = "Deprecacion Anual"

        excel.Cells(1, 1) = "Empresa"
        excel.Cells(2, 1) = "Ruc"
        excel.Cells(1, 3) = LibComunVar.ClsVarComun.NomEmpresa
        excel.Cells(2, 3) = "'" & LibComunVar.ClsVarComun.RucEmpresa

        excel.Cells(4, 3) = "Depreciación y Amortización Acumulada"
        excel.Cells(5, 3) = nud_anho.Value
        excel.Cells(6, 3) = "(Expresado en Nuevos Soles)"

        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 8


        For c As Integer = 2 To dgv_data.ColumnCount - 1
            excel.Cells(cont_filas_tmp, c) = dgv_data.Columns(c).HeaderText
        Next

        'excel.Cells(cont_filas_tmp, 2) = "Num. Cuenta"
        'excel.Cells(cont_filas_tmp, 3) = "Cuenta Contable"
        'excel.Cells(cont_filas_tmp, 4) = "DEBE"
        'excel.Cells(cont_filas_tmp, 5) = "HABER"

        With wSheet.Range("B8", "V8").Borders(xlEdgeBottom)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With

        With wSheet.Range("B8", "V8").Borders(xlEdgeTop)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With


        cont_filas_tmp = 9

        For f As Integer = 0 To dgv_data.Rows.Count - 1

            For c As Integer = 2 To dgv_data.ColumnCount - 1
                excel.Cells(cont_filas_tmp + f, c) = dgv_data.Rows(f).Cells(c).Value
            Next

            'excel.Cells(cont_filas_tmp + f, 2) = dgv_data.Rows(f).Cells("col_num").Value
            'excel.Cells(cont_filas_tmp + f, 3) = dgv_data.Rows(f).Cells("col_des").Value
            'excel.Cells(cont_filas_tmp + f, 4) = dgv_data.Rows(f).Cells("col_debe").Value
            'excel.Cells(cont_filas_tmp + f, 5) = dgv_data.Rows(f).Cells("col_haber").Value
        Next







        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        Dim strFileName As String = "C:\DepreciacionAnual.xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True

        Me.Cursor = Cursors.Default
    End Sub
End Class