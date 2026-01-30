Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_AF_LT_TomaInventario
    Dim bol_nuevo As Boolean = False

    Private Sub frm_AF_LT_TomaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Estados()
        Call Cargar_Responsables()
        Call Cargar_Combos()
    End Sub

    Private Sub Cargar_Combos()

        Dim inventarioBl As New ClsOperaciones.AF_LT_TOMA_INV_C
        Dim ds_tmp As DataSet = inventarioBl.get_Data_Combos()
        inventarioBl = Nothing


        cmb_ubicacion.DataSource = ds_tmp.Tables(0)
        cmb_ubicacion.DisplayMember = "UB_DESCRIPCION"
        cmb_ubicacion.ValueMember = "UB_ID"

        cmb_area.DataSource = ds_tmp.Tables(1)
        cmb_area.DisplayMember = "AR_DESCRIPCION"
        cmb_area.ValueMember = "AR_ID"

        cmb_responsable.DataSource = ds_tmp.Tables(2)
        cmb_responsable.DisplayMember = "RA_DESCRIPCION"
        cmb_responsable.ValueMember = "RA_ID"

        cmb_est_fis.DataSource = ds_tmp.Tables(3)
        cmb_est_fis.DisplayMember = "EF_DESCRIPCION"
        cmb_est_fis.ValueMember = "EF_ID"

        ds_tmp = Nothing

    End Sub

    Private Sub Cargar_Responsables()
        Dim responsableBL As New ClsOperaciones.AF_MA_RESPO_ACTI
        cmb_respo_activo.DataSource = responsableBL.get_responsables_cmb
        cmb_respo_activo.DisplayMember = "RA_DESCRIPCION"
        cmb_respo_activo.ValueMember = "RA_ID"
        responsableBL = Nothing

        cmb_respo_activo.SelectedIndex = -1
    End Sub

    Private Sub Cargar_Estados()
        Dim estadosBL As New ClsOperaciones.AF_LT_ESTADO_INV
        cmb_estado.DataSource = estadosBL.get_Estados()
        cmb_estado.DisplayMember = "EI_DES"
        cmb_estado.ValueMember = "EI_ID"
        estadosBL = Nothing
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If cmb_respo_activo.SelectedIndex = -1 Then
            MsgBox("Seleccione un responsable del inventario")
            cmb_respo_activo.Focus()
            Exit Sub
        End If


        Dim inventarioBE As New ClsEntidades.AF_LT_TOMA_INV_C
        With inventarioBE
            If bol_nuevo Then
                .TI_ID = 0
            Else
                .TI_ID = txt_num_inv.Text.Trim
            End If
            .TI_FECHA = dtp_fecha.Value
            .TI_OBS = txt_obs.Text.Trim
            .TI_ESTADO = cmb_estado.SelectedValue
            .TI_TERMINAL = Environment.MachineName
            .TI_USUARIO = LibComunVar.ClsVarComun.USUARIO
            .TI_FECREG = Now
            .TI_FECHA_FIN = dtp_fec_fin.Value
            .TI_IDRESPONSABLE = cmb_respo_activo.SelectedValue
        End With

        If bol_nuevo Then Call Cargar_Activos()

        'luego grabamos en la BD todo(cab y Det)
        Dim inventarioBL As New ClsOperaciones.AF_LT_TOMA_INV_C
        Dim lista As New List(Of ClsEntidades.AF_LT_TOMA_INV_D)
        Dim detalle As ClsEntidades.AF_LT_TOMA_INV_D


        For i As Integer = 0 To dgv_detalle.Rows.Count - 1
            detalle = New ClsEntidades.AF_LT_TOMA_INV_D

            If bol_nuevo Then
                detalle.TD_IDCAB = 0
            Else
                detalle.TD_IDCAB = txt_num_inv.Text.Trim
            End If

            detalle.TD_IDACTIVO = dgv_detalle.Rows(i).Cells("col_idactivo").Value
            detalle.TD_ESTADO_INV = IIf(dgv_detalle.Rows(i).Cells("col_si").Value, 1, 0)

            If dgv_detalle.Rows(i).Cells("col_ubi").Value Is Nothing Then
                detalle.TD_IDUBICACION = String.Empty
            Else
                detalle.TD_IDUBICACION = dgv_detalle.Rows(i).Cells("col_ubi").Value
            End If

            If dgv_detalle.Rows(i).Cells("col_area").Value Is Nothing Then
                detalle.TD_IDAREA = String.Empty
            Else
                detalle.TD_IDAREA = dgv_detalle.Rows(i).Cells("col_area").Value
            End If

            If dgv_detalle.Rows(i).Cells("col_estado").Value Is Nothing Then
                detalle.TD_IDEST_FIS = String.Empty
            Else
                detalle.TD_IDEST_FIS = dgv_detalle.Rows(i).Cells("col_estado").Value
            End If

            If dgv_detalle.Rows(i).Cells("col_asig").Value Is Nothing Then
                detalle.TD_IDRESPO = String.Empty
            Else
                detalle.TD_IDRESPO = dgv_detalle.Rows(i).Cells("col_asig").Value
            End If

            If dgv_detalle.Rows(i).Cells("col_img").Value Is Nothing Then
                detalle.TD_IDIMG = Nothing
            Else
                detalle.TD_IDIMG = Image2Bytes(dgv_detalle.Rows(i).Cells("col_img").Value)
            End If


            If dgv_detalle.Rows(i).Cells("col_comen").Value Is Nothing Then
                detalle.TD_COMENTARIOS = String.Empty
            Else
                detalle.TD_COMENTARIOS = dgv_detalle.Rows(i).Cells("col_comen").Value
            End If


            lista.Add(detalle)
        Next

        If bol_nuevo Then
            inventarioBL.Insert(inventarioBE, lista)
            txt_num_inv.Text = inventarioBE.TI_ID
            MsgBox("Listo!.... Ya puede comenzar a actualizar el inventario")
            bol_nuevo = False
        Else
            inventarioBL.Update(inventarioBE, lista)

            If chk_cerrar.Checked Then
                inventarioBL.Update_Estado(txt_num_inv.Text.Trim)
                inventarioBL = Nothing
                cmb_estado.SelectedValue = 2
                MsgBox("Listo!..... Inventario Cerrado")
                chk_cerrar.Checked = False
            Else
                MsgBox("Listo!.... Inventario Actualizado")
            End If
            'Call Tool_Nuevo_Click(sender, e)
        End If


    End Sub

    Private Sub Cargar_Activos()

        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        Dim dt_tmp As DataTable = activoBL.get_Lista_07_inventario()


        dgv_detalle.Rows.Clear()
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            dgv_detalle.Rows.Add()
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_idactivo").Value = dt_tmp.Rows(i)("AC_IDACTIVO")
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_desactivo").Value = dt_tmp.Rows(i)("AC_ACTIVO_DES").ToString
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_si").Value = False
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_no").Value = True
        Next
        dgv_detalle.Update()

        dt_tmp = Nothing
        activoBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        If cmb_estado.Items.Count > 0 Then cmb_estado.SelectedIndex = 0
        txt_num_inv.Text = ""
        btn_grabar.Enabled = True
        cmb_respo_activo.SelectedIndex = -1
        dgv_detalle.Rows.Clear()
        txt_obs.Text = ""
        dtp_fecha.Focus()
    End Sub

    Private Sub btn_cargar_inv_Click(sender As Object, e As EventArgs) Handles btn_cargar_inv.Click

        Dim f As New frm_AF_LT_ListaInvs
        f.ShowDialog()
        If f.gint_num_inv > 0 Then
            txt_num_inv.Text = f.gint_num_inv
            Call Cargar_Inventario()
        End If
        
    End Sub

    Private Sub Cargar_Inventario()

        If txt_num_inv.Text.Trim = "" Then
            MsgBox("ingrese el numero de inventario")
            Exit Sub
        End If

        Dim inventarioBL As New ClsOperaciones.AF_LT_TOMA_INV_C
        Dim ds_tmp As DataSet = inventarioBL.get_Inv_x_Numero(txt_num_inv.Text.Trim)


        If ds_tmp.Tables(0).Rows.Count = 0 Then
            MsgBox("El inventario no existe")
            inventarioBL = Nothing
            ds_tmp = Nothing
            Exit Sub
        End If

        btn_grabar.Enabled = True


        For i As Integer = 0 To ds_tmp.Tables(0).Rows.Count - 1
            dtp_fecha.Value = ds_tmp.Tables(0).Rows(i)("TI_FECHA")
            txt_obs.Text = ds_tmp.Tables(0).Rows(i)("TI_OBS")
            cmb_estado.SelectedValue = ds_tmp.Tables(0).Rows(i)("TI_ESTADO")
            cmb_respo_activo.SelectedValue = ds_tmp.Tables(0).Rows(i)("TI_IDRESPONSABLE")
            If ds_tmp.Tables(0).Rows(i)("TI_FECHA_FIN").ToString = "" Then
                dtp_fec_fin.Value = Now
            Else
                dtp_fec_fin.Value = ds_tmp.Tables(0).Rows(i)("TI_FECHA_FIN").ToString
            End If

        Next

        dgv_detalle.Rows.Clear()
        For i As Integer = 0 To ds_tmp.Tables(1).Rows.Count - 1
            dgv_detalle.Rows.Add()
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_idactivo").Value = ds_tmp.Tables(1).Rows(i)("TD_IDACTIVO")
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_desactivo").Value = ds_tmp.Tables(1).Rows(i)("AC_ACTIVO_DES").ToString
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_si").Value = IIf(ds_tmp.Tables(1).Rows(i)("TD_ESTADO_INV") = 1, True, False)
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_no").Value = IIf(ds_tmp.Tables(1).Rows(i)("TD_ESTADO_INV") = 1, False, True)

            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_ubi").Value = ds_tmp.Tables(1).Rows(i)("TD_IDUBICACION").ToString
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_area").Value = ds_tmp.Tables(1).Rows(i)("TD_IDAREA").ToString
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_estado").Value = ds_tmp.Tables(1).Rows(i)("TD_IDEST_FIS").ToString
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_asig").Value = ds_tmp.Tables(1).Rows(i)("TD_IDRESPO").ToString

            If ds_tmp.Tables(1).Rows(i)("TD_IDIMG").ToString = String.Empty Then
                dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_img").Value = Nothing
            Else
                dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_img").Value = Bytes2Image(ds_tmp.Tables(1).Rows(i)("TD_IDIMG"))
            End If

            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_comen").Value = ds_tmp.Tables(1).Rows(i)("TD_COMENTARIOS").ToString

        Next
        dgv_detalle.Update()


        If ds_tmp.Tables(0).Rows(0)("TI_ESTADO") = 2 Then
            btn_grabar.Enabled = False
            MsgBox("El inventario ya fue cerrado, no se puede modificar.")
        End If

        inventarioBL = Nothing
        ds_tmp = Nothing
        bol_nuevo = False


    End Sub

    Private Sub dgv_detalle_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgv_detalle.CurrentCellChanged

        'If dgv_detalle.CurrentRow.Cells("col_si").Value = True Then

        '    If dgv_detalle.CurrentRow.Cells("col_no").Value = True Then
        '        dgv_detalle.CurrentRow.Cells("col_no").Value = False
        '        MsgBox("si")
        '    End If
        'End If

        'If dgv_detalle.CurrentRow.Cells("col_si").Value = True Then

        '    MsgBox("si")

        'End If


    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click



        dgv_detalle.CurrentRow.Cells("col_ubi").Value = cmb_ubicacion.SelectedValue
        dgv_detalle.CurrentRow.Cells("col_area").Value = cmb_area.SelectedValue
        dgv_detalle.CurrentRow.Cells("col_estado").Value = cmb_est_fis.SelectedValue
        dgv_detalle.CurrentRow.Cells("col_asig").Value = cmb_responsable.SelectedValue
        dgv_detalle.CurrentRow.Cells("col_comen").Value = txt_comentario.Text.Trim
        dgv_detalle.CurrentRow.Cells("col_img").Value = pb_img.Image
        dgv_detalle.CurrentRow.Cells("col_si").Value = IIf(rb_si.Checked, True, False)
        dgv_detalle.CurrentRow.Cells("col_no").Value = IIf(rb_no.Checked, True, False)

        tc_detalle.SelectedIndex = 0
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

        End If
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        pb_img.Image = Nothing
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_detalle.SelectedIndex = 0
    End Sub

    Private Sub dgv_detalle_DoubleClick(sender As Object, e As EventArgs) Handles dgv_detalle.DoubleClick

        txt_idactivo.Text = dgv_detalle.CurrentRow.Cells("col_idactivo").Value
        txt_des_activo.Text = dgv_detalle.CurrentRow.Cells("col_desactivo").Value

        If dgv_detalle.CurrentRow.Cells("col_ubi").Value Is Nothing Then
            cmb_ubicacion.SelectedIndex = -1
        Else
            cmb_ubicacion.SelectedValue = dgv_detalle.CurrentRow.Cells("col_ubi").Value
        End If

        If dgv_detalle.CurrentRow.Cells("col_area").Value Is Nothing Then
            cmb_area.SelectedIndex = -1
        Else
            cmb_area.SelectedValue = dgv_detalle.CurrentRow.Cells("col_area").Value
        End If

        rb_si.Checked = IIf(dgv_detalle.CurrentRow.Cells("col_si").Value, True, False)
        rb_no.Checked = IIf(dgv_detalle.CurrentRow.Cells("col_no").Value, True, False)

        If dgv_detalle.CurrentRow.Cells("col_asig").Value Is Nothing Then
            cmb_responsable.SelectedIndex = -1
        Else
            cmb_responsable.SelectedValue = dgv_detalle.CurrentRow.Cells("col_asig").Value
        End If


        If dgv_detalle.CurrentRow.Cells("col_estado").Value Is Nothing Then
            cmb_est_fis.SelectedIndex = -1
        Else
            cmb_est_fis.SelectedValue = dgv_detalle.CurrentRow.Cells("col_estado").Value
        End If


        pb_img.Image = dgv_detalle.CurrentRow.Cells("col_img").Value

        If dgv_detalle.CurrentRow.Cells("col_comen").Value Is Nothing Then
            txt_comentario.Text = String.Empty
        Else
            txt_comentario.Text = dgv_detalle.CurrentRow.Cells("col_comen").Value
        End If

        tc_detalle.SelectedIndex = 1
        cmb_ubicacion.Focus()
    End Sub

    Private Sub txt_num_inv_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_inv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Inventario()
        End If
    End Sub
End Class