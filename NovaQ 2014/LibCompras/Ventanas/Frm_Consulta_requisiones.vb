Imports LibComunVar

Public Class Frm_Consulta_requisiones

    Dim clsRequisionesBl As ClsOperaciones.REQUIREMENT
    Dim dtDocumentos As DataTable
    Dim dtDocumentos_detalle As DataTable
    Dim dtv As DataView
    Dim STRorden As String = ""

    Private Sub Frm_Consulta_requisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 0
        cboOpcionTipoDoc.SelectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsRequisionesBl.get_DatosGeneralesRequisicionesII(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex, cboOpcionTipoDoc.Text)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                For i As Integer = 6 To dgvCabecera.ColumnCount() - 1
                    dgvCabecera.Columns(i).Visible = False
                Next
                dgvCabecera.Columns(8).Visible = True
                dgvCabecera.Columns(4).Visible = False
                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name & "+" & dgvCabecera.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DocumentosRequisionesDetalles(ByVal codigo As String, ByVal tipo As String)
        Try
            clsRequisionesBl = New ClsOperaciones.REQUIREMENT
            dtDocumentos_detalle = New DataTable
            dtDocumentos_detalle = clsRequisionesBl.get_DetallesRequisicionesII(codigo, tipo)
            dgvDetalle.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvDetalle.DataSource = dtDocumentos_detalle
                dgvDetalle.AutoResizeColumns()
                dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub cboOpcionTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcionTipoDoc.SelectedIndexChanged
        If cboOpcionTipoDoc.Text = String.Empty Then Exit Sub
        DocumentosRequisiones()
    End Sub

    Private Sub dgvCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCabecera.SelectionChanged
        If dgvCabecera.DataSource Is Nothing Then Exit Sub
        Dim codigo As String = ""
        Dim tipo As String = ""
        codigo = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        tipo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        If codigo = "" And tipo = "" Then Exit Sub
        DocumentosRequisionesDetalles(codigo, tipo)
    End Sub
End Class