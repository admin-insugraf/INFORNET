Imports System.Windows.Forms
Imports LibComunVar
Imports System.Drawing
Imports LibContabilidad
Imports LibVentas
Imports LibCobranzas
Imports System.Globalization
Public Class Frm_Registro_Licitaciones
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim Modo_consultar As Boolean = False
    Dim flag_Edicion As Boolean = False
    Dim CompraCabENT As ClsEntidades.LICITACION
    Dim CompraDetENT As ClsEntidades.LICITACION_LINE
    Dim ListaDetalles As List(Of ClsEntidades.LICITACION_LINE)
    Dim dtTable As DataTable
    Dim carteraBE As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY
    Dim CarteraBl As LibContabilidad.ClsOperaciones.Asiento_Contable

    Dim CompraBl As ClsOperaciones.PURCHASE_FACT_SUPPLIER

    Dim CORRELATIVOBL As ClsTransacciones.PURCHASE_FACT_SUPPLIER
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim LibData As LibConexion.ClsData
    Dim dtdetalleArticuloPrincipal As DataTable
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
    Dim item_detalle As Integer
    Private Sub Frm_Registro_Licitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub Limpiar()
        Call Limpiar_Controles(gbcabecera)
        Call Limpiar_Controles(gbDetalles)
        Call Limpiar_Controles(GroupBox7)
        chkSinIGV.Checked = False
        txtBruto.Text = "0.00"
        txtDescuentos.Text = "0.00"
        txtIgv.Text = "0.00"
        txtvalorVenta.Text = "0.00"
        txtPrecioVenta.Text = "0.00"
        dgvDetalle.DataSource = Nothing
        dtp_emision.Value = Date.Now
    End Sub

    Private Sub Nuevo()
        Try
            flag_Edicion = False
            Limpiar()
            'ConfigurarGrila()
            Modo_consultar = False
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            gbcabecera.Enabled = True
            gbDetalles.Enabled = False
            If Modo_consultar = False Then
                gbOpciones.Enabled = True
            End If
            txt_num_licitacion.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        'Dim Correlativo As String = String.Empty
        'Try
        '    CORRELATIVOBL = New ClsTransacciones.PURCHASE_FACT_SUPPLIER
        '    CORRELATIVOBL.Get_NumeroCorrelativoCompra(dtpemision.Value.Year & Format(dtpemision.Value.Month, "00"))
        '    If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
        '        Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", 1)
        '    Else
        '        Correlativo = dtpemision.Value.Year & Format(dtpemision.Value.Month, "00") & String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo))
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Return Correlativo
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_consultar = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _id As Integer = 0
        _id = CInt(dgvCabecera.CurrentRow.Cells("ID").Value)
        If Modo_consultar = True Then
            txt_num_licitacion.Text = dgvCabecera.CurrentRow.Cells("NUMERO_LICITACION").Value
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("ID").Value
            txt_num_entregas.Text = dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value
            dtp_emision.Value = dgvCabecera.CurrentRow.Cells("FECHA").Value
            txt_observaciones.Text = dgvCabecera.CurrentRow.Cells("OBS").Value
            chkSinIGV.Checked = IIf(dgvCabecera.CurrentRow.Cells("FLAG_IGV").Value = 1, False, True)
        End If
        Try
            ''cabecera
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtdetalle_licitacion As New DataTable
            dtdetalle_licitacion = CompraBl.Modo_Edicion_Licitacion(_id)
            If dtdetalle_licitacion.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dgvDetalle.DataSource = dtdetalle_licitacion
                dtdetalleArticuloPrincipal = dtdetalle_licitacion
                Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function get_MostrarDescripcion(ByVal cadena As String) As String
        'Try
        '    dtTable = New DataTable
        '    LibData = New LibConexion.ClsData
        '    Dim description As String = String.Empty
        '    dtTable = LibData.Run_Query_DataTable(cadena)
        '    LibData.Dispose()
        '    description = dtTable.Rows(0).Item(0).ToString()
        '    Return description
        'Catch ex As Exception
        'End Try
    End Function

    Private Sub Guardar_Licitacion()
        Try
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            CompraCabENT = New ClsEntidades.LICITACION
            ListaDetalles = New List(Of ClsEntidades.LICITACION_LINE)

            If Modo_consultar = True Then
                CompraCabENT.ID_CABECERA = CInt(txtcodigo.Text)
            Else
                CompraCabENT.ID_CABECERA = 0
            End If
            With CompraCabENT
                .NUMERO_LICITACION = txt_num_licitacion.Text.Trim
                .FECHA = dtp_emision.Value.ToString("dd/MM/yyyy")
                .NUMERO_ENTREGAS = CInt(txt_num_entregas.Text)
                .OBS = txt_observaciones.Text.Trim
                .USUARIO = LibComunVar.ClsVarComun.USUARIO
                .TERMINAL = Environment.MachineName
            End With
            
            If CompraBl.Guardar_Licitacion(CompraCabENT, dtdetalleArticuloPrincipal, CInt(txt_num_entregas.Text), IIf(chkSinIGV.Checked, 0, 1)) Then
                If Modo_consultar = True Then
                    MsgBox("Licitación Modificado Correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Licitación Generado Correctamente.", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalle.Rows.Count() = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            If ValidacionesGenerales() = False Then Exit Sub
            For Each row As DataRow In dtdetalleArticuloPrincipal.Select("CANTIDAD_CLIENTE=0 OR PRECIO=0", "")
                MessageBox.Show("Falta ingresar el precio y/o cantidad a los detalles.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Next
        End If
        If MessageBox.Show("Se va a registrar la  Licitación" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Guardar_Licitacion()
            btnCancelar_Click(sender, e)
            DocumentosCompra()
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
            Dim _id As String = String.Empty
            _id = dgvCabecera.CurrentRow.Cells("ID").Value
            estadoInicial = dgvCabecera.CurrentRow.Cells("ESTADO").Value
            If estadoInicial = "ANULADO" Then
                MsgBox("El documento ya se encuentra anulado.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If estadoInicial <> "ANULADO" Then
                If MessageBox.Show("Se va a anular la Licitación" & vbCrLf & "¿Desea continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If CompraBl.Anular_Licitacion(_id) Then
                        MsgBox("Licitación anulado Correctamente.", MsgBoxStyle.Information)
                    End If
                End If
                DocumentosCompra()
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
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Nuevos Soles"
            Else
                STRmontotexto = UCase(NUMEROLETRAS(Math.Abs(_Monto))) & "   Dólares Americanos"
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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        Dim _Id As String = String.Empty
        Dim _Monto As Double = 0.0
        Dim _Moneda As String = String.Empty
        _Id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Monto = IIf(String.IsNullOrEmpty(dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value.ToString), 0, dgvCabecera.Item(22, dgvCabecera.CurrentRow.Index).Value)
        _Moneda = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
        imprimir_Compra(_Id, _Monto, IIf(_Moneda = "MN", "Nuevos Soles", "Dólares Americanos"))
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        'DocumentosCompra()
    End Sub





    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try

            If txt_num_licitacion.Text = String.Empty Then
                MsgBox("Debe ingresar un Número de Licitación.", MsgBoxStyle.Critical)
                estado = False
                txt_num_licitacion.Focus()
                Exit Try
            End If

            If dgvDetalle.Rows.Count = 0 Then
                MsgBox("No se ah registrado nigun detalle de la Licitación.", MsgBoxStyle.Critical)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function



    Public Sub blank()
        'txtcodigoArticulo.Text = ""
        'txtdescripcionArticulo.Text = ""
        'txtunidadMedida.Text = ""
        'txtunidadMedRef.Text = ""
        'txtcantidad.Text = ""
        'txtcantidadref.Text = ""
        'txtGlosa.Text = ""
        'txtporc_descuento.Text = "0"
        'txtValorunitario.Text = "0"
        'txtvalorventaref.Text = "0"
        'txtvalorventaunit.Text = "0"
        'txtpreciounitario.Text = "0"
        'txtvalorbruto.Text = "0"
        'txtdescuento.Text = "0"
        'txtvalorvent.Text = "0"
        'txt_igv.Text = "0"
        'txttotalneto.Text = "0"
        'txtobservaciones.Text = ""
        'txtcentroCosto.Text = ""
        'txtarea.Text = ""
        'txtproyecto.Text = ""
        'chk_libre.Checked = False
        'chkigv.Checked = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Call Limpiar_Controles(GroupBox7)
        txt_cod_articulo.Focus()
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


    Private Sub Mostrar_Totales()
        Try
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                txtDescuentos.Text = Format(0, "0.00")
                txtvalorVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (VALOR_VENTA) ", ""), "0.00")
                txtIgv.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (IGV_ART) ", ""), "0.00")
                txtPrecioVenta.Text = Format(dtdetalleArticuloPrincipal.Compute("sum (IMPORTE) ", ""), "0.00")
                txtBruto.Text = Format(Val(txtvalorVenta.Text) + Val(txtDescuentos.Text), "0.00")

                txtDescuentos.Text = Format(Double.Parse(txtDescuentos.Text), "##,##0.00")
                txtvalorVenta.Text = Format(Double.Parse(txtvalorVenta.Text), "##,##0.00")
                txtIgv.Text = Format(Double.Parse(txtIgv.Text), "##,##0.00")
                txtPrecioVenta.Text = Format(Double.Parse(txtPrecioVenta.Text), "##,##0.00")
                txtBruto.Text = Format(Double.Parse(txtBruto.Text), "##,##0.00")
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
            Dim cantidad_por_cliente As Double
            'For Each row As DataRow In dtdetalleArticuloPrincipal.Select("PART_ID='" & txt_cod_articulo.Text.Trim & "'")
            If txt_cantidad_articulo.Text <> "" Then
                If CDbl(txt_cantidad_articulo.Text) > 0 Then
                    cantidad_por_cliente = Format(dtdetalleArticuloPrincipal.Compute("sum (CANTIDAD_CLIENTE) ", "PART_ID='" & txt_cod_articulo.Text.Trim & "'"), "0.00")
                    txt_saldo_registro.Text = Format(CDbl(txt_cantidad_articulo.Text) - cantidad_por_cliente, "0.00")
                    txt_saldo_registro.Text = Format(Double.Parse(txt_saldo_registro.Text), "##,##0.00")
                End If
            End If
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calcular_Totales()
        Try
            Dim clsIgvArticuloBL As LibVentas.ClsTransacciones.clsPedidos
            Dim dtIgvArticulo As DataTable
            Dim i As Integer = 0
            Dim total As Double = 0.0
            Dim totaldesc1 As Double = 0.0
            Dim totaldesc2 As Double = 0.0
            Dim TasaIgv As Double = 0.0
            Dim Monto As Double = 0.0
            Dim por_TasaIgv As Double = 0.0
            Dim Igv As Double = 0.0

            If dgvDetalle.RowCount > 0 Then
                'Datos del Sistema Parametros Generales
                clsIgvArticuloBL = New LibVentas.ClsTransacciones.clsPedidos
                dtIgvArticulo = New DataTable("IGV_SISTEMA")
                por_TasaIgv = 0.0
                Igv = 0.0
                dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvsSistema()
                por_TasaIgv = CDbl(dtIgvArticulo.Rows(0).Item("AMOUNT_TAX"))
                'obteniendo Datos del Articulo
                For Each row As DataRow In dtdetalleArticuloPrincipal.Rows
                    'VERIFICA SI EL ARTICULO ESTA SUJETO A IGV
                    clsIgvArticuloBL = New LibVentas.ClsTransacciones.clsPedidos
                    dtIgvArticulo = New DataTable("Fl_igv")
                    dtIgvArticulo = clsIgvArticuloBL.Get_DatosIgvArticulo(row("PART_ID").ToString())
                    If dtIgvArticulo.Rows.Count() <> 0 Then
                        If chkSinIGV.Checked = False Then
                            'SI EL PRECIO SI INCLUYE IGV
                            Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                            TasaIgv = 0.0
                            TasaIgv = por_TasaIgv / 100
                            Monto = 0.0
                            Monto = CDbl(row("PRECIO")) + (CDbl(row("PRECIO")) * (CDbl(Igv) / 100))
                            If chkSinIGV.Checked = False Then
                                Monto = Monto / (1 + (Igv / 100))
                            End If
                            If chkSinIGV.Checked Then
                                Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                            Else
                                Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                            End If
                            dtdetalleArticuloPrincipal.BeginInit()
                            row("PRECIO_SIN_IGV") = CDbl(Monto)
                            row("PRECIO_CON_IGV") = row("PRECIO")
                            row("VALOR_VENTA") = CDbl(row("CANTIDAD_CLIENTE") * row("PRECIO_SIN_IGV"))
                            row("IGV_ART") = CDbl(row("CANTIDAD_CLIENTE") * row("PRECIO_SIN_IGV") * TasaIgv)
                            row("IMPORTE") = CDbl(row("PRECIO_CON_IGV") * row("CANTIDAD_CLIENTE"))
                            dtdetalleArticuloPrincipal.EndInit()
                            dtdetalleArticuloPrincipal.AcceptChanges()
                        Else
                            'SI EL ARTICULO NO INCLUYE IGV
                            Igv = CDbl(dtIgvArticulo.Rows(0).Item("VAT_POR"))
                            TasaIgv = 0.0
                            TasaIgv = por_TasaIgv / 100
                            Monto = 0.0
                            Monto = CDbl(row("PRECIO"))
                            If chkSinIGV.Checked = False Then
                                Monto = Monto / (1 + (Igv / 100))
                            End If
                            If chkSinIGV.Checked Then
                                Monto = Val(Format(Monto * (1 + TasaIgv), "0.000000"))
                            Else
                                Monto = Val(Format(Monto / (1 + TasaIgv), "0.000000"))
                            End If
                            dtdetalleArticuloPrincipal.BeginInit()
                            row("PRECIO_CON_IGV") = CDbl(Monto)
                            row("PRECIO_SIN_IGV") = row("PRECIO")
                            row("VALOR_VENTA") = CDbl(row("CANTIDAD_CLIENTE") * row("PRECIO_SIN_IGV"))
                            row("IGV_ART") = CDbl(row("CANTIDAD_CLIENTE") * row("PRECIO_SIN_IGV") * TasaIgv)
                            row("IMPORTE") = CDbl(row("PRECIO_CON_IGV") * row("CANTIDAD_CLIENTE"))
                            dtdetalleArticuloPrincipal.EndInit()
                            dtdetalleArticuloPrincipal.AcceptChanges()
                        End If
                    End If
                Next
                Mostrar_Totales()
            Else
                txtBruto.Text = "0.00"
                txtDescuentos.Text = "0.00"
                txtvalorVenta.Text = "0.00"
                txtIgv.Text = "0.00"
                txtPrecioVenta.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        'Try
        '    If dgvDetalle.RowCount() = 0 Then Exit Sub
        '    If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        '    If gbcabecera.Enabled = True Then
        '        If ValidacionesGenerales() = False Then Exit Sub
        '        gbcabecera.Enabled = False
        '    End If

        '    _Flag_edicion = True
        '    _Codigo_Ini = String.Empty
        '    _Codigo_Ini = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
        '    CONTROLES(True, 1)
        '    blank()
        '    btn_menu.Enabled = False
        '    For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
        '        txtcodigoArticulo.Text = row("PART_ID")
        '        txtdescripcionArticulo.Text = row("DESCRIPTION")
        '        txtunidadMedida.Text = row("UNIT")
        '        txtunidadMedRef.Text = row("UNIT_REFERENCE")
        '        txtcantidad.Text = CDbl(row("QTY"))
        '        txtcantidadref.Text = IIf(row("FACTOR_REFERENCE").ToString = "", 0, row("FACTOR_REFERENCE"))
        '        txtValorunitario.Text = CDbl(row("PRICE"))
        '        txtporc_descuento.Text = row("DISCOUNT_PER")
        '        txtdescuento.Text = row("DISCOUNT")
        '        txt_igv.Text = row("AMOUNT_TAX")
        '        If txtoperacion.Text = "01" Then
        '            txttasa.Text = "18"
        '            txttasa.Enabled = False
        '        ElseIf txtoperacion.Text = "02" Then
        '            txttasa.Enabled = False
        '        ElseIf txtoperacion.Text = "03" Then
        '            txttasa.Enabled = True
        '        End If
        '        txttasa.Text = row("PERCENT_TAX")
        '        txtvalorvent.Text = CDbl(row("PRICE_NET"))
        '        txtvalorventaunit.Text = row("AMOUNT_TOTAL")
        '        txttotalneto.Text = row("AMOUNT_TOTAL_NET")
        '        txtobservaciones.Text = row("COMMENT1")
        '        txtGlosa.Text = row("TEXT_COMMENT")
        '        If String.IsNullOrEmpty(row("IS_VAT").ToString) Then
        '            chkigv.Checked = False
        '        Else
        '            If row("IS_VAT") = "1" Then
        '                chkigv.Checked = True
        '            Else
        '                chkigv.Checked = False
        '            End If
        '        End If
        '        If String.IsNullOrEmpty(row("FLAG_FREE_IGV").ToString) Then
        '            chk_libre.Checked = False
        '        Else
        '            If row("FLAG_FREE_IGV") = "1" Then
        '                chk_libre.Checked = True
        '            Else
        '                chk_libre.Checked = False
        '            End If
        '        End If
        '        txtpreciounitario.Text = row("PRICE_UNIT")
        '        txtcentroCosto.Text = row("CCOST_ID")
        '        txtproyecto.Text = ""
        '        If txtcantidadref.Text <> 0 Then
        '            txtvalorventaref.Text = txtdescuento.Text
        '        Else
        '            txtvalorventaref.Text = 0
        '        End If
        '        txtvalorbruto.Text = Format(Val(txtdescuento.Text) + Val(txtvalorVenta.Text), "0.00")
        '        If String.IsNullOrEmpty(row("ORDEN_COMPRA").ToString) Then
        '            txtcodigoArticulo.Enabled = True
        '            txtValorunitario.Enabled = True
        '            txtcodigoArticulo.Select()
        '        Else
        '            txtcodigoArticulo.Enabled = False
        '            txtValorunitario.Enabled = False
        '            txtcantidad.Select()
        '        End If
        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
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


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosCompra()
        End If
    End Sub

    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Calcular_Importes_Detalle()
        'Try
        '    Dim nValorVta As Double
        '    Dim nValorUniRef As Double
        '    Dim nValorUnit As Double
        '    Dim nPrecioUnit As Double
        '    Dim nDsctoUnit As Double
        '    Dim nValorBruto As Double
        '    Dim nTasaIGV As Double
        '    Dim nMontoIgv As Double
        '    Dim nMontodes As Double
        '    Dim nMontoTotal As Double
        '    txttasa.Text = 18
        '    nTasaIGV = (Val(txttasa.Text) / 100)
        '    If Val(txtValorunitario.Text) <> 0 Then  'Valor unitario
        '        If chk_libre.Checked Then
        '            'Aplicando descuento
        '            nValorUnit = Val(txtValorunitario.Text)
        '            If Val(txtcantidad.Text) <> 0 Then
        '                nValorUniRef = 0
        '                nDsctoUnit = nValorUnit * (IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)) / 100
        '                nValorUnit = nValorUnit - nDsctoUnit
        '            End If
        '            'Precio Unitario
        '            nPrecioUnit = nValorUnit
        '            nValorVta = nValorUnit * Val(txtcantidad.Text)
        '            nMontodes = nDsctoUnit * Val(txtcantidad.Text)
        '            nMontoIgv = 0
        '            nMontoTotal = nValorVta + nMontoIgv
        '            nValorBruto = nValorVta + nMontodes
        '            txttasa.Text = 0
        '        Else
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
        '        End If
        '    End If
        '    txtvalorventaref.Text = Format(nValorUniRef, "0.00")
        '    txtvalorventaunit.Text = Format(nValorUnit, "0.00")
        '    txtpreciounitario.Text = Format(nPrecioUnit, "0.00")
        '    txtvalorbruto.Text = Format(nValorBruto, "0.00")
        '    txtdescuento.Text = Format(nMontodes, "0.00")
        '    txtvalorvent.Text = Format(nValorVta, "0.00")
        '    txt_igv.Text = Format(nMontoIgv, "0.00")
        '    txttotalneto.Text = Format(nMontoTotal, "0.00")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        'Try
        '    If ValidacionesGeneralesArticulo() = False Then Exit Sub
        '    If _Flag_edicion = False Then
        '        Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
        '        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
        '            row("ITEM") = CInt(dtdetalleArticuloPrincipal.Rows(dtdetalleArticuloPrincipal.Rows.Count - 1).Item("item").ToString) + 1 'dtdetalleArticuloPrincipal.Rows.Count() + 1
        '        Else
        '            row("ITEM") = 1
        '        End If
        '        row("PART_ID") = txtcodigoArticulo.Text
        '        row("DESCRIPTION") = txtdescripcionArticulo.Text
        '        row("UNIT") = txtunidadMedida.Text
        '        row("UNIT_REFERENCE") = txtunidadMedRef.Text
        '        row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
        '        row("FACTOR_REFERENCE") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
        '        row("PRICE") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
        '        row("DISCOUNT_PER") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
        '        row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
        '        row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
        '        row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
        '        row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
        '        row("AMOUNT_TOTAL") = IIf(txtvalorventaunit.Text = "", 0, txtvalorventaunit.Text)
        '        row("AMOUNT_TOTAL_NET") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
        '        row("COMMENT1") = txtobservaciones.Text
        '        row("TEXT_COMMENT") = txtGlosa.Text
        '        row("IS_VAT") = IIf(chkigv.Checked = True, "1", "0")
        '        row("PRICE_UNIT") = IIf(txtpreciounitario.Text = "", 0.0, txtpreciounitario.Text)
        '        row("CCOST_ID") = txtcentroCosto.Text
        '        row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
        '        dtdetalleArticuloPrincipal.Rows.Add(row)
        '        dtdetalleArticuloPrincipal.AcceptChanges()
        '        blank()
        '        txtcodigoArticulo.Select()
        '    Else
        '        For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & _Codigo_Ini)
        '            dtdetalleArticuloPrincipal.BeginInit()
        '            row("PART_ID") = txtcodigoArticulo.Text
        '            row("DESCRIPTION") = txtdescripcionArticulo.Text
        '            row("UNIT") = txtunidadMedida.Text
        '            row("UNIT_REFERENCE") = txtunidadMedRef.Text
        '            row("QTY") = IIf(txtcantidad.Text = "", 0, txtcantidad.Text)
        '            row("FACTOR_REFERENCE") = IIf(txtcantidadref.Text = "", 0, txtcantidadref.Text)
        '            row("PRICE") = IIf(txtValorunitario.Text = "", 0, txtValorunitario.Text)
        '            row("DISCOUNT_PER") = IIf(txtporc_descuento.Text = "", 0, txtporc_descuento.Text)
        '            row("DISCOUNT") = IIf(txtdescuento.Text = "", 0, txtdescuento.Text)
        '            row("AMOUNT_TAX") = IIf(txt_igv.Text = "", 0, txt_igv.Text)
        '            row("PERCENT_TAX") = IIf(txttasa.Text = "", 0, txttasa.Text)
        '            row("PRICE_NET") = IIf(txtvalorvent.Text = "", 0, txtvalorvent.Text)
        '            row("AMOUNT_TOTAL") = IIf(txtvalorventaunit.Text = "", 0, txtvalorventaunit.Text)
        '            row("AMOUNT_TOTAL_NET") = IIf(txttotalneto.Text = "", 0.0, txttotalneto.Text)
        '            row("COMMENT1") = txtobservaciones.Text
        '            row("TEXT_COMMENT") = txtGlosa.Text
        '            row("IS_VAT") = IIf(chkigv.Checked = True, "1", "0")
        '            row("PRICE_UNIT") = IIf(txtpreciounitario.Text = "", 0.0, txtpreciounitario.Text)
        '            row("CCOST_ID") = txtcentroCosto.Text
        '            row("FLAG_FREE_IGV") = IIf(chk_libre.Checked = True, 1, 0)
        '            dtdetalleArticuloPrincipal.EndInit()
        '            dtdetalleArticuloPrincipal.AcceptChanges()
        '        Next
        '        btn_cancel.PerformClick()
        '    End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Function ValidacionesGeneralesArticulo() As Boolean
        'Dim estado As Boolean = True
        'Try
        '    If txtcantidad.Text = String.Empty Then
        '        MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
        '        estado = False
        '        txtcantidad.Focus()
        '        Exit Try
        '    ElseIf Val(txtcantidad.Text) <= 0 Then
        '        MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
        '        estado = False
        '        txtcantidad.Focus()
        '        Exit Try
        '    ElseIf txtValorunitario.Text = String.Empty Then
        '        MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information, "Sistemas")
        '        estado = False
        '        txtValorunitario.Focus()
        '        Exit Try
        '    ElseIf Val(txtValorunitario.Text) <= 0 Then
        '        MsgBox("La cantidad debe ser mayor a Cero", MsgBoxStyle.Information, "Sistemas")
        '        estado = False
        '        txtValorunitario.Focus()
        '        Exit Try
        '    End If
        'Catch ex As Exception
        '    estado = False
        'End Try
        'Return estado
    End Function


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

    Private Sub dtpfechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicial.ValueChanged
        DocumentosCompra()
    End Sub

   


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Detalle_Entregas")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PRESENTACION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("COD_CLIENTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CLIENTE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("RUC", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_CLIENTE", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_CON_IGV", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PRECIO_SIN_IGV", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("VALOR_VENTA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IGV_ART", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("IMPORTE", Type.GetType("System.Double"))
            For i As Integer = 1 To Val(txt_num_entregas.Text)
                dtdetalleArticuloPrincipal.Columns.Add("ENTREGA" & CStr(i), Type.GetType("System.Double"))
            Next

            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}

            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal

            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Pres."
            dgvDetalle.Columns(5).HeaderText = "Cantidad Total"
            dgvDetalle.Columns(6).HeaderText = "Cod. Cliente"
            dgvDetalle.Columns(7).HeaderText = "Cliente"
            dgvDetalle.Columns(8).HeaderText = "RUC"
            dgvDetalle.Columns(9).HeaderText = "Cant. por Cliente"
            dgvDetalle.Columns(10).HeaderText = "Precio"
            dgvDetalle.Columns(11).Visible = False
            dgvDetalle.Columns(12).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(14).Visible = False
            dgvDetalle.Columns(15).Visible = False
            For i As Integer = 1 To Val(txt_num_entregas.Text)
                dgvDetalle.Columns(15 + i).HeaderText = "Entrega " & CStr(i)
            Next

            dgvDetalle.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            dgvDetalle.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            For i As Integer = 1 To Val(txt_num_entregas.Text)
                dgvDetalle.Columns(15 + i).DefaultCellStyle.Format = "##,##0.00"
                dgvDetalle.Columns(15 + i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalle.AutoResizeColumns()
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For i As Integer = 6 To 12
                dgvDetalle.Columns(i).DefaultCellStyle.Format = "##,##0.00"
            Next
            For i As Integer = 19 To dgvDetalle.ColumnCount() - 1
                dgvDetalle.Columns(i).Visible = False
            Next

            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Codigo"
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "Unid.Ref"
            dgvDetalle.Columns(6).HeaderText = "Cantidad"
            dgvDetalle.Columns(7).HeaderText = "Precio"
            dgvDetalle.Columns(8).HeaderText = "%.Descuento"
            dgvDetalle.Columns(9).HeaderText = "Descuento"
            dgvDetalle.Columns(10).HeaderText = "I.g.v"
            dgvDetalle.Columns(12).HeaderText = "Valor.Venta"
            dgvDetalle.Columns(14).HeaderText = "Total"
            dgvDetalle.Columns(18).HeaderText = "Comentario"
            dgvDetalle.Columns(17).HeaderText = "Observacion"

            dgvDetalle.Columns(5).Visible = False
            dgvDetalle.Columns(11).Visible = False
            dgvDetalle.Columns(13).Visible = False
            dgvDetalle.Columns(15).Visible = False
            dgvDetalle.Columns(16).Visible = False
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
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

            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = CompraBl.Mostrar_Documentos_Principal_Licitacion(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value, _
                                                                           cboopcionesBusqueda.SelectedIndex)
            dtv = dtDocumentos.DefaultView
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                
                dgvCabecera.Columns(0).HeaderText = "Id. Interno"
                dgvCabecera.Columns(1).HeaderText = "Número de Licitación"
                dgvCabecera.Columns(2).HeaderText = "Fecha"
                dgvCabecera.Columns(3).HeaderText = "Número de Entregas"
                dgvCabecera.Columns(4).HeaderText = "Observaciones"
                dgvCabecera.Columns(5).HeaderText = "Estado"
                dgvCabecera.Columns(6).Visible = False
                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_cod_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Clientes()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente.Text = String.Empty Then
                Ayuda_Clientes()
            Else
                Ayuda_Clientes(txt_cod_cliente.Text)
            End If
        End If
    End Sub

    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PED_SP_S_ORDER_CLIENTE"
                frm.CadenaConsulta = sql
                frm.Titulo = "Clientes"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cod_cliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txt_des_cliente.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                    txt_ruc_cliente.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                    txt_cantidad_cliente.Focus()
                End If
                frm.Close()

            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                Dim dtDetalleFact As DataTable
                dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txt_cod_cliente.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txt_des_cliente.Text = dtDetalleFact.Rows(0).Item(1).ToString
                    txt_ruc_cliente.Text = dtDetalleFact.Rows(0).Item(2).ToString
                    txt_cantidad_cliente.Focus()
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txt_cod_cliente.Text = String.Empty
                    txt_des_cliente.Text = String.Empty
                    txt_ruc_cliente.Text = String.Empty
                    txt_cod_cliente.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_articulo.KeyDown
        If e.KeyCode = Keys.F1 Then MostrandoArticulos()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_articulo.Text = String.Empty Then
                MostrandoArticulos()
            Else
                AgregarArticuloManual(txt_cod_articulo.Text)
            End If
        End If
    End Sub

    Private Sub txt_cod_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Clientes()
    End Sub
    Private Sub MostrandoArticulos()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "LICIT_SP_S_PART"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_articulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_articulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_pres_articulo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
                txt_unidad_articulo.Text = frm.Data_Matriz.Rows(0).Item(3).ToString
                txt_cantidad_articulo.Focus()
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AgregarArticuloManual(ByVal _codigoArticulo As String)
        Try
            clsFacturaBl = New ClsNegocio.RECEIVABLE
            Dim dtDocumentoGuias As DataTable
            dtDocumentoGuias = New DataTable
            dtDocumentoGuias = clsFacturaBl.Get_ManualArticulos(_codigoArticulo)
            Dim codArticulo As String = String.Empty
            If dtDocumentoGuias.Rows.Count() <> 0 Then
                txt_cod_articulo.Text = dtDocumentoGuias.Rows(0).Item("CODIGO").ToString
                txt_des_articulo.Text = dtDocumentoGuias.Rows(0).Item("DESCRIPCION").ToString
                txt_pres_articulo.Text = dtDocumentoGuias.Rows(0).Item("PRESENTACION").ToString
                txt_unidad_articulo.Text = dtDocumentoGuias.Rows(0).Item("UNIDAD").ToString
                txt_cantidad_articulo.Focus()
            Else
                MsgBox("No hay informacion con el codigo especificado", MsgBoxStyle.Information)
                txt_cod_articulo.Text = String.Empty
                txt_des_articulo.Text = String.Empty
                txt_pres_articulo.Text = String.Empty
                txt_unidad_articulo.Text = String.Empty
                txt_cod_articulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_articulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_articulo.MouseDoubleClick
        MostrandoArticulos()
    End Sub

    Private Sub txt_num_entregas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_entregas.KeyPress
        e.Handled = Numero(e, txt_num_entregas) ' txtTotal, caja de texto a validar
    End Sub

    Private Sub txt_cantidad_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_articulo.KeyPress
        e.Handled = Numero(e, txt_cantidad_articulo) ' txtTotal, caja de texto a validar
    End Sub

    Private Sub txt_cantidad_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_cliente.KeyPress
        e.Handled = Numero(e, txt_cantidad_cliente) ' txtTotal, caja de texto a validar
    End Sub

    Private Sub txt_precio_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_unit.KeyPress
        e.Handled = Numero(e, txt_precio_unit) ' txtTotal, caja de texto a validar

    End Sub

    Private Sub txt_num_licitacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_licitacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_num_entregas_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_entregas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MessageBox.Show("¿El número de entregas es correcto ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                gbDetalles.Enabled = True
                gbcabecera.Enabled = False
                GenerarColummnaDataTable()
                txt_cod_articulo.Focus()

            End If
            
        End If
    End Sub

    Private Sub txt_observaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cantidad_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad_articulo.Text = String.Empty Then
                MsgBox("Debe ingresar la cantidad para el articulo.", MsgBoxStyle.Exclamation)
                txt_cantidad_articulo.Focus()
                Exit Sub
            Else
                If CDbl(txt_cantidad_articulo.Text) = 0 Then
                    MsgBox("La cantidad para el articulo debe ser mayor a cero.", MsgBoxStyle.Exclamation)
                    txt_cantidad_articulo.Focus()
                    Exit Sub
                End If
            End If
            txt_cantidad_articulo.Text = Format(Double.Parse(txt_cantidad_articulo.Text), "##,##0.00")
            txt_cod_cliente.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
            txt_cantidad_cliente.Text = Format(Double.Parse(txt_cantidad_cliente.Text), "##,##0.00")
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Private Sub txt_precio_unit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_precio_unit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad_cliente.Text = String.Empty Then
                MsgBox("Debe ingresar la cantidad de entrega para el cliente.", MsgBoxStyle.Information)
                txt_cantidad_cliente.Focus()
                Exit Sub
            Else
                If Val(txt_cantidad_cliente.Text) <= 0 Then
                    MsgBox("La cantidad a entregar al cliente debe ser mayor a cero.", MsgBoxStyle.Information)
                    txt_cantidad_cliente.Focus()
                    Exit Sub
                End If
            End If
            If txt_num_entregas.TextLength <> 0 Then
                If Val(txt_num_entregas.Text) <= 0 Then
                    MsgBox("El numero de entregas debe ser mayor a Cero", MsgBoxStyle.Information)
                    txt_num_entregas.Focus()
                    Exit Sub
                End If
                txt_precio_unit.Text = Format(Double.Parse(txt_precio_unit.Text), "##,##0.000000")
                pnl_detalle_num_entregas.Visible = True
                'BultosGenerarColummnaDataTable()
                LLenarDatosBultos(Val(txt_num_entregas.Text))

            Else
                MsgBox("Ingrese el número de entregas.", MsgBoxStyle.Information)
                txt_num_entregas.Focus()
            End If
        End If
    End Sub
    Private Sub LLenarDatosBultos(ByVal _numero_entregas As Integer)
        Try
            Dim CantidadTotal As String = String.Empty

            dgvDetallesBulto.Rows.Clear()
            For i As Integer = 0 To _numero_entregas - 1
                dgvDetallesBulto.Rows.Add(i + 1, txt_cantidad_cliente.Text, "0.0")
            Next
            dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, 0)
            dgvDetallesBulto.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreplicar_Click(sender As Object, e As EventArgs) Handles btnreplicar.Click
        If dgvDetallesBulto.Rows.Count > 0 Then
            Dim _cantidad_inicial As Double = dgvDetallesBulto.Rows(0).Cells(2).Value
            dgvDetallesBulto.Rows.Clear()
            For i As Integer = 0 To txt_num_entregas.Text - 1
                'For i As Integer = 0 To txtnumerobultos.Text - 1
                dgvDetallesBulto.Rows.Add(i + 1, txt_cantidad_cliente.Text, _cantidad_inicial)
                'Next
            Next
        End If
    End Sub

    Private Sub dgvDetallesBulto_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetallesBulto.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
        'AddHandler validar.KeyPress, AddressOf PresionaEnter_KeyPress
    End Sub
    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
       ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetallesBulto.CurrentCell.ColumnIndex
        If columna = 2 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or _
           (caracter = ChrW(Keys.Back)) Or _
           (caracter = ".") And _
           (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub SalirBultos_Click(sender As Object, e As EventArgs) Handles SalirBultos.Click
        pnl_detalle_num_entregas.Visible = False
        flag_Edicion = False
        txt_precio_unit.Focus()
    End Sub

    Private Sub btnAceptarBultos_Click(sender As Object, e As EventArgs) Handles btnAceptarBultos.Click
        If GuardarBultos() = False Then
            Exit Sub
        End If
    End Sub
    Private Function GuardarBultos() As Boolean
        Dim res As Boolean = True
        Try
            Dim SubTotal As Decimal
            Dim valor As String = String.Empty
            For i As Integer = 0 To dgvDetallesBulto.Rows.Count() - 1
                Dim value As Object = dgvDetallesBulto.Item(2, i).Value
                'If ((Convert.ToString(value) = String.Empty) OrElse (Not (IsNumeric(value)))) Then
                If (String.IsNullOrEmpty(value) OrElse (Not (IsNumeric(value)))) Then
                    MsgBox("No se ingreso un Numero en la posicion :" & i + 1, MsgBoxStyle.Information)
                    dgvDetallesBulto.CurrentCell = dgvDetallesBulto(2, i)
                    res = False
                    Exit Try
                End If
                SubTotal += value
            Next
            'Mostrando La cantidad Asignada.
            txtCantidadAsiganda.Text = SubTotal
            If CDbl(txt_cantidad_cliente.Text) <> SubTotal Then
                MsgBox("La Cantidad Asignada en total debe ser igual a : " & txt_cantidad_cliente.Text, MsgBoxStyle.Information)
                res = False
                Exit Try
            End If

            If flag_Edicion = True Then
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & item_detalle)
                    dtdetalleArticuloPrincipal.BeginInit()

                    row("PART_ID") = txt_cod_articulo.Text.Trim
                    row("DESCRIPTION") = txt_des_articulo.Text.Trim
                    row("UNIT") = txt_unidad_articulo.Text.Trim
                    row("PRESENTACION") = txt_pres_articulo.Text.Trim
                    row("CANTIDAD_TOTAL") = CDbl(txt_cantidad_articulo.Text)
                    row("COD_CLIENTE") = txt_cod_cliente.Text.Trim
                    row("CLIENTE") = txt_des_cliente.Text.Trim
                    row("RUC") = txt_ruc_cliente.Text.Trim
                    row("CANTIDAD_CLIENTE") = CDbl(txt_cantidad_cliente.Text)
                    row("PRECIO") = CDbl(txt_precio_unit.Text)

                    For i As Integer = 1 To dgvDetallesBulto.Rows.Count
                        Dim _cant_entrega As Object = dgvDetallesBulto.Item(2, i - 1).Value
                        row("ENTREGA" & CStr(i)) = CDbl(_cant_entrega)
                    Next
                    row("PRECIO_CON_IGV") = CDbl(0)
                    row("PRECIO_SIN_IGV") = CDbl(0)
                    row("VALOR_VENTA") = CDbl(0)
                    row("IGV_ART") = CDbl(0)
                    row("IMPORTE") = CDbl(0)

                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()

                Next
            Else
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = txt_cod_articulo.Text.Trim
                row("DESCRIPTION") = txt_des_articulo.Text.Trim
                row("UNIT") = txt_unidad_articulo.Text.Trim
                row("PRESENTACION") = txt_pres_articulo.Text.Trim
                row("CANTIDAD_TOTAL") = CDbl(txt_cantidad_articulo.Text)
                row("COD_CLIENTE") = txt_cod_cliente.Text.Trim
                row("CLIENTE") = txt_des_cliente.Text.Trim
                row("RUC") = txt_ruc_cliente.Text.Trim
                row("CANTIDAD_CLIENTE") = CDbl(txt_cantidad_cliente.Text)
                row("PRECIO") = CDbl(txt_precio_unit.Text)

                For i As Integer = 1 To dgvDetallesBulto.Rows.Count
                    Dim _cant_entrega As Object = dgvDetallesBulto.Item(2, i - 1).Value
                    row("ENTREGA" & CStr(i)) = CDbl(_cant_entrega)
                Next
                row("PRECIO_CON_IGV") = CDbl(0)
                row("PRECIO_SIN_IGV") = CDbl(0)
                row("VALOR_VENTA") = CDbl(0)
                row("IGV_ART") = CDbl(0)
                row("IMPORTE") = CDbl(0)


                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
            End If

            Calcular_Totales()
            flag_Edicion = False
            pnl_detalle_num_entregas.Visible = False
            txt_cod_cliente.Text = String.Empty
            txt_des_cliente.Text = String.Empty
            txt_ruc_cliente.Text = String.Empty
            txt_cantidad_cliente.Text = String.Empty
            txt_precio_unit.Text = String.Empty
            txt_cod_cliente.Focus()
            'AgregarDatosBultos(Flag_ModoEdicion)
        Catch ex As Exception
            res = False
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    
    Private Sub dgvDetallesBulto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetallesBulto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptarBultos.Select()
        End If
    End Sub

    Private Sub dgvDetalle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDetalle.MouseDoubleClick
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If MessageBox.Show("¿Desea modificar el item elegido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            flag_Edicion = True
            item_detalle = dgvDetalle.CurrentRow.Cells("ITEM").Value
            txt_cod_articulo.Text = dgvDetalle.CurrentRow.Cells("PART_ID").Value
            txt_des_articulo.Text = dgvDetalle.CurrentRow.Cells("DESCRIPTION").Value
            txt_unidad_articulo.Text = dgvDetalle.CurrentRow.Cells("UNIT").Value
            txt_pres_articulo.Text = dgvDetalle.CurrentRow.Cells("PRESENTACION").Value
            txt_cantidad_articulo.Text = dgvDetalle.CurrentRow.Cells("CANTIDAD_TOTAL").Value
            txt_cod_cliente.Text = dgvDetalle.CurrentRow.Cells("COD_CLIENTE").Value
            txt_des_cliente.Text = dgvDetalle.CurrentRow.Cells("CLIENTE").Value
            txt_ruc_cliente.Text = dgvDetalle.CurrentRow.Cells("RUC").Value
            txt_cantidad_cliente.Text = dgvDetalle.CurrentRow.Cells("CANTIDAD_CLIENTE").Value
            txt_precio_unit.Text = dgvDetalle.CurrentRow.Cells("PRECIO").Value
            txt_cod_articulo.Focus()
        End If

    End Sub
    
    Private Sub dgvCabecera_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCabecera.MouseDoubleClick
        Call btnConsultar_Click(sender, e)
    End Sub

    Private Sub Tool_Exportar_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _id As Integer
        _id = CInt(dgvCabecera.CurrentRow.Cells("ID").Value)
        Try
            ''cabecera
            CompraBl = New ClsOperaciones.PURCHASE_FACT_SUPPLIER
            Dim dtdetalle_licitacion As New DataTable
            dtdetalle_licitacion = CompraBl.Licitacion_Reporte(_id)
            If dtdetalle_licitacion.Rows.Count() <> 0 Then
                dgvdetalle_reporte.DataSource = dtdetalle_licitacion
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Cursor = Cursors.WaitCursor

        Const xlEdgeLeft = 7
        Const xlEdgeRight = 10
        Const xlEdgeTop = 8
        Const xlEdgeBottom = 9
        Const xlInsideHorizontal = 12
        Const xlInsideVertical = 11
        Const xlContinuous = 1
        Const xlThin = 2

        Dim excel As Object
        Dim wBook As Object
        Dim wSheet As Object

        excel = CreateObject("Excel.Application")
        wBook = excel.Workbooks.Add
        wSheet = wBook.Worksheets(1)


        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        wSheet.Name = "Licitación"

        excel.Cells(1, 1) = "Empresa"
        excel.Cells(2, 1) = "Ruc"
        excel.Cells(1, 2) = LibComunVar.ClsVarComun.NomEmpresa
        excel.Cells(2, 2) = "'" & LibComunVar.ClsVarComun.RucEmpresa

        excel.Cells(4, 3) = "DISTRIBUCION POR PUNTO DE ENTREGA"

        excel.Cells(6, 1) = "N° Licitación"
        excel.Cells(7, 1) = "N° de Entregas"
        excel.Cells(8, 1) = "Fecha"
        excel.Cells(9, 1) = "Observaciones"

        excel.Cells(6, 2) = dgvCabecera.CurrentRow.Cells("NUMERO_LICITACION").Value
        excel.Cells(7, 2) = dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value
        excel.Cells(8, 2) = dgvCabecera.CurrentRow.Cells("FECHA").Value
        excel.Cells(9, 2) = dgvCabecera.CurrentRow.Cells("OBS").Value


        Dim cont_filas_tmp As Integer = 0
        cont_filas_tmp = 11

        excel.Cells(cont_filas_tmp, 2) = "Codigo Producto"
        excel.Cells(cont_filas_tmp, 3) = "Producto"
        excel.Cells(cont_filas_tmp, 4) = "Unidad"
        excel.Cells(cont_filas_tmp, 5) = "Codigo Cliente"
        excel.Cells(cont_filas_tmp, 6) = "Cliente"
        excel.Cells(cont_filas_tmp, 7) = "RUC"
        For x As Integer = 1 To CInt(dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value)
            excel.Cells(cont_filas_tmp, 7 + x) = "N° Entrega " & CStr(x) & " "
        Next
        excel.Cells(cont_filas_tmp, 8 + CInt(dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value)) = "TOTAL REQUERIDO"
        'With wSheet.Range(cont_filas_tmp, "F11").Borders(xlEdgeBottom)
        '    .Weight = xlThin
        '    .LineStyle = xlContinuous
        '    .ColorIndex = 0
        '    .TintAndShade = 0
        'End With

        'With wSheet.Range(cont_filas_tmp, "F11").Borders(xlEdgeTop)
        '    .Weight = xlThin
        '    .LineStyle = xlContinuous
        '    .ColorIndex = 0
        '    .TintAndShade = 0
        'End With



        cont_filas_tmp = 12

        For f As Integer = 0 To dgvdetalle_reporte.Rows.Count - 1
            excel.Cells(cont_filas_tmp + f, 2) = dgvdetalle_reporte.Rows(f).Cells("PART_ID").Value
            excel.Cells(cont_filas_tmp + f, 3) = dgvdetalle_reporte.Rows(f).Cells("DESCRIPTION").Value & "  " & dgvdetalle_reporte.Rows(f).Cells("PRESENTACION").Value
            excel.Cells(cont_filas_tmp + f, 4) = dgvdetalle_reporte.Rows(f).Cells("UNIT").Value
            excel.Cells(cont_filas_tmp + f, 5) = dgvdetalle_reporte.Rows(f).Cells("COD_CLIENTE").Value
            excel.Cells(cont_filas_tmp + f, 6) = dgvdetalle_reporte.Rows(f).Cells("CLIENTE").Value
            excel.Cells(cont_filas_tmp + f, 7) = dgvdetalle_reporte.Rows(f).Cells("RUC").Value
            For x As Integer = 1 To CInt(dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value)
                excel.Cells(cont_filas_tmp, 7 + x) = dgvdetalle_reporte.Rows(f).Cells("ENTREGA" & CStr(x) & "").Value
            Next
            excel.Cells(cont_filas_tmp + f, 8 + CInt(dgvCabecera.CurrentRow.Cells("NUMERO_ENTREGAS").Value)) = dgvdetalle_reporte.Rows(f).Cells("CANTIDAD_CLIENTE").Value
        Next

        wSheet.Columns.AutoFit()

        '****************** finalizamos *******************
        Dim strFileName As String = "C:\LICITACION.xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True

        Me.Cursor = Cursors.Default

    End Sub
End Class