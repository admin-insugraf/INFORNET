Imports System.Windows.Forms

Public Class frm_AF_RP_Lis_Activos

    Private Sub AF_RP_Lis_Activos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Tool_Exportar_Click(sender As Object, e As EventArgs) Handles Tool_Exportar.Click

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


        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        wSheet.Name = "Depreciacion por Activo"

        excel.Cells(1, 1) = "Empresa"
        excel.Cells(2, 1) = "Ruc"
        excel.Cells(1, 3) = LibComunVar.ClsVarComun.NomEmpresa
        excel.Cells(2, 3) = "'" & LibComunVar.ClsVarComun.RucEmpresa



        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 8

        excel.Cells(cont_filas_tmp, 2) = "COD"
        excel.Cells(cont_filas_tmp, 3) = "COD_ALTERNO"
        excel.Cells(cont_filas_tmp, 4) = "DESCRIPCION"
        excel.Cells(cont_filas_tmp, 5) = "FAMILIA"
        excel.Cells(cont_filas_tmp, 6) = "TASA%"
        excel.Cells(cont_filas_tmp, 7) = "INI_OPERACION"
        excel.Cells(cont_filas_tmp, 8) = "COSTO"
        excel.Cells(cont_filas_tmp, 9) = "MONEDA"
        excel.Cells(cont_filas_tmp, 10) = "AREA"
        excel.Cells(cont_filas_tmp, 11) = "RESPONSABLE"
        excel.Cells(cont_filas_tmp, 12) = "MARCA"
        excel.Cells(cont_filas_tmp, 13) = "MODELO"
        excel.Cells(cont_filas_tmp, 14) = "SERIE"

        With wSheet.Range("B8", "N8").Borders(xlEdgeBottom)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With

        With wSheet.Range("B8", "N8").Borders(xlEdgeTop)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With


        cont_filas_tmp = 9

        For f As Integer = 0 To dgv_listado.Rows.Count - 1
            excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("COD").Value
            excel.Cells(cont_filas_tmp + f, 3) = dgv_listado.Rows(f).Cells("COD_ALTERNO").Value
            excel.Cells(cont_filas_tmp + f, 4) = dgv_listado.Rows(f).Cells("DESCRIPCION").Value
            excel.Cells(cont_filas_tmp + f, 5) = dgv_listado.Rows(f).Cells("FAMILIA").Value
            excel.Cells(cont_filas_tmp + f, 6) = dgv_listado.Rows(f).Cells("TASA%").Value
            excel.Cells(cont_filas_tmp + f, 7) = dgv_listado.Rows(f).Cells("INI_OPERACION").Value
            excel.Cells(cont_filas_tmp + f, 8) = dgv_listado.Rows(f).Cells("COSTO").Value
            excel.Cells(cont_filas_tmp + f, 9) = dgv_listado.Rows(f).Cells("MONEDA").Value
            excel.Cells(cont_filas_tmp + f, 10) = dgv_listado.Rows(f).Cells("AREA").Value
            excel.Cells(cont_filas_tmp + f, 11) = dgv_listado.Rows(f).Cells("RESPONSABLE").Value
            excel.Cells(cont_filas_tmp + f, 12) = dgv_listado.Rows(f).Cells("MARCA").Value
            excel.Cells(cont_filas_tmp + f, 13) = dgv_listado.Rows(f).Cells("MODELO").Value
            excel.Cells(cont_filas_tmp + f, 14) = dgv_listado.Rows(f).Cells("SERIE").Value
        Next

        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        Dim strFileName As String = "C:\RepListaActivos001.xls"
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

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        dgv_listado.DataSource = activoBL.get_Listado_Activo_Reporte()
        activoBL = Nothing
        Me.Cursor = Cursors.Default
    End Sub
End Class