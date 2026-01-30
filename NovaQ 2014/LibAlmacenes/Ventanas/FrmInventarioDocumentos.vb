Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmInventarioDocumentos
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable

    Dim clsReportesBl As ClsReporteGenerales
    Dim dtDatosMov As DataTable
    Dim dtdocumAlmacen As DataTable
    Dim DT_NOM_EMPRESA As DataTable
    Dim crystalBL As LibReportes.ClsReporte
    Dim NOMBRE_EMPRESA As String

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UN ALMACEN)"
            dtAlmacen.Rows.InsertAt(row, 0)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacen.DataSource = dtAlmacen
                cboAlmacen.DisplayMember = "DESCRIPCION"
                cboAlmacen.ValueMember = "CODIGO"
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarTipoTransaccion(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "TRANS_SP_S_TRANSACTION_TYPE_TIPO"
            frmM.CadenaConsulta = sql
            frmM._Flag_Filtro = True
            If cboTipoMov.SelectedIndex = 1 Then
                frmM.Filtros1 = "I"
            ElseIf cboTipoMov.SelectedIndex = 2 Then
                frmM.Filtros1 = "S"
            End If
            frmM.Titulo = "Tipo Transaccion"
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoReporte(ByVal fechaINI As String, ByVal fechaFIN As String, ByVal Almacen As String, ByVal TipoMov As String, _
                                ByVal Mov_inicial As String, ByVal Mov_final As String)
        Try
            clsReportesBl = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            dtdocumAlmacen = New DataTable
            dtdocumAlmacen = clsReportesBl.Get_ImprimirReporte_Documentos_Almacen(fechaINI, fechaFIN, Almacen, TipoMov, Mov_inicial, Mov_final)
            DT_NOM_EMPRESA = New DataTable
            DT_NOM_EMPRESA = clsReportesBl.Get_Nombre_Empresa()
            If DT_NOM_EMPRESA.Rows.Count > 0 Then
                NOMBRE_EMPRESA = DT_NOM_EMPRESA.Rows(0).Item("REPORT_SCREEN").ToString
            Else
                NOMBRE_EMPRESA = ""
            End If
            Me.Cursor = Cursors.WaitCursor
            If dtdocumAlmacen.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Inv_doc_Docum_Almacen.rpt", dtdocumAlmacen, "", "", "", "@FECHA_INI;" & fechaINI, "@FECHA_FIN;" & fechaFIN, "@ALMACENES;" & cboAlmacen.Text, "EMPRESA;" & NOMBRE_EMPRESA)
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Validaciones(ByRef fechaINI As String, ByRef fechaFIN As String, _
                                  ByRef Almacen As String, ByRef TipoMov As String, _
                                  ByRef Mov_inicial As String, ByRef Mov_final As String) As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fechaFIN = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            'Seleccionando almacen
            If cboAlmacen.SelectedIndex = 0 Then
                estado = False
                MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
                cboAlmacen.Focus()
                Exit Try
            ElseIf cboAlmacen.SelectedIndex > 0 Then
                Almacen = cboAlmacen.SelectedValue().ToString()
            End If
            'Seleccionando TipoMov
            If cboTipoMov.SelectedIndex = 0 Then
                TipoMov = ""
            ElseIf cboTipoMov.SelectedIndex = 1 Then
                TipoMov = "I"
            ElseIf cboTipoMov.SelectedIndex = 2 Then
                TipoMov = "S"
            End If
            'Seleccionando Tipo transacciones
            If cboTipoMov.SelectedIndex <> 0 Then
                If txtInicioMov.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un Tipo de transaccion.", MsgBoxStyle.Information)
                    txtInicioMov.Focus()
                    Exit Try
                ElseIf txtFinMov.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un Tipo de transaccion.", MsgBoxStyle.Information)
                    txtFinMov.Focus()
                    Exit Try
                End If
                Mov_inicial = txtInicioMov.Text
                Mov_final = txtFinMov.Text
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub FrmInventarioDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoAlmacenes()
        cboTipoMov.SelectedIndex = 0
    End Sub

    Private Sub cboTipoMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMov.SelectedIndexChanged
        If cboTipoMov.SelectedIndex = 0 Then
            gbmovimiento.Enabled = False
            txtInicioMov.Text = String.Empty
            txtDescripcionInicioMov.Text = String.Empty
            txtFinMov.Text = String.Empty
            txtDescripcionfinMov.Text = String.Empty
            ''Mostrando data
            clsReportesBl = New ClsReporteGenerales
            dtDatosMov = New DataTable
            Dim Cadenaconsulta As String
            Cadenaconsulta = String.Empty
            Cadenaconsulta = "SELECT TOP 1 MOV_ID,NAME FROM TRANSACTION_TYPE  ORDER BY MOV_ID"

            dtDatosMov = clsReportesBl.Get_DatosMovimientos(Cadenaconsulta)
            If dtDatosMov.Rows.Count() <> 0 Then
                txtInicioMov.Text = dtDatosMov.Rows(0).Item(0).ToString
                txtDescripcionInicioMov.Text = dtDatosMov.Rows(0).Item(1).ToString

                clsReportesBl = New ClsReporteGenerales
                dtDatosMov = New DataTable
                Cadenaconsulta = String.Empty
                Cadenaconsulta = "SELECT TOP 1 MOV_ID,NAME FROM TRANSACTION_TYPE   ORDER BY MOV_ID DESC"

                dtDatosMov = clsReportesBl.Get_DatosMovimientos(Cadenaconsulta)
                If dtDatosMov.Rows.Count() <> 0 Then
                    txtFinMov.Text = dtDatosMov.Rows(0).Item(0).ToString
                    txtDescripcionfinMov.Text = dtDatosMov.Rows(0).Item(1).ToString
                End If
            End If
        Else
            gbmovimiento.Enabled = True
            txtInicioMov.Text = String.Empty
            txtDescripcionInicioMov.Text = String.Empty
            txtFinMov.Text = String.Empty
            txtDescripcionfinMov.Text = String.Empty
        End If
    End Sub

    Private Sub txtInicioMov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtInicioMov.MouseDoubleClick
        BuscarTipoTransaccion(txtInicioMov, txtDescripcionInicioMov)
    End Sub

    Private Sub txtFinMov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinMov.MouseDoubleClick
        BuscarTipoTransaccion(txtFinMov, txtDescripcionfinMov)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fechaINI As String = String.Empty
        Dim Ref_fechaFIN As String = String.Empty
        Dim Ref_Almacen As String = String.Empty
        Dim Ref_TipoMov As String = String.Empty
        Dim Ref_Mov_inicial As String = String.Empty
        Dim Ref_Mov_final As String = String.Empty
        If Validaciones(Ref_fechaINI, Ref_fechaFIN, Ref_Almacen, Ref_TipoMov, Ref_Mov_inicial, Ref_Mov_final) = False Then Exit Sub
        MostrandoReporte(Ref_fechaINI, Ref_fechaFIN, Ref_Almacen, Ref_TipoMov, Ref_Mov_inicial, Ref_Mov_final)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txtInicioMov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInicioMov.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtInicioMov_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            txtFinMov.Focus()
        End If
    End Sub

    Private Sub txtFinMov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFinMov.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call txtFinMov_MouseDoubleClick(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Enter Then
            btnMostrar.Select()
        End If
    End Sub
End Class