Imports System.Windows.Forms

Public Class FrmComprasConceptos

    Dim AsientoBl As ClsOperaciones.Asiento_Contable
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
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim dtCabecera As New DataTable
            dtCabecera = AsientoBl.ConceptosCompras()
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
        txtcodigoConcepto.Text = String.Empty
        txtdescripcionConcepto.Text = String.Empty
    End Sub

    Private Sub FrmComprasConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Botonera_Estado_Inicio(Me)
        DocumentosPrincipal()
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Botonera_Estado_Cambiar(Me)
        pnlcabecera.Visible = False
        blank()
        Flag_modo_edicion = False
        txtcodigoConcepto.Enabled = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txtcodigoConcepto.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del Concepto.", MsgBoxStyle.Information)
            txtcodigoConcepto.Focus()
            Exit Sub
        ElseIf txtdescripcionConcepto.Text = String.Empty Then
            MsgBox("Debe ingresar una descripcion.", MsgBoxStyle.Information)
            txtdescripcionConcepto.Focus()
            Exit Sub
        End If
        Dim ConceptoCompraEnt As New ClsEntidades.CO_COMPRAS_CONCEPTOS_CABECERA
        AsientoBl = New ClsOperaciones.Asiento_Contable
        ConceptoCompraEnt.CO_CONCEPTO = txtcodigoConcepto.Text
        ConceptoCompraEnt.CO_DESCRIPCION = txtdescripcionConcepto.Text
        ConceptoCompraEnt.CREATE_DATE = Date.Now()
        ConceptoCompraEnt.CREATE_USER = LibComunVar.ClsVarComun.USUARIO
        If Flag_modo_edicion = False Then
            If AsientoBl.GuardarConceptoCompra(ConceptoCompraEnt) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If AsientoBl.ModificarConceptoCompra(ConceptoCompraEnt) = True Then
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
        Call Botonera_Estado_Cambiar(Me)
        blank()
        txtcodigoConcepto.Text = Codigo
        txtcodigoConcepto.Enabled = False
        txtdescripcionConcepto.Text = Descripcion
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim ConceptoCompraEnt As New ClsEntidades.CO_COMPRAS_CONCEPTOS_CABECERA
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim Codigo As String = String.Empty
            Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Codigo) Then Exit Sub
            ConceptoCompraEnt.CO_CONCEPTO = Codigo
            If AsientoBl.EliminarConceptoCompra(ConceptoCompraEnt) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
            DocumentosPrincipal()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(Me)
        pnlcabecera.Visible = True
        DocumentosPrincipal()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarDetalles_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalles.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        Dim Codigo As String = String.Empty
        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        Dim frmDetalles As New FrmComprasConceptosDetalle
        frmDetalles.CodigoConceptoCompra = Codigo
        frmDetalles.ShowDialog()
    End Sub
End Class