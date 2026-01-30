Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmTipoNumeracion
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
    Public monto_american_expres As Double = 0.0
    Public monto_diners_club As Double = 0.0
    Public modo_pago As String = ""
    Public forma_pago As String = ""
    Public num_operacion_visa As String = String.Empty
    Public num_operacion_mastercard As String = String.Empty
    Public num_operacion_american As String = String.Empty
    Public num_operacion_diners As String = String.Empty

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
                        If AMOUNT_CARD_VISA.Text = "" Then
                            AMOUNT_CARD_VISA.Text = "0"
                        End If
                        If AMOUNT_CARD_MASTER.Text = "" Then
                            AMOUNT_CARD_MASTER.Text = "0"
                        End If
                        If AMOUNT_DINERS.Text = "" Then
                            AMOUNT_DINERS.Text = "0"
                        End If
                        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
                            AMOUNT_AMERICAN_EXPRES.Text = "0"
                        End If

                        If CDbl(TxEfeSol.Text) = 0 And CDbl(AMOUNT_CARD_VISA.Text) = 0 And CDbl(AMOUNT_CARD_MASTER.Text) = 0 And CDbl(AMOUNT_DINERS.Text) = 0 And CDbl(AMOUNT_AMERICAN_EXPRES.Text) = 0 Then
                            MsgBox("Debe ingresar una forma de cancelación.", MsgBoxStyle.Exclamation, "Aviso")
                            TxEfeSol.Select()
                            fl_datos = False
                            estado = False
                            Exit Try
                        End If

                        If rdb_credito.Checked Then
                            TipoCanelacion = "Credito"

                        ElseIf rdb_contado.Checked Then
                            If TxEfeSol.Text = "" Then
                                TxEfeSol.Text = "0"
                            End If
                            If TxEfeDol.Text = "" Then
                                TxEfeDol.Text = "0"
                            End If
                            If AMOUNT_CARD_VISA.Text = "" Then
                                AMOUNT_CARD_VISA.Text = "0"
                            End If
                            If AMOUNT_CARD_MASTER.Text = "" Then
                                AMOUNT_CARD_MASTER.Text = "0"
                            End If
                            If AMOUNT_DINERS.Text = "" Then
                                AMOUNT_DINERS.Text = "0"
                            End If
                            If AMOUNT_AMERICAN_EXPRES.Text = "" Then
                                AMOUNT_AMERICAN_EXPRES.Text = "0"
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

                            If CDbl(AMOUNT_CARD_VISA.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "VISA/"
                                monto_visa = CDbl(AMOUNT_CARD_VISA.Text)
                                num_operacion_visa = txt_num_operacion_visa.Text
                            End If
                            If CDbl(AMOUNT_CARD_MASTER.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "MASTER CARD/"
                                monto_mastercard = CDbl(AMOUNT_CARD_MASTER.Text)
                                num_operacion_mastercard = txt_num_operacion_master.Text
                            End If
                            If CDbl(AMOUNT_DINERS.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "DINERS/"
                                monto_diners_club = CDbl(AMOUNT_DINERS.Text)
                                num_operacion_diners = txt_num_operacion_diners.Text
                            End If
                            If CDbl(AMOUNT_AMERICAN_EXPRES.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "AMERICAN EXPRESS/"
                                monto_american_expres = CDbl(AMOUNT_AMERICAN_EXPRES.Text)
                                num_operacion_american = txt_num_operacion_american.Text
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
                        Vuelto = 0
                        modo_pago = ""
                        forma_pago = ""

                        If TxEfeSol.Text = "" Then
                            TxEfeSol.Text = "0"
                        End If
                        If TxEfeDol.Text = "" Then
                            TxEfeDol.Text = "0"
                        End If
                        If AMOUNT_CARD_VISA.Text = "" Then
                            AMOUNT_CARD_VISA.Text = "0"
                        End If
                        If AMOUNT_CARD_MASTER.Text = "" Then
                            AMOUNT_CARD_MASTER.Text = "0"
                        End If
                        If AMOUNT_DINERS.Text = "" Then
                            AMOUNT_DINERS.Text = "0"
                        End If
                        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
                            AMOUNT_AMERICAN_EXPRES.Text = "0"
                        End If

                        If CDbl(TxEfeSol.Text) = 0 And CDbl(AMOUNT_CARD_VISA.Text) = 0 And CDbl(AMOUNT_CARD_MASTER.Text) = 0 And CDbl(AMOUNT_DINERS.Text) = 0 And CDbl(AMOUNT_AMERICAN_EXPRES.Text) = 0 Then
                            MsgBox("Debe ingresar una forma de cancelación.", MsgBoxStyle.Exclamation, "Aviso")
                            TxEfeSol.Select()
                            fl_datos = False
                            estado = False
                            Exit Try
                        End If

                        If rdb_credito.Checked Then
                            TipoCanelacion = "Credito"

                        ElseIf rdb_contado.Checked Then
                            If TxEfeSol.Text = "" Then
                                TxEfeSol.Text = "0"
                            End If
                            If TxEfeDol.Text = "" Then
                                TxEfeDol.Text = "0"
                            End If
                            If AMOUNT_CARD_VISA.Text = "" Then
                                AMOUNT_CARD_VISA.Text = "0"
                            End If
                            If AMOUNT_CARD_MASTER.Text = "" Then
                                AMOUNT_CARD_MASTER.Text = "0"
                            End If
                            If AMOUNT_DINERS.Text = "" Then
                                AMOUNT_DINERS.Text = "0"
                            End If
                            If AMOUNT_AMERICAN_EXPRES.Text = "" Then
                                AMOUNT_AMERICAN_EXPRES.Text = "0"
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

                            If CDbl(AMOUNT_CARD_VISA.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "VISA/"
                                monto_visa = CDbl(AMOUNT_CARD_VISA.Text)
                                num_operacion_visa = txt_num_operacion_visa.Text
                            End If
                            If CDbl(AMOUNT_CARD_MASTER.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "MASTER CARD/"
                                monto_mastercard = CDbl(AMOUNT_CARD_MASTER.Text)
                                num_operacion_mastercard = txt_num_operacion_master.Text
                            End If
                            If CDbl(AMOUNT_DINERS.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "DINERS/"
                                monto_diners_club = CDbl(AMOUNT_DINERS.Text)
                                num_operacion_diners = txt_num_operacion_diners.Text
                            End If
                            If CDbl(AMOUNT_AMERICAN_EXPRES.Text) > 0 Then
                                TipoCanelacion = TipoCanelacion & "AMERICAN EXPRESS/"
                                monto_american_expres = CDbl(AMOUNT_AMERICAN_EXPRES.Text)
                                num_operacion_american = txt_num_operacion_american.Text
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

    Private Sub FrmTipoNumeracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AMOUNT_CARD_VISA.Text = 0
        AMOUNT_CARD_MASTER.Text = 0
        TXTTOTALE.Text = 0
        TXTTOTALT.Text = 0

        txt_num_operacion_visa.Text = ""
        txt_num_operacion_master.Text = ""
        txt_num_operacion_american.Text = ""
        txt_num_operacion_diners.Text = ""

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
        End If
    End Sub

    Private Sub TxEfeSol_TextChanged(sender As Object, e As EventArgs) Handles TxEfeSol.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If AMOUNT_CARD_VISA.Text = "" Then
            AMOUNT_CARD_VISA.Text = "0"
        End If
        If AMOUNT_CARD_MASTER.Text = "" Then
            AMOUNT_CARD_MASTER.Text = "0"
        End If
        If AMOUNT_DINERS.Text = "" Then
            AMOUNT_DINERS.Text = "0"
        End If
        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
            AMOUNT_AMERICAN_EXPRES.Text = "0"
        End If

        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
        End If

    End Sub

    Private Sub TxEfeDol_TextChanged(sender As Object, e As EventArgs) Handles TxEfeDol.TextChanged
        If TxEfeDol.Text = "" Then Exit Sub
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_TextChanged(sender As Object, e As EventArgs) Handles AMOUNT_CARD_VISA.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If AMOUNT_CARD_VISA.Text = "" Then
            AMOUNT_CARD_VISA.Text = "0"
        End If
        If AMOUNT_CARD_MASTER.Text = "" Then
            AMOUNT_CARD_MASTER.Text = "0"
        End If
        If AMOUNT_DINERS.Text = "" Then
            AMOUNT_DINERS.Text = "0"
        End If
        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
            AMOUNT_AMERICAN_EXPRES.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_TextChanged(sender As Object, e As EventArgs) Handles AMOUNT_CARD_MASTER.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If AMOUNT_CARD_VISA.Text = "" Then
            AMOUNT_CARD_VISA.Text = "0"
        End If
        If AMOUNT_CARD_MASTER.Text = "" Then
            AMOUNT_CARD_MASTER.Text = "0"
        End If
        If AMOUNT_DINERS.Text = "" Then
            AMOUNT_DINERS.Text = "0"
        End If
        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
            AMOUNT_AMERICAN_EXPRES.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_DINERS_TextChanged(sender As Object, e As EventArgs) Handles AMOUNT_DINERS.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If AMOUNT_CARD_VISA.Text = "" Then
            AMOUNT_CARD_VISA.Text = "0"
        End If
        If AMOUNT_CARD_MASTER.Text = "" Then
            AMOUNT_CARD_MASTER.Text = "0"
        End If
        If AMOUNT_DINERS.Text = "" Then
            AMOUNT_DINERS.Text = "0"
        End If
        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
            AMOUNT_AMERICAN_EXPRES.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_TextChanged(sender As Object, e As EventArgs) Handles AMOUNT_AMERICAN_EXPRES.TextChanged
        If TxEfeSol.Text = "" Then
            TxEfeSol.Text = "0"
        End If
        If TxEfeDol.Text = "" Then
            TxEfeDol.Text = "0"
        End If
        If AMOUNT_CARD_VISA.Text = "" Then
            AMOUNT_CARD_VISA.Text = "0"
        End If
        If AMOUNT_CARD_MASTER.Text = "" Then
            AMOUNT_CARD_MASTER.Text = "0"
        End If
        If AMOUNT_DINERS.Text = "" Then
            AMOUNT_DINERS.Text = "0"
        End If
        If AMOUNT_AMERICAN_EXPRES.Text = "" Then
            AMOUNT_AMERICAN_EXPRES.Text = "0"
        End If
        If _nuevo = True Then
            lblpagado.Text = Format(CDbl(TxEfeSol.Text) + CDbl(IIf(TxEfeDol.Text = "", 0, TxEfeDol.Text) * CDbl(lbltipo_cambio.Text)) + CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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
            TXTTOTALT.Text = Format(CDbl(AMOUNT_CARD_VISA.Text) + CDbl(AMOUNT_CARD_MASTER.Text) + CDbl(AMOUNT_DINERS.Text) + CDbl(AMOUNT_AMERICAN_EXPRES.Text), "###,###.00")
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

    Private Sub AMOUNT_CARD_VISA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_CARD_VISA.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_CARD_MASTER.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_DINERS.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_AMERICAN_EXPRES.KeyPress
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
            txt_cod_modo_pago.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_VISA_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_CARD_VISA.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_modo_pago.Focus()
        End If
    End Sub

    Private Sub AMOUNT_CARD_MASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_CARD_MASTER.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_modo_pago.Focus()
        End If
    End Sub

    Private Sub AMOUNT_DINERS_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_DINERS.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_modo_pago.Focus()
        End If
    End Sub

    Private Sub AMOUNT_AMERICAN_EXPRES_KeyDown(sender As Object, e As KeyEventArgs) Handles AMOUNT_AMERICAN_EXPRES.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_modo_pago.Focus()
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
End Class