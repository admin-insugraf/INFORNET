Public Class Frm_OP_Planta_Act_No_Programada
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim PedidoCabENT As ClsEntidades.MANTENIMIENTO_OP
    Dim Pedido_Det_HP As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
    Dim Mantenimiento_Parte_produccion As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION
    Dim dtdetalleArticuloPrincipal As DataTable

    Public usuario As String
    Public fecha As String
    Public maquina As String
    Public equipo As String
    Public turno As String
    Public termino_turno As String
    Private Sub Frm_OP_Planta_Act_No_Programada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_fecha_hp.Value = fecha
        txt_equipo.Text = equipo
        txt_nro_op.Text = ""
        txt_buenos.Text = ""
        txt_malos.Text = ""
        GenerarColummnaDataTable_Historial_Personal()
        Cargar_Motivos_Act_No_Programada()
        cbo_motivo.SelectedIndex = -1
        Lista_Historial_Personal()
    End Sub
    Private Sub Cargar_Motivos_Act_No_Programada()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbo_motivo.DataSource = monedaBL.get_Motivos_Act_No_Programada(maquina)
        cbo_motivo.ValueMember = "CODIGO"
        cbo_motivo.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub
    Private Sub Lista_Historial_Personal()
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dtdetalleArticuloPrincipal = clsPedidoBl.get_Parte_Produccion_Historial_Personal_Act_No_Programadas(maquina, fecha, turno)
            dgv_detalle_hp.DataSource = Nothing
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal
                Formato_Grillas()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub GenerarColummnaDataTable_Historial_Personal()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM_DET", Type.GetType("System.Int64")) '0
        dtdetalleArticuloPrincipal.Columns.Add("HORA", Type.GetType("System.String")) '1
        dtdetalleArticuloPrincipal.Columns.Add("MOTIVO_PAUSA", Type.GetType("System.String")) '2
        dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String")) '3
        dtdetalleArticuloPrincipal.Columns.Add("NUMERO_OP", Type.GetType("System.String")) '4
        dtdetalleArticuloPrincipal.Columns.Add("OBSERVACIONES", Type.GetType("System.String")) '5

        dgv_detalle_hp.DataSource = Nothing
        dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal

    End Sub

    Public Sub Formato_Grillas()
        If dtdetalleArticuloPrincipal.Rows.Count > 0 Then
            dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal
            dgv_detalle_hp.Columns(0).Visible = False
            dgv_detalle_hp.Columns(1).HeaderText = "Hora"
            dgv_detalle_hp.Columns(2).Visible = False
            dgv_detalle_hp.Columns(3).HeaderText = "Act. No Programada"
            dgv_detalle_hp.Columns(4).HeaderText = "N° O.P."
            dgv_detalle_hp.Columns(5).HeaderText = "Observaciones"
            dgv_detalle_hp.AutoResizeColumns()
            dgv_detalle_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            dgv_detalle_hp.DataSource = Nothing
        End If
    End Sub

    Private Sub btn_add_hp_Click(sender As Object, e As EventArgs) Handles btn_add_hp.Click
        Try
            If Validacion_HP() = False Then Exit Sub

            If Agregar_HP(0) Then
                txt_descripcion_hp.Text = ""
                cbo_motivo.SelectedIndex = -1
                txt_nro_op.Text = ""
                txt_buenos.Text = ""
                txt_malos.Text = ""
                chk_mantenimiento_equipo.Checked = False
                txt_descripcion_hp.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Agregar_HP(ByVal _item As Integer) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

            With Pedido_Det_HP
                .USER_ID = usuario
                .FECHA = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")
                .ITEM = _item
                .DESCRIPCION = txt_descripcion_hp.Text.Trim
                .NUMERO_OP = "Actividad No Programada"
                .EQUIPO_COD = maquina
                .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                .PC_ID_REGISTRO = Environment.MachineName
                .TURNO = turno
                .FECHA_TURNO = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")
                .NUMERO_OP_II = txt_nro_op.Text.Trim
                .MOTIVO_ACT_NO_PROGRAMADA = cbo_motivo.SelectedValue
                .PLIEGOS_BUENOS = txt_buenos.Text
                .PLIEGOS_MALOS = txt_malos.Text
            End With


            If clsPedidoBl.Guardar_Parte_Produccion_Historial_Personal_Act_No_Programda(Pedido_Det_HP) = False Then
                MsgBox("Registro de ACT. NO PROGRAMADA no se registro.", MsgBoxStyle.Exclamation, "Sistemas")
                Me.Cursor = Cursors.Default
                Return False
            Else
                Lista_Historial_Personal()
                Me.Cursor = Cursors.Default
                Return True
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Function Validacion_HP() As Boolean

        If cbo_motivo.SelectedIndex = -1 Then
            MsgBox("Debe elegir un motivo de la ACT. NO PROGRAMADA", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        If txt_descripcion_hp.Text.Trim = "" Then
            MsgBox("Debe digitar una descripción de la ACT. NO PROGRAMADA.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub txt_nro_op_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_op.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Lista_OPS(txt_nro_op)
        If e.KeyCode = Keys.Enter Then
            If txt_nro_op.Text = String.Empty Then
                Mostrando_Lista_OPS(txt_nro_op)
            Else
                txt_descripcion_hp.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nro_op_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_nro_op.MouseDoubleClick
        Mostrando_Lista_OPS(txt_nro_op)
    End Sub
    Private Sub Mostrando_Lista_OPS(ByVal texto_cod As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "MANTENIMIENTO_SP_S_LISTA_OP"
            frm.CadenaConsulta = sql
            frm.Titulo = "Seleccion de N° de O.P."
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_descripcion_hp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_descripcion_hp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_buenos.Focus()
        End If
    End Sub

    Private Sub txt_buenos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buenos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_malos.Focus()
        End If
    End Sub
End Class