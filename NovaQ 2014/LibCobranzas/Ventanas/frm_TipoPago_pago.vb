Imports System.Windows.Forms

Public Class frm_TipoPago_pago

    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim tipoPagoBL As ClsOperaciones.TERMS_PAY
    Dim dtdetalles As DataTable


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

    Private Sub frm_CX_MA_TipoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
    End Sub
    Private Sub Cargar_Datos()
        tipoPagoBL = New ClsOperaciones.TERMS_PAY
        dtdetalles = New DataTable("DATOS_PAGO")
        dtv = New DataView
        dtdetalles = tipoPagoBL.get_terms()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_Lista.DataSource = dtv
            dgv_Lista.Columns(0).Width = 80
            dgv_Lista.Columns(1).Width = 250
            dgv_Lista.Columns(2).Width = 80
            STRorden = dgv_Lista.Columns(0).Name & "+" & dgv_Lista.Columns(1).Name & "+" & dgv_Lista.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        tipoPagoBL = Nothing
    End Sub

    Private Function GeneracionCodigo(ByVal Tipo As String) As Boolean
        Dim ESTADO As Boolean = True
        Try
            tipoPagoBL = New ClsOperaciones.TERMS_PAY
            dtdetalles = New DataTable("Codigo")
            Dim codigo As String = String.Empty
            If Tipo = "A" Then
                dtdetalles = tipoPagoBL.GeneracionCodigoFormaPago(Tipo)
                If dtdetalles.Rows.Count() <> 0 Then
                    txt_cod.Text = dtdetalles.Rows(0).Item("Codigo").ToString
                End If
            ElseIf Tipo = "M" Then
                codigo = txt_cod.Text.Trim
                codigo = String.Format("{0:00}", CInt(codigo))
                dtdetalles = tipoPagoBL.GeneracionCodigoFormaPago(Tipo, codigo)
                If dtdetalles.Rows.Count() <> 0 Then
                    MsgBox("El codigo ingresado ya Existe..", MsgBoxStyle.Information)
                    ESTADO = False
                    txt_cod.Focus()
                    Exit Try
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
        'txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = bol_nuevo
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        If GeneracionCodigo("A") = True Then txt_des.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_cod.Text.Trim = "" Then
            Avisar("Ingrese el codigo")
            txt_cod.Focus()
            Exit Sub
        Else
            If bol_nuevo = True Then
                If GeneracionCodigo("M") = False Then Exit Sub
            End If
        End If

        If txt_des.Text.Trim = "" Then
            Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        Dim termsBL As New ClsOperaciones.TERMS_PAY
        Dim termsBE As New ClsEntidades.TERMS_PAY
        Dim codigo As String = String.Empty
        codigo = txt_cod.Text.Trim
        codigo = String.Format("{0:00}", CInt(codigo))
        With termsBE
            .ID = codigo
            .NAME = txt_des.Text.Trim
            .NET_DAYS = IIf(mtb_dias.Text.Trim = "", 0, mtb_dias.Text.Trim)
        End With

        If bol_nuevo Then
            termsBL.Insert(termsBE)
        Else
            termsBL.Update(termsBE)
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
        txt_cod.Text = dgv_Lista.CurrentRow.Cells(0).Value.ToString
        txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = True
        txt_des.Text = dgv_Lista.CurrentRow.Cells(1).Value.ToString
        mtb_dias.Text = IIf(String.IsNullOrEmpty(dgv_Lista.CurrentRow.Cells(2).Value.ToString), 0, dgv_Lista.CurrentRow.Cells(2).Value)

        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_Lista.Rows.Count = 0 Then Exit Sub
        If dgv_Lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            Dim termsBL As New ClsOperaciones.TERMS_PAY
            Dim termsBE As New ClsEntidades.TERMS_PAY
            termsBE.ID = dgv_Lista.CurrentRow.Cells(0).Value.ToString
            termsBL.Delete(termsBE)
            termsBE = Nothing
            termsBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Listo!")
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
            If String.IsNullOrEmpty(txt_cod.Text) Then Exit Sub
            If GeneracionCodigo("M") = True Then txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub mtb_dias_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_dias.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
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

End Class