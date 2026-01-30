Imports System.Windows.Forms

Public Class frm_AF_MA_Familia

    Dim bol_nuevo As Boolean = False
    Dim flag_familia As Boolean

    Private Sub frm_AF_MA_Familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        flag_familia = False
        Call Cargar_Lista()
        Call Carga_Categorias()
        Call Cargar_Cuentas()
        Call Inicializa_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Cargar_Cuentas()

        Dim familiaBL As New ClsOperaciones.AF_MA_FAMILIA
        Dim dt_tmp1 As DataTable = familiaBL.get_ctas_contables(LibComunVar.ClsVarComun.FechaSistema.Year)
        Dim dt_tmp2 As DataTable = familiaBL.get_ctas_contables(LibComunVar.ClsVarComun.FechaSistema.Year)
        Dim dt_tmp3 As DataTable = familiaBL.get_ctas_contables(LibComunVar.ClsVarComun.FechaSistema.Year)

        cmb_cta_activo.DataSource = dt_tmp1
        cmb_cta_activo.DisplayMember = "PC_DES_CTA"
        cmb_cta_activo.ValueMember = "PC_NUM_CTA"

        cmb_cta_depre.DataSource = dt_tmp2
        cmb_cta_depre.DisplayMember = "PC_DES_CTA"
        cmb_cta_depre.ValueMember = "PC_NUM_CTA"

        cmb_cta_gasto.DataSource = dt_tmp3
        cmb_cta_gasto.DisplayMember = "PC_DES_CTA"
        cmb_cta_gasto.ValueMember = "PC_NUM_CTA"

        familiaBL = Nothing

    End Sub

    Private Sub Cargar_Lista()
        Dim familiaBL As New ClsOperaciones.AF_MA_FAMILIA
        Dim dt_tmp As DataTable = familiaBL.get_familia_01
        dgv_familia.DataSource = dt_tmp
        familiaBL = Nothing
    End Sub

    Private Sub Carga_Categorias()
        Dim categoriaBL As New ClsOperaciones.AF_MA_CATEGORIA
        cmb_cat.DataSource = categoriaBL.get_Categoria_01()
        cmb_cat.DisplayMember = "CA_DESCRIPCION"
        cmb_cat.ValueMember = "CA_ID"
        categoriaBL = Nothing
    End Sub

    Private Sub Cargar_Cuentas_cc(cuenta_ As String)
        Dim cta_ccBE As New ClsEntidades.AF_MA_FAMI_CTA_CC
        Dim cta_ccBL As New ClsOperaciones.AF_MA_FAMI_CTA_CC
        Dim dt_cuentas As DataTable = Nothing
        cta_ccBE.FC_IDFAMILIA = cuenta_
        dt_cuentas = cta_ccBL.get_Cuentas(cta_ccBE)
        dgv_cuentas_cc.DataSource = dt_cuentas
        cta_ccBE = Nothing
        cta_ccBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        flag_familia = True
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        cmb_metodo.SelectedIndex = 0
        tc_familia.SelectedIndex = 1
        Limpiar_Controles(gb_datos)
        chk_estado.Checked = True
        gb_datos.Enabled = True
        gb_cuentas.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
        txt_cod.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If txt_cod.Text.Trim.Length = 0 Then
            MsgBox("Ingrese codigo")
            txt_cod.Focus()
            Exit Sub
        End If

        If cmb_cat.SelectedIndex = -1 Then
            MsgBox("Seleccione una familia")
            cmb_cat.Focus()
            Exit Sub
        End If




        Dim familiaBE As New ClsEntidades.AF_MA_FAMILIA
        Dim familiaBL As New ClsOperaciones.AF_MA_FAMILIA

        With familiaBE
            .FA_ID = txt_cod.Text.Trim
            .FA_DESCRIPCION = txt_des.Text.Trim
            .FA_IDMETODO = "01"
            .FA_IDCATEGORIA = cmb_cat.SelectedValue
            .FA_CUENTA_DEPRE = txt_cta_depre.Text.Trim
            .FA_CUENTA_ACTIVO = txt_cta_activo.Text.Trim
            .FA_CUENTA_GASTO = txt_cta_gasto.Text.Trim
            .FA_ESTADO = IIf(chk_estado.Checked, 1, 0)
        End With

        If bol_nuevo Then
            familiaBL.Insert(familiaBE)
        Else
            familiaBL.Update(familiaBE)
        End If

        MsgBox("Listo!")

        familiaBE = Nothing
        familiaBL = Nothing

        Call Cargar_Lista()
        Tool_Cancelar_Click(sender, e)
    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        flag_familia = True
        If dgv_familia.RowCount = 0 Then Exit Sub
        If dgv_familia.CurrentRow Is Nothing Then Exit Sub

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        bol_nuevo = False
        txt_cod.Text = dgv_familia.CurrentRow.Cells("FA_ID").Value
        txt_des.Text = dgv_familia.CurrentRow.Cells("FA_DESCRIPCION").Value
        cmb_metodo.SelectedIndex = 0
        'txt_metodo.Text = dgv_familia.CurrentRow.Cells("FA_IDMETODO").Value
        cmb_cat.SelectedValue = dgv_familia.CurrentRow.Cells("FA_IDCATEGORIA").Value
        txt_cta_depre.Text = dgv_familia.CurrentRow.Cells("FA_CUENTA_DEPRE").Value
        cmb_cta_depre.SelectedValue = txt_cta_depre.Text
        txt_cta_activo.Text = dgv_familia.CurrentRow.Cells("FA_CUENTA_ACTIVO").Value
        cmb_cta_activo.SelectedValue = txt_cta_activo.Text
        txt_cta_gasto.Text = dgv_familia.CurrentRow.Cells("FA_CUENTA_GASTO").Value
        cmb_cta_gasto.SelectedValue = txt_cta_gasto.Text
        chk_estado.Checked = IIf(dgv_familia.CurrentRow.Cells("FA_ESTADO").Value = 1, True, False)

        tc_familia.SelectedIndex = 1

        Call Cargar_Cuentas_cc(txt_cod.Text.Trim)

        gb_datos.Enabled = True
        gb_cuentas.Enabled = True
        txt_cod.Enabled = False
        txt_des.Focus()


    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_familia.SelectedIndex = 0
        gb_datos.Enabled = False
        gb_cuentas.Enabled = False
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub cmb_cta_depre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cta_depre.SelectedIndexChanged
        If flag_familia = True Then
            txt_cta_depre.Text = cmb_cta_depre.SelectedValue
        End If

    End Sub

    Private Sub cmb_cta_activo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cta_activo.SelectedIndexChanged
        If flag_familia = True Then
            txt_cta_activo.Text = cmb_cta_activo.SelectedValue
        End If

    End Sub

    Private Sub cmb_cta_gasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cta_gasto.SelectedIndexChanged
        If flag_familia = True Then
            txt_cta_gasto.Text = cmb_cta_gasto.SelectedValue
        End If

    End Sub

    Private Sub cmb_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cat.SelectedIndexChanged
        If flag_familia = True Then
            Dim categoriBL As New ClsOperaciones.AF_MA_CATEGORIA
            txt_tasa.Text = categoriBL.get_Tasa_x_IdCat(cmb_cat.SelectedValue)
            categoriBL = Nothing
        End If

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If txt_cta_cc.Text.Trim = "" Then
            MsgBox("Ingrese cuenta Centro de Costo")
            txt_cta_cc.Focus()
            Exit Sub
        End If

        If txt_porce.Text.Trim = "" Then
            MsgBox("Ingrese Porcentaje para el Centro de Costo")
            txt_porce.Focus()
            Exit Sub
        End If

        If Val(txt_porce.Text) <= 0 Then
            MsgBox("El valor del porcentaje tiene que ser mayor a cero")
            txt_porce.Focus()
            Exit Sub
        End If


        Dim cuentaBE As New ClsEntidades.AF_MA_FAMI_CTA_CC
        Dim cuentaBL As New ClsOperaciones.AF_MA_FAMI_CTA_CC

        With cuentaBE
            .FC_IDFAMILIA = txt_cod.Text.Trim
            .FC_NUM_CUENTA = txt_cta_cc.Text.Trim
            .FC_PORCE = txt_porce.Text.Trim
        End With

        cuentaBL.Insert(cuentaBE)

        cuentaBE = Nothing
        cuentaBL = Nothing

        MsgBox("Listo!")

        txt_cta_cc.Clear()
        txt_porce.Clear()

        Call Cargar_Cuentas_cc(txt_cod.Text.Trim)


    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click

        If dgv_cuentas_cc.RowCount = 0 Then Exit Sub
        If dgv_cuentas_cc.CurrentRow Is Nothing Then Exit Sub

        Dim cuentaBE As New ClsEntidades.AF_MA_FAMI_CTA_CC
        Dim cuentaBL As New ClsOperaciones.AF_MA_FAMI_CTA_CC

        With cuentaBE
            .FC_IDFAMILIA = txt_cod.Text.Trim
            .FC_NUM_CUENTA = dgv_cuentas_cc.CurrentRow.Cells("FC_NUM_CUENTA").Value.ToString
        End With

        cuentaBL.Delete(cuentaBE)

        cuentaBE = Nothing
        cuentaBL = Nothing

        MsgBox("Listo!")

        Call Cargar_Cuentas_cc(txt_cod.Text.Trim)

    End Sub

    Private Sub txt_cta_depre_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_depre.MouseDoubleClick
        Ayuda_CuentaContable(txt_cta_depre)
    End Sub

    Private Sub Ayuda_CuentaContable(ByVal Caja_Texto As TextBox)
        Try

            Dim frm As New LibContabilidad.FrmBuscar_CuentaContable
            Dim sql As String = String.Empty
            sql = "CO_SP_S_PLANCTAS_MOV"
            frm.CadenaConsulta = sql
            frm.Titulo = "Plan de Cuentas Contable"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                Caja_Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                frm.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cta_activo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_activo.MouseDoubleClick
        Ayuda_CuentaContable(txt_cta_activo)
    End Sub

    Private Sub txt_cta_gasto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_gasto.MouseDoubleClick
        Ayuda_CuentaContable(txt_cta_gasto)
    End Sub

    Private Sub txt_cta_gasto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_gasto.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentaContable(txt_cta_gasto)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cta_gasto.Text = "" Then
                Ayuda_CuentaContable(txt_cta_gasto)
            Else
                Tool_Grabar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_cta_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_activo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentaContable(txt_cta_activo)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cta_activo.Text = "" Then
                Ayuda_CuentaContable(txt_cta_activo)
            Else
                txt_cta_gasto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cta_depre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_depre.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentaContable(txt_cta_depre)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cta_depre.Text = "" Then
                Ayuda_CuentaContable(txt_cta_depre)
            Else
                txt_cta_activo.Focus()
            End If
        End If
    End Sub
End Class