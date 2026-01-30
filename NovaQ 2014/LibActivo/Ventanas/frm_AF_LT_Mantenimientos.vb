Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_AF_LT_Mantenimientos

    Dim bol_nuevo As Boolean = False
    Dim lis_datos As List(Of ClsEntidades.AF_PR_MANTE_D_DATOS)

    Private Sub frm_AF_LT_Mantenimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Call Cargar_Combos()
        Call Cargar_Datos_Detalle()
    End Sub

    Private Sub Cargar_Datos()
        Dim manteBL As New ClsOperaciones.AF_PR_MANTE_C
        dgv_lista.DataSource = manteBL.get_Mantenimientos()
        manteBL = Nothing
    End Sub

    Private Sub Cargar_Datos_Detalle()
        Dim datosBL As New ClsOperaciones.AF_PR_DATOS_MANTE
        Dim dt_tmp As DataTable = datosBL.get_Datos()

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            dgv_datos.Rows.Add()
            dgv_datos.Rows(i).Cells("COL_ID").Value = dt_tmp.Rows(i)("DM_ID")
            dgv_datos.Rows(i).Cells("COL_DATO").Value = dt_tmp.Rows(i)("DM_DES").ToString
            dgv_datos.Rows(i).Cells("COL_DET").Value = ""
            dgv_datos.Update()
        Next



    End Sub

    Private Sub Editar()


        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub


        Dim manteBL As New ClsOperaciones.AF_PR_MANTE_C
        Dim ds_tmp As DataSet = Nothing
        Dim numfolio As Integer = dgv_lista.CurrentRow.Cells("MA_ID").Value
        ds_tmp = manteBL.get_data_x_Folio(numfolio)

        'cabecera
        With ds_tmp.Tables(0)
            txt_num_folio.Text = numfolio
            mtb_fec_ini.Text = .Rows(0)("MA_FEC_INI")
            mtb_fec_fin.Text = .Rows(0)("MA_FEC_FIN")
            cmb_tipo_mante.SelectedValue = .Rows(0)("MA_IDTIPO_MANTE")

            If .Rows(0)("MA_IDTIPO_EJECUTOR") = "P" Then
                rb_per.Checked = True
                cmb_respo_mante.SelectedValue = .Rows(0)("MA_IDRESPO_EJECU")
                cmb_tercero.SelectedIndex = -1
                cmb_tercero.Enabled = False
            Else
                rb_ter.Checked = True
                cmb_tercero.SelectedValue = .Rows(0)("MA_IDTERCERO_EJECU")
                cmb_respo_mante.SelectedIndex = -1
                cmb_respo_mante.Enabled = False
            End If

            txt_obs.Text = .Rows(0)("MA_OBS").ToString

        End With


        'detalle
        With ds_tmp.Tables(1)
            dgv_detalle.Rows.Clear()
            For i As Integer = 0 To .Rows.Count - 1
                dgv_detalle.Rows.Add()
                dgv_detalle.Rows(i).Cells("COL_IDACTIVO").Value = .Rows(i)("MD_IDACTIVO")
                dgv_detalle.Rows(i).Cells("COL_DES_ACTIVO").Value = .Rows(i)("AC_ACTIVO_DES")
                dgv_detalle.Rows(i).Cells("COL_FEC_INI").Value = .Rows(i)("MD_FEC_INI")
                dgv_detalle.Rows(i).Cells("COL_FEC_FIN").Value = .Rows(i)("MD_FEC_FIN")
                dgv_detalle.Rows(i).Cells("COL_HOR_INI").Value = .Rows(i)("MD_HOR_INI")
                dgv_detalle.Rows(i).Cells("COL_HOR_FIN").Value = .Rows(i)("MD_HOR_FIN")
                dgv_detalle.Rows(i).Cells("COL_IDAREA").Value = .Rows(i)("MD_IDAREA")
                dgv_detalle.Rows(i).Cells("COL_DES_AREA").Value = .Rows(i)("AR_DESCRIPCION")
                dgv_detalle.Rows(i).Cells("COL_RESPO").Value = .Rows(i)("MD_IDRESPO_ACTIVO")
                dgv_detalle.Rows(i).Cells("COL_DES_RESPO").Value = .Rows(i)("RA_DESCRIPCION")
                dgv_detalle.Rows(i).Cells("COL_COD_EJE").Value = .Rows(i)("MD_IDEJECUTOR")
                dgv_detalle.Rows(i).Cells("COL_DES_EJE").Value = .Rows(i)("RE_DESCRIPCION")
                dgv_detalle.Rows(i).Cells("COL_OBS").Value = .Rows(i)("MD_OBS").ToString

                If ds_tmp.Tables(1).Rows(i)("MD_IMG_ANT").ToString = "" Then
                    dgv_detalle.Rows(i).Cells("COL_IMG_ANT").Value = Nothing
                Else
                    dgv_detalle.Rows(i).Cells("COL_IMG_ANT").Value = Bytes2Image(.Rows(i)("MD_IMG_ANT"))
                End If

                If .Rows(i)("MD_IMG_DES").ToString = "" Then
                    dgv_detalle.Rows(i).Cells("COL_IMG_DES").Value = Nothing
                Else
                    dgv_detalle.Rows(i).Cells("COL_IMG_DES").Value = Bytes2Image(.Rows(i)("MD_IMG_DES"))
                End If

                dgv_detalle.Update()
            Next

        End With

        lis_datos = New List(Of ClsEntidades.AF_PR_MANTE_D_DATOS)
        Dim datosBE As ClsEntidades.AF_PR_MANTE_D_DATOS
        With ds_tmp.Tables(2)
            For i As Integer = 0 To .Rows.Count - 1
                datosBE = New ClsEntidades.AF_PR_MANTE_D_DATOS
                datosBE.DD_IDFOLIO = numfolio
                datosBE.DD_IDACTIVO = .Rows(i)("DD_IDACTIVO")
                datosBE.DD_ID = .Rows(i)("DD_ID")
                datosBE.DD_VALOR = .Rows(i)("DD_VALOR")
                lis_datos.Add(datosBE)
            Next
        End With


        ds_tmp = Nothing
        manteBL = Nothing

        dgv_img.Rows.Clear()
        pb_img.Image = Nothing


    End Sub

    Private Sub Cargar_Combos()

        Dim manteBL As New ClsOperaciones.AF_PR_MANTE_C
        Dim ds_data As DataSet = manteBL.get_data_combos()
        'tipo de mantenimiento
        cmb_tipo_mante.DataSource = ds_data.Tables(0)
        cmb_tipo_mante.ValueMember = "TM_ID"
        cmb_tipo_mante.DisplayMember = "TM_DESCRIPCION"

        'responsable de activo
        cmb_respo_activo.DataSource = ds_data.Tables(1)
        cmb_respo_activo.ValueMember = "RA_ID"
        cmb_respo_activo.DisplayMember = "RA_DESCRIPCION"

        'tercero
        cmb_tercero.DataSource = ds_data.Tables(2)
        cmb_tercero.ValueMember = "TE_ID"
        cmb_tercero.DisplayMember = "TE_DESCRIPCION"

        'area
        cmb_area.DataSource = ds_data.Tables(3)
        cmb_area.ValueMember = "AR_ID"
        cmb_area.DisplayMember = "AR_DESCRIPCION"


        'responsable de mantenimiento
        cmb_respo_mante.DataSource = ds_data.Tables(4)
        cmb_respo_mante.ValueMember = "RE_ID"
        cmb_respo_mante.DisplayMember = "RE_DESCRIPCION"

        'ejecutor detalle = personal responsable de mantenimiento
        cmb_ejecutor_det.DataSource = ds_data.Tables(5)
        cmb_ejecutor_det.ValueMember = "RE_ID"
        cmb_ejecutor_det.DisplayMember = "RE_DESCRIPCION"


        manteBL = Nothing
        ds_data = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click

        Call Limpiar_Controles(gb_datos)
        tc_cab.SelectedIndex = 1
        gb_datos.Enabled = True
        bol_nuevo = True

        If cmb_tipo_mante.Items.Count > 0 Then
            cmb_tipo_mante.SelectedIndex = 0
        End If

        lis_datos = New List(Of ClsEntidades.AF_PR_MANTE_D_DATOS)
        dgv_img.Rows.Clear()
        dgv_detalle.Rows.Clear()
        mtb_fec_ini.Focus()


    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click


        'If Not mtb_fec_ini.MaskFull Then
        '    MsgBox("Ingrese fecha de Inicio")
        '    mtb_fec_ini.Focus()
        '    Exit Sub
        'End If

        'If Not mtb_fec_fin.MaskFull Then
        '    MsgBox("Ingrese fecha de termino")
        '    mtb_fec_ini.Focus()
        '    Exit Sub
        'End If

        If rb_per.Checked Then
            If cmb_respo_mante.SelectedIndex = -1 Then
                MsgBox("Seleccione responsable de mantenimiento")
                cmb_respo_mante.Focus()
                Exit Sub
            End If
        End If

        If rb_ter.Checked Then
            If cmb_tercero.SelectedIndex = -1 Then
                MsgBox("Seleccione proveedor - tercero de mantenimiento")
                cmb_tercero.Focus()
                Exit Sub
            End If
        End If


        Dim mantecabBE As New ClsEntidades.AF_PR_MANTE_C
        With mantecabBE
            .MA_ID = IIf(txt_num_folio.Text.Trim = "", 0, txt_num_folio.Text.Trim)
            .MA_FEC_INI = mtb_fec_ini.Text
            .MA_FEC_FIN = mtb_fec_fin.Text
            .MA_IDTIPO_MANTE = cmb_tipo_mante.SelectedValue
            .MA_OBS = txt_obs.Text.Trim
            .MA_IDTIPO_EJECUTOR = IIf(rb_per.Checked, "P", "T")
            .MA_IDRESPO_EJECU = IIf(rb_per.Checked, cmb_respo_mante.SelectedValue, "")
            .MA_IDTERCERO_EJECU = IIf(rb_ter.Checked, cmb_tercero.SelectedValue, "")
            .MA_ESTADO = 1
            .MA_USUARIO = LibComunVar.ClsVarComun.USUARIO
            .MA_TERMINAL = Environment.MachineName
            .MA_FECREG = Now
        End With

        Dim det As ClsEntidades.AF_PR_MANTE_D
        Dim lista As New List(Of ClsEntidades.AF_PR_MANTE_D)
        For i As Integer = 0 To dgv_detalle.Rows.Count - 1
            det = New ClsEntidades.AF_PR_MANTE_D
            With det
                .MD_IDFOLIO = IIf(txt_num_folio.Text.Trim = "", 0, txt_num_folio.Text.Trim)
                .MD_IDACTIVO = dgv_detalle.Rows(i).Cells("col_idactivo").Value
                .MD_FEC_INI = dgv_detalle.Rows(i).Cells("COL_FEC_INI").Value
                .MD_FEC_FIN = dgv_detalle.Rows(i).Cells("COL_FEC_FIN").Value
                .MD_HOR_INI = dgv_detalle.Rows(i).Cells("COL_HOR_INI").Value
                .MD_HOR_FIN = dgv_detalle.Rows(i).Cells("COL_HOR_FIN").Value
                .MD_IDRESPO_ACTIVO = dgv_detalle.Rows(i).Cells("COL_RESPO").Value
                .MD_IDAREA = dgv_detalle.Rows(i).Cells("COL_IDAREA").Value
                .MD_IDEJECUTOR = dgv_detalle.Rows(i).Cells("COL_COD_EJE").Value
                .MD_OBS = dgv_detalle.Rows(i).Cells("COL_OBS").Value

                If dgv_detalle.Rows(i).Cells("COL_IMG_ANT").Value Is Nothing Then
                    .MD_IMG_ANT = Nothing
                Else
                    .MD_IMG_ANT = Image2Bytes(dgv_detalle.Rows(i).Cells("COL_IMG_ANT").Value)
                End If

                If dgv_detalle.Rows(i).Cells("COL_IMG_DES").Value Is Nothing Then
                    .MD_IMG_DES = Nothing
                Else
                    .MD_IMG_DES = Image2Bytes(dgv_detalle.Rows(i).Cells("COL_IMG_DES").Value)
                End If

            End With
            lista.Add(det)
        Next

        Dim manteBL As New ClsOperaciones.AF_PR_MANTE_C
        If bol_nuevo Then
            manteBL.insert(mantecabBE, lista, lis_datos)
        Else
            manteBL.update(mantecabBE, lista, lis_datos)
        End If

        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

        MsgBox("Listo!")

        manteBL = Nothing

    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        'aqui esta el chongo
        bol_nuevo = False
        Call Editar()
        tc_cab.SelectedIndex = 1
        mtb_fec_ini.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_cab.SelectedIndex = 0
        gb_datos.Enabled = False
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_lista.RowCount = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de Eliminar?", MsgBoxStyle.Question, "Cuidado!") = MsgBoxResult.Yes Then
            Dim catBE As New ClsEntidades.AF_PR_MANTE_C
            Dim catBL As New ClsOperaciones.AF_PR_MANTE_C
            With catBE
                .MA_ID = dgv_lista.CurrentRow.Cells("MA_ID").Value
            End With
            catBL.delete(catBE)
            catBE = Nothing
            catBL = Nothing
            MsgBox("Listo!")
            Call Cargar_Datos()
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub rb_per_CheckedChanged(sender As Object, e As EventArgs) Handles rb_per.CheckedChanged
        'If rb_per.Checked Then
        '    cmb_respo_mante.Enabled = True
        '    cmb_tercero.Enabled = False
        'End If
    End Sub

    Private Sub rb_ter_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ter.CheckedChanged
        'If rb_ter.Checked Then
        '    cmb_respo_mante.Enabled = False
        '    cmb_tercero.Enabled = True
        'End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        tc_det.SelectedIndex = 1
        txt_idactivo.Text = ""
        txt_des_activo.Text = ""
        dgv_img.Rows.Clear()
        txt_idactivo.Focus()

    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_detalle.RowCount = 0 Then Exit Sub
        If dgv_detalle.CurrentRow Is Nothing Then Exit Sub

inicio:

        For I As Integer = 0 To lis_datos.Count - 1
            If lis_datos(I).DD_IDACTIVO = dgv_detalle.CurrentRow.Cells("col_idactivo").Value Then
                lis_datos.RemoveAt(I)
                GoTo inicio
            End If
        Next

        dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)
    End Sub

    Private Sub txt_idactivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idactivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim f As New frm_AF_LT_AyudaActivo
            f.ShowDialog()
            If f.bol_aceptar Then
                txt_idactivo.Text = f.ent_activo.AC_IDACTIVO
                txt_des_activo.Text = f.ent_activo.AC_ACTIVO_DES
                mtb_fec_ini_det.Focus()
            End If
            f = Nothing
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click


        If txt_idactivo.Text.Trim = "" Then
            MsgBox("Ingrese el codigo de activo")
            txt_idactivo.Focus()
            Exit Sub
        End If

        dgv_detalle.Rows.Add()
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("col_idactivo").Value = txt_idactivo.Text.Trim
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_DES_ACTIVO").Value = txt_des_activo.Text.Trim
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_FEC_INI").Value = mtb_fec_ini_det.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_FEC_FIN").Value = mtb_fec_fin_det.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_HOR_INI").Value = mtb_hor_ini.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_HOR_FIN").Value = mtb_hor_fin.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_IDAREA").Value = cmb_area.SelectedValue
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_DES_AREA").Value = cmb_area.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_RESPO").Value = cmb_respo_activo.SelectedValue
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_DES_RESPO").Value = cmb_respo_activo.Text
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_COD_EJE").Value = cmb_ejecutor_det.SelectedValue
        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_DES_EJE").Value = cmb_ejecutor_det.Text

        If dgv_img.Rows.Count > 0 Then
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_IMG_ANT").Value = dgv_img.Rows(0).Cells("col_Img").Value
        Else
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_IMG_ANT").Value = Nothing
        End If

        If dgv_img.Rows.Count > 1 Then
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_IMG_DES").Value = dgv_img.Rows(1).Cells("col_Img").Value
        Else
            dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_IMG_DES").Value = Nothing
        End If

        dgv_detalle.Rows(dgv_detalle.Rows.Count - 1).Cells("COL_OBS").Value = txtobs_det.Text.Trim
        dgv_detalle.Update()

        Dim datosBE As ClsEntidades.AF_PR_MANTE_D_DATOS
        For i As Integer = 0 To dgv_datos.Rows.Count - 1
            datosBE = New ClsEntidades.AF_PR_MANTE_D_DATOS
            datosBE.DD_IDFOLIO = IIf(txt_num_folio.Text.Trim = "", 0, txt_num_folio.Text.Trim)
            datosBE.DD_IDACTIVO = txt_idactivo.Text.Trim
            datosBE.DD_ID = dgv_datos.Rows(i).Cells("COL_ID").Value
            datosBE.DD_VALOR = dgv_datos.Rows(i).Cells("COL_DET").Value.ToString
            lis_datos.Add(datosBE)
        Next

        pb_img.Image = Nothing

        tc_det.SelectedIndex = 0

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Call Limpiar_detalle()
        tc_det.SelectedIndex = 0
        txt_idactivo.Focus()
    End Sub

    Private Sub Limpiar_detalle()
        txt_idactivo.Text = String.Empty
        txt_des_activo.Text = String.Empty
        txtobs_det.Text = String.Empty
        mtb_fec_ini_det.Text = String.Empty
        mtb_fec_fin_det.Text = String.Empty
        mtb_hor_ini.Text = String.Empty
        mtb_hor_fin.Text = String.Empty
        cmb_area.SelectedIndex = -1
        cmb_respo_activo.SelectedIndex = -1
        cmb_ejecutor_det.SelectedIndex = -1
    End Sub

    Private Sub mtb_fec_ini_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobs_det.KeyDown, txt_obs.KeyDown, mtb_hor_ini.KeyDown, mtb_hor_fin.KeyDown, cmb_tipo_mante.KeyDown, cmb_tercero.KeyDown, cmb_respo_mante.KeyDown, cmb_ejecutor_det.KeyDown, cmb_area.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F5 Then
            mtb_fec_ini.Text = gFechaSis
        End If
    End Sub

    Private Sub mtb_fec_fin_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F5 Then
            mtb_fec_fin.Text = gFechaSis
        End If
    End Sub

    Private Sub mtb_fec_ini_det_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F5 Then
            mtb_fec_ini_det.Text = gFechaSis
        End If
    End Sub

    Private Sub mtb_fec_fin_det_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F5 Then
            mtb_fec_fin_det.Text = gFechaSis
        End If
    End Sub

    Private Sub cmb_respo_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_respo_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F5 Then
            'Cargar_Combos()
            Dim manteBL As New ClsOperaciones.AF_PR_MANTE_C
            Dim ds_data As DataSet = manteBL.get_data_combos()
            'responsable de activo
            cmb_respo_activo.DataSource = ds_data.Tables(1)
            cmb_respo_activo.ValueMember = "RA_ID"
            cmb_respo_activo.DisplayMember = "RA_DESCRIPCION"
            manteBL = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

            Dim desc_img As String = ""
            'desc_img = InputBox("Ingrese descripcion de la imagen", "agregar imagen")

            dgv_img.Rows.Add()
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_sec").Value = dgv_img.Rows.Count
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_nom").Value = sNombre
            dgv_img.Rows(dgv_img.Rows.Count - 1).Cells("col_des").Value = IIf(dgv_img.Rows.Count = 1, "ANTES", "DESPUES")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgv_img.RowCount = 0 Then Exit Sub
        If dgv_img.CurrentRow Is Nothing Then Exit Sub
        dgv_img.Rows.Remove(dgv_img.CurrentRow)

        For i As Integer = 0 To dgv_img.Rows.Count - 1
            dgv_img.Rows(i).Cells("col_sec").Value = i + 1
        Next
        dgv_img.Update()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tc_det.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tc_det.SelectedIndex = 2
    End Sub

    Private Sub cmb_tipo_mante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_mante.SelectedIndexChanged

    End Sub

    Private Sub cmb_respo_mante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_respo_mante.SelectedIndexChanged

    End Sub

    Private Sub cmb_tercero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tercero.SelectedIndexChanged

    End Sub
End Class