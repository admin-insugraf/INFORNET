Imports System.Windows.Forms

Public Class Frm_MA_Conceptos_Variables
    Dim bol_nuevo As Boolean = False

    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim transaccionesBL As ClsOperaciones.Personal_RRHH
    Dim transaccionesEnt As ClsEntidades.PL_CONCEPTOS_VARIABLES

    Dim dtdetalles As DataTable
    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable
    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable
    Private Sub Frm_MA_Conceptos_Variables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Data()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
        Call Cargar_Tipo()
    End Sub

    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_tipos.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        '-----------------------------------
        Select Case tc_tipos.SelectedIndex
            Case 0
                tc_tipos.SelectedIndex = indice + 1
            Case 1
                tc_tipos.SelectedIndex = indice - 1
        End Select
        ' ----------------------------------
    End Sub

    Private Sub Cargar_Data()
        transaccionesBL = New ClsOperaciones.Personal_RRHH
        dtdetalles = New DataTable
        dtv = New DataView
        STRorden = ""
        dtdetalles = transaccionesBL.DocumentoPrincipal_Conceptos_Variables
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_transacciones.AutoResizeColumns()
            dgv_transacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv_transacciones.DataSource = dtv
            dgv_transacciones.Columns(0).HeaderText = "Tipo"
            dgv_transacciones.Columns(1).HeaderText = "Codigo"
            dgv_transacciones.Columns(2).HeaderText = "Descripción"
            dgv_transacciones.Columns(3).HeaderText = "Afecto a ESSALUD"
            dgv_transacciones.Columns(4).HeaderText = "Afecto a AFP"

            dgv_transacciones.Columns("DETALLE_ANEXO").Visible = False
            dgv_transacciones.Columns("RUC_ANEXO").Visible = False

            STRorden = dgv_transacciones.Columns(0).Name & "+" & dgv_transacciones.Columns(1).Name & "+" & dgv_transacciones.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        transaccionesBL = Nothing
    End Sub

    Private Sub Cargar_Tipo()
        cmb_tipo.Items.Clear()
        cmb_tipo.Items.Add("I - Ingreso")
        cmb_tipo.Items.Add("D - Descuento")
        cmb_tipo.Items.Add("G - General")
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        txt_cod.Text = String.Empty
        txt_des.Text = String.Empty
        txtcuentaAdm.Text = ""
        txtcuentaVta.Text = ""
        txtcuentaProd.Text = ""
        chk_detalla_anexo.Checked = False
        txt_ruc_anexo.Text = ""
        cbo_debe_haber.SelectedIndex = -1
        chk_afecto_essalud.Checked = False
        chk_afecto_afp.Checked = False
        gb_data.Enabled = True
        bol_nuevo = True
        cmb_tipo.SelectedIndex = 0
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        cmb_tipo.Enabled = True
        txt_cod.Enabled = False
        txt_cod.Text = Numeracion()
        txt_des.Focus()
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New ClsOperaciones.Personal_RRHH
            CORRELATIVOBL.NumeroCorrelativo_Conceptos_Variables()
            If String.IsNullOrEmpty(CORRELATIVOBL.Correlativo_Conceptos_Variables.ToString) Then
                Correlativo = "00"
            Else
                Correlativo = String.Format("{0:00}", CInt(CORRELATIVOBL.Correlativo_Conceptos_Variables + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_cod.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del Concepto.", MsgBoxStyle.Exclamation)
            txt_cod.Focus()
            Exit Sub
        ElseIf txt_des.Text = String.Empty Then
            MsgBox("Debe ingresar una descripción del Concepto.", MsgBoxStyle.Exclamation)
            txt_des.Focus()
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim areaEnt As New ClsEntidades.PL_CONCEPTOS_VARIABLES
            transaccionesBL = New ClsOperaciones.Personal_RRHH

            areaEnt.ID = txt_cod.Text
            areaEnt.DESCRIPTION = txt_des.Text
            areaEnt.TIPO = IIf(cmb_tipo.SelectedIndex = 0, "I", IIf(cmb_tipo.SelectedIndex = 1, "D", IIf(cmb_tipo.SelectedIndex = 2, "G", "")))
            areaEnt.AFECTO_REM_ESSALUD = IIf(chk_afecto_essalud.Checked, "S", "N")
            areaEnt.AFECTO_REM_AFP = IIf(chk_afecto_afp.Checked, "S", "N")

            areaEnt.CUENTA_ADM = txtcuentaAdm.Text
            areaEnt.CUENTA_VTA = txtcuentaVta.Text
            areaEnt.CUENTA_PROD = txtcuentaProd.Text
            areaEnt.DEBE_HABER = cbo_debe_haber.Text

            areaEnt.DETALLE_ANEXO = IIf(chk_detalla_anexo.Checked, "S", "N")
            areaEnt.RUC_ANEXO = txt_ruc_anexo.Text

            If bol_nuevo Then
                If transaccionesBL.Guardar_Conceptos_variables(areaEnt) = True Then
                    MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Exclamation)
                End If
            Else
                If transaccionesBL.Actualizar_Conceptos_variables(areaEnt) = True Then
                    MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Exclamation)
                End If
            End If
            Cargar_Data()
            btn_cancelar_Click(sender, e)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub

        cmb_tipo.SelectedIndex = IIf(dgv_transacciones.CurrentRow.Cells("TIPO").Value.ToString = "I", 0, IIf(dgv_transacciones.CurrentRow.Cells("TIPO").Value.ToString = "D", 1, IIf(dgv_transacciones.CurrentRow.Cells("TIPO").Value.ToString = "G", 2, -1)))
        txt_cod.Text = dgv_transacciones.CurrentRow.Cells("Codigo").Value
        txt_des.Text = dgv_transacciones.CurrentRow.Cells("Descripcion").Value
        chk_afecto_essalud.Checked = IIf(dgv_transacciones.CurrentRow.Cells("AFECTO_REM_ESSALUD").Value.ToString = "S", True, False)
        chk_afecto_afp.Checked = IIf(dgv_transacciones.CurrentRow.Cells("AFECTO_REM_AFP").Value.ToString = "S", True, False)

        txtcuentaAdm.Text = dgv_transacciones.CurrentRow.Cells("Cuenta Adm.").Value
        txtcuentaVta.Text = dgv_transacciones.CurrentRow.Cells("Cuenta Vta.").Value
        txtcuentaProd.Text = dgv_transacciones.CurrentRow.Cells("Cuenta Prod.").Value
        cbo_debe_haber.Text = dgv_transacciones.CurrentRow.Cells("Debe/Haber").Value

        If dgv_transacciones.CurrentRow.Cells("DETALLE_ANEXO").Value = "S" Then
            chk_detalla_anexo.Checked = True
        Else
            chk_detalla_anexo.Checked = False
        End If
        txt_ruc_anexo.Text = dgv_transacciones.CurrentRow.Cells("RUC_ANEXO").Value

        bol_nuevo = False
        cmb_tipo.Enabled = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txt_cod.Enabled = False
        txt_des.Focus()
        Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub

        Try

            If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                transaccionesBL = New ClsOperaciones.Personal_RRHH
                Dim Codigo As String = String.Empty
                Codigo = dgv_transacciones.Item(1, dgv_transacciones.CurrentRow.Index).Value
                If String.IsNullOrEmpty(Codigo) Then Exit Sub
                If transaccionesBL.Eliminacion_Concepto_Variable(Codigo) = True Then
                    MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Exclamation)
                End If
                Cargar_Data()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_tipos.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        'Cargar_Data()
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub cmb_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
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

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub txt_cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_cod.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub txtcuentaVenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaAdm.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaAdm)
    End Sub
    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcuentaVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaAdm.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaAdm)
        End If
    End Sub

    Private Sub txtcuentaVta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaVta.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaVta)
    End Sub

    Private Sub txtcuentaProd_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaProd.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaProd)
    End Sub

    Private Sub txtcuentaVta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaVta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaVta)
        End If
    End Sub

    Private Sub txtcuentaProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaProd.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaProd)
        End If
    End Sub
End Class