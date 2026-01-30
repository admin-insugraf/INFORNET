Imports System.Windows.Forms

Public Class bscCliente
    'Public Property Objeto As Cliente
    Public Property Objeto As String
    Public Property ObjetoDescripcion As String

    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Public dtData As DataTable
    Public dtv As DataView
    Public clsBusquedaBl As ClsBuscar
    Private STRorden As String
    Private STRCodAlmacen As String
    Protected dtHelp As New DataTable
    Public CadenaSql As String = String.Empty
    Public CodigoAlmacen As String = String.Empty

    Private Sub MostrandoClientes()
        Try
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_CLIENTES"
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.Get_MostrarDescripcion(sql)
            DataGridView1.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                DataGridView1.DataSource = dtv
                DataGridView1.Columns(1).Width = 300
                STRorden = DataGridView1.Columns(0).Name.Substring(0, 6) & "+" & DataGridView1.Columns(1).Name.Substring(0, 6)
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bscCliente_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Dim totalRegistros As Integer = 0
        'Using context = AlmacenContext.CrearContext() 'New AlmacenContext()
        '    Dim qry = (From a In context.Clientes
        '               Select a)
        '    totalRegistros = qry.Count()
        'End Using
        'Paginacion1.Inicializar(totalRegistros)
        MostrandoClientes()
        txtFiltro.Focus()
    End Sub

    Private Sub Paginacion1_CargarLista(inicio As Integer, registros As Integer)
        Using context = AlmacenContext.CrearContext() 'New AlmacenContext()
            Dim qry = (From a In context.Clientes
                       Order By a.Codigo
                       Select a)
            bsCliente.DataSource = qry.Skip(inicio).Take(registros).ToList()
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Objeto = CType(bsCliente.Current, Cliente)
        'DialogResult = DialogResult.OK
        If Me.DataGridView1.CurrentRow Is Nothing Then Exit Sub
        Objeto = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        ObjetoDescripcion = Me.DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        DialogResult = DialogResult.OK
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'dtv.Sort = STRorden
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If

        Select Case Asc(e.KeyChar)
            Case 13
                If DataGridView1.SelectedRows.Count > 0 Then
                    Objeto = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    ObjetoDescripcion = Me.DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                    DialogResult = DialogResult.OK
                End If
        End Select
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Down
                If DataGridView1.RowCount > 0 Then
                    DataGridView1.Focus()
                End If
        End Select
    End Sub

    Private Sub bscCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFiltro.Focus()
    End Sub
End Class