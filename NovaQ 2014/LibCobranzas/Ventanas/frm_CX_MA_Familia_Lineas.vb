Imports System.Windows.Forms

Public Class frm_CX_MA_Familia_Lineas
    Public pCodFamilia As String
    Dim bol_nuevo As Boolean = False
    Dim LibData As LibConexion.ClsData
    Dim LineasBl As ClsNegocio.WAREHOUSE
    Dim dtdetalles As DataTable
    Dim _CODIGO_TIPO_ARTICULO As String

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub frm_CX_MA_Familia_Lineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Data()
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub Cargar_Data()
        Dim lineaBL As New ClsOperaciones.LINES
        Dim familiaBE As New ClsEntidades.FAMILY
        familiaBE.ID = pCodFamilia
        dgv_lineas_familia.DataSource = lineaBL.get_Lineas(familiaBE)
        dgv_lineas_familia.Columns(0).HeaderText = "Cod. Linea"
        dgv_lineas_familia.Columns(1).HeaderText = "Des. Linea"
        dgv_lineas_familia.Columns(2).HeaderText = "Cod. Tip. Articulo"
        dgv_lineas_familia.Columns(3).HeaderText = "Des. Tip. Articulo"
        dgv_lineas_familia.Columns(4).HeaderText = "Abreviatura"
        dgv_lineas_familia.Columns(5).HeaderText = "Opc. Guia/Facturacion"
        dgv_lineas_familia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        lineaBL = Nothing
        familiaBE = Nothing
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        tc_familia.SelectedIndex = 1
        gb_data.Enabled = True
        lblTipoArticulo.Text = ""
        bol_nuevo = True
        txt_cod.Enabled = False
        CorrelativoLinea()
        txt_des.Focus()
    End Sub

    Private Sub CorrelativoLinea()
        Try
            LineasBl = New ClsNegocio.WAREHOUSE
            dtdetalles = New DataTable("Correlativo")
            dtdetalles = LineasBl.get_GeneracionCodigoAutomaticoLineas()
            If dtdetalles.Rows.Count() <> 0 Then
                txt_cod.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If txt_cod.Text.Trim = "" Then
            Call Avisar("Ingrese el codigo")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            Call Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        If txttipoArticulo.Text.Trim = "" Then
            Call Avisar("Elija un tipo de articulo.")
            txttipoArticulo.Focus()
            Exit Sub
        End If
        'If txtcodigo.Text.Trim = "" Then
        '    Call Avisar("Ingrese una letra de identificacion.")
        '    txtcodigo.Focus()
        '    Exit Sub
        'End If

        Dim lineaBL As New ClsOperaciones.LINES
        Dim lineaBE As New ClsEntidades.LINES

        With lineaBE
            .FAMILY_ID = pCodFamilia
            .ID = txt_cod.Text.Trim
            .NAME = txt_des.Text.Trim
            .CODIGO_PART_TYPE = txttipoArticulo.Text.Trim
            .CODIGO = txtcodigo.Text
            .IS_SHOW_FACT_GUIA = IIf(chkmostrarfacturacion.Checked, "S", "N")
        End With

        If bol_nuevo Then
            lineaBL.Insert(lineaBE)
        Else
            lineaBL.Update(lineaBE)
        End If

        Call Cargar_Data()
        Call Avisar("Proceso generado correctamente!")

        lineaBE = Nothing
        lineaBL = Nothing

        Call btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Dim Sql As String = String.Empty
        If dgv_lineas_familia.Rows.Count = 0 Then Exit Sub
        If dgv_lineas_familia.CurrentRow Is Nothing Then Exit Sub

        txt_cod.Text = dgv_lineas_familia.CurrentRow.Cells("col_id").Value
        txt_des.Text = dgv_lineas_familia.CurrentRow.Cells("col_des").Value
        txttipoArticulo.Text = dgv_lineas_familia.CurrentRow.Cells("CODIGO_PART_TYPE").Value
        _CODIGO_TIPO_ARTICULO = dgv_lineas_familia.CurrentRow.Cells("CODIGO").Value
        txtcodigo.Text = _CODIGO_TIPO_ARTICULO
        chkmostrarfacturacion.Checked = IIf(dgv_lineas_familia.CurrentRow.Cells("IS_SHOW_FACT_GUIA").Value = "N", False, True)
        lblTipoArticulo.Text = dgv_lineas_familia.CurrentRow.Cells("NAME").Value


        bol_nuevo = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        tc_familia.SelectedIndex = 1
        txt_cod.Enabled = False
        txt_des.Focus()
        Botonera_Estado_Cambiar(True)
    End Sub

    Private Function get_MostrarDescripcion(ByVal cadena As String) As String
        Try
            dtTable = New DataTable
            LibData = New LibConexion.ClsData
            Dim description As String = String.Empty
            dtTable = LibData.Run_Query_DataTable(cadena)
            LibData.Dispose()
            description = dtTable.Rows(0).Item(0).ToString()
            Return description
        Catch ex As Exception
        End Try
    End Function

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lineas_familia.Rows.Count = 0 Then Exit Sub
        If dgv_lineas_familia.CurrentRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim lineaBL As New ClsOperaciones.LINES
            Dim lineaBE As New ClsEntidades.LINES
            lineaBE.FAMILY_ID = pCodFamilia
            lineaBE.ID = dgv_lineas_familia.CurrentRow.Cells("col_id").Value.ToString
            lineaBL.Delete(lineaBE)
            lineaBE = Nothing
            lineaBL = Nothing
            Call Avisar("Listo!")
            Call Cargar_Data()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_familia.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Private Sub txttipoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttipoArticulo.MouseDoubleClick
        Ayuda_TipoArticulos()
    End Sub

    Private Sub txttipoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoArticulos()
    End Sub
    Private Sub Ayuda_TipoArticulos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_PART_TYPE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Tipos de Articulos"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txttipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            lblTipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            _CODIGO_TIPO_ARTICULO = frm.Data_Matriz.Rows(0).Item(2).ToString
        End If
        frm.Close()
    End Sub
End Class