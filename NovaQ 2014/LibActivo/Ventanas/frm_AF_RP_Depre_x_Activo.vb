Imports System.Globalization
Imports System.Windows.Forms

Public Class frm_AF_RP_Depre_x_Activo

    Private Sub frm_AF_RP_Depre_x_Activo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_procesar_Click(sender As Object, e As EventArgs) Handles btn_procesar.Click
        Call Procesar_Datos_Depreciacion()
    End Sub

    Private Sub txt_cod_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_activo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim f As New frm_AF_LT_AyudaActivo
            f.ShowDialog()
            If f.bol_aceptar Then
                txt_cod_activo.Text = f.ent_activo.AC_IDACTIVO
                txt_activo.Text = f.ent_activo.AC_ACTIVO_DES
                Call Procesar_Datos_Depreciacion()
            End If
            f = Nothing
        End If
    End Sub

    Private Sub Procesar_Datos_Depreciacion()
        Dim vidaUtil As Integer = 0
        Dim depre_anual As Double = 0
        Dim costo_activo As Double = 0
        Dim activoBL As New ClsOperaciones.ReportesAF
        Dim dt_tmp As DataTable = activoBL.get_Datos_Activo_01(txt_cod_activo.Text.Trim)

        depre_anual = CDbl(dt_tmp.Rows(0)("DEPRE_ANUAL"))
        costo_activo = CDbl(dt_tmp.Rows(0)("AC_MDOC"))
        vidaUtil = dt_tmp.Rows(0)("VIDA_UTIL")

        txt_costo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", CDbl(costo_activo))
        txt_Tipo.Text = "LINEA RECTA"
        txt_valorResidual.Text = dt_tmp.Rows(0)("AC_VALOR_RESIDUAL")
        txt_vidaUtil.Text = vidaUtil & " AÑOS"
        activoBL = Nothing

        dgv_listado.Rows.Clear()

        dgv_listado.Rows.Add()
        dgv_listado.Rows(0).Cells("col_libros").Value = costo_activo
        dgv_listado.Update()

        For i As Integer = 1 To vidaUtil
            dgv_listado.Rows.Add()
            dgv_listado.Rows(i).Cells("col_periodos").Value = i.ToString
            dgv_listado.Rows(i).Cells("col_concepto").Value = "Depreciacion AF año " & i.ToString
            dgv_listado.Rows(i).Cells("col_depre_anual").Value = depre_anual
            dgv_listado.Rows(i).Cells("col_depre_acu").Value = depre_anual * i
            dgv_listado.Rows(i).Cells("col_libros").Value = costo_activo - (depre_anual * i)
            dgv_listado.Update()
        Next


    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim f As New frm_AF_LT_AyudaActivo
        f.ShowDialog()
        If f.bol_aceptar Then
            txt_cod_activo.Text = f.ent_activo.AC_IDACTIVO
            txt_activo.Text = f.ent_activo.AC_ACTIVO_DES
            Call Procesar_Datos_Depreciacion()
        End If
        f = Nothing
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

        excel.Cells(4, 3) = "Depreciacion por Activo"

        excel.Cells(5, 2) = "Activo Fijo"
        excel.Cells(6, 2) = "Vida Util"
        excel.Cells(7, 2) = "Costo del Activo"

        excel.Cells(5, 3) = txt_activo.Text.Trim
        excel.Cells(6, 3) = txt_vidaUtil.Text
        excel.Cells(7, 3) = txt_costo.Text


        excel.Cells(5, 5) = "Tipo de Depreciacion"
        excel.Cells(6, 5) = "Valor Residual"
        excel.Cells(5, 6) = txt_Tipo.Text.Trim
        excel.Cells(6, 6) = txt_valorResidual.Text.Trim



        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 8

        excel.Cells(cont_filas_tmp, 2) = "Nº de Periodos"
        excel.Cells(cont_filas_tmp, 3) = "Concepto"
        excel.Cells(cont_filas_tmp, 4) = "Depreciacion Anual"
        excel.Cells(cont_filas_tmp, 5) = "Depreciacion Acumulada"
        excel.Cells(cont_filas_tmp, 6) = "Importe en Libros"

        With wSheet.Range("B8", "F8").Borders(xlEdgeBottom)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With

        With wSheet.Range("B8", "F8").Borders(xlEdgeTop)
            .Weight = xlThin
            .LineStyle = xlContinuous
            .ColorIndex = 0
            '.TintAndShade = 0
        End With



        cont_filas_tmp = 9

        For f As Integer = 0 To dgv_listado.Rows.Count - 1
            excel.Cells(cont_filas_tmp + f, 2) = dgv_listado.Rows(f).Cells("col_periodos").Value
            excel.Cells(cont_filas_tmp + f, 3) = dgv_listado.Rows(f).Cells("col_concepto").Value
            excel.Cells(cont_filas_tmp + f, 4) = dgv_listado.Rows(f).Cells("col_depre_anual").Value
            excel.Cells(cont_filas_tmp + f, 5) = dgv_listado.Rows(f).Cells("col_depre_acu").Value
            excel.Cells(cont_filas_tmp + f, 6) = dgv_listado.Rows(f).Cells("col_libros").Value
        Next

        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        Dim strFileName As String = "C:\repActivo02.xls"
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
