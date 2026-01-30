Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes
Public Class Frm_Reporte_Diario_ModoPago
    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Private Sub Frm_Reporte_Diario_ModoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        Cargar_Documentos()
    End Sub

    Private Sub Cargar_Documentos()
        Try

            Dim documentosBL As LibCobranzas.ClsOperaciones.DOCUMENT_TYPE
            documentosBL = New LibCobranzas.ClsOperaciones.DOCUMENT_TYPE
            Dim dtAlmacen As DataTable

            dtAlmacen = New DataTable
            dtAlmacen = documentosBL.get_Series()
            chk_list_series.Items.Clear()
            If dtAlmacen.Rows.Count() <> 0 Then
                For i As Integer = 0 To dtAlmacen.Rows.Count() - 1
                    chk_list_series.Items.Add(dtAlmacen.Rows(i).Item("DES").ToString)
                Next
            End If

            dtImprimir = New DataTable
            dtImprimir = documentosBL.get_Forma_Pago()
            If dtImprimir.Rows.Count() <> 0 Then
                chk_list_forma_pago.Items.Clear()
                Dim Documentos(dtImprimir.Rows.Count - 1) As String

                For I As Integer = 0 To dtImprimir.Rows.Count() - 1
                    Documentos(I) = dtImprimir.Rows(I).Item("CODIGO").ToString & ":" & dtImprimir.Rows(I).Item("DESCRIPCION").ToString
                Next

                For i As Integer = 0 To Documentos.Count() - 1
                    chk_list_forma_pago.Items.Add(Documentos(i))
                Next

            End If

            dtImprimir = New DataTable
            dtImprimir = documentosBL.get_Vendedor()
            If dtImprimir.Rows.Count() <> 0 Then
                chk_list_vendedor.Items.Clear()
                Dim Documentos(dtImprimir.Rows.Count - 1) As String

                For I As Integer = 0 To dtImprimir.Rows.Count() - 1
                    Documentos(I) = dtImprimir.Rows(I).Item("CODIGO").ToString & ":" & dtImprimir.Rows(I).Item("DESCRIPCION").ToString
                Next

                For i As Integer = 0 To Documentos.Count() - 1
                    chk_list_vendedor.Items.Add(Documentos(i))
                Next
            End If
            
            documentosBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If Validaciones() = False Then Exit Sub
        ImprimirReporte()
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
            End If
            If CheckBox1.Checked = False Then
                If txt_cod_estado.Text = String.Empty Then
                    MsgBox("Debe seleccionar un Modo de Pago.", MsgBoxStyle.Exclamation)
                    txt_cod_estado.Focus()
                    estado = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Private Sub ImprimirReporte()

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dtDatosCompany As DataTable
            'NombreStore = "DOC_PENDIENTES_X_CLIENTES"
            dtImprimir = New DataTable("Reporte6")
            reporteBL = New ClsBuscar
            crystalBL = New ClsReporte

            Dim idForma_Pago As String = String.Empty
            Dim idSerie As String = String.Empty
            Dim idVendedor As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chk_list_forma_pago.CheckedItems.Count - 1
                idForma_Pago = idForma_Pago & """" & TraerCodigo(chk_list_forma_pago.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idForma_Pago.Length() <> 0 Then
                idForma_Pago = Mid(idForma_Pago, 1, idForma_Pago.Length - 1)
            End If
            If idForma_Pago = String.Empty Then
                MsgBox("Debe seleccionar al menos una Forma de Pago.", MsgBoxStyle.Exclamation)
                chk_list_forma_pago.Focus()
                Exit Sub
            End If

            i = 0
            Do While i <= chk_list_series.CheckedItems.Count - 1
                idSerie = idSerie & """" & (chk_list_series.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idSerie.Length() <> 0 Then
                idSerie = Mid(idSerie, 1, idSerie.Length - 1)
            End If
            If idSerie = String.Empty Then
                MsgBox("Debe seleccionar al menos una Serie.", MsgBoxStyle.Exclamation)
                chk_list_series.Focus()
                Exit Sub
            End If

            i = 0
            Do While i <= chk_list_vendedor.CheckedItems.Count - 1
                idVendedor = idVendedor & """" & TraerCodigo(chk_list_vendedor.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idVendedor.Length() <> 0 Then
                idVendedor = Mid(idVendedor, 1, idVendedor.Length - 1)
            End If
            If idVendedor = String.Empty Then
                MsgBox("Debe seleccionar al menos un Vendedor.", MsgBoxStyle.Exclamation)
                chk_list_vendedor.Focus()
                Exit Sub
            End If

            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()

            dtImprimir = reporteBL.Get_Reporte_Modo_Pago(dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), txt_cod_estado.Text.Trim, _
                                                         idForma_Pago, idSerie, idVendedor)
            If dtImprimir.Rows.Count() <> 0 Then
                If rdb_detallado.Checked Then
                    crystalBL.Muestra_Reporte("REP_MODO_PAGO.rpt", dtImprimir, "", "", _
                                          "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@MODO_PAGO;" & txt_cod_estado.Text.Trim, _
                                          "@FORMA_PAGO;" & idForma_Pago, _
                                          "@SERIE;" & idSerie, _
                                          "@VENDEDOR;" & idVendedor, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "fecha_inicial;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "fecha_final;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))
                ElseIf rdb_resumido.Checked Then
                    crystalBL.Muestra_Reporte("REP_MODO_PAGO_RESUMIDO.rpt", dtImprimir, "", "", _
                                          "@FECHA_INI;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "@FECHA_FIN;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"), _
                                          "@MODO_PAGO;" & txt_cod_estado.Text.Trim, _
                                          "@FORMA_PAGO;" & idForma_Pago, _
                                          "@SERIE;" & idSerie, _
                                          "@VENDEDOR;" & idVendedor, _
                                          "RUC;" & dtDatosCompany.Rows(0).Item("VAT_REGISTRATION").ToString, _
                                          "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString, _
                                          "fecha_inicial;" & dtpfechaInicio.Value.ToString("dd/MM/yyyy"), _
                                          "fecha_final;" & dtpfechaFin.Value.ToString("dd/MM/yyyy"))
                End If
                
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt_cod_estado_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_estado.MouseDoubleClick
        Ayuda_Estado()
    End Sub

    Private Sub txt_cod_estado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_estado.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Estado()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_estado.Text.Trim = "" Then
                Ayuda_Estado()
            Else
                txt_cod_estado.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Estado()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "SAL_HLP_FIND_MODO_COBRO"
            frm.CadenaConsulta = sql
            frm.Titulo = "MODO DE PAGO"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_estado.Text = frm.Data_Matriz.Rows(0).Item(0)
                txt_desc_estado.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txt_cod_estado.Text = String.Empty
        txt_desc_estado.Text = String.Empty
        txt_cod_estado.Enabled = Not CheckBox1.Checked
        txt_desc_estado.Enabled = Not CheckBox1.Checked
    End Sub

    Private Sub chk_todos_forma_pago_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos_forma_pago.CheckedChanged
        If chk_todos_forma_pago.Checked Then
            ActivarCheck(True, chk_list_forma_pago)
            chk_list_forma_pago.Enabled = False
        Else
            ActivarCheck(False, chk_list_forma_pago)
            chk_list_forma_pago.Enabled = True
        End If
    End Sub
    Sub ActivarCheck(ByVal opcion As Boolean, ByVal _lista As CheckedListBox)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= _lista.Items.Count - 1
                _lista.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= _lista.Items.Count - 1
                _lista.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub chk_vendedor_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vendedor.CheckedChanged
        If chk_vendedor.Checked Then
            ActivarCheck(True, chk_list_vendedor)
            chk_list_vendedor.Enabled = False
        Else
            ActivarCheck(False, chk_list_vendedor)
            chk_list_vendedor.Enabled = True
        End If
    End Sub

    Private Sub chk_series_CheckedChanged(sender As Object, e As EventArgs) Handles chk_series.CheckedChanged
        If chk_series.Checked Then
            ActivarCheck(True, chk_list_series)
            chk_list_series.Enabled = False
        Else
            ActivarCheck(False, chk_list_series)
            chk_list_series.Enabled = True
        End If
    End Sub
End Class