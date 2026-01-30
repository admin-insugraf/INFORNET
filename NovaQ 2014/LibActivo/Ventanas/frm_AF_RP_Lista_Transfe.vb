Imports System.Windows.Forms

Public Class frm_AF_RP_Lista_Transfe

    Private Sub frm_AF_RP_Lista_Transfe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_exportar_Click(sender As Object, e As EventArgs) Handles Tool_exportar.Click


        If dgv_listado.RowCount = 0 Then Exit Sub



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

        excel.Cells(5, 2) = "Tranferencia de Activos"

        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 8

        excel.Cells(cont_filas_tmp, 2) = "NUM_FOLIO"
        excel.Cells(cont_filas_tmp, 3) = "ACTIVO"
        excel.Cells(cont_filas_tmp, 4) = "FECHA"
        excel.Cells(cont_filas_tmp, 5) = "ORIGEN"
        excel.Cells(cont_filas_tmp, 6) = "DESTINO"
        excel.Cells(cont_filas_tmp, 7) = "RESPONSABLE"
        excel.Cells(cont_filas_tmp, 8) = "OBSERVACIONES"


        With wSheet.Range("B5", "B5").Borders(xlEdgeBottom)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With

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
            excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("NUM_FOLIO").Value
            excel.Cells(cont_filas_tmp + f, 3) = dgv_listado.Rows(f).Cells("ACTIVO").Value
            excel.Cells(cont_filas_tmp + f, 4) = dgv_listado.Rows(f).Cells("FECHA").Value
            excel.Cells(cont_filas_tmp + f, 5) = dgv_listado.Rows(f).Cells("ORIGEN").Value
            excel.Cells(cont_filas_tmp + f, 6) = dgv_listado.Rows(f).Cells("DESTINO").Value
            excel.Cells(cont_filas_tmp + f, 7) = dgv_listado.Rows(f).Cells("RESPONSABLE").Value
            excel.Cells(cont_filas_tmp + f, 8) = dgv_listado.Rows(f).Cells("OBSERVACIONES").Value

        Next

        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        Dim strFileName As String = "C:\Transferencias" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second & ".xls"
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

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        Dim transferenciaBL As New ClsOperaciones.AF_PR_TRANSFE_C
        Dim dt_tmp As DataTable = transferenciaBL.get_Rep_Transferencias()
        dgv_listado.DataSource = dt_tmp
        transferenciaBL = Nothing
    End Sub
End Class