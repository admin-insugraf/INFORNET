Imports System.Windows.Forms

Public Class FrmCentroCosto

    Dim AsientoBl As ClsOperaciones.Asiento_Contable
    Dim Flag_modo_edicion As Boolean = False

    Dim dtv As DataView
    Dim STRorden As String = String.Empty

    Public Sub Botonera_Estado_Inicio(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = True
        frm.Controls("btn_grabar").Enabled = False
        frm.Controls("btn_Editar").Enabled = True
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_eliminar").Enabled = True
        frm.Controls("btn_salir").Enabled = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
        frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
        frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
        frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
        frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
        frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    End Sub


    Private Sub DocumentosPrincipal()
        Try
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim dtCabecera As New DataTable
            dtv = New DataView
            dtCabecera = AsientoBl.CentrosCostos()
            If dtCabecera.Rows.Count() <> 0 Then
                dtv = dtCabecera.DefaultView
                dgvCabecera.DataSource = dtv
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 200
                dgvCabecera.Columns(2).Width = 50
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Else
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub blank()
        txtcodigo.Text = String.Empty
        txtdescripcion.Text = String.Empty
        txtnode_id.Text = String.Empty
        txtnode_key.Text = String.Empty
        txtLevel.Text = String.Empty
        checkEstado.Checked = True
        checkTipo.Checked = False
        txtcuentaDebe.Text = String.Empty
        txtdescripcionDebe.Text = String.Empty
        txtdecripcionHaber.Text = String.Empty
        txtcuentaHaber.Text = String.Empty
    End Sub

    Private Sub FrmComprasConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call Botonera_Estado_Inicio(Me)
        Me.WindowState = FormWindowState.Maximized
        Botonera_Estado_Cambiar(False)
        DocumentosPrincipal()
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
        pnlcabecera.Visible = False
        GroupBox3.Visible = False
        blank()
        Flag_modo_edicion = False
        txtcodigo.Enabled = True
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txtcodigo.Text = String.Empty Then
            MsgBox("Debe ingresar el Codigo del Centro de Costo.", MsgBoxStyle.Information)
            txtcodigo.Focus()
            Exit Sub
        ElseIf txtdescripcion.Text = String.Empty Then
            MsgBox("Debe ingresar una Descripcion.", MsgBoxStyle.Information)
            txtdescripcion.Focus()
            Exit Sub
        End If
        If checkTipo.Checked = True Then
            If txtcuentaDebe.Text = String.Empty Then
                MsgBox("Debe seleccionar una Cuenta Contable para el Debe.", MsgBoxStyle.Information)
                txtcuentaDebe.Focus()
                Exit Sub
            ElseIf txtcuentaHaber.Text = String.Empty Then
                MsgBox("Debe seleccionar una Cuenta Contable para el Haber.", MsgBoxStyle.Information)
                txtcuentaHaber.Focus()
                Exit Sub
            End If
        End If
        Dim CentroCostEnt As New ClsEntidades.CENTER_COST
        AsientoBl = New ClsOperaciones.Asiento_Contable
        With CentroCostEnt
            .COST_CENTER_ID = txtcodigo.Text
            .COST_CENTER_DESCRIPTION = txtdescripcion.Text
            .CREATE_DATE = Date.Now
            .IS_STATUS = IIf(checkEstado.Checked = True, "1", "0")
            .USER_ID = LibComunVar.ClsVarComun.USUARIO
            .LAST_MODIFY_DATE = Date.Now
            .COMPUTER_ID = System.Net.Dns.GetHostName()
            .USER_MODIFIED = LibComunVar.ClsVarComun.USUARIO
            .NODE_ID = txtnode_id.Text
            .NODE_KEY = txtnode_key.Text
            .LEVEL_CCOST = txtLevel.Text
            .TYPE_MOV = IIf(checkTipo.Checked = True, "1", "0")
            .DESTINO_DEBE = txtcuentaDebe.Text
            .DESTINO_HABER = txtcuentaHaber.Text
        End With
        If Flag_modo_edicion = False Then
            If AsientoBl.GuardarCentroCosto(CentroCostEnt) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If AsientoBl.ModificarCentroCosto(CentroCostEnt) = True Then
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        End If
        btn_cancelar_Click(sender, e)
    End Sub

    Public Sub ModoEdicion(ByVal Codigo As String)
        Try
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim dtCabeceraEdicion As New DataTable("Edicion")
            dtCabeceraEdicion = AsientoBl.EdicionCentrosCostos(Codigo)
            If dtCabeceraEdicion.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtCabeceraEdicion.Rows.Count() - 1
                    txtcodigo.Text = dtCabeceraEdicion.Rows(i).Item("COST_CENTER_ID").ToString
                    txtdescripcion.Text = dtCabeceraEdicion.Rows(i).Item("COST_CENTER_DESCRIPTION").ToString

                    If dtCabeceraEdicion.Rows(i).Item("IS_STATUS").ToString = "0" Then
                        checkEstado.Checked = False
                    ElseIf dtCabeceraEdicion.Rows(i).Item("IS_STATUS").ToString = "1" Then
                        checkEstado.Checked = True
                    End If
                    txtnode_id.Text = dtCabeceraEdicion.Rows(i).Item("NODE_ID").ToString
                    txtnode_key.Text = dtCabeceraEdicion.Rows(i).Item("NODE_KEY").ToString
                    txtLevel.Text = dtCabeceraEdicion.Rows(i).Item("LEVEL_CCOST").ToString
                    If dtCabeceraEdicion.Rows(i).Item("TYPE_MOV").ToString = "0" Then
                        checkTipo.Checked = False
                        gbDestino.Enabled = False
                    ElseIf dtCabeceraEdicion.Rows(i).Item("TYPE_MOV").ToString = "1" Then
                        checkTipo.Checked = True
                        gbDestino.Enabled = True
                        txtcuentaDebe.Text = dtCabeceraEdicion.Rows(i).Item("DESTINO_DEBE").ToString
                        txtdescripcionDebe.Text = dtCabeceraEdicion.Rows(i).Item("DES_DEBE").ToString
                        txtcuentaHaber.Text = dtCabeceraEdicion.Rows(i).Item("DESTINO_HABER").ToString
                        txtdecripcionHaber.Text = dtCabeceraEdicion.Rows(i).Item("DES_HABER").ToString
                    End If
                Next
            Else
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Flag_modo_edicion = True
        Dim Codigo As String = String.Empty
        Dim Descripcion As String = String.Empty
        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        If String.IsNullOrEmpty(Codigo) Then Exit Sub
        pnlcabecera.Visible = False
        Botonera_Estado_Cambiar(True)
        blank()
        txtcodigo.Text = Codigo
        txtcodigo.Enabled = False
        ModoEdicion(Codigo)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim ConceptoCompraEnt As New ClsEntidades.CENTER_COST
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim Codigo As String = String.Empty
            Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Codigo) Then Exit Sub
            ConceptoCompraEnt.COST_CENTER_ID = Codigo
            If AsientoBl.EliminarCentroCosto(ConceptoCompraEnt) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
            DocumentosPrincipal()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(False)
        pnlcabecera.Visible = True
        GroupBox3.Visible = True
        DocumentosPrincipal()
    End Sub
 

    Private Sub checkTipo_CheckedChanged(sender As Object, e As EventArgs) Handles checkTipo.CheckedChanged
        gbDestino.Enabled = checkTipo.Checked
        txtcuentaDebe.Text = String.Empty
        txtdescripcionDebe.Text = String.Empty
        txtdecripcionHaber.Text = String.Empty
        txtcuentaHaber.Text = String.Empty
    End Sub


    Private Sub CuentaContable(ByVal Texto As TextBox, ByVal Descripcion As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_PLANCTAS_MOV"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = Date.Now.Year
            frm.Titulo = "Plan de Cuentas Contable"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                Texto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                Descripcion.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcuentaDebe_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaDebe.MouseDoubleClick
        CuentaContable(txtcuentaDebe, txtdescripcionDebe)
    End Sub

    Private Sub txtcuentaDebe_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaDebe.KeyDown
        If e.KeyCode = Keys.F1 Then
            CuentaContable(txtcuentaDebe, txtdescripcionDebe)
        End If
    End Sub

    Private Sub txtcuentaHaber_DoubleClick(sender As Object, e As EventArgs) Handles txtcuentaHaber.DoubleClick
        CuentaContable(txtcuentaHaber, txtdecripcionHaber)
    End Sub

    Private Sub txtcuentaHaber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaHaber.KeyDown
        If e.KeyCode = Keys.F1 Then
            CuentaContable(txtcuentaHaber, txtdecripcionHaber)
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If txtFiltro.Text = String.Empty Then
            dtv.RowFilter = String.Empty
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            Exit Sub
        Else
            dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
            If dtv.Count() = 0 Then
                STRorden = String.Empty
                STRorden = dgvCabecera.Columns(0).Name
                dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                If dtv.Count() = 0 Then
                    STRorden = String.Empty
                    STRorden = dgvCabecera.Columns(1).Name
                    dtv.RowFilter = STRorden & " like '" & txtFiltro.Text & "%'"
                    If dtv.Count() = 0 Then
                        STRorden = String.Empty
                        STRorden = dgvCabecera.Columns(0).Name & "+" & dgvCabecera.Columns(1).Name
                        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                        Exit Sub
                    End If
                End If
            End If
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Close()
    End Sub
End Class