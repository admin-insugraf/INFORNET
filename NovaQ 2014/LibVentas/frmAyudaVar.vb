Imports System.Windows.Forms
Public Class frmAyudaVar
    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Private cVenta As ClsAyudas
    Private dtData As DataTable
    Private dtv As DataView
    Private STRorden As String
    Private STRCodAlmacen As String
    Protected dtHelp As New DataTable
    Public CadenaSql As String = String.Empty

    Enum STipoAyuda
        PtoVenta = 0
        Clientes = 1
        Articulos = 2
        Transportistas = 3
        Vendedores = 4
        FormaPago = 5
        Reportes = 6
    End Enum

    Public Property CodAlmacen As String
        Get
            Return STRCodAlmacen
        End Get
        Set(value As String)
            STRCodAlmacen = value
        End Set
    End Property

    Private Sub DevuelveDatos()
        Try
            If dgvdato.RowCount = 0 Then Exit Sub
            Dim miFila As DataRow
            Dim iCol As Int16
            dtHelp = New DataTable
            For iCol = 0 To dtv.Table.Columns.Count - 1
                dtHelp.Columns.Add(dgvdato.Columns(iCol).Name)
            Next
            If dgvdato.SelectedRows.Count = 0 Then
                Me.Close()
                Exit Sub
            End If
            miFila = dtHelp.NewRow
            Dim INTDato As Int16
            For INTDato = 0 To dtv.Table.Columns.Count - 1
                miFila(dgvdato.Columns(INTDato).Name) = dgvdato.Item(INTDato, dgvdato.CurrentRow.Index).Value
            Next
            dtHelp.Rows.Add(miFila)
            Data_Matriz = dtHelp
            'txtBuscar.Clear()
            Me.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Property Data_Matriz() As DataTable
        Get
            Return dtHelp
        End Get
        Set(ByVal Value As DataTable)
            dtHelp = Value
        End Set
    End Property
    Public Property Titulo As String
        Get
            Return STRTitulo
        End Get
        Set(value As String)
            STRTitulo = value
        End Set
    End Property
    Public Property TipoAyuda As STipoAyuda
        Get
            Return INTTipoAyuda
        End Get
        Set(value As STipoAyuda)
            INTTipoAyuda = value
        End Set
    End Property

    Private Sub frmAyudaVar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Titulo
        Data_Matriz.Clear()
        cVenta = New ClsAyudas
        dtv = New DataView
        dtData = New DataTable
        If TipoAyuda = STipoAyuda.PtoVenta Then
            dtData = cVenta.get_Pto_Venta
        ElseIf TipoAyuda = STipoAyuda.Clientes Then
            dtData = cVenta.get_List_Clientes("", "", "", "")
        ElseIf TipoAyuda = STipoAyuda.Articulos Then
            dtData = cVenta.get_Lista_Articulos(CodAlmacen, "", "")
        ElseIf TipoAyuda = STipoAyuda.Transportistas Then
            dtData = cVenta.get_Transportistas
        ElseIf TipoAyuda = STipoAyuda.Vendedores Then
            dtData = cVenta.get_Vendedores
        ElseIf TipoAyuda = STipoAyuda.FormaPago Then
            dtData = cVenta.get_FormasPago("")
        ElseIf TipoAyuda = STipoAyuda.Reportes Then
            dtData = cVenta.Get_MostrarDescripcion(CadenaSql)
        End If
        dtv = dtData.DefaultView
        dgvdato.DataSource = dtv
        dgvdato.Columns(1).Width = 300
        STRorden = dgvdato.Columns(0).Name & "+" & dgvdato.Columns(1).Name
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        cVenta = Nothing
        dgvdato.Columns(1).Width = 300

    End Sub

    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        Call DevuelveDatos()
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Down
                If dgvdato.RowCount > 0 Then
                    dgvdato.Focus()
                End If
        End Select
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If

        Select Case Asc(e.KeyChar)
            Case 13
                If dgvdato.SelectedRows.Count > 0 Then
                    Call DevuelveDatos()
                End If
        End Select
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'dtv.Sort = STRorden
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub
    Private Sub dgvdato_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvdato.MouseDoubleClick
        Call DevuelveDatos()
    End Sub

    Private Sub dgvdato_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdato.ColumnHeaderMouseClick
        STRorden = dgvdato.Columns(e.ColumnIndex).Name
        '  lblBuscar.Text = "BUSCAR POR " & STRorden.ToUpper
        txtFiltro.Focus()
        txtFiltro.Clear()
    End Sub
End Class