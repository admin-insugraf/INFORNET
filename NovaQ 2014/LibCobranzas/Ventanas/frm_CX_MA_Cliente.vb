Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frm_CX_MA_Cliente
    Dim dv_lista As New DataView
    Dim bol_nuevo As Boolean = False
    Dim bol_cargar As Boolean = False
    Dim clsLetrasBl As ClsNegocio.PART
    Dim clsBuscarBl As ClsBuscar
    Dim clienteBL As ClsNegocio.CUSTOMER
    Dim dtdetalles As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim dtdetalleArticuloPrincipal As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_tipos.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        Select Case tc_tipos.SelectedIndex
            Case 0
                tc_tipos.SelectedIndex = indice + 1
            Case 1
                tc_tipos.SelectedIndex = indice - 1
        End Select
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
            btn_reporte.Enabled = False
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
            btn_reporte.Enabled = True
        End If
    End Sub

    Private Sub frm_CX_MA_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Clientes()
        Call Cargar_Documentos_Persona()
        Call Cargar_Bancos()
        Botonera_Estado_Cambiar(False)
        bol_cargar = True
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
    End Sub

    Private Sub blank()

        txtTipoCliente.Text = String.Empty
        txtdescripcionTipocliente.Text = String.Empty
        txtDepartamento.Text = String.Empty
        txtdescripciondepartamento.Text = String.Empty
        txt_des_depart.Text = String.Empty
        txt_desc_prov.Text = String.Empty
        txt_desc_dist.Text = String.Empty
        txt_desc_vende.Text = String.Empty
        txt_desc_pago.Text = String.Empty
        txt_cod_cli.Text = String.Empty
        txt_des_cli.Text = String.Empty
        txt_dir_cli.Text = String.Empty
        txt_telf_cli.Text = String.Empty
        txt_ruc_cli.Text = String.Empty
        txt_num_doc.Text = String.Empty
        txt_porc_descto.Text = String.Empty
        txt_cond_pago.Text = String.Empty
        txt_contacto.Text = String.Empty
        txt_cod_dist.Text = String.Empty
        txt_fax.Text = String.Empty
        txt_tip_precio.Text = String.Empty
        txt_des_tip_precio.Text = String.Empty
        txt_cod_vende.Text = String.Empty
        txt_pais.Text = String.Empty
        txt_cod_dep.Text = String.Empty
        txt_cod_prov.Text = String.Empty
        txt_cod_pross.Text = String.Empty
        txt_lim_sol.Text = String.Empty
        txt_lim_dol.Text = String.Empty
        txt_saldo_sol.Text = String.Empty
        txt_saldo_dol.Text = String.Empty
        txt_obs.Text = String.Empty
        txt_mail.Text = String.Empty
        txt_web.Text = String.Empty
        txt_cod_zon_ven.Text = String.Empty
        txt_tot_letra.Text = String.Empty
        txt_tot_factura.Text = String.Empty
        txt_tot_let_protes.Text = String.Empty
        txt_tot_cheque.Text = String.Empty
        txt_tip_cli.Text = String.Empty
        txt_tip_neg.Text = String.Empty
        txt_territorio.Text = String.Empty
        txt_ruta.Text = String.Empty
        txt_segmento.Text = String.Empty
        txt_ubi_seg.Text = String.Empty
        txt_hor_vis.Text = String.Empty
        txt_tip_ate.Text = String.Empty
        txt_comentario.Text = String.Empty
        rb_activo.Checked = True
        rbdistribuidor.Checked = True
        txtcodigoTipoEmp.Text = String.Empty
        txtdescripcionTipoEmp.Text = String.Empty

        txt_ap_paterno.Text = String.Empty
        txt_ap_materno.Text = String.Empty
        txt_primer_nombre.Text = String.Empty
        txt_segundo_nombre.Text = String.Empty

        rb_principal.Checked = False
        rb_sede.Checked = False
        gb_tipo_cliente.Enabled = True
        txt_cod_cli.Enabled = True
        txt_ruc_cli.ReadOnly = False

        ' txt_des_cli.Enabled = True
        gb_estado.Enabled = True
        chk_validacion_fe.Checked = False
    End Sub


    Private Sub Cargar_TipoCliente()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_MASTER_HELP"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipo de Cliente"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtTipoCliente.Text = String.Empty
                txtdescripcionTipocliente.Text = String.Empty
                txtDepartamento.Text = String.Empty
                txtdescripciondepartamento.Text = String.Empty
                'txt_cod_cli.Text = String.Empty
                txtTipoCliente.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripcionTipocliente.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
                txtDepartamento.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Departamento()
        Try
            If String.IsNullOrEmpty(txtTipoCliente.Text) Then
                MsgBox("Es necesario elegir un Tipo.", MsgBoxStyle.Information)
                txtTipoCliente.Focus()
                Exit Sub
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtDepartamento.Text = String.Empty
                txtdescripciondepartamento.Text = String.Empty
                'departamento
                txt_cod_dep.Text = String.Empty
                txt_des_depart.Text = String.Empty
                'provincia
                txt_cod_prov.Text = String.Empty
                txt_desc_prov.Text = String.Empty
                'distrito
                txt_cod_dist.Text = String.Empty
                txt_desc_dist.Text = String.Empty


                txtDepartamento.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txtdescripciondepartamento.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                ''datos del departamento
                txt_cod_dep.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_depart.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                'GenerarCodigoCliente(txtTipoCliente.Text, frm.Data_Matriz.Rows(0).Item("COD_DEPT").ToString)
                'If txtDepartamento.Text = "15" Then
                '    txtcuentaContableSol.Text = "121201"
                '    txtcuentaContableDol.Text = "121201"
                'ElseIf txtDepartamento.Text <> "15" Then
                '    txtcuentaContableSol.Text = "121202"
                '    txtcuentaContableDol.Text = "121202"
                'End If
                gb_data.Enabled = True
                txt_des_cli.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Departamento_modif()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'departamento
                txt_cod_dep.Text = String.Empty
                txt_des_depart.Text = String.Empty
                'provincia
                txt_cod_prov.Text = String.Empty
                txt_desc_prov.Text = String.Empty
                'distrito
                txt_cod_dist.Text = String.Empty
                txt_desc_dist.Text = String.Empty

                ''datos del departamento
                txt_cod_dep.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_depart.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                If txt_cod_dep.Text = "15" Then
                    txtcuentaContableSol.Text = "121201"
                    txtcuentaContableDol.Text = "121201"
                ElseIf txt_cod_dep.Text <> "15" Then
                    txtcuentaContableSol.Text = "121202"
                    txtcuentaContableDol.Text = "121202"
                End If
                gb_data.Enabled = True
                txt_cod_prov.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Departamento_direc_entrega()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'departamento
                TextBox1.Text = String.Empty
                TextBox2.Text = String.Empty
                'provincia
                TextBox3.Text = String.Empty
                TextBox4.Text = String.Empty
                'distrito
                TextBox5.Text = String.Empty
                TextBox6.Text = String.Empty

                ''datos del departamento
                TextBox6.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox3.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                gb_data.Enabled = True
                TextBox2.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Provincia()
        Try
            If bol_nuevo = True Then
                If String.IsNullOrEmpty(txtDepartamento.Text) Then
                    MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                    txtDepartamento.Focus()
                    Exit Sub
                End If
            Else
                If String.IsNullOrEmpty(txt_cod_dep.Text) Then
                    MsgBox("No hay codigo de departamento", MsgBoxStyle.Information)
                    txt_cod_dep.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            If bol_nuevo = True Then
                frm.Filtros1 = txtDepartamento.Text
            Else
                frm.Filtros1 = txt_cod_dep.Text
            End If
            frm.Titulo = "Provincias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'provincia
                txt_cod_prov.Text = String.Empty
                txt_desc_prov.Text = String.Empty
                'distrito
                txt_cod_dist.Text = String.Empty
                txt_desc_dist.Text = String.Empty
                txt_cod_prov.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_desc_prov.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_cod_dist.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Provincia_direcc_entrega()
        Try
            If bol_nuevo = True Then
                If String.IsNullOrEmpty(TextBox6.Text) Then
                    MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                    TextBox6.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TextBox6.Text
            frm.Titulo = "Provincias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'provincia
                TextBox5.Text = String.Empty
                TextBox2.Text = String.Empty
                'distrito
                TextBox4.Text = String.Empty
                TextBox1.Text = String.Empty
                TextBox5.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TextBox2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                TextBox4.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Distrito()
        Try
            If bol_nuevo = True Then
                If String.IsNullOrEmpty(txtDepartamento.Text) Then
                    MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                    txtDepartamento.Focus()
                    Exit Sub
                ElseIf String.IsNullOrEmpty(txt_cod_prov.Text) Then
                    MsgBox("Es necesario elegir una Provincia", MsgBoxStyle.Information)
                    txt_cod_prov.Focus()
                    Exit Sub
                End If
            Else
                If String.IsNullOrEmpty(txt_cod_dep.Text) Then
                    MsgBox("No hay codigo de departamento", MsgBoxStyle.Information)
                    txt_cod_dep.Focus()
                    Exit Sub
                ElseIf String.IsNullOrEmpty(txt_cod_prov.Text) Then
                    MsgBox("Es necesario elegir una Provincia", MsgBoxStyle.Information)
                    txt_cod_prov.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            If bol_nuevo = True Then
                frm.Filtros1 = txtDepartamento.Text
            Else
                frm.Filtros1 = txt_cod_dep.Text
            End If
            frm.Filtros2 = txt_cod_prov.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_dist.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_desc_dist.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
            Else
                txt_cod_dist.Text = String.Empty
                txt_desc_dist.Text = String.Empty
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Distrito_direc_entrega()
        Try
            If String.IsNullOrEmpty(TextBox6.Text) Then
                MsgBox("No hay codigo de departamento", MsgBoxStyle.Information)
                TextBox6.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TextBox5.Text) Then
                MsgBox("Es necesario elegir una Provincia", MsgBoxStyle.Information)
                TextBox5.Focus()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TextBox6.Text
            frm.Filtros2 = TextBox5.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox4.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox1.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
            Else
                TextBox4.Text = String.Empty
                TextBox1.Text = String.Empty
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarCodigoCliente(ByVal _TipoCliente As String, ByVal _Departamento As String)
        Try
            clienteBL = New ClsNegocio.CUSTOMER
            dtdetalles = New DataTable("CodigoCliente")
            dtdetalles = clienteBL.GeneracionCodigoCliente(_TipoCliente, _Departamento)
            If dtdetalles.Rows.Count() <> 0 Then
                txt_cod_cli.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Cargar_Clientes()
        Try
            clienteBL = New ClsNegocio.CUSTOMER
            dtv = New DataView
            dtdetalles = New DataTable("Datos")
            dtdetalles = clienteBL.get_Clientes_mt()
            dtv = dtdetalles.DefaultView
            If dtdetalles.Rows.Count() <> 0 Then
                dgv_Lista.DataSource = dtv
                clienteBL = Nothing
                dgv_Lista.Columns(0).Width = 90
                dgv_Lista.Columns(1).Width = 400
                dgv_Lista.Columns(2).Width = 100
                dgv_Lista.Columns(3).Width = 250
                dgv_Lista.Columns(4).Width = 100
                dgv_Lista.Columns(5).Width = 100
                dgv_Lista.Columns(6).Width = 100
                dgv_Lista.Columns(7).Width = 250
                dgv_Lista.Columns(8).Width = 250

                dgv_Lista.Columns(9).Width = 150
                dgv_Lista.Columns(10).Width = 150
                dgv_Lista.Columns(11).Width = 150
                dgv_Lista.Columns(12).Width = 150
                'dgv_Lista.AutoResizeColumns()
                'dgv_Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name & "+" & dgv_Lista.Columns(2).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            'If dgv_Lista.RowCount > 0 Then
            '    dgv_Lista.ContextMenuStrip = cmsOpciones
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Cargar_Clientes()
    '    Dim clienteBL As New ClsOperaciones.CUSTOMER
    '    dv_lista = clienteBL.get_Clientes_mt().DefaultView
    '    dgv_Lista.DataSource = dv_lista
    '    clienteBL = Nothing
    '    If dgv_Lista.RowCount > 0 Then
    '        dgv_Lista.ContextMenuStrip = cmsOpciones
    '    End If
    'End Sub

    Private Sub Ayuda_Vendedor()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CLI_SP_S_SALES_REP"
        frm.CadenaConsulta = sql
        frm._Flag_Filtro = False
        frm.Titulo = "Vendedores"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_vende.Text = String.Empty
            txt_desc_vende.Text = String.Empty
            txt_cod_vende.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_desc_vende.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_cod_vende.Focus()
            'Me.Cursor = Cursors.Default
        End If
        frm.Close()
    End Sub

    Private Sub Cargar_Bancos()
        Dim bancoBL As New ClsOperaciones.BANK
        cmb_banco.DataSource = bancoBL.get_Bancos()
        cmb_banco.DisplayMember = "NAME"
        cmb_banco.ValueMember = "ID"
        bancoBL = Nothing
    End Sub

    Private Sub Cargar_Cuentas_Corrientes()

        If cmb_banco.SelectedIndex = -1 Then Exit Sub

        Dim cuentasBL As New ClsOperaciones.ACCOUNT_BANK
        cmb_cta_cte.DataSource = cuentasBL.get_Cuentas_Corrientes(cmb_banco.SelectedValue)
        cmb_cta_cte.DisplayMember = "DES"
        cmb_cta_cte.ValueMember = "COD"
        cuentasBL = Nothing
    End Sub

    Private Sub Cargar_Documentos_Persona()
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        cmb_tip_doc_per.DataSource = tipoDocBL.get_Tipos
        cmb_tip_doc_per.DisplayMember = "TD_DESCRIPCION"
        cmb_tip_doc_per.ValueMember = "TD_ID"
        tipoDocBL = Nothing
    End Sub
    Private Sub Cargar_Direccion_Entrega(ByVal _codigo_cli As String)
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        Dim CADENA As String
        CADENA = "SELECT A.ITEM,A.CUSTOMER_ID,A.ADDR,ISNULL(UB.CODDIS,'') [DISTRITO_ID],ISNULL(UB.NOMBRE,'') [DISTRITO],ISNULL(UBB.CODPROV,'') [PROVINCIA_ID],ISNULL(UBB.NOMBRE,'') [PROVINCIA],ISNULL(UBBB.CODDPTO,'') [DEPARTAMENTO_ID],ISNULL(UBBB.NOMBRE,'') [DEPARTAMENTO]  "
        CADENA = CADENA & " FROM dbo.ADDR_CUSTOMER A LEFT join dbo.ubigeo ub on ub.CODDPTO=A.DEPARTAMENTO_ID AND ub.CODPROV=A.PROVINCIA_ID AND ub.CODDIS=A.DISTRITO_ID LEFT join dbo.ubigeo UBB on UBB.CODDPTO=A.DEPARTAMENTO_ID AND UBB.CODPROV=A.PROVINCIA_ID AND UBB.CODDIS='00' LEFT join dbo.ubigeo UBBB on UBBB.CODDPTO=A.DEPARTAMENTO_ID  "
        CADENA = CADENA & " AND UBBB.CODPROV='00' AND UBBB.CODDIS='00' WHERE A.CUSTOMER_ID='" & _codigo_cli & "' "

        'cbo_direc_entrega.DataSource = Nothing
        'cbo_direc_entrega.DataSource = tipoDocBL.get_Direc_entrega(CADENA)
        'cbo_direc_entrega.DisplayMember = "DIRECCION_ENTREGA"
        'cbo_direc_entrega.ValueMember = "CUSTOMER_ID"
        dtdetalleArticuloPrincipal = tipoDocBL.get_Direc_entrega(CADENA)
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
        tipoDocBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        gbGenerarCodigo.Visible = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        CONTROLES(TabPage3, True)
        gb_data.Enabled = True
        gb_mas_datos.Enabled = True
        bol_nuevo = True
        blank()
        GenerarColummnaDataTable()
        txt_ruc_cli.Focus()
        gb_tipo_cliente.Enabled = False
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        'If rb_principal.Checked = False And rb_sede.Checked = False Then
        '    MsgBox("Debe especificar un Tipo de Cliente.", MsgBoxStyle.Critical, "Sistemas")
        '    gb_tipo_cliente.Select()
        '    Exit Sub
        'End If

        If txt_cod_cli.Text = "" Then
            Call Avisar("Ingrese el codigo de cliente")
            txt_cod_cli.Focus()
            Exit Sub
        ElseIf txt_des_cli.Text.Trim = "" Then
            Call Avisar("Ingrese la descripcion")
            txt_des_cli.Focus()
            Exit Sub
            'ElseIf txt_ruc_cli.Text.Trim = "" Then
            '    Call Avisar("Ingrese el ruc.")
            '    txt_des_cli.Focus()
            '    Exit Sub
        ElseIf txt_cod_prov.Text.Trim = "" Then
            If cmb_tip_doc_per.SelectedValue <> "0" And cmb_tip_doc_per.SelectedValue <> "9" Then
                Call Avisar("Seleccione el codigo de una provincia.")
                txt_cod_prov.Focus()
                Exit Sub
            End If

        ElseIf txt_cod_dist.Text.Trim = "" Then
            If cmb_tip_doc_per.SelectedValue <> "0" And cmb_tip_doc_per.SelectedValue <> "9" Then
                Call Avisar("Seleccione el codigo de un distrito.")
                txt_cod_dist.Focus()
                Exit Sub
            End If
        ElseIf txt_cod_vende.Text.Trim = "" Then
            Call Avisar("Seleccione el codigo de un vendedor.")
            txt_cod_vende.Focus()
            Exit Sub
        End If

        If cmb_tip_doc_per.SelectedValue <> "0" Then
            If txt_ruc_cli.Text.Trim = "" Then
                Call Avisar("Ingrese el ruc.")
                txt_des_cli.Focus()
                Exit Sub
            End If
        End If

        If cmb_tip_doc_per.SelectedValue = "1" Then
            If txt_ruc_cli.Text.Length <> 8 Then
                MsgBox("El DNI ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                txt_ruc_cli.Focus()
                Exit Sub
            End If
        ElseIf cmb_tip_doc_per.SelectedValue = "6" Then
            If txt_ruc_cli.Text.Length <> 11 Then
                MsgBox("El RUC ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                txt_ruc_cli.Focus()
                Exit Sub
            End If
        End If


        Dim clienteBL As ClsOperaciones.CUSTOMER
        Dim clienteBE As New ClsEntidades.CUSTOMER
        If bol_nuevo Then
            clienteBL = New ClsOperaciones.CUSTOMER
            Dim dtvalidacion As New DataTable
            dtvalidacion = clienteBL.ValidacionCliente(txt_cod_cli.Text.Trim, txt_ruc_cli.Text.Trim)
            If dtvalidacion.Rows.Count() <> 0 Then
                MsgBox("Ya existe creado un cliente con el mismo Codigo y Ruc, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        clienteBL = New ClsOperaciones.CUSTOMER
        With clienteBE
            .ID = txt_cod_cli.Text.Trim
            If bol_nuevo Then
                If rb_principal.Checked = True Then
                    .NAME = txt_des_cli.Text.Trim
                Else
                    .NAME = txt_des_cli.Text.Trim & "  " & txt_desc_prov.Text & "  " & txt_desc_dist.Text
                End If
            Else
                .NAME = txt_des_cli.Text.Trim
            End If
            .ADDR = txt_dir_cli.Text.Trim
            .PHONE = txt_telf_cli.Text.Trim
            .VAT_REGISTRATION = txt_ruc_cli.Text.Trim
            .NUMBER_DOC = txt_num_doc.Text.Trim
            .DISCOUNT_PERCENT = IIf(txt_porc_descto.Text.Trim = "", 0, txt_porc_descto.Text.Trim)
            .TERMS_TYPE = txt_cond_pago.Text.Trim
            If rb_inactivo.Checked = True Then
                .STATUS = "A"
            ElseIf rb_activo.Checked = True Then
                .STATUS = "V"
            End If

            If chk_validacion_fe.Checked = True Then
                .ESTADO_VALIDACION_FE = "SI"
            Else
                .ESTADO_VALIDACION_FE = "NO"
            End If

            .OPEN_DATE = gFechaSis.ToShortDateString
            .CONTACT = txt_contacto.Text.Trim
            .STATE_ID = txt_cod_dist.Text.Trim
            .CREATE_USER = LibComunVar.ClsVarComun.USUARIO
            .CREATE_DATE = Date.Now.ToShortDateString
            .MODIFY_DATE = Date.Now.ToShortDateString
            .TYPE_PRICE = txt_tip_precio.Text.Trim
            .SALES_ID = txt_cod_vende.Text
            .SELL_ZONE = txt_cod_zon_ven.Text.Trim
            .COUNTRY = txt_pais.Text.Trim
            .DEPARTMENT = txt_cod_dep.Text.Trim
            .PROVINCE = txt_cod_prov.Text
            .ADDR_DLV = txt_dir_cli.Text.Trim
            .CURRENCY_CREDIT_LIMIT = txt_cod_mon_cre.Text
            .CREDIT_LIMIT_US = IIf(String.IsNullOrEmpty(txt_lim_dol.Text.ToString), 0, txt_lim_dol.Text)
            .CREDIT_LIMIT = IIf(String.IsNullOrEmpty(txt_lim_sol.Text.ToString), 0, txt_lim_sol.Text)
            .BALANCE = IIf(String.IsNullOrEmpty(txt_saldo_sol.Text.ToString), 0, txt_saldo_sol.Text)
            .BALANCE_US = IIf(String.IsNullOrEmpty(txt_saldo_dol.Text.ToString), 0, txt_saldo_dol.Text)
            .OBSERV = txt_obs.Text.Trim
            .TOTAL_LETTER = IIf(txt_tot_letra.Text = "", 0, txt_tot_letra.Text)
            .TOTAL_RECEIVABLE = IIf(txt_tot_factura.Text = "", 0, txt_tot_factura.Text)
            .TOTAL_CHECK = IIf(txt_tot_cheque.Text = "", 0, txt_tot_cheque.Text)
            .TOTAL_LETTER_PROTESTED = IIf(txt_tot_let_protes.Text = "", 0, txt_tot_let_protes.Text)
            .CUSTOMER_TYPE = txt_tip_cli.Text.Trim
            .BUSINESS_TYPE = txt_tip_neg.Text.Trim
            .TERRITORY = txt_territorio.Text.Trim
            .ROUTE = txt_ruta.Text.Trim
            .SEGMENT = txt_segmento.Text.Trim
            .SEGMENT_LOCATION = txt_ubi_seg.Text.Trim

            If cmb_banco.SelectedIndex = -1 Then
                .BANK_ID = ""
            Else
                .BANK_ID = cmb_banco.SelectedValue.ToString
            End If

            If cmb_cta_cte.SelectedIndex = -1 Then
                .ACCOUNT_NO = ""
            Else
                .ACCOUNT_NO = cmb_cta_cte.SelectedValue.ToString()
            End If
            .DATE_REVIEW = Date.Now.ToShortDateString
            .HOUR_VISIT = txt_hor_vis.Text.Trim
            .ATTENTION_TYPE = txt_tip_ate.Text.Trim
            .FAX_NUMBER = txt_fax.Text.Trim
            .EMAIL = txt_mail.Text.Trim
            .WEBSITE = txt_web.Text.Trim
            .COMMENT = txt_comentario.Text.Trim
            .IS_PRIMARY = 0
            .RETENTION = IIf(checkRetencion.Checked = True, "1", "0")
            .DOCUMENT_TYPE_PERSON_ID = cmb_tip_doc_per.SelectedValue
            .TYPE_COMPANY = txtcodigoTipoEmp.Text
            .ACCOUNT_LOCAL = txtcuentaContableSol.Text
            .ACCOUNT_EXTERNAL = txtcuentaContableDol.Text

            .AP_PATERNO = txt_ap_paterno.Text.Trim
            .AP_MATERNO = txt_ap_materno.Text.Trim
            .PRIMER_NOMBRE = txt_primer_nombre.Text.Trim
            .SEGUNDO_NOMBRE = txt_segundo_nombre.Text.Trim

            If rbFarmacia.Checked = True Then
                .TYPE_DISCOUNT = "0"
            ElseIf rbdistribuidor.Checked = True Then
                .TYPE_DISCOUNT = "1"
            End If
            .NAME_COMERTIAL = txtnombreComercial.Text
            If rb_principal.Checked = True Then
                .FLAG_PRINCIPAL = "1"
            ElseIf rb_sede.Checked = True Then
                .FLAG_PRINCIPAL = "0"
            Else
                .FLAG_PRINCIPAL = ""
            End If

            '.FLAG_PRINCIPAL = IIf(rb_principal.Checked = True, "1", "0")
        End With
        If bol_nuevo Then
            If clienteBL.Insert(clienteBE) Then
                MessageBox.Show("Cliente generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_cancelar_Click(sender, e)
                dgv_Lista.Focus()
            End If
        Else
            If clienteBL.Update(clienteBE) Then
                MessageBox.Show("Cliente actualizado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_cancelar_Click(sender, e)
                dgv_Lista.Focus()
            End If
        End If

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Try
            Botonera_Estado_Cambiar(True)
            If dgv_Lista.Rows.Count = 0 Then Exit Sub
            If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
            bol_nuevo = False
            blank()
            Dim clienteBE As New ClsEntidades.CUSTOMER
            Dim clienteBL As New ClsOperaciones.CUSTOMER
            clienteBE.ID = dgv_Lista.CurrentRow.Cells("CODIGO").Value.ToString
            clienteBL.get_Clientes_x_DocPer(clienteBE)
            With clienteBE
                txt_cod_cli.Text = .ID
                GenerarColummnaDataTable()
                Call Cargar_Direccion_Entrega(txt_cod_cli.Text.Trim)
                txt_des_cli.Text = .NAME
                txt_dir_cli.Text = .ADDR
                txt_telf_cli.Text = .PHONE
                txt_ruc_cli.Text = .VAT_REGISTRATION
                txt_num_doc.Text = .NUMBER_DOC
                txt_cond_pago.Text = .TERMS_TYPE
                If .STATUS = "A" Then
                    rb_inactivo.Checked = True
                ElseIf .STATUS = "V" Then
                    rb_activo.Checked = True
                Else
                    rb_activo.Checked = True
                End If

                If .ESTADO_VALIDACION_FE = "SI" Then
                    chk_validacion_fe.Checked = True
                    chk_validacion_fe_CheckedChanged(sender, e)
                ElseIf .ESTADO_VALIDACION_FE = "NO" Then
                    chk_validacion_fe.Checked = False
                    chk_validacion_fe_CheckedChanged(sender, e)
                Else
                    chk_validacion_fe.Checked = False
                    chk_validacion_fe_CheckedChanged(sender, e)
                End If

                txt_contacto.Text = .CONTACT
                txt_cod_dist.Text = .STATE_ID
                txt_tip_precio.Text = .TYPE_PRICE
                txt_cod_vende.Text = .SALES_ID
                txt_cod_zon_ven.Text = .SELL_ZONE
                txt_pais.Text = .COUNTRY
                txt_cod_dep.Text = .DEPARTMENT
                txt_cod_prov.Text = .PROVINCE
                txt_cod_mon_cre.Text = .CURRENCY_CREDIT_LIMIT
                txt_lim_dol.Text = .CREDIT_LIMIT_US
                txt_lim_sol.Text = .CREDIT_LIMIT
                txt_saldo_sol.Text = .BALANCE
                txt_saldo_dol.Text = .BALANCE_US
                txt_obs.Text = .OBSERV
                txt_tot_letra.Text = .TOTAL_LETTER
                txt_tot_factura.Text = .TOTAL_RECEIVABLE
                txt_tot_cheque.Text = .TOTAL_CHECK
                txt_tot_let_protes.Text = .TOTAL_LETTER_PROTESTED
                txt_tip_cli.Text = .CUSTOMER_TYPE
                txt_tip_neg.Text = .BUSINESS_TYPE
                txt_territorio.Text = .TERRITORY
                txt_ruta.Text = .ROUTE
                txt_segmento.Text = .SEGMENT
                txt_ubi_seg.Text = .SEGMENT_LOCATION
                cmb_banco.SelectedValue = .BANK_ID
                cmb_cta_cte.SelectedValue = .ACCOUNT_NO
                .DATE_REVIEW = Date.Now.ToShortDateString
                txt_hor_vis.Text = .HOUR_VISIT
                txt_tip_ate.Text = .ATTENTION_TYPE
                txt_fax.Text = .FAX_NUMBER
                txt_mail.Text = .EMAIL
                txt_web.Text = .WEBSITE
                txt_comentario.Text = .COMMENT
                '.IS_PRIMARY = 0
                If .RETENTION = "1" Then
                    checkRetencion.Checked = True
                Else
                    checkRetencion.Checked = False
                End If
                cmb_tip_doc_per.SelectedValue = .DOCUMENT_TYPE_PERSON_ID
                txtcodigoTipoEmp.Text = .TYPE_COMPANY
                txtcuentaContableSol.Text = .ACCOUNT_LOCAL
                txtcuentaContableDol.Text = .ACCOUNT_EXTERNAL

                txt_ap_paterno.Text = .AP_PATERNO
                txt_ap_materno.Text = .AP_MATERNO
                txt_primer_nombre.Text = .PRIMER_NOMBRE
                txt_segundo_nombre.Text = .SEGUNDO_NOMBRE

                If .TYPE_DISCOUNT = "0" Then
                    rbFarmacia.Checked = True
                ElseIf .TYPE_DISCOUNT = "1" Then
                    rbdistribuidor.Checked = True
                Else
                    rbdistribuidor.Checked = True
                End If
                txtnombreComercial.Text = .NAME_COMERTIAL
                If Not String.IsNullOrEmpty(.FLAG_PRINCIPAL.ToString) Then
                    If .FLAG_PRINCIPAL = "0" Then
                        gb_tipo_cliente.Enabled = Not Consultando_Jerarquia()
                        rb_sede.Checked = True
                    ElseIf .FLAG_PRINCIPAL = "1" Then
                        gb_tipo_cliente.Enabled = True
                        rb_principal.Checked = True
                        ' txt_des_cli.Enabled = False
                    End If
                End If
            End With
            If txt_cod_dep.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_des_depart.Text = clsBuscarBl.Get_Departamento_Manual(txt_cod_dep.Text)
                If txt_des_depart.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Departamento.", MsgBoxStyle.Information)
                    txt_cod_dep.Text = String.Empty
                End If
            End If
            If txt_cod_dep.Text <> String.Empty And txt_cod_prov.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_desc_prov.Text = clsBuscarBl.Get_Provincia_Manual(txt_cod_dep.Text, txt_cod_prov.Text)
                If txt_desc_prov.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo de la Provincia.", MsgBoxStyle.Information)
                    txt_cod_prov.Text = String.Empty
                End If
            End If
            If txt_cod_dep.Text <> String.Empty And txt_cod_prov.Text <> String.Empty And txt_cod_dist.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_desc_dist.Text = clsBuscarBl.Get_Distrito_Manual(txt_cod_dep.Text, txt_cod_prov.Text, txt_cod_dist.Text)
                If txt_desc_dist.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Distrito.", MsgBoxStyle.Information)
                    txt_cod_dist.Text = String.Empty
                End If
            End If
            If txt_cond_pago.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_desc_pago.Text = clsBuscarBl.Get_FormaCobro(txt_cond_pago.Text)
                If txt_desc_pago.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo de la Forma de Pago.", MsgBoxStyle.Information)
                    txt_cond_pago.Text = String.Empty
                End If
            End If
            If txt_cod_vende.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_desc_vende.Text = clsBuscarBl.Get_NombreVendedor(txt_cod_vende.Text)
                If txt_desc_vende.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Vendedor.", MsgBoxStyle.Information)
                    txt_cod_vende.Text = String.Empty
                End If
            End If

            If txt_tip_precio.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txt_des_tip_precio.Text = clsBuscarBl.Get_NombreTipoPrecio(txt_tip_precio.Text)
                If txt_des_tip_precio.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Tipo de Precio.", MsgBoxStyle.Information)
                    txt_des_tip_precio.Text = String.Empty
                    txt_tip_precio.Text = String.Empty
                End If
            End If

            If txtcodigoTipoEmp.Text <> String.Empty Then
                clsBuscarBl = New ClsBuscar
                txtdescripcionTipoEmp.Text = clsBuscarBl.Get_NombreTipo_Empresa(txtcodigoTipoEmp.Text)
                If txtdescripcionTipoEmp.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Tipo de Empresa.", MsgBoxStyle.Information)
                    txtdescripcionTipoEmp.Text = String.Empty
                    txtcodigoTipoEmp.Text = String.Empty
                End If
            End If
            gb_data.Enabled = True
            gb_mas_datos.Enabled = True
            txt_cod_cli.Enabled = False
            txt_ruc_cli.ReadOnly = True
            txt_des_cli.Focus()
            CONTROLES(TabPage1, False)
            CONTROLES(TabPage2, True)
            CONTROLES(TabPage3, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_FormaPago()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_FORMA_COBRO"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Forma de Pago"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cond_pago.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_desc_pago.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub

        If MessageBox.Show("Seguro de eliminar", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim clienteBE As New ClsEntidades.CUSTOMER
            Dim clienteBL As New ClsOperaciones.CUSTOMER
            clienteBE.ID = dgv_Lista.CurrentRow.Cells("CODIGO").Value
            clienteBL.Delete(clienteBE)
            clienteBE = Nothing
            clienteBL = Nothing
            MessageBox.Show("Listo!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Cargar_Clientes()
            txtFiltro.Text = String.Empty
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        gb_data.Enabled = False
        gb_mas_datos.Enabled = False
        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        gbGenerarCodigo.Visible = False
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
        tc_tipos.SelectedIndex = 0
        Cargar_Clientes()
    End Sub


    Private Sub cmb_banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_banco.SelectedIndexChanged
        If bol_cargar Then
            Call Cargar_Cuentas_Corrientes()
        End If
    End Sub


    Private Sub dgv_Lista_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Lista.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim STRFactura As String = String.Empty
            With dgv_Lista
                Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If hti.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = _
                    .Rows(hti.RowIndex).Cells(hti.ColumnIndex)
                End If

            End With
        End If
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub


    Private Sub txtTipoCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoCliente.MouseDoubleClick
        Cargar_TipoCliente()
    End Sub

    Private Sub txtTipoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Cargar_TipoCliente()
        End If
    End Sub

    Private Sub txtDepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepartamento.KeyDown
        If e.KeyCode = Keys.F1 Then
            txtDepartamento.Text = String.Empty
            Cargar_Departamento()
        End If
    End Sub

    Private Sub txtDepartamento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtDepartamento.MouseDoubleClick
        txtDepartamento.Text = String.Empty
        Cargar_Departamento()
    End Sub

    Private Sub txt_cod_prov_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prov.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_prov.Text = String.Empty
            Cargar_Provincia()
        End If
    End Sub

    Private Sub txt_cod_prov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_prov.MouseDoubleClick
        txt_cod_prov.Text = String.Empty
        Cargar_Provincia()
    End Sub

    Private Sub txt_cod_dist_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_dist.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_dist.Text = String.Empty
            Cargar_Distrito()
        End If
    End Sub

    Private Sub txt_cod_dist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_dist.MouseDoubleClick
        txt_cod_dist.Text = String.Empty
        Cargar_Distrito()
    End Sub

    Private Sub txt_cond_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cond_pago.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cond_pago.Text = String.Empty
            Ayuda_FormaPago()
        End If
    End Sub

    Private Sub txt_cond_pago_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cond_pago.MouseDoubleClick
        txt_cond_pago.Text = String.Empty
        Ayuda_FormaPago()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_vende_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vende.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_vende.Text = String.Empty
            Ayuda_Vendedor()
        End If
    End Sub

    Private Sub txt_cod_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_cli.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_des_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_des_cli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_dir_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dir_cli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_telf_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telf_cli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_ruc_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc_cli.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    If txt_ruc_cli.Text.Length <> 11 Then
        '        MsgBox("El RUC ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
        '        txt_ruc_cli.Focus()
        '    End If
        'End If
    End Sub

    Private Sub txt_num_doc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_doc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_fax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fax.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_porc_descto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_porc_descto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cond_pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cond_pago.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_contacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contacto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_activo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_activo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_inactivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_inactivo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_tip_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tip_precio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_vende_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_vende.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_tip_doc_per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_tip_doc_per.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_pais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pais.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_dep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_dep.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_prov.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_dist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_dist.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_pross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_pross.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_lim_sol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lim_sol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_saldo_sol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_saldo_sol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_lim_dol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lim_dol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_saldo_dol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_saldo_dol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_mail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_web_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_web.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_zon_ven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_zon_ven.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_obs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtcuentaContableSol_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaContableSol.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaContableSol)
    End Sub

    Private Sub txtcuentaContableDol_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaContableDol.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaContableDol)
    End Sub

    Private Sub txtcuentaContableSol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaContableSol.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaContableSol)
        End If
    End Sub

    Private Sub txtcuentaContableDol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaContableDol.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaContableDol)
        End If
    End Sub

    Private Sub Ayuda_TipoEmpresa()
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_COMPANY_TYPE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipo de Empresa"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoTipoEmp.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionTipoEmp.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtcodigoTipoEmp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoTipoEmp.MouseDoubleClick
        Ayuda_TipoEmpresa()
    End Sub

    Private Sub txtcodigoTipoEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoTipoEmp.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoEmpresa()
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub Consultando_Ruc()
        Dim clienteBl As ClsOperaciones.CUSTOMER
        Dim dt_ruc As New DataTable
        clienteBl = New ClsOperaciones.CUSTOMER
        dt_ruc = clienteBl.Validacion_Ruc(txt_ruc_cli.Text)
        If dt_ruc.Rows.Count() = 0 Then
            rb_principal.Checked = True
            txt_cod_cli.Select()
            Exit Sub
        Else
            Dim Principal() As DataRow = dt_ruc.Select("FLAG_PRINCIPAL='1'", "")
            If Principal.Count() <> 0 Then
                For Each row As DataRow In Principal
                    txt_des_cli.Text = row.Item("NAME").ToString
                    txt_dir_cli.Text = row.Item("ADDR").ToString
                    Exit For
                Next
                rb_sede.Checked = True
                'txt_des_cli.Enabled = False
                txt_cod_cli.Select()
                Exit Sub
            Else
                Dim Sede() As DataRow = dt_ruc.Select("FLAG_PRINCIPAL='0'", "")
                gb_tipo_cliente.Enabled = Not Consultando_Jerarquia()
                If Sede.Count() <> 0 Then
                    rb_sede.Checked = True
                    Exit Sub
                Else
                    MsgBox("El ruc existe, pero no se configuro el Tipo de Cliente.", MsgBoxStyle.Critical, "Sistemas")
                    rb_sede.Checked = True
                    txt_cod_cli.Select()
                End If
            End If
        End If
    End Sub

    Private Function Consultando_Jerarquia() As Boolean
        Dim clienteBl As ClsOperaciones.CUSTOMER
        Dim dt_ruc As New DataTable
        clienteBl = New ClsOperaciones.CUSTOMER
        dt_ruc = clienteBl.Validacion_Ruc_Principal(txt_ruc_cli.Text)
        If dt_ruc.Rows.Count() <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txt_ruc_cli_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc_cli.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bol_nuevo = True Then
                Consultando_Ruc()
            End If
        End If

    End Sub

    Private Sub txt_ruc_cli_TextChanged(sender As Object, e As EventArgs) Handles txt_ruc_cli.TextChanged
        'txt_num_doc.Text = txt_ruc_cli.Text
    End Sub

    Private Sub txt_cod_vende_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vende.MouseDoubleClick
        Ayuda_Vendedor()
    End Sub

    Private Sub txt_cod_dep_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_dep.MouseDoubleClick
        txt_cod_dep.Text = String.Empty
        Cargar_Departamento_modif()
    End Sub

    Private Sub txt_cod_dep_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_dep.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod_dep.Text = String.Empty
            Cargar_Departamento_modif()
        End If
    End Sub

    Private Sub dgv_Lista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Lista.CellContentDoubleClick
        Call btn_Editar_Click(sender, e)
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox6.Text = String.Empty
            Cargar_Departamento_direc_entrega()
        End If
    End Sub

    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseDoubleClick
        TextBox6.Text = String.Empty
        Cargar_Departamento_direc_entrega()
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox5.Text = String.Empty
            Cargar_Provincia_direcc_entrega()
        End If
    End Sub

    Private Sub TextBox5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox5.MouseDoubleClick
        TextBox5.Text = String.Empty
        Cargar_Provincia_direcc_entrega()
    End Sub

    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseDoubleClick
        TextBox4.Text = String.Empty
        Cargar_Distrito_direc_entrega()
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox4.Text = String.Empty
            Cargar_Distrito_direc_entrega()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Call Cargar_Direccion_Entrega(txtcod_cliente_de.Text.Trim)
        pnldirecentrega.Visible = False
        gb_data.Enabled = True
    End Sub

    Private Sub btndirecentrega_Click(sender As Object, e As EventArgs) Handles btndirecentrega.Click
        If txt_cod_cli.Text = "" Then
            MsgBox("El codigo del Cliente no existe, debe ingresar y/o elegir uno.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If
        txtcod_cliente_de.Text = txt_cod_cli.Text
        pnldirecentrega.Visible = True
        gb_data.Enabled = False
        txtdirecentrega.Text = String.Empty

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        txtdirecentrega.Focus()
    End Sub

    Private Sub txtdirecentrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdirecentrega.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox6.Focus()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox5.Focus()
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox4.Focus()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btn_ok.Focus()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txtcod_cliente_de.Text = "" Then
            Call Avisar("Debe elegir un cliente valido.")
            Exit Sub
        ElseIf txtdirecentrega.Text = "" Then
            Call Avisar("Debe ingresar una dirección de entrega.")
            txtdirecentrega.Focus()
            Exit Sub
        ElseIf TextBox6.Text.Trim = "" Then
            Call Avisar("Seleccione el codigo de un Departamento.")
            TextBox6.Focus()
            Exit Sub
        ElseIf TextBox5.Text.Trim = "" Then
            Call Avisar("Seleccione el codigo de una Provincia.")
            TextBox5.Focus()
            Exit Sub
        ElseIf TextBox4.Text.Trim = "" Then
            Call Avisar("Seleccione el codigo de un Distrito.")
            TextBox4.Focus()
            Exit Sub
        End If
        Dim CONSULTA As String = String.Empty
        Dim clienteBL As ClsOperaciones.CUSTOMER
        CONSULTA = "INSERT INTO dbo.ADDR_CUSTOMER (CUSTOMER_ID, ADDR, ZONE_ID, DEPARTAMENTO_ID, PROVINCIA_ID, DISTRITO_ID,ITEM)" _
                & " VALUES ('" & txtcod_cliente_de.Text.Trim() & "', '" & txtdirecentrega.Text.Trim() & "', '', '" & TextBox6.Text.Trim() & "', '" & TextBox5.Text.Trim() & "', '" & TextBox4.Text.Trim() & "'," & dtdetalleArticuloPrincipal.Rows.Count + 1 & ")"
        clienteBL = New ClsOperaciones.CUSTOMER
        If clienteBL.Ejecuta_consulta(CONSULTA) Then
            MsgBox("Guardado exitosamente.", MsgBoxStyle.Information)
            txtdirecentrega.Text = String.Empty

            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            txtdirecentrega.Focus()
        Else
            MsgBox("No se llego a registrar.", MsgBoxStyle.Information)
        End If
    End Sub


    Public Sub GenerarColummnaDataTable()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dtdetalleArticuloPrincipal.Columns.Add("CUSTOMER_ID", Type.GetType("System.String")) '1
        dtdetalleArticuloPrincipal.Columns.Add("ADDR", Type.GetType("System.String")) '2
        dtdetalleArticuloPrincipal.Columns.Add("DISTRITO_ID", Type.GetType("System.String")) '3
        dtdetalleArticuloPrincipal.Columns.Add("DISTRITO", Type.GetType("System.String")) '4
        dtdetalleArticuloPrincipal.Columns.Add("PROVINCIA_ID", Type.GetType("System.String")) '5
        dtdetalleArticuloPrincipal.Columns.Add("PROVINCIA", Type.GetType("System.String")) '6
        dtdetalleArticuloPrincipal.Columns.Add("DEPARTAMENTO_ID", Type.GetType("System.String")) '7
        dtdetalleArticuloPrincipal.Columns.Add("DEPARTAMENTO", Type.GetType("System.String")) '8

        dgvDetalle.DataSource = Nothing
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal

        dgvDetalle.Columns(0).HeaderText = "Item"

        dgvDetalle.Columns(2).HeaderText = "Dirección"
        dgvDetalle.Columns(4).HeaderText = "Distrito"
        dgvDetalle.Columns(6).HeaderText = "Provincia"
        dgvDetalle.Columns(8).HeaderText = "Departamento"

        dgvDetalle.Columns(1).Visible = False
        dgvDetalle.Columns(3).Visible = False
        dgvDetalle.Columns(5).Visible = False
        dgvDetalle.Columns(7).Visible = False

        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        txtdirecentrega.Focus()
    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        btn_ok_Click(sender, e)
        Call Cargar_Direccion_Entrega(txt_cod_cli.Text.Trim)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle.RowCount = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            Dim CONSULTA As String = String.Empty
            Dim clienteBL As ClsOperaciones.CUSTOMER
            CONSULTA = "DELETE dbo.ADDR_CUSTOMER WHERE CUSTOMER_ID='" & txt_cod_cli.Text.Trim & "' and ITEM=" & dgvDetalle.CurrentRow.Cells("ITEM").Value & " "

            clienteBL = New ClsOperaciones.CUSTOMER
            If clienteBL.Ejecuta_consulta(CONSULTA) Then
                MsgBox("Eliminado exitosamente.", MsgBoxStyle.Information)
                txtdirecentrega.Text = String.Empty

                TextBox1.Text = String.Empty
                TextBox2.Text = String.Empty
                TextBox3.Text = String.Empty
                TextBox4.Text = String.Empty
                TextBox5.Text = String.Empty
                TextBox6.Text = String.Empty
                txtdirecentrega.Focus()
            Else
                MsgBox("No se llego a registrar.", MsgBoxStyle.Critical)
            End If
        End If


    End Sub

    Private Sub txt_tip_precio_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tip_precio.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_tip_precio.Text = String.Empty
            txt_des_tip_precio.Text = String.Empty
            Ayuda_Tipo_Precio()
        End If
    End Sub

    Private Sub txt_tip_precio_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tip_precio.MouseDoubleClick
        txt_tip_precio.Text = String.Empty
        txt_des_tip_precio.Text = String.Empty
        Ayuda_Tipo_Precio()
    End Sub
    Private Sub Ayuda_Tipo_Precio()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CLI_SP_S_TIPOS_PRECIOS"
        frm.CadenaConsulta = sql
        frm._Flag_Filtro = False
        frm.Titulo = "Tipos de Precio"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_tip_precio.Text = String.Empty
            txt_des_tip_precio.Text = String.Empty
            txt_tip_precio.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_tip_precio.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_tip_precio.Focus()
            'Me.Cursor = Cursors.Default
        End If
        frm.Close()
    End Sub

    Private Sub txt_cod_cli_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_cli.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTipoCliente.Focus()
        End If
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        ToolStrip1.Enabled = False
        tc_tipos.Enabled = False
        rbcodigo.Checked = True
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        chk_todos.Checked = False
        pnlreporte.Visible = True
    End Sub

    Private Sub rbcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcodigo.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If rbcodigo.Checked = True Then
            txtdescripcion1.Text = "Del Cliente"
            txtdescripcion2.Text = "Al Cliente"
        End If
    End Sub

    Private Sub rbvendedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbvendedor.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If rbcodigo.Checked = True Then
            txtdescripcion1.Text = "Del Vendedor"
            txtdescripcion2.Text = "Al Vendedor"
        End If
    End Sub

    Private Sub rbtipocliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbtipocliente.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If rbcodigo.Checked = True Then
            txtdescripcion1.Text = "Del tipo de Cliente"
            txtdescripcion2.Text = "Al tipo de Cliente"
        End If
    End Sub

    Private Sub txtcodigo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigo1.KeyDown
        If e.KeyData = Keys.F1 Then
            Listado_Ayudas(txtcodigo1)
        End If
    End Sub

    Private Sub txtcodigo1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigo1.MouseDoubleClick
        Listado_Ayudas(txtcodigo1)
    End Sub

    Private Sub txtcodigo2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigo2.MouseDoubleClick
        Listado_Ayudas(txtcodigo2)
    End Sub

    Private Sub txtcodigo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigo2.KeyDown
        If e.KeyData = Keys.F1 Then
            Listado_Ayudas(txtcodigo2)
        End If
    End Sub
    Private Sub Listado_Ayudas(ByVal texto As TextBox)
        Try
            If chk_todos.Checked = False Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                If rbcodigo.Checked = True Then
                    sql = "CUSTOMER_SP_S_LISTADO_CUSTOMER"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Listado de Clientes"
                ElseIf rbvendedor.Checked = True Then
                    sql = "CUSTOMER_SP_S_LISTADO_SALES_REP"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Listado de Vendedores"
                ElseIf rbtipocliente.Checked = True Then
                    sql = "CLI_SP_S_CUSTOMER_REP_MASTER_HELP"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Listado de Tipo de Clientes"
                End If
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    texto.Text = frm.Data_Matriz.Rows(0).Item(0) & ":" & frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If chk_todos.Checked = True Then
            txtcodigo1.Enabled = False
            txtcodigo2.Enabled = False
        Else
            txtcodigo1.Enabled = True
            txtcodigo2.Enabled = True
        End If
    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try


            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("REPORTES_CUSTOMER")
            Me.Cursor = Cursors.WaitCursor
            If rbcodigo.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Customer_Codigo(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_cliente_codigo.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text))
                End If
            ElseIf rbvendedor.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Customer_Vendedor(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_cliente_vendedor.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text))
                End If
            ElseIf rbtipocliente.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Customer_Tipo_Customer(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_cliente_tipo_cliente.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text))
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStrip1.Enabled = True
        tc_tipos.Enabled = True
        pnlreporte.Visible = False
    End Sub

    Private Sub chk_validacion_fe_CheckedChanged(sender As Object, e As EventArgs) Handles chk_validacion_fe.CheckedChanged
        If chk_validacion_fe.Checked Then
            chk_validacion_fe.Text = "Cliente Validado? SI"
            chk_validacion_fe.ForeColor = Drawing.Color.Blue
        Else
            chk_validacion_fe.Text = "Cliente Validado? NO"
            chk_validacion_fe.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Private Sub dgv_Lista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_Lista.CellFormatting
        If dgv_Lista.Rows(e.RowIndex).Cells("ESTADO.VALIDACION").Value = "NO" Then
            dgv_Lista.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgv_Lista.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        Else
            dgv_Lista.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_Lista.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_ruc_cli.Text)) = 11 Then
                cmb_tip_doc_per.SelectedValue = "6"
            ElseIf Len(Strings.Trim(txt_ruc_cli.Text)) = 8 Then
                Me.Cursor = Cursors.Default
                MsgBox("RUC incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_ruc_cli.Focus()
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_ruc_cli.Focus()
                Exit Sub
            End If
            Dim clienteBL As ClsOperaciones.CUSTOMER
            clienteBL = New ClsOperaciones.CUSTOMER
            Dim dtvalidacion As New DataTable
            dtvalidacion = clienteBL.ValidacionCliente(txt_cod_cli.Text.Trim, txt_ruc_cli.Text.Trim)
            If dtvalidacion.Rows.Count() <> 0 Then
                MsgBox("Ya existe creado un cliente con el mismo Codigo y Ruc, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Verifica_WS(txt_ruc_cli.Text)
                txt_des_cli.Focus()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Verifica_WS(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/ruc?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_des_cli.Text = JObject.Parse(data)("nombre")
            txt_dir_cli.Text = JObject.Parse(data)("direccion")

            MsgBox("Estado: " & JObject.Parse(data)("estado").ToString & vbCrLf & "Condición: " & JObject.Parse(data)("condicion").ToString, MsgBoxStyle.Information, "Aviso")


            Dim dt_ubigeo As DataTable
            dt_ubigeo = New DataTable
            Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE

            txt_cod_dep.Text = Strings.Left(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Departamento(txt_cod_dep.Text, "", "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_des_depart.Text = dt_ubigeo.Rows(0).Item("DEPARTAMENTO")
            Else
                txt_des_depart.Text = ""
            End If

            txt_cod_prov.Text = Strings.Mid(JObject.Parse(data)("ubigeo"), 3, 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Provincia(txt_cod_dep.Text, txt_cod_prov.Text, "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_desc_prov.Text = dt_ubigeo.Rows(0).Item("PROVINCIA")
            Else
                txt_desc_prov.Text = ""
            End If

            txt_cod_dist.Text = Strings.Right(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Distrito(txt_cod_dep.Text, txt_cod_prov.Text, txt_cod_dist.Text)
            If dt_ubigeo.Rows.Count > 0 Then
                txt_desc_dist.Text = dt_ubigeo.Rows(0).Item("DISTRITO")
            Else
                txt_desc_dist.Text = ""
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_ruc_cli.Text)) = 11 Then
                Me.Cursor = Cursors.Default
                MsgBox("DNI incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_ruc_cli.Focus()
                Exit Sub
            ElseIf Len(Strings.Trim(txt_ruc_cli.Text)) = 8 Then
                cmb_tip_doc_per.SelectedValue = "1"
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 11 o 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_ruc_cli.Focus()
                Exit Sub
            End If

            Dim clienteBL As ClsOperaciones.CUSTOMER
            clienteBL = New ClsOperaciones.CUSTOMER
            Dim dtvalidacion As New DataTable
            dtvalidacion = clienteBL.ValidacionCliente(txt_cod_cli.Text.Trim, txt_ruc_cli.Text.Trim)
            If dtvalidacion.Rows.Count() <> 0 Then
                MsgBox("Ya existe creado un cliente con el mismo Codigo y Ruc, verifique.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Verifica_WS_DNI(txt_ruc_cli.Text)
                txt_des_cli.Focus()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Verifica_WS_DNI(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/dni?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_des_cli.Text = JObject.Parse(data)("nombre")
            txt_dir_cli.Text = ""

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub
End Class