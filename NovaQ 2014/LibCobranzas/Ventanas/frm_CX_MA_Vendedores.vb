Imports System.Windows.Forms

Public Class frm_CX_MA_Vendedores
    Dim bol_nuevo As Boolean = False
    Dim dtv As DataView
    Dim STRorden As String = String.Empty
    Dim vendedorBL As ClsOperaciones.SALES_REP
    Dim dtdetalles As DataTable
    Dim vendedorBE As ClsEntidades.SALES_REP

    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable

    Public Sub Botonera_Estado_Cambiar(ByVal Opcion As Boolean)
        If Opcion Then
            btn_Nuevo.Enabled = False
            btn_grabar.Enabled = True
            btn_eliminar.Enabled = False
            btnImprimir.Enabled = False
            btn_Editar.Enabled = False
            btn_cancelar.Enabled = True
        Else
            btn_Nuevo.Enabled = True
            btn_grabar.Enabled = False
            btn_eliminar.Enabled = True
            btnImprimir.Enabled = True
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
        vendedorBL = New ClsOperaciones.SALES_REP
        dtdetalles = New DataTable("Vendedor")
        dtv = New DataView
        dtdetalles = vendedorBL.getVendedores()
        If dtdetalles.Rows.Count() <> 0 Then
            dtv = dtdetalles.DefaultView
            dgv_lista.DataSource = dtv
            dgv_lista.Columns(0).Width = 80
            dgv_lista.Columns(1).Width = 250
            dgv_lista.Columns(2).Visible = False
            dgv_lista.Columns(3).Visible = False
            dgv_lista.Columns(4).Visible = False
            dgv_lista.Columns(5).Visible = False
            dgv_lista.Columns(6).Visible = False
            dgv_lista.Columns(7).Visible = False
            dgv_lista.Columns(8).Visible = False
            dgv_lista.Columns(9).Visible = False

            STRorden = dgv_lista.Columns(0).Name & "+" & dgv_lista.Columns(1).Name & "+" & dgv_lista.Columns(2).Name
            lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
            vendedorBL = Nothing
        End If
    End Sub

    Private Sub Ayuda_Departamento()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            'sql = "VEN_SP_S_SALES_REP_UBIGEO"
            sql = "CLI_SP_S_CUSTOMER_REP_UBIGEO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Departamentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoUbigeo.Text = frm.Data_Matriz.Rows(0).Item("COD_DEPT").ToString
                txtDescripcionUbigeo.Text = frm.Data_Matriz.Rows(0).Item("DEPARTAMENTO").ToString
                If String.IsNullOrEmpty(txtcodigoUbigeo.Text) Then
                    Exit Sub
                End If
                GenerarCodigoVendedor()
                gbdatosvendedor.Enabled = True
                txt_des.Focus()
            Else
                txtcodigoUbigeo.Text = String.Empty
                txtDescripcionUbigeo.Text = String.Empty
                Blank()
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Blank()
        txt_cod.Text = String.Empty
        txt_des.Text = String.Empty
        txt_dir.Text = String.Empty
        txt_telf.Text = String.Empty
        txt_ruc.Text = String.Empty
        txt_correo.Text = String.Empty
        txtcodigoUbigeo.Text = String.Empty
        txtDescripcionUbigeo.Text = String.Empty
        dtpFechaIngreso.Value = Date.Now
        txtcodigoCliente.Text = ""
        txtdescripcioncliente.Text = ""
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

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.click
        'Call Limpiar_GroupBox(gb_datos)
        Blank()
        Botonera_Estado_Cambiar(True)
        bol_nuevo = True
        txt_cod.Enabled = bol_nuevo
        gb_datos.Enabled = bol_nuevo
        dtpFechaIngreso.Enabled = True
        'tc_tipos.SelectedIndex = 1
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        txtcodigoUbigeo.Visible = True
        txtDescripcionUbigeo.Visible = True
        Label7.Visible = True
        txtcodigoUbigeo.Focus()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim mensaje As String = String.Empty
        If bol_nuevo = True Then
            mensaje = "Se va a proceder a la creacion de un Vendedor"
        Else
            mensaje = "Se va a proceder a la modificacion del Vendedor"
        End If

        If MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txt_cod.Text.Trim = "" Then
                Avisar("Ingrese el codigo")
                txt_cod.Focus()
                Exit Sub
            ElseIf txt_des.Text.Trim = "" Then
                Avisar("Ingrese la descripcion")
                txt_des.Focus()
                Exit Sub
            End If
            vendedorBL = New ClsOperaciones.SALES_REP
            vendedorBE = New ClsEntidades.SALES_REP
            With vendedorBE
                .ID = txt_cod.Text.Trim
                .NAME = txt_des.Text.Trim
                .ADDR = txt_dir.Text.Trim
                .PHONE = txt_telf.Text.Trim
                .EMAIL = txt_correo.Text.Trim
                .VAT_REGISTRATION = txt_ruc.Text.Trim
                .DATE_ADMISSION = dtpFechaIngreso.Value.ToString("dd/MM/yyyy")
                .STATUS = IIf(chk_estado.Checked = True, 1, 0)
                .CREATE_DATE = Date.Now()
                .USER = LibComunVar.ClsVarComun.USUARIO
                .COD_CLI = txtcodigoCliente.Text
            End With
            If bol_nuevo Then
                vendedorBL.Insert(vendedorBE)
                MsgBox("Transaccion realizada Exitosamente.!", MsgBoxStyle.Information)
            Else
                vendedorBL.Update(vendedorBE)
                MsgBox("Transaccion realizada Exitosamente.!", MsgBoxStyle.Information)
            End If
            btn_cancelar_Click(sender, e)
            dgv_lista.Focus()
        End If

    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        bol_nuevo = False
        Call Limpiar_GroupBox(gb_datos)
        gb_datos.Enabled = True
        '' dtpFechaIngreso.Enabled = False
        txt_cod.Text = dgv_lista.CurrentRow.Cells("Codigo").Value.ToString
        txt_des.Text = dgv_lista.CurrentRow.Cells("Descripcion").Value.ToString
        txt_dir.Text = dgv_lista.CurrentRow.Cells("Detalles").Value.ToString
        txt_telf.Text = dgv_lista.CurrentRow.Cells("PHONE").Value.ToString
        txt_correo.Text = dgv_lista.CurrentRow.Cells("EMAIL").Value.ToString
        txt_ruc.Text = dgv_lista.CurrentRow.Cells("VAT_REGISTRATION").Value.ToString
        dtpFechaIngreso.Value = IIf(String.IsNullOrEmpty(dgv_lista.CurrentRow.Cells("DATE_ADMISSION").Value.ToString), Date.Now, dgv_lista.CurrentRow.Cells("DATE_ADMISSION").Value)
        chk_estado.Checked = IIf(dgv_lista.CurrentRow.Cells("STATUS").Value.ToString = "1", True, False)
        txtcodigoCliente.Text = dgv_lista.CurrentRow.Cells("COD_CLI").Value.ToString
        txtdescripcioncliente.Text = dgv_lista.CurrentRow.Cells("DESCRIPCION_CLIENTE").Value.ToString
        txt_cod.Enabled = bol_nuevo
        'tc_tipos.SelectedIndex = 1
        CONTROLES(TabPage1, False)
        CONTROLES(TabPage2, True)
        Botonera_Estado_Cambiar(True)
        txtcodigoUbigeo.Visible = False
        txtDescripcionUbigeo.Visible = False
        Label7.Visible = False
        gbdatosvendedor.Enabled = True
        txt_des.Focus()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_lista.Rows.Count = 0 Then Exit Sub
        If dgv_lista.CurrentRow Is Nothing Then Exit Sub
        If Preguntar("Seguro de eliminar?") Then
            vendedorBL = New ClsOperaciones.SALES_REP
            Dim codigoV As String = String.Empty
            codigoV = dgv_lista.CurrentRow.Cells(0).Value.ToString
            If String.IsNullOrEmpty(codigoV) Then Exit Sub
            vendedorBL.EliminarVendedor(codigoV)
            vendedorBE = Nothing
            vendedorBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Listo!")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgv_lista.Focus()
        Botonera_Estado_Cambiar(False)
        gb_datos.Enabled = False
        CONTROLES(TabPage1, True)
        CONTROLES(TabPage2, False)
        txtcodigoUbigeo.Visible = False
        txtDescripcionUbigeo.Visible = False
        gbdatosvendedor.Enabled = False
        Label7.Visible = False
        Cargar_Datos()
    End Sub
 

    Private Sub txt_cod_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_des.KeyDown, txt_telf.KeyDown, txt_dir.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc.KeyDown
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

    Private Sub GenerarCodigoVendedor()
        Try
            vendedorBL = New ClsOperaciones.SALES_REP
            dtdetalles = New DataTable("CodigoVendedor")
            Dim Pass As String = String.Empty
            Pass = txtcodigoUbigeo.Text
            dtdetalles = vendedorBL.get_CodigoVendedor(Pass)
            If dtdetalles.Rows.Count() <> 0 Then
                txt_cod.Text = dtdetalles.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoUbigeo_DoubleClick(sender As Object, e As EventArgs) Handles txtcodigoUbigeo.DoubleClick
        Blank()
        Ayuda_Departamento()
    End Sub

    Private Sub txtcodigoUbigeo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoUbigeo.KeyDown
        If e.KeyCode = Keys.F1 Then
            txt_cod.Text = String.Empty
            Blank()
            Ayuda_Departamento()
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

    Private Sub txt_correo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_correo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_grabar_Click(sender, e)
        End If
    End Sub

    Private Sub imprimirVendedores(ByVal idalamacen As String, ByVal documentid As String, ByVal numerodocument As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Registro_Vendedores")

            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaRemision(idalamacen, documentid, numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen_tipos_Guia_remision.rpt", dtImprimir, "", "", "@almacen;" & idalamacen, "@tipo;" & documentid, "@numero;" & numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        pnlreporte.Visible = True
    End Sub

 
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            If dgv_lista.Rows.Count() = 0 Then Exit Sub
            If dgv_lista.CurrentRow Is Nothing Then Exit Sub
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable("Registro_Vendedores")
            Dim Estado As String = String.Empty

            If rb_activo.Checked Then
                Estado = "1"
            ElseIf rb_inactivo.Checked Then
                Estado = "0"
            Else
                Estado = ""
            End If
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporte_Registro_Vendedores(Estado)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Listado_Vendedores.rpt", dtImprimir, "", "", "")
            Else
                MsgBox("no hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        pnlreporte.Visible = False
    End Sub


    Private Sub Ayuda_Clientes(Optional ByVal _CodigoCliente As String = "")
        Try
            If _CodigoCliente = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "PED_SP_S_ORDER_USUARIOS"
                frm.CadenaConsulta = sql
                frm.Titulo = "Usuarios"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtcodigoCliente.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                    txtdescripcioncliente.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
                End If
                frm.Close()
            Else
                Dim clsFacturaBl = New ClsNegocio.RECEIVABLE
                Dim dtDetalleFact = New DataTable("Clientes")
                dtDetalleFact = clsFacturaBl.Get_ManualClientes(_CodigoCliente)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtcodigoCliente.Text = dtDetalleFact.Rows(0).Item(0).ToString
                    txtdescripcioncliente.Text = dtDetalleFact.Rows(0).Item(1).ToString
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtcodigoCliente.Text = String.Empty
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigoCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoCliente.MouseDoubleClick
        Ayuda_Clientes()
    End Sub

    Private Sub txtcodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ayuda_Clientes()
        End If
    End Sub
 
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class