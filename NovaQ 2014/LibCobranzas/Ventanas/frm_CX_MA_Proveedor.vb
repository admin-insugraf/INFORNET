Imports System.Windows.Forms
Imports System.Net
Imports Newtonsoft.Json.Linq


Public Class frm_CX_MA_Proveedor
    Dim bol_nuevo As Boolean = False
    Dim dttable As DataTable
    Dim LibData As LibConexion.ClsData
    Private clsLetrasBl As ClsNegocio.PART
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

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


    Private Sub frm_CX_MA_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Data()
        Call Cargar_TipoDoc()
        Call Cargar_TipoCompania()
        Botonera_Estado_Cambiar(False)

    End Sub

    Private Sub Cargar_Data()
        Dim vendorBL As New LibCobranzas.ClsOperaciones.VENDOR
        dtv = New DataView
        dtv = vendorBL.Proveedores().DefaultView
        dgv_proveedor.DataSource = dtv
        For i = 4 To 12 'dgv_proveedor.ColumnCount() - 1
            dgv_proveedor.Columns(i).Visible = False
        Next
        dgv_proveedor.Columns(0).Width = 100
        dgv_proveedor.Columns(1).Width = 300
        dgv_proveedor.Columns(2).Width = 100
        dgv_proveedor.Columns(3).Width = 400
        dgv_proveedor.Columns(0).HeaderText = "Codigo"
        dgv_proveedor.Columns(1).HeaderText = "Descripcion"
        dgv_proveedor.Columns(2).HeaderText = "RUC"
        dgv_proveedor.Columns(3).HeaderText = "Dirección"
        dgv_proveedor.Columns(13).HeaderText = "País"
        dgv_proveedor.Columns(14).HeaderText = "Apellido Paterno"
        dgv_proveedor.Columns(15).HeaderText = "Apellido Materno"
        dgv_proveedor.Columns(16).HeaderText = "Primer Nombre"
        dgv_proveedor.Columns(17).HeaderText = "Segundo Nombre"
        dgv_proveedor.Columns(14).Width = 150
        dgv_proveedor.Columns(15).Width = 150
        dgv_proveedor.Columns(16).Width = 150
        dgv_proveedor.Columns(17).Width = 150
        dgv_proveedor.Columns(18).HeaderText = "Tipo de Documento"
        dgv_proveedor.Columns(19).HeaderText = "Tipo de Empresa"
        dgv_proveedor.Columns(18).Width = 250
        dgv_proveedor.Columns(19).Width = 250
        STRorden = dgv_proveedor.Columns(0).Name & "+" & dgv_proveedor.Columns(1).Name
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        vendorBL = Nothing
    End Sub

    Private Sub Cargar_TipoDoc()
        Dim tipoDocBL As New ClsOperaciones.DOCUMENT_TYPE_PERSON
        cmb_td.DataSource = tipoDocBL.get_Documentos()
        cmb_td.DisplayMember = "DESCRIPTION"
        cmb_td.ValueMember = "DOCUMENT_TYPE_ID"
        tipoDocBL = Nothing
    End Sub

    Private Sub Cargar_TipoCompania()
        Dim companiaBL As New ClsOperaciones.COMPANY_TYPE
        cmb_tc.DataSource = companiaBL.get_TiposCompanis()
        cmb_tc.DisplayMember = "DESCRIPTION"
        cmb_tc.ValueMember = "COMPANY_TYPE_ID"
        companiaBL = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        tc_proveedor.SelectedIndex = 1
        gb_data.Enabled = True
        bol_nuevo = True
        txt_cod.Enabled = True
        txt_cod.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If txt_cod.Text.Trim = "" Then
            MsgBox("Debe ingresar un codigo.", MsgBoxStyle.Critical, "Sistemas")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            MsgBox("Debe ingresar la Razón Social.", MsgBoxStyle.Critical, "Sistemas")
            txt_des.Focus()
            Exit Sub
        End If

        If txt_dir.Text.Trim = "" Then
            MsgBox("Debe ingresar la dirección.", MsgBoxStyle.Critical, "Sistemas")
            txt_dir.Focus()
            Exit Sub
        End If

        If txt_cod_departamento.Text.Trim = "" Then
            MsgBox("Debe elegir un departamento.", MsgBoxStyle.Critical, "Sistemas")
            txt_cod_departamento.Focus()
            Exit Sub
        End If
        If txt_cod_provincia.Text.Trim = "" Then
            MsgBox("Debe elegir una provincia.", MsgBoxStyle.Critical, "Sistemas")
            txt_cod_provincia.Focus()
            Exit Sub
        End If
        If txt_cod_distrito.Text.Trim = "" Then
            MsgBox("Debe elegir un distrito.", MsgBoxStyle.Critical, "Sistemas")
            txt_cod_distrito.Focus()
            Exit Sub
        End If

        If cmb_td.SelectedIndex = -1 Then
            MsgBox("Debe ingresar un Tipo de documento.", MsgBoxStyle.Critical, "Sistemas")
            cmb_td.Focus()
            Exit Sub
        End If
        If cmb_tc.SelectedIndex = -1 Then
            MsgBox("Debe ingresar un Tipo de compañia.", MsgBoxStyle.Critical, "Sistemas")
            cmb_tc.Focus()
            Exit Sub
        End If
        If txt_ruc.Text = "" Then
            MsgBox("Debe ingresar el nro de Ruc")
            txt_ruc.Select()
            Exit Sub
        End If
        If cmb_td.SelectedValue = "01" Then
            If txt_cod.Text.Length <> 8 Then
                MsgBox("El codigo ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
            If txt_ruc.Text.Length <> 8 Then
                MsgBox("El DNI ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                txt_ruc.Focus()
                Exit Sub
            End If
            If txt_ap_paterno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Paterno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_paterno.Focus()
                Exit Sub
            End If
            If txt_ap_materno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Materno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_materno.Focus()
                Exit Sub
            End If
            If txt_primer_nombre.Text.Trim = "" Then
                MsgBox("Debe ingresar el Primer Nombre.", MsgBoxStyle.Critical, "Sistemas")
                txt_primer_nombre.Focus()
                Exit Sub
            End If
        Else
            If txt_cod.Text.Length <> 11 Then
                MsgBox("El codigo ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
            If txt_ruc.Text.Length <> 11 Then
                MsgBox("El RUC ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                txt_cod.Focus()
                Exit Sub
            End If
        End If

        If cmb_tc.SelectedValue = "01" Or cmb_tc.SelectedValue = "02" Then
            If txt_ap_paterno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Paterno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_paterno.Focus()
                Exit Sub
            End If
            If txt_ap_materno.Text.Trim = "" Then
                MsgBox("Debe ingresar el Apellido Materno.", MsgBoxStyle.Critical, "Sistemas")
                txt_ap_materno.Focus()
                Exit Sub
            End If
            If txt_primer_nombre.Text.Trim = "" Then
                MsgBox("Debe ingresar el Primer Nombre.", MsgBoxStyle.Critical, "Sistemas")
                txt_primer_nombre.Focus()
                Exit Sub
            End If
        End If
        If Trim(txt_ruc.Text) <> Trim(txt_cod.Text) Then
            MsgBox("El RUC y codigo ingresado son diferentes, deben ser el el mismo dato.!", MsgBoxStyle.Critical)
            txt_cod.Focus()
            Exit Sub
        End If
        If bol_nuevo = True Then
            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor_Ruc(txt_ruc.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El RUC ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_ruc.Focus()
                Exit Sub
            End If
        End If
        Dim proveedorBL As New ClsOperaciones.VENDOR
        Dim proveedorBE As New ClsEntidades.VENDOR

        With proveedorBE
            .ID = txt_cod.Text.Trim
            .NAME = txt_des.Text.Trim
            .VAT_REGISTRATION = txt_ruc.Text.Trim
            .ADDR = txt_dir.Text.Trim
            .PHONE = txt_tel.Text.Trim
            .EMAIL = txt_mail.Text.Trim
            .WEBSITE = txt_web.Text.Trim
            .CONTACT = txt_contacto.Text.Trim
            .DOCUMENT_TYPE_PERSON_ID = cmb_td.SelectedValue
            .TYPE_COMPANY = cmb_tc.SelectedValue
            .ACCOUNT_LOCAL = txtcuentaContableSol.Text.Trim
            .ACCOUNT_EXTERNAL = txtcuentaContableDol.Text.Trim
            .USER = LibComunVar.ClsVarComun.USUARIO
            .CREATE_DATE = Date.Now
            .PAIS = txt_cod_pais.Text.Trim

            .AP_PATERNO = txt_ap_paterno.Text.Trim
            .AP_MATERNO = txt_ap_materno.Text.Trim
            .PRIMER_NOMBRE = txt_primer_nombre.Text.Trim
            .SEGUNDO_NOMBRE = txt_segundo_nombre.Text.Trim

            .COD_DEPARTAMENTO = txt_cod_departamento.Text
            .COD_PROVINCIA = txt_cod_provincia.Text
            .COD_DISTRITO = txt_cod_distrito.Text
        End With

        If bol_nuevo Then
            If proveedorBL.Insert(proveedorBE) Then
                Call Cargar_Data()
                Call Avisar("Proceso generado correctamente!")

                proveedorBE = Nothing
                proveedorBL = Nothing

                Call btn_cancelar_Click(sender, e)
            End If
        Else
            If proveedorBL.Update(proveedorBE) Then
                Call Cargar_Data()
                Call Avisar("Proceso generado correctamente!")

                proveedorBE = Nothing
                proveedorBL = Nothing

                Call btn_cancelar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click

        If dgv_proveedor.Rows.Count = 0 Then Exit Sub
        If dgv_proveedor.CurrentRow Is Nothing Then Exit Sub

        Try
            txt_cod.Text = dgv_proveedor.CurrentRow.Cells(0).Value
            txt_des.Text = dgv_proveedor.CurrentRow.Cells(1).Value
            txt_ruc.Text = dgv_proveedor.CurrentRow.Cells(2).Value
            txt_dir.Text = dgv_proveedor.CurrentRow.Cells(3).Value
            txt_tel.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(4).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(4).Value)
            txt_mail.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(5).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(5).Value)
            txt_web.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(6).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(6).Value)
            txt_contacto.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(7).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(7).Value)
            cmb_td.SelectedValue = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(8).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(8).Value)
            cmb_tc.SelectedValue = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(9).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(9).Value)
            txtcuentaContableSol.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(10).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(10).Value)
            txtcuentaContableDol.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(11).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(11).Value)

            txt_cod_pais.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(12).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(12).Value)
            txt_des_pais.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(13).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(13).Value)

            txt_ap_paterno.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(14).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(14).Value)
            txt_ap_materno.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(15).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(15).Value)
            txt_primer_nombre.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(16).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(16).Value)
            txt_segundo_nombre.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells(17).Value.ToString), "", dgv_proveedor.CurrentRow.Cells(17).Value)

            txt_cod_departamento.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("COD_DEPARTAMENTO").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("COD_DEPARTAMENTO").Value)
            txt_des_departamento.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("DEPARTAMENTO").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("DEPARTAMENTO").Value)

            txt_cod_provincia.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("COD_PROVINCIA").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("COD_PROVINCIA").Value)
            txt_des_provincia.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("PROVINCIA").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("PROVINCIA").Value)

            txt_cod_distrito.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("COD_DISTRITO").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("COD_DISTRITO").Value)
            txt_des_distrito.Text = IIf(String.IsNullOrEmpty(dgv_proveedor.CurrentRow.Cells("DISTRITO").Value.ToString), "", dgv_proveedor.CurrentRow.Cells("DISTRITO").Value)


            bol_nuevo = False
            txt_cod.Enabled = False
            gb_data.Enabled = True
            tc_proveedor.SelectedIndex = 1
            txt_cod.Enabled = False
            txt_des.Focus()
            Botonera_Estado_Cambiar(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_proveedor.Rows.Count = 0 Then Exit Sub
        If dgv_proveedor.CurrentRow Is Nothing Then Exit Sub

        If String.IsNullOrEmpty(dgv_proveedor.Item(0, dgv_proveedor.CurrentRow.Index).Value) Then
            Exit Sub
        End If

        Dim dtproveedor As DataTable
        clsLetrasBl = New ClsNegocio.PART
        dtproveedor = New DataTable("Proveedores")
        dtproveedor = clsLetrasBl.ValidarMovimientos_Proveedor(dgv_proveedor.Item(0, dgv_proveedor.CurrentRow.Index).Value)
        If dtproveedor.Rows().Count() > 0 Then
            MsgBox("El RUC ingresado tiene movimientos en Compras." & Chr(13) & "No se puede eliminar!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Preguntar("Seguro de eliminar el Proveedor?") Then
            Dim proveedorBL As New ClsOperaciones.VENDOR
            Dim proveedorBE As New ClsEntidades.VENDOR

            proveedorBE.ID = dgv_proveedor.Item(0, dgv_proveedor.CurrentRow.Index).Value
            If proveedorBL.Delete(proveedorBE) Then
                proveedorBE = Nothing
                proveedorBL = Nothing
                Call Avisar("Listo!")
                Call Cargar_Data()
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_proveedor.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                If cmb_td.SelectedValue = "01" Then
                    If txt_cod.Text.Length <> 8 Then
                        MsgBox("El codigo ingresado debe tener 8 caracteres!", MsgBoxStyle.Critical)
                        txt_cod.Focus()
                    Else
                        SendKeys.Send(vbTab)
                    End If
                Else
                    If txt_cod.Text.Length <> 11 Then
                        MsgBox("El codigo ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                        txt_cod.Focus()
                    Else
                        SendKeys.Send(vbTab)
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub cmb_td_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_td.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_tc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor_Ruc(txt_ruc.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El RUC ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_ruc.Focus()
            Else
                If txt_ruc.Text.Length <> 11 Then
                    MsgBox("El RUC ingresado debe tener 11 caracteres!", MsgBoxStyle.Critical)
                    txt_ruc.Focus()
                Else
                    SendKeys.Send(vbTab)
                End If
            End If
        End If
    End Sub

    Private Sub txt_dir_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dir.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_departamento.Focus()
        End If
    End Sub

    Private Sub txt_tel_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tel.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_mail_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mail.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_web_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_web.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_contacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cta_loc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cta_ext_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgv_proveedor.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgv_proveedor.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgv_proveedor.Columns(0).Name & "+" & dgv_proveedor.Columns(1).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
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

    Private Sub txtcuentaContableSol_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaContableSol.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaContableSol)
    End Sub

    Private Sub txtcuentaContableSol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaContableSol.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ayuda_CuentasContables(txtcuentaContableSol)
        End If
    End Sub

    Private Sub txtcuentaContableDol_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaContableDol.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaContableDol)
    End Sub

    Private Sub txtcuentaContableDol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaContableDol.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ayuda_CuentasContables(txtcuentaContableDol)
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Private Sub txt_cod_pais_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_pais.MouseDoubleClick
        Ayuda_Pais(txt_cod_pais, txt_des_pais)
    End Sub

    Private Sub txt_cod_pais_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_pais.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ayuda_Pais(txt_cod_pais, txt_des_pais)
        End If
    End Sub


    Private Sub Ayuda_Pais(ByVal CajaTexto As TextBox, ByVal CajaTexto_Des As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_PAISES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Paises"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                CajaTexto_Des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_cod.Text)) = 11 Then
                cmb_td.SelectedValue = "06"
            ElseIf Len(Strings.Trim(txt_cod.Text)) = 8 Then
                Me.Cursor = Cursors.Default
                MsgBox("RUC incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Proveedor debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            End If

            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                Verifica_WS(txt_cod.Text)
                txt_cod.Focus()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Verifica_WS(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/ruc?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_des.Text = JObject.Parse(data)("nombre")
            txt_dir.Text = JObject.Parse(data)("direccion")
            txt_ruc.Text = _ruc

            MsgBox("Estado: " & JObject.Parse(data)("estado").ToString & vbCrLf & "Condición: " & JObject.Parse(data)("condicion").ToString, MsgBoxStyle.Information, "Aviso")


            Dim dt_ubigeo As DataTable
            dt_ubigeo = New DataTable
            Dim clsFacturaCabBl As LibCobranzas.ClsOperaciones.RECEIVABLE
            clsFacturaCabBl = New ClsOperaciones.RECEIVABLE
            Dim _cod_dep, _cod_prov, _cod_dis As String

            _cod_dep = Strings.Left(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Departamento(_cod_dep, "", "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("DEPARTAMENTO")
            Else
                txt_dir.Text = txt_dir.Text
            End If

            _cod_prov = Strings.Mid(JObject.Parse(data)("ubigeo"), 3, 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Provincia(_cod_dep, _cod_prov, "")
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("PROVINCIA")
            Else
                txt_dir.Text = txt_dir.Text
            End If

            _cod_dis = Strings.Right(JObject.Parse(data)("ubigeo"), 2)
            dt_ubigeo = clsFacturaCabBl.get_Nombre_Distrito(_cod_dep, _cod_prov, _cod_dis)
            If dt_ubigeo.Rows.Count > 0 Then
                txt_dir.Text = txt_dir.Text & " " & dt_ubigeo.Rows(0).Item("DISTRITO")
            Else
                txt_dir.Text = txt_dir.Text
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Len(Strings.Trim(txt_cod.Text)) = 11 Then
                Me.Cursor = Cursors.Default
                MsgBox("DNI incorrecto. Verifique", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            ElseIf Len(Strings.Trim(txt_cod.Text)) = 8 Then
                cmb_td.SelectedValue = "01"
            Else
                Me.Cursor = Cursors.Default
                MsgBox("El Código de Cliente debe tener 8 caracteres.", MsgBoxStyle.Exclamation)
                txt_cod.Focus()
                Exit Sub
            End If

            Dim dtproveedor As DataTable
            clsLetrasBl = New ClsNegocio.PART
            dtproveedor = New DataTable("Proveedores")
            dtproveedor = clsLetrasBl.ValidarProveedor(txt_cod.Text)
            If dtproveedor.Rows().Count() > 0 Then
                MsgBox("El codigo ingresado del Proveedor ya existe!", MsgBoxStyle.Critical)
                txt_cod.Focus()
            Else
                Verifica_WS_DNI(txt_cod.Text)
                txt_des.Focus()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Verifica_WS_DNI(ByVal _ruc As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim url As String = "https://api.apis.net.pe/v1/dni?numero=" & _ruc
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            request.UserAgent = "Test"


            Dim response As HttpWebResponse = request.GetResponse
            Dim responseStream As System.IO.Stream = response.GetResponseStream

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd
            streamReader.Close()

            txt_des.Text = JObject.Parse(data)("nombre")
            txt_dir.Text = ""
            txt_ruc.Text = _ruc

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_cod_departamento_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_departamento.MouseDoubleClick
        Cargar_Departamento_direc_entrega()
    End Sub

    Private Sub txt_cod_departamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_departamento.KeyDown
        If e.KeyCode = Keys.F1 Then
            Cargar_Departamento_direc_entrega()
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_cod_departamento.Text = "" Then
                Cargar_Departamento_direc_entrega()
            Else
                txt_cod_provincia.Focus()
            End If
        End If
    End Sub

    Private Sub Cargar_Departamento_direc_entrega()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'departamento
                txt_cod_departamento.Text = String.Empty
                txt_des_departamento.Text = String.Empty
                'provincia
                txt_cod_provincia.Text = String.Empty
                txt_des_provincia.Text = String.Empty
                'distrito
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty

                ''datos del departamento
                txt_cod_departamento.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_departamento.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                txt_cod_provincia.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_provincia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_provincia.MouseDoubleClick
        Cargar_Provincia_direcc_entrega()
    End Sub

    Private Sub txt_cod_provincia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_provincia.KeyDown
        If e.KeyCode = Keys.F1 Then
            Cargar_Provincia_direcc_entrega()
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_cod_provincia.Text = "" Then
                Cargar_Provincia_direcc_entrega()
            Else
                txt_cod_distrito.Focus()
            End If
        End If
    End Sub

    Private Sub Cargar_Provincia_direcc_entrega()
        Try
            If bol_nuevo = True Then
                If String.IsNullOrEmpty(txt_cod_departamento.Text) Then
                    MsgBox("Es necesario elegir un Departamento", MsgBoxStyle.Information)
                    txt_cod_departamento.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_departamento.Text
            frm.Titulo = "Provincias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'provincia
                txt_cod_provincia.Text = String.Empty
                txt_des_provincia.Text = String.Empty
                'distrito
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty
                txt_cod_provincia.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_provincia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_cod_distrito.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_distrito_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_distrito.MouseDoubleClick
        Cargar_Distrito_direc_entrega()
    End Sub

    Private Sub txt_cod_distrito_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_distrito.KeyDown
        If e.KeyCode = Keys.F1 Then
            Cargar_Distrito_direc_entrega()
        End If
    End Sub

    Private Sub Cargar_Distrito_direc_entrega()
        Try
            If String.IsNullOrEmpty(txt_cod_departamento.Text) Then
                MsgBox("No hay codigo de departamento", MsgBoxStyle.Information)
                txt_cod_departamento.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(txt_cod_provincia.Text) Then
                MsgBox("Es necesario elegir una Provincia", MsgBoxStyle.Information)
                txt_cod_provincia.Focus()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_departamento.Text
            frm.Filtros2 = txt_cod_provincia.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_distrito.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                txt_des_distrito.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
                txt_cod_pais.Focus()
            Else
                txt_cod_distrito.Text = String.Empty
                txt_des_distrito.Text = String.Empty
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class