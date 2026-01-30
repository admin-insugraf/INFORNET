Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes
Public Class Frm_Canje_Letras
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Private Sub Frm_Canje_Letras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        chk_gerencial.Checked = False
    End Sub

    Private Sub txtClienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClienteInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub
    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_CUSTOMER"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CLIENTES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtClienteInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
                txtClienteInicialDesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtClienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtClienteInicial.Text.Trim = "" Then
                Ayuda_Vendedor()
            Else
                txt_cod_estado.Focus()
            End If
        End If
    End Sub

    Private Sub checkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedor.CheckedChanged
        txtClienteInicial.Text = String.Empty
        txtClienteInicialDesc.Text = String.Empty
        txtClienteInicial.Enabled = Not checkVendedor.Checked
        txtClienteInicialDesc.Enabled = Not checkVendedor.Checked
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Validaciones() = False Then Exit Sub
        ImprimirReporte()
    End Sub
    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If checkVendedor.Checked = False Then
                If txtClienteInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Exclamation)
                    txtClienteInicial.Focus()
                    estado = False
                End If
            End If
            If CheckBox1.Checked = False Then
                If txt_cod_estado.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Estado de los Canjes de Letras.", MsgBoxStyle.Exclamation)
                    txt_cod_estado.Focus()
                    estado = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirReporte()

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dtDatosCompany As DataTable
            'NombreStore = "DOC_PENDIENTES_X_CLIENTES"
            dtImprimir = New DataTable("Reporte6")
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            dtImprimir = reporteBL.Get_Canje_de_Letras(txtClienteInicial.Text.Trim, dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                                           txt_cod_estado.Text.Trim, IIf(chk_gerencial.Checked, "S", "N"))
            If dtImprimir.Rows.Count() <> 0 Then
                If chk_gerencial.Checked = False Then
                    crystalBL.Muestra_Reporte("REP_CANJE_LETRAS.rpt", dtImprimir, "", "", "XVEN1;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "XVEN2;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                              "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                Else
                    crystalBL.Muestra_Reporte("REP_CANJE_LETRAS_GER.rpt", dtImprimir, "", "", "XVEN1;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                              "XVEN2;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                              "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                End If
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt_cod_estado_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_estado.MouseDoubleClick
        Ayuda_Estado()
    End Sub

    Private Sub txt_cod_estado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_estado.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Estado()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtClienteInicial.Text.Trim = "" Then
                Ayuda_Estado()
            Else
                txt_cod_estado.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Estado()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_ESTADOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE ESTADOS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_estado.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_desc_estado.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txt_cod_estado.Text = String.Empty
        txt_desc_estado.Text = String.Empty
        txt_cod_estado.Enabled = Not CheckBox1.Checked
        txt_desc_estado.Enabled = Not CheckBox1.Checked
    End Sub
End Class