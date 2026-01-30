Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmVentasDocumentosDetracccion


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub MostrandoTipoDocumentos()
        Try
            chklstDocumentos.Items.Clear()
            Dim Documentos(4) As String
            Documentos(0) = "BV:BOLETA DE VENTA"
            Documentos(1) = "CP:COMPROBANTE DE PERCEPCION"
            Documentos(2) = "FT:FACTURA DE VENTA"
            Documentos(3) = "NC:NOTA DE CREDITO"
            Documentos(4) = "ND:NOTA DE DEBITO"
            For i As Integer = 0 To Documentos.Count() - 1
                chklstDocumentos.Items.Add(Documentos(i))
            Next
            chklstDocumentos.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmVentasDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoTipoDocumentos()
    End Sub

    Private Function Validaciones(ByRef FechaIni As String, ByRef FechaFin As String, ByRef TipoDoc As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            FechaIni = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            FechaFin = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            'validacion
            If chklstDocumentos.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos un Tipo de Documento", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            Dim idTipoDoc As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstDocumentos.CheckedItems.Count - 1
                idTipoDoc = idTipoDoc & """" & TraerCodigo(chklstDocumentos.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idTipoDoc.Length() <> 0 Then
                idTipoDoc = Mid(idTipoDoc, 1, idTipoDoc.Length - 1)
                TipoDoc = idTipoDoc
            End If

            If FechaIni = String.Empty Or FechaFin = String.Empty Or TipoDoc = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, ByVal TipoDoc As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteDetraccion(FechaIni, FechaFin, TipoDoc)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Ventas_doc_Detraccion.rpt", "", "", "", "@FECHA_INI;" & FechaIni, "@FECHA_FIN;" & FechaFin, "@TIPO_DOC;" & TipoDoc)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_TipoDoc As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin, Ref_TipoDoc) = False Then Exit Sub
        MostrarReporte(Ref_fecIni, Ref_fecFin, Ref_TipoDoc)
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