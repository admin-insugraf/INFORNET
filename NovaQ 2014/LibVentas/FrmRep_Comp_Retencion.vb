Imports LibComunVar
Imports System.Windows.Forms
Public Class FrmRep_Comp_Retencion
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub FrmRep_Comp_Retencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim _cliente_inicial As String = String.Empty

        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin) = False Then Exit Sub
        Dim Flag_Todos As String = ""

        If checkDocumentos.Checked = True Then
            Flag_Todos = "SI"
        Else
            Flag_Todos = "NO"
            If txt_cod_cliente.Text = "" Then
                MsgBox("Seleccione un cliente.", MsgBoxStyle.Critical)
                txt_cod_cliente.Select()
                Exit Sub
            End If
        End If
        _cliente_inicial = txt_cod_cliente.Text

        MostrarReporte(Ref_fecIni, Ref_fecFin, _cliente_inicial, Flag_Todos)
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
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal cliente_inicial As String, ByVal todos As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarReporte_Retenciones_Cliente(FechaIni, FechaFin, cliente_inicial, todos)
            Dim Nombre_rep As String = ""

            Nombre_rep = "REP_RETENCIONES_CLIENTE.rpt"

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, dtImprimir, "", "", "@CUSTOMER_ID;" & cliente_inicial, _
                                          "@FECHA_INI;" & FechaIni, "@FECHA_FIN;" & FechaFin, _
                                          "@TODOS;" & todos, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub txtdocumentoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cliente(txt_cod_cliente, txt_des_cliente)
        End If
    End Sub

    Private Sub txtdocumentoInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Cliente(txt_cod_cliente, txt_des_cliente)
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

    Private Sub checkDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles checkDocumentos.CheckedChanged
        If checkDocumentos.Checked Then
            txt_cod_cliente.Text = ""
            txt_des_cliente.Text = ""
            txt_cod_cliente.Enabled = False
        Else
            txt_cod_cliente.Text = ""
            txt_des_cliente.Text = ""
            txt_cod_cliente.Enabled = True
            txt_cod_cliente.Focus()
        End If
    End Sub

End Class