Imports LibComunVar
Imports System.Windows.Forms
Imports System.Drawing
Imports LibCobranzas

Public Class FrmReporteProductoVencer
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim dtReporte As DataTable

    Private _NombreReporte As String

    Dim reporteBL As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte


    Public Property NombreReporte As String
        Get
            Return _NombreReporte
        End Get
        Set(value As String)
            _NombreReporte = value
        End Set
    End Property


    Public Sub MostrarReportes(ByVal Fecha As String, ByVal art_inicial As String, ByVal art_final As String)
        Try
            reporteBL = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            Dim lista As New List(Of String)
            Dim idAlmacen As String = String.Empty
            Dim i As Integer = 0
            Me.Cursor = Cursors.WaitCursor
            Do While i <= chklstAlmacenes.CheckedItems.Count - 1
                idAlmacen = idAlmacen & """" & TraerCodigo(chklstAlmacenes.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idAlmacen.Length() <> 0 Then
                idAlmacen = Mid(idAlmacen, 1, idAlmacen.Length - 1)
            End If
            dtReporte = New DataTable("ProductoVencer")
            dtReporte = reporteBL.Get_Imprimir_Producto_Vencer(idAlmacen, art_inicial, art_final, Fecha, IIf(chkfamilia.Checked = True, "", cboFamilia.SelectedValue.ToString), IIf(chklineas.Checked = True, "", cbolinea.SelectedValue.ToString))
            If dtReporte.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("PRO_VEN.rpt", "", "", "", "", "@ALMACEN;" & idAlmacen, "@PROD_INI;" & art_inicial, "@PROD_FIN;" & art_final, "@FECHA_LIMITE;" & dtpfechaInicio.Value _
                                          , "@FAMILIA;" & IIf(chkfamilia.Checked = True, "", cboFamilia.SelectedValue.ToString), "@LINEA;" & IIf(chklineas.Checked = True, "", cbolinea.SelectedValue.ToString))
            Else
                MsgBox("No hay informacion dispnible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
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
                ' chklstAlmacenes.SelectedIndex = 1
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
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

    Private Sub Mostrarlineas()
        Try
            Dim clsFamiliasBl As New ClsOperaciones.LINES
            Dim dtlineas As New DataTable
            dtlineas = clsFamiliasBl.get_MostrarLineasFamilia(cboFamilia.SelectedValue.ToString)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtlineas.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UNA LINEA)"
            dtlineas.Rows.InsertAt(row, 0)
            clsFamiliasBl = Nothing
            If dtlineas.Rows.Count() <> 0 Then
                cbolinea.DisplayMember = "DESCRIPCION"
                cbolinea.ValueMember = "CODIGO"
                cbolinea.DataSource = dtlineas
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmReporteKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
        MostrarFamilias()
    End Sub

    Private Sub txtarticuloInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticuloInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticuloInicial_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtarticuloInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarticuloInicial.KeyPress

    End Sub

    Private Sub txtarticuloInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticuloInicial.MouseDoubleClick
        Try
            If chkfamilia.Checked = False Then
                If cboFamilia.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Familia.", MsgBoxStyle.Critical)
                    cboFamilia.Focus()
                    Exit Sub
                End If
            End If
            If chklineas.Checked = False Then
                If cbolinea.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Linea.", MsgBoxStyle.Critical)
                    cboFamilia.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            If chkfamilia.Checked = True Then
                sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_SIN"
                frm.CadenaConsulta = sql
            Else
                If chklineas.Checked = True Then
                    sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_CON"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboFamilia.SelectedValue.ToString
                Else
                    sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_ALL"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboFamilia.SelectedValue.ToString
                    frm.Filtros2 = cbolinea.SelectedValue.ToString
                End If
            End If
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticuloInicial.Text = frm.Data_Matriz.Rows(0).Item(0)
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtarticulofinal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtarticulofinal.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtarticulofinal_MouseDoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtarticulofinal_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtarticulofinal.MouseDoubleClick
        Try
            If chkfamilia.Checked = False Then
                If cboFamilia.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Familia.", MsgBoxStyle.Critical)
                    cboFamilia.Focus()
                    Exit Sub
                End If
            End If
            If chklineas.Checked = False Then
                If cbolinea.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar una Linea.", MsgBoxStyle.Critical)
                    cboFamilia.Focus()
                    Exit Sub
                End If
            End If
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            If chkfamilia.Checked = True Then
                sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_SIN"
                frm.CadenaConsulta = sql
            Else
                If chklineas.Checked = True Then
                    sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_CON"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboFamilia.SelectedValue.ToString
                Else
                    sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA_ALL"
                    frm.CadenaConsulta = sql
                    frm._Flag_Filtro = True
                    frm.Filtros1 = cboFamilia.SelectedValue.ToString
                    frm.Filtros2 = cbolinea.SelectedValue.ToString
                End If
            End If
            frm.Titulo = "Articulos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtarticulofinal.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        If chklstAlmacenes.CheckedItems.Count() = 0 Then
            MsgBox("Debe seleccionar al menos un Almacen.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If chk_articulos.Checked = False Then
            If txtarticuloInicial.Text = "" And txtarticulofinal.Text = "" Then
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Critical)
            End If
        End If
        MostrarReportes(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), IIf(txtarticuloInicial.Text = "", txtarticulofinal.Text, txtarticuloInicial.Text), _
                        IIf(txtarticulofinal.Text = "", txtarticuloInicial.Text, txtarticulofinal.Text))
    End Sub
 

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        chklstAlmacenes.Enabled = Not checkAlmacen.Checked
        Dim i As Integer = 0
        Do While i <= chklstAlmacenes.Items.Count - 1
            chklstAlmacenes.SetItemChecked(i, checkAlmacen.Checked)
            i = i + 1
        Loop
    End Sub

    Private Sub chk_articulos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulos.CheckedChanged
        txtarticuloInicial.Text = ""
        txtarticulofinal.Text = ""
        If chk_articulos.Checked Then
            txtarticuloInicial.Enabled = False
            txtarticulofinal.Enabled = False
        Else
            txtarticuloInicial.Enabled = True
            txtarticulofinal.Enabled = True
        End If


    End Sub

    Private Sub cboFamilia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFamilia.SelectionChangeCommitted
        If cboFamilia.SelectedIndex = -1 Then Exit Sub
        If cboFamilia.SelectedIndex = 0 Then
            GroupBox3.Enabled = False
        Else
            GroupBox3.Enabled = True
        End If
        Mostrarlineas()
    End Sub

    Private Sub chkfamilia_CheckedChanged(sender As Object, e As EventArgs) Handles chkfamilia.CheckedChanged

        If chkfamilia.Checked = True Then
            cboFamilia.Enabled = False
            cboFamilia.SelectedIndex = 0
            chklineas.Checked = True
        Else
            cboFamilia.Enabled = True
            cboFamilia.SelectedIndex = 0
            GroupBox3.Enabled = False
            cbolinea.DataSource = Nothing
            txtarticuloInicial.Text = ""
            txtarticulofinal.Text = ""
            chklineas.Checked = False
        End If
    End Sub

    Private Sub chklineas_CheckedChanged(sender As Object, e As EventArgs) Handles chklineas.CheckedChanged
        If chklineas.Checked = True Then
            cbolinea.Enabled = False
            If cboFamilia.SelectedIndex > 0 Then
                cbolinea.SelectedIndex = 0
            End If
        Else
            cbolinea.Enabled = True
            If cboFamilia.SelectedIndex > 0 Then
                cbolinea.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class