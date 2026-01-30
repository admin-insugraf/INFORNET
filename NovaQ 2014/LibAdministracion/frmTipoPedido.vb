Imports System.Windows.Forms
Imports System.Drawing
Imports LibConexion
Public Class frmTipoPedido
    Private ClsUsuario As LibAdministracion.ClsUsuarios
    Private ClsTipoPedido As LibAdministracion.ClsTipoPedido
    Private BOLNuevo As Boolean
    Private dtTipoPedido As DataTable
    Private ClsData As LibConexion.ClsData
    Dim dtdetalles As DataTable
    Dim validado As String = ""

    Private Sub ToolEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolEditar.Click
        Call Editar()
    End Sub
    Private Sub Editar()
        'BOLNuevo = False
        If dgTiposPedido.RowCount = 0 Then Exit Sub
        If dgTiposPedido.SelectedRows.Count = 0 Then Exit Sub
        ClsData = New LibConexion.ClsData
        txtCodigo.Text = dgTiposPedido.Item(0, dgTiposPedido.CurrentRow.Index).Value
        txtDescripcion.Text = dgTiposPedido.Item(1, dgTiposPedido.CurrentRow.Index).Value

        Dim Transacciones As String = String.Empty

        If String.IsNullOrEmpty(dgTiposPedido.Item(2, dgTiposPedido.CurrentRow.Index).Value.ToString) Then
            ActivarCheck(False)
            chklstTransacciones.Enabled = True
        Else
            checkVincularTodos.Checked = False
            Transacciones = dgTiposPedido.Item(2, dgTiposPedido.CurrentRow.Index).Value
            Dim i As Integer = 0
            Dim separators() As String = {",", """", " "}
            Dim value As String = Transacciones
            Dim ArrayTransacciones() As String = value.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            For Each Array In ArrayTransacciones
                Do While i <= chklstTransacciones.Items.Count - 1
                    If TraerCodigo(chklstTransacciones.Items(i)).Trim = Array Then
                        chklstTransacciones.SetItemChecked(i, True)
                        Exit Do
                    End If
                    i = i + 1
                Loop
            Next
        End If
        BOLNuevo = False
        gbTipoPedido.Enabled = True

        txtCodigo.Enabled = False
        pnlPrincipal.Visible = False
        ClsData = Nothing
        Call EstadoBotones()

    End Sub

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        Try
            Dim STRCodIGO As String, STRDescripcion As String
            Dim STRTipoIU As String


            STRCodIGO = txtCodigo.Text.Trim
            STRDescripcion = txtDescripcion.Text.Trim


            If STRCodIGO.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar el código ", "Tipo Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodigo.Focus()
                Exit Sub
            ElseIf STRCodIGO.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar una descripción", "Tipo Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDescripcion.Focus()
                Exit Sub
            End If

            If chklstTransacciones.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos una Transacción", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim idTransaccion As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstTransacciones.CheckedItems.Count - 1
                idTransaccion = idTransaccion & """" & TraerCodigo(chklstTransacciones.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            idTransaccion = Mid(idTransaccion, 1, idTransaccion.Length - 1)



            If BOLNuevo = True Then
                STRTipoIU = "I"
            Else
                STRTipoIU = "U"
            End If

            ClsTipoPedido = New LibAdministracion.ClsTipoPedido
            ClsData = New LibConexion.ClsData
            Dim estado As String
            If BOLNuevo = True Then
                estado = "0"
                If ValidaExiste() = True Then
                    Exit Sub
                End If
            End If
            If ClsTipoPedido.Creacion_Actualizacion_TipoPedido(STRCodIGO, STRDescripcion, idTransaccion, STRTipoIU) = True Then
                If BOLNuevo = True Then
                    MessageBox.Show("Datos guardados correctamente.", "Tipo de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Datos actualizado correctamente.", "Tipo de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No se logró guardar los datos", "Tipo Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClsUsuario = Nothing
            ClsData = Nothing
            Call Cancelar()
            Call EstadoBotones()
            Call CargaTipoPedido()
            pnlPrincipal.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidaExiste() As Boolean
        ClsTipoPedido = New LibAdministracion.ClsTipoPedido
        If ClsTipoPedido.Existe_TipoPedido(txtCodigo.Text.Trim) = True Then
            MessageBox.Show("El codigo de tipo de pedido ya existe, debe elegir otro", "TipoPedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
        ClsUsuario = Nothing
    End Function


    Private Sub MostrandoTansacciones()
        Try
            ClsTipoPedido = New LibAdministracion.ClsTipoPedido
            dtdetalles = New DataTable("TipoPedido")
            dtdetalles = ClsTipoPedido.Get_MostrarTransacciones()
            If dtdetalles.Rows.Count() <> 0 Then
                chklstTransacciones.Items.Clear()
                For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                    chklstTransacciones.Items.Add(dtdetalles.Rows(i).Item("DESCRIPCION").ToString)
                Next
                chklstTransacciones.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTipoPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call InicioForm()
        MostrandoTansacciones()
        ToolGrabar.Enabled = False
        ToolCancelar.Enabled = False
    End Sub


    Private Sub InicioForm()
        ClsTipoPedido = New LibAdministracion.ClsTipoPedido
        gbTipoPedido.Enabled = False

        Call CargaTipoPedido()
    End Sub

    Private Sub CargaTipoPedido()
        dtTipoPedido = New DataTable
        ClsTipoPedido = New LibAdministracion.ClsTipoPedido
        dtTipoPedido = ClsTipoPedido.Lista_Datos_Mantenimientos

        With dgTiposPedido
            .DataSource = dtTipoPedido
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Visible = False

            .Columns(0).HeaderText = "CODIGO"
            .Columns(1).HeaderText = "DESCRIPCION"

            .RowHeadersWidth = 25
        End With
        ClsUsuario = Nothing
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        Call Cancelar()
        Call EstadoBotones()
        BOLNuevo = False
        gbTipoPedido.Enabled = False
        'gbListaUsuario.Enabled = True
        pnlPrincipal.Visible = True
        CargaTipoPedido()
    End Sub
    Private Sub Cancelar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        gbTipoPedido.Enabled = False
        ActivarCheck(False)
        chklstTransacciones.Enabled = True

    End Sub
    Private Sub Nuevo()
        pnlPrincipal.Visible = False
        BOLNuevo = True
        gbTipoPedido.Enabled = True
        txtCodigo.Enabled = True
        checkVincularTodos.Checked = False
        txtCodigo.Focus()
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        Call Nuevo()
        Call EstadoBotones()

    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub txtCodUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If BOLNuevo = True Then
            If ValidaExiste() = True Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dgUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTiposPedido.DoubleClick
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
            Do While i <= chklstTransacciones.Items.Count - 1
                chklstTransacciones.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstTransacciones.Items.Count - 1
                chklstTransacciones.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkVincularTodos.CheckedChanged
        If checkVincularTodos.Checked Then
            ActivarCheck(True)
            chklstTransacciones.Enabled = False
        Else
            ActivarCheck(False)
            chklstTransacciones.Enabled = True
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If dgTiposPedido.Rows.Count() = 0 Then Exit Sub
            If dgTiposPedido.CurrentRow Is Nothing Then Exit Sub
            ClsTipoPedido = New LibAdministracion.ClsTipoPedido
            Dim codigo As String = ""
            codigo = dgTiposPedido.Item(0, dgTiposPedido.CurrentRow.Index).Value
            If codigo = String.Empty Then Exit Sub
            If ClsTipoPedido.Eliminar_TipoPedido(codigo) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Critical)
                CargaTipoPedido()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class