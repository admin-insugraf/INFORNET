Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmAreaDetalleSolicitante
    Dim dtdetalleConceptos As DataTable
    Dim ClsBuscarBl As ClsBuscar
    Dim Dtdatos As DataTable

    Dim SolicitanteBl As ClsOperaciones.SOLICITANTE
    Dim Flag_modo_edicion As Boolean = False
    Private _CodigoArea As String
    Dim Item_Edicion As Integer = 0
    Dim Listacuentas As List(Of String)

    Public Property CodigoArea As String
        Get
            Return _CodigoArea
        End Get
        Set(value As String)
            _CodigoArea = value
        End Set
    End Property



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
            SolicitanteBl = New ClsOperaciones.SOLICITANTE
            Dim dtCabecera As New DataTable
            dtCabecera = SolicitanteBl.DocumentoPrincipal(CodigoArea)
            dgvCabecera.DataSource = Nothing
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).Width = 80
                dgvCabecera.Columns(1).Width = 200
            Else
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Botonera_Estado_Cambiar(False)
        DocumentosPrincipal()
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleConceptos.Rows
            i += 1
            dtdetalleConceptos.BeginInit()
            items("ITEM") = i
            dtdetalleConceptos.EndInit()
            dtdetalleConceptos.AcceptChanges()
        Next
    End Sub

    Public Sub blank()
        txtcodigo.Text = String.Empty
        txtdescripcion.Text = String.Empty
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New ClsTransacciones.SOLICITANTE
            CORRELATIVOBL.NumeroCorrelativoSolicitante()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "00"
            Else
                Correlativo = String.Format("{0:00000000}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function


    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        pnlcabecera.Visible = False
        blank()
        txtcodigo.Text = Numeracion()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txtcodigo.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del solicitante.", MsgBoxStyle.Information)
            txtcodigo.Focus()
            Exit Sub
        ElseIf txtdescripcion.Text = String.Empty Then
            MsgBox("Debe ingresar una descripcion para el solicitante.", MsgBoxStyle.Information)
            txtdescripcion.Focus()
            Exit Sub
        End If
        Dim SolicitanteEnt As New ClsEntidades.SOLICITANTE
        SolicitanteBl = New ClsOperaciones.SOLICITANTE
        SolicitanteEnt.TYPE_ID = "12"
        SolicitanteEnt.ID = txtcodigo.Text
        SolicitanteEnt.DESCRIPTION = txtdescripcion.Text
        SolicitanteEnt.CREATE_DATE = Date.Now.ToShortDateString
        SolicitanteEnt.COD_AREA = CodigoArea
        If Flag_modo_edicion = False Then
            If SolicitanteBl.GuardarSolicitante(SolicitanteEnt) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If SolicitanteBl.ActualizarSolicitante(SolicitanteEnt) = True Then
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        End If
        btn_cancelar_Click(sender, e)
    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            SolicitanteBl = New ClsOperaciones.SOLICITANTE
            Dim _Codigo As String = String.Empty
            _Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            If SolicitanteBl.EliminacionSolicitante(_Codigo, CodigoArea) = True Then
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

 

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        Flag_modo_edicion = True
        txtcodigo.Text = ""
        txtdescripcion.Text = ""
        pnlcabecera.Visible = False
        txtcodigo.Text = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        txtdescripcion.Text = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class