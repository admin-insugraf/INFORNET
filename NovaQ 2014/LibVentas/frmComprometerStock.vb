Imports System.Windows.Forms
Imports System.Drawing

Public Class frmComprometerStock
    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Private _CadenaConsulta As String
    Private clsBusquedaBl As ClsBuscar
    Private dtData As DataTable
    Private dtv As DataView
    Private STRorden As String
    Private STRCodAlmacen As String
    Protected dtHelp As New DataTable
    Private _Filtros1 As String
    Private _Filtros2 As String
    Private _Filtros3 As String
    Public _Flag_Filtro As Boolean = False
    Public _Flag_Ajuste_Automatico As Boolean = False
    Public _flag_detalles As String = String.Empty

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



    Public Property CadenaConsulta As String
        Get
            Return _CadenaConsulta
        End Get
        Set(value As String)
            _CadenaConsulta = value
        End Set
    End Property


    Public Property Filtros1 As String
        Get
            Return _Filtros1
        End Get
        Set(value As String)
            _Filtros1 = value
        End Set
    End Property

    Public Property Filtros2 As String
        Get
            Return _Filtros2
        End Get
        Set(value As String)
            _Filtros2 = value
        End Set
    End Property

    Public Property Filtros3 As String
        Get
            Return _Filtros3
        End Get
        Set(value As String)
            _Filtros3 = value
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

    Private Sub MostrarBusqueda()
        Try
            Me.Text = Titulo
            Data_Matriz.Clear()
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.Get_MostrarDescripcion(CadenaConsulta)
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvdato.DataSource = dtv
                If _Flag_Ajuste_Automatico = False Then
                    dgvdato.Columns(1).Width = 300
                Else
                    dgvdato.AutoResizeColumns()
                    dgvdato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End If

                STRorden = String.Empty
                For i As Integer = 0 To dtData.Columns.Count() - 1
                    STRorden += dgvdato.Columns(i).Name & "+"
                Next
                STRorden = Mid(STRorden, 1, STRorden.Length() - 1)
                ''STRorden = dgvdato.Columns(0).Name & "+" & dgvdato.Columns(1).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                dgvdato.Columns(1).Width = 300
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub MostrarBusquedaFiltros()
        Try
            Me.Text = Titulo
            Data_Matriz.Clear()
            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.Get_ConsultaStockComprometido(CadenaConsulta, Filtros1)

            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvdato.DataSource = dtv
                dgvdato.Columns(1).Width = 300
                STRorden = String.Empty
                For i As Integer = 0 To dtData.Columns.Count() - 2
                    STRorden += dgvdato.Columns(i).Name & "+"
                Next
                STRorden = Mid(STRorden, 1, STRorden.Length() - 1)
                lblCantidad.Text = "Se encontrarón " & dtv.Count & " registros"
                dgvdato.Columns(1).Width = 300
                clsBusquedaBl = Nothing
            Else
                MsgBox("No hay informacion para Mostrar.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmComprometerStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarBusquedaFiltros()

    End Sub

    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        Call DevuelveDatos()
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Down
                If dgvdato.RowCount > 0 Then
                    dgvdato.Focus()
                End If
        End Select
    End Sub




    Private Sub dgvdato_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvdato.MouseDoubleClick
        Call DevuelveDatos()
    End Sub

    Private Sub dgvdato_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdato.ColumnHeaderMouseClick
        STRorden = dgvdato.Columns(e.ColumnIndex).Name

    End Sub

    Private Sub dgvdato_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvdato.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvdato.SelectedRows.Count > 0 Then
                Call DevuelveDatos()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvdato_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvdato.CellFormatting
        If _flag_detalles = "si" Then
            If dgvdato.Rows(e.RowIndex).Cells("STOCK").Value <= 0 Then
                dgvdato.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
                dgvdato.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
            Else
                dgvdato.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                dgvdato.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
            End If
        End If
        
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class