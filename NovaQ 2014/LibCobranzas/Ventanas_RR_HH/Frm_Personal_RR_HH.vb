Imports System.Windows.Forms

Public Class Frm_Personal_RR_HH
    Dim dv_lista As New DataView
    Dim bol_nuevo As Boolean = False
    Dim bol_cargar As Boolean = False
    Dim clsLetrasBl As ClsNegocio.PART
    Dim clsBuscarBl As ClsBuscar
    Dim clienteBL As ClsNegocio.Personal_RRHH
    Dim dtdetalles As DataTable
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim dtdetalles_direc_entrega As DataTable
    Dim ArticulosBl As ClsOperaciones.PART
    Dim articuloPA As ClsEntidades.ADDR_CUSTOMER
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_ctas_bancarias As DataTable

    Dim edicion As Boolean = False
    Dim codigo_contacto As Integer = 0
    Dim codigo_cuenta_bancaria As Integer = 0

    Private Sub Frm_Personal_RR_HH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Personal()
        Call Cargar_Documentos_Persona()
        Botonera_Estado_Cambiar(False)
        bol_cargar = True
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
    End Sub

    Private Sub Cargar_Personal()
        Try
            clienteBL = New ClsNegocio.Personal_RRHH
            dtv = New DataView
            dtdetalles = New DataTable("Datos")
            dtdetalles = clienteBL.get_Personal_RRHH()
            dtv = dtdetalles.DefaultView
            dgv_Lista.DataSource = Nothing
            STRorden = ""
            If dtdetalles.Rows.Count() <> 0 Then
                dgv_Lista.DataSource = dtv
                clienteBL = Nothing
                dgv_Lista.Columns("CODIGO").Width = 50
                dgv_Lista.Columns("NOMBRE").Width = 150
                dgv_Lista.Columns("APELLIDO_PATERNO").Width = 150
                dgv_Lista.Columns("APELLIDO_MATERNO").Width = 150
                dgv_Lista.Columns("NUMERO_DOCUMENTO").Width = 100

                dgv_Lista.Columns("CODIGO").HeaderText = "CODIGO"
                dgv_Lista.Columns("NOMBRE").HeaderText = "NOMBRE(S)"
                dgv_Lista.Columns("APELLIDO_PATERNO").HeaderText = "APELLIDO PATERNO"
                dgv_Lista.Columns("APELLIDO_MATERNO").HeaderText = "APELLIDO MATERNO"
                dgv_Lista.Columns("NUMERO_DOCUMENTO").HeaderText = "N° DOCUMENTO"

                STRorden = dgv_Lista.Columns("CODIGO").Name & "+" & dgv_Lista.Columns("NOMBRE").Name & "+" & dgv_Lista.Columns("APELLIDO_PATERNO").Name & "+" & dgv_Lista.Columns("APELLIDO_MATERNO").Name & "+" & dgv_Lista.Columns("NUMERO_DOCUMENTO").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub blank()
        txt_codigo_personal.Text = String.Empty
        txt_codigo_personal2.Text = String.Empty
        txt_descripcion_personal.Text = String.Empty
        txt_descripcion_personal2.Text = String.Empty
        txt_ap_paterno.Text = String.Empty
        txt_ap_materno.Text = String.Empty
        txt_primer_nombre.Text = String.Empty
        txt_segundo_nombre.Text = String.Empty
        cmb_tip_doc_per.SelectedIndex = -1
        txt_num_doc.Text = String.Empty
        cbo_tipo_via.SelectedIndex = -1
        txt_nombre_via.Text = String.Empty
        txt_numero_via.Text = String.Empty
        cbo_tipo_zona.SelectedIndex = -1
        txt_cod_dep.Text = String.Empty
        txt_des_depart.Text = String.Empty
        txt_cod_prov.Text = String.Empty
        txt_desc_prov.Text = String.Empty
        txt_cod_dist.Text = String.Empty
        txt_desc_dist.Text = String.Empty
        txt_nombre_zona.Text = String.Empty
        txt_referencia.Text = String.Empty
        txt_email.Text = String.Empty
        txt_telefono_fijo.Text = String.Empty
        txt_telefono_movil.Text = String.Empty
        cbo_sexo.SelectedIndex = -1
        cbo_estado_civil.SelectedIndex = -1
        txt_fecha_de_nacimiento.Text = String.Empty
        txt_cod_nacionalidad.Text = String.Empty
        txt_desc_nacionalidad.Text = String.Empty
        gb_estado.Enabled = True

        txt_fecha_ingreso.Text = String.Empty
        txt_fecha_cese.Text = String.Empty
        cbo_establecimiento.SelectedIndex = -1
        cbo_cargo.SelectedIndex = -1
        cbo_area.SelectedIndex = -1
        cbo_fondo_pensiones.SelectedIndex = -1
        txt_cuspp.Text = String.Empty
        cbo_comision_afp.SelectedIndex = -1
        txt_fecha_inscripcion_afp.Text = String.Empty
        chk_senati.Checked = False
        chk_sctr.Checked = False
        chk_aseg_pension.Checked = False
        chk_esalud_vida.Checked = False
        chk_asignacion_familiar.Checked = False
        chk_afecto_quinta.Checked = False
        chk_afecto_essalud.Checked = False
        chk_Eps.Checked = False
        txt_remuneracion.Text = String.Empty
        cbo_banco_remuneracion.SelectedIndex = -1
        cbo_moneda_remuneracion.SelectedIndex = -1
        txt_numero_cuenta_remuneracion.Text = String.Empty
        cbo_banco_cts.SelectedIndex = -1
        cbo_moneda_cts.SelectedIndex = -1
        txt_numero_cuenta_cts.Text = String.Empty
        txt_eps.Text = String.Empty
        txt_movilidad.Text = String.Empty
    End Sub

    Private Sub Cargar_Departamento()
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
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Provincia()
        Try
            If String.IsNullOrEmpty(txt_cod_dep.Text) Then
                MsgBox("Debe elegir un departamento", MsgBoxStyle.Exclamation)
                txt_cod_dep.Focus()
                Exit Sub
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_dep.Text
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

    Private Sub Cargar_Distrito()
        Try
            If String.IsNullOrEmpty(txt_cod_dep.Text) Then
                MsgBox("Debe elegir un departamento", MsgBoxStyle.Exclamation)
                txt_cod_dep.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(txt_cod_prov.Text) Then
                MsgBox("Debe elegir una Provincia", MsgBoxStyle.Exclamation)
                txt_cod_prov.Focus()
                Exit Sub
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_dep.Text
            frm.Filtros2 = txt_cod_prov.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_dist.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_desc_dist.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Documentos_Persona()
        Dim tipoDocBL As New LibContabilidad.ClsOperaciones.CO_TB_TIPO_DOC_ANE
        cmb_tip_doc_per.DataSource = tipoDocBL.get_Tipos
        cmb_tip_doc_per.DisplayMember = "TD_DESCRIPCION"
        cmb_tip_doc_per.ValueMember = "TD_ID"

        cbo_tipo_via.DataSource = tipoDocBL.get_Tipo_Via
        cbo_tipo_via.DisplayMember = "DESCRIPTION"
        cbo_tipo_via.ValueMember = "VIA_ID"

        cbo_tipo_zona.DataSource = tipoDocBL.get_Tipo_Zona_RR_HH
        cbo_tipo_zona.DisplayMember = "DESCRIPTION"
        cbo_tipo_zona.ValueMember = "ZONA_ID"

        cbo_estado_civil.DataSource = tipoDocBL.get_Estado_Civil_RR_HH
        cbo_estado_civil.DisplayMember = "DESCRIPTION"
        cbo_estado_civil.ValueMember = "CIVIL_STATUS_ID"

        cbo_establecimiento.DataSource = tipoDocBL.get_Establecimiento_RR_HH
        cbo_establecimiento.DisplayMember = "DESCRIPTION"
        cbo_establecimiento.ValueMember = "ID_ESTABLISHMENT"

        cbo_cargo.DataSource = tipoDocBL.get_Cargo_RR_HH
        cbo_cargo.DisplayMember = "DESCRIPCION"
        cbo_cargo.ValueMember = "ID"

        cbo_area.DataSource = tipoDocBL.get_Area_RR_HH
        cbo_area.DisplayMember = "DESCRIPTION"
        cbo_area.ValueMember = "AREA_ID"

        cbo_fondo_pensiones.DataSource = tipoDocBL.get_Fondo_Pensiones_RR_HH
        cbo_fondo_pensiones.DisplayMember = "AFP_DESCRIPTION"
        cbo_fondo_pensiones.ValueMember = "AFP_ID"

        cbo_comision_afp.DataSource = tipoDocBL.get_Comision_AFP_RR_HH
        cbo_comision_afp.DisplayMember = "DESCRIPTION"
        cbo_comision_afp.ValueMember = "ID"

        cbo_banco_remuneracion.DataSource = tipoDocBL.get_Banco_RR_HH
        cbo_banco_remuneracion.DisplayMember = "NAME"
        cbo_banco_remuneracion.ValueMember = "ID"

        cbo_moneda_remuneracion.DataSource = tipoDocBL.get_Moneda_RR_HH
        cbo_moneda_remuneracion.DisplayMember = "DESCRIPCION"
        cbo_moneda_remuneracion.ValueMember = "CODIGO"

        cbo_banco_cts.DataSource = tipoDocBL.get_Banco_RR_HH
        cbo_banco_cts.DisplayMember = "NAME"
        cbo_banco_cts.ValueMember = "ID"

        cbo_moneda_cts.DataSource = tipoDocBL.get_Moneda_RR_HH
        cbo_moneda_cts.DisplayMember = "DESCRIPCION"
        cbo_moneda_cts.ValueMember = "CODIGO"

        cbo_tipo_planilla.DataSource = tipoDocBL.get_Tipo_Planilla
        cbo_tipo_planilla.DisplayMember = "DESCRIPCION"
        cbo_tipo_planilla.ValueMember = "CODIGO"

        tipoDocBL = Nothing

    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        CONTROLES(TabPage3, True)
        gb_data.Enabled = True
        bol_nuevo = True
        blank()
        'GenerarCodigo_Personal()
        txt_ap_paterno.Focus()
    End Sub

    Private Sub GenerarCodigo_Personal()
        Try
            clienteBL = New ClsNegocio.Personal_RRHH
            dtdetalles = New DataTable("Datos")
            dtdetalles = clienteBL.Generar_codigo_Personal_RR_HH()
            If dtdetalles.Rows.Count() <> 0 Then
                txt_codigo_personal.Text = dtdetalles.Rows(0).Item(0).ToString
                txt_codigo_personal2.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        gb_data.Enabled = False
        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
        tc_tipos.SelectedIndex = 0
    End Sub


    Private Sub dgv_Lista_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Lista.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
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
        If STRorden = "" Then Exit Sub

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

    Private Sub txt_cod_prov_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prov.KeyDown
        If e.KeyCode = Keys.F1 Then Cargar_Provincia()

        If e.KeyCode = Keys.Enter Then
            If txt_cod_prov.Text = "" Then
                Cargar_Provincia()
            Else
                txt_cod_dist.Focus()
            End If
        End If

    End Sub

    Private Sub txt_cod_prov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_prov.MouseDoubleClick
        Cargar_Provincia()
    End Sub

    Private Sub txt_cod_dist_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_dist.KeyDown
        If e.KeyCode = Keys.F1 Then Cargar_Distrito()

        If e.KeyCode = Keys.Enter Then
            If txt_cod_dist.Text = "" Then
                Cargar_Distrito()
            Else
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cod_dist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_dist.MouseDoubleClick
        Cargar_Distrito()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_cod_dep_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_dep.MouseDoubleClick
        Cargar_Departamento()
    End Sub

    Private Sub txt_cod_dep_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_dep.KeyDown
        If e.KeyCode = Keys.F1 Then Cargar_Departamento()

        If e.KeyCode = Keys.Enter Then
            If txt_cod_dep.Text = "" Then
                Cargar_Departamento()
            Else
                txt_cod_prov.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono_movil.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_nacionalidad.Focus()
        End If
    End Sub


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
            Case 2
                tc_tipos.SelectedIndex = indice - 1
            Case 3
                tc_tipos.SelectedIndex = indice - 1
            Case 4
                tc_tipos.SelectedIndex = indice - 1
            Case 5
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
            btnimprimir.Enabled = False
        Else
            btn_Nuevo.Enabled = True
            btnimprimir.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            Botonera_Estado_Cambiar(True)
            bol_nuevo = False
            blank()
            Dim personalRRHH As New ClsEntidades.PL_EMPLOYEE
            Dim clienteBL As New ClsOperaciones.CUSTOMER
            personalRRHH.EMPLOYEE_ID = dgv_Lista.CurrentRow.Cells("CODIGO").Value.ToString
            clienteBL.get_Personal_RR_HH(personalRRHH)
            With personalRRHH
                txt_codigo_personal.Text = .EMPLOYEE_ID
                txt_codigo_personal2.Text = .EMPLOYEE_ID
                txt_descripcion_personal.Text = .PATERNAL_LAST_NAME & " " & .MATERNAL_LAST_NAME & " " & .EMPLOYEE_FIRST_NAME & " " & .EMPLOYEE_SECOND_NAME
                txt_descripcion_personal2.Text = .PATERNAL_LAST_NAME & " " & .MATERNAL_LAST_NAME & " " & .EMPLOYEE_FIRST_NAME & " " & .EMPLOYEE_SECOND_NAME
                txt_ap_paterno.Text = .PATERNAL_LAST_NAME
                txt_ap_materno.Text = .MATERNAL_LAST_NAME
                txt_primer_nombre.Text = .EMPLOYEE_FIRST_NAME
                txt_segundo_nombre.Text = .EMPLOYEE_SECOND_NAME
                cmb_tip_doc_per.SelectedValue = .EMP_TYPE_DOCUMENT
                txt_num_doc.Text = .EMP_NUMBER_DOC
                cbo_tipo_via.SelectedValue = .EMP_TYPE_VIA
                txt_nombre_via.Text = .EMP_NAME_VIA
                txt_numero_via.Text = .EMP_NUMBER_VIA
                cbo_tipo_zona.SelectedValue = .EMP_ZONA_TYPE
                txt_nombre_zona.Text = .EMP_ZONA_NAME
                txt_referencia.Text = .EMP_ZONA_REFERENCE
                txt_cod_dep.Text = Strings.Left(.EMP_UBIGEO, 2)
                txt_cod_prov.Text = Strings.Mid(.EMP_UBIGEO, 3, 2)
                txt_cod_dist.Text = Strings.Right(.EMP_UBIGEO, 2)

                If txt_cod_dep.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    txt_des_depart.Text = clsBuscarBl.Get_Departamento_Manual(txt_cod_dep.Text)
                    If txt_des_depart.Text = String.Empty Then
                        txt_cod_dep.Text = String.Empty
                    End If
                End If
                If txt_cod_dep.Text <> String.Empty And txt_cod_prov.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    txt_desc_prov.Text = clsBuscarBl.Get_Provincia_Manual(txt_cod_dep.Text, txt_cod_prov.Text)
                    If txt_desc_prov.Text = String.Empty Then
                        txt_cod_prov.Text = String.Empty
                    End If
                End If
                If txt_cod_dep.Text <> String.Empty And txt_cod_prov.Text <> String.Empty And txt_cod_dist.Text <> String.Empty Then
                    clsBuscarBl = New ClsBuscar
                    txt_desc_dist.Text = clsBuscarBl.Get_Distrito_Manual(txt_cod_dep.Text, txt_cod_prov.Text, txt_cod_dist.Text)
                    If txt_desc_dist.Text = String.Empty Then
                        txt_cod_dist.Text = String.Empty
                    End If
                End If

                txt_email.Text = .EMAIL
                txt_telefono_fijo.Text = .EMP_PHONE
                txt_telefono_movil.Text = .EMP_CEL
                txt_cod_nacionalidad.Text = .NATIONALITY_ID
                txt_desc_nacionalidad.Text = .NATIONALITY_DESC
                If .EMP_SEX = "M" Then
                    cbo_sexo.SelectedIndex = 0
                ElseIf .EMP_SEX = "F" Then
                    cbo_sexo.SelectedIndex = 1
                End If

                cbo_estado_civil.SelectedValue = .CIVIL_STATE_ID
                txt_fecha_de_nacimiento.Text = .EMP_DATE_BIRTH

                If .STATUS = "V" Then
                    rb_activo.Checked = True
                ElseIf .STATUS = "A" Then
                    rb_inactivo.Checked = True
                End If

                txt_fecha_ingreso.Text = .FECHA_INGRESO
                txt_fecha_cese.Text = .FECHA_CESE
                cbo_establecimiento.SelectedValue = .ESTABLECIMIENTO
                cbo_cargo.SelectedValue = .CARGO
                cbo_area.SelectedValue = .AREA
                cbo_fondo_pensiones.SelectedValue = .FONDO_PENSIONES
                txt_cuspp.Text = .CUSPP
                cbo_comision_afp.SelectedValue = .COMISION_AFP
                txt_fecha_inscripcion_afp.Text = .FECHA_INSCRIP_AFP

                If .SENATI = "S" Then
                    chk_senati.Checked = True
                Else
                    chk_senati.Checked = False
                End If

                If .SCTR = "S" Then
                    chk_sctr.Checked = True
                Else
                    chk_sctr.Checked = False
                End If

                If .ASEG_PENSION = "S" Then
                    chk_aseg_pension.Checked = True
                Else
                    chk_aseg_pension.Checked = False
                End If

                If .ESSALUD_VIDA = "S" Then
                    chk_esalud_vida.Checked = True
                Else
                    chk_esalud_vida.Checked = False
                End If

                If .ASIG_FAMILIAR = "S" Then
                    chk_asignacion_familiar.Checked = True
                Else
                    chk_asignacion_familiar.Checked = False
                End If

                If .AFECTO_QUINTA = "S" Then
                    chk_afecto_quinta.Checked = True
                Else
                    chk_afecto_quinta.Checked = False
                End If

                If .AFECTO_EPS = "S" Then
                    chk_Eps.Checked = True
                Else
                    chk_Eps.Checked = False
                End If

                If .AFECTO_ESSALUD = "S" Then
                    chk_afecto_essalud.Checked = True
                Else
                    chk_afecto_essalud.Checked = False
                End If

                txt_remuneracion.Text = .REMUNERACION
                txt_remuneracion.Text = Format(CDbl(txt_remuneracion.Text), "##,##0.00")
                cbo_banco_remuneracion.SelectedValue = .BANCO_REMUNERACION
                cbo_moneda_remuneracion.SelectedValue = .MONEDA_REMUNERACION
                txt_numero_cuenta_remuneracion.Text = .NUM_CUENTA_REMUNERACION
                cbo_banco_cts.SelectedValue = .BANCO_CTS
                cbo_moneda_cts.SelectedValue = .MONEDA_CTS
                txt_numero_cuenta_cts.Text = .NUM_CUENTA_CTS

                txt_eps.Text = .EPS
                txt_eps.Text = Format(CDbl(txt_eps.Text), "##,##0.00")

                txt_movilidad.Text = .MOVILIDAD
                txt_movilidad.Text = Format(CDbl(txt_movilidad.Text), "##,##0.00")

                cbo_tipo_planilla.SelectedValue = .TIPO_PLANILLA

                gb_data.Enabled = True
                CONTROLES(TabPage1, False)
                CONTROLES(TabPage2, True)
                CONTROLES(TabPage3, True)


            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try

            If txt_ap_paterno.Text = "" Then
                MsgBox("Debe ingresar el Apellido Paterno del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_ap_paterno.Select()
                Exit Sub
            ElseIf txt_ap_materno.Text = "" Then
                MsgBox("Debe ingresar el Apellido Materno del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_ap_materno.Select()
                Exit Sub
            ElseIf txt_primer_nombre.Text.Trim = "" Then
                MsgBox("Debe ingresar el primer nombre del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_primer_nombre.Select()
                Exit Sub
            ElseIf txt_num_doc.Text.Trim = "" Then
                MsgBox("Debe ingresar el número de documento del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_num_doc.Select()
                Exit Sub
            ElseIf cbo_tipo_via.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Tipo de Via.", MsgBoxStyle.Exclamation, "Sistemas")
                cbo_tipo_via.Focus()
                Exit Sub
            ElseIf txt_nombre_via.Text.Trim = "" Then
                MsgBox("Debe ingresar la dirección del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_nombre_via.Select()
                Exit Sub
            ElseIf txt_telefono_movil.Text.Trim = "" Then
                MsgBox("Debe ingresar el teléfono movil del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_telefono_movil.Select()
                Exit Sub
            ElseIf txt_cod_dep.Text.Trim = "" Then
                MsgBox("Debe elegir un Departamento.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_cod_dep.Select()
                Exit Sub
            ElseIf txt_cod_prov.Text.Trim = "" Then
                MsgBox("Debe elegir una Provincia.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_cod_prov.Select()
                Exit Sub
            ElseIf txt_cod_dist.Text.Trim = "" Then
                MsgBox("Debe elegir un Distrito.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_cod_dist.Select()
                Exit Sub
            ElseIf txt_cod_nacionalidad.Text.Trim = "" Then
                MsgBox("Debe elegir la nacionalidad del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_cod_nacionalidad.Select()
                Exit Sub
            ElseIf cbo_sexo.SelectedIndex = -1 Then
                MsgBox("Debe elegir el sexo del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                cbo_sexo.Focus()
                Exit Sub
            ElseIf cbo_estado_civil.SelectedIndex = -1 Then
                MsgBox("Debe elegir el estado civil del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                cbo_estado_civil.Focus()
                Exit Sub
            ElseIf txt_fecha_de_nacimiento.Text.Trim = "" Then
                MsgBox("Debe ingresar la fecha de nacimiento del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_fecha_de_nacimiento.Select()
                Exit Sub
            End If

            If txt_fecha_ingreso.Text.Trim = "" Then
                MsgBox("Debe ingresar la fecha de ingreso del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_fecha_ingreso.Select()
                Exit Sub
            ElseIf cbo_fondo_pensiones.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Fondo de Pensiones del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                cbo_fondo_pensiones.Focus()
                Exit Sub
            ElseIf cbo_tipo_planilla.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Tipo de Planilla del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                cbo_tipo_planilla.Focus()
                Exit Sub
            ElseIf txt_remuneracion.Text.Trim = "" Then
                MsgBox("Debe ingresar la remuneración del Personal.", MsgBoxStyle.Exclamation, "Sistemas")
                txt_remuneracion.Select()
                Exit Sub
            End If

            If bol_nuevo Then
                'If txt_num_doc.Text.Length <> 11 And txt_num_doc.Text.Length <> 8 Then
                '    MsgBox("El RUC/DNI ingresado debe tener 11 o 8 caracteres!", MsgBoxStyle.Critical)
                '    txt_num_doc.Focus()
                '    Exit Sub
                'End If
            End If

            If txt_fecha_cese.Text <> "" Then
                If CDate(txt_fecha_ingreso.Text) > CDate(txt_fecha_cese.Text) Then
                    MsgBox("La Fecha de Cese es incorrecto.", MsgBoxStyle.Exclamation, "Sistemas")
                    txt_fecha_cese.Focus()
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim clienteBL As ClsOperaciones.CUSTOMER
            Dim personal_RR_HH As New ClsEntidades.PL_EMPLOYEE

            If bol_nuevo Then
                clienteBL = New ClsOperaciones.CUSTOMER
                Dim dtvalidacion As New DataTable
                dtvalidacion = clienteBL.Validacion_Personal_RR_HH(txt_num_doc.Text.Trim)
                If dtvalidacion.Rows.Count() <> 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Personal a registrar ya existe en el sistema.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
            clienteBL = New ClsOperaciones.CUSTOMER
            With personal_RR_HH
                .EMPLOYEE_ID = txt_codigo_personal.Text.Trim
                .PATERNAL_LAST_NAME = txt_ap_paterno.Text.Trim
                .MATERNAL_LAST_NAME = txt_ap_materno.Text.Trim
                .EMPLOYEE_FIRST_NAME = txt_primer_nombre.Text.Trim
                .EMPLOYEE_SECOND_NAME = txt_segundo_nombre.Text.Trim
                .EMP_TYPE_DOCUMENT = cmb_tip_doc_per.SelectedValue
                .EMP_NUMBER_DOC = txt_num_doc.Text.Trim
                .EMP_TYPE_VIA = cbo_tipo_via.SelectedValue
                .EMP_NAME_VIA = txt_nombre_via.Text.Trim
                .EMP_NUMBER_VIA = txt_numero_via.Text.Trim
                .EMP_ZONA_TYPE = cbo_tipo_zona.SelectedValue
                .EMP_ZONA_NAME = txt_nombre_zona.Text.Trim
                .EMP_ZONA_REFERENCE = txt_referencia.Text.Trim
                .EMP_UBIGEO = txt_cod_dep.Text.Trim & txt_cod_prov.Text.Trim & txt_cod_dist.Text.Trim
                .EMAIL = txt_email.Text.Trim
                .EMP_PHONE = txt_telefono_fijo.Text.Trim
                .EMP_CEL = txt_telefono_movil.Text.Trim
                .NATIONALITY_ID = txt_cod_nacionalidad.Text.Trim
                .EMP_SEX = cbo_sexo.Text
                .CIVIL_STATE_ID = cbo_estado_civil.SelectedValue
                .EMP_DATE_BIRTH = txt_fecha_de_nacimiento.Text.Trim
                If rb_inactivo.Checked = True Then
                    .STATUS = "A"
                ElseIf rb_activo.Checked = True Then
                    .STATUS = "V"
                End If
                .USER_ID = LibComunVar.ClsVarComun.USUARIO

                .FECHA_INGRESO = txt_fecha_ingreso.Text
                .FECHA_CESE = txt_fecha_cese.Text
                .ESTABLECIMIENTO = cbo_establecimiento.SelectedValue
                .CARGO = cbo_cargo.SelectedValue
                .AREA = cbo_area.SelectedValue
                .FONDO_PENSIONES = cbo_fondo_pensiones.SelectedValue
                .CUSPP = txt_cuspp.Text
                .COMISION_AFP = cbo_comision_afp.SelectedValue
                .FECHA_INSCRIP_AFP = txt_fecha_inscripcion_afp.Text
                .SENATI = IIf(chk_senati.Checked, "S", "N")
                .SCTR = IIf(chk_sctr.Checked, "S", "N")
                .ASEG_PENSION = IIf(chk_aseg_pension.Checked, "S", "N")
                .ESSALUD_VIDA = IIf(chk_esalud_vida.Checked, "S", "N")
                .ASIG_FAMILIAR = IIf(chk_asignacion_familiar.Checked, "S", "N")
                .AFECTO_QUINTA = IIf(chk_afecto_quinta.Checked, "S", "N")
                If txt_remuneracion.Text = "" Then
                    .REMUNERACION = 0
                Else
                    .REMUNERACION = CDbl(txt_remuneracion.Text)
                End If

                .BANCO_REMUNERACION = cbo_banco_remuneracion.SelectedValue
                .MONEDA_REMUNERACION = cbo_moneda_remuneracion.SelectedValue
                .NUM_CUENTA_REMUNERACION = txt_numero_cuenta_remuneracion.Text
                .BANCO_CTS = cbo_banco_cts.SelectedValue
                .MONEDA_CTS = cbo_moneda_cts.SelectedValue
                .NUM_CUENTA_CTS = txt_numero_cuenta_cts.Text
                .TIPO_PLANILLA = cbo_tipo_planilla.SelectedValue
                If txt_eps.Text = "" Then
                    .EPS = 0
                Else
                    .EPS = CDbl(txt_eps.Text)
                End If

                If txt_movilidad.Text = "" Then
                    .MOVILIDAD = 0
                Else
                    .MOVILIDAD = CDbl(txt_movilidad.Text)
                End If

                .AFECTO_EPS = IIf(chk_Eps.Checked, "S", "N")
                .AFECTO_ESSALUD = IIf(chk_afecto_essalud.Checked, "S", "N")
            End With

            If bol_nuevo Then
                If clienteBL.Insert_Personal_RR_HH(personal_RR_HH) Then
                    MessageBox.Show("Personal registrado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cargar_Personal()
                    btn_cancelar_Click(sender, e)
                    dgv_Lista.Focus()
                End If
            Else
                If clienteBL.Update_Personal_RR_HH(personal_RR_HH) Then
                    MessageBox.Show("Personal actualizado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cargar_Personal()
                    btn_cancelar_Click(sender, e)
                    dgv_Lista.Focus()
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub

        Try
            If MessageBox.Show("Seguro de eliminar el Personal", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim clienteBE As New ClsEntidades.PL_EMPLOYEE
                Dim clienteBL As New ClsOperaciones.CUSTOMER
                clienteBE.EMPLOYEE_ID = dgv_Lista.CurrentRow.Cells("CODIGO").Value
                clienteBL.Delete_Personal_RR_HH(clienteBE)
                clienteBE = Nothing
                clienteBL = Nothing
                MessageBox.Show("Eliminación del Personal correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Cargar_Personal()
                txtFiltro.Text = String.Empty
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click

    End Sub

    Private Sub txt_ap_paterno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_paterno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ap_materno.Focus()
        End If
    End Sub

    Private Sub txt_ap_materno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ap_materno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_primer_nombre.Focus()
        End If
    End Sub

    Private Sub txt_primer_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_primer_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_segundo_nombre.Focus()
        End If
    End Sub

    Private Sub txt_segundo_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_segundo_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_tip_doc_per.Focus()
        End If
    End Sub

    Private Sub cmb_tip_doc_per_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tip_doc_per.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_doc.Focus()
        End If
    End Sub

    Private Sub txt_num_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipo_via.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_via_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_via.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre_via.Focus()
        End If
    End Sub

    Private Sub txt_nombre_via_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre_via.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_numero_via.Focus()
        End If
    End Sub

    Private Sub txt_numero_via_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_via.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipo_zona.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_zona_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_zona.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre_zona.Focus()
        End If
    End Sub

    Private Sub txt_nombre_zona_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre_zona.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_referencia.Focus()
        End If
    End Sub

    Private Sub txt_referencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_referencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_dep.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_telefono_fijo.Focus()
        End If
    End Sub

    Private Sub txt_telefono_fijo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono_fijo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_telefono_movil.Focus()
        End If
    End Sub

    Private Sub cbo_sexo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_sexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_estado_civil.Focus()
        End If
    End Sub

    Private Sub cbo_estado_civil_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_estado_civil.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_de_nacimiento.Focus()
        End If
    End Sub

    Private Sub txt_cod_nacionalidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_nacionalidad.KeyDown
        If e.KeyCode = Keys.F1 Then Cargar_Nacionalidad()

        If e.KeyCode = Keys.Enter Then
            If txt_cod_nacionalidad.Text = "" Then
                Cargar_Nacionalidad()
            Else
                cbo_sexo.Focus()
            End If
        End If
    End Sub

    Private Sub Cargar_Nacionalidad()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PLA_SP_S_PL_NATIONALITY"
            frm.CadenaConsulta = sql
            frm.Titulo = "Nacionalidad"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_nacionalidad.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_desc_nacionalidad.Text = frm.Data_Matriz.Rows(0).Item("DESCRIPCION").ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_nacionalidad_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_nacionalidad.MouseDoubleClick
        Cargar_Nacionalidad()
    End Sub

    Private Sub txt_remuneracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_remuneracion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_eps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eps.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class