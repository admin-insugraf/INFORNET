Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes
Public Class Frm_Rep_Estados_Letras
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Private Sub Frm_Rep_Estados_Letras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub txtClienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtClienteInicial.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub
    Private Sub Ayuda_Vendedor()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COB_SP_S_ESTADOS_LETRAS_II"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE ESTADOS DE LETRAS"
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
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If checkVendedor.Checked = False Then
                If txtClienteInicial.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Estado de la Letra.", MsgBoxStyle.Exclamation)
                    txtClienteInicial.Focus()
                    estado = False
                End If
            End If

            If chk_todos_clientes.Checked = False Then
                If txt_cod_cliente.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Exclamation)
                    txt_cod_cliente.Focus()
                    estado = False
                End If
            End If

            If chk_todas_letras.Checked = False Then
                If txt_num_letra.Text = String.Empty Then
                    MsgBox("Debe ingresar un número de Letra.", MsgBoxStyle.Exclamation)
                    txt_num_letra.Focus()
                    estado = False
                End If
            End If

            If rdb_emision.Checked = False And rdb_vcto.Checked = False Then
                MsgBox("Debe elegir un tipo de Fecha para las Letras", MsgBoxStyle.Exclamation)
                estado = False
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
            dtImprimir = New DataTable("Reporte7")
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            dtImprimir = reporteBL.Get_Rep_Estados_de_Letras(txtClienteInicial.Text.Trim, dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txt_cod_cliente.Text.Trim, txt_num_letra.Text.Trim, IIf(rdb_emision.Checked, "1", "2"))
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("REP_ESTADOS_LETRAS.rpt", dtImprimir, "", "", "XVEN1;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "XVEN2;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chk_todos_clientes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_clientes.CheckedChanged
        txt_cod_cliente.Text = String.Empty
        txt_desc_cliente.Text = String.Empty
        txt_cod_cliente.Enabled = Not chk_todos_clientes.Checked
        txt_desc_cliente.Enabled = Not chk_todos_clientes.Checked
    End Sub

    Private Sub txt_cod_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Cliente()
    End Sub

    Private Sub txt_cod_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente.Text.Trim = "" Then
                Ayuda_Cliente()
            Else
                txt_num_letra.Focus()
            End If
        End If
    End Sub
    Private Sub Ayuda_Cliente()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_CUSTOMER"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE CLIENTES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_cliente.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_desc_cliente.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_todas_letras_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todas_letras.CheckedChanged
        txt_num_letra.Text = String.Empty
        txt_num_letra.Enabled = Not chk_todas_letras.Checked
    End Sub

    Private Sub rdb_emision_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_emision.CheckedChanged
        If rdb_emision.Checked Then
            GroupBox4.Text = "Rango de Fechas de Emisión de Letras"
        End If
    End Sub

    Private Sub rdb_vcto_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_vcto.CheckedChanged
        If rdb_vcto.Checked Then
            GroupBox4.Text = "Rango de Fechas de Vencimiento de Letras"
        End If
    End Sub
End Class