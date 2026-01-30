Imports System.Windows.Forms

Public Class FrmArea

    Dim AreaBl As ClsOperaciones.AREA
    Dim Flag_modo_edicion As Boolean = False

    Public Sub Botonera_Estado_Inicio(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = True
        frm.Controls("btn_grabar").Enabled = False
        frm.Controls("btn_Editar").Enabled = True
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_eliminar").Enabled = True
        frm.Controls("btn_salir").Enabled = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
        frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
        frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
        frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
        frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
        frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    End Sub


    Private Sub DocumentosPrincipal()
        Try
            AreaBl = New ClsOperaciones.AREA
            Dim dtCabecera As New DataTable
            dtCabecera = AreaBl.DocumentoPrincipal()
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 200
            Else
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
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

    Private Sub FrmComprasConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim CORRELATIVOBL As New ClsTransacciones.AREA
            CORRELATIVOBL.NumeroCorrelativoArea()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "00"
            Else
                Correlativo = String.Format("{0:000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
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
        Dim areaEnt As New ClsEntidades.AREA
        AreaBl = New ClsOperaciones.AREA

        areaEnt.ID = txtcodigo.Text
        areaEnt.DESCRIPTION = txtdescripcion.Text

        If Flag_modo_edicion = False Then
            If AreaBl.GuardarArea(areaEnt) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If AreaBl.ActualizarArea(areaEnt) = True Then
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
        If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            AreaBl = New ClsOperaciones.AREA
            Dim Codigo As String = String.Empty
            Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Codigo) Then Exit Sub
            If AreaBl.EliminacionArea(Codigo) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
            DocumentosPrincipal()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(False)
        pnlcabecera.Visible = True
        DocumentosPrincipal()
    End Sub
 

    Private Sub btnAgregarDetalles_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalles.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim Codigo As String = String.Empty
        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        Dim frmDetalles As New FrmAreaDetalleSolicitante
        frmDetalles.CodigoArea = Codigo
        frmDetalles.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class