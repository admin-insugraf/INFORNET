Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports LibContabilidad

Public Class FrmLetras
    Dim LetterEnt As ClsEntidades.LETTER
    Private clsLetrasBl As ClsNegocio.LETTER_EXCHANGE
    Private clsLetraCorrelativoBl As ClsTransacciones.clsLetrasCorrelativo
    Private dtDetalleLetra As DataTable
    Private dtDocumentoPlanilla As DataTable
    Private dtDocumentoLetra As DataTable
    Private dtDocumentosPrincipal As DataTable
    Private listaLetras As List(Of strNLetras)
    Dim cont As Integer = 0
    Dim TipoNumeracion As String
    Dim Flag_Retencion As Boolean = False
    Dim PorcPercepcion As Double
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim Confirma As Boolean = False
    Dim _TIPO_CAMBIO_PLANILLA As Double = 0

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtdetalles As DataTable
    Public LISTA_LETRAS As List(Of ESTRUTURA_LETRA)
    Dim dtAdicionales As DataTable
    Dim var As String = String.Empty

    Dim CodigoPlanilla As String
    Dim CodigoLetra As String
    Dim NombreCliente As String
    Dim CodigoCliente As String
    Dim CodigoRuc As String

    Dim ClsCobranzaBl As ClsOperaciones.RECEIVABLE_LIST
    Dim dtAsientoCabecera As DataTable
    Dim dtAsientoDetalle As DataTable
    Dim dtDetallesLetra As DataTable

    Dim dtdetalleAsiento As DataTable
    Dim _numero_asiento As String = ""
    Dim EstadoPlanilla As String
    Dim f_vcto_nuevo As String, f_vcto_actual As String

    Public Sub GenerarColummnaDataTableAsientoContable()
        Try
            dtdetalleAsiento = New DataTable
            dtdetalleAsiento.Columns.Add("AD_IDCAB", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_SECUENCIA", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_CUENTA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("DESC_CUENTA", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_TANEXO", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDANEXO", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_TDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_SDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_NDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_FDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_VDOC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_DEBE", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_HABER", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_TCAM", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_SEC_ORI_DES", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDCC", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_ES_DESTINO", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_IDMEDIOPAGO", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_MONTO_ORI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_PORCE_DESTINO", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_ES_CONCI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_MES_CONCI", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_ES_INAFECTO", Type.GetType("System.Double"))
            dtdetalleAsiento.Columns.Add("AD_IDMONEDA", Type.GetType("System.Int64"))
            dtdetalleAsiento.Columns.Add("AD_TDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_SDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_NDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_FDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_VDOC_REF", Type.GetType("System.String"))
            dtdetalleAsiento.Columns.Add("AD_GLOSA", Type.GetType("System.String"))
            dgvDetalleAsiento.DataSource = Nothing
            dgvDetalleAsiento.DataSource = dtdetalleAsiento
            For i As Integer = 0 To dgvDetalleAsiento.ColumnCount() - 1
                dgvDetalleAsiento.Columns(i).Visible = False
                dgvDetalleAsiento.Columns(i).ReadOnly = True
            Next
            dgvDetalleAsiento.Columns(2).ReadOnly = False
            dgvDetalleAsiento.Columns(3).Width = 200
            dgvDetalleAsiento.Columns(2).Visible = True
            dgvDetalleAsiento.Columns(3).Visible = True
            dgvDetalleAsiento.Columns(6).Visible = True
            dgvDetalleAsiento.Columns(6).Width = 60
            dgvDetalleAsiento.Columns(7).Visible = True
            dgvDetalleAsiento.Columns(7).Width = 60
            dgvDetalleAsiento.Columns(8).Visible = True
            dgvDetalleAsiento.Columns(11).Visible = True
            dgvDetalleAsiento.Columns(12).Visible = True

            dgvDetalleAsiento.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalleAsiento.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvDetalleAsiento.Columns(2).HeaderText = "Cuenta Contable"
            dgvDetalleAsiento.Columns(3).HeaderText = "Descripcion Cuenta"
            dgvDetalleAsiento.Columns(6).HeaderText = "TipoDoc"
            dgvDetalleAsiento.Columns(7).HeaderText = "SerieDoc"
            dgvDetalleAsiento.Columns(8).HeaderText = "NumDoc"
            dgvDetalleAsiento.Columns(11).HeaderText = "Debe"
            dgvDetalleAsiento.Columns(12).HeaderText = "Haber"

            dgvDetalleAsiento.Columns(11).DefaultCellStyle.Format = "N2"
            dgvDetalleAsiento.Columns(12).DefaultCellStyle.Format = "N2"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CalcularTotalDocumentos(Optional ByVal Opcion As Boolean = False)
        Dim Fila As Int16 = dgvDocumentos.CurrentRow.Index
        Dim Total As Double = 0.0
        Dim TotalMn As Double = 0.0
        Dim TotalMe As Double = 0.0
        If Opcion = False Then
            If dtDocumentosPrincipal.Rows(Fila).Item("Sel").ToString = True Then
                TotalMn = 0.0
                TotalMe = 0.0
                For i As Integer = 0 To dtDocumentosPrincipal.Rows.Count() - 1
                    If dtDocumentosPrincipal.Rows(i).Item("Sel").ToString = True Then
                        If dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "MN" Then
                            TotalMn += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoCanjear").ToString)
                        ElseIf dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "ME" Then
                            TotalMe += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoCanjear").ToString)
                        End If
                    End If
                Next
                cont = cont + 1
                lbl_sel.Text = "Total Seleccionados : " & cont
                txtImporteMN.Text = Format(TotalMn, "##,##0.00")
                txtImporteME.Text = Format(TotalMe, "##,##0.00")
                txttotalMN.Text = Format((txtImporteME.Text * txtTipoCambio.Text) + txtImporteMN.Text, "##,##0.00")
                txttotalME.Text = Format((txtImporteMN.Text / txtTipoCambio.Text) + txtImporteME.Text, "##,##0.00")
            Else
                dtDocumentosPrincipal.BeginInit()
                dtDocumentosPrincipal.Rows(Fila).Item("MontoCanjear") = CDbl(dtDocumentosPrincipal.Rows(Fila).Item("MontoDetrac"))
                dtDocumentosPrincipal.Rows(Fila).Item("Saldo") = 0
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
                TotalMn = 0.0
                TotalMe = 0.0
                For i As Integer = 0 To dtDocumentosPrincipal.Rows.Count() - 1
                    If dtDocumentosPrincipal.Rows(i).Item("Sel").ToString = True Then
                        If dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "MN" Then
                            TotalMn += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoDetrac") - dtDocumentosPrincipal.Rows(i).Item("Saldo"))
                        ElseIf dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "ME" Then
                            TotalMe += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoDetrac") - dtDocumentosPrincipal.Rows(i).Item("Saldo"))
                        End If
                    End If
                Next
                cont = cont - 1
                lbl_sel.Text = "Total Seleccionados : " & cont
                txtImporteMN.Text = Format(TotalMn, "##,##0.00")
                txtImporteME.Text = Format(TotalMe, "##,##0.00")
                txttotalMN.Text = Format((txtImporteME.Text * txtTipoCambio.Text) + txtImporteMN.Text, "##,##0.00")
                txttotalME.Text = Format((txtImporteMN.Text / txtTipoCambio.Text) + txtImporteME.Text, "##,##0.00")
            End If
        Else
            TotalMn = 0.0
            TotalMe = 0.0
            For i As Integer = 0 To dtDocumentosPrincipal.Rows.Count() - 1
                If dtDocumentosPrincipal.Rows(i).Item("Sel").ToString = True Then
                    If dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "MN" Then
                        TotalMn += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoDetrac") - dtDocumentosPrincipal.Rows(i).Item("Saldo"))
                    ElseIf dtDocumentosPrincipal.Rows(i).Item("Mon").ToString = "ME" Then
                        TotalMe += CDbl(dtDocumentosPrincipal.Rows(i).Item("MontoDetrac") - dtDocumentosPrincipal.Rows(i).Item("Saldo"))
                    End If
                End If
            Next
            txtImporteMN.Text = Format(TotalMn, "##,##0.00")
            txtImporteME.Text = Format(TotalMe, "##,##0.00")
            txttotalMN.Text = Format((txtImporteME.Text * txtTipoCambio.Text) + txtImporteMN.Text, "##,##0.00")
            txttotalME.Text = Format((txtImporteMN.Text / txtTipoCambio.Text) + txtImporteME.Text, "##,##0.00")
        End If
    End Sub

    Private Function CalcularSaldoDocumentos() As Boolean
        Dim Fila As Int16 = dgvDocumentos.CurrentRow.Index
        If CDbl(dtDocumentosPrincipal.Rows(Fila).Item("MontoCanjear")) > CDbl(dtDocumentosPrincipal.Rows(Fila).Item("MontoDetrac")) Then
            MsgBox("El monto a Canjear debe ser menor o igual que el Monto", MsgBoxStyle.Information)
            dtDocumentosPrincipal.BeginInit()
            dtDocumentosPrincipal.Rows(Fila).Item("MontoCanjear") = CDbl(dtDocumentosPrincipal.Rows(Fila).Item("MontoDetrac"))
            dtDocumentosPrincipal.Rows(Fila).Item("Saldo") = CDbl(0)
            dtDocumentosPrincipal.EndInit()
            dtDocumentosPrincipal.AcceptChanges()
            Return False
        Else
            dtDocumentosPrincipal.BeginInit()
            dtDocumentosPrincipal.Rows(Fila).Item("Saldo") = CDbl(dtDocumentosPrincipal.Rows(Fila).Item("MontoDetrac") - dtDocumentosPrincipal.Rows(Fila).Item("MontoCanjear"))
            dtDocumentosPrincipal.EndInit()
            dtDocumentosPrincipal.AcceptChanges()
            Return True
        End If
    End Function

    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("Sel", Type.GetType("System.Boolean"))
            dtDocumentosPrincipal.Columns.Add("TipoDoc", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NumDoc", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("Monto", Type.GetType("System.Double"))
            dtDocumentosPrincipal.Columns.Add("Saldo", Type.GetType("System.Double"))
            dtDocumentosPrincipal.Columns.Add("MontoCanjear", Type.GetType("System.Double"))
            dtDocumentosPrincipal.Columns.Add("Mon", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("Emision", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("Vencimiento", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("MontoDetrac", Type.GetType("System.String"))
            dgvDocumentos.DataSource = Nothing
            dgvDocumentos.DataSource = dtDocumentosPrincipal
            dgvDocumentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDocumentos.Columns(0).Width = 40
            dgvDocumentos.Columns(0).ReadOnly = False
            dgvDocumentos.Columns(1).Width = 60
            dgvDocumentos.Columns(1).ReadOnly = True
            dgvDocumentos.Columns(2).Width = 90
            dgvDocumentos.Columns(2).ReadOnly = True
            dgvDocumentos.Columns(3).Width = 90
            dgvDocumentos.Columns(3).ReadOnly = True
            dgvDocumentos.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            dgvDocumentos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentos.Columns(4).Width = 90
            dgvDocumentos.Columns(4).ReadOnly = True
            dgvDocumentos.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            dgvDocumentos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentos.Columns(5).Width = 80
            dgvDocumentos.Columns(5).ReadOnly = False
            dgvDocumentos.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            dgvDocumentos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentos.Columns(6).Width = 60
            dgvDocumentos.Columns(6).ReadOnly = True
            dgvDocumentos.Columns(7).Width = 90
            dgvDocumentos.Columns(7).ReadOnly = True
            dgvDocumentos.Columns(8).Width = 90
            dgvDocumentos.Columns(8).ReadOnly = True
            dgvDocumentos.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PED_SP_S_ORDER_CLIENTE"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtCodCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txtRucDni.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    If String.IsNullOrEmpty(frm.Data_Matriz.Rows(0).Item("RETENTION").ToString()) Then
                        Flag_Retencion = False
                    Else
                        If frm.Data_Matriz.Rows(0).Item("RETENTION").ToString() = "0" Then
                            Flag_Retencion = False
                        ElseIf frm.Data_Matriz.Rows(0).Item("RETENTION").ToString() = "1" Then
                            Flag_Retencion = True
                        End If
                    End If
                End If
                frm.Close()
            Else
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                dtDetalleLetra = New DataTable("Clientes")
                dtDetalleLetra = clsLetrasBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleLetra.Rows.Count() <> 0 Then
                    txtCodCliente.Text = dtDetalleLetra.Rows(0).Item(0).ToString
                    txtRazonSocial.Text = dtDetalleLetra.Rows(0).Item(1).ToString
                    txtRucDni.Text = dtDetalleLetra.Rows(0).Item(2).ToString
                    If String.IsNullOrEmpty(dtDetalleLetra.Rows(0).Item("RETENTION").ToString()) Then
                        Flag_Retencion = False
                    Else
                        If dtDetalleLetra.Rows(0).Item("RETENTION").ToString() = "0" Then
                            Flag_Retencion = False
                        ElseIf dtDetalleLetra.Rows(0).Item("RETENTION").ToString() = "1" Then
                            Flag_Retencion = True
                        End If
                    End If
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtCodCliente.Text = String.Empty
                    txtRazonSocial.Text = String.Empty
                    txtRucDni.Text = String.Empty
                    txtCodCliente.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarDocumentosPendiente()
        Try
            If txtCodCliente.Text = String.Empty Then Exit Sub
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDetalleLetra = New DataTable("DocumentosPendientes")
            Dim _CodigoCliente As String = String.Empty
            _CodigoCliente = txtCodCliente.Text
            GenerarColummnaDataTable()
            dtDocumentosPrincipal = clsLetrasBl.Get_DocumentosPendientes(_CodigoCliente, IIf(cmbtipo.SelectedIndex = 0, "C", "R"))
            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dgvDocumentos.DataSource = dtDocumentosPrincipal
                lbl_tot.Text = "Total Registros     : " & dtDocumentosPrincipal.Rows.Count()
                cont = 0
                lbl_sel.Text = "Total Seleccionados : " & cont
            Else
                MsgBox("El Cliente no posee Documentos para Generar una Letra.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cmb_moneda.ValueMember = "CODIGO"
        cmb_moneda.DisplayMember = "DESCRIPCION"
        cmb_moneda.DataSource = monedaBL.get_TiposCambio()
        monedaBL = Nothing
    End Sub

    Private Sub PorcentajeRetecion()
        clsLetraCorrelativoBl = New ClsTransacciones.clsLetrasCorrelativo
        clsLetraCorrelativoBl.Get_PorcentajeRetencion()
        PorcPercepcion = 0.0
        PorcPercepcion = IIf(String.IsNullOrEmpty(clsLetraCorrelativoBl.NUMERIC_TYPE), 0, clsLetraCorrelativoBl.NUMERIC_TYPE)
    End Sub

    Private Sub DocumentosPlanilla()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentoPlanilla = New DataTable
            dtv = New DataView
            dtDocumentoPlanilla = clsLetrasBl.Get_DocumentosPlanilla(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, cboopcionesBusqueda.SelectedIndex, txtFiltro.Text.Trim)
            dgvPlanilla.DataSource = Nothing
            If dtDocumentoPlanilla.Rows.Count() <> 0 Then
                dtv = dtDocumentoPlanilla.DefaultView
                dgvPlanilla.DataSource = dtv
                dgvPlanilla.Columns(7).Visible = False

                dgvPlanilla.Columns(0).Width = 50
                dgvPlanilla.Columns(1).Width = 80
                dgvPlanilla.Columns(2).Width = 300
                dgvPlanilla.Columns(3).Width = 80
                dgvPlanilla.Columns(4).Width = 50
                dgvPlanilla.Columns(5).Width = 60
                dgvPlanilla.Columns(6).Width = 100
                dgvPlanilla.Columns(8).Width = 100

                'dgvPlanilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvPlanilla.Columns(0).Name & "+" & dgvPlanilla.Columns(1).Name & "+" & dgvPlanilla.Columns(2).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                dgvLetra.DataSource = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DocumentosLetras(ByVal _CodigoPlanilla As String)
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentoLetra = New DataTable
            var = String.Empty
            dtDocumentoLetra = clsLetrasBl.Get_DocumentosLetras(_CodigoPlanilla)
            dgvLetra.DataSource = Nothing
            If dtDocumentoLetra.Rows.Count() <> 0 Then
                dgvLetra.DataSource = dtDocumentoLetra
                For i As Integer = 0 To dtDocumentoLetra.Rows.Count() - 1
                    If dtDocumentoLetra.Rows(i).Item("IS_ORIG").ToString = "S" Then
                        var += dtDocumentoLetra.Rows(i).Item("TipoDoc").ToString & "-" & dtDocumentoLetra.Rows(i).Item("NumDocumento").ToString & ","
                    End If
                Next
                If var.Length() <> 0 Then
                    var = Mid(var, 1, var.Length() - 1)
                End If
                dgvLetra.Columns(3).DefaultCellStyle.Format = "N2"
                dgvLetra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvLetra.Columns(5).HeaderText = "Tipo"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosInciales(ByVal _CodigoPlanilla As String)
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentoLetra = New DataTable
            var = String.Empty
            dtDocumentoLetra = clsLetrasBl.Get_DocumentosLetras(_CodigoPlanilla)
            dgvLetra.DataSource = Nothing
            If dtDocumentoLetra.Rows.Count() <> 0 Then
                dgvLetra.DataSource = dtDocumentoLetra
                For i As Integer = 0 To dtDocumentoLetra.Rows.Count() - 1
                    If dtDocumentoLetra.Rows(i).Item("IS_ORIG").ToString = "S" Then
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta) Then
            MsgBox("No se asigno el tipo de Cambio.", MsgBoxStyle.Information)
            Me.Close()
        End If
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        Botonera_Estado_Cambiar(False)
        cboopcionesBusqueda.SelectedIndex = 1
        cmbtipo.SelectedIndex = 0
        txtTipoCambio.Text = ClsVarComun.TCVenta
        listaLetras = New List(Of strNLetras)
        Cargar_Moneda()
        PorcentajeRetecion()
        DocumentosPlanilla()
        If NIVEL_ACCESO() Then
            ToolStripButton3.Visible = NIVEL_ACCESO()

        Else
            ToolStripButton3.Visible = NIVEL_ACCESO_FACTURACION()
        End If

        dgvPlanilla.Select()
    End Sub
    Private Function NIVEL_ACCESO_FACTURACION() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "0000000011" Or dtNivel.Rows(0).Item("COD_PERFIL").ToString = "0000000005" Then
                        FLAG_NIVEL = True
                    Else
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
            MostrarDocumentosPendiente()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtCodCliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                Ayuda_Clientes(txtCodCliente.Text)
            End If
            MostrarDocumentosPendiente()
        End If
    End Sub

    Private Sub txtCodCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodCliente.MouseDoubleClick
        Ayuda_Clientes()
        MostrarDocumentosPendiente()
    End Sub
    Private Sub dgvDocumentos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvDocumentos.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvDocumentos.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvDocumentos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentos.CellValueChanged
        If e.ColumnIndex = 0 Then
            CalcularTotalDocumentos()
        ElseIf e.ColumnIndex = 5 Then
            If dgvDocumentos.Item(0, dgvDocumentos.CurrentRow.Index).Value = False Then
                dtDocumentosPrincipal.BeginInit()
                dtDocumentosPrincipal.Rows(dgvDocumentos.CurrentRow.Index).Item("MontoCanjear") = CDbl(dtDocumentosPrincipal.Rows(dgvDocumentos.CurrentRow.Index).Item("MontoDetrac"))
                dtDocumentosPrincipal.EndInit()
                dtDocumentosPrincipal.AcceptChanges()
                Exit Sub
            End If
            CalcularSaldoDocumentos()
            CalcularTotalDocumentos(True)
        End If
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna  
        Dim columna As Integer = dgvDocumentos.CurrentCell.ColumnIndex
        If columna = 5 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ".") And (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
   ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDocumentos.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
    End Sub

    Public Structure strNLetras
        Public Item As Short
        Public NroLetra As String
        Public Vence As DateTime
        Public Plazo As Integer
        Public CanjeMN As Decimal
        Public CanjeME As Decimal
        Public RetencMN As Decimal
        Public RetencME As Decimal
        Public LetraMN As Decimal
        Public LetraME As Decimal
        Public NroCorrelativo As String
        Public FechaVencimiento As DateTime
    End Structure

    Sub AgregarLetra(ByVal NLetras As Integer)
        Try
            Dim listStrNLetras As List(Of strNLetras)
            Dim objstrNLetras As strNLetras
            listStrNLetras = New List(Of strNLetras)
            dgvDetalleLetra.Rows.Clear()
            Dim Plazo As Short = 0
            Dim dteVen As Date
            Dim x As Integer = 0
            clsLetraCorrelativoBl = New ClsTransacciones.clsLetrasCorrelativo
            clsLetraCorrelativoBl.Get_NumeroCorrelativoLetra("LL")
            Dim ContadorMN As Double = 0
            Dim ContadorME As Double = 0
            Dim ContadorMN_Retencion As Double = 0
            Dim ContadorME_Retencion As Double = 0
            For i As Short = 1 To NLetras
                If NLetras = 1 Then
                    Plazo += 30
                    dteVen = DateAdd("D", Plazo, dtpFecha.Value.Date)
                    objstrNLetras = New strNLetras
                    objstrNLetras.Item = i
                    objstrNLetras.NroLetra = "L.N°" & String.Format("{0:000000}", CInt(clsLetraCorrelativoBl.NumeroCorrelativo + i))
                    objstrNLetras.Vence = dteVen
                    objstrNLetras.Plazo = Plazo
                    objstrNLetras.CanjeMN = Math.Round((txttotalMN.Text / NLetras), 2, MidpointRounding.AwayFromZero)
                    ContadorMN += objstrNLetras.CanjeMN
                    objstrNLetras.CanjeME = Math.Round((txttotalME.Text / NLetras), 2, MidpointRounding.AwayFromZero)
                    ContadorME += objstrNLetras.CanjeME
                    If Flag_Retencion = True And cmbtipo.SelectedIndex = 0 And CDbl(txttotalMN.Text) >= 700 Then
                        objstrNLetras.RetencMN = Math.Round(objstrNLetras.CanjeMN * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                        objstrNLetras.RetencME = Math.Round(objstrNLetras.CanjeME * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                    Else
                        objstrNLetras.RetencMN = 0
                        objstrNLetras.RetencME = 0
                    End If
                    ContadorMN_Retencion += objstrNLetras.RetencMN
                    ContadorME_Retencion += objstrNLetras.RetencME

                    objstrNLetras.LetraMN = objstrNLetras.CanjeMN - objstrNLetras.RetencMN
                    objstrNLetras.LetraME = objstrNLetras.CanjeME - objstrNLetras.RetencME
                    objstrNLetras.NroCorrelativo = objstrNLetras.NroLetra
                    objstrNLetras.FechaVencimiento = dteVen
                    listStrNLetras.Add(objstrNLetras)
                Else
                    Plazo += 30
                    dteVen = DateAdd("D", Plazo, dtpFecha.Value.Date)
                    objstrNLetras = New strNLetras
                    objstrNLetras.Item = i
                    'objstrNLetras.NroLetra = String.Format("{0:0000000}", CInt(clsLetraCorrelativoBl.NumeroCorrelativo + 1)) & "-" & String.Format("{0:00}", i)
                    objstrNLetras.NroLetra = "L.N°" & String.Format("{0:000000}", CInt(clsLetraCorrelativoBl.NumeroCorrelativo + i))
                    objstrNLetras.Vence = dteVen
                    objstrNLetras.Plazo = Plazo
                    If i = NLetras Then
                        objstrNLetras.CanjeMN = Math.Round(txttotalMN.Text - ContadorMN, 2, MidpointRounding.AwayFromZero)
                        objstrNLetras.CanjeME = txttotalME.Text - ContadorME
                    Else
                        objstrNLetras.CanjeMN = Math.Round((txttotalMN.Text / NLetras), 2, MidpointRounding.AwayFromZero)
                        ContadorMN += objstrNLetras.CanjeMN
                        objstrNLetras.CanjeME = Math.Round((txttotalME.Text / NLetras), 2, MidpointRounding.AwayFromZero)
                        ContadorME += objstrNLetras.CanjeME
                    End If

                    If i = NLetras Then
                        If Flag_Retencion = True And cmbtipo.SelectedIndex = 0 And CDbl(txttotalMN.Text) >= 700 Then
                            objstrNLetras.RetencMN = Math.Round((txttotalMN.Text * PorcPercepcion / 100) - ContadorMN_Retencion, 2, MidpointRounding.AwayFromZero)
                            'objstrNLetras.RetencMN = Math.Round(objstrNLetras.CanjeMN * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                            objstrNLetras.RetencME = Math.Round((txttotalME.Text * PorcPercepcion / 100) - ContadorME_Retencion, 2, MidpointRounding.AwayFromZero)
                            'objstrNLetras.RetencME = Math.Round(objstrNLetras.CanjeME * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                        Else
                            objstrNLetras.RetencMN = 0
                            objstrNLetras.RetencME = 0
                        End If
                    Else
                        If Flag_Retencion = True And cmbtipo.SelectedIndex = 0 And CDbl(txttotalMN.Text) >= 700 Then
                            objstrNLetras.RetencMN = Math.Round(objstrNLetras.CanjeMN * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                            'objstrNLetras.RetencMN = Math.Round(objstrNLetras.CanjeMN * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                            objstrNLetras.RetencME = Math.Round(objstrNLetras.CanjeME * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                            'objstrNLetras.RetencME = Math.Round(objstrNLetras.CanjeME * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero)
                        Else
                            objstrNLetras.RetencMN = 0
                            objstrNLetras.RetencME = 0
                        End If
                    End If

                    ContadorMN_Retencion += objstrNLetras.RetencMN
                    ContadorME_Retencion += objstrNLetras.RetencME

                    objstrNLetras.LetraMN = objstrNLetras.CanjeMN - objstrNLetras.RetencMN
                    objstrNLetras.LetraME = objstrNLetras.CanjeME - objstrNLetras.RetencME
                    objstrNLetras.NroCorrelativo = objstrNLetras.NroLetra
                    objstrNLetras.FechaVencimiento = dteVen
                    listStrNLetras.Add(objstrNLetras)
                End If
            Next
            listaLetras = listStrNLetras
            For Each obj As strNLetras In listaLetras
                dgvDetalleLetra.Rows.Add(obj.Item, obj.NroLetra, Format(obj.Vence, "Long Date"), _
                                         obj.Plazo, obj.CanjeMN.ToString("####0.00"), obj.CanjeME.ToString("####0.00"), _
                                         obj.RetencMN.ToString("####0.00"), obj.RetencME.ToString("####0.00"), _
                                         obj.LetraMN.ToString("####0.00"), obj.LetraME.ToString("####0.00"), _
                                         obj.NroCorrelativo, obj.FechaVencimiento.ToString("dd/MM/yyyy"))
                If obj.Vence.ToString("dddd").ToUpper() = "domingo".ToUpper() Then
                    dgvDetalleLetra.Rows(dgvDetalleLetra.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
                    dgvDetalleLetra.Rows(dgvDetalleLetra.Rows.Count - 1).DefaultCellStyle.SelectionForeColor = Color.Red
                    x += 1
                End If
            Next
            lblDomingo.Text = x.ToString()
            CalcularTotales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CalcularTotales()
        Try
            Dim TotalLetraMN As Double = 0.0
            Dim TotalLetraME As Double = 0.0
            Dim TotalRetMN As Double = 0.0
            Dim TotalRetME As Double = 0.0
            For Each row As DataGridViewRow In dgvDetalleLetra.Rows
                TotalLetraME += row.Cells("LetraME").Value
                TotalLetraMN += row.Cells("LetraMN").Value
                TotalRetME += row.Cells("RetencME").Value
                TotalRetMN += row.Cells("RetencMN").Value
            Next
            txtTotalLetraME.Text = Format(TotalLetraME, "##,##0.00")
            txtTotalLetraMN.Text = Format(TotalLetraMN, "##,##0.00")
            txtTotalRetME.Text = Format(TotalRetME, "##,##0.000")
            txtTotalRetMN.Text = Format(TotalRetMN, "##,##0.000")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub AgregarQuitar(ByVal opcion As Boolean)
        Try
            Dim n As Integer
            n = Convert.ToInt32(txtNLetras.Text)
            If opcion = True Then
                If Not n >= 200 Then
                    n += 1
                End If
            Else
                If Not n <= 1 Then
                    n -= 1
                End If
            End If
            txtNLetras.Text = n.ToString()

            If txtTipoCambio.Text = "" Then
                MessageBox.Show("No existe Tipo de Cambio. Verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf CDbl(txtTipoCambio.Text) = 0 Then
                MessageBox.Show("El Tipo de Cambio debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            GroupBox3.Visible = True

            AgregarLetra(n)
        Catch ex As Exception
            MessageBox.Show("Datos invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        AgregarQuitar(True)
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        AgregarQuitar(False)
    End Sub

    Private Sub dgvDetalleLetra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleLetra.CellEndEdit
        Try
            If e.ColumnIndex = 4 Then
                Dim TotalCanjeMN As Double = 0.0
                For i As Integer = 0 To dgvDetalleLetra.Rows.Count() - 1
                    TotalCanjeMN = TotalCanjeMN + dgvDetalleLetra.Item(4, i).Value
                Next
                TotalCanjeMN = Math.Round(TotalCanjeMN, 2, MidpointRounding.AwayFromZero)
                If CDbl(txttotalMN.Text) < TotalCanjeMN Then
                    MsgBox("La cantidad debe ser menor o igual que el  Total Canje MN.", MsgBoxStyle.Information)
                    dgvDetalleLetra.Item(4, dgvDetalleLetra.CurrentRow.Index).Value = 0
                    Exit Try
                End If
                dgvDetalleLetra.Item(8, dgvDetalleLetra.CurrentRow.Index).Value = dgvDetalleLetra.Item(4, dgvDetalleLetra.CurrentRow.Index).Value - dgvDetalleLetra.Item(6, dgvDetalleLetra.CurrentRow.Index).Value
                txtTotalLetraMN.Text = TotalCanjeMN
            ElseIf e.ColumnIndex = 5 Then
                Dim TotalCanjeME As Double = 0.0
                For i As Integer = 0 To dgvDetalleLetra.Rows.Count() - 1
                    TotalCanjeME = TotalCanjeME + dgvDetalleLetra.Item(5, i).Value
                Next
                TotalCanjeME = Math.Round(TotalCanjeME, 2, MidpointRounding.AwayFromZero)
                If CDbl(txttotalME.Text) < TotalCanjeME Then
                    MsgBox("La cantidad debe ser menor o igual que el  Total Canje ME.", MsgBoxStyle.Information)
                    dgvDetalleLetra.Item(5, dgvDetalleLetra.CurrentRow.Index).Value = 0
                    Exit Try
                End If
                dgvDetalleLetra.Item(9, dgvDetalleLetra.CurrentRow.Index).Value = dgvDetalleLetra.Item(5, dgvDetalleLetra.CurrentRow.Index).Value - dgvDetalleLetra.Item(7, dgvDetalleLetra.CurrentRow.Index).Value
                txtTotalLetraME.Text = TotalCanjeME
            End If
            Dim x As Integer = 0
            Dim nPlazo As Integer
            nPlazo = Convert.ToInt32(dgvDetalleLetra.Rows(e.RowIndex).Cells("Plazo").Value)
            Dim objStr As strNLetras = listaLetras(e.RowIndex)
            objStr.NroLetra = IIf(String.IsNullOrEmpty(dgvDetalleLetra.Rows(e.RowIndex).Cells("Nro_Letra").Value.ToString), "", dgvDetalleLetra.Rows(e.RowIndex).Cells("Nro_Letra").Value)
            objStr.Vence = DateAdd("D", nPlazo, dtpFecha.Value.Date)
            objStr.Plazo = nPlazo
            objStr.CanjeMN = Convert.ToDouble(dgvDetalleLetra.Rows(e.RowIndex).Cells("CanjeMN").Value)
            objStr.CanjeME = Convert.ToDouble(dgvDetalleLetra.Rows(e.RowIndex).Cells("CanjeME").Value)
            objStr.RetencMN = dgvDetalleLetra.Rows(e.RowIndex).Cells("RetencMN").Value
            objStr.RetencME = dgvDetalleLetra.Rows(e.RowIndex).Cells("RetencME").Value
            objStr.LetraMN = dgvDetalleLetra.Rows(e.RowIndex).Cells("LetraMN").Value
            objStr.LetraME = dgvDetalleLetra.Rows(e.RowIndex).Cells("LetraME").Value
            objStr.FechaVencimiento = objStr.Vence
            listaLetras(e.RowIndex) = objStr
            dgvDetalleLetra.Rows.Clear()
            For Each obj As strNLetras In listaLetras
                dgvDetalleLetra.Rows.Add(obj.Item, obj.NroLetra, Format(obj.Vence, "Long Date"), _
                            obj.Plazo, obj.CanjeMN.ToString("####0.00"), obj.CanjeME.ToString("####0.00"), _
                            obj.RetencMN.ToString("####0.000"), obj.RetencME.ToString("####0.00"), _
                            obj.LetraMN.ToString("####0.00"), obj.LetraME.ToString("####0.00"), _
                             obj.NroCorrelativo, obj.FechaVencimiento.ToString("dd/MM/yyyy"))
                If obj.Vence.ToString("dddd").ToUpper() = "domingo".ToUpper() Then
                    dgvDetalleLetra.Rows(dgvDetalleLetra.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
                    dgvDetalleLetra.Rows(dgvDetalleLetra.Rows.Count - 1).DefaultCellStyle.SelectionForeColor = Color.Red
                    x += 1
                End If
            Next
            lblDomingo.Text = x.ToString()
            CalcularTotales()

        Catch ex As InvalidOperationException
            MessageBox.Show("Se encuentra en modo Edicion para terminar Debe pulsar la Tecla Enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As SystemException
            MessageBox.Show("Dato invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvDetalleLetra.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Red
            dgvDetalleLetra.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.White
            dgvDetalleLetra.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionForeColor = Color.White
            dgvDetalleLetra.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Color.DarkRed
            dgvDetalleLetra.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        End Try
    End Sub

    Private Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Size = New System.Drawing.Size(837, 667)
            Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
            Me.TopMost = True
            Me.gbCabeceraLetra.Enabled = False
        Else
            Size = New System.Drawing.Size(837, 360)
            Me.gbCabeceraLetra.Enabled = True
        End If
    End Sub

    Private Sub BtnGenerarLetra_Click(sender As Object, e As EventArgs) Handles BtnGenerarLetra.Click
        If validaciones() = False Then Exit Sub
        GroupBox4.Visible = True
        Me.gbCabeceraLetra.Enabled = False
        txtTipoCambio.Text = "0.00"
        dtpFecha.MaxDate = Date.Now
        dtpFecha.Focus()
    End Sub

    Private Sub dgvDetalleLetra_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvDetalleLetra.CellValidating
        If e.ColumnIndex = 1 Then
            If dgvDetalleLetra.Columns(e.ColumnIndex).Name = "Nro_Letra" Then
                If String.IsNullOrEmpty(e.FormattedValue.ToString) Then
                    e.Cancel = True
                Else
                    dgvDetalleLetra.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    Dim CodigoLetra As String = String.Empty
                    CodigoLetra = dgvDetalleLetra.Rows(e.RowIndex).Cells("Nro_Letra").Value
                    CodigoLetra = CodigoLetra.PadLeft(6, Char.Parse("0"))
                    ''Verificar NumeracionLetra
                    clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                    dtDetalleLetra = New DataTable("NumeracionLetra")
                    dtDetalleLetra = clsLetrasBl.Get_VerificacionNumeracionLetra(Strings.Right(CodigoLetra, 6))
                    If dtDetalleLetra.Rows.Count() <> 0 Then
                        MsgBox("La Numeracion de la Letra ya existe, Verifique.", MsgBoxStyle.Information)
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelarLetra.Click
        Blank()
        Me.gbCabeceraLetra.Enabled = True
        txtCodCliente.Select()
        'AjustarTamaño(False)
    End Sub

    Private Function GuardarLetra() As Boolean
        Try
            Dim letraCabEnt As New ClsEntidades.LETTER_EXCHANGE
            Dim letraDetEnt As ClsEntidades.LETTER_EXCHANGE_LINE
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            Dim lista_det As New List(Of ClsEntidades.LETTER_EXCHANGE_LINE)
            Dim listaNumeroMax As New List(Of String)
            Dim NumMax As String
            Dim msj As String = String.Empty
            'numeroCorrelativo
            clsLetraCorrelativoBl = New ClsTransacciones.clsLetrasCorrelativo
            clsLetraCorrelativoBl.Get_NumeroCorrelativoLetra("LT")
            With letraCabEnt
                .ID = String.Format("{0:000000}", CInt(clsLetraCorrelativoBl.NumeroCorrelativo + 1))
                .DATE_EXCHANGE = dtpFecha.Value.ToShortDateString
                .VOUCHER_ID = 0
                .CREATE_DATE = DateTime.Now
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .STATUS = "P"
                .ACCEPT_DATE = ""
                .SELL_RATE = Math.Round(CDbl(txtTipoCambio.Text), 3)
                .CURRENCY_ID = cmb_moneda.SelectedValue.ToString
                .CUSTOMER_ID = txtCodCliente.Text
                .COMMENT = txtcomentario.Text
            End With
            'DOC origen
            Dim x As Integer = 1
            For Each row As DataRow In dtDocumentosPrincipal.Select("Sel=True")
                letraDetEnt = New ClsEntidades.LETTER_EXCHANGE_LINE
                With letraDetEnt
                    .ID = letraCabEnt.ID
                    .ITEM = x
                    .TYPE_DOC = row("TipoDoc").ToString
                    .NUMBER_DOC = row("NumDoc").ToString
                    If cmb_moneda.SelectedValue = "MN" Then
                        If row("Mon") = "MN" Then
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT = row("MontoCanjear")
                                End If
                            Else
                                .AMOUNT = row("MontoCanjear")
                            End If
                        Else
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT = (row("MontoCanjear") * CDbl(txtTipoCambio.Text))
                                    .AMOUNT = (.AMOUNT - Math.Round(.AMOUNT * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT = (row("MontoCanjear") * CDbl(txtTipoCambio.Text))
                                End If
                            Else
                                .AMOUNT = (row("MontoCanjear") * CDbl(txtTipoCambio.Text))
                            End If
                        End If
                    Else
                        If row("Mon") = "ME" Then
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT = (row("MontoCanjear"))
                                End If
                            Else
                                .AMOUNT = (row("MontoCanjear"))
                            End If
                            
                        Else
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT = (row("MontoCanjear") / CDbl(txtTipoCambio.Text))
                                    .AMOUNT = (.AMOUNT - Math.Round(.AMOUNT * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT = (row("MontoCanjear") / CDbl(txtTipoCambio.Text))
                                End If
                            Else
                                .AMOUNT = (row("MontoCanjear") / CDbl(txtTipoCambio.Text))
                            End If
                        End If
                    End If
                    .CADUCATE_DATE = ""
                    .IS_ORIG = "S"
                    .OPCION = ""
                    .PERCENT_DETRAC = IIf(Flag_Retencion, PorcPercepcion, 0)
                    If cmb_moneda.SelectedValue = "MN" Then
                        If row("Mon") = "MN" Then
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT_DETRAC = (Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT_DETRAC = 0 ' row("MontoCanjear")
                                End If
                            Else
                                .AMOUNT_DETRAC = 0 ' row("MontoCanjear")
                            End If
                            
                        Else
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT_DETRAC = (row("MontoCanjear") * CDbl(txtTipoCambio.Text))
                                    .AMOUNT_DETRAC = (Math.Round(.AMOUNT_DETRAC * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT_DETRAC = 0 '(row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                End If
                            Else
                                .AMOUNT_DETRAC = 0 '(row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                            End If
                        End If
                    Else

                        If row("Mon") = "ME" Then
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT_DETRAC = (Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT_DETRAC = 0 '(row("MontoCanjear"))
                                End If
                            Else
                                .AMOUNT_DETRAC = 0 '(row("MontoCanjear"))
                            End If
                            
                        Else
                            If cmbtipo.SelectedIndex = 0 Then
                                If Flag_Retencion = True Then
                                    .AMOUNT_DETRAC = (row("MontoCanjear") / CDbl(txtTipoCambio.Text))
                                    .AMOUNT_DETRAC = (Math.Round(.AMOUNT_DETRAC * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                Else
                                    .AMOUNT_DETRAC = 0 '(row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                End If
                            Else
                                .AMOUNT_DETRAC = 0 '(row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                            End If
                            
                        End If
                    End If
                End With
                x += 1
                lista_det.Add(letraDetEnt)
            Next

            For Each rows As DataGridViewRow In dgvDetalleLetra.Rows
                letraDetEnt = New ClsEntidades.LETTER_EXCHANGE_LINE
                With letraDetEnt
                    .ID = letraCabEnt.ID
                    .ITEM = x
                    .TYPE_DOC = "LT"
                    .NUMBER_DOC = rows.Cells("Nro_Letra").Value
                    If cmb_moneda.SelectedValue.ToString = "MN" Then
                        .AMOUNT = rows.Cells("LetraMN").Value
                    ElseIf cmb_moneda.SelectedValue.ToString = "ME" Then
                        .AMOUNT = rows.Cells("LetraME").Value
                    End If
                    .CADUCATE_DATE = rows.Cells("FechaVencimiento").Value
                    .IS_ORIG = "N"
                    .OPCION = rows.Cells("Plazo").Value
                    .PERCENT_DETRAC = 0
                    .AMOUNT_DETRAC = 0
                End With
                TipoNumeracion = String.Empty
                If rows.Cells("Nro_Letra").Value.ToString = rows.Cells("NroCorrelativo").Value.ToString Then
                    TipoNumeracion = "A"
                End If
                x += 1
                lista_det.Add(letraDetEnt)
                NumMax = rows.Cells("Nro_Letra").Value
                NumMax = NumMax.PadLeft(6, Char.Parse("0"))
                listaNumeroMax.Add(Strings.Right(NumMax, 6))
            Next
            Me.Cursor = Cursors.WaitCursor
            If clsLetrasBl.Insert(letraCabEnt, lista_det, dtDocumentosPrincipal, TipoNumeracion, listaNumeroMax.Max(), cmb_moneda.SelectedValue, PorcPercepcion, Flag_Retencion) Then
                msj = String.Empty
                msj = "Planilla Generada Correctamente, Nro Planilla: " & letraCabEnt.ID
                Me.Cursor = Cursors.Default
                MsgBox(msj, MsgBoxStyle.Information)
                Return True
            Else
                msj = String.Empty
                msj = "Hubo un error en la Generacion de la Letra"
                Me.Cursor = Cursors.Default
                MsgBox(msj, MsgBoxStyle.Exclamation)
                Return False
            End If
            
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Private Function validaciones() As Boolean
        Dim estado As Boolean = True
        Dim contador_monto As Double = 0
        Try
            If txtCodCliente.Text = String.Empty Then
                MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Information)
                estado = False
                txtCodCliente.Focus()
                Exit Try
            Else
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                dtDetalleLetra = New DataTable("Clientes")
                dtDetalleLetra = clsLetrasBl.Get_ManualClientes(txtCodCliente.Text)
                If dtDetalleLetra.Rows().Count() = 0 Then
                    MsgBox("El codigo ingresado del Cliente es incorrecto.", MsgBoxStyle.Critical)
                    estado = False
                    txtCodCliente.Focus()
                    Exit Try
                End If

            End If
            If dgvDocumentos.Rows.Count() = 0 Then
                MsgBox("El Cliente no posee Documentos para Generar una Letra.", MsgBoxStyle.Information)
                estado = False
                txtCodCliente.Focus()
                Exit Try
            End If
            If CDbl(txttotalMN.Text) = 0 Or CDbl(txttotalME.Text) = 0 Then
                MsgBox("No se puede Generar una Letra con Montos iguales a  Cero (0).", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If


            If Verificar_Apertura_Cierre_Modulos(dtpFecha.Value.Month, dtpFecha.Value.Year) = False Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Verificar_Apertura_Cierre_Modulos(ByVal Mes As String, ByVal anyo As String) As Boolean
        Dim Estado As Boolean = True
        Try
            Dim Mes_Ant = Mes
            Dim Anio_Ant = anyo

            Dim VentasBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            VentasBl = New LibCobranzas.ClsOperaciones.RECEIVABLE
            Dim dtCierre As New DataTable
            dtCierre = VentasBl.Validar_Cierre_Apertura_Modulos(Mes_Ant, Anio_Ant, "CLIENTES")
            If dtCierre.Rows.Count() > 0 Then
                MsgBox("El mes seleccionado se encuentra CERRADO," & Chr(13) & "APERTURAR para generar la Letra.", MsgBoxStyle.Critical)
                Estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function

    Private Function validaciones_monto() As Boolean
        Dim estado As Boolean = True
        Dim contador_monto As Double = 0.0
        Try
            For Each rows As DataGridViewRow In dgvDetalleLetra.Rows
                If cmb_moneda.SelectedValue.ToString = "MN" Then
                    contador_monto = contador_monto + rows.Cells("LetraMN").Value
                ElseIf cmb_moneda.SelectedValue.ToString = "ME" Then
                    contador_monto = contador_monto + rows.Cells("LetraME").Value
                End If
            Next
            If cmb_moneda.SelectedValue.ToString = "MN" Then
                If Val(txtTotalLetraMN.Text) <> contador_monto Then
                    MsgBox("La suma de la(s) letra(s) no son iguales al monto total a canjear.", MsgBoxStyle.Critical, "Aviso")
                    estado = False
                    Exit Try
                End If
            ElseIf cmb_moneda.SelectedValue.ToString = "ME" Then
                If Val(txtTotalLetraMN.Text) <> contador_monto Then
                    MsgBox("La suma de la(s) letra(s) no son iguales al monto total a canjear.", MsgBoxStyle.Critical, "Aviso")
                    estado = False
                    Exit Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub Blank()
        txtCodCliente.Text = String.Empty
        txtRucDni.Text = String.Empty
        txtRazonSocial.Text = String.Empty
        dgvDocumentos.DataSource = Nothing
        listaLetras = New List(Of strNLetras)
        If dgvDetalleLetra.RowCount() <> 0 Then
            For n As Integer = dgvDetalleLetra.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgvDetalleLetra.Rows(n)
                dgvDetalleLetra.Rows.Remove(row)
            Next
        End If
        'dgvDetalleLetra.Rows.Clear()
        txtImporteMN.Text = "0.00"
        txtImporteME.Text = "0.00"
        txttotalMN.Text = "0.00"
        txttotalME.Text = "0.00"
        txtNLetras.Text = 0
        'Dim fecha As Date = LibComunVar.ClsVarComun.FechaSistema.ToString("dd/MM/yyyy")
        'dtpFecha.Value = fecha
        txtTotalLetraMN.Text = "0.00"
        txtTotalLetraME.Text = "0.00"
        txtTotalRetME.Text = "0.00"
        txtTotalRetMN.Text = "0.00"
        txtTipoCambio.Text = LibComunVar.ClsVarComun.TCVenta
        lbl_tot.Text = "..."
        lbl_sel.Text = "..."
        txtcomentario.Text = ""
        cmbtipo.SelectedIndex = 0
        GroupBox4.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Function Validar_Numero_Letra(ByVal _numero As String) As Boolean
        Dim estado As Boolean = True

        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtDocumentoPlanilla = New DataTable
            dtDocumentoPlanilla = clsLetrasBl.Get_Numero_Letra(_numero)
            If dtDocumentoPlanilla.Rows.Count > 0 Then
                estado = False
            End If

        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If dgvDocumentos.CurrentRow Is Nothing Then Exit Sub

        If validaciones() = False Then Exit Sub

        If MessageBox.Show("Se va a proceder a la Creacion de una nueva Planilla de Letra(s)" & vbCrLf & "¿Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If dgvDetalleLetra.Rows.Count() = 0 Then
                MsgBox("No hay items en el Detalle de la Letra", MsgBoxStyle.Exclamation)

                dgvDetalleLetra.Focus()
                Exit Sub
            Else
                Dim ListaNumDistinc As New List(Of String)
                For Each rows As DataGridViewRow In dgvDetalleLetra.Rows
                    If ListaNumDistinc.Contains(rows.Cells("Nro_Letra").Value) = False Then
                        ListaNumDistinc.Add(rows.Cells("Nro_Letra").Value)
                    End If
                Next
                If ListaNumDistinc.Count() <> dgvDetalleLetra.Rows.Count() Then
                    MsgBox("Existe en la numeración de la letra, numeración repetida. Verifique", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For Each rows As DataGridViewRow In dgvDetalleLetra.Rows
                    If Validar_Numero_Letra(rows.Cells("Nro_Letra").Value) = False Then
                        MsgBox("El número de Letra " & rows.Cells("Nro_Letra").Value & " ya existe, verifique", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Next

                Dim totalCanjeMn As Double = 0.0
                totalCanjeMn = totalCanjeMn + CDbl(txtTotalRetMN.Text) + CDbl(txtTotalLetraMN.Text)
                Dim totalCanjeMe As Double = 0
                totalCanjeMe = CDbl(txtTotalLetraME.Text) + CDbl(txtTotalRetME.Text)

                If txttotalMN.Text <> Math.Round(totalCanjeMn, 2) Then
                    MsgBox("Los montos ingresados no coinciden con el Monto a canjear.. ", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txttotalME.Text <> Math.Round(totalCanjeMe, 2) Then
                    MsgBox("Los montos ingresados no coinciden con el Monto a canjear.. ", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If GuardarLetra() Then
                    Blank()
                    Me.gbCabeceraLetra.Enabled = True
                    Me.Cursor = Cursors.Default
                    txtCodCliente.Focus()
                End If

                'AjustarTamaño(False)
            End If
        End If
    End Sub
 

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            Dim wbusqueda As String = UCase(txtFiltro.Text)
            Dim myCurrencyManager As CurrencyManager
            myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
            Dim INTnewpos As Integer
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        
    End Sub


    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            ToolStripButton3.Enabled = False
            ToolStripButton2.Enabled = False
            btnEliminar.Enabled = False
            ToolStripButton1.Enabled = False
            btnAceptar.Enabled = False
            BtnGuardar.Enabled = True
            btn_anular.Enabled = False
            btn_ImprimirLetra.Enabled = False
            btn_ImprimirPlanilla.Enabled = False
            BtnCancelar.Enabled = True
            btn_por_recoger.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnEliminar.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = True
            btnAceptar.Enabled = True
            BtnGuardar.Enabled = False
            btn_ImprimirLetra.Enabled = True
            btn_ImprimirPlanilla.Enabled = True
            btn_anular.Enabled = True
            BtnCancelar.Enabled = False
            btn_por_recoger.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        Blank()
        PnlDocumentos.Visible = False
        PnlFiltros.Visible = False
        AjustarTamaño(False)
        txtCodCliente.Focus()
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botonera_Estado_Cambiar(False)
        Blank()
        'AjustarTamaño(True)
        PnlFiltros.Visible = True
        txtFiltro.Text = String.Empty
        PnlDocumentos.Visible = True
        DocumentosPlanilla()
    End Sub

    Private Sub dgvPlanilla_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPlanilla.SelectionChanged
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub
        Dim CodigoPlanilla As String = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        DocumentosLetras(CodigoPlanilla)
    End Sub

    Private Sub ImprimirPlanilla(ByVal _CodigoPlanillas As String, ByVal _CodigoCliente As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("ImprimirPlanilla")
            Dim DIFERENCIA As Double, DIFERENCIA2 As Double
            Dim Total_S As Double
            Dim Retenc As String
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteLetrasPlanilla(_CodigoPlanillas)
            If dtImprimir.Rows.Count() <> 0 Then
                ''MONTO DE DOCUMENTOS
                reporteBL = New ClsBuscar
                dtdetalles = New DataTable("Monto_S")
                dtdetalles = reporteBL.Montos_S(_CodigoPlanillas)
                If dtdetalles.Rows.Count() <> 0 Then
                    Total_S = 0.0
                    Total_S = IIf(String.IsNullOrEmpty(dtdetalles.Rows(0).Item("AMOUNT").ToString), 0, dtdetalles.Rows(0).Item("AMOUNT"))
                End If
                ''MONTO DE LA LETRA
                'reporteBL = New ClsBuscar
                'dtdetalles = New DataTable("Monto_N")
                'dtdetalles = reporteBL.Montos_N(_CodigoPlanillas)

                'If dtdetalles.Rows.Count() <> 0 Then
                '    Total_N = 0.0
                '    Total_N = IIf(String.IsNullOrEmpty(dtdetalles.Rows(0).Item("AMOUNT").ToString), 0, dtdetalles.Rows(0).Item("AMOUNT"))
                'End If
                DIFERENCIA = 0.0
                DIFERENCIA2 = 0.0
                DIFERENCIA = Total_S * PorcPercepcion / 100
                DIFERENCIA2 = Total_S - DIFERENCIA
                ''verificar
                reporteBL = New ClsBuscar
                dtdetalles = New DataTable("Cliente_Retencion")
                dtdetalles = reporteBL.ClienteRetencion(_CodigoCliente)
                Retenc = String.Empty
                If dtdetalles.Rows.Count() <> 0 Then
                    Retenc = IIf(String.IsNullOrEmpty(dtdetalles.Rows(0).Item("RETENTION").ToString), "0", dtdetalles.Rows(0).Item("RETENTION"))
                End If
                ''Documentos con Detraccion
                reporteBL = New ClsBuscar
                Dim DocAfectosRetencion As Double = 0
                dtdetalles = New DataTable("documentos_Detraccion")
                dtdetalles = reporteBL.VerificacionDocumentosDetraccion(_CodigoPlanillas)
                If dtdetalles.Rows.Count() <> 0 Then
                    For Each rows As DataRow In dtdetalles.Rows
                        DocAfectosRetencion += IIf(String.IsNullOrEmpty(rows("AMOUNT_DETRAC").ToString), "0", rows("AMOUNT_DETRAC"))
                    Next
                End If
                Dim dtDatosCompany As DataTable
                dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
                crystalBL.Muestra_Reporte("rpt_Letras_Planilla.rpt", "", "", "", "@ID;" & _CodigoPlanillas, "RETENC;" & Retenc, "DIFER;" & DIFERENCIA, "@PORC;" & PorcPercepcion, "@DETRACCION;" & DocAfectosRetencion, "empresa;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ImprimirLetra(ByVal _CodigoPlanilla As String, ByVal _TipoDocum As String)
        Try



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ImprimirPlanilla_Click(sender As Object, e As EventArgs) Handles btn_ImprimirPlanilla.Click
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub
        Dim CodigoPlanilla As String = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        Dim CodigoCliente As String = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value
        ImprimirPlanilla(CodigoPlanilla, CodigoCliente)
    End Sub


    Public Sub Limpiar()
        txtruc.Text = String.Empty
        txtnombreAval.Text = String.Empty
        txtnrodocAval.Text = String.Empty
        txtdireccAval.Text = String.Empty
        txttelefonoAval.Text = String.Empty
        txtnombreReprAval.Text = String.Empty
        txtbanco.Text = String.Empty
        txtoficina.Text = String.Empty
        cboCuenta.DataSource = Nothing
        txtdescripcionBanco.Text = String.Empty
        txtnombreRepresentante.Text = String.Empty
        txtNroFacturas.Text = String.Empty
    End Sub

    Public Sub CargarDetallesLetra(ByVal _CodigoPlanilla As String, ByVal _CodigoLetra As String, ByVal _CodigoCliente As String, ByVal _NombreCliente As String, ByVal _Ruc As String)
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            Dim dtAdicLetraCabecera As DataTable
            dtAdicLetraCabecera = New DataTable
            Dim xsec As Integer
            Dim Giro, Mon, xNumLetra, xVence, CLIENTE, xxDolar, xxSoles As String
            Dim vGRuc, vGTlf, vGDirec, vGFecha, CodCliente, ProvCliente As String
            Dim Dir_fis, telefono As String
            Dim xSoles, xDolares As Double
            dtAdicLetraCabecera = clsLetrasBl.Get_AdicionalDatosLetra(_CodigoPlanilla, _CodigoCliente)
            If dtAdicLetraCabecera.Rows.Count() <> 0 Then
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                Dim dtAdicionalesCliente As DataTable
                dtAdicionalesCliente = New DataTable
                Dim CodCli As String = String.Empty
                CodCli = dtAdicLetraCabecera.Rows(0).Item("CUSTOMER_ID").ToString
                dtAdicionalesCliente = clsLetrasBl.Get_AdicionalDatosCliente(CodCli)
                If dtAdicionalesCliente.Rows.Count() <> 0 Then
                    vGRuc = String.Empty
                    vGTlf = String.Empty
                    vGDirec = String.Empty
                    vGFecha = String.Empty
                    vGRuc = dtAdicionalesCliente.Rows(0).Item("VAT_REGISTRATION").ToString
                    vGTlf = dtAdicionalesCliente.Rows(0).Item("PHONE").ToString
                    vGDirec = dtAdicionalesCliente.Rows(0).Item("ADDR").ToString
                    CodCliente = dtAdicionalesCliente.Rows(0).Item("ID").ToString
                    ProvCliente = dtAdicionalesCliente.Rows(0).Item("PROVINCE").ToString
                End If
                Giro = String.Empty
                Mon = String.Empty
                Giro = dtAdicLetraCabecera.Rows(0).Item("DATE_EXCHANGE")
                If Not String.IsNullOrEmpty(dtAdicLetraCabecera.Rows(0).Item("CURRENCY_ID").ToString) Then
                    If Trim(dtAdicLetraCabecera.Rows(0).Item("CURRENCY_ID")) = "MN" Then
                        Mon = "MN"
                    Else
                        Mon = "ME"
                    End If
                End If
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                Dim dtAdicLetraDetalle As DataTable
                dtAdicLetraDetalle = New DataTable
                dtAdicLetraDetalle = clsLetrasBl.Get_AdicionalDatosLetraDetalle(_CodigoPlanilla, _CodigoLetra)
                If dtAdicLetraDetalle.Rows().Count() <> 0 Then
                    xsec = 0
                    For i As Integer = 0 To dtAdicLetraDetalle.Rows().Count() - 1
                        xNumLetra = String.Empty
                        xVence = String.Empty
                        CLIENTE = String.Empty
                        xxDolar = String.Empty
                        xxSoles = String.Empty
                        xSoles = 0.0 : xDolares = 0.0
                        xsec += 1
                        If Not String.IsNullOrEmpty(dtAdicLetraDetalle.Rows(i).Item("NUMBER_DOC").ToString) Then xNumLetra = dtAdicLetraDetalle.Rows(i).Item("NUMBER_DOC")
                        If dtAdicLetraCabecera.Rows(0).Item("CURRENCY_ID") = "MN" Then
                            If Not String.IsNullOrEmpty(dtAdicLetraDetalle.Rows(i).Item("AMOUNT").ToString) Then xSoles = CDbl(dtAdicLetraDetalle.Rows(i).Item("AMOUNT"))
                        Else
                            If Not String.IsNullOrEmpty(dtAdicLetraDetalle.Rows(i).Item("AMOUNT").ToString) Then xDolares = CDbl(dtAdicLetraDetalle.Rows(i).Item("AMOUNT"))
                        End If

                        If Not String.IsNullOrEmpty(dtAdicLetraDetalle.Rows(i).Item("CADUCATE_DATE").ToString) Then
                            xVence = dtAdicLetraDetalle.Rows(i).Item("CADUCATE_DATE")
                        Else
                            xVence = ""
                        End If
                        CLIENTE = _NombreCliente
                        xxDolar = UCase(NUMEROLETRASFACTURACION(dtAdicLetraDetalle.Rows(i).Item("AMOUNT"))) & "Dolares Americanos"
                        xxSoles = UCase(NUMEROLETRASFACTURACION(dtAdicLetraDetalle.Rows(i).Item("AMOUNT"))) & "Soles"
                        For Each obj As ESTRUTURA_LETRA In LISTA_LETRAS
                            Dim csql As String = String.Empty
                            csql = "INSERT INTO T_Temporal_Letras (SQ,NumeroLetra,Soles,Dolares,Vence,Cliente,DICliente,Giro,Aval,DocAval,DirecAval, " _
                                 & "TelfAval,Banco,Oficina,Cta,Moneda,LetrSol,LetrUS,RepAval,RepEmp,Factura,codCliente,PROV) " _
                                 & "VALUES (" & xsec & ",'" & xNumLetra & "', " & xSoles & "," & xDolares & ",'" & xVence & "','" & Trim(CLIENTE) & "'" _
                                 & ", '" & _Ruc & "', '" & Giro & "','" & Trim(obj.NOMBRE_AVAL) & "','" & Trim(obj.NRODOC_AVAL) & "', '" & Trim(obj.DIRECC_AVAL) & "','" & Trim(obj.TELEFONO_AVAL) & "'" _
                                 & ",'" & Trim(obj.BANCO) & "', '" & Trim(obj.OFICINA) & "','" & Trim(obj.CUENTA) & "','" & Trim(Mon) & "','" & xxSoles & "','" & xxDolar & "'" _
                                 & ",'" & obj.NOMBRE_REP_AVAL & "','" & obj.NOMBRE_REPRESENTANTE & "','" & obj.NRO_FACTURA & "','" & CodCliente & "','" & ProvCliente & "')"
                            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                            dtAdicionales = New DataTable("GuardarDetallesLetra")
                            If clsLetrasBl.InsercionTablaTemporal(csql) = False Then
                                Exit Sub
                            End If
                        Next
                    Next
                    clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                    dtAdicionales = New DataTable("GuardarDetallesLetra")
                    Dir_fis = String.Empty
                    telefono = String.Empty
                    dtAdicionales = clsLetrasBl.DatosAdicionalesDireccion(_CodigoCliente)
                    If dtAdicionales.Rows.Count() <> 0 Then
                        Dir_fis = dtAdicionales.Rows(0).Item("DIRECCION").ToString
                        telefono = dtAdicionales.Rows(0).Item("PHONE").ToString
                    End If
                    clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                    crystalBL = New LibReportes.ClsReporte
                    dtImprimir = New DataTable
                    Me.Cursor = Cursors.WaitCursor
                    dtImprimir = clsLetrasBl.EjecutarReporteLetras()
                    If dtImprimir.Rows.Count() <> 0 Then
                        If LibComunVar.ClsVarComun.RucEmpresa = "20556850454" Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Letras_20556850454.rpt", dtImprimir, "", "", "@DIREC;" & Dir_fis, "@TEL;" & telefono)
                        ElseIf LibComunVar.ClsVarComun.RucEmpresa = "20604576394" Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Letras_20604576394.rpt", dtImprimir, "", "", "@DIREC;" & Dir_fis, "@TEL;" & telefono)
                        ElseIf LibComunVar.ClsVarComun.RucEmpresa = "20547008902" Then
                            crystalBL.Muestra_Reporte("rpt_Letras_Letras_20547008902.rpt", dtImprimir, "", "", "@DIREC;" & Dir_fis, "@TEL;" & telefono)
                        Else
                            crystalBL.Muestra_Reporte("rpt_Letras_Letras.rpt", dtImprimir, "", "", "@DIREC;" & Dir_fis, "@TEL;" & telefono)
                        End If

                    Else
                        MsgBox("No hay informacion para mostrar", MsgBoxStyle.Information)
                    End If
                End If
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ImprimirLetra_Click(sender As Object, e As EventArgs) Handles btn_ImprimirLetra.Click
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvLetra.Item(0, dgvLetra.CurrentRow.Index).Value.ToString) Or String.IsNullOrEmpty(dgvLetra.Item(1, dgvLetra.CurrentRow.Index).Value.ToString) Then Exit Sub
        If dgvLetra.Item(1, dgvLetra.CurrentRow.Index).Value.ToString <> "LT" Then Exit Sub
        CodigoPlanilla = String.Empty
        CodigoLetra = String.Empty
        NombreCliente = String.Empty
        CodigoCliente = String.Empty
        CodigoRuc = String.Empty
        'Asignacion
        CodigoPlanilla = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        CodigoLetra = dgvLetra.Item(2, dgvLetra.CurrentRow.Index).Value
        NombreCliente = dgvPlanilla.Item(2, dgvPlanilla.CurrentRow.Index).Value
        CodigoCliente = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value
        CodigoRuc = dgvPlanilla.Item(7, dgvPlanilla.CurrentRow.Index).Value
        pnlLetraAdicionales.Visible = True
        PnlDocumentos.Enabled = False
        Limpiar()
        MostrarDatosAdicionalesLetra(CodigoPlanilla, CodigoLetra, CodigoCliente, var, CodigoRuc)
        txtnombreAval.Focus()
    End Sub

    Public Sub DatosAdicionales()
        Dim estado As Boolean = True
        LISTA_LETRAS = New List(Of ESTRUTURA_LETRA)
        Dim STR As New ESTRUTURA_LETRA
        STR.RUC = txtruc.Text
        STR.NOMBRE_AVAL = txtnombreAval.Text
        STR.NRODOC_AVAL = txtnrodocAval.Text
        STR.DIRECC_AVAL = txtdireccAval.Text
        STR.TELEFONO_AVAL = txttelefonoAval.Text
        STR.NOMBRE_REP_AVAL = txtnombreReprAval.Text
        STR.BANCO = txtbanco.Text
        STR.OFICINA = txtoficina.Text
        If cboCuenta.Text = String.Empty Then
            STR.CUENTA = ""
        Else
            STR.CUENTA = cboCuenta.SelectedValue.ToString
        End If
        STR.NOMBRE_REPRESENTANTE = txtnombreRepresentante.Text
        STR.NRO_FACTURA = txtNroFacturas.Text
        LISTA_LETRAS = New List(Of ESTRUTURA_LETRA)
        LISTA_LETRAS.Add(STR)

        ''Detalles Adicionales
        LetterEnt = New ClsEntidades.LETTER
        LetterEnt.LETTER_ID = dgvLetra.Item(2, dgvLetra.CurrentRow.Index).Value
        LetterEnt.BANK_ID = txtbanco.Text
        LetterEnt.COMMENT = ""
        LetterEnt.STATUS_ACT = ""
        LetterEnt.STATUS_LAST = ""
        LetterEnt.PLACE_SHIP = ""
        LetterEnt.GUARANTOR_NAME = txtnombreAval.Text
        LetterEnt.GUARANTOR_PHONE = txttelefonoAval.Text
        LetterEnt.GUARANTOR_ADDR = txtdireccAval.Text
        LetterEnt.GUARANTOR_NAME2 = ""
        LetterEnt.GUARANTOR_ADDR2 = ""
        LetterEnt.GUARANTOR_PHONE2 = ""
        LetterEnt.LETTER_ORIG = ""
        If cboCuenta.Text = String.Empty Then
            LetterEnt.NUMBER_ACCOUNT = ""
        Else
            LetterEnt.NUMBER_ACCOUNT = cboCuenta.SelectedValue.ToString
        End If
        LetterEnt.NUMBER_BANK = ""
        LetterEnt.TYPE_DOC = ""
        LetterEnt.CREATE_DATE = Date.Now() & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
        LetterEnt.UPDATE_DATE = ""
        clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
        If clsLetrasBl.InsertDetallesLetra(LetterEnt) = False Then
            MsgBox("Error guardando detalles de datos Adicionales", MsgBoxStyle.Information)
        End If
    End Sub

    Public Structure ESTRUTURA_LETRA
        Public RUC As String
        Public NOMBRE_AVAL As String
        Public NRODOC_AVAL As String
        Public DIRECC_AVAL As String
        Public TELEFONO_AVAL As String
        Public NOMBRE_REP_AVAL As String
        Public BANCO As String
        Public OFICINA As String
        Public CUENTA As String
        Public NOMBRE_REPRESENTANTE As String
        Public NRO_FACTURA As String
    End Structure

    Private Sub MostrarDatosAdicionalesLetra(ByVal _CodigoPlanilla As String, ByVal _CodigoLetra As String, ByVal _CodigoCliente As String, ByVal ConcatenadoNumeros As String, ByVal _Ruc As String)
        Try
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            dtAdicionales = New DataTable("DatosAdicionalesLetter")
            dtAdicionales = clsLetrasBl.Get_AdicionalesLetter(_CodigoLetra)
            If dtAdicionales.Rows.Count() <> 0 Then
                txtruc.Text = _Ruc
                txtnombreAval.Text = dtAdicionales.Rows(0).Item("GUARANTOR_NAME").ToString
                txtnrodocAval.Text = ""
                txtdireccAval.Text = dtAdicionales.Rows(0).Item("GUARANTOR_ADDR").ToString
                txttelefonoAval.Text = dtAdicionales.Rows(0).Item("GUARANTOR_PHONE").ToString
                txtnombreReprAval.Text = ""
                txtbanco.Text = dtAdicionales.Rows(0).Item("BANK_ID").ToString
                txtoficina.Text = ""
                If txtbanco.Text <> String.Empty Then
                    reporteBL = New ClsBuscar
                    Dim dtMostrandoDescripcion As DataTable
                    dtMostrandoDescripcion = New DataTable("Desc_Banco")
                    Dim consulta As String = String.Empty
                    consulta = "SELECT * FROM BANK WHERE ID='" & txtbanco.Text & "'"
                    dtMostrandoDescripcion = reporteBL.MostrandoDescripcion(consulta)
                    If dtMostrandoDescripcion.Rows.Count() <> 0 Then
                        txtdescripcionBanco.Text = dtMostrandoDescripcion.Rows(0).Item(1).ToString
                    Else
                        txtbanco.Text = String.Empty
                    End If
                    If txtbanco.Text <> String.Empty Then MostrandoCuentasBancos(txtbanco.Text)
                End If
                'cboCuenta.SelectedValue = dtAdicionales.Rows(0).Item("NUMBER_ACCOUNT").ToString
                txtnombreRepresentante.Text = ""
                txtNroFacturas.Text = ConcatenadoNumeros
            Else
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                dtAdicionales = New DataTable("DatosAdicionalesAval")
                dtAdicionales = clsLetrasBl.Get_AdicionalesAval(_CodigoCliente)
                If dtAdicionales.Rows.Count() <> 0 Then
                    txtruc.Text = _Ruc
                    txtnombreAval.Text = dtAdicionales.Rows(0).Item("NAME_GUARANTOR").ToString
                    txtnrodocAval.Text = dtAdicionales.Rows(0).Item("DOC_GUARANTOR").ToString
                    txtdireccAval.Text = dtAdicionales.Rows(0).Item("ADDR_GUARANTOR").ToString
                    txttelefonoAval.Text = dtAdicionales.Rows(0).Item("PHONE_GUARANTOR").ToString
                    txtnombreReprAval.Text = dtAdicionales.Rows(0).Item("REP_GUARANTOR").ToString
                    txtbanco.Text = ""
                    txtoficina.Text = ""
                    ' cboCuenta.Text = ""
                    txtnombreRepresentante.Text = ""
                    txtNroFacturas.Text = ConcatenadoNumeros
                End If
            End If
            txtNroFacturas.Text = ConcatenadoNumeros
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function NUMEROLETRAS(num As Double) As String
        Dim cLET As String
        Dim cWork As String
        Dim cUNIDAD As String
        Dim cDECENA As String
        Dim cCENTENA As String
        Dim nMODULUS As Integer
        Dim nI As Integer
        Dim nK As Integer
        Dim Lit1 As String
        Dim Lit2 As String
        Dim Lit3 As String
        Dim Lit4 As String
        Dim Lit5 As String
        Lit1 = "Uno    Dos    Tres   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
        Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
        Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
        Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
        Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"
        cLET = ""
        If num > 0.99 Then

            If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
                cWork = Mid(Trim(Str(num)), 1, InStr(1, Trim(Str(num)), ".", 0) - 1)
            Else
                cWork = Str(num)
            End If
            nMODULUS = Int(Len(Trim(cWork)) / 3)
            nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)

            If nMODULUS > 0 Then
                'cWork = String.Format(3 - nMODULUS, "0") & Trim(cWork)
                cWork = cWork.PadLeft(CInt(3 - nMODULUS) + CInt(cWork.Length()), "0")
            End If
            nK = (Len(Trim(cWork)) / 3) - 1

            nI = 1
            Do While nI < Len(Trim(cWork)) - 1
                cCENTENA = Mid(Trim(cWork), nI, 1)
                cDECENA = Mid(Trim(cWork), nI + 1, 1)
                cUNIDAD = Mid(Trim(cWork), nI + 2, 1)

                If cCENTENA <> "0" Then
                    If cCENTENA = "1" Then
                        cLET = cLET & "Cien "
                        If cDECENA <> "0" Or cUNIDAD <> "0" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "to "
                        End If
                    Else
                        If cCENTENA = 2 Or cCENTENA = 3 Then
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "cientos "
                        Else
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                        End If
                    End If
                End If

                If cDECENA <> "0" Then
                    If cDECENA = "1" And cUNIDAD <> "0" Then
                        If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
                    Else
                        If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
                    End If
                End If

                If cUNIDAD <> "0" Then
                    If cDECENA > "1" Then
                        'MODIFICADO PARA VER EL TEXTO CON LA Y GRIEGA
                        If cDECENA = "2" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "i"
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        Else
                            cLET = cLET & " y "
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        End If
                    Else
                        If cDECENA < "1" Then
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
                        End If
                    End If
                End If
                cLET = cLET & " "
                'Pone Miles o Millones
                If nK > 0 Then
                    If cCENTENA & cDECENA & cUNIDAD = "001" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
                    End If
                    nMODULUS = Int(nK / 2)
                    nMODULUS = nK - (nMODULUS * 2)
                    If nMODULUS = 0 Then
                        cLET = cLET + Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))
                        If cCENTENA & cDECENA & cUNIDAD = "001" Or num > 1999999 Then
                            cLET = cLET & "es "
                        Else
                            cLET = cLET & " "
                        End If
                    Else
                        If cCENTENA & cDECENA & cUNIDAD > "000" Then
                            cLET = cLET & "Mil "
                        End If
                    End If
                    nK = nK - 1
                End If
                nI = nI + 3
            Loop

            cLET = cLET & "con "

        End If
        If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
            cLET = cLET + Mid(Trim(Format(num, ".00")), InStr(1, Trim(Format(num, ".00")), ".", 0) + 1, 2) & "/100" & " "
        Else
            cLET = cLET + "00/100" & " "
        End If
        NUMEROLETRAS = cLET
    End Function

    Public Function NUMEROLETRASFACTURACION(num As Double) As String
        Dim cLET As String
        Dim cWork As String
        Dim cUNIDAD As String
        Dim cDECENA As String
        Dim cCENTENA As String
        Dim nMODULUS As Integer
        Dim nI As Integer
        Dim nK As Integer
        Dim Lit1 As String
        Dim Lit2 As String
        Dim Lit3 As String
        Dim Lit4 As String
        Dim Lit5 As String
        Lit1 = "Uno    Dos    Tres   Cuatroc  Quin   Seisc  Setec  Ochoc  Novec  "
        Lit2 = "Diez     Veinte   Treinta  Cuarenta CincuentaSesenta  Setenta  Ochenta  Noventa  "
        Lit3 = "Once      Doce      Trece     Catorce   Quince    Dieciseis DiecisieteDieciocho Diecinueve"
        Lit4 = "Uno   Dos   Tres  CuatroCinco Seis  Siete Ocho  Nueve "
        Lit5 = "Millon    Billon    Trillon   CuatrillonQuintillon"
        cLET = ""
        If num > 0.99 Then

            If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
                cWork = Mid(Trim(Str(num)), 1, InStr(1, Trim(Str(num)), ".", 0) - 1)
            Else
                cWork = Str(num)
            End If
            nMODULUS = Int(Len(Trim(cWork)) / 3)
            nMODULUS = Len(Trim(cWork)) - (nMODULUS * 3)

            If nMODULUS > 0 Then
                cWork = cWork.Trim
                cWork = cWork.PadLeft(CInt(3 - nMODULUS) + CInt(cWork.Length()), "0")
            End If
            nK = (Len(Trim(cWork)) / 3) - 1

            nI = 1
            Do While nI < Len(Trim(cWork)) - 1
                cCENTENA = Mid(Trim(cWork), nI, 1)
                cDECENA = Mid(Trim(cWork), nI + 1, 1)
                cUNIDAD = Mid(Trim(cWork), nI + 2, 1)

                If cCENTENA <> "0" Then
                    If cCENTENA = "1" Then
                        cLET = cLET & "Cien "
                        If cDECENA <> "0" Or cUNIDAD <> "0" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "to "
                        End If
                    Else
                        If cCENTENA = 2 Or cCENTENA = 3 Then
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "cientos "
                        Else
                            cLET = cLET & Trim(Mid(Lit1, ((Val(cCENTENA) - 1) * 7) + 1, 7)) & "ientos "
                        End If
                    End If
                End If

                If cDECENA <> "0" Then
                    If cDECENA = "1" And cUNIDAD <> "0" Then
                        If ((Val(cUNIDAD) - 1) * 10) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit3, ((Val(cUNIDAD) - 1) * 10) + 1, 10))
                    Else
                        If ((Val(cDECENA) - 1) * 9) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit2, ((Val(cDECENA) - 1) * 9) + 1, 9))
                    End If
                End If

                If cUNIDAD <> "0" Then
                    If cDECENA > "1" Then
                        'MODIFICADO PARA VER EL TEXTO CON LA Y GRIEGA
                        If cDECENA = "2" Then
                            cLET = Mid(cLET, 1, (Len(cLET) - 1)) & "i"
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        Else
                            cLET = cLET & " y "
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + LCase(Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6)))
                        End If
                    Else
                        If cDECENA < "1" Then
                            If ((Val(cUNIDAD) - 1) * 6) + 1 > 0 Then cLET = cLET + Trim(Mid(Lit4, ((Val(cUNIDAD) - 1) * 6) + 1, 6))
                        End If
                    End If
                End If
                cLET = cLET & " "
                'Pone Miles o Millones
                If nK > 0 Then
                    If cCENTENA & cDECENA & cUNIDAD = "001" Then
                        cLET = Mid(cLET, 1, Len(cLET) - 2) & " "
                    End If
                    nMODULUS = Int(nK / 2)
                    nMODULUS = nK - (nMODULUS * 2)
                    If nMODULUS = 0 Then
                        cLET = cLET + Trim(Mid(Lit5, (((nK / 2) - 1) * 10) + 1, 10))

                        If cCENTENA & cDECENA & cUNIDAD = "001" And num > 2999999 Then
                            cLET = cLET & "es "
                        Else
                            cLET = cLET & " "
                        End If
                    Else
                        If cCENTENA & cDECENA & cUNIDAD > "000" Then
                            cLET = cLET & "Mil "
                        End If
                    End If
                    nK = nK - 1
                End If
                nI = nI + 3
            Loop

            cLET = cLET & "con "

        End If
        If InStr(1, Trim(Str(num)), ".", 0) > 0 Then
            cLET = cLET + Mid(Trim(Format(num, ".00")), InStr(1, Trim(Format(num, ".00")), ".", 0) + 1, 2) & "/100" & " "
        Else
            cLET = cLET + "00/100" & " "
        End If
        NUMEROLETRASFACTURACION = cLET

    End Function

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        DatosAdicionales()
        If CodigoPlanilla = String.Empty Or CodigoLetra = String.Empty Or CodigoCliente = String.Empty Then Exit Sub
        CargarDetallesLetra(CodigoPlanilla, CodigoLetra, CodigoCliente, NombreCliente, CodigoRuc)
        pnlLetraAdicionales.Visible = False
        PnlDocumentos.Enabled = True
        Limpiar()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        pnlLetraAdicionales.Visible = False
        PnlDocumentos.Enabled = True
        Limpiar()
    End Sub

    Private Sub txtruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtruc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnombreAval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreAval.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnrodocAval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnrodocAval.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtdireccAval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccAval.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txttelefonoAval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoAval.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnombreReprAval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreReprAval.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtbanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbanco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtoficina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtoficina.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcuenta_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtnombreRepresentante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreRepresentante.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtNroFacturas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacturas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0 'TODOS
                gbRangofechas.Enabled = False
            Case 1 'MES DE PROCESO
                gbRangofechas.Enabled = False
            Case 2 'RANGO DE FECHAS
                gbRangofechas.Enabled = True
            Case 3 'POR NUMERO DE LETRA
                gbRangofechas.Enabled = False
            Case 4 'EMITIDO
                gbRangofechas.Enabled = True
            Case 5 'ACEPTADO
                gbRangofechas.Enabled = True
            Case 6 'ANULADO
                gbRangofechas.Enabled = True
            Case 7 'POR RECOGER
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosPlanilla()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPlanilla()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPlanilla()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim CodigoPlanilla As String = String.Empty
        Dim EstadoPlanilla As String = String.Empty
        Dim CodigoCliente As String = String.Empty
        Dim monto_debe_ft As Double, monto_haber_ft As Double
        Dim monto_debe_nc As Double, monto_haber_nc As Double
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub

        CodigoPlanilla = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        EstadoPlanilla = dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value
        CodigoCliente = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value


        If EstadoPlanilla = "EMITIDO" Or EstadoPlanilla = "POR RECOGER" Then
            ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
            Dim dtClienteVendedor As New DataTable
            dtClienteVendedor = ClsCobranzaBl.Saldo_planilla_canje(CodigoPlanilla)
            If dtClienteVendedor.Rows.Count() > 0 Then
                For i As Integer = 0 To dtClienteVendedor.Rows.Count - 1
                    If dtClienteVendedor.Rows(i).Item("AMOUNT_BALANCE") < dtClienteVendedor.Rows(i).Item("AMOUNT") Then
                        MsgBox("El documento " & dtClienteVendedor.Rows(i).Item("TYPE_DOC") & "-" & dtClienteVendedor.Rows(i).Item("NUMBER_DOC") & Chr(13) & "no tiene saldo para aceptar el canje. Verifique!! ", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Next
            End If

            If MessageBox.Show("¿Desea Aceptar la Planilla de Letra(s)  Nro: " & CodigoPlanilla & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ''verificacion
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                'Dim dtClienteVendedor As New DataTable
                Dim SQL As String = String.Empty
                SQL = "Select * from CUSTOMER WHERE ID='" & CodigoCliente & "'"
                dtClienteVendedor = clsLetrasBl.VerificacionClienteVendedor(SQL)
                If dtClienteVendedor.Rows.Count() = 0 Then
                    MsgBox("No exixten datos con el Cliente", MsgBoxStyle.Information)
                    Pnlcontabilidad.Visible = False
                    PnlDocumentos.Enabled = True
                    Exit Sub
                End If
                Dim dtAccepLetra_Contab As New DataTable
                SQL = "SELECT IS_ACCEPT_CONT FROM NUMBER_DOCUMENT  WHERE TYPE_DOC='LT'"
                dtAccepLetra_Contab = clsLetrasBl.VerificacionClienteVendedor(SQL)
                If dtAccepLetra_Contab.Rows.Count() <> 0 Then
                    If dtAccepLetra_Contab.Rows(0).Item("IS_ACCEPT_CONT").ToString = "N" Then
                        If clsLetrasBl.GeneracionAceptacionLetra(CodigoPlanilla) Then
                            MsgBox("Aceptacion de letra generada Correctamente.", MsgBoxStyle.Information)
                            DocumentosPlanilla()
                        Else
                            MsgBox("Hubo un error en la Aceptacion de la Letra.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If

                        Exit Sub
                    End If
                End If

                PnlDocumentos.Enabled = False
                Pnlcontabilidad.Visible = True
                GenerarColummnaDataTableAsientoContable()
                txtTotalDebe.Text = "0.00"
                txttotalHaber.Text = "0.00"
                ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
                dtDetallesLetra = New DataTable("Contabilizar")
                dtDetallesLetra = ClsCobranzaBl.DetallesLetras(CodigoPlanilla)
                Dim mon As Integer = 0
                Dim monto, TipoC As Double
                Dim Is_orig, cta12_Clientes, Des_cta_corriente As String
                Dim ruc, tdoc, sdoc, ndoc As String
                Dim _CodigoCliente As String = String.Empty
                Dim _CuentaCliente As String = String.Empty
                Dim Dtverificar As New DataTable

                If dtDetallesLetra.Rows.Count() <> 0 Then
                    For i As Integer = 0 To dtDetallesLetra.Rows.Count() - 1
                        ruc = String.Empty
                        tdoc = String.Empty
                        sdoc = String.Empty
                        ndoc = String.Empty
                        mon = 0
                        monto = 0
                        TipoC = 0
                        Is_orig = String.Empty
                        cta12_Clientes = String.Empty
                        Des_cta_corriente = String.Empty

                        dtpfechaaceptacion.Value = dtDetallesLetra.Rows(i)("DATE_EXCHANGE").ToString()

                        mon = IIf(dtDetallesLetra.Rows(i)("CURRENCY_ID").ToString() = "MN", 1, 2)
                        monto = Math.Round(Double.Parse(dtDetallesLetra.Rows(i)("AMOUNT").ToString()), 2)
                        Is_orig = dtDetallesLetra.Rows(i)("IS_ORIG").ToString()
                        ruc = dtDetallesLetra.Rows(i)("VAT_REGISTRATION").ToString()
                        tdoc = dtDetallesLetra.Rows(i)("TYPE_DOC").ToString()
                        If tdoc <> "LT" Then
                            sdoc = Strings.Left(dtDetallesLetra.Rows(i)("NUMBER_DOC").ToString(), 3)
                            ndoc = Strings.Right(dtDetallesLetra.Rows(i)("NUMBER_DOC").ToString(), 7)
                        Else
                            sdoc = ""
                            ndoc = dtDetallesLetra.Rows(i)("NUMBER_DOC").ToString()
                        End If
                        TipoC = dtDetallesLetra.Rows(i)("SELL_RATE").ToString()
                        _TIPO_CAMBIO_PLANILLA = TipoC


                        Dim subd As String = "02" '//ventas
                        Dim tanexo As Integer = 1 '//clientes
                        If Is_orig = "S" Then

                            _CodigoCliente = dtDetallesLetra.Rows(i)("CUSTOMER_ID").ToString()
                            ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
                            Dtverificar = ClsCobranzaBl.VerificarCuenta_LETRAS(_CodigoCliente, tdoc, sdoc, ndoc)

                            If Dtverificar.Rows.Count <> 0 Then
                                _CuentaCliente = String.Empty
                                cta12_Clientes = Dtverificar.Rows(0).Item("ACCOUNT").ToString
                                Des_cta_corriente = Dtverificar.Rows(0).Item("DES_CUENTA1").ToString
                            Else
                                cta12_Clientes = ""
                                Des_cta_corriente = ""
                            End If
                        Else
                            Dtverificar = ClsCobranzaBl.VerificarCuentaContableEstadoInicialletra("CR", IIf(mon = 1, "MN", "ME"))
                            If Dtverificar.Rows.Count <> 0 Then
                                _CuentaCliente = String.Empty
                                cta12_Clientes = Dtverificar.Rows(0).Item("ACCOUNT").ToString
                                Des_cta_corriente = Dtverificar.Rows(0).Item("DES_CUENTA1").ToString
                            Else
                                cta12_Clientes = ""
                                Des_cta_corriente = ""
                            End If
                        End If
                        Dim row As DataRow = dtdetalleAsiento.NewRow
                        row("AD_IDCAB") = 0
                        row("AD_SECUENCIA") = dtDetallesLetra.Rows.Count() + 1
                        row("AD_CUENTA") = cta12_Clientes
                        row("DESC_CUENTA") = Des_cta_corriente
                        row("AD_TANEXO") = tanexo
                        row("AD_IDANEXO") = ruc
                        row("AD_TDOC") = tdoc
                        row("AD_SDOC") = sdoc
                        row("AD_NDOC") = ndoc
                        row("AD_FDOC") = dtDetallesLetra.Rows(i)("DATE_EXCHANGE").ToString()
                        row("AD_VDOC") = dtDetallesLetra.Rows(i)("CADUCATE_DATE").ToString()
                        If Is_orig = "S" Then
                            If tdoc = "NC" Then
                                row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, monto, monto * TipoC), 2))
                                row("AD_HABER") = 0
                            Else
                                row("AD_DEBE") = 0
                                row("AD_HABER") = Math.Abs(Math.Round(IIf(mon = 1, monto, monto * TipoC), 2))
                            End If
                        Else
                            row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, monto, monto * TipoC), 2))
                            row("AD_HABER") = 0
                        End If
                        row("AD_TCAM") = CDbl(dtDetallesLetra.Rows(i)("SELL_RATE").ToString())
                        row("AD_SEC_ORI_DES") = 0
                        row("AD_IDCC") = ""
                        row("AD_ES_DESTINO") = 0
                        row("AD_IDMEDIOPAGO") = ""
                        row("AD_MONTO_ORI") = Math.Round(monto, 2)
                        row("AD_PORCE_DESTINO") = 0
                        row("AD_ES_CONCI") = 0
                        row("AD_MES_CONCI") = 0
                        row("AD_ES_INAFECTO") = 0
                        row("AD_IDMONEDA") = mon
                        row("AD_TDOC_REF") = ""
                        row("AD_SDOC_REF") = ""
                        row("AD_NDOC_REF") = "" 'CodigoPlanilla '.PadLeft(15, Char.Parse("0"))
                        row("AD_FDOC_REF") = ""
                        row("AD_VDOC_REF") = ""
                        row("AD_GLOSA") = "ACEPTACION DE LETRAS DE CLIENTE PLANILLA N° " & CodigoPlanilla
                        dtdetalleAsiento.Rows.Add(row)
                        dtdetalleAsiento.AcceptChanges()
                    Next
                    monto_debe_ft = IIf(IsDBNull(dtdetalleAsiento.Compute("sum(AD_DEBE)", "AD_TDOC='LT'")), 0, dtdetalleAsiento.Compute("sum(AD_DEBE)", "AD_TDOC='LT'"))
                    monto_haber_ft = IIf(IsDBNull(dtdetalleAsiento.Compute("sum(AD_HABER)", "AD_TDOC<>'NC'")), 0, dtdetalleAsiento.Compute("sum(AD_HABER)", "AD_TDOC<>'NC'"))
                    monto_debe_nc = IIf(IsDBNull(dtdetalleAsiento.Compute("sum(AD_DEBE)", "AD_TDOC='NC'")), 0, dtdetalleAsiento.Compute("sum(AD_DEBE)", "AD_TDOC='NC'"))
                    monto_haber_nc = 0
                    txtTotalDebe.Text = monto_debe_ft ' + monto_debe_nc 'dtdetalleAsiento.Compute("sum(AD_DEBE)", "")
                    txttotalHaber.Text = monto_haber_ft - monto_debe_nc 'dtdetalleAsiento.Compute("sum(AD_HABER)", "")
                    txtTotalDebe.Text = Format(CType(txtTotalDebe.Text, Decimal), "##,##00.00")
                    txttotalHaber.Text = Format(CType(txttotalHaber.Text, Decimal), "##,##00.00")
                    'dtpfechaaceptacion.Value = Date.Now
                    dgvDetalleAsiento.Focus()
                End If
            End If
        ElseIf EstadoPlanilla = "ACEPTADO" Then
            MsgBox("La Planilla ya se encuentra Aceptado", MsgBoxStyle.Information)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        ElseIf EstadoPlanilla = "ANULADO" Then
            MsgBox("La Planilla ya se encuentra Anulada", MsgBoxStyle.Information)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        ElseIf EstadoPlanilla = "CANCELADO" Then
            MsgBox("La Planilla ya se encuentra Cancelada", MsgBoxStyle.Information)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        End If
    End Sub




    Private Sub cmb_moneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_moneda.SelectedIndexChanged
        'AgregarLetra(CInt(txtNLetras.Text))
        If cmb_moneda.SelectedIndex > -1 Then
            If cmb_moneda.SelectedValue = "ME" Then
                dgvDetalleLetra.Columns(5).ReadOnly = False
                dgvDetalleLetra.Columns(4).ReadOnly = True
            ElseIf cmb_moneda.SelectedValue = "MN" Then
                dgvDetalleLetra.Columns(4).ReadOnly = False
                dgvDetalleLetra.Columns(5).ReadOnly = True
            End If
        End If
    End Sub

    Private Sub MostrarBancos()
        Dim frm As New frmBuscar
        Try
            Dim sql As String = String.Empty
            sql = "LETRA_SP_S_BANK"
            frm.CadenaConsulta = sql
            frm.Titulo = "Bancos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtbanco.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionBanco.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                If String.IsNullOrEmpty(txtbanco.Text) Then
                    cboCuenta.DataSource = Nothing
                    Exit Sub
                End If
                frm.Close()
                MostrandoCuentasBancos(txtbanco.Text)
            Else
                txtbanco.Text = String.Empty
                txtdescripcionBanco.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoCuentasBancos(ByVal codigoBank As String)
        Try
            Dim BuscarBl As New ClsBuscar
            Dim dtBancoCuenta As DataTable
            dtBancoCuenta = New DataTable
            dtBancoCuenta = BuscarBl.CuentasBancos(codigoBank)
            cboCuenta.DataSource = Nothing
            If dtBancoCuenta.Rows.Count() <> 0 Then
                cboCuenta.ValueMember = "CODIGO"
                cboCuenta.DisplayMember = "DESCRIPCION"
                cboCuenta.DataSource = dtBancoCuenta
            Else
                cboCuenta.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtbanco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtbanco.MouseDoubleClick
        MostrarBancos()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub dataGridView_EditingControl(ByVal sender As Object, _
ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleLetra.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Key
    End Sub


    Private Sub SoloNumeros_Key(ByVal sender As Object, _
  ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetalleLetra.CurrentCell.ColumnIndex
        If columna = 4 Or columna = 5 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ".") And (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msj As String
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        Dim CodigoPlanilla As String = String.Empty
        Dim Usuario As String = String.Empty
        CodigoPlanilla = dgvPlanilla.CurrentRow.Cells("Codigo").Value

        If dgvPlanilla.CurrentRow.Cells("Estado_Contable").Value = "CONTABILIZADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta CONTABILIZADO, no se puede Eliminar."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ACEPTADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta ACEPTADO, no se puede Eliminar."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta ANULADO, no se puede Eliminar."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub

        End If

        If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If String.IsNullOrEmpty(CodigoPlanilla) Then Exit Sub
            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
            Me.Cursor = Cursors.WaitCursor
            Dim LetraBl As New ClsOperaciones.LETTER_EXCHANGE
            If LetraBl.ConsultandoDocEliminacion(CodigoPlanilla, LibComunVar.ClsVarComun.USUARIO) = True Then
                DocumentosPlanilla()
                MsgBox("Eliminación generado correctamente", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_retornar_Click(sender As Object, e As EventArgs) Handles btn_retornar.Click
        PnlDocumentos.Enabled = True
        Pnlcontabilidad.Visible = False
        txtTotalDebe.Text = "0.00"
        txttotalHaber.Text = "0.00"
    End Sub


    Private Sub ImprimirVoucher(ByRef _DOCUMENT_ID As String)
        Try
            ''Imprimiendo
            If MessageBox.Show("¿Desea imprimir el Documento ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                reporteBL = New ClsBuscar
                crystalBL = New LibReportes.ClsReporte
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("CONSULTA_ASIENTO")
                Dim SQL As String = String.Empty
                SQL = "SELECT *  FROM DBO.CO_TB_ASIENTO_CAB WHERE AC_IDSUBDIARIO = '09'   AND AC_ID_LETRA ='" & _DOCUMENT_ID & "'"
                dtImprimir = reporteBL.EjecutarConsulta(SQL)
                If dtImprimir.Rows.Count() <> 0 Then
                    Dim CodAsiento As String = dtImprimir.Rows(0).Item("AC_ID").ToString
                    reporteBL = New ClsBuscar
                    dtImprimir = New DataTable("REPORTE_LETRA_CAJA")
                    dtImprimir = reporteBL.EjecutarReporteVoucher(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                        crystalBL.Muestra_Reporte("rpt_AsientoContable_Comprobante.rpt", dtImprimir, "", "", "@AC_ID;" & CodAsiento)
                    End If
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Numero_Voucher()
        Dim fecha As DateTime = DateTime.Parse(dtpfechaaceptacion.Value)
        Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
        _numero_asiento = ac.get_Ult_num_voucher("09", fecha.Year, Format(fecha.Month, "00"))
        ac = Nothing
    End Sub
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim Flag As Boolean = False

        For j As Integer = 0 To dtdetalleAsiento.Rows.Count() - 1
            If String.IsNullOrEmpty(dtdetalleAsiento.Rows(j).Item("AD_CUENTA").ToString) Then
                Flag = True
                Exit For
            End If
        Next
        If Flag = True Then
            MsgBox("Debe ingresar las Cuentas Contables para todos los registros.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        Dim CodigoPlanilla As String = String.Empty
        Dim EstadoPlanilla As String = String.Empty
        Dim CodigoCliente As String = String.Empty
        Dim MonedaPlanilla As String = String.Empty
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        
        CodigoPlanilla = dgvPlanilla.CurrentRow.Cells("Codigo").Value
        EstadoPlanilla = dgvPlanilla.CurrentRow.Cells("Estado").Value
        CodigoCliente = dgvPlanilla.CurrentRow.Cells("CodCliente").Value
        MonedaPlanilla = dgvPlanilla.CurrentRow.Cells("Moneda").Value

        clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
        ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
        Dim dtAceptacionLetra As DataTable
        dtAceptacionLetra = New DataTable
        Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
        Dim ClsasientoBlCob As New LibContabilidad.ClsOperaciones.Asiento_Contable
        Dim dtcodigo As New DataTable

        If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call Cargar_Numero_Voucher()
        Else
            Dim codigo As String = String.Empty
            codigo = InputBox("Ingrese numero de asiento")
            If codigo = String.Empty Then
                MsgBox("Es necesario una numeracion.", MsgBoxStyle.Information)
                Exit Sub
            End If
            codigo = Format(dtpfechaaceptacion.Value.Month, "00") & codigo.PadLeft(4, Char.Parse("0"))
            dtcodigo = ClsasientoBl.ValidarCodigo_Canje_Letras_Cobros("09", codigo, dtpfechaaceptacion.Value.Year, dtpfechaaceptacion.Value.Month)
            If dtcodigo.Rows.Count() <> 0 Then
                MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                _numero_asiento = codigo
            End If
        End If

        'For j As Integer = 0 To dtdetalleAsiento.Rows.Count() - 1
        '    If dtdetalleAsiento.Rows(j).Item("AD_TDOC").ToString = "LT" Then
        '        dtcodigo = ClsasientoBlCob.ValidarCuentaContable_EstadoLetra(dtdetalleAsiento.Rows(j).Item("AD_CUENTA").ToString, IIf(dtdetalleAsiento.Rows(j).Item("AD_IDMONEDA").ToString = 1, "MN", "ME"))
        '        If dtcodigo.Rows.Count() = 0 Then
        '            Flag = True
        '            Exit For
        '        Else
        '            Flag = False
        '        End If
        '    End If
        'Next
        'If Flag = True Then
        '    MsgBox("Las Cuentas Contables ingresadas no pertenecen a ningún estado de las Letras por cobrar.", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        If ClsCobranzaBl.Contabilizar_Caja_Letra(CodigoPlanilla, dtdetalleAsiento, _numero_asiento, dtpfechaaceptacion.Value, MonedaPlanilla, _TIPO_CAMBIO_PLANILLA) = True Then
            ImprimirVoucher(CodigoPlanilla)
        End If

        If clsLetrasBl.GeneracionAceptacionLetra(CodigoPlanilla) Then
            MsgBox("Aceptacion de letra generada Correctamente.", MsgBoxStyle.Information)
            DocumentosPlanilla()
        Else
            MsgBox("Hubo un error en la Aceptacion de la Letra.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        PnlDocumentos.Enabled = True
        Pnlcontabilidad.Visible = False
        txtTotalDebe.Text = "0.00"
        txttotalHaber.Text = "0.00"
    End Sub

    Private Sub Ayuda_CuentaContable(Optional ByVal _CodigoCuentaContable As String = "")
        Try
            Dim frm As New frmBuscar
            If _CodigoCuentaContable = String.Empty Then
                Dim sql As String = String.Empty
                sql = "CO_SP_S_PLANCTAS_MOV"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = Date.Now.Year
                frm.Titulo = "Plan de Cuentas Contable"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    dgvDetalleAsiento.Item(2, dgvDetalleAsiento.CurrentRow.Index).Value = frm.Data_Matriz.Rows(0).Item(0).ToString
                    dgvDetalleAsiento.Item(3, dgvDetalleAsiento.CurrentRow.Index).Value = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
            Else
                Dim AsientoContableCabs As New LibContabilidad.ClsOperaciones.Asiento_Contable
                Dim DtDatos As New DataTable("CuentaContable")
                DtDatos = AsientoContableCabs.Get_ManualCuentaContable(_CodigoCuentaContable)
                Dim codArticulo As String = String.Empty
                If DtDatos.Rows.Count() <> 0 Then
                    dgvDetalleAsiento.Item(2, dgvDetalleAsiento.CurrentRow.Index).Value = DtDatos.Rows(0).Item(0).ToString
                    dgvDetalleAsiento.Item(3, dgvDetalleAsiento.CurrentRow.Index).Value = DtDatos.Rows(0).Item(1).ToString
                Else
                    Dim sql As String = String.Empty
                    sql = "CO_SP_S_PLANCTAS_MOV"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = Date.Now.Year
                    frm.Titulo = "Plan de Cuentas Contable"
                    frm._Cadena_Filtro = _CodigoCuentaContable
                    frm.ShowDialog()
                    If frm.Data_Matriz.Rows.Count > 0 Then
                        dgvDetalleAsiento.Item(2, dgvDetalleAsiento.CurrentRow.Index).Value = frm.Data_Matriz.Rows(0).Item(0).ToString
                        dgvDetalleAsiento.Item(3, dgvDetalleAsiento.CurrentRow.Index).Value = frm.Data_Matriz.Rows(0).Item(1).ToString
                        frm.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvDetalleAsiento_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetalleAsiento.CellMouseDoubleClick
        If e.ColumnIndex = 2 Then
            Ayuda_CuentaContable()
        End If
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        Dim msj As String
        If dgvPlanilla.RowCount() = 0 Then Exit Sub
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        Dim CodigoPlanilla As String = dgvPlanilla.CurrentRow.Cells("Codigo").Value

        If dgvPlanilla.CurrentRow.Cells("Estado_Contable").Value = "CONTABILIZADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta CONTABILIZADO, no se puede Anular."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ACEPTADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta ACEPTADO, no se puede Anular."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & CodigoPlanilla & vbCrLf & " esta ANULADO, no se puede Anular."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub

        End If

        If MessageBox.Show("Se va a anular el registro" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim LetraBl As New ClsOperaciones.LETTER_EXCHANGE
            If LetraBl.ConsultandoDocAnulacion(CodigoPlanilla, LibComunVar.ClsVarComun.USUARIO) = True Then
                DocumentosPlanilla()
                MsgBox("Anulacion generado correctamente", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub dgvDetalleAsiento_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleAsiento.CellEndEdit
        If e.ColumnIndex = 2 Then
            If String.IsNullOrEmpty(dgvDetalleAsiento.Item(2, dgvDetalleAsiento.CurrentRow.Index).Value.ToString) Then
                Ayuda_CuentaContable()
            Else
                Ayuda_CuentaContable(dgvDetalleAsiento.Item(2, dgvDetalleAsiento.CurrentRow.Index).Value)
            End If
        End If
    End Sub


    Private Sub dtpfechaaceptacion_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaaceptacion.KeyDown
        If e.KeyCode = Keys.Enter Then btn_generar.Focus()
    End Sub
 
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If dgvPlanilla.Rows.Count() = 0 Then Exit Sub
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        EstadoPlanilla = String.Empty
        CodigoPlanilla = String.Empty
        Dim estado_contable As String = String.Empty
        CodigoPlanilla = dgvPlanilla.CurrentRow.Cells("Codigo").Value
        EstadoPlanilla = dgvPlanilla.CurrentRow.Cells("Estado").Value
        estado_contable = dgvPlanilla.CurrentRow.Cells("Estado_Contable").Value
        If EstadoPlanilla = "EMITIDO" Then Exit Sub
        If estado_contable = "CONTABILIZADO" Then Exit Sub
        If EstadoPlanilla = "ANULADO" Then Exit Sub
        If EstadoPlanilla = "CANCELADO" Then Exit Sub

        If MessageBox.Show("Se va a cambiar el estado del registro" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim clsletraPay As New ClsOperaciones.LETTER_EXCHANGE_PAY
            If clsletraPay.CambioEstadoLetraCobranza(CodigoPlanilla) = True Then
                MsgBox("Se cambio de estado correctamente.", MsgBoxStyle.Information, "Sistemas")
                DocumentosPlanilla()
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        '///inicio validacion
        Dim msj As String
        If dgvPlanilla.RowCount() = 0 Then Exit Sub
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        Dim Cod_planilla As String = dgvPlanilla.CurrentRow.Cells("Codigo").Value

        If dgvPlanilla.CurrentRow.Cells("Estado_Contable").Value = "CONTABILIZADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & Cod_planilla & vbCrLf & " esta CONTABILIZADO, no procede ningun cambio."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ACEPTADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & Cod_planilla & vbCrLf & " esta ACEPTADO, no procede ningun cambio."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf dgvPlanilla.CurrentRow.Cells("Estado").Value = "ANULADO" Then
            msj = String.Empty
            msj = "      La Planilla de Canje N° " & Cod_planilla & vbCrLf & " esta ANULADO, no procede ningun cambio."
            MsgBox(msj, MsgBoxStyle.Exclamation)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        '/// fin de validacion


        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvLetra.Item(0, dgvLetra.CurrentRow.Index).Value.ToString) Or String.IsNullOrEmpty(dgvLetra.Item(1, dgvLetra.CurrentRow.Index).Value.ToString) Then Exit Sub
        If dgvLetra.Item(1, dgvLetra.CurrentRow.Index).Value.ToString <> "LT" Then Exit Sub
        CodigoPlanilla = String.Empty
        CodigoLetra = String.Empty
        NombreCliente = String.Empty
        CodigoCliente = String.Empty
        CodigoRuc = String.Empty
        'Asignacion
        CodigoPlanilla = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        CodigoLetra = dgvLetra.Item(2, dgvLetra.CurrentRow.Index).Value
        NombreCliente = dgvPlanilla.Item(2, dgvPlanilla.CurrentRow.Index).Value
        CodigoCliente = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value
        CodigoRuc = dgvPlanilla.Item(7, dgvPlanilla.CurrentRow.Index).Value
        f_vcto_actual = dgvLetra.CurrentRow.Cells("FechaVencimiento").Value
        txt_nvo_num_letra.Text = String.Empty
        f_vcto_nuevo = f_vcto_actual
        Panelvcto.Visible = True
        PnlDocumentos.Enabled = False
        txtnumletra.Text = ""
        txtnumletra.Text = CodigoLetra
        dtvctoactual.Value = f_vcto_actual
        dtvctonuevo.Value = f_vcto_actual

        PnlDocumentos.Enabled = False
        PnlFiltros.Enabled = False
        ToolStrip1.Enabled = False

        txt_nvo_num_letra.Focus()
    End Sub

    Private Sub btncancelarvcto_Click(sender As Object, e As EventArgs) Handles btncancelarvcto.Click
        Panelvcto.Visible = False
        PnlDocumentos.Enabled = True

        PnlDocumentos.Enabled = True
        PnlFiltros.Enabled = True
        ToolStrip1.Enabled = True
    End Sub

    Private Sub btnconfirmarvcto_Click(sender As Object, e As EventArgs) Handles btnconfirmarvcto.Click
        If txt_nvo_num_letra.Text <> "" Then
            If txtnumletra.Text.Trim = txt_nvo_num_letra.Text.Trim Then
                MsgBox("El número de Letra ingresado es igual al anterior. Verifique", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Validar_Numero_Letra(txt_nvo_num_letra.Text) = False Then
                MsgBox("El número de Letra " & txt_nvo_num_letra.Text & " ya existe, verifique", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        
        Try
            If MessageBox.Show("Se va a proceder a la actualización de la Letra." & vbCrLf & "¿Desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE
                Dim CONSULTA As String = String.Empty
                If txt_nvo_num_letra.Text.Trim = "" Then
                    CONSULTA = "UPDATE dbo.LETTER_EXCHANGE_LINE SET CADUCATE_DATE='" & dtvctonuevo.Value.ToString("dd/MM/yyyy") & "' WHERE ID='" & CodigoPlanilla & "' AND TYPE_DOC='LT' AND NUMBER_DOC='" & CodigoLetra & "'"
                ElseIf txt_nvo_num_letra.Text.Trim <> "" Then
                    CONSULTA = "UPDATE dbo.LETTER_EXCHANGE_LINE SET NUMBER_DOC='" & txt_nvo_num_letra.Text.Trim & "', CADUCATE_DATE='" & dtvctonuevo.Value.ToString("dd/MM/yyyy") & "' WHERE ID='" & CodigoPlanilla & "' AND TYPE_DOC='LT' AND NUMBER_DOC='" & CodigoLetra & "'"
                End If
                'CONSULTA = "UPDATE dbo.LETTER_EXCHANGE_LINE SET NUMBER_DOC='" & txt_nvo_num_letra.Text.Trim & "', CADUCATE_DATE='" & dtvctonuevo.Value.ToString("dd/MM/yyyy") & "' WHERE ID='" & CodigoPlanilla & "' AND TYPE_DOC='LT' AND NUMBER_DOC='" & CodigoLetra & "'"
                clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                    MsgBox("Actualizado exitosamente.", MsgBoxStyle.Information)
                    btncancelarvcto_Click(sender, e)
                Else
                    MsgBox("No se llego a modificar los datos de la Letra. Verifique", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub dgvPlanilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPlanilla.CellFormatting
        If dgvPlanilla.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvPlanilla.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvPlanilla.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvPlanilla.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvPlanilla.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub


    Private Sub txt_nvo_num_letra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nvo_num_letra.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtvctonuevo.Focus()
        End If
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPlanilla()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim CodigoPlanilla As String = String.Empty
        Dim EstadoPlanilla As String = String.Empty
        Dim EstadoPlanilla_Contabilizada As String = String.Empty
        Dim CodigoCliente As String = String.Empty
        Dim MonedaPlanilla As String = String.Empty
        Dim FechaPlanilla As String = String.Empty

        Try
            If dgvPlanilla.Rows.Count = 0 Then Exit Sub
            If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub

            If String.IsNullOrEmpty(dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub
            If String.IsNullOrEmpty(dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub

            If MessageBox.Show("¿Desea Aceptar la(s) Letra(s) de los canjes filtrados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For x As Integer = 0 To dgvPlanilla.Rows.Count - 1
                    'CodigoPlanilla = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
                    'EstadoPlanilla = dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value
                    'CodigoCliente = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value

                    CodigoPlanilla = dgvPlanilla.Rows(x).Cells("Codigo").Value
                    EstadoPlanilla = dgvPlanilla.Rows(x).Cells("Estado").Value
                    EstadoPlanilla_Contabilizada = dgvPlanilla.Rows(x).Cells("Estado_Contable").Value
                    CodigoCliente = dgvPlanilla.Rows(x).Cells("CodCliente").Value
                    MonedaPlanilla = dgvPlanilla.Rows(x).Cells("Moneda").Value
                    FechaPlanilla = dgvPlanilla.Rows(x).Cells("Fecha_Canje").Value

                    'If CodigoPlanilla = "001245" Then
                    '    MsgBox(" Planilla N° " & CodigoPlanilla, MsgBoxStyle.Information)
                    'End If
                    If EstadoPlanilla = "ACEPTADO" And EstadoPlanilla_Contabilizada = "" Then
                        Me.Cursor = Cursors.WaitCursor
                        GenerarColummnaDataTableAsientoContable()
                        ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
                        dtDetallesLetra = New DataTable("Contabilizar")
                        dtDetallesLetra = ClsCobranzaBl.DetallesLetras(CodigoPlanilla)
                        Dim mon As Integer = 0
                        Dim mon_origen As Integer = 0
                        Dim monto, TipoCPLanilla As Double, TipoCDocumento As Double
                        Dim Is_orig, cta12_Clientes, Des_cta_corriente As String
                        Dim ruc, tdoc, sdoc, ndoc As String
                        Dim _CodigoCliente As String = String.Empty
                        Dim _CuentaCliente As String = String.Empty
                        Dim Dtverificar As New DataTable

                        If dtDetallesLetra.Rows.Count() <> 0 Then
                            For i As Integer = 0 To dtDetallesLetra.Rows.Count() - 1
                                ruc = String.Empty
                                tdoc = String.Empty
                                sdoc = String.Empty
                                ndoc = String.Empty
                                mon = 0
                                mon_origen = 0
                                monto = 0
                                TipoCPLanilla = 0
                                TipoCDocumento = 0
                                Is_orig = String.Empty
                                cta12_Clientes = String.Empty
                                Des_cta_corriente = String.Empty

                                dtpfechaaceptacion.Value = dtDetallesLetra.Rows(i)("DATE_EXCHANGE").ToString()
                                Is_orig = dtDetallesLetra.Rows(i)("IS_ORIG").ToString()
                                mon = IIf(dtDetallesLetra.Rows(i)("CURRENCY_ID").ToString() = "MN", 1, 2)
                                monto = Math.Round(Double.Parse(dtDetallesLetra.Rows(i)("AMOUNT").ToString()), 2)
                                If Is_orig = "S" Then
                                    mon_origen = IIf(dtDetallesLetra.Rows(i)("MONEDA_ORIGEN").ToString() = "MN", 1, 2)
                                Else
                                    mon_origen = IIf(dtDetallesLetra.Rows(i)("CURRENCY_ID").ToString() = "MN", 1, 2)
                                End If
                                ruc = dtDetallesLetra.Rows(i)("VAT_REGISTRATION").ToString()
                                tdoc = dtDetallesLetra.Rows(i)("TYPE_DOC").ToString()
                                If Is_orig = "S" Then
                                    sdoc = dtDetallesLetra.Rows(i)("SERIE_AUX").ToString()
                                    ndoc = dtDetallesLetra.Rows(i)("NUM_DOC_AUX").ToString()
                                Else
                                    sdoc = ""
                                    ndoc = dtDetallesLetra.Rows(i)("NUMBER_DOC").ToString()
                                End If
                                TipoCPLanilla = dtDetallesLetra.Rows(i)("SELL_RATE").ToString()
                                _TIPO_CAMBIO_PLANILLA = TipoCPLanilla

                                Dim subd As String = "02" '//ventas
                                Dim tanexo As Integer = 1 '//clientes
                                If Is_orig = "S" Then
                                    _CodigoCliente = dtDetallesLetra.Rows(i)("CUSTOMER_ID").ToString()
                                    ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
                                    Dtverificar = ClsCobranzaBl.VerificarCuenta_LETRAS(_CodigoCliente, tdoc, sdoc, ndoc)
                                    If Dtverificar.Rows.Count <> 0 Then
                                        _CuentaCliente = String.Empty
                                        cta12_Clientes = Dtverificar.Rows(0).Item("AD_CUENTA").ToString
                                        Des_cta_corriente = "" 'Dtverificar.Rows(0).Item("DES_CUENTA1").ToString
                                        TipoCPLanilla = CDbl(Dtverificar.Rows(0).Item("TIPO_CAMBIO_DOCUMENTO").ToString)
                                    Else
                                        MsgBox("Error de detalle de cuentas." & Chr(13) & " Planilla N° " & CodigoPlanilla, MsgBoxStyle.Exclamation)
                                        cta12_Clientes = ""
                                        Des_cta_corriente = ""
                                        TipoCPLanilla = 0
                                        Continue For
                                    End If
                                Else
                                    'If mon = 1 Then
                                    '    cta12_Clientes = "12301"
                                    '    Des_cta_corriente = ""
                                    '    'TipoCDocumento = _TIPO_CAMBIO_PLANILLA
                                    'ElseIf mon = 2 Then
                                    '    cta12_Clientes = "12302"
                                    '    Des_cta_corriente = ""
                                    '    'TipoCDocumento = _TIPO_CAMBIO_PLANILLA
                                    'End If

                                    Dtverificar = ClsCobranzaBl.VerificarCuentaContableEstadoInicialletra("CR", IIf(mon = 1, "MN", "ME"))
                                    If Dtverificar.Rows.Count <> 0 Then
                                        _CuentaCliente = String.Empty
                                        cta12_Clientes = Dtverificar.Rows(0).Item("ACCOUNT").ToString
                                        Des_cta_corriente = Dtverificar.Rows(0).Item("DES_CUENTA1").ToString
                                    Else
                                        cta12_Clientes = ""
                                        Des_cta_corriente = ""
                                    End If
                                End If
                                Dim row As DataRow = dtdetalleAsiento.NewRow
                                row("AD_IDCAB") = 0
                                row("AD_SECUENCIA") = dtDetallesLetra.Rows.Count() + 1
                                row("AD_CUENTA") = cta12_Clientes
                                row("DESC_CUENTA") = Des_cta_corriente
                                row("AD_TANEXO") = tanexo
                                row("AD_IDANEXO") = ruc
                                row("AD_TDOC") = tdoc
                                row("AD_SDOC") = sdoc
                                row("AD_NDOC") = ndoc
                                If Is_orig = "S" Then
                                    row("AD_FDOC") = dtDetallesLetra.Rows(i)("FECHA_EMISION").ToString()
                                    row("AD_VDOC") = dtDetallesLetra.Rows(i)("FECHA_VCTO").ToString()
                                Else
                                    row("AD_FDOC") = dtDetallesLetra.Rows(i)("DATE_EXCHANGE").ToString()
                                    row("AD_VDOC") = dtDetallesLetra.Rows(i)("CADUCATE_DATE").ToString()
                                End If
                                If Is_orig = "S" Then
                                    If tdoc = "NC" Then
                                        If mon = mon_origen And mon = 1 Then
                                            row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, monto, 0), 2))
                                            row("AD_HABER") = 0
                                        ElseIf mon = mon_origen And mon = 2 Then
                                            row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, 0, monto * TipoCPLanilla), 2))
                                            row("AD_HABER") = 0
                                        ElseIf mon <> mon_origen And mon = 1 Then
                                            row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, (monto / _TIPO_CAMBIO_PLANILLA) * TipoCPLanilla, 0), 2))
                                            row("AD_HABER") = 0
                                        ElseIf mon <> mon_origen And mon = 2 Then
                                            row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, 0, monto * _TIPO_CAMBIO_PLANILLA), 2))
                                            row("AD_HABER") = 0
                                        End If
                                    Else
                                        If mon = mon_origen And mon = 1 Then
                                            row("AD_DEBE") = 0
                                            row("AD_HABER") = Math.Abs(Math.Round(IIf(mon = 1, monto, 0), 2))
                                        ElseIf mon = mon_origen And mon = 2 Then
                                            row("AD_DEBE") = 0
                                            row("AD_HABER") = Math.Abs(Math.Round(IIf(mon = 1, 0, monto * TipoCPLanilla), 2))
                                        ElseIf mon <> mon_origen And mon = 1 Then
                                            row("AD_DEBE") = 0
                                            row("AD_HABER") = Math.Abs(Math.Round(IIf(mon = 1, (monto / _TIPO_CAMBIO_PLANILLA) * TipoCPLanilla, 0), 2))
                                        ElseIf mon <> mon_origen And mon = 2 Then
                                            row("AD_DEBE") = 0
                                            row("AD_HABER") = Math.Abs(Math.Round(IIf(mon = 1, 0, monto * _TIPO_CAMBIO_PLANILLA), 2))
                                        End If
                                    End If
                                Else
                                    row("AD_DEBE") = Math.Abs(Math.Round(IIf(mon = 1, monto, monto * _TIPO_CAMBIO_PLANILLA), 2))
                                    row("AD_HABER") = 0
                                End If
                                row("AD_TCAM") = TipoCPLanilla 'CDbl(dtDetallesLetra.Rows(i)("SELL_RATE").ToString())
                                row("AD_SEC_ORI_DES") = 0
                                row("AD_IDCC") = ""
                                row("AD_ES_DESTINO") = 0
                                row("AD_IDMEDIOPAGO") = ""

                                If mon = mon_origen And mon = 1 Then
                                    row("AD_MONTO_ORI") = Math.Round(monto, 2)
                                ElseIf mon = mon_origen And mon = 2 Then
                                    row("AD_MONTO_ORI") = Math.Round(monto, 2)
                                ElseIf mon <> mon_origen And mon = 1 Then
                                    row("AD_MONTO_ORI") = Math.Round(monto / _TIPO_CAMBIO_PLANILLA, 2)
                                ElseIf mon <> mon_origen And mon = 2 Then
                                    row("AD_MONTO_ORI") = Math.Round(monto * _TIPO_CAMBIO_PLANILLA, 2)
                                End If

                                row("AD_PORCE_DESTINO") = 0
                                row("AD_ES_CONCI") = 0
                                row("AD_MES_CONCI") = 0
                                row("AD_ES_INAFECTO") = 0
                                row("AD_IDMONEDA") = mon_origen
                                row("AD_TDOC_REF") = ""
                                row("AD_SDOC_REF") = ""
                                row("AD_NDOC_REF") = "" 'CodigoPlanilla '.PadLeft(15, Char.Parse("0"))
                                row("AD_FDOC_REF") = ""
                                row("AD_VDOC_REF") = ""
                                row("AD_GLOSA") = "ACEPTACION DE LETRAS DE CLIENTE PLANILLA N° " & CodigoPlanilla
                                dtdetalleAsiento.Rows.Add(row)
                                dtdetalleAsiento.AcceptChanges()
                            Next

                            'grabado de asiento
                            Dim Flag As Boolean = False
                            clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                            ClsCobranzaBl = New ClsOperaciones.RECEIVABLE_LIST
                            Dim dtAceptacionLetra As DataTable
                            dtAceptacionLetra = New DataTable
                            Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                            Dim ClsasientoBlCob As New LibContabilidad.ClsOperaciones.Asiento_Contable
                            Dim dtcodigo As New DataTable
                            Call Cargar_Numero_Voucher()
                            If ClsCobranzaBl.Contabilizar_Aceptacion_Letra(CodigoPlanilla, dtdetalleAsiento, _numero_asiento, dtpfechaaceptacion.Value, MonedaPlanilla, _TIPO_CAMBIO_PLANILLA) = True Then
                                MsgBox("Contabilización generada Correctamente." & Chr(13) & " Planilla N° " & CodigoPlanilla, MsgBoxStyle.Information)
                            Else
                                MsgBox("Hubo un error en la Contabilización de" & Chr(13) & " Planilla N° " & CodigoPlanilla, MsgBoxStyle.Critical)
                                'If clsLetrasBl.GeneracionAceptacionLetra(CodigoPlanilla) Then
                                '    MsgBox("Contabilización generada Correctamente. Planilla N° " & CodigoPlanilla, MsgBoxStyle.Information)
                                'Else
                                '    MsgBox("Hubo un error en la Contabilización de la Planilla N° " & CodigoPlanilla, MsgBoxStyle.Critical)
                                'End If
                            End If
                        End If
                    End If
                Next
            End If
            DocumentosPlanilla()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        
    End Sub

    Private Sub btn_por_recoger_Click(sender As Object, e As EventArgs) Handles btn_por_recoger.Click
        Dim CodigoPlanilla As String = String.Empty
        Dim EstadoPlanilla As String = String.Empty
        Dim CodigoCliente As String = String.Empty
        Dim monto_debe_ft As Double, monto_haber_ft As Double
        Dim monto_debe_nc As Double, monto_haber_nc As Double
        If dgvPlanilla.CurrentRow Is Nothing Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub
        If String.IsNullOrEmpty(dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value.ToString) Then Exit Sub

        CodigoPlanilla = dgvPlanilla.Item(0, dgvPlanilla.CurrentRow.Index).Value
        EstadoPlanilla = dgvPlanilla.Item(6, dgvPlanilla.CurrentRow.Index).Value
        CodigoCliente = dgvPlanilla.Item(1, dgvPlanilla.CurrentRow.Index).Value
        If EstadoPlanilla = "EMITIDO" Then
            If MessageBox.Show("¿Desea cambiar al estado POR RECOGER las Letras de la Planilla" & Chr(13) & "Nro: " & CodigoPlanilla & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ''verificacion
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                Dim dtClienteVendedor As New DataTable
                Dim SQL As String = String.Empty
                SQL = "Select * from CUSTOMER WHERE ID='" & CodigoCliente & "'"
                dtClienteVendedor = clsLetrasBl.VerificacionClienteVendedor(SQL)
                If dtClienteVendedor.Rows.Count() = 0 Then
                    MsgBox("No exixten datos con el Cliente", MsgBoxStyle.Information)
                    Pnlcontabilidad.Visible = False
                    PnlDocumentos.Enabled = True
                    Exit Sub
                End If

                If clsLetrasBl.Generacion_Por_Recoger_Letra(CodigoPlanilla) Then
                    MsgBox("Actualización de Planilla de Letras generada Correctamente.", MsgBoxStyle.Information)
                    DocumentosPlanilla()
                Else
                    MsgBox("Hubo un error en la Aceptacion de la Letra.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                Exit Sub
            End If
        ElseIf EstadoPlanilla = "ACEPTADO" Then
            MsgBox("La Planilla ya se encuentra Aceptado", MsgBoxStyle.Exclamation)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        ElseIf EstadoPlanilla = "ANULADO" Then
            MsgBox("La Planilla ya se encuentra Anulada", MsgBoxStyle.Exclamation)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        ElseIf EstadoPlanilla = "CANCELADO" Then
            MsgBox("La Planilla ya se encuentra Cancelada", MsgBoxStyle.Exclamation)
            Pnlcontabilidad.Visible = False
            PnlDocumentos.Enabled = True
            Exit Sub
        End If
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                clsLetrasBl = New ClsNegocio.LETTER_EXCHANGE
                dtDocumentoPlanilla = New DataTable
                dtDocumentoPlanilla = clsLetrasBl.Get_Tipo_Cambio(dtpFecha.Value.ToString("dd/MM/yyyy"))
                If dtDocumentoPlanilla.Rows.Count() <> 0 Then
                    txtTipoCambio.Text = Math.Round(CDbl(dtDocumentoPlanilla.Rows(0).Item("SELL_RATE").ToString), 3)
                    CalcularTotalDocumentos()
                    cmb_moneda.Focus()
                Else
                    MsgBox("No se asigno el Tipo de Cambio para la fecha elegida", MsgBoxStyle.Exclamation, "Sistemas")
                    txtTipoCambio.Text = "0"
                    dtpFecha.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMas.Select()
        End If
    End Sub
End Class