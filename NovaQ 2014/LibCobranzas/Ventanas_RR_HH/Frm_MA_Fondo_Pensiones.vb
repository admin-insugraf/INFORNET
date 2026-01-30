Imports System.Windows.Forms
Public Class Frm_MA_Fondo_Pensiones
    Dim AreaBl As ClsOperaciones.Personal_RRHH
    Dim Flag_modo_edicion As Boolean = False

    Private Sub Frm_MA_Fondo_Pensiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        DocumentosPrincipal()
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        pnlcabecera.Visible = False
        blank()
        txtcodigo.Enabled = True
        txtcodigo.Focus()
        Flag_modo_edicion = False

    End Sub


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txtcodigo.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del Fondo de Pensiones.", MsgBoxStyle.Exclamation)
            txtcodigo.Focus()
            Exit Sub
        ElseIf txt_ruc.Text = String.Empty Then
            MsgBox("Debe ingresar el RUC del Fondo de Pensiones.", MsgBoxStyle.Exclamation)
            txt_ruc.Focus()
            Exit Sub
        ElseIf txtdescripcion.Text = String.Empty Then
            MsgBox("Debe ingresar una descripción del Fondo de Pensiones.", MsgBoxStyle.Exclamation)
            txtdescripcion.Focus()
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim areaEnt As New ClsEntidades.PL_AFP
            AreaBl = New ClsOperaciones.Personal_RRHH

            areaEnt.ID = txtcodigo.Text
            areaEnt.DESCRIPTION = txtdescripcion.Text
            areaEnt.RUC = txt_ruc.Text
            If txt_aporte_obligatorio.Text = "" Then
                areaEnt.APORTE_OBLIGATORIO = 0
            Else
                areaEnt.APORTE_OBLIGATORIO = CDbl(txt_aporte_obligatorio.Text)
            End If
            If txt_comision_variable.Text = "" Then
                areaEnt.COMISION_VARIABLE = 0
            Else
                areaEnt.COMISION_VARIABLE = CDbl(txt_comision_variable.Text)
            End If
            If txt_comision_mixta.Text = "" Then
                areaEnt.COMISION_MIXTA = 0
            Else
                areaEnt.COMISION_MIXTA = CDbl(txt_comision_mixta.Text)
            End If
            If txt_prima_seguro.Text = "" Then
                areaEnt.PRIMA_SEGURO = 0
            Else
                areaEnt.PRIMA_SEGURO = CDbl(txt_prima_seguro.Text)
            End If


            If Flag_modo_edicion = False Then
                If AreaBl.Guardar_Fondo_Pensiones(areaEnt) = True Then
                    MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Exclamation)
                End If
            Else
                If AreaBl.Actualizar_Fondo_Pensiones(areaEnt) = True Then
                    MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error.", MsgBoxStyle.Exclamation)
                End If
            End If
            btn_cancelar_Click(sender, e)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub

        Flag_modo_edicion = True
        Dim Codigo As String = String.Empty
        Dim Descripcion As String = String.Empty
        blank()

        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        Descripcion = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        txt_aporte_obligatorio.Text = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
        txt_aporte_obligatorio.Text = Format(CDbl(txt_aporte_obligatorio.Text), "##,##0.00")
        txt_comision_variable.Text = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value
        txt_comision_variable.Text = Format(CDbl(txt_comision_variable.Text), "##,##0.00")
        txt_comision_mixta.Text = dgvCabecera.Item(4, dgvCabecera.CurrentRow.Index).Value
        txt_comision_mixta.Text = Format(CDbl(txt_comision_mixta.Text), "##,##0.00")
        txt_prima_seguro.Text = dgvCabecera.Item(5, dgvCabecera.CurrentRow.Index).Value
        txt_prima_seguro.Text = Format(CDbl(txt_prima_seguro.Text), "##,##0.00")

        txt_ruc.Text = dgvCabecera.CurrentRow.Cells("RUC").Value

        If String.IsNullOrEmpty(Codigo) Then Exit Sub
        pnlcabecera.Visible = False
        Botonera_Estado_Cambiar(True)
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
                If AreaBl.Eliminacion_Fondo_Pensiones(Codigo) = True Then
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
            dtCabecera = AreaBl.DocumentoPrincipal_Fondo_Pensiones()
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 200

                dgvCabecera.Columns(2).Width = 100
                dgvCabecera.Columns(3).Width = 100
                dgvCabecera.Columns(4).Width = 100
                dgvCabecera.Columns(5).Width = 100
                dgvCabecera.Columns("RUC").Visible = False

                dgvCabecera.Columns(2).HeaderText = "Aporte Obligatorio"
                dgvCabecera.Columns(3).HeaderText = "Comisión Variable"
                dgvCabecera.Columns(4).HeaderText = "Comisión Mixta"
                dgvCabecera.Columns(5).HeaderText = "Prima/Seguro"

                dgvCabecera.Columns(2).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(3).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(4).DefaultCellStyle.Format = "N2"
                dgvCabecera.Columns(5).DefaultCellStyle.Format = "N2"

                dgvCabecera.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvCabecera.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        txt_aporte_obligatorio.Text = String.Empty
        txt_comision_variable.Text = String.Empty
        txt_comision_mixta.Text = String.Empty
        txt_prima_seguro.Text = String.Empty
        txt_ruc.Text = String.Empty
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

    Private Sub txt_aporte_obligatorio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aporte_obligatorio.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_comision_variable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_comision_variable.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_comision_mixta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_comision_mixta.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_prima_seguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_prima_seguro.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class