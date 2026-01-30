Imports System.Windows.Forms
Imports System.Drawing

Public Class bscArticulo
    'Public Property Objeto As Articulo
    Public Property Objeto As String

    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Private dtData As DataTable
    Private dtv As DataView
    Private STRorden As String
    Private STRCodAlmacen As String
    Protected dtHelp As New DataTable
    Public CadenaSql As String = String.Empty
    Public CodigoAlmacen As String = String.Empty
    Public clsBusquedaBl As New ClsBuscar
    Public Transaccion_TipoArticulo As String = String.Empty

    Private Sub bscArticulo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MostrandoArticulos()
        txtFiltro.Focus()
    End Sub
    Private Sub MostrandoArticulos()
        Try
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.Get_MostrarDescripcionArticulo_TipoArticulo(Transaccion_TipoArticulo)
            DataGridView1.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                DataGridView1.DataSource = dtv
                Me.DataGridView1.Columns(0).Name = "Codigo"
                Me.DataGridView1.Columns(1).Name = "Descripcion"
                Me.DataGridView1.Columns(2).Name = "Unidad"
                STRorden = DataGridView1.Columns(0).Name & "+" & DataGridView1.Columns(1).Name
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Paginacion1_CargarLista(inicio As Integer, registros As Integer)
        dtData = New DataTable
        Using context = AlmacenContext.CrearContext() 'New AlmacenContext()
            Dim qry = (From a In context.Articulos
                       Order By a.Codigo Ascending
                       Select a)
            bsArticulo.DataSource = qry.Skip(inicio).Take(registros).ToList()
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Objeto = CType(bsArticulo.Current, Articulo)
        'DialogResult = DialogResult.OK
        Objeto = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Me.Close()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        Select Case Asc(e.KeyChar)
            Case 13
                If DataGridView1.SelectedRows.Count > 0 Then
                    Objeto = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
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

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'dtv.Sort = STRorden
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        STRorden = DataGridView1.Columns(e.ColumnIndex).Name
        txtFiltro.Focus()
    End Sub

    Private Sub bscArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class