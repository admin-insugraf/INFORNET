Imports System.Windows.Forms

Public Class frm_CX_MA_TransaccionTipo
    Dim bol_nuevo As Boolean = False

    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim transaccionesBL As ClsOperaciones.TRANSACTION_TYPE
    Dim transaccionesEnt As ClsEntidades.TRANSACTION_TYPE

    Dim dtdetalles As DataTable
    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable
    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable

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

    Private Sub frm_CX_MA_TransaccionTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Data()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
        Call Cargar_Tipo()
        Cargar_Almacen()
        TiposArticulos()
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


    Private Sub Cargar_Almacen()
        Try
            almacenBL = New ClsOperaciones.WAREHOUSE
            dtAlmacen = New DataTable
            dtAlmacen = almacenBL.get_Almacenes_Ayuda(LibComunVar.ClsVarComun.AccesoAlmacenes)
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(-SELECCIONE-)"
            dtAlmacen.Rows.InsertAt(row, 0)
            CboAlmacen.DataSource = dtAlmacen
            CboAlmacen.DisplayMember = "DESCRIPCION"
            CboAlmacen.ValueMember = "CODIGO"
            almacenBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TiposArticulos()
        Try
            clsTipoProductoBl = New ClsOperaciones.PART_TYPE
            dtTipoProducto = New DataTable
            dtTipoProducto = clsTipoProductoBl.get_TipoArticulo()
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtTipoProducto.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE)"
            dtTipoProducto.Rows.InsertAt(row, 0)
            If dtTipoProducto.Rows.Count() <> 0 Then
                Me.cboTipoArticulo.DataSource = dtTipoProducto
                Me.cboTipoArticulo.DisplayMember = "DESCRIPCION"
                Me.cboTipoArticulo.ValueMember = "CODIGO"
            Else
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function GeneracionCodigo() As Boolean
        Dim ESTADO As Boolean = True
        Try
            transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
            dtdetalles = New DataTable("Codigo")
            Dim TipoMov As String = String.Empty
            Dim codigo As String = String.Empty
            codigo = txt_cod.Text.Trim
            TipoMov = IIf(cmb_tipo.SelectedIndex = 0, "I", "S")
            dtdetalles = transaccionesBL.VerificarCodigoTransacciones(TipoMov, codigo)
                If dtdetalles.Rows.Count() <> 0 Then
                MsgBox("Ya se registro una Transaccion con el codigo ingresado.", MsgBoxStyle.Information)
                    ESTADO = False
                    txt_cod.Focus()
                    Exit Try
                End If
        Catch ex As Exception
            ESTADO = False
            MsgBox(ex.Message)
        End Try
        Return ESTADO
    End Function

    Private Sub Cargar_Data()
        transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
        dtdetalles = New DataTable
        dtv = New DataView
        dtdetalles = transaccionesBL.get_Transacciones
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_transacciones.DataSource = dtv
            dgv_transacciones.Columns(0).Width = 70
            dgv_transacciones.Columns(0).HeaderText = "Tipo"
            dgv_transacciones.Columns(1).Width = 90
            dgv_transacciones.Columns(1).HeaderText = "Codigo"
            dgv_transacciones.Columns(2).Width = 230
            dgv_transacciones.Columns(2).HeaderText = "Descripcion"
            dgv_transacciones.Columns(3).Visible = False
            dgv_transacciones.Columns(4).Visible = False
            dgv_transacciones.Columns(5).Visible = False
            dgv_transacciones.Columns(6).Visible = False
            dgv_transacciones.Columns(7).Visible = False
            dgv_transacciones.Columns(8).Visible = False
            dgv_transacciones.Columns(9).Visible = False
            dgv_transacciones.Columns(10).Visible = False
            dgv_transacciones.Columns(11).Visible = False
            dgv_transacciones.Columns(12).Visible = False
            dgv_transacciones.Columns(13).Visible = False
            dgv_transacciones.Columns(14).Visible = False
            dgv_transacciones.Columns(15).Visible = False
            dgv_transacciones.Columns(16).Visible = False
            dgv_transacciones.Columns(17).Visible = False
            dgv_transacciones.Columns(18).Visible = False
            dgv_transacciones.Columns(19).Visible = False
            STRorden = dgv_transacciones.Columns(0).Name & "+" & dgv_transacciones.Columns(1).Name & "+" & dgv_transacciones.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        transaccionesBL = Nothing
    End Sub

    Private Sub Cargar_Tipo()
        cmb_tipo.Items.Clear()
        cmb_tipo.Items.Add("I - Ingreso")
        cmb_tipo.Items.Add("S - Salida")
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        txt_cod.Text = String.Empty
        txt_des.Text = String.Empty
        Limpiar_GroupBox(gbCaracteristicas)
        gb_data.Enabled = True
        bol_nuevo = True
        cmb_tipo.SelectedIndex = 0
        CboAlmacen.SelectedIndex = 0
        cboTipoArticulo.SelectedIndex = 0
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        cmb_tipo.Enabled = True
        txt_cod.Enabled = True
        txt_cod.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_cod.Text.Trim = "" Then
            Call Avisar("Ingrese el codigo")
            txt_cod.Focus()
            Exit Sub
        Else
            If bol_nuevo = True Then
                If GeneracionCodigo() = False Then Exit Sub
            End If
        End If
        If txt_des.Text.Trim = "" Then
            Call Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        If chk_AlmDestino.Checked = True Then
            If CboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un almacen.", MsgBoxStyle.Information)
                CboAlmacen.Focus()
                Exit Sub
            End If
        End If
        If chk_TipoArticulo.Checked = True Then
            If cboTipoArticulo.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un tipo de Articulo.", MsgBoxStyle.Information)
                cboTipoArticulo.Focus()
                Exit Sub
            End If
        End If
        If chk_Count.Checked = True Then
            If txt_count.Text = String.Empty Then
                MsgBox("Debe ingresar una cantidad.", MsgBoxStyle.Information)
                txt_count.Focus()
                Exit Sub
            End If
        End If


        Dim transaccionBL As New ClsOperaciones.TRANSACTION_TYPE
        Dim transaccionBE As New ClsEntidades.TRANSACTION_TYPE

        With transaccionBE
            .TYPE_ID = IIf(cmb_tipo.SelectedIndex = 0, "I", "S")
            .MOV_ID = txt_cod.Text.Trim
            .NAME = txt_des.Text.Trim
            .IS_VALUED = IIf(chk_valorizado.Checked, "V", "F")
            .IS_VENDOR = IIf(chk_prove.Checked, "S", "N")
            .IS_DOC_REF = IIf(chk_documento.Checked, "S", "N")
            .IS_AUTHORIZED = IIf(chk_autorizado.Checked, "S", "N")
            .IS_CCOST = IIf(chk_centrocosto.Checked, "S", "N")
            .IS_ORDER_PURCHASE = IIf(chk_ordencompra.Checked, "S", "N")
            .IS_COMMENT = IIf(chk_comentario.Checked, "S", "N")
            .IS_WHO = IIf(chk_almacen.Checked, "S", "N")
            .IS_CUSTOMER = IIf(chk_cliente.Checked, "S", "N")
            .IS_ORDER_MANUFACT = IIf(chk_ordenprod.Checked, "S", "N")
            .IS_ACCOUNT = IIf(chk_Account.Checked, "S", "N")
            .VAR_COUNT = 0
            .WHO_ID = CboAlmacen.SelectedValue.ToString
            .IS_GUIA_ANALISIS = IIf(chk_GuiaAnalisis.Checked, "S", "N")
            .WHO_ID_PART_TYPE = IIf(cboTipoArticulo.SelectedIndex = -1, "", cboTipoArticulo.SelectedValue.ToString)
            .LOTE_A_FABRICAR = IIf(chk_lote_F.Checked, "S", "N")
            .IS_COD_ARTICULO = IIf(chkcodarticulo.Checked, "S", "N")
            .IS_GUIA_REMISION = IIf(chk_GuiaRemision.Checked, "S", "N")
        End With

        If bol_nuevo Then
            transaccionBL.Insert(transaccionBE)
        Else
            transaccionBL.Update(transaccionBE)
        End If
        Call Cargar_Data()
        Call Avisar("Datos grabados correctamente.!")
        transaccionBE = Nothing
        transaccionBL = Nothing
        Call btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub
        cmb_tipo.SelectedIndex = IIf(dgv_transacciones.CurrentRow.Cells("TYPE_ID").Value.ToString = "I", 0, 1)
        txt_cod.Text = dgv_transacciones.CurrentRow.Cells("MOV_ID").Value
        txt_des.Text = dgv_transacciones.CurrentRow.Cells("Name").Value
        chk_valorizado.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_VALUED").Value.ToString = "V", True, False)
        chk_prove.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_VENDOR").Value.ToString = "S", True, False)
        chk_documento.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_DOC_REF").Value.ToString = "S", True, False)
        chk_autorizado.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_AUTHORIZED").Value.ToString = "S", True, False)
        chk_centrocosto.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_CCOST").Value.ToString = "S", True, False)
        chk_ordencompra.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_ORDER_PURCHASE").Value.ToString = "S", True, False)
        chk_comentario.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_COMMENT").Value.ToString = "S", True, False)
        chk_almacen.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_WHO").Value.ToString = "S", True, False)
        chk_cliente.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_CUSTOMER").Value.ToString = "S", True, False)
        chk_ordenprod.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_ORDER_MANUFACT").Value.ToString = "S", True, False)
        chk_Account.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_ACCOUNT").Value.ToString = "S", True, False)
        chk_GuiaAnalisis.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_GUIA_ANALISIS").Value.ToString = "S", True, False)
        chk_lote_F.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_LOTE_A_FABRICAR").Value.ToString = "S", True, False)
        chkcodarticulo.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_COD_ARTICULO").Value.ToString = "S", True, False)
        chk_GuiaRemision.Checked = IIf(dgv_transacciones.CurrentRow.Cells("IS_GUIA_REMISION").Value.ToString = "S", True, False)

        If String.IsNullOrEmpty(dgv_transacciones.CurrentRow.Cells("WHO_ID").Value.ToString) Then
            chk_AlmDestino.Checked = False
        Else
            chk_AlmDestino.Checked = True
            CboAlmacen.SelectedValue = dgv_transacciones.CurrentRow.Cells("WHO_ID").Value.ToString
        End If
        If String.IsNullOrEmpty(dgv_transacciones.CurrentRow.Cells("WHO_ID_PART_TYPE").Value.ToString) Then
            chk_TipoArticulo.Checked = False
        Else
            chk_TipoArticulo.Checked = True
            cboTipoArticulo.SelectedValue = dgv_transacciones.CurrentRow.Cells("WHO_ID_PART_TYPE").Value.ToString
        End If

        If String.IsNullOrEmpty(dgv_transacciones.CurrentRow.Cells("VAR_COUNT").Value.ToString) Then
            txt_count.Enabled = True
        Else
            txt_count.Enabled = True
            txt_count.Text = dgv_transacciones.CurrentRow.Cells("VAR_COUNT").Value.ToString
        End If

        bol_nuevo = False
        cmb_tipo.Enabled = False
        txt_cod.Enabled = False
        gb_data.Enabled = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txt_cod.Enabled = False
        txt_des.Focus()
        Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
            transaccionesEnt = New ClsEntidades.TRANSACTION_TYPE
            transaccionesEnt.TYPE_ID = dgv_transacciones.CurrentRow.Cells(0).Value.ToString
            transaccionesEnt.MOV_ID = dgv_transacciones.CurrentRow.Cells(1).Value.ToString
            transaccionesBL.Delete(transaccionesEnt)
            transaccionesBL = Nothing
            transaccionesEnt = Nothing
            Call Cargar_Data()
            Call Avisar("Listo!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_tipos.SelectedIndex = 0
        gb_data.Enabled = False
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        Cargar_Data()
    End Sub

 

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(txt_cod.Text) Then Exit Sub
            If GeneracionCodigo() = True Then txt_des.Focus()
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar.Select()
        End If
    End Sub

    Private Sub cmb_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
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
    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub
 
    Private Sub chk_AlmDestino_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AlmDestino.CheckedChanged
        If chk_AlmDestino.Checked = True Then
            CboAlmacen.Enabled = True
        Else
            CboAlmacen.Enabled = False
            CboAlmacen.SelectedIndex = 0
        End If
    End Sub
 
    Private Sub chk_TipoArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_TipoArticulo.CheckedChanged
        If chk_TipoArticulo.Checked = True Then
            cboTipoArticulo.Enabled = True
        Else
            cboTipoArticulo.Enabled = False
            cboTipoArticulo.SelectedIndex = 0
        End If
    End Sub

    Private Sub chk_Count_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Count.CheckedChanged
        If chk_Count.Checked = True Then
            txt_count.Enabled = True
            txt_count.Text = String.Empty
        Else
            txt_count.Enabled = False
            txt_count.Text = String.Empty
        End If
    End Sub

    Private Sub txt_cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_cod.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_count_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_count.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub
End Class