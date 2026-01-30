Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmRep_Gasto_Movilidad
    Dim reporteBL As LibVentas.ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmRep_Gasto_Movilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub checkClientes_CheckedChanged(sender As Object, e As EventArgs) Handles checkClientes.CheckedChanged
        If checkClientes.Checked = True Then
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteInicial.Enabled = False
        Else
            txtclienteInicial.Text = String.Empty
            txtclienteInicialDesc.Text = String.Empty
            txtclienteInicial.Enabled = True
        End If
    End Sub

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Proveedor(txtclienteInicial, txtclienteInicialDesc)
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Proveedor(txtclienteInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub Ayuda_Proveedor(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New libventas.frmBuscar
            Dim sql As String = String.Empty
            sql = "CCHICA_SP_S_PERSONAL"
            frm.CadenaConsulta = sql
            frm.Titulo = "Personal"
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
        MostrarReporte()
    End Sub
    Private Sub MostrarReporte()
        Try
            reporteBL = New LibVentas.ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarRep_Gastos_Movilidad(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), txtclienteInicial.Text.Trim)
            Dim Nombre_rep As String = ""
            Dim PERIODO As String = dtpfechaInicio.Text

            Nombre_rep = "REP_GASTOS_MOVILIDAD.rpt"
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, dtImprimir, "", "", _
                                          "@PERSONAL;" & txtclienteInicial.Text.Trim, _
                                          "@FECHA;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "PERIODO;" & PERIODO)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class