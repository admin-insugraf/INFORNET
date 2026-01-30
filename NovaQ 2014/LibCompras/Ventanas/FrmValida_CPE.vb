Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class FrmValida_CPE
    Dim tipo_documento As String = ""
    Dim reporteBL As ClsBuscar

    Private Sub FrmValida_CPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnlimpiar_Click(sender, e)
        reporteBL = New ClsBuscar
        Dim dtDatosCompany As DataTable
        dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
        If dtDatosCompany.Rows.Count > 0 Then
            txt_ruc.Text = dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString
            txt_user.Text = dtDatosCompany.Rows(0).Item("USUARIO_CPE").ToString
            txt_pass.Text = dtDatosCompany.Rows(0).Item("PASS_CPE").ToString
        Else
            txt_ruc.Text = ""
            txt_user.Text = ""
            txt_pass.Text = ""
        End If
    End Sub

    Private Sub cmb_ConsultaStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ConsultaStatus.SelectedIndexChanged
        'Factura()
        'Boleta()
        'Nota Crédito
        'Nota Débito
        'Retención()
        'Percepcion()
        If cmb_ConsultaStatus.SelectedIndex = 0 Then
            tipo_documento = "01"
        ElseIf cmb_ConsultaStatus.SelectedIndex = 1 Then
            tipo_documento = "03"
        ElseIf cmb_ConsultaStatus.SelectedIndex = 2 Then
            tipo_documento = "07"
        ElseIf cmb_ConsultaStatus.SelectedIndex = 3 Then
            tipo_documento = "08"
        ElseIf cmb_ConsultaStatus.SelectedIndex = 4 Then
            tipo_documento = ""
        ElseIf cmb_ConsultaStatus.SelectedIndex = 5 Then
            tipo_documento = ""
        End If
    End Sub

    Private Sub txt_ruc_emisor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc_emisor.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_ConsultaStatus.Focus()
        End If
    End Sub

    Private Sub cmb_ConsultaStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ConsultaStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_serie.Focus()
        End If
    End Sub

    Private Sub txt_serie_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_serie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_numero.Focus()
        End If
    End Sub

    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_emision.Focus()
        End If
    End Sub

    Private Sub txt_fecha_emision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_emision.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total.Focus()
        End If
    End Sub

    Private Sub txt_total_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_EstatusDocumento_Click(sender, e)
        End If
    End Sub

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave
        If txt_numero.Text.Trim().Length > 0 Then
            txt_numero.Text = txt_numero.Text.PadLeft(8, Char.Parse("0"))
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        cmb_ConsultaStatus.SelectedIndex = -1
        txt_ruc_emisor.Text = ""
        txt_serie.Text = ""
        txt_numero.Text = ""
        txt_fecha_emision.Text = ""
        txt_total.Text = ""
        txt_ruc_emisor.Select()
    End Sub
    Private Sub btn_EstatusDocumento_Click(sender As Object, e As EventArgs) Handles btn_EstatusDocumento.Click
        If txt_ruc_emisor.Text.Length <> 11 Then
            MessageBox.Show("Ruc invalido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_ruc_emisor.Select()
            Exit Sub
        End If

        If IsDate(txt_fecha_emision.Text) = False Then
            MessageBox.Show("Fecha invalida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_fecha_emision.Select()
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api-seguridad.sunat.gob.pe/v1/clientesextranet/" & txt_user.Text.Trim & "/oauth2/token/"
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"
            request.Method = "POST"

            Dim _scope As String = "https://api.sunat.gob.pe/v1/contribuyente/contribuyentes"
            Dim postData As String = "grant_type=client_credentials&scope=" & _scope & "&client_id=" & txt_user.Text.Trim & "&client_secret=" & txt_pass.Text.Trim & ""

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream
            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            Dim access_token_ As String = JObject.Parse(data)("access_token")

            url = "https://api.sunat.gob.pe/v1/contribuyente/contribuyentes/" & txt_ruc.Text.Trim & "/validarcomprobante"
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request2 As HttpWebRequest = HttpWebRequest.Create(url)
            request2.Proxy = Nothing
            request2.UserAgent = "Test"
            request2.Method = "POST"
            request2.Headers.Add("Authorization", "Bearer " & access_token_)

            Dim postData2 As String
            postData2 = "{""numRuc"":""" & txt_ruc_emisor.Text.Trim & """,""codComp"":""" & tipo_documento & """,""numeroSerie"":""" & txt_serie.Text.Trim & """,""numero"":""" & txt_numero.Text.Trim & """,""fechaEmision"":""" & txt_fecha_emision.Text.Trim & """,""monto"":""" & txt_total.Text.Trim & """}"
            Dim byteArray2 As Byte() = Encoding.UTF8.GetBytes(postData2)
            request2.ContentType = "application/json"
            request2.ContentLength = byteArray2.Length
            Dim dataStream2 As Stream = request2.GetRequestStream()
            dataStream2.Write(byteArray2, 0, byteArray2.Length)
            dataStream2.Close()

            Dim response2 As HttpWebResponse = request2.GetResponse
            Dim responseStream2 As System.IO.Stream = response2.GetResponseStream
            Dim streamReader2 As New System.IO.StreamReader(responseStream2)
            Dim data2 As String = streamReader2.ReadToEnd
            streamReader2.Close()

            Dim _success As String = JObject.Parse(data2)("success")
            Dim _message As String = JObject.Parse(data2)("message")
            Dim _estadoCp As String = JObject.Parse(data2)("data")("estadoCp")
            Dim _estadoRuc As String = JObject.Parse(data2)("data")("estadoRuc")
            Dim _condDomiRuc As String = JObject.Parse(data2)("data")("condDomiRuc")
            Dim _texto_estadoCp As String = ""
            Dim _texto_estadoRuc As String = ""
            Dim _texto_condDomiRuc As String = ""

            If _estadoCp = "0" Then _texto_estadoCp = "NO EXISTE (Comprobante no informado)"
            If _estadoCp = "1" Then _texto_estadoCp = "ACEPTADO (Comprobante aceptado)"
            If _estadoCp = "2" Then _texto_estadoCp = "ANULADO (Comunicado en una baja)"
            If _estadoCp = "3" Then _texto_estadoCp = "AUTORIZADO (con autorización de imprenta)"
            If _estadoCp = "4" Then _texto_estadoCp = "NO AUTORIZADO (no autorizado por imprenta)"

            If _estadoRuc = "00" Then _texto_estadoRuc = "ACTIVO"
            If _estadoRuc = "01" Then _texto_estadoRuc = "BAJA PROVISIONAL"
            If _estadoRuc = "02" Then _texto_estadoRuc = "BAJA PROV. POR OFICIO"
            If _estadoRuc = "03" Then _texto_estadoRuc = "SUSPENSION TEMPORAL"
            If _estadoRuc = "10" Then _texto_estadoRuc = "BAJA DEFINITIVA"
            If _estadoRuc = "11" Then _texto_estadoRuc = "BAJA DE OFICIO"
            If _estadoRuc = "22" Then _texto_estadoRuc = "INHABILITADO-VENT.UNICA"

            If _condDomiRuc = "00" Then _texto_condDomiRuc = "HABIDO"
            If _condDomiRuc = "09" Then _texto_condDomiRuc = "PENDIENTE"
            If _condDomiRuc = "11" Then _texto_condDomiRuc = "POR VERIFICAR"
            If _condDomiRuc = "12" Then _texto_condDomiRuc = "NO HABIDO"
            If _condDomiRuc = "20" Then _texto_condDomiRuc = "NO HALLADO"

            Dim _mensaje As String = ""
            _mensaje = "success: " & _success.ToString & Chr(13)
            _mensaje = _mensaje & "message: " & _message & Chr(13)
            _mensaje = _mensaje & "estadoCp: " & _estadoCp & " - " & _texto_estadoCp & Chr(13)
            _mensaje = _mensaje & "estadoRuc: " & _estadoRuc & " - " & _texto_estadoRuc & Chr(13)
            _mensaje = _mensaje & "condDomiRuc: " & _condDomiRuc & " - " & _texto_condDomiRuc & Chr(13)

            MsgBox(_mensaje, MsgBoxStyle.Information)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmValida_CPE_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_ValidaAcceso_Click(sender As Object, e As EventArgs) Handles btn_ValidaAcceso.Click

    End Sub
End Class