Imports System.IO

Public Class FrmManufactura_Formulas
    Dim Modo_consultar As Boolean = False
    Dim ManufactutraCabENT As ClsEntidades.FORMULATION
    Dim ManufactutraDetENT As ClsEntidades.FORMULATION_LINE
    Dim ManufactutraDetENT_Procesos As ClsEntidades.FORMULATION_LINE_PROCESOS
    Dim ListaDetalles As List(Of ClsEntidades.FORMULATION_LINE)
    Dim ListaDetalles_Procesos As List(Of ClsEntidades.FORMULATION_LINE_PROCESOS)

    Dim ManufactutraBl As ClsOperaciones.FORMULATION
    Dim CORRELATIVOBL As ClsTransacciones.FORMULACION
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_Procesos As DataTable
    Dim dtdetalleArticuloPrincipal_historial_cambios As DataTable
    Dim Fl_close As Boolean = False
    Dim TIPO_FORMULA, TIPO_PROD As String
    Dim Modo_Edicion As Boolean = False

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim _ruta As String = String.Empty
    Dim STRNomArch As String, STRExtArch As String, STRSoloNomArch As String, STRSoloRuta As String
    Dim INTtamano As Integer    '
    Dim dtdetalleArchivos As DataTable

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_TEORICA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("EQUIVALENCIA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("TYPE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("POR_EXCESO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCARGA_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Procesos()
        Try
            dtdetalleArticuloPrincipal_Procesos = New DataTable
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("PROCESO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("MAQUINA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_Procesos.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_Procesos.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Historial_Cambios()
        Try
            dtdetalleArticuloPrincipal_historial_cambios = New DataTable
            dtdetalleArticuloPrincipal_historial_cambios.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_historial_cambios.Columns.Add("FECHA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_historial_cambios.Columns.Add("ID", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_historial_cambios.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_historial_cambios.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal
            dgvDetalles.Columns(0).Width = 40
            dgvDetalles.Columns(1).Width = 80
            dgvDetalles.Columns(2).Width = 200
            dgvDetalles.Columns(3).Width = 80
            dgvDetalles.Columns(4).Width = 80
            dgvDetalles.Columns(5).Width = 80
            dgvDetalles.Columns(6).Width = 80
            dgvDetalles.Columns(7).Width = 80
            dgvDetalles.Columns(8).Width = 80
            dgvDetalles.Columns(9).Width = 80
            dgvDetalles.Columns(10).Width = 80

            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Cantidad"
            dgvDetalles.Columns(5).Visible = False '.HeaderText = "Cant.Teor"
            dgvDetalles.Columns(6).Visible = False 'HeaderText = "Costo"
            dgvDetalles.Columns(7).Visible = False 'HeaderText = "Equival"
            dgvDetalles.Columns(8).Visible = False 'HeaderText = "Tipo"
            dgvDetalles.Columns(9).Visible = False 'HeaderText = "%.Exceso"
            dgvDetalles.Columns(10).Visible = False 'HeaderText = "Desc.Total"
        End If
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            'If Modo_Edicion = True Then
            '    btnGrabar.Enabled = False
            'Else
            btnGrabar.Enabled = True
            'End If
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

    Private Sub MostrandoAlmacenes()
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtAlmacen As New DataTable
            dtAlmacen = ManufactutraBl.Mostrar_Almacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            cboalmacen.DataSource = Nothing
            If dtAlmacen.Rows.Count() <> 0 Then
                cboalmacen.DisplayMember = "DESCRIPCION"
                cboalmacen.ValueMember = "CODIGO"
                cboalmacen.DataSource = dtAlmacen
            Else
                'MsgBox("No hay almacenes para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosFormulacion()
        Try
            Dim Tipodoc As String = String.Empty
            Select Case cboMostrar.SelectedIndex
                Case 1
                    Tipodoc = "FO"
                Case 2
                    Tipodoc = "FE"
                Case Else
                    Tipodoc = ""
            End Select
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtDocumentos As New DataTable
            dtv = New DataView
            dtDocumentos = ManufactutraBl.Mostrar_Documentos_Principal(Tipodoc)
            dtv = dtDocumentos.DefaultView
            dgvCabecera.DataSource = Nothing
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name '& "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name
            Else
                'MsgBox("No hay Informacion para mostrar.", MsgBoxStyle.Critical, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Moneda()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub


    Private Sub FrmManufactura_Formulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cboMostrar.SelectedIndex = 0
        Botonera_Estado_Cambiar(False)
        MostrandoAlmacenes()
        Cargar_Moneda()
        DocumentosFormulacion()
    End Sub

    Public Sub GenerarColummaArchivos()
        Try
            dtdetalleArchivos = New DataTable
            dtdetalleArchivos.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetalleArchivos.Columns.Add("ITEM_ARCHIVO", Type.GetType("System.Int64")) '0
            dtdetalleArchivos.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '1
            dtdetalleArchivos.Columns.Add("NOMBRE_ARCHIVO", Type.GetType("System.String")) '2
            dtdetalleArchivos.Columns.Add("PESO_ARCHIVO", Type.GetType("System.String")) '2
            dtdetalleArchivos.Columns.Add("FECHA_REGISTRO", Type.GetType("System.String")) '2
            dtdetalleArchivos.Columns.Add("EXTENSION", Type.GetType("System.String")) '1
            dtdetalleArchivos.PrimaryKey = New DataColumn() {dtdetalleArchivos.Columns("ITEM")}

            dgvDetalle_Archivo.DataSource = dtdetalleArchivos

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMostrar.SelectedIndexChanged
        DocumentosFormulacion()
    End Sub

    Private Sub Limpiar()
        txtcodigo.Text = String.Empty
        txtdescripcion.Text = String.Empty
        chkEstado.Checked = True
        dtpFecha.Value = Date.Now
        cboMoneda.SelectedIndex = 0
        rbmp.Checked = True
        chkEstado.Checked = True
        txtComentario.Text = String.Empty
        dgvDetalles.DataSource = Nothing
        dgvDetalles_procesos.DataSource = Nothing
        dgv_detalle_historial_cambios.DataSource = Nothing
        txt_proceso.Text = ""
        txt_maquina.Text = ""
        LBLPORCENTAJE.Text = "Formula al 0 %"
        rdb_ficha_tecnica.Checked = False
        rdb_hoja_seguridad.Checked = False
        rdb_procedimiento.Checked = False
    End Sub

    Private Sub Nuevo()
        Try
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            Modo_Edicion = False
            gbcabecera.Enabled = True
            Limpiar()
            If Modo_Edicion = False Then
                txtcodigo.Enabled = True
                'cboalmacen.Enabled = True
            End If
            txtcodigo.Text = Numeracion()
            GenerarColummnaDataTable()
            GenerarColummnaDataTable_Procesos()
            GenerarColummnaDataTable_Historial_Cambios()
            GenerarColummaArchivos()
            TabControl1.SelectedIndex = 0

            reporteBL = New ClsBuscar
            dtdetalleArchivos = reporteBL.get_Detalle_Archivos("")
            dgvDetalle_Archivo.DataSource = dtdetalleArchivos
            cargarImagen()
            txtdescripcion.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            CORRELATIVOBL = New ClsTransacciones.FORMULACION
            CORRELATIVOBL.Get_NumeroCorrelativoFormulacion()

            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:0000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
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
        TabControl1.SelectedIndex = 0
        Dim _id As String = String.Empty
        Dim Alm As String = String.Empty
        _id = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        Alm = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
        If Modo_Edicion = True Then
            txtcodigo.Enabled = False
            'cboalmacen.Enabled = False
        End If
        Try
            ''cabecera
            ManufactutraBl = New ClsOperaciones.FORMULATION
            Dim dtCabeceraF As New DataTable
            dtCabeceraF = ManufactutraBl.Modo_Edicion_Cabecera(_id, Alm)
            If dtCabeceraF.Rows.Count() <> 0 Then
                txtcodigo.Text = dtCabeceraF.Rows(0).Item(0).ToString
                cboalmacen.SelectedValue = dtCabeceraF.Rows(0).Item(1).ToString
                txtdescripcion.Text = dtCabeceraF.Rows(0).Item(2).ToString
                txtComentario.Text = dtCabeceraF.Rows(0).Item(6).ToString
                cboMoneda.SelectedValue = dtCabeceraF.Rows(0).Item(7).ToString
                dtpFecha.Value = dtCabeceraF.Rows(0).Item(3).ToString
                chkEstado.Checked = IIf(dtCabeceraF.Rows(0).Item(5).ToString = "A", True, False)
                If dtCabeceraF.Rows(0).Item(8).ToString = "FO" Then
                    rbmp.Checked = True
                Else
                    rbee.Checked = True
                End If
            End If
            ''Detalle
            ManufactutraBl = New ClsOperaciones.FORMULATION
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle(_id, Alm)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
                LBLPORCENTAJE.Text = "Formula al " & Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") & " %"
            End If

            GenerarColummnaDataTable_Procesos()
            dtdetalleArticuloPrincipal_Procesos = ManufactutraBl.Modo_Edicion_Detalle_Procesos(_id, Alm)
            If dtdetalleArticuloPrincipal_Procesos.Rows.Count() <> 0 Then
                ConfigurarGrila_Proceso()
            End If

            GenerarColummnaDataTable_Historial_Cambios()
            dtdetalleArticuloPrincipal_historial_cambios = ManufactutraBl.Modo_Edicion_Detalle_Historial_Cambios(_id, Alm)
            If dtdetalleArticuloPrincipal_historial_cambios.Rows.Count() <> 0 Then
                ConfigurarGrila_Historial_Cambios()
            End If

            reporteBL = New ClsBuscar
            dtdetalleArchivos = reporteBL.get_Detalle_Archivos(txtcodigo.Text)
            dgvDetalle_Archivo.DataSource = dtdetalleArchivos
            cargarImagen()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Guardar_Formulacion() As Boolean
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            ManufactutraCabENT = New ClsEntidades.FORMULATION
            ListaDetalles = New List(Of ClsEntidades.FORMULATION_LINE)
            ListaDetalles_Procesos = New List(Of ClsEntidades.FORMULATION_LINE_PROCESOS)

            If Modo_Edicion = True Then
                ManufactutraCabENT.ID = txtcodigo.Text
            Else
                Dim _CORRELATIVO As String = Numeracion()
                ManufactutraCabENT.ID = _CORRELATIVO
            End If
            ManufactutraCabENT.WHO_ID = cboalmacen.SelectedValue
            ManufactutraCabENT.DESCRIPTION = txtdescripcion.Text
            ManufactutraCabENT.DOCUMENT_DATE = dtpFecha.Value
            ManufactutraCabENT.USER_ID = LibComunVar.ClsVarComun.USUARIO
            ManufactutraCabENT.STATUS = IIf(chkEstado.Checked, "A", "I")
            ManufactutraCabENT.COMMENT = txtComentario.Text
            ManufactutraCabENT.MONEDA = cboMoneda.SelectedValue
            ManufactutraCabENT.TYPE_DOC = IIf(rbmp.Checked, "FO", "FE") 'TIPO_FORMULA
            ManufactutraCabENT.DESCARGA_TOTAL = ""

            For Each item As DataRow In dtdetalleArticuloPrincipal.Rows
                ManufactutraDetENT = New ClsEntidades.FORMULATION_LINE
                ManufactutraDetENT.ID = ManufactutraCabENT.ID
                ManufactutraDetENT.WHO_ID = cboalmacen.SelectedValue
                ManufactutraDetENT.ITEM = item("ITEM").ToString
                ManufactutraDetENT.PART_ID = item("PART_ID").ToString
                ManufactutraDetENT.QTY = CDbl(item("QTY").ToString)
                ManufactutraDetENT.AVERAGE_COST = CDbl(item("AVERAGE_COST"))
                ManufactutraDetENT.STATUS = IIf(chkEstado.Checked, "A", "I")
                ManufactutraDetENT.TYPE = "M" 'item("TYPE").ToString
                ManufactutraDetENT.DESCRIPTION = item("DESCRIPTION").ToString
                ManufactutraDetENT.SECUENCE = ""
                ManufactutraDetENT.UNIT = item("UNIT").ToString
                ManufactutraDetENT.EQUIVALENCIA = item("EQUIVALENCIA").ToString
                ManufactutraDetENT.POR_EXCESO = item("POR_EXCESO").ToString
                ManufactutraDetENT.DESCARGA_TOTAL = item("DESCARGA_TOTAL").ToString
                ManufactutraDetENT.QTY_TEORICA = CDbl(item("QTY_TEORICA"))
                ListaDetalles.Add(ManufactutraDetENT)
            Next

            For Each item As DataRow In dtdetalleArticuloPrincipal_Procesos.Rows
                ManufactutraDetENT_Procesos = New ClsEntidades.FORMULATION_LINE_PROCESOS
                ManufactutraDetENT_Procesos.ID = ManufactutraCabENT.ID
                ManufactutraDetENT_Procesos.ITEM = item("ITEM")
                ManufactutraDetENT_Procesos.MAQUINA = item("MAQUINA").ToString
                ManufactutraDetENT_Procesos.PROCESO = item("PROCESO").ToString
                ListaDetalles_Procesos.Add(ManufactutraDetENT_Procesos)
            Next

            If ManufactutraBl.GuardarFormulacionProduccion(ManufactutraCabENT, ListaDetalles, ListaDetalles_Procesos) Then
                If Modo_Edicion = True Then
                    MsgBox("Formula Modificada Correctamente," & vbCrLf & "Nro Documento: " & ManufactutraCabENT.ID, MsgBoxStyle.Information, "Sistemas")
                Else
                    MsgBox("Nueva Formula Generada Correctamente," & vbCrLf & "Nro Documento: " & ManufactutraCabENT.ID, MsgBoxStyle.Information, "Sistemas")
                End If

                If MessageBox.Show("Se procedera a la Impresión de la Formula" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    imprimirAlmacen(ManufactutraCabENT.ID, ManufactutraCabENT.WHO_ID)
                End If
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
        'If Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") <> 100 Then
        '    MsgBox("La formula no cumple con el porcentaje requerido.", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If MessageBox.Show("Se va registrar la Formula" & vbCrLf & "¿Desea continuar?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Guardar_Formulacion() Then
                DocumentosFormulacion()
                btnCancelar_Click(sender, e)
            End If
        End If


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvCabecera.Rows.Count() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim _id As String = String.Empty
                Dim Alm As String = String.Empty
                _id = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
                Alm = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
                If ManufactutraBl.Eliminar_Formulacion(_id, Alm) Then
                    MsgBox("Formula eliminada Correctamente.", MsgBoxStyle.Information)
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
            dtImprimir = New DataTable("Formulacion")
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteFormulacion(_Codigo, _Almacen)

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                ''crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & _idalamacen, "@tipo;" & _documentid, "@numero;" & _numerodocument)
                crystalBL.Muestra_Reporte("rpt_Produccion_Formulacion.rpt", dtImprimir, "", "", "@id;" & _Codigo, "@alm;" & _Almacen,
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString,
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
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
        Dim _id As String = String.Empty
        Dim _Alm As String = String.Empty
        _id = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        _Alm = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
        imprimirAlmacen(_id, _Alm)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        Modo_consultar = False
        Limpiar()
        'DocumentosFormulacion()
    End Sub

    Private Sub txtGlosaGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub AgregandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            TIPO_FORMULA = String.Empty
            TIPO_PROD = String.Empty
            If rbmp.Checked = True Then
                TIPO_FORMULA = "FO"
                TIPO_PROD = "MP"
            ElseIf rbee.Checked = True Then
                TIPO_FORMULA = "FE"
                TIPO_PROD = "EE"
            End If
            frmArticulo.AlmacenOrigen = cboalmacen.SelectedValue
            frmArticulo.MonedaOrigen = cboMoneda.SelectedValue
            frmArticulo.EstadoOrigen = chkEstado.Checked
            frmArticulo.TIPO_FORMULA = TIPO_FORMULA
            frmArticulo.TIPO_PROD = TIPO_PROD
            frmArticulo.ShowDialog()
            If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                row("ITEM") = Format(dtdetalleArticuloPrincipal.Rows.Count() + 1, "000")
                row("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                row("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                row("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                row("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                row("QTY_TEORICA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_TEORICA")
                row("AVERAGE_COST") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST")
                row("EQUIVALENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("EQUIVALENCIA")
                row("TYPE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TYPE")
                row("POR_EXCESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("POR_EXCESO")
                row("DESCARGA_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCARGA_TOTAL")
                dtdetalleArticuloPrincipal.Rows.Add(row)
                dtdetalleArticuloPrincipal.AcceptChanges()
                Fl_close = False
            Else
                Fl_close = True
            End If
            '  Calcular_Totales()
            ConfigurarGrila()
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If txtcodigo.Text = String.Empty Then
                MsgBox("Debe no se cargo el Codigo.", MsgBoxStyle.Information)
                estado = False
                txtcodigo.Focus()
                Exit Try
            End If

            If txtdescripcion.Text = String.Empty Then
                MsgBox("Debe ingresar un Descripcion, para poder continuar.", MsgBoxStyle.Information)
                estado = False
                txtdescripcion.Focus()
                Exit Try
            End If

            If cboMoneda.Text = String.Empty Then
                MsgBox("No se cargo datos del Tipo de Moneda.", MsgBoxStyle.Critical)
                estado = False
                cboMoneda.Focus()
                Exit Try
            End If
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
        'Modo_Edicion = False
        AgregandoArticulos()
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            LBLPORCENTAJE.Text = "Formula al " & Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") & " %"
            If Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") > 100 Then
                MsgBox("La formula se excedio, actualize los datos.", MsgBoxStyle.Critical)
            End If
        Else
            LBLPORCENTAJE.Text = "Formula al 0 %"
        End If
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        If Fl_close = True Then
            Exit Sub
        Else
            btnAgregar_Click(sender, e)
        End If

    End Sub

    Private Sub ModificandoArticulos()
        Try
            Dim frmArticulo As New FrmAsignarArticulo
            frmArticulo.AlmacenOrigen = cboalmacen.SelectedValue
            frmArticulo.GenerarColummnaDataTable()
            frmArticulo.Flag_Modo_Edicion = True
            Dim Codigo As String = dgvDetalles.Item(0, dgvDetalles.CurrentRow.Index).Value
            'Enviando datos seleccioandos a Modificar
            frmArticulo._id_item = Codigo
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                Dim row As DataRow = frmArticulo.dtdetalleArticulo.NewRow
                row("ITEM") = item("ITEM")
                row("PART_ID") = item("PART_ID")
                row("DESCRIPTION") = item("DESCRIPTION")
                row("UNIT") = item("UNIT")
                row("QTY") = item("QTY")
                row("QTY_TEORICA") = item("QTY_TEORICA")
                row("AVERAGE_COST") = item("AVERAGE_COST")
                row("EQUIVALENCIA") = item("EQUIVALENCIA")
                row("TYPE") = item("TYPE")
                row("POR_EXCESO") = item("POR_EXCESO")
                row("DESCARGA_TOTAL") = item("DESCARGA_TOTAL")
                frmArticulo.dtdetalleArticulo.Rows.Add(row)
                frmArticulo.dtdetalleArticulo.AcceptChanges()
            Next
            frmArticulo.ShowDialog()
            If frmArticulo.fl_close = False Then
                If frmArticulo.dtdetalleArticulo.Rows.Count() <> 0 Then
                    For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                        dtdetalleArticuloPrincipal.BeginInit()

                        item("ITEM") = Format(frmArticulo.dtdetalleArticulo.Rows(0).Item("ITEM"), "000")
                        item("PART_ID") = frmArticulo.dtdetalleArticulo.Rows(0).Item("PART_ID")
                        item("DESCRIPTION") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCRIPTION")
                        item("UNIT") = frmArticulo.dtdetalleArticulo.Rows(0).Item("UNIT")
                        item("QTY") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY")
                        item("QTY_TEORICA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("QTY_TEORICA")
                        item("AVERAGE_COST") = frmArticulo.dtdetalleArticulo.Rows(0).Item("AVERAGE_COST")
                        item("EQUIVALENCIA") = frmArticulo.dtdetalleArticulo.Rows(0).Item("EQUIVALENCIA")
                        item("TYPE") = frmArticulo.dtdetalleArticulo.Rows(0).Item("TYPE")
                        item("POR_EXCESO") = frmArticulo.dtdetalleArticulo.Rows(0).Item("POR_EXCESO")
                        item("DESCARGA_TOTAL") = frmArticulo.dtdetalleArticulo.Rows(0).Item("DESCARGA_TOTAL")
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If
            End If
            frmArticulo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvDetalles.CurrentRow Is Nothing Then Exit Sub
        'Modo_Edicion = True
        If gbcabecera.Enabled = True Then
            If ValidacionesGenerales() = False Then Exit Sub
            gbcabecera.Enabled = False
        End If
        ModificandoArticulos()
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            LBLPORCENTAJE.Text = "Formula al " & Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") & " %"
            If Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") > 100 Then
                MsgBox("La formula se excedio, actualize los datos.", MsgBoxStyle.Critical)
            End If
        Else
            LBLPORCENTAJE.Text = "Formula al 0 %"
        End If

    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = Format(i, "000")
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
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            LBLPORCENTAJE.Text = "Formula al " & Format(CType(dtdetalleArticuloPrincipal.Compute("sum(QTY)", ""), Decimal), "##,##00") & " %"
        Else
            LBLPORCENTAJE.Text = "Formula al 0 %"
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then

        ElseIf txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(1).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(2).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(1).Name & "+" & dgvCabecera.Columns(2).Name ' & "+" & dgvCabecera.Columns(3).Name & "+" & dgvCabecera.Columns(4).Name
                        'lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            ' lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub btn_add_procesos_Click(sender As Object, e As EventArgs) Handles btn_add_procesos.Click
        Try
            If Validacion_Ingreso_Proceso() = False Then Exit Sub

            Dim row As DataRow = dtdetalleArticuloPrincipal_Procesos.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal_Procesos.Rows.Count() + 1
            row("PROCESO") = txt_proceso.Text.Trim
            row("MAQUINA") = txt_maquina.Text.Trim

            dtdetalleArticuloPrincipal_Procesos.Rows.Add(row)
            dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
            ConfigurarGrila_Proceso()

            txt_proceso.Text = ""
            txt_maquina.Text = ""
            txt_proceso.Focus()


            txt_proceso.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila_Proceso()
        If dtdetalleArticuloPrincipal_Procesos.Rows.Count() <> 0 Then
            dgvDetalles_procesos.DataSource = Nothing
            dgvDetalles_procesos.DataSource = dtdetalleArticuloPrincipal_Procesos
            dgvDetalles_procesos.AutoResizeColumns()
            dgvDetalles_procesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalles_procesos.Columns(0).HeaderText = "Item"
            dgvDetalles_procesos.Columns(1).HeaderText = "Proceso"
            dgvDetalles_procesos.Columns(2).HeaderText = "Maquina"
        End If

    End Sub

    Private Sub ConfigurarGrila_Historial_Cambios()
        If dtdetalleArticuloPrincipal_historial_cambios.Rows.Count() <> 0 Then
            dgv_detalle_historial_cambios.DataSource = Nothing
            dgv_detalle_historial_cambios.DataSource = dtdetalleArticuloPrincipal_historial_cambios
            dgv_detalle_historial_cambios.AutoResizeColumns()
            dgv_detalle_historial_cambios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgv_detalle_historial_cambios.Columns(0).HeaderText = "Item"
            dgv_detalle_historial_cambios.Columns(1).HeaderText = "Descripción"
            dgv_detalle_historial_cambios.Columns(2).Visible = False
        End If

    End Sub

    Function Validacion_Ingreso_Proceso() As Boolean

        If txt_proceso.Text.Trim = "" Then
            MsgBox("Debe indicar un Proceso.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_proceso.Focus()
            Return False
            Exit Function
        End If

        If txt_maquina.Text.Trim = "" Then
            MsgBox("Debe indicar una maquina.", MsgBoxStyle.Exclamation, "Sistemas")
            txt_maquina.Focus()
            Return False
            Exit Function
        End If


        Return True

    End Function

    Private Sub btn_del_procesos_Click(sender As Object, e As EventArgs) Handles btn_del_procesos.Click
        If dgvDetalles_procesos.RowCount = 0 Then Exit Sub
        If dgvDetalles_procesos.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Eliminando_Proceso()
        End If
    End Sub

    Private Sub Eliminando_Proceso()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalles_procesos.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Procesos.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
            Next
            RehacerSecuencia_Proceso()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia_Proceso()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Procesos.Rows
            i += 1
            dtdetalleArticuloPrincipal_Procesos.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Procesos.EndInit()
            dtdetalleArticuloPrincipal_Procesos.AcceptChanges()
        Next
    End Sub

    Private Sub txt_proceso_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proceso.KeyDown

        If e.KeyCode = Keys.F1 Then Ayuda_Proceso()
        If e.KeyCode = Keys.Enter Then
            If txt_proceso.Text = String.Empty Then
                Ayuda_Proceso()
            Else
                txt_maquina.Focus()
            End If
        End If

    End Sub

    Private Sub txt_maquina_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_maquina.KeyDown

        If e.KeyCode = Keys.F1 Then Ayuda_Maquinas()
        If e.KeyCode = Keys.Enter Then
            If txt_maquina.Text = String.Empty Then
                Ayuda_Maquinas()
            Else
                btn_add_procesos.Focus()
            End If
        End If
    End Sub

    Private Sub txt_proceso_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_proceso.MouseDoubleClick
        Ayuda_Proceso()
    End Sub

    Private Sub Ayuda_Proceso()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_PROCESOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Procesos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_proceso.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_maquina_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_maquina.MouseDoubleClick
        Ayuda_Maquinas()
    End Sub

    Private Sub Ayuda_Maquinas()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MAQUINAS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Maquinas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_maquina.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_subir_archivo_Click(sender As Object, e As EventArgs) Handles btn_subir_archivo.Click
        If rdb_ficha_tecnica.Checked = False And rdb_hoja_seguridad.Checked = False And rdb_procedimiento.Checked = False Then
            MsgBox("Debe elegir un Tipo.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        If odArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _ruta = odArchivo.FileName

            Dim infoArchivo As New System.IO.FileInfo(_ruta)

            If infoArchivo.Length > 262144000 Then
                MessageBox.Show("El archivo seleccionado pesa más de 250 MB. Seleccione otro archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                Me.Cursor = Cursors.WaitCursor
                reporteBL = New ClsBuscar

                Dim MiFichero As New System.IO.FileInfo(odArchivo.FileName)

                'STRNomArch = MiFichero.Name
                'STRExtArch = MiFichero.Extension
                'INTtamano = MiFichero.Length
                'STRSoloNomArch = Path.GetFileNameWithoutExtension(odArchivo.FileName)
                'STRSoloRuta = MiFichero.DirectoryName

                Dim STRNomArch As String = Path.GetFileName(odArchivo.FileName)
                Dim STRExtArch As String = Path.GetExtension(odArchivo.FileName).TrimStart
                Dim STRSoloNomArch As String = Path.GetFileNameWithoutExtension(odArchivo.FileName)
                Dim STRSoloRuta As String = Path.GetDirectoryName(odArchivo.FileName)
                Dim INTtamano As Double = New FileInfo(odArchivo.FileName).Length

                'txt_nombre_archivo.Text = STRNomArch '& "." & STRExtArch
                'txt_des_archivo.Text = STRNomArch

                Dim item As Integer
                item = dtdetalleArchivos.Rows.Count + 1

                Dim pc_name As String = Environment.MachineName

                If reporteBL.GrabarArchivo(_ruta, txtcodigo.Text, "", STRExtArch, STRSoloNomArch, INTtamano, _
                                           LibComunVar.ClsVarComun.USUARIO, pc_name, item, _
                                           IIf(rdb_ficha_tecnica.Checked, rdb_ficha_tecnica.Text, IIf(rdb_hoja_seguridad.Checked, rdb_hoja_seguridad.Text, rdb_procedimiento.Text))) = True Then
                    MessageBox.Show("Archivo guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dtdetalleArchivos = reporteBL.get_Detalle_Archivos(txtcodigo.Text)
                dgvDetalle_Archivo.DataSource = dtdetalleArchivos
                cargarImagen()

                reporteBL = Nothing
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cargarImagen()
        If dgvDetalle_Archivo.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvDetalle_Archivo.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells("EXTENSION").Value = ".png" Or Fila.Cells("EXTENSION").Value = ".jpg" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.fotos
                    ElseIf Fila.Cells("EXTENSION").Value = ".xls" Or Fila.Cells("EXTENSION").Value = ".xlsx" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.excel
                    ElseIf Fila.Cells("EXTENSION").Value = ".pdf" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.pdf
                    ElseIf Fila.Cells("EXTENSION").Value = ".doc" Or Fila.Cells("EXTENSION").Value = ".docx" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.word
                    ElseIf Fila.Cells("EXTENSION").Value = ".doc" Or Fila.Cells("EXTENSION").Value = ".docx" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.word
                    ElseIf Fila.Cells("EXTENSION").Value = ".ppt" Or Fila.Cells("EXTENSION").Value = ".pptx" Then
                        Fila.Cells("ARCHIVO").Value = My.Resources.ppt
                    Else
                        Fila.Cells("ARCHIVO").Value = My.Resources.desconocido
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub dgvDetalle_Archivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle_Archivo.CellContentClick
        'If e.ColumnIndex = 0 Then
        '    Try
        '        Me.Cursor = Cursors.WaitCursor
        '        reporteBL = New ClsBuscar
        '        Dim aBytDocumento() As Byte = Nothing
        '        Dim oFileStream As FileStream

        '        Dim drArchivo As SqlClient.SqlDataReader


        '        Dim item_archivo As Integer = dgvDetalle_Archivo.Item(2, dgvDetalle_Archivo.CurrentRow.Index).Value

        '        drArchivo = reporteBL.Ver_Archivo(txtcodigo.Text, "", item_archivo)
        '        If drArchivo.Read Then
        '            aBytDocumento = CType(drArchivo("bin_arc"), Byte())
        '            'Dim MiFichero As New System.IO.FileInfo("C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"))
        '            Dim MiFichero As New System.IO.FileInfo("C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc"))
        '            If MiFichero.Exists = True Then
        '                MiFichero.Delete()
        '            End If
        '            'oFileStream = New FileStream("C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
        '            oFileStream = New FileStream("C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
        '            oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
        '            oFileStream.Close()
        '            Dim loPSI As New ProcessStartInfo
        '            Dim loProceso As New Process
        '            'loPSI.FileName = "C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc")
        '            loPSI.FileName = "C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc")
        '            loProceso = Process.Start(loPSI)
        '        End If
        '        drArchivo.Close()
        '        drArchivo = Nothing
        '        reporteBL = Nothing
        '        Me.Cursor = Cursors.Default

        '    Catch ex As Exception
        '        Me.Cursor = Cursors.Default
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub cmAbrir_Click(sender As Object, e As EventArgs) Handles cmAbrir.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            reporteBL = New ClsBuscar
            Dim aBytDocumento() As Byte = Nothing
            Dim oFileStream As FileStream

            Dim drArchivo As SqlClient.SqlDataReader
            Dim item_archivo As Integer = dgvDetalle_Archivo.Item(2, dgvDetalle_Archivo.CurrentRow.Index).Value

            drArchivo = reporteBL.Ver_Archivo(txtcodigo.Text, "", item_archivo)
            If drArchivo.Read Then
                aBytDocumento = CType(drArchivo("bin_arc"), Byte())
                'Dim MiFichero As New System.IO.FileInfo("C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"))
                Dim MiFichero As New System.IO.FileInfo("C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc"))
                If MiFichero.Exists = True Then
                    MiFichero.Delete()
                End If
                'oFileStream = New FileStream("C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
                oFileStream = New FileStream("C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
                oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                oFileStream.Close()
                Dim loPSI As New ProcessStartInfo
                Dim loProceso As New Process
                'loPSI.FileName = "C:\NovaQ\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc")
                loPSI.FileName = "C:\INFORNET\" & drArchivo("nom_arc") & drArchivo("ext_arc")
                loProceso = Process.Start(loPSI)
            End If
            drArchivo.Close()
            drArchivo = Nothing
            reporteBL = Nothing
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmDescargar_Click(sender As Object, e As EventArgs) Handles cmDescargar.Click
        Try
            Dim STRRutaSave As String
            Dim item_archivo As Integer = dgvDetalle_Archivo.Item(2, dgvDetalle_Archivo.CurrentRow.Index).Value

            fbAdmArchivos.Description = "Seleccione un destino"
            ' Sets the root folder where the browsing starts from 
            fbAdmArchivos.RootFolder = Environment.SpecialFolder.MyComputer
            Dim dlgResult As DialogResult = fbAdmArchivos.ShowDialog()

            If dlgResult = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                STRRutaSave = fbAdmArchivos.SelectedPath
                reporteBL = New ClsBuscar
                Dim aBytDocumento() As Byte = Nothing
                Dim oFileStream As FileStream

                Dim drArchivo As SqlClient.SqlDataReader

                drArchivo = reporteBL.Ver_Archivo(txtcodigo.Text, "", item_archivo)
                ' drArchivo = reporteBL.Ver_Archivo(lvContenido.SelectedItems(0).Text)
                If drArchivo.Read Then
                    aBytDocumento = CType(drArchivo("bin_arc"), Byte())
                    'Dim MiFichero As New System.IO.FileInfo(STRRutaSave & "\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"))
                    Dim MiFichero As New System.IO.FileInfo(STRRutaSave & "\" & drArchivo("nom_arc") & drArchivo("ext_arc"))
                    If MiFichero.Exists = True Then
                        MiFichero.Delete()
                    End If
                    'oFileStream = New FileStream(STRRutaSave & "\" & drArchivo("nom_arc") & "." & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
                    oFileStream = New FileStream(STRRutaSave & "\" & drArchivo("nom_arc") & drArchivo("ext_arc"), FileMode.CreateNew, FileAccess.Write)
                    oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                    oFileStream.Close()
                    MessageBox.Show("Archivo descargado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                drArchivo.Close()
                drArchivo = Nothing
                reporteBL = Nothing
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmEliminar_Click(sender As Object, e As EventArgs) Handles cmEliminar.Click
        Try
            If dgvDetalle_Archivo.RowCount = 0 Then
                Exit Sub
            End If

            Dim item_archivo As Integer = dgvDetalle_Archivo.Item(2, dgvDetalle_Archivo.CurrentRow.Index).Value

            If MessageBox.Show("¿Seguro que desea eliminar el archivo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                reporteBL = New ClsBuscar
                
                If reporteBL.EliminaArchivo(txtcodigo.Text, "", item_archivo) = True Then
                    MessageBox.Show("Archivo eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                dtdetalleArchivos = reporteBL.get_Detalle_Archivos(txtcodigo.Text)
                dgvDetalle_Archivo.DataSource = dtdetalleArchivos
                cargarImagen()
                reporteBL = Nothing
                Me.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VerFormulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFormulaToolStripMenuItem.Click
        If dgv_detalle_historial_cambios.Rows.Count() = 0 Then Exit Sub
        If dgv_detalle_historial_cambios.CurrentRow Is Nothing Then Exit Sub

        Dim frm As FrmManufactura_Formulas_HC
        frm = New FrmManufactura_Formulas_HC
        frm._id = dgv_detalle_historial_cambios.CurrentRow.Cells("ID").Value
        frm.ShowDialog()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        
    End Sub
End Class