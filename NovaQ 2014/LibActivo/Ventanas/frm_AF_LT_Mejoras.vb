Imports System.Windows.Forms

Public Class frm_AF_LT_Mejoras

    Public bol_nuevo As Boolean = False
    Dim dt_lista As DataTable

    Private Sub frm_AF_LT_Mejoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Call Cargar_Combos()
        Call Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Public Sub Cargar_Datos()
        Dim mejorasBL As New ClsOperaciones.AF_PR_ACTIVO_MEJORA
        dt_lista = mejorasBL.get_Mejoras_Lista_todos()
        dgv_Lista_Mejoras.DataSource = dt_lista
        mejorasBL = Nothing
    End Sub

    Private Sub Cargar_Combos()
        Dim mejorasBL As New ClsOperaciones.AF_PR_ACTIVO_MEJORA
        Dim ds_tmp As DataSet = mejorasBL.get_Data_cmbs()

        cmb_prove.DataSource = ds_tmp.Tables(0)
        cmb_prove.DisplayMember = "NAME"
        cmb_prove.ValueMember = "ID"

        cmb_moneda.DataSource = ds_tmp.Tables(1)
        cmb_moneda.DisplayMember = "MO_ABRE"
        cmb_moneda.ValueMember = "MO_CODIGO"

        cmb_tip_pago.DataSource = ds_tmp.Tables(2)
        cmb_tip_pago.DisplayMember = "TP_DESCRIPCION"
        cmb_tip_pago.ValueMember = "TP_ID"

        cmb_tdoc.DataSource = ds_tmp.Tables(3)
        cmb_tdoc.DisplayMember = "NAME"
        cmb_tdoc.ValueMember = "TYPE_ID"

        ds_tmp = Nothing


    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles(gb_datos)
        tc_mejoras.SelectedIndex = 1

        txt_sec.Text = "0"
        mtb_tasa.Text = "0.00"
        mtb_idoc.Text = "0.00"
        txt_tc.Text = "0.000"

        btn_buscar.Focus()
        bol_nuevo = True
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text.Trim = "" Then
            MsgBox("Ingrese el codigo del activo")
            btn_buscar.Focus()
            Exit Sub
        End If

        If txt_ref.Text.Trim = "" Then
            MsgBox("Ingrese la referencia de la mejora")
            txt_ref.Focus()
            Exit Sub
        End If

        Dim mejorasBL As New ClsOperaciones.AF_PR_ACTIVO_MEJORA
        Dim mejorasBE As New ClsEntidades.AF_PR_ACTIVO_MEJORA

        With mejorasBE
            .AM_IDACTIVO = txt_codigo.Text.Trim
            .AM_SEC = txt_sec.Text.Trim
            .AM_REF = txt_ref.Text.Trim
            .AM_IDPROVE = IIf(cmb_prove.SelectedIndex = -1, "", cmb_prove.SelectedValue)
            .AM_TDOC = IIf(cmb_tdoc.SelectedIndex = -1, "", cmb_tdoc.SelectedValue)
            .AM_SDOC = txt_sdoc.Text.Trim
            .AM_NDOC = txt_ndoc.Text.Trim

            If mtb_fdoc.MaskFull Then
                .AM_FDOC = mtb_fdoc.Text
            Else
                .AM_FDOC = String.Empty
            End If

            .AM_MDOC = mtb_idoc.Text
            .AM_IDMONEDA = IIf(cmb_moneda.SelectedIndex = -1, "", cmb_moneda.SelectedValue)
            .AM_TCAM = txt_tc.Text
            .AM_IDTIPO_PAGO = IIf(cmb_tip_pago.SelectedIndex = -1, "", cmb_tip_pago.SelectedValue)
            .AM_OBS = txt_obs.Text.Trim
            .AM_TASA = mtb_tasa.Text
            .AM_FEC_REG = Now
            .AM_USUARIO = LibComunVar.ClsVarComun.USUARIO
            .AM_TERMINAL = Environment.MachineName
        End With

        If bol_nuevo Then
            mejorasBL.Insert(mejorasBE)
        Else
            mejorasBL.Update(mejorasBE)
        End If

        MsgBox("Listo!")

        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click

        If dgv_Lista_Mejoras.Rows.Count = 0 Then Exit Sub
        If dgv_Lista_Mejoras.CurrentRow Is Nothing Then Exit Sub

        Dim mejoraBL As New ClsOperaciones.AF_PR_ACTIVO_MEJORA
        Dim mejoraBE As New ClsEntidades.AF_PR_ACTIVO_MEJORA
        mejoraBE.AM_SEC = dgv_Lista_Mejoras.CurrentRow.Cells("SEC").Value
        mejoraBE.AM_IDACTIVO = dgv_Lista_Mejoras.CurrentRow.Cells("CODIGO").Value
        Dim dt_tmp As DataTable = mejoraBL.get_Mejoras_x_Cod(mejoraBE)

        With dt_tmp.Rows(0)
            txt_codigo.Text = .Item("AM_IDACTIVO")
            txt_cod_alt.Text = .Item("AC_CODIGO_ALT")
            txt_descripcion.Text = .Item("AC_ACTIVO_DES")
            txt_sec.Text = .Item("AM_SEC")
            txt_ref.Text = .Item("AM_REF")
            txt_obs.Text = .Item("AM_OBS")
            cmb_prove.SelectedValue = .Item("AM_IDPROVE")
            cmb_tdoc.SelectedValue = .Item("AM_TDOC")
            txt_sdoc.Text = .Item("AM_SDOC")
            txt_ndoc.Text = .Item("AM_NDOC")
            mtb_fdoc.Text = .Item("AM_FDOC").ToString
            mtb_idoc.Text = .Item("AM_MDOC").ToString
            cmb_moneda.SelectedValue = .Item("AM_IDMONEDA")
            txt_tc.Text = .Item("AM_TCAM")
            cmb_tip_pago.SelectedValue = .Item("AM_IDTIPO_PAGO")
            mtb_tasa.Text = .Item("AM_TASA")
        End With

        dt_tmp = Nothing
        mejoraBE = Nothing
        mejoraBL = Nothing

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)

        tc_mejoras.SelectedIndex = 1
        bol_nuevo = False
        txt_ref.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_mejoras.SelectedIndex = 0
        Call Limpiar_Controles(gb_datos)
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click

        If dgv_Lista_Mejoras.Rows.Count = 0 Then Exit Sub
        If dgv_Lista_Mejoras.CurrentRow Is Nothing Then Exit Sub

        Dim mejoraBL As New ClsOperaciones.AF_PR_ACTIVO_MEJORA
        Dim mejoraBE As New ClsEntidades.AF_PR_ACTIVO_MEJORA

        mejoraBE.AM_IDACTIVO = dgv_Lista_Mejoras.CurrentRow.Cells("CODIGO").Value
        mejoraBE.AM_SEC = dgv_Lista_Mejoras.CurrentRow.Cells("SEC").Value
        mejoraBL.Delete(mejoraBE)

        MsgBox("Listo!")
        Call Cargar_Datos()
        mejoraBE = Nothing
        mejoraBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim f As New frm_AF_LT_AyudaActivo
        f.ShowDialog()
        If f.bol_aceptar Then

            txt_codigo.Text = f.ent_activo.AC_IDACTIVO
            txt_descripcion.Text = f.ent_activo.AC_ACTIVO_DES
            txt_cod_alt.Text = f.ent_activo.AC_CODIGO_ALT
            txt_ref.Focus()
        End If
        f = Nothing
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged
        Call Filtrar()

    End Sub

    Private Sub Filtrar()
        Try
            If txt_filtro.Text.Trim = "" Then
                dt_lista.DefaultView.RowFilter = Nothing
            End If

            If chk_comienza.Checked Then
                dt_lista.DefaultView.RowFilter = "ACTIVO like '" & txt_filtro.Text.Trim & "%'"
            Else
                dt_lista.DefaultView.RowFilter = "ACTIVO like '%" & txt_filtro.Text.Trim & "%'"
            End If

        Catch ex As Exception
            'dgv_ayuda.DataSource = dt_data.DefaultView.RowFilter = Nothing
        End Try

    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ref_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ref.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_obs_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obs.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_prove_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_prove.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_tdoc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tdoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_sdoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sdoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ndoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ndoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub mtb_fdoc_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fdoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub mtb_idoc_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_idoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub mtb_tasa_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_tasa.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_tc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_tip_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tip_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub chk_comienza_CheckedChanged(sender As Object, e As EventArgs) Handles chk_comienza.CheckedChanged
        Call Filtrar()
    End Sub
End Class