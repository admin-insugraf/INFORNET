Imports System.Windows.Forms
Imports LibComunVar


Public Class FrmVentasMensualArticulo
    Dim clsBusquedasBL As ClsBuscar
    Dim dtDetalles As DataTable
    Public dt_tmp As DataTable

    Dim dtReporte As DataTable
    'Dim reporteBL As ClsReporteGenerales.ReportesGerenciales
    Dim crystalBL As LibReportes.ClsReporte


    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frmM.CadenaConsulta = sql
            frmM.Titulo = "Seleccion de Articulos"
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmVentasMensualArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes("01/01/" + CStr(Year(Date.Now)))
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes("01/12/" + CStr(Year(Date.Now)))
        CheckBox1.Checked = True
        chktodos.Checked = True
        rdb_resumido.Checked = True
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
    End Sub

    Private Sub txtinicioArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinicioArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
        End If
        If e.KeyCode = Keys.Enter Then
            If txtinicioArticulo.Text = "" Then
                BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
            End If
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim estado As Boolean = True
        Try

            If dtpfechaInicio.Value.Year <> dtpfechaFin.Value.Year Then
                MessageBox.Show("El rango de fechas no es correcto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                estado = False
                Exit Try
            End If

            If chktodos.Checked = False Then
                If txtinicioArticulo.Text = "" Then
                    MessageBox.Show("Debe elegir un articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtinicioArticulo.Focus()
                    estado = False
                    Exit Try
                End If
            End If

            If CheckBox1.Checked = False Then
                If txt_cod_cliente.Text = "" Then
                    MessageBox.Show("Debe elegir un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_cod_cliente.Focus()
                    estado = False
                    Exit Try
                End If
            End If

            clsBusquedasBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dt_tmp = New DataTable
            Dim query As String = String.Empty
            Dim fq As New LibContabilidad.ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty

            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            
            dt_tmp = clsBusquedasBL.EjecutaReporte_Precios_Anual(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                                                        dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                                                        txtinicioArticulo.Text.Trim, _
                                                                        txt_cod_cliente.Text.Trim, _
                                                                        IIf(rdb_resumido.Checked, "0", "1"))
            If dt_tmp.Rows.Count() <> 0 Then
                If rdb_resumido.Checked Then
                    crystalBL.Muestra_Reporte("rpt_Precios_Anual_Gerencia.rpt", dt_tmp, "", "", "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@PRODUCTO;" & txtinicioArticulo.Text.Trim, _
                                          "@CLIENTE;" & txt_cod_cliente.Text.Trim, _
                                          "ANIO;" & dtpfechaFin.Value.Year.ToString, _
                                          "CLIENTE;" & IIf(CheckBox1.Checked, "Cliente: Todos", "Cliente: " & txt_des_cliente.Text.Trim), _
                                          "pRuc;" & ruc, _
                                          "pRazon;" & razon)
                ElseIf rdb_detallado.Checked Then
                    crystalBL.Muestra_Reporte("rpt_Precios_Anual_Gerencia_detallado.rpt", dt_tmp, "", "", "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@PRODUCTO;" & txtinicioArticulo.Text.Trim, _
                                          "@CLIENTE;" & txt_cod_cliente.Text.Trim, _
                                          "ANIO;" & dtpfechaFin.Value.Year.ToString, _
                                          "pRuc;" & ruc, _
                                          "pRazon;" & razon)
                End If
                
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            estado = False
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub mtb_ayo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtinicioArticulo.Focus()
        End If
    End Sub

    Private Sub cboTipoReporte_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnMostrar_Click(sender, e)
        End If
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked Then
            txtinicioArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtinicioArticulo.Enabled = False
            txtdescripcionArticuloInicial.Enabled = False
        Else
            txtinicioArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtinicioArticulo.Enabled = True
            txtdescripcionArticuloInicial.Enabled = True
            txtinicioArticulo.Focus()
        End If
    End Sub

    Private Sub txt_cod_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txt_cod_cliente, txt_des_cliente)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente.Text = "" Then
                Ayuda_Cliente(txt_cod_cliente, txt_des_cliente)
            End If
        End If
    End Sub

    Private Sub Ayuda_Cliente(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_CUSTOMER"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CLIENTES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtDescripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Cliente(txt_cod_cliente, txt_des_cliente)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_cod_cliente.Text = String.Empty
            txt_des_cliente.Text = String.Empty
            txt_cod_cliente.Enabled = False
            txt_des_cliente.Enabled = False
        Else
            txt_cod_cliente.Text = String.Empty
            txt_des_cliente.Text = String.Empty
            txt_cod_cliente.Enabled = True
            txt_des_cliente.Enabled = True
            txt_cod_cliente.Focus()
        End If
    End Sub
End Class
