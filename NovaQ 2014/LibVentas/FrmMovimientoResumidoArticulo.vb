Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmMovimientoResumidoArticulo
    Dim clsBusquedaBl As New ClsBuscar
    Dim dtAlmacen As New DataTable
    Dim reporteBL As LibVentas.ClsReporteGenerales.ReportesGerenciales
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtReporte As DataTable
    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(Seleccione una Clase de Articulo)"
            dtAlmacen.Rows.InsertAt(row, 0)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacenes.DataSource = dtAlmacen
                cboAlmacenes.DisplayMember = "DESCRIPCION"
                cboAlmacenes.ValueMember = "CODIGO"
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmMovimientoResumidoArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
    End Sub

    Private Sub MostrarReporte()
        Try
            'Seleccionando almacen

            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                Exit Try
            End If
            If cboAlmacenes.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Tipo de Articulo.", MsgBoxStyle.Information)
                cboAlmacenes.Focus()
                Exit Try
            End If

            reporteBL = New ClsReporteGenerales.ReportesGerenciales
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dtReporte = New DataTable
            Dim FechaIni As String = String.Empty
            Dim Fechafin As String = String.Empty
            FechaIni = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            Fechafin = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            dtReporte = reporteBL.EjecutaReporteMovimientoResumidoArticulo(FechaIni, Fechafin, cboAlmacenes.SelectedValue.ToString)
            If dtReporte.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Resumido_Articulo.rpt", dtReporte, "", "", "", "@FECHA_INI;" & FechaIni, "@FECHA_FIN;" & Fechafin, "@ALM;" & cboAlmacenes.Text)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
 

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MostrarReporte()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class