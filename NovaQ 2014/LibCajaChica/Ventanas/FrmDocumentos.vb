Imports System.Windows.Forms
Public Class FrmDocumentos
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS
    Dim dtdetalles As DataTable
    Private Sub FrmDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
    End Sub

    Private Sub Cargar_Datos()
        tipoPagoBL = New ClsOperaciones.TERMS
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_Documentos_Caja_Chica()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_Lista.DataSource = dtv
            dgv_Lista.Columns(0).Width = 80
            dgv_Lista.Columns(1).Width = 250
            dgv_Lista.Columns(0).HeaderText = "Codigo"
            dgv_Lista.Columns(1).HeaderText = "Descripcion"
            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        Else
            dgv_Lista.DataSource = Nothing
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
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = bol_nuevo
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txt_cod.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
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

        If bol_nuevo = True Then
            If Validar_Codigo(txt_cod.Text) = False Then
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        

        Dim termsBL As New ClsOperaciones.TERMS
        Dim termsBE As New ClsEntidades.DOCUMENT_TYPE_CAJA_CHICA
        Dim codigo As String = String.Empty
        codigo = txt_cod.Text.Trim
        With termsBE
            .TYPE_ID = codigo
            .NAME = txt_des.Text.Trim
        End With

        If bol_nuevo Then
            termsBL.Insert_Documento_Caja_chica(termsBE)
        Else
            termsBL.Update_Documento_Caja_Chica(termsBE)
        End If

        Call Avisar("Proceso generado correctamente!")
        btn_cancelar_Click(sender, e)
        dgv_Lista.Focus()

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
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            Dim termsBL As New ClsOperaciones.TERMS
            Dim termsBE As New ClsEntidades.DOCUMENT_TYPE_CAJA_CHICA
            termsBE.TYPE_ID = dgv_Lista.CurrentRow.Cells(0).Value.ToString
            termsBL.Delete_Documento_CajaChica(termsBE)
            termsBE = Nothing
            termsBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Proceso generado correctamente!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        Cargar_Datos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Validar_Codigo(txt_cod.Text) Then
                txt_des.Focus()
            End If
        End If
    End Sub

    Private Function Validar_Codigo(ByVal _CODIGO As String) As Boolean
        tipoPagoBL = New ClsOperaciones.TERMS
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_ValidarCodigo_Documentos_CajaChica(_CODIGO)
        If dtdetalles.Rows.Count() > 0 Then
            MsgBox("El codigo ingresado ya esta registrado, utilize otro codigo.", MsgBoxStyle.Critical, "Sistemas")
            Return False
            Exit Function
        End If
        tipoPagoBL = Nothing
        Return True
    End Function

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden <> "" Then
            Dim wbusqueda As String = UCase(txtFiltro.Text)
            Dim myCurrencyManager As CurrencyManager
            myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
            Dim INTnewpos As Integer
            dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
            myCurrencyManager.Position = INTnewpos
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
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

End Class