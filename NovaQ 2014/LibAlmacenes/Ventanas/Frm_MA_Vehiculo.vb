Imports System.Windows.Forms
Imports LibCobranzas

Public Class Frm_MA_Vehiculo
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim vehiculoBl As ClsOperaciones.VEHICLE
    Dim dtdetalles As DataTable
    Dim VehiculoEnt As ClsEntidades.VEHICLE

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
    End Sub

    Private Sub Iniciar_Form()
        tc_tipos.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Datos()
        vehiculoBl = New ClsOperaciones.VEHICLE
        dtdetalles = New DataTable("Vehiculos")
        dtv = New DataView
        dtdetalles = vehiculoBl.documentos_Vehiculos()
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
            vehiculoBl = Nothing
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
            Dim CORRELATIVOBL As New LibCompras.ClsTransacciones.VEHICLE
            CORRELATIVOBL.NumeroCorrelativoVehicle()
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
        txt_placa.Select()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If txt_codigo.Text.Trim = "" Then
            MsgBox("Ingrese el codigo", MsgBoxStyle.Critical, "Sistemas")
            txt_codigo.Focus()
            Exit Sub
        ElseIf txt_placa.Text.Trim = "" Then
            MsgBox("Ingrese la placa", MsgBoxStyle.Critical, "Sistemas")
            txt_placa.Focus()
            Exit Sub
        ElseIf txt_marca.Text.Trim = "" Then
            MsgBox("Ingrese la marca", MsgBoxStyle.Critical, "Sistemas")
            txt_marca.Focus()
            Exit Sub
        End If

        Dim mensaje As String = String.Empty
        If bol_nuevo = True Then
            mensaje = "Se va a proceder a la creacion de un vehiculo"
        Else
            mensaje = "Se va a proceder a la modificacion de un vehiculo"
        End If
        If MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            vehiculoBl = New ClsOperaciones.VEHICLE
            VehiculoEnt = New ClsEntidades.VEHICLE
            With VehiculoEnt
                .CODIGO = txt_codigo.Text
                .PLACA = txt_placa.Text
                .MARCA = txt_marca.Text
                .MODELO = txt_modelo.Text
                .CAPACIDAD = IIf(txt_capacidad.Text = "", 0, txt_capacidad.Text)
            End With
            If vehiculoBl.Guardar_Actualizar_Vehiculo(VehiculoEnt, bol_nuevo) Then
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
        txt_placa.Text = dgv_lista.CurrentRow.Cells("Placa").Value.ToString
        txt_marca.Text = dgv_lista.CurrentRow.Cells("Marca").Value.ToString
        txt_modelo.Text = dgv_lista.CurrentRow.Cells("Modelo").Value.ToString
        txt_capacidad.Text = dgv_lista.CurrentRow.Cells("Capacidad").Value.ToString
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txt_placa.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            vehiculoBl = New ClsOperaciones.VEHICLE
            Dim codigo As String = String.Empty
            codigo = dgv_lista.CurrentRow.Cells(0).Value.ToString
            If String.IsNullOrEmpty(codigo) Then Exit Sub
            If vehiculoBl.Eliminar_Vehicle(codigo) Then
                MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Critical)
                Cargar_Datos()
            End If
            vehiculoBl = Nothing
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

    Private Sub txt_placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_placa.KeyPress
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