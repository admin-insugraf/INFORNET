Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.SqlClient

Public Class Frm_Tipo_Articulo
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim TipoArticuloBl As ClsOperaciones.PART_TYPE
    Dim TipoArticuloENT As ClsEntidades.PART_TYPE

    Dim dtdetalles As DataTable
    Dim vendedorBE As ClsEntidades.SALES_REP

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

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



    Declare Function ExitWindowsEx Lib "user32" Alias "ExitWindowsEx" (ByVal uFlags As Long, ByVal dwReserved As Long) As Long



    Private Sub frm_CX_MA_Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        Call Iniciar_Form()
        CONTROLES(TabPage2, False)
    End Sub

    Private Sub Iniciar_Form()
        tc_tipos.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Datos()
        TipoArticuloBl = New ClsOperaciones.PART_TYPE
        dtdetalles = New DataTable("Vendedor")
        dtv = New DataView
        dtdetalles = TipoArticuloBl.Get_Tipos_Articulos()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_lista.DataSource = dtv
            dgv_lista.Columns(0).Width = 80
            dgv_lista.Columns(1).Width = 250
            dgv_lista.Columns(2).Width = 150
            dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            STRorden = dgv_lista.Columns(0).Name & "+" & dgv_lista.Columns(1).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            TipoArticuloBl = Nothing
        End If
    End Sub


    Private Sub Blank()
        txtcodigo.Text = String.Empty
        txtdescripcion.Text = String.Empty
        txtid.Text = String.Empty
        txtcuentaContable.Text = String.Empty
        lbldescuentacontable.Text = String.Empty
    End Sub

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

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        Blank()
        txtcodigo.Text = Numeracion()
        bol_nuevo = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
    End Sub

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New ClsTransacciones.PART_TYPE
            CORRELATIVOBL.NumeroCorrelativo_Tipo_Articulo()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "0"
            Else
                Correlativo = String.Format("{0:00}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim mensaje As String = String.Empty
        If bol_nuevo = True Then
            mensaje = "Se va a proceder a la creacion de un Tipo de articulo"
        Else
            mensaje = "Se va a proceder a la modificacion de un tipo de articulo"
        End If

        If MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txtcodigo.Text.Trim = "" Then
                MsgBox("No se cargo el dato del codigo", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf txtdescripcion.Text.Trim = "" Then
                MsgBox("Debe ingresar un descripcion", MsgBoxStyle.Information)
                txtdescripcion.Focus()
                Exit Sub
            End If
            TipoArticuloBl = New ClsOperaciones.PART_TYPE
            TipoArticuloENT = New ClsEntidades.PART_TYPE
            With TipoArticuloENT
                .ID = txtcodigo.Text
                .NAME = txtdescripcion.Text
                .CODIGO = txtid.Text
                .CUENTA_CONTABLE = txtcuentaContable.Text
            End With
            If TipoArticuloBl.Insert_Update(TipoArticuloENT, bol_nuevo) Then
                MsgBox("Transaccion realizada Exitosamente.!", MsgBoxStyle.Information)
            End If
            btn_cancelar_Click(sender, e)
            dgv_lista.Focus()
        End If

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        bol_nuevo = False
        Blank()
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txtcodigo.Text = dgv_lista.CurrentRow.Cells("Codigo").Value 'dgv_lista.Item(0, dgv_lista.CurrentRow.Index).Value
        txtdescripcion.Text = dgv_lista.CurrentRow.Cells("Descripcion").Value 'dgv_lista.Item(1, dgv_lista.CurrentRow.Index).Value
        txtid.Text = dgv_lista.CurrentRow.Cells("Abreviatura").Value 'dgv_lista.Item(2, dgv_lista.CurrentRow.Index).Value
        txtcuentaContable.Text = dgv_lista.CurrentRow.Cells("Cuenta_Contable").Value
        If Trim(txtcuentaContable.Text) <> "" Then
            TipoArticuloBl = New ClsOperaciones.PART_TYPE
            dtdetalles = New DataTable("Cuenta_contable")
            dtdetalles = TipoArticuloBl.Get_Desc_cuenta_contable(txtcuentaContable.Text)
            If dtdetalles.Rows.Count > 0 Then
                lbldescuentacontable.Text = dtdetalles.Rows(0).Item("DESCRIPCION").ToString
            End If
        End If
        

        txtdescripcion.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            TipoArticuloBl = New ClsOperaciones.PART_TYPE
            Dim codigo As String = String.Empty
            codigo = dgv_lista.CurrentRow.Cells(0).Value.ToString
            If String.IsNullOrEmpty(codigo) Then Exit Sub
            TipoArticuloBl.Delete(codigo)
            TipoArticuloBl = Nothing
            Call Cargar_Datos()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_lista.Focus()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        Cargar_Datos()
    End Sub


    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'dtv.Sort = STRorden
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

    Private Sub txt_correo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtcuentaContable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcuentaContable.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ayuda_CuentasContables(txtcuentaContable, lbldescuentacontable)
        End If
    End Sub

    Private Sub txtcuentaContable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcuentaContable.MouseDoubleClick
        Ayuda_CuentasContables(txtcuentaContable, lbldescuentacontable)
    End Sub
    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox, ByVal desc_cajatexto As Label)
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
                desc_cajatexto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class