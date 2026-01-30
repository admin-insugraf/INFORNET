Public Class Paginacion
    Private _paginaActual As Integer = 0
    Private _totalPaginas As Integer = 0
    Private _totalRegistros As Integer = 25

    Public Event CargarLista(ByVal inicio As Integer, ByVal registros As Integer)

    Public Sub Inicializar(value As Integer)
        If value > 0 Then
            _paginaActual = 1
            _totalPaginas = value \ _totalRegistros
            If value Mod _totalRegistros > 0 Then _totalPaginas = _totalPaginas + 1
            txtPagina.Minimum = 1
            txtPagina.Maximum = _totalPaginas
            txtPagina.Enabled = True
            btnFirst.Enabled = True
            btnLast.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
        End If
        Me.lblTotal.Text = _totalPaginas
        Me.txtPagina.Value = _paginaActual
    End Sub

    Public Sub RefrescarPagina()
        Dim skip As Integer
        If _paginaActual = 0 Then _paginaActual = 1
        skip = (_paginaActual - 1) * _totalRegistros
        RaiseEvent CargarLista(skip, _totalRegistros)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        _paginaActual = 1
        Me.txtPagina.Value = 1
        RaiseEvent CargarLista(0, _totalRegistros)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If txtPagina.Value > 1 Then
            _paginaActual = _paginaActual - 1
            Me.txtPagina.Value = _paginaActual
            Dim skip As Integer
            skip = (_paginaActual - 1) * _totalRegistros
            RaiseEvent CargarLista(skip, _totalRegistros)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtPagina.Value < CInt(lblTotal.Text) Then
            _paginaActual = _paginaActual + 1
            Me.txtPagina.Value = _paginaActual
            Dim skip As Integer
            skip = (_paginaActual - 1) * _totalRegistros
            RaiseEvent CargarLista(skip, _totalRegistros)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        _paginaActual = CInt(lblTotal.Text)
        Me.txtPagina.Value = _paginaActual
        Dim skip As Integer
        skip = (_paginaActual - 1) * _totalRegistros
        RaiseEvent CargarLista(skip, _totalRegistros)
    End Sub

    Private Sub txtPagina_ValueChanged(sender As Object, e As EventArgs) Handles txtPagina.ValueChanged
        _paginaActual = CInt(Me.txtPagina.Value)
        Dim skip As Integer
        skip = (_paginaActual - 1) * _totalRegistros
        RaiseEvent CargarLista(skip, _totalRegistros)
    End Sub
End Class
