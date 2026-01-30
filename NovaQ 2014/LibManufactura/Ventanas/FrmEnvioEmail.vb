Imports System.Windows.Forms
Imports System.Net.Mail
Public Class FrmEnvioEmail
    Public _almacen_id As String
    Public _serie_doc As String
    Public _document_id As String
    Public _number_document As String
    Public _codigo_datos_email As String
    Public _USER_MAIL As String = String.Empty
    Public _TIPO_ESTADO As String = String.Empty

    Dim clsBusquedaBl As ClsBuscar
    Dim _REMITENTE As String
    Dim _RECEPCIONANTE As String
    Dim _SERVER As String
    Dim _USUARIO As String
    Dim _PASSWORD As String
    Dim _ASUNTO As String
    Dim _TITULO As String
    Dim _PUERTO As String
    Dim _mensaje As String

    Private Sub FrmEnvioEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtremitente.Text = _USER_MAIL
            Dim DT_DATOS_ENVIO_EMAIL As DataTable
            DT_DATOS_ENVIO_EMAIL = New DataTable
            clsBusquedaBl = New ClsBuscar
            Dim DT_MENSAJE As DataTable
            DT_MENSAJE = New DataTable
            txtremitente.Visible = False
            lbldelinea.Visible = False
            lblde.Visible = False
            DT_DATOS_ENVIO_EMAIL = clsBusquedaBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL(_codigo_datos_email)
            If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
                _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
                _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
                _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
                _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
                _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
                _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
                _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
                _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
                txtPara.Text = _RECEPCIONANTE
                txtAsunto.Text = _ASUNTO
                '--CONFIGURACION DEL ASUNTO
                If _codigo_datos_email = "00" Then
                    DT_MENSAJE = clsBusquedaBl.GET_MENSAJE(_almacen_id, _document_id, _number_document)
                    If DT_MENSAJE.Rows.Count() <> 0 Then
                        _mensaje = "Se registro la siguiente transacción: " & vbCrLf & vbCrLf
                        _mensaje = _mensaje & " TIPO : " & _TITULO & vbCrLf
                        _mensaje = _mensaje & " TRANSACCION : " & DT_MENSAJE.Rows(0).Item("TRANS_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_TRANSACCION").ToString & vbCrLf
                        _mensaje = _mensaje & " ALMACEN : " & DT_MENSAJE.Rows(0).Item("WAREHOUSE_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_ALMACEN").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REGISTRO : " & DT_MENSAJE.Rows(0).Item("DOCUMENT_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUMBER_DOCUMENT").ToString & vbCrLf
                        _mensaje = _mensaje & " FECHA Y HORA : " & DT_MENSAJE.Rows(0).Item("DATE_DOCUMENT").ToString & " - " & DT_MENSAJE.Rows(0).Item("HOUR").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REFERENCIA : " & DT_MENSAJE.Rows(0).Item("DOC_ID_REF").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUM_ID_REF").ToString & vbCrLf
                        _mensaje = _mensaje & " PROVEEDOR : " & DT_MENSAJE.Rows(0).Item("VENDOR_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("VENDOR_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " CLIENTE : " & DT_MENSAJE.Rows(0).Item("CUSTOMER_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("CUSTOMER_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " DETALLES : " & vbCrLf
                        For I As Integer = 0 To DT_MENSAJE.Rows.Count() - 1
                            _mensaje = _mensaje & "   - " & DT_MENSAJE.Rows(I).Item("ITEM").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_ID").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_DESCRIPTION").ToString & ";  CANTIDAD : " & DT_MENSAJE.Rows(I).Item("QTY").ToString & " " & DT_MENSAJE.Rows(I).Item("UNIT_PART").ToString & ";  NUM. BULTOS : " & DT_MENSAJE.Rows(I).Item("QT_BULTOS").ToString & ";  PROCEDENCIA : " & DT_MENSAJE.Rows(I).Item("PROCEDENCIA").ToString & ";  PAIS ORIGEN : " & DT_MENSAJE.Rows(I).Item("PAIS_ORIGEN").ToString & vbCrLf
                            _mensaje = _mensaje & "      LOTE: " & DT_MENSAJE.Rows(I).Item("NUMBER_LOT").ToString & ";  FECHA VENC. : " & CDate(DT_MENSAJE.Rows(I).Item("CADUCATE_DATE").ToString).ToString("MMMM-yyyy") & "; NUM. PROTOCOLO: " & DT_MENSAJE.Rows(I).Item("NUM_PROTOCOLOS").ToString & "; NUM. DE ANALISIS: " & DT_MENSAJE.Rows(I).Item("NUMBER_ANALIS").ToString & vbCrLf & vbCrLf
                        Next
                        _mensaje = _mensaje & vbCrLf
                        _mensaje = _mensaje & "Atte."
                        txtMensaje.Text = _mensaje
                    Else
                        txtMensaje.Text = "No hay datos para mostrar..."
                    End If
                    '--FIN DE CONFIGURACION DEL ASUNTO
                ElseIf _codigo_datos_email = "05" Or _codigo_datos_email = "06" Then
                    DT_MENSAJE = clsBusquedaBl.Detalle_Correo(_document_id, _serie_doc, _number_document)
                    If DT_MENSAJE.Rows.Count() <> 0 Then
                        Dim QUERY As String = String.Empty
                        QUERY = "Se realizo el siguiente REGISTRO DE DEVOLUCION :" + vbCrLf + vbCrLf
                        QUERY = QUERY & " DOCUMENTO : " & DT_MENSAJE.Rows(0).Item("DOCUMENT_ID") & " " & DT_MENSAJE.Rows(0).Item("NUMBER_SERIE") & "-" & DT_MENSAJE.Rows(0).Item("NUMBER_DOCUMENT") + vbCrLf
                        QUERY = QUERY & " FECHA     : " & CStr(DT_MENSAJE.Rows(0).Item("DOCUMENT_DATE")) + vbCrLf
                        QUERY = QUERY & " CLIENTE   : " & DT_MENSAJE.Rows(0).Item("CUSTOMER_ID") & "  " & DT_MENSAJE.Rows(0).Item("CUSTOMER_NAME") + vbCrLf
                        QUERY = QUERY & " DOC. DEVOLUCION : " & DT_MENSAJE.Rows(0).Item("DOC_DEVOLUCION") + vbCrLf
                        'QUERY = QUERY & " DOC. REF. : " & RS_datos("DOCUMENT_REF") & " " & RS_datos("SERIE_REF") & "-" & RS_datos("NUMBER_REF") + Chr(13)
                        QUERY = QUERY & " OBS. GENERALES DE ALMACEN : " & DT_MENSAJE.Rows(0).Item("COMMENT_ALMACEN") + vbCrLf
                        'QUERY = QUERY & " OBS. GENERALES DE DIR. TECNICA : " & DT_MENSAJE.Rows(0).Item("COMMENT_DIR") + vbCrLf + vbCrLf

                        If _TIPO_ESTADO = "1" Then
                            QUERY = QUERY & " DETALLE DE PRODUCTOS : " + vbCrLf + vbCrLf
                            For Each RS_datos As DataRow In DT_MENSAJE.Rows
                                QUERY = QUERY & RS_datos("ITEM") & ".-  " & RS_datos("PART_ID") & "  -  " & RS_datos("PART_DESCRIPTION") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Cantidad : " & CStr(CInt(RS_datos("QTY"))) & " unidad(es)" & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Número de Lote : " & RS_datos("PART_LOT") & ", Vcto. de Lote : " & RS_datos("FEC_VCTO") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Motivo de Devolución : " & RS_datos("MOTIVO_DEVOLUCION") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Observaciones de Devolución : " & IIf(Trim(RS_datos("OBSERVACIONES")) = "", "ninguna", RS_datos("OBSERVACIONES")) & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Fin de Devolución : " & RS_datos("FIN_DEVOLUCION_ID") & "" + vbCrLf + vbCrLf
                            Next
                        ElseIf _TIPO_ESTADO = "2" Then
                            QUERY = QUERY & " OBS. GENERALES DE DIR. TECNICA : " & DT_MENSAJE.Rows(0).Item("COMMENT_DIR") + vbCrLf + vbCrLf
                            QUERY = QUERY & " DETALLE DE PRODUCTOS : " + vbCrLf + vbCrLf

                            For Each RS_datos As DataRow In DT_MENSAJE.Rows
                                QUERY = QUERY & RS_datos("ITEM") & ".-  " & RS_datos("PART_ID") & "  -  " & RS_datos("PART_DESCRIPTION") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Cantidad : " & CStr(CInt(RS_datos("QTY"))) & " unidad(es)" & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Número de Lote : " & RS_datos("PART_LOT") & ", Vcto. de Lote : " & RS_datos("FEC_VCTO") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Motivo de Devolución : " & RS_datos("MOTIVO_DEVOLUCION") & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Observaciones de Devolución : " & IIf(Trim(RS_datos("OBSERVACIONES")) = "", "ninguna", RS_datos("OBSERVACIONES")) & "" + vbCrLf
                                QUERY = QUERY & vbTab + "Fin de Devolución : " & RS_datos("FIN_DEVOLUCION_ID") & "" + vbCrLf + vbCrLf
                            Next

                        ElseIf _TIPO_ESTADO = "3" Then
                            For Each RS_datos As DataRow In DT_MENSAJE.Rows
                                QUERY = QUERY & RS_datos("ITEM") & ".-  " & RS_datos("PART_ID") & "  " & RS_datos("PART_DESCRIPTION") & ", Cantidad : " & CStr(CInt(RS_datos("QTY"))) & " unidad(es), Número de Lote : " & RS_datos("PART_LOT") & ", Vcto. de Lote : " & RS_datos("FEC_VCTO") & " , Motivo de Devolución : " & RS_datos("MOTIVO_DEVOLUCION") & ", Observaciones de Devolución : " & IIf(Trim(RS_datos("OBSERVACIONES")) = "", "ninguna", RS_datos("OBSERVACIONES")) & ", Fin de Devolución : " & RS_datos("FIN_DEVOLUCION_ID") & ", Obs. de Fin de Devolución : " & IIf(Trim(RS_datos("TEXTO_FIN_DEVOLUCION_ID")) = "", "ninguna", RS_datos("TEXTO_FIN_DEVOLUCION_ID")) & ", Almacen Destino : " & RS_datos("NAME") & ",  ESTADO : " & RS_datos("OPT_APROB") + Chr(13)
                            Next
                        End If
                        QUERY = QUERY & "" + vbCrLf + vbCrLf
                        QUERY = QUERY & " Atte." + vbCrLf
                        txtMensaje.Text = QUERY
                    End If
                ElseIf _codigo_datos_email = "02" Or _codigo_datos_email = "07" Then
                    txtremitente.Visible = True
                    lbldelinea.Visible = True
                    lblde.Visible = True
                    DT_MENSAJE = clsBusquedaBl.Detalle_Correo_Requisiciones(_document_id, _number_document)
                    If DT_MENSAJE.Rows.Count() <> 0 Then
                        _mensaje = "Se registro la siguiente transacción: " & vbCrLf & vbCrLf
                        _mensaje = _mensaje & " TIPO : " & _TITULO & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REGISTRO : " & DT_MENSAJE.Rows(0).Item("TYPE").ToString & " - " & DT_MENSAJE.Rows(0).Item("ID").ToString & vbCrLf
                        _mensaje = _mensaje & " FECHA : " & DT_MENSAJE.Rows(0).Item("REQUIRED_DATE") & vbCrLf
                        _mensaje = _mensaje & " AREA : " & DT_MENSAJE.Rows(0).Item("AREA").ToString & vbCrLf
                        _mensaje = _mensaje & " SOLICITANTE : " & DT_MENSAJE.Rows(0).Item("SOLICITANTE").ToString & vbCrLf
                        _mensaje = _mensaje & " DETALLES : " & vbCrLf
                        For I As Integer = 0 To DT_MENSAJE.Rows.Count() - 1
                            _mensaje = _mensaje & "   - " & DT_MENSAJE.Rows(I).Item("ITEM").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_ID").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_DESCRIPTION").ToString & ";  CANTIDAD : " & DT_MENSAJE.Rows(I).Item("QTY").ToString & " " & DT_MENSAJE.Rows(I).Item("UNIT").ToString & vbCrLf
                        Next
                        _mensaje = _mensaje & vbCrLf
                        _mensaje = _mensaje & "Atte." + Chr(13)
                        txtMensaje.Text = _mensaje
                    Else
                        txtMensaje.Text = "No hay datos para mostrar..."
                    End If

                ElseIf _codigo_datos_email = "03" Then
                    DT_MENSAJE = clsBusquedaBl.GET_MENSAJE(_almacen_id, _document_id, _number_document)
                    If DT_MENSAJE.Rows.Count() <> 0 Then
                        _mensaje = "Se registro la siguiente transacción: " & vbCrLf & vbCrLf
                        _mensaje = _mensaje & " TIPO : " & _TITULO & vbCrLf
                        _mensaje = _mensaje & " TRANSACCION : " & DT_MENSAJE.Rows(0).Item("TRANS_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_TRANSACCION").ToString & vbCrLf
                        _mensaje = _mensaje & " ALMACEN : " & DT_MENSAJE.Rows(0).Item("WAREHOUSE_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_ALMACEN").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REGISTRO : " & DT_MENSAJE.Rows(0).Item("DOCUMENT_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUMBER_DOCUMENT").ToString & vbCrLf
                        _mensaje = _mensaje & " FECHA Y HORA : " & DT_MENSAJE.Rows(0).Item("DATE_DOCUMENT").ToString & " - " & DT_MENSAJE.Rows(0).Item("HOUR").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REFERENCIA : " & DT_MENSAJE.Rows(0).Item("DOC_ID_REF").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUM_ID_REF").ToString & vbCrLf
                        _mensaje = _mensaje & " PROVEEDOR : " & DT_MENSAJE.Rows(0).Item("VENDOR_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("VENDOR_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " CLIENTE : " & DT_MENSAJE.Rows(0).Item("CUSTOMER_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("CUSTOMER_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " DETALLES : " & vbCrLf
                        For I As Integer = 0 To DT_MENSAJE.Rows.Count() - 1
                            _mensaje = _mensaje & "   - " & DT_MENSAJE.Rows(I).Item("ITEM").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_ID").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_DESCRIPTION").ToString & ";  CANTIDAD : " & DT_MENSAJE.Rows(I).Item("QTY").ToString & " " & DT_MENSAJE.Rows(I).Item("UNIT_PART").ToString & ";  NUM. BULTOS : " & DT_MENSAJE.Rows(I).Item("QT_BULTOS").ToString & ";  PROCEDENCIA : " & DT_MENSAJE.Rows(I).Item("PROCEDENCIA").ToString & ";  PAIS ORIGEN : " & DT_MENSAJE.Rows(I).Item("PAIS_ORIGEN").ToString & vbCrLf
                            _mensaje = _mensaje & "      LOTE: " & DT_MENSAJE.Rows(I).Item("NUMBER_LOT").ToString & ";  FECHA VENC. : " & CDate(DT_MENSAJE.Rows(I).Item("CADUCATE_DATE").ToString).ToString("MMMM-yyyy") & "; NUM. PROTOCOLO: " & DT_MENSAJE.Rows(I).Item("NUM_PROTOCOLOS").ToString & "; NUM. DE ANALISIS: " & DT_MENSAJE.Rows(I).Item("NUMBER_ANALIS").ToString & vbCrLf & vbCrLf
                        Next
                        _mensaje = _mensaje & vbCrLf
                        _mensaje = _mensaje & "Atte." + Chr(13)
                        txtMensaje.Text = _mensaje
                    Else
                        txtMensaje.Text = "No hay datos para mostrar..."
                    End If
                    '--FIN DE CONFIGURACION DEL ASUNTO
                ElseIf _codigo_datos_email = "04" Then
                    DT_MENSAJE = clsBusquedaBl.GET_LIBERACION_PT(_almacen_id, _document_id, _number_document)
                    If DT_MENSAJE.Rows.Count() <> 0 Then
                        _mensaje = "Se registro la siguiente transacción: " & vbCrLf & vbCrLf
                        _mensaje = _mensaje & " TIPO : " & _TITULO & vbCrLf
                        _mensaje = _mensaje & " TRANSACCION : " & DT_MENSAJE.Rows(0).Item("TRANS_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_TRANSACCION").ToString & vbCrLf
                        _mensaje = _mensaje & " ALMACEN : " & DT_MENSAJE.Rows(0).Item("WAREHOUSE_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NAME_ALMACEN").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REGISTRO : " & DT_MENSAJE.Rows(0).Item("DOCUMENT_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUMBER_DOCUMENT").ToString & vbCrLf
                        _mensaje = _mensaje & " FECHA Y HORA : " & DT_MENSAJE.Rows(0).Item("DATE_DOCUMENT").ToString & " - " & DT_MENSAJE.Rows(0).Item("HOUR").ToString & vbCrLf
                        _mensaje = _mensaje & " DOC. Y NUMERO DE REFERENCIA : " & DT_MENSAJE.Rows(0).Item("DOC_ID_REF").ToString & " - " & DT_MENSAJE.Rows(0).Item("NUM_ID_REF").ToString & vbCrLf
                        _mensaje = _mensaje & " PROVEEDOR : " & DT_MENSAJE.Rows(0).Item("VENDOR_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("VENDOR_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " CLIENTE : " & DT_MENSAJE.Rows(0).Item("CUSTOMER_ID").ToString & " - " & DT_MENSAJE.Rows(0).Item("CUSTOMER_NAME").ToString & vbCrLf
                        _mensaje = _mensaje & " DETALLES : " & vbCrLf
                        For I As Integer = 0 To DT_MENSAJE.Rows.Count() - 1
                            _mensaje = _mensaje & "   - " & DT_MENSAJE.Rows(I).Item("ITEM").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_ID").ToString & " " & DT_MENSAJE.Rows(I).Item("PART_DESCRIPTION").ToString & ";  CANTIDAD : " & DT_MENSAJE.Rows(I).Item("QTY").ToString & " " & DT_MENSAJE.Rows(I).Item("UNIT_PART").ToString & ";  NUM. BULTOS : " & DT_MENSAJE.Rows(I).Item("QT_BULTOS").ToString & ";  PROCEDENCIA : " & DT_MENSAJE.Rows(I).Item("PROCEDENCIA").ToString & ";  PAIS ORIGEN : " & DT_MENSAJE.Rows(I).Item("PAIS_ORIGEN").ToString & vbCrLf
                            _mensaje = _mensaje & "      LOTE: " & DT_MENSAJE.Rows(I).Item("NUMBER_LOT").ToString & ";  FECHA VENC. : " & CDate(DT_MENSAJE.Rows(I).Item("CADUCATE_DATE").ToString).ToString("MMMM-yyyy") & "; NUM. PROTOCOLO: " & DT_MENSAJE.Rows(I).Item("NUM_PROTOCOLOS").ToString & "; NUM. DE ANALISIS: " & DT_MENSAJE.Rows(I).Item("NUMBER_ANALIS").ToString & vbCrLf & vbCrLf
                        Next
                        _mensaje = _mensaje & vbCrLf
                        _mensaje = _mensaje & "Atte." + Chr(13)
                        txtMensaje.Text = _mensaje
                    Else
                        txtMensaje.Text = "No hay datos para mostrar..."
                    End If
                    '--FIN DE CONFIGURACION DEL ASUNTO
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            If _codigo_datos_email = "02" Or _codigo_datos_email = "07" Then
                If txtremitente.Text = "" Then
                    MsgBox("Debe ingresar un email remitente.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                _REMITENTE = txtremitente.Text
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, txtPara.Text & ",soporte@lusa.pe", _ASUNTO, txtMensaje.Text)
            Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
            Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
            smpt.EnableSsl = False
            smpt.Credentials = acceso
            smpt.Port = _PUERTO
            smpt.Host = _SERVER
            smpt.Send(mensajes)
            MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")
            Me.Cursor = Cursors.Default
            btn_salir_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class