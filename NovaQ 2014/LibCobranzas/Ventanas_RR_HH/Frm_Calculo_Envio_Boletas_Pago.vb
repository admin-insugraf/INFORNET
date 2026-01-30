Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports LibComunVar
Imports System.Net.Http
Imports System.Net
Imports System.Threading
Imports System.Net.Mail
Imports LibCobranzas
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Net.Mime

Public Class Frm_Calculo_Envio_Boletas_Pago
    Dim clienteBL As ClsNegocio.Personal_RRHH
    Dim dtv_detalle As DataView
    Dim clsPedidoBl As ClsOperaciones.ORDERS
    Dim clsBusquedaBl As ClsBuscar
    Dim dtv_bandeja_pre_prensa As DataView
    Dim dtv_bandeja_pre_prensa_op As DataView
    Dim STRorden_bandeja_pre_prensa As String = String.Empty
    Dim STRorden_bandeja_pre_prensa_op As String = String.Empty
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtdetalle_pre_prensa As DataTable
    Dim flag_modificar_logistica As Boolean = False
    Dim pl_planilla_cab As ClsEntidades.PL_PLANILLA
    Dim pl_planilla_det As ClsEntidades.PL_PLANILLA_LINE
    Dim pl_planilla_det_conceptos_variables As ClsEntidades.PL_PLANILLA_LINE_CONCEPTOS_VARIABLES
    Dim Codigo_logistica As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS
    Dim id_op_planeamiento As Integer
    Dim vendedorBL As LibCobranzas.ClsOperaciones.SALES_REP
    Dim _inicio As Boolean = False
    Dim _codigo_planilla As Integer = 0
    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String
    Dim dtTrabajos_Mantenimiento As DataTable
    Dim Modo_actualizar As Boolean = False

    Dim dtDocumentos As DataTable
    Dim dtDocumentos_ingresos_Descuentos_variables As DataTable
    Dim dt_ingresos_variables As DataTable
    Dim dt_descuentos_variables As DataTable
    Dim dtv As DataView
    Dim dtv_conceptos_variables As DataView
    Dim STRorden As String = ""
    Dim STRorden_conceptos_variables As String = ""
    Dim _codigo_personal As String = ""
    Dim dtCabeceraReq As DataTable
    Dim dtDetalleReq As DataTable

    Dim Modo_Edicion As Boolean = False
    Dim dtDocumentosPrincipal As DataTable
    Dim dtDocumentosPrincipal_totales As DataTable
    Dim dtDetalle As DataTable
    Dim listaProductos As List(Of ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO_DETALLE)
    Dim articuloBE As ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO_DETALLE
    Dim cabeceraBE As ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO
    Dim ArticulosBl As ClsOperaciones.PART
    Dim Correlativo As Integer = 0
    Dim fecha_variable As String = String.Empty
    Dim Lista_Personal As List(Of String)
    Public _estado_enviado As Integer = 0

    Dim _TIPO As String = ""

    Dim _periodo_ini As String = ""
    Dim _periodo_fin As String = ""
    Dim periodo As String = ""

    'Dim _REMITENTE As String
    'Dim _RECEPCIONANTE As String
    'Dim _SERVER As String
    'Dim _USUARIO As String
    'Dim _PASSWORD As String
    'Dim _ASUNTO As String
    'Dim _TITULO As String
    'Dim _PUERTO As String
    Dim _mensaje As String

    Private Sub Frm_Calculo_Envio_Boletas_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        _inicio = False
        ocultarElementos()
        dtpfechaInicial.Value = "01/01/" & ClsVarComun.FechaSistema.Year.ToString
        dtpfechafinal.Value = "31/12/" & ClsVarComun.FechaSistema.Year.ToString
        cboopcionesBusqueda.SelectedIndex = 1
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub ocultarElementos()
        Label10.Visible = False
        txtRuta.Visible = False
        btnRuta.Visible = False
        btn_enviarEmail.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub mostrarElementos()
        Label10.Visible = True
        txtRuta.Visible = True
        btnRuta.Visible = True
        btn_enviarEmail.Visible = True
        ProgressBar1.Visible = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btnNuevo.Enabled = False
            btnGrabar.Enabled = True
            btnConsultar.Enabled = False
            btnCancelar.Enabled = True
        Else
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnConsultar.Enabled = True
            btnCancelar.Enabled = False
            btn_enviarEmail.Visible = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlCabecera.Visible = True
        Botonera_Estado_Cambiar(False)
        limpiar()
        GbCabecera.Enabled = False
        'DocumentosRequisiones()
    End Sub

    Private Sub limpiar()
        txtcodigo.Text = ""
        txt_titulo.Text = ""
        ocultarElementos()

        If dgv_Lista_detalle.RowCount() <> 0 Then
            For n As Integer = dgv_Lista_detalle.Rows.Count - 1 To 0 Step -1
                Dim row As DataGridViewRow = dgv_Lista_detalle.Rows(n)
                dgv_Lista_detalle.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub Nuevo()
        Try
            limpiar()
            Botonera_Estado_Cambiar(True)
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            _inicio = True
            _codigo_planilla = 0
            Modo_Edicion = False
            btn_anexar.Enabled = True
            btn_anexar.Visible = True
            tc_tipos.SelectedIndex = 0
            dtpFecha_planilla.Value = Date.Now
            Formato_Grilla()
            txt_titulo.Text = "BOLETA DE PAGO " & MonthName(dtpFecha_planilla.Value.Month) & " - " & dtpFecha_planilla.Value.Year
            txt_titulo.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_anexar_Click(sender As Object, e As EventArgs) Handles btn_anexar.Click
        Try
            If txt_titulo.Text = "" Then
                MsgBox("Debe ingresar un titulo.", MsgBoxStyle.Information, "Sistemas")
                txt_titulo.Focus()
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            If dgv_Lista_detalle.RowCount() <> 0 Then
                For n As Integer = dgv_Lista_detalle.Rows.Count - 1 To 0 Step -1
                    Dim row As DataGridViewRow = dgv_Lista_detalle.Rows(n)
                    dgv_Lista_detalle.Rows.Remove(row)
                Next
            End If

            clienteBL = New ClsNegocio.Personal_RRHH

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PL_S_PL_PLANILLA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Planillas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                dtDocumentosPrincipal = New DataTable
                dtDocumentosPrincipal = clienteBL.get_Personal_RRHH_new_Envio_Boletas(frm.Data_Matriz.Rows(0).Item(0), frm.Data_Matriz.Rows(0).Item("TIPO"))

                If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                    dgv_Lista_detalle.DataSource = dtDocumentosPrincipal
                    lblCantidad_detalle.Text = "Se encontraron " & dtDocumentosPrincipal.Rows.Count() & " registros"
                    _TIPO = frm.Data_Matriz.Rows(0).Item("TIPO")
                End If

            End If
            frm.Close()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Personal()
        Try
            clienteBL = New ClsNegocio.Personal_RRHH
            dtv = New DataView
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal = clsPedidoBl.Get_Datos_Detalle_Boletas_Pago(_codigo_planilla)

            If dtDocumentosPrincipal.Rows.Count() <> 0 Then
                dgv_Lista_detalle.DataSource = dtDocumentosPrincipal
                lblCantidad_detalle.Text = "Se encontraron " & dtDocumentosPrincipal.Rows.Count() & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dgv_Lista_detalle.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            If txt_titulo.Text = String.Empty Then
                MsgBox("Debe ingresar un titulo.", MsgBoxStyle.Information, "Sistemas")
                txt_titulo.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            'If VerificarMesAnioBoleta(dtpFecha_planilla.Value) = False Then
            '    MsgBox("Ya existe boletas generadas de: " & MonthName(dtpFecha_planilla.Value.Month) & "/" & dtpFecha_planilla.Value.Year, MsgBoxStyle.Information, "Sistemas")
            '    dtpFecha_planilla.Focus()
            '    Me.Cursor = Cursors.Default
            '    Exit Sub
            'End If

            If MessageBox.Show("Se van a registrar las boletas de pago" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                If Guardar_Boletas_Pago() Then
                    MsgBox("Boletas de pago guardado correctamente.", MsgBoxStyle.Information)
                    mostrarElementos()
                    dgv_Lista_detalle.Columns("STATUS_ENVIO_BOLETA").Visible = True
                    btnGrabar.Enabled = False
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosRequisiones()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    System.Windows.Forms.MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If
            clsPedidoBl = New ClsOperaciones.ORDERS
            dtDocumentos = New DataTable
            dtv = New DataView
            STRorden = ""
            dtDocumentos = clsPedidoBl.get_Lista_Boletas_Pago_Enviados(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"),
                                                                           cboopcionesBusqueda.SelectedIndex)
            dgvCabecera.DataSource = Nothing
            dtv = dtDocumentos.DefaultView
            If dtDocumentos.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtv

                dgvCabecera.Columns("ID").HeaderText = "CODIGO"
                dgvCabecera.Columns("TITULO").HeaderText = "TITULO"
                dgvCabecera.Columns("FECHA").HeaderText = "FECHA BOLETA"

                dgvCabecera.Columns("TITULO").Width = 400
                dgvCabecera.Columns("FECHA").Visible = False

                STRorden = dgvCabecera.Columns("ID").Name & "+" & dgvCabecera.Columns("TITULO").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Guardar_Boletas_Pago() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            listaProductos = New List(Of ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO_DETALLE)
            cabeceraBE = New ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO

            With cabeceraBE
                If Modo_Edicion = False Then 'nuevo
                    .NUMBER_DOCUMENT = 0
                Else ' ACTUALIZAMOS
                    .NUMBER_DOCUMENT = _codigo_planilla
                End If
                .DESCRIPCION = txt_titulo.Text
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .NOMBRE_PC = Environment.MachineName
                Dim ip As System.Net.IPHostEntry
                ip = Dns.GetHostEntry(.NOMBRE_PC)
                .IP_PC = ip.AddressList(1).ToString
                .FECHA = dtpFecha_planilla.Value
                .TIPO = _TIPO
            End With

            For Each row As DataGridViewRow In dgv_Lista_detalle.Rows
                articuloBE = New ClsEntidades.PL_ATTENDENCE_STAFF_BOLETAS_PAGO_DETALLE
                articuloBE.EMPLOYEE_ID = row.Cells("CODIGO").Value
                articuloBE.NOMBRES = row.Cells("NOMBRE").Value
                articuloBE.APELLIDO_PATERNO = row.Cells("APELLIDO_PATERNO").Value
                articuloBE.APELLIDO_MATERNO = row.Cells("APELLIDO_MATERNO").Value
                articuloBE.EMAIL = row.Cells("EMAIL").Value
                listaProductos.Add(articuloBE)
            Next

            ArticulosBl = New ClsOperaciones.PART

            If ArticulosBl.Insert_Boletas_Pago(listaProductos, cabeceraBE, Modo_Edicion) Then
                Me.Cursor = Cursors.Default
                ArticulosBl = Nothing
                Return True
            Else
                Return False
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function VerificarMesAnioBoleta(_fecha As Date) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New ClsOperaciones.ORDERS
            'Mostrando datos del detalle
            Dim dtFecha As New DataTable

            dtFecha = clsPedidoBl.Get_Datos_Fecha_Boleta_Pago(_fecha)

            If dtFecha.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
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
        txtFiltro.Text = String.Empty
        DocumentosRequisiones()
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtDocumentosPrincipal = New DataTable
            dtDocumentosPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NOMBRE", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("APELLIDO_PATERNO", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("APELLIDO_PATERNO", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("EMAIL", Type.GetType("System.String"))
            dtDocumentosPrincipal.Columns.Add("STATUS_ENVIO_BOLETA", Type.GetType("System.String"))
            dgv_Lista_detalle.DataSource = Nothing
            dgv_Lista_detalle.DataSource = dtDocumentosPrincipal
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Formato_Grilla()
        If dtDocumentos.Rows.Count() <> 0 Then
            dgv_Lista_detalle.Columns("CODIGO").Visible = True
            dgv_Lista_detalle.Columns("NOMBRE").Visible = True
            dgv_Lista_detalle.Columns("APELLIDO_PATERNO").Visible = True
            dgv_Lista_detalle.Columns("APELLIDO_MATERNO").Visible = True
            dgv_Lista_detalle.Columns("NUMERO_DOCUMENTO").Visible = False
            dgv_Lista_detalle.Columns("EMAIL").Visible = True
            dgv_Lista_detalle.Columns("STATUS_ENVIO_BOLETA").Visible = False
            dgv_Lista_detalle.Columns("NOMBRE_COMPLETO").Visible = False

            'dgv_Lista_detalle.Columns("HE_100").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub


    Private Sub btnRuta_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRuta_Click_1(sender As Object, e As EventArgs) Handles btnRuta.Click

        Dim Carpeta As New FolderBrowserDialog
        If Carpeta.ShowDialog() = DialogResult.OK Then
            Me.txtRuta.Text = Carpeta.SelectedPath.ToString
        End If
    End Sub

    Private Sub btn_enviarEmail_Click(sender As Object, e As EventArgs) Handles btn_enviarEmail.Click
        clienteBL = New ClsNegocio.Personal_RRHH
        If dgv_Lista_detalle.CurrentRow Is Nothing Then Exit Sub

        If txtRuta.Text = "" Then
            MsgBox("Indicar la ruta donde se encuentran las boletas de pago", MsgBoxStyle.Exclamation)
            btnRuta_Click_1(sender, e)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Envio_Mail_Cliente As String
            Dim StrNomArchivo_PDF As String = ""
            Dim mensaje_ As String = ""
            Dim nombre_trabajador As String = ""
            Dim clienteBL As ClsOperaciones.CUSTOMER
            clienteBL = New ClsOperaciones.CUSTOMER
            Dim personal_RR_HH As New ClsEntidades.PL_EMPLOYEE
            Dim id_cab As Integer = 0

            Dim _TIPO_BOLETA As String = ""
            Dim _mensaje_tipo As String = ""

            'Dim periodo_ini As String = Format(CDate(_periodo_ini), "MMMM") & " " & Format(CDate(_periodo_ini), "yyyy")
            'Dim periodo_fin As String = Format(CDate(_periodo_fin), "MMMM") & " " & Format(CDate(_periodo_fin), "yyyy")
            periodo = "" 'Strings.UCase(periodo_ini & "-" & periodo_fin)


            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = dgv_Lista_detalle.Rows.Count - 1

            For i As Integer = 0 To dgv_Lista_detalle.Rows.Count - 1
                ProgressBar1.Value = i
                If dgv_Lista_detalle.Rows(i).Cells("EMAIL").Value <> "" And dgv_Lista_detalle.Rows(i).Cells("STATUS_ENVIO_BOLETA").Value = "" Then
                    Envio_Mail_Cliente = dgv_Lista_detalle.Rows(i).Cells("EMAIL").Value
                    nombre_trabajador = dtpFecha_planilla.Value.Year & "_" & Format(dtpFecha_planilla.Value.Month, "00") & "_" & dgv_Lista_detalle.Rows(i).Cells("APELLIDO_PATERNO").Value & "_" & dgv_Lista_detalle.Rows(i).Cells("NOMBRE_COMPLETO").Value

                    StrNomArchivo_PDF = txtRuta.Text & "\" & Strings.RTrim(nombre_trabajador) & ".pdf"

                    If Modo_Edicion = True Then
                        id_cab = _codigo_planilla
                    Else
                        With cabeceraBE
                            id_cab = .NUMBER_DOCUMENT
                        End With
                    End If

                    If _TIPO = "PLA" Then
                        _TIPO_BOLETA = "Boleta de Pago"
                        ' _mensaje_tipo = "Te enviamos tu boleta de pago."
                    ElseIf _TIPO = "GRA" Then
                        _TIPO_BOLETA = "Boleta de Pago de Gratificación"
                        '_mensaje_tipo = "Te enviamos tu boleta de pago de gratificación."
                    ElseIf _TIPO = "CTS" Then
                        _TIPO_BOLETA = "HOJA DE LIQUIDACIÓN DE CTS"
                        '_mensaje_tipo = "Te enviamos tu boleta de pago de gratificación."
                    End If

                    If File.Exists(StrNomArchivo_PDF) = True Then
                        'Dim envio_mail As New frm_EnvioEmail
                        'envio_mail._archivo_pdf = StrNomArchivo_PDF
                        'envio_mail._codigo_datos_email = "99"
                        'envio_mail._nombre_documento = nombre_trabajador & ".pdf"
                        'envio_mail._nombre_personal = dgv_Lista_detalle.Rows(i).Cells("NOMBRE").Value
                        'envio_mail._USER_MAIL = LibComunVar.ClsVarComun.MAIL_USER
                        'envio_mail._EMAIL_RECEPCIONANTE = Envio_Mail_Cliente
                        'envio_mail._nombre_tipo_documento = "Boleta de Pago"
                        'envio_mail._serie_document = MonthName(dtpFecha_planilla.Value.Month)
                        'envio_mail._number_document = dtpFecha_planilla.Value.Year
                        'envio_mail._nombre_trabajador = nombre_trabajador
                        'envio_mail._asunto_correo = txt_titulo.Text
                        'envio_mail.ShowDialog()

                        If Enviar_Email(StrNomArchivo_PDF, "99", nombre_trabajador & ".pdf", dgv_Lista_detalle.Rows(i).Cells("NOMBRE").Value,
                                        LibComunVar.ClsVarComun.MAIL_USER, Envio_Mail_Cliente, _TIPO_BOLETA, MonthName(dtpFecha_planilla.Value.Month),
                                        dtpFecha_planilla.Value.Year, nombre_trabajador, txt_titulo.Text,
                                        dgv_Lista_detalle.Rows(i).Cells("txtFrom").Value,
                                        dgv_Lista_detalle.Rows(i).Cells("TXTSERVER").Value,
                                        dgv_Lista_detalle.Rows(i).Cells("TXTMSG").Value,
                                        dgv_Lista_detalle.Rows(i).Cells("TXTUSERNAME").Value,
                                        dgv_Lista_detalle.Rows(i).Cells("TXTPASSWORD").Value) Then

                            With personal_RR_HH
                                .EMPLOYEE_ID = dgv_Lista_detalle.Rows(i).Cells("CODIGO").Value
                                .PATERNAL_LAST_NAME = txt_titulo.Text & ", ENVIADO"
                            End With

                            If clienteBL.Envio_Boleta_RR_HH_II(personal_RR_HH, id_cab) = False Then
                                MsgBox("No se actualizo el envio de la Boleta de Pago", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    Else
                        MsgBox("ERROR:" & Chr(13) & "La boleta " & nombre_trabajador & ".PDF" & Chr(13) & _
                                            "no existe en la carpeta. Verifique!!!", MsgBoxStyle.Exclamation)
                    End If
                End If
                ProgressBar1.PerformStep()
            Next
            ProgressBar1.Value = dgv_Lista_detalle.Rows.Count - 1
            MsgBox("El proceso de envio de boletas termino correctamente.", MsgBoxStyle.Information)
            Call Cargar_Personal()
            ProgressBar1.Value = 0
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ProgressBar1.Value = 0
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Enviar_Email(ByVal _archivo_pdf As String, ByVal _codigo_datos_email As String, ByVal _nombre_documento As String,
                             ByVal _nombre_personal As String, ByVal _USER_MAIL As String, ByVal _EMAIL_RECEPCIONANTE As String, ByVal _nombre_tipo_documento As String,
                             ByVal _serie_document As String, ByVal _number_document As String, ByVal _nombre_trabajador As String, ByVal _asunto_correo As String,
                             ByVal _REMITENTE As String, ByVal _SERVER As String, ByVal _PUERTO As String, ByVal _USUARIO As String, ByVal _PASSWORD As String) As Boolean
        Try
            'Dim DT_DATOS_ENVIO_EMAIL As DataTable
            'DT_DATOS_ENVIO_EMAIL = New DataTable
            'clsBusquedaBl = New ClsBuscar
            'Dim DT_MENSAJE As DataTable
            'DT_MENSAJE = New DataTable
            'DT_DATOS_ENVIO_EMAIL = clsBusquedaBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL(_codigo_datos_email)
            'If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
            '_REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
            '_RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
            '_SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
            '_USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
            '_PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
            '_ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
            '_TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
            '_PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
            If _codigo_datos_email = "99" Then
                _mensaje = ""
                _mensaje = _mensaje & " <span style=""color:#0032a0;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: left;"">Hola, " & _nombre_personal & "<br></span> "
                If _TIPO = "PLA" Then
                    _mensaje = _mensaje & " <span style=""color:#04be50;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: center;""> Te enviamos tu boleta de pago.</span><br><br></span> "
                ElseIf _TIPO = "GRA" Then
                    _mensaje = _mensaje & " <span style=""color:#04be50;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: center;""> Te enviamos tu boleta de pago de gratificación.</span><br><br></span> "
                ElseIf _TIPO = "CTS" Then
                    _mensaje = _mensaje & " <span style=""color:#04be50;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: center;""> Te enviamos tu Hoja de Liquidación de CTS.</span><br><br></span> "
                End If
                '_mensaje = _mensaje & " <span style=""color:#04be50;font-family: verdana,geneva,sans-serif;font-size: 25px;line-height: 40px;text-align: center;""> Te enviamos tu boleta de pago.</span><br><br></span> "

                _mensaje = _mensaje & " <table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""border:1px solid #36c1dc;padding-left:15px;padding-right:15px;background-repeat:no-repeat;background-position:50% 50%"" data-image-whitelisted="" align=""center"">"
                _mensaje = _mensaje & " <tbody><tr><td width=""100%"" height=""250"" align=""center"" valign=""top"" style=""text-align:center"" rowspan=""1"" colspan=""1"">"
                _mensaje = _mensaje & " <table width=""100%"" cellspacing=""0"" cellpadding=""0"" style=""border-spacing:0;text-align:center""><tbody><tr><td colspan=""2"" style=""height:20px"" rowspan=""1"">&nbsp;</td></tr><tr style=""vertical-align:top""><td colspan=""2"" align=""center"" valign=""top"" style=""color:#00add0;font-size:18px;width:141px;word-wrap:break-word;overflow:auto"" rowspan=""1"">"
                _mensaje = _mensaje & " <span>Constancia de Envío</span> </td></tr><tr><td colspan=""2"" style=""height:20px"" rowspan=""1"">&nbsp;</td></tr> <tr style=""vertical-align:top"">"
                _mensaje = _mensaje & " <td colspan=""2"" align=""center"" valign=""top"" style=""text-align:center;font-size:13px"" rowspan=""1"">Fecha:&nbsp;<span>" & Date.Now.Day.ToString & " " & Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(DateTime.Now.ToString("MM") - 1) & " " & Date.Now.Year.ToString & "</span>&nbsp;&nbsp;Hora:&nbsp;<span>" & Date.Now.ToString("HH:mm:ss") & "</span></td>"
                _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr></tbody>"
                _mensaje = _mensaje & " </table><table width=""100%"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""color:#4e4f53;font-size:14px;text-align:center""><tbody>"
                _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Tipo :</span> </td>"
                _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _nombre_tipo_documento & "</span><br clear=""none""></span> </td>"
                _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"

                If _TIPO = "PLA" Then
                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Año y Mes:</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _serie_document & "/" & _number_document & " </span><br clear=""none""></span> </td>"
                ElseIf _TIPO = "GRA" Then
                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Año y Mes:</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & _serie_document & "/" & _number_document & " </span><br clear=""none""></span> </td>"
                ElseIf _TIPO = "CTS" Then
                    _mensaje = _mensaje & " <tr style=""vertical-align:top""><td style=""color:#0039a6;text-align:right;font-size:14px;width:126px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-etiqueta"">Periodo:</span> </td>"
                    _mensaje = _mensaje & " <td style=""text-align:left;padding-left:8px;width:134px"" rowspan=""1"" colspan=""1""><span id=""m_3405978872032249379font-parrafo-valor""><span>" & periodo & " </span><br clear=""none""></span> </td>"
                End If
                
                _mensaje = _mensaje & " </tr><tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr>"
                _mensaje = _mensaje & " <tr><td colspan=""2"" style=""height:10px"" rowspan=""1"">&nbsp;</td></tr></tbody></table></td></tr><tr><td style=""height:10px"" rowspan=""1"" colspan=""1"">&nbsp;</td></tr></tbody></table>"
                _mensaje = _mensaje & " </td></tr><tr><td style=""padding:30px;text-align:center;font-size:12px;color:#cccccc;""><p style=""margin:0 0 8px 0;""><a href=""#"" style=""text-decoration:none;"">"
                _mensaje = _mensaje & " <img src=""cid:imagen2"" width=""40"" height=""40"" alt=""f"" style=""display:inline-block;color:#cccccc;""></a><a href=""#"" style=""text-decoration:none;"">"
                _mensaje = _mensaje & " <img src=""cid:imagen3"" width=""40"" height=""40"" alt=""t"" style=""display:inline-block;color:#cccccc;""></a></p><p style=""margin:0;font-size:14px;line-height:20px;"">&reg; " & LibComunVar.ClsVarComun.NomEmpresa_completo & Date.Now.Year & "<br>"
                _mensaje = _mensaje & " </p></td></tr></table></td></tr></table></div></body></html>"

                Dim _texto_email As String = Cabecera_correo() & _mensaje

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(_texto_email, Encoding.UTF8, MediaTypeNames.Text.Html)

                Dim img2 As LinkedResource = New LinkedResource("facebook_1.png", MediaTypeNames.Image.Jpeg)
                img2.ContentId = "imagen2"
                htmlView.LinkedResources.Add(img2)

                Dim img3 As LinkedResource = New LinkedResource("instagram.png", MediaTypeNames.Image.Jpeg)
                img3.ContentId = "imagen3"
                htmlView.LinkedResources.Add(img3)

                Dim att_pdf As New Net.Mail.Attachment(_archivo_pdf)
                'Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, _EMAIL_RECEPCIONANTE, _asunto_correo, _texto_email)
                Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, _EMAIL_RECEPCIONANTE, _asunto_correo, _texto_email)
                mensajes.Attachments.Add(att_pdf)
                mensajes.AlternateViews.Add(htmlView)
                Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
                Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
                smpt.EnableSsl = True
                smpt.Credentials = acceso
                smpt.Port = _PUERTO
                smpt.Host = _SERVER

                smpt.Send(mensajes)
                smpt.Dispose()
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Cabecera_correo() As String
        Dim mensaje_cabecera As String
        mensaje_cabecera = "<!DOCTYPE html><html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office""><head>  <meta charset=""utf-8"">  <meta name=""viewport"" content=""width=device-width,initial-scale=1"">  <meta name=""x-apple-disable-message-reformatting"">  <title></title>"
        mensaje_cabecera = mensaje_cabecera & " <style>    table, td, div, h1, p {      font-family: Arial, sans-serif;    }    @media screen and (max-width: 530px) {      .unsub {        display: block;        padding: 8px;        margin-top: 14px;        border-radius: 6px;        background-color: #555555;        text-decoration: none !important;        "
        mensaje_cabecera = mensaje_cabecera & " font-weight: bold;      }      .col-lge {        max-width: 100% !important;      }    }    @media screen and (min-width: 531px) {.col-sml {        max-width: 27% !important;      }      .col-lge {        max-width: 73% !important;      }    }  </style> "
        mensaje_cabecera = mensaje_cabecera & " <body style=""margin:0;padding:0;word-spacing:normal;""> <div role=""article"" aria-roledescription=""email"" lang=""en"" style=""text-size-adjust:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;"">     <table role=""presentation"" style=""width:100%;border:none;border-spacing:0;""> "
        mensaje_cabecera = mensaje_cabecera & "       <tr>         <td align=""center"" style=""padding:0;"">           <table role=""presentation"" style=""width:94%;max-width:600px;border:none;border-spacing:0;text-align:left;font-family:Arial,sans-serif;font-size:16px;line-height:22px;color:#363636;"" > "
        mensaje_cabecera = mensaje_cabecera & "       <tr>              <td style=""padding:40px 30px 30px 30px;text-align:center;font-size:24px;font-weight:bold;"">"
        mensaje_cabecera = mensaje_cabecera & " 	  </td>            </tr>            <tr>"
        mensaje_cabecera = mensaje_cabecera & " <td style=""padding:30px;background-color:#ffffff;"" >"

        Return mensaje_cabecera
    End Function

    Private Function Cabecera_correo_2() As String
        Dim mensaje_cabecera As String
        mensaje_cabecera = "<!DOCTYPE html><html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office""><head>  <meta charset=""utf-8"">  <meta name=""viewport"" content=""width=device-width,initial-scale=1"">  <meta name=""x-apple-disable-message-reformatting"">  <title></title>"
        mensaje_cabecera = mensaje_cabecera & " <style>    table, td, div, h1, p {      font-family: Arial, sans-serif;    }    @media screen and (max-width: 530px) {      .unsub {        display: block;        padding: 8px;        margin-top: 14px;        border-radius: 6px;        background-color: #555555;        text-decoration: none !important;        "
        mensaje_cabecera = mensaje_cabecera & " font-weight: bold;      }      .col-lge {        max-width: 100% !important;      }    }    @media screen and (min-width: 531px) {.col-sml {        max-width: 27% !important;      }      .col-lge {        max-width: 73% !important;      }    }  </style> "
        mensaje_cabecera = mensaje_cabecera & " <body style=""margin:0;padding:0;word-spacing:normal;""> <div role=""article"" aria-roledescription=""email"" lang=""en"" style=""text-size-adjust:100%;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;"">     <table role=""presentation"" style=""width:100%;border:none;border-spacing:0;""> "
        mensaje_cabecera = mensaje_cabecera & "       <tr>         <td align=""center"" style=""padding:0;"">           <table role=""presentation"" style=""width:94%;max-width:600px;border:none;border-spacing:0;text-align:left;font-family:Arial,sans-serif;font-size:16px;line-height:22px;color:#363636;"" > "
        mensaje_cabecera = mensaje_cabecera & "       <tr>              <td style=""padding:40px 30px 30px 30px;text-align:center;font-size:24px;font-weight:bold;"">"
        mensaje_cabecera = mensaje_cabecera & " 	  </td>            </tr>            <tr>"
        mensaje_cabecera = mensaje_cabecera & " <td style=""padding:30px;background-color:#ffffff;"" >"

        Return mensaje_cabecera
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dgvCabecera.RowCount() = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Botonera_Estado_Cambiar(True)
            Modo_Edicion = True
            limpiar()
            _inicio = True
            pnlCabecera.Visible = False
            GbCabecera.Enabled = True
            dtpfechaInicial.Enabled = False
            dtpfechafinal.Enabled = False
            'btn_anexar.Enabled = False
            _codigo_planilla = dgvCabecera.CurrentRow.Cells("ID").Value
            txtcodigo.Text = dgvCabecera.CurrentRow.Cells("ID").Value
            txt_titulo.Text = dgvCabecera.CurrentRow.Cells("TITULO").Value
            _TIPO = dgvCabecera.CurrentRow.Cells("TIPO").Value

            dtpFecha_planilla.Value = dgvCabecera.CurrentRow.Cells("FECHA").Value

            MostrarModoConsultar(_codigo_planilla)
            tc_tipos.SelectedIndex = 0
            'CONTROLES(TabPage1, True)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarModoConsultar(ByVal _codigo As Integer)
        Try
            Dim dtPeriodo As New DataTable
            clsPedidoBl = New ClsOperaciones.ORDERS
            'Mostrando datos del detalle
            dtDocumentos = New DataTable
            dtDocumentos = clsPedidoBl.Get_Datos_Detalle_Boletas_Pago(_codigo)
            dtPeriodo = clsPedidoBl.Get_Datos_Detalle_Boletas_Periodo(_codigo, _TIPO)
            For Each row As DataRow In dtPeriodo.Rows
                _periodo_ini = row("PERIODO_INICIAL").ToString
                _periodo_fin = row("PERIODO_FINAL").ToString

            Next
            btnGrabar.Enabled = False
            mostrarElementos()

            If dtDocumentos.Rows.Count > 0 Then
                dgv_Lista_detalle.DataSource = dtDocumentos
                Formato_Grilla()
                dgv_Lista_detalle.Columns("STATUS_ENVIO_BOLETA").Visible = True
                dgv_Lista_detalle.Update()
                lblCantidad_detalle.Text = "Se encontraron " & dtDocumentos.Rows.Count() & " registros"
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_planilla_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_planilla.ValueChanged
        'If _TIPO = "PLA" Then
        '    txt_titulo.Text = "BOLETA DE PAGO " & MonthName(dtpFecha_planilla.Value.Month) & " - " & dtpFecha_planilla.Value.Year
        'ElseIf _TIPO = "GRA" Then
        '    txt_titulo.Text = "BOLETA DE PAGO GRATIFICACION " & MonthName(dtpFecha_planilla.Value.Month) & " - " & dtpFecha_planilla.Value.Year
        'ElseIf _TIPO = "CTS" Then
        '    txt_titulo.Text = "BOLETA DE PAGO CTS " & MonthName(dtpFecha_planilla.Value.Month) & " - " & dtpFecha_planilla.Value.Year
        'End If
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentosRequisiones()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub


End Class