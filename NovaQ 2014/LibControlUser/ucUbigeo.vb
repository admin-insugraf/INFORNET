Public Class ucUbigeo
    Private STRCodUbigeo As String
    Private STRDesUbigeo As String

    Private Sub pbHelp_Click(sender As Object, e As EventArgs) Handles pbHelp.Click
        frmUbigeo.ShowDialog()
        If frmUbigeo.Codigo_Ubigeo.Trim <> "" Then
            txtCodUbigeo.Text = frmUbigeo.Codigo_Ubigeo
            txtDesUbigeo.Text = frmUbigeo.Descripcion_Ubigeo
            CodUbigeo = txtCodUbigeo.Text
            DesUbigeo = txtDesUbigeo.Text
        End If
    End Sub

    Public Property CodUbigeo As String
        Get
            Return STRCodUbigeo
        End Get
        Set(value As String)
            STRCodUbigeo = value
        End Set
    End Property

    Public Property DesUbigeo As String
        Get
            Return STRDesUbigeo
        End Get
        Set(value As String)
            STRDesUbigeo = value
        End Set
    End Property

End Class
