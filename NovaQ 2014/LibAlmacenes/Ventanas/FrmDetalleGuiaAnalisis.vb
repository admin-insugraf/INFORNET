Imports System.Windows.Forms
Public Class FrmDetalleGuiaAnalisis
    Public dtDetallesBulto As DataTable
    Public dtdetalleArticulo As DataTable
    Dim clsAlmacenCabBl As LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
    Dim dtDetalleAlm As DataTable
    Public almacen As String, document_id As String, number_document As String, part_id As String, lote As String

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub FrmDetalleGuiaAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' GenerarColummnaDataTable()
        ' BultosGenerarColummnaDataTable()
        SetearFormatoGridBultos()
    End Sub
    Public Sub SetearFormatoGridBultos()
        For i = 0 To dgvDetallesBulto.ColumnCount - 1
            dgvDetallesBulto.Columns(i).Visible = False
            dgvDetallesBulto.Columns(i).ReadOnly = True
        Next
        ' dgvDetallesBulto.Columns(0).Visible = False
        dgvDetallesBulto.Columns(7).Visible = True
        dgvDetallesBulto.Columns(9).Visible = True
        dgvDetallesBulto.Columns(10).Visible = True
        dgvDetallesBulto.Columns(10).ReadOnly = False

        dgvDetallesBulto.Columns(7).HeaderText = "Item"
        dgvDetallesBulto.Columns(9).HeaderText = "Cant. Bulto"
        dgvDetallesBulto.Columns(10).HeaderText = "Cant. Analisis"
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleArticulo.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("PART_DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIT_PART", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMBER_ANALIS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("QT_BULTOS", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("OPT_ENTREGA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUM_PROTOCOLOS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMBER_LOT", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD_ANALIZAR", Type.GetType("System.Double"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub BultosGenerarColummnaDataTable()
        Try
            dtDetallesBulto = New DataTable
            dtDetallesBulto.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("TYPE_TRANS", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("LOTE", Type.GetType("System.String"))
            dtDetallesBulto.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtDetallesBulto.Columns.Add("QTY", Type.GetType("System.Double"))
            dtDetallesBulto.Columns.Add("QTY_BULTOS", Type.GetType("System.Double"))
            dtDetallesBulto.Columns.Add("QTY_ANALISIS", Type.GetType("System.Double"))
            dtDetallesBulto.Columns.Add("QTY_LIBERACION", Type.GetType("System.Double"))
            dgvDetallesBulto.DataSource = Nothing
            dgvDetallesBulto.DataSource = dtDetallesBulto

            'For i = 0 To dgvDetallesBulto.ColumnCount - 1
            '    dgvDetallesBulto.Columns(i).Visible = False
            '    dgvDetallesBulto.Columns(i).ReadOnly = True
            'Next
            'dgvDetallesBulto.Columns(0).Visible = False
            'dgvDetallesBulto.Columns(7).Visible = True
            'dgvDetallesBulto.Columns(9).Visible = True
            'dgvDetallesBulto.Columns(10).Visible = True
            'dgvDetallesBulto.Columns(10).ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub LLenarDatosBultos()
        Try
            If dtDetallesBulto.Rows.Count() <> 0 Then
                dgvDetallesBulto.Rows.Clear()
                For i As Integer = 0 To dtDetallesBulto.Rows.Count() - 1
                    dgvDetallesBulto.Rows.Add(i + 1, dtDetallesBulto.Rows(i).Item("QTY"), dtDetallesBulto.Rows(i).Item("QTY_BULTOS"))
                Next
                txtCantidadAsiganda.Text = txtcantidad.Text
            Else
                clsAlmacenCabBl = New LibCobranzas.ClsOperaciones.WAREHOUSE_TRANS
                dtDetalleAlm = New DataTable
                '---Mostrando Datos de Cabecera
                dtDetalleAlm = clsAlmacenCabBl.get_Bultos(almacen, document_id, number_document)

                dgvDetallesBulto.Rows.Clear()
                If dtDetalleAlm.Rows.Count > 0 Then
                    For i As Integer = 0 To dtDetalleAlm.Rows.Count - 1
                        dgvDetallesBulto.Rows.Add(dtDetalleAlm.Rows(i).Item("ITEM"), dtDetalleAlm.Rows(i).Item("QTY_BULTOS"), "0.0")
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDetallesBulto_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetallesBulto.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
    End Sub
    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
       ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = dgvDetallesBulto.CurrentCell.ColumnIndex
        If columna = 10 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or _
           (caracter = ChrW(Keys.Back)) Or _
           (caracter = ".") And _
           (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvDetallesBulto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDetallesBulto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim resultado As Object = dtDetallesBulto.Compute("Sum(QTY_ANALISIS)", Nothing)
            txtCantidadAsiganda.Text = String.Format("{0:N6}", resultado)
            btnAceptar.Select()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        Me.Close()
    End Sub
    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If Val(txtCantidadAsiganda.Text) = 0 Then
                MsgBox("No se agrego cantidad a analizar de los Bultos.", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function

    Private Sub btnreplicar_Click(sender As Object, e As EventArgs) Handles btnreplicar.Click
        If dtDetallesBulto.Rows.Count > 0 Then
            Dim _cantidad_inicial As Double = CDbl(dtDetallesBulto.Rows(0).Item("qty_analisis").ToString)
            For i As Integer = 0 To dtDetallesBulto.Rows.Count - 1
                'For i As Integer = 0 To txtnumerobultos.Text - 1
                Me.dgvDetallesBulto.Rows(i).Cells("qty_analisis").Value = _cantidad_inicial
                'Next
            Next
        End If
    End Sub
End Class