Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_AF_MA_Activo
    Dim bol_nuevo As Boolean = False
    Dim dt_lista As DataTable
    Dim flag_familia As Boolean

    Private Sub frm_AF_MA_Activo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        flag_familia = False
        Call Cargar_Lista()
        Call Cargar_Combos()
        Call Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Combos()
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        Dim ds_combos As DataSet = activoBL.get_Lista_Combos()
        activoBL = Nothing

        cmb_area.DataSource = ds_combos.Tables(0)
        cmb_area.DisplayMember = "AR_DESCRIPCION"
        cmb_area.ValueMember = "AR_ID"

        cmb_cc.DataSource = ds_combos.Tables(1)
        cmb_cc.DisplayMember = "CC_DESCRIPCION"
        cmb_cc.ValueMember = "CC_ID"

        cmb_clase.DataSource = ds_combos.Tables(2)
        cmb_clase.DisplayMember = "CL_DESCRIPCION"
        cmb_clase.ValueMember = "CL_ID"

        cmb_est_fis.DataSource = ds_combos.Tables(3)
        cmb_est_fis.DisplayMember = "EF_DESCRIPCION"
        cmb_est_fis.ValueMember = "EF_ID"

        cmb_familia.DataSource = ds_combos.Tables(4)
        cmb_familia.DisplayMember = "FA_DESCRIPCION"
        cmb_familia.ValueMember = "FA_ID"

        cmb_grupo.DataSource = ds_combos.Tables(5)
        cmb_grupo.DisplayMember = "GR_DESCRIPCION"
        cmb_grupo.ValueMember = "GR_ID"

        cmb_marca.DataSource = ds_combos.Tables(6)
        cmb_marca.DisplayMember = "MA_DESCRIPCION"
        cmb_marca.ValueMember = "MA_ID"

        cmb_nivel_obs.DataSource = ds_combos.Tables(7)
        cmb_nivel_obs.DisplayMember = "NO_DESCRIPCION"
        cmb_nivel_obs.ValueMember = "NO_ID"

        cmb_subgrupo.DataSource = ds_combos.Tables(8)
        cmb_subgrupo.DisplayMember = "SG_DESCRIPCION"
        cmb_subgrupo.ValueMember = "SG_ID"

        cmb_tip_pago.DataSource = ds_combos.Tables(9)
        cmb_tip_pago.DisplayMember = "TP_DESCRIPCION"
        cmb_tip_pago.ValueMember = "TP_ID"

        cmb_ubicacion.DataSource = ds_combos.Tables(10)
        cmb_ubicacion.DisplayMember = "UB_DESCRIPCION"
        cmb_ubicacion.ValueMember = "UB_ID"

        cmb_uso.DataSource = ds_combos.Tables(11)
        cmb_uso.DisplayMember = "US_DESCRIPCION"
        cmb_uso.ValueMember = "US_ID"

        cmb_moneda.DataSource = ds_combos.Tables(12)
        cmb_moneda.DisplayMember = "MO_ABRE"
        cmb_moneda.ValueMember = "MO_CODIGO"

        cmb_prove.DataSource = ds_combos.Tables(13)
        cmb_prove.DisplayMember = "NAME"
        cmb_prove.ValueMember = "ID"

        cmb_tdoc.DataSource = ds_combos.Tables(14)
        cmb_tdoc.DisplayMember = "NAME"
        cmb_tdoc.ValueMember = "TYPE_ID"

        cmb_responsable.DataSource = ds_combos.Tables(15)
        cmb_responsable.DisplayMember = "RA_DESCRIPCION"
        cmb_responsable.ValueMember = "RA_ID"

        cmb_origen_req.DataSource = ds_combos.Tables(16)
        cmb_origen_req.DisplayMember = "OR_DESCRIPCION"
        cmb_origen_req.ValueMember = "OR_ID"

        ds_combos = Nothing

    End Sub

    Private Sub Cargar_Lista()
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        dt_lista = activoBL.get_Listado_01()
        activoBL = Nothing
        dgv_Lista.DataSource = dt_lista
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        flag_familia = True
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Nuevo()
        If cmb_origen_req.Items.Count > 0 Then cmb_origen_req.SelectedIndex = 0
        If cmb_grupo.Items.Count > 0 Then cmb_grupo.SelectedIndex = 0
        If cmb_subgrupo.Items.Count > 0 Then cmb_subgrupo.SelectedIndex = 0
        If cmb_marca.Items.Count > 0 Then cmb_marca.SelectedIndex = 0
        If cmb_tip_pago.Items.Count > 0 Then cmb_tip_pago.SelectedIndex = 0
        If cmb_ubicacion.Items.Count >= 0 Then cmb_ubicacion.SelectedIndex = 0
        If cmb_cc.Items.Count > 0 Then cmb_cc.SelectedIndex = 0
        If cmb_area.Items.Count > 0 Then cmb_area.SelectedIndex = 0
        If cmb_clase.Items.Count > 0 Then cmb_clase.SelectedIndex = 0
        If cmb_uso.Items.Count > 0 Then cmb_uso.SelectedIndex = 0
        If cmb_nivel_obs.Items.Count > 0 Then cmb_nivel_obs.SelectedIndex = 0
        If cmb_est_fis.Items.Count > 0 Then cmb_est_fis.SelectedIndex = 0

    End Sub

    Private Sub Nuevo()
        bol_nuevo = True
        tc_mante_activo.SelectedIndex = 1

        Limpiar_Controles(gb_principal)
        Limpiar_Controles(gb_leasing)
        Limpiar_Controles(gb_mante)
        Limpiar_Controles(gb_otros)
        txt_obs.Text = String.Empty

        mtb_idoc.Text = "0.00"
        txt_tc.Text = "0.000"
        txt_valor_residual.Text = "0.00"
        cmb_moneda.SelectedIndex = 0

        gb_principal.Enabled = True
        gb_leasing.Enabled = True
        gb_mante.Enabled = True
        gb_otros.Enabled = True

        dgv_ficha_tec.Rows.Clear()
        dgv_img.Rows.Clear()
        pb_img.Image = Nothing

        txt_descripcion.Focus()
    End Sub


    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click


        If txt_descripcion.Text.Trim = "" Then
            MsgBox("Ingrese una descripcion")
            txt_descripcion.Focus()
            Exit Sub
        End If

        If cmb_familia.SelectedIndex = -1 Then
            MsgBox("Seleccione una Familia.")
            cmb_familia.Focus()
            Exit Sub
        End If

        If cmb_moneda.SelectedIndex = -1 Then
            MsgBox("Seleccion una moneda")
            cmb_moneda.Focus()
            Exit Sub
        End If



        Dim activoBE As New ClsEntidades.AF_MA_ACTIVO
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO

        With activoBE
            .AC_IDACTIVO = IIf(bol_nuevo, 0, txt_codigo.Text.Trim)
            If chk_mejora.Checked Then
                .AC_IDACTIVO_REF = txt_idactivo_principal.Text.Trim
            Else
                .AC_IDACTIVO_REF = 0
            End If


            If bol_nuevo Then
                'generamos el codigo alterno del activo en base a un compuesto
                Dim familiaBL As New ClsOperaciones.AF_MA_FAMILIA
                txt_cod_alt.Text = cmb_familia.SelectedValue & "" & cmb_area.SelectedValue & "" & familiaBL.get_num_items_xFamilia(cmb_familia.SelectedValue).ToString.PadLeft(5, "0")
                familiaBL = Nothing
            End If

            .AC_CODIGO_ALT = txt_cod_alt.Text.Trim
            .AC_ACTIVO_DES = txt_descripcion.Text.Trim
            .AC_IDFAMILIA = cmb_familia.SelectedValue

            If Not mtb_fec_compra.MaskFull Then
                .AC_FECHA_COMPRA = String.Empty
            Else
                .AC_FECHA_COMPRA = mtb_fec_compra.Text
            End If

            If Not mtb_fec_ini_ope.MaskFull Then
                .AC_FECHA_INI_OPE = String.Empty
            Else
                .AC_FECHA_INI_OPE = mtb_fec_ini_ope.Text
            End If

            .AC_IDGRUPO = IIf(cmb_grupo.SelectedIndex = -1, "", cmb_grupo.SelectedValue)

            .AC_IDSUB_GRUPO = IIf(cmb_subgrupo.SelectedIndex = -1, "", cmb_subgrupo.SelectedValue)
            .AC_IDMARCA = IIf(cmb_marca.SelectedIndex = -1, "", cmb_marca.SelectedValue)
            .AC_MODELO = txt_modelo.Text.Trim
            .AC_NUMSERIE = txt_serie.Text.Trim
            .AC_NUMPLACA = txt_num_placa.Text.Trim
            .AC_IDPROVE = IIf(cmb_prove.SelectedIndex = -1, "", cmb_prove.SelectedValue)
            .AC_TDOC = IIf(cmb_tdoc.SelectedIndex = -1, "", cmb_tdoc.SelectedValue)
            .AC_SDOC = txt_sdoc.Text.Trim
            .AC_NDOC = txt_ndoc.Text.Trim

            If Not mtb_fdoc.MaskFull Then
                .AC_FDOC = String.Empty
            Else
                .AC_FDOC = mtb_fdoc.Text
            End If

            .AC_MDOC = IIf(Not mtb_idoc.MaskFull, 0, mtb_idoc.Text.Trim)
            .AC_IDMONEDA = cmb_moneda.SelectedValue
            .AC_TCAM = IIf(txt_tc.Text = "", 0, txt_tc.Text.Trim)
            .AC_IDTIPO_PAGO = IIf(cmb_tip_pago.SelectedIndex = -1, "", cmb_tip_pago.SelectedValue)
            .AC_IDESTADO_FISICO = IIf(cmb_est_fis.SelectedIndex = -1, "", cmb_est_fis.SelectedValue)
            .AC_IDCLASE = IIf(cmb_clase.SelectedIndex = -1, "", cmb_clase.SelectedValue)
            .AC_IDUSO = IIf(cmb_uso.SelectedIndex = -1, "", cmb_uso.SelectedValue)
            .AC_IDNIVEL_OBS = IIf(cmb_nivel_obs.SelectedIndex = -1, "", cmb_nivel_obs.SelectedValue)
            .AC_CODIGO_BARRA = txt_cod_barra.Text
            .AC_IDUBICACION = IIf(cmb_ubicacion.SelectedIndex, "", cmb_ubicacion.SelectedValue)
            .AC_IDCENCOS = IIf(cmb_cc.SelectedIndex = -1, "", cmb_cc.SelectedValue)
            .AC_IDAREA = IIf(cmb_area.SelectedIndex = -1, "", cmb_area.SelectedValue)
            .AC_LEA_NUM_CONTRATO = txt_num_con.Text

            If Not mtb_fec_con.MaskFull Then
                .AC_LEA_FECHA_CONTRA = String.Empty
            Else
                .AC_LEA_FECHA_CONTRA = mtb_fec_con.Text
            End If

            If Not mtb_fec_arren.MaskFull Then
                .AC_LEA_FECHA_ARRENDA = String.Empty
            Else
                .AC_LEA_FECHA_ARRENDA = mtb_fec_arren.Text
            End If

            .AC_LEA_NUM_COUTAS = IIf(txt_num_cuotas.Text = String.Empty, 0, Val(txt_num_cuotas.Text))
            .AC_LEA_MONTO_TOTAL = IIf(txt_lea_total.Text = String.Empty, 0, Val(txt_lea_total.Text))
            .AC_ANHOS = IIf(txt_anho.Text = "", 0, Val(txt_anho.Text))
            .AC_MESES = IIf(txt_meses.Text = "", 0, Val(txt_meses.Text))
            .AC_OBSERVACIONES = txt_obs.Text.Trim
            .AC_MESESGARANTIA = IIf(txt_meses_garan.Text.Trim = "", 0, Val(txt_meses_garan.Text))

            If Not mtb_fec_vcto_garan.MaskFull Then
                .AC_FEC_VENCE_GARAN = String.Empty
            Else
                .AC_FEC_VENCE_GARAN = mtb_fec_vcto_garan.Text
            End If

            .AC_NUM_CONTRATO = txt_num_contrato.Text
            .AC_PERIODICIDAD_DIAS = IIf(txt_perioricidad.Text = "", 0, Val(txt_perioricidad.Text.Trim))

            If Not mtb_fec_vcto_con.MaskFull Then
                .AC_FEC_VENCE_CON = String.Empty
            Else
                .AC_FEC_VENCE_CON = mtb_fec_vcto_con.Text
            End If


            .AC_DEPRE_INICIAL = IIf(txt_depre_ini.Text = "", 0, Val(txt_depre_ini.Text))
            .AC_ES_TASA_PARTICULAR = IIf(txt_tasa_parti.Text = "", 0, Val(txt_tasa_parti.Text))
            .AC_USUARIO = LibComunVar.ClsVarComun.USUARIO
            .AC_TERMINAL = Environment.MachineName
            .AC_FECREG = Now
            .AC_ESTADO = 1
            .AC_USUARIO_MOD = LibComunVar.ClsVarComun.USUARIO
            .AC_TERMINAL_MOD = Environment.MachineName
            .AC_FECREG_MOD = Now
            .AC_VALOR_RESIDUAL = IIf(txt_valor_residual.Text = "", 0, Val(txt_valor_residual.Text))
            .AC_NUM_COTIZA = txt_cotizacion.Text.Trim
            .AC_NUM_ORD_COMPRA = txt_orden_compra.Text.Trim
            .AC_AUTORIZA_ADQ = txt_autoriza_adq.Text.Trim
            .AC_IDORIGEN_REQ = IIf(cmb_origen_req.SelectedIndex = -1, "", cmb_origen_req.SelectedValue)
            .AC_IDRESPON_ACTI = IIf(cmb_responsable.SelectedIndex = -1, "", cmb_responsable.SelectedValue)
        End With

        Dim lista_imgs As New List(Of ClsEntidades.AF_MA_ACTIVO_IMG)
        Dim imgBE As ClsEntidades.AF_MA_ACTIVO_IMG


        For i As Integer = 0 To dgv_img.Rows.Count - 1
            imgBE = New ClsEntidades.AF_MA_ACTIVO_IMG
            With imgBE
                .AI_IDACTIVO = IIf(bol_nuevo, 0, txt_codigo.Text.Trim)
                .AI_IMG = Image2Bytes(dgv_img.Rows(i).Cells("col_img").Value)
                .AI_NOM = dgv_img.Rows(i).Cells("col_nom").Value
                .AI_DES = dgv_img.Rows(i).Cells("col_nom").Value
                .AI_SEC = dgv_img.Rows(i).Cells("col_sec").Value
                .AI_FECREG = dgv_img.Rows(i).Cells("col_fec").Value
            End With
            lista_imgs.Add(imgBE)
        Next

        Dim lista_fics As New List(Of ClsEntidades.AF_MA_ACTIVO_FIC)
        Dim fichaBE As ClsEntidades.AF_MA_ACTIVO_FIC


        For i As Integer = 0 To dgv_ficha_tec.Rows.Count - 1
            fichaBE = New ClsEntidades.AF_MA_ACTIVO_FIC
            With fichaBE
                .AF_IDACTIVO = IIf(bol_nuevo, 0, txt_codigo.Text.Trim)
                .AF_SEC = dgv_ficha_tec.Rows(i).Cells("col_dsec").Value
                .AF_ARCHIVO = dgv_ficha_tec.Rows(i).Cells("col_dArc").Value
                .AF_FICHA = dgv_ficha_tec.Rows(i).Cells("col_ddoc").Value
            End With
            lista_fics.Add(fichaBE)
        Next

        If bol_nuevo Then
            activoBL.Insert(activoBE, lista_imgs, lista_fics)
        Else
            activoBL.Update(activoBE, lista_imgs, lista_fics)
        End If

        activoBE = Nothing
        activoBL = Nothing
        Call Cargar_Lista()
        MsgBox("Proceso generado correctamente.", MsgBoxStyle.Information, "Sistemas")

        Call Tool_Cancelar_Click(sender, e)


    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        flag_familia = True
        If dgv_Lista.RowCount = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub

        Call Nuevo()
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)

        bol_nuevo = False
        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        Dim dt_lista As DataTable = activoBL.get_Listado_02(dgv_Lista.CurrentRow.Cells(0).Value)
        activoBL = Nothing

        txt_codigo.Text = dgv_Lista.CurrentRow.Cells(0).Value
        txt_cod_alt.Text = dt_lista.Rows(0)("AC_CODIGO_ALT").ToString

        txt_idactivo_principal.Text = dt_lista.Rows(0)("AC_IDACTIVO_REF").ToString
        If Val(txt_idactivo_principal.Text) > 0 Then
            txt_des_activo_principal.Text = dt_lista.Rows(0)("DESCRIP_ACTIVO_PRIN").ToString
            chk_mejora.Checked = True
        Else
            chk_mejora.Checked = False
        End If

        txt_descripcion.Text = dt_lista.Rows(0)("AC_ACTIVO_DES")
        cmb_familia.SelectedValue = dt_lista.Rows(0)("AC_IDFAMILIA")
        mtb_fec_compra.Text = dt_lista.Rows(0)("AC_FECHA_COMPRA").ToString
        mtb_fec_ini_ope.Text = dt_lista.Rows(0)("AC_FECHA_INI_OPE").ToString
        txt_valor_residual.Text = dt_lista.Rows(0)("AC_VALOR_RESIDUAL")
        cmb_grupo.SelectedValue = dt_lista.Rows(0)("AC_IDGRUPO")
        cmb_subgrupo.SelectedValue = dt_lista.Rows(0)("AC_IDSUB_GRUPO")
        cmb_marca.SelectedValue = dt_lista.Rows(0)("AC_IDMARCA")
        txt_modelo.Text = dt_lista.Rows(0)("AC_MODELO").ToString
        txt_serie.Text = dt_lista.Rows(0)("AC_NUMSERIE").ToString
        txt_num_placa.Text = dt_lista.Rows(0)("AC_NUMPLACA").ToString
        txt_cod_barra.Text = dt_lista.Rows(0)("AC_CODIGO_BARRA").ToString
        cmb_prove.SelectedValue = dt_lista.Rows(0)("AC_IDPROVE")
        cmb_tdoc.SelectedValue = dt_lista.Rows(0)("AC_TDOC")
        txt_sdoc.Text = dt_lista.Rows(0)("AC_SDOC").ToString
        txt_ndoc.Text = dt_lista.Rows(0)("AC_NDOC").ToString
        mtb_fdoc.Text = dt_lista.Rows(0)("AC_FDOC").ToString
        mtb_idoc.Text = dt_lista.Rows(0)("AC_MDOC")
        cmb_moneda.SelectedValue = dt_lista.Rows(0)("AC_IDMONEDA")
        txt_tc.Text = dt_lista.Rows(0)("AC_TCAM")
        cmb_tip_pago.SelectedValue = dt_lista.Rows(0)("AC_IDTIPO_PAGO")
        cmb_ubicacion.SelectedValue = dt_lista.Rows(0)("AC_IDUBICACION")
        cmb_cc.SelectedValue = dt_lista.Rows(0)("AC_IDCENCOS")
        cmb_area.SelectedValue = dt_lista.Rows(0)("AC_IDAREA")
        cmb_clase.SelectedValue = dt_lista.Rows(0)("AC_IDCLASE")
        cmb_uso.SelectedValue = dt_lista.Rows(0)("AC_IDUSO")
        cmb_nivel_obs.SelectedValue = dt_lista.Rows(0)("AC_IDNIVEL_OBS")
        cmb_est_fis.SelectedValue = dt_lista.Rows(0)("AC_IDESTADO_FISICO")

        txt_num_contrato.Text = dt_lista.Rows(0)("AC_LEA_NUM_CONTRATO").ToString
        mtb_fec_con.Text = dt_lista.Rows(0)("AC_LEA_FECHA_CONTRA").ToString
        txt_num_cuotas.Text = dt_lista.Rows(0)("AC_LEA_NUM_COUTAS")
        txt_lea_total.Text = dt_lista.Rows(0)("AC_LEA_MONTO_TOTAL")
        txt_anho.Text = dt_lista.Rows(0)("AC_ANHOS")
        txt_meses.Text = dt_lista.Rows(0)("AC_MESES")
        mtb_fec_arren.Text = dt_lista.Rows(0)("AC_LEA_FECHA_ARRENDA").ToString

        txt_obs.Text = dt_lista.Rows(0)("AC_OBSERVACIONES").ToString

        txt_meses_garan.Text = dt_lista.Rows(0)("AC_MESESGARANTIA")
        mtb_fec_vcto_garan.Text = dt_lista.Rows(0)("AC_FEC_VENCE_GARAN").ToString
        txt_num_con.Text = dt_lista.Rows(0)("AC_NUM_CONTRATO").ToString
        txt_perioricidad.Text = dt_lista.Rows(0)("AC_PERIODICIDAD_DIAS")
        mtb_fec_vcto_con.Text = dt_lista.Rows(0)("AC_FEC_VENCE_CON").ToString
        txt_depre_ini.Text = dt_lista.Rows(0)("AC_DEPRE_INICIAL")
        txt_tasa_parti.Text = dt_lista.Rows(0)("AC_ES_TASA_PARTICULAR")

        txt_cotizacion.Text = dt_lista.Rows(0)("AC_NUM_COTIZA").ToString
        txt_orden_compra.Text = dt_lista.Rows(0)("AC_NUM_ORD_COMPRA").ToString
        txt_autoriza_adq.Text = dt_lista.Rows(0)("AC_AUTORIZA_ADQ").ToString
        cmb_origen_req.SelectedValue = dt_lista.Rows(0)("AC_IDORIGEN_REQ").ToString
        cmb_responsable.SelectedValue = dt_lista.Rows(0)("AC_IDRESPON_ACTI").ToString

        dt_lista.Dispose()



        Dim imgBL As New ClsOperaciones.AF_MA_ACTIVO_IMG
        Dim imgBE As New ClsEntidades.AF_MA_ACTIVO_IMG With {.AI_IDACTIVO = txt_codigo.Text.Trim}
        Dim dt_img As DataTable = imgBL.get_Imgs(imgBE)

        For i As Integer = 0 To dt_img.Rows.Count - 1
            dgv_img.Rows.Add()
            dgv_img.Rows(i).Cells("col_sec").Value = dt_img.Rows(i)("AI_SEC")
            dgv_img.Rows(i).Cells("col_nom").Value = dt_img.Rows(i)("AI_NOM")
            dgv_img.Rows(i).Cells("col_des").Value = dt_img.Rows(i)("AI_DES")
            dgv_img.Rows(i).Cells("col_fec").Value = dt_img.Rows(i)("AI_FECREG")
            dgv_img.Rows(i).Cells("col_img").Value = Bytes2Image(dt_img.Rows(i)("AI_IMG"))
            dgv_img.Update()
        Next

        dt_img = Nothing
        imgBE = Nothing
        imgBL = Nothing


        Dim fichaBL As New ClsOperaciones.AF_MA_ACTIVO_FIC
        Dim dt_fichas As DataTable = fichaBL.get_fichas(txt_codigo.Text.Trim)

        For i As Integer = 0 To dt_fichas.Rows.Count - 1
            dgv_ficha_tec.Rows.Add()
            dgv_ficha_tec.Rows(i).Cells("col_dsec").Value = dt_fichas.Rows(i)("AF_SEC")
            dgv_ficha_tec.Rows(i).Cells("col_dArc").Value = dt_fichas.Rows(i)("AF_ARCHIVO")
            dgv_ficha_tec.Rows(i).Cells("col_ddoc").Value = dt_fichas.Rows(i)("AF_FICHA")
            dgv_ficha_tec.Update()
        Next


        txt_descripcion.Focus()
        tc_mante_activo.SelectedIndex = 1


    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        tc_mante_activo.SelectedIndex = 0
        gb_principal.Enabled = False
        gb_leasing.Enabled = False
        gb_mante.Enabled = False
        gb_otros.Enabled = False
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        MsgBox("No se ha establecido el procedimiento para eliminar activos")
        Exit Sub

        'Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        'activoBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown, txt_valor_residual.KeyDown, txt_tc.KeyDown, txt_tasa_parti.KeyDown, txt_serie.KeyDown, txt_sdoc.KeyDown, txt_perioricidad.KeyDown, txt_num_placa.KeyDown, txt_num_cuotas.KeyDown, txt_num_contrato.KeyDown, txt_num_con.KeyDown, txt_ndoc.KeyDown, txt_modelo.KeyDown, txt_meses_garan.KeyDown, txt_meses.KeyDown, txt_lea_total.KeyDown, txt_descripcion.KeyDown, txt_depre_ini.KeyDown, txt_cod_barra.KeyDown, txt_cod_alt.KeyDown, txt_anho.KeyDown, mtb_idoc.KeyDown, mtb_fec_vcto_garan.KeyDown, mtb_fec_vcto_con.KeyDown, mtb_fec_ini_ope.KeyDown, mtb_fec_con.KeyDown, mtb_fec_compra.KeyDown, mtb_fec_arren.KeyDown, mtb_fdoc.KeyDown, cmb_uso.KeyDown, cmb_ubicacion.KeyDown, cmb_tip_pago.KeyDown, cmb_tdoc.KeyDown, cmb_subgrupo.KeyDown, cmb_prove.KeyDown, cmb_nivel_obs.KeyDown, cmb_moneda.KeyDown, cmb_marca.KeyDown, cmb_grupo.KeyDown, cmb_familia.KeyDown, cmb_est_fis.KeyDown, cmb_clase.KeyDown, cmb_cc.KeyDown, cmb_area.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        dt_lista.DefaultView.RowFilter = "AC_ACTIVO_DES like '%" & txt_filtro.Text.Trim & "%'"
    End Sub

    Private Sub dgv_Lista_DoubleClick(sender As Object, e As EventArgs) Handles dgv_Lista.DoubleClick
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub chk_mejora_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mejora.CheckedChanged
        txt_idactivo_principal.Enabled = chk_mejora.Checked
        txt_des_activo_principal.Enabled = chk_mejora.Checked
    End Sub

    Private Sub txt_idactivo_principal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idactivo_principal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim f As New frm_AF_LT_AyudaActivo
            f.ShowDialog()
            If f.bol_aceptar Then
                txt_idactivo_principal.Text = f.ent_activo.AC_IDACTIVO
                txt_des_activo_principal.Text = f.ent_activo.AC_ACTIVO_DES
            End If
            f = Nothing
        End If
    End Sub

    Private Sub cmb_familia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_familia.SelectedIndexChanged
        If flag_familia = True Then
            Dim familiaBL As New ClsOperaciones.AF_MA_FAMILIA
            Dim familiaid As String
            'cmb_familia.SelectedIndex = 0
            familiaid = cmb_familia.SelectedValue
            txt_tasa.Text = familiaBL.get_tasa_cat(familiaid)
            'txt_cod_alt.Text = cmb_familia.SelectedValue & "" & cmb_area.SelectedValue & "" & familiaBL.get_num_items_xFamilia(cmb_familia.SelectedValue).ToString.PadLeft(5, "0")
            familiaBL = Nothing
        End If
        

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ' Seleccionar la imagen
        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        oFD.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp"
        If oFD.ShowDialog = DialogResult.OK Then
            ' La cantidad de caracteres máximo
            ' (por si el path es demasiado largo)
            Dim i As Integer = 255 'dt.Columns("Nombre").MaxLength
            If i < 0 Then i = 255
            ' El nombre del fichero
            ' Nos quedamos solo con el nombre, sin el path
            Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
            If sNombre.Length > i Then
                ' Si el nombre es más grande de lo permitido, lo cortamos
                sNombre = sNombre.Substring(0, i)
            End If

            'Me.txt_foto.Text = sNombre
            Me.pb_img.Image = Image.FromFile(oFD.FileName)

            dgv_img.Rows.Add()
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_sec").Value = dgv_img.Rows.Count
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_nom").Value = sNombre
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_des").Value = sNombre
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_fec").Value = Now
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_img").Value = Image.FromFile(oFD.FileName)
            dgv_img.Update()

        End If
    End Sub

    Private Sub dgv_img_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_img.CellClick
        Try
            pb_img.Image = dgv_img.CurrentRow.Cells("col_img").Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_img.RowCount = 0 Then Exit Sub
        If dgv_img.CurrentRow Is Nothing Then Exit Sub
        dgv_img.Rows.Remove(dgv_img.CurrentRow)

        For i As Integer = 0 To dgv_img.Rows.Count - 1
            dgv_img.Rows(i).Cells("col_sec").Value = i + 1
        Next
        dgv_img.Update()

    End Sub

  

    Private Sub btn_agregar_fic_Click(sender As Object, e As EventArgs) Handles btn_agregar_fic.Click
        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        'oFD.Filter = "*.*"
        If oFD.ShowDialog = DialogResult.OK Then
            Dim i As Integer = 255
            If i < 0 Then i = 255
            ' El nombre del fichero Nos quedamos solo con el nombre, sin el path
            Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
            If sNombre.Length > i Then sNombre = sNombre.Substring(0, i) ' Si el nombre es más grande de lo permitido, lo cortamos
            Dim tam As Integer
            Dim archivo As IO.FileStream
            archivo = New IO.FileStream(oFD.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            tam = archivo.Length
            Dim imagen(tam) As Byte
            archivo.Read(imagen, 0, tam)
            archivo.Close()


            dgv_ficha_tec.Rows.Add()
            dgv_ficha_tec.Rows(dgv_ficha_tec.Rows.Count - 1).Cells("col_dsec").Value = dgv_ficha_tec.Rows.Count
            dgv_ficha_tec.Rows(dgv_ficha_tec.Rows.Count - 1).Cells("col_dArc").Value = sNombre
            dgv_ficha_tec.Rows(dgv_ficha_tec.Rows.Count - 1).Cells("col_ddoc").Value = imagen
            dgv_ficha_tec.Update()



        End If
    End Sub

    Private Sub btn_ver_doc_Click(sender As Object, e As EventArgs) Handles btn_ver_doc.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim aByte() As Byte = dgv_ficha_tec.CurrentRow.Cells("col_ddoc").Value
            WriteBinaryFile(aByte, dgv_ficha_tec.CurrentRow.Cells("col_dArc").Value)
            Process.Start(dgv_ficha_tec.CurrentRow.Cells("col_dArc").Value)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btn_quitar_doc_Click(sender As Object, e As EventArgs) Handles btn_quitar_doc.Click
        If dgv_ficha_tec.RowCount = 0 Then Exit Sub
        If dgv_ficha_tec.CurrentRow Is Nothing Then Exit Sub
        dgv_ficha_tec.Rows.Remove(dgv_ficha_tec.CurrentRow)

        For i As Integer = 0 To dgv_ficha_tec.Rows.Count - 1
            dgv_ficha_tec.Rows(i).Cells("col_dsec").Value = i + 1
        Next
        dgv_ficha_tec.Update()
    End Sub
End Class