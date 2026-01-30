Imports System.Windows.Forms
Imports System.Drawing
Imports LibComunVar
Imports LibContabilidad
Imports LibSeguridad.ClsUsuario
Imports System.Data.SqlClient.SqlConnection

Public Class FrmArticuloActualizacionPrecio

    Private clsProductoBl As ClsOperaciones.PART
    Private dtDetalleProducto As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable

    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Public dtUsuarioAcceso As DataTable


    Private Sub ProductoMarca()
        Try
            clsProductoBl = New ClsOperaciones.PART
            dtDetalleProducto = New DataTable("Marca")
            dtDetalleProducto = clsProductoBl.get_ArticuloMarca()
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
            dtdetalleArticuloPrincipal.Columns.Add("Codigo", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("Descripcion_Articulo", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("Presentacion", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("V.V.F", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescDistribuidor_Desc1", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescDistribuidor_Desc2", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescFarmaciaDesc3", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DescFarmaciaDesc4", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("Marca_Generico", Type.GetType("System.Double"))
            DgvdetalleArticulo.DataSource = Nothing
            DgvdetalleArticulo.DataSource = dtdetalleArticuloPrincipal

            DgvdetalleArticulo.Columns(0).ReadOnly = True
            DgvdetalleArticulo.Columns(1).ReadOnly = True
            DgvdetalleArticulo.Columns(2).ReadOnly = True

            DgvdetalleArticulo.Columns(0).Width = 50
            DgvdetalleArticulo.Columns(1).Width = 370
            DgvdetalleArticulo.Columns(2).Width = 170
            DgvdetalleArticulo.Columns(3).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(4).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(5).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(6).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(7).DefaultCellStyle.Format = "N2"
            DgvdetalleArticulo.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvdetalleArticulo.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DgvdetalleArticulo.Columns(3).Width = 70
            DgvdetalleArticulo.Columns(4).Width = 70
            DgvdetalleArticulo.Columns(5).Width = 70
            DgvdetalleArticulo.Columns(6).Width = 70
            DgvdetalleArticulo.Columns(7).Width = 70
            'DgvdetalleArticulo.Columns(4).Width = 86
            DgvdetalleArticulo.Columns(8).Visible = False

            DgvdetalleArticulo.Columns(0).HeaderText = "Codigo"
            DgvdetalleArticulo.Columns(1).HeaderText = "Descripción del Producto"
            DgvdetalleArticulo.Columns(2).HeaderText = "Presentación"
            DgvdetalleArticulo.Columns(3).HeaderText = "V.V.F."
            DgvdetalleArticulo.Columns(4).HeaderText = "Desc. Dist. 1"
            DgvdetalleArticulo.Columns(5).HeaderText = "Desc. Dist. 2"
            DgvdetalleArticulo.Columns(6).HeaderText = "Desc. Far. 1"
            DgvdetalleArticulo.Columns(7).HeaderText = "Desc. Far. 2"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmArticuloActualizacionPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
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
        gb_pas_elimina_planilla.Visible = True
        ToolStrip1.Enabled = False
        gbopciones.Enabled = False
        DgvdetalleArticulo.Enabled = False
        txtpassword.Text = ""
        txtpassword.Focus()
    End Sub

    Private Sub SoloNumeros_Keypress(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DgvdetalleArticulo.CurrentCell.ColumnIndex
        If columna = 3 Then
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

 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtpassword.Text = String.Empty Then
            MessageBox.Show("Debe ingresar un contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Exit Sub
        End If
        If ValidarUsuariosIngreso() = True Then
            If Guardar() = True Then
                MsgBox("Actualizacion Generada Correcta.", MsgBoxStyle.Information, "Sistemas")
            End If
            MostrandoDatos()
            Button3_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gb_pas_elimina_planilla.Visible = False
        ToolStrip1.Enabled = True
        gbopciones.Enabled = True
        DgvdetalleArticulo.Enabled = True
    End Sub
    Private Function ValidarUsuariosIngreso() As Boolean
        Dim estado As Boolean = True
        Dim STRUserSys As String, STRPassSys As String
        Try
            ClsUsuarioBl = New LibSeguridad.ClsUsuario
            ClsData = New LibConexion.ClsData
            dtUsuarioAcceso = New DataTable
            Dim codigoUsuario As String = String.Empty
            codigoUsuario = "admin"
            dtUsuarioAcceso = ClsUsuarioBl.ValidarUsuariosIngresos(codigoUsuario)
            If dtUsuarioAcceso.Rows.Count() <> 0 Then
                If ClsUsuarioBl.ESTADO = "N" Then
                    MessageBox.Show("El estado del usuario ingresado se encuentra Inactivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    estado = False
                    Exit Try
                Else
                    STRUserSys = ClsUsuarioBl.CODUSUARIO
                    STRPassSys = ClsUsuarioBl.PASSUSUARIO
                    STRPassSys = ClsData.DesEncryptString(STRPassSys)
                    If txtpassword.Text = STRPassSys Then
                        estado = True
                        Exit Try
                    ElseIf txtpassword.Text <> STRPassSys Then
                        MessageBox.Show("El password ingresado es incorrecto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        estado = False
                        Exit Try
                    End If
                End If
            Else
                MessageBox.Show("El Usuario ingresado es incorrecto o no Existe, Verifique.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function


    Private Sub rbmarca_CheckedChanged(sender As Object, e As EventArgs)
        ProductoMarca()
    End Sub

    Private Sub rbgenericos_CheckedChanged(sender As Object, e As EventArgs)
        ProductoGenerico()
    End Sub
End Class