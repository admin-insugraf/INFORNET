Imports System.Windows.Forms

Public Class frm_CX_MA_Lotes
    Dim bol_nuevo As Boolean = False
    Dim STRorden As String = String.Empty

    Dim LotesBl As ClsNegocio.LOT
    Dim AlmacenBl As ClsNegocio.WAREHOUSE
    Dim dtv As DataView
    Dim dtdetalles As DataTable
    Dim Fecha As String = String.Empty

    Private Sub Cargar_Almacen()
        Try
            AlmacenBl = New ClsNegocio.WAREHOUSE
            dtdetalles = New DataTable("Almacen")
            dtdetalles = AlmacenBl.get_Almacenes_Ayuda_Lotes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            If dtdetalles.Rows.Count() <> 0 Then
                chklstAlmacenes.Items.Clear()
                For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                    chklstAlmacenes.Items.Add(dtdetalles.Rows(i).Item("DESCRIPCION").ToString)
                Next
                chklstAlmacenes.SelectedIndex = 1
            End If
            AlmacenBl = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
  


    Private Sub frm_CX_MA_Lotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Data()
        Call Cargar_Almacen()
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
    End Sub


    Private Sub Cargar_Data()
        Me.Cursor = Cursors.WaitCursor
        LotesBl = New ClsNegocio.LOT
        dtdetalles = New DataTable("lOTES")
        dtv = New DataView
        dtdetalles = LotesBl.get_Lotes()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgvLotes.DataSource = dtv
            dgvLotes.Columns(0).Width = 70
            dgvLotes.Columns(0).HeaderText = "Almacen"
            dgvLotes.Columns(1).Width = 80
            dgvLotes.Columns(1).HeaderText = "Codigo"
            dgvLotes.Columns(2).Width = 400
            dgvLotes.Columns(2).HeaderText = "Descripcion"
            dgvLotes.Columns(3).Width = 100
            dgvLotes.Columns(3).HeaderText = "Lote"
            dgvLotes.Columns(0).Visible = False
            dgvLotes.Columns(4).Visible = False
            dgvLotes.Columns(5).Visible = False
            dgvLotes.Columns(6).Visible = False
            dgvLotes.Columns(7).Visible = False
            dgvLotes.Columns(8).Visible = False
            dgvLotes.Columns(9).Visible = False
            dgvLotes.Columns(10).Visible = False
            dgvLotes.Columns(11).Visible = False
            STRorden = dgvLotes.Columns(0).Name & "+" & dgvLotes.Columns(1).Name & "+" & dgvLotes.Columns(2).Name & "+" & dgvLotes.Columns(3).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        End If
        LotesBl = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ayuda_Articulos()
        'Dim frm_articulos As New frm_CX_LT_BuscaArticulos
        'frm_articulos.bol_OnlyLote = True
        'frm_articulos.ShowDialog()
        'If frm_articulos.bol_aceptar Then
        '    txt_cod.Text = frm_articulos.ls_cliente(0)
        '    txt_des_arti.Text = frm_articulos.ls_cliente(1)
        'End If
        'frm_articulos.Dispose()
        'txt_lote.Focus()

        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_PART_LOTES"
            frm.CadenaConsulta = sql
            frm.Titulo = "Productos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_des_arti.Text = frm.Data_Matriz.Rows(0).Item(1)
                txt_lote.Focus()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        bol_nuevo = True
        blank()
        txt_cod.Enabled = True
        txt_lote.Enabled = True
        txt_cod.Focus()
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


    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If txt_cod.Text.Trim = "" Then
            'Call Avisar("Debe seleccionar el Codigo del Articulo.")
            MsgBox("Debe ingresar el vencimiento para el Lote.", MsgBoxStyle.Exclamation)
            txt_cod.Focus()
            Exit Sub
        ElseIf txt_lote.Text.Trim = "" Then
            'Call Avisar("Debe ingresar el Codigo para el Lote.")
            MsgBox("Debe ingresar el vencimiento para el Lote.", MsgBoxStyle.Exclamation)
            txt_lote.Focus()
            Exit Sub
        End If

        If Strings.Left(Trim(dtp_fec_ven.Text), 1) = "/" Then
            'Call Avisar("Debe ingresar el vencimiento para el Lote.")
            MsgBox("Debe ingresar el vencimiento para el Lote.", MsgBoxStyle.Exclamation)
            dtp_fec_ven.Focus()
            Exit Sub
        End If

        If chklstAlmacenes.CheckedItems.Count() = 0 Then
            MsgBox("Debe seleccionar al menos un Almacen", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim idAlmacen As String = String.Empty
        Dim i As Integer = 0
        Dim loteBL As New ClsOperaciones.LOT
        Dim loteBE As ClsEntidades.LOT
        Dim ls_lotes As New List(Of ClsEntidades.LOT)

        Do While i <= chklstAlmacenes.CheckedItems.Count - 1
            idAlmacen = TraerCodigo(chklstAlmacenes.CheckedItems(i))
            loteBE = New ClsEntidades.LOT
            With loteBE
                .WHO_ID = idAlmacen
                .PART_ID = txt_cod.Text.Trim
                .LOT_ID = txt_lote.Text.Trim
                .QTY_ON_HAND = txt_can.Text.Trim
                If Strings.Left(Trim(dtp_fec_reg.Text), 1) = "/" Then
                    .MANUFACT_DATE = ""
                Else
                    .MANUFACT_DATE = Trim(dtp_fec_reg.Text)
                End If
                .CADUCATE_DATE = dtp_fec_ven.Text
                .COMMENT = txt_comentario.Text.Trim
                .INFORME_ENSAYO = txtensayo.Text.Trim
                .ACTA_MUESTREO = txtacta.Text.Trim
                .N_PROTOCOLO = txtprotocolo.Text.Trim
                .REGISTRO_SANITARIO = txtrs.Text.Trim
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
            End With
            ls_lotes.Add(loteBE)
            i = i + 1
        Loop

        If loteBL.Guardando_Update_Lotes(ls_lotes) Then
            MsgBox("Lotes grabados correctamente.", MsgBoxStyle.Information, "Sistemas")
            loteBE = Nothing
            loteBL = Nothing
            Call Cargar_Data()
            Call btn_cancelar_Click(sender, e)
        Else
            MsgBox("No se genero la operación.", MsgBoxStyle.Critical, "Sistemas")
            Exit Sub
        End If
        

        
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

    Private Sub ModoEdicion()
        Try
            Dim warehouse As String = dgvLotes.CurrentRow.Cells("WHO_ID").Value
            '  cboAlmacen.SelectedValue = warehouse
            txt_cod.Text = dgvLotes.CurrentRow.Cells("PART_ID").Value
            txt_des_arti.Text = dgvLotes.CurrentRow.Cells("DESCRIPTION").Value
            txt_lote.Text = IIf(String.IsNullOrEmpty(dgvLotes.CurrentRow.Cells("LOT_ID").Value.ToString), "", dgvLotes.CurrentRow.Cells("LOT_ID").Value)
            txt_can.Text = dgvLotes.CurrentRow.Cells("QTY_ON_HAND").Value
            dtp_fec_reg.Text = IIf(String.IsNullOrEmpty(dgvLotes.CurrentRow.Cells("MANUFACT_DATE").Value.ToString), "", dgvLotes.CurrentRow.Cells("MANUFACT_DATE").Value)
            dtp_fec_ven.Text = IIf(String.IsNullOrEmpty(dgvLotes.CurrentRow.Cells("CADUCATE_DATE").Value.ToString), "", dgvLotes.CurrentRow.Cells("CADUCATE_DATE").Value)
            txt_comentario.Text = IIf(IsDBNull(dgvLotes.CurrentRow.Cells("COMMENT").Value), "", dgvLotes.CurrentRow.Cells("COMMENT").Value)
            txtensayo.Text = IIf(IsDBNull(dgvLotes.CurrentRow.Cells("INFORME_ENSAYO").Value), "", dgvLotes.CurrentRow.Cells("INFORME_ENSAYO").Value)
            txtacta.Text = IIf(IsDBNull(dgvLotes.CurrentRow.Cells("ACTA_MUESTREO").Value), "", dgvLotes.CurrentRow.Cells("ACTA_MUESTREO").Value)
            txtprotocolo.Text = IIf(IsDBNull(dgvLotes.CurrentRow.Cells("N_PROTOCOLO").Value), "", dgvLotes.CurrentRow.Cells("N_PROTOCOLO").Value)
            txtrs.Text = IIf(IsDBNull(dgvLotes.CurrentRow.Cells("REGISTRO_SANITARIO").Value), "", dgvLotes.CurrentRow.Cells("REGISTRO_SANITARIO").Value)
            Dim clsLotBl As New ClsOperaciones.LOT
            Dim dtLotesAlm As New DataTable
            dtLotesAlm = clsLotBl.Lotes_Almacen(txt_cod.Text, txt_lote.Text)
            If dtLotesAlm.Rows.Count() <> 0 Then
                Dim i As Integer = 0
                For Each Array As DataRow In dtLotesAlm.Rows
                    Do While i <= chklstAlmacenes.Items.Count - 1
                        If TraerCodigo(chklstAlmacenes.Items(i)).Trim = Array("WHO_ID") Then
                            chklstAlmacenes.SetItemChecked(i, True)
                            Exit Do
                        End If
                        i = i + 1
                    Loop
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub blank()
        Try
            txt_cod.Text = String.Empty
            txt_des_arti.Text = String.Empty
            txt_lote.Text = String.Empty
            txt_can.Text = 0
            dtp_fec_reg.Text = ""
            dtp_fec_ven.Text = ""
            txt_comentario.Text = String.Empty
            txtensayo.Text = ""
            txtacta.Text = ""
            txtprotocolo.Text = ""
            txtrs.Text = ""
            ActivarCheck(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgvLotes.Rows.Count = 0 Then Exit Sub
        If dgvLotes.CurrentRow Is Nothing Then Exit Sub
        Botonera_Estado_Cambiar(True)
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        bol_nuevo = False
        txt_cod.Enabled = False
        txt_lote.Enabled = False
        blank()
        'Cargar_Almacen()
        ModoEdicion()
        dtp_fec_reg.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvLotes.Rows.Count = 0 Then Exit Sub
        If dgvLotes.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            LotesBl = New ClsNegocio.LOT
            Dim Almacen As String = String.Empty
            Dim Articulo As String = String.Empty
            Dim lote As String = String.Empty
            Almacen = dgvLotes.Item(0, dgvLotes.CurrentRow.Index).Value
            Articulo = dgvLotes.Item(1, dgvLotes.CurrentRow.Index).Value
            lote = dgvLotes.Item(3, dgvLotes.CurrentRow.Index).Value
            If String.IsNullOrEmpty(Almacen.ToString) Or String.IsNullOrEmpty(Articulo.ToString) Or String.IsNullOrEmpty(lote.ToString) Then Exit Sub
            If LotesBl.Eliminar(Almacen, Articulo, lote) = True Then
                MsgBox("Eliminado Correctamente", MsgBoxStyle.Information, "Mensaje-Sistemas")
            End If
            Cargar_Data()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        'Cargar_Data()
    End Sub
 

    Private Function VerificarCodigoLote(ByVal Almacen As String, ByVal Articulo As String, ByVal lote As String) As Boolean
        Dim estado As Boolean = True
        Try
            LotesBl = New ClsNegocio.LOT
            dtdetalles = New DataTable("Verificar_Lote")
            dtdetalles = LotesBl.VerificarCodigoLote(Almacen, Articulo, lote)
            If dtdetalles.Rows.Count() <> 0 Then
                MsgBox("El Codigo de Lote ingresado ya existe, verifique.!", MsgBoxStyle.Information)
                estado = False
                txt_lote.Focus()
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub txt_lote_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lote.KeyDown
        If e.KeyCode = Keys.Enter Then
            ''If cboAlmacen.SelectedValue.ToString = String.Empty Or txt_cod.Text = String.Empty Or txt_lote.Text = String.Empty Then Exit Sub
            '' If VerificarCodigoLote(cboAlmacen.SelectedValue.ToString, txt_cod.Text, txt_lote.Text) = False Then Exit Sub
        End If
    End Sub

    Private Sub cmb_almacen_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_cod.Focus()
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
        ' Referenciamos el control TabPage que ha sido seleccionado
        Dim tp As TabPage = e.TabPage
        ' Cancelamos la selección si el control
        ' se encuentra deshabilitado.
        e.Cancel = Not tp.Enabled
    End Sub

    Private Sub txt_comentario_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_comentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub

    Private Sub cboAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_lote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_can_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_can.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtp_fec_reg_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtp_fec_ven_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_comentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_comentario.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txt_comentario.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub


    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstAlmacenes.Items.Count - 1
                chklstAlmacenes.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkAlmacen_CheckedChanged(sender As Object, e As EventArgs) Handles checkAlmacen.CheckedChanged
        If checkAlmacen.Checked Then
            ActivarCheck(True)
            chklstAlmacenes.Enabled = False
        Else
            ActivarCheck(False)
            chklstAlmacenes.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Private Sub dtp_fec_reg_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles dtp_fec_reg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtp_fec_ven_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles dtp_fec_ven.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtensayo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtensayo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtacta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtacta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtprotocolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprotocolo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtrs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrs.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cod_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod.MouseDoubleClick
        Call Ayuda_Articulos()
    End Sub

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call Ayuda_Articulos()
        End If
    End Sub
End Class
