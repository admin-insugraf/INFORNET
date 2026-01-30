Public Class TextNumeric
    <System.ComponentModel.DefaultValue(True)>
    Public Property Decimales As Boolean = True

    Private Sub TextNumeric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim decimals = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Decimales And e.KeyChar = decimals And Not Me.Text.IndexOf(decimals) Then
            e.Handled = True
        ElseIf Decimales And e.KeyChar = decimals Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
