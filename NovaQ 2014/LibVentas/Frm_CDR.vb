Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Frm_CDR
    Public _tipo_documento As String = ""
    Public _serie_documento As String = ""
    Public _numero_documento As String = ""
    Public _tipo_doc_electronico As String = ""
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Private dtDocumentoFactura As DataTable
    Private mySetting As NameValueCollection



    Private Sub btn_verifica_estado_manual_Click(sender As Object, e As EventArgs) Handles btn_verifica_estado_manual.Click
        Me.Close()
    End Sub

    Private Sub Frm_CDR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datos_Documento()
    End Sub

    Private Sub Datos_Documento()
        Try
            Me.Cursor = Cursors.WaitCursor
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDocumentoFactura = New DataTable
            If _tipo_doc_electronico = "CR" Then
                dtDocumentoFactura = clsFacturaBl.get_Datos_CDR(_tipo_documento, _serie_documento, _numero_documento, _tipo_doc_electronico)
            Else
                dtDocumentoFactura = clsFacturaBl.get_Datos_CDR(_tipo_documento, _serie_documento, Strings.Right(_numero_documento, 7), _tipo_doc_electronico)
            End If

            If dtDocumentoFactura.Rows.Count() <> 0 Then
                txt_id_Recepcion.Text = dtDocumentoFactura.Rows(0).Item("CDR").ToString
                txt_Fecha_recepcion.Text = dtDocumentoFactura.Rows(0).Item("FECHA_RECEPCION").ToString
                txt_hora_recepcion.Text = dtDocumentoFactura.Rows(0).Item("HORA_RECEPCION").ToString
                txt_fecha_generacion.Text = dtDocumentoFactura.Rows(0).Item("FECHA_GENERACION").ToString
                txt_hora_generacion.Text = dtDocumentoFactura.Rows(0).Item("HORA_GENERACION").ToString
                txt_ruc_emisor.Text = dtDocumentoFactura.Rows(0).Item("RUC_EMISOR").ToString
                txt_ruc_receptor.Text = Datos_Ruc_Electronico()
                txt_documento_electronico.Text = "" 'dtDocumentoFactura.Rows(0).Item("CDR").ToString
                txt_respuesta_sunat.Text = dtDocumentoFactura.Rows(0).Item("RESPUESTA_SUNAT").ToString
                txt_tipo_doc.Text = dtDocumentoFactura.Rows(0).Item("TIPO").ToString
                txt_Serie_doc.Text = dtDocumentoFactura.Rows(0).Item("SERIE").ToString
                txt_num_doc.Text = dtDocumentoFactura.Rows(0).Item("NUMERO").ToString
                txt_id_Receptor.Text = dtDocumentoFactura.Rows(0).Item("ID_RECEPTOR").ToString
            Else
                txt_id_Recepcion.Text = ""
                txt_Fecha_recepcion.Text = ""
                txt_hora_recepcion.Text = ""
                txt_fecha_generacion.Text = ""
                txt_hora_generacion.Text = ""
                txt_ruc_emisor.Text = ""
                txt_ruc_receptor.Text = ""
                txt_documento_electronico.Text = ""
                txt_respuesta_sunat.Text = ""
                txt_tipo_doc.Text = ""
                txt_Serie_doc.Text = ""
                txt_num_doc.Text = ""
                txt_id_Receptor.Text = ""
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Datos_Ruc_Electronico() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuc = mySetting("Ruc")
        Return STRRuc
    End Function
End Class