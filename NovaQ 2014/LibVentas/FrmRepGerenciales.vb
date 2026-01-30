Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes

Public Class FrmRepGerenciales
    Dim frm_ayuda As frmAyudaVar
    Public TituloReporte As String = String.Empty
    Public cadena As String = String.Empty
    Public opcion As Integer = 0
    Private Sub FrmRepGerenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        '  Me.Size = Screen.PrimaryScreen.WorkingArea.Size

    End Sub

    Private Sub BloquearControles(ByVal controles As GroupBox)
        For Each ctrl As Control In controles.Controls
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub btnReporteVentasVendedor_Click(sender As Object, e As EventArgs) Handles btnReporte1.Click
        '----1 Reporte de Ventas por Vendedor
        '----2 Reporte de Ventas por cliente
        '----3 Reporte de Ventas por producto
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .lblFiltro.Text = "Seleccione un Vendedor"
            .checkMostrarTodos.Text = "Mostrar todos los Vendedores"
            .rbvendedor.Visible = False
            .opcion = btnReporte1.Tag
            .rbresumido.Checked = True
            .AjustarTamaño(True, btnReporte1.Tag)
            .ShowDialog()
            .Close()
        End With

    End Sub

    Private Sub btnReporteVentasCliente_Click(sender As Object, e As EventArgs) Handles btnReporte2.Click
        '----1 Reporte de Ventas por Vendedor
        '----2 Reporte de Ventas por cliente
        '----3 Reporte de Ventas por producto
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .lblFiltro.Text = "Seleccione un Cliente"
            .checkMostrarTodos.Text = "Mostrar todos los Clientes"
            .CheckGrupoDany.Visible = False
            .rbvendedor.Visible = False
            .opcion = btnReporte2.Tag
            .FlagDetalle = False
            .rbresumido.Checked = True
            .AjustarTamaño(True, btnReporte2.Tag)
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporteVentasProducto_Click(sender As Object, e As EventArgs) Handles btnReporte5.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .lblFiltro.Text = "Seleccione un producto"
            .checkMostrarTodos.Text = "Mostrar todos los Productos"
            .rbresumido.Text = "Valorizado"
            .rbresumido.Checked = True
            .rbGrSinValor.Visible = True
            .opcion = btnReporte5.Tag
            .AjustarTamaño(True, btnReporte5.Tag)
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporte3_Click(sender As Object, e As EventArgs) Handles btnReporte3.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = btnReporte3.Tag
            .AjustarTamaño(False, btnReporte3.Tag)
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporte4_Click(sender As Object, e As EventArgs) Handles btnReporte4.Click
        Dim frm As New FrmMostrarReporte
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = btnReporte4.Tag
            .AjustarTamaño(False, btnReporte4.Tag)
            .rbStockValorizado.Checked = True
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporte6_Click(sender As Object, e As EventArgs) Handles btnReporte6.Click
        ' btnReporte6.Name
        Dim frm As New FrmMostrarReporteII
        With frm
            .LimpiarControles(.GroupBox4)
            .opcion = btnReporte6.Tag
            .rbdocumento.Checked = True
            .rbtodos.Checked = True
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporte7_Click(sender As Object, e As EventArgs) Handles btnReporte7.Click
        ' btnReporte7.Name
        Dim frm As New FrmMostrarReporte_Cobranza
        With frm
            '.LimpiarControles(.GroupBox4)
            '.opcion = btnReporte6.Tag
            '.rbdocumento.Checked = True
            '.rbtodos.Checked = True
            .ShowDialog()
            .Close()
        End With
    End Sub

    Private Sub btnReporte8_Click(sender As Object, e As EventArgs) Handles btnReporte8.Click
        ' btnReporte8.Name
    End Sub
End Class