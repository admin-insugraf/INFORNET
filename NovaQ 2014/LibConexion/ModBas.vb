Module ModBas
    Friend STRServidor As String
    Friend STRBDatos As String
    Friend STRUsuario As String
    Friend STRPassword As String

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub
End Module
