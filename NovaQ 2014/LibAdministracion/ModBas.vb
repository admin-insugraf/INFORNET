Module ModBas
    Friend dtTable As DataTable
    Friend dtTableR As DataTable
    Friend dtTableRL As DataTable
    Friend dtTableWT As DataTable
    Friend dtTableWTL As DataTable

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub
End Module
