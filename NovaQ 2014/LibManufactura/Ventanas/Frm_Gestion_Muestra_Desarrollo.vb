Imports LibComunVar
Imports LibCobranzas
Imports System.IO
Imports System.Collections.Specialized

Public Class Frm_Gestion_Muestra_Desarrollo
    Dim Modo_actualizar As Boolean = False
    Dim Modo_nuevo As Boolean = False
    Dim dtdetallePrincipal As DataTable
    Private _tipoMov As String = String.Empty

    Dim dtDocumentos As DataTable
    Dim dtv As DataView
    Dim STRorden As String = ""

    Dim _Flag_edicion As Boolean = False
    Dim _Codigo_Ini As String = ""

    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtAlmacen As DataTable
    Private mySetting As NameValueCollection
    Dim vendedorBL As LibCobranzas.ClsOperaciones.SALES_REP
    Dim _contador_despachos As Integer = 0
    Dim _inicio As Boolean = False
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim CAB_QUEJAS_RECLAMOS As ClsEntidades.GESTION_MUESTRAS_DESARROLLO
    Dim CAB_QUEJAS_RECLAMOS_ARCHIVOS As ClsEntidades.QUEJAS_RECLAMOS_ARCHIVOS

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_archivos As DataTable
    Dim archivoByte() As Byte
    Dim archivoByte2() As Byte
    Dim archivoByte3() As Byte

    Dim datos_archivo As ClsEntidades.DATOS_ARCHIVO
    Dim _Modo_Consulta_Archivo As Boolean = False
    Dim dtdetalleArchivos As DataTable

    Private Sub Frm_Gestion_Muestra_Desarrollo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        _inicio = False
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            dtv = New DataView
            STRorden = ""
            dtDocumentos = clsPedidoBl.get_Gestion_Muestra_Desarrollo(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), _
                                                                           cboopcionesBusqueda.SelectedIndex)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                dgvCabecera.Columns("NUMERO").HeaderText = "N°"
                dgvCabecera.Columns("FECHA_VISITA").HeaderText = "FECHA DE VISITA"
                dgvCabecera.Columns("VENDEDOR").HeaderText = "EJECUTIVO"
                dgvCabecera.Columns("CLIENTE").HeaderText = "CLIENTE"
                dgvCabecera.Columns("NOMBRE_MUESTRA").HeaderText = "NOMBRE DE MUESTRA"
                dgvCabecera.Columns("USO").HeaderText = "USO"
                dgvCabecera.Columns("CONSUMO_MENSUAL").HeaderText = "CONSUMO MENSUAL(KG)"
                dgvCabecera.Columns("FECHA_ENVIO_MUESTRA").HeaderText = "FECHA DE ENVIO DE MUESTRA"
                dgvCabecera.Columns("FECHA_RECEPCION_MUESTRA").HeaderText = "FECHA DE RECEPCION DE MUESTRA"
                dgvCabecera.Columns("ESTADO_MUESTRA").HeaderText = "ESTADO DE MUESTRA"
                dgvCabecera.Columns("ESTADO_DESARROLLO").HeaderText = "ESTADO DE DESARROLLO"
                dgvCabecera.Columns("ESTADO_COMERCIAL").HeaderText = "ESTADO COMERCIAL"

                dgvCabecera.Columns("FECHA_ENVIO").HeaderText = "FECHA ENVIO"
                dgvCabecera.Columns("CODIGO_QI").HeaderText = "CODIGO QI"
                dgvCabecera.Columns("CANTIDAD_M").HeaderText = "CANTIDAD /M"


                dgvCabecera.Columns("NUMERO").Width = 100
                dgvCabecera.Columns("FECHA_VISITA").Width = 100
                dgvCabecera.Columns("VENDEDOR").Width = 150
                dgvCabecera.Columns("CLIENTE").Width = 250
                dgvCabecera.Columns("NOMBRE_MUESTRA").Width = 250
                dgvCabecera.Columns("USO").Width = 200
                dgvCabecera.Columns("CONSUMO_MENSUAL").Width = 120
                dgvCabecera.Columns("FECHA_ENVIO_MUESTRA").Width = 150
                dgvCabecera.Columns("FECHA_RECEPCION_MUESTRA").Width = 150
                dgvCabecera.Columns("ESTADO_MUESTRA").Width = 150
                dgvCabecera.Columns("ESTADO_DESARROLLO").Width = 150
                dgvCabecera.Columns("ESTADO_COMERCIAL").Width = 150

                dgvCabecera.Columns("FECHA_ENVIO").Width = 100
                dgvCabecera.Columns("CODIGO_QI").Width = 100
                dgvCabecera.Columns("CANTIDAD_M").Width = 100
                dgvCabecera.Columns("OBSERVACIONES").Width = 350

                STRorden = dgvCabecera.Columns("NUMERO").Name & "+" & dgvCabecera.Columns("CLIENTE").Name & "+" & dgvCabecera.Columns("NOMBRE_MUESTRA").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        DocumentosRequisiones()
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown, dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub CONTROLES(ByVal opcion As Boolean, ByVal _indice As Integer)
        For i As Integer = 0 To Tc_principal.TabPages.Count() - 1
            Tc_principal.TabPages(i).Enabled = False
        Next
        Tc_principal.TabPages(_indice).Enabled = opcion
        Tc_principal.SelectTab(_indice)
    End Sub


    Private Sub Tc_principal_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Tc_principal.Selecting
        If Not Tc_principal.SelectedTab.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Validar_Registro_informes() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de registrar la Muestra para Desarrollo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                CAB_QUEJAS_RECLAMOS = New ClsEntidades.GESTION_MUESTRAS_DESARROLLO
                CAB_QUEJAS_RECLAMOS_ARCHIVOS = New ClsEntidades.QUEJAS_RECLAMOS_ARCHIVOS
                Dim LISTA_CAB_QUEJAS_RECLAMOS_ARCHIVOS As New List(Of ClsEntidades.QUEJAS_RECLAMOS_ARCHIVOS)

                With CAB_QUEJAS_RECLAMOS
                    If Modo_nuevo Then
                        .ID = "0"
                    Else
                        .ID = txtcodigo.Text
                    End If

                    .FECHA = dtp_fecha.Value.ToString("dd/MM/yyyy")
                    .COD_CLIENTE = txt_cod_cliente.Text
                    .CONTACTO = txt_contacto.Text
                    .VENDEDOR = txt_cod_vendedor.Text
                    .FECHA_VISITA = dtp_fecha_visita.Value.ToString("dd/MM/yyyy")
                    .NOMBRE_MUESTRA = txt_nombre_muestra.Text
                    If txt_cantidad_muestra_entregar.Text = "" Then
                        .CANTIDAD_MUESTRA = 0
                    Else
                        .CANTIDAD_MUESTRA = txt_cantidad_muestra_entregar.Text
                    End If
                    If txt_cantidad_proyectada_venta.Text = "" Then
                        .CANTIDAD_PROYECTADA_VENTAS = 0
                    Else
                        .CANTIDAD_PROYECTADA_VENTAS = txt_cantidad_proyectada_venta.Text
                    End If
                    .FECHA_ENVIO_MUESTRA = dtp_fecha_envio_muestra.Value.ToString("dd/MM/yyyy")
                    .FECHA_RECEPCION_MUESTRA = dtp_fecha_recepcion_muestra.Value.ToString("dd/MM/yyyy")
                    .ESTADO_MUESTRA = cbo_estado_muestra.Text
                    .ESTADO_COMERCIAL = cbo_estado_comercial.Text
                    .USER_PC = LibComunVar.ClsVarComun.USUARIO
                    .PC_ID = Environment.MachineName
                    .OBSERVACIONES = txt_observaciones.Text
                    .USO = txt_uso.Text
                    .FECHA_ENVIO = dtp_fecha_envio.Value.ToString("dd/MM/yyyy")
                    .CODIGO_QI = txt_codigo_qi.Text
                    .CANTIDAD_M = txt_cantidad_m.Text
                End With

                Dim _numero_queja_reclamo As Integer
                If clsPedidoBl.Guardar_Gestion_Muestra_Desarrollo(CAB_QUEJAS_RECLAMOS, Modo_nuevo, _numero_queja_reclamo) Then
                    Dim frm_envio As New Frm_Envio_Email_Rpta_Pre_Flyte
                    frm_envio._numero_queja_reclamo = _numero_queja_reclamo
                    frm_envio._cliente = txt_des_cliente.Text
                    frm_envio._producto = txt_nombre_muestra.Text
                    frm_envio.ShowDialog()

                    MsgBox("Proceso Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    DocumentosRequisiones()
                    btnCancelar_Click(sender, e)
                    Me.Cursor = Cursors.Default
                End If
            End If


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar_Registro_informes() As Boolean
        Try
            If txt_cod_cliente.Text = "" Then
                MsgBox("Debe elegir un CLiente.", MsgBoxStyle.Exclamation)
                txt_cod_cliente.Focus()
                Return False
            End If
            If txt_cod_vendedor.Text = "" Then
                MsgBox("Debe elegir un Vendedor.", MsgBoxStyle.Exclamation)
                txt_cod_vendedor.Focus()
                Return False
            End If
            If txt_nombre_muestra.Text = "" Then
                MsgBox("Debe ingresar el nombre de la muestra", MsgBoxStyle.Exclamation)
                txt_nombre_muestra.Focus()
                Return False
            End If
            If txt_cantidad_muestra_entregar.Text = "" Then
                MsgBox("Debe registrar la cantidad de muestra a entregar.", MsgBoxStyle.Exclamation)
                txt_cantidad_muestra_entregar.Focus()
                Return False
            End If
            If txt_cantidad_proyectada_venta.Text = "" Then
                MsgBox("Debe registrar la cantidad proyectada de ventas.", MsgBoxStyle.Exclamation)
                txt_cantidad_proyectada_venta.Focus()
                Return False
            End If

            If cbo_estado_muestra.SelectedIndex = -1 Then
                MsgBox("Debe elegir un estado de la muestra.", MsgBoxStyle.Exclamation)
                cbo_estado_muestra.Focus()
                Return False
            End If

            If cbo_estado_comercial.SelectedIndex = -1 Then
                MsgBox("Debe elegir un estado comercial.", MsgBoxStyle.Exclamation)
                cbo_estado_comercial.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If dgvCabecera.RowCount() = 0 Then Exit Sub
            If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

            Me.Cursor = Cursors.WaitCursor

            Botonera_Estado_Cambiar(True)
            Modo_actualizar = True
            Modo_nuevo = False

            'btn_ver_formato.Visible = True
            limpiar()
            CONTROLES(True, 0)
            pnlCabecera.Visible = False
            MostrarModoConsultar()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModoConsultar()
        Try

            dtCabeceraReq = New DataTable
            dtDetalleReq = New DataTable
            '---Mostrando Datos de Cabecera
            Dim codigo As String = ""

            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("NUMERO").Value

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS

            dtdetalleArticuloPrincipal = clsPedidoBl.get_Gestion_Muestra_Desarrollo(txtcodigo.Text)
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dtp_fecha.Value = dtdetalleArticuloPrincipal.Rows(0).Item("FECHA")
                txt_cod_cliente.Text = dtdetalleArticuloPrincipal.Rows(0).Item("COD_CLIENTE")
                txt_des_cliente.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CLIENTE")
                txt_contacto.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CONTACTO")
                txt_cod_vendedor.Text = dtdetalleArticuloPrincipal.Rows(0).Item("VENDEDOR")
                txt_des_vendedor.Text = dtdetalleArticuloPrincipal.Rows(0).Item("VENDEDOR_NOMBRE")
                dtp_fecha_visita.Value = dtdetalleArticuloPrincipal.Rows(0).Item("FECHA_VISITA")
                txt_nombre_muestra.Text = dtdetalleArticuloPrincipal.Rows(0).Item("NOMBRE_MUESTRA")
                txt_cantidad_muestra_entregar.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CANTIDAD_MUESTRA")
                txt_cantidad_proyectada_venta.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CANTIDAD_PROYECTADA_VENTAS")
                dtp_fecha_envio_muestra.Value = dtdetalleArticuloPrincipal.Rows(0).Item("FECHA_ENVIO_MUESTRA")
                dtp_fecha_recepcion_muestra.Value = dtdetalleArticuloPrincipal.Rows(0).Item("FECHA_RECEPCION_MUESTRA")
                cbo_estado_muestra.Text = dtdetalleArticuloPrincipal.Rows(0).Item("ESTADO_MUESTRA")
                cbo_estado_comercial.Text = dtdetalleArticuloPrincipal.Rows(0).Item("ESTADO_COMERCIAL")
                txt_observaciones.Text = dtdetalleArticuloPrincipal.Rows(0).Item("OBSERVACIONES")
                txt_uso.Text = dtdetalleArticuloPrincipal.Rows(0).Item("USO")

                dtp_fecha_envio.Value = dtdetalleArticuloPrincipal.Rows(0).Item("FECHA_ENVIO")
                txt_codigo_qi.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CODIGO_QI")
                txt_cantidad_m.Text = dtdetalleArticuloPrincipal.Rows(0).Item("CANTIDAD_M")

                dtdetalleArchivos = clsPedidoBl.get_Detalle_Archivos_Gestion_Muestra_Desarrollo(txtcodigo.Text)
                dgv_lista_archivos_dd.DataSource = dtdetalleArchivos

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte


            Dim dt_certificado_calidad As DataTable

            dt_certificado_calidad = clsPedidoBl.get_Queja_Reclamo_Detalle(dgvCabecera.CurrentRow.Cells("NUMERO").Value)

            If dt_certificado_calidad.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Quejas_Reclamos.rpt", dt_certificado_calidad, "", "", _
                                                  "@ID_CAB;" & dgvCabecera.CurrentRow.Cells("NUMERO").Value)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Close()
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btn_actualizar.Enabled = False
            btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
            btnImprimir.Enabled = False
        Else
            btnNuevo.Enabled = True
            btn_actualizar.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btnImprimir.Enabled = True
        End If
    End Sub

    Private Sub limpiar()
        _contador_despachos = 0
        txtcodigo.Text = "0"
        dtp_fecha.Value = Date.Now
        txt_cod_cliente.Text = ""
        txt_des_cliente.Text = ""
        txt_contacto.Text = ""
        txt_cod_vendedor.Text = ""
        txt_des_vendedor.Text = ""
        dtp_fecha_visita.Value = Date.Now
        txt_nombre_muestra.Text = ""
        txt_cantidad_muestra_entregar.Text = ""
        txt_cantidad_proyectada_venta.Text = ""
        dtp_fecha_envio_muestra.Value = Date.Now
        dtp_fecha_recepcion_muestra.Value = Date.Now
        cbo_estado_muestra.SelectedIndex = -1
        cbo_estado_comercial.SelectedIndex = -1

        txt_ruta_archivo_dd.Text = ""
        txt_descripcion_archivo_dd.Text = ""
        TabControl1.SelectedIndex = 0
        txt_observaciones.Text = ""
        txt_uso.Text = ""

        dtp_fecha_envio.Value = Date.Now
        txt_codigo_qi.Text = ""
        txt_cantidad_m.Text = ""

        If dgv_lista_archivos_dd.RowCount() <> 0 Then
            For n As Integer = dgv_lista_archivos_dd.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgv_lista_archivos_dd.Rows(n)
                dgv_lista_archivos_dd.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            _inicio = True
            Modo_actualizar = False
            Modo_nuevo = True
            Ayuda_Vendedor(LibComunVar.ClsVarComun.VENDEDOR)
            txt_cod_cliente.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable("Detalles_Compra")
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
            dtdetalleArticuloPrincipal.Columns.Add("NRO_SOLICITUD", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("FECHA_INICIAL", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("FECHA_FINAL", Type.GetType("System.String")) '3
            dtdetalleArticuloPrincipal.Columns.Add("SOLICITANTE", Type.GetType("System.String")) '4
            dtdetalleArticuloPrincipal.Columns.Add("MAQUINA", Type.GetType("System.String")) '5
            dtdetalleArticuloPrincipal.Columns.Add("ASUNTO", Type.GetType("System.String")) '6

            dtdetalleArticuloPrincipal.Columns.Add("TIPO_MANTENIMIENTO", Type.GetType("System.String")) '7
            dtdetalleArticuloPrincipal.Columns.Add("TIPO_ATENCION", Type.GetType("System.String")) '8
            dtdetalleArticuloPrincipal.Columns.Add("HORA_INICIO", Type.GetType("System.String")) '9
            dtdetalleArticuloPrincipal.Columns.Add("HORA_FIN", Type.GetType("System.String")) '10
            dtdetalleArticuloPrincipal.Columns.Add("DETALLE_SERVICIO", Type.GetType("System.String")) '11
            dtdetalleArticuloPrincipal.Columns.Add("RECOMENDACION", Type.GetType("System.String")) '12
            dtdetalleArticuloPrincipal.Columns.Add("SOLICITANTE_DESC", Type.GetType("System.String")) '13
            dtdetalleArticuloPrincipal.Columns.Add("MAQUINA_DESC", Type.GetType("System.String")) '14

            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            'dgvDetalle.DataSource = Nothing
            'dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            'dgvDetalle.AutoResizeColumns()
            'dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            'dgvDetalle.Columns(0).HeaderText = "Item"
            'dgvDetalle.Columns(1).HeaderText = "N° Solicitud"
            'dgvDetalle.Columns(2).HeaderText = "Fecha Inicial"
            'dgvDetalle.Columns(3).HeaderText = "Fecha Final"
            'dgvDetalle.Columns(4).Visible = False '.HeaderText = "Solicitante"
            'dgvDetalle.Columns(5).Visible = False '.HeaderText = "Maquina"
            'dgvDetalle.Columns(6).HeaderText = "Asunto"

            'dgvDetalle.Columns(7).HeaderText = "Tipo Mantenimiento"
            'dgvDetalle.Columns(8).HeaderText = "Tipo Atención"
            'dgvDetalle.Columns(9).HeaderText = "Hora Inicio"
            'dgvDetalle.Columns(10).HeaderText = "Hora Fin"
            'dgvDetalle.Columns(11).Visible = False
            'dgvDetalle.Columns(12).Visible = False
            'dgvDetalle.Columns(13).HeaderText = "Solicitante"
            'dgvDetalle.Columns(14).Visible = False

        End If
    End Sub


    Private Function Numeracion() As String
        'Dim Correlativo As String = String.Empty
        'Try
        '    vendedorBL = New LibCobranzas.ClsOperaciones.SALES_REP
        '    Dim dtdetalles As DataTable
        '    dtdetalles = New DataTable("CodigoVendedor")
        '    dtdetalles = vendedorBL.get_Codigo_Informes_Mantenimiento()
        '    If dtdetalles.Rows.Count() <> 0 Then
        '        Correlativo = String.Format("{0:0000000000}", CInt(dtdetalles.Rows(0).Item("NUMBER").ToString) + 1)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Return Correlativo
    End Function


    Private Sub Mostrando_Equipos_Planta(ByVal texto_cod As TextBox, ByVal texto_Des As TextBox, ByVal _tipo As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_EQUIPOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _tipo
            frm.Titulo = "Seleccion de Procesos o Equipos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                texto_Des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns("NUMERO").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns("CLIENTE").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns("NOMBRE_MUESTRA").Name
                        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgvCabecera.Columns("NUMERO").Name & "+" & dgvCabecera.Columns("CLIENTE").Name & "+" & dgvCabecera.Columns("NOMBRE_MUESTRA").Name
                            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                            Exit Sub
                        End If
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    If dgvCabecera.RowCount() = 0 Then Exit Sub
        '    If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        '    Botonera_Estado_Cambiar(True)
        '    Modo_actualizar = True
        '    limpiar()

        '    pnlCabecera.Visible = False
        '    MostrarModoConsultar()

        '    'dgvDetalle.Columns("EstadoEjecucion").Visible = True
        '    'dgvDetalle.Columns("FechaEjecucion").Visible = True
        '    'dgvDetalle.Columns("obsejecucion").Visible = True

        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    MsgBox(ex.Message)
        'End Try
    End Sub



    Private Sub dgvCabecera_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCabecera.CellFormatting
        
        If dgvCabecera.Rows(e.RowIndex).Cells("ESTADO_MUESTRA").Value = "Muestra Enviada" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        ElseIf dgvCabecera.Rows(e.RowIndex).Cells("ESTADO_MUESTRA").Value = "Muestra Recibida" Then
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        Else
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgvCabecera.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If

    End Sub

    Private Sub txtsolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_cliente.MouseDoubleClick
        Ayuda_Solicitante()
    End Sub

    Private Sub txtsolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Solicitante()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_cliente.Text = "" Then
                Ayuda_Solicitante()
            Else
                txt_contacto.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Solicitante()
        Try

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_ORDER_CLIENTE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Clientes"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_cliente.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_cliente.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                txt_contacto.Text = frm.Data_Matriz.Rows(0).Item("CONTACTO").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Try
            _Flag_edicion = False
            CONTROLES(True, 1)
            blank()
            btn_menu.Enabled = False

            txtcodigo.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub blank()
        'txtcodigo.Text = ""
        'cbo_tipo_mantenimiento.SelectedIndex = -1
        'cbo_tipo_atencion.SelectedIndex = -1
        'dtp_fecha_inicio.Value = Date.Today
        'dtp_Fecha_final.Value = Date.Today
        'txtsolicitante.Text = ""
        'txtdescripcion_solicitante.Text = ""
        'txt_titulo_informe.Text = ""
        'dtp_horario_inicio.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        'dtp_horario_final.Value = Date.Now.ToString("dd/MM/yyyy") & " 00:00:00"
        'txt_detalle_servicio.Text = ""
        'txt_recomendaciones.Text = ""
        '_contador_despachos = 0
        'cbo_nivel_importancia.SelectedIndex = -1
        'TabControl1.SelectedIndex = 0

        'txt_ruta_archivo_dd.Text = ""
        'txt_descripcion_archivo_dd.Text = ""
    End Sub



    Private Function ValidacionesGeneralesArticulo() As Boolean
        'Dim estado As Boolean = True
        'Try
        '    If txtcodigo.Text = String.Empty Then
        '        MsgBox("Debe ingresar un codigo de solicitud.", MsgBoxStyle.Exclamation, "Sistemas")
        '        estado = False
        '        txtcodigo.Focus()
        '        Exit Try
        '    ElseIf cbo_tipo_mantenimiento.SelectedIndex = -1 Then
        '        MsgBox("Debe elegir un Tipo de Mantenimiento.", MsgBoxStyle.Exclamation, "Sistemas")
        '        estado = False
        '        cbo_tipo_mantenimiento.Focus()
        '        Exit Try
        '    ElseIf cbo_tipo_atencion.SelectedIndex = -1 Then
        '        MsgBox("Debe elegir un Tipo de Atención.", MsgBoxStyle.Exclamation, "Sistemas")
        '        estado = False
        '        cbo_tipo_atencion.Focus()
        '        Exit Try
        '    ElseIf txtsolicitante.Text = "" Then
        '        MsgBox("Debe elegir un Solicitante.", MsgBoxStyle.Exclamation, "Sistemas")
        '        estado = False
        '        txtsolicitante.Focus()
        '        Exit Try
        '    ElseIf txt_titulo_informe.Text = "" Then
        '        MsgBox("Debe ingresar un Asunto de la Solicitud.", MsgBoxStyle.Exclamation, "Sistemas")
        '        estado = False
        '        txt_titulo_informe.Focus()
        '        Exit Try
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    estado = False
        'End Try
        'Return estado
    End Function


    Private Sub btn_ruta_archivo_dd_Click(sender As Object, e As EventArgs) Handles btn_ruta_archivo_dd.Click
        Try
            Dim archivo As New OpenFileDialog
            archivo.Title = "Selecccionar archivo"
            archivo.Filter = "Archivo *|*.*"
            If archivo.ShowDialog = DialogResult.OK Then
                datos_archivo = New ClsEntidades.DATOS_ARCHIVO
                If archivo.FileName <> "" Then
                    Dim fi As New FileInfo(archivo.FileName)

                    If fi.Exists Then
                        'If (fi.Length / 1024) > 102400 Then
                        '    MsgBox("El tamaño del archivo es: " & Math.Round(((fi.Length / 1024) / 1024), 2).ToString() & " Mb" & Chr(13) & "Supera el maximo permitido!!!", MsgBoxStyle.Exclamation, "Sistemas")
                        '    Exit Sub
                        'End If
                    Else
                        MsgBox("No existe el archivo.", MsgBoxStyle.Exclamation, "Sistemas")
                        Exit Sub
                    End If
                    Me.txt_ruta_archivo_dd.Text = archivo.SafeFileName()
                    Me.Cursor = Cursors.WaitCursor
                    Dim RUTA_ As New FileStream(archivo.FileName, FileMode.Open, FileAccess.Read)
                    Dim binario(RUTA_.Length) As Byte
                    RUTA_.Read(binario, 0, RUTA_.Length)
                    RUTA_.Close()

                    With datos_archivo
                        .ARCHIVO = binario
                        archivoByte = binario
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .PC_ID = Environment.MachineName
                        .NOMBRE_ARCHIVO = archivo.SafeFileName
                        .DES_ARCHIVO = txt_descripcion_archivo_dd.Text
                        .IP_PC = ""
                    End With
                    _Modo_Consulta_Archivo = True
                Else
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_agregar_archivo_dd_Click(sender As Object, e As EventArgs) Handles btn_agregar_archivo_dd.Click
        If ValidacionesArchivos_Dd() = False Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dt_datos_proyecto_descarga As DataTable
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dt_datos_proyecto_descarga = New DataTable
            Dim dt_item_archivo As New DataTable

            datos_archivo = New ClsEntidades.DATOS_ARCHIVO

            If Modo_nuevo Then
                txtcodigo.Text = "0"
            End If

            dt_item_archivo = clsPedidoBl.get_item_archivo_Gestion_Muestra_Desarrollo(txtcodigo.Text)
            Dim item As Integer

            If dt_item_archivo.Rows.Count() <> 0 Then
                For Each row2 As DataRow In dt_item_archivo.Rows
                    item = row2("ITEM_ARCHIVO").ToString + 1
                Next
            Else
                item = 1
            End If

            With datos_archivo
                .ARCHIVO = archivoByte
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .PC_ID = Environment.MachineName
                .NOMBRE_ARCHIVO = txt_ruta_archivo_dd.Text
                .ITEM = item
                .DES_ARCHIVO = txt_descripcion_archivo_dd.Text
                .IP_PC = ""
            End With

            If clsPedidoBl.Grabar_Archivo_Gestion_Muestra_Desarrollo(txtcodigo.Text, datos_archivo) Then
                dtdetalleArchivos = clsPedidoBl.get_Detalle_Archivos_Gestion_Muestra_Desarrollo(txtcodigo.Text)
                dgv_lista_archivos_dd.DataSource = dtdetalleArchivos

                txt_ruta_archivo_dd.Text = String.Empty
                txt_descripcion_archivo_dd.Text = String.Empty
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidacionesArchivos_Dd() As Boolean
        Dim estado As Boolean = True
        'Dim sender As Object
        'Dim e As EventArgs
        Try
            If txt_ruta_archivo_dd.Text = String.Empty Then
                MsgBox("Debe selecionar un archivo.", MsgBoxStyle.Exclamation)
                estado = False
                Exit Try
            ElseIf txt_descripcion_archivo_dd.Text = String.Empty Then
                MsgBox("Debe ingresar una descripción del archivo.", MsgBoxStyle.Exclamation)
                estado = False
                txt_descripcion_archivo_dd.Focus()
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub dgv_lista_archivos_dd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista_archivos_dd.CellClick
        If dgv_lista_archivos_dd.RowCount() = 0 Then Exit Sub
        If dgv_lista_archivos_dd.CurrentRow Is Nothing Then Exit Sub
        If e.ColumnIndex = 0 Then 'descargar archivo
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim Codigo As String = String.Empty
                Dim dt_datos_proyecto_descarga As DataTable
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                dt_datos_proyecto_descarga = New DataTable
                Codigo = dgv_lista_archivos_dd.CurrentRow.Cells("ITEM_2").Value
                dt_datos_proyecto_descarga = clsPedidoBl.get_datos_archivo_descargar_Gestion_Muestra_Desarrollo(txtcodigo.Text, Codigo)
                If dt_datos_proyecto_descarga.Rows.Count() <> 0 Then
                    If dt_datos_proyecto_descarga.Rows(0).Item("ARCHIVO") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        Dim directorio_archivo As String = ""

                        Dim Carpeta As New FolderBrowserDialog
                        If Carpeta.ShowDialog() = DialogResult.OK Then
                            directorio_archivo = Carpeta.SelectedPath.ToString & "\" & dt_datos_proyecto_descarga.Rows(0).Item("NOMBRE_ARCHIVO").ToString
                        End If
                        bytes = dt_datos_proyecto_descarga.Rows(0).Item("ARCHIVO")
                        BytesaArchivo(bytes, directorio_archivo)

                        Try
                            Process.Start(directorio_archivo)
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try

                        'MsgBox("Archivo descargado correctamente", MsgBoxStyle.Information, "Aviso")
                    Else
                        MsgBox("No existe el archivo en la base de datos. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
                    End If
                Else
                    MsgBox("No existe el archivo en la base de datos. Verifique!!!", MsgBoxStyle.Critical, "Aviso")
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try
        End If

        If e.ColumnIndex = 1 Then 'eliminar archivo
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim item As String = String.Empty
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                item = dgv_lista_archivos_dd.CurrentRow.Cells("ITEM_2").Value

                If MessageBox.Show("Se va a eliminar el archivo" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    If clsPedidoBl.Eliminar_Archivo_Gestion_Muestra_Desarrollo(txtcodigo.Text, item) Then
                        dtdetalleArchivos = clsPedidoBl.get_Detalle_Archivos_Gestion_Muestra_Desarrollo(txtcodigo.Text)
                        dgv_lista_archivos_dd.DataSource = dtdetalleArchivos
                    End If

                    Me.Cursor = Cursors.Default
                End If

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Public Sub BytesaArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim k As Long
        If bytes Is Nothing Then Exit Sub

        Try
            k = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, k)
            fs.Close()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub cbo_tipo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_cod_cliente.Focus()
        End If
    End Sub

    Private Sub txt_contacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_vendedor.Focus()
        End If
    End Sub


    Private Sub txt_cod_vendedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vendedor.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub

    Private Sub txt_cod_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vendedor.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Vendedor()
        If e.KeyCode = Keys.Enter Then
            If txt_cod_vendedor.Text = String.Empty Then
                Ayuda_Vendedor()
            Else
                dtp_fecha_visita.Focus() ' Ayuda_Vendedor(txtvendedor.Text)
            End If
        End If
    End Sub

    Private Sub Ayuda_Vendedor(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Vendedor"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txt_cod_vendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    txt_des_vendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            Else
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Dim dtDetalleVend As New DataTable("Vendedor")
                dtDetalleVend = clsPedidoBl.Get_ManualVendedor(_CodigoVendedor)
                If dtDetalleVend.Rows.Count() <> 0 Then
                    txt_cod_vendedor.Text = dtDetalleVend.Rows(0).Item(0).ToString
                    txt_des_vendedor.Text = dtDetalleVend.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txt_cod_vendedor.Text = String.Empty
                    txt_des_vendedor.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cantidad_muestra_entregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_muestra_entregar.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_proyectada_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_proyectada_venta.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class