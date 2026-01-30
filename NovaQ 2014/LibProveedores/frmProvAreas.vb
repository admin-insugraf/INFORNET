Imports System.Windows.Forms
Imports LibReportes
Public Class frmProvAreas
    Private cMant As ClsMantenimiento
    Private cConsulta As ClsConsultas
    Private BOLNuevo As Boolean
    Private STRInsUpd As String = ""
    Private dtAreas As DataTable
    Private CRep As LibReportes.ClsReporte

    Private Sub frmProvAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargaDatos()
    End Sub

    Private Sub CargaDatos()
        dtAreas = New DataTable
        cConsulta = New ClsConsultas
        dtAreas = cConsulta.get_List_Areas
        dgwAreas.DataSource = dtAreas
        cConsulta = Nothing
    End Sub

    Private Sub Grabar_Click(sender As Object, e As EventArgs) Handles Grabar.Click
        'Validar datos

        If txtCodigo.Text.Trim.Length = 0 Then
            MessageBox.Show("", "", MessageBoxButtons.OK)
            Exit Sub
        ElseIf txtDescripcion.Text.Trim.Length = 0 Then
            MessageBox.Show("", "", MessageBoxButtons.OK)
            Exit Sub
        End If


        Dim Area As New AreasTO
        Area.Id = txtCodigo.Text.Trim
        Area.Descripcion = txtDescripcion.Text.Trim

        cMant = New ClsMantenimiento

        If BOLNuevo = True Then
            STRInsUpd = "I"
        Else
            STRInsUpd = "U"
        End If

        If cMant.Ins_Upd_Areas(Area, STRInsUpd) = True Then
            MessageBox.Show("", "", MessageBoxButtons.OK)
            Call Limpiar()
        End If

        cMant = Nothing



    End Sub

    Private Sub Limpiar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Grabar.Enabled = True
        BOLNuevo = True
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        BOLNuevo = False
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        CRep = New LibReportes.ClsReporte
        CRep.Muestra_Reporte("Ven_Lista_Areas.rpt", "", "")

        CRep = Nothing
    End Sub
End Class