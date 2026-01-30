Imports System.Windows.Forms
Public Class FrmCierresModulos
    Dim bol_nuevo As Boolean = False

    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim transaccionesBL As ClsOperaciones.TRANSACTION_TYPE
    Dim transaccionesEnt As ClsEntidades.CIERRE_MODULOS

    Dim dtdetalles As DataTable
    Dim clsTipoProductoBl As ClsOperaciones.PART_TYPE
    Dim dtTipoProducto As DataTable
    Dim almacenBL As ClsOperaciones.WAREHOUSE
    Dim dtAlmacen As DataTable
    Private Sub FrmCierresModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        num_anio.Value = LibComunVar.ClsVarComun.FechaSistema.Year
        Call Cargar_Data(num_anio.Value)
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage2, False)
        num_anio.Focus()
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

    Private Sub Cargar_Data(ByVal _anio As Integer)
        transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
        dtdetalles = New DataTable
        dtv = New DataView
        dtdetalles = transaccionesBL.get_Cierre_Modulos(_anio)
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_transacciones.DataSource = dtv
            dgv_transacciones.AutoResizeColumns()
            dgv_transacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgv_transacciones.Columns(0).Visible = False
            dgv_transacciones.Columns(2).Visible = False

            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
        Else
            dgv_transacciones.DataSource = Nothing
        End If
        transaccionesBL = Nothing
    End Sub


    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Botonera_Estado_Cambiar(True)
        dtp_fecha.Value = LibComunVar.ClsVarComun.FechaSistema
        dtp_fecha.Enabled = True
        bol_nuevo = True
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)

        chk_proveedores.Checked = False
        chk_almacenes.Checked = False
        chk_clientes.Checked = False
        chk_caja_chica.Checked = False
        chk_manufactura.Checked = False
        chk_contabilidad.Checked = False
        chk_recursos_humanos.Checked = False
        chk_activo_fijo.Checked = False
        chk_cajabancos.Checked = False

        dtp_fecha.Focus()
    End Sub
    Private Function Validar_Cierre_Modulos(ByVal _mes As Integer, ByVal _anio As Integer) As Boolean
        Dim ESTADO As Boolean = True
        Try
            transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
            dtdetalles = New DataTable("Codigo")
            dtdetalles = transaccionesBL.Verificar_Cierre_Modulos(_mes, _anio)
            If dtdetalles.Rows.Count() <> 0 Then
                MsgBox("Ya se registro información" & Chr(13) & " con el mes y año seleccionado. Verifique!", MsgBoxStyle.Exclamation)
                ESTADO = False
                Exit Try
            End If
        Catch ex As Exception
            ESTADO = False
            MsgBox(ex.Message)
        End Try
        Return ESTADO
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim _pregunta_ As String = String.Empty
        If bol_nuevo = True Then
            If Validar_Cierre_Modulos(dtp_fecha.Value.Month, dtp_fecha.Value.Year) = False Then Exit Sub
        End If

        If bol_nuevo Then
            _pregunta_ = "Seguro de registrar los siguientes datos?"
        Else
            _pregunta_ = "Seguro de modificar los siguientes datos?"
        End If
        If Preguntar(_pregunta_) Then
            Dim transaccionBL As New ClsOperaciones.TRANSACTION_TYPE
            Dim transaccionBE As New ClsEntidades.CIERRE_MODULOS

            With transaccionBE
                If bol_nuevo Then
                    .ID_INTERNO = 0
                Else
                    .ID_INTERNO = dgv_transacciones.CurrentRow.Cells("ID_INTERNO").Value
                End If
                .ANIO = dtp_fecha.Value.Year
                .MES = dtp_fecha.Value.Month
                .PROVEEDORES = IIf(chk_proveedores.Checked, "C", "A")
                .ALMACENES = IIf(chk_almacenes.Checked, "C", "A")
                .CLIENTES = IIf(chk_clientes.Checked, "C", "A")
                .CAJA_BANCOS = IIf(chk_cajabancos.Checked, "C", "A")
                .MANUFACTURA = IIf(chk_manufactura.Checked, "C", "A")
                .CONTABILIDAD = IIf(chk_contabilidad.Checked, "C", "A")
                .RECURSOS_HUMANOS = IIf(chk_recursos_humanos.Checked, "C", "A")
                .ACTIVO_FIJO = IIf(chk_activo_fijo.Checked, "C", "A")
                .CAJA_CHICA = IIf(chk_caja_chica.Checked, "C", "A")
                .USER_CREATE = LibComunVar.ClsVarComun.USUARIO
                .PC_CREATE = Environment.MachineName

            End With

            If bol_nuevo Then
                transaccionBL.Insert_Cierre_Modulos(transaccionBE)
            Else
                transaccionBL.Update_Cierre_Modulos(transaccionBE)
            End If
            Call Cargar_Data(num_anio.Value)
            Call Avisar("Datos grabados correctamente.!")
            transaccionBE = Nothing
            transaccionBL = Nothing
            Call btn_cancelar_Click(sender, e)
        End If

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub

        dtp_fecha.Value = "01/" + dgv_transacciones.CurrentRow.Cells("codigo.mes").Value.ToString + "/" + dgv_transacciones.CurrentRow.Cells("Año").Value.ToString
        dtp_fecha.Enabled = False

        chk_proveedores.Checked = False
        chk_almacenes.Checked = False
        chk_clientes.Checked = False
        chk_cajabancos.Checked = False

        chk_manufactura.Checked = False
        chk_contabilidad.Checked = False
        chk_recursos_humanos.Checked = False
        chk_activo_fijo.Checked = False
        chk_caja_chica.Checked = False

        chk_proveedores.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Proveedores").Value.ToString = "CERRADO", True, False)
        chk_almacenes.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Almacenes").Value.ToString = "CERRADO", True, False)
        chk_clientes.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Clientes").Value.ToString = "CERRADO", True, False)
        chk_cajabancos.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Caja.Bancos").Value.ToString = "CERRADO", True, False)

        chk_manufactura.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Manufactura").Value.ToString = "CERRADO", True, False)
        chk_contabilidad.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Contabilidad").Value.ToString = "CERRADO", True, False)
        chk_recursos_humanos.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Recursos.Humanos").Value.ToString = "CERRADO", True, False)
        chk_activo_fijo.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Activo.Fijo").Value.ToString = "CERRADO", True, False)
        chk_caja_chica.Checked = IIf(dgv_transacciones.CurrentRow.Cells("Mod.Caja.Chica").Value.ToString = "CERRADO", True, False)

        bol_nuevo = False
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_transacciones.Rows.Count = 0 Then Exit Sub
        If dgv_transacciones.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar el registro seleccionado?") Then
            transaccionesBL = New ClsOperaciones.TRANSACTION_TYPE
            transaccionesEnt = New ClsEntidades.CIERRE_MODULOS
            transaccionesEnt.ID_INTERNO = dgv_transacciones.CurrentRow.Cells("ID_INTERNO").Value
            transaccionesBL.Delete_Cierre_Modulos(transaccionesEnt)
            transaccionesBL = Nothing
            transaccionesEnt = Nothing
            Call Cargar_Data(num_anio.Value)
            Call Avisar("Eliminado exitosamente!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        tc_tipos.SelectedIndex = 0
        Botonera_Estado_Cambiar(False)
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        Cargar_Data(num_anio.Value)
    End Sub



    Private Sub CONTROLES()
        Throw New NotImplementedException
    End Sub

    Private Sub tc_tipos_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc_tipos.Selecting
        Dim tp As TabPage = e.TabPage
        e.Cancel = Not tp.Enabled
    End Sub

    
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
            btn_refrescar.Enabled = False
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btn_Editar.Enabled = True
            btn_cancelar.Enabled = False
            btn_refrescar.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_refrescar.Click
        Call Cargar_Data(num_anio.Value)
    End Sub
End Class