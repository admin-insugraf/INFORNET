Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Public Class Frm_OP_PLanta_Bandeja_Lista_Despachos

    Dim _inicio As Boolean = False
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim _contador_despachos As Integer = 0
    Dim PedidoCabENT As ClsEntidades.MANTENIMIENTO_OP
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtdetalle_despachos As DataTable
    Dim flag_modificar_logistica As Boolean = False
    Dim MantenimientoOP_Corte As ClsEntidades.MANTENIMIENTO_OP_CORTE
    Dim Codigo_logistica As String = String.Empty

    Dim dtdetalle_despacho_correo As DataTable
    Dim _REMITENTE As String
    Dim _RECEPCIONANTE As String
    Dim _SERVER As String
    Dim _USUARIO As String
    Dim _PASSWORD As String
    Dim _ASUNTO As String
    Dim _TITULO As String
    Dim _PUERTO As String
    Dim _mensaje As String
    Dim _correo_vendedor As String
    Dim _vendedor_correo As String
    Dim _codigo_interno_op As Integer = 0
    Dim _cod_familia As String = ""
    Dim datos_reprogramacion As Boolean

    Private Sub Frm_OP_PLanta_Bandeja_Lista_Despachos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        pnl_programar_Despachos.Visible = True
        rdb_programar_Despacho.Checked = True
        chk_todos_lineas_produccion.Checked = True
        Call Consulta_Despachos()
        dtp_fecha_despacho.Value = Date.Now
        _inicio = True
        btn_prog_despacho_final.Focus()

        dgv_detalle_despachos_programados.DataSource = Nothing
        gb_cambio_depachos_programados.Visible = False
        dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
        dtp_ff_dp.Value = LibComunVar.ClsVarComun.FechaSistema
    End Sub
    Private Sub Consulta_Despachos()
        Try

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS

            Me.Cursor = Cursors.WaitCursor

            Dim dt_detalle_programa_despachos As DataTable

            dt_detalle_programa_despachos = clsPedidoBl.get_Mantenimiento_Lista_Despachos(txt_cod_linea_produccion.Text, _cod_familia)
            ' dgv_detalle_prog_despacho.DataSource = Nothing
            If dgv_detalle_prog_despacho.RowCount() <> 0 Then
                For n As Integer = dgv_detalle_prog_despacho.Rows.Count - 1 To 0 Step -1
                    Dim row As DataGridViewRow = dgv_detalle_prog_despacho.Rows(n)
                    dgv_detalle_prog_despacho.Rows.Remove(row)
                Next
            End If

            If dt_detalle_programa_despachos.Rows.Count() <> 0 Then
                dgv_detalle_prog_despacho.DataSource = dt_detalle_programa_despachos

                dgv_detalle_prog_despacho.Columns("NOP").Width = 70
                dgv_detalle_prog_despacho.Columns("Cliente").Width = 300
                dgv_detalle_prog_despacho.Columns("Producto").Width = 300

                dgv_detalle_prog_despacho.Columns("Vendedor").Width = 300
                dgv_detalle_prog_despacho.Columns("Observaciones").Width = 300

                dgv_detalle_prog_despacho.Columns("Cantidad").DefaultCellStyle.Format = "N2"
                dgv_detalle_prog_despacho.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End If

            _contador_despachos = 0

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rdb_despacho_programado_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_despacho_programado.CheckedChanged
        If rdb_despacho_programado.Checked Then
            Try
                Me.Cursor = Cursors.WaitCursor
                chk_todos_lineas_produccion_2.Checked = True
                pnl_despachos_programados.Visible = True
                pnl_programar_Despachos.Visible = False
                RadioButton3.Checked = True
                dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                dtp_ff_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                btn_consultar.Focus()

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgv_detalle_prog_despacho_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle_prog_despacho.CellValueChanged
        If e.ColumnIndex = 0 And _inicio = True Then
            If dgv_detalle_prog_despacho.CurrentRow.Cells("Sel").Value = True Then
                dgv_detalle_prog_despacho.CurrentRow.Cells("SecDespacho").Value = _contador_despachos + 1
                _contador_despachos = _contador_despachos + 1
            Else
                dgv_detalle_prog_despacho.CurrentRow.Cells("SecDespacho").Value = ""
                '_contador_despachos = _contador_despachos - 1
            End If

        End If
    End Sub

    Private Sub dgv_detalle_prog_despacho_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_detalle_prog_despacho.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgv_detalle_prog_despacho.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgv_detalle_prog_despacho.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Public Sub GenerarColummnaDataTable_Despachos_Correo()
        dtdetalle_despacho_correo = New DataTable
        dtdetalle_despacho_correo.Columns.Add("NOP", Type.GetType("System.String")) '1
        dtdetalle_despacho_correo.Columns.Add("FechaEntrega", Type.GetType("System.String")) '2
        dtdetalle_despacho_correo.Columns.Add("Cliente", Type.GetType("System.String")) '3
        dtdetalle_despacho_correo.Columns.Add("Producto", Type.GetType("System.String")) '4
        dtdetalle_despacho_correo.Columns.Add("Cantidad", Type.GetType("System.String")) '5
        dtdetalle_despacho_correo.Columns.Add("HrEntregaAcordado", Type.GetType("System.String")) '6
        dtdetalle_despacho_correo.Columns.Add("HrMaximoEntrega", Type.GetType("System.String")) '7
        dtdetalle_despacho_correo.Columns.Add("PuntodeSalida", Type.GetType("System.String")) '8
        dtdetalle_despacho_correo.Columns.Add("Observaciones", Type.GetType("System.String")) '9
        dtdetalle_despacho_correo.Columns.Add("VENDEDOR", Type.GetType("System.String")) '10
    End Sub

    Private Sub btn_prog_despacho_final_Click(sender As Object, e As EventArgs) Handles btn_prog_despacho_final.Click
        If Validar_Programacion_Despacho() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de registrar la Programación de Despacho?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

                For i As Integer = 0 To dgv_detalle_prog_despacho.Rows.Count - 1
                    If dgv_detalle_prog_despacho.Rows(i).Cells("SEL").Value Then
                        PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                        With PedidoCabENT
                            .ID = dgv_detalle_prog_despacho.Rows(i).Cells("CODIGO_INTERNO").Value
                            .ITEM = dgv_detalle_prog_despacho.Rows(i).Cells("ITEM").Value
                            .PRODUCTO = dgv_detalle_prog_despacho.Rows(i).Cells("CODIGO").Value
                            .CANTIDAD = dgv_detalle_prog_despacho.Rows(i).Cells("Cantidad").Value
                            .FECHA_DESPACHO = dtp_fecha_despacho.Value.ToString("dd/MM/yyyy")
                        End With
                        MantenimientoOP_Lista.Add(PedidoCabENT)
                    End If
                Next

                If clsPedidoBl.Guardar_Programacion_Lista_Despacho(MantenimientoOP_Lista) Then
                    MsgBox("Lista de Despacho generado correctamente.", MsgBoxStyle.Information, "Sistemas")

                    If dgv_detalle_prog_despacho.RowCount() <> 0 Then
                        For n As Integer = dgv_detalle_prog_despacho.Rows.Count - 1 To 0 Step -1
                            Dim row As DataGridViewRow = dgv_detalle_prog_despacho.Rows(n)
                            dgv_detalle_prog_despacho.Rows.Remove(row)
                        Next
                    End If

                    Call Consulta_Despachos()
                    dtp_fecha_despacho.Value = Date.Now
                    btn_prog_despacho_final.Focus()
                    Me.Cursor = Cursors.Default
                End If

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar_Programacion_Despacho() As Boolean
        Try
            dgv_detalle_prog_despacho.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgv_detalle_prog_despacho.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
                Return False
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgv_detalle_prog_despacho.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgv_detalle_prog_despacho.Focus()
                    Return False
                End If

                For Each row As DataGridViewRow In dgv_detalle_prog_despacho.Rows
                    If row.Cells("SEL").Value = True Then
                        If row.Cells("Cantidad").Value > row.Cells("Cantidad_Original").Value Then
                            MessageBox.Show("La cantidad a Programar es superior al saldo. Verifique!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            dgv_detalle_prog_despacho.Focus()
                            Return False
                            Exit For
                        End If
                    End If
                Next

            End If
            dgv_detalle_prog_despacho.Refresh()


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Call Consulta_Despachos()
                pnl_programar_Despachos.Visible = True
                pnl_despachos_programados.Visible = False
                rdb_programar_Despacho.Checked = True
                btn_prog_despacho_final.Focus()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgv_detalle_despachos_programados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_detalle_despachos_programados.CellFormatting
        If dgv_detalle_despachos_programados.Rows(e.RowIndex).Cells("REPROGRAMACION").Value = "S" Then
            dgv_detalle_despachos_programados.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgv_detalle_despachos_programados.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        Else
            dgv_detalle_despachos_programados.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalle_despachos_programados.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub dgv_detalle_despachos_programados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_detalle_despachos_programados.CellMouseDoubleClick

        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    If dgv_detalle_despachos_programados.CurrentRow Is Nothing Then Exit Sub

        '    Call Llenar_Despachos_Bandeja_Despachos()

        '    TextBox27.Text = "ACTUALIZACION DE DESPACHOS - N° O.P.  " & dgv_detalle_despachos_programados.CurrentRow.Cells("N° O.P.").Value
        '    _correo_vendedor = dgv_detalle_despachos_programados.CurrentRow.Cells("Email").Value
        '    _vendedor_correo = dgv_detalle_despachos_programados.CurrentRow.Cells("Vendedor").Value

        '    pnl_detalle_despachos.Visible = True
        '    pnl_detalle_despachos.BringToFront()
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    pnl_detalle_despachos.Visible = False
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    'Private Sub Llenar_Despachos_Bandeja_Despachos()
    '    'DESPACHOS
    '    Call Limpiar_Despachos_bandeja_Despacho()
    '    Call GenerarColummnaDataTable_Despachos_Bandeja_Despachos()
    '    dtdetalle_despachos = clsPedidoBl.get_Mantenimiento_OP_Despachos_Detalle(dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value)
    '    If dtdetalle_despachos.Rows.Count() <> 0 Then
    '        dgv_detalle_despacho_bandeja_despachos.DataSource = dtdetalle_despachos

    '        For i As Integer = 0 To dgv_detalle_despacho_bandeja_despachos.Rows.Count - 1
    '            For j As Integer = 1 To dgv_detalle_despacho_bandeja_despachos.Columns.Count - 1
    '                dgv_detalle_despacho_bandeja_despachos.Rows(i).Cells(j).ReadOnly = True
    '            Next
    '        Next

    '        dgv_detalle_despacho_bandeja_despachos.Columns("Sel").HeaderText = "Item a Actualizar"
    '        dgv_detalle_despacho_bandeja_despachos.Columns("Sel").ReadOnly = False
    '    End If
    'End Sub

    'Private Sub Limpiar_Despachos_bandeja_Despacho()
    '    TextBox40.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Cliente").Value
    '    TextBox36.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Producto").Value
    '    TextBox39.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Cantidad").Value 'cantidad
    '    TextBox35.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Punto de Salida").Value 'punto de salida
    '    DateTimePicker5.Value = dgv_detalle_despachos_programados.CurrentRow.Cells("Fecha_Despacho").Value
    '    TextBox34.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Observaciones de Despacho").Value

    '    TextBox32.Text = ""
    '    TextBox28.Text = ""
    '    DateTimePicker4.Value = LibComunVar.ClsVarComun.FechaSistema
    '    TextBox33.Text = ""

    '    CheckBox1.Checked = False
    '    chk_cerrar_despacho.Checked = False
    '    flag_modificar_logistica = False
    'End Sub
    'Public Sub GenerarColummnaDataTable_Despachos_Bandeja_Despachos()
    '    dtdetalle_despachos = New DataTable
    '    dtdetalle_despachos.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
    '    dtdetalle_despachos.Columns.Add("FECHA_DESPACHO", Type.GetType("System.String")) '1
    '    dtdetalle_despachos.Columns.Add("CANTIDAD", Type.GetType("System.Double")) '2
    '    dtdetalle_despachos.Columns.Add("PUNTO_SALIDA", Type.GetType("System.String")) '3
    '    dtdetalle_despachos.Columns.Add("OBSERVACIONES", Type.GetType("System.Double")) '4
    '    dtdetalle_despachos.Columns.Add("CONFORME", Type.GetType("System.String")) '5
    '    dtdetalle_despachos.Columns.Add("ESTADO", Type.GetType("System.String")) '6

    '    dtdetalle_despachos.Columns.Add("NUMERO_GR", Type.GetType("System.String")) '7
    '    dtdetalle_despachos.Columns.Add("FECHA_GR", Type.GetType("System.String")) '8
    '    dtdetalle_despachos.Columns.Add("CANTIDAD_GR", Type.GetType("System.String")) '9
    '    dtdetalle_despachos.Columns.Add("OBS_GR", Type.GetType("System.String")) '10
    '    'dtdetalle_despachos.Columns.Add("Sel", Type.GetType("System.BIT")) '11

    '    dgv_detalle_despacho_bandeja_despachos.DataSource = Nothing
    '    dgv_detalle_despacho_bandeja_despachos.DataSource = dtdetalle_despachos

    '    dgv_detalle_despacho_bandeja_despachos.Columns(0).HeaderText = "Item"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(1).HeaderText = "Fecha Despacho"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(2).HeaderText = "Cantidad"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(3).HeaderText = "Punto de Salida"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(4).HeaderText = "Observaciones"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(5).Visible = False
    '    dgv_detalle_despacho_bandeja_despachos.Columns(6).HeaderText = "Estado"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(7).HeaderText = "N° Guia R."
    '    dgv_detalle_despacho_bandeja_despachos.Columns(8).HeaderText = "Fecha Guia R."
    '    dgv_detalle_despacho_bandeja_despachos.Columns(9).HeaderText = "Cantidad Guia R."
    '    dgv_detalle_despacho_bandeja_despachos.Columns(10).HeaderText = "Observaciones Guia Remisión"

    '    dgv_detalle_despacho_bandeja_despachos.Columns(2).DefaultCellStyle.Format = "N0"
    '    dgv_detalle_despacho_bandeja_despachos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    '    dgv_detalle_despacho_bandeja_despachos.AutoResizeColumns()
    '    dgv_detalle_despacho_bandeja_despachos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    'End Sub

    Private Sub dgv_detalle_despachos_programados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle_despachos_programados.CellValueChanged
        If e.ColumnIndex = 0 Then
            If dgv_detalle_despachos_programados.CurrentRow.Cells(0).Value = True Then
                dgv_detalle_despachos_programados.CurrentRow.Cells(1).Value = _contador_despachos + 1
                _contador_despachos = _contador_despachos + 1
            Else
                dgv_detalle_despachos_programados.CurrentRow.Cells(1).Value = ""
                '_contador_despachos = _contador_despachos - 1
                _contador_despachos = 0
            End If

        End If
    End Sub

    Private Sub dgv_detalle_despachos_programados_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_detalle_despachos_programados.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgv_detalle_despachos_programados.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgv_detalle_despachos_programados.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS

            Me.Cursor = Cursors.WaitCursor

            Dim dt_detalle_despachos_programados As DataTable

            dt_detalle_despachos_programados = clsPedidoBl.get_Mantenimiento_Lista_Despachos_Programados(dtp_fi_dp.Value.ToString("dd/MM/yyyy"),
                                                                                                   dtp_ff_dp.Value.ToString("dd/MM/yyyy"))
            dgv_detalle_despachos_programados.DataSource = Nothing
            gb_cambio_depachos_programados.Visible = False
            If dt_detalle_despachos_programados.Rows.Count() <> 0 Then
                dgv_detalle_despachos_programados.DataSource = dt_detalle_despachos_programados
                dgv_detalle_despachos_programados.Columns("Sel").Width = 30
                dgv_detalle_despachos_programados.Columns("Nuevo Orden").Width = 50
                dgv_detalle_despachos_programados.Columns("Fecha Programada").Width = 70
                dgv_detalle_despachos_programados.Columns("Sec. Despacho.").Width = 70
                dgv_detalle_despachos_programados.Columns("CODIGO_INTERNO").Visible = False
                dgv_detalle_despachos_programados.Columns("Fecha de Entrega").Width = 70
                dgv_detalle_despachos_programados.Columns("N° REQUERIMIENTO").Width = 50
                dgv_detalle_despachos_programados.Columns("Cliente").Width = 300
                dgv_detalle_despachos_programados.Columns("Producto").Width = 300
                dgv_detalle_despachos_programados.Columns("U.M.").Width = 70
                dgv_detalle_despachos_programados.Columns("Cantidad").Width = 80
                dgv_detalle_despachos_programados.Columns("Vendedor").Width = 200
                dgv_detalle_despachos_programados.Columns("Observaciones").Width = 250
                dgv_detalle_despachos_programados.Columns("REPROGRAMACION").Visible = False
                dgv_detalle_despachos_programados.Columns("ITEM").Visible = False
                dgv_detalle_despachos_programados.Columns("CODIGO").Visible = False

                dgv_detalle_despachos_programados.Columns("Cantidad").Width = 120
                dgv_detalle_despachos_programados.Columns("Cantidad").DefaultCellStyle.Format = "N2"
                dgv_detalle_despachos_programados.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                

                For i As Integer = 0 To dgv_detalle_despachos_programados.Rows.Count - 1
                    For j As Integer = 1 To dgv_detalle_despachos_programados.Columns.Count - 1
                        dgv_detalle_despachos_programados.Rows(i).Cells(j).ReadOnly = True
                    Next
                Next
            End If

            _contador_despachos = 0

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles btn_reportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Dim dtDatosCompany As DataTable
            dtDatosCompany = New DataTable
            crystalBL = New LibReportes.ClsReporte


            Dim dt_detalle_despachos_programados As DataTable

            dt_detalle_despachos_programados = clsPedidoBl.get_Mantenimiento_Lista_Despachos_Programados(dtp_fi_dp.Value.ToString("dd/MM/yyyy"),
                                                                                                   dtp_ff_dp.Value.ToString("dd/MM/yyyy"))
            dtDatosCompany = clsPedidoBl.Obtener_Datos_Empresa()

            If dt_detalle_despachos_programados.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Formato_Lista_Despacho.rpt", dt_detalle_despachos_programados, "", "", _
                                                  "@FECHA_INICIO;" & dtp_fi_dp.Value.ToString("dd/MM/yyyy"), _
                                                  "@FECHA_FIN;" & dtp_ff_dp.Value.ToString("dd/MM/yyyy"), _
                                                  "titulo;" & "PROGRAMACION DE LISTA DE DESPACHO", _
                                                  "ruc;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
    '    If Validar_Act_Correlativo_Despachos_programados() = False Then Exit Sub

    '    Try
    '        If MsgBox("Esta seguro de actualizar el Correlativo de los Despachos Programados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
    '            Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

    '            For i As Integer = 0 To dgv_detalle_despachos_programados.Rows.Count - 1
    '                If dgv_detalle_despachos_programados.Rows(i).Cells("SEL").Value Then
    '                    PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
    '                    With PedidoCabENT
    '                        .ID = dgv_detalle_despachos_programados.Rows(i).Cells("CODIGO_INTERNO").Value
    '                        .FECHA_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Fecha Programada").Value
    '                        .USER_ID_DESPACHO = LibComunVar.ClsVarComun.USUARIO
    '                        .ITEM_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Nuevo Orden").Value
    '                        .ITEM_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Sec. Despacho.").Value
    '                    End With
    '                    MantenimientoOP_Lista.Add(PedidoCabENT)
    '                End If
    '            Next

    '            If clsPedidoBl.Guardar_Act_Correlativo_Programacion_Despacho(MantenimientoOP_Lista) Then
    '                MsgBox("Actualización de Programación de Despacho Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
    '                dgv_detalle_despachos_programados.DataSource = Nothing
    '                dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
    '                dtp_ff_dp.Value = ModFunciones.Ultimo_Dia_Mes(Date.Now)
    '                Button50.Focus()
    '            End If

    '            Me.Cursor = Cursors.Default
    '        End If
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Function Validar_Act_Correlativo_Despachos_programados() As Boolean
        Try
            dgv_detalle_despachos_programados.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgv_detalle_despachos_programados.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
                Return False
            Else
                Dim estado As Boolean = True
                For Each row As DataGridViewRow In dgv_detalle_despachos_programados.Rows
                    If row.Cells(0).Value = False Then
                        estado = False
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar todos los items!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgv_detalle_despachos_programados.Focus()
                    Return False
                End If
            End If
            dgv_detalle_despachos_programados.Refresh()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles btn_reprogramar.Click
        If Validar_Deshacer_Programacion_Despacho() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de cambiar de Fecha a la Lista de Despachos programados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                dtp_fecha_nueva_despachos_programados.Value = Date.Now
                gb_cambio_depachos_programados.Visible = True
                datos_reprogramacion = False
                btn_confirmar_cambio.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Validar_Deshacer_Programacion_Despacho() As Boolean
        Try
            dgv_detalle_despachos_programados.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgv_detalle_despachos_programados.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
                Return False
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgv_detalle_despachos_programados.Rows
                    If row.Cells(0).Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgv_detalle_despachos_programados.Focus()
                    Return False
                End If
            End If

            'For Each row As DataGridViewRow In dgv_detalle_despachos_programados.Rows
            '    If row.Cells(0).Value = True Then
            '        If row.Cells("ESTADO").Value <> "EN PROCESO" Then
            '            MessageBox.Show("Existen items con estado diferente a EN PROCESO. Verifique!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '            dgv_detalle_despachos_programados.Focus()
            '            Return False
            '        End If

            '    End If
            'Next

            dgv_detalle_despachos_programados.Refresh()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        If Validar_Deshacer_Programacion_Despacho() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de extornar la Programación de La Lista de Despachos elegida?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                For i As Integer = 0 To dgv_detalle_despachos_programados.Rows.Count - 1
                    If dgv_detalle_despachos_programados.Rows(i).Cells("SEL").Value Then
                        PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                        With PedidoCabENT
                            .ID = dgv_detalle_despachos_programados.Rows(i).Cells("CODIGO_INTERNO").Value
                            .FECHA_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Fecha Programada").Value
                            .ITEM_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Item").Value
                            .CANTIDAD = dgv_detalle_despachos_programados.Rows(i).Cells("Cantidad").Value
                        End With
                        MantenimientoOP_Lista.Add(PedidoCabENT)
                    End If
                Next

                If clsPedidoBl.Guardar_Deshacer_Programacion_Lista_Despacho(MantenimientoOP_Lista) Then
                    MsgBox("Extorno de Programación de Lista de Despacho generado correctamente.", MsgBoxStyle.Information, "Sistemas")
                    dgv_detalle_despachos_programados.DataSource = Nothing
                    dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    dtp_ff_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    btn_consultar.Focus()
                End If

                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles btn_confirmar_cambio.Click
        Try
            If txt_motivo.Text = "" Then
                MsgBox("Debe ingresar los datos de Reprogramación.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MsgBox("Esta seguro de Actualizar la Fecha de la Lista de Despachos programados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)


                For i As Integer = 0 To dgv_detalle_despachos_programados.Rows.Count - 1
                    If dgv_detalle_despachos_programados.Rows(i).Cells("SEL").Value Then
                        PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                        With PedidoCabENT
                            .ID = dgv_detalle_despachos_programados.Rows(i).Cells("CODIGO_INTERNO").Value
                            .FECHA_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Fecha Programada").Value
                            .FECHA_DESPACHO = dtp_fecha_nueva_despachos_programados.Value.ToString("dd/MM/yyyy")
                            .USER_ID_DESPACHO = LibComunVar.ClsVarComun.USUARIO
                            .ITEM_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Nuevo Orden").Value
                            .ITEM_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Sec. Despacho.").Value
                            .MOTIVO_REPROGRAMACION = txt_motivo.Text
                            .OBSERVACION_REPROGRAMACION = txt_observacion.Text
                            .REPROGRAMACION = "S"
                        End With
                        MantenimientoOP_Lista.Add(PedidoCabENT)
                    End If
                Next

                If clsPedidoBl.Guardar_Act_Fecha_Programacion_Lista_Despacho(MantenimientoOP_Lista) Then

                    MsgBox("Actualización de Programación de Lista de Despacho generado correctamente.", MsgBoxStyle.Information, "Sistemas")
                    dgv_detalle_despachos_programados.DataSource = Nothing
                    dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    dtp_ff_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    gb_cambio_depachos_programados.Visible = False
                    btn_consultar.Focus()
                    Me.Cursor = Cursors.Default
                End If


            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs)
        Try
            'If Validar_Actualizacion_Bandeja_Despacho() = False Then Exit Sub

            If MessageBox.Show("Se va actualizar el despacho" & Chr(13) & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If Guardar_Area_Despachos_Bandeja_Despachos() Then
                    Button75_Click(sender, e)
                    Button50_Click(sender, e)
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Function Validar_Actualizacion_Bandeja_Despacho() As Boolean
    '    Try
    '        dgv_detalle_despacho_bandeja_despachos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '        If dgv_detalle_despacho_bandeja_despachos.RowCount() = 0 Then
    '            MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
    '            Return False
    '        Else
    '            Dim estado As Boolean = False
    '            For Each row As DataGridViewRow In dgv_detalle_despacho_bandeja_despachos.Rows
    '                If row.Cells("Sel").Value = True Then
    '                    estado = True
    '                    Exit For
    '                End If
    '            Next
    '            If estado = False Then
    '                MessageBox.Show("Debe seleccionar el item que esta actualizando.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                dgv_detalle_despacho_bandeja_despachos.Focus()
    '                Return False
    '            End If
    '        End If

    '        dgv_detalle_despacho_bandeja_despachos.Refresh()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Private Function Guardar_Area_Despachos_Bandeja_Despachos() As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Dim MantenimientoOP_Corte_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP_CORTE)

            PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

            With PedidoCabENT
                .ID = dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value
                '.CIERRA_DESPACHO = IIf(chk_cerrar_despacho.Checked, "S", "N")
            End With

            For i As Integer = 0 To dtdetalle_despachos.Rows.Count() - 1
                'If dgv_detalle_despacho_bandeja_despachos.Rows(i).Cells("SEL").Value Then
                '    MantenimientoOP_Corte = New ClsEntidades.MANTENIMIENTO_OP_CORTE
                '    With MantenimientoOP_Corte
                '        .ID = dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value
                '        .ITEM = dtdetalle_despachos.Rows(i).Item("ITEM").ToString
                '        .CONFORME = dtdetalle_despachos.Rows(i).Item("CONFORME").ToString
                '        If .CONFORME = "SI" Then
                '            .ESTADO = "SIR"
                '        ElseIf .CONFORME = "NO" Then
                '            .ESTADO = "SI"
                '        End If

                '        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                '        .PC_ID = Environment.MachineName
                '        .FECHA_PROGRAMADO = dgv_detalle_despachos_programados.CurrentRow.Cells("Fecha_Despacho").Value 'dtdetalle_despachos.Rows(i).Item("FECHA_DESPACHO").ToString
                '        .NUMERO_GR = dtdetalle_despachos.Rows(i).Item("NUMERO_GR").ToString
                '        .FECHA_GR = dtdetalle_despachos.Rows(i).Item("FECHA_GR").ToString
                '        .CANTIDAD_GR = dtdetalle_despachos.Rows(i).Item("CANTIDAD_GR").ToString
                '        .OBS_GR = dtdetalle_despachos.Rows(i).Item("OBS_GR").ToString
                '    End With
                '    MantenimientoOP_Corte_Lista.Add(MantenimientoOP_Corte)
                'End If
            Next

            'If clsPedidoBl.Guardar_Mantenimiento_OP_Despachos(PedidoCabENT, MantenimientoOP_Corte_Lista) Then

            '    Dim DT_DATOS_ENVIO_EMAIL As DataTable
            '    DT_DATOS_ENVIO_EMAIL = clsPedidoBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL("77")

            '    If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
            '        _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
            '        _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
            '        _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
            '        _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
            '        _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
            '        _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
            '        _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
            '        _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
            '    End If

            '    Dim contador_ As Integer = 0


            '    contador_ = 0
            '    _mensaje = "Se registro la confirmación de despacho: " & vbCrLf & vbCrLf
            '    _mensaje = _mensaje & " Vendedor : " & _vendedor_correo & vbCrLf & vbCrLf


            '    For i As Integer = 0 To dtdetalle_despachos.Rows.Count() - 1
            '        If dgv_detalle_despacho_bandeja_despachos.Rows(i).Cells("SEL").Value Then
            '            _mensaje = _mensaje & vbTab & "- " & contador_ + 1 & vbTab & " N° O.P. : " & dgv_detalle_despachos_programados.CurrentRow.Cells("N° O.P.").Value & vbTab & ";  FECHA DESPACHADO : " & dtdetalle_despachos.Rows(i).Item("FECHA_GR").ToString & vbCrLf
            '            _mensaje = _mensaje & vbTab & "  CLIENTE : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Cliente").Value & vbCrLf
            '            _mensaje = _mensaje & vbTab & "  N° PRESUPUESTO : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Presupuesto").Value & vbCrLf
            '            _mensaje = _mensaje & vbTab & "  CANTIDAD : " & dtdetalle_despachos.Rows(i).Item("CANTIDAD_GR").ToString & vbTab & ";  PRODUCTO : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Producto").Value & vbCrLf
            '            _mensaje = _mensaje & vbTab & "  GUIA DE REMISION : " & dtdetalle_despachos.Rows(i).Item("NUMERO_GR").ToString & vbCrLf
            '            _mensaje = _mensaje & vbTab & "  OBSERVACIONES DEL DESPACHO : " & dtdetalle_despachos.Rows(i).Item("OBS_GR").ToString & vbCrLf
            '            contador_ = contador_ + 1
            '        End If
            '    Next

            '    If dgv_detalle_despachos_programados.CurrentRow.Cells("Cliente").Value = "EDICIONES HR" Then
            '        _correo_vendedor = _correo_vendedor & ",carla.morales@remugraf.com,Roger.remuzgo@remugraf.com,asistente.produccion@remugraf.com"
            '    End If

            '    Try
            '        Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, _correo_vendedor, _ASUNTO, _mensaje)
            '        Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
            '        Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
            '        smpt.EnableSsl = True
            '        smpt.Credentials = acceso
            '        smpt.Port = _PUERTO
            '        smpt.Host = _SERVER

            '        smpt.Send(mensajes)
            '        'MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")

            '    Catch ex As Exception
            '        Me.Cursor = Cursors.Default
            '        MsgBox(ex.Message)
            '    End Try

            '    MsgBox("Mantenimiento de Proceso Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
            'End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button75_Click(sender As Object, e As EventArgs)
        'pnl_detalle_despachos.Visible = False
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs)
        'Try

        '    If flag_modificar_logistica = True Then

        '        For Each row As DataRow In dtdetalle_despachos.Select("ITEM=" & Codigo_logistica)
        '            dtdetalle_despachos.BeginInit()

        '            'row("CONFORME") = IIf(CheckBox1.Checked, "SI", "NO")

        '            If row("CONFORME") = "SI" Then
        '                row("ESTADO") = "TERMINADO"
        '            ElseIf row("CONFORME") = "NO" Then
        '                row("ESTADO") = "EN PROCESO"
        '            End If

        '            row("NUMERO_GR") = TextBox32.Text
        '            row("FECHA_GR") = DateTimePicker4.Value.ToString("dd/MM/yyyy")
        '            row("CANTIDAD_GR") = TextBox28.Text
        '            row("OBS_GR") = TextBox33.Text

        '            dtdetalle_despachos.EndInit()
        '            dtdetalle_despachos.AcceptChanges()
        '        Next

        '        flag_modificar_logistica = False
        '        dgv_detalle_despacho_bandeja_despachos.DataSource = dtdetalle_despachos

        '        TextBox39.Text = ""
        '        TextBox35.Text = ""
        '        DateTimePicker5.Value = LibComunVar.ClsVarComun.FechaSistema
        '        TextBox34.Text = ""

        '        TextBox32.Text = ""
        '        TextBox28.Text = ""
        '        DateTimePicker4.Value = LibComunVar.ClsVarComun.FechaSistema
        '        TextBox33.Text = ""

        '        CheckBox1.Checked = False
        '        dgv_detalle_despacho_bandeja_despachos.Focus()
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs)
        'Try
        '    If dgv_detalle_despacho_bandeja_despachos.RowCount = 0 Then Exit Sub
        '    If dgv_detalle_despacho_bandeja_despachos.CurrentRow Is Nothing Then Exit Sub
        '    If dgv_detalle_despacho_bandeja_despachos.CurrentRow.Cells("ESTADO").Value = "TERMINADO" Then
        '        MsgBox("El item elegido esta TERMINADO, no procede la modificación.", MsgBoxStyle.Exclamation, "Sistemas")
        '        Exit Sub
        '    End If

        '    Me.Cursor = Cursors.WaitCursor

        '    TextBox39.Text = ""
        '    TextBox35.Text = ""
        '    DateTimePicker5.Value = LibComunVar.ClsVarComun.FechaSistema
        '    TextBox34.Text = ""

        '    TextBox32.Text = ""
        '    TextBox28.Text = ""
        '    DateTimePicker4.Value = LibComunVar.ClsVarComun.FechaSistema
        '    TextBox33.Text = ""


        '    Codigo_logistica = dgv_detalle_despacho_bandeja_despachos.CurrentRow.Cells("ITEM").Value
        '    'Borrando los Datos
        '    For Each item As DataRow In dtdetalle_despachos.Select("ITEM=" & Codigo_logistica)
        '        flag_modificar_logistica = True
        '        TextBox39.Text = item("CANTIDAD")
        '        TextBox35.Text = item("PUNTO_SALIDA")
        '        DateTimePicker5.Value = item("FECHA_DESPACHO")
        '        TextBox34.Text = item("OBSERVACIONES")

        '        If item("CONFORME") = "SI" Then
        '            CheckBox1.Checked = True
        '        ElseIf item("CONFORME") = "NO" Then
        '            CheckBox1.Checked = False
        '        End If

        '        TextBox32.Text = item("NUMERO_GR")
        '        If item("FECHA_GR") = "" Then
        '            DateTimePicker4.Value = LibComunVar.ClsVarComun.FechaSistema
        '        Else
        '            DateTimePicker4.Value = item("FECHA_GR")
        '        End If

        '        TextBox28.Text = item("CANTIDAD_GR")
        '        TextBox33.Text = item("OBS_GR")
        '        TextBox32.Focus()

        '    Next
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs)
        'TextBox40.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Cliente").Value
        'TextBox36.Text = dgv_detalle_despachos_programados.CurrentRow.Cells("Producto").Value
        'TextBox39.Text = ""
        'TextBox35.Text = ""
        'DateTimePicker5.Value = LibComunVar.ClsVarComun.FechaSistema
        'TextBox34.Text = ""

        'TextBox32.Text = ""
        'TextBox28.Text = ""
        'DateTimePicker4.Value = LibComunVar.ClsVarComun.FechaSistema
        'TextBox33.Text = ""

        'CheckBox1.Checked = False
        'flag_modificar_logistica = False
        'Codigo_logistica = 0
    End Sub


    Private Sub dgv_detalle_prog_despacho_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_detalle_prog_despacho.CellFormatting
        If dgv_detalle_prog_despacho.Rows(e.RowIndex).Cells("REGRESO_PROG_DESPACHO").Value = "SI" Then
            dgv_detalle_prog_despacho.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalle_prog_despacho.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
            dgv_detalle_prog_despacho.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        Else
            dgv_detalle_prog_despacho.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalle_prog_despacho.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    'Private Sub dgv_detalle_despacho_bandeja_despachos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
    '    Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgv_detalle_despacho_bandeja_despachos.CurrentCell, DataGridViewCheckBoxCell)
    '    If cb IsNot Nothing Then
    '        dgv_detalle_despacho_bandeja_despachos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '    End If
    'End Sub

    'Private Sub dgv_detalle_despacho_bandeja_despachos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If Me.dgv_detalle_despacho_bandeja_despachos.Rows(e.RowIndex).Cells("Sel").Value = True Then
    '        For Each celda As DataGridViewCell In Me.dgv_detalle_despacho_bandeja_despachos.Rows(e.RowIndex).Cells
    '            celda.Style.BackColor = Color.GreenYellow
    '        Next
    '    Else
    '        For Each celda As DataGridViewCell In Me.dgv_detalle_despacho_bandeja_despachos.Rows(e.RowIndex).Cells
    '            celda.Style.BackColor = Color.White
    '        Next
    '    End If


    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    Try
    '        If dgv_detalle_despacho_bandeja_despachos.RowCount = 0 Then Exit Sub
    '        If dgv_detalle_despacho_bandeja_despachos.CurrentRow Is Nothing Then Exit Sub

    '        Me.Cursor = Cursors.WaitCursor
    '        clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
    '        crystalBL = New LibReportes.ClsReporte
    '        Dim dt_detalle_despachos_programados As DataTable

    '        dt_detalle_despachos_programados = clsPedidoBl.get_Mantenimiento_Despachos_Programados_Reporte(dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value,
    '                                                                                               dgv_detalle_despacho_bandeja_despachos.CurrentRow.Cells("ITEM").Value)
    '        If dt_detalle_despachos_programados.Rows.Count() <> 0 Then
    '            crystalBL.Muestra_Reporte("rpt_Formato_Despacho_reporte.rpt", dt_detalle_despachos_programados, "", "", _
    '                                              "@ID_CAB;" & dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value, _
    '                                              "@ITEM;" & dgv_detalle_despacho_bandeja_despachos.CurrentRow.Cells("ITEM").Value)
    '        Else
    '            MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
    '        End If

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub chk_cerrar_despacho_CheckedChanged(sender As Object, e As EventArgs)
    '    If chk_cerrar_despacho.Checked Then
    '        chk_cerrar_despacho.Text = "Desea cerrar el despacho de la O.P.? SI"
    '    Else
    '        chk_cerrar_despacho.Text = "Desea cerrar el despacho de la O.P.? NO"
    '    End If
    'End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
    '    If CheckBox1.Checked Then
    '        CheckBox1.Text = "Se cumplió el Despacho? SI"
    '    Else
    '        CheckBox1.Text = "Se cumplió el Despacho? NO"
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim DT_DATOS_ENVIO_EMAIL As DataTable
        DT_DATOS_ENVIO_EMAIL = clsPedidoBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL("77")

        If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
            _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
            _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
            _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
            _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
            _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
            _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
            _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
            _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
        End If

        Dim contador_ As Integer = 0


        contador_ = 0
        _mensaje = "Se registro la confirmación de despacho: " & vbCrLf & vbCrLf
        _mensaje = _mensaje & " Vendedor : " & _vendedor_correo & vbCrLf & vbCrLf


        For i As Integer = 0 To dtdetalle_despachos.Rows.Count() - 1
            'If dgv_detalle_despacho_bandeja_despachos.Rows(i).Cells("SEL").Value Then
            '    _mensaje = _mensaje & vbTab & "- " & contador_ + 1 & vbTab & " N° O.P. : " & dgv_detalle_despachos_programados.CurrentRow.Cells("N° O.P.").Value & vbTab & ";  FECHA DESPACHADO : " & dtdetalle_despachos.Rows(i).Item("FECHA_GR").ToString & vbCrLf
            '    _mensaje = _mensaje & vbTab & "  CLIENTE : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Cliente").Value & vbCrLf
            '    _mensaje = _mensaje & vbTab & "  N° PRESUPUESTO : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Presupuesto").Value & vbCrLf
            '    _mensaje = _mensaje & vbTab & "  CANTIDAD : " & dtdetalle_despachos.Rows(i).Item("CANTIDAD_GR").ToString & vbTab & ";  PRODUCTO : " & dgv_detalle_despachos_programados.CurrentRow.Cells("Producto").Value & vbCrLf
            '    _mensaje = _mensaje & vbTab & "  GUIA DE REMISION : " & dtdetalle_despachos.Rows(i).Item("NUMERO_GR").ToString & vbCrLf
            '    _mensaje = _mensaje & vbTab & "  OBSERVACIONES DEL DESPACHO : " & dtdetalle_despachos.Rows(i).Item("OBS_GR").ToString & vbCrLf
            '    contador_ = contador_ + 1
            'End If
        Next

        Try
            Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, "soporte@lusa.pe", _ASUNTO, _mensaje)
            mensajes.IsBodyHtml = True
            Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
            Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
            smpt.EnableSsl = True
            smpt.Credentials = acceso
            smpt.Port = _PUERTO
            smpt.Host = _SERVER

            smpt.Send(mensajes)
            MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProgramarDespManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarDespManualToolStripMenuItem.Click
        Try

            dgv_detalle_prog_despacho.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgv_detalle_prog_despacho.CurrentRow Is Nothing Then Exit Sub
            If dgv_detalle_prog_despacho.Rows.Count = 0 Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            'dtp_fecha_despacho_manual.Enabled = True
            'dtp_fecha_despacho_manual.Value = Date.Now
            'txt_cantidad_manual.Text = ""
            'txt_hr_entrega_manual.Text = dgv_detalle_prog_despacho.CurrentRow.Cells("HrEntregaAcordado").Value
            'txt_obs_manual.Text = ""
            'txt_nro_op_manual.Text = dgv_detalle_prog_despacho.CurrentRow.Cells("NOP").Value
            '_codigo_interno_op = dgv_detalle_prog_despacho.CurrentRow.Cells("CODIGO_INTERNO").Value
            'pnl_programar_Despachos.Enabled = False
            'pnl_genera_despacho_manual.BringToFront()
            'pnl_genera_despacho_manual.Visible = True
            'txt_cantidad_manual.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_cancelar_desp_manual_Click(sender As Object, e As EventArgs)
        pnl_programar_Despachos.Enabled = True
        'pnl_genera_despacho_manual.Visible = False
    End Sub

    Private Sub txt_cantidad_manual_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_manual_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'txt_hr_entrega_manual.Focus()
        End If
    End Sub

    Private Sub txt_hr_entrega_manual_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'txt_obs_manual.Focus()
        End If
    End Sub

    Private Sub txt_obs_manual_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'btn_prog_despacho_manual.Focus()
        End If
    End Sub

    Private Sub btn_prog_despacho_manual_Click(sender As Object, e As EventArgs)
        'If txt_cantidad_manual.Text = "" Then
        '    MsgBox("Debe indicar una cantidad.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'ElseIf CDbl(txt_cantidad_manual.Text) = 0 Then
        '    MsgBox("La cantidad debe ser mayor a cero.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        Try
            If MsgBox("Esta seguro de registrar la Programación de Despacho?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                Dim dt_vendedores As DataTable
                dt_vendedores = New DataTable
                dt_vendedores.Columns.Add("VENDEDOR", Type.GetType("System.String")) '1
                dt_vendedores.Columns.Add("CORREO", Type.GetType("System.String")) '1
                Dim existe_vendedor As Boolean = False
                Dim opt_vendedor As String = ""

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

                GenerarColummnaDataTable_Despachos_Correo()

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                With PedidoCabENT
                    .ID = _codigo_interno_op
                    .ESTADO_DESPACHO = "SI"
                    '.FECHA_DESPACHO = dtp_fecha_despacho_manual.Value.ToString("dd/MM/yyyy")
                    '.CANTIDAD_DESPACHO = txt_cantidad_manual.Text
                    '.PUNTO_SALIDA_DESPACHO = ""
                    '.OBSERVACIONES_DESPACHO = txt_obs_manual.Text
                    '.USER_ID_DESPACHO = LibComunVar.ClsVarComun.USUARIO
                    '.ITEM_DESPACHO = 1
                    '.HORA_ENTREGA_ACORDADO = txt_hr_entrega_manual.Text

                    opt_vendedor = dgv_detalle_prog_despacho.CurrentRow.Cells("Vendedor").Value

                    For Each rows As DataRow In dt_vendedores.Select("VENDEDOR='" & opt_vendedor & "' ")
                        existe_vendedor = True
                    Next

                    If existe_vendedor = False Then
                        Dim row As DataRow = dt_vendedores.NewRow
                        row("VENDEDOR") = opt_vendedor
                        row("CORREO") = dgv_detalle_prog_despacho.CurrentRow.Cells("Email").Value
                        dt_vendedores.Rows.Add(row)
                        dt_vendedores.AcceptChanges()
                    End If

                    Dim row2 As DataRow = dtdetalle_despacho_correo.NewRow
                    'row2("NOP") = txt_nro_op_manual.Text
                    'row2("FechaEntrega") = dtp_fecha_despacho_manual.Value.ToString("dd/MM/yyyy")
                    'row2("Cliente") = dgv_detalle_prog_despacho.CurrentRow.Cells("Cliente").Value
                    'row2("Producto") = dgv_detalle_prog_despacho.CurrentRow.Cells("Producto").Value
                    'row2("Cantidad") = txt_cantidad_manual.Text
                    'row2("HrEntregaAcordado") = ""
                    'row2("HrMaximoEntrega") = ""
                    'row2("PuntodeSalida") = ""
                    'row2("Observaciones") = txt_obs_manual.Text
                    row2("VENDEDOR") = dgv_detalle_prog_despacho.CurrentRow.Cells("Vendedor").Value
                    dtdetalle_despacho_correo.Rows.Add(row2)
                    dtdetalle_despacho_correo.AcceptChanges()

                End With
                MantenimientoOP_Lista.Add(PedidoCabENT)

                If clsPedidoBl.Guardar_Programacion_Despacho(MantenimientoOP_Lista) Then

                    Dim DT_DATOS_ENVIO_EMAIL As DataTable
                    DT_DATOS_ENVIO_EMAIL = clsPedidoBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL("88")

                    If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
                        _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
                        _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
                        _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
                        _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
                        _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
                        _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
                        _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
                        _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
                    End If

                    Dim contador_ As Integer = 0

                    For i As Integer = 0 To dt_vendedores.Rows.Count - 1
                        contador_ = 0
                        _mensaje = "Se registro la programación de los despachos: " & vbCrLf & vbCrLf
                        _mensaje = _mensaje & " Vendedor : " & dt_vendedores.Rows(i).Item(0).ToString & vbCrLf & vbCrLf

                        For Each rows As DataRow In dtdetalle_despacho_correo.Select("VENDEDOR='" & dt_vendedores.Rows(i).Item(0).ToString & "' ")
                            _mensaje = _mensaje & vbTab & "- " & contador_ + 1 & vbTab & " N° O.P. : " & rows("NOP") & vbTab & ";  FECHA DESPACHO : " & rows("FechaEntrega") & vbTab & ";  PUNTO DE SALIDA : " & rows("PuntodeSalida") & vbCrLf
                            _mensaje = _mensaje & vbTab & "  CLIENTE : " & rows("Cliente") & vbCrLf
                            _mensaje = _mensaje & vbTab & "  CANTIDAD : " & rows("Cantidad") & vbTab & ";  PRODUCTO : " & rows("Producto") & vbCrLf
                            _mensaje = _mensaje & vbTab & "  OBSERVACIONES : " & rows("Observaciones") & vbCrLf
                            contador_ = contador_ + 1
                        Next

                        Try
                            Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, dt_vendedores.Rows(i).Item(1).ToString, _ASUNTO, _mensaje)
                            Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
                            Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
                            smpt.EnableSsl = True
                            smpt.Credentials = acceso
                            smpt.Port = _PUERTO
                            smpt.Host = _SERVER

                            smpt.Send(mensajes)
                            'MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")

                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MsgBox(ex.Message)
                        End Try
                    Next

                    MsgBox("Programación de Despacho Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    'dgv_detalle_prog_despacho.DataSource = Nothing

                    If dgv_detalle_prog_despacho.RowCount() <> 0 Then
                        For n As Integer = dgv_detalle_prog_despacho.Rows.Count - 1 To 0 Step -1
                            Dim row As DataGridViewRow = dgv_detalle_prog_despacho.Rows(n)
                            dgv_detalle_prog_despacho.Rows.Remove(row)
                        Next
                    End If

                    Call Consulta_Despachos()
                    dtp_fecha_despacho.Value = Date.Now
                    btn_prog_despacho_final.Focus()
                    btn_cancelar_desp_manual_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles btn_actualiza_correlativo.Click
        If Validar_Act_Correlativo_Despachos_programados() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de actualizar el Correlativo de la Lista de Despachos programados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                For i As Integer = 0 To dgv_detalle_despachos_programados.Rows.Count - 1
                    If dgv_detalle_despachos_programados.Rows(i).Cells("SEL").Value Then
                        PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                        With PedidoCabENT
                            .ID = dgv_detalle_despachos_programados.Rows(i).Cells("CODIGO_INTERNO").Value
                            .FECHA_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Fecha Programada").Value
                            .USER_ID_DESPACHO = LibComunVar.ClsVarComun.USUARIO
                            .ITEM_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Nuevo Orden").Value
                            .ITEM_ANT_DESPACHO = dgv_detalle_despachos_programados.Rows(i).Cells("Sec. Despacho.").Value
                        End With
                        MantenimientoOP_Lista.Add(PedidoCabENT)
                    End If
                Next

                If clsPedidoBl.Guardar_Act_Correlativo_Programacion_Lista_Despacho(MantenimientoOP_Lista) Then
                    MsgBox("Actualización de Programación de Lista de Despachos generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    dgv_detalle_despachos_programados.DataSource = Nothing
                    dtp_fi_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    dtp_ff_dp.Value = LibComunVar.ClsVarComun.FechaSistema
                    btn_consultar.Focus()
                End If

                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_todos_lineas_produccion_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_lineas_produccion.CheckedChanged
        txt_cod_linea_produccion.Text = String.Empty
        txt_des_linea_produccion.Text = String.Empty
        txt_cod_linea_produccion.Enabled = Not chk_todos_lineas_produccion.Checked
        txt_des_linea_produccion.Enabled = Not chk_todos_lineas_produccion.Checked
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Call Consulta_Despachos()
    End Sub

    Private Sub txt_cod_linea_produccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_linea_produccion.MouseDoubleClick
        Ayuda_Linea_Produccion()
    End Sub

    Private Sub txt_cod_linea_produccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_linea_produccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Linea_Produccion()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_linea_produccion.Text.Trim = "" Then
                Ayuda_Linea_Produccion()
            End If
        End If
    End Sub

    Private Sub Ayuda_Linea_Produccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            _cod_familia = ""
            sql = "SAL_HLP_FIND_LINEA_PRODUCCION"
            frm.CadenaConsulta = sql
            frm.Titulo = "LINEA DE PRODUCCION"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_linea_produccion.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_linea_produccion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _cod_familia = frm.Data_Matriz.Rows(0).Item("COD_FAMILIA").ToString
            Else
                txt_cod_linea_produccion.Text = ""
                txt_des_linea_produccion.Text = ""
                _cod_familia = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_todos_lineas_produccion_2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_lineas_produccion_2.CheckedChanged
        txt_cod_linea_produccion_2.Text = String.Empty
        txt_des_linea_produccion_2.Text = String.Empty
        txt_cod_linea_produccion_2.Enabled = Not chk_todos_lineas_produccion_2.Checked
        txt_des_linea_produccion_2.Enabled = Not chk_todos_lineas_produccion_2.Checked
    End Sub

    Private Sub txt_cod_linea_produccion_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_linea_produccion_2.MouseDoubleClick
        Ayuda_Linea_Produccion_2()
    End Sub

    Private Sub txt_cod_linea_produccion_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_linea_produccion_2.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Linea_Produccion_2()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_linea_produccion_2.Text.Trim = "" Then
                Ayuda_Linea_Produccion_2()
            End If
        End If
    End Sub
    Private Sub Ayuda_Linea_Produccion_2()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_LINEA_PRODUCCION"
            frm.CadenaConsulta = sql
            frm.Titulo = "LINEA DE PRODUCCION"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_linea_produccion_2.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_linea_produccion_2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_Equipos(ByVal cod As TextBox, ByVal des As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MAQUINAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE EQUIPOS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cod.Text = frm.Data_Matriz.Rows(0).Item(0)
                des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Else
                cod.Text = ""
                des.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles btn_datos_reprogramacion.Click
        If datos_reprogramacion = False Then
            txt_motivo.Text = ""
            txt_observacion.Text = ""
        End If
        pnl_despachos_programados.Enabled = False
        pnl_reprogramar_despacho.Visible = True
        pnl_reprogramar_despacho.BringToFront()
        txt_motivo.Focus()
    End Sub

    

    Private Sub dgv_detalle_despachos_programados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle_despachos_programados.CellClick
        If dgv_detalle_despachos_programados.RowCount() = 0 Then Exit Sub
        If dgv_detalle_despachos_programados.CurrentRow Is Nothing Then Exit Sub

        If e.ColumnIndex = 16 Then '
            Try
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Dim dtDatosCompany As DataTable
                dtDatosCompany = New DataTable
                crystalBL = New LibReportes.ClsReporte


                Dim dt_detalle_despachos_programados As DataTable

                dt_detalle_despachos_programados = clsPedidoBl.get_Reporte_Comparativo_OP_vs_Dispensado(dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value)
                dtDatosCompany = clsPedidoBl.Obtener_Datos_Empresa()

                If dt_detalle_despachos_programados.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_Formato_Comparativo.rpt", dt_detalle_despachos_programados, "", "", _
                                                      "@CODIGO_INTERNO;" & dgv_detalle_despachos_programados.CurrentRow.Cells("CODIGO_INTERNO").Value, _
                                                      "titulo;" & "COMPARATIVO DE DISPENSACION POR ORDEN DE PRODUCCION", _
                                                      "ruc;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString)
                Else
                    MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                End If

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LiquidarOrdenDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidarOrdenDeProducciónToolStripMenuItem.Click
        If dgv_detalle_despachos_programados.RowCount() = 0 Then
            MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
            Exit Sub
        End If

        pnl_despachos_programados.Enabled = False
        
    End Sub

    

    
    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        If txt_motivo.Text = "" Then
            MsgBox("Debe ingresar un Motivo.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        datos_reprogramacion = True
        pnl_despachos_programados.Enabled = True
        pnl_reprogramar_despacho.Visible = False
    End Sub

    Private Sub Button132_Click(sender As Object, e As EventArgs) Handles Button132.Click
        pnl_despachos_programados.Enabled = True
        pnl_reprogramar_despacho.Visible = False
    End Sub
End Class