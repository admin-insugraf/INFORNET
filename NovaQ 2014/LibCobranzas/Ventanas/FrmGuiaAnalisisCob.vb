Imports System.Windows.Forms
Public Class FrmGuiaAnalisisCob
    Private edicion As Boolean
    Private _tipoNota As String
    Public _ModoEdicion As Boolean = False
    Private _idAlmacen As String
    Private _documentId As String
    Private _NumeroDocumento As String
    Dim QT_BULTOS As String = ""
    Dim OPT_ENTREGA As String = ""
    Dim NUM_PROTOCOLOS As String = ""
    Dim NUMBER_ANALIS As String = ""


    Dim WAREHOUSE_TRANSent As ClsEntidades.WAREHOUSE_TRANS
    Dim WAREHOUSE_TRANS_LINEent As ClsEntidades.WAREHOUSE_TRANS_LINE
    Dim WAREHOUSE_TRANS_LINEBULTOS As ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS

    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim clsAlmacenDetBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
    Dim dtCabeceraAlm As DataTable
    Dim dtDetalleAlm As DataTable
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Public dtdetalleBultosPrincipal As DataTable
    Public ID_ALMACEN As String
    Private Sub FrmGuiaAnalisisCob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _ModoEdicion = True Then
            btnAceptar.Visible = False
        Else
            btnAceptar.Visible = True
        End If
        NumerosSerieGuia()
        MostrarGuiarAnalisis()
    End Sub
    Public Property idAlmacen() As String
        Get
            Return _idAlmacen
        End Get
        Set(value As String)
            _idAlmacen = value
        End Set
    End Property

    Public Property documentId() As String
        Get
            Return _documentId
        End Get
        Set(value As String)
            _documentId = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            _NumeroDocumento = value
        End Set
    End Property


    Private Sub imprimirAlmacen(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAnalisis(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis_Analisis.rpt", "", "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarGuiarAnalisis()
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            clsAlmacenDetBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS_LINE
            dtCabeceraAlm = New DataTable
            dtDetalleAlm = New DataTable
            '---Mostrando Datos de Cabecera
            dtCabeceraAlm = clsAlmacenCabBl.get_CabeceraAlmacen(idAlmacen, documentId, NumeroDocumento)
            If dtCabeceraAlm.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraAlm.Rows.Count() - 1
                    dtpFecha.Text = dtCabeceraAlm.Rows(i).Item(4).ToString
                    ID_ALMACEN = dtCabeceraAlm.Rows(i).Item("WAREHOUSE_ID").ToString
                    txtcodigotipoMov.Text = dtCabeceraAlm.Rows(i).Item("TRANS_ID").ToString
                    txtdescripciontipoMov.Text = dtCabeceraAlm.Rows(i).Item("TRANS_NAME").ToString
                    txtCodigoalmacenDestino.Text = dtCabeceraAlm.Rows(i).Item(0).ToString
                    txtalmacenDestinodesc.Text = dtCabeceraAlm.Rows(i).Item("NAME").ToString
                    txtTipoDocumento.Text = dtCabeceraAlm.Rows(i).Item("DOCUMENT_ID").ToString
                    txtNumeroReferencia.Text = dtCabeceraAlm.Rows(i).Item("NUMBER_DOCUMENT").ToString
                    txtorderFabricacion.Text = dtCabeceraAlm.Rows(i).Item("PROJECT_ID").ToString
                    txtcodigoProveedor.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_ID").ToString
                    txtproveedordesc.Text = dtCabeceraAlm.Rows(i).Item("VENDOR_NAME").ToString
                    txtcodigoTercero.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_ID").ToString
                    txtclientedesc.Text = dtCabeceraAlm.Rows(i).Item("CUSTOMER_NAME").ToString
                    txtComentarios.Text = dtCabeceraAlm.Rows(i).Item("COMMENT").ToString
                    _tipoNota = dtCabeceraAlm.Rows(i).Item("TYPE_TRANS").ToString
                Next
                '---Mostrando datos del Detalle
                GenerarColummnaDataTable()
                BultosGenerarColummnaDataTable()

                dtDetalleAlm = clsAlmacenDetBl.get_DetalleAlmacen(idAlmacen, documentId, NumeroDocumento)
                'dgvDetalle.DataSource = Nothing
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        Dim fila As DataRow = dtdetalleArticuloPrincipal.NewRow
                        fila("ITEM") = dtDetalleAlm.Rows(j).Item("ITEM").ToString
                        fila("PART_ID") = dtDetalleAlm.Rows(j).Item("PART_ID").ToString
                        fila("PART_DESCRIPTION") = dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString
                        fila("UNIT_PART") = dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString
                        fila("NUMBER_ANALIS") = dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString
                        fila("QTY") = Val(dtDetalleAlm.Rows(j).Item("QTY").ToString)
                        fila("QT_BULTOS") = Val(dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString)
                        fila("OPT_ENTREGA") = IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total")
                        fila("NUM_PROTOCOLOS") = dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString
                        fila("NUMBER_LOT") = dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString
                        fila("CANTIDAD_ANALIZAR") = Val(0.0)
                        dtdetalleArticuloPrincipal.Rows.Add(fila)
                        dtdetalleArticuloPrincipal.AcceptChanges()

                        'dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                        ' dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                        'dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, 0.0)
                    Next
                End If

                For i = 0 To dgvDetalle.ColumnCount - 1
                    dgvDetalle.Columns(i).ReadOnly = True
                Next
                'dgvDetalle.Columns(10).ReadOnly = False

                clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                dtDetalleAlm = New DataTable
                '---Mostrando Datos de Cabecera
                dtDetalleAlm = clsAlmacenCabBl.get_Bultos(ID_ALMACEN, txtTipoDocumento.Text, txtNumeroReferencia.Text)
                If dtDetalleAlm.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtDetalleAlm.Rows.Count() - 1
                        Dim fila As DataRow = dtdetalleBultosPrincipal.NewRow
                        fila("WAREHOUSE_ID") = dtDetalleAlm.Rows(j).Item("WAREHOUSE_ID").ToString
                        fila("DOCUMENT_ID") = dtDetalleAlm.Rows(j).Item("DOCUMENT_ID").ToString
                        fila("NUMBER_DOCUMENT") = dtDetalleAlm.Rows(j).Item("NUMBER_DOCUMENT").ToString
                        fila("DATE_DOCUMENT") = dtDetalleAlm.Rows(j).Item("DATE_DOCUMENT").ToString
                        fila("TYPE_TRANS") = dtDetalleAlm.Rows(j).Item("TYPE_TRANS").ToString
                        fila("PART_ID") = dtDetalleAlm.Rows(j).Item("PART_ID").ToString
                        fila("LOTE") = dtDetalleAlm.Rows(j).Item("LOTE").ToString
                        fila("ITEM") = dtDetalleAlm.Rows(j).Item("ITEM").ToString
                        fila("QTY") = dtDetalleAlm.Rows(j).Item("QTY").ToString
                        fila("QTY_BULTOS") = dtDetalleAlm.Rows(j).Item("QTY_BULTOS").ToString
                        fila("QTY_ANALISIS") = dtDetalleAlm.Rows(j).Item("QTY_ANALISIS").ToString
                        fila("QTY_LIBERACION") = dtDetalleAlm.Rows(j).Item("QTY_LIBERACION").ToString
                        dtdetalleBultosPrincipal.Rows.Add(fila)
                        dtdetalleBultosPrincipal.AcceptChanges()

                        'dgvDetalle.Rows.Add(dtDetalleAlm.Rows(j).Item("ITEM").ToString, dtDetalleAlm.Rows(j).Item("PART_ID").ToString, dtDetalleAlm.Rows(j).Item("PART_DESCRIPTION").ToString, _
                        ' dtDetalleAlm.Rows(j).Item("UNIT_PART").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_ANALIS").ToString, dtDetalleAlm.Rows(j).Item("QTY").ToString, _
                        'dtDetalleAlm.Rows(j).Item("QT_BULTOS").ToString, IIf(dtDetalleAlm.Rows(j).Item("OPT_ENTREGA").ToString = "0", "Parcial", "Total"), dtDetalleAlm.Rows(j).Item("NUM_PROTOCOLOS").ToString, dtDetalleAlm.Rows(j).Item("NUMBER_LOT").ToString, 0.0)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_PART", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUMBER_ANALIS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QT_BULTOS", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("OPT_ENTREGA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUM_PROTOCOLOS", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUMBER_LOT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD_ANALIZAR", Type.GetType("System.Double"))
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetalle.Columns(0).HeaderText = "Item"
            dgvDetalle.Columns(1).HeaderText = "Cod. Prod."
            dgvDetalle.Columns(2).HeaderText = "Producto"
            dgvDetalle.Columns(3).HeaderText = "Unidad"
            dgvDetalle.Columns(4).HeaderText = "N° Analisis"
            dgvDetalle.Columns(5).HeaderText = "Cantidad"
            dgvDetalle.Columns(6).HeaderText = "Cant. Bultos"
            dgvDetalle.Columns(7).HeaderText = "Opt. Entrega"
            dgvDetalle.Columns(8).HeaderText = "N° Protocolo"
            dgvDetalle.Columns(9).HeaderText = "N° Lote"
            dgvDetalle.Columns(10).HeaderText = "Cant. Analisis"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BultosGenerarColummnaDataTable()
        dtdetalleBultosPrincipal = New DataTable
        dtdetalleBultosPrincipal.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("LOTE", Type.GetType("System.String"))
        dtdetalleBultosPrincipal.Columns.Add("ITEM", Type.GetType("System.Int16"))
        dtdetalleBultosPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_BULTOS", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_ANALISIS", Type.GetType("System.Double"))
        dtdetalleBultosPrincipal.Columns.Add("QTY_LIBERACION", Type.GetType("System.Double"))
    End Sub

    Private Sub GuardarGuiaAnalisis()
        Try
            clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            Dim clsAlmacenNumAnalisis = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            Dim listaEntidades As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)
            Dim listaEntidadesbultos As New List(Of ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS)

            WAREHOUSE_TRANSent = New ClsEntidades.WAREHOUSE_TRANS

            clsAlmacenBl = New ClsTransacciones.clsAlmacen
            clsAlmacenBl.Get_NumeroGuiaAnalisis(cboserieguia.Text)
            Dim NumberDocument As String = String.Empty
            'cabecera de almacen
            WAREHOUSE_TRANSent.WAREHOUSE_ID = txtCodigoalmacenDestino.Text
            WAREHOUSE_TRANSent.DOCUMENT_ID = clsAlmacenBl.TYPE_DOC
            WAREHOUSE_TRANSent.NUMBER_DOCUMENT = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
            WAREHOUSE_TRANSent.DATE_DOCUMENT = CDate(dtpFecha.Value).ToShortDateString
            '' WAREHOUSE_TRANSent.TYPE_TRANS = _tipoNota
            WAREHOUSE_TRANSent.TYPE_TRANS = "S"
            WAREHOUSE_TRANSent.TRANS_ID = "XA" 'txtcodigotipoMov.Text
            WAREHOUSE_TRANSent.VENDOR_ID = txtcodigoProveedor.Text
            WAREHOUSE_TRANSent.VENDOR_NAME = txtproveedordesc.Text
            WAREHOUSE_TRANSent.COMMENT = txtComentarios.Text
            WAREHOUSE_TRANSent.DOC_ID_REF = txtTipoDocumento.Text
            WAREHOUSE_TRANSent.NUM_ID_REF = txtNumeroReferencia.Text
            WAREHOUSE_TRANSent.UPDATE_DATE = dtpFecha.Value
            WAREHOUSE_TRANSent.HOUR = dtpFecha.Value.Hour
            WAREHOUSE_TRANSent.USER_ID = LibComunVar.ClsVarComun.USUARIO
            WAREHOUSE_TRANSent.CUSTOMER_ID = txtcodigoTercero.Text
            WAREHOUSE_TRANSent.CUSTOMER_NAME = txtclientedesc.Text
            WAREHOUSE_TRANSent.STATUS_GUIA = "V"
            WAREHOUSE_TRANSent.PRINTER_STATUS = "I"
            WAREHOUSE_TRANSent.PROJECT_ID = txtorderFabricacion.Text
            WAREHOUSE_TRANSent.WAREHOUSE_REF = _idAlmacen
            WAREHOUSE_TRANSent.STATUS_CONTROL = "C"
            Dim DT_CGA As DataTable
            Dim _numerador_correlativo As Integer
            _numerador_correlativo = 0
            'Detalle de Almacen
            For i As Integer = 0 To dgvDetalle.Rows.Count() - 1
                _numerador_correlativo = 0
                WAREHOUSE_TRANS_LINEent = New ClsEntidades.WAREHOUSE_TRANS_LINE
                WAREHOUSE_TRANS_LINEent.WAREHOUSE_ID = txtCodigoalmacenDestino.Text
                WAREHOUSE_TRANS_LINEent.DOCUMENT_ID = clsAlmacenBl.TYPE_DOC
                WAREHOUSE_TRANS_LINEent.NUMBER_DOCUMENT = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
                WAREHOUSE_TRANS_LINEent.ITEM = i + 1
                WAREHOUSE_TRANS_LINEent.PART_ID = dgvDetalle.Item(1, i).Value
                WAREHOUSE_TRANS_LINEent.QTY = IIf(String.IsNullOrEmpty(dgvDetalle.Item(10, i).Value), 0, dgvDetalle.Item(10, i).Value)
                WAREHOUSE_TRANS_LINEent.QTY_REF = IIf(String.IsNullOrEmpty(dgvDetalle.Item(5, i).Value), 0, dgvDetalle.Item(5, i).Value)
                WAREHOUSE_TRANS_LINEent.PART_DESCRIPTION = dgvDetalle.Item(2, i).Value
                WAREHOUSE_TRANS_LINEent.NUMBER_LOT = dgvDetalle.Item(9, i).Value
                WAREHOUSE_TRANS_LINEent.PROJECT_ID = txtorderFabricacion.Text
                WAREHOUSE_TRANS_LINEent.QT_BULTOS = dgvDetalle.Item(6, i).Value 'IIf(dgvDetalle.Item(6, i).Value = String.Empty, 0, dgvDetalle.Item(6, i).Value)
                WAREHOUSE_TRANS_LINEent.OPT_ENTREGA = dgvDetalle.Item(7, i).Value
                WAREHOUSE_TRANS_LINEent.NUM_PROTOCOLOS = dgvDetalle.Item(8, i).Value

                DT_CGA = New DataTable
                DT_CGA = clsAlmacenNumAnalisis.get_Obtener_Correlativo_GA(WAREHOUSE_TRANSent.NUM_ID_REF, WAREHOUSE_TRANSent.DOC_ID_REF, WAREHOUSE_TRANS_LINEent.WAREHOUSE_ID, WAREHOUSE_TRANS_LINEent.PART_ID, WAREHOUSE_TRANS_LINEent.NUMBER_LOT)
                If DT_CGA.Rows.Count > 0 Then
                    _numerador_correlativo = Val(DT_CGA.Rows.Count) + 1 'Val(DT_CGA.Rows(0).Item(0).ToString) + 1
                Else
                    _numerador_correlativo = _numerador_correlativo
                End If
                If _numerador_correlativo = 0 Then
                    WAREHOUSE_TRANS_LINEent.NUMBER_ANALIS = Strings.Left(dgvDetalle.Item(4, i).Value, 5) + Strings.Right(dgvDetalle.Item(4, i).Value, 5)
                Else
                    WAREHOUSE_TRANS_LINEent.NUMBER_ANALIS = Strings.Left(dgvDetalle.Item(4, i).Value, 5) + "-" + CStr(_numerador_correlativo) + Strings.Right(dgvDetalle.Item(4, i).Value, 5)
                End If

                _numerador_correlativo = 0
                For Each ITEM As DataRow In dtdetalleBultosPrincipal.Select("PART_ID='" & WAREHOUSE_TRANS_LINEent.PART_ID & "' AND LOTE='" & WAREHOUSE_TRANS_LINEent.NUMBER_LOT & "' AND QTY_ANALISIS>0 ")
                    _numerador_correlativo = _numerador_correlativo + 1
                Next
                WAREHOUSE_TRANS_LINEent.QTY_BULTOS_ANALIZADOS = _numerador_correlativo
                listaEntidades.Add(WAREHOUSE_TRANS_LINEent)
            Next
            Me.Cursor = Cursors.WaitCursor
            clsAlmacenCabBl.Guardar(WAREHOUSE_TRANSent, listaEntidades)
            'actualizamos los datos de los bultos

            For i As Integer = 0 To dtdetalleBultosPrincipal.Rows.Count - 1
                If dtdetalleBultosPrincipal.Rows(i).Item("QTY_ANALISIS").ToString > 0 Then
                    WAREHOUSE_TRANS_LINEBULTOS = New ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS
                    WAREHOUSE_TRANS_LINEBULTOS.WAREHOUSE_ID = dtdetalleBultosPrincipal.Rows(i).Item("WAREHOUSE_ID").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.DOCUMENT_ID = dtdetalleBultosPrincipal.Rows(i).Item("DOCUMENT_ID").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.NUMBER_DOCUMENT = dtdetalleBultosPrincipal.Rows(i).Item("NUMBER_DOCUMENT").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.DATE_DOCUMENT = dtdetalleBultosPrincipal.Rows(i).Item("DATE_DOCUMENT").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.TYPE_TRANS = dtdetalleBultosPrincipal.Rows(i).Item("TYPE_TRANS").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.PART_ID = dtdetalleBultosPrincipal.Rows(i).Item("PART_ID").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.LOTE = dtdetalleBultosPrincipal.Rows(i).Item("LOTE").ToString
                    WAREHOUSE_TRANS_LINEBULTOS.QTY = CDbl(dtdetalleBultosPrincipal.Rows(i).Item("QTY").ToString)
                    WAREHOUSE_TRANS_LINEBULTOS.QTY_BULTOS = CDbl(dtdetalleBultosPrincipal.Rows(i).Item("QTY_BULTOS").ToString)
                    WAREHOUSE_TRANS_LINEBULTOS.ITEM = CInt(dtdetalleBultosPrincipal.Rows(i).Item("ITEM").ToString)
                    WAREHOUSE_TRANS_LINEBULTOS.QTY_ANALISIS = CDbl(dtdetalleBultosPrincipal.Rows(i).Item("QTY_ANALISIS").ToString)
                    WAREHOUSE_TRANS_LINEBULTOS.QTY_LIBERACION = CDbl(dtdetalleBultosPrincipal.Rows(i).Item("QTY_LIBERACION").ToString)
                    listaEntidadesbultos.Add(WAREHOUSE_TRANS_LINEBULTOS)
                End If
            Next
            clsAlmacenCabBl.Actualizar_Analisis_Bultos(WAREHOUSE_TRANS_LINEBULTOS, listaEntidadesbultos, WAREHOUSE_TRANS_LINEent.WAREHOUSE_ID, WAREHOUSE_TRANS_LINEent.DOCUMENT_ID, WAREHOUSE_TRANS_LINEent.NUMBER_DOCUMENT)

            Dim msj As String = String.Empty
            msj = "Guia de Analisis generada Correctamente, Nro Documento: " & WAREHOUSE_TRANSent.NUMBER_DOCUMENT
            MsgBox(msj, MsgBoxStyle.Information)
            imprimirAlmacen(WAREHOUSE_TRANSent.WAREHOUSE_ID, WAREHOUSE_TRANSent.DOCUMENT_ID, WAREHOUSE_TRANSent.NUMBER_DOCUMENT)
            Me.Cursor = Cursors.Default
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub NumerosSerieGuia()
        Try
            Dim clsTransaccionTipoBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            Dim dtTransaccionTipo As DataTable
            clsTransaccionTipoBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
            dtTransaccionTipo = New DataTable
            dtTransaccionTipo = clsTransaccionTipoBl.get_NumeroSeriesGuia()
            Dim row As DataRow = dtTransaccionTipo.NewRow()
            'row.Item("CODIGO") = ""
            'row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            'dtTransaccionTipo.Rows.InsertAt(row, 0)
            If dtTransaccionTipo.Rows.Count() <> 0 Then
                cboserieguia.DataSource = dtTransaccionTipo
                cboserieguia.DisplayMember = "DESCRIPCION"
                cboserieguia.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EliminandoArticulo()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos del Articulo
                For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    rows.Delete()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmDetalleGuiaAnalisisCob
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.BultosGenerarColummnaDataTable()
            Dim Codigo As String = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            ''Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("PART_DESCRIPTION") = item("PART_DESCRIPTION")
                row("UNIT_PART") = item("UNIT_PART")
                row("NUMBER_ANALIS") = item("NUMBER_ANALIS")
                row("QTY") = Val(item("QTY"))
                row("QT_BULTOS") = Val(item("QT_BULTOS"))
                row("OPT_ENTREGA") = item("OPT_ENTREGA")
                row("NUM_PROTOCOLOS") = item("NUM_PROTOCOLOS")
                row("NUMBER_LOT") = item("NUMBER_LOT")
                row("CANTIDAD_ANALIZAR") = item("CANTIDAD_ANALIZAR")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                'frmArticulo.dtdetalleArticulo.AcceptChanges()

                frmArticulo.txtcodigoArticulo.Text = item("PART_ID")
                frmArticulo.txtdescripcionArticulo.Text = item("PART_DESCRIPTION")
                frmArticulo.txtunidadMedida.Text = item("UNIT_PART")
                frmArticulo.txtlote.Text = item("NUMBER_LOT")
                'frmArticulo.dtpFechaVencimiento.Value = ""
                frmArticulo.txtcantidad.Text = item("QTY")
                frmArticulo.txtcantidadbultos.Text = item("QT_BULTOS")
            Next

            Dim CODIGO_ARTICULO As String = dgvDetalle.Item(1, dgvDetalle.CurrentRow.Index).Value
            Dim CODIGO_LOTE As String = dgvDetalle.Item(9, dgvDetalle.CurrentRow.Index).Value
            ''Enviando datos de Bultos  seleccioandos a Modificar 
            For Each item As DataRow In dtdetalleBultosPrincipal.Select("PART_ID='" & CODIGO_ARTICULO & "' AND LOTE='" & CODIGO_LOTE & "'")
                Dim fila As DataRow = frmArticulo.dtDetallesBulto.NewRow
                fila("WAREHOUSE_ID") = item("WAREHOUSE_ID")
                fila("DOCUMENT_ID") = item("DOCUMENT_ID")
                fila("NUMBER_DOCUMENT") = item("NUMBER_DOCUMENT")
                fila("DATE_DOCUMENT") = item("DATE_DOCUMENT")
                fila("TYPE_TRANS") = item("TYPE_TRANS")
                fila("PART_ID") = item("PART_ID")
                fila("LOTE") = item("LOTE")
                fila("ITEM") = item("ITEM")
                fila("QTY") = item("QTY")
                fila("QTY_BULTOS") = item("QTY_BULTOS")
                fila("QTY_ANALISIS") = item("QTY_ANALISIS")
                fila("QTY_LIBERACION") = item("QTY_LIBERACION")
                frmArticulo.dtDetallesBulto.Rows.Add(fila)
            Next
            frmArticulo.ShowDialog()

            If Val(frmArticulo.txtCantidadAsiganda.Text) <> 0 Or frmArticulo.txtCantidadAsiganda.Text <> String.Empty Then
                For Each item As DataRow In dtdetalleBultosPrincipal.Select("PART_ID='" & CODIGO_ARTICULO & "' AND LOTE='" & CODIGO_LOTE & "'")
                    dtdetalleBultosPrincipal.BeginInit()
                    Dim item_bulto As Int16 = CInt(item("item"))
                    For Each row As DataRow In frmArticulo.dtDetallesBulto.Select("PART_ID='" & CODIGO_ARTICULO & "' AND LOTE='" & CODIGO_LOTE & "' and item=" & item_bulto & " ")
                        item("QTY_ANALISIS") = row("QTY_ANALISIS")
                    Next

                    dtdetalleBultosPrincipal.EndInit()
                    dtdetalleBultosPrincipal.AcceptChanges()
                Next
                For Each row As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    row("CANTIDAD_ANALIZAR") = Val(frmArticulo.txtCantidadAsiganda.Text)
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        For i As Integer = 0 To dgvDetalle.RowCount() - 1
            If String.IsNullOrEmpty(dgvDetalle.Item(10, i).Value) Then
                MsgBox("Es necesario ingresar una cantidad.", MsgBoxStyle.Information)
                dgvDetalle.Rows(i).Selected = True
                dgvDetalle.CurrentCell = dgvDetalle.Rows(i).Cells(10)
                Exit Sub
            ElseIf dgvDetalle.Item(10, i).Value = 0 Then
                MsgBox("Es necesario ingresar una cantidad Mayor a Cero.", MsgBoxStyle.Information)
                dgvDetalle.Rows(i).Selected = True
                dgvDetalle.CurrentCell = dgvDetalle.Rows(i).Cells(10)
                Exit Sub
            ElseIf Val(dgvDetalle.Item(5, i).Value) < Val(dgvDetalle.Item(10, i).Value) Then
                MsgBox("la cantidad Ingresada debe ser menor a la muestra.", MsgBoxStyle.Information)
                dgvDetalle.Rows(i).Selected = True
                dgvDetalle.CurrentCell = dgvDetalle.Rows(i).Cells(10)
                Exit Sub
            End If
        Next
        GuardarGuiaAnalisis()
    End Sub



    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
       ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetalle.CurrentCell.ColumnIndex
        ' verificar columna actual  
        If columna = 10 Then
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
    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
       ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalle.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress

    End Sub

    Private Sub dgvDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        ModificandoArticulos()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub
End Class