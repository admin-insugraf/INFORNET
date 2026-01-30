Imports System.Windows.Forms
Public Class FrmMostrar_Productos

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

    Private Sub FrmMostrar_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Flag_Filtro = True Then
            MostrarBusquedaFiltros()
            dgvdato.Select()
        Else
            MostrarBusqueda()
            dgvdato.Select()
        End If
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
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvdato.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvdato.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvdato.Columns(0).Name & "+" & dgvdato.Columns(1).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub
    Private Sub dgvdato_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvdato.MouseDoubleClick
        Call DevuelveDatos()
    End Sub

    Private Sub dgvdato_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdato.ColumnHeaderMouseClick
        'STRorden = dgvdato.Columns(e.ColumnIndex).Name
        'txtFiltro.Focus()
        'txtFiltro.Clear()
    End Sub

    Private Sub dgvdato_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvdato.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvdato.SelectedRows.Count > 0 Then
                Call DevuelveDatos()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

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
            MsgBox(ex.Message)
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
            dtData = clsBusquedaBl.Get_Lista_Productos_Venta(Filtros1, Filtros2, Filtros3)
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvdato.DataSource = dtv

                dgvdato.Columns("IGV").Visible = False
                dgvdato.Columns("TIPO_ISC").Visible = False
                dgvdato.Columns("ISC_POR").Visible = False
                dgvdato.Columns("PRECIO_FRACCION").Visible = False
                dgvdato.Columns("LOTE").Visible = False
                dgvdato.Columns("PRESENTACION").Visible = False

                dgvdato.Columns("CODIGO").Width = 70
                dgvdato.Columns("DESCRIPCION").Width = 500
                dgvdato.Columns("PRESENTACION").Width = 200
                dgvdato.Columns("UNID_MED").Width = 50
                dgvdato.Columns("UNID_MED").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvdato.Columns("PRECIO_MINORISTA").Width = 80
                dgvdato.Columns("PRECIO_FRACCION").Width = 80
                dgvdato.Columns("STOCK").Width = 80
                dgvdato.Columns("LOTE").Width = 100
                
                dgvdato.Columns("CODIGO").HeaderText = "CODIGO"
                dgvdato.Columns("DESCRIPCION").HeaderText = "PRODUCTO"
                dgvdato.Columns("PRESENTACION").HeaderText = "PRESENTACION"
                dgvdato.Columns("UNID_MED").HeaderText = "UM"
                dgvdato.Columns("PRECIO_MINORISTA").HeaderText = "PRECIO"
                dgvdato.Columns("PRECIO_FRACCION").HeaderText = "PRECIO FRAC."
                dgvdato.Columns("STOCK").HeaderText = "STOCK"

                dgvdato.Columns("LOTE").HeaderText = "N° LOTE"

                dgvdato.Columns("STOCK").DefaultCellStyle.Format = "##,##0.00"
                dgvdato.Columns("STOCK").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvdato.Columns("PRECIO_MINORISTA").DefaultCellStyle.Format = "##,##0.00"
                dgvdato.Columns("PRECIO_MINORISTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvdato.Columns("PRECIO_FRACCION").DefaultCellStyle.Format = "##,##0.00"
                dgvdato.Columns("PRECIO_FRACCION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvdato.Columns("CODIGO").DisplayIndex = 0
                dgvdato.Columns("DESCRIPCION").DisplayIndex = 1
                dgvdato.Columns("PRESENTACION").DisplayIndex = 2
                dgvdato.Columns("UNID_MED").DisplayIndex = 3
                dgvdato.Columns("PRECIO_MINORISTA").DisplayIndex = 4
                dgvdato.Columns("PRECIO_FRACCION").DisplayIndex = 5
                dgvdato.Columns("STOCK").DisplayIndex = 6
                dgvdato.Columns("LOTE").DisplayIndex = 9

                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            Else
                '    MsgBox("No hay informacion para Mostrar.", MsgBoxStyle.Information)
                dgvdato.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmMostrar_Productos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class