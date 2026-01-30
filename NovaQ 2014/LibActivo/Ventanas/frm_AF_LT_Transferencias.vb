Imports System.Windows.Forms

Public Class frm_AF_LT_Transferencias

    Dim bol_nuevo As Boolean = False

    Private Sub frm_AF_LT_Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Call Cargar_Areas()
        Call Cagar_Responsables()
        Call Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Datos()
        Dim transferenciaBL As New ClsOperaciones.AF_PR_TRANSFE_C
        dgv_lista_trans.DataSource = transferenciaBL.get_Transferencias()
        transferenciaBL = Nothing
    End Sub

    Private Sub Cagar_Responsables()
        Dim responsableBL As New ClsOperaciones.AF_MA_RESPO_ACTI
        cmb_respo_activo.DataSource = responsableBL.get_responsables_cmb
        cmb_respo_activo.DisplayMember = "RA_DESCRIPCION"
        cmb_respo_activo.ValueMember = "RA_ID"
        responsableBL = Nothing
    End Sub

    Private Sub Cargar_Areas()

        Dim areaBL As New ClsOperaciones.AF_MA_AREA
        cmb_ori.DataSource = areaBL.get_areas_cmb()
        cmb_ori.DisplayMember = "AR_DESCRIPCION"
        cmb_ori.ValueMember = "AR_ID"

        cmb_des.DataSource = areaBL.get_areas_cmb()
        cmb_des.DisplayMember = "AR_DESCRIPCION"
        cmb_des.ValueMember = "AR_ID"

        areaBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim f As New frm_AF_LT_AyudaActivo
        f.ShowDialog()
        If f.bol_aceptar Then
            dgv_lista.Rows.Add()
            dgv_lista.Rows(dgv_lista.Rows.Count - 1).Cells(0).Value = f.ent_activo.AC_IDACTIVO
            dgv_lista.Rows(dgv_lista.Rows.Count - 1).Cells(1).Value = f.ent_activo.AC_ACTIVO_DES
            dgv_lista.Update()
        End If
        f = Nothing
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        dgv_lista.Rows.Remove(dgv_lista.CurrentRow)
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If dgv_lista.Rows.Count = 0 Then
            MsgBox("Ingrese activos a la lista para continuar.")
            btn_agregar.Focus()
            Exit Sub
        End If

        If Not mtb_fec.MaskFull Then
            MsgBox("Ingrese la fecha de la transferencia")
            mtb_fec.Focus()
            Exit Sub
        End If

        If cmb_ori.SelectedIndex = -1 Then
            MsgBox("Seleccione un area de origen para continuar")
            cmb_ori.Focus()
            Exit Sub
        End If

        If cmb_des.SelectedIndex = -1 Then
            MsgBox("Seleccione un area de origen para continuar")
            cmb_ori.Focus()
            Exit Sub
        End If

        Dim e_transCabBE As New ClsEntidades.AF_PR_TRANSFE_C
        With e_transCabBE
            If bol_nuevo Then
                .TR_IDFOLIO = 0
            Else
                .TR_IDFOLIO = txt_id.Text.Trim
            End If

            .TR_FECHA_TR = mtb_fec.Text
            .TR_IDAREA_ORI = cmb_ori.SelectedValue
            .TR_IDAREA_DES = cmb_des.SelectedValue
            .TR_OBS = txt_obs.Text.Trim
            .TR_USUARIO = LibComunVar.ClsVarComun.USUARIO
            .TR_TERMINAL = Environment.MachineName
            .TR_FECREG = Now
            .TR_IDRESPO_ACTI = cmb_respo_activo.SelectedValue
        End With

        Dim e_transDetBE As ClsEntidades.AF_PR_TRANSFE_D
        Dim lista_det As New List(Of ClsEntidades.AF_PR_TRANSFE_D)

        For i As Integer = 0 To dgv_lista.Rows.Count - 1
            e_transDetBE = New ClsEntidades.AF_PR_TRANSFE_D
            e_transDetBE.TD_IDFOLIO = 0
            e_transDetBE.TD_IDACTIVO = dgv_lista.Rows(i).Cells(0).Value
            lista_det.Add(e_transDetBE)
        Next

        Dim transferenciaBL As New ClsOperaciones.AF_PR_TRANSFE_C
        Dim numFolioRet As Integer = 0

        If bol_nuevo Then
            transferenciaBL.insert(e_transCabBE, lista_det, numFolioRet)
        Else
            transferenciaBL.Update(e_transCabBE, lista_det)
            numFolioRet = e_transCabBE.TR_IDFOLIO
        End If

        txt_id.Text = numFolioRet

        MsgBox("Listo!" & Chr(13) & "Numero de Folio :" & numFolioRet.ToString)

        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)
        gb_cab.Enabled = False

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        gb_cab.Enabled = True

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        txt_obs.Text = ""
        txt_id.Text = ""

        dgv_lista.Rows.Clear()
        tc_trans.SelectedIndex = 1
        mtb_fec.Focus()
        bol_nuevo = True
    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_trans.SelectedIndex = 0
        gb_cab.Enabled = False
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub mtb_fec_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_ori.Focus()
        End If
    End Sub

    Private Sub cmb_ori_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ori.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_des.Focus()
        End If
    End Sub

    Private Sub cmb_des_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs.Focus()
        End If
    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click

        If dgv_lista_trans.CurrentRow Is Nothing Then Exit Sub
        If dgv_lista_trans.RowCount = 0 Then Exit Sub


        Dim transferenciaBL As New ClsOperaciones.AF_PR_TRANSFE_C
        Dim ds_tmp As DataSet
        ds_tmp = transferenciaBL.get_Transferencias_x_numFolio(dgv_lista_trans.CurrentRow.Cells("NUM_FOLIO").Value)


        txt_id.Text = ds_tmp.Tables(0)(0)("TR_IDFOLIO")
        mtb_fec.Text = ds_tmp.Tables(0)(0)("TR_FECHA_TR")
        cmb_ori.SelectedValue = ds_tmp.Tables(0)(0)("TR_IDAREA_ORI")
        cmb_des.SelectedValue = ds_tmp.Tables(0)(0)("TR_IDAREA_DES")
        txt_obs.Text = ds_tmp.Tables(0)(0)("TR_OBS")
        cmb_respo_activo.SelectedValue = ds_tmp.Tables(0)(0)("TR_IDRESPO_ACTI")

        dgv_lista.Rows.Clear()
        For i As Integer = 0 To ds_tmp.Tables(1).Rows.Count - 1
            dgv_lista.Rows.Add()
            dgv_lista.Rows(i).Cells(0).Value = ds_tmp.Tables(1)(i)("TD_IDACTIVO")
            dgv_lista.Rows(i).Cells(1).Value = ds_tmp.Tables(1)(i)("AC_ACTIVO_DES")
            dgv_lista.Update()
        Next

        gb_cab.Enabled = True
        bol_nuevo = False

        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        tc_trans.SelectedIndex = 1
        txt_obs.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        MsgBox("En proceso")
    End Sub
End Class