Imports System.Windows.Forms
Imports LibCobranzas

Public Class FrmTransportistaAct_Direcciones

    Private nuevo As Boolean
    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Dim clsBuscarBl As LibCobranzas.ClsBuscar

    Dim AlmacenBl As ClsOperaciones.DIRECCIONESTRANSPORTISTAS
    Dim AlmacenesBl As ClsNegocio.DIRECCIONESTRANSPORTISTAS
    Dim AlmacenEnt As ClsEntidades.DIRECCIONESTRANSPORTISTAS
    Dim dtdetalles As DataTable

    Dim LibData As LibConexion.ClsData
    Dim dtTable As DataTable
    Private Function Validar() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) Then
            Avisar("El codigo es obligatorio")
            TextBox1.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            Avisar("El codigo es obligatorio")
            TextBox2.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(TextBox3.Text) Then
            Avisar("La descripcion es obligatoria")
            TextBox3.Focus()
            Return False

        ElseIf String.IsNullOrEmpty(txtdirecentrega.Text) Then
            Avisar("La descripcion es obligatoria")
            TextBox3.Focus()
            Return False

        End If
        Return True
    End Function






    Private Sub CorrelativoAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.DIRECCIONESTRANSPORTISTAS
            dtdetalles = New DataTable("Correlativo")
            dtdetalles = AlmacenesBl.get_GeneracionCodigoAutomatico(txtCodigoTransportista.Text)
            If dtdetalles.Rows.Count() <> 0 Then
                txtCodigo.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.DIRECCIONESTRANSPORTISTAS
            AlmacenEnt = New ClsEntidades.DIRECCIONESTRANSPORTISTAS
            AlmacenEnt.ITEM = txtCodigo.Text
            AlmacenEnt.CODIGO = txtCodigoTransportista.Text
            AlmacenEnt.ADDR = txtdirecentrega.Text

            AlmacenEnt.DEPARTAMENTO_ID = TextBox6.Text

            AlmacenEnt.PROVINCIA_ID = TextBox5.Text

            AlmacenEnt.DISTRITO_ID = TextBox4.Text


            If AlmacenesBl.GuardarActualizar(AlmacenEnt, nuevo) = True Then
                MsgBox("Operacion Generada Correctamente", MsgBoxStyle.Information, "Mensaje/Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseDoubleClick
        TextBox6.Text = String.Empty
        Cargar_Departamento_direc_entrega()
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox5.Text = String.Empty
            Cargar_Provincia_direcc_entrega()
        End If
    End Sub

    Private Sub TextBox5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox5.MouseDoubleClick
        TextBox5.Text = String.Empty
        Cargar_Provincia_direcc_entrega()
    End Sub

    Private Sub TextBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseDoubleClick
        TextBox4.Text = String.Empty
        Cargar_Distrito_direc_entrega()
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox4.Text = String.Empty
            Cargar_Distrito_direc_entrega()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox5.Focus()
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox4.Focus()
    End Sub



    Private Sub Cargar_Departamento_direc_entrega()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'departamento
                TextBox1.Text = String.Empty
                TextBox2.Text = String.Empty
                'provincia
                TextBox3.Text = String.Empty
                TextBox4.Text = String.Empty
                'distrito
                TextBox5.Text = String.Empty
                TextBox6.Text = String.Empty

                ''datos del departamento
                TextBox6.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox3.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                gb_data.Enabled = True
                TextBox2.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Provincia_direcc_entrega()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_PROV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TextBox6.Text
            frm.Titulo = "Provincias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                'provincia
                TextBox5.Text = String.Empty
                TextBox2.Text = String.Empty
                'distrito
                TextBox4.Text = String.Empty
                TextBox1.Text = String.Empty
                TextBox5.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                TextBox2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                TextBox4.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cargar_Distrito_direc_entrega()
        Try


            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CLI_SP_S_CUSTOMER_UBIGEO_DIST"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = TextBox6.Text
            frm.Filtros2 = TextBox5.Text
            frm.Titulo = "Distritos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox4.Text = frm.Data_Matriz.Rows(0).Item("CODIGO").ToString
                TextBox1.Text = frm.Data_Matriz.Rows(0).Item("DISTRITO").ToString
            Else
                TextBox4.Text = String.Empty
                TextBox1.Text = String.Empty
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub FrmArticuloAct_Unidad_Medida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        cargarData()
    End Sub

    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_articulo.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        '-----------------------------------
        Select Case tc_articulo.SelectedIndex
            Case 0
                tc_articulo.SelectedIndex = indice + 1
            Case 1
                tc_articulo.SelectedIndex = indice - 1
            Case 2
                tc_articulo.SelectedIndex = indice - 2
            Case 3
                tc_articulo.SelectedIndex = indice - 3
        End Select

        ' ----------------------------------
    End Sub



    Private Sub cargarData()
        AlmacenesBl = New ClsNegocio.DIRECCIONESTRANSPORTISTAS
        dtdetalles = New DataTable("DIRECCIONESTRANSPORTISTAS")
        dtv = New DataView
        dtdetalles = AlmacenesBl.get_DireccionesTransportistasGenerales(txtCodigoTransportista.Text)
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgvAlmacenes.DataSource = dtv
            dgvAlmacenes.Columns(0).Visible = False
            dgvAlmacenes.Columns(1).Width = 180

            dgvAlmacenes.Columns(2).Visible = False
            dgvAlmacenes.Columns(3).Width = 100

            dgvAlmacenes.Columns(4).Visible = False
            dgvAlmacenes.Columns(5).Width = 120

            dgvAlmacenes.Columns(6).Visible = False
            dgvAlmacenes.Columns(7).Width = 100


            STRorden = dgvAlmacenes.Columns(0).Name & "+" & dgvAlmacenes.Columns(1).Name & "+" & dgvAlmacenes.Columns(2).Name
            lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        AlmacenBl = Nothing
    End Sub
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


    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage2, True)
        'CONTROLES(TabPage1, False)
        txtCodigo.Enabled = True
        Blank()
        CorrelativoAlmacen()
        TextBox6.Focus()
        nuevo = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Validar() Then
            GuardarAlmacen()
            Call btn_cancelar_Click(sender, e)
        End If
    End Sub



    Private Sub Blank()
        TextBox6.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox4.Text = String.Empty


        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty


        txtdirecentrega.Text = String.Empty
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

    Private Sub ModoEdicion()
        Try
            txtCodigo.Text = dgvAlmacenes.Item("ITEM", dgvAlmacenes.CurrentRow.Index).Value
            txtdirecentrega.Text = dgvAlmacenes.Item("DIRECCION", dgvAlmacenes.CurrentRow.Index).Value

            'Dim Sql As String = String.Empty
            'Sql = String.Empty
            'Sql = "SELECT NAME FROM dbo.UNITS WHERE ID='" & TextBox6.Text & "'"
            'TextBox3.Text = get_MostrarDescripcion(Sql)

            TextBox6.Text = dgvAlmacenes.Item("DEPARTAMENTO_ID", dgvAlmacenes.CurrentRow.Index).Value
            TextBox5.Text = dgvAlmacenes.Item("PROVINCIA_ID", dgvAlmacenes.CurrentRow.Index).Value
            TextBox4.Text = dgvAlmacenes.Item("DISTRITO_ID", dgvAlmacenes.CurrentRow.Index).Value

            If TextBox6.Text <> String.Empty Then
                clsBuscarBl = New LibCobranzas.ClsBuscar
                TextBox3.Text = clsBuscarBl.Get_Departamento_Manual(TextBox6.Text)
                If TextBox6.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Departamento.", MsgBoxStyle.Information)
                    TextBox6.Text = String.Empty
                End If
            End If
            If TextBox6.Text <> String.Empty And TextBox5.Text <> String.Empty Then
                clsBuscarBl = New LibCobranzas.ClsBuscar
                TextBox2.Text = clsBuscarBl.Get_Provincia_Manual(TextBox6.Text, TextBox5.Text)
                If TextBox5.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo de la Provincia.", MsgBoxStyle.Information)
                    TextBox2.Text = String.Empty
                End If
            End If
            If TextBox6.Text <> String.Empty And TextBox5.Text <> String.Empty And TextBox4.Text <> String.Empty Then
                clsBuscarBl = New LibCobranzas.ClsBuscar
                TextBox1.Text = clsBuscarBl.Get_Distrito_Manual(TextBox6.Text, TextBox5.Text, TextBox4.Text)
                If TextBox1.Text = String.Empty Then
                    MsgBox("No hay descripcion con el codigo del Distrito.", MsgBoxStyle.Information)
                    TextBox1.Text = String.Empty
                End If
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvAlmacenes.Rows.Count = 0 Then Exit Sub
        If dgvAlmacenes.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        'CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        nuevo = False
        txtCodigo.Enabled = False
        Blank()
        ModoEdicion()
        TextBox6.Focus()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        'CONTROLES(TabPage2, False)
        CONTROLES(TabPage1, True)
        cargarData()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvAlmacenes.Rows.Count = 0 Then Exit Sub
        If dgvAlmacenes.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            AlmacenesBl = New ClsNegocio.DIRECCIONESTRANSPORTISTAS
            Dim Id As String = String.Empty
            Id = dgvAlmacenes.Item(0, dgvAlmacenes.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Id.ToString) Then Exit Sub
            If AlmacenesBl.get_EliminacionDireccionesTransportistasget_EliminacionUM(Id, txtCodigoTransportista.Text) = True Then
                MsgBox("Eliminado Correctamente", MsgBoxStyle.Information, "Mensaje-Sistemas")
            End If
            cargarData()
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Close()
    End Sub
End Class