Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Public Class FrmRegCompras
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable
    Dim dtDatosCompany As DataTable
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

 
    Private Sub FrmRegVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoTipoDocumentos()
        dtpfechaInicio.Select()
    End Sub

    Private Sub MostrandoTipoDocumentos()
        Try
            reporteBL = New ClsBuscar
            dtImprimir = New DataTable("documentos")

            dtImprimir = reporteBL.Get_Tipos_Documentos()

            If dtImprimir.Rows.Count > 0 Then
                chklstDocumentos.Items.Clear()
                Dim Documentos(dtImprimir.Rows.Count - 1) As String

                For I As Integer = 0 To dtImprimir.Rows.Count() - 1
                    Documentos(I) = dtImprimir.Rows(I).Item("TYPE_ID").ToString & ":" & dtImprimir.Rows(I).Item("NAME").ToString
                Next

                For i As Integer = 0 To Documentos.Count() - 1
                    chklstDocumentos.Items.Add(Documentos(i))
                Next
                chklstDocumentos.SelectedIndex = 1
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte) = False Then Exit Sub
        ' -----Mostrando el Reporte
        MostrarReporte(Ref_fecIni, Ref_fecFin, Reftipo_Reporte)
    End Sub

    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, ByRef _TipoReporte As Integer)
        Dim reporteBLC As ClsBuscar
        reporteBLC = New ClsBuscar
        reporteBL = New ClsBuscar
        crystalBL = New LibReportes.ClsReporte
        dtImprimir = New DataTable("compra")
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim idTipoDoc As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstDocumentos.CheckedItems.Count - 1
                idTipoDoc = idTipoDoc & """" & TraerCodigo(chklstDocumentos.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idTipoDoc.Length() <> 0 Then
                idTipoDoc = Mid(idTipoDoc, 1, idTipoDoc.Length - 1)
            End If
            dtImprimir = reporteBL.EjecutarReporteCompras(_fechaInicial, _fechaFinal, idTipoDoc)
            dtDatosCompany = reporteBLC.Obtener_Datos_Empresa()

            Select Case _TipoReporte
                Case 1
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_compras.rpt", dtImprimir, "", "", "@fechini;" & _fechaInicial, "@fechfin;" & _fechaFinal, "@TIPOS_DOC;" & idTipoDoc, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
                Case 2
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_compras_insugraf.rpt", dtImprimir, "", "", "@fechini;" & _fechaInicial, "@fechfin;" & _fechaFinal, "@TIPOS_DOC;" & idTipoDoc, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
            End Select

            

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, ByRef tipo_Reporte As Integer) As Boolean

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

            If rdbsunat.Checked = True Then
                tipo_Reporte = 1
            ElseIf rdbconcar.Checked = True Then
                tipo_Reporte = 2
            End If

            ' -------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub dtpfechaInicio_DockChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.DockChanged

    End Sub

    Private Sub dtpfechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaInicio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.ValueChanged

    End Sub

    Private Sub dtpfechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaFin.ValueChanged

    End Sub

    Private Sub rdbsunat_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rdbconcar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkTipoDoc_CheckedChanged(sender As Object, e As EventArgs) Handles checkTipoDoc.CheckedChanged
        If checkTipoDoc.Checked Then
            ActivarCheck(True)
            chklstDocumentos.Enabled = False
        Else
            ActivarCheck(False)
            chklstDocumentos.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class