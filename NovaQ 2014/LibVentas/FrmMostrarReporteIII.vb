Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing

Public Class FrmMostrarReporteIII
    Dim frm_ayuda As frmAyudaVar

    Public opcion As String = String.Empty
    Public TituloReporte As String = String.Empty
    Public cadena As String = String.Empty
    Public FlagDetalle As Boolean = True
    Dim dtProdustos As DataTable
    Dim dtDocumentos As DataTable
    Dim dt_tmp As DataTable



    Private Sub MostrarReporte(ByVal _opcion As String, Optional ByVal _fechaInicial As String = "", Optional ByVal _fechaFinal As String = "", _
                               Optional ByVal _Filtro As String = "", Optional ByVal _TipoReporte As Integer = 0, _
                               Optional ByVal _cod_producto As String = "", Optional ByVal _lot_producto As String = "", Optional ByVal _num_documento As String = "")

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim opt_dos As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case _opcion
                Case "Reporte6"
                    NombreStore = "DOC_PENDIENTES_X_CLIENTES"
                    dt_tmp = New DataTable("Reporte6")
                    If rbtentregados.Checked = True Then
                        opt_dos = "1"
                    ElseIf rbtpendientes.Checked = True Then
                        opt_dos = "2"
                    ElseIf rbtambos.Checked = True Then
                        opt_dos = "0"
                    End If
                    dt_tmp = reporteBL.Get_ImprimirReporteII(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _TipoReporte, _cod_producto, _
                                                             _lot_producto, _num_documento, opt_dos)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_pendiente_cliente.rpt", dt_tmp, "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
                Case "Reporte99"
                    NombreStore = "DOC_PENDIENTES_X_CLIENTES_REP_MEDICOS"
                    dt_tmp = New DataTable("Reporte99")
                    If rbtentregados.Checked = True Then
                        opt_dos = "1"
                    ElseIf rbtpendientes.Checked = True Then
                        opt_dos = "2"
                    ElseIf rbtambos.Checked = True Then
                        opt_dos = "0"
                    End If
                    dt_tmp = reporteBL.Get_ImprimirReporteII(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _TipoReporte, _cod_producto, _
                                                             _lot_producto, _num_documento, opt_dos)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_pendiente_cliente_rep_medicos.rpt", dt_tmp, "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
                    End If
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Sub MostrarDatos()
        Try
            Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
            dtDocumentos = New DataTable
            Dim nombreStore As String = String.Empty
            Dim Filtro As String = String.Empty
            '-----Detalles
            Dim fecha_Inicial As String = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            Dim fecha_Final As String = dtpfechaFin.Value.ToString("dd/MM/yyyy")

            Filtro = txtFiltro.Text
            If Filtro = String.Empty Then Exit Sub

            If rbdocumento.Checked = True Then
                nombreStore = "ALM_SP_S_WAREHOUSE_DOC_REP_MEDICOS"
            ElseIf rbproducto.Checked = True Then
                nombreStore = "ALM_SP_S_WAREHOUSE_PROD_REP_MEDICO"
            End If

            If rbtodos.Checked = True Then
                dgvdatos.DataSource = Nothing
                Exit Sub
            End If
            dtDocumentos = reporteBL.Get_WAREHOUSE(nombreStore, fecha_Inicial, fecha_Final, Filtro)
            dgvdatos.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvdatos.DataSource = dtDocumentos
                dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvdatos.AutoResizeColumns()
            Else
                dgvdatos.DataSource = dtDocumentos
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BusquedasAyudas(ByVal tituloForm As String, ByVal Sql As String)
        If Sql = String.Empty Then Exit Sub
        frm_ayuda = New frmAyudaVar
        With frm_ayuda
            .Titulo = tituloForm
            .TipoAyuda = frmAyudaVar.STipoAyuda.Reportes
            .CadenaSql = Sql
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                txtFiltro.Text = .Data_Matriz.Rows(0).Item(0)
                lbldescripcion.Text = .Data_Matriz.Rows(0).Item(1)
            End If
            frm_ayuda.Close()
        End With
    End Sub

    Private Sub OpcionBusquedaReportes(ByVal opcion As String)
        TituloReporte = String.Empty
        cadena = String.Empty
        Select Case opcion
            Case "Reporte6"
                TituloReporte = "Reporte pendientes por Cobrar por Cliente"
                cadena = "SELECT ID as [Codigo], NAME as [Descripcion]  FROM CUSTOMER"
                If cadena = String.Empty Then Exit Sub
                frm_ayuda = New frmAyudaVar
                With frm_ayuda
                    .Titulo = TituloReporte
                    .TipoAyuda = frmAyudaVar.STipoAyuda.Reportes
                    .CadenaSql = cadena
                    .ShowDialog()
                    If .Data_Matriz.Rows.Count > 0 Then
                        txtFiltro.Text = .Data_Matriz.Rows(0).Item(0)
                        lbldescripcion.Text = .Data_Matriz.Rows(0).Item(1)
                        MostrarDatos()
                    End If
                    frm_ayuda.Close()
                End With
            Case "Reporte99"
                TituloReporte = "Lista de Vendedores"
                cadena = "SELECT ID as [Codigo], NAME as [Descripcion]  FROM CUSTOMER"
                If cadena = String.Empty Then Exit Sub
                frm_ayuda = New frmAyudaVar
                With frm_ayuda
                    .Titulo = TituloReporte
                    .TipoAyuda = frmAyudaVar.STipoAyuda.Reportes
                    .CadenaSql = cadena
                    .ShowDialog()
                    If .Data_Matriz.Rows.Count > 0 Then
                        txtFiltro.Text = .Data_Matriz.Rows(0).Item(0)
                        lbldescripcion.Text = .Data_Matriz.Rows(0).Item(1)
                        MostrarDatos()
                    End If
                    frm_ayuda.Close()
                End With
        End Select
    End Sub

    Public Sub LimpiarControles(ByVal controles As Control)
        For Each ctrl As Control In controles.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = String.Empty
            ElseIf TypeOf (ctrl) Is Label Then
                ctrl.Text = String.Empty
            ElseIf TypeOf (ctrl) Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                chk.Checked = True
            End If
        Next
    End Sub

    Private Sub FrmMostrarReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        LimpiarControles(GroupBox4)
        Me.Hide()
    End Sub
    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, ByRef Filtro As String, _
                                  ByRef tipo_Reporte As Integer, ByRef cod_producto As String, ByRef lote_producto As String, _
                                  ByRef numero_documento As String) As Boolean

        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            '--
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            ' -------------
            If txtFiltro.Text = String.Empty Then
                MsgBox("Debe seleccionar un Rep. Medico para poder generar el reporte.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
            Filtro = txtFiltro.Text
            ' --Tipo
            If rbtodos.Checked = True Then
                tipo_Reporte = 1
            ElseIf rbindividual.Checked = True Then
                tipo_Reporte = 2
            End If
            If rbdocumento.Checked = True And rbindividual.Checked = True Then
                '----
                If dgvdatos.CurrentRow Is Nothing Then
                    MsgBox("Se encuentra en modo Consulta Individual es necesario seleccionar al menos un registro, para continuar.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
                cod_producto = dgvdatos.Item(1, dgvdatos.CurrentRow.Index).Value
                lote_producto = ""
                numero_documento = ""
            ElseIf rbproducto.Checked = True And rbindividual.Checked = True Then
                If dgvdatos.CurrentRow Is Nothing Then
                    MsgBox("Se encuentra en modo Consulta Individual es necesario seleccionar al menos un registro, para continuar.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
                '------
                cod_producto = dgvdatos.Item(0, dgvdatos.CurrentRow.Index).Value
                lote_producto = dgvdatos.Item(2, dgvdatos.CurrentRow.Index).Value
                numero_documento = dgvdatos.Item(4, dgvdatos.CurrentRow.Index).Value

                If lote_producto = String.Empty Then
                    tipo_Reporte = 4
                ElseIf lote_producto <> String.Empty Then
                    tipo_Reporte = 3
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs)
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_filtro As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim Ref_cod_producto As String = String.Empty
        Dim Ref_lote_producto As String = String.Empty
        Dim Refnumero_documento As String = String.Empty


        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Ref_filtro, Reftipo_Reporte, Ref_cod_producto, Ref_lote_producto, Refnumero_documento) = False Then Exit Sub
        ' -----Mostrando el Reporte
        MostrarReporte(opcion, Ref_fecIni, Ref_fecFin, Ref_filtro, Reftipo_Reporte, Ref_cod_producto, Ref_lote_producto, Refnumero_documento)
    End Sub

    Private Sub txtFiltro_DoubleClick(sender As Object, e As EventArgs) Handles txtFiltro.DoubleClick
        OpcionBusquedaReportes(opcion)
    End Sub
    Private Sub rbproducto_Click(sender As Object, e As EventArgs) Handles rbproducto.Click
        MostrarDatos()
    End Sub

    Private Sub rbdocumento_Click(sender As Object, e As EventArgs) Handles rbdocumento.Click
        MostrarDatos()
    End Sub
    Private Sub rbindividual_Click(sender As Object, e As EventArgs) Handles rbindividual.Click
        MostrarDatos()
    End Sub
    Private Sub rbtodos_Click(sender As Object, e As EventArgs) Handles rbtodos.Click
        Me.dgvdatos.DataSource = Nothing
        Me.dgvdatos.ReadOnly = True
    End Sub
    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.F1 Then
            OpcionBusquedaReportes(opcion)
        End If
    End Sub

    Private Sub dtpfechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaFin.ValueChanged
        MostrarDatos()
    End Sub

    Private Sub dtpfechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.ValueChanged
        MostrarDatos()
    End Sub
    Private Sub btnMostrar_Click_1(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_filtro As String = String.Empty
        Dim Reftipo_Reporte As Integer = 0
        Dim Ref_cod_producto As String = String.Empty
        Dim Ref_lote_producto As String = String.Empty
        Dim Refnumero_documento As String = String.Empty


        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Ref_filtro, Reftipo_Reporte, Ref_cod_producto, Ref_lote_producto, Refnumero_documento) = False Then Exit Sub
        ' -----Mostrando el Reporte
        MostrarReporte(opcion, Ref_fecIni, Ref_fecFin, Ref_filtro, Reftipo_Reporte, Ref_cod_producto, Ref_lote_producto, Refnumero_documento)
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        LimpiarControles(GroupBox4)
        Me.Hide()
    End Sub
End Class