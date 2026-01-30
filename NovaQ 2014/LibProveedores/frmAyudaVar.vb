Imports System.Windows.Forms
Public Class frmAyudaVar
    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Private cProvAyuda As ClsAyudas
    Private dtData As New DataTable
    Private dtv As DataView
    Private STRorden As String
    Private STRCodAlmacen As String
    Protected dtHelp As New DataTable

    Enum STipoAyuda
        PtoVenta = 0
        Clientes = 1
        Articulos = 2
        Transportistas = 3
        Vendedores = 4
        FormaPago = 5
        Proveedores = 6
        Compradores = 7
        TipoCompra = 8
        Almacenes = 9
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
            If dgwDatos.RowCount = 0 Then Exit Sub
            Dim miFila As DataRow
            Dim iCol As Int16
            dtHelp = New DataTable
            For iCol = 0 To dtv.Table.Columns.Count - 1
                dtHelp.Columns.Add(dgwDatos.Columns(iCol).Name)
            Next
            If dgwDatos.SelectedRows.Count = 0 Then
                Me.Close()
                Exit Sub
            End If
            miFila = dtHelp.NewRow
            Dim INTDato As Int16
            For INTDato = 0 To dtv.Table.Columns.Count - 1
                miFila(dgwDatos.Columns(INTDato).Name) = dgwDatos.Item(INTDato, dgwDatos.CurrentRow.Index).Value
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
        cProvAyuda = New ClsAyudas
        dtv = New DataView
        If TipoAyuda = STipoAyuda.PtoVenta Then
            dtData = cProvAyuda.get_Pto_Venta
        ElseIf TipoAyuda = STipoAyuda.Clientes Then
            dtData = cProvAyuda.get_List_Clientes("", "", "", "")
        ElseIf TipoAyuda = STipoAyuda.Articulos Then
            dtData = cProvAyuda.get_Lista_Articulos(CodAlmacen, "", "")
        ElseIf TipoAyuda = STipoAyuda.Transportistas Then
            dtData = cProvAyuda.get_Transportistas
        ElseIf TipoAyuda = STipoAyuda.Vendedores Then
            dtData = cProvAyuda.get_Vendedores
        ElseIf TipoAyuda = STipoAyuda.FormaPago Then
            dtData = cProvAyuda.get_FormasPago("")
        ElseIf TipoAyuda = STipoAyuda.Proveedores Then
            dtData = cProvAyuda.get_Proveedores
        ElseIf TipoAyuda = STipoAyuda.Compradores Then
            dtData = cProvAyuda.get_Compradores
        ElseIf TipoAyuda = STipoAyuda.TipoCompra Then
            dtData = cProvAyuda.get_TipoCompra
        ElseIf TipoAyuda = STipoAyuda.Almacenes Then
            dtData = cProvAyuda.get_Almacenes
        End If
        dtv = dtData.DefaultView
        dgwDatos.DataSource = dtv
        STRorden = dgwDatos.Columns(1).Name
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        cProvAyuda = Nothing
    End Sub

    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        Call DevuelveDatos()
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Down
                If dgwDatos.RowCount > 0 Then
                    dgwDatos.Focus()
                End If
        End Select
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                If dgwDatos.SelectedRows.Count > 0 Then
                    Call DevuelveDatos()
                End If
        End Select
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        dtv.Sort = STRorden
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager

        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)

        Dim INTnewpos As Integer

        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub dgwDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDatos.CellContentClick

    End Sub

    Private Sub dgwDatos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgwDatos.ColumnHeaderMouseClick
        STRorden = dgwDatos.Columns(e.ColumnIndex).Name
        lblBuscar.Text = "BUSCAR POR " & STRorden.ToUpper
        txtFiltro.Focus()
        txtFiltro.Clear()
    End Sub

    Private Sub dgwDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgwDatos.DoubleClick
        Call DevuelveDatos()
    End Sub
End Class