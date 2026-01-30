Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmConfiguracionDocumentos

    Dim clsReceivablaBl As ClsOperaciones.RECEIVABLE
    Dim dtConsulta As DataTable
    Dim Modo_Edicion As Boolean = False

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
        End If
    End Sub

    Private Sub TipoDocumento()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "ALM_SP_S_WAREHOUSE_TIPO_DOCUMENTO"
        frm.CadenaConsulta = sql
        frm.Titulo = "Tipo de Documentos de Referencias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txttipoDoc.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtdocContable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtDescripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub DocumentosConfiguracion()
        Try
            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            Dim dtDocumentos As New DataTable
            dtDocumentos = clsReceivablaBl.Mostrar_Configuracion_Documentos()
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos
                'dgvCabecera.Columns(2).Width = 220
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmConfiguracionDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        DocumentosConfiguracion()
    End Sub

    Private Sub Limpiar()
        txttipoDoc.Text = String.Empty
        txtdocContable.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtserie.Text = String.Empty
        txtcodigosunat.Text = String.Empty
        txtimpresora.Text = String.Empty
        txtnroInicio.Text = String.Empty
        txtcontrolador.Text = String.Empty
        txtpuertoImpresora.Text = String.Empty
        txtnroFinal.Text = String.Empty
        txtlineasImpresion.Text = String.Empty
        txtultimonumero.Text = String.Empty
        txt_formato_impresion.Text = String.Empty

        txt_veces_impresion.Text = String.Empty
        txt_nombre_impresora.Text = String.Empty

        chk_Puntoventa.Checked = False
        chk_razon.Checked = False
        chk_ruc.Checked = False
        chk_tipoC.Checked = False
        chk_ordenC.Checked = False
        chk_serie.Checked = False
        chk_direcc.Checked = False
        chk_fechaDoc.Checked = False
        chk_cotizacion.Checked = False
        chk_pedido.Checked = False
        chk_cl.Checked = False
        chk_especial.Checked = False
        chk_almacen.Checked = False
        chk_mueveStock.Checked = False
        chk_modDesc.Checked = False
        chk_Controlstock.Checked = False
        chk_digitacionIgv.Checked = False
        chkacep_asiento.Checked = False
        chkicbp.Checked = False
        chkiconta.Checked = False
        chkacep_asiento.Checked = False
        chkgenera_comp_per.Checked = False
        chkgeneradetraccion.Checked = False
        chkestadocuentacliente.Checked = False
        chk_generacanjeletra.Checked = False
        chkdeleteplanillacobros.Checked = False
        chkdeleteplanillapagos.Checked = False
        chkgeneraigvfacturar.Checked = False
        chkgenerafe.Checked = False
        chk_impresion_directa.Checked = False
        chk_no_modificar_correlativo.Checked = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Modo_Edicion = False
        Limpiar()
        If Modo_Edicion = False Then
            txttipoDoc.Enabled = True
            txtserie.Enabled = True
            txtserie.Focus()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            Dim CONSULTA As String = String.Empty
            If txttipoDoc.Text = String.Empty Then
                MsgBox("Debe seleccionar un tipo de Documento.", MsgBoxStyle.Information)
                txttipoDoc.Focus()
                Exit Sub
            ElseIf txtserie.Text = String.Empty Then
                MsgBox("Debe seleccionar un tipo de Documento.", MsgBoxStyle.Information)
                txtserie.Focus()
                Exit Sub
            ElseIf txtnroInicio.Text = String.Empty Then
                MsgBox("Debe ingresar un numero inical.", MsgBoxStyle.Information)
                txtnroInicio.Focus()
                Exit Sub
            ElseIf txtultimonumero.Text = String.Empty Then
                MsgBox("Debe ingresar el ultimo numero.", MsgBoxStyle.Information)
                txtultimonumero.Focus()
                Exit Sub
            ElseIf txtnroFinal.Text = String.Empty Then
                MsgBox("Debe ingresar un numero final.", MsgBoxStyle.Information)
                txtnroFinal.Focus()
                Exit Sub
            End If
            If Modo_Edicion = False Then
                clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                dtConsulta = New DataTable
                dtConsulta = clsReceivablaBl.Verificacion_Serie_Documento(txttipoDoc.Text, txtserie.Text)
                If dtConsulta.Rows().Count() <> 0 Then
                    MsgBox("Serie ya existe para el Tipo de Documento : " & txttipoDoc.Text, MsgBoxStyle.Critical)
                    txtserie.Focus()
                    Exit Sub
                End If

                CONSULTA = "INSERT INTO dbo.NUMBER_DOCUMENT (NO_MODIFICA_CORRELATIVO,IS_PRINT_AUTOMATIC,IMPRESORA,NUMERO_IMPRESIONES,IS_FACTUR_ELECTRONICO,TYPE_DOC, NUMBER_SERIE, BEGIN_NUMBER, END_NUMBER, LAST_NUMBER, USER_ID, REPORT_ID," _
                        & " NUMBER_LINE, IS_DATE, IS_VAT, IS_NAME, IS_ADDR, IS_PURCHASE, IS_ESTIMATING, IS_ORDER, IS_WAREHOUSE, IS_MODIFY_PART, " _
                        & " STATUS, IS_AFFECTED_STOCK, IS_PLACE_SALES, IS_SERIE, IS_CURR_EXCHANGE, IS_STOCK, PRINTER_ID, DRIVER_PRINTER, PORT, " _
                        & " IS_TAX, IS_CUST_DISCOUNT, IS_DISCOUNT_SP,IS_SAVE_CBP,IS_SAVE_CONT,IS_ACCEPT_CONT,IS_GENERA_COMP_PER,IS_GENERA_DETRACCION,IS_GENERA_ESTADO_CUENTA,IS_GENERA_CANJE_LETRA,IS_DELETE_PLANILLA,IS_DELETE_PLANILLA_COBROS,IS_GENERA_ASIENTO_VENTA,IS_GENERA_IGV)" _
                        & " VALUES ('" & IIf(chk_no_modificar_correlativo.Checked = True, "S", "N") & "','" & IIf(chk_impresion_directa.Checked = True, "S", "N") & "','" & txt_nombre_impresora.Text.Trim & "'," & txt_veces_impresion.Text & ",'" & IIf(chkgenerafe.Checked = True, "S", "N") & "','" & txttipoDoc.Text & "', '" & txtserie.Text & "', '" & txtnroInicio.Text & "', '" & txtultimonumero.Text & "', '" & txtnroFinal.Text & "'," _
                        & " '" & LibComunVar.ClsVarComun.USUARIO & "', '', '" & txtlineasImpresion.Text & "', '" & IIf(chk_fechaDoc.Checked = True, "S", "N") & "', " _
                        & " '" & IIf(chk_ruc.Checked = True, "S", "N") & "', '" & IIf(chk_razon.Checked = True, "S", "N") & "', '" & IIf(chk_direcc.Checked = True, "S", "N") & "', " _
                        & " '" & IIf(chk_ordenC.Checked = True, "S", "N") & "', '" & IIf(chk_cotizacion.Checked = True, "S", "N") & "', '" & IIf(chk_pedido.Checked = True, "S", "N") & "', " _
                        & " '" & IIf(chk_almacen.Checked = True, "S", "N") & "', '" & IIf(chk_modDesc.Checked = True, "S", "N") & "', '', " _
                        & " '" & IIf(chk_mueveStock.Checked = True, "S", "N") & "', '" & IIf(chk_Puntoventa.Checked = True, "S", "N") & "', '" & IIf(chk_serie.Checked = True, "S", "N") & "', " _
                        & " '" & IIf(chk_tipoC.Checked = True, "S", "N") & "', '" & IIf(chk_Controlstock.Checked = True, "S", "N") & "', '" & txtimpresora.Text & "', '" & txtcontrolador.Text & "', '" & txtpuertoImpresora.Text & "', " _
                        & " '" & IIf(chk_digitacionIgv.Checked = True, "1", "0") & "', '" & IIf(chk_cl.Checked = True, "S", "N") & "', '" & IIf(chk_especial.Checked = True, "S", "N") & "','" & IIf(chkicbp.Checked = True, "S", "N") & "','" & IIf(chkiconta.Checked = True, "S", "N") & "','" & IIf(chkacep_asiento.Checked = True, "S", "N") & "','" & IIf(chkgenera_comp_per.Checked = True, "S", "N") & "','" & IIf(chkgeneradetraccion.Checked = True, "S", "N") & "','" & IIf(chkestadocuentacliente.Checked = True, "S", "N") & "','" & IIf(chk_generacanjeletra.Checked = True, "S", "N") & "','" & IIf(chkdeleteplanillacobros.Checked = True, "S", "N") & "','" & IIf(chkdeleteplanillapagos.Checked = True, "S", "N") & "','" & IIf(chkasientoventa.Checked = True, "S", "N") & "','" & IIf(chkgeneraigvfacturar.Checked = True, "S", "N") & "')"
                clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                    MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                End If

                dtConsulta = clsReceivablaBl.Obtener_Nombre_Reporte(txttipoDoc.Text, txtserie.Text)
                If dtConsulta.Rows().Count() > 0 Then
                    CONSULTA = "UPDATE dbo.FORMAT_REPORT SET REPORT_NAME = '" & txt_formato_impresion.Text.Trim & "' " _
                        & " WHERE DOCUMENT_TYPE = '" & txttipoDoc.Text & "' AND SERIE = '" & txtserie.Text & "' "

                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                    If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                        'MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
                    Else
                        'MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                    End If
                Else
                    CONSULTA = "INSERT INTO dbo.FORMAT_REPORT (COMPANY_ID, FORMAT_ID, DOCUMENT_TYPE, REPORT_NAME, NAME, SERIE) " _
                        & " VALUES ('" & LibComunVar.ClsVarComun.NomEmpresa & "', '', '" & txttipoDoc.Text & "', '" & txt_formato_impresion.Text.Trim & "', '" & txtDescripcion.Text.Trim & "', '" & txtserie.Text.Trim & "') "

                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                    If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                        'MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
                    Else
                        'MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                    End If

                End If
            Else
                'Dim CONSULTA As String = String.Empty
                CONSULTA = "Update dbo.NUMBER_DOCUMENT SET NO_MODIFICA_CORRELATIVO='" & IIf(chk_no_modificar_correlativo.Checked = True, "S", "N") & "', IS_PRINT_AUTOMATIC='" & IIf(chk_impresion_directa.Checked = True, "S", "N") & "',IMPRESORA='" & txt_nombre_impresora.Text.Trim & "',NUMERO_IMPRESIONES=" & txt_veces_impresion.Text & ", IS_FACTUR_ELECTRONICO='" & IIf(chkgenerafe.Checked = True, "S", "N") & "', BEGIN_NUMBER = '" & txtnroInicio.Text & "', END_NUMBER = '" & txtultimonumero.Text & "', LAST_NUMBER = '" & txtnroFinal.Text & "' ," _
                & "  USER_ID = '" & LibComunVar.ClsVarComun.USUARIO & "', NUMBER_LINE = '" & txtlineasImpresion.Text & "', IS_DATE ='" & IIf(chk_fechaDoc.Checked = True, "S", "N") & "' ," _
                & "  IS_VAT = '" & IIf(chk_ruc.Checked = True, "S", "N") & "', IS_NAME = '" & IIf(chk_razon.Checked = True, "S", "N") & "',IS_ADDR ='" & IIf(chk_direcc.Checked = True, "S", "N") & "', " _
                & " IS_PURCHASE = '" & IIf(chk_ordenC.Checked = True, "S", "N") & "',IS_ESTIMATING= '" & IIf(chk_cotizacion.Checked = True, "S", "N") & "',IS_ORDER= '" & IIf(chk_pedido.Checked = True, "S", "N") & "', " _
                & " IS_WAREHOUSE= '" & IIf(chk_almacen.Checked = True, "S", "N") & "', IS_MODIFY_PART='" & IIf(chk_modDesc.Checked = True, "S", "N") & "', " _
                        & " IS_AFFECTED_STOCK='" & IIf(chk_mueveStock.Checked = True, "S", "N") & "',IS_PLACE_SALES= '" & IIf(chk_Puntoventa.Checked = True, "S", "N") & "', IS_SERIE='" & IIf(chk_serie.Checked = True, "S", "N") & "', " _
                        & " IS_CURR_EXCHANGE='" & IIf(chk_tipoC.Checked = True, "S", "N") & "', IS_STOCK='" & IIf(chk_Controlstock.Checked = True, "S", "N") & "', PRINTER_ID='" & txtimpresora.Text & "', " _
                        & " DRIVER_PRINTER='" & txtcontrolador.Text & "', PORT='" & txtpuertoImpresora.Text & "', " _
                        & " IS_GENERA_IGV='" & IIf(chkgeneraigvfacturar.Checked = True, "S", "N") & "', " _
                        & " IS_TAX='" & IIf(chk_digitacionIgv.Checked = True, "1", "0") & "', IS_CUST_DISCOUNT='" & IIf(chk_cl.Checked = True, "S", "N") & "', " _
                        & " IS_DISCOUNT_SP='" & IIf(chk_especial.Checked = True, "S", "N") & "',IS_SAVE_CBP='" & IIf(chkicbp.Checked = True, "S", "N") & "',IS_SAVE_CONT='" & IIf(chkiconta.Checked = True, "S", "N") & "',IS_ACCEPT_CONT='" & IIf(chkacep_asiento.Checked = True, "S", "N") & "',IS_GENERA_COMP_PER='" & IIf(chkgenera_comp_per.Checked = True, "S", "N") & "',IS_GENERA_DETRACCION='" & IIf(chkgeneradetraccion.Checked = True, "S", "N") & "',IS_GENERA_ESTADO_CUENTA='" & IIf(chkestadocuentacliente.Checked = True, "S", "N") & "',IS_GENERA_CANJE_LETRA='" & IIf(chk_generacanjeletra.Checked = True, "S", "N") & "',IS_DELETE_PLANILLA='" & IIf(chkdeleteplanillapagos.Checked = True, "S", "N") & "',IS_DELETE_PLANILLA_COBROS='" & IIf(chkdeleteplanillacobros.Checked = True, "S", "N") & "',IS_GENERA_ASIENTO_VENTA='" & IIf(chkasientoventa.Checked = True, "S", "N") & "'  WHERE TYPE_DOC = '" & txttipoDoc.Text & "' AND NUMBER_SERIE = '" & txtserie.Text & "'"
                clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                    MsgBox("Modificado exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                End If

                dtConsulta = clsReceivablaBl.Obtener_Nombre_Reporte(txttipoDoc.Text, txtserie.Text)
                If dtConsulta.Rows().Count() > 0 Then
                    CONSULTA = "UPDATE dbo.FORMAT_REPORT SET REPORT_NAME = '" & txt_formato_impresion.Text.Trim & "' " _
                        & " WHERE DOCUMENT_TYPE = '" & txttipoDoc.Text & "' AND SERIE = '" & txtserie.Text & "' "

                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                    If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                        'MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
                    Else
                        'MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                    End If
                Else
                    CONSULTA = "INSERT INTO dbo.FORMAT_REPORT (COMPANY_ID, FORMAT_ID, DOCUMENT_TYPE, REPORT_NAME, NAME, SERIE) " _
                        & " VALUES ('" & LibComunVar.ClsVarComun.NomEmpresa & "', '', '" & txttipoDoc.Text & "', '" & txt_formato_impresion.Text.Trim & "', '" & txtDescripcion.Text.Trim & "', '" & txtserie.Text.Trim & "') "

                    clsReceivablaBl = New ClsOperaciones.RECEIVABLE
                    If clsReceivablaBl.Ejecuta_consulta(CONSULTA) Then
                        'MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
                    Else
                        'MsgBox("No se llego a modificar.", MsgBoxStyle.Information)
                    End If

                End If
            End If
            btnCancelar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _Tipo As String = String.Empty
        Dim _Serie As String = String.Empty
        Limpiar()
        _Tipo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Serie = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value
        If Modo_Edicion = True Then
            txttipoDoc.Enabled = False
            txtserie.Enabled = False
        End If
        Try
            ''cabecera
            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            Dim dtConfigDoc As New DataTable
            dtConfigDoc = clsReceivablaBl.Modo_Edicion_Cabecera_Configuracion(_Tipo, _Serie)
            If dtConfigDoc.Rows.Count() <> 0 Then
                txttipoDoc.Text = dtConfigDoc.Rows(0).Item(0).ToString
                txtDescripcion.Text = dtConfigDoc.Rows(0).Item("NAME").ToString
                txt_formato_impresion.Text = dtConfigDoc.Rows(0).Item("REPORT_NAME").ToString

                txt_nombre_impresora.Text = dtConfigDoc.Rows(0).Item("IMPRESORA").ToString
                txt_veces_impresion.Text = dtConfigDoc.Rows(0).Item("NUMERO_IMPRESIONES").ToString

                txtdocContable.Text = dtConfigDoc.Rows(0).Item(0).ToString
                txtserie.Text = dtConfigDoc.Rows(0).Item(1).ToString
                txtnroInicio.Text = dtConfigDoc.Rows(0).Item(2).ToString
                txtultimonumero.Text = dtConfigDoc.Rows(0).Item(3).ToString
                txtnroFinal.Text = dtConfigDoc.Rows(0).Item(4).ToString
                txtlineasImpresion.Text = dtConfigDoc.Rows(0).Item(7).ToString
                chk_fechaDoc.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_DATE").ToString = "S", True, False)
                chk_ruc.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_VAT").ToString = "S", True, False)
                chk_razon.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_NAME").ToString = "S", True, False)
                chk_direcc.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_ADDR").ToString = "S", True, False)
                chk_ordenC.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_PURCHASE").ToString = "S", True, False)
                chk_cotizacion.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_ESTIMATING").ToString = "S", True, False)
                chk_pedido.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_ORDER").ToString = "S", True, False)
                chk_almacen.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_WAREHOUSE").ToString = "S", True, False)
                chk_modDesc.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_MODIFY_PART").ToString = "S", True, False)
                chk_mueveStock.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_AFFECTED_STOCK").ToString = "S", True, False)
                chk_Puntoventa.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_PLACE_SALES").ToString = "S", True, False)
                chk_serie.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_SERIE").ToString = "S", True, False)
                chk_tipoC.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_CURR_EXCHANGE").ToString = "S", True, False)
                chk_Controlstock.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_STOCK").ToString = "S", True, False)
                txtimpresora.Text = dtConfigDoc.Rows(0).Item("PRINTER_ID").ToString
                txtcontrolador.Text = dtConfigDoc.Rows(0).Item("DRIVER_PRINTER").ToString
                txtpuertoImpresora.Text = dtConfigDoc.Rows(0).Item("PORT").ToString
                chk_digitacionIgv.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_TAX").ToString = "S", True, False)
                chk_cl.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_CUST_DISCOUNT").ToString = "S", True, False)
                chk_especial.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_DISCOUNT_SP").ToString = "S", True, False)
                chkicbp.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_SAVE_CBP").ToString = "S", True, False)
                chkiconta.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_SAVE_CONT").ToString = "S", True, False)
                chkacep_asiento.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_ACCEPT_CONT").ToString = "S", True, False)
                chkgenera_comp_per.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_COMP_PER").ToString = "S", True, False)
                chkgeneradetraccion.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_DETRACCION").ToString = "S", True, False)
                chkestadocuentacliente.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_ESTADO_CUENTA").ToString = "S", True, False)
                chk_generacanjeletra.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_CANJE_LETRA").ToString = "S", True, False)
                chkdeleteplanillacobros.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_DELETE_PLANILLA_COBROS").ToString = "S", True, False)
                chkdeleteplanillapagos.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_DELETE_PLANILLA").ToString = "S", True, False)
                chkasientoventa.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_ASIENTO_VENTA").ToString = "S", True, False)
                chkgeneraigvfacturar.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_GENERA_IGV").ToString = "S", True, False)
                chkgenerafe.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_FACTUR_ELECTRONICO").ToString = "S", True, False)
                chk_impresion_directa.Checked = IIf(dtConfigDoc.Rows(0).Item("IS_PRINT_AUTOMATIC").ToString = "S", True, False)
                chk_no_modificar_correlativo.Checked = IIf(dtConfigDoc.Rows(0).Item("NO_MODIFICA_CORRELATIVO").ToString = "S", True, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttipoDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttipoDoc.MouseDoubleClick
        TipoDocumento()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_Edicion = False
        Limpiar()
        DocumentosConfiguracion()
    End Sub

    Private Sub txtnroInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtultimonumero.KeyPress, txtnroInicio.KeyPress, txtnroFinal.KeyPress, txtlineasImpresion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            clsReceivablaBl = New ClsOperaciones.RECEIVABLE
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim _Tipo As String = String.Empty
                Dim _Serie As String = String.Empty
                _Tipo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
                _Serie = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value
                Dim sql As String = String.Empty
                sql = "Delete from NUMBER_DOCUMENT WHERE TYPE_DOC='" & _Tipo & "' AND NUMBER_SERIE ='" & _Serie & "'"
                If clsReceivablaBl.Ejecuta_consulta(sql) Then
                    MsgBox("Documento eliminado Correctamente.", MsgBoxStyle.Information)
                    btnCancelar_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_veces_impresion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_veces_impresion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class