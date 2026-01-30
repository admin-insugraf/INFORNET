Imports LibSeguridad
Imports LibProveedores
Imports LibAlmacenes
Imports LibContabilidad
Imports LibVentas
Imports LibComunVar
Imports LibCobranzas
Imports LibAdministracion
Imports LibManufactura
Imports LibCompras
Imports LibActivo
Imports LibCajaChica
Imports System.IO
Imports System.Net
Imports System.Text
Imports LibConsultasComun
Imports Newtonsoft.Json.Linq

Public Class frmMenu
    Private dtAccesos As DataTable
    Private ClsUsuario As LibSeguridad.ClsUsuario
    Private ClsConsulta As LibConsultasComun.ClsComun

    Private Sub RecorrerEstructuraMenu(ByVal oMenu As MenuStrip)
        For Each oOpcionMenu As ToolStripMenuItem In oMenu.Items
            If MarcaAccesos(oOpcionMenu.Name) = True Then
                oOpcionMenu.Visible = True
            Else
                oOpcionMenu.Visible = False
            End If
            If oOpcionMenu.DropDownItems.Count > 0 Then
                Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, oOpcionMenu)
            End If
        Next
    End Sub
    Private Sub RecorrerSubmenu(ByVal oSubmenuItems As ToolStripItemCollection, ByVal Padre As ToolStripMenuItem)
        For Each oSubitem As ToolStripItem In oSubmenuItems
            If oSubitem.GetType Is GetType(ToolStripMenuItem) Then
                If MarcaAccesos(oSubitem.Name) = True Then
                    oSubitem.Visible = True
                Else
                    oSubitem.Visible = False
                End If
                If CType(oSubitem, ToolStripMenuItem).DropDownItems.Count > 0 Then
                    Me.RecorrerSubmenu(CType(oSubitem, ToolStripMenuItem).DropDownItems, oSubitem)
                End If
            End If
        Next
    End Sub

    Private Function MarcaAccesos(ByVal STRName As String) As Boolean
        Dim myRow() As DataRow
        myRow = dtAccesos.Select("COD_OPCION='" & STRName & "'", "COD_OPCION")
        If myRow.Length > 0 Then
            If myRow(0).Item("HABILITADO_SN") = "S" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("fondoLusa.swf"))
        Call ConsultaAccesos(STRUserSys)
        Call RecorrerEstructuraMenu(Me.MnuPrin)
        Call DatosGenerales()
        Call Paneles_StatusBar()
    End Sub

    Private Sub DatosGenerales()
        ClsConsulta = New LibConsultasComun.ClsComun
        Dim dtGeneral As New DataTable
        dtGeneral = ClsConsulta.get_TipoCambio(GdtFechaSys)
        If dtGeneral.Rows.Count > 0 Then
            GdbTipCambioC = Convert.ToDouble(dtGeneral.Rows(0).Item("BUY_RATE").ToString)
            GdbTipCambioV = Convert.ToDouble(dtGeneral.Rows(0).Item("SELL_RATE").ToString)
            ClsVarComun.TCVenta = GdbTipCambioV
            ClsVarComun.TCCompra = GdbTipCambioC
        Else
            Call ObtenerApi()
            Call DatosGenerales()
            'MessageBox.Show("El tipo de cambio no ha sido cargado, no se podrán realizar operaciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        dtGeneral.Dispose()
        ClsConsulta = Nothing

    End Sub

    Private Function ObtenerApi() As Boolean
        Try
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim url As String = "https://api.migo.pe/api/v1/exchange/latest"
            Dim token As String = "4ry5nuuz7O5JeupIFRbQ0kTRkfApq4a8c38euhIc2R2gxMvJUE64Cq8nqtrj"

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"

            Dim jsonBody As String = "{""token"":""" & token & """}"
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(jsonBody)
            request.ContentLength = bytes.Length

            Using Stream = request.GetRequestStream()
                Stream.Write(bytes, 0, bytes.Length)
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                If response.StatusCode <> HttpStatusCode.OK Then
                    MsgBox("Error HTTP: " & response.StatusCode.ToString, MsgBoxStyle.Critical)
                    Return False
                End If

                Using reader As New StreamReader(response.GetResponseStream())
                    Dim json As String = reader.ReadToEnd()

                    If json.Trim().StartsWith("{") Then
                        Dim obj As JObject = JObject.Parse(json)

                        If obj("success").ToString().ToLower = "true" Then

                            If String.IsNullOrEmpty(obj("precio_compra").ToString()) OrElse String.IsNullOrEmpty(obj("precio_venta").ToString()) Then
                                MsgBox("Datos incompletos en la respuesta del API", MsgBoxStyle.Exclamation)
                                Return False
                            End If

                            Dim fecha As Date = Date.Parse(obj("fecha").ToString())
                            Dim compra As Double = Convert.ToDouble(obj("precio_compra").ToString())
                            Dim venta As Double = Convert.ToDouble(obj("precio_venta").ToString())

                            Dim consulta As New ClsComun
                            Dim resultado As Integer = consulta.GuardarTipoCambio(fecha, compra, venta)
                            If resultado = 1 Then
                                Return True
                            Else
                                MsgBox("Error al guardar el tipo de cambio", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("Respuesta inesperada del servidor.", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End Using
            End Using

        Catch ex As WebException
            If ex.Response IsNot Nothing Then
                Dim httpResponse = CType(ex.Response, HttpWebResponse)
                MsgBox("Error HTTP: " & httpResponse.StatusCode.ToString, MsgBoxStyle.Critical)
            Else
                MsgBox("Error de conexión: " & ex.Message, MsgBoxStyle.Critical)
            End If
            Return False
        Catch ex As Exception
            MsgBox("Error al consultar el tipo de cambio: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub Paneles_StatusBar()
        tssEmpresa.Text = "EMPRESA: " & ClsVarComun.BaseDatos & Space(5)
        tssTipoCambio.Text = "Tipo de cambio:  Venta " & GdbTipCambioV & Space(6) & " Compra " & GdbTipCambioC & Space(5)
        tssFecha.Text = "Fecha de proceso: " & GdtFechaSys & Space(5)
        tssUsuario.Text = "Usuario: " & LibComunVar.ClsVarComun.USUARIO
    End Sub

    Private Sub ConsultaAccesos(ByVal STRCodigo As String)
        dtAccesos = New DataTable
        ClsUsuario = New LibSeguridad.ClsUsuario
        dtAccesos = ClsUsuario.Accesos_Usuario(STRCodigo)
        ClsUsuario = Nothing
    End Sub

    Private Sub mnuProvFicherosAreas_Click(sender As Object, e As EventArgs) Handles mnuProvFicherosAreas.Click
        Dim frmArea As New FrmArea
        frmArea.MdiParent = Me
        frmArea.Show()
    End Sub

    Private Sub mnuAlmFicherosArticulos_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosArticulos.Click
        frmcx_articulo = New frm_CX_MA_Articulo
        frmcx_articulo.MdiParent = Me
        frmcx_articulo.Show()
    End Sub

    Private Sub mnuAlmFicherosAlmacenes_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosAlmacenes.Click
        frm_Almacen = New frm_Almacen
        frm_Almacen.MdiParent = Me
        frm_Almacen.Show()
    End Sub
    Private Sub mnuContaFicherosAnexos_Click(sender As Object, e As EventArgs) Handles mnuContaFicherosAnexos.Click
        frmAnexos = New frm_CO_MA_Anexos
        frmAnexos.MdiParent = Me
        frmAnexos.Show()
    End Sub

    Private Sub mnuContaFicherosPlanCuentas_Click(sender As Object, e As EventArgs) Handles mnuContaFicherosPlanCuentas.Click
        Dim frmplancuentas As New frm_CO_MA_PlanCtas
        frmplancuentas.MdiParent = Me
        frmplancuentas.Show()
    End Sub

    Private Sub mnuClienteTransPedidos_Click(sender As Object, e As EventArgs)
        Dim frmAccesoP As New FrmAccesoPedido
        frmAccesoP.MdiParent = Me
        frmAccesoP.Show()
    End Sub

    Private Sub mnuAlmTransIngresos_Click(sender As Object, e As EventArgs) Handles mnuAlmTransIngresos.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmInv = New FrmMovimientoAlmacen
                frmInv.MdiParent = Me
                frmInv.TipoMov = "I"
                frmInv.documentId = "NI"
                frmInv.Text = "Ingreso a Almacen"
                frmInv.Name = "Ingreso a Almacen"
                OpenSubForm(frmInv)
            End If
        End If

    End Sub

    Private Sub mnuAlmTransEgresos_Click(sender As Object, e As EventArgs) Handles mnuAlmTransEgresos.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmInv = New FrmMovimientoAlmacen
                frmInv.MdiParent = Me
                frmInv.TipoMov = "S"
                frmInv.documentId = "NS"
                frmInv.Text = "Salida de Almacen"
                frmInv.Name = "Salida de Almacen"
                OpenSubForm(frmInv)
            End If
        End If
    End Sub

    Private Sub mnuCajaBancosFicTransCobCli_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosFicTransCobCli.Click


        'If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
        '    MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        'Else
        '    If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
        '        MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        '    Else
        '        frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
        '        frmcx_planillaCob.MdiParent = Me
        '        frmcx_planillaCob.Show()
        '    End If
        'End If
    End Sub

    Private Sub mnuClienteFicheroClientes_Click(sender As Object, e As EventArgs) Handles mnuClienteFicheroClientes.Click
        frmcx_clientes = New frm_CX_MA_Cliente
        frmcx_clientes.MdiParent = Me
        frmcx_clientes.Show()
    End Sub

    Private Sub mnuClienteFicheroCondicionVenta_Click(sender As Object, e As EventArgs) Handles mnuClienteFicheroCondicionVenta.Click
        frmcx_TipoPago = New frm_CX_MA_TipoPago
        frmcx_TipoPago.MdiParent = Me
        OpenSubForm(frmcx_TipoPago)
    End Sub

    Private Sub mnuClienteFicheroVendedores_Click(sender As Object, e As EventArgs) Handles mnuClienteFicheroVendedores.Click
        frmcx_vendedor = New frm_CX_MA_Vendedores
        frmcx_vendedor.MdiParent = Me
        OpenSubForm(frmcx_vendedor)
    End Sub

    Private Sub mnuCajaBancosFicFormaCobranza_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosFicFormaCobranza.Click
        frmcx_conceptos_cob = New frm_CX_MA_ConcepCob
        frmcx_conceptos_cob.MdiParent = Me
        OpenSubForm(frmcx_conceptos_cob)
    End Sub


    Private Sub mnuCajaBancosFicBancos_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosFicBancos.Click
        frmcx_banco = New frm_CX_MA_Bancos
        frmcx_banco.MdiParent = Me
        OpenSubForm(frmcx_banco)
    End Sub

    Private Sub mnuProvFicherosProveedores_Click(sender As Object, e As EventArgs) Handles mnuProvFicherosProveedores.Click
        frmcx_proveedor = New frm_CX_MA_Proveedor
        frmcx_proveedor.MdiParent = Me
        OpenSubForm(frmcx_proveedor)
    End Sub

    Private Sub mnuAlmFicherosFamilias_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosFamilias.Click
        frmcx_familia = New frm_CX_MA_Familia
        frmcx_familia.MdiParent = Me
        OpenSubForm(frmcx_familia)
    End Sub

    Private Sub mnuProvOrdCompra_Click(sender As Object, e As EventArgs) Handles mnuProvOrdCompra.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmOrdenCompra As New Frm_Orden_Compra
                FrmOrdenCompra.MdiParent = Me
                OpenSubForm(FrmOrdenCompra)
            End If
        End If

    End Sub

    Private Sub mnuCliConsTransaccionesCliente_Click(sender As Object, e As EventArgs)
        frmConTransaccionesCliente = New frmConTransaccionesCliente
        frmConTransaccionesCliente.MdiParent = Me
        frmConTransaccionesCliente.Show()
    End Sub


    Private Sub mnuAdmUsuariosCrearPerfiles_Click(sender As Object, e As EventArgs) Handles mnuAdmUsuariosCrearPerfiles.Click
        frmPerfilesUsuario = New frmPerfilesUsuario
        frmPerfilesUsuario.MenuPrincipal = MnuPrin
        frmPerfilesUsuario.MdiParent = Me
        frmPerfilesUsuario.Show()
    End Sub

    Private Sub mnuAdmUsuariosCrearUsuarios_Click(sender As Object, e As EventArgs) Handles mnuAdmUsuariosCrearUsuarios.Click
        frmCrearUsuario = New frmCrearUsuario
        frmCrearUsuario.MdiParent = Me
        frmCrearUsuario.Show()
    End Sub

    Private Sub mnuAdmUsuariosAccesosUsuario_Click(sender As Object, e As EventArgs) Handles mnuAdmUsuariosAccesosUsuario.Click
        frmAccesoUsuario.MdiParent = Me
        frmAccesoUsuario.Show()
    End Sub

    Private Sub mnuClienteReporteDocVendedor_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteDocVendedor.Click
        Dim VentasVendedorProducto As New frm_Reporte_VendedorxProducto
        VentasVendedorProducto.MdiParent = Me
        VentasVendedorProducto.Show()
    End Sub

    Private Sub mnuClienteReporteDocumentosxFecha_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteDocumentosxFecha.Click
        Dim FrmVentasClienteProducto As New frm_Reporte_ClientexProducto
        FrmVentasClienteProducto.MdiParent = Me
        FrmVentasClienteProducto.Show()
    End Sub

    Private Sub mnuAlmGuiaRemision_Click(sender As Object, e As EventArgs)
        'frm_CX_LT_GuiaRemision = New frm_GuiaRemision_tranferencia_Interna
        'frm_CX_LT_GuiaRemision.MdiParent = Me
        'frm_CX_LT_GuiaRemision.Show()
    End Sub

    Private Sub mnuCajaBancosFicFormaPago_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosFicFormaPago.Click
        frmcx_TipoPago = New frm_CX_MA_TipoPago
        frmcx_TipoPago.MdiParent = Me
        frmcx_TipoPago.Show()
    End Sub

    Private Sub mnuAlmFicherosTipTransacciones_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosTipTransacciones.Click
        frm_CX_MA_TransaccionTipo = New frm_CX_MA_TransaccionTipo
        frm_CX_MA_TransaccionTipo.MdiParent = Me
        frm_CX_MA_TransaccionTipo.Show()
    End Sub

    Private Sub mnuAlmFicherosLotesArticulo_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosLotesArticulo.Click
        frmcx_lotes = New frm_CX_MA_Lotes
        frmcx_lotes.MdiParent = Me
        frmcx_lotes.Show()
    End Sub


    Private Sub mnuAdmAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAdmAcercaDe.Click
        frmAcercaDe = New frmAcercaDe
        frmAcercaDe.MdiParent = Me
        frmAcercaDe.Show()
    End Sub



    Private Sub mnuProvCotizacionProveedores_Click(sender As Object, e As EventArgs)
        Dim FrmReporteKardexReferencia As New FrmReporteKardex
        FrmReporteKardexReferencia.MdiParent = Me
        FrmReporteKardexReferencia.Show()
    End Sub

    Private Sub KardexPorReferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuAlmRptkardexRefLotes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StockLoteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransaccionesPorArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmTransaccionesArticulo As New FrmTransaccionesArticulo
        FrmTransaccionesArticulo.MdiParent = Me
        FrmTransaccionesArticulo.Show()
    End Sub

    Private Sub mnuAlmTransTraslados_Click(sender As Object, e As EventArgs) Handles mnuAlmTransTraslados.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frm_tranferencia_Interna As New frm_GuiaRemision_tranferencia_Interna
                frm_tranferencia_Interna.MdiParent = Me
                frm_tranferencia_Interna.TipoTransaccion = "TD"
                frm_tranferencia_Interna.Show()
            End If
        End If
    End Sub

    Private Sub mnuAlmGuiasRemisiones_Click(sender As Object, e As EventArgs) Handles mnuAlmGuiasRemisiones.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frm_CX_LT_GuiaRemision = New frm_CX_LT_GuiaRemision
                frm_CX_LT_GuiaRemision.MdiParent = Me
                frm_CX_LT_GuiaRemision.Show()
            End If
        End If
    End Sub

    Private Sub mnuAlmTransIngrOC_Click(sender As Object, e As EventArgs) Handles mnuAlmTransIngrOC.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frm_Ingreso_OC = New frm_Ingreso_Orden_Compra
                frm_Ingreso_OC.MdiParent = Me
                frm_Ingreso_OC.Show()
            End If
        End If

    End Sub

    Private Sub mnuAlmRecalculoStock_Click(sender As Object, e As EventArgs) Handles mnuAlmRecalculoStock.Click
        Dim frm_Rec_Stok As New FrmRecalculoStock
        frm_Rec_Stok.MdiParent = Me
        frm_Rec_Stok.Show()
    End Sub

    Private Sub mnuAlmRevalorizacionInventarios_Click(sender As Object, e As EventArgs) Handles mnuAlmRevalorizacionInventarios.Click
        Dim frm_Rev_UInventario As New FrmRevalorizacionInventario
        frm_Rev_UInventario.MdiParent = Me
        frm_Rev_UInventario.Show()
    End Sub

    Private Sub mnuAlmRptInvValorizadoEmpresa_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub mnuAlmRptDocAlmacen_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub mnuAlmRptDocAlmTransArt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuTransaccionesDocumentoVentas_Click(sender As Object, e As EventArgs) Handles mnuTransaccionesDocumentoVentas.Click
        ''Verificacion Tipo Cambio
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmFact As New FrmFacturacion
                FrmFact.MdiParent = Me
                OpenSubForm(FrmFact)
            End If
        End If
    End Sub

    Private Sub mnuAlmTransInvFisico_Click(sender As Object, e As EventArgs) Handles mnuAlmTransInvFisico.Click
        Dim FrmAjusteInv As New FrmAjusteInventario
        FrmAjusteInv.MdiParent = Me
        OpenSubForm(FrmAjusteInv)
    End Sub
    'Método para abrir el formulario una sola vez.
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

    Private Sub mnuClienteReporteDespachos_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteDespachos.Click
        Dim FrmVentasDespacho As New FrmVentasDespacho
        FrmVentasDespacho.MdiParent = Me
        OpenSubForm(FrmVentasDespacho)
    End Sub

    Private Sub mnuClienteReporteVentaMensualArticulo_Click(sender As Object, e As EventArgs)
        Dim FrmVentasmensualArt As New LibVentas.FrmVentasMensualArticulo
        FrmVentasmensualArt.MdiParent = Me
        OpenSubForm(FrmVentasmensualArt)
    End Sub

    Private Sub mnuClienteReporteMovResumArticulo_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteMovResumArticulo.Click
        Dim frmMovResArt As New FrmMovimientoResumidoArticulo
        frmMovResArt.MdiParent = Me
        OpenSubForm(frmMovResArt)
    End Sub

    Private Sub mnuAlmRptConsultaStock_Click(sender As Object, e As EventArgs) Handles mnuAlmRptConsultaStock.Click
        Dim frmConsStock As New FrmConsultaStock
        frmConsStock.MdiParent = Me
        OpenSubForm(frmConsStock)
    End Sub

    Private Sub mnuClienteletraCanjeLetras_Click(sender As Object, e As EventArgs) Handles mnuClienteletraCanjeLetras.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmletras = New FrmLetras
                frmletras.MdiParent = Me
                OpenSubForm(frmletras)
            End If
        End If
    End Sub

    Private Sub mnuClienteletraMantenimiento_Click(sender As Object, e As EventArgs) Handles mnuClienteletraMantenimiento.Click
        frmMantenimiento = New FrmAceptacionLetras
        frmMantenimiento.MdiParent = Me
        OpenSubForm(frmMantenimiento)
    End Sub

    Private Sub mnuClienteReporteLetras_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteLetras.Click
        Dim frmReporteL As New FrmReporteLetras
        frmReporteL.MdiParent = Me
        OpenSubForm(frmReporteL)
    End Sub

    Private Sub mnuClienteReportePendienteC_Click(sender As Object, e As EventArgs)
        Dim FrmPendienteCobr As New FrmReportePendienteCobro
        FrmPendienteCobr.MdiParent = Me
        OpenSubForm(FrmPendienteCobr)
    End Sub

    Private Sub mnuTransaccionesDocumentosPendientes_Click(sender As Object, e As EventArgs) Handles mnuTransaccionesDocumentosPendientes.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frmDocPendientesL As New FrmLetras_ManejoDocumentosPendientes
                frmDocPendientesL.MdiParent = Me
                OpenSubForm(frmDocPendientesL)
            End If
        End If

    End Sub

    Private Sub mnuClienteReporteDocumentosCancelados_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteDocumentosCancelados.Click
        Dim frmDoccancelados As New FrmReporteDocumentosCancelados
        frmDoccancelados.MdiParent = Me
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub ReporteGerencialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteGerencialesToolStripMenuItem.Click
        FrmRepgerenciales = New FrmRepGerenciales
        FrmRepgerenciales.MdiParent = Me
        OpenSubForm(FrmRepgerenciales)
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        Try
            Dim FrmTipoC = New FrmTipoCambios
            FrmTipoC.ShowDialog()

            Call DatosGenerales()
            Call Paneles_StatusBar()


        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DocumentosConToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmDocDetracc As New FrmVentasDocumentosDetracccion
        FrmDocDetracc.MdiParent = Me
        FrmDocDetracc.Show()
    End Sub

    Private Sub mnuClienteReporteDocVencimiento_Click(sender As Object, e As EventArgs)
        Dim FrmDocDiasVencer As New FrmReporteDoc_Pend_Vencimiento
        FrmDocDiasVencer.MdiParent = Me
        FrmDocDiasVencer.Show()
    End Sub

    Private Sub mnuClienteReporteDocCanceladosTipoC_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteDocCanceladosTipoC.Click
        Dim FrmDocTipoC As New FrmReporteDocumentosTipoCobranzas
        FrmDocTipoC.MdiParent = Me
        FrmDocTipoC.Show()
    End Sub



    Private Sub BuscaAnexoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmBuscaA As New frm_CO_LT_BuscaAnexo
        frmBuscaA.MdiParent = Me
        OpenSubForm(frmBuscaA)
    End Sub

    Private Sub ContabilizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmContabilizar As New frm_CO_LT_Contabilizar
        frmContabilizar.MdiParent = Me
        OpenSubForm(frmContabilizar)
    End Sub

    Private Sub DocumentosPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmDocPend As New frm_CO_LT_DocsPendientes
        frmDocPend.MdiParent = Me
        OpenSubForm(frmDocPend)
    End Sub

    Private Sub IngVaucherToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmvaucher As New frm_CO_LT_IngVoucher
        frmvaucher.MdiParent = Me
        OpenSubForm(frmvaucher)
    End Sub

    Private Sub ListaAsientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaAsientosToolStripMenuItem.Click
        Dim frmListaAsient As New frm_CO_LT_ListaAsientos
        frmListaAsient.MdiParent = Me
        OpenSubForm(frmListaAsient)
    End Sub


    Private Sub PlanDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmPalnCuentas As New frm_CO_MA_PlanCtas
        frmPalnCuentas.MdiParent = Me
        OpenSubForm(frmPalnCuentas)

    End Sub

    Private Sub mnuContaFicherosSubdiarios_Click(sender As Object, e As EventArgs) Handles mnuContaFicherosSubdiarios.Click
        Dim frmSubDiario As New frm_CO_MA_Subdiarios
        frmSubDiario.MdiParent = Me
        OpenSubForm(frmSubDiario)
    End Sub



    Private Sub AnalisisToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmAnalisis As New frm_CO_RP_AnalisisCta01
        frmAnalisis.MdiParent = Me
        OpenSubForm(frmAnalisis)
    End Sub

    Private Sub BalanceDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmBalanceComp As New frm_CO_RP_BalCompro
        frmBalanceComp.MdiParent = Me
        OpenSubForm(frmBalanceComp)
    End Sub

    Private Sub BalanceGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmBalanceGeneral As New frm_CO_RP_BalGeneral
        frmBalanceGeneral.MdiParent = Me
        OpenSubForm(frmBalanceGeneral)
    End Sub

    Private Sub BalanceDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmBalanceInventarios As New frm_CO_RP_BalInven
        frmBalanceInventarios.MdiParent = Me
        OpenSubForm(frmBalanceInventarios)
    End Sub

    Private Sub DaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaoToolStripMenuItem.Click
        Dim frmDaot As New frm_CO_RP_Daot
        frmDaot.MdiParent = Me
        OpenSubForm(frmDaot)
    End Sub

    Private Sub EgpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmEgp As New frm_CO_RP_Egp
        frmEgp.MdiParent = Me
        OpenSubForm(frmEgp)
    End Sub

    Private Sub LibroCajaYBancosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TipoDeAnexoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeAnexoToolStripMenuItem1.Click
        Dim frmTipoAnexo As New frm_CO_MA_TipoAnexos
        frmTipoAnexo.MdiParent = Me
        OpenSubForm(frmTipoAnexo)
    End Sub

    Private Sub ParametrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem1.Click
        Dim frmParametros As New frm_CO_MA_Parametros
        frmParametros.MdiParent = Me
        OpenSubForm(frmParametros)
    End Sub

    Private Sub ContabilizarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim frmContabilizar As New frm_CO_LT_Contabilizar
        frmContabilizar.MdiParent = Me
        OpenSubForm(frmContabilizar)
    End Sub

    Private Sub LibroMayorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibroMayorToolStripMenuItem1.Click
        Dim frmLibroMayor As New frm_CO_RP_LibMayor
        frmLibroMayor.MdiParent = Me
        OpenSubForm(frmLibroMayor)
    End Sub

    Private Sub LibroCajasYBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroCajasYBancosToolStripMenuItem.Click
        Dim frmLibroCajaB As New frm_CO_RP_LibCajaBancos
        frmLibroCajaB.MdiParent = Me
        OpenSubForm(frmLibroCajaB)
    End Sub

    Private Sub EstadoDeGananciasYPerdidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeGananciasYPerdidasToolStripMenuItem.Click
        Dim frmEgp As New frm_CO_RP_Egp
        frmEgp.MdiParent = Me
        OpenSubForm(frmEgp)
    End Sub

    Private Sub BalanceEInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceEInventariosToolStripMenuItem.Click
        Dim frmBalanceInventarios As New frm_CO_RP_BalInven
        frmBalanceInventarios.MdiParent = Me
        OpenSubForm(frmBalanceInventarios)
    End Sub

    Private Sub BalanceGeneralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BalanceGeneralToolStripMenuItem1.Click
        Dim frmBalanceGeneral As New frm_CO_RP_BalGeneral
        frmBalanceGeneral.MdiParent = Me
        OpenSubForm(frmBalanceGeneral)
    End Sub

    Private Sub BalanceDeComprobacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceDeComprobacionToolStripMenuItem.Click
        Dim frmBalanceComp As New frm_CO_RP_BalCompro
        frmBalanceComp.MdiParent = Me
        OpenSubForm(frmBalanceComp)
    End Sub

    Private Sub AnalisisCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisisCuentaToolStripMenuItem.Click
        Dim frmAnalisis As New frm_CO_RP_AnalisisCta01
        frmAnalisis.MdiParent = Me
        OpenSubForm(frmAnalisis)
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        Dim FrmRegVentas As New FrmRegVentas
        FrmRegVentas.MdiParent = Me
        OpenSubForm(FrmRegVentas)
    End Sub


    Private Sub mnuTransaccionesCierreVentas_Click(sender As Object, e As EventArgs) Handles mnuTransaccionesCierreVentas.Click
        Dim frmCierreV As New FrmProCierreVentasMensual
        frmCierreV.MdiParent = Me
        OpenSubForm(frmCierreV)
    End Sub

    Private Sub ListaDeAsientosContablesVariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeAsientosContablesVariosToolStripMenuItem.Click
        Dim frmListaAsient As New frm_CO_LT_ListaAsientosVarios
        frmListaAsient.MdiParent = Me
        OpenSubForm(frmListaAsient)
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem1.Click
        Dim FrmRegVentas As New FrmRegistroVentas
        FrmRegVentas.MdiParent = Me
        OpenSubForm(FrmRegVentas)
    End Sub

    Private Sub RegistroDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasToolStripMenuItem.Click
        Dim FrmRegCompras As New FrmRegistroCompras
        FrmRegCompras.MdiParent = Me
        OpenSubForm(FrmRegCompras)
    End Sub

    Private Sub CierreDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeVentasToolStripMenuItem.Click
        Dim FrmcierreVentas As New FrmCierraVentasMensual
        FrmcierreVentas.MdiParent = Me
        OpenSubForm(FrmcierreVentas)
    End Sub

    Private Sub AperturaDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperturaDeVentasToolStripMenuItem.Click
        Dim FrmAperturaVentas As New FrmAperturaVentasMensuales
        FrmAperturaVentas.MdiParent = Me
        OpenSubForm(FrmAperturaVentas)
    End Sub

    Private Sub ComprasConceptosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasConceptosToolStripMenuItem.Click
        Dim FrmComprasConceptos As New FrmComprasConceptos
        FrmComprasConceptos.MdiParent = Me
        OpenSubForm(FrmComprasConceptos)
    End Sub

    Private Sub CentrosDeCostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosDeCostoToolStripMenuItem.Click
        Dim FrmCentroC As New FrmCentroCosto
        FrmCentroC.MdiParent = Me
        OpenSubForm(FrmCentroC)
    End Sub

    Private Sub AjusteDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmAjusteInv As New FrmAjusteInventario
        FrmAjusteInv.MdiParent = Me
        OpenSubForm(FrmAjusteInv)
    End Sub

    Private Sub mnuCajaBancosFicTransPagoProv_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosFicTransPagoProv.Click

        'If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
        '    MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        'Else
        '    If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
        '        MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        '    Else
        '        Dim FrmPagos As New frm_CX_LT_PlanillaPagos
        '        FrmPagos.MdiParent = Me
        '        OpenSubForm(FrmPagos)
        '    End If
        'End If
    End Sub

    Private Sub FormasDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormasDePagoToolStripMenuItem.Click
        Dim frmConceptoPago As New frm_CX_MA_ConceptosPago
        frmConceptoPago.MdiParent = Me
        frmConceptoPago.Show()
    End Sub

    Private Sub MovimientosGuiaAnalisisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosGuiaAnalisisToolStripMenuItem.Click
        Dim FrmMov_Guia As New FrmMovimientoGuiaAnalisis
        FrmMov_Guia.MdiParent = Me
        FrmMov_Guia.TipoMov = "I"
        FrmMov_Guia.Text = "Movimiento Guia Analisis"
        FrmMov_Guia.Show()
    End Sub

    Private Sub BancosPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosPagoToolStripMenuItem.Click
        Dim frmBancoP = New frm_CX_MA_Bancos_Pagos
        frmBancoP.MdiParent = Me
        frmBancoP.Show()
    End Sub

    Private Sub LiberaciónDeCuarentameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiberaciónDeCuarentameToolStripMenuItem.Click
        Dim FrmControlLiberacion As New FrmControl_Liberacion
        FrmControlLiberacion.MdiParent = Me
        OpenSubForm(FrmControlLiberacion)
    End Sub

    Private Sub ReportePorVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorVendedorToolStripMenuItem.Click
        Dim frmM As FrmMostrarReporte
        frmM = New FrmMostrarReporte
        frmM.LimpiarControles(frmM.GroupBox1)
        frmM.lblFiltro.Text = "Seleccione un Vendedor"
        frmM.checkMostrarTodos.Text = "Mostrar todos los Vendedores"
        frmM.rbvendedor.Visible = False
        frmM.opcion = "Reporte1"
        frmM.rbresumido.Checked = True
        frmM.AjustarTamaño(True, "Reporte1")
        frmM.Show()
    End Sub

    Private Sub ReportePorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorClienteToolStripMenuItem.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .lblFiltro.Text = "Seleccione un Cliente"
            .checkMostrarTodos.Text = "Mostrar todos los Clientes"
            .CheckGrupoDany.Visible = False
            .rbvendedor.Visible = False
            .opcion = "Reporte2"
            .FlagDetalle = False
            .rbresumido.Checked = True
            .AjustarTamaño(True, "Reporte2")
            .Show()
        End With
    End Sub

    Private Sub VentasPorDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorDiaToolStripMenuItem.Click

        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = "Reporte3"
            .AjustarTamaño(False, "Reporte3")
            .Show()
        End With

    End Sub

    Private Sub StockValorizadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockValorizadoToolStripMenuItem.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = "Reporte4"
            .AjustarTamaño(False, "Reporte4")
            .rbStockValorizado.Checked = True
            .Show()
        End With
    End Sub

    Private Sub ReportePorProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorProductoToolStripMenuItem.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .lblFiltro.Text = "Seleccione un producto"
            .checkMostrarTodos.Text = "Mostrar todos los Productos"
            .rbresumido.Text = "Valorizado"
            .rbresumido.Checked = True
            .rbGrSinValor.Visible = True
            .opcion = "Reporte5"
            .AjustarTamaño(True, "Reporte5")
            .Show()
        End With
    End Sub



    Private Sub TransadosMateriaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransadosMateriaPrimaToolStripMenuItem.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frm_Traslado As New frm_GuiaRemision_tranferencia_Interna_Materia_Prima
                frm_Traslado.MdiParent = Me
                frm_Traslado.TipoTransaccion = "LC"
                frm_Traslado.Show()
            End If
        End If

    End Sub

    Private Sub ReportePendientesDeCobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProvRpt_PendienteCobro.Click
        Dim FrmPendCob_Pag As New FrmReportePendienteCobro_Pago
        FrmPendCob_Pag.MdiParent = Me
        OpenSubForm(FrmPendCob_Pag)
    End Sub

    Private Sub ReporteDocumentosCanceladosDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub ReporteDocumentosPendientesDeCobroPorVencimientoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmDocDiasVencer_Pago As New FrmReporteDoc_Pend_Vencimiento_Pago
        FrmDocDiasVencer_Pago.MdiParent = Me
        FrmDocDiasVencer_Pago.Show()
    End Sub

    Private Sub ConfirmacionDeDespachosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfirmacionDeDespachosToolStripMenuItem.Click
        Dim frmConfirmDesp As New FrmConfirmarDespachos
        frmConfirmDesp.MdiParent = Me
        frmConfirmDesp.Show()
    End Sub

    Private Sub CanjeDeLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanjeDeLetrasToolStripMenuItem.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frmPagosLetras As New FrmLetras_Pagos
                frmPagosLetras.MdiParent = Me
                OpenSubForm(frmPagosLetras)
            End If
        End If

    End Sub

    Private Sub mnuManufacFicherosFormulacion_Click(sender As Object, e As EventArgs) Handles mnuManufacFicherosFormulacion.Click
        Dim FrmFormulacion As New FrmManufactura_Formulas
        FrmFormulacion.MdiParent = Me
        OpenSubForm(FrmFormulacion)
    End Sub

    Private Sub mnuManufacTransPlanificacion_Click(sender As Object, e As EventArgs) Handles mnuManufacTransPlanificacion.Click
        Dim FrmFormulacion As New FrmManufactura_Planeamiento
        FrmFormulacion.MdiParent = Me
        OpenSubForm(FrmFormulacion)
    End Sub

    Private Sub mnuManufacTransVerificaStock_Click(sender As Object, e As EventArgs) Handles mnuManufacTransVerificaStock.Click
        Dim FrmVerifStock As New FrmManufactura_Verificacion_Stock
        FrmVerifStock.MdiParent = Me
        OpenSubForm(FrmVerifStock)
    End Sub


    Private Sub mnuManufacTransGeneracionOF_Click(sender As Object, e As EventArgs) Handles mnuManufacTransGeneracionOF.Click
        Dim frmmanufactura_generacion_of As New FrmManufactura_Generacion_Orden_Fabricacion
        frmmanufactura_generacion_of.MdiParent = Me
        OpenSubForm(frmmanufactura_generacion_of)
    End Sub

    Private Sub AdmBaseConfiguracionDoc_Click(sender As Object, e As EventArgs) Handles AdmBaseConfiguracionDoc.Click
        Dim frmConfigDoc As New FrmConfiguracionDocumentos
        frmConfigDoc.MdiParent = Me
        frmConfigDoc.Show()
    End Sub

    Private Sub mnuClienteReportePendienteCobro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExistenciasPorEntregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciasPorEntregarToolStripMenuItem.Click
        Dim frm As New FrmMostrarReporteII
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = "Reporte6"
            .rbdocumento.Checked = True
            .rbtodos.Checked = True
            .Show()
        End With
    End Sub

    Private Sub ReporteCorrelativosFaltantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCorrelativosFaltantesToolStripMenuItem.Click
        Dim Frmcorrelativo As New Frm_rep_correlativo_faltantes
        Frmcorrelativo.MdiParent = Me
        OpenSubForm(Frmcorrelativo)
    End Sub

    Private Sub ReporteDeProductoAVencerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmProdVenvencer As New FrmReporteProductoVencer
        FrmProdVenvencer.MdiParent = Me
        OpenSubForm(FrmProdVenvencer)
    End Sub

    Private Sub ReporteDeProductoAVencerToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Dim Frmdevolucion As New FrmDevolucion_Principal
        Frmdevolucion.MdiParent = Me
        OpenSubForm(Frmdevolucion)
    End Sub

    Private Sub VentasPorProductoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorProductoClienteToolStripMenuItem.Click
        Dim Frm_Reporte_ProductoxCliente As New Frm_Reporte_ProductoxCliente
        Frm_Reporte_ProductoxCliente.MdiParent = Me
        Frm_Reporte_ProductoxCliente.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim frmRequision_Compra As New FrmRequisiones
        frmRequision_Compra.MdiParent = Me
        frmRequision_Compra.TipoMov = "RQ"
        frmRequision_Compra.Text = "Requisicion por Compras"
        frmRequision_Compra.Name = "REQUISION COMPRA"
        OpenSubForm(frmRequision_Compra)
    End Sub

    Private Sub ServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicioToolStripMenuItem.Click
        Dim frmRequision_serv As New FrmRequisiones
        frmRequision_serv.MdiParent = Me
        frmRequision_serv.TipoMov = "RS"
        frmRequision_serv.Text = "Requisicion por Servicio"
        frmRequision_serv.Name = "REQUISION SERVICIO"
        OpenSubForm(frmRequision_serv)
    End Sub

    Private Sub SolicitudCotizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudCotizacionToolStripMenuItem.Click
        Dim frmSolicitud As New FrmSolicitudCotizacion
        frmSolicitud.MdiParent = Me
        OpenSubForm(frmSolicitud)
    End Sub



    Private Sub RegistroDeComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasToolStripMenuItem1.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frmCompras As New Frm_Compras
                frmCompras.MdiParent = Me
                OpenSubForm(frmCompras)
            End If
        End If

    End Sub

    Private Sub RegistroDeComprasToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim frmRegCompr As New FrmRegCompras
        frmRegCompr.MdiParent = Me
        frmRegCompr.Show()
    End Sub

    Private Sub CuadroComparativoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmcuadro As New Frm_rep_cuadro_comparativo
        frmcuadro.MdiParent = Me
        frmcuadro.Show()
    End Sub



    Private Sub ExistenciasPorEntregarRepMedicosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmMostrarReporteIII
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = "Reporte99"
            .rbdocumento.Checked = True
            .rbtodos.Checked = True
            .Show()
        End With
    End Sub

    Private Sub PuntoDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuntoDeVentaToolStripMenuItem.Click
        Dim frmPuntoV As New frmPuntosVenta
        frmPuntoV.MdiParent = Me
        frmPuntoV.Show()
    End Sub

    Private Sub TipoDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDePagoToolStripMenuItem.Click
        Dim frmPago_Pago As New frm_TipoPago_pago
        frmPago_Pago.MdiParent = Me
        frmPago_Pago.Show()
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        Dim FrmFactRapida As New FrmFacturacionRapida
        FrmFactRapida.MdiParent = Me
        OpenSubForm(FrmFactRapida)
    End Sub

    Private Sub OrdenDeServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeServicioToolStripMenuItem.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmOrdenServicio As New Frm_Orden_Servicio
                FrmOrdenServicio.MdiParent = Me
                OpenSubForm(FrmOrdenServicio)
            End If
        End If

    End Sub

    Private Sub LiberaciónDeCuarentenaPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiberaciónDeCuarentenaPTToolStripMenuItem.Click
        Dim FrmLib_PT As New FrmControl_Liberacion_PT
        FrmLib_PT.MdiParent = Me
        OpenSubForm(FrmLib_PT)
    End Sub

    Private Sub ReporteProductosCuarentenaMPToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReporteProductosCuarentenaPTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ReporteDeProductosMayorVentaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuAlmFicherosTipoArticulos_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosTipoArticulos.Click
        Dim Frm_part_type As New Frm_Tipo_Articulo
        Frm_part_type.MdiParent = Me
        OpenSubForm(Frm_part_type)
    End Sub

    Private Sub DocumentosReToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosReToolStripMenuItem.Click
        Dim frm_consulta_req As New Frm_Consulta_requisiones
        frm_consulta_req.MdiParent = Me
        OpenSubForm(frm_consulta_req)
    End Sub

    Private Sub ActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivoToolStripMenuItem.Click
        frmActivo = New frm_AF_MA_Activo
        frmActivo.MdiParent = Me
        frmActivo.Show()
    End Sub

    Private Sub FamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliasToolStripMenuItem.Click
        frmFamilia = New frm_AF_MA_Familia
        frmFamilia.MdiParent = Me
        OpenSubForm(frmFamilia)

    End Sub

    Private Sub GrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoToolStripMenuItem.Click
        frmgrupo = New frm_AF_MA_Grupo
        frmgrupo.MdiParent = Me
        OpenSubForm(frmgrupo)
    End Sub

    Private Sub SubGrupoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubGrupoToolStripMenuItem.Click
        frmsubgrupo = New frm_AF_MA_SubGrupo
        frmsubgrupo.MdiParent = Me
        OpenSubForm(frmsubgrupo)
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        frmmarca = New frm_AF_MA_Marca
        frmmarca.MdiParent = Me
        OpenSubForm(frmmarca)
    End Sub

    Private Sub TipoDePagoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDePagoToolStripMenuItem1.Click
        frmtipopago = New frm_AF_MA_TipoPago
        frmtipopago.MdiParent = Me
        OpenSubForm(frmtipopago)
    End Sub

    Private Sub UbicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbicacionToolStripMenuItem.Click
        frmubicacion = New frm_AF_MA_Ubicacion
        frmubicacion.MdiParent = Me
        OpenSubForm(frmubicacion)
    End Sub

    Private Sub CentroDeCostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroDeCostoToolStripMenuItem.Click
        frmcentrocosto = New frm_AF_MA_CentroCosto
        frmcentrocosto.MdiParent = Me
        OpenSubForm(frmcentrocosto)
    End Sub

    Private Sub AreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaToolStripMenuItem.Click
        frmareaaf = New frm_AF_MA_Area
        frmareaaf.MdiParent = Me
        OpenSubForm(frmareaaf)
    End Sub

    Private Sub ClToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClToolStripMenuItem.Click
        frmclase = New frm_AF_MA_Clase
        frmclase.MdiParent = Me
        OpenSubForm(frmclase)
    End Sub

    Private Sub USoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USoToolStripMenuItem.Click
        frmuso = New frm_AF_MA_Uso
        frmuso.MdiParent = Me
        OpenSubForm(frmuso)
    End Sub

    Private Sub NivelDeObsolenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NivelDeObsolenciaToolStripMenuItem.Click
        frmnivelobs = New frm_AF_MA_NivelObso
        frmnivelobs.MdiParent = Me
        OpenSubForm(frmnivelobs)
    End Sub

    Private Sub EstadoFisicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoFisicoToolStripMenuItem.Click
        frmestadofisico = New frm_AF_MA_EstadoFisico
        frmestadofisico.MdiParent = Me
        OpenSubForm(frmestadofisico)
    End Sub

    Private Sub TipoDeMantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeMantenimientoToolStripMenuItem.Click
        frmtipomante = New frm_AF_MA_TipoManteni
        frmtipomante.MdiParent = Me
        OpenSubForm(frmtipomante)
    End Sub

    Private Sub ResponsableActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResponsableActivoToolStripMenuItem.Click
        frmresponsableActivo = New frm_AF_MA_Responsable_activo
        frmresponsableActivo.MdiParent = Me
        OpenSubForm(frmresponsableActivo)
    End Sub

    Private Sub ResponsableEjecutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResponsableEjecutorToolStripMenuItem.Click
        frmrespoejecutor = New frm_AF_MA_ResponsableEje
        frmrespoejecutor.MdiParent = Me
        OpenSubForm(frmrespoejecutor)
    End Sub

    Private Sub TerceroEjecutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerceroEjecutorToolStripMenuItem.Click
        frmterceroejecutor = New frm_AF_MA_TercerosEje
        frmterceroejecutor.MdiParent = Me
        OpenSubForm(frmterceroejecutor)
    End Sub

    Private Sub DepreciacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepreciacionToolStripMenuItem.Click
        frmcalculodepre = New frm_AF_LT_Proc_Depreciar
        frmcalculodepre.MdiParent = Me
        OpenSubForm(frmcalculodepre)
    End Sub

    Private Sub ContabilizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ContabilizarToolStripMenuItem.Click
        frmcontabilizar = New frm_AF_LT_Contabilizar
        frmcontabilizar.MdiParent = Me
        OpenSubForm(frmcontabilizar)
    End Sub

    Private Sub TransferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciasToolStripMenuItem.Click
        frmtransferencias = New frm_AF_LT_Transferencias
        frmtransferencias.MdiParent = Me
        OpenSubForm(frmtransferencias)
    End Sub

    Private Sub MantenimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientosToolStripMenuItem.Click
        frmantenimientos = New frm_AF_LT_Mantenimientos
        frmantenimientos.MdiParent = Me
        OpenSubForm(frmantenimientos)
    End Sub

    Private Sub BajaDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeActivosToolStripMenuItem.Click
        frmBajaActivo = New frm_AF_LT_BajaActivo
        frmBajaActivo.MdiParent = Me
        OpenSubForm(frmBajaActivo)
    End Sub

    Private Sub TomaDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TomaDeInventariosToolStripMenuItem.Click
        frmTomaInventario = New frm_AF_LT_TomaInventario
        frmTomaInventario.MdiParent = Me
        OpenSubForm(frmTomaInventario)
    End Sub

    Private Sub RegDeMejorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegDeMejorasToolStripMenuItem.Click
        frmMejoras = New frm_AF_LT_Mejoras
        frmMejoras.MdiParent = Me
        OpenSubForm(frmMejoras)
    End Sub

    Private Sub DepreciacionPorActivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepreciacionPorActivoToolStripMenuItem.Click
        frmRep_depre_x_activo = New frm_AF_RP_Depre_x_Activo
        frmRep_depre_x_activo.MdiParent = Me
        OpenSubForm(frmRep_depre_x_activo)
    End Sub

    Private Sub DeterminacionDeLaDepresiacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeterminacionDeLaDepresiacionToolStripMenuItem.Click
        frmRep_determinacion_depre = New frm_AF_RP_deter_depreci
        frmRep_determinacion_depre.MdiParent = Me
        OpenSubForm(frmRep_determinacion_depre)
    End Sub

    Private Sub ListaDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeActivosToolStripMenuItem.Click
        frmRep_ListaActivo = New frm_AF_RP_Lis_Activos
        frmRep_ListaActivo.MdiParent = Me
        OpenSubForm(frmRep_ListaActivo)
    End Sub

    Private Sub ListaDeTransferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeTransferenciasToolStripMenuItem.Click
        frmRepTransferencia = New frm_AF_RP_Lista_Transfe
        frmRepTransferencia.MdiParent = Me
        OpenSubForm(frmRepTransferencia)
    End Sub

    Private Sub ReporteIngresosACuarentenaPTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransportistasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransportistasToolStripMenuItem1.Click
        Dim frm_transportista As New Frm_MA_Transportistas
        frm_transportista.MdiParent = Me
        OpenSubForm(frm_transportista)
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosToolStripMenuItem.Click
        Dim frm_Vehiculo As New Frm_MA_Vehiculo
        frm_Vehiculo.MdiParent = Me
        OpenSubForm(frm_Vehiculo)
    End Sub

    Private Sub EmpresaDeTransporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaDeTransporteToolStripMenuItem.Click
        Dim frm_Empresa As New Frm_MA_Empresa_Transporte
        frm_Empresa.MdiParent = Me
        OpenSubForm(frm_Empresa)
    End Sub

    Private Sub TramasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TramasToolStripMenuItem.Click
        Dim frm_tramas As New Frm_MA_Tramos
        frm_tramas.MdiParent = Me
        OpenSubForm(frm_tramas)
    End Sub

    Private Sub ReporteProyeccionDeCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Frmproycobranza As New FrmProyeccionCobranza
        Frmproycobranza.MdiParent = Me
        OpenSubForm(Frmproycobranza)
    End Sub

    Private Sub ReporteMorosidadDeCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Frmmorosidadcobranza As New FrmMorosidadCobranza
        Frmmorosidadcobranza.MdiParent = Me
        OpenSubForm(Frmmorosidadcobranza)
    End Sub

    Private Sub ReporteCobranzaSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmrepcobranzasemanal As New FrmRepCobranzaSemanal
        frmrepcobranzasemanal.MdiParent = Me
        OpenSubForm(frmrepcobranzasemanal)
    End Sub

    Private Sub RegistroDeVentasCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmregventascobranza As New FrmRegVentasCobranza
        frmregventascobranza.MdiParent = Me
        OpenSubForm(frmregventascobranza)
    End Sub

    Private Sub ReporteCobranzaDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmrepcobranzadiario As New FrmRepCobranzaDiario
        frmrepcobranzadiario.MdiParent = Me
        OpenSubForm(frmrepcobranzadiario)
    End Sub

    Private Sub PendientesPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendientesPorClienteToolStripMenuItem.Click
        Dim FrmPendienteCobr As New FrmReportePendienteCobro
        FrmPendienteCobr.MdiParent = Me
        OpenSubForm(FrmPendienteCobr)
    End Sub

    Private Sub PendientesPorVencimientoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim FrmDocDiasVencer As New FrmReporteDoc_Pend_Vencimiento
        FrmDocDiasVencer.MdiParent = Me
        FrmDocDiasVencer.Show()
    End Sub

    Private Sub RegistroDeVentasCobranzaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasCobranzaToolStripMenuItem1.Click
        Dim frmregventascobranza As New FrmRegVentasCobranza
        frmregventascobranza.MdiParent = Me
        OpenSubForm(frmregventascobranza)
    End Sub

    Private Sub ProyeccionDeCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyeccionDeCobranzaToolStripMenuItem.Click
        Dim Frmproycobranza As New FrmProyeccionCobranza
        Frmproycobranza.MdiParent = Me
        OpenSubForm(Frmproycobranza)
    End Sub

    Private Sub MorosidadDeCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MorosidadDeCobranzaToolStripMenuItem.Click
        Dim Frmmorosidadcobranza As New FrmMorosidadCobranza
        Frmmorosidadcobranza.MdiParent = Me
        OpenSubForm(Frmmorosidadcobranza)
    End Sub

    Private Sub CobranzaSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobranzaSemanalToolStripMenuItem.Click
        Dim frmrepcobranzasemanal As New FrmRepCobranzaSemanal
        frmrepcobranzasemanal.MdiParent = Me
        OpenSubForm(frmrepcobranzasemanal)
    End Sub

    Private Sub CobranzaDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobranzaDiarioToolStripMenuItem.Click
        Dim frmrepcobranzadiario As New FrmRepCobranzaDiario
        frmrepcobranzadiario.MdiParent = Me
        OpenSubForm(frmrepcobranzadiario)
    End Sub

    Private Sub CobranzaEfectuadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobranzaEfectuadaToolStripMenuItem.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = ""
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub RegistroDeComprasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasToolStripMenuItem3.Click
        Dim frmRegCompr As New FrmRegCompras
        frmRegCompr.MdiParent = Me
        frmRegCompr.Show()
    End Sub

    Private Sub CuadroComparativoDeCotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadroComparativoDeCotizacionesToolStripMenuItem.Click
        Dim frmcuadro As New Frm_rep_cuadro_comparativo
        frmcuadro.MdiParent = Me
        frmcuadro.Show()
    End Sub

    Private Sub PagosEfectuadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosEfectuadosToolStripMenuItem.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "" 'varios
        frmDocCanPag.Text = "Reporte de Pagos"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub ProyeccionDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyeccionDePagosToolStripMenuItem.Click
        Dim frmproypagos As New FrmProyeccionPagos
        frmproypagos.MdiParent = Me
        OpenSubForm(frmproypagos)
    End Sub

    Private Sub MorosidadDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MorosidadDePagosToolStripMenuItem.Click
        Dim frmmorosidadpagos As New FrmMorosidadPagos
        frmmorosidadpagos.MdiParent = Me
        OpenSubForm(frmmorosidadpagos)
    End Sub

    Private Sub PagosSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosSemanalToolStripMenuItem.Click
        Dim frmpagossemanal As New FrmPagosSemanal
        frmpagossemanal.MdiParent = Me
        OpenSubForm(frmpagossemanal)
    End Sub

    Private Sub PagosDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosDiarioToolStripMenuItem.Click
        Dim frmreppagosdiario As New FrmRepPagosDiario
        frmreppagosdiario.MdiParent = Me
        OpenSubForm(frmreppagosdiario)
    End Sub

    Private Sub EstadoDeCuentaPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaPorClienteToolStripMenuItem.Click
        Dim frmRep_EstadoCuenta_Cliente As New FrmRepEstadoCuentaCiente
        frmRep_EstadoCuenta_Cliente.MdiParent = Me
        OpenSubForm(frmRep_EstadoCuenta_Cliente)
    End Sub

    Private Sub ResumneDeCobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumneDeCobranzaToolStripMenuItem.Click
        Dim frmrepresumencobranza As New FrmRepResumenCobranza
        frmrepresumencobranza.MdiParent = Me
        OpenSubForm(frmrepresumencobranza)
    End Sub

    Private Sub SituacionDeLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituacionDeLetrasToolStripMenuItem.Click
        frmestadoletrascobranza = New FrmEstadoLetrasCobranzas
        frmestadoletrascobranza.MdiParent = Me
        frmestadoletrascobranza.Show()
    End Sub

    Private Sub SituaciónDeLetrasPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituaciónDeLetrasPagosToolStripMenuItem.Click
        frmestadoletraspagos = New FrmEstadoLetrasPagos
        frmestadoletraspagos.MdiParent = Me
        frmestadoletraspagos.Show()
    End Sub

    Private Sub MantenimientoLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoLetrasToolStripMenuItem.Click
        frmmantenimientoletraspagos = New FrmAceptacionLetrasPagos
        frmmantenimientoletraspagos.MdiParent = Me
        OpenSubForm(frmmantenimientoletraspagos)
    End Sub

    Private Sub ResumenDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDePagosToolStripMenuItem.Click
        Dim frmrepresumenpagos As New FrmRepResumenPagos
        frmrepresumenpagos.MdiParent = Me
        OpenSubForm(frmrepresumenpagos)
    End Sub

    Private Sub RegistroDeComprasPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasPagosToolStripMenuItem.Click
        Dim frmregistrocompraspagos As New FrmRegComprasPagos
        frmregistrocompraspagos.MdiParent = Me
        OpenSubForm(frmregistrocompraspagos)
    End Sub

    Private Sub ManejoDeCarteraDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManejoDeCarteraDeProveedoresToolStripMenuItem.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frmcarteraproveedores As New FrmLetras_ManejoDocumentosPendientes_Pagos
                frmcarteraproveedores.MdiParent = Me
                OpenSubForm(frmcarteraproveedores)
            End If
        End If

    End Sub

    Private Sub PorArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorArticuloToolStripMenuItem.Click
        Dim FrmReporteKardexReferencia As New FrmReporteKardex
        FrmReporteKardexReferencia.MdiParent = Me
        FrmReporteKardexReferencia.NombreReporte = "ReporteKardexReferenciaArticulo"
        FrmReporteKardexReferencia.AjustarTamaño()
        OpenSubForm(FrmReporteKardexReferencia)
    End Sub

    Private Sub PorLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorLoteToolStripMenuItem.Click
        Dim FrmReporteKardexReferencia As New FrmReporteKardex
        FrmReporteKardexReferencia.MdiParent = Me
        FrmReporteKardexReferencia.NombreReporte = "ReporteKardexReferenciaLote"
        FrmReporteKardexReferencia.AjustarTamaño()
        OpenSubForm(FrmReporteKardexReferencia)
    End Sub

    Private Sub InventarioValorizadoPorEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioValorizadoPorEmpresaToolStripMenuItem.Click
        Dim frm_IV_Empresa As New FrmInventarioValorizadoEmpresa
        frm_IV_Empresa.MdiParent = Me
        frm_IV_Empresa.Show()
    End Sub

    Private Sub DocumentosDeAlmacenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DocumentosDeAlmacenToolStripMenuItem1.Click
        Dim FrmInv_Documentos As New FrmInventarioDocumentos
        FrmInv_Documentos.MdiParent = Me
        FrmInv_Documentos.Show()
    End Sub

    Private Sub ResumenDeTransaccionesPorArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeTransaccionesPorArticuloToolStripMenuItem.Click
        Dim FrmTransaccionesArticulo As New FrmTransaccionesArticulo
        FrmTransaccionesArticulo.MdiParent = Me
        FrmTransaccionesArticulo.Show()
    End Sub

    Private Sub KardexDeArticulosAVencerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexDeArticulosAVencerToolStripMenuItem.Click
        Dim FrmProdVenvencer As New FrmReporteProductoVencer
        FrmProdVenvencer.MdiParent = Me
        FrmProdVenvencer.Show()
    End Sub

    Private Sub StockDeArticulosMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeArticulosMensualToolStripMenuItem.Click
        Dim FRMSTKMENSUAL As New FrmStkMensual
        FRMSTKMENSUAL.MdiParent = Me
        FRMSTKMENSUAL.Show()
    End Sub

    Private Sub StockDeLotesMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeLotesMensualToolStripMenuItem.Click
        Dim FRMSTKLOTESMENSUAL As New FrmStkLotesMensual
        FRMSTKLOTESMENSUAL.MdiParent = Me
        FRMSTKLOTESMENSUAL.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Dim FRMSTK As New FrmStk
        FRMSTK.MdiParent = Me
        FRMSTK.Show()
    End Sub

    Private Sub ProductosCuarentenaMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosCuarentenaMPToolStripMenuItem.Click
        Dim frmcuarentena_mp As New FrmReporteProducto_Cuarentena
        frmcuarentena_mp.MdiParent = Me
        frmcuarentena_mp.NombreReporte = "MP"
        frmcuarentena_mp.Text = "Reporte Producto en Cuarentena MP"
        frmcuarentena_mp.Name = "Cuarentena_MP"
        OpenSubForm(frmcuarentena_mp)
    End Sub

    Private Sub ProductosCuarentenaPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosCuarentenaPTToolStripMenuItem.Click
        Dim frmcuarentena_mp As New FrmReporteProducto_Cuarentena
        frmcuarentena_mp.MdiParent = Me
        frmcuarentena_mp.NombreReporte = "PT"
        frmcuarentena_mp.Text = "Reporte Producto en Cuarentena PT"
        frmcuarentena_mp.Name = "Cuarentena PT"
        OpenSubForm(frmcuarentena_mp)
    End Sub

    Private Sub RepIngresosACuarentenaPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepIngresosACuarentenaPTToolStripMenuItem.Click
        Dim frmIngresosCuarentena As New FrmReporteProducto_Cuarentena_PT
        frmIngresosCuarentena.MdiParent = Me
        OpenSubForm(frmIngresosCuarentena)
    End Sub

    Private Sub RankingDeVentasPorArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingDeVentasPorArticuloToolStripMenuItem.Click
        Dim FrmProd_venta As New FrmReporteProducto_Mayor_Venta
        FrmProd_venta.MdiParent = Me
        OpenSubForm(FrmProd_venta)
    End Sub

    Private Sub mnuAlmTransReporteTransacciones_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StockPoLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockPoLoteToolStripMenuItem.Click
        Dim FrmReporteKardex_lote As New FrmReporteKardex_lote
        FrmReporteKardex_lote.MdiParent = Me
        FrmReporteKardex_lote.Show()
    End Sub

    Private Sub ReportePreciosYDescuentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePreciosYDescuentosToolStripMenuItem.Click
        Dim frmprecdescuentos As New FrmReporteProdPrecDesc
        frmprecdescuentos.MdiParent = Me
        OpenSubForm(frmprecdescuentos)
    End Sub

    Private Sub ReporteDeVentasPorVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasPorVendedorToolStripMenuItem.Click
        Dim frmrepventasvendedor As New FrmRepVentasxVendedor
        frmrepventasvendedor.MdiParent = Me
        OpenSubForm(frmrepventasvendedor)
    End Sub

    Private Sub LibroDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDiarioToolStripMenuItem.Click
        Dim frmLibroDiario As New frm_CO_RP_LibDiario
        frmLibroDiario.MdiParent = Me
        OpenSubForm(frmLibroDiario)
    End Sub

    Private Sub VentaRapidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaRapidaToolStripMenuItem.Click
        ''Verificacion Tipo Cambio
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frm_Facturacion_tienda As New LibCobranzas.FrmFacturacion_Tienda
                frm_Facturacion_tienda.MdiParent = Me
                OpenSubForm(frm_Facturacion_tienda)
            End If
        End If
    End Sub

    Private Sub ExportarMovimientosDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarMovimientosDelSistemaToolStripMenuItem.Click
        Dim frmimportarexportarmovimientos As New FrmImportarExportarMovimientos
        frmimportarexportarmovimientos.MdiParent = Me
        OpenSubForm(frmimportarexportarmovimientos)
    End Sub

    Private Sub LibrosElectronicosPLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosElectronicosPLEToolStripMenuItem.Click
        Dim frmlibrosple As New CO_PR_PLE
        frmlibrosple.MdiParent = Me
        OpenSubForm(frmlibrosple)
    End Sub

    Private Sub mnuClienteFicheroListaPrecios_Click(sender As Object, e As EventArgs) Handles mnuClienteFicheroListaPrecios.Click
        Dim frmlistaprecios As New LibCobranzas.FrmListaPrecios
        frmlistaprecios.MdiParent = Me
        OpenSubForm(frmlistaprecios)
    End Sub

    Private Sub CanjeDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanjeDeChequesToolStripMenuItem.Click


        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmchequescobranza = New FrmCheques
                frmchequescobranza.MdiParent = Me
                OpenSubForm(frmchequescobranza)
            End If
        End If

    End Sub

    Private Sub MovimientosDeCajaChicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeCajaChicaToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmmovimientoscajachica = New FrmMovimientosCaja
                frmmovimientoscajachica.MdiParent = Me
                OpenSubForm(frmmovimientoscajachica)
            End If
        End If

    End Sub

    Private Sub ConceptosDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosDeMovimientosToolStripMenuItem.Click
        frmconceptoscajachica = New FrmConceptos
        frmconceptoscajachica.MdiParent = Me
        OpenSubForm(frmconceptoscajachica)
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        frmpersonalcajachica = New FrmPersonal
        frmpersonalcajachica.MdiParent = Me
        OpenSubForm(frmpersonalcajachica)
    End Sub

    Private Sub DocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosToolStripMenuItem.Click
        frmdocumentoscajachica = New FrmDocumentos
        frmdocumentoscajachica.MdiParent = Me
        OpenSubForm(frmdocumentoscajachica)
    End Sub

    Private Sub LiquidacionDeOFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionDeOFToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmmanufactura_liquidacion = New FrmManufactura_Liquidacion
                frmmanufactura_liquidacion.MdiParent = Me
                OpenSubForm(frmmanufactura_liquidacion)
            End If
        End If

    End Sub

    Private Sub CentrosDeCostosComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosDeCostosComprasToolStripMenuItem.Click
        frmcentroscostoscompras = New FrmCentroCostosCompra
        frmcentroscostoscompras.MdiParent = Me
        OpenSubForm(frmcentroscostoscompras)
    End Sub

    Private Sub MovimientosPorCentroDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosPorCentroDeCostosToolStripMenuItem.Click
        frmmovcentroscostoscompras = New FrmRepCentroCostosCompra
        frmmovcentroscostoscompras.MdiParent = Me
        OpenSubForm(frmmovcentroscostoscompras)
    End Sub

    Private Sub CanjeDeChequesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CanjeDeChequesToolStripMenuItem1.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcanjechequespagos = New FrmChequesPagos
                frmcanjechequespagos.MdiParent = Me
                OpenSubForm(frmcanjechequespagos)
            End If
        End If

    End Sub


    Private Sub StockMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMensualToolStripMenuItem.Click
        frmauditoria_stock_mensual = New FrmAuditoria_StockMensual
        frmauditoria_stock_mensual.MdiParent = Me
        OpenSubForm(frmauditoria_stock_mensual)
    End Sub

    Private Sub RegistroDeLicitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeLicitacionesToolStripMenuItem.Click
        frmlistalicitaciones = New Frm_Registro_Licitaciones
        frmlistalicitaciones.MdiParent = Me
        OpenSubForm(frmlistalicitaciones)
    End Sub

    Private Sub ReporteDeVendedorPoLicitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmventaslicitacion = New Frm_RPT_Vendedor_Licitaciones
        frmventaslicitacion.MdiParent = Me
        OpenSubForm(frmventaslicitacion)
    End Sub

    Private Sub ContabilizarFacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilizarFacturacionToolStripMenuItem.Click
        frmFacturacion_Contab = New FrmFacturacion_Contabilizacion
        frmFacturacion_Contab.MdiParent = Me
        OpenSubForm(frmFacturacion_Contab)
    End Sub

    Private Sub ImprentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprentaToolStripMenuItem.Click
        frmrequisiciones_imprentas = New FrmRequisiciones_Imprenta
        frmrequisiciones_imprentas.MdiParent = Me
        frmrequisiciones_imprentas.TipoMov = "RI"
        frmrequisiciones_imprentas.Text = "Requisición de Imprenta"
        frmrequisiciones_imprentas.Name = "REQUISION IMPRENTA"
        OpenSubForm(frmrequisiciones_imprentas)
    End Sub

    Private Sub OrdenDeServicioImprentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeServicioImprentaToolStripMenuItem.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frmorden_servicio_imprenta As New Frm_Orden_Servicio_Imprenta
                frmorden_servicio_imprenta.MdiParent = Me
                OpenSubForm(frmorden_servicio_imprenta)
            End If
        End If
    End Sub

    Private Sub ReporteDaotDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDaotDeVentasToolStripMenuItem.Click
        frmdaot_ventas = New FrmRep_Daot_Ventas
        frmdaot_ventas.MdiParent = Me
        OpenSubForm(frmdaot_ventas)
    End Sub

    Private Sub BalancesAlcoholToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalancesAlcoholToolStripMenuItem.Click
        Dim frmreporte_balances_alcohol As New FrmReporteKardex_BA
        frmreporte_balances_alcohol.MdiParent = Me
        frmreporte_balances_alcohol.NombreReporte = "ReporteKardexReferenciaArticulo"
        OpenSubForm(frmreporte_balances_alcohol)
    End Sub

    Private Sub ReporteDeGuiasDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGuiasDeVentaToolStripMenuItem.Click
        Dim frmRpt_Guias_Ventas As New FrmRpt_Guias_Venta
        frmRpt_Guias_Ventas.MdiParent = Me
        OpenSubForm(frmRpt_Guias_Ventas)
    End Sub

    Private Sub mnuAlmFicherosTiposDocumento_Click(sender As Object, e As EventArgs) Handles mnuAlmFicherosTiposDocumento.Click
        Dim frmTipoDocumento As New Frm_Tipo_Documento
        frmTipoDocumento.MdiParent = Me
        OpenSubForm(frmTipoDocumento)
    End Sub

    Private Sub ReporteDeFTVsLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeFTVsLetrasToolStripMenuItem.Click
        Dim frmRpt_FT_Letras As New Frm_FT_Letras
        frmRpt_FT_Letras.MdiParent = Me
        OpenSubForm(frmRpt_FT_Letras)
    End Sub

    Private Sub ReporteDeCanjeDeLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCanjeDeLetrasToolStripMenuItem.Click
        Dim frmCanjeLetras As New Frm_Canje_Letras
        frmCanjeLetras.MdiParent = Me
        OpenSubForm(frmCanjeLetras)
    End Sub

    Private Sub ReporteEstadoLetras_Click(sender As Object, e As EventArgs) Handles ReporteEstadoLetras.Click
        Dim frmRepEstadosLetras As New Frm_Rep_Estados_Letras
        frmRepEstadosLetras.MdiParent = Me
        OpenSubForm(frmRepEstadosLetras)
    End Sub

    Private Sub DAOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAOTToolStripMenuItem.Click
        Dim frmDaot As New frm_CO_RP_Daot
        frmDaot.MdiParent = Me
        OpenSubForm(frmDaot)
    End Sub

    Private Sub ComprasPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProveedorToolStripMenuItem.Click
        Dim frmComprasProveedor As New Frm_Reporte_ProvxProducto
        frmComprasProveedor.MdiParent = Me
        OpenSubForm(frmComprasProveedor)
    End Sub

    Private Sub ImportaciónDeRetencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportaciónDeRetencionesToolStripMenuItem.Click
        Dim frmImportarRetenciones As New Frm_AF_PR_Incorporacion_Automatica
        frmImportarRetenciones.MdiParent = Me
        OpenSubForm(frmImportarRetenciones)
    End Sub

    Private Sub CobroDeClientesRetencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroDeClientesRetencionesToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob_CR = New Frm_CX_LT_PlanillaCob_CR
                frmcx_planillaCob_CR.MdiParent = Me
                OpenSubForm(frmcx_planillaCob_CR)
            End If
        End If
    End Sub

    Private Sub ConsultasDeMovPorOrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasDeMovPorOrdenDeCompraToolStripMenuItem.Click
        Dim frmRepMovOrdenes As New Frm_Rep_Mov_Orden_C_S_I
        frmRepMovOrdenes.MdiParent = Me
        OpenSubForm(frmRepMovOrdenes)
    End Sub

    Private Sub BCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCPToolStripMenuItem.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "01" 'bcp
                frmcx_planillaCob.Text = "Planilla de Cobranza - BCP"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub BIFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIFToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "02" 'BIF
                frmcx_planillaCob.Text = "Planilla de Cobranza - BIF"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub SCOTIABANKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCOTIABANKToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "03" 'SCOTIABANK
                frmcx_planillaCob.Text = "Planilla de Cobranza - SCOTIABANK"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub VARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VARIOSToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "04" 'VARIOS
                frmcx_planillaCob.Text = "Planilla de Cobranza - VARIOS"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub BCPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BCPToolStripMenuItem1.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmPagos As New frm_CX_LT_PlanillaPagos
                FrmPagos.MdiParent = Me
                FrmPagos.GRUPO_PAGOS = "01" 'BCP
                FrmPagos.Text = "Planilla de Pagos - BCP"
                OpenSubForm(FrmPagos)
            End If
        End If
    End Sub

    Private Sub BIFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BIFToolStripMenuItem1.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmPagos As New frm_CX_LT_PlanillaPagos
                FrmPagos.MdiParent = Me
                FrmPagos.GRUPO_PAGOS = "02" 'bif
                FrmPagos.Text = "Planilla de Pagos - BIF"
                OpenSubForm(FrmPagos)
            End If
        End If
    End Sub

    Private Sub SCOTIABANKToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SCOTIABANKToolStripMenuItem1.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmPagos As New frm_CX_LT_PlanillaPagos
                FrmPagos.MdiParent = Me
                FrmPagos.GRUPO_PAGOS = "03" 'scotiabank
                FrmPagos.Text = "Planilla de Pagos - SCOTIABANK"
                OpenSubForm(FrmPagos)
            End If
        End If
    End Sub

    Private Sub VARIOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VARIOSToolStripMenuItem1.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmPagos As New frm_CX_LT_PlanillaPagos
                FrmPagos.MdiParent = Me
                FrmPagos.GRUPO_PAGOS = "04" 'varios
                FrmPagos.Text = "Planilla de Pagos - VARIOS"
                OpenSubForm(FrmPagos)
            End If
        End If
    End Sub

    Private Sub GeneraciónDeOrdenDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónDeOrdenDeProducciónToolStripMenuItem.Click
        Dim frm_Genera_OP As New Frm_Generar_OP
        frm_Genera_OP.MdiParent = Me
        OpenSubForm(frm_Genera_OP)
    End Sub

    Private Sub LiquidaciónDeOrdenDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidaciónDeOrdenDeProducciónToolStripMenuItem.Click
        Dim frm_Liquidacion_OP As New Frm_Liquidar_OP
        frm_Liquidacion_OP.MdiParent = Me
        OpenSubForm(frm_Liquidacion_OP)
    End Sub

    Private Sub ReporteGastoMovilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteGastoMovilidadToolStripMenuItem.Click
        Dim frmRep_Gasto_Movilidad As New FrmRep_Gasto_Movilidad
        frmRep_Gasto_Movilidad.MdiParent = Me
        OpenSubForm(frmRep_Gasto_Movilidad)
    End Sub

    Private Sub DocumentoVentaSUNATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentoVentaSUNATToolStripMenuItem.Click
        Dim frmVentas_Sunat As New FrmFacturacion_SUNAT
        frmVentas_Sunat.MdiParent = Me
        OpenSubForm(frmVentas_Sunat)
    End Sub

    Private Sub Reporte_Precios_Anual_Click(sender As Object, e As EventArgs) Handles Reporte_Precios_Anual.Click
        Dim frm_Reporte_Precios_Anual As New LibCobranzas.FrmVentasMensualArticulo
        frm_Reporte_Precios_Anual.MdiParent = Me
        OpenSubForm(frm_Reporte_Precios_Anual)
    End Sub

    Private Sub RetencionesPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetencionesPorClienteToolStripMenuItem.Click
        Dim frmRep_Retenciones_Cliente As New FrmRep_Comp_Retencion
        frmRep_Retenciones_Cliente.MdiParent = Me
        OpenSubForm(frmRep_Retenciones_Cliente)
    End Sub

    Private Sub ReportePorEstadoDeLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePorEstadoDeLetrasToolStripMenuItem.Click
        Dim frmRep_Estado_Letras_Pagos As New Frm_Rep_Estados_Letras_Pagos
        frmRep_Estado_Letras_Pagos.MdiParent = Me
        OpenSubForm(frmRep_Estado_Letras_Pagos)
    End Sub

    Private Sub ReporteVentasModoPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasModoPagoToolStripMenuItem.Click
        Dim frm_Rep_Modo_Pago As New Frm_Reporte_Diario_ModoPago
        frm_Rep_Modo_Pago.MdiParent = Me
        OpenSubForm(frm_Rep_Modo_Pago)
    End Sub

    Private Sub CobroDeClientesProformasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroDeClientesProformasToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob_PF = New Frm_CX_LT_PlanillaCob_PF
                frmcx_planillaCob_PF.MdiParent = Me
                frmcx_planillaCob_PF.GRUPO_COBRANZA = "" 'PF
                frmcx_planillaCob_PF.Text = ""
                OpenSubForm(frmcx_planillaCob_PF)
            End If
        End If
    End Sub

    Private Sub ConsultaDeStockAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeStockAnualToolStripMenuItem.Click
        Dim frmConsultaStock_Anual As New FrmConsultaStock_Mensual
        frmConsultaStock_Anual.MdiParent = Me
        OpenSubForm(frmConsultaStock_Anual)
    End Sub

    Private Sub INTERBANKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERBANKToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "05" 'INTERBANK
                frmcx_planillaCob.Text = "Planilla de Cobranza - INTERBANK"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub LETRASENDSCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LETRASENDSCTOToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "06" 'VARIOS
                frmcx_planillaCob.Text = "Planilla de Cobranza - DSCTO LETRAS - FACTORING"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub mnuRecHumFicherosPersonal_Click(sender As Object, e As EventArgs) Handles mnuRecHumFicherosPersonal.Click
        Dim frm_Personal_RRHH As New Frm_Personal_RR_HH
        frm_Personal_RRHH.MdiParent = Me
        OpenSubForm(frm_Personal_RRHH)
    End Sub

    Private Sub mnuRecHumTransaccionesCalculoPlanilla_Click(sender As Object, e As EventArgs) Handles mnuRecHumTransaccionesCalculoPlanilla.Click
        Dim frm_Pr_Calculo_Planilla As New Frm_PR_Calculo_Planilla
        frm_Pr_Calculo_Planilla.MdiParent = Me
        OpenSubForm(frm_Pr_Calculo_Planilla)
    End Sub

    Private Sub DespachoDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespachoDePedidosToolStripMenuItem.Click
        Dim frm_Despachos_Pedidos As New FrmFacturacionRapida_Despachos
        frm_Despachos_Pedidos.MdiParent = Me
        OpenSubForm(frm_Despachos_Pedidos)
    End Sub

    Private Sub INTERBANKToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INTERBANKToolStripMenuItem1.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim FrmPagos As New frm_CX_LT_PlanillaPagos
                FrmPagos.MdiParent = Me
                FrmPagos.GRUPO_PAGOS = "05" 'INTERBANK
                FrmPagos.Text = "Planilla de Pagos - INTERBANK"
                OpenSubForm(FrmPagos)
            End If
        End If
    End Sub

    Private Sub VentasPorClienteFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorClienteFamiliaToolStripMenuItem.Click
        Dim frm_Rep_Prod_Familia As New Frm_Reporte_Cliente_Producto_Familia
        frm_Rep_Prod_Familia.MdiParent = Me
        OpenSubForm(frm_Rep_Prod_Familia)
    End Sub

    Private Sub ComprasPorProveedorFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProveedorFamiliaToolStripMenuItem.Click
        Dim frm_Rep_Prov_Familia As New Frm_Reporte_ProvxProducto_Familia
        frm_Rep_Prov_Familia.MdiParent = Me
        OpenSubForm(frm_Rep_Prov_Familia)
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim frmCategorias As New frm_AF_MA_Categoria
        frmCategorias.MdiParent = Me
        OpenSubForm(frmCategorias)
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesToolStripMenuItem.Click
        Dim frm_Facturacion_Cotizaciones As New FrmFacturacionCotizacion
        frm_Facturacion_Cotizaciones.MdiParent = Me
        OpenSubForm(frm_Facturacion_Cotizaciones)
    End Sub

    Private Sub mnuClienteReporteVentaMensual_Click(sender As Object, e As EventArgs) Handles mnuClienteReporteVentaMensual.Click
        Dim FrmVentasmensualArt As New LibVentas.FrmVentasMensualArticulo
        FrmVentasmensualArt.MdiParent = Me
        OpenSubForm(FrmVentasmensualArt)
    End Sub

    Private Sub RegistroDeImportacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeImportacionesToolStripMenuItem.Click

        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frm_Compras_Importaciones As New Frm_Compras_Importacion
                frm_Compras_Importaciones.MdiParent = Me
                OpenSubForm(frm_Compras_Importaciones)
            End If
        End If

    End Sub



    Private Sub mnuRecHumFicherosConceptoGral_Click(sender As Object, e As EventArgs) Handles mnuRecHumFicherosConceptoGral.Click
        Dim frmConceptos_Generales_RRHH As New FrmConceptosGenerales
        frmConceptos_Generales_RRHH.MdiParent = Me
        OpenSubForm(frmConceptos_Generales_RRHH)
    End Sub

    Private Sub EstablecimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecimientosToolStripMenuItem.Click
        Dim frm_MA_Establecimientos As New Frm_MA_Establecimientos
        frm_MA_Establecimientos.MdiParent = Me
        OpenSubForm(frm_MA_Establecimientos)
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim frm_MA_Cargos As New Frm_MA_Cargos
        frm_MA_Cargos.MdiParent = Me
        OpenSubForm(frm_MA_Cargos)
    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem1.Click
        Dim frm_MA_Categorias As New Frm_MA_Categorias
        frm_MA_Categorias.MdiParent = Me
        OpenSubForm(frm_MA_Categorias)
    End Sub

    Private Sub FondoDePensionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondoDePensionesToolStripMenuItem.Click
        Dim frm_MA_Fondo_Pensiones As New Frm_MA_Fondo_Pensiones
        frm_MA_Fondo_Pensiones.MdiParent = Me
        OpenSubForm(frm_MA_Fondo_Pensiones)
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        Dim frm_MA_Bancos As New Frm_MA_Bancos
        frm_MA_Bancos.MdiParent = Me
        OpenSubForm(frm_MA_Bancos)
    End Sub

    Private Sub ConceptosVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosVariablesToolStripMenuItem.Click
        Dim frm_MA_Conceptos_Variables As New Frm_MA_Conceptos_Variables
        frm_MA_Conceptos_Variables.MdiParent = Me
        OpenSubForm(frm_MA_Conceptos_Variables)
    End Sub

    Private Sub AdelantoDeQuincenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdelantoDeQuincenaToolStripMenuItem.Click
        Dim frm_PR_Adelanto_Quincena As New Frm_PR_Adelanto_Quincena
        frm_PR_Adelanto_Quincena.MdiParent = Me
        OpenSubForm(frm_PR_Adelanto_Quincena)
    End Sub

    Private Sub ConfigurarEGPPorFunciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarEGPPorFunciónToolStripMenuItem.Click
        Dim frmEGP_x_Funcion As New Frm_Configuracion_Egp_Funcion
        frmEGP_x_Funcion.MdiParent = Me
        OpenSubForm(frmEGP_x_Funcion)
    End Sub

    Private Sub ConfigurarEGPPorNaturalezaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarEGPPorNaturalezaToolStripMenuItem.Click
        Dim frmEGP_x_Naturaleza As New Frm_Configuracion_Egp_Naturaleza
        frmEGP_x_Naturaleza.MdiParent = Me
        OpenSubForm(frmEGP_x_Naturaleza)
    End Sub

    Private Sub ConfigurarBalanceGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarBalanceGeneralToolStripMenuItem.Click
        Dim frm_Conf_Balance_general As New Frm_Configuracion_Balance_General
        frm_Conf_Balance_general.MdiParent = Me
        OpenSubForm(frm_Conf_Balance_general)
    End Sub

    Private Sub GuiaDeRemisiónSUNAtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuiaDeRemisiónSUNAtToolStripMenuItem.Click
        Dim frm_Guias_Sunat As New FrmFacturacion_SUNAT_Guias
        frm_Guias_Sunat.MdiParent = Me
        OpenSubForm(frm_Guias_Sunat)
    End Sub

    Private Sub ContabilizarCálculoDePlanillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilizarCálculoDePlanillasToolStripMenuItem.Click
        Dim frm_Contabiliza_Planilla As New Frm_Contabilizar_Planilla
        frm_Contabiliza_Planilla.MdiParent = Me
        OpenSubForm(frm_Contabiliza_Planilla)
    End Sub

    Private Sub GestionDeAtenciónAClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeAtenciónAClienteToolStripMenuItem.Click
        Dim frm_oportunidad_clientes As New Frm_CX_MA_Oportunidad_clientes
        frm_oportunidad_clientes.MdiParent = Me
        OpenSubForm(frm_oportunidad_clientes)
    End Sub

    Private Sub CierreAperturaDeModulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreAperturaDeModulosToolStripMenuItem.Click
        Dim frm_cierre_modulos As New FrmCierresModulos
        frm_cierre_modulos.MdiParent = Me
        OpenSubForm(frm_cierre_modulos)
    End Sub

    Private Sub mnuCajaBancosRepLiquidacionCobro_Click(sender As Object, e As EventArgs) Handles mnuCajaBancosRepLiquidacionCobro.Click

    End Sub

    Private Sub BCPToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BCPToolStripMenuItem2.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = "01" 'bcp
        frmDoccancelados.Text = "Reporte de Cobranza - BCP"
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub BIFToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BIFToolStripMenuItem2.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = "02" 'BIF
        frmDoccancelados.Text = "Reporte de Cobranza - BIF"
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub SCOTIABANKToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SCOTIABANKToolStripMenuItem2.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = "03" 'SCOTIABANK
        frmDoccancelados.Text = "Reporte de Cobranza - SCOTIABANK"
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub INTERBANKToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles INTERBANKToolStripMenuItem2.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = "05" 'INTERBANK
        frmDoccancelados.Text = "Reporte de Cobranza - INTERBANK"
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub VARIOSToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VARIOSToolStripMenuItem2.Click
        Dim frmDoccancelados As New FrmRepCobranzaEfectuada
        frmDoccancelados.MdiParent = Me
        frmDoccancelados.GRUPO_COBRANZA = "04" 'VARIOS
        frmDoccancelados.Text = "Reporte de Cobranza - VARIOS"
        OpenSubForm(frmDoccancelados)
    End Sub

    Private Sub BCPToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BCPToolStripMenuItem3.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "01" 'BCP
        frmDocCanPag.Text = "Reporte de Pagos - BCP"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub BIFToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BIFToolStripMenuItem3.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "02" 'bif
        frmDocCanPag.Text = "Reporte de Pagos - BIF"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub SCOTIABANKToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SCOTIABANKToolStripMenuItem3.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "03" 'scotiabank
        frmDocCanPag.Text = "Reporte de Pagos - SCOTIABANK"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub INTERBANKToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles INTERBANKToolStripMenuItem3.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "05" 'INTERBANK
        frmDocCanPag.Text = "Reporte de Pagos - INTERBANK"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub VARIOSToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles VARIOSToolStripMenuItem3.Click
        Dim frmDocCanPag As New FrmReporteDocumentosCancelados_Pago
        frmDocCanPag.MdiParent = Me
        frmDocCanPag.GRUPO_COBRANZA = "04" 'varios
        frmDocCanPag.Text = "Reporte de Pagos - VARIOS"
        OpenSubForm(frmDocCanPag)
    End Sub

    Private Sub RequerimientoDeOrdenDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequerimientoDeOrdenDeProducciónToolStripMenuItem.Click
        Dim frm_requerimiento_OP As New Frm_Requerimiento_OP
        frm_requerimiento_OP.MdiParent = Me
        OpenSubForm(frm_requerimiento_OP)
    End Sub

    Private Sub AtenciónDeQuejasYReclamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtenciónDeQuejasYReclamosToolStripMenuItem.Click
        Dim frm_Quejas_reclamos As New Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico
        frm_Quejas_reclamos.MdiParent = Me
        OpenSubForm(frm_Quejas_reclamos)
    End Sub

    Private Sub AtenciónDeQuejasYReclamosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtenciónDeQuejasYReclamosToolStripMenuItem1.Click
        Dim frm_Quejas_reclamos As New Frm_OP_Planta_Bandeja_Mantenimiento_Informes_Tecnico
        frm_Quejas_reclamos.MdiParent = Me
        OpenSubForm(frm_Quejas_reclamos)
    End Sub

    Private Sub ListaMateriasPrimasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaMateriasPrimasToolStripMenuItem.Click
        Dim frm_Lista_precios As New LibManufactura.FrmListaPrecios
        frm_Lista_precios.MdiParent = Me
        frm_Lista_precios._tipo_producto = "02"
        frm_Lista_precios.Text = "Lista de Costos de Materia Prima"
        OpenSubForm(frm_Lista_precios)
    End Sub

    Private Sub ListaEnvasesYEmbalajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaEnvasesYEmbalajesToolStripMenuItem.Click
        Dim frm_Lista_precios As New LibManufactura.FrmListaPrecios
        frm_Lista_precios.MdiParent = Me
        frm_Lista_precios._tipo_producto = "06"
        frm_Lista_precios.Text = "Lista de Costos de Envases y Embalajes"
        OpenSubForm(frm_Lista_precios)
    End Sub

    Private Sub ProcesoDeCosteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesoDeCosteoToolStripMenuItem.Click
        frm_proceso_costeo = New FrmManufactura_Costeo_Losaro
        frm_proceso_costeo.MdiParent = Me
        OpenSubForm(frm_proceso_costeo)
    End Sub

    Private Sub GestiónDeMuestrasParaDesarrolloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeMuestrasParaDesarrolloToolStripMenuItem.Click
        frm_gestion_desarrollo = New Frm_Gestion_Muestra_Desarrollo
        frm_gestion_desarrollo.MdiParent = Me
        OpenSubForm(frm_gestion_desarrollo)
    End Sub

    Private Sub RecepciónDeMuestrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepciónDeMuestrasToolStripMenuItem.Click
        frm_gestion_desarrollo = New Frm_Gestion_Muestra_Desarrollo
        frm_gestion_desarrollo.MdiParent = Me
        OpenSubForm(frm_gestion_desarrollo)
    End Sub

    Private Sub PlanificaciónDeDesarrolloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanificaciónDeDesarrolloToolStripMenuItem.Click

    End Sub

    Private Sub GeneraciónDeOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónDeOToolStripMenuItem.Click
        frm_genera_orden_desarrollo = New Frm_Generar_Orden_Desarrollo
        frm_genera_orden_desarrollo.MdiParent = Me
        OpenSubForm(frm_genera_orden_desarrollo)
    End Sub

    Private Sub mnuManufacFicherosMaquinaria_Click(sender As Object, e As EventArgs) Handles mnuManufacFicherosMaquinaria.Click
        frm_equipos_maquinas = New Frm_Equipos_Maquinaria
        frm_equipos_maquinas.MdiParent = Me
        OpenSubForm(frm_equipos_maquinas)
    End Sub

    Private Sub ProgramacionDeOPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramacionDeOPToolStripMenuItem.Click
        frm_bandeja_programacion = New Frm_OP_PLanta_Bandeja_Despachos
        frm_bandeja_programacion.MdiParent = Me
        OpenSubForm(frm_bandeja_programacion)
    End Sub

    Private Sub LineasDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineasDeProducciónToolStripMenuItem.Click
        frm_linea_produccion = New Frm_Linea_Produccion
        frm_linea_produccion.MdiParent = Me
        OpenSubForm(frm_linea_produccion)
    End Sub

    Private Sub ProcesosDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesosDeProducciónToolStripMenuItem.Click
        frm_procesos_produccion = New Frm_Procesos_Produccion
        frm_procesos_produccion.MdiParent = Me
        OpenSubForm(frm_procesos_produccion)
    End Sub

    Private Sub ProgramaciónDeDespachosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaciónDeDespachosToolStripMenuItem.Click
        frm_programacion_despachos = New Frm_OP_PLanta_Bandeja_Programacion_Despachos
        frm_programacion_despachos.MdiParent = Me
        OpenSubForm(frm_programacion_despachos)
    End Sub

    Private Sub ComprobantesDeRetenciónSUNATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobantesDeRetenciónSUNATToolStripMenuItem.Click
        frm_Comp_retencion_sunat = New FrmFacturacion_SUNAT_Com_Retencion
        frm_Comp_retencion_sunat.MdiParent = Me
        OpenSubForm(frm_Comp_retencion_sunat)
    End Sub

    Private Sub ParteDeENtregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParteDeENtregaToolStripMenuItem.Click
        frmParteEntrega = New Frm_Parte_Entrega
        frmParteEntrega.MdiParent = Me
        frmParteEntrega.TipoMov = "I"
        frmParteEntrega.documentId = "NI"
        'frmParteEntrega.Text = "Ingreso a Almacen"
        'frmParteEntrega.Name = "Ingreso a Almacen"
        OpenSubForm(frmParteEntrega)
    End Sub

    Private Sub ParteDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParteDeProducciónToolStripMenuItem.Click
        frm_parte_produccion = New LibManufactura.Frm_OP_Planta_Parte_Produccion
        frm_parte_produccion.MdiParent = Me
        OpenSubForm(frm_parte_produccion)
    End Sub

    Private Sub mnuManufacFicherosPersonal_Click(sender As Object, e As EventArgs) Handles mnuManufacFicherosPersonal.Click
        frm_personal_produccion = New Frm_Personal
        frm_personal_produccion.MdiParent = Me
        OpenSubForm(frm_personal_produccion)
    End Sub

    Private Sub mnuManufacFicherosEstadosProd_Click(sender As Object, e As EventArgs) Handles mnuManufacFicherosEstadosProd.Click

    End Sub

    Private Sub mnuManufacFicherosTiposProd_Click(sender As Object, e As EventArgs) Handles mnuManufacFicherosTiposProd.Click

    End Sub

    Private Sub EnvioDeBoletasDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvioDeBoletasDePagoToolStripMenuItem.Click
        frm_Envio_Boletas = New Frm_Calculo_Envio_Boletas_Pago
        frm_Envio_Boletas.MdiParent = Me
        OpenSubForm(frm_Envio_Boletas)
    End Sub

    Private Sub RequerimientoDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequerimientoDeMaterialesToolStripMenuItem.Click
        Dim frm_req_materiales As New FrmRequisiciones_Materiales
        frm_req_materiales.MdiParent = Me
        frm_req_materiales.TipoMov = "RM"
        frm_req_materiales.Text = "Requisicion de Materiales"
        frm_req_materiales.Name = "REQUISICION DE MATERIALES"
        OpenSubForm(frm_req_materiales)
    End Sub

    Private Sub GuiaDeDevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuiaDeDevoluciónToolStripMenuItem.Click
        Dim frm_Guia_Devolucion As New LibCompras.FrmGuia_Devolucion
        frm_Guia_Devolucion.MdiParent = Me
        OpenSubForm(frm_Guia_Devolucion)
    End Sub

    Private Sub ContabilizarComprobantesDeRetenciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilizarComprobantesDeRetenciónToolStripMenuItem.Click
        Dim frm_com_reten_contabilizacion As New Frm_Comp_Retencion_Contabilizacion
        frm_com_reten_contabilizacion.MdiParent = Me
        OpenSubForm(frm_com_reten_contabilizacion)
    End Sub

    Private Sub ConsultaDeIngresosPorOrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeIngresosPorOrdenDeCompraToolStripMenuItem.Click
        Dim frmConsulta_OrdenCompra As New FrmConsulta_OrdenCompra
        frmConsulta_OrdenCompra.MdiParent = Me
        OpenSubForm(frmConsulta_OrdenCompra)
    End Sub

    Private Sub ConsultaParteProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaParteProducciónToolStripMenuItem.Click
        Dim frm_Consulta_Parte_Produccion As New Frm_Reporte_BI
        frm_Consulta_Parte_Produccion.MdiParent = Me
        OpenSubForm(frm_Consulta_Parte_Produccion)
    End Sub

    Private Sub ParteDeProducciónOrdenDeDesarrolloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParteDeProducciónOrdenDeDesarrolloToolStripMenuItem.Click
        Dim frm_parte_produccion_orden_desarrollo As New LibCobranzas.Frm_OP_Planta_Parte_Produccion
        frm_parte_produccion_orden_desarrollo.MdiParent = Me
        OpenSubForm(frm_parte_produccion_orden_desarrollo)
    End Sub

    Private Sub ParteDeProducciónOrdenDeDesarrolloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParteDeProducciónOrdenDeDesarrolloToolStripMenuItem1.Click
        Dim frm_parte_produccion_orden_desarrollo As New LibCobranzas.Frm_OP_Planta_Parte_Produccion
        frm_parte_produccion_orden_desarrollo.MdiParent = Me
        OpenSubForm(frm_parte_produccion_orden_desarrollo)
    End Sub

    Private Sub ProgramaciónDeOPAlamaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaciónDeOPAlamaxToolStripMenuItem.Click
        Dim frm_Programacion_op_alamax As New Frm_OP_PLanta_Bandeja_Despachos_Alamax
        frm_Programacion_op_alamax.MdiParent = Me
        OpenSubForm(frm_Programacion_op_alamax)
    End Sub

    Private Sub StockDeArticulosAUnaFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeArticulosAUnaFechaToolStripMenuItem.Click
        Dim frmStk_Almacen As New FrmStkMensual_Almacen
        frmStk_Almacen.MdiParent = Me
        OpenSubForm(frmStk_Almacen)
    End Sub

    Private Sub GeneraciónDeListaDeDespachoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónDeListaDeDespachoToolStripMenuItem.Click
        Dim frm_lista_despacho As New Frm_OP_PLanta_Bandeja_Lista_Despachos
        frm_lista_despacho.MdiParent = Me
        OpenSubForm(frm_lista_despacho)
    End Sub

    Private Sub BANCODELANACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BANCODELANACIONToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "07" 'BANCO DE LA NACION
                frmcx_planillaCob.Text = "Planilla de Cobranza - BANCO DE LA NACION"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub ConsultaDeDescargasPorOPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDescargasPorOPToolStripMenuItem.Click
        Dim frm_consulta_insumos_descargas As New Frm_Consulta_Ops_Vs_Descargas
        frm_consulta_insumos_descargas.MdiParent = Me
        OpenSubForm(frm_consulta_insumos_descargas)
    End Sub

    Private Sub ConsultaDeDescargasPorOPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaDeDescargasPorOPToolStripMenuItem1.Click
        Dim frm_consulta_insumos_descargas As New Frm_Consulta_Ops_Vs_Descargas
        frm_consulta_insumos_descargas.MdiParent = Me
        OpenSubForm(frm_consulta_insumos_descargas)
    End Sub

    Private Sub DocumentoVentaTiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentoVentaTiendaToolStripMenuItem.Click
        ''Verificacion Tipo Cambio
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                Dim frm_Fact_tienda As New LibCobranzas.FrmFacturacion_Tienda
                frm_Fact_tienda.MdiParent = Me
                OpenSubForm(frm_Fact_tienda)
            End If
        End If
    End Sub

    Private Sub CobroDeClientesProformasTiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroDeClientesProformasTiendaToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob_PF = New Frm_CX_LT_PlanillaCob_PF
                frmcx_planillaCob_PF.MdiParent = Me
                frmcx_planillaCob_PF.GRUPO_COBRANZA = "09" 'PF
                frmcx_planillaCob_PF.Text = ""
                OpenSubForm(frmcx_planillaCob_PF)
            End If
        End If
    End Sub

    Private Sub TIENDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIENDAToolStripMenuItem.Click
        If String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Or String.IsNullOrEmpty(LibComunVar.ClsVarComun.TCVenta.ToString) Then
            MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
        Else
            If LibComunVar.ClsVarComun.TCVenta = 0 Or LibComunVar.ClsVarComun.TCVenta = 0 Then
                MsgBox("No se cargo el Tipo de Cambio del Dia, verifique.", MsgBoxStyle.Critical)
            Else
                frmcx_planillaCob = New frm_CX_LT_PlanillaCobs
                frmcx_planillaCob.MdiParent = Me
                frmcx_planillaCob.GRUPO_COBRANZA = "08" 'VARIOS
                frmcx_planillaCob.Text = "Planilla de Cobranza - TIENDA"
                OpenSubForm(frmcx_planillaCob)
            End If
        End If
    End Sub

    Private Sub ConsultaDeFormulaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeFormulaciónToolStripMenuItem.Click
        Dim frm_formulas_consulta As New FrmManufactura_Formulas_Consulta
        frm_formulas_consulta.MdiParent = Me
        OpenSubForm(frm_formulas_consulta)
    End Sub

    Private Sub ListadoDeParteDeEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeParteDeEntregaToolStripMenuItem.Click
        Dim frm_lista_parte_entrega As New Frm_Reporte_Parte_Entrega_OPS
        frm_lista_parte_entrega.MdiParent = Me
        OpenSubForm(frm_lista_parte_entrega)
    End Sub

    Private Sub TiposDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDePedidoToolStripMenuItem.Click
        Dim frm_tipo_pedido As New frmTipoPedido
        frm_tipo_pedido.MdiParent = Me
        OpenSubForm(frm_tipo_pedido)
    End Sub

    Private Sub mnuAlmTransacciones_Click(sender As Object, e As EventArgs) Handles mnuAlmTransacciones.Click

    End Sub
End Class
