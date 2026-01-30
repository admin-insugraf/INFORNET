Imports System.Windows.Forms

Public Class frmPerfilesUsuario
    Private dtAccesos As DataTable
    Private dtPerfiles As DataTable
    Private objMenu As MenuStrip
    Private ClsUsuario As LibAdministracion.ClsUsuarios
    Private INTregistros As Integer = 0
    Private BOLNuevo As Boolean

    Public Property MenuPrincipal As MenuStrip
        Get
            Return objMenu
        End Get
        Set(value As MenuStrip)
            objMenu = value
        End Set
    End Property
    Private Sub frmPerfilesUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ToolGrabar.Enabled = False
        ToolCancelar.Enabled = False
        tcPerfiles.TabPages.Remove(tpAccesos)
        MuestraPerfiles()
    End Sub

    Private Sub MuestraPerfiles()
        dtPerfiles = New DataTable
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtPerfiles = ClsUsuario.Lista_Perfiles
        dgwPerfiles.DataSource = dtPerfiles
        dgwPerfiles.AutoResizeColumns()
        dgwPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgwPerfiles.Columns(0).HeaderText = "Cod. Perfil"
        dgwPerfiles.Columns(1).HeaderText = "Descripción Perfil"
        dgwPerfiles.Columns(2).HeaderText = "Habilitado"
        ClsUsuario = Nothing
    End Sub
    Private Sub ConsultaAccesos(ByVal STRCodigo As String)
        dtAccesos = New DataTable
        dtAccesos.Clear()
        ClsUsuario = New LibAdministracion.ClsUsuarios
        dtAccesos = ClsUsuario.Lista_Perfil_Opcion(STRCodigo)
        INTregistros = dtAccesos.Rows.Count
        ClsUsuario = Nothing
    End Sub
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


    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New ClsTransacciones.PERFIL
            CORRELATIVOBL.NumeroCorrelativoPerfil()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = String.Format("{0:0000000000}", 1)
            Else
                Correlativo = String.Format("{0:0000000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub ToolNuevo_Click(sender As Object, e As EventArgs) Handles ToolNuevo.Click
        BOLNuevo = True
        tcPerfiles.TabPages.Insert(1, tpAccesos)
        tcPerfiles.SelectTab(1)
        tcPerfiles.TabPages.Remove(tpListaPerfil)
        ToolNuevo.Enabled = False
        ToolGrabar.Enabled = True
        ToolEditar.Enabled = False
        ToolCancelar.Enabled = True
        Call ConsultaAccesos("")
        Call RecorrerEstructuraMenu(MenuPrincipal)
        tvAccesos.ExpandAll()
        txtCodPerfil.Focus()
        txtCodPerfil.Text = Numeracion()
    End Sub

    Private Sub tvAccesos_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvAccesos.AfterCheck
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


    Private Sub ToolEditar_Click(sender As Object, e As EventArgs) Handles ToolEditar.Click
        If dgwPerfiles.SelectedRows.Count > 0 Then
            BOLNuevo = False
            tcPerfiles.TabPages.Insert(1, tpAccesos)
            tcPerfiles.SelectTab(1)
            tcPerfiles.TabPages.Remove(tpListaPerfil)
            txtCodPerfil.Text = dgwPerfiles.Rows(dgwPerfiles.CurrentRow.Index).Cells(0).Value
            txtDesPerfil.Text = dgwPerfiles.Rows(dgwPerfiles.CurrentRow.Index).Cells(1).Value
            If dgwPerfiles.Rows(dgwPerfiles.CurrentRow.Index).Cells(2).Value = "S" Then
                cbHabilitado.SelectedIndex = 0
            Else
                cbHabilitado.SelectedIndex = 1
            End If
            Call ConsultaAccesos(txtCodPerfil.Text)
            Call RecorrerEstructuraMenu(MenuPrincipal)
            tvAccesos.ExpandAll()
            ToolNuevo.Enabled = False
            ToolGrabar.Enabled = True
            ToolEditar.Enabled = False
            ToolCancelar.Enabled = True
        Else
            MessageBox.Show("No ha seleccionado ningún perfil para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub

    Private Sub ToolGrabar_Click(sender As Object, e As EventArgs) Handles ToolGrabar.Click
        If txtCodPerfil.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar el código de perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodPerfil.Focus()
            Exit Sub
        ElseIf txtDesPerfil.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar la descripción de perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDesPerfil.Focus()
            Exit Sub
        ElseIf cbHabilitado.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir el estado del perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbHabilitado.Focus()
            Exit Sub
        End If

        Dim STRInsUpd As String = String.Empty
        Dim STREstado As String = String.Empty

        If BOLNuevo = True Then
            STRInsUpd = "I"
        Else
            STRInsUpd = "U"
        End If

        If cbHabilitado.SelectedIndex = 0 Then
            STREstado = "S"
        Else
            STREstado = "N"
        End If


        If BOLNuevo = True Then
            'Actualizo el datatable con el perfil a crear
            Array.ForEach(dtAccesos.AsEnumerable.ToArray,
                        Sub(row As DataRow) row("codperfil") = txtCodPerfil.Text.Trim)
        End If

        ClsUsuario = New LibAdministracion.ClsUsuarios

        If ClsUsuario.GuardaPerfil(txtCodPerfil.Text.Trim, txtDesPerfil.Text.Trim, "", STREstado, STRInsUpd, dtAccesos) = True Then
            MessageBox.Show("Se guardó el perfil correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ToolCancelar_Click(sender, e)
        End If

        ClsUsuario = Nothing
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Dim n As TreeNode
        If chkTodos.Checked = True Then
            For Each n In tvAccesos.Nodes
                n.Checked = True
                Call MarcarAll(n, True)
            Next
        Else
            For Each n In tvAccesos.Nodes
                n.Checked = False
                Call MarcarAll(n, False)
            Next
        End If
    End Sub

    Private Sub MarcarAll(treeNode As TreeNode, nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                Me.MarcarAll(node, nodeChecked)
            End If
        Next node
    End Sub

    Private Sub ToolSalir_Click(sender As Object, e As EventArgs) Handles ToolSalir.Click
        ClsUsuario = Nothing
        Me.Close()
    End Sub

    Private Sub ToolCancelar_Click(sender As Object, e As EventArgs) Handles ToolCancelar.Click
        txtCodPerfil.Clear()
        txtDesPerfil.Clear()
        cbHabilitado.SelectedIndex = -1
        tvAccesos.Nodes.Clear()
        tcPerfiles.TabPages.Remove(tpAccesos)
        tcPerfiles.TabPages.Insert(0, tpListaPerfil)
        tcPerfiles.SelectTab(0)
        ToolGrabar.Enabled = False
        ToolCancelar.Enabled = False
        ToolNuevo.Enabled = True
        ToolEditar.Enabled = True
        MuestraPerfiles()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgwPerfiles.Rows.Count() = 0 Then Exit Sub
        If dgwPerfiles.CurrentRow Is Nothing Then Exit Sub
        Try
            Dim PerfilBl As ClsBuscar
            PerfilBl = New ClsBuscar
            Dim dtperfil As New DataTable
            Dim Cod_perfil As String = ""
            Cod_perfil = dgwPerfiles.Item(0, dgwPerfiles.CurrentRow.Index).Value
            dtperfil = PerfilBl.ConsultaPerfil(Cod_perfil)
            If dtperfil.Rows.Count() <> 0 Then
                MsgBox("No se puede eliminar el perfil, por que se encuentra asociado a un usuario, elimine el usuario para poder continuar.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If MessageBox.Show("Se va a eliminar el perfil" & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    PerfilBl = New ClsBuscar
                    If PerfilBl.Eliminar_Perfil(Cod_perfil) = True Then
                        MsgBox("Eliminado exitosamente.", MsgBoxStyle.Information)
                        MuestraPerfiles()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class