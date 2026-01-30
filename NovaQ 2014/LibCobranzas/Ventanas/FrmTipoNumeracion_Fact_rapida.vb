Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmTipoNumeracion_Fact_rapida
    Public NumeracionGuiaRemision As String
    Public NumeracionFactura As String
    Public NumeracionFacturaNotaC As String
    Public NumeracionFacturaNotaD As String
    Public NumeracionFacturaCP As String
    Public NumeracionGeneral As String
    Public Vuelto As Double = 0.0
    Public monto_soles As Double = 0.0
    Public monto_dolares As Double = 0.0
    Public monto_visa As Double = 0.0
    Public monto_mastercard As Double = 0.0
    Public monto_scotiabank As Double = 0.0
    Public monto_interbank As Double = 0.0
    Public monto_american_expres As Double = 0.0
    Public monto_diners_club As Double = 0.0
    Public modo_pago As String = ""
    Public forma_pago As String = ""
    Public num_operacion_visa As String = String.Empty
    Public num_operacion_mastercard As String = String.Empty
    Public num_operacion_american As String = String.Empty
    Public num_operacion_diners As String = String.Empty
    Public num_operacion_scotiabank As String = String.Empty
    Public num_operacion_interbank As String = String.Empty

    Public fl_datos As Boolean = False
    Public Almacen As String = String.Empty
    Public Serie As String = String.Empty
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtdetalles As DataTable
    Public TipoNumeracion As String = String.Empty
    Public TipoDocumento As String = String.Empty
    Public TipoCanelacion As String = String.Empty
    Public Modo_edicion As Boolean = False
    Public Numero_edicion As String = ""
    Public monto_ventas As Double
    Dim _nuevo As Boolean = False

    Private Sub FrmTipoNumeracion_Fact_rapida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TipoDocumento = "PF" Then
            GroupBox5.Visible = True
        Else
            If LibComunVar.ClsVarComun.MODIFICA_NUMERACION_FACT = "SI" Then
                GroupBox5.Visible = True
            Else
                GroupBox5.Visible = False
            End If
        End If

        rbAutomatica.Checked = True
        GeneracionCodigoAutomatico()
        TipoPago()
        rdb_contado.Checked = True
        'btnAceptarNumeracion.Select()
        _nuevo = True
        TxEfeSol.Select()
    End Sub

    Private Sub TipoPago()
        lblmonto_venta.Text = "0"
        lblpagado.Text = ""
        lblfalta_pagar.Text = ""
        lblvuelto.Text = "0"
        lbltipo_cambio.Text = 0
        TxEfeSol.Text = 0
        TxEfeDol.Text = 0
        txt_bcp.Text = 0
        txt_bbva.Text = 0
        TXTTOTALE.Text = 0
        TXTTOTALT.Text = 0

        txt_num_operacion_bcp.Text = ""
        txt_num_operacion_bbva.Text = ""
        txt_num_operacion_plin.Text = ""
        txt_num_operacion_yape.Text = ""

        lbltipo_cambio.Text = Format(LibComunVar.ClsVarComun.TCVenta, "#,###,###.#0")
        lblmonto_venta.Text = Format(monto_ventas, "#,###,###.#0")

    End Sub

    Private Sub rdb_contado_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_contado.CheckedChanged
        If rdb_contado.Checked Then
            gb_pago_efectivo.Enabled = True
            gb_pago_tarjeta.Enabled = True
            gb_resumen_pago.Enabled = True
            gb_tipo_cambio.Enabled = True
            gb_modo_pago.Enabled = True
            txt_cod_modo_pago.Text = "00"
            txt_des_modo_pago.Text = "EFECTIVO"
            TipoPago()
        End If
    End Sub

    Private Sub rdb_credito_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_credito.CheckedChanged
        If rdb_credito.Checked Then
            gb_pago_efectivo.Enabled = False
            gb_pago_tarjeta.Enabled = False
            gb_resumen_pago.Enabled = False
            gb_tipo_cambio.Enabled = False
            gb_modo_pago.Enabled = False
            txt_cod_modo_pago.Text = ""
            txt_des_modo_pago.Text = ""
            TipoPago()
        End If
    End Sub

    Private Sub TxEfeSol_TextChanged(sender As Object, e As EventArgs) Handles TxEfeSol.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If

    End Sub

    Private Sub TxEfeDol_TextChanged(sender As Object, e As EventArgs) Handles TxEfeDol.TextChanged
        If TxEfeDol.Text = "" Then Exit Sub
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_TextChanged(sender As Object, e As EventArgs) Handles txt_bcp.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_TextChanged(sender As Object, e As EventArgs) Handles txt_bbva.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_DINERS_TextChanged(sender As Object, e As EventArgs) Handles txt_yape.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_TextChanged(sender As Object, e As EventArgs) Handles txt_plin.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub

    Private Sub TxEfeSol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxEfeSol.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxEfeDol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxEfeDol.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bcp.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bbva.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_yape.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plin.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxEfeSol_KeyDown(sender As Object, e As KeyEventArgs) Handles TxEfeSol.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bcp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bbva.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_yape.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_plin.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub txt_cod_modo_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_modo_pago.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Modo_Pago(txt_cod_modo_pago, txt_des_modo_pago)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_modo_pago.Text = "" Then
                Ayuda_Modo_Pago(txt_cod_modo_pago, txt_des_modo_pago)
            Else
                btnAceptarNumeracion.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Modo_Pago(cajaTexto As TextBox, cajaDescTexto As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_MODO_COBRO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Modo de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0)
                cajaDescTexto.Text = frm.Data_Matriz.Rows(0).Item(1)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_modo_pago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_modo_pago.MouseDoubleClick
        Ayuda_Modo_Pago(txt_cod_modo_pago, txt_des_modo_pago)
    End Sub


    Private Function GeneracionCodigoAutomatico() As Boolean
        Dim estado As Boolean = True
        Try
            If rbManual.Checked Then
                If txtNumeracionManual.Text = String.Empty Then
                    MsgBox("Debe ingresar una numeración", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                Else
                    txtNumeracionManual.Text = String.Format("{0:0000000}", CInt(txtNumeracionManual.Text.Trim))
                    clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
                    dtdetalles = New DataTable("Documentos")
                    dtdetalles = clsGuiaRemisionBl.get_VerificacionCodigoGuiaRemision(TipoDocumento, Almacen, Serie + txtNumeracionManual.Text)
                    If dtdetalles.Rows.Count() <> 0 Then
                        MsgBox("El correlativo ingresado ya existe.", MsgBoxStyle.Critical)
                        fl_datos = False
                        estado = False
                        Exit Try
                    Else
                        NumeracionGeneral = String.Empty
                        TipoNumeracion = String.Empty
                        NumeracionGeneral = Serie + txtNumeracionManual.Text
                        TipoNumeracion = "M"

                        monto_soles = 0
                        monto_dolares = 0
                        monto_visa = 0
                        monto_mastercard = 0
                        monto_american_expres = 0
                        monto_diners_club = 0
                        Vuelto = 0
                        modo_pago = ""
                        forma_pago = ""

                        If TxEfeSol.Text = "" Then
                            TxEfeSol.Text = "0"
                        End If
                        If TxEfeDol.Text = "" Then
                            TxEfeDol.Text = "0"
                        End If
                        If txt_bcp.Text = "" Then
                            txt_bcp.Text = "0"
                        End If
                        If txt_bbva.Text = "" Then
                            txt_bbva.Text = "0"
                        End If
                        If txt_yape.Text = "" Then
                            txt_yape.Text = "0"
                        End If
                        If txt_plin.Text = "" Then
                            txt_plin.Text = "0"
                        End If


                        If rdb_credito.Checked Then
                            TipoCanelacion = "Credito"

                        ElseIf rdb_contado.Checked Then
                            If CDbl(TxEfeSol.Text) = 0 And CDbl(txt_bcp.Text) = 0 And CDbl(txt_bbva.Text) = 0 And CDbl(txt_yape.Text) = 0 And CDbl(txt_plin.Text) = 0 Then
                                MsgBox("Debe ingresar una forma de cancelación.", MsgBoxStyle.Exclamation, "Aviso")
                                TxEfeSol.Select()
                                fl_datos = False
                                estado = False
                                Exit Try
                            End If

                            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                                MsgBox("El monto cancelado es menor al monto de la venta. Verifique!!!", MsgBoxStyle.Exclamation)
                                estado = False
                                Exit Try
                            End If

                            If TxEfeSol.Text = "" Then
                                TxEfeSol.Text = "0"
                            End If
                            If TxEfeDol.Text = "" Then
                                TxEfeDol.Text = "0"
                            End If
                            If txt_bcp.Text = "" Then
                                txt_bcp.Text = "0"
                            End If
                            If txt_bbva.Text = "" Then
                                txt_bbva.Text = "0"
                            End If
                            If txt_yape.Text = "" Then
                                txt_yape.Text = "0"
                            End If
                            If txt_plin.Text = "" Then
                                txt_plin.Text = "0"
                            End If

                            If CDbl(TxEfeSol.Text) > 0 Or CDbl(TxEfeDol.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "Efectivo/"
                            End If

                            If CDbl(TxEfeSol.Text) > 0 Then
                                monto_soles = CDbl(TxEfeSol.Text)
                            End If

                            If CDbl(TxEfeDol.Text) > 0 Then
                                monto_dolares = CDbl(TxEfeDol.Text)
                            End If

                            If CDbl(txt_bcp.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "BCP/"
                                monto_visa = CDbl(txt_bcp.Text)
                                num_operacion_visa = txt_num_operacion_bcp.Text
                            End If
                            If CDbl(txt_bbva.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "BBVA/"
                                monto_mastercard = CDbl(txt_bbva.Text)
                                num_operacion_mastercard = txt_num_operacion_bbva.Text
                            End If
                            If CDbl(txt_yape.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "YAPE/"
                                monto_diners_club = CDbl(txt_yape.Text)
                                num_operacion_diners = txt_num_operacion_yape.Text
                            End If
                            If CDbl(txt_plin.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "PLIN/"
                                monto_american_expres = CDbl(txt_plin.Text)
                                num_operacion_american = txt_num_operacion_plin.Text
                            End If

                            If Strings.Len(TipoCanelacion) <> 0 Then
                                TipoCanelacion = Mid(TipoCanelacion, 1, Len(TipoCanelacion) - 1)
                            End If


                        End If

                        If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                            lblvuelto.Text = Format(0, "###,###.00")
                        Else
                            lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
                        End If

                        If lblvuelto.Text = "" Then
                            Vuelto = 0.0
                        Else
                            Vuelto = CDbl(lblvuelto.Text)
                        End If

                        If monto_soles > 0 Then
                            monto_soles = Math.Abs(CDbl(lblmonto_venta.Text) - (monto_visa + monto_mastercard + monto_diners_club + monto_american_expres))
                        End If
                        modo_pago = txt_cod_modo_pago.Text
                        If rdb_contado.Checked Then
                            forma_pago = "00"
                        ElseIf rdb_credito.Checked Then
                            forma_pago = "01"
                        End If
                        fl_datos = True
                    End If
                End If
            End If
            If rbAutomatica.Checked Then
                If Modo_edicion Then
                    NumeracionGeneral = String.Empty
                    NumeracionGeneral = Numero_edicion
                    txtNumeracionManual.Text = Numero_edicion
                Else
                    If txtNumeracionManual.Text = String.Empty Then
                        clsAlmacenBl = New ClsTransacciones.clsAlmacen
                        clsAlmacenBl.Get_NumeroGuiaRemision(Serie, TipoDocumento)
                        NumeracionGeneral = String.Empty
                        TipoNumeracion = String.Empty
                        'If clsAlmacenBl.MODIFICA_CORRELATIVO = "S" Then
                        '    GroupBox5.Visible = True
                        'Else
                        '    GroupBox5.Visible = False
                        'End If
                        NumeracionGeneral = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
                        txtNumeracionManual.Text = NumeracionGeneral
                        TipoNumeracion = "A"
                    Else
                        monto_soles = 0
                        monto_dolares = 0
                        monto_visa = 0
                        monto_mastercard = 0
                        monto_american_expres = 0
                        monto_diners_club = 0
                        monto_scotiabank = 0
                        monto_interbank = 0
                        Vuelto = 0
                        modo_pago = ""
                        forma_pago = ""

                        If TxEfeSol.Text = "" Then
                            TxEfeSol.Text = "0"
                        End If
                        If TxEfeDol.Text = "" Then
                            TxEfeDol.Text = "0"
                        End If
                        If txt_bcp.Text = "" Then
                            txt_bcp.Text = "0"
                        End If
                        If txt_bbva.Text = "" Then
                            txt_bbva.Text = "0"
                        End If
                        If txt_yape.Text = "" Then
                            txt_yape.Text = "0"
                        End If
                        If txt_plin.Text = "" Then
                            txt_plin.Text = "0"
                        End If
                        If txt_scotiabank.Text = "" Then
                            txt_scotiabank.Text = "0"
                        End If
                        If txt_interbank.Text = "" Then
                            txt_interbank.Text = "0"
                        End If

                        If rdb_credito.Checked Then
                            TipoCanelacion = "Credito"

                        ElseIf rdb_contado.Checked Then

                            If CDbl(TxEfeSol.Text) = 0 And CDbl(txt_bcp.Text) = 0 And CDbl(txt_bbva.Text) = 0 And CDbl(txt_yape.Text) = 0 And CDbl(txt_plin.Text) = 0 And CDbl(txt_scotiabank.Text) = 0 And CDbl(txt_interbank.Text) = 0 Then
                                MsgBox("Debe ingresar una forma de cancelación.", MsgBoxStyle.Exclamation, "Aviso")
                                TxEfeSol.Select()
                                fl_datos = False
                                estado = False
                                Exit Try
                            End If

                            If CDbl(lblpagado.Text) < CDbl(lblmonto_venta.Text) Then
                                MsgBox("El monto cancelado es menor al monto de la venta. Verifique!!!", MsgBoxStyle.Exclamation)
                                estado = False
                                Exit Try
                            End If

                            If TxEfeSol.Text = "" Then
                                TxEfeSol.Text = "0"
                            End If
                            If TxEfeDol.Text = "" Then
                                TxEfeDol.Text = "0"
                            End If
                            If txt_bcp.Text = "" Then
                                txt_bcp.Text = "0"
                            End If
                            If txt_bbva.Text = "" Then
                                txt_bbva.Text = "0"
                            End If
                            If txt_yape.Text = "" Then
                                txt_yape.Text = "0"
                            End If
                            If txt_plin.Text = "" Then
                                txt_plin.Text = "0"
                            End If

                            If txt_scotiabank.Text = "" Then
                                txt_scotiabank.Text = "0"
                            End If
                            If txt_interbank.Text = "" Then
                                txt_interbank.Text = "0"
                            End If

                            If CDbl(TxEfeSol.Text) > 0 Or CDbl(TxEfeDol.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "Efectivo/"
                            End If

                            If CDbl(TxEfeSol.Text) > 0 Then
                                monto_soles = CDbl(TxEfeSol.Text)
                            End If

                            If CDbl(TxEfeDol.Text) > 0 Then
                                monto_dolares = CDbl(TxEfeDol.Text)
                            End If

                            If CDbl(txt_bcp.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "BCP/"
                                monto_visa = CDbl(txt_bcp.Text)
                                num_operacion_visa = txt_num_operacion_bcp.Text
                            End If
                            If CDbl(txt_bbva.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "BBVA/"
                                monto_mastercard = CDbl(txt_bbva.Text)
                                num_operacion_mastercard = txt_num_operacion_bbva.Text
                            End If
                            If CDbl(txt_yape.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "YAPE/"
                                monto_diners_club = CDbl(txt_yape.Text)
                                num_operacion_diners = txt_num_operacion_yape.Text
                            End If
                            If CDbl(txt_plin.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "PLIN/"
                                monto_american_expres = CDbl(txt_plin.Text)
                                num_operacion_american = txt_num_operacion_plin.Text
                            End If
                            If CDbl(txt_scotiabank.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "SCOTIABANK/"
                                monto_scotiabank = CDbl(txt_scotiabank.Text)
                                num_operacion_scotiabank = txt_num_operacion_scotiabank.Text
                            End If
                            If CDbl(txt_interbank.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "INTERBANK/"
                                monto_interbank = CDbl(txt_interbank.Text)
                                num_operacion_interbank = txt_num_operacion_interbank.Text
                            End If

                            If Strings.Len(TipoCanelacion) <> 0 Then
                                TipoCanelacion = Mid(TipoCanelacion, 1, Len(TipoCanelacion) - 1)
                            End If

                            If monto_soles = 0 Then
                                If (monto_visa + monto_mastercard + monto_diners_club + monto_american_expres + monto_scotiabank + monto_interbank) > CDbl(lblmonto_venta.Text) Then
                                    MsgBox("El monto a cancelar es mayor al monto de la venta!!!", MsgBoxStyle.Exclamation)
                                    fl_datos = False
                                    estado = False
                                    Exit Try
                                End If
                            Else
                                If (monto_soles + monto_visa + monto_mastercard + monto_diners_club + monto_american_expres + monto_scotiabank + monto_interbank) > CDbl(lblmonto_venta.Text) Then
                                    MsgBox("El monto a cancelar es mayor al monto de la venta!!!", MsgBoxStyle.Exclamation)
                                    fl_datos = False
                                    estado = False
                                    Exit Try
                                End If
                            End If

                        End If

                        If lblpagado.Text <> "" Then
                            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                                lblvuelto.Text = Format(0, "###,###.00")
                            Else
                                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
                            End If
                        End If


                        If lblvuelto.Text = "" Then
                            Vuelto = 0.0
                        Else
                            Vuelto = CDbl(lblvuelto.Text)
                        End If
                        If monto_soles > 0 Then
                            monto_soles = Math.Abs(CDbl(lblmonto_venta.Text) - (monto_visa + monto_mastercard + monto_diners_club + monto_american_expres + monto_scotiabank + monto_interbank))
                        End If
                        modo_pago = txt_cod_modo_pago.Text
                        If rdb_contado.Checked Then
                            forma_pago = "00"
                        ElseIf rdb_credito.Checked Then
                            forma_pago = "01"
                        End If
                        fl_datos = True
                    End If
                End If
            End If

        Catch ex As Exception
            fl_datos = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAceptarNumeracion_Click(sender As Object, e As EventArgs) Handles btnAceptarNumeracion.Click
        If GeneracionCodigoAutomatico() = False Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub btnSalirNumeracion_Click(sender As Object, e As EventArgs) Handles btnSalirNumeracion.Click
        fl_datos = False
        Me.Close()
    End Sub
    Private Sub rbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked Then
            txtNumeracionManual.Enabled = True
            txtNumeracionManual.Text = String.Empty
            txtNumeracionManual.Focus()
        Else
            txtNumeracionManual.Enabled = False
            txtNumeracionManual.Text = String.Empty
            GeneracionCodigoAutomatico()
        End If
    End Sub

    Private Sub txt_scotiabank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_scotiabank.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_interbank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_interbank.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_scotiabank_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_scotiabank.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub txt_interbank_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_interbank.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarNumeracion.Focus()
        End If
    End Sub

    Private Sub txt_scotiabank_TextChanged(sender As Object, e As EventArgs) Handles txt_scotiabank.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub

    Private Sub txt_interbank_TextChanged(sender As Object, e As EventArgs) Handles txt_interbank.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If txt_bcp.Text = "" Then
            txt_bcp.Text = "0"
        End If
        If txt_bbva.Text = "" Then
            txt_bbva.Text = "0"
        End If
        If txt_yape.Text = "" Then
            txt_yape.Text = "0"
        End If
        If txt_plin.Text = "" Then
            txt_plin.Text = "0"
        End If
        If txt_scotiabank.Text = "" Then
            txt_scotiabank.Text = "0"
        End If
        If txt_interbank.Text = "" Then
            txt_interbank.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
            If CDbl(lblpagado.Text) > CDbl(lblmonto_venta.Text) Then
                lblfalta_pagar.Text = Format(0, "###,###.00")
            Else
                lblfalta_pagar.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            If CDbl(lblpagado.Text) <= CDbl(lblmonto_venta.Text) Then
                lblvuelto.Text = Format(0, "###,###.00")
            Else
                lblvuelto.Text = Format(CDbl(lblpagado.Text) - CDbl(lblmonto_venta.Text), "###,###.00")
            End If
            TXTTOTALE.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)), "###,###.00")
            TXTTOTALT.Text = Format(CDbl(txt_bcp.Text) + CDbl(txt_bbva.Text) + CDbl(txt_yape.Text) + CDbl(txt_plin.Text) + CDbl(txt_scotiabank.Text) + CDbl(txt_interbank.Text), "###,###.00")
        End If
    End Sub
End Class