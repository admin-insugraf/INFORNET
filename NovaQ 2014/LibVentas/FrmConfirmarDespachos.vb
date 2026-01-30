Imports System.Windows.Forms
Imports LibCobranzas
Imports LibComunVar

Public Class FrmConfirmarDespachos

    Dim CierreVentasBl As New ClsOperaciones.RECEIVABLE
    Dim dtPrincipalDoc As DataTable
    Dim dtPrincipalDocGuias As DataTable
    Dim clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim dtvFactura As DataView
    Dim dtvGuia As DataView
    Dim STRordenFactura As String = String.Empty
    Dim STRordenGuia As String = String.Empty


    Private Sub FrmCierraVentasMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpDespachoFactura.Value = Date.Now()
        dtpdespachoGuia.Value = Date.Now()
        MostrandoDocumentosPendientes()
    End Sub


    Public Sub GenerarColummnaDataTableGuia()
        Try

            ''SEL, WAREHOUSE_ID, Name, DOCUMENT_ID, NUMBER_DOCUMENT, ID, CUSTOMER_NAME, DATE_DOCUMENT, STATUS_GUIA, FECHA_DESPACHO
            dtPrincipalDocGuias = New DataTable
            dtPrincipalDocGuias.Columns.Add("SEL", Type.GetType("System.Boolean"))
            dtPrincipalDocGuias.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("NAME", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("ID", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("CUSTOMER_NAME", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("STATUS_GUIA", Type.GetType("System.String"))
            dtPrincipalDocGuias.Columns.Add("FECHA_DESPACHO", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ConfigurarGrillaGuias()
        dgvdetalleGuias.DataSource = Nothing
        dtvGuia = New DataView
        dtvGuia = dtPrincipalDocGuias.DefaultView
        dgvdetalleGuias.DataSource = dtvGuia
        'dgvdetalleGuias.Columns(0).Width = 40
        'dgvdetalleGuias.Columns(1).Width = 30
        'dgvdetalleGuias.Columns(2).Width = 100
        'dgvdetalleGuias.Columns(3).Width = 80
        'dgvdetalleGuias.Columns(4).Width = 70
        'dgvdetalleGuias.Columns(5).Width = 50
        'dgvdetalleGuias.Columns(6).Width = 200
        'dgvdetalleGuias.Columns(7).Width = 80
        'dgvdetalleGuias.Columns(8).Width = 80

        dgvdetalleGuias.Columns(1).HeaderText = "Codigo"
        dgvdetalleGuias.Columns(2).HeaderText = "Almacen"
        dgvdetalleGuias.Columns(3).HeaderText = "Tipodoc"
        dgvdetalleGuias.Columns(4).HeaderText = "Numerodoc"
        dgvdetalleGuias.Columns(5).HeaderText = "Codigo"
        dgvdetalleGuias.Columns(6).HeaderText = "Cliente"
        dgvdetalleGuias.Columns(7).HeaderText = "Emision"
        dgvdetalleGuias.Columns(8).HeaderText = "Estado"
        dgvdetalleGuias.Columns(9).HeaderText = "FechaDespacho"

        dgvdetalleGuias.AutoResizeColumns()
        dgvdetalleGuias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        STRordenGuia = dgvdetalleGuias.Columns(2).Name & "+" & dgvdetalleGuias.Columns(3).Name & "+" & dgvdetalleGuias.Columns(4).Name & "+" & dgvdetalleGuias.Columns(6).Name
        lblCantidadGuias.Text = "Se encontraron " & dtvGuia.Count & " documentos pendientes por Despachar."
    End Sub

    Public Sub GenerarColummnaDataTableFacturacion()
        Try
            '' DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT, DOCUMENT_DATE, CADUCATE_DATE, CUSTOMER_ID, CUSTOMER_NAME, VAT_REGISTRATION
            dtPrincipalDoc = New DataTable
            dtPrincipalDoc.Columns.Add("SEL", Type.GetType("System.Boolean"))
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

    Public Sub ConfigurarGrillaFacturacion()
        dgvDetalles.DataSource = Nothing
        dtvFactura = New DataView
        dtvFactura = dtPrincipalDoc.DefaultView
        dgvDetalles.DataSource = dtvFactura
        'dgvDetalles.Columns(0).Width = 40
        'dgvDetalles.Columns(1).Width = 40
        'dgvDetalles.Columns(2).Width = 70
        'dgvDetalles.Columns(3).Width = 70
        'dgvDetalles.Columns(4).Width = 70
        'dgvDetalles.Columns(5).Width = 70
        'dgvDetalles.Columns(6).Width = 80
        'dgvDetalles.Columns(7).Width = 230
        'dgvDetalles.Columns(8).Width = 80

        dgvDetalles.Columns(1).HeaderText = "TipoDoc"
        dgvDetalles.Columns(2).HeaderText = "Serie"
        dgvDetalles.Columns(3).HeaderText = "NumeroDoc"
        dgvDetalles.Columns(4).HeaderText = "Emision"
        dgvDetalles.Columns(5).HeaderText = "Vencimiento"
        dgvDetalles.Columns(6).HeaderText = "Codigo"
        dgvDetalles.Columns(7).HeaderText = "Cliente"
        dgvDetalles.Columns(8).HeaderText = "Ruc"

        dgvDetalles.AutoResizeColumns()
        dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        STRordenFactura = dgvDetalles.Columns(1).Name & "+" & dgvDetalles.Columns(2).Name & "+" & dgvDetalles.Columns(3).Name & "+" & dgvDetalles.Columns(7).Name
        lblCantidad.Text = "Se encontraron " & dtvFactura.Count & " documentos pendientes por Despachar."

    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(825, 606)
        Else
            Size = New System.Drawing.Size(252, 186)
        End If
    End Sub

    Private Sub MostrandoDocumentosPendientes()
        Try
            ''Detalles Facturacion
            CierreVentasBl = New ClsOperaciones.RECEIVABLE
            GenerarColummnaDataTableFacturacion()
            dtPrincipalDoc = CierreVentasBl.RelacionDocumentosTotales()
            If dtPrincipalDoc.Rows.Count() <> 0 Then
                ConfigurarGrillaFacturacion()
            Else
                dgvDetalles.DataSource = dtPrincipalDoc
                checkFacturacion.Checked = False
            End If
            ''Detalles de Guias
            CierreVentasBl = New ClsOperaciones.RECEIVABLE
            GenerarColummnaDataTableGuia()
            dtPrincipalDocGuias = CierreVentasBl.RelacionDocumentosmensualGuiasTotales()
            If dtPrincipalDocGuias.Rows.Count() <> 0 Then
                ConfigurarGrillaGuias()
            Else
                dgvdetalleGuias.DataSource = dtPrincipalDocGuias
                checkGuias.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Desp_Fact_Click(sender As Object, e As EventArgs) Handles btn_Desp_Fact.Click
        Try
            If dgvDetalles.RowCount() = 0 Then Exit Sub
            If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
            Dim Flag_Estado As Boolean = False
            dgvDetalles.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For Each rows As DataRow In dtPrincipalDoc.Select("SEL=TRUE")
                Flag_Estado = True
                Exit For
            Next
            If Flag_Estado = False Then Exit Sub
            If MessageBox.Show("¿Desea Generar el  Despacho.?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                If clsFacturaBl.GenerarDespachoVarios(dtPrincipalDoc, dtpDespachoFactura.Value.ToString("dd/MM/yyyy"), LibComunVar.ClsVarComun.USUARIO) Then
                    MsgBox("Generacion de Despacho realizado exitosamente.", MsgBoxStyle.Information)
                    MostrandoDocumentosPendientes()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Despacho_Guia_Click(sender As Object, e As EventArgs) Handles btn_Despacho_Guia.Click
        Try
            If dgvdetalleGuias.RowCount() = 0 Then Exit Sub
            If dgvdetalleGuias.CurrentRow Is Nothing Then Exit Sub
            Dim Flag_Estado As Boolean = False
            For Each rows As DataRow In dtPrincipalDocGuias.Select("SEL=TRUE")
                Flag_Estado = True
                Exit For
            Next
            If Flag_Estado = False Then Exit Sub
            If MessageBox.Show("¿Desea Generar el  Despacho.?", "Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
                If almacenBL.GenerarDespachoVarios(dtPrincipalDocGuias, dtpdespachoGuia.Value.ToString("dd/MM/yyyy"), String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO) Then
                    MsgBox("Generacion de Despacho realizado exitosamente.", MsgBoxStyle.Information)
                    MostrandoDocumentosPendientes()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkFacturacion_CheckedChanged(sender As Object, e As EventArgs) Handles checkFacturacion.CheckedChanged
        For Each rows As DataRow In dtPrincipalDoc.Rows
            dtPrincipalDoc.BeginInit()
            rows("SEL") = checkFacturacion.Checked
            dtPrincipalDoc.EndInit()
            dtPrincipalDoc.AcceptChanges()
        Next
    End Sub

    Private Sub checkGuias_CheckedChanged(sender As Object, e As EventArgs) Handles checkGuias.CheckedChanged
        For Each rows As DataRow In dtPrincipalDocGuias.Rows
            dtPrincipalDocGuias.BeginInit()
            rows("SEL") = checkGuias.Checked
            dtPrincipalDocGuias.EndInit()
            dtPrincipalDocGuias.AcceptChanges()
        Next
    End Sub

    Private Sub txtFiltroFactura_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroFactura.TextChanged
        If txtFiltroFactura.Text = String.Empty Then
            dtvFactura.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtvFactura.Count & " registros"
            Exit Sub
        Else
            dtvFactura.RowFilter = STRordenFactura & " like '%" & txtFiltroFactura.Text & "%'"
            If dtvFactura.Count() = 0 Then
                STRordenFactura = String.Empty
                STRordenFactura = dgvDetalles.Columns(1).Name
                dtvFactura.RowFilter = STRordenFactura & " like '%" & txtFiltroFactura.Text & "%'"
                If dtvFactura.Count() = 0 Then
                    STRordenFactura = String.Empty
                    STRordenFactura = dgvDetalles.Columns(2).Name
                    dtvFactura.RowFilter = STRordenFactura & " like '%" & txtFiltroFactura.Text & "%'"
                    If dtvFactura.Count() = 0 Then
                        STRordenFactura = String.Empty
                        STRordenFactura = dgvDetalles.Columns(1).Name & "+" & dgvDetalles.Columns(2).Name & "+" & dgvDetalles.Columns(3).Name
                        lblCantidadGuias.Text = "Se encontraron " & dtvGuia.Count & " documentos pendientes por Despachar."
                        Exit Sub
                    End If
                End If
            End If
            lblCantidadGuias.Text = "Se encontraron " & dtvGuia.Count & " documentos pendientes por Despachar."
        End If
    End Sub

    Private Sub txtFiltroGuia_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroGuia.TextChanged
        If txtFiltroGuia.Text = String.Empty Then
            dtvGuia.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtvGuia.Count & " registros"
            Exit Sub
        Else
            dtvGuia.RowFilter = STRordenGuia & " like '%" & txtFiltroGuia.Text & "%'"
            If dtvGuia.Count() = 0 Then
                STRordenGuia = String.Empty
                STRordenGuia = dgvdetalleGuias.Columns(2).Name
                dtvGuia.RowFilter = STRordenGuia & " like '%" & txtFiltroGuia.Text & "%'"
                If dtvGuia.Count() = 0 Then
                    STRordenGuia = String.Empty
                    STRordenGuia = dgvdetalleGuias.Columns(3).Name
                    dtvGuia.RowFilter = STRordenGuia & " like '%" & txtFiltroGuia.Text & "%'"
                    If dtvGuia.Count() = 0 Then
                        STRordenGuia = String.Empty
                        STRordenGuia = dgvdetalleGuias.Columns(4).Name
                        dtvGuia.RowFilter = STRordenGuia & " like '%" & txtFiltroGuia.Text & "%'"
                        If dtvGuia.Count() = 0 Then
                            STRordenGuia = String.Empty
                            STRordenGuia = dgvdetalleGuias.Columns(6).Name
                            dtvGuia.RowFilter = STRordenGuia & " like '%" & txtFiltroGuia.Text & "%'"
                            If dtvGuia.Count() = 0 Then
                                STRordenGuia = String.Empty
                                STRordenGuia = dgvdetalleGuias.Columns(2).Name & "+" & dgvdetalleGuias.Columns(3).Name & "+" & dgvdetalleGuias.Columns(4).Name & "+" & dgvdetalleGuias.Columns(4).Name
                                lblCantidadGuias.Text = "Se encontraron " & dtvGuia.Count & " documentos pendientes por Despachar."
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            lblCantidadGuias.Text = "Se encontraron " & dtvGuia.Count & " documentos pendientes por Despachar."
        End If
    End Sub
End Class