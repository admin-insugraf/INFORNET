Imports System.Windows.Forms

Public Class FrmArticuloActualizacionDescuentos
    Private clsProductoBl As ClsOperaciones.PART
    Private dtDetalleProducto As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable


    Private Sub ProductoMarca()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Marca")
            dtDetalleProducto = clsProductoBl.get_ArticuloMarcaDescuento()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
                DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(5).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            Else
                DgvdetalleArticulo.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductoGenerico()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Generico")
            dtDetalleProducto = clsProductoBl.get_ArticuloGenericoDescuento()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
                DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(5).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "##,##0.00"
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
            dtDetalleProducto = clsProductoBl.get_ArticuloMuestraMedicaDescuento()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
                DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(5).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "##,##0.00"
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
            dtDetalleProducto = clsProductoBl.get_ArticuloMaquilaDescuento()
            If dtDetalleProducto.Rows.Count() <> 0 Then
                GenerarColummnaDataTable()
                dtdetalleArticuloPrincipal = dtDetalleProducto
                DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
                DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(5).DefaultCellStyle.Format = "##,##0.00"
                DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "##,##0.00"
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
            dtdetalleArticuloPrincipal.Columns.Add("Codigo", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("Descripcion_Articulo", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("Presentacion", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DescDistribuidor_Desc1", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescDistribuidor_Desc2", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescFarmaciaDesc3", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescFarmaciaDesc4", Type.GetType("System.Double"))
            DgvdetalleArticulo.DataSource = Nothing
            DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal
            DgvdetalleArticulo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvdetalleArticulo.Columns(0).Width = 60
            DgvdetalleArticulo.Columns(0).ReadOnly = True
            DgvdetalleArticulo.Columns(1).Width = 220
            DgvdetalleArticulo.Columns(2).Width = 180
            DgvdetalleArticulo.Columns(3).Width = 137
            DgvdetalleArticulo.Columns(3).HeaderText = "Descuento Distribuidor Descuento 1"
            DgvdetalleArticulo.Columns(4).Width = 137
            DgvdetalleArticulo.Columns(4).HeaderText = "Descuento Distribuidor Descuento 2"
            DgvdetalleArticulo.Columns(5).Width = 137
            DgvdetalleArticulo.Columns(5).HeaderText = "Descuento Farmacia y Botica Descuento 1"
            DgvdetalleArticulo.Columns(6).Width = 137
            DgvdetalleArticulo.Columns(6).HeaderText = "Descuento Farmacia y Botica Descuento 2"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmArticuloActualizacionPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductoMarca()
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
            clsProductoBl = New ClsOperaciones.PART
            clsProductoBl.ActualizacionProductosDescuentos(LibComunVar.ClsVarComun.USUARIO, dtdetalleArticuloPrincipal, ProgressBar1)
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleArticuloPrincipal.Rows.Count() = 0 Then Exit Sub
        'If gbopciones.Enabled = False Then Exit Sub
        If Guardar() = True Then
            MsgBox("Actualizacion Generada Correcta.", MsgBoxStyle.Information, "Sistemas")
        End If
        MostrandoDatos()
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DgvdetalleArticulo.CurrentCell.ColumnIndex
        If columna = 3 Or columna = 4 Or columna = 5 Or columna = 6 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda  
            Dim txt As TextBox = CType(sender, TextBox)
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ".") And (txt.Text.Contains(".") = False) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
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
        If gbopciones.Enabled = False Then
            If MessageBox.Show("¿Desea Guardar Cambios.?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                btnGrabar_Click(sender, e)
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If

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
 
End Class