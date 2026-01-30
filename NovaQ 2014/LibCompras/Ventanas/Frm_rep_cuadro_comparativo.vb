Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Public Class Frm_rep_cuadro_comparativo
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub MostrandoSolicitudes()
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                Exit Sub
            End If
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtSolic As New DataTable
            dtSolic = clsBusquedaBl.ListaCotizaciones(dtpfechaInicio.Value.ToShortDateString, dtpfechaFin.Value.ToShortDateString)
            If dtSolic.Rows.Count() <> 0 Then
                chklstsolicitudes.Items.Clear()
                For i As Integer = 0 To dtSolic.Rows.Count() - 1
                    chklstsolicitudes.Items.Add(dtSolic.Rows(i).Item("Solicitud").ToString)
                Next
                chklstsolicitudes.SelectedIndex = 1
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub FrmRegVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Moneda()
        dtpfechaInicio.Select()
        MostrandoSolicitudes()
    End Sub


    Private Sub Cargar_Moneda()
        Try
            Dim monedaBL As ClsOperaciones.CURRENCY_TYPE
            monedaBL = New ClsOperaciones.CURRENCY_TYPE
            cbomoneda.DataSource = monedaBL.get_TiposCambio()
            cbomoneda.ValueMember = "CODIGO"
            cbomoneda.DisplayMember = "DESCRIPCION"
            monedaBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarReporte()
    End Sub

    Private Sub MostrarReporte()
        If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpfechaInicio.Focus()
            Exit Sub
        End If
        reporteBL = New ClsBuscar
        crystalBL = New LibReportes.ClsReporte
        dtImprimir = New DataTable("cuadro_comparativo")

        Dim Id_Solicitante As String = String.Empty
        Dim i As Integer = 0
        Try
            Me.Cursor = Cursors.WaitCursor
            Do While i <= chklstsolicitudes.CheckedItems.Count - 1
                Id_Solicitante = Id_Solicitante & """" & TraerCodigo(chklstsolicitudes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If Id_Solicitante.Length() <> 0 Then
                Id_Solicitante = Mid(Id_Solicitante, 1, Id_Solicitante.Length - 1)
            End If
            dtImprimir = reporteBL.EjecutarReporteCompras_Cuadro_comparativo(Id_Solicitante, dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"))
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_compras_cuadro_comparativo.rpt", "", "", "", "@SOLICITANTE;" & Id_Solicitante, _
                                           "@FECINI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), "@FECFIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                           "xMoneda;" & cbomoneda.SelectedValue.ToString, "TasaCamb;" & LibComunVar.ClsVarComun.TCVenta)
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub
 


    Private Sub dtpfechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaInicio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub checkSolicitudes_CheckedChanged(sender As Object, e As EventArgs) Handles checkSolicitudes.CheckedChanged
        chklstsolicitudes.Enabled = Not checkSolicitudes.Checked
        Dim i As Integer = 0
        Do While i <= chklstsolicitudes.Items.Count - 1
            chklstsolicitudes.SetItemChecked(i, checkSolicitudes.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class