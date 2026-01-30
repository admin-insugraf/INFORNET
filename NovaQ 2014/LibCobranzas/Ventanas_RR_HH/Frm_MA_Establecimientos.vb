Imports System.Windows.Forms
Public Class Frm_MA_Establecimientos
    Dim AreaBl As ClsOperaciones.Personal_RRHH
    Dim Flag_modo_edicion As Boolean = False

    Private Sub Frm_MA_Establecimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        DocumentosPrincipal()
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        pnlcabecera.Visible = False
        blank()
        txtcodigo.Text = Numeracion()
        Flag_modo_edicion = False
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New ClsOperaciones.Personal_RRHH
            CORRELATIVOBL.NumeroCorrelativo_Establecimiento()
            If String.IsNullOrEmpty(CORRELATIVOBL.Correlativo_Establecimiento.ToString) Then
                Correlativo = "0000"
            Else
                Correlativo = String.Format("{0:0000}", CInt(CORRELATIVOBL.Correlativo_Establecimiento + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txtcodigo.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del Concepto.", MsgBoxStyle.Information)
            txtcodigo.Focus()
            Exit Sub
        ElseIf txtdescripcion.Text = String.Empty Then
            MsgBox("Debe ingresar una descripcion.", MsgBoxStyle.Information)
            txtdescripcion.Focus()
            Exit Sub
        End If
        Dim areaEnt As New ClsEntidades.PL_ESTABLISHMENT
        AreaBl = New ClsOperaciones.Personal_RRHH

        areaEnt.ID = txtcodigo.Text
        areaEnt.DESCRIPTION = txtdescripcion.Text

        If Flag_modo_edicion = False Then
            If AreaBl.Guardar_Establecimiento(areaEnt) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If AreaBl.Actualizar_Establecimiento(areaEnt) = True Then
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        End If
        btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Flag_modo_edicion = True
        Dim Codigo As String = String.Empty
        Dim Descripcion As String = String.Empty
        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        Descripcion = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        If String.IsNullOrEmpty(Codigo) Then Exit Sub
        pnlcabecera.Visible = False
        Botonera_Estado_Cambiar(True)
        blank()
        txtcodigo.Text = Codigo
        txtcodigo.Enabled = False
        txtdescripcion.Text = Descripcion
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Try

            If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                AreaBl = New ClsOperaciones.Personal_RRHH
                Dim Codigo As String = String.Empty
                Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
                If String.IsNullOrEmpty(Codigo) Then Exit Sub
                If AreaBl.Eliminacion_Establecimiento(Codigo) = True Then
                    MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Information)
                End If
                DocumentosPrincipal()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(False)
        pnlcabecera.Visible = True
        DocumentosPrincipal()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub

    Private Sub DocumentosPrincipal()
        Try
            AreaBl = New ClsOperaciones.Personal_RRHH
            Dim dtCabecera As New DataTable
            dtCabecera = AreaBl.DocumentoPrincipal_Establecimientos()
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 200
            Else
                'MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub blank()
        txtcodigo.Text = String.Empty
        txtdescripcion.Text = String.Empty
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
End Class