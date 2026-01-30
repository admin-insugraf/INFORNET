Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports LibBillService.Process

Public Class Frm_Resumen_Boletas

    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Private dtDocumentoFactura As DataTable
    Private dt_lista_cabecera_resumen_boletas As DataTable
    Dim dtv As DataView

    Dim cabeceraBL As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS
    Dim detalleBE As LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
    Dim ls_det As List(Of LibCobranzas.ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE)
    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Private mySetting As NameValueCollection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_genera_detalle.Click
        Documentos_Resumen_Boletas()
    End Sub

    Private Sub Documentos_Resumen_Boletas()
        Try
            Me.Cursor = Cursors.WaitCursor

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            Dim dt_table As DataTable
            dt_table = New DataTable

            dt_table = clsFacturaBl.get_Resumen_Boletas_SUNAT_Correlativo(Date.Now.ToString("dd/MM/yyyy"))
            If dt_table.Rows.Count > 0 Then
                txt_numero_resumen.Text = "RC-" & CDate(Date.Now).Year.ToString & Format(CDate(Date.Now).Month, "00") & Format(CDate(Date.Now).Day, "00") & "-" & Format(CInt(dt_table.Rows(0).Item("ITEMS")) + 1, "00000")
                txt_nombre_boletas.Text = "RC-" & CDate(Date.Now).Year.ToString & Format(CDate(Date.Now).Month, "00") & Format(CDate(Date.Now).Day, "00") & "-" & CStr(CInt(dt_table.Rows(0).Item("ITEMS")) + 1) & ".xml"
            Else
                txt_numero_resumen.Text = ""
            End If

            dtDocumentoFactura = New DataTable
            If rdb_emitidos.Checked Then
                dtDocumentoFactura = clsFacturaBl.get_Datos_Resumen_Boletas_SUNAT(dtp_fecha_resumen.Value.ToString("dd/MM/yyyy"))
            ElseIf rdb_anulados.Checked Then
                dtDocumentoFactura = clsFacturaBl.get_Datos_Resumen_Boletas_SUNAT_Anulados(dtp_fecha_resumen.Value.ToString("dd/MM/yyyy"))
            End If
            dgv_detalle_resumen.DataSource = Nothing
            If dtDocumentoFactura.Rows.Count() <> 0 Then
                Formato_Grilla()
                GroupBox2.Enabled = False
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Formato_Grilla()
        If dtDocumentoFactura.Rows.Count() <> 0 Then
            dtv = New DataView

            dtv = dtDocumentoFactura.DefaultView
            dgv_detalle_resumen.DataSource = dtv

            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

            dgv_detalle_resumen.Columns("OPE.GRABADAS").DefaultCellStyle.Format = "N2"
            dgv_detalle_resumen.Columns("OPE.INAFECTAS").DefaultCellStyle.Format = "N2"
            dgv_detalle_resumen.Columns("OPE.EXONERADAS").DefaultCellStyle.Format = "N2"
            dgv_detalle_resumen.Columns("IGV").DefaultCellStyle.Format = "N2"
            dgv_detalle_resumen.Columns("TOTAL").DefaultCellStyle.Format = "N2"
            dgv_detalle_resumen.Columns("OPE.GRABADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_resumen.Columns("OPE.INAFECTAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_resumen.Columns("OPE.EXONERADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_resumen.Columns("IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle_resumen.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgv_detalle_resumen.AutoResizeColumns()
            dgv_detalle_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            With dgv_detalle_resumen.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_grabar_datos.Click
        If dtDocumentoFactura.Rows.Count = 0 Then Exit Sub

        Try
            If MessageBox.Show("¿Desea generar el Resumen de Boletas para el " & dtp_fecha_resumen.Value.ToString("dd/MM/yyyy") & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                'If GuardarFacturacion() = True Then
                '    If Generar_Txt_Resumen_Boletas(dtp_fecha_resumen.Value.ToString("dd/MM/yyyy"), txt_numero_resumen.Text.Trim, Ruta_FE_Verificacion() & "\Input") = False Then
                '        MsgBox("No se Genero el Resumen de Boletas para la fecha " & dtp_fecha_resumen.Value.ToString("dd/MM/yyyy") & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                '    Else
                '        pnlPrincipal.Visible = True
                '        btn_buscar_registros_Click(sender, e)
                '        Dim msj As String
                '        msj = String.Empty
                '        msj = "Resumen de Boletas generado Correctamente."
                '        MsgBox(msj, MsgBoxStyle.Information)
                '        Me.Cursor = Cursors.Default
                '    End If
                'End If

                '***
                If GuardarFacturacion() = True Then
                    If Generar_XML_Resumen_Boletas(dtp_fecha_resumen.Value.ToString("dd/MM/yyyy"), txt_numero_resumen.Text, IIf(rdb_emitidos.Checked, "1", IIf(rdb_anulados.Checked, "3", ""))) = False Then
                        MsgBox("No se Genero el Resumen de Boletas en versión del UBL 2.1, para la fecha " & dtp_fecha_resumen.Value.ToString("dd/MM/yyyy") & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                    Else
                        Dim strMensaje As String = ""
                        Dim StrNomArchivo_XML As String = ""

                        StrNomArchivo_XML = Ruta_FE() & "\InputXML\" & txt_nombre_boletas.Text

                        Dim oProcesaArchivo As New ProcesaArchivo

                        If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                            MsgBox(strMensaje, MsgBoxStyle.Critical)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Else
                            pnlPrincipal.Visible = True
                            btn_buscar_registros_Click(sender, e)
                            Dim msj As String
                            msj = String.Empty
                            msj = "Resumen de Boletas generado Correctamente."
                            MsgBox(msj, MsgBoxStyle.Information)
                            Me.Cursor = Cursors.Default
                        End If
                    End If
                End If
                '***
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Generar_Txt_Resumen_Boletas(ByVal fecha_resumen As String, ByVal codigo_resumen As String, ByVal ruta As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Txt_Resumen_Boletas(fecha_resumen, ruta, codigo_resumen) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_XML_Resumen_Boletas(ByVal fecha_resumen As String, ByVal codigo_resumen As String, ByVal estado_documentos As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_XML_Resumen_Boletas(fecha_resumen, Ruta_FE() & "\InputXML", codigo_resumen, estado_documentos) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function

    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function

    Private Function GuardarFacturacion() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            cabeceraBE = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS
            detalleBE = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
            ls_det = New List(Of ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE)

            With cabeceraBE
                .ID = 0
                .CODIGO_RESUMEN = txt_numero_resumen.Text.Trim
                .CODIGO_RESUMEN_BOLETAS = txt_nombre_boletas.Text.Trim
                .FECHA_DOCUMENTOS = dtp_fecha_resumen.Value.ToString("dd/MM/yyy")
                .NUMERO_TICKET = ""
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PC_ID = Environment.MachineName
            End With

            'Detalle de Resumen
            For i As Integer = 0 To dtDocumentoFactura.Rows.Count() - 1
                detalleBE = New ClsEntidades.RECEIVABLE_RESUMEN_BOLETAS_LINE
                With detalleBE
                    .ID_CAB = 0
                    .ITEM = dtDocumentoFactura.Rows(i).Item("ITEM").ToString
                    .TIPO_DOC = dtDocumentoFactura.Rows(i).Item("TIPO.DOC").ToString
                    .SERIE_DOC = dtDocumentoFactura.Rows(i).Item("SERIE.DOC").ToString
                    .NUMERO_DOC = dtDocumentoFactura.Rows(i).Item("NUMERO.DOC").ToString
                    .OPE_GRABADAS = dtDocumentoFactura.Rows(i).Item("OPE.GRABADAS").ToString
                    .OPE_INAFECTAS = dtDocumentoFactura.Rows(i).Item("OPE.INAFECTAS").ToString
                    .OPE_EXONERADAS = dtDocumentoFactura.Rows(i).Item("OPE.EXONERADAS").ToString
                    .OPE_IGV = dtDocumentoFactura.Rows(i).Item("IGV").ToString
                    .OPE_TOTAL = dtDocumentoFactura.Rows(i).Item("TOTAL").ToString
                End With
                ls_det.Add(detalleBE)
            Next

            If cabeceraBL.GuardarFactura_Resumen_Boletas_SUNAT(cabeceraBE, ls_det) = False Then
                MsgBox("Hubo un Error en la generación del Resumen de Boletas.", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If

        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function

    Private Sub btn_verifica_estado_manual_Click(sender As Object, e As EventArgs) Handles btn_verifica_estado_manual.Click
        pnlPrincipal.Visible = False
        txt_numero_resumen.Text = ""
        dtp_fecha_resumen.Value = Date.Now
        GroupBox2.Enabled = True
        rdb_emitidos.Checked = True
        dgv_detalle_resumen.DataSource = Nothing
        btn_genera_detalle.Focus()
    End Sub

    Private Sub Frm_Resumen_Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        btn_buscar_registros_Click(sender, e)
    End Sub

    Private Sub btn_buscar_registros_Click(sender As Object, e As EventArgs) Handles btn_buscar_registros.Click
        Lista_cabecera_Resumen_Boletas()
    End Sub

    Private Sub Lista_cabecera_Resumen_Boletas()
        Try

            If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicial.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dt_lista_cabecera_resumen_boletas = New DataTable
            dt_lista_cabecera_resumen_boletas = clsFacturaBl.get_Datos_Resumen_Boletas_SUNAT_Cabecera(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), _
                                                                                                      dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvDocumentosFactura.DataSource = Nothing
            If dt_lista_cabecera_resumen_boletas.Rows.Count() <> 0 Then
                dgvDocumentosFactura.DataSource = dt_lista_cabecera_resumen_boletas

                dgvDocumentosFactura.Columns("RUC.EMISOR").Width = 100
                dgvDocumentosFactura.Columns("FECHA.DOCS").Width = 100
                dgvDocumentosFactura.Columns("NUMERO.RESUMEN").Width = 200
                dgvDocumentosFactura.Columns("ESTADO").Width = 120
                dgvDocumentosFactura.Columns("TICKET").Width = 150
                dgvDocumentosFactura.Columns("CDR").Width = 150

                With dgvDocumentosFactura.ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.White
                    .Font = New Font("Tahoma", 8, FontStyle.Bold)
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

                lblCantidad.Text = dt_lista_cabecera_resumen_boletas.Rows.Count.ToString & " registro(s)."
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDocumentosFactura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosFactura.CellFormatting
        dgvDocumentosFactura.Columns("ESTADO").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura.Columns("TICKET").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura.Columns("CDR").DefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub btn_retornar_Click(sender As Object, e As EventArgs) Handles btn_retornar.Click
        btn_buscar_registros_Click(sender, e)
        pnlPrincipal.Visible = True
    End Sub
End Class