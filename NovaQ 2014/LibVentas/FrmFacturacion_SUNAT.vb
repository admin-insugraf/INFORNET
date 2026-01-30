Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
Imports WSConsultaSUNAT
Imports LibBillService.Process

Public Class FrmFacturacion_SUNAT

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

    Private Sub FrmFacturacion_SUNAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboOpcionTipoDoc.SelectedIndex = 0
        cboopcionesBusqueda.SelectedIndex = 1
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        btn_generar_cpe.Visible = NIVEL_ACCESO()
        txtFiltro.Select()
    End Sub

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

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
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
                            STRorden = dgvDocumentosFactura2.Columns("NUMERO").Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvDocumentosFactura2.Columns("RUC.RECEP").Name
                                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                If dtv.Count() = 0 Then
                                    STRorden = String.Empty
                                    STRorden = dgvDocumentosFactura2.Columns("RECEPTOR").Name
                                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                    If dtv.Count() = 0 Then
                                        STRorden = String.Empty
                                        STRorden = dgvDocumentosFactura2.Columns("NUMERO").Name & "+" & dgvDocumentosFactura2.Columns("RUC.RECEP").Name & "+" & dgvDocumentosFactura2.Columns("RECEPTOR").Name
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

    Private Sub cboOpcionTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcionTipoDoc.SelectedIndexChanged
        If cboOpcionTipoDoc.Text = String.Empty Then Exit Sub
        DocumentosFactura()
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
            dtDocumentoFactura = clsFacturaBl.get_DatosGeneralesFacturacion_SUNAT(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                               cboopcionesBusqueda.SelectedIndex, IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text))
            dgvDocumentosFactura2.DataSource = Nothing
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
            dgvDocumentosFactura2.EnableHeadersVisualStyles = False
            dgvDocumentosFactura2.DataSource = dtv

            STRorden = dgvDocumentosFactura2.Columns("NUMERO").Name & "+" & dgvDocumentosFactura2.Columns("RUC.RECEP").Name & "+" & dgvDocumentosFactura2.Columns("RECEPTOR").Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"

            With dgvDocumentosFactura2.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            dgvDocumentosFactura2.Columns("OPE. GRABADAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura2.Columns("OPE. INAFECTAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura2.Columns("OPE. EXONERADAS").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura2.Columns("IGV").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura2.Columns("TOTAL").DefaultCellStyle.Format = "N2"
            dgvDocumentosFactura2.Columns("OPE. GRABADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura2.Columns("OPE. INAFECTAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura2.Columns("OPE. EXONERADAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura2.Columns("IGV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura2.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDocumentosFactura2.Columns("ESTADO").Width = 80
            dgvDocumentosFactura2.Columns("CDR").Width = 100
            dgvDocumentosFactura2.Columns("CRESUMEN").Width = 100
            dgvDocumentosFactura2.Columns("TIPO").Width = 40
            dgvDocumentosFactura2.Columns("SERIE").Width = 40
            dgvDocumentosFactura2.Columns("NUMERO").Width = 70
            dgvDocumentosFactura2.Columns("FECHA EMISION").Width = 70
            dgvDocumentosFactura2.Columns("TD RECEP").Width = 40
            dgvDocumentosFactura2.Columns("RUC.RECEP").Width = 80
            dgvDocumentosFactura2.Columns("RECEPTOR").Width = 250
            dgvDocumentosFactura2.Columns("OPE. GRABADAS").Width = 80
            dgvDocumentosFactura2.Columns("OPE. INAFECTAS").Width = 80
            dgvDocumentosFactura2.Columns("OPE. EXONERADAS").Width = 80
            dgvDocumentosFactura2.Columns("IGV").Width = 80
            dgvDocumentosFactura2.Columns("TOTAL").Width = 80
            dgvDocumentosFactura2.Columns("ESTADO FACTURACION").Width = 100
            dgvDocumentosFactura2.Columns("ESTADO_CPE_SUNAT").Width = 300
            dgvDocumentosFactura2.Columns("ESTADO_CPE_SUNAT").HeaderText = "ESTADO CPE SUNAT"

            For i As Integer = 17 To dgvDocumentosFactura2.Columns.Count - 1
                dgvDocumentosFactura2.Columns(i).Visible = False
            Next

            dgvDocumentosFactura2.Columns("ENVIO_MAIL").HeaderText = "Envio Mail"
            dgvDocumentosFactura2.Columns("ENVIO_MAIL").Width = 100
            dgvDocumentosFactura2.Columns("ENVIO_MAIL").Visible = True
            dgvDocumentosFactura2.Columns("ESTADO_CPE_SUNAT").Visible = True
        End If

    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosFactura()
        End If
    End Sub


    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub dgvDocumentosFactura_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        If dgvDocumentosFactura2.Rows(e.RowIndex).Cells("ESTADO FACTURACION").Value = "ANULADO" Then
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If

        dgvDocumentosFactura2.Columns("NUMERO").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura2.Columns("TIPO").DefaultCellStyle.BackColor = Color.BlanchedAlmond
        dgvDocumentosFactura2.Columns("SERIE").DefaultCellStyle.BackColor = Color.BlanchedAlmond

    End Sub

    Private Sub cboOpcionTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles cboOpcionTipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboopcionesBusqueda.Select()
        End If
    End Sub

    Private Sub cboopcionesBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboopcionesBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvDocumentosFactura2.Select()
        End If
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

            '//RECORRE LOS CDR DE LAS FT,NC,ND 
            For Each item As DataRow In dtDocumentoFactura.Select("BUSCA_CDR='SI'")
                dtDocumentoFactura.BeginInit()

                _nombre_archivo = "R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & item("SUNAT_ID") & "-" & item("SERIE") & "-" & item("NUMERO") & ".xml"

                If File.Exists(Ruta_FE_Verificacion() & "CDR\" & _nombre_archivo) = False Then
                    StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _nombre_archivo
                    If File.Exists(StrNomArchivo_CDR) Then
                        If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & item("SUNAT_ID") & " -  " & item("SERIE") & item("NUMERO") & ".CDR" & Chr(13) & _
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
            '//RECORRE LOS CDR DE LAS COMUNICACIONES DE BAJA Y RESUMENES DE LAS BOLETAS
            For Each item As DataRow In dtDocumentoFactura.Select("BUSCA_CDR='NO'")
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

            '//RECORRE LOS TICKETS
            For Each item As DataRow In dtDocumentoFactura.Select("BUSCA_CDR='NO' AND CDR=''")
                dtDocumentoFactura.BeginInit()

                If item("NOMBRE_CB").ToString <> "" Then
                    _nombre_archivo = LibComunVar.ClsVarComun.RucEmpresa & "-" & Strings.Mid(item("NOMBRE_CB"), 1, Strings.Len(item("NOMBRE_CB")) - 3) & "log"
                Else
                    _nombre_archivo = ""
                End If


                If File.Exists(Ruta_FE_Verificacion() & "\Output\Send\Ticket\" & _nombre_archivo) Then
                    _id_ticket = Leer_Ticket(Ruta_FE_Verificacion() & "\Output\Send\Ticket\" & _nombre_archivo)
                Else
                    _id_ticket = ""
                End If

                item("CRESUMEN") = _id_ticket

                dtDocumentoFactura.EndInit()
                dtDocumentoFactura.AcceptChanges()

                _existe_pendiente = True
            Next


            If _existe_pendiente Then
                If GuardarFacturacion() Then
                    Call DocumentosFactura()
                End If
            End If


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

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

            If cabeceraBL.GuardarFactura_Actualiza_SUNAT(ls_det) = False Then
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

    Private Sub btn_ver_pdf_Click(sender As Object, e As EventArgs) Handles btn_ver_pdf.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

        Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
        Dim dtCabeceraFact As DataTable
        Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
        Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
        Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value

        Dim StrNomArchivo_PDF As String = ""
        Dim StrNomArchivo_XML As String = ""
        If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then
            Dim _fecha_doc As Date

            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable

            dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7))
            If dtCabeceraFact.Rows.Count() <> 0 Then
                _fecha_doc = dtCabeceraFact.Rows(0).Item("CREATE_DATE")
            Else
                Exit Sub
            End If

            'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
            StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

            If File.Exists(StrNomArchivo_PDF) Then
                System.Diagnostics.Process.Start(StrNomArchivo_PDF)
            Else
                StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                                    Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03",
                                    IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" &
                                    Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) Then
                    If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                        If File.Exists(StrNomArchivo_PDF) Then
                            System.Diagnostics.Process.Start(StrNomArchivo_PDF)
                        Else
                            Dim msj As String = ""
                            msj = String.Empty
                            msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                            MsgBox(msj, MsgBoxStyle.Information)
                        End If
                    Else
                        MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".PDF" & Chr(13) & _
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If
                Else
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If


            'VERIFICAMOS SI SE ENCUENTRA EN LA RUTA DEL SERVIDOR
            StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & _
                                "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & _
                                "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

            If File.Exists(StrNomArchivo_XML) = False Then
                StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                            _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                            Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                            IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                            Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                If File.Exists(StrNomArchivo_XML) Then
                    If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                        MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".xml" & Chr(13) & _
                        "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                    End If
                Else
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                    MsgBox(msj, MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        End If

    End Sub

    Private Sub btn_ver_cdr_Click(sender As Object, e As EventArgs) Handles btn_ver_cdr.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

        Dim _frm_cdr As New Frm_CDR
        _frm_cdr._tipo_documento = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
        _frm_cdr._serie_documento = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
        _frm_cdr._numero_documento = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
        _frm_cdr._tipo_doc_electronico = "FT"
        _frm_cdr.ShowDialog()
    End Sub

    Private Sub btn_reenvio_email_Click(sender As Object, e As EventArgs) Handles btn_reenvio_email.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String, Envio_Mail_Cliente As String, REF_COD_ALMACEN As String
            Dim dtCabeceraFact As DataTable
            Dim _fecha_doc As Date
            Dim _EMAIL_RECEPCIONANTE As String = ""
            Dim StrNomArchivo_PDF As String = ""
            Dim StrNomArchivo_XML As String = ""
            Dim StrNomArchivo_CDR As String = ""
            Dim StrNomArchivo_PDF_GS As String = ""
            Dim StrNomArchivo_XML_GS As String = ""
            Dim tiene_guia As Boolean = False

            Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
            Envio_Mail_Cliente = dgvDocumentosFactura2.CurrentRow.Cells("ENVIO_MAIL").Value
            REF_COD_ALMACEN = dgvDocumentosFactura2.CurrentRow.Cells("COD_ALMACEN").Value

            If Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B" Then

                clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
                dtCabeceraFact = New DataTable

                dtCabeceraFact = clsFacturaCabBl.get_CabecearaFacturacion(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7))
                If dtCabeceraFact.Rows.Count() <> 0 Then
                    _fecha_doc = dtCabeceraFact.Rows(0).Item("CREATE_DATE")
                    _EMAIL_RECEPCIONANTE = dtCabeceraFact.Rows(0).Item("EMAIL")
                Else
                    Exit Sub
                End If

                'BUSCAMOS LOS ARCHIVOS PDF Y XML DESDE LA RUTA GENERAL DEL SERVIDOR
                'PDF
                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", _
                                    IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & _
                                    Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                If File.Exists(StrNomArchivo_PDF) = False Then
                    StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") & "\" &
                                        Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"

                    If File.Exists(StrNomArchivo_PDF) = True Then
                        If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".PDF" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                'XML
                StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & _
                                    IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", _
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                If File.Exists(StrNomArchivo_XML) = False Then
                    StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & Format(_fecha_doc.Month, "00") &
                                        "\" & Format(_fecha_doc.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_XML) = True Then
                        If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".XML" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If

                'CDR
                StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & _
                                    IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", _
                                    IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                If File.Exists(StrNomArchivo_CDR) = False Then
                    StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"

                    If File.Exists(StrNomArchivo_CDR) = True Then
                        If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = False Then
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".CDR" & Chr(13) & _
                                    "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".cdr"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
                'FIN DE BUSCAMOS LOS ARCHIVOS PDF Y XML DESDE LA RUTA GENERAL DEL SERVIDOR

                StrNomArchivo_PDF = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".pdf"
                If File.Exists(StrNomArchivo_PDF) = False Then
                    Dim msj As String = ""
                    msj = String.Empty
                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"
                    MsgBox(msj, MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    StrNomArchivo_XML = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                    If File.Exists(StrNomArchivo_XML) = False Then
                        Dim msj As String = ""
                        msj = String.Empty
                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"
                        MsgBox(msj, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        StrNomArchivo_CDR = Ruta_FE_Verificacion() & "CDR\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Ref_NUMBER_DOCUMENT), "00000000") & ".xml"
                        If File.Exists(StrNomArchivo_CDR) = False Then
                            Dim msj As String = ""
                            msj = String.Empty
                            msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".cdr"
                            MsgBox(msj, MsgBoxStyle.Critical)
                            Exit Sub
                        Else
                            If Envio_Mail_Cliente = "SI" Then
                                If MessageBox.Show("Los archivos electronicos ya se enviarón en un Mail anterior!!!" & Chr(13) & "¿Desea Continuar con el envio?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                                    '**************
                                    Dim GuiaBl As New ClsBuscar
                                    Dim dtDatosGuia As New DataTable
                                    dtDatosGuia = GuiaBl.Get_GuiasAsociadas(REF_COD_ALMACEN, Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7), Ref_DOCUMENT_ID)
                                    If dtDatosGuia.Rows.Count() <> 0 Then
                                        If Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 1) = "T" Then

                                            If MessageBox.Show("Dese adjuntar la guia del comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                                StrNomArchivo_PDF_GS = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                If File.Exists(StrNomArchivo_PDF_GS) = False Then
                                                    StrNomArchivo_PDF_GS = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                            Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                            LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                            Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                            "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                    If File.Exists(StrNomArchivo_PDF_GS) Then
                                                        If Copiar_Archivos(StrNomArchivo_PDF_GS, Ruta_FE_Verificacion() & "PDF") = False Then
                                                            MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".PDF" & Chr(13) &
                                                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                        End If
                                                    Else
                                                        Dim msj As String = ""
                                                        msj = String.Empty
                                                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                                        MsgBox(msj, MsgBoxStyle.Information)
                                                        Exit Sub
                                                    End If
                                                End If

                                                StrNomArchivo_XML_GS = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                If File.Exists(StrNomArchivo_XML_GS) = False Then
                                                    StrNomArchivo_XML_GS = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                            Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                            LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                            Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                            "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                    If File.Exists(StrNomArchivo_XML_GS) Then
                                                        If Copiar_Archivos(StrNomArchivo_XML_GS, Ruta_FE_Verificacion() & "XML") = False Then
                                                            MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".XML" & Chr(13) &
                                                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                        End If
                                                    Else
                                                        Dim msj As String = ""
                                                        msj = String.Empty
                                                        msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"
                                                        MsgBox(msj, MsgBoxStyle.Information)
                                                        Exit Sub
                                                    End If
                                                End If

                                                Dim envio_mail As New FrmEnvioEmail_FT_GS
                                                envio_mail._document_id = Ref_DOCUMENT_ID
                                                envio_mail._serie_document = Ref_NUMBER_SERIE
                                                envio_mail._number_document = Ref_NUMBER_DOCUMENT

                                                envio_mail._serie_document_gs = Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7)
                                                envio_mail._number_document_gs = Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")

                                                envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                                envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                                envio_mail._nombre_documento_gs = "09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")
                                                envio_mail._archivo_pdf = StrNomArchivo_PDF
                                                envio_mail._archivo_xml = StrNomArchivo_XML
                                                envio_mail._archivo_cdr = StrNomArchivo_CDR
                                                envio_mail._archivo_pdf_gs = StrNomArchivo_PDF_GS
                                                envio_mail._archivo_xml_gs = StrNomArchivo_XML_GS
                                                envio_mail._codigo_datos_email = "99"
                                                envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                                envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                                envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                                IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))

                                                envio_mail._nombre_tipo_documento_gs = "GUÍA DE REMISION REMITENTE ELECTRÓNICA"

                                                envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                                envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                                envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                                envio_mail.ShowDialog()
                                                envio_mail.Close()

                                            Else
                                                Dim envio_mail As New FrmEnvioEmail
                                                envio_mail._document_id = Ref_DOCUMENT_ID
                                                envio_mail._serie_document = Ref_NUMBER_SERIE
                                                envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                                envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                                envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                                envio_mail._archivo_pdf = StrNomArchivo_PDF
                                                envio_mail._archivo_xml = StrNomArchivo_XML
                                                envio_mail._archivo_cdr = StrNomArchivo_CDR
                                                envio_mail._codigo_datos_email = "99"
                                                envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                                envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                                envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                                IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                                envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                              IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                                envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                                envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                                envio_mail.ShowDialog()
                                                envio_mail.Close()
                                            End If
                                        Else
                                            Dim envio_mail As New FrmEnvioEmail
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                          IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()
                                        End If
                                    Else
                                        Dim envio_mail As New FrmEnvioEmail
                                        envio_mail._document_id = Ref_DOCUMENT_ID
                                        envio_mail._serie_document = Ref_NUMBER_SERIE
                                        envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                        envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                        envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                        envio_mail._archivo_pdf = StrNomArchivo_PDF
                                        envio_mail._archivo_xml = StrNomArchivo_XML
                                        envio_mail._archivo_cdr = StrNomArchivo_CDR
                                        envio_mail._codigo_datos_email = "99"
                                        envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                        envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                        envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                        envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                      IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                        envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                        envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                        envio_mail.ShowDialog()
                                        envio_mail.Close()
                                    End If
                                    '**************                                    
                                End If
                            Else
                                '**************
                                Dim GuiaBl As New ClsBuscar
                                Dim dtDatosGuia As New DataTable
                                dtDatosGuia = GuiaBl.Get_GuiasAsociadas(REF_COD_ALMACEN, Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7), Ref_DOCUMENT_ID)
                                If dtDatosGuia.Rows.Count() <> 0 Then
                                    If Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 1) = "T" Then

                                        If MessageBox.Show("Dese adjuntar la guia del comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                            StrNomArchivo_PDF_GS = Ruta_FE_Verificacion() & "PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                            If File.Exists(StrNomArchivo_PDF_GS) = False Then
                                                StrNomArchivo_PDF_GS = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                        Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                        LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"

                                                If File.Exists(StrNomArchivo_PDF_GS) Then
                                                    If Copiar_Archivos(StrNomArchivo_PDF_GS, Ruta_FE_Verificacion() & "PDF") = False Then
                                                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".PDF" & Chr(13) &
                                                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                    End If
                                                Else
                                                    Dim msj As String = ""
                                                    msj = String.Empty
                                                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".pdf"
                                                    MsgBox(msj, MsgBoxStyle.Information)
                                                    Exit Sub
                                                End If
                                            End If

                                            StrNomArchivo_XML_GS = Ruta_FE_Verificacion() & "XML\" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                    Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                    "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                            If File.Exists(StrNomArchivo_XML_GS) = False Then
                                                StrNomArchivo_XML_GS = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" & _fecha_doc.Year.ToString & "\" & _
                                                                        Format(_fecha_doc.Month, "00") & "\" & Format(_fecha_doc.Day, "00") & "\" & _
                                                                        LibComunVar.ClsVarComun.RucEmpresa & "-09-" & _
                                                                        Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & _
                                                                        "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"

                                                If File.Exists(StrNomArchivo_XML_GS) Then
                                                    If Copiar_Archivos(StrNomArchivo_XML_GS, Ruta_FE_Verificacion() & "XML") = False Then
                                                        MsgBox("ERROR:" & Chr(13) & "El documento 09 -  " & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".XML" & Chr(13) &
                                                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                                    End If
                                                Else
                                                    Dim msj As String = ""
                                                    msj = String.Empty
                                                    msj = "No existe el archivo " & vbCrLf & "" & LibComunVar.ClsVarComun.RucEmpresa & "-09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000") & ".xml"
                                                    MsgBox(msj, MsgBoxStyle.Information)
                                                    Exit Sub
                                                End If
                                            End If

                                            Dim envio_mail As New FrmEnvioEmail_FT_GS
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT

                                            envio_mail._serie_document_gs = Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7)
                                            envio_mail._number_document_gs = Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")

                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._nombre_documento_gs = "09-" & Strings.Left(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, Strings.Len(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString) - 7) & "-" & Format(CInt(Strings.Right(dtDatosGuia.Rows(0).Item("NUMBER_DOCUMENT").ToString, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._archivo_pdf_gs = StrNomArchivo_PDF_GS
                                            envio_mail._archivo_xml_gs = StrNomArchivo_XML_GS
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))

                                            envio_mail._nombre_tipo_documento_gs = "GUÍA DE REMISION REMITENTE ELECTRÓNICA"

                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                          IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()

                                        Else
                                            Dim envio_mail As New FrmEnvioEmail
                                            envio_mail._document_id = Ref_DOCUMENT_ID
                                            envio_mail._serie_document = Ref_NUMBER_SERIE
                                            envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                            envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                            envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                            envio_mail._archivo_pdf = StrNomArchivo_PDF
                                            envio_mail._archivo_xml = StrNomArchivo_XML
                                            envio_mail._archivo_cdr = StrNomArchivo_CDR
                                            envio_mail._codigo_datos_email = "99"
                                            envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                            envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                            envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                            IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                            envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                          IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                            envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                            envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                            envio_mail.ShowDialog()
                                            envio_mail.Close()
                                        End If
                                    Else
                                        Dim envio_mail As New FrmEnvioEmail
                                        envio_mail._document_id = Ref_DOCUMENT_ID
                                        envio_mail._serie_document = Ref_NUMBER_SERIE
                                        envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                        envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                        envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                        envio_mail._archivo_pdf = StrNomArchivo_PDF
                                        envio_mail._archivo_xml = StrNomArchivo_XML
                                        envio_mail._archivo_cdr = StrNomArchivo_CDR
                                        envio_mail._codigo_datos_email = "99"
                                        envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                        envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                        envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                        IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                        envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                      IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                        envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                        envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                        envio_mail.ShowDialog()
                                        envio_mail.Close()
                                    End If
                                Else
                                    Dim envio_mail As New FrmEnvioEmail
                                    envio_mail._document_id = Ref_DOCUMENT_ID
                                    envio_mail._serie_document = Ref_NUMBER_SERIE
                                    envio_mail._number_document = Ref_NUMBER_DOCUMENT
                                    envio_mail._ruc_electronico = LibComunVar.ClsVarComun.RucEmpresa
                                    envio_mail._nombre_documento = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000")
                                    envio_mail._archivo_pdf = StrNomArchivo_PDF
                                    envio_mail._archivo_xml = StrNomArchivo_XML
                                    envio_mail._archivo_cdr = StrNomArchivo_CDR
                                    envio_mail._codigo_datos_email = "99"
                                    envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                                    envio_mail._EMAIL_RECEPCIONANTE = _EMAIL_RECEPCIONANTE

                                    envio_mail._nombre_tipo_documento = IIf(Ref_DOCUMENT_ID = "BV", "BOLETA DE VENTA ELECTRÓNICA", _
                                                                            IIf(Ref_DOCUMENT_ID = "FT", "FACTURA ELECTRÓNICA", _
                                                                                IIf(Ref_DOCUMENT_ID = "NC", "NOTA DE CRÉDITO ELECTRÓNICA", _
                                                                                    IIf(Ref_DOCUMENT_ID = "ND", "NOTA DE DÉBITO ELECTRÓNICA", ""))))
                                    envio_mail._tipo_moneda = IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "MN", "S/", _
                                                                  IIf(dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value = "ME", "$", ""))
                                    envio_mail._monto_documento = dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value
                                    envio_mail._fecha_documento = dgvDocumentosFactura2.CurrentRow.Cells("FECHA EMISION").Value


                                    envio_mail.ShowDialog()
                                    envio_mail.Close()
                                End If
                                '************** 
                            End If

                        End If
                    End If
                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_verifica_estado_manual_Click(sender As Object, e As EventArgs) Handles btn_verifica_estado_manual.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""
            Dim estado_facturacion As String = ""
            Dim numero_ticket As String = ""

            Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura2.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura2.CurrentRow.Cells("TICKET_RB").Value

            Ref_DOCUMENT_ID = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", ""))))
            '//para obtener solo mensaje
            Dim oConsultaCDR1 As New ConsultaCDR("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 1, strMensaje)
            oConsultaCDR1.getStatus(LibComunVar.ClsVarComun.RucEmpresa, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, strMensaje)
            MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_reenviar_doc_sunat_Click(sender As Object, e As EventArgs) Handles btn_reenviar_doc_sunat.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

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

            'If Strings.Left(dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value, 1) = "B" Then
            '    Me.Cursor = Cursors.Default
            '    MsgBox("Documento elegido no aplica el Proceso de Re-envio a SUNAT. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            If CInt(dgvDocumentosFactura2.CurrentRow.Cells("DIAS").Value) > 3 Then
                Me.Cursor = Cursors.Default
                MsgBox("No aplica el Proceso de Re-envio a SUNAT, por superar el limite de días habiles.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura2.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura2.CurrentRow.Cells("TICKET_RB").Value
            moneda = dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value
            obsequio = dgvDocumentosFactura2.CurrentRow.Cells("RECEIVABLE_TYPE").Value
            total = CDbl(dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value)

            If moneda = "MN" Then
                If obsequio = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Soles"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Soles"
                End If
            Else
                If obsequio = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Dólares Americanos"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Dólares Americanos"
                End If
            End If
            If MessageBox.Show("¿Desea Re-enviar el documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " a SUNAT?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Generar_FT_GS_Xml(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7), STRmontotexto, "SI", "2") = False Then
                    MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " no genero el archivo XML UBL 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                Else
                    Dim StrNomArchivo_XML As String = ""
                    Dim StrNomArchivo_PDF As String = ""
                    Dim _existe_pdf As Boolean = False

                    StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"

                    Dim oProcesaArchivo As New ProcesaArchivo

                    If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                        MsgBox(strMensaje, MsgBoxStyle.Critical)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    Else

                        StrNomArchivo_XML = Ruta_FE() & "\Output\Process\XML\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                            LibComunVar.ClsVarComun.FechaSistema.Year.ToString & "\" & Format(LibComunVar.ClsVarComun.FechaSistema.Month, "00") & "\" &
                            Format(LibComunVar.ClsVarComun.FechaSistema.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                            IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                            Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"

                        If File.Exists(StrNomArchivo_XML) Then
                            If Copiar_Archivos(StrNomArchivo_XML, Ruta_FE_Verificacion() & "XML") = True Then

                                StrNomArchivo_PDF = Ruta_FE() & "\Output\Process\PDF\" & LibComunVar.ClsVarComun.RucEmpresa & "\" &
                                                    LibComunVar.ClsVarComun.FechaSistema.Year.ToString & "\" & Format(LibComunVar.ClsVarComun.FechaSistema.Month, "00") & "\" &
                                                    Format(LibComunVar.ClsVarComun.FechaSistema.Day, "00") & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01",
                                                    IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" &
                                                    Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".pdf"

                                System.Threading.Thread.Sleep(2000)
                                If File.Exists(StrNomArchivo_PDF) Then

                                    If Copiar_Archivos(StrNomArchivo_PDF, Ruta_FE_Verificacion() & "PDF") = True Then
                                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " se genero correctamente", MsgBoxStyle.Information, "UBL 2.1")
                                    End If
                                Else
                                    MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".pdf" & Chr(13) & _
                                           "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                                End If
                            Else
                                MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".xml" & Chr(13) & _
                                       "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                            End If
                        End If
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function Generar_Txt(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _email_cliente As String = "", Optional ByVal _ruta As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_Txt(TipoDoc, SerieDoc, NumDoc, _ruta, Monto_Letras, _envia_email, _email_cliente) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Generar_FT_GS_Xml(ByVal TipoDoc As String, ByVal SerieDoc As String, ByVal NumDoc As String, ByVal Monto_Letras As String, _
                                 Optional ByVal _envia_email As String = "", _
                                 Optional ByVal _ticket_a4 As String = "") As Boolean
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Generar_FT_GS_Xml(TipoDoc, SerieDoc, NumDoc, Ruta_FE() & "\InputXML", Monto_Letras, _envia_email, _ticket_a4) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

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
        NUMEROLETRAS = cLET

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Ref_DOCUMENT_ID As String, Ref_NUMBER_SERIE As String, Ref_NUMBER_DOCUMENT As String
            Dim strMensaje As String = ""
            Dim strRespuesta As String = ""
            Dim estado_facturacion As String = ""
            Dim numero_ticket As String = ""
            Dim StrNomArchivo_CDR As String = ""
            Dim nombre_resumen_boletas As String = ""

            Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura2.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura2.CurrentRow.Cells("TICKET_RB").Value
            nombre_resumen_boletas = dgvDocumentosFactura2.CurrentRow.Cells("NOMBRE_CB").Value

            If (Ref_DOCUMENT_ID = "FT" Or Ref_DOCUMENT_ID = "NC" Or Ref_DOCUMENT_ID = "ND" Or Ref_DOCUMENT_ID = "BV") And (Strings.Left(Ref_NUMBER_SERIE, 1) = "F" Or Strings.Left(Ref_NUMBER_SERIE, 1) = "B") Then

                Ref_DOCUMENT_ID = IIf(Ref_DOCUMENT_ID = "FT", "01", IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", ""))))
                If MessageBox.Show("¿Desea obtener el CDR del documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    '// para obtener el CDR fisico
                    Dim oConsultaCDR2 As New ConsultaCDR("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 1, strMensaje)
                    oConsultaCDR2.getStatusCDR(Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa, LibComunVar.ClsVarComun.RucEmpresa, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT, strMensaje)

                    StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" &
                                                    Ref_DOCUMENT_ID & "-" & Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".XML"

                    If File.Exists(StrNomArchivo_CDR) Then

                        If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = True Then
                            MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".CDR" & Chr(13) &
                               "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If
                    Else
                        MsgBox("No existe el documento " & Chr(13) & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".CDR" &
                               ". Verifique!!!", MsgBoxStyle.Exclamation, "UBL 2.1")
                    End If
                End If
            ElseIf (Ref_DOCUMENT_ID = "BV" Or Ref_DOCUMENT_ID = "NC" Or Ref_DOCUMENT_ID = "ND") And (Strings.Left(Ref_NUMBER_SERIE, 1) = "B") Then
                If numero_ticket <> "" Then
                    If MessageBox.Show("¿Desea obtener el CDR del Resumen de Boletas: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        '//ingresa aki cuando sean enviados como resumen de boletas
                        Dim oConsultaCDR3 As New ConsultaCDR(" https://e-factura.sunat.gob.pe/ol-ti-itcpfegem/billService", LibComunVar.ClsVarComun.RucEmpresa & LibComunVar.ClsVarComun.STRUSUARIO_SOL, LibComunVar.ClsVarComun.STRPASSWORD_SOL, 2, strMensaje)
                        oConsultaCDR3.getStatusCDRResumen(Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa, numero_ticket, strMensaje)

                        StrNomArchivo_CDR = Ruta_FE() & "\Output\Send\CDR\" & LibComunVar.ClsVarComun.RucEmpresa & "\R-" & LibComunVar.ClsVarComun.RucEmpresa & "-" & nombre_resumen_boletas

                        System.Threading.Thread.Sleep(2000)
                        If File.Exists(StrNomArchivo_CDR) Then

                            If Copiar_Archivos(StrNomArchivo_CDR, Ruta_FE_Verificacion() & "CDR") = True Then
                                MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MsgBox("ERROR:" & Chr(13) & "El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & ".CDR" & Chr(13) &
                                   "no se pudo copiar a la carpeta de destino. Verifique!!!", MsgBoxStyle.Information, "UBL 2.1")
                        End If

                    End If
                Else
                    MsgBox("El documento elegido no posee N° de Ticket. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("El documento es invalido para esta opción. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dtDocumentoFactura.Rows.Count = 0 Then Exit Sub

        Try
            crystalBL = New LibReportes.ClsReporte
            Dim fq As New LibContabilidad.ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            Me.Cursor = Cursors.WaitCursor

            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            If dtDocumentoFactura.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Lista_Doc_Electronicos.rpt", dtDocumentoFactura, "", "", _
                                          "@FECHA_INI;" & dtpfechaInicial.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FIN;" & dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                          "@OPCION;" & cboopcionesBusqueda.SelectedIndex, _
                                          "@DOCUMENT_ID;" & IIf(cboOpcionTipoDoc.SelectedIndex = 0, "", cboOpcionTipoDoc.Text), _
                                          "pRuc;" & ruc, _
                                          "pRazon;" & razon)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm_Resumen_Boletas As New Frm_Resumen_Boletas
        frm_Resumen_Boletas.ShowDialog()
        Call DocumentosFactura()
    End Sub

    Private Sub btn_comunicacion_baja_Click(sender As Object, e As EventArgs) Handles btn_comunicacion_baja.Click
        Dim frm_comunicacion_baja As New Frm_Comunicacion_Bajas
        frm_comunicacion_baja.ShowDialog()
        Call DocumentosFactura()
    End Sub

    Private Sub dgvDocumentosFactura2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumentosFactura2.CellFormatting

        If dgvDocumentosFactura2.Rows(e.RowIndex).Cells("ESTADO FACTURACION").Value = "ANULADO" Then
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvDocumentosFactura2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
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

                Ref_DOCUMENT_ID = item("TIPO")
                Ref_NUMBER_SERIE = item("SERIE") 
                Ref_NUMBER_DOCUMENT = item("NUMERO")

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_generar_cpe.Click
        If dgvDocumentosFactura2.CurrentRow Is Nothing Then Exit Sub
        Dim _formato_cpe As String = "" ' 1--ticket y 2--A4

        _formato_cpe = String.Empty
        _formato_cpe = InputBox("Ingrese el codigo del formato del CPE:" & Chr(13) & "1-- para formato TICKET" & Chr(13) & "2-- para formato A4", "Opción de formato de CPE")
        While _formato_cpe = "" Or _formato_cpe <> ""
            If _formato_cpe <> "1" And _formato_cpe <> "2" Then
                MsgBox("Debe digitar una opción correcta!!!", MsgBoxStyle.Exclamation, "Sistemas")
                _formato_cpe = String.Empty
                _formato_cpe = InputBox("Ingrese el codigo del formato del CPE:" & Chr(13) & "1-- para formato TICKET" & Chr(13) & "2-- para formato A4", "Opción de formato de CPE")
                Continue While
            Else
                Exit While
            End If
        End While

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

            Ref_DOCUMENT_ID = dgvDocumentosFactura2.CurrentRow.Cells("TIPO").Value
            Ref_NUMBER_SERIE = dgvDocumentosFactura2.CurrentRow.Cells("SERIE").Value
            Ref_NUMBER_DOCUMENT = dgvDocumentosFactura2.CurrentRow.Cells("NUMERO").Value
            estado_facturacion = dgvDocumentosFactura2.CurrentRow.Cells("ESTADO FACTURACION").Value
            numero_ticket = dgvDocumentosFactura2.CurrentRow.Cells("TICKET_RB").Value
            moneda = dgvDocumentosFactura2.CurrentRow.Cells("MONEDA").Value
            obsequio = dgvDocumentosFactura2.CurrentRow.Cells("RECEIVABLE_TYPE").Value
            total = CDbl(dgvDocumentosFactura2.CurrentRow.Cells("TOTAL").Value)

            If moneda = "MN" Then
                If obsequio = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Soles"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Soles"
                End If
            Else
                If obsequio = "FO" Then
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Dólares Americanos"
                Else
                    STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(total))) & " Dólares Americanos"
                End If
            End If
            If MessageBox.Show("¿Desea generar el documento: " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Ref_NUMBER_DOCUMENT & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Generar_FT_GS_Xml(Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Strings.Right(Ref_NUMBER_DOCUMENT, 7), STRmontotexto, "SI", _formato_cpe) = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " no genero el archivo XML UBL 2.1." & Chr(13) & "Realizar la revisión.", MsgBoxStyle.Critical, "Sistemas")
                Else
                    Dim StrNomArchivo_XML As String = ""
                    Dim StrNomArchivo_PDF As String = ""
                    Dim _existe_pdf As Boolean = False

                    StrNomArchivo_XML = Ruta_FE() & "\InputXML" & "\" & LibComunVar.ClsVarComun.RucEmpresa & "-" & IIf(Ref_DOCUMENT_ID = "FT", "01", _
                                        IIf(Ref_DOCUMENT_ID = "BV", "03", IIf(Ref_DOCUMENT_ID = "NC", "07", IIf(Ref_DOCUMENT_ID = "ND", "08", "")))) & "-" & _
                                        Ref_NUMBER_SERIE & "-" & Format(CInt(Strings.Right(Ref_NUMBER_DOCUMENT, 7)), "00000000") & ".xml"

                    Dim oProcesaArchivo As New ProcesaArchivo

                    If Not oProcesaArchivo.p_ProcesaArchivo(StrNomArchivo_XML, strMensaje) Then
                        Me.Cursor = Cursors.Default
                        MsgBox(strMensaje, MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        MsgBox("El documento " & Ref_DOCUMENT_ID & " -  " & Ref_NUMBER_SERIE & Strings.Right(Ref_NUMBER_DOCUMENT, 7) & " se genero correctamente", MsgBoxStyle.Information, "UBL 2.1")
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class