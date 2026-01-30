Public Class Frm_OP_Planta_No_Actividad
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim PedidoCabENT As ClsEntidades.MANTENIMIENTO_OP
    Dim Pedido_Det_HP As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
    Dim Pedido_Det_TM As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO
    Dim Mantenimiento_Parte_produccion As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION
    Dim dtdetalleArticuloPrincipal As DataTable
    Private dtv_proveedor As DataView
    Private STRorden_proveedor As String
    Public usuario As String
    Public fecha As String
    Public maquina As String
    Public equipo As String
    Public turno As String
    Public turno_cerrado As String
    Dim dtTrabajos_Mantenimiento As DataTable
    Dim _agrega_trabajos_mantenimiento As Boolean = False
    Dim _inicio As Boolean = False
    Private Sub btn_add_hp_Click(sender As Object, e As EventArgs) Handles btn_add_hp.Click
        Try
            If Validacion_HP() = False Then Exit Sub

            If Agregar_HP(0) Then
                cbo_motivo.SelectedIndex = -1
                txt_descripcion_hp.Text = ""
                chk_mantenimiento_equipo.Checked = False
                cbo_motivo.Focus()
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
            Pedido_Det_TM = New ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO
            Dim Lista_Pedido_Det_TM As New List(Of ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO)

            With Pedido_Det_HP
                .USER_ID = usuario
                .FECHA = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")
                .ITEM = _item
                .DESCRIPCION = txt_descripcion_hp.Text.Trim
                .NUMERO_OP = IIf(chk_mantenimiento_equipo.Checked, "Mantenimiento Equipo", "Sin Trabajo")
                .EQUIPO_COD = maquina
                .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                .PC_ID_REGISTRO = Environment.MachineName
                .TURNO = turno
                .FECHA_TURNO = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")
                .MOTIVO_ACT_NO_PROGRAMADA = cbo_motivo.SelectedValue
            End With

            If dtTrabajos_Mantenimiento.Rows.Count > 0 Then
                For i As Integer = 0 To dtTrabajos_Mantenimiento.Rows.Count() - 1
                    Pedido_Det_TM = New ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO
                    With Pedido_Det_TM
                        .ITEM = dtTrabajos_Mantenimiento.Rows(i).Item("ITEM").ToString
                        .ID = dtTrabajos_Mantenimiento.Rows(i).Item("ID").ToString
                        .DESCRIPCION = dtTrabajos_Mantenimiento.Rows(i).Item("DESCRIPCION").ToString
                    End With
                    Lista_Pedido_Det_TM.Add(Pedido_Det_TM)
                Next
            End If
            

            If clsPedidoBl.Guardar_Parte_Produccion_Historial_Personal_Sin_Trabajo_detalle(Pedido_Det_HP, Lista_Pedido_Det_TM) = False Then
                MsgBox("Registro de SIN TRABAJO no se registro.", MsgBoxStyle.Exclamation, "Sistemas")
                Me.Cursor = Cursors.Default
                Return False
            Else
                GenerarColummnaDataTable_Trabajos_Mantenimiento()
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
            MsgBox("Debe elegir un motivo de SIN TRABAJO.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        If txt_descripcion_hp.Text.Trim = "" Then
            MsgBox("Debe digitar una observación de SIN TRABAJO.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub Frm_OP_Planta_No_Actividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarColummnaDataTable_Trabajos_Mantenimiento()
        chk_mantenimiento_equipo.Checked = False
        dtp_fecha_hp.Value = fecha
        txt_equipo.Text = equipo
        Cargar_Motivos_Sin_Trabajo()
        Lista_Historial_Personal()
        _inicio = True
    End Sub

    Private Sub Cargar_Motivos_Sin_Trabajo()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbo_motivo.DataSource = monedaBL.get_Motivos_Sin_Trabajo(maquina)
        cbo_motivo.ValueMember = "CODIGO"
        cbo_motivo.DisplayMember = "DESCRIPCION"
        cbo_motivo.SelectedIndex = -1
        monedaBL = Nothing
    End Sub

    Private Sub Lista_Historial_Personal()
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dtdetalleArticuloPrincipal = clsPedidoBl.get_Parte_Produccion_Historial_Personal_No_Operatividad(maquina, fecha, turno)
            dgv_detalle_hp.DataSource = Nothing
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal
                dgv_detalle_hp.Columns("ITEM_DET").Visible = False
                dgv_detalle_hp.AutoResizeColumns()
                dgv_detalle_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click

        Dim _ID As String = ""
        Dim _NAME As String = ""

        _ID = dgv_lista_proveedor.CurrentRow.Cells("CODIGO").Value
        _NAME = dgv_lista_proveedor.CurrentRow.Cells("DESCRIPCION").Value

        'Validaciones
        If dtTrabajos_Mantenimiento.Rows.Count() <> 0 Then
            Dim Resultado() As DataRow
            Resultado = dtTrabajos_Mantenimiento.Select("ID='" & _ID & "'", "")
            If Resultado.Count() <> 0 Then
                MsgBox("El Trabajo de Mantenimiento ya se registro anteriormente.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Dim row As DataRow = dtTrabajos_Mantenimiento.NewRow
        row("ITEM") = dtTrabajos_Mantenimiento.Rows.Count() + 1
        row("ID") = _ID
        row("DESCRIPCION") = _NAME
        dtTrabajos_Mantenimiento.Rows.Add(row)
        dtTrabajos_Mantenimiento.AcceptChanges()
        If dtTrabajos_Mantenimiento.Rows.Count() <> 0 Then
            configurarGrilla()
        End If
        dgv_lista_proveedor.Focus()
    End Sub

    Private Sub configurarGrilla()
        dgv_proveedor.DataSource = dtTrabajos_Mantenimiento
        dgv_proveedor.Columns(0).Width = 30
        dgv_proveedor.Columns(1).Width = 45
        dgv_proveedor.Columns(2).Width = 500
        dgv_proveedor.Columns("ITEM").HeaderText = "Item"
        dgv_proveedor.Columns("ID").HeaderText = "Codigo"
        dgv_proveedor.Columns("DESCRIPCION").HeaderText = "Descripción"

    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        Try
            If dgv_proveedor.CurrentRow Is Nothing Then
                dgv_proveedor.Focus()
            End If
            If dtTrabajos_Mantenimiento.Rows.Count = 0 Then Exit Sub
            Dim Codigo As String = String.Empty
            Codigo = dgv_proveedor.CurrentRow.Cells("ITEM").Value
            'Borrando los Datos
            For Each item As DataRow In dtTrabajos_Mantenimiento.Select("ITEM=" & Codigo)
                dtTrabajos_Mantenimiento.BeginInit()
                item.Delete()
                dtTrabajos_Mantenimiento.EndInit()
                dtTrabajos_Mantenimiento.AcceptChanges()
            Next
            RehacerCorrelativo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerCorrelativo()
        Dim i As Integer = 0
        For Each items As DataRow In dtTrabajos_Mantenimiento.Rows
            i += 1
            dtTrabajos_Mantenimiento.BeginInit()
            items("ITEM") = i
            dtTrabajos_Mantenimiento.EndInit()
            dtTrabajos_Mantenimiento.AcceptChanges()
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        _agrega_trabajos_mantenimiento = False
        dgv_proveedor.DataSource = Nothing
        gb_trabajaos_mantenimiento.Visible = False
        cbo_motivo.SelectedIndex = -1
    End Sub

    Private Sub Listado_Trabajos_Mantenimiento()
        Try
            Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
            Dim dtDocumentosProv As New DataTable
            dtv_proveedor = New DataView
            dtDocumentosProv = monedaBL.Get_Listado_Trabajos_Mantenimiento(maquina)
            dgv_lista_proveedor.DataSource = Nothing
            dtv_proveedor = dtDocumentosProv.DefaultView
            If dtDocumentosProv.Rows.Count() <> 0 Then
                dgv_lista_proveedor.DataSource = dtv_proveedor
                dgv_lista_proveedor.Columns("CODIGO").Width = 50
                dgv_lista_proveedor.Columns("DESCRIPCION").Width = 500

                dgv_lista_proveedor.Columns("CODIGO").HeaderText = "Codigo"
                dgv_lista_proveedor.Columns("DESCRIPCION").HeaderText = "Descripción"

                STRorden_proveedor = dgv_lista_proveedor.Columns("CODIGO").Name & "+" & dgv_lista_proveedor.Columns("DESCRIPCION").Name
                txtbusqueda.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If STRorden_proveedor = "" Then Exit Sub

        If txtbusqueda.Text = String.Empty Then
            dtv_proveedor.RowFilter = String.Empty
            Exit Sub
        Else
            dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
            If dtv_proveedor.Count() = 0 Then
                STRorden_proveedor = String.Empty
                STRorden_proveedor = dgv_lista_proveedor.Columns("CODIGO").Name
                dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                If dtv_proveedor.Count() = 0 Then
                    STRorden_proveedor = String.Empty
                    STRorden_proveedor = dgv_lista_proveedor.Columns("DESCRIPCION").Name
                    dtv_proveedor.RowFilter = STRorden_proveedor & " like '%" & txtbusqueda.Text & "%'"
                    If dtv_proveedor.Count() = 0 Then
                        STRorden_proveedor = String.Empty
                        STRorden_proveedor = dgv_lista_proveedor.Columns("CODIGO").Name & "+" & dgv_lista_proveedor.Columns("DESCRIPCION").Name
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub GenerarColummnaDataTable_Trabajos_Mantenimiento()
        Try
            dtTrabajos_Mantenimiento = New DataTable("Proveedores")
            dtTrabajos_Mantenimiento.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtTrabajos_Mantenimiento.Columns.Add("ID", Type.GetType("System.String"))
            dtTrabajos_Mantenimiento.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtTrabajos_Mantenimiento.PrimaryKey = New DataColumn() {dtTrabajos_Mantenimiento.Columns("ITEM")}
            dgv_proveedor.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_motivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_motivo.SelectedIndexChanged
        If _inicio = True Then
            If cbo_motivo.SelectedValue = "01" Then
                Listado_Trabajos_Mantenimiento()
                GenerarColummnaDataTable_Trabajos_Mantenimiento()
                gb_trabajaos_mantenimiento.Visible = True
            End If
        End If
        
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If dtTrabajos_Mantenimiento.Rows.Count = 0 Then
            MsgBox("Debe agregar un Trabajo de Mantenimiento.", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        _agrega_trabajos_mantenimiento = True
        gb_trabajaos_mantenimiento.Visible = False
        txt_descripcion_hp.Focus()
    End Sub
End Class