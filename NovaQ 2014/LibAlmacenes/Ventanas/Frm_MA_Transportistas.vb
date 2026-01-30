Imports System.Windows.Forms
Imports LibCobranzas

Public Class Frm_MA_Transportistas
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim TransportistaBl As ClsOperaciones.CARRIER
    Dim dtdetalles As DataTable
    Dim TransportistaEnt As ClsEntidades.CARRIER

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

    Private Sub frm_CX_MA_Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Datos()
        Botonera_Estado_Cambiar(False)
        Call Iniciar_Form()
        CONTROLES(TabPage2, False)
        cbo_estado.SelectedIndex = 0
    End Sub

    Private Sub Iniciar_Form()
        tc_tipos.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Datos()
        TransportistaBl = New ClsOperaciones.CARRIER
        dtdetalles = New DataTable("Transportista")
        dtv = New DataView
        dtdetalles = TransportistaBl.documentos_transportistas()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_lista.DataSource = dtv
            dgv_lista.AutoResizeColumns()
            dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            For i As Integer = 5 To dgv_lista.ColumnCount() - 1
                dgv_lista.Columns(i).Visible = False
            Next
            dgv_lista.Columns("LAST_NAME_CARRIER").Visible = True
            dgv_lista.Columns("LAST_NAME_CARRIER").HeaderText = "Apellidos Transportista"
            dgv_lista.Columns("LAST_NAME_CARRIER").DisplayIndex = 3

            STRorden = dgv_lista.Columns(0).Name & "+" & dgv_lista.Columns(1).Name & "+" & dgv_lista.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            TransportistaBl = Nothing
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
            Dim CORRELATIVOBL As New LibCompras.ClsTransacciones.CARRIER
            CORRELATIVOBL.NumeroCorrelativoCarrier()
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

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Limpiar_GroupBox(gb_datos)
        Call Limpiar_GroupBox(GroupBox1)
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        gb_datos.Enabled = bol_nuevo
        txt_codigo.Text = Numeracion()
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If txt_codigo.Text.Trim = "" Then
            MsgBox("Ingrese el codigo", MsgBoxStyle.Critical, "Sistemas")
            txt_codigo.Focus()
            Exit Sub
        ElseIf txt_dni.Text.Trim = "" Then
            MsgBox("Ingrese el N° de DNI", MsgBoxStyle.Critical, "Sistemas")
            txt_dni.Focus()
            Exit Sub
        ElseIf txt_nombre.Text.Trim = "" Then
            MsgBox("Ingrese el nombre", MsgBoxStyle.Critical, "Sistemas")
            txt_nombre.Focus()
            Exit Sub
        ElseIf txt_apellido.Text.Trim = "" Then
            MsgBox("Ingrese los Apellidos.", MsgBoxStyle.Critical, "Sistemas")
            txt_apellido.Focus()
            Exit Sub
        ElseIf txt_brevete.Text.Trim = "" Then
            MsgBox("Ingrese el N° de Brevete.", MsgBoxStyle.Critical, "Sistemas")
            txt_brevete.Focus()
            Exit Sub
        ElseIf txt_direccion.Text.Trim = "" Then
            MsgBox("Ingrese la direccion", MsgBoxStyle.Critical, "Sistemas")
            txt_direccion.Focus()
            Exit Sub
        ElseIf cbo_estado.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un estado.", MsgBoxStyle.Critical, "Sistemas")
            cbo_estado.Focus()
            Exit Sub
        End If

        Dim mensaje As String = String.Empty
        If bol_nuevo = True Then
            mensaje = "Se va a proceder a la creacion de un Transportista"
        Else
            mensaje = "Se va a proceder a la modificacion de un Transportista"
        End If
        If MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            
            TransportistaBl = New ClsOperaciones.CARRIER
            TransportistaEnt = New ClsEntidades.CARRIER
            With TransportistaEnt
                .ID = txt_codigo.Text
                .NAME_CARRIER = txt_nombre.Text
                .LAST_NAME_CARRIER = txt_apellido.Text
                .ADDR = txt_direccion.Text
                .PHONE = txt_telefono.Text
                .VAT_REGISTRATION = txt_ruc.Text
                .STATUS = IIf(cbo_estado.SelectedIndex = 0, "V", "I")
                .CREATE_DATE = Date.Now
                .NAME = txt_emp_razon_social.Text
                .VAT_REGISTRATION_COMP = txt_emp_ruc.Text
                .ADDR_COMP = txt_emp_direcc.Text
                .PHONE_COMP = txt_emp_telefono.Text
                .NUMBER_REGISTRATION = txt_placa.Text
                .NUMBER_LICENSE = txt_brevete.Text
                .MODEL_VEH = txt_modelo.Text
                .NUMBER_INSCRIP = txt_nro_incripcion.Text
                .NUMBER_DOCUMENT = txt_dni.Text
            End With
            If TransportistaBl.Guardar_Actualizar_Transportista(TransportistaEnt, bol_nuevo) Then
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
        Limpiar_GroupBox(GroupBox1)
        gb_datos.Enabled = True
        txt_codigo.Text = dgv_lista.CurrentRow.Cells("Codigo").Value.ToString
        txt_ruc.Text = dgv_lista.CurrentRow.Cells("Ruc").Value.ToString
        txt_dni.Text = dgv_lista.CurrentRow.Cells("NUMBER_DOCUMENT").Value.ToString
        txt_nombre.Text = dgv_lista.CurrentRow.Cells("Transportista").Value.ToString
        txt_apellido.Text = dgv_lista.CurrentRow.Cells("LAST_NAME_CARRIER").Value.ToString
        txt_direccion.Text = dgv_lista.CurrentRow.Cells("Direccion").Value.ToString
        txt_telefono.Text = dgv_lista.CurrentRow.Cells("PHONE").Value.ToString

        If String.IsNullOrEmpty(dgv_lista.CurrentRow.Cells("STATUS").Value.ToString) Then
            cbo_estado.SelectedIndex = -1
        Else
            If dgv_lista.CurrentRow.Cells("STATUS").Value.ToString = "V" Then
                cbo_estado.SelectedIndex = 0
            ElseIf dgv_lista.CurrentRow.Cells("STATUS").Value.ToString = "I" Then
                cbo_estado.SelectedIndex = 1
            End If
        End If
        txt_placa.Text = dgv_lista.CurrentRow.Cells("NUMBER_REGISTRATION").Value.ToString
        txt_brevete.Text = dgv_lista.CurrentRow.Cells("NUMBER_LICENSE").Value.ToString
        txt_modelo.Text = dgv_lista.CurrentRow.Cells("MODEL_VEH").Value.ToString
        txt_nro_incripcion.Text = dgv_lista.CurrentRow.Cells("NUMBER_INSCRIP").Value.ToString
        txt_emp_razon_social.Text = dgv_lista.CurrentRow.Cells("Name").Value.ToString
        txt_emp_direcc.Text = dgv_lista.CurrentRow.Cells("ADDR_COMP").Value.ToString
        txt_emp_ruc.Text = dgv_lista.CurrentRow.Cells("VAT_REGISTRATION_COMP").Value.ToString
        txt_emp_telefono.Text = dgv_lista.CurrentRow.Cells("PHONE_COMP").Value.ToString

        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_ruc.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            TransportistaBl = New ClsOperaciones.CARRIER
            Dim codigo As String = String.Empty
            codigo = dgv_lista.CurrentRow.Cells(0).Value.ToString
            If String.IsNullOrEmpty(codigo) Then Exit Sub
            If TransportistaBl.Eliminar_Transportista(codigo) Then
                MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Critical)
                Cargar_Datos()
            End If
            TransportistaBl = Nothing
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        Call Limpiar_GroupBox(gb_datos)
        Call Limpiar_GroupBox(GroupBox1)
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
 
    Private Sub txt_brevete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_brevete.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class