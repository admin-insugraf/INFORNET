Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Public Class Frm_OP_PLanta_Bandeja_Programacion_Despachos_Prog_Recojo

    Dim _inicio As Boolean = False
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim _contador_despachos As Integer = 0
    Dim PedidoCabENT As ClsEntidades.MANTENIMIENTO_OP
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtdetalle_despachos As DataTable
    Dim flag_modificar_logistica As Boolean = False
    Dim MantenimientoOP_Corte As ClsEntidades.MANTENIMIENTO_OP_CORTE
    Dim Codigo_logistica As String = String.Empty

    Dim dtdetalle_despacho_correo As DataTable
    Dim _REMITENTE As String
    Dim _RECEPCIONANTE As String
    Dim _SERVER As String
    Dim _USUARIO As String
    Dim _PASSWORD As String
    Dim _ASUNTO As String
    Dim _TITULO As String
    Dim _PUERTO As String
    Dim _mensaje As String
    Dim _correo_vendedor As String
    Dim _vendedor_correo As String
    Dim _codigo_interno_op As Integer = 0

    Private Sub txt_cod_trans_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_trans.MouseDoubleClick
        Call Ayuda_Transportista(txt_cod_trans, txt_des_trans)
    End Sub

    Private Sub txt_cod_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_trans.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Transportista(txt_cod_trans, txt_des_trans)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_trans.Text = "" Then
                Ayuda_Transportista(txt_cod_trans, txt_des_trans)
            End If
        End If
    End Sub

    Private Sub txt_cod_vehiculo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_vehiculo.MouseDoubleClick
        Call Ayuda_Vehiculo(txt_cod_vehiculo, txt_des_vehiculo)
    End Sub

    Private Sub txt_cod_vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_vehiculo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vehiculo(txt_cod_vehiculo, txt_des_vehiculo)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_vehiculo.Text = "" Then
                Ayuda_Vehiculo(txt_cod_vehiculo, txt_des_vehiculo)
            End If
        End If
    End Sub

    Private Sub Ayuda_Transportista(ByVal cod As TextBox, ByVal des As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CARRIER_DESPACHOS_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Transportista"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Vehiculo(ByVal cod As TextBox, ByVal des As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_VEHICULO_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Vehiculo"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cliente.MouseDoubleClick
        Call Ayuda_CLiente_Proveedor(txt_cliente, txt_cliente)
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CLiente_Proveedor(txt_cliente, txt_cliente)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cliente.Text = "" Then
                Ayuda_CLiente_Proveedor(txt_cliente, txt_cliente)
            End If
        End If
    End Sub

    Private Sub Ayuda_CLiente_Proveedor(ByVal cod As TextBox, ByVal des As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CX_SP_S_CUSTOMER_VENDOR_AYU"
            frm.CadenaConsulta = sql
            frm.Titulo = "Clientes/Proveedores"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                cod.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_prog_despacho_final_Click(sender As Object, e As EventArgs) Handles btn_prog_despacho_final.Click
        If Validar_Programacion_Despacho() = False Then Exit Sub

        Try
            If MsgBox("Esta seguro de registrar el Recojo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                Dim dt_vendedores As DataTable
                dt_vendedores = New DataTable
                dt_vendedores.Columns.Add("VENDEDOR", Type.GetType("System.String")) '1
                dt_vendedores.Columns.Add("CORREO", Type.GetType("System.String")) '1
                Dim existe_vendedor As Boolean = False
                Dim opt_vendedor As String = ""

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                With PedidoCabENT
                    .ID = 0
                    .ITEM_DESPACHO = 0
                End With
                MantenimientoOP_Lista.Add(PedidoCabENT)
                    

                If clsPedidoBl.Guardar_Programacion_Recojo(MantenimientoOP_Lista, txt_cod_trans.Text, txt_des_vehiculo.Text,
                                                                     dtp_fecha_despacho.Value.ToString("dd/MM/yyyy"), txt_cliente.Text,
                                                                     txt_direccion.Text, txt_obs.Text, txt_des_trans.Text) Then
                    MsgBox("Programación de Recojo Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    Me.Cursor = Cursors.Default
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validar_Programacion_Despacho() As Boolean
        Try

            If txt_cod_trans.Text = "" Then
                MessageBox.Show("Debe elegir un Transportista.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txt_cod_trans.Focus()
                Return False
            End If

            If txt_cod_vehiculo.Text = "" Then
                MessageBox.Show("Debe elegir un Vehiculo.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txt_cod_vehiculo.Focus()
                Return False
            End If

            If txt_cliente.Text = "" Then
                MessageBox.Show("Debe elegir un Cliente/Proveedor.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txt_cliente.Focus()
                Return False
            End If


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class