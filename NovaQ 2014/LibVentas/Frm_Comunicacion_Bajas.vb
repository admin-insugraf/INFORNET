Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
'Imports Microsoft.Office.Interop
Imports WSConsultaSUNAT
Imports LibBillService.Process

Public Class Frm_Comunicacion_Bajas
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Private dtDocumentoFactura As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Private mySetting As NameValueCollection

    Dim cabeceraBL As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim cabeceraBE As LibCobranzas.ClsEntidades.RECEIVABLE
    Dim ls_det As List(Of LibCobranzas.ClsEntidades.RECEIVABLE)
    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim crystalBL As LibReportes.ClsReporte
    Dim ID_COMUNICACION_BAJA_ As String
    Dim ID_COMUNICACION_BAJA_CDR As String

    Private Sub Frm_Comunicacion_Bajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        txtFiltro.Select()
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
            Case 3
                gbRangofechas.Enabled = False
        End Select
        txtFiltro.Text = String.Empty
        DocumentosFactura()
        txtFiltro.Focus()
    End Sub

    Private Sub cboopcionesBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboopcionesBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentosFactura.Select()
        End If
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
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvDocumentosFactura.Columns(6).Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvDocumentosFactura.Columns(9).Name
                                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                If dtv.Count() = 0 Then
                                    STRorden = String.Empty
                                    STRorden = dgvDocumentosFactura.Columns(10).Name
                                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                    If dtv.Count() = 0 Then
                                        STRorden = String.Empty
                                        STRorden = dgvDocumentosFactura.Columns(6).Name & "+" & dgvDocumentosFactura.Columns(9).Name & "+" & dgvDocumentosFactura.Columns(10).Name
                                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                End If
            End If
        End If
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
            dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion_SUNAT_Comunicacion_Baja(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                               cboopcionesBusqueda.SelectedIndex, "")
            dgvDocumentosFactura.DataSource = Nothing
            If dtDocumentoFactura.Rows.Count() <> 0 Then
                Formato_Grilla()
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
            dgvDocumentosFactura.DataSource = dtv

            STRorden = dgvDocumentosFactura.Columns(6).Name & "+" & dgvDocumentosFactura.Columns(9).Name & "+" & dgvDocumentosFactura.Columns(10).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

            With dgvDocumentosFactura.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            dgvDocumentosFactura.Columns("OPE. GRABADAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura.Columns("OPE. INAFECTAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura.Columns("OPE. EXONERADAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura.Columns("IGV").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura.Columns("TOTAL").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura.Columns("OPE. GRABADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura.Columns("OPE. INAFECTAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura.Columns("OPE. EXONERADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura.Columns("IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura.Columns("ESTADO").Width = 80
            dgvDocumentosFactura.Columns("CDR").Width = 100
            dgvDocumentosFactura.Columns("CRESUMEN").Visible = False
            dgvDocumentosFactura.Columns("TIPO").Width = 40
            dgvDocumentosFactura.Columns("SERIE").Width = 40
            dgvDocumentosFactura.Columns("NUMERO").Width = 70
            dgvDocumentosFactura.Columns("FECHA EMISION").Width = 70
            dgvDocumentosFactura.Columns("TD RECEP").Width = 40
            dgvDocumentosFactura.Columns("RUC.RECEP").Width = 80
            dgvDocumentosFactura.Columns("RECEPTOR").Width = 250
            dgvDocumentosFactura.Columns("OPE. GRABADAS").Width = 80
            dgvDocumentosFactura.Columns("OPE. INAFECTAS").Width = 80
            dgvDocumentosFactura.Columns("OPE. EXONERADAS").Width = 80
            dgvDocumentosFactura.Columns("IGV").Width = 80
            dgvDocumentosFactura.Columns("TOTAL").Width = 80
            dgvDocumentosFactura.Columns("ESTADO FACTURACION").Width = 100
            dgvDocumentosFactura.Columns("ESTADO_CPE_SUNAT").Width = 300
            dgvDocumentosFactura.Columns("ESTADO_CPE_SUNAT").HeaderText = "ESTADO CPE SUNAT"

            For i As Integer = 17 To dgvDocumentosFactura.Columns.Count - 1
                dgvDocumentosFactura.Columns(i).Visible = False
            Next
            dgvDocumentosFactura.Columns("ESTADO_CPE_SUNAT").Visible = True
        End If

    End Sub

    Private Sub dgvDocumentosFactura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosFactura.CellFormatting
        If dgvDocumentosFactura.Rows(e.RowIndex).Cells("ESTADO FACTURACION").Value = "ANULADO" Then
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If

        dgvDocumentosFactura.Columns("NUMERO").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura.Columns("TIPO").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura.Columns("SERIE").DefaultCellStyle.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub btn_ver_cdr_Click(sender As Object, e As EventArgs) Handles btn_ver_cdr.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Dim _frm_cdr As New Frm_CDR
        _frm_cdr._tipo_documento = dgvDocumentosFactura.CurrentRow.Cells("TIPO").Value
        _frm_cdr._serie_documento = dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value
        _frm_cdr._numero_documento = dgvDocumentosFactura.CurrentRow.Cells("NUMERO").Value
        _frm_cdr._tipo_doc_electronico = "CB"
        _frm_cdr.ShowDialog()
    End Sub

    Private Sub btn_verifica_estado_manual_Click(sender As Object, e As EventArgs) Handles btn_verifica_estado_manual.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""
            Dim estado_facturacion As String = ""
            Dim numero_ticket As String = ""

            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura.CurrentRow.Cells("TICKET_RB").Value

            Ref_DOCUMENT_ID = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", ""))))
            '//para obtener solo mensaje
            Dim oConsultaCDR1 As New ConsultaCDR("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 1, strMensaje)
            oConsultaCDR1.getStatus(LibComunVar.ClsVarComun.RucEmpresa, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, strMensaje)
            MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_actualiza_estado_Click(sender As Object, e As EventArgs) Handles btn_actualiza_estado.Click
        If dtDocumentoFactura.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim _nombre_archivo As String = ""
            Dim _id_cdr As String = ""
            Dim _id_ticket As String = ""
            Dim _fecha_recepcion As String = ""
            Dim _hora_recepcion As String = ""
            Dim _fecha_generacion As String = ""
            Dim _hora_generacion As String = ""
            Dim _ruc_emisor As String = ""
            Dim _respuesta_sunat As String = ""
            Dim _id_receptor As String = ""
            Dim _codigo_respuesta As String = ""
            Dim _existe_pendiente As Boolean = False
            Dim StrNomArchivo_CDR As String = ""

            '//RECORRE LOS CDR DE LAS COMUNICACIONES DE BAJA 
            For Each item As DataRow In dtDocumentoFactura.Select("BUSCA_CDR='SI'")
                dtDocumentoFactura.BeginInit()

                _nombre_archivo = "R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & item("NOMBRE_CB")

                If File.Exists(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo) = False Then
                    StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _nombre_archivo
                    If File.Exists(StrNomArchivo_CDR) Then
                        If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & item("NOMBRE_CB") & ".CDR" & Chr(13) & _
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    End If
                End If

                If File.Exists(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo) Then
                    _id_cdr = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cbc:ID")
                    _fecha_recepcion = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cbc:IssueDate")
                    _hora_recepcion = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cbc:IssueTime")
                    _fecha_generacion = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cbc:ResponseDate")
                    _hora_generacion = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cbc:ResponseTime")
                    _ruc_emisor = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cac:Signature//cac:SignatoryParty//cac:PartyIdentification//cbc:ID")
                    _respuesta_sunat = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cac:DocumentResponse//cac:Response//cbc:Description")
                    _id_receptor = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cac:DocumentResponse//cac:RecipientParty//cac:PartyIdentification//cbc:ID")
                    _codigo_respuesta = Leer_XML_CDR(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo, "//cac:DocumentResponse//cac:Response//cbc:ResponseCode")
                Else
                    _id_cdr = ""
                    _fecha_recepcion = ""
                    _hora_recepcion = ""
                    _fecha_generacion = ""
                    _hora_generacion = ""
                    _ruc_emisor = ""
                    _respuesta_sunat = ""
                    _id_receptor = ""
                    _codigo_respuesta = ""
                End If

                item("CDR") = _id_cdr
                item("FECHA_RECEPCION") = _fecha_recepcion
                item("HORA_RECEPCION") = _hora_recepcion
                item("FECHA_GENERACION") = _fecha_generacion
                item("HORA_GENERACION") = _hora_generacion
                item("RUC_EMISOR") = _ruc_emisor
                item("RESPUESTA_SUNAT") = _respuesta_sunat
                item("ID_RECEPTOR") = _id_receptor
                item("CODIGO_RESPUESTA") = _codigo_respuesta

                dtDocumentoFactura.EndInit()
                dtDocumentoFactura.AcceptChanges()

                _existe_pendiente = True
            Next


            If _existe_pendiente Then
                If GuardarFacturacion() Then
                    Call DocumentosFactura()
                End If
            Else
                Call DocumentosFactura()
            End If


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Ruta_FE_Verificacion() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE_Verificacion = mySetting("Ruta_FE_Verificacion")
        Return STRRuta_FE_Verificacion
    End Function

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function

    Private Sub btn_reenviar_doc_sunat_Click(sender As Object, e As EventArgs) Handles btn_reenviar_doc_sunat.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""
            Dim estado_facturacion As String = ""
            Dim numero_ticket As String = ""
            Dim moneda As String = ""
            Dim obsequio As String = ""
            Dim STRmontotexto As String = ""
            Dim total As Double = 0

            If Strings.Left(dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value, 1) = "B" Then
                Me.Cursor = Cursors.Default
                MsgBox("Documento elegido no aplica el Proceso de Re-envio a SUNAT. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If CInt(dgvDocumentosFactura.CurrentRow.Cells("DIAS").Value) > 7 Then
                Me.Cursor = Cursors.Default
                MsgBox("No aplica el Proceso de Re-envio a SUNAT, por superar el limite de días habiles.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura.CurrentRow.Cells("TICKET_RB").Value
            moneda = dgvDocumentosFactura.CurrentRow.Cells("MONEDA").Value
            obsequio = dgvDocumentosFactura.CurrentRow.Cells("RECEIVABLE_TYPE").Value
            total = CDbl(dgvDocumentosFactura.CurrentRow.Cells("TOTAL").Value)

            If MessageBox.Show("¿Desea Re-enviar la COMUNICACION DE BAJA del documento: " & Chr(13) & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " a SUNAT?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cabeceraBL = New ClsOperaciones.RECEIVABLE
                ID_COMUNICACION_BAJA_ = ""
                ID_COMUNICACION_BAJA_CDR = ""
                If cabeceraBL.Genera_Comunicacion_Baja_Manual(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7), Date.Now.ToString("dd/MM/yyyy")) = True Then
                    If Generar_XML_Comunicacion_Baja(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7), Date.Now.ToString("dd/MM/yyyy"), _
                                                     ID_COMUNICACION_BAJA_, ID_COMUNICACION_BAJA_CDR) = False Then
                        Me.Cursor = Cursors.Default
                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " no genero el archivo XML UBL 2.1 de la Comunicación de Baja." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                    Else

                        Dim StrNomArchivo_XML As String = ""

                        StrNomArchivo_XML = Ruta_FE() & "\InputXML\RA-" & ID_COMUNICACION_BAJA_

                        Dim oProcesaArchivo As New ProcesaArchivo

                        If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                            MsgBox(strMensaje, MsgBoxStyle.Critical)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Else
                            StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                LibComunVar.ClsVarComun.FechaSistema.Year.ToString & "\" & Format(LibComunVar.ClsVarComun.FechaSistema.Month, "00") & "\" &
                                                Format(LibComunVar.ClsVarComun.FechaSistema.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa &
                                                "-RA-" & ID_COMUNICACION_BAJA_CDR

                            System.Threading.Thread.Sleep(2000)
                            If File.Exists(StrNomArchivo_XML) Then
                                If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                                    MsgBox("ERROR:" & Chr(13) & "El documento RA-" & ID_COMUNICACION_BAJA_CDR & Chr(13) & _
                                           "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                Else
                                    DocumentosFactura()
                                    Me.Cursor = Cursors.Default
                                    MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " se genero correctamente", MsgBoxStyle.Information, "UBL 2.1")
                                End If
                            Else
                                MsgBox("No existe el documento RA-" & ID_COMUNICACION_BAJA_CDR & " . Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                            End If
                        End If
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    MsgBox("No se pudo anular el documento elegido. Verifique!!!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Generar_Txt_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Txt_Comunicacion_Baja(TipoDoc, SerieDoc, NumDoc, Ruta_FE_Verificacion() & "\Input", Fecha_baja) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_XML_Comunicacion_Baja(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Fecha_baja As String, _
                                                   ByRef ID_COMUNICACION_BAJA_ As String, ByRef ID_COMUNICACION_BAJA_CDR As String) As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_XML_Comunicacion_Baja(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Fecha_baja, ID_COMUNICACION_BAJA_, ID_COMUNICACION_BAJA_CDR) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function GuardarFacturacion() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            cabeceraBE = New ClsEntidades.RECEIVABLE
            ls_det = New List(Of ClsEntidades.RECEIVABLE)

            'Detalle de Factura
            For i As Integer = 0 To dtDocumentoFactura.Rows.Count() - 1
                cabeceraBE = New ClsEntidades.RECEIVABLE
                With cabeceraBE
                    .DOCUMENT_ID = dtDocumentoFactura.Rows(i).Item("TIPO").ToString
                    .NUMBER_SERIE = dtDocumentoFactura.Rows(i).Item("SERIE").ToString
                    .NUMBER_DOCUMENT = dtDocumentoFactura.Rows(i).Item("NUMERO").ToString

                    .CDR = dtDocumentoFactura.Rows(i).Item("CDR").ToString
                    .CRESUMEN = dtDocumentoFactura.Rows(i).Item("CRESUMEN").ToString
                    .FECHA_RECEPCION = dtDocumentoFactura.Rows(i).Item("FECHA_RECEPCION").ToString
                    .HORA_RECEPCION = dtDocumentoFactura.Rows(i).Item("HORA_RECEPCION").ToString
                    .FECHA_GENERACION = dtDocumentoFactura.Rows(i).Item("FECHA_GENERACION").ToString
                    .HORA_GENERACION = dtDocumentoFactura.Rows(i).Item("HORA_GENERACION").ToString
                    .RUC_EMISOR = dtDocumentoFactura.Rows(i).Item("RUC_EMISOR").ToString
                    .RESPUESTA_SUNAT = dtDocumentoFactura.Rows(i).Item("RESPUESTA_SUNAT").ToString
                    .ID_RECEPTOR = dtDocumentoFactura.Rows(i).Item("ID_RECEPTOR").ToString
                    .CODIGO_RESPUESTA = dtDocumentoFactura.Rows(i).Item("CODIGO_RESPUESTA").ToString
                End With
                ls_det.Add(cabeceraBE)
            Next

            If cabeceraBL.GuardarFactura_Actualiza_SUNAT_Comunicacion_Baja(ls_det) = False Then
                MsgBox("Hubo un Error en la Actualización de los documentos Electronicos", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If

        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvDocumentosFactura.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""
            Dim estado_facturacion As String = ""
            Dim numero_ticket As String = ""

            Ref_DOCUMENT_ID = dgvDocumentosFactura.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura.CurrentRow.Cells("TICKET_RB").Value

            If (Ref_DOCUMENT_ID = "FT" Or Ref_DOCUMENT_ID = "NC" Or Ref_DOCUMENT_ID = "ND") And Strings.Left(Ref_NUMBER_SERIE, 1) = "F" And estado_facturacion = "ANULADO" Then
                If numero_ticket <> "" Then
                    If MessageBox.Show("¿Desea obtener el CDR de la Comunicacion de Baja: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '//ingresa aki cuando sean anulados los documentos(comunicacion de baja)
                        Dim oConsultaCDR3 As New ConsultaCDR(" https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 2, strMensaje)
                        oConsultaCDR3.getStatusCDRResumen(Ruta_FE_Verificacion() & "\Output\CDR", numero_ticket, strMensaje)
                        MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK)
                    End If
                Else
                    MsgBox("El documento elegido no posee N° de Ticket. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_estado_sunat_Click(sender As Object, e As EventArgs) Handles btn_estado_sunat.Click
        If dtDocumentoFactura.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""

            For Each item As DataRow In dtDocumentoFactura.Select()
                dtDocumentoFactura.BeginInit()

                Ref_DOCUMENT_ID = item("TIPO") 'dgvDocumentosFactura.CurrentRow.Cells("TIPO").Value
                Ref_NUMBER_SERIE = item("SERIE") 'dgvDocumentosFactura.CurrentRow.Cells("SERIE").Value
                Ref_NUMBER_DOCUMENT = item("NUMERO") 'dgvDocumentosFactura.CurrentRow.Cells("NUMERO").Value

                Ref_DOCUMENT_ID = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", ""))))
                '//para obtener solo mensaje
                Dim oConsultaCDR1 As New ConsultaCDR("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 1, strMensaje)
                oConsultaCDR1.getStatus(LibComunVar.ClsVarComun.RucEmpresa, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, strMensaje)
                item("ESTADO_CPE_SUNAT") = strMensaje
                strMensaje = ""
                dtDocumentoFactura.EndInit()
                dtDocumentoFactura.AcceptChanges()
            Next

            If GuardarFacturacion_Estado_Sunat() Then
                Call DocumentosFactura()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GuardarFacturacion_Estado_Sunat() As Boolean
        Dim indicadorF As Boolean = True
        Try
            ''Cabecera FACTURA
            cabeceraBL = New ClsOperaciones.RECEIVABLE
            cabeceraBE = New ClsEntidades.RECEIVABLE
            ls_det = New List(Of ClsEntidades.RECEIVABLE)

            'Detalle de Factura
            For i As Integer = 0 To dtDocumentoFactura.Rows.Count() - 1
                cabeceraBE = New ClsEntidades.RECEIVABLE
                With cabeceraBE
                    .DOCUMENT_ID = dtDocumentoFactura.Rows(i).Item("TIPO").ToString
                    .NUMBER_SERIE = dtDocumentoFactura.Rows(i).Item("SERIE").ToString
                    .NUMBER_DOCUMENT = dtDocumentoFactura.Rows(i).Item("NUMERO").ToString

                    .CDR = dtDocumentoFactura.Rows(i).Item("ESTADO_CPE_SUNAT").ToString
                End With
                ls_det.Add(cabeceraBE)
            Next

            If cabeceraBL.GuardarFactura_Actualiza_Estado_Cpe_SUNAT(ls_det) = False Then
                MsgBox("Hubo un Error en la Actualización de los documentos Electronicos", MsgBoxStyle.Critical)
                indicadorF = False
                Exit Try
            End If

        Catch ex As Exception
            indicadorF = False
            MsgBox(ex.Message)
        End Try
        Return indicadorF
    End Function
End Class