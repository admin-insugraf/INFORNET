Public Class FrmManufactura_Verificacion_Stock
        Dim OrdenProduccionBl As ClsOperaciones.ORDER_PRODUCTION


    Private Sub DocumentosVerificacionStock()
        Try
            Dim Tipodoc As String = String.Empty
            If cboMostrar.Text = "Planificacion" Then
                Tipodoc = "01"
            ElseIf cboMostrar.Text = "Produccion" Then
                Tipodoc = "02"
            ElseIf cboMostrar.Text = "Anuladas" Then
                Tipodoc = "03"
            ElseIf cboMostrar.Text = "Terminadas" Then
                Tipodoc = "04"
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Principal_Verifica_Stock(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.Columns(3).Visible = False
                dgvCabecera.Columns(6).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(8).HeaderText = "Estado de Comprometido"
                dgvCabecera.Columns(9).Visible = False
                dgvCabecera.Columns(10).Visible = False
                dgvCabecera.Columns(11).Visible = False
                dgvCabecera.Columns(12).Visible = False

                dgvCabecera.Columns(13).Visible = False
                dgvCabecera.Columns(14).Visible = False
                dgvCabecera.Columns(15).Visible = False
                'Else
                '    MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Materiales_Click(sender As Object, e As EventArgs) Handles btn_Materiales.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _id As String = String.Empty
        Dim _Who As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(15, dgvCabecera.CurrentRow.Index).Value

        Dim frm As New FrmManufactura_ListaMateriales
        frm.NRO_OF = _id
        frm.WHO_ID = _Who
        frm.ShowDialog()
        DocumentosVerificacionStock()
    End Sub
 

    Private Sub FrmManufactura_Verificacion_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 1
        cboMostrar.SelectedIndex = 1
        ' DocumentosVerificacionStock()
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMostrar.SelectedIndexChanged
        DocumentosVerificacionStock()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

   
    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosVerificacionStock()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosVerificacionStock()
        End If
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
        DocumentosVerificacionStock()
    End Sub
End Class