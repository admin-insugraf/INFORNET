Imports System.Windows.Forms

Public Class frm_CO_MA_Anexos
    Dim bol_nuevo As Boolean = False
    Dim dv_data As DataView
    Dim STRorden As String = String.Empty


    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Private Sub frm_CO_MA_Anexos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Inicializa_Tool(ToolS_Mantenimiento)
        Call Cargar_Combo()
        gb_data.Enabled = False
    End Sub

    Public Sub Cargar_Datos(tipo_ As String)
        Me.Cursor = Cursors.WaitCursor
        Dim fqBL As New ClsOperaciones.freeQuery
        dv_data = New DataView
        dv_data = fqBL.get_Annexed(tipo_).DefaultView
        dgv_Lista.DataSource = dv_data
        fqBL = Nothing

        For i As Integer = 0 To dgv_Lista.Columns.Count - 1
            dgv_Lista.Columns(i).Visible = False
        Next
        dgv_Lista.Columns("ID").Visible = True
        dgv_Lista.Columns("VAT_REGISTRATION").Visible = True
        dgv_Lista.Columns("NAME").Visible = True

        dgv_Lista.Columns("ID").HeaderText = "Codigo"
        dgv_Lista.Columns("VAT_REGISTRATION").HeaderText = "Ruc"
        'dgv_Lista.Columns("VAT_REGISTRATION").HeaderText = "Nº de Docum.tipAnexBL=Nothing"
        dgv_Lista.Columns("NAME").HeaderText = "Descripcion"
        'dgv_Lista.Columns("VAT_REGISTRATION").Width = 100
        'dgv_Lista.Columns("NAME").Width = 350
        dgv_Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        STRorden = dgv_Lista.Columns("VAT_REGISTRATION").Name & "+" & dgv_Lista.Columns("NAME").Name
        lblCantidad.Text = "Se encontraron " & dv_data.Count & " registros"
        dgv_Lista.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub Cargar_Combo()

        Dim tipAnexBL As New ClsOperaciones.CO_TB_TIPO_ANEXO
        Dim tipDocAnexBL As New ClsOperaciones.CO_TB_TIPO_DOC_ANE

        Dim dt_tmp1 As DataTable = tipAnexBL.get_Tipos
        Dim dt_tmp2 As DataTable = tipAnexBL.get_Tipos
        Dim dt_tmp3 As DataTable = tipDocAnexBL.get_Tipos

        dt_tmp1.TableName = "temporal"
        dt_tmp2.TableName = "temporal2"
        dt_tmp3.TableName = "temporal3"

        'ListBox
        lb_tipos.DataSource = dt_tmp1
        lb_tipos.ValueMember = dt_tmp1.Columns(0).ToString()
        lb_tipos.DisplayMember = dt_tmp1.Columns(1).ToString()

        cmb_tipo_anexo.DataSource = dt_tmp2
        cmb_tipo_anexo.ValueMember = dt_tmp2.Columns(0).ToString()
        cmb_tipo_anexo.DisplayMember = dt_tmp2.Columns(1).ToString()

        cbo_tipodoc.DataSource = dt_tmp3
        cbo_tipodoc.ValueMember = dt_tmp3.Columns(0).ToString()
        cbo_tipodoc.DisplayMember = dt_tmp3.Columns(1).ToString()

        tipAnexBL = Nothing
        tipDocAnexBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles(gb_data)

        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True
        cbo_tipodoc.SelectedValue = "6"

        cmb_tipo_anexo.SelectedValue = lb_tipos.SelectedValue.ToString()
        txtcodigo.Focus()
        If bol_nuevo = True Then
            cmb_tipo_anexo.Enabled = True
            txt_num_doc.Enabled = True
        End If
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click

        If txtcodigo.Text.Length = 0 Then
            MsgBox("Ingrese el codigo del Anexo", MsgBoxStyle.Information)
            txtcodigo.Focus()
            Exit Sub
        End If

        If txt_num_doc.Text.Length = 0 Then
            MsgBox("Ingrese el numero de documento", MsgBoxStyle.Information)
            txt_num_doc.Focus()
            Exit Sub
        End If

        If txt_des.Text.Length = 0 Then
            MsgBox("Ingrese la Razon Social", MsgBoxStyle.Information, "Sistemas")
            txt_des.Focus()
            Exit Sub
        End If

        If cbo_tipodoc.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un Tipo de Documento", MsgBoxStyle.Information)
            cbo_tipodoc.Focus()
            Exit Sub
        End If

        Dim anexoBL As New ClsOperaciones.freeQuery
        If MessageBox.Show("¿Desea grabar los datos ingresados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If bol_nuevo Then
                If anexoBL.Insert_Annexed(txtcodigo.Text, cmb_tipo_anexo.SelectedValue.ToString(), txt_num_doc.Text, txt_des.Text, "", "", "", "", cbo_tipodoc.SelectedValue.ToString()) = True Then
                    MsgBox("Guardado Exitosamente.", MsgBoxStyle.Information)
                End If
            Else
                If anexoBL.Update_Annexed(txtcodigo.Text, cmb_tipo_anexo.SelectedValue.ToString(), txt_num_doc.Text, txt_des.Text, "", "", "", "", cbo_tipodoc.SelectedValue.ToString()) = True Then
                    MsgBox("Modificado Exitosamente.", MsgBoxStyle.Information)
                End If
            End If
            anexoBL = Nothing
            Call Tool_Cancelar_Click(sender, e)
            Call Cargar_Datos(lb_tipos.SelectedValue.ToString())
        End If
        

    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        Call Limpiar_Controles(gb_data)
        bol_nuevo = False
        cmb_tipo_anexo.SelectedValue = lb_tipos.SelectedValue.ToString()
        If String.IsNullOrEmpty(dgv_Lista.Item(8, dgv_Lista.CurrentRow.Index).Value.ToString) Then
            cbo_tipodoc.SelectedIndex = -1
        Else
            cbo_tipodoc.SelectedValue = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("BUSINESS").Value.ToString()
        End If
        txtcodigo.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("ID").Value.ToString()
        txt_num_doc.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("VAT_REGISTRATION").Value.ToString()
        txt_des.Text = dgv_Lista.Rows(dgv_Lista.CurrentRow.Index).Cells("NAME").Value.ToString()
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
        tc_Lista.SelectedIndex = 1
        gb_data.Enabled = True
        txt_num_doc.Focus()
        If bol_nuevo = False Then
            cmb_tipo_anexo.Enabled = False
            txtcodigo.Enabled = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        tc_Lista.SelectedIndex = 0
        gb_data.Enabled = False
        Call Cambiar_Estado_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        MessageBox.Show("No se ha configurado para que se eliminen Anexos.", "Sistema")
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub lb_tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_tipos.SelectedIndexChanged
        Call Cargar_Datos(lb_tipos.SelectedValue.ToString())
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs)
        'If cmb_campos.SelectedIndex = 0 Then
        '    dv_data.RowFilter = "VAT_REGISTRATION like '%" & txt_busca.Text.Trim() & "%'"
        'Else
        '    dv_data.RowFilter = "NAME like '%" & txt_busca.Text.Trim() & "%'"
        'End If
    End Sub

    Private Sub dgv_Lista_DoubleClick(sender As Object, e As EventArgs)
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub cmb_tipo_anexo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tipo_anexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipodoc.Focus()
        End If
    End Sub

    Private Sub cmb_td_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipodoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_doc.Focus()
        End If
    End Sub

    Private Sub txt_num_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_doc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Try
            If txtFiltro.Text = String.Empty Then
                dv_data.RowFilter = String.Empty
                lblCantidad.Text = "Se encontraron " & dv_data.Count & " registros"
                Exit Sub
            Else
                dv_data.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dv_data.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgv_Lista.Columns(0).Name
                    dv_data.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dv_data.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgv_Lista.Columns(1).Name
                        dv_data.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                        If dv_data.Count() = 0 Then
                            STRorden = String.Empty
                            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
                            lblCantidad.Text = "Se encontraron " & dv_data.Count & " registros"
                            Exit Sub
                        End If
                    End If
                End If
                lblCantidad.Text = "Se encontraron " & dv_data.Count & " registros"
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
                Dim CodigoTipoAnexo As String = lb_tipos.SelectedValue.ToString()
                crystalBL = New LibReportes.ClsReporte
                reporteBL = New ClsBuscar
                Me.Cursor = Cursors.WaitCursor
                dtImprimir = New DataTable("REPORTE")
                dtImprimir = reporteBL.EjecutarReporteAnexos(CodigoTipoAnexo)
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_AsientoContable_lista_Anexos.rpt", "", "", "", "@TYPE;" & CodigoTipoAnexo)
                End If
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub txtcodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_tipo_anexo.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Tool_Grabar_Click(sender, e)
        End If
    End Sub
End Class