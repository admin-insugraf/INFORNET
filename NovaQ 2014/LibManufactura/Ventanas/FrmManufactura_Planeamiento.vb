'Imports Microsoft.Office.Interop.Excel

Public Class FrmManufactura_Planeamiento
    Dim Modo_consultar As Boolean = False
    Dim OrdenProduccionCabENT As ClsEntidades.ORDER_PRODUCTION
    Dim OrdenProduccionDetENT As ClsEntidades.ORDER_PRODUCTION_LINE
    Dim ListaDetalles As List(Of ClsEntidades.ORDER_PRODUCTION_LINE)
    Dim ListaCabecera As List(Of ClsEntidades.ORDER_PRODUCTION)

    Dim OrdenProduccionBl As ClsOperaciones.ORDER_PRODUCTION
    Dim CORRELATIVOBL As ClsTransacciones.ORDER_PRODUCTION
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim Fl_close As Boolean = False
    Dim Modo_Edicion As Boolean = False

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Dim _FechaVencimiento As String = String.Empty
    Dim _Rs As String = String.Empty
    Dim _Volumen As String = String.Empty
    Dim _Composicion As String = String.Empty
    Dim dtDatosCompany As DataTable

    Dim _id As String = String.Empty
    Dim _Who As String = String.Empty
    Dim _estado_compromiso As String = String.Empty

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION_PART", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT_PART", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_FORM", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION_FORM", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_FORM_EE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION_FORM_EE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("NUMERO_OF", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal

            dgvDetalles.AutoResizeColumns()
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgvDetalles.Columns(0).Width = 40
            'dgvDetalles.Columns(1).Width = 80
            'dgvDetalles.Columns(2).Width = 200
            'dgvDetalles.Columns(3).Width = 80
            'dgvDetalles.Columns(4).Width = 80
            dgvDetalles.Columns(7).Visible = False
            dgvDetalles.Columns(8).Visible = False

            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Cantidad"
            dgvDetalles.Columns(4).DefaultCellStyle.Format = "N2"
            dgvDetalles.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalles.Columns(5).HeaderText = "Cod. Formula"
            dgvDetalles.Columns(6).HeaderText = "Formula"
            dgvDetalles.Columns(9).HeaderText = "N° Orden de Fabricación"


            'dgvDetalles.Columns(8).HeaderText = "Tipo"
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_genera_xls.Enabled = False
            btnGrabar.Enabled = True
            btnEliminar.Enabled = False
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_genera_xls.Enabled = True
            btnGrabar.Enabled = False
            btnEliminar.Enabled = True
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    'Private Sub MostrandoAlmacenes()
    '    Try
    '        OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
    '        Dim dtAlmacen As New DataTable
    '        dtAlmacen = ManufactutraBl.Mostrar_Almacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
    '        cboalmacen.DataSource = Nothing
    '        If dtAlmacen.Rows.Count() <> 0 Then
    '            cboalmacen.DisplayMember = "DESCRIPCION"
    '            cboalmacen.ValueMember = "CODIGO"
    '            cboalmacen.DataSource = dtAlmacen
    '        Else
    '            MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub DocumentosPlanificacion()
        Try
            Dim Tipodoc As String = String.Empty
            If cboMostrar.Text = "Planificacion" Then
                Tipodoc = "01"
            ElseIf cboMostrar.Text = "Produccion" Then
                Tipodoc = "02"
            ElseIf cboMostrar.Text = "Anuladas" Then
                Tipodoc = "03"
            ElseIf cboMostrar.Text = "Terminadas" Then
                Tipodoc = "04"
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Principal(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos
                'dgvCabecera.Columns(1).DefaultCellStyle.Format = "MMMM (yyyy)"
                dgvCabecera.Columns(0).Width = 80
                dgvCabecera.Columns(1).Visible = False
                dgvCabecera.Columns(2).Visible = False
                dgvCabecera.Columns(3).Width = 100
                dgvCabecera.Columns(4).Width = 280
                dgvCabecera.Columns(5).Visible = False
                dgvCabecera.Columns(6).Width = 100
                dgvCabecera.Columns(7).Width = 80
                dgvCabecera.Columns(8).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvCabecera.Columns(11).Visible = False
                dgvCabecera.Columns(12).Visible = False
                dgvCabecera.Columns(13).Visible = False
                dgvCabecera.Columns(14).Visible = False
                dgvCabecera.Columns(15).Visible = False
                dgvCabecera.Columns(16).Visible = False
                dgvCabecera.Columns(17).Visible = False
                dgvCabecera.Columns(18).Width = 200

                'Else
                'MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosVerificacionStock()
        Try
            Dim Tipodoc As String = String.Empty
            If cboMostrar.Text = "Planificacion" Then
                Tipodoc = "01"
            ElseIf cboMostrar.Text = "Produccion" Then
                Tipodoc = "02"
            ElseIf cboMostrar.Text = "Anuladas" Then
                Tipodoc = "03"
            ElseIf cboMostrar.Text = "Terminadas" Then
                Tipodoc = "04"
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtDocumentos As New DataTable
            dtDocumentos = OrdenProduccionBl.Mostrar_Documentos_Principal_Verifica_Stock(Tipodoc, cboopcionesBusqueda.SelectedIndex, _
                                                                          dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"))
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtDocumentos
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvCabecera.Columns(3).Visible = False
                dgvCabecera.Columns(6).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(8).HeaderText = "Estado de Comprometido"
                dgvCabecera.Columns(9).Visible = False
                dgvCabecera.Columns(10).Visible = False
                dgvCabecera.Columns(11).Visible = False
                dgvCabecera.Columns(12).Visible = False

                dgvCabecera.Columns(13).Visible = False
                dgvCabecera.Columns(14).Visible = False
                dgvCabecera.Columns(15).Visible = False
                'Else
                '    MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrandoAlmacenes()
        Try
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtAlmacen As New DataTable
            dtAlmacen = OrdenProduccionBl.Mostrar_Almacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            cboalmacen.DataSource = Nothing
            If dtAlmacen.Rows.Count() <> 0 Then
                cboalmacen.DisplayMember = "DESCRIPCION"
                cboalmacen.ValueMember = "CODIGO"
                cboalmacen.DataSource = dtAlmacen
            Else
                MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(LibComunVar.ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 1
        cboMostrar.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
        MostrandoAlmacenes()

        'DocumentosPlanificacion()
    End Sub


    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMostrar.SelectedIndexChanged
        DocumentosPlanificacion()
    End Sub

    Private Sub Limpiar()
        txtcodigo.Text = String.Empty
        txtComentario.Text = String.Empty
        dgvDetalles.DataSource = Nothing
    End Sub

    Private Sub Nuevo()
        Try
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_Edicion = False
            cboMes.SelectedIndex = LibComunVar.ClsVarComun.FechaSistema.Month - 1
            dtpAño.Value = LibComunVar.ClsVarComun.FechaSistema
            gbcabecera.Enabled = True
            Limpiar()
            If Modo_Edicion = False Then
                txtcodigo.Text = Numeracion()
            End If
            btnAgregar.Focus()
            GenerarColummnaDataTable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.ORDER_PRODUCTION
            CORRELATIVOBL.Get_NumeroCorrelativoOrdenProduccion(cboMes.SelectedIndex + 1, dtpAño.Value.Year)
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
            Correlativo = Correlativo & "." & String.Format("{0:00}", cboMes.SelectedIndex + 1) & "." & Strings.Right(dtpAño.Value.Year, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        Call Botonera_Estado_Cambiar(True)
        pnlCabecera.Visible = False
        Dim _id As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        If Modo_Edicion = True Then
            gbcabecera.Enabled = False
        End If
        Try
            ''cabecera
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtCabeceraOp As New DataTable
            dtCabeceraOp = OrdenProduccionBl.Modo_Edicion_Cabecera(_id)
            If dtCabeceraOp.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraOp.Rows(0).Item(0).ToString
                cboalmacen.SelectedValue = dtCabeceraOp.Rows(0).Item(1).ToString
                cboMes.SelectedIndex = CInt(CDate(dtCabeceraOp.Rows(0).Item(2).ToString).Month.ToString) - 1
                dtpAño.Value = dtCabeceraOp.Rows(0).Item(2).ToString
                txtComentario.Text = dtCabeceraOp.Rows(0).Item(9).ToString
                ''Detalle
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = OrdenProduccionBl.Modo_Edicion_Detalle(_id)
                If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                    ConfigurarGrila()
                End If
            End If
            If dgvCabecera.Item(17, dgvCabecera.CurrentRow.Index).Value = "1" Then
                btnGrabar.Enabled = False
                gbOpciones.Enabled = False
            Else
                btnGrabar.Enabled = True
                gbOpciones.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Guardar_Orden_Produccion() As Boolean
        Try
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            ListaDetalles = New List(Of ClsEntidades.ORDER_PRODUCTION_LINE)
            ListaCabecera = New List(Of ClsEntidades.ORDER_PRODUCTION)

            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                OrdenProduccionCabENT = New ClsEntidades.ORDER_PRODUCTION

                OrdenProduccionCabENT.ID = item("NUMERO_OF").ToString
                OrdenProduccionCabENT.WHO_ID = cboalmacen.SelectedValue.ToString
                OrdenProduccionCabENT.DOCUMENT_DATE = "01/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
                OrdenProduccionCabENT.DATE_INIT = ""
                OrdenProduccionCabENT.DATE_OUT = ""
                OrdenProduccionCabENT.TURNO = ""
                OrdenProduccionCabENT.DOCUMENT_REF = ""
                OrdenProduccionCabENT.USER_ID = LibComunVar.ClsVarComun.USUARIO
                OrdenProduccionCabENT.STATUS = "01"
                OrdenProduccionCabENT.COMMENT = "" 'txtComentario.Text
                OrdenProduccionCabENT.COMPROMETIDO = "0"
                OrdenProduccionCabENT.MONEDA = ""
                OrdenProduccionCabENT.QTY_PRODUCID = 0
                OrdenProduccionCabENT.LIQUID = "N"
                OrdenProduccionCabENT.VENCIMIENTO = "" '_FechaVencimiento
                OrdenProduccionCabENT.LOTE = "" '_LOTE
                OrdenProduccionCabENT.RS = _Rs
                OrdenProduccionCabENT.VOLUMEN_LLENADO = _Volumen
                OrdenProduccionCabENT.TEXTO_COMPOSICION = _Composicion
                OrdenProduccionCabENT.FECHA_REGISTRO = Date.Today & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
                ListaCabecera.Add(OrdenProduccionCabENT)
            Next

            'If Modo_Edicion = True Then
            '    OrdenProduccionCabENT.ID = txtcodigo.Text
            'Else
            '    Dim _CORRELATIVO As String = Numeracion()
            '    OrdenProduccionCabENT.ID = _CORRELATIVO
            'End If
            '_LOTE = Mid(OrdenProduccionCabENT.ID, 8, 1) + Mid(OrdenProduccionCabENT.ID, 5, 2) + Strings.Left(OrdenProduccionCabENT.ID, 3) + Strings.Right(OrdenProduccionCabENT.ID, 1)
            'OrdenProduccionCabENT.WHO_ID = cboalmacen.SelectedValue.ToString
            'OrdenProduccionCabENT.DOCUMENT_DATE = "01/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
            'OrdenProduccionCabENT.DATE_INIT = ""
            'OrdenProduccionCabENT.DATE_OUT = ""
            'OrdenProduccionCabENT.TURNO = ""
            'OrdenProduccionCabENT.DOCUMENT_REF = ""
            'OrdenProduccionCabENT.USER_ID = LibComunVar.ClsVarComun.USUARIO
            'OrdenProduccionCabENT.STATUS = "01"
            'OrdenProduccionCabENT.COMMENT = txtComentario.Text
            'OrdenProduccionCabENT.COMPROMETIDO = "0"
            'OrdenProduccionCabENT.MONEDA = ""
            'OrdenProduccionCabENT.QTY_PRODUCID = 0
            'OrdenProduccionCabENT.LIQUID = "N"
            'OrdenProduccionCabENT.VENCIMIENTO = "" '_FechaVencimiento
            'OrdenProduccionCabENT.LOTE = "" '_LOTE
            'OrdenProduccionCabENT.RS = _Rs
            'OrdenProduccionCabENT.VOLUMEN_LLENADO = _Volumen
            'OrdenProduccionCabENT.TEXTO_COMPOSICION = _Composicion
            'OrdenProduccionCabENT.FECHA_REGISTRO = Date.Today & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)

            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                OrdenProduccionDetENT = New ClsEntidades.ORDER_PRODUCTION_LINE
                OrdenProduccionDetENT.ID = item("NUMERO_OF").ToString
                OrdenProduccionDetENT.WHO_ID = cboalmacen.SelectedValue.ToString
                OrdenProduccionDetENT.PART_ID = item("PART_ID").ToString
                OrdenProduccionDetENT.UNIT_PART = item("UNIT_PART").ToString
                OrdenProduccionDetENT.QTY = CDbl(item("QTY"))
                OrdenProduccionDetENT.PART_FORM = item("PART_FORM").ToString
                OrdenProduccionDetENT.DESCRIPTION_PART = item("DESCRIPTION_PART").ToString
                OrdenProduccionDetENT.DESCRIPTION_FORM = item("DESCRIPTION_FORM").ToString
                OrdenProduccionDetENT.PART_FORM_EE = item("PART_FORM_EE").ToString
                OrdenProduccionDetENT.DESCRIPTION_FORM_EE = item("DESCRIPTION_FORM_EE").ToString
                OrdenProduccionDetENT.COMMENT = txtComentario.Text
                ListaDetalles.Add(OrdenProduccionDetENT)
            Next
            If OrdenProduccionBl.GuardarOrdenProduccion(OrdenProduccionCabENT, ListaDetalles, ListaCabecera) Then
                If Modo_Edicion = True Then
                    MsgBox("Proceso Modificado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                Else
                    MsgBox("Proceso Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                End If
                DocumentosPlanificacion()
                'If MessageBox.Show("Se procedera a la Impresion de Documentos" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                '    imprimirAlmacen(OrdenProduccionCabENT.ID, OrdenProduccionCabENT.WHO_ID)
                'End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgvDetalles.Rows.Count() = 0 Then Exit Sub
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            If Guardar_Orden_Produccion() Then
                btnCancelar_Click(sender, e)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If dgvCabecera.Item(17, dgvCabecera.CurrentRow.Index).Value = "1" Then
            MsgBox("La O.F. hizo la reserva de los insumos o esta en un estado superior," & Chr(13) & "no se puede eliminar, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            If MessageBox.Show("Se va a anular el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim _id As String = String.Empty
                Dim Alm As String = String.Empty
                _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
                Alm = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
                If OrdenProduccionBl.Eliminar_Formulacion(_id, Alm) Then
                    MsgBox("Documento anulado Correctamente.", MsgBoxStyle.Information)
                    DocumentosPlanificacion()
                    btnCancelar_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub imprimirAlmacen(ByVal _Codigo As String, ByVal _Almacen As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As New DataTable()
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.EjecutarReporteOrdenProduccion(_Codigo, _Almacen)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Planificacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Dim _id As String = String.Empty
        Dim _Alm As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Alm = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        imprimirAlmacen(_id, _Alm)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        'DocumentosPlanificacion()
    End Sub



    Private Sub txtGlosaGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarDetalle
            If cboMes.SelectedIndex + 1 = 2 Then
                frmArticulo.FechaVencimientoOrigen = "28/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
            Else
                frmArticulo.FechaVencimientoOrigen = "30/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
            End If
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION_PART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_PART")
                row("UNIT_PART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT_PART")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("PART_FORM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_FORM")
                row("DESCRIPTION_FORM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_FORM")
                row("PART_FORM_EE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_FORM_EE")
                row("DESCRIPTION_FORM_EE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_FORM_EE")
                row("NUMERO_OF") = Format((CInt(Strings.Left(Numeracion(), 3)) - 1) + dtdetalleArticuloPrincipal.Rows.Count() + 1, "000") & "." & String.Format("{0:00}", cboMes.SelectedIndex + 1) & "." & Strings.Right(dtpAño.Value.Year, 2)
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                _FechaVencimiento = frmArticulo.FechaVencimientoOrigen
                _Rs = frmArticulo.RsOrigen
                _Volumen = frmArticulo.VolumenOrigen
                _Composicion = frmArticulo.ComposicionOrigen
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrila()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            'If txtcodigo.Text = String.Empty Then
            '    MsgBox("Debe no se cargo el Codigo.", MsgBoxStyle.Information)
            '    estado = False
            '    txtcodigo.Focus()
            '    Exit Try
            'End If

            'If txtcodigo.Text = String.Empty Then
            '    MsgBox("Debe ingresar un Descripcion, para poder continuar.", MsgBoxStyle.Information)
            '    estado = False
            '    txtcodigo.Focus()
            '    Exit Try
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        Modo_Edicion = False
        AgregandoArticulos()
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarDetalle
            ' frmArticulo.AlmacenOrigen = cboalmacen.SelectedValue
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.Flag_Modo_Edicion = True
            If cboMes.SelectedIndex + 1 = 2 Then
                frmArticulo.FechaVencimientoOrigen = "28/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
            Else
                frmArticulo.FechaVencimientoOrigen = "30/" & Format(cboMes.SelectedIndex + 1, "00") & "/" & dtpAño.Value.Year
            End If
            Dim Codigo As String = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION_PART") = item("DESCRIPTION_PART")
                row("UNIT_PART") = item("UNIT_PART")
                row("QTY") = item("QTY")
                row("PART_FORM") = item("PART_FORM")
                row("DESCRIPTION_FORM") = item("DESCRIPTION_FORM")
                row("PART_FORM_EE") = item("PART_FORM_EE")
                row("DESCRIPTION_FORM_EE") = item("DESCRIPTION_FORM_EE")
                frmArticulo.NUMERO_OF = item("NUMERO_OF")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()
                        'item("ITEM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ITEM")
                        item("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                        item("DESCRIPTION_PART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_PART")
                        item("UNIT_PART") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT_PART")
                        item("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                        item("PART_FORM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_FORM")
                        item("DESCRIPTION_FORM") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_FORM")
                        item("PART_FORM_EE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_FORM_EE")
                        item("DESCRIPTION_FORM_EE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION_FORM_EE")
                        item("NUMERO_OF") = frmArticulo.NUMERO_OF
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                    _FechaVencimiento = frmArticulo.FechaVencimientoOrigen
                    _Rs = frmArticulo.RsOrigen
                    _Volumen = frmArticulo.VolumenOrigen
                    _Composicion = frmArticulo.ComposicionOrigen
                    ConfigurarGrila()
                End If
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        Modo_Edicion = True
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        ModificandoArticulos()
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
                Codigo = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                    dtdetalleArticuloPrincipal.BeginInit()
                    item.Delete()
                    dtdetalleArticuloPrincipal.EndInit()
                    dtdetalleArticuloPrincipal.AcceptChanges()
                Next
                RehacerSecuencia()
                ' Calcular_Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        EliminandoArticulo()
    End Sub

    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO").Value = "ANULADAS" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes.SelectedIndexChanged
        If Modo_Edicion = False Then
            txtcodigo.Text = Numeracion()
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
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
        DocumentosPlanificacion()
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPlanificacion()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosPlanificacion()
        End If
    End Sub

    Private Sub btn_Materiales_Click(sender As Object, e As EventArgs) Handles btn_Materiales.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim _id As String = String.Empty
        Dim _Who As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Who = dgvCabecera.Item(15, dgvCabecera.CurrentRow.Index).Value

        Dim frm As New FrmManufactura_ListaMateriales
        frm.NRO_OF = _id
        frm.WHO_ID = _Who
        frm.ShowDialog()
        'DocumentosVerificacionStock()
        DocumentosPlanificacion()
    End Sub

    Private Sub btn_GenerarOf_Click(sender As Object, e As EventArgs) Handles btn_GenerarOf.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        _id = String.Empty
        _Who = String.Empty
        _estado_compromiso = String.Empty
        _id = dgvCabecera.CurrentRow.Cells("Codigo").Value
        _Who = dgvCabecera.CurrentRow.Cells("ID").Value
        _estado_compromiso = dgvCabecera.CurrentRow.Cells("COMPROMETIDO").Value

        If _estado_compromiso = "0" Then
            MsgBox("No se realizo la reserva de los insumos para O.F. Verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LibComunVar.ClsVarComun.TCVenta = 0 Then
            MsgBox("No se cargo el Tipo de Cambio del dia, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        pnlGenerar.Visible = True
        ToolStrip1.Enabled = False
        dtpFecha.Value = Date.Now
        Dim _CORRELATIVO As String = Numeracion_Lote()
        txt_numero_lote.Text = _CORRELATIVO
        pnlCabecera.Enabled = False
    End Sub
    Private Function Numeracion_Lote() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.ORDER_PRODUCTION
            CORRELATIVOBL.Get_NumeroCorrelativo_Lote()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = CInt(CORRELATIVOBL.NumeroCorrelativo + 1)
            End If
            Correlativo = Correlativo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub btn_terminarof_Click(sender As Object, e As EventArgs) Handles btn_terminarof.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim fecha_fab As Date
        _id = String.Empty
        _Who = String.Empty
        _estado_compromiso = String.Empty
        _id = dgvCabecera.CurrentRow.Cells("Codigo").Value
        fecha_fab = CDate(dgvCabecera.CurrentRow.Cells("Fecha de Inicio de Fabricación").Value)
        _Who = dgvCabecera.CurrentRow.Cells("ID").Value
        _estado_compromiso = dgvCabecera.CurrentRow.Cells("Estado").Value

        If _estado_compromiso <> "PRODUCCION" And _estado_compromiso <> "TERMINADAS" Then
            MsgBox("No se pueder terminar la O.F., su estado no lo permite, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If LibComunVar.ClsVarComun.TCVenta = 0 Then
            MsgBox("No se cargo el Tipo de Cambio del dia, verifique.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ToolStrip1.Enabled = False
        pnlterminar.Visible = True
        pnlCabecera.Enabled = False
        dtp_terminar.Value = Date.Now
        dtp_vcto_lote.Value = DateAdd("m", 6, fecha_fab)
        txt_num_lote.Text = dgvCabecera.CurrentRow.Cells("Lote").Value
        txtcatidadterminar.Text = "0.0"
        txtcatidadterminar.Select()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        pnlGenerar.Visible = False
        ToolStrip1.Enabled = True
        pnlCabecera.Enabled = True
        _id = String.Empty
        _Who = String.Empty
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Generar_Orden_Fabricacion()
        btn_cancelar_Click(sender, e)
    End Sub
    Private Sub Generar_Orden_Fabricacion()
        Try
            If MessageBox.Show("Desea Generar la Orden de Fabricación?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim QUERY_INSERTAR As String, QUERY_ACT_NUM As String

                QUERY_INSERTAR = " UPDATE  dbo.ORDER_PRODUCTION SET LOTE='" & txt_numero_lote.Text & "', STATUS='02',DATE_INIT='" & dtpFecha.Value.ToShortDateString & "' WHERE ID='" & _id & "' "
                QUERY_ACT_NUM = " UPDATE dbo.NUMBER_DOCUMENT SET LAST_NUMBER=" & CDbl(txt_numero_lote.Text) & " WHERE TYPE_DOC='99' "
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                If OrdenProduccionBl.Ejecutar_Consulta(QUERY_INSERTAR) = True Then
                    OrdenProduccionBl.Ejecutar_Consulta(QUERY_ACT_NUM)
                    Dim dt_descarga As DataTable
                    dt_descarga = OrdenProduccionBl.Genera_Descarga(_id, _Who, LibComunVar.ClsVarComun.USUARIO, LibComunVar.ClsVarComun.TCVenta)
                    If dt_descarga.Rows.Count > 0 Then
                        MsgBox("Descarga de Insumos con la Salida Nro " & dt_descarga.Rows(0).Item("NUMERO_SALIDA").ToString & ", grabado correctamente.", MsgBoxStyle.Information, "Sistemas")
                        imprimir_Descarga(_Who, "NS", dt_descarga.Rows(0).Item("NUMERO_SALIDA").ToString)
                    Else
                        MsgBox("No se realizo la descarga de los insumos.", MsgBoxStyle.Critical)
                    End If
                    imprimirAlmacen(_id, _Who)
                    'Documentos_Orden_Fabricacion()
                    DocumentosPlanificacion()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub imprimir_Descarga(ByVal _idalamacen As String, ByVal _documentid As String, ByVal _numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(_idalamacen, _documentid, _numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                If _idalamacen = "01" Then
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", dtImprimir, "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                Else
                    crystalBL.Muestra_Reporte("rpt_Mov_Almacen_Guia_Analisis.rpt", dtImprimir, "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlterminar.Visible = False
        ToolStrip1.Enabled = True
        pnlCabecera.Enabled = True
        _id = String.Empty
        _Who = String.Empty
    End Sub

    Private Sub btn_confirmartermino_Click(sender As Object, e As EventArgs) Handles btn_confirmartermino.Click
        If txtcatidadterminar.Text = "" Then
            MsgBox("Debe ingresar una Cantidad Terminada valida. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If
        If Generar_Termino_Orden_Fabricacion() Then
            Button1_Click(sender, e)
        End If
    End Sub
    Private Function Generar_Termino_Orden_Fabricacion() As Boolean
        Try
            If MessageBox.Show("Desea Terminar la Orden de Fabricación?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim QUERY_INSERTAR As String
                QUERY_INSERTAR = " UPDATE  dbo.ORDER_PRODUCTION SET VENCIMIENTO='" & dtp_vcto_lote.Value.ToString("dd/MM/yyyy") & "', STATUS='04',DATE_OUT='" & dtp_terminar.Value.ToShortDateString & "',QTY_PRODUCID=" & CDbl(txtcatidadterminar.Text) & " WHERE ID='" & _id & "' "
                OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
                If OrdenProduccionBl.Ejecutar_Consulta(QUERY_INSERTAR) = True Then
                    'imprimirAlmacen(_id, _Who)
                    'Documentos_Orden_Fabricacion()
                    DocumentosPlanificacion()
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub dgvCabecera_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCabecera.SelectionChanged
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            Dim dtResultado As DataTable
            Dim _NroOf As String = String.Empty
            Dim TEXTO As String = String.Empty
            _NroOf = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            TEXTO = "SELECT COMPROMETIDO FROM dbo.ORDER_PRODUCTION WHERE ID='" & _NroOf & "'"
            dtResultado = New DataTable
            dtResultado = OrdenProduccionBl.Mostrar_Consulta(TEXTO)
            If dtResultado.Rows.Count() <> 0 Then
                If dtResultado.Rows(0).Item("COMPROMETIDO").ToString = "1" Then
                    btn_GenerarOf.Enabled = True
                Else
                    btn_GenerarOf.Enabled = False
                End If
            End If
            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtResultado = New DataTable
            TEXTO = ""
            TEXTO = "SELECT STATUS FROM dbo.ORDER_PRODUCTION WHERE ID='" & _NroOf & "'"
            dtResultado = OrdenProduccionBl.Mostrar_Consulta(TEXTO)
            If dtResultado.Rows.Count() <> 0 Then
                If dtResultado.Rows(0).Item("STATUS") = "02" Then 'PRODUCCION
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = True
                    btn_adicional.Enabled = True
                ElseIf dtResultado.Rows(0).Item("STATUS") = "01" Then 'PLANIFICACION
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "03" Then 'ANULADAS
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "04" Then 'TERMINADAS
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = True
                    btn_adicional.Enabled = False
                ElseIf dtResultado.Rows(0).Item("STATUS") = "05" Then 'LIQUIDADO
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                Else 'LIQUIDADO MANUALMENTE
                    btn_GenerarOf.Enabled = False
                    btn_terminarof.Enabled = False
                    btn_adicional.Enabled = False
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_adicional_Click(sender As Object, e As EventArgs) Handles btn_adicional.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Nuevo_Adicional()
        Botonera_Estado_Cambiar(True)
        btnGrabar.Visible = True
    End Sub
    Private Sub Nuevo_Adicional()
        Try
            pnlCabecera.Visible = False
            GroupBox7.Enabled = True
            txtcodigo_adicional.Text = dgvCabecera.CurrentRow.Cells("Nro.O.F").Value
            txt_producto.Text = dgvCabecera.CurrentRow.Cells("Producto a Fabricar").Value
            txt_lote_detalle.Text = dgvCabecera.CurrentRow.Cells("Lote").Value
            GenerarColummnaDataTable()

            OrdenProduccionBl = New ClsOperaciones.ORDER_PRODUCTION
            dtdetalleArticuloPrincipal = OrdenProduccionBl.Mostrar_OF_Adicionales(txtcodigo_adicional.Text.Trim)
            dgvdetalles_adicional.DataSource = Nothing
            If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                dgvdetalles_adicional.DataSource = dtdetalleArticuloPrincipal
                dgvdetalles_adicional.AutoResizeColumns()
                dgvdetalles_adicional.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvdetalles_adicional.Columns("ITEM").HeaderText = "Item"
                dgvdetalles_adicional.Columns("PART_ID").HeaderText = "Codigo"
                dgvdetalles_adicional.Columns("DESCRIPTION").HeaderText = "Producto"
                dgvdetalles_adicional.Columns("UNIT").HeaderText = "Unidad"
                dgvdetalles_adicional.Columns("LOTE").HeaderText = "N° Lote"
                dgvdetalles_adicional.Columns("QTY").HeaderText = "Cantidad"
                dgvdetalles_adicional.Columns("QTY").DefaultCellStyle.Format = "N4"
                dgvdetalles_adicional.Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvdetalles_adicional.Columns("ALMACEN_SALIDA").Visible = False
                dgvdetalles_adicional.Columns("DOC_SALIDA").HeaderText = "Tipo Documento Desc."
                dgvdetalles_adicional.Columns("NUM_SALIDA").HeaderText = "N° Documento Desc."
                dgvdetalles_adicional.Columns("FECHA").HeaderText = "Fecha Documento Desc."
                dgvdetalles_adicional.Columns("ESTADO").Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Modo_Edicion = False
        AgregandoArticulos_Adicionales()
        If dgvdetalles_adicional.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            Button4_Click(sender, e)
        End If
    End Sub
    Private Sub AgregandoArticulos_Adicionales()
        Try
            Dim frmArticulo As New FrmAsignacionArticuloAdicional
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("LOTE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("LOTE")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("ALMACEN_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ALMACEN_SALIDA")
                row("DOC_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DOC_SALIDA")
                row("NUM_SALIDA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("NUM_SALIDA")
                row("FECHA") = ""
                row("ESTADO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("ESTADO")

                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            ConfigurarGrilla()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarGrilla()
        dgvdetalles_adicional.DataSource = Nothing
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvdetalles_adicional.DataSource = dtdetalleArticuloPrincipal
            dgvdetalles_adicional.Columns(0).HeaderText = "Item"
            dgvdetalles_adicional.Columns(1).HeaderText = "Codigo"
            dgvdetalles_adicional.Columns(2).HeaderText = "Producto"
            dgvdetalles_adicional.Columns(3).HeaderText = "Unidad"
            dgvdetalles_adicional.Columns(4).HeaderText = "N° Lote"
            dgvdetalles_adicional.Columns(5).HeaderText = "Cantidad"
            dgvdetalles_adicional.Columns(6).Visible = False
            dgvdetalles_adicional.Columns(7).HeaderText = "Tipo Documento Desc."
            dgvdetalles_adicional.Columns(8).HeaderText = "N° Documento Desc."
            dgvdetalles_adicional.Columns(9).HeaderText = "Fecha Documento Desc."
            dgvdetalles_adicional.Columns(10).Visible = False

            dgvdetalles_adicional.Columns(5).DefaultCellStyle.Format = "N6"
            dgvdetalles_adicional.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvdetalles_adicional.AutoResizeColumns()
            dgvdetalles_adicional.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End If
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_genera_xls.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xls;*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString() = "" Then Exit Sub

        Dim _id As String = String.Empty
        Dim _Alm As String = String.Empty
        _id = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        _Alm = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value

        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            Dim dtImprimir_OP As DataTable
            dtImprimir_OP = New DataTable
            Dim nombre_Archivo As String

            Me.Cursor = Cursors.WaitCursor
            dtImprimir_OP = reporteBL.EjecutarReporteOrdenProduccion(_id, _Alm)
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir_OP.Rows.Count() <> 0 Then
                'crystalBL.Muestra_Reporte("rpt_Orden_Produccion_Planificacion.rpt", "", "", "", "@OF;" & _Codigo, "@ALMACEN;" & _Almacen, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
                Dim xlibro As Microsoft.Office.Interop.Excel.Application
                Dim strRutaarchivo As String
                strRutaarchivo = myFileDialog.FileName.ToString()
                nombre_Archivo = (System.IO.Path.GetFileNameWithoutExtension(myFileDialog.FileName)) & (System.IO.Path.GetExtension(myFileDialog.FileName))

                xlibro = CreateObject("Excel.Application")
                xlibro.Workbooks.Open(strRutaarchivo)

                xlibro.Workbooks(nombre_Archivo).Activate()
                xlibro.Sheets("F-001").Select()

                Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlibro.Sheets.Item("F-001")
                xlibro.Visible = True

                xlibro.Range("H6").Value = dtImprimir_OP.Rows(0).Item("ID").ToString
                xlibro.Range("B8").Value = dtImprimir_OP.Rows(0).Item("CUSTOMER_NAME").ToString
                xlibro.Range("H8").Value = dtImprimir_OP.Rows(0).Item("VENDEDOR").ToString
                xlibro.Range("H9").Value = dtImprimir_OP.Rows(0).Item("DESCRIPTION_PART").ToString
                xlibro.Range("B11").Value = dtImprimir_OP.Rows(0).Item("CANT_OP").ToString
                xlibro.Range("H11").Value = dtImprimir_OP.Rows(0).Item("CANT_OP").ToString

                For i As Integer = 0 To dtImprimir_OP.Rows.Count - 1
                    xlibro.Range("A" & 17 + i).Value = dtImprimir_OP.Rows(i).Item("DESCRIPTION").ToString
                    xlibro.Range("H" & 17 + i).Value = dtImprimir_OP.Rows(i).Item("CANTIDAD").ToString
                    xlibro.Range("J" & 17 + +i).Value = dtImprimir_OP.Rows(i).Item("UNIT").ToString
                Next

            Else
                MsgBox("No hay informacion disponible para la Orden de Producción elegida.", MsgBoxStyle.Exclamation)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub
End Class