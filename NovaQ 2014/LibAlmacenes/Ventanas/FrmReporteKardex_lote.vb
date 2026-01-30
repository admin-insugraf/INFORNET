Imports LibCobranzas
Imports System.Windows.Forms

Public Class FrmReporteKardex_lote
    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporteKardex As DataTable
    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte

    Dim clsFamiliasBl As ClsOperaciones.FAMILY
    Dim dtFamilia As DataTable

    Private Sub MostrarReporte(ByVal TYPE_PART As String, ByVal FAMILY As String, ByVal WHO_ID As String, ByVal LOTE As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dtReporteKardex = New DataTable("Lotes_")
            dtReporteKardex = reporteBL.Get_ImprimirReporte_kardex_lote(TYPE_PART, FAMILY, WHO_ID, LOTE)
            If dtReporteKardex.Rows.Count() <> 0 Then
                Dim Almacen As String = String.Empty

                If chklstAlmacenes.CheckedItems.Count() <> 1 Then
                    Almacen = "VARIOS LOS ALMACENES"
                Else
                    Almacen = chklstAlmacenes.CheckedItems(0)
                End If
                If checkLotesTodos.Checked = True Then
                    LOTE = "TODOS LOS LOTES"
                End If
                crystalBL.Muestra_Reporte("rpt_kardex_lotes.rpt", dtReporteKardex, "", "", "", "@LOTES;" & LOTE, "@ALMACEN;" & Almacen)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub MostrarFamilias()
        Try
            clsFamiliasBl = New ClsOperaciones.FAMILY
            dtFamilia = New DataTable
            dtFamilia = clsFamiliasBl.get_MostrarFamilias()
            clsFamiliasBl = Nothing
            If dtFamilia.Rows.Count() <> 0 Then
                cboFamilia.DataSource = dtFamilia
                cboFamilia.DisplayMember = "DESCRIPCION"
                cboFamilia.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TiposArticulos()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_TipoArticulo()
            If dtTipoProducto.Rows.Count() <> 0 Then
                cboTipoProducto.Items.Clear()
                Me.cboTipoProducto.DataSource = dtTipoProducto
                Me.cboTipoProducto.DisplayMember = "DESCRIPCION"
                Me.cboTipoProducto.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtAlmacen.Rows.Count() <> 0 Then
                chklstAlmacenes.Items.Clear()
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtAlmacen.Rows(i).Item("DESCRIPCION").ToString)
                Next
                'chklstAlmacenes.SelectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoLotes()
        Try
            Dim frmL As New frmBuscar
            frmL._Flag_Filtro = True
            frmL.CadenaConsulta = "PART_SP_S_PART_LOTES"
            frmL.Titulo = "Lotes"
            Dim id As String = String.Empty
            If checkAlmacen.Checked Then
                If chklstAlmacenes.CheckedItems.Count() = 0 Then
                    MsgBox("Debe seleccionar al menos un Almacen", MsgBoxStyle.Information)
                    Exit Try
                End If
                Dim i As Integer = 0
                Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                    ' idAlmacen = idAlmacen + "'" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & "',"
                    id = id & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                    i = i + 1
                Loop
                id = Mid(id, 1, id.Length - 1)
                frmL.Filtros1 = id
                frmL.ShowDialog()
                If frmL.Data_Matriz.Rows.Count > 0 Then
                    txtcodigolote.Text = frmL.Data_Matriz.Rows(0).Item(1)
                End If
                frmL.Close()
            Else
                If chklstAlmacenes.CheckedItems.Count() = 0 Then
                    MsgBox("Debe seleccionar al menos un Almacen", MsgBoxStyle.Information)
                    Exit Try
                End If
                Dim i As Integer = 0
                Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                    ' idAlmacen = idAlmacen + "'" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & "',"
                    id = id & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                    i = i + 1
                Loop
                id = Mid(id, 1, id.Length - 1)
                frmL.Filtros1 = id
                frmL.ShowDialog()
                If frmL.Data_Matriz.Rows.Count > 0 Then
                    txtcodigolote.Text = frmL.Data_Matriz.Rows(0).Item(1)
                End If
                frmL.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmReporteKardex_lote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TiposArticulos()
        MostrarFamilias()
        MostrandoAlmacenes()
        checkAlmacen.Checked = True
        checkAlmacen.Text = "Activar / Desactivar Todos"
        ActivarCheck(True)
    End Sub

    Private Sub cboTipoProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoProducto.SelectedIndexChanged

    End Sub

    Private Sub cboAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub checkLotesTodos_CheckedChanged(sender As Object, e As EventArgs) Handles checkLotesTodos.CheckedChanged
        If checkLotesTodos.Checked = True Then
            txtcodigolote.Enabled = False
            txtcodigolote.Text = String.Empty
            txtdescripcionLote.Text = String.Empty
        Else
            txtcodigolote.Enabled = True
            txtcodigolote.Text = String.Empty
            txtdescripcionLote.Text = String.Empty
        End If
    End Sub

    Private Function Validaciones(ByRef TYPE_PART As String, ByRef FAMILY As String, ByRef WHO_ID As String, ByRef LOTE As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Seleccionando tIPO ARTICULO
            TYPE_PART = cboTipoProducto.SelectedValue().ToString
            'Seleccionando FAMILIA 
            FAMILY = cboFamilia.SelectedValue().ToString
            'Seleccionando Almacen
            If chklstAlmacenes.CheckedItems.Count() = 0 Then
                MsgBox("Debe seleccionar al menos un Almacen", MsgBoxStyle.Information)
                estado = False
                Exit Try
            End If
                Dim id As String = ""
                Dim i As Integer = 0
                Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                    id = id + "'" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & "',"
                    i = i + 1
                Loop
                id = Mid(id, 1, id.Length - 1)
                WHO_ID = id
            If checkLotesTodos.Checked = True Then
                LOTE = ""
            Else
                If txtcodigolote.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Lote.", MsgBoxStyle.Information)
                    estado = False
                    Exit Try
                End If
                LOTE = txtcodigolote.Text
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_TYPE_PART As String = String.Empty
        Dim Ref_WHO_ID As String = String.Empty
        Dim Ref_LOTE As String = String.Empty
        Dim Ref_FAMILY As String = String.Empty
        If Validaciones(Ref_TYPE_PART, Ref_FAMILY, Ref_WHO_ID, Ref_LOTE) = False Then Exit Sub
        MostrarReporte(Ref_TYPE_PART, Ref_FAMILY, Ref_WHO_ID, Ref_LOTE)
    End Sub

    Private Sub txtcodigolote_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigolote.MouseDoubleClick
        MostrandoLotes()
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        If checkAlmacen.Checked Then
            ActivarCheck(True)
            chklstAlmacenes.Enabled = False
        Else
            ActivarCheck(False)
            chklstAlmacenes.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class