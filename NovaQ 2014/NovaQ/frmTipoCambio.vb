Imports System.Data.SqlClient
Imports vb6 = Microsoft.VisualBasic
Imports LibConsultasComun
Public Class frmTipoCambio
    Private WithEvents bsTipoC As New BindingSource
    Private ClsMantGen As LibConsultasComun.ClsComun
    Private BOLEdit As Boolean
    Private daTipo As SqlClient.SqlDataAdapter
    Private dtTabla As DataTable

    Private Sub ToolGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolGrabar.Click
        If Not bsTipoC.DataSource Is Nothing Then
            daTipo.Update(CType(bsTipoC.DataSource, DataTable))
            Call CargaDatosTipos()
            ToolGrabar.Enabled = False
            ToolNuevo.Enabled = True
            ToolEditar.Enabled = True
            Call BloquearColumnas(True)
            MessageBox.Show("Tipo de cambio guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BloquearColumnas(ByVal Estado As Boolean)
        Dim BYTCol As Byte = 0
        For BYTCol = 0 To dgTipoCambio.Columns.Count - 1
            dgTipoCambio.Columns(BYTCol).ReadOnly = Estado
        Next
    End Sub

    Private Sub ColumnasEdicion()
        Dim BYTCol As Byte = 0
        dgTipoCambio.Columns(0).ReadOnly = True
        For BYTCol = 1 To dgTipoCambio.Columns.Count - 2
            dgTipoCambio.Columns(BYTCol).ReadOnly = False
        Next
    End Sub
    Private Sub FormatoGridTipo()
        With dgTipoCambio
            .Columns(0).HeaderText = "Moneda"
            .Columns(1).HeaderText = "Fecha"
            .Columns(2).HeaderText = "Tipo Venta"
            .Columns(3).HeaderText = "Tipo Compra"
            .RowHeadersWidth = 25
            .Columns(0).Width = 70
            .Columns(1).Width = 100
            .Columns(2).Width = 70
            .Columns(3).Width = 70
        End With
    End Sub
    Private Sub CargaDatosTipos()
        dtTabla = New DataTable
        ClsMantGen = New LibConsultasComun.ClsComun
        daTipo = New SqlClient.SqlDataAdapter
        dtTabla = ClsMantGen.Lista_Datos_TCambio("ADM_LISTA_TIPO_CAMBIO", daTipo, dtpFecha.Value.Year, dtpFecha.Value.Month)
        Dim SqlCommandBuilder As New SqlCommandBuilder(daTipo)
        bsTipoC.DataSource = dtTabla
        With dgTipoCambio
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .Refresh()
            If dtTabla.Rows.Count > 1 Then
                .FirstDisplayedScrollingRowIndex = bsTipoC.Position
            End If

        End With

        BOLEdit = False
        Call FormatoGridTipo()
    End Sub

    Private Sub ToolNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolNuevo.Click
        bsTipoC.AddNew()
        ToolGrabar.Enabled = True
        ToolNuevo.Enabled = False
        ToolEditar.Enabled = False
        Call BloquearColumnas(False)
    End Sub

    Private Sub ToolEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolEditar.Click
        Call ColumnasEdicion()
        ToolGrabar.Enabled = True
        ToolNuevo.Enabled = False
        ToolEditar.Enabled = False
    End Sub

    Private Sub ToolSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolCancelar.Click
        bsTipoC.CancelEdit()
        ToolGrabar.Enabled = False
        ToolNuevo.Enabled = True
        ToolEditar.Enabled = True
    End Sub

    Private Sub frmTipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecha.Value = GdtFechaSys
        dgTipoCambio.DataSource = bsTipoC
        Call CargaDatosTipos()
        Call BloquearColumnas(True)
    End Sub

    Private Sub dgTipoCambio_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTipoCambio.CellEndEdit
        BOLEdit = True
    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Call CargaDatosTipos()
    End Sub
End Class