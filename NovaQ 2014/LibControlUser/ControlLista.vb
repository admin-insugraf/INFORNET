Public Class ControlLista
    Public Property TextBoxWidth() As Integer
        Get
            Return TextBox1.Width
        End Get
        Set(value As Integer)
            TextBox1.Width = value
        End Set
    End Property

    Public Property CodigoText() As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property

    Public Property DescripcionText() As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label1.Text = ""
    End Sub
End Class
