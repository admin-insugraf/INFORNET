Imports System.Windows.Forms
Imports System.Drawing
Imports LibConexion
Public Class frmCrearUsuario
    Private ClsUsuario As LibAdministracion.ClsUsuarios
    Private BOLNuevo As Boolean
    Private dtUsuario As DataTable
    Private dtNivelAcceso As DataTable
    Private ClsData As LibConexion.ClsData
    Dim dtdetalles As DataTable
    Dim validado As String = ""

    Private Sub ToolEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolEditar.Click
        Call Editar()
    End Sub
    Private Sub Editar()
        'BOLNuevo = False
        If dgUsuarios.RowCount = 0 Then Exit Sub
        If dgUsuarios.SelectedRows.Count = 0 Then Exit Sub
        txtPassword.Enabled = False
        txtConfirmaPassword.Enabled = False
        ClsData = New LibConexion.ClsData
        txtCodUsuario.Text = dgUsuarios.Item(0, dgUsuarios.CurrentRow.Index).Value
        txtNombreUsuario.Text = dgUsuarios.Item(1, dgUsuarios.CurrentRow.Index).Value
        txtPassword.Text = ClsData.DesEncryptString(dgUsuarios.Item(2, dgUsuarios.CurrentRow.Index).Value)
        txtConfirmaPassword.Text = ClsData.DesEncryptString(dgUsuarios.Item(2, dgUsuarios.CurrentRow.Index).Value)
        validado = IIf(String.IsNullOrEmpty(dgUsuarios.Item(10, dgUsuarios.CurrentRow.Index).Value.ToString), "", dgUsuarios.Item(10, dgUsuarios.CurrentRow.Index).Value)

        txt_cod_tipo_doc.Text = dgUsuarios.CurrentRow.Cells("TIPO_DOC_DEFECTO").Value
        txt_des_tipo_doc.Text = dgUsuarios.CurrentRow.Cells("NOMBRE_DOC_DEFECTO").Value
        txt_cod_serie_doc.Text = dgUsuarios.CurrentRow.Cells("SERIE_DOC_DEFECTO").Value

        If dgUsuarios.Item(6, dgUsuarios.CurrentRow.Index).Value = "S" Then
            chkEstado.Checked = True
        Else
            chkEstado.Checked = False
        End If

        If dgUsuarios.CurrentRow.Cells("VALIDA_STOCK").Value = "SI" Then
            chk_valida_stock.Checked = True
        Else
            chk_valida_stock.Checked = False
        End If

        If dgUsuarios.CurrentRow.Cells("MANEJO_CARTERA").Value = "SI" Then
            chk_manejo_cartera.Checked = True
        Else
            chk_manejo_cartera.Checked = False
        End If

        If dgUsuarios.CurrentRow.Cells("MODIFICA_NUMERACION_FACT").Value = "SI" Then
            chk_numeracion_fact.Checked = True
        Else
            chk_numeracion_fact.Checked = False
        End If

        If dgUsuarios.CurrentRow.Cells("ACTUALIZA_PE").Value = "SI" Then
            chk_hab_pe.Checked = True
        Else
            chk_hab_pe.Checked = False
        End If

        '-------
        Dim clsUSuario As New LibCobranzas.ClsOperaciones.USUARIO
        Dim NIVEL As String = ""
        NIVEL = clsUSuario.NivelAcceso(LibComunVar.ClsVarComun.USUARIO)

        If NIVEL = "01" Then
            chkpassword.Visible = True
            chkpassword.Checked = False
        Else
            chkpassword.Visible = False
        End If

        cboNivel.SelectedValue = dgUsuarios.Item(7, dgUsuarios.CurrentRow.Index).Value

        If IsDate(dgUsuarios.Item(4, dgUsuarios.CurrentRow.Index).Value) And IsDate(dgUsuarios.Item(5, dgUsuarios.CurrentRow.Index).Value) Then
            chkRangoValidez.Checked = True
            dtpFecInicio.Value = dgUsuarios.Item(4, dgUsuarios.CurrentRow.Index).Value
            dtpFecFinal.Value = dgUsuarios.Item(5, dgUsuarios.CurrentRow.Index).Value
        Else
            chkRangoValidez.Checked = False
        End If

        If Convert.ToString(dgUsuarios.Item(8, dgUsuarios.CurrentRow.Index).Value) = String.Empty Then
            cboPerfil.SelectedIndex = 0
        Else
            cboPerfil.SelectedValue = dgUsuarios.Item(8, dgUsuarios.CurrentRow.Index).Value
        End If
        Dim Almacen As String = String.Empty
        '¨Personal y solicitante
        txtarea.Text = dgUsuarios.Item(11, dgUsuarios.CurrentRow.Index).Value.ToString
        txtdescripcion_area.Text = dgUsuarios.Item(12, dgUsuarios.CurrentRow.Index).Value.ToString

        txtsolicitante.Text = dgUsuarios.Item(13, dgUsuarios.CurrentRow.Index).Value.ToString
        txtdescripcion_solicitante.Text = dgUsuarios.Item(14, dgUsuarios.CurrentRow.Index).Value.ToString
        txtcorreo.Text = dgUsuarios.Item(15, dgUsuarios.CurrentRow.Index).Value.ToString

        If String.IsNullOrEmpty(dgUsuarios.Item(9, dgUsuarios.CurrentRow.Index).Value.ToString) Then
            ActivarCheck(False)
            chklstAlmacenes.Enabled = True
        Else
            checkAlmacen.Checked = False
            Almacen = dgUsuarios.Item(9, dgUsuarios.CurrentRow.Index).Value
            Dim i As Integer = 0
            Dim separators() As String = {",", """", " "}
            Dim value As String = Almacen
            Dim ArrayAlmacen() As String = value.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            For Each Array In ArrayAlmacen
                Do While i <= chklstAlmacenes.Items.Count - 1
                    If TraerCodigo(chklstAlmacenes.Items(i)).Trim = Array Then
                        chklstAlmacenes.SetItemChecked(i, True)
                        Exit Do
                    End If
                    i = i + 1
                Loop
            Next
        End If

        If String.IsNullOrEmpty(dgUsuarios.CurrentRow.Cells("VENDEDORES").Value) Then
            ActivarCheckVendedores(False)
            chklstVendedores.Enabled = True
        Else
            checkVendedores.Checked = False
            Almacen = dgUsuarios.CurrentRow.Cells("VENDEDORES").Value
            Dim i As Integer = 0
            Dim separators() As String = {",", """", " "}
            Dim value As String = Almacen
            Dim ArrayAlmacen() As String = value.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            For Each Array In ArrayAlmacen
                Do While i <= chklstVendedores.Items.Count - 1
                    If TraerCodigo(chklstVendedores.Items(i)).Trim = Array Then
                        chklstVendedores.SetItemChecked(i, True)
                        Exit Do
                    End If
                    i = i + 1
                Loop
            Next
        End If

        BOLNuevo = False
        gbUsuarios.Enabled = True
        chkRangoValidez.Enabled = True
        gbRangoFechas.Enabled = True

        txtCodUsuario.Enabled = False
        'gbListaUsuario.Enabled = False
        pnlPrincipal.Visible = False
        ClsData = Nothing
        Call EstadoBotones()
        ' AjustarTamaño(True)
    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Try
            Dim STRCodUsu As String, STRNomUsu As String
            Dim STRPassUsu As String, STRPassUsuC As String
            Dim STRNivelUsu As String, STRHabUsu As String
            Dim STRFecIniUsu As String, STRFecFinUsu As String
            Dim STRTipoIU, StrCodPerfil As String

            STRCodUsu = txtCodUsuario.Text.Trim
            STRNomUsu = txtNombreUsuario.Text.Trim
            STRPassUsu = txtPassword.Text.Trim
            STRPassUsuC = txtConfirmaPassword.Text.Trim
            If chkEstado.Checked = True Then
                STRHabUsu = "S"
            Else
                STRHabUsu = "N"
            End If
            If chkRangoValidez.Checked = True Then
                STRFecIniUsu = dtpFecInicio.Value
                STRFecFinUsu = dtpFecFinal.Value
            Else
                STRFecIniUsu = Nothing
                STRFecFinUsu = Nothing
            End If
            STRNivelUsu = cboNivel.SelectedValue
            StrCodPerfil = cboPerfil.SelectedValue.ToString

            If STRCodUsu.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el codigo de usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodUsuario.Focus()
                Exit Sub
            ElseIf STRNomUsu.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar una descripción para el usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNombreUsuario.Focus()
                Exit Sub
                ''ElseIf STRPassUsu.Trim.Length = 0 Then
                ''    MessageBox.Show("Debe ingresar una contraseña.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ''    txtPassword.Focus()
                ''    Exit Sub
                ''ElseIf STRPassUsu.Trim <> STRPassUsuC.Trim Then
                ''    MessageBox.Show("Las contraseñas no coinciden.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ''    txtPassword.Focus()
                ''    Exit Sub
            ElseIf cboNivel.SelectedIndex = 0 Then
                MessageBox.Show("Debe elegir el nivel de usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboNivel.Focus()
                Exit Sub
            ElseIf cboPerfil.SelectedIndex = 0 Then
                MessageBox.Show("Debe elegir el Perfil del Usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboPerfil.Focus()
                Exit Sub
            End If
            If chkRangoValidez.Checked = True Then
                If dtpFecInicio.Value > dtpFecFinal.Value Then
                    MessageBox.Show("Error en el rango de validez ingresado.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFecInicio.Focus()
                    Exit Sub
                End If
            End If

            If chklstAlmacenes.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos un Almacen", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim idAlmacen As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                ' idAlmacen = idAlmacen + "'" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & "',"
                idAlmacen = idAlmacen & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)

            Dim idVendedor As String = String.Empty
            Dim j As Integer = 0
            Do While j <= chklstVendedores.CheckedItems.Count - 1
                ' idAlmacen = idAlmacen + "'" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & "',"
                idVendedor = idVendedor & """" & TraerCodigo(chklstVendedores.CheckedItems(j)) & """" & ","
                j = j + 1
            Loop
            If idVendedor.Length > 0 Then
                idVendedor = Mid(idVendedor, 1, idVendedor.Length - 1)
            End If


            If BOLNuevo = True Then
                STRTipoIU = "I"
            Else
                STRTipoIU = "U"
            End If

            ClsUsuario = New LibAdministracion.ClsUsuarios
            ClsData = New LibConexion.ClsData
            Dim estado As String
            If BOLNuevo = True Then
                estado = "0"
                If ValidaExisteUsuario() = True Then
                    Exit Sub
                End If
            Else
                If validado = "0" Then
                    If chkpassword.Checked Then
                        STRPassUsu = "1234"
                        estado = "0"
                    Else
                        estado = "0"
                    End If

                Else
                    If chkpassword.Checked Then
                        STRPassUsu = "1234"
                        estado = "0"
                    Else
                        estado = "1"
                    End If
                End If

            End If
            If ClsUsuario.Creacion_Actualizacion_Usuarios(STRCodUsu, STRNomUsu, ClsData.EncryptString(STRPassUsu), _
                                STRFecIniUsu, STRFecFinUsu, STRHabUsu, cboNivel.SelectedValue, STRTipoIU, StrCodPerfil, idAlmacen, idVendedor, _
                                estado, txtarea.Text, txtsolicitante.Text, txtcorreo.Text, _
                                txt_cod_tipo_doc.Text, txt_cod_serie_doc.Text, IIf(chk_valida_stock.Checked, "SI", "NO"), _
                                IIf(chk_manejo_cartera.Checked, "SI", "NO"), IIf(chk_numeracion_fact.Checked, "SI", "NO"), _
                                IIf(chk_hab_pe.Checked, "SI", "NO")) = True Then
                If BOLNuevo = True Then
                    MessageBox.Show("Datos de usuario guardados correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Datos de usuario actualizado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No se logró guardar los datos del Usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClsUsuario = Nothing
            ClsData = Nothing
            Call Cancelar()
            Call EstadoBotones()
            Call CargaUsuarios()
            pnlPrincipal.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidaExisteUsuario() As Boolean
        ClsUsuario = New LibAdministracion.ClsUsuarios
        If ClsUsuario.Existe_Usuario(txtCodUsuario.Text.Trim) = True Then
            MessageBox.Show("El codigo de usuario ya existe, debe elegir otro.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
        ClsUsuario = Nothing
    End Function

    Private Sub Mostrar_Perfiles()
        Try
            ClsUsuario = New LibAdministracion.ClsUsuarios
            dtdetalles = New DataTable("Perfiles")
            dtdetalles = ClsUsuario.Lista_DatosPerfiles()
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtdetalles.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE)"
            dtdetalles.Rows.InsertAt(row, 0)
            If dtdetalles.Rows.Count() <> 0 Then
                cboPerfil.DataSource = Nothing
                cboPerfil.DataSource = dtdetalles
                cboPerfil.DisplayMember = "DESCRIPCION"
                cboPerfil.ValueMember = "CODIGO"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AjustarTamaño(ByVal opcion As Boolean)
        If opcion = True Then
            Me.Size = New System.Drawing.Size(1045, 360)
        Else
            Me.Size = New System.Drawing.Size(372, 349)
        End If
    End Sub


    Private Sub MostrandoAlmacenes()
        Try
            ClsUsuario = New LibAdministracion.ClsUsuarios
            dtdetalles = New DataTable("Almacenes")
            dtdetalles = ClsUsuario.Get_MostrarAlmacenes()
            If dtdetalles.Rows.Count() <> 0 Then
                chklstAlmacenes.Items.Clear()
                For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtdetalles.Rows(i).Item("DESCRIPCION").ToString)
                Next
                chklstAlmacenes.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCrearUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InicioForm()
        Mostrar_Perfiles()
        MostrandoAlmacenes()
        MostrandoVendedores()
        ToolGrabar.Enabled = False
        ToolCancelar.Enabled = False
    End Sub

    Private Sub MostrandoVendedores()
        Try
            ClsUsuario = New LibAdministracion.ClsUsuarios
            dtdetalles = New DataTable("Vendedores")
            dtdetalles = ClsUsuario.Get_MostrarVendedores()
            If dtdetalles.Rows.Count() <> 0 Then
                chklstVendedores.Items.Clear()
                For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                    chklstVendedores.Items.Add(dtdetalles.Rows(i).Item("DESCRIPCION").ToString)
                Next
                chklstVendedores.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InicioForm()
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtNivelAcceso = ClsUsuario.Niveles_Acceso_Usuarios("")
        'agregando una nueva Fila (Seleccione) --
        Dim row As DataRow = dtNivelAcceso.NewRow()
        row.Item("cod_nivel") = ""
        row.Item("des_nivel") = "(SELECCIONE)"
        dtNivelAcceso.Rows.InsertAt(row, 0)
        cboNivel.DataSource = dtNivelAcceso
        cboNivel.ValueMember = dtNivelAcceso.Columns(0).ToString
        cboNivel.DisplayMember = dtNivelAcceso.Columns(1).ToString
        'cboNivel.SelectedIndex = -1
        gbRangoFechas.Enabled = False
        gbUsuarios.Enabled = False
        chkRangoValidez.Enabled = False
        Call CargaUsuarios()
    End Sub

    

    Private Sub CargaUsuarios()
        dtUsuario = New DataTable
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtUsuario = ClsUsuario.Lista_Datos_Mantenimientos

        With dgUsuarios
            .DataSource = dtUsuario
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns("TIPO_DOC_DEFECTO").Visible = False
            .Columns("NOMBRE_DOC_DEFECTO").Visible = False
            .Columns("SERIE_DOC_DEFECTO").Visible = False
            .Columns("VALIDA_STOCK").Visible = False
            .Columns("MODIFICA_NUMERACION_FACT").Visible = False
            .Columns("VENDEDORES").Visible = False
            .Columns("ACTUALIZA_PE").Visible = False
            .Columns("MANEJO_CARTERA").Visible = False
            .Columns("DES_PERFIL").Visible = True
            .Columns("ESTADO_DESC").Visible = True
            .Columns("DES_PERFIL").HeaderText = "Perfil"
            .Columns("ESTADO_DESC").HeaderText = "Estado"
            .Columns("DES_PERFIL").Width = 250
            .Columns("ESTADO_DESC").Width = 150
            .Columns(15).Width = 350
            .RowHeadersWidth = 25
        End With
        ClsUsuario = Nothing
    End Sub


    Private Sub chkRangoValidez_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRangoValidez.CheckedChanged
        If chkRangoValidez.Checked = True Then
            gbRangoFechas.Enabled = True
        Else
            gbRangoFechas.Enabled = False
        End If
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call Cancelar()
        Call EstadoBotones()
        BOLNuevo = False
        gbUsuarios.Enabled = False
        'gbListaUsuario.Enabled = True
        pnlPrincipal.Visible = True
        CargaUsuarios()
    End Sub
    Private Sub Cancelar()
        txtCodUsuario.Clear()
        txtNombreUsuario.Clear()
        txtPassword.Clear()
        txtConfirmaPassword.Clear()
        chkEstado.Checked = False
        cboNivel.SelectedIndex = 0
        cboPerfil.SelectedIndex = 0
        chkRangoValidez.Checked = False
        gbRangoFechas.Enabled = False
        gbUsuarios.Enabled = False
        chkRangoValidez.Enabled = False
        ActivarCheck(False)
        chklstAlmacenes.Enabled = True

        ActivarCheckVendedores(False)
        chklstVendedores.Enabled = True
    End Sub
    Private Sub Nuevo()
        pnlPrincipal.Visible = False
        BOLNuevo = True
        gbUsuarios.Enabled = True
        chkRangoValidez.Enabled = True
        gbRangoFechas.Enabled = True
        txtCodUsuario.Enabled = True
        txtPassword.Enabled = False
        txtConfirmaPassword.Enabled = False
        txtarea.Text = ""
        txtdescripcion_area.Text = ""
        txtsolicitante.Text = ""
        txtdescripcion_solicitante.Text = ""
        txtCodUsuario.Focus()
        txtcorreo.Text = ""
        txtPassword.Text = "1234"
        txtConfirmaPassword.Text = "1234"
        txt_cod_tipo_doc.Text = ""
        txt_des_tipo_doc.Text = ""
        txt_cod_serie_doc.Text = ""
        chk_valida_stock.Checked = False
        chk_manejo_cartera.Checked = False
        chk_numeracion_fact.Checked = False
        chk_hab_pe.Checked = False
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Call Nuevo()
        Call EstadoBotones()
        chkpassword.Visible = False
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub txtCodUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodUsuario.LostFocus
        If BOLNuevo = True Then
            If ValidaExisteUsuario() = True Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgUsuarios.DoubleClick
        Call Editar()
    End Sub
    Private Sub EstadoBotones()
        ToolNuevo.Enabled = Not ToolNuevo.Enabled
        ToolEditar.Enabled = Not ToolEditar.Enabled
        ToolGrabar.Enabled = Not ToolGrabar.Enabled
        ToolCancelar.Enabled = Not ToolCancelar.Enabled
        btn_eliminar.Enabled = Not btn_eliminar.Enabled
    End Sub


    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub
 
    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        If checkAlmacen.Checked Then
            ActivarCheck(True)
            chklstAlmacenes.Enabled = False
        Else
            ActivarCheck(False)
            chklstAlmacenes.Enabled = True
        End If
    End Sub

    Private Sub cboPerfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPerfil.SelectedIndexChanged

        If cboPerfil.Text = "Administrador" Then
            checkAlmacen.Checked = True
        Else
            checkAlmacen.Checked = False
        End If
    End Sub


    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_AREA"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de areas"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarea.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_area.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtarea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarea.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txtarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarea.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Area()
        End If
    End Sub

    Private Sub Ayuda_Solicitante()
        Try
            If txtarea.Text = "" Then
                MsgBox("Debe seleccionar primero una area.", MsgBoxStyle.Information)
                txtarea.Select()
                Exit Sub
            End If

            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "COMPRAS_SP_S_SOLICITANTE"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txtarea.Text
            frm.Titulo = "Lista de solicitante"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtsolicitante.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcion_solicitante.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsolicitante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtsolicitante.MouseDoubleClick
        Ayuda_Solicitante()
    End Sub

    Private Sub txtsolicitante_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsolicitante.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Solicitante()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If dgUsuarios.Rows.Count() = 0 Then Exit Sub
            If dgUsuarios.CurrentRow Is Nothing Then Exit Sub
            ClsUsuario = New LibAdministracion.ClsUsuarios
            Dim codigo As String = ""
            codigo = dgUsuarios.Item(0, dgUsuarios.CurrentRow.Index).Value
            If codigo = String.Empty Then Exit Sub
            If ClsUsuario.Eliminar_usuario(codigo) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Critical)
                CargaUsuarios()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_tipo_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_tipo_doc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Doc()
        End If
    End Sub
    Private Sub Ayuda_Tipo_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ADM_LISTA_DOCUMENTOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Tipo de Documentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_tipo_doc.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_tipo_doc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_tipo_doc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_tipo_doc.MouseDoubleClick
        Ayuda_Tipo_Doc()
    End Sub

    Private Sub txt_cod_serie_doc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_serie_doc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Serie_Doc()
        End If
    End Sub

    Private Sub Ayuda_Serie_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ADM_LISTA_SERIES_DOCUMENTOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_cod_tipo_doc.Text
            frm.Titulo = "Lista de Series del Documento"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_serie_doc.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_serie_doc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_serie_doc.MouseDoubleClick
        Ayuda_Serie_Doc()
    End Sub

    Private Sub checkVendedores_CheckedChanged(sender As Object, e As EventArgs) Handles checkVendedores.CheckedChanged
        If checkVendedores.Checked Then
            ActivarCheckVendedores(True)
            chklstVendedores.Enabled = False
        Else
            ActivarCheckVendedores(False)
            chklstVendedores.Enabled = True
        End If
    End Sub
    Sub ActivarCheckVendedores(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstVendedores.Items.Count - 1
                chklstVendedores.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstVendedores.Items.Count - 1
                chklstVendedores.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub
End Class