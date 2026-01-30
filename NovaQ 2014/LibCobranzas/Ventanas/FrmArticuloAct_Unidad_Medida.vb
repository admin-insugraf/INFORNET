Imports System.Collections.Specialized
Imports System.IO
Imports System.Windows.Forms

Public Class FrmArticuloAct_Unidad_Medida

    Private nuevo As Boolean
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim AlmacenBl As ClsOperaciones.UNIDADESmEDIDA
    Dim AlmacenesBl As ClsNegocio.UNIDADESMEDIDA
    Dim AlmacenEnt As ClsEntidades.UNIDADESmeDIDA
    Dim dtdetalles As DataTable

    Dim clsPedidoBl As ClsOperaciones.PART

    Private mySetting As NameValueCollection

    Dim LibData As LibConexion.ClsData
    Dim dtTable As DataTable
    Private Function Validar() As Boolean
        If spnFactor.Value = 0 Then
            Avisar("Debe de ingresar el Factor de Conversión")
            Return False

        ElseIf String.IsNullOrEmpty(txtunidaddesc.Text) Then
            Avisar("La descripcion es obligatoria")
            txt_codigoBarra.Focus()
            Return False

        End If
        Return True
    End Function



    Private Sub txt_um_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_um.MouseDoubleClick
        Ayuda_UnidadesMedida()
    End Sub


    Private Sub CorrelativoAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.UNIDADESMEDIDA
            dtdetalles = New DataTable("Correlativo")
            dtdetalles = AlmacenesBl.get_GeneracionCodigoAutomatico()
            If dtdetalles.Rows.Count() <> 0 Then
                txtCodigo.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.UNIDADESMEDIDA
            AlmacenEnt = New ClsEntidades.UNIDADESmeDIDA
            AlmacenEnt.ITEM = txtCodigo.Text
            AlmacenEnt.PART_ID = txtCodigoProducto.Text
            AlmacenEnt.UNIT_ID = txt_um.Text
            AlmacenEnt.FACTOR = spnFactor.Value
            AlmacenEnt.ALIAS = txt_alias.Text
            AlmacenEnt.CODBAR = txt_codigoBarra.Text

            AlmacenEnt.MOQ = spnMOQ.Value

            AlmacenEnt.MASTERPACK = spnMasterPack.Value
            AlmacenEnt.IS_MAINUNIT = False


            AlmacenEnt.IS_NOSALE = chkFlgNoSale.Checked
            AlmacenEnt.IS_STOCKETD = chkstocketd.Checked
            AlmacenEnt.USUCREA = LibComunVar.ClsVarComun.USUARIO
            AlmacenEnt.FECCREA = Now()

            AlmacenEnt.USUMOD = LibComunVar.ClsVarComun.USUARIO
            AlmacenEnt.FECMOD = Now()

            If AlmacenesBl.GuardarActualizar(AlmacenEnt, nuevo) = True Then
                MsgBox("Operación Generada Correctamente", MsgBoxStyle.Information, "Mensaje/Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Ayuda_UnidadesMedida(Optional ByVal tipo As String = "")
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CX_SP_S_UNITS_AYU"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de unidades de medidas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            If tipo = "REF" Then
                txtUnidMedRef.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtunidadrefdesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txtUnidMedRef.Focus()
            Else
                txt_um.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtunidaddesc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                txt_um.Focus()
            End If
        End If
        frm.Close()

    End Sub

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function


    Private Sub FrmArticuloAct_Unidad_Medida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        cargarData()



        Dim dtdocumentoPrin As DataTable
        dtdocumentoPrin = New DataTable

        clsPedidoBl = New ClsOperaciones.PART
        dtdocumentoPrin = clsPedidoBl.Mostrar_FICHA_PART(txtCodigoProducto.Text)

        If dtdocumentoPrin IsNot Nothing AndAlso dtdocumentoPrin.Rows.Count > 0 Then
            If dtdocumentoPrin.Rows(0)("Archivo") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtdocumentoPrin.Rows(0)("Archivo").ToString()) Then

                Dim archivoBytes As Byte() = CType(dtdocumentoPrin.Rows(0)("Archivo"), Byte())
                Dim rutaDestino As String = Ruta_FE() & "\OC"
                Dim nombreArchivo As String = "Orden_" & txtCodigoProducto.Text & ".pdf" ' o extraído si está disponible
                Dim rutaCompleta As String = Path.Combine(rutaDestino, nombreArchivo)
                File.WriteAllBytes(rutaCompleta, archivoBytes)
                txtRutaArchivo.Text = rutaCompleta
            End If


        End If







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
        AlmacenesBl = New ClsNegocio.UNIDADESMEDIDA
        dtdetalles = New DataTable("UM")
        dtv = New DataView
        dtdetalles = AlmacenesBl.get_UMGenerales(txtCodigoProducto.Text)
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            With dgUnidadesMedida
                .DataSource = dtv
                .RowHeadersWidth = 20
                .Columns(0).Width = 70 : .Columns(0).HeaderText = "Código"
                .Columns(1).Visible = False
                .Columns(2).Width = 100 : .Columns(2).HeaderText = "Unidad Medida"
                .Columns(3).Width = 50 : .Columns(3).HeaderText = "Factor"
                .Columns(4).Width = 200 : .Columns(4).HeaderText = "Alias"
                .Columns(5).Width = 100 : .Columns(5).HeaderText = "Código de Barra"
                .Columns(6).Width = 50 : .Columns(6).HeaderText = "MOQ"
                .Columns(7).Width = 50 : .Columns(7).HeaderText = "M.Pack"
                .Columns(8).Visible = False
                .Columns(9).Width = 100

                .Columns(10).Width = 100
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(14).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
                .Columns(17).Visible = False

                STRorden = .Columns(0).Name & "+" & .Columns(1).Name & "+" & .Columns(2).Name
                lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End With

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
        spnFactor.Focus()
        nuevo = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Validar() Then
            GuardarAlmacen()
            Call btn_cancelar_Click(sender, e)
        End If
    End Sub



    Private Sub Blank()
        spnFactor.Value = 0
        txt_alias.Text = String.Empty
        txt_codigoBarra.Text = String.Empty

        txt_um.Text = String.Empty
        txtunidaddesc.Text = String.Empty

        txtUnidMedRef.Text = String.Empty
        txtunidadrefdesc.Text = String.Empty

        chkFlgNoSale.Checked = False

        spnMasterPack.Value = 1

        chkstocketd.Checked = False
        chkMainunit.Checked = False

        spnMOQ.Value = 1



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
            txtCodigo.Text = dgUnidadesMedida.Item("CODIGO", dgUnidadesMedida.CurrentRow.Index).Value
            txt_um.Text = dgUnidadesMedida.Item("UM", dgUnidadesMedida.CurrentRow.Index).Value

            Dim Sql As String = String.Empty
            Sql = String.Empty
            Sql = "SELECT NAME FROM dbo.UNITS WHERE ID='" & txt_um.Text & "'"
            txtunidaddesc.Text = get_MostrarDescripcion(Sql)

            spnFactor.Value = dgUnidadesMedida.Item("FACTOR", dgUnidadesMedida.CurrentRow.Index).Value
            txt_alias.Text = dgUnidadesMedida.Item("ALIAS", dgUnidadesMedida.CurrentRow.Index).Value
            txt_codigoBarra.Text = dgUnidadesMedida.Item("CODIGO_BARRAS", dgUnidadesMedida.CurrentRow.Index).Value

            spnMOQ.Value = dgUnidadesMedida.Item("MOQ", dgUnidadesMedida.CurrentRow.Index).Value

            spnMasterPack.Value = dgUnidadesMedida.Item("MASTERPACK", dgUnidadesMedida.CurrentRow.Index).Value
            chkMainunit.Checked = dgUnidadesMedida.Item("PRINCIPAL", dgUnidadesMedida.CurrentRow.Index).Value
            chkFlgNoSale.Checked = dgUnidadesMedida.Item("NO_VENTA", dgUnidadesMedida.CurrentRow.Index).Value
            chkstocketd.Checked = dgUnidadesMedida.Item("STOCKEABLE", dgUnidadesMedida.CurrentRow.Index).Value
            'chkDeleted.Checked = dgvAlmacenes.Item("ELIMINADO", dgvAlmacenes.CurrentRow.Index).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgUnidadesMedida.Rows.Count = 0 Then Exit Sub
        If dgUnidadesMedida.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        'CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        nuevo = False
        txtCodigo.Enabled = False
        Blank()
        ModoEdicion()
        spnFactor.Focus()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        'CONTROLES(TabPage2, False)
        CONTROLES(TabPage1, True)
        cargarData()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgUnidadesMedida.Rows.Count = 0 Then Exit Sub
        If dgUnidadesMedida.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("¿Está seguro de eliminar?") Then
            AlmacenesBl = New ClsNegocio.UNIDADESMEDIDA
            Dim Id As String = String.Empty
            Id = dgUnidadesMedida.Item(0, dgUnidadesMedida.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Id.ToString) Then Exit Sub
            If AlmacenesBl.get_EliminacionUM(Id, txtCodigoProducto.Text) = True Then
                MsgBox("Eliminado Correctamente", MsgBoxStyle.Information, "Mensaje-Sistemas")
            End If
            cargarData()
        End If

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Close()
    End Sub

    Private Sub btnBuscarArchivos_Click(sender As Object, e As EventArgs) Handles btnBuscarArchivos.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtRutaArchivo.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub btnSubirArchivo_Click(sender As Object, e As EventArgs) Handles btnSubirArchivo.Click
        If txtRutaArchivo.Text <> String.Empty Then
            Dim pdfBytes As Byte() = File.ReadAllBytes(txtRutaArchivo.Text)



            clsPedidoBl = New ClsOperaciones.PART
            If clsPedidoBl.Actualizar_FICHA_PART(txtCodigoProducto.Text, pdfBytes) = True Then
                MsgBox("Se actualizo la Ficha Tecnica", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If



    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try
            If txtRutaArchivo.Text <> String.Empty Then
                ' Opcional: Abrir el PDF
                Process.Start(txtRutaArchivo.Text)
            End If


        Catch ex As Exception
            MessageBox.Show("Error al recuperar PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        clsPedidoBl = New ClsOperaciones.PART
        If clsPedidoBl.Actualizar_FICHA_PART(txtCodigoProducto.Text, Nothing) = True Then
            txtRutaArchivo.Text = String.Empty

            MsgBox("Se actualizo la Ficha Tecnica", MsgBoxStyle.Information)

        End If
    End Sub
End Class