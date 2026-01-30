Imports LibConsultasComun
Public Class frmUbigeo

    Private dtUbigeo As DataTable
    Private LibComun As LibConsultasComun.ClsComun
    Private STRCodUbigeo As String
    Private STRDesUbigeo As String

    Public Property Codigo_Ubigeo As String
        Get
            Return STRCodUbigeo
        End Get
        Set(value As String)
            STRCodUbigeo = value
        End Set
    End Property
    Public Property Descripcion_Ubigeo As String
        Get
            Return STRDesUbigeo
        End Get
        Set(value As String)
            STRDesUbigeo = value
        End Set
    End Property

    Private Sub frmUbigeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Ubigeo()
    End Sub
    Private Sub Cargar_Ubigeo()
        dtUbigeo = New DataTable
        LibComun = New LibConsultasComun.ClsComun
        dtUbigeo = LibComun.get_Lista_ubigeo

        Dim nuevoNodo As New TreeNode
        tvUbigeo.Nodes.Clear()
        Dim STRCodigo As String
        Dim STRDescripcion As String
        Dim STRNivel As String

        For i As Integer = 0 To dtUbigeo.Rows.Count - 1
            Try
                STRCodigo = dtUbigeo.Rows(i)(0).ToString.Trim
                STRDescripcion = dtUbigeo.Rows(i)(1).ToString.Trim
                STRNivel = dtUbigeo.Rows(i)(2).ToString.Trim
                If STRCodigo.Trim = "00" Then
                    nuevoNodo.Text = "Ubigeo " & STRDescripcion
                    Exit Try
                End If
                If STRCodigo.Trim.Length = 2 Then
                    nuevoNodo.Nodes.Add(STRCodigo, STRDescripcion)
                End If
            Catch ex As Exception
            End Try
        Next
        For i As Integer = 0 To dtUbigeo.Rows.Count - 1
            Try
                STRCodigo = dtUbigeo.Rows(i)(0).ToString.Trim
                STRDescripcion = dtUbigeo.Rows(i)(1).ToString.Trim
                STRNivel = dtUbigeo.Rows(i)(2).ToString.Trim
                If STRCodigo.Trim.Length = 4 Then
                    nuevoNodo.Nodes(STRNivel).Nodes.Add(STRCodigo, STRDescripcion)
                End If
            Catch ex As Exception
            End Try
        Next
        For i As Integer = 0 To dtUbigeo.Rows.Count - 1
            Try
                STRCodigo = dtUbigeo.Rows(i)(0).ToString.Trim
                STRDescripcion = dtUbigeo.Rows(i)(1).ToString.Trim
                STRNivel = dtUbigeo.Rows(i)(2).ToString.Trim
                If STRCodigo.Trim.Length = 6 Then
                    nuevoNodo.Nodes(STRNivel.Substring(0, 2)).Nodes(STRNivel).Nodes.Add(STRCodigo, STRDescripcion)
                End If
            Catch ex As Exception
            End Try
        Next
        tvUbigeo.Nodes.Add(nuevoNodo)
        LibComun = Nothing
    End Sub

    Private Sub tvUbigeo_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUbigeo.AfterSelect
        txtSeleccionado.Text = tvUbigeo.SelectedNode.Name & " - " & tvUbigeo.SelectedNode.Text
    End Sub

    Private Sub tvUbigeo_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvUbigeo.NodeMouseDoubleClick
        Me.Codigo_Ubigeo = e.Node.Name
        Me.Descripcion_Ubigeo = e.Node.Text
        Me.Close()
    End Sub
End Class