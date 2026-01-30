Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmInventarioValorizadoEmpresa
    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim clsTipoCambio As ClsOperaciones.CURRENCY_TYPE
    Dim dtTipoCambio As DataTable
    Dim dtTipoProducto As DataTable
    Dim clsReportesBl As ClsReporteGenerales
    Dim dtDatosPart As DataTable
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtReporteInventarioV As DataTable
    Dim reporteBL As ClsBuscar

    Private Sub TiposArticulos()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_TipoArticulo()
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtTipoProducto.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(TODOS)"
            dtTipoProducto.Rows.InsertAt(row, 0)
            If dtTipoProducto.Rows.Count() <> 0 Then
                Me.cboTipoProducto.DataSource = dtTipoProducto
                Me.cboTipoProducto.DisplayMember = "DESCRIPCION"
                Me.cboTipoProducto.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TipoCambio()
        Try
            clsTipoCambio = New ClsOperaciones.CURRENCY_TYPE
            dtTipoCambio = New DataTable
            dtTipoCambio = clsTipoCambio.get_TiposCambio()
            If dtTipoCambio.Rows.Count() <> 0 Then
                Me.cbomoneda.DataSource = dtTipoCambio
                Me.cbomoneda.DisplayMember = "DESCRIPCION"
                Me.cbomoneda.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frmM.CadenaConsulta = sql
            frmM.Titulo = "Articulos"
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

  
    Private Function Validaciones(ByRef IDE As String, ByRef fechaINI As String, _
                                  ByRef Art_inicial As String, ByRef Art_final As String, ByRef TipoPart As String, _
                                  ByRef moneda As String, ByRef tipoReporte As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            'nombre de la pc
            IDE = System.Net.Dns.GetHostName()
            'Fecha
            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            'Seleccionando ARTICULO
            If txtinicioArticulo.Text = String.Empty Then
                estado = False
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                txtinicioArticulo.Focus()
                Exit Try
            ElseIf txtFinArticulo.Text = String.Empty Then
                estado = False
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                txtFinArticulo.Focus()
                Exit Try
            End If
            Art_inicial = txtinicioArticulo.Text
            Art_final = txtFinArticulo.Text

            'Tipo de articulo
            TipoPart = cboTipoProducto.SelectedValue.ToString

            'Moneda
            moneda = cbomoneda.SelectedValue.ToString
            If rbdetallado.Checked = True Then
                tipoReporte = 0
            ElseIf rbResumido.Checked = True Then
                tipoReporte = 1
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Public Sub MostrarReportes(ByVal IDE As String, ByVal fechaINI As String, _
                                  ByVal Art_inicial As String, ByVal Art_final As String, ByVal TipoPart As String, _
                                  ByVal moneda As String, ByVal tipoReporte As Integer)
        Try
            Dim dtDatosCompany As DataTable
            clsReportesBl = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Dim NombreReporte As String = String.Empty
            Dim EstiloReporte As String = String.Empty
            If tipoReporte = 0 Then
                NombreReporte = ""
            ElseIf tipoReporte = 1 Then
                NombreReporte = ""
            End If
            dtReporteInventarioV = New DataTable
            dtReporteInventarioV = clsReportesBl.Get_ImprimirReporte_Inventario_Valorizado(IDE, fechaINI, Art_inicial, Art_final, TipoPart, moneda, ProgressBar1)
            'Recorriendo los datos
            If tipoReporte = 0 Then
                EstiloReporte = "- DETALLADO."
            ElseIf tipoReporte = 1 Then
                EstiloReporte = "- RESUMIDO."
            End If
            dtDatosCompany = New DataTable
            reporteBL = New ClsBuscar
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            Me.Cursor = Cursors.WaitCursor
            If dtReporteInventarioV.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Inventario_Valorizado_Empresa.rpt", dtReporteInventarioV, "", "", "", "@ESTILOREPORTE;" & EstiloReporte, "@ART_INI;" & Art_inicial, "@ART_FIN;" & Art_final, _
                                          "@PERIODO;" & dtpfechaInicio.Text, "@MONEDA;" & cbomoneda.Text, "@ESTILO_REP;" & tipoReporte, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FrmInventarioValorizadoEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TiposArticulos()
        TipoCambio()
    End Sub

    Private Sub checkArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles checkArticulo.CheckedChanged
        Dim rsql As String = String.Empty
        If checkArticulo.Checked Then
            GbArticulos.Enabled = False
            txtinicioArticulo.Text = String.Empty
            txtFinArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtDescripcionArticulofinal.Text = String.Empty

            If cboTipoProducto.SelectedIndex >= 1 Then
                rsql = "SELECT TOP 1 ID,description  FROM PART WHERE TYPE_PART='" & cboTipoProducto.SelectedValue.ToString & "'" & _
                       " AND NOT(IS_STOCKED='N' AND IS_LOT='N' AND SERIES='N') ORDER BY ID "
            Else
                rsql = "SELECT TOP 1 ID,description FROM PART WHERE NOT(IS_STOCKED='N' AND IS_LOT='N' AND SERIES='N') ORDER BY ID "
            End If
            ''Mostrando data
            clsReportesBl = New ClsReporteGenerales
            dtDatosPart = New DataTable
            dtDatosPart = clsReportesBl.Get_DatosPart(rsql)

            If dtDatosPart.Rows.Count() <> 0 Then
                txtinicioArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                txtdescripcionArticuloInicial.Text = dtDatosPart.Rows(0).Item(1).ToString
                If cboTipoProducto.SelectedIndex >= 1 Then
                    rsql = "select TOP 1 ID,description from PART where TYPE_PART='" & cboTipoProducto.SelectedValue.ToString & "' ORDER BY ID DESC"
                Else
                    rsql = "select TOP 1 ID,description from PART WHERE NOT(IS_STOCKED='N' AND IS_LOT='N' AND SERIES='N') ORDER BY ID DESC"
                End If
                clsReportesBl = New ClsReporteGenerales
                dtDatosPart = New DataTable
                dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                txtFinArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                txtDescripcionArticulofinal.Text = dtDatosPart.Rows(0).Item(1).ToString
            End If
        Else
            GbArticulos.Enabled = True
            txtinicioArticulo.Text = String.Empty
            txtFinArticulo.Text = String.Empty
            txtdescripcionArticuloInicial.Text = String.Empty
            txtDescripcionArticulofinal.Text = String.Empty
        End If
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
    End Sub

    Private Sub txtFinArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinArticulo.MouseDoubleClick
        BuscarArticulos(txtFinArticulo, txtDescripcionArticulofinal)
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim ref_Ide As String = String.Empty
        Dim ref_fechaINI As String = String.Empty
        Dim ref_Art_inicial As String = String.Empty
        Dim ref_Art_final As String = String.Empty
        Dim ref_TipoPart As String = String.Empty
        Dim ref_moneda As String = String.Empty
        Dim ref_tipoReporte As Integer

        Me.Cursor = Cursors.WaitCursor
        If Validaciones(ref_Ide, ref_fechaINI, ref_Art_inicial, ref_Art_final, ref_TipoPart, ref_moneda, ref_tipoReporte) = False Then Exit Sub
        ProgressBar1.Visible = True
        MostrarReportes(ref_Ide, ref_fechaINI, ref_Art_inicial, ref_Art_final, ref_TipoPart, ref_moneda, ref_tipoReporte)
        ProgressBar1.Visible = False
        Me.Cursor = Cursors.Default
    End Sub
 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class