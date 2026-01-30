Imports System.Windows.Forms
Public Class FrmListaPrecios
    Private clsProductoBl As ClsOperaciones.PART
    Private dtDetalleProducto As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Private dtv As DataView
    Dim STRorden As String = String.Empty

    Private Sub FrmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ProductoMarca()
        txtbuscarArticulo.Focus()
    End Sub
    Private Sub ProductoMarca()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Marca")
            dtv = New DataView
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = clsProductoBl.get_ListaPrecios()
            dtv = dtdetalleArticuloPrincipal.DefaultView
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                DgvdetalleArticulo.DataSource = dtv
                STRorden = DgvdetalleArticulo.Columns(0).Name & "+" & DgvdetalleArticulo.Columns(1).Name
            Else
                DgvdetalleArticulo.DataSource = Nothing
                STRorden = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductoGenerico()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Generico")
            dtDetalleProducto = clsProductoBl.get_ArticuloGenerico()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            Else
                DgvdetalleArticulo.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductoMuestraMedica()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("M_Medica")
            dtDetalleProducto = clsProductoBl.get_ArticuloMuestraMedica()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            Else
                DgvdetalleArticulo.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductoMaquila()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Maquila")
            dtDetalleProducto = clsProductoBl.get_ArticuloMaquila()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            Else
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
            dtdetalleArticuloPrincipal.Columns.Add("Presentacion", Type.GetType("System.String")) '2
            dtdetalleArticuloPrincipal.Columns.Add("Costo", Type.GetType("System.Double")) '3
            dtdetalleArticuloPrincipal.Columns.Add("Precio", Type.GetType("System.Double")) '4
            dtdetalleArticuloPrincipal.Columns.Add("Marca_Generico", Type.GetType("System.Double")) '5
            dtdetalleArticuloPrincipal.Columns.Add("Porcentaje.Ganancia.%", Type.GetType("System.String")) '6
            DgvdetalleArticulo.DataSource = Nothing
            DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            'DgvdetalleArticulo.Columns(0).Width = 80
            DgvdetalleArticulo.Columns(0).ReadOnly = True
            'DgvdetalleArticulo.Columns(1).Width = 250
            DgvdetalleArticulo.Columns(2).Visible = False
            DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "N6"
            DgvdetalleArticulo.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(3).HeaderText = "Precio Soles"
            'DgvdetalleArticulo.Columns(3).Visible = False
            DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "N6"
            DgvdetalleArticulo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(4).HeaderText = "Precio Dolares"
            DgvdetalleArticulo.Columns(5).Visible = False
            DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(6).Visible = False
            DgvdetalleArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles rbmarca.MouseClick
        ProductoMarca()
    End Sub


    Private Sub rbgenericos_MouseClick(sender As Object, e As MouseEventArgs) Handles rbgenericos.MouseClick
        ProductoGenerico()
    End Sub

    Private Sub rbmaquila_MouseClick(sender As Object, e As MouseEventArgs) Handles rbmaquila.MouseClick
        ProductoMaquila()
    End Sub

    Private Sub rbmuestramedica_MouseClick(sender As Object, e As MouseEventArgs) Handles rbmuestramedica.MouseClick
        ProductoMuestraMedica()
    End Sub

    Private Function Guardar() As Boolean
        Dim estado As Boolean = True
        Try
            Me.Cursor = Cursors.WaitCursor
            If rbmuestramedica.Checked = False Then
                clsProductoBl = New ClsOperaciones.PART
                clsProductoBl.ActualizacionProductos(String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO, dtdetalleArticuloPrincipal, ProgressBar1, 0)
                clsProductoBl = Nothing
            ElseIf rbmuestramedica.Checked = True Then
                clsProductoBl = New ClsOperaciones.PART
                clsProductoBl.ActualizacionProductos(String.Format("{0:HH:mm:ss}", DateTime.Now), LibComunVar.ClsVarComun.USUARIO, dtdetalleArticuloPrincipal, ProgressBar1, 1)
                clsProductoBl = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            estado = False
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then Exit Sub
        If Guardar() = True Then
            MostrandoDatos()
            MsgBox("Actualizacion Generada Correcta.", MsgBoxStyle.Information, "Sistemas")
        End If

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
            ElseIf rbgenericos.Checked = True Then
                ProductoGenerico()
            ElseIf rbmaquila.Checked = True Then
                ProductoMaquila()
            ElseIf rbmuestramedica.Checked = True Then
                ProductoMuestraMedica()
            End If
            gbopciones.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
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


    Private Sub txtbuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarArticulo.TextChanged
        If STRorden = "" Then Exit Sub
        If txtbuscarArticulo.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = DgvdetalleArticulo.Columns(0).Name
                dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = DgvdetalleArticulo.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = DgvdetalleArticulo.Columns(0).Name & "+" & DgvdetalleArticulo.Columns(1).Name
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub
End Class