Imports LibComunVar
Imports System.Windows.Forms
Imports LibCobranzas
Imports System.Drawing
Imports System.Drawing.Printing
Imports LibSeguridad.ClsUsuario
Imports System.Collections.Specialized
Imports System.IO
'Imports Microsoft.Office.Interop
Imports LibBillService.Process
Public Class FrmFacturacion_Detalle_Pedido
    Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
    Dim dtCabeceraFact As DataTable
    Dim clsPedidoBl As ClsOperaciones.ORDERS
    Public _numero_pedido As String

    Private Sub FrmFacturacion_Detalle_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarModoConsultar(_numero_pedido)
    End Sub

    Private Sub MostrarModoConsultar(ByVal numero_pedido As String)
        Try
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            dtCabeceraFact = New DataTable
            '---Mostrando Datos de Cabecera
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtCabeceraFact = clsPedidoBl.Modo_Edicion_Cabecera(numero_pedido)

            If dtCabeceraFact.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraFact.Rows.Count() - 1
                    txtModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO").ToString
                    lblModoPago.Text = dtCabeceraFact.Rows(i).Item("MODO_PAGO_DESC").ToString

                    txt_provincia.Text = dtCabeceraFact.Rows(i).Item("PROVINCIA").ToString
                    txt_cod_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE").ToString
                    txt_des_agencia_trans.Text = dtCabeceraFact.Rows(i).Item("AGENCIA_TRANSPORTE_DES").ToString
                    txt_guia.Text = dtCabeceraFact.Rows(i).Item("GUIA").ToString
                    If dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "AGENCIA" Then
                        rdb_agencia.Checked = True
                        rdb_domicilio.Checked = False
                    ElseIf dtCabeceraFact.Rows(i).Item("AGE_DOMI").ToString = "DOMICILIO" Then
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = True
                    Else
                        rdb_agencia.Checked = False
                        rdb_domicilio.Checked = False
                    End If

                    If dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Agencia" Then
                        rdb_opt_agencia.Checked = True
                        rdb_opt_domicilio.Checked = False
                    ElseIf dtCabeceraFact.Rows(i).Item("OPT_A_D").ToString = "Domicilio" Then
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = True
                    Else
                        rdb_opt_agencia.Checked = False
                        rdb_opt_domicilio.Checked = False
                    End If

                    txt_lt_ft.Text = dtCabeceraFact.Rows(i).Item("LT_FT").ToString
                    If dtCabeceraFact.Rows(i).Item("CHEQUE").ToString = "SI" Then
                        chk_cheque.Checked = True
                    Else
                        chk_cheque.Checked = False
                    End If

                    If dtCabeceraFact.Rows(i).Item("GUIA_2").ToString = "" Then
                        chk_guia_2.Checked = False
                    Else
                        chk_guia_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("FACTURA_2").ToString = "" Then
                        chk_factura_2.Checked = False
                    Else
                        chk_factura_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("LETRA_2").ToString = "" Then
                        chk_letra_2.Checked = False
                    Else
                        chk_letra_2.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_2").ToString = "" Then
                        chk_transferencia.Checked = False
                    Else
                        chk_transferencia.Checked = True
                    End If
                    If dtCabeceraFact.Rows(i).Item("EFECTIVO_2").ToString = "" Then
                        chk_efectivo.Checked = False
                    Else
                        chk_efectivo.Checked = True
                    End If

                    txt_cod_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA").ToString
                    txt_des_transferencia.Text = dtCabeceraFact.Rows(i).Item("TRANSFERENCIA_DES").ToString
                    txt_n_operacion.Text = dtCabeceraFact.Rows(i).Item("N_OPERACION").ToString
                    txt_obs_general.Text = dtCabeceraFact.Rows(i).Item("OBS_GENERAL").ToString
                    txt_recepcion_tercero.Text = dtCabeceraFact.Rows(i).Item("RECEPCION_TERCERO").ToString
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class