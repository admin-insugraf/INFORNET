Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmListaPrecios
    Private clsProductoBl As ClsOperaciones.ORDER_PRODUCTION
    Private dtDetalleProducto As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Public _tipo_producto As String

    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim flag_importar As Boolean = False
    Dim dtDocumentos_importador_compras As New DataTable
    Dim articuloBE As ClsEntidades.PART
    Dim listaProductos As List(Of ClsEntidades.PART)

    Private Sub FrmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ProductoMarca()
    End Sub
    Private Sub ProductoMarca()
        Try
            clsProductoBl = New ClsOperaciones.ORDER_PRODUCTION
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = clsProductoBl.get_Lista_Costos_MP_EE(_tipo_producto)
            dtv = New DataView
            dtv = dtdetalleArticuloPrincipal.DefaultView

            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                DgvdetalleArticulo.DataSource = dtv
                STRorden = DgvdetalleArticulo.Columns("Codigo").Name & "+" & DgvdetalleArticulo.Columns("Descripcion_Articulo").Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                STRorden = ""
                lblCantidad.Text = "Se encontraron 0 registros"
                DgvdetalleArticulo.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("Codigo", Type.GetType("System.String")) '0
            dtdetalleArticuloPrincipal.Columns.Add("Descripcion_Articulo", Type.GetType("System.String")) '1
            dtdetalleArticuloPrincipal.Columns.Add("Unidad", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("Costo", Type.GetType("System.Double")) '3
            dtdetalleArticuloPrincipal.Columns.Add("CostoME", Type.GetType("System.Double")) '4

            DgvdetalleArticulo.DataSource = Nothing
            DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal

            DgvdetalleArticulo.Columns("Codigo").ReadOnly = True
            DgvdetalleArticulo.Columns("Descripcion_Articulo").ReadOnly = True
            DgvdetalleArticulo.Columns("Unidad").ReadOnly = True

            DgvdetalleArticulo.Columns("Codigo").Width = 100
            DgvdetalleArticulo.Columns("Descripcion_Articulo").Width = 450
            DgvdetalleArticulo.Columns("Unidad").Width = 100
            DgvdetalleArticulo.Columns("Costo").Width = 100
            DgvdetalleArticulo.Columns("CostoME").Width = 100

            DgvdetalleArticulo.Columns("Codigo").HeaderText = "CODIGO"
            DgvdetalleArticulo.Columns("Descripcion_Articulo").HeaderText = "DESCRIPCION"
            DgvdetalleArticulo.Columns("Unidad").HeaderText = "U.M."
            DgvdetalleArticulo.Columns("Costo").HeaderText = "COSTO UNITARIO MN"
            DgvdetalleArticulo.Columns("CostoME").HeaderText = "COSTO UNITARIO ME"

            DgvdetalleArticulo.Columns("Codigo").DisplayIndex = 0
            DgvdetalleArticulo.Columns("Descripcion_Articulo").DisplayIndex = 1
            DgvdetalleArticulo.Columns("Unidad").DisplayIndex = 2
            DgvdetalleArticulo.Columns("Costo").DisplayIndex = 4
            DgvdetalleArticulo.Columns("CostoME").DisplayIndex = 3

            DgvdetalleArticulo.Columns("Costo").DefaultCellStyle.Format = "N4"
            DgvdetalleArticulo.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns("CostoME").DefaultCellStyle.Format = "N4"
            DgvdetalleArticulo.Columns("CostoME").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DgvdetalleArticulo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles rbmarca.MouseClick
        ProductoMarca()
    End Sub

    Private Function Guardar() As Boolean
        Dim estado As Boolean = True
        Try
            Me.Cursor = Cursors.WaitCursor
            If rbmuestramedica.Checked = False Then
                clsProductoBl = New ClsOperaciones.ORDER_PRODUCTION
                clsProductoBl.Actualizacion_Costos_MP_EE(String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO, dtdetalleArticuloPrincipal, ProgressBar1, 0)
                clsProductoBl = Nothing
            ElseIf rbmuestramedica.Checked = True Then
                clsProductoBl = New ClsOperaciones.ORDER_PRODUCTION
                clsProductoBl.Actualizacion_Costos_MP_EE(String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO, dtdetalleArticuloPrincipal, ProgressBar1, 1)
                clsProductoBl = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then Exit Sub
        If Guardar() = True Then
            MsgBox("Registro de Costos generada correctamente.", MsgBoxStyle.Information, "Sistemas")
        End If
        MostrandoDatos()
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DgvdetalleArticulo.CurrentCell.ColumnIndex
        If columna = 4 Or columna = 3 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ".") And (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf columna = 3 Then
            e.Handled = True
        End If
    End Sub
    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, _
   ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DgvdetalleArticulo.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf SoloNumeros_Keypress
    End Sub
    Private Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
        Me.Close()
    End Sub

    Private Sub DgvdetalleArticulo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvdetalleArticulo.CellEndEdit
        gbopciones.Enabled = False
    End Sub


    Private Sub MostrandoDatos()
        Try
            If rbmarca.Checked = True Then
                ProductoMarca()
            End If
            gbopciones.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        If gbopciones.Enabled = False Then
            If MessageBox.Show("¿Desea guardar Cambios.?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                btnGrabar_Click(sender, e)
            Else
                MostrandoDatos()
            End If
        Else
            gbopciones.Enabled = True
        End If

    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then

        ElseIf txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = DgvdetalleArticulo.Columns("Codigo").Name
                dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = DgvdetalleArticulo.Columns("Descripcion_Articulo").Name
                    dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = DgvdetalleArticulo.Columns("Codigo").Name & "+" & DgvdetalleArticulo.Columns("Descripcion_Articulo").Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub btn_importador_compras_aut_Click(sender As Object, e As EventArgs) Handles btn_importador_compras_aut.Click
        ToolStrip1.Enabled = False
        pnl_importador_compras.Visible = True
        txt_ruta_oficial.Text = ""
        flag_importar = False
        dgvdetalles_imp.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStrip1.Enabled = True
        flag_importar = True
        pnl_importador_compras.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx;*.xls"
            .Title = "Open File"
            .ShowDialog()
        End With
        txt_ruta_oficial.Text = myFileDialog.FileName.ToString
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        flag_importar = False
        If txt_ruta_oficial.Text.Trim = "" Then
            MsgBox("Debe elegir una Ruta del archivo a Importar.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dt_datos As DataTable
            Dim ds_datos As DataSet

            Call importarExcel(dgvdetalles_imp, txt_ruta_oficial.Text.Trim, "Hoja1")
            If dgvdetalles_imp.Rows.Count = 0 Then Me.Cursor = Cursors.Default : Exit Sub
            ds_datos = dgvdetalles_imp.DataSource
            dt_datos = ds_datos.Tables(0)

            If dgvdetalles_imp.Rows.Count > 0 Then
                btn_importar_detalle.Enabled = True
                clsProductoBl = New ClsOperaciones.ORDER_PRODUCTION
                If clsProductoBl.Ejecutar_Eliminacion_Movimientos_Temporales("SP_IMPORTAR_LIMPIAR_COSTOS_MP_EE") = True Then
                    If clsProductoBl.CopyDataTableBulk_Importar_Costos_MP_EE(dt_datos, "COSTOS_MP_EE") Then
                        dtDocumentos_importador_compras = clsProductoBl.Mostrar_Documentos_Importados_Costos_MP_EE(_tipo_producto)
                        If dtDocumentos_importador_compras.Rows.Count > 0 Then
                            dgvdetalles_imp.DataSource = dtDocumentos_importador_compras

                            dgvdetalles_imp.Columns("Codigo").Width = 100
                            dgvdetalles_imp.Columns("DESCRIPCION").Width = 450
                            dgvdetalles_imp.Columns("U.M.").Width = 100
                            dgvdetalles_imp.Columns("Costo").Width = 100
                            dgvdetalles_imp.Columns("Costo_me").Width = 100

                            dgvdetalles_imp.Columns("Costo").DefaultCellStyle.Format = "N3"
                            dgvdetalles_imp.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvdetalles_imp.Columns("Costo_me").DefaultCellStyle.Format = "N3"
                            dgvdetalles_imp.Columns("Costo_me").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                            dgvdetalles_imp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            flag_importar = True
                        Else
                            dgvdetalles_imp.DataSource = Nothing
                        End If
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_importar_detalle_Click(sender As Object, e As EventArgs) Handles btn_importar_detalle.Click
        If dgvdetalles_imp.Rows.Count() = 0 Then Exit Sub
        If dgvdetalles_imp.CurrentRow Is Nothing Then Exit Sub

        For i As Integer = 0 To dgvdetalles_imp.Rows.Count - 1
            If dgvdetalles_imp.Rows(i).Cells("CODIGO").Value = "" Then
                MsgBox("No existe el codigo del Producto en la fila " & (i + 1), MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            End If
        Next

        If MessageBox.Show("Se van a registrar los Costos de los Productos en la lista." & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Guardar_Importacion_Costos_MP_EE() Then
                ToolStrip1.Enabled = True
                ProductoMarca()
                MsgBox("Importación de Costos generado correctamente.", MsgBoxStyle.Information)
                Button1_Click(sender, e)
            End If
        End If
    End Sub

    Private Function Guardar_Importacion_Costos_MP_EE() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            articuloBE = New ClsEntidades.PART
            listaProductos = New List(Of ClsEntidades.PART)

            For x As Integer = 0 To dgvdetalles_imp.Rows.Count - 1
                articuloBE = New ClsEntidades.PART
                articuloBE.ID = dgvdetalles_imp.Rows(x).Cells("CODIGO").Value
                articuloBE.PESO = dgvdetalles_imp.Rows(x).Cells("COSTO").Value
                articuloBE.UNIT_PRICE = dgvdetalles_imp.Rows(x).Cells("COSTO_ME").Value
                listaProductos.Add(articuloBE)
            Next

            clsProductoBl = New ClsOperaciones.ORDER_PRODUCTION
            If clsProductoBl.Insert_Importar_Costos_MP_EE(listaProductos) Then
                Me.Cursor = Cursors.Default
                clsProductoBl = Nothing
                Return True
            Else
                Return False
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub txt_por_utilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_por_utilidad.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_por_utilidad.Text = "" Then
            MsgBox("Debe ingresar un Tipo de Cambio.", MsgBoxStyle.Critical, "Sistemas")
            txt_por_utilidad.Focus()
            Exit Sub
        End If

        If Preguntar("Seguro de convertir los precios con el Tipo de Cambio?") Then
            Me.Cursor = Cursors.WaitCursor
            Dim _precio_dolares As Double = 0
            Dim Codigo As String
            For i As Integer = 0 To DgvdetalleArticulo.Rows.Count - 1
                Codigo = DgvdetalleArticulo.Rows(i).Cells("Codigo").Value.ToString
                _precio_dolares = DgvdetalleArticulo.Rows(i).Cells("CostoME").Value

                If _precio_dolares > 0 Then
                    For Each ROW As DataRow In dtdetalleArticuloPrincipal.Select("Codigo='" & Codigo & "'")
                        dtdetalleArticuloPrincipal.BeginInit()
                        ROW("Costo") = Math.Abs(Math.Round(_precio_dolares * CDbl(txt_por_utilidad.Text), 4))
                        dtdetalleArticuloPrincipal.EndInit()
                        dtdetalleArticuloPrincipal.AcceptChanges()
                    Next
                End If

                _precio_dolares = 0
            Next

            DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DgvdetalleArticulo_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvdetalleArticulo.CellFormatting
        If DgvdetalleArticulo.Columns(e.ColumnIndex).Name = "CostoME" Then
            e.CellStyle.BackColor = Color.LightGoldenrodYellow
        End If
    End Sub
End Class