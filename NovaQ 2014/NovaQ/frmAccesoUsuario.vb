
Public Class frmAccesoUsuario
    Private ClsUsuario As LibAdministracion.ClsUsuarios
    Private dtAccesos As DataTable
    Private dtTabla As DataTable
    Private dtPerfiles As DataTable
    Private INTregistros As Integer = 0
    
    Private Sub ConsultaAccesos(ByVal STRCodigo As String)
        dtAccesos = New DataTable
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtAccesos = ClsUsuario.Accesos_Usuario(STRCodigo)
        INTregistros = dtAccesos.Rows.Count
        ClsUsuario = Nothing
    End Sub

    Private Sub ConsultaAccesosPerfil(ByVal STRCodigo As String)
        dtAccesos = New DataTable
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtAccesos.Clear()
        dtAccesos = ClsUsuario.Lista_Perfil_Opcion(STRCodigo)
        INTregistros = dtAccesos.Rows.Count
        ClsUsuario = Nothing
    End Sub

    Private Function MarcaAccesos(ByVal STRName As String) As Boolean
        Dim myRow() As DataRow
        myRow = dtAccesos.Select("COD_OPCION='" & STRName & "'", "COD_OPCION")
        If myRow.Length > 0 Then
            If myRow(0).Item("HABILITADO_SN") = "S" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Sub RecorrerEstructuraMenu(ByVal oMenu As MenuStrip)
        For Each oOpcionMenu As ToolStripMenuItem In oMenu.Items
            Dim nodoPadre As TreeNode = Nothing
            nodoPadre = New TreeNode(oOpcionMenu.Text)
            nodoPadre.Name = oOpcionMenu.Name
            tvAccesos.Nodes.Add(nodoPadre)
            If MarcaAccesos(oOpcionMenu.Name) = True Then
                nodoPadre.Checked = True
            Else
                nodoPadre.Checked = False
            End If
            If oOpcionMenu.DropDownItems.Count > 0 Then
                Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, nodoPadre)
            End If
        Next
    End Sub
    Private Sub RecorrerSubmenu(ByVal oSubmenuItems As ToolStripItemCollection, ByVal Padre As TreeNode)
        For Each oSubitem As ToolStripItem In oSubmenuItems
            If oSubitem.GetType Is GetType(ToolStripMenuItem) Then
                Dim NodoHijo As TreeNode = Nothing
                NodoHijo = Padre.Nodes.Add(oSubitem.Text)
                NodoHijo.Name = oSubitem.Name
                If MarcaAccesos(oSubitem.Name) = True Then
                    NodoHijo.Checked = True
                Else
                    NodoHijo.Checked = False
                End If
                If CType(oSubitem, ToolStripMenuItem).DropDownItems.Count > 0 Then
                    Me.RecorrerSubmenu(CType(oSubitem, ToolStripMenuItem).DropDownItems, NodoHijo)
                End If
            End If
        Next
    End Sub

    Private Sub frmAccesosUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaUsuarios()
        Call CargaPerfiles()
    End Sub
    Private Sub CargaPerfiles()
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtPerfiles = ClsUsuario.Lista_Perfiles
        cboPerfil.DataSource = dtPerfiles
        cboPerfil.ValueMember = dtPerfiles.Columns(0).ToString
        cboPerfil.DisplayMember = dtPerfiles.Columns(1).ToString
        cboPerfil.SelectedIndex = -1
        ClsUsuario = Nothing
    End Sub
    Private Sub CargaUsuarios()
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtTabla = ClsUsuario.Lista_Usuarios("", "")
        cboUsuario.DataSource = dtTabla
        cboUsuario.ValueMember = dtTabla.Columns(0).ToString
        cboUsuario.DisplayMember = dtTabla.Columns(1).ToString
        cboUsuario.SelectedIndex = -1
        ClsUsuario = Nothing
    End Sub

    Private Sub tvAccesos_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvAccesos.AfterCheck
        Dim myRow() As DataRow
        Dim STRVisible As String
        If e.Node.Checked = True Then
            STRVisible = "S"
        Else
            STRVisible = "N"
        End If
        myRow = dtAccesos.Select("COD_OPCION='" & e.Node.Name & "'", "COD_OPCION")
        If myRow.Length > 0 Then
            myRow(0).Item("HABILITADO_SN") = STRVisible
        End If
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call Cancelar()
    End Sub
    Private Sub Cancelar()
        cboUsuario.Enabled = True
        cboUsuario.SelectedIndex = -1
        cboPerfil.SelectedIndex = -1
        tvAccesos.Nodes.Clear()
        dtAccesos.Clear()
    End Sub
    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        If cboUsuario.SelectedValue = "" Then
            MessageBox.Show("Debe elegir un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboUsuario.Enabled = True
            cboUsuario.Focus()
            Exit Sub
        ElseIf cboPerfil.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir un perfil para el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboPerfil.Focus()
        End If

        If MessageBox.Show("¿Desea guardar los accesos para el usuario " & cboUsuario.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClsUsuario = New LibAdministracion.ClsUsuarios

            Array.ForEach(dtAccesos.AsEnumerable.ToArray,
                        Sub(row As DataRow) row("codperfil") = cboUsuario.SelectedValue)
            If ClsUsuario.GuardarPermisos(dtAccesos, cboUsuario.SelectedValue) = True Then
                MessageBox.Show("Accesos guardados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Cancelar()
            Else
                MessageBox.Show("Ocurrió un error al grabar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClsUsuario = Nothing
        End If
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        ClsUsuario = Nothing
        Me.Close()
    End Sub

    Private Sub cboPerfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPerfil.SelectedIndexChanged
        If cboUsuario.SelectedValue <> "" Then
            tvAccesos.Nodes.Clear()
            INTregistros = 0
            'Call ConsultaAccesos(cboUsuario.SelectedValue)
            Call ConsultaAccesosPerfil(cboPerfil.SelectedValue)
            If INTregistros > 0 Then
                Call RecorrerEstructuraMenu(frmMenu.MnuPrin)
                tvAccesos.ExpandAll()
                cboUsuario.Enabled = False
            End If
        
        End If
    End Sub
End Class