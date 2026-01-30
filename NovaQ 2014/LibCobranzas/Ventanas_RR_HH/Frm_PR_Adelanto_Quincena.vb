Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports LibComunVar


Public Class Frm_PR_Adelanto_Quincena

    Dim clsPedidoBl As ClsOperaciones.ORDERS
    Dim dtv_bandeja_pre_prensa As DataView
    Dim dtv_bandeja_pre_prensa_op As DataView
    Dim STRorden_bandeja_pre_prensa As String = String.Empty
    Dim STRorden_bandeja_pre_prensa_op As String = String.Empty
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtdetalle_pre_prensa As DataTable
    Dim flag_modificar_logistica As Boolean = False
    Dim pl_planilla_cab As ClsEntidades.PL_PLANILLA
    Dim pl_planilla_det As ClsEntidades.PL_ADELANTO_QUINCENA_LINE
    Dim Codigo_logistica As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS
    Dim id_op_planeamiento As Integer
    Dim vendedorBL As LibCobranzas.ClsOperaciones.SALES_REP
    Dim _inicio As Boolean = False
    Dim _codigo_planilla As Integer = 0
    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String
    Dim dtTrabajos_Mantenimiento As DataTable
    Dim Modo_actualizar As Boolean = False

    'Dim Cab_Certificado_Calidad As ClsEntidades.PLANILLA_LETRAS_BANCO
    'Dim Det_Certificado_Calidad As ClsEntidades.PLANILLA_LETRAS_BANCO_LINE

    Dim dtDocumentos As DataTable
    Dim dtDocumentos_ingresos_Descuentos_variables As DataTable
    Dim dt_ingresos_variables As DataTable
    Dim dt_descuentos_variables As DataTable
    Dim dtv As DataView
    Dim dtv_conceptos_variables As DataView
    Dim STRorden As String = ""
    Dim STRorden_conceptos_variables As String = ""
    Dim _codigo_personal As String = ""
    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable

    Private Sub Frm_PR_Adelanto_Quincena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        _inicio = False
        dtpfechaInicial.Value = "01/01/" & ClsVarComun.FechaSistema.Year.ToString
        dtpfechafinal.Value = "31/12/" & ClsVarComun.FechaSistema.Year.ToString
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            lbl_por_adelanto.Visible = False
            txt_por_adelanto.Visible = False
            btn_calcular_adelanto.Visible = False
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            _inicio = True
            _codigo_planilla = 0
            Modo_actualizar = False
            dtpFecha_inicial.Enabled = True
            txtcodigo.Text = Numeracion()
            Label18.Visible = True
            btn_anexar.Visible = True
            checkTodos.Checked = False
            TabControl1.SelectedIndex = 0

            txt_titulo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = TabControl1.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        '-----------------------------------
        'Select Case TabControl1.SelectedIndex
        '    Case 0
        '        TabControl1.SelectedIndex = indice + 1
        '    Case 1
        '        TabControl1.SelectedIndex = indice - 1
        '    Case 2
        '        TabControl1.SelectedIndex = indice - 2
        '    Case 3
        '        TabControl1.SelectedIndex = indice - 3
        'End Select
        ' ----------------------------------
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            'vendedorBL = New LibCobranzas.ClsOperaciones.SALES_REP
            'Dim dtdetalles As DataTable
            'dtdetalles = New DataTable("CodigoVendedor")
            'dtdetalles = vendedorBL.get_Codigo_Adelanto_Quincena_RRHH(dtpFecha_inicial.Value.Year)
            'If dtdetalles.Rows.Count() <> 0 Then
            '    Correlativo = String.Format("{0:00000}", CInt(dtdetalles.Rows(0).Item("NUMBER").ToString) + 1) & "-" & dtpFecha_inicial.Value.Year.ToString
            'End If

            Correlativo = String.Format("{0:00000}", dtpFecha_inicial.Value.Month) & "-" & dtpFecha_inicial.Value.Year.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub limpiar()
        txtcodigo.Text = ""
        dtpFecha_inicial.Value = Date.Now
        txt_titulo.Text = ""
        txt_por_adelanto.Text = ""
        mtb_total_adelanto.Text = "0.00"

        If dgvDetalle1.RowCount() <> 0 Then
            For n As Integer = dgvDetalle1.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgvDetalle1.Rows(n)
                dgvDetalle1.Rows.Remove(row)
            Next
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        Ayuda_Anexa_Personal()
    End Sub

    Private Sub Ayuda_Anexa_Personal()
        Try
            Me.Cursor = Cursors.WaitCursor

            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsPedidoBl.Ejecutar_Anexar_Personal_Adelanto_Quincena()
            If dtDocumentos.Rows.Count > 0 Then
                dgvDetalle1.DataSource = dtDocumentos
                Formato_Grilla()
                Sumar_Marcados()
                checkTodos.Checked = True
                dgvDetalle1.Update()
                lbl_por_adelanto.Visible = True
                txt_por_adelanto.Visible = True
                btn_calcular_adelanto.Visible = True
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        'limpiar()
        GbCabecera.Enabled = False
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Function Validar_Calculo_Adelanto_Quincena() As Boolean
        Try
            If txtcodigo.Text = "" Then
                MsgBox("La Planilla de Adelanto de Quincena no tiene codigo.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txt_titulo.Text = "" Then
                MsgBox("Debe ingresar un TITULO a la Planilla de Adelanto de Quincena.", MsgBoxStyle.Exclamation)
                txt_titulo.Focus()
                Return False
            End If

            If txt_por_adelanto.Text = "" Then
                MsgBox("Debe digitar el % de adelanto.", MsgBoxStyle.Exclamation)
                Exit Function
            End If


            'VARIABLES
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvDetalle1.RowCount() = 0 Then
                MsgBox("No hay items para procesar.", MsgBoxStyle.Exclamation)
                dgvDetalle1.Focus()
                TabControl1.SelectedIndex = 0
                Return False
            Else
                Dim estado As Boolean = False
                Dim item_marcados As Integer = 0
                For Each row As DataGridViewRow In dgvDetalle1.Rows
                    If row.Cells("Sel").Value = True Then
                        item_marcados = item_marcados + 1
                        Exit For
                    End If
                Next
                If item_marcados = 0 Then
                    MessageBox.Show("Debe seleccionar al menos un item.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvDetalle1.Focus()
                    TabControl1.SelectedIndex = 0
                    Return False
                End If
                'For Each row As DataGridViewRow In dgvDetalle1.Rows
                '    If row.Cells("Sel").Value = True And (row.Cells("MONTO_ADELANTO").Value = 0 Or row.Cells("MONTO_ADELANTO").Value = "") Then
                '        MessageBox.Show("Hay un monto de adelanto con valor cero.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '        Return False
                '        Exit For
                '    End If
                'Next

            End If
            dgvDetalle1.Refresh()

            If Modo_actualizar = False Then
                vendedorBL = New LibCobranzas.ClsOperaciones.SALES_REP
                Dim dtdetalles As DataTable
                dtdetalles = New DataTable("CodigoVendedor")
                dtdetalles = vendedorBL.get_Verifico_Adelanto_Quincena_RRHH(dtpFecha_inicial.Value.Month, dtpFecha_inicial.Value.Year)
                If dtdetalles.Rows.Count() <> 0 Then
                    MsgBox("Existe un Adelanto de Quincena con el mes/año elegido.", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If

            If Verificar_Apertura_Cierre_Modulos(dtpFecha_inicial.Value.Month, dtpFecha_inicial.Value.Year) = False Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "RECURSOS_HUMANOS")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar el Adelanto de Quincena.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Validar_Calculo_Adelanto_Quincena() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de registrar la Planilla de Adelanto de Quincena?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New ClsOperaciones.ORDERS
                pl_planilla_cab = New ClsEntidades.PL_PLANILLA
                pl_planilla_det = New ClsEntidades.PL_ADELANTO_QUINCENA_LINE
                Dim lista_pl_planilla_det As New List(Of ClsEntidades.PL_ADELANTO_QUINCENA_LINE)

                With pl_planilla_cab
                    .ID = _codigo_planilla
                    .CODIGO = txtcodigo.Text
                    .TITULO = txt_titulo.Text
                    .MES_ANIO = ModFunciones.Primer_Dia_Mes(dtpFecha_inicial.Value.ToString("dd/MM/yyyy"))
                    .STATUS = "V"
                    .USER_ID = LibComunVar.ClsVarComun.USUARIO
                    .PORCENTAJE_ADELANTO = CDbl(txt_por_adelanto.Text)
                End With

                For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                    If dgvDetalle1.Rows(i).Cells("Sel").Value Then
                        pl_planilla_det = New ClsEntidades.PL_ADELANTO_QUINCENA_LINE
                        With pl_planilla_det
                            .ID_CAB = _codigo_planilla
                            .ITEM = dgvDetalle1.Rows(i).Cells("ITEM").Value
                            .CODIGO = dgvDetalle1.Rows(i).Cells("CODIGO").Value
                            .NUMERO_DOC = dgvDetalle1.Rows(i).Cells("NUMERO_DOC").Value
                            .BASICO = dgvDetalle1.Rows(i).Cells("BASICO").Value
                            .ASIGNACION_FAMILIAR = dgvDetalle1.Rows(i).Cells("ASIGNACION_FAMILIAR").Value
                            .MOVILIDAD = dgvDetalle1.Rows(i).Cells("MOVILIDAD").Value
                            .TOTAL_INGRESOS = dgvDetalle1.Rows(i).Cells("TOTAL_INGRESOS").Value
                            .MONTO_ADELANTO = dgvDetalle1.Rows(i).Cells("MONTO_ADELANTO").Value
                        End With
                        lista_pl_planilla_det.Add(pl_planilla_det)
                    End If
                Next

                If clsPedidoBl.Guardar_Adelanto_Quincena(pl_planilla_cab, lista_pl_planilla_det, _codigo_planilla) Then
                    MsgBox("Planilla de Adelanto de Quincena registrado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sumar_Marcados()
        Dim total_neto_pagar As Double = 0
        Dim total_afp As Double = 0
        Dim total_onp As Double = 0
        Dim total_aportes As Double = 0

        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
            If dgvDetalle1.Rows(i).Cells("Sel").Value = True Then
                total_neto_pagar += dgvDetalle1.Rows(i).Cells("MONTO_ADELANTO").Value
            End If
        Next
        mtb_total_adelanto.Text = total_neto_pagar
        mtb_total_adelanto.Text = Format(Double.Parse(mtb_total_adelanto.Text), "##,##0.00")
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

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("TITULO").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name & "+" & dgvCabecera.Columns("TITULO").Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    System.Windows.Forms.MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            dtv = New DataView
            dtDocumentos = clsPedidoBl.get_Lista_Adelanto_Quincena_RRHH(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"),
                                                                           cboopcionesBusqueda.SelectedIndex)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                dgvCabecera.Columns("ID").Visible = False
                dgvCabecera.Columns("FECHA").Visible = False
                dgvCabecera.Columns("PORCENTAJE_ADELANTO").Visible = False
                dgvCabecera.Columns("NUMERO_PLANILLA").HeaderText = "N° PLANILLA"
                dgvCabecera.Columns("TITULO").HeaderText = "TITULO"
                dgvCabecera.Columns("MES_ANIO").HeaderText = "MES/AÑO"
                dgvCabecera.Columns("ESTADO").HeaderText = "ESTADO"

                dgvCabecera.Columns("NUMERO_PLANILLA").Width = 100
                dgvCabecera.Columns("TITULO").Width = 400
                dgvCabecera.Columns("MES_ANIO").Width = 100
                dgvCabecera.Columns("ESTADO").Width = 100

                STRorden = dgvCabecera.Columns("NUMERO_PLANILLA").Name & "+" & dgvCabecera.Columns("TITULO").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Botonera_Estado_Cambiar(True)
            Modo_actualizar = True
            limpiar()
            _inicio = True
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            dtpFecha_inicial.Enabled = False

            _codigo_planilla = dgvCabecera.CurrentRow.Cells("ID").Value
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("NUMERO_PLANILLA").Value
            txt_titulo.Text = dgvCabecera.CurrentRow.Cells("TITULO").Value
            dtpFecha_inicial.Value = dgvCabecera.CurrentRow.Cells("FECHA").Value
            txt_por_adelanto.Text = dgvCabecera.CurrentRow.Cells("PORCENTAJE_ADELANTO").Value
            txt_por_adelanto.Text = Format(Double.Parse(txt_por_adelanto.Text), "##,##0.00")

            If dgvCabecera.CurrentRow.Cells("ESTADO").Value = "FINALIZADO" Then
                btn_anexar.Visible = False
                btnGrabar.Enabled = False
            Else
                btn_anexar.Visible = False
            End If

            Label18.Visible = False
            MostrarModoConsultar(_codigo_planilla)
            TabControl1.SelectedIndex = 0
            lbl_por_adelanto.Visible = True
            txt_por_adelanto.Visible = True
            btn_calcular_adelanto.Visible = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModoConsultar(ByVal _codigo As Integer)
        Try
            clsPedidoBl = New ClsOperaciones.ORDERS
            'Mostrando datos del detalle
            dtDocumentos = New DataTable
            dtDocumentos = clsPedidoBl.Get_Datos_Detalle_Adelanto_Quincena(_codigo)
            If dtDocumentos.Rows.Count > 0 Then
                dgvDetalle1.DataSource = dtDocumentos
                Formato_Grilla()
                Sumar_Marcados()
                checkTodos.Checked = True
                dgvDetalle1.Update()
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Formato_Grilla()

        If dtDocumentos.Rows.Count() <> 0 Then
            dgvDetalle1.Columns("Sel").Width = 30
            dgvDetalle1.Columns("ITEM").Width = 30
            dgvDetalle1.Columns("NUMERO_DOC").Width = 70
            dgvDetalle1.Columns("APELLIDOS_NOMBRES").Width = 300
            dgvDetalle1.Columns("APELLIDOS_NOMBRES").Frozen = True
            dgvDetalle1.Columns("BASICO").Width = 100
            dgvDetalle1.Columns("ASIGNACION_FAMILIAR").Width = 100
            dgvDetalle1.Columns("MOVILIDAD").Width = 100
            dgvDetalle1.Columns("BASICO").Width = 100
            dgvDetalle1.Columns("TOTAL_INGRESOS").Width = 100

            dgvDetalle1.Columns("BASICO").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("ASIGNACION_FAMILIAR").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("MOVILIDAD").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("TOTAL_INGRESOS").DefaultCellStyle.Format = "N2"
            dgvDetalle1.Columns("MONTO_ADELANTO").DefaultCellStyle.Format = "N2"

            dgvDetalle1.Columns("BASICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("MONTO_ADELANTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("ASIGNACION_FAMILIAR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("MOVILIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle1.Columns("TOTAL_INGRESOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalle1.Columns("ITEM").ReadOnly = True
            dgvDetalle1.Columns("NUMERO_DOC").ReadOnly = True
            dgvDetalle1.Columns("APELLIDOS_NOMBRES").ReadOnly = True
            dgvDetalle1.Columns("BASICO").ReadOnly = True
            dgvDetalle1.Columns("ASIGNACION_FAMILIAR").ReadOnly = True
            dgvDetalle1.Columns("MOVILIDAD").ReadOnly = True
            dgvDetalle1.Columns("TOTAL_INGRESOS").ReadOnly = True
            dgvDetalle1.Columns("MONTO_ADELANTO").ReadOnly = False

        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte


            Dim dt_imprime_planilla As DataTable

            dt_imprime_planilla = clsPedidoBl.Rpt_Imprime_Planilla(dgvCabecera.CurrentRow.Cells("ID").Value)

            If dt_imprime_planilla.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Planilla_Letras_Banco.rpt", dt_imprime_planilla, "", "",
                                                  "@NUMERO;" & dgvCabecera.CurrentRow.Cells("ID").Value)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_inicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_inicial.ValueChanged
        If _inicio = True And Modo_actualizar = False Then
            txtcodigo.Text = Numeracion()
        End If
    End Sub

    Private Sub dgvDetalle1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDetalle1.CellFormatting
        If e.ColumnIndex = 8 Then
            e.CellStyle.BackColor = Color.Pink
        End If

    End Sub

    Private Sub RegistrarIngresosdescuentosVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarIngresosdescuentosVariablesToolStripMenuItem.Click
        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            _codigo_personal = dgvDetalle1.CurrentRow.Cells("CODIGO").Value

            For Each row As DataRow In dtDocumentos_ingresos_Descuentos_variables.Select("TIPO='I' AND COD_PERSONAL='" & _codigo_personal & "'")
                Dim row2 As DataRow = dt_ingresos_variables.NewRow
                row2("ITEM") = dt_ingresos_variables.Rows.Count() + 1
                row2("TIPO") = row("TIPO")
                row2("COD_PERSONAL") = row("COD_PERSONAL")
                row2("COD_CONCEPTO") = row("COD_CONCEPTO")
                row2("CONCEPTO") = row("CONCEPTO")
                row2("MONTO") = row("MONTO")
                dt_ingresos_variables.Rows.Add(row2)
                dt_ingresos_variables.AcceptChanges()
            Next
            'dgv_ingresos.DataSource = dt_ingresos_variables


            For Each row As DataRow In dtDocumentos_ingresos_Descuentos_variables.Select("TIPO='D' AND COD_PERSONAL='" & _codigo_personal & "'")
                Dim row2 As DataRow = dt_descuentos_variables.NewRow
                row2("ITEM") = dt_descuentos_variables.Rows.Count() + 1
                row2("TIPO") = row("TIPO")
                row2("COD_PERSONAL") = row("COD_PERSONAL")
                row2("COD_CONCEPTO") = row("COD_CONCEPTO")
                row2("CONCEPTO") = row("CONCEPTO")
                row2("MONTO") = row("MONTO")
                dt_descuentos_variables.Rows.Add(row2)
                dt_descuentos_variables.AcceptChanges()
            Next
            'dgv_descuentos.DataSource = dt_descuentos_variables

            GbCabecera.Enabled = False
            btn_menu.Enabled = False
            TabControl1.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ImprimirBoletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirBoletaToolStripMenuItem.Click
        dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgvDetalle1.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            Dim dt_imprime_planilla As DataTable

            _codigo_personal = dgvDetalle1.CurrentRow.Cells("CODIGO").Value
            dt_imprime_planilla = clsPedidoBl.Rpt_Imprime_Boleta_RR_HH(dgvCabecera.CurrentRow.Cells("ID").Value, _codigo_personal)

            If dt_imprime_planilla.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Boleta_Pago_RRHH.rpt", dt_imprime_planilla, "", "",
                                                  "@ID;" & dgvCabecera.CurrentRow.Cells("ID").Value,
                                                  "@CODIGO_PERSONAL;" & _codigo_personal)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_por_adelanto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_por_adelanto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_titulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_titulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_por_adelanto.Focus()
        End If
    End Sub

    Private Sub txt_por_adelanto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_por_adelanto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_calcular_adelanto.Focus()
        End If
    End Sub

    Private Sub btn_calcular_adelanto_Click(sender As Object, e As EventArgs) Handles btn_calcular_adelanto.Click
        If txt_por_adelanto.Text = "" Then
            MsgBox("Debe digitar el % de adelanto.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                If dgvDetalle1.Rows(i).Cells("Sel").Value Then
                    dgvDetalle1.Rows(i).Cells("MONTO_ADELANTO").Value = Math.Round(CDbl(dgvDetalle1.Rows(i).Cells("TOTAL_INGRESOS").Value) * (CDbl(txt_por_adelanto.Text) / 100), 2)
                End If
            Next

            Formato_Grilla()
            Sumar_Marcados()
            dgvDetalle1.Update()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvDetalle1_CellEndEdit_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle1.CellEndEdit
        Sumar_Marcados()
    End Sub

    Private Sub checkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkTodos.CheckedChanged
        If checkTodos.Checked = True Then
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                dgvDetalle1.Rows(i).Cells("Sel").Value = True
            Next
        Else
            dgvDetalle1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                dgvDetalle1.Rows(i).Cells("Sel").Value = False
            Next
        End If
        Sumar_Marcados()
    End Sub
End Class