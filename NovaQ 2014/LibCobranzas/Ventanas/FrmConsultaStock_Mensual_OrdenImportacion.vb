Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmConsultaStock_Mensual_OrdenImportacion
    Public _codigo_producto As String
    Dim clsBusquedaBl As ClsBuscar
    Dim ArticuloBl As ClsNegocio.PART

    Private Sub FrmConsultaStock_Mensual_OrdenImportacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ArticuloBl = New ClsNegocio.PART
            Dim dtdetalles As DataTable

            dtdetalles = ArticuloBl.Retornar_Ordenes_Importacion(_codigo_producto)
            If dtdetalles.Rows.Count() <> 0 Then
                dgvConsulta.DataSource = dtdetalles
                dgvConsulta.Columns("TIPO_ORDEN").HeaderText = "Tipo Orden"
                dgvConsulta.Columns("NUM_ORDEN").HeaderText = "N° Orden"
                dgvConsulta.Columns("ITEM").HeaderText = "Item"
                dgvConsulta.Columns("PART_ID").HeaderText = "Codigo"
                dgvConsulta.Columns("DESCRIPTION").HeaderText = "Descripción"
                dgvConsulta.Columns("UNIT").HeaderText = "UM"
                dgvConsulta.Columns("QTY").HeaderText = "Cantidad"
                dgvConsulta.Columns("PRICE").HeaderText = "Precio"
                dgvConsulta.Columns("FECHA").HeaderText = "Fecha"

                dgvConsulta.AutoResizeColumns()
                dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ArticuloBl = Nothing
            Else
                dgvConsulta.DataSource = Nothing
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class