Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario

Public Class Frm_Comp_Retencion_Contabilizacion
    Dim dtDatosCompany As DataTable
    Dim total_soles As Double
    Dim total_dolares As Double
    Dim contador_doc_vencidos As Integer

    Public dtUsuarioAcceso As DataTable
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData

    Dim clsBuscarBl As ClsBuscar
    Private cProcesosbL As ClsProcesos
    Private cConsultabL As ClsConsultas
    ' Private clsFacturaBl As ClsOperaciones.RECEIVABLE
    Private clsFacturaBl As ClsNegocio.RECEIVABLE

    Private dtDocumentoFactura As DataTable
    Public CodigoVendedor As String = String.Empty
    Public DescripcionVendedor As String = String.Empty

    Dim Flag_Verificar As Boolean = False
    Dim Modo_consultar As Boolean = False
    Dim Modo_editar As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim STRordenCliente As String = String.Empty
    Dim STRordenPedido As String = String.Empty
    Dim STRordenDevol As String = String.Empty

    Dim edicion As Boolean = False
    Public dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Fl_NC_REF As Boolean = False

    Dim _DT_SALDO_INICIAL As DataTable
    Dim _SALDO_INICIAL As Double = 0.0
    Dim _FLAG_INICIAL As Boolean = False
    Dim FLAG_CLIENTE As String
    Dim _ARTS_INICIALES As String = String.Empty
    Dim _CANT_INICIALES As Double = 0.0

    Dim TIPO_DEV, NUM_DEV, POSICION_DEV As String

    Dim NumeracionGuiaRemision, NumeracionFacturacion, NumeracionFacturaNotac, NumeracionFacturaNotaD, NumeracionFacturaCP As String
    Dim Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, Ref_ALMACEN As String
    Dim Ref_GUIA_DOCUMENT_ID, Ref_GUIA_NUMBER_SERIE, Ref_GUIA_NUMBER_DOCUMENT As String
    Dim Ref_CP_DOCUMENT_ID, Ref_CP_NUMBER_SERIE, Ref_CP_NUMBER_DOCUMENT As String

    Dim Flag_ComprobPerc As Boolean = False
    Dim Flag_Detraccion As Boolean = False

    Dim indicadorG As Boolean = True

    Dim TipoNumeracion As String
    Dim TipoNumeracionCp As String
    Dim ListaDocCliente As List(Of String)
    Dim NumerosDocClientes As String
    Dim PorcentajePercepcion, PorcentajeDetraccion As String

    Dim cabeceraBL As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As LibCobranzas.ClsEntidades.RECEIVABLE
    Dim carteraBE As LibCobranzas.ClsEntidades.CUSTOMER_BALANCE
    Dim detalle As LibCobranzas.ClsEntidades.RECEIVABLE_LINE
    Dim ls_det As List(Of LibCobranzas.ClsEntidades.RECEIVABLE_LINE)
    Dim ls_det_alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuia_Alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE)
    Dim ListaGuiaCab_alm As List(Of LibCobranzas.ClsEntidades.WAREHOUSE_TRANS)
    Dim alm_cabBE As LibCobranzas.ClsEntidades.WAREHOUSE_TRANS
    Dim alm_detBE As LibCobranzas.ClsEntidades.WAREHOUSE_TRANS_LINE
    Dim numeracionBE As LibCobranzas.ClsEntidades.NUMBER_DOCUMENT


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtVerificar As DataTable

    Dim cVenta As ClsAyudas
    Dim dtSerieDoc As DataTable
    Dim dtTipoDoc As DataTable
    Dim dtSerieGuia As DataTable
    Dim dtDirCliente As DataTable
    Dim dtPedido As DataTable
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim NumeroLineas As Integer
    Dim STRAccion As String = String.Empty

    Dim clsIgvArticuloBL As ClsTransacciones.clsPedidos
    Dim dtIgvArticulo As DataTable

    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim clsFacturaDetBl As LibCobranzas.ClsOperaciones.RECEIVABLE_LIST
    Dim dtCabeceraFact As DataTable
    Dim dtDetalleFact As DataTable
    Dim dtValidacion As DataTable
    Dim _GENERA_DETRACCION As String
    Dim _GENERA_COMP_PER As String
    Dim _GENERA_ESTADO_CUENTA As String
    Dim po_TasaIgv As Double
    Dim Igv As Double = 0.0


    Dim Dt_principal_lista_Doc_Ref As DataTable
    Public IGV_POR_ITEM As Double
    Private Sub Frm_Comp_Retencion_Contabilizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        txtFiltro.Select()
    End Sub

    Private Sub DocumentosFactura()
        Try
            Me.Cursor = Cursors.WaitCursor
            

            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDocumentoFactura = New DataTable
            dtv = New DataView
            dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion_Contabilizacion_CR(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                            cboopcionesBusqueda.SelectedIndex, "")
            dgvDocumentosFactura.DataSource = Nothing
            If dtDocumentoFactura.Rows.Count() <> 0 Then
                dtv = dtDocumentoFactura.DefaultView
                dgvDocumentosFactura.DataSource = dtv
                dgvDocumentosFactura.Columns(0).Width = 150
                dgvDocumentosFactura.Columns(1).Width = 30
                dgvDocumentosFactura.Columns(2).Width = 40
                dgvDocumentosFactura.Columns(3).Width = 80
                dgvDocumentosFactura.Columns(4).Width = 70
                dgvDocumentosFactura.Columns(5).Width = 300
                dgvDocumentosFactura.Columns(6).Width = 50
                dgvDocumentosFactura.Columns(8).Width = 90
                dgvDocumentosFactura.Columns(7).Width = 100

                dgvDocumentosFactura.Columns(7).HeaderText = "Monto"
                dgvDocumentosFactura.Columns(7).DefaultCellStyle.Format = "N2"
                dgvDocumentosFactura.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvDocumentosFactura.Columns(0).Visible = True
                dgvDocumentosFactura.Columns(0).HeaderText = "CDR"
                dgvDocumentosFactura.Columns(9).Visible = False
                dgvDocumentosFactura.Columns(10).Visible = False
                dgvDocumentosFactura.Columns(11).Visible = False
                dgvDocumentosFactura.Columns(12).Visible = False
                dgvDocumentosFactura.Columns(13).Visible = False
                dgvDocumentosFactura.Columns(14).Visible = False
                dgvDocumentosFactura.Columns(15).Visible = False
                dgvDocumentosFactura.Columns(16).Visible = False
                dgvDocumentosFactura.Columns(17).Visible = False
                dgvDocumentosFactura.Columns(18).Visible = False
                dgvDocumentosFactura.Columns(19).Visible = False
                dgvDocumentosFactura.Columns(20).Visible = False
                dgvDocumentosFactura.Columns(21).Visible = False
                dgvDocumentosFactura.Columns(22).Visible = False
                dgvDocumentosFactura.Columns(23).Visible = False
                dgvDocumentosFactura.Columns(24).Visible = False
                dgvDocumentosFactura.Columns("ORIGEN").Visible = False

                STRorden = dgvDocumentosFactura.Columns(3).Name & "+" & dgvDocumentosFactura.Columns(5).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cboopcionesBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboopcionesBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentosFactura.Select()
        End If
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosFactura()
        txtFiltro.Focus()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosFactura()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosFactura()
        End If
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
        If dgvDocumentosFactura.RowCount() = 0 Then
            MsgBox("No hay documentos para Contabilizar.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If dgvDocumentosFactura.CurrentRow Is Nothing Then
                dgvDocumentosFactura.Focus()
                Exit Sub
            End If
        End If
        Me.Cursor = Cursors.WaitCursor
        If MessageBox.Show("¿Desea contabilizar los Comprobantes de Retención?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For i As Integer = 0 To dgvDocumentosFactura.Rows.Count - 1
                Ref_DOCUMENT_ID = String.Empty
                Ref_NUMBER_SERIE = String.Empty
                Ref_NUMBER_DOCUMENT = String.Empty
                Dim _id_compra As String
                Dim _origen As String

                Ref_DOCUMENT_ID = dgvDocumentosFactura.Rows(i).Cells("Tipo").Value.ToString
                Ref_NUMBER_SERIE = dgvDocumentosFactura.Rows(i).Cells("Serie").Value.ToString
                Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.Rows(i).Cells("Numero").Value.ToString
                _id_compra = dgvDocumentosFactura.Rows(i).Cells("Guia.Remision").Value.ToString
                _origen = dgvDocumentosFactura.Rows(i).Cells("ORIGEN").Value.ToString

                If dgvDocumentosFactura.Rows(i).Cells("PV").Value.ToString <> "" Then
                    reporteBL = New ClsBuscar
                    dtImprimir = reporteBL.Verif_Contab_CR(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, _id_compra, _origen)
                    If dtImprimir.Rows.Count > 0 Then
                        If dgvDocumentosFactura.Rows(i).Cells("Numero.Voucher").Value.ToString = "" Then
                            If Contabilizar_Individual(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, "", _id_compra, _origen) = True Then
                                'DocumentosFactura()
                            Else
                                'DocumentosFactura()
                                MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no se contabilizo." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Exclamation, "Sistemas")
                            End If
                        End If
                    Else
                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no existe." & Chr(13) & "No procede la contabilización.", MsgBoxStyle.Exclamation, "Sistemas")
                    End If
                End If
            Next
            DocumentosFactura()
        End If

        Me.Cursor = Cursors.Default

    End Sub
    Private Function ValidacionConsultas(ByRef _DOCUMENT_ID As String, ByRef _NUMBER_SERIE As String, ByRef _NUMBER_DOCUMENT As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            _DOCUMENT_ID = dgvDocumentosFactura.Item(7, dgvDocumentosFactura.CurrentRow.Index).Value
            _NUMBER_SERIE = dgvDocumentosFactura.Item(8, dgvDocumentosFactura.CurrentRow.Index).Value
            _NUMBER_DOCUMENT = dgvDocumentosFactura.Item(9, dgvDocumentosFactura.CurrentRow.Index).Value
            'validacion
            If _DOCUMENT_ID = String.Empty Or _NUMBER_SERIE = String.Empty Or _NUMBER_DOCUMENT = String.Empty Then
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function
    Private Function Contabilizar(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Id_compra As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Contabilizar_CR(TipoDoc, SerieDoc, NumDoc) Then
                'MsgBox("Proceso de Contabilización generado correctamente.", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Contabilizar_Individual(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal num_asiento As String, ByVal id_compra As String,
                                             ByVal origen As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Contabilizar_Individual_CR(TipoDoc, SerieDoc, NumDoc, num_asiento, id_compra, origen) Then
                'MsgBox("Proceso de Contabilización generado correctamente.", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Contabilizar_Ventas_Contado(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Contabilizar_Ventas_Contado(TipoDoc, SerieDoc, NumDoc) Then
                'MsgBox("Proceso de Contabilización generado correctamente.", MsgBoxStyle.Information)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub dgvDocumentosFactura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosFactura.CellFormatting
        If dgvDocumentosFactura.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            If cboopcionesBusqueda.SelectedIndex <> 3 Then
                If txtFiltro.Text = String.Empty Then
                    dtv.RowFilter = String.Empty
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                    Exit Sub
                Else
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvDocumentosFactura.Columns(3).Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvDocumentosFactura.Columns(5).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvDocumentosFactura.Columns(3).Name & "+" & dgvDocumentosFactura.Columns(5).Name
                                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                Exit Sub
                            End If
                        End If
                    End If
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                End If
            End If
        End If

    End Sub

    
    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If dgvDocumentosFactura.RowCount() = 0 Then
            MsgBox("No hay documentos para Contabilizar.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If dgvDocumentosFactura.CurrentRow Is Nothing Then
                dgvDocumentosFactura.Focus()
                Exit Sub
            End If
        End If
        Me.Cursor = Cursors.WaitCursor
        If MessageBox.Show("¿Desea contabilizar el Comprobante de Retención seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Ref_DOCUMENT_ID = String.Empty
            Ref_NUMBER_SERIE = String.Empty
            Ref_NUMBER_DOCUMENT = String.Empty

            Dim _fecha_ref As String = String.Empty
            Dim _num_voucher As String = String.Empty
            Dim _id_compra As String = String.Empty
            Dim _origen As String = String.Empty

            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("DOCUMENT_ID").Value.ToString
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_SERIE").Value.ToString
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMBER_DOCUMENT").Value.ToString
            _fecha_ref = dgvDocumentosFactura.CurrentRow.Cells("FECHA").Value.ToString
            _id_compra = dgvDocumentosFactura.CurrentRow.Cells("Guia.Remision").Value.ToString
            _origen = dgvDocumentosFactura.CurrentRow.Cells("ORIGEN").Value.ToString

            Dim fecha As DateTime = DateTime.Parse(_fecha_ref)

            'If ValidacionConsultas(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT) = False Then Exit Sub
            reporteBL = New ClsBuscar
            dtImprimir = reporteBL.Verif_Contab_CR(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, _id_compra, _origen)
            If dtImprimir.Rows.Count > 0 Then
                If dgvDocumentosFactura.CurrentRow.Cells("Numero.Voucher").Value.ToString = "" Then
                    If MessageBox.Show("¿Desea numeracion Automatica para el Comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable
                        _num_voucher = ac.get_Ult_num_voucher("20", fecha.Year, Format(fecha.Month, "00"))
                        ac = Nothing
                    Else
                        Dim codigo As String = String.Empty
                        codigo = InputBox("Ingrese numero de asiento")
                        If codigo = String.Empty Then
                            MsgBox("Es necesario una numeración.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        codigo = Format(fecha.Month, "00") & codigo.PadLeft(4, Char.Parse("0"))
                        Dim ClsasientoBl As New LibContabilidad.ClsOperaciones.Asiento_Contable
                        Dim dtcodigo As New DataTable
                        dtcodigo = ClsasientoBl.ValidarCodigo_Cobranzas("20", codigo, fecha.Year, fecha.Month)
                        If dtcodigo.Rows.Count() <> 0 Then
                            MsgBox("El codigo del Asiento contable ya existe.", MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            _num_voucher = codigo
                        End If
                    End If
                    If Contabilizar_Individual(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, _num_voucher, _id_compra, _origen) = True Then
                        'DocumentosFactura()
                    Else
                        'DocumentosFactura()
                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no se contabilizo." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Exclamation, "Sistemas")
                    End If
                Else
                    MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " se encuentra contabilizado." & Chr(13) & "No procede la contabilización.", MsgBoxStyle.Critical, "Sistemas")
                End If
            Else
                MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " no existe." & Chr(13) & "No procede la contabilización.", MsgBoxStyle.Exclamation, "Sistemas")
            End If

            DocumentosFactura()
        End If

        Me.Cursor = Cursors.Default
    End Sub
End Class