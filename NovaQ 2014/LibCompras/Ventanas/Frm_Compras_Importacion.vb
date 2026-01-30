Imports System.Windows.Forms
Imports LibComunVar
Imports LibCobranzas
Imports System.Drawing
Imports LibContabilidad
Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Frm_Compras_Importacion
    Private clsLetrasBl As ClsNegocio.PART
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim Modo_consultar As Boolean = False
    Dim CompraCabENT As ClsEntidades.PURCHASE_FACT_SUPPLIER_IMPORT
    Dim CompraImportacion As ClsEntidades.REFERENCES_DOCUMENT_IMPORTACION_COMPRAS
    Dim CompraDetENT As ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT
    Dim ListaDetalles As List(Of ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT)
    Dim Compra_gastos_Varios As ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS
    Dim dtTable As DataTable
    Dim carteraBE As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY
    Dim CarteraBl As LibContabilidad.ClsOperaciones.Asiento_Contable

    Dim CompraBl As ClsOperaciones.PURCHASE_FACT_SUPPLIER

    Dim CORRELATIVOBL As ClsTransacciones.PURCHASE_FACT_SUPPLIER
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim LibData As LibConexion.ClsData
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_Gastos_Varios As DataTable
    Dim Fl_close As Boolean = False
    Dim TIPO_FORMULA, TIPO_PROD As String

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim _Flag_edicion As Boolean = False
    Dim dtResultados As DataTable

    Dim _Codigo_Ini As String = ""
    Dim _TipoAnexoDoc As String = ""
    Dim _TipoDato As String = ""
    Dim _NumeroTipoAnexoDoc As String = ""
    Dim _tipo_de_documento As String
    Dim Dt_principal_lista_Doc_Ref As DataTable

    Dim id_caja_chica As String = String.Empty
    Dim item_caja_chica As String = String.Empty
    Dim item As String = String.Empty


    Private Sub Frm_Compras_Importacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        Cargar_Moneda()
        GenerarColummnaDataTable()
        GenerarColummnaDataTable_Gastos_varios()
        'Ayuda_TipoDocumento()
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbomoneda.DataSource = monedaBL.get_TiposCambio()
        cbomoneda.ValueMember = "CODIGO"
        cbomoneda.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub

    'Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    DocumentosOrdenCompra()
    'End Sub

    Private Sub Limpiar()

        txtproveedor.Text = String.Empty
        txtproveedor_razons.Text = String.Empty
        txtproveedor_ruc.Text = String.Empty
        txt_invoice2.Text = ""
        dtp_fecha_invoice.Value = Date.Now
        txt_numero_dam.Text = ""
        dtp_fecha_dam.Value = Date.Now
        cbomoneda.SelectedIndex = 0
        txttipoCambio.Text = "0.000" 'LibComunVar.ClsVarComun.TCVenta
        txtComentario.Text = String.Empty
        dgvDetalle.DataSource = Nothing
        dtdetalleArticuloPrincipal.Rows.Clear()
        dtdetalleArticuloPrincipal_Gastos_Varios.Rows.Clear()
        txtproveedor.Enabled = True
        cbomoneda.Enabled = True

    End Sub

    Private Sub Nuevo()
        Try
            Limpiar()
            ConfigurarGrila()
            Modo_consultar = False
            CONTROLES(True, 0)
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            If Modo_consultar = False Then
                lblcompra.Visible = False
                txtcodigo.Visible = False
                txtproveedor.Enabled = True
                cbomoneda.Enabled = True
                gbOpciones.Enabled = True
            End If
            txtproveedor.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        CONTROLES(True, 0)
        pnlCabecera.Visible = False
        Dim _id As Integer = 0
        
        _id = dgvCabecera.CurrentRow.Cells("ID").Value
        If Modo_consultar = True Then
            txtcodigo.Visible = True
            lblcompra.Visible = True
            txtcodigo.Enabled = False
            txtproveedor.Enabled = False
            cbomoneda.Enabled = False
        End If
        Try
            'cabecera
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtCabeceraoC As New DataTable
            dtCabeceraoC = CompraBl.Modo_Edicion_Cabecera_Importacion(_id)
            If dtCabeceraoC.Rows.Count() <> 0 Then
                gbcabecera.Enabled = True
                txtcodigo.Text = dtCabeceraoC.Rows(0).Item("ID").ToString
                txtproveedor.Text = dtCabeceraoC.Rows(0).Item("VENDOR_ID").ToString
                txtproveedor_razons.Text = dtCabeceraoC.Rows(0).Item("NOMBRE_PROVEEDOR").ToString
                txtproveedor_ruc.Text = dtCabeceraoC.Rows(0).Item("RUC_PROVEEDOR").ToString
                txt_invoice2.Text = dtCabeceraoC.Rows(0).Item("INVOICE").ToString
                dtp_fecha_invoice.Value = dtCabeceraoC.Rows(0).Item("FECHA_INVOICE").ToString
                txt_numero_dam.Text = dtCabeceraoC.Rows(0).Item("NRO_DAM").ToString
                dtp_fecha_dam.Value = dtCabeceraoC.Rows(0).Item("FECHA_DAM").ToString
                cbomoneda.SelectedValue = dtCabeceraoC.Rows(0).Item("CURRENCY_TYPE").ToString
                txttipoCambio.Text = dtCabeceraoC.Rows(0).Item("SELL_RATE").ToString
                txtComentario.Text = dtCabeceraoC.Rows(0).Item("COMMENT").ToString

                If dtCabeceraoC.Rows(0).Item("STATUS_ID").ToString = "02" Then
                    gbOpciones.Enabled = False
                    btnGrabar.Enabled = False
                Else
                    gbOpciones.Enabled = True
                    btnGrabar.Enabled = True
                End If

                'Detalle
                CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = CompraBl.Modo_Edicion_Detalle_Importacion(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                End If
                GenerarColummnaDataTable_Gastos_varios()
                dtdetalleArticuloPrincipal_Gastos_Varios = CompraBl.Modo_Edicion_Detalle_Importacion_Gastos_Varios(_id)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function get_MostrarDescripcion(ByVal cadena As String) As String
        Try
            dtTable = New DataTable
            LibData = New LibConexion.ClsData
            Dim description As String = String.Empty
            dtTable = LibData.Run_Query_DataTable(cadena)
            LibData.Dispose()
            description = dtTable.Rows(0).Item(0).ToString()
            Return description
        Catch ex As Exception
        End Try
    End Function

    Private Function Guardar_Compra() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            CompraCabENT = New ClsEntidades.PURCHASE_FACT_SUPPLIER_IMPORT
            ListaDetalles = New List(Of ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT)
            CompraCabENT = New ClsEntidades.PURCHASE_FACT_SUPPLIER_IMPORT
            Compra_gastos_Varios = New ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS

            If Modo_consultar = True Then
                CompraCabENT.ID = txtcodigo.Text
            Else
                CompraCabENT.ID = 0
            End If

            With CompraCabENT
                .VENDOR_ID = txtproveedor.Text
                .INVOICE = txt_invoice2.Text
                .FECHA_INVOICE = dtp_fecha_invoice.Value.ToString("dd/MM/yyyy")
                .NRO_DAM = txt_numero_dam.Text
                .FECHA_DAM = dtp_fecha_dam.Value.ToString("dd/MM/yyyy")
                .CURRENCY_TYPE = cbomoneda.SelectedValue
                .SELL_RATE = txttipoCambio.Text
                .COMMENT = txtComentario.Text
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .STATUS_ID = "01"
            End With
            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                CompraDetENT = New ClsEntidades.PURCHASE_FACT_SUPPLIER_LINE_IMPORT
                With CompraDetENT
                    .ID_CAB = CompraCabENT.ID
                    .ITEM = item("ITEM")
                    .PART_ID = item("PART_ID")
                    .PART_DESCRIPTION = item("DESCRIPTION")
                    .UNIT = item("UNIT")
                    .DAM = item("SUBPARTIDA_NACIONAL_DAM")
                    .QTY = item("QTY")
                    .PRICE = item("PRICE")
                    .PRICE_TOTAL = item("PRICE_TOTAL")
                    .AD_VALOREM2 = item("AD_VALOREM2")
                    .ISC = item("ISC_POR")
                    .IGV = item("IGV_POR")
                    .IPM = item("IPM_POR")
                    .DERECHOS_ESPECIFICOS = item("DERECHOS_ESPECIFICOS")
                    .DERECHOS_ANTIDUMPING = item("DERECHOS_ANTIDUMPING")
                    .SEGURO2 = item("SEGURO2")
                    .SOBRETASA_TRIBUTO = item("SOBRETASA_TRIBUTO")
                    .SOBRETASA_SANCION = item("SOBRETASA_SANCION")
                    .PERCEPCION2 = item("PERCEPCION2")
                    .VALOR_REF_FLETE_DAM = item("VALOR_REF_FLETE")
                    .FLETE_DAM = item("FLETE")
                    .SEGURO_DAM = item("SEGURO")
                    .AD_VALOREM_DAM = item("AD_VALOREM")
                    .IGV_DAM = item("IGV")
                    .IPM_DAM = item("IPM")
                    .PERCEPCION_DAM = item("PERCEPCION")

                    .COMISION_AGENCIA_ADUANAS2 = item("COMISION_AGENCIA_ADUANAS2")
                    .GASTOS_OPERATIVOS = item("GASTOS_OPERATIVOS")
                    .GASTOS_ADMINISTRATIVOS = item("GASTOS_ADMINISTRATIVOS")
                    .HANDLING_DESTINO = item("HANDLING_DESTINO")
                    .TRANSMISION_MANIFIESTO = item("TRANSMISION_MANIFIESTO")
                    .GASTOS_OPERACIONAL_DESTINO = item("GASTOS_OPERACIONAL_DESTINO")
                    .SEGURO3 = item("SEGURO3")
                    .ALMACEN = item("ALMACEN")
                    .VISTOS_BUENOS = item("VISTOS_BUENOS")
                    .DEVOLUCION_CONTENEDOR = item("DEVOLUCION_CONTENEDOR")
                    .DESCONSOLIDACION = item("DESCONSOLIDACION")
                    .REPARACION_CONTENEDOR = item("REPARACION_CONTENEDOR")
                    .RECTIFICACION_MANI = item("RECTIFICACION_MANI")
                    .FLETE_MARITIMO = item("FLETE_MARITIMO")
                    .TRANSPORTE_TERRESTRE = item("TRANSPORTE_TERRESTRE")
                    .TC = item("TC")
                    .TOTAL_COSTO_AGENCIA_ADUANAS = item("TOTAL_COSTO_AGENCIA_ADUANAS")
                    .COSTO_INVOICE2_TOTAL = item("COSTO_INVOICE2_TOTAL")
                    .COSTO_ADVALOREM_TOTAL = item("COSTO_ADVALOREM_TOTAL")
                    .COSTO_AGENCIA_ADUANA_TOTAL = item("COSTO_AGENCIA_ADUANA_TOTAL")
                    .COSTO_TOTAL = item("COSTO_TOTAL")
                    .COSTO_UNITARIO = item("COSTO_UNITARIO")
                    .COSTO_UNITARIO_SOLES = item("COSTO_UNITARIO_SOLES")
                End With
                ListaDetalles.Add(CompraDetENT)
            Next

            For Each item As DataRow In dtdetalleArticuloPrincipal_Gastos_Varios.Rows
                With Compra_gastos_Varios
                    .ID_CAB = CompraCabENT.ID
                    .COMISION_AGENCIA_ADUANAS2 = item("COMISION_AGENCIA_ADUANAS2")
                    .GASTOS_OPERATIVOS = item("GASTOS_OPERATIVOS")
                    .GASTOS_ADMINISTATIVOS = item("GASTOS_ADMINISTRATIVOS")
                    .HANDLING_DESTINO = item("HANDLING_DESTINO")
                    .TRANSMISION_MANIFIESTO = item("TRANSMISION_MANIFIESTO")
                    .GASTOS_OPERACIONAL_DESTINO = item("GASTOS_OPERACIONAL_DESTINO")
                    .SEGURO3 = item("SEGURO3")
                    .ALMACEN = item("ALMACEN")
                    .VISTOS_BUENOS = item("VISTOS_BUENOS")
                    .DEVOLUCION_CONTENEDOR = item("DEVOLUCION_CONTENEDOR")
                    .DESCONSOLIDACION = item("DESCONSOLIDACION")
                    .REPARACION_CONTENEDOR = item("REPARACION_CONTENEDOR")
                    .RECTIFICACION_MANI = item("RECTIFICACION_MANI")
                    .FLETE_MARITIMO = item("FLETE_MARITIMO")
                    .TRANSPORTE_TERRESTRE = item("TRANSPORTE_TERRESTRE")
                End With
            Next


            If CompraBl.Guardar_Importacion(CompraCabENT, ListaDetalles, IIf(Modo_consultar = False, True, False), Compra_gastos_Varios) Then
                If Modo_consultar = True Then
                    MsgBox("Documento Modificado Correctamente," & vbCrLf & "Nro Documento: " & CompraCabENT.ID, MsgBoxStyle.Information)
                Else
                    MsgBox("Nuevo documento Generado Correctamente," & vbCrLf & "Nro Documento: " & CompraCabENT.ID, MsgBoxStyle.Information)
                End If
                Me.Cursor = Cursors.Default
                Return True
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se registro el documento en las Importaciones. Verifique!", MsgBoxStyle.Critical)
                Return False
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If ValidacionesGenerales() = False Then Exit Sub
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("QTY=0 OR PRICE=0", "")
                MessageBox.Show("Falta ingresar el precio y/o cantidad a los Articulos.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next
        End If

        If MessageBox.Show("Se va a registrar la Importación" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Guardar_Compra() Then
                DocumentosCompra()
                btnCancelar_Click(sender, e)
            End If
        End If


    End Sub
    Private Function OpenSubForm(ByVal form As Form) As Boolean
        Dim estado As Boolean = True
        Try
            For Each formulario As Form In Application.OpenForms
                If formulario.Name = form.Name Then
                    estado = False
                    formulario.Activate()
                    Exit Try
                End If
            Next
            form.Show()
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Function Ayuda_CambioEstado(ByVal _Estado As String) As String
        Dim Estado As String = ""
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRA_SP_S_ESTADO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _Estado
            frm.Titulo = "Listado de Estados de la orden de Compra"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                Estado = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Estado
    End Function


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim estadoInicial As String = ""
            Dim estadoActualizado As String = ""
            Dim estadoContabilizado As String = ""
            Dim _id As Integer = 0

            _id = dgvCabecera.CurrentRow.Cells("ID").Value
            estadoInicial = dgvCabecera.CurrentRow.Cells("ESTADO").Value '12

            If estadoInicial = "ANULADO" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If estadoInicial = "EMITIDO" Then
                If MessageBox.Show("Se va a anular la Importación" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If CompraBl.Anular_Oden_Importacion(_id) Then
                        MsgBox("Documento anulado Correctamente.", MsgBoxStyle.Information)
                        DocumentosCompra()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
                        If cCENTENA & cDECENA & cUNIDAD = "001" Or num > 1999999 Then
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

    Private Sub imprimir_Compra(ByVal _Codigo As String, ByVal _Monto As Double, ByVal _Moneda As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Compra")
            Me.Cursor = Cursors.WaitCursor

            Dim STRmontotexto As String = String.Empty
            If _Moneda = "MN" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Soles"
            ElseIf _Moneda = "ME" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Dólares Americanos"
            ElseIf _Moneda = "EE" Then
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Euros"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   "
            End If
            dtImprimir = reporteBL.EjecutarReporteCompra(_Codigo)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Facturar_Compra.rpt", "", "", "", "@NUMERO;" & _Codigo, "@LETRA;" & STRmontotexto)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'Dim _Id As String = String.Empty
        'Dim _Monto As Double = 0.0
        'Dim _Moneda As String = String.Empty
        '_Id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        '_Monto = IIf(String.IsNullOrEmpty(dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value.ToString), 0, dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value)
        '_Moneda = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
        'imprimir_Compra(_Id, _Monto, _Moneda)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        'dtpemision.MinDate = "01/01/1753"
        'dtpemision.MaxDate = "31/12/9998"
        'Limpiar()
        'gbcabecera.Enabled = True
        'DocumentosCompra()
    End Sub



    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub



    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtproveedor.Text = String.Empty Then
                MsgBox("Debe ingresar un numero de referencia.", MsgBoxStyle.Exclamation)
                estado = False
                txtproveedor.Focus()
                Exit Try
            ElseIf txt_invoice2.Text = String.Empty Then
                MsgBox("Debe digitar el Invoice 2.", MsgBoxStyle.Exclamation)
                estado = False
                txt_invoice2.Focus()
                Exit Try
            ElseIf txt_numero_dam.Text = String.Empty Then
                MsgBox("Debe digitar el número DAM.", MsgBoxStyle.Exclamation)
                estado = False
                txt_numero_dam.Focus()
                Exit Try
            End If
            If cbomoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                cbomoneda.Focus()
                Exit Try
            End If
            If txttipoCambio.Text = String.Empty Or Val(txttipoCambio.Text) = 0 Then
                MsgBox("Debe registrar un tipo de cambio para la fecha elegida.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function



    Public Sub blank()
        txtcodigoArticulo.Text = ""
        txtdescripcionArticulo.Text = ""
        txtunidadMedida.Text = ""
        txt_sub_partida_dam.Text = ""
        txt_cantidad.Text = ""
        txt_precio_unitario.Text = ""
        txt_precio_total.Text = ""
        txt_ad_valorem2.Text = "0"
        txt_derechos_antidumping.Text = "0"
        txt_isc.Text = "0"
        txt_seguro2.Text = "0"
        txt_igv.Text = "0"
        txt_sobretasa_tributo.Text = "0"
        txt_ipm.Text = "0"
        txt_sobretasa_sancion.Text = "0"
        txt_derechos_especificos.Text = "0"
        txt_percepcion2.Text = "0"
        txt_valor_ref_flete.Text = "0"
        txt_flete.Text = "0"
        txt_seguro.Text = "0"
        txt_ad_valorem.Text = "0"
        txt_igv_.Text = "0"
        txt_ipm_.Text = "0"
        txt_percepcion.Text = "0"

        txt_1.Text = "0"
        txt_2.Text = "0"
        txt_3.Text = "0"
        txt_4.Text = "0"
        txt_5.Text = "0"
        txt_6.Text = "0"
        txt_7.Text = "0"
        txt_8.Text = "0"
        txt_9.Text = "0"
        txt_10.Text = "0"
        txt_11.Text = "0"
        txt_12.Text = "0"
        txt_13.Text = "0"
        txt_14.Text = "0"
        txt_15.Text = "0"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                gbcabecera.Enabled = False
            End If
            _Flag_edicion = False
            'CONTROLES(True, 2)
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            txtcodigoArticulo.Enabled = True
            txtcodigoArticulo.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function TasaIgvEstandar() As Double
        Dim tasa As Double = 0.0
        Try
            Dim OrdenCompraBl As New ClsOperaciones.PURCHASE_ORDER
            Dim dtSistema As New DataTable("IGV_SISTEMA")
            dtSistema = OrdenCompraBl.Get_DatosIgvsSistema()
            tasa = CDbl(dtSistema.Rows(0).Item("AMOUNT_TAX"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tasa
    End Function


    Private Sub CalcularTotales()
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                'txtDescuentos.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (DISCOUNT) ", ""), "0.00")
                'txtvalorVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (PRICE_NET) ", ""), "0.00")
                'txtIgv.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TAX) ", ""), "0.00")
                'txtPrecioVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (AMOUNT_TOTAL_NET) ", ""), "0.00")
                'txtBruto.Text = Format(Val(txtvalorVenta.Text) + Val(txtDescuentos.Text), "0.00")
            Else
                'txtBruto.Text = "0.00"
                'txtDescuentos.Text = "0.00"
                'txtvalorVenta.Text = "0.00"
                'txtIgv.Text = "0.00"
                'txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                gbcabecera.Enabled = False
            End If

            _Flag_edicion = True
            _Codigo_Ini = String.Empty
            _Codigo_Ini = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                txtcodigoArticulo.Text = row("PART_ID")
                txtdescripcionArticulo.Text = row("DESCRIPTION")
                txtunidadMedida.Text = row("UNIT")
                txt_sub_partida_dam.Text = row("SUBPARTIDA_NACIONAL_DAM")
                txt_cantidad.Text = row("QTY")
                txt_precio_unitario.Text = row("PRICE")
                txt_precio_total.Text = row("PRICE_TOTAL")
                txt_ad_valorem2.Text = row("AD_VALOREM2")
                txt_isc.Text=row("ISC_POR") 
                txt_igv.Text = row("IGV_POR")
                txt_ipm.Text = row("IPM_POR")
                txt_derechos_especificos.Text = row("DERECHOS_ESPECIFICOS")
                txt_derechos_antidumping.Text = row("DERECHOS_ANTIDUMPING")
                txt_seguro2.Text = row("SEGURO2")
                txt_sobretasa_tributo.Text = row("SOBRETASA_TRIBUTO")
                txt_sobretasa_sancion.Text = row("SOBRETASA_SANCION")
                txt_percepcion2.Text = row("PERCEPCION2")
                txt_valor_ref_flete.Text = row("VALOR_REF_FLETE")
                txt_flete.Text = row("FLETE")
                txt_seguro.Text = row("SEGURO")
                txt_ad_valorem.Text = row("AD_VALOREM")
                txt_igv_.Text = row("IGV")
                txt_ipm_.Text = row("IPM")
                txt_percepcion.Text = row("PERCEPCION")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub

    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

                If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then
                    _TipoAnexoDoc = ""
                Else
                    RehacerSecuencia()
                End If
                Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Enabled = False
            Case 1
                gbRangofechas.Enabled = False
            Case 2
                gbRangofechas.Enabled = True
        End Select
        txtFiltro.Text = String.Empty
        DocumentosCompra()
    End Sub

    Private Sub Ayuda_Clientes()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_PROVEEDORES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtproveedor.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtproveedor_razons.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtproveedor_ruc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                'dtpemision.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtproveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtproveedor.MouseDoubleClick
        Ayuda_Clientes()
    End Sub



    Private Sub Ayuda_FormaPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRA_SP_S_FORMA_PAGO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Lista de Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'txtFormaPago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                'lblformapago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                'txtresponsable.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFormaPago_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_FormaPago()
    End Sub

    Private Sub Ayuda_Responsable()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_RESPONSABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE RESPONSABLES"
            frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    txtresponsable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            '    lblresponsable.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            '    txtPorc_Detrac.Select()
            'Else
            '    txtPorc_Detrac.Select()
            'End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Centro_Costo_Compras(Optional ByVal _codigo As String = "")
        Try
            If _codigo = "" Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PUR_SP_S_CENTRO_COSTO_COMPRAS"
                frm.CadenaConsulta = sql
                frm.Titulo = "LISTA DE CENTROS DE COSTO COMPRAS"
                frm.ShowDialog()
                'If frm.Data_Matriz.Rows.Count > 0 Then
                '    txtcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                '    lblcentrocostodetalle.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                '    txtcantidad.Select()
                'Else
                '    txtcentrocostodetalle.Select()
                'End If
                frm.Close()
            Else
                Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
                Dim dtDocumentoGuias As New DataTable
                dtDocumentoGuias = clsArticuloBl.Verifica_Centro_Costo(_codigo)
                'If dtDocumentoGuias.Rows.Count > 0 Then
                '    lblcentrocostodetalle.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                'End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtresponsable_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Responsable()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                Exit Sub
            Else
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("ID").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("VENDOR_ID").Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns("RAZON_SOCIAL").Name
                            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                            If dtv.Count() = 0 Then
                                STRorden = String.Empty
                                STRorden = dgvCabecera.Columns("INVOICE").Name
                                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                If dtv.Count() = 0 Then
                                    STRorden = String.Empty
                                    STRorden = dgvCabecera.Columns("NRO_DAM").Name
                                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                                    If dtv.Count() = 0 Then
                                        STRorden = String.Empty
                                        STRorden = dgvCabecera.Columns("ID").Name & "+" & dgvCabecera.Columns("VENDOR_ID").Name & "+" & dgvCabecera.Columns("RAZON_SOCIAL").Name & "+" & dgvCabecera.Columns("INVOICE").Name & "+" & dgvCabecera.Columns("NRO_DAM").Name
                                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                                        Exit Sub
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        End If

    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosCompra()
        End If
        If e.KeyCode = Keys.Tab Then
            dtpfechafinal.Focus()
        End If
    End Sub

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Ayuda_Unidad_Medida()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_UNIDAD_REF"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista Unidad de Medida de Referencia"
            frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    txtunidadMedRef.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            'Else
            '    txtunidadMedRef.Text = ""
            'End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtunidadMedRef_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Unidad_Medida()
    End Sub

    Private Sub txtValorunitario_Leave(sender As Object, e As EventArgs)
        'If txtValorunitario.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    'Private Sub Calcular_Importes_Detalle()
    '    Try
    '        Dim nValorVta As Double
    '        Dim nValorUniRef As Double
    '        Dim nValorUnit As Double
    '        Dim nPrecioUnit As Double
    '        Dim nDsctoUnit As Double
    '        Dim nValorBruto As Double
    '        Dim nTasaIGV As Double
    '        Dim nMontoIgv As Double
    '        Dim nMontodes As Double
    '        Dim nMontoTotal As Double
    '        nTasaIGV = (Val(txttasa.Text) / 100)
    '        If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
    '            'Aplicando descuento
    '            If chkigv.Checked = True Then
    '                nValorUnit = Math.Round(Val(txtValorunitario.Text) / (1 + nTasaIGV), 6)
    '            Else
    '                nValorUnit = Val(txtValorunitario.Text)
    '            End If
    '            If Val(txtcantidadref.Text) <> 0 And Val(txtcantidad.Text) <> 0 Then
    '                nValorUniRef = Math.Round((Val(txtcantidadref.Text) / Val(txtcantidad.Text)) * nValorUnit, 6)
    '                nDsctoUnit = nValorUniRef * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
    '                nValorUniRef = nValorUniRef - nDsctoUnit
    '                nValorUnit = nValorUniRef
    '            Else
    '                nValorUniRef = 0
    '                nDsctoUnit = nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
    '                nValorUnit = nValorUnit - nDsctoUnit
    '            End If
    '            'Precio Unitario
    '            nPrecioUnit = nValorUnit * (1 + nTasaIGV)
    '            nValorVta = nValorUnit * Val(txtcantidad.Text)
    '            nMontodes = nDsctoUnit * Val(txtcantidad.Text)
    '            nMontoIgv = (nValorUnit * nTasaIGV) * Val(txtcantidad.Text)
    '            nMontoTotal = nValorVta + nMontoIgv
    '            nValorBruto = nValorVta + nMontodes

    '            txtvalorventaref.Text = Format(nValorUniRef, "0.00")
    '            txtvalorventaunit.Text = Format(nValorUnit, "0.00")
    '            txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
    '            txtvalorbruto.Text = Format(nValorBruto, "0.00")
    '            txtdescuento.Text = Format(nMontodes, "0.00")
    '            txtvalorvent.Text = Format(nValorVta, "0.00")
    '            txt_igv.Text = Format(nMontoIgv, "0.00")
    '            txttotalneto.Text = Format(nMontoTotal, "0.00")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub Calcular_Importes_Detalle()
        Try
            Dim precio_Total As Double
            Dim valor_Ref_Flete As Double
            Dim flete As Double
            Dim seguro As Double
            Dim ad_Valorem As Double
            Dim igv As Double
            Dim ipm As Double
            Dim percepcion As Double

            precio_Total = CDbl(txt_precio_total.Text)
            valor_Ref_Flete = CDbl(txt_valor_ref_flete.Text)
            flete = CDbl(txt_flete.Text)
            seguro = CDbl(txt_seguro.Text)

            ad_Valorem = (precio_Total + valor_Ref_Flete + flete + seguro) * (CDbl(txt_ad_valorem2.Text) / 100)
            igv = (precio_Total + valor_Ref_Flete + flete + seguro + ad_Valorem) * (CDbl(txt_igv.Text) / 100)
            ipm = (precio_Total + valor_Ref_Flete + flete + seguro + ad_Valorem) * (CDbl(txt_ipm.Text) / 100)
            percepcion = (precio_Total + valor_Ref_Flete + flete + seguro + ad_Valorem + igv + ipm) * (CDbl(txt_percepcion2.Text) / 100)

            txt_ad_valorem.Text = Format(ad_Valorem, "0.00")
            txt_igv_.Text = Format(igv, "0.00")
            txt_ipm_.Text = Format(ipm, "0.00")
            txt_percepcion.Text = Format(percepcion, "0.00")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Calcular_Precio_Total()
        Try
            Dim precio_Total As Double

            precio_Total = CDbl(txt_cantidad.Text) * CDbl(txt_precio_unitario.Text)
            txt_precio_total.Text = Format(precio_Total, "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkigv_CheckedChanged(sender As Object, e As EventArgs)
        Calcular_Importes_Detalle()
        'txtobservaciones.Focus()
    End Sub

    Private Sub Ayuda_Centro_Costo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_CENTRO_COSTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    txtcentroCosto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            'Else
            '    txtcentroCosto.Text = ""
            'End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcentroCosto_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Centro_Costo()
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    txtarea.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            'Else
            '    txtarea.Text = ""
            'End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Area()
    End Sub

    Private Sub txtproyecto_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Proyecto()
    End Sub

    Private Sub Ayuda_Proyecto()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "PUR_SP_S_PROYECTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Centros de Costo"
            frm.ShowDialog()
            'If frm.Data_Matriz.Rows.Count > 0 Then
            '    txtproyecto.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
            'Else
            '    txtproyecto.Text = ""

            'End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidacionesGeneralesArticulo() = False Then Exit Sub
            If _Flag_edicion = False Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                    row("ITEM") = CInt(dtdetalleArticuloPrincipal.Rows(dtdetalleArticuloPrincipal.Rows.Count - 1).Item("item").ToString) + 1 'dtdetalleArticuloPrincipal.Rows.Count() + 1
                Else
                    row("ITEM") = 1
                End If
                row("PART_ID") = txtcodigoArticulo.Text
                row("DESCRIPTION") = txtdescripcionArticulo.Text
                row("UNIT") = txtunidadMedida.Text
                row("SUBPARTIDA_NACIONAL_DAM") = txt_sub_partida_dam.Text
                row("QTY") = IIf(txt_cantidad.Text = "", 0, txt_cantidad.Text)
                row("PRICE") = IIf(txt_precio_unitario.Text = "", 0, txt_precio_unitario.Text)
                row("PRICE_TOTAL") = IIf(txt_precio_total.Text = "", 0, txt_precio_total.Text)
                row("AD_VALOREM2") = IIf(txt_ad_valorem2.Text = "", 0, (txt_ad_valorem2.Text))
                row("ISC_POR") = IIf(txt_isc.Text = "", 0, txt_isc.Text)
                row("IGV_POR") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                row("IPM_POR") = IIf(txt_ipm.Text = "", 0, txt_ipm.Text)
                row("DERECHOS_ESPECIFICOS") = IIf(txt_derechos_especificos.Text = "", 0, txt_derechos_especificos.Text)
                row("DERECHOS_ANTIDUMPING") = IIf(txt_derechos_antidumping.Text = "", 0, txt_derechos_antidumping.Text)
                row("SEGURO2") = IIf(txt_seguro2.Text = "", 0.0, txt_seguro2.Text)
                row("SOBRETASA_TRIBUTO") = IIf(txt_sobretasa_tributo.Text = "", 0.0, txt_sobretasa_tributo.Text)
                row("SOBRETASA_SANCION") = IIf(txt_sobretasa_sancion.Text = "", 0.0, txt_sobretasa_sancion.Text)
                row("PERCEPCION2") = IIf(txt_percepcion2.Text = "", 0.0, txt_percepcion2.Text)
                row("VALOR_REF_FLETE") = IIf(txt_valor_ref_flete.Text = "", 0.0, txt_valor_ref_flete.Text)
                row("FLETE") = IIf(txt_flete.Text = "", 0.0, txt_flete.Text)
                row("SEGURO") = IIf(txt_seguro.Text = "", 0.0, txt_seguro.Text)
                row("AD_VALOREM") = IIf(txt_ad_valorem.Text = "", 0.0, txt_ad_valorem.Text)
                row("IGV") = IIf(txt_igv_.Text = "", 0.0, txt_igv_.Text)
                row("IPM") = IIf(txt_ipm_.Text = "", 0.0, txt_ipm_.Text)
                row("PERCEPCION") = IIf(txt_percepcion.Text = "", 0.0, txt_percepcion.Text)
                row("TC") = CDbl(txttipoCambio.Text)
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                blank()
                txtcodigoArticulo.Select()
            Else
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("PART_ID") = txtcodigoArticulo.Text
                    row("DESCRIPTION") = txtdescripcionArticulo.Text
                    row("UNIT") = txtunidadMedida.Text
                    row("SUBPARTIDA_NACIONAL_DAM") = txt_sub_partida_dam.Text
                    row("QTY") = IIf(txt_cantidad.Text = "", 0, txt_cantidad.Text)
                    row("PRICE") = IIf(txt_precio_unitario.Text = "", 0, txt_precio_unitario.Text)
                    row("PRICE_TOTAL") = IIf(txt_precio_total.Text = "", 0, txt_precio_total.Text)
                    row("AD_VALOREM2") = IIf(txt_ad_valorem2.Text = "", 0, (txt_ad_valorem2.Text))
                    row("ISC_POR") = IIf(txt_isc.Text = "", 0, txt_isc.Text)
                    row("IGV_POR") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
                    row("IPM_POR") = IIf(txt_ipm.Text = "", 0, txt_ipm.Text)
                    row("DERECHOS_ESPECIFICOS") = IIf(txt_derechos_especificos.Text = "", 0, txt_derechos_especificos.Text)
                    row("DERECHOS_ANTIDUMPING") = IIf(txt_derechos_antidumping.Text = "", 0, txt_derechos_antidumping.Text)
                    row("SEGURO2") = IIf(txt_seguro2.Text = "", 0.0, txt_seguro2.Text)
                    row("SOBRETASA_TRIBUTO") = IIf(txt_sobretasa_tributo.Text = "", 0.0, txt_sobretasa_tributo.Text)
                    row("SOBRETASA_SANCION") = IIf(txt_sobretasa_sancion.Text = "", 0.0, txt_sobretasa_sancion.Text)
                    row("PERCEPCION2") = IIf(txt_percepcion2.Text = "", 0.0, txt_percepcion2.Text)
                    row("VALOR_REF_FLETE") = IIf(txt_valor_ref_flete.Text = "", 0.0, txt_valor_ref_flete.Text)
                    row("FLETE") = IIf(txt_flete.Text = "", 0.0, txt_flete.Text)
                    row("SEGURO") = IIf(txt_seguro.Text = "", 0.0, txt_seguro.Text)
                    row("AD_VALOREM") = IIf(txt_ad_valorem.Text = "", 0.0, txt_ad_valorem.Text)
                    row("IGV") = IIf(txt_igv_.Text = "", 0.0, txt_igv_.Text)
                    row("IPM") = IIf(txt_ipm_.Text = "", 0.0, txt_ipm_.Text)
                    row("PERCEPCION") = IIf(txt_percepcion.Text = "", 0.0, txt_percepcion.Text)
                    row("TC") = CDbl(txttipoCambio.Text)
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                btn_cancel.PerformClick()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesGeneralesArticulo() As Boolean
        Dim estado As Boolean = True
        Try
            'If txt_valor_ref_flete.Text = String.Empty Then
            '    MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
            '    estado = False
            '    txt_valor_ref_flete.Focus()
            '    Exit Try
            'ElseIf Val(txt_valor_ref_flete.Text) <= 0 Then
            '    MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
            '    estado = False
            '    txt_valor_ref_flete.Focus()
            '    Exit Try
            'ElseIf txtValorunitario.Text = String.Empty Then
            '    MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
            '    estado = False
            '    txtValorunitario.Focus()
            '    Exit Try
            'ElseIf Val(txtValorunitario.Text) = 0 Then
            '    MsgBox("La cantidad debe ser diferente a Cero", MsgBoxStyle.Information, "Sistemas")
            '    estado = False
            '    txtValorunitario.Focus()
            '    Exit Try
            'ElseIf txtcentrocostodetalle.Text = String.Empty Then
            '    MsgBox("Debe elegir un Centro de Costo.", MsgBoxStyle.Information, "Sistemas")
            '    estado = False
            '    txtcentrocostodetalle.Focus()
            '    Exit Try
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_ARTICULO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "IP"
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtunidadMedida.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_sub_partida_dam.Text = frm.Data_Matriz.Rows(0).Item("DAM").ToString
                txt_ad_valorem2.Text = frm.Data_Matriz.Rows(0).Item("AD_VALOREM2").ToString
                txt_isc.Text = frm.Data_Matriz.Rows(0).Item("ISC").ToString
                txt_igv.Text = frm.Data_Matriz.Rows(0).Item("IGV").ToString
                txt_ipm.Text = frm.Data_Matriz.Rows(0).Item("IPM").ToString
                txt_derechos_especificos.Text = frm.Data_Matriz.Rows(0).Item("DERECHOS_ESPECIFICOS").ToString
                txt_derechos_antidumping.Text = frm.Data_Matriz.Rows(0).Item("DERECHOS_ANTIDUMPING").ToString
                txt_seguro2.Text = frm.Data_Matriz.Rows(0).Item("SEGURO2").ToString
                txt_sobretasa_tributo.Text = frm.Data_Matriz.Rows(0).Item("SOBRETASA_TRIBUTO").ToString
                txt_sobretasa_sancion.Text = frm.Data_Matriz.Rows(0).Item("SOBRETASA_SANCION").ToString
                txt_percepcion2.Text = frm.Data_Matriz.Rows(0).Item("PERCEPCION2").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoArticulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub txtcodigoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txtcodigoArticulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                'Dim codigoArticulo As String = String.Empty
                'codigoArticulo = txtcodigoArticulo.Text.Trim
                'AgregarArticuloManual(codigoArticulo)
                txt_cantidad.Focus()
            End If
        End If
    End Sub

    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            Dim clsArticuloBl As New LibCobranzas.ClsOperaciones.PART
            Dim dtDocumentoGuias As New DataTable
            dtDocumentoGuias = clsArticuloBl.Verifica_Cod_Producto(_codigoArticulo, "RS")
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txtcodigoArticulo.Text = dtDocumentoGuias.Rows(0).Item("ID").ToString
                txtdescripcionArticulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPTION").ToString
                txtunidadMedida.Text = dtDocumentoGuias.Rows(0).Item("UNIT_OF_MEASUREMENT").ToString
                If txtcodigoArticulo.Text = "SERVICIO" Then
                    txtdescripcionArticulo.ReadOnly = False
                    txtdescripcionArticulo.Select()
                Else
                    txtdescripcionArticulo.ReadOnly = True
                    'txtcentrocostodetalle.Select()
                End If

            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txtcodigoArticulo.Text = String.Empty
                txtdescripcionArticulo.Text = String.Empty
                txtunidadMedida.Text = String.Empty
                txtcodigoArticulo.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        CONTROLES(True, 0)
        CalcularTotales()
        ConfigurarGrila()
        btn_menu.Enabled = True
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        For i As Integer = 0 To Tc_principal.TabPages.Count() - 1
            Tc_principal.TabPages(i).Enabled = False
        Next
        Tc_principal.TabPages(_indice).Enabled = opcion
        Tc_principal.SelectTab(_indice)
    End Sub



    Function Valida_Ingreso_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As Boolean
        Try
            Dim CompraBl As New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = CompraBl.Get_Validacion_Ingreso_Compras(_td, _serie, _numero, _proveedor)
            If dtTipoDoc.Rows.Count > 0 Then
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Function Valida_Modificacion_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As Boolean
        Try
            Dim CompraBl As New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtTipoDoc As New DataTable
            dtTipoDoc = CompraBl.Get_Validacion_Modificacion_Compras(_td, _serie, _numero, _proveedor)
            If dtTipoDoc.Rows.Count > 0 Then
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Private Sub Calcular_Importes_Detalle_Ayuda()
        Try
            Dim nValorVta As Double
            Dim nValorUniRef As Double
            Dim nValorUnit As Double
            Dim nPrecioUnit As Double
            Dim nDsctoUnit As Double
            Dim nValorBruto As Double
            Dim nTasaIGV As Double
            Dim nMontoIgv As Double
            Dim nMontodes As Double
            Dim nMontoTotal As Double

            For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                nTasaIGV = (Val(row("PERCENT_TAX")) / 100)
                'nTasaIGV = (Val(IIf(String.IsNullOrEmpty(row("AMOUNT_TAX")), 0, row("AMOUNT_TAX"))) / 100)
                If Val(row("PRICE")) <> 0 Then  'Valor unitario
                    'Aplicando descuento
                    If row("FLAG_FREE_IGV") = "1" Then
                        'Aplicando descuento
                        nValorUnit = Val(row("PRICE"))
                        If Val(txt_valor_ref_flete.Text) <> 0 Then
                            nValorUniRef = 0
                            nDsctoUnit = nValorUnit * (IIf(String.IsNullOrEmpty(row("DISCOUNT_PER")), 0, row("DISCOUNT_PER"))) / 100
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = nValorUnit
                        nValorVta = Math.Round(nValorUnit * Val(row("QTY")), 2)
                        nMontodes = Math.Round(nDsctoUnit * Val(row("QTY")), 2)
                        nMontoIgv = 0 '(nValorUnit * nTasaIGV) * Val(row("QTY"))
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                        'txttasa.Text = 0
                    Else
                        If row("IS_VAT") = "1" Then
                            nValorUnit = Math.Round(Val(row("PRICE")) / (1 + nTasaIGV), 10)
                        Else
                            nValorUnit = Val(row("PRICE"))
                        End If

                        If Val(row("FACTOR_REFERENCE")) <> 0 And Val(row("QTY")) <> 0 Then
                            nValorUniRef = Math.Round((Val(row("FACTOR_REFERENCE")) / Val(row("QTY"))) * nValorUnit, 6)
                            nDsctoUnit = nValorUniRef * (IIf(row("DISCOUNT_PER") = "", 0, row("DISCOUNT_PER"))) / 100
                            nValorUniRef = nValorUniRef - nDsctoUnit
                            nValorUnit = nValorUniRef
                        Else
                            nValorUniRef = 0
                            nDsctoUnit = nValorUnit * (IIf(String.IsNullOrEmpty(row("DISCOUNT_PER")), 0, row("DISCOUNT_PER"))) / 100
                            nValorUnit = nValorUnit - nDsctoUnit
                        End If
                        'Precio Unitario
                        nPrecioUnit = Math.Round(nValorUnit * (1 + nTasaIGV), 10)
                        nValorVta = Math.Round(nValorUnit * Val(row("QTY")), 2)
                        nMontodes = Math.Round(nDsctoUnit * Val(row("QTY")), 2)
                        nMontoIgv = Math.Round((nValorUnit * nTasaIGV) * Val(row("QTY")), 2)
                        nMontoTotal = nValorVta + nMontoIgv
                        nValorBruto = nValorVta + nMontodes
                    End If
                    'actualizando data
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("DISCOUNT") = Format(nMontodes, "0.00")
                    row("AMOUNT_TAX") = Format(nMontoIgv, "0.00")
                    'row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
                    row("PRICE_NET") = Format(nValorVta, "0.00")
                    row("AMOUNT_TOTAL") = Format(nValorUnit, "0.00")
                    row("AMOUNT_TOTAL_NET") = Format(nMontoTotal, "0.00")
                    row("PRICE_UNIT") = Format(nPrecioUnit, "0.00")
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub txtcantidad_Leave(sender As Object, e As EventArgs) Handles txt_valor_ref_flete.Leave
        If txt_valor_ref_flete.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub


    Private Sub Ayuda_Destinos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_TIPO_DESTINO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipo de Destinos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'txtoperacion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                'lbltipooperacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                'txtFormaPago.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Clientes()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtproveedor.Text = "" Then
                Ayuda_Clientes()
            Else
                txt_invoice2.Focus()
            End If
        End If
    End Sub

    Private Sub txtFormaPago_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_FormaPago()
        End If
    End Sub

    Private Sub txtresponsable_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            Ayuda_Responsable()
        End If
    End Sub

    Private Sub txtporc_descuento_Leave(sender As Object, e As EventArgs)
        'If txtporc_descuento.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txtComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Select()
        End If
    End Sub

    Private Sub dtp_emision_ref_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_invoice.ValueChanged
        Try
            Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
            Dim dt_Tc As Double

            dt_Tc = cls_compras.get_TiposCambio_fecha_dada(dtp_fecha_invoice.Value.ToString("dd/MM/yyyy"))

            If dt_Tc > 0 Then
                txttipoCambio.Text = dt_Tc
                txttipoCambio.Text = Format(CDbl(txttipoCambio.Text), "##,##0.000")
            Else
                txttipoCambio.Text = "0.000"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttipodoc_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Ayuda_Tipo_Doc()
        'txttipodoc.Text = _tipo_de_documento
    End Sub
    Private Sub Ayuda_Tipo_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_DOCUMENT_TYPE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipos de Documentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _tipo_de_documento = frm.Data_Matriz.Rows(0).Item(0).ToString
                '                lbltipooperacion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Tipo_Doc_Anticipo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_S_S_DOCUMENT_TYPE_ANTICIPOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtproveedor.Text
            frm.Titulo = "Anticipos del Sistema"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'txttdanticipo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                'txtserieanticipo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                'txtnumeroanticipo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                'dtpfechaanticipo.Value = frm.Data_Matriz.Rows(0).Item(3).ToString
                'txtmontoanticipo.Text = Math.Round(CDbl(frm.Data_Matriz.Rows(0).Item(4).ToString), 2)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btncontabilizar_Click(sender As Object, e As EventArgs)

        If dgvCabecera.CurrentRow.Cells("ESTADO_CONTABLE").Value.ToString() = "CONTABILIZADO" Then MsgBox("El registro seleccionado, se encuentra CONTABILIZADO, no se puede Contabilizar.", MsgBoxStyle.Critical, "Aviso") : Exit Sub
        If dgvCabecera.CurrentRow.Cells("ESTADO").Value.ToString() = "ANULADO" Then MsgBox("El registro seleccionado, se encuentra ANULADO, no se puede Contabilizar.", MsgBoxStyle.Critical, "Aviso") : Exit Sub
        Dim id As Integer = Integer.Parse("0")
        Dim ff As New frm_CO_LT_IngVoucher
        ff.viene_de_compras = "si"
        ff.id_compras = "CO" & dgvCabecera.CurrentRow.Cells("ID").Value.ToString()
        ff.bol_edicion_Asiento = True
        Dim EstaDoc As String = String.Empty
        EstaDoc = "P"
        If EstaDoc = "F" Then ff.Flag_Estado_Fin = True Else ff.Flag_Estado_Fin = False
        ff.GenerarColummnaDataTableAsientoContable()
        ff.Cargar_Asiento_Editar(1, id, "CO" & dgvCabecera.CurrentRow.Cells("ID").Value.ToString(), CDate(dgvCabecera.CurrentRow.Cells("DOCUMENT_DATE").Value.ToString()).Year.ToString, CDate(dgvCabecera.CurrentRow.Cells("DOCUMENT_DATE").Value.ToString()).Month.ToString)
        'ff.Cargar_Asiento_Editar(1, id, "01", "2015", "1")
        ff.ShowDialog()
        DocumentosCompra()
    End Sub

    Private Sub dtp_emision_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_invoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim cls_compras = New ClsOperaciones.CURRENCY_TYPE
                Dim dt_Tc As Double

                dt_Tc = cls_compras.get_TiposCambio_fecha_dada(dtp_fecha_invoice.Value.ToString("dd/MM/yyyy"))

                If dt_Tc > 0 Then
                    txttipoCambio.Text = dt_Tc
                    txttipoCambio.Text = Format(CDbl(txttipoCambio.Text), "##,##0.000")
                    txt_numero_dam.Focus()
                Else
                    MsgBox("No se asigno el Tipo de Cambio para esa fecha, verifique.", MsgBoxStyle.Exclamation, "Sistemas")
                    txttipoCambio.Text = "0.000"
                    dtp_fecha_invoice.Select()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvCabecera_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabecera.CellContentDoubleClick
        Call btnConsultar_Click(sender, e)
    End Sub

    Private Sub dtp_emision_ref_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_fecha_invoice.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then dtp_vencimiento_ref.Focus()
    End Sub


    Private Sub Tool_Imprimir_Orden_Pago_Click(sender As Object, e As EventArgs) Handles Tool_Imprimir_Orden_Pago.Click
        'If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        'Dim CodigoCliente As String = String.Empty
        'Dim NumeroDoc_OrdenPago As String = String.Empty

        'CodigoCliente = dgvCabecera.CurrentRow.Cells("ID").Value.ToString
        'NumeroDoc_OrdenPago = dgvCabecera.CurrentRow.Cells("NUM_ORDER_PAGO").Value.ToString

        'Imprimir_Orden_Pago(CodigoCliente, NumeroDoc_OrdenPago)
    End Sub
    Private Sub Imprimir_Orden_Pago(ByVal customer_id As String, ByVal numerodocument As String)
        Try
            Dim dtImprimir As DataTable
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("OrdenPago")
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.Imprimir_Orden_Pago(customer_id, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Pago.rpt", dtImprimir, "", "", "usuario;" & LibComunVar.ClsVarComun.USUARIO, "numero_op;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtdescripcionArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcionArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_valor_ref_flete.Focus()
        End If
    End Sub



    Private Sub btn_add_prov_Click(sender As Object, e As EventArgs)
        'btn_menu.Enabled = False
        'Tc_principal.Enabled = False

        'txt_cod.Text = ""
        'txt_des.Text = ""
        'txt_ruc.Text = ""
        'txt_cod_pais.Text = ""
        'txt_des_pais.Text = ""
        'txt_ap_paterno.Text = ""
        'txt_ap_materno.Text = ""
        'txt_primer_nombre.Text = ""
        'txt_segundo_nombre.Text = ""
        'txt_dir.Text = ""
        'cmb_td.SelectedIndex = -1
        'cmb_tc.SelectedIndex = -1
        'Call Cargar_TipoDoc()
        'Call Cargar_TipoCompania()
        'pnl_add_proveedor.Visible = True
        'txt_cod.Focus()
    End Sub


    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADO" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub


    Private Sub cbomoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cbomoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.Focus()
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_valor_ref_flete.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_flete.Select()
        End If
    End Sub

    Private Sub btn_contabilizar_marcado_Click(sender As Object, e As EventArgs)
        Try
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvCabecera.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvCabecera.Focus()
                    Exit Sub
                End If
            End If
            dgvCabecera.Refresh()

            If MessageBox.Show("Se van a CONTABILIZAR los items marcados" & vbCrLf & "¿Desea continuar?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value And row.Cells("Estado").Value <> "ANULADO" Then
                        If Guardando_Asiento_Contable_marcado(row.Cells("ID").Value) = False Then
                            MsgBox("La compra N° " & row.Cells("ID").Value & " no se contabilizó. Verifique!!!", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Next
                DocumentosCompra()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardando_Asiento_Contable_marcado(ByVal codigo_compra As String) As Boolean
        Try
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalles As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)
            Dim asiento As New LibContabilidad.ClsOperaciones.Asiento_Contable
            Dim codigo_asiento As Integer = 0

            Dim dtDatos_Compra As DataTable
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            dtDatos_Compra = New DataTable("Datos_Compra")
            dtDatos_Compra = clsFacturaBl.Get_Datos_Compra(codigo_compra)
            If dtDatos_Compra.Rows.Count > 0 Then

                Dim fecha As DateTime = DateTime.Parse(dtDatos_Compra.Rows(0).Item("AC_FEC_VOUCHER").ToString)
                Dim ac As New LibContabilidad.ClsOperaciones.Asiento_Contable

                'ac = Nothing
                ''Ingresando Datos de la Cabecera del Asiento Contable
                cab.AC_ID = 0
                cab.AC_IDSUBDIARIO = dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString
                cab.AC_NUM_VOUCHER = ac.get_Ult_num_voucher(dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString, fecha.Year, Format(fecha.Month, "00"))
                While cab.AC_NUM_VOUCHER = ""
                    cab.AC_NUM_VOUCHER = ac.get_Ult_num_voucher(dtDatos_Compra.Rows(0).Item("AC_IDSUBDIARIO").ToString, fecha.Year, Format(fecha.Month, "00"))
                End While
                cab.AC_ANHO = fecha.Year
                cab.AC_MES = fecha.Month
                cab.AC_FEC_VOUCHER = dtDatos_Compra.Rows(0).Item("AC_FEC_VOUCHER").ToString
                cab.AC_IDMONEDA = Integer.Parse(dtDatos_Compra.Rows(0).Item("AC_IDMONEDA").ToString)
                cab.AC_DEBE = Double.Parse(dtDatos_Compra.Rows(0).Item("AC_DEBE").ToString)
                cab.AC_HABER = Double.Parse(dtDatos_Compra.Rows(0).Item("AC_HABER").ToString)
                cab.AC_ESTADO = 1
                cab.AC_GLOSA_VOU = dtDatos_Compra.Rows(0).Item("AC_GLOSA_VOU").ToString
                cab.AC_ES_INTERFACE = 0
                cab.AC_IDPLANILLA = ""
                cab.AC_RUC = dtDatos_Compra.Rows(0).Item("AC_RUC").ToString
                cab.AC_TIPO_DOC = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC").ToString
                cab.AC_SER_DOC = dtDatos_Compra.Rows(0).Item("AC_SER_DOC").ToString
                cab.AC_NUM_DOC = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC").ToString
                cab.AC_FEC_DOC = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC").ToString)
                cab.AC_FEC_DOC_VENCE = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_VENCE").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_VENCE").ToString)
                cab.AC_POR_IGV = dtDatos_Compra.Rows(0).Item("AC_POR_IGV")
                cab.AC_VAL_IGV = IIf(dtDatos_Compra.Rows(0).Item("AC_VAL_IGV").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_VAL_IGV"))
                cab.AC_TOTAL_DOC = IIf(dtDatos_Compra.Rows(0).Item("AC_TOTAL_DOC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_TOTAL_DOC"))
                cab.AC_TIPO_CAMBIO = IIf(dtDatos_Compra.Rows(0).Item("AC_TIPO_CAMBIO").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_TIPO_CAMBIO"))
                cab.AC_GLOSA_TRANSACCION = dtDatos_Compra.Rows(0).Item("AC_GLOSA_VOU").ToString
                cab.AC_DESTINO = dtDatos_Compra.Rows(0).Item("AC_DESTINO").ToString
                cab.AC_POR_ISC = IIf(dtDatos_Compra.Rows(0).Item("AC_POR_ISC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_POR_ISC"))
                cab.AC_ISC = IIf(dtDatos_Compra.Rows(0).Item("AC_ISC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_ISC"))
                cab.AC_POR_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_POR_DETRAC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_POR_DETRAC"))
                cab.AC_FEC_PLE = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_PLE").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_PLE").ToString)
                cab.AC_TIPO_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC_REF").ToString
                cab.AC_SER_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_SER_DOC_REF").ToString
                cab.AC_NUM_DOC_REF = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC_REF").ToString
                cab.AC_FEC_DOC_REF = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_REF").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_REF").ToString)
                cab.AC_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_DETRAC").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_DETRAC"))
                cab.AC_DUA = dtDatos_Compra.Rows(0).Item("AC_DUA")
                cab.AC_OP_INAFECTA = IIf(dtDatos_Compra.Rows(0).Item("AC_OP_INAFECTA").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_OP_INAFECTA"))
                cab.AC_OP_GRAVADA = IIf(dtDatos_Compra.Rows(0).Item("AC_OP_GRAVADA").ToString = String.Empty, 0, dtDatos_Compra.Rows(0).Item("AC_OP_GRAVADA"))
                cab.AC_ID_REGCOMPRA = codigo_compra

                cab.AC_TIPO_DOC_DETRAC = dtDatos_Compra.Rows(0).Item("AC_TIPO_DOC_DETRAC").ToString
                cab.AC_SER_DOC_DETRAC = "" 'dtDatos_Compra.Rows(0).Item("").ToString
                cab.AC_NUM_DOC_DETRAC = dtDatos_Compra.Rows(0).Item("AC_NUM_DOC_DETRAC").ToString
                cab.AC_FEC_DOC_DETRAC = IIf(dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_DETRAC").ToString = String.Empty, Date.Now, dtDatos_Compra.Rows(0).Item("AC_FEC_DOC_DETRAC").ToString)

                If asiento.Guardar_Asiento_Cabecera_Compras_Marcados(cab) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_act_cc_Click(sender As Object, e As EventArgs)

        Try
            Cursor = Cursors.WaitCursor
            dgvCabecera.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgvCabecera.RowCount() = 0 Then
                Cursor = Cursors.Default
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgvCabecera.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvCabecera.Focus()
                    Exit Sub
                Else
                    'pnl_act_cc.Visible = True
                    'pnlCabecera.Enabled = False
                    'btn_menu.Enabled = False
                    'txt_cod_act_cc.Text = ""
                    'txt_desc_act_cc.Text = ""
                    'txt_cod_act_cc.Focus()
                End If
            End If
            'dgvCabecera.Refresh()
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Detalles_Compra")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal.Columns.Add("SUBPARTIDA_NACIONAL_DAM", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double")) '5
            dtdetalleArticuloPrincipal.Columns.Add("PRICE", Type.GetType("System.Double")) '6
            dtdetalleArticuloPrincipal.Columns.Add("PRICE_TOTAL", Type.GetType("System.Double")) '7
            dtdetalleArticuloPrincipal.Columns.Add("AD_VALOREM2", Type.GetType("System.Double")) '8
            dtdetalleArticuloPrincipal.Columns.Add("ISC_POR", Type.GetType("System.Double")) '9
            dtdetalleArticuloPrincipal.Columns.Add("IGV_POR", Type.GetType("System.Double")) '10
            dtdetalleArticuloPrincipal.Columns.Add("IPM_POR", Type.GetType("System.Double")) '11
            dtdetalleArticuloPrincipal.Columns.Add("DERECHOS_ESPECIFICOS", Type.GetType("System.Double")) '12
            dtdetalleArticuloPrincipal.Columns.Add("DERECHOS_ANTIDUMPING", Type.GetType("System.Double")) '13
            dtdetalleArticuloPrincipal.Columns.Add("SEGURO2", Type.GetType("System.Double")) '14
            dtdetalleArticuloPrincipal.Columns.Add("SOBRETASA_TRIBUTO", Type.GetType("System.Double")) '15
            dtdetalleArticuloPrincipal.Columns.Add("SOBRETASA_SANCION", Type.GetType("System.Double")) '16
            dtdetalleArticuloPrincipal.Columns.Add("PERCEPCION2", Type.GetType("System.Double")) '17
            dtdetalleArticuloPrincipal.Columns.Add("VALOR_REF_FLETE", Type.GetType("System.Double")) '18
            dtdetalleArticuloPrincipal.Columns.Add("FLETE", Type.GetType("System.Double")) '19
            dtdetalleArticuloPrincipal.Columns.Add("SEGURO", Type.GetType("System.Double")) '20
            dtdetalleArticuloPrincipal.Columns.Add("AD_VALOREM", Type.GetType("System.Double")) '21
            dtdetalleArticuloPrincipal.Columns.Add("IGV", Type.GetType("System.Double")) '22
            dtdetalleArticuloPrincipal.Columns.Add("IPM", Type.GetType("System.Double")) '23
            dtdetalleArticuloPrincipal.Columns.Add("PERCEPCION", Type.GetType("System.Double")) '24
            dtdetalleArticuloPrincipal.Columns.Add("COMISION_AGENCIA_ADUANAS2", Type.GetType("System.Double")) '25
            dtdetalleArticuloPrincipal.Columns.Add("GASTOS_OPERATIVOS", Type.GetType("System.Double")) '26
            dtdetalleArticuloPrincipal.Columns.Add("GASTOS_ADMINISTRATIVOS", Type.GetType("System.Double")) '27
            dtdetalleArticuloPrincipal.Columns.Add("HANDLING_DESTINO", Type.GetType("System.Double")) '28
            dtdetalleArticuloPrincipal.Columns.Add("TRANSMISION_MANIFIESTO", Type.GetType("System.Double")) '29
            dtdetalleArticuloPrincipal.Columns.Add("GASTOS_OPERACIONAL_DESTINO", Type.GetType("System.Double")) '30
            dtdetalleArticuloPrincipal.Columns.Add("SEGURO3", Type.GetType("System.Double")) '31
            dtdetalleArticuloPrincipal.Columns.Add("ALMACEN", Type.GetType("System.Double")) '32
            dtdetalleArticuloPrincipal.Columns.Add("VISTOS_BUENOS", Type.GetType("System.Double")) '33
            dtdetalleArticuloPrincipal.Columns.Add("DEVOLUCION_CONTENEDOR", Type.GetType("System.Double")) '34
            dtdetalleArticuloPrincipal.Columns.Add("DESCONSOLIDACION", Type.GetType("System.Double")) '35
            dtdetalleArticuloPrincipal.Columns.Add("REPARACION_CONTENEDOR", Type.GetType("System.Double")) '36
            dtdetalleArticuloPrincipal.Columns.Add("RECTIFICACION_MANI", Type.GetType("System.Double")) '37
            dtdetalleArticuloPrincipal.Columns.Add("FLETE_MARITIMO", Type.GetType("System.Double")) '38
            dtdetalleArticuloPrincipal.Columns.Add("TRANSPORTE_TERRESTRE", Type.GetType("System.Double")) '39
            dtdetalleArticuloPrincipal.Columns.Add("TC", Type.GetType("System.Double")) '40
            dtdetalleArticuloPrincipal.Columns.Add("TRANSPORTE_TERRESTRE_SOLES", Type.GetType("System.Double")) '41
            dtdetalleArticuloPrincipal.Columns.Add("TOTAL_COSTO_AGENCIA_ADUANAS", Type.GetType("System.Double")) '42
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_INVOICE2_TOTAL", Type.GetType("System.Double")) '43
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_ADVALOREM_TOTAL", Type.GetType("System.Double")) '44
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_AGENCIA_ADUANA_TOTAL", Type.GetType("System.Double")) '45
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_TOTAL", Type.GetType("System.Double")) '46
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_UNITARIO", Type.GetType("System.Double")) '47
            dtdetalleArticuloPrincipal.Columns.Add("COSTO_UNITARIO_SOLES", Type.GetType("System.Double")) '48
            
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Gastos_varios()
        Try
            dtdetalleArticuloPrincipal_Gastos_Varios = New DataTable("Detalles_Compra_Gastos")
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("COMISION_AGENCIA_ADUANAS2", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("GASTOS_OPERATIVOS", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("GASTOS_ADMINISTRATIVOS", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("HANDLING_DESTINO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("TRANSMISION_MANIFIESTO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("GASTOS_OPERACIONAL_DESTINO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("SEGURO3", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("ALMACEN", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("VISTOS_BUENOS", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("DEVOLUCION_CONTENEDOR", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("DESCONSOLIDACION", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("REPARACION_CONTENEDOR", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("RECTIFICACION_MANI", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("FLETE_MARITIMO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("TRANSPORTE_TERRESTRE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal_Gastos_Varios.Columns.Add("TRANSPORTE_TERRESTRE_SOLES", Type.GetType("System.Double"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For i As Integer = 5 To dgvDetalle.Columns.Count - 1
                dgvDetalle.Columns(i).DefaultCellStyle.Format = "##,##0.00"
            Next
            
            dgvDetalle.Columns("ITEM").HeaderText = "Item"
            dgvDetalle.Columns("PART_ID").HeaderText = "Codigo"
            dgvDetalle.Columns("DESCRIPTION").HeaderText = "Producto"
            dgvDetalle.Columns("UNIT").HeaderText = "Unidad"
            dgvDetalle.Columns("SUBPARTIDA_NACIONAL_DAM").HeaderText = "Subpartida Nacional DAM"
            dgvDetalle.Columns("QTY").HeaderText = "Cantidad"
            dgvDetalle.Columns("PRICE").HeaderText = "Precio Unitario"
            dgvDetalle.Columns("PRICE_TOTAL").HeaderText = "Precio Total"
            dgvDetalle.Columns("AD_VALOREM2").HeaderText = "Ad-Valorem2"
            dgvDetalle.Columns("ISC_POR").HeaderText = "I.S.C."
            dgvDetalle.Columns("IGV_POR").HeaderText = "I.G.V."
            dgvDetalle.Columns("IPM_POR").HeaderText = "I.P.M."
            dgvDetalle.Columns("DERECHOS_ESPECIFICOS").HeaderText = "Derechos Especificos"
            dgvDetalle.Columns("DERECHOS_ANTIDUMPING").HeaderText = "Derechos Antidumping"
            dgvDetalle.Columns("SEGURO2").HeaderText = "Seguro2"
            dgvDetalle.Columns("SOBRETASA_TRIBUTO").HeaderText = "Sobretasa Tributo"
            dgvDetalle.Columns("SOBRETASA_SANCION").HeaderText = "Sobretasa Sanción"
            dgvDetalle.Columns("PERCEPCION2").HeaderText = "Percepción2"
            dgvDetalle.Columns("VALOR_REF_FLETE").HeaderText = "Valor Ref. Flete"
            dgvDetalle.Columns("FLETE").HeaderText = "Flete"
            dgvDetalle.Columns("SEGURO").HeaderText = "Seguro"
            dgvDetalle.Columns("AD_VALOREM").HeaderText = "Ad-Valorem"
            dgvDetalle.Columns("IGV").HeaderText = "I.G.V."
            dgvDetalle.Columns("IPM").HeaderText = "I.P.M."
            dgvDetalle.Columns("PERCEPCION").HeaderText = "Percepción"
            dgvDetalle.Columns("COMISION_AGENCIA_ADUANAS2").HeaderText = "Comisión Agencia de Aduanas 2"
            dgvDetalle.Columns("GASTOS_OPERATIVOS").HeaderText = "Gastos Operativos"
            dgvDetalle.Columns("GASTOS_ADMINISTRATIVOS").HeaderText = "Gastos Administrativos"
            dgvDetalle.Columns("HANDLING_DESTINO").HeaderText = "Handling Destino"
            dgvDetalle.Columns("TRANSMISION_MANIFIESTO").HeaderText = "Transmisión Manifiesto"
            dgvDetalle.Columns("GASTOS_OPERACIONAL_DESTINO").HeaderText = "Gastos Operacional Destino"
            dgvDetalle.Columns("SEGURO3").HeaderText = "Seguro3"
            dgvDetalle.Columns("ALMACEN").HeaderText = "Almacen"
            dgvDetalle.Columns("VISTOS_BUENOS").HeaderText = "Vistos Buenos"
            dgvDetalle.Columns("DEVOLUCION_CONTENEDOR").HeaderText = "Devolución Contenedor"
            dgvDetalle.Columns("DESCONSOLIDACION").HeaderText = "Desconsolidación"
            dgvDetalle.Columns("REPARACION_CONTENEDOR").HeaderText = "Reparación Contenedor"
            dgvDetalle.Columns("RECTIFICACION_MANI").HeaderText = "Rectificación Mani"
            dgvDetalle.Columns("FLETE_MARITIMO").HeaderText = "Flete Marítimo"
            dgvDetalle.Columns("TRANSPORTE_TERRESTRE").HeaderText = "Transporte Terrestre"
            dgvDetalle.Columns("TC").HeaderText = "T.C."
            dgvDetalle.Columns("TRANSPORTE_TERRESTRE_SOLES").HeaderText = "Transporte Terrestre Soles"
            dgvDetalle.Columns("TOTAL_COSTO_AGENCIA_ADUANAS").HeaderText = "Total Costo Agencia Aduanas"
            dgvDetalle.Columns("COSTO_INVOICE2_TOTAL").HeaderText = "Costo Invoice2"
            dgvDetalle.Columns("COSTO_ADVALOREM_TOTAL").HeaderText = "Costo Ad-Valorem"
            dgvDetalle.Columns("COSTO_AGENCIA_ADUANA_TOTAL").HeaderText = "Costo Agencia Aduanas"
            dgvDetalle.Columns("COSTO_TOTAL").HeaderText = "Costo Total"
            dgvDetalle.Columns("COSTO_UNITARIO").HeaderText = "Costo Unitario"
            dgvDetalle.Columns("COSTO_UNITARIO_SOLES").HeaderText = "Costo Unitario Soles"

            dgvDetalle.Columns("PRICE").DefaultCellStyle.Format = "##,##0.0000"
            dgvDetalle.Columns("TC").DefaultCellStyle.Format = "##,##0.000"
            dgvDetalle.Columns("COSTO_UNITARIO").DefaultCellStyle.Format = "##,##0.0000"
            dgvDetalle.Columns("COSTO_UNITARIO_SOLES").DefaultCellStyle.Format = "##,##0.0000"
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            'If Modo_Edicion = True Then
            '    btnGrabar.Enabled = False
            'End If

            'End If
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
            Tool_Imprimir_Orden_Pago.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
            Tool_Imprimir_Orden_Pago.Enabled = True
        End If
    End Sub

    Private Sub DocumentosCompra()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = CompraBl.Mostrar_Documentos_Principal_Importacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                           cboopcionesBusqueda.SelectedIndex)
            dtv = dtDocumentos.DefaultView
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                dgvCabecera.Columns(0).HeaderText = "Nro"
                dgvCabecera.Columns(1).HeaderText = "Codigo"
                dgvCabecera.Columns(2).HeaderText = "Proveedor"
                dgvCabecera.Columns(3).HeaderText = "Moneda"
                dgvCabecera.Columns(4).HeaderText = "T.C."
                dgvCabecera.Columns(5).HeaderText = "Estado"
                dgvCabecera.Columns(6).HeaderText = "Invoice"
                dgvCabecera.Columns(7).HeaderText = "Fecha Invoice"
                dgvCabecera.Columns(8).HeaderText = "Nro DAM"
                dgvCabecera.Columns(9).HeaderText = "Fecha DAM"
                
                dgvCabecera.Columns(0).Width = 90
                dgvCabecera.Columns(1).Width = 100
                dgvCabecera.Columns(2).Width = 400
                dgvCabecera.Columns(3).Width = 50
                dgvCabecera.Columns(4).Width = 50
                dgvCabecera.Columns(5).Width = 70
                dgvCabecera.Columns(6).Width = 100
                dgvCabecera.Columns(7).Width = 70
                dgvCabecera.Columns(8).Width = 150
                dgvCabecera.Columns(9).Width = 70

                dgvCabecera.Columns(4).DefaultCellStyle.Format = "N3"

                STRorden = dgvCabecera.Columns("ID").Name & "+" & dgvCabecera.Columns("VENDOR_ID").Name & "+" & dgvCabecera.Columns("RAZON_SOCIAL").Name & "+" & dgvCabecera.Columns("INVOICE").Name & "+" & dgvCabecera.Columns("NRO_DAM").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_ipm__KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor_ref_flete.KeyPress, txt_sobretasa_tributo.KeyPress, txt_sobretasa_sancion.KeyPress, txt_seguro2.KeyPress, txt_seguro.KeyPress, txt_precio_unitario.KeyPress, txt_percepcion2.KeyPress, txt_percepcion.KeyPress, txt_isc.KeyPress, txt_ipm_.KeyPress, txt_ipm.KeyPress, txt_igv_.KeyPress, txt_igv.KeyPress, txt_flete.KeyPress, txt_derechos_especificos.KeyPress, txt_derechos_antidumping.KeyPress, txt_cantidad.KeyPress, txt_ad_valorem2.KeyPress, txt_ad_valorem.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_precio_unitario.Focus()
        End If
    End Sub

    Private Sub txt_precio_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_precio_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_valor_ref_flete.Focus()
        End If
    End Sub

    Private Sub txt_flete_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_flete.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_seguro.Select()
        End If
    End Sub

    Private Sub txt_flete_Leave(sender As Object, e As EventArgs) Handles txt_flete.Leave
        If txt_flete.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txt_seguro_Leave(sender As Object, e As EventArgs) Handles txt_seguro.Leave
        If txt_seguro.Text = String.Empty Then Exit Sub
        Calcular_Importes_Detalle()
    End Sub

    Private Sub txt_cantidad_Leave(sender As Object, e As EventArgs) Handles txt_cantidad.Leave
        If txt_cantidad.Text = String.Empty Then Exit Sub
        If txt_precio_unitario.Text = String.Empty Then Exit Sub
        Calcular_Precio_Total()
    End Sub

    Private Sub txt_precio_unitario_Leave(sender As Object, e As EventArgs) Handles txt_precio_unitario.Leave
        If txt_precio_unitario.Text = String.Empty Then Exit Sub
        If txt_cantidad.Text = String.Empty Then Exit Sub
        Calcular_Precio_Total()
    End Sub

    Private Sub btnAceptar2_Click(sender As Object, e As EventArgs) Handles btnAceptar2.Click
        Try
            If dtdetalleArticuloPrincipal_Gastos_Varios.Rows.Count > 0 Then
                For Each row As DataRow In dtdetalleArticuloPrincipal_Gastos_Varios.Rows
                    dtdetalleArticuloPrincipal_Gastos_Varios.BeginInit()
                    row("COMISION_AGENCIA_ADUANAS2") = IIf(txt_1.Text = "", 0.0, txt_1.Text)
                    row("GASTOS_OPERATIVOS") = IIf(txt_2.Text = "", 0.0, txt_2.Text)
                    row("GASTOS_ADMINISTRATIVOS") = IIf(txt_3.Text = "", 0.0, txt_3.Text)
                    row("HANDLING_DESTINO") = IIf(txt_4.Text = "", 0.0, txt_4.Text)
                    row("TRANSMISION_MANIFIESTO") = IIf(txt_5.Text = "", 0.0, txt_5.Text)
                    row("GASTOS_OPERACIONAL_DESTINO") = IIf(txt_6.Text = "", 0.0, txt_6.Text)
                    row("SEGURO3") = IIf(txt_7.Text = "", 0.0, txt_7.Text)
                    row("ALMACEN") = IIf(txt_8.Text = "", 0.0, txt_8.Text)
                    row("VISTOS_BUENOS") = IIf(txt_9.Text = "", 0.0, txt_9.Text)
                    row("DEVOLUCION_CONTENEDOR") = IIf(txt_10.Text = "", 0.0, txt_10.Text)
                    row("DESCONSOLIDACION") = IIf(txt_11.Text = "", 0.0, txt_11.Text)
                    row("REPARACION_CONTENEDOR") = IIf(txt_12.Text = "", 0.0, txt_12.Text)
                    row("RECTIFICACION_MANI") = IIf(txt_13.Text = "", 0.0, txt_13.Text)
                    row("FLETE_MARITIMO") = IIf(txt_14.Text = "", 0.0, txt_14.Text)
                    row("TRANSPORTE_TERRESTRE") = IIf(txt_15.Text = "", 0.0, txt_15.Text)
                    dtdetalleArticuloPrincipal_Gastos_Varios.EndInit()
                    dtdetalleArticuloPrincipal_Gastos_Varios.AcceptChanges()
                Next
                btn_cancel2.PerformClick()

            Else
                Dim row As DataRow = dtdetalleArticuloPrincipal_Gastos_Varios.NewRow

                row("COMISION_AGENCIA_ADUANAS2") = IIf(txt_1.Text = "", 0.0, txt_1.Text)
                row("GASTOS_OPERATIVOS") = IIf(txt_2.Text = "", 0.0, txt_2.Text)
                row("GASTOS_ADMINISTRATIVOS") = IIf(txt_3.Text = "", 0.0, txt_3.Text)
                row("HANDLING_DESTINO") = IIf(txt_4.Text = "", 0.0, txt_4.Text)
                row("TRANSMISION_MANIFIESTO") = IIf(txt_5.Text = "", 0.0, txt_5.Text)
                row("GASTOS_OPERACIONAL_DESTINO") = IIf(txt_6.Text = "", 0.0, txt_6.Text)
                row("SEGURO3") = IIf(txt_7.Text = "", 0.0, txt_7.Text)
                row("ALMACEN") = IIf(txt_8.Text = "", 0.0, txt_8.Text)
                row("VISTOS_BUENOS") = IIf(txt_9.Text = "", 0.0, txt_9.Text)
                row("DEVOLUCION_CONTENEDOR") = IIf(txt_10.Text = "", 0.0, txt_10.Text)
                row("DESCONSOLIDACION") = IIf(txt_11.Text = "", 0.0, txt_11.Text)
                row("REPARACION_CONTENEDOR") = IIf(txt_12.Text = "", 0.0, txt_12.Text)
                row("RECTIFICACION_MANI") = IIf(txt_13.Text = "", 0.0, txt_13.Text)
                row("FLETE_MARITIMO") = IIf(txt_14.Text = "", 0.0, txt_14.Text)
                row("TRANSPORTE_TERRESTRE") = IIf(txt_15.Text = "", 0.0, txt_15.Text)
                dtdetalleArticuloPrincipal_Gastos_Varios.Rows.Add(row)
                dtdetalleArticuloPrincipal_Gastos_Varios.AcceptChanges()
                btn_cancel2.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calcular_Totales()
        Try
            Dim i As Integer = 0
            Dim COMISION_AGENCIA_ADUANAS2 As Double = 0.0
            Dim GASTOS_OPERATIVOS As Double = 0.0
            Dim GASTOS_ADMINISTRATIVOS As Double = 0.0
            Dim HANDLING_DESTINO As Double = 0.0
            Dim TRANSMISION_MANIFIESTO As Double = 0.0
            Dim GASTOS_OPERACIONAL_DESTINO As Double = 0.0
            Dim SEGURO3 As Double = 0.0
            Dim ALMACEN As Double = 0.0
            Dim VISTOS_BUENOS As Double = 0.0
            Dim DEVOLUCION_CONTENEDOR As Double = 0.0
            Dim DESCONSOLIDACION As Double = 0.0
            Dim REPARACION_CONTENEDOR As Double = 0.0
            Dim RECTIFICACION_MANI As Double = 0.0
            Dim FLETE_MARITIMO As Double = 0.0
            Dim TRANSPORTE_TERRESTRE As Double = 0.0
            Dim TRANSPORTE_TERRESTRE_SOLES As Double = 0.0
            Dim PRECIO_TOTAL As Double = 0.0
            Dim PRECIO_TOTAL_FILA As Double = 0.0

            For Each row As DataRow In dtdetalleArticuloPrincipal_Gastos_Varios.Rows
                COMISION_AGENCIA_ADUANAS2 = row("COMISION_AGENCIA_ADUANAS2")
                GASTOS_OPERATIVOS = row("GASTOS_OPERATIVOS")
                GASTOS_ADMINISTRATIVOS = row("GASTOS_ADMINISTRATIVOS")
                HANDLING_DESTINO = row("HANDLING_DESTINO")
                TRANSMISION_MANIFIESTO = row("TRANSMISION_MANIFIESTO")
                GASTOS_OPERACIONAL_DESTINO = row("GASTOS_OPERACIONAL_DESTINO")
                SEGURO3 = row("SEGURO3")
                ALMACEN = row("ALMACEN")
                VISTOS_BUENOS = row("VISTOS_BUENOS")
                DEVOLUCION_CONTENEDOR = row("DEVOLUCION_CONTENEDOR")
                DESCONSOLIDACION = row("DESCONSOLIDACION")
                REPARACION_CONTENEDOR = row("REPARACION_CONTENEDOR")
                RECTIFICACION_MANI = row("RECTIFICACION_MANI")
                FLETE_MARITIMO = row("FLETE_MARITIMO")
                TRANSPORTE_TERRESTRE = row("TRANSPORTE_TERRESTRE")
            Next

            PRECIO_TOTAL = dtdetalleArticuloPrincipal.Compute("sum (PRICE_TOTAL) ", "")

            For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                dtdetalleArticuloPrincipal.BeginInit()
                PRECIO_TOTAL_FILA = row("PRICE_TOTAL")
                row("COMISION_AGENCIA_ADUANAS2") = (COMISION_AGENCIA_ADUANAS2 / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("GASTOS_OPERATIVOS") = (GASTOS_OPERATIVOS / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("GASTOS_ADMINISTRATIVOS") = (GASTOS_ADMINISTRATIVOS / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("HANDLING_DESTINO") = (HANDLING_DESTINO / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("TRANSMISION_MANIFIESTO") = (TRANSMISION_MANIFIESTO / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("GASTOS_OPERACIONAL_DESTINO") = (GASTOS_OPERACIONAL_DESTINO / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("SEGURO3") = (SEGURO3 / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("ALMACEN") = (ALMACEN / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("VISTOS_BUENOS") = (VISTOS_BUENOS / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("DEVOLUCION_CONTENEDOR") = (DEVOLUCION_CONTENEDOR / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("DESCONSOLIDACION") = (DESCONSOLIDACION / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("REPARACION_CONTENEDOR") = (REPARACION_CONTENEDOR / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("RECTIFICACION_MANI") = (RECTIFICACION_MANI / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("FLETE_MARITIMO") = (FLETE_MARITIMO / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("TRANSPORTE_TERRESTRE") = (TRANSPORTE_TERRESTRE / PRECIO_TOTAL) * PRECIO_TOTAL_FILA
                row("TOTAL_COSTO_AGENCIA_ADUANAS") = row("COMISION_AGENCIA_ADUANAS2") + row("GASTOS_OPERATIVOS") + row("GASTOS_ADMINISTRATIVOS") + row("HANDLING_DESTINO") + row("TRANSMISION_MANIFIESTO") + row("GASTOS_OPERACIONAL_DESTINO") + row("SEGURO3") + row("ALMACEN") + row("VISTOS_BUENOS") + row("DEVOLUCION_CONTENEDOR") + row("DESCONSOLIDACION") + row("REPARACION_CONTENEDOR") + row("RECTIFICACION_MANI") + row("FLETE_MARITIMO") + row("TRANSPORTE_TERRESTRE")
                row("COSTO_INVOICE2_TOTAL") = row("PRICE_TOTAL")
                row("COSTO_ADVALOREM_TOTAL") = row("AD_VALOREM")
                row("COSTO_AGENCIA_ADUANA_TOTAL") = row("TOTAL_COSTO_AGENCIA_ADUANAS")
                row("COSTO_TOTAL") = row("COSTO_INVOICE2_TOTAL") + row("COSTO_ADVALOREM_TOTAL") + row("COSTO_AGENCIA_ADUANA_TOTAL")
                row("COSTO_UNITARIO") = row("COSTO_TOTAL") / row("QTY")
                row("COSTO_UNITARIO_SOLES") = row("COSTO_UNITARIO") * CDbl(txttipoCambio.Text)
                dtdetalleArticuloPrincipal.EndInit()
                dtdetalleArticuloPrincipal.AcceptChanges()

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_cancel2_Click(sender As Object, e As EventArgs) Handles btn_cancel2.Click
        CONTROLES(True, 0)
        Calcular_Totales()
        ConfigurarGrila()
        btn_menu.Enabled = True
    End Sub

    Private Sub btn_agregar_gastos_Click(sender As Object, e As EventArgs) Handles btn_agregar_gastos.Click
        Try
            If dgvDetalle.RowCount() = 0 Then Exit Sub
            If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
            If gbcabecera.Enabled = True Then
                If ValidacionesGenerales() = False Then Exit Sub
                gbcabecera.Enabled = False
            End If

            CONTROLES(True, 2)
            blank()
            btn_menu.Enabled = False
            For Each row As DataRow In dtdetalleArticuloPrincipal_Gastos_Varios.Rows
                txt_1.Text = row("COMISION_AGENCIA_ADUANAS2")
                txt_2.Text = row("GASTOS_OPERATIVOS")
                txt_3.Text = row("GASTOS_ADMINISTRATIVOS")
                txt_4.Text = row("HANDLING_DESTINO")
                txt_5.Text = row("TRANSMISION_MANIFIESTO")
                txt_6.Text = row("GASTOS_OPERACIONAL_DESTINO")
                txt_7.Text = row("SEGURO3")
                txt_8.Text = row("ALMACEN")
                txt_9.Text = row("VISTOS_BUENOS")
                txt_10.Text = row("DEVOLUCION_CONTENEDOR")
                txt_11.Text = row("DESCONSOLIDACION")
                txt_12.Text = row("REPARACION_CONTENEDOR")
                txt_13.Text = row("RECTIFICACION_MANI")
                txt_14.Text = row("FLETE_MARITIMO")
                txt_15.Text = row("TRANSPORTE_TERRESTRE")
            Next
            txt_1.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_invoice2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_invoice2.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fecha_invoice.Focus()
        End If
    End Sub

    Private Sub txt_numero_dam_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_dam.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_fecha_dam.Focus()
        End If
    End Sub

    Private Sub dtp_fecha_dam_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_dam.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbomoneda.Focus()
        End If
    End Sub
End Class