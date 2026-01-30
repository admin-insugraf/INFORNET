Module ModBas
    Friend dtTable As DataTable
    Public GdtFechaSys As Date
    Public GdbTipCambioV As Double
    Public GdbTipCambioC As Double
    Friend STRRuta_FE As String

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub
End Module
