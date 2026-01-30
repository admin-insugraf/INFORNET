Imports System.Windows.Forms
Public Class FrmDetallesRequisiciones
    Private DetRequilib As ClsOperaciones.PURCHASE_ORDER
    Private STRTitulo As String
    Private dtv As DataView
    Public _tipo_requisicion As String
    Public _numero_requisicion As String
    Public _lista_items As String = String.Empty
    Protected dtdetalles As New DataTable
    Private Sub FrmDetallesRequisiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Detalles_Requisiciones()
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalles = New DataTable("Detalles_Requisicion")
            dtdetalles.Columns.Add("Selec.", Type.GetType("System.Boolean"))
            dtdetalles.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalles.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalles.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalles.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalles.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalles.Columns.Add("COMMENT", Type.GetType("System.String"))
            dtdetalles.Columns.Add("PRIORIDAD", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Imprenta()
        Try
            dtdetalles = New DataTable("Detalles_Requisicion")
            dtdetalles.Columns.Add("Selec.", Type.GetType("System.Boolean"))
            dtdetalles.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalles.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalles.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalles.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalles.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalles.Columns.Add("COD_PRODUCTO", Type.GetType("System.String"))
            dtdetalles.Columns.Add("PRODUCTO", Type.GetType("System.String"))
            dtdetalles.Columns.Add("COMMENT", Type.GetType("System.String"))
            dtdetalles.Columns.Add("PRIORIDAD", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Detalles_Requisiciones()
        Try
            DetRequilib = New ClsOperaciones.PURCHASE_ORDER
            Dim dtdetalles As New DataTable
            dtv = New DataView
            If _tipo_requisicion = "RI" Then
                dtdetalles = DetRequilib.Mostrar_Detalles_Requisicion_Imprenta(_tipo_requisicion, _numero_requisicion)
                dgvdato_imprenta.Visible = True
                dgvdato.Visible = False
                dtv = dtdetalles.DefaultView
                dgvdato_imprenta.DataSource = Nothing
                If dtdetalles.Rows.Count() <> 0 Then
                    dgvdato_imprenta.DataSource = dtv
                    dgvdato_imprenta.AutoResizeColumns()
                    dgvdato_imprenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For i As Integer = 0 To dgvdato_imprenta.Columns.Count - 1
                        dgvdato_imprenta.Columns(i).ReadOnly = True
                    Next
                    dgvdato_imprenta.Columns(0).ReadOnly = False
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                End If
            Else
                dtdetalles = DetRequilib.Mostrar_Detalles_Requisicion(_tipo_requisicion, _numero_requisicion)
                dgvdato_imprenta.Visible = False
                dgvdato.Visible = True
                dtv = dtdetalles.DefaultView
                dgvdato.DataSource = Nothing
                If dtdetalles.Rows.Count() <> 0 Then
                    dgvdato.DataSource = dtv
                    dgvdato.AutoResizeColumns()
                    dgvdato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For i As Integer = 0 To dgvdato.Columns.Count - 1
                        dgvdato.Columns(i).ReadOnly = True
                    Next
                    dgvdato.Columns(0).ReadOnly = False
                    lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                End If
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Public Property Titulo As String
        Get
            Return STRTitulo
        End Get
        Set(value As String)
            STRTitulo = value
        End Set
    End Property
    
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvdato_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvdato.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvdato.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvdato.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        Listar_Marcados()
        If _lista_items.Length = 0 Then
            MsgBox("Debe seleccionar algun item para poder continuar.!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub
    
    Private Sub Listar_Marcados()
        _lista_items = String.Empty
        ' dgvdato.CommitEdit(DataGridViewDataErrorContexts.Commit)

        If _tipo_requisicion = "RI" Then
            For i As Integer = 0 To dgvdato_imprenta.Rows.Count - 1
                If dgvdato_imprenta.Rows(i).Cells("Sel_imprenta").Value = True Then
                    '_lista_items = _lista_items & "'" & dgvdato_imprenta.Rows(i).Cells("PART_ID_imprenta").Value & "',"
                    _lista_items = _lista_items & "'" & dgvdato_imprenta.Rows(i).Cells("ITEM_IMPRENTA").Value & "',"
                End If
            Next
        Else
            For i As Integer = 0 To dgvdato.Rows.Count - 1
                If dgvdato.Rows(i).Cells("Sel").Value = True Then
                    _lista_items = _lista_items & "'" & dgvdato.Rows(i).Cells("PART_ID").Value & "',"
                End If
            Next
        End If
        
        If _lista_items.Length > 0 Then
            _lista_items = Mid(_lista_items, 1, _lista_items.Length - 1)
        End If
    End Sub

    Private Sub dgvdato_imprenta_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvdato_imprenta.CurrentCellDirtyStateChanged
        Dim cb As DataGridViewCheckBoxCell = TryCast(Me.dgvdato_imprenta.CurrentCell, DataGridViewCheckBoxCell)
        If cb IsNot Nothing Then
            dgvdato_imprenta.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class