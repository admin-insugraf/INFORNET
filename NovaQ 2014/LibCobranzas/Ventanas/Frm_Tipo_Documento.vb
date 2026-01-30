Imports System.Windows.Forms
Public Class Frm_Tipo_Documento
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS
    Dim dtdetalles As DataTable
    Private Sub Frm_Tipo_Documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
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

    Private Sub Cargar_Datos()
        tipoPagoBL = New ClsOperaciones.TERMS
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_tipo_Documento()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_Lista.DataSource = dtv
            dgv_Lista.Columns(0).Width = 80
            dgv_Lista.Columns(1).Width = 250
            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        tipoPagoBL = Nothing
    End Sub

    Private Function GeneracionCodigo(ByVal Tipo As String) As Boolean
        Dim ESTADO As Boolean = True
        Try
            tipoPagoBL = New ClsOperaciones.TERMS
            dtdetalles = New DataTable("Codigo")
            Dim codigo As String = String.Empty
            If Tipo = "A" Then
                dtdetalles = tipoPagoBL.GeneracionCodigoFormaPago(Tipo)
                If dtdetalles.Rows.Count() <> 0 Then
                    txt_cta_soles_desc.Text = dtdetalles.Rows(0).Item("Codigo").ToString
                End If
            ElseIf Tipo = "M" Then
                codigo = txt_cta_soles_desc.Text.Trim
                codigo = String.Format("{0:00}", CInt(codigo))
                dtdetalles = tipoPagoBL.GeneracionCodigoFormaPago(Tipo, codigo)
                If dtdetalles.Rows.Count() <> 0 Then
                    If dtdetalles.Rows(0).Item("codigo").ToString <> codigo Then
                        MsgBox("El codigo ingresado ya Existe..", MsgBoxStyle.Exclamation)
                        ESTADO = False
                        txt_cta_soles_desc.Focus()
                        Exit Try
                    End If

                End If
            End If
        Catch ex As Exception
            ESTADO = False
            MsgBox(ex.Message)
        End Try
        Return ESTADO
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

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Limpiar_GroupBox(gb_datos)
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txt_cod.Enabled = bol_nuevo
        txt_cod.Focus()
    End Sub

    Function Cargar_Datos(ByVal _COD As String) As Boolean
        Dim ESTADO As Boolean = True
        Try
            tipoPagoBL = New ClsOperaciones.TERMS
            dtdetalles = New DataTable("")
            dtdetalles = tipoPagoBL.Validar_tipo_Documento(_COD)
            If dtdetalles.Rows.Count() <> 0 Then
                ESTADO = False
            End If
            tipoPagoBL = Nothing
        Catch ex As Exception
            ESTADO = False
            MsgBox(ex.Message)
        End Try
        Return ESTADO
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_cod.Text.Trim = "" Then
            MsgBox("Ingrese el codigo del Tipo de Documento", MsgBoxStyle.Exclamation, "Aviso")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            MsgBox("Ingrese la descripcion del Tipo de Documento", MsgBoxStyle.Exclamation, "Aviso")
            txt_des.Focus()
            Exit Sub
        End If

        If bol_nuevo = True Then
            If Cargar_Datos(txt_cod.Text) = False Then
                MsgBox("El codigo ingresado ya existe, verifique.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
        End If
        

        Dim termsBL As New ClsOperaciones.TERMS
        Dim termsBE As New ClsEntidades.DOCUMENT_TYPE
        Dim codigo As String = String.Empty

        With termsBE
            .TYPE_ID = txt_cod.Text
            .NAME = txt_des.Text.Trim
            .SUNAT_ID = txt_cod_sunat.Text
            .ACCOUNT = txt_cta_soles.Text
            .ACCOUNT_ME = txt_cta_dolares.Text
        End With

        If bol_nuevo Then
            termsBL.Insert_Document_type(termsBE)
        Else
            termsBL.Update_Tipo_Documento(termsBE)
        End If

        Call Avisar("Listo!")
        btn_cancelar_Click(sender, e)
        dgv_Lista.Focus()

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        bol_nuevo = False
        Call Limpiar_GroupBox(gb_datos)

        txt_cod.Text = dgv_Lista.CurrentRow.Cells("COD").Value.ToString
        txt_des.Text = dgv_Lista.CurrentRow.Cells("DES").Value.ToString
        txt_cod.Enabled = bol_nuevo

        tipoPagoBL = New ClsOperaciones.TERMS
        dtdetalles = New DataTable("Datos")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_Datos_tipo_Documento(txt_cod.Text)
        If dtdetalles.Rows.Count() <> 0 Then
            txt_cod_sunat.Text = dtdetalles.Rows(0).Item("SUNAT_ID").ToString
            txt_cta_soles.Text = dtdetalles.Rows(0).Item("ACCOUNT").ToString
            txt_cta_soles_desc.Text = dtdetalles.Rows(0).Item("ACCOUNT_SOLES").ToString
            txt_cta_dolares.Text = dtdetalles.Rows(0).Item("ACCOUNT_ME").ToString
            txt_cta_dolares_desc.Text = dtdetalles.Rows(0).Item("ACCOUNT_ME_DESC").ToString
        Else
            txt_cod_sunat.Text = ""
            txt_cta_soles.Text = ""
            txt_cta_soles_desc.Text = ""
            txt_cta_dolares.Text = ""
            txt_cta_dolares_desc.Text = ""
        End If
        tipoPagoBL = Nothing

        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        'If dgv_Lista.Rows.Count = 0 Then Exit Sub
        'If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        'If Preguntar("Seguro de eliminar?") Then
        '    Dim termsBL As New ClsOperaciones.TERMS
        '    Dim termsBE As New ClsEntidades.TERMS
        '    termsBE.ID = dgv_Lista.CurrentRow.Cells(0).Value.ToString
        '    termsBL.Delete(termsBE)
        '    termsBE = Nothing
        '    termsBL = Nothing
        '    Call Cargar_Datos()
        '    Call Avisar("Listo!")
        'End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_Lista.Focus()
        Botonera_Estado_Cambiar(False)
        'gb_datos.Enabled = True
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        Cargar_Datos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_sunat.Focus()
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

    Private Sub txt_cod_sunat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_sunat.MouseDoubleClick
        Call Ayuda_Cod_Sunat()
    End Sub

    Private Sub txt_cod_sunat_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_sunat.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Cod_Sunat()
        End If
        If e.KeyCode = Keys.Enter Then
            txt_cta_soles.Focus()
        End If
    End Sub
    Private Sub Ayuda_Cod_Sunat()
        Dim frm As New frmBuscar
        Dim sql As String = String.Empty
        sql = "CX_SP_S_COMP_SUNAT_AYU"
        frm.CadenaConsulta = sql
        frm.Titulo = "Lista de Codigos Sunat"
        frm.ShowDialog()
        If frm.Data_Matriz.Rows.Count > 0 Then
            txt_cod_sunat.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            txt_cta_soles.Focus()
        End If
        frm.Close()

    End Sub

    Private Sub txt_cta_soles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_soles.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_soles, txt_cta_soles_desc)
    End Sub

    Private Sub txt_cta_soles_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_soles.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_soles, txt_cta_soles_desc)
        End If
        If e.KeyCode = Keys.Enter Then
            txt_cta_dolares.Focus()
        End If
    End Sub
    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox, ByVal CajaTexto2 As TextBox)
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
                CajaTexto2.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cta_dolares_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_dolares.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_dolares, txt_cta_dolares_desc)
    End Sub

    Private Sub txt_cta_dolares_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_dolares.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_dolares, txt_cta_dolares_desc)
        End If
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub
End Class