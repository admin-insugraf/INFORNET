Imports System.Windows.Forms
Imports LibCobranzas

Public Class Frm_MA_Empresa_Transporte
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim EmpresaBl As ClsOperaciones.EMPRESA_TRANSPORTE
    Dim dtdetalles As DataTable
    Dim EmpresaEnt As ClsEntidades.EMPRESA_TRANSPORTE

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable


    Public Sub Limpiar_GroupBox(gb As GroupBox)

        Dim controles As Control = gb
        For Each ctrl As Control In controles.Controls
            'si es Label continuar
            If TypeOf (ctrl) Is Label Then Continue For
            '---------
            If TypeOf (ctrl) Is TextBox Then
                '---validando Cajas de Texto
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btnDirecciones.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btnDirecciones.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
        End If
    End Sub

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
        EmpresaBl = New ClsOperaciones.EMPRESA_TRANSPORTE
        dtdetalles = New DataTable("Empresa_transporte")
        dtv = New DataView
        dtdetalles = EmpresaBl.documentos_Empresa_Transporte()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_lista.DataSource = dtv
            dgv_lista.AutoResizeColumns()
            dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            For i As Integer = 5 To dgv_lista.ColumnCount() - 1
                dgv_lista.Columns(i).Visible = False
            Next
            STRorden = dgv_lista.Columns(0).Name & "+" & dgv_lista.Columns(1).Name & "+" & dgv_lista.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            EmpresaBl = Nothing
        End If
    End Sub

    Private Sub Blank()
        'txt_cod.Text = String.Empty
        'txt_des.Text = String.Empty
        'txt_dir.Text = String.Empty
        'txt_telf.Text = String.Empty
        'txt_ruc.Text = String.Empty
        'txt_correo.Text = String.Empty
        'txtcodigoUbigeo.Text = String.Empty
        'txtDescripcionUbigeo.Text = String.Empty
        'dtpFechaIngreso.Value = Date.Now
        'txtcodigoCliente.Text = ""
        'txtdescripcioncliente.Text = ""
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

    Private Function Numeracion() As String
        Dim Correlativo As String = String.Empty
        Try
            Dim CORRELATIVOBL As New LibCompras.ClsTransacciones.EMPRESA_TRANSPORTE
            CORRELATIVOBL.NumeroCorrelativoEmpresa_transporte()
            If String.IsNullOrEmpty(CORRELATIVOBL.NumeroCorrelativo.ToString) Then
                Correlativo = "00"
            Else
                Correlativo = String.Format("{0:00}", CInt(CORRELATIVOBL.NumeroCorrelativo + 1))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Correlativo
    End Function

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Limpiar_GroupBox(gb_datos)
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        gb_datos.Enabled = bol_nuevo
        txt_codigo.Text = Numeracion()
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txt_razon_social.Select()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim mensaje As String = String.Empty
        If bol_nuevo = True Then
            mensaje = "Se va a proceder a la creacion de una empresa de transporte"
        Else
            mensaje = "Se va a proceder a la modificacion de una empresa de transporte"
        End If
        If MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txt_codigo.Text.Trim = "" Then
                MsgBox("Ingrese el codigo", MsgBoxStyle.Critical, "Sistemas")
                txt_codigo.Focus()
                Exit Sub
            ElseIf txt_razon_social.Text.Trim = "" Then
                MsgBox("Ingrese la razon social", MsgBoxStyle.Critical, "Sistemas")
                txt_razon_social.Focus()
                Exit Sub
            ElseIf txt_ruc.Text.Trim = "" Then
                MsgBox("Ingrese el ruc", MsgBoxStyle.Critical, "Sistemas")
                txt_ruc.Focus()
                Exit Sub
            End If
            EmpresaBl = New ClsOperaciones.EMPRESA_TRANSPORTE
            EmpresaEnt = New ClsEntidades.EMPRESA_TRANSPORTE
            With EmpresaEnt
                .CODIGO = txt_codigo.Text
                .RAZON_SOCIAL = txt_razon_social.Text
                .RUC = txt_ruc.Text
                .DIRECCION = txt_direccion.Text
                .TELEFONO = IIf(txt_telefono.Text = "", 0, txt_telefono.Text)
            End With
            If EmpresaBl.Guardar_Actualizar_Empresa_Transporte(EmpresaEnt, bol_nuevo) Then
                If bol_nuevo Then
                    MsgBox("Registro agregado Exitosamente.!", MsgBoxStyle.Information)
                Else
                    MsgBox("Registro modificado Exitosamente.!", MsgBoxStyle.Information)
                End If
            End If
            btn_cancelar_Click(sender, e)
            dgv_lista.Focus()
        End If

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        bol_nuevo = False
        Limpiar_GroupBox(gb_datos)
        gb_datos.Enabled = True
        txt_codigo.Text = dgv_lista.CurrentRow.Cells("Codigo").Value.ToString
        txt_razon_social.Text = dgv_lista.CurrentRow.Cells("Razon.Social").Value.ToString
        txt_ruc.Text = dgv_lista.CurrentRow.Cells("Ruc").Value.ToString
        txt_direccion.Text = dgv_lista.CurrentRow.Cells("Direccion").Value.ToString
        txt_telefono.Text = dgv_lista.CurrentRow.Cells("Telefono").Value.ToString
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_razon_social.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            EmpresaBl = New ClsOperaciones.EMPRESA_TRANSPORTE
            Dim codigo As String = String.Empty
            codigo = dgv_lista.CurrentRow.Cells(0).Value.ToString
            If String.IsNullOrEmpty(codigo) Then Exit Sub
            If EmpresaBl.Eliminar_Empresa_Transporte(codigo) Then
                MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Critical)
                Cargar_Datos()
            End If
            EmpresaBl = Nothing
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        Call Limpiar_GroupBox(gb_datos)
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

    Private Sub btnDirecciones_Click(sender As Object, e As EventArgs) Handles btnDirecciones.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        Dim codigo As String
        Dim razonSocial As String
        Dim ruc As String
        Dim direccion As String
        Dim telefono As String

        codigo = dgv_lista.CurrentRow.Cells("Codigo").Value.ToString
        razonSocial = dgv_lista.CurrentRow.Cells("Razon.Social").Value.ToString
        ruc = dgv_lista.CurrentRow.Cells("Ruc").Value.ToString
        direccion = dgv_lista.CurrentRow.Cells("Direccion").Value.ToString
        telefono = dgv_lista.CurrentRow.Cells("Telefono").Value.ToString


        Dim objListaSKU As New FrmTransportistaAct_Direcciones


        With objListaSKU
            .txtCodigoTransportista.Text = codigo
            .txtDireccionPTransportista.Text = direccion
            .txtRUCTransportista.Text = ruc

            .txtRazonSocialTransportista.Text = razonSocial

            .txtDireccionPTransportista.Text = direccion

            .ShowDialog()
        End With
    End Sub
End Class