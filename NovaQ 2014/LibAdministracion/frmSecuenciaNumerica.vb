Public Class frmSecuenciaNumerica
    Private BOLNuevo As Boolean
    Private Sub ToolNuevo_Click(sender As Object, e As EventArgs) Handles ToolNuevo.Click
        BOLNuevo = True
        ToolGrabar.Enabled = True
        ToolNuevo.Enabled = False
        ToolEditar.Enabled = False
        tcSecuencias.TabPages.Insert(1, tpNumeroDoc)
        tcSecuencias.TabPages.Remove(tpListado)
        tcSecuencias.SelectTab(0)
        txtTipoDoc.ReadOnly = False
        txtNumeroSerie.ReadOnly = False
        txtTipoDoc.Focus()
    End Sub
End Class