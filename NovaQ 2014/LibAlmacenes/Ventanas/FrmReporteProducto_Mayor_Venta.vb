Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Imports LibCobranzas

Public Class FrmReporteProducto_Mayor_Venta
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporte As DataTable

    Private _NombreReporte As String
    Private _idAlmacen As String = ""

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte


    Public Sub MostrarReportes(ByVal Fecha_ini As String, ByVal Fecha_fin As String, ByVal Familia As String, ByVal art_inicial As String, ByVal art_final As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor
            dtReporte = New DataTable("Producto_Mayor_Venta")
            dtReporte = reporteBL.Imprimir_Producto_Mayor_Venta(Fecha_ini, Fecha_fin, Familia, art_inicial, art_final)
            If dtReporte.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_producto_mayor_venta.rpt", dtReporte, "", "", "@FECHA_INI;" & Fecha_ini, "@FECHA_FIN;" & Fecha_fin, "@FAMILIA;" & Familia, "@PART_INI;" & art_inicial, "@PART_FIN;" & art_final)
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MostrarFamilias()
        Try
            Dim clsFamiliasBl As New ClsOperaciones.FAMILY
            Dim dtFamilia As New DataTable
            dtFamilia = clsFamiliasBl.get_MostrarFamilias()
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtFamilia.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UNA FAMILIA)"
            dtFamilia.Rows.InsertAt(row, 0)
            clsFamiliasBl = Nothing
            If dtFamilia.Rows.Count() <> 0 Then
                cboFamilia.DisplayMember = "DESCRIPCION"
                cboFamilia.ValueMember = "CODIGO"
                cboFamilia.DataSource = dtFamilia
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            If chkfamilia.Checked = True Then
                sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_SIN"
                frmM.CadenaConsulta = sql
            Else
                sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_CON"
                frmM.CadenaConsulta = sql
                frmM._Flag_Filtro = True
                frmM.Filtros1 = cboFamilia.SelectedValue.ToString
            End If
            frmM.Titulo = "Seleccion de Articulos"
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmReporteKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrarFamilias()
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

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
            MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpfechaInicio.Focus()
            Exit Sub
        End If
        If chk_articulos.Checked = False Then
            If txtinicioArticulo.Text = "" Then
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf txtFinArticulo.Text = "" Then
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        MostrarReportes(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), IIf(chkfamilia.Checked = True, "", cboFamilia.SelectedValue.ToString), txtinicioArticulo.Text, txtFinArticulo.Text)
    End Sub

    Private Sub LimpiarArticulos()
        txtinicioArticulo.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
    End Sub

    Private Sub MostrandoArticulos()
        Try
            LimpiarArticulos()
            If chk_articulos.Checked Then
                Dim clsReportesBl = New ClsReporteGenerales
                Dim dtDatosPart = New DataTable("Detalles_Part")
                Dim rsql As String = String.Empty

                If chkfamilia.Checked Then
                    rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  ORDER BY ID"
                Else
                    rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  WHERE FAMILY ='" & cboFamilia.SelectedValue.ToString & "' ORDER BY ID"
                End If
                ''Mostrando data
                clsReportesBl = New ClsReporteGenerales
                dtDatosPart = New DataTable
                dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                If dtDatosPart.Rows.Count() <> 0 Then
                    ''Mostrando data del primer Articulo
                    txtinicioArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                    txtdescripcionArticuloInicial.Text = dtDatosPart.Rows(0).Item(1).ToString
                    '---Mostrando data
                    If chkfamilia.Checked Then
                        rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  ORDER BY ID DESC"
                    Else
                        rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  WHERE FAMILY ='" & cboFamilia.SelectedValue.ToString & "' ORDER BY ID DESC"
                    End If
                    clsReportesBl = New ClsReporteGenerales
                    dtDatosPart = New DataTable
                    dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                    ''Mostrando data del segundo  Articulo
                    txtFinArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                    txtDescripcionArticulofinal.Text = dtDatosPart.Rows(0).Item(1).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_articulos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulos.CheckedChanged
        If chkfamilia.Checked = True Then
            If chk_articulos.Checked Then
                GroupBox1.Enabled = False
                MostrandoArticulos()
            Else
                GroupBox1.Enabled = True
                LimpiarArticulos()
            End If
        Else
            If cboFamilia.SelectedIndex = 0 Then
                chk_articulos.Checked = False
                Exit Sub
            End If

            If chk_articulos.Checked Then
                GroupBox1.Enabled = False
                MostrandoArticulos()
            Else
                GroupBox1.Enabled = True
                LimpiarArticulos()
            End If
        End If


    End Sub

    Private Sub cboFamilia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFamilia.SelectionChangeCommitted
        If cboFamilia.SelectedIndex = -1 Then Exit Sub
        LimpiarArticulos()
        chk_articulos.Checked = False
        If cboFamilia.SelectedIndex = 0 Then
            gbArticulos.Enabled = False
        Else
            gbArticulos.Enabled = True
        End If
    End Sub

    Private Sub chkfamilia_CheckedChanged(sender As Object, e As EventArgs) Handles chkfamilia.CheckedChanged
        LimpiarArticulos()
        gbArticulos.Enabled = True
        chk_articulos.Checked = False
        GroupBox1.Enabled = True
        If chkfamilia.Checked = True Then
            cboFamilia.Enabled = False
            cboFamilia.SelectedIndex = 0
        Else
            cboFamilia.Enabled = True
            cboFamilia.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtFinArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinArticulo.MouseDoubleClick
        BuscarArticulos(txtFinArticulo, txtDescripcionArticulofinal)
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
    End Sub
End Class