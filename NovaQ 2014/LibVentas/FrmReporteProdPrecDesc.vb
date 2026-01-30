Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Public Class FrmReporteProdPrecDesc
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        ' -----Mostrando el Reporte
        MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
    End Sub

    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, _
                               ByRef _TipoReporte As Integer)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim _marca As String, _generico As String, _muestra_medica As String
        Dim dtDatosCompany As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor

            If chkmarca.Checked = False And chkgenerico.Checked = False And chkmuestramedica.Checked = False Then
                MsgBox("Debe elegir una opción para Mostrar el Reporte", MsgBoxStyle.Critical)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            If chkmarca.Checked = True Then
                _marca = "SI"
            Else
                _marca = ""
            End If
            If chkgenerico.Checked = True Then
                _generico = "SI"
            Else
                _generico = ""
            End If
            If chkmuestramedica.Checked = True Then
                _muestra_medica = "SI"
            Else
                _muestra_medica = ""
            End If
            NombreStore = "CLI_SP_S_PART_REPORTE"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ImprimirRepProdPrecDesc(NombreStore, _marca, _generico, _muestra_medica)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dt_tmp.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Prod_Prec_Desc.rpt", "", "", "", "@MARCA;" & _marca, "@GENERICO;" & _generico, "@MUESTRA_MEDICA;" & _muestra_medica, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Sub FrmReporteProdPrecDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    
End Class