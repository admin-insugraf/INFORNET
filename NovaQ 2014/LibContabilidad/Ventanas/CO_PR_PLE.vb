Imports LibComunVar
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Shared.TableLogOnInfos
Imports CrystalDecisions.Shared.ConnectionInfo
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Specialized
Imports LibConexion
Imports System.IO
Public Class CO_PR_PLE
    Dim ClsasientoBl As ClsOperaciones.Asiento_Contable
    Private mySetting As NameValueCollection
    Dim ConnectionCR As New ConnectionInfo
    Private ClsVarComun As LibComunVar.ClsVarComun
    Private ClsCnx As LibConexion.ClsData
    Private Sub CO_PR_PLE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfecha.Focus()
    End Sub
    Public Sub Cargar_Meses_en_Combo(cmb As System.Windows.Forms.ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("ENERO")
        cmb.Items.Add("FEBRERO")
        cmb.Items.Add("MARZO")
        cmb.Items.Add("ABRIL")
        cmb.Items.Add("MAYO")
        cmb.Items.Add("JUNIO")
        cmb.Items.Add("JULIO")
        cmb.Items.Add("AGOSTO")
        cmb.Items.Add("SEPTIEMBRE")
        cmb.Items.Add("OCTUBRE")
        cmb.Items.Add("NOVIEMBRE")
        cmb.Items.Add("DICIEMBRE")
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Generar_Archivos_ple()

        If chkregcompras.Checked Then Call Generar_Archivo_Compras()
        If chkregcompras_sire.Checked Then Call Generar_Archivo_Compras_Sire()
        If chkregventas.Checked Then Call Generar_Archivo_Ventas()
        If chkregventas_sire.Checked Then Call Generar_Archivo_Ventas_Sire()
        If chkdiario.Checked Then Call Generar_Archivo_Libro_Diario()
        If chkmayor.Checked Then Call Generar_Archivo_Libro_Mayor()
        If chkplancuentas.Checked Then Call Generar_Archivo_PlanCuentas()
        If chkregcompras_02.Checked Then Call Generar_Archivo_Compras_02()
        If chkregcompras_02_sire.Checked Then Call Generar_Archivo_Compras_02_SIRE()
        If chkdaot_costos.Checked Or chkdaot_ingresos.Checked Then Call Generar_Archivo_DAOT()
        If rdb_retenciones.Checked Then Call Generar_Archivo_Comp_Retenciones()
        If rdb_percepcion.Checked Then Call Generar_Archivo_Comp_Percepcion()
        If rdb_4ta_categoria.Checked Then Call Generar_Archivo_Prestador_Servicios_4ta()
        MsgBox("Proceso generado correctamente!", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub Generar_Archivo_Balance_Compro()
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        'ClsasientoBl.get_BalCom_Pdt(une_Ayo.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        ClsasientoBl = Nothing
    End Sub
    Private Function RutaReportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
    End Function

    Private Sub Generar_Archivo_Comp_Retenciones()
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_Comp_Retencion(dtpfecha.Value.Year, dtpfecha.Value.Month, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
    End Sub

    Private Sub Generar_Archivo_Comp_Percepcion()
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_Comp_Percepcion(dtpfecha.Value.Year, dtpfecha.Value.Month, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
    End Sub

    Private Sub Generar_Archivo_Prestador_Servicios_4ta()
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_Prestador_Servicios_4ta(dtpfecha.Value.Year, dtpfecha.Value.Month, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
    End Sub

    Private Sub Generar_Archivo_DAOT()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_DAOT(dtpfecha.Value.Year.ToString, IIf(chkdaot_costos.Checked, 1, 2), txtRuta.Text.Trim, CDbl(txt_tope.Text))
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Compras_02()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_RegCompras_No_Domiciliados(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Compras_02_SIRE()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_RegCompras_No_Domiciliados_SIRE(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Compras()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        Dim _FECHA_INICIO As String, _FECHA_FIN As String, fecha_puente As String
        fecha_puente = dtpfecha.Value.AddYears(-1)
        _FECHA_INICIO = ModBas.Primer_Dia_Mes(fecha_puente)
        _FECHA_FIN = ModBas.Ultimo_Dia_Mes(dtpfecha.Value.ToString("dd/MM/yyyy"))

        ClsasientoBl.get_PLE_RegCompras(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim, _FECHA_INICIO, _FECHA_FIN)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Compras_Sire()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        Dim _FECHA_INICIO As String, _FECHA_FIN As String, fecha_puente As String
        fecha_puente = dtpfecha.Value.AddYears(-1)
        _FECHA_INICIO = ModBas.Primer_Dia_Mes(fecha_puente)
        _FECHA_FIN = ModBas.Ultimo_Dia_Mes(dtpfecha.Value.ToString("dd/MM/yyyy"))

        ClsasientoBl.get_PLE_RegCompras_SIRE(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim, _FECHA_INICIO, _FECHA_FIN)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Ventas()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_RegVentas(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Ventas_Sire()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_RegVentas_Sire(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Libro_Diario()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_Diario(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_PlanCuentas()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_PlanCuentas(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month, ModBas.Ultimo_Dia_Mes(dtpfecha.Value.ToString("dd/MM/yyyy")).Day.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Generar_Archivo_Libro_Mayor()
        Me.Cursor = Cursors.WaitCursor
        ClsasientoBl = New ClsOperaciones.Asiento_Contable
        ClsasientoBl.get_PLE_Mayor(dtpfecha.Value.Year.ToString, dtpfecha.Value.Month.ToString, txtRuta.Text.Trim)
        ClsasientoBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub
    'Private Sub Tool_Abrir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Abrir.Click
    '    Process.Start("explorer.exe", gStr_RutaRep & "\PLE")
    'End Sub

    Private Sub tool_nuevo_Click(sender As Object, e As EventArgs) Handles tool_nuevo.Click
        If txtRuta.Text.Trim = "" Then
            MsgBox("Debe elegir una ruta donde se guardara el archivo!!!", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        Call Generar_Archivos_ple()
    End Sub

    Private Sub dtpfecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkregcompras.Focus()
        End If
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString
        End If
    End Sub
End Class
