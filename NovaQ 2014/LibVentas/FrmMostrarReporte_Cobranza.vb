Imports System.Windows.Forms
Imports LibComunVar
Imports LibCobranzas

Public Class FrmMostrarReporte_Cobranza
    Dim dtDocumentosPrincipal As DataTable
    Dim clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Dim dtDetalleClientes As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim reporteBL As LibCobranzas.ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Private Sub FrmMostrarReporte_Cobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDocumentosPendiente_Cliente()
        txtFiltro.Focus()
    End Sub
    Private Sub MostrarDocumentosPendiente_Cliente()
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalleClientes = New DataTable
            dtv = New DataView
            dgvDocumentos.DataSource = Nothing
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.MostrandoClientesDocPendientes()
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dtv = dtDocumentosPrincipal.DefaultView
                dgvDocumentos.DataSource = dtv
                STRorden = dgvDocumentos.Columns(1).Name & "+" & dgvDocumentos.Columns(2).Name & "+" & dgvDocumentos.Columns(3).Name
                'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                MsgBox("No hay informacion disponible para mostrar en este momento.", MsgBoxStyle.Information)
                'lblCantidad.Text = "Se encontraron 0 registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))
            dtDocumentosPrincipal.Columns.Add("CUSTOMER_ID", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NAME", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("VAT_REGISTRATION", Type.GetType("System.Double"))
            dgvDocumentos.DataSource = Nothing
            dgvDocumentos.DataSource = dtDocumentosPrincipal
            dgvDocumentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDocumentos.Columns(0).Width = 40
            dgvDocumentos.Columns(0).ReadOnly = False
            dgvDocumentos.Columns(0).HeaderText = "SELEC"
            dgvDocumentos.Columns(1).Width = 100
            dgvDocumentos.Columns(1).ReadOnly = True
            dgvDocumentos.Columns(1).HeaderText = "Codigo"
            dgvDocumentos.Columns(2).Width = 300
            dgvDocumentos.Columns(2).ReadOnly = True
            dgvDocumentos.Columns(2).HeaderText = "Cliente"
            dgvDocumentos.Columns(3).Width = 120
            dgvDocumentos.Columns(3).ReadOnly = True
            dgvDocumentos.Columns(3).HeaderText = "Ruc"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        If checkTodos.Checked = True Then

            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=False")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = True
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        Else
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
                dtDocumentosPrincipal.BeginInit()
                row("Sel") = False
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentos.Select()
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub

        Dim Estado As Boolean = False
        For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
            Estado = True
            Exit For
        Next
        If Estado = False Then
            MsgBox("No selecciono ningun Cliente.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim _Codigo As String = String.Empty

        For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=true")
            _Codigo = _Codigo & """" & row("CUSTOMER_ID").ToString() & """" & ","
        Next

        If _Codigo.Length() <> 0 Then
            _Codigo = Mid(_Codigo, 1, _Codigo.Length - 1)
            ImprimirDocumentosPendientes(_Codigo)
        End If
    End Sub

    Private Sub ImprimirDocumentosPendientes(ByVal _Codigo As String)
        Try
            Dim dtDatosCompany As DataTable
            reporteBL = New LibCobranzas.ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim idAlmacen As String = String.Empty
            Dim iddocumentos As String = String.Empty
            Dim i As Integer = 0
            Dim j As Integer = 0

            Me.Cursor = Cursors.WaitCursor
            
            dtImprimir = New DataTable
            dtImprimir = reporteBL.EjecutarReporteDocuementosPendientesCliente_gerencial(_Codigo, IIf(checkTodos.Checked, "0", "1"), "", _
                                                                                   "", "", "3", "", "", "")

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Letras_Doc_Pend_Clientes_ult.rpt", dtImprimir, "", "", _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
End Class