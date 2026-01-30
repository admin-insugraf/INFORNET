Imports System.Windows.Forms

Public Class FrmFacturacion_Detalles_Hab
    Private DetRequilib As ClsTransacciones.COMPANY_TYPE
    Private STRTitulo As String
    Private dtv As DataView
    Public _tipo_requisicion As String
    Public _numero_requisicion As String
    Public _lista_items As String = String.Empty
    Protected dtdetalles As New DataTable

    Private Sub FrmFacturacion_Detalles_Hab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Detalles_Requisiciones()
    End Sub
    'Public Sub GenerarColummnaDataTable()
    '    Try
    '        dtdetalles = New DataTable("Detalles_Requisicion")
    '        dtdetalles.Columns.Add("Selec.", Type.GetType("System.Boolean"))
    '        dtdetalles.Columns.Add("ITEM", Type.GetType("System.Int64"))
    '        dtdetalles.Columns.Add("PART_ID", Type.GetType("System.String"))
    '        dtdetalles.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
    '        dtdetalles.Columns.Add("UNIT", Type.GetType("System.String"))
    '        dtdetalles.Columns.Add("SALDO", Type.GetType("System.Double"))
    '        dtdetalles.Columns.Add("FECHA", Type.GetType("System.String"))
    '        dtdetalles.Columns.Add("USO", Type.GetType("System.String"))
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub Detalles_Requisiciones()
        Try
            DetRequilib = New ClsTransacciones.COMPANY_TYPE
            Dim dtdetalles As New DataTable
            dtv = New DataView
            dtdetalles = DetRequilib.Mostrar_Detalles_Pedido(_numero_requisicion)
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
        For i As Integer = 0 To dgvdato.Rows.Count - 1
            If dgvdato.Rows(i).Cells("Sel").Value = True Then
                _lista_items = _lista_items & "'" & dgvdato.Rows(i).Cells("ID_ITEM").Value & "',"
            End If
        Next
        If _lista_items.Length > 0 Then
            _lista_items = Mid(_lista_items, 1, _lista_items.Length - 1)
        End If
    End Sub
End Class