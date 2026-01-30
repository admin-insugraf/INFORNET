Imports System.Windows.Forms
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Frm_CX_MA_Oportunidad_clientes
    Dim dv_lista As New DataView
    Dim bol_nuevo As Boolean = False
    Dim bol_aprobar As Boolean = False
    Dim bol_adm As Boolean = False
    Dim bol_cargar As Boolean = False
    Dim clsLetrasBl As ClsNegocio.PART
    Dim clsBuscarBl As ClsBuscar
    Dim clienteBL As ClsNegocio.CUSTOMER
    Dim dtdetalles As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE

    Private Sub Frm_CX_MA_Oportunidad_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        bol_adm = NIVEL_ACCESO()
        cbo_dias_sin_atencion.SelectedIndex = 0
        Call Cargar_Clientes("", cbo_dias_sin_atencion.SelectedIndex)
        bol_cargar = True
    End Sub

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalles = New DataTable
            dtdetalles.Columns.Add("Sel", Type.GetType("System.Boolean"))

            dtdetalles.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalles.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalles.Columns.Add("RUC", Type.GetType("System.String"))
            dtdetalles.Columns.Add("VENDEDOR", Type.GetType("System.String"))
            dtdetalles.Columns.Add("DIAS", Type.GetType("System.Int32"))
            dtdetalles.Columns.Add("DIAS_GENERAL", Type.GetType("System.Int32"))
            dtdetalles.Columns.Add("VENDEDOR_SOLICITANTE", Type.GetType("System.String"))
            dgv_Lista.DataSource = Nothing
            dgv_Lista.DataSource = dtdetalles

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Clientes(ByVal _codigo_vendedor As String, ByVal _opcion As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor
            GenerarColummnaDataTable()
            clienteBL = New ClsNegocio.CUSTOMER
            dtv = New DataView
            dtdetalles = clienteBL.get_Clientes_mt_Oportunidad_Cliente(_codigo_vendedor, _opcion)
            If dtdetalles.Rows.Count() <> 0 Then
                dtv = dtdetalles.DefaultView
                dgv_Lista.DataSource = dtv
                dgv_Lista.Columns("Sel").Visible = False
                dgv_Lista.Columns("CODIGO").Width = 150
                dgv_Lista.Columns("DESCRIPCION").Width = 400
                dgv_Lista.Columns("RUC").Visible = False
                dgv_Lista.Columns("VENDEDOR").Width = 220
                'dgv_Lista.Columns("VENDEDOR").Frozen = True
                dgv_Lista.Columns("FECHA_CREACION").Width = 100
                dgv_Lista.Columns("VENDEDOR_SOLICITANTE").Width = 220
                dgv_Lista.Columns("DIAS").Width = 130
                dgv_Lista.Columns("DIAS_GENERAL").Width = 130

                dgv_Lista.Columns("ULTIMA_COTIZACION").Width = 130
                dgv_Lista.Columns("ULTIMA_COTIZACION_FECHA").Width = 100
                dgv_Lista.Columns("NRO_COTIZACIONES").Width = 150
                dgv_Lista.Columns("NRO_COTIZACIONES_APROBADOS").Width = 150
                dgv_Lista.Columns("TOTAL_VENTAS").Width = 100
                dgv_Lista.Columns("LINEA_CREDITO").Width = 150

                dgv_Lista.Columns("VENDEDOR").HeaderText = "VENDEDOR ASIGNADO"
                dgv_Lista.Columns("FECHA_CREACION").HeaderText = "FECHA DE CREACIÓN"
                dgv_Lista.Columns("VENDEDOR_SOLICITANTE").Visible = False 'HeaderText = "VENDEDOR SOLICITANTE"
                dgv_Lista.Columns("DIAS").HeaderText = "# DIAS SIN ATENCION POR VENDEDOR"
                dgv_Lista.Columns("DIAS_GENERAL").Visible = False 'HeaderText = "# DIAS SIN ATENCION GENERAL"
                dgv_Lista.Columns("ESTADO_GOC").Visible = False

                dgv_Lista.Columns("ULTIMA_COTIZACION").HeaderText = "ULTIMA COTIZACION EMITIDA"
                dgv_Lista.Columns("ULTIMA_COTIZACION_FECHA").HeaderText = "FECHA ULTIMA COTIZACION EMITIDA"
                dgv_Lista.Columns("NRO_COTIZACIONES").Visible = False 'HeaderText = "NRO. DE COTIZACIONES TOTALES"
                dgv_Lista.Columns("NRO_COTIZACIONES_APROBADOS").Visible = False 'HeaderText = "NRO. DE COTIZACIONES APROBADAS"
                dgv_Lista.Columns("TOTAL_VENTAS").Visible = False 'HeaderText = " MONTO TOTAL VENDIDO"
                dgv_Lista.Columns("LINEA_CREDITO").Visible = False 'HeaderText = "LINEA DE CREDITO (PROY. DE VENTAS)"
                dgv_Lista.Columns("TOTAL_VENTAS").Visible = False 'Visible = bol_adm

                dgv_Lista.Columns("TOTAL_VENTAS").DefaultCellStyle.Format = "N0"
                dgv_Lista.Columns("LINEA_CREDITO").DefaultCellStyle.Format = "N0"
                dgv_Lista.Columns("TOTAL_VENTAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv_Lista.Columns("LINEA_CREDITO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                STRorden = dgv_Lista.Columns("CODIGO").Name & "+" & dgv_Lista.Columns("DESCRIPCION").Name & "+" & dgv_Lista.Columns("RUC").Name & "+" & dgv_Lista.Columns("VENDEDOR").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

                'For i As Integer = 0 To dgv_Lista.Columns.Count - 1
                '    dgv_Lista.Columns(i).ReadOnly = True
                'Next
                'dgv_Lista.Columns("Sel").ReadOnly = False

                Formatea_grilla(dgv_Lista)

                clienteBL = Nothing
            End If
            'If dgv_Lista.RowCount > 0 Then
            '    dgv_Lista.ContextMenuStrip = cmsOpciones
            'End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ayuda_Vendedor(ByVal _cod As TextBox, ByVal _des As TextBox)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_SALES_REP"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Vendedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _cod.Text = String.Empty
                _des.Text = String.Empty
                _cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                _des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                _cod.Focus()
                'Me.Cursor = Cursors.Default
            End If
            frm.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

   

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)

        tc_tipos.SelectedIndex = 0
        'Cargar_Clientes()
    End Sub


    Private Sub dgv_Lista_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Lista.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim STRFactura As String = String.Empty
            With dgv_Lista
                Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If hti.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = _
                    .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                End If

            End With
        End If
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub


    

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub



    Private Sub dgv_Lista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Lista.CellContentDoubleClick
        Call btn_Editar_Click(sender, e)
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
    End Sub



    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_tipos.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        Select Case tc_tipos.SelectedIndex
            Case 0
                tc_tipos.SelectedIndex = indice + 1
            Case 1
                tc_tipos.SelectedIndex = indice - 1
        End Select
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_solicitar_cliente.Enabled = False
            btn_inactivar_clientes.Enabled = False
            btn_reporte.Enabled = False
            btn_grabar.Enabled = True
            btn_Editar.Enabled = False
            btn_confirmar_sol_cliente.Enabled = False
            btn_cancelar.Enabled = True
            btn_mostrar_cli_nuevos.Enabled = False
        Else
            btn_Nuevo.Enabled = True
            btn_solicitar_cliente.Enabled = True
            btn_inactivar_clientes.Enabled = True
            btn_reporte.Enabled = True
            btn_grabar.Enabled = False
            btn_Editar.Enabled = True
            btn_confirmar_sol_cliente.Enabled = True
            btn_cancelar.Enabled = False
            btn_mostrar_cli_nuevos.Enabled = True
        End If
    End Sub


    Private Sub btn_solicitar_cliente_Click(sender As Object, e As EventArgs) Handles btn_solicitar_cliente.Click

    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        For i As Integer = 0 To dgv_Lista.Rows.Count - 1
            dgv_Lista.Rows(i).Cells("SEL").Value = chk_todos.Checked
        Next
        dgv_Lista.Refresh()
    End Sub

    Private Sub btn_confirmar_sol_cliente_Click(sender As Object, e As EventArgs) Handles btn_confirmar_sol_cliente.Click
        
    End Sub


    Private Sub txt_cod_vendedor_c_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_vendedor_c.TextChanged
        If txt_cod_vendedor_c.Text = "" Then txt_des_vendedor_c.Text = ""
    End Sub

    Private Sub txt_cod_vendedor_c_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vendedor_c.MouseDoubleClick
        Ayuda_Vendedor(txt_cod_vendedor_c, txt_des_vendedor_c)
    End Sub

    Private Sub txt_cod_vendedor_c_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vendedor_c.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txt_cod_vendedor_c, txt_des_vendedor_c)
        ElseIf e.KeyCode = Keys.Enter Then
            If txt_cod_vendedor_c.Text = "" Then
                Ayuda_Vendedor(txt_cod_vendedor_c, txt_des_vendedor_c)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Call Cargar_Clientes(txt_cod_vendedor_c.Text, cbo_dias_sin_atencion.SelectedIndex)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbo_dias_sin_atencion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_dias_sin_atencion.SelectedIndexChanged
        Call Cargar_Clientes(txt_cod_vendedor_c.Text, cbo_dias_sin_atencion.SelectedIndex)
    End Sub

    


    Private Sub btn_mostrar_cli_nuevos_Click(sender As Object, e As EventArgs) Handles btn_mostrar_cli_nuevos.Click
        
    End Sub


    Private Sub btn_inactivar_clientes_Click(sender As Object, e As EventArgs) Handles btn_inactivar_clientes.Click
        
    End Sub

    Private Sub btn_exportar_cliente_Click(sender As Object, e As EventArgs) Handles btn_exportar_cliente.Click
        
    End Sub

    Private Sub btn_aprobar_cliente_Click(sender As Object, e As EventArgs)

    End Sub
End Class