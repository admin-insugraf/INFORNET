Imports System.Windows.Forms
Imports System.Net.Mail
Imports LibCobranzas
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System.Threading
Imports System.Text
Imports System.Net.Mime

Public Class FrmEnvioEmail
    Public _almacen_id As String
    Public _serie_doc As String
    Public _document_id As String
    Public _number_document As String
    Public _serie_document As String
    Public _codigo_datos_email As String
    Public _ruc_electronico As String
    Public _nombre_documento As String
    Public _archivo_pdf As String
    Public _archivo_xml As String
    Public _archivo_cdr As String
    Public _USER_MAIL As String = String.Empty
    Public _TIPO_ESTADO As String = String.Empty
    Public _EMAIL_RECEPCIONANTE As String = String.Empty
    Public _nombre_tipo_documento As String = String.Empty
    Public _monto_documento As Double = 0
    Public _fecha_documento As String = String.Empty
    Public _tipo_moneda As String = String.Empty

    Private clsFacturaBl As ClsNegocio.RECEIVABLE

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
                txtPara.Text = _EMAIL_RECEPCIONANTE
                txtAsunto.Text = LibComunVar.ClsVarComun.NomEmpresa_completo & " - " & _nombre_tipo_documento & " - " & _serie_document & "-" & _number_document
                '--CONFIGURACION DEL ASUNTO
                If _codigo_datos_email = "99" Then
                    txtremitente.Visible = True
                    lbldelinea.Visible = True
                    lblde.Visible = True
                    txtremitente.Text = _REMITENTE

                    '_mensaje = "El nombre de los documentos es:" & vbCrLf & "" & _ruc_electronico & "-" & _nombre_documento & vbCrLf & "Los documentos van adjuntos." 'estilo & cuerpo
                    '_mensaje = _mensaje & vbCrLf
                    '_mensaje = _mensaje & "Atte." + Chr(13)
                    'txtMensaje.Text = _mensaje

                    lbl_nombre_pdf.Text = _nombre_documento & ".PDF"
                    lbl_nombre_xml.Text = _nombre_documento & ".XML"


                    _mensaje = ""
                    _mensaje = _mensaje & " <span style=""color:#0032a0;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: left;"">Hola,<br></span> "
                    _mensaje = _mensaje & " <span style=""color:#04be50;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: center;"">Te enviamos tu comprobante electrónico.</span><br><br></span> "
                    _mensaje = _mensaje & " <table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""border:1px solid #36c1dc;padding-left:15px;padding-right:15px;background-repeat:no-repeat;background-position:50% 50%"" data-image-whitelisted="" align=""center"">"
                    _mensaje = _mensaje & " <tbody><tr><td width=""100%"" height=""250"" align=""center"" valign=""top"" style=""text-align:center"" rowspan=""1"" colspan=""1"">"
                    _mensaje = _mensaje & " <table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""border-spacing:0;text-align:center""><tbody><tr><td colspan=""2"" style=""height:20px"" rowspan=""1"">&nbsp;</td></tr><tr style=""vertical-align:top""><td colspan=""2"" align=""center"" valign=""top"" style=""color:#00add0;font-size:18px;width:141px;word-wrap:break-word;overflow:auto"" rowspan=""1"">"
                    _mensaje = _mensaje & " <span>Constancia de Envío</span> </td></tr><tr><td colspan=""2"" style=""height:20px"" rowspan=""1"">&nbsp;</td></tr> <tr style=""vertical-align:top"">"
                    _mensaje = _mensaje & " <td colspan=""2"" align=""center"" valign=""top"" style=""text-align:center;font-size:13px"" rowspan=""1"">Fecha:&nbsp;<span>" & Date.Now.Day.ToString & " " & Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(DateTime.Now.ToString("MM") - 1) & " " & Date.Now.Year.ToString & "</span>&nbsp;&nbsp;Hora:&nbsp;<span>" & Date.Now.ToString("HH:mm:ss") & "</span></td>"
                    _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr></tbody>"
                    _mensaje = _mensaje & " </table><table width=""100%"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""color:#4e4f53;font-size:14px;text-align:center""><tbody>"

                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Tipo :</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _nombre_tipo_documento & "</span><br clear=""none""></span> </td>"
                    _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"

                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Número :</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _serie_document & "-" & _number_document & "</span><br clear=""none""></span> </td>"
                    _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"

                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Monto :</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _tipo_moneda & " " & Format(_monto_documento, "##,##0.00") & "</span><br clear=""none""></span> </td>"
                    _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"

                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Fecha de emisión :</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _fecha_documento & "</span><br clear=""none""></span> </td>"
                    _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"

                    _mensaje = _mensaje & " <tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr></tbody></table></td></tr><tr><td style=""height:10px"" rowspan=""1"" colspan=""1"">&nbsp;</td></tr></tbody></table>"
                    _mensaje = _mensaje & " </td></tr><tr><td style=""padding:30px;text-align:center;font-size:12px;color:#cccccc;""><p style=""margin:0 0 8px 0;""><a href=""#"" style=""text-decoration:none;"">"
                    _mensaje = _mensaje & " <img src=""cid:imagen2"" width=""40"" height=""40"" alt=""f"" style=""display:inline-block;color:#cccccc;""></a><a href=""#"" style=""text-decoration:none;"">"
                    _mensaje = _mensaje & " <img src=""cid:imagen3"" width=""40"" height=""40"" alt=""t"" style=""display:inline-block;color:#cccccc;""></a></p><p style=""margin:0;font-size:14px;line-height:20px;"">&reg; " & LibComunVar.ClsVarComun.NomEmpresa_completo & " " & Date.Now.Year & "<br>"
                    _mensaje = _mensaje & " </p></td></tr></table></td></tr></table></div></body></html>"

                    txtMensaje.Text = Cabecera_correo() & _mensaje
                    WebBrowser1.DocumentText = Cabecera_correo_2() & _mensaje
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Cabecera_correo() As String
        Dim mensaje_cabecera As String
        mensaje_cabecera = "<!DOCTYPE html><html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office""><head>  <meta charset=""utf-8"">  <meta name=""viewport"" content=""width=device-width,initial-scale=1"">  <meta name=""x-apple-disable-message-reformatting"">  <title></title>"
        mensaje_cabecera = mensaje_cabecera & " <style>    table, td, div, h1, p {      font-family: Arial, sans-serif;    }    @media screen and (max-width: 530px) {      .unsub {        display: block;        padding: 8px;        margin-top: 14px;        border-radius: 6px;        background-color: #555555;        text-decoration: none !important;        "
        mensaje_cabecera = mensaje_cabecera & " font-weight: bold;      }      .col-lge {        max-width: 100% !important;      }    }    @media screen and (min-width: 531px) {.col-sml {        max-width: 27% !important;      }      .col-lge {        max-width: 73% !important;      }    }  </style> "
        mensaje_cabecera = mensaje_cabecera & " <body style=""margin:0;padding:0;word-spacing:normal;""> <div role=""article"" aria-roledescription=""email"" lang=""en"" style=""text-size-adjust:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;"">     <table role=""presentation"" style=""width:100%;border:none;border-spacing:0;""> "
        mensaje_cabecera = mensaje_cabecera & "       <tr>         <td align=""center"" style=""padding:0;"">           <table role=""presentation"" style=""width:94%;max-width:600px;border:none;border-spacing:0;text-align:left;font-family:Arial,sans-serif;font-size:16px;line-height:22px;color:#363636;"" > "
        mensaje_cabecera = mensaje_cabecera & "       <tr>              <td style=""padding:40px 30px 30px 30px;text-align:center;font-size:24px;font-weight:bold;"">"
        mensaje_cabecera = mensaje_cabecera & " 	  </td>            </tr>            <tr>"
        mensaje_cabecera = mensaje_cabecera & " <td style=""padding:30px;background-color:#ffffff;"" >"

        Return mensaje_cabecera
    End Function

    Private Function Cabecera_correo_2() As String
        Dim mensaje_cabecera As String
        mensaje_cabecera = "<!DOCTYPE html><html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office""><head>  <meta charset=""utf-8"">  <meta name=""viewport"" content=""width=device-width,initial-scale=1"">  <meta name=""x-apple-disable-message-reformatting"">  <title></title>"
        mensaje_cabecera = mensaje_cabecera & " <style>    table, td, div, h1, p {      font-family: Arial, sans-serif;    }    @media screen and (max-width: 530px) {      .unsub {        display: block;        padding: 8px;        margin-top: 14px;        border-radius: 6px;        background-color: #555555;        text-decoration: none !important;        "
        mensaje_cabecera = mensaje_cabecera & " font-weight: bold;      }      .col-lge {        max-width: 100% !important;      }    }    @media screen and (min-width: 531px) {.col-sml {        max-width: 27% !important;      }      .col-lge {        max-width: 73% !important;      }    }  </style> "
        mensaje_cabecera = mensaje_cabecera & " <body style=""margin:0;padding:0;word-spacing:normal;""> <div role=""article"" aria-roledescription=""email"" lang=""en"" style=""text-size-adjust:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;"">     <table role=""presentation"" style=""width:100%;border:none;border-spacing:0;""> "
        mensaje_cabecera = mensaje_cabecera & "       <tr>         <td align=""center"" style=""padding:0;"">           <table role=""presentation"" style=""width:94%;max-width:600px;border:none;border-spacing:0;text-align:left;font-family:Arial,sans-serif;font-size:16px;line-height:22px;color:#363636;"" > "
        mensaje_cabecera = mensaje_cabecera & "       <tr>              <td style=""padding:40px 30px 30px 30px;text-align:center;font-size:24px;font-weight:bold;"">"
        mensaje_cabecera = mensaje_cabecera & " 	  </td>            </tr>            <tr>"
        mensaje_cabecera = mensaje_cabecera & " <td style=""padding:30px;background-color:#ffffff;"" >"

        Return mensaje_cabecera
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            If txtremitente.Text = "" Then
                MsgBox("Debe ingresar un email remitente.", MsgBoxStyle.Critical)
                txtremitente.Focus()
                Exit Sub
            End If
            If txtPara.Text = "" Then
                MsgBox("Debe ingresar un email de destino.", MsgBoxStyle.Critical)
                txtPara.Focus()
                Exit Sub
            End If

            If txtAsunto.Text = "" Then
                MsgBox("Debe ingresar un asunto del mail.", MsgBoxStyle.Critical)
                txtAsunto.Focus()
                Exit Sub
            End If
            _REMITENTE = txtremitente.Text

            Me.Cursor = Cursors.WaitCursor
            'Dim att_pdf As New Net.Mail.Attachment(_archivo_pdf)
            'Dim att_xml As New Net.Mail.Attachment(_archivo_xml)
            'Dim att_cdr As New Net.Mail.Attachment(_archivo_cdr)
            'Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, txtPara.Text, txtAsunto.Text, txtMensaje.Text)
            'mensajes.Attachments.Add(att_pdf)
            'mensajes.Attachments.Add(att_xml)
            'mensajes.Attachments.Add(att_cdr)
            'Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
            'Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
            'smpt.EnableSsl = True
            'smpt.Credentials = acceso
            'smpt.Port = _PUERTO
            'smpt.Host = _SERVER

            'ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

            'smpt.Send(mensajes)

            '***********************
            Dim _texto_email As String = Cabecera_correo() & _mensaje

            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(_texto_email, Encoding.UTF8, MediaTypeNames.Text.Html)
            'Dim img As LinkedResource = New LinkedResource("logoinsugraf.jpg", MediaTypeNames.Image.Jpeg)
            'img.ContentId = "imagen1"
            'htmlView.LinkedResources.Add(img)

            Dim img2 As LinkedResource = New LinkedResource("facebook_1.png", MediaTypeNames.Image.Jpeg)
            img2.ContentId = "imagen2"
            htmlView.LinkedResources.Add(img2)

            Dim img3 As LinkedResource = New LinkedResource("instagram.png", MediaTypeNames.Image.Jpeg)
            img3.ContentId = "imagen3"
            htmlView.LinkedResources.Add(img3)

            Dim att_pdf As New Net.Mail.Attachment(_archivo_pdf)
            Dim att_xml As New Net.Mail.Attachment(_archivo_xml)
            'Dim att_cdr As New Net.Mail.Attachment(_archivo_cdr)
            'Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, txtPara.Text, txtAsunto.Text, txtMensaje.Text)
            Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, txtPara.Text, txtAsunto.Text, _texto_email)
            mensajes.Attachments.Add(att_pdf)
            mensajes.Attachments.Add(att_xml)
            'mensajes.Attachments.Add(att_cdr)
            mensajes.AlternateViews.Add(htmlView)
            Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
            Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
            smpt.EnableSsl = True
            smpt.Credentials = acceso
            smpt.Port = _PUERTO
            smpt.Host = _SERVER

            smpt.Send(mensajes)
            '***********************

            clsFacturaBl = New ClsNegocio.RECEIVABLE
            If clsFacturaBl.Act_Envio_Mail(_document_id, _serie_document, _number_document) Then
                Me.Cursor = Cursors.Default
                MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")
                btn_salir_Click(sender, e)
            Else
                Me.Cursor = Cursors.Default
                MsgBox("Error al enviar el Mail. Verifique!!!", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class