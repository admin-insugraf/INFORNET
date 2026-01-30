Imports System.Windows.Forms

Public Class Frm_Personal

    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.ORDER_PRODUCTION
    Dim dtdetalles As DataTable
    Dim dtdetalles_validar As DataTable
    Dim _NUEVO_CODIGO As String


    Private Sub Frm_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
    End Sub


    Private Sub Cargar_Datos()
        tipoPagoBL = New ClsOperaciones.ORDER_PRODUCTION
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_Lista_Personal()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_Lista.DataSource = dtv
            dgv_Lista.Columns(0).Width = 80
            dgv_Lista.Columns(1).Width = 250
            'dgv_Lista.Columns(2).Width = 150
            dgv_Lista.Columns(0).HeaderText = "Codigo Interno"
            dgv_Lista.Columns(1).HeaderText = "Descripcion"
            dgv_Lista.Columns(2).HeaderText = "Tipo"
            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        Else
            dgv_Lista.DataSource = Nothing
            lblCantidad.Text = "Se encontraron 0 registros"
        End If
        tipoPagoBL = Nothing
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
        Call Limpiar_GroupBox(gb_datos)
        cbo_tipo.SelectedIndex = -1
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        gb_datos.Enabled = bol_nuevo
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Call Obtener_Codigo()
        txt_cod.Text = _NUEVO_CODIGO
        txt_des.Focus()
    End Sub

    Private Sub Obtener_Codigo()
        tipoPagoBL = New ClsOperaciones.ORDER_PRODUCTION
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_Codigo_Personal()
        If dtdetalles.Rows.Count() > 0 Then
            _NUEVO_CODIGO = dtdetalles.Rows(0).Item("CODIGO").ToString
        End If
        tipoPagoBL = Nothing
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try

            If txt_cod.Text.Trim = "" Then
                Avisar("Ingrese el codigo")
                txt_cod.Focus()
                Exit Sub
            End If

            If txt_des.Text.Trim = "" Then
                Avisar("Ingrese la descripcion")
                txt_des.Focus()
                Exit Sub
            End If

            If cbo_tipo.SelectedIndex = -1 Then
                Avisar("Elija un tipo de personal.")
                cbo_tipo.Focus()
                Exit Sub
            End If

            Dim termsBL As New ClsOperaciones.ORDER_PRODUCTION
            Dim termsBE As New ClsEntidades.PERSONAL

            Me.Cursor = Cursors.WaitCursor
            If bol_nuevo Then
                tipoPagoBL = New ClsOperaciones.ORDER_PRODUCTION
                dtdetalles_validar = New DataTable("Datos")
                dtdetalles_validar = tipoPagoBL.get_Personal_Existe(txt_cod.Text.Trim)
                If dtdetalles_validar.Rows.Count() <> 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El codigo ingresado ya existe. Verifique!!!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            With termsBE
                .TYPE_ID = txt_cod.Text.Trim
                .NAME = txt_des.Text.Trim
                .CODIGO_EQUIPO = cbo_tipo.Text
            End With

            If bol_nuevo Then
                termsBL.Insert_Personal(termsBE)
            Else
                termsBL.Update_Personal(termsBE)
            End If

            Call Avisar("Proceso generado correctamente!")
            Cargar_Datos()
            btn_cancelar_Click(sender, e)
            dgv_Lista.Focus()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        bol_nuevo = False
        Call Limpiar_GroupBox(gb_datos)
        txt_cod.Text = dgv_Lista.CurrentRow.Cells(0).Value.ToString
        txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = True
        txt_des.Text = dgv_Lista.CurrentRow.Cells(1).Value.ToString
        cbo_tipo.Text = dgv_Lista.CurrentRow.Cells(2).Value.ToString
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Try

            If dgv_Lista.Rows.Count = 0 Then Exit Sub
            If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
            If Preguntar("Seguro de eliminar?") Then
                Me.Cursor = Cursors.WaitCursor
                Dim termsBL As New ClsOperaciones.ORDER_PRODUCTION
                Dim termsBE As New ClsEntidades.PERSONAL
                termsBE.TYPE_ID = dgv_Lista.CurrentRow.Cells(0).Value.ToString
                termsBL.Delete_Personal(termsBE)
                termsBE = Nothing
                termsBL = Nothing
                Call Cargar_Datos()
                Call Avisar("Proceso generado correctamente!")
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub


    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
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

    Private Sub txtFiltro_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
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

    Private Sub txt_codigo_equipo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cbo_tipo.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub
End Class