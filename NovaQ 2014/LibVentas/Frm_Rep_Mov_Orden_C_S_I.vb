Imports LibComunVar
Imports System.Windows.Forms
Public Class Frm_Rep_Mov_Orden_C_S_I
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim dtDatosCompany As DataTable
    Private Sub Frm_Rep_Mov_Orden_C_S_I_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Function Validaciones(ByRef FechaIni As String, ByRef FechaFin As String, ByRef Prod_Ini As String, ByRef Prod_Fin As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            FechaIni = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            FechaFin = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            'validacion
            If FechaIni = String.Empty Or FechaFin = String.Empty Then
                estado = False
                Exit Try
            End If

            If checkProductos.Checked = False Then
                If txt_cod_prod_inicial.Text = "" And txt_cod_prod_final.Text = "" Then
                    MessageBox.Show("Debe elegir un Producto para mostrar el Reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_cod_prod_inicial.Focus()
                    estado = False
                    Exit Try
                Else
                    Prod_Ini = txt_cod_prod_inicial.Text.Trim
                    Prod_Fin = txt_cod_prod_final.Text.Trim
                End If
            End If

        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_producto_inicial As String = String.Empty
        Dim Ref_producto_final As String = String.Empty
        '---Validaciones generales
        If Validaciones(Ref_fecIni, Ref_fecFin, Ref_producto_inicial, Ref_producto_final) = False Then Exit Sub
        Dim Flag_Todos As String = ""
        

        If checkProductos.Checked = True Then
            Flag_Todos = "SI"
        Else
            Flag_Todos = "NO"
        End If

        MostrarReporte(Ref_fecIni, Ref_fecFin, Flag_Todos, Ref_producto_inicial, Ref_producto_final)
    End Sub
    Private Sub MostrarReporte(ByVal FechaIni As String, ByVal FechaFin As String, _
                            ByVal TODOS As String, ByVal producto_inicial As String, ByVal producto_final As String)
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable
            dtDatosCompany = New DataTable
            Me.Cursor = Cursors.WaitCursor

            dtImprimir = reporteBL.EjecutarRep_Ordenes(FechaIni, FechaFin, TODOS, producto_inicial, producto_final)

            Dim Nombre_rep As String = ""
            Dim filtro_uno As String = ""
            Dim filtro_dos As String = ""

            Nombre_rep = "REP_MOV_ORDENES.rpt"
            filtro_uno = txt_des_prod_inicial.Text
            filtro_dos = txt_des_prod_final.Text

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte(Nombre_rep, dtImprimir, "", "", "INICIO;" & filtro_uno, "FIN;" & filtro_dos, "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub checkProductos_CheckedChanged(sender As Object, e As EventArgs) Handles checkProductos.CheckedChanged
        Dim reporteBL As New ClsBuscar
        Dim dtDetalleVendedor As New DataTable
        If checkProductos.Checked = True Then
            GroupBox2.Enabled = False
            reporteBL = New ClsBuscar
            dtDetalleVendedor = New DataTable
            Dim Cadena As String = String.Empty
            Dim CodigoV As String = String.Empty
            Cadena = "SELECT MIN(ID) AS [CODIGO]  FROM dbo.PART "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], DESCRIPTION AS [DESCRIPCION ]FROM dbo.PART  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txt_cod_prod_inicial.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txt_des_prod_inicial.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txt_cod_prod_inicial.Text = String.Empty
                    txt_des_prod_inicial.Text = String.Empty
                End If
            End If
            'If cboOpcionTipoDoc.Text <> "GS" Then
            '    If txtVendedorInicial.Text = String.Empty Then Exit Sub
            'End If
            Cadena = String.Empty
            Cadena = "SELECT MAX(ID) AS [CODIGO]  FROM dbo.PART "
            dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
            If dtDetalleVendedor.Rows.Count() <> 0 Then
                CodigoV = String.Empty
                CodigoV = dtDetalleVendedor.Rows(0).Item("CODIGO").ToString
                reporteBL = New ClsBuscar
                dtDetalleVendedor = New DataTable("DetallesProveedor")
                Cadena = String.Empty
                Cadena = "SELECT ID AS [CODIGO], DESCRIPTION AS [DESCRIPCION ]FROM dbo.PART  WHERE ID= '" & CodigoV & "'"
                dtDetalleVendedor = reporteBL.MostrandoDescripcion(Cadena)
                If dtDetalleVendedor.Rows.Count() <> 0 Then
                    txt_cod_prod_final.Text = dtDetalleVendedor.Rows(0).Item(0).ToString
                    txt_des_prod_final.Text = dtDetalleVendedor.Rows(0).Item(1).ToString
                Else
                    txt_cod_prod_final.Text = String.Empty
                    txt_des_prod_final.Text = String.Empty
                End If
            End If
        Else
            GroupBox2.Enabled = True
            txt_cod_prod_inicial.Text = String.Empty
            txt_des_prod_inicial.Text = String.Empty
            txt_cod_prod_final.Text = String.Empty
            txt_des_prod_final.Text = String.Empty
        End If
    End Sub

    Private Sub txt_cod_prod_inicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_prod_inicial.MouseDoubleClick
        Ayuda_Producto(txt_cod_prod_inicial, txt_des_prod_inicial)
    End Sub

    Private Sub txt_cod_prod_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prod_inicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Producto(txt_cod_prod_inicial, txt_des_prod_inicial)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_prod_inicial.Text = "" Then
                Ayuda_Producto(txt_cod_prod_inicial, txt_des_prod_inicial)
            Else
                txt_cod_prod_final.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Producto(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_PRODUCTOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Productos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_prod_final_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_prod_final.MouseDoubleClick
        Ayuda_Producto(txt_cod_prod_final, txt_des_prod_final)
    End Sub

    Private Sub txt_cod_prod_final_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_prod_final.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Producto(txt_cod_prod_final, txt_des_prod_final)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_prod_final.Text = "" Then
                Ayuda_Producto(txt_cod_prod_final, txt_des_prod_final)
            End If
        End If
    End Sub
End Class