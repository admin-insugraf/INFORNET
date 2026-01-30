Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing

Public Class FrmMostrarReporte
    Dim frm_ayuda As frmAyudaVar

    Public opcion As String = String.Empty
    Public TituloReporte As String = String.Empty
    Public cadena As String = String.Empty
    Public FlagDetalle As Boolean = True
    Dim dt_tmp As DataTable
    Dim dt_ReporteProducto As DataTable

    Public Sub MostrarReporte(ByVal _opcion As String, Optional ByVal _fechaInicial As String = "", Optional ByVal _fechaFinal As String = "", _
                               Optional ByVal _Filtro As String = "", Optional ByVal _ActivadorGrupo As Integer = 0, _
                               Optional ByVal _TipoReporte As Integer = 0)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Dim TipoReportes As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case _opcion
                Case "Reporte1" '----
                    NombreStore = "SP_REP_X_VENDEDORES"
                    If _TipoReporte = 0 Then
                        TipoReportes = "rpt_VentasVendedorResumido.rpt"
                    ElseIf _TipoReporte = 1 Then
                        TipoReportes = "rpt_VentasVendedorDetallado.rpt"
                    End If
                    dt_tmp = New DataTable("Reporte1")
                    dt_tmp = reporteBL.Get_ImprimirReporte(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _ActivadorGrupo, _TipoReporte, _opcion)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte(TipoReportes, "", "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal, "@VENDEDOR;" & _Filtro, "@DANY;" & _ActivadorGrupo, "@TIPO;" & _TipoReporte)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                Case "Reporte2"
                    If _TipoReporte = 0 Then
                        TipoReportes = "rpt_VentasCliente.rpt"
                    ElseIf _TipoReporte = 1 Then
                        TipoReportes = "rpt_VentasCliente_detallado.rpt"
                    End If
                    NombreStore = "SP_REP_X_CLIENTE"
                    dt_tmp = New DataTable("Reporte2")
                    dt_tmp = reporteBL.Get_ImprimirReporte(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _ActivadorGrupo, _TipoReporte, _opcion)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte(TipoReportes, "", "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal, "@CLIENTE;" & _Filtro)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                Case "Reporte3"
                    TipoReportes = "rpt_ventas_Dia.rpt"
                    NombreStore = "SP_REP_VENTAS_DIA"
                    dt_tmp = New DataTable("Reporte3")
                    dt_tmp = reporteBL.Get_ImprimirReporte(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _ActivadorGrupo, _TipoReporte, _opcion)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte(TipoReportes, dt_tmp, "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                Case "Reporte4"
                    If _TipoReporte = 3 Then
                        TipoReportes = "rpt_Stock_valorizado.rpt"
                    ElseIf _TipoReporte = 4 Then
                        TipoReportes = "rpt_no_valorizado.rpt"
                    ElseIf _TipoReporte = 6 Then
                        TipoReportes = "rpt_no_valorizado_Productos_sin_Stock.rpt"
                        _ActivadorGrupo = 1
                    End If
                    NombreStore = "SP_REP_VENTAS_STOCK_VALORIZADO"
                    dt_tmp = New DataTable("Reporte4")
                    dt_tmp = reporteBL.Get_ImprimirReporte(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _ActivadorGrupo, _TipoReporte, _opcion)
                    If dt_tmp.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte(TipoReportes, dt_tmp, "", "", "")
                    Else
                        MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                Case "Reporte5"
                    If _TipoReporte = 0 Then
                        TipoReportes = "rpt_Ventas_Producto_Resumido.rpt"
                    ElseIf _TipoReporte = 1 Then
                        TipoReportes = "rpt_Ventas_Producto_Detallado.rpt"
                    ElseIf _TipoReporte = 2 Then
                        TipoReportes = "rpt_Ventas_Producto_vendedor.rpt"
                    ElseIf _TipoReporte = 5 Then
                        TipoReportes = "rpt_Ventas_Producto_resumido_sinValorizar.rpt"
                    End If
                    NombreStore = "SP_REP_X_PRODUCTOS"
                    dt_ReporteProducto = New DataTable("Rep_Productos")
                    dt_ReporteProducto = reporteBL.Get_ImprimirReporte(NombreStore, _fechaInicial, _fechaFinal, _Filtro, _ActivadorGrupo, _TipoReporte, _opcion)
                    If dt_ReporteProducto.Rows.Count() <> 0 Then
                        If _TipoReporte = 2 Then _TipoReporte = 1
                        crystalBL.Muestra_Reporte(TipoReportes, "", "", "", "@FECHA_INI;" & _fechaInicial, "@FECHA_FIN;" & _fechaFinal, "@PRODUCTO;" & _Filtro, "@DANY;" & _ActivadorGrupo, "@TIPO;" & _TipoReporte)
                    Else
                        MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
                    End If
                Case 4

            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
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

    Public Sub OpcionBusquedaReportes(ByVal opcion As String)
        TituloReporte = String.Empty
        cadena = String.Empty
        Select Case opcion
            Case "Reporte1"
                TituloReporte = "Reporte de Ventas por Vendedor"
                cadena = "SELECT ID, NAME , ADDR   FROM SALES_REP"
                BusquedasAyudas(TituloReporte, cadena)
            Case "Reporte2"
                TituloReporte = "Reporte de Ventas por Cliente"
                cadena = "SELECT ID, NAME , ADDR   FROM CUSTOMER"
                BusquedasAyudas(TituloReporte, cadena)
            Case "Reporte5"
                TituloReporte = "Reporte de Ventas por Producto"
                cadena = "SELECT ID,DESCRIPTION,NOMBRE_COMERCIAL, PRESS_COMERCIAL  FROM PART"
                BusquedasAyudas(TituloReporte, cadena)
            Case 4

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

    Public Sub AjustarTamaño(ByVal opcion As Boolean, ByVal Reporte As String)
        Select Case Reporte
            Case "Reporte1"

            Case "Reporte2"

            Case "Reporte3"
                If opcion = True Then
                    Size = New System.Drawing.Size(735, 631)
                    Me.GroupBox1.Location = New Point(42, 487)
                Else
                    Size = New System.Drawing.Size(735, 346)
                    Me.GroupBox1.Location = New Point(42, 191)
                End If
            Case "Reporte4"
                If opcion = True Then
                    Size = New System.Drawing.Size(735, 631)
                    Me.GroupBox5.Location = New Point(42, 637)
                Else
                    Size = New System.Drawing.Size(735, 346)
                    Me.GroupBox5.Location = New Point(42, 87)
                    Me.GroupBox1.Location = New Point(42, 191)
                End If
            Case "Reporte5"
            Case "Reporte6"
            Case "Reporte7"
            Case "Reporte8"
        End Select
    End Sub

    Public Sub FrmMostrarReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        CheckGrupoDany.Enabled = FlagDetalle
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        LimpiarControles(GroupBox4)
        Me.Close()
    End Sub

    Public Sub checkMostrarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostrarTodos.CheckedChanged
        If checkMostrarTodos.Checked = True Then
            txtFiltro.Enabled = False
            txtFiltro.Text = String.Empty
            lbldescripcion.Text = String.Empty
        Else
            txtFiltro.Enabled = True
            txtFiltro.Select()
        End If
    End Sub

    Public Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                    ByRef Activador_Grupo As Integer, ByRef tipo_Reporte As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            If checkMostrarTodos.Checked = False Then
                If txtFiltro.Text = String.Empty Then
                    MsgBox("Debe seleccionar un filtro para el Reporte", MsgBoxStyle.Information)
                    txtFiltro.Focus()
                    estado = False
                    Exit Try
                End If
            End If
            '----------
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            '-------------
            '---GrupoDany, ProductoSinStock 0 no Incluye, 1 Incluye grupo Dany,ProductoSinStock
            If CheckGrupoDany.Checked = True Or checkProductoSinStock.Checked = True Then
                Activador_Grupo = 1
            ElseIf CheckGrupoDany.Checked = False Or checkProductoSinStock.Checked = False Then
                Activador_Grupo = 0
            End If
            '--Tipo Reporte Detallado o Resumido
            '---0 Resumido ---1 Detallado ----2vendedor
            If rbresumido.Checked = True Then
                tipo_Reporte = 0
            ElseIf rbdetallado.Checked = True Then
                tipo_Reporte = 1
            ElseIf rbvendedor.Checked = True Then
                tipo_Reporte = 2
            ElseIf rbGrSinValor.Checked = True Then
                tipo_Reporte = 5
            End If
            If rbStockValorizado.Checked = True Then
                tipo_Reporte = 3
            ElseIf rbStockSinValorizar.Checked = True Then
                tipo_Reporte = 4
            ElseIf rbproductosinStock.Checked = True Then
                tipo_Reporte = 6
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_ActivadorGrupo As Integer = 0
        Dim Ref_tipoReporte As Integer = 0
        Dim Filtro As String = txtFiltro.Text
        '---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Ref_ActivadorGrupo, Ref_tipoReporte) = False Then Exit Sub
        '-----Mostrando el Reporte
        MostrarReporte(opcion, Ref_fecIni, Ref_fecFin, Filtro, Ref_ActivadorGrupo, Ref_tipoReporte)
    End Sub

    Private Sub txtFiltro_DoubleClick(sender As Object, e As EventArgs) Handles txtFiltro.DoubleClick
        OpcionBusquedaReportes(opcion)
    End Sub
End Class