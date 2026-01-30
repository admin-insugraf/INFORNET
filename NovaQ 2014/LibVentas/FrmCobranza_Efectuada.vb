Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmCobranza_Efectuada
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dt_tmp As DataTable
    Dim dtDatosCompany As DataTable
    Dim _opcion As String = ""
    Dim STRorden As String = String.Empty
    Dim dtv As DataView
    Public GRUPO_COBRANZA As String

    Private Sub FrmCobranza_Efectuada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicio.Focus()
    End Sub

    Private Sub Ayuda_Cliente(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim _cliente_inicial As String = String.Empty
        Dim _cliente_final As String = String.Empty
        Dim _vendedor_inicial As String = String.Empty
        Dim _vendedor_final As String = String.Empty
        Dim _documento_inicial As String = String.Empty
        Dim _documento_final As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        Dim Filtro_1 As String = ""
        Dim Filtro_2 As String = ""


        If checkClientes.Checked = True Then
            Flag_Todos = "SI"
        Else
            Flag_Todos = "NO"
            If txtclienteInicial.Text = "" Then
                MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                txtclienteInicial.Select()
                Exit Sub
            End If
        End If
        _cliente_inicial = txtclienteInicial.Text
        _cliente_final = txtclienteInicial.Text
        _opcion = "1"


        MostrarReporte(Ref_fecIni, Ref_fecFin, Flag_Todos, _cliente_inicial, _cliente_final, _vendedor_inicial, _vendedor_final, _documento_inicial, _documento_final, _opcion)
    End Sub
    Private Function Validaciones(ByRef FechaIni As String, ByRef FechaFin As String) As Boolean
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
            If FechaIni = String.Empty Or FechaFin = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, ByVal vendedor_final As String, ByVal documento_inicial As String, ByVal documento_final As String, ByVal opcion As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""

            dtImprimir = reporteBL.EjecutarReporteCobranzaEfectuadaVendedor_Consulta(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final, vendedor_inicial, _
                                                                                     vendedor_final, documento_inicial, documento_final, opcion, GRUPO_COBRANZA)

            Nombre_rep = "REP_COBRANZAS_EFECTUADAS_CLIENTE.rpt"
            filtro_uno = txtclienteInicialDesc.Text
            filtro_dos = txtclienteInicialDesc.Text


            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, dtImprimir, "", "", "@FECHA_INICIAL;" & FechaIni, "@FECHA_FINAL;" & FechaFin, "@CLIENTE_INICIAL;" & cliente_inicial, _
                                          "@CLIENTE_FINAL;" & cliente_final, "@OPCION_TODOS;" & TODOS, "INICIO;" & filtro_uno, "FIN;" & filtro_dos, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarConsulta(ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal TODOS As String, ByVal cliente_inicial As String, ByVal cliente_final As String, ByVal vendedor_inicial As String, _
                                ByVal vendedor_final As String, ByVal documento_inicial As String, ByVal documento_final As String, ByVal opcion As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""
            STRorden = ""

            dtImprimir = reporteBL.Ejecutar_Cobranza_Efectuada(FechaIni, FechaFin, TODOS, cliente_inicial, cliente_final, vendedor_inicial, vendedor_final, documento_inicial, _
                                                               documento_final, opcion, GRUPO_COBRANZA)

            If dtImprimir.Rows.Count() <> 0 Then
                dtv = dtImprimir.DefaultView
                dgvCabecera.DataSource = dtv
                dgvCabecera.Columns("GRUPO").Visible = False
                dgvCabecera.Columns("AMOUNT").Visible = False
                dgvCabecera.Columns("SALES_ID").Visible = False
                dgvCabecera.Columns("BANK_ID").Visible = False
                dgvCabecera.Columns("BANK_DESCRIPTION").Visible = False
                dgvCabecera.Columns("REC_ID").Visible = False
                dgvCabecera.Columns("TRANS_TYPE").Visible = False
                dgvCabecera.Columns("ACCOUNT_BANK_ID").Visible = False
                dgvCabecera.Columns("BANCO_NOMBRE").Visible = False
                
                dgvCabecera.Columns("CUSTOMER_ID").Width = 100
                dgvCabecera.Columns("DOCUMENT_ID").Width = 80
                dgvCabecera.Columns("NUMBER_DOC").Width = 100
                dgvCabecera.Columns("DOC_DATE").Width = 80
                dgvCabecera.Columns("NAME").Width = 200
                dgvCabecera.Columns("ID").Width = 100
                dgvCabecera.Columns("DAT").Width = 80
                dgvCabecera.Columns("PAMOUNT").Width = 100
                dgvCabecera.Columns("CURRENCY_ID").Width = 80
                dgvCabecera.Columns("SELL_RATE").Width = 100
                dgvCabecera.Columns("DOC_REF").Width = 100
                dgvCabecera.Columns("NUM_REF").Width = 120
                dgvCabecera.Columns("DESCRIPTION").Width = 250
                dgvCabecera.Columns("COMMENT").Width = 250
                dgvCabecera.Columns("AMOUNT_ITF").Width = 100
                dgvCabecera.Columns("AMOUNT_COMISIONES").Width = 100
                dgvCabecera.Columns("AMOUNT_GASTOS_FINANCIEROS").Width = 100
                dgvCabecera.Columns("INGRESOS_POR_REDONDEO").Width = 100
                dgvCabecera.Columns("GASTOS_POR_REDONDEO").Width = 100

                dgvCabecera.Columns("PAMOUNT").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("PAMOUNT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("SELL_RATE").DefaultCellStyle.Format = "N3"
                dgvCabecera.Columns("SELL_RATE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("AMOUNT_ITF").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("AMOUNT_ITF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("AMOUNT_COMISIONES").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("AMOUNT_COMISIONES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("AMOUNT_GASTOS_FINANCIEROS").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("AMOUNT_GASTOS_FINANCIEROS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("INGRESOS_POR_REDONDEO").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("INGRESOS_POR_REDONDEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns("GASTOS_POR_REDONDEO").DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns("GASTOS_POR_REDONDEO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvCabecera.Columns("CUSTOMER_ID").DisplayIndex = 0
                dgvCabecera.Columns("NAME").DisplayIndex = 1
                dgvCabecera.Columns("ID").DisplayIndex = 2
                dgvCabecera.Columns("DAT").DisplayIndex = 3
                dgvCabecera.Columns("DOCUMENT_ID").DisplayIndex = 4
                dgvCabecera.Columns("NUMBER_DOC").DisplayIndex = 5
                dgvCabecera.Columns("DOC_DATE").DisplayIndex = 6
                dgvCabecera.Columns("PAMOUNT").DisplayIndex = 7
                dgvCabecera.Columns("CURRENCY_ID").DisplayIndex = 8
                dgvCabecera.Columns("SELL_RATE").DisplayIndex = 9
                dgvCabecera.Columns("DOC_REF").DisplayIndex = 10
                dgvCabecera.Columns("NUM_REF").DisplayIndex = 11
                dgvCabecera.Columns("DESCRIPTION").DisplayIndex = 12
                dgvCabecera.Columns("COMMENT").DisplayIndex = 13
                dgvCabecera.Columns("AMOUNT_ITF").DisplayIndex = 14
                dgvCabecera.Columns("AMOUNT_COMISIONES").DisplayIndex = 15
                dgvCabecera.Columns("AMOUNT_GASTOS_FINANCIEROS").DisplayIndex = 16
                dgvCabecera.Columns("INGRESOS_POR_REDONDEO").DisplayIndex = 17
                dgvCabecera.Columns("GASTOS_POR_REDONDEO").DisplayIndex = 18

                dgvCabecera.Columns("CUSTOMER_ID").HeaderText = "COD. CLIENTE"
                dgvCabecera.Columns("NAME").HeaderText = "CLIENTE"
                dgvCabecera.Columns("ID").HeaderText = "N° PLANILLA"
                dgvCabecera.Columns("DAT").HeaderText = "FECHA COBRO"
                dgvCabecera.Columns("DOCUMENT_ID").HeaderText = "TD"
                dgvCabecera.Columns("NUMBER_DOC").HeaderText = "N° DOCUMENTO"
                dgvCabecera.Columns("DOC_DATE").HeaderText = "FEC. VCTO"
                dgvCabecera.Columns("PAMOUNT").HeaderText = "MONTO"
                dgvCabecera.Columns("CURRENCY_ID").HeaderText = "MONEDA"
                dgvCabecera.Columns("SELL_RATE").HeaderText = "T. CAMBIO"
                dgvCabecera.Columns("DOC_REF").HeaderText = "TD REF"
                dgvCabecera.Columns("NUM_REF").HeaderText = "N° DOC. REF"
                dgvCabecera.Columns("DESCRIPTION").HeaderText = "CONCEPTO COBRO"
                dgvCabecera.Columns("COMMENT").HeaderText = "OBSERVACIONES"
                dgvCabecera.Columns("AMOUNT_ITF").HeaderText = "ITF"
                dgvCabecera.Columns("AMOUNT_COMISIONES").HeaderText = "COMISIONES"
                dgvCabecera.Columns("AMOUNT_GASTOS_FINANCIEROS").HeaderText = "GASTOS FINANCIEROS"
                dgvCabecera.Columns("INGRESOS_POR_REDONDEO").HeaderText = "ING X REDONDEO"
                dgvCabecera.Columns("GASTOS_POR_REDONDEO").HeaderText = "GASTOS X REDONDEO"

                STRorden = dgvCabecera.Columns("NAME").Name & "+" & dgvCabecera.Columns("NUMBER_DOC").Name & "+" & dgvCabecera.Columns("CUSTOMER_ID").Name
            Else
                dgvCabecera.DataSource = Nothing
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Public Sub blank()
        checkClientes.Checked = False
        txtclienteInicial.Text = ""
        txtclienteInicialDesc.Text = ""
    End Sub
    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        If checkClientes.Checked Then
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteInicial.Enabled = False
            txtclienteInicialDesc.Enabled = False
        Else
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteInicial.Enabled = True
            txtclienteInicialDesc.Enabled = True
        End If
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As System.Windows.forms.KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
        End If
        If e.KeyCode = Keys.Enter Then
            If txtclienteInicial.Text = "" Then
                Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
            Else
                btn_consultar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As System.Windows.forms.MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Cliente(txtclienteInicial, txtclienteInicialDesc)
    End Sub

    Private Sub dtpfechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpfechaFin.Focus()
        End If
    End Sub

    Private Sub dtpfechaFin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaFin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtclienteInicial.Focus()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim _cliente_inicial As String = String.Empty
        Dim _cliente_final As String = String.Empty
        Dim _vendedor_inicial As String = String.Empty
        Dim _vendedor_final As String = String.Empty
        Dim _documento_inicial As String = String.Empty
        Dim _documento_final As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        Dim Filtro_1 As String = ""
        Dim Filtro_2 As String = ""


        If checkClientes.Checked = True Then
            Flag_Todos = "SI"
        Else
            Flag_Todos = "NO"
            If txtclienteInicial.Text = "" Then
                MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                txtclienteInicial.Select()
                Exit Sub
            End If
        End If
        _cliente_inicial = txtclienteInicial.Text
        _opcion = "1"

        MostrarConsulta(Ref_fecIni, Ref_fecFin, Flag_Todos, _cliente_inicial, _cliente_final, _vendedor_inicial, _vendedor_final, _documento_inicial, _documento_final, _opcion)

        txtFiltro.Text = ""
        txtFiltro.Focus()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                Exit Sub
            Else
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("NAME").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("NUMBER_DOC").Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns("CUSTOMER_ID").Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns("NAME").Name & "+" & dgvCabecera.Columns("NUMBER_DOC").Name & "+" & dgvCabecera.Columns("CUSTOMER_ID").Name
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
        
    End Sub
End Class