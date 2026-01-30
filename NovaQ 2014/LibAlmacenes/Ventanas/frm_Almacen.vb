Imports System.Windows.Forms
Imports LibCobranzas

Public Class frm_Almacen
    Private nuevo As Boolean
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim AlmacenBl As ClsOperaciones.WAREHOUSE
    Dim AlmacenesBl As CLsNegocio.WAREHOUSE
    Dim AlmacenEnt As ClsEntidades.WAREHOUSE
    Dim dtdetalles As DataTable

    Private Sub GuardarAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.WAREHOUSE
            AlmacenEnt = New ClsEntidades.WAREHOUSE
            AlmacenEnt.ID = txtCodigo.Text
            AlmacenEnt.NAME = txtDescripcion.Text
            AlmacenEnt.ADDR_WHO = txtDireccion.Text
            AlmacenEnt.STATE_ID = txtDistrito.Text
            AlmacenEnt.TYPE_PART = txtTipoArticulo.Text
            AlmacenEnt.PHONE = txtTelefono.Text
            If String.IsNullOrEmpty(txtUltimoIngreso.Text.ToString) Then
                AlmacenEnt.LAST_NUM_IN = 0
            Else
                AlmacenEnt.LAST_NUM_IN = CDbl(txtUltimoIngreso.Text.Trim)
            End If
            If String.IsNullOrEmpty(txtUltimaSalida.Text.ToString) Then
                AlmacenEnt.LAST_NUM_OUT = 0
            Else
                AlmacenEnt.LAST_NUM_OUT = CDbl(txtUltimaSalida.Text.Trim)
            End If
            If cmbEstado.SelectedIndex = 0 Then AlmacenEnt.STATUS = "V" Else AlmacenEnt.STATUS = "A"
            AlmacenEnt.IS_DEFAULT = "0"
            If AlmacenesBl.GuardarActualizar(AlmacenEnt, nuevo) = True Then
                MsgBox("Operacion Generada Correctamente", MsgBoxStyle.Information, "Mensaje/Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarData()
        AlmacenesBl = New ClsNegocio.WAREHOUSE
        dtdetalles = New DataTable("Almacenes")
        dtv = New DataView
        dtdetalles = AlmacenesBl.get_AlmacenesGenerales()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgvAlmacenes.DataSource = dtv
            dgvAlmacenes.Columns(0).Width = 100
            dgvAlmacenes.Columns(1).Width = 300
            dgvAlmacenes.Columns(2).Visible = False
            dgvAlmacenes.Columns(3).Visible = False
            dgvAlmacenes.Columns(4).Visible = False
            dgvAlmacenes.Columns(5).Visible = False
            dgvAlmacenes.Columns(6).Visible = False
            dgvAlmacenes.Columns(7).Visible = False
            dgvAlmacenes.Columns(8).Visible = False
            dgvAlmacenes.Columns(9).Visible = False
            STRorden = dgvAlmacenes.Columns(0).Name & "+" & dgvAlmacenes.Columns(1).Name & "+" & dgvAlmacenes.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        AlmacenBl = Nothing
    End Sub


    Private Sub Ayuda_TipoArticulo()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PART_SP_S_PART_TYPE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Tipo de Articulo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtTipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcionTipoArticulo.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CorrelativoAlmacen()
        Try
            AlmacenesBl = New ClsNegocio.WAREHOUSE
            dtdetalles = New DataTable("Correlativo")
            dtdetalles = AlmacenesBl.get_GeneracionCodigoAutomatico()
            If dtdetalles.Rows.Count() <> 0 Then
                txtCodigo.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Blank()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtDistrito.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtTipoArticulo.Text = String.Empty
        txtUltimoIngreso.Text = 0
        txtUltimaSalida.Text = 0
        cmbEstado.SelectedIndex = 0
        txtTipoArticulo.Text = String.Empty
        txtDescripcionTipoArticulo.Text = String.Empty
    End Sub

    Private Function Validar() As Boolean
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            Avisar("El codigo es obligatorio")
            txtCodigo.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(txtDescripcion.Text) Then
            Avisar("La descripcion es obligatoria")
            txtDescripcion.Focus()
            Return False
        ElseIf String.IsNullOrEmpty(txtTipoArticulo.Text) Then
            Avisar("Debe seleccionar un Tipo de Articulo")
            txtTipoArticulo.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub CONTROLES(ByVal tab As TabPage, ByVal opcion As Boolean)
        Dim indice As Integer = 0
        indice = tc_tipos.SelectedIndex
        If opcion Then
            tab.Enabled = opcion
        Else
            tab.Enabled = opcion
        End If
        '-----------------------------------
        Select Case tc_tipos.SelectedIndex
            Case 0
                tc_tipos.SelectedIndex = indice + 1
            Case 1
                tc_tipos.SelectedIndex = indice - 1
        End Select
        ' ----------------------------------
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

    Private Sub frm_Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txtCodigo.Enabled = True
        Blank()
        CorrelativoAlmacen()
        txtDescripcion.Focus()
        nuevo = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If Validar() Then
            GuardarAlmacen()
            Call btn_cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub ModoEdicion()
        Try
            txtCodigo.Text = dgvAlmacenes.Item(0, dgvAlmacenes.CurrentRow.Index).Value
            txtDescripcion.Text = dgvAlmacenes.Item(1, dgvAlmacenes.CurrentRow.Index).Value
            txtDireccion.Text = dgvAlmacenes.Item(2, dgvAlmacenes.CurrentRow.Index).Value
            txtDistrito.Text = dgvAlmacenes.Item(3, dgvAlmacenes.CurrentRow.Index).Value
            txtTelefono.Text = dgvAlmacenes.Item(5, dgvAlmacenes.CurrentRow.Index).Value
            txtTipoArticulo.Text = dgvAlmacenes.Item(4, dgvAlmacenes.CurrentRow.Index).Value
            txtUltimoIngreso.Text = IIf(String.IsNullOrEmpty(dgvAlmacenes.Item(6, dgvAlmacenes.CurrentRow.Index).Value.ToString), 0, dgvAlmacenes.Item(6, dgvAlmacenes.CurrentRow.Index).Value)
            txtUltimoIngreso.Text = FormatNumber(txtUltimoIngreso.Text, 0)
            txtUltimaSalida.Text = IIf(String.IsNullOrEmpty(dgvAlmacenes.Item(7, dgvAlmacenes.CurrentRow.Index).Value.ToString), 0, dgvAlmacenes.Item(7, dgvAlmacenes.CurrentRow.Index).Value)
            txtUltimaSalida.Text = FormatNumber(txtUltimaSalida.Text, 0)
            If dgvAlmacenes.Item(8, dgvAlmacenes.CurrentRow.Index).Value = "V" Then cmbEstado.SelectedIndex = 0 Else cmbEstado.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvAlmacenes.Rows.Count = 0 Then Exit Sub
        If dgvAlmacenes.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        nuevo = False
        txtCodigo.Enabled = False
        Blank()
        ModoEdicion()
        txtDescripcion.Focus()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        cargarData()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvAlmacenes.Rows.Count = 0 Then Exit Sub
        If dgvAlmacenes.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            AlmacenesBl = New ClsNegocio.WAREHOUSE
            Dim Id As String = String.Empty
            Id = dgvAlmacenes.Item(0, dgvAlmacenes.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Id.ToString) Then Exit Sub
            If AlmacenesBl.get_EliminacionAlmacen(Id) = True Then
                MsgBox("Eliminado Correctamente", MsgBoxStyle.Information, "Mensaje-Sistemas")
            End If
            cargarData()
        End If
    End Sub
 

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtUltimoIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUltimoIngreso.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtUltimaSalida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUltimaSalida.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
 
    Private Sub txtTipoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoArticulo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_TipoArticulo()
        End If
    End Sub

    Private Sub txtTipoArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoArticulo.MouseDoubleClick
        Ayuda_TipoArticulo()
    End Sub

    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        ' Referenciamos el control TabPage que ha sido seleccionado
        Dim tp As TabPage = e.TabPage
        ' Cancelamos la selección si el control
        ' se encuentra deshabilitado.
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class