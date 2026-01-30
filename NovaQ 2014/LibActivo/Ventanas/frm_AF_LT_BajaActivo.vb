Imports System.Windows.Forms

Public Class frm_AF_LT_BajaActivo
    Dim bol_nuevo As Boolean = False

    Private Sub frm_AF_LT_BajaActivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Inicializa_Tool(ToolS_Mantenimiento)
        Call Cargar_Datos()
        Call Cargar_Motivos()
        Call Cargar_Documentos()
        Call Cargar_Monedas()
        Call Cargar_Clientes()
    End Sub

    Private Sub Cargar_Datos()
        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO
        dgv_baja.DataSource = bajaBL.get_Bajas()
        bajaBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()
        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO
        cmb_tdoc.DataSource = bajaBL.get_Documentos
        cmb_tdoc.DisplayMember = "NAME"
        cmb_tdoc.ValueMember = "TYPE_ID"
        bajaBL = Nothing
    End Sub

    Private Sub Cargar_Clientes()
        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO
        cmb_cliente.DataSource = bajaBL.get_Clientes
        cmb_cliente.DisplayMember = "NAME"
        cmb_cliente.ValueMember = "ID"
        bajaBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO
        cmb_moneda.DataSource = bajaBL.get_Monedas
        cmb_moneda.DisplayMember = "NAME"
        cmb_moneda.ValueMember = "ID"
        bajaBL = Nothing
    End Sub

    Private Sub Cargar_Motivos()
        Dim motivoBL As New ClsOperaciones.AF_MA_MOTIVO_BAJA
        cmb_motivo.DataSource = motivoBL.get_Motivos_cmb()
        cmb_motivo.DisplayMember = "MB_DESCRIPCION"
        cmb_motivo.ValueMember = "MB_ID"
        motivoBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        tc_baja.SelectedIndex = 1
        Limpiar_Controles(gb_datos)
        gb_datos.Enabled = True
        bol_nuevo = True
        cmb_moneda.SelectedIndex = 0
        txt_idactivo.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If txt_idactivo.Text.Trim = "" Then
            MsgBox("Ingrese activo fijo")
            txt_idactivo.Focus()
            Exit Sub
        End If

        If Not mtb_fec_baja.MaskFull Then
            MsgBox("Ingrese la fecha de baja")
            mtb_fec_baja.Focus()
            Exit Sub
        End If

        Dim bajaBE As New ClsEntidades.AF_PR_BAJA_ACTIVO
        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO

        With bajaBE
            .BA_IDACTIVO = txt_idactivo.Text.Trim
            .BA_FECHA = mtb_fec_baja.Text
            .BA_IDMOTIVO = cmb_motivo.SelectedValue

            If cmb_tdoc.SelectedIndex = -1 Then
                .BA_TIPO_DOC = String.Empty
            Else
                .BA_TIPO_DOC = cmb_tdoc.SelectedValue
            End If

            .BA_SER_DOC = txt_sdoc.Text.Trim
            .BA_NUM_DOC = txt_ndoc.Text.Trim

            If mtb_idoc.Text.Trim = "" Then
                .BA_PRECIO_VENTA = 0
            Else
                .BA_PRECIO_VENTA = mtb_idoc.Text
            End If

            .BA_IDMONEDA = cmb_moneda.SelectedValue

            If mtb_fdoc.MaskFull Then
                .BA_FEC_VENTA = mtb_fdoc.Text
            Else
                .BA_FEC_VENTA = String.Empty
            End If

            If cmb_cliente.SelectedIndex = -1 Then
                .BA_IDCLIENTE = String.Empty
            Else
                .BA_IDCLIENTE = cmb_cliente.SelectedValue
            End If

            .BA_OBS = txtobs_det.Text.Trim
        End With

        If bol_nuevo Then
            bajaBL.Insert(bajaBE)
        Else
            bajaBL.Update(bajaBE)
        End If


        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

        MsgBox("Listo!")

        bajaBL = Nothing
        bajaBE = Nothing


    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click

        If dgv_baja.Rows.Count = 0 Then Exit Sub
        If dgv_baja.CurrentRow Is Nothing Then Exit Sub

        Cambiar_Estado_Tool(ToolS_Mantenimiento)

        txt_idactivo.Text = dgv_baja.CurrentRow.Cells("BA_IDACTIVO").Value
        txt_des_activo.Text = dgv_baja.CurrentRow.Cells("AC_ACTIVO_DES").Value
        mtb_fec_baja.Text = dgv_baja.CurrentRow.Cells("BA_FECHA").Value
        cmb_motivo.SelectedValue = dgv_baja.CurrentRow.Cells("BA_IDMOTIVO").Value
        cmb_tdoc.SelectedValue = dgv_baja.CurrentRow.Cells("BA_TIPO_DOC").Value
        txt_sdoc.Text = dgv_baja.CurrentRow.Cells("BA_SER_DOC").Value
        txt_ndoc.Text = dgv_baja.CurrentRow.Cells("BA_NUM_DOC").Value
        mtb_idoc.Text = dgv_baja.CurrentRow.Cells("BA_PRECIO_VENTA").Value
        cmb_moneda.SelectedValue = dgv_baja.CurrentRow.Cells("BA_IDMONEDA").Value
        mtb_fdoc.Text = dgv_baja.CurrentRow.Cells("BA_FEC_VENTA").Value.ToString
        txtobs_det.Text = dgv_baja.CurrentRow.Cells("BA_OBS").Value.ToString
        cmb_cliente.SelectedValue = dgv_baja.CurrentRow.Cells("BA_IDCLIENTE").Value.ToString
        tc_baja.SelectedIndex = 1
        gb_datos.Enabled = True
        bol_nuevo = False
        mtb_fec_baja.Focus()



    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_baja.SelectedIndex = 0
        Cambiar_Estado_Tool(ToolS_Mantenimiento)
        gb_datos.Enabled = False
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_baja.Rows.Count = 0 Then Exit Sub
        If dgv_baja.CurrentRow Is Nothing Then Exit Sub

        Dim bajaBL As New ClsOperaciones.AF_PR_BAJA_ACTIVO
        Dim bajaBE As New ClsEntidades.AF_PR_BAJA_ACTIVO
        bajaBE.BA_IDACTIVO = dgv_baja.CurrentRow.Cells("BA_IDACTIVO").Value
        bajaBL.Delete(bajaBE)
        MsgBox("Listo!")

        bajaBE = Nothing
        bajaBL = Nothing

        Call Cargar_Datos()

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub txt_idactivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idactivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim f As New frm_AF_LT_AyudaActivo
            f.ShowDialog()
            If f.bol_aceptar Then
                txt_idactivo.Text = f.ent_activo.AC_IDACTIVO
                txt_des_activo.Text = f.ent_activo.AC_ACTIVO_DES
                mtb_fec_baja.Focus()
            End If
            f = Nothing
        End If
    End Sub

    Private Sub mtb_fec_baja_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_baja.KeyDown, txt_sdoc.KeyDown, txt_ndoc.KeyDown, mtb_idoc.KeyDown, mtb_fdoc.KeyDown, cmb_tdoc.KeyDown, cmb_motivo.KeyDown, cmb_moneda.KeyDown, cmb_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class