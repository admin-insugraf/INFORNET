Imports System.Windows.Forms
Imports LibCobranzas
Imports LibComunVar

Public Class FrmCierraVentasMensual

    Dim CierreVentasBl As New ClsOperaciones.RECEIVABLE
    Dim dtPrincipalDoc As DataTable

    Private Sub FrmCierraVentasMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaANIO.Value = Date.Now()
        dtpfechaMES.Value = Date.Now()
        GenerarColummnaDataTable()
        AjustarTamaño(False)
    End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            '' DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT, DOCUMENT_DATE, CADUCATE_DATE, CUSTOMER_ID, CUSTOMER_NAME, VAT_REGISTRATION
            dtPrincipalDoc = New DataTable
            dtPrincipalDoc.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("NUMBER_SERIE", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("DOCUMENT_DATE", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("CADUCATE_DATE", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("CUSTOMER_ID", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("CUSTOMER_NAME", Type.GetType("System.String"))
            dtPrincipalDoc.Columns.Add("VAT_REGISTRATION", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ConfigurarGrilla()
        dgvDetalles.DataSource = Nothing
        dgvDetalles.DataSource = dtPrincipalDoc
        dgvDetalles.Columns(0).Width = 40
        dgvDetalles.Columns(1).Width = 40
        dgvDetalles.Columns(2).Width = 70
        dgvDetalles.Columns(3).Width = 70
        dgvDetalles.Columns(4).Width = 70
        dgvDetalles.Columns(5).Width = 50
        dgvDetalles.Columns(6).Width = 230
        dgvDetalles.Columns(7).Width = 80

        dgvDetalles.Columns(0).HeaderText = "TipoDoc"
        dgvDetalles.Columns(1).HeaderText = "Serie"
        dgvDetalles.Columns(2).HeaderText = "NumeroDoc"
        dgvDetalles.Columns(3).HeaderText = "Emision"
        dgvDetalles.Columns(4).HeaderText = "Vencimiento"
        dgvDetalles.Columns(5).HeaderText = "Codigo"
        dgvDetalles.Columns(6).HeaderText = "Cliente"
        dgvDetalles.Columns(7).HeaderText = "Ruc"
        lblCantidad.Text = "Se encontraron " & dtPrincipalDoc.Rows.Count & " documentos pendientes por Despachar."
    End Sub
 

    Private Sub Generar()
        Try
            CierreVentasBl = New ClsOperaciones.RECEIVABLE
            '00 CONTABILIDAD
            '01 INVENTARIOS
            '02 VENTAS
            '03 COBRANZAS
            '04 COMPRAS
            '05 PAGOS
            '06 PRODUCCION
            Me.Cursor = Cursors.WaitCursor
            CierreVentasBl.GuardarCierre_Ventas(dtpfechaMES.Value.Month.ToString, dtpfechaANIO.Value.Year.ToString, "02", LibComunVar.ClsVarComun.USUARIO.ToString, System.Net.Dns.GetHostName, "CIERRE")
            MsgBox("Cierre de ventas se realizó con exito", MsgBoxStyle.Information, "Aviso")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(812, 713)
        Else
            Size = New System.Drawing.Size(252, 186)
        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If MessageBox.Show("Se procedera a generar el Cierre de Ventas" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'CierreVentasBl = New ClsOperaciones.RECEIVABLE
                'Dim dtRelaciondoc As New DataTable
                'Dim dtGuias As DataTable
                'dtRelaciondoc = CierreVentasBl.RelacionDocumentosmensual(dtpfechaANIO.Value.Year, dtpfechaMES.Value.Month)
                'GenerarColummnaDataTable()
                'If dtRelaciondoc.Rows.Count() <> 0 Then
                '    MsgBox("Existen Documentos que Faltan Despachar no se puede realizar el Cierre de ventas.", MsgBoxStyle.Critical)
                '    ProgressBar1.Visible = True
                '    AjustarTamaño(True)
                '    pnlDocumentos.Visible = True
                '    Dim dtVerificarRelac As DataTable
                '    CierreVentasBl = New ClsOperaciones.RECEIVABLE
                '    ProgressBar1.Minimum = 0
                '    ProgressBar1.Maximum = dtRelaciondoc.Rows.Count()
                '    Dim j As Integer = 0
                '    For Each rows As DataRow In dtRelaciondoc.Rows
                '        ProgressBar1.Value = j
                '        dtVerificarRelac = New DataTable
                '        dtVerificarRelac = CierreVentasBl.VerificarDespacho(rows("DOCUMENT_ID").ToString, rows("NUMBER_SERIE").ToString, rows("NUMBER_DOCUMENT").ToString)
                '        If dtVerificarRelac.Rows.Count() = 0 Then
                '            Dim item As DataRow = dtPrincipalDoc.NewRow
                '            item("DOCUMENT_ID") = rows("DOCUMENT_ID").ToString
                '            item("NUMBER_SERIE") = rows("NUMBER_SERIE").ToString
                '            item("NUMBER_DOCUMENT") = rows("NUMBER_DOCUMENT").ToString
                '            item("DOCUMENT_DATE") = rows("DOCUMENT_DATE").ToString
                '            item("CADUCATE_DATE") = rows("CADUCATE_DATE").ToString
                '            item("CUSTOMER_ID") = rows("CUSTOMER_ID").ToString
                '            item("CUSTOMER_NAME") = rows("CUSTOMER_NAME").ToString
                '            item("VAT_REGISTRATION") = rows("VAT_REGISTRATION").ToString
                '            dtPrincipalDoc.Rows.Add(item)
                '            dtPrincipalDoc.AcceptChanges()
                '        End If
                '        ProgressBar1.PerformStep()
                '        j = j + 1
                '    Next
                '    ProgressBar1.Value = dtRelaciondoc.Rows.Count()
                '    ProgressBar1.Visible = False
                '    ConfigurarGrilla()
                '    ''''Mostrando sin hay Guias sin Despachar
                '    CierreVentasBl = New ClsOperaciones.RECEIVABLE
                '    dtGuias = New DataTable
                '    dtGuias = CierreVentasBl.RelacionDocumentosmensualGuias(dtpfechaANIO.Value.Year, dtpfechaMES.Value.Month)
                '    dgvdetalleGuias.DataSource = Nothing
                '    If dtGuias.Rows.Count() <> 0 Then
                '        dgvdetalleGuias.DataSource = dtGuias
                '        dgvdetalleGuias.Columns(0).Width = 30
                '        dgvdetalleGuias.Columns(1).Width = 120
                '        dgvdetalleGuias.Columns(2).Width = 30
                '        dgvdetalleGuias.Columns(3).Width = 70
                '        dgvdetalleGuias.Columns(4).Width = 60
                '        dgvdetalleGuias.Columns(5).Width = 100
                '        dgvdetalleGuias.Columns(6).Width = 70
                '        dgvdetalleGuias.Columns(7).Width = 80
                '    End If
                '    lblCantidadGuias.Text = "Se encontraron " & dtGuias.Rows.Count & " documentos pendientes por Despachar."
                '    ''Motrando correlativos faltantes
                '    CierreVentasBl = New ClsOperaciones.RECEIVABLE
                '    Dim DtCorrelativoFaltantes As DataTable
                '    DtCorrelativoFaltantes = New DataTable
                '    Dim diaFinal As Date
                '    diaFinal = UltimoDiaDelMes(dtpfechaMES.Value)
                '    DtCorrelativoFaltantes = CierreVentasBl.CorrelativosFaltantes("01/" & dtpfechaMES.Value.Month & "/" & dtpfechaANIO.Value.Year, diaFinal.Day & "/" & diaFinal.Month & "/" & dtpfechaANIO.Value.Year)
                '    DataGridView1.DataSource = DtCorrelativoFaltantes
                '    Exit Sub
                'Else
                '    Generar()
                'End If
                Generar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlDocumentos.Visible = False
        AjustarTamaño(False)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class