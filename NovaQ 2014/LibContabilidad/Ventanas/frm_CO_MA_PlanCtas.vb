Imports System.Windows.Forms

Public Class frm_CO_MA_PlanCtas

    Dim bol_nuevo As Boolean = False
    Dim dv_datos As DataView
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub frm_CO_MA_PlanCtas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Call Cargar_Combos()
        Call Inicializa_Tool(ToolS_Mantenimiento)
        gb_data.Enabled = False
    End Sub

    Public Sub Cargar_Datos()
        Try
            Dim planBL As New ClsOperaciones.CO_TB_PLANCTAS
            'dv_datos = planBL.get_Cuentas(Date.Now.Year).DefaultView
            'dgv_Lista.DataSource = dv_datos
            dtv = New DataView
            dtv = planBL.get_Cuentas(Date.Now.Year).DefaultView
            dgv_Lista.DataSource = dtv
            planBL = Nothing
            For i As Integer = 0 To dgv_Lista.ColumnCount - 1
                dgv_Lista.Columns(i).Visible = False
            Next
            dgv_Lista.Columns("PC_NUM_CTA").Visible = True
            dgv_Lista.Columns("PC_DES_CTA").Visible = True

            dgv_Lista.Columns("PC_DES_D").Visible = True
            dgv_Lista.Columns("PC_DES_H").Visible = True

            dgv_Lista.Columns("PC_NUM_CTA").HeaderText = "Numero"
            dgv_Lista.Columns("PC_DES_CTA").HeaderText = "Cuenta"
            dgv_Lista.Columns("PC_DES_CTA").Width = 400
            dgv_Lista.Columns("PC_DES_D").HeaderText = "Destino Debe"
            dgv_Lista.Columns("PC_DES_H").HeaderText = "Destino Haber"
            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Combos()
        Try
            Dim monedaBL As New ClsOperaciones.CO_TB_MONEDA
            Dim tipAnexBL As New ClsOperaciones.CO_TB_TIPO_ANEXO
            Dim tipMovBL As New ClsOperaciones.CO_TB_TIPO_MOV

            cmb_Moneda.DisplayMember = "MO_ABRE"
            cmb_Moneda.ValueMember = "MO_CODIGO"
            cmb_Moneda.DataSource = monedaBL.get_Monedas()
       
            cmb_tipo_anexo.DisplayMember = "TA_DESCRIPCION"
            cmb_tipo_anexo.ValueMember = "TA_ID"
            cmb_tipo_anexo.DataSource = tipAnexBL.get_Tipos()
       
            cmb_tipo_Mov.DisplayMember = "TM_DESCRIPCION"
            cmb_tipo_Mov.ValueMember = "TM_ID"
            cmb_tipo_Mov.DataSource = tipMovBL.get_Tipos()
            monedaBL = Nothing
            tipAnexBL = Nothing
            tipMovBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles(gb_data)
        chk_cc.Checked = False
        chk_mp.Checked = False
        chk_efectivo.Checked = False
        chk_ctacorriente.Checked = False

        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True
        cmb_tipo_anexo.SelectedIndex = -1
        cmb_tipo_Mov.SelectedIndex = 0
        txt_cod.Enabled = True
        txt_cod.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click


        If txt_cod.Text.Trim.Length = 0 Then
            'MessageBox.Show("Ingrese el numero de cuenta.", "Aviso")
            MsgBox("Ingrese el numero de cuenta.", MsgBoxStyle.Critical)
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            'MessageBox.Show("Ingrese la descripcion de la cuenta.", "Aviso")
            MsgBox("Ingrese la descripcion de la cuenta.", MsgBoxStyle.Critical)
            txt_des.Focus()
            Exit Sub
        End If

        If bol_nuevo Then
            Dim planBL As New ClsOperaciones.CO_TB_PLANCTAS
            'dv_datos = planBL.get_Cuentas(Date.Now.Year).DefaultView
            'dgv_Lista.DataSource = dv_datos
            Dim DT_AVISO As DataTable
            DT_AVISO = planBL.get_Validar_Cuenta(txt_cod.Text)
            If DT_AVISO.Rows.Count > 0 Then
                MsgBox("La cuenta ingresada ya existe en el Plan de Cuentas.", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If
        End If
        

        Dim moneda As Integer = cmb_Moneda.SelectedValue
        Dim tipMov As Integer = cmb_tipo_Mov.SelectedValue
        Dim tpAnex As Integer = IIf(cmb_tipo_anexo.SelectedIndex >= 0, cmb_tipo_anexo.SelectedValue, 0)
        Dim cencos As Integer = IIf(chk_cc.Checked, 1, 0)

        Dim cuentasBL As New ClsOperaciones.CO_TB_PLANCTAS

        If bol_nuevo Then
            cuentasBL.Insert(txt_cod.Text.Trim(), txt_des.Text.Trim(), moneda, tipMov, tpAnex, gFechaSis.Year, cencos, txt_des_d.Text, txt_des_h.Text, IIf(chk_efectivo.Checked, 1, 0), IIf(chk_ctacorriente.Checked, 1, 0), IIf(chk_mp.Checked, 1, 0), IIf(CheckBox1.Checked, 1, 0))
            'cuentasBL.Update(txt_cod.Text.Trim(), txt_des.Text.Trim(), moneda, tipMov, tpAnex, gFechaSis.Year, cencos, txt_des_d.Text, txt_des_h.Text, IIf(chk_efectivo.Checked, 1, 0), IIf(chk_ctacorriente.Checked, 1, 0), IIf(chk_mp.Checked, 1, 0), IIf(CheckBox1.Checked, 1, 0))
        Else
            'cuentasBL.Insert(txt_cod.Text.Trim(), txt_des.Text.Trim(), moneda, tipMov, tpAnex, gFechaSis.Year, cencos, txt_des_d.Text, txt_des_h.Text, IIf(chk_efectivo.Checked, 1, 0), IIf(chk_ctacorriente.Checked, 1, 0), IIf(chk_mp.Checked, 1, 0), IIf(CheckBox1.Checked, 1, 0))
            cuentasBL.Update(txt_cod.Text.Trim(), txt_des.Text.Trim(), moneda, tipMov, tpAnex, gFechaSis.Year, cencos, txt_des_d.Text, txt_des_h.Text, IIf(chk_efectivo.Checked, 1, 0), IIf(chk_ctacorriente.Checked, 1, 0), IIf(chk_mp.Checked, 1, 0), IIf(CheckBox1.Checked, 1, 0))
        End If

        'MessageBox.Show("Proceso generado correctamente!", "Sistema", MessageBoxButtons.OK)
        MsgBox("Proceso generado correctamente!", MsgBoxStyle.Information)
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)


    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        Call Limpiar_Controles(gb_data)

        bol_nuevo = False
        chk_cc.Checked = False
        chk_mp.Checked = False
        chk_efectivo.Checked = False
        chk_ctacorriente.Checked = False
        CheckBox1.Checked = False

        cmb_tipo_anexo.SelectedIndex = -1

        txt_cod.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_NUM_CTA").Value.ToString()
        txt_des.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_DES_CTA").Value.ToString()
        If String.IsNullOrEmpty(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDMONEDA").Value.ToString) Then
            cmb_Moneda.SelectedIndex = -1
        Else
            cmb_Moneda.SelectedValue = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDMONEDA").Value.ToString
        End If

        If String.IsNullOrEmpty(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDTIPO_ANEXO").Value.ToString) Then
            cmb_tipo_anexo.SelectedIndex = -1
        Else
            cmb_tipo_anexo.SelectedValue = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDTIPO_ANEXO").Value.ToString
        End If

        If String.IsNullOrEmpty(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDTIPO_MOV").Value.ToString) Then
            cmb_tipo_Mov.SelectedIndex = -1
        Else
            cmb_tipo_Mov.SelectedValue = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_IDTIPO_MOV").Value.ToString
        End If


        chk_cc.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_ES_CC").Value.ToString() = "1", True, False)
        chk_efectivo.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_ES_EFE").Value.ToString() = "1", True, False)
        chk_ctacorriente.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_ES_CTA").Value.ToString() = "1", True, False)

        CheckBox1.Checked = IIf(dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_TCAMBIO").Value.ToString() = "1", True, False)

        txt_des_d.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_DES_D").Value.ToString
        txt_des_h.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_DES_H").Value.ToString

        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)

        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True
        txt_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_Lista.SelectedIndex = 0
        gb_data.Enabled = False
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If dgv_Lista.RowCount > 0 Then
            If MessageBox.Show("Seguro de eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Dim cuentasBL As New ClsOperaciones.CO_TB_PLANCTAS
                Dim numCuenta As String = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("PC_NUM_CTA").Value.ToString

                cuentasBL.Delete(numCuenta, gFechaSis.Year)
                cuentasBL = Nothing

                MessageBox.Show("Cuenta Contable eliminada", "Sistema")
                Call Cargar_Datos()
            End If
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub dgv_Lista_DoubleClick(sender As Object, e As EventArgs) Handles dgv_Lista.DoubleClick
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Try
            If txtFiltro.Text = String.Empty Then
                dtv.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                Exit Sub
            Else
                dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgv_Lista.Columns(0).Name
                    dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgv_Lista.Columns(1).Name
                        dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                        If dtv.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
                            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                            Exit Sub
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
 
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dgv_Lista.RowCount > 0 Then
            If dgv_Lista.CurrentRow Is Nothing Then
                dgv_Lista.Focus()
                Exit Sub
            End If
            If Not dgv_Lista.CurrentRow Is Nothing Then
                If String.IsNullOrEmpty(dgv_Lista.CurrentRow.Cells("PC_NUM_CTA").Value.ToString()) Then Exit Sub
                Dim CodAsiento As String = Integer.Parse(dgv_Lista.CurrentRow.Cells("PC_NUM_CTA").Value.ToString())
                crystalBL = New LibReportes.ClsReporte
                reporteBL = New ClsBuscar
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("REPORTE")
                dtImprimir = reporteBL.EjecutarReporteListaCuentasContables(CodAsiento)
                    If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_AsientoContable_Lista.rpt", "", "", "", "@PC_NUM_CTA;" & CodAsiento)
                    End If
                Me.Cursor = Cursors.Default
                End If
        End If
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim planBL As New ClsOperaciones.CO_TB_PLANCTAS
            'dv_datos = planBL.get_Cuentas(Date.Now.Year).DefaultView
            'dgv_Lista.DataSource = dv_datos
            Dim DT_AVISO As DataTable
            DT_AVISO = planBL.get_Validar_Cuenta(txt_cod.Text)
            If DT_AVISO.Rows.Count > 0 Then
                MsgBox("La cuenta ingresada ya existe en el Plan de Cuentas.", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If

            txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_Moneda.Focus()
        End If
    End Sub

    Private Sub cmb_Moneda_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_tipo_Mov.Focus()
        End If
    End Sub

    Private Sub cmb_tipo_Mov_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tipo_Mov.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_tipo_anexo.Focus()
        End If
    End Sub
End Class