Imports System.Windows.Forms
Imports System.Drawing
Imports LibComunVar

Public Class frm_CX_MA_Articulo
    Dim bol_nuevo As Boolean = False

    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable

    Dim clsFamiliasBl As ClsOperaciones.FAMILY
    Dim dtFamilia As DataTable

    Dim clsLineasBl As ClsOperaciones.LINES
    Dim dtLineas As DataTable

    Dim ArticulosBl As ClsOperaciones.PART
    Dim dtArticulos As DataTable

    Dim LineaMedicaBl As ClsOperaciones.LINEA_MEDICA
    Dim dtlineaMedicas As DataTable


    Dim articuloBE As ClsEntidades.PART
    Dim articuloPA As ClsEntidades.PRINCIPIOS_ACTIVOS_DETALLE
    Dim articuloIRS As ClsEntidades.INCRIPCIONES_REG_SANIT

    Dim listaMuestras As List(Of String)

    Private dtv As DataView
    Dim STRorden As String = String.Empty

    Dim indiceM As Integer = 0
    Dim valorM As String = String.Empty
    Dim indiceG As Integer = 0
    Dim valorG As String = String.Empty
    Dim indiceP As Integer = 0
    Dim valorP As String = String.Empty


    Dim LibData As LibConexion.ClsData
    Dim dtTable As DataTable

    Dim _CONSULTA As String
    Dim _DT_CONSULTA As DataTable

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
 
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_Incripciones_RegSanit As DataTable
    Dim lista As New List(Of TabPage)

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_Adicionales.Enabled = False
            'If bol_nuevo = False Then
            '    btn_grabar.Enabled = True
            'Else
            '    btn_grabar.Enabled = False
            'End If
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
            btn_precio.Enabled = False
            btn_Descuentos.Enabled = False
            btnImprimir.Enabled = False
        Else
            btn_Nuevo.Enabled = True
            btn_Adicionales.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = NIVEL_ACCESO()
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
            btn_precio.Enabled = True
            btn_Descuentos.Enabled = True
            btnImprimir.Enabled = True
        End If
    End Sub

 


    Private Sub MostrarLineasMedicas()
        Try
            LineaMedicaBl = New ClsOperaciones.LINEA_MEDICA
            dtlineaMedicas = New DataTable

            dtlineaMedicas = LineaMedicaBl.get_LineasMedicasII()
            If dtlineaMedicas.Rows.Count() <> 0 Then
                chklstLineas.Items.Clear()
                For i As Integer = 0 To dtlineaMedicas.Rows.Count() - 1
                    chklstLineas.Items.Add(dtlineaMedicas.Rows(i).Item("DESCRIPCION").ToString)
                Next
                chklstLineas.SelectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_CX_MA_Articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call MostrarFamilias()
        Call TiposArticulos()
        Call Condicion_Venta()
        Call Forma_Farmaceutica()
        cboLine.Text = "Todas las Lineas"
        MostrarLineas()
        MostrarLineasMedicas()
        MostrarTodosDatosArticulos()
        'MostrarClaseTerapeutica()
        Botonera_Estado_Cambiar(False)
        CboEstado.SelectedIndex = 0
        cboTipoProducto.SelectedIndex = -1
        tc_articulo.SelectedIndex = 0
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
        CONTROLES(TabPage4, False)
        pnlTipoProducto.Visible = False
        Panel1.Visible = True
        btn_eliminar.Enabled = NIVEL_ACCESO()
    End Sub

    Private Sub Forma_Farmaceutica()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_Forma_Farmaceutica()
            If dtTipoProducto.Rows.Count() <> 0 Then
                cbo_forma_farmaceutica.Items.Clear()
                Me.cbo_forma_farmaceutica.DataSource = dtTipoProducto
                Me.cbo_forma_farmaceutica.DisplayMember = "DESCRIPCION"
                Me.cbo_forma_farmaceutica.ValueMember = "CODIGO"
            Else
                'MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Condicion_Venta()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_Condicion_Venta()
            If dtTipoProducto.Rows.Count() <> 0 Then
                cbo_condicion_venta.Items.Clear()
                Me.cbo_condicion_venta.DataSource = dtTipoProducto
                Me.cbo_condicion_venta.DisplayMember = "DESCRIPCION"
                Me.cbo_condicion_venta.ValueMember = "CODIGO"
            Else
                'MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GenerarCodigoMuestras()
        Try
            ArticulosBl = New ClsOperaciones.PART
            listaMuestras = New List(Of String)
            Dim codigoArticulo As String = String.Empty
            Dim TipoArticulo As String = String.Empty
            Dim Familia As String = String.Empty
            Dim Linea As String = String.Empty
            Dim Indicador As String = String.Empty
            Dim cod_Muestra As String = String.Empty
            '------------------
            codigoArticulo = txt_id.Text
            TipoArticulo = txttipoArticulo.Text
            Familia = txt_idfamilia.Text
            Linea = txt_linea.Text
            '----------
            If codigoArticulo = String.Empty Or TipoArticulo = String.Empty Or Familia = String.Empty Then Exit Sub

            If TipoArticulo = "02" Then
                Indicador = codigoArticulo.Substring(0, 2)

                '---Obtencion Codigo Familia para Muestra
                cod_Muestra = CStr(CInt(Familia + 1))

                If IsNumeric(Indicador) Then
                    Indicador = codigoArticulo.Substring(0, 2)
                Else
                    Indicador = codigoArticulo.Substring(0, 1)
                End If
                '---Validacion para ver si el Codigo es una Muestra Medica
                If Indicador = cod_Muestra Then
                    Exit Sub
                End If
                listaMuestras = ArticulosBl.get_CodigoMuestras(codigoArticulo, TipoArticulo, Familia, Linea)

                If listaMuestras Is Nothing Or listaMuestras.Count() = 0 Then Exit Sub
                Me.GBmuestraMedica.Visible = True

                'Inicializando Variables
                indiceM = 0
                valorM = String.Empty
                indiceG = 0
                valorG = String.Empty
                indiceP = 0
                valorP = String.Empty
                '--------- return 0 indica que no  posee Muestra
                '--------- return 1 indica que si  posee Muestra
                indiceM = listaMuestras(0).ToString
                valorM = listaMuestras(1).ToString
                '--------- return 0 indica que no  posee Muestra Granel
                '--------- return 1 indica que no si posee Muestra Granel
                indiceG = listaMuestras(2).ToString
                valorG = listaMuestras(3).ToString
                '--------- return 0 indica que no  posee Piloto
                '--------- return 1 indica que  si posee Piloto
                indiceP = listaMuestras(4).ToString
                valorP = listaMuestras(5).ToString
                '-----------------
                If indiceM = 1 Then
                    btnMuestraMedica.Enabled = False
                ElseIf indiceM = 0 Then
                    btnMuestraMedica.Enabled = True
                End If
                If indiceP = 1 Then
                    btnproductopiloto.Enabled = False
                ElseIf indiceP = 0 Then
                    btnproductopiloto.Enabled = True
                End If
            '-----------------
            If indiceG = 1 Then
                btnMuestraGranel.Enabled = False
            ElseIf indiceG = 0 Then
                btnMuestraGranel.Enabled = True
            End If
            Else
            GBmuestraMedica.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub MostrarLineasMedicas()
    '    Try
    '        LineaMedicaBl = New ClsOperaciones.LINEA_MEDICA
    '        dtlineaMedicas = New DataTable

    '        dtlineaMedicas = LineaMedicaBl.get_LineasMedicas()
    '        'agregando una nueva Fila (Seleccione) --
    '        Dim row As DataRow = dtlineaMedicas.NewRow()
    '        row.Item("CODIGO") = ""
    '        row.Item("DESCRIPCION") = "(-SELECCIONE-)"
    '        dtlineaMedicas.Rows.InsertAt(row, 0)
    '        '--------
    '        If dtlineaMedicas.Rows.Count() <> 0 Then
    '            cboLineaMedica.DataSource = dtlineaMedicas
    '            cboLineaMedica.DisplayMember = "DESCRIPCION"
    '            cboLineaMedica.ValueMember = "CODIGO"
    '        Else
    '            MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub ObtenerCodigoArticulo()
        Try
            Dim Lista As New List(Of String)
            ArticulosBl = New ClsOperaciones.PART

            Dim CodigoFamilia As String = String.Empty
            Dim codigoPart As String = String.Empty
            Dim codigoLine As String = String.Empty

            codigoPart = txttipoArticulo.Text
            CodigoFamilia = txt_idfamilia.Text
            codigoLine = txt_linea.Text

            If CodigoFamilia = String.Empty Or codigoPart = String.Empty Or codigoLine = String.Empty Then Exit Sub

            Lista = ArticulosBl.get_ObtnerCodigoPart(CodigoFamilia, codigoPart, codigoLine)
            If Lista.Count() = 0 Then
                MsgBox("No se pudo generar el codigo de Articulo.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txt_id.Text = Lista(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_TipoArticulos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_PART_TYPE"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Tipos de Articulos"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_id.Text = String.Empty
            txt_idfamilia.Text = String.Empty
            txt_linea.Text = String.Empty
            txttipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            lblTipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_idfamilia.Focus()
            'If txttipoArticulo.Text = "02" Then
            '    pnl_pt.Visible = False
            'Else
            '    pnl_pt.Visible = True
            'End If
        End If
        frm.Close()
    End Sub

    Private Sub Ayuda_Formulas()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_FORMULATION"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Formulas"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtProduccion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            TXTPRODUCCIONDESC.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub Ayuda_Presentacion()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_PRESENTACIONES"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Presentaciones"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txtcodigopres.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txtdescripcionpres.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub MostrarTodosDatosArticulos()
        Try
            ArticulosBl = New ClsOperaciones.PART
            dtArticulos = New DataTable
            dtv = New DataView

            Dim CodigoFamilia As String = String.Empty
            Dim codigoPart As String = String.Empty
            Dim codigoLine As String = String.Empty
            Dim opcion_part As String = String.Empty

            CodigoFamilia = cboFamily.SelectedValue.ToString
            codigoPart = cbopart_Type.SelectedValue.ToString
            codigoLine = cboLine.SelectedValue.ToString

            'If CodigoFamilia = String.Empty Or codigoPart = String.Empty Then Exit Sub
            If opttodos.Checked = True Then
                opcion_part = "0"
            ElseIf optmuestramedica.Checked = True Then
                opcion_part = "1"
            ElseIf optproductosgranel.Checked = True Then
                opcion_part = "2"
            End If

            If CodigoFamilia = "" And codigoPart = "" And codigoLine = "" Then
                dtArticulos = ArticulosBl.get_MostrarArticulos_General(CodigoFamilia, codigoPart, codigoLine, opcion_part)
            Else
                dtArticulos = ArticulosBl.get_MostrarArticulostodos(CodigoFamilia, codigoPart, codigoLine, opcion_part)
            End If

            dtv = dtArticulos.DefaultView
            If dtArticulos.Rows.Count() <> 0 Then
                dgv_articulos.DataSource = dtv
                STRorden = dgv_articulos.Columns(2).Name & "+" & dgv_articulos.Columns(3).Name
                lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                dgv_articulos.Refresh()
                dgv_articulos.DataSource = dtv
                STRorden = dgv_articulos.Columns(2).Name & "+" & dgv_articulos.Columns(3).Name
                lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
            End If
            If cbopart_Type.SelectedValue = "02" Then
                'dgv_articulos.Columns(21).Visible = True
                dgv_articulos.Columns(22).Visible = True
                dgv_articulos.Columns(22).HeaderText = "Presentación"
                dgv_articulos.Columns(23).Visible = True
                dgv_articulos.Columns(23).HeaderText = "Registro Sanitario"
            Else
                'dgv_articulos.Columns(20).Visible = False
                'dgv_articulos.Columns(21).Visible = False
                dgv_articulos.Columns(22).Visible = False
                dgv_articulos.Columns(23).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarLineas()
        Try
            clsLineasBl = New ClsOperaciones.LINES
            dtLineas = New DataTable

            Dim CodigoFamilia As String = String.Empty
            Dim codigoPart As String = String.Empty

            CodigoFamilia = cboFamily.SelectedValue.ToString
            codigoPart = cbopart_Type.SelectedValue.ToString

            dtLineas = clsLineasBl.get_MostrarLineas(CodigoFamilia, codigoPart)
            Dim row As DataRow = dtLineas.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-TODOS LOS REGISTROS-)"
            dtLineas.Rows.InsertAt(row, 0)
            If dtLineas.Rows.Count() <> 0 Then
                '-------------------
                cboLine.DataSource = dtLineas
                Me.cboLine.DisplayMember = "DESCRIPCION"
                Me.cboLine.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub MostrarClaseTerapeutica()
    '    Try
    '        ArticulosBl = New ClsOperaciones.PART
    '        Dim dtclaseTerap As New DataTable
    '        dtclaseTerap = ArticulosBl.ListarClaseTerapeutica()
    '        Dim row As DataRow = dtclaseTerap.NewRow()
    '        row.Item("CODIGO") = ""
    '        row.Item("DESCRIPCION") = "(-SELECCIONE-)"
    '        dtclaseTerap.Rows.InsertAt(row, 0)
    '        If dtLineas.Rows.Count() <> 0 Then
    '            cbo_clase_terapeutica.DisplayMember = "DESCRIPCION"
    '            cbo_clase_terapeutica.ValueMember = "CODIGO"
    '            cbo_clase_terapeutica.DataSource = dtclaseTerap
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub



    Private Sub MostrarFamilias()
        Try
            clsFamiliasBl = New ClsOperaciones.FAMILY
            dtFamilia = New DataTable
            dtFamilia = clsFamiliasBl.get_MostrarFamilias()
            clsFamiliasBl = Nothing
            If dtFamilia.Rows.Count() <> 0 Then

                Dim row2 As DataRow = dtFamilia.NewRow()
                row2.Item("CODIGO") = ""
                row2.Item("DESCRIPCION") = "(-TODOS LOS REGISTROS-)"
                dtFamilia.Rows.InsertAt(row2, 0)

                cboFamily.DataSource = dtFamilia
                cboFamily.DisplayMember = "DESCRIPCION"
                cboFamily.ValueMember = "CODIGO"
                ''segundo Combo box
                clsFamiliasBl = New ClsOperaciones.FAMILY
                Dim dtFamily As New DataTable
                dtFamily = clsFamiliasBl.get_MostrarFamilias()
                clsFamiliasBl = Nothing
                Dim row As DataRow = dtFamily.NewRow()
                row.Item("CODIGO") = ""
                row.Item("DESCRIPCION") = "(SELECCIONE UNA FAMILIA)"
                dtFamily.Rows.InsertAt(row, 0)
                cboFamilia.DisplayMember = "DESCRIPCION"
                cboFamilia.ValueMember = "CODIGO"
                cboFamilia.DataSource = dtFamily
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

                Dim row2 As DataRow = dtTipoProducto.NewRow()
                row2.Item("CODIGO") = ""
                row2.Item("DESCRIPCION") = "(-TODOS LOS REGISTROS-)"
                dtTipoProducto.Rows.InsertAt(row2, 0)

                cbopart_Type.Items.Clear()
                Me.cbopart_Type.DataSource = dtTipoProducto
                Me.cbopart_Type.DisplayMember = "DESCRIPCION"
                Me.cbopart_Type.ValueMember = "CODIGO"
                ''Segunda
                clsTipoProductoBl = New ClsOperaciones.PART_TYPE
                Dim dt_TipoProd As New DataTable
                dt_TipoProd = clsTipoProductoBl.get_ClaseArticulo()
                Me.cboTipoPart.DisplayMember = "DESCRIPCION"
                Me.cboTipoPart.ValueMember = "CODIGO"
                Me.cboTipoPart.DataSource = dt_TipoProd
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Data()
        Dim articuloBL As New ClsOperaciones.PART
        dgv_articulos.DataSource = articuloBL.get_articulos
        articuloBL = Nothing

        If dgv_articulos.RowCount > 0 Then
            dgv_articulos.ContextMenuStrip = cmsOpciones
        End If
    End Sub


    Private Sub Ayuda_Familia()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CX_SP_S_FAMILY_AYU"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Familias"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_id.Text = String.Empty
            txt_linea.Text = String.Empty
            txt_idfamilia.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            lbl_familia.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_linea.Select()
        End If
        frm.Close()
    End Sub

    Private Function Ayuda_Lineas() As Boolean
        Dim estado As Boolean = True
        Try
            If txttipoArticulo.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo de Articulo", MsgBoxStyle.Exclamation)
                txttipoArticulo.Select()
                estado = False
                Exit Try
            ElseIf txt_idfamilia.Text = String.Empty Then
                MsgBox("Debe seleccionar un Tipo de Familia", MsgBoxStyle.Exclamation)
                txt_idfamilia.Select()
                estado = False
                Exit Try
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "LIN_SP_S_LINE_PART"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = txt_idfamilia.Text.Trim
            frm.Filtros2 = txttipoArticulo.Text.Trim
            frm.Titulo = "Lista Lineas de Familias"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_linea.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                lbl_linea.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function


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

    Private Function ValidacionesGenerales() As Boolean
        Dim indicador As Boolean = True
        Try
            If txt_id.Text.Trim = "" Then
                MsgBox("No se Genero el codigo de Articulo.", MsgBoxStyle.Exclamation)
                indicador = False
                Exit Try
            ElseIf txt_idfamilia.Text.Trim = "" Then
                MsgBox("Seleccione una Familia.", MsgBoxStyle.Exclamation)
                txt_idfamilia.Focus()
                indicador = False
                Exit Try
            ElseIf txt_linea.Text.Trim = "" Then
                MsgBox("Seleccione una Linea.", MsgBoxStyle.Exclamation)
                txt_linea.Focus()
                indicador = False
                Exit Try
            ElseIf txttipoArticulo.Text.Trim = "" Then
                MsgBox("Seleccione un Tipo de Articulo.", MsgBoxStyle.Exclamation)
                txttipoArticulo.Focus()
                indicador = False
                Exit Try
                'ElseIf txtcodigoClaseArt.Text.Trim = "" Then
                '    MsgBox("Seleccione una Clase de Articulo.", MsgBoxStyle.Exclamation)
                '    txtcodigoClaseArt.Focus()
                '    indicador = False
                '    Exit Try
            ElseIf txt_um.Text.Trim = "" Then
                MsgBox("Debe seleccionar una Unidad de medida.", MsgBoxStyle.Exclamation)
                txt_um.Focus()
                indicador = False
                Exit Try
            End If
            
            If chk_prod_controlado.Checked Then
                If cbo_tipo_prod_controlado.SelectedIndex = -1 Then
                    MsgBox("Debe elegir un Tipo de Prod. Controlado.", MsgBoxStyle.Exclamation)
                    indicador = False
                    Exit Try
                End If
            End If
            If bol_nuevo Then
                ArticulosBl = New ClsOperaciones.PART
                dtArticulos = New DataTable
                dtArticulos = ArticulosBl.get_Validar_Codigo_Nuevo(txt_id.Text.Trim)
                If dtArticulos.Rows.Count > 0 Then
                    MsgBox("El codigo del Producto nuevo ya existe en" & Chr(13) & " la base de datos, verifique.", MsgBoxStyle.Exclamation)
                    indicador = False
                    Exit Try
                End If
            End If
            

        Catch ex As Exception
            indicador = False
        End Try
        Return indicador
    End Function

    Private Sub GuardarArticulos(Optional ByVal INDICADOR As Integer = 1, _
                                 Optional ByVal VALOR As String = "")
        ArticulosBl = New ClsOperaciones.PART
        articuloBE = New ClsEntidades.PART
        With articuloBE
            If INDICADOR = 1 Then
                .ID = CStr(txt_id.Text.Trim)
            ElseIf INDICADOR = 0 Then
                .ID = VALOR
            End If
            .DESCRIPTION = CStr(txt_des.Text.Trim)
            .ID_FAB = txt_cod_fab.Text.Trim
            .FAMILY = txt_idfamilia.Text.Trim
            .UNIT_OF_MEASUREMENT = txt_um.Text.Trim
            If rbStockSerie.Checked = True Then
                .SERIES = "S"
            Else
                .SERIES = "N"
            End If
            If rbStockLote.Checked = True Then
                .IS_LOT = "S"
            Else
                .IS_LOT = "N"
            End If
            If rbLibre.Checked = True Then
                .IS_STOCKED = "S"
            Else
                .IS_STOCKED = "N"
            End If
            .VAT_POR = 18
            .IS_VAT = 0
            .ACCOUNT_INTERNAL_ID = txtcuentaVenta.Text
            .ACCOUNT_INV = txtCuentaInventario.Text
            .ACCOUNT_PAY = txtCuentaCompra.Text.Trim
            .ISCPOR = 0
            .TIPOISC = 0
            .MODEL = txt_linea.Text.Trim
            .DESCRIPTION_OPT = ""
            .UNIT_PRICE = CDbl(0)
            .DISCOUNT = CDbl(0)
            .PRICE_BUY = CDbl(0)
            .VENDOR_ID_PART = ""
            .CREATE_DATE = Format(Date.Now(), "Short Date")
            .CREATE_USER = LibComunVar.ClsVarComun.USUARIO
            .STATUS = IIf(CboEstado.SelectedIndex = 0, "V", "F")
            .STATUS_MAT_EMPAQUE = "" ' cmb_estado_mat_empaque.SelectedIndex.ToString
            .CURRENCY_ID = "MN"
            .TYPE_PART = txttipoArticulo.Text
            .WEIGHT = 0
            .CST_POR = 0
            .HOUR_UPDATE = Format(Date.Now(), "Short Date")
            .ORIGEN = CChar("N")
            .PRESS_VENTA = txtPresentacion.Text
            .PRESS_MUESTRA_MEDICA = txtPresMMedica.Text
            .LINEA_MEDICA = ""
            .NOMBRE_COMERCIAL = txtdecComercial.Text
            .ID_ANTERIOR = txt_cod_fab.Text
            .TIPO_ARTICULO = cboTipoProducto.SelectedIndex 'IIf(cboTipoProducto.SelectedIndex = 1, 1, 0)
            .PRESS_COMERCIAL = txtPresComercial.Text
            .CLASS_PART = txtcodigoClaseArt.Text
            .REG_SANIT = txt_nro_reg_sanit.Text
            .VIGENCIA_REG_SANIT = dtp_vcto_reg_sanit.Value.ToString("dd/MM/yyyy") 'txt_vig_reg_sanit.Text
            .VIGENCIA_LOTE = txt_vigencia_lot.Text 'txt_vig_reg_sanit.Text
            If dgv_detalle.Rows.Count > 0 Then
                If dgv_detalle.Rows(0).Cells("col_img").Value Is Nothing Then
                    .IMAGEN = Nothing
                Else
                    .IMAGEN = Image2Bytes(dgv_detalle.Rows(0).Cells("col_img").Value)
                End If
            Else
                .IMAGEN = Nothing
            End If
            .IS_PRODUCTION = IIf(chkProduccion.Checked, "S", "N")
            .FORMULA_ID = txtProduccion.Text
            .COD_PRESENTACION = txtcodigopres.Text
            If txtcapacidad.Text = "" Then
                .QTY_PRESENTACION = 0
            Else
                .QTY_PRESENTACION = CDbl(txtcapacidad.Text)
            End If


            If cbo_forma_farmaceutica.SelectedIndex = -1 Then
                .COD_FORMA_FARMACEUTICO = ""
            Else
                .COD_FORMA_FARMACEUTICO = cbo_forma_farmaceutica.SelectedValue.ToString
            End If
            If cbo_condicion_venta.SelectedIndex = -1 Then
                .COD_CONDICION_VENTA = ""
            Else
                .COD_CONDICION_VENTA = cbo_condicion_venta.SelectedValue.ToString
            End If
            If cbo_estado_rs.SelectedIndex = -1 Then
                .COD_ESTADO_RS = ""
            Else
                .COD_ESTADO_RS = cbo_estado_rs.SelectedIndex
            End If

            If cbo_norma_tecnica.SelectedIndex = -1 Then
                .COD_NORMA_TECNICA = ""
            Else
                .COD_NORMA_TECNICA = cbo_norma_tecnica.SelectedIndex
            End If


            .FEC_EMISION_NORMA_TECNICA = dtp_fec_emi_norma_tecnica.Value.ToString("dd/MM/yyyy")
            .FEC_VCTO_NORMA_TECNICA = dtp_fec_vcto_norma_tec.Value.ToString("dd/MM/yyyy")
            .NUMERO_NORMA_TECNICA = txt_numero_norma_tec.Text.Trim

            .FLAG_PRODUCTO_CONTROLADO = IIf(chk_prod_controlado.Checked, "1", "0")
            .COD_TIPO_PRODUCTO_CONTROLADO = IIf(cbo_tipo_prod_controlado.SelectedIndex = -1, "", cbo_tipo_prod_controlado.SelectedIndex.ToString)
            .COMMENT = txtComentarios.Text.Trim
            .TIPO_ORIGEN = txt_tipo_origen.Text

            .DAM = txt_1.Text
            If txt_2.Text = "" Then
                .AD_VALOREM2 = 0
            Else
                .AD_VALOREM2 = txt_2.Text
            End If

            If txt_3.Text = "" Then
                .ISC = 0
            Else
                .ISC = txt_3.Text
            End If

            If txt_4.Text = "" Then
                .IGV = 0
            Else
                .IGV = txt_4.Text
            End If

            If txt_5.Text = "" Then
                .IPM = 0
            Else
                .IPM = txt_5.Text
            End If

            If txt_6.Text = "" Then
                .DERECHOS_ESPECIFICOS = 0
            Else
                .DERECHOS_ESPECIFICOS = txt_6.Text
            End If

            If txt_7.Text = "" Then
                .DERECHOS_ANTIDUMPING = 0
            Else
                .DERECHOS_ANTIDUMPING = txt_7.Text
            End If

            If txt_8.Text = "" Then
                .SEGURO2 = 0
            Else
                .SEGURO2 = txt_8.Text
            End If

            If txt_9.Text = "" Then
                .SOBRETASA_TRIBUTO = 0
            Else
                .SOBRETASA_TRIBUTO = txt_9.Text
            End If

            If txt_10.Text = "" Then
                .SOBRETASA_SANCION = 0
            Else
                .SOBRETASA_SANCION = txt_10.Text
            End If

            If txt_11.Text = "" Then
                .PERCEPCION2 = 0
            Else
                .PERCEPCION2 = txt_11.Text
            End If

            .STOCK_MINIMO = Val(txt_stock_minimo.Text)
            .STOCK_PUNTO_PEDIDO = Val(txt_punto_pedido.Text)
            .STOCK_MAXIMO = Val(txt_stock_maximo.Text)
            .LINEA_PRODUCCION = txt_cod_linea_produccion.Text
        End With

        articuloPA = New ClsEntidades.PRINCIPIOS_ACTIVOS_DETALLE
        Dim ls_det_pa As New List(Of ClsEntidades.PRINCIPIOS_ACTIVOS_DETALLE)
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            For i As Integer = 0 To dtdetalleArticuloPrincipal.Rows.Count() - 1
                articuloPA = New ClsEntidades.PRINCIPIOS_ACTIVOS_DETALLE
                With articuloPA
                    .PART_ID = articuloBE.ID
                    .ID_PRINCIPIO = dtdetalleArticuloPrincipal.Rows(i).Item("CODIGO").ToString
                    .NAME_PRINCIPIO = dtdetalleArticuloPrincipal.Rows(i).Item("DESCRIPCION").ToString
                    .USUARIO = LibComunVar.ClsVarComun.USUARIO
                    .TERMINAL = Environment.MachineName
                End With
                ls_det_pa.Add(articuloPA)
            Next
        End If
        


        articuloIRS = New ClsEntidades.INCRIPCIONES_REG_SANIT
        Dim ls_det_IRS As New List(Of ClsEntidades.INCRIPCIONES_REG_SANIT)
        If dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count > 0 Then
            For i As Integer = 0 To dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count() - 1
                articuloIRS = New ClsEntidades.INCRIPCIONES_REG_SANIT
                With articuloIRS
                    .PART_ID = articuloBE.ID
                    .NUM_REG_SANIT = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("NUM_REG_SANIT").ToString
                    .FEC_EMISION = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("FEC_EMISION").ToString
                    .FEC_VENCIMIENTO = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("FEC_VENCIMIENTO").ToString
                    .USUARIO = LibComunVar.ClsVarComun.USUARIO
                    .TERMINAL = Environment.MachineName
                End With
                ls_det_IRS.Add(articuloIRS)
            Next
        End If


        If bol_nuevo Then
            ArticulosBl.Insert(articuloBE, chklstLineas, ls_det_pa, ls_det_IRS)
            '' ArticulosBl = New ClsOperaciones.PART
            '' ArticulosBl.Update_ObtnerCodigoPart(txt_idfamilia.Text, txttipoArticulo.Text, txt_linea.Text)
            ArticulosBl = New ClsOperaciones.PART
            ArticulosBl.InsertandoArticuloTodosAlmacenes(VALOR)
            ''
            'If INDICADOR = 0 Then
            '    ArticulosBl = New ClsOperaciones.PART
            '    ArticulosBl.InsertandoArticuloTodosAlmaceneslotes(txt_id.Text, VALOR)
            'End If
        Else
            ArticulosBl.Update(articuloBE, chklstLineas, ls_det_pa, ls_det_IRS)
        End If
    End Sub


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If ValidacionesGenerales() = False Then Exit Sub
        Dim Mensaje As String = String.Empty

        If bol_nuevo Then
            Mensaje = "¿Desea Generar un nuevo Articulo.?"
        Else
            Mensaje = "¿Desea Modificar el Articulo.?"
        End If

        Dim opcion As DialogResult = MsgBox(Mensaje, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
        If opcion = DialogResult.Yes Then
            GuardarArticulos("0", txt_id.Text)
            Call Avisar("Datos grabados correctamente.")
            cboTipoProducto.SelectedIndex = 0
            Call btn_cancelar_Click(sender, e)
            Call MostrarTodosDatosArticulos()
        End If
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

    Private Function Modo_Edicion(ByVal idArticulo As String) As Boolean
        ArticulosBl = New ClsOperaciones.PART
        dtArticulos = New DataTable
        Dim dtdescripcion As New DataTable

        Dim Indicador As Boolean = True
        Dim Sql As String = String.Empty
        Try
            dtArticulos = ArticulosBl.get_EdiciondeArticulos(idArticulo)
            If dtArticulos.Rows.Count <> 0 Then
                For i As Integer = 0 To dtArticulos.Rows.Count() - 1
                    txt_cod_articulo.Visible = True
                    Label52.Visible = True
                    txt_cod_articulo_dos.Visible = True
                    Label53.Visible = True

                    txt_id.Text = dtArticulos.Rows(i).Item("ID").ToString
                    txt_cod_articulo.Text = txt_id.Text
                    txt_cod_articulo_dos.Text = txt_id.Text
                    txt_des.Text = dtArticulos.Rows(i).Item("DESCRIPTION").ToString
                    txt_cod_fab.Text = dtArticulos.Rows(i).Item("ID_FAB").ToString
                    txt_idfamilia.Text = dtArticulos.Rows(i).Item("FAMILY").ToString
                    Sql = String.Empty
                    Sql = "SELECT NAME  FROM FAMILY  WHERE ID='" & txt_idfamilia.Text & "'"
                    lbl_familia.Text = get_MostrarDescripcion(Sql)
                    txt_um.Text = dtArticulos.Rows(i).Item("UNIT_OF_MEASUREMENT").ToString

                    txt_cod_linea_produccion.Text = dtArticulos.Rows(i).Item("LINEA_PRODUCCION").ToString
                    txt_des_lina_produccion.Text = dtArticulos.Rows(i).Item("LINEA_PRODUCCION_DES").ToString


                    txt_stock_minimo.Text = dtArticulos.Rows(i).Item("STOCK_MINIMO").ToString
                    txt_stock_minimo.Text = Format(Double.Parse(txt_stock_minimo.Text), "##,##0")
                    txt_stock_maximo.Text = dtArticulos.Rows(i).Item("STOCK_MAXIMO").ToString
                    txt_stock_maximo.Text = Format(Double.Parse(txt_stock_maximo.Text), "##,##0")
                    txt_punto_pedido.Text = dtArticulos.Rows(i).Item("STOCK_PUNTO_PEDIDO").ToString
                    txt_punto_pedido.Text = Format(Double.Parse(txt_punto_pedido.Text), "##,##0")

                    txt_tipo_origen.Text = dtArticulos.Rows(i).Item("TIPO_ORIGEN").ToString
                    txt_tipo_origen_desc.Text = dtArticulos.Rows(i).Item("TIPO_ORIGEN_DESC").ToString

                    Sql = String.Empty
                    Sql = "SELECT NAME FROM dbo.UNITS WHERE ID='" & txt_um.Text & "'"
                    txtunidaddesc.Text = get_MostrarDescripcion(Sql)

                    txtcodigoClaseArt.Text = dtArticulos.Rows(i).Item("CLASS_PART").ToString
                    chkProduccion.Checked = IIf(dtArticulos.Rows(i).Item("IS_PRODUCTION").ToString = "S", True, False)
                    txtProduccion.Text = dtArticulos.Rows(i).Item("FORMULA_ID").ToString
                    Sql = String.Empty
                    Sql = "SELECT DESCRIPTION  FROM DBO.FORMULATION  WHERE ID='" & txtProduccion.Text & "'"
                    TXTPRODUCCIONDESC.Text = get_MostrarDescripcion(Sql)

                    txtcodigopres.Text = dtArticulos.Rows(i).Item("COD_PRESENTACION").ToString
                    Sql = String.Empty
                    Sql = "SELECT DESCRIPTION  FROM DBO.PART  WHERE ID='" & txtcodigopres.Text & "'"
                    txtdescripcionpres.Text = get_MostrarDescripcion(Sql)
                    txtcapacidad.Text = dtArticulos.Rows(i).Item("QTY_PRESENTACION").ToString

                    Sql = String.Empty
                    Sql = "SELECT NAME  FROM MARK WHERE ID='" & txtcodigoClaseArt.Text & "'"
                    txtDescripcionClaseArt.Text = get_MostrarDescripcion(Sql)
                    If dtArticulos.Rows(i).Item("SERIES").ToString = "N" Then
                        rbStockSerie.Checked = False
                    ElseIf dtArticulos.Rows(i).Item("SERIES").ToString = "S" Then
                        rbStockSerie.Checked = True
                    End If
                    If dtArticulos.Rows(i).Item("IS_STOCKED").ToString = "N" Then
                        rbLibre.Checked = False
                    ElseIf dtArticulos.Rows(i).Item("IS_STOCKED").ToString = "S" Then
                        rbLibre.Checked = True
                    End If
                    If dtArticulos.Rows(i).Item("IS_LOT").ToString = "N" Then
                        rbStockLote.Checked = False
                    ElseIf dtArticulos.Rows(i).Item("IS_LOT").ToString = "S" Then
                        rbStockLote.Checked = True
                    End If
                    ' txt_por_igv.Text = IIf(dtArticulos.Rows(i).Item("VAT_POR").ToString = String.Empty, 0.0, CDbl(dtArticulos.Rows(i).Item("VAT_POR").ToString))
                    txtcuentaVenta.Text = dtArticulos.Rows(i).Item("ACCOUNT_INTERNAL_ID").ToString
                    txtCuentaInventario.Text = dtArticulos.Rows(i).Item("ACCOUNT_INV").ToString
                    txtCuentaCompra.Text = dtArticulos.Rows(i).Item("ACCOUNT_PAY").ToString
                    'txt_por_isc.Text = IIf(dtArticulos.Rows(i).Item("ISCPOR").ToString = "", "", dtArticulos.Rows(i).Item("ISCPOR").ToString)
                    txt_linea.Text = dtArticulos.Rows(i).Item("MODEL").ToString
                    Sql = String.Empty
                    Sql = "SELECT NAME  FROM LINES  WHERE ID='" & txt_linea.Text & "' and family_id='" & txt_idfamilia.Text.Trim & "' "
                    lbl_linea.Text = get_MostrarDescripcion(Sql)
                    txttipoArticulo.Text = dtArticulos.Rows(i).Item("TYPE_PART").ToString
                    If txttipoArticulo.Text = "02" Then
                        pnl_pt.Visible = True
                    Else
                        pnl_pt.Visible = False
                    End If
                    Sql = String.Empty
                    Sql = "SELECT NAME  FROM PART_TYPE  WHERE ID='" & txttipoArticulo.Text & "'"
                    lblTipoArticulo.Text = get_MostrarDescripcion(Sql)
                    txtPresentacion.Text = dtArticulos.Rows(i).Item("PRESS_VENTA").ToString
                    txtPresMMedica.Text = dtArticulos.Rows(i).Item("PRESS_MUESTRA_MEDICA").ToString
                    'cboLineaMedica.SelectedValue = IIf(dtArticulos.Rows(i).Item("LINEA_MEDICA").ToString = "", cboLineaMedica.SelectedIndex = 0, dtArticulos.Rows(i).Item("LINEA_MEDICA").ToString)
                    ' cboLineaMedica.SelectedValue = dtArticulos.Rows(i).Item("LINEA_MEDICA").ToString
                    txtdecComercial.Text = dtArticulos.Rows(i).Item("NOMBRE_COMERCIAL").ToString
                    'txt_cod_fab.Text = dtArticulos.Rows(i).Item("ID_ANTERIOR").ToString
                    cboTipoProducto.SelectedIndex = IIf(dtArticulos.Rows(i).Item("TIPO_ARTICULO").ToString = "", -1, IIf(dtArticulos.Rows(i).Item("TIPO_ARTICULO").ToString = "0", 0, 1))
                    txtPresComercial.Text = dtArticulos.Rows(i).Item("PRESS_COMERCIAL").ToString
                    CboEstado.SelectedIndex = IIf(dtArticulos.Rows(i).Item("STATUS").ToString = "V", 0, 1)
                    cmb_estado_mat_empaque.SelectedIndex = CInt(dtArticulos.Rows(i).Item("ESTADO_MAT_ESPAQUE").ToString)
                    txt_nro_reg_sanit.Text = dtArticulos.Rows(i).Item("REG_SANIT").ToString
                    txt_vig_reg_sanit.Text = dtArticulos.Rows(i).Item("VIGENCIA_REG_SANIT").ToString
                    txtComentarios.Text = dtArticulos.Rows(i).Item("COMMENT").ToString
                    If txt_vig_reg_sanit.Text = "" Then
                        dtp_vcto_reg_sanit.Value = Date.Now
                    Else
                        dtp_vcto_reg_sanit.Value = CDate(txt_vig_reg_sanit.Text)
                    End If


                    txt_vigencia_lot.Text = dtArticulos.Rows(i).Item("VIGENCIA_LOTE").ToString
                    Dim ds_tmp As DataSet = ArticulosBl.get_Imagen_Producto(idArticulo)

                    If ds_tmp.Tables(0).Rows.Count > 0 Then
                        If ds_tmp.Tables(0).Rows(i)("IMAGEN").ToString = String.Empty Then
                            dgv_detalle.DataSource = ds_tmp.Tables(0)
                            dgv_detalle.Rows(0).Cells("col_img").Value = Nothing
                            pb_img.Image = Nothing
                        Else
                            dgv_detalle.DataSource = ds_tmp.Tables(0)
                            dgv_detalle.Rows(0).Cells("col_img").Value = Bytes2Image(ds_tmp.Tables(0).Rows(0)("IMAGEN"))
                            pb_img.Image = dgv_detalle.Rows(0).Cells("col_img").Value
                        End If
                    Else
                        pb_img.Image = Nothing
                    End If

                    cbo_estado_rs.SelectedIndex = IIf(dtArticulos.Rows(i).Item("COD_ESTADO_RS").ToString = "0", 0, IIf(dtArticulos.Rows(i).Item("COD_ESTADO_RS").ToString = "", -1, 1))
                    cbo_forma_farmaceutica.SelectedValue = dtArticulos.Rows(i).Item("COD_FORMA_FARMACEUTICO").ToString
                    cbo_condicion_venta.SelectedValue = dtArticulos.Rows(i).Item("COD_CONDICION_VENTA").ToString


                    cbo_norma_tecnica.SelectedIndex = IIf(dtArticulos.Rows(i).Item("COD_NORMA_TECNICA").ToString = "", -1, dtArticulos.Rows(i).Item("COD_NORMA_TECNICA").ToString)
                    dtp_fec_emi_norma_tecnica.Value = IIf(dtArticulos.Rows(i).Item("FEC_EMISION_NORMA_TECNICA").ToString = "", Date.Now, dtArticulos.Rows(i).Item("FEC_EMISION_NORMA_TECNICA").ToString)
                    dtp_fec_vcto_norma_tec.Value = IIf(dtArticulos.Rows(i).Item("FEC_VCTO_NORMA_TECNICA").ToString = "", Date.Now, dtArticulos.Rows(i).Item("FEC_VCTO_NORMA_TECNICA").ToString)
                    txt_numero_norma_tec.Text = dtArticulos.Rows(i).Item("NUMERO_NORMA_TECNICA").ToString

                    txt_1.Text = dtArticulos.Rows(i).Item("DAM").ToString
                    txt_2.Text = dtArticulos.Rows(i).Item("AD_VALOREM2").ToString
                    txt_3.Text = dtArticulos.Rows(i).Item("ISC").ToString
                    txt_4.Text = dtArticulos.Rows(i).Item("IGV").ToString
                    txt_5.Text = dtArticulos.Rows(i).Item("IPM").ToString
                    txt_6.Text = dtArticulos.Rows(i).Item("DERECHOS_ESPECIFICOS").ToString
                    txt_7.Text = dtArticulos.Rows(i).Item("DERECHOS_ANTIDUMPING").ToString
                    txt_8.Text = dtArticulos.Rows(i).Item("SEGURO2").ToString
                    txt_9.Text = dtArticulos.Rows(i).Item("SOBRETASA_TRIBUTO").ToString
                    txt_10.Text = dtArticulos.Rows(i).Item("SOBRETASA_SANCION").ToString
                    txt_11.Text = dtArticulos.Rows(i).Item("PERCEPCION2").ToString

                    If dtArticulos.Rows(i).Item("FLAG_PRODUCTO_CONTROLADO").ToString = "" Or dtArticulos.Rows(i).Item("FLAG_PRODUCTO_CONTROLADO").ToString = "0" Then
                        chk_prod_controlado.Checked = False
                    Else
                        chk_prod_controlado.Checked = True
                        If dtArticulos.Rows(i).Item("COD_TIPO_PRODUCTO_CONTROLADO").ToString = "" Then
                            cbo_tipo_prod_controlado.SelectedIndex = -1
                        Else
                            cbo_tipo_prod_controlado.SelectedIndex = dtArticulos.Rows(i).Item("COD_TIPO_PRODUCTO_CONTROLADO").ToString
                        End If
                    End If


                    'CARGA LOS PRINCIPIOS ACTIVOS
                    Call GenerarColummnaDataTable()
                    dtdetalleArticuloPrincipal = ArticulosBl.get_Lista_Principios_Activos(txt_id.Text.Trim)
                    If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                        dgvDetalle.DataSource = dtdetalleArticuloPrincipal
                    End If

                    'CARGA LAS INSCRIPCIONES DEL RS
                    Call GenerarColummnaDataTable_Incripciones_RS()
                    dtdetalleArticuloPrincipal_Incripciones_RegSanit = ArticulosBl.get_Lista_Incripciones_Reg_Sanitario(txt_id.Text.Trim)
                    If dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count() <> 0 Then
                        dgv_incripciones_regsanit.DataSource = dtdetalleArticuloPrincipal_Incripciones_RegSanit
                    End If

                Next
                'Devolviendo Data
                ArticulosBl = New ClsOperaciones.PART
                dtdescripcion = New DataTable
                dtdescripcion = ArticulosBl.ListarPart_Detalle_Lineas(txt_id.Text)
                checkLineas.Checked = False
                chklstLineas.Enabled = True
                ActivarCheck(False)
                If dtdescripcion.Rows.Count <> 0 Then
                    Dim i As Integer = 0
                    For Each row As DataRow In dtdescripcion.Rows
                        Do While i <= chklstLineas.Items.Count - 1
                            If TraerCodigo(chklstLineas.Items(i)).Trim = row.Item("CODIGO").ToString Then
                                chklstLineas.SetItemChecked(i, True)
                                Exit Do
                            End If
                            i = i + 1
                        Loop
                    Next
                End If
            Else
                Indicador = False
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Try
            End If
        Catch ex As Exception
            Indicador = False
            MsgBox(ex.Message)
        End Try
        Return Indicador
    End Function
  
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

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Dim CodigoArticulo As String = String.Empty
        If dgv_articulos.CurrentRow Is Nothing Then Exit Sub
        CodigoArticulo = dgv_articulos.CurrentRow.Cells("codigo").Value 'dgv_articulos.Item(0, dgv_articulos.CurrentRow.Index).Value
        If CodigoArticulo = String.Empty Then Exit Sub
        Limpiar_GroupBox(gb_data)
        Limpiar_GroupBox(GroupBox2)
        Limpiar_GroupBox(gb_principios_activos)
        If Modo_Edicion(CodigoArticulo) = False Then Exit Sub
        bol_nuevo = False
        txt_id.Enabled = False
        gb_data.Enabled = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        CONTROLES(TabPage3, True)
        CONTROLES(TabPage4, True)
        txt_id.Enabled = False
        txt_des.Focus()
        GBmuestraMedica.Visible = False
        Botonera_Estado_Cambiar(True)
        Call GenerarCodigoMuestras()
        txtbuscarArticulo.Text = ""
        GroupBox1.Enabled = NIVEL_ACCESO()
        Dim flag_de_readonly As Boolean
        flag_de_readonly = NIVEL_ACCESO_FACTURACION()
        Poner_Habilitado(flag_de_readonly)
        txttipoArticulo.Enabled = False
        txt_idfamilia.Enabled = False
        txt_linea.Enabled = True
        'btn_grabar.Enabled = NIVEL_ACCESO()
    End Sub
    Private Sub Poner_Habilitado(ByVal _flag As Boolean)
        If _flag = False Then
            txt_id.Enabled = _flag
            txt_cod_fab.Enabled = _flag
            'txttipoArticulo.Enabled = _flag
            'txt_idfamilia.Enabled = _flag
            'txt_linea.Enabled = _flag
            txt_des.ReadOnly = Not _flag
            txtPresentacion.ReadOnly = Not _flag
            txtPresMMedica.ReadOnly = _flag
            txtdecComercial.ReadOnly = _flag
            txtPresComercial.ReadOnly = _flag
            txtcodigoClaseArt.ReadOnly = Not _flag
            txt_um.ReadOnly = _flag
            TextBox8.ReadOnly = Not _flag
            txtPartidaArancelaria.ReadOnly = Not _flag
            CboEstado.Enabled = Not _flag
            cbo_clase_terapeutica.Enabled = Not _flag
            cboTipoProducto.Enabled = Not _flag
            GroupBox1.Enabled = _flag


        ElseIf _flag = True Then
            txt_id.Enabled = Not _flag
            txt_cod_fab.Enabled = Not _flag
            'txttipoArticulo.Enabled = Not _flag
            'txt_idfamilia.Enabled = Not _flag
            'txt_linea.Enabled = Not _flag
            txt_des.ReadOnly = Not _flag
            txtPresentacion.ReadOnly = Not _flag
            txtPresMMedica.ReadOnly = Not _flag
            txtdecComercial.ReadOnly = Not _flag
            txtPresComercial.ReadOnly = Not _flag
            txtcodigoClaseArt.ReadOnly = Not _flag
            txt_um.ReadOnly = Not _flag
            TextBox8.ReadOnly = Not _flag
            txtPartidaArancelaria.ReadOnly = Not _flag
            CboEstado.Enabled = _flag
            cbo_clase_terapeutica.Enabled = _flag
            cboTipoProducto.Enabled = _flag
            GroupBox1.Enabled = _flag
            CONTROLES(TabPage1, False)
            CONTROLES(TabPage2, True)
            CONTROLES(TabPage3, True)
            CONTROLES(TabPage4, True)
        End If
    End Sub
    Private Function NIVEL_ACCESO() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "" Then
                    FLAG_NIVEL = False
                Else
                    If dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "01" Then
                        FLAG_NIVEL = True
                    ElseIf dtNivel.Rows(0).Item("NIVEL_ACCESO").ToString = "02" Then
                        FLAG_NIVEL = False
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Function NIVEL_ACCESO_FACTURACION() As Boolean
        Dim FLAG_NIVEL As Boolean = True
        Try
            Dim clsBusquedaBl As New ClsBuscar
            Dim dtNivel As New DataTable
            dtNivel = clsBusquedaBl.NIVEL_ACCESO(LibComunVar.ClsVarComun.USUARIO)
            If dtNivel.Rows.Count() <> 0 Then
                If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "" Then
                    FLAG_NIVEL = True
                Else
                    If dtNivel.Rows(0).Item("COD_PERFIL").ToString = "0000000007" Then
                        FLAG_NIVEL = False
                    ElseIf dtNivel.Rows(0).Item("COD_PERFIL").ToString <> "0000000007" Then
                        FLAG_NIVEL = True
                    End If
                End If
            Else
                FLAG_NIVEL = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return FLAG_NIVEL
    End Function

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        CONTROLES(TabPage3, True)
        CONTROLES(TabPage4, True)
        bol_nuevo = True
        Botonera_Estado_Cambiar(True)
        Call Limpiar_GroupBox(gb_data)
        Call Limpiar_GroupBox(gb_principios_activos)
        Call Limpiar_GroupBox(GroupBox8)
        Call Limpiar_GroupBox(GroupBox9)
        Call Limpiar_GroupBox(gb_datos_logisticos)
        gb_data.Enabled = True
        lbl_familia.Text = ""
        lbl_linea.Text = ""
        txtbuscarArticulo.Text = ""
        lblTipoArticulo.Text = String.Empty
        txt_id.Enabled = True
        GBmuestraMedica.Visible = False
        txttipoArticulo.Select()
        txt_nro_reg_sanit.Text = ""
        txt_vig_reg_sanit.Text = ""
        txt_vigencia_lot.Text = ""
        txtComentarios.Text = ""
        txt_numero_norma_tec.Text = ""
        txt_cod_linea_produccion.Text = ""
        txt_des_lina_produccion.Text = ""
        chk_prod_controlado.Checked = False
        cbo_forma_farmaceutica.SelectedIndex = -1
        cbo_condicion_venta.SelectedIndex = -1
        cbo_norma_tecnica.SelectedIndex = -1
        cbo_estado_rs.SelectedIndex = 0
        cbo_norma_tecnica.SelectedIndex = 0
        txt_stock_minimo.Text = "0"
        txt_stock_maximo.Text = "0"
        txt_punto_pedido.Text = "0"

        txt_cod_articulo.Visible = False
        Label52.Visible = False
        txt_cod_articulo_dos.Visible = False
        Label53.Visible = False

        txttipoArticulo.Enabled = True
        txt_idfamilia.Enabled = True
        txt_linea.Enabled = True

        GroupBox1.Enabled = True
        pnl_pt.Visible = True
        checkLineas.Checked = False
        'btn_grabar.Enabled = NIVEL_ACCESO()
        Call GenerarColummnaDataTable()
        Call GenerarColummnaDataTable_Incripciones_RS()
        ActivarCheck(False)
        'ObtenerCodigoArticulo()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_articulos.Rows.Count = 0 Then Exit Sub
        If dgv_articulos.CurrentRow Is Nothing Then Exit Sub

        If MessageBox.Show("seguro de eliminar", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim articuloBE As New ClsEntidades.PART
            Dim articuloBL As New ClsOperaciones.PART
            articuloBE.ID = dgv_articulos.Item(0, dgv_articulos.CurrentRow.Index).Value
            articuloBL.Delete(articuloBE)
            articuloBE = Nothing
            articuloBL = Nothing
            MessageBox.Show("Proceso generado correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call MostrarTodosDatosArticulos()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        CONTROLES(TabPage3, False)
        CONTROLES(TabPage4, False)
        gb_data.Enabled = False
        GBmuestraMedica.Visible = False
        Botonera_Estado_Cambiar(False)
        'cboTipoProducto.SelectedIndex = 0
        GroupBox1.Enabled = NIVEL_ACCESO()
        pnl_pt.Visible = True
    End Sub

 

    Private Sub txt_idfamilia_DoubleClick(sender As Object, e As EventArgs) Handles txt_idfamilia.DoubleClick
        Ayuda_Familia()
    End Sub


    Private Sub txt_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cod_fab_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_fab.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_idfamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idfamilia.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_Familia()
        If e.KeyCode = Keys.Enter Then If txt_idfamilia.Text = "" Then Ayuda_Familia()
    End Sub

    Private Sub cmb_serie_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_igv_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_stock_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub cmb_lote_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cta_int_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cta_inv_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_pago_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_por_igv_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_por_isc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub txt_linea_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_linea.KeyDown
        If e.KeyCode = Keys.F1 Then If Ayuda_Lineas() Then If bol_nuevo = True Then ObtenerCodigoArticulo()
        If e.KeyCode = Keys.Enter Then
            If txt_linea.Text = "" Then
                If Ayuda_Lineas() Then
                    If bol_nuevo = True Then
                        ObtenerCodigoArticulo()
                    End If
                End If
            End If
        End If
    End Sub
    'Private Sub dgv_articulos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_articulos.MouseDown
    '    If e.Button = MouseButtons.Right Then
    '        With dgv_articulos
    '            Dim hti As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
    '            If hti.Type = DataGridViewHitTestType.Cell Then
    '                .CurrentCell = _
    '                .Rows(hti.RowIndex).Cells(hti.ColumnIndex)

    '            End If

    '        End With
    '    End If
    'End Sub

    Private Sub VerStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerStockToolStripMenuItem.Click


        Dim crystalBL As New LibReportes.ClsReporte
        Dim STRCodigo As String

        STRCodigo = dgv_articulos.Rows(dgv_articulos.CurrentRow.Index).Cells("col_id").Value.ToString

        Try
            Me.Cursor = Cursors.WaitCursor
            crystalBL.Muestra_Reporte("Inv_Rep_Stock_Qty.RPT", "", "@CODIGO;" & STRCodigo)
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

        crystalBL = Nothing
    End Sub

    Private Sub txtbuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarArticulo.TextChanged
        '        dtv.Sort = STRorden
        'Dim wbusqueda As String = UCase(txtbuscarArticulo.Text)
        'Dim myCurrencyManager As CurrencyManager
        'myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        'Dim INTnewpos As Integer
        'dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
        'myCurrencyManager.Position = INTnewpos
        'lblcantidad.Text = "Se Encontraron " & dtv.Count & " Registros"
        If txtbuscarArticulo.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgv_articulos.Columns(2).Name
                dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgv_articulos.Columns(3).Name
                    dtv.RowFilter = STRorden & " like '%" & txtbuscarArticulo.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgv_articulos.Columns(2).Name & "+" & dgv_articulos.Columns(3).Name
                        lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblcantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub dgv_articulos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_articulos.ColumnHeaderMouseClick
        STRorden = dgv_articulos.Columns(e.ColumnIndex).Name
        lblbuscar.Text = "Buscar por : " & STRorden
        txtbuscarArticulo.Focus()
        txtbuscarArticulo.Clear()
    End Sub

    Private Sub cbopart_Type_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbopart_Type.SelectionChangeCommitted
        Call MostrarLineas()
        Call MostrarTodosDatosArticulos()
    End Sub

    Private Sub cboFamily_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFamily.SelectionChangeCommitted
        Call MostrarLineas()
        Call MostrarTodosDatosArticulos()
    End Sub

    Private Sub cboLine_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboLine.SelectionChangeCommitted
        MostrarTodosDatosArticulos()
    End Sub

    Private Sub txttipoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txttipoArticulo.MouseDoubleClick
        Ayuda_TipoArticulos()
    End Sub

    Private Sub txttipoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txttipoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then Ayuda_TipoArticulos()
        If e.KeyCode = Keys.Enter Then If txttipoArticulo.Text = "" Then Ayuda_TipoArticulos()
    End Sub

    Private Sub chkProduccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkProduccion.CheckedChanged
        If chkProduccion.Checked Then
            txtProduccion.Select()
        End If
    End Sub

    Private Sub btnMuestraMedica_Click(sender As Object, e As EventArgs) Handles btnMuestraMedica.Click
        If ValidacionesGenerales() = False Then Exit Sub
        Dim opcion As DialogResult = MsgBox("¿Desea Generar una Muestra Medica.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
        If opcion = DialogResult.Yes Then
            bol_nuevo = True
            GuardarArticulos(indiceM, valorM)
            Call Avisar("Proceso generado correctamente")
            Call btn_cancelar_Click(sender, e)
            gb_data.Enabled = False
            GBmuestraMedica.Visible = False
            cboTipoProducto.SelectedIndex = 0
            Call MostrarTodosDatosArticulos()
        End If
    End Sub

    Private Sub btnMuestraGranel_Click(sender As Object, e As EventArgs) Handles btnMuestraGranel.Click
        If ValidacionesGenerales() = False Then Exit Sub
        Dim opcion As DialogResult = MsgBox("¿Desea Generar un producto a Granel?" _
                                            , MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
        If opcion = DialogResult.Yes Then
            bol_nuevo = True
            GuardarArticulos(indiceG, valorG)
            Call Avisar("Proceso generado correctamente")
            Call btn_cancelar_Click(sender, e)
            gb_data.Enabled = False
            GBmuestraMedica.Visible = False
            cboTipoProducto.SelectedIndex = 0
            MostrarTodosDatosArticulos()
        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        STRorden = dgv_articulos.Columns(e.ColumnIndex).Name
        lblbuscar.Text = "Buscar por : " & STRorden
        txtbuscarArticulo.Focus()
        txtbuscarArticulo.Clear()
    End Sub



    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_articulo_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_articulo.Selecting
        ' Referenciamos el control TabPage que ha sido seleccionado
        Dim tp As TabPage = e.TabPage
        ' Cancelamos la selección si el control
        ' se encuentra deshabilitado.
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub txtbuscarArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscarArticulo.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtbuscarArticulo.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btn_precio_Click(sender As Object, e As EventArgs) Handles btn_precio.Click
        Dim frm As New FrmArticuloActualizacionPrecio
        frm.ShowDialog()
    End Sub

    Private Sub txttipoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipoArticulo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_idfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idfamilia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_linea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_linea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_des.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtPresentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresentacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtPresMMedica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresMMedica.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtdecComercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdecComercial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtPresComercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresComercial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_um_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_um.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txt_tipo_origen.Focus()
    End Sub

    Private Sub txtUnidMedRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidMedRef.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then btn_grabar.Select()
    End Sub

    Private Sub txtpesoArticulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtClase_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtcuentaVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcuentaVenta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtTalla_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCuentaInventario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaInventario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtPartidaArancelaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPartidaArancelaria.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub CboEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboEstado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboLineaMedica_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cboTipoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_Descuentos_Click(sender As Object, e As EventArgs) Handles btn_Descuentos.Click
        Dim frm As New FrmArticuloActualizacionDescuentos
        frm.ShowDialog()
    End Sub

    Private Sub txtcodigoClaseArt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoClaseArt.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_ClaseArticulo()
        ElseIf e.KeyCode = Keys.Enter Then
            txt_um.Focus()
        End If
    End Sub

    Private Sub Ayuda_ClaseArticulo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PART_SP_S_PART_MARK"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clase de Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoClaseArt.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcionClaseArt.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtcodigoClaseArt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoClaseArt.MouseDoubleClick
        Ayuda_ClaseArticulo()
    End Sub

    Private Sub txtcuentaVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaVenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtcuentaVenta)
        End If
    End Sub

    Private Sub txtCuentaInventario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaInventario.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtCuentaInventario)
        End If
    End Sub

    Private Sub txtCuentaCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaCompra.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txtCuentaCompra)
        End If
    End Sub

    Private Sub txtcuentaVenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaVenta.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaVenta)
    End Sub

    Private Sub txtCuentaInventario_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaInventario.MouseDoubleClick
        Ayuda_CuentasContables(txtCuentaInventario)
    End Sub

    Private Sub txtCuentaCompra_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaCompra.MouseDoubleClick
        Ayuda_CuentasContables(txtCuentaCompra)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Panel1.Visible = True
        pnlreporte.Visible = True
        rbcodigo.Checked = True
        txtdescripcion1.Text = "Del articulo"
        txtdescripcion2.Text = "Al articulo"
    End Sub

    Public Function TraerCodigo(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, 1, InStr(cadena, ":") - 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function



    Public Function TraerDescripcion(ByVal cadena As String) As String
        Dim resul As String = ""
        Try
            If InStr(cadena, ":") = 0 Then
                resul = ""
            Else
                If cadena.Length > 0 Then
                    resul = Mid(cadena, InStr(cadena, ":") + 1, cadena.Length)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical)
        End Try
        Return resul
    End Function

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            If chk_todos.Checked = False Then
                If rbtipoarticulo.Checked = False Then
                    If txtcodigo1.Text = "" Then
                        txtcodigo1.Select()
                        Exit Sub
                    ElseIf txtcodigo2.Text = "" Then
                        txtcodigo2.Select()
                        Exit Sub
                    End If
                End If
            End If
            If rblinea.Checked = True Then
                If cboFamilia.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Familia", MsgBoxStyle.Critical)
                    cboFamilia.Select()
                    Exit Sub
                End If
            End If

            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("REPORTES_PART")
            Me.Cursor = Cursors.WaitCursor
            If rbcodigo.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Part_Codigo(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_producto_codigo.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text))
                End If
            ElseIf rbfamilia.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Part_Familia(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_producto_Familia.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text))
                End If
            ElseIf rblinea.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Part_Linea(TraerCodigo(txtcodigo1.Text), TraerCodigo(txtcodigo2.Text), cboFamilia.SelectedValue.ToString)
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_producto_Linea.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & TraerCodigo(txtcodigo1.Text), "@CODIGO_FINAL;" & TraerCodigo(txtcodigo2.Text), "@LINEA;" & cboFamilia.SelectedValue)
                End If
            ElseIf rbtipoarticulo.Checked = True Then
                dtImprimir = reporteBL.EjecutarReporte_Part_Tipo(IIf(chk_todos.Checked, "", cboTipoPart.SelectedValue.ToString))
                If dtImprimir.Rows.Count() <> 0 Then
                    crystalBL.Muestra_Reporte("rpt_producto_Tipo.rpt", dtImprimir, "", "", "@CODIGO_INICIAL;" & cboTipoPart.SelectedValue)
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcodigo.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If rbcodigo.Checked = True Then
            txtdescripcion1.Text = "Del articulo"
            txtdescripcion2.Text = "Al articulo"
        End If
    End Sub

    Private Sub rbfamilia_CheckedChanged(sender As Object, e As EventArgs) Handles rbfamilia.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If rbfamilia.Checked = True Then
            txtdescripcion1.Text = "De la familia"
            txtdescripcion2.Text = "A la familia"
        End If
    End Sub

    Private Sub rbtipoarticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtipoarticulo.CheckedChanged
        If rbtipoarticulo.Checked Then
            txtdescripcion1.Text = "Seleccione una Clase de Artículo"
            pnlTipoProducto.Visible = True
            cboTipoPart.Enabled = True
            chk_todos.Checked = False
        Else
            pnlTipoProducto.Visible = False
        End If
    End Sub

    Private Sub rblinea_CheckedChanged(sender As Object, e As EventArgs) Handles rblinea.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        cboFamilia.SelectedIndex = 0
        If rblinea.Checked = True Then
            Panel1.Visible = False
            cboFamilia.Enabled = True
            Label38.Text = "Seleccione una Familia"
            txtdescripcion1.Text = "De la linea"
            txtdescripcion2.Text = "A la linea"
        Else
            Panel1.Visible = True
            cboFamilia.Enabled = False
            Label38.Text = "..."
        End If
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        txtcodigo1.Text = ""
        txtcodigo2.Text = ""
        If chk_todos.Checked = True Then
            cboTipoPart.Enabled = False
            txtcodigo1.Enabled = False
            txtcodigo2.Enabled = False
        Else
            cboTipoPart.Enabled = True
            txtcodigo1.Enabled = True
            txtcodigo2.Enabled = True
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        pnlTipoProducto.Visible = False
        pnlreporte.Visible = False

    End Sub


    Private Sub Listado_Ayudas(ByVal texto As TextBox)
        Try
            If rblinea.Checked = True Then
                If cboFamilia.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Familia.", MsgBoxStyle.Critical)
                    cboFamilia.Focus()
                    Exit Sub
                End If
            End If
            If chk_todos.Checked = False Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                If rbcodigo.Checked = True Then
                    sql = "PART_SP_S_LISTADO_PART"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Listado de Articulos"
                ElseIf rbfamilia.Checked = True Then
                    sql = "PART_SP_S_LISTADO_FAMILY"
                    frm.CadenaConsulta = sql
                    frm.Titulo = "Listado de Familias"
                ElseIf rblinea.Checked = True Then
                    sql = "PART_SP_S_LISTADO_LINEAS"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboFamilia.SelectedValue.ToString
                ElseIf rbtipoarticulo.Checked = True Then
                    sql = "PART_SP_S_LISTADO_TIPO_ARTICULO"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboTipoPart.SelectedValue.ToString
                End If
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    texto.Text = frm.Data_Matriz.Rows(0).Item(0) & ":" & frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigo1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigo1.MouseDoubleClick
        Listado_Ayudas(txtcodigo1)
    End Sub

    Private Sub txtcodigo2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigo2.MouseDoubleClick
        Listado_Ayudas(txtcodigo2)
    End Sub

    Private Sub opttodos_CheckedChanged(sender As Object, e As EventArgs) Handles opttodos.CheckedChanged
        'Call MostrarLineas()
        'Call MostrarTodosDatosArticulos()
    End Sub

    Private Sub optmuestramedica_CheckedChanged(sender As Object, e As EventArgs) Handles optmuestramedica.CheckedChanged
        'Call MostrarLineas()
        Call MostrarTodosDatosArticulos()
    End Sub

    Private Sub optproductosgranel_CheckedChanged(sender As Object, e As EventArgs) Handles optproductosgranel.CheckedChanged
        'Call MostrarLineas()
        Call MostrarTodosDatosArticulos()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub txtpesoArticulo_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstLineas.Items.Count - 1
                chklstLineas.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstLineas.Items.Count - 1
                chklstLineas.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkLineas_CheckedChanged(sender As Object, e As EventArgs) Handles checkLineas.CheckedChanged
        If checkLineas.Checked Then
            ActivarCheck(True)
            chklstLineas.Enabled = False
        Else
            ActivarCheck(False)
            chklstLineas.Enabled = True
        End If
    End Sub



    Private Sub txtCuentaCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaCompra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_des_TextChanged(sender As Object, e As EventArgs) Handles txt_des.TextChanged
        If bol_nuevo = True Then
            'txtdecComercial.Text = txt_des.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnproductopiloto.Click
        If ValidacionesGenerales() = False Then Exit Sub
        Dim opcion As DialogResult = MsgBox("¿Desea Generar un producto Piloto?" _
                                            , MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema")
        If opcion = DialogResult.Yes Then
            bol_nuevo = True
            GuardarArticulos(indiceP, valorP)
            Call Avisar("Proceso generado correctamente")
            Call btn_cancelar_Click(sender, e)
            gb_data.Enabled = False
            GBmuestraMedica.Visible = False
            cboTipoProducto.SelectedIndex = 0
            MostrarTodosDatosArticulos()
        End If
    End Sub

    Private Sub dgv_articulos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_articulos.CellContentDoubleClick
        Call btn_Editar_Click(sender, e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ' Seleccionar la imagen
        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        oFD.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp"
        If oFD.ShowDialog = DialogResult.OK Then
            ' La cantidad de caracteres máximo
            ' (por si el path es demasiado largo)
            Dim i As Integer = 255 'dt.Columns("Nombre").MaxLength
            If i < 0 Then i = 255
            ' El nombre del fichero
            ' Nos quedamos solo con el nombre, sin el path
            Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
            If sNombre.Length > i Then
                ' Si el nombre es más grande de lo permitido, lo cortamos
                sNombre = sNombre.Substring(0, i)
            End If

            'Me.txt_foto.Text = sNombre
            Me.pb_img.Image = Image.FromFile(oFD.FileName)
            dgv_detalle.Rows(0).Cells("col_img").Value = pb_img.Image
        End If
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        pb_img.Image = Nothing
        dgv_detalle.Rows(0).Cells("col_img").Value = pb_img.Image
    End Sub

    Private Sub txtProduccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtProduccion.MouseDoubleClick
        Ayuda_Formulas()
    End Sub

    Private Sub txtProduccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Formulas()
        End If
    End Sub

    Private Sub txtcodigopres_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigopres.MouseDoubleClick
        Ayuda_Presentacion()
    End Sub

    Private Sub txtcodigopres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigopres.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Presentacion()
        End If
    End Sub

    Private Sub txtcapacidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcapacidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_vigencia_lot_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Numero(e, txt_vigencia_lot) ' txtTotal, caja de texto a validar
    End Sub
    Function Validacion_Ingreso() As Boolean

        If txt_cod_principio_activo.Text.Trim = "" Then
            MsgBox("Debe elegir un Principio Activo.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Function Validacion_Ingreso_Incripciones_Reg_Sanit() As Boolean

        If txt_num_regsanit.Text.Trim = "" Then
            MsgBox("Debe digitar un número de Reg. Sanitario.", MsgBoxStyle.Exclamation, "Sistemas Lusa")
            Return False
            Exit Function
        End If

        Return True

    End Function


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso() = False Then Exit Sub
            If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
                For Each rows As DataRow In dtdetalleArticuloPrincipal.Select("CODIGO='" & txt_cod_principio_activo.Text.Trim & "' ")
                    MsgBox("El Principio Activo elejido ya se encuentra adjuntado.", MsgBoxStyle.Information, "Aviso")
                    Exit Try
                Next
            End If
            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
            row("CODIGO") = txt_cod_principio_activo.Text.Trim
            row("DESCRIPCION") = txt_des_principio_activo.Text.Trim
            dtdetalleArticuloPrincipal.Rows.Add(row)
            dtdetalleArticuloPrincipal.AcceptChanges()
            txt_cod_principio_activo.Text = String.Empty
            txt_des_principio_activo.Text = String.Empty
            txt_cod_principio_activo.Focus()
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal
            'dgvDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle.RowCount = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo()
        End If
    End Sub
    Private Sub EliminandoArticulo()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal.AcceptChanges()
            Next
            RehacerSecuencia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EliminandoArticulo_Incripciones_Reg_Sanit()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgv_incripciones_regsanit.Item(0, dgv_incripciones_regsanit.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
            Next
            RehacerSecuencia_Incripciones_RegSanit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal.Rows
            i += 1
            dtdetalleArticuloPrincipal.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal.EndInit()
            dtdetalleArticuloPrincipal.AcceptChanges()
        Next
    End Sub
    Private Sub RehacerSecuencia_Incripciones_RegSanit()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows
            i += 1
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.EndInit()
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
        Next
    End Sub
    Public Sub GenerarColummnaDataTable()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dgvDetalle.DataSource = Nothing
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal

        dgvDetalle.Columns(0).HeaderText = "Item"
        'dgvDetalle.Columns(0).Visible = False
        dgvDetalle.Columns(1).HeaderText = "Codigo"
        dgvDetalle.Columns(2).HeaderText = "Descripción"

        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub GenerarColummnaDataTable_Incripciones_RS()
        dtdetalleArticuloPrincipal_Incripciones_RegSanit = New DataTable
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("NUM_REG_SANIT", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("FEC_EMISION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("FEC_VENCIMIENTO", Type.GetType("System.String"))
        dgv_incripciones_regsanit.DataSource = Nothing
        dgv_incripciones_regsanit.DataSource = dtdetalleArticuloPrincipal_Incripciones_RegSanit

        dgv_incripciones_regsanit.Columns(0).HeaderText = "Item"
        dgv_incripciones_regsanit.Columns(1).HeaderText = "N° Reg. Sanitario"
        dgv_incripciones_regsanit.Columns(2).HeaderText = "Fec. Emisión"
        dgv_incripciones_regsanit.Columns(3).HeaderText = "Fec. Vcto."

        dgv_incripciones_regsanit.AutoResizeColumns()
        dgv_incripciones_regsanit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub txt_cod_principio_activo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_principio_activo.MouseDoubleClick
        Ayuda_Lista_Principios_Activos()
    End Sub

    Private Sub txt_cod_principio_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_principio_activo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Lista_Principios_Activos()
        End If
    End Sub
    Private Sub Ayuda_Lista_Principios_Activos()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_PRINCIPIOS_ACTIVOS"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Principios Activos"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_principio_activo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_principio_activo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub txt_vigencia_lot_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_vigencia_lot.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DTP_FEC_EMI_REG_SANIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTP_FEC_VCTO_REG_SANIT.Focus()
        End If
    End Sub

    Private Sub DTP_FEC_VCTO_REG_SANIT_KeyDown(sender As Object, e As KeyEventArgs) Handles DTP_FEC_VCTO_REG_SANIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_regsanit.Focus()
        End If
    End Sub

    Private Sub txt_num_regsanit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_regsanit.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add_regsanit.Focus()
        End If
    End Sub

    Private Sub btn_del_regsanit_Click(sender As Object, e As EventArgs) Handles btn_del_regsanit.Click
        If dgv_incripciones_regsanit.RowCount = 0 Then Exit Sub
        If dgv_incripciones_regsanit.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo_Incripciones_Reg_Sanit()
        End If
    End Sub

    Private Sub btn_add_regsanit_Click(sender As Object, e As EventArgs) Handles btn_add_regsanit.Click
        Try
            If Validacion_Ingreso_Incripciones_Reg_Sanit() = False Then Exit Sub
            If dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count > 0 Then
                'For Each rows As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Select("NUM_REG_SANIT='" & txt_num_regsanit.Text.Trim & "' ")
                '    MsgBox("El Registro Sanitario ya se encuentra registrado.", MsgBoxStyle.Information, "Aviso")
                '    Exit Try
                'Next
            End If
            Dim row As DataRow = dtdetalleArticuloPrincipal_Incripciones_RegSanit.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count() + 1
            row("NUM_REG_SANIT") = txt_num_regsanit.Text.Trim
            row("FEC_EMISION") = DTP_FEC_EMI_REG_SANIT.Value.ToString("dd/MM/yyyy")
            row("FEC_VENCIMIENTO") = DTP_FEC_VCTO_REG_SANIT.Value.ToString("dd/MM/yyyy")
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Add(row)
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
            DTP_FEC_EMI_REG_SANIT.Value = LibComunVar.ClsVarComun.FechaSistema
            DTP_FEC_VCTO_REG_SANIT.Value = LibComunVar.ClsVarComun.FechaSistema
            txt_num_regsanit.Text = String.Empty
            txt_num_regsanit.Focus()
            dgv_incripciones_regsanit.DataSource = dtdetalleArticuloPrincipal_Incripciones_RegSanit
            'dgvDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub chk_prod_controlado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_prod_controlado.CheckedChanged
        If chk_prod_controlado.Checked Then
            gb_tipo_prod_controlado.Enabled = True
            cbo_tipo_prod_controlado.SelectedIndex = -1
        Else
            gb_tipo_prod_controlado.Enabled = False
            cbo_tipo_prod_controlado.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtUnidMedRef_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtUnidMedRef.MouseDoubleClick
        Call Ayuda_UnidadesMedida("REF")
    End Sub

    Private Sub txt_um_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_um.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_UnidadesMedida()
        End If
    End Sub

    Private Sub txtUnidMedRef_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidMedRef.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_UnidadesMedida("REF")
        End If
    End Sub

    Private Sub txt_um_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_um.MouseDoubleClick
        Ayuda_UnidadesMedida()
    End Sub

    Private Sub Tool_Precio_Mat_Empaque_Click(sender As Object, e As EventArgs) Handles Tool_Precio_Mat_Empaque.Click
        Dim frmPreciosMat_Empaque As New FrmArticuloAct_Mat_Empaque
        OpenSubForm(frmPreciosMat_Empaque)
    End Sub
    Private Function OpenSubForm(ByVal form As Form) As Boolean
        Dim estado As Boolean = True
        Try
            For Each formulario As Form In Application.OpenForms
                If formulario.Name = form.Name Then
                    estado = False
                    formulario.Activate()
                    Exit Try
                End If
            Next
            form.Show()
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub txt_linea_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_linea.MouseDoubleClick
        If Ayuda_Lineas() Then
            If bol_nuevo = True Then
                ObtenerCodigoArticulo()
            End If
        End If
    End Sub


    Private Sub txt_tipo_origen_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tipo_origen.MouseDoubleClick
        Ayuda_Tipo_Origen()
    End Sub

    Private Sub txt_tipo_origen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_origen.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Origen()
        End If
    End Sub

    Private Sub txt_tipo_origen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tipo_origen.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then TextBox8.Focus()
    End Sub

    Private Sub Ayuda_Tipo_Origen()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CX_SP_S_TIPO_ORIGEN_AYU"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Tipo de Origen"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_tipo_origen.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_tipo_origen_desc.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            txt_tipo_origen.Focus()
        End If
        frm.Close()

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_9.KeyPress, txt_10.KeyPress, txt_5.KeyPress, txt_4.KeyPress, txt_3.KeyPress, txt_2.KeyPress, txt_11.KeyPress, txt_6.KeyPress, txt_7.KeyPress, txt_8.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_minimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock_minimo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_punto_pedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_punto_pedido.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_maximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock_maximo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_minimo_Leave(sender As Object, e As EventArgs) Handles txt_stock_minimo.Leave
        If txt_stock_minimo.Text = "" Then
            txt_stock_minimo.Text = Format(Double.Parse(0), "##,##0")
        Else
            txt_stock_minimo.Text = Format(Double.Parse(txt_stock_minimo.Text), "##,##0")
        End If
    End Sub

    Private Sub txt_punto_pedido_Leave(sender As Object, e As EventArgs) Handles txt_punto_pedido.Leave
        If txt_punto_pedido.Text = "" Then
            txt_punto_pedido.Text = Format(Double.Parse(0), "##,##0")
        Else
            txt_punto_pedido.Text = Format(Double.Parse(txt_punto_pedido.Text), "##,##0")
        End If
    End Sub

    Private Sub txt_stock_maximo_Leave(sender As Object, e As EventArgs) Handles txt_stock_maximo.Leave
        If txt_stock_maximo.Text = "" Then
            txt_stock_maximo.Text = Format(Double.Parse(0), "##,##0")
        Else
            txt_stock_maximo.Text = Format(Double.Parse(txt_stock_maximo.Text), "##,##0")
        End If
    End Sub

    Private Sub txt_cod_linea_produccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_linea_produccion.MouseDoubleClick
        Ayuda_Linea_produccion()
    End Sub

    Private Sub txt_cod_linea_produccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_linea_produccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Linea_produccion()
        End If
    End Sub

    Private Sub Ayuda_Linea_produccion()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "PART_SP_S_LINEA_PRODUCCION"
        frm.CadenaConsulta = sql
        frm.Titulo = "Linea de Producción"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_linea_produccion.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_des_lina_produccion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
        End If
        frm.Close()
    End Sub

    Private Sub btn_Adicionales_Click(sender As Object, e As EventArgs) Handles btn_Adicionales.Click
        Dim CodigoArticulo As String = String.Empty
        Dim descripcion As String = String.Empty
        Dim UM As String = String.Empty
        If dgv_articulos.CurrentRow Is Nothing Then Exit Sub
        CodigoArticulo = dgv_articulos.CurrentRow.Cells("codigo").Value 'dgv_articulos.Item(0, dgv_articulos.CurrentRow.Index).Value
        descripcion = dgv_articulos.CurrentRow.Cells("descripcion").Value 'dgv_articulos.Item(0, dgv_articulos.CurrentRow.Index).Value
        UM = dgv_articulos.CurrentRow.Cells("col_UOM").Value 'dgv_articulos.Item(0, dgv_articulos.CurrentRow.Index).Value
        If CodigoArticulo = String.Empty Then Exit Sub
        If descripcion = String.Empty Then Exit Sub
        If UM = String.Empty Then Exit Sub


        Dim objListaSKU As New FrmArticuloAct_Unidad_Medida


        With objListaSKU
            .txtCodigoProducto.Text = CodigoArticulo
            .txtDescripcionProducto.Text = descripcion
            .txtUMProducto.Text = UM

            .ShowDialog()
        End With
    End Sub
End Class